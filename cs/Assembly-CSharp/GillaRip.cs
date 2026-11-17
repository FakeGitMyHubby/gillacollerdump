using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Rendering;

public static class GillaRip
{
	private sealed class _003C_003Ec__DisplayClass10_1
	{
		public int e;

		public RimGrid._003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals1;

		internal void _003C_002Ector_003Eb__1(int sq)
		{
			//IL_00a2: Expected Obj, but got I4
			//IL_00b1: Expected Obj, but got I4
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected Obj, but got Unknown
			//IL_012e: Expected Obj, but got I4
			//IL_013d: Expected Obj, but got I4
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected Obj, but got Unknown
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected Obj, but got Unknown
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Expected Obj, but got Unknown
			//IL_01b7: Expected Obj, but got I
			//IL_01fb: Expected Obj, but got I
			//IL_0216: Expected Obj, but got I4
			RimGrid._003C_003Ec__DisplayClass10_0 obj = CS_0024_003C_003E8__locals1;
			if (CS_0024_003C_003E8__locals1 != null)
			{
				RimGrid rimGrid = obj._003C_003E4__this;
				if (obj._003C_003E4__this != null)
				{
					int[] start = rimGrid.start;
					if (rimGrid.start != null)
					{
						bool flag = start.Length < sq;
						object obj2 = !flag;
						object obj3 = start.Length - sq;
						bool flag2 = obj3 == null;
						object obj4 = ~obj2;
						object obj5 = obj4 | flag2;
						if (obj5 == null)
						{
							int[] fill = obj.fill;
							if (obj.fill == null)
							{
								goto IL_023e;
							}
							bool flag3 = fill.Length < sq;
							object obj6 = !flag3;
							object obj7 = fill.Length - sq;
							bool flag4 = obj7 == null;
							object obj8 = ~obj6;
							object obj9 = obj8 | flag4;
							if (obj9 == null)
							{
								int[] inSquare = rimGrid.inSquare;
								object obj10 = obj.fill + sq;
								object obj11 = rimGrid.start + sq;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X12_v3+20]");
								object obj12 = (nint)0 + (nint)1;
								if (rimGrid.inSquare == null)
								{
									goto IL_023e;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X12_v3+20]");
								nint num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X10_v5+20]");
								object obj13 = num + 0;
								bool flag5 = (nint)obj13 < inSquare.Length;
								object obj14 = !flag5;
								if (obj14 == null)
								{
									object obj15 = (object)rimGrid.inSquare + obj13;
									_ = e;
									return;
								}
							}
						}
						goto IL_024c;
					}
				}
			}
			goto IL_023e;
			IL_023e:
			NullReferenceException ex = new NullReferenceException();
			goto IL_024c;
			IL_024c:
			throw new IndexOutOfRangeException();
		}
	}

	public struct Along
	{
		public Vector3 n;

		public Vector3 y;

		public Vector3 z;

		public float off;

		public unsafe static Along Middle
		{
			get
			{
				//IL_0015: Expected Obj, but got I
				//IL_002d: Expected Obj, but got I
				//IL_0047: Expected VT, but got I
				//IL_0042: Expected native int or pointer, but got VT
				//IL_0069: Expected VT, but got I
				//IL_0064: Expected native int or pointer, but got VT
				//IL_008b: Expected VT, but got I
				//IL_0086: Expected native int or pointer, but got VT
				//IL_00a1: Expected native int or pointer, but got VT
				//IL_00ab: Expected VT, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v2+A0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+3C]");
				Along along = default;
				((Along*)(nint)along)->n = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+18]");
				((Along*)(nint)along)->y = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+48]");
				((Along*)(nint)along)->z = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+50]");
				_ = 0;
				((Along*)(nint)along)->off = 0f;
				IntPtr intPtr = default;
				return (Along)(nint)intPtr;
			}
		}

		public bool IsMiddle
		{
			get
			{
				//IL_0041: Expected Obj, but got I
				//IL_0059: Expected Obj, but got I
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Expected Obj, but got Unknown
				//IL_008d: Expected Obj, but got I
				//IL_0010: Invalid comparison between F4 and I4
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+A0]");
				object obj3 = 0;
				Vector3 vector = n;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v6+3C]");
				object obj4 = vector - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaRip+Along)+8]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v6+44]");
				object obj5 = num - 0;
				object obj6 = obj4 * obj4;
				object obj7 = obj5 * obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				object obj8 = obj7 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
				if ((nint)obj8 < 0)
				{
					return off == 0f;
				}
				return false;
			}
		}

		public unsafe string Key
		{
			get
			{
				//IL_002a: Expected Obj, but got I
				//IL_0015: Expected Obj, but got I
				//IL_0080: Expected Obj, but got I
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Expected Obj, but got Unknown
				//IL_00b0: Expected Obj, but got I
				//IL_00dd: Expected Obj, but got I8
				//IL_0103: Unknown result type (might be due to invalid IL or missing references)
				//IL_0108: Expected Obj, but got Unknown
				//IL_013c: Expected Obj, but got I4
				//IL_0152: Expected Obj, but got I
				//IL_0172: Unknown result type (might be due to invalid IL or missing references)
				//IL_0177: Expected Obj, but got Unknown
				//IL_0195: Expected Obj, but got I
				//IL_019e: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a3: Expected Obj, but got Unknown
				//IL_01cf: Expected Ref, but got F4
				//IL_01f2: Expected Obj, but got I8
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_021d: Expected Obj, but got Unknown
				//IL_0251: Expected Obj, but got I4
				//IL_0267: Expected Obj, but got I
				//IL_0287: Unknown result type (might be due to invalid IL or missing references)
				//IL_028c: Expected Obj, but got Unknown
				//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a8: Expected Obj, but got Unknown
				//IL_02d4: Expected Ref, but got F4
				//IL_02ff: Expected Obj, but got I4
				//IL_0315: Expected Obj, but got I
				//IL_0335: Unknown result type (might be due to invalid IL or missing references)
				//IL_033a: Expected Obj, but got Unknown
				//IL_0351: Unknown result type (might be due to invalid IL or missing references)
				//IL_0356: Expected Obj, but got Unknown
				//IL_038a: Expected Obj, but got I4
				//IL_03a0: Expected Obj, but got I
				//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c5: Expected Obj, but got Unknown
				//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e1: Expected Obj, but got Unknown
				//IL_0410: Expected Obj, but got I
				//IL_041d: Expected Ref, but got F4
				//IL_0440: Expected Obj, but got I8
				//IL_0466: Unknown result type (might be due to invalid IL or missing references)
				//IL_046b: Expected Obj, but got Unknown
				if (IsMiddle)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					return (string)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				string[] array = default;
				if (array != null)
				{
					if (array.Length != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
						object obj2 = 0;
						object obj3 = array + 32;
						obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68A8]");
						object obj4 = 0;
						string text = ((float)this).ToString((string)obj4);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X21_v4-8]");
						object obj5 = 0 & 0xFFFFFFFEL;
						if (obj5 != null)
						{
							object obj6 = array + 40;
							obj6 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X21_v6-10]");
							bool flag = (nint)0 < (nint)2;
							object obj7 = !flag;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X21_v6-10]");
							object obj8 = -2;
							bool flag2 = obj8 == null;
							object obj9 = ~obj7;
							object obj10 = obj9 | flag2;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A0]");
								object obj11 = 0;
								object obj12 = array + 48;
								obj12 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								float num = (float)(ref this) + 4f;
								string text2 = ((float*)num)->ToString((string)obj4);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X21_v8-18]");
								object obj13 = 0 & 0xFFFFFFFCL;
								if (obj13 != null)
								{
									object obj14 = array + 56;
									obj14 = text2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X21_v10-20]");
									bool flag3 = (nint)0 < (nint)4;
									object obj15 = !flag3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X21_v10-20]");
									object obj16 = -4;
									bool flag4 = obj16 == null;
									object obj17 = ~obj15;
									object obj18 = obj17 | flag4;
									if (obj18 == null)
									{
										object obj19 = array + 64;
										obj19 = obj11;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										float num2 = (float)(ref this) + 8f;
										string text3 = ((float*)num2)->ToString((string)obj4);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X21_v12-28]");
										bool flag5 = (nint)0 < (nint)5;
										object obj20 = !flag5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X21_v12-28]");
										object obj21 = -5;
										bool flag6 = obj21 == null;
										object obj22 = ~obj20;
										object obj23 = obj22 | flag6;
										if (obj23 == null)
										{
											object obj24 = array + 72;
											obj24 = text3;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X21_v14-30]");
											bool flag7 = (nint)0 < (nint)6;
											object obj25 = !flag7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X21_v14-30]");
											object obj26 = -6;
											bool flag8 = obj26 == null;
											object obj27 = ~obj25;
											object obj28 = obj27 | flag8;
											if (obj28 == null)
											{
												object obj29 = array + 80;
												obj29 = obj11;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												float num3 = (float)(ref this) + 36f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68A0]");
												object obj30 = 0;
												string text4 = ((float*)num3)->ToString((string)obj30);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X21_v16-38]");
												object obj31 = 0 & 0xFFFFFFF8L;
												if (obj31 != null)
												{
													object obj32 = array + 88;
													obj32 = text4;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													return string.Concat(array);
												}
											}
										}
									}
								}
							}
						}
					}
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
				}
				return (string)(object)new NullReferenceException();
			}
		}

		public unsafe static Along Across(Vector3 normal, float off)
		{
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0077: Invalid comparison between F4 and I
			//IL_0290: Expected Obj, but got I
			//IL_02a0: Expected F4, but got I
			//IL_02b0: Expected Obj, but got I
			//IL_02c0: Expected Obj, but got I
			//IL_04db: Expected Obj, but got I
			//IL_04eb: Expected Obj, but got I
			//IL_0512: Unknown result type (might be due to invalid IL or missing references)
			//IL_0517: Expected Obj, but got Unknown
			//IL_0527: Unknown result type (might be due to invalid IL or missing references)
			//IL_052c: Expected Obj, but got Unknown
			//IL_0583: Expected Obj, but got I
			//IL_0593: Invalid comparison between F4 and I
			//IL_048c: Expected Obj, but got I4
			//IL_013e: Expected Obj, but got I
			//IL_0146: Expected F4, but got Obj
			//IL_0156: Expected Obj, but got I
			//IL_0166: Expected Obj, but got I
			//IL_0354: Expected VT, but got Obj
			//IL_0376: Expected Obj, but got I4
			//IL_02f6: Expected Obj, but got I
			//IL_0306: Expected Obj, but got I
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Expected Obj, but got Unknown
			//IL_0342: Unknown result type (might be due to invalid IL or missing references)
			//IL_0347: Expected Obj, but got Unknown
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected Obj, but got Unknown
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected Obj, but got Unknown
			//IL_01e0: Invalid comparison between F4 and I
			//IL_0241: Expected Obj, but got I
			//IL_0249: Expected F4, but got Obj
			//IL_0259: Expected F4, but got I
			//IL_0269: Expected F4, but got I
			//IL_03af: Expected VT, but got F4
			//IL_03aa: Expected native int or pointer, but got VT
			//IL_03df: Expected VT, but got F4
			//IL_03da: Expected native int or pointer, but got VT
			//IL_040f: Expected native int or pointer, but got VT
			//IL_0453: Expected VT, but got F4
			//IL_044e: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 * obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj4 = 0;
			float num = off * off;
			float num2 = num + (float)obj;
			object obj6 = default;
			object obj5 = obj6 * obj6;
			float num3 = (float)obj5 + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			float num4;
			object obj9;
			object obj10;
			if (!(num3 > 0f))
			{
				object obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v24+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v25+3C]");
				num4 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v25+40]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v25+44]");
				obj10 = 0;
			}
			else
			{
				object obj11 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v27+E4]");
				bool flag = (nint)0 == 0;
				object obj12 = !flag;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				if (num5 > 0)
				{
					float num6 = off;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
					num4 = num6 / 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
					obj9 = obj2 / 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
					obj10 = obj6 / 0;
				}
				else
				{
					object obj13 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v32+A0]");
					object obj14 = 0;
					num4 = (float)obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v33+4]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v33+8]");
					obj10 = 0;
				}
			}
			object obj15 = obj3;
			float num7 = num4 * (float)obj10;
			object obj16 = obj9 * obj10;
			object obj17 = obj10 * obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v5+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v18+4C]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v18+48]");
			float num8 = 0f - num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v18+4C]");
			object obj20 = 0 - obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v18+50]");
			object obj21 = 0 - obj17;
			float num9 = num8 * num8;
			object obj22 = obj20 * obj20;
			float num10 = num9 + (float)obj22;
			object obj23 = obj21 * obj21;
			float num11 = num10 + (float)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			object obj24 = 0;
			float num12 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			if (num12 < 0f)
			{
				num11 = num4 * (float)obj9;
				obj24 = obj9 * obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v18+18]");
				obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v18+1C]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v18+20]");
				obj21 = 0 - obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v18+18]");
				num8 = 0f - num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v18+1C]");
				obj20 = 0 - obj24;
			}
			Along result = (Along)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v7 (GillaRip+Along)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj25 = !flag2;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num13 = num8 * num8;
			object obj26 = obj20 * obj20;
			float num14 = num13 + (float)obj26;
			object obj27 = obj21 * obj21;
			float num15 = num14 + (float)obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num16;
			float num17;
			float num18;
			if (num15 > 0f)
			{
				num16 = num8 / num15;
				num17 = (float)obj20 / num15;
				num18 = (float)obj21 / num15;
			}
			else
			{
				object obj28 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v14+A0]");
				object obj29 = 0;
				num16 = (float)obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v15+4]");
				num17 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v15+8]");
				num18 = 0f;
			}
			float num19 = (float)obj10 * num17;
			float num20 = (float)obj9 * num18;
			Along along = default;
			((Along*)(nint)along)->z = (Vector3)num16;
			float num21 = num4 * num18;
			float num22 = (float)obj10 * num16;
			((Along*)(nint)along)->n = (Vector3)num4;
			float num23 = (float)obj9 * num16;
			float num24 = num4 * num17;
			float num25 = default;
			((Along*)(nint)along)->off = num25;
			float num26 = num19 - num20;
			float num27 = num21 - num22;
			float num28 = num23 - num24;
			((Along*)(nint)along)->y = (Vector3)num26;
			return result;
		}

		public unsafe Vector3 In(Vector3 p)
		{
			//IL_0002: Expected VT, but got Ref
			return (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}

		public unsafe Vector3 Out(Vector3 q)
		{
			//IL_0002: Expected VT, but got Ref
			return (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}

		public unsafe Vector3 WayIn(Vector3 d)
		{
			//IL_0002: Expected VT, but got Ref
			return (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}

		public unsafe Vector3 Way(Vector3 d)
		{
			//IL_0002: Expected VT, but got Ref
			return (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}

	public class Half
	{
		internal Built builtSkin;

		internal Built builtInside;

		private Mesh skin_;

		private Mesh inside_;

		public Vector3 middle;

		public float across;

		public float took;

		public int loops;

		public int covered;

		public int open;

		public readonly float[] laps;

		public int rimEdges;

		public int fleshPoints;

		public Mesh skin
		{
			get
			{
				//IL_0010: Expected Obj, but got I
				//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f9: Expected Obj, but got Unknown
				//IL_011b: Expected Obj, but got I4
				//IL_006c: Expected Obj, but got I
				//IL_0096: Expected Obj, but got I4
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = this + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)obj3 != null)
				{
					return (Mesh)obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Mesh mesh = Make(builtSkin);
				obj3 = mesh;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return mesh;
			}
		}

		public Mesh inside
		{
			get
			{
				//IL_0010: Expected Obj, but got I
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0123: Expected Obj, but got Unknown
				//IL_0145: Expected Obj, but got I4
				//IL_004c: Expected Obj, but got I4
				//IL_0089: Expected Obj, but got I
				//IL_00b3: Expected Obj, but got I4
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = this + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = (UnityEngine.Object)obj3 != null;
				bool flag3 = !flag2;
				object obj5 = !flag3;
				if (obj5 == null && builtInside != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v8+E4]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Mesh mesh = Make(builtInside);
					obj3 = mesh;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					return mesh;
				}
				return (Mesh)obj3;
			}
		}

		public Half()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj2 = this + 80;
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	internal class Built
	{
		public string name;

		public List<Vector3> at;

		public List<Vector3> normals;

		public List<Vector3> third;

		public List<Vector3> fourth;

		public List<Vector2> uv;

		public List<Vector4> second;

		public List<Vector2> secondShort;

		public BoneWeight[] weights;

		public Matrix4x4[] binds;

		public List<int>[] tris;

		public bool workOutNormals;

		public float flipNormals = 1f;

		public List<Vector2> thirdShort;
	}

	private class Source
	{
		public string name;

		public Vector3[] at;

		public Vector3[] faces;

		public Vector2[] uv;

		public BoneWeight[] weights;

		public Matrix4x4[] binds;

		public int[][] tris;
	}

	private class Shape
	{
		[StructLayout((LayoutKind)3)]
		private struct _003C_003Ec__DisplayClass71_0
		{
			public bool[] inside;
		}

		[StructLayout((LayoutKind)3)]
		private struct _003C_003Ec__DisplayClass6_0
		{
			public Func<Vector3, Vector3, bool> splits;

			public Shape _003C_003E4__this;
		}

		[StructLayout((LayoutKind)3)]
		private struct _003C_003Ec__DisplayClass6_1
		{
			public Dictionary<long, int> mids;
		}

		[StructLayout((LayoutKind)3)]
		private struct _003C_003Ec__DisplayClass6_2
		{
			public List<int> now;
		}

		public readonly List<Vector3> at;

		public readonly List<Vector3> faces;

		public readonly List<Vector2> uv;

		public readonly List<BoneWeight> weights;

		public List<int>[] tris;

		public unsafe int Between(int a, int b, float t)
		{
			//IL_09f0: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_0057: Expected Obj, but got I
			//IL_007a: Expected Obj, but got I
			//IL_0098: Expected Obj, but got I
			//IL_00b5: Invalid comparison between F4 and I4
			//IL_00c4: Invalid comparison between F4 and I4
			//IL_00dc: Expected Obj, but got F8
			//IL_00e9: Expected Obj, but got F4
			//IL_0123: Expected Obj, but got I4
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected Obj, but got Unknown
			//IL_0a22: Invalid comparison between F4 and I4
			//IL_016f: Expected F8, but got I4
			//IL_01c6: Expected Obj, but got I4
			//IL_0298: Expected Obj, but got I
			//IL_02a8: Expected Obj, but got I
			//IL_02bf: Expected VT, but got I
			//IL_0244: Expected Obj, but got I
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Expected Obj, but got Unknown
			//IL_026f: Expected Obj, but got I
			//IL_037c: Invalid comparison between F4 and I4
			//IL_038b: Invalid comparison between F4 and I4
			//IL_03a3: Expected Obj, but got F8
			//IL_03b0: Expected Obj, but got F4
			//IL_03e5: Expected Obj, but got I4
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Expected Obj, but got Unknown
			//IL_0a67: Invalid comparison between F4 and I4
			//IL_0431: Expected F8, but got I4
			//IL_0ab1: Expected Obj, but got I
			//IL_0aea: Expected Obj, but got I4
			//IL_046c: Invalid comparison between F8 and I
			//IL_04c5: Expected Obj, but got I
			//IL_04dd: Expected Obj, but got I
			//IL_04e5: Expected F4, but got Obj
			//IL_04f5: Expected F8, but got I
			//IL_0505: Expected F8, but got I
			//IL_0b08: Expected Obj, but got I
			//IL_0b26: Expected Obj, but got I
			//IL_0533: Expected Obj, but got I4
			//IL_05ab: Expected Obj, but got I
			//IL_05bb: Expected Obj, but got I
			//IL_05d2: Expected VT, but got I
			//IL_0557: Expected Obj, but got I
			//IL_0567: Unknown result type (might be due to invalid IL or missing references)
			//IL_056c: Expected Obj, but got Unknown
			//IL_0582: Expected Obj, but got I
			//IL_0643: Expected Obj, but got I
			//IL_065f: Invalid comparison between F4 and I4
			//IL_066e: Expected F8, but got I4
			//IL_0b60: Expected Obj, but got I
			//IL_0b7e: Expected Obj, but got I
			//IL_0701: Expected Obj, but got I4
			//IL_07a2: Expected Obj, but got I
			//IL_07b2: Expected Obj, but got I
			//IL_07c9: Expected VT, but got I
			//IL_0768: Expected Obj, but got I
			//IL_077e: Expected Obj, but got I
			//IL_0807: Expected Obj, but got I
			//IL_0849: Expected Obj, but got I
			//IL_0887: Expected Obj, but got I4
			//IL_08b5: Expected VT, but got Ref
			//IL_08b5: Expected VT, but got Ref
			//IL_08c9: Expected Obj, but got I
			//IL_08e0: Expected Obj, but got I
			//IL_0933: Expected Obj, but got I4
			//IL_0999: Expected VT, but got Ref
			//IL_095e: Expected Obj, but got I
			//IL_0974: Expected Obj, but got I
			List<Vector3> list = at;
			if (at != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
				object obj = 0;
				Vector3 vector = at.get_Item(a);
				if (at != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
					object obj2 = 0;
					Vector3 vector2 = at.get_Item(b);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X22_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj3 = 0;
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X22_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj5 = (nint)0 + (nint)1;
					float num = t - 1f;
					bool flag = num < 0f;
					bool flag2 = num == 0f;
					object obj6 = (double)t ^ 1.0;
					object obj7 = t ^ num;
					object obj8 = obj6 & obj7;
					bool flag3 = (nint)obj8 < 0;
					bool flag4 = flag == flag3;
					object obj9 = !flag4;
					object obj10 = obj9 | flag2;
					object obj11 = ~obj10;
					double num2 = ((obj11 != null) ? 1.0 : ((double)t));
					if (t < 0f)
					{
						num2 = 0.0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X22_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					if ((nint)0 != 0)
					{
						float num3 = t - t;
						object obj13 = default;
						object obj12 = obj13 - obj13;
						object obj15 = default;
						object obj14 = obj15 - obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X22_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v4+18]");
						bool flag5 = num4 < 0;
						object obj16 = !flag5;
						float num5 = num3 * (float)num2;
						double num6 = (double)obj12 * num2;
						double num7 = (double)obj14 * num2;
						float num8 = t + num5;
						double num9 = (double)obj13 + num6;
						double num10 = (double)obj15 + num7;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X22_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj17 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X22_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj18 = 0 + obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X22_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj19 = (nint)0 + (nint)1;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X9_v2+20]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v42+A8]");
							object obj21 = 0;
							List<Vector3> list2 = at;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v43+70]");
							list2.AddWithResize((Vector3)0);
						}
						List<Vector3> list3 = faces;
						if (faces != null)
						{
							Vector3 vector3 = faces.get_Item(a);
							if (faces != null)
							{
								Vector3 vector4 = faces.get_Item(b);
								float num11 = num8 - num8;
								double num12 = num9 - num9;
								double num13 = num10 - num10;
								float num14 = t - 1f;
								bool flag6 = num14 < 0f;
								bool flag7 = num14 == 0f;
								object obj22 = (double)t ^ 1.0;
								object obj23 = t ^ num14;
								object obj24 = obj22 & obj23;
								bool flag8 = (nint)obj24 < 0;
								bool flag9 = flag6 == flag8;
								object obj25 = !flag9;
								object obj26 = obj25 | flag7;
								object obj27 = ~obj26;
								double num15 = ((obj27 != null) ? 1.0 : ((double)t));
								double num16 = ((!(t < 0f)) ? num15 : 0.0);
								float num17 = num11 * (float)num16;
								double num18 = num12 * num16;
								double num19 = num13 * num16;
								float num20 = num8 + num17;
								double num21 = num9 + num18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
								object obj28 = 0;
								double num22 = num10 + num19;
								object obj29 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v15+E4]");
								bool flag10 = (nint)0 == 0;
								object obj30 = !flag10;
								if (obj30 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								float num23;
								double num24;
								if (num10 > 0.0)
								{
									num23 = num20 / (float)num10;
									num24 = num21 / num10;
									double num25 = num22 / num10;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									object obj31 = 0;
									object obj32 = obj31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v38+A0]");
									object obj33 = 0;
									num23 = (float)obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v39+4]");
									num24 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v39+8]");
									double num25 = 0.0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X22_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								object obj34 = 0;
								object obj35 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X22_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
								object obj36 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X22_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X22_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									nint num26 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v15+18]");
									bool flag11 = num26 < 0;
									object obj37 = !flag11;
									if (obj37 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X22_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										object obj38 = (nint)0 * (nint)12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X22_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										object obj39 = 0 + obj38;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X22_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										object obj40 = (nint)0 + (nint)1;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X9_v4+20]");
										object obj41 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v33+A8]");
										object obj42 = 0;
										List<Vector3> list4 = faces;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v34+70]");
										list4.AddWithResize((Vector3)0);
									}
									List<Vector2> list5 = uv;
									if ((object)uv != null)
									{
										Vector2 vector5 = uv.get_Item(a);
										if ((object)uv != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69C0]");
											object obj43 = 0;
											Vector2 vector6 = uv.get_Item(b);
											bool flag12 = t < 0f;
											double num27 = 0.0;
											if (!flag12)
											{
												bool flag13 = !((double)t > 1.0);
												num27 = t;
												if (!flag13)
												{
													num27 = 1.0;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X22_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
											object obj44 = 0;
											object obj45 = obj43;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X22_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
											object obj46 = (nint)0 + (nint)1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X22_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
											if ((nint)0 != 0)
											{
												float num28 = num23 - num23;
												double num29 = num24 - num24;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X22_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
												nint num30 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v17+18]");
												bool flag14 = num30 < 0;
												object obj47 = !flag14;
												float num31 = num28 * (float)num27;
												double num32 = num29 * num27;
												float num33 = num23 + num31;
												double num34 = num24 + num32;
												if (obj47 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X22_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
													nint num35 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X22_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
													object obj48 = num35 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X22_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
													object obj49 = (nint)0 + (nint)1;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X9_v6+20]");
													object obj50 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v30+A8]");
													object obj51 = 0;
													List<Vector2> list6 = uv;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v31+70]");
													list6.AddWithResize((Vector2)0);
												}
												List<BoneWeight> list7 = weights;
												if (weights != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69E0]");
													object obj52 = 0;
													BoneWeight boneWeight = weights.get_Item(a);
													if (weights != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
														object obj53 = 0;
														BoneWeight boneWeight2 = weights.get_Item(b);
														object obj54 = obj53;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v27+E4]");
														bool flag15 = (nint)0 == 0;
														object obj55 = !flag15;
														if (obj55 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														object obj56 = default;
														object obj57 = default;
														BoneWeight boneWeight3 = Mix((BoneWeight)(&obj56), (BoneWeight)(&obj57), t);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X22_v6 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+10]");
														object obj58 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X22_v6 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+1C]");
														object obj59 = (nint)0 + (nint)1;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X22_v6 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+10]");
														if ((nint)0 != 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X22_v6 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+18]");
															nint num36 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v23+18]");
															bool flag16 = num36 < 0;
															object obj60 = !flag16;
															if (obj60 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X22_v6 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+10]");
																nint num37 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X22_v6 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+18]");
																object obj61 = num37 + 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X22_v6 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+18]");
																object obj62 = (nint)0 + (nint)1;
															}
															else
															{
																object obj63 = default;
																weights.AddWithResize((BoneWeight)(&obj63));
															}
															List<Vector3> list8 = at;
															if (at != null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v25 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																return (int)(-1);
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
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		public unsafe void Refine(Func<Vector3, Vector3, bool> splits, int passes)
		{
			//IL_0785: Expected Obj, but got Ref
			//IL_001c: Expected VT, but got I4
			//IL_0025: Expected Obj, but got I4
			//IL_088e: Expected Obj, but got I
			//IL_0069: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I4
			//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c8: Expected Obj, but got Unknown
			//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d5: Expected Obj, but got Unknown
			//IL_06ef: Expected Obj, but got I4
			//IL_0705: Unknown result type (might be due to invalid IL or missing references)
			//IL_070a: Expected Obj, but got Unknown
			//IL_0724: Expected Obj, but got I4
			//IL_072c: Expected VT, but got Obj
			//IL_009a: Expected Obj, but got I4
			//IL_00cd: Expected Obj, but got I
			//IL_010a: Expected Obj, but got I
			//IL_0124: Expected Obj, but got I
			//IL_012c: Expected I4, but got Obj
			//IL_08c6: Expected Obj, but got I
			//IL_08ed: Expected Obj, but got I
			//IL_0914: Expected Obj, but got I
			//IL_0616: Expected Obj, but got I4
			//IL_05b4: Expected I, but got Obj
			//IL_05c4: Expected Obj, but got I
			//IL_05ed: Expected Obj, but got I
			//IL_0213: Expected Obj, but got I4
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Expected Obj, but got Unknown
			//IL_0644: Unknown result type (might be due to invalid IL or missing references)
			//IL_0649: Expected Obj, but got Unknown
			//IL_066e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0673: Expected Obj, but got Unknown
			//IL_068f: Expected Obj, but got I4
			//IL_02d7: Expected I4, but got I8
			//IL_02f1: Expected Obj, but got I4
			//IL_0810: Expected Obj, but got I4
			//IL_0819: Expected Obj, but got I4
			//IL_046c: Expected I4, but got I8
			//IL_0486: Expected Obj, but got I4
			//IL_027d: Expected Obj, but got I4
			//IL_03a4: Expected I4, but got I8
			//IL_03be: Expected Obj, but got I4
			//IL_02b0: Expected Obj, but got VT
			//IL_02c0: Expected Obj, but got I4
			//IL_03de: Expected I4, but got I8
			//IL_03f8: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_003C_003Ec__DisplayClass6_0 obj2 = default;
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (passes < 1)
			{
				return;
			}
			List<int> list = null;
			int num = passes;
			_003C_003Ec__DisplayClass6_1 obj3 = (_003C_003Ec__DisplayClass6_1)0;
			object obj4 = 0;
			Shape shape = this;
			Dictionary<long, int> dictionary = default;
			List<int> list3 = default;
			_003C_003Ec__DisplayClass6_2 obj15 = default;
			_003C_003Ec__DisplayClass6_2 obj18 = default;
			_003C_003Ec__DisplayClass6_2 obj19 = default;
			_003C_003Ec__DisplayClass6_2 obj22 = default;
			_003C_003Ec__DisplayClass6_2 obj23 = default;
			IndexOutOfRangeException ex = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6998]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				dictionary._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				List<int>[] array = tris;
				bool flag = tris == null;
				Dictionary<long, int> dictionary2 = dictionary;
				if (!flag)
				{
					object obj6 = 0;
					shape = (Shape)(object)dictionary;
					object obj7 = 0;
					while ((nint)obj6 < array.Length)
					{
						bool flag2 = (nint)obj6 < array.Length;
						object obj8 = !flag2;
						dictionary2 = (Dictionary<long, int>)(object)shape;
						if (obj8 == null)
						{
							object obj9 = (object)array + obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v18+20]");
							List<int> list2 = (List<int>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v18+20]");
							bool flag3 = (nint)0 == 0;
							dictionary2 = (Dictionary<long, int>)(object)shape;
							if (!flag3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
								object obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
								object obj11 = 0;
								num = (int)obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X21_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
								list3._002Ector(0);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X21_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
								bool flag4 = (nint)0 < (nint)1;
								list = list3;
								dictionary2 = (Dictionary<long, int>)(object)list3;
								if (!flag4)
								{
									int num2 = 0;
									int num20;
									do
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v18+20]");
										int num3 = ((List<int>)0).get_Item(num2);
										int index = num2 + 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v18+20]");
										int num4 = ((List<int>)0).get_Item(index);
										int num5 = num2 + 2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v18+20]");
										int num6 = ((List<int>)0).get_Item(num5);
										int num7 = _003CRefine_003Eg__Mid_007C6_0(num3, num4, ref obj2, ref obj3);
										int num8 = _003CRefine_003Eg__Mid_007C6_0(num4, num6, ref obj2, ref obj3);
										int num9 = _003CRefine_003Eg__Mid_007C6_0(num6, num3, ref obj2, ref obj3);
										int num10 = ~num8;
										int num11 = ~num7;
										int num12 = num10 >> 31;
										object obj12 = num12 + num11;
										int num13 = ~num9;
										object obj13 = obj12 + num13;
										ref _003C_003Ec__DisplayClass6_2 reference;
										int num17;
										int a;
										nint num14;
										if ((nint)obj13 != 3)
										{
											ref _003C_003Ec__DisplayClass6_2 reference2;
											int b;
											if ((nint)obj13 != 1)
											{
												bool flag5 = obj13 == null;
												object obj14 = !flag5;
												if (obj14 == null)
												{
													_003CRefine_003Eg__Add_007C6_1(num3, num4, num6, ref obj15);
													num14 = (nint)(&obj15);
													list = (List<int>)obj15;
													num = num6;
													dictionary2 = (Dictionary<long, int>)num4;
													goto IL_07ac;
												}
												int num15 = (int)(num9 & 0x80000000L);
												bool flag6 = num15 == 0;
												object obj16 = !flag6;
												if (obj16 == null)
												{
													int num16 = (int)(num7 & 0x80000000L);
													bool flag7 = num16 == 0;
													object obj17 = !flag7;
													if (obj17 == null)
													{
														_003CRefine_003Eg__Add_007C6_1(num9, num3, num7, ref obj15);
														_003CRefine_003Eg__Add_007C6_1(num6, num9, num7, ref obj18);
														reference = ref *(_003C_003Ec__DisplayClass6_2*)(&list);
														num = num4;
														num17 = num7;
														a = num6;
													}
													else
													{
														_003CRefine_003Eg__Add_007C6_1(num8, num6, num9, ref obj15);
														_003CRefine_003Eg__Add_007C6_1(num4, num8, num9, ref obj19);
														reference = ref *(_003C_003Ec__DisplayClass6_2*)(&list);
														num = num3;
														num17 = num9;
														a = num4;
													}
													goto IL_07eb;
												}
												_003CRefine_003Eg__Add_007C6_1(num7, num4, num8, ref obj15);
												reference2 = ref *(_003C_003Ec__DisplayClass6_2*)(&list);
												b = num7;
											}
											else
											{
												int num18 = (int)(num7 & 0x80000000L);
												bool flag8 = num18 == 0;
												object obj20 = !flag8;
												if (obj20 == null)
												{
													_003CRefine_003Eg__Add_007C6_1(num3, num7, num6, ref obj15);
													reference = ref *(_003C_003Ec__DisplayClass6_2*)(&list);
													num17 = num4;
													a = num7;
													goto IL_07de;
												}
												int num19 = (int)(num8 & 0x80000000L);
												bool flag9 = num19 == 0;
												object obj21 = !flag9;
												if (obj21 != null)
												{
													_003CRefine_003Eg__Add_007C6_1(num3, num4, num9, ref obj15);
													reference = ref *(_003C_003Ec__DisplayClass6_2*)(&list);
													num17 = num6;
													a = num4;
													goto IL_0850;
												}
												reference2 = ref obj15;
												b = num4;
											}
											_003CRefine_003Eg__Add_007C6_1(num3, b, num8, ref reference2);
											reference = ref *(_003C_003Ec__DisplayClass6_2*)(&list);
											num17 = num8;
											a = num3;
											goto IL_07de;
										}
										_003CRefine_003Eg__Add_007C6_1(num3, num7, num9, ref obj15);
										_003CRefine_003Eg__Add_007C6_1(num7, num4, num8, ref obj22);
										_003CRefine_003Eg__Add_007C6_1(num9, num8, num6, ref obj23);
										reference = ref *(_003C_003Ec__DisplayClass6_2*)(&list);
										num17 = num8;
										a = num7;
										goto IL_0850;
										IL_07eb:
										_003CRefine_003Eg__Add_007C6_1(a, num17, num, ref reference);
										num14 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
										dictionary2 = (Dictionary<long, int>)num17;
										obj7 = 1;
										goto IL_07ac;
										IL_07ac:
										num2 = num5 + 1;
										num20 = num2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X21_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
										continue;
										IL_07de:
										num = num6;
										goto IL_07eb;
										IL_0850:
										num = num9;
										goto IL_07eb;
									}
									while ((nint)num20 < (nint)0);
								}
								List<int>[] array2 = tris;
								if (tris != null)
								{
									bool flag10 = list == null;
									Dictionary<long, int> dictionary3 = dictionary2;
									if (!flag10)
									{
										nint num21 = (nint)array2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v29 (Il2CppClass<System.Collections.Generic.List`1<System.Int32>[]>)+40]");
										dictionary3 = (Dictionary<long, int>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag11 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v29 (Il2CppClass<System.Collections.Generic.List`1<System.Int32>[]>)+40]");
										dictionary2 = (Dictionary<long, int>)0;
										if (flag11)
										{
											goto end_IL_087e;
										}
									}
									bool flag12 = (nint)obj6 < array2.Length;
									object obj24 = !flag12;
									dictionary2 = dictionary3;
									if (obj24 != null)
									{
										goto IL_0749;
									}
									object obj25 = (object)tris + obj6;
									object obj26 = obj25 + 32;
									obj26 = list;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									array = tris;
									object obj27 = obj6 + 1;
									bool flag13 = tris == null;
									object obj28 = !flag13;
									obj6 = obj27;
									shape = (Shape)(object)list;
									if (obj28 != null)
									{
										continue;
									}
									dictionary2 = (Dictionary<long, int>)(object)list;
								}
							}
							goto IL_073b;
						}
						goto IL_0749;
					}
					obj4++;
					object obj29 = obj4 - passes;
					bool flag14 = obj29 == null;
					object obj30 = !flag14;
					object obj31 = obj7 & obj30;
					object obj32 = obj31 & 1;
					bool flag15 = obj32 == null;
					object obj33 = !flag15;
					obj3 = (_003C_003Ec__DisplayClass6_1)dictionary;
					if (obj33 == null)
					{
						return;
					}
					continue;
				}
				goto IL_073b;
				IL_0749:
				ex = new IndexOutOfRangeException();
				break;
				IL_073b:
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_0749;
				continue;
				end_IL_087e:
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			throw new ArgumentNullException();
		}

		public unsafe List<(int, int)> Clip(Func<Vector3, float> into)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_1449: Expected Obj, but got Ref
			//IL_1461: Expected Obj, but got Ref
			//IL_0085: Expected Obj, but got I
			//IL_01b4: Expected Obj, but got I
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Expected Obj, but got I4
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected Obj, but got Unknown
			//IL_00e7: Expected Obj, but got I
			//IL_00fd: Expected I, but got Obj
			//IL_0150: Expected Obj, but got I4
			//IL_01ed: Expected Obj, but got I4
			//IL_0218: Expected Obj, but got I
			//IL_022d: Expected Obj, but got I
			//IL_0247: Expected Obj, but got I
			//IL_024f: Expected I, but got Obj
			//IL_1373: Expected Obj, but got I4
			//IL_1533: Expected I, but got Obj
			//IL_1311: Expected I, but got Obj
			//IL_02f7: Expected Obj, but got I4
			//IL_139f: Unknown result type (might be due to invalid IL or missing references)
			//IL_13a4: Expected Obj, but got Unknown
			//IL_13bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_13c4: Expected Obj, but got Unknown
			//IL_13ea: Expected Obj, but got I4
			//IL_13f2: Expected I4, but got Obj
			//IL_0346: Expected Obj, but got I4
			//IL_0395: Expected Obj, but got I4
			//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d0: Expected Obj, but got Unknown
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dd: Expected Obj, but got Unknown
			//IL_0411: Expected Obj, but got I
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Expected Obj, but got Unknown
			//IL_0445: Expected Obj, but got I
			//IL_044d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Expected Obj, but got Unknown
			//IL_0462: Expected Obj, but got I
			//IL_0608: Expected Obj, but got I4
			//IL_0622: Expected Obj, but got I4
			//IL_062a: Unknown result type (might be due to invalid IL or missing references)
			//IL_062f: Expected Obj, but got Unknown
			//IL_0638: Unknown result type (might be due to invalid IL or missing references)
			//IL_063d: Expected Obj, but got Unknown
			//IL_04f8: Expected Obj, but got I
			//IL_0516: Expected Obj, but got I
			//IL_0549: Expected Obj, but got I4
			//IL_0706: Expected Obj, but got I
			//IL_0716: Expected Obj, but got I
			//IL_0743: Expected Obj, but got I
			//IL_0761: Expected Obj, but got I
			//IL_079c: Expected Obj, but got I4
			//IL_056d: Expected Obj, but got I
			//IL_057d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0582: Expected Obj, but got Unknown
			//IL_05a2: Expected Obj, but got I
			//IL_0a96: Expected Obj, but got I
			//IL_0aa6: Expected Obj, but got I
			//IL_0abc: Expected Obj, but got I
			//IL_080f: Expected Obj, but got I
			//IL_081f: Expected Obj, but got I
			//IL_084c: Expected Obj, but got I
			//IL_086a: Expected Obj, but got I
			//IL_0af0: Expected Obj, but got I4
			//IL_09a7: Expected Obj, but got I
			//IL_09be: Expected Obj, but got I
			//IL_08a7: Expected Obj, but got I4
			//IL_07c0: Expected Obj, but got I
			//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d5: Expected Obj, but got Unknown
			//IL_07f5: Expected Obj, but got I
			//IL_0c4f: Expected Obj, but got I
			//IL_0c66: Expected Obj, but got I
			//IL_09f2: Expected Obj, but got I4
			//IL_0907: Expected Obj, but got I
			//IL_0917: Expected Obj, but got I
			//IL_0c99: Expected Obj, but got I4
			//IL_0b14: Expected Obj, but got I
			//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b29: Expected Obj, but got Unknown
			//IL_0b49: Expected Obj, but got I
			//IL_0b72: Expected Obj, but got I
			//IL_0b89: Expected Obj, but got I
			//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ca: Expected Obj, but got Unknown
			//IL_08e0: Expected Obj, but got I
			//IL_0df7: Expected Obj, but got I
			//IL_0e0e: Expected Obj, but got I
			//IL_0bbd: Expected Obj, but got I4
			//IL_0a16: Expected Obj, but got I
			//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2b: Expected Obj, but got Unknown
			//IL_0a4b: Expected Obj, but got I
			//IL_0e41: Expected Obj, but got I4
			//IL_0cbd: Expected Obj, but got I
			//IL_0ccd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd2: Expected Obj, but got Unknown
			//IL_0cf2: Expected Obj, but got I
			//IL_0d1b: Expected Obj, but got I
			//IL_0d2b: Expected Obj, but got I
			//IL_0d41: Expected Obj, but got I
			//IL_0d75: Expected Obj, but got I4
			//IL_0be1: Expected Obj, but got I
			//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf6: Expected Obj, but got Unknown
			//IL_0c16: Expected Obj, but got I
			//IL_0c2b: Expected Obj, but got I
			//IL_0f79: Expected Obj, but got I
			//IL_0f82: Expected VT, but got I4
			//IL_0fa2: Expected VT, but got Ref
			//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e64: Expected Obj, but got Unknown
			//IL_0e7a: Expected Obj, but got I
			//IL_0ea8: Expected Obj, but got I
			//IL_0ebf: Expected Obj, but got I
			//IL_14f1: Expected native int or pointer, but got VT
			//IL_0ef2: Expected Obj, but got I4
			//IL_0d99: Expected Obj, but got I
			//IL_0da9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dae: Expected Obj, but got Unknown
			//IL_0dce: Expected Obj, but got I
			//IL_1186: Expected Obj, but got I
			//IL_1196: Expected Obj, but got I
			//IL_11ac: Expected Obj, but got I
			//IL_0fc6: Expected Obj, but got I
			//IL_0fdd: Expected Obj, but got I
			//IL_11e9: Expected Obj, but got I4
			//IL_1010: Expected Obj, but got I4
			//IL_0f16: Expected Obj, but got I
			//IL_0f26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f2b: Expected Obj, but got Unknown
			//IL_0f4b: Expected Obj, but got I
			//IL_1251: Expected Obj, but got I
			//IL_1261: Expected Obj, but got I
			//IL_1286: Expected I4, but got VT
			//IL_1092: Expected Obj, but got I
			//IL_10a9: Expected Obj, but got I
			//IL_1207: Unknown result type (might be due to invalid IL or missing references)
			//IL_120c: Expected Obj, but got Unknown
			//IL_1222: Expected Obj, but got I
			//IL_123c: Expected I4, but got VT
			//IL_10dc: Expected Obj, but got I4
			//IL_1034: Expected Obj, but got I
			//IL_1044: Unknown result type (might be due to invalid IL or missing references)
			//IL_1049: Expected Obj, but got Unknown
			//IL_1069: Expected Obj, but got I
			//IL_1148: Expected Obj, but got I
			//IL_1151: Expected VT, but got I4
			//IL_1171: Expected VT, but got Ref
			//IL_10fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_10ff: Expected Obj, but got Unknown
			//IL_1115: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69A0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69A8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6998]");
			object obj3 = 0;
			RimGrid._003C_003Ec__DisplayClass7_0 obj5 = default;
			object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<(int, int)> list = default;
			list._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<long, int> dictionary = default;
			dictionary._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			List<Vector3> list2 = at;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			int num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v17+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_0195;
			}
			object obj9 = default;
			object obj8 = obj9 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
			object obj10 = 0;
			int num2 = 0;
			while (true)
			{
				nint num3 = (nint)obj10;
				Vector3 vector = at.get_Item(num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Func`2<UnityEngine.Vector3, System.Single>)+28]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [into @ X1 (System.Func`2<UnityEngine.Vector3, System.Single>)+18] (should have been resolved before IL gen)");
				int num4 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v17+18]");
				bool flag = (nint)num4 < (nint)0;
				object obj11 = !flag;
				if (obj11 != null)
				{
					break;
				}
				num2++;
				int num5 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v17+18]");
				if ((nint)num5 < (nint)0)
				{
					continue;
				}
				goto IL_0195;
			}
			goto IL_1410;
			IL_0195:
			List<int>[] array = tris;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
			object obj13 = 0;
			object obj14 = 0;
			List<int> list4 = default;
			int num7 = default;
			object obj20 = default;
			object obj22 = default;
			object obj24 = default;
			IndexOutOfRangeException ex = default;
			while (true)
			{
				int num6;
				if ((nint)obj14 < array.Length)
				{
					bool flag2 = (nint)obj14 < array.Length;
					object obj15 = !flag2;
					if (obj15 != null)
					{
						break;
					}
					object obj16 = (object)array + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v13+20]");
					List<int> list3 = (List<int>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
					object obj18 = 0;
					nint num3 = (nint)obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X23_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
					list4._002Ector(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X23_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
					bool flag3 = (nint)0 < (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X23_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
					num6 = 0;
					if (!flag3)
					{
						object obj19 = obj20;
						num7 = num7;
						object obj21 = obj22;
						object obj23 = obj24;
						object obj25 = obj13;
						int num8 = 0;
						while (true)
						{
							int num9 = list3.get_Item(num8);
							int index = num8 + 1;
							int num10 = list3.get_Item(index);
							num3 = (nint)obj12;
							int num11 = num8 + 2;
							int num12 = list3.get_Item(num11);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v17+18]");
							bool flag4 = (nint)num9 < (nint)0;
							object obj26 = !flag4;
							obj20 = obj19;
							obj22 = obj21;
							obj24 = obj23;
							num = num11;
							if (obj26 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v17+18]");
							bool flag5 = (nint)num10 < (nint)0;
							object obj27 = !flag5;
							obj20 = obj19;
							obj22 = obj21;
							obj24 = obj23;
							num = num11;
							if (obj27 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v17+18]");
							bool flag6 = (nint)num12 < (nint)0;
							object obj28 = !flag6;
							obj20 = obj19;
							obj22 = obj21;
							obj24 = obj23;
							num = num11;
							if (obj28 != null)
							{
								break;
							}
							object obj29 = obj9 + num9;
							object obj30 = obj9 + num10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v29+20]");
							bool flag7 = (nint)0 < (nint)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v29+20]");
							nint num13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v29+20]");
							object obj31 = num13 ^ 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v29+20]");
							object obj32 = 0 & obj31;
							bool flag8 = (nint)obj32 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v30+20]");
							obj22 = 0;
							object obj33 = obj9 + num12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v31+20]");
							obj24 = 0;
							bool flag9 = flag7 == flag8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v30+20]");
							bool flag10 = (((nint)0 < (nint)0) ? flag9 : ((byte)((flag9 ? 1u : 0u) + 1u) != 0));
							if ((nint)obj24 >= 0)
							{
								flag10 = (byte)((flag10 ? 1u : 0u) + 1u) != 0;
							}
							bool flag11 = !flag10;
							int num14 = num12;
							num6 = num11;
							if (!flag11)
							{
								if ((flag10 ? 1 : 0) == 3)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
									object obj34 = 0;
									object obj35 = obj25;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
									object obj36 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
									nint num15 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1092 @ X8_v85+18]");
									bool flag12 = num15 < 0;
									object obj37 = !flag12;
									if (obj37 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj38 = (nint)0 + (nint)1;
										object obj39 = obj34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj40 = obj39 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
										object obj41 = (nint)0 + (nint)1;
										num6 = num11;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X9_v46+20]");
										object obj42 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X8_v92+A8]");
										object obj43 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ X8_v93+70]");
										num3 = 0;
										list4.AddWithResize(num9);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
										obj34 = 0;
										obj35 = obj25;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
										object obj44 = (nint)0 + (nint)1;
										num6 = num9;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
									nint num16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1092 @ X8_v85+18]");
									bool flag13 = num16 < 0;
									object obj45 = !flag13;
									if (obj45 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj46 = (nint)0 + (nint)1;
										object obj47 = obj34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj48 = obj47 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
										object obj49 = (nint)0 + (nint)1;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X9_v46+20]");
										object obj50 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X8_v89+A8]");
										object obj51 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ X8_v90+70]");
										num3 = 0;
										list4.AddWithResize(num10);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
										obj34 = 0;
										obj35 = obj25;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
										object obj52 = (nint)0 + (nint)1;
										num6 = num10;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
									nint num17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1092 @ X8_v85+18]");
									bool flag14 = num17 < 0;
									object obj53 = !flag14;
									if (obj53 == null)
									{
										object obj54 = obj34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj55 = obj54 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj56 = (nint)0 + (nint)1;
										num14 = num12;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X9_v46+20]");
										object obj57 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1100 @ X8_v86+A8]");
										object obj58 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v87+70]");
										num3 = 0;
										list4.AddWithResize(num12);
										num14 = num12;
										num6 = num12;
									}
								}
								else
								{
									bool flag15 = (nint)obj22 < 0;
									object obj59 = obj22 ^ obj22;
									object obj60 = obj22 & obj59;
									bool flag16 = (nint)obj60 < 0;
									bool flag17 = flag15 == flag16;
									object obj61 = (flag10 ? 1 : 0) - 1;
									bool flag18 = obj61 == null;
									object obj62 = !flag18;
									object obj63 = flag17 ^ obj62;
									object obj64 = obj63 & 1;
									int num18;
									if (obj64 != null)
									{
										num7 = num9;
										num14 = num10;
										num18 = num12;
									}
									else
									{
										bool flag19 = (nint)obj24 < 0;
										object obj65 = obj24 ^ obj24;
										object obj66 = obj24 & obj65;
										bool flag20 = (nint)obj66 < 0;
										bool flag21 = flag19 == flag20;
										if ((flag21 ? 1 : 0) != (nint)obj62)
										{
											num7 = num10;
											num14 = num12;
											num18 = num9;
										}
										else
										{
											num7 = num12;
											num14 = num9;
											num18 = num10;
										}
									}
									object obj103;
									(int, int) tuple;
									int num27;
									int item;
									(int, int) tuple2;
									if (!flag10)
									{
										int num19 = _003CClip_003Eg__Cross_007C7_0(num18, num14, ref obj5);
										int num20 = _003CClip_003Eg__Cross_007C7_0(num7, num14, ref obj5);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
										object obj67 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
										object obj68 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num21 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v61+18]");
										bool flag22 = num21 < 0;
										object obj69 = !flag22;
										if (obj69 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj70 = (nint)0 + (nint)1;
											object obj71 = obj67;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj72 = obj71 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj73 = (nint)0 + (nint)1;
										}
										else
										{
											list4.AddWithResize(num19);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
											obj67 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj74 = (nint)0 + (nint)1;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num22 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v61+18]");
										bool flag23 = num22 < 0;
										object obj75 = !flag23;
										if (obj75 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj76 = (nint)0 + (nint)1;
											object obj77 = obj67;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj78 = obj77 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj79 = (nint)0 + (nint)1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
											obj25 = 0;
										}
										else
										{
											list4.AddWithResize(num18);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
											obj67 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
											obj25 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj80 = (nint)0 + (nint)1;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num23 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v61+18]");
										bool flag24 = num23 < 0;
										object obj81 = !flag24;
										if (obj81 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj82 = (nint)0 + (nint)1;
											object obj83 = obj67;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj84 = obj83 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj85 = (nint)0 + (nint)1;
										}
										else
										{
											list4.AddWithResize(num7);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
											obj67 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj86 = (nint)0 + (nint)1;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num24 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v61+18]");
										bool flag25 = num24 < 0;
										object obj87 = !flag25;
										if (obj87 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj88 = (nint)0 + (nint)1;
											object obj89 = obj67;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj90 = obj89 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj91 = (nint)0 + (nint)1;
										}
										else
										{
											list4.AddWithResize(num19);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
											obj67 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj92 = (nint)0 + (nint)1;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v61+18]");
										bool flag26 = num25 < 0;
										object obj93 = !flag26;
										if (obj93 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj94 = (nint)0 + (nint)1;
											object obj95 = obj67;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj96 = obj95 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj97 = (nint)0 + (nint)1;
										}
										else
										{
											list4.AddWithResize(num7);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
											obj67 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj98 = (nint)0 + (nint)1;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num26 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v61+18]");
										bool flag27 = num26 < 0;
										object obj99 = !flag27;
										if (obj99 == null)
										{
											object obj100 = obj67;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj101 = obj100 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj102 = (nint)0 + (nint)1;
										}
										else
										{
											list4.AddWithResize(num20);
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41E0]");
										obj103 = 0;
										tuple = ((int, int))0;
										num14 = num20;
										num27 = num19;
										item = num20;
										tuple2 = ((int, int))(&tuple);
									}
									else
									{
										int num28 = _003CClip_003Eg__Cross_007C7_0(num14, num18, ref obj5);
										int num29 = _003CClip_003Eg__Cross_007C7_0(num14, num7, ref obj5);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
										object obj104 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
										obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
										object obj105 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X8_v43+18]");
										bool flag28 = num30 < 0;
										object obj106 = !flag28;
										if (obj106 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj107 = (nint)0 + (nint)1;
											object obj108 = obj104;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj109 = obj108 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj110 = (nint)0 + (nint)1;
										}
										else
										{
											list4.AddWithResize(num14);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
											obj104 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj111 = (nint)0 + (nint)1;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num31 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X8_v43+18]");
										bool flag29 = num31 < 0;
										object obj112 = !flag29;
										if (obj112 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj113 = (nint)0 + (nint)1;
											object obj114 = obj104;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj115 = obj114 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj116 = (nint)0 + (nint)1;
										}
										else
										{
											list4.AddWithResize(num28);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+10]");
											obj104 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj117 = (nint)0 + (nint)1;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num32 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X8_v43+18]");
										bool flag30 = num32 < 0;
										object obj118 = !flag30;
										if (obj118 == null)
										{
											object obj119 = obj104;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj120 = obj119 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v26 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj121 = (nint)0 + (nint)1;
										}
										else
										{
											list4.AddWithResize(num29);
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41E0]");
										obj103 = 0;
										tuple = ((int, int))0;
										num7 = num29;
										num27 = num29;
										item = num28;
										tuple2 = ((int, int))(&tuple);
									}
									obj19 = obj103;
									*((int, int)*)(nint)tuple2 = (item, num27);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
									object obj122 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69B0]");
									object obj123 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+1C]");
									object obj124 = (nint)0 + (nint)1;
									object obj125 = obj123;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
									nint num33 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v37+18]");
									bool flag31 = num33 < 0;
									object obj126 = !flag31;
									if (obj126 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
										object obj127 = obj122 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
										object obj128 = (nint)0 + (nint)1;
										num3 = num27;
										num6 = (int)tuple;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X9_v18+20]");
										object obj129 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1284 @ X8_v38+A8]");
										object obj130 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v39+70]");
										num3 = 0;
										list.AddWithResize(tuple);
										num6 = (int)tuple;
									}
								}
							}
							num8 = num11 + 1;
							int num34 = num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X23_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
							bool flag32 = (nint)num34 < (nint)0;
							obj20 = obj19;
							obj13 = obj25;
							obj21 = obj22;
							obj23 = obj24;
							if (flag32)
							{
								continue;
							}
							goto IL_12dd;
						}
						break;
					}
					goto IL_12dd;
				}
				return list;
				IL_12dd:
				List<int>[] array2 = tris;
				if (list4 != null)
				{
					nint num35 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v26 (Il2CppClass<System.Collections.Generic.List`1<System.Int32>[]>)+40]");
					num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag33 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v26 (Il2CppClass<System.Collections.Generic.List`1<System.Int32>[]>)+40]");
					num = 0;
					if (flag33)
					{
						goto IL_141e;
					}
				}
				bool flag34 = (nint)obj14 < array2.Length;
				object obj131 = !flag34;
				num = num6;
				if (obj131 != null)
				{
					break;
				}
				object obj132 = (object)array2 + obj14;
				object obj133 = obj132 + 32;
				obj133 = list4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj14++;
				array = tris;
				bool flag35 = tris == null;
				object obj134 = !flag35;
				num = (int)list4;
				if (obj134 == null)
				{
					throw new NullReferenceException();
				}
			}
			goto IL_1410;
			IL_1410:
			ex = new IndexOutOfRangeException();
			goto IL_141e;
			IL_141e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			return (List<(int, int)>)(object)new ArgumentNullException();
		}

		public Shape()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0021: Expected Obj, but got I
			//IL_0032: Expected Obj, but got I
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected Obj, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected Obj, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected Obj, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6788]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6980]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<Vector3> list = default;
			list._002Ector();
			object obj4 = this + 16;
			obj4 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<Vector3> list2 = default;
			list2._002Ector();
			object obj5 = this + 24;
			obj5 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<Vector2> list3 = default;
			list3._002Ector();
			object obj6 = this + 32;
			obj6 = list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<BoneWeight> list4 = default;
			list4._002Ector();
			object obj7 = this + 40;
			obj7 = list4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}

		private int _003CRefine_003Eg__Mid_007C6_0(int a, int b, ref _003C_003Ec__DisplayClass6_0 P_2, ref _003C_003Ec__DisplayClass6_1 P_3)
		{
			//IL_0261: Expected Obj, but got I4
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Expected I4, but got Unknown
			//IL_02bf: Expected Obj, but got I4
			//IL_02e4: Invalid comparison between VT and I4
			//IL_023a: Expected I4, but got Obj
			//IL_002f: Expected Obj, but got I
			//IL_0045: Expected I8, but got I4
			//IL_0045: Expected Obj, but got VT
			//IL_0063: Expected Obj, but got I4
			//IL_00a0: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got VT
			//IL_0100: Invalid comparison between VT and I4
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected Obj, but got Unknown
			//IL_0206: Expected I4, but got I8
			//IL_036b: Invalid comparison between VT and I4
			//IL_0156: Expected Obj, but got I4
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected I4, but got Unknown
			//IL_01c3: Expected Obj, but got I4
			//IL_0222: Expected I8, but got I4
			//IL_0222: Expected Obj, but got VT
			//IL_0311: Expected Obj, but got I4
			//IL_0319: Unknown result type (might be due to invalid IL or missing references)
			//IL_031e: Expected Obj, but got Unknown
			int num2 = default;
			int num = num2 | a;
			int num3 = a | num2;
			object obj = a - num2;
			bool flag = (nint)obj < 0;
			int num4 = a ^ num2;
			int num5 = a ^ obj;
			int num6 = num4 & num5;
			bool flag2 = num6 < 0;
			bool flag3 = flag == flag2;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			int num7 = ((obj3 != null) ? num3 : num);
			int num12 = default;
			if (System.Runtime.CompilerServices.Unsafe.As<_003C_003Ec__DisplayClass6_0, _003C_003Ec__DisplayClass6_1>(ref P_2) != (_003C_003Ec__DisplayClass6_1)(object)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C10]");
				object obj4 = 0;
				bool flag4 = ((Dictionary<long, int>)System.Runtime.CompilerServices.Unsafe.As<_003C_003Ec__DisplayClass6_0, _003C_003Ec__DisplayClass6_1>(ref P_2)).TryGetValue(num7, out var _);
				bool flag5 = !flag4;
				object obj5 = !flag5;
				if (obj5 != null)
				{
					goto IL_0227;
				}
				if (at != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
					object obj6 = 0;
					object obj7 = P_2;
					Vector3 vector = at.get_Item(a);
					if (at != null)
					{
						Vector3 vector2 = at.get_Item(num2);
						if (P_2 != (_003C_003Ec__DisplayClass6_0)(object)0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v156 @ X24_v5+18] (should have been resolved before IL gen)");
							object obj9 = default;
							object obj8 = obj9 & 1;
							if (obj8 != null)
							{
								object obj10 = a - num2;
								bool flag6 = (nint)obj10 < 0;
								bool flag7 = obj10 == null;
								int num8 = a ^ num2;
								int num9 = a ^ obj10;
								int num10 = num8 & num9;
								bool flag8 = num10 < 0;
								bool flag9 = flag6 == flag8;
								object obj11 = !flag9;
								object obj12 = ~obj11;
								int a2 = ((obj12 != null) ? num2 : a);
								bool flag10 = flag6 == flag8;
								object obj13 = !flag7;
								object obj14 = flag10 & obj13;
								object obj15 = ~obj14;
								if (obj15 == null)
								{
								}
								int num11 = Between(a2, a, 0.5f);
								num12 = num11;
							}
							else
							{
								num12 = -1;
							}
							if (System.Runtime.CompilerServices.Unsafe.As<_003C_003Ec__DisplayClass6_0, _003C_003Ec__DisplayClass6_1>(ref P_2) != (_003C_003Ec__DisplayClass6_1)(object)0)
							{
								((Dictionary<long, int>)System.Runtime.CompilerServices.Unsafe.As<_003C_003Ec__DisplayClass6_0, _003C_003Ec__DisplayClass6_1>(ref P_2)).set_Item((long)num7, num12);
								goto IL_0227;
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_0227:
			return num12;
		}

		internal static void _003CRefine_003Eg__Add_007C6_1(int a, int b, int c, ref _003C_003Ec__DisplayClass6_2 P_3)
		{
			//IL_0247: Expected Obj, but got VT
			//IL_0016: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I4
			//IL_00c4: Expected Obj, but got VT
			//IL_00d9: Expected Obj, but got I
			//IL_00f0: Expected Obj, but got I
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected Obj, but got Unknown
			//IL_0099: Expected Obj, but got I
			//IL_0123: Expected Obj, but got I4
			//IL_0187: Expected Obj, but got VT
			//IL_019c: Expected Obj, but got I
			//IL_01b3: Expected Obj, but got I
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected Obj, but got Unknown
			//IL_015c: Expected Obj, but got I
			//IL_01e6: Expected Obj, but got I4
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Expected Obj, but got Unknown
			//IL_021f: Expected Obj, but got I
			List<int> list = (List<int>)P_3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj2 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+18]");
			bool flag = num < 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj4 = obj + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj5 = (nint)0 + (nint)1;
			}
			else
			{
				list.AddWithResize(a);
				list = (List<int>)P_3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj7 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v6+18]");
			bool flag2 = num2 < 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj9 = obj6 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj10 = (nint)0 + (nint)1;
			}
			else
			{
				list.AddWithResize(b);
				list = (List<int>)P_3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj12 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v8+18]");
			bool flag3 = num3 < 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj14 = obj11 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj15 = (nint)0 + (nint)1;
			}
			else
			{
				list.AddWithResize(c);
			}
		}

		private int _003CClip_003Eg__Cross_007C7_0(int keep, int gone, ref RimGrid._003C_003Ec__DisplayClass7_0 P_2)
		{
			//IL_0301: Invalid comparison between VT and I4
			//IL_02f3: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_0038: Expected I8, but got I4
			//IL_0038: Expected Obj, but got VT
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_0093: Expected F8, but got I4
			//IL_00a8: Expected Obj, but got I
			//IL_0119: Invalid comparison between F8 and I4
			//IL_0128: Expected F8, but got I4
			//IL_020e: Invalid comparison between F8 and I4
			//IL_0221: Expected Obj, but got F8
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected Obj, but got Unknown
			//IL_0256: Expected Obj, but got I4
			//IL_0353: Expected Obj, but got I4
			//IL_0373: Unknown result type (might be due to invalid IL or missing references)
			//IL_0378: Expected Obj, but got Unknown
			//IL_02b0: Invalid comparison between VT and I4
			//IL_02db: Expected I8, but got I4
			//IL_02db: Expected Obj, but got VT
			int num;
			double num3;
			if (P_2 != (RimGrid._003C_003Ec__DisplayClass7_0)(object)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C10]");
				object obj = 0;
				num = gone | keep;
				bool flag = ((Dictionary<long, int>)P_2).TryGetValue(num, out var _);
				bool flag2 = !flag;
				object obj2 = !flag2;
				if (obj2 != null)
				{
					goto IL_02e0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
				object obj3 = 0;
				object obj4 = 8;
				double num2 = 1.0;
				num3 = 0.0;
				double num8 = default;
				double num10 = default;
				double num12 = default;
				while (at != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X3 (<>c__DisplayClass7_0&)+8]");
					object obj5 = 0;
					Vector3 vector = at.get_Item(keep);
					if (at == null)
					{
						break;
					}
					double num4 = num2 + num3;
					double num5 = num4 * 0.5;
					Vector3 vector2 = at.get_Item(gone);
					bool flag3 = num5 < 0.0;
					double num6 = 0.0;
					if (!flag3)
					{
						bool flag4 = !(num5 > 1.0);
						num6 = num5;
						if (!flag4)
						{
							num6 = 1.0;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X3 (<>c__DisplayClass7_0&)+8]");
					if ((nint)0 == 0)
					{
						break;
					}
					double num7 = num8 - num8;
					double num9 = num10 - num10;
					double num11 = num4 - num12;
					double num13 = num7 * num6;
					double num14 = num9 * num6;
					double num15 = num11 * num6;
					num8 += num13;
					num10 += num14;
					num12 += num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X26_v5+18] (should have been resolved before IL gen)");
					bool flag5 = num12 < 0.0;
					object obj6 = num12 ^ num12;
					object obj7 = num12 & obj6;
					bool flag6 = (nint)obj7 < 0;
					bool flag7 = flag5 == flag6;
					object obj8 = !flag7;
					object obj9 = ~obj8;
					if (obj9 == null)
					{
						num2 = num5;
					}
					bool flag8 = flag5 == flag6;
					object obj10 = !flag8;
					object obj11 = ~obj10;
					if (obj11 != null)
					{
						num3 = num5;
					}
					obj4--;
					if ((nint)obj4 != 1)
					{
						continue;
					}
					goto IL_028c;
				}
			}
			goto IL_02e5;
			IL_02e0:
			int num16 = default;
			return num16;
			IL_028c:
			num16 = Between(keep, gone, (float)num3);
			if (P_2 != (RimGrid._003C_003Ec__DisplayClass7_0)(object)0)
			{
				((Dictionary<long, int>)P_2).set_Item((long)num, num16);
				goto IL_02e0;
			}
			goto IL_02e5;
			IL_02e5:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class RimGrid
	{
		[StructLayout((LayoutKind)3)]
		private struct _003C_003Ec__DisplayClass7_0
		{
			public Dictionary<long, int> on;

			public Func<Vector3, float> into;

			public Shape _003C_003E4__this;
		}

		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public RimGrid _003C_003E4__this;

			public int[] count;

			public int[] fill;

			public Action<int> _003C_003E9__0;

			internal void _003C_002Ector_003Eb__0(int sq)
			{
				//IL_0044: Expected Obj, but got I4
				//IL_0053: Expected Obj, but got I4
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Expected Obj, but got Unknown
				//IL_0090: Unknown result type (might be due to invalid IL or missing references)
				//IL_0095: Expected Obj, but got Unknown
				//IL_00ab: Expected Obj, but got I
				int[] array = count;
				if (count != null)
				{
					bool flag = array.Length < sq;
					object obj = !flag;
					object obj2 = array.Length - sq;
					bool flag2 = obj2 == null;
					object obj3 = ~obj;
					object obj4 = obj3 | flag2;
					if (obj4 == null)
					{
						object obj5 = count + sq;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2+20]");
						object obj6 = (nint)0 + (nint)1;
						return;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				throw new IndexOutOfRangeException();
			}
		}

		private readonly List<(Vector2, Vector2)> edges;

		private readonly float size;

		private readonly float x0;

		private readonly float y0;

		private readonly int across;

		private readonly int down;

		private readonly int[] start;

		private readonly int[] inSquare;

		private readonly int[] seen;

		private int look;

		public unsafe RimGrid(List<(Vector2, Vector2)> edges, float size)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got I
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected Obj, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected Obj, but got I
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected Obj, but got Unknown
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_031c: Expected Obj, but got Unknown
			//IL_0343: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Expected Obj, but got Unknown
			//IL_0185: Expected Obj, but got I
			//IL_0197: Expected F4, but got I
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected Obj, but got I4
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Expected Obj, but got I4
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Expected Obj, but got I4
			//IL_1164: Expected Obj, but got I4
			//IL_0228: Expected I4, but got F4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Invalid comparison between Unknown and I4
			//IL_0288: Expected Obj, but got I4
			//IL_0290: Expected Obj, but got Ref
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_0294: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Expected Obj, but got I4
			//IL_0c1b: Expected Obj, but got I4
			//IL_0c79: Expected Obj, but got I
			//IL_02dd: Expected Obj, but got I4
			//IL_0ccc: Invalid comparison between F4 and I4
			//IL_0cf9: Invalid comparison between F4 and I4
			//IL_0d08: Invalid comparison between F4 and I4
			//IL_0d17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d1c: Expected Obj, but got Unknown
			//IL_0d29: Expected Obj, but got F4
			//IL_0d5e: Expected Obj, but got I4
			//IL_0d66: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d6b: Expected Obj, but got Unknown
			//IL_0397: Expected F4, but got I4
			//IL_03c1: Expected F4, but got I4
			//IL_0d8c: Expected I4, but got F4
			//IL_119d: Expected Obj, but got I4
			//IL_040a: Expected Obj, but got I4
			//IL_0db3: Expected Obj, but got I4
			//IL_0de7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dec: Expected I4, but got Unknown
			//IL_0e21: Expected Obj, but got I4
			//IL_0e29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2e: Expected Obj, but got Unknown
			//IL_0e54: Expected Obj, but got I4
			//IL_0e5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e62: Expected Obj, but got Unknown
			//IL_0e86: Expected Obj, but got I4
			//IL_0ead: Invalid comparison between F4 and I4
			//IL_0ebc: Invalid comparison between F4 and I4
			//IL_0eca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ecf: Expected I4, but got Unknown
			//IL_0edc: Expected Obj, but got F4
			//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee9: Expected I4, but got Unknown
			//IL_0f11: Expected Obj, but got I4
			//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f1e: Expected Obj, but got Unknown
			//IL_0f59: Invalid comparison between F4 and I4
			//IL_0f68: Invalid comparison between F4 and I4
			//IL_0f78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f7d: Expected I4, but got Unknown
			//IL_0f8c: Expected Obj, but got F4
			//IL_0f94: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f99: Expected I4, but got Unknown
			//IL_0fc1: Expected Obj, but got I4
			//IL_0fc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fce: Expected Obj, but got Unknown
			//IL_0463: Expected I4, but got F4
			//IL_0fef: Expected F4, but got I4
			//IL_1002: Unknown result type (might be due to invalid IL or missing references)
			//IL_1007: Expected Obj, but got Unknown
			//IL_100f: Expected Obj, but got I4
			//IL_058e: Expected Obj, but got I4
			//IL_0597: Unknown result type (might be due to invalid IL or missing references)
			//IL_059c: Expected Obj, but got Unknown
			//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b1: Expected Obj, but got Unknown
			//IL_047f: Expected I4, but got F4
			//IL_05e3: Expected Obj, but got I4
			//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0494: Expected Obj, but got I
			//IL_04a4: Expected Obj, but got I
			//IL_088b: Expected F4, but got I4
			//IL_104e: Expected Obj, but got I
			//IL_1070: Expected Obj, but got I4
			//IL_055f: Expected I, but got Obj
			//IL_0567: Expected I, but got Obj
			//IL_08f5: Expected Obj, but got I4
			//IL_04e5: Expected I, but got Obj
			//IL_0662: Expected Obj, but got I4
			//IL_0678: Expected Obj, but got I
			//IL_0692: Expected Obj, but got I4
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f8: Expected Obj, but got Unknown
			//IL_0510: Expected Obj, but got I4
			//IL_0903: Unknown result type (might be due to invalid IL or missing references)
			//IL_090b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0910: Expected Obj, but got Unknown
			//IL_0920: Unknown result type (might be due to invalid IL or missing references)
			//IL_0925: Expected Obj, but got Unknown
			//IL_06d4: Expected Obj, but got I4
			//IL_0969: Expected Obj, but got I
			//IL_097c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0981: Expected Obj, but got Unknown
			//IL_1098: Expected F4, but got I8
			//IL_10a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_10a6: Expected Obj, but got Unknown
			//IL_06c6: Expected Obj, but got I
			//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10bc: Invalid comparison between F4 and I4
			//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2a: Expected Obj, but got Unknown
			//IL_0759: Expected Obj, but got I4
			//IL_0a77: Expected Obj, but got I
			//IL_0a87: Expected Obj, but got I
			//IL_1103: Expected I, but got Obj
			//IL_0ad7: Expected Obj, but got I4
			//IL_0adf: Expected I, but got Obj
			//IL_0ae7: Expected Obj, but got I4
			//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b0: Expected Obj, but got Unknown
			//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bd: Expected Obj, but got Unknown
			//IL_07db: Expected Obj, but got I
			//IL_07f8: Expected Obj, but got I
			//IL_0818: Expected Obj, but got I4
			//IL_0844: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDBE6]");
			Enumerator<, > val = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			base._002Ector();
			bool flag = obj2 == null;
			Enumerator<, > val2 = (Enumerator<, >)0;
			float num = default;
			Enumerator<, > val3 = (Enumerator<, >)num;
			int num2 = 0;
			List<(Vector2, Vector2)> list = null;
			int num8;
			List<(Vector2, Vector2)> list2 = default;
			object obj55;
			object obj57;
			object obj58;
			int num29;
			object obj60;
			int num26;
			int num9 = default;
			object obj59 = default;
			int num30 = default;
			object obj61 = default;
			object obj53;
			object obj44;
			int num27;
			if (!flag)
			{
				object obj3 = obj2 + 16;
				obj3 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj4 = this + 16;
				obj4 = edges;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				_ = 0;
				bool flag2 = (object)edges == null;
				val2 = (Enumerator<, >)0;
				val3 = (Enumerator<, >)num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				num2 = 0;
				list = edges;
				val = (Enumerator<, >)17276928;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj6 = this + 64;
					object obj7 = default;
					obj6 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X1 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj8 = this + 48;
						object obj9 = default;
						obj8 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj10 = this + 56;
						object obj11 = default;
						obj10 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C50]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					x0 = 0f;
					Enumerator<, > enumerator = edges.GetEnumerator();
					float num3 = num;
					num2 = -129;
					while (val2.MoveNext())
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
						num3 = x0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
						x0 = x0;
						num2 = (int)num;
					}
					object obj13 = 5;
					Enumerator<, > val4 = default;
					val2 = val4;
					val3 = (Enumerator<, >)0;
					object obj14 = 0;
					Enumerator<, > val5 = (Enumerator<, >)(ref val2);
					val = (Enumerator<, >)(ref val2);
					object obj15 = 0;
					object obj18 = default;
					while (true)
					{
						list = (List<(Vector2, Vector2)>)obj12;
						val2.Dispose();
						bool flag3 = obj15 == null;
						object obj16 = !flag3;
						if (obj16 == null)
						{
							bool flag4 = (int)val3 == 0;
							object obj17 = !flag4;
							OutOfMemoryException ex = (OutOfMemoryException)(&val2);
							val = val3;
							if (obj17 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)list == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							val3 = (Enumerator<, >)1;
							val = (Enumerator<, >)1;
							obj15 = obj14;
						}
						else
						{
							if ((nint)list != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DB6C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj15 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj14 = obj18;
						}
						obj13 = 0;
					}
					if ((nint)obj13 != 5 && (object)(obj13 != null) != null)
					{
						return;
					}
					object obj19 = 109891584;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj20 = 0;
					object obj21 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v9+E4]");
					bool flag5;
					if ((nint)0 != 0)
					{
						flag5 = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X22_v5+BA4]");
						flag5 = (nint)0 == 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					float num4 = x0 + 1f;
					float num5 = ((num4 < 512f) ? (x0 + 1f) : 512f);
					float num6 = num5 - 1f;
					bool flag6 = num6 < 0f;
					bool flag7 = num6 == 0f;
					object obj22 = num5 ^ 1;
					object obj23 = num5 ^ num6;
					object obj24 = obj22 & obj23;
					bool flag8 = (nint)obj24 < 0;
					bool flag9 = flag6 == flag8;
					object obj25 = !flag7;
					object obj26 = flag9 & obj25;
					object obj27 = ~obj26;
					if (obj27 != null)
					{
						num5 = 1f;
					}
					across = (int)num5;
					if (flag5)
					{
						_ = 1;
					}
					object obj28 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X0_v12+E4]");
					bool flag10 = (nint)0 == 0;
					object obj29 = !flag10;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					float num7 = -129f - x0;
					num8 = (((nint)(object)(num9 + 1) < 512) ? (num9 + 1) : 512);
					object obj30 = num8 - 1;
					bool flag11 = (nint)obj30 < 0;
					bool flag12 = obj30 == null;
					int num10 = num8 ^ 1;
					int num11 = num8 ^ obj30;
					int num12 = num10 & num11;
					bool flag13 = num12 < 0;
					bool flag14 = flag11 == flag13;
					object obj31 = !flag12;
					object obj32 = flag14 & obj31;
					object obj33 = ~obj32;
					if (obj33 != null)
					{
						num8 = 1;
					}
					object obj34 = across * num8;
					object obj35 = 1 + obj34;
					down = num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					object obj36 = across + 191;
					float num13 = num7 / (float)obj36;
					float num14 = num13 - (float)num8;
					bool flag15 = num14 < 0f;
					bool flag16 = num14 == 0f;
					int num15 = num13 ^ num8;
					object obj37 = num13 ^ num14;
					int num16 = num15 & obj37;
					bool flag17 = num16 < 0;
					bool flag18 = flag15 == flag17;
					object obj38 = !flag16;
					object obj39 = flag18 & obj38;
					object obj40 = ~obj39;
					num2 = ((obj40 != null) ? num8 : ((int)num13));
					num3 = this.size;
					float num17 = this.size - (float)num2;
					bool flag19 = num17 < 0f;
					bool flag20 = num17 == 0f;
					int num18 = this.size ^ num2;
					object obj41 = this.size ^ num17;
					int num19 = num18 & obj41;
					bool flag21 = num19 < 0;
					bool flag22 = flag19 == flag21;
					object obj42 = !flag20;
					object obj43 = flag22 & obj42;
					obj44 = ~obj43;
					if (obj44 == null)
					{
						num2 = (int)this.size;
					}
					this.size = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj45 = obj2 + 24;
					int num20 = default;
					obj45 = num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X1 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C48]");
						object obj46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C78]");
						object obj47 = 0;
						object obj49 = default;
						object obj48 = obj49;
						nint num22 = default;
						nint num21 = num22;
						int num23 = 0;
						int num24 = num20;
						Action<int> action2 = default;
						bool flag24;
						do
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+28]");
							Action<int> action = (Action<int>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+28]");
							bool flag23 = (nint)0 == 0;
							object obj50 = !flag23;
							if (obj50 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								action2._002Ector(obj2, (IntPtr)obj47);
								object obj51 = obj2 + 40;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								obj48 = 0;
								action = action2;
							}
							Span(num23, action);
							num23++;
							int num25 = num23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X1 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
							flag24 = (nint)num25 < (nint)0;
							obj49 = obj48;
							num22 = (nint)action;
							num21 = (nint)action;
							num24 = num23;
						}
						while (flag24);
					}
					object obj52 = 1 + (object)(down * across);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					obj12 = this + 48;
					obj12 = list2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num26 = down;
					obj53 = down * across;
					val = (Enumerator<, >)obj12;
					if ((nint)obj53 >= 1)
					{
						bool flag25 = obj12 == null;
						num9 = num8;
						num27 = -129;
						list = list2;
						if (!flag25)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v3 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>+Enumerator<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
							object obj54 = (nint)0 >= (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v3 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>+Enumerator<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
							obj55 = ~(obj54 & (object)((object)(-1) != null));
							object obj56;
							if (obj55 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v3 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>+Enumerator<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
								obj56 = 0;
							}
							else
							{
								obj56 = 1;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v3 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>+Enumerator<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
							float num28 = 0f;
							obj57 = obj56 - 1;
							num26 = 0;
							while (true)
							{
								bool flag26 = num28 == (float)num26;
								obj58 = obj59;
								num29 = num30;
								obj60 = obj53;
								if (flag26)
								{
									break;
								}
								obj53 = obj45;
								bool flag27 = obj45 == null;
								num9 = num8;
								obj61 = obj57;
								obj44 = obj55;
								num27 = -129;
								list = list2;
								if (!flag27)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X12_v6+18]");
									num29 = 0;
									int num31 = num26;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X12_v6+18]");
									bool flag28 = (nint)num31 < (nint)0;
									object obj62 = !flag28;
									obj58 = obj59;
									obj60 = obj45;
									if (obj62 != null)
									{
										break;
									}
									bool flag29 = (nint)obj57 == num26;
									obj58 = obj59;
									obj60 = obj45;
									if (flag29)
									{
										break;
									}
									object obj63 = val + num26;
									object obj64 = obj45 + num26;
									num26++;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X13_v7+20]");
									obj59 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X12_v8+20]");
									nint num32 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X13_v7+20]");
									object obj65 = num32 + 0;
									num30 = down;
									obj53 = down * across;
									if (num26 < (nint)obj53)
									{
										continue;
									}
									goto IL_0834;
								}
								goto IL_0b4e;
							}
							goto IL_0afe;
						}
					}
					else
					{
						bool flag30 = obj12 == null;
						obj58 = obj59;
						num29 = num30;
						obj57 = obj61;
						float num28 = 512f;
						obj60 = obj53;
						obj55 = obj44;
						num9 = num8;
						num27 = -129;
						list = list2;
						if (!flag30)
						{
							goto IL_08c4;
						}
					}
				}
			}
			goto IL_0b4e;
			IL_0afe:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			num9 = num8;
			obj59 = obj58;
			num30 = num29;
			obj61 = obj57;
			obj53 = obj60;
			obj44 = obj55;
			num27 = -129;
			list = list2;
			goto IL_0b4e;
			IL_0834:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X13_v7+20]");
			obj58 = 0;
			num29 = down;
			obj60 = obj53;
			goto IL_08c4;
			IL_08c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v3 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>+Enumerator<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
			num26 = 0;
			object obj66 = obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v3 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>+Enumerator<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
			if ((object)((nint)obj66 >= 0) != null)
			{
				goto IL_0afe;
			}
			object obj67 = val + obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj68 = this + 56;
			object obj69 = default;
			obj68 = obj69;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X22_v9-10]");
			num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X22_v9-10]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X22_v9-14]");
			object obj70 = num33 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj71 = obj2 + 32;
			object obj72 = default;
			obj71 = obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C88]");
			val = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj73 = default;
			obj73._002Ector();
			bool flag31 = obj73 == null;
			num9 = num8;
			obj59 = obj58;
			num30 = num29;
			obj61 = obj57;
			obj53 = obj60;
			obj44 = obj55;
			num27 = -129;
			list = null;
			if (!flag31)
			{
				object obj74 = obj73 + 24;
				obj74 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X1 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C48]");
					object obj75 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C80]");
					object obj76 = 0;
					object obj77 = obj2;
					int num34 = 0;
					Action<int> action3 = default;
					bool flag32;
					do
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						action3._002Ector(obj73, (IntPtr)obj76);
						Span(num34, action3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v34 (System.Object)+10]");
						int num35 = (int)((nint)0 + (nint)1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X1 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
						flag32 = (nint)num35 < (nint)0;
						object obj49 = 0;
						nint num22 = (nint)action3;
						obj77 = num34;
						num34 = num35;
					}
					while (flag32);
				}
				return;
			}
			goto IL_0b4e;
			IL_0b4e:
			throw new NullReferenceException();
		}

		private int Col(float x)
		{
			//IL_0055: Expected Obj, but got I
			//IL_007f: Expected Obj, but got I4
			//IL_0045: Expected I4, but got F4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num = x - x0;
			float num2 = num / size;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			return (int)num2;
		}

		private int Row(float y)
		{
			//IL_0055: Expected Obj, but got I
			//IL_007f: Expected Obj, but got I4
			//IL_0045: Expected I4, but got F4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num = y - y0;
			float num2 = num / size;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			return (int)num2;
		}

		private void Span(int e, Action<int> each)
		{
			//IL_0032: Invalid comparison between F4 and I4
			//IL_0041: Invalid comparison between F4 and I4
			//IL_0054: Expected Obj, but got F4
			//IL_0061: Expected Obj, but got F4
			//IL_0263: Expected Obj, but got I4
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected Obj, but got Unknown
			//IL_02b2: Expected Obj, but got I4
			//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Expected I4, but got Unknown
			//IL_0310: Expected Obj, but got I4
			//IL_0378: Expected Obj, but got I4
			//IL_03ba: Expected Obj, but got I4
			//IL_03de: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Expected I4, but got Unknown
			//IL_0418: Expected Obj, but got I4
			//IL_0480: Expected Obj, but got I4
			//IL_04af: Invalid comparison between F4 and I4
			//IL_04be: Invalid comparison between F4 and I4
			//IL_04d1: Expected Obj, but got F4
			//IL_04de: Expected Obj, but got F4
			//IL_0532: Expected Obj, but got I4
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_053f: Expected Obj, but got Unknown
			//IL_0581: Expected Obj, but got I4
			//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05aa: Expected I4, but got Unknown
			//IL_05df: Expected Obj, but got I4
			//IL_0647: Expected Obj, but got I4
			//IL_0689: Expected Obj, but got I4
			//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b2: Expected I4, but got Unknown
			//IL_06e7: Expected Obj, but got I4
			//IL_074f: Expected Obj, but got I4
			bool flag = (object)edges == null;
			int index = default;
			(Vector2, Vector2) tuple = edges.get_Item(index);
			float num2 = default;
			float num3 = default;
			float num = num2 - num3;
			bool flag2 = num < 0f;
			bool flag3 = num == 0f;
			object obj = num2 ^ num3;
			object obj2 = num2 ^ num;
			object obj3 = obj & obj2;
			bool flag4 = (nint)obj3 < 0;
			float x = ((!(num2 < num3)) ? num3 : num2);
			bool flag5 = flag2 == flag4;
			object obj4 = !flag3;
			object obj5 = flag5 & obj4;
			object obj6 = ~obj5;
			float x2 = ((obj6 != null) ? num3 : num2);
			int num4 = Col(x);
			int num5 = across - 1;
			object obj7 = num4 - num5;
			bool flag6 = (nint)obj7 < 0;
			int num6 = num4 ^ num5;
			int num7 = num4 ^ obj7;
			int num8 = num6 & num7;
			bool flag7 = num8 < 0;
			bool flag8 = flag6 == flag7;
			object obj8 = !flag8;
			object obj9 = ~obj8;
			if (obj9 == null)
			{
				num5 = num4;
			}
			bool flag9 = num4 < 0;
			int num9 = num4 ^ num4;
			int num10 = num4 & num9;
			bool flag10 = num10 < 0;
			bool flag11 = flag9 == flag10;
			object obj10 = !flag11;
			object obj11 = ~obj10;
			int num11 = ((obj11 != null) ? num5 : 0);
			int num12 = Col(x2);
			int num13 = across - 1;
			object obj12 = num12 - num13;
			bool flag12 = (nint)obj12 < 0;
			int num14 = num12 ^ num13;
			int num15 = num12 ^ obj12;
			int num16 = num14 & num15;
			bool flag13 = num16 < 0;
			bool flag14 = flag12 == flag13;
			object obj13 = !flag14;
			object obj14 = ~obj13;
			if (obj14 == null)
			{
				num13 = num12;
			}
			bool flag15 = num12 < 0;
			int num17 = num12 ^ num12;
			int num18 = num12 & num17;
			bool flag16 = num18 < 0;
			bool flag17 = flag15 == flag16;
			object obj15 = !flag17;
			object obj16 = ~obj15;
			int num19 = ((obj16 != null) ? num13 : 0);
			float num21 = default;
			float num22 = default;
			float num20 = num21 - num22;
			bool flag18 = num20 < 0f;
			bool flag19 = num20 == 0f;
			object obj17 = num21 ^ num22;
			object obj18 = num21 ^ num20;
			object obj19 = obj17 & obj18;
			bool flag20 = (nint)obj19 < 0;
			float y = ((!(num21 < num22)) ? num22 : num21);
			bool flag21 = flag18 == flag20;
			object obj20 = !flag19;
			object obj21 = flag21 & obj20;
			object obj22 = ~obj21;
			float y2 = ((obj22 != null) ? num22 : num21);
			int num23 = Row(y);
			int num24 = down - 1;
			object obj23 = num23 - num24;
			bool flag22 = (nint)obj23 < 0;
			int num25 = num23 ^ num24;
			int num26 = num23 ^ obj23;
			int num27 = num25 & num26;
			bool flag23 = num27 < 0;
			bool flag24 = flag22 == flag23;
			object obj24 = !flag24;
			object obj25 = ~obj24;
			if (obj25 == null)
			{
				num24 = num23;
			}
			bool flag25 = num23 < 0;
			int num28 = num23 ^ num23;
			int num29 = num23 & num28;
			bool flag26 = num29 < 0;
			bool flag27 = flag25 == flag26;
			object obj26 = !flag27;
			object obj27 = ~obj26;
			int i = ((obj27 != null) ? num24 : 0);
			int num30 = Row(y2);
			int num31 = down - 1;
			object obj28 = num30 - num31;
			bool flag28 = (nint)obj28 < 0;
			int num32 = num30 ^ num31;
			int num33 = num30 ^ obj28;
			int num34 = num32 & num33;
			bool flag29 = num34 < 0;
			bool flag30 = flag28 == flag29;
			object obj29 = !flag30;
			object obj30 = ~obj29;
			if (obj30 == null)
			{
				num31 = num30;
			}
			bool flag31 = num30 < 0;
			int num35 = num30 ^ num30;
			int num36 = num30 & num35;
			bool flag32 = num36 < 0;
			bool flag33 = flag31 == flag32;
			object obj31 = !flag33;
			object obj32 = ~obj31;
			for (int num37 = ((obj32 != null) ? num31 : 0); i <= num37; i++)
			{
				if (num11 <= num19)
				{
					int num38 = num11;
					do
					{
						flag = (byte)(i * across) != 0;
						index = num38 + (flag ? 1 : 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [each @ X2 (System.Action`1<System.Int32>)+18] (should have been resolved before IL gen)");
						num38++;
					}
					while (num38 <= num19);
				}
			}
		}

		public float Nearest(Vector2 p)
		{
			//IL_0c32: Expected F4, but got I4
			//IL_0c89: Expected Obj, but got I
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected Obj, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_0cd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd5: Expected I4, but got Unknown
			//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc3: Expected I4, but got Unknown
			//IL_0d92: Expected Obj, but got I4
			//IL_0dc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dca: Expected I4, but got Unknown
			//IL_0dff: Expected Obj, but got I4
			//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0c: Expected Obj, but got Unknown
			//IL_0cef: Expected Obj, but got I4
			//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d27: Expected I4, but got Unknown
			//IL_0d5c: Expected Obj, but got I4
			//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d69: Expected Obj, but got Unknown
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Expected Obj, but got Unknown
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected Obj, but got Unknown
			//IL_0e4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e4f: Expected I4, but got Unknown
			//IL_1193: Expected VT, but got Obj
			//IL_11b5: Expected Obj, but got I4
			//IL_0e30: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e35: Expected I4, but got Unknown
			//IL_0e71: Expected Obj, but got I4
			//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea9: Expected I4, but got Unknown
			//IL_0ede: Expected Obj, but got I4
			//IL_0ee6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eeb: Expected Obj, but got Unknown
			//IL_0f0f: Expected Obj, but got I4
			//IL_0f42: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f47: Expected I4, but got Unknown
			//IL_0f7c: Expected Obj, but got I4
			//IL_0f84: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f89: Expected Obj, but got Unknown
			//IL_0f92: Expected I4, but got Obj
			//IL_0fb2: Expected I4, but got I8
			//IL_0fcc: Expected Obj, but got I4
			//IL_02d2: Expected Obj, but got I
			//IL_02e2: Expected Obj, but got I
			//IL_02f3: Expected F4, but got I4
			//IL_02fc: Expected Obj, but got I4
			//IL_030e: Expected Obj, but got I4
			//IL_11ff: Expected Obj, but got I4
			//IL_120c: Expected Obj, but got I4
			//IL_0b4d: Expected Obj, but got I
			//IL_0b76: Invalid comparison between F4 and I4
			//IL_0b87: Expected Obj, but got I4
			//IL_0b90: Expected I4, but got Obj
			//IL_0343: Expected Obj, but got I4
			//IL_1109: Expected Obj, but got I4
			//IL_1111: Unknown result type (might be due to invalid IL or missing references)
			//IL_1116: Expected Obj, but got Unknown
			//IL_0bab: Expected Obj, but got I4
			//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be3: Expected I4, but got Unknown
			//IL_10c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c8: Expected Obj, but got Unknown
			//IL_10e2: Expected Obj, but got I4
			//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac9: Expected Obj, but got Unknown
			//IL_0445: Expected Obj, but got I4
			//IL_0fe5: Expected Obj, but got I4
			//IL_1007: Expected Obj, but got I4
			//IL_1010: Expected I4, but got Obj
			//IL_108e: Expected I4, but got I8
			//IL_10a8: Expected Obj, but got I4
			//IL_0649: Expected I4, but got Obj
			//IL_067d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0682: Expected Obj, but got Unknown
			//IL_06a3: Expected Obj, but got I4
			//IL_06c0: Expected I4, but got Obj
			//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ce: Expected I4, but got Unknown
			//IL_06de: Expected Obj, but got I
			//IL_11e4: Expected Obj, but got I4
			//IL_06f0: Expected Obj, but got I4
			//IL_0700: Expected Obj, but got I
			//IL_0773: Expected Obj, but got I4
			//IL_07dc: Expected Obj, but got I4
			//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0801: Expected Obj, but got Unknown
			//IL_0814: Unknown result type (might be due to invalid IL or missing references)
			//IL_0819: Expected Obj, but got Unknown
			//IL_0821: Expected I4, but got Obj
			//IL_1027: Unknown result type (might be due to invalid IL or missing references)
			//IL_102c: Expected Obj, but got Unknown
			//IL_1046: Expected Obj, but got I4
			//IL_106e: Expected VT, but got I
			//IL_0861: Expected Obj, but got I4
			//IL_08a3: Expected VT, but got Obj
			//IL_08c5: Expected Obj, but got I4
			//IL_08fb: Expected VT, but got Obj
			//IL_08fb: Expected VT, but got I
			//IL_0909: Expected I4, but got Obj
			//IL_09d5: Expected I, but got Obj
			//IL_0978: Expected I, but got Obj
			List<(Vector2, Vector2)> list = edges;
			if ((object)edges == null)
			{
				goto IL_0c37;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>)+18]");
			float num31;
			if ((nint)0 != 0)
			{
				int num = look + 1;
				look = num;
				float x = default;
				int num2 = Col(x);
				float num4 = default;
				int num3 = Row(num4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X0_v13+E4]");
				object obj3;
				int num6;
				int num7;
				int num9 = default;
				if ((nint)0 != 0)
				{
					obj3 = this + 36;
					int num5 = ~num2;
					num6 = ((num2 >= 0) ? num2 : (-num2));
					num7 = obj3 + num5;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = this + 36;
					int num8 = ~num2;
					num6 = ((num2 >= 0) ? num2 : (-num2));
					num7 = obj3 + num8;
					num9 = num2;
				}
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v15+E4]");
				if ((nint)0 != 0)
				{
					int num10 = ((num7 >= 0) ? num7 : (-num7));
					object obj5 = num6 - num10;
					bool flag = (nint)obj5 < 0;
					bool flag2 = obj5 == null;
					int num11 = num6 ^ num10;
					int num12 = num6 ^ obj5;
					int num13 = num11 & num12;
					bool flag3 = num13 < 0;
					bool flag4 = flag == flag3;
					object obj6 = !flag2;
					object obj7 = flag4 & obj6;
					object obj8 = ~obj7;
					if (obj8 != null)
					{
						num6 = num10;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					int num14 = ((num7 >= 0) ? num7 : (-num7));
					object obj9 = num6 - num14;
					bool flag5 = (nint)obj9 < 0;
					bool flag6 = obj9 == null;
					int num15 = num6 ^ num14;
					int num16 = num6 ^ obj9;
					int num17 = num15 & num16;
					bool flag7 = num17 < 0;
					bool flag8 = flag5 == flag7;
					object obj10 = !flag6;
					object obj11 = flag8 & obj10;
					object obj12 = ~obj11;
					if (obj12 != null)
					{
						num6 = num14;
					}
				}
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X0_v17+E4]");
				int num19;
				int num20;
				object obj15;
				if ((nint)0 != 0)
				{
					object obj14 = this + 40;
					int num18 = ~num3;
					num19 = ((num3 >= 0) ? num3 : (-num3));
					num20 = obj14 + num18;
					obj15 = obj14;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj16 = this + 40;
					int num21 = ~num3;
					num19 = ((num3 >= 0) ? num3 : (-num3));
					num20 = obj16 + num21;
					obj15 = obj16;
					num9 = num3;
				}
				Vector2 vector = (Vector2)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v22 (UnityEngine.Vector2)+E4]");
				bool flag9 = (nint)0 == 0;
				object obj17 = !flag9;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num22 = ((num20 >= 0) ? num20 : (-num20));
				object obj18 = num19 - num22;
				bool flag10 = (nint)obj18 < 0;
				bool flag11 = obj18 == null;
				int num23 = num19 ^ num22;
				int num24 = num19 ^ obj18;
				int num25 = num23 & num24;
				bool flag12 = num25 < 0;
				bool flag13 = flag10 == flag12;
				object obj19 = !flag11;
				object obj20 = flag13 & obj19;
				object obj21 = ~obj20;
				if (obj21 == null)
				{
					num22 = num19;
				}
				object obj22 = num6 - num22;
				bool flag14 = (nint)obj22 < 0;
				bool flag15 = obj22 == null;
				int num26 = num6 ^ num22;
				int num27 = num6 ^ obj22;
				int num28 = num26 & num27;
				bool flag16 = num28 < 0;
				bool flag17 = flag14 == flag16;
				object obj23 = !flag15;
				object obj24 = flag17 & obj23;
				if ((int)(~obj24) == 0)
				{
					num22 = num6;
				}
				int num29 = (int)(num22 & 0x80000000L);
				bool flag18 = num29 == 0;
				object obj25 = !flag18;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C90]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
					object obj27 = 0;
					float num30 = num4;
					num31 = 2.139095E+09f;
					object obj28 = 17276928;
					int num32 = 0;
					object obj29 = 109891584;
					float num33 = num4;
					float num36 = default;
					float num37 = default;
					float num38 = default;
					float num39 = default;
					float num40 = default;
					float num41 = default;
					float num42 = default;
					float num43 = default;
					nint num44 = default;
					Vector2 vector2 = default;
					while (true)
					{
						object obj30 = num3 - num32;
						object obj31 = num32 + num3;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31))
						{
							int num34 = num32 << 1;
							int num35 = num2 - num32;
							obj29 = num32 + num2;
							object obj32 = obj30;
							num36 = num36;
							num37 = num37;
							num38 = num38;
							num39 = num39;
							num40 = num40;
							num41 = num41;
							num42 = num42;
							num43 = num43;
							num44 = num44;
							vector2 = vector2;
							int num45 = num20;
							float num46 = num31;
							int num47 = num9;
							int num48 = num6;
							object obj33 = obj28;
							int num49 = num32;
							Vector2 vector3 = vector;
							object obj34 = obj;
							while (true)
							{
								object obj35 = obj32 & 0x80000000L;
								bool flag19 = obj35 == null;
								obj25 = !flag19;
								if (obj25 == null && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) && num35 <= (nint)obj29)
								{
									object obj36 = obj32 - obj31;
									bool flag20 = obj36 == null;
									object obj37 = !flag20;
									object obj38 = ~obj37;
									bool flag21;
									if (obj38 == null)
									{
										object obj39 = obj32 - obj30;
										flag21 = obj39 == null;
									}
									else
									{
										flag21 = true;
									}
									object obj40 = !flag21;
									object obj41 = ~obj40;
									bool flag22 = obj41 != null || num32 == 0;
									object obj42 = !flag22;
									bool flag23 = (byte)(int)(~obj42) != 0;
									float num50;
									float num51;
									float num52;
									float num53;
									float num54;
									float num55;
									float num56;
									float num57;
									float num58;
									nint num59;
									Vector2 vector4;
									int num60;
									float num61;
									int num62;
									int num63;
									object obj43;
									int num64;
									Vector2 vector5;
									object obj44;
									if (!flag23)
									{
										num50 = num36;
										num51 = num37;
										num52 = num38;
										num53 = num39;
										num54 = num30;
										num55 = num40;
										num56 = num41;
										num57 = num42;
										num58 = num43;
										num59 = num44;
										vector4 = vector2;
										num60 = num45;
										num61 = num46;
										num62 = num35;
										num63 = num47;
										num48 = num34;
										obj43 = obj30;
										num64 = num49;
										x = num33;
										vector5 = vector3;
										int num65 = num34;
										obj44 = obj34;
									}
									else
									{
										num50 = num36;
										num51 = num37;
										num52 = num38;
										num53 = num39;
										num54 = num30;
										num55 = num40;
										num56 = num41;
										num57 = num42;
										num58 = num43;
										num59 = num44;
										vector4 = vector2;
										num60 = num45;
										num61 = num46;
										num62 = num35;
										num63 = num47;
										num48 = 1;
										obj43 = obj30;
										num64 = num49;
										x = num33;
										vector5 = vector3;
										int num65 = num34;
										obj44 = obj34;
									}
									while (true)
									{
										int num66 = (int)(num62 & 0x80000000L);
										bool flag24 = num66 == 0;
										obj25 = !flag24;
										if (obj25 == null)
										{
											obj43 = obj3;
											if (num62 < (nint)obj3)
											{
												int num65 = (int)start;
												if (start == null)
												{
													break;
												}
												obj25 = obj3 * obj32;
												object obj45 = num62 + obj25;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v41 (System.Int32)+18]");
												bool flag25 = (nint)obj45 < 0;
												object obj46 = !flag25;
												if (obj46 == null)
												{
													num64 = (int)((object)start + obj45);
													int num67 = obj45 + 1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1085 @ X10_v15 (System.Int32)+20]");
													obj44 = 0;
													while (true)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v41 (System.Int32)+18]");
														bool flag26 = (nint)num67 < (nint)0;
														object obj47 = !flag26;
														if (obj47 != null)
														{
															break;
														}
														object obj48 = num65 + num67;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X9_v21+20]");
														obj43 = 0;
														object obj49 = obj44;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X9_v21+20]");
														bool flag27 = (nint)obj49 >= 0;
														num60 = num67;
														if (!flag27)
														{
															int[] array = inSquare;
															if (inSquare == null)
															{
																goto end_IL_107c;
															}
															bool flag28 = (nint)obj44 < array.Length;
															object obj50 = !flag28;
															if (obj50 != null)
															{
																break;
															}
															int[] array2 = seen;
															if (seen == null)
															{
																goto end_IL_107c;
															}
															object obj51 = (object)inSquare + obj44;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ X9_v24+20]");
															bool flag29 = (nint)0 < (nint)array2.Length;
															object obj52 = !flag29;
															if (obj52 != null)
															{
																break;
															}
															int[] array3 = seen;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ X9_v24+20]");
															object obj53 = array3 + 0;
															num64 = look;
															object obj54 = obj53 + 32;
															num63 = (int)obj54;
															bool flag30 = (nint)obj54 == look;
															float num68 = num52;
															float num69 = num53;
															float num70 = num54;
															if (!flag30)
															{
																obj54 = look;
																if ((object)edges == null)
																{
																	goto end_IL_107c;
																}
																List<(Vector2, Vector2)> list2 = edges;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ X9_v24+20]");
																(Vector2, Vector2) tuple = list2.get_Item(0);
																vector5 = (Vector2)obj27;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v28 (UnityEngine.Vector2)+E4]");
																bool flag31 = (nint)0 == 0;
																object obj55 = !flag31;
																if (obj55 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																Vector2 p2 = vector5;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ X9_v24+20]");
																float num71 = ToSegment(p2, (Vector2)0, (Vector2)obj26);
																num65 = (int)start;
																flag23 = !(num61 < num71);
																if (!flag23)
																{
																	num50 = num52;
																	num51 = num53;
																	num68 = num54;
																	num69 = x;
																	num70 = num4;
																	num55 = num52;
																	num56 = num53;
																	num57 = num54;
																	num58 = x;
																	num59 = (nint)obj26;
																	x = num71;
																}
																else
																{
																	num50 = num52;
																	num51 = num53;
																	num68 = num54;
																	num69 = x;
																	num70 = num4;
																	num55 = num52;
																	num56 = num53;
																	num57 = num54;
																	num58 = x;
																	num59 = (nint)obj26;
																	num61 = num71;
																	x = num71;
																}
															}
															obj44++;
															bool flag32 = num65 == 0;
															obj25 = !flag32;
															num52 = num68;
															num53 = num69;
															num54 = num70;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ X9_v24+20]");
															vector4 = (Vector2)0;
															if (obj25 == null)
															{
																goto end_IL_107c;
															}
															continue;
														}
														goto IL_09ef;
													}
												}
												goto IL_0c45;
											}
										}
										goto IL_09ef;
										IL_09ef:
										num62 += num48;
										bool flag33 = num62 <= (nint)obj29;
										num36 = num50;
										num37 = num51;
										num38 = num52;
										num39 = num53;
										num30 = num54;
										num40 = num55;
										num41 = num56;
										num42 = num57;
										num43 = num58;
										num44 = num59;
										vector2 = vector4;
										num45 = num60;
										num46 = num61;
										num47 = num63;
										bool flag34 = flag23;
										obj33 = obj43;
										num49 = num64;
										num33 = x;
										vector3 = vector5;
										obj34 = obj44;
										if (flag33)
										{
											continue;
										}
										goto IL_0abb;
										continue;
										end_IL_107c:
										break;
									}
									break;
								}
								goto IL_0abb;
								IL_0abb:
								obj32++;
								bool flag35 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31);
								num20 = num45;
								num31 = num46;
								num9 = num47;
								num6 = num48;
								obj28 = obj33;
								vector = vector3;
								obj = obj34;
								if (flag35)
								{
									continue;
								}
								goto IL_0b20;
							}
							break;
						}
						goto IL_0b20;
						IL_0b20:
						num30 = size;
						int num72 = num32 + 1;
						int num73 = num32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A964]");
						object obj56 = (nint)num73 + (nint)0;
						num33 = (float)obj56 * size;
						float num74 = num31 - num33;
						bool flag36 = num74 < 0f;
						object obj57 = !flag36;
						bool flag37;
						bool flag38;
						bool flag39;
						if ((int)(~obj57) == 0)
						{
							object obj58 = num72 - num22;
							flag37 = (nint)obj58 < 0;
							flag38 = obj58 == null;
							int num75 = num72 ^ num22;
							int num76 = num72 ^ obj58;
							int num77 = num75 & num76;
							flag39 = num77 < 0;
						}
						else
						{
							flag39 = false;
							flag38 = false;
							flag37 = false;
						}
						bool flag40 = flag37 == flag39;
						object obj59 = !flag40;
						object obj60 = obj59 | flag38;
						num32 = num72;
						if (obj60 != null)
						{
							continue;
						}
						goto IL_112c;
					}
					goto IL_0c37;
				}
			}
			num31 = 2.139095E+09f;
			goto IL_112c;
			IL_0c45:
			throw new IndexOutOfRangeException();
			IL_112c:
			return num31;
			IL_0c37:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0c45;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0<T>
	{
		public Func<T> work;

		internal T _003CNext_003Eb__0(Task _)
		{
			//IL_0071: Expected VT, but got Obj
			//IL_0039: Expected Obj, but got I
			//IL_0049: Expected Obj, but got I
			//IL_0059: Expected Obj, but got I
			Func<T> func = work;
			if (work != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Func`1<T>)+40]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Func`1<T>)+28]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Func`1<T>)+18]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X2_v1 (should have been resolved before IL gen)");
			}
			NullReferenceException ex = new NullReferenceException();
			return (T)ex;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public Source source;

		public int side;

		public int tear;

		internal Half _003CPrepareMesh_003Eb__0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_006e: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Work(source, side, tear);
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public Mesh m;

		public Vector3[] at;

		public Vector3[] faces;

		public int[] corners;

		public Bounds bounds;

		internal unsafe GillaWounds.BoneShape _003CPrepareShape_003Eb__0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
			//IL_0045: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = default;
			return GillaWounds.Shaped(m, at, faces, corners, (Bounds)(&obj4));
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public int sign;

		public int seed;

		public Along along;

		public Source read;

		internal unsafe Half _003CCut_003Eb__0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0072: Expected Obj, but got I4
			//IL_003f: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Along along = default;
			return Work(read, sign, seed, (Along)(&along));
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public int seed;

		public Along along;
	}

	private sealed class _003C_003Ec__DisplayClass40_1
	{
		public Source r;

		public int side;

		public _003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals1;

		internal unsafe Half _003CBegin_003Eb__0()
		{
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_007a: Expected VT, but got Ref
			_003C_003Ec__DisplayClass40_0 obj = CS_0024_003C_003E8__locals1;
			if (CS_0024_003C_003E8__locals1 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Along along = default;
				return Work(r, side, obj.seed, (Along)(&along));
			}
			return (Half)(object)new NullReferenceException();
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public float gone;

		public int sign;

		public int seed;

		internal bool _003CWork_003Eb__0(Vector3 a, Vector3 b)
		{
			//IL_00df: Expected Obj, but got I
			//IL_011b: Invalid comparison between Obj and F4
			object obj2 = default;
			object obj3 = default;
			object obj = obj2 - obj3;
			object obj5 = default;
			object obj6 = default;
			object obj4 = obj5 - obj6;
			object obj8 = default;
			object obj9 = default;
			object obj7 = obj8 - obj9;
			object obj10 = obj * obj;
			object obj11 = obj4 * obj4;
			object obj12 = obj7 * obj7;
			object obj13 = obj10 + obj11;
			object obj14 = obj12 + obj13;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			if ((nint)obj15 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				object obj16 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				if ((nint)obj16 >= 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					obj14 = 0;
				}
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)gone))
				{
					object obj17 = obj2 * obj3;
					return (nint)obj17 < 0;
				}
				return true;
			}
			return false;
		}

		internal float _003CWork_003Eg__Over_007C1(Vector3 p)
		{
			//IL_0010: Expected Obj, but got I
			//IL_006c: Expected Obj, but got I4
			//IL_0039: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IntPtr intPtr = default;
			return Into((Vector3)sign, seed, (int)(nint)intPtr);
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public Stopwatch clock;

		public Half half;

		public float lapFrom;

		public Shape s;

		public float fine;

		internal float _003CBowl_003Eg__Lap_007C0(int i)
		{
			//IL_016d: Expected F4, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_004e: Expected Obj, but got I4
			//IL_00eb: Expected Obj, but got I4
			//IL_00fa: Expected Obj, but got I4
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected Obj, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected Obj, but got Unknown
			float num;
			if (clock != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
				object obj = 0;
				TimeSpan elapsed = clock.Elapsed;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				TimeSpan timeSpan = default;
				num = (float)timeSpan.TotalMilliseconds;
				Half half = this.half;
				if (this.half != null)
				{
					float[] laps = half.laps;
					if (half.laps != null)
					{
						bool flag2 = laps.Length < i;
						object obj4 = !flag2;
						object obj5 = laps.Length - i;
						bool flag3 = obj5 == null;
						object obj6 = ~obj4;
						object obj7 = obj6 | flag3;
						if (obj7 != null)
						{
							goto IL_0180;
						}
						object obj8 = half.laps + i;
						float num2 = num - lapFrom;
						lapFrom = num;
						goto IL_01aa;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_0180;
			}
			num = 0f;
			goto IL_01aa;
			IL_0180:
			throw new IndexOutOfRangeException();
			IL_01aa:
			return num;
		}

		internal int _003CBowl_003Eb__1(List<int> a, List<int> b)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num = Area(s, b);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			float value = Area(s, a);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			float num2 = default;
			return num2.CompareTo(value);
		}

		internal bool _003CBowl_003Eb__2(Vector3 a, Vector3 b)
		{
			//IL_0093: Invalid comparison between F4 and I4
			//IL_00a2: Invalid comparison between F4 and I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected Obj, but got Unknown
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected Obj, but got Unknown
			//IL_00f7: Expected Obj, but got I4
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected I4, but got Unknown
			object obj2 = default;
			object obj3 = default;
			object obj = obj2 - obj3;
			object obj5 = default;
			object obj6 = default;
			object obj4 = obj5 - obj6;
			object obj8 = default;
			object obj9 = default;
			object obj7 = obj8 - obj9;
			object obj10 = obj * obj;
			object obj11 = obj4 * obj4;
			object obj12 = obj10 + obj11;
			object obj13 = obj7 * obj7;
			object obj14 = obj13 + obj12;
			float num = fine * fine;
			float num2 = (float)obj14 - num;
			bool flag = num2 < 0f;
			bool flag2 = num2 == 0f;
			object obj15 = obj14 ^ num;
			object obj16 = obj14 ^ num2;
			object obj17 = obj15 & obj16;
			bool flag3 = (nint)obj17 < 0;
			bool flag4 = flag == flag3;
			object obj18 = !flag2;
			return (byte)((flag4 & obj18) ? 1 : 0) != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public Shape s;

		public Dictionary<Vector3Int, List<int>> cells;

		public Dictionary<int, List<int>> onward;

		internal unsafe int _003CLoops_003Eg__Point_007C0(int v)
		{
			//IL_071a: Unknown result type (might be due to invalid IL or missing references)
			//IL_071e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got I
			//IL_005f: Expected I, but got Obj
			//IL_0748: Expected Obj, but got I
			//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fe: Expected Obj, but got Unknown
			//IL_094d: Expected Obj, but got I4
			//IL_00cb: Expected Obj, but got I
			//IL_00db: Expected Obj, but got I
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected Ref, but got Unknown
			//IL_0123: Expected Obj, but got I8
			//IL_012c: Expected Obj, but got I4
			//IL_08dc: Expected Obj, but got I8
			//IL_0896: Unknown result type (might be due to invalid IL or missing references)
			//IL_089e: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a3: Expected Obj, but got Unknown
			//IL_08b0: Expected VT, but got Obj
			//IL_08bd: Expected Obj, but got I8
			//IL_0970: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected Ref, but got Unknown
			//IL_017c: Expected I4, but got VT
			//IL_079c: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a1: Expected Obj, but got Unknown
			//IL_07bb: Expected Obj, but got Ref
			//IL_01a1: Expected Obj, but got Ref
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected I4, but got VT
			//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Expected Obj, but got Unknown
			//IL_03ed: Expected Obj, but got Ref
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d1: Expected I4, but got Obj
			//IL_0404: Unknown result type (might be due to invalid IL or missing references)
			//IL_0409: Expected Obj, but got Unknown
			//IL_0423: Expected Obj, but got Ref
			//IL_0880: Expected Obj, but got I4
			//IL_0891: Expected Obj, but got I4
			//IL_080b: Expected Obj, but got I
			//IL_0813: Expected I4, but got Obj
			//IL_0836: Expected Obj, but got I4
			//IL_083a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0846: Expected Obj, but got Ref
			//IL_0452: Expected Obj, but got Ref
			//IL_0456: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Unknown result type (might be due to invalid IL or missing references)
			//IL_0392: Expected Obj, but got Ref
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_0313: Expected Obj, but got Ref
			//IL_031b: Expected Obj, but got Ref
			//IL_0474: Unknown result type (might be due to invalid IL or missing references)
			//IL_0478: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Expected VT, but got Unknown
			//IL_0487: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Expected Ref, but got Unknown
			//IL_04ae: Expected Obj, but got I4
			//IL_04b6: Expected Obj, but got Ref
			//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04be: Expected I, but got Unknown
			//IL_04c6: Expected I4, but got VT
			//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b8: Expected Obj, but got Ref
			//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Expected I, but got Obj
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Expected Obj, but got Unknown
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Invalid comparison between Unknown and I
			//IL_04e4: Expected Obj, but got I
			//IL_04fe: Expected Obj, but got I
			//IL_0506: Expected I, but got Obj
			//IL_05cf: Expected Obj, but got I
			//IL_05e6: Expected Obj, but got I
			//IL_0606: Unknown result type (might be due to invalid IL or missing references)
			//IL_0532: Expected Obj, but got Ref
			//IL_0536: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ec: Expected Obj, but got I4
			//IL_02fe: Expected Obj, but got I4
			//IL_0641: Expected Obj, but got I4
			//IL_0561: Expected Obj, but got I
			//IL_0573: Unknown result type (might be due to invalid IL or missing references)
			//IL_057c: Expected Obj, but got Unknown
			//IL_0584: Unknown result type (might be due to invalid IL or missing references)
			//IL_058c: Expected I, but got Unknown
			//IL_0594: Expected I4, but got VT
			//IL_066c: Expected Obj, but got I
			//IL_0682: Expected Obj, but got I
			Shape shape = s;
			bool flag = s == null;
			object obj2 = default;
			object obj = obj2;
			object obj4 = default;
			object obj3 = obj4;
			Enumerator<, > val2 = default;
			Enumerator<, > val = val2;
			int num = v;
			object obj5;
			object obj9;
			object obj12;
			object obj13;
			Enumerator<, > val3;
			ref System.__Canon reference;
			int num3;
			Vector3Int vector3Int;
			ref System.__Canon reference2;
			List<int> list2 = default;
			nint num2;
			object obj16;
			List<int> list;
			if (!flag)
			{
				bool flag2 = shape.at == null;
				obj = obj2;
				obj3 = obj4;
				val = val2;
				num = v;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
					obj5 = 0;
					num2 = (nint)obj5;
					Vector3 vector = shape.at.get_Item(v);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v18+E4]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj8 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF8C]");
					obj9 = obj4 / 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v21+E4]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					object obj10 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v24+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C98]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
					obj13 = 0;
					obj = obj2;
					obj3 = obj4;
					val3 = (Enumerator<, >)0;
					reference = ref *(System.__Canon*)val2;
					num3 = 0;
					object obj14 = obj9;
					num = v;
					object obj15 = 4294967295L;
					obj16 = 109891584;
					while (true)
					{
						object obj17 = obj15 + obj14;
						object obj18 = 4294967295L;
						while (true)
						{
							object obj19 = val2 + obj18;
							vector3Int = (Vector3Int)(obj17 | obj19);
							object obj20 = 4294967295L;
							while (true)
							{
								bool flag4 = (object)cells == null;
								val = (Enumerator<, >)(ref reference);
								if (flag4)
								{
									break;
								}
								object obj21 = obj12;
								reference2 = ref *(System.__Canon*)(obj20 + val2);
								bool flag5 = ((Dictionary<Vector3Int, System.__Canon>)(object)cells).TryGetValue(vector3Int, out reference2);
								bool flag6 = !flag5;
								num2 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
								num = (int)vector3Int;
								if (!flag6)
								{
									goto IL_018a;
								}
								obj20++;
								bool flag7 = (nint)obj20 != 2;
								list = (List<int>)(&list2);
								if (flag7)
								{
									continue;
								}
								goto IL_03c5;
							}
							break;
							IL_03c5:
							obj18++;
							bool flag8 = (nint)obj18 != 2;
							list = (List<int>)(&list2);
							if (flag8)
							{
								continue;
							}
							goto IL_03fb;
						}
						break;
						IL_03fb:
						obj15++;
						bool flag9 = (nint)obj15 != 2;
						list = (List<int>)(&list2);
						obj14 = obj9;
						if (flag9)
						{
							continue;
						}
						goto IL_0439;
					}
				}
			}
			goto IL_06ba;
			IL_02e3:
			object obj22 = 0;
			int num4 = 0;
			obj16 = 11;
			goto IL_07fb;
			IL_0379:
			NullReferenceException ex = new NullReferenceException();
			Enumerator<, > val4 = (Enumerator<, >)(ref val3);
			list = (List<int>)(&list2);
			OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
			goto IL_0854;
			IL_06c8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_06d7;
			IL_07fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
			object obj23 = 0;
			num = (int)obj23;
			val3.Dispose();
			bool flag10 = obj22 == null;
			object obj24 = !flag10;
			val4 = (Enumerator<, >)(ref val3);
			list = (List<int>)(&list2);
			NullReferenceException ex3;
			if (obj24 == null)
			{
				val4 = (Enumerator<, >)(ref val3);
				list = (List<int>)(&list2);
				ex3 = (NullReferenceException)(&val3);
				goto IL_06c8;
			}
			goto IL_06d7;
			IL_0439:
			bool flag11 = (object)cells == null;
			list = (List<int>)(&list2);
			val = (Enumerator<, >)(ref reference);
			if (!flag11)
			{
				object obj21 = obj12;
				Vector3Int vector3Int2 = (Vector3Int)(obj9 | val2);
				bool flag12 = ((Dictionary<Vector3Int, System.__Canon>)(object)cells).TryGetValue(vector3Int2, out *(System.__Canon*)val2);
				bool flag13 = !flag12;
				object obj25 = !flag13;
				List<int> list3 = default;
				list = (List<int>)(&list3);
				num2 = (nint)val2;
				num = (int)vector3Int2;
				List<int> list4 = default;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
					object obj27 = 0;
					num2 = (nint)obj27;
					list4._002Ector(1);
					bool flag14 = (object)cells == null;
					list = (List<int>)(&list3);
					val = (Enumerator<, >)(ref reference);
					num = 1;
					if (flag14)
					{
						goto IL_06ba;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CA0]");
					object obj28 = 0;
					obj21 = obj28;
					((Dictionary<Vector3Int, System.__Canon>)(object)cells).set_Item(vector3Int2, (System.__Canon)val2);
					list = list4;
					num2 = (nint)val2;
					num = (int)vector3Int2;
				}
				bool flag15 = list4 == null;
				val = (Enumerator<, >)(ref reference);
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v37 (System.Collections.Generic.List`1<System.Int32>)+10]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v37 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj30 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v37 (System.Collections.Generic.List`1<System.Int32>)+10]");
					bool flag16 = (nint)0 == 0;
					val = (Enumerator<, >)(ref reference);
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v37 (System.Collections.Generic.List`1<System.Int32>)+18]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v31+18]");
						bool flag17 = num5 < 0;
						object obj31 = !flag17;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v37 (System.Collections.Generic.List`1<System.Int32>)+10]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v37 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj32 = num6 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v37 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj33 = (nint)0 + (nint)1;
							return v;
						}
						list4.AddWithResize(v);
						return v;
					}
				}
			}
			goto IL_06ba;
			IL_06d7:
			ex2 = new OutOfMemoryException();
			goto IL_0854;
			IL_018a:
			bool flag18 = list2 == null;
			list = (List<int>)(&list2);
			val = (Enumerator<, >)(ref reference);
			num2 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
			num = (int)vector3Int;
			if (flag18)
			{
				goto IL_06ba;
			}
			Enumerator<, > enumerator = list2.GetEnumerator();
			Enumerator<, > val5 = default;
			val = val5;
			num2 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
			while (true)
			{
				num = (int)obj13;
				if (!val3.MoveNext())
				{
					break;
				}
				Shape shape2 = s;
				if (s == null)
				{
					goto IL_0379;
				}
				if (shape2.at != null)
				{
					num2 = (nint)obj5;
					Vector3 vector2 = shape2.at.get_Item(0);
					object obj34 = val - val2;
					object obj35 = obj3 - obj4;
					obj -= obj2;
					object obj36 = obj34 * obj34;
					object obj37 = obj35 * obj35;
					object obj38 = obj36 + obj37;
					obj3 = obj * obj;
					val = (Enumerator<, >)(obj3 + obj38);
					Enumerator<, > val6 = val;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B018]");
					if ((nint)val6 >= (nint)0)
					{
						continue;
					}
					goto IL_02e3;
				}
				goto IL_039f;
			}
			obj22 = 0;
			num4 = num3;
			obj16 = 8;
			goto IL_07fb;
			IL_06ba:
			ex3 = new NullReferenceException();
			goto IL_06c8;
			IL_0854:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			int result = default;
			return result;
			IL_039f:
			NullReferenceException ex4 = new NullReferenceException();
			val4 = (Enumerator<, >)(ref val3);
			list = (List<int>)(&list2);
			ex2 = (OutOfMemoryException)(object)ex4;
			goto IL_0854;
		}

		internal void _003CLoops_003Eg__TakeEdge_007C1(int a, int b)
		{
			System.__Canon _Canon = ((Dictionary<int, System.__Canon>)(object)onward).get_Item(a);
			bool flag = ((List<int>)(object)_Canon).Remove(b);
			System.__Canon _Canon2 = ((Dictionary<int, System.__Canon>)(object)onward).get_Item(b);
			bool flag2 = ((List<int>)(object)_Canon2).Remove(a);
		}

		internal int _003CLoops_003Eb__2(int x, int y)
		{
			//IL_00ef: Expected I4, but got Obj
			//IL_00a3: Expected Obj, but got I8
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			if (onward != null)
			{
				System.__Canon _Canon = ((Dictionary<int, System.__Canon>)(object)onward).get_Item(x);
				if (_Canon != null && onward != null)
				{
					System.__Canon _Canon2 = ((Dictionary<int, System.__Canon>)(object)onward).get_Item(y);
					if (_Canon2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v7 (System.__Canon)+18]");
						object obj = 0 & 0x80000001L;
						object obj2 = obj - 1;
						bool flag = obj2 == null;
						int value = ((!flag) ? 1 : 0);
						int num = default;
						return num.CompareTo(value);
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass56_0
	{
		public Shape c;
	}

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public GillaWounds.BoneShape s;

		public float gone;

		public float thick;

		public int sign;

		public int seed;

		public Vector4[] holes;

		public Vector4[] axes;

		public Vector4[] sides;

		public int holeCount;

		public Vector3 faceAt;

		public float faceAcross;

		public Along along;

		internal unsafe object _003CBones_003Eb__0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a0: Expected Obj, but got I4
			//IL_006d: Expected F4, but got VT
			//IL_006d: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Along along = default;
			Along along2 = default;
			return Bone(s, gone, thick, sign, seed, holes, axes, sides, holeCount, (Vector3)(&along), (float)faceAt, along2);
		}
	}

	public const int Seeds = default(int);

	public const int SawSeed = default(int);

	public const float SawTear = default(float);

	private const float Band = default(float);

	private const float FineSkin = default(float);

	private const float FineInside = default(float);

	private const float FineInsideSaw = default(float);

	private const float MostOff = default(float);

	public const float Deep = default(float);

	private const float PastFlesh = default(float);

	public static readonly ConcurrentQueue<string> OwnCutTimes;

	private static readonly Dictionary<(string, int, int), Task<Half>> cuts;

	private static Task queue;

	private static readonly ProfilerMarker CutMark;

	private static readonly ProfilerMarker MeshMark;

	private static int made;

	public static int RimGridMisses;

	public static bool Ready
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_009c: Expected Obj, but got I
			//IL_0054: Expected I4, but got Obj
			//IL_003d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
				return ((Task)0).IsCompleted;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private unsafe static Mesh Make(Built b)
	{
		//IL_09c2: Expected Obj, but got I4
		//IL_0acc: Expected Obj, but got I
		//IL_0adc: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I4
		//IL_08c5: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I4
		//IL_0936: Expected Obj, but got I4
		//IL_0984: Expected I4, but got Obj
		//IL_01e7: Expected Obj, but got I4
		//IL_07ba: Expected Obj, but got Ref
		//IL_0237: Expected Obj, but got I4
		//IL_0804: Expected Obj, but got I4
		//IL_0287: Expected Obj, but got I4
		//IL_07e0: Expected I, but got Obj
		//IL_02d7: Expected Obj, but got I4
		//IL_082c: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got I4
		//IL_044c: Expected Obj, but got I4
		//IL_0455: Expected Obj, but got I4
		//IL_038d: Expected Obj, but got I4
		//IL_04b3: Expected Obj, but got I4
		//IL_0a09: Expected Obj, but got I4
		//IL_079b: Expected Obj, but got I4
		//IL_0504: Expected Obj, but got I4
		//IL_0605: Invalid comparison between F4 and I4
		//IL_0858: Expected Obj, but got I4
		//IL_087f: Expected Obj, but got I4
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0538: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I4
		//IL_057b: Expected Obj, but got I4
		//IL_058c: Expected Obj, but got I4
		//IL_0640: Expected Obj, but got I4
		//IL_0649: Expected Obj, but got I4
		//IL_066e: Expected Obj, but got I4
		//IL_06a1: Expected Obj, but got I8
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected Obj, but got Unknown
		//IL_06cd: Expected Obj, but got I4
		//IL_0a5b: Expected Obj, but got I4
		//IL_06e2: Expected F4, but got I
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected Obj, but got Unknown
		//IL_06fe: Unsupported input type for neg.
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected Obj, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_0748: Expected Obj, but got I4
		//IL_0758: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		int num = 0;
		int value = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Int32)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value = ((int*)num)->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Int32)+A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+20]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Mesh mesh = default;
		mesh._002Ector();
		bool flag2 = b == null;
		object obj4 = 0;
		OutOfMemoryException ex = null;
		Vector3[] array = null;
		if (flag2)
		{
			goto IL_08a6;
		}
		bool flag3 = (object)mesh == null;
		obj4 = 0;
		ex = null;
		array = null;
		if (flag3)
		{
			goto IL_08b4;
		}
		mesh.name = b.name;
		List<Vector3> at = b.at;
		bool flag4 = b.at == null;
		List<Vector3> list = null;
		obj4 = 0;
		ex = null;
		array = (Vector3[])(object)b.at;
		if (flag4)
		{
			goto IL_08ca;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X1_v15 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
		if ((nint)0 >= (nint)65001)
		{
			mesh.indexFormat = (IndexFormat)1;
			at = b.at;
		}
		mesh.SetVertices(at);
		if (b.normals != null)
		{
			mesh.SetNormals(b.normals);
		}
		mesh.SetUVs(0, b.uv);
		bool flag5 = (object)b.second == null;
		object obj5 = 0;
		int num2 = 0;
		if (!flag5)
		{
			mesh.SetUVs(1, b.second);
			obj5 = 0;
			num2 = 1;
		}
		if ((object)b.secondShort != null)
		{
			mesh.SetUVs(1, b.secondShort);
			obj5 = 0;
			num2 = 1;
		}
		if (b.third != null)
		{
			mesh.SetUVs(2, b.third);
			obj5 = 0;
			num2 = 2;
		}
		if ((object)b.thirdShort != null)
		{
			mesh.SetUVs(2, b.thirdShort);
			obj5 = 0;
			num2 = 2;
		}
		list = b.fourth;
		if (b.fourth != null)
		{
			mesh.SetUVs(3, b.fourth);
			obj5 = 0;
			num2 = 3;
		}
		if (~(b.workOutNormals ? 1u : 0u) == 0)
		{
			int value2 = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v66 (System.Int32)+E4]");
			bool flag6 = (nint)0 == 0;
			object obj6 = !flag6;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			FleshChannels(mesh);
		}
		bool flag7 = b.weights == null;
		Matrix4x4[] array2 = (Matrix4x4[])(object)b.weights;
		if (!flag7)
		{
			mesh.boneWeights = b.weights;
			array2 = b.binds;
			mesh.bindposes = b.binds;
			list = null;
		}
		List<int>[] tris = b.tris;
		bool flag8 = b.tris == null;
		object obj7 = 65001;
		obj4 = 0;
		ex = null;
		array = (Vector3[])(object)array2;
		int num3;
		object obj8;
		int num5;
		int num4 = default;
		Vector3[] normals;
		if (!flag8)
		{
			num3 = tris.Length;
			mesh.subMeshCount = tris.Length;
			List<int>[] tris2 = b.tris;
			bool flag9 = b.tris == null;
			obj7 = 65001;
			num4 = 0;
			if (flag9)
			{
				goto IL_05ba;
			}
			obj8 = obj5;
			num5 = 0;
			int num6 = 0;
			while (true)
			{
				obj7 = tris2.Length;
				bool flag10 = num6 >= tris2.Length;
				obj5 = obj8;
				num4 = num5;
				num = num6;
				if (flag10)
				{
					break;
				}
				bool flag11 = num6 < tris2.Length;
				object obj9 = !flag11;
				if (obj9 == null)
				{
					object obj10 = tris2 + num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v34+20]");
					mesh.SetTriangles((List<int>)0, num6);
					tris2 = b.tris;
					num = num6 + 1;
					bool flag12 = b.tris == null;
					object obj11 = !flag12;
					obj5 = 0;
					num4 = num6;
					obj8 = 0;
					num5 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v34+20]");
					num3 = 0;
					num6 = num;
					if (obj11 != null)
					{
						continue;
					}
					goto IL_05ba;
				}
				goto IL_0847;
			}
			if (~(b.workOutNormals ? 1u : 0u) == 0)
			{
				mesh.RecalculateNormals();
				float flipNormals = b.flipNormals;
				if (b.flipNormals < 0f)
				{
					normals = mesh.normals;
					bool flag13 = normals == null;
					list = (List<Vector3>)num4;
					obj4 = 0;
					ex = null;
					array = normals;
					if (!flag13)
					{
						obj7 = normals.Length;
						if (normals.Length < 1)
						{
							goto IL_076e;
						}
						object obj12 = normals.Length & 0xFFFFFFFFL;
						object obj13 = normals + 40;
						object obj15 = default;
						object obj14 = obj15;
						float num7 = b.flipNormals;
						object obj16 = 0;
						while (true)
						{
							bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
							object obj17 = !flag14;
							obj15 = obj14;
							flipNormals = num7;
							obj8 = obj5;
							obj7 = obj13;
							num5 = num4;
							array = normals;
							if (obj17 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X9_v16-8]");
							flipNormals = 0f;
							obj16++;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							obj15 = 0 - obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X9_v16-8]");
							_ = 0;
							obj13 = obj15;
							obj7 = obj13 + 12;
							bool flag15 = (nint)obj16 < normals.Length;
							obj14 = obj15;
							obj12 = normals.Length;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X9_v16-8]");
							num7 = 0f;
							obj13 = obj7;
							if (flag15)
							{
								continue;
							}
							goto IL_076e;
						}
						goto IL_085d;
					}
					goto IL_08e6;
				}
			}
			goto IL_0789;
		}
		goto IL_08d8;
		IL_0789:
		mesh.RecalculateBounds();
		obj4 = 0;
		ex = null;
		array = null;
		Mesh result = mesh;
		goto IL_07b2;
		IL_0847:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		array = (Vector3[])num3;
		goto IL_085d;
		IL_085d:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		obj5 = obj8;
		num4 = num5;
		obj4 = 0;
		ex = null;
		goto IL_0889;
		IL_0889:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		goto IL_0897;
		IL_08a6:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_08b4;
		IL_0897:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_08a6;
		IL_08ca:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_08d8;
		IL_08e6:
		NullReferenceException ex7 = new NullReferenceException();
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj4 = 1;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				Mesh result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj18 = default;
			ex = (OutOfMemoryException)obj18;
		}
		num4 = (int)list;
		result = null;
		goto IL_07b2;
		IL_08b4:
		NullReferenceException ex8 = new NullReferenceException();
		list = (List<Vector3>)num4;
		goto IL_08ca;
		IL_05ba:
		throw new NullReferenceException();
		IL_076e:
		mesh.normals = normals;
		num4 = 0;
		goto IL_0789;
		IL_07b2:
		object obj20 = default;
		object obj19 = (object)(&obj20);
		if (obj19 != null)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj19);
			array = null;
		}
		bool flag16 = ex == null;
		object obj21 = !flag16;
		if (obj21 != null)
		{
			goto IL_0889;
		}
		bool flag17 = obj4 == null;
		object obj22 = !flag17;
		ex4 = ex;
		if (obj22 == null)
		{
			return result;
		}
		goto IL_0897;
		IL_08d8:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_08e6;
	}

	public static void FleshChannels(Mesh m)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01bd: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = m == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			int vertexCount = m.vertexCount;
			bool flag4 = m.HasVertexAttribute((VertexAttribute)8);
			bool flag5 = !flag4;
			object obj5 = !flag5;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6788]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				List<Vector2> list = default;
				IEnumerable<Vector2> collection = default;
				list._002Ector(collection);
				m.SetUVs(4, list);
			}
			if (!m.HasVertexAttribute((VertexAttribute)9))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				List<Vector3> list2 = default;
				IEnumerable<Vector3> collection2 = default;
				list2._002Ector(collection2);
				m.SetUVs(5, list2);
			}
		}
	}

	public static bool DrawsFlesh(Material[] mats)
	{
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I8
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I4
		//IL_02b2: Expected I4, but got Obj
		//IL_009e: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_024e: Expected Obj, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I4
		//IL_01a8: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_0236: Expected I, but got Obj
		if (mats != null && mats.Length >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6790]");
			object obj2 = 0;
			object obj3 = mats.Length & 0xFFFFFFFFL;
			object obj4 = mats + 32;
			object obj5 = 0;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
				object obj6 = !flag;
				if (obj6 == null)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v9+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X25_v4+v127 @ X22_v5*8]");
					bool flag3 = (UnityEngine.Object)0 != null;
					bool flag4 = !flag3;
					object obj9 = 0;
					nint num = unchecked((nint)null);
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X25_v4+v127 @ X22_v5*8]");
						if ((nint)0 == 0)
						{
							goto IL_02a4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X25_v4+v127 @ X22_v5*8]");
						Shader shader = ((Material)0).shader;
						object obj10 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v12+E4]");
						bool flag5 = (nint)0 == 0;
						object obj11 = !flag5;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag6 = shader != null;
						bool flag7 = !flag6;
						obj9 = 0;
						num = unchecked((nint)null);
						if (!flag7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X25_v4+v127 @ X22_v5*8]");
							Shader shader2 = ((Material)0).shader;
							if ((object)shader2 == null)
							{
								goto IL_02a4;
							}
							string name = shader2.name;
							bool flag8 = name == (string)obj2;
							bool flag9 = !flag8;
							object obj12 = !flag9;
							obj9 = 0;
							num = (nint)obj2;
							if (obj12 != null)
							{
								return true;
							}
						}
					}
					obj3 = mats.Length;
					obj5++;
					if ((nint)obj5 >= mats.Length)
					{
						break;
					}
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				goto IL_02a4;
				IL_02a4:
				NullReferenceException ex2 = new NullReferenceException();
				return (byte)(int)ex2 != 0;
			}
		}
		return false;
	}

	private static Source Read(Mesh m)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_01a8: Expected Obj, but got I4
		//IL_01e8: Expected Obj, but got I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6798]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		string name = m.name;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67A0]");
		object obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Vector3[] vertices = m.vertices;
		object obj5 = obj2 + 24;
		obj5 = vertices;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Vector3[] normals = m.normals;
		object obj6 = obj2 + 32;
		obj6 = normals;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Vector2[] uv = m.uv;
		object obj7 = obj2 + 40;
		obj7 = uv;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		BoneWeight[] boneWeights = m.boneWeights;
		object obj8 = obj2 + 48;
		obj8 = boneWeights;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Matrix4x4[] bindposes = m.bindposes;
		object obj9 = obj2 + 56;
		obj9 = bindposes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int subMeshCount = m.subMeshCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = obj2 + 64;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = obj10;
		object obj13 = 32;
		int num = 0;
		while (true)
		{
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X23_v5+18]");
			if ((nint)num2 < (nint)0)
			{
				int[] triangles = m.GetTriangles(num);
				int num3 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X23_v5+18]");
				bool flag = (nint)num3 < (nint)0;
				object obj14 = !flag;
				if (obj14 != null)
				{
					break;
				}
				object obj15 = obj12 + num;
				object obj16 = obj12 + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj12 = obj10;
				num++;
				obj13 += 8;
				bool flag2 = obj10 == null;
				object obj17 = !flag2;
				if (obj17 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return (Source)obj2;
		}
		return (Source)(object)new IndexOutOfRangeException();
	}

	private unsafe static Task<T> Next<T>(Func<T> work)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj = default;
		((_003C_003Ec__DisplayClass23_0<T>)obj)._002Ector();
		if (obj != null)
		{
			object obj2 = obj + 16;
			obj2 = work;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v10+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Func<System.__Canon, System.__Canon> func = default;
			func._002Ector(obj, (IntPtr)(nint)__ldftn(_003C_003Ec__DisplayClass23_0<T>._003CNext_003Eb__0));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0B8]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v17+A0]");
				object scheduler = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+10]");
				Task<T> task = ((Task)0).ContinueWith((Func<Task, T>)(object)func, (TaskScheduler)scheduler);
				object obj12 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v13+A0]");
				Task task2 = (Task)((nint)0 + (nint)16);
				task2 = task;
				Task<T> task3 = task2.ContinueWith((Func<Task, T>)(object)task, (TaskScheduler)scheduler);
				return task;
			}
		}
		return (Task<T>)(object)new NullReferenceException();
	}

	public static void Prepare(Dismemberment body)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0faf: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I4
		//IL_03ec: Expected Obj, but got I4
		//IL_042f: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I4
		//IL_0bbb: Expected Obj, but got I
		//IL_0bcb: Expected Obj, but got I
		//IL_0bff: Expected Obj, but got I4
		//IL_0fd6: Expected Obj, but got I4
		//IL_0484: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_0c74: Expected Obj, but got I
		//IL_04b2: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I4
		//IL_0376: Expected Obj, but got I
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_0ca9: Expected Obj, but got I
		//IL_04d0: Expected Obj, but got I
		//IL_04e0: Expected Obj, but got I
		//IL_04f0: Expected Obj, but got I
		//IL_0500: Expected Obj, but got I
		//IL_051a: Expected Obj, but got I8
		//IL_0523: Expected Obj, but got I4
		//IL_052c: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I
		//IL_106a: Expected Obj, but got I4
		//IL_0ce4: Expected Obj, but got I
		//IL_0cf4: Expected Obj, but got I
		//IL_0cfd: Expected Obj, but got I4
		//IL_0d06: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_1091: Expected Obj, but got I4
		//IL_0553: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I
		//IL_032e: Expected Obj, but got I4
		//IL_0286: Expected Obj, but got I
		//IL_0d20: Expected Obj, but got I
		//IL_100e: Expected Obj, but got I4
		//IL_05a2: Expected Obj, but got I4
		//IL_0693: Expected Obj, but got I4
		//IL_069c: Expected Obj, but got I4
		//IL_05d1: Expected Obj, but got I
		//IL_05ed: Expected Obj, but got I4
		//IL_02d0: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I4
		//IL_0d6f: Expected Obj, but got I4
		//IL_0b71: Expected Obj, but got I
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected Obj, but got Unknown
		//IL_0d9e: Expected Obj, but got I
		//IL_0dba: Expected Obj, but got I4
		//IL_0f3d: Expected Obj, but got I
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Expected Obj, but got Unknown
		//IL_0df7: Expected Obj, but got I4
		//IL_06dc: Expected Obj, but got I
		//IL_06fc: Expected Obj, but got I4
		//IL_0645: Expected Obj, but got I4
		//IL_0e31: Expected Obj, but got I
		//IL_0e31: Expected Obj, but got I
		//IL_0e4d: Expected Obj, but got I4
		//IL_0e5d: Expected Obj, but got I
		//IL_0730: Expected Obj, but got I4
		//IL_0e81: Expected Obj, but got I
		//IL_0e99: Expected Obj, but got I4
		//IL_0ea9: Expected Obj, but got I
		//IL_074c: Expected Obj, but got I4
		//IL_0755: Expected Obj, but got I4
		//IL_0ee1: Expected Obj, but got I4
		//IL_1025: Unknown result type (might be due to invalid IL or missing references)
		//IL_102a: Expected Obj, but got Unknown
		//IL_0f0f: Expected Obj, but got I
		//IL_0f18: Expected Obj, but got I4
		//IL_0f28: Expected Obj, but got I
		//IL_076f: Expected Obj, but got I
		//IL_07dc: Expected Obj, but got I4
		//IL_0814: Expected Obj, but got I4
		//IL_0843: Expected Obj, but got I
		//IL_085f: Expected Obj, but got I4
		//IL_0b1e: Expected Obj, but got I
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected Obj, but got Unknown
		//IL_0b4e: Expected Obj, but got I4
		//IL_08a8: Expected Obj, but got I
		//IL_08c4: Expected Obj, but got I4
		//IL_08e7: Expected Obj, but got I
		//IL_092d: Expected Obj, but got I4
		//IL_095b: Expected Obj, but got I4
		//IL_0983: Expected Obj, but got I
		//IL_09a1: Expected Obj, but got I4
		//IL_09aa: Expected Obj, but got I4
		//IL_0acb: Expected Obj, but got I4
		//IL_0af9: Expected Obj, but got I
		//IL_09d0: Expected Obj, but got I
		//IL_0a16: Expected Obj, but got I4
		//IL_0a5e: Expected Obj, but got I
		//IL_0a7a: Expected Obj, but got I4
		//IL_0a8b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = body == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		if ((object)body != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			object obj7 = default;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v12+18]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v12+18]");
				bool flag4 = (nint)0 < (nint)1;
				UnityEngine.Object obj9 = (UnityEngine.Object)1;
				if (flag4)
				{
					goto IL_03b8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67B0]");
				object value = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4900]");
				object obj11 = 0;
				object obj12 = 0;
				object obj13 = obj5;
				while (true)
				{
					bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
					object obj14 = !flag5;
					if (obj14 != null)
					{
						break;
					}
					object obj15 = obj7 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v43+20]");
					Mesh sharedMesh;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v43+20]");
						sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
						object obj16 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v44+E4]");
						bool flag6 = (nint)0 == 0;
						object obj17 = !flag6;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag7 = sharedMesh != null;
						bool flag8 = !flag7;
						obj6 = 0;
						obj9 = null;
						if (!flag8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v43+20]");
							string name = ((UnityEngine.Object)0).name;
							if (name == null)
							{
								goto IL_0f70;
							}
							bool flag9 = name.EndsWith((string)value);
							bool flag10 = !flag9;
							object obj18 = !flag10;
							object obj19 = 0;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v43+20]");
								string name2 = ((UnityEngine.Object)0).name;
								if (name2 == null)
								{
									goto IL_0f70;
								}
								bool flag11 = name2.EndsWith((string)obj11);
								bool flag12 = !flag11;
								obj19 = 0;
								obj6 = 0;
								obj9 = (UnityEngine.Object)obj11;
								if (flag12)
								{
									goto IL_0366;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v43+20]");
							Mesh sharedMesh2 = ((SkinnedMeshRenderer)0).sharedMesh;
							object obj20 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v47+E4]");
							bool flag13 = (nint)0 == 0;
							object obj21 = !flag13;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							PrepareMesh(sharedMesh2);
							obj6 = obj19;
							obj9 = null;
						}
						goto IL_0366;
					}
					goto IL_0f70;
					IL_0366:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v12+18]");
					obj8 = 0;
					obj12++;
					object obj22 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v12+18]");
					bool flag14 = (nint)obj22 < 0;
					Mesh mesh = sharedMesh;
					obj13 = obj6;
					if (flag14)
					{
						continue;
					}
					goto IL_03b8;
				}
				goto IL_0f7e;
			}
		}
		goto IL_0f70;
		IL_0bab:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v15+E4]");
		bool flag15 = (nint)0 == 0;
		object obj26 = !flag15;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj27 = default;
		if (!(obj27 != null))
		{
			return;
		}
		if ((object)obj27 == null)
		{
			goto IL_0f70;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v21 (UnityEngine.Object)+28]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v21 (UnityEngine.Object)+28]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X23_v7+18]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X23_v7+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v21 (UnityEngine.Object)+28]");
		object obj30 = (nint)0 + (nint)32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj31 = 0;
		object obj32 = 0;
		object obj33 = 0;
		UnityEngine.Object obj34 = null;
		while (true)
		{
			bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
			object obj35 = !flag16;
			if (obj35 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v7+v235 @ X24_v8*8]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v7+v235 @ X24_v8*8]");
			if ((nint)0 != 0)
			{
				object obj37 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v26+E4]");
				bool flag17 = (nint)0 == 0;
				object obj38 = !flag17;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X27_v7+20]");
				bool flag18 = (UnityEngine.Object)0 != null;
				bool flag19 = !flag18;
				obj33 = 0;
				obj34 = null;
				if (!flag19)
				{
					object obj39 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v31+E4]");
					bool flag20 = (nint)0 == 0;
					object obj40 = !flag20;
					if (obj40 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X27_v7+28]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v21 (UnityEngine.Object)+20]");
					bool flag21 = (UnityEngine.Object)num == (UnityEngine.Object)0;
					bool flag22 = !flag21;
					obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v21 (UnityEngine.Object)+20]");
					obj34 = (UnityEngine.Object)0;
					if (!flag22)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X27_v7+18]");
						object obj41 = (nint)0 & (nint)0xFE;
						bool flag23 = (nint)obj41 == 2;
						obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v21 (UnityEngine.Object)+20]");
						obj34 = (UnityEngine.Object)0;
						if (!flag23)
						{
							object obj42 = obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v35+E4]");
							bool flag24 = (nint)0 == 0;
							object obj43 = !flag24;
							if (obj43 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X27_v7+20]");
							PrepareShape((Mesh)0);
							obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v21 (UnityEngine.Object)+20]");
							obj34 = (UnityEngine.Object)0;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X23_v7+18]");
				obj29 = 0;
				obj32++;
				object obj44 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X23_v7+18]");
				if ((nint)obj44 >= 0)
				{
					return;
				}
				continue;
			}
			goto IL_0f70;
		}
		goto IL_0f7e;
		IL_0f7e:
		throw new IndexOutOfRangeException();
		IL_03b8:
		CosmeticCatalog cosmeticCatalog = CosmeticCatalog.Get();
		object obj45 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v11+E4]");
		bool flag25 = (nint)0 == 0;
		object obj46 = !flag25;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag26 = cosmeticCatalog != null;
		bool flag27 = !flag26;
		object obj47 = 0;
		if (!flag27)
		{
			if ((object)cosmeticCatalog == null)
			{
				goto IL_0f70;
			}
			Mesh mesh = (Mesh)(object)cosmeticCatalog.cosmetics;
			bool flag28 = cosmeticCatalog.cosmetics == null;
			obj47 = 0;
			if (!flag28)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X21_v8 (UnityEngine.Mesh)+18]");
				bool flag29 = (nint)0 < (nint)1;
				obj47 = 0;
				if (!flag29)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67B0]");
					object obj48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4900]");
					object obj50 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67A8]");
					object obj51 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X21_v8 (UnityEngine.Mesh)+18]");
					object obj52 = 0 & 0xFFFFFFFFL;
					object obj53 = 0;
					object obj54 = 0;
					UnityEngine.Object obj55 = null;
					UnityEngine.Object obj62 = default;
					while (true)
					{
						bool flag30 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj53) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj52);
						object obj56 = !flag30;
						if (obj56 != null)
						{
							break;
						}
						object obj57 = (object)mesh + obj53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v28+20]");
						object obj58 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v28+20]");
						UnityEngine.Object obj61;
						if ((nint)0 != 0)
						{
							object obj59 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X0_v69+E4]");
							bool flag31 = (nint)0 == 0;
							object obj60 = !flag31;
							if (obj60 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X20_v14+28]");
							bool flag32 = (UnityEngine.Object)0 != null;
							bool flag33 = !flag32;
							obj54 = 0;
							obj55 = null;
							obj61 = null;
							if (!flag33)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X20_v14+28]");
								if ((nint)0 == 0)
								{
									goto IL_0f70;
								}
								obj54 = obj51;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626234");
								obj55 = (UnityEngine.Object)1;
								obj61 = obj62;
							}
						}
						else
						{
							obj61 = null;
						}
						object obj63 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v45+E4]");
						bool flag34 = (nint)0 == 0;
						object obj64 = !flag34;
						if (obj64 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag35 = obj61 == null;
						bool flag36 = !flag35;
						object obj65 = !flag36;
						obj47 = 0;
						obj55 = null;
						if (obj65 == null)
						{
							if ((object)obj61 == null)
							{
								goto IL_0f70;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X19_v11 (UnityEngine.Object)+48]");
							object obj66 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X19_v11 (UnityEngine.Object)+48]");
							bool flag37 = (nint)0 == 0;
							obj47 = 0;
							obj55 = null;
							if (!flag37)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X19_v11 (UnityEngine.Object)+50]");
								bool flag38 = (nint)0 == 0;
								obj47 = 0;
								obj55 = null;
								if (!flag38)
								{
									object obj67 = 4;
									obj47 = 0;
									obj55 = null;
									while (true)
									{
										object obj68 = obj67 - 4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v34+18]");
										if ((nint)obj68 >= 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X19_v11 (UnityEngine.Object)+50]");
										object obj69 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X19_v11 (UnityEngine.Object)+50]");
										object obj76;
										UnityEngine.Object obj77;
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X10_v8+18]");
											if ((nint)obj68 >= 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v34+18]");
											bool flag39 = (nint)obj68 < 0;
											object obj70 = !flag39;
											if (obj70 != null)
											{
												goto end_IL_1051;
											}
											object obj71 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v51+E4]");
											bool flag40 = (nint)0 == 0;
											object obj72 = !flag40;
											if (obj72 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v34+v546 @ X28_v7*8]");
											bool flag41 = (UnityEngine.Object)0 != null;
											bool flag42 = !flag41;
											obj47 = 0;
											obj55 = null;
											if (flag42)
											{
												goto IL_0b0e;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v34+v546 @ X28_v7*8]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v34+v546 @ X28_v7*8]");
												bool isReadable = ((Mesh)0).isReadable;
												bool flag43 = !isReadable;
												obj47 = 0;
												obj55 = null;
												if (flag43)
												{
													goto IL_0b0e;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X19_v11 (UnityEngine.Object)+50]");
												object obj73 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X19_v11 (UnityEngine.Object)+50]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v37+18]");
													bool flag44 = (nint)obj68 < 0;
													object obj74 = !flag44;
													if (obj74 != null)
													{
														goto end_IL_1051;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v37+v546 @ X28_v7*8]");
													bool flag45 = (nint)0 == 0;
													obj47 = 0;
													obj55 = null;
													if (flag45)
													{
														goto IL_0b0e;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v37+v546 @ X28_v7*8]");
													bool flag46 = ((string)0).EndsWith((string)obj48);
													bool flag47 = !flag46;
													object obj75 = !flag47;
													obj76 = 0;
													obj77 = (UnityEngine.Object)obj48;
													if (obj75 != null)
													{
														goto IL_0aa1;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X19_v11 (UnityEngine.Object)+50]");
													object obj78 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X19_v11 (UnityEngine.Object)+50]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v40+18]");
														bool flag48 = (nint)obj68 < 0;
														object obj79 = !flag48;
														if (obj79 != null)
														{
															goto end_IL_1051;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v40+v546 @ X28_v7*8]");
														if ((nint)0 != 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v40+v546 @ X28_v7*8]");
															bool flag49 = ((string)0).EndsWith((string)obj50);
															bool flag50 = !flag49;
															obj76 = 0;
															obj77 = (UnityEngine.Object)obj50;
															obj47 = 0;
															obj55 = (UnityEngine.Object)obj50;
															if (!flag50)
															{
																goto IL_0aa1;
															}
															goto IL_0b0e;
														}
													}
												}
											}
										}
										goto IL_0f70;
										IL_0b0e:
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X19_v11 (UnityEngine.Object)+48]");
										obj66 = 0;
										obj67++;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X19_v11 (UnityEngine.Object)+48]");
										bool flag51 = (nint)0 == 0;
										object obj80 = !flag51;
										if (obj80 != null)
										{
											continue;
										}
										goto IL_0f70;
										IL_0aa1:
										object obj81 = obj49;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X0_v61+E4]");
										bool flag52 = (nint)0 == 0;
										object obj82 = !flag52;
										if (obj82 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v34+v546 @ X28_v7*8]");
										PrepareMesh((Mesh)0);
										obj47 = obj76;
										obj55 = obj77;
										goto IL_0b0e;
									}
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X21_v8 (UnityEngine.Mesh)+18]");
						obj52 = 0;
						obj53++;
						object obj83 = obj53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X21_v8 (UnityEngine.Mesh)+18]");
						bool flag53 = (nint)obj83 < 0;
						obj54 = obj47;
						if (flag53)
						{
							continue;
						}
						goto IL_0bab;
						continue;
						end_IL_1051:
						break;
					}
					goto IL_0f7e;
				}
			}
		}
		goto IL_0bab;
		IL_0f70:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0f7e;
	}

	private static void PrepareMesh(Mesh mesh)
	{
		//IL_03da: Expected Obj, but got I
		//IL_03ea: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I
		//IL_0408: Expected VT, but got I4
		//IL_0574: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I8
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_00a8: Expected VT, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I4
		//IL_0426: Expected Obj, but got I
		//IL_0191: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I4
		//IL_045b: Expected Obj, but got I
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_02c4: Expected Obj, but got I4
		//IL_04fa: Expected Obj, but got I
		//IL_051a: Expected Obj, but got I
		//IL_0534: Expected Obj, but got I
		//IL_0545: Expected I, but got Obj
		//IL_0555: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I
		//IL_034c: Expected Obj, but got I
		//IL_035c: Expected Obj, but got I
		//IL_036c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj3 = 0;
		Source source = null;
		(System.__Canon, int, int) tuple = ((System.__Canon, int, int))0;
		int num = 0;
		object obj5 = default;
		object obj12 = default;
		System.__Canon _Canon2 = default;
		object obj14 = default;
		object obj17 = default;
		Func<System.__Canon> func = default;
		object obj34 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			if (obj5 != null)
			{
				_ = 1;
				_ = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v4+18]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v4+18]");
					object obj6 = 0 & 0xFFFFFFFFL;
					object obj7 = obj5 + 32;
					object obj8 = obj2;
					object obj9 = obj3;
					object obj10 = obj;
					Source source2 = source;
					object obj11 = obj12;
					System.__Canon _Canon = _Canon2;
					object obj13 = obj14;
					(System.__Canon, int, int) tuple2 = ((System.__Canon, int, int))2;
					object obj15 = 0;
					while (true)
					{
						bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
						object obj16 = !flag;
						if (obj16 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X29_v4+v187 @ X28_v7*4]");
						int num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						obj17._002Ector();
						if ((object)mesh != null)
						{
							string name = mesh.name;
							obj14 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X29_v4+v187 @ X28_v7*4]");
							tuple = ((System.__Canon)(object)name, 0, num);
							object obj18 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v17+E4]");
							bool flag2 = (nint)0 == 0;
							object obj19 = !flag2;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj18 = obj9;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v17+A0]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v13+8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67B8]");
								object obj21 = 0;
								obj12 = obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v13+8]");
								bool flag3 = ((Dictionary<(System.__Canon, int, int), System.__Canon>)0).ContainsKey(tuple);
								bool flag4 = !flag3;
								object obj22 = !flag4;
								_Canon2 = null;
								tuple2 = tuple;
								if (obj22 != null)
								{
									goto IL_044b;
								}
								bool flag5 = source2 == null;
								object obj23 = !flag5;
								if (obj23 == null)
								{
									object obj24 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v33+E4]");
									bool flag6 = (nint)0 == 0;
									object obj25 = !flag6;
									if (obj25 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Source source3 = Read(mesh);
									source2 = source3;
								}
								if (obj17 != null)
								{
									object obj26 = obj17 + 16;
									obj26 = source2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj27 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v25+E4]");
									bool flag7 = (nint)0 == 0;
									object obj28 = !flag7;
									if (obj28 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj27 = obj9;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v25+A0]");
									object obj29 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20+8]");
									num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67C8]");
									object obj30 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67D8]");
									object obj31 = 0;
									func._002Ector(obj17, (IntPtr)obj31);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67D0]");
									object obj32 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3627648");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20+8]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67C0]");
										object obj33 = 0;
										obj14 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20+8]");
										((Dictionary<(System.__Canon, int, int), System.__Canon>)0).set_Item(tuple, (System.__Canon)null);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67E0]");
										obj10 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67E8]");
										obj8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
										obj9 = 0;
										obj12 = obj34;
										_Canon2 = null;
										tuple2 = tuple;
										goto IL_044b;
									}
								}
							}
						}
						goto IL_03b5;
						IL_044b:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v4+18]");
						obj6 = 0;
						object obj35 = obj15 + 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v4+18]");
						bool flag8 = (nint)obj35 < 0;
						obj2 = obj8;
						obj3 = obj9;
						obj = obj10;
						source = source2;
						obj11 = obj12;
						_Canon = _Canon2;
						obj13 = obj14;
						obj15 = obj35;
						if (flag8)
						{
							continue;
						}
						goto IL_0386;
					}
					break;
				}
				goto IL_0386;
			}
			goto IL_03b5;
			IL_03b5:
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0386:
			num++;
			if (num == 3)
			{
				return;
			}
		}
		throw new IndexOutOfRangeException();
	}

	public unsafe static int PickSeed()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_04e5: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I
		//IL_0506: Expected Obj, but got I
		//IL_052f: Expected VT, but got I4
		//IL_05d7: Expected Obj, but got I4
		//IL_0556: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0583: Expected I4, but got Obj
		//IL_0610: Expected I4, but got Obj
		//IL_0636: Expected VT, but got Ref
		//IL_039e: Expected VT, but got Ref
		//IL_00c6: Expected I4, but got I8
		//IL_00de: Expected Obj, but got I4
		//IL_03d1: Expected VT, but got Ref
		//IL_03e3: Expected Obj, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_012c: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6828]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6820]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj6 = obj2;
		List<int> list = default;
		list._002Ector(3);
		Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator enumerator = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)0;
		int num = 3;
		int num2 = 0;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v6+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v5+8]");
		Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator enumerator3 = default;
		Task task = default;
		Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator enumerator4 = default;
		Task task2;
		string text;
		Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator enumerator5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v5+8]");
			Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator enumerator2 = ((Dictionary<(System.__Canon, int, int), System.__Canon>)0).GetEnumerator();
			object obj10 = 1;
			object obj11 = 0;
			object obj12 = default;
			while (true)
			{
				num = (int)obj4;
				if (!enumerator3.MoveNext())
				{
					break;
				}
				if (num2 != (nint)obj12)
				{
					continue;
				}
				if (0 == 0)
				{
					goto IL_0378;
				}
				int num3 = ((string)null).IndexOf('|');
				int num4 = (int)(num3 & 0x80000000L);
				bool flag2 = num4 == 0;
				obj6 = 0;
				if (flag2)
				{
					continue;
				}
				if (task != null)
				{
					bool isCompleted = task.IsCompleted;
					obj10 &= isCompleted;
					obj11 = 1;
					obj6 = 0;
					continue;
				}
				goto IL_03ab;
			}
			num = (int)obj5;
			enumerator3.Dispose();
			task2 = task;
			text = null;
			enumerator = enumerator4;
			enumerator5 = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)(&enumerator3);
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		}
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_05e5;
		IL_05e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DA4C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		int result = default;
		return result;
		IL_0378:
		NullReferenceException ex3 = new NullReferenceException();
		task2 = task;
		text = null;
		enumerator = enumerator4;
		enumerator5 = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)(&enumerator3);
		ex2 = (OutOfMemoryException)(object)ex3;
		goto IL_05e5;
		IL_03ab:
		NullReferenceException ex4 = new NullReferenceException();
		task2 = task;
		text = null;
		enumerator = enumerator4;
		enumerator5 = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)(&enumerator3);
		num = 124;
		obj6 = 0;
		ex2 = (OutOfMemoryException)(object)ex4;
		goto IL_05e5;
	}

	public unsafe static void MakeOneMore()
	{
		//IL_0010: Expected Obj, but got I
		//IL_07da: Expected Obj, but got I4
		//IL_0a6e: Expected Obj, but got I
		//IL_0a98: Expected VT, but got I4
		//IL_0aa1: Expected VT, but got I4
		//IL_06ce: Expected VT, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_07f8: Expected Obj, but got I
		//IL_0822: Expected VT, but got I4
		//IL_082b: Expected VT, but got I4
		//IL_00e1: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_0405: Expected VT, but got I4
		//IL_040e: Expected VT, but got I4
		//IL_041f: Expected Obj, but got I4
		//IL_043f: Expected VT, but got Ref
		//IL_0448: Expected Obj, but got I4
		//IL_0a02: Expected Obj, but got I
		//IL_0a13: Expected Ref, but got VT
		//IL_0a2d: Expected Obj, but got I4
		//IL_068e: Expected VT, but got I4
		//IL_069f: Expected Obj, but got I4
		//IL_06bf: Expected VT, but got Ref
		//IL_0456: Invalid comparison between VT and I4
		//IL_0467: Expected Obj, but got I4
		//IL_046f: Expected Obj, but got VT
		//IL_0168: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I4
		//IL_087b: Expected Obj, but got I
		//IL_088b: Expected Obj, but got I
		//IL_08bf: Expected Obj, but got I
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected Obj, but got Unknown
		//IL_08fc: Expected Obj, but got I4
		//IL_0754: Expected VT, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01e8: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I4
		//IL_0941: Expected Obj, but got I
		//IL_0957: Expected Obj, but got I
		//IL_0971: Expected Obj, but got I4
		//IL_0497: Expected VT, but got I4
		//IL_04a0: Expected VT, but got I4
		//IL_04b1: Expected Obj, but got I4
		//IL_04d1: Expected VT, but got Ref
		//IL_0265: Expected VT, but got I4
		//IL_026e: Expected VT, but got I4
		//IL_027f: Expected Obj, but got I4
		//IL_029f: Expected VT, but got Ref
		//IL_04fc: Expected Obj, but got I
		//IL_0526: Expected Obj, but got I4
		//IL_056a: Expected VT, but got I4
		//IL_0573: Expected Obj, but got I4
		//IL_02ca: Expected Obj, but got I
		//IL_02f4: Expected Obj, but got I4
		//IL_0657: Expected Obj, but got I4
		//IL_0338: Expected VT, but got I4
		//IL_0341: Expected Obj, but got I4
		//IL_098f: Expected Obj, but got I
		//IL_09a5: Expected Obj, but got I
		//IL_09b3: Expected VT, but got I4
		//IL_09c4: Expected Obj, but got I4
		//IL_09e4: Expected VT, but got Ref
		//IL_09ed: Expected Obj, but got I4
		//IL_05a4: Expected Obj, but got I
		//IL_05ca: Expected Obj, but got I
		//IL_05f4: Expected Obj, but got I4
		//IL_0372: Expected Obj, but got I
		//IL_0623: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I
		//IL_03c2: Expected Obj, but got I4
		//IL_03f1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+8]");
		bool flag2 = (nint)0 == 0;
		(System.__Canon, int, int) tuple2 = default;
		(System.__Canon, int, int) tuple = tuple2;
		Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator enumerator = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)0;
		Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator enumerator2 = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)0;
		(System.__Canon, int, int) tuple3;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6848]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+8]");
			int count = ((Dictionary<(System.__Canon, int, int), System.__Canon>)0).Count;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+28]");
			if ((nint)0 >= (nint)count)
			{
				return;
			}
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v32+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v32+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v17+8]");
			bool flag4 = (nint)0 == 0;
			tuple = tuple2;
			enumerator = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)0;
			enumerator2 = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v17+8]");
				Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator enumerator3 = ((Dictionary<(System.__Canon, int, int), System.__Canon>)0).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6828]");
				object obj10 = 0;
				Task task = default;
				Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator enumerator4 = default;
				object obj47 = default;
				object obj26;
				Task task2;
				(System.__Canon, int, int) tuple4;
				Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator enumerator5;
				while (true)
				{
					obj6 = obj10;
					object obj46;
					if (enumerator.MoveNext())
					{
						if (task == null)
						{
							break;
						}
						if (!task.IsCompleted)
						{
							continue;
						}
						bool isFaulted = task.IsFaulted;
						bool flag5 = !isFaulted;
						object obj11 = !flag5;
						if (obj11 != null)
						{
							continue;
						}
						object obj12 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v44+E4]");
						bool flag6 = (nint)0 == 0;
						object obj13 = !flag6;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj12 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v44+A0]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v24+28]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v24+28]");
						bool flag7 = (nint)0 < (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v24+28]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v24+28]");
						object obj16 = num ^ 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v24+28]");
						object obj17 = 0 & obj16;
						bool flag8 = (nint)obj17 < 0;
						bool flag9 = flag7 == flag8;
						object obj18 = !flag9;
						object obj19 = ~obj18;
						if (obj19 == null)
						{
							obj15++;
						}
						if (0 < (nint)obj15)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6850]");
						object obj20 = 0;
						obj6 = obj20;
						System.__Canon result = ((Task<System.__Canon>)task).Result;
						object obj21 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v48+E4]");
						bool flag10 = (nint)0 == 0;
						object obj22 = !flag10;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj21 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v48+A0]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v30+28]");
						object obj24 = (nint)0 & (nint)1;
						bool flag11 = obj24 == null;
						object obj25 = !flag11;
						if (obj25 == null)
						{
							bool flag12 = result == null;
							tuple3 = ((System.__Canon, int, int))0;
							tuple = ((System.__Canon, int, int))0;
							enumerator = enumerator4;
							obj26 = 0;
							task2 = task;
							tuple4 = tuple2;
							enumerator2 = enumerator4;
							enumerator5 = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)(&enumerator);
							if (flag12)
							{
								goto IL_06f6;
							}
							Mesh skin = ((Half)(object)result).skin;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj27 = 0;
							object obj28 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v71+E4]");
							bool flag13 = (nint)0 == 0;
							object obj29 = !flag13;
							if (obj29 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag14 = skin == null;
							bool flag15 = !flag14;
							tuple3 = ((System.__Canon, int, int))0;
							object obj30 = 0;
							UnityEngine.Object obj31 = null;
							if (!flag15)
							{
								string text = tuple3.ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6860]");
								object obj32 = 0;
								string message = (string)obj32 + text;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
								object obj33 = 0;
								object obj34 = obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v79+E4]");
								bool flag16 = (nint)0 == 0;
								object obj35 = !flag16;
								if (obj35 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								UnityEngine.Debug.LogWarning(message);
								obj30 = 0;
								obj31 = null;
							}
						}
						else
						{
							bool flag17 = result == null;
							tuple3 = ((System.__Canon, int, int))0;
							tuple = ((System.__Canon, int, int))0;
							enumerator = enumerator4;
							obj26 = 0;
							task2 = task;
							tuple4 = tuple2;
							enumerator2 = enumerator4;
							enumerator5 = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)(&enumerator);
							if (flag17)
							{
								goto IL_0704;
							}
							Mesh inside = ((Half)(object)result).inside;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj36 = 0;
							object obj37 = obj36;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v56+E4]");
							bool flag18 = (nint)0 == 0;
							object obj38 = !flag18;
							if (obj38 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag19 = inside == null;
							bool flag20 = !flag19;
							tuple3 = ((System.__Canon, int, int))0;
							object obj30 = 0;
							UnityEngine.Object obj31 = null;
							if (!flag20)
							{
								string text2 = tuple3.ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6868]");
								object obj39 = 0;
								string message2 = (string)obj39 + text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
								object obj40 = 0;
								object obj41 = obj40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v64+E4]");
								bool flag21 = (nint)0 == 0;
								object obj42 = !flag21;
								if (obj42 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								UnityEngine.Debug.LogWarning(message2);
								obj30 = 0;
								obj31 = null;
							}
						}
						object obj43 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X0_v51+E4]");
						bool flag22 = (nint)0 == 0;
						object obj44 = !flag22;
						if (obj44 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj43 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X0_v51+A0]");
						object obj45 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v34+28]");
						obj5 = (nint)0 + (nint)1;
						tuple = ((System.__Canon, int, int))0;
						enumerator = enumerator4;
						obj26 = 0;
						task2 = task;
						tuple4 = tuple2;
						enumerator2 = enumerator4;
						enumerator5 = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)(&enumerator);
						obj46 = 0;
					}
					else
					{
						tuple3 = ((System.__Canon, int, int))0;
						tuple = ((System.__Canon, int, int))0;
						enumerator = enumerator4;
						obj26 = 0;
						task2 = task;
						tuple4 = tuple2;
						enumerator2 = enumerator4;
						enumerator5 = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)(&enumerator);
						obj46 = 0;
					}
					goto IL_09f2;
					IL_0704:
					NullReferenceException ex = new NullReferenceException();
					if ((nint)obj6 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						tuple = ((System.__Canon, int, int))1;
						obj46 = obj26;
					}
					else
					{
						if ((nint)obj6 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DA4C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj46 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj26 = obj47;
					}
					goto IL_09f2;
					IL_06f6:
					NullReferenceException ex2 = new NullReferenceException();
					goto IL_0704;
					IL_09f2:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6820]");
					object obj48 = 0;
					obj6 = obj48;
					((Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator*)enumerator5)->Dispose();
					bool flag23 = obj46 == null;
					object obj49 = !flag23;
					if (obj49 == null)
					{
						bool flag24 = tuple == ((System.__Canon, int, int))(object)0;
						object obj50 = !flag24;
						OutOfMemoryException ex3 = (OutOfMemoryException)enumerator5;
						if (obj50 == null)
						{
							return;
						}
					}
					else
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					goto IL_06f6;
				}
				NullReferenceException ex4 = new NullReferenceException();
				tuple = ((System.__Canon, int, int))0;
				enumerator = enumerator4;
				obj26 = 0;
				task2 = task;
				tuple4 = tuple2;
				enumerator2 = enumerator4;
				enumerator5 = (Dictionary<(System.__Canon, int, int), System.__Canon>.Enumerator)(&enumerator);
			}
		}
		tuple3 = ((System.__Canon, int, int))0;
		throw new NullReferenceException();
	}

	private unsafe static void PrepareShape(Mesh m)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Ref, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Ref, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Ref, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Ref, but got Unknown
		//IL_010e: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_014e: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = m;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (GillaWounds.WillShape((Mesh)obj4, out *(Vector3[]*)(obj4 + 8), out *(Vector3[]*)(obj4 + 16), out *(int[]*)(obj4 + 24), out *(Bounds*)(obj4 + 32)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67F8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6808]");
			object obj8 = 0;
			Func<System.__Canon> func = default;
			func._002Ector(obj2, (IntPtr)obj8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6800]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3627648");
		}
	}

	public static float Line(float y, float z, int seed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_00db: Expected VT, but got I4
		//IL_0037: Expected Obj, but got I4
		//IL_012f: Expected VT, but got I4
		//IL_005e: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj = 0;
		object obj2 = obj;
		if (seed == 9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num = GillaWounds.Lumps((Vector3)0);
			float num2 = num + -0.5f;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A884]");
			return num3 * 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num4 = GillaWounds.Lumps((Vector3)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num5 = GillaWounds.Lumps((Vector3)0);
		float num6 = num4 + -0.5f;
		float num7 = num5 + -0.5f;
		float num8 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
		float num9 = num8 * 0f;
		float num10 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AADC]");
		float num11 = num10 * 0f;
		return num9 + num11;
	}

	public static float Into(Vector3 p, int sign, int seed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float y = default;
		float z = default;
		float num = Line(y, z, sign);
		object obj4 = default;
		float num2 = (float)obj4 - num;
		return num2 * (float)p;
	}

	internal unsafe static BoneWeight MixWeights(BoneWeight a, BoneWeight b, float t)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I4
		//IL_0035: Expected VT, but got Ref
		//IL_0035: Expected VT, but got Ref
		//IL_0041: Expected native int or pointer, but got VT
		//IL_004e: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = default;
		float num2 = default;
		BoneWeight result = Mix((BoneWeight)(&num), (BoneWeight)(&num2), t);
		BoneWeight boneWeight = default;
		float weight = default;
		((BoneWeight*)(nint)boneWeight)->m_Weight0 = weight;
		int boneIndex = default;
		((BoneWeight*)(nint)boneWeight)->m_BoneIndex0 = boneIndex;
		return result;
	}

	private unsafe static BoneWeight Mix(BoneWeight a, BoneWeight b, float t)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_0592: Expected Obj, but got Ref
		//IL_05a0: Expected VT, but got Ref
		//IL_05b4: Expected Obj, but got Ref
		//IL_05f8: Expected Obj, but got I4
		//IL_006a: Invalid comparison between F8 and I4
		//IL_007b: Expected Obj, but got I4
		//IL_0084: Invalid comparison between F8 and I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_0635: Expected VT, but got I4
		//IL_0668: Expected VT, but got I4
		//IL_069b: Expected VT, but got I4
		//IL_00bb: Expected VT, but got I4
		//IL_00c8: Expected I4, but got F8
		//IL_0103: Expected VT, but got I4
		//IL_0136: Expected VT, but got I4
		//IL_016e: Expected VT, but got I4
		//IL_01a1: Expected VT, but got I4
		//IL_01a5: Expected VT, but got I4
		//IL_01b3: Invalid comparison between VT and I4
		//IL_0416: Expected native int or pointer, but got VT
		//IL_0428: Expected native int or pointer, but got VT
		//IL_08a4: Expected Obj, but got VT
		//IL_01d0: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I4
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0707: Invalid comparison between Obj and VT
		//IL_0718: Expected Obj, but got I4
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_0295: Invalid comparison between Obj and VT
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02cb: Invalid comparison between VT and I4
		//IL_082b: Expected Obj, but got I4
		//IL_055f: Expected Obj, but got VT
		//IL_02f9: Expected Obj, but got I4
		//IL_0215: Expected F4, but got I
		//IL_0327: Expected Obj, but got I4
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_06ba: Invalid comparison between VT and Obj
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected Obj, but got Unknown
		//IL_074b: Expected Obj, but got I4
		//IL_0754: Expected VT, but got I4
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected VT, but got Unknown
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected Obj, but got Unknown
		//IL_0864: Invalid comparison between Obj and VT
		//IL_0346: Expected Obj, but got I4
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_038a: Invalid comparison between VT and I4
		//IL_0772: Expected F4, but got I4
		//IL_03a6: Expected I4, but got VT
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected I4, but got Unknown
		//IL_03c1: Invalid comparison between VT and I4
		//IL_080c: Expected F4, but got I4
		//IL_0479: Invalid comparison between VT and I4
		//IL_048a: Expected Obj, but got I4
		//IL_0789: Expected F4, but got I4
		//IL_079b: Expected F4, but got I4
		//IL_0796: Expected native int or pointer, but got VT
		//IL_07a3: Expected native int or pointer, but got VT
		//IL_07b0: Expected native int or pointer, but got VT
		//IL_07bd: Expected native int or pointer, but got VT
		//IL_07ca: Expected native int or pointer, but got VT
		//IL_07d7: Expected native int or pointer, but got VT
		//IL_07e4: Expected native int or pointer, but got VT
		//IL_07f1: Expected native int or pointer, but got VT
		//IL_04d1: Invalid comparison between VT and I4
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj3 = 0;
		object obj5 = default;
		object obj4 = (object)(&obj5);
		Span<int> span = (Span<int>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj5, 32));
		_ = 0;
		_ = 0;
		object obj6 = (object)(&obj5);
		int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj5, 32));
		object obj7 = obj3;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num2 = 1.0 - (double)t;
		double num3 = num2 * (double)a.m_Weight0;
		bool flag2 = num3 < 0.0;
		object obj9 = !flag2;
		bool flag3 = num3 == 0.0;
		object obj10 = ~obj9;
		object obj11 = obj10 | flag3;
		if (obj11 == null)
		{
			span = (Span<int>)a.m_BoneIndex0;
			((int*)num)->m_value = (int)num3;
		}
		float how = (float)num2 * a.m_Weight1;
		int num4 = AddBone(span, (Span<float>)8, num, 8, how);
		float how2 = (float)num2 * a.m_Weight2;
		int num5 = AddBone(span, (Span<float>)8, num, 8, how2);
		float how3 = (float)num2 * a.m_Weight3;
		int num6 = AddBone(span, (Span<float>)8, num, 8, how3);
		float how4 = b.m_Weight0 * t;
		int num7 = AddBone(span, (Span<float>)8, num, 8, how4);
		float how5 = b.m_Weight1 * t;
		int num8 = AddBone(span, (Span<float>)8, num, 8, how5);
		float how6 = b.m_Weight2 * t;
		int num9 = AddBone(span, (Span<float>)8, num, 8, how6);
		float num10 = b.m_Weight3 * t;
		BoneWeight boneWeight = (BoneWeight)AddBone(span, (Span<float>)8, num, 8, num10);
		if (boneWeight < (object)1)
		{
			goto IL_03ef;
		}
		object obj12 = 0;
		object obj13 = 1;
		float num12;
		int num11;
		while (true)
		{
			object obj14 = obj12 + 1;
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<BoneWeight, UIntPtr>(ref boneWeight);
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v1 (System.Int32)+v244 @ X10_v5*4]");
				num11 = 0;
				object obj16 = obj13;
				num12 = num10;
				while (true)
				{
					bool flag5 = (nint)obj16 < 8;
					object obj17 = !flag5;
					if (obj17 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v1 (System.Int32)+v377 @ X12_v7*4]");
					num10 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v1 (System.Int32)+v377 @ X12_v7*4]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v1 (System.Int32)+v244 @ X10_v5*4]");
					if (num13 > 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v1 (System.Int32)+v377 @ X12_v7*4]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v1 (System.Int32)+v244 @ X10_v5*4]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v2 (System.Span`1<System.Int32>)+v377 @ X12_v7*4]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v2 (System.Span`1<System.Int32>)+v244 @ X10_v5*4]");
						_ = 0;
					}
					object obj18 = obj16 + 1;
					bool flag6 = boneWeight != (BoneWeight)obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v1 (System.Int32)+v244 @ X10_v5*4]");
					num11 = 0;
					obj16 = obj18;
					num12 = num10;
					if (flag6)
					{
						continue;
					}
					goto IL_027f;
				}
				break;
			}
			goto IL_027f;
			IL_027f:
			obj13++;
			bool flag7 = obj14 != (object)boneWeight;
			obj12 = obj14;
			if (flag7)
			{
				continue;
			}
			goto IL_02b4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-20]");
		bool flag8 = num14 != 0;
		IndexOutOfRangeException ex = (IndexOutOfRangeException)boneWeight;
		if (!flag8)
		{
			ex = new IndexOutOfRangeException();
		}
		goto IL_057b;
		IL_0803:
		float weight = 0f;
		goto IL_0777;
		IL_0777:
		int boneIndex = 0;
		num12 = 0f;
		goto IL_078e;
		IL_03ef:
		num12 = a.m_Weight0;
		num11 = a.m_BoneIndex0;
		BoneWeight boneWeight2 = default;
		((BoneWeight*)(nint)boneWeight2)->m_Weight0 = a.m_Weight0;
		((BoneWeight*)(nint)boneWeight2)->m_BoneIndex0 = a.m_BoneIndex0;
		goto IL_087b;
		IL_02b4:
		object obj19 = boneWeight - 1;
		object obj25;
		int boneIndex2;
		int boneIndex3;
		float weight2;
		int boneIndex4;
		object obj26 = default;
		if (boneWeight >= (object)1)
		{
			bool flag9 = (nint)obj19 < 3;
			object obj20 = !flag9;
			object obj21 = ~obj20;
			object obj22 = ~obj21;
			if (obj22 != null)
			{
				obj19 = 3;
			}
			object obj23 = obj19 << 2;
			object obj24 = obj23 + 4;
			obj25 = 0;
			BoneWeight boneWeight3 = (BoneWeight)0;
			obj25 = obj26;
			boneWeight3 = boneWeight2;
			do
			{
				boneWeight3 = (BoneWeight)(boneWeight3 + 4);
				object obj27 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v1 (System.Int32)+v523 @ X8_v10 (UnityEngine.BoneWeight)]");
				obj25 = obj27 + 0;
			}
			while (obj24 != (object)boneWeight3);
			bool flag10 = (nint)obj25 < 0;
			object obj28 = !flag10;
			bool flag11 = obj25 == null;
			object obj29 = ~obj28;
			object obj30 = obj29 | flag11;
			obj26 = obj25;
			if (obj30 == null)
			{
				if (boneWeight >= (object)1)
				{
					boneIndex2 = (int)span;
					num11 = ((int*)num)->m_value / obj25;
					if (boneWeight != (BoneWeight)(object)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v2 (System.Span`1<System.Int32>)+4]");
						boneIndex3 = 0;
						bool flag12 = boneWeight < (object)3;
						object obj31 = !flag12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v1 (System.Int32)+4]");
						weight2 = 0f / (float)obj25;
						object obj32 = ~obj31;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v2 (System.Span`1<System.Int32>)+8]");
							boneIndex4 = 0;
							bool flag13 = boneWeight == (BoneWeight)(object)3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v1 (System.Int32)+8]");
							weight = 0f / (float)obj25;
							if (flag13)
							{
								goto IL_0777;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v2 (System.Span`1<System.Int32>)+C]");
							boneIndex = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v1 (System.Int32)+C]");
							num12 = 0f / (float)obj25;
							goto IL_078e;
						}
						boneIndex4 = 0;
						goto IL_0803;
					}
					boneIndex4 = 0;
					boneIndex3 = 0;
				}
				else
				{
					num11 = 0;
					boneIndex4 = 0;
					boneIndex2 = 0;
					boneIndex3 = 0;
				}
				weight2 = 0f;
				goto IL_0803;
			}
		}
		goto IL_03ef;
		IL_057b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		BoneWeight result = default;
		return result;
		IL_087b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-20]");
		bool flag14 = num15 != 0;
		ex = (IndexOutOfRangeException)boneWeight;
		if (!flag14)
		{
			return boneWeight;
		}
		goto IL_057b;
		IL_078e:
		((BoneWeight*)(nint)boneWeight2)->m_Weight0 = num11;
		((BoneWeight*)(nint)boneWeight2)->m_Weight1 = weight2;
		((BoneWeight*)(nint)boneWeight2)->m_Weight2 = weight;
		((BoneWeight*)(nint)boneWeight2)->m_Weight3 = num12;
		((BoneWeight*)(nint)boneWeight2)->m_BoneIndex0 = boneIndex2;
		((BoneWeight*)(nint)boneWeight2)->m_BoneIndex1 = boneIndex3;
		((BoneWeight*)(nint)boneWeight2)->m_BoneIndex2 = boneIndex4;
		((BoneWeight*)(nint)boneWeight2)->m_BoneIndex3 = boneIndex;
		obj26 = obj25;
		goto IL_087b;
	}

	private static int AddBone(Span<int> bone, Span<float> much, int n, int which, float how)
	{
		//IL_0009: Invalid comparison between F4 and I4
		//IL_001a: Expected Obj, but got I4
		//IL_0023: Invalid comparison between F4 and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_00d9: Invalid comparison between VT and I
		//IL_00ea: Expected Obj, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_01fe: Expected I4, but got Obj
		//IL_007b: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_020b: Invalid comparison between VT and Obj
		//IL_01b9: Expected Obj, but got I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		bool flag = how < 0f;
		object obj = !flag;
		bool flag2 = how == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		nint num = default;
		int result = (int)num;
		object obj4;
		if (obj3 == null)
		{
			if (num < 1)
			{
				goto IL_00d1;
			}
			obj4 = 0;
			object obj5 = default;
			while (much != (Span<float>)obj4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bone @ X0 (System.Span`1<System.Int32>)+v39 @ X9_v5*4]");
				if (0 != (nint)obj5)
				{
					obj4++;
					if (num != (nint)obj4)
					{
						continue;
					}
					goto IL_00d1;
				}
				goto IL_01a0;
			}
			goto IL_01f0;
		}
		goto IL_01fe;
		IL_01a0:
		bool flag3 = (nint)obj4 < which;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			goto IL_01f0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [n @ X2 (System.Int32)+v39 @ X9_v5*4]");
		float num2 = 0f + how;
		result = (int)num;
		goto IL_01fe;
		IL_00d1:
		bool flag4 = much < (object)num;
		object obj7 = !flag4;
		object obj8 = much - num;
		bool flag5 = obj8 == null;
		object obj9 = ~obj7;
		object obj10 = obj9 | flag5;
		if (obj10 == null)
		{
			bool flag6 = which < num;
			object obj11 = !flag6;
			object obj12 = which - num;
			bool flag7 = obj12 == null;
			object obj13 = ~obj11;
			object obj14 = obj13 | flag7;
			if (obj14 == null)
			{
				result = (int)(num + 1);
				goto IL_01fe;
			}
		}
		goto IL_01f0;
		IL_01f0:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
		IL_01fe:
		return result;
	}

	public unsafe static Half Cut(Mesh source, int sign, int seed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_0039: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj = 0;
		Along middle = Along.Middle;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Mesh source2 = default;
		object obj4 = default;
		return Cut(source2, sign, seed, (Along)(&obj4));
	}

	public unsafe static Half Cut(Mesh source, int sign, int seed, Along along)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0594: Expected VT, but got I4
		//IL_0082: Expected Obj, but got I4
		//IL_06df: Expected Obj, but got I
		//IL_06ef: Expected VT, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got Ref
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected VT, but got Unknown
		//IL_0126: Expected Ref, but got VT
		//IL_0150: Expected Obj, but got I
		//IL_0168: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I4
		//IL_0729: Expected Obj, but got I
		//IL_0755: Expected VT, but got I
		//IL_075f: Expected Obj, but got I4
		//IL_076c: Expected Obj, but got Ref
		//IL_064a: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I
		//IL_0203: Expected I, but got Obj
		//IL_0219: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I4
		//IL_023f: Expected VT, but got Ref
		//IL_0250: Expected Obj, but got VT
		//IL_0484: Expected Obj, but got I4
		//IL_0491: Expected Obj, but got Ref
		//IL_028d: Expected Obj, but got I4
		//IL_052f: Expected Obj, but got I4
		//IL_04c0: Expected Obj, but got I
		//IL_04df: Expected Obj, but got I4
		//IL_04ec: Expected Obj, but got Ref
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_050b: Expected I, but got Obj
		//IL_02f9: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I
		//IL_0334: Expected I, but got Obj
		//IL_055f: Expected Obj, but got I4
		//IL_0349: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I4
		//IL_03a0: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got VT
		//IL_03e2: Expected I4, but got Obj
		//IL_03eb: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got Ref
		//IL_0427: Expected Obj, but got I
		//IL_042f: Expected I, but got Obj
		//IL_0445: Expected Obj, but got I
		//IL_044d: Expected Obj, but got VT
		//IL_0466: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6878]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Along along3;
		System.__Canon _Canon;
		object obj5 = default;
		OutOfMemoryException ex = default;
		object obj6 = default;
		Along along4 = default;
		Task<System.__Canon> task;
		Along along6;
		Along along2 = default;
		System.__Canon result2;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			int num = 0;
			int value = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X3_v1 (GillaRip+Along)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X3_v1 (GillaRip+Along)+10]");
			_ = 0;
			_ = along2.n;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v34 (System.Int32)+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				value = ((int*)num)->m_value;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v34 (System.Int32)+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v17+18]");
			along3 = (Along)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v17+18]");
			bool flag2 = (nint)0 == 0;
			_Canon = null;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v17+18]");
				ProfilerUnsafeUtility.BeginSample((IntPtr)0);
				_Canon = null;
			}
			bool flag3 = (object)source == null;
			obj5 = 0;
			ex = null;
			obj6 = (object)(&along4);
			along4 = along3;
			if (!flag3)
			{
				string name = source.name;
				Along along5 = (Along)(obj2 + 24);
				string key = ((Along*)along5)->Key;
				string text = name + key;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67E8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
				int num2 = 0;
				nint num3 = (nint)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+14]");
				(System.__Canon, int, int) tuple = ((System.__Canon)(object)text, (int)num4, 0);
				int value2 = ((int*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v44 (System.Int32)+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					value2 = ((int*)num)->m_value;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v44 (System.Int32)+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v22+8]");
				bool flag5 = (nint)0 == 0;
				task = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+14]");
				along2 = (Along)0;
				obj5 = 0;
				ex = null;
				obj6 = (object)(&along4);
				along4 = along3;
				_Canon = (System.__Canon)(object)text;
				along6 = (Along)tuple;
				if (flag5)
				{
					goto IL_05de;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6880]");
				object obj10 = 0;
				num3 = (nint)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v22+8]");
				bool flag6 = ((Dictionary<(System.__Canon, int, int), System.__Canon>)0).TryGetValue(tuple, out *(System.__Canon*)null);
				bool flag7 = !flag6;
				object obj11 = !flag7;
				along2 = (Along)(&task);
				num2 = 0;
				_Canon = tuple;
				if (obj11 == null)
				{
					int value3 = ((int*)num)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v50 (System.Int32)+E4]");
					bool flag8 = (nint)0 == 0;
					object obj12 = !flag8;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Source source2 = Read(source);
					object obj13 = obj2 + 64;
					obj13 = source2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					int value4 = ((int*)num)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v29 (System.Int32)+A0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67C8]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6898]");
					object obj16 = 0;
					Func<System.__Canon> func = default;
					func._002Ector(obj2, (IntPtr)obj16);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
					object obj17 = 0;
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v59+E4]");
					bool flag9 = (nint)0 == 0;
					object obj19 = !flag9;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6888]");
					object obj20 = 0;
					_Canon = (System.__Canon)obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @362791C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v30+8]");
					bool flag10 = (nint)0 == 0;
					Along along7 = default;
					task = (Task<System.__Canon>)along7;
					along2 = along7;
					num2 = (int)obj16;
					obj5 = 0;
					ex = null;
					obj6 = (object)(&along4);
					along4 = along3;
					along6 = (Along)tuple;
					if (flag10)
					{
						goto IL_05fa;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67C0]");
					object obj21 = 0;
					num3 = (nint)obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v30+8]");
					((Dictionary<(System.__Canon, int, int), System.__Canon>)0).set_Item(tuple, (System.__Canon)null);
					task = (Task<System.__Canon>)along7;
					along2 = along7;
					num2 = 0;
					_Canon = tuple;
				}
				bool flag11 = task == null;
				obj5 = 0;
				ex = null;
				obj6 = (object)(&along4);
				along4 = along3;
				along6 = (Along)tuple;
				if (flag11)
				{
					goto IL_05ec;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6850]");
				object obj22 = 0;
				_Canon = (System.__Canon)obj22;
				System.__Canon result = task.Result;
				obj5 = 0;
				ex = null;
				obj6 = (object)(&along4);
				result2 = result;
				along6 = (Along)tuple;
				goto IL_07b6;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			along4 = (Along)0;
			_Canon = null;
			along3 = along2;
		}
		NullReferenceException ex3 = new NullReferenceException();
		task = null;
		goto IL_05b9;
		IL_05fa:
		NullReferenceException ex4 = new NullReferenceException();
		if ((nint)_Canon == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj5 = 1;
		}
		else
		{
			if ((nint)_Canon != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				Half result3 = default;
				return result3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj23 = default;
			ex = (OutOfMemoryException)obj23;
		}
		result2 = null;
		goto IL_07b6;
		IL_07b6:
		if (obj6 != null)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj6);
			_Canon = null;
		}
		bool flag12 = ex == null;
		object obj24 = !flag12;
		along3 = along6;
		if (obj24 != null)
		{
			goto IL_05b9;
		}
		bool flag13 = obj5 == null;
		object obj25 = !flag13;
		OutOfMemoryException ex5 = ex;
		along3 = along6;
		if (obj25 == null)
		{
			return (Half)(object)result2;
		}
		goto IL_05c7;
		IL_05de:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_05ec;
		IL_05b9:
		ex5 = new OutOfMemoryException();
		goto IL_05c7;
		IL_05ec:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_05fa;
		IL_05c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		along6 = along3;
		goto IL_05de;
	}

	public unsafe static void Begin(Mesh source, int seed, Along along, CancellationToken drop = default(CancellationToken))
	{
		//IL_0010: Expected Obj, but got I
		//IL_002a: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I8
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got I4
		//IL_0111: Expected VT, but got I4
		//IL_061b: Expected Obj, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected VT, but got Unknown
		//IL_01ce: Expected Ref, but got VT
		//IL_021d: Expected Obj, but got I
		//IL_0225: Expected I, but got Obj
		//IL_0274: Expected Obj, but got I4
		//IL_04a3: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I
		//IL_02b1: Expected VT, but got Obj
		//IL_02c6: Expected Obj, but got I
		//IL_02e4: Expected Obj, but got I4
		//IL_02ed: Expected VT, but got I4
		//IL_04d8: Expected Obj, but got I
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_031d: Expected Obj, but got I4
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got I4
		//IL_057f: Expected Obj, but got I
		//IL_058f: Expected Obj, but got I
		//IL_05a9: Expected Obj, but got I
		//IL_05ba: Expected I, but got Obj
		//IL_05ca: Expected Obj, but got I
		//IL_05f4: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got I4
		//IL_03c2: Expected Obj, but got I
		//IL_0401: Expected Obj, but got I
		//IL_0409: Expected I, but got Obj
		//IL_041f: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I
		//IL_0440: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X2_v4 (GillaRip+Along)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X2_v4 (GillaRip+Along)+10]");
			_ = 0;
			Along along2 = default;
			_ = along2.n;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj4 = default;
			if (obj4 != null)
			{
				_ = 1;
				_ = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v9+18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68C8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v9+18]");
				object obj7 = 0 & 0xFFFFFFFFL;
				object obj8 = obj4 + 32;
				CancellationToken cancellationToken = drop;
				object obj9 = 0;
				(System.__Canon, int, int) tuple = ((System.__Canon, int, int))2;
				Source source2 = null;
				object obj11 = default;
				Func<System.__Canon> func = default;
				CancellationToken cancellationToken2 = default;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
					object obj10 = !flag;
					if (obj10 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					obj11._002Ector();
					if (obj11 != null)
					{
						object obj12 = obj11 + 32;
						obj12 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						if ((object)source != null)
						{
							string name = source.name;
							if (obj12 != null)
							{
								Along along3 = (Along)(obj12 + 20);
								string key = ((Along*)along3)->Key;
								string item = name + key;
								object obj13 = obj12;
								if (obj12 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67E8]");
									object obj14 = 0;
									nint num = (nint)obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v8+v114 @ X29_v6*4]");
									nint num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v12+10]");
									(System.__Canon, int, int) tuple2 = ((System.__Canon)(object)item, (int)num2, 0);
									object obj15 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v24+E4]");
									bool flag2 = (nint)0 == 0;
									object obj16 = !flag2;
									if (obj16 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj15 = obj6;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v24+A0]");
									object obj17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v16+8]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67B8]");
										object obj18 = 0;
										cancellationToken = (CancellationToken)obj18;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v16+8]");
										bool flag3 = ((Dictionary<(System.__Canon, int, int), System.__Canon>)0).ContainsKey(tuple2);
										bool flag4 = !flag3;
										object obj19 = !flag4;
										along2 = (Along)0;
										tuple = tuple2;
										if (obj19 == null)
										{
											bool flag5 = source2 == null;
											object obj20 = !flag5;
											if (obj20 == null)
											{
												object obj21 = obj6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v43+E4]");
												bool flag6 = (nint)0 == 0;
												object obj22 = !flag6;
												if (obj22 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Source source3 = Read(source);
												source2 = source3;
											}
											object obj23 = obj11 + 16;
											obj23 = source2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj24 = obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v8+v114 @ X29_v6*4]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v32+E4]");
											bool flag7 = (nint)0 == 0;
											object obj25 = !flag7;
											if (obj25 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj24 = obj6;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v32+A0]");
											object obj26 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67C8]");
											object obj27 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68C0]");
											object obj28 = 0;
											func._002Ector(obj11, (IntPtr)obj28);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
											object obj29 = 0;
											object obj30 = obj29;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v35+E4]");
											bool flag8 = (nint)0 == 0;
											object obj31 = !flag8;
											if (obj31 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68B8]");
											object obj32 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3627A10");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v23+8]");
											if ((nint)0 == 0)
											{
												goto IL_044e;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67C0]");
											object obj33 = 0;
											num = (nint)obj33;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v23+8]");
											((Dictionary<(System.__Canon, int, int), System.__Canon>)0).set_Item(tuple2, (System.__Canon)null);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68C8]");
											obj5 = 0;
											cancellationToken = cancellationToken2;
											along2 = (Along)0;
											tuple = tuple2;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v9+18]");
										obj7 = 0;
										obj9++;
										object obj34 = obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v9+18]");
										if ((nint)obj34 >= 0)
										{
											return;
										}
										continue;
									}
								}
							}
						}
					}
					goto IL_044e;
				}
				goto IL_045c;
			}
		}
		goto IL_044e;
		IL_045c:
		throw new IndexOutOfRangeException();
		IL_044e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_045c;
	}

	public unsafe static bool IsReady(Mesh source, int seed, Along along)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02e6: Expected I4, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I8
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00ed: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		//IL_0343: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_0170: Expected Ref, but got VT
		//IL_01e9: Expected VT, but got I4
		//IL_01e9: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_028e: Expected VT, but got I4
		//IL_0297: Expected VT, but got I4
		//IL_02a0: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = default;
		if (obj2 == null)
		{
			goto IL_02ca;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+18]");
			bool flag = (nint)0 == 1;
			_ = 1;
			if (!flag)
			{
				_ = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_02ae;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6880]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+18]");
				object obj5 = 0 & 0xFFFFFFFFL;
				object obj6 = obj2 + 32;
				Along along2 = along;
				object obj7 = 2;
				object obj8 = 0;
				Task task = default;
				while (true)
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
					object obj9 = !flag2;
					if (obj9 != null)
					{
						break;
					}
					object obj10 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj10 = obj3;
					}
					if ((object)source != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13+A0]");
						object obj12 = 0;
						string name = source.name;
						string key = ((Along*)along)->Key;
						string item = name + key;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X28_v6+v107 @ X26_v7*4]");
						(System.__Canon, int, int) tuple = ((System.__Canon)(object)item, 0, seed);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v11+8]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v11+8]");
							if (((Dictionary<(System.__Canon, int, int), System.__Canon>)0).TryGetValue(((System.__Canon, int, int))0, out *(System.__Canon*)null))
							{
								if (task == null)
								{
									goto IL_02ca;
								}
								if (task.IsCompleted)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+18]");
									obj5 = 0;
									obj8++;
									object obj13 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+18]");
									bool flag4 = (nint)obj13 < 0;
									tuple = ((System.__Canon, int, int))0;
									along2 = (Along)0;
									obj7 = 0;
									if (flag4)
									{
										continue;
									}
									goto IL_02ae;
								}
							}
							return false;
						}
					}
					goto IL_02ca;
				}
			}
		}
		goto IL_02d8;
		IL_02d8:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_02ca:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02d8;
		IL_02ae:
		return true;
	}

	public unsafe static void Forget(Mesh source, int seed, Along along)
	{
		//IL_0259: Expected Ref, but got VT
		//IL_0277: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I8
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I4
		//IL_00d8: Expected VT, but got I4
		//IL_02bb: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I
		//IL_0152: Expected Ref, but got VT
		//IL_017c: Expected Obj, but got I
		//IL_01d9: Expected VT, but got I4
		//IL_01d9: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_021a: Expected VT, but got I4
		//IL_0223: Expected VT, but got I4
		//IL_022c: Expected VT, but got I4
		bool isMiddle = ((Along*)along)->IsMiddle;
		bool flag = !isMiddle;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = default;
		if (obj3 == null)
		{
			goto IL_023b;
		}
		_ = 1;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68D0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+18]");
		object obj6 = 0 & 0xFFFFFFFFL;
		object obj7 = obj3 + 32;
		Along along2 = along;
		object obj8 = 0;
		(System.__Canon, int, int) tuple = ((System.__Canon, int, int))2;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
			object obj9 = !flag2;
			if (obj9 != null)
			{
				break;
			}
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj4;
			}
			if ((object)source != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v13+A0]");
				object obj12 = 0;
				string name = source.name;
				string key = ((Along*)along)->Key;
				string item = name + key;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67E8]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X28_v5+v240 @ X26_v6*4]");
				(System.__Canon, int, int) tuple2 = ((System.__Canon)(object)item, 0, seed);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v12+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v12+8]");
					bool flag4 = ((Dictionary<(System.__Canon, int, int), System.__Canon>)0).Remove(((System.__Canon, int, int))0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+18]");
					obj6 = 0;
					obj8++;
					object obj14 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+18]");
					bool flag5 = (nint)obj14 < 0;
					tuple2 = ((System.__Canon, int, int))0;
					along2 = (Along)0;
					tuple = ((System.__Canon, int, int))0;
					if (!flag5)
					{
						return;
					}
					continue;
				}
			}
			goto IL_023b;
		}
		goto IL_0249;
		IL_023b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0249;
		IL_0249:
		throw new IndexOutOfRangeException();
	}

	private unsafe static Half Work(Source source, int sign, int seed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_0039: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj = 0;
		Along middle = Along.Middle;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Source source2 = default;
		object obj4 = default;
		return Work(source2, sign, seed, (Along)(&obj4));
	}

	private unsafe static Half Work(Source source, int sign, int seed, Along along)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0018: Expected Obj, but got Ref
		//IL_40cb: Expected Obj, but got I4
		//IL_4103: Expected VT, but got I4
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_00ce: Expected VT, but got I4
		//IL_012c: Expected VT, but got I4
		//IL_018f: Expected VT, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_01e6: Expected VT, but got Obj
		//IL_0226: Expected I4, but got Obj
		//IL_0264: Expected VT, but got Obj
		//IL_02a4: Expected I4, but got Obj
		//IL_02ea: Expected Obj, but got I
		//IL_02f2: Expected VT, but got Obj
		//IL_0332: Expected I4, but got Obj
		//IL_0378: Expected Obj, but got I
		//IL_0380: Expected VT, but got Obj
		//IL_03d5: Expected I4, but got Obj
		//IL_041b: Expected Obj, but got I
		//IL_042b: Expected Obj, but got I
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_044b: Expected Obj, but got I4
		//IL_0463: Expected Ref, but got VT
		//IL_24cc: Expected VT, but got Obj
		//IL_2536: Expected Obj, but got I
		//IL_253e: Expected VT, but got Obj
		//IL_2558: Expected VT, but got Obj
		//IL_4732: Invalid comparison between Obj and VT
		//IL_4743: Expected Obj, but got I4
		//IL_4761: Invalid comparison between F4 and I4
		//IL_4778: Invalid comparison between Obj and VT
		//IL_04f8: Expected F4, but got I4
		//IL_4673: Expected Obj, but got I4
		//IL_4694: Invalid comparison between F4 and I4
		//IL_256a: Expected I4, but got Obj
		//IL_256a: Expected Obj, but got VT
		//IL_257b: Expected VT, but got Obj
		//IL_257b: Expected Ref, but got VT
		//IL_258c: Expected VT, but got Obj
		//IL_259d: Expected VT, but got Obj
		//IL_259d: Expected I4, but got Obj
		//IL_259d: Expected Obj, but got VT
		//IL_25aa: Expected VT, but got Obj
		//IL_25d6: Expected I4, but got Obj
		//IL_1b64: Expected Obj, but got I
		//IL_1b81: Expected Obj, but got I
		//IL_1ba3: Expected Obj, but got I4
		//IL_2616: Expected I4, but got Obj
		//IL_2627: Expected VT, but got Obj
		//IL_2627: Expected Ref, but got VT
		//IL_1bf4: Expected I4, but got VT
		//IL_0574: Expected Obj, but got I4
		//IL_058f: Invalid comparison between F4 and I4
		//IL_2638: Expected VT, but got Obj
		//IL_264e: Expected VT, but got Obj
		//IL_264e: Expected I4, but got Obj
		//IL_265b: Expected VT, but got Obj
		//IL_2664: Unknown result type (might be due to invalid IL or missing references)
		//IL_2669: Expected Obj, but got Unknown
		//IL_2688: Expected Obj, but got I4
		//IL_26a0: Expected I4, but got Obj
		//IL_26c0: Expected VT, but got Obj
		//IL_26c8: Expected I4, but got Obj
		//IL_26dd: Expected VT, but got Obj
		//IL_1ca7: Expected Obj, but got I4
		//IL_1ce1: Expected Obj, but got I
		//IL_1c12: Expected Obj, but got I
		//IL_1c2c: Expected Obj, but got I
		//IL_1c3d: Expected I, but got Obj
		//IL_05d1: Expected Obj, but got I
		//IL_1d00: Expected Obj, but got I
		//IL_1d11: Expected I, but got Obj
		//IL_1c5d: Expected VT, but got I4
		//IL_0626: Expected Obj, but got I
		//IL_0664: Expected Obj, but got I
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_06a1: Expected Obj, but got I4
		//IL_06aa: Expected I4, but got Obj
		//IL_1d5b: Expected Obj, but got I
		//IL_06e3: Expected Obj, but got I
		//IL_1d8e: Expected I, but got Obj
		//IL_4150: Expected I4, but got Obj
		//IL_4160: Expected Obj, but got I
		//IL_4168: Expected VT, but got Obj
		//IL_4185: Expected Obj, but got I
		//IL_41a7: Expected Obj, but got I4
		//IL_41c9: Invalid comparison between F4 and I4
		//IL_06ce: Expected Obj, but got I
		//IL_1da3: Expected F8, but got I
		//IL_1dab: Expected I, but got Obj
		//IL_1dcd: Expected Obj, but got I4
		//IL_1def: Invalid comparison between F4 and I4
		//IL_07d8: Expected VT, but got Obj
		//IL_07f9: Expected VT, but got I4
		//IL_46e7: Expected Obj, but got I4
		//IL_1e31: Expected F8, but got I
		//IL_4a2a: Invalid comparison between VT and Obj
		//IL_4a3b: Expected Obj, but got I4
		//IL_4a54: Invalid comparison between F4 and I4
		//IL_1e88: Expected VT, but got I4
		//IL_1e99: Expected Obj, but got I4
		//IL_1ea9: Expected VT, but got Obj
		//IL_1eb1: Expected I4, but got Obj
		//IL_1ed1: Expected I4, but got Obj
		//IL_1ed9: Expected VT, but got Obj
		//IL_1a19: Expected Obj, but got I4
		//IL_1a3a: Invalid comparison between F4 and I4
		//IL_19a9: Expected I, but got Obj
		//IL_1ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef5: Expected Obj, but got Unknown
		//IL_1a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a75: Expected Obj, but got Unknown
		//IL_1a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a95: Expected Obj, but got Unknown
		//IL_1ab7: Expected Obj, but got I4
		//IL_1abf: Expected I4, but got Obj
		//IL_1f36: Expected Obj, but got I
		//IL_1f58: Expected Obj, but got I4
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Expected I4, but got Unknown
		//IL_096d: Expected VT, but got Obj
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected Obj, but got Unknown
		//IL_09ca: Expected Obj, but got I4
		//IL_09eb: Invalid comparison between F4 and I4
		//IL_1f92: Expected Obj, but got I
		//IL_1fb2: Expected VT, but got I4
		//IL_1fca: Expected VT, but got Obj
		//IL_1feb: Expected I4, but got Obj
		//IL_1ff3: Expected VT, but got Obj
		//IL_1af5: Expected I4, but got Obj
		//IL_2011: Expected Obj, but got I
		//IL_2031: Expected VT, but got I4
		//IL_2041: Expected VT, but got Obj
		//IL_0ba2: Expected VT, but got Obj
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected Obj, but got Unknown
		//IL_0bff: Expected Obj, but got I4
		//IL_0c20: Invalid comparison between F4 and I4
		//IL_2085: Expected VT, but got I4
		//IL_2095: Expected VT, but got Obj
		//IL_20ce: Expected Obj, but got I4
		//IL_20e4: Expected Obj, but got I
		//IL_2118: Unknown result type (might be due to invalid IL or missing references)
		//IL_211d: Expected I4, but got Unknown
		//IL_212e: Expected VT, but got I4
		//IL_213e: Expected VT, but got Obj
		//IL_0dc7: Expected I4, but got Obj
		//IL_0dcf: Expected VT, but got Obj
		//IL_0e0d: Invalid comparison between VT and I
		//IL_0e1e: Expected Obj, but got I4
		//IL_0e3f: Invalid comparison between F4 and I4
		//IL_2177: Expected Obj, but got I4
		//IL_21d0: Expected VT, but got I4
		//IL_21e0: Expected VT, but got Obj
		//IL_222b: Expected VT, but got I4
		//IL_223b: Expected VT, but got Obj
		//IL_225c: Expected I4, but got Obj
		//IL_2264: Expected VT, but got Obj
		//IL_0fe9: Expected VT, but got Obj
		//IL_1017: Expected Obj, but got I
		//IL_1028: Expected F4, but got I
		//IL_227b: Invalid comparison between F4 and I4
		//IL_228c: Expected Obj, but got I4
		//IL_2296: Invalid comparison between F4 and I4
		//IL_22a7: Expected I, but got Obj
		//IL_22ab: Expected native int or pointer, but got Obj
		//IL_22ba: Invalid comparison between F4 and I4
		//IL_10df: Invalid comparison between VT and Obj
		//IL_10f0: Expected Obj, but got I4
		//IL_1109: Invalid comparison between F4 and I4
		//IL_1153: Expected F4, but got I
		//IL_4717: Expected Obj, but got I4
		//IL_11f8: Expected F4, but got I
		//IL_2342: Expected Ref, but got VT
		//IL_235b: Expected Obj, but got I
		//IL_2375: Expected Obj, but got I4
		//IL_12ab: Expected Obj, but got I
		//IL_12c1: Expected Obj, but got I
		//IL_135a: Expected F4, but got I
		//IL_2432: Expected Ref, but got VT
		//IL_2452: Expected I4, but got Obj
		//IL_245a: Expected VT, but got Obj
		//IL_2462: Expected F4, but got I8
		//IL_247b: Expected VT, but got Obj
		//IL_249c: Expected I4, but got Obj
		//IL_24a4: Expected VT, but got Obj
		//IL_24ac: Expected Obj, but got VT
		//IL_23a8: Expected F8, but got I
		//IL_23b9: Expected Obj, but got I
		//IL_23db: Expected Obj, but got I4
		//IL_13e8: Expected Obj, but got I
		//IL_140e: Expected Obj, but got I4
		//IL_4227: Unknown result type (might be due to invalid IL or missing references)
		//IL_422c: Expected VT, but got Unknown
		//IL_4270: Invalid comparison between VT and Obj
		//IL_4281: Expected Obj, but got I4
		//IL_429a: Invalid comparison between F4 and I4
		//IL_438d: Invalid comparison between VT and Obj
		//IL_270e: Expected Obj, but got I
		//IL_2730: Expected Obj, but got I4
		//IL_2405: Expected VT, but got Ref
		//IL_2412: Expected F4, but got VT
		//IL_1477: Expected VT, but got Ref
		//IL_1487: Expected Obj, but got I
		//IL_1497: Expected VT, but got I
		//IL_14bc: Expected Obj, but got I
		//IL_47bf: Expected Obj, but got I
		//IL_47cf: Expected Obj, but got I
		//IL_24bf: Expected Obj, but got I4
		//IL_4522: Expected Obj, but got I4
		//IL_453b: Invalid comparison between F4 and I4
		//IL_4585: Expected F4, but got I
		//IL_1441: Unknown result type (might be due to invalid IL or missing references)
		//IL_1446: Expected Obj, but got Unknown
		//IL_14ee: Expected Obj, but got I
		//IL_1504: Expected Obj, but got I
		//IL_1595: Expected F4, but got I
		//IL_1623: Expected Obj, but got I
		//IL_1649: Expected Obj, but got I4
		//IL_2807: Expected Obj, but got I4
		//IL_282e: Expected Obj, but got I
		//IL_2879: Expected Obj, but got I
		//IL_2889: Unknown result type (might be due to invalid IL or missing references)
		//IL_288e: Expected Obj, but got Unknown
		//IL_28ad: Expected Obj, but got I
		//IL_28c6: Expected Obj, but got I4
		//IL_28ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d3: Expected Obj, but got Unknown
		//IL_28dc: Expected I4, but got Obj
		//IL_16b2: Expected VT, but got Ref
		//IL_16c2: Expected Obj, but got I
		//IL_16d2: Expected VT, but got I
		//IL_16f7: Expected Obj, but got I
		//IL_28ff: Expected Obj, but got I
		//IL_45ac: Expected Obj, but got I4
		//IL_45c5: Invalid comparison between F4 and I4
		//IL_460f: Expected F4, but got I
		//IL_167c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1681: Expected Obj, but got Unknown
		//IL_4823: Expected I4, but got Obj
		//IL_2972: Expected Obj, but got I8
		//IL_1729: Expected Obj, but got I
		//IL_173f: Expected Obj, but got I
		//IL_17d0: Expected F4, but got I
		//IL_299d: Expected Obj, but got I4
		//IL_29bf: Expected VT, but got I
		//IL_186b: Expected Obj, but got I
		//IL_1891: Expected Obj, but got I4
		//IL_18f5: Expected VT, but got Ref
		//IL_1905: Expected Obj, but got I
		//IL_1915: Expected VT, but got I
		//IL_193a: Expected Obj, but got I
		//IL_2a79: Expected Obj, but got I4
		//IL_2a9b: Invalid comparison between F4 and I4
		//IL_2ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2abb: Expected I4, but got Unknown
		//IL_2acb: Expected F4, but got I
		//IL_18bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c4: Expected Obj, but got Unknown
		//IL_2a39: Expected F4, but got I
		//IL_2ae7: Expected Obj, but got I4
		//IL_2b20: Expected F4, but got I
		//IL_2b30: Expected F4, but got I
		//IL_2b38: Expected I4, but got Obj
		//IL_2b7d: Expected F4, but got I
		//IL_2b85: Expected I4, but got Obj
		//IL_2c40: Expected Obj, but got I8
		//IL_2c5f: Expected F4, but got I
		//IL_2c08: Expected F4, but got I
		//IL_2c7b: Expected Obj, but got I4
		//IL_2c83: Expected Obj, but got I4
		//IL_2ca7: Expected Obj, but got I8
		//IL_2cc6: Expected F4, but got I
		//IL_2d91: Expected Obj, but got I4
		//IL_2da7: Expected Obj, but got I
		//IL_2dc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dcc: Expected Obj, but got Unknown
		//IL_2ddc: Expected F4, but got I
		//IL_2d51: Expected F4, but got I
		//IL_2df8: Expected Obj, but got I4
		//IL_2e00: Expected Obj, but got I4
		//IL_2e2c: Expected Obj, but got I4
		//IL_2e42: Expected Obj, but got I
		//IL_2e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e67: Expected Obj, but got Unknown
		//IL_2e77: Expected F4, but got I
		//IL_2f42: Expected Obj, but got I4
		//IL_2f58: Expected Obj, but got I
		//IL_2f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f7d: Expected Obj, but got Unknown
		//IL_2f8d: Expected F4, but got I
		//IL_2f02: Expected F4, but got I
		//IL_2fa9: Expected Obj, but got I4
		//IL_2fb1: Expected Obj, but got I4
		//IL_2fd5: Expected Obj, but got I8
		//IL_2ff4: Expected F4, but got I
		//IL_30bf: Expected Obj, but got I4
		//IL_30d5: Expected Obj, but got I
		//IL_30f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_30fa: Expected Obj, but got Unknown
		//IL_310a: Expected F4, but got I
		//IL_307f: Expected F4, but got I
		//IL_3126: Expected Obj, but got I4
		//IL_312e: Expected Obj, but got I4
		//IL_315a: Expected Obj, but got I4
		//IL_3170: Expected Obj, but got I
		//IL_3190: Unknown result type (might be due to invalid IL or missing references)
		//IL_3195: Expected Obj, but got Unknown
		//IL_31a5: Expected F4, but got I
		//IL_3268: Expected Obj, but got I8
		//IL_3287: Expected F4, but got I
		//IL_3230: Expected F4, but got I
		//IL_32a3: Expected Obj, but got I4
		//IL_32ab: Expected Obj, but got I4
		//IL_32d7: Expected Obj, but got I4
		//IL_32ed: Expected Obj, but got I
		//IL_330d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3312: Expected Obj, but got Unknown
		//IL_3322: Expected F4, but got I
		//IL_33ed: Expected Obj, but got I4
		//IL_3403: Expected Obj, but got I
		//IL_3423: Unknown result type (might be due to invalid IL or missing references)
		//IL_3428: Expected Obj, but got Unknown
		//IL_3438: Expected F4, but got I
		//IL_33ad: Expected F4, but got I
		//IL_3454: Expected Obj, but got I4
		//IL_3473: Expected Obj, but got I4
		//IL_34a8: Expected Obj, but got I4
		//IL_34ca: Invalid comparison between F4 and I4
		//IL_34e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ea: Expected I4, but got Unknown
		//IL_34fa: Expected F4, but got I
		//IL_3503: Expected VT, but got I4
		//IL_3543: Expected F4, but got I
		//IL_3553: Expected F4, but got I
		//IL_3563: Expected F4, but got I
		//IL_3573: Expected F4, but got I
		//IL_3583: Expected F4, but got I
		//IL_3593: Expected F4, but got I
		//IL_35a3: Expected F4, but got I
		//IL_35b3: Expected F4, but got I
		//IL_35c3: Expected F4, but got I
		//IL_35cc: Expected VT, but got I4
		//IL_36ae: Expected F4, but got I
		//IL_36b7: Expected VT, but got I4
		//IL_3627: Expected I, but got Obj
		//IL_3660: Expected F4, but got I
		//IL_3669: Expected VT, but got I4
		//IL_36ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d3: Expected Obj, but got Unknown
		//IL_36db: Expected Obj, but got I4
		//IL_36ff: Expected Obj, but got I8
		//IL_371e: Expected F4, but got I
		//IL_3727: Expected VT, but got I4
		//IL_37ee: Expected Obj, but got I8
		//IL_380d: Expected F4, but got I
		//IL_3816: Expected VT, but got I4
		//IL_3774: Expected I, but got Obj
		//IL_37ad: Expected F4, but got I
		//IL_37b6: Expected VT, but got I4
		//IL_382d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3832: Expected Obj, but got Unknown
		//IL_383a: Expected Obj, but got I4
		//IL_3866: Expected Obj, but got I4
		//IL_387c: Expected Obj, but got I
		//IL_389c: Unknown result type (might be due to invalid IL or missing references)
		//IL_38a1: Expected Obj, but got Unknown
		//IL_38b1: Expected F4, but got I
		//IL_38ba: Expected VT, but got I4
		//IL_38e0: Expected F4, but got I
		//IL_3989: Expected Obj, but got I4
		//IL_39ab: Invalid comparison between F4 and I4
		//IL_39c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_39cb: Expected I4, but got Unknown
		//IL_39d4: Expected VT, but got I4
		//IL_3917: Expected I, but got Obj
		//IL_3949: Expected VT, but got I4
		//IL_39eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_39f0: Expected Obj, but got Unknown
		//IL_39f8: Expected Obj, but got I4
		//IL_3a12: Expected Obj, but got I
		//IL_3a1a: Expected I, but got Obj
		//IL_3a22: Expected I4, but got Obj
		//IL_3bb4: Expected Obj, but got I8
		//IL_3bcc: Expected VT, but got I4
		//IL_3a4f: Expected Obj, but got I
		//IL_3a7e: Expected F4, but got I
		//IL_3a8e: Expected F4, but got I
		//IL_3a9e: Expected F4, but got I
		//IL_3aae: Expected F4, but got I
		//IL_3abe: Expected F4, but got I
		//IL_3ace: Expected F4, but got I
		//IL_3ade: Expected F4, but got I
		//IL_3aee: Expected F4, but got I
		//IL_3afe: Expected F4, but got I
		//IL_3b07: Expected VT, but got I4
		//IL_3b4a: Expected I, but got Obj
		//IL_3b7c: Expected VT, but got I4
		//IL_3be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be8: Expected Obj, but got Unknown
		//IL_3ca8: Expected Obj, but got I4
		//IL_3cbe: Expected Obj, but got I
		//IL_3cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ce3: Expected Obj, but got Unknown
		//IL_3cec: Expected VT, but got I4
		//IL_3c36: Expected I, but got Obj
		//IL_3c68: Expected VT, but got I4
		//IL_3d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d08: Expected Obj, but got Unknown
		//IL_3dc8: Expected Obj, but got I4
		//IL_3dea: Invalid comparison between F4 and I4
		//IL_3e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e0a: Expected I4, but got Unknown
		//IL_3e13: Expected VT, but got I4
		//IL_3d56: Expected I, but got Obj
		//IL_3d88: Expected VT, but got I4
		//IL_3e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e2f: Expected Obj, but got Unknown
		//IL_3e4e: Expected Obj, but got I4
		//IL_3e8f: Expected F4, but got I
		//IL_3e9f: Expected F4, but got I
		//IL_3eaf: Expected F4, but got I
		//IL_3ebf: Expected F4, but got I
		//IL_3ecf: Expected F4, but got I
		//IL_3edf: Expected F4, but got I
		//IL_3eef: Expected F4, but got I
		//IL_3eff: Expected F4, but got I
		//IL_3f07: Expected F4, but got I
		//IL_3f10: Expected VT, but got I4
		//IL_3f18: Expected I4, but got Obj
		//IL_3f46: Expected Obj, but got I
		//IL_3f4e: Expected VT, but got Obj
		//IL_3f6b: Expected Obj, but got I
		//IL_3f7b: Expected Obj, but got I
		//IL_3f83: Expected I4, but got Obj
		//IL_4a14: Expected Obj, but got I4
		//IL_4870: Expected Obj, but got I
		//IL_4897: Expected F4, but got I
		//IL_48a7: Expected F4, but got I
		//IL_48b7: Expected F4, but got I
		//IL_48c7: Expected F4, but got I
		//IL_48d7: Expected F4, but got I
		//IL_48e7: Expected F4, but got I
		//IL_48f7: Expected F4, but got I
		//IL_4907: Expected F4, but got I
		//IL_490f: Expected F4, but got I
		//IL_3fa7: Expected I4, but got Obj
		//IL_3fce: Expected Obj, but got I4
		//IL_3fe8: Invalid comparison between F4 and I4
		//IL_4044: Expected Obj, but got I4
		//IL_4935: Expected Obj, but got I
		//IL_495c: Expected F4, but got I
		//IL_496c: Expected F4, but got I
		//IL_497c: Expected F4, but got I
		//IL_498c: Expected F4, but got I
		//IL_499c: Expected F4, but got I
		//IL_49ac: Expected F4, but got I
		//IL_49bc: Expected F4, but got I
		//IL_49cc: Expected F4, but got I
		//IL_49d4: Expected F4, but got I
		//IL_4071: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68D8]");
		string text = (string)0;
		System.__Canon result = default;
		object obj = (object)(&result);
		obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		Along along2 = along;
		Vector3 vector = (Vector3)seed;
		int num = 0;
		object obj3 = obj2;
		Source source2 = source;
		int num2 = sign;
		int num3 = seed;
		Along along3 = along;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6940]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v158+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Stopwatch stopwatch = Stopwatch.StartNew();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Shape shape = default;
			shape._002Ector();
			bool flag3 = shape == null;
			along2 = along;
			vector = (Vector3)seed;
			num = 0;
			obj3 = obj2;
			source2 = source;
			num2 = sign;
			num3 = seed;
			along3 = along;
			if (!flag3)
			{
				bool flag4 = source == null;
				along2 = along;
				vector = (Vector3)seed;
				num = 0;
				obj3 = obj2;
				source2 = source;
				num2 = sign;
				num3 = seed;
				along3 = along;
				if (!flag4)
				{
					bool flag5 = shape.at == null;
					along2 = along;
					vector = (Vector3)seed;
					num = 0;
					obj3 = obj2;
					source2 = source;
					num2 = sign;
					num3 = seed;
					along3 = along;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6910]");
						text = (string)0;
						vector = (Vector3)text;
						shape.at.AddRange(source.at);
						bool flag6 = shape.faces == null;
						along2 = along;
						num = (int)source.at;
						obj3 = obj2;
						source2 = source;
						num2 = sign;
						num3 = seed;
						along3 = along;
						if (!flag6)
						{
							vector = (Vector3)text;
							shape.faces.AddRange(source.faces);
							bool flag7 = (object)shape.uv == null;
							along2 = along;
							num = (int)source.faces;
							obj3 = obj2;
							source2 = source;
							num2 = sign;
							num3 = seed;
							along3 = along;
							if (!flag7)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6918]");
								object obj7 = 0;
								vector = (Vector3)obj7;
								shape.uv.AddRange(source.uv);
								bool flag8 = shape.weights == null;
								along2 = along;
								num = (int)source.uv;
								obj3 = obj2;
								source2 = source;
								num2 = sign;
								num3 = seed;
								along3 = along;
								if (!flag8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6920]");
									object obj8 = 0;
									vector = (Vector3)obj8;
									shape.weights.AddRange(source.weights);
									int[][] tris = source.tris;
									bool flag9 = source.tris == null;
									along2 = along;
									Source source3 = source;
									num = (int)source.weights;
									obj3 = obj2;
									source2 = source;
									num2 = sign;
									num3 = seed;
									along3 = along;
									if (!flag9)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56B0]");
										string text2 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
										object obj9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										object obj10 = shape + 48;
										int num4 = default;
										obj10 = num4;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										bool isMiddle = ((Along*)along)->IsMiddle;
										bool flag10 = !isMiddle;
										num = num4;
										source2 = source;
										along3 = along;
										if (flag10)
										{
											along3 = (Along)shape.at;
											bool flag11 = shape.at == null;
											along2 = along;
											source3 = source;
											num = num4;
											obj3 = obj2;
											source2 = source;
											num2 = sign;
											num3 = seed;
											if (flag11)
											{
												goto IL_26eb;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6938]");
											text = (string)0;
											Vector3 vector2 = (Vector3)obj8;
											int num5 = num4;
											Source source4 = null;
											Along along4 = (Along)shape.at;
											while (true)
											{
												bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)source4) < System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref along4.z);
												object obj11 = !flag12;
												float num6 = (float)source4 - (float)along4.z;
												bool flag13 = num6 == 0f;
												bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)source4) >= System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref along4.z);
												vector = vector2;
												num = num5;
												source2 = source4;
												along3 = along4;
												if (flag14)
												{
													break;
												}
												Vector3 vector3 = ((List<Vector3>)along4).get_Item((int)source4);
												Vector3 vector4 = ((Along*)along)->In((Vector3)source4);
												vector = (Vector3)text;
												((List<Vector3>)along4).set_Item((int)source4, (Vector3)text);
												along3 = (Along)shape.faces;
												bool flag15 = shape.faces == null;
												along2 = along;
												source3 = source;
												num = (int)source4;
												obj3 = obj2;
												source2 = source4;
												num2 = sign;
												num3 = seed;
												if (!flag15)
												{
													Vector3 vector5 = shape.faces.get_Item((int)source4);
													Vector3 vector6 = ((Along*)along)->WayIn((Vector3)source4);
													vector = (Vector3)text;
													shape.faces.set_Item((int)source4, (Vector3)text);
													along3 = (Along)shape.at;
													source2 = (Source)(source4 + 1);
													bool flag16 = shape.at == null;
													object obj12 = !flag16;
													along2 = along;
													source3 = source;
													num = (int)source4;
													obj3 = obj2;
													num2 = sign;
													num3 = seed;
													vector2 = (Vector3)text;
													num5 = (int)source4;
													source4 = source2;
													along4 = (Along)shape.at;
													if (obj12 != null)
													{
														continue;
													}
												}
												goto IL_26eb;
											}
										}
										_ = 1019517862;
										object obj13 = obj10;
										bool flag17 = obj10 == null;
										along2 = along;
										source3 = source;
										obj3 = obj2;
										num2 = sign;
										num3 = seed;
										if (!flag17)
										{
											float num7 = 0f;
											num2 = sign;
											num3 = seed;
											string text3 = null;
											List<int> list = default;
											float num35 = default;
											float num33 = default;
											object obj23 = default;
											Vector3[] array2 = default;
											Vector3[] array4 = default;
											float num11 = default;
											double num13 = default;
											double num15 = default;
											float num17 = default;
											double num19 = default;
											double num25 = default;
											float num27 = default;
											double num29 = default;
											float num31 = default;
											double num37 = default;
											float num39 = default;
											double num41 = default;
											double num43 = default;
											float num45 = default;
											float num47 = default;
											double num49 = default;
											double num51 = default;
											float num53 = default;
											TimeSpan timeSpan = default;
											Func<Vector3, Vector3, bool> func = default;
											object obj25 = default;
											Func<Vector3, float> func2 = default;
											Half half = default;
											Func<Vector3, float> func3 = default;
											double num58 = default;
											double num21 = default;
											Vector3 vector15 = default;
											float num84 = default;
											int num86 = default;
											object obj71 = default;
											int num89 = default;
											float num90 = default;
											int num91 = default;
											float num92 = default;
											int num93 = default;
											float num94 = default;
											int num95 = default;
											float num96 = default;
											int num97 = default;
											float num98 = default;
											object obj107 = default;
											float num99 = default;
											object obj114 = default;
											int num101 = default;
											int num103 = default;
											float num104 = default;
											float num23 = default;
											int num106 = default;
											float num107 = default;
											object obj126 = default;
											object obj129 = default;
											object obj135 = default;
											IndexOutOfRangeException ex = default;
											while (true)
											{
												string text4 = text3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1692 @ X8_v98+18]");
												bool flag18 = (nint)text4 < 0;
												object obj11 = !flag18;
												float num8 = (float)text3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1692 @ X8_v98+18]");
												float num6 = num8 - 0f;
												bool flag13 = num6 == 0f;
												string text5 = text3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1692 @ X8_v98+18]");
												int num85;
												int num87;
												if ((nint)text5 < 0)
												{
													int[][] tris2 = source.tris;
													bool flag19 = source.tris == null;
													along2 = along;
													source3 = source;
													obj3 = obj2;
													if (flag19)
													{
														break;
													}
													bool flag20 = (nint)text3 < tris2.Length;
													obj11 = !flag20;
													num6 = (float)text3 - (float)tris2.Length;
													flag13 = num6 == 0f;
													along2 = along;
													if (obj11 == null)
													{
														object obj14 = source.tris + text3;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v121+20]");
														text = (string)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v121+20]");
														bool flag21 = (nint)0 == 0;
														along2 = along;
														text2 = text3;
														source3 = source;
														obj3 = obj2;
														if (flag21)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
														object obj15 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
														bool flag22 = (nint)0 < (nint)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
														nint num9 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
														object obj16 = num9 ^ 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
														object obj17 = 0 & obj16;
														bool flag23 = (nint)obj17 < 0;
														bool flag24 = flag22 == flag23;
														object obj18 = !flag24;
														object obj19;
														if ((int)(~obj18) == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
															obj19 = (nint)0 + (nint)1;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
															obj19 = 0;
														}
														num = obj19 >> 1;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
														object obj20 = 0;
														vector = (Vector3)obj20;
														list._002Ector(num);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
														object obj21 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
														bool flag25 = (nint)0 < (nint)1;
														obj11 = !flag25;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
														num6 = 0f - 1f;
														flag13 = num6 == 0f;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
														bool flag14 = (nint)0 < (nint)1;
														text2 = text3;
														if (flag14)
														{
															goto IL_193f;
														}
														float num10 = num11;
														double num12 = num13;
														double num14 = num15;
														float num16 = num17;
														double num18 = num19;
														double num20 = num21;
														float num22 = num23;
														double num24 = num25;
														float num26 = num27;
														double num28 = num29;
														object obj22 = obj23;
														Vector3[] array = array2;
														Vector3[] array3 = array4;
														float num30 = num31;
														float num32 = num33;
														float num34 = num35;
														double num36 = num37;
														float num38 = num39;
														double num40 = num41;
														double num42 = num43;
														float num44 = num45;
														float num46 = num47;
														double num48 = num49;
														double num50 = num51;
														float num52 = num53;
														object obj24 = obj25;
														bool flag26 = flag14;
														float num54 = num7;
														string text6 = text3;
														Vector3 vector7 = (Vector3)obj20;
														int num55 = num;
														int num56 = num2;
														int num57 = num3;
														Along along5 = (Along)0;
														while (true)
														{
															bool flag27 = along5 < obj21;
															obj11 = !flag27;
															num6 = (float)along5 - (float)obj21;
															flag13 = num6 == 0f;
															num11 = num10;
															num13 = num12;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num31 = num30;
															num33 = num32;
															num35 = num34;
															vector = vector7;
															num = num55;
															if (obj11 != null)
															{
																break;
															}
															bool flag28 = shape.at == null;
															num11 = num10;
															num13 = num12;
															num15 = num14;
															num17 = num16;
															num19 = num18;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num25 = num24;
															num27 = num26;
															num29 = num28;
															obj23 = obj22;
															array2 = array;
															array4 = array3;
															num31 = num30;
															num33 = num32;
															num35 = num34;
															num37 = num36;
															num39 = num38;
															num41 = num40;
															num43 = num42;
															num45 = num44;
															num47 = num46;
															num49 = num48;
															num51 = num50;
															num53 = num52;
															obj25 = obj24;
															flag14 = flag26;
															num7 = num54;
															text2 = text6;
															source3 = source;
															vector = vector7;
															num = num55;
															obj3 = obj2;
															source2 = (Source)(object)list;
															num2 = num56;
															num3 = num57;
															along3 = along5;
															if (flag28)
															{
																goto end_IL_4652;
															}
															num2 = (int)(text + along5);
															vector = (Vector3)obj9;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X23_v15 (System.Int32)+20]");
															num = 0;
															List<Vector3> at = shape.at;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X23_v15 (System.Int32)+20]");
															Vector3 vector8 = at.get_Item(0);
															object obj26 = along5 + 1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
															bool flag29 = (nint)obj26 < 0;
															obj11 = !flag29;
															float num59 = (float)obj26;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
															num6 = num59 - 0f;
															flag13 = num6 == 0f;
															num11 = num10;
															num13 = num12;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num31 = num30;
															num33 = num32;
															num35 = num34;
															if (obj11 != null)
															{
																break;
															}
															bool flag30 = shape.at == null;
															num11 = num10;
															num13 = num12;
															num15 = num14;
															num17 = num16;
															num19 = num18;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num25 = num24;
															num27 = num26;
															num29 = num28;
															obj23 = obj22;
															array2 = array;
															array4 = array3;
															num31 = num30;
															num33 = num32;
															num35 = num34;
															num37 = num36;
															num39 = num38;
															num41 = num40;
															num43 = num42;
															num45 = num44;
															num47 = num46;
															num49 = num48;
															num51 = num50;
															num53 = num52;
															obj25 = obj24;
															flag14 = flag26;
															num7 = num54;
															text2 = text6;
															source3 = source;
															obj3 = obj2;
															source2 = (Source)(object)list;
															num3 = num57;
															along3 = along5;
															if (flag30)
															{
																goto end_IL_4652;
															}
															obj25 = text + obj26;
															vector = (Vector3)obj9;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X29_v10+20]");
															num = 0;
															List<Vector3> at2 = shape.at;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X29_v10+20]");
															Vector3 vector9 = at2.get_Item(0);
															object obj27 = along5 + 2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
															bool flag31 = (nint)obj27 < 0;
															obj11 = !flag31;
															float num60 = (float)obj27;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
															num6 = num60 - 0f;
															flag13 = num6 == 0f;
															num11 = num10;
															num13 = num12;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num31 = num30;
															num33 = num32;
															num35 = num34;
															if (obj11 != null)
															{
																break;
															}
															bool flag32 = shape.at == null;
															num11 = num10;
															num13 = num12;
															num15 = num14;
															num17 = num16;
															num19 = num18;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num25 = num24;
															num27 = num26;
															num29 = num28;
															obj23 = obj22;
															array2 = array;
															array4 = array3;
															num31 = num30;
															num33 = num32;
															num35 = num34;
															num37 = num36;
															num39 = num38;
															num41 = num40;
															num43 = num42;
															num45 = num44;
															num47 = num46;
															num49 = num58;
															num51 = num20;
															num53 = num22;
															flag14 = flag26;
															num7 = num54;
															text2 = text6;
															source3 = source;
															obj3 = obj2;
															source2 = (Source)(object)list;
															num3 = num57;
															along3 = along5;
															if (flag32)
															{
																goto end_IL_4652;
															}
															num3 = (int)(text + obj27);
															vector = (Vector3)obj9;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+20]");
															num = 0;
															List<Vector3> at3 = shape.at;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+20]");
															Vector3 vector10 = at3.get_Item(0);
															Along along6 = along5;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
															bool flag33 = along6 < (object)0;
															obj11 = !flag33;
															float num61 = (float)along5;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
															num6 = num61 - 0f;
															flag13 = num6 == 0f;
															num11 = num10;
															num13 = num12;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num31 = num30;
															num33 = num32;
															num35 = num34;
															if (obj11 != null)
															{
																break;
															}
															bool flag34 = shape.faces == null;
															num11 = num10;
															num13 = num12;
															num15 = num14;
															num17 = num16;
															num19 = num18;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num25 = num24;
															num27 = num26;
															num29 = num28;
															obj23 = obj22;
															array2 = array;
															array4 = array3;
															num31 = num30;
															num33 = num32;
															num35 = num34;
															num37 = num36;
															num39 = num38;
															num41 = num20;
															num43 = num58;
															num45 = num54;
															num47 = num22;
															num49 = num58;
															num51 = num20;
															num53 = num22;
															flag14 = flag26;
															num7 = num54;
															text2 = text6;
															source3 = source;
															obj3 = obj2;
															source2 = (Source)(object)list;
															along3 = along5;
															if (flag34)
															{
																goto end_IL_4652;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X23_v15 (System.Int32)+20]");
															num = 0;
															vector = (Vector3)obj9;
															List<Vector3> faces = shape.faces;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X23_v15 (System.Int32)+20]");
															Vector3 vector11 = faces.get_Item(0);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
															obj21 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+10]");
															num35 = -0;
															float num62 = num22;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+14]");
															num33 = num62 * 0f;
															double num65;
															if (num33 < num35)
															{
																float num63 = num22;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+14]");
																num33 = num63 * 0f;
																if (num33 < num35)
																{
																	float num64 = num22;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+14]");
																	num33 = num64 * 0f;
																	if (num33 < num35)
																	{
																		num65 = num58;
																		goto IL_4200;
																	}
																}
															}
															bool flag35 = along5 < obj21;
															obj11 = !flag35;
															num6 = (float)along5 - (float)obj21;
															flag13 = num6 == 0f;
															num11 = num10;
															num13 = num12;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+14]");
															num31 = 0f;
															if (obj11 != null)
															{
																break;
															}
															bool flag36 = list == null;
															num11 = num10;
															num13 = num12;
															num15 = num14;
															num17 = num16;
															num19 = num18;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num25 = num24;
															num27 = num26;
															num29 = num28;
															obj23 = obj22;
															array2 = array;
															array4 = array3;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+14]");
															num31 = 0f;
															num37 = num20;
															num39 = num22;
															num41 = num20;
															num43 = num58;
															num45 = num54;
															num47 = num22;
															num49 = num58;
															num51 = num20;
															num53 = num22;
															num7 = (float)num58;
															text2 = text6;
															source3 = source;
															obj3 = obj2;
															source2 = (Source)(object)list;
															along3 = along5;
															if (flag36)
															{
																goto end_IL_4652;
															}
															text2 = ((Source)(object)list).name;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X23_v15 (System.Int32)+20]");
															num = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
															object obj28 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ X0_v244 (System.Collections.Generic.List`1<System.Int32>)+1C]");
															array2 = (Vector3[])((nint)0 + (nint)1);
															array4 = (Vector3[])obj28;
															bool flag37 = ((Source)(object)list).name == null;
															num11 = num10;
															num13 = num12;
															num15 = num14;
															num17 = num16;
															num19 = num18;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num25 = num24;
															num27 = num26;
															num29 = num28;
															obj23 = obj22;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+14]");
															num31 = 0f;
															num37 = num20;
															num39 = num22;
															num41 = num20;
															num43 = num58;
															num45 = num54;
															num47 = num22;
															num49 = num58;
															num51 = num20;
															num53 = num22;
															num7 = (float)num58;
															source3 = source;
															obj3 = obj2;
															source2 = (Source)(object)list;
															along3 = along5;
															if (flag37)
															{
																goto end_IL_4652;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2064 @ X9_v33 (System.String)+18]");
															obj23 = 0;
															Vector3[] at4 = ((Source)(object)list).at;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2064 @ X9_v33 (System.String)+18]");
															bool flag38 = (nint)at4 < 0;
															object obj29 = !flag38;
															if (obj29 == null)
															{
																object obj30 = ((Source)(object)list).name + ((Source)(object)list).at;
																Vector3[] at5 = (Vector3[])(((Source)(object)list).at + 1);
																((Source)(object)list).at = at5;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X23_v15 (System.Int32)+20]");
																_ = 0;
															}
															else
															{
																Vector3 vector12 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array4[0]);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2098 @ X8_v151 (UnityEngine.Vector3)+A8]");
																object obj31 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2100 @ X8_v152+70]");
																vector = (Vector3)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X23_v15 (System.Int32)+20]");
																list.AddWithResize(0);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
																obj21 = 0;
															}
															bool flag39 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21);
															obj11 = !flag39;
															num6 = (float)obj26 - (float)obj21;
															flag13 = num6 == 0f;
															num11 = num10;
															num13 = num12;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+14]");
															num31 = 0f;
															if (obj11 != null)
															{
																break;
															}
															text2 = ((Source)(object)list).name;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X29_v10+20]");
															num = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
															object obj32 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ X0_v244 (System.Collections.Generic.List`1<System.Int32>)+1C]");
															array2 = (Vector3[])((nint)0 + (nint)1);
															array4 = (Vector3[])obj32;
															bool flag40 = ((Source)(object)list).name == null;
															num11 = num10;
															num13 = num12;
															num15 = num14;
															num17 = num16;
															num19 = num18;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num25 = num58;
															num27 = num22;
															num29 = num20;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+14]");
															num31 = 0f;
															num37 = num20;
															num39 = num22;
															num41 = num20;
															num43 = num58;
															num45 = num54;
															num47 = num22;
															num49 = num58;
															num51 = num20;
															num53 = num22;
															num7 = (float)num58;
															source3 = source;
															obj3 = obj2;
															source2 = (Source)(object)list;
															along3 = along5;
															if (flag40)
															{
																goto end_IL_4652;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2064 @ X9_v33 (System.String)+18]");
															obj23 = 0;
															Vector3[] at6 = ((Source)(object)list).at;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2064 @ X9_v33 (System.String)+18]");
															bool flag41 = (nint)at6 < 0;
															object obj33 = !flag41;
															if (obj33 == null)
															{
																object obj34 = ((Source)(object)list).name + ((Source)(object)list).at;
																Vector3[] at7 = (Vector3[])(((Source)(object)list).at + 1);
																((Source)(object)list).at = at7;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X29_v10+20]");
																_ = 0;
															}
															else
															{
																Vector3 vector13 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array4[0]);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2126 @ X8_v148 (UnityEngine.Vector3)+A8]");
																object obj35 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2128 @ X8_v149+70]");
																vector = (Vector3)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X29_v10+20]");
																list.AddWithResize(0);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
																obj21 = 0;
															}
															bool flag42 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21);
															obj11 = !flag42;
															num6 = (float)obj27 - (float)obj21;
															flag13 = num6 == 0f;
															num11 = num10;
															num13 = num12;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+14]");
															num31 = 0f;
															if (obj11 != null)
															{
																break;
															}
															text2 = ((Source)(object)list).name;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+20]");
															num = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
															object obj36 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ X0_v244 (System.Collections.Generic.List`1<System.Int32>)+1C]");
															array2 = (Vector3[])((nint)0 + (nint)1);
															array4 = (Vector3[])obj36;
															bool flag43 = ((Source)(object)list).name == null;
															num11 = num10;
															num13 = num12;
															num15 = num14;
															num17 = num16;
															num19 = num18;
															num58 = num58;
															num21 = num20;
															along2 = along;
															num23 = num22;
															num25 = num58;
															num27 = num22;
															num29 = num20;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+14]");
															num31 = 0f;
															num37 = num20;
															num39 = num22;
															num41 = num20;
															num43 = num58;
															num45 = num54;
															num47 = num22;
															num49 = num58;
															num51 = num20;
															num53 = num22;
															num7 = (float)num58;
															source3 = source;
															obj3 = obj2;
															source2 = (Source)(object)list;
															along3 = along5;
															if (flag43)
															{
																goto end_IL_4652;
															}
															array = ((Source)(object)list).at;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2064 @ X9_v33 (System.String)+18]");
															obj22 = 0;
															Vector3[] at8 = ((Source)(object)list).at;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2064 @ X9_v33 (System.String)+18]");
															bool flag44 = (nint)at8 < 0;
															object obj37 = !flag44;
															if (obj37 == null)
															{
																text2 += ((Source)(object)list).at;
																array4 = (((Source)(object)list).at = (Vector3[])(((Source)(object)list).at + 1));
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+20]");
																_ = 0;
															}
															else
															{
																Vector3 vector14 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array4[0]);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2154 @ X8_v145 (UnityEngine.Vector3)+A8]");
																object obj38 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2156 @ X8_v146+70]");
																vector = (Vector3)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+20]");
																list.AddWithResize(0);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
																obj21 = 0;
															}
															num24 = num58;
															num26 = num22;
															num28 = num20;
															array3 = array4;
															num65 = num58;
															text6 = text2;
															goto IL_4200;
															IL_4200:
															num19 = num20 - num20;
															double num66 = num65 - num58;
															along3 = (Along)(along5 + 3);
															num15 = num20 - num20;
															double num67 = num58 - num58;
															float num68 = num22 - num22;
															num35 = num22 - num22;
															bool flag45 = along3 < obj21;
															obj11 = !flag45;
															num6 = (float)along3 - (float)obj21;
															flag13 = num6 == 0f;
															double num69 = num19 * num67;
															double num70 = num66 * num15;
															num17 = (float)num66 * num35;
															float num71 = num68 * (float)num67;
															num31 = num68 * (float)num15;
															num13 = num69 - num70;
															num11 = num17 - num71;
															float num72 = (float)num19 * num35;
															float num73 = (float)num13 * num22;
															num33 = num31 - num72;
															float num74 = num11 * (float)num20;
															float num75 = num73 + num74;
															float num76 = num33 * (float)num58;
															num23 = num76 + num75;
															num7 = num54 + num23;
															flag14 = along3 < obj21;
															num58 = num58;
															num21 = num75;
															num25 = num24;
															num27 = num26;
															num29 = num28;
															obj23 = obj22;
															array2 = array;
															array4 = array3;
															num37 = num20;
															num39 = num22;
															num41 = num20;
															num43 = num58;
															num45 = num54;
															num47 = num22;
															num49 = num58;
															num51 = num20;
															num53 = num22;
															text2 = text6;
															num10 = num11;
															num12 = num13;
															num14 = num15;
															num16 = num17;
															num18 = num19;
															num20 = num75;
															num22 = num23;
															num30 = num31;
															num32 = num33;
															num34 = num35;
															num36 = num75;
															num38 = num23;
															num40 = num75;
															num42 = num58;
															num44 = num54;
															num46 = num23;
															num48 = num58;
															num50 = num75;
															num52 = num23;
															obj24 = obj25;
															flag26 = flag14;
															num54 = num7;
															vector7 = vector;
															num55 = num;
															num56 = num2;
															num57 = num3;
															along5 = along3;
															if (flag14)
															{
																continue;
															}
															goto IL_193f;
														}
													}
												}
												else
												{
													bool flag46 = stopwatch == null;
													along2 = along;
													source3 = source;
													obj3 = obj2;
													if (flag46)
													{
														break;
													}
													TimeSpan elapsed = stopwatch.Elapsed;
													int num77 = (int)(&result);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
													obj9 = 0;
													object obj39 = obj9;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
													text = (string)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1732 @ X8_v100+E4]");
													bool flag47 = (nint)0 == 0;
													object obj40 = !flag47;
													if (obj40 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													double totalMilliseconds = timeSpan.TotalMilliseconds;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+18]");
													bool flag48 = (nint)0 == 9;
													Along along7 = along;
													int num78 = (int)vector;
													if (!flag48)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6900]");
														object obj41 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6950]");
														object obj42 = 0;
														func._002Ector(obj2, (IntPtr)obj42);
														shape.Refine(func, 5);
														along7 = (Along)0;
														num78 = 5;
													}
													TimeSpan elapsed2 = stopwatch.Elapsed;
													object obj43 = obj9;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1815 @ X8_v103+E4]");
													bool flag49 = (nint)0 == 0;
													object obj44 = !flag49;
													if (obj44 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													double totalMilliseconds2 = timeSpan.TotalMilliseconds;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68F8]");
													obj25 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6958]");
													object obj45 = 0;
													func2._002Ector(obj2, (IntPtr)obj45);
													List<(int, int)> list2 = shape.Clip(func2);
													TimeSpan elapsed3 = stopwatch.Elapsed;
													double totalMilliseconds3 = timeSpan.TotalMilliseconds;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6908]");
													object obj46 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													half._002Ector();
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													func3._002Ector(obj2, (IntPtr)obj45);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF4]");
													num21 = 0.0;
													nint num79 = (nint)text;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+18]");
													bool flag50 = (nint)0 < (nint)9;
													obj11 = !flag50;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+18]");
													num6 = 0f - 9f;
													flag13 = num6 == 0f;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+18]");
													double num80;
													if ((nint)0 == 9)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF4]");
														num80 = 0.0;
													}
													else
													{
														num80 = 1.0;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1949 @ X0_v208 (Il2CppClass<System.String>)+E4]");
													bool flag51 = (nint)0 == 0;
													object obj47 = !flag51;
													if (obj47 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Built built = Skin(shape, source, func3, (float)num80);
													bool flag52 = half == null;
													along2 = (Along)0;
													num23 = (float)num80;
													text2 = (string)17276928;
													source3 = source;
													vector = (Vector3)func3;
													num = (int)source;
													obj3 = obj2;
													source2 = (Source)(object)func3;
													num2 = (int)(&result);
													num3 = (int)half;
													along3 = (Along)list2;
													if (flag52)
													{
														break;
													}
													source2 = (Source)(half + 16);
													source2 = (Source)(object)built;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													TimeSpan elapsed4 = stopwatch.Elapsed;
													object obj48 = obj9;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2030 @ X8_v108+E4]");
													text2 = (string)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2030 @ X8_v108+E4]");
													bool flag53 = (nint)0 == 0;
													object obj49 = !flag53;
													if (obj49 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													double totalMilliseconds4 = timeSpan.TotalMilliseconds;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1930 @ X0_v205 (GillaRip+Half)+50]");
													object obj50 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1930 @ X0_v205 (GillaRip+Half)+50]");
													bool flag54 = (nint)0 == 0;
													along2 = (Along)0;
													num23 = (float)totalMilliseconds4;
													source3 = source;
													vector = (Vector3)func3;
													num = 0;
													obj3 = obj2;
													num2 = (int)(&result);
													num3 = (int)half;
													along3 = (Along)list2;
													if (flag54)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v109+18]");
													text2 = (string)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v109+18]");
													bool flag55 = (nint)0 == 0;
													along2 = (Along)0;
													num23 = (float)totalMilliseconds4;
													vector = (Vector3)func3;
													num = 0;
													if (!flag55)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v109+18]");
														bool flag56 = (nint)0 == 1;
														num21 = totalMilliseconds;
														along2 = (Along)0;
														num23 = (float)totalMilliseconds4;
														vector = (Vector3)func3;
														num = 0;
														if (!flag56)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v109+18]");
															bool flag57 = (nint)0 < (nint)2;
															object obj51 = !flag57;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v109+18]");
															object obj52 = -2;
															bool flag58 = obj52 == null;
															num21 = totalMilliseconds2 - totalMilliseconds;
															object obj53 = ~obj51;
															bool flag14 = (byte)((obj53 | flag58) ? 1 : 0) != 0;
															num58 = totalMilliseconds2;
															along2 = (Along)0;
															num23 = (float)totalMilliseconds4;
															vector = (Vector3)func3;
															num = 0;
															if (!flag14)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v109+18]");
																bool flag59 = (nint)0 < (nint)3;
																obj11 = !flag59;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v109+18]");
																num6 = 0f - 3f;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v109+18]");
																flag13 = (nint)0 == 3;
																num58 = totalMilliseconds3 - totalMilliseconds2;
																num21 = totalMilliseconds3;
																along2 = (Along)0;
																num23 = (float)totalMilliseconds4;
																vector = (Vector3)func3;
																num = 0;
																if (!flag13)
																{
																	num23 = (float)totalMilliseconds4 - (float)totalMilliseconds3;
																	bool flag60 = list2 == null;
																	num21 = totalMilliseconds3;
																	along2 = (Along)0;
																	source3 = source;
																	vector = (Vector3)func3;
																	num = 0;
																	obj3 = obj2;
																	num2 = (int)(&result);
																	num3 = (int)half;
																	along3 = (Along)list2;
																	if (flag60)
																	{
																		break;
																	}
																	bool flag61 = num7 < 0f;
																	obj11 = !flag61;
																	flag13 = num7 == 0f;
																	nint num81 = (nint)text;
																	_ = ((Along*)(nint)list2)->z;
																	double num82 = ((!(num7 < 0f)) ? 1.0 : (-1.0));
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2145 @ X0_v218 (Il2CppClass<System.String>)+E4]");
																	bool flag62 = (nint)0 == 0;
																	object obj54 = !flag62;
																	if (obj54 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+14]");
																	nint num83 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (System.Object)+18]");
																	Bowl(shape, list2, source, half, (int)num83, 0, (float)num82, stopwatch);
																	bool isMiddle2 = ((Along*)along)->IsMiddle;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
																	obj9 = 0;
																	bool flag63 = !isMiddle2;
																	object obj55 = !flag63;
																	num21 = -1.0;
																	if (obj55 == null)
																	{
																		object obj56 = obj9;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [along @ X3 (GillaRip+Along)+10]");
																		num21 = 0.0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2182 @ X0_v228+E4]");
																		text2 = (string)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2182 @ X0_v228+E4]");
																		bool flag64 = (nint)0 == 0;
																		object obj57 = !flag64;
																		if (obj57 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		Back(half, (Along)(&vector15));
																		num84 = (float)along.n;
																	}
																	long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
																	bool isMiddle3 = ((Along*)along)->IsMiddle;
																	bool flag65 = !isMiddle3;
																	num85 = (int)half;
																	along2 = (Along)half;
																	num23 = elapsedMilliseconds;
																	num6 = num7;
																	source3 = source;
																	vector = (Vector3)source;
																	num = 0;
																	obj3 = obj2;
																	num2 = (int)(&result);
																	num3 = (int)half;
																	along3 = (Along)list2;
																	text = (string)along;
																	if (!flag65)
																	{
																		goto IL_24ba;
																	}
																	object obj58 = obj9;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+50]");
																	object obj59 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X0_v11+E4]");
																	bool flag66 = (nint)0 == 0;
																	object obj60 = !flag66;
																	if (obj60 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		obj58 = obj9;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X0_v11+A0]");
																	object obj61 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
																	object obj62 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																	bool flag67 = num86 == 0;
																	num = 9;
																	if (flag67)
																	{
																		break;
																	}
																	bool flag68 = source3.name == null;
																	num = 9;
																	if (!flag68)
																	{
																		int value = ((int*)num86)->m_value;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v79 (System.Int32)+40]");
																		num = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																		bool flag69 = ex == null;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v79 (System.Int32)+40]");
																		num87 = 0;
																		if (flag69)
																		{
																			goto IL_40a5;
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																	if ((nint)0 != 0)
																	{
																		object obj63 = num86 + 32;
																		obj63 = source3.name;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
																		text2 = (string)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X21_v5 (System.Object)+14]");
																		bool flag70 = (nint)0 < (nint)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X21_v5 (System.Object)+14]");
																		bool flag71 = (nint)0 == 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X21_v5 (System.Object)+14]");
																		nint num88 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X21_v5 (System.Object)+14]");
																		object obj64 = num88 ^ 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X21_v5 (System.Object)+14]");
																		object obj65 = 0 & obj64;
																		bool flag72 = (nint)obj65 < 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6970]");
																		object obj66 = 0;
																		bool flag73 = flag70 == flag72;
																		object obj67 = !flag71;
																		object obj68 = flag73 & obj67;
																		if ((int)(~obj68) != 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
																			text2 = (string)0;
																		}
																		text = (string)obj66;
																		bool flag74 = text2 == null;
																		num = (int)source3.name;
																		if (!flag74)
																		{
																			int value2 = ((int*)num86)->m_value;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v78 (System.Int32)+40]");
																			num = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																			bool flag75 = ex == null;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v78 (System.Int32)+40]");
																			num87 = 0;
																			if (flag75)
																			{
																				goto IL_40a5;
																			}
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																		object obj69 = 0 & 0xFFFFFFFEL;
																		if (obj69 != null)
																		{
																			object obj70 = num86 + 40;
																			obj70 = text2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
																			along3 = (Along)0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																			bool flag76 = obj71 == null;
																			num = (int)(&num84);
																			if (!flag76)
																			{
																				int value3 = ((int*)num86)->m_value;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1395 @ X8_v77 (System.Int32)+40]");
																				num = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																				bool flag77 = ex == null;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+40]");
																				num23 = 0f;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1395 @ X8_v77 (System.Int32)+40]");
																				num87 = 0;
																				if (flag77)
																				{
																					goto IL_40a5;
																				}
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																			bool flag78 = (nint)0 < (nint)2;
																			obj11 = !flag78;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																			num6 = 0f - 2f;
																			flag13 = num6 == 0f;
																			object obj72 = ~obj11;
																			flag14 = (byte)((obj72 | flag13) ? 1 : 0) != 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+40]");
																			num23 = 0f;
																			if (!flag14)
																			{
																				object obj73 = num86 + 48;
																				obj73 = obj71;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+50]");
																				bool flag79 = (nint)0 == 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+40]");
																				num84 = 0f;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+40]");
																				num23 = 0f;
																				num = (int)obj71;
																				obj3 = obj71;
																				num2 = num86;
																				if (flag79)
																				{
																					break;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																				bool flag80 = (nint)0 == 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+40]");
																				num23 = 0f;
																				num = (int)obj71;
																				if (!flag80)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																					bool flag81 = num89 == 0;
																					num = (int)(&num90);
																					if (!flag81)
																					{
																						int value4 = ((int*)num86)->m_value;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X8_v76 (System.Int32)+40]");
																						num = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																						bool flag82 = ex == null;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+20]");
																						num23 = 0f;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X8_v76 (System.Int32)+40]");
																						num87 = 0;
																						if (flag82)
																						{
																							goto IL_40a5;
																						}
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																					object obj74 = 0 & 0xFFFFFFFCL;
																					bool flag83 = obj74 == null;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+20]");
																					num23 = 0f;
																					if (!flag83)
																					{
																						object obj75 = num86 + 56;
																						obj75 = num89;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																						object obj76 = 0 & 0xFFFFFFFEL;
																						bool flag84 = obj76 == null;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+20]");
																						num23 = 0f;
																						num = num89;
																						if (!flag84)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																							bool flag85 = num91 == 0;
																							num = (int)(&num92);
																							if (!flag85)
																							{
																								int value5 = ((int*)num86)->m_value;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ X8_v75 (System.Int32)+40]");
																								num = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																								bool flag86 = ex == null;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+24]");
																								num23 = 0f;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ X8_v75 (System.Int32)+40]");
																								num87 = 0;
																								if (flag86)
																								{
																									goto IL_40a5;
																								}
																							}
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																							bool flag87 = (nint)0 < (nint)4;
																							object obj77 = !flag87;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																							object obj78 = -4;
																							bool flag88 = obj78 == null;
																							object obj79 = ~obj77;
																							object obj80 = obj79 | flag88;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+24]");
																							num23 = 0f;
																							if (obj80 == null)
																							{
																								object obj81 = num86 + 64;
																								obj81 = num91;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																								bool flag89 = (nint)0 < (nint)2;
																								object obj82 = !flag89;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																								object obj83 = -2;
																								bool flag90 = obj83 == null;
																								object obj84 = ~obj82;
																								object obj85 = obj84 | flag90;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+24]");
																								num23 = 0f;
																								num = num91;
																								if (obj85 == null)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																									bool flag91 = num93 == 0;
																									num = (int)(&num94);
																									if (!flag91)
																									{
																										int value6 = ((int*)num86)->m_value;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v74 (System.Int32)+40]");
																										num = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																										bool flag92 = ex == null;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+28]");
																										num23 = 0f;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v74 (System.Int32)+40]");
																										num87 = 0;
																										if (flag92)
																										{
																											goto IL_40a5;
																										}
																									}
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																									bool flag93 = (nint)0 < (nint)5;
																									object obj86 = !flag93;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																									object obj87 = -5;
																									bool flag94 = obj87 == null;
																									object obj88 = ~obj86;
																									object obj89 = obj88 | flag94;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+28]");
																									num23 = 0f;
																									if (obj89 == null)
																									{
																										object obj90 = num86 + 72;
																										obj90 = num93;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																										object obj91 = 0 & 0xFFFFFFFCL;
																										bool flag95 = obj91 == null;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+28]");
																										num23 = 0f;
																										num = num93;
																										if (!flag95)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																											bool flag96 = num95 == 0;
																											num = (int)(&num96);
																											if (!flag96)
																											{
																												int value7 = ((int*)num86)->m_value;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X8_v73 (System.Int32)+40]");
																												num = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																												bool flag97 = ex == null;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+2C]");
																												num23 = 0f;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X8_v73 (System.Int32)+40]");
																												num87 = 0;
																												if (flag97)
																												{
																													goto IL_40a5;
																												}
																											}
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																											bool flag98 = (nint)0 < (nint)6;
																											object obj92 = !flag98;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																											object obj93 = -6;
																											bool flag99 = obj93 == null;
																											object obj94 = ~obj92;
																											object obj95 = obj94 | flag99;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+2C]");
																											num23 = 0f;
																											if (obj95 == null)
																											{
																												object obj96 = num86 + 80;
																												obj96 = num95;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																												bool flag100 = (nint)0 < (nint)4;
																												object obj97 = !flag100;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																												object obj98 = -4;
																												bool flag101 = obj98 == null;
																												object obj99 = ~obj97;
																												object obj100 = obj99 | flag101;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+2C]");
																												num23 = 0f;
																												num = num95;
																												if (obj100 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																													bool flag102 = num97 == 0;
																													num = (int)(&num98);
																													if (!flag102)
																													{
																														int value8 = ((int*)num86)->m_value;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1400 @ X8_v72 (System.Int32)+40]");
																														num = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																														bool flag103 = ex == null;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+30]");
																														num23 = 0f;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1400 @ X8_v72 (System.Int32)+40]");
																														num87 = 0;
																														if (flag103)
																														{
																															goto IL_40a5;
																														}
																													}
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																													object obj101 = 0 & 0xFFFFFFF8L;
																													bool flag104 = obj101 == null;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+30]");
																													num23 = 0f;
																													if (!flag104)
																													{
																														object obj102 = num86 + 88;
																														obj102 = num97;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																														bool flag105 = (nint)0 < (nint)5;
																														object obj103 = !flag105;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																														object obj104 = -5;
																														bool flag106 = obj104 == null;
																														object obj105 = ~obj103;
																														object obj106 = obj105 | flag106;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+30]");
																														num23 = 0f;
																														num = num97;
																														if (obj106 == null)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																															bool flag107 = obj107 == null;
																															num = (int)(&num99);
																															if (!flag107)
																															{
																																int value9 = ((int*)num86)->m_value;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ X8_v71 (System.Int32)+40]");
																																num = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																																bool flag108 = ex == null;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+34]");
																																num23 = 0f;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ X8_v71 (System.Int32)+40]");
																																num87 = 0;
																																if (flag108)
																																{
																																	goto IL_40a5;
																																}
																															}
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																															bool flag109 = (nint)0 < (nint)8;
																															object obj108 = !flag109;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v13 (System.Int32)+18]");
																															object obj109 = -8;
																															bool flag110 = obj109 == null;
																															object obj110 = ~obj108;
																															object obj111 = obj110 | flag110;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+34]");
																															num23 = 0f;
																															if (obj111 == null)
																															{
																																object obj112 = num86 + 96;
																																obj112 = obj107;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																string text7 = string.Format(text, (object[])num86);
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																																bool flag111 = (nint)0 < (nint)6;
																																obj11 = !flag111;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																																num6 = 0f - 6f;
																																flag13 = num6 == 0f;
																																object obj113 = ~obj11;
																																flag14 = (byte)((obj113 | flag13) ? 1 : 0) != 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+34]");
																																num23 = 0f;
																																vector = (Vector3)0;
																																num = 6;
																																if (!flag14)
																																{
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																																	bool flag112 = obj114 == null;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+38]");
																																	float num100 = 0f;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+34]");
																																	num99 = 0f;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+30]");
																																	num98 = 0f;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+2C]");
																																	num96 = 0f;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+28]");
																																	num94 = 0f;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+24]");
																																	num92 = 0f;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+20]");
																																	num90 = 0f;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+40]");
																																	num84 = 0f;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+38]");
																																	num23 = 0f;
																																	vector = (Vector3)0;
																																	num = (int)(&num100);
																																	obj3 = obj114;
																																	num2 = num86;
																																	text = text7;
																																	if (flag112)
																																	{
																																		break;
																																	}
																																	bool flag113 = num101 == 0;
																																	num = (int)(&num100);
																																	if (!flag113)
																																	{
																																		nint num102 = (nint)obj114;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X8_v70 (Il2CppClass<System.Object>)+40]");
																																		num = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																																		bool flag114 = ex == null;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+38]");
																																		num23 = 0f;
																																		vector = (Vector3)0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X8_v70 (Il2CppClass<System.Object>)+40]");
																																		num87 = 0;
																																		if (flag114)
																																		{
																																			goto IL_40a5;
																																		}
																																	}
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v67 (System.Object)+18]");
																																	bool flag115 = (nint)0 == 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+38]");
																																	num23 = 0f;
																																	vector = (Vector3)0;
																																	if (!flag115)
																																	{
																																		object obj115 = obj114 + 32;
																																		obj115 = num101;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																																		object obj116 = 0 & 0xFFFFFFF8L;
																																		bool flag116 = obj116 == null;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+38]");
																																		num23 = 0f;
																																		vector = (Vector3)0;
																																		num = num101;
																																		if (!flag116)
																																		{
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																																			bool flag117 = num103 == 0;
																																			num = (int)(&num104);
																																			if (!flag117)
																																			{
																																				nint num105 = (nint)obj114;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1403 @ X8_v69 (Il2CppClass<System.Object>)+40]");
																																				num = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																																				bool flag118 = ex == null;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+3C]");
																																				num23 = 0f;
																																				vector = (Vector3)0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1403 @ X8_v69 (Il2CppClass<System.Object>)+40]");
																																				num87 = 0;
																																				if (flag118)
																																				{
																																					goto IL_40a5;
																																				}
																																			}
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v67 (System.Object)+18]");
																																			object obj117 = 0 & 0xFFFFFFFEL;
																																			bool flag119 = obj117 == null;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+3C]");
																																			num23 = 0f;
																																			vector = (Vector3)0;
																																			if (!flag119)
																																			{
																																				object obj118 = obj114 + 40;
																																				obj118 = num103;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																																				bool flag120 = (nint)0 < (nint)8;
																																				object obj119 = !flag120;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+18]");
																																				object obj120 = -8;
																																				bool flag121 = obj120 == null;
																																				object obj121 = ~obj119;
																																				object obj122 = obj121 | flag121;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+3C]");
																																				num23 = 0f;
																																				vector = (Vector3)0;
																																				num = num103;
																																				if (obj122 == null)
																																				{
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+40]");
																																					num23 = 0f;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																																					bool flag122 = num106 == 0;
																																					num = (int)(&num107);
																																					if (!flag122)
																																					{
																																						nint num108 = (nint)obj114;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X8_v68 (Il2CppClass<System.Object>)+40]");
																																						num = 0;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																																						bool flag123 = ex == null;
																																						vector = (Vector3)0;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X8_v68 (Il2CppClass<System.Object>)+40]");
																																						num87 = 0;
																																						if (flag123)
																																						{
																																							goto IL_40a5;
																																						}
																																					}
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v67 (System.Object)+18]");
																																					bool flag124 = (nint)0 < (nint)2;
																																					obj11 = !flag124;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v67 (System.Object)+18]");
																																					num6 = 0f - 2f;
																																					flag13 = num6 == 0f;
																																					object obj123 = ~obj11;
																																					flag14 = (byte)((obj123 | flag13) ? 1 : 0) != 0;
																																					vector = (Vector3)0;
																																					if (!flag14)
																																					{
																																						object obj124 = obj114 + 48;
																																						obj124 = num106;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6968]");
																																						text2 = (string)0;
																																						nint num109 = (nint)source2;
																																						num2 = (int)text2;
																																						if (source2 != null)
																																						{
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2247 @ X8_v47 (Il2CppClass<GillaRip+Source>)+18]");
																																							object obj125 = 0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2247 @ X8_v47 (Il2CppClass<GillaRip+Source>)+18]");
																																							bool flag125 = (nint)0 == 0;
																																							num107 = num23;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+3C]");
																																							num104 = 0f;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+38]");
																																							num100 = 0f;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+34]");
																																							num99 = 0f;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+30]");
																																							num98 = 0f;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+2C]");
																																							num96 = 0f;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+28]");
																																							num94 = 0f;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+24]");
																																							num92 = 0f;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+20]");
																																							num90 = 0f;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+40]");
																																							num84 = 0f;
																																							vector = (Vector3)0;
																																							num = num106;
																																							obj3 = obj114;
																																							text = text7;
																																							if (flag125)
																																							{
																																								break;
																																							}
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v66+18]");
																																							num109 = 0;
																																						}
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																																						bool flag126 = obj126 == null;
																																						num = (int)(&num84);
																																						if (!flag126)
																																						{
																																							nint num110 = (nint)obj114;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1405 @ X8_v65 (Il2CppClass<System.Object>)+40]");
																																							num = 0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																																							bool flag127 = ex == null;
																																							vector = (Vector3)0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1405 @ X8_v65 (Il2CppClass<System.Object>)+40]");
																																							num87 = 0;
																																							if (flag127)
																																							{
																																								goto IL_40a5;
																																							}
																																						}
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v67 (System.Object)+18]");
																																						object obj127 = 0 & 0xFFFFFFFCL;
																																						bool flag128 = obj127 == null;
																																						vector = (Vector3)0;
																																						if (!flag128)
																																						{
																																							object obj128 = obj114 + 56;
																																							obj128 = obj126;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																																							bool flag129 = obj129 == null;
																																							num = (int)(&num90);
																																							if (!flag129)
																																							{
																																								nint num111 = (nint)obj114;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v64 (Il2CppClass<System.Object>)+40]");
																																								num = 0;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																																								bool flag130 = ex == null;
																																								vector = (Vector3)0;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v64 (Il2CppClass<System.Object>)+40]");
																																								num87 = 0;
																																								if (flag130)
																																								{
																																									goto IL_40a5;
																																								}
																																							}
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v67 (System.Object)+18]");
																																							bool flag131 = (nint)0 < (nint)4;
																																							object obj130 = !flag131;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v67 (System.Object)+18]");
																																							object obj131 = -4;
																																							bool flag132 = obj131 == null;
																																							object obj132 = ~obj130;
																																							object obj133 = obj132 | flag132;
																																							vector = (Vector3)0;
																																							if (obj133 == null)
																																							{
																																								object obj134 = obj114 + 64;
																																								obj134 = obj129;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																																								bool flag133 = obj135 == null;
																																								num = (int)(&num92);
																																								if (!flag133)
																																								{
																																									nint num112 = (nint)obj114;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X8_v63 (Il2CppClass<System.Object>)+40]");
																																									num = 0;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																																									bool flag134 = ex == null;
																																									vector = (Vector3)0;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X8_v63 (Il2CppClass<System.Object>)+40]");
																																									num87 = 0;
																																									if (flag134)
																																									{
																																										goto IL_40a5;
																																									}
																																								}
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v67 (System.Object)+18]");
																																								bool flag135 = (nint)0 < (nint)5;
																																								obj11 = !flag135;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v67 (System.Object)+18]");
																																								num6 = 0f - 5f;
																																								flag13 = num6 == 0f;
																																								object obj136 = ~obj11;
																																								flag14 = (byte)((obj136 | flag13) ? 1 : 0) != 0;
																																								vector = (Vector3)0;
																																								if (!flag14)
																																								{
																																									object obj137 = obj114 + 72;
																																									obj137 = obj135;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																									string text8 = string.Format((string)num2, (object[])obj114);
																																									string text9 = text7 + text8;
																																									bool flag136 = obj61 == null;
																																									num107 = num23;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+3C]");
																																									num104 = 0f;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+38]");
																																									num100 = 0f;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+34]");
																																									num99 = 0f;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+30]");
																																									num98 = 0f;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+2C]");
																																									num96 = 0f;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+28]");
																																									num94 = 0f;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+5C]");
																																									num92 = 0f;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+58]");
																																									num90 = 0f;
																																									num84 = num109;
																																									vector = (Vector3)0;
																																									num = (int)text8;
																																									obj3 = obj114;
																																									text = text7;
																																									if (flag136)
																																									{
																																										break;
																																									}
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68E0]");
																																									object obj138 = 0;
																																									vector = (Vector3)obj138;
																																									((ConcurrentQueue<System.__Canon>)obj61).Enqueue((System.__Canon)(object)text9);
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68F0]");
																																									text = (string)0;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C68E8]");
																																									object obj139 = 0;
																																									num = (int)text9;
																																									while (true)
																																									{
																																										object obj140 = obj9;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2309 @ X0_v111+E4]");
																																										bool flag137 = (nint)0 == 0;
																																										object obj141 = !flag137;
																																										if (obj141 == null)
																																										{
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																																											obj140 = obj9;
																																										}
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2309 @ X0_v111+A0]");
																																										object obj142 = 0;
																																										bool flag138 = obj142 == null;
																																										num107 = num23;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+3C]");
																																										num104 = 0f;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+38]");
																																										num100 = 0f;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+34]");
																																										num99 = 0f;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+30]");
																																										num98 = 0f;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+2C]");
																																										num96 = 0f;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+28]");
																																										num94 = 0f;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+5C]");
																																										num92 = 0f;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+58]");
																																										num90 = 0f;
																																										num84 = num109;
																																										obj3 = obj114;
																																										if (flag138)
																																										{
																																											break;
																																										}
																																										num = (int)text;
																																										int count = ((ConcurrentQueue<System.__Canon>)obj142).Count;
																																										bool flag139 = count < 64;
																																										obj11 = !flag139;
																																										num6 = (float)count - 64f;
																																										flag13 = num6 == 0f;
																																										flag14 = count <= 64;
																																										num85 = num3;
																																										if (!flag14)
																																										{
																																											object obj143 = obj9;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2319 @ X0_v115+E4]");
																																											bool flag140 = (nint)0 == 0;
																																											object obj144 = !flag140;
																																											if (obj144 == null)
																																											{
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																																												obj143 = obj9;
																																											}
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2319 @ X0_v115+A0]");
																																											object obj145 = 0;
																																											bool flag141 = obj145 == null;
																																											num107 = num23;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+3C]");
																																											num104 = 0f;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+38]");
																																											num100 = 0f;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+34]");
																																											num99 = 0f;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+30]");
																																											num98 = 0f;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+2C]");
																																											num96 = 0f;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X24_v4+28]");
																																											num94 = 0f;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+5C]");
																																											num92 = 0f;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X22_v13 (System.Int32)+58]");
																																											num90 = 0f;
																																											num84 = num109;
																																											obj3 = obj114;
																																											if (flag141)
																																											{
																																												break;
																																											}
																																											vector = (Vector3)obj139;
																																											bool flag142 = ((ConcurrentQueue<System.__Canon>)obj145).TryDequeue(out result);
																																											num = (int)(&result);
																																											continue;
																																										}
																																										goto IL_24ba;
																																									}
																																									break;
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
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
												goto IL_408f;
												IL_408f:
												ex = new IndexOutOfRangeException();
												num87 = num;
												goto IL_40a5;
												IL_193f:
												text = (string)obj10;
												bool flag143 = obj10 == null;
												along2 = along;
												source3 = source;
												obj3 = obj2;
												source2 = (Source)(object)list;
												if (flag143)
												{
													break;
												}
												if (list != null)
												{
													nint num113 = (nint)text;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1393 @ X8_v135 (Il2CppClass<System.String>)+40]");
													num = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag144 = ex == null;
													along2 = along;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1393 @ X8_v135 (Il2CppClass<System.String>)+40]");
													num87 = 0;
													if (flag144)
													{
														goto IL_40a5;
													}
												}
												string text10 = text3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
												bool flag145 = (nint)text10 < 0;
												obj11 = !flag145;
												float num114 = (float)text3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X19_v21 (System.String)+18]");
												num6 = num114 - 0f;
												flag13 = num6 == 0f;
												along2 = along;
												if (obj11 == null)
												{
													object obj146 = text + text3;
													object obj147 = obj146 + 32;
													obj147 = list;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													string text11 = text3 + 1;
													obj13 = obj10;
													bool flag146 = obj10 == null;
													object obj148 = !flag146;
													num = (int)list;
													source2 = (Source)(object)list;
													text3 = text11;
													if (obj148 == null)
													{
														along2 = along;
														source3 = source;
														num = (int)list;
														obj3 = obj2;
														source2 = (Source)(object)list;
														break;
													}
													continue;
												}
												goto IL_408f;
												IL_40a5:
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
												return (Half)(object)new ArgumentNullException();
												IL_24ba:
												return (Half)num85;
												continue;
												end_IL_4652:
												break;
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
		goto IL_26eb;
		IL_26eb:
		throw new NullReferenceException();
	}

	private unsafe static void Back(Half half, Along along)
	{
		//IL_0023: Expected Obj, but got I
		//IL_01d6: Expected Ref, but got VT
		//IL_0093: Expected VT, but got I4
		//IL_0093: Expected Ref, but got VT
		//IL_0273: Expected VT, but got I4
		//IL_0273: Expected Ref, but got VT
		//IL_00ad: Expected VT, but got Obj
		//IL_00e7: Expected Obj, but got I4
		//IL_00ef: Expected VT, but got I4
		//IL_028d: Expected VT, but got Obj
		//IL_02c7: Expected Obj, but got I4
		//IL_03dc: Expected Obj, but got I
		//IL_0151: Expected VT, but got I4
		//IL_0151: Expected Ref, but got VT
		//IL_016b: Expected VT, but got Obj
		//IL_01a5: Expected Obj, but got I4
		//IL_01ad: Expected VT, but got I4
		//IL_0335: Expected VT, but got I4
		//IL_0335: Expected Ref, but got VT
		//IL_040c: Expected VT, but got Obj
		//IL_034f: Expected VT, but got Obj
		//IL_0389: Expected Obj, but got I4
		//IL_044b: Expected Obj, but got I4
		Built builtSkin = half.builtSkin;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6938]");
		object obj = 0;
		bool flag = half.builtSkin == null;
		Vector3 q = (Vector3)along;
		if (!flag)
		{
			List<Vector3> at = builtSkin.at;
			Along along2 = along;
			int num = 0;
			while (true)
			{
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X22_v15 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				if ((nint)num2 >= (nint)0)
				{
					break;
				}
				Vector3 vector = at.get_Item(num);
				Vector3 vector2 = ((Along*)along)->Out((Vector3)num);
				at.set_Item(num, (Vector3)obj);
				at = builtSkin.at;
				int num3 = num + 1;
				bool flag2 = builtSkin.at == null;
				object obj2 = !flag2;
				along2 = (Along)num;
				num = num3;
				if (obj2 != null)
				{
					continue;
				}
				goto IL_0459;
			}
			List<Vector3> normals = builtSkin.normals;
			q = (Vector3)along2;
			int num4 = 0;
			while (true)
			{
				int num5 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X22_v17 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				if ((nint)num5 >= (nint)0)
				{
					break;
				}
				Vector3 vector3 = normals.get_Item(num4);
				Vector3 vector4 = ((Along*)along)->Way((Vector3)num4);
				normals.set_Item(num4, (Vector3)obj);
				normals = builtSkin.normals;
				int num6 = num4 + 1;
				bool flag3 = builtSkin.normals == null;
				object obj3 = !flag3;
				q = (Vector3)num4;
				num4 = num6;
				if (obj3 != null)
				{
					continue;
				}
				goto IL_0459;
			}
		}
		Vector3 vector5 = ((Along*)along)->Out(q);
		Built builtInside = half.builtInside;
		half.middle = half.middle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [half @ X0 (GillaRip+Half)+34]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [half @ X0 (GillaRip+Half)+38]");
		_ = 0;
		if (half.builtInside == null)
		{
			return;
		}
		List<Vector3> at2 = builtInside.at;
		int num7 = 0;
		object obj4;
		do
		{
			int num8 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X22_v6 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			if ((nint)num8 < (nint)0)
			{
				Vector3 vector6 = at2.get_Item(num7);
				Vector3 vector7 = ((Along*)along)->Out((Vector3)num7);
				at2.set_Item(num7, (Vector3)obj);
				at2 = builtInside.at;
				num7++;
				bool flag4 = builtInside.at == null;
				obj4 = !flag4;
				continue;
			}
			List<Vector3> fourth = builtInside.fourth;
			if (builtInside.fourth != null)
			{
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X22_v11 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					if ((nint)num10 >= (nint)0)
					{
						break;
					}
					Vector3 vector8 = fourth.get_Item(num9);
					Vector3 vector9 = ((Along*)along)->Way((Vector3)num9);
					fourth.set_Item(num9, (Vector3)obj);
					fourth = builtInside.fourth;
					num9++;
					bool flag5 = builtInside.fourth == null;
					object obj5 = !flag5;
					if (obj5 == null)
					{
						goto end_IL_04b3;
					}
				}
			}
			List<Vector4> second = builtInside.second;
			if ((object)builtInside.second == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B10]");
			object obj6 = 0;
			int num11 = 0;
			object obj7;
			do
			{
				int num12 = num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X21_v10 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
				if ((nint)num12 < (nint)0)
				{
					Vector4 vector10 = second.get_Item(num11);
					second.set_Item(num11, (Vector4)obj6);
					second = builtInside.second;
					num11++;
					bool flag6 = (object)builtInside.second == null;
					obj7 = !flag6;
					continue;
				}
				return;
			}
			while (obj7 != null);
			break;
			continue;
			end_IL_04b3:
			break;
		}
		while (obj4 != null);
		goto IL_0459;
		IL_0459:
		throw new NullReferenceException();
	}

	private unsafe static Built Skin(Shape s, Source source, Func<Vector3, float> over, float tearScale)
	{
		//IL_005c: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got I8
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0223: Expected Obj, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I8
		//IL_0288: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I4
		//IL_1347: Expected Obj, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a7: Expected Obj, but got I
		//IL_13c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cb: Expected Obj, but got Unknown
		//IL_13eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f0: Expected Obj, but got Unknown
		//IL_140b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1410: Expected Obj, but got Unknown
		//IL_033a: Expected Obj, but got I4
		//IL_1430: Unknown result type (might be due to invalid IL or missing references)
		//IL_1435: Expected Obj, but got Unknown
		//IL_1450: Unknown result type (might be due to invalid IL or missing references)
		//IL_1455: Expected Obj, but got Unknown
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_147a: Expected Obj, but got Unknown
		//IL_1495: Unknown result type (might be due to invalid IL or missing references)
		//IL_149a: Expected Obj, but got Unknown
		//IL_036a: Expected Obj, but got I
		//IL_039f: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I
		//IL_14fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ff: Expected Obj, but got Unknown
		//IL_03fa: Expected Obj, but got I
		//IL_151f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1524: Expected Obj, but got Unknown
		//IL_1544: Unknown result type (might be due to invalid IL or missing references)
		//IL_1549: Expected Obj, but got Unknown
		//IL_0478: Expected Obj, but got I4
		//IL_0420: Expected Obj, but got I
		//IL_0449: Expected Obj, but got I
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_051a: Expected Obj, but got I4
		//IL_0581: Expected Obj, but got I
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected F4, but got Unknown
		//IL_1665: Expected Obj, but got I
		//IL_166d: Expected I4, but got Obj
		//IL_16f9: Expected Obj, but got I
		//IL_170e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected Obj, but got I4
		//IL_114a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected Obj, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_0f24: Expected Obj, but got I4
		//IL_1186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f53: Expected Obj, but got I4
		//IL_1300: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got I
		//IL_1288: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected Obj, but got I
		//IL_06a0: Expected Obj, but got I
		//IL_06b0: Expected Obj, but got I
		//IL_06c6: Expected Obj, but got I
		//IL_0f96: Expected Obj, but got I
		//IL_0f9e: Expected I4, but got Obj
		//IL_0fae: Expected Obj, but got I
		//IL_0fc4: Expected Obj, but got I
		//IL_131e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected Obj, but got I4
		//IL_101f: Expected Obj, but got I4
		//IL_07a1: Expected Obj, but got I
		//IL_07b1: Expected Obj, but got I
		//IL_07c6: Expected VT, but got I
		//IL_107f: Expected Obj, but got I
		//IL_108f: Expected Obj, but got I
		//IL_109f: Expected Obj, but got I
		//IL_10ac: Expected I4, but got Obj
		//IL_0745: Expected Obj, but got I
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected Obj, but got Unknown
		//IL_0770: Expected Obj, but got I
		//IL_104a: Expected Obj, but got I
		//IL_1060: Expected Obj, but got I
		//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected Obj, but got I
		//IL_11a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected Obj, but got I
		//IL_0868: Expected Obj, but got I
		//IL_087e: Expected Obj, but got I
		//IL_08d9: Expected Obj, but got I4
		//IL_0959: Expected Obj, but got I
		//IL_0969: Expected Obj, but got I
		//IL_097e: Expected VT, but got I
		//IL_08fd: Expected Obj, but got I
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected Obj, but got Unknown
		//IL_0928: Expected Obj, but got I
		//IL_12e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Expected Obj, but got I
		//IL_1200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Expected Obj, but got I
		//IL_0a20: Expected Obj, but got I
		//IL_0a36: Expected Obj, but got I
		//IL_0a91: Expected Obj, but got I4
		//IL_0afe: Expected Obj, but got I
		//IL_0b0e: Expected Obj, but got I
		//IL_0b23: Expected VT, but got I
		//IL_0abc: Expected Obj, but got I
		//IL_0ad2: Expected Obj, but got I
		//IL_12c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Expected Obj, but got I
		//IL_11d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb5: Expected Obj, but got I
		//IL_0bc5: Expected Obj, but got I
		//IL_0bdb: Expected Obj, but got I
		//IL_0c36: Expected Obj, but got I4
		//IL_0cb3: Expected Obj, but got I
		//IL_0cc3: Expected Obj, but got I
		//IL_0cd3: Expected Obj, but got I
		//IL_0ce0: Expected VT, but got Ref
		//IL_0c61: Expected Obj, but got I
		//IL_0c77: Expected Obj, but got I
		//IL_1244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d37: Expected Obj, but got I
		//IL_1262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d95: Invalid comparison between F4 and I4
		//IL_1226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db5: Expected F4, but got I4
		//IL_0dca: Expected Obj, but got I
		//IL_0dda: Expected Obj, but got I
		//IL_0df0: Expected Obj, but got I
		//IL_0e5a: Expected Obj, but got I4
		//IL_0ec0: Expected Obj, but got I
		//IL_0ed0: Expected Obj, but got I
		//IL_0ee5: Expected VT, but got I
		//IL_0e85: Expected Obj, but got I
		//IL_0e9b: Expected Obj, but got I
		bool flag = s == null;
		float num2 = default;
		float num = num2;
		Func<Vector3, float> func2 = default;
		Func<Vector3, float> func = func2;
		Source source2 = source;
		object obj2 = default;
		if (!flag)
		{
			List<Vector3> at = s.at;
			bool flag2 = s.at == null;
			num = num2;
			func = func2;
			source2 = source;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				source2 = (Source)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				bool flag3 = obj2 == null;
				num = num2;
				func = func2;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v19+18]");
					if ((nint)0 < (nint)1)
					{
						goto IL_0159;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v19+18]");
					object obj3 = ~(nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v19+18]");
					object obj4 = 0 & obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v19+18]");
					object obj5 = 0 & 0xFFFFFFFFL;
					object obj6 = obj2 + 32;
					while (true)
					{
						bool flag4 = obj5 == null;
						num = num2;
						func = func2;
						if (flag4)
						{
							break;
						}
						obj5--;
						obj6 = 4294967295L;
						if ((nint)obj4 != 1)
						{
							continue;
						}
						goto IL_0159;
					}
					goto IL_1572;
				}
			}
		}
		goto IL_1580;
		IL_1580:
		NullReferenceException ex = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_159d;
		IL_12d5:
		NullReferenceException ex2 = new NullReferenceException();
		Enumerator<, > val2;
		Enumerator<, > val = (Enumerator<, >)(ref val2);
		ArgumentNullException ex3 = (ArgumentNullException)(object)ex2;
		goto IL_16c6;
		IL_1237:
		NullReferenceException ex4 = new NullReferenceException();
		val = (Enumerator<, >)(ref val2);
		ex3 = (ArgumentNullException)(object)ex4;
		goto IL_16c6;
		IL_1299:
		NullReferenceException ex5 = new NullReferenceException();
		val = (Enumerator<, >)(ref val2);
		ex3 = (ArgumentNullException)(object)ex5;
		goto IL_16c6;
		IL_159d:
		OutOfMemoryException ex6 = new OutOfMemoryException();
		goto IL_15ab;
		IL_1197:
		NullReferenceException ex7 = new NullReferenceException();
		val = (Enumerator<, >)(ref val2);
		int num4 = default;
		int num3 = num4;
		ex3 = (ArgumentNullException)(object)ex7;
		goto IL_16c6;
		IL_0159:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6788]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6978]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6980]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list2 = default;
		list2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector2> list3 = default;
		list3._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector2> list4 = default;
		list4._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6988]");
		object obj12 = 0;
		source2 = (Source)obj12;
		List<BoneWeight> list5 = default;
		list5._002Ector();
		List<int>[] tris = s.tris;
		bool flag5 = s.tris == null;
		num = num2;
		func = func2;
		float num12 = default;
		int num11;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56B0]");
			object obj13 = 0;
			source2 = (Source)tris.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj14 = default;
			bool flag6 = obj14 == null;
			num = num2;
			func = func2;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v33+18]");
				if ((nint)0 >= (nint)1)
				{
					object obj15 = obj14 + 32;
					val2 = (Enumerator<, >)0;
					num = num2;
					func = func2;
					object obj16 = null;
					List<int>[] tris2 = s.tris;
					if (s.tris != null)
					{
						bool flag7 = (nint)obj16 < tris2.Length;
						object obj17 = !flag7;
						if (obj17 != null)
						{
							goto IL_1572;
						}
						object obj18 = (object)s.tris + obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X8_v27+20]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X8_v27+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
							object obj21 = 0;
							func = (Func<Vector3, float>)obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v28+18]");
							List<int> list6 = default;
							list6._002Ector(0);
							bool flag8 = list6 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v28+18]");
							Source source3 = (Source)0;
							if (!flag8)
							{
								object obj22 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v103+40]");
								source3 = (Source)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag9 = ex6 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v103+40]");
								source2 = (Source)0;
								if (flag9)
								{
									goto IL_15ab;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v33+18]");
							bool flag10 = (nint)obj16 < 0;
							object obj23 = !flag10;
							source2 = source3;
							if (obj23 != null)
							{
								goto IL_1572;
							}
							object obj24 = obj14 + obj16;
							object obj25 = obj15 + obj16;
							object obj26 = obj24 + 32;
							obj26 = list6;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							List<int>[] tris3 = s.tris;
							bool flag11 = s.tris == null;
							source2 = (Source)(object)list6;
							if (!flag11)
							{
								bool flag12 = (nint)obj16 < tris3.Length;
								object obj27 = !flag12;
								source2 = (Source)(object)list6;
								if (obj27 != null)
								{
									goto IL_1572;
								}
								object obj28 = (object)s.tris + obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v37+20]");
								bool flag13 = (nint)0 == 0;
								source2 = (Source)(object)list6;
								if (!flag13)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v37+20]");
									Enumerator<, > enumerator = ((List<int>)0).GetEnumerator();
									Enumerator<, > val3 = default;
									num = (float)val3;
									object obj29 = obj16;
									float num13 = default;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
										object obj30 = 0;
										num3 = (int)obj30;
										if (!val2.MoveNext())
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v19+18]");
										bool flag14 = (nint)num4 < (nint)0;
										object obj31 = !flag14;
										if (obj31 != null)
										{
											goto IL_113d;
										}
										object obj32 = obj2 + num4;
										obj29 = obj32 + 32;
										object obj33 = obj29 & 0x80000000L;
										if (obj33 == null)
										{
											goto IL_0f03;
										}
										if (list == null)
										{
											goto IL_12f3;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										obj29 = 0;
										if (s.at == null)
										{
											goto IL_127b;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
										object obj34 = 0;
										func = (Func<Vector3, float>)obj34;
										Vector3 vector = s.at.get_Item(num4);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										object obj35 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
										object obj36 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
										object obj37 = (nint)0 + (nint)1;
										object obj38 = obj36;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											nint num5 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v65+18]");
											bool flag15 = num5 < 0;
											object obj39 = !flag15;
											if (obj39 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
												object obj40 = (nint)0 * (nint)12;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
												object obj41 = 0 + obj40;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
												object obj42 = (nint)0 + (nint)1;
												num3 = num4;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X9_v27+20]");
												object obj43 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ X8_v100+A8]");
												object obj44 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ X8_v101+70]");
												list.AddWithResize((Vector3)0);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ X8_v101+70]");
												num3 = 0;
											}
											if (s.faces != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
												object obj45 = 0;
												func = (Func<Vector3, float>)obj45;
												Vector3 vector2 = s.faces.get_Item(num4);
												if (list2 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v25 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
													object obj46 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
													object obj47 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v25 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
													object obj48 = (nint)0 + (nint)1;
													object obj49 = obj47;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v25 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v25 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
														nint num6 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1195 @ X8_v70+18]");
														bool flag16 = num6 < 0;
														object obj50 = !flag16;
														if (obj50 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v25 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
															object obj51 = (nint)0 * (nint)12;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v25 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
															object obj52 = 0 + obj51;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v25 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
															object obj53 = (nint)0 + (nint)1;
															num3 = num4;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X9_v32+20]");
															object obj54 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ X8_v97+A8]");
															object obj55 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ X8_v98+70]");
															list2.AddWithResize((Vector3)0);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ X8_v98+70]");
															num3 = 0;
														}
														if ((object)s.uv != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69D8]");
															object obj56 = 0;
															func = (Func<Vector3, float>)obj56;
															Vector2 vector3 = s.uv.get_Item(num4);
															if ((object)list3 != null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																object obj57 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69C0]");
																object obj58 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																object obj59 = (nint)0 + (nint)1;
																object obj60 = obj58;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																	nint num7 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1218 @ X8_v75+18]");
																	bool flag17 = num7 < 0;
																	object obj61 = !flag17;
																	if (obj61 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																		nint num8 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																		object obj62 = num8 + 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																		object obj63 = (nint)0 + (nint)1;
																		num3 = num4;
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X9_v37+20]");
																		object obj64 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ X8_v94+A8]");
																		object obj65 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ X8_v95+70]");
																		list3.AddWithResize((Vector2)0);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ X8_v95+70]");
																		num3 = 0;
																	}
																	if (s.weights != null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69E0]");
																		object obj66 = 0;
																		func = (Func<Vector3, float>)obj66;
																		BoneWeight boneWeight = s.weights.get_Item(num4);
																		if (list5 != null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v31 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+10]");
																			object obj67 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69C8]");
																			object obj68 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v31 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+1C]");
																			object obj69 = (nint)0 + (nint)1;
																			object obj70 = obj68;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v31 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+10]");
																			if ((nint)0 != 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v31 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+18]");
																				nint num9 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1239 @ X8_v81+18]");
																				bool flag18 = num9 < 0;
																				object obj71 = !flag18;
																				if (obj71 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v31 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+10]");
																					nint num10 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v31 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+18]");
																					object obj72 = num10 + 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v31 (System.Collections.Generic.List`1<UnityEngine.BoneWeight>)+18]");
																					object obj73 = (nint)0 + (nint)1;
																					num11 = num4;
																					num = num12;
																					num3 = num4;
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1242 @ X9_v42+20]");
																					object obj74 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ X8_v91+A8]");
																					object obj75 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v92+70]");
																					func = (Func<Vector3, float>)0;
																					list5.AddWithResize((BoneWeight)(&num13));
																					num13 = num12;
																					num11 = num4;
																					num = num12;
																					num3 = (int)(&num13);
																				}
																				if (s.at == null)
																				{
																					goto IL_1237;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
																				object obj76 = 0;
																				func = (Func<Vector3, float>)obj76;
																				Vector3 vector4 = s.at.get_Item(num4);
																				if (func2 != null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X2_v8 (System.Func`2<UnityEngine.Vector3, System.Single>)+28]");
																					num3 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v134 @ X2_v8 (System.Func`2<UnityEngine.Vector3, System.Single>)+18] (should have been resolved before IL gen)");
																					if (num < 0f)
																					{
																						num = 0f;
																					}
																					if ((object)list4 != null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v29 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																						object obj77 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69C0]");
																						object obj78 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v29 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																						object obj79 = (nint)0 + (nint)1;
																						object obj80 = obj78;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v29 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																						if ((nint)0 != 0)
																						{
																							num *= num2;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v29 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																							nint num14 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X8_v87+18]");
																							bool flag19 = num14 < 0;
																							object obj81 = !flag19;
																							if (obj81 == null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v29 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																								nint num15 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v29 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																								object obj82 = num15 + 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v29 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																								object obj83 = (nint)0 + (nint)1;
																								_ = 0;
																							}
																							else
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1143 @ X9_v48+20]");
																								object obj84 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1274 @ X8_v88+A8]");
																								object obj85 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ X8_v89+70]");
																								list4.AddWithResize((Vector2)0);
																								num11 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ X8_v89+70]");
																								num3 = 0;
																							}
																							goto IL_0f03;
																						}
																					}
																					goto IL_1219;
																				}
																				goto IL_1255;
																			}
																		}
																		goto IL_11bd;
																	}
																	goto IL_12b7;
																}
															}
															goto IL_11f3;
														}
														goto IL_12d5;
													}
												}
												goto IL_1197;
											}
											goto IL_1299;
										}
										goto IL_1311;
										IL_0f03:
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v33+18]");
										bool flag20 = (nint)obj16 < 0;
										object obj86 = !flag20;
										if (obj86 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v19+18]");
											bool flag21 = (nint)num4 < (nint)0;
											object obj87 = !flag21;
											if (obj87 == null)
											{
												List<int> list7 = (List<int>)obj26;
												if (obj26 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X0_v89 (System.Collections.Generic.List`1<System.Int32>)+10]");
													object obj88 = 0;
													num3 = (int)obj29;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
													object obj89 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X0_v89 (System.Collections.Generic.List`1<System.Int32>)+1C]");
													object obj90 = (nint)0 + (nint)1;
													object obj91 = obj89;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X0_v89 (System.Collections.Generic.List`1<System.Int32>)+10]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X0_v89 (System.Collections.Generic.List`1<System.Int32>)+18]");
														nint num16 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X8_v58+18]");
														bool flag22 = num16 < 0;
														object obj92 = !flag22;
														if (obj92 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X0_v89 (System.Collections.Generic.List`1<System.Int32>)+10]");
															nint num17 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X0_v89 (System.Collections.Generic.List`1<System.Int32>)+18]");
															object obj93 = num17 + 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X0_v89 (System.Collections.Generic.List`1<System.Int32>)+18]");
															object obj94 = (nint)0 + (nint)1;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X9_v23+20]");
															object obj95 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X8_v59+A8]");
															object obj96 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X8_v60+70]");
															func = (Func<Vector3, float>)0;
															((List<int>)obj26).AddWithResize((int)obj29);
														}
														continue;
													}
												}
												goto IL_111f;
											}
											goto IL_115b;
										}
										goto IL_1179;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
									object obj97 = 0;
									source2 = (Source)obj97;
									val2.Dispose();
									val = (Enumerator<, >)(ref val2);
									goto IL_159d;
								}
							}
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69B8]");
					object obj98 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					_ = 1065353216;
					object obj99 = default;
					obj99._002Ector();
					bool flag23 = source == null;
					num = num;
					func = func;
					source2 = null;
					if (!flag23)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69E8]");
						object obj100 = 0;
						string text = source.name + (string)obj100;
						object obj101 = obj99 + 16;
						obj101 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj102 = obj99 + 24;
						obj102 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj103 = obj99 + 32;
						obj103 = list2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj104 = obj99 + 56;
						obj104 = list3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj105 = obj99 + 72;
						obj105 = list4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj106 = obj99 + 40;
						obj106 = list2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj107 = obj99 + 48;
						obj107 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag24 = list5 == null;
						num = num;
						func = null;
						source2 = (Source)(object)list;
						if (!flag24)
						{
							BoneWeight[] array = list5.ToArray();
							object obj108 = obj99 + 80;
							obj108 = array;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj109 = obj99 + 88;
							obj109 = source.binds;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj110 = obj99 + 96;
							obj110 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							return (Built)obj99;
						}
					}
				}
			}
		}
		goto IL_1580;
		IL_15ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex3 = new ArgumentNullException();
		num3 = 0;
		goto IL_16c6;
		IL_1255:
		NullReferenceException ex8 = new NullReferenceException();
		val = (Enumerator<, >)(ref val2);
		num3 = num4;
		ex3 = (ArgumentNullException)(object)ex8;
		goto IL_16c6;
		IL_12b7:
		NullReferenceException ex9 = new NullReferenceException();
		val = (Enumerator<, >)(ref val2);
		ex3 = (ArgumentNullException)(object)ex9;
		goto IL_16c6;
		IL_1179:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		val = (Enumerator<, >)(ref val2);
		ex3 = (ArgumentNullException)(object)ex10;
		goto IL_16c6;
		IL_11bd:
		NullReferenceException ex11 = new NullReferenceException();
		num11 = num4;
		val = (Enumerator<, >)(ref val2);
		num = num12;
		num3 = num4;
		ex3 = (ArgumentNullException)(object)ex11;
		goto IL_16c6;
		IL_113d:
		IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
		val = (Enumerator<, >)(ref val2);
		ex3 = (ArgumentNullException)(object)ex12;
		goto IL_16c6;
		IL_11f3:
		NullReferenceException ex13 = new NullReferenceException();
		val = (Enumerator<, >)(ref val2);
		num3 = num4;
		ex3 = (ArgumentNullException)(object)ex13;
		goto IL_16c6;
		IL_12f3:
		NullReferenceException ex14 = new NullReferenceException();
		val = (Enumerator<, >)(ref val2);
		ex3 = (ArgumentNullException)(object)ex14;
		goto IL_16c6;
		IL_16c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		Built result = default;
		return result;
		IL_111f:
		NullReferenceException ex15 = new NullReferenceException();
		val = (Enumerator<, >)(ref val2);
		ex3 = (ArgumentNullException)(object)ex15;
		goto IL_16c6;
		IL_127b:
		NullReferenceException ex16 = new NullReferenceException();
		val = (Enumerator<, >)(ref val2);
		ex3 = (ArgumentNullException)(object)ex16;
		goto IL_16c6;
		IL_1311:
		NullReferenceException ex17 = new NullReferenceException();
		val = (Enumerator<, >)(ref val2);
		num3 = num4;
		ex3 = (ArgumentNullException)(object)ex17;
		goto IL_16c6;
		IL_1219:
		NullReferenceException ex18 = new NullReferenceException();
		val = (Enumerator<, >)(ref val2);
		ex3 = (ArgumentNullException)(object)ex18;
		goto IL_16c6;
		IL_1572:
		IndexOutOfRangeException ex19 = new IndexOutOfRangeException();
		goto IL_1580;
		IL_115b:
		IndexOutOfRangeException ex20 = new IndexOutOfRangeException();
		val = (Enumerator<, >)(ref val2);
		ex3 = (ArgumentNullException)(object)ex20;
		goto IL_16c6;
	}

	private unsafe static void Bowl(Shape s, List<(int, int)> rim, Source source, Half half, int sign, int seed, float handed, Stopwatch clock = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		//IL_0050: Expected I4, but got Obj
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected I4, but got Unknown
		//IL_007a: Expected I4, but got Obj
		//IL_0125: Expected F8, but got I4
		//IL_4fa7: Expected Obj, but got I
		//IL_4fd6: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_021d: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I
		//IL_02be: Expected I, but got Obj
		//IL_0311: Expected VT, but got Obj
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected F4, but got I4
		//IL_0444: Expected F8, but got Obj
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got I4
		//IL_0379: Expected VT, but got I
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected F4, but got I4
		//IL_03ad: Expected F8, but got Obj
		//IL_03b5: Expected F8, but got I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected F8, but got I4
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got I4
		//IL_03f4: Expected VT, but got I
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_04e6: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I
		//IL_0506: Expected Obj, but got I
		//IL_0518: Expected VT, but got I
		//IL_0528: Expected Obj, but got I
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_4e22: Expected I4, but got F8
		//IL_4e2a: Expected I4, but got F8
		//IL_4e32: Expected VT, but got I4
		//IL_4e3a: Expected VT, but got I4
		//IL_5913: Expected F8, but got I4
		//IL_591b: Expected F8, but got I4
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_58dc: Expected Obj, but got I
		//IL_58ec: Expected Obj, but got I
		//IL_58fc: Expected Obj, but got I
		//IL_0598: Expected Obj, but got I4
		//IL_05a8: Expected Obj, but got I
		//IL_05b8: Expected Obj, but got I
		//IL_05c8: Expected Obj, but got I
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected F4, but got I
		//IL_5a93: Invalid comparison between VT and I4
		//IL_4eb8: Invalid comparison between VT and I4
		//IL_222c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2239: Expected F4, but got I4
		//IL_2271: Expected F8, but got I
		//IL_2279: Expected I4, but got Obj
		//IL_2282: Expected Obj, but got I4
		//IL_2282: Unknown result type (might be due to invalid IL or missing references)
		//IL_2286: Unknown result type (might be due to invalid IL or missing references)
		//IL_2293: Expected Obj, but got I4
		//IL_2297: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c4: Expected Obj, but got I4
		//IL_22d4: Expected Obj, but got I
		//IL_22e5: Expected Obj, but got I4
		//IL_4e68: Expected Obj, but got F8
		//IL_4e70: Expected I4, but got F8
		//IL_4e80: Expected I4, but got F8
		//IL_4e89: Expected Obj, but got I4
		//IL_4e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ea2: Expected Obj, but got I4
		//IL_5add: Expected Obj, but got I
		//IL_5ae5: Expected VT, but got Obj
		//IL_5ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_5aee: Expected Ref, but got Unknown
		//IL_5b08: Expected Obj, but got I4
		//IL_4ef8: Expected Obj, but got F8
		//IL_4f00: Expected I4, but got F8
		//IL_4f10: Expected I4, but got F8
		//IL_4f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f41: Expected Obj, but got I4
		//IL_230c: Expected Obj, but got I4
		//IL_2314: Unknown result type (might be due to invalid IL or missing references)
		//IL_231c: Expected Obj, but got Unknown
		//IL_233b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2340: Expected Obj, but got Unknown
		//IL_4c8a: Expected F8, but got I4
		//IL_06c9: Expected Obj, but got I
		//IL_06f7: Expected Obj, but got I4
		//IL_239c: Expected Obj, but got I4
		//IL_23d1: Expected Obj, but got I4
		//IL_23e1: Expected Obj, but got I
		//IL_23ef: Expected Obj, but got I4
		//IL_242a: Expected Obj, but got I
		//IL_243b: Expected I, but got Obj
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected Obj, but got I4
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected F4, but got Unknown
		//IL_247c: Expected Obj, but got I4
		//IL_4cd3: Expected VT, but got I4
		//IL_24cc: Expected Obj, but got I4
		//IL_4ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cf4: Expected F4, but got I4
		//IL_4cfc: Expected I4, but got F8
		//IL_4d1c: Expected F8, but got I
		//IL_4d24: Expected I4, but got Obj
		//IL_4d2d: Expected Obj, but got I4
		//IL_4d2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d3e: Expected Obj, but got I4
		//IL_4d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d6f: Expected Obj, but got I4
		//IL_51b5: Expected Obj, but got I
		//IL_51bd: Expected I4, but got Obj
		//IL_51c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_51cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_51d8: Expected F8, but got I4
		//IL_07a7: Expected Obj, but got I4
		//IL_2504: Expected Obj, but got I4
		//IL_07da: Expected VT, but got Obj
		//IL_07da: Expected Obj, but got F8
		//IL_07da: Expected Obj, but got I4
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got Unknown
		//IL_07f3: Expected F8, but got I4
		//IL_2541: Expected Obj, but got I
		//IL_2560: Expected Obj, but got I
		//IL_2568: Expected VT, but got Obj
		//IL_2581: Expected Obj, but got I
		//IL_25a1: Expected Obj, but got I4
		//IL_25bf: Expected Obj, but got I
		//IL_25df: Expected Obj, but got I4
		//IL_25f7: Expected Obj, but got I4
		//IL_2611: Expected Obj, but got I4
		//IL_261a: Expected Obj, but got I4
		//IL_2638: Expected Obj, but got I
		//IL_2648: Expected Obj, but got I
		//IL_26b0: Expected Obj, but got I
		//IL_26b9: Expected Obj, but got I4
		//IL_26ca: Expected Obj, but got I4
		//IL_26da: Expected F8, but got I
		//IL_56d1: Expected Obj, but got I4
		//IL_5719: Expected F8, but got Obj
		//IL_5731: Unknown result type (might be due to invalid IL or missing references)
		//IL_5739: Expected F8, but got Unknown
		//IL_2fb3: Expected Obj, but got I
		//IL_2710: Unknown result type (might be due to invalid IL or missing references)
		//IL_2715: Expected Obj, but got Unknown
		//IL_2725: Expected Obj, but got I
		//IL_300d: Expected Obj, but got I
		//IL_3027: Expected Obj, but got I
		//IL_304f: Expected F4, but got I
		//IL_2e86: Expected Obj, but got I4
		//IL_2f3c: Expected Obj, but got I
		//IL_308c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3091: Expected VT, but got Unknown
		//IL_30a1: Expected F4, but got I
		//IL_30b1: Expected F4, but got I
		//IL_30c6: Expected Obj, but got I
		//IL_30d6: Expected F8, but got I
		//IL_30e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_30eb: Expected I4, but got Unknown
		//IL_30fb: Expected Obj, but got I
		//IL_310b: Expected Obj, but got I
		//IL_311b: Expected Obj, but got I
		//IL_2802: Expected Obj, but got I
		//IL_3157: Expected I4, but got Obj
		//IL_316b: Expected Obj, but got I
		//IL_3195: Expected Obj, but got I4
		//IL_3670: Expected Obj, but got I
		//IL_2848: Expected Obj, but got I
		//IL_31dc: Expected VT, but got Obj
		//IL_31f6: Expected I4, but got F8
		//IL_28a6: Expected Obj, but got I
		//IL_3685: Expected Obj, but got I
		//IL_369d: Expected Obj, but got I
		//IL_36bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_36f1: Expected F4, but got I4
		//IL_35a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ae: Expected Obj, but got Unknown
		//IL_35da: Expected Obj, but got I4
		//IL_35e2: Expected F4, but got I4
		//IL_35fa: Expected I4, but got F4
		//IL_3247: Expected Obj, but got I4
		//IL_28ec: Expected Obj, but got I
		//IL_5a31: Expected Obj, but got I
		//IL_5a39: Expected VT, but got Obj
		//IL_5a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a53: Expected F8, but got I4
		//IL_5a5d: Expected F8, but got I4
		//IL_5a6d: Expected Obj, but got I
		//IL_327d: Expected VT, but got I4
		//IL_3291: Expected Obj, but got I
		//IL_3299: Expected VT, but got Obj
		//IL_32bb: Expected Obj, but got I4
		//IL_4dd7: Expected F8, but got Obj
		//IL_4ddf: Expected F8, but got I4
		//IL_4de7: Expected F8, but got I4
		//IL_4de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4def: Expected F8, but got Unknown
		//IL_36fe: Expected Obj, but got Ref
		//IL_3792: Expected I4, but got F4
		//IL_294a: Expected Obj, but got I
		//IL_2988: Expected Obj, but got I
		//IL_299c: Expected Obj, but got I
		//IL_29c6: Expected Obj, but got I4
		//IL_5771: Expected Obj, but got I4
		//IL_577a: Expected I4, but got Obj
		//IL_29f4: Expected I4, but got Obj
		//IL_29f4: Expected VT, but got I4
		//IL_2a09: Expected I4, but got Obj
		//IL_2a09: Expected VT, but got I4
		//IL_2a23: Expected I4, but got Obj
		//IL_2a23: Expected VT, but got I4
		//IL_579f: Expected Obj, but got Ref
		//IL_33e0: Expected Obj, but got I4
		//IL_33f0: Expected F4, but got I4
		//IL_33f8: Expected F8, but got Obj
		//IL_342d: Expected Obj, but got I
		//IL_342d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3435: Expected F8, but got Unknown
		//IL_3445: Expected Obj, but got Ref
		//IL_521d: Invalid comparison between F4 and I4
		//IL_34a3: Expected Obj, but got I
		//IL_34cd: Expected Obj, but got I4
		//IL_5254: Invalid comparison between F4 and I4
		//IL_5265: Expected Obj, but got I4
		//IL_5275: Invalid comparison between F4 and I
		//IL_5294: Expected F8, but got I4
		//IL_52b4: Expected F8, but got I
		//IL_52bc: Expected VT, but got I4
		//IL_52c4: Expected Obj, but got I4
		//IL_52cc: Expected Obj, but got I4
		//IL_2a6e: Expected F4, but got I4
		//IL_34fb: Expected F4, but got I4
		//IL_34fb: Expected F4, but got I4
		//IL_351e: Expected Obj, but got Ref
		//IL_2db0: Expected Obj, but got I
		//IL_2dc0: Expected Obj, but got I
		//IL_2e3e: Expected Obj, but got I
		//IL_2e5e: Expected Obj, but got I
		//IL_2a90: Expected Obj, but got I
		//IL_2a98: Expected VT, but got Obj
		//IL_3563: Expected VT, but got Obj
		//IL_3563: Expected I4, but got Obj
		//IL_3563: Expected Obj, but got I
		//IL_358b: Expected I4, but got Obj
		//IL_2ae4: Expected Obj, but got I4
		//IL_2b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b1c: Expected I4, but got Unknown
		//IL_52f3: Expected Obj, but got I4
		//IL_52fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_5300: Expected Obj, but got Unknown
		//IL_532f: Invalid comparison between F8 and I4
		//IL_533e: Invalid comparison between F8 and I4
		//IL_5351: Expected Obj, but got F8
		//IL_535e: Expected Obj, but got F8
		//IL_53b2: Expected Obj, but got I4
		//IL_53ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_53bf: Expected Obj, but got Unknown
		//IL_542c: Invalid comparison between F8 and I4
		//IL_543b: Invalid comparison between F8 and I4
		//IL_544e: Expected Obj, but got F8
		//IL_545b: Expected Obj, but got F8
		//IL_5490: Expected Obj, but got I4
		//IL_5498: Unknown result type (might be due to invalid IL or missing references)
		//IL_549d: Expected Obj, but got Unknown
		//IL_54c1: Expected Obj, but got I4
		//IL_54f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_54f9: Expected I4, but got Unknown
		//IL_552e: Expected Obj, but got I4
		//IL_5536: Unknown result type (might be due to invalid IL or missing references)
		//IL_553b: Expected Obj, but got Unknown
		//IL_5544: Expected I4, but got Obj
		//IL_2be3: Expected F8, but got I4
		//IL_5579: Expected Obj, but got VT
		//IL_5593: Expected Obj, but got I4
		//IL_55d1: Expected VT, but got I4
		//IL_55d9: Expected Obj, but got VT
		//IL_55e1: Expected Obj, but got VT
		//IL_2bd6: Expected F8, but got I4
		//IL_2bf6: Expected Obj, but got VT
		//IL_2c04: Expected Obj, but got VT
		//IL_2c34: Expected Obj, but got VT
		//IL_565d: Expected Obj, but got I4
		//IL_5673: Expected VT, but got I4
		//IL_567b: Expected Obj, but got VT
		//IL_2d26: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d2b: Expected Obj, but got Unknown
		//IL_2d33: Invalid comparison between Obj and VT
		//IL_2d74: Expected I4, but got VT
		//IL_2d7c: Expected VT, but got Obj
		//IL_55fc: Expected VT, but got Obj
		//IL_2ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce6: Expected Obj, but got Unknown
		//IL_2d07: Expected I4, but got VT
		//IL_2c7c: Expected Obj, but got Ref
		//IL_2c94: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		Source source2 = source;
		object obj3 = obj2;
		int num;
		int num2;
		Shape shape2 = default;
		float value2;
		double num7;
		double num9;
		Enumerator<, > val4;
		Vector2Int vector2Int3 = default;
		object obj25;
		List<(Vector2, Vector2)> list4 = default;
		List<System.__Canon> list5 = default;
		Vector3[] array;
		object obj27;
		object obj28;
		Source source6;
		double num12;
		Enumerator<, > val5;
		Enumerator<, > val6 = default;
		int num16;
		double num20;
		double num22;
		object obj39;
		Enumerator<, > val;
		Shape shape3 = default;
		Source source7 = default;
		double num23 = default;
		int num24;
		object obj35 = default;
		object obj36 = default;
		Enumerator<, > val8 = default;
		List<(Vector2, Vector2)> list6 = default;
		object obj37;
		object obj38 = default;
		int num25 = default;
		int num21;
		float num14;
		Vector2Int vector2Int2;
		Source source5;
		object obj19;
		double num3;
		double num6;
		double num19 = default;
		int num11;
		double num13 = default;
		int num15;
		int num8 = default;
		int num10 = default;
		Vector2Int vector2Int;
		List<int> list3;
		if (!flag)
		{
			object obj4 = obj2 + 16;
			obj4 = clock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num = obj2 + 24;
			((int*)num)->m_value = (int)half;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num2 = obj2 + 40;
			((int*)num2)->m_value = (int)s;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
				object obj5 = 0;
				TimeSpan elapsed = ((Stopwatch)obj4).Elapsed;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1562 @ X8_v270+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				TimeSpan timeSpan = default;
				num3 = timeSpan.TotalMilliseconds;
				Shape shape = null;
			}
			else
			{
				num3 = 0.0;
				Shape shape = s;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1577 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3 (System.Object)+28]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3 (System.Object)+18]");
			List<List<int>> list = Loops((Shape)num4, rim, (Half)0);
			bool flag4 = list == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3 (System.Object)+18]");
			source2 = (Source)0;
			obj3 = obj2;
			if (!flag4)
			{
				int value = ((int*)num)->m_value;
				bool flag5 = ((int*)num)->m_value == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3 (System.Object)+18]");
				source2 = (Source)0;
				obj3 = obj2;
				if (!flag5)
				{
					int size = list._size;
					_ = list._size;
					bool flag6 = list._size == 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3 (System.Object)+18]");
					source2 = (Source)0;
					obj3 = obj2;
					if (flag6)
					{
						int i = 4;
						float num5 = ((_003C_003Ec__DisplayClass47_0)obj3)._003CBowl_003Eg__Lap_007C0(i);
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69F8]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AD8]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A78]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6940]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56B0]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
					Source source3 = (Source)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Comparison<System.__Canon> comparison = default;
					comparison._002Ector(obj2, (IntPtr)obj12);
					source2 = (Source)obj13;
					((List<System.__Canon>)(object)list).Sort(comparison);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					shape2._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					vector2Int = (Vector2Int)obj16;
					List<int> list2 = default;
					list2._002Ector();
					object obj17 = default;
					bool flag7 = obj17 == null;
					obj3 = obj2;
					if (!flag7)
					{
						Source source4 = default;
						Enumerator<, > val2;
						Enumerator<, > val3;
						if (list2 != null)
						{
							object obj18 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1657 @ X8_v269+40]");
							vector2Int = (Vector2Int)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							OutOfMemoryException ex = default;
							bool flag8 = ex == null;
							val = (Enumerator<, >)0;
							value2 = 0f;
							num6 = (double)source4;
							num7 = num8;
							val2 = (Enumerator<, >)0;
							val3 = (Enumerator<, >)0;
							num9 = num10;
							val4 = (Enumerator<, >)0;
							obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1657 @ X8_v269+40]");
							vector2Int2 = (Vector2Int)0;
							source5 = source;
							num11 = seed;
							if (flag8)
							{
								goto IL_4df4;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1639 @ X0_v29+18]");
						bool flag9 = (nint)0 == 0;
						val = (Enumerator<, >)0;
						value2 = 0f;
						num6 = (double)source4;
						val2 = (Enumerator<, >)0;
						val3 = (Enumerator<, >)0;
						val4 = (Enumerator<, >)0;
						obj19 = 0;
						source5 = source;
						list3 = list2;
						num11 = seed;
						if (flag9)
						{
							goto IL_4c0f;
						}
						object obj20 = obj17 + 32;
						obj20 = list2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag10 = shape2 == null;
						obj3 = obj2;
						if (!flag10)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AB8]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A88]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC0]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A30]");
							vector2Int3 = (Vector2Int)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
							object obj24 = 0;
							obj25 = shape2 + 48;
							obj25 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							list4._002Ector();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							list5._002Ector();
							Enumerator<, > enumerator = ((List<System.__Canon>)(object)list).GetEnumerator();
							array = (Vector3[])(-sign);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
							obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
							obj28 = 0;
							source6 = source4;
							val2 = (Enumerator<, >)0;
							num12 = num13;
							val3 = (Enumerator<, >)0;
							Vector3[] array2 = array;
							val5 = val6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							num14 = 0f;
							size = (int)(&val4);
							num15 = num2;
							num16 = vector2Int3.m_X;
							if (val4.MoveNext())
							{
								int value3 = ((int*)num15)->m_value;
								if (((int*)num15)->m_value != 0)
								{
									if (source4 != null)
									{
										source2 = (Source)obj24;
										int num17 = ((List<int>)(object)source4).get_Item(0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2643 @ X8_v171 (System.Int32)+10]");
										bool flag11 = (nint)0 == 0;
										num16 = num17;
										if (flag11)
										{
											goto IL_4c3e;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2643 @ X8_v171 (System.Int32)+10]");
										Vector3 vector = ((List<Vector3>)0).get_Item(num17);
										object obj29 = obj28;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2930 @ X0_v276+E4]");
										bool flag12 = (nint)0 == 0;
										object obj30 = !flag12;
										if (obj30 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag13 = list5 == null;
										num10 = num8;
										double num18 = num12;
										source2 = (Source)obj27;
										num16 = num17;
										if (flag13)
										{
											goto IL_4c4c;
										}
										Enumerator<, > enumerator2 = list5.GetEnumerator();
										num13 = num12;
										object obj31 = 0;
										Enumerator<, > val7 = default;
										num14 = (float)val7;
										while (val3.MoveNext())
										{
											object obj32 = obj28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3207 @ X0_v350+E4]");
											bool flag14 = (nint)0 == 0;
											object obj33 = !flag14;
											if (obj33 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag15 = Inside((Shape)((int*)num15)->m_value, (List<int>)num19, (Vector2)obj27);
											obj31 = flag15 | obj31;
											num13 = num8;
											num14 = (float)num12;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A28]");
										object obj34 = 0;
										num16 = (int)obj34;
										val3.Dispose();
										val3 = val7;
										num20 = 0.0;
										num10 = num8;
										num18 = num12;
										source2 = (Source)obj27;
										goto IL_4c79;
									}
								}
								else
								{
									NullReferenceException ex2 = new NullReferenceException();
								}
								NullReferenceException ex3 = new NullReferenceException();
								goto IL_4c3e;
							}
							val = (Enumerator<, >)0;
							value2 = 0f;
							num21 = num8;
							num13 = num12;
							num22 = num19;
							shape3 = shape2;
							source7 = source;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							num23 = 0.0;
							num24 = (int)array;
							obj35 = 0;
							val4 = val6;
							obj36 = 0;
							val8 = (Enumerator<, >)(ref val4);
							list6 = list4;
							obj37 = obj25;
							num25 = num2;
							obj38 = obj2;
							obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
							obj3 = 0;
							source5 = (Source)(object)list5;
							obj39 = 16;
							num11 = seed;
							goto IL_500e;
						}
					}
				}
			}
		}
		goto IL_4951;
		IL_4c4c:
		NullReferenceException ex4 = new NullReferenceException();
		num13 = num12;
		num20 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_4c79;
		IL_4c3e:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_4c4c;
		IL_4d84:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		num22 = num20;
		int num27;
		int num26 = num27;
		goto IL_4da3;
		IL_4da3:
		num19 = num22;
		num3 = num14;
		num11 = num26;
		throw new OutOfMemoryException();
		IL_4c79:
		OutOfMemoryException ex6 = new OutOfMemoryException();
		double num28 = num10;
		NullReferenceException ex7 = new NullReferenceException();
		num21 = num8;
		OutOfMemoryException ex8 = new OutOfMemoryException();
		NullReferenceException ex9 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		vector2Int2 = (Vector2Int)num16;
		NullReferenceException ex10 = new NullReferenceException();
		val = (Enumerator<, >)0;
		value2 = 0f;
		num10 = (int)num28;
		shape3 = shape2;
		source7 = source;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		num23 = 0.0;
		num24 = (int)array;
		obj35 = 0;
		val4 = val6;
		obj36 = 0;
		val8 = (Enumerator<, >)(ref val4);
		list6 = list4;
		obj37 = obj25;
		num25 = num2;
		obj38 = obj2;
		obj19 = 0;
		source5 = (Source)(object)list5;
		num27 = seed;
		goto IL_4d84;
		IL_2f52:
		float num29 = ((_003C_003Ec__DisplayClass47_0)obj38)._003CBowl_003Eg__Lap_007C0(6);
		Dictionary<Vector2Int, float> dictionary = default;
		object obj60;
		bool flag25 = default;
		float num46 = default;
		float num47 = default;
		double num48 = default;
		double num54 = default;
		double num44 = default;
		if (source7 != null && source7.name != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4900]");
			object value4 = 0;
			bool flag16 = source7.name.EndsWith((string)value4);
			List<Vector3> at = shape3.at;
			bool flag17 = shape3.at == null;
			source2 = null;
			if (!flag17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AD0]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				List<(Vector2, Vector2)> edges = list6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				RimGrid rimGrid = default;
				rimGrid._002Ector(edges, 0f);
				List<Vector3> at2 = shape3.at;
				bool flag18 = shape3.at == null;
				source2 = null;
				if (!flag18)
				{
					object obj42 = default;
					vector2Int3 = (Vector2Int)(obj42 + 32);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD4C]");
					float num30 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B010]");
					float num31 = 0f;
					int num32 = num26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
					object obj43 = (nint)num32 * (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AADC]");
					double num18 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD4C]");
					int num33 = obj43 / 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A00]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6938]");
					source5 = (Source)0;
					int num34 = num26;
					source2 = null;
					int num35 = num33;
					int size = sign;
					obj3 = null;
					while (true)
					{
						object obj46 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3523 @ X0_v56 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						if ((nint)obj46 >= 0)
						{
							break;
						}
						source2 = (Source)obj27;
						Vector3 vector2 = at2.get_Item((int)obj3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
						object obj47 = 0;
						object obj48 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3536 @ X0_v147+E4]");
						bool flag19 = (nint)0 == 0;
						object obj49 = !flag19;
						if (obj49 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num36;
						int num37;
						if (rimGrid != null)
						{
							num36 = rimGrid.Nearest((Vector2)obj3);
							bool flag20 = (double)num36 < num23;
							num37 = (int)num23;
							if (flag20)
							{
								goto IL_35a0;
							}
							float num38 = num36 / num31;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
							object obj50 = obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3729 @ X0_v153+E4]");
							bool flag21 = (nint)0 == 0;
							object obj51 = !flag21;
							if (obj51 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num39 = (float)num21 / num30;
							float num40 = GillaWounds.Lumps((Vector3)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
							object obj52 = 0;
							Vector2 p = (Vector2)obj52;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3835 @ X0_v157 (UnityEngine.Vector2)+E4]");
							bool flag22 = (nint)0 == 0;
							object obj53 = !flag22;
							if (obj53 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Vector2Int vector2Int4 = _003CBowl_003Eg__SquareOf_007C47_3(p);
							if ((object)dictionary != null)
							{
								obj19 = obj45;
								double num41 = 1.0 - (double)num38;
								float num42 = num40 + 0.5f;
								double num43 = num41 * num18;
								num44 = num43 * (double)num42;
								bool flag23 = dictionary.TryGetValue(vector2Int4, out value2);
								float num45 = value2 * 0.75f;
								if (num44 < (double)num45)
								{
									num45 = (float)num44;
								}
								bool flag24 = !flag23;
								object obj54 = !flag24;
								flag25 = (byte)(int)(~obj54) != 0;
								if (!flag25)
								{
									num3 = num45;
								}
								else
								{
									num3 = num44;
								}
								bool flag26 = obj42 == null;
								source2 = (Source)(&value2);
								if (!flag26)
								{
									object obj55 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3452 @ X0_v52+18]");
									bool flag27 = (nint)obj55 < 0;
									object obj56 = !flag27;
									num46 = num40;
									num47 = num21;
									num6 = (double)source6;
									num8 = num33;
									num13 = 0.75;
									num19 = num22;
									num10 = num34;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v32+30]");
									Vector3[] array2 = (Vector3[])0;
									num48 = (double)val5;
									num25 = num33;
									source2 = (Source)(&value2);
									vector2Int = vector2Int4;
									list3 = (List<int>)(object)rimGrid;
									num11 = num26;
									if (obj56 != null)
									{
										goto IL_4c0f;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
									double num49 = num44 / num18;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
									object obj57 = 0;
									object obj58 = obj57;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4074 @ X0_v161+E4]");
									bool flag28 = (nint)0 == 0;
									object obj59 = !flag28;
									if (obj59 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									float num50 = Line(num34, num21, num26);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1871 @ stack_-208_v11 (GillaRip+Shape)+10]");
									bool flag29 = (nint)0 == 0;
									source2 = (Source)(&value2);
									if (!flag29)
									{
										double num51 = num44 * (double)sign;
										num36 = (float)num51 + num50;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1871 @ stack_-208_v11 (GillaRip+Shape)+10]");
										((List<Vector3>)0).set_Item((int)obj3, (Vector3)source5);
										num46 = num40;
										num37 = num34;
										obj60 = obj19;
										source2 = source5;
										size = (int)shape3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1871 @ stack_-208_v11 (GillaRip+Shape)+10]");
										num15 = 0;
										goto IL_35a0;
									}
								}
							}
						}
						goto IL_4951;
						IL_35a0:
						obj3++;
						at2 = shape3.at;
						bool flag30 = shape3.at == null;
						object obj61 = !flag30;
						num47 = num21;
						num34 = num37;
						num10 = num37;
						num35 = (int)num36;
						if (obj61 != null)
						{
							continue;
						}
						goto IL_4951;
					}
					float num52 = ((_003C_003Ec__DisplayClass47_0)obj38)._003CBowl_003Eg__Lap_007C0(7);
					if (shape3.at != null)
					{
						source2 = (Source)obj27;
						Vector3 vector3 = shape3.at.get_Item(0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
						object obj62 = 0;
						if (shape3.at != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj63 = 0;
							object obj64 = obj63;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3672 @ X8_v54+A0]");
							object obj65 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3673 @ X8_v55+4]");
							double num53 = 0.0 * 63.0;
							Enumerator<, > enumerator3 = shape3.at.GetEnumerator();
							num54 = num53;
							num21 = num21;
							num13 = num22;
							num25 = num34;
							num14 = num34;
							object obj67 = default;
							while (val.MoveNext())
							{
								object obj66 = (object)(&obj67);
								double num55 = (double)num25 - num54;
								double num56 = num54 + (double)num25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3790 @ X8_v123+FF]");
								num21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								double num57 = num56 - num55;
								num13 = num57 * 63.0;
								num14 = (float)num55 + (float)num13;
								num54 = num13;
								num25 = (int)num14;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A20]");
							object obj68 = 0;
							vector2Int2 = (Vector2Int)obj68;
							val.Dispose();
							Enumerator<, > val9 = default;
							val = val9;
							num44 = 63.0;
							num19 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v32+30]");
							Vector3[] array2 = (Vector3[])0;
							obj19 = obj60;
							num3 = num14;
							num11 = num21;
							OutOfMemoryException ex = new OutOfMemoryException();
							num6 = (double)source6;
							num7 = num21;
							num9 = num10;
							num48 = (double)val5;
							goto IL_4df4;
						}
					}
				}
			}
		}
		goto IL_4951;
		IL_500e:
		object obj69 = obj38;
		int num58 = num;
		object obj70 = obj36;
		num26 = num11;
		goto IL_5acd;
		IL_4c0f:
		throw new IndexOutOfRangeException();
		IL_5acd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A28]");
		object obj71 = 0;
		vector2Int2 = (Vector2Int)obj71;
		((Enumerator<, >*)val8)->Dispose();
		bool flag31 = obj70 == null;
		object obj72 = !flag31;
		if (obj72 == null)
		{
			bool flag32 = obj35 == null;
			object obj73 = !flag32;
			num20 = num22;
			ex10 = (NullReferenceException)val8;
			num27 = num26;
			if (obj73 == null)
			{
				object obj74 = obj39 | 0x10;
				if ((nint)obj74 != 16)
				{
					return;
				}
				float num59 = ((_003C_003Ec__DisplayClass47_0)obj69)._003CBowl_003Eg__Lap_007C0(4);
				object obj75 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2923 @ X0_v35+E4]");
				bool flag33 = (nint)0 == 0;
				object obj76 = !flag33;
				if (obj76 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Flip(shape3);
				object obj77 = 17281024 + 1840;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6900]");
				object obj78 = 0;
				object obj79 = num26 - 9;
				bool flag34 = obj79 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X10_v7+v434 @ Z_v7 (System.Boolean)*4]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AE0]");
				object obj80 = 0;
				Func<Vector3, Vector3, bool> func = default;
				func._002Ector(obj69, (IntPtr)obj80);
				shape3.Refine(func, 6);
				object obj81 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3149 @ X0_v41+E4]");
				bool flag35 = (nint)0 == 0;
				object obj82 = !flag35;
				if (obj82 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Flip(shape3);
				List<Vector3> at3 = shape3.at;
				bool flag36 = shape3.at == null;
				source2 = (Source)6;
				if (!flag36)
				{
					int value5 = ((int*)num58)->m_value;
					bool flag37 = ((int*)num58)->m_value == 0;
					source2 = (Source)6;
					if (!flag37)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X8_v26 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						_ = 0;
						float num60 = ((_003C_003Ec__DisplayClass47_0)obj69)._003CBowl_003Eg__Lap_007C0(5);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A18]");
						object obj83 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A08]");
						object obj84 = 0;
						vector2Int = (Vector2Int)obj84;
						dictionary._002Ector();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X22_v10 (System.Object)+28]");
						object obj85 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X22_v10 (System.Object)+28]");
						bool flag38 = (nint)0 == 0;
						source2 = (Source)6;
						if (!flag38)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v32+30]");
							Vector3[] array3 = (Vector3[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v32+30]");
							bool flag39 = (nint)0 == 0;
							source2 = (Source)6;
							if (!flag39)
							{
								object obj86 = array3.Length;
								bool flag40 = array3.Length < 1;
								obj60 = 0;
								source2 = (Source)6;
								if (flag40)
								{
									goto IL_2f52;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A00]");
								object obj87 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A10]");
								source5 = (Source)0;
								object obj89 = default;
								object obj88 = obj89;
								bool flag41 = flag25;
								double num61 = num54;
								float num62 = num46;
								float num63 = num47;
								int num65 = default;
								int num64 = num65;
								double num67 = default;
								double num66 = num67;
								double num68 = num44;
								num8 = num21;
								double num69 = num13;
								int num70 = num10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v32+30]");
								Vector3[] array2 = (Vector3[])0;
								obj19 = 0;
								object obj90 = obj27;
								Source source8 = (Source)6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
								num3 = 0.0;
								int size = 0;
								object obj91 = obj3;
								Dictionary<Vector2Int, float> dictionary2 = dictionary;
								list3 = (List<int>)(object)shape3;
								int num71 = num15;
								while (true)
								{
									bool flag42 = size < (nint)obj86;
									object obj92 = !flag42;
									obj89 = obj88;
									flag25 = flag41;
									num54 = num61;
									num46 = num62;
									num47 = num63;
									num65 = num64;
									num67 = num66;
									num44 = num68;
									num6 = (double)source6;
									num13 = num69;
									num19 = num22;
									num10 = num70;
									num48 = (double)val5;
									source2 = source8;
									num11 = num26;
									if (obj92 != null)
									{
										break;
									}
									object obj93 = array2 + size;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v139+20]");
									List<int> list7 = (List<int>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v139+20]");
									bool flag43 = (nint)0 == 0;
									source2 = source8;
									obj3 = obj91;
									if (!flag43)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X19_v17 (System.Collections.Generic.List`1<System.Int32>)+18]");
										if ((nint)0 < (nint)1)
										{
											goto IL_2e7c;
										}
										double num72 = num66;
										int num73 = num8;
										double num74 = num69;
										Vector2Int vector2Int5 = vector2Int3;
										object obj94 = obj19;
										object obj95 = obj90;
										source2 = source8;
										double num75 = num3;
										obj3 = obj91;
										int num76 = 0;
										object obj96 = obj28;
										int num77 = num71;
										while (true)
										{
											int value6 = ((int*)num77)->m_value;
											if (((int*)num77)->m_value == 0)
											{
												break;
											}
											source2 = (Source)obj3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v139+20]");
											int index = ((List<int>)0).get_Item(num76);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v144 (System.Int32)+10]");
											if ((nint)0 == 0)
											{
												break;
											}
											source2 = (Source)obj95;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v144 (System.Int32)+10]");
											Vector3 vector4 = ((List<Vector3>)0).get_Item(index);
											int value7 = ((int*)num77)->m_value;
											if (((int*)num77)->m_value == 0)
											{
												break;
											}
											source2 = (Source)obj3;
											int index2 = num76 + 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v139+20]");
											int index3 = ((List<int>)0).get_Item(index2);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v145 (System.Int32)+10]");
											if ((nint)0 == 0)
											{
												break;
											}
											source2 = (Source)obj95;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v145 (System.Int32)+10]");
											Vector3 vector5 = ((List<Vector3>)0).get_Item(index3);
											int value8 = ((int*)num77)->m_value;
											if (((int*)num77)->m_value == 0)
											{
												break;
											}
											source2 = (Source)obj3;
											int index4 = num76 + 2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v139+20]");
											int index5 = ((List<int>)0).get_Item(index4);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X8_v146 (System.Int32)+10]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X8_v146 (System.Int32)+10]");
											Vector3 vector6 = ((List<Vector3>)0).get_Item(index5);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
											object obj97 = 0;
											object obj98 = obj97;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3725 @ X0_v184+E4]");
											bool flag44 = (nint)0 == 0;
											object obj99 = !flag44;
											if (obj99 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											float num78 = Into((Vector3)sign, num26, (int)obj95);
											float num79 = Into((Vector3)sign, num26, (int)obj95);
											float num80 = Into((Vector3)sign, num26, (int)obj95);
											if (num79 < num80)
											{
												num80 = num79;
											}
											if (!(num78 < num80))
											{
												num78 = num80;
											}
											flag41 = !(num78 < 0f);
											num63 = (flag41 ? num78 : 0f);
											float num81 = num63;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
											float num82 = num81 - 0f;
											bool flag45 = num82 == 0f;
											obj88 = !flag45;
											float num83 = num63;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
											bool flag46 = num83 > 0f;
											float num84 = num79;
											num8 = num73;
											num69 = 0.0;
											double num18 = num74;
											source8 = (Source)obj95;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
											num3 = 0.0;
											vector2Int = (Vector2Int)num26;
											dictionary2 = (Dictionary<Vector2Int, float>)sign;
											list3 = (List<int>)num26;
											if (!flag46)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
												object obj100 = 0;
												Vector2 p2 = (Vector2)obj100;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4059 @ X0_v191 (UnityEngine.Vector2)+E4]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												object obj101 = num73 - num73;
												bool flag47 = (nint)obj101 < 0;
												bool flag48 = obj101 == null;
												int num85 = num73 ^ num73;
												int num86 = num73 ^ obj101;
												int num87 = num85 & num86;
												bool flag49 = num87 < 0;
												int num88 = ((num73 >= num73) ? num73 : num73);
												bool flag50 = flag47 == flag49;
												object obj102 = !flag48;
												object obj103 = flag50 & obj102;
												object obj104 = ~obj103;
												if (obj104 == null)
												{
												}
												double num89 = num74 - num74;
												bool flag51 = num89 < 0.0;
												bool flag52 = num89 == 0.0;
												object obj105 = num74 ^ num74;
												object obj106 = num74 ^ num89;
												object obj107 = obj105 & obj106;
												bool flag53 = (nint)obj107 < 0;
												double num90 = ((!(num74 < num74)) ? num74 : num74);
												bool flag54 = flag51 == flag53;
												object obj108 = !flag52;
												object obj109 = flag54 & obj108;
												object obj110 = ~obj109;
												num72 = ((obj110 != null) ? num74 : num74);
												if (num74 < num90)
												{
												}
												if (num73 < num88)
												{
												}
												double num91 = num74 - num72;
												bool flag55 = num91 < 0.0;
												bool flag56 = num91 == 0.0;
												object obj111 = num74 ^ num72;
												object obj112 = num74 ^ num91;
												object obj113 = obj111 & obj112;
												bool flag57 = (nint)obj113 < 0;
												bool flag58 = flag55 == flag57;
												object obj114 = !flag56;
												object obj115 = flag58 & obj114;
												object obj116 = ~obj115;
												num84 = ((obj116 != null) ? ((float)num72) : ((float)num74));
												object obj117 = num73 - num73;
												bool flag59 = (nint)obj117 < 0;
												bool flag60 = obj117 == null;
												int num92 = num73 ^ num73;
												int num93 = num73 ^ obj117;
												int num94 = num92 & num93;
												bool flag61 = num94 < 0;
												bool flag62 = flag59 == flag61;
												object obj118 = !flag60;
												object obj119 = flag62 & obj118;
												flag41 = (byte)(int)(~obj119) != 0;
												num18 = (flag41 ? ((double)num73) : ((double)num73));
												Vector2Int vector2Int6 = _003CBowl_003Eg__SquareOf_007C47_3(p2);
												Vector2Int vector2Int7 = _003CBowl_003Eg__SquareOf_007C47_3(vector2Int6);
												object obj120 = vector2Int6 - vector2Int7;
												bool flag63 = obj120 == null;
												obj88 = !flag63;
												bool flag64 = vector2Int6 > vector2Int7;
												num8 = num73;
												num69 = num18;
												vector2Int5 = vector2Int7;
												source8 = (Source)obj95;
												num3 = num84;
												vector2Int = (Vector2Int)num26;
												dictionary2 = (Dictionary<Vector2Int, float>)vector2Int7;
												list3 = (List<int>)vector2Int6;
												if (!flag64)
												{
													object obj121 = vector2Int6 >> 32;
													obj96 = vector2Int7 >> 32;
													object obj122 = obj94;
													source2 = (Source)obj95;
													double num95 = num84;
													int num96 = num26;
													Vector2Int vector2Int8 = vector2Int7;
													List<int> list8 = (List<int>)vector2Int6;
													while (true)
													{
														object obj123 = obj121 - obj96;
														bool flag65 = obj123 == null;
														obj88 = !flag65;
														bool flag66 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj121) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj96);
														vector2Int = (Vector2Int)num96;
														dictionary2 = (Dictionary<Vector2Int, float>)vector2Int8;
														if (!flag66)
														{
															if ((object)dictionary == null)
															{
																break;
															}
															object obj124 = obj121;
															bool flag69;
															do
															{
																Vector2Int vector2Int9 = (Vector2Int)((object)list8 | obj124);
																obj122 = obj87;
																bool flag67 = dictionary.TryGetValue(vector2Int9, out var value9);
																if (flag67)
																{
																	bool flag68 = !(num63 < value9);
																	source2 = (Source)(&value9);
																	num95 = value9;
																	vector2Int = vector2Int9;
																	dictionary2 = (Dictionary<Vector2Int, float>)flag67;
																	if (flag68)
																	{
																		goto IL_2cd8;
																	}
																}
																dictionary.set_Item(vector2Int9, num63);
																source2 = source5;
																num95 = num63;
																vector2Int = vector2Int9;
																dictionary2 = dictionary;
																goto IL_2cd8;
																IL_2cd8:
																obj95 = obj124 + 1;
																flag69 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj95) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj96);
																obj3 = list8;
																num77 = (int)vector2Int9;
																obj124 = obj95;
															}
															while (flag69);
														}
														list3 = (List<int>)(list8 + 1);
														bool flag70 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)list3) <= System.Runtime.CompilerServices.Unsafe.As<Vector2Int, UIntPtr>(ref vector2Int7);
														num8 = num73;
														num69 = num18;
														vector2Int5 = vector2Int7;
														obj94 = obj122;
														source8 = source2;
														num3 = num95;
														num96 = (int)vector2Int;
														vector2Int8 = (Vector2Int)dictionary2;
														list8 = list3;
														if (flag70)
														{
															continue;
														}
														goto IL_2d92;
													}
													break;
												}
											}
											goto IL_2d92;
											IL_2d92:
											num58 = num76 + 3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
											obj91 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
											obj90 = 0;
											int num97 = num58;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X19_v17 (System.Collections.Generic.List`1<System.Int32>)+18]");
											bool flag71 = (nint)num97 < (nint)0;
											num61 = num75;
											num62 = (float)num74;
											num66 = num72;
											num68 = num84;
											num70 = num73;
											vector2Int3 = vector2Int5;
											obj19 = obj94;
											obj28 = obj96;
											num71 = num25;
											num73 = num8;
											num74 = num69;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
											obj95 = 0;
											source2 = source8;
											num75 = num3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
											obj3 = 0;
											num76 = num58;
											num77 = num25;
											if (flag71)
											{
												continue;
											}
											goto IL_2e7c;
										}
									}
									goto IL_4951;
									IL_2e7c:
									obj86 = array3.Length;
									int num98 = size + 1;
									bool flag72 = num98 < array3.Length;
									obj89 = obj88;
									flag25 = flag41;
									num54 = num61;
									num46 = num62;
									num47 = num63;
									num65 = size;
									num67 = num66;
									num44 = num68;
									num21 = num8;
									num13 = num69;
									num10 = num70;
									obj60 = obj19;
									obj27 = obj90;
									source2 = source8;
									obj3 = obj91;
									num15 = num71;
									num64 = size;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v32+30]");
									array2 = (Vector3[])0;
									size = num98;
									if (flag72)
									{
										continue;
									}
									goto IL_2f52;
								}
								goto IL_4c0f;
							}
						}
					}
				}
				goto IL_4951;
			}
			goto IL_4d84;
		}
		goto IL_4da3;
		IL_4951:
		throw new NullReferenceException();
		IL_4df4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex11 = new ArgumentNullException();
		int num99 = 0;
		num8 = (int)num7;
		num10 = (int)num9;
		vector2Int = (Vector2Int)num99;
		Vector2Int vector2Int10 = (Vector2Int)num99;
		list3 = (List<int>)(object)ex11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DA88");
		double num100 = num8;
		double num101 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
		obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		obj28 = 0;
		if (vector2Int10 == (Vector2Int)(object)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			source6 = (Source)num6;
			num21 = (int)num100;
			num22 = num19;
			num10 = (int)num101;
			obj35 = 1;
			val5 = (Enumerator<, >)num48;
			num14 = (float)num3;
			obj39 = 0;
			num15 = num25;
			goto IL_500e;
		}
		if (vector2Int10 == (Vector2Int)(object)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj125 = default;
			obj70 = obj125;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			source6 = (Source)num6;
			num21 = (int)num100;
			num22 = num19;
			num10 = (int)num101;
			obj36 = obj125;
			val5 = (Enumerator<, >)num48;
			obj69 = obj38;
			num14 = (float)num3;
			num58 = num;
			obj39 = 0;
			num26 = num11;
			num15 = num25;
			goto IL_5acd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DA88");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	private static Vector2 YZ(Vector3 p)
	{
		return p;
	}

	private static float ToSegment(Vector2 p, Vector2 a, Vector2 b)
	{
		//IL_0053: Expected Obj, but got I
		//IL_0063: Invalid comparison between F8 and I
		//IL_007d: Expected F8, but got I4
		//IL_0219: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_00ea: Invalid comparison between F8 and I4
		//IL_00f9: Expected F8, but got I4
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		object obj7 = obj * obj;
		object obj8 = obj4 * obj4;
		double num = (double)obj8 + (double)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
		object obj9 = 0;
		double num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
		bool flag = !(num2 > 0.0);
		double num4 = default;
		double num3 = num4;
		double num5 = 0.0;
		object obj11 = default;
		if (!flag)
		{
			double num6 = num4 - (double)obj6;
			object obj10 = obj11 - obj3;
			double num7 = num6 * (double)obj4;
			obj9 = obj10 * obj;
			double num8 = num7 + (double)obj9;
			num3 = num8 / num;
			bool flag2 = num3 < 0.0;
			num5 = 0.0;
			if (!flag2)
			{
				bool flag3 = !(num3 > 1.0);
				num = 1.0;
				num5 = num3;
				if (!flag3)
				{
					num = 1.0;
					num5 = 1.0;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num9 = (double)obj * num5;
		double num10 = (double)obj4 * num5;
		double num11 = (double)obj3 + num9;
		double num12 = (double)obj6 + num10;
		double num13 = (double)obj11 - num11;
		double num14 = num4 - num12;
		double num15 = num14 * num14;
		double num16 = num13 * num13;
		float result = (float)num15 + (float)num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		return result;
	}

	private unsafe static List<List<int>> Loops(Shape s, List<(int, int)> rim, Half half)
	{
		//IL_0010: Expected Obj, but got I
		//IL_22b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected I4, but got Unknown
		//IL_00e7: Expected I4, but got Obj
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Expected Obj, but got I4
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ff: Expected Obj, but got I4
		//IL_2490: Expected Obj, but got I
		//IL_2498: Expected I4, but got Obj
		//IL_2498: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a1: Expected Ref, but got Unknown
		//IL_24bb: Expected Obj, but got I4
		//IL_24bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c3: Expected I4, but got Unknown
		//IL_1993: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected Obj, but got I4
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected I4, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Expected Obj, but got I
		//IL_0a5e: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I4
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected I4, but got Unknown
		//IL_02d7: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I4
		//IL_02f9: Expected I4, but got Obj
		//IL_19ed: Expected Obj, but got I4
		//IL_031c: Expected I8, but got I4
		//IL_2332: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected I8, but got I4
		//IL_0ac6: Expected Obj, but got I
		//IL_0ad4: Expected Obj, but got I4
		//IL_0ae8: Expected Obj, but got I
		//IL_1958: Unknown result type (might be due to invalid IL or missing references)
		//IL_195c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Expected Obj, but got I
		//IL_0b24: Expected Obj, but got I
		//IL_196e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got I4
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected I4, but got I8
		//IL_0b43: Expected Obj, but got I
		//IL_0b54: Expected I, but got Obj
		//IL_0b68: Expected I, but got Obj
		//IL_0394: Expected Obj, but got I
		//IL_039c: Expected I, but got Obj
		//IL_03b2: Expected Obj, but got I4
		//IL_03d0: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got Ref
		//IL_0ba6: Expected Obj, but got I
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2362: Unknown result type (might be due to invalid IL or missing references)
		//IL_237c: Expected Obj, but got I4
		//IL_237c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2380: Unknown result type (might be due to invalid IL or missing references)
		//IL_2388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Expected I, but got Obj
		//IL_03fe: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I
		//IL_050b: Expected Obj, but got I
		//IL_0529: Expected I4, but got Obj
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got I4
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got I4
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e3: Expected Obj, but got I
		//IL_1a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected Obj, but got I4
		//IL_05ac: Expected Obj, but got I
		//IL_05d5: Expected Obj, but got I4
		//IL_04af: Expected Obj, but got I
		//IL_04b7: Expected I, but got Obj
		//IL_04cd: Expected Obj, but got I4
		//IL_0635: Expected Obj, but got I
		//IL_0645: Expected Obj, but got I
		//IL_0655: Expected Obj, but got I
		//IL_1a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Expected I4, but got Obj
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got I4
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected Obj, but got I
		//IL_06da: Expected Obj, but got I
		//IL_06e2: Expected I, but got Obj
		//IL_06f8: Expected Obj, but got I4
		//IL_0716: Expected Obj, but got I4
		//IL_071e: Expected Obj, but got Ref
		//IL_18d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18dc: Expected I4, but got Unknown
		//IL_23b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d2: Expected Obj, but got I4
		//IL_23d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23de: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b03: Expected Obj, but got I
		//IL_1b13: Expected Obj, but got I
		//IL_1b23: Expected Obj, but got I
		//IL_1b34: Expected Obj, but got I
		//IL_1b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_190a: Unknown result type (might be due to invalid IL or missing references)
		//IL_190e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected Obj, but got I
		//IL_075e: Expected Obj, but got I
		//IL_264e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2652: Unknown result type (might be due to invalid IL or missing references)
		//IL_2656: Unknown result type (might be due to invalid IL or missing references)
		//IL_265a: Unknown result type (might be due to invalid IL or missing references)
		//IL_266e: Expected Obj, but got I4
		//IL_0c94: Expected Obj, but got I
		//IL_0cae: Expected Obj, but got I
		//IL_0cb6: Expected I4, but got Obj
		//IL_0841: Expected Obj, but got I
		//IL_0851: Expected Obj, but got I
		//IL_086f: Expected I4, but got Obj
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got I4
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got I4
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b98: Expected Obj, but got I4
		//IL_08f2: Expected Obj, but got I
		//IL_091b: Expected Obj, but got I4
		//IL_07f5: Expected Obj, but got I
		//IL_07fd: Expected I, but got Obj
		//IL_0813: Expected Obj, but got I4
		//IL_0cf1: Expected Obj, but got I
		//IL_0d01: Expected Obj, but got I
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected Obj, but got I
		//IL_0993: Expected Obj, but got I
		//IL_09a3: Expected Obj, but got I
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc6: Expected Obj, but got I
		//IL_1c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c34: Expected Obj, but got I4
		//IL_0946: Expected Obj, but got I
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d69: Expected Obj, but got I
		//IL_0d92: Expected Obj, but got I4
		//IL_1c5f: Expected Obj, but got I
		//IL_1c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1caa: Expected Obj, but got I4
		//IL_0df2: Expected Obj, but got I
		//IL_0e02: Expected Obj, but got I
		//IL_0e12: Expected Obj, but got I
		//IL_0e3c: Expected Obj, but got I
		//IL_0e56: Expected Obj, but got I
		//IL_0e5e: Expected I4, but got Obj
		//IL_0dbd: Expected Obj, but got I
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd0: Expected Obj, but got I
		//IL_1d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d51: Expected Obj, but got I
		//IL_1d71: Expected Obj, but got I4
		//IL_0e99: Expected Obj, but got I
		//IL_0ea1: Expected I, but got Obj
		//IL_0ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec4: Expected I4, but got Unknown
		//IL_0eed: Expected Obj, but got I4
		//IL_1d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8c: Expected Obj, but got Unknown
		//IL_1dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df8: Expected Obj, but got I4
		//IL_1e0d: Expected Obj, but got I8
		//IL_2082: Unknown result type (might be due to invalid IL or missing references)
		//IL_2086: Unknown result type (might be due to invalid IL or missing references)
		//IL_208a: Unknown result type (might be due to invalid IL or missing references)
		//IL_208e: Unknown result type (might be due to invalid IL or missing references)
		//IL_25bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f15: Expected Obj, but got I4
		//IL_20fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2103: Unknown result type (might be due to invalid IL or missing references)
		//IL_2107: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e52: Expected Obj, but got I4
		//IL_15b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2141: Expected Obj, but got I4
		//IL_1e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1763: Expected Obj, but got I4
		//IL_1782: Expected Obj, but got I4
		//IL_17b2: Expected I4, but got Obj
		//IL_1890: Unknown result type (might be due to invalid IL or missing references)
		//IL_2161: Unknown result type (might be due to invalid IL or missing references)
		//IL_2166: Expected Obj, but got Unknown
		//IL_218f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2194: Expected Obj, but got Unknown
		//IL_1ed1: Expected Obj, but got I
		//IL_1ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee2: Expected Obj, but got Unknown
		//IL_1f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Expected Obj, but got I4
		//IL_0fd2: Expected I4, but got Obj
		//IL_1f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1611: Expected Obj, but got I
		//IL_162c: Expected I4, but got Obj
		//IL_24ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Expected Obj, but got I4
		//IL_1025: Expected I4, but got Obj
		//IL_252d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2531: Unknown result type (might be due to invalid IL or missing references)
		//IL_253d: Expected Obj, but got I4
		//IL_1682: Expected Obj, but got I4
		//IL_16a2: Expected Obj, but got I4
		//IL_1f7e: Expected Obj, but got I4
		//IL_171c: Expected Obj, but got I
		//IL_172c: Expected Obj, but got I
		//IL_173c: Expected Obj, but got I
		//IL_174d: Unknown result type (might be due to invalid IL or missing references)
		//IL_105a: Expected I4, but got Obj
		//IL_1f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f95: Expected Obj, but got Unknown
		//IL_1faf: Expected Obj, but got I4
		//IL_1fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcf: Expected Obj, but got I4
		//IL_16c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c7: Expected Obj, but got Unknown
		//IL_16d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16de: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e7: Expected I4, but got Unknown
		//IL_16f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f5: Expected Obj, but got Unknown
		//IL_1fea: Expected I4, but got Obj
		//IL_2008: Expected I, but got Obj
		//IL_2019: Expected I4, but got Obj
		//IL_2029: Unknown result type (might be due to invalid IL or missing references)
		//IL_202d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1300: Expected Obj, but got I
		//IL_1308: Expected I, but got Obj
		//IL_1331: Expected Obj, but got I
		//IL_1341: Expected Obj, but got I
		//IL_135f: Expected I4, but got Obj
		//IL_138b: Expected Obj, but got I
		//IL_1397: Unknown result type (might be due to invalid IL or missing references)
		//IL_113d: Expected Obj, but got I4
		//IL_1155: Expected I4, but got Obj
		//IL_13d9: Expected Obj, but got I
		//IL_1402: Expected Obj, but got I4
		//IL_147a: Expected Obj, but got I
		//IL_148a: Expected Obj, but got I
		//IL_142d: Expected Obj, but got I
		//IL_119f: Expected Obj, but got I4
		//IL_11b7: Expected I4, but got Obj
		//IL_1535: Expected Obj, but got I
		//IL_153d: Expected I, but got Obj
		//IL_11e2: Expected Obj, but got I
		//IL_11fd: Expected I4, but got Obj
		//IL_1226: Expected Obj, but got I4
		//IL_123e: Expected I4, but got Obj
		//IL_1256: Expected Obj, but got I4
		//IL_1276: Expected Obj, but got I4
		//IL_1296: Unknown result type (might be due to invalid IL or missing references)
		//IL_129b: Expected Obj, but got Unknown
		//IL_12c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c9: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		Enumerator<, > val = (Enumerator<, >)0;
		Half half2 = half;
		object obj3 = null;
		object obj4 = obj2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B68]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B70]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BA0]");
			Comparison<int> comparison = (Comparison<int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B98]");
			object obj7 = 0;
			object obj8 = obj2 + 16;
			obj8 = s;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<Vector3Int, System.__Canon> dictionary = default;
			dictionary._002Ector();
			object obj9 = obj2 + 24;
			obj9 = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<int, System.__Canon> dictionary2 = default;
			dictionary2._002Ector();
			int num = obj2 + 32;
			((int*)num)->m_value = (int)dictionary2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			obj3 = obj7;
			HashSet<long> hashSet = default;
			hashSet._002Ector();
			bool flag2 = rim == null;
			val = (Enumerator<, >)0;
			half2 = half;
			obj4 = obj2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B50]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
				object obj11 = 0;
				Enumerator<, > enumerator = rim.GetEnumerator();
				System.__Canon value = null;
				System.__Canon value2 = null;
				half2 = half;
				Enumerator<, > val3 = default;
				Enumerator<, > val2 = (Enumerator<, >)(ref val3);
				int num3 = default;
				Enumerator<, > val6 = default;
				List<int> list = default;
				List<int> list2 = default;
				object obj42 = default;
				OutOfMemoryException ex3 = default;
				List<List<int>> result = default;
				List<System.__Canon> list3 = default;
				List<System.__Canon> list4 = default;
				List<int> list5 = default;
				Comparison<int> comparison2 = default;
				Enumerator<, > val8 = default;
				List<int> list6 = default;
				Dictionary<int, int> dictionary4 = default;
				object obj22 = default;
				int num9 = default;
				object obj87 = default;
				object obj89 = default;
				while (true)
				{
					Enumerator<, > val4;
					int num6;
					HashSet<long> hashSet2;
					object obj12;
					Enumerator<, > val5;
					nint num14;
					Enumerator<, > val7;
					if (val3.MoveNext())
					{
						int num2 = ((_003C_003Ec__DisplayClass52_0)obj2)._003CLoops_003Eg__Point_007C0(num3);
						int v = num3 >> 32;
						int num4 = ((_003C_003Ec__DisplayClass52_0)obj2)._003CLoops_003Eg__Point_007C0(v);
						bool flag3 = num2 == num4;
						int num5 = num4;
						if (flag3)
						{
							continue;
						}
						bool flag4 = hashSet == null;
						num6 = 0;
						val4 = (Enumerator<, >)0;
						num5 = num4;
						hashSet2 = null;
						obj12 = 0;
						int num7 = (int)val2;
						val5 = val6;
						val6 = (Enumerator<, >)(ref val3);
						if (flag4)
						{
							goto IL_1917;
						}
						int num8 = num4 | num2;
						num7 = num2 | num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B90]");
						num9 = 0;
						object obj13 = num2 - num4;
						bool flag5 = (nint)obj13 < 0;
						int num10 = num2 ^ num4;
						int num11 = num2 ^ obj13;
						int num12 = num10 & num11;
						bool flag6 = num12 < 0;
						half2 = (Half)((int*)num9)->m_value;
						bool flag7 = flag5 == flag6;
						object obj14 = !flag7;
						long num13 = (((int)(~obj14) != 0) ? num7 : num8);
						bool flag8 = hashSet.Add(num13);
						bool flag9 = !flag8;
						num5 = num4;
						val2 = (Enumerator<, >)num7;
						if (flag9)
						{
							continue;
						}
						bool flag10 = ((int*)num)->m_value == 0;
						num6 = 0;
						val4 = (Enumerator<, >)0;
						num5 = num4;
						hashSet2 = null;
						obj12 = 0;
						val5 = val6;
						val6 = (Enumerator<, >)(ref val3);
						v = (int)num13;
						if (!flag10)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B38]");
							object obj15 = 0;
							num14 = (nint)obj15;
							bool flag11 = ((Dictionary<int, System.__Canon>)((int*)num)->m_value).TryGetValue(num2, out value2);
							bool flag12 = !flag11;
							object obj16 = !flag12;
							half2 = (Half)(&value2);
							v = num2;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
								object obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
								object obj18 = 0;
								half2 = (Half)obj18;
								list._002Ector(2);
								bool flag13 = ((int*)num)->m_value == 0;
								num6 = 0;
								val4 = (Enumerator<, >)0;
								value2 = (System.__Canon)(object)list;
								num5 = num4;
								hashSet2 = null;
								obj12 = 0;
								val5 = (Enumerator<, >)(ref val3);
								val7 = (Enumerator<, >)(ref val3);
								v = 2;
								if (flag13)
								{
									goto IL_1965;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B60]");
								object obj19 = 0;
								num14 = (nint)obj19;
								((Dictionary<int, System.__Canon>)((int*)num)->m_value).set_Item(num2, (System.__Canon)(object)list);
								value2 = (System.__Canon)(object)list;
								half2 = (Half)(object)list;
								v = num2;
							}
							bool flag14 = value2 == null;
							num6 = 0;
							val4 = (Enumerator<, >)0;
							num5 = num4;
							hashSet2 = null;
							obj12 = 0;
							val5 = val6;
							val6 = (Enumerator<, >)(ref val3);
							if (!flag14)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ stack_-A8_v4 (System.__Canon)+10]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ stack_-A8_v4 (System.__Canon)+1C]");
								num9 = (int)((nint)0 + (nint)1);
								num7 = (int)obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ stack_-A8_v4 (System.__Canon)+10]");
								bool flag15 = (nint)0 == 0;
								num6 = 0;
								val4 = (Enumerator<, >)0;
								num5 = num4;
								hashSet2 = null;
								obj12 = 0;
								val5 = (Enumerator<, >)(ref val3);
								val6 = (Enumerator<, >)(ref val3);
								if (!flag15)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ stack_-A8_v4 (System.__Canon)+18]");
									num9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X8_v132+18]");
									obj22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ stack_-A8_v4 (System.__Canon)+18]");
									nint num15 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X8_v132+18]");
									bool flag16 = num15 < 0;
									object obj23 = !flag16;
									if (obj23 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ stack_-A8_v4 (System.__Canon)+10]");
										nint num16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ stack_-A8_v4 (System.__Canon)+18]");
										object obj24 = num16 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ stack_-A8_v4 (System.__Canon)+18]");
										num7 = (int)((nint)0 + (nint)1);
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2121 @ X9_v30 (System.Int32)+20]");
										object obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ X8_v147+A8]");
										object obj26 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X8_v148+70]");
										half2 = (Half)0;
										((List<int>)(object)value2).AddWithResize(num4);
										v = num4;
									}
									bool flag17 = ((int*)num)->m_value == 0;
									num6 = 0;
									val4 = (Enumerator<, >)0;
									num5 = num4;
									hashSet2 = null;
									obj12 = 0;
									val5 = val6;
									val6 = (Enumerator<, >)(ref val3);
									if (!flag17)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B38]");
										object obj27 = 0;
										num14 = (nint)obj27;
										bool flag18 = ((Dictionary<int, System.__Canon>)((int*)num)->m_value).TryGetValue(num4, out value);
										bool flag19 = !flag18;
										object obj28 = !flag19;
										half2 = (Half)(&value);
										v = num4;
										if (obj28 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
											object obj29 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
											object obj30 = 0;
											half2 = (Half)obj30;
											list2._002Ector(2);
											bool flag20 = ((int*)num)->m_value == 0;
											num6 = 0;
											val = (Enumerator<, >)0;
											value = (System.__Canon)(object)list2;
											num5 = num4;
											hashSet2 = null;
											obj12 = 0;
											val5 = (Enumerator<, >)(ref val3);
											val7 = (Enumerator<, >)(ref val3);
											v = 2;
											if (flag20)
											{
												goto IL_197b;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B60]");
											object obj31 = 0;
											num14 = (nint)obj31;
											((Dictionary<int, System.__Canon>)((int*)num)->m_value).set_Item(num4, (System.__Canon)(object)list2);
											value = (System.__Canon)(object)list2;
											half2 = (Half)(object)list2;
											v = num4;
										}
										bool flag21 = value == null;
										num6 = 0;
										val4 = (Enumerator<, >)0;
										num5 = num4;
										hashSet2 = null;
										obj12 = 0;
										val5 = val6;
										val6 = (Enumerator<, >)(ref val3);
										if (!flag21)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ stack_-B0_v4 (System.__Canon)+10]");
											object obj32 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
											object obj33 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ stack_-B0_v4 (System.__Canon)+1C]");
											num9 = (int)((nint)0 + (nint)1);
											num7 = (int)obj33;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ stack_-B0_v4 (System.__Canon)+10]");
											bool flag22 = (nint)0 == 0;
											num6 = 0;
											val4 = (Enumerator<, >)0;
											num5 = num4;
											hashSet2 = null;
											obj12 = 0;
											val5 = (Enumerator<, >)(ref val3);
											val6 = (Enumerator<, >)(ref val3);
											if (!flag22)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ stack_-B0_v4 (System.__Canon)+18]");
												num9 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1084 @ X8_v137+18]");
												obj22 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ stack_-B0_v4 (System.__Canon)+18]");
												nint num17 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1084 @ X8_v137+18]");
												bool flag23 = num17 < 0;
												object obj34 = !flag23;
												if (obj34 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ stack_-B0_v4 (System.__Canon)+10]");
													nint num18 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ stack_-B0_v4 (System.__Canon)+18]");
													object obj35 = num18 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ stack_-B0_v4 (System.__Canon)+18]");
													val2 = (Enumerator<, >)((nint)0 + (nint)1);
													num5 = num4;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2121 @ X9_v30 (System.Int32)+20]");
													object obj36 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1457 @ X8_v138+A8]");
													object obj37 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v139+70]");
													half2 = (Half)0;
													((List<int>)(object)value).AddWithResize(num2);
													num5 = num4;
													val2 = (Enumerator<, >)obj33;
												}
												continue;
											}
										}
										goto IL_1933;
									}
									goto IL_194f;
								}
							}
							goto IL_1925;
						}
						goto IL_1941;
					}
					num6 = 0;
					val = (Enumerator<, >)0;
					hashSet2 = null;
					obj12 = 0;
					val5 = val6;
					val7 = (Enumerator<, >)(ref val3);
					object obj38 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B78]");
						object obj39 = 0;
						int v = (int)obj39;
						((Enumerator<, >*)val7)->Dispose();
						bool flag24 = obj38 == null;
						object obj40 = !flag24;
						int num7 = (int)val2;
						if (obj40 == null)
						{
							bool flag25 = hashSet2 == null;
							object obj41 = !flag25;
							OutOfMemoryException ex = (OutOfMemoryException)val7;
							if (obj41 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
							val2 = (Enumerator<, >)num7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						switch (v)
						{
						case 2:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							hashSet2 = (HashSet<long>)1;
							obj38 = obj12;
							break;
						case 1:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj38 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj12 = obj42;
							break;
						default:
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DB00");
							OutOfMemoryException ex2 = ex3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return result;
						}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC0]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A90]");
					comparison = (Comparison<int>)0;
					list3._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					obj3 = comparison;
					list4._002Ector();
					bool flag26 = ((int*)num)->m_value == 0;
					obj4 = obj2;
					if (flag26)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B58]");
					object obj44 = 0;
					Dictionary<int, System.__Canon>.KeyCollection keys = ((Dictionary<int, System.__Canon>)((int*)num)->m_value).Keys;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BD8]");
					object obj46 = 0;
					list5._002Ector((IEnumerable<int>)(object)keys);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B20]");
					object obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BF0]");
					object obj48 = 0;
					comparison2._002Ector(obj2, (IntPtr)obj48);
					bool flag27 = list5 == null;
					num14 = unchecked((nint)null);
					half2 = (Half)obj48;
					comparison = comparison2;
					obj3 = obj2;
					obj4 = obj2;
					if (flag27)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BD0]");
					object obj49 = 0;
					half2 = (Half)obj49;
					list5.Sort(comparison2);
					Enumerator<, > enumerator2 = list5.GetEnumerator();
					num14 = unchecked((nint)null);
					comparison = comparison2;
					while (val8.MoveNext())
					{
						Dictionary<int, System.__Canon> dictionary3 = (Dictionary<int, System.__Canon>)((int*)num)->m_value;
						if (((int*)num)->m_value != 0)
						{
							object obj50 = obj22;
							nint num19 = num14;
							int num20 = num9;
							int num21 = (int)hashSet2;
							Comparison<int> comparison3 = comparison;
							while (true)
							{
								half2 = (Half)obj10;
								System.__Canon _Canon = dictionary3.get_Item(num21);
								bool flag28 = _Canon == null;
								int v = num21;
								int num7;
								int num5;
								if (!flag28)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ X0_v97 (System.__Canon)+18]");
									bool flag29 = (nint)0 <= (nint)0;
									obj22 = obj50;
									num14 = num19;
									num9 = num20;
									comparison = comparison3;
									if (flag29)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
									object obj51 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
									object obj52 = 0;
									v = (int)obj52;
									list6._002Ector();
									if (list6 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+10]");
										object obj53 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
										object obj54 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+1C]");
										num20 = (int)((nint)0 + (nint)1);
										val2 = (Enumerator<, >)obj54;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+10]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
											num20 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ X8_v76+18]");
											obj50 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
											nint num22 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ X8_v76+18]");
											bool flag30 = num22 < 0;
											object obj55 = !flag30;
											if (obj55 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+10]");
												nint num23 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
												object obj56 = num23 + 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
												val2 = (Enumerator<, >)((nint)0 + (nint)1);
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1604 @ X9_v27 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.Int32, System.Int32>>+Enumerator<System.ValueTuple`2<System.Int32, System.Int32>>)+20]");
												object obj57 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ X8_v114+A8]");
												object obj58 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1744 @ X8_v115+70]");
												half2 = (Half)0;
												list6.AddWithResize(num21);
												v = num21;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6070]");
											object obj59 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6078]");
											object obj60 = 0;
											v = (int)obj60;
											dictionary4._002Ector();
											if (dictionary4 == null)
											{
												goto IL_18cb;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B28]");
											object obj61 = 0;
											num19 = (nint)obj61;
											dictionary4.Add(num21, 0);
											int num24 = 0;
											num7 = (int)val2;
											v = num21;
											while (true)
											{
												bool flag31 = ((int*)num)->m_value == 0;
												half2 = (Half)num24;
												int num25;
												int num26;
												int num28;
												if (!flag31)
												{
													half2 = (Half)obj10;
													System.__Canon _Canon2 = ((Dictionary<int, System.__Canon>)((int*)num)->m_value).get_Item(num21);
													if (_Canon2 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1686 @ X0_v130 (System.__Canon)+18]");
														if ((nint)0 <= (nint)0)
														{
															break;
														}
														bool flag32 = ((int*)num)->m_value == 0;
														num5 = num21;
														v = num21;
														if (flag32)
														{
															goto IL_185f;
														}
														half2 = (Half)obj10;
														System.__Canon _Canon3 = ((Dictionary<int, System.__Canon>)((int*)num)->m_value).get_Item(num21);
														bool flag33 = ((int*)num)->m_value == 0;
														num5 = num21;
														num25 = (int)_Canon3;
														v = num21;
														if (flag33)
														{
															goto IL_183b;
														}
														half2 = (Half)obj10;
														System.__Canon _Canon4 = ((Dictionary<int, System.__Canon>)((int*)num)->m_value).get_Item(num21);
														bool flag34 = _Canon4 == null;
														num5 = num21;
														num25 = (int)_Canon3;
														v = num21;
														if (flag34)
														{
															goto IL_182d;
														}
														bool flag35 = _Canon3 == null;
														num5 = num21;
														num25 = (int)_Canon3;
														v = num21;
														if (flag35)
														{
															goto IL_1849;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1864 @ X0_v141 (System.__Canon)+18]");
														int index = (int)(-1);
														num26 = ((List<int>)(object)_Canon3).get_Item(index);
														((_003C_003Ec__DisplayClass52_0)obj2)._003CLoops_003Eg__TakeEdge_007C1(num21, num26);
														if (dictionary4.TryGetValue(num26, out num6))
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BB8]");
															num7 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
															int num27 = (int)(-num6);
															num19 = ((int*)num7)->m_value;
															List<int> range = list6.GetRange(num6, num27);
															bool flag36 = range == null;
															half2 = (Half)num27;
															num5 = num21;
															num28 = num26;
															v = (int)range;
															if (flag36)
															{
																goto IL_1875;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v150 (System.Collections.Generic.List`1<System.Int32>)+18]");
															if ((nint)0 < (nint)3)
															{
																goto IL_14d8;
															}
															bool flag37 = list3 == null;
															half2 = (Half)num27;
															num5 = num21;
															num28 = num26;
															v = (int)range;
															if (!flag37)
															{
																System.__Canon[] items = list3._items;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A50]");
																object obj62 = 0;
																num20 = list3._version + 1;
																num7 = (int)obj62;
																list3._version = num20;
																bool flag38 = list3._items == null;
																half2 = (Half)num27;
																num5 = num21;
																num28 = num26;
																v = (int)range;
																if (!flag38)
																{
																	obj50 = items.Length;
																	bool flag39 = list3._size < items.Length;
																	object obj63 = !flag39;
																	if (obj63 == null)
																	{
																		object obj64 = list3._items + list3._size;
																		int size = list3._size + 1;
																		list3._size = size;
																		object obj65 = obj64 + 32;
																		obj65 = range;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	}
																	else
																	{
																		list3.AddWithResize((System.__Canon)(object)range);
																	}
																	goto IL_14d8;
																}
															}
															goto IL_1883;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
														num24 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6048]");
														object obj66 = 0;
														num19 = (nint)obj66;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
														dictionary4.set_Item(num26, 0);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+10]");
														object obj67 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
														object obj68 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+1C]");
														num20 = (int)((nint)0 + (nint)1);
														num7 = (int)obj68;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+10]");
														bool flag40 = (nint)0 == 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
														half2 = (Half)0;
														num5 = num21;
														val2 = (Enumerator<, >)obj68;
														num28 = num26;
														v = num26;
														if (!flag40)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
															num20 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2146 @ X8_v101+18]");
															obj50 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
															nint num29 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2146 @ X8_v101+18]");
															bool flag41 = num29 < 0;
															object obj69 = !flag41;
															if (obj69 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+10]");
																nint num30 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
																object obj70 = num30 + 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
																num7 = (int)((nint)0 + (nint)1);
																num5 = num21;
																num21 = num26;
																v = num26;
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2121 @ X9_v30 (System.Int32)+20]");
																object obj71 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2240 @ X8_v102+A8]");
																object obj72 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1823 @ X8_v103+70]");
																num24 = 0;
																list6.AddWithResize(num26);
																num5 = num21;
																num21 = num26;
																v = num26;
															}
															continue;
														}
														goto IL_1899;
													}
													NullReferenceException ex4 = new NullReferenceException();
													num5 = num21;
													v = num21;
												}
												NullReferenceException ex5 = new NullReferenceException();
												num25 = num21;
												goto IL_182d;
												IL_1899:
												NullReferenceException ex6 = new NullReferenceException();
												num21 = num28;
												goto IL_18af;
												IL_1883:
												NullReferenceException ex7 = new NullReferenceException();
												val2 = (Enumerator<, >)num7;
												goto IL_1899;
												IL_182d:
												NullReferenceException ex8 = new NullReferenceException();
												goto IL_183b;
												IL_183b:
												NullReferenceException ex9 = new NullReferenceException();
												goto IL_1849;
												IL_14d8:
												num5 = num6 + 1;
												while (true)
												{
													int num31 = num5;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
													if ((nint)num31 >= (nint)0)
													{
														break;
													}
													int key = list6.get_Item(num5);
													num5++;
													bool flag42 = dictionary4.Remove(key);
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BC8]");
												object obj73 = 0;
												num19 = (nint)obj73;
												int num32 = ~num6;
												v = num6 + 1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
												num24 = (int)((nint)0 + (nint)num32);
												list6.RemoveRange(v, num24);
												num20 = num32;
												num7 = num6;
												num21 = num26;
												continue;
												IL_1849:
												NullReferenceException ex10 = new NullReferenceException();
												num21 = num25;
												goto IL_185f;
												IL_185f:
												NullReferenceException ex11 = new NullReferenceException();
												num28 = num21;
												goto IL_1875;
												IL_1875:
												NullReferenceException ex12 = new NullReferenceException();
												goto IL_1883;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X0_v105 (System.Collections.Generic.List`1<System.Int32>)+18]");
											bool flag43 = (nint)0 <= (nint)1;
											val2 = (Enumerator<, >)num7;
											if (flag43)
											{
												goto IL_1756;
											}
											bool flag44 = list4 == null;
											num5 = num21;
											v = num21;
											if (!flag44)
											{
												System.__Canon[] items2 = list4._items;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A50]");
												object obj74 = 0;
												num20 = list4._version + 1;
												num7 = (int)obj74;
												list4._version = num20;
												bool flag45 = list4._items == null;
												num5 = num21;
												v = num21;
												if (!flag45)
												{
													num20 = list4._size;
													obj50 = items2.Length;
													bool flag46 = list4._size < items2.Length;
													object obj75 = !flag46;
													if (obj75 == null)
													{
														object obj76 = list4._items + list4._size;
														val2 = (Enumerator<, >)(list4._size + 1);
														list4._size = (int)val2;
														object obj77 = obj76 + 32;
														obj77 = list6;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2121 @ X9_v30 (System.Int32)+20]");
														object obj78 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2149 @ X8_v96+A8]");
														object obj79 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2051 @ X8_v97+70]");
														half2 = (Half)0;
														list4.AddWithResize((System.__Canon)(object)list6);
														val2 = (Enumerator<, >)obj74;
													}
													goto IL_1756;
												}
											}
											goto IL_18e1;
										}
									}
									goto IL_18af;
								}
								goto IL_18bd;
								IL_18af:
								NullReferenceException ex13 = new NullReferenceException();
								goto IL_18bd;
								IL_18e1:
								NullReferenceException ex14 = new NullReferenceException();
								val4 = val6;
								obj22 = obj50;
								num14 = num19;
								num9 = num20;
								val5 = val6;
								goto IL_1917;
								IL_18bd:
								NullReferenceException ex15 = new NullReferenceException();
								goto IL_18cb;
								IL_18cb:
								NullReferenceException ex16 = new NullReferenceException();
								num7 = (int)val2;
								goto IL_18e1;
								IL_1756:
								dictionary3 = (Dictionary<int, System.__Canon>)((int*)num)->m_value;
								bool flag47 = ((int*)num)->m_value == 0;
								object obj80 = !flag47;
								obj22 = obj50;
								num14 = num19;
								num9 = num20;
								comparison = (Comparison<int>)(object)list6;
								num5 = num21;
								num21 = (int)hashSet2;
								comparison3 = (Comparison<int>)(object)list6;
								if (obj80 != null)
								{
									continue;
								}
								goto IL_17c8;
							}
							continue;
						}
						goto IL_17c8;
						IL_17c8:
						throw new NullReferenceException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
					object obj81 = 0;
					obj3 = obj81;
					val8.Dispose();
					bool flag48 = list4 == null;
					val = val6;
					val5 = val6;
					obj4 = obj2;
					if (flag48)
					{
						break;
					}
					bool flag49 = half == null;
					val = val6;
					val5 = val6;
					obj4 = obj2;
					if (flag49)
					{
						break;
					}
					int size2 = list4._size;
					half.open = list4._size;
					if (list4._size >= 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BE0]");
						object obj82 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BC0]");
						object obj83 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
						object obj84 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BE8]");
						object obj85 = 0;
						object obj86 = obj87;
						object obj88 = obj89;
						Enumerator<, > val9 = val6;
						List<System.__Canon> list7 = list4;
						while (true)
						{
							int index2 = size2 - 1;
							System.__Canon _Canon5 = list7.get_Item(index2);
							half2 = (Half)obj83;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1694 @ X0_v64 (System.Collections.Generic.List`1<System.__Canon>)+18]");
							int num33 = (int)(-1);
							list7.RemoveAt(num33);
							object obj90 = obj8;
							bool flag50 = obj8 == null;
							obj87 = obj86;
							obj89 = obj88;
							val = val6;
							val5 = val9;
							comparison = (Comparison<int>)(object)_Canon5;
							obj3 = num33;
							obj4 = list7;
							if (flag50)
							{
								break;
							}
							bool flag51 = _Canon5 == null;
							obj87 = obj86;
							obj89 = obj88;
							val = val6;
							val5 = val9;
							comparison = (Comparison<int>)(object)_Canon5;
							obj3 = num33;
							obj4 = list7;
							if (flag51)
							{
								break;
							}
							half2 = (Half)obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v49+10]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1700 @ X0_v65 (System.__Canon)+18]");
							int num34 = (int)(-1);
							int num35 = ((List<int>)(object)_Canon5).get_Item(num34);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v49+10]");
							bool flag52 = (nint)0 == 0;
							obj87 = obj86;
							obj89 = obj88;
							val = val6;
							val5 = val9;
							comparison = (Comparison<int>)(object)_Canon5;
							obj3 = num34;
							if (flag52)
							{
								break;
							}
							half2 = (Half)obj84;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v49+10]");
							Vector3 vector = ((List<Vector3>)0).get_Item(num35);
							object obj91 = obj8;
							bool flag53 = obj8 == null;
							obj87 = obj86;
							obj89 = obj88;
							val = val6;
							val5 = val9;
							comparison = (Comparison<int>)(object)_Canon5;
							obj3 = num35;
							if (flag53)
							{
								break;
							}
							half2 = (Half)obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v51+10]");
							obj4 = 0;
							int num36 = ((List<int>)(object)_Canon5).get_Item(0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v51+10]");
							bool flag54 = (nint)0 == 0;
							obj87 = obj86;
							obj89 = obj88;
							val = val6;
							val5 = val9;
							comparison = (Comparison<int>)(object)_Canon5;
							obj3 = null;
							if (flag54)
							{
								break;
							}
							half2 = (Half)obj84;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v51+10]");
							Vector3 vector2 = ((List<Vector3>)0).get_Item(num36);
							bool flag55 = list4._size < 1;
							obj3 = num36;
							int num37;
							if (!flag55)
							{
								object obj92 = val9 - val9;
								object obj93 = obj88 - obj88;
								object obj94 = obj86 - obj86;
								object obj95 = obj92 * obj92;
								obj89 = obj93 * obj93;
								obj87 = obj94 * obj94;
								val5 = (Enumerator<, >)(obj95 + obj89);
								Enumerator<, > val10 = (Enumerator<, >)(obj87 + val5);
								num = 0;
								obj3 = num36;
								List<System.__Canon> list8 = list4;
								obj4 = 4294967295L;
								while (true)
								{
									object obj96 = obj8;
									bool flag56 = obj8 == null;
									val = val6;
									comparison = (Comparison<int>)(object)_Canon5;
									if (flag56)
									{
										break;
									}
									half2 = (Half)obj82;
									System.__Canon _Canon6 = list8.get_Item(num);
									bool flag57 = _Canon6 == null;
									val = val6;
									comparison = (Comparison<int>)(object)_Canon5;
									obj3 = num;
									if (flag57)
									{
										break;
									}
									half2 = (Half)obj11;
									num37 = ((List<int>)(object)_Canon6).get_Item(0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v63+10]");
									bool flag58 = (nint)0 == 0;
									val = val6;
									comparison = (Comparison<int>)(object)_Canon5;
									obj3 = null;
									if (flag58)
									{
										break;
									}
									half2 = (Half)obj84;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v63+10]");
									Vector3 vector3 = ((List<Vector3>)0).get_Item(num37);
									object obj97 = val9 - val5;
									object obj98 = obj88 - obj89;
									obj87 = obj86 - obj87;
									object obj99 = obj97 * obj97;
									object obj100 = obj98 * obj98;
									object obj101 = obj99 + obj100;
									obj89 = obj87 * obj87;
									val5 = (Enumerator<, >)(obj89 + obj101);
									Enumerator<, > val11 = ((val5 >= val10) ? val10 : val5);
									if (val5 < val10)
									{
										obj4 = num;
									}
									num++;
									bool flag59 = num < list4._size;
									val10 = val11;
									obj3 = num37;
									list8 = list4;
									if (flag59)
									{
										continue;
									}
									goto IL_1f83;
								}
								break;
							}
							goto IL_2036;
							IL_21bf:
							list7 = list4;
							goto IL_2553;
							IL_2036:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1700 @ X0_v65 (System.__Canon)+18]");
							bool flag60 = (nint)0 < (nint)3;
							list7 = list4;
							if (!flag60)
							{
								bool flag61 = list3 == null;
								obj87 = obj86;
								obj89 = obj88;
								val = val6;
								val5 = val9;
								comparison = (Comparison<int>)(object)_Canon5;
								if (flag61)
								{
									break;
								}
								System.__Canon[] items3 = list3._items;
								int version = list3._version + 1;
								list3._version = version;
								bool flag62 = list3._items == null;
								obj87 = obj86;
								obj89 = obj88;
								val = val6;
								val5 = val9;
								comparison = (Comparison<int>)(object)_Canon5;
								if (flag62)
								{
									break;
								}
								bool flag63 = list3._size < items3.Length;
								object obj102 = !flag63;
								if (obj102 == null)
								{
									object obj103 = list3._items + list3._size;
									int size3 = list3._size + 1;
									list3._size = size3;
									object obj104 = obj103 + 32;
									obj104 = _Canon5;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								}
								else
								{
									list3.AddWithResize(_Canon5);
								}
								goto IL_21bf;
							}
							goto IL_2553;
							IL_2553:
							size2 = list7._size;
							if (list7._size > 0)
							{
								continue;
							}
							goto IL_21cc;
							IL_1f83:
							object obj105 = obj4 & 0x80000000L;
							bool flag64 = obj105 == null;
							object obj106 = !flag64;
							obj86 = obj87;
							obj88 = obj89;
							val9 = val5;
							obj3 = num37;
							if (obj106 != null)
							{
								goto IL_2036;
							}
							System.__Canon collection = list4.get_Item((int)obj4);
							((List<int>)(object)_Canon5).AddRange((IEnumerable<int>)collection);
							num14 = (nint)obj85;
							list4.set_Item((int)obj4, _Canon5);
							obj86 = obj87;
							obj88 = obj89;
							val9 = val5;
							goto IL_21bf;
						}
						break;
					}
					goto IL_21cc;
					IL_197b:
					throw new NullReferenceException();
					IL_1965:
					NullReferenceException ex17 = new NullReferenceException();
					val = val4;
					goto IL_197b;
					IL_21cc:
					return (List<List<int>>)(object)list3;
					IL_1933:
					NullReferenceException ex18 = new NullReferenceException();
					goto IL_1941;
					IL_194f:
					NullReferenceException ex19 = new NullReferenceException();
					val7 = val6;
					goto IL_1965;
					IL_1917:
					NullReferenceException ex20 = new NullReferenceException();
					goto IL_1925;
					IL_1925:
					NullReferenceException ex21 = new NullReferenceException();
					goto IL_1933;
					IL_1941:
					NullReferenceException ex22 = new NullReferenceException();
					goto IL_194f;
				}
			}
		}
		throw new NullReferenceException();
	}

	private static float Area(Shape s, List<int> loop)
	{
		//IL_019d: Expected F4, but got I4
		//IL_0035: Expected F4, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected I4, but got Unknown
		if (loop != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loop @ X1 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)0 < (nint)1)
			{
				return 0f;
			}
			float num = 0f;
			int num2 = 0;
			object obj3 = default;
			object obj4 = default;
			while (s != null)
			{
				int index = loop.get_Item(num2);
				if (s.at == null)
				{
					break;
				}
				Vector3 vector = s.at.get_Item(index);
				num2++;
				int num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loop @ X1 (System.Collections.Generic.List`1<System.Int32>)+18]");
				int num4 = (int)((nint)num3 / (nint)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loop @ X1 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj = (nint)num4 * (nint)0;
				int index2 = num2 - obj;
				int index3 = loop.get_Item(index2);
				if (s.at == null)
				{
					break;
				}
				Vector3 vector2 = s.at.get_Item(index3);
				object obj2 = obj3 * obj4;
				obj3 = obj4 * obj3;
				float num5 = (float)obj2 - (float)obj3;
				num += num5;
				int num6 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loop @ X1 (System.Collections.Generic.List`1<System.Int32>)+18]");
				if ((nint)num6 >= (nint)0)
				{
					return num * 0.5f;
				}
			}
		}
		throw new NullReferenceException();
	}

	private static bool Inside(Shape s, List<int> loop, Vector2 p)
	{
		//IL_034d: Expected I4, but got Obj
		//IL_033a: Expected Obj, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected I4, but got Unknown
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_028e: Expected Obj, but got I4
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		object obj;
		if (loop != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loop @ X1 (System.Collections.Generic.List`1<System.Int32>)+18]");
			int index = (int)(-1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loop @ X1 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)0 < (nint)1)
			{
				obj = 0;
				goto IL_03a4;
			}
			if (s != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
				object obj3 = 0;
				object obj5 = default;
				object obj4 = obj5;
				object obj7 = default;
				object obj6 = obj7;
				obj = 0;
				int num = 0;
				object obj11 = default;
				while (true)
				{
					int index2 = loop.get_Item(num);
					if (s.at == null)
					{
						break;
					}
					Vector3 vector = s.at.get_Item(index2);
					object obj8 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v11+E4]");
					bool flag = (nint)0 == 0;
					object obj9 = !flag;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int index3 = loop.get_Item(index);
					if (s.at == null)
					{
						break;
					}
					Vector3 vector2 = s.at.get_Item(index3);
					object obj10 = obj11 - obj5;
					bool flag2 = (nint)obj10 < 0;
					bool flag3 = obj10 == null;
					object obj12 = obj11 ^ obj5;
					object obj13 = obj11 ^ obj10;
					object obj14 = obj12 & obj13;
					bool flag4 = (nint)obj14 < 0;
					bool flag5 = flag2 == flag4;
					object obj15 = !flag3;
					object obj16 = flag5 & obj15;
					object obj17 = obj11 - obj5;
					bool flag6 = (nint)obj17 < 0;
					bool flag7 = obj17 == null;
					object obj18 = obj11 ^ obj5;
					object obj19 = obj11 ^ obj17;
					object obj20 = obj18 & obj19;
					bool flag8 = (nint)obj20 < 0;
					bool flag9 = flag6 == flag8;
					object obj21 = !flag9;
					object obj22 = obj21 | flag7;
					object obj23 = obj16 ^ obj22;
					object obj24 = obj23 & 1;
					bool flag10 = obj24 == null;
					object obj25 = !flag10;
					if (obj25 == null)
					{
						object obj26 = obj4 - obj4;
						object obj27 = obj5 - obj11;
						object obj28 = obj27 * obj26;
						object obj29 = obj11 - obj11;
						object obj30 = obj28 / obj29;
						obj6 = obj4 + obj30;
						bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
						obj4 = obj29;
						if (!flag11)
						{
							obj ^= 1;
							obj4 = obj29;
						}
					}
					num++;
					int num2 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loop @ X1 (System.Collections.Generic.List`1<System.Int32>)+18]");
					bool flag12 = (nint)num2 < (nint)0;
					index = num;
					if (flag12)
					{
						continue;
					}
					goto IL_03a4;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_03a4:
		return (byte)(obj & 1) != 0;
	}

	private static void EarClip(Shape c, int start, int count)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1724: Expected Obj, but got I
		//IL_173a: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		//IL_03bf: Expected Obj, but got I
		//IL_03c8: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_1169: Expected Obj, but got I
		//IL_1180: Expected Obj, but got I
		//IL_16f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f9: Expected Obj, but got Unknown
		//IL_1702: Expected Obj, but got I4
		//IL_170f: Expected I4, but got I8
		//IL_15c5: Expected I4, but got Obj
		//IL_15cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d2: Expected Obj, but got Unknown
		//IL_15f9: Expected I4, but got Obj
		//IL_11d3: Expected Obj, but got I4
		//IL_040b: Expected Obj, but got I
		//IL_0435: Expected Obj, but got I4
		//IL_1259: Expected Obj, but got I
		//IL_1270: Expected Obj, but got I
		//IL_11fe: Expected Obj, but got I
		//IL_1214: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_12c3: Expected Obj, but got I4
		//IL_04a9: Expected Obj, but got I4
		//IL_04d0: Expected I4, but got Obj
		//IL_1349: Expected Obj, but got I
		//IL_1360: Expected Obj, but got I
		//IL_12ee: Expected Obj, but got I
		//IL_1304: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I4
		//IL_0510: Expected I, but got Obj
		//IL_059a: Expected Obj, but got I4
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I4
		//IL_13b3: Expected Obj, but got I4
		//IL_1514: Unknown result type (might be due to invalid IL or missing references)
		//IL_1519: Expected Obj, but got Unknown
		//IL_1532: Expected Obj, but got I4
		//IL_0a9e: Expected I4, but got I8
		//IL_13d7: Expected Obj, but got I
		//IL_13f4: Expected Obj, but got I
		//IL_0d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d46: Expected Obj, but got Unknown
		//IL_0d6d: Expected I4, but got Obj
		//IL_0a54: Expected I4, but got I8
		//IL_0a6e: Expected Obj, but got I4
		//IL_0ad8: Expected Obj, but got I8
		//IL_09e6: Expected Obj, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0db5: Expected Obj, but got I
		//IL_0dcc: Expected Obj, but got I
		//IL_176c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1771: Expected Obj, but got Unknown
		//IL_177a: Unknown result type (might be due to invalid IL or missing references)
		//IL_177f: Expected Obj, but got Unknown
		//IL_17a6: Expected I4, but got Obj
		//IL_0e20: Expected Obj, but got I4
		//IL_0b24: Expected Obj, but got I
		//IL_0b4e: Expected Obj, but got I4
		//IL_1558: Expected Obj, but got I
		//IL_0eaf: Expected Obj, but got I
		//IL_0ec6: Expected Obj, but got I
		//IL_0e4b: Expected Obj, but got I
		//IL_0e61: Expected Obj, but got I
		//IL_0f19: Expected Obj, but got I4
		//IL_06d7: Expected I, but got Obj
		//IL_06fd: Expected Obj, but got I
		//IL_0705: Expected VT, but got Obj
		//IL_0715: Expected Obj, but got I
		//IL_0f95: Expected Obj, but got I4
		//IL_0fbc: Expected I4, but got Obj
		//IL_0fdd: Expected Obj, but got I
		//IL_0ff4: Expected Obj, but got I
		//IL_0f44: Expected Obj, but got I
		//IL_0f5a: Expected Obj, but got I
		//IL_0cfb: Expected Obj, but got I4
		//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d08: Expected Obj, but got Unknown
		//IL_07da: Expected Obj, but got I
		//IL_07e2: Expected VT, but got Obj
		//IL_07f2: Expected Obj, but got I
		//IL_1047: Expected Obj, but got I4
		//IL_1678: Expected Obj, but got I4
		//IL_1680: Unknown result type (might be due to invalid IL or missing references)
		//IL_1685: Expected Obj, but got Unknown
		//IL_10d3: Expected Obj, but got I
		//IL_1072: Expected Obj, but got I
		//IL_1088: Expected Obj, but got I
		//IL_08bf: Expected Obj, but got I
		//IL_08c7: Expected VT, but got Obj
		//IL_08d7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list = default;
		list._002Ector(count);
		if (count < 1)
		{
			goto IL_02e5;
		}
		if (list != null)
		{
			int num = start;
			int num2 = count;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj3 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X9_v35+18]");
				bool flag = num3 < 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj5 = num4 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj6 = (nint)0 + (nint)1;
				}
				else
				{
					list.AddWithResize(num);
				}
				num2--;
				num++;
				if (num2 != 1)
				{
					continue;
				}
				goto IL_00d7;
			}
		}
		goto IL_140f;
		IL_030a:
		List<int>[] tris = c.tris;
		List<int> list2;
		List<int> list4;
		object obj25 = default;
		object obj27 = default;
		if (c.tris != null && list2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X21_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj7 = 0;
			List<int> list3 = tris[0];
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X21_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			bool flag2 = (nint)0 < (nint)4;
			list4 = tris[0];
			if (flag2)
			{
				goto IL_112a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
			List<Vector3> list5 = (List<Vector3>)0;
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B014]");
			object obj9 = 0;
			List<int> list6 = list2;
			object obj52 = default;
			while (true)
			{
				object obj10 = obj7 - 1;
				object obj11 = 0;
				int num5 = -1;
				object obj37;
				object obj31;
				object obj32;
				while (true)
				{
					object obj12 = obj11 + obj8;
					object obj13 = obj12 / obj7;
					object obj14 = obj13 * obj7;
					int num6 = obj12 - obj14;
					object obj15 = obj10 + num6;
					object obj16 = obj15 / obj7;
					object obj17 = obj16 * obj7;
					int num7 = obj15 - obj17;
					int index = list6.get_Item(num7);
					if (c.at == null)
					{
						break;
					}
					Vector3 vector = c.at.get_Item(index);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
					object obj18 = 0;
					object obj19 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v27+E4]");
					bool flag3 = (nint)0 == 0;
					object obj20 = !flag3;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int index2 = list6.get_Item(num6);
					if (c.at == null)
					{
						break;
					}
					Vector3 vector2 = c.at.get_Item(index2);
					object obj21 = num6 + 1;
					object obj22 = obj21 / obj7;
					object obj23 = obj22 * obj7;
					int num8 = obj21 - obj23;
					int index3 = list6.get_Item(num8);
					if (c.at == null)
					{
						break;
					}
					nint num9 = (nint)list5;
					Vector3 vector3 = c.at.get_Item(index3);
					object obj24 = obj25 - obj25;
					object obj26 = obj27 - obj27;
					object obj28 = obj27 - obj27;
					object obj29 = obj25 - obj25;
					object obj30 = obj24 * obj26;
					obj31 = obj28 * obj29;
					obj32 = obj30 - obj31;
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
					object obj33 = !flag4;
					object obj34 = obj32 - obj9;
					bool flag5 = obj34 == null;
					object obj35 = ~obj33;
					object obj36 = obj35 | flag5;
					obj37 = obj27;
					if (obj36 == null)
					{
						object obj38 = obj25 - obj25;
						object obj39 = obj27 - obj27;
						object obj40 = obj25 - obj25;
						object obj41 = obj27 - obj27;
						object obj42 = obj27;
						object obj43 = obj40;
						int num10 = 0;
						object obj44 = obj25;
						object obj45 = obj41;
						while (true)
						{
							bool flag6 = num8 == num10;
							object obj46 = obj42;
							object obj47 = obj44;
							object obj61;
							object obj62;
							if (!flag6)
							{
								bool flag7 = num6 == num10;
								obj46 = obj42;
								obj47 = obj44;
								if (!flag7)
								{
									bool flag8 = num7 == num10;
									obj46 = obj42;
									obj47 = obj44;
									if (!flag8)
									{
										int index4 = list.get_Item(num10);
										if (c.at == null)
										{
											break;
										}
										num9 = (nint)list5;
										Vector3 vector4 = c.at.get_Item(index4);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
										object obj48 = 0;
										vector3 = (Vector3)obj48;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X0_v70 (UnityEngine.Vector3)+E4]");
										obj21 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X0_v70 (UnityEngine.Vector3)+E4]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object obj49 = obj42 - obj27;
										object obj50 = obj44 - obj25;
										object obj51 = obj24 * obj49;
										obj47 = obj28 * obj50;
										obj45 = obj51 - obj47;
										bool flag9 = (nint)obj45 < 0;
										obj46 = obj42;
										obj52 = obj42;
										obj9 = obj44;
										if (!flag9)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
											object obj53 = 0;
											vector3 = (Vector3)obj53;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X0_v70 (UnityEngine.Vector3)+E4]");
											obj21 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X0_v70 (UnityEngine.Vector3)+E4]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											object obj54 = obj42 - obj27;
											object obj55 = obj44 - obj25;
											object obj56 = obj38 * obj54;
											obj47 = obj39 * obj55;
											obj45 = obj56 - obj47;
											bool flag10 = (nint)obj45 < 0;
											obj46 = obj39;
											obj52 = obj42;
											obj43 = obj38;
											obj9 = obj44;
											if (!flag10)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
												object obj57 = 0;
												vector3 = (Vector3)obj57;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X0_v70 (UnityEngine.Vector3)+E4]");
												obj21 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X0_v70 (UnityEngine.Vector3)+E4]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												object obj58 = obj42 - obj27;
												object obj59 = obj44 - obj25;
												object obj60 = obj40 * obj58;
												obj47 = obj41 * obj59;
												obj45 = obj60 - obj47;
												bool flag11 = (nint)obj45 >= 0;
												obj46 = obj41;
												obj52 = obj42;
												obj43 = obj40;
												obj9 = obj44;
												obj37 = obj41;
												obj61 = obj42;
												obj31 = obj40;
												obj62 = obj47;
												obj32 = obj45;
												if (flag11)
												{
													goto IL_1540;
												}
											}
										}
									}
								}
							}
							num10++;
							bool flag12 = num10 < (nint)obj7;
							object obj63 = !flag12;
							object obj64 = ~obj63;
							obj42 = obj46;
							obj44 = obj47;
							if (obj64 != null)
							{
								continue;
							}
							obj37 = obj46;
							obj61 = obj52;
							obj31 = obj43;
							obj62 = obj47;
							obj32 = obj45;
							num5 = num6;
							goto IL_1540;
							IL_1540:
							obj52 = obj61;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B014]");
							obj9 = 0;
							obj25 = obj62;
							goto IL_150b;
						}
						break;
					}
					goto IL_150b;
					IL_150b:
					obj11++;
					bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
					object obj65 = !flag13;
					if (obj65 == null)
					{
						int num11 = (int)(num5 & 0x80000000L);
						bool flag14 = num11 == 0;
						object obj66 = !flag14;
						obj27 = obj37;
						list6 = list;
						if (obj66 != null)
						{
							continue;
						}
					}
					goto IL_0a8c;
				}
				break;
				IL_0d39:
				object obj67 = obj10 + num5;
				object obj68 = obj67 / obj7;
				object obj69 = obj68 * obj7;
				int index5 = obj67 - obj69;
				int item = list.get_Item(index5);
				if (tris[0] == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj70 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj71 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v38+18]");
				bool flag15 = num12 < 0;
				object obj72 = !flag15;
				if (obj72 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj73 = num13 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj74 = (nint)0 + (nint)1;
				}
				else
				{
					tris[0].AddWithResize(item);
				}
				int item2 = list.get_Item(num5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj75 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj76 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v40+18]");
				bool flag16 = num14 < 0;
				object obj77 = !flag16;
				if (obj77 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj78 = num15 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj79 = (nint)0 + (nint)1;
				}
				else
				{
					tris[0].AddWithResize(item2);
				}
				object obj80 = num5 + 1;
				object obj81 = obj80 / obj7;
				object obj82 = obj81 * obj7;
				int index6 = obj80 - obj82;
				int item3 = list.get_Item(index6);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj83 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj84 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v43+18]");
				bool flag17 = num16 < 0;
				object obj85 = !flag17;
				if (obj85 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj86 = num17 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj87 = (nint)0 + (nint)1;
				}
				else
				{
					tris[0].AddWithResize(item3);
				}
				list.RemoveAt(num5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				bool flag18 = (nint)0 > (nint)3;
				list4 = tris[0];
				list2 = list;
				obj27 = obj37;
				obj8 = obj80;
				list6 = list;
				if (flag18)
				{
					continue;
				}
				goto IL_112a;
				IL_0a8c:
				if ((int)(num5 & 0x80000000L) != 0)
				{
					object obj88 = obj37;
					object obj89 = obj31;
					object obj90 = 4286578687L;
					object obj91 = obj25;
					object obj92 = obj32;
					int num18 = num5;
					int num19 = 0;
					while (true)
					{
						object obj93 = obj7 + num19;
						object obj94 = obj93 - 1;
						object obj95 = obj94 / obj7;
						object obj96 = obj95 * obj7;
						int index7 = obj94 - obj96;
						int index8 = list.get_Item(index7);
						if (c.at == null)
						{
							break;
						}
						Vector3 vector5 = c.at.get_Item(index8);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
						object obj97 = 0;
						object obj98 = obj97;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X0_v57+E4]");
						bool flag19 = (nint)0 == 0;
						object obj99 = !flag19;
						if (obj99 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int index9 = list.get_Item(num19);
						if (c.at == null)
						{
							break;
						}
						Vector3 vector6 = c.at.get_Item(index9);
						int num20 = num19 + 1;
						int index10 = ((num20 != (nint)obj7) ? (num19 + 1) : 0);
						int index11 = list.get_Item(index10);
						if (c.at == null)
						{
							break;
						}
						Vector3 vector7 = c.at.get_Item(index11);
						object obj100 = obj91 - obj91;
						obj37 = obj88 - obj88;
						int num21 = num20 - 1;
						obj31 = obj88 - obj88;
						object obj101 = obj91 - obj91;
						object obj102 = obj100 * obj37;
						obj25 = obj31 * obj101;
						obj32 = obj102 - obj25;
						object obj103 = obj32 - obj90;
						bool flag20 = (nint)obj103 < 0;
						bool flag21 = obj103 == null;
						object obj104 = obj32 ^ obj90;
						object obj105 = obj32 ^ obj103;
						object obj106 = obj104 & obj105;
						bool flag22 = (nint)obj106 < 0;
						bool flag23 = flag20 == flag22;
						object obj107 = !flag21;
						object obj108 = flag23 & obj107;
						object obj109 = ~obj108;
						if (obj109 == null)
						{
							obj90 = obj32;
						}
						bool flag24 = flag20 == flag22;
						object obj110 = !flag21;
						object obj111 = flag24 & obj110;
						object obj112 = ~obj111;
						if (obj112 == null)
						{
							num18 = num21;
						}
						bool flag25 = num20 != (nint)obj7;
						num5 = num18;
						obj88 = obj37;
						obj89 = obj31;
						obj91 = obj25;
						obj92 = obj32;
						num19 = num20;
						if (flag25)
						{
							continue;
						}
						goto IL_0d39;
					}
					break;
				}
				goto IL_0d39;
			}
		}
		goto IL_140f;
		IL_00d7:
		if (count < 1)
		{
			goto IL_02e5;
		}
		object obj116;
		if (c != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
			object obj113 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj114 = 0;
			object obj115 = -count;
			int num22 = 1;
			obj116 = 0;
			while (true)
			{
				int index12 = num22 - 1;
				int index13 = list.get_Item(index12);
				if (c.at == null)
				{
					break;
				}
				Vector3 vector8 = c.at.get_Item(index13);
				object obj117 = obj114;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X0_v93+E4]");
				bool flag26 = (nint)0 == 0;
				object obj118 = !flag26;
				if (obj118 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj119 = obj115 + num22;
				bool flag27 = obj119 == null;
				object obj112 = !flag27;
				int index14 = ((obj112 != null) ? num22 : 0);
				int index15 = list.get_Item(index14);
				if (c.at == null)
				{
					break;
				}
				Vector3 vector9 = c.at.get_Item(index15);
				object obj120 = obj25 * obj27;
				obj25 = obj27 * obj25;
				num22++;
				object obj121 = obj115 + num22;
				object obj32 = obj120 - obj25;
				obj116 += obj32;
				if ((nint)obj121 != 1)
				{
					continue;
				}
				goto IL_0288;
			}
		}
		goto IL_140f;
		IL_02e5:
		bool flag28 = c == null;
		list2 = list;
		if (!flag28)
		{
			goto IL_030a;
		}
		goto IL_140f;
		IL_0288:
		bool flag29 = (nint)obj116 >= 0;
		list2 = list;
		if (!flag29)
		{
			if (list == null)
			{
				goto IL_140f;
			}
			list.Reverse();
			list2 = list;
		}
		goto IL_030a;
		IL_112a:
		int item4 = list2.get_Item(0);
		if (list4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj122 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj123 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v8+18]");
				bool flag30 = num23 < 0;
				object obj124 = !flag30;
				if (obj124 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj125 = num24 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj126 = (nint)0 + (nint)1;
				}
				else
				{
					list4.AddWithResize(item4);
				}
				int item5 = list2.get_Item(1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj127 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj128 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v10+18]");
					bool flag31 = num25 < 0;
					object obj129 = !flag31;
					if (obj129 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj130 = num26 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj131 = (nint)0 + (nint)1;
					}
					else
					{
						list4.AddWithResize(item5);
					}
					int item6 = list2.get_Item(2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
					object obj132 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj133 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
						nint num27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v12+18]");
						bool flag32 = num27 < 0;
						object obj134 = !flag32;
						if (obj134 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj135 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
							nint num28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X22_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj136 = num28 + 0;
						}
						else
						{
							list4.AddWithResize(item6);
						}
						return;
					}
				}
			}
		}
		goto IL_140f;
		IL_140f:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private unsafe static void Flip(Shape c)
	{
		//IL_0054: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_0ea9: Expected Obj, but got I
		//IL_0ec3: Expected Obj, but got I
		//IL_0edc: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_0beb: Expected Obj, but got I4
		//IL_0e77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7c: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_0e60: Expected Obj, but got I4
		//IL_0e69: Expected Obj, but got I4
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected Obj, but got Unknown
		//IL_0def: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df4: Expected Obj, but got Unknown
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected I4, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c68: Expected I4, but got Unknown
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c90: Expected Obj, but got Unknown
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9e: Expected I4, but got Unknown
		//IL_0cc6: Expected Obj, but got I4
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected I4, but got Unknown
		//IL_0d3e: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I4
		//IL_016e: Expected I8, but got I4
		//IL_07a3: Expected Obj, but got I
		//IL_07bc: Expected I8, but got I4
		//IL_07dc: Expected I8, but got I4
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected Obj, but got Unknown
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected Obj, but got Unknown
		//IL_0877: Expected Obj, but got I8
		//IL_019d: Expected I8, but got I4
		//IL_01cc: Expected Obj, but got I4
		//IL_0202: Expected I4, but got Obj
		//IL_0212: Expected Obj, but got I
		//IL_021a: Expected I4, but got Obj
		//IL_0245: Expected Obj, but got I4
		//IL_026d: Expected I8, but got I4
		//IL_0288: Expected Obj, but got I4
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected I4, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_0365: Expected Obj, but got I4
		//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7f: Expected I4, but got Unknown
		//IL_0daa: Expected Obj, but got I
		//IL_0dd4: Expected Obj, but got I4
		//IL_03fc: Expected Obj, but got I
		//IL_040c: Invalid comparison between F4 and I
		//IL_0445: Expected Obj, but got Ref
		//IL_045d: Expected I8, but got I4
		//IL_047c: Invalid comparison between VT and I4
		//IL_04da: Expected Obj, but got I
		//IL_04ee: Expected Obj, but got I
		//IL_0518: Expected Obj, but got I4
		//IL_053e: Invalid comparison between VT and I4
		//IL_058c: Expected Obj, but got I
		//IL_0599: Invalid comparison between VT and I4
		//IL_05e7: Expected Obj, but got I
		//IL_05f4: Invalid comparison between VT and I4
		//IL_064f: Expected Obj, but got I
		//IL_071f: Invalid comparison between F4 and I4
		//IL_0768: Expected Obj, but got Ref
		//IL_0778: Expected I8, but got I4
		//IL_0a0c: Expected Obj, but got I
		//IL_0b0d: Expected Obj, but got I
		//IL_0b26: Expected I4, but got Obj
		//IL_0bbd: Expected Obj, but got I4
		//IL_0bc5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (c != null)
		{
			List<int>[] tris = c.tris;
			if (c.tris != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
				int num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C10]");
				object obj = 0;
				List<int> list = tris[0];
				int value = 0;
				Shape shape = c;
				object obj2 = 0;
				int num2 = 17276928;
				Dictionary<long, int> dictionary = default;
				HashSet<int> hashSet = default;
				float num17 = default;
				float num19 = default;
				int num20 = default;
				object obj28 = default;
				_003C_003Ec__DisplayClass56_0 obj39 = default;
				_003C_003Ec__DisplayClass56_0 obj40 = default;
				float num26 = default;
				float num28 = default;
				float num33 = default;
				float num34 = default;
				float num36 = default;
				float num39 = default;
				float num40 = default;
				float num41 = default;
				float num42 = default;
				float num43 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6998]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6990]");
					object obj4 = 0;
					dictionary._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C38]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C30]");
					object obj6 = 0;
					shape = (Shape)obj6;
					hashSet._002Ector();
					if (tris[0] == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X19_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj7;
					float num16;
					float num18;
					float num44;
					float num45;
					float num46;
					float num47;
					float num48;
					float num49;
					float num50;
					float num51;
					float num52;
					float num53;
					object obj46;
					int num54;
					object obj47;
					int num55;
					if ((nint)0 >= (nint)1)
					{
						obj7 = 0;
						int num3 = 0;
						Dictionary<long, int> dictionary2 = dictionary;
						while (true)
						{
							HashSet<int> hashSet2 = (HashSet<int>)2;
							object obj8 = 0;
							Dictionary<long, int> dictionary3;
							while (true)
							{
								object obj9 = hashSet2 * 2863311531L;
								int num4 = num3 + obj8;
								object obj10 = obj9 >> 33;
								object obj11 = obj10 + obj10;
								int num5 = tris[0].get_Item(num4);
								object obj12 = (((nint)obj8 != 2) ? ((object)(obj8 + 1)) : ((object)0));
								int index = obj12 + num3;
								int num6 = tris[0].get_Item(index);
								object obj13 = num4 - obj11;
								int index2 = obj13 + 2;
								int num7 = tris[0].get_Item(index2);
								object obj14 = num5 - num6;
								bool flag = (nint)obj14 < 0;
								int num8 = num5 ^ num6;
								int num9 = num5 ^ obj14;
								int num10 = num8 & num9;
								bool flag2 = num10 < 0;
								int num11 = num6 | num5;
								int num12 = num5 | num6;
								bool flag3 = flag == flag2;
								object obj15 = !flag3;
								object obj16 = ~obj15;
								int num13 = ((obj16 != null) ? num12 : num11);
								if (dictionary2 == null)
								{
									break;
								}
								object obj17 = obj;
								long num21;
								HashSet<int> hashSet3;
								if (dictionary2.TryGetValue(num13, out value))
								{
									bool flag4 = dictionary2.Remove(num13);
									if (hashSet == null)
									{
										break;
									}
									object obj18 = value * 1431655766;
									object obj19 = obj18 >> 63;
									object obj20 = obj18 >> 32;
									object obj21 = obj20 + obj19;
									int num14 = (int)(obj21 + obj21);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C28]");
									object obj22 = 0;
									int num15 = (int)obj22;
									bool flag5 = hashSet.Contains(num14);
									bool flag6 = !flag5;
									object obj23 = !flag6;
									num16 = num17;
									num18 = num19;
									num20 = num14;
									num13 = value;
									num21 = num14;
									if (obj23 == null)
									{
										object obj24 = value - num14;
										int a = tris[0].get_Item(value);
										object obj25 = obj24 + 1;
										object obj26 = obj25 * 86;
										object obj27 = obj26 >> 15;
										obj28 = obj27 & 1;
										object obj29 = obj28 + obj26;
										object obj30 = obj29 + obj29;
										object obj31 = obj25 - obj30;
										int index3 = num14 + obj31;
										int num22 = tris[0].get_Item(index3);
										object obj32 = obj24 + 2;
										object obj33 = obj24 - 1;
										bool flag7 = (nint)obj32 < 3;
										object obj34 = !flag7;
										object obj35 = ~obj34;
										obj16 = ~obj35;
										if (obj16 != null)
										{
											obj32 = obj33;
										}
										int index4 = obj32 + num14;
										int num23 = tris[0].get_Item(index4);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
										object obj36 = 0;
										object obj37 = obj36;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X8_v49+E4]");
										bool flag8 = (nint)0 == 0;
										object obj38 = !flag8;
										if (obj38 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float num24 = _003CFlip_003Eg__Across_007C56_0(num5, num6, num7, ref obj39);
										float num25 = _003CFlip_003Eg__Across_007C56_0(a, num22, num23, ref obj40);
										num26 = num24 + num25;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C10]");
										obj = 0;
										float num27 = num26;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD50]");
										bool flag9 = !(num27 < 0f);
										num16 = num17;
										num18 = num19;
										num28 = num24;
										num4 = num;
										num20 = num14;
										obj17 = (object)(&obj40);
										num13 = num23;
										num15 = num23;
										num21 = num22;
										dictionary2 = dictionary;
										if (!flag9)
										{
											if (obj40 == (_003C_003Ec__DisplayClass56_0)(object)0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ stack_-98_v12 (GillaRip+<>c__DisplayClass56_0)+10]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
											num4 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ stack_-98_v12 (GillaRip+<>c__DisplayClass56_0)+10]");
											Vector3 vector = ((List<Vector3>)0).get_Item(num5);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
											object obj41 = 0;
											object obj42 = obj41;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X0_v42+E4]");
											bool flag10 = (nint)0 == 0;
											object obj43 = !flag10;
											if (obj43 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											if (obj40 == (_003C_003Ec__DisplayClass56_0)(object)0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ stack_-98_v12 (GillaRip+<>c__DisplayClass56_0)+10]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ stack_-98_v12 (GillaRip+<>c__DisplayClass56_0)+10]");
											Vector3 vector2 = ((List<Vector3>)0).get_Item(num6);
											if (obj40 == (_003C_003Ec__DisplayClass56_0)(object)0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ stack_-98_v12 (GillaRip+<>c__DisplayClass56_0)+10]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ stack_-98_v12 (GillaRip+<>c__DisplayClass56_0)+10]");
											Vector3 vector3 = ((List<Vector3>)0).get_Item(num7);
											if (obj40 == (_003C_003Ec__DisplayClass56_0)(object)0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ stack_-98_v12 (GillaRip+<>c__DisplayClass56_0)+10]");
											if ((nint)0 == 0)
											{
												break;
											}
											num15 = ((int*)num4)->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ stack_-98_v12 (GillaRip+<>c__DisplayClass56_0)+10]");
											Vector3 vector4 = ((List<Vector3>)0).get_Item(num23);
											float num29 = num17 - num17;
											float num30 = num19 - num19;
											float num31 = num19 - num19;
											float num32 = num17 - num17;
											num33 = num17 - num17;
											num34 = num19 - num19;
											float num35 = num29 * num31;
											num36 = num30 * num32;
											float num37 = num33 * num31;
											num16 = num34 * num32;
											float num38 = num35 - num36;
											num18 = num37 - num16;
											num26 = num38 * num18;
											bool flag11 = !(num26 < 0f);
											num39 = num17;
											num40 = num19;
											num41 = num17;
											num42 = num19;
											num43 = num17;
											num28 = num19;
											num20 = num14;
											obj17 = (object)(&obj40);
											num13 = num23;
											num21 = num23;
											dictionary2 = dictionary;
											if (!flag11)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AB0]");
												object obj44 = 0;
												tris[0].set_Item(num3, num7);
												int index5 = num3 + 1;
												tris[0].set_Item(index5, num5);
												int index6 = num3 + 2;
												tris[0].set_Item(index6, num23);
												tris[0].set_Item(num14, num23);
												int index7 = num14 + 1;
												tris[0].set_Item(index7, num6);
												obj17 = obj44;
												int index8 = num14 + 2;
												tris[0].set_Item(index8, num7);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C20]");
												object obj45 = 0;
												bool flag12 = hashSet.Add(num3);
												num15 = (int)obj45;
												bool flag13 = hashSet.Add(num14);
												hashSet3 = hashSet;
												num44 = num34;
												num45 = num33;
												num46 = num36;
												num47 = num17;
												num48 = num19;
												num49 = num17;
												num50 = num19;
												num51 = num17;
												num52 = num19;
												num53 = num26;
												obj46 = obj28;
												num4 = num3;
												num54 = num14;
												num13 = num23;
												obj7 = 1;
												shape = (Shape)num14;
												obj47 = obj;
												num55 = num;
												dictionary3 = dictionary;
												goto IL_08b5;
											}
										}
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C18]");
									object obj48 = 0;
									obj17 = obj48;
									dictionary2.set_Item((long)num13, num4);
									num16 = num17;
									num18 = num19;
									int num15 = num4;
									num21 = num13;
								}
								obj8++;
								hashSet3 = (HashSet<int>)(hashSet2 + 1);
								bool flag14 = (nint)obj8 != 3;
								num44 = num34;
								num45 = num33;
								num46 = num36;
								num47 = num39;
								num48 = num40;
								num49 = num41;
								num50 = num42;
								num51 = num43;
								num52 = num28;
								num53 = num26;
								obj46 = obj28;
								num54 = num20;
								shape = (Shape)num21;
								obj47 = obj;
								num55 = num;
								dictionary3 = dictionary2;
								hashSet2 = hashSet3;
								num17 = num16;
								num19 = num18;
								if (flag14)
								{
									continue;
								}
								goto IL_08b5;
							}
							break;
							IL_08b5:
							num2 = num3 + 3;
							int num56 = num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X19_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
							bool flag15 = (nint)num56 < (nint)0;
							num34 = num44;
							num33 = num45;
							num17 = num16;
							num19 = num18;
							num36 = num46;
							num39 = num47;
							num40 = num48;
							num41 = num49;
							num42 = num50;
							num43 = num51;
							num28 = num52;
							num26 = num53;
							obj28 = obj46;
							num20 = num54;
							num3 = num2;
							obj = obj47;
							num = num55;
							dictionary2 = dictionary3;
							if (flag15)
							{
								continue;
							}
							goto IL_0977;
						}
						break;
					}
					obj7 = 0;
					goto IL_0e6e;
					IL_0e6e:
					object obj49 = obj7 & 1;
					if (obj49 != null)
					{
						obj2++;
						if ((nint)obj2 == 40)
						{
							return;
						}
						continue;
					}
					return;
					IL_0977:
					num34 = num44;
					num33 = num45;
					num17 = num16;
					num19 = num18;
					num36 = num46;
					num39 = num47;
					num40 = num48;
					num41 = num49;
					num42 = num50;
					num43 = num51;
					num28 = num52;
					num26 = num53;
					obj28 = obj46;
					num20 = num54;
					obj = obj47;
					num = num55;
					goto IL_0e6e;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public unsafe static Task<object> Bones(Mesh whole, float gone, float thick, int sign, int seed, Vector4[] holes, Vector4[] axes, Vector4[] sides, int holeCount, Vector3 faceAt, float faceAcross)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_0059: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj = 0;
		Along middle = Along.Middle;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Mesh whole2 = default;
		object obj4 = default;
		Along along = default;
		return Bones(whole2, gone, thick, sign, seed, holes, axes, sides, holeCount, (Vector3)(&obj4), faceAcross, along);
	}

	public static Task<object> Bones(Mesh whole, float gone, float thick, int sign, int seed, Vector4[] holes, Vector4[] axes, Vector4[] sides, int holeCount, Vector3 faceAt, float faceAcross, Along along)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_0115: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got I
		//IL_019f: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CA8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CB0]");
			object obj4 = 0;
			object obj5 = obj2 + 40;
			obj5 = holes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = obj2 + 48;
			obj6 = axes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj2 + 56;
			obj7 = sides;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [faceAt @ X7 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [faceAt @ X7 (UnityEngine.Vector3)+10]");
			_ = 0;
			_ = faceAt.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CB8]");
			object obj10 = 0;
			GillaWounds.BoneShape boneShape = GillaWounds.ShapeOf(whole);
			object obj11 = obj2 + 16;
			obj11 = boneShape;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CC0]");
			object obj12 = 0;
			Func<System.__Canon> func = default;
			func._002Ector(obj2, (IntPtr)obj12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @362791C");
			Task<object> result = default;
			return result;
		}
		return (Task<object>)(object)new NullReferenceException();
	}

	public static Mesh BoneMesh(object made)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		if (made != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69B8]");
			object obj = 0;
			nint num = (nint)made;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<System.Object>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X9_v4-8]");
				if (0 == (nint)obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v3+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return Make((Built)made);
				}
			}
		}
		return null;
	}

	private unsafe static Built Bone(GillaWounds.BoneShape s, float gone, float thick, int sign, int seed, Vector4[] holes, Vector4[] axes, Vector4[] sides, int holeCount, Vector3 faceAt, float faceAcross, Along along)
	{
		//IL_453f: Expected F4, but got I
		//IL_4547: Expected Obj, but got Ref
		//IL_4559: Expected Obj, but got Ref
		//IL_006e: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I8
		//IL_0b6b: Expected Obj, but got I
		//IL_0b7c: Expected Obj, but got I
		//IL_0b9c: Expected Obj, but got I
		//IL_0bae: Expected Obj, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected I4, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0160: Expected Obj, but got I4
		//IL_0170: Expected F8, but got I
		//IL_018a: Expected F4, but got I
		//IL_019a: Expected F4, but got I
		//IL_0f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Expected Obj, but got Unknown
		//IL_0bbc: Invalid comparison between VT and I4
		//IL_0bcc: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		//IL_0c12: Expected Obj, but got I
		//IL_0c2c: Expected Obj, but got I8
		//IL_0c5d: Expected Obj, but got I4
		//IL_0c6e: Expected VT, but got I4
		//IL_0f74: Expected Obj, but got Ref
		//IL_5390: Expected Obj, but got I4
		//IL_53aa: Expected Obj, but got I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_0213: Expected Obj, but got I
		//IL_022b: Expected F4, but got I
		//IL_023b: Expected F4, but got I
		//IL_025d: Expected Obj, but got I4
		//IL_466d: Expected VT, but got I4
		//IL_4681: Expected Obj, but got I
		//IL_46ab: Expected Obj, but got I4
		//IL_0fa9: Expected Obj, but got Ref
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c80: Expected Obj, but got Unknown
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Expected Obj, but got Unknown
		//IL_02ef: Expected VT, but got I4
		//IL_0fd9: Expected Obj, but got Ref
		//IL_4937: Unknown result type (might be due to invalid IL or missing references)
		//IL_493c: Expected Obj, but got Unknown
		//IL_4945: Unknown result type (might be due to invalid IL or missing references)
		//IL_494a: Expected VT, but got Unknown
		//IL_08ac: Expected Obj, but got I4
		//IL_08bc: Expected F8, but got I
		//IL_08dc: Expected F4, but got I
		//IL_08ed: Expected VT, but got I4
		//IL_08f6: Expected Obj, but got I4
		//IL_0ce9: Expected Obj, but got I4
		//IL_4836: Invalid comparison between F4 and I4
		//IL_0338: Expected F4, but got I
		//IL_0358: Expected F4, but got I
		//IL_100e: Expected Obj, but got Ref
		//IL_0a80: Invalid comparison between VT and I4
		//IL_103e: Expected Obj, but got Ref
		//IL_0d25: Expected Obj, but got VT
		//IL_0d41: Expected Obj, but got I4
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected Obj, but got Unknown
		//IL_0923: Expected Obj, but got I4
		//IL_0397: Expected Obj, but got I4
		//IL_03a7: Expected F8, but got I
		//IL_03bf: Expected F4, but got I
		//IL_03df: Expected F4, but got I
		//IL_03f0: Expected VT, but got I4
		//IL_03f9: Expected Obj, but got I4
		//IL_5408: Unknown result type (might be due to invalid IL or missing references)
		//IL_540d: Expected Obj, but got Unknown
		//IL_5426: Expected Obj, but got I4
		//IL_5430: Expected Obj, but got I4
		//IL_0ad6: Expected Obj, but got I4
		//IL_52e8: Expected Obj, but got I4
		//IL_094a: Invalid comparison between F4 and I4
		//IL_095b: Expected Obj, but got I4
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected Obj, but got Unknown
		//IL_09a2: Expected F4, but got I4
		//IL_4a1d: Expected Obj, but got Ref
		//IL_4a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a3f: Expected Obj, but got Unknown
		//IL_4a7a: Expected Obj, but got I
		//IL_4a94: Expected Obj, but got I
		//IL_4aa4: Expected Obj, but got I
		//IL_4abf: Expected Obj, but got I4
		//IL_0d63: Expected Obj, but got I
		//IL_0d7d: Expected Obj, but got I8
		//IL_0b36: Expected Obj, but got I4
		//IL_4853: Unknown result type (might be due to invalid IL or missing references)
		//IL_4858: Expected Obj, but got Unknown
		//IL_48b9: Expected F4, but got I
		//IL_0417: Expected F8, but got Obj
		//IL_041f: Invalid comparison between Obj and F8
		//IL_18ad: Expected Obj, but got I
		//IL_18e6: Expected F8, but got I
		//IL_491f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4924: Expected Obj, but got Unknown
		//IL_09b9: Invalid comparison between VT and I4
		//IL_09e1: Expected F4, but got I4
		//IL_46d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_46d5: Expected Obj, but got Unknown
		//IL_46ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_46f1: Expected Obj, but got Unknown
		//IL_1074: Invalid comparison between VT and I4
		//IL_1084: Expected Obj, but got I4
		//IL_10ac: Expected F8, but got I
		//IL_49b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_49b7: Expected Obj, but got Unknown
		//IL_49c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_49c9: Expected Obj, but got Unknown
		//IL_0dc6: Expected Obj, but got I4
		//IL_0dd0: Expected Obj, but got I4
		//IL_0a10: Expected Obj, but got I4
		//IL_0a4a: Expected F4, but got I4
		//IL_0886: Expected F4, but got I
		//IL_1a0c: Expected F8, but got I
		//IL_10ec: Expected Obj, but got I8
		//IL_111c: Expected Obj, but got VT
		//IL_1125: Expected Obj, but got I4
		//IL_112f: Expected Obj, but got I4
		//IL_1148: Expected Obj, but got I4
		//IL_0ea9: Expected Obj, but got I4
		//IL_0ec3: Expected Obj, but got I4
		//IL_0e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3b: Expected Obj, but got Unknown
		//IL_0e4b: Expected Obj, but got I
		//IL_0e72: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I4
		//IL_1942: Expected Obj, but got I
		//IL_1952: Unknown result type (might be due to invalid IL or missing references)
		//IL_1957: Expected Obj, but got Unknown
		//IL_1971: Expected Obj, but got I8
		//IL_197a: Unknown result type (might be due to invalid IL or missing references)
		//IL_197f: Expected Obj, but got Unknown
		//IL_4c2d: Expected F8, but got I
		//IL_0a69: Expected F4, but got I4
		//IL_0a72: Expected Obj, but got I4
		//IL_1a3b: Invalid comparison between VT and I4
		//IL_1a61: Expected F8, but got I
		//IL_4c82: Expected F8, but got I
		//IL_0ef1: Expected Obj, but got I4
		//IL_1155: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Expected Obj, but got Unknown
		//IL_1aa8: Expected F8, but got I4
		//IL_1ac0: Expected F8, but got I
		//IL_1ae1: Expected Obj, but got I4
		//IL_1b01: Expected F4, but got I
		//IL_1b1a: Expected Obj, but got I4
		//IL_198e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1993: Expected Obj, but got Unknown
		//IL_19a0: Expected Obj, but got I8
		//IL_19a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ae: Expected Obj, but got Unknown
		//IL_19cd: Expected Obj, but got I8
		//IL_1810: Unknown result type (might be due to invalid IL or missing references)
		//IL_1815: Expected Obj, but got Unknown
		//IL_181e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1823: Expected Obj, but got Unknown
		//IL_1865: Expected Obj, but got I4
		//IL_1882: Expected Obj, but got I8
		//IL_0524: Expected Obj, but got I4
		//IL_426d: Expected Obj, but got I
		//IL_5292: Expected Obj, but got I4
		//IL_11f3: Expected F8, but got I
		//IL_429b: Expected Obj, but got I
		//IL_42a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_42a9: Expected Obj, but got Unknown
		//IL_42c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_42c9: Expected Obj, but got Unknown
		//IL_0563: Expected F4, but got I
		//IL_0573: Expected F4, but got I
		//IL_0583: Expected F4, but got I
		//IL_0593: Expected Obj, but got I
		//IL_05a3: Expected F8, but got I
		//IL_05bf: Expected F8, but got I
		//IL_42e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_42ee: Expected Obj, but got Unknown
		//IL_4309: Unknown result type (might be due to invalid IL or missing references)
		//IL_430e: Expected Obj, but got Unknown
		//IL_1b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2c: Expected Obj, but got Unknown
		//IL_123e: Expected Obj, but got I4
		//IL_4727: Expected VT, but got Obj
		//IL_4727: Expected VT, but got I4
		//IL_4727: Expected VT, but got I4
		//IL_4727: Expected VT, but got I4
		//IL_4748: Invalid comparison between F4 and I4
		//IL_475e: Invalid comparison between F4 and I
		//IL_476f: Expected Obj, but got I4
		//IL_478f: Invalid comparison between F4 and I4
		//IL_479d: Unknown result type (might be due to invalid IL or missing references)
		//IL_47a2: Expected Obj, but got Unknown
		//IL_47b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_47b8: Expected Obj, but got Unknown
		//IL_47d0: Expected F4, but got I
		//IL_47e0: Expected F4, but got I
		//IL_47f0: Expected F4, but got I
		//IL_47f9: Expected VT, but got I4
		//IL_432e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4333: Expected Obj, but got Unknown
		//IL_434e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4353: Expected Obj, but got Unknown
		//IL_4199: Unknown result type (might be due to invalid IL or missing references)
		//IL_419e: Expected Obj, but got Unknown
		//IL_41a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_41ac: Expected Obj, but got Unknown
		//IL_548e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5493: Expected I4, but got Unknown
		//IL_54ac: Expected Obj, but got I4
		//IL_54cc: Expected F8, but got I
		//IL_0809: Expected Obj, but got I4
		//IL_0849: Expected F8, but got I
		//IL_060a: Expected F8, but got I
		//IL_061a: Expected F4, but got I
		//IL_062a: Expected F8, but got I
		//IL_4373: Unknown result type (might be due to invalid IL or missing references)
		//IL_4378: Expected Obj, but got Unknown
		//IL_439a: Expected Obj, but got I
		//IL_1b62: Expected I4, but got Obj
		//IL_1b8e: Expected I4, but got Obj
		//IL_064a: Expected Obj, but got I4
		//IL_0683: Expected F4, but got I
		//IL_0693: Expected F4, but got I
		//IL_12c9: Expected I4, but got I8
		//IL_4af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4af5: Expected Obj, but got Unknown
		//IL_06b1: Expected Obj, but got I
		//IL_06b9: Expected F4, but got Obj
		//IL_1bc3: Expected Obj, but got I4
		//IL_131a: Expected Obj, but got I4
		//IL_133a: Expected F8, but got I
		//IL_070e: Expected VT, but got I4
		//IL_076c: Expected VT, but got I4
		//IL_07bc: Expected F8, but got I
		//IL_07da: Expected VT, but got I4
		//IL_1370: Unknown result type (might be due to invalid IL or missing references)
		//IL_1375: Expected Obj, but got Unknown
		//IL_4464: Unknown result type (might be due to invalid IL or missing references)
		//IL_4469: Expected Obj, but got Unknown
		//IL_4484: Unknown result type (might be due to invalid IL or missing references)
		//IL_4489: Expected Obj, but got Unknown
		//IL_1c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8a: Expected Obj, but got Unknown
		//IL_1cad: Expected Obj, but got I4
		//IL_13ba: Expected I4, but got Obj
		//IL_13ee: Expected F8, but got I
		//IL_1cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfd: Expected Obj, but got Unknown
		//IL_1d36: Expected Obj, but got I4
		//IL_1424: Expected Obj, but got I
		//IL_1445: Expected Obj, but got I4
		//IL_1465: Expected F8, but got I
		//IL_1d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d81: Expected Obj, but got Unknown
		//IL_1d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8f: Expected I4, but got Unknown
		//IL_1da6: Expected Obj, but got I8
		//IL_1498: Expected I4, but got Obj
		//IL_14cc: Expected F8, but got I
		//IL_1514: Expected Obj, but got I
		//IL_1524: Expected Obj, but got I
		//IL_154d: Expected Obj, but got I4
		//IL_156d: Expected F8, but got I
		//IL_2268: Expected Obj, but got I
		//IL_2286: Expected Obj, but got I
		//IL_1e77: Expected Obj, but got I4
		//IL_15c2: Expected F8, but got I
		//IL_2308: Expected Obj, but got I
		//IL_2331: Expected Obj, but got I4
		//IL_23a1: Expected Obj, but got I
		//IL_23b1: Expected Obj, but got I
		//IL_15fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1602: Expected Obj, but got Unknown
		//IL_1622: Expected Obj, but got I
		//IL_164b: Expected Obj, but got I4
		//IL_166b: Expected F8, but got I
		//IL_23e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e9: Expected Obj, but got Unknown
		//IL_23fb: Expected I4, but got I8
		//IL_2425: Expected I4, but got Obj
		//IL_235c: Expected Obj, but got I
		//IL_2372: Expected Obj, but got I
		//IL_238c: Expected Obj, but got I4
		//IL_1f59: Expected Obj, but got I4
		//IL_243c: Invalid comparison between F4 and I4
		//IL_244d: Expected Obj, but got I4
		//IL_2456: Invalid comparison between F4 and I4
		//IL_246d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2472: Expected Obj, but got Unknown
		//IL_16da: Expected Obj, but got I4
		//IL_4b70: Expected VT, but got Obj
		//IL_4b78: Invalid comparison between VT and Obj
		//IL_4b89: Expected Obj, but got I4
		//IL_4ba9: Expected F8, but got I
		//IL_16c7: Expected Obj, but got I4
		//IL_258d: Expected VT, but got I4
		//IL_5263: Expected I4, but got VT
		//IL_202f: Expected Obj, but got I4
		//IL_16e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ec: Expected Obj, but got Unknown
		//IL_171d: Expected Obj, but got I4
		//IL_173d: Expected F8, but got I
		//IL_25e2: Expected Obj, but got I4
		//IL_260a: Expected I4, but got VT
		//IL_207f: Expected Obj, but got I
		//IL_2095: Expected Obj, but got I
		//IL_20c5: Expected Obj, but got I
		//IL_1778: Expected Obj, but got I
		//IL_17a9: Expected Obj, but got I4
		//IL_17c9: Expected F8, but got I
		//IL_2643: Unknown result type (might be due to invalid IL or missing references)
		//IL_2648: Expected Obj, but got Unknown
		//IL_2672: Expected I4, but got I8
		//IL_269c: Expected I4, but got VT
		//IL_4d1d: Expected F4, but got I
		//IL_4d2d: Expected F4, but got I
		//IL_4d3d: Expected F4, but got I
		//IL_4d4d: Expected F4, but got I
		//IL_4d5d: Expected F4, but got I
		//IL_4d7f: Expected Obj, but got I4
		//IL_4041: Unknown result type (might be due to invalid IL or missing references)
		//IL_4046: Expected Obj, but got Unknown
		//IL_4058: Expected I4, but got I8
		//IL_417a: Expected VT, but got I4
		//IL_214b: Expected VT, but got I4
		//IL_214b: Expected VT, but got Ref
		//IL_2170: Expected Obj, but got I4
		//IL_2191: Expected F8, but got I4
		//IL_21a1: Expected F4, but got I
		//IL_26d3: Expected Obj, but got I4
		//IL_26fb: Expected I4, but got VT
		//IL_21f2: Expected Obj, but got I4
		//IL_220a: Expected F8, but got I
		//IL_221b: Expected F8, but got I4
		//IL_222b: Expected F4, but got I
		//IL_2729: Unknown result type (might be due to invalid IL or missing references)
		//IL_272e: Expected Obj, but got Unknown
		//IL_2758: Expected I4, but got VT
		//IL_2797: Expected I4, but got VT
		//IL_27af: Expected Obj, but got I4
		//IL_27ca: Expected Obj, but got I4
		//IL_27f2: Expected I4, but got VT
		//IL_2847: Unknown result type (might be due to invalid IL or missing references)
		//IL_284c: Expected Obj, but got Unknown
		//IL_4e23: Invalid comparison between F8 and Obj
		//IL_4e34: Expected Obj, but got I4
		//IL_4e5c: Expected I4, but got VT
		//IL_2839: Expected Obj, but got I4
		//IL_2882: Expected I4, but got VT
		//IL_289d: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a2: Expected Obj, but got Unknown
		//IL_28c5: Expected Obj, but got I4
		//IL_28ed: Expected I4, but got VT
		//IL_2942: Expected Obj, but got I4
		//IL_296a: Expected I4, but got VT
		//IL_29b9: Expected I4, but got VT
		//IL_29ea: Expected Obj, but got I4
		//IL_2a12: Expected I4, but got VT
		//IL_2a46: Expected Obj, but got I
		//IL_2a6e: Expected Obj, but got I
		//IL_5508: Unknown result type (might be due to invalid IL or missing references)
		//IL_550d: Expected Obj, but got Unknown
		//IL_551d: Expected Obj, but got I
		//IL_5533: Expected Obj, but got I
		//IL_5556: Expected Obj, but got I
		//IL_558d: Expected Obj, but got I4
		//IL_2abe: Expected Obj, but got I
		//IL_2af4: Invalid comparison between F4 and I
		//IL_2b6e: Expected Obj, but got I
		//IL_2b86: Expected Obj, but got I
		//IL_2b8e: Expected F4, but got Obj
		//IL_2b9e: Expected F4, but got I
		//IL_2bae: Expected F4, but got I
		//IL_4eb0: Expected I4, but got VT
		//IL_2b1d: Expected F4, but got Obj
		//IL_2b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b2b: Expected Obj, but got Unknown
		//IL_2b4a: Expected F4, but got Obj
		//IL_2bd6: Expected Obj, but got I4
		//IL_2bfe: Expected I4, but got VT
		//IL_55a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_55ae: Expected Obj, but got Unknown
		//IL_55be: Expected Obj, but got I
		//IL_55d4: Expected Obj, but got I
		//IL_55f7: Expected Obj, but got I
		//IL_562e: Expected Obj, but got I4
		//IL_2c5a: Expected Obj, but got I
		//IL_2c90: Invalid comparison between F4 and I
		//IL_2d0a: Expected Obj, but got I
		//IL_2d22: Expected Obj, but got I
		//IL_2d2a: Expected F4, but got Obj
		//IL_2d3a: Expected F4, but got I
		//IL_2d4a: Expected F4, but got I
		//IL_4ed3: Expected Obj, but got I
		//IL_4f04: Expected I4, but got VT
		//IL_2cb9: Expected F4, but got Obj
		//IL_2cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc7: Expected Obj, but got Unknown
		//IL_2ce6: Expected F4, but got Obj
		//IL_2d72: Expected Obj, but got I4
		//IL_2d9a: Expected I4, but got VT
		//IL_2ddb: Expected Obj, but got I4
		//IL_2e03: Expected I4, but got VT
		//IL_2e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e34: Expected Obj, but got Unknown
		//IL_2e4a: Expected Obj, but got I
		//IL_2e6d: Expected Obj, but got I
		//IL_564c: Expected Obj, but got I
		//IL_5676: Expected Obj, but got I4
		//IL_2f0a: Expected Obj, but got I
		//IL_2fca: Invalid comparison between F4 and I
		//IL_3026: Expected Obj, but got I
		//IL_303e: Expected Obj, but got I
		//IL_3046: Expected F4, but got Obj
		//IL_3056: Expected F4, but got I
		//IL_4f58: Expected F8, but got I
		//IL_4f70: Expected F4, but got I
		//IL_4f78: Expected I4, but got VT
		//IL_3076: Expected Obj, but got I4
		//IL_3096: Expected F8, but got I
		//IL_30a6: Expected F4, but got I
		//IL_30ae: Expected I4, but got VT
		//IL_30f9: Expected Obj, but got I4
		//IL_31df: Invalid comparison between F4 and I4
		//IL_4f8f: Invalid comparison between F4 and I4
		//IL_4faf: Invalid comparison between F4 and I4
		//IL_4fe8: Expected Obj, but got I4
		//IL_4ff8: Expected F4, but got I
		//IL_5008: Expected F4, but got I
		//IL_5018: Expected F4, but got I
		//IL_571d: Expected VT, but got Ref
		//IL_5742: Expected F4, but got I
		//IL_5742: Expected VT, but got Ref
		//IL_575f: Expected VT, but got Ref
		//IL_329c: Expected VT, but got Ref
		//IL_32b0: Expected Obj, but got I
		//IL_32c0: Expected Obj, but got I
		//IL_32d6: Expected Obj, but got I
		//IL_3344: Expected I4, but got VT
		//IL_325e: Expected F4, but got I
		//IL_326e: Expected F4, but got I
		//IL_327e: Expected F4, but got I
		//IL_33b1: Expected Obj, but got I4
		//IL_3579: Expected Obj, but got I
		//IL_3589: Expected Obj, but got I
		//IL_35af: Invalid comparison between F4 and I4
		//IL_35be: Invalid comparison between F4 and I4
		//IL_35d1: Expected Obj, but got F4
		//IL_35d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_35de: Expected Obj, but got Unknown
		//IL_35fd: Expected Obj, but got I
		//IL_360d: Expected Obj, but got I
		//IL_3623: Expected Obj, but got I
		//IL_3644: Expected Obj, but got I4
		//IL_364c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3651: Expected Obj, but got Unknown
		//IL_34ac: Expected Obj, but got I
		//IL_34bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_34c1: Expected Obj, but got Unknown
		//IL_34ca: Invalid comparison between F4 and I4
		//IL_34d9: Invalid comparison between F4 and I4
		//IL_34ec: Expected Obj, but got F4
		//IL_34f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_34f9: Expected Obj, but got Unknown
		//IL_352b: Expected Obj, but got I4
		//IL_3533: Unknown result type (might be due to invalid IL or missing references)
		//IL_3538: Expected Obj, but got Unknown
		//IL_503c: Expected Obj, but got I
		//IL_5051: Expected Obj, but got I4
		//IL_36ab: Expected Obj, but got I4
		//IL_379c: Expected Obj, but got I
		//IL_37ac: Expected Obj, but got I
		//IL_37d2: Invalid comparison between F4 and I4
		//IL_37e1: Invalid comparison between F4 and I4
		//IL_37f4: Expected Obj, but got F4
		//IL_37fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3801: Expected Obj, but got Unknown
		//IL_3820: Expected Obj, but got I
		//IL_3830: Expected Obj, but got I
		//IL_3846: Expected Obj, but got I
		//IL_3867: Expected Obj, but got I4
		//IL_386f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3874: Expected Obj, but got Unknown
		//IL_36cf: Expected Obj, but got I
		//IL_36df: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e4: Expected Obj, but got Unknown
		//IL_36ed: Invalid comparison between F4 and I4
		//IL_36fc: Invalid comparison between F4 and I4
		//IL_370f: Expected Obj, but got F4
		//IL_3717: Unknown result type (might be due to invalid IL or missing references)
		//IL_371c: Expected Obj, but got Unknown
		//IL_374e: Expected Obj, but got I4
		//IL_3756: Unknown result type (might be due to invalid IL or missing references)
		//IL_375b: Expected Obj, but got Unknown
		//IL_50cb: Expected Obj, but got I
		//IL_38b5: Expected Obj, but got I
		//IL_38de: Expected Obj, but got I4
		//IL_3951: Expected Obj, but got I
		//IL_3961: Expected Obj, but got I
		//IL_398e: Expected Obj, but got I
		//IL_39ac: Expected Obj, but got I
		//IL_3902: Expected Obj, but got I
		//IL_3912: Unknown result type (might be due to invalid IL or missing references)
		//IL_3917: Expected Obj, but got Unknown
		//IL_3937: Expected Obj, but got I
		//IL_3a44: Expected Obj, but got I4
		//IL_3b35: Expected Obj, but got I
		//IL_3b45: Expected Obj, but got I
		//IL_3b6b: Invalid comparison between F4 and I4
		//IL_3b7a: Invalid comparison between F4 and I4
		//IL_3b8d: Expected Obj, but got F4
		//IL_3b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b9a: Expected Obj, but got Unknown
		//IL_3bb9: Expected Obj, but got I
		//IL_3bd7: Expected Obj, but got I
		//IL_3bf0: Expected Obj, but got I4
		//IL_3bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bfd: Expected Obj, but got Unknown
		//IL_3a68: Expected Obj, but got I
		//IL_3a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a7d: Expected Obj, but got Unknown
		//IL_3a86: Invalid comparison between F4 and I4
		//IL_3a95: Invalid comparison between F4 and I4
		//IL_3aa8: Expected Obj, but got F4
		//IL_3ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ab5: Expected Obj, but got Unknown
		//IL_3ae7: Expected Obj, but got I4
		//IL_3aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_3af4: Expected Obj, but got Unknown
		//IL_514a: Expected Obj, but got I
		//IL_3c57: Expected Obj, but got I4
		//IL_3d48: Expected Obj, but got I
		//IL_3d58: Expected Obj, but got I
		//IL_3d7e: Invalid comparison between F4 and I4
		//IL_3d8d: Invalid comparison between F4 and I4
		//IL_3da0: Expected Obj, but got F4
		//IL_3da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dad: Expected Obj, but got Unknown
		//IL_3dcc: Expected Obj, but got I
		//IL_3dea: Expected Obj, but got I
		//IL_3e03: Expected Obj, but got I4
		//IL_3e0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e10: Expected Obj, but got Unknown
		//IL_3e19: Expected I4, but got Obj
		//IL_3c7b: Expected Obj, but got I
		//IL_3c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c90: Expected Obj, but got Unknown
		//IL_3c99: Invalid comparison between F4 and I4
		//IL_3ca8: Invalid comparison between F4 and I4
		//IL_3cbb: Expected Obj, but got F4
		//IL_3cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc8: Expected Obj, but got Unknown
		//IL_3cfa: Expected Obj, but got I4
		//IL_3d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d07: Expected Obj, but got Unknown
		//IL_3d10: Expected I4, but got Obj
		//IL_51c9: Expected Obj, but got I
		//IL_3e51: Expected Obj, but got I
		//IL_3e7a: Expected Obj, but got I4
		//IL_3f68: Expected Obj, but got I
		//IL_3f78: Expected Obj, but got I
		//IL_3fad: Expected F4, but got I
		//IL_3fbd: Expected F4, but got I
		//IL_3fde: Expected F8, but got I4
		//IL_3e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e9d: Expected Obj, but got Unknown
		//IL_3eb3: Expected Obj, but got I
		//IL_3ed5: Expected F4, but got I
		//IL_3ee5: Expected F4, but got I
		//IL_3f06: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Vector3 vector = default;
		float num = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+10]");
		float num2 = 0f;
		object obj2 = default;
		object obj = (object)(&obj2);
		_ = vector.x;
		object obj4 = default;
		object obj3 = (object)(&obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+10]");
		_ = 0;
		bool flag = s == null;
		int num3 = 136;
		float num5 = default;
		float num4 = num5;
		float num7 = default;
		float num6 = num7;
		float num8 = faceAcross;
		int num9 = 0;
		Vector3[] middles;
		Vector4[] array;
		float num10;
		float num11;
		float num12;
		int num13;
		Vector3 vector3 = default;
		float num16 = default;
		float num18 = default;
		double num20 = default;
		float num22 = default;
		double num24 = default;
		double num25;
		double num27;
		float num29;
		float num32;
		float num33;
		float num36 = default;
		float num37 = default;
		double num39 = default;
		float num48 = default;
		double num57 = default;
		float num58 = default;
		double num59 = default;
		float num60 = default;
		float num75 = default;
		double num76 = default;
		int num56 = default;
		Vector4[] array2 = default;
		Vector4[] array3 = default;
		Vector4[] array4 = default;
		float num30 = default;
		double num26 = default;
		double num28 = default;
		if (!flag)
		{
			middles = s.middles;
			bool flag2 = s.middles == null;
			num3 = 136;
			num4 = num5;
			num6 = num7;
			num8 = faceAcross;
			num9 = 0;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj5 = 0;
				array = (Vector4[])(middles.Length & 0xFFFFFFFFL);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				bool flag3 = middles.Length < 1;
				num10 = num5;
				num11 = num7;
				num12 = faceAcross;
				num13 = middles.Length;
				Vector3 vector2 = vector3;
				if (flag3)
				{
					goto IL_0b3b;
				}
				object obj6 = array2 + 44;
				int num14 = array3 + 44;
				object obj7 = array4 + 44;
				num4 = num5;
				float num15 = num16;
				float num17 = num18;
				double num19 = num20;
				float num21 = num22;
				double num23 = num24;
				num25 = num26;
				num27 = num28;
				num6 = num7;
				num29 = num30;
				num8 = faceAcross;
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				double num31 = 0.0;
				num9 = middles.Length;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+10]");
				num32 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				num33 = 0f;
				int num34 = seed;
				int num35 = middles.Length;
				double num38 = default;
				object obj16 = default;
				double num41 = default;
				float num42 = default;
				float num46 = default;
				float num61 = default;
				while (true)
				{
					Vector3[] middles2 = s.middles;
					bool flag4 = s.middles == null;
					num3 = 136;
					num26 = num25;
					num28 = num27;
					num30 = num29;
					num2 = num32;
					num = num33;
					if (flag4)
					{
						break;
					}
					bool flag5 = (nint)obj8 < middles2.Length;
					object obj9 = !flag5;
					num3 = 136;
					float num54;
					float num55;
					object obj20;
					object obj21;
					float num62;
					float num63;
					if (obj9 == null)
					{
						object obj10 = obj8 * 12;
						object obj11 = (object)s.middles + obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
						object obj12 = 0;
						object obj13 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v162+28]");
						num36 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v162+20]");
						num37 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1817 @ X0_v168+E4]");
						bool flag6 = (nint)0 == 0;
						object obj14 = !flag6;
						num26 = num38;
						num28 = num39;
						object obj15 = obj16;
						double num40 = num41;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							num19 = num38;
							num21 = num42;
							num23 = num39;
							num26 = num38;
							num28 = num39;
							obj15 = obj16;
							num40 = num41;
						}
						float num43 = num37 * (float)num40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v162+24]");
						float num44 = 0f * (float)obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v162+24]");
						float num45 = 0f * num46;
						float num47 = num37 * num48;
						float num49 = num43 + num44;
						double num50 = (double)num36 * num28;
						num6 = num47 + num45;
						float num51 = num36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
						num4 = num51 * 0f;
						double num52 = num50 + (double)num49;
						float num53 = num4 + num6;
						num54 = Into((Vector3)sign, seed, 136);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
						object obj17 = 0;
						object obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2261 @ X0_v171+E4]");
						bool flag7 = (nint)0 == 0;
						object obj19 = !flag7;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						num55 = GillaWounds.Jag((Vector3)0, num37);
						if (num56 < 1)
						{
							obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
							num57 = 0.0;
							num58 = num46;
							num59 = num48;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
							num30 = 0f;
							num60 = num61;
							vector2 = (Vector3)0;
							obj21 = 0;
							goto IL_4807;
						}
						bool flag8 = array2 == null;
						num3 = 136;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
						num30 = 0f;
						num8 = num36;
						num9 = seed;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v162+24]");
						num2 = 0f;
						num = num55;
						if (flag8)
						{
							break;
						}
						object obj22 = obj6;
						object obj23 = obj7;
						num62 = num37;
						num63 = num36;
						obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
						num57 = 0.0;
						num58 = num46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
						num29 = 0f;
						num8 = num36;
						num60 = num61;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v162+24]");
						num32 = 0f;
						num33 = num55;
						vector2 = (Vector3)0;
						obj21 = 0;
						num34 = num14;
						num35 = 0;
						while (true)
						{
							bool flag9 = num35 < array2.Length;
							object obj24 = !flag9;
							num3 = 136;
							num25 = num26;
							num27 = num28;
							num9 = seed;
							if (obj24 != null)
							{
								break;
							}
							num59 = (double)obj22;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num31))
							{
								bool flag10 = array4 == null;
								num3 = 136;
								num30 = num29;
								num9 = seed;
								num2 = num32;
								num = num33;
								if (flag10)
								{
									goto end_IL_5317;
								}
								bool flag11 = num35 < array4.Length;
								object obj25 = !flag11;
								num3 = 136;
								num25 = num26;
								num27 = num28;
								num9 = seed;
								if (obj25 != null)
								{
									break;
								}
								bool flag12 = array3 == null;
								num3 = 136;
								num30 = num29;
								num9 = seed;
								num2 = num32;
								num = num33;
								if (flag12)
								{
									goto end_IL_5317;
								}
								bool flag13 = num35 < array3.Length;
								object obj26 = !flag13;
								num3 = 136;
								num25 = num26;
								num27 = num28;
								num9 = seed;
								if (obj26 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X22_v20-C]");
								float num64 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X22_v20-8]");
								num6 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X22_v20-4]");
								num4 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X29_v22-C]");
								num25 = 0.0;
								object obj28 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1336 @ X25_v17 (System.Int32)-4]");
								num57 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2576 @ X0_v177+E4]");
								bool flag14 = (nint)0 == 0;
								bool flag15 = !flag14;
								if (!flag15)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X22_v20-4]");
									num19 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X22_v20-8]");
									num21 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X22_v20-C]");
									num23 = 0.0;
								}
								float num65 = GillaWounds.OutOf((Vector3)0, (Vector4)seed, (Vector4)136, (Vector4)array2);
								float num66 = num65 - 1.5f;
								bool flag16 = num66 < 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
								bool flag17 = num65 < 0f;
								object obj29 = !flag17;
								float num67 = num65;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
								float num68 = num67 - 0f;
								bool flag18 = num68 == 0f;
								obj21 = flag16 | obj21;
								object obj30 = ~obj29;
								object obj31 = obj30 | flag18;
								float num69 = num36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1336 @ X25_v17 (System.Int32)-8]");
								float num70 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v162+24]");
								float num71 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
								float num72 = 0f;
								Vector3 vector4 = (Vector3)0;
								if (obj31 == null)
								{
									bool flag19 = num35 < array2.Length;
									object obj32 = !flag19;
									num3 = 136;
									num27 = num59;
									num29 = num64;
									num8 = num36;
									num9 = seed;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v162+24]");
									num32 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
									num33 = 0f;
									if (obj32 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
									object obj33 = 0;
									num70 = (float)obj22;
									object obj34 = obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2628 @ X0_v181+E4]");
									bool flag20 = (nint)0 == 0;
									flag15 = !flag20;
									if (!flag15)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									float num73 = GillaWounds.Jag((Vector3)0, num37);
									float num74 = num65 / gone;
									num72 = num74 + num73;
									bool flag21 = !((double)num72 < 1.0);
									num64 = num70;
									num69 = num36;
									num71 = 1f;
									vector4 = (Vector3)0;
									num62 = num37;
									num63 = num36;
									num26 = num25;
									num58 = num65;
									num28 = num59;
									num29 = num70;
									num8 = num36;
									num60 = num70;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
									num31 = 0.0;
									num32 = 1f;
									num33 = num72;
									vector2 = (Vector3)0;
									flag8 = flag15;
									if (flag21)
									{
										goto IL_46b9;
									}
								}
								num62 = num37;
								num63 = num36;
								obj20 = 1;
								num26 = num25;
								num58 = num65;
								num28 = num59;
								num29 = num64;
								num8 = num69;
								num60 = num70;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
								num31 = 0.0;
								num32 = num71;
								num33 = num72;
								vector2 = vector4;
								flag8 = flag15;
							}
							goto IL_46b9;
							IL_46b9:
							num35++;
							obj22 += 16;
							num34 += 16;
							obj23 += 16;
							if (num56 != num35)
							{
								continue;
							}
							goto IL_086e;
						}
					}
					goto IL_44b7;
					IL_086e:
					num15 = num36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v162+24]");
					num17 = 0f;
					num37 = num62;
					num36 = num63;
					num30 = num29;
					goto IL_4807;
					IL_484a:
					object obj35 = obj8 + 1;
					bool flag22 = obj35 != array;
					num10 = num4;
					num16 = num15;
					num18 = num17;
					num20 = num19;
					num22 = num21;
					num24 = num23;
					num11 = num6;
					num12 = num55;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
					num75 = 0f;
					num76 = num31;
					num13 = seed;
					num25 = num26;
					num27 = num28;
					num29 = num30;
					num8 = num55;
					obj8 = obj35;
					num9 = seed;
					num32 = num2;
					num33 = num;
					if (flag22)
					{
						continue;
					}
					goto IL_0b3b;
					IL_4917:
					object obj36 = vector3 + obj8;
					goto IL_484a;
					IL_4807:
					float num77 = num55;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE2C]");
					float num78 = num77 * 0f;
					num = num54 + num78;
					object obj45;
					if (!(num < 0f))
					{
						object obj37 = obj20 & 1;
						bool flag23 = obj37 == null;
						object obj38 = !flag23;
						if (obj38 == null)
						{
							float num79 = num - 1.00898176E+09f;
							bool flag24 = num79 < 0f;
							object obj39 = !flag24;
							object obj40 = ~obj21;
							object obj41 = obj39 & obj40;
							object obj42 = obj41 & 1;
							bool flag25 = obj42 == null;
							flag2 = !flag25;
							num2 = 1.00898176E+09f;
							if (flag2)
							{
								goto IL_484a;
							}
							flag2 = vector3 == (Vector3)(object)0;
							num3 = 136;
							num8 = num55;
							num9 = seed;
							num2 = 1.00898176E+09f;
							if (flag2)
							{
								break;
							}
							object obj43 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v10 (UnityEngine.Vector3)+18]");
							bool flag26 = (nint)obj43 < 0;
							object obj44 = !flag26;
							num3 = 136;
							num25 = num26;
							num27 = num28;
							num29 = num30;
							num8 = num55;
							num9 = seed;
							num32 = 1.00898176E+09f;
							num33 = num;
							if (obj44 != null)
							{
								goto IL_44b7;
							}
							num2 = 1.00898176E+09f;
							obj45 = 1;
							goto IL_4917;
						}
					}
					flag2 = vector3 == (Vector3)(object)0;
					num3 = 136;
					num8 = num55;
					num9 = seed;
					num2 = num54;
					if (flag2)
					{
						break;
					}
					object obj46 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v10 (UnityEngine.Vector3)+18]");
					bool flag27 = (nint)obj46 < 0;
					object obj47 = !flag27;
					num3 = 136;
					num25 = num26;
					num27 = num28;
					num29 = num30;
					num8 = num55;
					num9 = seed;
					num32 = num54;
					num33 = num;
					if (obj47 != null)
					{
						goto IL_44b7;
					}
					num2 = num54;
					obj45 = 2;
					goto IL_4917;
					continue;
					end_IL_5317:
					break;
				}
			}
		}
		goto IL_44ed;
		IL_44fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (Built)(object)new ArgumentNullException();
		IL_421b:
		List<int> list = default;
		object obj53 = default;
		List<Vector3> list2 = default;
		List<Vector2> list3 = default;
		List<Vector4> list4 = default;
		List<Vector2> list5 = default;
		List<Vector3> list6 = default;
		NullReferenceException ex = default;
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)0 == 0)
			{
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69B8]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			_ = 1065353216;
			object obj49 = default;
			obj49._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CD0]");
			object obj50 = 0;
			object obj51 = obj49 + 16;
			obj51 = obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj52 = obj49 + 24;
			obj52 = obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj54 = obj49 + 32;
			obj54 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj55 = obj49 + 56;
			obj55 = list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj56 = obj49 + 64;
			obj56 = list4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj57 = obj49 + 112;
			obj57 = list5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj58 = obj49 + 48;
			obj58 = list6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56B0]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj60 = default;
			bool flag28 = obj60 == null;
			num9 = 1;
			if (!flag28)
			{
				object obj61 = obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1511 @ X8_v40+40]");
				num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				if (ex != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X0_v75+18]");
					bool flag29 = (nint)0 == 0;
					num25 = num26;
					num27 = num28;
					num29 = num30;
					num32 = num2;
					num33 = num;
					if (!flag29)
					{
						object obj62 = obj60 + 32;
						obj62 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj63 = obj49 + 96;
						obj63 = obj60;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						return (Built)obj49;
					}
					goto IL_44b7;
				}
				goto IL_44fb;
			}
		}
		goto IL_44ed;
		IL_0b3b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		int num80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C0]");
		int num81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6788]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC8]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CC8]");
		int num82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj66 = 0;
		num3 = 136;
		object obj67 = 0;
		object obj68 = default;
		object obj71 = default;
		Vector3 vector5 = default;
		int[] array7 = default;
		object obj73 = default;
		while (true)
		{
			if (middles.Length < 1)
			{
				goto IL_0efe;
			}
			bool flag30 = vector3 == (Vector3)(object)0;
			array3 = (Vector4[])middles.Length;
			array4 = array;
			num4 = num10;
			num6 = num11;
			num8 = num12;
			num9 = num13;
			if (flag30)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v10 (UnityEngine.Vector3)+18]");
			obj68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v10 (UnityEngine.Vector3)+18]");
			object obj69 = 0 & 0xFFFFFFFFL;
			object obj70 = obj71;
			Vector4[] array5 = array2;
			int num83 = num3;
			object obj72 = obj73;
			int[] array6 = array7;
			object obj74 = 0;
			num9 = num13;
			vector5 = (Vector3)0;
			while (true)
			{
				bool flag31 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj74) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj69);
				object obj75 = !flag31;
				array2 = array5;
				num3 = num83;
				array3 = (Vector4[])middles.Length;
				array4 = array;
				num4 = num10;
				num25 = num26;
				num27 = num28;
				num6 = num11;
				num29 = num30;
				num8 = num12;
				num32 = num2;
				num33 = num;
				if (obj75 != null)
				{
					break;
				}
				object obj76 = vector3 + obj74;
				object obj77 = obj76 + 32;
				if ((nint)obj77 == 1)
				{
					array6 = s.across;
					bool flag32 = s.across == null;
					array2 = array5;
					num3 = num83;
					array3 = (Vector4[])middles.Length;
					array4 = array;
					num4 = num10;
					num6 = num11;
					num8 = num12;
					if (flag32)
					{
						goto end_IL_49e9;
					}
					object obj78 = vector5 << 32;
					num9 = array6.Length;
					num3 = 0;
					obj72 = 0;
					while (true)
					{
						array2 = (Vector4[])(vector5 + obj72);
						bool flag33 = (nint)array2 < num9;
						object obj79 = !flag33;
						array3 = (Vector4[])middles.Length;
						array4 = array;
						num4 = num10;
						num25 = num26;
						num27 = num28;
						num6 = num11;
						num29 = num30;
						num8 = num12;
						num32 = num2;
						num33 = num;
						if (obj79 != null)
						{
							break;
						}
						object obj80 = (object)array6 + obj78;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2411 @ X3_v16+20]");
						array2 = (Vector4[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2411 @ X3_v16+20]");
						object obj81 = 0 & 0x80000000L;
						if (obj81 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2411 @ X3_v16+20]");
							bool flag34 = 0 < (nint)obj68;
							object obj82 = !flag34;
							array3 = (Vector4[])middles.Length;
							array4 = array;
							num4 = num10;
							num25 = num26;
							num27 = num28;
							num6 = num11;
							num29 = num30;
							num8 = num12;
							num32 = num2;
							num33 = num;
							if (obj82 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2411 @ X3_v16+20]");
							object obj83 = vector3 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2466 @ X3_v20+20]");
							array2 = (Vector4[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2466 @ X3_v20+20]");
							bool flag35 = (nint)0 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2466 @ X3_v20+20]");
							array5 = (Vector4[])0;
							if (flag35)
							{
								goto IL_49a9;
							}
						}
						num3++;
						array5 = array2;
						goto IL_49a9;
						IL_49a9:
						obj72++;
						obj78 += 4294967296L;
						if ((nint)obj72 != 3)
						{
							continue;
						}
						goto IL_0e9b;
					}
					break;
				}
				goto IL_492e;
				IL_0e9b:
				object obj84 = num3 - 1;
				bool flag36 = obj84 == null;
				obj70 = !flag36;
				bool flag37 = num3 > 1;
				num83 = num3;
				if (!flag37)
				{
					obj77 = 2;
					num83 = num3;
				}
				goto IL_492e;
				IL_492e:
				object obj35 = obj74 + 1;
				Vector3 vector2 = vector5 + 3;
				bool flag38 = obj35 != array;
				obj71 = obj70;
				array2 = array5;
				num3 = num83;
				obj73 = obj72;
				array7 = array6;
				num13 = num9;
				obj74 = obj35;
				vector5 = vector2;
				if (flag38)
				{
					continue;
				}
				goto IL_0efe;
			}
			goto IL_44b7;
			IL_0efe:
			obj67++;
			if ((nint)obj67 != 2)
			{
				continue;
			}
			goto IL_0f2c;
			continue;
			end_IL_49e9:
			break;
		}
		goto IL_44ed;
		IL_0f2c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list7 = default;
		list7._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		list2._002Ector();
		object obj85 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj53, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		list3._002Ector();
		object obj86 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj53, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		list4._002Ector();
		object obj87 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj53, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		list5._002Ector();
		object obj88 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj53, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		list6._002Ector();
		object obj89 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj53, 112));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		list._002Ector();
		num9 = s.points;
		object obj91 = default;
		object obj90 = (object)(&obj91);
		object obj93 = default;
		object obj94 = default;
		object obj92 = obj93 * obj94;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X9_v13+FF]");
		object obj96 = default;
		object obj95 = 0 * obj96;
		object obj97 = obj92 + obj95;
		object obj98 = default;
		num6 = num48 * (float)obj98;
		num8 = (float)obj97 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj99 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
		object obj101 = 0;
		bool flag39 = middles.Length < 1;
		array3 = (Vector4[])middles.Length;
		array4 = array;
		if (flag39)
		{
			goto IL_1890;
		}
		bool flag40 = vector3 == (Vector3)(object)0;
		array3 = (Vector4[])middles.Length;
		array4 = array;
		num4 = num48;
		num26 = num39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
		num28 = 0.0;
		num30 = faceAcross;
		num2 = num7;
		num = num5;
		bool flag42 = default;
		int num87 = default;
		if (!flag40)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v10 (UnityEngine.Vector3)+18]");
			object obj102 = 0 & 0xFFFFFFFFL;
			Vector3 vector6 = vector;
			bool flag41 = flag42;
			int num84 = num56;
			Vector4[] array8 = array2;
			int num85 = num3;
			int[] array9 = (int[])vector5;
			object obj103 = 0;
			Vector4[] array10 = (Vector4[])middles.Length;
			Vector4[] array11 = array;
			int num86 = num87;
			object obj104 = 0;
			while (true)
			{
				bool flag43 = obj104 == obj102;
				vector = vector6;
				num56 = num84;
				array2 = array8;
				num3 = num85;
				array3 = array10;
				array4 = array11;
				num4 = num48;
				num25 = num39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2691 @ X7_v6 (UnityEngine.Vector3)+20]");
				num27 = 0.0;
				num29 = faceAcross;
				num32 = num7;
				num33 = num5;
				if (flag43)
				{
					break;
				}
				object obj105 = vector3 + obj104;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2735 @ X13_v8+20]");
				if ((nint)0 != 1)
				{
					goto IL_1807;
				}
				array9 = s.across;
				bool flag44 = s.across == null;
				vector = vector6;
				num56 = num84;
				array2 = array8;
				num3 = num85;
				array3 = array10;
				array4 = array11;
				num4 = num48;
				num26 = num39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2691 @ X7_v6 (UnityEngine.Vector3)+20]");
				num28 = 0.0;
				num30 = faceAcross;
				num2 = num7;
				num = num5;
				if (!flag44)
				{
					object obj106 = obj103 << 32;
					array7 = (int[])(object)(obj104 + obj104);
					obj73 = array9.Length;
					vector = vector6;
					bool flag45 = flag41;
					num56 = num84;
					array2 = array8;
					array3 = array10;
					array4 = array11;
					int num88 = num9;
					int num89 = 0;
					while (true)
					{
						num3 = obj103 + num89;
						bool flag46 = num3 < (nint)obj73;
						object obj107 = !flag46;
						num4 = num48;
						num25 = num39;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
						num27 = 0.0;
						num29 = faceAcross;
						num9 = num88;
						num32 = num7;
						num33 = num5;
						if (obj107 != null)
						{
							break;
						}
						array4 = (Vector4[])(obj106 >> 32);
						object obj108 = (object)array9 + (object)array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2874 @ X1_v81+20]");
						num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2874 @ X1_v81+20]");
						if (0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2874 @ X1_v81+20]");
							nint num90 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v10 (UnityEngine.Vector3)+18]");
							bool flag47 = num90 < 0;
							object obj109 = !flag47;
							num4 = num48;
							num25 = num39;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
							num27 = 0.0;
							num29 = faceAcross;
							num32 = num7;
							num33 = num5;
							if (obj109 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2874 @ X1_v81+20]");
							object obj110 = vector3 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3008 @ X1_v84+20]");
							num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3008 @ X1_v84+20]");
							if ((nint)0 == 2)
							{
								num9 = (int)s.corners;
								bool flag48 = s.corners == null;
								num4 = num48;
								num26 = num39;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
								num28 = 0.0;
								num30 = faceAcross;
								num2 = num7;
								num = num5;
								if (!flag48)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2712 @ X1_v79 (System.Int32)+18]");
									array2 = (Vector4[])0;
									int num91 = num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2712 @ X1_v79 (System.Int32)+18]");
									bool flag49 = (nint)num91 < (nint)0;
									object obj111 = !flag49;
									num4 = num48;
									num25 = num39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
									num27 = 0.0;
									num29 = faceAcross;
									num32 = num7;
									num33 = num5;
									if (obj111 != null)
									{
										break;
									}
									num3 = (int)s.point;
									bool flag50 = s.point == null;
									num4 = num48;
									num26 = num39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
									num28 = 0.0;
									num30 = faceAcross;
									num2 = num7;
									num = num5;
									if (!flag50)
									{
										object obj112 = (object)s.corners + (object)array4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3042 @ X4_v11+20]");
										array3 = (Vector4[])0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2754 @ X2_v31 (System.Int32)+18]");
										array4 = (Vector4[])0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3042 @ X4_v11+20]");
										nint num92 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2754 @ X2_v31 (System.Int32)+18]");
										bool flag51 = num92 < 0;
										object obj113 = !flag51;
										num4 = num48;
										num25 = num39;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
										num27 = 0.0;
										num29 = faceAcross;
										num32 = num7;
										num33 = num5;
										if (obj113 != null)
										{
											break;
										}
										flag40 = num87 == 0;
										num4 = num48;
										num26 = num39;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
										num28 = 0.0;
										num30 = faceAcross;
										num2 = num7;
										num = num5;
										if (!flag40)
										{
											int[] point = s.point;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3042 @ X4_v11+20]");
											object obj114 = point + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3057 @ X5_v11+20]");
											num56 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X0_v44 (System.Int32)+18]");
											array3 = (Vector4[])0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3057 @ X5_v11+20]");
											nint num93 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X0_v44 (System.Int32)+18]");
											bool flag52 = num93 < 0;
											object obj115 = !flag52;
											num4 = num48;
											num25 = num39;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
											num27 = 0.0;
											num29 = faceAcross;
											num32 = num7;
											num33 = num5;
											if (obj115 != null)
											{
												break;
											}
											num56 = num87 + num56;
											flag45 = num89 != 2;
											object obj116 = (flag45 ? ((object)(num89 + 1)) : ((object)0));
											_ = 1;
											vector = (Vector3)(obj116 + (object)array7);
											bool flag53 = vector < (object)array2;
											object obj117 = !flag53;
											num4 = num48;
											num25 = num39;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
											num27 = 0.0;
											num29 = faceAcross;
											num32 = num7;
											num33 = num5;
											if (obj117 != null)
											{
												break;
											}
											object obj118 = num9 + vector;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3095 @ X1_v87+20]");
											num9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3095 @ X1_v87+20]");
											bool flag54 = 0 < (nint)array4;
											object obj119 = !flag54;
											num4 = num48;
											num25 = num39;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
											num27 = 0.0;
											num29 = faceAcross;
											num32 = num7;
											num33 = num5;
											if (obj119 != null)
											{
												break;
											}
											int num94 = num3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3095 @ X1_v87+20]");
											object obj120 = (nint)num94 + (nint)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3099 @ X1_v89+20]");
											num9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3099 @ X1_v89+20]");
											bool flag55 = 0 < (nint)array3;
											object obj121 = !flag55;
											num4 = num48;
											num25 = num39;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
											num27 = 0.0;
											num29 = faceAcross;
											num32 = num7;
											num33 = num5;
											if (obj121 != null)
											{
												break;
											}
											num9 = num87 + num9;
											_ = 1;
											goto IL_4ad5;
										}
									}
								}
								goto IL_44ed;
							}
						}
						goto IL_4ad5;
						IL_4ad5:
						num86 = num89 + 1;
						obj106 += 4294967296L;
						bool flag56 = num86 != 3;
						vector6 = vector;
						flag41 = flag45;
						num84 = num56;
						array8 = array2;
						num85 = num3;
						array10 = array3;
						array11 = array4;
						num88 = num9;
						num89 = num86;
						if (flag56)
						{
							continue;
						}
						goto IL_1807;
					}
					break;
				}
				goto IL_44ed;
				IL_1807:
				obj104++;
				obj103 += 3;
				bool flag57 = obj104 != array;
				vector = vector6;
				flag42 = flag41;
				num56 = num84;
				array2 = array8;
				num3 = num85;
				obj68 = 1;
				array3 = array10;
				array4 = array11;
				object obj35 = 4294967296L;
				if (flag57)
				{
					continue;
				}
				goto IL_1890;
			}
			goto IL_44b7;
		}
		goto IL_44ed;
		IL_1890:
		num9 = s.points;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj122 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		List<int> list8 = default;
		bool flag58 = list8 == null;
		num4 = num48;
		num26 = num39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
		num28 = 0.0;
		num30 = faceAcross;
		num2 = num7;
		num = num5;
		if (!flag58)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_19db;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj123 = ~(nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj124 = 0 & obj123;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj125 = 0 & 0xFFFFFFFFL;
			object obj126 = list8 + 32;
			while (true)
			{
				bool flag59 = obj125 == null;
				num4 = num48;
				num25 = num39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
				num27 = 0.0;
				num29 = faceAcross;
				num32 = num7;
				num33 = num5;
				if (flag59)
				{
					break;
				}
				obj125--;
				obj126 = 4294967295L;
				obj126 += 4;
				bool flag60 = (nint)obj124 != 1;
				object obj35 = 4294967295L;
				if (flag60)
				{
					continue;
				}
				goto IL_19db;
			}
			goto IL_44b7;
		}
		goto IL_44ed;
		IL_44b7:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		num26 = num25;
		num28 = num27;
		num30 = num29;
		num2 = num32;
		num = num33;
		goto IL_44ed;
		IL_44ed:
		ex = new NullReferenceException();
		goto IL_44fb;
		IL_19db:
		bool flag61 = middles.Length < 1;
		num4 = num48;
		num26 = num39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
		num28 = 0.0;
		num30 = faceAcross;
		num2 = num7;
		num = num5;
		if (flag61)
		{
			goto IL_421b;
		}
		bool flag62 = vector3 == (Vector3)(object)0;
		num4 = num48;
		num26 = num39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
		num28 = 0.0;
		num30 = faceAcross;
		num2 = num7;
		num = num5;
		if (!flag62)
		{
			int num95 = num3;
			float num96 = num48;
			Vector4[] array12 = array;
			double num97 = 0.0;
			num25 = num39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ X7_v8 (UnityEngine.Vector3)+20]");
			num27 = 0.0;
			float num98 = num6;
			num29 = faceAcross;
			float num99 = num8;
			object obj127 = 0;
			int num100 = num9;
			num32 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			num33 = 0f;
			List<int> list9 = list8;
			int num101 = num87;
			object obj128 = 0;
			float num110 = default;
			float num111 = default;
			object obj194 = default;
			object obj227 = default;
			float num166 = default;
			object obj236 = default;
			float num178 = default;
			float byBreak = default;
			object obj242 = default;
			while (true)
			{
				object obj129 = obj127;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v10 (UnityEngine.Vector3)+18]");
				bool flag63 = (nint)obj129 < 0;
				object obj130 = !flag63;
				num3 = num95;
				num4 = num96;
				num6 = num98;
				num8 = num99;
				num9 = num100;
				if (obj130 != null)
				{
					break;
				}
				object obj131 = vector3 + obj127;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2877 @ X9_v21+20]");
				if ((nint)0 != 1)
				{
					goto IL_4190;
				}
				num101 = obj128 << 32;
				double num102 = (double)obj127 + (double)obj127;
				ref GillaSawHits._003C_003Ec__DisplayClass60_0 reference = ref *(GillaSawHits._003C_003Ec__DisplayClass60_0*)num95;
				array12 = null;
				float num103 = (float)num59;
				int num104 = (int)list9;
				num81 = num101;
				object obj35;
				while (true)
				{
					int[] corners = s.corners;
					bool flag64 = s.corners == null;
					num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num4 = num96;
					num26 = num25;
					num28 = num27;
					num6 = num98;
					num30 = num29;
					num8 = num99;
					num9 = num100;
					num2 = num32;
					num = num33;
					if (flag64)
					{
						break;
					}
					object obj132 = obj128 + (object)array12;
					bool flag65 = (nint)obj132 < corners.Length;
					object obj133 = !flag65;
					num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num4 = num96;
					num6 = num98;
					num8 = num99;
					num9 = num100;
					if (obj133 != null)
					{
						goto end_IL_5271;
					}
					int[] point2 = s.point;
					bool flag66 = s.point == null;
					num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num4 = num96;
					num26 = num25;
					num28 = num27;
					num6 = num98;
					num30 = num29;
					num8 = num99;
					num9 = num100;
					num2 = num32;
					num = num33;
					if (flag66)
					{
						break;
					}
					object obj134 = s.corners + num81;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X8_v52+20]");
					bool flag67 = (nint)0 < (nint)point2.Length;
					object obj135 = !flag67;
					num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num4 = num96;
					num6 = num98;
					num8 = num99;
					num9 = num100;
					if (obj135 != null)
					{
						goto end_IL_5271;
					}
					int[] point3 = s.point;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X8_v52+20]");
					object obj136 = point3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3044 @ X9_v28+20]");
					num80 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3044 @ X9_v28+20]");
					nint num105 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
					bool flag68 = num105 < 0;
					object obj137 = !flag68;
					num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num4 = num96;
					num6 = num98;
					num8 = num99;
					num9 = num100;
					if (obj137 != null)
					{
						goto end_IL_5271;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3044 @ X9_v28+20]");
					object obj138 = list8 + 0;
					num82 = obj138 + 32;
					object obj139 = ((int*)num82)->m_value & 0x80000000L;
					bool flag69 = obj139 == null;
					num9 = ((int*)num82)->m_value;
					if (!flag69)
					{
						Vector3[] at = s.at;
						bool flag70 = s.at == null;
						num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						num4 = num96;
						num26 = num25;
						num28 = num27;
						num6 = num98;
						num30 = num29;
						num8 = num99;
						num9 = ((int*)num82)->m_value;
						num2 = num32;
						num = num33;
						if (flag70)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X8_v52+20]");
						bool flag71 = (nint)0 < (nint)at.Length;
						object obj140 = !flag71;
						num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						num4 = num96;
						num6 = num98;
						num8 = num99;
						num9 = ((int*)num82)->m_value;
						if (obj140 != null)
						{
							goto end_IL_5271;
						}
						Vector3[] faces = s.faces;
						bool flag72 = s.faces == null;
						num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						num4 = num96;
						num26 = num25;
						num28 = num27;
						num6 = num98;
						num30 = num29;
						num8 = num99;
						num9 = ((int*)num82)->m_value;
						num2 = num32;
						num = num33;
						if (flag72)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X8_v52+20]");
						bool flag73 = (nint)0 < (nint)faces.Length;
						object obj141 = !flag73;
						num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						num4 = num96;
						num6 = num98;
						num8 = num99;
						num9 = ((int*)num82)->m_value;
						if (obj141 != null)
						{
							goto end_IL_5271;
						}
						bool flag74 = num87 == 0;
						num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						num4 = num96;
						num26 = num25;
						num28 = num27;
						num6 = num98;
						num30 = num29;
						num8 = num99;
						num9 = ((int*)num82)->m_value;
						num2 = num32;
						num = num33;
						if (flag74)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3044 @ X9_v28+20]");
						nint num106 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X0_v44 (System.Int32)+18]");
						bool flag75 = num106 < 0;
						object obj142 = !flag75;
						num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						num4 = num96;
						num6 = num98;
						num8 = num99;
						num9 = ((int*)num82)->m_value;
						if (obj142 != null)
						{
							goto end_IL_5271;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3044 @ X9_v28+20]");
						object obj143 = (nint)num87 + (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X8_v52+20]");
						object obj144 = (nint)0 * (nint)12;
						object obj145 = (object)s.at + obj144;
						object obj146 = obj100;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X8_v52+20]");
						object obj147 = (nint)0 * (nint)12;
						object obj148 = (object)s.faces + obj147;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3108 @ X11_v37+20]");
						flag42 = (nint)0 != 0;
						num76 = (flag42 ? 1.0 : num97);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3111 @ X9_v81+20]");
						num58 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3111 @ X9_v81+24]");
						num60 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3114 @ X8_v145+20]");
						num36 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3111 @ X9_v81+28]");
						num103 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3114 @ X8_v145+28]");
						num37 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3112 @ X0_v147+E4]");
						bool flag76 = (nint)0 == 0;
						object obj149 = !flag76;
						if (obj149 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						num104 = _003CBone_003Eg__Put_007C60_0((Vector3)(&obj53), (Vector3)((int*)num82)->m_value, num58, num60, ref reference);
						int num107 = num80;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
						bool flag77 = (nint)num107 < (nint)0;
						object obj150 = !flag77;
						num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						num4 = num37;
						num25 = num76;
						num27 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3114 @ X8_v145+24]");
						num6 = 0f;
						num29 = num36;
						num8 = num103;
						num9 = ((int*)num82)->m_value;
						num32 = num60;
						num33 = num58;
						if (obj150 != null)
						{
							goto end_IL_5271;
						}
						((int*)num82)->m_value = num104;
						obj68 = 12;
						num96 = num37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3114 @ X8_v145+24]");
						num57 = 0.0;
						num25 = num76;
						num27 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3114 @ X8_v145+24]");
						num98 = 0f;
						num29 = num36;
						num99 = num103;
						num9 = num104;
						num32 = num60;
						num33 = num58;
					}
					bool flag78 = list == null;
					num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num4 = num96;
					num26 = num25;
					num28 = num27;
					num6 = num98;
					num30 = num29;
					num8 = num99;
					num2 = num32;
					num = num33;
					if (flag78)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+10]");
					object obj151 = 0;
					object obj152 = obj101;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj153 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+10]");
					flag62 = (nint)0 == 0;
					num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num4 = num96;
					num26 = num25;
					num28 = num27;
					num6 = num98;
					num30 = num29;
					num8 = num99;
					num2 = num32;
					num = num33;
					if (flag62)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1361 @ X8_v55+18]");
					obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num108 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1361 @ X8_v55+18]");
					bool flag79 = num108 < 0;
					object obj154 = !flag79;
					if (obj154 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num109 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj155 = num109 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj156 = (nint)0 + (nint)1;
						num95 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						list9 = (List<int>)num104;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X9_v31+20]");
						object obj157 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3091 @ X8_v142+A8]");
						object obj158 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3093 @ X8_v143+70]");
						num95 = 0;
						list.AddWithResize(num9);
						list9 = list;
					}
					array12 = (Vector4[])(array12 + 1);
					num81 = (int)(num81 + 4294967296L);
					bool flag80 = (nint)array12 != 3;
					reference = ref *(GillaSawHits._003C_003Ec__DisplayClass60_0*)num95;
					num100 = num9;
					num104 = (int)list9;
					if (flag80)
					{
						continue;
					}
					goto IL_2433;
				}
				goto IL_44ed;
				IL_4190:
				obj127++;
				obj128 += 3;
				bool flag81 = obj127 != array;
				num3 = num95;
				num4 = num96;
				num26 = num25;
				num28 = num27;
				num6 = num98;
				num30 = num29;
				num8 = num99;
				num9 = num100;
				num2 = num32;
				num = num33;
				if (flag81)
				{
					continue;
				}
				goto IL_421b;
				IL_2433:
				bool flag82 = thick < 0f;
				object obj159 = !flag82;
				bool flag83 = thick == 0f;
				object obj160 = ~obj159;
				object obj161 = obj160 | flag83;
				num59 = num103;
				num100 = num9;
				num33 = thick;
				if (obj161 != null)
				{
					goto IL_4190;
				}
				num110 = num110;
				num111 = num111;
				bool flag84 = flag42;
				object obj162 = obj71;
				ref GillaSawHits._003C_003Ec__DisplayClass60_0 reference2 = ref *(GillaSawHits._003C_003Ec__DisplayClass60_0*)num95;
				object obj163 = obj68;
				num4 = num96;
				float num112 = num16;
				float num113 = num18;
				Vector4[] array13 = null;
				object obj164 = obj101;
				double num114 = num20;
				float num115 = num22;
				float num116 = (float)num24;
				double num117 = num97;
				float num118 = num37;
				float num119 = num36;
				int num120 = num80;
				float num121 = (float)num57;
				num26 = num25;
				float num122 = num58;
				num28 = num27;
				num6 = num98;
				num30 = num29;
				num8 = num99;
				float num123 = num60;
				float num124 = num75;
				int num125 = num82;
				object obj165 = obj35;
				double num126 = num76;
				Vector3 vector7 = (Vector3)num9;
				num2 = num32;
				num = thick;
				List<int> list10 = list9;
				int num127 = num101;
				object obj166 = obj100;
				while (true)
				{
					int[] across = s.across;
					bool flag85 = s.across == null;
					num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
					num9 = (int)vector7;
					if (flag85)
					{
						break;
					}
					object obj167 = obj128 + (object)array13;
					bool flag86 = (nint)obj167 < across.Length;
					object obj168 = !flag86;
					num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
					num25 = num26;
					num27 = num28;
					num29 = num30;
					num9 = (int)vector7;
					num32 = num2;
					num33 = num;
					if (obj168 != null)
					{
						goto end_IL_5271;
					}
					int num128 = num127 >> 32;
					object obj169 = s.across + num128;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3137 @ X10_v24+20]");
					num81 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3137 @ X10_v24+20]");
					int num129 = 0;
					bool flag87 = num129 == 0;
					flag62 = !flag87;
					num95 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
					num100 = (int)vector7;
					if (!flag62)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3137 @ X10_v24+20]");
						nint num130 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X0_v10 (UnityEngine.Vector3)+18]");
						bool flag88 = num130 < 0;
						object obj170 = !flag88;
						num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
						num25 = num26;
						num27 = num28;
						num29 = num30;
						num9 = (int)vector7;
						num32 = num2;
						num33 = num;
						if (obj170 != null)
						{
							goto end_IL_5271;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3137 @ X10_v24+20]");
						object obj171 = vector3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3177 @ X10_v27+20]");
						bool flag89 = (nint)0 != 2;
						num95 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
						num100 = (int)vector7;
						if (!flag89)
						{
							int[] corners2 = s.corners;
							bool flag90 = s.corners == null;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num9 = (int)vector7;
							if (flag90)
							{
								break;
							}
							obj163 = corners2.Length;
							bool flag91 = (nint)obj167 < corners2.Length;
							object obj172 = !flag91;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num25 = num26;
							num27 = num28;
							num29 = num30;
							num9 = (int)vector7;
							num32 = num2;
							num33 = num;
							if (obj172 != null)
							{
								goto end_IL_5271;
							}
							object obj173 = (((nint)array13 != 2) ? ((object)(array13 + 1)) : ((object)0));
							double num131 = (double)obj173 + num102;
							bool flag92 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num131) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj163);
							object obj174 = !flag92;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num25 = num26;
							num27 = num28;
							num29 = num30;
							num9 = (int)vector7;
							num32 = num2;
							num33 = num;
							if (obj174 != null)
							{
								goto end_IL_5271;
							}
							Vector3[] at2 = s.at;
							bool flag93 = s.at == null;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num9 = (int)vector7;
							if (flag93)
							{
								break;
							}
							object obj175 = s.corners + num128;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3193 @ X8_v63+20]");
							bool flag94 = (nint)0 < (nint)at2.Length;
							object obj176 = !flag94;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num25 = num26;
							num27 = num28;
							num29 = num30;
							num9 = (int)vector7;
							num32 = num2;
							num33 = num;
							if (obj176 != null)
							{
								goto end_IL_5271;
							}
							double num132 = (double)s.corners + num131;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X10_v30 (System.Double)+20]");
							bool flag95 = (nint)0 < (nint)at2.Length;
							object obj177 = !flag95;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num25 = num26;
							num27 = num28;
							num29 = num30;
							num9 = (int)vector7;
							num32 = num2;
							num33 = num;
							if (obj177 != null)
							{
								goto end_IL_5271;
							}
							Vector3[] faces2 = s.faces;
							bool flag96 = s.faces == null;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num9 = (int)vector7;
							if (flag96)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3193 @ X8_v63+20]");
							bool flag97 = (nint)0 < (nint)faces2.Length;
							object obj178 = !flag97;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num25 = num26;
							num27 = num28;
							num29 = num30;
							num9 = (int)vector7;
							num32 = num2;
							num33 = num;
							if (obj178 != null)
							{
								goto end_IL_5271;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3193 @ X8_v63+20]");
							object obj179 = (nint)0 * (nint)12;
							object obj180 = (object)s.at + obj179;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X10_v30 (System.Double)+20]");
							object obj181 = (nint)0 * (nint)12;
							object obj182 = (object)s.at + obj181;
							object obj183 = s.faces + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj184 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3193 @ X8_v63+20]");
							object obj185 = (nint)0 * (nint)12;
							object obj186 = obj183 + obj185;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3193 @ X8_v63+20]");
							object obj187 = (nint)0 * (nint)12;
							object obj188 = obj183 + obj187;
							object obj189 = obj184;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3233 @ X0_v93+E4]");
							bool flag98 = (nint)0 == 0;
							object obj190 = !flag98;
							if (obj190 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj191 = obj186 * obj186;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3232 @ X23_v15+4]");
							nint num133 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3232 @ X23_v15+4]");
							object obj192 = num133 * 0;
							object obj193 = obj191 + obj192;
							num = (float)obj193 + (float)obj194;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							float num134 = num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							float num136;
							float num137;
							if (num134 > 0f)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								num8 = (float)obj186;
								object obj195 = obj188 + 8;
								float num135 = (float)obj186;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								num136 = num135 / 0f;
								num2 = (float)obj195;
								num137 = (float)obj195 / num;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj196 = 0;
								object obj197 = obj196;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3254 @ X8_v137+A0]");
								object obj198 = 0;
								num136 = (float)obj198;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3255 @ X8_v138+8]");
								num137 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								num2 = 0f;
							}
							Vector3[] faces3 = s.faces;
							bool flag99 = s.faces == null;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num9 = (int)vector7;
							if (flag99)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X10_v30 (System.Double)+20]");
							bool flag100 = (nint)0 < (nint)faces3.Length;
							object obj199 = !flag100;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num25 = num26;
							num27 = num28;
							num29 = num30;
							num9 = (int)vector7;
							num32 = num2;
							num33 = num;
							if (obj199 != null)
							{
								goto end_IL_5271;
							}
							object obj200 = s.faces + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj201 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X10_v30 (System.Double)+20]");
							object obj202 = (nint)0 * (nint)12;
							object obj203 = obj200 + obj202;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X10_v30 (System.Double)+20]");
							object obj204 = (nint)0 * (nint)12;
							object obj205 = obj200 + obj204;
							object obj206 = obj201;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3288 @ X0_v97+E4]");
							bool flag101 = (nint)0 == 0;
							object obj207 = !flag101;
							if (obj207 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj208 = obj203 * obj203;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3287 @ X23_v17+4]");
							nint num138 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3287 @ X23_v17+4]");
							object obj209 = num138 * 0;
							object obj210 = obj208 + obj209;
							num = (float)obj210 + (float)obj194;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							float num139 = num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							float num141;
							float num142;
							if (num139 > 0f)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								num8 = (float)obj203;
								object obj211 = obj205 + 8;
								float num140 = (float)obj203;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								num141 = num140 / 0f;
								num2 = (float)obj211;
								num142 = (float)obj211 / num;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj212 = 0;
								object obj213 = obj212;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3308 @ X8_v130+A0]");
								object obj214 = 0;
								num141 = (float)obj214;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3309 @ X8_v131+8]");
								num142 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								num2 = 0f;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
							obj166 = 0;
							Vector3[] faces4 = s.faces;
							bool flag102 = s.faces == null;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num9 = (int)vector7;
							if (flag102)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3193 @ X8_v63+20]");
							bool flag103 = (nint)0 < (nint)faces4.Length;
							object obj215 = !flag103;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num25 = num26;
							num27 = num28;
							num29 = num30;
							num9 = (int)vector7;
							num32 = num2;
							num33 = num;
							if (obj215 != null)
							{
								goto end_IL_5271;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X10_v30 (System.Double)+20]");
							bool flag104 = (nint)0 < (nint)faces4.Length;
							object obj216 = !flag104;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num25 = num26;
							num27 = num28;
							num29 = num30;
							num9 = (int)vector7;
							num32 = num2;
							num33 = num;
							if (obj216 != null)
							{
								goto end_IL_5271;
							}
							object obj217 = s.faces + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3193 @ X8_v63+20]");
							object obj218 = (nint)0 * (nint)12;
							object obj219 = obj217 + obj218;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X10_v30 (System.Double)+20]");
							object obj220 = (nint)0 * (nint)12;
							object obj221 = obj217 + obj220;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj222 = 0;
							object obj223 = obj222;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3348 @ X0_v101+E4]");
							bool flag105 = (nint)0 == 0;
							object obj224 = !flag105;
							if (obj224 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3201 @ X9_v39+28]");
							double num143 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+28]");
							num27 = num143 - 0.0;
							object obj225 = obj219 + obj221;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3201 @ X9_v39+20]");
							float num144 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+20]");
							float num145 = num144 - 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3318 @ X9_v47+8]");
							nint num146 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3320 @ X8_v86+8]");
							object obj226 = num146 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3320 @ X8_v86+8]");
							float num147 = 0f * num30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3320 @ X8_v86+8]");
							num6 = 0f * (float)obj226;
							num = num6 - num147;
							float num148 = (float)obj225 * num145;
							float num149 = num148 - (float)obj227;
							float num150 = num * num;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
							float num151 = num149 * num149;
							num8 = num151 + num150;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							float num152 = num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							if (num152 > 0f)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								num2 = num149 / num8;
								float num153 = num;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								num111 = num153 / 0f;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj228 = 0;
								object obj229 = obj228;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3376 @ X8_v124+A0]");
								object obj230 = 0;
								num111 = (float)obj230;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3377 @ X8_v125+8]");
								num2 = 0f;
							}
							Vector3[] middles3 = s.middles;
							bool flag106 = s.middles == null;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num4 = num145;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+20]");
							num26 = 0.0;
							num28 = num27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							num30 = 0f;
							num9 = (int)vector7;
							if (flag106)
							{
								break;
							}
							bool flag107 = num81 < middles3.Length;
							object obj231 = !flag107;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num4 = num145;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+20]");
							num25 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							num29 = 0f;
							num9 = (int)vector7;
							num32 = num2;
							num33 = num;
							if (obj231 != null)
							{
								goto end_IL_5271;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+20]");
							double num154 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3201 @ X9_v39+20]");
							double num155 = num154 + 0.0;
							object obj232 = num81 * 12;
							object obj233 = (object)s.middles + obj232;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+28]");
							float num156 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3201 @ X9_v39+28]");
							float num157 = num156 + 0f;
							float num158 = 0f - num2;
							object obj234 = obj166;
							double num159 = num155 * 191.0;
							double num160 = (double)num157 * -0.5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3385 @ X8_v96+20]");
							double num161 = 0.0 + num159;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3385 @ X8_v96+28]");
							double num162 = 0.0 + num160;
							float num163 = num111 * (float)num161;
							float num164 = num2 * (float)num162;
							float num165 = 0f - num166;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
							float num167 = num164 + num163;
							float num168 = 0f - num111;
							num123 = ((!(num167 < 0f)) ? num2 : num158);
							num103 = ((!(num167 < 0f)) ? num166 : num165);
							num118 = ((!(num167 < 0f)) ? num111 : num168);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3389 @ X0_v103+E4]");
							bool flag108 = (nint)0 == 0;
							object obj235 = !flag108;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3201 @ X9_v39+20]");
							num110 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+28]");
							float num169 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+20]");
							float num170 = 0f;
							if (obj235 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3201 @ X9_v39+20]");
								num110 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+28]");
								num169 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+20]");
								num170 = 0f;
							}
							float num171 = num136 * (float)obj236;
							float num172 = num137 * thick;
							float num173 = num141 * (float)obj236;
							float num174 = num142 * thick;
							float num175 = num170 - num171;
							num119 = num169 - num172;
							float num176 = num110 - num173;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3201 @ X9_v39+28]");
							num121 = 0f - num174;
							int num177 = _003CBone_003Eg__Put_007C60_0((Vector3)(&obj53), vector7, num170, num178, ref reference2);
							Vector3 face = vector7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3201 @ X9_v39+20]");
							int num179 = _003CBone_003Eg__Put_007C60_0((Vector3)(&obj53), face, 0f, byBreak, ref reference2);
							int num180 = _003CBone_003Eg__Put_007C60_0((Vector3)(&obj53), vector7, num176, num178, ref reference2);
							int num181 = _003CBone_003Eg__Put_007C60_0((Vector3)(&obj53), vector7, num175, num178, ref reference2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+10]");
							object obj237 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
							object obj238 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
							object obj239 = (nint)0 + (nint)1;
							object obj240 = obj238;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+10]");
							flag62 = (nint)0 == 0;
							num3 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num4 = num123;
							num26 = 1.0;
							num28 = 1.0;
							num6 = num103;
							num30 = num118;
							num8 = num119;
							num9 = (int)vector7;
							num2 = num178;
							num = num175;
							if (flag62)
							{
								break;
							}
							float num182 = num121 - num169;
							float num183 = num176;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+20]");
							float num184 = num183 - 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
							nint num185 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3724 @ X8_v103+18]");
							bool flag109 = num185 < 0;
							object obj241 = !flag109;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							double num186 = num27 * (double)num178;
							double num187 = num27 * (double)num184;
							float num188 = (float)obj242 * num182;
							float num189 = num145 * num182;
							num30 = num145 * num118;
							float num190 = num188 - (float)num186;
							double num191 = num187 - (double)num189;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							float num192 = num190 * num118;
							double num193 = num191 * (double)num103;
							num8 = num30 - num189;
							num = num192 + (float)num193;
							num2 = num123 * num8;
							float num194 = num2 + num;
							int num195;
							if (obj241 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj243 = (nint)0 + (nint)1;
								object obj244 = obj237;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj245 = obj244 + 0;
								bool flag110 = num194 < 0f;
								bool flag111 = num194 == 0f;
								object obj246 = num194 ^ num194;
								object obj247 = num194 & obj246;
								bool flag112 = (nint)obj247 < 0;
								bool flag113 = flag110 == flag112;
								object obj248 = !flag111;
								object obj249 = flag113 & obj248;
								object obj250 = ~obj249;
								num195 = ((obj250 != null) ? num180 : num179);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj251 = (nint)0 + (nint)1;
								num95 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
								list10 = (List<int>)num181;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3168 @ X9_v60+20]");
								object obj252 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3516 @ X8_v119+A8]");
								object obj253 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3518 @ X8_v120+70]");
								num95 = 0;
								list.AddWithResize(num177);
								bool flag114 = num194 < 0f;
								bool flag115 = num194 == 0f;
								object obj254 = num194 ^ num194;
								object obj255 = num194 & obj254;
								bool flag116 = (nint)obj255 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+10]");
								obj237 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
								object obj256 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj257 = (nint)0 + (nint)1;
								obj240 = obj256;
								bool flag117 = flag114 == flag116;
								object obj258 = !flag115;
								object obj259 = flag117 & obj258;
								object obj260 = ~obj259;
								num195 = ((obj260 != null) ? num180 : num179);
								flag62 = obj237 == null;
								list10 = list;
								num3 = num95;
								num4 = num145;
								num26 = 1.0;
								num28 = num27;
								num6 = (float)num186;
								num9 = num195;
								if (flag62)
								{
									break;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
							nint num196 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3724 @ X8_v103+18]");
							bool flag118 = num196 < 0;
							object obj261 = !flag118;
							int num197;
							if (obj261 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj262 = (nint)0 + (nint)1;
								object obj263 = obj237;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj264 = obj263 + 0;
								bool flag119 = num194 < 0f;
								bool flag120 = num194 == 0f;
								object obj265 = num194 ^ num194;
								object obj266 = num194 & obj265;
								bool flag121 = (nint)obj266 < 0;
								bool flag122 = flag119 == flag121;
								object obj267 = !flag120;
								object obj268 = flag122 & obj267;
								object obj269 = ~obj268;
								num197 = ((obj269 != null) ? num179 : num180);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj270 = (nint)0 + (nint)1;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3168 @ X9_v60+20]");
								object obj271 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3575 @ X8_v116+A8]");
								object obj272 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3576 @ X8_v117+70]");
								num95 = 0;
								list.AddWithResize(num195);
								bool flag123 = num194 < 0f;
								bool flag124 = num194 == 0f;
								object obj273 = num194 ^ num194;
								object obj274 = num194 & obj273;
								bool flag125 = (nint)obj274 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+10]");
								obj237 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
								object obj275 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj276 = (nint)0 + (nint)1;
								obj240 = obj275;
								bool flag126 = flag123 == flag125;
								object obj277 = !flag124;
								object obj278 = flag126 & obj277;
								object obj279 = ~obj278;
								num197 = ((obj279 != null) ? num179 : num180);
								flag62 = obj237 == null;
								list10 = list;
								num3 = num95;
								num4 = num145;
								num26 = 1.0;
								num28 = num27;
								num6 = (float)num186;
								num9 = num197;
								if (flag62)
								{
									break;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
							obj164 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
							nint num198 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3724 @ X8_v103+18]");
							bool flag127 = num198 < 0;
							object obj280 = !flag127;
							if (obj280 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj281 = (nint)0 + (nint)1;
								object obj282 = obj237;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj283 = obj282 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj284 = (nint)0 + (nint)1;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3168 @ X9_v60+20]");
								object obj285 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3610 @ X8_v113+A8]");
								object obj286 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3611 @ X8_v114+70]");
								num95 = 0;
								list.AddWithResize(num197);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+10]");
								obj237 = 0;
								obj240 = obj164;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj287 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+10]");
								flag62 = (nint)0 == 0;
								list10 = list;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3611 @ X8_v114+70]");
								num3 = 0;
								num4 = num145;
								num26 = 1.0;
								num28 = num27;
								num6 = (float)num186;
								num9 = num197;
								if (flag62)
								{
									break;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
							nint num199 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3724 @ X8_v103+18]");
							bool flag128 = num199 < 0;
							object obj288 = !flag128;
							int num200;
							if (obj288 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj289 = (nint)0 + (nint)1;
								object obj290 = obj237;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj291 = obj290 + 0;
								bool flag129 = num194 < 0f;
								bool flag130 = num194 == 0f;
								object obj292 = num194 ^ num194;
								object obj293 = num194 & obj292;
								bool flag131 = (nint)obj293 < 0;
								bool flag132 = flag129 == flag131;
								object obj294 = !flag130;
								object obj295 = flag132 & obj294;
								object obj296 = ~obj295;
								num200 = ((obj296 != null) ? num181 : num180);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj297 = (nint)0 + (nint)1;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3168 @ X9_v60+20]");
								object obj298 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3646 @ X8_v110+A8]");
								object obj299 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3648 @ X8_v111+70]");
								num95 = 0;
								list.AddWithResize(num177);
								bool flag133 = num194 < 0f;
								bool flag134 = num194 == 0f;
								object obj300 = num194 ^ num194;
								object obj301 = num194 & obj300;
								bool flag135 = (nint)obj301 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+10]");
								obj237 = 0;
								obj240 = obj164;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj302 = (nint)0 + (nint)1;
								bool flag136 = flag133 == flag135;
								object obj303 = !flag134;
								object obj304 = flag136 & obj303;
								object obj305 = ~obj304;
								num200 = ((obj305 != null) ? num181 : num180);
								flag62 = obj237 == null;
								list10 = list;
								num3 = num95;
								num4 = num145;
								num26 = 1.0;
								num28 = num27;
								num6 = (float)num186;
								num9 = num200;
								if (flag62)
								{
									break;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
							nint num201 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3724 @ X8_v103+18]");
							bool flag137 = num201 < 0;
							object obj306 = !flag137;
							if (obj306 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj307 = (nint)0 + (nint)1;
								object obj308 = obj237;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj309 = obj308 + 0;
								bool flag138 = num194 < 0f;
								bool flag139 = num194 == 0f;
								object obj310 = num194 ^ num194;
								object obj311 = num194 & obj310;
								bool flag140 = (nint)obj311 < 0;
								bool flag141 = flag138 == flag140;
								obj162 = !flag139;
								object obj312 = flag141 & obj162;
								flag84 = (byte)(int)(~obj312) != 0;
								num100 = (flag84 ? num180 : num181);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj313 = (nint)0 + (nint)1;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3168 @ X9_v60+20]");
								object obj314 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3703 @ X8_v107+A8]");
								object obj315 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3704 @ X8_v108+70]");
								num95 = 0;
								list.AddWithResize(num200);
								bool flag142 = num194 < 0f;
								bool flag143 = num194 == 0f;
								object obj316 = num194 ^ num194;
								object obj317 = num194 & obj316;
								bool flag144 = (nint)obj317 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+10]");
								obj237 = 0;
								obj240 = obj164;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj318 = (nint)0 + (nint)1;
								bool flag145 = flag142 == flag144;
								obj162 = !flag143;
								object obj319 = flag145 & obj162;
								flag84 = (byte)(int)(~obj319) != 0;
								num100 = (flag84 ? num180 : num181);
								flag62 = obj237 == null;
								list10 = list;
								num3 = num95;
								num4 = num145;
								num26 = 1.0;
								num28 = num27;
								num6 = (float)num186;
								num9 = num100;
								if (flag62)
								{
									break;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3724 @ X8_v103+18]");
							obj165 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
							nint num202 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3724 @ X8_v103+18]");
							bool flag146 = num202 < 0;
							object obj320 = !flag146;
							if (obj320 == null)
							{
								object obj321 = obj237;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj322 = obj321 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2639 @ X0_v41 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj323 = (nint)0 + (nint)1;
								num4 = num145;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+20]");
								num112 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3201 @ X9_v39+20]");
								num113 = 0f;
								num114 = num27;
								num115 = num145;
								num116 = num175;
								num117 = 0.0;
								num120 = num181;
								num26 = 1.0;
								num122 = num169;
								num28 = num27;
								num6 = (float)num186;
								num124 = num176;
								num125 = num177;
								num126 = num194;
								num81 = num180;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3168 @ X9_v60+20]");
								object obj324 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3726 @ X8_v104+A8]");
								object obj325 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3174 @ X8_v105+70]");
								num95 = 0;
								list.AddWithResize(num100);
								num4 = num145;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3199 @ X8_v66+20]");
								num112 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3201 @ X9_v39+20]");
								num113 = 0f;
								num114 = num27;
								num115 = num145;
								num116 = num175;
								num117 = 0.0;
								num120 = num181;
								num26 = 1.0;
								num122 = num169;
								num28 = num27;
								num6 = (float)num186;
								num124 = num176;
								num125 = num177;
								num126 = num194;
								list10 = list;
								num81 = num180;
							}
						}
					}
					array12 = (Vector4[])(array13 + 1);
					num101 = (int)(num127 + 4294967296L);
					bool flag147 = (nint)array12 != 3;
					flag42 = flag84;
					obj71 = obj162;
					obj68 = obj163;
					num96 = num4;
					num16 = num112;
					num18 = num113;
					obj101 = obj164;
					num20 = num114;
					num22 = num115;
					num24 = num116;
					num97 = num117;
					num37 = num118;
					num36 = num119;
					num80 = num120;
					num57 = num121;
					num25 = num26;
					num58 = num122;
					num59 = num103;
					num27 = num28;
					num98 = num6;
					num29 = num30;
					num99 = num8;
					num60 = num123;
					num75 = num124;
					num82 = num125;
					obj35 = obj165;
					num76 = num126;
					num32 = num2;
					num33 = num;
					list9 = list10;
					obj100 = obj166;
					reference2 = ref *(GillaSawHits._003C_003Ec__DisplayClass60_0*)num95;
					array13 = array12;
					vector7 = (Vector3)num100;
					num127 = num101;
					if (flag147)
					{
						continue;
					}
					goto IL_4190;
				}
				goto IL_44ed;
				continue;
				end_IL_5271:
				break;
			}
			goto IL_44b7;
		}
		goto IL_44ed;
	}

	public unsafe static Mesh Trim(Mesh whole, int sign, int seed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_0039: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj = 0;
		Along middle = Along.Middle;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Mesh whole2 = default;
		object obj4 = default;
		return Trim(whole2, sign, seed, (Along)(&obj4));
	}

	public unsafe static Mesh Trim(Mesh whole, int sign, int seed, Along along)
	{
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0073: Expected I4, but got Obj
		//IL_0091: Expected Obj, but got I4
		//IL_00c2: Expected I4, but got Obj
		//IL_00cb: Expected Obj, but got I4
		//IL_00d5: Expected VT, but got I4
		//IL_0ae2: Expected Obj, but got I4
		//IL_093a: Expected Obj, but got I
		//IL_0952: Expected Obj, but got I
		//IL_0974: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_09c8: Expected Obj, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_01a0: Expected Obj, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I4
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0219: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_029d: Expected Obj, but got I
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_0313: Expected Ref, but got VT
		//IL_0336: Invalid comparison between F4 and I
		//IL_034c: Expected I4, but got VT
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Expected Obj, but got Unknown
		//IL_0a68: Expected VT, but got I4
		//IL_036a: Invalid comparison between F4 and I
		//IL_04c6: Expected Obj, but got I4
		//IL_03c1: Expected Obj, but got I
		//IL_03eb: Expected Obj, but got I4
		//IL_0419: Expected VT, but got I4
		//IL_0427: Expected Obj, but got I4
		//IL_0437: Invalid comparison between F4 and I
		//IL_0465: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I
		//IL_0497: Expected Obj, but got I4
		//IL_0501: Expected Obj, but got I
		//IL_0511: Expected Obj, but got I
		//IL_0527: Expected Obj, but got I
		//IL_0582: Expected Obj, but got I4
		//IL_05ea: Expected Obj, but got I
		//IL_05fa: Expected Obj, but got I
		//IL_0629: Expected Obj, but got I4
		//IL_0a8f: Expected Obj, but got I4
		//IL_05ad: Expected Obj, but got I
		//IL_05c3: Expected Obj, but got I
		//IL_063e: Expected Obj, but got I
		//IL_064e: Expected Obj, but got I
		//IL_0664: Expected Obj, but got I
		//IL_06bf: Expected Obj, but got I4
		//IL_071f: Expected Obj, but got I
		//IL_072f: Expected Obj, but got I
		//IL_074c: Expected I4, but got Obj
		//IL_0756: Expected Obj, but got I4
		//IL_0ab6: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I
		//IL_0700: Expected Obj, but got I
		//IL_076b: Expected Obj, but got I
		//IL_0773: Expected I4, but got Obj
		//IL_0783: Expected Obj, but got I
		//IL_0799: Expected Obj, but got I
		//IL_07f4: Expected Obj, but got I4
		//IL_0884: Expected Obj, but got I
		//IL_0894: Expected Obj, but got I
		//IL_08b1: Expected I4, but got Obj
		//IL_08bb: Expected Obj, but got I4
		//IL_081f: Expected Obj, but got I
		//IL_0835: Expected Obj, but got I
		List<int> list = default;
		if ((object)whole != null)
		{
			Vector3[] vertices = whole.vertices;
			int[] triangles = whole.triangles;
			if (triangles != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				int num = (int)obj2;
				list._002Ector(triangles.Length);
				object obj3 = triangles.Length;
				bool flag = triangles.Length < 1;
				int num2 = triangles.Length;
				if (flag)
				{
					goto IL_08e8;
				}
				int num3 = (int)obj2;
				object obj4 = 0;
				Vector3 vector = (Vector3)triangles.Length;
				object obj30 = default;
				double num11 = default;
				object obj32 = default;
				while (true)
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
					object obj5 = !flag2;
					if (obj5 == null)
					{
						if (vertices == null)
						{
							break;
						}
						object obj6 = (object)triangles + obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X20_v7+20]");
						bool flag3 = (nint)0 < (nint)vertices.Length;
						object obj7 = !flag3;
						if (obj7 == null)
						{
							object obj8 = obj4 + 1;
							bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
							object obj9 = !flag4;
							if (obj9 == null)
							{
								object obj10 = (object)triangles + obj8;
								object obj11 = obj10 + 32;
								bool flag5 = (nint)obj11 < vertices.Length;
								object obj12 = !flag5;
								if (obj12 == null)
								{
									object obj13 = obj4 + 2;
									bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
									object obj14 = !flag6;
									if (obj14 == null)
									{
										object obj15 = (object)triangles + obj13;
										object obj16 = obj15 + 32;
										bool flag7 = (nint)obj16 < vertices.Length;
										object obj17 = !flag7;
										if (obj17 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X20_v7+20]");
											object obj18 = (nint)0 * (nint)12;
											object obj19 = (object)vertices + obj18;
											object obj20 = obj11 * 12;
											object obj21 = (object)vertices + obj20;
											object obj22 = obj16 * 12;
											object obj23 = (object)vertices + obj22;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v19+20]");
											nint num4 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X9_v7+20]");
											object obj24 = num4 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X10_v7+20]");
											object obj25 = obj24 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v19+28]");
											nint num5 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X9_v7+28]");
											object obj26 = num5 + 0;
											object obj27 = obj25 / 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X10_v7+28]");
											object obj28 = obj26 + 0;
											double num6 = (double)obj28 / 3.0;
											Vector3 vector2 = ((Along*)along)->In(vector);
											float num7 = (float)obj27 * (float)sign;
											float num8 = num7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAA8]");
											bool flag8 = num8 < 0f;
											object obj29 = obj30;
											num2 = (int)vector;
											if (flag8)
											{
												goto IL_0a3c;
											}
											float num9 = num7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABC4]");
											bool flag9 = !(num9 < 0f);
											double num10 = num11;
											object obj31 = obj32;
											double num12 = num6;
											object obj33 = obj30;
											float num13 = num7;
											object obj34 = obj3;
											if (!flag9)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
												object obj35 = 0;
												object obj36 = obj35;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X0_v31+E4]");
												bool flag10 = (nint)0 == 0;
												object obj37 = !flag10;
												if (obj37 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												num13 = Into((Vector3)sign, seed, num3);
												obj34 = triangles.Length;
												float num14 = num13;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
												bool flag11 = num14 < 0f;
												num10 = num6;
												obj31 = obj30;
												num12 = num6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
												obj33 = 0;
												num11 = num6;
												obj32 = obj30;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
												obj29 = 0;
												num7 = num13;
												obj3 = triangles.Length;
												num2 = seed;
												if (flag11)
												{
													goto IL_0a3c;
												}
											}
											bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34);
											object obj38 = !flag12;
											if (obj38 == null)
											{
												if (list == null)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+10]");
												object obj39 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
												object obj40 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+1C]");
												object obj41 = (nint)0 + (nint)1;
												object obj42 = obj40;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+10]");
												if ((nint)0 == 0)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
												nint num15 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v22+18]");
												bool flag13 = num15 < 0;
												object obj43 = !flag13;
												if (obj43 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+10]");
													nint num16 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
													object obj44 = num16 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
													object obj45 = (nint)0 + (nint)1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X20_v7+20]");
													_ = 0;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X9_v11+20]");
													object obj46 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v33+A8]");
													object obj47 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v34+70]");
													num3 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X20_v7+20]");
													list.AddWithResize(0);
													obj34 = triangles.Length;
												}
												bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34);
												object obj48 = !flag14;
												if (obj48 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+10]");
													object obj49 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
													object obj50 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+1C]");
													object obj51 = (nint)0 + (nint)1;
													object obj52 = obj50;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+10]");
													if ((nint)0 == 0)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
													nint num17 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v24+18]");
													bool flag15 = num17 < 0;
													object obj53 = !flag15;
													if (obj53 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+10]");
														nint num18 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
														object obj54 = num18 + 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
														object obj55 = (nint)0 + (nint)1;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X9_v15+20]");
														object obj56 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v30+A8]");
														object obj57 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v31+70]");
														num3 = 0;
														list.AddWithResize((int)obj11);
														obj34 = triangles.Length;
													}
													bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34);
													object obj58 = !flag16;
													if (obj58 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+10]");
														object obj59 = 0;
														num2 = (int)obj16;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
														object obj60 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+1C]");
														object obj61 = (nint)0 + (nint)1;
														object obj62 = obj60;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+10]");
														if ((nint)0 == 0)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
														nint num19 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v26+18]");
														bool flag17 = num19 < 0;
														object obj63 = !flag17;
														if (obj63 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+10]");
															nint num20 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
															object obj64 = num20 + 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
															object obj65 = (nint)0 + (nint)1;
															num11 = num10;
															obj32 = obj31;
															num6 = num12;
															obj29 = obj33;
															num7 = num13;
															obj3 = obj34;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X9_v19+20]");
															object obj66 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v27+A8]");
															object obj67 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v28+70]");
															num3 = 0;
															list.AddWithResize((int)obj16);
															obj3 = triangles.Length;
															num11 = num10;
															obj32 = obj31;
															num6 = num12;
															obj29 = obj33;
															num7 = num13;
														}
														goto IL_0a3c;
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
					break;
					IL_0a3c:
					obj4 += 3;
					bool flag18 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
					num = num3;
					vector = (Vector3)num2;
					if (flag18)
					{
						continue;
					}
					goto IL_08e8;
				}
			}
		}
		goto IL_0a11;
		IL_08e8:
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v9 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)0 == 0)
			{
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj68 = 0;
			object obj69 = obj68;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BB8]");
			object obj70 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v13+E4]");
			bool flag19 = (nint)0 == 0;
			object obj71 = !flag19;
			if (obj71 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDA38");
			UnityEngine.Object obj72 = default;
			if ((object)obj72 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CD8]");
				object name = 0;
				obj72.name = (string)name;
				((Mesh)obj72).SetTriangles(list, 0);
				return (Mesh)obj72;
			}
		}
		goto IL_0a11;
		IL_0a11:
		return (Mesh)(object)new NullReferenceException();
	}

	static GillaRip()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CF0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		ConcurrentQueue<System.__Canon> concurrentQueue = default;
		concurrentQueue._002Ector();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+A0]");
		object obj6 = 0;
		obj6 = concurrentQueue;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<(System.__Canon, int, int), System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+A0]");
		object obj9 = (nint)0 + (nint)8;
		obj9 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D08]");
		object name = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D10]");
		object name2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v15+A0]");
		object obj14 = 0;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X9_v1+A0]");
		object obj16 = (nint)0 + (nint)16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v11+30]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker((string)name, 1, (MarkerFlags)0, 0);
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v12+A0]");
		object obj18 = 0;
		IntPtr intPtr2 = ProfilerUnsafeUtility.CreateMarker((string)name2, 1, (MarkerFlags)0, 0);
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v14+A0]");
		object obj20 = 0;
	}

	internal static Vector2Int _003CBowl_003Eg__SquareOf_007C47_3(Vector2 p)
	{
		//IL_0083: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_006e: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
		object obj7 = default;
		object obj6 = obj7 / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
		object obj9 = default;
		object obj8 = obj9 / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		return (Vector2Int)(obj8 | obj6);
	}

	internal static float _003CEarClip_003Eg__Turn_007C55_0(Vector2 a, Vector2 b, Vector2 d)
	{
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		object obj8 = default;
		object obj7 = obj8 - obj6;
		object obj10 = default;
		object obj9 = obj10 - obj3;
		object obj11 = obj * obj4;
		object obj12 = obj7 * obj9;
		return (float)obj11 - (float)obj12;
	}

	internal static float _003CFlip_003Eg__Across_007C56_0(int a, int b, int d, ref _003C_003Ec__DisplayClass56_0 P_3)
	{
		//IL_016b: Expected Obj, but got VT
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got VT
		//IL_00ac: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got VT
		//IL_00d7: Expected Obj, but got I
		object obj = P_3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+10]");
		Vector3 vector = ((List<Vector3>)0).get_Item(a);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = P_3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v6+10]");
		Vector3 vector2 = ((List<Vector3>)0).get_Item(b);
		object obj7 = P_3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v7+10]");
		Vector3 vector3 = ((List<Vector3>)0).get_Item(d);
		object obj9 = default;
		object obj8 = obj9 - obj9;
		object obj11 = default;
		object obj10 = obj11 - obj11;
		object obj12 = obj9 - obj9;
		object obj13 = obj11 - obj11;
		object obj14 = obj8 * obj12;
		object obj15 = obj10 * obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		object obj16 = obj14 + obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		return (float)obj16 / (float)obj15;
	}

	internal static float _003CFlip_003Eg__Turn_007C56_1(Vector2 a, Vector2 b, Vector2 d)
	{
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		object obj8 = default;
		object obj7 = obj8 - obj6;
		object obj10 = default;
		object obj9 = obj10 - obj3;
		object obj11 = obj * obj4;
		object obj12 = obj7 * obj9;
		return (float)obj11 - (float)obj12;
	}

	internal unsafe static int _003CBone_003Eg__Put_007C60_0(Vector3 at, Vector3 face, float isBreak, float byBreak, ref GillaSawHits._003C_003Ec__DisplayClass60_0 P_4)
	{
		//IL_09fb: Expected Obj, but got F4
		//IL_0a09: Invalid comparison between F4 and I4
		//IL_09ee: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_012e: Expected VT, but got I
		//IL_0148: Expected VT, but got I
		//IL_0148: Expected Obj, but got F4
		//IL_015a: Expected Obj, but got F4
		//IL_0168: Invalid comparison between F4 and I4
		//IL_00ba: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		//IL_0295: Expected VT, but got I
		//IL_02af: Expected VT, but got I
		//IL_02af: Expected Obj, but got F4
		//IL_02c4: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I
		//IL_0327: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I
		//IL_0407: Expected VT, but got I
		//IL_0424: Expected VT, but got I
		//IL_0424: Expected Obj, but got I
		//IL_0439: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I
		//IL_03bb: Expected Obj, but got I
		//IL_046e: Expected Obj, but got I
		//IL_0484: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I
		//IL_04d6: Expected Obj, but got I
		//IL_04ff: Expected Obj, but got I4
		//IL_0596: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I
		//IL_05c3: Expected VT, but got I
		//IL_05c3: Expected Obj, but got I
		//IL_05d3: Expected VT, but got I
		//IL_05e8: Expected Obj, but got I
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected VT, but got Unknown
		//IL_0603: Expected Ref, but got VT
		//IL_0631: Expected Obj, but got I4
		//IL_052a: Expected Obj, but got I
		//IL_0540: Expected Obj, but got I
		//IL_066f: Expected VT, but got I
		//IL_0693: Invalid comparison between F4 and I4
		//IL_06a2: Expected F8, but got I4
		//IL_06fe: Expected Obj, but got I
		//IL_071c: Expected Obj, but got I
		//IL_0786: Expected Obj, but got I4
		//IL_07ec: Expected Obj, but got I
		//IL_07fc: Expected Obj, but got I
		//IL_0819: Expected VT, but got I
		//IL_0819: Expected Obj, but got I
		//IL_082e: Expected Obj, but got I
		//IL_07aa: Expected Obj, but got I
		//IL_07c7: Expected Obj, but got I
		//IL_0863: Expected Obj, but got I
		//IL_0881: Expected Obj, but got I
		//IL_08d4: Expected Obj, but got I4
		//IL_0964: Expected Obj, but got I
		//IL_0974: Expected Obj, but got I
		//IL_0991: Expected VT, but got I
		//IL_0991: Expected Obj, but got I
		//IL_09b1: Invalid comparison between F4 and I4
		//IL_08f8: Expected Obj, but got I
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected Obj, but got Unknown
		//IL_0923: Expected Obj, but got I
		List<Vector3> list = (List<Vector3>)at.x;
		if (at.x != 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			object obj2 = 0;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
			object obj4 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v4+18]");
				bool flag = num < 0;
				object obj5 = !flag;
				Vector3 vector = default;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj6 = (nint)0 * (nint)12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj7 = 0 + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj8 = (nint)0 + (nint)1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v2+20]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v34+A8]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v35+70]");
					vector = (Vector3)0;
					float x = at.x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v35+70]");
					((List<Vector3>)x).AddWithResize((Vector3)0);
				}
				List<Vector3> list2 = (List<Vector3>)at.z;
				if (at.z != 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj11 = 0;
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj13 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v6+18]");
						bool flag2 = num2 < 0;
						object obj14 = !flag2;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj15 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj16 = 0 + obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj17 = (nint)0 + (nint)1;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X9_v4+20]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v31+A8]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v32+70]");
							vector = (Vector3)0;
							float z = at.z;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v32+70]");
							((List<Vector3>)z).AddWithResize((Vector3)0);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+10]");
						List<Vector2> list3 = (List<Vector2>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69C0]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v6 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
							object obj21 = 0;
							object obj22 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v6 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
							object obj23 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v6 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v6 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v8+18]");
								bool flag3 = num3 < 0;
								object obj24 = !flag3;
								Vector2 vector2;
								if (obj24 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v6 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
									nint num4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v6 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
									object obj25 = num4 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v6 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
									object obj26 = (nint)0 + (nint)1;
									vector2 = vector;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X9_v6+20]");
									object obj27 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v28+A8]");
									object obj28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v29+70]");
									vector2 = (Vector2)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+10]");
									nint num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v29+70]");
									((List<Vector2>)num5).AddWithResize((Vector2)0);
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+18]");
								List<Vector4> list4 = (List<Vector4>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A58]");
									object obj29 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v7 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
									object obj30 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v7 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
									object obj31 = 0;
									object obj32 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v7 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
										object obj33 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v7 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
										nint num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v10+18]");
										bool flag4 = num6 < 0;
										object obj34 = !flag4;
										Vector3 p;
										if (obj34 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v7 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
											nint num7 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v7 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
											object obj35 = num7 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v7 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
											object obj36 = (nint)0 + (nint)1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+20]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+24]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+28]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+2C]");
											_ = 0;
											p = vector2;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v9+20]");
											object obj37 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v25+A8]");
											object obj38 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+18]");
											nint num8 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v26+70]");
											((List<Vector4>)num8).AddWithResize((Vector4)0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v26+70]");
											p = (Vector3)0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+30]");
										List<Vector2> list5 = (List<Vector2>)0;
										Along along = (Along)(at + 56);
										Vector3 vector3 = ((Along*)along)->In(p);
										object obj39 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v10+E4]");
										bool flag5 = (nint)0 == 0;
										object obj40 = !flag5;
										if (obj40 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+60]");
										nint num9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+64]");
										float num10 = Into((Vector3)num9, 0, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref P_4));
										float num11 = num10;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+68]");
										float num12 = num11 / 0f;
										bool flag6 = num12 < 0f;
										double num13 = 0.0;
										if (!flag6)
										{
											bool flag7 = !((double)num12 > 1.0);
											num13 = num12;
											if (!flag7)
											{
												num13 = 1.0;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+30]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X20_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
											object obj41 = 0;
											object obj42 = obj20;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X20_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
											object obj43 = (nint)0 + (nint)1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X20_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
											if ((nint)0 != 0)
											{
												double num14 = num13;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E8]");
												double num15 = num14 * 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X20_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
												nint num16 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v13+18]");
												bool flag8 = num16 < 0;
												object obj44 = !flag8;
												if (obj44 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X20_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
													object obj45 = (nint)0 + (nint)1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X20_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
													nint num17 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X20_v3 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
													object obj46 = num17 + 0;
													_ = 1056964608;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v11+20]");
													object obj47 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v22+A8]");
													object obj48 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+30]");
													nint num18 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v23+70]");
													((List<Vector2>)num18).AddWithResize((Vector2)0);
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+70]");
												List<Vector3> list6 = (List<Vector3>)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+70]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
													object obj49 = 0;
													object obj50 = obj;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
													object obj51 = (nint)0 + (nint)1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
														nint num19 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v15+18]");
														bool flag9 = num19 < 0;
														object obj52 = !flag9;
														if (obj52 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
															object obj53 = (nint)0 * (nint)12;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
															object obj54 = 0 + obj53;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v14 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
															object obj55 = (nint)0 + (nint)1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+78]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+7C]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+80]");
															_ = 0;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X9_v13+20]");
															object obj56 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v19+A8]");
															object obj57 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X0 (UnityEngine.Vector3)+70]");
															nint num20 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v20+70]");
															((List<Vector3>)num20).AddWithResize((Vector3)0);
														}
														float x2 = at.x;
														if (at.x != 0f)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v17 (System.Single)+18]");
															return (int)(-1);
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
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}
}
