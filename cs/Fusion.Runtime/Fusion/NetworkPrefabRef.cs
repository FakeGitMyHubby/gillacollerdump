using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.MultiplayerModels;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Size = 16)]
public struct NetworkPrefabRef : Action<RequestMultiplayerServerResponse>, _0021_00210, Action<RequestPartyServiceResponse>
{
	public sealed class EqualityComparer : _0021_00210
	{
		public bool Equals(NetworkPrefabRef x, NetworkPrefabRef y)
		{
			//IL_0008: Invalid comparison between VT and I
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected Obj, but got Unknown
			IntPtr intPtr = default;
			if (x == (NetworkPrefabRef)(object)(nint)intPtr)
			{
				object obj2 = default;
				object obj = y - obj2;
				return obj == null;
			}
			return false;
		}

		public int GetHashCode(NetworkPrefabRef obj)
		{
			NetworkPrefabRef networkPrefabRef = default;
			int hashCode = networkPrefabRef.GetHashCode();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
			if (num == 0)
			{
				return hashCode;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			int result = default;
			return result;
		}
	}

	public const int ALIGNMENT = default(int);

	[FieldOffset(0)]
	public NetworkObjectHeader._003CRawGuidValue_003Ee__FixedBuffer RawGuidValue;

	[FieldOffset(0)]
	[NonSerialized]
	private long _data0;

	[FieldOffset(8)]
	[NonSerialized]
	private long _data1;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_RAW_GUID_VALUE = default(int);

	internal const int BYTE_COUNT_OF_RAW_GUID_VALUE = default(int);

	internal const int BYTE_OF__DATA0 = default(int);

	internal const int BYTE_COUNT_OF__DATA0 = default(int);

	internal const int BYTE_OF__DATA1 = default(int);

