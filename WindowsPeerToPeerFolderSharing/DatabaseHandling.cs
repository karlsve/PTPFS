using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace WindowsPeerToPeerFolderSharing
{
	class DatabaseHandling
	{
		SQLiteConnection connection = null;
		String database = "db.db";

		public void connect()
		{
			connection = new SQLiteConnection("Data Source="+database);
			connection.Open();
		}

		public void execute(String query)
		{
			SQLiteCommand command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			command.Dispose();
		}

		public SQLiteDataReader query(String query)
		{
			SQLiteCommand command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			return reader;
		}

		public void disconnect()
		{
			if (connection != null)
				connection.Close();
		}
	}
}
