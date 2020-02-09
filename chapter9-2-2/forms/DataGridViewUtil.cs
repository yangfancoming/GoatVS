using System;
using System.ComponentModel;
using System.Windows.Forms;
using chapter9_2_2.model;
using chapter9_2_2.mybatis;

namespace chapter9_2_2.forms {

    public static class DataGridViewUtil {

        // 初始化表格样式
        public static void initStyle(DataGridView dgv) {
            dgv.AutoGenerateColumns = false; //设置不自动生成列，此属性在属性面板中没有
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 只能选中行
            dgv.MultiSelect = false; // 是否可以选中多行
            dgv.AllowUserToAddRows = false;// 设置用户不能手动给 dgv 添加新行
            dgv.AllowUserToResizeColumns = false ;// 禁止用户改变dgv的所有列的列宽
            dgv.AllowUserToResizeRows = false ;// 禁止用户改变dgv的所有行的行高
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;  // 设定包括Header和所有单元格的列宽自动调整
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // 设定包括Header和所有单元格的行高自动调整
            foreach (DataGridViewColumn item in dgv.Columns) {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        //文件  初始化 设定表格列名及列显示顺序
        public static void initColumnsFile(DataGridView dgv) {
            dgv.DataSource = new BindingList<FileJob>();
            dgv.Columns["编码"].Visible = true;
            dgv.Columns["任务名称"].DisplayIndex = 0;
            dgv.Columns["任务类型"].DisplayIndex = 1;
            dgv.Columns["任务周期"].DisplayIndex = 2;
            dgv.Columns["任务周期"].Visible = false;
            dgv.Columns["任务状态"].DisplayIndex = 3;
            dgv.Columns["文件后缀"].DisplayIndex = 4;
            dgv.Columns["匹配条件"].DisplayIndex = 5;
            dgv.Columns["监视目录"].DisplayIndex = 6;
            dgv.Columns["创建时间"].DisplayIndex = 7;
        }

        // 数据库  初始化 设定表格列名及列显示顺序
        public static void initColumnsDB(DataGridView dgv) {
            dgv.DataSource = new BindingList<DBJob>();
            dgv.Columns["编码"].Visible = true;
            dgv.Columns["任务名称"].DisplayIndex = 0;
            dgv.Columns["任务类型"].DisplayIndex = 1;
            dgv.Columns["任务周期"].DisplayIndex = 2;
            dgv.Columns["任务状态"].DisplayIndex = 3;
            dgv.Columns["数据库类型"].DisplayIndex = 4;
            dgv.Columns["连接串"].DisplayIndex = 5;
            dgv.Columns["SQL"].DisplayIndex = 6;
            dgv.Columns["创建时间"].DisplayIndex = 7;
        }

        // 初始化 文件采集页面
        public static void initFilePage(DataGridView dgv) {
            initColumnsFile(dgv);
            initStyle(dgv);
            dgv.DataSource = "sys_fileJob.selectList".selectList<FileJob>();
        }

        // 初始化 数据库采集页面
        public static void initDBPage(DataGridView dgv) {
            initColumnsDB(dgv);
            initStyle(dgv);
            dgv.DataSource = "sys_dbJob.selectList".selectList<DBJob>();
        }

        // 获取表格内选中记录
        public static T getCurrentRow<T>(DataGridView dgv,string mapperStr) {
            string id = getCurrentRowById(dgv);
            // 通过主键id 查询出该条记录
            var fileJob = mapperStr.selectById<T>(Convert.ToInt32(id));
            return fileJob;
        }

        // 获取当前选中行的主键
        public static string getCurrentRowById(DataGridView dgv) {
            var id = dgv.SelectedRows[0].Cells["编码"].Value.ToString();
            return id;
        }

        // 获取表格选中记录 生成并返回key
        public static string getCurrentRowFileAsKey<T>(DataGridView dgv,string mapperStr) {
            var fileJob = getCurrentRow<T>(dgv,mapperStr) as FileJob;
            return fileJob.getKeyByFileJob();
        }

        // 通过 fileJob 生成key
        public static string getKeyByFileJob(this FileJob fileJob) {
            return fileJob.fileSuffix + fileJob.fileDirectory;
        }

        // 通过 dbJob 生成key
        public static string getKeyByDbJob(this DBJob dbJob) {
            return dbJob.dbConstr;
        }

        // 通用删除行 功能
        public static void deleteRowById<T>(DataGridView dgv,string namespaces,string deleteById,string selectList) {
            string id = getCurrentRowById(dgv);
            (namespaces + "." + deleteById).deleteById(Convert.ToInt32(id));
            dgv.DataSource = (namespaces  + "." + selectList).selectList<T>();
        }

        // 通用更改行 功能
        public static void updateRowById<T>(DataGridView dgv,string namespaces,string deleteById,string selectList,string jobStatus) {
            JobInfor job = new JobInfor() {id = Convert.ToInt32(getCurrentRowById(dgv)), jobStatus = jobStatus };
            (namespaces + "." + deleteById).update(job);
            dgv.DataSource = (namespaces  + "." + selectList).selectList<T>();
        }
    }
}