using System;
using System.Windows.Forms;

namespace chapter9_2_2.constant {

    public static class Actions {

        public static readonly Action<TextBox,string> test  = (textBox,text) => textBox.Text = text;
    }
}