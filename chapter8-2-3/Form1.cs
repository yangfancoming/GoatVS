using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace chapter8_2_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // 1. 添加数据
        private void button1_Click(object sender, EventArgs e) {
            clb.Items.Add("一级");
            clb.Items.Add("二级");
            clb.Items.Add("三级");
        }

        // 3. 设置第i项的选中状态(索引从0开始) true选中  false取消选中
        private void button3_Click(object sender, EventArgs e) {
            clb.SetItemChecked(0, true);
        }

        // 判断第1项是否被选中，选中为true，否则为false
        private void button4_Click(object sender, EventArgs e) {
            if (clb.GetItemChecked(0)) {
                Debug.WriteLine(true);
            }
            else{
                Debug.WriteLine(false);
            }
        }

        // 仅遍历选中项
        private void button2_Click(object sender, EventArgs e) {
            foreach (string outstr in clb.CheckedItems){
                Debug.WriteLine(outstr);
            }
        }

        // 遍历 所有列表框项
        private void button5_Click(object sender, EventArgs e) {
            for (int i = 0; i < clb.Items.Count; i++){
                if (clb.GetItemChecked(i)){
                    string temp = clb.GetItemText(clb.Items[i]);
                    Debug.WriteLine(temp);
                }
            }
        }
    }
}