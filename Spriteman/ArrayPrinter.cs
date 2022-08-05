using System;
using System.Text;

namespace M4EC
{
	// Token: 0x02000006 RID: 6
	internal class ArrayPrinter
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000025D8 File Offset: 0x000007D8
		public static string Print<T>(T[] array)
		{
			if (array.Length == 0)
			{
				return "";
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(array[0]);
			for (int i = 1; i < array.Length; i++)
			{
				string value = string.Format(",{0}", array[i]);
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
	}
}
