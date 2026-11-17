using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion.LagCompensation;

[Serializable]
public struct PositionRotationQueryParams
{
	public QueryParams QueryParams;

	public Hitbox Hitbox;

	public unsafe PositionRotationQueryParams(QueryParams queryParams, Hitbox hitbox)
	{
		//IL_0030: Expected VT, but got I4
		//IL_003b: Expected Obj, but got Ref
		//IL_0050: Expected Obj, but got Ref
		_ = queryParams.UserArgs;
		_ = queryParams.Tick;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [queryParams @ X1 (Fusion.LagCompensation.QueryParams)+20]");
		_ = 0;
		QueryParams = (QueryParams)queryParams.Options;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
		obj2 = hitbox;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
