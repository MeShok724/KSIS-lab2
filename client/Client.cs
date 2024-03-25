using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace client
{
    public class Client
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        private Thread receiveThread;

        public event EventHandler<string> MessageReceived;

        public string Nickname { get; set; }

        public Client(string nickname)
        {
            Nickname = nickname;
        }

        public void Connect(string ipAddress, int port)
        {
            try
            {
                tcpClient = new TcpClient(ipAddress, port);
                stream = tcpClient.GetStream();

                // Отправляем никнейм серверу
                byte[] nicknameBuffer = Encoding.UTF8.GetBytes(Nickname);
                stream.Write(nicknameBuffer, 0, nicknameBuffer.Length);

                // Запускаем поток для чтения сообщений от сервера
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                OnMessageReceived("Connection error: " + ex.Message);
            }
        }

        public void Disconnect()
        {
            stream.Close();
            tcpClient.Close();
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    OnMessageReceived(message);
                }
            }
            catch (Exception ex)
            {
                // OnMessageReceived("Error receiving messages: " + ex.Message);
            }
        }

        public void SendMessage(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);
            OnMessageReceived("You: " + message);
        }

        protected virtual void OnMessageReceived(string message)
        {
            MessageReceived?.Invoke(this, message);
        }
    }
}