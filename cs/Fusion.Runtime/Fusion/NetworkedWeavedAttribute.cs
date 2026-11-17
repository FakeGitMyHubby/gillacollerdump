using System;

namespace Fusion;

public sealed class NetworkedWeavedAttribute : Attribute
{
	private readonly int WordOffset__BackingField;

	private readonly int WordCount__BackingField;

	public int WordOffset => WordOffset__BackingField;

	public int WordCount => WordCount__BackingField;

	public NetworkedWeavedAttribute(int wordOffset, int wordCount)
	{
		WordOffset__BackingField = wordOffset;
		WordCount__BackingField = wordCount;
	}
}
