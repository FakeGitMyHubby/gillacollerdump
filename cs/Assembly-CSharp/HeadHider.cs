using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class HeadHider
{
	public static readonly string[] HeadBones;

	public unsafe static Mesh BuildCapped(Mesh src, Transform[] bones, string[] cut, float threshold)
	{
		//IL_1c02: Expected Obj, but got I
		//IL_1c2c: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I8
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0187: Expected I, but got Obj
		//IL_1e43: Expected Obj, but got I4
		//IL_21ab: Expected Obj, but got I
		//IL_21bb: Expected Obj, but got I
		//IL_21d8: Expected Obj, but got I
		//IL_07db: Expected Obj, but got I
		//IL_07ec: Expected Obj, but got I
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected Obj, but got I4
		//IL_1b52: Expected Obj, but got I4
		//IL_2167: Expected Obj, but got I
		//IL_2181: Expected Obj, but got I
		//IL_1c64: Expected Obj, but got I4
		//IL_082d: Expected Obj, but got I
		//IL_0847: Expected Obj, but got I
		//IL_01ea: Invalid comparison between F8 and I4
		//IL_0899: Expected I4, but got Obj
		//IL_08a1: Expected I8, but got Obj
		//IL_1cc8: Expected Obj, but got I4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected F4, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected F4, but got Unknown
		//IL_0b5e: Expected Obj, but got I
		//IL_0b78: Expected Obj, but got I
		//IL_1c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c80: Expected Obj, but got Unknown
		//IL_1c9a: Expected Obj, but got I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected F4, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected F4, but got Unknown
		//IL_0b98: Expected I4, but got Obj
		//IL_08c0: Expected Obj, but got I4
		//IL_0bc5: Expected I8, but got F8
		//IL_0bcd: Expected Obj, but got I4
		//IL_1f76: Expected Obj, but got I4
		//IL_1d00: Expected Obj, but got I4
		//IL_10db: Expected Obj, but got I
		//IL_10f5: Expected Obj, but got I
		//IL_1f2f: Expected I4, but got Obj
		//IL_1f5f: Expected Obj, but got I4
		//IL_0351: Invalid comparison between F8 and I4
		//IL_0bec: Expected Obj, but got I4
		//IL_206e: Expected Obj, but got I4
		//IL_08e6: Expected Obj, but got I4
		//IL_0906: Expected Obj, but got I4
		//IL_1138: Expected Obj, but got I
		//IL_1155: Expected Obj, but got I
		//IL_201c: Expected I4, but got Obj
		//IL_202c: Expected Obj, but got I
		//IL_1d64: Expected Obj, but got I4
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected F4, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected F4, but got Unknown
		//IL_1174: Expected Obj, but got I
		//IL_1199: Expected Obj, but got I
		//IL_11a9: Expected Obj, but got I
		//IL_11ba: Expected Obj, but got I
		//IL_0c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Expected Obj, but got Unknown
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected Obj, but got Unknown
		//IL_1d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1c: Expected Obj, but got Unknown
		//IL_1d36: Expected Obj, but got I4
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected F4, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected F4, but got Unknown
		//IL_1f88: Expected I4, but got Obj
		//IL_1fb8: Expected Obj, but got I4
		//IL_0bfa: Expected Obj, but got I4
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Expected Obj, but got Unknown
		//IL_11e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fd: Expected F8, but got I8
		//IL_1e5e: Expected I4, but got Obj
		//IL_1e90: Expected Obj, but got I4
		//IL_1ea8: Expected Obj, but got I4
		//IL_095a: Expected Obj, but got I4
		//IL_1d9c: Expected Obj, but got I4
		//IL_2098: Expected Obj, but got I
		//IL_20a9: Expected Obj, but got I
		//IL_0c33: Expected Obj, but got I4
		//IL_0c53: Expected Obj, but got I4
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_222f: Expected Obj, but got I
		//IL_2244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected Obj, but got I
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected Obj, but got Unknown
		//IL_09b9: Expected Obj, but got I4
		//IL_051f: Invalid comparison between Obj and F8
		//IL_0c8a: Expected Obj, but got I4
		//IL_0caa: Expected Obj, but got I4
		//IL_09fd: Expected Obj, but got I4
		//IL_04d2: Invalid comparison between Obj and F8
		//IL_1a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected F4, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected Obj, but got I4
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected Obj, but got Unknown
		//IL_0cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Expected Obj, but got Unknown
		//IL_0cea: Expected Obj, but got I
		//IL_0cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected Obj, but got Unknown
		//IL_0d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0e: Expected Obj, but got Unknown
		//IL_0d30: Expected Obj, but got I4
		//IL_0a28: Expected F8, but got I
		//IL_0a45: Expected Obj, but got I
		//IL_0a71: Expected I8, but got I
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected I8, but got Unknown
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected Obj, but got Unknown
		//IL_0ad3: Expected Obj, but got I4
		//IL_1daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db8: Expected Obj, but got Unknown
		//IL_1dd2: Expected Obj, but got I4
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected F4, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6c: Expected Obj, but got I4
		//IL_0b07: Expected I8, but got I
		//IL_05dc: Expected VT, but got F8
		//IL_05ed: Expected Ref, but got F4
		//IL_060b: Expected Obj, but got I4
		//IL_061b: Expected Obj, but got F4
		//IL_0623: Expected Obj, but got VT
		//IL_1edb: Expected I, but got Obj
		//IL_0af2: Expected I8, but got F8
		//IL_0d87: Expected I8, but got Obj
		//IL_0d97: Expected Obj, but got I
		//IL_0dca: Expected I8, but got Obj
		//IL_0dd7: Expected I8, but got Obj
		//IL_0e14: Expected Obj, but got I4
		//IL_0641: Expected Obj, but got I
		//IL_065a: Expected I4, but got F4
		//IL_0672: Expected Obj, but got F4
		//IL_067a: Expected Obj, but got VT
		//IL_20f9: Expected Obj, but got I4
		//IL_2101: Expected Obj, but got I4
		//IL_0e40: Expected I8, but got Obj
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Expected Obj, but got Unknown
		//IL_0b38: Expected I, but got Obj
		//IL_06c5: Expected Obj, but got I4
		//IL_1fe7: Expected Obj, but got I
		//IL_2001: Expected I4, but got I8
		//IL_129f: Expected Obj, but got I
		//IL_12cf: Expected Obj, but got I4
		//IL_1064: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Expected Obj, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected Obj, but got Unknown
		//IL_0726: Expected Obj, but got I4
		//IL_0e66: Expected Obj, but got I4
		//IL_0e7e: Expected Obj, but got I8
		//IL_1b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1092: Unknown result type (might be due to invalid IL or missing references)
		//IL_1097: Expected Obj, but got Unknown
		//IL_14ec: Expected Obj, but got I
		//IL_1a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a14: Expected Obj, but got I4
		//IL_0eb5: Expected Obj, but got I4
		//IL_0ecd: Expected Obj, but got I8
		//IL_130a: Expected Obj, but got I
		//IL_0f0a: Expected Obj, but got I8
		//IL_1546: Expected Obj, but got I
		//IL_1342: Expected Obj, but got I
		//IL_136b: Expected Obj, but got I
		//IL_137b: Expected Obj, but got I
		//IL_1391: Expected Obj, but got I
		//IL_1399: Expected F8, but got Obj
		//IL_1a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3a: Expected Obj, but got I4
		//IL_0f20: Expected I, but got Obj
		//IL_0f31: Expected I4, but got Obj
		//IL_0f31: Expected I4, but got Obj
		//IL_0f52: Expected Obj, but got I4
		//IL_1a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7e: Expected Obj, but got I4
		//IL_13d3: Expected Obj, but got I
		//IL_13fd: Expected Obj, but got I4
		//IL_157d: Expected Obj, but got I
		//IL_1594: Expected Obj, but got I
		//IL_145f: Expected Obj, but got I
		//IL_146f: Expected Obj, but got I
		//IL_0f9f: Expected I, but got Obj
		//IL_1abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aca: Expected Obj, but got I4
		//IL_1428: Expected Obj, but got I
		//IL_15e8: Expected Obj, but got I4
		//IL_0fc5: Expected I, but got Obj
		//IL_0fd6: Expected I4, but got Obj
		//IL_0ff7: Expected Obj, but got I4
		//IL_100f: Expected Obj, but got I4
		//IL_1613: Expected Obj, but got I
		//IL_1629: Expected Obj, but got I
		//IL_1035: Expected I4, but got Obj
		//IL_103d: Expected I, but got Obj
		//IL_104e: Expected I4, but got Obj
		//IL_1056: Expected Obj, but got I4
		//IL_168b: Expected Obj, but got I
		//IL_16a2: Expected Obj, but got I
		//IL_1ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af0: Expected Obj, but got I4
		//IL_16f6: Expected Obj, but got I4
		//IL_1721: Expected Obj, but got I
		//IL_1737: Expected Obj, but got I
		//IL_17a7: Expected Obj, but got I
		//IL_17b7: Expected Obj, but got I
		//IL_17cd: Expected Obj, but got I
		//IL_1a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa4: Expected Obj, but got I4
		//IL_180f: Expected Obj, but got I
		//IL_1839: Expected Obj, but got I4
		//IL_1899: Expected Obj, but got I
		//IL_18a9: Expected Obj, but got I
		//IL_18b9: Expected Obj, but got I
		//IL_18f9: Invalid comparison between F8 and I
		//IL_1864: Expected Obj, but got I
		//IL_187a: Expected Obj, but got I
		//IL_1916: Unknown result type (might be due to invalid IL or missing references)
		//IL_191b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = default;
		Mesh mesh = BuildHeadless(src, bones, cut, num);
		bool flag2 = (object)src == null;
		string[] array = cut;
		Transform[] array2 = bones;
		object obj12 = default;
		nint num2;
		object obj15;
		double num4;
		string[] array3;
		Transform[] array4;
		float num7;
		double num16 = default;
		object obj16 = default;
		double num5 = default;
		nint num3 = default;
		if (!flag2)
		{
			Vector3[] vertices = src.vertices;
			bool flag3 = vertices == null;
			array = cut;
			array2 = null;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9DE0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9DC0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				array2 = (Transform[])obj6;
				Dictionary<Vector3Int, int> dictionary = default;
				dictionary._002Ector();
				bool flag4 = vertices.Length < 1;
				array = cut;
				if (flag4)
				{
					goto IL_0784;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9DB8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj8 = 0;
				object obj9 = vertices.Length & 0xFFFFFFFFL;
				object obj10 = vertices + 40;
				object obj11 = obj12 + 32;
				object obj14 = default;
				object obj13 = obj14;
				num2 = num3;
				obj15 = obj16;
				num4 = num5;
				nint num6 = unchecked((nint)null);
				array3 = cut;
				array4 = (Transform[])obj6;
				num7 = num;
				Enumerator<, > val = default;
				IntPtr intPtr = default;
				while (true)
				{
					bool flag5 = num6 < (nint)obj9;
					object obj17 = !flag5;
					if (obj17 != null)
					{
						break;
					}
					object obj18 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1057 @ X0_v144+E4]");
					bool flag6 = (nint)0 == 0;
					object obj19 = !flag6;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X29_v28-8]");
					double num8 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF9C]");
					double num9 = num8 * 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					float num10;
					if (num9 < 0.0)
					{
						if (num9 == -0.5)
						{
							num4 = (double)val + -1.0;
							num7 = (float)val;
							num10 = (float)val;
							goto IL_1c72;
						}
						double num11 = num9 + -0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
						num7 = (float)num11;
					}
					else
					{
						if (num9 == 0.5)
						{
							num4 = (double)val + 1.0;
							num7 = (float)val;
							num10 = (float)val;
							goto IL_1c72;
						}
						double num12 = num9 + 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						num7 = (float)num12;
					}
					goto IL_1cad;
					IL_1d49:
					bool flag7 = num6 < vertices.Length;
					object obj20 = !flag7;
					if (obj20 != null)
					{
						break;
					}
					object obj21 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ X0_v154+E4]");
					bool flag8 = (nint)0 == 0;
					object obj22 = !flag8;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj23 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF9C]");
					object obj24 = obj23 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					Enumerator<, > val2;
					if ((nint)obj24 < 0)
					{
						if (obj24 == (object)(-0.5))
						{
							num4 = (double)val + -1.0;
							num = (float)val;
							val2 = val;
							goto IL_1daa;
						}
						double num13 = (double)obj24 + -0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
						num = (float)num13;
					}
					else
					{
						if (obj24 == (object)0.5)
						{
							num4 = (double)val + 1.0;
							num = (float)val;
							val2 = val;
							goto IL_1daa;
						}
						double num14 = (double)obj24 + 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						num = (float)num14;
					}
					goto IL_1de5;
					IL_1c72:
					object obj25 = num10 & 1;
					bool flag9 = obj25 == null;
					obj13 = !flag9;
					num9 = ((obj13 != null) ? num4 : ((double)num7));
					goto IL_1cad;
					IL_1daa:
					object obj26 = val2 & 1;
					bool flag10 = obj26 == null;
					obj13 = !flag10;
					if (obj13 != null)
					{
						num = (float)num4;
					}
					goto IL_1de5;
					IL_1de5:
					bool flag11 = (object)dictionary == null;
					num3 = num2;
					obj16 = obj15;
					num5 = num4;
					array = array3;
					array2 = array4;
					double num15;
					if (!flag11)
					{
						obj16 = obj7;
						Vector3Int vector3Int = (Vector3Int)(num9 | num15);
						bool flag12 = dictionary.TryGetValue(vector3Int, out *(int*)num);
						bool flag13 = !flag12;
						object obj27 = !flag13;
						num3 = (nint)(&intPtr);
						array = (string[])num;
						array2 = (Transform[])vector3Int;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9DD8]");
							object obj28 = 0;
							obj16 = obj28;
							dictionary.set_Item(vector3Int, (int)num);
							intPtr = num6;
							num3 = num6;
							array = (string[])num;
							array2 = (Transform[])vector3Int;
						}
						bool flag14 = obj12 == null;
						num5 = num4;
						if (!flag14)
						{
							nint intPtr2 = num6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v22+18]");
							bool flag15 = intPtr2 < 0;
							object obj29 = !flag15;
							num2 = num3;
							obj15 = obj16;
							array3 = array;
							array4 = array2;
							num7 = num;
							if (obj29 != null)
							{
								break;
							}
							obj10 += 12;
							num6++;
							obj9 = vertices.Length;
							bool flag16 = num6 < vertices.Length;
							obj14 = obj13;
							num5 = num4;
							num16 = num15;
							num2 = num3;
							obj15 = obj16;
							array3 = array;
							array4 = array2;
							num7 = num;
							if (flag16)
							{
								continue;
							}
							goto IL_0784;
						}
					}
					goto IL_1bc0;
					IL_1d0e:
					float num17;
					object obj30 = num17 & 1;
					bool flag17 = obj30 == null;
					obj13 = !flag17;
					num15 = ((obj13 != null) ? num4 : ((double)num7));
					goto IL_1d49;
					IL_1cad:
					bool flag18 = num6 < vertices.Length;
					object obj31 = !flag18;
					if (obj31 != null)
					{
						break;
					}
					object obj32 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1416 @ X0_v149+E4]");
					bool flag19 = (nint)0 == 0;
					object obj33 = !flag19;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X29_v28-4]");
					double num18 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF9C]");
					num15 = num18 * 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					if (num15 < 0.0)
					{
						if (num15 == -0.5)
						{
							num4 = (double)val + -1.0;
							num7 = (float)val;
							num17 = (float)val;
							goto IL_1d0e;
						}
						double num19 = num15 + -0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
						num7 = (float)num19;
					}
					else
					{
						if (num15 == 0.5)
						{
							num4 = (double)val + 1.0;
							num7 = (float)val;
							num17 = (float)val;
							goto IL_1d0e;
						}
						double num20 = num15 + 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						num7 = (float)num20;
					}
					goto IL_1d49;
				}
				goto IL_1b82;
			}
		}
		goto IL_1bc0;
		IL_0b4e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6070]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6078]");
		object obj35 = 0;
		Dictionary<int, int> dictionary2 = default;
		dictionary2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		int num21 = (int)obj35;
		Dictionary<int, int> dictionary3 = default;
		dictionary3._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
		bool flag20 = (nint)0 < (nint)1;
		long num22 = (long)num16;
		int num23;
		array = (string[])num23;
		if (flag20)
		{
			goto IL_10cb;
		}
		num2 = num3;
		object obj36 = 0;
		List<int> list = default;
		Dictionary<long, int> dictionary4 = default;
		while (true)
		{
			object obj37 = 0;
			while (true)
			{
				int index = (int)(obj36 + obj37);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
				object obj38 = 0;
				int num24 = list.get_Item(index);
				array = (string[])obj38;
				object obj39 = (((nint)obj37 != 2) ? ((object)(obj37 + 1)) : ((object)0));
				int num25 = (int)(obj39 + obj36);
				int num26 = list.get_Item(num25);
				bool flag21 = obj12 == null;
				num3 = num2;
				array2 = (Transform[])num25;
				if (flag21)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v22+18]");
				bool flag22 = (nint)num24 < (nint)0;
				object obj40 = !flag22;
				obj15 = obj16;
				num4 = num5;
				array3 = array;
				array4 = (Transform[])num25;
				num7 = num;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v22+18]");
					bool flag23 = (nint)num26 < (nint)0;
					object obj41 = !flag23;
					obj15 = obj16;
					num4 = num5;
					array3 = array;
					array4 = (Transform[])num25;
					num7 = num;
					if (obj41 == null)
					{
						object obj42 = obj12 + num24;
						object obj43 = obj12 + num26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4D0]");
						object obj44 = 0;
						object obj45 = obj42 + 32;
						object obj46 = obj44;
						object obj47 = obj43 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1904 @ X0_v121+E4]");
						bool flag24 = (nint)0 == 0;
						object obj48 = !flag24;
						if (obj48 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag25 = dictionary4 == null;
						num3 = num2;
						array2 = (Transform[])num25;
						if (flag25)
						{
							break;
						}
						num22 = obj47 | obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4B8]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
						object obj50 = obj45 - obj47;
						bool flag26 = (nint)obj50 < 0;
						long num27 = obj45 ^ obj47;
						long num28 = obj45 ^ obj50;
						long num29 = num27 & num28;
						bool flag27 = num29 < 0;
						array3 = (string[])obj49;
						bool flag28 = flag26 == flag27;
						object obj51 = !flag28;
						object obj14 = ~obj51;
						long num30 = ((obj14 != null) ? ((long)obj45) : num22);
						int num31 = dictionary4.get_Item(num30);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6048]");
						object obj52 = 0;
						bool flag29 = num31 != 1;
						num21 = (int)num30;
						if (flag29)
						{
							goto IL_105b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v22+18]");
						bool flag30 = (nint)num26 < (nint)0;
						object obj53 = !flag30;
						obj15 = obj16;
						num4 = num5;
						array4 = (Transform[])num30;
						num7 = num;
						if (obj53 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v22+18]");
							bool flag31 = (nint)num24 < (nint)0;
							object obj54 = !flag31;
							obj15 = obj16;
							num4 = num5;
							array4 = (Transform[])num30;
							num7 = num;
							if (obj54 == null)
							{
								bool flag32 = dictionary2 == null;
								num3 = num2;
								array = array3;
								array2 = (Transform[])num30;
								if (flag32)
								{
									break;
								}
								num2 = (nint)obj52;
								dictionary2.set_Item((int)obj47, (int)obj45);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v22+18]");
								bool flag33 = (nint)num24 < (nint)0;
								object obj55 = !flag33;
								obj15 = obj16;
								num4 = num5;
								array3 = (string[])obj45;
								array4 = (Transform[])obj47;
								num7 = num;
								if (obj55 == null)
								{
									bool flag34 = dictionary3 == null;
									num3 = (nint)obj52;
									array = (string[])obj45;
									array2 = (Transform[])obj47;
									if (flag34)
									{
										break;
									}
									num2 = (nint)obj52;
									dictionary3.set_Item((int)obj45, num24);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v22+18]");
									bool flag35 = (nint)num26 < (nint)0;
									object obj56 = !flag35;
									obj15 = obj16;
									num4 = num5;
									array3 = (string[])num24;
									array4 = (Transform[])obj45;
									num7 = num;
									if (obj56 == null)
									{
										num21 = (int)obj47;
										num2 = (nint)obj52;
										dictionary3.set_Item((int)obj47, num26);
										array3 = (string[])num26;
										goto IL_105b;
									}
								}
							}
						}
					}
				}
				goto IL_1b82;
				IL_105b:
				obj37++;
				if ((nint)obj37 != 3)
				{
					continue;
				}
				goto IL_1089;
			}
			break;
			IL_1089:
			obj36 += 3;
			object obj57 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
			bool flag36 = (nint)obj57 < 0;
			num3 = num2;
			array = array3;
			if (flag36)
			{
				continue;
			}
			goto IL_10cb;
		}
		goto IL_1bc0;
		IL_10cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C38]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C30]");
		object obj59 = 0;
		array2 = (Transform[])obj59;
		HashSet<int> hashSet = default;
		hashSet._002Ector();
		object obj67;
		Enumerator<, > val3;
		if (dictionary2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4C8]");
			object obj60 = 0;
			Dictionary<int, int>.KeyCollection keys = dictionary2.Keys;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
			object obj61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BD8]");
			object obj62 = 0;
			array = (string[])obj62;
			List<int> list2 = default;
			list2._002Ector((IEnumerable<int>)(object)keys);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C28]");
			object obj64 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4C0]");
			object obj65 = 0;
			bool flag37 = list2 == null;
			array2 = (Transform[])(object)keys;
			if (!flag37)
			{
				Enumerator<, > enumerator = list2.GetEnumerator();
				object obj66 = obj67;
				num16 = num22;
				object obj68 = obj67;
				List<int> list3 = default;
				float num36 = default;
				while (true)
				{
					array2 = (Transform[])obj63;
					bool flag38 = val3.MoveNext();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
					object obj69 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C18]");
					object obj70 = 0;
					int num32;
					NullReferenceException ex;
					Enumerator<, > val;
					if (flag38)
					{
						if (hashSet != null)
						{
							array = (string[])obj64;
							bool flag39 = hashSet.Contains(0);
							bool flag40 = !flag39;
							object obj71 = !flag40;
							if (obj71 != null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							list3._002Ector();
							num32 = 0;
							while (true)
							{
								array = (string[])obj64;
								bool flag41 = hashSet.Contains(num32);
								bool flag42 = !flag41;
								object obj72 = !flag42;
								array2 = (Transform[])num32;
								if (obj72 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4B0]");
								obj68 = 0;
								array = (string[])obj68;
								bool flag43 = dictionary2.ContainsKey(num32);
								bool flag44 = !flag43;
								array2 = (Transform[])num32;
								if (flag44)
								{
									break;
								}
								if (list3 == null)
								{
									goto IL_19fb;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+18]");
								obj68 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+18]");
								if ((nint)0 >= (nint)4096)
								{
									goto IL_1516;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C20]");
								object obj73 = 0;
								array = (string[])obj73;
								bool flag45 = hashSet.Add(num32);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+10]");
								object obj74 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
								object obj75 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj76 = (nint)0 + (nint)1;
								num16 = (double)obj75;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+10]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj49 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+18]");
									nint num33 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v85+18]");
									bool flag46 = num33 < 0;
									object obj77 = !flag46;
									if (obj77 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+10]");
										nint num34 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+18]");
										obj68 = num34 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+18]");
										num16 = 0.0 + 1.0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1450 @ X9_v11 (System.Double)+20]");
										object obj78 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2112 @ X8_v87+A8]");
										obj68 = 0;
										list3.AddWithResize(num32);
									}
									int num35 = dictionary2.get_Item(num32);
									num32 = num35;
									continue;
								}
								goto IL_1a21;
							}
							if (num32 != 0)
							{
								continue;
							}
							if (list3 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+18]");
								obj68 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+18]");
								if ((nint)0 < (nint)3)
								{
									continue;
								}
								goto IL_1536;
							}
							ex = new NullReferenceException();
							val = (Enumerator<, >)(ref val3);
							num = num36;
							break;
						}
						ex = new NullReferenceException();
						val = (Enumerator<, >)(ref val3);
						num = num36;
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
					object obj79 = 0;
					array2 = (Transform[])obj79;
					val3.Dispose();
					val = (Enumerator<, >)(ref val3);
					num = num36;
					OutOfMemoryException ex2 = new OutOfMemoryException();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					break;
					IL_1ab1:
					ex = new NullReferenceException();
					val = (Enumerator<, >)(ref val3);
					int num37;
					array2 = (Transform[])num37;
					num = num36;
					break;
					IL_1536:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
					object obj80 = 0;
					int num38 = 1;
					int num39;
					int num42;
					int num45;
					while (true)
					{
						array = (string[])obj80;
						num39 = list3.get_Item(0);
						if (dictionary3 == null)
						{
							break;
						}
						array = (string[])obj65;
						num37 = dictionary3.get_Item(num39);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
						object obj81 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj82 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 == 0)
						{
							goto IL_1ab1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
						nint num40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v60+18]");
						bool flag47 = num40 < 0;
						object obj83 = !flag47;
						if (obj83 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
							nint num41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj84 = num41 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj85 = (nint)0 + (nint)1;
						}
						else
						{
							list.AddWithResize(num37);
						}
						int key = list3.get_Item(num38);
						array = (string[])obj65;
						num42 = dictionary3.get_Item(key);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
						object obj86 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj87 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
							nint num43 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X8_v62+18]");
							bool flag48 = num43 < 0;
							object obj88 = !flag48;
							if (obj88 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
								nint num44 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj89 = num44 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj90 = (nint)0 + (nint)1;
							}
							else
							{
								list.AddWithResize(num42);
							}
							int index2 = num38 + 1;
							int key2 = list3.get_Item(index2);
							array = (string[])obj65;
							num45 = dictionary3.get_Item(key2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
							object obj91 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
							object obj92 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+1C]");
							object obj93 = (nint)0 + (nint)1;
							object obj94 = obj92;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj49 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
								nint num46 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v64+18]");
								bool flag49 = num46 < 0;
								object obj95 = !flag49;
								if (obj95 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
									nint num47 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj96 = num47 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj97 = (nint)0 + (nint)1;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X9_v26+20]");
									object obj98 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2180 @ X8_v69+A8]");
									object obj99 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2181 @ X8_v70+70]");
									array = (string[])0;
									list.AddWithResize(num45);
								}
								num16 = (double)num38 + 2.0;
								num38++;
								double num48 = num16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X0_v75 (System.Collections.Generic.List`1<System.Int32>)+18]");
								if (num48 < 0.0)
								{
									continue;
								}
								goto IL_190d;
							}
							goto IL_1a8b;
						}
						goto IL_1ad7;
					}
					ex = new NullReferenceException();
					val = (Enumerator<, >)(ref val3);
					array2 = (Transform[])num39;
					num = num36;
					break;
					IL_190d:
					obj68 = obj66 + 1;
					obj66 = obj68;
					continue;
					IL_1a8b:
					ex = new NullReferenceException();
					val = (Enumerator<, >)(ref val3);
					array2 = (Transform[])num45;
					num = num36;
					break;
					IL_1a21:
					ex = new NullReferenceException();
					val = (Enumerator<, >)(ref val3);
					array2 = (Transform[])num32;
					num = num36;
					break;
					IL_1516:
					if (num32 != 0)
					{
						continue;
					}
					goto IL_1536;
					IL_19fb:
					ex = new NullReferenceException();
					val = (Enumerator<, >)(ref val3);
					array2 = (Transform[])num32;
					num = num36;
					break;
					IL_1ad7:
					ex = new NullReferenceException();
					val = (Enumerator<, >)(ref val3);
					array2 = (Transform[])num42;
					num = num36;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				Mesh result = default;
				return result;
			}
		}
		goto IL_1bc0;
		IL_1bc0:
		throw new NullReferenceException();
		IL_1b82:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		num3 = num2;
		obj16 = obj15;
		num5 = num4;
		array = array3;
		array2 = array4;
		num = num7;
		goto IL_1bc0;
		IL_0784:
		if ((object)mesh != null)
		{
			int subMeshCount = mesh.subMeshCount;
			if (subMeshCount < 1)
			{
				Mesh result2 = mesh;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4D8]");
				object format = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj100 = 0;
				string name = src.name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj101 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object arg = default;
				string message = string.Format((string)format, name, arg);
				object obj102 = obj100;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X8_v21+E4]");
				bool flag50 = (nint)0 == 0;
				object obj103 = !flag50;
				if (obj103 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.Log(message);
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
			object obj69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C18]");
			object obj70 = 0;
			val3 = (Enumerator<, >)0;
			int value = 0;
			obj67 = 0;
			int submesh = 0;
			Mesh mesh2 = mesh;
			int[] triangles = mesh2.GetTriangles(submesh);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
			object obj104 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BD8]");
			object obj105 = 0;
			array = (string[])obj105;
			list._002Ector((IEnumerable<int>)triangles);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6998]");
			object obj106 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6990]");
			object obj107 = 0;
			array2 = (Transform[])obj107;
			dictionary4._002Ector();
			if (list != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
				bool flag51 = (nint)0 < (nint)1;
				num23 = (int)obj105;
				long num49 = (long)obj107;
				if (flag51)
				{
					goto IL_0b4e;
				}
				num2 = num3;
				object obj108 = 0;
				while (true)
				{
					object obj109 = 0;
					long num60;
					while (true)
					{
						array = (string[])obj69;
						int num50 = (int)(obj108 + obj109);
						int num51 = list.get_Item(num50);
						bool flag52 = obj12 == null;
						num3 = num2;
						array2 = (Transform[])num50;
						if (flag52)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v22+18]");
						bool flag53 = (nint)num51 < (nint)0;
						object obj110 = !flag53;
						obj15 = obj16;
						num4 = num5;
						array3 = (string[])obj69;
						array4 = (Transform[])num50;
						num7 = num;
						if (obj110 == null)
						{
							object obj111 = obj12 + num51;
							array3 = (string[])obj69;
							object obj112 = (((nint)obj109 != 2) ? ((object)(obj109 + 1)) : ((object)0));
							int num52 = (int)(obj112 + obj108);
							int num53 = list.get_Item(num52);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v22+18]");
							bool flag54 = (nint)num53 < (nint)0;
							object obj113 = !flag54;
							obj15 = obj16;
							num4 = num5;
							array4 = (Transform[])num52;
							num7 = num;
							if (obj113 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4D0]");
								object obj114 = 0;
								object obj115 = obj12 + num53;
								object obj116 = obj114;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1795 @ X0_v136+E4]");
								bool flag55 = (nint)0 == 0;
								object obj117 = !flag55;
								if (obj117 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag56 = dictionary4 == null;
								num3 = num2;
								array = array3;
								array2 = (Transform[])num52;
								if (flag56)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v112+20]");
								nint num54 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1633 @ X8_v109+20]");
								num16 = num54 | 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1633 @ X8_v109+20]");
								nint num55 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v112+20]");
								object obj118 = num55 - 0;
								bool flag57 = (nint)obj118 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1633 @ X8_v109+20]");
								nint num56 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v112+20]");
								long num57 = num56 ^ 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1633 @ X8_v109+20]");
								long num58 = 0 ^ obj118;
								long num59 = num57 & num58;
								bool flag58 = num59 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
								obj109++;
								bool flag59 = flag57 == flag58;
								object obj119 = !flag59;
								object obj14 = ~obj119;
								if (obj14 == null)
								{
									num60 = (long)num16;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1633 @ X8_v109+20]");
									num60 = 0L;
								}
								bool flag60 = dictionary4.TryGetValue(num60, out value);
								num2 = (nint)obj70;
								num23 = value + 1;
								dictionary4.set_Item(num60, num23);
								if ((nint)obj109 != 3)
								{
									continue;
								}
								goto IL_0b0c;
							}
						}
						goto IL_1b82;
					}
					break;
					IL_0b0c:
					obj108 += 3;
					object obj120 = obj108;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
					bool flag61 = (nint)obj120 < 0;
					num3 = (nint)obj70;
					num49 = num60;
					if (flag61)
					{
						continue;
					}
					goto IL_0b4e;
				}
			}
		}
		goto IL_1bc0;
	}

	public static Mesh BuildHeadless(Mesh src, Transform[] bones, float threshold = default(float))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+A0]");
		object cut = 0;
		return BuildHeadless(src, bones, (string[])cut, threshold);
	}

	public static Mesh BuildHeadless(Mesh src, Transform[] bones, string[] cut, float threshold)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I8
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00b1: Expected Obj, but got I4
		//IL_0e0e: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_05aa: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I
		//IL_05dc: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_014b: Expected Obj, but got I4
		//IL_0653: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I4
		//IL_0368: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I
		//IL_06b8: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I4
		//IL_040f: Expected Obj, but got I4
		//IL_06e4: Expected Obj, but got I
		//IL_042d: Expected F4, but got I
		//IL_043d: Expected Obj, but got I
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_045b: Expected Obj, but got I
		//IL_046b: Expected Obj, but got I
		//IL_0716: Expected Obj, but got I4
		//IL_049c: Expected F4, but got I4
		//IL_0767: Expected Obj, but got I4
		//IL_04aa: Expected Obj, but got I4
		//IL_0f35: Expected Obj, but got I4
		//IL_04b8: Expected Obj, but got I4
		//IL_04c6: Expected Obj, but got I4
		//IL_04db: Expected Obj, but got I
		//IL_04fc: Expected Obj, but got I4
		//IL_07df: Expected Obj, but got I4
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0574: Expected F4, but got I4
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_0812: Expected F4, but got I
		//IL_0822: Invalid comparison between I and F4
		//IL_0cf1: Expected Obj, but got I4
		//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Expected Obj, but got Unknown
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected Obj, but got Unknown
		//IL_0860: Expected Obj, but got I4
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected Obj, but got Unknown
		//IL_08aa: Expected Obj, but got I4
		//IL_08d5: Expected F4, but got I
		//IL_08e5: Invalid comparison between I and F4
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected Obj, but got Unknown
		//IL_0923: Expected Obj, but got I4
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected Obj, but got Unknown
		//IL_0975: Expected Obj, but got I4
		//IL_0990: Expected I4, but got Obj
		//IL_09a0: Expected F4, but got I
		//IL_09b0: Invalid comparison between I and F4
		//IL_09d7: Expected Obj, but got I
		//IL_09ee: Expected Obj, but got I
		//IL_0a41: Expected Obj, but got I4
		//IL_0ac3: Expected Obj, but got I4
		//IL_0ee7: Expected Obj, but got I4
		//IL_0a6c: Expected Obj, but got I
		//IL_0a82: Expected Obj, but got I
		//IL_0ae0: Expected Obj, but got I
		//IL_0af7: Expected Obj, but got I
		//IL_0b31: Expected Obj, but got I
		//IL_0b5a: Expected Obj, but got I4
		//IL_0bc2: Expected I4, but got Obj
		//IL_0bcc: Expected Obj, but got I4
		//IL_0f0e: Expected Obj, but got I4
		//IL_0b85: Expected Obj, but got I
		//IL_0b9b: Expected Obj, but got I
		//IL_0be9: Expected Obj, but got I
		//IL_0bf1: Expected I4, but got Obj
		//IL_0c07: Expected Obj, but got I
		//IL_0c41: Expected Obj, but got I
		//IL_0c51: Expected Obj, but got I
		//IL_0c7a: Expected Obj, but got I4
		//IL_0cda: Expected I4, but got Obj
		//IL_0ca5: Expected Obj, but got I
		object obj2;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		if (bones != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj2 = 0;
			UnityEngine.Object obj3 = (UnityEngine.Object)bones.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag = bones.Length < 1;
			string[] array = cut;
			if (flag)
			{
				goto IL_025f;
			}
			object obj4 = bones.Length & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4708]");
			object obj5 = 0;
			obj6 = bones + 32;
			obj7 = obj8 + 32;
			string[] array2 = cut;
			object obj9 = 0;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
				object obj10 = !flag2;
				if (obj10 != null)
				{
					break;
				}
				object obj11 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v43+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X27_v7+v213 @ X25_v9*8]");
				if ((UnityEngine.Object)0 != null)
				{
					bool flag4 = (nint)obj9 < bones.Length;
					object obj13 = !flag4;
					if (obj13 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X27_v7+v213 @ X25_v9*8]");
					if ((nint)0 == 0)
					{
						goto IL_0dad;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X27_v7+v213 @ X25_v9*8]");
					string name = ((UnityEngine.Object)0).name;
					array = (string[])obj5;
					int num = Array.IndexOf((System.__Canon[])(object)cut, (System.__Canon)(object)name);
					int num2 = ~num;
					int num3 = num2 >> 31;
					obj3 = (UnityEngine.Object)(object)name;
				}
				else
				{
					int num3 = 0;
					array = null;
					obj3 = null;
				}
				if (obj8 != null)
				{
					object obj14 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+18]");
					bool flag5 = (nint)obj14 < 0;
					object obj15 = !flag5;
					if (obj15 != null)
					{
						break;
					}
					obj4 = bones.Length;
					obj9++;
					bool flag6 = (nint)obj9 < bones.Length;
					array2 = array;
					if (flag6)
					{
						continue;
					}
					goto IL_025f;
				}
				goto IL_0dad;
			}
			goto IL_0d9f;
		}
		goto IL_0dad;
		IL_0d9a:
		UnityEngine.Object obj16 = default;
		return (Mesh)obj16;
		IL_0dad:
		return (Mesh)(object)new NullReferenceException();
		IL_0d9f:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0dad;
		IL_0592:
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BB8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4E0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDA38");
		string name2 = src.name;
		string name3 = name2 + (string)obj19;
		object obj27 = default;
		object obj29 = default;
		object obj35 = default;
		if ((object)obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
			object obj21 = 0;
			obj16.name = name3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<int> list = default;
			list._002Ector();
			int subMeshCount = src.subMeshCount;
			if (subMeshCount < 1)
			{
				goto IL_0d9a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
			object obj22 = 0;
			int num4 = 0;
			Mesh mesh = src;
			object obj25 = default;
			while (true)
			{
				int[] triangles = mesh.GetTriangles(num4);
				if (list == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj23 = (nint)0 + (nint)1;
				_ = 0;
				if (triangles == null)
				{
					break;
				}
				object obj24 = triangles.Length;
				if (triangles.Length < 1)
				{
					goto IL_0d45;
				}
				obj25 = obj25;
				object obj26 = obj27;
				object obj28 = obj29;
				object obj30 = obj7;
				object obj31 = obj6;
				object obj32 = 0;
				int[] array3 = triangles;
				object obj33 = obj21;
				while (true)
				{
					bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
					object obj34 = !flag8;
					if (obj34 != null)
					{
						break;
					}
					if (obj35 == null)
					{
						goto end_IL_0f43;
					}
					object obj36 = (object)triangles + obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v12+18]");
					int num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X9_v9+20]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v12+18]");
					bool flag9 = num5 < 0;
					object obj37 = !flag9;
					if (obj37 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X9_v9+20]");
					object obj38 = obj35 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X10_v6+20]");
					float num6 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X10_v6+20]");
					if (0f < threshold)
					{
						obj33 = obj32 + 1;
						bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
						object obj39 = !flag10;
						if (obj39 != null)
						{
							break;
						}
						object obj40 = (object)triangles + obj33;
						obj25 = obj40 + 32;
						object obj41 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v12+18]");
						bool flag11 = (nint)obj41 < 0;
						object obj42 = !flag11;
						if (obj42 != null)
						{
							break;
						}
						obj38 = obj35 + obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X10_v6+20]");
						num6 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X10_v6+20]");
						if (0f < threshold)
						{
							obj30 = obj32 + 2;
							bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
							object obj43 = !flag12;
							if (obj43 != null)
							{
								break;
							}
							object obj44 = (object)triangles + obj30;
							obj31 = obj44 + 32;
							obj38 = obj31;
							object obj45 = obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v12+18]");
							bool flag13 = (nint)obj45 < 0;
							object obj46 = !flag13;
							if (obj46 != null)
							{
								break;
							}
							num3 = (int)(obj35 + obj31);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X9_v7 (System.Int32)+20]");
							num6 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X9_v7 (System.Int32)+20]");
							if (0f < threshold)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+10]");
								object obj47 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj48 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+10]");
								if ((nint)0 == 0)
								{
									goto end_IL_0f43;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+18]");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X9_v13+18]");
								bool flag14 = num7 < 0;
								object obj49 = !flag14;
								List<int> list2;
								if (obj49 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+10]");
									nint num8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj50 = num8 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj51 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X9_v9+20]");
									_ = 0;
									list2 = (List<int>)(object)array3;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X9_v9+20]");
									list.AddWithResize(0);
									obj24 = triangles.Length;
									list2 = list;
								}
								bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
								object obj52 = !flag15;
								if (obj52 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+10]");
								object obj53 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj54 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+10]");
								if ((nint)0 == 0)
								{
									goto end_IL_0f43;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X9_v15+18]");
								obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+18]");
								nint num9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X9_v15+18]");
								bool flag16 = num9 < 0;
								object obj55 = !flag16;
								if (obj55 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+10]");
									nint num10 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj56 = num10 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj57 = (nint)0 + (nint)1;
									array3 = (int[])(object)list2;
								}
								else
								{
									list.AddWithResize((int)obj25);
									obj24 = triangles.Length;
									array3 = (int[])(object)list;
								}
								bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
								object obj58 = !flag17;
								if (obj58 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+10]");
								object obj59 = 0;
								num3 = (int)obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj60 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+10]");
								if ((nint)0 == 0)
								{
									goto end_IL_0f43;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+18]");
								obj38 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+18]");
								obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+18]");
								nint num11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+18]");
								bool flag18 = num11 < 0;
								object obj61 = !flag18;
								if (obj61 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+10]");
									nint num12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj62 = num12 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v22 (System.Collections.Generic.List`1<System.Int32>)+18]");
									num3 = (int)((nint)0 + (nint)1);
								}
								else
								{
									list.AddWithResize((int)obj31);
									array3 = (int[])(object)list;
								}
							}
						}
					}
					obj24 = triangles.Length;
					obj32 += 3;
					bool flag19 = (nint)obj32 < triangles.Length;
					obj27 = obj26;
					obj29 = obj28;
					obj7 = obj30;
					obj6 = obj31;
					obj21 = obj33;
					if (flag19)
					{
						continue;
					}
					goto IL_0d45;
				}
				goto IL_0d9f;
				IL_0d45:
				((Mesh)obj16).SetTriangles(list, num4);
				num4++;
				int subMeshCount2 = src.subMeshCount;
				bool flag20 = num4 < subMeshCount2;
				mesh = src;
				if (flag20)
				{
					continue;
				}
				goto IL_0d9a;
				continue;
				end_IL_0f43:
				break;
			}
		}
		goto IL_0dad;
		IL_025f:
		if ((object)src != null)
		{
			BoneWeight[] boneWeights = src.boneWeights;
			if (boneWeights != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
				object obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				bool flag21 = boneWeights.Length < 1;
				float num6 = threshold;
				if (flag21)
				{
					goto IL_0592;
				}
				object obj64 = boneWeights + 60;
				obj29 = obj35 + 32;
				int num13 = 0;
				while (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v24-C]");
					object obj65 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v24-C]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+18]");
					bool flag22 = num14 < 0;
					object obj66 = !flag22;
					if (obj66 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v24-8]");
						object obj67 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v24-8]");
						nint num15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+18]");
						bool flag23 = num15 < 0;
						object obj68 = !flag23;
						if (obj68 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v24-4]");
							object obj69 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v24-4]");
							nint num16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+18]");
							bool flag24 = num16 < 0;
							object obj70 = !flag24;
							if (obj70 == null)
							{
								object obj71 = obj64;
								object obj72 = obj64;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+18]");
								bool flag25 = (nint)obj72 < 0;
								object obj73 = !flag25;
								if (obj73 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v24-1C]");
									float num17 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v24-18]");
									object obj74 = 0;
									object obj75 = obj8 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v24-14]");
									object obj76 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v24-10]");
									object obj77 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X16_v6+v564 @ X12_v12]");
									if ((nint)0 == 0)
									{
										num17 = 0f;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X16_v6+v562 @ X13_v5]");
									if ((nint)0 == 0)
									{
										obj74 = 128;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X16_v6+v115 @ X14_v5]");
									if ((nint)0 == 0)
									{
										obj76 = 128;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X16_v6+v109 @ X15_v5]");
									if ((nint)0 == 0)
									{
										obj77 = 128;
									}
									if (obj35 == null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v12+18]");
									obj27 = 0;
									int num18 = num13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v12+18]");
									bool flag26 = (nint)num18 < (nint)0;
									object obj78 = !flag26;
									if (obj78 == null)
									{
										float num19 = num17 + (float)obj74;
										object obj38 = obj64 + 32;
										float num20 = (float)obj76 + num19;
										float num21 = (float)obj77 + num20;
										int num3 = num13 + 1;
										bool flag27 = boneWeights.Length != num3;
										num6 = 0f;
										obj64 = obj38;
										num13 = num3;
										if (flag27)
										{
											continue;
										}
										goto IL_0592;
									}
								}
							}
						}
					}
					goto IL_0d9f;
				}
			}
		}
		goto IL_0dad;
	}

	static HeadHider()
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
		//IL_015c: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F0]");
			object obj2 = 0;
			object obj4 = default;
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X20_v6-8]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48D8]");
				object obj6 = 0;
				object obj7 = obj4 + 40;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X20_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X20_v8-10]");
				object obj9 = -2;
				bool flag2 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4910]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4D0]");
					object obj13 = 0;
					object obj14 = obj4 + 48;
					obj14 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj15 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v14+A0]");
					object obj16 = 0;
					obj16 = obj4;
					object obj17 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					return;
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal static long _003CBuildCapped_003Eg__Key_007C1_0(int a, int b)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		//IL_0085: Expected Obj, but got I4
		//IL_00b1: Expected I8, but got I4
		//IL_00a4: Expected I8, but got I4
		object obj = a - b;
		bool flag = (nint)obj < 0;
		int num = a ^ b;
		int num2 = a ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		int num4 = b | a;
		int num5 = a | b;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			return num4;
		}
		return num5;
	}
}
