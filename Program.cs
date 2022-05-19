using System;
using System.Windows.Forms;

namespace 批量修改
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MYForm());
		}
	}
}
