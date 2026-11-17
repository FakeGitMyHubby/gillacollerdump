using Cpp2ILInjected;
using UnityEngine;

public static class GillaVoiceVolume
{
	private const string Key = null;

	public const int Most = default(int);

	public const int Step = default(int);

	private static bool loaded;

	private static int percent;

	private static float factor;

	public static int Percent
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Ready();
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5+4]");
			return 0;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e9: Expected Obj, but got I
			//IL_010b: Expected Obj, but got I4
			//IL_0037: Expected Obj, but got I4
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected I4, but got Unknown
			//IL_009e: Expected Obj, but got I4
			//IL_013f: Expected Obj, but got I
			//IL_0166: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA300]");
			object key = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Ready();
			object obj4 = value - 200;
			bool flag2 = (nint)obj4 < 0;
			int num = value ^ 0xC8;
			int num2 = value ^ obj4;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			object obj5 = obj;
			bool flag4 = flag2 == flag3;
			object obj6 = !flag4;
			object obj7 = ~obj6;
			int num4 = ((obj7 != null) ? 200 : value);
			int num5 = ~num4;
			int num6 = num4 & num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v1+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v8+A0]");
			object obj10 = 0;
			int num7 = num6 / 1120403456;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v9+4]");
			PlayerPrefs.SetInt((string)key, 0);
			PlayerPrefs.Save();
		}
	}

	public static float Factor
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_008b: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+8]");
			return 0f;
		}
	}

	public static void Ready()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I
		//IL_021d: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected I4, but got Unknown
		//IL_0177: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
		object obj4 = 0;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v15+A0]");
				obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA300]");
			object key = 0;
			obj4 = 1;
			int num = PlayerPrefs.GetInt((string)key, 100);
			object obj8 = num - 200;
			bool flag4 = (nint)obj8 < 0;
			int num2 = num ^ 0xC8;
			int num3 = num ^ obj8;
			int num4 = num2 & num3;
			bool flag5 = num4 < 0;
			object obj9 = obj;
			bool flag6 = flag4 == flag5;
			object obj10 = !flag6;
			object obj11 = ~obj10;
			int num5 = ((obj11 != null) ? 200 : num);
			int num6 = ~num5;
			int num7 = num5 & num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X9_v6+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v11+A0]");
			object obj14 = 0;
			int num8 = num7 / 1120403456;
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5+A0]");
		object obj6 = 0;
		_ = 1065353216;
	}

	static GillaVoiceVolume()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		_ = 100;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v5+A0]");
		object obj5 = 0;
		_ = 1065353216;
	}
}
