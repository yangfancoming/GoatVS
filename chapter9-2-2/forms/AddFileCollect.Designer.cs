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
            this.cb_handlerOld = new System.Windows.Forms.CheckBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "匹配条件：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "监视目录：";
            // 
            // cbox_fileType
            // 
            this.cbox_fileType.FormattingEnabled = true;
            this.cbox_fileType.Location = new System.Drawing.Point(105, 103);
            this.cbox_fileType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_fileType.Name = "cbox_fileType";
            this.cbox_fileType.Size = new System.Drawing.Size(140, 25);
            this.cbox_fileType.TabIndex = 3;
            // 
            // tb_fileMatched
            // 
            this.tb_fileMatched.Location = new System.Drawing.Point(106, 164);
            this.tb_fileMatched.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_fileMatched.Name = "tb_fileMatched";
            this.tb_fileMatched.Size = new System.Drawing.Size(140, 23);
            this.tb_fileMatched.TabIndex = 4;
            // 
            // tb_fileDirectory
            // 
            this.tb_fileDirectory.Location = new System.Drawing.Point(105, 222);
            this.tb_fileDirectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_fileDirectory.Name = "tb_fileDirectory";
            this.tb_fileDirectory.Size = new System.Drawing.Size(140, 23);
            this.tb_fileDirectory.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 324);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(164, 324);
            this.btnEsc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(90, 40);
            this.btnEsc.TabIndex = 7;
            this.btnEsc.Text = "取消";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // tb_jobName
            // 
            this.tb_jobName.Location = new System.Drawing.Point(105, 42);
            this.tb_jobName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_jobName.Name = "tb_jobName";
            this.tb_jobName.Size = new System.Drawing.Size(140, 23);
            this.tb_jobName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "任务名称：";
            // 
            // cb_handlerOld
            // 
            this.cb_handlerOld.Location = new System.Drawing.Point(105, 275);
            this.cb_handlerOld.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_handlerOld.Name = "cb_handlerOld";
            this.cb_handlerOld.Size = new System.Drawing.Size(140, 24);
            this.cb_handlerOld.TabIndex = 13;
            this.cb_handlerOld.Text = "处理已有文件";
            this.cb_handlerOld.UseVisualStyleBackColor = true;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(253, 220);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(66, 33);
            this.btnBrowser.TabIndex = 14;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // AddFileCollect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 391);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.cb_handlerOld);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddFileCollect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件采集";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_jobName;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.CheckBox cb_handlerOld;
    }
}