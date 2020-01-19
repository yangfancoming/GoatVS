namespace chapter9_2_2.model {


    public class FileJob :JobInfor {

        // 文件所在目录
        private string fileDirectory ;

        public string 所在目录{
            get => fileDirectory ;
            set => fileDirectory  = value;
        }

        // 文件匹配条件
        private string fileMatched ;

        public string 匹配条件{
            get => fileMatched ;
            set => fileMatched  = value;
        }

        // 文件后缀名
        private string fileSuffix;

        public string 文件类型{
            get => fileSuffix;
            set => fileSuffix = value;
        }


    }
}