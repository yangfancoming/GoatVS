using System.Diagnostics;

namespace chapter3_5_2 {


    public class FolderApp {

        private static readonly string folderPath = @"C:\Users\Administrator\Desktop\444";

        public static void test1() {
            FolderUtil.deleteFolder1(folderPath);
        }

        public static void test2() {
            FolderUtil.deleteFolder2(folderPath);
        }

        private static readonly string source =  @"C:\Users\Administrator\Desktop\123\444\";
        private static readonly string target =  @"E:\Code\C#_code\RiderLearning\GoatVS\chapter3-5-3\bin\Debug\ec0f0f1afc004dd98f074f1d409de5c5\";

        public static void test3() {
            var mark = FolderUtil.CopyDirectory(source,target,true);
            Debug.Print(mark.ToString());
        }

        public static void test4() {
            FolderUtil.DeleteDir(target);
        }


    }
}