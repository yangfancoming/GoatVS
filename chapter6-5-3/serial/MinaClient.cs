using System;
using System.Diagnostics;
using System.IO.Ports;
using chapter6_5_2;
using Mina.Core.Future;
using Mina.Core.Service;
using Mina.Filter.Codec;
using Mina.Filter.Logging;
using Mina.Transport.Serial;

namespace chapter6_5_3.serial {


    public static class MinaClient {


        private static readonly IoConnector serial = new SerialConnector();
        private static IConnectFuture future;

        static MinaClient() {
            serial.ExceptionCaught += (s, e) => {
                e.Session.Close(true);
                Debug.Print($"出现异常 Session 关闭：{e.Exception.Message}");
    
            };
            serial.MessageReceived += (s, e) =>{
                Debug.Print($"接收到消息：{e.Message}");
            };
            
            serial.SessionIdle += (session, status) => Debug.Print($"SessionIdle {status.IdleStatus}");
            serial.SessionClosed += (session, status) => Debug.Print($"SessionClosed {status.Session}");
            serial.SessionOpened += (session, status) => Debug.Print($"SessionOpened {status.Session}");
            serial.SessionCreated += (session, status) => Debug.Print($"SessionCreated {status.Session}");
            serial.MessageSent += (session, message) => Debug.Print($"MessageSent {message.Message}");
            serial.InputClosed += (session, status) => Debug.Print($"InputClosed {status.Session}");

            serial.FilterChain.AddLast("logger", new LoggingFilter());
            serial.FilterChain.AddLast("codec", new ProtocolCodecFilter(new SerialFactory()));
//            serial.SessionConfig.SetIdleTime(IdleStatus.BothIdle,60);
        }

        public static void init(string portName,int baudRate,Parity parity,int dataBits,StopBits stopBits) {
            try {
                var serialEP = new SerialEndPoint(portName, baudRate,parity,dataBits,stopBits);
                future = serial.Connect(serialEP);
                future.Await();
                Debug.Print($"打开串口成功！");
            } catch (Exception e) {
                Debug.Print($"打开串口失败，原因：{e.Message}");
            }
        }

        public static void close() {
            future.Session.Close(true);
            Debug.Print($"关闭串口成功！");
        }

    }
}