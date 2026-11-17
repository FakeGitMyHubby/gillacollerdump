using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

public class LagCompensationDraw
{
	public SnapshotHistoryDraw SnapshotHistoryDraw;

	public BVHDraw BVHDraw;

	internal LagCompensationDraw(HitboxBuffer _buffer)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6488]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6490]");
		object obj2 = 0;
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		SnapshotHistoryDraw snapshotHistoryDraw = default;
		snapshotHistoryDraw._002Ector(_buffer);
		object obj3 = this + 16;
		obj3 = snapshotHistoryDraw;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		BVHDraw bVHDraw = default;
		bVHDraw._002Ector(_buffer);
		object obj4 = this + 24;
		obj4 = bVHDraw;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public static void GizmosDrawWireCapsule(Vector3 topCenter, Vector3 bottomCenter, float capsuleRadius)
	{
		//IL_000e: Expected VT, but got I4
		//IL_001c: Expected VT, but got I4
		//IL_0034: Expected VT, but got I4
		//IL_0047: Expected VT, but got I4
		//IL_005a: Expected VT, but got I4
		//IL_006d: Expected VT, but got I4
		Gizmos.DrawWireSphere((Vector3)0, capsuleRadius);
		float radius = default;
		Gizmos.DrawWireSphere((Vector3)0, radius);
		Gizmos.DrawLine((Vector3)0, bottomCenter);
		Gizmos.DrawLine((Vector3)0, bottomCenter);
		Gizmos.DrawLine((Vector3)0, bottomCenter);
		Gizmos.DrawLine((Vector3)0, bottomCenter);
	}
}
