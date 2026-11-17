using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

[Serializable]
public struct SphereOverlapQueryParams
{
	public QueryParams QueryParams;

	public Vector3 Center;

	public float Radius;

	public int StaticHitsCapacity;

	public unsafe SphereOverlapQueryParams(QueryParams queryParams, Vector3 center, float radius, int staticHitsCapacity)
	{
		//IL_0030: Expected VT, but got I4
		//IL_003b: Expected Obj, but got Ref
		//IL_004f: Expected VT, but got F4
		//IL_006d: Expected I4, but got VT
		_ = queryParams.UserArgs;
		_ = queryParams.Tick;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [queryParams @ X1 (Fusion.LagCompensation.QueryParams)+20]");
		_ = 0;
		QueryParams = (QueryParams)queryParams.Options;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Center = (Vector3)radius;
		float radius2 = default;
		Radius = radius2;
		StaticHitsCapacity = (int)center;
	}
}
