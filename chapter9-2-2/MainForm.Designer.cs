using System.ComponentModel;

namespace chapter9_2_2 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAddSerial = new System.Windows.Forms.Button();
            this.btnAddDb = new System.Windows.Forms.Button();
            this.btnFileStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnFileStop = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDbStart = new System.Windows.Forms.Button();
            this.btnDBStop = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            //
            // dataGridView1
            //
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(945, 315);
            this.dataGridView1.TabIndex = 0;
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(52, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(20, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增文件采集";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDel
            //
            this.btnDel.Location = new System.Drawing.Point(488, 30);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 35);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            //
            // btnSettings
            //
            this.btnSettings.Location = new System.Drawing.Point(584, 30);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(80, 35);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "系统设置";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            //
            // btnAddSerial
            //
            this.btnAddSerial.Location = new System.Drawing.Point(248, 30);
            this.btnAddSerial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddSerial.Name = "btnAddSerial";
            this.btnAddSerial.Size = new System.Drawing.Size(105, 35);
            this.btnAddSerial.TabIndex = 5;
            this.btnAddSerial.Text = "新增串口采集";
            this.btnAddSerial.UseVisualStyleBackColor = true;
            this.btnAddSerial.Click += new System.EventHandler(this.btnAddSerial_Click);
            //
            // btnAddDb
            //
            this.btnAddDb.Location = new System.Drawing.Point(49, 21);
            this.btnAddDb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddDb.Name = "btnAddDb";
            this.btnAddDb.Size = new System.Drawing.Size(92, 35);
            this.btnAddDb.TabIndex = 6;
            this.btnAddDb.Text = "新增DB采集";
            this.btnAddDb.UseVisualStyleBackColor = true;
            this.btnAddDb.Click += new System.EventHandler(this.btnAddDb_Click);
            //
            // btnFileStart
            //
            this.btnFileStart.Location = new System.Drawing.Point(396, 18);
            this.btnFileStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFileStart.Name = "btnFileStart";
            this.btnFileStart.Size = new System.Drawing.Size(80, 35);
            this.btnFileStart.TabIndex = 7;
            this.btnFileStart.Text = "开启任务";
            this.btnFileStart.UseVisualStyleBackColor = true;
            this.btnFileStart.Click += new System.EventHandler(this.btnStart_Click);
            //
            // btnStop
            //
            this.btnStop.Location = new System.Drawing.Point(668, 18);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 35);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "关闭任务";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(24, 91);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 428);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(953, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文件采集";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // panel1
            //
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 390);
            this.panel1.TabIndex = 0;
            //
            // panel3
            //
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 315);
            this.panel3.TabIndex = 1;
            //
            // panel2
            //
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnFileStop);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnFileStart);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 75);
            this.panel2.TabIndex = 0;
            //
            // button7
            //
            this.button7.Location = new System.Drawing.Point(160, 18);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 35);
            this.button7.TabIndex = 16;
            this.button7.Text = "删除";
            this.button7.UseVisualStyleBackColor = true;
            //
            // button5
            //
            this.button5.Location = new System.Drawing.Point(584, 18);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 35);
            this.button5.TabIndex = 15;
            this.button5.Text = "恢复任务";
            this.button5.UseVisualStyleBackColor = true;
            //
            // btnFileStop
            //
            this.btnFileStop.Location = new System.Drawing.Point(496, 18);
            this.btnFileStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFileStop.Name = "btnFileStop";
            this.btnFileStop.Size = new System.Drawing.Size(80, 35);
            this.btnFileStop.TabIndex = 14;
            this.btnFileStop.Text = "暂停任务";
            this.btnFileStop.UseVisualStyleBackColor = true;
            this.btnFileStop.Click += new System.EventHandler(this.btnFileStop_Click);
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(953, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据库采集";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // panel5
            //
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 85);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(945, 309);
            this.panel5.TabIndex = 1;
            //
            // dataGridView2
            //
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(945, 309);
            this.dataGridView2.TabIndex = 1;
            //
            // panel4
            //
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnDbStart);
            this.panel4.Controls.Add(this.btnDBStop);
            this.panel4.Controls.Add(this.btnAddDb);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(945, 81);
            this.panel4.TabIndex = 0;
            //
            // button4
            //
            this.button4.Location = new System.Drawing.Point(458, 21);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "恢复任务";
            this.button4.UseVisualStyleBackColor = true;
            //
            // button3
            //
            this.button3.Location = new System.Drawing.Point(371, 21);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "暂停任务";
            this.button3.UseVisualStyleBackColor = true;
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(149, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            //
            // btnDbStart
            //
            this.btnDbStart.Location = new System.Drawing.Point(284, 21);
            this.btnDbStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDbStart.Name = "btnDbStart";
            this.btnDbStart.Size = new System.Drawing.Size(80, 35);
            this.btnDbStart.TabIndex = 9;
            this.btnDbStart.Text = "开启任务";
            this.btnDbStart.UseVisualStyleBackColor = true;
            this.btnDbStart.Click += new System.EventHandler(this.btnDbStart_Click);
            //
            // btnDBStop
            //
            this.btnDBStop.Location = new System.Drawing.Point(552, 21);
            this.btnDBStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDBStop.Name = "btnDBStop";
            this.btnDBStop.Size = new System.Drawing.Size(80, 35);
            this.btnDBStop.TabIndex = 10;
            this.btnDBStop.Text = "关闭任务";
            this.btnDBStop.UseVisualStyleBackColor = true;
            this.btnDBStop.Click += new System.EventHandler(this.btnDBStop_Click);
            //
            // tabPage3
            //
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(953, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "串口采集";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // tabPage4
            //
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(953, 402);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "系统设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            //
            // rtbLog
            //
            this.rtbLog.Location = new System.Drawing.Point(29, 540);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(951, 350);
            this.rtbLog.TabIndex = 10;
            this.rtbLog.Text = "";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 908);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnAddSerial);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据采集工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAddSerial;
        private System.Windows.Forms.Button btnAddDb;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnDBStop;
        private System.Windows.Forms.Button btnDbStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnFileStop;
        private System.Windows.Forms.Button btnFileStart;
    }
}