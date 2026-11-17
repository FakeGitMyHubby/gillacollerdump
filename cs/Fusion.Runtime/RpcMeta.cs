using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;

internal struct RpcMeta
{
	public readonly uint Key;

	public readonly Type DeclaringType;

	public readonly int Sources;

	public readonly int Targets;

	public readonly RpcInvokeDelegate Invoke;

	public unsafe RpcMeta(uint key, Type declaringType, int sources, int targets, RpcInvokeDelegate invoke)
	{
		//IL_0015: Expected Obj, but got Ref
		//IL_0032: Expected Obj, but got Ref
		Key = key;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj = declaringType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
		obj2 = invoke;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
