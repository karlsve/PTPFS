using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace WindowsPeerToPeerFolderSharing
{
	class FolderDatabase : DatabaseHandling
	{
		public List<SharedFolder> getFolder()
		{
			List<SharedFolder> list = new List<SharedFolder>();
			SQLiteDataReader reader = this.query("SELECT * FROM sharedfolder ORDER BY id");
			while(reader.Read())
			{
				DirectoryInfo dir = new DirectoryInfo((string)reader["path"]);
				SharedFolder folder = new SharedFolder(dir);
				list.Add(folder);
			}
			return list;
		}
	}
}
