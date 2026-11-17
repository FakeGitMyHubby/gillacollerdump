using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

public sealed class ScreenFont
{
	public enum Action
	{
		// error: enumerator has no value
		TearLeftArm,
		// error: enumerator has no value
		TearRightArm,
		// error: enumerator has no value
		TearHead,
		// error: enumerator has no value
		ResetAll
	}

	private struct Glyph
	{
		public int advance;

		public int x;

		public int y;

		public int w;

		public int h;

		public int[] rows;
	}

	public readonly int size;

	public readonly int ascent;

	public readonly int descent;

	public readonly int cap;

	private readonly Dictionary<char, Glyph> glyphs;

	private readonly Glyph space;

	public unsafe ScreenFont(string baked)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I4
		//IL_08c4: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_089d: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I8
		//IL_011b: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I8
		//IL_0216: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_028e: Expected Obj, but got I8
		//IL_02cc: Expected Obj, but got I4
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected Ref, but got Unknown
		//IL_030d: Expected Obj, but got Ref
		//IL_031d: Expected Obj, but got I
		//IL_0922: Expected Obj, but got I4
		//IL_0358: Expected Obj, but got I
		//IL_07eb: Expected Obj, but got I4
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Obj, but got Unknown
		//IL_03d1: Expected Obj, but got I4
		//IL_03f3: Expected Obj, but got I8
		//IL_0443: Expected Obj, but got I4
		//IL_0453: Expected Obj, but got I4
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_04b1: Expected Obj, but got I8
		//IL_0501: Expected Obj, but got I4
		//IL_0511: Expected Obj, but got I4
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_0577: Expected Obj, but got I4
		//IL_0587: Expected Obj, but got I4
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected Obj, but got Unknown
		//IL_05ed: Expected Obj, but got I
		//IL_060a: Expected Obj, but got Ref
		//IL_064e: Expected I4, but got I8
		//IL_0660: Expected Obj, but got I4
		//IL_08e0: Expected Obj, but got I4
		//IL_08fb: Expected Obj, but got I4
		//IL_07cc: Expected VT, but got Ref
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected Obj, but got Unknown
		//IL_06a4: Expected Obj, but got I4
		//IL_06d7: Expected Obj, but got I
		//IL_0701: Expected Obj, but got I4
		//IL_071c: Expected Obj, but got I4
		//IL_073c: Expected I4, but got I8
		//IL_0768: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE8B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<char, Glyph> dictionary = default;
		dictionary._002Ector();
		object obj2 = this + 32;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		string[] array = baked.Split('\n', (StringSplitOptions)0);
		object obj3 = array.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4208]");
		object value = 0;
		object obj5;
		if (array.Length >= 1)
		{
			object obj4 = array + 32;
			obj5 = 0;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
				object obj6 = !flag;
				if (obj6 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X20_v9+v346 @ X19_v4*8]");
				if (((string)0).StartsWith((string)value))
				{
					obj3 = array.Length;
					obj5++;
					if ((nint)obj5 < array.Length)
					{
						continue;
					}
				}
				else
				{
					obj3 = array.Length;
				}
				goto IL_08ab;
			}
			goto IL_083a;
		}
		obj5 = 0;
		goto IL_08ab;
		IL_08ab:
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
		object obj7 = !flag2;
		if (obj7 == null)
		{
			object obj8 = (object)array + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v6+20]");
			string[] array2 = ((string)0).Split(' ', (StringSplitOptions)0);
			if ((object)(array2.Length & 0xFFFFFFFEL) != null)
			{
				size = int.Parse(array2[1]);
				if ((object)(array2.Length & 0xFFFFFFFCL) != null)
				{
					ascent = int.Parse(array2[3]);
					if ((object)(~(object)(array2.Length >= 5) | ((object)(array2.Length - 5) == null)) == null)
					{
						descent = int.Parse(array2[5]);
						if ((object)(array2.Length & 0xFFFFFFF8L) != null)
						{
							int num = int.Parse(array2[7]);
							object obj9 = array.Length;
							object obj10 = obj5 + 1;
							cap = num;
							if ((nint)obj10 >= array.Length)
							{
								goto IL_0817;
							}
							int num2 = default;
							object obj11 = (object)(&num2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC120]");
							object obj12 = 0;
							int num3 = 0;
							num2 = 0;
							int num14 = default;
							int num17 = default;
							while (true)
							{
								bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
								object obj13 = !flag3;
								if (obj13 != null)
								{
									break;
								}
								object obj14 = (object)array + obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v18+20]");
								string text = ((string)0).Trim();
								string[] array3 = text.Split(' ', (StringSplitOptions)0);
								int num4;
								if (array3.Length >= 6)
								{
									bool flag4 = array3[0].StartsWith((string)value);
									bool flag5 = !flag4;
									object obj15 = !flag5;
									if (obj15 == null)
									{
										object obj16 = array3.Length & 0xFFFFFFFEL;
										if (obj16 == null)
										{
											break;
										}
										num4 = int.Parse(array3[1]);
										bool flag6 = array3.Length < 2;
										object obj17 = !flag6;
										object obj18 = array3.Length - 2;
										bool flag7 = obj18 == null;
										object obj19 = ~obj17;
										object obj20 = obj19 | flag7;
										if (obj20 != null)
										{
											break;
										}
										int num5 = int.Parse(array3[2]);
										object obj21 = array3.Length & 0xFFFFFFFCL;
										if (obj21 == null)
										{
											break;
										}
										int num6 = int.Parse(array3[3]);
										bool flag8 = array3.Length < 4;
										object obj22 = !flag8;
										object obj23 = array3.Length - 4;
										bool flag9 = obj23 == null;
										object obj24 = ~obj22;
										object obj25 = obj24 | flag9;
										if (obj25 != null)
										{
											break;
										}
										int num7 = int.Parse(array3[4]);
										bool flag10 = array3.Length < 5;
										object obj26 = !flag10;
										object obj27 = array3.Length - 5;
										bool flag11 = obj27 == null;
										object obj28 = ~obj26;
										object obj29 = obj28 | flag11;
										if (obj29 != null)
										{
											break;
										}
										int num8 = int.Parse(array3[5]);
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
										object obj30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num2, 6));
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										bool flag12 = num8 < 1;
										int num9 = num6;
										int num10 = num5;
										if (!flag12)
										{
											int num11 = 0;
											int num12 = 0;
											object obj32 = 0;
											int num13 = num14;
											while (true)
											{
												object obj33 = num12 + 6;
												bool flag13 = (nint)obj33 < array3.Length;
												object obj34 = !flag13;
												if (obj34 != null)
												{
													break;
												}
												object obj35 = obj12;
												object obj36 = array3 + num11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X0_v52+E4]");
												bool flag14 = (nint)0 == 0;
												object obj37 = !flag14;
												if (obj37 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v37+20]");
												int num15 = Convert.ToInt32((string)0, 16);
												int num16 = num12;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v44 (System.Int32)+18]");
												bool flag15 = (nint)num16 < (nint)0;
												object obj38 = !flag15;
												if (obj38 != null)
												{
													break;
												}
												object obj39 = num14 + num12;
												num10 = num12 + 1;
												num9 = (int)(num11 + 4294967296L);
												bool flag16 = num10 < num8;
												num11 = num9;
												num12 = num10;
												obj32 = 0;
												num13 = 16;
												if (flag16)
												{
													continue;
												}
												goto IL_077f;
											}
											break;
										}
										goto IL_077f;
									}
								}
								goto IL_07e1;
								IL_077f:
								if (array3.Length == 0)
								{
									break;
								}
								int key = int.Parse(array3[0]);
								((Dictionary<char, Glyph>)obj2).set_Item((char)key, (Glyph)(&num17));
								num3 = num4;
								num2 = num4;
								goto IL_07e1;
								IL_07e1:
								obj9 = array.Length;
								obj10++;
								if ((nint)obj10 < array.Length)
								{
									continue;
								}
								goto IL_0817;
							}
						}
					}
				}
			}
		}
		goto IL_083a;
		IL_083a:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0817:
		bool flag17 = ((Dictionary<char, Glyph>)obj2).TryGetValue(' ', out *(Glyph*)(this + 40));
	}

	private unsafe Glyph Find(char c)
	{
		//IL_0082: Expected VT, but got Obj
		//IL_001d: Expected VT, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_00ae: Expected I4, but got Obj
		//IL_00a9: Expected native int or pointer, but got VT
		//IL_00be: Expected native int or pointer, but got VT
		//IL_006f: Expected Obj, but got Ref
		if (glyphs != null)
		{
			Glyph glyph = (Glyph)glyphs.TryGetValue(c, out var value);
			object obj = this + 40;
			object obj2 = glyph & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				obj = (object)(&value);
			}
			Glyph glyph2 = default;
			((Glyph*)(nint)glyph2)->advance = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v5+10]");
			((Glyph*)(nint)glyph2)->h = 0;
			return glyph;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Glyph)ex;
	}

	public int Measure(string text, int scale = default(int))
	{
		//IL_0077: Expected I4, but got Obj
		//IL_0064: Expected Obj, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected I4, but got Unknown
		//IL_0048: Expected Obj, but got I4
		if (text != null)
		{
			object obj;
			if (text._stringLength >= 1)
			{
				obj = 0;
				int num = 0;
				object obj2 = default;
				do
				{
					char c = text.get_Chars(num);
					Glyph glyph = Find(c);
					num++;
					obj = obj2 + obj;
				}
				while (num < text._stringLength);
			}
			else
			{
				obj = 0;
			}
			return obj * scale;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public int Draw(Color32[] px, int w, int h, int x, int y, string text, [In] ref ShiftAuth.Style s)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected I4, but got Unknown
		//IL_008b: Expected Obj, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00bc: Expected I4, but got VT
		//IL_0143: Expected VT, but got I4
		//IL_010a: Expected VT, but got I
		object obj = s - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = s ^ 1;
		int num2 = s ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int scale = ((obj4 != null) ? 1 : ((int)s));
		int num4 = Measure(text, scale);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X7 (Style&)+1F]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X7 (Style&)+1C]");
			Pass(px, w, h, x, y, text, ref s, scale, num4, 1, (Color32)0);
		}
		Pass(px, w, h, x, y, text, ref s, scale, num4, 0, (Color32)0);
		return num4;
	}

	public int DrawCentred(Color32[] px, int w, int h, int cx, int y, string text, [In] ref ShiftAuth.Style s)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected I4, but got Unknown
		//IL_008b: Expected Obj, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_00bc: Expected I4, but got VT
		object obj = s - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = s ^ 1;
		int num2 = s ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int scale = ((obj4 != null) ? 1 : ((int)s));
		int num4 = Measure(text, scale);
		bool flag5 = num4 < 0;
		int num5 = num4 ^ num4;
		int num6 = num4 & num5;
		bool flag6 = num6 < 0;
		bool flag7 = flag5 == flag6;
		object obj5 = !flag7;
		object obj6 = ~obj5;
		int num7 = ((obj6 != null) ? num4 : (num4 + 1));
		int x = cx - num7;
		return Draw(px, w, h, x, y, text, ref s);
	}

	private void Pass(Color32[] px, int w, int h, int x, int y, string text, [In] ref ShiftAuth.Style s, int scale, int width, int offset, Color32 solid)
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I4
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected Obj, but got Unknown
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected Obj, but got Unknown
		//IL_08f1: Expected Obj, but got I4
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected Obj, but got Unknown
		//IL_0122: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected I4, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_01f7: Expected Obj, but got I4
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected Obj, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_02c1: Expected Obj, but got I4
		//IL_0a72: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got I
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected Obj, but got Unknown
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected Obj, but got Unknown
		//IL_038a: Expected Obj, but got I4
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Expected Obj, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected Obj, but got Unknown
		//IL_03e6: Expected Obj, but got I
		//IL_0939: Expected Obj, but got I
		//IL_0941: Expected VT, but got Obj
		//IL_0af3: Expected Obj, but got I4
		//IL_0981: Expected Obj, but got I
		//IL_0996: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I
		//IL_0b30: Invalid comparison between F8 and I4
		//IL_0430: Expected VT, but got I4
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Expected Obj, but got Unknown
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected Obj, but got Unknown
		//IL_04fc: Invalid comparison between F8 and I4
		//IL_052d: Expected Obj, but got I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected Obj, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected I4, but got Unknown
		//IL_0625: Invalid comparison between F8 and I4
		//IL_0636: Expected Obj, but got I4
		//IL_0668: Expected Obj, but got I
		//IL_05b1: Expected Obj, but got I
		object obj = ascent * scale;
		object obj2 = y + obj;
		object obj3 = cap * scale;
		object obj4 = obj2 - obj3;
		object obj5 = obj2 - 1;
		object obj6 = width - 1;
		object obj7 = obj5 - obj4;
		object obj8 = obj7 - 1;
		bool flag = (nint)obj8 < 0;
		bool flag2 = obj8 == null;
		object obj9 = obj7 ^ 1;
		object obj10 = obj7 ^ obj8;
		object obj11 = obj9 & obj10;
		bool flag3 = (nint)obj11 < 0;
		bool flag4 = flag == flag3;
		object obj12 = !flag2;
		object obj13 = flag4 & obj12;
		object obj14 = ~obj13;
		if (obj14 != null)
		{
			obj7 = 1;
		}
		object obj15 = obj6 - 1;
		bool flag5 = (nint)obj15 < 0;
		bool flag6 = obj15 == null;
		object obj16 = obj6 ^ 1;
		object obj17 = obj6 ^ obj15;
		object obj18 = obj16 & obj17;
		bool flag7 = (nint)obj18 < 0;
		bool flag8 = flag5 == flag7;
		object obj19 = !flag6;
		object obj20 = flag8 & obj19;
		object obj21 = ~obj20;
		if (obj21 != null)
		{
			obj6 = 1;
		}
		string text2 = default;
		bool flag9 = text2 == null;
		if (text2._stringLength < 1)
		{
			return;
		}
		object obj22 = -x;
		int num = 0;
		int num2 = x;
		object obj23 = default;
		object obj25 = default;
		object obj30 = default;
		object obj31 = default;
		double num3 = default;
		object obj32 = default;
		float num4 = default;
		Color32 color = default;
		object obj33 = default;
		object obj34 = default;
		object obj37 = default;
		object obj39 = default;
		object obj43 = default;
		object obj85 = default;
		bool flag23;
		do
		{
			char c = text2.get_Chars(num);
			Glyph glyph = Find(c);
			if ((nint)obj23 >= 1)
			{
				object obj24 = scale * obj25;
				object obj26 = offset + num2;
				object obj27 = obj22 + num2;
				object obj28 = obj26 + obj24;
				object obj29 = obj27 + obj24;
				obj30 = obj30;
				obj31 = obj31;
				num3 = num3;
				obj32 = obj32;
				num4 = num4;
				color = color;
				obj33 = obj33;
				obj34 = obj34;
				object obj35 = 0;
				object obj36 = obj37;
				object obj38 = obj39;
				object obj40 = obj22;
				int num5 = h;
				object obj41 = obj19;
				bool flag22;
				do
				{
					if ((nint)obj38 >= 1)
					{
						object obj42 = obj43 + obj35;
						object obj44 = obj42 * scale;
						object obj45 = y + obj44;
						object obj46 = obj36 + obj35;
						object obj47 = obj30;
						object obj48 = obj31;
						double num6 = num3;
						object obj49 = obj32;
						float num7 = num4;
						Color32 color2 = color;
						object obj50 = obj33;
						object obj51 = obj34;
						object obj52 = obj28;
						object obj53 = obj29;
						object obj54 = obj36;
						object obj55 = obj38;
						object obj56 = 0;
						int num8 = num5;
						Glyph glyph2 = glyph;
						object obj57 = obj41;
						object obj58 = obj35;
						bool flag21;
						do
						{
							object obj59 = obj35;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X14_v8+18]");
							bool flag10 = (nint)obj59 < 0;
							object obj60 = !flag10;
							if (obj60 == null)
							{
								object obj61 = ~obj56;
								object obj62 = obj55 + obj61;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v25+20]");
								object obj63 = (nint)0 >> (int)obj62;
								object obj64 = obj63 & 1;
								flag9 = obj64 == null;
								if (flag9 || scale < 1)
								{
									goto IL_06f2;
								}
								double num9 = num6;
								object obj65 = obj49;
								float num10 = num7;
								Color32 color3 = color2;
								object obj66 = obj50;
								object obj67 = 0;
								int num11 = num8;
								Glyph glyph3 = glyph2;
								object obj68 = obj57;
								object obj69 = obj58;
								bool flag11 = flag9;
								while (true)
								{
									obj47 = obj45 + obj67;
									obj48 = obj47 + offset;
									if ((nint)obj48 >= 0 && (nint)obj48 < num11)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X7 (Style&)+4]");
										obj66 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
										object obj70 = 0;
										glyph3 = (Glyph)obj70;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X0_v17 (ScreenFont+Glyph)+E4]");
										bool flag12 = (nint)0 == 0;
										flag11 = !flag12;
										if (!flag11)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											num11 = h;
										}
										bool flag13 = offset == 0;
										obj68 = !flag13;
										bool flag14 = offset > 0;
										color3 = solid;
										if (!flag14)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X7 (Style&)+18]");
											flag11 = (nint)0 == 0;
											if (!flag11)
											{
												color3 = (Color32)0;
											}
											else
											{
												object obj71 = obj47 - obj4;
												num10 = (float)obj71 / (float)obj7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X7 (Style&)+10]");
												Color32 color4 = Gradient((Color32[])0, num10);
												color3 = color4;
												num11 = h;
												glyph3 = (Glyph)color4;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X7 (Style&)+8]");
										object obj72 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X7 (Style&)+8]");
										obj62 = (nint)0 + (nint)scale;
										if ((nint)obj62 >= 1)
										{
											object obj73 = obj5 - obj47;
											object obj74 = obj66 * obj73;
											double num12 = (double)obj74 + 0.5;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
											num9 = (double)obj52 + num12;
											object obj75 = 0;
											int num13 = num11;
											Glyph glyph4 = glyph3;
											bool flag15 = flag11;
											while (true)
											{
												double num14 = num9 + (double)obj75;
												if (!(num14 < 0.0) && num14 < (double)w)
												{
													bool flag16 = offset == 0;
													object obj76 = !flag16;
													glyph4 = (Glyph)color3;
													object obj77 = obj48;
													if (obj76 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X7 (Style&)+18]");
														bool flag17 = (nint)0 == 0;
														glyph4 = (Glyph)color3;
														obj77 = obj47;
														if (!flag17)
														{
															object obj78 = obj53 + obj75;
															float num15 = (float)obj78 / (float)obj6;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X7 (Style&)+10]");
															Color32 color5 = Gradient((Color32[])0, num15);
															num12 = num15;
															num13 = h;
															glyph4 = (Glyph)color5;
															obj77 = obj47;
														}
													}
													object obj79 = ~obj77;
													double num16 = num9 + (double)obj75;
													object obj80 = obj79 + num13;
													flag15 = (byte)(obj80 * w) != 0;
													double num17 = num16 + (double)(flag15 ? 1 : 0);
													bool flag18 = num17 < (double)px.Length;
													object obj81 = !flag18;
													if (obj81 != null)
													{
														break;
													}
													double num18 = (double)px + num17;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X7 (Style&)+8]");
													obj72 = 0;
												}
												obj65 = obj75 + 1;
												obj62 = obj72 + scale;
												bool flag19 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj65) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj62);
												num10 = (float)num12;
												num11 = num13;
												glyph3 = glyph4;
												obj69 = obj52;
												flag11 = flag15;
												obj75 = obj65;
												if (flag19)
												{
													continue;
												}
												goto IL_066d;
											}
											break;
										}
									}
									goto IL_066d;
									IL_066d:
									obj51 = obj67 + 1;
									bool flag20 = (nint)obj51 != scale;
									num6 = num9;
									obj49 = obj65;
									num7 = num10;
									color2 = color3;
									obj50 = obj66;
									num8 = num11;
									glyph2 = glyph3;
									obj57 = obj68;
									obj58 = obj69;
									flag9 = flag11;
									obj67 = obj51;
									if (flag20)
									{
										continue;
									}
									goto IL_06f2;
								}
							}
							IndexOutOfRangeException ex = new IndexOutOfRangeException();
							throw new NullReferenceException();
							IL_06f2:
							object obj82 = obj52 + scale;
							obj40 = obj56 + 1;
							object obj83 = obj53 + scale;
							flag21 = obj40 != obj39;
							obj30 = obj47;
							obj31 = obj48;
							num3 = num6;
							obj32 = obj49;
							num4 = num7;
							color = color2;
							obj33 = obj50;
							obj34 = obj51;
							obj36 = obj37;
							obj38 = obj39;
							num5 = num8;
							glyph = glyph2;
							obj41 = obj57;
							obj27 = obj58;
							obj52 = obj82;
							obj53 = obj83;
							obj54 = obj37;
							obj55 = obj39;
							obj56 = obj40;
						}
						while (flag21);
					}
					object obj84 = obj35 + 1;
					flag22 = obj84 != obj23;
					obj19 = obj41;
					obj35 = obj84;
				}
				while (flag22);
			}
			flag9 = (byte)(obj85 * scale) != 0;
			int num19 = num2 + (flag9 ? 1 : 0);
			num++;
			flag23 = num < text2._stringLength;
			num2 = num19;
		}
		while (flag23);
	}

	public static Color32 Gradient(Color32[] stops, float t)
	{
		//IL_00b6: Expected Obj, but got I4
		//IL_00bf: Expected F8, but got I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		//IL_03fd: Expected Obj, but got I8
		//IL_0424: Expected VT, but got Obj
		//IL_004c: Expected Obj, but got I4
		//IL_00f3: Invalid comparison between F4 and I4
		//IL_0102: Invalid comparison between F4 and I4
		//IL_011a: Expected Obj, but got F8
		//IL_0127: Expected Obj, but got F4
		//IL_015c: Expected Obj, but got I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_008e: Expected Obj, but got I
		//IL_00a8: Expected F8, but got I
		//IL_0432: Invalid comparison between F4 and I4
		//IL_0470: Invalid comparison between F8 and I4
		//IL_0483: Expected Obj, but got F8
		//IL_0490: Expected Obj, but got F8
		//IL_04c5: Expected Obj, but got I4
		//IL_01a8: Expected F8, but got I4
		//IL_04e6: Invalid comparison between F8 and I4
		//IL_04f7: Expected Obj, but got I4
		//IL_03cb: Expected VT, but got Obj
		//IL_01ee: Invalid comparison between F8 and I4
		//IL_01ff: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I
		//IL_02a1: Invalid comparison between F8 and I4
		//IL_02b0: Invalid comparison between F8 and I4
		//IL_02c8: Expected Obj, but got F8
		//IL_02d5: Expected Obj, but got F8
		//IL_0307: Expected Obj, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0353: Expected Obj, but got I
		//IL_036c: Expected Obj, but got I4
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_050e: Invalid comparison between F8 and I4
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_03b8: Expected F8, but got I4
		object obj27;
		double num18;
		if (stops != null && stops.Length != 0)
		{
			object obj = stops.Length - 1;
			if (stops.Length != 1)
			{
				double num = (double)stops.Length - 2.0;
				float num2 = t - 1f;
				bool flag = num2 < 0f;
				bool flag2 = num2 == 0f;
				object obj2 = (double)t ^ 1.0;
				object obj3 = t ^ num2;
				object obj4 = obj2 & obj3;
				bool flag3 = (nint)obj4 < 0;
				bool flag4 = flag == flag3;
				object obj5 = !flag4;
				object obj6 = obj5 | flag2;
				object obj7 = ~obj6;
				double num3 = ((obj7 != null) ? 1.0 : ((double)t));
				double num4 = ((!(t < 0f)) ? num3 : 0.0);
				double num5 = num4 * (double)obj;
				double num6 = num5 - num;
				bool flag5 = num6 < 0.0;
				object obj8 = num5 ^ num;
				object obj9 = num5 ^ num6;
				object obj10 = obj8 & obj9;
				bool flag6 = (nint)obj10 < 0;
				bool flag7 = flag5 == flag6;
				object obj11 = !flag7;
				object obj12 = ~obj11;
				double num7 = ((obj12 != null) ? num : num5);
				bool flag8 = num7 < (double)stops.Length;
				object obj13 = !flag8;
				if (obj13 == null)
				{
					double num8 = num7 + 1.0;
					bool flag9 = num8 < (double)stops.Length;
					object obj14 = !flag9;
					if (obj14 == null)
					{
						double num9 = (double)stops + num7;
						double num10 = (double)stops + num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						double num11 = num5 - num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v7 (System.Double)+20]");
						object obj15 = (nint)0 >> 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X10_v7 (System.Double)+20]");
						object obj16 = (nint)0 >> 24;
						double num12 = num11 - 1.0;
						bool flag10 = num12 < 0.0;
						bool flag11 = num12 == 0.0;
						object obj17 = num11 ^ 1.0;
						object obj18 = num11 ^ num12;
						object obj19 = obj17 & obj18;
						bool flag12 = (nint)obj19 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X10_v7 (System.Double)+20]");
						object obj20 = (nint)0 & (nint)0xFF;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v7 (System.Double)+20]");
						object obj21 = obj20 - 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						object obj22 = obj16 - obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v7 (System.Double)+20]");
						object obj23 = (nint)0 & (nint)0xFF;
						bool flag13 = flag10 == flag12;
						object obj24 = !flag13;
						object obj25 = obj24 | flag11;
						object obj26 = ~obj25;
						double num13 = ((obj26 != null) ? 1.0 : num11);
						if (num11 < 0.0)
						{
							num13 = 0.0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						double num14 = num13 * (double)obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						double num15 = num13 * (double)obj21;
						double num16 = num14 + (double)obj15;
						double num17 = num15 + (double)obj23;
						obj27 = num16 & 0xFF;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						num18 = num17;
						goto IL_03cb;
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				return (Color32)ex;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [stops @ X0 (UnityEngine.Color32[])+20]");
			obj27 = (nint)0 >> 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [stops @ X0 (UnityEngine.Color32[])+20]");
			num18 = 0.0;
		}
		else
		{
			obj27 = 255;
			num18 = 255.0;
		}
		goto IL_03cb;
		IL_03cb:
		object obj28 = num18 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B598]");
		object obj29 = 0 & 0xFF0000FF0000L;
		object obj30 = obj29 | obj27;
		object obj31 = obj30 | obj28;
		object obj32 = default;
		return (Color32)(obj31 | obj32);
	}
}
