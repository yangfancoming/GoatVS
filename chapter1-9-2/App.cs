using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;

namespace chapter1_9_2 {

    public static class App {

        // 使用 AmazonS3Client 遍历 桶
        public static async void test() {
            AmazonS3Client amazonS3Client = MyAmazonS3Client.getInstance();
            var listBuckets = await amazonS3Client.ListBucketsAsync();
            foreach (var bucket in listBuckets.Buckets){
               Debug.Print("bucket '" + bucket.BucketName + "' created at " + bucket.CreationDate);
            }
        }

        // 使用 AmazonS3Client 创建 桶
        public static async void test1() {
            AmazonS3Client amazonS3Client = MyAmazonS3Client.getInstance();
            amazonS3Client.PutBucket("1231111111111111");
            var replace = "68:EC:C5:87:01:D6".Replace(":", "");
        }
        // 使用 AmazonS3Client 创建 目录

        public static async void test3() {
            AmazonS3Client amazonS3Client = MyAmazonS3Client.getInstance();
            PutObjectRequest requestUpdate = new PutObjectRequest();
            var fileStream = new FileStream(@"C:\Users\Administrator\Desktop\333\student.xml", FileMode.Open, FileAccess.Read);
            requestUpdate.InputStream = fileStream;
            requestUpdate.BucketName = "test";
            requestUpdate.Key = "pic/123.xml"; // 这里相当于上传服务器后的 newName，其中 pic 会是 "test" bucket下的文件夹
            requestUpdate.CannedACL = S3CannedACL.PublicRead;
            PutObjectResponse putObjectResponse = amazonS3Client.PutObject(requestUpdate);
            Debug.Print(putObjectResponse.ToString());
        }

        // 使用 AmazonS3Client 同步文件夹
        public static async void test2() {
            AmazonS3Client amazonS3Client = MyAmazonS3Client.getInstance();
            string localPath = @"D:\222\";
            string bucketName = "goat";
            SychoniAsync(amazonS3Client,localPath,bucketName);
        }

        public static async Task SychoniAsync(AmazonS3Client amazonS3Client, string localPath, string bucketName, bool isDel = false) {
            var listBuckets = await amazonS3Client.ListBucketsAsync();
            if (listBuckets.Buckets.Count <= 0) return;

            var listFiles = await amazonS3Client.ListObjectsAsync(bucketName);
            DirectoryInfo TheFolder = new DirectoryInfo(localPath);
            foreach (FileInfo FileLocal in TheFolder.GetFiles()){
                if (MinIoUtil.ExistsBucket(FileLocal.Name, listFiles) == false){
                    await MinIoUtil.upLoad(bucketName, amazonS3Client, localPath, FileLocal.Name);
                }
            }

            foreach (S3Object obj in listFiles.S3Objects){
                string pathTemps = localPath + obj.Key;
                FileInfo fi = new FileInfo(pathTemps);
                // 存在则同步
                if (File.Exists(pathTemps)){
                    await MinIoUtil.synchronisation(obj, bucketName, amazonS3Client, pathTemps, fi);
                } else {
                    if (isDel) {
                        // 不存在则删除
                        await MinIoUtil.delete(obj, bucketName, amazonS3Client);
                    }
                }
            }
        }
    }
}