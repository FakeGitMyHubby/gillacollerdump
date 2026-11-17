using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

[Serializable]
public abstract class Query : _0021_00210
{
	public QueryTriggerInteraction TriggerInteraction;

	public HitOptions Options;

	public LayerMask LayerMask;

	[NonSerialized]
	public PlayerRef Player;

	[NonSerialized]
	public int? Tick;

	[NonSerialized]
	public unsafe void* UserArgs;

	[NonSerialized]
	public float? Alpha;

	[NonSerialized]
	public int? TickTo;

	[NonSerialized]
	public PreProcessingDelegate PreProcessingDelegate;

	protected Query(ref QueryParams qParams)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I
		object obj = this + 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [qParams @ X1 (Fusion.LagCompensation.QueryParams&)+28]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [qParams @ X1 (Fusion.LagCompensation.QueryParams&)+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [qParams @ X1 (Fusion.LagCompensation.QueryParams&)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [qParams @ X1 (Fusion.LagCompensation.QueryParams&)+30]");
		_ = 0;
		_ = qParams;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [qParams @ X1 (Fusion.LagCompensation.QueryParams&)+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [qParams @ X1 (Fusion.LagCompensation.QueryParams&)+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [qParams @ X1 (Fusion.LagCompensation.QueryParams&)+1C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [qParams @ X1 (Fusion.LagCompensation.QueryParams&)+10]");
		int? num = 0;
		_ = 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	private bool Fusion_002ELagCompensation_002EIBoundsTraversalTest_002ECheck(ref AABB bounds)
	{
		//IL_0005: Expected I, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Fusion.LagCompensation.Query>)+188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Fusion.LagCompensation.Query>)+190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected abstract bool Check(ref AABB bounds);

	internal abstract bool NarrowPhase(IHitboxColliderContainer container, HashSet<int> candidates, List<HitboxHit> hits);

	internal abstract void PerformStaticQuery(NetworkRunner runner, List<LagCompensatedHit> hits, HitOptions options);

	internal unsafe HitboxHit CreateHitboxHit(ref HitboxCollider collider, Vector3 point, float distance, Vector3 normal)
	{
		//IL_000e: Expected Obj, but got Ref
		//IL_0026: Expected Obj, but got Ref
		float num = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref collider, 452));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		HitboxHit result = default;
		return result;
	}
}
