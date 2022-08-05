using System;
using System.Windows.Forms;

namespace M4EC
{
	// Token: 0x0200000A RID: 10
	internal static class Program
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000066ED File Offset: 0x000048ED
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
