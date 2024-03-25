using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace client
{
    public partial class FormClientChat : Form
    {
        private Client _client;
        public static IPAddress ipAddress;
        public static int port;
        private NetworkStream stream;
        
        public FormClientChat(Client client)
        {
            InitializeComponent();
            lbClient.Text = "";
            lbClient.Items.Add("You are connected.");
            _client = client;
            client.MessageReceived += Client_MessageReceived;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = tbMessage.Text;
            _client.SendMessage(message);
            tbMessage.Text = "";
        }
        private void Client_MessageReceived(object sender, string message)
        {
            AddMessageToListBox(message);
        }
        private void AddMessageToListBox(string message)
        {
            if (lbClient.InvokeRequired)
            {
                try
                {
                    Invoke(new Action<string>(AddMessageToListBox), message);
                }
                catch { }
                return;
            }

            lbClient.Items.Add(message);
        }

        private void FormClientChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.Disconnect();
            Application.Exit();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _client.Disconnect();
            lbClient.Items.Add("You are disconnected.");
            Application.Exit();
        }
    }
}