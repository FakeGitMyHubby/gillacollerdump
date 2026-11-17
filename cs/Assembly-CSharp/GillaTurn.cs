using Cpp2ILInjected;
using UnityEngine;

public static class GillaTurn
{
	public const int Snap = default(int);

	public const int Smooth = default(int);

	public const int Off = default(int);

	private const string ModeKey = null;

	private const string AngleKey = null;

	private const string SpeedKey = null;

	private static bool loaded;

	private static int mode;

	private static int snapAngle;

	private static int smoothSpeed;

	public static int Mode
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Load();
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5+4]");
			return 0;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			//IL_00fa: Expected Obj, but got I4
			//IL_0037: Expected Obj, but got I4
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected I4, but got Unknown
			//IL_009e: Expected Obj, but got I4
			//IL_012e: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Load();
			object obj4 = value - 2;
			bool flag2 = (nint)obj4 < 0;
			int num = value ^ 2;
			int num2 = value ^ obj4;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			object obj5 = obj;
			bool flag4 = flag2 == flag3;
			object obj6 = !flag4;
			object obj7 = ~obj6;
			int num4 = ((obj7 != null) ? 2 : value);
			int num5 = ~num4;
			int num6 = num4 & num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v1+A0]");
			object obj8 = 0;
			Save();
		}
	}

	public static int SnapAngle
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Load();
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5+8]");
			return 0;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			//IL_00be: Expected Obj, but got I4
			//IL_0053: Expected Obj, but got I4
			//IL_00da: Expected Obj, but got I4
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected I4, but got Unknown
			//IL_0130: Expected Obj, but got I
			//IL_0149: Expected Obj, but got I4
			//IL_008f: Expected Obj, but got I4
			//IL_0081: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Load();
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			object obj6 = value - 90;
			bool flag3 = (nint)obj6 < 0;
			int num = value ^ 0x5A;
			int num2 = value ^ obj6;
			int num3 = num & num2;
			bool flag4 = num3 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+A0]");
			object obj7 = 0;
			bool flag5 = flag3 == flag4;
			object obj8 = !flag5;
			object obj9 = ~obj8;
			if (obj9 == null)
			{
				object obj10 = 45;
			}
			else
			{
				object obj10 = 90;
			}
			Save();
		}
	}

	public static int SmoothSpeed
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Load();
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5+C]");
			return 0;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			//IL_00fa: Expected Obj, but got I4
			//IL_0037: Expected Obj, but got I4
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected I4, but got Unknown
			//IL_009e: Expected Obj, but got I4
			//IL_012e: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Load();
			object obj4 = value - 9;
			bool flag2 = (nint)obj4 < 0;
			int num = value ^ 9;
			int num2 = value ^ obj4;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			object obj5 = obj;
			bool flag4 = flag2 == flag3;
			object obj6 = !flag4;
			object obj7 = ~obj6;
			int num4 = ((obj7 != null) ? 9 : value);
			int num5 = ~num4;
			int num6 = num4 & num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v1+A0]");
			object obj8 = 0;
			Save();
		}
	}

	public static float DegreesPerSecond
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_003b: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = SmoothSpeed;
			object obj4 = num * 1114636288;
			return (float)obj4 + 30f;
		}
	}

	public static string Describe()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = Mode;
		object obj4 = obj;
		string text;
		int num4 = default;
		object obj8;
		if (num != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num2 = Mode;
			if (num2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA190]");
				return (string)0;
			}
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num3 = SmoothSpeed;
			text = num4.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA188]");
			obj8 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num5 = SnapAngle;
			text = num4.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA180]");
			obj8 = 0;
		}
		return (string)obj8 + text;
	}

	private static void Load()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected I4, but got Unknown
		//IL_01bc: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected I4, but got Unknown
		//IL_029e: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_02d7: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_035d: Expected Obj, but got I
		//IL_036d: Expected Obj, but got I
		//IL_0392: Expected Obj, but got I4
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected I4, but got Unknown
		//IL_03f9: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+A0]");
		object obj4 = 0;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v21+A0]");
				obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA178]");
			object key = 0;
			obj4 = 1;
			int num = PlayerPrefs.GetInt((string)key, 0);
			object obj8 = num - 2;
			bool flag4 = (nint)obj8 < 0;
			int num2 = num ^ 2;
			int num3 = num ^ obj8;
			int num4 = num2 & num3;
			bool flag5 = num4 < 0;
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA170]");
			object key2 = 0;
			bool flag6 = flag4 == flag5;
			object obj10 = !flag6;
			object obj11 = ~obj10;
			int num5 = ((obj11 != null) ? 2 : num);
			int num6 = ~num5;
			int num7 = num5 & num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X9_v6+A0]");
			object obj12 = 0;
			int num8 = PlayerPrefs.GetInt((string)key2, 45);
			object obj13 = obj;
			object obj14 = num8 - 90;
			bool flag7 = (nint)obj14 < 0;
			int num9 = num8 ^ 0x5A;
			int num10 = num8 ^ obj14;
			int num11 = num9 & num10;
			bool flag8 = num11 < 0;
			bool flag9 = flag7 == flag8;
			object obj15 = !flag9;
			object obj16 = ~obj15;
			if (obj16 == null)
			{
				object obj17 = 45;
			}
			else
			{
				object obj17 = 90;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v11+E4]");
			bool flag10 = (nint)0 == 0;
			object obj18 = !flag10;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA168]");
			object key3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v11+A0]");
			object obj19 = 0;
			int num12 = PlayerPrefs.GetInt((string)key3, 5);
			object obj20 = num12 - 9;
			bool flag11 = (nint)obj20 < 0;
			int num13 = num12 ^ 9;
			int num14 = num12 ^ obj20;
			int num15 = num13 & num14;
			bool flag12 = num15 < 0;
			object obj21 = obj;
			bool flag13 = flag11 == flag12;
			object obj22 = !flag13;
			object obj23 = ~obj22;
			int num16 = ((obj23 != null) ? 9 : num12);
			int num17 = ~num16;
			int num18 = num16 & num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X9_v10+A0]");
			object obj24 = 0;
		}
	}

	private static void Save()
	{
		//IL_0010: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA178]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA170]");
		object key2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA168]");
		object key3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+4]");
		PlayerPrefs.SetInt((string)key, 0);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+8]");
		PlayerPrefs.SetInt((string)key2, 0);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+C]");
		PlayerPrefs.SetInt((string)key3, 0);
		PlayerPrefs.Save();
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
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
		obj4 = 0;
	}

	static GillaTurn()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C348]");
		_ = 0;
		_ = 5;
	}
}
