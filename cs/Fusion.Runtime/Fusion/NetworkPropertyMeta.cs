using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal struct NetworkPropertyMeta
{
	public readonly int WordOffset;

	public readonly int WordCount;

	public readonly int Capacity;

	public readonly Type PropertyType;

	public readonly Type ValueReaderWriterType;

	public readonly Type KeyReaderWriterType;

	public readonly NetworkPropertyMetaFlags Flags;

	public unsafe NetworkPropertyMeta(int wordOffset, int wordCount, int capacity, Type propertyType, Type valueReaderWriterType, Type keyReaderWriterType, NetworkPropertyMetaFlags flags)
	{
		//IL_0029: Expected Obj, but got Ref
		//IL_0046: Expected Obj, but got Ref
		//IL_0068: Expected Obj, but got Ref
		WordOffset = wordOffset;
		WordCount = wordCount;
		Capacity = capacity;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj = propertyType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
		obj2 = valueReaderWriterType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 32));
		obj3 = keyReaderWriterType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
