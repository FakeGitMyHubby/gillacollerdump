using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class GillaOwnMeshes : MonoBehaviour
{
	public readonly List<Mesh> meshes;

	private unsafe void OnDestroy()
	{
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got I4
		//IL_0298: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got Ref
		//IL_00f7: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
		object obj3 = 0;
		Enumerator<, > enumerator = ((List<System.__Canon>)(object)meshes).GetEnumerator();
		object obj5 = default;
		object obj4 = obj5;
		Enumerator<, > val = default;
		while (val.MoveNext())
		{
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = (UnityEngine.Object)null != (UnityEngine.Object)null;
			bool flag3 = !flag2;
			obj4 = 0;
			if (!flag3)
			{
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v30+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(null);
				obj4 = 0;
			}
		}
		object obj10 = 0;
		object obj11 = 0;
		Enumerator<, > val2 = (Enumerator<, >)(ref val);
		object obj12 = 0;
		object obj15 = default;
		object obj16 = default;
		IntPtr intPtr = default;
		object obj17 = default;
		while (true)
		{
			nint num = (nint)obj3;
			val.Dispose();
			bool flag5 = obj12 == null;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				bool flag6 = obj10 == null;
				object obj14 = !flag6;
				OutOfMemoryException ex = (OutOfMemoryException)(&val);
				if (obj14 == null)
				{
					break;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj4 = obj5;
				obj10 = obj15;
				obj11 = obj16;
				num = intPtr;
				obj3 = 109895680;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			switch ((long)num)
			{
			case 2L:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj10 = 1;
				obj12 = obj11;
				break;
			case 1L:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj12 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj11 = obj17;
				break;
			default:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC5C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
		}
	}

	public GillaOwnMeshes()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7410]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj2 = this + 32;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
