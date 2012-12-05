using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace WindowsPeerToPeerFolderSharing
{
	class Client
	{
		#region Events
		public delegate void ClientEventHandling(object sender, ClientEventArgs e);

		public event ClientEventHandling onMessageSent;
		public event ClientEventHandling onMessageReceived;
		public event ClientEventHandling onError;
		public event ClientEventHandling onConnected;
		public event ClientEventHandling onDisconnected;
		public event ClientEventHandling onStopped;
		#endregion

		#region Variables
		int port = 12345;
		public IPAddress ip;
		bool run = true;
		#endregion

		public Client(IPAddress ip)
		{
			this.ip = ip;
		}

		#region thread functions
		public void init()
		{
			run = true;
			this.start();
		}

		private void start()
		{
			DateTime last = DateTime.Now;
			while (run)
			{
				if (DateTime.Now >= last.AddMilliseconds(5000))
				{
					try
					{
						TcpClient client = new TcpClient();
						client.Connect(this.ip.ToString(), port);
						NetworkStream stream = client.GetStream();
						StreamWriter writer = new StreamWriter(stream);
						ClientEventArgs eConn = new ClientEventArgs(this.ip, "connected");
						this.onConnected(this, eConn);
						writer.WriteLine("getSharedData");
						writer.Flush();
						ClientEventArgs e = new ClientEventArgs(this.ip, "Message sent to server(" + this.ip.ToString() + ") with content \"getSharedData\".");
						this.onMessageSent(this, e);
						ClientEventArgs eDc = new ClientEventArgs(this.ip, "disconnected");
						this.onDisconnected(this, eDc);
						stream.Close();
						client.Close();
					}
					catch (Exception e)
					{
						onError(this, new ClientEventArgs(ip, e.Message));
					}
					last = DateTime.Now;
				}
			}
			this.onStopped(this, new ClientEventArgs(ip, "stopped"));
		}

		public void stop()
		{
			run = false;
		}
		#endregion
	}
}
