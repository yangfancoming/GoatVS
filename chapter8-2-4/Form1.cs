using System;
using System.Linq;
using System.Windows.Forms;
using chapter8_2_4.util;

namespace chapter8_2_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            comboBox1.initComboBox((new[]{"xml","csv","xls"}).ToList());
        }
    }
}