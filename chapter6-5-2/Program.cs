using System.Diagnostics;
using GoatTools;

namespace chapter6_5_2 {

    internal class Program {

        public static void Main(string[] args) {
            string temp = "A1BC";
            byte[] bytes = DataTypeTransmit.StringToByteArrayV2(temp);
            Debug.Print(bytes.Length.ToString());
            string result = DataTypeTransmit.ByteArr2hexStrV2(bytes);
            Debug.Print(result);
        }
    }
}