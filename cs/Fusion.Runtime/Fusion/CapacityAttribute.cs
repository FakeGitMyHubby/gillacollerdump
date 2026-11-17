using System;

namespace Fusion;

public sealed class CapacityAttribute : Attribute
{
	private readonly int Length__BackingField;

	public int Length => Length__BackingField;

	public CapacityAttribute(int length)
	{
		Length__BackingField = length;
	}
}
