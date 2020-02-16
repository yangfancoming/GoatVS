namespace chapter5_3_5 {
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
            this.CombServer = new System.Windows.Forms.ComboBox();
            this.txtReceiveMessage = new System.Windows.Forms.RichTextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSubscribe = new System.Windows.Forms.Button();
            this.txtSubTopic = new System.Windows.Forms.TextBox();
            this.txtPubTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSendMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CombServer
            // 
            this.CombServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombServer.FormattingEnabled = true;
            this.CombServer.Location = new System.Drawing.Point(28, 13);
            this.CombServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CombServer.Name = "CombServer";
            this.CombServer.Size = new System.Drawing.Size(108, 25);
            this.CombServer.TabIndex = 10;
            this.CombServer.SelectedIndexChanged += new System.EventHandler(this.CombServer_SelectedIndexChanged);
            // 
            // txtReceiveMessage
            // 
            this.txtReceiveMessage.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiveMessage.Location = new System.Drawing.Point(115, 91);
            this.txtReceiveMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReceiveMessage.Name = "txtReceiveMessage";
            this.txtReceiveMessage.Size = new System.Drawing.Size(315, 124);
            this.txtReceiveMessage.TabIndex = 11;
            this.txtReceiveMessage.Text = "";
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Location = new System.Drawing.Point(598, 10);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(84, 33);
            this.BtnClear.TabIndex = 13;
            this.BtnClear.Text = "清空";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSubscribe
            // 
            this.BtnSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSubscribe.Location = new System.Drawing.Point(509, 10);
            this.BtnSubscribe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSubscribe.Name = "BtnSubscribe";
            this.BtnSubscribe.Size = new System.Drawing.Size(84, 33);
            this.BtnSubscribe.TabIndex = 12;
            this.BtnSubscribe.Text = "订阅";
            this.BtnSubscribe.UseVisualStyleBackColor = true;
            this.BtnSubscribe.Click += new System.EventHandler(this.BtnSubscribe_Click);
            // 
            // txtSubTopic
            // 
            this.txtSubTopic.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTopic.Location = new System.Drawing.Point(236, 16);
            this.txtSubTopic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubTopic.Name = "txtSubTopic";
            this.txtSubTopic.Size = new System.Drawing.Size(254, 23);
            this.txtSubTopic.TabIndex = 14;
            // 
            // txtPubTopic
            // 
            this.txtPubTopic.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPubTopic.Location = new System.Drawing.Point(196, 242);
            this.txtPubTopic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPubTopic.Name = "txtPubTopic";
            this.txtPubTopic.Size = new System.Drawing.Size(235, 23);
            this.txtPubTopic.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "发布主题";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(437, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "发布";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "订阅主题";
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendMessage.Location = new System.Drawing.Point(134, 276);
            this.txtSendMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(324, 127);
            this.txtSendMessage.TabIndex = 19;
            this.txtSendMessage.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 416);
            this.Controls.Add(this.txtSendMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPubTopic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubTopic);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSubscribe);
            this.Controls.Add(this.txtReceiveMessage);
            this.Controls.Add(this.CombServer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox CombServer;
        private System.Windows.Forms.RichTextBox txtReceiveMessage;
        private System.Windows.Forms.Button BtnSubscribe;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox txtSubTopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPubTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtSendMessage;
    }
}