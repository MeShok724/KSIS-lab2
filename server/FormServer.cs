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

namespace server
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
            tbIP.Text = "127.0.0.1";
            tbPort.Text = "8081";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string ipStr = tbIP.Text;
            string portStr = tbPort.Text;

            if (!CheckData(ipStr, portStr))
                return;

            Server server = Server.CreateServer(IPAddress.Parse(ipStr), int.Parse(portStr));
            FormServerChat formChat = new FormServerChat(server, ipStr, portStr);
            formChat.Show();
            this.Hide();
        }
        private bool CheckData(string ipStr, string portStr)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(ipStr);
                int port = int.Parse(portStr);
                TcpListener listener = new TcpListener(ipAddress, port);
                listener.Start();
                listener.Stop();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}