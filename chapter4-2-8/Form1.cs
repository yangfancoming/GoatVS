using System;
using System.Data;
using System.Windows.Forms;
using chapter4_2_8.IBLL;
using Spring.Context;
using Spring.Context.Support;

namespace chapter4_2_8 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSqlserver_Click(object sender, EventArgs e) {

            // 从配置文件读取配置
            IApplicationContext ctx = ContextRegistry.GetContext();
            // 获取具体的实现类
            IDatabaseService dbService = ctx.GetObject("bll") as IDatabaseService;
            // 从数据库查询数据
            DataTable dt = dbService.GetDataTableBySQL();
            // 将查询出的数据绑定到DataGridView中

        }

        private void btnOracle_Click(object sender, EventArgs e) {

        }
    }
}