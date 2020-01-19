namespace chapter9_2_2.model {


    public class FileJob :JobInfor {

        // 文件所在目录
        public string fileDirectory ;

        // 文件名匹配条件
        public string fileMatched ;

        // 文件后缀名
        public string fileSuffix;

        public string 所在目录 {
            get => fileDirectory;
            set => fileDirectory = value;
        }

        public string 匹配条件 {
            get => fileMatched;
            set => fileMatched = value;
        }

        public string 文件后缀 {
            get => fileSuffix;
            set => fileSuffix = value;
        }
    }
}