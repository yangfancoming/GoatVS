using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
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
//            // 加签
//            string privateKey = tb_private.Text;
//            string text = "123";
//            var bytes = Encoding.UTF8.GetBytes(text);
//            var signatureBytes = Sign(bytes, privateKey);
//            var signature =   Convert.ToBase64String(signatureBytes);
//            Debug.Print("Text:{0}, signature:{1}", text, signature);
//
//            // 验签
//            string PublicKey = tb_public.Text;
//            var fromBase64String = Convert.FromBase64String(signature);
//            var isVerified = Verify(bytes, fromBase64String,PublicKey);
//            Debug.Print("Text:{0}, signature:{1}, is verified:{2}", text, signature, isVerified);
        }

        private static RSAParameters ParsePublicKey(string publicKey){
            using (var reader = new StringReader(publicKey)){
                var pemReader = new PemReader(reader);
                var key = (RsaKeyParameters)pemReader.ReadObject();// 如果key为null 则可能是由于公钥私钥格式错误导致！
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
                var key = (RsaPrivateCrtKeyParameters)pemReader.ReadObject(); // 如果key为null 则可能是由于公钥私钥格式错误导致！
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
            string key = Md5Util.encrypt(tb_miyao.Text.Trim());// 968E1C0D53182DF8BF3A550D2F4C60D1
            var aesDecryptEcb = EncryptAndDecrypt.AesDecrypt_ECB(tb_4.Text,key);
            tb_3.Text = aesDecryptEcb;
        }

        // 验签
        private void btn_yanqian_Click(object sender, EventArgs e) {
            string json = tb_json.Text.Trim();
            Model model = JsonConvert.DeserializeObject<Model>(json);
            Debug.Print(model.body);
            Debug.Print(model.timestamp);
            Debug.Print(model.sign);

            // 验签1
            string PublicKey = FormatPublicKey(tb_public.Text.Trim()); // 公钥
            byte[] sign = Convert.FromBase64String(model.sign);
            byte[] bytes = Encoding.Default.GetBytes(model.timestamp + model.body);// 文本
            var isVerified = Verify(bytes, sign,PublicKey);
            Debug.Print("Text:{0}, signature:{1}, is verified:{2}", model.timestamp + model.body, sign, isVerified);
            string result = isVerified ? "验签通过！" : "验签失败！";
            tb_result.Text = result;
        }

        // pem格式的公钥和私钥 需要增加相应的前后缀
        private string FormatPublicKey(string PublicKey) {
            string prefix = "-----BEGIN PUBLIC KEY-----\n";
            string suffix = "-----END PUBLIC KEY-----";
            return prefix + PublicKey + "\n" + suffix;
        }

        private string FormatPrivateKey(string PrivateKey) {
            string prefix = "-----BEGIN PRIVATE KEY-----\n";
            string suffix = "-----END PRIVATE KEY-----";
            return prefix + PrivateKey + "\n" + suffix;
        }

        // 加签
        private void btn_jiaqian_Click(object sender, EventArgs e) {
            string json = tb_json.Text.Trim();
            Model result = JsonConvert.DeserializeObject<Model>(json);
            Debug.Print(result.body);
            Debug.Print(result.timestamp);
            Debug.Print(result.sign);
            byte[] bytes = Encoding.Default.GetBytes(result.timestamp + result.body);// 文本
            byte[] sign = Sign(bytes,FormatPrivateKey(tb_private.Text.Trim()));
            string base64String = Convert.ToBase64String(sign);
            Debug.Print(base64String);
            tb_result.Text = base64String;
            string PublicKey =  FormatPublicKey(tb_public.Text.Trim()); // 公钥
            var isVerified = Verify(bytes, sign,PublicKey);
            Debug.Print(isVerified.ToString());

        }
    }
}