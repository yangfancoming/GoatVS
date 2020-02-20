namespace chapter3_5_2 {


    public class FolderApp {

        private static readonly string folderPath = @"C:\Users\Administrator\Desktop\444";

        public static void test1() {
            FolderUtil.deleteFolder1(folderPath);
        }

        public static void test2() {
            FolderUtil.deleteFolder2(folderPath);
        }


    }
}