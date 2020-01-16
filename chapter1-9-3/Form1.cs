using System;
using System.Windows.Forms;

namespace chapter1_9_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        string host = "ftp://192.168.211.128/";
        private void button1_Click(object sender, EventArgs e) {
            Ftp1.UploadFile(host,"test","test","D:\\123\\2222\\123.txt");
        }

        private void button2_Click(object sender, EventArgs e) {
            Ftp1.DownloadFile(host,"test","test","D:\\123\\2222\\222.txt","/123.txt");
        }
    }
}