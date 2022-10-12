using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Colorful;

// Token: 0x02000002 RID: 2
internal class Class0
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002228 File Offset: 0x00000428
	private static string smethod_0(string string_0)
	{
		string result;
		using (SHA256 sha = SHA256.Create())
		{
			byte[] array = sha.ComputeHash(Encoding.UTF8.GetBytes(string_0));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			result = stringBuilder.ToString();
		}
		return result;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000022A4 File Offset: 0x000004A4
	public static void smethod_1()
	{
		string text = "";
		if (File.Exists("key.cto"))
		{
			text = File.ReadAllText("key.cto");
		}
		else
		{
			Class5.smethod_0();
			Colorful.Console.WriteFormatted(" {0} Enter your c.io Key : ", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
			{
				"[-]"
			});
			text = Colorful.Console.ReadLine();
		}
	

			Class5.smethod_0();
		Colorful.Console.Write(" fuck you cracked io");
			{
			
			}
			Class4.smethod_0();
		      
		}
}

