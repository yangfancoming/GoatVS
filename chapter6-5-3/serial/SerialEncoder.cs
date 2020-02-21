using System.Diagnostics;
using Mina.Core.Buffer;
using Mina.Core.Session;
using Mina.Filter.Codec;

namespace chapter6_5_2 {


    public class SerialEncoder:ProtocolEncoderAdapter{


        public override void Encode(IoSession session, object message, IProtocolEncoderOutput output) {
            Debug.Print($" 发送数据 :{message}");
            var bytes = (byte[])message;
            var ioBuffer = IoBuffer.Allocate(bytes.Length);
            ioBuffer.Put(bytes);
            ioBuffer.Flip();
            output.Write(ioBuffer);
            output.Flush();
        }
    }
}