using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace chapter3_5_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // 获取当前目录
            string directory = Directory.GetCurrentDirectory();
            // 生成uuid名称
            string uuid = Guid.NewGuid().ToString("N");
            // 创建临时文件夹
            var directoryInfo = Directory.CreateDirectory($"{directory}\\{uuid}");
            Debug.Print(directoryInfo.FullName);  // E:\Code\C#_code\RiderLearning\GoatVS\chapter3-5-3\bin\Debug\0b4e3851b4d743378925368cebd09cff
            // 拷贝已存在文件

        }
    }
}