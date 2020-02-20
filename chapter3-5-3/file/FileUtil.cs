using System.IO;

namespace chapter3_5_2 {


    public static class FileUtil {

        // @"C:\Users\Administrator\Desktop\123\xml2.xml"
        public static void deleteFile1(string fileToBeDeleted) {
            var file = new FileInfo(fileToBeDeleted);
            if (file.Exists) file.Delete();
        }

        // @"C:\Users\Administrator\Desktop\123\xml2.xml"
       public static void deleteFile2(string fileToBeDeleted) {
           if (File.Exists(fileToBeDeleted)) File.Delete(fileToBeDeleted);
        }


       public static void MoveFile1(string source,string target){
           if (File.Exists(source) && !File.Exists(target)) {
               File.Move(source, target);
           }
       }

       public static void MoveFile2(string source,string target){
           var file = new FileInfo(source);
           if (file.Exists)  file.MoveTo(target);
       }

    }
}