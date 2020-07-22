using System;
using System.Security.Cryptography;
using System.Text;
using GoatTools;

namespace chapter2_0_3 {


    public class Md5Util {

        /// <summary>
        /// 对字符串进MD5加密
        /// </summary>
        /// <param name="sourceStr">源类型</param>
        /// <returns>加密后字符串</returns>
        public static string encrypt(string sourceStr){
            MD5 md5 = new MD5CryptoServiceProvider();
            //将要加密的字符串转换成字节数组
            byte[] palindata = Encoding.Default.GetBytes(sourceStr);
            //通过字节数组进行加密
            byte[] encryptdata = md5.ComputeHash(palindata);
            //将加密后的字节数组转换成字符串
//            string returnData = Convert.ToBase64String(encryptdata);
            string returnData = DataTypeTransmit.ByteArr2hexStr(encryptdata);
            return returnData;
        }

    }
}