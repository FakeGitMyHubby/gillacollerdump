using System;

namespace Fusion;

public sealed class NetworkSerializeMethodAttribute : Attribute
{
	private int MaxSize__BackingField;

	public int MaxSize
	{
		get
		{
			return MaxSize__BackingField;
		}
		set
		{
			MaxSize__BackingField = value;
		}
	}
}
