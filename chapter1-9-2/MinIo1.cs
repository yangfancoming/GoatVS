using System;
using System.Threading.Tasks;
using Minio;
using Minio.DataModel;


namespace chapter1_9_2 {

    public class MinIo1 {

        // Initialize the client with access credentials.
        private static MinioClient minioClient = new MinioClient("192.168.211.128:9000","minioadmin","minioadmin" );

        public static void test1() {
            // Create an async task for listing buckets.
            Task<ListAllMyBucketsResult> getListBucketsTask = minioClient.ListBucketsAsync();
            // Iterate over the list of buckets.
            foreach (Bucket bucket in getListBucketsTask.Result.Buckets) {
                Console.WriteLine(bucket.Name + " " + bucket.CreationDateDateTime);
            }

        }


        public static void test2() {
            Run(minioClient).Wait();
        }

        // File uploader task.
        private static async Task Run(MinioClient minio) {
            var bucketName = "mymusic"; // 桶的名称
            var location   = "us-east-1"; //服务器区域
            var objectName = "golden-oldies.zip"; // 上传后文件名
            var filePath = "D:\\123\\12.txt"; // 本地 待上传文件
            var contentType = "application/zip"; // 上传后的文件格式

            // Make a bucket on the server, if not already present.
            bool found = await minio.BucketExistsAsync(bucketName);
            if (!found) {
                await minio.MakeBucketAsync(bucketName, location);
            }
            // Upload a file to bucket.
            await minio.PutObjectAsync(bucketName, objectName, filePath, contentType);
            Console.WriteLine("Successfully uploaded " + objectName );
        }

    }
}