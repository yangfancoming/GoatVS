namespace hfdc.upload {


    interface IOperFile {

        /// <summary>
        /// 上传文件接口
        /// </summary>
        /// <param name="host"> ftp地址：ftp://192.168.1.200/  </param>
        /// <param name="account">ftp用户名</param>
        /// <param name="password">ftp密码</param>
        /// <param name="localPath">本地待上传文件所在路径："D:\doctument\test.pdf"</param>
        bool uploadFile(string host, string account, string password, string localPath);


        /// <summary>
        /// 下载文件接口
        /// </summary>
        /// <param name="ftphost">ftp地址：ftp://192.168.1.200/</param>
        /// <param name="user">ftp用户名</param>
        /// <param name="password">ftp密码</param>
        /// <param name="saveLocalPath">下载到本地的地址：d:\\doctument\\0F5GAHRT4A484TRA5D15FEA.pdf</param>
        /// <param name="downPath">将要下载的文件在FTP上的路径：/DownFile/0F5GAHRT4A484TRA5D15FEA</param>
        void downloadFile(string host, string account, string password, string saveLocalPath, string downPath);
    }
}
