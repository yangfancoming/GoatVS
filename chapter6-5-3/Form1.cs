using System;
using System.IO.Ports;
using System.Windows.Forms;
using chapter6_5_3.serial;

namespace chapter6_5_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MinaClient.init("COM1",9600,Parity.None, 8, StopBits.One);
        }

        private void button2_Click(object sender, EventArgs e) {
            MinaClient.close();
        }
    }
}