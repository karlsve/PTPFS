using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace WindowsPeerToPeerFolderSharing
{
	class ServerClientConnection
	{
		#region events
		public delegate void ServerClientEventHandler(object sender, ServerClientEventArgs e);

		public event ServerClientEventHandler onConnected;
		public event ServerClientEventHandler onMessage;
		public event ServerClientEventHandler onDisconnected;
		#endregion

		#region variables
		TcpClient client;
		bool connected = true;
		#endregion

		public ServerClientConnection(TcpClient client)
		{
			this.client = client;
		}

		#region thread functions
		public void init()
		{
			NetworkStream stream = this.client.GetStream();
			Byte[] readBuffer = new byte[1024];
			StreamReader reader = new StreamReader(stream);
			IPAddress ip = ((IPEndPoint)client.Client.RemoteEndPoint).Address;

			onConnected(this, new ServerClientEventArgs(ip, "Connected"));
			while (this.connected)
			{
				if(stream.DataAvailable)
				{
					String message = reader.ReadLine();
					ServerClientEventArgs e = new ServerClientEventArgs(ip, ip+": "+message.ToString());
					onMessage(this, e);
					if (message.Equals("getSharedData"))
					{
						Console.Out.WriteLine(message);
					}
				}
				if (client.Client.Poll(0, SelectMode.SelectRead))
				{
					byte[] checkConn = new byte[1];
					if (client.Client.Receive(checkConn, SocketFlags.Peek) == 0)
						this.connected = false;
				}
			}
			stream.Close();
			client.Close();
			onDisconnected(this, new ServerClientEventArgs(ip, "Disconnected"));
		}
		#endregion
	}
}
