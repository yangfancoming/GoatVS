using System.ComponentModel;

namespace chapter9_2_2.forms {
    partial class AddSerialCollect {
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
            this.cbox5 = new System.Windows.Forms.ComboBox();
            this.cbox4 = new System.Windows.Forms.ComboBox();
            this.cbox2 = new System.Windows.Forms.ComboBox();
            this.cbox3 = new System.Windows.Forms.ComboBox();
            this.cbox1 = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_jobCycle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_jobName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbox5
            // 
            this.cbox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox5.FormattingEnabled = true;
            this.cbox5.Location = new System.Drawing.Point(127, 288);
            this.cbox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox5.Name = "cbox5";
            this.cbox5.Size = new System.Drawing.Size(114, 25);
            this.cbox5.TabIndex = 47;
            // 
            // cbox4
            // 
            this.cbox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox4.FormattingEnabled = true;
            this.cbox4.Location = new System.Drawing.Point(127, 245);
            this.cbox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox4.Name = "cbox4";
            this.cbox4.Size = new System.Drawing.Size(114, 25);
            this.cbox4.TabIndex = 45;
            // 
            // cbox2
            // 
            this.cbox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox2.FormattingEnabled = true;
            this.cbox2.Location = new System.Drawing.Point(127, 160);
            this.cbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox2.Name = "cbox2";
            this.cbox2.Size = new System.Drawing.Size(114, 25);
            this.cbox2.TabIndex = 46;
            // 
            // cbox3
            // 
            this.cbox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox3.FormattingEnabled = true;
            this.cbox3.Location = new System.Drawing.Point(127, 203);
            this.cbox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox3.Name = "cbox3";
            this.cbox3.Size = new System.Drawing.Size(114, 25);
            this.cbox3.TabIndex = 43;
            // 
            // cbox1
            // 
            this.cbox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox1.FormattingEnabled = true;
            this.cbox1.Location = new System.Drawing.Point(127, 116);
            this.cbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(114, 25);
            this.cbox1.TabIndex = 44;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(47, 334);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 33);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(180, 334);
            this.btnEsc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(79, 33);
            this.btnEsc.TabIndex = 42;
            this.btnEsc.Text = "取消";
            this.btnEsc.UseVisualStyleBackColor = false;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "停止位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "校检位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "串口号";
            // 
            // tb_jobCycle
            // 
            this.tb_jobCycle.Location = new System.Drawing.Point(127, 74);
            this.tb_jobCycle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_jobCycle.Name = "tb_jobCycle";
            this.tb_jobCycle.Size = new System.Drawing.Size(114, 23);
            this.tb_jobCycle.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "任务周期：";
            // 
            // tb_jobName
            // 
            this.tb_jobName.Location = new System.Drawing.Point(127, 33);
            this.tb_jobName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_jobName.Name = "tb_jobName";
            this.tb_jobName.Size = new System.Drawing.Size(114, 23);
            this.tb_jobName.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "任务名称：";
            // 
            // AddSerialCollect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 391);
            this.Controls.Add(this.tb_jobCycle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_jobName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox5);
            this.Controls.Add(this.cbox4);
            this.Controls.Add(this.cbox2);
            this.Controls.Add(this.cbox3);
            this.Controls.Add(this.cbox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddSerialCollect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口采集";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbox1;
        private System.Windows.Forms.ComboBox cbox3;
        private System.Windows.Forms.ComboBox cbox2;
        private System.Windows.Forms.ComboBox cbox4;
        private System.Windows.Forms.ComboBox cbox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_jobName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_jobCycle;
    }
}