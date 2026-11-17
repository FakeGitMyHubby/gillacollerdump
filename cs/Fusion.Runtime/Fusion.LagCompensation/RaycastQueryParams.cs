using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

[Serializable]
public struct RaycastQueryParams
{
	public QueryParams QueryParams;

	public Vector3 Origin;

	public Vector3 Direction;

	public float Length;

	public int StaticHitsCapacity;

	public unsafe RaycastQueryParams(QueryParams queryParams, Vector3 origin, Vector3 direction, float length, int staticHitsCapacity = default(int))
	{
		//IL_0030: Expected VT, but got I4
		//IL_003b: Expected Obj, but got Ref
		//IL_004f: Expected VT, but got F4
		//IL_0081: Expected I4, but got VT
		_ = queryParams.UserArgs;
		_ = queryParams.Tick;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [queryParams @ X1 (Fusion.LagCompensation.QueryParams)+20]");
		_ = 0;
		QueryParams = (QueryParams)queryParams.Options;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Origin = (Vector3)length;
		Vector3 direction2 = default;
		Direction = direction2;
		float length2 = default;
		Length = length2;
		StaticHitsCapacity = (int)origin;
	}
}
