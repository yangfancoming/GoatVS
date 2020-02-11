using System;

namespace chapter7_1_2.uilog {

    public class UiLogEventArgs : EventArgs{

        public string Message { get; }

        public UiLogEventArgs(string message){
            Message = message;
        }
    }

}