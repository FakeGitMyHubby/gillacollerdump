using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlayFab.GroupsModels;
using PlayFab.ProgressionModels;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Pack = 4, Size = 8)]
public struct _2 : Action<ListLeaderboardDefinitionsResponse>, _0021_00210, Action<ListMembershipOpportunitiesResponse>
{
	public const int SIZE = default(int);

	[FieldOffset(0)]
	public _4._003CData_003Ee__FixedBuffer Data;

	[FieldOffset(0)]
	[NonSerialized]
	private uint _data0;

	[FieldOffset(4)]
	[NonSerialized]
	private uint _data1;

	public unsafe void Set(ReadOnlySpan<uint> values)
	{
		//IL_000f: Expected VT, but got Ref
		ReadOnlySpan<uint> readOnlySpan = default;
		readOnlySpan.CopyTo((Span<uint>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this));
	}
}
