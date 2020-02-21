using System;
using System.Diagnostics;
using Mina.Core.Service;
using Mina.Core.Session;

namespace chapter6_5_2 {

    public class ServerHandler:IoHandler {

        public void SessionCreated(IoSession session) {
            Debug.Print("SessionCreated");
        }

        public void SessionOpened(IoSession session) {
          Debug.Print("SessionOpened");
        }

        public void SessionClosed(IoSession session) {
          Debug.Print("SessionClosed");
        }

        public void SessionIdle(IoSession session, IdleStatus status) {
          Debug.Print("SessionIdle");
        }

        public void ExceptionCaught(IoSession session, Exception cause) {
          Debug.Print("ExceptionCaught");
        }

        public void MessageReceived(IoSession session, object message) {
          Debug.Print("MessageReceived");
        }

        public void MessageSent(IoSession session, object message) {
          Debug.Print("MessageSent");
        }

        public void InputClosed(IoSession session) {
          Debug.Print("InputClosed");
        }
    }
}