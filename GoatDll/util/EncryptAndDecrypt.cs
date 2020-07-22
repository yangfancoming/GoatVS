using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// treeView树节点用


namespace GoatTools
{
    public class EncryptAndDecrypt
    {

        public static byte[] Encrypt(byte[] inputByteArray, byte[] key)//加密
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            des.Key = key;
            des.IV = key;
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.None;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return ms.ToArray();
        }
        public static byte[] Decrypt(byte[] inputByteArray, byte[] sKey)  //解密
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            des.Key = sKey;
            des.IV = sKey;
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.None;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return ms.ToArray();
        }

        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };//默认密钥向量
        public static string EncryptDES(string encryptString, string encryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }
        public static string DecryptDES(string decryptString, string decryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return decryptString;
            }
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
