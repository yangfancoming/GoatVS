
using System;
using System.Diagnostics;
using FluentFTP;

namespace chapter1_9_3 {

    public static class MyFtpUtil {

        public static readonly FtpClient _ftpClient = new FtpClient("ftp://192.168.211.128/",21,"test","test");


        /// <summary>
        /// 上传文件
        /// MyFtpUtil.upLoadFile(@"D:\123\123.txt", "321.txt")
        /// </summary>
        /// <param name="localPath">本地待上传文件地全路径</param>
        /// <param name="remotePath">ftp服务器上传后的文件名</param>
        /// <returns>成功返回true 失败返回false</returns>
        public static bool upLoadFile(string localPath, string remotePath){
            try{
                _ftpClient.Connect();
                bool uploadFile = _ftpClient.UploadFile(localPath, remotePath);
                _ftpClient.Disconnect();
                return uploadFile;
            }
            catch (Exception e) {
                Debug.Print(e.Message);
                return false;
            }
        }

        /// <summary>
        /// 删除远程ftp服务器文件
        /// MyFtpUtil.deleteFile("321.txt");
        /// </summary>
        /// <param name="remotePath">远程ftp服务器文件名</param>
        /// <returns>成功返回true 失败返回false</returns>
        public static bool deleteFile(string remotePath){
            try{
                _ftpClient.Connect();
                _ftpClient.DeleteFile( remotePath);
                _ftpClient.Disconnect();
            }
            catch (Exception e) {
                Debug.Print(e.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        ///  给远程ftp服务器文件改名
        /// MyFtpUtil.reNameFile("12.txt", "1111112.txt");
        /// </summary>
        /// <param name="oldName">原文件名</param>
        /// <param name="newName">新文件名</param>
        /// <returns>成功返回true 失败返回false</returns>
        public static bool reNameFile(string oldName, string newName){
            try{
                _ftpClient.Connect();
                _ftpClient.Rename(oldName,newName);
                _ftpClient.Disconnect();
            }
            catch (Exception e) {
                Debug.Print(e.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        ///  给远程ftp服务器创建目录
        /// MyFtpUtil.reNameFile("123");
        /// </summary>
        /// <param name="dir">待创建的目录名称</param>
        /// <returns>成功返回true 失败返回false</returns>
        public static bool createDir(string dir){
            try{
                if (string.IsNullOrEmpty(dir)||"/".Equals(dir)) return true;
                _ftpClient.Connect();
                _ftpClient.CreateDirectory(dir);
                _ftpClient.Disconnect();
            }
            catch (Exception e) {
                Debug.Print(e.Message);
                return false;
            }
            return true;
        }
    }
}