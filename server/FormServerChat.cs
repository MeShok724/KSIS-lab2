using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace lab2
{
    public partial class FormServerChat : Form
    {
        public static IPAddress ipAddress;
        public static int port;
        private TcpListener server;
        private NetworkStream stream;
        public FormServerChat()
        {
            InitializeComponent();
            lbServer.Text = "";
            server = new TcpListener(ipAddress, port);
            server.Start();
            Thread acceptThread = new Thread(() =>
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    lbServer.Invoke(new Action(() =>
                    {
                        lbServer.Items.Add("The client was connected");
                    }));
                    
                    ClientHandler(client);
                    break;
                }
            });
            acceptThread.Start();
        }
        private void ClientHandler(object obj)
        {
            TcpClient client = (TcpClient)obj;
            stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;
            try
            {
                // Поток для чтения сообщений от клиента
                Thread receiveThread = new Thread(() =>
                {
                    while (true)
                    {
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        lbServer.Invoke(new Action(() =>
                        {
                            lbServer.Items.Add("Client: " + receivedMessage);
                        }));
                    }
                });
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                lbServer.Invoke(new Action(() =>
                {
                    lbServer.Items.Add("Ошибка: " + ex.Message);
                }));
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = tbMessage.Text;
            lbServer.Items.Add("You: " + message);
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
    }
}