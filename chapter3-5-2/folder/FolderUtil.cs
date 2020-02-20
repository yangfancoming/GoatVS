using System.IO;

namespace chapter3_5_2 {


    public static class FolderUtil {

        // @"C:\Users\Administrator\Desktop\123"
        public static void deleteFolder1(string folderToBeDeleted) {
            var folder = new DirectoryInfo(folderToBeDeleted);
            if (folder.Exists) folder.Delete(true);
        }

        // @"C:\Users\Administrator\Desktop\123"
       public static void deleteFolder2(string folderToBeDeleted) {
           if (Directory.Exists(folderToBeDeleted)) Directory.Delete(folderToBeDeleted,true);
        }

    }
}