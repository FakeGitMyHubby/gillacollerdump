using System;

namespace Fusion;

public sealed class NetworkBehaviourWeavedAttribute : Attribute
{
	private readonly int WordCount__BackingField;

	public int WordCount => WordCount__BackingField;

	public NetworkBehaviourWeavedAttribute(int wordCount)
	{
		WordCount__BackingField = wordCount;
	}
}
