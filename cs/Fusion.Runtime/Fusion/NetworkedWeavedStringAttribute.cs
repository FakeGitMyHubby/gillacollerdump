using System;
using Cpp2ILInjected;

namespace Fusion;

public class NetworkedWeavedStringAttribute : Attribute
{
	private readonly int Capacity__BackingField;

	private readonly string CacheFieldName__BackingField;

	public int Capacity => Capacity__BackingField;

	public string CacheFieldName => CacheFieldName__BackingField;

	public NetworkedWeavedStringAttribute(int capacity, string cacheFieldName)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = cacheFieldName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
