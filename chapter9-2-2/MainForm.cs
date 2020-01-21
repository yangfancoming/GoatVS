using System;
using System.Diagnostics;
using System.Windows.Forms;
using chapter9_2_2.constant;
using chapter9_2_2.db;
using chapter9_2_2.forms;
using chapter9_2_2.job;
using chapter9_2_2.model;
using chapter9_2_2.mybatis;
using chapter9_2_2.parse;

namespace chapter9_2_2 {
    public partial class MainForm : Form {

        public static DataGridView Pdgv1 ;
        public static DataGridView Pdgv2 ;
        public static RichTextBox PrtbLog ;

        public MainForm() {
            InitializeComponent();
            PrtbLog = rtbLog;
            Pdgv1 = dataGridView1;
            Pdgv2 = dataGridView2;
        }


        private void MainForm_Load(object sender, EventArgs e) {
            DataGridViewUtil.initFilePage(dataGridView1);
        }

        // 测试按钮
        private void button1_Click(object sender, EventArgs e) {
//            var selectList = "sys_fileJob.selectList".selectList<FileJob>();
//            Debug.Print(selectList.Count.ToString());
            var selectById = "sys_fileJob.selectById".selectById<FileJob>(2);
            Debug.Print(selectById.fileDirectory);
        }


        // 新增文件采集按钮
        private void btnAdd_Click(object sender, EventArgs e) {
            var addFileCollect = new AddFileCollect {ShowInTaskbar = false};
            addFileCollect.ShowDialog();
        }

        // 删除选中行按钮
        private void btnDel_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            string id = DataGridViewUtil.getCurrentRowFileAsId(dataGridView1);
            "sys_fileJob.deleteById".deleteById(Convert.ToInt32(id));
            dataGridView1.DataSource = "sys_fileJob.selectList".selectList<FileJob>(); //将DataGridView里的数据源绑
        }

        private void btnAddSerial_Click(object sender, EventArgs e) {
            var addSerialCollect = new AddSerialCollect{ShowInTaskbar = false};
            addSerialCollect.ShowDialog();
        }

        private void btnAddDb_Click(object sender, EventArgs e) {
            var addSerialCollect = new AddDbCollect{ShowInTaskbar = false};
            addSerialCollect.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            var settings = new Settings { ShowInTaskbar = false }; ;
            settings.ShowDialog();
        }

        // 开启任务 文件采集
        private async void btnStart_Click(object sender, EventArgs e) {
            FileJob fileJob = DataGridViewUtil.getCurrentRowFile(dataGridView1);
            // 通过 fileSuffix 字段 获取对应的实现类
            var o = (FileType)Enum.Parse(typeof(FileType), fileJob.fileSuffix, true);
            // 从字典中取出对应的 枚举类实现类
            var mParse = ParseStrategy.mParses[o];
            string key = DataGridViewUtil.getKeyByFileJob(fileJob);
            await JobUtil.configFileAndStart(mParse,key);
        }


        // 关闭任务
        private async void btnStop_Click(object sender, EventArgs e) {
            string key = DataGridViewUtil.getCurrentRowFileAsKey(dataGridView1);
            await JobUtil.stopFile(key);
        }

        // TabControl控件中TabPage选项卡切换时触发的事件
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            switch (tabControl1.SelectedTab.Text) {
                case "文件采集":
                    break;
                case "数据库采集":
                    DataGridViewUtil.initDBPage(dataGridView2);
                    break;
                case "串口采集":
                    break;
                case "系统设置":
                    break;
            }
        }

        // 数据库开启任务
        private async void btnDbStart_Click(object sender, EventArgs e) {
            // 获取当前选中行的主键
            var id = dataGridView2.SelectedRows[0].Cells["编码"].Value.ToString();
            // 通过主键id 查询出该条记录
            var dbJob = "sys_dbJob.selectById".selectById<DBJob>(Convert.ToInt32(id));
            var o = (DatabaseType)Enum.Parse(typeof(DatabaseType), dbJob.dbType, true);
            // 从字典中取出对应的 枚举类实现类
            MyDataAdapter db = UserDBStrategy.mUserDB[o];
            await JobUtil.config2(db);
//            await JobUtil.startDB();
        }

        private async void btnDBStop_Click(object sender, EventArgs e) {
//            await JobUtil.startDB();
        }

        private async void btnFileStop_Click(object sender, EventArgs e) {
            string key = DataGridViewUtil.getCurrentRowFileAsKey(dataGridView1);
            await JobUtil.startFile(key);
        }

        private void btnFileDel_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            string id = DataGridViewUtil.getCurrentRowFileAsId(dataGridView1);
            int num  = "sys_fileJob.deleteById".deleteById(Convert.ToInt32(id));
            Debug.Print(num.ToString());
            dataGridView1.DataSource = "sys_fileJob.selectList".selectList<FileJob>(); //将DataGridView里的数据源绑
        }
    }
}