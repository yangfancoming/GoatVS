using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using GoatTools;

namespace chapter2_0_3 {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            cb_type.Items.Add("AES");
            cb_type.Items.Add("DES");
            cb_type.SelectedIndex = 0;

            tb_miyao.Text = "E2CGvNlxsXK7SX69";
            tb_3.Text = ""; // 明文
            tb_4.Text = "D64P7737YA4LMNBHZAxazAQEBpkqQrOszH/SnpIo1DVdNZ1Eo5PBTGfhm2dTkDlY"; // 密文
        }
        private void btn_md5_Click(object sender, EventArgs e) {
            string key = Md5Util.encrypt("E2CGvNlxsXK7SX69");
            byte[] bytes = Encoding.Default.GetBytes(key.ToLower());
            Debug.Print(key);
            var aesDecryptEcb = EncryptAndDecrypt.AesDecrypt_ECB("D64P7737YA4LMNBHZAxazAQEBpkqQrOszH/SnpIo1DVdNZ1Eo5PBTGfhm2dTkDlY",key);
            Debug.Print(aesDecryptEcb);
        }


        private void btn_jiami_Click(object sender, EventArgs e) {
            string key = Md5Util.encrypt(tb_miyao.Text.Trim());
            var aesDecryptEcb = EncryptAndDecrypt.AesEncrypt_ECB(tb_3.Text,key);
            tb_4.Text = aesDecryptEcb;
        }

        private void btn_jiemi_Click(object sender, EventArgs e) {
            string key = Md5Util.encrypt(tb_miyao.Text.Trim());
            var aesDecryptEcb = EncryptAndDecrypt.AesDecrypt_ECB(tb_4.Text,key);
            tb_3.Text = aesDecryptEcb;
        }
    }
}