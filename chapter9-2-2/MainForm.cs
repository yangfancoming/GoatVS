using System;
using System.ComponentModel;
using System.Data;
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
        public MainForm() {
            InitializeComponent();

            PrtbLog = rtbLog;
        }

        public static DataGridView Pdgv1 ;
        public static DataGridView Pdgv2 ;
        public static RichTextBox PrtbLog ;

        private static readonly BindingList<FileJob> fileJobs = new BindingList<FileJob>();//将IList中的值赋给对应的BindingList
        private static readonly BindingList<DBJob> dbJobs = new BindingList<DBJob>();//将IList中的值赋给对应的BindingList

        private void MainForm_Load(object sender, EventArgs e) {
            dataGridView1.DataSource = fileJobs;  //将DataGridView里的数据源绑
            dataGridView1.AutoGenerateColumns = false; //设置不自动生成列，此属性在属性面板中没有
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 只能选中行
            dataGridView1.MultiSelect = false; // 是否可以选中多行
            dataGridView1.AllowUserToAddRows = false;// 设置用户不能手动给 DataGridView1 添加新行
            dataGridView1.AllowUserToResizeColumns = false ;// 禁止用户改变DataGridView1的所有列的列宽
            dataGridView1.AllowUserToResizeRows = false ;// 禁止用户改变DataGridView1的所有行的行高

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;  // 设定包括Header和所有单元格的列宽自动调整
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // 设定包括Header和所有单元格的行高自动调整
            foreach (DataGridViewColumn item in dataGridView1.Columns) {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Pdgv1 = dataGridView1;
            dataGridView1.DataSource = BaseDao.selectList<FileJob>("sys_fileJob.selectList"); //将DataGridView里的数据源绑

            // 初始化 列显示顺序
            dataGridView1.Columns["编码"].Visible = true;
            dataGridView1.Columns["任务名称"].DisplayIndex = 0;
            dataGridView1.Columns["任务类型"].DisplayIndex = 1;
            dataGridView1.Columns["任务周期"].DisplayIndex = 2;
            dataGridView1.Columns["任务状态"].DisplayIndex = 3;
            dataGridView1.Columns["文件后缀"].DisplayIndex = 4;
            dataGridView1.Columns["匹配条件"].DisplayIndex = 5;
            dataGridView1.Columns["所在目录"].DisplayIndex = 6;
            dataGridView1.Columns["创建时间"].DisplayIndex = 7;
        }

        // 测试按钮
        private void button1_Click(object sender, EventArgs e) {


//            onnectionString="Data Source=.\db\DemoDB.db;Version=3;"


            // 传统访问数据库方式
//            using (IDbConnection cnn = new SQLiteConnection(@"Data Source=.\db\sqlite.db;Version=3;")){
//                var output = cnn.Query<SysPerson>("SELECT * FROM PERSON", new DynamicParameters());
//                List<SysPerson> temp = output.ToList();
//                Debug.Print(temp.Count.ToString());
//            }


            // Mybatis 访问数据库方式
//            DomSqlMapBuilder builder = new DomSqlMapBuilder();
//            ISqlMapper Map = builder.Configure("mybatis/SqlMap.config");
////            Map.DataSource.ConnectionString = @"Data Source=Data Source=.\db\sqlite.db;Version=3";
//            SysPerson temp = new SysPerson();
////            Map.Insert("Student.create", temp);
//            IList<SysPerson> list;
//            try {
//                list = Map.QueryForList<SysPerson>("sys_person.selectList",null);
//            } catch (Exception exception) {
//                Console.WriteLine(exception);
//                throw;
//            }
//            Debug.Print(list.Count.ToString());
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
        private void btnStart_Click(object sender, EventArgs e) {
            // 获取当前选中行的主键
            var id = dataGridView1.SelectedRows[0].Cells["编码"].Value.ToString();
            // 通过主键id 查询出该条记录
            FileJob fileJob = (FileJob)"sys_fileJob.selectById".selectById(Convert.ToInt32(id));
            // 通过 fileSuffix 字段 获取对应的实现类
            var o = (FileType)Enum.Parse(typeof(FileType), fileJob.fileSuffix, true);
            // 从字典中取出对应的 枚举类实现类
            var mParse = ParseStrategy.mParses[o];
            // 动态创建job
            JobUtil.config2(mParse);
            JobUtil.start();
        }


        // 关闭任务
        private void btnStop_Click(object sender, EventArgs e) {
            JobUtil.stop();
        }

        // TabControl控件中TabPage选项卡切换时触发的事件
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            switch (tabControl1.SelectedTab.Text) {
                //也可以判断tabControl1.SelectedTab.Text的值
                case "文件采集":
                    Debug.Print(tabControl1.SelectedTab.Text);
                    break;
                case "数据库采集":
                    dataGridView2.DataSource = dbJobs;  //将DataGridView里的数据源绑
                    dataGridView2.AutoGenerateColumns = false; //设置不自动生成列，此属性在属性面板中没有
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 只能选中行
                    dataGridView2.MultiSelect = false; // 是否可以选中多行
                    dataGridView2.AllowUserToAddRows = false;// 设置用户不能手动给 dataGridView2 添加新行
                    dataGridView2.AllowUserToResizeColumns = false ;// 禁止用户改变dataGridView2的所有列的列宽
                    dataGridView2.AllowUserToResizeRows = false ;// 禁止用户改变dataGridView2的所有行的行高

                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;  // 设定包括Header和所有单元格的列宽自动调整
                    dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // 设定包括Header和所有单元格的行高自动调整
                    foreach (DataGridViewColumn item in dataGridView2.Columns) {
                        item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    Pdgv2 = dataGridView2;
                    dataGridView2.DataSource = BaseDao.selectList<DBJob>("sys_dbJob.selectList"); //将DataGridView里的数据源绑

                    // 初始化 列显示顺序
                    dataGridView2.Columns["编码"].Visible = true;
                    dataGridView2.Columns["任务名称"].DisplayIndex = 0;
                    dataGridView2.Columns["任务类型"].DisplayIndex = 1;
                    dataGridView2.Columns["任务周期"].DisplayIndex = 2;
                    dataGridView2.Columns["任务状态"].DisplayIndex = 3;
                    dataGridView2.Columns["数据库类型"].DisplayIndex = 4;
                    dataGridView2.Columns["连接串"].DisplayIndex = 5;
                    dataGridView2.Columns["SQL"].DisplayIndex = 6;
                    dataGridView2.Columns["创建时间"].DisplayIndex = 7;
                    Debug.Print(tabControl1.SelectedTab.Text);
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
        private void btnDbStart_Click(object sender, EventArgs e) {
            // 获取当前选中行的主键
            var id = dataGridView2.SelectedRows[0].Cells["编码"].Value.ToString();
            // 通过主键id 查询出该条记录
            DBJob dbJob = (DBJob)"sys_dbJob.selectById".selectById(Convert.ToInt32(id));
            var o = (DatabaseType)Enum.Parse(typeof(DatabaseType), dbJob.dbType, true);
            // 从字典中取出对应的 枚举类实现类
            MyDataAdapter db = UserDBStrategy.mUserDB[o];
//            db.constr = dbJob.dbConstr;
//            db.dbSql = dbJob.dbSql;

//            db.constr = "Database=test2;Data Source=192.168.211.128;port=3306;uid=root;pwd=12345;charset=utf8;pooling=true";
//            db.dbSql = "select * from book";
//            string connetStr = "Database=test2;Data Source=192.168.211.128;port=3306;uid=root;pwd=12345;charset=utf8;pooling=true";
            //string connetStr = @"Data Source=E:\Code\C#_code\RiderLearning\GoatVS\chapter5-2-7\db\DemoDB.db";

//            var dataAdapter = db.getDataAdapter(dbJob.dbSql, dbJob.dbConstr);
//            DataSet dataSet = new DataSet();
//            dataAdapter.Fill(dataSet);
//            Debug.Print(dataSet.Tables[0].Rows.Count.ToString());
            JobUtil.config2(db);
            JobUtil.start();
        }

        private void btnDBStop_Click(object sender, EventArgs e) {
            JobUtil.start();
        }
    }
}