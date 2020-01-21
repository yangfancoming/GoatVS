using System;
using System.Windows.Forms;
using chapter9_2_2.constant;
using chapter9_2_2.model;
using chapter9_2_2.mybatis;

namespace chapter9_2_2.forms {
    public partial class AddDbCollect : Form {
        public AddDbCollect() {
            InitializeComponent();
            cbox_dbType.DataSource = Enum.GetNames(typeof(DatabaseType));
        }

        private void btnSave_Click(object sender, EventArgs e) {
            DBJob dbJob = new DBJob {
                jobName = tb_jobName.Text,// 任务名称
                jobCycle = tb_jobCycle.Text,// 任务周期
                jobType = "数据库采集", // 任务类型
                dbConstr = tb_dbConstr.Text, // 数据库连接串
                dbType =   cbox_dbType.Text, // 数据库类型
                dbSql =   tb_dbSql.Text, // 待执行sql语句
                createTime = DateTime.Now.ToString() // 创建时间
            };
            BaseDao.insert("sys_dbJob.insert",dbJob);
            MainForm.Pdgv2.DataSource = "sys_dbJob.selectList".selectList<DBJob>();
            Close();
        }

        private void btnEsc_Click(object sender, EventArgs e) {
            Close();
        }
    }
}