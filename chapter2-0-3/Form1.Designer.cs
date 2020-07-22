namespace chapter2_0_3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btn_md5 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_jiemi = new System.Windows.Forms.Button();
            this.btn_jiami = new System.Windows.Forms.Button();
            this.tb_4 = new System.Windows.Forms.TextBox();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_miyao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_md5
            // 
            this.btn_md5.Location = new System.Drawing.Point(595, 47);
            this.btn_md5.Name = "btn_md5";
            this.btn_md5.Size = new System.Drawing.Size(94, 41);
            this.btn_md5.TabIndex = 0;
            this.btn_md5.Text = "md5";
            this.btn_md5.UseVisualStyleBackColor = true;
            this.btn_md5.Click += new System.EventHandler(this.btn_md5_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(573, 443);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_jiemi);
            this.tabPage1.Controls.Add(this.btn_jiami);
            this.tabPage1.Controls.Add(this.tb_4);
            this.tabPage1.Controls.Add(this.tb_3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tb_miyao);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cb_type);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(565, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "加密解密";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "密文：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "明文：";
            // 
            // btn_jiemi
            // 
            this.btn_jiemi.Location = new System.Drawing.Point(317, 238);
            this.btn_jiemi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_jiemi.Name = "btn_jiemi";
            this.btn_jiemi.Size = new System.Drawing.Size(103, 48);
            this.btn_jiemi.TabIndex = 26;
            this.btn_jiemi.Text = "解密↑";
            this.btn_jiemi.UseVisualStyleBackColor = true;
            this.btn_jiemi.Click += new System.EventHandler(this.btn_jiemi_Click);
            // 
            // btn_jiami
            // 
            this.btn_jiami.Location = new System.Drawing.Point(129, 238);
            this.btn_jiami.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_jiami.Name = "btn_jiami";
            this.btn_jiami.Size = new System.Drawing.Size(103, 48);
            this.btn_jiami.TabIndex = 25;
            this.btn_jiami.Text = "加密↓";
            this.btn_jiami.UseVisualStyleBackColor = true;
            this.btn_jiami.Click += new System.EventHandler(this.btn_jiami_Click);
            // 
            // tb_4
            // 
            this.tb_4.Location = new System.Drawing.Point(80, 312);
            this.tb_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_4.Multiline = true;
            this.tb_4.Name = "tb_4";
            this.tb_4.Size = new System.Drawing.Size(399, 80);
            this.tb_4.TabIndex = 24;
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(80, 139);
            this.tb_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_3.Multiline = true;
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(399, 80);
            this.tb_3.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "密钥：";
            // 
            // tb_miyao
            // 
            this.tb_miyao.Location = new System.Drawing.Point(80, 86);
            this.tb_miyao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_miyao.Name = "tb_miyao";
            this.tb_miyao.Size = new System.Drawing.Size(383, 23);
            this.tb_miyao.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "方式：";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(80, 16);
            this.cb_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(129, 25);
            this.cb_type.TabIndex = 19;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(565, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "加签验签";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 482);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_md5);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_md5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_miyao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_3;
        private System.Windows.Forms.TextBox tb_4;
        private System.Windows.Forms.Button btn_jiami;
        private System.Windows.Forms.Button btn_jiemi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}