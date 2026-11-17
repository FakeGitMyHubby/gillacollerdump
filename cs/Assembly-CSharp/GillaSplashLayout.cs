using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public static class GillaSplashLayout
{
	private sealed class _003C_003Ec__DisplayClass99_0
	{
		public int map;

		public GillaSplashGame _003C_003E4__this;

		internal bool _003CVotesFor_003Eb__0(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_000e: Expected Obj, but got VT
			//IL_0070: Expected I4, but got Obj
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected VT, but got Unknown
			object obj = kv >> 32;
			if (map == (nint)obj)
			{
				if ((object)_003C_003E4__this != null)
				{
					PlayerRef p = (PlayerRef)(kv & 0xFFFFFFFFL);
					return _003C_003E4__this.InRoom(p);
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public struct Kind
	{
		public string name;

		public string model;

		public float across;

		public float along;

		public bool safe;

		public unsafe Kind(string name, string model, float across, float along, bool safe = default(bool))
		{
			//IL_001f: Expected Obj, but got Ref
			this.name = name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			obj = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public struct Spot
	{
		public int kind;

		public float x;

		public float z;

		public float yaw;
	}

	public struct Hall
	{
		public Rect water;

		public Vector3[] pillars;
	}

	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass17_0
	{
		public System.Random rng;

		public string[] picks;

		public float safeShare;

		public float lo;

		public float hi;

		public Rect w;

		public Hall hall;
	}

	public static readonly Kind[] Kinds;

	public const int Styles = default(int);

	public const int MostInAHall = default(int);

	private static readonly string[][][] Picks;

	private const float Grid = default(float);

	private const float YawStep = default(float);

	public static float Hard(int round)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_002b: Invalid comparison between F8 and I4
		//IL_003a: Expected F4, but got I4
		object obj = round - 1;
		double num = (double)obj / 6.0;
		bool flag = num < 0.0;
		float result = 0f;
		if (!flag)
		{
			bool flag2 = !(num > 1.0);
			result = (float)num;
			if (!flag2)
			{
				result = 1f;
			}
		}
		return result;
	}

	public unsafe static (float, float) Gaps(int style, int round)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_004f: Invalid comparison between F8 and I4
		//IL_005e: Expected F8, but got I4
		//IL_00f9: Expected F8, but got I
		//IL_0201: Invalid comparison between F8 and I4
		//IL_0210: Invalid comparison between F8 and I4
		//IL_0228: Expected Obj, but got F8
		//IL_0235: Expected Obj, but got F8
		//IL_026a: Expected Obj, but got I4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_011b: Expected F8, but got I
		//IL_012b: Expected F8, but got I
		//IL_02e6: Invalid comparison between F8 and I4
		//IL_0306: Invalid comparison between F8 and I4
		//IL_0158: Expected F8, but got I4
		//IL_0360: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = round - 1;
		double num = (double)obj4 / 6.0;
		bool flag2 = num < 0.0;
		double num2 = 0.0;
		if (!flag2)
		{
			bool flag3 = !(num > 1.0);
			num2 = num;
			if (!flag3)
			{
				num2 = 1.0;
			}
		}
		double num3;
		double num4;
		switch (style)
		{
		case 2:
			num3 = 3.0;
			num4 = 4.0;
			break;
		case 1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
			num3 = 0.0;
			num4 = 3.0;
			break;
		default:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A888]");
			num3 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAF4]");
			num4 = 0.0;
			break;
		}
		double num5 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
		double num6 = num5 + 0.0;
		double num7 = num2 - 1.0;
		bool flag4 = num7 < 0.0;
		bool flag5 = num7 == 0.0;
		object obj5 = num2 ^ 1.0;
		object obj6 = num2 ^ num7;
		object obj7 = obj5 & obj6;
		bool flag6 = (nint)obj7 < 0;
		bool flag7 = flag4 == flag6;
		object obj8 = !flag5;
		object obj9 = flag7 & obj8;
		object obj10 = ~obj9;
		double num8 = ((obj10 != null) ? num2 : 1.0);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC00]");
		double num9 = 0.0 - num4;
		double num10 = num6 - num3;
		double num11 = num10 * 0.0;
		double num12 = num8 * num10;
		double num13 = ((!(num2 < 0.0)) ? num8 : 0.0);
		if (num2 < 0.0)
		{
			num12 = num11;
		}
		double num14 = num9 * num13;
		float item = (float)num3 + (float)num12;
		float item2 = (float)num4 + (float)num14;
		(float, float) tuple = (item, item2);
		return ((float, float))(&tuple);
	}

	public static int HowMany(int round)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_004f: Invalid comparison between F8 and I4
		//IL_005e: Expected F8, but got I4
		//IL_026c: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I4
		//IL_00d5: Invalid comparison between F8 and I4
		//IL_025c: Expected I4, but got F8
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = round - 1;
		double num = (double)obj4 / 6.0;
		bool flag2 = num < 0.0;
		double num2 = 0.0;
		if (!flag2)
		{
			bool flag3 = num > 1.0;
			num2 = 18.0;
			if (!flag3)
			{
				num2 = num * 18.0;
			}
		}
		double num3 = 1110966272.0 - num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num4;
		double num5 = default;
		double num6;
		if (num3 < 0.0)
		{
			if (num3 == -0.5)
			{
				num4 = num5;
				num6 = -1.0;
				goto IL_020d;
			}
			num4 = num3 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num3 == 0.5)
			{
				num4 = num5;
				num6 = 1.0;
				goto IL_020d;
			}
			num4 = num3 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_0257;
		IL_020d:
		double num7 = num4 + num6;
		object obj8 = num4 & 1;
		bool flag5 = obj8 == null;
		object obj9 = !flag5;
		if (obj9 != null)
		{
			num4 = num7;
		}
		goto IL_0257;
		IL_0257:
		return (int)num4;
	}

	public static float SafeShare(int round)
	{
		//IL_0101: Expected F4, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_0087: Invalid comparison between F8 and I4
		//IL_0096: Expected F8, but got I4
		//IL_00b4: Expected F8, but got I
		bool flag = round < 2;
		float result = 0f;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = round - 1;
			double num = (double)obj4 / 6.0;
			bool flag3 = num < 0.0;
			double num2 = 0.0;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD58]");
				num2 = 0.0;
				if (!(num > 1.0))
				{
					num2 = num * num2;
				}
			}
			result = 0.25f - (float)num2;
		}
		return result;
	}

	public unsafe static List<Spot> Make(Hall[] halls, int style, int round, System.Random rng)
	{
		//IL_0010: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected I4, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00ed: Expected Obj, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_01f0: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got I4
		//IL_01cf: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = round - 1;
		bool flag2 = (nint)obj4 < 0;
		bool flag3 = obj4 == null;
		int num = round ^ 1;
		int num2 = round ^ obj4;
		int num3 = num & num2;
		bool flag4 = num3 < 0;
		bool flag5 = flag2 == flag4;
		object obj5 = !flag3;
		object obj6 = flag5 & obj5;
		object obj7 = ~obj6;
		int num4 = ((obj7 != null) ? 1 : round);
		if (halls != null)
		{
			object obj8 = num4 - 1;
			object obj9 = obj8 * 2863311531L;
			object obj10 = obj9 >> 33;
			object obj11 = obj10 + obj10;
			object obj12 = obj8 - obj11;
			if ((nint)obj12 < halls.Length)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
				object obj13 = 0;
				object obj14 = obj12 * 24;
				object obj15 = (object)halls + obj14;
				object obj16 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v9+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj18 = default;
				return MakeHall((Hall)(&obj18), style, round, rng);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79E8]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<Spot> list = default;
			list._002Ector();
			return list;
		}
		return (List<Spot>)(object)new NullReferenceException();
	}

	public unsafe static List<Spot> MakeHall(Hall hall, int style, int round, System.Random rng)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected I4, but got Unknown
		//IL_0274: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I4
		//IL_0362: Expected Obj, but got I
		//IL_0372: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I4
		//IL_0344: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I
		//IL_01da: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = style - 2;
		bool flag = (nint)obj3 < 0;
		int num = style ^ 2;
		int num2 = style ^ obj3;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		int num4 = ((obj5 != null) ? 2 : style);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+8]");
		if ((nint)0 == 0)
		{
			goto IL_01e3;
		}
		int num5 = ~num4;
		int num6 = num4 & num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+18]");
		bool flag5 = (nint)num6 < (nint)0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+8]");
			object obj10 = (nint)0 + (nint)num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v8+20]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v8+20]");
			if ((nint)0 == 0)
			{
				goto IL_01e3;
			}
			object obj12 = round - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v9+18]");
			object obj13 = -1;
			object obj14 = obj12 - obj13;
			bool flag6 = (nint)obj14 < 0;
			object obj15 = obj12 ^ obj13;
			object obj16 = obj12 ^ obj14;
			object obj17 = obj15 & obj16;
			bool flag7 = (nint)obj17 < 0;
			bool flag8 = flag6 == flag7;
			object obj18 = !flag8;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
				obj13 = obj12;
			}
			bool flag9 = (nint)obj12 < 0;
			object obj20 = obj12 ^ obj12;
			object obj21 = obj12 & obj20;
			bool flag10 = (nint)obj21 < 0;
			bool flag11 = flag9 == flag10;
			object obj22 = !flag11;
			object obj23 = ~obj22;
			object obj24 = ((obj23 != null) ? obj13 : ((object)0));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v9+18]");
			bool flag12 = (nint)obj24 < 0;
			object obj25 = !flag12;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v8+20]");
				object obj26 = 0 + obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v10+20]");
				object obj27 = default;
				return LayHall((Hall)(&obj27), (string[])0, num6, round, rng);
			}
		}
		goto IL_01f1;
		IL_01e3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01f1;
		IL_01f1:
		return (List<Spot>)(object)new IndexOutOfRangeException();
	}

	private static int KindOf(string name)
	{
		//IL_0185: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I
		//IL_0175: Expected I4, but got Obj
		//IL_0065: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
		object obj = 0;
		object obj2 = 32;
		int num = 0;
		while (true)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v4+A0]");
			object obj5 = 0;
			object obj6 = obj5;
			if (obj5 == null)
			{
				goto IL_0159;
			}
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+18]");
			if ((nint)num2 < (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v11+A0]");
					object obj9 = 0;
					obj6 = obj9;
					if (obj9 == null)
					{
						goto IL_0159;
					}
				}
				int num3 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+18]");
				bool flag3 = (nint)num3 < (nint)0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+v42 @ X22_v2]");
					bool flag4 = (string)0 == name;
					bool flag5 = !flag4;
					object obj11 = !flag5;
					if (obj11 != null)
					{
						break;
					}
					num++;
					obj2 += 32;
					continue;
				}
				goto IL_0167;
			}
			num = 0;
			break;
			IL_0167:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			return (int)ex;
			IL_0159:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0167;
		}
		return num;
	}

	private static int SafeLike(int kind)
	{
		//IL_0010: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I
		//IL_0314: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0436: Expected Obj, but got I4
		//IL_035c: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_0222: Expected Obj, but got I4
		//IL_0391: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I4
		//IL_0293: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v12+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)kind;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5+18]");
			object obj7 = -kind;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 != null)
			{
				goto IL_0306;
			}
			object obj10 = obj4 + kind;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v8+30]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v8+34]");
			object obj12 = 0;
			object obj13 = 2139095039;
			int num = 0;
			int result = kind;
			object obj14 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v12+E4]");
				bool flag4 = (nint)0 == 0;
				object obj15 = !flag4;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v12+A0]");
				object obj16 = 0;
				object obj17 = obj16;
				if (obj16 == null)
				{
					break;
				}
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v14+18]");
				if ((nint)num2 < (nint)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v12+E4]");
					bool flag5 = (nint)0 == 0;
					object obj18 = !flag5;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v12+A0]");
						object obj19 = 0;
						obj17 = obj19;
						if (obj19 == null)
						{
							break;
						}
					}
					int num3 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v14+18]");
					bool flag6 = (nint)num3 < (nint)0;
					object obj20 = !flag6;
					if (obj20 == null)
					{
						object obj21 = obj17 + obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v15+38]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v12+E4]");
							bool flag7 = (nint)0 == 0;
							object obj22 = !flag7;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj2 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v12+A0]");
							object obj23 = 0;
							object obj24 = obj23;
							if (obj23 == null)
							{
								break;
							}
							int num4 = num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v21+18]");
							bool flag8 = (nint)num4 < (nint)0;
							object obj25 = !flag8;
							if (obj25 != null)
							{
								goto IL_0306;
							}
							object obj26 = obj23 + obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v22+34]");
							obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v22+30]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v22+34]");
							obj11 = num5 * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
							{
								result = num;
								goto IL_03b6;
							}
						}
						obj11 = obj13;
						goto IL_03b6;
					}
					goto IL_0306;
				}
				return result;
				IL_03b6:
				num++;
				obj14 += 32;
				obj13 = obj11;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0306;
		IL_0306:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
	}

	private unsafe static List<Spot> LayHall(Hall hall, string[] picks, int style, int round, System.Random rng)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0018: Expected Obj, but got Ref
		//IL_152e: Expected Obj, but got I
		//IL_1546: Expected Obj, but got I
		//IL_155e: Expected Obj, but got Ref
		//IL_0051: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		//IL_0201: Expected VT, but got Obj
		//IL_022a: Expected Obj, but got I4
		//IL_0233: Expected VT, but got I4
		//IL_023c: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_027a: Expected F4, but got I
		//IL_0282: Expected Obj, but got Ref
		//IL_18ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b2: Expected Obj, but got Unknown
		//IL_0300: Expected VT, but got Obj
		//IL_0330: Expected VT, but got Obj
		//IL_07ef: Expected Obj, but got I4
		//IL_0804: Expected Obj, but got I
		//IL_03a4: Expected VT, but got Obj
		//IL_03d4: Expected VT, but got Obj
		//IL_083d: Invalid comparison between VT and I4
		//IL_135d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1362: Expected Obj, but got Unknown
		//IL_137f: Expected Obj, but got I
		//IL_13ba: Expected Obj, but got I
		//IL_13ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cf: Expected Obj, but got Unknown
		//IL_1404: Expected Obj, but got I4
		//IL_140c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1411: Expected Obj, but got Unknown
		//IL_049f: Expected Obj, but got I4
		//IL_0861: Expected Obj, but got I
		//IL_087b: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I4
		//IL_180c: Expected Obj, but got I
		//IL_089a: Expected Obj, but got I
		//IL_08a2: Expected VT, but got Obj
		//IL_08b4: Invalid comparison between VT and I4
		//IL_0444: Expected Obj, but got I
		//IL_045e: Invalid comparison between F4 and I
		//IL_1452: Expected Obj, but got I
		//IL_146c: Expected Obj, but got I
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected Obj, but got Unknown
		//IL_08e7: Expected Obj, but got VT
		//IL_1492: Expected Obj, but got I
		//IL_14bc: Expected Obj, but got I4
		//IL_05c4: Expected Obj, but got I4
		//IL_05d1: Expected Obj, but got I8
		//IL_05da: Expected F4, but got I4
		//IL_0636: Invalid comparison between F4 and I
		//IL_092f: Expected Obj, but got I4
		//IL_15c0: Expected VT, but got Ref
		//IL_15cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d2: Expected Obj, but got Unknown
		//IL_15f4: Expected Obj, but got VT
		//IL_1604: Expected Obj, but got Ref
		//IL_1614: Expected Obj, but got Ref
		//IL_1654: Expected Obj, but got Ref
		//IL_1664: Expected VT, but got Ref
		//IL_098d: Expected Obj, but got I4
		//IL_09a5: Invalid comparison between F4 and I4
		//IL_09b6: Expected Obj, but got I4
		//IL_09cb: Expected I4, but got Obj
		//IL_0ff3: Expected I4, but got I8
		//IL_0ffb: Expected Obj, but got Ref
		//IL_0a91: Invalid comparison between VT and I4
		//IL_0aa2: Expected Obj, but got I4
		//IL_0aaa: Expected VT, but got I4
		//IL_0ab2: Expected Obj, but got VT
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Expected Obj, but got Unknown
		//IL_0b1d: Expected Obj, but got VT
		//IL_0b2a: Expected I4, but got I8
		//IL_0688: Expected Obj, but got I
		//IL_1010: Expected Obj, but got I
		//IL_1020: Expected Obj, but got I
		//IL_1030: Expected Obj, but got I
		//IL_1040: Expected Obj, but got I
		//IL_0a17: Expected Obj, but got I4
		//IL_073c: Expected Obj, but got I4
		//IL_0b73: Expected Obj, but got I4
		//IL_107f: Expected I4, but got I8
		//IL_1099: Expected Obj, but got I4
		//IL_0bd1: Expected Obj, but got I4
		//IL_0be9: Invalid comparison between F4 and I4
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Expected Obj, but got Unknown
		//IL_119a: Expected Obj, but got I4
		//IL_0797: Expected Obj, but got I
		//IL_07a0: Expected Obj, but got I4
		//IL_07a9: Expected Obj, but got I4
		//IL_07b9: Expected F4, but got I
		//IL_07c9: Expected F4, but got I
		//IL_11e1: Expected Obj, but got I4
		//IL_10ea: Expected Obj, but got I4
		//IL_0c25: Expected I4, but got I8
		//IL_0c3f: Expected Obj, but got I4
		//IL_0c47: Expected I4, but got Obj
		//IL_0a58: Expected Obj, but got I
		//IL_113e: Expected Obj, but got I4
		//IL_114b: Expected Obj, but got I8
		//IL_178d: Expected VT, but got Ref
		//IL_179a: Unknown result type (might be due to invalid IL or missing references)
		//IL_179f: Expected Obj, but got Unknown
		//IL_17c1: Expected Obj, but got Ref
		//IL_17d1: Expected VT, but got Ref
		//IL_0d4e: Expected VT, but got I4
		//IL_12b7: Expected Obj, but got I4
		//IL_12c4: Expected Obj, but got I8
		//IL_12cd: Expected F4, but got I4
		//IL_12f2: Expected Obj, but got I
		//IL_1311: Expected Obj, but got Ref
		//IL_1321: Expected VT, but got Ref
		//IL_0fbb: Expected Obj, but got VT
		//IL_0cd2: Expected F8, but got I4
		//IL_0cda: Expected F4, but got I4
		//IL_0cea: Expected F8, but got I4
		//IL_0cfa: Expected F4, but got I4
		//IL_0fe1: Expected Obj, but got Ref
		//IL_0d99: Expected Obj, but got I4
		//IL_0dc9: Expected Obj, but got I4
		//IL_0f81: Expected Obj, but got I4
		//IL_0e48: Expected Obj, but got I4
		//IL_0ea6: Expected Obj, but got I4
		//IL_0ebe: Invalid comparison between F4 and I4
		//IL_0ecf: Expected Obj, but got I4
		//IL_0ee4: Expected VT, but got Obj
		//IL_0f13: Expected Obj, but got I4
		//IL_0f37: Expected Obj, but got I
		//IL_0f54: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
		object obj = 0;
		object obj3 = default;
		object obj2 = (object)(&obj3);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = (nint)(&obj3) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 64));
		_ = hall.water;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79E8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7ED0]");
		object obj10 = 0;
		int num2 = default;
		float num = SafeShare(num2);
		int num3 = HowMany(num2);
		(float, float) tuple = Gaps(style, num2);
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7668]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7650]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7660]");
		object obj15 = 0;
		float num5 = default;
		float num4 = num5 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7980]");
		object obj16 = 0;
		object obj17 = default;
		float x = (float)obj17 + num4;
		Vector2[] array = Corners(x, -5f, num5, 10f, 0f);
		float num6 = num5 * 0.5f;
		float x2 = (float)obj17 + num6;
		object obj18 = default;
		float num7 = (float)obj18 + 5f;
		Vector2[] array2 = Corners(x2, num7, num5, 10f, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Vector2 vector = (Vector2)obj10;
		List<Spot> list = default;
		list._002Ector();
		int num8 = num3 << 5;
		System.__Canon _Canon = (System.__Canon)(num8 - num3);
		_003C_003Ec__DisplayClass17_0 obj19 = (_003C_003Ec__DisplayClass17_0)0;
		object obj20 = 0;
		List<Spot> list2 = list;
		float num9 = num5;
		double num10 = 0.5;
		int num11 = num3;
		object obj21 = 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C338]");
		float num12 = 0f;
		object obj22 = (object)(&obj19);
		object obj23 = obj9;
		List<Spot> list3 = default;
		List<System.__Canon> list4 = default;
		object obj26 = default;
		object obj28 = default;
		float num14 = default;
		int num21 = default;
		GillaSplashLobby._003C_003Ec__DisplayClass17_1 obj40 = default;
		object arg = default;
		Queue<int> queue = default;
		object obj64 = default;
		object obj67 = default;
		GillaSplashLobby._003C_003Ec__DisplayClass17_1 obj95 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			list3._002Ector();
			object obj24 = obj22 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			list4._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag3 = (nint)_Canon < 1;
			List<System.__Canon> list5 = list4;
			List<System.__Canon> list6 = list4;
			System.__Canon _Canon2 = _Canon;
			ref GillaSplashLobby._003C_003Ec__DisplayClass17_1 reference = ref *(GillaSplashLobby._003C_003Ec__DisplayClass17_1*)num2;
			object obj25 = obj26;
			object obj27 = obj28;
			float num13 = num14;
			obj19 = (_003C_003Ec__DisplayClass17_0)list4;
			float num15 = num7;
			float num16 = num9;
			double num17 = num10;
			object obj29 = obj21;
			float num18 = num12;
			vector = (Vector2)list4;
			object obj30 = obj14;
			if (flag3)
			{
				goto IL_07e6;
			}
			while (list3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v25 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
				bool flag4 = (nint)0 >= (nint)num11;
				reference = ref *(GillaSplashLobby._003C_003Ec__DisplayClass17_1*)num2;
				obj25 = obj26;
				obj27 = obj28;
				num13 = num14;
				obj19 = (_003C_003Ec__DisplayClass17_0)list5;
				num15 = num7;
				num16 = num9;
				num17 = num10;
				obj29 = obj21;
				num18 = num12;
				vector = (Vector2)list6;
				obj30 = obj14;
				if (flag4)
				{
					goto IL_07e6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v25 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
				ref GillaSplashLobby._003C_003Ec__DisplayClass17_1 reference2;
				object obj41;
				Vector2[] array3;
				float num22;
				if ((nint)0 != 0)
				{
					if (obj3 == null)
					{
						break;
					}
					object obj31 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X8_v82+1C0]");
					list6 = (List<System.__Canon>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v884 @ X8_v82+1B8] (should have been resolved before IL gen)");
					float num19 = num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BAC8]");
					if (!(num19 < 0f))
					{
						if (obj3 == null)
						{
							break;
						}
						object obj32 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v885 @ X8_v83+1B8] (should have been resolved before IL gen)");
						float num20 = num12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C338]");
						if (num20 < 0f)
						{
							if (obj3 == null)
							{
								break;
							}
							object obj33 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v25 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
							object obj34 = -6;
							object obj35 = ~obj34;
							object obj36 = obj34 & obj35;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1143 @ X8_v88+1A0]");
							reference2 = ref *(GillaSplashLobby._003C_003Ec__DisplayClass17_1*)null;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1143 @ X8_v88+198] (should have been resolved before IL gen)");
						}
						else
						{
							if (obj3 == null)
							{
								break;
							}
							object obj37 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1151 @ X8_v87+1A8] (should have been resolved before IL gen)");
							reference2 = ref *(GillaSplashLobby._003C_003Ec__DisplayClass17_1*)num2;
						}
						if (list5 == null)
						{
							break;
						}
						obj21 = obj15;
						System.__Canon _Canon3 = list5.get_Item(num21);
						object obj38 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v85+E4]");
						bool flag5 = (nint)0 == 0;
						object obj39 = !flag5;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Vector2 vector2 = _003CLayHall_003Eg__Middle_007C17_2(num21, ref obj40);
						if (obj3 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7650]");
						obj14 = 0;
						obj26 = 1135869952;
						obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C338]");
						num14 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C338]");
						num22 = 0f;
						num10 = num12;
						obj41 = obj3;
						array3 = (Vector2[])(object)_Canon3;
						goto IL_1577;
					}
				}
				object obj42 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X0_v118+E4]");
				bool flag6 = (nint)0 == 0;
				object obj43 = !flag6;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj44 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X0_v120+E4]");
				bool flag7 = (nint)0 == 0;
				object obj45 = !flag7;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (obj3 == null)
				{
					break;
				}
				object obj46 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v883 @ X8_v80+1B8] (should have been resolved before IL gen)");
				if (obj3 == null)
				{
					break;
				}
				float num23 = (float)obj17 + num5;
				double num24 = (double)obj17 + 3.0;
				float num25 = num23 + -3f;
				num22 = num25 - (float)num24;
				num12 = num22 * num12;
				num10 = num24 + (double)num12;
				reference2 = ref *(GillaSplashLobby._003C_003Ec__DisplayClass17_1*)num2;
				obj26 = 1123024896;
				obj28 = 3262119936L;
				num14 = 0f;
				num9 = (float)num24;
				obj41 = obj3;
				array3 = array;
				goto IL_1577;
				IL_1577:
				object obj47 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v422 @ X8_v76+1B8] (should have been resolved before IL gen)");
				float num26 = (float)obj26 * num12;
				num9 = num26 + (float)obj28;
				bool flag8 = _003CLayHall_003Eg__Place_007C17_1(array3, (Vector2)(&obj3), (float)num10, ref obj19, ref reference2);
				_Canon2 = (System.__Canon)(_Canon2 - 1);
				bool flag9 = (nint)_Canon2 != 1;
				num2 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
				list5 = (List<System.__Canon>)obj19;
				num7 = num14;
				obj21 = (object)(&obj19);
				num12 = (float)num10;
				list6 = (List<System.__Canon>)(&obj3);
				reference = ref reference2;
				obj25 = obj26;
				obj27 = obj28;
				num13 = num14;
				num15 = num14;
				num16 = num9;
				num17 = num10;
				obj29 = (object)(&obj19);
				num18 = (float)num10;
				vector = (Vector2)(&obj3);
				obj30 = obj14;
				if (flag9)
				{
					continue;
				}
				goto IL_07e6;
			}
			goto IL_14fc;
			IL_1354:
			obj20++;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v16 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ stack_-178_v2 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
			object obj48 = num27 - 0;
			bool flag10 = (nint)obj48 < 0;
			bool flag11 = obj48 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v16 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ stack_-178_v2 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
			object obj49 = num28 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v16 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
			object obj50 = 0 ^ obj48;
			object obj51 = obj49 & obj50;
			bool flag12 = (nint)obj51 < 0;
			bool flag13 = flag10 == flag12;
			object obj52 = !flag11;
			object obj53 = flag13 & obj52;
			object obj54 = ~obj53;
			List<Spot> list8;
			List<Spot> list7 = ((obj54 != null) ? list2 : list8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79E8]");
			obj23 = 0;
			bool flag14 = (nint)obj20 != 30;
			num2 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			obj26 = obj25;
			obj28 = obj27;
			num14 = num13;
			list2 = list7;
			num7 = num15;
			num9 = num16;
			num10 = num17;
			num11 = num3;
			obj21 = obj29;
			num12 = num18;
			obj14 = obj30;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F58]");
				object format = 0;
				string message = string.Format((string)format, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj56 = 0;
				object obj57 = obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v27+E4]");
				bool flag15 = (nint)0 == 0;
				object obj58 = !flag15;
				if (obj58 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message);
				return list7;
			}
			continue;
			IL_07e6:
			object obj59 = 0;
			while (list3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7668]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v25 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
				bool flag16 = (nint)0 >= (nint)81;
				list8 = list3;
				if (flag16)
				{
					goto IL_1337;
				}
				if (obj19 == (_003C_003Ec__DisplayClass17_0)(object)0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
				object obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F50]");
				object obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F40]");
				object obj62 = 0;
				vector = (Vector2)obj62;
				queue._002Ector();
				if (obj19 == (_003C_003Ec__DisplayClass17_0)(object)0)
				{
					break;
				}
				object obj63 = obj64 + 32;
				int num29 = 0;
				List<System.__Canon> list9 = (List<System.__Canon>)obj19;
				while (num29 < list9._size)
				{
					obj29 = obj15;
					System.__Canon _Canon4 = list9.get_Item(num29);
					object obj65 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v67+E4]");
					bool flag17 = (nint)0 == 0;
					object obj66 = !flag17;
					if (obj66 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					num18 = Apart(array, (Vector2[])(object)_Canon4);
					float num30 = (float)obj67;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
					num15 = num30 + 0f;
					bool flag18 = num18 < num15;
					object obj68 = !flag18;
					float num31 = num18 - num15;
					bool flag19 = num31 == 0f;
					object obj69 = !flag19;
					object obj70 = obj68 & obj69;
					int num32 = (int)_Canon4;
					if (obj70 == null)
					{
						if (obj64 == null)
						{
							goto end_IL_17df;
						}
						int num33 = num29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v50+18]");
						bool flag20 = (nint)num33 < (nint)0;
						object obj71 = !flag20;
						if (obj71 != null)
						{
							goto end_IL_1891;
						}
						_ = 1;
						if (queue == null)
						{
							goto end_IL_17df;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F38]");
						object obj72 = 0;
						obj29 = obj72;
						queue.Enqueue(num29);
						num32 = num29;
					}
					num29++;
					bool flag21 = obj19 == (_003C_003Ec__DisplayClass17_0)(object)0;
					object obj73 = !flag21;
					vector = (Vector2)num32;
					list9 = (List<System.__Canon>)obj19;
					if (obj73 == null)
					{
						goto end_IL_17df;
					}
				}
				if (queue == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1114 @ X0_v52 (System.Collections.Generic.Queue`1<System.Int32>)+20]");
				int num34;
				double num41;
				if ((nint)0 >= (nint)1)
				{
					object obj74 = obj64 + 32;
					List<System.__Canon> list10 = (List<System.__Canon>)obj19;
					num34 = -1;
					while (true)
					{
						int num35 = queue.Dequeue();
						if (list10 == null)
						{
							break;
						}
						object obj75 = obj15;
						System.__Canon p = list10.get_Item(num35);
						object obj76 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X8_v54+E4]");
						bool flag22 = (nint)0 == 0;
						object obj77 = !flag22;
						if (obj77 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num36 = Apart((Vector2[])(object)p, array2);
						float num37 = (float)obj67;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
						num15 = num37 + 0f;
						bool flag23 = num36 < num15;
						object obj78 = !flag23;
						float num38 = num36 - num15;
						bool flag24 = num38 == 0f;
						object obj79 = ~obj78;
						object obj80 = obj79 | flag24;
						int num42;
						if (obj80 == null)
						{
							int num39 = (int)(num34 & 0x80000000L);
							bool flag25 = num39 == 0;
							object obj81 = !flag25;
							int num40 = (int)array2;
							if (obj81 == null)
							{
								if (list3 == null)
								{
									break;
								}
								Spot spot = list3.get_Item(num35);
								if (list3 == null)
								{
									break;
								}
								obj75 = obj16;
								Spot spot2 = list3.get_Item(num34);
								bool flag26 = num35 <= num34;
								num17 = num35;
								num36 = num34;
								num40 = num34;
								num41 = num35;
								obj29 = obj16;
								num18 = num34;
								num42 = num34;
								if (flag26)
								{
									goto IL_16bb;
								}
							}
							num41 = num17;
							num34 = num35;
							obj29 = obj75;
							num18 = num36;
							num42 = num40;
							goto IL_16bb;
						}
						return list3;
						IL_16bb:
						if (list10 == null)
						{
							break;
						}
						int num43 = 0;
						vector = (Vector2)num42;
						list9 = list10;
						while (num43 < list9._size)
						{
							if (obj64 == null)
							{
								goto end_IL_16fc;
							}
							int num44 = num43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v50+18]");
							bool flag27 = (nint)num44 < (nint)0;
							object obj82 = !flag27;
							if (obj82 != null)
							{
								goto end_IL_1891;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X23_v15+v711 @ X28_v13 (System.Int32)]");
							bool flag28 = (nint)0 == 0;
							object obj83 = !flag28;
							if (obj83 == null)
							{
								System.__Canon p2 = list9.get_Item(num35);
								if (list10 == null)
								{
									goto end_IL_16fc;
								}
								obj29 = obj15;
								System.__Canon _Canon5 = list10.get_Item(num43);
								object obj84 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1453 @ X8_v62+E4]");
								bool flag29 = (nint)0 == 0;
								object obj85 = !flag29;
								if (obj85 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								num18 = Apart((Vector2[])(object)p2, (Vector2[])(object)_Canon5);
								float num45 = (float)obj67;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
								num15 = num45 + 0f;
								bool flag30 = num18 < num15;
								object obj86 = !flag30;
								float num46 = num18 - num15;
								bool flag31 = num46 == 0f;
								object obj87 = !flag31;
								object obj88 = obj86 & obj87;
								vector = (Vector2)_Canon5;
								if (obj88 == null)
								{
									int num47 = num43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v50+18]");
									bool flag32 = (nint)num47 < (nint)0;
									object obj89 = !flag32;
									if (obj89 != null)
									{
										goto end_IL_1891;
									}
									_ = 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F38]");
									object obj90 = 0;
									obj29 = obj90;
									queue.Enqueue(num43);
									vector = (Vector2)num43;
								}
							}
							num43++;
							bool flag33 = list10 == null;
							object obj91 = !flag33;
							list9 = list10;
							if (obj91 == null)
							{
								goto end_IL_16fc;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1114 @ X0_v52 (System.Collections.Generic.Queue`1<System.Int32>)+20]");
						bool flag34 = (nint)0 > (nint)0;
						list10 = (List<System.__Canon>)obj19;
						num17 = num41;
						if (flag34)
						{
							continue;
						}
						goto IL_0fd1;
						continue;
						end_IL_16fc:
						break;
					}
					break;
				}
				num34 = -1;
				obj22 = (object)(&obj19);
				goto IL_1727;
				IL_0fd1:
				num17 = num41;
				obj22 = (object)(&obj19);
				goto IL_1727;
				IL_1727:
				if (list3 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7ED0]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7668]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7650]");
				obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v25 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
				bool flag35 = (nint)0 > (nint)79;
				list8 = list3;
				if (!flag35)
				{
					int num48 = (int)(num34 & 0x80000000L);
					bool flag36 = num48 == 0;
					object obj92 = !flag36;
					object obj96;
					System.__Canon _Canon7;
					if (obj92 == null)
					{
						obj29 = obj15;
						System.__Canon _Canon6 = list9.get_Item(num34);
						object obj93 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X8_v48+E4]");
						bool flag37 = (nint)0 == 0;
						object obj94 = !flag37;
						if (obj94 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Vector2 vector3 = _003CLayHall_003Eg__Middle_007C17_2(num34, ref obj95);
						if (obj3 == null)
						{
							break;
						}
						obj25 = 1120403456;
						obj27 = 3259498496L;
						num13 = num15;
						num17 = num18;
						obj96 = obj3;
						_Canon7 = _Canon6;
					}
					else
					{
						object obj97 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ X0_v60+E4]");
						bool flag38 = (nint)0 == 0;
						object obj98 = !flag38;
						if (obj98 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj99 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1332 @ X0_v62+E4]");
						bool flag39 = (nint)0 == 0;
						object obj100 = !flag39;
						if (obj100 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (obj3 == null)
						{
							break;
						}
						object obj101 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v901 @ X8_v46+1B8] (should have been resolved before IL gen)");
						if (obj3 == null)
						{
							break;
						}
						float num49 = (float)obj17 + num5;
						num16 = (float)obj17 + 3f;
						float num50 = num49 + -3f;
						num15 = num50 - num16;
						num18 = num15 * num18;
						num17 = (double)num16 + (double)num18;
						obj25 = 1117782016;
						obj27 = 3256877056L;
						num13 = 0f;
						obj96 = obj3;
						_Canon7 = (System.__Canon)(object)array;
					}
					object obj102 = obj96;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v917 @ X8_v42+1B8] (should have been resolved before IL gen)");
					float num51 = (float)obj25 * num18;
					num16 = num51 + (float)obj27;
					bool flag40 = _003CLayHall_003Eg__Place_007C17_1((Vector2[])(object)_Canon7, (Vector2)(&obj3), (float)num17, ref obj19, ref reference);
					obj59++;
					bool flag41 = (nint)obj59 != 60;
					num15 = num13;
					obj29 = (object)(&obj19);
					num18 = (float)num17;
					vector = (Vector2)(&obj3);
					if (flag41)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7668]");
					obj13 = 0;
					bool flag42 = list3 == null;
					num15 = num13;
					obj29 = (object)(&obj19);
					num18 = (float)num17;
					vector = (Vector2)(&obj3);
					list8 = list3;
					if (flag42)
					{
						break;
					}
				}
				goto IL_1337;
				IL_1337:
				if (list2 == null)
				{
					break;
				}
				goto IL_1354;
				continue;
				end_IL_17df:
				break;
			}
			goto IL_14fc;
			IL_14fc:
			NullReferenceException ex = new NullReferenceException();
			break;
			continue;
			end_IL_1891:
			break;
		}
		return (List<Spot>)(object)new IndexOutOfRangeException();
	}

	public static Vector2[] Corners(float x, float z, float across, float along, float yaw)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0094: Expected Obj, but got F4
		//IL_0140: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
		object obj = 0;
		float num = yaw;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		float num2 = num * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Vector2[] array = default;
		if (array != null)
		{
			if (array.Length != 0)
			{
				bool flag = array.Length == 1;
				float num3 = across * 0.5f;
				float num4 = along * 0.5f;
				object obj2 = default;
				float num5 = num3 * (float)obj2;
				object obj3 = default;
				float num6 = (float)obj3 * num3;
				object obj4 = 0f - num6;
				float num7 = num4 * (float)obj3;
				float num8 = num4 * (float)obj2;
				float num9 = x - num5;
				float num10 = z - (float)obj4;
				float num11 = num9 - num7;
				float num12 = num10 - num8;
				if (!flag)
				{
					float num13 = num5 + x;
					float num14 = (float)obj4 + z;
					bool flag2 = array.Length < 2;
					object obj5 = !flag2;
					object obj6 = array.Length - 2;
					bool flag3 = obj6 == null;
					float num15 = num13 - num7;
					float num16 = num14 - num8;
					object obj7 = ~obj5;
					object obj8 = obj7 | flag3;
					if (obj8 == null)
					{
						float num17 = num7 + num13;
						float num18 = num8 + num14;
						if (array.Length != 3)
						{
							float num19 = num7 + num9;
							float num20 = num8 + num10;
							return array;
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (Vector2[])(object)new NullReferenceException();
	}

	private static float PointApart(Vector2 point, Vector2 middle, float across, float along, float yaw)
	{
		//IL_00e8: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		object obj5 = default;
		object obj4 = obj5 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
		object obj6 = default;
		float num = along - (float)obj6;
		object obj7 = default;
		float num2 = num * (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		object obj8 = default;
		double num3 = (double)obj8 * 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		float num4 = num2 - (float)num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num5 = num4 * num4;
		double num6 = num3 * num3;
		float result = num5 + (float)num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		return result;
	}

	public static float Apart(Vector2[] p, Vector2[] q)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		//IL_00dd: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = Separated(p, q);
		bool flag3 = !flag2;
		object obj4 = !flag3;
		Vector2[] array = q;
		float num;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = Separated(q, p);
			bool flag6 = !flag5;
			array = p;
			num = 0f;
			if (flag6)
			{
				goto IL_01c2;
			}
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj8 = !flag7;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		num = Nearest(p, q);
		float num2 = Nearest(q, p);
		if (!(num < num2))
		{
			num = num2;
		}
		goto IL_01c2;
		IL_01c2:
		return num;
	}

	private static bool Separated(Vector2[] a, Vector2[] b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I4
		//IL_02e8: Expected I4, but got Obj
		//IL_0309: Expected I4, but got Obj
		//IL_0051: Expected Obj, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I8
		//IL_0174: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I8
		//IL_00e8: Expected Obj, but got I4
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I8
		//IL_04c2: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I8
		//IL_01c0: Expected Obj, but got I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I8
		//IL_0383: Expected Obj, but got I4
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		//IL_04e4: Expected Obj, but got I4
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_044f: Expected Obj, but got I4
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		object obj = a + 32;
		object obj2 = b + 32;
		object obj3 = 0;
		while (true)
		{
			object obj5;
			object obj9;
			object obj10;
			object obj22;
			object obj23;
			if ((nint)obj3 != 2)
			{
				if (a == null)
				{
					break;
				}
				object obj4 = a.Length;
				obj5 = obj3 + 1;
				bool flag = (nint)obj5 < a.Length;
				object obj6 = !flag;
				if (obj6 == null)
				{
					object obj7 = a + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X13_v5+v75 @ X11_v5*8]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X13_v5+v74 @ X11_v2*8]");
					object obj8 = num - 0;
					object obj21;
					if (a.Length >= 1)
					{
						obj9 = 4286578687L;
						obj10 = 2139095039;
						object obj11 = obj;
						do
						{
							obj11 += 8;
							object obj12 = obj8 * obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
							{
								obj10 = obj12;
							}
							object obj13 = obj9 - obj12;
							bool flag2 = (nint)obj13 < 0;
							bool flag3 = obj13 == null;
							object obj14 = obj9 ^ obj12;
							object obj15 = obj9 ^ obj13;
							object obj16 = obj14 & obj15;
							bool flag4 = (nint)obj16 < 0;
							bool flag5 = flag2 == flag4;
							object obj17 = !flag3;
							object obj18 = flag5 & obj17;
							object obj19 = ~obj18;
							if (obj19 != null)
							{
								obj9 = obj12;
							}
							obj4--;
						}
						while ((nint)obj4 != 1);
						bool flag6 = b == null;
						object obj20 = !flag6;
						obj21 = 2139095039;
						if (obj20 == null)
						{
							break;
						}
					}
					else
					{
						bool flag7 = b == null;
						obj9 = 4286578687L;
						obj10 = 2139095039;
						if (flag7)
						{
							break;
						}
					}
					if (b.Length < 1)
					{
						obj22 = 2139095039;
						obj23 = 4286578687L;
						goto IL_049b;
					}
					object obj24 = b.Length & 0xFFFFFFFFL;
					object obj25 = ~b.Length;
					object obj26 = b.Length & obj25;
					obj22 = 2139095039;
					obj23 = 4286578687L;
					obj21 = obj2;
					while (obj24 != null)
					{
						obj21 += 8;
						object obj27 = obj26 - 1;
						obj24--;
						object obj28 = obj8 * obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28))
						{
							obj22 = obj28;
						}
						object obj29 = obj23 - obj28;
						bool flag8 = (nint)obj29 < 0;
						bool flag9 = obj29 == null;
						object obj30 = obj23 ^ obj28;
						object obj31 = obj23 ^ obj29;
						object obj32 = obj30 & obj31;
						bool flag10 = (nint)obj32 < 0;
						bool flag11 = flag8 == flag10;
						object obj17 = !flag9;
						object obj33 = flag11 & obj17;
						object obj34 = ~obj33;
						if (obj34 != null)
						{
							obj23 = obj28;
						}
						bool flag12 = (nint)obj26 != 1;
						obj26 = obj27;
						if (flag12)
						{
							continue;
						}
						goto IL_049b;
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				break;
			}
			goto IL_02c5;
			IL_02c5:
			bool flag13 = (nint)obj3 < 2;
			object obj35 = !flag13;
			return (byte)(int)(~obj35) != 0;
			IL_049b:
			object obj36 = obj9 - obj22;
			bool flag14 = (nint)obj36 < 0;
			object obj37 = !flag14;
			object obj38 = ~obj37;
			bool flag15;
			if (obj38 == null)
			{
				object obj39 = obj23 - obj10;
				flag15 = (nint)obj39 < 0;
			}
			else
			{
				flag15 = true;
			}
			object obj40 = !flag15;
			obj3 = obj5;
			if (obj40 != null)
			{
				continue;
			}
			goto IL_02c5;
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	private static float Nearest(Vector2[] points, Vector2[] edges)
	{
		//IL_0278: Expected F4, but got I4
		//IL_004c: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I8
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I4
		//IL_0080: Expected F4, but got I4
		//IL_0355: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_03bb: Expected Obj, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I
		//IL_01b8: Invalid comparison between F8 and I4
		//IL_01c7: Expected F8, but got I4
		//IL_0392: Expected Obj, but got I4
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_023e: Expected Obj, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		float num;
		if (points != null)
		{
			if (points.Length < 1)
			{
				num = 2.139095E+09f;
				goto IL_0363;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = points.Length & 0xFFFFFFFFL;
			object obj3 = edges + 32;
			object obj4 = 0;
			num = 2.139095E+09f;
			double num5 = default;
			object obj16 = default;
			object obj21 = default;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
				object obj5 = !flag;
				if (obj5 == null)
				{
					if (edges == null)
					{
						break;
					}
					object obj6 = (object)points + obj4;
					object obj7 = 0;
					while (true)
					{
						bool flag2 = (nint)obj7 < edges.Length;
						object obj8 = !flag2;
						if (obj8 != null)
						{
							break;
						}
						object obj9 = obj7 + 1;
						object obj10 = obj9 & 3;
						bool flag3 = (nint)obj10 < edges.Length;
						object obj11 = !flag3;
						if (obj11 != null)
						{
							break;
						}
						object obj12 = obj9 & 3;
						object obj13 = (object)edges + obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X9_v9+20]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X23_v4+v317 @ X8_v10*8]");
						object obj14 = num2 - 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v8+20]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X23_v4+v317 @ X8_v10*8]");
						object obj15 = num3 - 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						double num4 = num5 * (double)obj16;
						object obj17 = obj15 * obj14;
						double num6 = num4 + (double)obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						double num7 = num6 / num4;
						bool flag4 = num7 < 0.0;
						num5 = 0.0;
						if (!flag4)
						{
							bool flag5 = !(num7 > 1.0);
							num5 = num7;
							if (!flag5)
							{
								num5 = 1.0;
							}
						}
						object obj18 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v9+E4]");
						bool flag6 = (nint)0 == 0;
						object obj19 = !flag6;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj20 = obj14 * obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X23_v4+v317 @ X8_v10*8]");
						object obj22 = 0 + obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v8+20]");
						object obj23 = obj22 - 0;
						float num8 = (float)obj23 * (float)obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						if (!(num < num8))
						{
							num = num8;
						}
						bool flag7 = (nint)obj9 != 4;
						obj7 = obj9;
						if (flag7)
						{
							continue;
						}
						goto IL_0234;
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				break;
				IL_0234:
				obj2 = points.Length;
				obj4++;
				if ((nint)obj4 < points.Length)
				{
					continue;
				}
				goto IL_0363;
			}
		}
		throw new NullReferenceException();
		IL_0363:
		return num;
	}

	public static int Pack([In] ref Spot s)
	{
		//IL_0016: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_0051: Invalid comparison between F8 and I4
		//IL_0437: Expected Obj, but got I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_0317: Expected Obj, but got I4
		//IL_013e: Invalid comparison between F8 and I4
		//IL_039c: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got F8
		//IL_046f: Expected Obj, but got I4
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_0373: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got F8
		//IL_0251: Invalid comparison between Obj and F8
		//IL_0220: Invalid comparison between Obj and F8
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected I4, but got Unknown
		//IL_0270: Expected Obj, but got F8
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03c9: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X0 (Spot&)+4]");
		object obj = (nint)0 + (nint)1115684864;
		double num = (double)obj * 4.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num2;
		double num3;
		double num4 = default;
		if (num < 0.0)
		{
			if (num == -0.5)
			{
				num2 = -1.0;
				num3 = num4;
				goto IL_02e0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num == 0.5)
			{
				num2 = 1.0;
				num3 = num4;
				goto IL_02e0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_032a;
		IL_034b:
		object obj6;
		object obj5 = obj6 & 1;
		bool flag2 = obj5 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
		}
		goto IL_0386;
		IL_032a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X0 (Spot&)+8]");
		double num5 = 0.0 * 4.0;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		if (num5 < 0.0)
		{
			if (num5 == -0.5)
			{
				obj6 = num4;
				goto IL_034b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num5 == 0.5)
			{
				obj6 = num4;
				goto IL_034b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_0386;
		IL_03a1:
		object obj11;
		object obj10 = obj11 & 1;
		bool flag4 = obj10 == null;
		object obj12 = !flag4;
		if (obj12 != null)
		{
		}
		goto IL_03dc;
		IL_03dc:
		int result = num & 0x1FF;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		return result;
		IL_0386:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ X0 (Spot&)+C]");
		object obj13 = (nint)0 / (nint)1085538304;
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		if ((nint)obj13 < 0)
		{
			if (obj13 == (object)(-0.5))
			{
				obj11 = num4;
				goto IL_03a1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (obj13 == (object)0.5)
			{
				obj11 = num4;
				goto IL_03a1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_03dc;
		IL_02e0:
		double num6 = num3 + num2;
		object obj16 = num3 & 1;
		bool flag6 = obj16 == null;
		object obj17 = !flag6;
		num = ((obj17 != null) ? num6 : num3);
		goto IL_032a;
	}

	public static Spot Unpack(int v)
	{
		//IL_003c: Expected Obj, but got I8
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected VT, but got Unknown
		int num = v & 0x1FF;
		int num2 = v >> 20;
		int num3 = num2 & 0x1F;
		object obj = num + 3263168512L;
		return (Spot)(num3 | obj);
	}

	unsafe static GillaSplashLayout()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_05a8: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I8
		//IL_010b: Expected Obj, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01e0: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I8
		//IL_0281: Expected Obj, but got I
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I
		//IL_02fd: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0356: Expected Obj, but got I
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0374: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I4
		//IL_03e8: Expected Obj, but got I
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_042b: Expected Obj, but got I
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_0449: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I
		//IL_04a7: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_0500: Expected Obj, but got I
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_051e: Expected Obj, but got I
		//IL_0557: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F88]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = default;
		object obj4 = (nint)(&obj5) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C80E0]");
			object obj6 = 0;
			object obj8 = default;
			object obj7 = obj8 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8070]");
			object obj9 = 0;
			_ = 64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj11 = default;
			object obj10 = (nint)(&obj11) | (nint)8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+18]");
			object obj12 = 0 & 0xFFFFFFFEL;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8028]");
				object obj13 = 0;
				object obj14 = obj8 + 64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8098]");
				object obj15 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj17 = default;
				object obj16 = (nint)(&obj17) | (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+18]");
				bool flag = (nint)0 < (nint)2;
				object obj18 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+18]");
				object obj19 = -2;
				bool flag2 = obj19 == null;
				object obj20 = ~obj18;
				object obj21 = obj20 | flag2;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8138]");
					object obj22 = 0;
					object obj23 = obj8 + 96;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7FC0]");
					object obj24 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj26 = default;
					object obj25 = (nint)(&obj26) | (nint)8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+18]");
					object obj27 = 0 & 0xFFFFFFFCL;
					if (obj27 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C80D0]");
						object obj28 = 0;
						object obj29 = obj8 + 128;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8030]");
						object obj30 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj32 = default;
						object obj31 = (nint)(&obj32) | (nint)8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+18]");
						bool flag3 = (nint)0 < (nint)4;
						object obj33 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+18]");
						object obj34 = -4;
						bool flag4 = obj34 == null;
						object obj35 = ~obj33;
						object obj36 = obj35 | flag4;
						if (obj36 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C80C0]");
							object obj37 = 0;
							object obj38 = obj8 + 160;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8088]");
							object obj39 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj41 = default;
							object obj40 = (nint)(&obj41) | (nint)8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+18]");
							bool flag5 = (nint)0 < (nint)5;
							object obj42 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+18]");
							object obj43 = -5;
							bool flag6 = obj43 == null;
							object obj44 = ~obj42;
							object obj45 = obj44 | flag6;
							if (obj45 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8008]");
								object obj46 = 0;
								object obj47 = obj8 + 192;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8108]");
								object obj48 = 0;
								_ = 65;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj50 = default;
								object obj49 = (nint)(&obj50) | (nint)8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+18]");
								bool flag7 = (nint)0 < (nint)6;
								object obj51 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+18]");
								object obj52 = -6;
								bool flag8 = obj52 == null;
								object obj53 = ~obj51;
								object obj54 = obj53 | flag8;
								if (obj54 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8000]");
									object obj55 = 0;
									object obj56 = obj8 + 224;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C80E8]");
									object obj57 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B0F0]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj59 = default;
									object obj58 = (nint)(&obj59) | (nint)8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CCB4");
									return;
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

	internal static float _003CLayHall_003Eg__R_007C17_0(float a, float b, ref _003C_003Ec__DisplayClass17_0 P_2)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = P_2;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ X8_v1+1B8] (should have been resolved before IL gen)");
		float num = b - a;
		float num2 = num * a;
		return num2 + a;
	}

	internal unsafe static bool _003CLayHall_003Eg__Place_007C17_1(Vector2[] from, Vector2 at, float heading, ref _003C_003Ec__DisplayClass17_0 P_3, ref GillaSplashLobby._003C_003Ec__DisplayClass17_1 P_4)
	{
		//IL_1807: Expected Obj, but got I
		//IL_1824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between F4 and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected native int or pointer, but got F4
		//IL_0093: Expected VT, but got I
		//IL_00a3: Expected F4, but got I
		//IL_00de: Expected Obj, but got I4
		//IL_16eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I4
		//IL_01ba: Invalid comparison between F4 and I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected native int or pointer, but got F4
		//IL_022d: Expected VT, but got I
		//IL_0247: Expected F4, but got I
		//IL_0257: Invalid comparison between F4 and I
		//IL_1898: Expected Obj, but got I4
		//IL_1def: Expected Obj, but got I
		//IL_1e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e28: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I4
		//IL_02fe: Expected F4, but got I
		//IL_031f: Expected Obj, but got I4
		//IL_0327: Expected Obj, but got I4
		//IL_0360: Invalid comparison between F4 and I4
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got I4
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_03b7: Expected native int or pointer, but got F4
		//IL_03d0: Expected VT, but got I
		//IL_0415: Invalid comparison between F4 and I4
		//IL_191b: Invalid comparison between F4 and I4
		//IL_1927: Unknown result type (might be due to invalid IL or missing references)
		//IL_1933: Expected Obj, but got I4
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18be: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c3: Expected Obj, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected native int or pointer, but got F4
		//IL_056f: Expected Obj, but got I
		//IL_057f: Expected F4, but got I
		//IL_05a6: Expected Obj, but got I
		//IL_05c5: Expected F4, but got I
		//IL_0606: Expected Obj, but got I4
		//IL_060f: Expected F8, but got I4
		//IL_0617: Expected Obj, but got Ref
		//IL_0620: Expected F8, but got I4
		//IL_1e70: Expected Obj, but got I4
		//IL_18f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fb: Expected F4, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected F4, but got Unknown
		//IL_06bc: Expected F4, but got I
		//IL_06bc: Expected F4, but got I
		//IL_1979: Unknown result type (might be due to invalid IL or missing references)
		//IL_197e: Expected Obj, but got Unknown
		//IL_19a8: Expected F4, but got I
		//IL_19b8: Expected F4, but got I
		//IL_0777: Invalid comparison between F4 and I4
		//IL_1a4f: Invalid comparison between F4 and I4
		//IL_19ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f3: Expected Obj, but got Unknown
		//IL_1b02: Expected Obj, but got I4
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected F4, but got I
		//IL_0970: Expected F4, but got I
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected F4, but got I
		//IL_09c5: Expected F4, but got I
		//IL_09dd: Expected VT, but got Obj
		//IL_09e5: Expected Obj, but got I4
		//IL_1a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a83: Expected Obj, but got Unknown
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Expected F4, but got Unknown
		//IL_0d22: Expected Obj, but got I
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected F4, but got I
		//IL_0d7b: Expected F4, but got I
		//IL_0d83: Expected VT, but got Obj
		//IL_0d8b: Expected Obj, but got I4
		//IL_0a3e: Expected Obj, but got I8
		//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4c: Expected Obj, but got Unknown
		//IL_0a5d: Expected Obj, but got I4
		//IL_0dc8: Expected F4, but got I
		//IL_0dd8: Expected F4, but got I
		//IL_1bee: Expected Obj, but got I4
		//IL_1c2b: Expected F4, but got I
		//IL_1c59: Expected F4, but got I
		//IL_1c71: Expected VT, but got Obj
		//IL_1c79: Expected Obj, but got I4
		//IL_1054: Expected F4, but got I
		//IL_1076: Expected Obj, but got I4
		//IL_10b4: Expected F4, but got I
		//IL_10d4: Invalid comparison between F4 and I4
		//IL_10e5: Expected Obj, but got I4
		//IL_10f5: Invalid comparison between F4 and I
		//IL_0e00: Expected Obj, but got I8
		//IL_0e10: Expected F8, but got I
		//IL_0e26: Expected Obj, but got I
		//IL_0e3f: Expected Obj, but got I4
		//IL_0e57: Expected F4, but got I
		//IL_0e6f: Expected F4, but got I
		//IL_0a9a: Expected F4, but got I
		//IL_0aa2: Expected F4, but got Obj
		//IL_0ac4: Expected Obj, but got I4
		//IL_1cb5: Expected Obj, but got I4
		//IL_1cfe: Expected F4, but got I4
		//IL_1d06: Expected VT, but got Obj
		//IL_1d0e: Expected Obj, but got I4
		//IL_0af1: Expected Obj, but got I
		//IL_1117: Invalid comparison between VT and I4
		//IL_1123: Unknown result type (might be due to invalid IL or missing references)
		//IL_114f: Expected VT, but got Obj
		//IL_1157: Expected Obj, but got I4
		//IL_0e94: Expected VT, but got Obj
		//IL_0ea4: Expected F8, but got I
		//IL_0eb4: Expected F8, but got I
		//IL_0ebc: Expected F4, but got Obj
		//IL_0ede: Expected Obj, but got I4
		//IL_0b53: Expected Obj, but got I4
		//IL_118b: Expected Obj, but got VT
		//IL_1186: Unknown result type (might be due to invalid IL or missing references)
		//IL_118b: Unknown result type (might be due to invalid IL or missing references)
		//IL_119f: Expected Obj, but got I
		//IL_119f: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a7: Expected F4, but got Unknown
		//IL_0f14: Expected VT, but got Obj
		//IL_1b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b25: Expected Obj, but got Unknown
		//IL_0b7b: Expected Obj, but got I
		//IL_12a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ba: Expected Obj, but got I4
		//IL_12e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fb: Expected Obj, but got I4
		//IL_1304: Expected Obj, but got I4
		//IL_0f53: Expected Obj, but got I
		//IL_0f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f61: Expected Obj, but got Unknown
		//IL_0f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6f: Expected Obj, but got Unknown
		//IL_0f95: Expected F4, but got I
		//IL_0fad: Expected F4, but got I
		//IL_0fc6: Expected F4, but got I4
		//IL_0fd6: Expected F4, but got I
		//IL_0ffe: Expected F4, but got I
		//IL_0baa: Expected Obj, but got I4
		//IL_1d5e: Expected Obj, but got I
		//IL_1d66: Expected VT, but got Obj
		//IL_1d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6f: Expected Ref, but got Unknown
		//IL_1d89: Expected Obj, but got I4
		//IL_1d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da1: Expected F4, but got Unknown
		//IL_1da9: Expected Obj, but got I4
		//IL_0bd7: Expected Obj, but got I
		//IL_171c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1728: Expected I4, but got Obj
		//IL_1323: Expected Obj, but got I4
		//IL_1333: Unknown result type (might be due to invalid IL or missing references)
		//IL_133b: Expected Obj, but got Unknown
		//IL_11f2: Expected Obj, but got I4
		//IL_0c39: Expected Obj, but got I4
		//IL_1745: Invalid comparison between VT and I4
		//IL_1b65: Expected F4, but got I
		//IL_1ba8: Invalid comparison between F4 and I4
		//IL_1bb9: Expected Obj, but got I4
		//IL_1794: Invalid comparison between VT and I4
		//IL_0c61: Expected Obj, but got I
		//IL_139e: Expected Obj, but got I
		//IL_13c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cd: Expected F4, but got Unknown
		//IL_13d5: Expected Obj, but got I4
		//IL_1244: Unknown result type (might be due to invalid IL or missing references)
		//IL_1248: Unknown result type (might be due to invalid IL or missing references)
		//IL_1255: Expected Obj, but got I4
		//IL_1281: Unknown result type (might be due to invalid IL or missing references)
		//IL_1289: Unknown result type (might be due to invalid IL or missing references)
		//IL_1296: Expected Obj, but got I4
		//IL_129f: Expected Obj, but got I4
		//IL_0c70: Expected Obj, but got I4
		//IL_0c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected Obj, but got Unknown
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8c: Expected Obj, but got Unknown
		//IL_0cfc: Expected F4, but got I
		//IL_177e: Expected Obj, but got I4
		//IL_1380: Expected Obj, but got I4
		//IL_17ed: Expected Obj, but got I4
		//IL_13f3: Expected Obj, but got I
		//IL_1403: Expected Obj, but got I
		//IL_140b: Expected F4, but got Obj
		//IL_1455: Expected Obj, but got I4
		//IL_147b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1480: Expected VT, but got Unknown
		//IL_148d: Expected Ref, but got F8
		//IL_14b6: Expected Obj, but got I4
		//IL_152b: Expected Obj, but got I
		//IL_153b: Expected Obj, but got I
		//IL_1550: Expected Obj, but got I
		//IL_1562: Expected Obj, but got VT
		//IL_1570: Invalid comparison between VT and I4
		//IL_1596: Expected Obj, but got I4
		//IL_14e1: Expected Obj, but got I
		//IL_15b4: Expected Obj, but got I
		//IL_15c9: Expected F4, but got Obj
		//IL_161d: Expected Obj, but got I4
		//IL_164b: Expected Obj, but got I4
		//IL_16c9: Expected Obj, but got VT
		//IL_166b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1670: Expected Obj, but got Unknown
		//IL_1699: Unknown result type (might be due to invalid IL or missing references)
		//IL_169e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+8]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+8]");
		bool flag = (nint)0 == 0;
		Enumerator<, > val = (Enumerator<, >)0;
		float num2 = default;
		float num = num2;
		float num4 = default;
		float num3 = num4;
		float num6 = default;
		float num5 = num6;
		ref _003C_003Ec__DisplayClass17_0 reference = ref P_3;
		Vector2 vector = at;
		float num7 = num4;
		double num8 = num2;
		object obj3;
		int num13;
		double num18;
		Enumerator<, > val2;
		Enumerator<, > val3 = default;
		float num17;
		float num9;
		if (!flag)
		{
			float x = at.x;
			bool flag2 = at.x == 0f;
			val = (Enumerator<, >)0;
			num = num2;
			num3 = num4;
			num5 = num6;
			reference = ref P_3;
			vector = at;
			num7 = num4;
			num8 = num2;
			if (!flag2)
			{
				float value = ((float*)(nint)x)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X20_v10 (System.String)+18]");
				vector = (Vector2)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v25 (System.Single)+1A8]");
				num9 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v25 (System.Single)+1B0]");
				reference = ref *(_003C_003Ec__DisplayClass17_0*)null;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v451 @ X8_v25 (System.Single)+1A8] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X20_v10 (System.String)+18]");
				object obj = default;
				bool flag3 = (nint)obj < 0;
				object obj2 = !flag3;
				num5 = num6;
				num7 = num4;
				num8 = num2;
				if (obj2 != null)
				{
					goto IL_16dc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+8]");
				num9 = 0f + (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X9_v25 (System.Single)+20]");
				text = (string)0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v28+E4]");
				int num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v28+E4]");
				bool flag4 = (nint)0 == 0;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num11 = KindOf(text);
				float x2 = at.x;
				bool flag5 = at.x == 0f;
				val = (Enumerator<, >)0;
				num = num2;
				num3 = num4;
				num5 = num6;
				num7 = num4;
				num8 = num2;
				if (!flag5)
				{
					num9 = ((float*)(nint)x2)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X9_v25 (System.Single)+1B8]");
					num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X9_v25 (System.Single)+1C0]");
					vector = (Vector2)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v376 @ X9_v25 (System.Single)+1B8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+10]");
					num5 = 0f;
					float num12 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+10]");
					bool flag6 = !(num12 < 0f);
					num13 = num11;
					if (!flag6)
					{
						object obj6 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X0_v100+E4]");
						bool flag7 = (nint)0 == 0;
						object obj7 = !flag7;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int num14 = SafeLike(num11);
						num13 = num14;
					}
					object obj8 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v43+E4]");
					bool flag8 = (nint)0 == 0;
					object obj9 = !flag8;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj8 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v43+A0]");
					object obj10 = 0;
					object obj11 = obj10;
					bool flag9 = obj10 == null;
					val = (Enumerator<, >)0;
					num = num2;
					num3 = num4;
					text = (string)num13;
					num7 = num4;
					num8 = num2;
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v33+18]");
						num9 = 0f;
						int num15 = num13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v33+18]");
						bool flag10 = (nint)num15 < (nint)0;
						object obj12 = !flag10;
						text = (string)num13;
						num7 = num4;
						num8 = num2;
						if (obj12 != null)
						{
							goto IL_16dc;
						}
						float x3 = at.x;
						bool flag11 = at.x == 0f;
						val = (Enumerator<, >)0;
						num = num2;
						num3 = num4;
						text = (string)num13;
						num7 = num4;
						num8 = num2;
						if (!flag11)
						{
							object obj13 = obj10 + num13;
							num9 = ((float*)(nint)x3)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X9_v25 (System.Single)+1C0]");
							vector = (Vector2)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v376 @ X9_v25 (System.Single)+1B8] (should have been resolved before IL gen)");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+34]");
							float num16 = 0f * 1.13587E+09f;
							num17 = num16 / 1.0855383E+09f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
							if (num17 < 0f)
							{
								if ((double)num17 == -0.5)
								{
									num18 = -1.0;
									val2 = val3;
									goto IL_18a6;
								}
								double num19 = (double)num17 + -0.5;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
								num = num2;
								num3 = (float)num19;
								num5 = -0.5f;
							}
							else
							{
								if ((double)num17 == 0.5)
								{
									num18 = 1.0;
									val2 = val3;
									goto IL_18a6;
								}
								double num20 = (double)num17 + 0.5;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
								num = num2;
								num3 = (float)num20;
								num5 = 0.5f;
							}
							goto IL_1900;
						}
					}
				}
			}
		}
		goto IL_1704;
		IL_18a6:
		double num21 = (double)val2 + num18;
		object obj14 = val2 & 1;
		num3 = ((obj14 != null) ? ((float)num21) : ((float)val2));
		num = (float)num18;
		num5 = (float)val2;
		goto IL_1900;
		IL_1704:
		throw new NullReferenceException();
		IL_103c:
		object obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+14]");
		num17 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X0_v66+E4]");
		bool flag12 = (nint)0 == 0;
		object obj16 = !flag12;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector2[] array;
		num3 = Apart(from, array);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+18]");
		num5 = 0f;
		float num22 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+18]");
		float num23 = num22 - 0f;
		bool flag13 = num23 == 0f;
		object obj17 = !flag13;
		float num24 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+18]");
		if (num24 > 0f)
		{
			goto IL_150d;
		}
		bool flag14 = P_3 == (_003C_003Ec__DisplayClass17_0)(object)0;
		val = (Enumerator<, >)0;
		float num26;
		float num25 = num26;
		float num28;
		float num27 = num28;
		Vector2[] array2 = array;
		float num30;
		float num29 = num30;
		vector = (Vector2)array;
		text = (string)num13;
		float num34;
		double num35;
		object obj18;
		double num33;
		if (!flag14)
		{
			float num31 = num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			float num32 = num31 * 0f;
			Enumerator<, > enumerator = ((List<System.__Canon>)P_3).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F68]");
			obj18 = 0;
			Enumerator<, > val4 = default;
			num3 = (float)val4;
			Vector2[] array4;
			object obj21;
			System.__Canon _Canon;
			Enumerator<, > val5;
			object obj22;
			object obj23;
			Vector2[] array3 = default;
			while (true)
			{
				if (val.MoveNext())
				{
					if (array3 != from)
					{
						object obj19 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1595 @ X0_v74+E4]");
						bool flag15 = (nint)0 == 0;
						object obj20 = !flag15;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						num3 = Apart(array, array3);
						if (num3 < num32)
						{
							array4 = null;
							val = val4;
							obj21 = 0;
							num25 = num26;
							num33 = num34;
							num27 = num28;
							_Canon = (System.__Canon)(object)array;
							num29 = num30;
							val3 = (Enumerator<, >)(ref val);
							val5 = (Enumerator<, >)(ref val);
							obj22 = 0;
							obj23 = 17;
							break;
						}
					}
					continue;
				}
				array4 = null;
				val = val4;
				obj21 = 0;
				num25 = num26;
				num33 = num34;
				num27 = num28;
				_Canon = (System.__Canon)(object)array;
				num29 = num30;
				val3 = (Enumerator<, >)(ref val);
				val5 = (Enumerator<, >)(ref val);
				obj22 = 0;
				obj23 = 18;
				break;
			}
			bool result = default;
			object obj27 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F60]");
				object obj24 = 0;
				vector = (Vector2)obj24;
				((Enumerator<, >*)val3)->Dispose();
				bool flag16 = obj22 == null;
				object obj25 = !flag16;
				array3 = array4;
				array2 = (Vector2[])(object)_Canon;
				num9 = (float)val5;
				text = (string)num13;
				if (obj25 == null)
				{
					bool flag17 = array4 == null;
					object obj26 = !flag17;
					array3 = array4;
					array2 = (Vector2[])(object)_Canon;
					OutOfMemoryException ex = (OutOfMemoryException)val3;
					if (obj26 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
					val5 = (Enumerator<, >)num9;
					num13 = (int)text;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if (vector == (Vector2)(object)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					array3 = (Vector2[])1;
					obj22 = obj21;
				}
				else
				{
					if (vector != (Vector2)(object)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E4A4");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj22 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj21 = obj27;
				}
				array4 = array3;
				_Canon = (System.__Canon)(object)array2;
				obj23 = 0;
			}
			if ((nint)obj23 != 18)
			{
				bool flag18 = obj23 == null;
				object obj28 = !flag18;
				if (obj28 != null)
				{
					goto IL_150d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass17_0&)+8]");
			List<Spot> list = (List<Spot>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass17_0&)+8]");
			bool flag19 = (nint)0 == 0;
			array3 = array4;
			array2 = (Vector2[])(object)_Canon;
			num9 = (float)val5;
			text = (string)num13;
			if (!flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79D8]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+10]");
				object obj30 = 0;
				num9 = (float)obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+1C]");
				int num10 = (int)((nint)0 + (nint)1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+10]");
				bool flag20 = (nint)0 == 0;
				array3 = array4;
				array2 = (Vector2[])(object)_Canon;
				text = (string)num13;
				if (!flag20)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
					num10 = 0;
					Spot spot = (Spot)(num13 | num35);
					reference = ref *(_003C_003Ec__DisplayClass17_0*)(num33 | (double)num29);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
					nint num36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v8+18]");
					bool flag21 = num36 < 0;
					object obj31 = !flag21;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+10]");
						nint num37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
						object obj32 = num37 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
						num9 = 0f + 1f;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X9_v25 (System.Single)+20]");
						object obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X8_v16+A8]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass17_0&)+8]");
						((List<Spot>)0).AddWithResize(spot);
					}
					List<System.__Canon> list2 = (List<System.__Canon>)P_3;
					bool flag22 = P_3 == (_003C_003Ec__DisplayClass17_0)(object)0;
					array3 = array4;
					array2 = (Vector2[])(object)_Canon;
					vector = (Vector2)spot;
					text = (string)num13;
					if (!flag22)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7640]");
						object obj35 = 0;
						System.__Canon[] items = list2._items;
						num9 = (float)obj35;
						num10 = list2._version + 1;
						list2._version = num10;
						bool flag23 = list2._items == null;
						array3 = array4;
						array2 = (Vector2[])(object)_Canon;
						vector = (Vector2)spot;
						text = (string)num13;
						if (!flag23)
						{
							bool flag24 = list2._size < items.Length;
							object obj36 = !flag24;
							if (obj36 == null)
							{
								object obj37 = list2._items + list2._size;
								int size = list2._size + 1;
								list2._size = size;
								object obj38 = obj37 + 32;
								obj38 = _Canon;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							}
							else
							{
								((List<System.__Canon>)P_3).AddWithResize(_Canon);
							}
							return true;
						}
					}
				}
			}
		}
		goto IL_1704;
		IL_1a28:
		num17 = num7 * 4f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		Enumerator<, > val6;
		float num39;
		double num38;
		if (num17 < 0f)
		{
			if ((double)num17 == -0.5)
			{
				num38 = -1.0;
				val6 = val3;
				goto IL_1a66;
			}
			num39 = num17 + -0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if ((double)num17 == 0.5)
			{
				num38 = 1.0;
				val6 = val3;
				goto IL_1a66;
			}
			num39 = num17 + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_1ab0;
		IL_1900:
		float x4 = at.x;
		bool flag25 = at.x == 0f;
		val = (Enumerator<, >)0;
		text = (string)num13;
		num7 = num4;
		num8 = num2;
		if (flag25)
		{
			goto IL_1704;
		}
		float value2 = ((float*)(nint)x4)->m_value;
		num30 = num3 * 1.0855383E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X8_v40 (System.Single)+1B8]");
		num9 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1131 @ X8_v40 (System.Single)+1B8] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+18]");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+14]");
		object obj39 = num40 - 0;
		float num41 = (float)obj39 * num30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		float num42 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+14]");
		float num43 = 0f + num41;
		double num44 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		double num45 = num44 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
		array2 = (Vector2[])14;
		double num46 = 1107820544.0;
		double num47 = default;
		Vector2[] array5 = (Vector2[])(&num47);
		num8 = 0.0;
		object obj42 = default;
		Vector2[] array6;
		bool flag27;
		do
		{
			object obj40 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ X0_v54+E4]");
			bool flag26 = (nint)0 == 0;
			object obj41 = !flag26;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num48 = num46 + num8;
			num33 = num48 * 0.5;
			double num49 = (double)obj42 * num33;
			double num50 = num47 * num33;
			float x5 = num4 + (float)num49;
			num42 = num6 + (float)num50;
			float z = num42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+30]");
			nint num51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+34]");
			array6 = Corners(x5, z, num51, 0f, num30);
			float num52 = Apart(from, array6);
			if (!(num52 < num43))
			{
				num46 = num33;
			}
			if (num52 < num43)
			{
				num8 = num33;
			}
			array2 = (Vector2[])(array2 - 1);
			flag27 = (nint)array2 != 1;
			num25 = num30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+34]");
			num27 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+30]");
			num = 0f;
			num45 = num52;
			array5 = array6;
		}
		while (flag27);
		double num53 = (double)obj42 * num46;
		num38 = num47 * num46;
		float num54 = num4 + (float)num53;
		float num55 = num54 * 4f;
		num7 = num6 + (float)num38;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num56;
		double num57 = default;
		double num58;
		if (num55 < 0f)
		{
			if ((double)num55 == -0.5)
			{
				num38 = -1.0;
				num56 = num57;
				goto IL_19d6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num58 = -0.5;
		}
		else
		{
			if ((double)num55 == 0.5)
			{
				num38 = 1.0;
				num56 = num57;
				goto IL_19d6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num58 = 0.5;
		}
		goto IL_1a28;
		IL_1ab0:
		object obj43 = obj3;
		num35 = num33 * 0.25;
		num34 = num39 * 0.25f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ X0_v62+E4]");
		bool flag28 = (nint)0 == 0;
		object obj44 = !flag28;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+30]");
		nint num59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+34]");
		array = Corners((float)num35, num34, num59, 0f, num30);
		bool flag29 = array == null;
		val = (Enumerator<, >)0;
		num25 = num30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+34]");
		num27 = 0f;
		double num60 = num43;
		num29 = num30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+30]");
		num = 0f;
		num3 = (float)num35;
		num5 = num34;
		vector = (Vector2)array6;
		text = (string)num13;
		if (!flag29)
		{
			bool flag30 = array.Length < 1;
			num60 = num43;
			num3 = (float)num35;
			num5 = num34;
			if (flag30)
			{
				goto IL_0d12;
			}
			object obj45 = array.Length & 0xFFFFFFFFL;
			object obj46 = array + 36;
			object obj47 = obj17;
			object obj48 = 0;
			float num61 = num17;
			num4 = (float)num35;
			float num62 = num34;
			float num63 = num7;
			while (true)
			{
				bool flag31 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45);
				object obj49 = !flag31;
				obj17 = obj47;
				object obj50 = obj46;
				object obj51 = obj48;
				num25 = num30;
				num33 = -1.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+34]");
				num27 = 0f;
				array2 = array;
				num60 = -1.0;
				num29 = num30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+30]");
				num2 = 0f;
				num17 = num61;
				num5 = num62;
				vector = (Vector2)array6;
				text = (string)num13;
				num7 = num63;
				num8 = 1.0;
				if (obj49 != null)
				{
					break;
				}
				object obj52 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X27_v15-4]");
				num17 = 0f;
				num7 = (float)obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1489 @ X0_v84+E4]");
				bool flag32 = (nint)0 == 0;
				object obj53 = !flag32;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+1C]");
				object obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+1C]");
				double num64 = 0.0 + 1.0;
				if (!((double)num17 < num64))
				{
					object obj55 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1536 @ X0_v86+E4]");
					bool flag33 = (nint)0 == 0;
					object obj56 = !flag33;
					if (obj56 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+1C]");
						obj54 = 0;
					}
					object obj57 = obj54;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+24]");
					object obj58 = obj57 + 0;
					double num65 = (double)obj58 + -1.0;
					if (!((double)num17 > num65))
					{
						object obj59 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1551 @ X0_v88+E4]");
						bool flag34 = (nint)0 == 0;
						object obj60 = !flag34;
						if (obj60 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+20]");
						object obj61 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+20]");
						double num66 = 0.0 + 1.5;
						if (!((double)num7 < num66))
						{
							object obj62 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1569 @ X0_v90+E4]");
							bool flag35 = (nint)0 == 0;
							object obj63 = !flag35;
							if (obj63 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+20]");
								obj61 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+28]");
							num5 = 0f;
							float num67 = (float)obj61;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+28]");
							float num68 = num67 + 0f;
							num3 = num68 + -1.5f;
							float num69 = num7 - num3;
							bool flag36 = num69 == 0f;
							obj17 = !flag36;
							if (!(num7 > num3))
							{
								obj45 = array.Length;
								obj51 = obj48 + 1;
								obj50 = obj46 + 8;
								bool flag37 = (nint)obj51 < array.Length;
								num33 = -1.5;
								num60 = -1.0;
								num8 = 1.0;
								obj47 = obj17;
								obj46 = obj50;
								obj48 = obj51;
								num61 = num17;
								num4 = num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+28]");
								num62 = 0f;
								num63 = num7;
								if (flag37)
								{
									continue;
								}
								goto IL_0d12;
							}
						}
					}
				}
				goto IL_150d;
			}
			goto IL_16dc;
		}
		goto IL_1704;
		IL_19d6:
		double num70 = num56 + num38;
		object obj64 = num56 & 1;
		num33 = ((obj64 != null) ? num70 : num56);
		num58 = num56;
		goto IL_1a28;
		IL_150d:
		return false;
		IL_0d12:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+40]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+40]");
		bool flag38 = (nint)0 == 0;
		val = (Enumerator<, >)0;
		num25 = num30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+34]");
		num27 = 0f;
		array2 = array;
		num29 = num30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+30]");
		num = 0f;
		vector = (Vector2)array6;
		text = (string)num13;
		if (!flag38)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X25_v3+18]");
			bool flag39 = (nint)0 < (nint)1;
			num26 = num30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+34]");
			num28 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+30]");
			num = 0f;
			if (flag39)
			{
				goto IL_103c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X25_v3+18]");
			object obj65 = 0 & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
			num33 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector2)+40]");
			object obj66 = (nint)0 + (nint)40;
			float num72 = default;
			float num71 = num72;
			float num74 = default;
			float num73 = num74;
			object obj67 = 0;
			num25 = num30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+34]");
			num27 = 0f;
			double num75 = num60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+30]");
			num2 = 0f;
			num4 = num3;
			float num76 = num5;
			double num77 = num8;
			while (true)
			{
				bool flag40 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj67) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj65);
				object obj68 = !flag40;
				num72 = num71;
				num74 = num73;
				object obj50 = obj66;
				object obj51 = obj67;
				array2 = array;
				num60 = num75;
				num29 = num30;
				num5 = num76;
				num9 = 17276928f;
				vector = (Vector2)array6;
				text = (string)num13;
				num8 = num77;
				if (obj68 != null)
				{
					break;
				}
				Vector2 point = (Vector2)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X27_v12-8]");
				num8 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X27_v12-4]");
				num60 = 0.0;
				num17 = (float)obj66;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1098 @ X0_v81 (UnityEngine.Vector2)+E4]");
				bool flag41 = (nint)0 == 0;
				object obj69 = !flag41;
				if (obj69 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				num3 = PointApart(point, (Vector2)array6, (float)num8, (float)num60, (float)num35);
				num5 = num17 + (float)num33;
				if (!(num3 < num5))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X25_v3+18]");
					obj65 = 0;
					obj51 = obj67 + 1;
					obj50 = obj66 + 12;
					object obj70 = obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X25_v3+18]");
					bool flag42 = (nint)obj70 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+34]");
					num72 = 0f;
					num74 = num30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+30]");
					num26 = 0f;
					num28 = num34;
					num = (float)num35;
					num9 = 17276928f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+34]");
					num71 = 0f;
					num73 = num30;
					obj66 = obj50;
					obj67 = obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v34+30]");
					num25 = 0f;
					num27 = num34;
					num75 = num60;
					num2 = (float)num35;
					num4 = num3;
					num76 = num5;
					num77 = num8;
					if (flag42)
					{
						continue;
					}
					goto IL_103c;
				}
				goto IL_150d;
			}
			goto IL_16dc;
		}
		goto IL_1704;
		IL_16dc:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		val = (Enumerator<, >)0;
		num = num2;
		num3 = num4;
		goto IL_1704;
		IL_1a66:
		double num78 = (double)val6 + num38;
		object obj71 = val6 & 1;
		num39 = ((obj71 != null) ? ((float)num78) : ((float)val6));
		goto IL_1ab0;
	}

	internal static Vector2 _003CLayHall_003Eg__Middle_007C17_2(int i, ref GillaSplashLobby._003C_003Ec__DisplayClass17_1 P_1)
	{
		//IL_0070: Expected VT, but got Obj
		//IL_001b: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass17_1&)+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass17_1&)+8]");
			Spot spot = ((List<Spot>)0).get_Item(i);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass17_1&)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass17_1&)+8]");
				return (Vector2)((List<Spot>)0).get_Item(i);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector2)ex;
	}
}
