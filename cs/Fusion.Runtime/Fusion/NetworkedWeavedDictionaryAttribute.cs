using System;
using Cpp2ILInjected;

namespace Fusion;

public class NetworkedWeavedDictionaryAttribute : Attribute
{
	private readonly int Capacity__BackingField;

	private readonly int KeyWordCount__BackingField;

	private readonly int ValueWordCount__BackingField;

	private Type KeyReaderWriterType__BackingField;

	private Type ValueReaderWriterType__BackingField;

	public int Capacity => Capacity__BackingField;

	public int KeyWordCount => KeyWordCount__BackingField;

	public int ValueWordCount => ValueWordCount__BackingField;

	public Type KeyReaderWriterType
	{
		get
		{
			return KeyReaderWriterType__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public Type ValueReaderWriterType
	{
		get
		{
			return ValueReaderWriterType__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public NetworkedWeavedDictionaryAttribute(int capacity, int keyWordCount, int elementWordCount, Type keyReaderWriterType, Type valueReaderWriterType)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		Capacity__BackingField = capacity;
		KeyWordCount__BackingField = keyWordCount;
		ValueWordCount__BackingField = elementWordCount;
		object obj = this + 32;
		obj = keyReaderWriterType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 40;
		obj2 = valueReaderWriterType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
