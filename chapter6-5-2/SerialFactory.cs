using System;
using Mina.Core.Session;
using Mina.Filter.Codec;

namespace chapter6_5_2 {


    public class SerialFactory: IProtocolCodecFactory {

        private static SerialEncoder _serialEncoder;
        private static SerialDecoder _serialDecoder;


        public SerialFactory() {
            _serialEncoder = new SerialEncoder();
            _serialDecoder = new SerialDecoder();
        }

        public IProtocolEncoder GetEncoder(IoSession session) {
            Console.WriteLine("GetEncoder");
            return _serialEncoder;
        }

        public IProtocolDecoder GetDecoder(IoSession session) {
            Console.WriteLine("GetDecoder");
            return _serialDecoder;
        }
    }
}