using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WindowsPeerToPeerFolderSharing
{
	class ServerClientEventArgs : EventArgs
	{
		public readonly IPAddress Client;
		public readonly string Message;

		public ServerClientEventArgs(IPAddress client, string message)
		{
			this.Client = client;
			this.Message = message;
		}
	}
}
