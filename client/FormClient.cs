using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // if (IsIpAddressAndPortValid(tbIP.Text, int.Parse(tbPort.Text)))
            // {
            //     MessageBox.Show("Server not found");
            //     return;
            // }
            FormClientChat.ipAddress = IPAddress.Parse(tbIP.Text);
            FormClientChat.port = int.Parse(tbPort.Text);
            FormClientChat form = new FormClientChat();
            form.Show();
            this.Hide();
        }
        static bool IsIpAddressAndPortValid(string ipAddress, int port)
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    tcpClient.Connect(ipAddress, port);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}