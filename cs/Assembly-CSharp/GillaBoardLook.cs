using System;
using Cpp2ILInjected;
using UnityEngine;

public static class GillaBoardLook
{
	public static readonly Color32[] White;

	public static readonly Color32[] Soft;

	public static readonly Color32[] Dim;

	public static readonly Color32 Band;

	public static readonly Color32 OtherBand;

	public static readonly Color32 PickedBand;

	public static readonly Color32 Dots;

	public static readonly Color32 Edge;

	public static readonly Color32 Solid;

	public static readonly Color32[] Gold;

	public static readonly Color32[] Red;

	private static readonly Color32 CoinLight;

	private static readonly Color32 CoinBody;

	private static readonly Color32 CoinDark;

	private static readonly Color32 CoinMark;

	public static readonly Color32 GoldTag;

	public static readonly Color32 GoldTagPicked;

	private static Color32[] back;

	private static int backW;

	private static Color32 G(byte v)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected VT, but got Unknown
		int num = v & 0xFF;
		object obj = num * 65793;
		return (Color32)(obj | 0xFF000000L);
	}

	private static Color32 C(byte r, byte g, byte b)
	{
		//IL_0045: Expected VT, but got I8
		int num = g & 0xFF;
		int num2 = num << 8;
		int num3 = num2 | b;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		return (Color32)(num3 | 0xFF000000L);
	}

	public static void Coin(Color32[] px, int w, int h, int x, int y, int scale = default(int))
	{
		//IL_0010: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I8
		//IL_00b1: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0186: Expected Obj, but got I8
		//IL_01b3: Expected Obj, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02d9: Expected Obj, but got I
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_031b: Expected Obj, but got I4
		//IL_0331: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0374: Expected Obj, but got I
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_03b5: Expected Obj, but got I4
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected Obj, but got Unknown
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected I4, but got Unknown
		//IL_0721: Expected Obj, but got I4
		//IL_03cf: Expected Obj, but got I
		//IL_058f: Expected Obj, but got I4
		//IL_06fb: Expected Obj, but got I
		//IL_077c: Expected Obj, but got I
		//IL_07a6: Expected Obj, but got I4
		//IL_0540: Expected Obj, but got I4
		//IL_05e8: Expected VT, but got Obj
		//IL_06e0: Expected Obj, but got I
		//IL_04f1: Expected Obj, but got I4
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_06c5: Expected Obj, but got I
		//IL_0465: Expected Obj, but got I4
		//IL_06aa: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC10]");
			object obj2 = 0;
			object obj4 = default;
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X26_v4-8]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC28]");
				object obj6 = 0;
				object obj7 = obj4 + 40;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X26_v6-10]");
				bool flag = (nint)0 < (nint)2;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X26_v6-10]");
				object obj9 = -2;
				bool flag2 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC20]");
					object obj12 = 0;
					object obj13 = obj4 + 48;
					obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X26_v8-18]");
					object obj14 = 0 & 0xFFFFFFFCL;
					if (obj14 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC18]");
						object obj15 = 0;
						object obj16 = obj4 + 56;
						obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X26_v10-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj17 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X26_v10-20]");
						object obj18 = -4;
						bool flag4 = obj18 == null;
						object obj19 = ~obj17;
						object obj20 = obj19 | flag4;
						if (obj20 == null)
						{
							object obj21 = obj4 + 64;
							obj21 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X26_v12-28]");
							bool flag5 = (nint)0 < (nint)5;
							object obj22 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X26_v12-28]");
							object obj23 = -5;
							bool flag6 = obj23 == null;
							object obj24 = ~obj22;
							object obj25 = obj24 | flag6;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC30]");
								object obj26 = 0;
								object obj27 = obj4 + 72;
								obj27 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X26_v14-30]");
								bool flag7 = (nint)0 < (nint)6;
								object obj28 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X26_v14-30]");
								object obj29 = -6;
								bool flag8 = obj29 == null;
								object obj30 = ~obj28;
								object obj31 = obj30 | flag8;
								if (obj31 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
									object obj32 = 0;
									object obj33 = obj4 + 80;
									obj33 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int num = scale;
									int num2 = y;
									int num3 = x;
									object obj34 = 0;
									while (true)
									{
										object obj35 = obj34 * scale;
										int num4 = y + obj35;
										object obj36 = obj4 + obj34;
										int num5 = x;
										int num6 = 0;
										while (true)
										{
											object obj37 = obj34;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
											bool flag9 = (nint)obj37 < 0;
											object obj38 = !flag9;
											if (obj38 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X22_v4+20]");
											char c = ((string)0).get_Chars(num6);
											object obj41;
											switch (c & 0xFFFF)
											{
											case 76:
											{
												object obj44 = obj32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v46+E4]");
												bool flag12 = (nint)0 == 0;
												object obj45 = !flag12;
												if (obj45 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj44 = obj32;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v46+A0]");
												obj41 = (nint)0 + (nint)64;
												break;
											}
											case 109:
											{
												object obj42 = obj32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v42+E4]");
												bool flag11 = (nint)0 == 0;
												object obj43 = !flag11;
												if (obj43 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj42 = obj32;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v42+A0]");
												obj41 = (nint)0 + (nint)76;
												break;
											}
											default:
											{
												object obj46 = obj32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v34+E4]");
												bool flag13 = (nint)0 == 0;
												object obj47 = !flag13;
												if (obj47 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj46 = obj32;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v34+A0]");
												obj41 = (nint)0 + (nint)68;
												break;
											}
											case 100:
											{
												object obj39 = obj32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v38+E4]");
												bool flag10 = (nint)0 == 0;
												object obj40 = !flag10;
												if (obj40 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj39 = obj32;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v38+A0]");
												obj41 = (nint)0 + (nint)72;
												break;
											}
											case 46:
												goto IL_0606;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
											object obj48 = 0;
											object obj49 = obj48;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v28+E4]");
											bool flag14 = (nint)0 == 0;
											object obj50 = !flag14;
											if (obj50 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											PixelFont.Fill(px, w, h, num5, num4, scale, scale, (Color32)obj41);
											num = scale;
											num2 = num4;
											num3 = num5;
											goto IL_0606;
											IL_0606:
											num6++;
											num5 += scale;
											if (num6 != 7)
											{
												continue;
											}
											goto IL_0641;
										}
										break;
										IL_0641:
										obj34++;
										if ((nint)obj34 == 7)
										{
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static void Clear(Color32[] px, int w, int h)
	{
		//IL_0010: Expected Obj, but got I
		//IL_062e: Expected Obj, but got I4
		//IL_0874: Expected Obj, but got I
		//IL_0884: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I
		//IL_06a9: Expected Obj, but got I
		//IL_06b1: Expected Obj, but got I4
		//IL_06d3: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_0685: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I4
		//IL_0252: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_05d3: Expected Obj, but got I
		//IL_05ee: Expected Obj, but got I
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected Obj, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected I4, but got Unknown
		//IL_028c: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_0839: Expected Obj, but got I4
		//IL_0715: Expected Obj, but got I
		//IL_0725: Expected Obj, but got I
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected Obj, but got Unknown
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected I4, but got Unknown
		//IL_074c: Expected Obj, but got I4
		//IL_0776: Invalid comparison between F8 and I4
		//IL_0785: Expected F8, but got I4
		//IL_08d3: Expected Obj, but got I4
		//IL_0345: Invalid comparison between F8 and I4
		//IL_0448: Expected I4, but got F8
		//IL_0415: Expected I4, but got F8
		//IL_041d: Expected I4, but got F8
		//IL_07cf: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got I4
		//IL_03e5: Expected I4, but got F8
		//IL_07e5: Expected I4, but got F8
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected I4, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_04da: Expected Obj, but got I4
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v21+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v21+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v38+58]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v38+58]");
		Color32[] array;
		int num;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v21+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v21+A0]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v38+58]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v38+58]");
				if ((nint)0 == 0)
				{
					goto IL_05ef;
				}
			}
			if (px != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v14+18]");
				if ((nint)0 == px.Length)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v21+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v21+A0]");
						obj4 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v38+60]");
					if ((nint)0 == w)
					{
						num = w;
						array = px;
						goto IL_0663;
					}
				}
				goto IL_0182;
			}
		}
		else if (px != null)
		{
			goto IL_0182;
		}
		goto IL_05ef;
		IL_0663:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v21+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (array != null)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v7+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v8+58]");
			Array.Copy((Array)0, array, array.Length);
			return;
		}
		goto IL_05ef;
		IL_05fd:
		throw new IndexOutOfRangeException();
		IL_05ef:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05fd;
		IL_0572:
		obj2 = obj;
		int num2 = default;
		num = num2;
		array = px;
		goto IL_0663;
		IL_0182:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v15+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v15+A0]");
		object obj13 = (nint)0 + (nint)88;
		obj13 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v21+A0]");
		object obj14 = 0;
		bool flag5 = h < 1;
		num = num2;
		array = px;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			int num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			int num4 = (int)((nint)h * (nint)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj15 = 0;
			int num5 = h;
			int num6 = num4;
			object obj16 = 0;
			Color32[] array2 = px;
			int num7 = w;
			object obj17 = 0;
			object obj21 = default;
			int num16 = default;
			while (true)
			{
				if (num7 >= 1)
				{
					object obj18 = obj17 << 32;
					object obj19 = obj16 - num4;
					int num8 = obj19 / h;
					object obj20 = num8 * num8;
					obj21 = obj21;
					int num9 = h;
					Color32[] array3 = null;
					while (true)
					{
						object obj22 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v25+E4]");
						bool flag6 = (nint)0 == 0;
						object obj23 = !flag6;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj22 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v25+A0]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v24+58]");
						object obj25 = 0;
						object obj26 = array3 - w;
						int num10 = obj26 / w;
						object obj27 = num10 * num10;
						object obj28 = obj20 + obj27;
						double num11 = (double)obj28 * 0.75;
						bool flag7 = num11 < 0.0;
						double num12 = 0.0;
						if (!flag7)
						{
							bool flag8 = num11 > 1.0;
							num12 = 1.0;
							if (!flag8)
							{
								num12 = num11;
							}
						}
						object obj29 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X0_v27+E4]");
						bool flag9 = (nint)0 == 0;
						object obj30 = !flag9;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						double num13 = num12 * -15.0;
						double num14 = num13 + 24.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
						double num15;
						if (num14 < 0.0)
						{
							if (num14 == -0.5)
							{
								num15 = -1.0;
								num6 = num16;
								goto IL_0798;
							}
							double num17 = num14 + -0.5;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
							num9 = 0;
							num6 = (int)num17;
						}
						else
						{
							if (num14 == 0.5)
							{
								num15 = 1.0;
								num6 = num16;
								goto IL_0798;
							}
							double num18 = num14 + 0.5;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
							num6 = (int)num18;
						}
						goto IL_07ea;
						IL_0798:
						double num19 = (double)num6 + num15;
						int num20 = num6 & 1;
						bool flag10 = num20 == 0;
						obj21 = !flag10;
						if (obj21 != null)
						{
							num6 = (int)num19;
						}
						num9 = (int)num19;
						goto IL_07ea;
						IL_07ea:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v24+58]");
						if ((nint)0 == 0)
						{
							break;
						}
						object obj31 = obj17 + (object)array3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X27_v6+18]");
						bool flag11 = (nint)obj31 < 0;
						object obj32 = !flag11;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v24+58]");
							int num21 = 0 + obj18;
							array2 = (Color32[])(array3 + 1);
							obj18 += 4294967296L;
							int num22 = num6 & 0xFF;
							object obj33 = num22 * 65793;
							object obj34 = obj33 | 0xFF000000L;
							bool flag12 = w != (nint)array2;
							num3 = num9;
							num5 = num4;
							num8 = num6;
							array3 = array2;
							if (flag12)
							{
								continue;
							}
							goto IL_0530;
						}
						goto IL_05fd;
					}
					break;
				}
				goto IL_0530;
				IL_0530:
				obj16++;
				obj17 += w;
				bool flag13 = (nint)obj16 != h;
				num7 = w;
				if (flag13)
				{
					continue;
				}
				goto IL_0572;
			}
			goto IL_05ef;
		}
		goto IL_0663;
	}

	public static void Frame(Color32[] px, int w, int h, int inset = default(int))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I4, but got Unknown
		//IL_00d0: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I4
		//IL_013a: Expected VT, but got I
		//IL_015f: Expected Obj, but got I
		//IL_018e: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = ~inset;
		int num2 = default;
		int x = num + num2;
		int num3 = default;
		Rule(px, num2, num3, inset, x, inset);
		object obj4 = num3 - inset;
		int x2 = num + num2;
		int y = obj4 - 1;
		Rule(px, num2, num3, inset, x2, y);
		if ((nint)obj4 <= inset)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj5 = 0;
		int num4 = inset;
		int num5 = inset;
		bool flag4;
		do
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj;
			}
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v9+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int y2 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X9_v3+24]");
			PixelFont.Fill(px, num2, num3, inset, y2, 1, 2, (Color32)0);
			object obj11 = obj;
			num4 = num + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v8+A0]");
			object obj12 = 0;
			int x3 = num4;
			int y3 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v9+24]");
			PixelFont.Fill(px, num2, num3, x3, y3, 1, 2, (Color32)0);
			int num6 = num5 + 4;
			flag4 = num6 < (nint)obj4;
			y = 1;
			x2 = num5;
			num5 = num6;
		}
		while (flag4);
	}

	public static void Rule(Color32[] px, int w, int h, int x0, int x1, int y)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_0097: Expected VT, but got I
		int num = default;
		if (num > x1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj2 = 0;
		int num2 = y;
		int num3 = x1;
		int num4 = num;
		int w2 = default;
		int h2 = default;
		bool flag3;
		do
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v5+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int x2 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v3+24]");
			PixelFont.Fill(px, w2, h2, x2, y, 2, 1, (Color32)0);
			int num5 = num4 + 4;
			flag3 = num5 <= x1;
			num2 = 2;
			num3 = y;
			num4 = num5;
		}
		while (flag3);
	}

	public static void Box(Color32[] px, int w, int h, int x, int y, int bw, int bh, Color32 colour)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected VT, but got Unknown
		//IL_0085: Expected Obj, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected VT, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected I4, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected VT, but got Unknown
		//IL_013f: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected VT, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int x2 = x - 2;
		int rw = bw + 4;
		Color32 colour2 = (Color32)(colour & 0xFFFFFFFFL);
		PixelFont.Fill(px, w, h, x2, y, rw, 1, colour2);
		object obj4 = y + bh;
		int rw2 = bw + 4;
		Color32 colour3 = (Color32)(colour & 0xFFFFFFFFL);
		int y2 = obj4 - 1;
		PixelFont.Fill(px, w, h, x2, y2, rw2, 1, colour3);
		int y3 = y - 2;
		int rh = bh + 4;
		Color32 colour4 = (Color32)(colour & 0xFFFFFFFFL);
		PixelFont.Fill(px, w, h, x, y3, 1, rh, colour4);
		object obj5 = x + bw;
		int rh2 = bh + 4;
		Color32 colour5 = (Color32)(colour & 0xFFFFFFFFL);
		int x3 = obj5 - 1;
		PixelFont.Fill(px, w, h, x3, y3, 1, rh2, colour5);
	}

	static GillaBoardLook()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I
		//IL_026f: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I
		//IL_03bb: Expected Obj, but got I
		//IL_03e5: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I
		//IL_0433: Expected Obj, but got I
		//IL_044d: Expected Obj, but got I
		//IL_0467: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v3+18]");
			bool flag = (nint)0 == 1;
			_ = 4294967295L;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
				object obj2 = 0;
				_ = 4293454056L;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v8+A0]");
				object obj4 = 0;
				object obj5 = default;
				obj4 = obj5;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v11+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v11+18]");
					bool flag2 = (nint)0 == 1;
					_ = 4292269782L;
					if (!flag2)
					{
						_ = 4290690750L;
						object obj7 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v14+A0]");
						object obj8 = (nint)0 + (nint)8;
						object obj9 = default;
						obj8 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v16+18]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v16+18]");
							bool flag3 = (nint)0 == 1;
							_ = 4287269514L;
							if (!flag3)
							{
								_ = 4285558896L;
								object obj10 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v18+A0]");
								object obj11 = (nint)0 + (nint)16;
								object obj12 = default;
								obj11 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj13 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v19+A0]");
								object obj14 = 0;
								_ = 4278716424L;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v19+A0]");
								object obj15 = 0;
								_ = 4279045389L;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v19+A0]");
								object obj16 = 0;
								_ = 4282269246L;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v19+A0]");
								object obj17 = 0;
								_ = 4289769648L;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v19+A0]");
								object obj18 = 0;
								_ = 4282006074L;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v19+A0]");
								object obj19 = 0;
								_ = 4293980400L;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v21+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v21+18]");
									bool flag4 = (nint)0 == 1;
									_ = 4287424767L;
									if (!flag4)
									{
										_ = 4280854764L;
										object obj20 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v24+A0]");
										object obj21 = (nint)0 + (nint)48;
										object obj22 = default;
										obj21 = obj22;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v26+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v26+18]");
											bool flag5 = (nint)0 == 1;
											_ = 4283457791L;
											if (!flag5)
											{
												_ = 4279245014L;
												object obj23 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v28+A0]");
												object obj24 = (nint)0 + (nint)56;
												object obj25 = default;
												obj24 = obj25;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												object obj26 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v29+A0]");
												object obj27 = 0;
												_ = 4288737023L;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v29+A0]");
												object obj28 = 0;
												_ = 4281514740L;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v29+A0]");
												object obj29 = 0;
												_ = 4279794366L;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v29+A0]");
												object obj30 = 0;
												_ = 4279263904L;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v29+A0]");
												object obj31 = 0;
												_ = 4281382640L;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v29+A0]");
												object obj32 = 0;
												_ = 4284536575L;
												return;
											}
										}
									}
								}
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
