using System;
using System.Windows.Forms;

namespace chapter3_4_1 {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        // 任务1
        private void button1_Click(object sender, EventArgs e) {
            Util.Run1().GetAwaiter().GetResult();
        }

        private void button4_Click(object sender, EventArgs e) {
            Util.Stop1().GetAwaiter().GetResult();
        }

        // 任务1
        private void button2_Click(object sender, EventArgs e) {
            Util.Run2().GetAwaiter().GetResult();
        }
        private void button5_Click(object sender, EventArgs e) {
            Util.Stop2().GetAwaiter().GetResult();
        }

        // 任务3
        private void button3_Click(object sender, EventArgs e) {
            Util.Run3().GetAwaiter().GetResult();
        }

        private void button6_Click(object sender, EventArgs e) {
            Util.Stop3().GetAwaiter().GetResult();
        }
    }
}