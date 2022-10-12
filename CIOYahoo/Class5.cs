using System;
using System.Drawing;
using System.Threading;
using Colorful;

// Token: 0x0200000B RID: 11
internal class Class5
{
	// Token: 0x06000026 RID: 38 RVA: 0x00003170 File Offset: 0x00001370
	public static void smethod_0()
	{
		Colorful.Console.Clear();
		Colorful.Console.Title = "C.IO Yahoo v1 - Made by SexyAzure | Thanks for using C.IO Yahoo ;)";
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLineFormatted("                                    :::   :::   :::     :::    :::  ::::::::   :::::::: ", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), Array.Empty<object>());
		Colorful.Console.WriteLineFormatted("                                   :+:   :+: :+: :+:   :+:    :+: :+:    :+: :+:    :+: ", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), Array.Empty<object>());
		Colorful.Console.WriteLineFormatted("                                   +:+ +:+ +:+   +:+  +:+    +:+ +:+    +:+ +:+    +:+  ", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), Array.Empty<object>());
		Colorful.Console.WriteLineFormatted("                                   +#++: +#++:++#++: +#++:++#++ +#+    +:+ +#+    +:+   ", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), Array.Empty<object>());
		Colorful.Console.WriteLineFormatted("                                   +#+  +#+     +#+ +#+    +#+ +#+    +#+ +#+    +#+    ", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), Array.Empty<object>());
		Colorful.Console.WriteLineFormatted("                                  #+#  #+#     #+# #+#    #+# #+#    #+# #+#    #+#     ", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), Array.Empty<object>());
		Colorful.Console.WriteLineFormatted("                                 ###  ###     ### ###    ###  cracked by ReverseTn ########   ########", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
		{
			"v1.0.0"
		});
		Colorful.Console.WriteLineFormatted("                                               {0}Cracked.io/********{1}******auth removed", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
		{
			"[",
			"]"
		});
		Colorful.Console.WriteLineFormatted("                                                      [{0}] ", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
		{
			"v1.0.0"
		});
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000032FC File Offset: 0x000014FC
	public static void smethod_1(string string_4, Color color_0, int int_0)
	{
		foreach (char value in string_4)
		{
			Colorful.Console.Write(value, color_0);
			Thread.Sleep(int_0);
		}
	}

	// Token: 0x04000017 RID: 23
	internal const string string_0 = "v1.0.0";

	// Token: 0x04000018 RID: 24
	internal const string string_1 = "v1";

	// Token: 0x04000019 RID: 25
	public static string string_2 = "#C5A3FF";

	// Token: 0x0400001A RID: 26
	public static string string_3 = "#77FFEA";
}
