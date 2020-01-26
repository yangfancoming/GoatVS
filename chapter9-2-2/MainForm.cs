using System;
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
//            var selectById = "sys_fileJob.selectById".selectById<FileJob>(2);
//            Debug.Print(selectById.fileDirectory);
        }


        // 新增文件采集按钮
        private void btnAdd_Click(object sender, EventArgs e) {
            var addFileCollect = new AddFileCollect {ShowInTaskbar = false};
            addFileCollect.ShowDialog();
        }

        // 删除选中行按钮
        private void btnDel_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            string id = DataGridViewUtil.getCurrentRowById(dataGridView1);
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

        // 文件采集 开启任务
        private void btnStart_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            FileJob fileJob = DataGridViewUtil.getCurrentRow<FileJob>(dataGridView1,"sys_fileJob.selectById");
            // 通过 fileSuffix 字段 获取对应的实现类
            var o = (FileType)Enum.Parse(typeof(FileType), fileJob.fileSuffix, true);
            // 从字典中取出对应的 枚举类实现类
            IParse<string, string> mParse;
            try {
                mParse = ParseStrategy.mParses[o];
            } catch (Exception) {
                MessageBox.Show("不支持文件类型!");
                return;
            }
            string key = fileJob.getKeyByFileJob();
            JobUtil.configFileAndStart(mParse,key);
        }


        // 数据库 开启任务
        private void btnDbStart_Click(object sender, EventArgs e) {
            if (dataGridView2.SelectedRows.Count <= 0) return;
            DBJob dbJob = DataGridViewUtil.getCurrentRow<DBJob>(dataGridView2,"sys_dbJob.selectById");
            var o = (DatabaseType)Enum.Parse(typeof(DatabaseType), dbJob.dbType, true);
            // 从字典中取出对应的 枚举类实现类
            MyDataAdapter db;
            try {
                 db = UserDBStrategy.mUserDB[o];
            } catch (Exception) {
                MessageBox.Show("不支持数据库类型!");
                return;
            }
            JobUtil.configDbAndStart(db,dbJob);
        }
        // 数据库 删除按钮
        private void btnDbDel_Click(object sender, EventArgs e) {
            if (dataGridView2.SelectedRows.Count <= 0) return;
            DataGridViewUtil.deleteRowById<FileJob>(dataGridView2,"sys_dbJob","deleteById","selectList");
        }

        // 文件 删除按钮
        private void btnFileDel_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            DataGridViewUtil.deleteRowById<FileJob>(dataGridView1,"sys_fileJob","deleteById","selectList");
        }

        private void btnTestDb_Click(object sender, EventArgs e) {

        }

        // 文件 暂停任务
        private void btnFilePause_Click(object sender, EventArgs e) {
            DataGridViewUtil.updateRowById<FileJob>(dataGridView1,"sys_fileJob","updateById","selectList",JobStatus.暂停.ToString());
        }
        // 文件 恢复任务
        private void btnFileResume_Click(object sender, EventArgs e){
            DataGridViewUtil.updateRowById<FileJob>(dataGridView1,"sys_fileJob","updateById","selectList",JobStatus.执行.ToString());
        }
        // 数据库 暂停任务
        private void btnDbPause_Click(object sender, EventArgs e) {
            DataGridViewUtil.updateRowById<DBJob>(dataGridView2,"sys_dbJob","updateById","selectList",JobStatus.暂停.ToString());
        }
        // 数据库 恢复任务
        private void btnDbResume_Click(object sender, EventArgs e){
            DataGridViewUtil.updateRowById<DBJob>(dataGridView2,"sys_dbJob","updateById","selectList",JobStatus.执行.ToString());
        }

        // 数据库 关闭任务
        private async void btnDbStop_Click(object sender, EventArgs e) {
            DBJob dbJob = DataGridViewUtil.getCurrentRow<DBJob>(dataGridView2,"sys_dbJob.selectById");
            await JobUtil.stopJob(dbJob.dbConstr);
        }

        // 文件 关闭任务
        private async void btnFileStop_Click(object sender, EventArgs e) {
            var key = DataGridViewUtil.getCurrentRowFileAsKey<FileJob>(dataGridView1,"sys_fileJob.selectById");
            await JobUtil.startJob(key);
        }


    }
}