using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace server
{
    public class ClientHandler
    {
        private string _nickname;
        private readonly TcpClient _tcpClient;
        private readonly Server _server;
        private readonly NetworkStream _stream;
        private readonly Thread _receiveThread;

        public ClientHandler(TcpClient client, Server server)
        {
            _tcpClient = client;
            this._server = server;
            _stream = _tcpClient.GetStream();
            _receiveThread = new Thread(ReceiveMessages);
        }

        public void HandleClient()
        {
            _receiveThread.Start();
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                // Читаем первое сообщение, которое должно содержать имя клиента
                bytesRead = _stream.Read(buffer, 0, buffer.Length);
                _nickname = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                if (!string.IsNullOrEmpty(GetNickname()))
                {
                    _server.BroadcastMessage($"Client {_nickname} is connected.", this);   
                }
                else
                {
                    _server.MessageToServer($"Noname client is connected.");
                }
                while ((bytesRead = _stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    _server.BroadcastMessage($"{_nickname}: {message}", this);
                }
            }
            catch (Exception)
            {
                _server.RemoveClient(this);
            }
            finally
            {
                _stream.Close();
                _tcpClient.Close();
                _server.RemoveClient(this);
            }
        }

        public void SendMessage(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            _stream.Write(buffer, 0, buffer.Length);
        }

        public void Disconnect()
        {
            _stream.Close();
            _tcpClient.Close();
        }

        public string GetNickname()
        {
            return _nickname;
        }
    }
}