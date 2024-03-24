using System.ComponentModel;

namespace client
{
    partial class FormClientChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbClient = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbClient
            // 
            this.lbClient.FormattingEnabled = true;
            this.lbClient.ItemHeight = 20;
            this.lbClient.Location = new System.Drawing.Point(72, 70);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(672, 304);
            this.lbClient.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(246, 524);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(196, 54);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(130, 458);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(541, 26);
            this.tbMessage.TabIndex = 3;
            // 
            // FormClientChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 687);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbClient);
            this.Name = "FormClientChat";
            this.Text = "Client chat";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbMessage;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        private System.Windows.Forms.Button btnSend;

        private System.Windows.Forms.ListBox lbClient;

        #endregion
    }
}