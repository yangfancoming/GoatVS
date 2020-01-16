using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter8_2_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            add(listBox1,textBox1.Text.Trim());
        }

        // 右移
        private void button2_Click(object sender, EventArgs e) {
            //判断所有选中项集合大于0
            if(listBox1.SelectedItems.Count > 0) {
                // 添加右框
                add(listBox2, listBox1.SelectedItem.ToString());
                // 删除左框
                delete(listBox1,listBox1.SelectedItem.ToString());
            }
            else{
                MessageBox.Show("未选中listbox集合的值");
            }
        }

        // 左移
        private void button3_Click(object sender, EventArgs e) {
            //判断所有选中项集合大于0
            if(listBox2.SelectedItems.Count > 0) {
                // 添加右框
                add(listBox1, listBox2.SelectedItem.ToString());
                // 删除左框
                delete(listBox2,listBox2.SelectedItem.ToString());
            }
            else{
                MessageBox.Show("未选中listbox集合的值");
            }
        }
        // 删除 listbox item
        public void delete(ListBox listBox, string item) {
            if(!listBox.Items.Contains(item)) return;
            listBox.Items.Remove(item);
        }


        // 添加 listbox item
        public void add(ListBox listBox,string item) {
            //检查添加值是否添加过
            if(listBox.Items.Contains(item)) return;
            // 演示添加listBox的值
            listBox.Items.Add(item);
        }

    }
}