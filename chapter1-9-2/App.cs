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
            var listBucketResponse = await amazonS3Client.ListBucketsAsync();
            foreach (var bucket in listBucketResponse.Buckets){
               Debug.Print("bucket '" + bucket.BucketName + "' created at " + bucket.CreationDate);
            }
        }

        // 使用 AmazonS3Client 同步文件夹
        public static async void test2() {
            AmazonS3Client amazonS3Client = MyAmazonS3Client.getInstance();
            string localPath = @"D:\222\";
            string bucketName = "goat";
            SychoniAsync(amazonS3Client,localPath,bucketName);
        }

        public static async Task SychoniAsync(AmazonS3Client amazonS3Client, string localPath, string bucketName, bool isDel = false) {
            var listBucketResponse = await amazonS3Client.ListBucketsAsync();
            if (listBucketResponse.Buckets.Count <= 0) return;

            var listObjectsResponse = await amazonS3Client.ListObjectsAsync(bucketName);
            DirectoryInfo TheFolder = new DirectoryInfo(localPath);
            foreach (FileInfo FileLocal in TheFolder.GetFiles()){
                if (MinIoUtil.ExistsBucket(FileLocal.Name, listObjectsResponse, amazonS3Client) == false){
                    await MinIoUtil.upLoad(bucketName, amazonS3Client, localPath, FileLocal.Name);
                }
            }

            foreach (S3Object obj in listObjectsResponse.S3Objects){
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