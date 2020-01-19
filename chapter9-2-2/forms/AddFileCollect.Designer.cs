using System.ComponentModel;

namespace chapter9_2_2.forms {
    partial class AddFileCollect {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_fileType = new System.Windows.Forms.ComboBox();
            this.tb_fileMatched = new System.Windows.Forms.TextBox();
            this.tb_fileDirectory = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.tb_jobName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_jobCycle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件类型：";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "匹配条件：";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "所在目录：";
            this.cbox_fileType.FormattingEnabled = true;
            this.cbox_fileType.Location = new System.Drawing.Point(105, 94);
            this.cbox_fileType.Name = "cbox_fileType";
            this.cbox_fileType.Size = new System.Drawing.Size(121, 20);
            this.cbox_fileType.TabIndex = 3;
            this.tb_fileMatched.Location = new System.Drawing.Point(105, 126);
            this.tb_fileMatched.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_fileMatched.Name = "tb_fileMatched";
            this.tb_fileMatched.Size = new System.Drawing.Size(121, 21);
            this.tb_fileMatched.TabIndex = 4;
            this.tb_fileDirectory.Location = new System.Drawing.Point(105, 166);
            this.tb_fileDirectory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_fileDirectory.Multiline = true;
            this.tb_fileDirectory.Name = "tb_fileDirectory";
            this.tb_fileDirectory.Size = new System.Drawing.Size(121, 46);
            this.tb_fileDirectory.TabIndex = 5;
            this.btnSave.Location = new System.Drawing.Point(36, 235);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnEsc.Location = new System.Drawing.Point(141, 235);
            this.btnEsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(77, 28);
            this.btnEsc.TabIndex = 7;
            this.btnEsc.Text = "取消";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            this.tb_jobName.Location = new System.Drawing.Point(105, 30);
            this.tb_jobName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_jobName.Name = "tb_jobName";
            this.tb_jobName.Size = new System.Drawing.Size(121, 21);
            this.tb_jobName.TabIndex = 9;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "任务名称：";
            this.tb_jobCycle.Location = new System.Drawing.Point(105, 60);
            this.tb_jobCycle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_jobCycle.Name = "tb_jobCycle";
            this.tb_jobCycle.Size = new System.Drawing.Size(121, 21);
            this.tb_jobCycle.TabIndex = 11;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "任务周期：";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 276);
            this.Controls.Add(this.tb_jobCycle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_jobName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tb_fileDirectory);
            this.Controls.Add(this.tb_fileMatched);
            this.Controls.Add(this.cbox_fileType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFileCollect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加文件采集";
            this.Load += new System.EventHandler(this.AddFileCollect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbox_fileType;
        private System.Windows.Forms.TextBox tb_fileMatched;
        private System.Windows.Forms.TextBox tb_fileDirectory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_jobCycle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_jobName;
    }
}