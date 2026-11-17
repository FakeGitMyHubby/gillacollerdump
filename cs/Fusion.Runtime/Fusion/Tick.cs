using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.ClientModels;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 4)]
public struct Tick : Action<RemoveFriendResult>, _0021_00210, Action<RemoveGenericIDResult>
{
	[Serializable]
	private struct Entry<TKey, TValue>
	{
		public TKey Key;

		public TValue Value;
	}

	public sealed class RelationalComparer : Action<PurchaseItemResult>
	{
		public int Compare(Tick x, Tick y)
		{
			//IL_000d: Expected I4, but got VT
			int num = default;
			return num.CompareTo((int)y);
		}
	}

	public const int ALIGNMENT = default(int);

	[FieldOffset(0)]
	public int Raw;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_RAW = default(int);

	internal const int BYTE_COUNT_OF_RAW = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public Tick Next(int increment)
	{
		//IL_000f: Expected VT, but got I4
		return (Tick)(Raw + increment);
	}

	public bool Equals(Tick other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = Raw - other;
		return obj == null;
	}

	public int CompareTo(Tick other)
	{
		//IL_000a: Expected I4, but got VT
		return ((int)this).CompareTo((int)other);
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6430]");
			object obj2 = 0;
			if (obj == obj2)
			{
				int raw = Raw;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				object obj3 = (nint)raw - (nint)0;
				return obj3 == null;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Raw;
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6F10]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		return string.Format((string)format, arg);
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator >(Tick a, Tick b)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0038: Expected Obj, but got VT
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected I4, but got Unknown
		object obj = a - b;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		object obj2 = a ^ b;
		object obj3 = a ^ obj;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		return (byte)((flag4 & obj5) ? 1 : 0) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator >=(Tick a, Tick b)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0029: Expected Obj, but got VT
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		object obj = a - b;
		bool flag = (nint)obj < 0;
		object obj2 = a ^ b;
		object obj3 = a ^ obj;
		object obj4 = obj2 & obj3;
		bool flag2 = (nint)obj4 < 0;
		return flag == flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator <(Tick a, Tick b)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0029: Expected Obj, but got VT
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		object obj = a - b;
		bool flag = (nint)obj < 0;
		object obj2 = a ^ b;
		object obj3 = a ^ obj;
		object obj4 = obj2 & obj3;
		bool flag2 = (nint)obj4 < 0;
		bool flag3 = flag == flag2;
		return !flag3;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator <=(Tick a, Tick b)
	{
		//IL_000d: Expected Obj, but got VT
		//IL_0038: Expected Obj, but got VT
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected I4, but got Unknown
		object obj = a - b;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		object obj2 = a ^ b;
		object obj3 = a ^ obj;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag4;
		return (byte)((obj5 | flag2) ? 1 : 0) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(Tick a, Tick b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(Tick a, Tick b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		bool flag = obj == null;
		return !flag;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static implicit operator Tick(int value)
	{
		//IL_0016: Expected VT, but got I4
		int num = ~value;
		return (Tick)(value & num);
	}

	[MethodImpl((MethodImplOptions)256)]
	public static implicit operator int(Tick value)
	{
		//IL_0005: Expected I4, but got VT
		return (int)value;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static explicit operator uint(Tick value)
	{
		//IL_0005: Expected I4, but got VT
		return (uint)(int)value;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static implicit operator bool(Tick value)
	{
		//IL_0009: Invalid comparison between VT and I4
		//IL_0018: Invalid comparison between VT and I4
		//IL_002b: Expected Obj, but got VT
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected I4, but got Unknown
		bool flag = value < (object)0;
		bool flag2 = value == (Tick)(object)0;
		object obj = value ^ value;
		object obj2 = value & obj;
		bool flag3 = (nint)obj2 < 0;
		bool flag4 = flag == flag3;
		object obj3 = !flag2;
		return (byte)((flag4 & obj3) ? 1 : 0) != 0;
	}
}
