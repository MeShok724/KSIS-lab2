using System.ComponentModel;

namespace server
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
            this.btnStopServer = new System.Windows.Forms.Button();
            this.lbServer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lIpAdress = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(177, 493);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(196, 54);
            this.btnStopServer.TabIndex = 5;
            this.btnStopServer.Text = "Stop server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // lbServer
            // 
            this.lbServer.FormattingEnabled = true;
            this.lbServer.ItemHeight = 20;
            this.lbServer.Location = new System.Drawing.Point(129, 119);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(813, 304);
            this.lbServer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(129, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chat:";
            // 
            // lIpAdress
            // 
            this.lIpAdress.Location = new System.Drawing.Point(499, 459);
            this.lIpAdress.Name = "lIpAdress";
            this.lIpAdress.Size = new System.Drawing.Size(443, 34);
            this.lIpAdress.TabIndex = 7;
            this.lIpAdress.Text = "IP adress of the server:";
            // 
            // lPort
            // 
            this.lPort.Location = new System.Drawing.Point(499, 510);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(452, 34);
            this.lPort.TabIndex = 7;
            this.lPort.Text = "Port number of the server:";
            // 
            // FormServerChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 629);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.lIpAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.lbServer);
            this.Name = "FormServerChat";
            this.Text = "Server Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServerChat_FormClosing);
            this.Load += new System.EventHandler(this.FormServerChat_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lIpAdress;
        private System.Windows.Forms.Label lPort;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.ListBox lbServer;

        #endregion
    }
}