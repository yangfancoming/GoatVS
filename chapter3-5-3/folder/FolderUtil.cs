using System;
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

       public static bool CopyDirectory(string SourcePath, string DestinationPath, bool mark)  {
           bool ret;
           try  {
               if (!Directory.Exists(SourcePath)) return false;

               if (!Directory.Exists(DestinationPath))
                   Directory.CreateDirectory(DestinationPath);

                   foreach (var fls in Directory.GetFiles(SourcePath)) {
                       var file = new FileInfo(fls);
                       file.CopyTo(DestinationPath + file.Name, mark);
                   }
                   foreach (var drs in Directory.GetDirectories(SourcePath)){
                       var dirInfo = new DirectoryInfo(drs);
                       if (CopyDirectory(drs, DestinationPath + dirInfo.Name, mark) == false)
                           return  false;
                   }
               ret = true;
           }
           catch (Exception ex)  {
               ret = false;
           }
           return ret;
       }

//       if (!Directory.Exists(strpatj+"\\temp"))
//       Directory.CreateDirectory(strpatj + "\\temp");
    }
}