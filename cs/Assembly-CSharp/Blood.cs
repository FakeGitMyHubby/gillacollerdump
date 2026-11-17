using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Rendering;

public static class Blood
{
	private static Mesh s_drop;

	private static GillaGoreAssets s_gore;

	private static readonly ProfilerMarker BloodMark;

	private static readonly Color Dark;

	private static readonly Color Bright;

	private const int IgnoreLayers = default(int);

	private const float Budget = default(float);

	private const float Lately = default(float);

	private const float Least = default(float);

	private const float Thin = default(float);

	private const float Most = default(float);

	private static float let;

	private static float letAt;

	private const int ChainMostDrops = default(int);

	private const int ChainMostBits = default(int);

	private static ParticleSystem chainDrops;

	private static ParticleSystem chainBits;

	private static GillaGoreAssets Gore
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0153: Expected Obj, but got I
			//IL_0175: Expected Obj, but got I4
			//IL_01f5: Expected Obj, but got I
			//IL_0217: Expected Obj, but got I4
			//IL_004d: Expected Obj, but got I
			//IL_00cd: Expected Obj, but got I
			//IL_00dd: Expected Obj, but got I
			//IL_0111: Expected Obj, but got I4
			//IL_01be: Expected Obj, but got I
			//IL_0098: Expected Obj, but got I4
			//IL_0193: Expected Obj, but got I
			//IL_01a3: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+8]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v18+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v18+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v12+8]");
				return (GillaGoreAssets)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v9+A0]");
			object obj15 = (nint)0 + (nint)8;
			GillaGoreAssets gillaGoreAssets = default;
			obj15 = gillaGoreAssets;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return gillaGoreAssets;
		}
	}

	private static Material RoomLit(Material given)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaGoreAssets gore = Gore;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = gore != null;
		bool flag4 = !flag3;
		Material result = given;
		if (!flag4)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaGoreAssets gore2 = Gore;
			if ((object)gore2 == null)
			{
				goto IL_0212;
			}
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v8+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = gore2.spray != null;
			bool flag8 = !flag7;
			result = given;
			if (!flag8)
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v19+E4]");
				bool flag9 = (nint)0 == 0;
				object obj12 = !flag9;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaGoreAssets gore3 = Gore;
				if ((object)gore3 == null)
				{
					goto IL_0212;
				}
				result = gore3.spray;
			}
		}
		return result;
		IL_0212:
		return (Material)(object)new NullReferenceException();
	}

	private static void Fresh()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
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
		object obj4 = (nint)0 + (nint)72;
		obj4 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+A0]");
		object obj6 = (nint)0 + (nint)64;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public static float Share(float want)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I
		//IL_01f6: Invalid comparison between F4 and I4
		//IL_026e: Invalid comparison between F4 and I
		//IL_027f: Expected Obj, but got I4
		//IL_029f: Invalid comparison between F4 and I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_0300: Expected Obj, but got I4
		//IL_0035: Expected F4, but got I4
		//IL_03c1: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_0317: Invalid comparison between F4 and I4
		//IL_0329: Expected F8, but got I4
		//IL_0332: Expected F8, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected F4, but got I
		//IL_00c3: Expected Obj, but got I4
		//IL_0367: Expected F8, but got I
		//IL_0390: Invalid comparison between F4 and I
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj = 0;
		float unscaledTime = Time.unscaledTime;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X19_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		object obj4 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X19_v9+A0]");
		object obj5 = 0;
		float num = unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v1+3C]");
		float num2 = num - 0f;
		if (num2 < 0f)
		{
			num2 = 0f;
		}
		float num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD04]");
		float num4 = num3 / 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v1+38]");
		float num5 = 0f * num4;
		float num6 = num5 + want;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD40]");
		bool flag2 = num6 < 0f;
		object obj6 = !flag2;
		float num7 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD40]");
		float num8 = num7 - 0f;
		bool flag3 = num8 == 0f;
		object obj7 = ~obj6;
		object obj8 = obj7 | flag3;
		double num9 = num6;
		double num10 = 1.0;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X19_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X19_v9+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v16+38]");
				num5 = 0f;
			}
			bool flag5 = !(num5 < 1.1639849E+09f);
			num9 = 1163984896.0;
			num10 = 0.0;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X19_v9+E4]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X19_v9+A0]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v15+38]");
					num5 = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD40]");
				float num11 = 0f - num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
				num10 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				object obj13 = default;
				num5 = num11 / (float)obj13;
				float num12 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
				bool flag7 = num12 < 0f;
				num9 = 1.0;
				if (!flag7)
				{
					if ((double)num5 > 1.0)
					{
						num9 = 1.0;
						num10 = 1.0;
					}
					else
					{
						num9 = 1.0;
						num10 = num5;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X19_v9+E4]");
		bool flag8 = (nint)0 == 0;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X19_v9+A0]");
		object obj15 = 0;
		double num13 = num10 * (double)want;
		double num14 = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v8+38]");
		double num15 = num14 + 0.0;
		return (float)num10;
	}

	private static short Some(float n)
	{
		//IL_013d: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I4
		//IL_0027: Invalid comparison between F4 and I4
		//IL_01d8: Invalid comparison between F4 and I4
		//IL_01e7: Invalid comparison between F4 and I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got F4
		//IL_023d: Expected Obj, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		//IL_011a: Expected I4, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num;
		float num2;
		float num3 = default;
		if (n < 0f)
		{
			if ((double)n == -0.5)
			{
				num = -1.0;
				num2 = num3;
				goto IL_0175;
			}
			num2 = n + -0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if ((double)n == 0.5)
			{
				num = 1.0;
				num2 = num3;
				goto IL_0175;
			}
			num2 = n + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_01bf;
		IL_01bf:
		float num4 = num2 - 1f;
		bool flag2 = num4 < 0f;
		bool flag3 = num4 == 0f;
		object obj4 = num2 ^ 1;
		object obj5 = num2 ^ num4;
		object obj6 = obj4 & obj5;
		bool flag4 = (nint)obj6 < 0;
		bool flag5 = flag2 == flag4;
		object obj7 = !flag3;
		object obj8 = flag5 & obj7;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			return (short)(int)num2;
		}
		return 1;
		IL_0175:
		double num5 = (double)num2 + num;
		object obj10 = num2 & 1;
		bool flag6 = obj10 == null;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			num2 = (float)num5;
		}
		goto IL_01bf;
	}

	public unsafe static void Spray(Transform at, Vector3 dir, Material mat, float seconds, int burst, int pulses, float fine = default(float))
	{
		//IL_0010: Expected Obj, but got I
		//IL_178f: Expected Obj, but got I4
		//IL_1ac3: Expected Obj, but got I
		//IL_17ad: Expected Obj, but got I
		//IL_17b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bb: Expected Obj, but got Unknown
		//IL_17cb: Invalid comparison between F4 and I
		//IL_004e: Expected VT, but got I4
		//IL_1826: Invalid comparison between F4 and I4
		//IL_1835: Invalid comparison between F4 and I4
		//IL_1844: Unknown result type (might be due to invalid IL or missing references)
		//IL_1849: Expected Obj, but got Unknown
		//IL_1856: Expected Obj, but got F4
		//IL_188b: Expected Obj, but got I4
		//IL_1893: Unknown result type (might be due to invalid IL or missing references)
		//IL_1898: Expected Obj, but got Unknown
		//IL_0063: Expected F4, but got I
		//IL_18c9: Expected Obj, but got I4
		//IL_007e: Expected F4, but got I4
		//IL_00b5: Invalid comparison between F4 and I4
		//IL_00c6: Expected Obj, but got I4
		//IL_00cf: Invalid comparison between F4 and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got I4
		//IL_0102: Expected VT, but got I4
		//IL_010b: Expected VT, but got I4
		//IL_0114: Expected VT, but got I4
		//IL_011d: Expected VT, but got I4
		//IL_0126: Expected VT, but got I4
		//IL_012f: Expected F8, but got I4
		//IL_145a: Expected Obj, but got Ref
		//IL_14a8: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I
		//IL_15a5: Expected Obj, but got VT
		//IL_1480: Expected I, but got Obj
		//IL_1489: Expected VT, but got I4
		//IL_01ae: Expected Obj, but got I4
		//IL_01b7: Expected VT, but got I4
		//IL_01c0: Expected VT, but got I4
		//IL_01c9: Expected VT, but got I4
		//IL_01d2: Expected VT, but got I4
		//IL_01db: Expected VT, but got I4
		//IL_01e4: Expected F8, but got I4
		//IL_14e0: Expected Obj, but got I4
		//IL_14e8: Expected Obj, but got VT
		//IL_0231: Expected Obj, but got I4
		//IL_023a: Expected VT, but got I4
		//IL_0243: Expected VT, but got I4
		//IL_024c: Expected VT, but got I4
		//IL_0255: Expected VT, but got I4
		//IL_025e: Expected VT, but got I4
		//IL_0267: Expected F8, but got I4
		//IL_15fe: Expected I4, but got Obj
		//IL_031e: Invalid comparison between F4 and I
		//IL_19c9: Expected Obj, but got I
		//IL_19da: Expected VT, but got I
		//IL_033e: Expected VT, but got F4
		//IL_18f4: Expected Obj, but got I
		//IL_1904: Expected F4, but got I
		//IL_1914: Expected F8, but got I
		//IL_1942: Expected Obj, but got I4
		//IL_194b: Expected VT, but got I4
		//IL_1954: Expected VT, but got I4
		//IL_195d: Expected VT, but got I4
		//IL_1966: Expected VT, but got I4
		//IL_196f: Expected VT, but got I4
		//IL_198e: Expected Obj, but got Ref
		//IL_0356: Expected VT, but got I4
		//IL_0366: Expected Obj, but got I
		//IL_039a: Expected Obj, but got I4
		//IL_03a3: Expected VT, but got I4
		//IL_03ac: Expected VT, but got I4
		//IL_03b5: Expected VT, but got I4
		//IL_03be: Expected VT, but got I4
		//IL_03c7: Expected VT, but got I4
		//IL_168c: Expected Obj, but got I4
		//IL_1694: Expected VT, but got Obj
		//IL_0429: Expected Obj, but got I4
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected I4, but got Unknown
		//IL_0497: Expected Obj, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_16b0: Invalid comparison between VT and I4
		//IL_170f: Invalid comparison between VT and I4
		//IL_1a01: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I
		//IL_16e9: Expected Obj, but got I4
		//IL_0537: Expected Obj, but got I4
		//IL_0540: Expected VT, but got I4
		//IL_0549: Expected VT, but got I4
		//IL_0552: Expected VT, but got I4
		//IL_055b: Expected VT, but got I4
		//IL_0564: Expected VT, but got I4
		//IL_05cc: Expected Obj, but got I4
		//IL_05d5: Expected VT, but got I4
		//IL_05de: Expected VT, but got I4
		//IL_05e7: Expected VT, but got I4
		//IL_05f0: Expected VT, but got I4
		//IL_05f9: Expected VT, but got I4
		//IL_0803: Expected F4, but got I
		//IL_0803: Expected F4, but got I
		//IL_0669: Expected Obj, but got I8
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected Obj, but got Unknown
		//IL_0680: Expected Obj, but got I4
		//IL_0815: Expected VT, but got Ref
		//IL_1a28: Expected Obj, but got I4
		//IL_1a38: Expected VT, but got Obj
		//IL_0841: Expected VT, but got Ref
		//IL_1538: Expected Obj, but got I4
		//IL_1541: Expected VT, but got I4
		//IL_154a: Expected VT, but got I4
		//IL_1553: Expected VT, but got I4
		//IL_155c: Expected VT, but got I4
		//IL_1565: Expected VT, but got I4
		//IL_08a0: Expected VT, but got Ref
		//IL_06a7: Expected F4, but got I
		//IL_06d4: Expected F4, but got I
		//IL_08c3: Expected VT, but got Ref
		//IL_151c: Expected VT, but got I4
		//IL_08d8: Expected F4, but got I
		//IL_0924: Expected VT, but got Ref
		//IL_06f9: Expected Obj, but got Ref
		//IL_0709: Expected F4, but got I
		//IL_0711: Expected Obj, but got Ref
		//IL_072b: Expected VT, but got Ref
		//IL_0739: Expected Obj, but got I4
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected Obj, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected Obj, but got Unknown
		//IL_076d: Expected F4, but got VT
		//IL_0777: Expected F4, but got VT
		//IL_079f: Expected F4, but got VT
		//IL_07a7: Expected Obj, but got Ref
		//IL_0953: Expected Obj, but got I4
		//IL_1a56: Expected Obj, but got I
		//IL_1a69: Expected VT, but got I4
		//IL_1a69: Expected VT, but got I4
		//IL_1a76: Expected VT, but got Ref
		//IL_1a87: Expected F4, but got I
		//IL_0985: Expected VT, but got Ref
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected Obj, but got Unknown
		//IL_0a21: Expected VT, but got Ref
		//IL_0a31: Expected Obj, but got I
		//IL_0a94: Expected Obj, but got I
		//IL_0aa3: Expected Obj, but got I4
		//IL_0aac: Expected VT, but got I4
		//IL_0ab5: Expected VT, but got I4
		//IL_0abe: Expected VT, but got I4
		//IL_0add: Expected F8, but got I4
		//IL_0ae9: Expected Obj, but got I4
		//IL_0afc: Expected F8, but got I4
		//IL_0b17: Expected F4, but got I4
		//IL_0b1f: Expected Obj, but got I4
		//IL_0b56: Expected Obj, but got I
		//IL_0b65: Expected Obj, but got I4
		//IL_0b6e: Expected VT, but got I4
		//IL_0b77: Expected VT, but got I4
		//IL_0b80: Expected VT, but got I4
		//IL_0b9f: Expected F8, but got I4
		//IL_0bab: Expected Obj, but got I4
		//IL_0bbe: Expected F8, but got I4
		//IL_0bd9: Expected F4, but got I4
		//IL_0be1: Expected Obj, but got I4
		//IL_0c13: Expected Obj, but got I4
		//IL_0c5f: Expected F4, but got I
		//IL_0c8f: Expected Obj, but got I
		//IL_0cd6: Expected Obj, but got I
		//IL_0ce5: Expected Obj, but got I4
		//IL_0cee: Expected VT, but got I4
		//IL_0d10: Expected F8, but got I4
		//IL_0d1c: Expected Obj, but got I4
		//IL_0d4e: Expected F4, but got I4
		//IL_0d8a: Expected Obj, but got I
		//IL_0d99: Expected Obj, but got I4
		//IL_0da2: Expected VT, but got I4
		//IL_0dc4: Expected F8, but got I4
		//IL_0dd0: Expected Obj, but got I4
		//IL_0e02: Expected F4, but got I4
		//IL_0e36: Expected F4, but got I
		//IL_0e54: Expected F4, but got I
		//IL_0e6e: Expected Obj, but got I8
		//IL_0e8f: Expected Obj, but got I
		//IL_0e9e: Expected Obj, but got I4
		//IL_0ea7: Expected VT, but got I4
		//IL_0ecc: Expected F8, but got I4
		//IL_0ed8: Expected Obj, but got I4
		//IL_0f5e: Expected Obj, but got I4
		//IL_0f74: Expected Obj, but got I
		//IL_0f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f99: Expected Obj, but got Unknown
		//IL_0fab: Expected Obj, but got I
		//IL_0fba: Expected Obj, but got I4
		//IL_0fc3: Expected VT, but got I4
		//IL_0feb: Expected F8, but got I4
		//IL_0ff7: Expected Obj, but got I4
		//IL_100a: Expected F8, but got I4
		//IL_1064: Expected Obj, but got I4
		//IL_108c: Expected VT, but got Ref
		//IL_10ee: Expected I4, but got I8
		//IL_115f: Expected F4, but got I
		//IL_1170: Expected VT, but got Ref
		//IL_118f: Expected VT, but got Ref
		//IL_11af: Expected VT, but got Ref
		//IL_11d6: Expected Obj, but got I
		//IL_11de: Expected VT, but got Obj
		//IL_120e: Expected Obj, but got I
		//IL_121d: Expected Obj, but got I4
		//IL_1242: Expected F8, but got I4
		//IL_124e: Expected Obj, but got I4
		//IL_1259: Expected F8, but got I4
		//IL_1290: Expected Obj, but got I4
		//IL_129e: Expected Obj, but got I4
		//IL_12cd: Expected Obj, but got I4
		//IL_1300: Expected Obj, but got I4
		//IL_130e: Expected Obj, but got VT
		//IL_131f: Expected Obj, but got I4
		//IL_1332: Expected Obj, but got I4
		//IL_1340: Expected Obj, but got I4
		//IL_1353: Expected Obj, but got I4
		//IL_1371: Expected Obj, but got I
		//IL_139b: Expected Obj, but got I4
		//IL_13eb: Expected Obj, but got I
		//IL_13fa: Expected Obj, but got I4
		//IL_141f: Expected F8, but got I4
		//IL_142b: Expected Obj, but got I4
		//IL_1436: Expected F8, but got I4
		//IL_144d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v5+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4+10]");
		bool flag2 = (nint)0 == 0;
		Vector3 vector = dir;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4+10]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			obj2 = obj;
			vector = (Vector3)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v5+E4]");
		object obj5 = 0;
		object obj7 = default;
		object obj6 = obj7 * 1124859904;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		float num2 = default;
		float num3;
		if (num2 < 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			num3 = 0f;
		}
		else
		{
			num3 = num2;
		}
		object obj8 = obj6 * obj7;
		float num4 = num3 * (float)obj8;
		Material material = default;
		float num5 = num4 + (float)material;
		float num6 = num5 - 1.1422925E+09f;
		bool flag3 = num6 < 0f;
		bool flag4 = num6 == 0f;
		object obj9 = num5 ^ 0x44160000;
		object obj10 = num5 ^ num6;
		object obj11 = obj9 & obj10;
		bool flag5 = (nint)obj11 < 0;
		bool flag6 = flag3 == flag5;
		object obj12 = !flag4;
		object obj13 = flag6 & obj12;
		object obj14 = ~obj13;
		float want = ((obj14 != null) ? num5 : 1.1422925E+09f);
		bool flag7 = obj5 == null;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num7 = Share(want);
		bool flag8 = num7 < 0f;
		object obj16 = !flag8;
		bool flag9 = num7 == 0f;
		object obj17 = ~obj16;
		object obj18 = obj17 | flag9;
		OutOfMemoryException ex = null;
		object obj19 = 0;
		ParticleSystem.CollisionModule collisionModule = (ParticleSystem.CollisionModule)0;
		ParticleSystem.SizeOverLifetimeModule sizeOverLifetimeModule = (ParticleSystem.SizeOverLifetimeModule)0;
		ParticleSystem.ShapeModule shapeModule = (ParticleSystem.ShapeModule)0;
		ParticleSystem.EmissionModule emissionModule = (ParticleSystem.EmissionModule)0;
		ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)0;
		double num8 = 1142292480.0;
		float num9 = seconds;
		float num10 = fine;
		string text;
		Material material2;
		Vector3 forward = default;
		float num17;
		int num18;
		ParticleSystemStopBehavior particleSystemStopBehavior;
		int num19 = default;
		float num23;
		Keyframe keyframe;
		double num33;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D58]");
			object obj21 = 0;
			text = (string)obj21;
			GameObject gameObject = default;
			gameObject._002Ector((string)obj21);
			bool flag10 = (object)gameObject == null;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = (ParticleSystem.SizeOverLifetimeModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			num8 = 1142292480.0;
			material2 = null;
			num9 = seconds;
			num10 = fine;
			if (flag10)
			{
				goto IL_15c1;
			}
			Transform transform = gameObject.transform;
			bool flag11 = (object)transform == null;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = (ParticleSystem.SizeOverLifetimeModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			num8 = 1142292480.0;
			material2 = null;
			text = null;
			num9 = seconds;
			num10 = fine;
			if (flag11)
			{
				goto IL_15cf;
			}
			transform.SetParent(at, worldPositionStays: false);
			Transform transform2 = gameObject.transform;
			float num11 = seconds * seconds;
			float num12 = fine * fine;
			float num13 = num11 + num12;
			double num15 = default;
			double num14 = num15 * num15;
			float num16 = (float)num14 + num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			if (num16 > 0f)
			{
				forward = (Vector3)seconds;
			}
			else
			{
				void* value = ((IntPtr*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1777 @ X8_v81 (System.Void*)+A0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1767 @ X8_v82+18]");
				forward = (Vector3)0;
			}
			void* value2 = ((IntPtr*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1769 @ X8_v35 (System.Void*)+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ X8_v36+18]");
			num17 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ X8_v36+20]");
			num8 = 0.0;
			Vector3 upwards = default;
			Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
			bool flag12 = (object)transform2 == null;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = (ParticleSystem.SizeOverLifetimeModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			ParticleSystem.Burst burst2 = (ParticleSystem.Burst)upwards;
			num18 = 0;
			material2 = null;
			text = (string)(&upwards);
			num9 = seconds;
			num10 = fine;
			if (flag12)
			{
				goto IL_15ed;
			}
			transform2.rotation = (Quaternion)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD0]");
			object obj24 = 0;
			text = (string)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			Transform transform3 = default;
			bool flag13 = (object)transform3 == null;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = (ParticleSystem.SizeOverLifetimeModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			burst2 = (ParticleSystem.Burst)upwards;
			num18 = 0;
			particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
			num9 = seconds;
			num10 = fine;
			if (flag13)
			{
				goto IL_1603;
			}
			((ParticleSystem)(object)transform3).Stop(true, (ParticleSystemStopBehavior)0);
			object obj25 = obj;
			object obj26 = num19 - 1;
			bool flag14 = (nint)obj26 < 0;
			bool flag15 = obj26 == null;
			int num20 = num19 ^ 1;
			int num21 = num19 ^ obj26;
			int num22 = num20 & num21;
			bool flag16 = num22 < 0;
			bool flag17 = flag14 == flag16;
			obj12 = !flag15;
			object obj27 = flag17 & obj12;
			obj14 = ~obj27;
			int count = ((obj14 != null) ? 1 : num19);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2514 @ X0_v63+E4]");
			bool flag18 = (nint)0 == 0;
			object obj28 = !flag18;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationCurve animationCurve = Pulses(count);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C98]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			AnimationCurve animationCurve2 = default;
			animationCurve2._002Ector();
			bool flag19 = (object)animationCurve == null;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = (ParticleSystem.SizeOverLifetimeModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			burst2 = (ParticleSystem.Burst)upwards;
			num18 = 0;
			particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
			text = null;
			num9 = seconds;
			num10 = fine;
			if (flag19)
			{
				goto IL_1611;
			}
			Keyframe[] keys = animationCurve.keys;
			bool flag20 = keys == null;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = (ParticleSystem.SizeOverLifetimeModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			burst2 = (ParticleSystem.Burst)upwards;
			num18 = 0;
			particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
			text = null;
			num9 = seconds;
			num10 = fine;
			if (flag20)
			{
				goto IL_161f;
			}
			if (keys.Length >= 1)
			{
				object obj30 = keys.Length & 0xFFFFFFFFL;
				object obj31 = keys + 36;
				object obj32 = 0;
				num23 = (float)num8;
				Material material3 = null;
				string text2 = null;
				object obj35 = default;
				object obj37 = default;
				float num25 = default;
				while (true)
				{
					bool flag21 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30);
					object obj33 = !flag21;
					keyframe = (Keyframe)forward;
					vector = (Vector3)text2;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X28_v20-4]");
						num17 = 0f;
						num23 = (float)obj31 * 0.5f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X28_v20-4]");
						Keyframe keyframe2 = new Keyframe(0f, num23);
						if ((object)animationCurve2 != null)
						{
							object obj34 = (object)(&obj35);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2648 @ X8_v77+FF]");
							num23 = 0f;
							object obj36 = (object)(&obj37);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2648 @ X8_v77+FF]");
							_ = 0;
							int num24 = animationCurve2.AddKey((Keyframe)(&num25));
							obj30 = keys.Length;
							object obj38 = obj32 + 1;
							object obj39 = obj31 + 28;
							bool flag22 = (nint)obj38 < keys.Length;
							num25 = (float)keyframe2;
							num25 = (float)keyframe2;
							obj31 = obj39;
							obj32 = obj38;
							forward = (Vector3)keyframe2;
							material3 = null;
							num17 = (float)keyframe2;
							text2 = (string)(&num25);
							if (!flag22)
							{
								break;
							}
							continue;
						}
						NullReferenceException ex2 = new NullReferenceException();
						keyframe = keyframe2;
						vector = (Vector3)0;
					}
					IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
					ex = null;
					obj19 = 0;
					collisionModule = (ParticleSystem.CollisionModule)0;
					sizeOverLifetimeModule = (ParticleSystem.SizeOverLifetimeModule)0;
					shapeModule = (ParticleSystem.ShapeModule)0;
					emissionModule = (ParticleSystem.EmissionModule)0;
					mainModule = (ParticleSystem.MainModule)0;
					num19 = 0;
					material = material3;
					num7 = num17;
					goto IL_1584;
				}
			}
			ParticleSystem.MainModule main = ((ParticleSystem)(object)transform3).main;
			mainModule.duration = num3;
			mainModule.loop = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF4]");
			ParticleSystem.MinMaxCurve minMaxCurve = new ParticleSystem.MinMaxCurve(num26, 0f);
			ParticleSystem.MinMaxCurve minMaxCurve2 = default;
			mainModule.startLifetime = (ParticleSystem.MinMaxCurve)(&minMaxCurve2);
			ParticleSystem.MinMaxCurve minMaxCurve3 = new ParticleSystem.MinMaxCurve(4.5f, animationCurve2, animationCurve);
			ParticleSystem.MinMaxCurve minMaxCurve4 = default;
			mainModule.startSpeed = (ParticleSystem.MinMaxCurve)(&minMaxCurve4);
			mainModule.startSize3D = true;
			float num27 = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AADC]");
			float min = num27 * 0f;
			float num28 = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9A8]");
			num9 = num28 * 0f;
			ParticleSystem.MinMaxCurve minMaxCurve5 = new ParticleSystem.MinMaxCurve(min, num9);
			ParticleSystem.MinMaxCurve minMaxCurve6 = default;
			mainModule.startSizeX = (ParticleSystem.MinMaxCurve)(&minMaxCurve6);
			ParticleSystem.MinMaxCurve minMaxCurve7 = new ParticleSystem.MinMaxCurve(min, num9);
			ParticleSystem.MinMaxCurve minMaxCurve8 = default;
			mainModule.startSizeY = (ParticleSystem.MinMaxCurve)(&minMaxCurve8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			num10 = 0f;
			float num29 = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D0]");
			float min2 = num29 * 0f;
			float num30 = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			float max = num30 * 0f;
			ParticleSystem.MinMaxCurve minMaxCurve9 = new ParticleSystem.MinMaxCurve(min2, max);
			ParticleSystem.MinMaxCurve minMaxCurve10 = default;
			mainModule.startSizeZ = (ParticleSystem.MinMaxCurve)(&minMaxCurve10);
			object obj40 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2719 @ X0_v88+E4]");
			bool flag23 = (nint)0 == 0;
			object obj41 = !flag23;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj40 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2719 @ X0_v88+A0]");
			object obj42 = 0;
			ParticleSystem.MinMaxGradient minMaxGradient = new ParticleSystem.MinMaxGradient((Color)0, (Color)0);
			ParticleSystem.MinMaxGradient minMaxGradient2 = default;
			mainModule.startColor = (ParticleSystem.MinMaxGradient)(&minMaxGradient2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
			ParticleSystem.MinMaxCurve minMaxCurve11 = 0f;
			object obj43 = default;
			mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj43);
			mainModule.simulationSpace = (ParticleSystemSimulationSpace)1;
			float n = num7 * 1.1422925E+09f;
			short maxParticles = Some(n);
			mainModule.maxParticles = maxParticles;
			ParticleSystem.EmissionModule emission = ((ParticleSystem)(object)transform3).emission;
			object obj44 = obj7 * 1133248512;
			object obj45 = obj44 * obj7;
			float multiplier = (float)obj45 * num7;
			ParticleSystem.MinMaxCurve minMaxCurve12 = new ParticleSystem.MinMaxCurve(multiplier, animationCurve);
			ParticleSystem.MinMaxCurve minMaxCurve13 = default;
			emissionModule.rateOverTime = (ParticleSystem.MinMaxCurve)(&minMaxCurve13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E50]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			float n2 = num7 * (float)material;
			short num31 = Some(n2);
			burst2 = new ParticleSystem.Burst(0f, num31);
			int num32 = default;
			bool flag24 = num32 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2721 @ X8_v46+28]");
			obj7 = 0;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = (ParticleSystem.SizeOverLifetimeModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = emission;
			num15 = 0.0;
			obj5 = 17276928;
			forward = (Vector3)minMaxGradient;
			num33 = 0.0;
			num18 = 0;
			particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
			num17 = 0f;
			text = (string)num31;
			if (flag24)
			{
				goto IL_1635;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2775 @ X0_v102 (System.Int32)+18]");
			bool flag25 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2721 @ X8_v46+28]");
			obj7 = 0;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = (ParticleSystem.SizeOverLifetimeModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = emission;
			num15 = 0.0;
			obj5 = 17276928;
			forward = (Vector3)minMaxGradient;
			num33 = 0.0;
			num18 = 0;
			particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
			num17 = 0f;
			text = (string)num31;
			if (flag25)
			{
				goto IL_1643;
			}
			_ = 0;
			_ = 0;
			_ = 0;
			emissionModule.SetBursts((ParticleSystem.Burst[])num32);
			ParticleSystem.ShapeModule shape = ((ParticleSystem)(object)transform3).shape;
			shapeModule.shapeType = (ParticleSystemShapeType)4;
			shapeModule.angle = 18f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D8]");
			shapeModule.radius = 0f;
			ParticleSystem.SizeOverLifetimeModule sizeOverLifetime = ((ParticleSystem)(object)transform3).sizeOverLifetime;
			sizeOverLifetimeModule.enabled = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CA8]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Keyframe keyframe3 = new Keyframe(0f, 1f);
			int num34 = default;
			bool flag26 = num34 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2721 @ X8_v46+28]");
			obj7 = 0;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = sizeOverLifetime;
			num15 = 0.0;
			obj5 = 17276928;
			forward = (Vector3)minMaxGradient;
			num33 = 1.0;
			num18 = 0;
			particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
			num17 = 0f;
			text = null;
			if (flag26)
			{
				goto IL_1651;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2807 @ X0_v115 (System.Int32)+18]");
			bool flag27 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2721 @ X8_v46+28]");
			obj7 = 0;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = sizeOverLifetime;
			num15 = 0.0;
			obj5 = 17276928;
			forward = (Vector3)minMaxGradient;
			num33 = 1.0;
			num18 = 0;
			particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
			num17 = 0f;
			text = null;
			if (flag27)
			{
				goto IL_165f;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num17 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			Keyframe keyframe4 = new Keyframe(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2807 @ X0_v115 (System.Int32)+18]");
			object obj48 = 0 & 0xFFFFFFFEL;
			bool flag28 = obj48 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2721 @ X8_v46+28]");
			obj7 = 0;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = sizeOverLifetime;
			num15 = 0.0;
			obj5 = 0;
			forward = (Vector3)minMaxGradient;
			num33 = 1.0;
			num18 = 0;
			particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
			text = null;
			if (flag28)
			{
				goto IL_166d;
			}
			_ = 0;
			_ = 0;
			Keyframe keyframe5 = new Keyframe(1f, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2807 @ X0_v115 (System.Int32)+18]");
			bool flag29 = (nint)0 < (nint)2;
			object obj49 = !flag29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2807 @ X0_v115 (System.Int32)+18]");
			object obj50 = -2;
			bool flag30 = obj50 == null;
			object obj51 = ~obj49;
			object obj52 = obj51 | flag30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2721 @ X8_v46+28]");
			obj7 = 0;
			ex = null;
			obj19 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			sizeOverLifetimeModule = sizeOverLifetime;
			num15 = 0.0;
			obj5 = 0;
			forward = (Vector3)minMaxGradient;
			num33 = 0.0;
			num18 = 0;
			particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
			num17 = 1f;
			text = null;
			if (obj52 != null)
			{
				goto IL_167b;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			AnimationCurve animationCurve3 = default;
			animationCurve3._002Ector((Keyframe[])num34);
			ParticleSystem.MinMaxCurve minMaxCurve14 = new ParticleSystem.MinMaxCurve(1f, animationCurve3);
			ParticleSystem.MinMaxCurve minMaxCurve15 = default;
			sizeOverLifetimeModule.size = (ParticleSystem.MinMaxCurve)(&minMaxCurve15);
			ParticleSystem.CollisionModule collision = ((ParticleSystem)(object)transform3).collision;
			collisionModule.enabled = true;
			collisionModule.type = (ParticleSystemCollisionType)1;
			collisionModule.mode = (ParticleSystemCollisionMode)0;
			collisionModule.quality = (ParticleSystemCollisionQuality)1;
			LayerMask collidesWith = -1797;
			collisionModule.collidesWith = collidesWith;
			collisionModule.enableDynamicColliders = false;
			if ((double)num7 < 1.0)
			{
				collisionModule.quality = (ParticleSystemCollisionQuality)2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			ParticleSystem.MinMaxCurve minMaxCurve16 = 0f;
			object obj53 = default;
			collisionModule.dampen = (ParticleSystem.MinMaxCurve)(&obj53);
			ParticleSystem.MinMaxCurve minMaxCurve17 = num10;
			object obj54 = default;
			collisionModule.bounce = (ParticleSystem.MinMaxCurve)(&obj54);
			ParticleSystem.MinMaxCurve minMaxCurve18 = 0f;
			Vector3 vector2 = default;
			collisionModule.lifetimeLoss = (ParticleSystem.MinMaxCurve)(&vector2);
			collisionModule.radiusScale = 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD8]");
			object obj55 = 0;
			vector = (Vector3)obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			int num35 = default;
			bool flag31 = num35 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2721 @ X8_v46+28]");
			obj7 = 0;
			ex = null;
			obj19 = 0;
			num15 = 0.0;
			obj5 = 0;
			num33 = 0.0;
			num18 = 0;
			material = null;
			num17 = 0.5f;
			if (flag31)
			{
				goto IL_1699;
			}
			((ParticleSystemRenderer)num35).renderMode = (ParticleSystemRenderMode)4;
			((ParticleSystemRenderer)num35).alignment = (ParticleSystemRenderSpace)4;
			object obj56 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2909 @ X0_v149+E4]");
			bool flag32 = (nint)0 == 0;
			object obj57 = !flag32;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Mesh mesh = Drop();
			((ParticleSystemRenderer)num35).mesh = mesh;
			Material sharedMaterial = RoomLit((Material)dir);
			((Renderer)num35).sharedMaterial = sharedMaterial;
			((Renderer)num35).shadowCastingMode = (ShadowCastingMode)0;
			((Renderer)num35).lightProbeUsage = (LightProbeUsage)1;
			((ParticleSystemRenderer)num35).enableGPUInstancing = false;
			((ParticleSystem)(object)transform3).Play();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj58 = 0;
			object obj59 = obj58;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2931 @ X0_v159+E4]");
			bool flag33 = (nint)0 == 0;
			object obj60 = !flag33;
			if (obj60 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num7 = num3 + 2f;
			UnityEngine.Object.Destroy(gameObject, num7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2721 @ X8_v46+28]");
			obj7 = 0;
			ex = null;
			obj19 = 0;
			num15 = 0.0;
			obj5 = 0;
			num8 = 0.0;
			num19 = 0;
			material = null;
			vector = (Vector3)0;
		}
		goto IL_1452;
		IL_166d:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		goto IL_167b;
		IL_167b:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		material = (Material)particleSystemStopBehavior;
		vector = (Vector3)text;
		goto IL_1699;
		IL_15ed:
		NullReferenceException ex6 = new NullReferenceException();
		particleSystemStopBehavior = (ParticleSystemStopBehavior)material2;
		goto IL_1603;
		IL_161f:
		NullReferenceException ex7 = new NullReferenceException();
		num33 = num8;
		goto IL_1635;
		IL_1611:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_161f;
		IL_1452:
		IntPtr intPtr = default;
		object obj61 = (object)(&intPtr);
		if (obj61 != null)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj61);
			vector = (Vector3)0;
		}
		bool flag34 = ex == null;
		object obj62 = !flag34;
		keyframe = (Keyframe)forward;
		num23 = (float)num8;
		if (obj62 != null)
		{
			goto IL_1584;
		}
		bool flag35 = obj19 == null;
		object obj63 = !flag35;
		text = (string)vector;
		OutOfMemoryException ex9 = ex;
		if (obj63 == null)
		{
			return;
		}
		goto IL_15aa;
		IL_1643:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		goto IL_1651;
		IL_1651:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_165f;
		IL_1635:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_1643;
		IL_1584:
		ex9 = new OutOfMemoryException();
		forward = (Vector3)keyframe;
		num8 = num23;
		text = (string)vector;
		goto IL_15aa;
		IL_15cf:
		NullReferenceException ex13 = new NullReferenceException();
		num18 = num19;
		num17 = num7;
		goto IL_15ed;
		IL_15c1:
		NullReferenceException ex14 = new NullReferenceException();
		goto IL_15cf;
		IL_1603:
		NullReferenceException ex15 = new NullReferenceException();
		goto IL_1611;
		IL_165f:
		IndexOutOfRangeException ex16 = new IndexOutOfRangeException();
		goto IL_166d;
		IL_1699:
		NullReferenceException ex17 = new NullReferenceException();
		if (vector == (Vector3)(object)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj19 = 1;
			num8 = num33;
			num19 = num18;
			num7 = num17;
		}
		else
		{
			if (vector != (Vector3)(object)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj64 = default;
			ex = (OutOfMemoryException)obj64;
			num8 = num33;
			num19 = num18;
			num7 = num17;
		}
		goto IL_1452;
		IL_15aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		material2 = material;
		goto IL_15c1;
	}

	public unsafe static void Burst(Vector3 at, Vector3 dir, Material mat, float size = default(float))
	{
		//IL_0010: Expected Obj, but got I
		//IL_2029: Expected Obj, but got I4
		//IL_24de: Expected Obj, but got I
		//IL_205a: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got VT
		//IL_0076: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_00fc: Expected VT, but got I4
		//IL_0105: Expected VT, but got I4
		//IL_010e: Expected VT, but got I4
		//IL_0119: Expected VT, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_013a: Expected F4, but got I4
		//IL_0148: Expected VT, but got I4
		//IL_1dc5: Expected Obj, but got Ref
		//IL_1e13: Expected Obj, but got I4
		//IL_01d1: Expected F4, but got I
		//IL_01e1: Invalid comparison between F4 and I
		//IL_1deb: Expected I, but got Obj
		//IL_1df4: Expected VT, but got I4
		//IL_2092: Expected Obj, but got I4
		//IL_1e3b: Expected Obj, but got I4
		//IL_0251: Invalid comparison between F4 and I4
		//IL_0262: Expected Obj, but got I4
		//IL_026b: Invalid comparison between F4 and I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0295: Expected Obj, but got I4
		//IL_029e: Expected VT, but got I4
		//IL_02a7: Expected VT, but got I4
		//IL_02b0: Expected VT, but got I4
		//IL_02bb: Expected VT, but got I4
		//IL_02c3: Expected Obj, but got I
		//IL_02e1: Expected VT, but got I4
		//IL_20b0: Expected Obj, but got I
		//IL_20c8: Expected Obj, but got I
		//IL_20d8: Expected F4, but got I
		//IL_20e8: Expected F4, but got I
		//IL_20f8: Expected F4, but got I
		//IL_0307: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I4
		//IL_0359: Expected VT, but got I4
		//IL_0362: Expected VT, but got I4
		//IL_036b: Expected VT, but got I4
		//IL_0376: Expected VT, but got I4
		//IL_037e: Expected Obj, but got I
		//IL_039b: Expected VT, but got Obj
		//IL_03a3: Expected I, but got Obj
		//IL_03e3: Expected Obj, but got I4
		//IL_03ec: Expected VT, but got I4
		//IL_03f5: Expected VT, but got I4
		//IL_03fe: Expected VT, but got I4
		//IL_0409: Expected VT, but got I4
		//IL_0411: Expected Obj, but got I
		//IL_042f: Expected VT, but got I4
		//IL_0437: Expected I, but got Obj
		//IL_045b: Expected VT, but got I4
		//IL_0497: Expected Obj, but got I4
		//IL_2116: Expected Obj, but got I
		//IL_2140: Expected Obj, but got I4
		//IL_050c: Invalid comparison between F4 and I4
		//IL_21ca: Expected Obj, but got I4
		//IL_0648: Expected Obj, but got I
		//IL_0658: Expected F4, but got I
		//IL_0675: Expected Obj, but got F4
		//IL_0675: Expected VT, but got Obj
		//IL_0696: Expected Obj, but got I4
		//IL_069f: Expected VT, but got I4
		//IL_06a8: Expected VT, but got I4
		//IL_06b1: Expected VT, but got I4
		//IL_06bc: Expected VT, but got I4
		//IL_06c4: Expected Obj, but got F4
		//IL_06fd: Expected VT, but got Obj
		//IL_0705: Expected I, but got Obj
		//IL_2166: Unknown result type (might be due to invalid IL or missing references)
		//IL_216b: Expected Obj, but got Unknown
		//IL_2185: Expected Obj, but got I4
		//IL_1f5a: Invalid comparison between VT and I4
		//IL_1fb1: Invalid comparison between VT and I4
		//IL_0746: Expected F4, but got I
		//IL_219b: Expected F4, but got VT
		//IL_05a7: Expected F4, but got VT
		//IL_0758: Expected VT, but got Ref
		//IL_0776: Expected F4, but got I
		//IL_1f93: Expected Obj, but got I4
		//IL_0788: Expected VT, but got Ref
		//IL_07a9: Expected F4, but got I
		//IL_07a9: Expected F4, but got I
		//IL_07bb: Expected VT, but got Ref
		//IL_07c8: Expected VT, but got Ref
		//IL_07ee: Expected F4, but got I
		//IL_07ee: Expected F4, but got I
		//IL_07fb: Expected VT, but got Ref
		//IL_0811: Expected F4, but got I
		//IL_0822: Expected VT, but got Ref
		//IL_0854: Expected VT, but got Ref
		//IL_0864: Expected Obj, but got I
		//IL_08c4: Expected Obj, but got I4
		//IL_08cd: Expected VT, but got I4
		//IL_08d6: Expected VT, but got I4
		//IL_0904: Expected Obj, but got F4
		//IL_092e: Expected F4, but got I4
		//IL_093b: Expected VT, but got I4
		//IL_0943: Expected I, but got Obj
		//IL_0978: Expected Obj, but got I4
		//IL_0981: Expected VT, but got I4
		//IL_098a: Expected VT, but got I4
		//IL_09b8: Expected Obj, but got F4
		//IL_09e2: Expected F4, but got I4
		//IL_09ef: Expected VT, but got I4
		//IL_09f7: Expected I, but got Obj
		//IL_0a51: Expected F4, but got I
		//IL_0a6a: Expected F4, but got I
		//IL_0a83: Expected Obj, but got I8
		//IL_0aa0: Expected Obj, but got I4
		//IL_0aa9: Expected VT, but got I4
		//IL_0ab2: Expected VT, but got I4
		//IL_0aec: Expected F4, but got I4
		//IL_0af4: Expected Obj, but got F4
		//IL_0b05: Expected F4, but got VT
		//IL_0b16: Expected F4, but got I4
		//IL_0b26: Expected F4, but got I
		//IL_0b33: Expected VT, but got I4
		//IL_0b3b: Expected I, but got Obj
		//IL_0bb5: Expected F4, but got I
		//IL_0c17: Expected I4, but got I8
		//IL_0c4c: Expected F4, but got I
		//IL_0c62: Expected VT, but got Ref
		//IL_0c73: Expected F4, but got I
		//IL_0c89: Expected VT, but got Ref
		//IL_0ca9: Expected VT, but got Ref
		//IL_0cd9: Invalid comparison between F4 and I
		//IL_0ced: Expected Obj, but got I4
		//IL_0d2f: Expected F4, but got I4
		//IL_0d37: Expected Obj, but got F4
		//IL_0d49: Expected F4, but got I4
		//IL_0d69: Expected F4, but got I
		//IL_0d77: Expected VT, but got I4
		//IL_0d7f: Expected I, but got Obj
		//IL_2202: Expected Obj, but got I4
		//IL_0dc4: Invalid comparison between F4 and I4
		//IL_228c: Expected Obj, but got I4
		//IL_0f00: Expected F4, but got I
		//IL_0f1d: Expected Obj, but got F4
		//IL_0f1d: Expected VT, but got Obj
		//IL_0f3e: Expected Obj, but got I4
		//IL_0f7f: Expected Obj, but got F4
		//IL_0fc0: Expected VT, but got Obj
		//IL_0fc8: Expected I, but got Obj
		//IL_2228: Unknown result type (might be due to invalid IL or missing references)
		//IL_222d: Expected Obj, but got Unknown
		//IL_2247: Expected Obj, but got I4
		//IL_1001: Expected F4, but got I
		//IL_225d: Expected F4, but got VT
		//IL_0e5f: Expected F4, but got VT
		//IL_1013: Expected VT, but got Ref
		//IL_1040: Expected VT, but got Ref
		//IL_1061: Expected F4, but got I
		//IL_1061: Expected F4, but got I
		//IL_1073: Expected VT, but got Ref
		//IL_1080: Expected VT, but got Ref
		//IL_10a6: Expected F4, but got I
		//IL_10a6: Expected F4, but got I
		//IL_10b3: Expected VT, but got Ref
		//IL_10d7: Expected VT, but got Ref
		//IL_1109: Expected VT, but got Ref
		//IL_22c4: Expected Obj, but got I4
		//IL_113f: Invalid comparison between F4 and I4
		//IL_232e: Expected I4, but got F4
		//IL_234b: Expected Obj, but got I4
		//IL_2383: Expected Obj, but got F4
		//IL_23ad: Expected F4, but got I4
		//IL_23b6: Expected F4, but got I4
		//IL_23c3: Expected VT, but got F4
		//IL_22ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ef: Expected Obj, but got Unknown
		//IL_2309: Expected Obj, but got I4
		//IL_124f: Expected Obj, but got I4
		//IL_1287: Expected Obj, but got F4
		//IL_12b1: Expected F4, but got I4
		//IL_12ba: Expected F4, but got I4
		//IL_12c7: Expected VT, but got F4
		//IL_1301: Expected Obj, but got I
		//IL_1344: Expected F4, but got I
		//IL_1359: Expected F4, but got I
		//IL_139a: Expected Obj, but got I4
		//IL_13e2: Expected Obj, but got I4
		//IL_140a: Expected Obj, but got F4
		//IL_1424: Expected F4, but got I4
		//IL_1434: Expected F4, but got VT
		//IL_1442: Expected VT, but got I4
		//IL_1482: Expected Obj, but got I4
		//IL_14c5: Expected Obj, but got I4
		//IL_14ed: Expected Obj, but got F4
		//IL_1507: Expected F4, but got I4
		//IL_1517: Expected F4, but got VT
		//IL_152d: Expected VT, but got I4
		//IL_156e: Expected Obj, but got I4
		//IL_15bb: Expected Obj, but got I4
		//IL_15e2: Expected Obj, but got F4
		//IL_15fc: Expected F4, but got I4
		//IL_160c: Expected F4, but got VT
		//IL_161a: Expected VT, but got I4
		//IL_165a: Expected Obj, but got I4
		//IL_169d: Expected Obj, but got I4
		//IL_16c4: Expected Obj, but got F4
		//IL_16de: Expected F4, but got I4
		//IL_16ee: Expected F4, but got VT
		//IL_1704: Expected VT, but got I4
		//IL_1740: Expected Obj, but got I4
		//IL_1767: Expected Obj, but got F4
		//IL_1781: Expected F4, but got I4
		//IL_1791: Expected F4, but got VT
		//IL_17a7: Expected VT, but got I4
		//IL_17ca: Expected I, but got Obj
		//IL_2403: Expected Obj, but got I4
		//IL_1805: Invalid comparison between F4 and I4
		//IL_2473: Expected Obj, but got I
		//IL_247b: Expected I, but got Obj
		//IL_249d: Expected Obj, but got I4
		//IL_1941: Expected F4, but got I
		//IL_1951: Expected Obj, but got I
		//IL_197c: Expected Obj, but got F4
		//IL_197c: Expected VT, but got I
		//IL_197c: Expected VT, but got Obj
		//IL_2429: Unknown result type (might be due to invalid IL or missing references)
		//IL_242e: Expected Obj, but got Unknown
		//IL_2448: Expected Obj, but got I4
		//IL_19a7: Expected Obj, but got I4
		//IL_1a08: Expected Obj, but got F4
		//IL_1a10: Expected VT, but got I
		//IL_245e: Expected F4, but got VT
		//IL_18a0: Expected F4, but got VT
		//IL_1a48: Expected Obj, but got I4
		//IL_1a95: Expected Obj, but got I4
		//IL_1afb: Expected VT, but got I4
		//IL_1b33: Expected Obj, but got I4
		//IL_1b76: Expected Obj, but got I4
		//IL_1bdc: Expected VT, but got I4
		//IL_1c10: Expected Obj, but got I4
		//IL_1c76: Expected VT, but got I4
		//IL_1c91: Expected I, but got Obj
		//IL_1cb7: Expected I, but got Obj
		//IL_1cd9: Expected Obj, but got I4
		//IL_1d06: Expected F4, but got I
		//IL_1d16: Expected Obj, but got I
		//IL_1d41: Expected VT, but got I
		//IL_1d41: Expected VT, but got Obj
		//IL_1d4f: Expected Obj, but got I4
		//IL_1db8: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v4+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v4+10]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Material material = RoomLit((Material)at);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = material == null;
		bool flag5 = !flag4;
		object obj9 = !flag5;
		OutOfMemoryException ex = null;
		object obj10 = 0;
		ParticleSystem.CollisionModule collisionModule = (ParticleSystem.CollisionModule)0;
		ParticleSystem.ShapeModule shapeModule = (ParticleSystem.ShapeModule)0;
		ParticleSystem.EmissionModule emissionModule = (ParticleSystem.EmissionModule)0;
		ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)0;
		IntPtr intPtr = default;
		Material material2 = (Material)(nint)intPtr;
		float num3 = default;
		float num2 = num3;
		float num5 = default;
		float num4 = num5;
		float num6 = 0f;
		Mesh mesh = null;
		Vector3 vector = (Vector3)0;
		float num8 = default;
		float num7 = num8;
		float num10 = default;
		float num9 = num10;
		float num12 = default;
		float num11 = num12;
		float num14 = default;
		float num13 = num14;
		Transform transform;
		object obj23;
		float num22;
		float num23;
		double num24;
		ParticleSystem.Burst burst;
		double num27;
		float num25;
		ParticleSystem.Burst burst2 = default;
		float num21;
		float num26;
		if (obj9 == null)
		{
			float num15 = num8 * num8;
			float num16 = num10 * num10;
			float num17 = num15 + num16;
			float num18 = num12 * num12;
			float num19 = num18 + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			num4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			bool flag6 = !(num19 < 0f);
			num7 = num8;
			num9 = num10;
			num11 = num12;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v113+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v114+18]");
				num7 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v114+1C]");
				num9 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v114+20]");
				num11 = 0f;
				num = 109891584;
			}
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v61+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num20 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFCC]");
			float want = num20 * 0f;
			num6 = Share(want);
			bool flag8 = num6 < 0f;
			object obj16 = !flag8;
			bool flag9 = num6 == 0f;
			object obj17 = ~obj16;
			object obj18 = obj17 | flag9;
			ex = null;
			obj10 = 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			material2 = (Material)(nint)intPtr;
			num2 = num3;
			num21 = num6;
			mesh = null;
			vector = (Vector3)0;
			num13 = num14;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E58]");
				object obj20 = 0;
				GameObject gameObject = default;
				gameObject._002Ector((string)obj20);
				bool flag10 = (object)gameObject == null;
				ex = null;
				obj10 = 0;
				collisionModule = (ParticleSystem.CollisionModule)0;
				shapeModule = (ParticleSystem.ShapeModule)0;
				emissionModule = (ParticleSystem.EmissionModule)0;
				mainModule = (ParticleSystem.MainModule)0;
				material2 = (Material)(nint)intPtr;
				num2 = num3;
				num21 = num6;
				mesh = null;
				vector = (Vector3)obj20;
				num = (nint)gameObject;
				num13 = num14;
				if (flag10)
				{
					goto IL_1e6f;
				}
				transform = gameObject.transform;
				bool flag11 = (object)transform == null;
				ex = null;
				obj10 = 0;
				collisionModule = (ParticleSystem.CollisionModule)0;
				shapeModule = (ParticleSystem.ShapeModule)0;
				emissionModule = (ParticleSystem.EmissionModule)0;
				mainModule = (ParticleSystem.MainModule)0;
				material2 = (Material)(nint)intPtr;
				num2 = num3;
				num21 = num6;
				mesh = null;
				vector = (Vector3)0;
				num = (nint)transform;
				num13 = num14;
				if (flag11)
				{
					goto IL_1e7d;
				}
				transform.position = (Vector3)0;
				GameObject gameObject2 = transform.gameObject;
				object obj21 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ X0_v69+E4]");
				bool flag12 = (nint)0 == 0;
				object obj22 = !flag12;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(gameObject2, 5f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				obj23 = 0;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1972 @ X0_v73+E4]");
				bool flag13 = (nint)0 == 0;
				object obj25 = !flag13;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				num22 = num6 * num14;
				num23 = num22 * 1.1314135E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
				if (num23 < 0f)
				{
					if ((double)num23 == -0.5)
					{
						num24 = -1.0;
						burst = burst2;
						goto IL_214e;
					}
					num25 = num23 + -0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					num26 = num23;
					num27 = -0.5;
				}
				else
				{
					if ((double)num23 == 0.5)
					{
						num24 = 1.0;
						burst = burst2;
						goto IL_214e;
					}
					num25 = num23 + 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					num26 = num23;
					num27 = 0.5;
				}
				goto IL_21a0;
			}
		}
		goto IL_1dbd;
		IL_2210:
		ParticleSystem.Burst burst3;
		double num29;
		double num28 = (double)burst3 + num29;
		object obj26 = burst3 & 1;
		bool flag14 = obj26 == null;
		object obj27 = !flag14;
		float num30 = ((obj27 != null) ? ((float)num28) : ((float)burst3));
		float num31 = (float)burst3;
		goto IL_2262;
		IL_1f43:
		NullReferenceException ex2 = new NullReferenceException();
		Mesh mesh2 = default;
		ParticleSystem particleSystem;
		float num32;
		if (vector == (Vector3)(object)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj10 = 1;
			mesh2 = (Mesh)(object)particleSystem;
			num6 = num32;
		}
		else
		{
			if (vector != (Vector3)(object)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj28 = default;
			ex = (OutOfMemoryException)obj28;
			mesh2 = (Mesh)(object)particleSystem;
			num6 = num32;
		}
		goto IL_1dbd;
		IL_2411:
		ParticleSystem.Burst burst4;
		double num34;
		double num33 = (double)burst4 + num34;
		object obj29 = burst4 & 1;
		bool flag15 = obj29 == null;
		obj27 = !flag15;
		num21 = ((obj27 != null) ? ((float)num33) : ((float)burst4));
		float num35 = (float)burst4;
		goto IL_2463;
		IL_214e:
		num27 = (double)burst + num24;
		object obj30 = burst & 1;
		bool flag16 = obj30 == null;
		obj27 = !flag16;
		num26 = ((obj27 != null) ? ((float)num27) : ((float)burst));
		num25 = (float)burst;
		goto IL_21a0;
		IL_2262:
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2762 @ X0_v138+E4]");
		bool flag17 = (nint)0 == 0;
		object obj32 = !flag17;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		num8 = 0f;
		object name;
		int num36 = default;
		ParticleSystem particleSystem2 = Particles((string)name, transform, (Vector3)material, (Material)num30, num7, num36);
		bool flag18 = (object)particleSystem2 == null;
		ex = null;
		obj10 = 0;
		ParticleSystem.ShapeModule shape;
		shapeModule = shape;
		ParticleSystem.Burst burst5;
		ParticleSystem.MinMaxCurve minMaxCurve = (ParticleSystem.MinMaxCurve)burst5;
		ParticleSystem.Burst[] array2 = default;
		ParticleSystem.Burst[] array = array2;
		ParticleSystem.EmissionModule emission;
		emissionModule = emission;
		ParticleSystem.MainModule main;
		mainModule = main;
		material2 = (Material)num30;
		num26 = num30;
		ParticleSystem particleSystem3;
		mesh2 = (Mesh)(object)particleSystem3;
		num2 = num11;
		num21 = num13;
		num4 = num9;
		num32 = num7;
		mesh = (Mesh)(object)material;
		vector = (Vector3)transform;
		num = (nint)transform;
		if (flag18)
		{
			goto IL_1ecb;
		}
		ParticleSystem.MainModule main2 = particleSystem2.main;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		minMaxCurve = new ParticleSystem.MinMaxCurve(0f, 0.5f);
		ParticleSystem.MinMaxCurve minMaxCurve2 = default;
		mainModule.startLifetime = (ParticleSystem.MinMaxCurve)(&minMaxCurve2);
		ParticleSystem.MinMaxCurve minMaxCurve3 = new ParticleSystem.MinMaxCurve(1f, 4f);
		ParticleSystem.MinMaxCurve minMaxCurve4 = default;
		mainModule.startSpeed = (ParticleSystem.MinMaxCurve)(&minMaxCurve4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD88]");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB0]");
		ParticleSystem.MinMaxCurve minMaxCurve5 = new ParticleSystem.MinMaxCurve(num37, 0f);
		ParticleSystem.MinMaxCurve minMaxCurve6 = default;
		mainModule.startSizeY = (ParticleSystem.MinMaxCurve)(&minMaxCurve6);
		ParticleSystem.MinMaxCurve minMaxCurve7 = default;
		mainModule.startSizeX = (ParticleSystem.MinMaxCurve)(&minMaxCurve7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A884]");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A99C]");
		ParticleSystem.MinMaxCurve minMaxCurve8 = new ParticleSystem.MinMaxCurve(num38, 0f);
		ParticleSystem.MinMaxCurve minMaxCurve9 = default;
		mainModule.startSizeZ = (ParticleSystem.MinMaxCurve)(&minMaxCurve9);
		ParticleSystem.MinMaxCurve minMaxCurve10 = 0.5f;
		object obj33 = default;
		mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj33);
		ParticleSystem.EmissionModule emission2 = particleSystem2.emission;
		ParticleSystem.MinMaxCurve minMaxCurve11 = 0f;
		object obj34 = default;
		emissionModule.rateOverTime = (ParticleSystem.MinMaxCurve)(&obj34);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj35 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2862 @ X0_v164+E4]");
		bool flag19 = (nint)0 == 0;
		object obj36 = !flag19;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num39;
		float num40;
		float num41 = default;
		if (num13 < 0f)
		{
			if ((double)num13 == -0.5)
			{
				num39 = -1.0;
				num40 = num41;
				goto IL_22d2;
			}
			num40 = num13 + -0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if ((double)num13 == 0.5)
			{
				num39 = 1.0;
				num40 = num41;
				goto IL_22d2;
			}
			num40 = num13 + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_231c;
		IL_1f0b:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_1f19;
		IL_1f27:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_1f35;
		IL_21a0:
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2487 @ X0_v77+E4]");
		bool flag20 = (nint)0 == 0;
		object obj38 = !flag20;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D58]");
		name = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		num8 = 0f;
		particleSystem3 = Particles((string)name, transform, (Vector3)material, (Material)num26, num7, num36);
		bool flag21 = (object)particleSystem3 == null;
		ex = null;
		obj10 = 0;
		collisionModule = (ParticleSystem.CollisionModule)0;
		shapeModule = (ParticleSystem.ShapeModule)0;
		emissionModule = (ParticleSystem.EmissionModule)0;
		mainModule = (ParticleSystem.MainModule)0;
		material2 = (Material)num26;
		mesh2 = (Mesh)(object)particleSystem3;
		num2 = num11;
		num21 = num6;
		num4 = num9;
		num32 = num7;
		mesh = (Mesh)(object)material;
		vector = (Vector3)transform;
		num = (nint)transform;
		num13 = num23;
		if (flag21)
		{
			goto IL_1e93;
		}
		main = particleSystem3.main;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		minMaxCurve3 = new ParticleSystem.MinMaxCurve(0f, 1.5f);
		ParticleSystem.MinMaxCurve minMaxCurve12 = default;
		mainModule.startLifetime = (ParticleSystem.MinMaxCurve)(&minMaxCurve12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
		minMaxCurve5 = new ParticleSystem.MinMaxCurve(0f, 7f);
		ParticleSystem.MinMaxCurve minMaxCurve13 = default;
		mainModule.startSpeed = (ParticleSystem.MinMaxCurve)(&minMaxCurve13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A838]");
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8CC]");
		minMaxCurve8 = new ParticleSystem.MinMaxCurve(num42, 0f);
		ParticleSystem.MinMaxCurve minMaxCurve14 = default;
		mainModule.startSizeY = (ParticleSystem.MinMaxCurve)(&minMaxCurve14);
		ParticleSystem.MinMaxCurve minMaxCurve15 = default;
		mainModule.startSizeX = (ParticleSystem.MinMaxCurve)(&minMaxCurve15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB68]");
		ParticleSystem.MinMaxCurve minMaxCurve16 = new ParticleSystem.MinMaxCurve(num43, 0f);
		ParticleSystem.MinMaxCurve minMaxCurve17 = default;
		mainModule.startSizeZ = (ParticleSystem.MinMaxCurve)(&minMaxCurve17);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		ParticleSystem.MinMaxCurve minMaxCurve18 = 0f;
		object obj39 = default;
		mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj39);
		emission = particleSystem3.emission;
		ParticleSystem.MinMaxCurve minMaxCurve19 = 0f;
		object obj40 = default;
		emissionModule.rateOverTime = (ParticleSystem.MinMaxCurve)(&obj40);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E50]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		float n = num22 * 1.1281367E+09f;
		short num44 = Some(n);
		burst2 = new ParticleSystem.Burst(0f, num44);
		bool flag22 = array2 == null;
		ex = null;
		obj10 = 0;
		collisionModule = (ParticleSystem.CollisionModule)0;
		shapeModule = (ParticleSystem.ShapeModule)0;
		array = array2;
		emissionModule = emission;
		mainModule = main;
		material2 = (Material)num26;
		mesh2 = (Mesh)(object)particleSystem3;
		num2 = num11;
		num21 = num6;
		float num45 = default;
		num4 = num45;
		num32 = 0f;
		mesh = null;
		vector = (Vector3)num44;
		num = (nint)transform;
		num13 = num23;
		if (flag22)
		{
			goto IL_1ea1;
		}
		bool flag23 = array2.Length == 0;
		ex = null;
		obj10 = 0;
		collisionModule = (ParticleSystem.CollisionModule)0;
		shapeModule = (ParticleSystem.ShapeModule)0;
		array = array2;
		emissionModule = emission;
		mainModule = main;
		material2 = (Material)num26;
		mesh2 = (Mesh)(object)particleSystem3;
		num2 = num11;
		num21 = num6;
		num4 = num45;
		num32 = 0f;
		mesh = null;
		vector = (Vector3)num44;
		num = (nint)transform;
		num13 = num23;
		if (flag23)
		{
			goto IL_1eaf;
		}
		_ = 0;
		float n2 = num22 * 1.1107041E+09f;
		_ = 0;
		_ = 0;
		short num46 = Some(n2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		num13 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		burst5 = new ParticleSystem.Burst(0f, num46);
		object obj42 = array2.Length & 0xFFFFFFFEL;
		bool flag24 = obj42 == null;
		ex = null;
		obj10 = 0;
		collisionModule = (ParticleSystem.CollisionModule)0;
		shapeModule = (ParticleSystem.ShapeModule)0;
		minMaxCurve = (ParticleSystem.MinMaxCurve)burst5;
		array = array2;
		emissionModule = emission;
		mainModule = main;
		num8 = 0f;
		material2 = (Material)num26;
		mesh2 = (Mesh)(object)particleSystem3;
		num2 = (float)burst2;
		num21 = num6;
		num4 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		num32 = 0f;
		mesh = null;
		vector = (Vector3)num46;
		num = (nint)transform;
		if (flag24)
		{
			goto IL_1ebd;
		}
		_ = 0;
		_ = 0;
		_ = 0;
		emissionModule.SetBursts(array2);
		shape = particleSystem3.shape;
		shapeModule.shapeType = (ParticleSystemShapeType)4;
		shapeModule.angle = 62f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		shapeModule.radius = 0f;
		ParticleSystem.CollisionModule collision = particleSystem3.collision;
		collisionModule.enabled = true;
		collisionModule.type = (ParticleSystemCollisionType)1;
		collisionModule.mode = (ParticleSystemCollisionMode)0;
		collisionModule.quality = (ParticleSystemCollisionQuality)2;
		LayerMask collidesWith = -1797;
		collisionModule.collidesWith = collidesWith;
		collisionModule.enableDynamicColliders = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		ParticleSystem.MinMaxCurve minMaxCurve20 = 0f;
		object obj43 = default;
		collisionModule.dampen = (ParticleSystem.MinMaxCurve)(&obj43);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		ParticleSystem.MinMaxCurve minMaxCurve21 = 0f;
		object obj44 = default;
		collisionModule.bounce = (ParticleSystem.MinMaxCurve)(&obj44);
		ParticleSystem.MinMaxCurve minMaxCurve22 = 0f;
		object obj45 = default;
		collisionModule.lifetimeLoss = (ParticleSystem.MinMaxCurve)(&obj45);
		collisionModule.radiusScale = 0.5f;
		particleSystem3.Play();
		float num47 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		bool flag25 = num47 < 0f;
		ex = null;
		obj10 = 0;
		shapeModule = shape;
		minMaxCurve = (ParticleSystem.MinMaxCurve)burst5;
		array = array2;
		emissionModule = emission;
		mainModule = main;
		num8 = 0f;
		material2 = (Material)num26;
		mesh2 = (Mesh)(object)particleSystem3;
		num2 = 0f;
		num21 = num6;
		float num48 = default;
		num4 = num48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		num6 = 0f;
		mesh = null;
		vector = (Vector3)0;
		num = (nint)transform;
		if (flag25)
		{
			goto IL_1dbd;
		}
		object obj46 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2689 @ X0_v134+E4]");
		bool flag26 = (nint)0 == 0;
		object obj47 = !flag26;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		num13 = num22 * 1.1204035E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		if (num13 < 0f)
		{
			if ((double)num13 == -0.5)
			{
				num29 = -1.0;
				burst3 = burst2;
				goto IL_2210;
			}
			num31 = num13 + -0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num30 = num26;
			num28 = -0.5;
		}
		else
		{
			if ((double)num13 == 0.5)
			{
				num29 = 1.0;
				burst3 = burst2;
				goto IL_2210;
			}
			num31 = num13 + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num30 = num26;
			num28 = 0.5;
		}
		goto IL_2262;
		IL_2463:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		array = (ParticleSystem.Burst[])0;
		nint num49 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3064 @ X0_v196 (Il2CppClass<Burst[]>)+E4]");
		bool flag27 = (nint)0 == 0;
		object obj48 = !flag27;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADD4]");
		num14 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC8]");
		object obj49 = 0;
		GillaGoreAssets gore;
		GillaWounds.Chunks((Vector3)gore.chunk, (Vector3)num, (Mesh)num21, null, num36, size, num5, num3, num7);
		GillaGoreAssets gore2 = Gore;
		bool flag28 = (object)gore2 == null;
		ex = null;
		obj10 = 0;
		num12 = num11;
		num10 = num9;
		num8 = num7;
		material2 = null;
		particleSystem = particleSystem3;
		num2 = num3;
		num4 = num5;
		num32 = size;
		mesh = (Mesh)num21;
		vector = (Vector3)num;
		if (!flag28)
		{
			object obj50 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v96+E4]");
			bool flag29 = (nint)0 == 0;
			object obj51 = !flag29;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag30 = gore2.chipMaterial != null;
			bool flag31 = !flag30;
			ex = null;
			obj10 = 0;
			num12 = num11;
			num10 = num9;
			num8 = num7;
			material2 = null;
			mesh2 = (Mesh)(object)particleSystem3;
			num2 = num3;
			num4 = num5;
			num6 = size;
			mesh = null;
			vector = (Vector3)0;
			if (!flag31)
			{
				object obj52 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3086 @ X0_v204+E4]");
				bool flag32 = (nint)0 == 0;
				object obj53 = !flag32;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaGoreAssets gore3 = Gore;
				bool flag33 = (object)gore3 == null;
				ex = null;
				obj10 = 0;
				num12 = num11;
				num10 = num9;
				num8 = num7;
				material2 = null;
				particleSystem = particleSystem3;
				num2 = num3;
				num4 = num5;
				num32 = size;
				mesh = null;
				vector = (Vector3)0;
				if (flag33)
				{
					goto IL_1f35;
				}
				GillaGoreAssets gore4 = Gore;
				bool flag34 = (object)gore4 == null;
				ex = null;
				obj10 = 0;
				num12 = num11;
				num10 = num9;
				num8 = num7;
				material2 = null;
				particleSystem = particleSystem3;
				num2 = num3;
				num4 = num5;
				num32 = size;
				mesh = null;
				vector = (Vector3)0;
				if (flag34)
				{
					goto IL_1f43;
				}
				num = (nint)gore4.chipMaterial;
				float num50 = num22 * 12f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7F0");
				nint num51 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3091 @ X0_v209 (Il2CppClass<Burst[]>)+E4]");
				bool flag35 = (nint)0 == 0;
				object obj54 = !flag35;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE2C]");
				num14 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A958]");
				obj49 = 0;
				Mesh mesh3 = default;
				GillaWounds.Chunks((Vector3)gore3.chunk, (Vector3)num, mesh3, null, num36, size, num5, num3, num7);
				ex = null;
				obj10 = 0;
				num12 = num11;
				num10 = num9;
				num8 = num7;
				material2 = null;
				mesh2 = mesh3;
				num2 = num3;
				num4 = num5;
				num6 = size;
				mesh = mesh3;
				vector = (Vector3)num;
			}
			goto IL_1dbd;
		}
		goto IL_1f27;
		IL_1f35:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_1f43;
		IL_1f19:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_1f27;
		IL_1ebd:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		goto IL_1ecb;
		IL_1ea1:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_1eaf;
		IL_1e6f:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_1e7d;
		IL_1e93:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_1ea1;
		IL_1e7d:
		NullReferenceException ex11 = new NullReferenceException();
		num32 = num6;
		goto IL_1e93;
		IL_1efd:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_1f0b;
		IL_1ecb:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_1ed9;
		IL_22d2:
		double num52 = (double)num40 + num39;
		object obj55 = num40 & 1;
		bool flag36 = obj55 == null;
		obj27 = !flag36;
		if (obj27 != null)
		{
			num40 = (float)num52;
		}
		goto IL_231c;
		IL_1ee7:
		IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
		particleSystem = (ParticleSystem)(object)mesh2;
		goto IL_1efd;
		IL_231c:
		burst2 = new ParticleSystem.Burst(0f, (short)(int)num40);
		IntPtr intPtr2 = default;
		bool flag37 = intPtr2 == (IntPtr)0;
		ex = null;
		obj10 = 0;
		shapeModule = shape;
		array = array2;
		emissionModule = emission2;
		material2 = (Material)num30;
		num26 = num30;
		mesh2 = (Mesh)(object)particleSystem3;
		num2 = num11;
		num21 = num13;
		num4 = 0f;
		num32 = 0f;
		mesh = null;
		vector = (Vector3)num40;
		num = intPtr2;
		if (flag37)
		{
			goto IL_1ed9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2852 @ X0_v162 (System.IntPtr)+18]");
		bool flag38 = (nint)0 == 0;
		ex = null;
		obj10 = 0;
		shapeModule = shape;
		array = array2;
		emissionModule = emission2;
		material2 = (Material)num30;
		num26 = num30;
		mesh2 = (Mesh)(object)particleSystem3;
		num2 = num11;
		num21 = num13;
		num4 = 0f;
		num32 = 0f;
		mesh = null;
		vector = (Vector3)num40;
		num = intPtr2;
		if (!flag38)
		{
			_ = 0;
			_ = 0;
			_ = 0;
			emissionModule.SetBursts((ParticleSystem.Burst[])(nint)intPtr2);
			ParticleSystem.ShapeModule shape2 = particleSystem2.shape;
			shapeModule.shapeType = (ParticleSystemShapeType)4;
			shapeModule.angle = 75f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD4]");
			num6 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD4]");
			shapeModule.radius = 0f;
			particleSystem2.Play();
			GillaGoreAssets gore5 = Gore;
			object obj56 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2957 @ X0_v177+E4]");
			bool flag39 = (nint)0 == 0;
			object obj57 = !flag39;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag40 = gore5 != null;
			bool flag41 = !flag40;
			ex = null;
			obj10 = 0;
			array = array2;
			material2 = (Material)num30;
			num26 = num30;
			mesh2 = (Mesh)(object)particleSystem3;
			num2 = 0f;
			num21 = num13;
			num4 = (float)burst2;
			mesh = null;
			vector = (Vector3)0;
			num = intPtr2;
			if (!flag41)
			{
				object obj58 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2968 @ X0_v182+E4]");
				bool flag42 = (nint)0 == 0;
				object obj59 = !flag42;
				if (obj59 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaGoreAssets gore6 = Gore;
				bool flag43 = (object)gore6 == null;
				ex = null;
				obj10 = 0;
				array = array2;
				material2 = (Material)num30;
				num26 = num30;
				particleSystem = particleSystem3;
				num2 = 0f;
				num21 = num13;
				num4 = (float)burst2;
				num32 = num6;
				mesh = null;
				vector = (Vector3)0;
				num = intPtr2;
				if (flag43)
				{
					goto IL_1efd;
				}
				object obj60 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v86+E4]");
				bool flag44 = (nint)0 == 0;
				object obj61 = !flag44;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag45 = gore6.chunk != null;
				bool flag46 = !flag45;
				ex = null;
				obj10 = 0;
				array = array2;
				material2 = (Material)num30;
				num26 = num30;
				mesh2 = (Mesh)(object)particleSystem3;
				num2 = 0f;
				num21 = num13;
				num4 = (float)burst2;
				mesh = null;
				vector = (Vector3)0;
				num = intPtr2;
				if (!flag46)
				{
					object obj62 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2980 @ X0_v188+E4]");
					bool flag47 = (nint)0 == 0;
					object obj63 = !flag47;
					if (obj63 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					gore = Gore;
					bool flag48 = (object)gore == null;
					ex = null;
					obj10 = 0;
					array = array2;
					material2 = (Material)num30;
					num26 = num30;
					particleSystem = particleSystem3;
					num2 = 0f;
					num21 = num13;
					num4 = (float)burst2;
					num32 = num6;
					mesh = null;
					vector = (Vector3)0;
					num = intPtr2;
					if (flag48)
					{
						goto IL_1f0b;
					}
					GillaGoreAssets gore7 = Gore;
					bool flag49 = (object)gore7 == null;
					ex = null;
					obj10 = 0;
					array = array2;
					material2 = (Material)num30;
					num26 = num30;
					particleSystem = particleSystem3;
					num2 = 0f;
					num21 = num13;
					num4 = (float)burst2;
					num32 = num6;
					mesh = null;
					vector = (Vector3)0;
					num = intPtr2;
					if (flag49)
					{
						goto IL_1f19;
					}
					num = (nint)gore7.chunkMaterial;
					object obj64 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2990 @ X0_v192+E4]");
					bool flag50 = (nint)0 == 0;
					object obj65 = !flag50;
					if (obj65 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					num26 = num22 * 26f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					if (num26 < 0f)
					{
						if ((double)num26 == -0.5)
						{
							num34 = -1.0;
							burst4 = burst2;
							goto IL_2411;
						}
						num35 = num26 + -0.5f;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
						num21 = num26;
						num33 = -0.5;
					}
					else
					{
						if ((double)num26 == 0.5)
						{
							num34 = 1.0;
							burst4 = burst2;
							goto IL_2411;
						}
						num35 = num26 + 0.5f;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						num21 = num26;
						num33 = 0.5;
					}
					goto IL_2463;
				}
			}
			goto IL_1dbd;
		}
		goto IL_1ee7;
		IL_1eaf:
		IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
		goto IL_1ebd;
		IL_1ed9:
		NullReferenceException ex16 = new NullReferenceException();
		goto IL_1ee7;
		IL_1dbd:
		object obj67 = default;
		object obj66 = (object)(&obj67);
		if (obj66 != null)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj66);
			vector = (Vector3)0;
		}
		bool flag51 = ex == null;
		object obj68 = !flag51;
		if (obj68 == null)
		{
			bool flag52 = obj10 == null;
			object obj69 = !flag52;
			OutOfMemoryException ex17 = ex;
			if (obj69 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex17 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_1e6f;
	}

	public unsafe static void Chain(Vector3 at, Vector3 dir, int drops, int bits = default(int))
	{
		//IL_0010: Expected Obj, but got I
		//IL_11e4: Expected Obj, but got I4
		//IL_1202: Expected Obj, but got I
		//IL_1222: Expected VT, but got I4
		//IL_00a6: Invalid comparison between F8 and I
		//IL_0046: Expected VT, but got I4
		//IL_17aa: Expected Obj, but got I
		//IL_17d4: Expected Obj, but got I4
		//IL_014e: Invalid comparison between F8 and I
		//IL_0160: Expected F8, but got I4
		//IL_0169: Expected F8, but got I4
		//IL_0172: Expected F8, but got I4
		//IL_017b: Expected F8, but got I4
		//IL_0184: Expected F4, but got I4
		//IL_1245: Expected Obj, but got I
		//IL_125d: Expected Obj, but got I
		//IL_126d: Expected F8, but got I
		//IL_127d: Expected F4, but got I
		//IL_128d: Expected F4, but got I
		//IL_12a2: Expected F4, but got I
		//IL_12ab: Invalid comparison between VT and I4
		//IL_077c: Invalid comparison between VT and I4
		//IL_0790: Expected Obj, but got I4
		//IL_1036: Expected Obj, but got Ref
		//IL_021e: Expected Obj, but got I4
		//IL_1084: Expected Obj, but got I4
		//IL_07d8: Expected Obj, but got I4
		//IL_12fc: Expected native int or pointer, but got F4
		//IL_1327: Expected Obj, but got I4
		//IL_105c: Expected I, but got Obj
		//IL_1065: Expected VT, but got I4
		//IL_0802: Expected native int or pointer, but got F4
		//IL_082d: Expected Obj, but got I4
		//IL_0289: Expected VT, but got I4
		//IL_10ac: Expected Obj, but got I4
		//IL_0875: Expected Obj, but got I4
		//IL_088f: Expected VT, but got I4
		//IL_0897: Expected VT, but got Obj
		//IL_02ce: Expected Obj, but got I4
		//IL_02e8: Expected VT, but got I4
		//IL_08d7: Expected Obj, but got I4
		//IL_091a: Expected Obj, but got I4
		//IL_0934: Expected VT, but got I4
		//IL_093c: Expected VT, but got Obj
		//IL_0316: Expected Obj, but got I
		//IL_0396: Expected F4, but got I
		//IL_15ff: Expected VT, but got I4
		//IL_1121: Invalid comparison between VT and I4
		//IL_0956: Expected native int or pointer, but got F4
		//IL_096c: Expected VT, but got Obj
		//IL_098f: Expected Obj, but got I4
		//IL_1168: Invalid comparison between VT and I4
		//IL_09b6: Expected Obj, but got VT
		//IL_09d7: Expected Obj, but got I4
		//IL_09f1: Expected VT, but got I4
		//IL_044d: Expected VT, but got I4
		//IL_0471: Expected F4, but got I
		//IL_115a: Expected Obj, but got I4
		//IL_0a31: Expected Obj, but got I4
		//IL_0a74: Expected Obj, but got I4
		//IL_0a8e: Expected VT, but got I4
		//IL_180c: Expected Obj, but got I4
		//IL_0aa8: Expected native int or pointer, but got F4
		//IL_0abe: Expected VT, but got Obj
		//IL_0ae0: Expected Obj, but got I4
		//IL_04dd: Expected Obj, but got F8
		//IL_0506: Invalid comparison between F4 and I
		//IL_0b07: Expected Obj, but got VT
		//IL_0b28: Expected Obj, but got I4
		//IL_0b42: Expected VT, but got I4
		//IL_0549: Expected Obj, but got I
		//IL_0551: Expected F4, but got Obj
		//IL_1354: Expected F4, but got I
		//IL_1375: Expected VT, but got I4
		//IL_1392: Expected F4, but got I
		//IL_1392: Expected F4, but got I
		//IL_0b82: Expected Obj, but got I4
		//IL_0573: Expected F4, but got I
		//IL_0573: Expected F4, but got I
		//IL_0585: Expected VT, but got I4
		//IL_1659: Expected native int or pointer, but got F4
		//IL_1684: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I4
		//IL_0be1: Expected Obj, but got I4
		//IL_0bfb: Expected VT, but got I4
		//IL_13ab: Expected Obj, but got I
		//IL_13bb: Expected F4, but got I
		//IL_13cb: Expected F4, but got I
		//IL_13db: Expected F4, but got I
		//IL_13eb: Expected Obj, but got I
		//IL_13fb: Expected F4, but got I
		//IL_140b: Expected F8, but got I
		//IL_141b: Expected F4, but got I
		//IL_142b: Expected F4, but got I
		//IL_143d: Invalid comparison between F4 and I4
		//IL_144c: Expected F8, but got I4
		//IL_1542: Expected F4, but got I
		//IL_1542: Expected F4, but got I
		//IL_0c38: Expected Obj, but got I4
		//IL_0c52: Expected VT, but got I4
		//IL_0645: Expected VT, but got Ref
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected VT, but got Unknown
		//IL_065c: Invalid comparison between VT and I4
		//IL_0676: Expected VT, but got F8
		//IL_067e: Expected VT, but got F4
		//IL_069a: Expected F4, but got I
		//IL_06ab: Expected VT, but got Ref
		//IL_06d4: Expected VT, but got F8
		//IL_06f4: Expected VT, but got F4
		//IL_0734: Expected F4, but got I
		//IL_0c78: Expected Obj, but got I
		//IL_0c88: Expected F4, but got I
		//IL_0c98: Expected Obj, but got I
		//IL_0ca8: Expected F4, but got I
		//IL_0cb8: Expected F4, but got I
		//IL_0cc8: Expected F4, but got I
		//IL_1706: Expected F4, but got I4
		//IL_1729: Expected Obj, but got I4
		//IL_173f: Expected Obj, but got I4
		//IL_1760: Expected VT, but got I4
		//IL_1769: Expected Obj, but got I4
		//IL_0d4f: Expected VT, but got I4
		//IL_1844: Expected Obj, but got I4
		//IL_0dd7: Expected Obj, but got F8
		//IL_0e00: Invalid comparison between F4 and I
		//IL_0e33: Expected I, but got Obj
		//IL_0e43: Expected Obj, but got I
		//IL_0e53: Expected F4, but got I
		//IL_16c0: Expected VT, but got I4
		//IL_0eb6: Expected VT, but got I4
		//IL_0f1b: Expected VT, but got Ref
		//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Expected VT, but got Unknown
		//IL_0f32: Invalid comparison between VT and I4
		//IL_0f44: Expected F4, but got I4
		//IL_0f55: Expected VT, but got F8
		//IL_0f5d: Expected VT, but got F4
		//IL_0f7d: Expected Obj, but got I4
		//IL_0f98: Expected Obj, but got I4
		//IL_0fb6: Expected VT, but got Ref
		//IL_0fbf: Expected Obj, but got I4
		//IL_0fd8: Expected VT, but got F8
		//IL_0fe0: Expected VT, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v4+10]");
		bool flag2 = (nint)0 == 0;
		ParticleSystem.EmitParams emitParams = (ParticleSystem.EmitParams)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v4+10]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			emitParams = (ParticleSystem.EmitParams)0;
		}
		double num2 = default;
		double num = num2 * num2;
		double num4 = default;
		double num3 = num4 * num4;
		double num5 = num + num3;
		float num7 = default;
		float num6 = num7 * num7;
		double num8 = (double)num6 + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		bool flag3 = !(num8 < 0.0);
		double num9 = num2;
		float num10 = (float)num4;
		float num11 = num7;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v63+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v64+18]");
			num9 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v64+1C]");
			num10 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v64+20]");
			num11 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num12 = num9 * num9;
		float num13 = num10 * num10;
		double num14 = (double)num13 + num12;
		float num15 = num11 * num11;
		double num16 = num14 + (double)num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		bool flag5 = !(num16 > 0.0);
		double num17 = 0.0;
		double num18 = 0.0;
		double num19 = 0.0;
		double num20 = 0.0;
		float num21 = 0f;
		float num22 = (float)num16;
		if (!flag5)
		{
			num20 = num9 / num16;
			double num23 = (double)num10 / num16;
			double num24 = (double)num11 / num16;
			num17 = num24;
			num18 = num20;
			num19 = num23;
			num21 = (float)num23;
			num22 = (float)num24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		float num25 = 0f;
		bool flag6 = at < (object)1;
		int num26 = 144;
		Vector3 vector = at;
		OutOfMemoryException ex;
		object obj14;
		double num64 = default;
		float num28;
		float num30 = default;
		int num32 = default;
		Vector3 a = default;
		Vector3 b = default;
		double num27;
		if (!flag6)
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v116+E4]");
			bool flag7 = (nint)0 == 0;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v116+A0]");
			ParticleSystem particleSystem = ChainSystem(ref *(ParticleSystem*)((nint)0 + (nint)64), bits: false);
			float value = ((float*)(nint)num25)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v119 (System.Single)+E4]");
			bool flag8 = (nint)0 == 0;
			object obj13 = !flag8;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = particleSystem != null;
			bool flag10 = !flag9;
			ParticleSystem particleSystem2 = particleSystem;
			num26 = 0;
			emitParams = (ParticleSystem.EmitParams)0;
			vector = at;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				bool flag11 = (object)particleSystem == null;
				particleSystem2 = particleSystem;
				ex = null;
				obj14 = 0;
				num27 = num21;
				num26 = 144;
				emitParams = (ParticleSystem.EmitParams)0;
				vector = at;
				num28 = (float)num9;
				if (flag11)
				{
					goto IL_10e0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj15 = 0;
				float num29 = num30;
				object obj17 = default;
				object obj16 = obj17;
				int num31 = num32;
				double num34 = default;
				double num33 = num34;
				double num36 = default;
				double num35 = num36;
				double num38 = default;
				double num37 = num38;
				float num40 = default;
				float num39 = num40;
				float num42 = default;
				float num41 = num42;
				float num44 = default;
				float num43 = num44;
				float num46 = default;
				float num45 = num46;
				double num47 = num4;
				double num48 = num2;
				double num49 = num20;
				float num50 = num21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
				float num51 = 0f;
				int num52 = 144;
				Vector3 vector2 = at;
				double num53 = num9;
				float num54 = num10;
				float num55 = num11;
				object obj18 = default;
				object obj19 = default;
				ParticleSystem.EmitParams emitParams2 = default;
				Color32 startColor = default;
				object obj28 = default;
				bool flag17;
				do
				{
					int particleCount = particleSystem.particleCount;
					bool flag12 = particleCount >= 160;
					num30 = num29;
					obj17 = obj16;
					num32 = num31;
					num34 = num33;
					num36 = num35;
					num38 = num37;
					num40 = num39;
					num42 = num41;
					num44 = num43;
					num46 = num45;
					num4 = num47;
					num2 = num48;
					particleSystem2 = particleSystem;
					num20 = num49;
					num21 = num50;
					num22 = num51;
					num26 = num52;
					emitParams = (ParticleSystem.EmitParams)0;
					vector = vector2;
					num9 = num53;
					num10 = num54;
					num11 = num55;
					if (flag12)
					{
						break;
					}
					Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
					float num56 = num50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC4]");
					float num57 = num56 * 0f;
					float num58 = num51;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC4]");
					float num59 = num58 * 0f;
					double num60 = num49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC4]");
					double num61 = num60 * 0.0;
					float num62 = (float)obj18 + num57;
					float num63 = (float)num64 + num59;
					double num65 = (double)obj19 + num61;
					emitParams2.position = (Vector3)0;
					Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
					float num66 = UnityEngine.Random.Range(0f, 0f);
					Vector3 vector3 = Vector3.Internal_Slerp(ref a, ref b, num66);
					object obj20 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X0_v138+E4]");
					bool flag13 = (nint)0 == 0;
					object obj21 = !flag13;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num67 = num66 * num66;
					double num68 = num17 * num17;
					float num69 = num67 + (float)num68;
					object obj22 = num18 * num18;
					float num70 = (float)obj22 + num69;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					float num71;
					if (num70 > 0f)
					{
						num71 = num66 / num70;
					}
					else
					{
						object obj23 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X8_v55+A0]");
						object obj24 = 0;
						num71 = (float)obj24;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
					float num72 = UnityEngine.Random.Range(0f, 5.5f);
					float num73 = num71 * num72;
					emitParams2.velocity = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A838]");
					nint num74 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8CC]");
					float num75 = UnityEngine.Random.Range(num74, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
					nint num76 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
					float num77 = UnityEngine.Random.Range(num76, 0f);
					emitParams2.startSize3D = (Vector3)0;
					object obj25 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X0_v146+E4]");
					bool flag14 = (nint)0 == 0;
					object obj26 = !flag14;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj25 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X0_v146+A0]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v54+18]");
					num46 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v54+1C]");
					num44 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v54+20]");
					num42 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v54+24]");
					obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v54+28]");
					num30 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v54+2C]");
					num9 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v54+30]");
					num10 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v54+34]");
					num11 = 0f;
					float value2 = UnityEngine.Random.value;
					bool flag15 = value2 < 0f;
					double num78 = 0.0;
					if (!flag15)
					{
						bool flag16 = !((double)value2 > 1.0);
						num78 = value2;
						if (!flag16)
						{
							num78 = 1.0;
						}
					}
					float num79 = num30 - num46;
					double num80 = num9 - (double)num44;
					float num81 = num10 - num42;
					float num82 = num11 - (float)obj17;
					double num83 = (double)num79 * num78;
					double num84 = num80 * num78;
					double num85 = (double)num81 * num78;
					num4 = (double)num82 * num78;
					double num86 = (double)num46 + num83;
					double num87 = (double)num44 + num84;
					num20 = (double)num42 + num85;
					num2 = (double)obj17 + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B470");
					emitParams2.startColor = startColor;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					nint num88 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
					num22 = (emitParams2.startLifetime = UnityEngine.Random.Range(num88, 0f));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					particleSystem.Emit((ParticleSystem.EmitParams)(&obj28), 1);
					vector = vector2 - 1;
					flag17 = vector != (Vector3)(object)1;
					num32 = 0;
					a = (Vector3)num18;
					b = (Vector3)num63;
					particleSystem2 = particleSystem;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
					num21 = 0f;
					num26 = 1;
					emitParams = (ParticleSystem.EmitParams)(&obj28);
					num29 = num30;
					obj16 = obj17;
					num31 = 0;
					num33 = num17;
					a = (Vector3)num18;
					num35 = num19;
					num37 = num65;
					num39 = num62;
					b = (Vector3)num63;
					num41 = num42;
					num43 = num44;
					num45 = num46;
					num47 = num4;
					num48 = num2;
					num49 = num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
					num50 = 0f;
					num51 = num22;
					num52 = 1;
					vector2 = vector;
					num53 = num9;
					num54 = num10;
					num55 = num11;
				}
				while (flag17);
			}
		}
		bool flag18 = dir < (object)1;
		ex = null;
		obj14 = 0;
		num27 = num21;
		num28 = (float)num9;
		if (!flag18)
		{
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X0_v40+E4]");
			bool flag19 = (nint)0 == 0;
			object obj30 = !flag19;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaGoreAssets gore = Gore;
			float value3 = ((float*)(nint)num25)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v42 (System.Single)+E4]");
			bool flag20 = (nint)0 == 0;
			object obj31 = !flag20;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag21 = gore != null;
			bool flag22 = !flag21;
			ex = null;
			obj14 = 0;
			num27 = num21;
			num26 = 0;
			emitParams = (ParticleSystem.EmitParams)0;
			vector = (Vector3)gore;
			num28 = (float)num9;
			if (!flag22)
			{
				object obj32 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X0_v47+E4]");
				bool flag23 = (nint)0 == 0;
				object obj33 = !flag23;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaGoreAssets gore2 = Gore;
				bool flag24 = (object)gore2 == null;
				ex = null;
				obj14 = 0;
				num27 = num21;
				num26 = 0;
				emitParams = (ParticleSystem.EmitParams)0;
				vector = (Vector3)gore;
				num28 = (float)num9;
				if (flag24)
				{
					goto IL_10ee;
				}
				float value4 = ((float*)(nint)num25)->m_value;
				vector = (Vector3)gore2.chunk;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v26 (System.Single)+E4]");
				bool flag25 = (nint)0 == 0;
				object obj34 = !flag25;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag26 = (UnityEngine.Object)vector != null;
				bool flag27 = !flag26;
				ex = null;
				obj14 = 0;
				num27 = num21;
				num26 = 0;
				emitParams = (ParticleSystem.EmitParams)0;
				num28 = (float)num9;
				if (!flag27)
				{
					object obj35 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X0_v53+E4]");
					bool flag28 = (nint)0 == 0;
					object obj36 = !flag28;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaGoreAssets gore3 = Gore;
					bool flag29 = (object)gore3 == null;
					ex = null;
					obj14 = 0;
					num27 = num21;
					num26 = 0;
					emitParams = (ParticleSystem.EmitParams)0;
					num28 = (float)num9;
					if (flag29)
					{
						goto IL_10fc;
					}
					float value5 = ((float*)(nint)num25)->m_value;
					vector = (Vector3)gore3.chunkMaterial;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v28 (System.Single)+E4]");
					bool flag30 = (nint)0 == 0;
					object obj37 = !flag30;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag31 = (UnityEngine.Object)vector != null;
					bool flag32 = !flag31;
					ex = null;
					obj14 = 0;
					num27 = num21;
					num26 = 0;
					emitParams = (ParticleSystem.EmitParams)0;
					num28 = (float)num9;
					if (!flag32)
					{
						object obj38 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X0_v59+E4]");
						bool flag33 = (nint)0 == 0;
						object obj39 = !flag33;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj38 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X0_v59+A0]");
						ParticleSystem particleSystem3 = ChainSystem(ref *(ParticleSystem*)((nint)0 + (nint)72), bits: true);
						float value6 = ((float*)(nint)num25)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X0_v62 (System.Single)+E4]");
						bool flag34 = (nint)0 == 0;
						object obj40 = !flag34;
						if (obj40 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag35 = particleSystem3 != null;
						bool flag36 = !flag35;
						ex = null;
						obj14 = 0;
						num27 = num21;
						num26 = 0;
						emitParams = (ParticleSystem.EmitParams)0;
						num28 = (float)num9;
						if (!flag36)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
							bool flag37 = (object)particleSystem3 == null;
							ex = null;
							obj14 = 0;
							num27 = num21;
							num26 = 144;
							emitParams = (ParticleSystem.EmitParams)0;
							num28 = (float)num9;
							if (flag37)
							{
								goto IL_110a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
							num11 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							ParticleSystem particleSystem2 = (ParticleSystem)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AADC]");
							num10 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF80]");
							num28 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
							float num46 = 0f;
							float num90 = num30;
							int num91 = num32;
							double num92 = num4;
							double num93 = num2;
							double num94 = num20;
							double num95 = num21;
							float num96 = num22;
							int num97 = 144;
							Vector3 vector4 = dir;
							ParticleSystem.EmitParams emitParams3 = default;
							Color32 startColor2 = default;
							object obj45 = default;
							bool flag40;
							do
							{
								int particleCount2 = particleSystem3.particleCount;
								bool flag38 = particleCount2 >= 36;
								num30 = num90;
								num25 = 1.13587E+09f;
								num32 = num91;
								num4 = num92;
								num2 = num93;
								object obj15 = 109891584;
								num20 = num94;
								ex = null;
								obj14 = 0;
								num27 = num95;
								num22 = num96;
								num26 = num97;
								emitParams = (ParticleSystem.EmitParams)0;
								obj = 1;
								if (flag38)
								{
									break;
								}
								Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
								float num98 = num96 * (float)obj17;
								float num99 = (float)num64 + num98;
								emitParams3.position = (Vector3)0;
								Vector3 onUnitSphere2 = UnityEngine.Random.onUnitSphere;
								float num100 = UnityEngine.Random.Range(0f, num11);
								Vector3 vector5 = Vector3.Internal_Slerp(ref a, ref b, num100);
								object obj41 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ X0_v81+E4]");
								bool flag39 = (nint)0 == 0;
								object obj42 = !flag39;
								if (obj42 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								float num101 = num100 * num100;
								double num102 = num17 * num17;
								float num103 = num101 + (float)num102;
								object obj43 = num18 * num18;
								float num104 = (float)obj43 + num103;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								if (num104 > 0f)
								{
									num30 = (float)num18 / num104;
								}
								else
								{
									nint num105 = (nint)particleSystem2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X8_v39 (Il2CppClass<UnityEngine.ParticleSystem>)+A0]");
									object obj44 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v40+8]");
									num30 = 0f;
								}
								float num106 = UnityEngine.Random.Range(4f, 13f);
								emitParams3.velocity = (Vector3)0;
								float startSize = UnityEngine.Random.Range(num10, num28);
								emitParams3.startSize = startSize;
								float num107 = UnityEngine.Random.Range(0f, 360f);
								float num108 = UnityEngine.Random.Range(0f, 360f);
								float num109 = UnityEngine.Random.Range(0f, 360f);
								emitParams3.rotation3D = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B470");
								emitParams3.startColor = startColor2;
								num22 = (emitParams3.startLifetime = UnityEngine.Random.Range(num46, 2f));
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
								particleSystem3.Emit((ParticleSystem.EmitParams)(&obj45), 1);
								vector4--;
								flag40 = vector4 != (Vector3)(object)1;
								num25 = 1.13587E+09f;
								num32 = 0;
								a = (Vector3)num18;
								b = (Vector3)num99;
								num4 = num64;
								num2 = 1.0;
								obj15 = 109891584;
								num20 = 1.0;
								ex = null;
								obj14 = 0;
								num27 = 2.0;
								num26 = 1;
								emitParams = (ParticleSystem.EmitParams)(&obj45);
								obj = 1;
								num90 = num30;
								num91 = 0;
								a = (Vector3)num18;
								b = (Vector3)num99;
								num92 = num64;
								num93 = 1.0;
								num94 = 1.0;
								num95 = 2.0;
								num96 = num22;
								num97 = 1;
							}
							while (flag40);
						}
					}
				}
			}
		}
		goto IL_102e;
		IL_110a:
		NullReferenceException ex2 = new NullReferenceException();
		if (emitParams == (ParticleSystem.EmitParams)(object)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj14 = 1;
		}
		else
		{
			if (emitParams != (ParticleSystem.EmitParams)(object)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj46 = default;
			ex = (OutOfMemoryException)obj46;
		}
		goto IL_102e;
		IL_102e:
		IntPtr intPtr = default;
		object obj47 = (object)(&intPtr);
		if (obj47 != null)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj47);
			emitParams = (ParticleSystem.EmitParams)0;
		}
		bool flag41 = ex == null;
		object obj48 = !flag41;
		if (obj48 == null)
		{
			bool flag42 = obj14 == null;
			object obj49 = !flag42;
			OutOfMemoryException ex3 = ex;
			if (obj49 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex3 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_10e0;
		IL_10e0:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_10ee;
		IL_10ee:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_10fc;
		IL_10fc:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_110a;
	}

	public unsafe static void WarmChain(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0457: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I4
		//IL_04eb: Expected Obj, but got I4
		//IL_006a: Expected VT, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
		//IL_0090: Expected VT, but got I4
		//IL_01a2: Expected Obj, but got I4
		//IL_0509: Expected Obj, but got I
		//IL_0517: Expected VT, but got I4
		//IL_01da: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got I
		//IL_055b: Expected Obj, but got I
		//IL_0569: Expected VT, but got I4
		//IL_057e: Expected F4, but got I
		//IL_05a8: Expected Obj, but got I4
		//IL_05c6: Expected Obj, but got I
		//IL_022f: Expected Obj, but got I4
		//IL_00cd: Expected VT, but got Ref
		//IL_00de: Expected VT, but got Ref
		//IL_0279: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I4
		//IL_0350: Expected Obj, but got I4
		//IL_0388: Expected Obj, but got I4
		//IL_0634: Expected Obj, but got I4
		//IL_03ff: Expected VT, but got I4
		//IL_0650: Expected VT, but got I4
		//IL_0665: Expected F4, but got I
		//IL_067a: Expected F4, but got I
		//IL_0441: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+A0]");
		ParticleSystem particleSystem = ChainSystem(ref *(ParticleSystem*)((nint)0 + (nint)64), bits: false);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = particleSystem != null;
		bool flag4 = !flag3;
		int num = 0;
		ParticleSystem.EmitParams emitParams = (ParticleSystem.EmitParams)0;
		ParticleSystem.EmitParams emitParams2 = default;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
			emitParams2.position = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj7 = 0;
			emitParams2.velocity = (Vector3)0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v33+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v34+14]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			object obj10 = num2 * 0;
			emitParams2.startSize3D = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			emitParams2.startLifetime = 0f;
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v78+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v78+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B470");
			Color32 startColor = default;
			emitParams2.startColor = startColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			object obj14 = default;
			particleSystem.Emit((ParticleSystem.EmitParams)(&obj14), 1);
			num = 1;
			emitParams = (ParticleSystem.EmitParams)(&obj14);
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaGoreAssets gore = Gore;
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = gore == null;
		bool flag9 = !flag8;
		object obj19 = !flag9;
		if (obj19 != null)
		{
			return;
		}
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v22+E4]");
		bool flag10 = (nint)0 == 0;
		object obj21 = !flag10;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaGoreAssets gore2 = Gore;
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v12+E4]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = gore2.chunk == null;
		bool flag13 = !flag12;
		object obj24 = !flag13;
		if (obj24 != null)
		{
			return;
		}
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v28+E4]");
		bool flag14 = (nint)0 == 0;
		object obj26 = !flag14;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaGoreAssets gore3 = Gore;
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v14+E4]");
		bool flag15 = (nint)0 == 0;
		object obj28 = !flag15;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag16 = gore3.chunkMaterial == null;
		bool flag17 = !flag16;
		object obj29 = !flag17;
		if (obj29 == null)
		{
			object obj30 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v34+E4]");
			bool flag18 = (nint)0 == 0;
			object obj31 = !flag18;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj30 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v34+A0]");
			ParticleSystem particleSystem2 = ChainSystem(ref *(ParticleSystem*)((nint)0 + (nint)72), bits: true);
			object obj32 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v17+E4]");
			bool flag19 = (nint)0 == 0;
			object obj33 = !flag19;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (particleSystem2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				emitParams2.position = (Vector3)0;
				emitParams2.velocity = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				emitParams2.startSize = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				emitParams2.startLifetime = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B470");
				Color32 startColor2 = default;
				emitParams2.startColor = startColor2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				object obj34 = default;
				particleSystem2.Emit((ParticleSystem.EmitParams)(&obj34), 1);
			}
		}
	}

	private unsafe static ParticleSystem ChainSystem(ref ParticleSystem kept, bool bits)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0957: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_098f: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I
		//IL_09de: Expected Obj, but got I4
		//IL_025a: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I4
		//IL_09f7: Expected Obj, but got I4
		//IL_0347: Expected F4, but got I
		//IL_0a35: Expected VT, but got Ref
		//IL_0332: Expected F4, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_048c: Expected F4, but got I
		//IL_049d: Expected Obj, but got I4
		//IL_04c9: Expected F4, but got I
		//IL_0a64: Expected Obj, but got I8
		//IL_0513: Expected Obj, but got I4
		//IL_0523: Expected Obj, but got I4
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_056c: Expected Obj, but got I
		//IL_05b7: Expected VT, but got Ref
		//IL_0692: Expected F8, but got I
		//IL_06a2: Expected F4, but got I
		//IL_06af: Expected I4, but got I8
		//IL_0634: Expected VT, but got Ref
		//IL_0641: Expected VT, but got Ref
		//IL_0653: Expected VT, but got Ref
		//IL_0663: Expected F4, but got I
		//IL_067d: Expected I4, but got I8
		//IL_0721: Expected VT, but got Ref
		//IL_0740: Expected VT, but got Ref
		//IL_0760: Expected VT, but got Ref
		//IL_0787: Expected Obj, but got I
		//IL_0890: Expected Obj, but got I4
		//IL_0803: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ParticleSystem result;
		if (kept != null)
		{
			result = kept;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
			object obj4 = 0;
			object obj5 = obj4;
			Material material;
			if (bits)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v108+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaGoreAssets gore = Gore;
				if ((object)gore == null)
				{
					goto IL_0911;
				}
				material = gore.chunkMaterial;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v108+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Material material2 = RoomLit(null);
				material = material2;
			}
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = material == null;
			bool flag6 = !flag5;
			object obj10 = !flag6;
			result = null;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EE0]");
				object name = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
				object obj11 = 0;
				bool flag7 = !bits;
				object obj12 = !flag7;
				object obj13 = ~obj12;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4ED8]");
					name = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				GameObject gameObject = default;
				gameObject._002Ector((string)name);
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X0_v16+E4]");
				bool flag8 = (nint)0 == 0;
				object obj15 = !flag8;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
				if ((object)gameObject != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD0]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					ParticleSystem particleSystem = default;
					if ((object)particleSystem != null)
					{
						particleSystem.Stop(withChildren: true, (ParticleSystemStopBehavior)0);
						ParticleSystem.MainModule main = particleSystem.main;
						ParticleSystem.MainModule mainModule = default;
						mainModule.loop = true;
						mainModule.playOnAwake = false;
						mainModule.simulationSpace = (ParticleSystemSimulationSpace)1;
						bool flag9 = !bits;
						object obj17 = !flag9;
						object obj18 = ~obj17;
						int maxParticles = ((obj18 != null) ? 160 : 36);
						object obj19 = !flag9;
						object obj20 = ~obj19;
						float num;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
							num = 0f;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
							num = 0f;
						}
						mainModule.maxParticles = maxParticles;
						ParticleSystem.MinMaxCurve minMaxCurve = num;
						object obj21 = default;
						mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj21);
						if (bits)
						{
							mainModule.startRotation3D = true;
						}
						else
						{
							mainModule.startSize3D = true;
						}
						ParticleSystem.EmissionModule emission = particleSystem.emission;
						ParticleSystem.EmissionModule emissionModule = default;
						emissionModule.enabled = false;
						ParticleSystem.ShapeModule shape = particleSystem.shape;
						ParticleSystem.ShapeModule shapeModule = default;
						shapeModule.enabled = false;
						ParticleSystem.SizeOverLifetimeModule sizeOverLifetime = particleSystem.sizeOverLifetime;
						ParticleSystem.SizeOverLifetimeModule sizeOverLifetimeModule = default;
						sizeOverLifetimeModule.enabled = true;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CA8]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Keyframe keyframe = new Keyframe(0f, 1f);
						Keyframe[] array = default;
						if (array != null)
						{
							if (array.Length != 0)
							{
								bool flag10 = !bits;
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
								float time = 0f;
								_ = 0;
								object obj23 = !flag10;
								object obj24 = ~obj23;
								if (obj24 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
									time = 0f;
								}
								Keyframe keyframe2 = new Keyframe(time, 1f);
								object obj25 = array.Length & 0xFFFFFFFEL;
								if (obj25 != null)
								{
									_ = 0;
									_ = 0;
									_ = 0;
									Keyframe keyframe3 = new Keyframe(1f, 0f);
									bool flag11 = array.Length < 2;
									object obj26 = !flag11;
									object obj27 = array.Length - 2;
									bool flag12 = obj27 == null;
									object obj28 = ~obj26;
									object obj29 = obj28 | flag12;
									if (obj29 == null)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C98]");
										object obj30 = 0;
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										AnimationCurve animationCurve = default;
										animationCurve._002Ector(array);
										ParticleSystem.MinMaxCurve minMaxCurve2 = new ParticleSystem.MinMaxCurve(1f, animationCurve);
										object obj31 = default;
										sizeOverLifetimeModule.size = (ParticleSystem.MinMaxCurve)(&obj31);
										float num2;
										double num3;
										int num4;
										if (bits)
										{
											RotationOverLifetimeModule rotationOverLifetime = particleSystem.rotationOverLifetime;
											RotationOverLifetimeModule rotationOverLifetimeModule = default;
											rotationOverLifetimeModule.enabled = true;
											rotationOverLifetimeModule.separateAxes = true;
											ParticleSystem.MinMaxCurve minMaxCurve3 = new ParticleSystem.MinMaxCurve(-8f, 8f);
											object obj32 = default;
											rotationOverLifetimeModule.z = (ParticleSystem.MinMaxCurve)(&obj32);
											object obj33 = default;
											rotationOverLifetimeModule.y = (ParticleSystem.MinMaxCurve)(&obj33);
											object obj34 = default;
											rotationOverLifetimeModule.x = (ParticleSystem.MinMaxCurve)(&obj34);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
											num2 = 0f;
											num3 = 0.75;
											num4 = -5893;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
											num3 = 0.0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
											num2 = 0f;
											num4 = -1797;
										}
										ParticleSystem.CollisionModule collision = particleSystem.collision;
										ParticleSystem.CollisionModule collisionModule = default;
										collisionModule.enabled = true;
										collisionModule.type = (ParticleSystemCollisionType)1;
										collisionModule.mode = (ParticleSystemCollisionMode)0;
										collisionModule.quality = (ParticleSystemCollisionQuality)2;
										LayerMask collidesWith = num4;
										collisionModule.collidesWith = collidesWith;
										collisionModule.enableDynamicColliders = false;
										ParticleSystem.MinMaxCurve minMaxCurve4 = (float)num3;
										object obj35 = default;
										collisionModule.dampen = (ParticleSystem.MinMaxCurve)(&obj35);
										ParticleSystem.MinMaxCurve minMaxCurve5 = num2;
										object obj36 = default;
										collisionModule.bounce = (ParticleSystem.MinMaxCurve)(&obj36);
										ParticleSystem.MinMaxCurve minMaxCurve6 = 0f;
										object obj37 = default;
										collisionModule.lifetimeLoss = (ParticleSystem.MinMaxCurve)(&obj37);
										collisionModule.radiusScale = 0.5f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD8]");
										object obj38 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
										ParticleSystemRenderer particleSystemRenderer = default;
										if ((object)particleSystemRenderer != null)
										{
											particleSystemRenderer.renderMode = (ParticleSystemRenderMode)4;
											Mesh mesh;
											if (bits)
											{
												object obj39 = obj4;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X0_v87+E4]");
												bool flag13 = (nint)0 == 0;
												object obj40 = !flag13;
												if (obj40 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												GillaGoreAssets gore2 = Gore;
												if ((object)gore2 == null)
												{
													goto IL_0911;
												}
												mesh = gore2.chunk;
											}
											else
											{
												particleSystemRenderer.alignment = (ParticleSystemRenderSpace)4;
												object obj41 = obj4;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X0_v83+E4]");
												bool flag14 = (nint)0 == 0;
												object obj42 = !flag14;
												if (obj42 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Mesh mesh2 = Drop();
												mesh = mesh2;
											}
											particleSystemRenderer.mesh = mesh;
											particleSystemRenderer.sharedMaterial = material;
											particleSystemRenderer.shadowCastingMode = (ShadowCastingMode)0;
											particleSystemRenderer.lightProbeUsage = (LightProbeUsage)1;
											particleSystemRenderer.enableGPUInstancing = false;
											particleSystem.Play();
											ref ParticleSystem reference = ref *(ParticleSystem*)particleSystem;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											result = particleSystem;
											goto IL_090c;
										}
										goto IL_0911;
									}
								}
							}
							goto IL_091f;
						}
					}
				}
				goto IL_0911;
			}
		}
		goto IL_090c;
		IL_0911:
		NullReferenceException ex = new NullReferenceException();
		goto IL_091f;
		IL_091f:
		return (ParticleSystem)(object)new IndexOutOfRangeException();
		IL_090c:
		return result;
	}

	public unsafe static void Yolk(Vector3 at, Vector3 dir)
	{
		//IL_0010: Expected Obj, but got I
		//IL_094d: Expected Obj, but got I4
		//IL_0aab: Expected Obj, but got I
		//IL_097d: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_00f9: Expected VT, but got I4
		//IL_0102: Expected VT, but got I4
		//IL_010d: Expected VT, but got I4
		//IL_0116: Expected F4, but got I4
		//IL_011f: Expected VT, but got I4
		//IL_0791: Expected Obj, but got Ref
		//IL_07db: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got VT
		//IL_0182: Expected Obj, but got VT
		//IL_01a1: Expected VT, but got I
		//IL_01b1: Invalid comparison between F4 and I
		//IL_07b7: Expected I, but got Obj
		//IL_099b: Expected Obj, but got I
		//IL_09b5: Expected Obj, but got I
		//IL_09df: Expected Obj, but got I4
		//IL_09e8: Expected VT, but got I4
		//IL_09f1: Expected VT, but got I4
		//IL_09fc: Expected VT, but got I4
		//IL_0a05: Expected VT, but got I4
		//IL_0803: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_0218: Expected VT, but got I4
		//IL_0221: Expected VT, but got I4
		//IL_022c: Expected VT, but got I4
		//IL_0235: Expected VT, but got I4
		//IL_0a2b: Expected Obj, but got I
		//IL_0a43: Expected Obj, but got I
		//IL_0a53: Expected F4, but got I
		//IL_0a63: Expected VT, but got I
		//IL_0a73: Expected VT, but got I
		//IL_0256: Expected VT, but got I4
		//IL_0292: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I
		//IL_0328: Expected F8, but got I
		//IL_0346: Expected Obj, but got I4
		//IL_0346: Expected VT, but got Obj
		//IL_0367: Expected Obj, but got I4
		//IL_0370: Expected VT, but got I4
		//IL_0379: Expected VT, but got I4
		//IL_0384: Expected VT, but got I4
		//IL_038d: Expected Obj, but got I4
		//IL_03ad: Expected VT, but got Obj
		//IL_08c7: Expected Obj, but got I4
		//IL_03e2: Expected VT, but got Obj
		//IL_03e2: Expected VT, but got I4
		//IL_03f4: Expected VT, but got Ref
		//IL_0415: Expected F4, but got I
		//IL_0415: Expected F4, but got I
		//IL_0427: Expected VT, but got Ref
		//IL_0445: Expected F4, but got I
		//IL_0457: Expected VT, but got Ref
		//IL_0478: Expected F4, but got I
		//IL_0478: Expected F4, but got I
		//IL_048a: Expected VT, but got Ref
		//IL_0497: Expected VT, but got Ref
		//IL_04bd: Expected F4, but got I
		//IL_04bd: Expected F4, but got I
		//IL_04ca: Expected VT, but got Ref
		//IL_04e0: Expected F4, but got I
		//IL_04f1: Expected VT, but got Ref
		//IL_0523: Expected VT, but got Ref
		//IL_0533: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I4
		//IL_057b: Expected VT, but got I4
		//IL_05ad: Expected Obj, but got I4
		//IL_05c3: Expected VT, but got I4
		//IL_05d4: Expected F4, but got I4
		//IL_05dd: Expected VT, but got I4
		//IL_05e6: Expected Obj, but got I4
		//IL_0619: Expected Obj, but got I4
		//IL_0622: Expected VT, but got I4
		//IL_0654: Expected Obj, but got I4
		//IL_066a: Expected VT, but got I4
		//IL_067b: Expected F4, but got I4
		//IL_0684: Expected VT, but got I4
		//IL_068d: Expected Obj, but got I4
		//IL_0702: Expected F4, but got I
		//IL_0717: Expected F4, but got I
		//IL_072e: Expected Obj, but got I4
		//IL_0758: Expected Obj, but got I4
		//IL_076e: Expected VT, but got I4
		//IL_077f: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+10]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Material material = RoomLit(null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = material == null;
		bool flag5 = !flag4;
		object obj9 = !flag5;
		OutOfMemoryException ex = null;
		object obj10 = 0;
		ParticleSystem.ShapeModule shapeModule = (ParticleSystem.ShapeModule)0;
		ParticleSystem.EmissionModule emissionModule = (ParticleSystem.EmissionModule)0;
		ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)0;
		float num = 0f;
		Vector3 vector = (Vector3)0;
		UnityEngine.Object obj11 = null;
		double num3 = default;
		float num2 = (float)num3;
		ParticleSystem.Burst burst2 = default;
		ParticleSystem.Burst burst = burst2;
		ParticleSystem.Burst burst4 = default;
		ParticleSystem.Burst burst3 = burst4;
		ParticleSystem.Burst burst5;
		ParticleSystem.Burst burst9 = default;
		if (obj9 == null)
		{
			double num4 = num3 * num3;
			object obj12 = burst2 * burst2;
			double num5 = num4 + (double)obj12;
			object obj13 = burst4 * burst4;
			num = (float)obj13 + (float)num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			burst5 = (ParticleSystem.Burst)0;
			float num6 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			bool flag6 = !(num6 < 0f);
			num2 = (float)num3;
			burst = burst2;
			burst3 = burst4;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj14 = 0;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v51+A0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v52+18]");
				num2 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v52+1C]");
				burst = (ParticleSystem.Burst)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v52+20]");
				burst3 = (ParticleSystem.Burst)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EE8]");
			object obj18 = 0;
			GameObject gameObject = default;
			gameObject._002Ector((string)obj18);
			bool flag7 = (object)gameObject == null;
			ex = null;
			obj10 = 0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			vector = (Vector3)0;
			obj11 = (UnityEngine.Object)obj18;
			if (flag7)
			{
				goto IL_083f;
			}
			Transform transform = gameObject.transform;
			bool flag8 = (object)transform == null;
			ex = null;
			obj10 = 0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			vector = (Vector3)0;
			obj11 = null;
			if (flag8)
			{
				goto IL_084d;
			}
			transform.position = (Vector3)0;
			GameObject gameObject2 = transform.gameObject;
			object obj19 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X0_v47+E4]");
			bool flag9 = (nint)0 == 0;
			object obj20 = !flag9;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(gameObject2, 3f);
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X0_v50+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EF0]");
			object name = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			num3 = 0.0;
			int most = default;
			ParticleSystem particleSystem = Particles((string)name, transform, (Vector3)material, (Material)40, num2, most);
			bool flag11 = (object)particleSystem == null;
			ex = null;
			obj10 = 0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			Material material2 = (Material)40;
			ParticleSystem.Burst burst6 = burst3;
			burst5 = burst;
			num = num2;
			vector = (Vector3)material;
			obj11 = transform;
			if (flag11)
			{
				goto IL_085b;
			}
			ParticleSystem.MainModule main = particleSystem.main;
			ParticleSystem.MinMaxGradient minMaxGradient = new ParticleSystem.MinMaxGradient((Color)0, (Color)material);
			ParticleSystem.MinMaxGradient minMaxGradient2 = default;
			mainModule.startColor = (ParticleSystem.MinMaxGradient)(&minMaxGradient2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			ParticleSystem.MinMaxCurve minMaxCurve = new ParticleSystem.MinMaxCurve(num7, 0f);
			ParticleSystem.MinMaxCurve minMaxCurve2 = default;
			mainModule.startLifetime = (ParticleSystem.MinMaxCurve)(&minMaxCurve2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			ParticleSystem.MinMaxCurve minMaxCurve3 = new ParticleSystem.MinMaxCurve(0f, 3f);
			ParticleSystem.MinMaxCurve minMaxCurve4 = default;
			mainModule.startSpeed = (ParticleSystem.MinMaxCurve)(&minMaxCurve4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE2C]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
			ParticleSystem.MinMaxCurve minMaxCurve5 = new ParticleSystem.MinMaxCurve(num8, 0f);
			ParticleSystem.MinMaxCurve minMaxCurve6 = default;
			mainModule.startSizeY = (ParticleSystem.MinMaxCurve)(&minMaxCurve6);
			ParticleSystem.MinMaxCurve minMaxCurve7 = default;
			mainModule.startSizeX = (ParticleSystem.MinMaxCurve)(&minMaxCurve7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA14]");
			ParticleSystem.MinMaxCurve minMaxCurve8 = new ParticleSystem.MinMaxCurve(num9, 0f);
			ParticleSystem.MinMaxCurve minMaxCurve9 = default;
			mainModule.startSizeZ = (ParticleSystem.MinMaxCurve)(&minMaxCurve9);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
			ParticleSystem.MinMaxCurve minMaxCurve10 = 0f;
			object obj23 = default;
			mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj23);
			ParticleSystem.EmissionModule emission = particleSystem.emission;
			ParticleSystem.MinMaxCurve minMaxCurve11 = 0f;
			object obj24 = default;
			emissionModule.rateOverTime = (ParticleSystem.MinMaxCurve)(&obj24);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E50]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			ParticleSystem.Burst burst7 = new ParticleSystem.Burst(0f, 34);
			GameObject gameObject3 = default;
			bool flag12 = (object)gameObject3 == null;
			ex = null;
			obj10 = 0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = emission;
			double num10 = 1.0;
			material2 = (Material)40;
			num3 = 1.0;
			burst6 = (ParticleSystem.Burst)0;
			ParticleSystem.Burst burst8 = default;
			burst5 = burst8;
			num = 0f;
			vector = (Vector3)0;
			obj11 = (UnityEngine.Object)34;
			if (flag12)
			{
				goto IL_0869;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X0_v76 (UnityEngine.GameObject)+18]");
			bool flag13 = (nint)0 == 0;
			ex = null;
			obj10 = 0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = emission;
			num10 = 1.0;
			material2 = (Material)40;
			num3 = 1.0;
			burst6 = (ParticleSystem.Burst)0;
			burst5 = burst8;
			num = 0f;
			vector = (Vector3)0;
			obj11 = (UnityEngine.Object)34;
			if (flag13)
			{
				goto IL_0877;
			}
			_ = 0;
			_ = 0;
			_ = 0;
			emissionModule.SetBursts((ParticleSystem.Burst[])(object)gameObject3);
			ParticleSystem.ShapeModule shape = particleSystem.shape;
			shapeModule.shapeType = (ParticleSystemShapeType)4;
			shapeModule.angle = 60f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			shapeModule.radius = 0f;
			particleSystem.Play();
			ex = null;
			obj10 = 0;
			num10 = 1.0;
			material2 = (Material)40;
			num3 = 1.0;
			burst6 = (ParticleSystem.Burst)0;
			burst9 = burst7;
			vector = (Vector3)0;
			obj11 = null;
		}
		goto IL_0789;
		IL_0869:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0877;
		IL_0789:
		object obj27 = default;
		object obj26 = (object)(&obj27);
		if (obj26 != null)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj26);
			obj11 = null;
		}
		bool flag14 = ex == null;
		object obj28 = !flag14;
		if (obj28 == null)
		{
			bool flag15 = obj10 == null;
			object obj29 = !flag15;
			OutOfMemoryException ex3 = ex;
			if (obj29 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex3 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		burst5 = burst9;
		goto IL_083f;
		IL_084d:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_085b;
		IL_085b:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_0869;
		IL_0877:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		if ((nint)obj11 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj10 = 1;
			burst9 = burst5;
		}
		else
		{
			if ((nint)obj11 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj30 = default;
			ex = (OutOfMemoryException)obj30;
			burst9 = burst5;
		}
		goto IL_0789;
		IL_083f:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_084d;
	}

	public unsafe static void Punch(Transform at, Vector3 dir, Material mat)
	{
		//IL_0010: Expected Obj, but got I
		//IL_2333: Expected Obj, but got I4
		//IL_240a: Expected Obj, but got I
		//IL_00a6: Expected F8, but got I
		//IL_00b6: Invalid comparison between F4 and I
		//IL_236b: Expected Obj, but got I4
		//IL_0046: Expected VT, but got I4
		//IL_0110: Invalid comparison between F4 and I4
		//IL_0121: Expected Obj, but got I4
		//IL_012a: Invalid comparison between F4 and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_014f: Expected VT, but got I4
		//IL_0158: Expected VT, but got I4
		//IL_0161: Expected VT, but got I4
		//IL_016c: Expected VT, but got I4
		//IL_0174: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I4
		//IL_20ab: Expected Obj, but got Ref
		//IL_2389: Expected Obj, but got I
		//IL_23a1: Expected Obj, but got I
		//IL_23b1: Expected F4, but got I
		//IL_23c1: Expected F8, but got I
		//IL_23d1: Expected F8, but got I
		//IL_20f9: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I
		//IL_20d1: Expected I, but got Obj
		//IL_20da: Expected VT, but got I4
		//IL_01e6: Expected VT, but got I4
		//IL_01ef: Expected VT, but got I4
		//IL_01f8: Expected VT, but got I4
		//IL_0203: Expected VT, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_0216: Expected VT, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_023b: Expected F4, but got I4
		//IL_0244: Expected VT, but got I4
		//IL_2121: Expected Obj, but got I4
		//IL_0272: Expected VT, but got I4
		//IL_027b: Expected VT, but got I4
		//IL_0284: Expected VT, but got I4
		//IL_028f: Expected VT, but got I4
		//IL_0297: Expected Obj, but got I
		//IL_02a2: Expected VT, but got I4
		//IL_02ac: Expected Obj, but got I4
		//IL_02c7: Expected F4, but got I4
		//IL_02d0: Expected VT, but got I4
		//IL_02e6: Expected Obj, but got Ref
		//IL_031d: Expected F4, but got I
		//IL_0337: Expected Obj, but got I8
		//IL_034f: Expected VT, but got I4
		//IL_0358: Expected VT, but got I4
		//IL_0361: Expected VT, but got I4
		//IL_036c: Expected VT, but got I4
		//IL_0374: Expected Obj, but got I
		//IL_037f: Expected VT, but got I4
		//IL_0389: Expected Obj, but got Ref
		//IL_0394: Expected VT, but got I4
		//IL_039e: Expected Obj, but got I4
		//IL_03c0: Expected F4, but got I
		//IL_03c9: Expected VT, but got I4
		//IL_0412: Expected F4, but got I
		//IL_0412: Expected F4, but got I
		//IL_0434: Expected Obj, but got I4
		//IL_044a: Expected Obj, but got I
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected Obj, but got Unknown
		//IL_0478: Expected VT, but got I4
		//IL_0481: Expected VT, but got I4
		//IL_048a: Expected VT, but got I4
		//IL_0495: Expected VT, but got I4
		//IL_049d: Expected Obj, but got I
		//IL_04a8: Expected VT, but got I4
		//IL_04b4: Expected VT, but got I4
		//IL_04be: Expected Obj, but got Ref
		//IL_04c9: Expected VT, but got I4
		//IL_04d3: Expected Obj, but got I4
		//IL_04e8: Expected F8, but got I
		//IL_04f8: Expected F4, but got I
		//IL_0501: Expected VT, but got I4
		//IL_0546: Expected F4, but got I
		//IL_0560: Expected Obj, but got I8
		//IL_0578: Expected VT, but got I4
		//IL_0581: Expected VT, but got I4
		//IL_058a: Expected VT, but got I4
		//IL_0595: Expected VT, but got I4
		//IL_059d: Expected Obj, but got I
		//IL_05a8: Expected VT, but got I4
		//IL_05b4: Expected VT, but got I4
		//IL_05c0: Expected VT, but got I4
		//IL_05ca: Expected Obj, but got Ref
		//IL_05d5: Expected VT, but got I4
		//IL_05df: Expected Obj, but got I4
		//IL_05f4: Expected F8, but got I
		//IL_060a: Expected VT, but got I4
		//IL_062e: Expected Obj, but got I
		//IL_0658: Expected Obj, but got I
		//IL_0677: Expected F4, but got I
		//IL_0691: Expected F4, but got I
		//IL_06ae: Expected VT, but got I4
		//IL_06b7: Expected VT, but got I4
		//IL_06c0: Expected VT, but got I4
		//IL_06cb: Expected VT, but got I4
		//IL_06d3: Expected Obj, but got I
		//IL_06de: Expected VT, but got I4
		//IL_06ef: Expected VT, but got I4
		//IL_06fb: Expected VT, but got I4
		//IL_0707: Expected VT, but got I4
		//IL_0711: Expected Obj, but got Ref
		//IL_071c: Expected VT, but got I4
		//IL_0726: Expected Obj, but got I4
		//IL_073b: Expected F8, but got I
		//IL_0744: Expected F4, but got I4
		//IL_074d: Expected VT, but got I4
		//IL_077b: Expected VT, but got I4
		//IL_0784: Expected VT, but got I4
		//IL_078d: Expected VT, but got I4
		//IL_0798: Expected VT, but got I4
		//IL_07a0: Expected Obj, but got I
		//IL_07ab: Expected VT, but got I4
		//IL_07bc: Expected VT, but got I4
		//IL_07c8: Expected VT, but got I4
		//IL_07d4: Expected VT, but got I4
		//IL_07de: Expected Obj, but got Ref
		//IL_07e9: Expected VT, but got I4
		//IL_07f3: Expected Obj, but got I4
		//IL_0808: Expected F8, but got I
		//IL_0811: Expected F4, but got I4
		//IL_081a: Expected VT, but got I4
		//IL_0862: Expected F4, but got I
		//IL_0862: Expected F4, but got I
		//IL_087c: Expected Obj, but got I8
		//IL_0894: Expected VT, but got I4
		//IL_089d: Expected VT, but got I4
		//IL_08a6: Expected VT, but got I4
		//IL_08b1: Expected VT, but got I4
		//IL_08b9: Expected Obj, but got I
		//IL_08c4: Expected VT, but got I4
		//IL_08d0: Expected VT, but got I4
		//IL_08e1: Expected VT, but got I4
		//IL_08ed: Expected VT, but got I4
		//IL_08f9: Expected VT, but got I4
		//IL_0903: Expected Obj, but got Ref
		//IL_090e: Expected VT, but got I4
		//IL_0918: Expected Obj, but got I4
		//IL_092d: Expected F8, but got I
		//IL_093d: Expected F4, but got I
		//IL_0946: Expected VT, but got I4
		//IL_097d: Expected F4, but got I
		//IL_099e: Expected F4, but got I
		//IL_099e: Expected F4, but got I
		//IL_09c0: Expected Obj, but got I4
		//IL_09d6: Expected Obj, but got I
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected Obj, but got Unknown
		//IL_0a04: Expected VT, but got I4
		//IL_0a0d: Expected VT, but got I4
		//IL_0a16: Expected VT, but got I4
		//IL_0a21: Expected VT, but got I4
		//IL_0a29: Expected Obj, but got I
		//IL_0a34: Expected VT, but got I4
		//IL_0a40: Expected VT, but got I4
		//IL_0a4c: Expected VT, but got I4
		//IL_0a5d: Expected VT, but got I4
		//IL_0a69: Expected VT, but got I4
		//IL_0a75: Expected VT, but got I4
		//IL_0a7f: Expected Obj, but got Ref
		//IL_0a8a: Expected VT, but got I4
		//IL_0a94: Expected Obj, but got I4
		//IL_0aa9: Expected F8, but got I
		//IL_0ab9: Expected F4, but got I
		//IL_0ac2: Expected VT, but got I4
		//IL_0b07: Expected F4, but got I
		//IL_0b21: Expected Obj, but got I8
		//IL_0b39: Expected VT, but got I4
		//IL_0b42: Expected VT, but got I4
		//IL_0b4b: Expected VT, but got I4
		//IL_0b56: Expected VT, but got I4
		//IL_0b5e: Expected Obj, but got I
		//IL_0b69: Expected VT, but got I4
		//IL_0b75: Expected VT, but got I4
		//IL_0b81: Expected VT, but got I4
		//IL_0b8d: Expected VT, but got I4
		//IL_0b9e: Expected VT, but got I4
		//IL_0baa: Expected VT, but got I4
		//IL_0bb6: Expected VT, but got I4
		//IL_0bc0: Expected Obj, but got Ref
		//IL_0bcb: Expected VT, but got I4
		//IL_0bd5: Expected Obj, but got I4
		//IL_0bea: Expected F8, but got I
		//IL_0c00: Expected VT, but got I4
		//IL_2284: Invalid comparison between VT and I4
		//IL_0c36: Expected Obj, but got I
		//IL_22cb: Invalid comparison between VT and I4
		//IL_0c65: Expected Obj, but got I4
		//IL_0caf: Expected Obj, but got I
		//IL_0ccc: Expected Obj, but got I4
		//IL_22bd: Expected Obj, but got I4
		//IL_0ced: Expected VT, but got I4
		//IL_0cf6: Expected VT, but got I4
		//IL_0cff: Expected VT, but got I4
		//IL_0d0a: Expected VT, but got I4
		//IL_0d1a: Expected F4, but got I
		//IL_0d2a: Expected Obj, but got I4
		//IL_0d35: Expected VT, but got I4
		//IL_0d41: Expected VT, but got I4
		//IL_0d4d: Expected VT, but got I4
		//IL_0d59: Expected VT, but got I4
		//IL_0d62: Expected Obj, but got VT
		//IL_0d6d: Expected VT, but got I4
		//IL_0d79: Expected VT, but got I4
		//IL_0d85: Expected VT, but got I4
		//IL_0d9a: Expected VT, but got I4
		//IL_0da4: Expected Obj, but got I4
		//IL_0dc1: Expected VT, but got Obj
		//IL_0dfd: Expected F4, but got I
		//IL_0dfd: Expected F4, but got I
		//IL_0e0f: Expected VT, but got Ref
		//IL_0e2c: Expected F4, but got I
		//IL_0e3e: Expected VT, but got Ref
		//IL_0e5f: Expected F4, but got I
		//IL_0e5f: Expected F4, but got I
		//IL_0e71: Expected VT, but got Ref
		//IL_0e7e: Expected VT, but got Ref
		//IL_0ea4: Expected F4, but got I
		//IL_0ea4: Expected F4, but got I
		//IL_0eb1: Expected VT, but got Ref
		//IL_0ec7: Expected F4, but got I
		//IL_0ed8: Expected VT, but got Ref
		//IL_0f24: Expected VT, but got I4
		//IL_0f2d: Expected VT, but got I4
		//IL_0f5a: Expected F4, but got I
		//IL_0f72: Expected VT, but got I4
		//IL_0f7e: Expected VT, but got I4
		//IL_0f8a: Expected VT, but got I4
		//IL_0f96: Expected VT, but got I4
		//IL_0fa7: Expected VT, but got I4
		//IL_0fb3: Expected VT, but got I4
		//IL_0fbf: Expected VT, but got I4
		//IL_0fd4: Expected VT, but got I4
		//IL_0fde: Expected Obj, but got I4
		//IL_0fec: Expected F8, but got I4
		//IL_0ff5: Expected F4, but got I4
		//IL_0ffe: Expected VT, but got I4
		//IL_1023: Expected VT, but got I4
		//IL_102c: Expected VT, but got I4
		//IL_1059: Expected F4, but got I
		//IL_1071: Expected VT, but got I4
		//IL_107d: Expected VT, but got I4
		//IL_1089: Expected VT, but got I4
		//IL_1095: Expected VT, but got I4
		//IL_10a6: Expected VT, but got I4
		//IL_10b2: Expected VT, but got I4
		//IL_10be: Expected VT, but got I4
		//IL_10d3: Expected VT, but got I4
		//IL_10dd: Expected Obj, but got I4
		//IL_10eb: Expected F8, but got I4
		//IL_10f4: Expected F4, but got I4
		//IL_10fd: Expected VT, but got I4
		//IL_112c: Expected F4, but got I
		//IL_1146: Expected F4, but got I
		//IL_115d: Expected Obj, but got I8
		//IL_1175: Expected VT, but got I4
		//IL_117e: Expected VT, but got I4
		//IL_11ae: Expected F4, but got I
		//IL_11c6: Expected VT, but got I4
		//IL_11d2: Expected VT, but got I4
		//IL_11de: Expected VT, but got I4
		//IL_11ea: Expected VT, but got I4
		//IL_11fb: Expected VT, but got I4
		//IL_1207: Expected VT, but got I4
		//IL_1213: Expected VT, but got I4
		//IL_1228: Expected VT, but got I4
		//IL_1232: Expected Obj, but got I4
		//IL_1240: Expected F8, but got I4
		//IL_1249: Expected VT, but got I4
		//IL_1278: Expected F4, but got I
		//IL_1296: Expected F4, but got I
		//IL_12b5: Expected Obj, but got I4
		//IL_12c8: Expected Obj, but got I4
		//IL_12e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ed: Expected Obj, but got Unknown
		//IL_12f6: Expected VT, but got I4
		//IL_12ff: Expected VT, but got I4
		//IL_1332: Expected F4, but got I
		//IL_134a: Expected VT, but got I4
		//IL_1356: Expected VT, but got I4
		//IL_1362: Expected VT, but got I4
		//IL_136e: Expected VT, but got I4
		//IL_137f: Expected VT, but got I4
		//IL_138b: Expected VT, but got I4
		//IL_1397: Expected VT, but got I4
		//IL_13ac: Expected VT, but got I4
		//IL_13b6: Expected Obj, but got I4
		//IL_13d1: Expected VT, but got I4
		//IL_141e: Expected Obj, but got I8
		//IL_1436: Expected VT, but got I4
		//IL_143f: Expected VT, but got I4
		//IL_1475: Expected F4, but got I
		//IL_148d: Expected VT, but got I4
		//IL_1499: Expected VT, but got I4
		//IL_14a5: Expected VT, but got I4
		//IL_14b1: Expected VT, but got I4
		//IL_14c2: Expected VT, but got I4
		//IL_14ce: Expected VT, but got I4
		//IL_14da: Expected VT, but got I4
		//IL_14ef: Expected VT, but got I4
		//IL_14f9: Expected Obj, but got I4
		//IL_1507: Expected F8, but got I4
		//IL_151d: Expected VT, but got I4
		//IL_1586: Expected VT, but got Ref
		//IL_159b: Expected Obj, but got I
		//IL_15f1: Expected VT, but got I4
		//IL_15fa: Expected VT, but got I4
		//IL_1635: Expected F4, but got I
		//IL_164d: Expected VT, but got I4
		//IL_1659: Expected VT, but got I4
		//IL_1665: Expected VT, but got I4
		//IL_1671: Expected VT, but got I4
		//IL_1682: Expected VT, but got I4
		//IL_168e: Expected VT, but got I4
		//IL_169a: Expected VT, but got I4
		//IL_16a7: Expected VT, but got I4
		//IL_16b1: Expected Obj, but got I4
		//IL_16bf: Expected F8, but got I4
		//IL_16c8: Expected F4, but got I4
		//IL_16d0: Expected VT, but got I4
		//IL_16f5: Expected VT, but got I4
		//IL_16fe: Expected VT, but got I4
		//IL_1739: Expected F4, but got I
		//IL_1751: Expected VT, but got I4
		//IL_175d: Expected VT, but got I4
		//IL_1769: Expected VT, but got I4
		//IL_1775: Expected VT, but got I4
		//IL_1786: Expected VT, but got I4
		//IL_1792: Expected VT, but got I4
		//IL_179e: Expected VT, but got I4
		//IL_17ab: Expected VT, but got I4
		//IL_17b5: Expected Obj, but got I4
		//IL_17c3: Expected F8, but got I4
		//IL_17cc: Expected F4, but got I4
		//IL_17d4: Expected VT, but got I4
		//IL_1834: Expected F4, but got I4
		//IL_18a8: Expected I4, but got I8
		//IL_18dd: Expected F4, but got I
		//IL_18f3: Expected VT, but got Ref
		//IL_1904: Expected F4, but got I
		//IL_191a: Expected VT, but got Ref
		//IL_193a: Expected VT, but got Ref
		//IL_196a: Expected F4, but got I
		//IL_197a: Invalid comparison between F4 and I
		//IL_19c3: Expected F4, but got I
		//IL_19cc: Expected F8, but got I4
		//IL_19dc: Expected VT, but got I4
		//IL_19e8: Expected VT, but got I4
		//IL_19f4: Expected VT, but got I4
		//IL_1a00: Expected VT, but got I4
		//IL_1a11: Expected VT, but got I4
		//IL_1a1d: Expected VT, but got I4
		//IL_1a29: Expected VT, but got I4
		//IL_1a36: Expected VT, but got I4
		//IL_1a40: Expected Obj, but got I4
		//IL_1a56: Expected VT, but got I4
		//IL_1a8e: Expected Obj, but got I4
		//IL_1ac9: Expected Obj, but got I4
		//IL_1b1f: Expected F4, but got I
		//IL_1b30: Expected Obj, but got I4
		//IL_1b3b: Expected VT, but got I4
		//IL_1b47: Expected VT, but got I4
		//IL_1b53: Expected VT, but got I4
		//IL_1b5f: Expected VT, but got I4
		//IL_1b68: Expected Obj, but got VT
		//IL_1b73: Expected VT, but got I4
		//IL_1b7f: Expected VT, but got I4
		//IL_1b8b: Expected VT, but got I4
		//IL_1b98: Expected VT, but got I4
		//IL_1ba2: Expected Obj, but got I4
		//IL_1bbf: Expected VT, but got Obj
		//IL_1bfb: Expected F4, but got I
		//IL_1bfb: Expected F4, but got I
		//IL_1c0d: Expected VT, but got Ref
		//IL_1c2e: Expected F4, but got I
		//IL_1c2e: Expected F4, but got I
		//IL_1c40: Expected VT, but got Ref
		//IL_1c61: Expected F4, but got I
		//IL_1c61: Expected F4, but got I
		//IL_1c73: Expected VT, but got Ref
		//IL_1c80: Expected VT, but got Ref
		//IL_1ca6: Expected F4, but got I
		//IL_1ca6: Expected F4, but got I
		//IL_1cb3: Expected VT, but got Ref
		//IL_1cd7: Expected VT, but got Ref
		//IL_1d09: Expected VT, but got Ref
		//IL_1d9d: Expected F4, but got I
		//IL_1dae: Expected Obj, but got I4
		//IL_1db9: Expected VT, but got I4
		//IL_1dc5: Expected VT, but got I4
		//IL_1dd1: Expected VT, but got I4
		//IL_1ddd: Expected VT, but got I4
		//IL_1dee: Expected VT, but got I4
		//IL_1dfa: Expected VT, but got I4
		//IL_1e06: Expected VT, but got I4
		//IL_1e13: Expected VT, but got I4
		//IL_1e1d: Expected Obj, but got I4
		//IL_1e2b: Expected F8, but got I4
		//IL_1e34: Expected F4, but got I4
		//IL_1e3c: Expected VT, but got I4
		//IL_1ea3: Expected F4, but got I
		//IL_1eb4: Expected Obj, but got I4
		//IL_1ebf: Expected VT, but got I4
		//IL_1ecb: Expected VT, but got I4
		//IL_1ed7: Expected VT, but got I4
		//IL_1ee3: Expected VT, but got I4
		//IL_1ef4: Expected VT, but got I4
		//IL_1f00: Expected VT, but got I4
		//IL_1f0c: Expected VT, but got I4
		//IL_1f19: Expected VT, but got I4
		//IL_1f23: Expected Obj, but got I4
		//IL_1f31: Expected F8, but got I4
		//IL_1f3a: Expected F4, but got I4
		//IL_1f42: Expected VT, but got I4
		//IL_1fb7: Expected F4, but got I
		//IL_1fcc: Expected F4, but got I
		//IL_2007: Expected F4, but got I
		//IL_2010: Expected F8, but got I4
		//IL_2019: Expected Obj, but got I4
		//IL_2024: Expected VT, but got I4
		//IL_2030: Expected VT, but got I4
		//IL_203c: Expected VT, but got I4
		//IL_2048: Expected VT, but got I4
		//IL_2059: Expected VT, but got I4
		//IL_2065: Expected VT, but got I4
		//IL_2071: Expected VT, but got I4
		//IL_207e: Expected VT, but got I4
		//IL_2088: Expected Obj, but got I4
		//IL_2095: Expected F8, but got VT
		//IL_209e: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v4+10]");
		bool flag2 = (nint)0 == 0;
		Vector3 vector = dir;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v4+10]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			vector = (Vector3)0;
		}
		float num2 = default;
		float num = num2 * num2;
		double num4 = default;
		double num3 = num4 * num4;
		float num5 = num + (float)num3;
		double num7 = default;
		double num6 = num7 * num7;
		float num8 = (float)num6 + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		double num9 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		bool flag3 = !(num8 < 0f);
		float num10 = num2;
		double num11 = num4;
		double num12 = num7;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v105+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v106+18]");
			num10 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v106+1C]");
			num11 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v106+20]");
			num12 = 0.0;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num13 = Share(135f);
		bool flag5 = num13 < 0f;
		object obj10 = !flag5;
		bool flag6 = num13 == 0f;
		object obj11 = ~obj10;
		object obj12 = obj11 | flag6;
		ParticleSystem.CollisionModule collisionModule = (ParticleSystem.CollisionModule)0;
		ParticleSystem.ShapeModule shapeModule = (ParticleSystem.ShapeModule)0;
		ParticleSystem.EmissionModule emissionModule = (ParticleSystem.EmissionModule)0;
		ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)0;
		IntPtr intPtr = default;
		Material material = (Material)(nint)intPtr;
		object obj13 = 0;
		OutOfMemoryException ex = null;
		float num14 = num13;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CA8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Keyframe keyframe = new Keyframe(0f, 1f);
			IntPtr intPtr2 = default;
			bool flag7 = intPtr2 == (IntPtr)0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			material = (Material)(nint)intPtr;
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			num9 = 1.0;
			num14 = 0f;
			vector = (Vector3)0;
			if (flag7)
			{
				goto IL_2155;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v68 (System.IntPtr)+18]");
			bool flag8 = (nint)0 == 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			material = (Material)(nint)intPtr;
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			num9 = 1.0;
			num14 = 0f;
			vector = (Vector3)0;
			if (flag8)
			{
				goto IL_2163;
			}
			Keyframe keyframe2 = default;
			AnimationCurve animationCurve = (AnimationCurve)(&keyframe2);
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X23_v24 (UnityEngine.AnimationCurve)+E0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			Keyframe keyframe3 = new Keyframe(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v68 (System.IntPtr)+18]");
			object obj15 = 0 & 0xFFFFFFFEL;
			bool flag9 = obj15 == null;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			material = (Material)(nint)intPtr;
			keyframe3 = (Keyframe)0;
			AnimationCurve animationCurve2 = (AnimationCurve)(&keyframe2);
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			num9 = 1.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			num14 = 0f;
			vector = (Vector3)0;
			if (flag9)
			{
				goto IL_2171;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X23_v24 (UnityEngine.AnimationCurve)+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB8]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			Keyframe keyframe4 = new Keyframe(num15, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v68 (System.IntPtr)+18]");
			bool flag10 = (nint)0 < (nint)2;
			object obj16 = !flag10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v68 (System.IntPtr)+18]");
			object obj17 = -2;
			bool flag11 = obj17 == null;
			object obj18 = ~obj16;
			object obj19 = obj18 | flag11;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			material = (Material)(nint)intPtr;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = (AnimationCurve)(&keyframe2);
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			num9 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB8]");
			num14 = 0f;
			vector = (Vector3)0;
			if (obj19 != null)
			{
				goto IL_217f;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X23_v24 (UnityEngine.AnimationCurve)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			Keyframe keyframe5 = new Keyframe(1f, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v68 (System.IntPtr)+18]");
			object obj20 = 0 & 0xFFFFFFFCL;
			bool flag12 = obj20 == null;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			material = (Material)(nint)intPtr;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = (AnimationCurve)(&keyframe2);
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			num9 = 0.0;
			num14 = 1f;
			vector = (Vector3)0;
			if (flag12)
			{
				goto IL_218d;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C98]");
			object obj21 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X23_v24 (UnityEngine.AnimationCurve)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			AnimationCurve animationCurve3 = default;
			animationCurve3._002Ector((Keyframe[])(nint)intPtr2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num16 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			Keyframe keyframe6 = new Keyframe(0f, 0f);
			IntPtr intPtr3 = default;
			bool flag13 = intPtr3 == (IntPtr)0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			material = (Material)(nint)intPtr;
			keyframe6 = (Keyframe)0;
			Material material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = (AnimationCurve)(&keyframe2);
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			num9 = 0.0;
			num14 = 0f;
			vector = (Vector3)0;
			if (flag13)
			{
				goto IL_219b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2253 @ X0_v76 (System.IntPtr)+18]");
			bool flag14 = (nint)0 == 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			material = (Material)(nint)intPtr;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = (AnimationCurve)(&keyframe2);
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			num9 = 0.0;
			num14 = 0f;
			vector = (Vector3)0;
			if (flag14)
			{
				goto IL_21a9;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X23_v24 (UnityEngine.AnimationCurve)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			Keyframe keyframe7 = new Keyframe(num17, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2253 @ X0_v76 (System.IntPtr)+18]");
			object obj22 = 0 & 0xFFFFFFFEL;
			bool flag15 = obj22 == null;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			material = (Material)(nint)intPtr;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = (AnimationCurve)(&keyframe2);
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			num9 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			num14 = 0f;
			vector = (Vector3)0;
			if (flag15)
			{
				goto IL_21b7;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X23_v24 (UnityEngine.AnimationCurve)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			num16 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB8]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			Keyframe keyframe8 = new Keyframe(num18, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2253 @ X0_v76 (System.IntPtr)+18]");
			bool flag16 = (nint)0 < (nint)2;
			object obj23 = !flag16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2253 @ X0_v76 (System.IntPtr)+18]");
			object obj24 = -2;
			bool flag17 = obj24 == null;
			object obj25 = ~obj23;
			object obj26 = obj25 | flag17;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			material = (Material)(nint)intPtr;
			keyframe8 = (Keyframe)0;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = (AnimationCurve)(&keyframe2);
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			num9 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB8]");
			num14 = 0f;
			vector = (Vector3)0;
			if (obj26 != null)
			{
				goto IL_21c5;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X23_v24 (UnityEngine.AnimationCurve)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			keyframe2 = new Keyframe(1f, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2253 @ X0_v76 (System.IntPtr)+18]");
			object obj27 = 0 & 0xFFFFFFFCL;
			bool flag18 = obj27 == null;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			material = (Material)(nint)intPtr;
			keyframe2 = (Keyframe)0;
			keyframe8 = (Keyframe)0;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = (AnimationCurve)(&keyframe2);
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			num9 = 0.0;
			num14 = 1f;
			vector = (Vector3)0;
			if (flag18)
			{
				goto IL_21d3;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			AnimationCurve animationCurve4 = default;
			animationCurve4._002Ector((Keyframe[])(nint)intPtr3);
			object obj28 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3900 @ X0_v84+E4]");
			bool flag19 = (nint)0 == 0;
			object obj29 = !flag19;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float n = num13 * 1.1190927E+09f;
			short num19 = Some(n);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D58]");
			object name = 0;
			int most = default;
			ParticleSystem particleSystem = Particles((string)name, at, dir, (Material)num19, num10, most);
			bool flag20 = (object)particleSystem == null;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = (ParticleSystem.EmissionModule)0;
			mainModule = (ParticleSystem.MainModule)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			float num20 = 0f;
			num7 = num12;
			material = (Material)num19;
			keyframe2 = (Keyframe)0;
			keyframe8 = (Keyframe)0;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = (Material)dir;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = animationCurve4;
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			num9 = num11;
			num14 = num10;
			vector = (Vector3)at;
			if (flag20)
			{
				goto IL_21e1;
			}
			ParticleSystem.MainModule main = particleSystem.main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
			ParticleSystem.MinMaxCurve minMaxCurve = new ParticleSystem.MinMaxCurve(num21, 0f);
			ParticleSystem.MinMaxCurve minMaxCurve2 = default;
			mainModule.startLifetime = (ParticleSystem.MinMaxCurve)(&minMaxCurve2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABBC]");
			ParticleSystem.MinMaxCurve minMaxCurve3 = new ParticleSystem.MinMaxCurve(0f, animationCurve4, animationCurve3);
			ParticleSystem.MinMaxCurve minMaxCurve4 = default;
			mainModule.startSpeed = (ParticleSystem.MinMaxCurve)(&minMaxCurve4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB20]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF40]");
			ParticleSystem.MinMaxCurve minMaxCurve5 = new ParticleSystem.MinMaxCurve(num22, 0f);
			ParticleSystem.MinMaxCurve minMaxCurve6 = default;
			mainModule.startSizeY = (ParticleSystem.MinMaxCurve)(&minMaxCurve6);
			ParticleSystem.MinMaxCurve minMaxCurve7 = default;
			mainModule.startSizeX = (ParticleSystem.MinMaxCurve)(&minMaxCurve7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A99C]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA14]");
			ParticleSystem.MinMaxCurve minMaxCurve8 = new ParticleSystem.MinMaxCurve(num23, 0f);
			ParticleSystem.MinMaxCurve minMaxCurve9 = default;
			mainModule.startSizeZ = (ParticleSystem.MinMaxCurve)(&minMaxCurve9);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
			ParticleSystem.MinMaxCurve minMaxCurve10 = 0f;
			ParticleSystem.Burst burst = default;
			mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&burst);
			ParticleSystem.EmissionModule emission = particleSystem.emission;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Keyframe keyframe9 = new Keyframe(0f, 0f);
			AnimationCurve animationCurve5 = default;
			bool flag21 = (object)animationCurve5 == null;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = emission;
			mainModule = main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num20 = 0f;
			num7 = num12;
			material = null;
			keyframe2 = (Keyframe)0;
			keyframe8 = (Keyframe)0;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = animationCurve4;
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			num9 = 0.0;
			num14 = 0f;
			vector = (Vector3)0;
			if (flag21)
			{
				goto IL_21ef;
			}
			bool flag22 = (byte)(~(animationCurve5.m_RequiresNativeCleanup ? 1u : 0u)) != 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = emission;
			mainModule = main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num20 = 0f;
			num7 = num12;
			material = null;
			keyframe2 = (Keyframe)0;
			keyframe8 = (Keyframe)0;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = animationCurve4;
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			num9 = 0.0;
			num14 = 0f;
			vector = (Vector3)0;
			if (flag22)
			{
				goto IL_21fd;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			num14 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			Keyframe keyframe10 = new Keyframe(0f, 0f);
			object obj30 = (animationCurve5.m_RequiresNativeCleanup ? 1 : 0) & 0xFFFFFFFEL;
			bool flag23 = obj30 == null;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = emission;
			mainModule = main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num20 = 0f;
			num7 = num12;
			material = null;
			keyframe2 = (Keyframe)0;
			keyframe8 = (Keyframe)0;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = animationCurve4;
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			num9 = 0.0;
			vector = (Vector3)0;
			if (flag23)
			{
				goto IL_220b;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			num14 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			Keyframe keyframe11 = new Keyframe(0f, 1f);
			bool flag24 = (animationCurve5.m_RequiresNativeCleanup ? 1 : 0) < 2;
			object obj31 = !flag24;
			object obj32 = (animationCurve5.m_RequiresNativeCleanup ? 1 : 0) - 2;
			bool flag25 = obj32 == null;
			object obj33 = ~obj31;
			object obj34 = obj33 | flag25;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = emission;
			mainModule = main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num20 = 0f;
			num7 = num12;
			material = null;
			keyframe2 = (Keyframe)0;
			keyframe8 = (Keyframe)0;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = animationCurve4;
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			num9 = 1.0;
			vector = (Vector3)0;
			if (obj34 != null)
			{
				goto IL_2219;
			}
			_ = 0;
			_ = 0;
			Keyframe keyframe12 = new Keyframe(1f, 0f);
			object obj35 = (animationCurve5.m_RequiresNativeCleanup ? 1 : 0) & 0xFFFFFFFCL;
			bool flag26 = obj35 == null;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = emission;
			mainModule = main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num20 = 0f;
			num7 = num12;
			material = null;
			keyframe2 = (Keyframe)0;
			keyframe8 = (Keyframe)0;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			animationCurve2 = animationCurve4;
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			num9 = 0.0;
			num14 = 1f;
			vector = (Vector3)0;
			if (flag26)
			{
				goto IL_2227;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			AnimationCurve animationCurve6 = default;
			animationCurve6._002Ector((Keyframe[])(object)animationCurve5);
			float multiplier = num13 * 1.1083448E+09f;
			ParticleSystem.MinMaxCurve minMaxCurve11 = new ParticleSystem.MinMaxCurve(multiplier, animationCurve6);
			ParticleSystem.MinMaxCurve minMaxCurve12 = default;
			emissionModule.rateOverTime = (ParticleSystem.MinMaxCurve)(&minMaxCurve12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E50]");
			animationCurve2 = (AnimationCurve)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			float n2 = num13 * 1.1151606E+09f;
			short num24 = Some(n2);
			ParticleSystem.Burst burst2 = new ParticleSystem.Burst(0f, num24);
			AnimationCurve animationCurve7 = default;
			bool flag27 = (object)animationCurve7 == null;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = emission;
			mainModule = main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num20 = 0f;
			num7 = num12;
			material = null;
			keyframe2 = (Keyframe)0;
			keyframe8 = (Keyframe)0;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			num9 = 0.0;
			num14 = 0f;
			vector = (Vector3)num24;
			if (flag27)
			{
				goto IL_2235;
			}
			bool flag28 = (byte)(~(animationCurve7.m_RequiresNativeCleanup ? 1u : 0u)) != 0;
			collisionModule = (ParticleSystem.CollisionModule)0;
			shapeModule = (ParticleSystem.ShapeModule)0;
			emissionModule = emission;
			mainModule = main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num20 = 0f;
			num7 = num12;
			material = null;
			keyframe2 = (Keyframe)0;
			keyframe8 = (Keyframe)0;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			num9 = 0.0;
			num14 = 0f;
			vector = (Vector3)num24;
			if (flag28)
			{
				goto IL_2243;
			}
			_ = 0;
			_ = 0;
			_ = 0;
			emissionModule.SetBursts((ParticleSystem.Burst[])(object)animationCurve7);
			ParticleSystem.ShapeModule shape = particleSystem.shape;
			shapeModule.shapeType = (ParticleSystemShapeType)4;
			shapeModule.angle = 66f;
			shapeModule.radius = num16;
			ParticleSystem.CollisionModule collision = particleSystem.collision;
			collisionModule.enabled = true;
			collisionModule.type = (ParticleSystemCollisionType)1;
			collisionModule.mode = (ParticleSystemCollisionMode)0;
			collisionModule.quality = (ParticleSystemCollisionQuality)2;
			LayerMask collidesWith = -1797;
			collisionModule.collidesWith = collidesWith;
			collisionModule.enableDynamicColliders = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			ParticleSystem.MinMaxCurve minMaxCurve13 = 0f;
			object obj36 = default;
			collisionModule.dampen = (ParticleSystem.MinMaxCurve)(&obj36);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			ParticleSystem.MinMaxCurve minMaxCurve14 = 0f;
			object obj37 = default;
			collisionModule.bounce = (ParticleSystem.MinMaxCurve)(&obj37);
			ParticleSystem.MinMaxCurve minMaxCurve15 = 0f;
			object obj38 = default;
			collisionModule.lifetimeLoss = (ParticleSystem.MinMaxCurve)(&obj38);
			collisionModule.radiusScale = 0.5f;
			particleSystem.Play();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			num14 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			bool flag29 = num13 < 0f;
			shapeModule = shape;
			emissionModule = emission;
			mainModule = main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num20 = 0f;
			num7 = 0.0;
			material = null;
			keyframe2 = (Keyframe)0;
			keyframe8 = (Keyframe)0;
			keyframe7 = (Keyframe)0;
			keyframe6 = (Keyframe)0;
			material2 = null;
			keyframe5 = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			keyframe = (Keyframe)0;
			obj13 = 0;
			ex = null;
			double num25 = default;
			num9 = num25;
			vector = (Vector3)0;
			if (!flag29)
			{
				object obj39 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4106 @ X0_v145+E4]");
				bool flag30 = (nint)0 == 0;
				object obj40 = !flag30;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				ParticleSystem particleSystem2 = Particles((string)name, at, dir, (Material)45, num10, most);
				bool flag31 = (object)particleSystem2 == null;
				shapeModule = shape;
				emissionModule = emission;
				mainModule = main;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				num20 = 0f;
				num7 = num12;
				material = (Material)45;
				keyframe2 = (Keyframe)0;
				keyframe8 = (Keyframe)0;
				keyframe7 = (Keyframe)0;
				keyframe6 = (Keyframe)0;
				material2 = (Material)dir;
				keyframe5 = (Keyframe)0;
				keyframe4 = (Keyframe)0;
				keyframe3 = (Keyframe)0;
				keyframe = (Keyframe)0;
				obj13 = 0;
				ex = null;
				num9 = num11;
				num14 = num10;
				vector = (Vector3)at;
				if (flag31)
				{
					goto IL_2251;
				}
				ParticleSystem.MainModule main2 = particleSystem2.main;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
				nint num26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF8]");
				minMaxCurve = new ParticleSystem.MinMaxCurve(num26, 0f);
				ParticleSystem.MinMaxCurve minMaxCurve16 = default;
				mainModule.startLifetime = (ParticleSystem.MinMaxCurve)(&minMaxCurve16);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A910]");
				minMaxCurve3 = new ParticleSystem.MinMaxCurve(num27, 0f);
				ParticleSystem.MinMaxCurve minMaxCurve17 = default;
				mainModule.startSpeed = (ParticleSystem.MinMaxCurve)(&minMaxCurve17);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD88]");
				nint num28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABFC]");
				minMaxCurve5 = new ParticleSystem.MinMaxCurve(num28, 0f);
				ParticleSystem.MinMaxCurve minMaxCurve18 = default;
				mainModule.startSizeY = (ParticleSystem.MinMaxCurve)(&minMaxCurve18);
				ParticleSystem.MinMaxCurve minMaxCurve19 = default;
				mainModule.startSizeX = (ParticleSystem.MinMaxCurve)(&minMaxCurve19);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A884]");
				nint num29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AADC]");
				minMaxCurve8 = new ParticleSystem.MinMaxCurve(num29, 0f);
				ParticleSystem.MinMaxCurve minMaxCurve20 = default;
				mainModule.startSizeZ = (ParticleSystem.MinMaxCurve)(&minMaxCurve20);
				ParticleSystem.MinMaxCurve minMaxCurve21 = 0.5f;
				object obj41 = default;
				mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj41);
				ParticleSystem.EmissionModule emission2 = particleSystem2.emission;
				ParticleSystem.MinMaxCurve minMaxCurve22 = 0f;
				object obj42 = default;
				emissionModule.rateOverTime = (ParticleSystem.MinMaxCurve)(&obj42);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				float n3 = num13 * 1.1107041E+09f;
				short num30 = Some(n3);
				burst2 = new ParticleSystem.Burst(0f, num30);
				Transform transform = default;
				bool flag32 = (object)transform == null;
				shapeModule = shape;
				emissionModule = emission2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				num20 = 0f;
				num7 = num12;
				material = (Material)45;
				keyframe2 = (Keyframe)0;
				keyframe8 = (Keyframe)0;
				keyframe7 = (Keyframe)0;
				keyframe6 = (Keyframe)0;
				material2 = null;
				keyframe5 = (Keyframe)0;
				keyframe4 = (Keyframe)0;
				keyframe3 = (Keyframe)0;
				keyframe = (Keyframe)0;
				obj13 = 0;
				ex = null;
				num9 = 0.0;
				num14 = 0f;
				vector = (Vector3)num30;
				if (flag32)
				{
					goto IL_225f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4195 @ X0_v169 (UnityEngine.Transform)+18]");
				bool flag33 = (nint)0 == 0;
				shapeModule = shape;
				emissionModule = emission2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				num20 = 0f;
				num7 = num12;
				material = (Material)45;
				keyframe2 = (Keyframe)0;
				keyframe8 = (Keyframe)0;
				keyframe7 = (Keyframe)0;
				keyframe6 = (Keyframe)0;
				material2 = null;
				keyframe5 = (Keyframe)0;
				keyframe4 = (Keyframe)0;
				keyframe3 = (Keyframe)0;
				keyframe = (Keyframe)0;
				obj13 = 0;
				ex = null;
				num9 = 0.0;
				num14 = 0f;
				vector = (Vector3)num30;
				if (flag33)
				{
					goto IL_226d;
				}
				_ = 0;
				_ = 0;
				_ = 0;
				emissionModule.SetBursts((ParticleSystem.Burst[])(object)transform);
				ParticleSystem.ShapeModule shape2 = particleSystem2.shape;
				shapeModule.shapeType = (ParticleSystemShapeType)4;
				shapeModule.angle = 58f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D4]");
				num14 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D4]");
				shapeModule.radius = 0f;
				particleSystem2.Play();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				num20 = 0f;
				num7 = 0.0;
				material = (Material)45;
				keyframe2 = (Keyframe)0;
				keyframe8 = (Keyframe)0;
				keyframe7 = (Keyframe)0;
				keyframe6 = (Keyframe)0;
				material2 = null;
				keyframe5 = (Keyframe)0;
				keyframe4 = (Keyframe)0;
				keyframe3 = (Keyframe)0;
				keyframe = (Keyframe)0;
				obj13 = 0;
				ex = null;
				num9 = (double)burst2;
				vector = (Vector3)0;
			}
		}
		goto IL_20a3;
		IL_218d:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_219b;
		IL_217f:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		goto IL_218d;
		IL_21a9:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		goto IL_21b7;
		IL_219b:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_21a9;
		IL_21c5:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_21d3;
		IL_21b7:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		goto IL_21c5;
		IL_21e1:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_21ef;
		IL_21d3:
		IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
		goto IL_21e1;
		IL_21fd:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		goto IL_220b;
		IL_21ef:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_21fd;
		IL_220b:
		IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
		goto IL_2219;
		IL_2219:
		IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
		goto IL_2227;
		IL_2227:
		IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
		goto IL_2235;
		IL_20a3:
		IntPtr intPtr4 = default;
		object obj43 = (object)(&intPtr4);
		if (obj43 != null)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj43);
			vector = (Vector3)0;
		}
		bool flag34 = ex == null;
		object obj44 = !flag34;
		if (obj44 == null)
		{
			bool flag35 = obj13 == null;
			object obj45 = !flag35;
			OutOfMemoryException ex15 = ex;
			if (obj45 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex15 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_2155;
		IL_2243:
		IndexOutOfRangeException ex16 = new IndexOutOfRangeException();
		goto IL_2251;
		IL_2235:
		NullReferenceException ex17 = new NullReferenceException();
		goto IL_2243;
		IL_226d:
		IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
		if (vector == (Vector3)(object)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj13 = 1;
		}
		else
		{
			if (vector != (Vector3)(object)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj46 = default;
			ex = (OutOfMemoryException)obj46;
		}
		goto IL_20a3;
		IL_225f:
		NullReferenceException ex19 = new NullReferenceException();
		goto IL_226d;
		IL_2251:
		NullReferenceException ex20 = new NullReferenceException();
		goto IL_225f;
		IL_2163:
		IndexOutOfRangeException ex21 = new IndexOutOfRangeException();
		goto IL_2171;
		IL_2155:
		NullReferenceException ex22 = new NullReferenceException();
		goto IL_2163;
		IL_2171:
		IndexOutOfRangeException ex23 = new IndexOutOfRangeException();
		goto IL_217f;
	}

	private unsafe static ParticleSystem Particles(string name, Transform at, Vector3 dir, Material mat, float seconds, int most)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04e3: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0086: Expected VT, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_053a: Expected Obj, but got I
		//IL_054d: Expected VT, but got I4
		//IL_054d: Expected VT, but got I4
		//IL_055a: Expected VT, but got Ref
		//IL_0181: Expected I4, but got Obj
		//IL_0233: Expected F4, but got I
		//IL_0247: Expected Obj, but got I8
		//IL_02a9: Expected Obj, but got I4
		//IL_02b9: Expected Obj, but got I4
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_0302: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I
		//IL_035d: Expected VT, but got Ref
		//IL_0399: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got VT
		//IL_0440: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(name);
		if ((object)gameObject != null)
		{
			Transform transform = gameObject.transform;
			if ((object)transform != null)
			{
				transform.SetParent(at, worldPositionStays: false);
				Transform transform2 = gameObject.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v9+A0]");
				object obj4 = 0;
				Vector3 forward = default;
				Vector3 upwards = default;
				Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
				if ((object)transform2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD0]");
					object obj5 = 0;
					transform2.rotation = (Quaternion)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					ParticleSystem particleSystem = default;
					if ((object)particleSystem != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CA8]");
						object obj7 = 0;
						particleSystem.Stop(withChildren: true, (ParticleSystemStopBehavior)0);
						ParticleSystem.MainModule main = particleSystem.main;
						ParticleSystem.MainModule mainModule = default;
						float num = default;
						mainModule.duration = num;
						mainModule.loop = false;
						mainModule.startSize3D = true;
						object obj8 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v24+E4]");
						bool flag = (nint)0 == 0;
						object obj9 = !flag;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj8 = obj6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v24+A0]");
						object obj10 = 0;
						*(ParticleSystem.MinMaxGradient*)(&forward) = new ParticleSystem.MinMaxGradient((Color)0, (Color)0);
						object obj11 = default;
						mainModule.startColor = (ParticleSystem.MinMaxGradient)(&obj11);
						mainModule.simulationSpace = (ParticleSystemSimulationSpace)1;
						mainModule.maxParticles = (int)mat;
						ParticleSystem.SizeOverLifetimeModule sizeOverLifetime = particleSystem.sizeOverLifetime;
						ParticleSystem.SizeOverLifetimeModule sizeOverLifetimeModule = default;
						sizeOverLifetimeModule.enabled = true;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Keyframe keyframe = new Keyframe(0f, 1f);
						Keyframe[] array = default;
						if (array != null)
						{
							if (array.Length != 0)
							{
								_ = 0;
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
								Keyframe keyframe2 = new Keyframe(0f, 1f);
								object obj12 = array.Length & 0xFFFFFFFEL;
								if (obj12 != null)
								{
									_ = 0;
									_ = 0;
									_ = 0;
									Keyframe keyframe3 = new Keyframe(1f, 0f);
									bool flag2 = array.Length < 2;
									object obj13 = !flag2;
									object obj14 = array.Length - 2;
									bool flag3 = obj14 == null;
									object obj15 = ~obj13;
									object obj16 = obj15 | flag3;
									if (obj16 == null)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C98]");
										object obj17 = 0;
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD8]");
										object obj18 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										AnimationCurve animationCurve = default;
										animationCurve._002Ector(array);
										ParticleSystem.MinMaxCurve minMaxCurve = new ParticleSystem.MinMaxCurve(1f, animationCurve);
										object obj19 = default;
										sizeOverLifetimeModule.size = (ParticleSystem.MinMaxCurve)(&obj19);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
										ParticleSystemRenderer particleSystemRenderer = default;
										if ((object)particleSystemRenderer != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
											object obj20 = 0;
											particleSystemRenderer.renderMode = (ParticleSystemRenderMode)4;
											particleSystemRenderer.alignment = (ParticleSystemRenderSpace)4;
											Mesh mesh = Drop();
											particleSystemRenderer.mesh = mesh;
											particleSystemRenderer.sharedMaterial = (Material)dir;
											particleSystemRenderer.shadowCastingMode = (ShadowCastingMode)0;
											particleSystemRenderer.lightProbeUsage = (LightProbeUsage)1;
											particleSystemRenderer.enableGPUInstancing = false;
											object obj21 = obj20;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v50+E4]");
											bool flag4 = (nint)0 == 0;
											object obj22 = !flag4;
											if (obj22 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											float t = num + 2f;
											UnityEngine.Object.Destroy(gameObject, t);
											return particleSystem;
										}
										goto IL_0483;
									}
								}
							}
							goto IL_0491;
						}
					}
				}
			}
		}
		goto IL_0483;
		IL_0491:
		return (ParticleSystem)(object)new IndexOutOfRangeException();
		IL_0483:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0491;
	}

	private unsafe static AnimationCurve Pulses(int count)
	{
		//IL_0010: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_017f: Expected VT, but got Ref
		//IL_007c: Expected VT, but got Ref
		//IL_00c9: Expected VT, but got Ref
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_010c: Expected VT, but got I4
		//IL_0115: Expected VT, but got I4
		//IL_011e: Expected VT, but got I4
		//IL_0127: Expected VT, but got I4
		//IL_0130: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C98]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		AnimationCurve animationCurve = default;
		animationCurve._002Ector();
		if (count < 1)
		{
			goto IL_013e;
		}
		double num = (double)count + 0.5;
		double num2 = 1.0 / num;
		double num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
		double num4 = num3 * 0.0;
		object obj2 = 0;
		double num5 = 1.0;
		Keyframe keyframe2 = default;
		Keyframe keyframe4 = default;
		Keyframe keyframe;
		while (true)
		{
			double num6 = num2 * (double)obj2;
			keyframe = new Keyframe((float)num6, (float)num5);
			if ((object)animationCurve == null)
			{
				break;
			}
			int num7 = animationCurve.AddKey((Keyframe)(&keyframe2));
			float time = (float)num4 + (float)num6;
			float num8 = (float)num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			float value = num8 * 0f;
			Keyframe keyframe3 = new Keyframe(time, value);
			int num9 = animationCurve.AddKey((Keyframe)(&keyframe4));
			double num10 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A83C]");
			num5 = num10 * 0.0;
			obj2++;
			bool flag = count != (nint)obj2;
			keyframe = (Keyframe)0;
			keyframe = (Keyframe)0;
			keyframe4 = (Keyframe)0;
			keyframe3 = (Keyframe)0;
			keyframe2 = (Keyframe)0;
			if (flag)
			{
				continue;
			}
			goto IL_013e;
		}
		goto IL_0188;
		IL_0188:
		return (AnimationCurve)(object)new NullReferenceException();
		IL_013e:
		keyframe = new Keyframe(1f, 0f);
		if ((object)animationCurve != null)
		{
			object obj3 = default;
			int num11 = animationCurve.AddKey((Keyframe)(&obj3));
			return animationCurve;
		}
		goto IL_0188;
	}

	private static Mesh Drop()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0913: Expected Obj, but got I
		//IL_0935: Expected Obj, but got I4
		//IL_0a36: Expected Obj, but got I
		//IL_0a58: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I4
		//IL_08da: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0299: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_02ce: Expected F8, but got I
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_0351: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I4
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected Obj, but got Unknown
		//IL_03fd: Expected Obj, but got I4
		//IL_040d: Expected Obj, but got I4
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_0474: Expected Obj, but got I
		//IL_06d5: Expected Obj, but got I
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected Obj, but got Unknown
		//IL_06fd: Expected Obj, but got I
		//IL_071c: Expected Obj, but got I
		//IL_04db: Expected Obj, but got I
		//IL_04eb: Expected Obj, but got I
		//IL_04ff: Expected Obj, but got I8
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected Obj, but got Unknown
		//IL_051e: Expected Obj, but got I4
		//IL_052e: Expected F8, but got I
		//IL_053e: Expected Obj, but got I
		//IL_098a: Expected Obj, but got I4
		//IL_07e2: Expected Obj, but got I
		//IL_0776: Expected Obj, but got I8
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected Obj, but got Unknown
		//IL_078d: Expected Obj, but got I4
		//IL_09b1: Expected Obj, but got I4
		//IL_0a90: Expected Obj, but got I4
		//IL_0827: Expected Obj, but got I
		//IL_0581: Expected Obj, but got I
		//IL_079c: Expected Obj, but got I4
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Expected Obj, but got Unknown
		//IL_0625: Expected Obj, but got I
		//IL_063d: Expected Obj, but got I
		//IL_088f: Expected Obj, but got I4
		//IL_0963: Expected Obj, but got I4
		//IL_05f3: Expected Obj, but got I
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected Obj, but got Unknown
		//IL_09cf: Expected Obj, but got I
		//IL_0a01: Expected Obj, but got I
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected Obj, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected Obj, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected Obj, but got Unknown
		//IL_0697: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj6 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v45+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			goto IL_08c2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Vector3[] array = default;
		if (array != null)
		{
			if (array.Length != 0)
			{
				bool flag4 = array.Length == 1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B9D0]");
				_ = 0;
				if (!flag4)
				{
					bool flag5 = array.Length < 2;
					object obj11 = !flag5;
					object obj12 = array.Length - 2;
					bool flag6 = obj12 == null;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BBF0]");
					_ = 0;
					object obj13 = ~obj11;
					object obj14 = obj13 | flag6;
					if (obj14 == null)
					{
						bool flag7 = array.Length == 3;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3D8]");
						_ = 0;
						if (!flag7)
						{
							bool flag8 = array.Length < 4;
							object obj15 = !flag8;
							object obj16 = array.Length - 4;
							bool flag9 = obj16 == null;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3E0]");
							_ = 0;
							object obj17 = ~obj15;
							object obj18 = obj17 | flag9;
							if (obj18 == null)
							{
								bool flag10 = array.Length == 5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B338]");
								_ = 0;
								_ = 1070537661;
								if (!flag10)
								{
									bool flag11 = array.Length < 6;
									object obj19 = !flag11;
									object obj20 = array.Length - 6;
									bool flag12 = obj20 == null;
									_ = 1070537661;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3E8]");
									double num = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3E8]");
									_ = 0;
									object obj21 = ~obj19;
									object obj22 = obj21 | flag12;
									if (obj22 == null)
									{
										bool flag13 = array.Length == 7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B338]");
										_ = 0;
										_ = 3218021309L;
										if (!flag13)
										{
											bool flag14 = array.Length < 8;
											object obj23 = !flag14;
											object obj24 = array.Length - 8;
											bool flag15 = obj24 == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3E8]");
											_ = 0;
											_ = 3218021309L;
											object obj25 = ~obj23;
											object obj26 = obj25 | flag15;
											if (obj26 == null)
											{
												bool flag16 = array.Length == 9;
												_ = 3212836864L;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B940]");
												_ = 0;
												if (!flag16)
												{
													bool flag17 = array.Length < 10;
													object obj27 = !flag17;
													object obj28 = array.Length - 10;
													bool flag18 = obj28 == null;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B940]");
													_ = 0;
													_ = 1065353216;
													object obj29 = ~obj27;
													object obj30 = obj29 | flag18;
													if (obj30 == null)
													{
														bool flag19 = array.Length == 11;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B288]");
														object obj31 = 0;
														_ = 3212836864L;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B288]");
														_ = 0;
														if (!flag19)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B288]");
															_ = 0;
															_ = 1065353216;
															if (array.Length < 1)
															{
																goto IL_06c5;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
															object obj32 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
															object obj33 = 0;
															object obj34 = array.Length & 0xFFFFFFFFL;
															object obj35 = array + 32;
															object obj37 = default;
															object obj36 = obj37;
															object obj38 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3E8]");
															double num2 = 0.0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B288]");
															object obj39 = 0;
															object obj47 = default;
															while (true)
															{
																bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34);
																object obj40 = !flag20;
																if (obj40 != null)
																{
																	break;
																}
																object obj41 = obj33;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X0_v38+E4]");
																bool flag21 = (nint)0 == 0;
																object obj42 = !flag21;
																if (obj42 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																object obj43 = obj35 * obj35;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X24_v7+4]");
																nint num3 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X24_v7+4]");
																object obj44 = num3 * 0;
																object obj45 = obj43 + obj44;
																object obj46 = obj45 + obj47;
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
																object obj48;
																object obj49;
																if ((nint)obj47 > 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
																	obj48 = obj35 / obj46;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X24_v7+8]");
																	obj36 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X24_v7+8]");
																	obj49 = 0 / obj47;
																}
																else
																{
																	object obj50 = obj32;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v41+A0]");
																	object obj51 = 0;
																	obj48 = obj51;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v42+8]");
																	obj49 = 0;
																}
																bool flag22 = (nint)obj38 < array.Length;
																object obj52 = !flag22;
																if (obj52 != null)
																{
																	break;
																}
																obj31 = obj48 * 63;
																num = (double)obj49 * 0.5;
																obj38++;
																obj35 = obj31;
																obj35 += 12;
																obj34 = array.Length;
																bool flag23 = (nint)obj38 < array.Length;
																num2 = num;
																obj39 = obj31;
																if (flag23)
																{
																	continue;
																}
																goto IL_06c5;
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
			goto IL_08df;
		}
		goto IL_08ed;
		IL_08c2:
		object obj53 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v6+A0]");
		return (Mesh)0;
		IL_06c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		int[] array2 = default;
		object obj55 = array2 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC8]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Color32[] array3 = default;
		if (array3 != null)
		{
			if (array3.Length < 1)
			{
				goto IL_07d2;
			}
			object obj58 = array3.Length & 0xFFFFFFFFL;
			object obj59 = array3 + 32;
			object obj60 = 0;
			while (true)
			{
				bool flag24 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj60) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj58);
				object obj61 = !flag24;
				if (obj61 != null)
				{
					break;
				}
				obj58 = array3.Length;
				_ = 4294967295L;
				obj60++;
				if ((nint)obj60 < array3.Length)
				{
					continue;
				}
				goto IL_07d2;
			}
			goto IL_08df;
		}
		goto IL_08ed;
		IL_07d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Mesh mesh = default;
		mesh._002Ector();
		if ((object)mesh != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4ED0]");
			object name = 0;
			mesh.name = (string)name;
			mesh.vertices = array;
			mesh.triangles = array2;
			mesh.colors32 = array3;
			object obj63 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v29+E4]");
			bool flag25 = (nint)0 == 0;
			object obj64 = !flag25;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj63 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v29+A0]");
			object obj65 = 0;
			obj65 = mesh;
			object obj66 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj67 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v28+A0]");
			object obj68 = 0;
			if (obj68 != null)
			{
				((Mesh)obj68).RecalculateNormals();
				goto IL_08c2;
			}
		}
		goto IL_08ed;
		IL_08df:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_08ed;
		IL_08ed:
		return (Mesh)(object)new NullReferenceException();
	}

	static Blood()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EF8]");
		object name = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj = 0;
		IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker((string)name, 1, (MarkerFlags)0, 0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F150]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D7A0]");
		_ = 0;
	}
}
