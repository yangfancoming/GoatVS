using System.IO;

namespace chapter3_5_2 {


    public class FileUtil {

        // @"C:\Users\Administrator\Desktop\123\xml2.xml"
        public static void deleteFile1(string fileToBeDeleted) {
            var file = new FileInfo(fileToBeDeleted);
            if (file.Exists) file.Delete();
        }

        // @"C:\Users\Administrator\Desktop\123\xml2.xml"
       public static void deleteFile2(string fileToBeDeleted) {
           if (File.Exists(fileToBeDeleted)) File.Delete(fileToBeDeleted);
        }

    }
}