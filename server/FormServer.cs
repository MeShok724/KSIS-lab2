using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!IsPortAvailable(int.Parse(tbPort.Text)))
            {
                MessageBox.Show("The port is not available");
                return;
            }
            
            FormServerChat.ipAddress = IPAddress.Parse(tbIP.Text);
            FormServerChat.port = int.Parse(tbPort.Text);
            FormServerChat form = new FormServerChat();
            form.Show();
            this.Hide();
        }
        static bool IsPortAvailable(int port)
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
                listener.Stop();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}