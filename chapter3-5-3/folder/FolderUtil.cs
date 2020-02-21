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

       // 将指定目录中的所有文件  拷贝到 另一个目录中   如果目的目录中已经存在 是否覆盖。
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
           catch (Exception)  {
               ret = false;
           }
           return ret;
       }

       //递归删除目录下所有文件
       public static bool DeleteDir(string file) {
           bool mark = false;
           try {
               //判断文件夹是否还存在
               if (!Directory.Exists(file)) return mark;
               //去除文件的只读属性
               File.SetAttributes(file, FileAttributes.Normal);
               foreach (var f in Directory.GetFileSystemEntries(file)){
                   if (File.Exists(f)){
                       File.Delete(f); //如果有子文件删除文件
                   }
                   else{
                       DeleteDir(f);//循环递归删除子文件夹
                   }
               }
               //删除空文件夹
               Directory.Delete(file);
               return true;
           }
           catch (Exception){ // 异常处理
               return false;
           }
       }
    }
}