	internal const int BYTE_COUNT_OF__DATA1 = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public static NetworkPrefabRef Empty
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (NetworkPrefabRef)0;
		}
	}

	public bool IsValid
	{
		get
		{
			//IL_000b: Invalid comparison between VT and I4
			if (RawGuidValue != (NetworkObjectHeader._003CRawGuidValue_003Ee__FixedBuffer)(object)0)
			{
				return true;
			}
			bool flag = _data1 == 0;
			return !flag;
		}
	}

	public unsafe NetworkPrefabRef(string guid)
	{
		//IL_002a: Expected VT, but got I4
		Guid guid2 = new Guid(guid);
		object obj = default;
		object obj2 = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&obj), (byte*)(&obj2));
		RawGuidValue = (NetworkObjectHeader._003CRawGuidValue_003Ee__FixedBuffer)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		if (num != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	public NetworkPrefabRef(long data0, long data1)
	{
		//IL_000a: Expected VT, but got I8
		RawGuidValue = (NetworkObjectHeader._003CRawGuidValue_003Ee__FixedBuffer)data0;
		_data1 = data1;
	}

	public NetworkPrefabRef(byte[] guid)
	{
		//IL_001c: Expected VT, but got I8
		long num = BitConverter.ToInt64(guid, 0);
		RawGuidValue = (NetworkObjectHeader._003CRawGuidValue_003Ee__FixedBuffer)num;
		long data = BitConverter.ToInt64(guid, 8);
		_data1 = data;
	}

	public unsafe NetworkPrefabRef(byte* guid)
	{
		//IL_000a: Expected VT, but got I
		//IL_001c: Expected I8, but got I
		RawGuidValue = (NetworkObjectHeader._003CRawGuidValue_003Ee__FixedBuffer)guid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [guid @ X1 (System.Byte*)+8]");
		_data1 = 0L;
	}

	public unsafe static implicit operator NetworkPrefabRef(Guid guid)
	{
		//IL_0042: Expected VT, but got I4
		Guid guid2 = default;
		object obj = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&guid2), (byte*)(&obj));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return (NetworkPrefabRef)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkPrefabRef result = default;
		return result;
	}

	public unsafe static implicit operator Guid(NetworkPrefabRef guid)
	{
		//IL_0042: Expected VT, but got I4
		NetworkPrefabRef networkPrefabRef = default;
		object obj = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&networkPrefabRef), (byte*)(&obj));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return (Guid)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Guid result = default;
		return result;
	}

	public unsafe static bool TryParse(string str, out NetworkPrefabRef guid)
	{
		bool flag = Guid.TryParse(str, out var result);
		if (flag)
		{
			object obj = default;
			object obj2 = default;
			NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&obj), (byte*)(&obj2));
			ref NetworkPrefabRef reference = ref *(NetworkPrefabRef*)null;
			bool flag2 = (byte)(&obj) != 0;
			byte* ptr = (byte*)(&obj2);
		}
		else
		{
			ref NetworkPrefabRef reference = ref *(NetworkPrefabRef*)null;
			_ = 0;
			bool flag2 = flag;
			byte* ptr = (byte*)(&result);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
		if (num == 0)
		{
			return flag;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public unsafe static NetworkPrefabRef Parse(string str)
	{
		//IL_0054: Expected VT, but got I4
		Guid guid = Guid.Parse(str);
		Guid guid2 = default;
		object obj = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&guid2), (byte*)(&obj));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return (NetworkPrefabRef)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkPrefabRef result = default;
		return result;
	}

	public static bool operator ==(NetworkPrefabRef a, NetworkPrefabRef b)
	{
		//IL_0008: Invalid comparison between VT and I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		IntPtr intPtr = default;
		if (a == (NetworkPrefabRef)(object)(nint)intPtr)
		{
			object obj2 = default;
			object obj = b - obj2;
			return obj == null;
		}
		return false;
	}

	public static bool operator !=(NetworkPrefabRef a, NetworkPrefabRef b)
	{
		//IL_0008: Invalid comparison between VT and I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		IntPtr intPtr = default;
		bool flag;
		if (a == (NetworkPrefabRef)(object)(nint)intPtr)
		{
			object obj2 = default;
			object obj = b - obj2;
			flag = obj == null;
		}
		else
		{
			flag = false;
		}
		return !flag;
	}

	public bool Equals(NetworkPrefabRef other)
	{
		//IL_0030: Expected Obj, but got I8
		if (RawGuidValue == (NetworkObjectHeader._003CRawGuidValue_003Ee__FixedBuffer)other)
		{
			IntPtr intPtr = default;
			object obj = _data1 - (nint)intPtr;
			return obj == null;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0046: Invalid comparison between VT and I
		//IL_0074: Expected Obj, but got I8
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8218]");
			object obj2 = 0;
			if (obj == obj2)
			{
				NetworkObjectHeader._003CRawGuidValue_003Ee__FixedBuffer rawGuidValue = RawGuidValue;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				if (rawGuidValue == (NetworkObjectHeader._003CRawGuidValue_003Ee__FixedBuffer)(object)0)
				{
					long data = _data1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+18]");
					object obj3 = data - 0;
					return obj3 == null;
				}
			}
		}
		return false;
	}

	public unsafe override int GetHashCode()
	{
		object obj = default;
		object obj2 = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&obj), (byte*)(&obj2));
		Guid guid = default;
		int hashCode = guid.GetHashCode();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return hashCode;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		int result = default;
		return result;
	}

	public unsafe override string ToString()
	{
		object obj = default;
		object obj2 = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&obj), (byte*)(&obj2));
		Guid guid = default;
		string result = guid.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		string result2 = default;
		return result2;
	}

	public string ToUnityGuidString()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF1A8]");
		object obj = 0;
		return ToString((string)obj);
	}

	public unsafe string ToString(string format)
	{
		object obj = default;
		object obj2 = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&obj), (byte*)(&obj2));
		Guid guid = default;
		string result = guid.ToString(format);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		string result2 = default;
		return result2;
	}

	public int CompareTo(NetworkPrefabRef other)
	{
		//IL_000f: Expected Obj, but got VT
		//IL_0017: Invalid comparison between Obj and VT
		//IL_00aa: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I8
		object obj = RawGuidValue - other;
		if (obj == (object)other)
		{
			IntPtr intPtr = default;
			obj = _data1 - (nint)intPtr;
			if ((nint)obj == (nint)intPtr)
			{
				return 0;
			}
		}
		bool flag = (nint)obj < 0;
		object obj2 = obj ^ obj;
		object obj3 = obj & obj2;
		bool flag2 = (nint)obj3 < 0;
		bool flag3 = flag == flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			return -1;
		}
		return 1;
	}

	public static explicit operator NetworkObjectGuid(NetworkPrefabRef t)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ SYSREG+28]");
		if (num == 0)
		{
			return (NetworkObjectGuid)t;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkObjectGuid result = default;
		return result;
	}
}
