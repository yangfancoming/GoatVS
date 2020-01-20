using System.Windows.Forms;

namespace chapter9_2_2.forms {
    public partial class Settings : Form {
        public Settings() {
            InitializeComponent();
        }

        private void btnEsc_Click(object sender, System.EventArgs e) {
            Close();
        }
    }
}