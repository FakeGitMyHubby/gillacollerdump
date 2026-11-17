using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class ShopRooms : MonoBehaviour
{
	public Bounds[] rooms;

	private static ShopRooms here;

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9E0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = this;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 == this)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+A0]");
			object obj8 = 0;
			obj8 = 0;
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static bool Holds(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_0210: Expected I4, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I8
		//IL_0131: Expected Obj, but got I
		//IL_013a: Expected VT, but got I4
		//IL_0143: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01cb: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		bool flag5;
		if (obj7 == null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+A0]");
			object obj9 = 0;
			object obj10 = obj9;
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v9+20]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v9+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X19_v8+18]");
					if ((nint)0 < (nint)1)
					{
						goto IL_01e6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X19_v8+18]");
					object obj12 = 0 & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v9+20]");
					object obj13 = (nint)0 + (nint)32;
					Bounds bounds = (Bounds)0;
					object obj14 = 0;
					Vector3 point = default;
					Vector3 vector = default;
					while (true)
					{
						bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
						object obj15 = !flag4;
						if (obj15 != null)
						{
							break;
						}
						flag5 = bounds.Internal_Contains(ref point);
						bool flag6 = !flag5;
						object obj16 = !flag6;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X19_v8+18]");
							obj12 = 0;
							obj14++;
							obj13 += 24;
							object obj17 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X19_v8+18]");
							bool flag7 = (nint)obj17 < 0;
							bounds = (Bounds)obj13;
							point = vector;
							if (flag7)
							{
								continue;
							}
						}
						goto IL_0260;
					}
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
		}
		goto IL_01e6;
		IL_0260:
		return flag5;
		IL_01e6:
		flag5 = false;
		goto IL_0260;
	}

	public ShopRooms()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5048]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 32;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
