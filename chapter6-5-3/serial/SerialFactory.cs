using Mina.Core.Session;
using Mina.Filter.Codec;

namespace chapter6_5_2 {


    public class SerialFactory: IProtocolCodecFactory {

        private static SerialDecoder _serialDecoder;

        private static SerialEncoder _serialEncoder;

        public SerialFactory() {
            _serialDecoder = new SerialDecoder();
            _serialEncoder = new SerialEncoder();

        }

        public IProtocolDecoder GetDecoder(IoSession session) {
            return _serialDecoder;
        }

        public IProtocolEncoder GetEncoder(IoSession session) {
            return _serialEncoder;
        }

    }
}