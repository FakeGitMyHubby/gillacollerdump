using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine.InputSystem.LowLevel;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Size = 8)]
public struct NetworkBehaviourId : Action<InputEventPtr>, _0021_00210
{
	[FieldOffset(0)]
	public NetworkId Object;

	[FieldOffset(4)]
	public int Behaviour;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_OBJECT = default(int);

	internal const int BYTE_COUNT_OF_OBJECT = default(int);

	internal const int BYTE_OF_BEHAVIOUR = default(int);

	internal const int BYTE_COUNT_OF_BEHAVIOUR = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public bool IsValid
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0099: Expected Obj, but got I4
			//IL_002f: Invalid comparison between VT and I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Object != (NetworkId)(object)0)
			{
				int num = ~Behaviour;
				return (byte)(num >> 31) != 0;
			}
			return false;
		}
	}

	public static NetworkBehaviourId None
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (NetworkBehaviourId)0;
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool Equals(NetworkBehaviourId other)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got VT
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Object == (NetworkId)other)
		{
			object obj4 = other >> 32;
			object obj5 = Behaviour - obj4;
			return obj5 == null;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_005a: Invalid comparison between VT and I
		//IL_0087: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C30]");
			object obj2 = 0;
			if (obj == obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				NetworkId networkId = Object;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				if (networkId == (NetworkId)(object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
					object obj6 = (nint)0 >> 32;
					object obj7 = Behaviour - obj6;
					return obj7 == null;
				}
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0010: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int hashCode = ((NetworkId)this).GetHashCode();
		object obj4 = hashCode * 397;
		return obj4 ^ Behaviour;
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C38]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		return string.Format((string)format, arg, arg2);
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(NetworkBehaviourId a, NetworkBehaviourId b)
	{
		//IL_0045: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = a - b;
		return obj4 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(NetworkBehaviourId a, NetworkBehaviourId b)
	{
		//IL_0050: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = a - b;
		bool flag2 = obj4 == null;
		return !flag2;
	}
}
