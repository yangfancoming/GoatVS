using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using chapter2_5_1.excel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace chapter2_5_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // 创建 excel 1
        private void button1_Click(object sender, EventArgs e) {
            //创建工作薄
            HSSFWorkbook wk = new HSSFWorkbook();
            //创建一个名称为mySheet的表
            ISheet tb = wk.CreateSheet("mySheet");
            //创建一行，此行为第二行
            IRow row = tb.CreateRow(1);
            for (int i = 0; i < 20; i++)  {
                ICell cell = row.CreateCell(i);  //在第二行中创建单元格
                cell.SetCellValue(i);//循环往第二行的单元格中添加数据
            }
            using (FileStream fs = File.OpenWrite(@"F:/myxls.xls")) {//打开一个xls文件，如果没有则自行创建，如果存在myxls.xls文件则在创建是不要打开该文件！
                wk.Write(fs);   //向打开的这个xls文件中写入mySheet表并保存。
                MessageBox.Show("提示：创建成功！");
            }
        }
        // 创建 excel 2
        private void button4_Click(object sender, EventArgs e) {
            HSSFWorkbook hssfworkbook =new HSSFWorkbook();
            hssfworkbook.CreateSheet("Sheet1");
            hssfworkbook.CreateSheet("Sheet2");
            hssfworkbook.CreateSheet("Sheet3");
            FileStream file =new FileStream(@"F:\test123.xls", FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
        }

        // 读取 xls
        private void button2_Click(object sender, EventArgs e) {
            StringBuilder sbr = new StringBuilder();
            using (FileStream fs = File.OpenRead(@"F:/myxls.xls")){   //打开myxls.xls文件
                HSSFWorkbook wk = new HSSFWorkbook(fs);   //把xls文件中的数据写入wk中
                for (int i = 0; i < wk.NumberOfSheets; i++) { //NumberOfSheets是myxls.xls中总共的表数
                    ISheet sheet = wk.GetSheetAt(i);   //读取当前表数据
                    for (int j = 0; j <= sheet.LastRowNum; j++) { //LastRowNum 是当前表的总行数
                        IRow row = sheet.GetRow(j);  //读取当前行数据
                        if (row != null){
                            sbr.Append("-------------------------------------\r\n"); //读取行与行之间的提示界限
                            for (int k = 0; k <= row.LastCellNum; k++) { //LastCellNum 是当前行的总列数
                                ICell cell = row.GetCell(k);  //当前表格
                                if (cell != null){
                                    sbr.Append(cell);   //获取表格中的数据并转换为字符串类型
                                }
                            }
                        }
                    }
                }
            }
            using (StreamWriter wr = new StreamWriter(new FileStream(@"F:/myText.txt", FileMode.Append))){  //把读取xls文件的数据写入myText.txt文件中
                wr.Write(sbr.ToString());
                wr.Flush();
            }
        }

        // 创建常用xls
        private void button3_Click(object sender, EventArgs e) {
            IWorkbook wb = new HSSFWorkbook();
            //创建表
            ISheet sh = wb.CreateSheet("zhiyuan");
            //设置单元的宽度
            sh.SetColumnWidth(0, 15 * 256);
            sh.SetColumnWidth(1, 35 * 256);
            sh.SetColumnWidth(2, 15 * 256);
            sh.SetColumnWidth(3, 10 * 256);
            int i = 0;
            #region 练习合并单元格
            sh.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, 3));

            //CellRangeAddress（）该方法的参数次序是：开始行号，结束行号，开始列号，结束列号。

            IRow row0 = sh.CreateRow(0);
            row0.Height = 20 * 20;
            ICell icell1top0 = row0.CreateCell(0);
            icell1top0.CellStyle = Util.Getcellstyle(wb, stylexls.头);
            icell1top0.SetCellValue("标题合并单元");
            #endregion
            i++;
            #region 设置表头
            IRow row1 = sh.CreateRow(1);
            row1.Height = 20 * 20;

            ICell icell1top = row1.CreateCell(0);
            icell1top.CellStyle = Util.Getcellstyle(wb, stylexls.头);
            icell1top.SetCellValue("网站名");

            ICell icell2top = row1.CreateCell(1);
            icell2top.CellStyle = Util.Getcellstyle(wb, stylexls.头);
            icell2top.SetCellValue("网址");

            ICell icell3top = row1.CreateCell(2);
            icell3top.CellStyle = Util.Getcellstyle(wb, stylexls.头);
            icell3top.SetCellValue("百度快照");

            ICell icell4top = row1.CreateCell(3);
            icell4top.CellStyle = Util.Getcellstyle(wb, stylexls.头);
            icell4top.SetCellValue("百度收录");
            #endregion

            using(FileStream stm=File.OpenWrite(@"F:/myMergeCell.xls"))
            {
                wb.Write(stm);
                MessageBox.Show("提示：创建成功！");
            }
        }


    }
}