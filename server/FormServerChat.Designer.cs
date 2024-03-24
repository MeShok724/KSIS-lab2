using System.ComponentModel;

namespace lab2
{
    partial class FormServerChat
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
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbServer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(185, 447);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(541, 26);
            this.tbMessage.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(301, 513);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(196, 54);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbServer
            // 
            this.lbServer.FormattingEnabled = true;
            this.lbServer.ItemHeight = 20;
            this.lbServer.Location = new System.Drawing.Point(127, 59);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(672, 304);
            this.lbServer.TabIndex = 4;
            // 
            // FormServerChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 622);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbServer);
            this.Name = "FormServerChat";
            this.Text = "FormServerChat";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lbServer;

        #endregion
    }
}