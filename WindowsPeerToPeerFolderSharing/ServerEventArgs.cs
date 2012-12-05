using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPeerToPeerFolderSharing
{
	class ServerEventArgs : EventArgs
	{
		public readonly int Port;
		public readonly string Message;

		public ServerEventArgs(int port, string message)
		{
			this.Port = port;
			this.Message = message;
		}
	}
}
