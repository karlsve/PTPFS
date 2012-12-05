using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPeerToPeerFolderSharing
{
	class FolderSync
	{
		Boolean run = true;
		DatabaseHandling db = null;

		public FolderSync()
		{

		}

		public void init()
		{
			db = new DatabaseHandling();
			this.start();
		}

		private void start()
		{
			db.connect(); 
			DateTime last = DateTime.Now;
			while (run)
			{
				if (DateTime.Now >= last.AddMilliseconds(50000))
				{
					last = DateTime.Now;
				}
			}
		}

		public void stop()
		{
			run = false;
		}
	}
}
