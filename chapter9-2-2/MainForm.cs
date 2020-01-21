using System;
using System.ComponentModel;
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

        }


        // 新增文件采集按钮
        private void btnAdd_Click(object sender, EventArgs e) {
            var addFileCollect = new AddFileCollect {ShowInTaskbar = false};
            addFileCollect.ShowDialog();
        }

        // 删除选中行按钮
        private void btnDel_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count <= 0) {
                MessageBox.Show("请选择要删除记录！");
                return;
            }
            // 拿到当前选中行的主键id
            Debug.Print(dataGridView1.SelectedRows[0].Cells["编码"].Value.ToString());
            BaseDao.deleteById("sys_fileJob.deleteById", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["编码"].Value));
            dataGridView1.DataSource = BaseDao.selectList<FileJob>("sys_fileJob.selectList"); //将DataGridView里的数据源绑
        }

        private void btnAddSerial_Click(object sender, EventArgs e) {
            var addSerialCollect = new AddSerialCollect{ShowInTaskbar = false};;
            addSerialCollect.ShowDialog();
        }

        private void btnAddDb_Click(object sender, EventArgs e) {
            var addSerialCollect = new AddDbCollect{ShowInTaskbar = false};;
            addSerialCollect.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            var settings = new Settings { ShowInTaskbar = false }; ;
            settings.ShowDialog();
        }

        // 开启任务
        private async void btnStart_Click(object sender, EventArgs e) {
            // 获取当前选中行的主键
            var id = dataGridView1.SelectedRows[0].Cells["编码"].Value.ToString();
            // 通过主键id 查询出该条记录
            FileJob fileJob = (FileJob)"sys_fileJob.selectById".selectById(Convert.ToInt32(id));
            // 通过 fileSuffix 字段 获取对应的实现类
            var o = (FileType)Enum.Parse(typeof(FileType), fileJob.fileSuffix, true);
            // 从字典中取出对应的 枚举类实现类
            var mParse = ParseStrategy.mParses[o];
            // 动态创建job
           await JobUtil.config2(mParse);
           await JobUtil.start();
        }


        // 关闭任务
        private async void btnStop_Click(object sender, EventArgs e) {
            await JobUtil.stop();
        }

        // TabControl控件中TabPage选项卡切换时触发的事件
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            switch (tabControl1.SelectedTab.Text) {
                case "文件采集":
                    Debug.Print(tabControl1.SelectedTab.Text);
                    break;
                case "数据库采集":
                    DataGridViewUtil.initDBPage(dataGridView2);
                    break;
                case "串口采集":
                    Debug.Print(tabControl1.SelectedTab.Text);
                    break;
                case "系统设置":
                    Debug.Print(tabControl1.SelectedTab.Text);
                    break;
            }
        }

        // 数据库开启任务
        private async void btnDbStart_Click(object sender, EventArgs e) {
            // 获取当前选中行的主键
            var id = dataGridView2.SelectedRows[0].Cells["编码"].Value.ToString();
            // 通过主键id 查询出该条记录
            DBJob dbJob = (DBJob)"sys_dbJob.selectById".selectById(Convert.ToInt32(id));
            var o = (DatabaseType)Enum.Parse(typeof(DatabaseType), dbJob.dbType, true);
            // 从字典中取出对应的 枚举类实现类
            MyDataAdapter db = UserDBStrategy.mUserDB[o];
            await JobUtil.config2(db);
            await JobUtil.start();
        }

        private async void btnDBStop_Click(object sender, EventArgs e) {
            await JobUtil.start();
        }
    }
}