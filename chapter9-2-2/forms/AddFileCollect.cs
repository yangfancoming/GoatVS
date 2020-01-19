using System;
using System.Windows.Forms;
using chapter9_2_2.model;
using chapter9_2_2.mybatis;

namespace chapter9_2_2.forms {
    public partial class AddFileCollect : Form {
        public AddFileCollect() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            FileJob fileJob = new FileJob();
            fileJob.fileDirectory = tb_fileDirectory.Text;
            fileJob.fileMatched = tb_fileMatched.Text;
//            fileJob.fileSuffix = cbox_fileType.Text;
            fileJob.fileSuffix = "gaga";
            fileJob.jobName = "111";
            fileJob.jobType = "111";
            fileJob.jobCycle = "111";
            fileJob.createTime = "2020年1月19日17:55:11";
//开始事务

           BASE_DAL.insert("sys_fileJob.insert",fileJob);
           var selectList = BASE_DAL.selectList("sys_fileJob.selectList",fileJob);

        }

        private void AddFileCollect_Load(object sender, EventArgs e) {
            // 下拉框禁止编辑
            cbox_fileType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnEsc_Click(object sender, EventArgs e) {
            Close();
        }
    }
}