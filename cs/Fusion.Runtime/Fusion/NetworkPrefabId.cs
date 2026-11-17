using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using PlayFab.EconomyModels;
using PlayFab.EventsModels;
using PlayFab.MultiplayerModels;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Size = 4)]
public struct NetworkPrefabId : _0021_00210, Action<SetItemModerationStateResponse>, _0021_00210, Action<SetMatchmakingQueueResult>
{
	public sealed class EqualityComparer : Action<SetDataConnectionResponse>
	{
		public bool Equals(NetworkObjectTypeId x, NetworkObjectTypeId y)
		{
			//IL_0010: Expected Obj, but got I
			//IL_006f: Expected Obj, but got I4
			//IL_0031: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = x - y;
			return obj4 == null;
		}

		public int GetHashCode(NetworkObjectTypeId obj)
		{
			//IL_0010: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I4
			//IL_0032: Expected Obj, but got VT
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected Obj, but got Unknown
			//IL_004d: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = obj >> 32;
			object obj6 = obj * 397;
			return obj6 ^ obj5;
		}
	}

	public const int ALIGNMENT = default(int);

	public const int MAX_INDEX = default(int);

	[FieldOffset(0)]
	public uint RawValue;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_RAW_VALUE = default(int);

	internal const int BYTE_COUNT_OF_RAW_VALUE = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public bool IsNone => RawValue == 0;

	public bool IsValid
	{
		get
		{
			bool flag = RawValue == 0;
			return !flag;
		}
	}

	public int AsIndex => (int)(RawValue - 1);

	public static NetworkPrefabId FromIndex(int index)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0036: Expected VT, but got I4
		//IL_008d: Expected VT, but got Obj
		bool flag = index < 2147483647;
		object obj = !flag;
		if (obj == null)
		{
			return (NetworkPrefabId)(index + 1);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentOutOfRangeException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkPrefabId)ex2;
	}

	public static NetworkPrefabId FromRaw(uint value)
	{
		//IL_0005: Expected VT, but got I4
		return (NetworkPrefabId)value;
	}

	public bool Equals(NetworkPrefabId other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = RawValue - other;
		return obj == null;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8858]");
			object obj2 = 0;
			if (obj == obj2)
			{
				uint rawValue = RawValue;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				object obj3 = (nint)(int)rawValue - (nint)0;
				return obj3 == null;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (int)RawValue;
	}

	public override string ToString()
	{
		return ToString(brackets: true, prefix: true);
	}

	private int System_002EIComparable_002ECompareTo(object obj)
	{
		//IL_003b: Expected I4, but got I8
		//IL_0015: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8858]");
			object obj2 = 0;
			if (obj == obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				return ((uint)this).CompareTo(0u);
			}
		}
		return -1;
	}

	public string ToString(bool brackets, bool prefix)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_01bf: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		if (brackets)
		{
			if (stringBuilder == null)
			{
				goto IL_01e9;
			}
			StringBuilder stringBuilder2 = stringBuilder.Append('[');
		}
		uint rawValue = RawValue;
		if (RawValue != 0)
		{
			if (prefix)
			{
				if (stringBuilder != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8868]");
					object value = 0;
					StringBuilder stringBuilder3 = stringBuilder.Append((string)value);
					rawValue = RawValue;
					goto IL_0164;
				}
			}
			else if (stringBuilder != null)
			{
				goto IL_0164;
			}
		}
		else if (stringBuilder != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8860]");
			object value2 = 0;
			StringBuilder stringBuilder4 = stringBuilder.Append((string)value2);
			bool flag = !brackets;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_01a0;
			}
			goto IL_01b7;
		}
		goto IL_01e9;
		IL_0164:
		int value3 = (int)(rawValue - 1);
		StringBuilder stringBuilder5 = stringBuilder.Append(value3);
		if (brackets)
		{
			goto IL_01a0;
		}
		goto IL_01b7;
		IL_01a0:
		StringBuilder stringBuilder6 = stringBuilder.Append(']');
		goto IL_01b7;
		IL_01e9:
		return (string)(object)new NullReferenceException();
		IL_01b7:
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+168]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+170]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v87 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_01e9;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(NetworkPrefabId a, NetworkPrefabId b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(NetworkPrefabId a, NetworkPrefabId b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		bool flag = obj == null;
		return !flag;
	}

	public int CompareTo(NetworkPrefabId other)
	{
		//IL_000a: Expected I4, but got VT
		return ((uint)this).CompareTo((uint)(int)other);
	}
}
