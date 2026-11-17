using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

public class MonsterGore : ScriptableObject
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass12_0
	{
		public GameObject m;
	}

	[Serializable]
	public class Limb
	{
		public GoreSection section;

		public string bone;

		public Vector3 from;

		public Vector3 to;

		public float radius;
	}

	public Mesh mesh;

	public float units;

	public byte[] sectionOf;

	public Limb[] limbs;

	public MonsterNavMesh.Arm[] arms;

	public GillaHands.Piece[] pieces;

	public Material wound;

	public Material flesh;

	public bool legs;

	public MonsterGore()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE68]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE70]");
		object obj4 = 0;
		units = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 40;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 48;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj9 = this + 56;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj11 = this + 64;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
