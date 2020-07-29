using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter1_9_8 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            CancellationTokenSource token = new CancellationTokenSource();
            HttpUtil.Listen("http://localhost:41000/hello/", 2, token.Token);
//            token.Cancel();
        }

        private void button2_Click(object sender, EventArgs e) {
            HttpUtil.StopListen();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CancellationTokenSource token = new CancellationTokenSource();
            Task t = HttpUtil.Listen("http://localhost:41000/hello/", 2, token.Token);
//            token.Cancel();
        }
    }
}