using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.MultiplayerModels;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 4)]
internal struct ChangeTick : _0021_00210, Action<ListBuildAliasesResponse>, _0021_00210
{
	public const int ALIGNMENT = default(int);

	[FieldOffset(0)]
	public uint Raw;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_RAW = default(int);

	internal const int BYTE_COUNT_OF_RAW = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public static ChangeTick MaxValue
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_000a: Expected VT, but got I8
			return (ChangeTick)4294967295L;
		}
	}

	public Tick AsPrevSimulationTick
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0083: Expected Obj, but got I4
			//IL_0054: Expected VT, but got I4
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
			int num = (int)Raw >> 1;
			int val = num - 1;
			return (Tick)Math.Max(0, val);
		}
	}

	public bool IsSimulationTick
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			int num = (int)(Raw & 1);
			return num == 0;
		}
	}

	public static ChangeTick FromSimulationTick(Tick tick)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Expected Obj, but got VT
		//IL_002c: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C10]");
		object error = 0;
		object obj = ~tick;
		bool condition = (byte)(obj >> 31) != 0;
		Assert.Check(condition, (string)error);
		return (ChangeTick)(tick << 1);
	}

	public static ChangeTick FromRaw(uint tick)
	{
		//IL_0005: Expected VT, but got I4
		return (ChangeTick)tick;
	}

	public static ChangeTick FromRecvTick(Tick tick)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Expected Obj, but got VT
		//IL_002c: Expected I4, but got Obj
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C10]");
		object error = 0;
		object obj = ~tick;
		bool condition = (byte)(obj >> 31) != 0;
		Assert.Check(condition, (string)error);
		return (ChangeTick)(1 | tick);
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool Equals(ChangeTick other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = Raw - other;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int CompareTo(ChangeTick other)
	{
		//IL_000a: Expected I4, but got VT
		return ((uint)this).CompareTo((uint)(int)other);
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6430]");
			object obj2 = 0;
			if (obj == obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj3 = default;
				bool flag = Equals(obj3);
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((uint)this).GetHashCode();
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C18]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		int num = (int)(Raw & 1);
		bool flag = num == 0;
		object obj2 = !flag;
		object arg;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			arg = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
			arg = 0;
		}
		object arg2 = default;
		return string.Format((string)format, arg2, arg);
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(ChangeTick a, ChangeTick b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(ChangeTick a, ChangeTick b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		bool flag = obj == null;
		return !flag;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator >(ChangeTick a, ChangeTick b)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got VT
		//IL_0040: Expected Obj, but got I4
		//IL_004d: Expected I4, but got Obj
		bool flag = a < b;
		object obj = !flag;
		object obj2 = a - b;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		return (byte)(obj & obj3) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator <(ChangeTick a, ChangeTick b)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_0022: Expected I4, but got Obj
		bool flag = a < b;
		object obj = !flag;
		return (byte)(int)(~obj) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator >=(ChangeTick a, ChangeTick b)
	{
		bool flag = a < b;
		return !flag;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator <=(ChangeTick a, ChangeTick b)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got VT
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected I4, but got Unknown
		bool flag = a < b;
		object obj = !flag;
		object obj2 = a - b;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		return (byte)((obj3 | flag2) ? 1 : 0) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static ChangeTick operator +(ChangeTick a, ChangeTick b)
	{
		return b + a;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static ChangeTick operator -(ChangeTick a, ChangeTick b)
	{
		return a - b;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static ChangeTick Max(ChangeTick a, ChangeTick b)
	{
		//IL_0019: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got VT
		//IL_0040: Expected Obj, but got I4
		ChangeTick changeTick = default;
		bool flag = changeTick < b;
		object obj = !flag;
		object obj2 = changeTick - b;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
		}
		return b;
	}
}
