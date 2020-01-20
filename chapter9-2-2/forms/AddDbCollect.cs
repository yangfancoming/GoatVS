using System;
using System.Windows.Forms;
using chapter9_2_2.constant;

namespace chapter9_2_2.forms {
    public partial class AddDbCollect : Form {
        public AddDbCollect() {
            InitializeComponent();
            cbox_dbType.DataSource = Enum.GetNames(typeof(DatabaseType));
        }

        private void btnSave_Click(object sender, EventArgs e) {

        }

        private void btnEsc_Click(object sender, EventArgs e) {
            Close();
        }
    }
}