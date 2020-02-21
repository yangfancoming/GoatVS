using System.Diagnostics;
using Mina.Core.Buffer;
using Mina.Core.Session;
using Mina.Filter.Codec;

namespace chapter6_5_2 {


    public class SerialDecoder:CumulativeProtocolDecoder {

        protected override bool DoDecode(IoSession session, IoBuffer input, IProtocolDecoderOutput output) {
            var arraySegment = input.GetRemaining();
            Debug.Print($" 待解码字节数 :{arraySegment.Count}");
            var test = new byte[arraySegment.Count];
            input.Get(test, 0, input.Remaining);
            output.Write(test);
            return true;
        }
    }
}