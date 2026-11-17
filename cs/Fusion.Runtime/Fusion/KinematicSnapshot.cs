using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public struct KinematicSnapshot
{
	public Vector3 WorldPosition;

	public Quaternion WorldRotation;

	public Vector3 LinearVelocity;

	public Vector3 AngularVelocity;

	public bool IsSleeping;

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003c: Expected Obj, but got Ref
		//IL_0052: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got Ref
		//IL_017f: Expected Obj, but got I8
		//IL_0124: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01e2: Expected Obj, but got Ref
		//IL_025b: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_01f8: Expected I, but got Obj
		//IL_0208: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02e4: Expected Obj, but got Ref
		//IL_0355: Expected Obj, but got I8
		//IL_02fa: Expected I, but got Obj
		//IL_030a: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_03a2: Expected Obj, but got I
		//IL_03c8: Expected Obj, but got Ref
		//IL_0441: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I4
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_03de: Expected I, but got Obj
		//IL_03ee: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object[] array = default;
		if (array != null)
		{
			object obj3 = default;
			bool flag = obj3 == null;
			object obj5 = default;
			object obj4 = (object)(&obj5);
			IndexOutOfRangeException ex = default;
			object obj6;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
				obj6 = 0;
				if (flag2)
				{
					goto IL_04e5;
				}
			}
			if (array.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
				object obj7 = 0;
				object obj8 = array + 32;
				obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj9 = default;
				bool flag3 = obj9 == null;
				object obj10 = default;
				obj4 = (object)(&obj10);
				if (!flag3)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
					obj6 = 0;
					if (flag4)
					{
						goto IL_04e5;
					}
				}
				object obj11 = array.Length & 0xFFFFFFFEL;
				if (obj11 != null)
				{
					object obj12 = array + 40;
					obj12 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj13 = default;
					bool flag5 = obj13 == null;
					object obj14 = default;
					obj4 = (object)(&obj14);
					if (!flag5)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
						obj6 = 0;
						if (flag6)
						{
							goto IL_04e5;
						}
					}
					bool flag7 = array.Length < 2;
					object obj15 = !flag7;
					object obj16 = array.Length - 2;
					bool flag8 = obj16 == null;
					object obj17 = ~obj15;
					object obj18 = obj17 | flag8;
					if (obj18 == null)
					{
						object obj19 = array + 48;
						obj19 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj20 = default;
						bool flag9 = obj20 == null;
						object obj21 = default;
						obj4 = (object)(&obj21);
						if (!flag9)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag10 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
							obj6 = 0;
							if (flag10)
							{
								goto IL_04e5;
							}
						}
						object obj22 = array.Length & 0xFFFFFFFCL;
						if (obj22 != null)
						{
							object obj23 = array + 56;
							obj23 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj25 = default;
							bool flag11 = obj25 == null;
							object obj26 = default;
							obj4 = (object)(&obj26);
							if (!flag11)
							{
								nint num5 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag12 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
								obj6 = 0;
								if (flag12)
								{
									goto IL_04e5;
								}
							}
							bool flag13 = array.Length < 4;
							object obj27 = !flag13;
							object obj28 = array.Length - 4;
							bool flag14 = obj28 == null;
							object obj29 = ~obj27;
							object obj30 = obj29 | flag14;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6898]");
								object format = 0;
								object obj31 = array + 64;
								obj31 = obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								return string.Format((string)format, array);
							}
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			obj6 = obj4;
			goto IL_04e5;
		}
		goto IL_04fd;
		IL_04fd:
		return (string)(object)new NullReferenceException();
		IL_04e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		goto IL_04fd;
	}
}
