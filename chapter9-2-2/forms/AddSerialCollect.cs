using System;
using System.Windows.Forms;

namespace chapter9_2_2.forms {
    public partial class AddSerialCollect : Form {
        public AddSerialCollect() {
            InitializeComponent();
        }

        private void btnEsc_Click(object sender, EventArgs e) {
            Close();
        }
    }
}