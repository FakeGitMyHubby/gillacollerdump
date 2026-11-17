using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal struct NetworkInputMeta
{
	public readonly uint Key;

	public readonly int WordCount;

	public readonly Type Type;

	public unsafe NetworkInputMeta(uint key, int wordCount, Type type)
	{
		//IL_001f: Expected Obj, but got Ref
		Key = key;
		WordCount = wordCount;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj = type;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
