using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace server
{
   public class Server
    {
        private readonly TcpListener _tcpListener;
        private readonly List<ClientHandler> _clients = new List<ClientHandler>();
        private const int MaxClientsNumber = 20;
        private bool IsRunning = false;
        public Thread threadServerMain;

        public event EventHandler<string> MessageReceived;
        public event EventHandler<string> MessageInfo;

        public Server(IPAddress ipAddress, int port)
        {
            _tcpListener = new TcpListener(ipAddress, port);
        }

        public void Start()
        {
            IsRunning = true;
            _tcpListener.Start();
            MessageToServer("The server is running.");

            while (IsRunning)
            {
                while (_clients.Count >= MaxClientsNumber) { }
                try {
                    TcpClient tcpClient = _tcpListener.AcceptTcpClient();
                    //MessageToServer("The new client is connected.");
                    ClientHandler clientHandler = new ClientHandler(tcpClient, this);
                    _clients.Add(clientHandler);
                    Thread clientThread = new Thread(clientHandler.HandleClient);
                    clientThread.Start();
                } catch{}
            }
        }

        public void BroadcastMessage(string message, ClientHandler sender)
        {
            MessageToAll(message);
            foreach (var client in _clients)
            {
                if (client != sender)
                {
                    client.SendMessage(message);
                }
            }
        }
        public void BroadcastMessage(string message)
        {
            MessageToAll(message);
            foreach (var client in _clients)
            {
                client.SendMessage(message);
            }
        }

        public void RemoveClient(ClientHandler client)
        {
            if (!_clients.Contains(client))
                return;
            _clients.Remove(client);
            client.Disconnect();
            if (!string.IsNullOrEmpty(client.GetNickname()))
            {
                BroadcastMessage($"Client {client.GetNickname()} is disabled.", client);
            }
            else
            {
                MessageToServer($"Noname client is disabled.");
            }
        }
        public void Stop()
        {
            // MessageToServer("The server is stopped.");
            BroadcastMessage("The server is stopped.");
            IsRunning = false;
            while (_clients.Count!=0)
            {
                var client = _clients[0];
                RemoveClient(client);
            }
            _tcpListener.Stop();
        }

        public static Server CreateServer(IPAddress ip, int port)
        {
            Server newServer = new Server(ip, port);
            return newServer;
        }

        public void MessageToAll(string message)
        {
            if (MessageReceived != null)
            {
                MessageReceived.Invoke(this, message);
            }
        }
        public void MessageToServer(string message)
        {
            if (MessageInfo != null)
            {
                MessageInfo.Invoke(this, message);
            }
        }
    }
}