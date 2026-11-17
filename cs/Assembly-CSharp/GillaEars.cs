using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class GillaEars
{
	private static AudioListener last;

	public static AudioListener Listening
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_030c: Expected Obj, but got I
			//IL_032e: Expected Obj, but got I4
			//IL_00e1: Expected Obj, but got I
			//IL_00ea: Expected Obj, but got I4
			//IL_0102: Expected Obj, but got I
			//IL_0136: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got I
			//IL_018a: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I4
			//IL_02cb: Expected Obj, but got I
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Expected Obj, but got Unknown
			//IL_01c6: Expected Obj, but got I4
			//IL_0355: Expected Obj, but got I4
			//IL_0201: Expected Obj, but got I
			//IL_021f: Expected Obj, but got I4
			//IL_028c: Expected Obj, but got I
			//IL_029c: Expected Obj, but got I
			//IL_023d: Expected Obj, but got I
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4310]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj5 != null)
			{
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v21+A0]");
				object obj8 = 0;
				if (obj8 == null)
				{
					goto IL_02d0;
				}
				bool isActiveAndEnabled = ((Behaviour)obj8).isActiveAndEnabled;
				bool flag2 = !isActiveAndEnabled;
				object obj9 = !flag2;
				if (obj9 != null)
				{
					goto IL_02b3;
				}
			}
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v11+A0]");
			object obj11 = 0;
			obj11 = 0;
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4318]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
			object obj16 = default;
			if (obj16 == null)
			{
				goto IL_02d0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v18+18]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v18+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_02b3;
			}
			object obj18 = obj16 + 32;
			object obj19 = 0;
			while (true)
			{
				bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
				object obj20 = !flag4;
				if (obj20 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X23_v5+v86 @ X22_v6*8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X23_v5+v86 @ X22_v6*8]");
					bool isActiveAndEnabled2 = ((Behaviour)0).isActiveAndEnabled;
					bool flag5 = !isActiveAndEnabled2;
					object obj21 = !flag5;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v18+18]");
						obj17 = 0;
						obj19++;
						object obj22 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v18+18]");
						if ((nint)obj22 < 0)
						{
							continue;
						}
					}
					else
					{
						object obj23 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v17+A0]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X23_v5+v86 @ X22_v6*8]");
						obj24 = 0;
						object obj25 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					goto IL_02b3;
				}
				goto IL_02d0;
			}
			goto IL_02de;
			IL_02de:
			return (AudioListener)(object)new IndexOutOfRangeException();
			IL_02b3:
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v8+A0]");
			return (AudioListener)0;
			IL_02d0:
			NullReferenceException ex = new NullReferenceException();
			goto IL_02de;
		}
	}
}
