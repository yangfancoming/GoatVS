using System;
using System.Diagnostics;
using System.Windows.Forms;
using chapter3_5_5;
using chapter9_2_2.constant;
using chapter9_2_2.model;
using chapter9_2_2.mybatis;

namespace chapter9_2_2.forms {
    public partial class AddFileCollect : Form {

        public AddFileCollect() {
            InitializeComponent();
            cbox_fileType.DataSource = Enum.GetNames(typeof(FileType));
        }

        private void btnSave_Click(object sender, EventArgs e) {
            FileJob fileJob = new FileJob {
                jobName = tb_jobName.Text,// 任务名称
                jobStatus = JobStatus.停止.ToString(),
                //jobCycle = tb_jobCycle.Text,// 任务周期
                fileSuffix = cbox_fileType.Text, // 文件类型|后缀
                fileDirectory = tb_fileDirectory.Text, // 文件目录
                fileMatched = tb_fileMatched.Text, // 文件名匹配条件
                jobType = "文件采集", // 任务类型
                filehandlerOld =cb_handlerOld.Checked.ToString().ToLower(),// 处理已有文件
                createTime = DateTime.Now.ToString() // 创建时间
            };
            BaseDao.insert("sys_fileJob.insert",fileJob);
            MainForm.Pdgv1.DataSource = "sys_fileJob.selectList".selectList<FileJob>();

            // 初始化 文件狗
            MyFileSystemWatcher.initWatcher(fileJob.getKeyByFileJob(),fileJob.fileDirectory,"*." + fileJob.fileSuffix);
            Close();
        }

        private void AddFileCollect_Load(object sender, EventArgs e) {
            // 下拉框禁止编辑
            cbox_fileType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnEsc_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnBrowser_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK){
                tb_fileDirectory.Text = dialog.SelectedPath;
            }
        }
    }
}