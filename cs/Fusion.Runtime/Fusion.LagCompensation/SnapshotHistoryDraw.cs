using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Fusion.LagCompensation;

public class SnapshotHistoryDraw : Action<ProbeReferenceVolume.ExtraDataActionInput>, _0021_00210
{
	public struct ContactData
	{
		public Vector3 Point;

		public Vector3 Normal;

		public float Penetration;
	}

	private HitboxBuffer _buffer;

	private HitboxColliderContainerDraw _containerDraw;

	internal SnapshotHistoryDraw(HitboxBuffer buffer)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6498]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HitboxColliderContainerDraw hitboxColliderContainerDraw = default;
		hitboxColliderContainerDraw._002Ector();
		object obj2 = this + 24;
		obj2 = hitboxColliderContainerDraw;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		object obj3 = this + 16;
		obj3 = buffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public IEnumerator<HitboxColliderContainerDraw> GetEnumerator()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D64C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator<HitboxColliderContainerDraw>)obj2;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return (IEnumerator)GetEnumerator();
	}
}
