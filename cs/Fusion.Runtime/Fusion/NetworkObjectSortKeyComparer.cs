using System;
using Cpp2ILInjected;

namespace Fusion;

public class NetworkObjectSortKeyComparer : _0021_00210
{
	public static readonly NetworkObjectSortKeyComparer Instance;

	public unsafe int Compare(NetworkObject x, NetworkObject y)
	{
		//IL_0071: Expected I4, but got Obj
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected I4, but got Unknown
		if ((object)x != null && (object)y != null)
		{
			uint num = (uint)(x + 64);
			return ((uint*)num)->CompareTo(y.SortKey);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	static NetworkObjectSortKeyComparer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D87D8]");
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
}
