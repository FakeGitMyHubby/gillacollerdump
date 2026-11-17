using System;
using Cpp2ILInjected;

namespace Fusion;

public class NetworkedWeavedArrayAttribute : Attribute
{
	private readonly int Capacity__BackingField;

	private readonly int ElementWordCount__BackingField;

	private readonly Type ElementReaderWriterType__BackingField;

	public int Capacity => Capacity__BackingField;

	public int ElementWordCount => ElementWordCount__BackingField;

	public Type ElementReaderWriterType => ElementReaderWriterType__BackingField;

	public NetworkedWeavedArrayAttribute(int capacity, int elementWordCount, Type elementReaderWriter)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = elementReaderWriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
