using System;
using System.IO.Ports;
using Mina.Core.Future;
using Mina.Core.Service;
using Mina.Filter.Codec;
using Mina.Filter.Logging;
using Mina.Transport.Serial;

namespace chapter6_5_2 {


    public class App {


        public static void test1() {
            // create your connector
            IoConnector connector = new SerialConnector();
            connector.ExceptionCaught += (session, ex) => ex.Session.Close(true);
            connector.MessageReceived += (session, message) => Console.WriteLine(message.Message);
            connector.SessionIdle += (session, status) => Console.WriteLine(status.IdleStatus);
            connector.SessionClosed += (session, status) => Console.WriteLine(status.Session);
            connector.SessionOpened += (session, status) => Console.WriteLine(status.Session);
            connector.SessionCreated += (session, status) => Console.WriteLine(status.Session);
            connector.MessageSent += (session, message) => Console.WriteLine(message.Message);
            connector.InputClosed += (session, status) => Console.WriteLine(status.Session);

            // Add two filters : a logger and a codec
            connector.FilterChain.AddLast("logger", new LoggingFilter());
            connector.FilterChain.AddLast("codec", new ProtocolCodecFilter(new SerialFactory()));
//            connector.SessionConfig.SetIdleTime(IdleStatus.BothIdle,60);

            SerialEndPoint serialEP = new SerialEndPoint("COM1", 9600,Parity.None,8,StopBits.One);
            IConnectFuture future = connector.Connect(serialEP);
            future.Await();

            if (future.Connected)
            {
                while (true)
                {
                    String line = Console.ReadLine();
                    if (line.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
                    {
                        future.Session.Close(true);
                        break;
                    }
                    future.Session.Write(line);
                }
            }
            else if (future.Exception != null)
            {
                Console.WriteLine(future.Exception);
            }

            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }

    }
}