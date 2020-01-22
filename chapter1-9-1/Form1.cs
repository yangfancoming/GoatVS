using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace chapter1_9_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            using (StreamWriter sw = new StreamWriter(@"F:\123\YYYest.txt",true,Encoding.UTF8)) {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("");
                sw.Close();
            }
        }
    }
}