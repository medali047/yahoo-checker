using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using Colorful;
using Newtonsoft.Json;

// Token: 0x02000008 RID: 8
internal class Class2
{
	// Token: 0x06000019 RID: 25 RVA: 0x00002CF8 File Offset: 0x00000EF8
	public static Class2.Class3 smethod_0(bool bool_0)
	{
		Class5.smethod_0();
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("Choose a UIType.", ColorTranslator.FromHtml(Class5.string_2), 25);
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		Class5.smethod_1(" [1] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("CUI", ColorTranslator.FromHtml(Class5.string_2), 25);
		Colorful.Console.WriteLine();
		Class5.smethod_1(" [2] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("LOG", ColorTranslator.FromHtml(Class5.string_2), 25);
		Colorful.Console.WriteLine();
		Class2.class3_0.String_0 = Colorful.Console.ReadLine();
		Colorful.Console.WriteLine();
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("Enter a RefreshRate (in m.s) : ", ColorTranslator.FromHtml(Class5.string_2), 25);
		Class2.class3_0.Int32_0 = int.Parse(Colorful.Console.ReadLine());
		Colorful.Console.WriteLine();
		Class5.smethod_1(" [-] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("Enter a Retry amount : ", ColorTranslator.FromHtml(Class5.string_2), 25);
		Class2.class3_0.Int32_1 = int.Parse(Colorful.Console.ReadLine());
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		File.WriteAllText("settings.json", JsonConvert.SerializeObject(Class2.class3_0));
		Class5.smethod_1(" [!] ", ColorTranslator.FromHtml(Class5.string_3), 25);
		Class5.smethod_1("Config Saved.", ColorTranslator.FromHtml(Class5.string_2), 25);
		Colorful.Console.WriteLine();
		Colorful.Console.WriteLine();
		Colorful.Console.WriteFormatted(" {0} Press any key to continue to Main Menu.", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
		{
			"[-]"
		});
		Colorful.Console.ReadLine();
		Class4.smethod_0();
		return Class2.class3_0;
	}

	// Token: 0x04000013 RID: 19
	public static Class2.Class3 class3_0 = new Class2.Class3();

	// Token: 0x02000009 RID: 9
	public class Class3
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020C2 File Offset: 0x000002C2
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020CA File Offset: 0x000002CA
		public string String_0 { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000020D3 File Offset: 0x000002D3
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000020DB File Offset: 0x000002DB
		public int Int32_0 { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000020E4 File Offset: 0x000002E4
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000020EC File Offset: 0x000002EC
		public int Int32_1 { get; set; }

		// Token: 0x04000014 RID: 20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000015 RID: 21
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_0;

		// Token: 0x04000016 RID: 22
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int int_1;
	}
}
