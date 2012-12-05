using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsPeerToPeerFolderSharing
{
    public partial class MainForm : Form
	{
		#region variables
		private Server server = null;
		private Thread serverThread = null;
		private bool running = true;
		private List<Client> clients = new List<Client>();
		#endregion

		public MainForm()
        {
            InitializeComponent();
			this.FormClosed += MainForm_FormClosed;
        }

		void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			running = false;
			foreach (Client client in clients)
			{
				client.stop();
			}
			if(server != null)
				server.stop();
		}

		#region button functions
		private void buttonStartStop_Click(object sender, EventArgs e)
		{
			if (this.buttonStart.Text == "Start Server")
			{
				if (server == null)
				{
					server = new Server();
					server.onStarted += server_onStarted;
					server.onError += server_onError;
					server.onStopped += server_onStopped;
					server.onClientConnected += server_onClientConnected;
					server.onClientMessage += server_onClientMessage;
					server.onClientDisconnected += server_onClientDisconnected;
				}
				if(serverThread != null)
					serverThread.Join();
				serverThread = new Thread(server.init);
				serverThread.Start();
				this.buttonStart.Text = "Stop Server";
			}
			else
			{
				server.stop();
				this.buttonStart.Text = "Start Server";
			}
		}

		private void buttonSendMessage_Click(object sender, EventArgs e)
		{
			IPAddress ip = IPAddress.Loopback;
			if(clients.Count() > 0)
			{
				foreach(Client current in clients)
				{
					if (current.ip == ip)
						return;
				}
			}
			Client client = new Client(ip);
			clients.Add(client);
			client.onMessageSent += client_onMessageSent;
			client.onMessageReceived += client_onMessageReceived;
			client.onError += client_onError;
			client.onConnected += client_onConnected;
			client.onDisconnected += client_onDisconnected;
			client.onStopped += client_onStopped;
			Thread clientThread = new Thread(client.init);
			clientThread.Start();
		}

#endregion

		#region event handling
		void server_onClientMessage(object sender, ServerClientEventArgs e)
		{
			this.textBoxLog.AppendTextThreadSafe(e.Message);
		}

		void server_onClientDisconnected(object sender, ServerClientEventArgs e)
		{
			//this.textBoxLog.AppendTextThreadSafe(e.Message);
		}

		void server_onClientConnected(object sender, ServerClientEventArgs e)
		{
			//this.textBoxLog.AppendTextThreadSafe(e.Message);
		}

		void server_onStopped(object sender, ServerEventArgs e)
		{
			if(this.running)
				this.textBoxLog.AppendTextThreadSafe(e.Message);
		}

		void server_onError(object sender, ServerEventArgs e)
		{
			this.textBoxLog.AppendTextThreadSafe(e.Message+"\n");
		}

		void server_onStarted(object sender, ServerEventArgs e)
		{
			this.textBoxLog.AppendTextThreadSafe(e.Message+"\n");
		}

		void client_onError(object sender, ClientEventArgs e)
		{
			this.textBoxLog.AppendTextThreadSafe(e.Message);
		}

		void client_onMessageReceived(object sender, ClientEventArgs e)
		{
			this.textBoxLog.AppendTextThreadSafe(e.Message);
		}

		void client_onMessageSent(object sender, ClientEventArgs e)
		{
			//this.textBoxLog.AppendTextThreadSafe(e.Message);
		}

		void client_onDisconnected(object sender, ClientEventArgs e)
		{
		}

		void client_onStopped(object sender, ClientEventArgs e)
		{
			if (sender is Client)
				clients.Remove((Client)sender);
		}

		void client_onConnected(object sender, ClientEventArgs e)
		{
		}
		#endregion

	}
}
