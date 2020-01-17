namespace chapter4_2_8 {
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
            this.btnSqlserver = new System.Windows.Forms.Button();
            this.btnOracle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSqlserver
            // 
            this.btnSqlserver.Location = new System.Drawing.Point(78, 50);
            this.btnSqlserver.Name = "btnSqlserver";
            this.btnSqlserver.Size = new System.Drawing.Size(96, 37);
            this.btnSqlserver.TabIndex = 0;
            this.btnSqlserver.Text = "Sqlserver";
            this.btnSqlserver.UseVisualStyleBackColor = true;
            this.btnSqlserver.Click += new System.EventHandler(this.btnSqlserver_Click);
            // 
            // btnOracle
            // 
            this.btnOracle.Location = new System.Drawing.Point(213, 50);
            this.btnOracle.Name = "btnOracle";
            this.btnOracle.Size = new System.Drawing.Size(96, 37);
            this.btnOracle.TabIndex = 1;
            this.btnOracle.Text = "Oracle";
            this.btnOracle.UseVisualStyleBackColor = true;
            this.btnOracle.Click += new System.EventHandler(this.btnOracle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 127);
            this.Controls.Add(this.btnOracle);
            this.Controls.Add(this.btnSqlserver);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnOracle;
        private System.Windows.Forms.Button btnSqlserver;
    }
}