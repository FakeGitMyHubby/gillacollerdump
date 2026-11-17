using System;
using Cpp2ILInjected;

namespace Fusion;

public struct NetworkRunnerUpdaterDefaultInvokeSettings : _0021_00210
{
	public Type ReferencePlayerLoopSystem;

	public FusionPlayerLoopSystemAddMode AddMode;

	public bool Equals(NetworkRunnerUpdaterDefaultInvokeSettings other)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got VT
		//IL_009e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X0_v1+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (ReferencePlayerLoopSystem == (Type)other)
		{
			nint num = default;
			object obj4 = (nint)AddMode - num;
			return obj4 == null;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0049: Expected VT, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BC0]");
			object obj2 = 0;
			if (obj == obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				return Equals((NetworkRunnerUpdaterDefaultInvokeSettings)0);
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected I4, but got Unknown
		//IL_00e9: Expected I4, but got Obj
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X8_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X0_v1+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4;
		if (ReferencePlayerLoopSystem != null)
		{
			if ((object)ReferencePlayerLoopSystem == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			string fullName = ((System.RuntimeType)ReferencePlayerLoopSystem).FullName;
			obj4 = fullName * 397;
		}
		else
		{
			obj4 = 0;
		}
		return AddMode ^ obj4;
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9CD8]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3F18]");
		object obj = 0;
		object arg;
		if ((object)ReferencePlayerLoopSystem != null)
		{
			Type[] genericArguments = ((System.RuntimeType)ReferencePlayerLoopSystem).GetGenericArguments();
			arg = genericArguments;
		}
		else
		{
			arg = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg2 = default;
		return string.Format((string)format, arg, arg2);
	}

	public static bool operator ==(NetworkRunnerUpdaterDefaultInvokeSettings left, NetworkRunnerUpdaterDefaultInvokeSettings right)
	{
		//IL_000d: Expected VT, but got I
		NetworkRunnerUpdaterDefaultInvokeSettings networkRunnerUpdaterDefaultInvokeSettings = default;
		IntPtr intPtr = default;
		return networkRunnerUpdaterDefaultInvokeSettings.Equals((NetworkRunnerUpdaterDefaultInvokeSettings)(nint)intPtr);
	}

	public static bool operator !=(NetworkRunnerUpdaterDefaultInvokeSettings left, NetworkRunnerUpdaterDefaultInvokeSettings right)
	{
		//IL_000d: Expected VT, but got I
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
		NetworkRunnerUpdaterDefaultInvokeSettings networkRunnerUpdaterDefaultInvokeSettings = default;
		IntPtr intPtr = default;
		bool flag = networkRunnerUpdaterDefaultInvokeSettings.Equals((NetworkRunnerUpdaterDefaultInvokeSettings)(nint)intPtr);
		object obj = !flag;
		return (byte)(1 & obj) != 0;
	}
}
