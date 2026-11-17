using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaPitKill : MonoBehaviour
{
	public Bounds pits;

	private const float RoomOver = default(float);

	private const float LookEvery = default(float);

	private static readonly List<GillaPitKill> live;

	private Vector3 outside;

	private bool wasOutside;

	private float lookAt;

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj4 = 0;
		List<System.__Canon> list = (List<System.__Canon>)obj4;
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag2 = list._size < items.Length;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj7 = obj6 + 32;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)(object)this);
		}
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj4 = 0;
		bool flag2 = ((List<System.__Canon>)obj4).Remove((System.__Canon)(object)this);
	}

	public bool Covers(Vector3 at)
	{
		//IL_035f: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_00fe: Expected VT, but got I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0176: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_0220: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I4
		//IL_0260: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I
		//IL_02ff: Invalid comparison between Obj and F8
		//IL_0310: Expected Obj, but got I4
		//IL_0328: Invalid comparison between F8 and I4
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected I4, but got Unknown
		Transform transform = base.transform;
		bool result;
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Transform parent = transform.parent;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = parent == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				goto IL_0138;
			}
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Transform parent2 = transform2.parent;
				if ((object)parent2 != null)
				{
					Vector3 vector = parent2.InverseTransformPoint((Vector3)0);
					Bounds bounds = pits;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPitKill)+2C]");
					object obj5 = bounds - 0;
					object obj6 = default;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
					{
						goto IL_0138;
					}
					Bounds bounds2 = pits;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPitKill)+2C]");
					object obj7 = bounds2 + 0;
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
					object obj8 = !flag4;
					object obj9 = obj6 - obj7;
					bool flag5 = obj9 == null;
					object obj10 = !flag5;
					object obj11 = obj8 & obj10;
					result = false;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPitKill)+28]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPitKill)+34]");
						object obj12 = num - 0;
						object obj13 = default;
						bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
						result = false;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPitKill)+28]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPitKill)+34]");
							object obj14 = num2 + 0;
							bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
							object obj15 = !flag7;
							object obj16 = obj13 - obj14;
							bool flag8 = obj16 == null;
							object obj17 = !flag8;
							object obj18 = obj15 & obj17;
							result = false;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPitKill)+24]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPitKill)+30]");
								object obj19 = num3 - 0;
								object obj20 = default;
								bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
								result = false;
								if (!flag9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPitKill)+24]");
									nint num4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPitKill)+30]");
									object obj21 = num4 + 0;
									double num5 = (double)obj21 + 12.0;
									bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num5);
									object obj22 = !flag10;
									double num6 = (double)obj20 - num5;
									bool flag11 = num6 == 0.0;
									object obj23 = ~obj22;
									bool flag12 = (byte)((obj23 | flag11) ? 1 : 0) != 0;
									result = flag12;
								}
							}
						}
					}
					goto IL_0386;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0138:
		result = false;
		goto IL_0386;
		IL_0386:
		return result;
	}

	private unsafe bool Under(Vector3 at)
	{
		//IL_0139: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_00f3: Expected VT, but got I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected VT, but got Unknown
		//IL_010f: Expected Ref, but got VT
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Transform parent = transform.parent;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(parent != null))
			{
				return false;
			}
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Transform parent2 = transform2.parent;
				if ((object)parent2 != null)
				{
					Vector3 vector = parent2.InverseTransformPoint((Vector3)0);
					Bounds bounds = (Bounds)(this + 32);
					Vector3 point = default;
					return ((Bounds*)bounds)->Internal_Contains(ref point);
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe static bool InRoom(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I
		//IL_036d: Expected VT, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected VT, but got Obj
		//IL_00b0: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Ref
		//IL_00da: Expected Obj, but got I4
		//IL_02fd: Expected VT, but got Obj
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Ref, but got Unknown
		//IL_0320: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Ref
		//IL_00f9: Expected Obj, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_018d: Invalid comparison between VT and I4
		//IL_01e5: Invalid comparison between VT and I4
		//IL_01c6: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		object obj4 = 0;
		bool flag2 = obj4 == null;
		IntPtr intPtr = default;
		Vector3 vector = (Vector3)(nint)intPtr;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EA0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E98]");
			object obj6 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)obj4).GetEnumerator();
			vector = (Vector3)obj5;
			Enumerator<, > val = default;
			bool flag3 = val.MoveNext();
			bool flag4 = !flag3;
			object obj8 = default;
			object obj7 = obj8;
			object obj10 = default;
			object obj9 = obj10;
			object obj12 = default;
			object obj11 = obj12;
			object obj13;
			object obj14;
			Enumerator<, > val2;
			if (flag4)
			{
				obj13 = 0;
				obj14 = 0;
				val2 = (Enumerator<, >)(ref val);
				obj4 = (object)(&val);
				bool result = flag3;
				object obj15 = 0;
				object obj18 = default;
				while (true)
				{
					vector = (Vector3)obj6;
					((Enumerator<, >*)val2)->Dispose();
					bool flag5 = obj15 == null;
					object obj16 = !flag5;
					obj8 = obj7;
					obj10 = obj9;
					obj12 = obj11;
					if (obj16 == null)
					{
						bool flag6 = obj13 == null;
						object obj17 = !flag6;
						obj8 = obj7;
						obj10 = obj9;
						obj12 = obj11;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj17 == null)
						{
							return result;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if (vector == (Vector3)(object)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj13 = 1;
						obj4 = 1;
						obj15 = obj14;
					}
					else
					{
						if (vector != (Vector3)(object)1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj15 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj14 = obj18;
					}
					obj7 = obj8;
					obj9 = obj10;
					obj11 = obj12;
					result = false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D95C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result2 = default;
				return result2;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj13 = 0;
			obj14 = 0;
			val2 = (Enumerator<, >)(ref val);
			obj4 = (object)(&val);
		}
		throw new NullReferenceException();
	}

	public unsafe static bool Fallen(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I
		//IL_036d: Expected VT, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected VT, but got Obj
		//IL_00b0: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Ref
		//IL_00da: Expected Obj, but got I4
		//IL_02fd: Expected VT, but got Obj
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Ref, but got Unknown
		//IL_0320: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Ref
		//IL_00f9: Expected Obj, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_018d: Invalid comparison between VT and I4
		//IL_01e5: Invalid comparison between VT and I4
		//IL_01c6: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		object obj4 = 0;
		bool flag2 = obj4 == null;
		IntPtr intPtr = default;
		Vector3 vector = (Vector3)(nint)intPtr;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EA0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E98]");
			object obj6 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)obj4).GetEnumerator();
			vector = (Vector3)obj5;
			Enumerator<, > val = default;
			bool flag3 = val.MoveNext();
			bool flag4 = !flag3;
			object obj8 = default;
			object obj7 = obj8;
			object obj10 = default;
			object obj9 = obj10;
			object obj12 = default;
			object obj11 = obj12;
			object obj13;
			object obj14;
			Enumerator<, > val2;
			if (flag4)
			{
				obj13 = 0;
				obj14 = 0;
				val2 = (Enumerator<, >)(ref val);
				obj4 = (object)(&val);
				bool result = flag3;
				object obj15 = 0;
				object obj18 = default;
				while (true)
				{
					vector = (Vector3)obj6;
					((Enumerator<, >*)val2)->Dispose();
					bool flag5 = obj15 == null;
					object obj16 = !flag5;
					obj8 = obj7;
					obj10 = obj9;
					obj12 = obj11;
					if (obj16 == null)
					{
						bool flag6 = obj13 == null;
						object obj17 = !flag6;
						obj8 = obj7;
						obj10 = obj9;
						obj12 = obj11;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj17 == null)
						{
							return result;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if (vector == (Vector3)(object)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj13 = 1;
						obj4 = 1;
						obj15 = obj14;
					}
					else
					{
						if (vector != (Vector3)(object)1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj15 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj14 = obj18;
					}
					obj7 = obj8;
					obj9 = obj10;
					obj11 = obj12;
					result = false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D95C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result2 = default;
				return result2;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj13 = 0;
			obj14 = 0;
			val2 = (Enumerator<, >)(ref val);
			obj4 = (object)(&val);
		}
		throw new NullReferenceException();
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0397: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I
		//IL_019e: Expected VT, but got I4
		//IL_01d4: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I4
		//IL_02e4: Expected VT, but got I4
		//IL_02f7: Expected VT, but got F4
		//IL_0333: Expected Obj, but got I4
		//IL_034c: Expected VT, but got I4
		//IL_026b: Expected Obj, but got I
		//IL_027e: Expected VT, but got I4
		//IL_027e: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
		bool flag5 = (UnityEngine.Object)0 == null;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			return;
		}
		Transform transform = base.transform;
		Transform parent = transform.parent;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (parent == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
		Vector3 position = ((Transform)0).position;
		if (Covers((Vector3)0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v27+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (MonsterPlayer.IsMonster)
			{
				if (~(wasOutside ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
					Vector3 forward = ((Transform)0).forward;
					bool flag9 = GillaTeleport.To((Vector3)0, (Vector3)0);
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+A9]");
			bool flag10 = (nint)0 == 0;
			object obj17 = !flag10;
			if (obj17 == null && Under((Vector3)0))
			{
				((KillCam)obj5).DieInPit();
			}
		}
		else
		{
			float time = Time.time;
			if (!(time < lookAt))
			{
				float time2 = Time.time;
				float num = time2 + 0.25f;
				lookAt = num;
				float num2 = default;
				Vector3 vector = GillaTeleport.FloorUnder((Vector3)0, num2);
				outside = (Vector3)num2;
				wasOutside = true;
			}
		}
	}

	static GillaPitKill()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EB8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E80]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = list;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
