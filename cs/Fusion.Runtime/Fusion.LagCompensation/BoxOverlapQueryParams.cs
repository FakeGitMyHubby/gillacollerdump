using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

[Serializable]
public struct BoxOverlapQueryParams
{
	public QueryParams QueryParams;

	public Vector3 Center;

	public Vector3 Extents;

	public Quaternion Rotation;

	public int StaticHitsCapacity;

	public unsafe BoxOverlapQueryParams(QueryParams queryParams, Vector3 center, Vector3 extents, Quaternion rotation, int staticHitsCapacity)
	{
		//IL_0026: Expected VT, but got I4
		//IL_003b: Expected Obj, but got Ref
		//IL_0081: Expected I4, but got VT
		_ = queryParams.UserArgs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [queryParams @ X1 (Fusion.LagCompensation.QueryParams)+20]");
		_ = 0;
		QueryParams = (QueryParams)queryParams.Options;
		_ = queryParams.Tick;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Vector3 center2 = default;
		Center = center2;
		Vector3 extents2 = default;
		Extents = extents2;
		Quaternion rotation2 = default;
		Rotation = rotation2;
		StaticHitsCapacity = (int)center;
	}
}
