using System.Security.Cryptography;
using System.Text;

namespace GoatTools {


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
//            string returnData = DataTypeTransmit.ByteArr2hexStr(encryptdata);// 968e1c0d53182df8bf3a550d2f4c60d1
            string returnData = DataTypeTransmit.ByteArr2hexStrV2(encryptdata);// 968E1C0D53182DF8BF3A550D2F4C60D1
            return returnData;
        }

    }
}