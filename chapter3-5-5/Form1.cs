using System;
using System.Windows.Forms;

namespace chapter3_5_5 {

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            FileSystemWatcher1.initWatcher(@"D:\123");
        }

        private void button1_Click(object sender, EventArgs e) {
            FileSystemWatcher1.startWatcher();
        }

        private void button2_Click(object sender, EventArgs e) {
            FileSystemWatcher1.stopWatcher();
        }
    }
}