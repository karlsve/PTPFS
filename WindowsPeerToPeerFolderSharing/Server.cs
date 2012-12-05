using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace WindowsPeerToPeerFolderSharing
{
    class Server
    {

		#region events
		public delegate void ServerEventHandler(object sender, ServerEventArgs e);
		public delegate void ServerClientEventHandler(object sender, ServerClientEventArgs e);

		public event ServerEventHandler onError;
		public event ServerEventHandler onStarted;
		public event ServerEventHandler onStopped;
		public event ServerClientEventHandler onClientConnected;
		public event ServerClientEventHandler onClientMessage;
		public event ServerClientEventHandler onClientDisconnected;


		void clientConnection_onDisconnected(object sender, ServerClientEventArgs e)
		{
			this.onClientDisconnected(sender, e);
		}

		void clientConnection_onMessage(object sender, ServerClientEventArgs e)
		{
			this.onClientMessage(sender, e);
		}

		void clientConnection_onConnected(object sender, ServerClientEventArgs e)
		{
			this.onClientConnected(sender, e);
		}
		#endregion

		#region variables
		private int port = 12345;
		private TcpListener listener;
		private bool run = true;
		#endregion

		public Server()
		{
		}

		#region thread functions
		public void init()
        {
			this.run = true;
			this.start();
        }

		private void start()
		{
			this.listener = new TcpListener(IPAddress.Loopback, port);
			try
			{
				this.listener.Start();
				ServerEventArgs e = new ServerEventArgs(port, "Server started on port " + port.ToString());
				this.onStarted(this, e);
			}
			catch (Exception e)
			{
				ServerEventArgs ex = new ServerEventArgs(port, e.Message);
				this.onError(this, ex);
			}
				
			while (run)
			{
				if (this.listener.Pending())
				{
					TcpClient client = this.listener.AcceptTcpClient();
					ServerClientConnection clientConnection = new ServerClientConnection(client);
					clientConnection.onConnected += clientConnection_onConnected;
					clientConnection.onMessage += clientConnection_onMessage;
					clientConnection.onDisconnected += clientConnection_onDisconnected;
					Thread clientThread = new Thread(clientConnection.init);
					clientThread.Start();
				}
			}
			this.listener.Stop();
			ServerEventArgs stoppedE = new ServerEventArgs(port, "Server stopped on port " + port.ToString());
			this.onStopped(this, stoppedE);
		}

		public void stop()
		{
			run = false;
		}
		#endregion
	}
}
