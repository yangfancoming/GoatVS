namespace datacollect.model {

    // 饿汉式单例
    public class FtpSettings {

        private static readonly FtpSettings  _singleton = new FtpSettings();//1
        private FtpSettings() {}  //2

        public static FtpSettings getInstance() { //3
            return _singleton;
        }
//
//
//
//        static FtpSettings(){
//            Instance = new FtpSettings();
//        }
//        private FtpSettings(){ }
//
//        public static FtpSettings Instance() {
//
//        }

        // ftp 地址   ftp://192.168.211.128/
        // ftp 端口  21
        // ftp 账号  test
        // ftp 密码  test


        public string TbFtpAddr { get; set; }

        public string TbFtpPort { get; set; }

        public string TbFtpAccount { get; set; }

        public string TbFtpPassword { get; set; }
    }
}