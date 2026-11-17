using System;

namespace Fusion;

public sealed class RpcPayloadAttribute : Attribute
{
	private readonly int ByteCount__BackingField;

	public int ByteCount => ByteCount__BackingField;

	public RpcPayloadAttribute()
	{
	}

	public RpcPayloadAttribute(int byteSize)
	{
		ByteCount__BackingField = byteSize;
	}
}
