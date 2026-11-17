using System;

namespace Fusion;

public sealed class NetworkInputWeavedAttribute : Attribute
{
	private readonly int WordCount__BackingField;

	private readonly uint Key__BackingField;

	public int WordCount => WordCount__BackingField;

	public uint Key => Key__BackingField;

	public NetworkInputWeavedAttribute(uint key, int wordCount)
	{
		WordCount__BackingField = wordCount;
		Key__BackingField = key;
	}
}
