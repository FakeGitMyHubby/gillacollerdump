using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlayFab.ClientModels;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Pack = 4, Size = 64)]
public struct _16 : _0021_00210, Action<ListPlayerCustomPropertiesResult>, _0021_00210
{
	public const int SIZE = default(int);

	[FieldOffset(0)]
	public _32._003CData_003Ee__FixedBuffer Data;

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

	[FieldOffset(16)]
	[NonSerialized]
	private uint _data4;

	[FieldOffset(20)]
	[NonSerialized]
	private uint _data5;

	[FieldOffset(24)]
	[NonSerialized]
	private uint _data6;

	[FieldOffset(28)]
	[NonSerialized]
	private uint _data7;

	[FieldOffset(32)]
	[NonSerialized]
	private uint _data8;

	[FieldOffset(36)]
	[NonSerialized]
	private uint _data9;

	[FieldOffset(40)]
	[NonSerialized]
	private uint _data10;

	[FieldOffset(44)]
	[NonSerialized]
	private uint _data11;

	[FieldOffset(48)]
	[NonSerialized]
	private uint _data12;

	[FieldOffset(52)]
	[NonSerialized]
	private uint _data13;

	[FieldOffset(56)]
	[NonSerialized]
	private uint _data14;

	[FieldOffset(60)]
	[NonSerialized]
	private uint _data15;

	public unsafe void Set(ReadOnlySpan<uint> values)
	{
		//IL_000f: Expected VT, but got Ref
		ReadOnlySpan<uint> readOnlySpan = default;
		readOnlySpan.CopyTo((Span<uint>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this));
	}
}
