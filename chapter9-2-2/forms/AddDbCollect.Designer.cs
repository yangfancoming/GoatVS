using System.ComponentModel;

namespace chapter9_2_2.forms {
    partial class AddDbCollect {
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
            this.tb_jobCycle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_jobName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEsc = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tb_dbSql = new System.Windows.Forms.TextBox();
            this.tb_dbConstr = new System.Windows.Forms.TextBox();
            this.cbox_dbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_jobCycle
            // 
            this.tb_jobCycle.Location = new System.Drawing.Point(128, 74);
            this.tb_jobCycle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_jobCycle.Name = "tb_jobCycle";
            this.tb_jobCycle.Size = new System.Drawing.Size(140, 23);
            this.tb_jobCycle.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "任务周期：";
            // 
            // tb_jobName
            // 
            this.tb_jobName.Location = new System.Drawing.Point(128, 30);
            this.tb_jobName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_jobName.Name = "tb_jobName";
            this.tb_jobName.Size = new System.Drawing.Size(140, 23);
            this.tb_jobName.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "任务名称：";
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(170, 322);
            this.btnEsc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(90, 40);
            this.btnEsc.TabIndex = 19;
            this.btnEsc.Text = "取消";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(48, 322);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 40);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tb_dbSql
            // 
            this.tb_dbSql.Location = new System.Drawing.Point(128, 172);
            this.tb_dbSql.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_dbSql.Name = "tb_dbSql";
            this.tb_dbSql.Size = new System.Drawing.Size(140, 23);
            this.tb_dbSql.TabIndex = 17;
            // 
            // tb_dbConstr
            // 
            this.tb_dbConstr.Location = new System.Drawing.Point(128, 215);
            this.tb_dbConstr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_dbConstr.Multiline = true;
            this.tb_dbConstr.Name = "tb_dbConstr";
            this.tb_dbConstr.Size = new System.Drawing.Size(140, 82);
            this.tb_dbConstr.TabIndex = 16;
            // 
            // cbox_dbType
            // 
            this.cbox_dbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_dbType.FormattingEnabled = true;
            this.cbox_dbType.Location = new System.Drawing.Point(128, 120);
            this.cbox_dbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_dbType.Name = "cbox_dbType";
            this.cbox_dbType.Size = new System.Drawing.Size(140, 25);
            this.cbox_dbType.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "执行SQL：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "连接串：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "数据库类型：";
            // 
            // AddDbCollect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 391);
            this.Controls.Add(this.tb_jobCycle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_jobName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tb_dbSql);
            this.Controls.Add(this.tb_dbConstr);
            this.Controls.Add(this.cbox_dbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddDbCollect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库采集";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_jobName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_jobCycle;
        private System.Windows.Forms.ComboBox cbox_dbType;
        private System.Windows.Forms.TextBox tb_dbSql;
        private System.Windows.Forms.TextBox tb_dbConstr;
    }
}