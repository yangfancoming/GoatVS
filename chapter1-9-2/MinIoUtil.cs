using System.IO;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;

namespace chapter1_9_2 {


    public static class MinIoUtil {

        public static async Task upLoad(string bucketName, AmazonS3Client amazonS3Client, string path, string filename){
            string pathTemps = path + filename;
            PutObjectRequest requestUpdate = new PutObjectRequest();
            var fileStream = new FileStream(pathTemps, FileMode.Open, FileAccess.Read);
            requestUpdate.InputStream = fileStream;
            requestUpdate.BucketName = bucketName;
            requestUpdate.Key = filename;
            requestUpdate.CannedACL = S3CannedACL.PublicRead;
            await amazonS3Client.PutObjectAsync(requestUpdate);
        }

        public static async Task delete(S3Object obj, string bucketName, AmazonS3Client amazonS3Client){
            DeleteObjectRequest requestDelete = new DeleteObjectRequest{
                BucketName = bucketName,
                Key = obj.Key,
            };
            await amazonS3Client.DeleteObjectAsync(requestDelete);
        }

        public static bool ExistsBucket(string fileKey, ListObjectsResponse listObjectsResponse){
            foreach (S3Object obj in listObjectsResponse.S3Objects){
                if (obj.Key == fileKey){
                    return true;
                }
            }
            return false;
        }


        public static async Task synchronisation(S3Object obj, string bucketName, AmazonS3Client amazonS3Client, string pathTemps, FileInfo fi){
            DeleteObjectRequest requestDelete = new DeleteObjectRequest{  BucketName = bucketName, Key = obj.Key, };
            await amazonS3Client.DeleteObjectAsync(requestDelete);

            PutObjectRequest requestUpdate = new PutObjectRequest();
            var fileStream = new FileStream(pathTemps, FileMode.Open, FileAccess.Read);
            requestUpdate.InputStream = fileStream;
            requestUpdate.BucketName = bucketName;
            requestUpdate.Key = fi.Name;
            requestUpdate.CannedACL = S3CannedACL.PublicRead;
            await amazonS3Client.PutObjectAsync(requestUpdate);
        }





    }
}