using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace chapter2_0_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_md5_Click(object sender, EventArgs e) {
            string key = Md5Util.encrypt("E2CGvNlxsXK7SX69");
            byte[] bytes = Encoding.Default.GetBytes(key.ToLower());
            Debug.Print(key);
            var aesDecryptEcb = AesDecrypt_ECB("",key);
            Debug.Print(aesDecryptEcb);
        }

        public static string AesDecrypt_ECB(string str, string key){
            if (string.IsNullOrEmpty(str)){
                return null;
            }
            int keyLength = key.Length;
            if (keyLength != 16 && keyLength != 24 && keyLength != 32){
                return null;
            }
            byte[] toDecryptArray = Convert.FromBase64String(str);
            RijndaelManaged rm = new RijndaelManaged{
                Key = Encoding.UTF8.GetBytes(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = rm.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }



        public static string AesEncrypt_ECB(string str, string key){
            if (string.IsNullOrEmpty(str)){
                return null;
            }
            int keyLength = key.Length;
            if (keyLength != 16 && keyLength != 24 && keyLength != 32){
                return null;
            }
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(str);
            RijndaelManaged rijndaelManaged = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = rijndaelManaged.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
    }
}