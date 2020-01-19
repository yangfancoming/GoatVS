using System;
using System.ComponentModel;
using System.Windows.Forms;
using chapter9_2_2.forms;
using chapter9_2_2.model;

namespace chapter9_2_2 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private static readonly BindingList<FileJob> fileJobs = new BindingList<FileJob>();//将IList中的值赋给对应的BindingList

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
        }

        // 测试按钮
        private void button1_Click(object sender, EventArgs e) {

//            var FileJob1 = new FileJob {任务名称 = "1号任务",任务类型 = "文件采集",任务周期 = "3",创建时间 = "2020年1月19日15:54:54",文件类型 = "txt",所在目录 = "txt",匹配条件 = "txt",};
//            var FileJob2 = new FileJob {任务名称 = "2号任务",任务类型 = "串口采集",任务周期 = "4",创建时间 = "2020年1月19日15:54:57",文件类型 = "txt",所在目录 = "txt",匹配条件 = "txt",};
//            var FileJob3 = new FileJob {任务名称 = "3号任务",任务类型 = "数据库采集",任务周期 = "5",创建时间 = "2020年1月19日15:54:59",文件类型 = "txt",所在目录 = "txt",匹配条件 = "txt",};
//            fileJobs.Add(FileJob1);
//            fileJobs.Add(FileJob2);
//            fileJobs.Add(FileJob3);

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


        private void btnAdd_Click(object sender, EventArgs e) {
            AddFileCollect addFileCollect = new AddFileCollect {ShowInTaskbar = false};
            addFileCollect.ShowDialog();
        }
    }
}