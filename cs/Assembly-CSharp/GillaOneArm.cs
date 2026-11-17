using System;
using Cpp2ILInjected;
using UnityEngine;

public static class GillaOneArm
{
	private static readonly int[] restFrame;

	public static bool Resting(int hand)
	{
		//IL_01ba: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I
		//IL_01a0: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		bool flag = hand < 1;
		object obj = !flag;
		object obj2 = hand - 1;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v4+A0]");
		object obj8 = 0;
		object obj9 = obj8;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+18]");
			bool flag4 = (nint)0 < (nint)hand;
			object obj10 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+18]");
			object obj11 = -hand;
			bool flag5 = obj11 == null;
			object obj12 = ~obj10;
			object obj13 = obj12 | flag5;
			if (obj13 == null)
			{
				object obj14 = obj8 + hand;
				int frameCount = Time.frameCount;
				object obj15 = frameCount - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+20]");
				object obj16 = 0 - obj15;
				bool flag6 = (nint)obj16 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+20]");
				object obj17 = 0 ^ obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+20]");
				object obj18 = 0 ^ obj16;
				object obj19 = obj17 & obj18;
				bool flag7 = (nint)obj19 < 0;
				return flag6 == flag7;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public static void Rest(int hand)
	{
		//IL_0113: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		bool flag = hand < 1;
		object obj = !flag;
		object obj2 = hand - 1;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+A0]");
		object obj8 = 0;
		object obj9 = obj8;
		int frameCount = Time.frameCount;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X20_v6+18]");
			bool flag4 = (nint)0 < (nint)hand;
			object obj10 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X20_v6+18]");
			object obj11 = -hand;
			bool flag5 = obj11 == null;
			object obj12 = ~obj10;
			object obj13 = obj12 | flag5;
			if (obj13 == null)
			{
				object obj14 = obj8 + hand;
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
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
		if (obj4 != null)
		{
			_ = -10;
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	static GillaOneArm()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v3+18]");
			bool flag = (nint)0 == 1;
			_ = 4294967286L;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
				object obj2 = 0;
				_ = 4294967286L;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v1+A0]");
				object obj4 = 0;
				object obj5 = default;
				obj4 = obj5;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
