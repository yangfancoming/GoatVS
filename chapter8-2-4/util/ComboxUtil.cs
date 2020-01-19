using System.Collections.Generic;
using System.Windows.Forms;

namespace chapter8_2_4.util {


    public static class ComboxUtil {

        /// <summary>
        /// 加载 combox 内容
        /// </summary>
        /// <param name="comboBox"> 待加载的控件地址</param>
        /// <param name="data">待加载的数据</param>
        /// <param name="index">默认显示的索引项</param>
        public static void initComboBox(this ComboBox comboBox,List<string> data,int index = 0) {
            comboBox.DataSource = data;
            comboBox.SelectedIndex = index;
        }

        public static void folderBrowse(this FolderBrowserDialog folder, TextBox textBox){
            folder.Description = "请选择文件路径";
            if (folder.ShowDialog() == DialogResult.OK){
                textBox.Text = folder.SelectedPath;
            }
        }

    }
}