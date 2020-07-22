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
            this.SuspendLayout();
            this.btn_md5.Location = new System.Drawing.Point(55, 48);
            this.btn_md5.Name = "btn_md5";
            this.btn_md5.Size = new System.Drawing.Size(95, 41);
            this.btn_md5.TabIndex = 0;
            this.btn_md5.Text = "md5";
            this.btn_md5.UseVisualStyleBackColor = true;
            this.btn_md5.Click += new System.EventHandler(this.btn_md5_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 637);
            this.Controls.Add(this.btn_md5);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_md5;
    }
}