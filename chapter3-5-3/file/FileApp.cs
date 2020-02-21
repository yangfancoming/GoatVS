using System.IO;

namespace chapter3_5_2 {


    public class FileApp {

        private static readonly string filePath = @"C:\Users\Administrator\Desktop\123\xml2.xml";

        public static void test1() {
            FileUtil.deleteFile1(filePath);
        }

        public static void test2() {
            FileUtil.deleteFile2(filePath);
        }

//       string fileToMove = @"c:\temp\New Text Document.txt";
//       string fileNewDestination = @"c:\temp\test.txt";
        private static readonly string source =  @"C:\Users\Administrator\Desktop\123\json1.json";
        public static void test3() {
            FileUtil.MoveFile1(source,filePath);
        }

    }
}