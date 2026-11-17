using System;

namespace Fusion;

public sealed class UnityTooltipAttribute : Attribute
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

	public UnityTooltipAttribute(string tooltip)
	{
	}
}
