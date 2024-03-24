namespace lab2
{
    partial class FormServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnStart = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(279, 326);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(243, 41);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start the server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(279, 246);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(243, 26);
            this.tbPort.TabIndex = 5;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(279, 119);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(243, 26);
            this.tbIP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(279, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter port:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(279, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter IP:";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormServer";
            this.Text = "Server start";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}