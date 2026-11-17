using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace GorillaLocomotion;

public class HeldShape
{
	public readonly Vector3[] at;

	public readonly float[] radius;

	public readonly float reach;

	public bool goesIn;

	public HeldShape(Vector3[] at, float[] radius)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got I8
		//IL_008d: Expected Obj, but got I
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_01b6: Invalid comparison between F4 and I4
		//IL_01c5: Invalid comparison between F4 and I4
		//IL_01da: Expected Obj, but got F4
		//IL_01e9: Expected Obj, but got F4
		//IL_021e: Expected Obj, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = at;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 24;
		obj2 = radius;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (at.Length < 1)
		{
			return;
		}
		object obj3 = at.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj4 = 0;
		object obj5 = at + 40;
		object obj6 = radius + 32;
		object obj7 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj8 = !flag;
			if (obj8 != null)
			{
				break;
			}
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = (nint)obj7 < radius.Length;
			object obj11 = !flag3;
			if (obj11 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X24_v5-8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X24_v5-8]");
			object obj12 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X24_v5-4]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X24_v5-4]");
			object obj13 = num2 * 0;
			obj3 = at.Length;
			obj5 += 12;
			object obj14 = obj12 + obj13;
			object obj15 = obj5 * obj5;
			object obj16 = obj14 + obj15;
			obj7++;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num3 = (float)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X25_v4+v100 @ X23_v5*4]");
			float num4 = num3 + 0f;
			float num5 = reach - num4;
			bool flag4 = num5 < 0f;
			bool flag5 = num5 == 0f;
			object obj17 = reach ^ num4;
			object obj18 = reach ^ num5;
			object obj19 = obj17 & obj18;
			bool flag6 = (nint)obj19 < 0;
			bool flag7 = flag4 == flag6;
			object obj20 = !flag5;
			object obj21 = flag7 & obj20;
			object obj22 = ~obj21;
			if (obj22 == null)
			{
				num4 = reach;
			}
			reach = num4;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
