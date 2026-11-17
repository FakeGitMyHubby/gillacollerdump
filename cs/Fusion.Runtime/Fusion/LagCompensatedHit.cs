using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion.LagCompensation;
using UnityEngine;

namespace Fusion;

public struct LagCompensatedHit
{
	public HitType Type;

	public GameObject GameObject;

	public Vector3 Normal;

	public Vector3 Point;

	public Vector3 HitboxColliderPosition;

	public Quaternion HitboxColliderRotation;

	public float Distance;

	public Hitbox Hitbox;

	public Collider Collider;

	public Collider2D Collider2D;

	internal float _sortAux;

	public unsafe static explicit operator LagCompensatedHit(RaycastHit raycastHit)
	{
		//IL_001d: Expected Ref, but got VT
		//IL_00cc: Expected VT, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0076: Expected Obj, but got Ref
		//IL_0089: Expected Ref, but got VT
		//IL_00a0: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Collider collider = ((RaycastHit*)raycastHit)->collider;
		if ((object)collider != null)
		{
			GameObject gameObject = collider.gameObject;
			object obj2 = default;
			object obj = (nint)(&obj2) | (nint)8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 72));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Collider collider2 = ((RaycastHit*)raycastHit)->collider;
			object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 80));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			LagCompensatedHit result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (LagCompensatedHit)ex;
	}

	public unsafe static explicit operator LagCompensatedHit(RaycastHit2D raycastHit2D)
	{
		//IL_0009: Expected Ref, but got VT
		//IL_00b8: Expected VT, but got Obj
		//IL_0045: Expected Obj, but got I
		//IL_0062: Expected Obj, but got Ref
		//IL_0075: Expected Ref, but got VT
		//IL_008c: Expected Obj, but got Ref
		Collider2D collider = ((RaycastHit2D*)raycastHit2D)->collider;
		if ((object)collider != null)
		{
			GameObject gameObject = collider.gameObject;
			object obj2 = default;
			object obj = (nint)(&obj2) | (nint)8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 72));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Collider2D collider2 = ((RaycastHit2D*)raycastHit2D)->collider;
			object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 88));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			LagCompensatedHit result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (LagCompensatedHit)ex;
	}

	internal unsafe static LagCompensatedHit FromHitboxHit(ref HitboxHit hitboxHit)
	{
		//IL_00a9: Expected VT, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_0048: Expected Obj, but got I
		//IL_0065: Expected Obj, but got Ref
		//IL_007d: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hitboxHit @ X0 (Fusion.LagCompensation.HitboxHit&)+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hitboxHit @ X0 (Fusion.LagCompensation.HitboxHit&)+20]");
			GameObject gameObject = ((Component)0).gameObject;
			object obj2 = default;
			object obj = (nint)(&obj2) | (nint)8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 72));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 80));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			LagCompensatedHit result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (LagCompensatedHit)ex;
	}

	internal unsafe static void QuickSort(List<LagCompensatedHit> hits, int low, int high)
	{
		//IL_0027: Expected Obj, but got I
		//IL_008d: Expected VT, but got Ref
		//IL_0111: Expected VT, but got Ref
		//IL_00ad: Expected VT, but got Ref
		//IL_0131: Expected VT, but got Ref
		if (low >= high)
		{
			return;
		}
		LagCompensatedHit lagCompensatedHit = hits.get_Item(high);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6540]");
		object obj = 0;
		int num = low;
		int num2 = low;
		object obj2 = default;
		object obj3 = default;
		do
		{
			LagCompensatedHit lagCompensatedHit2 = hits.get_Item(num);
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				LagCompensatedHit lagCompensatedHit3 = hits.get_Item(num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				LagCompensatedHit lagCompensatedHit4 = hits.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				hits.set_Item(num2, (LagCompensatedHit)(&obj3));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				hits.set_Item(num, (LagCompensatedHit)(&obj3));
				num2++;
			}
			num++;
		}
		while (high != num);
		LagCompensatedHit lagCompensatedHit5 = hits.get_Item(num2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		LagCompensatedHit lagCompensatedHit6 = hits.get_Item(high);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		hits.set_Item(num2, (LagCompensatedHit)(&obj3));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		hits.set_Item(high, (LagCompensatedHit)(&obj3));
		int high2 = num2 - 1;
		QuickSort(hits, low, high2);
		int low2 = num2 + 1;
		QuickSort(hits, low2, high);
	}

	internal unsafe static void QuickSortDistance(List<LagCompensatedHit> hits, int low, int high)
	{
		//IL_0027: Expected Obj, but got I
		//IL_008d: Expected VT, but got Ref
		//IL_0111: Expected VT, but got Ref
		//IL_00ad: Expected VT, but got Ref
		//IL_0131: Expected VT, but got Ref
		if (low >= high)
		{
			return;
		}
		LagCompensatedHit lagCompensatedHit = hits.get_Item(high);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6540]");
		object obj = 0;
		int num = low;
		int num2 = low;
		object obj2 = default;
		object obj3 = default;
		do
		{
			LagCompensatedHit lagCompensatedHit2 = hits.get_Item(num);
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				LagCompensatedHit lagCompensatedHit3 = hits.get_Item(num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				LagCompensatedHit lagCompensatedHit4 = hits.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				hits.set_Item(num2, (LagCompensatedHit)(&obj3));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				hits.set_Item(num, (LagCompensatedHit)(&obj3));
				num2++;
			}
			num++;
		}
		while (high != num);
		LagCompensatedHit lagCompensatedHit5 = hits.get_Item(num2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		LagCompensatedHit lagCompensatedHit6 = hits.get_Item(high);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		hits.set_Item(num2, (LagCompensatedHit)(&obj3));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		hits.set_Item(high, (LagCompensatedHit)(&obj3));
		int high2 = num2 - 1;
		QuickSortDistance(hits, low, high2);
		int low2 = num2 + 1;
		QuickSortDistance(hits, low2, high);
	}
}
