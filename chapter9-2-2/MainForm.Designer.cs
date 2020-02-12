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
            this.btnFileStop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFileDel = new System.Windows.Forms.Button();
            this.btnFileResume = new System.Windows.Forms.Button();
            this.btnFilePause = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTestDb = new System.Windows.Forms.Button();
            this.btnDbResume = new System.Windows.Forms.Button();
            this.btnDbPause = new System.Windows.Forms.Button();
            this.btnDbDel = new System.Windows.Forms.Button();
            this.btnDbStart = new System.Windows.Forms.Button();
            this.btnDbStop = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_MinioAccessKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_MiniosecretKey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_MinioEndpoint = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_DeviceCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_JavaUri = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_ftpDirRule = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ftpPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ftpPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ftpAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ftpAddr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.btnFileStart.Text = "开启监视";
            this.btnFileStart.UseVisualStyleBackColor = true;
            this.btnFileStart.Click += new System.EventHandler(this.btnStart_Click);
            //
            // btnFileStop
            //
            this.btnFileStop.Location = new System.Drawing.Point(668, 18);
            this.btnFileStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFileStop.Name = "btnFileStop";
            this.btnFileStop.Size = new System.Drawing.Size(80, 35);
            this.btnFileStop.TabIndex = 8;
            this.btnFileStop.Text = "关闭监视";
            this.btnFileStop.UseVisualStyleBackColor = true;
            this.btnFileStop.Click += new System.EventHandler(this.btnFileStop_Click);
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
            this.panel2.Controls.Add(this.btnFileDel);
            this.panel2.Controls.Add(this.btnFileResume);
            this.panel2.Controls.Add(this.btnFilePause);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnFileStart);
            this.panel2.Controls.Add(this.btnFileStop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 75);
            this.panel2.TabIndex = 0;
            //
            // btnFileDel
            //
            this.btnFileDel.Location = new System.Drawing.Point(160, 18);
            this.btnFileDel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFileDel.Name = "btnFileDel";
            this.btnFileDel.Size = new System.Drawing.Size(80, 35);
            this.btnFileDel.TabIndex = 16;
            this.btnFileDel.Text = "删除";
            this.btnFileDel.UseVisualStyleBackColor = true;
            this.btnFileDel.Click += new System.EventHandler(this.btnFileDel_Click);
            //
            // btnFileResume
            //
            this.btnFileResume.Location = new System.Drawing.Point(584, 18);
            this.btnFileResume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFileResume.Name = "btnFileResume";
            this.btnFileResume.Size = new System.Drawing.Size(80, 35);
            this.btnFileResume.TabIndex = 15;
            this.btnFileResume.Text = "恢复任务";
            this.btnFileResume.UseVisualStyleBackColor = false;
            this.btnFileResume.Visible = false;
            this.btnFileResume.Click += new System.EventHandler(this.btnFileResume_Click);
            //
            // btnFilePause
            //
            this.btnFilePause.Location = new System.Drawing.Point(496, 18);
            this.btnFilePause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilePause.Name = "btnFilePause";
            this.btnFilePause.Size = new System.Drawing.Size(80, 35);
            this.btnFilePause.TabIndex = 14;
            this.btnFilePause.Text = "暂停任务";
            this.btnFilePause.UseVisualStyleBackColor = false;
            this.btnFilePause.Visible = false;
            this.btnFilePause.Click += new System.EventHandler(this.btnFilePause_Click);
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
            this.panel4.Controls.Add(this.btnTestDb);
            this.panel4.Controls.Add(this.btnDbResume);
            this.panel4.Controls.Add(this.btnDbPause);
            this.panel4.Controls.Add(this.btnDbDel);
            this.panel4.Controls.Add(this.btnDbStart);
            this.panel4.Controls.Add(this.btnDbStop);
            this.panel4.Controls.Add(this.btnAddDb);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(945, 81);
            this.panel4.TabIndex = 0;
            //
            // btnTestDb
            //
            this.btnTestDb.Location = new System.Drawing.Point(164, 21);
            this.btnTestDb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTestDb.Name = "btnTestDb";
            this.btnTestDb.Size = new System.Drawing.Size(80, 35);
            this.btnTestDb.TabIndex = 14;
            this.btnTestDb.Text = "测试连接";
            this.btnTestDb.UseVisualStyleBackColor = true;
            this.btnTestDb.Click += new System.EventHandler(this.btnTestDb_Click);
            //
            // btnDbResume
            //
            this.btnDbResume.Location = new System.Drawing.Point(562, 21);
            this.btnDbResume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDbResume.Name = "btnDbResume";
            this.btnDbResume.Size = new System.Drawing.Size(80, 35);
            this.btnDbResume.TabIndex = 13;
            this.btnDbResume.Text = "恢复任务";
            this.btnDbResume.UseVisualStyleBackColor = false;
            this.btnDbResume.Visible = false;
            this.btnDbResume.Click += new System.EventHandler(this.btnDbResume_Click);
            //
            // btnDbPause
            //
            this.btnDbPause.Location = new System.Drawing.Point(475, 21);
            this.btnDbPause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDbPause.Name = "btnDbPause";
            this.btnDbPause.Size = new System.Drawing.Size(80, 35);
            this.btnDbPause.TabIndex = 12;
            this.btnDbPause.Text = "暂停任务";
            this.btnDbPause.UseVisualStyleBackColor = false;
            this.btnDbPause.Visible = false;
            this.btnDbPause.Click += new System.EventHandler(this.btnDbPause_Click);
            //
            // btnDbDel
            //
            this.btnDbDel.Location = new System.Drawing.Point(253, 21);
            this.btnDbDel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDbDel.Name = "btnDbDel";
            this.btnDbDel.Size = new System.Drawing.Size(80, 35);
            this.btnDbDel.TabIndex = 11;
            this.btnDbDel.Text = "删除";
            this.btnDbDel.UseVisualStyleBackColor = true;
            this.btnDbDel.Click += new System.EventHandler(this.btnDbDel_Click);
            //
            // btnDbStart
            //
            this.btnDbStart.Location = new System.Drawing.Point(388, 21);
            this.btnDbStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDbStart.Name = "btnDbStart";
            this.btnDbStart.Size = new System.Drawing.Size(80, 35);
            this.btnDbStart.TabIndex = 9;
            this.btnDbStart.Text = "开启任务";
            this.btnDbStart.UseVisualStyleBackColor = true;
            this.btnDbStart.Click += new System.EventHandler(this.btnDbStart_Click);
            //
            // btnDbStop
            //
            this.btnDbStop.Location = new System.Drawing.Point(650, 21);
            this.btnDbStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDbStop.Name = "btnDbStop";
            this.btnDbStop.Size = new System.Drawing.Size(80, 35);
            this.btnDbStop.TabIndex = 10;
            this.btnDbStop.Text = "关闭任务";
            this.btnDbStop.UseVisualStyleBackColor = true;
            this.btnDbStop.Click += new System.EventHandler(this.btnDbStop_Click);
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
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(953, 402);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "系统设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            //
            // groupBox4
            //
            this.groupBox4.Controls.Add(this.tb_MinioAccessKey);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tb_MiniosecretKey);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tb_MinioEndpoint);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(673, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(261, 264);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minio 配置";
            //
            // tb_MinioAccessKey
            //
            this.tb_MinioAccessKey.Location = new System.Drawing.Point(103, 78);
            this.tb_MinioAccessKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_MinioAccessKey.Name = "tb_MinioAccessKey";
            this.tb_MinioAccessKey.Size = new System.Drawing.Size(140, 23);
            this.tb_MinioAccessKey.TabIndex = 29;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "accessKey：";
            //
            // tb_MiniosecretKey
            //
            this.tb_MiniosecretKey.Location = new System.Drawing.Point(103, 122);
            this.tb_MiniosecretKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_MiniosecretKey.Name = "tb_MiniosecretKey";
            this.tb_MiniosecretKey.Size = new System.Drawing.Size(140, 23);
            this.tb_MiniosecretKey.TabIndex = 25;
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 126);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "secretKey：";
            //
            // tb_MinioEndpoint
            //
            this.tb_MinioEndpoint.Location = new System.Drawing.Point(103, 34);
            this.tb_MinioEndpoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_MinioEndpoint.Name = "tb_MinioEndpoint";
            this.tb_MinioEndpoint.Size = new System.Drawing.Size(140, 23);
            this.tb_MinioEndpoint.TabIndex = 23;
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "endpoint：";
            //
            // groupBox3
            //
            this.groupBox3.Controls.Add(this.tb_DeviceCode);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(10, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(334, 99);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设备编码 配置";
            //
            // tb_DeviceCode
            //
            this.tb_DeviceCode.Location = new System.Drawing.Point(106, 35);
            this.tb_DeviceCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_DeviceCode.Name = "tb_DeviceCode";
            this.tb_DeviceCode.Size = new System.Drawing.Size(194, 23);
            this.tb_DeviceCode.TabIndex = 25;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "设备编码：";
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.tb_JavaUri);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(10, 173);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(334, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "后台服务器 配置";
            //
            // tb_JavaUri
            //
            this.tb_JavaUri.Location = new System.Drawing.Point(108, 41);
            this.tb_JavaUri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_JavaUri.Name = "tb_JavaUri";
            this.tb_JavaUri.Size = new System.Drawing.Size(192, 23);
            this.tb_JavaUri.TabIndex = 25;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "服务器地址：";
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.tb_ftpDirRule);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_ftpPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_ftpPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_ftpAccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_ftpAddr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(370, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(282, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP 配置";
            //
            // tb_ftpDirRule
            //
            this.tb_ftpDirRule.FormattingEnabled = true;
            this.tb_ftpDirRule.Location = new System.Drawing.Point(121, 210);
            this.tb_ftpDirRule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ftpDirRule.Name = "tb_ftpDirRule";
            this.tb_ftpDirRule.Size = new System.Drawing.Size(140, 25);
            this.tb_ftpDirRule.TabIndex = 31;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "生成目录规则：";
            //
            // tb_ftpPort
            //
            this.tb_ftpPort.Location = new System.Drawing.Point(121, 78);
            this.tb_ftpPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_ftpPort.Name = "tb_ftpPort";
            this.tb_ftpPort.Size = new System.Drawing.Size(140, 23);
            this.tb_ftpPort.TabIndex = 29;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "ftp端口：";
            //
            // tb_ftpPassword
            //
            this.tb_ftpPassword.Location = new System.Drawing.Point(121, 166);
            this.tb_ftpPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_ftpPassword.Name = "tb_ftpPassword";
            this.tb_ftpPassword.Size = new System.Drawing.Size(140, 23);
            this.tb_ftpPassword.TabIndex = 27;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "密码：";
            //
            // tb_ftpAccount
            //
            this.tb_ftpAccount.Location = new System.Drawing.Point(121, 122);
            this.tb_ftpAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_ftpAccount.Name = "tb_ftpAccount";
            this.tb_ftpAccount.Size = new System.Drawing.Size(140, 23);
            this.tb_ftpAccount.TabIndex = 25;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "账号：";
            //
            // tb_ftpAddr
            //
            this.tb_ftpAddr.Location = new System.Drawing.Point(121, 34);
            this.tb_ftpAddr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_ftpAddr.Name = "tb_ftpAddr";
            this.tb_ftpAddr.Size = new System.Drawing.Size(140, 23);
            this.tb_ftpAddr.TabIndex = 23;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "ftp地址：";
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
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnFileStop;
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
        private System.Windows.Forms.Button btnDbStop;
        private System.Windows.Forms.Button btnDbStart;
        private System.Windows.Forms.Button btnDbPause;
        private System.Windows.Forms.Button btnDbResume;
        private System.Windows.Forms.Button btnFileStart;
        private System.Windows.Forms.Button btnFileDel;
        private System.Windows.Forms.Button btnTestDb;
        private System.Windows.Forms.Button btnFilePause;
        private System.Windows.Forms.Button btnFileResume;
        private System.Windows.Forms.Button btnDbDel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_ftpPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ftpPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ftpAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ftpAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tb_ftpDirRule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_DeviceCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_JavaUri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_MinioAccessKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_MiniosecretKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_MinioEndpoint;
        private System.Windows.Forms.Label label12;
    }
}