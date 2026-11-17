using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public static class PixelFont
{
	public const int W = default(int);

	public const int H = default(int);

	public const string AtlasChars = null;

	public const int AtlasCell = default(int);

	public const int AtlasCols = default(int);

	private static readonly Dictionary<char, byte[]> glyphs;

	public static bool Lit(char c, int x, int y)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_018b: Expected I4, but got Obj
		//IL_00d6: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+90]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		char key = char.ToUpperInvariant(c);
		if (obj5 != null)
		{
			if (!((Dictionary<char, System.__Canon>)obj5).TryGetValue(key, out System.__Canon value))
			{
				return false;
			}
			if (value != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ stack_-38_v4 (System.__Canon)+18]");
				bool flag3 = (nint)0 < (nint)y;
				object obj8 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ stack_-38_v4 (System.__Canon)+18]");
				object obj9 = -y;
				bool flag4 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag4;
				if (obj11 == null)
				{
					object obj12 = value + y;
					object obj13 = 4 - x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v13+20]");
					object obj14 = (nint)0 >> (int)obj13;
					return (byte)(obj14 & 1) != 0;
				}
				goto IL_017d;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_017d;
		IL_017d:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public static int Measure(string text, int scale = default(int))
	{
		//IL_009d: Expected I4, but got Obj
		//IL_0030: Expected Obj, but got I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected I4, but got Unknown
		if (text != null)
		{
			object obj = text._stringLength * 6;
			object obj2 = 4294967295L + obj;
			int result = obj2 * scale;
			if (text._stringLength == 0)
			{
				return 0;
			}
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static void Draw(Color32[] px, int w, int h, int x, int y, string text, Color32 top, Color32 bottom)
	{
		//IL_0035: Expected Obj, but got VT
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got VT
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got VT
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got VT
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got VT
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got VT
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got VT
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got VT
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_04f9: Invalid comparison between F8 and I4
		//IL_0508: Expected F8, but got I4
		//IL_0475: Expected Obj, but got F8
		//IL_04a0: Expected Obj, but got I4
		//IL_0567: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_0311: Expected Obj, but got I4
		if (text != null)
		{
			if (text._stringLength < 1)
			{
				return;
			}
			object obj = bottom >> 8;
			object obj2 = obj & 0xFF;
			object obj3 = top >> 8;
			object obj4 = obj3 & 0xFFFFFF;
			object obj5 = bottom & 0xFF;
			object obj6 = obj5 - top;
			object obj7 = bottom >> 16;
			object obj8 = obj7 & 0xFF;
			object obj9 = top >> 24;
			object obj10 = obj9 & 0xFF;
			object obj11 = obj2 - obj4;
			object obj12 = top >> 16;
			object obj13 = obj12 & 0xFFFF;
			object obj14 = top & 0xFF;
			object obj15 = top >> 16;
			object obj16 = obj15 & 0xFF;
			object obj17 = obj8 - obj13;
			object obj18 = bottom >> 24;
			object obj19 = obj18 & 0xFF;
			object obj20 = top >> 8;
			object obj21 = obj20 & 0xFF;
			object obj22 = obj19 - obj10;
			int num = ~y;
			object obj23 = num + h;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj24 = 0;
			object obj25 = w * obj23;
			object obj26 = x + obj25;
			object obj27 = -w;
			int num2 = x;
			int num3 = 0;
			while (true)
			{
				int num4 = 0;
				object obj28 = obj26;
				while (true)
				{
					double num5 = (double)num4 / 6.0;
					bool flag = num5 < 0.0;
					double num6 = 0.0;
					if (!flag)
					{
						bool flag2 = !(num5 > 1.0);
						num6 = num5;
						if (!flag2)
						{
							num6 = 1.0;
						}
					}
					double num7 = num6 * (double)obj22;
					double num8 = num6 * (double)obj17;
					double num9 = num6 * (double)obj11;
					double num10 = num6 * (double)obj6;
					double num11 = num7 + (double)obj10;
					double num12 = num8 + (double)obj16;
					double num13 = num10 + (double)obj14;
					double num14 = num9 + (double)obj21;
					object obj29 = num11 << 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
					object obj30 = num4 + y;
					int num15 = 0;
					while (true)
					{
						char c = text.get_Chars(num3);
						object obj31 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v21+E4]");
						bool flag3 = (nint)0 == 0;
						object obj32 = !flag3;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (Lit(c, num15, num4) && (nint)obj30 < h)
						{
							object obj33 = num2 + num15;
							if ((nint)obj33 < w)
							{
								object obj34 = obj33 | obj30;
								object obj35 = obj34 & 0x80000000L;
								bool flag4 = obj35 == null;
								object obj36 = !flag4;
								if (obj36 == null)
								{
									if (px == null)
									{
										break;
									}
									object obj37 = obj28 + num15;
									bool flag5 = (nint)obj37 < px.Length;
									object obj38 = !flag5;
									if (obj38 != null)
									{
										goto IL_03cb;
									}
									object obj39 = (object)px + obj37;
								}
							}
						}
						num15++;
						if (num15 != 5)
						{
							continue;
						}
						goto IL_0336;
					}
					break;
					IL_0336:
					num4++;
					obj28 += obj27;
					if (num4 != 7)
					{
						continue;
					}
					goto IL_0371;
				}
				break;
				IL_0371:
				num3++;
				num2 += 6;
				obj26 += 6;
				if (num3 >= text._stringLength)
				{
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_03cb;
		IL_03cb:
		throw new IndexOutOfRangeException();
	}

	public static void Draw(Color32[] px, int w, int h, int x, int y, string text, Color32 colour, int scale = default(int))
	{
		//IL_0035: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got I4
		//IL_005c: Unsupported input type for neg.
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0426: Expected Obj, but got I4
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_03e1: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0134: Expected Obj, but got I4
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected I4, but got Unknown
		//IL_0146: Expected Obj, but got I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01f2: Expected Obj, but got I4
		if (text != null)
		{
			if (text._stringLength < 1)
			{
				return;
			}
			object obj = -w;
			int num = ~y;
			object obj2 = scale + scale;
			object obj3 = scale * w;
			object obj4 = 0 - obj3;
			object obj5 = num + h;
			object obj6 = w * obj5;
			object obj7 = x + obj6;
			object obj8 = obj2 << 1;
			int num2 = x;
			object obj9 = obj4;
			int num3 = 0;
			string text2 = text;
			object obj17 = default;
			while (true)
			{
				object obj10 = obj7;
				int num4 = 0;
				while (true)
				{
					object obj11 = num4 * scale;
					object obj12 = y + obj11;
					int num5 = 0;
					object obj13 = obj10;
					int num6 = num4;
					int num7 = num2;
					while (true)
					{
						char c = text2.get_Chars(num3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
						object obj14 = 0;
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v16+E4]");
						bool flag = (nint)0 == 0;
						object obj16 = !flag;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag2 = Lit(c, num5, num4);
						if (scale >= 1 && flag2)
						{
							obj17 = obj17;
							object obj18 = obj13;
							object obj19 = 0;
							while (true)
							{
								obj9 = obj12 + obj19;
								num6 = 0;
								while (true)
								{
									if ((nint)obj9 < h)
									{
										obj17 = num7 + num6;
										if ((nint)obj17 < w)
										{
											obj17 = obj9 | obj17;
											object obj20 = obj17 & 0x80000000L;
											if (obj20 == null)
											{
												if (px == null)
												{
													break;
												}
												object obj21 = obj18 + num6;
												bool flag3 = (nint)obj21 < px.Length;
												object obj22 = !flag3;
												if (obj22 != null)
												{
													goto IL_0354;
												}
												obj17 = (object)px + obj21;
											}
										}
									}
									num6++;
									if (scale != num6)
									{
										continue;
									}
									goto IL_0217;
								}
								break;
								IL_0217:
								obj19++;
								obj18 += obj;
								if ((nint)obj19 != scale)
								{
									continue;
								}
								goto IL_0251;
							}
							break;
						}
						goto IL_0251;
						IL_0251:
						num5++;
						num7 += scale;
						obj13 += scale;
						bool flag4 = num5 != 5;
						text2 = text;
						if (flag4)
						{
							continue;
						}
						goto IL_02a1;
					}
					break;
					IL_02a1:
					num4++;
					obj10 += obj4;
					bool flag5 = num4 != 7;
					text2 = text;
					if (flag5)
					{
						continue;
					}
					goto IL_02e4;
				}
				break;
				IL_02e4:
				int num8 = num3 + 1;
				int num9 = num2 + obj8;
				obj7 += obj8;
				bool flag6 = num8 < text._stringLength;
				num2 = num9;
				num3 = num8;
				text2 = text;
				if (!flag6)
				{
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0354;
		IL_0354:
		throw new IndexOutOfRangeException();
	}

	public static void Fill(Color32[] px, int w, int h, int x, int y, int rw, int rh, Color32 colour)
	{
		//IL_0030: Expected Obj, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I4, but got Unknown
		//IL_008e: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected I4, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected I4, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I4
		//IL_0287: Expected Obj, but got I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_02a7: Expected Obj, but got I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		int num = rh + y;
		int num2 = ~y;
		int num3 = y & num2;
		object obj = h - num;
		bool flag = (nint)obj < 0;
		int num4 = h ^ num;
		int num5 = h ^ obj;
		int num6 = num4 & num5;
		bool flag2 = num6 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			num = h;
		}
		if (num3 >= num)
		{
			return;
		}
		int num7 = ~num3;
		int num8 = rw + x;
		object obj4 = num7 + h;
		int num9 = ~x;
		int num10 = x & num9;
		object obj5 = w - num8;
		bool flag4 = (nint)obj5 < 0;
		int num11 = w ^ num8;
		int num12 = w ^ obj5;
		int num13 = num11 & num12;
		bool flag5 = num13 < 0;
		bool flag6 = (byte)(w * obj4) != 0;
		object obj6 = num10 + (flag6 ? 1 : 0);
		bool flag7 = flag4 == flag5;
		object obj7 = !flag7;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			num8 = w;
		}
		object obj9 = num8 - num10;
		do
		{
			if (num10 < num8)
			{
				flag6 = px == null;
				object obj10 = obj6;
				bool flag9;
				do
				{
					bool flag8 = (nint)obj10 < px.Length;
					object obj11 = !flag8;
					if (obj11 == null)
					{
						object obj12 = (object)px + obj10;
						object obj13 = obj9 - 1;
						object obj14 = obj10 + 1;
						flag9 = (nint)obj13 != 1;
						obj10 = obj14;
						continue;
					}
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
					throw new NullReferenceException();
				}
				while (flag9);
			}
			num3++;
			obj6 -= w;
		}
		while (num3 != num);
	}

	public unsafe static Color32[] AtlasPixels(out int w, out int h)
	{
		//IL_0010: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0326: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected I4, but got Unknown
		//IL_0213: Expected VT, but got I8
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5A0]");
		object obj = 0;
		object obj2 = obj;
		bool flag = obj == null;
		Color32[] array = (Color32[])109895680;
		Color32[] result;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+10]");
			object obj3 = (nint)0 + (nint)15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+10]");
			object obj4 = (nint)0 + (nint)30;
			bool flag2 = (nint)obj3 < 0;
			object obj5 = obj3 ^ obj3;
			object obj6 = obj3 & obj5;
			bool flag3 = (nint)obj6 < 0;
			bool flag4 = flag2 == flag3;
			object obj7 = !flag4;
			object obj8 = ~obj7;
			if (obj8 != null)
			{
				obj4 = obj3;
			}
			object obj9 = obj4 >> 4;
			ref int reference = ref *(int*)128;
			object obj10 = obj9 << 3;
			ref int reference2 = ref *(int*)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj11 = 0;
			object obj12 = obj10 * w;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			string text = (string)obj;
			bool flag5 = obj == null;
			array = (Color32[])109895680;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj14 = 0;
				int num = 0;
				object obj15 = 0;
				Color32[] array2 = default;
				char c2 = default;
				object obj21;
				do
				{
					bool flag6 = num >= text._stringLength;
					result = array2;
					if (!flag6)
					{
						char c = text.get_Chars(num);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X29_v5+90]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v13+E4]");
						bool flag7 = (nint)0 == 0;
						object obj17 = !flag7;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text2 = c2.ToString();
						object obj18 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v14+E4]");
						bool flag8 = (nint)0 == 0;
						object obj19 = !flag8;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int num2 = num >> 1;
						object obj20 = obj15 & 0x78;
						int x = obj20 | 1;
						int y = num2 & 0x3FFFFFF8;
						Draw(array2, w, h, x, y, text2, (Color32)4294967295L, 1);
						text = (string)obj;
						num++;
						obj15 += 8;
						bool flag9 = obj == null;
						obj21 = !flag9;
						array = array2;
						continue;
					}
					return result;
				}
				while (obj21 != null);
			}
		}
		result = array;
		throw new NullReferenceException();
	}

	public static Rect AtlasRect(char c, int atlasW, int atlasH)
	{
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_0062: Expected VT, but got Obj
		//IL_004f: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		char value = char.ToUpperInvariant(c);
		if (obj3 != null)
		{
			return (Rect)((string)obj3).IndexOf(value);
		}
		NullReferenceException ex = new NullReferenceException();
		return (Rect)ex;
	}

	static PixelFont()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_01ad: Expected I4, but got Obj
		//IL_02f3: Expected Obj, but got I
		//IL_0324: Expected I4, but got Obj
		//IL_0343: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I
		//IL_0424: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I
		//IL_04ba: Expected Obj, but got I
		//IL_0505: Expected Obj, but got I
		//IL_0536: Expected I4, but got Obj
		//IL_0555: Expected Obj, but got I
		//IL_05a0: Expected Obj, but got I
		//IL_05eb: Expected Obj, but got I
		//IL_0636: Expected Obj, but got I
		//IL_0681: Expected Obj, but got I
		//IL_06cc: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I
		//IL_0762: Expected Obj, but got I
		//IL_0793: Expected I4, but got Obj
		//IL_07b2: Expected Obj, but got I
		//IL_07fd: Expected Obj, but got I
		//IL_0848: Expected Obj, but got I
		//IL_0893: Expected Obj, but got I
		//IL_08de: Expected Obj, but got I
		//IL_0929: Expected Obj, but got I
		//IL_0974: Expected Obj, but got I
		//IL_09bf: Expected Obj, but got I
		//IL_09f0: Expected I4, but got Obj
		//IL_0a0f: Expected Obj, but got I
		//IL_0a5a: Expected Obj, but got I
		//IL_0aa5: Expected Obj, but got I
		//IL_0af0: Expected Obj, but got I
		//IL_0b3b: Expected Obj, but got I
		//IL_0b86: Expected Obj, but got I
		//IL_0be3: Expected Obj, but got I4
		//IL_0bf9: Expected Obj, but got I
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected Obj, but got Unknown
		//IL_0c67: Expected Obj, but got I
		//IL_0c7d: Expected Obj, but got I
		//IL_0d2e: Expected Obj, but got I8
		//IL_0d5b: Expected Obj, but got I
		//IL_0d6b: Expected Obj, but got I
		//IL_0d7b: Expected Obj, but got I
		//IL_0d8b: Expected Obj, but got I
		//IL_0d9b: Expected Obj, but got I
		//IL_0dab: Expected Obj, but got I
		//IL_0dbb: Expected Obj, but got I
		//IL_0dcb: Expected Obj, but got I
		//IL_0fda: Expected Obj, but got I
		//IL_1025: Expected Obj, but got I
		//IL_1070: Expected Obj, but got I
		//IL_10cd: Expected Obj, but got I4
		//IL_10e3: Expected Obj, but got I
		//IL_1103: Unknown result type (might be due to invalid IL or missing references)
		//IL_1108: Expected Obj, but got Unknown
		//IL_115f: Expected Obj, but got I4
		//IL_1175: Expected Obj, but got I
		//IL_1195: Unknown result type (might be due to invalid IL or missing references)
		//IL_119a: Expected Obj, but got Unknown
		//IL_11ca: Expected Obj, but got I4
		//IL_11e0: Expected Obj, but got I
		//IL_1206: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Expected Obj, but got Unknown
		//IL_1229: Expected Obj, but got I
		//IL_1239: Expected Obj, but got I
		//IL_124f: Expected Obj, but got I
		//IL_12ef: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<char, System.__Canon> dictionary = default;
		dictionary._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v3+3]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5C0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE730]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE660]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5F0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5D8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6F0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE678]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE710]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE600]");
		object obj13 = 0;
		System.__Canon value = default;
		dictionary.Add('$', value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj14 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v6+3]");
		_ = 0;
		System.__Canon value2 = default;
		dictionary.Add(',', value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj15 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v8+3]");
		_ = 0;
		System.__Canon value3 = default;
		dictionary.Add('0', value3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj16 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v10+3]");
		_ = 0;
		System.__Canon value4 = default;
		dictionary.Add((char)(int)typeof(_0021_00210), value4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj17 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v12+3]");
		_ = 0;
		System.__Canon value5 = default;
		dictionary.Add('2', value5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj18 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v14+3]");
		_ = 0;
		System.__Canon value6 = default;
		dictionary.Add('3', value6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj19 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v16+3]");
		_ = 0;
		System.__Canon value7 = default;
		dictionary.Add('4', value7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj20 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v18+3]");
		_ = 0;
		System.__Canon value8 = default;
		dictionary.Add('5', value8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj21 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v20+3]");
		_ = 0;
		System.__Canon value9 = default;
		dictionary.Add('6', value9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE760]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v24+3]");
		_ = 0;
		System.__Canon value10 = default;
		dictionary.Add((char)(int)typeof(_0021_00210), value10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE618]");
		object obj24 = 0;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v28+3]");
		_ = 0;
		System.__Canon value11 = default;
		dictionary.Add('8', value11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE728]");
		object obj26 = 0;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v32+3]");
		_ = 0;
		System.__Canon value12 = default;
		dictionary.Add('9', value12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE680]");
		object obj28 = 0;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v36+3]");
		_ = 0;
		System.__Canon value13 = default;
		dictionary.Add('A', value13);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE720]");
		object obj30 = 0;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v40+3]");
		_ = 0;
		System.__Canon value14 = default;
		dictionary.Add('B', value14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6F8]");
		object obj32 = 0;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v44+3]");
		_ = 0;
		System.__Canon value15 = default;
		dictionary.Add('C', value15);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE748]");
		object obj34 = 0;
		object obj35 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v48+3]");
		_ = 0;
		System.__Canon value16 = default;
		dictionary.Add('D', value16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE740]");
		object obj36 = 0;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v52+3]");
		_ = 0;
		System.__Canon value17 = default;
		dictionary.Add((char)(int)typeof(_0021_00210), value17);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE648]");
		object obj38 = 0;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v56+3]");
		_ = 0;
		System.__Canon value18 = default;
		dictionary.Add('F', value18);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE708]");
		object obj40 = 0;
		object obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v60+3]");
		_ = 0;
		System.__Canon value19 = default;
		dictionary.Add('G', value19);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE640]");
		object obj42 = 0;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v64+3]");
		_ = 0;
		System.__Canon value20 = default;
		dictionary.Add('H', value20);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE658]");
		object obj44 = 0;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v68+3]");
		_ = 0;
		System.__Canon value21 = default;
		dictionary.Add('I', value21);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5E8]");
		object obj46 = 0;
		object obj47 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v72+3]");
		_ = 0;
		System.__Canon value22 = default;
		dictionary.Add('J', value22);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE650]");
		object obj48 = 0;
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v76+3]");
		_ = 0;
		System.__Canon value23 = default;
		dictionary.Add('K', value23);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE610]");
		object obj50 = 0;
		object obj51 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v80+3]");
		_ = 0;
		System.__Canon value24 = default;
		dictionary.Add('L', value24);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE768]");
		object obj52 = 0;
		object obj53 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v84+3]");
		_ = 0;
		System.__Canon value25 = default;
		dictionary.Add((char)(int)typeof(_0021_00210), value25);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6C0]");
		object obj54 = 0;
		object obj55 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v88+3]");
		_ = 0;
		System.__Canon value26 = default;
		dictionary.Add('N', value26);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6E8]");
		object obj56 = 0;
		object obj57 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v92+3]");
		_ = 0;
		System.__Canon value27 = default;
		dictionary.Add('O', value27);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE688]");
		object obj58 = 0;
		object obj59 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v96+3]");
		_ = 0;
		System.__Canon value28 = default;
		dictionary.Add('P', value28);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5E0]");
		object obj60 = 0;
		object obj61 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v100+3]");
		_ = 0;
		System.__Canon value29 = default;
		dictionary.Add('Q', value29);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE738]");
		object obj62 = 0;
		object obj63 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X8_v104+3]");
		_ = 0;
		System.__Canon value30 = default;
		dictionary.Add('R', value30);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6D0]");
		object obj64 = 0;
		object obj65 = obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v108+3]");
		_ = 0;
		System.__Canon value31 = default;
		dictionary.Add('S', value31);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE718]");
		object obj66 = 0;
		object obj67 = obj66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v112+3]");
		_ = 0;
		System.__Canon value32 = default;
		dictionary.Add('T', value32);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6E0]");
		object obj68 = 0;
		object obj69 = obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X8_v116+3]");
		_ = 0;
		System.__Canon value33 = default;
		dictionary.Add((char)(int)typeof(_0021_00210), value33);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5F8]");
		object obj70 = 0;
		object obj71 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v120+3]");
		_ = 0;
		System.__Canon value34 = default;
		dictionary.Add('V', value34);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE670]");
		object obj72 = 0;
		object obj73 = obj72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v124+3]");
		_ = 0;
		System.__Canon value35 = default;
		dictionary.Add('W', value35);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE620]");
		object obj74 = 0;
		object obj75 = obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X8_v128+3]");
		_ = 0;
		System.__Canon value36 = default;
		dictionary.Add('X', value36);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5C8]");
		object obj76 = 0;
		object obj77 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v132+3]");
		_ = 0;
		System.__Canon value37 = default;
		dictionary.Add('Y', value37);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE758]");
		object obj78 = 0;
		object obj79 = obj78;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v136+3]");
		_ = 0;
		System.__Canon value38 = default;
		dictionary.Add('Z', value38);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6A8]");
		object obj80 = 0;
		object obj81 = obj80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v140+3]");
		_ = 0;
		System.__Canon value39 = default;
		dictionary.Add(':', value39);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v124 (System.__Canon)+18]");
		bool flag = (nint)0 < (nint)5;
		object obj82 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v124 (System.__Canon)+18]");
		object obj83 = -5;
		bool flag2 = obj83 == null;
		object obj84 = ~obj82;
		object obj85 = obj84 | flag2;
		if (obj85 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v124 (System.__Canon)+18]");
			bool flag3 = (nint)0 == 6;
			_ = 12;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE5D0]");
				object obj86 = 0;
				_ = 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6B8]");
				object obj87 = 0;
				System.__Canon value40 = default;
				dictionary.Add('.', value40);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj88 = obj86;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v144+3]");
				_ = 0;
				System.__Canon value41 = default;
				dictionary.Add('!', value41);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj89 = obj87;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v146+3]");
				_ = 0;
				System.__Canon value42 = default;
				dictionary.Add('?', value42);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v135 (System.__Canon)+18]");
				object obj90 = 0 & 0xFFFFFFFCL;
				if (obj90 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE690]");
					object obj91 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE608]");
					object obj92 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE668]");
					object obj93 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6C8]");
					object obj94 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE750]");
					object obj95 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE698]");
					object obj96 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE630]");
					object obj97 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6B0]");
					object obj98 = 0;
					_ = 31;
					System.__Canon value43 = default;
					dictionary.Add('-', value43);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj99 = obj91;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X8_v150+3]");
					_ = 0;
					System.__Canon value44 = default;
					dictionary.Add('>', value44);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj100 = obj92;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X8_v152+3]");
					_ = 0;
					System.__Canon value45 = default;
					dictionary.Add('<', value45);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj101 = obj93;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X8_v154+3]");
					_ = 0;
					System.__Canon value46 = default;
					dictionary.Add('*', value46);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj102 = obj94;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X8_v156+3]");
					_ = 0;
					System.__Canon value47 = default;
					dictionary.Add('/', value47);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj103 = obj95;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v158+3]");
					_ = 0;
					System.__Canon value48 = default;
					dictionary.Add('#', value48);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj104 = obj96;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v160+3]");
					_ = 0;
					System.__Canon value49 = default;
					dictionary.Add('+', value49);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj105 = obj97;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X8_v162+3]");
					_ = 0;
					System.__Canon value50 = default;
					dictionary.Add('^', value50);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj106 = obj98;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X8_v164+3]");
					_ = 0;
					System.__Canon value51 = default;
					dictionary.Add('~', value51);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE628]");
					object obj107 = 0;
					object obj108 = obj107;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v168+3]");
					_ = 0;
					System.__Canon value52 = default;
					dictionary.Add('[', value52);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6A0]");
					object obj109 = 0;
					object obj110 = obj109;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v172+3]");
					_ = 0;
					System.__Canon value53 = default;
					dictionary.Add(']', value53);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE6D8]");
					object obj111 = 0;
					object obj112 = obj111;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X8_v176+3]");
					_ = 0;
					System.__Canon value54 = default;
					dictionary.Add('\'', value54);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v171 (System.__Canon)+18]");
					bool flag4 = (nint)0 < (nint)6;
					object obj113 = !flag4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v171 (System.__Canon)+18]");
					object obj114 = -6;
					bool flag5 = obj114 == null;
					object obj115 = ~obj113;
					object obj116 = obj115 | flag5;
					if (obj116 == null)
					{
						_ = 31;
						System.__Canon value55 = default;
						dictionary.Add('_', value55);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v174 (System.__Canon)+18]");
						bool flag6 = (nint)0 < (nint)2;
						object obj117 = !flag6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v174 (System.__Canon)+18]");
						object obj118 = -2;
						bool flag7 = obj118 == null;
						object obj119 = ~obj117;
						object obj120 = obj119 | flag7;
						if (obj120 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v174 (System.__Canon)+18]");
							bool flag8 = (nint)0 < (nint)4;
							object obj121 = !flag8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v174 (System.__Canon)+18]");
							object obj122 = -4;
							bool flag9 = obj122 == null;
							_ = 31;
							object obj123 = ~obj121;
							object obj124 = obj123 | flag9;
							if (obj124 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE700]");
								object obj125 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE638]");
								object obj126 = 0;
								_ = 31;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
								object obj127 = 0;
								System.__Canon value56 = default;
								dictionary.Add('=', value56);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								object obj128 = obj125;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X8_v181+3]");
								_ = 0;
								System.__Canon value57 = default;
								dictionary.Add('(', value57);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								object obj129 = obj126;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1085 @ X8_v183+3]");
								_ = 0;
								System.__Canon value58 = default;
								dictionary.Add(')', value58);
								object obj130 = obj127;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ X8_v185+A0]");
								object obj131 = 0;
								obj131 = dictionary;
								object obj132 = obj127;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								return;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
