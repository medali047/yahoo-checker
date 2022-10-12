using System;
using System.IO;

// Token: 0x0200000E RID: 14
internal class Class7
{
	// Token: 0x0600003B RID: 59 RVA: 0x00004128 File Offset: 0x00002328
	public static void smethod_0(string string_0, string string_1, string string_2)
	{
		object obj = Class7.object_0;
		lock (obj)
		{
			File.AppendAllText(string.Concat(new string[]
			{
				"Results/",
				string_0,
				"/",
				Class6.string_4,
				"/",
				string_1,
				".txt"
			}), string_2 + Environment.NewLine);
		}
	}

	// Token: 0x04000035 RID: 53
	private static object object_0 = new object();
}
