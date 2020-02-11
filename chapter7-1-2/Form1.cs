using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using log4net.Config;

namespace chapter7_1_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // 初始化log4net 配置
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4c/log4net.config"));
        }

        private ILog log = LogManager.GetLogger(typeof(Form1));

        private void Form1_Load(object sender, EventArgs e) {
            const int temp000 = 000;
            const int temp111 = 111;
            log.Debug($"{temp000}  已删除日志。{temp111}");
        }
    }
}