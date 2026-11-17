using System;

namespace Fusion;

public sealed class NetworkStructWeavedAttribute : Attribute
{
	private readonly int WordCount__BackingField;

	private readonly bool IsGenericComposite__BackingField;

	public int WordCount => WordCount__BackingField;

	internal bool IsGenericComposite => IsGenericComposite__BackingField;

	public NetworkStructWeavedAttribute(int wordCount)
	{
		WordCount__BackingField = wordCount;
	}

	internal NetworkStructWeavedAttribute(int wordCount, bool isGenericComposite)
	{
		WordCount__BackingField = wordCount;
		IsGenericComposite__BackingField = isGenericComposite;
	}
}
