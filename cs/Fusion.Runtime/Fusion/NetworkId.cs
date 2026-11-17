using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion.Sockets;
using PlayFab.ClientModels;
using UnityEngine.UIElements.UIR;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Size = 4)]
public struct NetworkId : _0021_00210, Action<RemoveSharedGroupMembersResult>, _0021_00210, Action<UnityEngine.UIElements.UIR.RenderChainCommand>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7000]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal int _003C_002Ecctor_003Eb__39_0(double a, double b)
		{
			double num = default;
			return num.CompareTo(b);
		}
	}

	public const int BLOCK_SIZE = default(int);

	public const int ALIGNMENT = default(int);

	private static readonly NetworkObject.EqualityComparer Comparer__BackingField;

	[FieldOffset(0)]
	public uint Raw;

	internal const int MAX_RESERVED_ID = default(int);

	private const uint RAW_RUNTIME_CONFIG = default(uint);

	private const uint RAW_PLAYER_REF_DATA_ARRAY = default(uint);

	private const uint RAW_SCENE_INFO = default(uint);

	private const uint RAW_PHYSICS_INFO = default(uint);

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_RAW = default(int);

	internal const int BYTE_COUNT_OF_RAW = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public static NetworkObject.EqualityComparer Comparer
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
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
			return (NetworkObject.EqualityComparer)0;
		}
	}

	public bool IsValid
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			bool flag = Raw == 0;
			return !flag;
		}
	}

	public bool IsReserved
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			object obj = Raw - 1;
			bool flag = (nint)obj < 1023;
			object obj2 = !flag;
			return (byte)(int)(~obj2) != 0;
		}
	}

	internal static NetworkId RuntimeConfig
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (NetworkId)1;
		}
	}

	internal static NetworkId SceneInfo
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (NetworkId)3;
		}
	}

	internal static NetworkId PhysicsInfo
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (NetworkId)4;
		}
	}

	public static NetworkId None
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (NetworkId)0;
		}
	}

	internal NetworkId(uint raw)
	{
		Raw = raw;
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool Equals(NetworkId other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = Raw - other;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int CompareTo(NetworkId other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected I4, but got Unknown
		return (int)(Raw - other);
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
			object obj2 = 0;
			if (obj == obj2)
			{
				uint raw = Raw;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				object obj3 = (nint)(int)raw - (nint)0;
				return obj3 == null;
			}
		}
		return false;
	}

	private int System_002EIComparable_002ECompareTo(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
			object obj2 = 0;
			object obj3 = obj2;
			if (obj == obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				uint raw = Raw;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				return (int)((nint)(int)raw - (nint)0);
			}
		}
		return 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(NetworkId a, NetworkId b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(NetworkId a, NetworkId b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		bool flag = obj == null;
		return !flag;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static implicit operator bool(NetworkId id)
	{
		//IL_0009: Invalid comparison between VT and I4
		bool flag = id == (NetworkId)(object)0;
		return !flag;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static void Write(NetBitBuffer* buffer, NetworkId id)
	{
		//IL_0012: Expected I4, but got VT
		buffer->WriteUInt32VarLength((uint)(int)id, 8);
	}

	public unsafe static NetworkId Read(NetBitBuffer* buffer)
	{
		//IL_0012: Expected VT, but got I4
		return (NetworkId)buffer->ReadUInt32VarLength(8);
	}

	internal static NetworkId? TryRead(ref Fusion.NetBitBufferManaged buffer)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_003d: Expected VT, but got I4
		//IL_0021: Expected VT, but got I4
		//IL_002f: Expected VT, but got I4
		uint? num = buffer.TryReadUInt32VarLength(8);
		object obj = (_003F?)num & 0xFF;
		if (obj != null)
		{
			uint? num2 = default;
			uint value = num2.Value;
			NetworkId? networkId = (NetworkId)value;
			return (NetworkId?)(object)0;
		}
		return (NetworkId?)(object)0;
	}

	internal unsafe static NetworkId? TryRead(NetBitBuffer* buffer)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_003d: Expected VT, but got I4
		//IL_0021: Expected VT, but got I4
		//IL_002f: Expected VT, but got I4
		uint? num = buffer->TryReadUInt32VarLength(8);
		object obj = (_003F?)num & 0xFF;
		if (obj != null)
		{
			uint? num2 = default;
			uint value = num2.Value;
			NetworkId? networkId = (NetworkId)value;
			return (NetworkId?)(object)0;
		}
		return (NetworkId?)(object)0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void Write(NetBitBuffer* buffer)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I4
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
		buffer->WriteUInt32VarLength(Raw, 8);
	}

	[MethodImpl((MethodImplOptions)256)]
	internal static void Write(ref Fusion.NetBitBufferManaged buffer, NetworkId id)
	{
		//IL_0012: Expected I4, but got VT
		buffer.WriteUInt32VarLength((uint)(int)id, 8);
	}

	internal void Write(ref Fusion.NetBitBufferManaged buffer)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I4
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
		buffer.WriteUInt32VarLength(Raw, 8);
	}

	public override int GetHashCode()
	{
		return (int)Raw;
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object result;
		if ((int)Raw > 1)
		{
			if (Raw != 2)
			{
				if (Raw != 3)
				{
					if (Raw != 4)
					{
						goto IL_0150;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7098]");
					result = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7078]");
					result = 0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7080]");
				result = 0;
			}
		}
		else if (Raw != 0)
		{
			if (Raw != 1)
			{
				goto IL_0150;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7088]");
			result = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D70A0]");
			result = 0;
		}
		return (string)result;
		IL_0150:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7090]");
		object format = 0;
		object arg = default;
		return string.Format((string)format, arg);
	}

	public string ToNamePrefixString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Raw != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D70B0]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			return string.Format((string)format, arg);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D70A8]");
		return (string)0;
	}

	public static NetworkId FromRaw(uint value)
	{
		//IL_0005: Expected VT, but got I4
		return (NetworkId)value;
	}

	static NetworkId()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D70B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = obj3;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
