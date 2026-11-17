using System;

namespace Fusion;

public sealed class UnityHeaderAttribute : Attribute
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

	public UnityHeaderAttribute(string header)
	{
	}
}
