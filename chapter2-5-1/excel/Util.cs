using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;

namespace chapter2_5_1.excel {

    public  static class Util {

        public static ICellStyle Getcellstyle(IWorkbook wb, stylexls str) {

            ICellStyle cellStyle = wb.CreateCellStyle();

            //定义几种字体
            //也可以一种字体，写一些公共属性，然后在下面需要时加特殊的
            IFont font12 = wb.CreateFont();
            font12.FontHeightInPoints = 10;
            font12.FontName = "微软雅黑";


            IFont font = wb.CreateFont();
            font.FontName = "微软雅黑";
            //font.Underline = 1;下划线


            IFont fontcolorblue = wb.CreateFont();
            fontcolorblue.Color = HSSFColor.OLIVE_GREEN.BLUE.index;
            fontcolorblue.IsItalic = true;//下划线
            fontcolorblue.FontName = "微软雅黑";


            //边框
            cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.DOTTED;
            cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.HAIR;
            cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.HAIR;
            cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.DOTTED;
            //边框颜色
            cellStyle.BottomBorderColor = HSSFColor.OLIVE_GREEN.BLUE.index;
            cellStyle.TopBorderColor = HSSFColor.OLIVE_GREEN.BLUE.index;

            //背景图形，我没有用到过。感觉很丑
            //cellStyle.FillBackgroundColor = HSSFColor.OLIVE_GREEN.BLUE.index;
            //cellStyle.FillForegroundColor = HSSFColor.OLIVE_GREEN.BLUE.index;
            cellStyle.FillForegroundColor = HSSFColor.WHITE.index;
            // cellStyle.FillPattern = FillPatternType.NO_FILL;
            cellStyle.FillBackgroundColor = HSSFColor.BLUE.index;

            //水平对齐
            cellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT;

            //垂直对齐
            cellStyle.VerticalAlignment = VerticalAlignment.CENTER;

            //自动换行
            cellStyle.WrapText = true;

            //缩进;当设置为1时，前面留的空白太大了。希旺官网改进。或者是我设置的不对
            cellStyle.Indention = 0;

            //上面基本都是设共公的设置
            //下面列出了常用的字段类型
            switch (str)
            {
                case stylexls.头:
                    // cellStyle.FillPattern = FillPatternType.LEAST_DOTS;
                    cellStyle.SetFont(font12);
                    break;
                case stylexls.时间:
                    IDataFormat datastyle = wb.CreateDataFormat();

                    cellStyle.DataFormat = datastyle.GetFormat("yyyy/mm/dd");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.数字:
                    cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.钱:
                    IDataFormat format = wb.CreateDataFormat();
                    cellStyle.DataFormat = format.GetFormat("￥#,##0");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.url:
                    fontcolorblue.Underline = 1;
                    cellStyle.SetFont(fontcolorblue);
                    break;
                case stylexls.百分比:
                    cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00%");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.中文大写:
                    IDataFormat format1 = wb.CreateDataFormat();
                    cellStyle.DataFormat = format1.GetFormat("[DbNum2][$-804]0");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.科学计数法:
                    cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00E+00");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.默认:
                    cellStyle.SetFont(font);
                    break;
            }
            return cellStyle;

        }

    }
}