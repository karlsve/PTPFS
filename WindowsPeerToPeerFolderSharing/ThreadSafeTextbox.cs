using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPeerToPeerFolderSharing
{
	class ThreadSafeTextbox : System.Windows.Forms.TextBox
	{
		public void AppendTextThreadSafe(string input)
		{
			input = input + "\r\n";
			try
			{
				if (this.InvokeRequired)
				{
					this.Invoke(new Action<String>(this.AppendText), new object[] { input });
				}
				else
					this.AppendText(input);
			}
			catch (Exception)
			{
			}
		}
	}
}
