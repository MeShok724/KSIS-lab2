using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace client
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            tbIP.Text = "127.0.0.1";
            tbPort.Text = "8081";
            tbNickname.Text = "User1";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Client client = new Client(tbNickname.Text);
            string ip = tbIP.Text;
            string port = tbPort.Text;
            if (!IsIpAddressAndPortValid(ip, port))
                return;
            client.Connect(ip, int.Parse(port));
            FormClientChat form = new FormClientChat(client);
            form.Show();
            Hide();
        }
        static bool IsIpAddressAndPortValid(string ipAddress, string port)
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    tcpClient.Connect(ipAddress, int.Parse(port));
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect to the server");
                return false;
            }
        }
    }
}