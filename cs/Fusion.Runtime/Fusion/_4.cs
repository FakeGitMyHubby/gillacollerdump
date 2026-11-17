using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlayFab.GroupsModels;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Pack = 4, Size = 16)]
public struct _4 : _0021_00210, Action<ListMembershipResponse>, _0021_00210
{
	public const int SIZE = default(int);

	[FieldOffset(0)]
	public _8._003CData_003Ee__FixedBuffer Data;

	[FieldOffset(0)]
	[NonSerialized]
	private uint _data0;

	[FieldOffset(4)]
	[NonSerialized]
	private uint _data1;

	[FieldOffset(8)]
	[NonSerialized]
	private uint _data2;

	[FieldOffset(12)]
	[NonSerialized]
	private uint _data3;

	public unsafe void Set(ReadOnlySpan<uint> values)
	{
		//IL_000f: Expected VT, but got Ref
		ReadOnlySpan<uint> readOnlySpan = default;
		readOnlySpan.CopyTo((Span<uint>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this));
	}
}
