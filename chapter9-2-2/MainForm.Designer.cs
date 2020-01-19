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
            this.jobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSuffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileMatched = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileDirectory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            //
            // dataGridView1
            //
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.jobName, this.jobType, this.jobCycle, this.createTime, this.fileSuffix, this.fileMatched, this.fileDirectory});
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(961, 273);
            this.dataGridView1.TabIndex = 0;
            //
            // jobName
            //
            this.jobName.HeaderText = "任务名称";
            this.jobName.Name = "jobName";
            this.jobName.ReadOnly = true;
            //
            // jobType
            //
            this.jobType.HeaderText = "任务类型";
            this.jobType.Name = "jobType";
            this.jobType.ReadOnly = true;
            //
            // jobCycle
            //
            this.jobCycle.HeaderText = "任务周期";
            this.jobCycle.Name = "jobCycle";
            this.jobCycle.ReadOnly = true;
            //
            // createTime
            //
            this.createTime.HeaderText = "创建时间";
            this.createTime.Name = "createTime";
            this.createTime.ReadOnly = true;
            //
            // fileSuffix
            //
            this.fileSuffix.HeaderText = "文件后缀";
            this.fileSuffix.Name = "fileSuffix";
            this.fileSuffix.ReadOnly = true;
            //
            // fileMatched
            //
            this.fileMatched.HeaderText = "匹配条件";
            this.fileMatched.Name = "fileMatched";
            this.fileMatched.ReadOnly = true;
            //
            // fileDirectory
            //
            this.fileDirectory.HeaderText = "所在目录";
            this.fileDirectory.Name = "fileDirectory";
            this.fileDirectory.ReadOnly = true;
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
            this.btnAdd.Location = new System.Drawing.Point(150, 30);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDel
            //
            this.btnDel.Location = new System.Drawing.Point(252, 30);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 35);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            //
            // button4
            //
            this.button4.Location = new System.Drawing.Point(349, 30);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 374);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobType;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSuffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileMatched;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileDirectory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
    }
}