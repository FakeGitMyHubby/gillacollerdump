using System.Runtime.CompilerServices;

namespace Fusion;

public static class NetworkObjectFlagsExtensions
{
	public const NetworkObjectFlags CurrentVersion = default(NetworkObjectFlags);

	[MethodImpl((MethodImplOptions)256)]
	public static NetworkObjectFlags GetVersion(NetworkObjectFlags flags)
	{
		return flags & (NetworkObjectFlags)0xFF;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsVersionCurrent(NetworkObjectFlags flags)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		object obj = flags & (NetworkObjectFlags)0xFF;
		object obj2 = obj - 2;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static NetworkObjectFlags SetCurrentVersion(NetworkObjectFlags flags)
	{
		//IL_0012: Expected Obj, but got I8
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
		object obj = (long)flags & 0xFFFFFF00L;
		return (NetworkObjectFlags)(obj | 2);
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsIgnored(NetworkObjectFlags flags)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
		object obj = (int)flags >> 16;
		return (byte)(obj & 1) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static NetworkObjectFlags SetIgnored(NetworkObjectFlags flags, bool value)
	{
		//IL_0021: Expected Obj, but got I8
		//IL_002c: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_006c: Expected I4, but got Obj
		//IL_004c: Expected Obj, but got I4
		bool flag = !value;
		object obj = (long)flags & 0xFFFEFFFFL;
		object obj2 = !flag;
		object obj3 = ~obj2;
		object obj4 = ((obj3 != null) ? ((object)0) : ((object)65536));
		return (NetworkObjectFlags)(obj4 | obj);
	}

	[MethodImpl((MethodImplOptions)256)]
	private static NetworkObjectFlags SetWithMask(NetworkObjectFlags flags, NetworkObjectFlags value, NetworkObjectFlags mask)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		object obj = ~mask;
		object obj2 = flags & obj;
		return (NetworkObjectFlags)(obj2 | value);
	}

	public static NetworkObjectInterestModes GetInterestMode(NetworkObjectFlags flags)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		object obj = flags & (NetworkObjectFlags)0x200000;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = ~obj2;
		NetworkObjectInterestModes result = ((obj3 != null) ? ((NetworkObjectInterestModes)1) : ((NetworkObjectInterestModes)2));
		object obj4 = flags & (NetworkObjectFlags)0x100000;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			return result;
		}
		return (NetworkObjectInterestModes)0;
	}

	public static NetworkObjectFlags SetInterestMode(NetworkObjectFlags flags, NetworkObjectInterestModes value)
	{
		//IL_0012: Expected I4, but got I8
		NetworkObjectFlags networkObjectFlags = (NetworkObjectFlags)((long)flags & 0xFFCFFFFFL);
		NetworkObjectFlags networkObjectFlags2 = networkObjectFlags | (NetworkObjectFlags)0x200000;
		NetworkObjectFlags result = networkObjectFlags | (NetworkObjectFlags)0x100000;
		if (value == (NetworkObjectInterestModes)2)
		{
			networkObjectFlags = networkObjectFlags2;
		}
		if (value == 0)
		{
			return result;
		}
		return networkObjectFlags;
	}
}
