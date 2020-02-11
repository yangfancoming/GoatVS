
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using FluentFTP;
using IBatisNet.Common.Logging;
using Quartz.Logging;

namespace chapter1_9_3 {

    public static class MyFtpUtil {

        private static readonly FtpClient _ftpClient = new FtpClient("ftp://192.168.211.128/",21,"test","test");

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
                _ftpClient.DeleteFile(remotePath);
                _ftpClient.Disconnect();
            }
            catch (Exception e) {
                Debug.Print(e.Message);
                return false;
            }
            return true;
        }

        // MyFtpUtil.deleteDirectory("/123/log/"); // 删除 123 目录下的log 目录
        // MyFtpUtil.deleteDirectory("/123/"); // 如果123目录下还有子目录  则删除123目录下的所有文件，其他子目录不受影响
        public static bool deleteDirectory(string fullPath){
            try{
                _ftpClient.Connect();
                _ftpClient.DeleteDirectory(fullPath);
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
        public static bool renameFile(string oldName, string newName){
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
        /// MyFtpUtil.createDir("123");
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

//        private static readonly ILog log = LogManager.GetLogger(typeof(MyFtpUtil));
//        log.Info($"CreateFtpDirectory==>{remoteFile}");
        /// <summary>
        /// 同步本地文件到远程FTP服务
        /// MyFtpUtil.Sync("222",@"C:\Users\Administrator\Desktop\123",false);
        /// </summary>
        /// <param name="remotePath">远程路径 "222" </param>
        /// <param name="localPath">本地路径 @"C:\Users\Administrator\Desktop\123" </param>
        /// <param name="isDel">是否删除本地已不存在的远程文件</param>
        public static void Sync(string remotePath, string localPath, bool isDel = false){
            _ftpClient.Connect();
            SyncDirectory(_ftpClient, remotePath, localPath, isDel);
            _ftpClient.Disconnect();
        }

      private static void SyncDirectory(IFtpClient client, string remotePath, string localPath, bool isDel) {
            var localFolder = new DirectoryInfo(localPath);
            var infos = localFolder.GetFileSystemInfos();
            foreach (var info in infos){
                if (!client.IsConnected) client.Connect();

                if (info is FileInfo fileInfo){
                    var size = fileInfo.Length;
                    var remoteFile = Path.Combine(remotePath, fileInfo.Name);
                    if (client.FileExists(remoteFile) && client.GetFileSize(remoteFile) == size) continue;
                    client.UploadFile(fileInfo.FullName, remoteFile);
                }
                else if (info is DirectoryInfo){
                    var remoteFile = Path.Combine(remotePath, info.Name);
                    if (!client.DirectoryExists(remoteFile)){
                        client.CreateDirectory(remoteFile);
                    }
                    SyncDirectory(client, Path.Combine(remotePath, info.Name), info.FullName, isDel);
                }
            }
            if (!isDel) return;{
                var items = client.GetListing(remotePath);
                foreach (var item in items) {
                    if (infos.Any(info => info.Name == item.Name)) continue;
                    switch (item.Type) {
                        case FtpFileSystemObjectType.File:
                            client.DeleteFile(item.FullName);
                            break;
                        case FtpFileSystemObjectType.Directory:
                            client.DeleteDirectory(item.FullName);
                            break;
                    }
                }
            }

      }
    }
}