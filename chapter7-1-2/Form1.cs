using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using chapter7_1_2.uilog;
using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;

namespace chapter7_1_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // 初始化log4net 配置
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4c/log4net.config"));
            // 初始化UI控件日志 配置
            InitLog();
        }

        private ILog log = LogManager.GetLogger(typeof(Form1));

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void LogEventHandle(object o, UiLogEventArgs e) {
            rtbLog.Invoke(new Action(() => { rtbLog.AppendText(e.Message + "\r\n"); }));
        }

        //初始化UI控件日志
        private void InitLog() {
            Hierarchy hierarchy = LogManager.GetRepository() as Hierarchy;
            foreach (var appender in hierarchy.Root.Repository.GetAppenders()) {
                if (appender is UiLogAppender uiLogAppender)
                    uiLogAppender.UiLogReceived += LogEventHandle;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            const int temp000 = 000;
            const int temp111 = 111;
            log.Debug($"{temp000}  已删除日志。{temp111}");
        }

    }
}