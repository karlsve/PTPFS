using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsPeerToPeerFolderSharing
{
	class SharedFolder
	{
		protected readonly DirectoryInfo dir = null;

		public SharedFolder(DirectoryInfo dir)
		{
			this.dir = dir;
		}
	}
}
