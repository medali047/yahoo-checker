using System;
using System.Drawing;
using System.IO;
using System.Net;
using Colorful;
using Newtonsoft.Json;

// Token: 0x0200000A RID: 10
internal class Class4
{
	// Token: 0x06000023 RID: 35 RVA: 0x00002ED0 File Offset: 0x000010D0
	[STAThread]
	private static void Main(string[] args)
	{
		Class5.smethod_0();
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("Choose a option.", ColorTranslator.FromHtml(Class5.string_2), 25);
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLineFormatted(" {0} Login", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
		{
			"[1]"
		});
		Colorful.Console.WriteLineFormatted(" {0} Exit", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
		{
			"[2]"
		});
		ConsoleKey key = Colorful.Console.ReadKey(true).Key;
		ConsoleKey consoleKey = key;
		if (consoleKey <= ConsoleKey.D2)
		{
			if (consoleKey == ConsoleKey.D1)
			{
				goto IL_C9;
			}
			if (consoleKey != ConsoleKey.D2)
			{
				return;
			}
		}
		else
		{
			if (consoleKey == ConsoleKey.NumPad1)
			{
				goto IL_C9;
			}
			if (consoleKey != ConsoleKey.NumPad2)
			{
				return;
			}
		}
		Environment.Exit(0);
		return;
		IL_C9:
		Class0.smethod_1();
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002FAC File Offset: 0x000011AC
	public static void smethod_0()
	{
		string path = "settings.json";
		Class2.class3_0 = (File.Exists(path) ? JsonConvert.DeserializeObject<Class2.Class3>(File.ReadAllText(path)) : Class2.smethod_0(true));
		Class5.smethod_0();
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("Choose a option.", ColorTranslator.FromHtml(Class5.string_2), 25);
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		Colorful.Console.Write(" Welcome to CIOYahoo Made by SexyAzure. cracked by ReverseTn", ColorTranslator.FromHtml(Class5.string_3));
		Colorful.Console.WriteLine();
		Colorful.Console.Write(" Join the discord... ************", ColorTranslator.FromHtml(Class5.string_3));
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLineFormatted(" {0} Start Checking", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
		{
			"[1]"
		});
		Colorful.Console.WriteLineFormatted(" {0} Settings", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
		{
			"[2]"
		});
		Colorful.Console.WriteLineFormatted(" {0} Links", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
		{
			"[3]"
		});
		Colorful.Console.WriteLineFormatted(" {0} Exit", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
		{
			"[4]"
		});
		ConsoleKey key = Colorful.Console.ReadKey(true).Key;
		ConsoleKey consoleKey = key;
		switch (consoleKey)
		{
		case ConsoleKey.D1:
			break;
		case ConsoleKey.D2:
		case ConsoleKey.D3:
		case ConsoleKey.D4:
			return;
		default:
			switch (consoleKey)
			{
			case ConsoleKey.NumPad1:
				break;
			case ConsoleKey.NumPad2:
			case ConsoleKey.NumPad3:
			case ConsoleKey.NumPad4:
				return;
			default:
				return;
			}
			break;
		}
		Class6.string_2 = Class2.class3_0.String_0;
		Class6.list_0.Add(new Func<string[], string, bool>(Class8.smethod_0));
		Class6.smethod_0();
	}
}
