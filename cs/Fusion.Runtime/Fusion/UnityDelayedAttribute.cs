using System;

namespace Fusion;

public sealed class UnityDelayedAttribute : Attribute
{
	private int order__BackingField;

	public int order
	{
		get
		{
			return order__BackingField;
		}
		set
		{
			order__BackingField = value;
		}
	}
}
