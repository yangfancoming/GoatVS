using Amazon;
using Amazon.S3;

namespace chapter1_9_2 {


    public class MyAmazonS3Client {

        private static readonly MyAmazonS3Client  _singleton = new MyAmazonS3Client();

        private static AmazonS3Client _amazonS3Client;
        private MyAmazonS3Client() {
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                ServiceURL = "http://192.168.211.128:9000",
                ForcePathStyle = true
            };
            _amazonS3Client = new AmazonS3Client("minioadmin", "minioadmin", config);
        }

        public static AmazonS3Client getInstance() {
            return _amazonS3Client;
        }

//        public static AmazonS3Client getInstance(string regionEndpoint,string serviceURL,string accessKey,string secretKey) {
//            _singleton.regionEndpoint = regionEndpoint;
//            _singleton.serviceURL = serviceURL;
//            _singleton.accessKey = accessKey;
//            _singleton.secretKey = secretKey;
//            return _amazonS3Client;
//        }

        // ftp 地址   ftp://192.168.211.128/
//        public string regionEndpoint = "";
//
//        // ftp 端口  21
//        public string serviceURL { get; set; }
//
//        // ftp 账号  test
//        public string accessKey { get; set; }
//
//        // ftp 密码  test
//        public string secretKey { get; set; }
    }
}