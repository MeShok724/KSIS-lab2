using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace server
{
    public partial class FormServerChat : Form
    {
        private Server _server;
        public FormServerChat(Server server, string ipStr, string portStr)
        {
            InitializeComponent();
            lIpAdress.Text += " "+ipStr;
            lPort.Text += " "+portStr;
            _server = server;
        }
        private void FormServerChat_Load(object sender, EventArgs e)
        {
            lbServer.Text = "";
            // IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            // int port = 8888; // Используем порт 8888
            // _server = new Server(ipAddress, port);
            _server.MessageReceived += Server_MessageReceived;
            _server.MessageInfo += Server_MessageReceived;
            _server.threadServerMain = new Thread(_server.Start);
            _server.threadServerMain.Start();
        }
        private void Server_MessageReceived(object sender, string message)
        {
            // Обработка полученного сообщения
            if (!string.IsNullOrEmpty(message))
            {
                AddMessageToListBox(message);
            }
        }
        private void AddMessageToListBox(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddMessageToListBox), message);
                return;
            }
            lbServer.Items.Add(message);
        }

        private void FormServerChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            _server.Stop();
            Application.Exit();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            _server.Stop();
        }
    }
}