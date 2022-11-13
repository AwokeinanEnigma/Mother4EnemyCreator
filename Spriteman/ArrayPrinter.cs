using System;
using System.Text;

namespace M4EC
{
	internal class ArrayPrinter
	{
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
