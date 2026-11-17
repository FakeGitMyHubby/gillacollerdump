using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Size = 4)]
public struct NetworkBool(bool value) : _0021_00210, Action<PlayFabError>
{
	[FieldOffset(0)]
	public int RawValue = (value ? 1 : 0);

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_RAW_VALUE = default(int);

	internal const int BYTE_COUNT_OF_RAW_VALUE = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public bool Equals(NetworkBool other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = RawValue - other;
		return obj == null;
	}

	public override string ToString()
	{
		//IL_002a: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		if (RawValue == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D90]");
			return (string)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6D98]");
		return (string)0;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_00f8: Expected I4, but got Obj
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6DA0]");
			object obj2 = 0;
			if (obj == obj2)
			{
				int rawValue = RawValue;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				if ((nint)rawValue == 0)
				{
					return true;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X9_v6+30]");
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				bool flag2 = RawValue == 0;
				object obj5 = !flag2;
				return (byte)(obj4 ^ obj5) != 0;
			}
		}
		return false;
	}

	public bool Equals(bool b)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I4, but got Unknown
		bool flag = RawValue == 0;
		object obj = !flag;
		object obj2 = obj ^ b;
		return (byte)(obj2 & 1) != 0;
	}

	public override int GetHashCode()
	{
		return RawValue;
	}

	public static implicit operator bool(NetworkBool val)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = val - 1;
		return obj == null;
	}

	public static implicit operator NetworkBool(bool val)
	{
		//IL_0005: Expected VT, but got I4
		return (NetworkBool)val;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(bool a, NetworkBool b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		object obj = b - 1;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = obj2 ^ a;
		return (byte)(obj3 & 1) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(bool a, NetworkBool b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected I4, but got Unknown
		object obj = b - 1;
		bool flag = obj == null;
		object obj2 = flag ^ a;
		return (byte)(obj2 & 1) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(NetworkBool a, bool b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		object obj = a - 1;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = obj2 ^ b;
		return (byte)(obj3 & 1) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(NetworkBool a, bool b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected I4, but got Unknown
		object obj = a - 1;
		bool flag = obj == null;
		object obj2 = flag ^ b;
		return (byte)(obj2 & 1) != 0;
	}
}
