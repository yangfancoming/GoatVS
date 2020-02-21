using System;
using Mina.Core.Session;
using Mina.Filter.Codec;

namespace chapter6_5_2 {


    public class SerialEncoder:ProtocolEncoderAdapter{


        public override void Encode(IoSession session, object message, IProtocolEncoderOutput output) {
            Console.WriteLine("DoDecode");

        }
    }
}