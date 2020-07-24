using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using GoatTools;
using Newtonsoft.Json;
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


        }

        private static RSAParameters ParsePublicKey(string publicKey){
            using (var reader = new StringReader(publicKey)){
                var pemReader = new PemReader(reader);
                var key = (RsaKeyParameters)pemReader.ReadObject();
                var parameter = new RSAParameters{
                    Modulus = key.Modulus.ToByteArrayUnsigned(),
                    Exponent = key.Exponent.ToByteArrayUnsigned()
                };
                return parameter;
            }
        }

        public bool Verify(byte[] bytes, byte[] signature, string publicKey){
            using (var rsa = new RSACryptoServiceProvider()){
                var key = ParsePublicKey(publicKey);
                rsa.ImportParameters(key);
                return rsa.VerifyData(bytes, new SHA256CryptoServiceProvider(), signature);  // MD5CryptoServiceProvider()
            }
        }

        public byte[] Sign(byte[] bytes, string privateKey){
            using (var rsa = new RSACryptoServiceProvider()){
                var key = ParsePrivateKey(privateKey);
                rsa.ImportParameters(key);
                var signature = rsa.SignData(bytes, new SHA256CryptoServiceProvider());  // MD5CryptoServiceProvider()
                return signature;
            }
        }

        private static RSAParameters ParsePrivateKey(string privateKey){
            using (var reader = new StringReader(privateKey)){
                var pemReader = new PemReader(reader);
                var key = (RsaPrivateCrtKeyParameters)pemReader.ReadObject();
                var parameter = new RSAParameters{
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

        // 加密
        private void btn_jiami_Click(object sender, EventArgs e) {
            string key = Md5Util.encrypt(tb_miyao.Text.Trim());
            var aesDecryptEcb = EncryptAndDecrypt.AesEncrypt_ECB(tb_3.Text,key);
            tb_4.Text = aesDecryptEcb;
        }

        // 解密
        private void btn_jiemi_Click(object sender, EventArgs e) {
            string key = Md5Util.encrypt(tb_miyao.Text.Trim());
            var aesDecryptEcb = EncryptAndDecrypt.AesDecrypt_ECB(tb_4.Text,key);
            tb_3.Text = aesDecryptEcb;
        }

        // 验签
        private void btn_yanqian_Click(object sender, EventArgs e) {
            string json = tb_json.Text.Trim();
            Model result = JsonConvert.DeserializeObject<Model>(json);
            Debug.Print(result.body);
            Debug.Print(result.timestamp);
            Debug.Print(result.sign);

            // 验签1
            string PublicKey = tb_public.Text; // 公钥
            byte[] sign = Convert.FromBase64String(result.sign);
            byte[] bytes = Encoding.Default.GetBytes(result.timestamp + result.body);// 文本
            var isVerified = Verify(bytes, sign,PublicKey);
            Debug.Print("Text:{0}, signature:{1}, is verified:{2}", result.timestamp + result.body, sign, isVerified);

        }


        // 加签
        private void btn_jiaqian_Click(object sender, EventArgs e) {
            string json = tb_json.Text.Trim();
            Model result = JsonConvert.DeserializeObject<Model>(json);
            Debug.Print(result.body);
            Debug.Print(result.timestamp);
            Debug.Print(result.sign);
            byte[] bytes = Encoding.Default.GetBytes(result.timestamp + result.body);// 文本
            var sign = Sign(bytes,tb_private.Text.Trim());
            Debug.Print(sign.ToString());

            string PublicKey = tb_public.Text; // 公钥
            var isVerified = Verify(bytes, sign,PublicKey);
            Debug.Print(isVerified.ToString());
        }
    }
}