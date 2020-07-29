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
            this.label5 = new System.Windows.Forms.Label();
            this.tb_json = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_yanqian = new System.Windows.Forms.Button();
            this.btn_jiaqian = new System.Windows.Forms.Button();
            this.tb_private = new System.Windows.Forms.TextBox();
            this.tb_public = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tb_result);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_json);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_yanqian);
            this.tabPage2.Controls.Add(this.btn_jiaqian);
            this.tabPage2.Controls.Add(this.tb_private);
            this.tabPage2.Controls.Add(this.tb_public);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(565, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "加签验签";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "报文：";
            // 
            // tb_json
            // 
            this.tb_json.Location = new System.Drawing.Point(110, 261);
            this.tb_json.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_json.Multiline = true;
            this.tb_json.Name = "tb_json";
            this.tb_json.Size = new System.Drawing.Size(399, 80);
            this.tb_json.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "私钥：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "公钥：";
            // 
            // btn_yanqian
            // 
            this.btn_yanqian.Location = new System.Drawing.Point(384, 5);
            this.btn_yanqian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_yanqian.Name = "btn_yanqian";
            this.btn_yanqian.Size = new System.Drawing.Size(103, 48);
            this.btn_yanqian.TabIndex = 36;
            this.btn_yanqian.Text = "验签↑";
            this.btn_yanqian.UseVisualStyleBackColor = true;
            this.btn_yanqian.Click += new System.EventHandler(this.btn_yanqian_Click);
            // 
            // btn_jiaqian
            // 
            this.btn_jiaqian.Location = new System.Drawing.Point(260, 5);
            this.btn_jiaqian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_jiaqian.Name = "btn_jiaqian";
            this.btn_jiaqian.Size = new System.Drawing.Size(103, 48);
            this.btn_jiaqian.TabIndex = 35;
            this.btn_jiaqian.Text = "加签↓";
            this.btn_jiaqian.UseVisualStyleBackColor = true;
            this.btn_jiaqian.Click += new System.EventHandler(this.btn_jiaqian_Click);
            // 
            // tb_private
            // 
            this.tb_private.Location = new System.Drawing.Point(110, 161);
            this.tb_private.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_private.Multiline = true;
            this.tb_private.Name = "tb_private";
            this.tb_private.Size = new System.Drawing.Size(399, 80);
            this.tb_private.TabIndex = 34;
            // 
            // tb_public
            // 
            this.tb_public.Location = new System.Drawing.Point(110, 62);
            this.tb_public.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_public.Multiline = true;
            this.tb_public.Name = "tb_public";
            this.tb_public.Size = new System.Drawing.Size(399, 80);
            this.tb_public.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "方式：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 25);
            this.comboBox1.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "结果：";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(110, 349);
            this.tb_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(399, 48);
            this.tb_result.TabIndex = 41;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_yanqian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_private;
        private System.Windows.Forms.TextBox tb_public;
        private System.Windows.Forms.TextBox tb_json;
        private System.Windows.Forms.Button btn_jiaqian;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label label7;
    }
}