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
        public static IPAddress ipAddress;
        public static int port;
        // IPEndPoint endPoint;
        // Socket socket;
        private NetworkStream stream;
        
        public FormClientChat()
        {
            InitializeComponent();
            lbClient.Text = "";
                // endPoint = new IPEndPoint(ipAddress, port);
                // socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // socket.Connect(endPoint);
            
            // Подключение к серверу
            TcpClient client = new TcpClient(ipAddress.ToString(), port);
            stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;
            Thread receiveThread = new Thread(() =>
            {
                while (true)
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    lbClient.Items.Add("Server: " + receivedMessage);
                }
            });
            receiveThread.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = tbMessage.Text;
            lbClient.Items.Add("You: " + message);
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
    }
}