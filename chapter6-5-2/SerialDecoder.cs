using System;
using Mina.Core.Buffer;
using Mina.Core.Session;
using Mina.Filter.Codec;

namespace chapter6_5_2 {


    public class SerialDecoder:CumulativeProtocolDecoder {

        protected override bool DoDecode(IoSession session, IoBuffer input, IProtocolDecoderOutput output) {
            Console.WriteLine("DoDecode");
            return true;
        }
    }
}