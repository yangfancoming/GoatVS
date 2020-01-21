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

        // 初始化  设定表格列名及列显示顺序
        public static void initColumnsFile(DataGridView dgv) {
            dgv.DataSource = new BindingList<FileJob>();
            dgv.Columns["编码"].Visible = true;
            dgv.Columns["任务名称"].DisplayIndex = 0;
            dgv.Columns["任务类型"].DisplayIndex = 1;
            dgv.Columns["任务周期"].DisplayIndex = 2;
            dgv.Columns["任务状态"].DisplayIndex = 3;
            dgv.Columns["文件后缀"].DisplayIndex = 4;
            dgv.Columns["匹配条件"].DisplayIndex = 5;
            dgv.Columns["所在目录"].DisplayIndex = 6;
            dgv.Columns["创建时间"].DisplayIndex = 7;
        }

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

        public static void initFilePage(DataGridView dgv) {
            initColumnsFile(dgv);
            initStyle(dgv);
            dgv.DataSource = BaseDao.selectList<FileJob>("sys_fileJob.selectList");
        }

        public static void initDBPage(DataGridView dgv) {
            initColumnsDB(dgv);
            initStyle(dgv);
            dgv.DataSource = BaseDao.selectList<DBJob>("sys_dbJob.selectList");
        }

        // 获取表格内选中记录
        public static FileJob getCurrentRowFile(DataGridView dgv) {
            string id = getCurrentRowFileAsId(dgv);
            // 通过主键id 查询出该条记录
            var fileJob = (FileJob)"sys_fileJob.selectById".selectById(Convert.ToInt32(id));
            return fileJob;
        }

        public static string getCurrentRowFileAsId(DataGridView dgv) {
            // 获取当前选中行的主键
            var id = dgv.SelectedRows[0].Cells["编码"].Value.ToString();
            return id;
        }

        // 获取表格选中记录 生成并返回key
        public static string getCurrentRowFileAsKey(DataGridView dgv) {
            var fileJob = getCurrentRowFile(dgv);
            return getKeyByFileJob(fileJob);
        }

        // 通过 fileJob 生成key
        public static string getKeyByFileJob(FileJob fileJob) {
            return fileJob.fileSuffix + fileJob.fileDirectory;
        }
    }
}