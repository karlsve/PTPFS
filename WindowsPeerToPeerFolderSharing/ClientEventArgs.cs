using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WindowsPeerToPeerFolderSharing
{
	class ClientEventArgs : EventArgs
	{
		public readonly string Message;
		public readonly IPAddress Ip; 

		public ClientEventArgs(IPAddress ip, string message)
		{
			this.Ip = ip;
			this.Message = message;
		}
	}
}
