using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using GoatTools;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;

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

            // 加签
            string privateKey = tb_3.Text;
            string text = "123";
            var bytes = Encoding.UTF8.GetBytes(text);
            var signatureBytes = Sign(bytes, privateKey);
            var signature =   Convert.ToBase64String(signatureBytes);
            Debug.Print("Text:{0}, signature:{1}", text, signature);

            // 验签
            string PublicKey = tb_4.Text;
            var fromBase64String = Convert.FromBase64String(signature);
            var isVerified = Verify(bytes, fromBase64String,PublicKey);
            Debug.Print("Text:{0}, signature:{1}, is verified:{2}", text, signature, isVerified);
        }

        private static RSAParameters ParsePublicKey(string publicKey)
        {
            using (var reader = new StringReader(publicKey))
            {
                var pemReader = new PemReader(reader);
                var key = (RsaKeyParameters)pemReader.ReadObject();

                var parameter = new RSAParameters
                {
                    Modulus = key.Modulus.ToByteArrayUnsigned(),
                    Exponent = key.Exponent.ToByteArrayUnsigned()
                };

                return parameter;
            }
        }

        public bool Verify(byte[] bytes, byte[] signature, string publicKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                var key = ParsePublicKey(publicKey);
                rsa.ImportParameters(key);
                return rsa.VerifyData(bytes, new MD5CryptoServiceProvider(), signature);
            }
        }

        public byte[] Sign(byte[] bytes, string privateKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                var key = ParsePrivateKey(privateKey);
                rsa.ImportParameters(key);
                var signature = rsa.SignData(bytes, new MD5CryptoServiceProvider());
                return signature;
            }
        }

        private static RSAParameters ParsePrivateKey(string privateKey)
        {
            using (var reader = new StringReader(privateKey))
            {
                var pemReader = new PemReader(reader);
                var key = (RsaPrivateCrtKeyParameters)pemReader.ReadObject();
                var parameter = new RSAParameters
                {
                    Modulus = key.Modulus.ToByteArrayUnsigned(),
                    Exponent = key.PublicExponent.ToByteArrayUnsigned(),
                    D = key.Exponent.ToByteArrayUnsigned(),
                    P = key.P.ToByteArrayUnsigned(),
                    Q = key.Q.ToByteArrayUnsigned(),
                    DP = key.DP.ToByteArrayUnsigned(),
                    DQ = key.DQ.ToByteArrayUnsigned(),
                    InverseQ = key.QInv.ToByteArrayUnsigned()
                };
                return parameter;
            }
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