using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Photon.Client.StructWrapping;

public static class StructWrapperUtility
{
	public static Type GetWrappedType(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
			object obj2 = 0;
			nint num = (nint)obj;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X9_v1 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v5+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X9_v1 (Il2CppClass<System.Object>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v5+130]");
				object obj6 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v4-8]");
				if (0 == (nint)obj3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+18]");
					return (Type)0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			Type result = default;
			return result;
		}
		return (Type)(object)new NullReferenceException();
	}

	public unsafe static StructWrapper<T> Wrap<T>(T value, bool persistant)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_01a0: Expected Obj, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got Ref
		//IL_01e1: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_0306: Expected VT, but got Ref
		//IL_031f: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I8
		//IL_00a3: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got Ref
		//IL_024e: Expected Obj, but got Ref
		//IL_026d: Expected Obj, but got I
		//IL_0282: Expected VT, but got I
		//IL_00e3: Expected VT, but got I
		//IL_0132: Expected Obj, but got I
		//IL_00f9: Expected I, but got Obj
		//IL_0109: Expected VT, but got I
		//IL_011c: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I4
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v2 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj6 = default;
		object obj5 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1<T>>)+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		nint num3 = 0;
		nint num4 = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num3 = 0;
			num4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1<T>>)+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3 (Il2CppClass<T>)+28]");
		bool flag2 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3 (Il2CppClass<T>)+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3 (Il2CppClass<T>)+28]");
		object obj9 = num5 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3 (Il2CppClass<T>)+28]");
		object obj10 = 0 & obj9;
		bool flag3 = (nint)obj10 < 0;
		T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
		bool flag4 = flag2 == flag3;
		object obj11 = !flag4;
		object obj12 = ~obj11;
		T val2;
		if (obj12 == null)
		{
			val2 = value;
		}
		else
		{
			val2 = val;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		bool flag5 = obj8 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v2 (Il2CppClass<T>)+FC]");
		object obj13 = 0;
		if (flag5)
		{
			goto IL_0132;
		}
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v9 (Il2CppClass<T>)+28]");
		object obj14 = 0 & 0x80000000L;
		bool flag6 = obj14 == null;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			obj5 = obj5;
		}
		object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ X1_v4 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-10]");
		StructWrapper<T> structWrapper = (StructWrapper<T>)0;
		bool flag7 = !persistant;
		val2 = (T)0;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-10]");
			bool flag8 = (nint)0 == 0;
			obj13 = obj8;
			val2 = (T)0;
			if (flag8)
			{
				goto IL_0132;
			}
			nint num8 = (nint)structWrapper;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v14 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1<T>>)+1A0]");
			val2 = (T)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-10]");
			NullReferenceException ex = (NullReferenceException)((Enum)0).CompareTo(0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		bool flag9 = num9 != 0;
		obj13 = obj8;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-10]");
			return (StructWrapper<T>)0;
		}
		goto IL_016f;
		IL_016f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		StructWrapper<T> result = default;
		return result;
		IL_0132:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		if (num10 == 0)
		{
			NullReferenceException ex = new NullReferenceException();
		}
		goto IL_016f;
	}

	public static StructWrapper<T> Wrap<T>(T value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X0 (T)+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X0 (T)+38]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X0 (T)+38]");
			obj = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+10]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X0 (T)+38]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+10]");
			obj3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v3+A0]");
		object obj5 = 0;
		double value2 = default;
		if (obj5 != null)
		{
			return (StructWrapper<T>)(object)((StructWrapperPool<double>)obj5).Acquire(value2);
		}
		return (StructWrapper<T>)(object)new NullReferenceException();
	}

	public static StructWrapper<byte> Wrap(byte value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516460]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)(int)value;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			object obj7 = -(int)value;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				object obj10 = obj4 + value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+20]");
				return (StructWrapper<byte>)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (StructWrapper<byte>)(object)new IndexOutOfRangeException();
	}

	public static StructWrapper<bool> Wrap(bool value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516460]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			bool flag2 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			bool flag3 = (nint)(flag2 ? 1 : 0) < (nint)0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
				object obj7 = (nint)0 + (nint)(value ? 1 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6+20]");
				return (StructWrapper<bool>)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (StructWrapper<bool>)(object)new IndexOutOfRangeException();
	}

	public static bool IsType<T>(object obj)
	{
		//IL_0154: Expected Obj, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_017c: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_00b5: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj5 = default;
		if (obj5 != null)
		{
			return true;
		}
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		nint num2 = 0;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		if (obj != null)
		{
			nint num3 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v10 (Il2CppClass<System.Object>)+130]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v7 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1<T>>)+130]");
			bool flag3 = num4 < 0;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v10 (Il2CppClass<System.Object>)+B0]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v7 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1<T>>)+130]");
				object obj10 = num5 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12-8]");
				object obj11 = -num2;
				return obj11 == null;
			}
		}
		return false;
	}

	public unsafe static T DisconnectPooling<T>(T table)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_0a67: Expected Obj, but got I
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Expected Obj, but got Unknown
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected Obj, but got Unknown
		//IL_0a94: Expected Obj, but got Ref
		//IL_0aa8: Expected Obj, but got Ref
		//IL_0ad2: Expected Obj, but got I4
		//IL_0b1d: Expected Obj, but got I
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected Obj, but got Unknown
		//IL_0b4f: Expected VT, but got Ref
		//IL_0b73: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_0b9b: Expected Obj, but got I
		//IL_0bb3: Expected Obj, but got Ref
		//IL_0bd2: Invalid comparison between VT and I4
		//IL_0be0: Expected Obj, but got Ref
		//IL_00b4: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_012c: Expected Obj, but got Ref
		//IL_0f48: Expected I, but got VT
		//IL_0f58: Expected Obj, but got I
		//IL_023c: Expected VT, but got Obj
		//IL_0cae: Expected Obj, but got I
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I
		//IL_0656: Expected Obj, but got I4
		//IL_0c10: Expected Obj, but got I4
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Expected Obj, but got Unknown
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected Obj, but got Unknown
		//IL_0c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Expected Obj, but got Unknown
		//IL_0f1b: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0e32: Expected VT, but got I
		//IL_0e54: Expected Obj, but got I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_0673: Expected Obj, but got I
		//IL_0683: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_0765: Expected Obj, but got I4
		//IL_0716: Expected VT, but got Obj
		//IL_0904: Expected VT, but got Obj
		//IL_03e6: Expected VT, but got Obj
		//IL_0949: Expected VT, but got Obj
		//IL_0e96: Expected Obj, but got I
		//IL_06be: Expected Obj, but got I
		//IL_0dab: Expected Obj, but got I
		//IL_0dbe: Invalid comparison between VT and I4
		//IL_0301: Expected Obj, but got I
		//IL_0de2: Expected VT, but got I
		//IL_0e04: Expected Obj, but got I4
		//IL_0d0d: Expected Obj, but got I4
		//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Expected Obj, but got Unknown
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5c: Expected Obj, but got Unknown
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected Obj, but got Unknown
		//IL_07c8: Expected Obj, but got I
		//IL_0804: Expected Obj, but got I
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected Obj, but got Unknown
		//IL_0836: Expected Obj, but got Ref
		//IL_084f: Expected Obj, but got I4
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected Obj, but got Unknown
		//IL_042b: Expected I, but got VT
		//IL_043c: Expected Obj, but got I
		//IL_0465: Expected Obj, but got I4
		//IL_0482: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_04f7: Expected I4, but got Obj
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_07aa: Expected Obj, but got I4
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Expected Obj, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0336: Expected Obj, but got I4
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_0ebf: Expected VT, but got I
		//IL_0876: Expected Obj, but got I
		//IL_0523: Expected Obj, but got I
		//IL_0533: Expected Obj, but got I
		//IL_0554: Expected Obj, but got I4
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_0ed2: Expected Obj, but got Ref
		//IL_0604: Expected Obj, but got I
		//IL_0a17: Expected Obj, but got I4
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X2+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X2+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X2+38]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X2+38]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X2+38]");
				obj3 = 0;
			}
		}
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v1+FC]");
		object obj7 = (nint)0 + (nint)16;
		object obj8 = obj7 + 15;
		object obj9 = obj8 & 0x1FFFFFFF0L;
		object obj11 = default;
		object obj10 = (ref *(byte*)(&obj11)) - (ref *(byte*)obj9);
		_ = 0;
		object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
		object obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+28]");
		bool flag3 = (nint)0 < (nint)0;
		object obj14 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+28]");
		bool flag4 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+28]");
		bool flag5 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+28]");
		object obj15 = num ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+28]");
		object obj16 = 0 & obj15;
		bool flag6 = (nint)obj16 < 0;
		T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
		bool flag7 = flag4 == flag6;
		bool flag8 = !flag7;
		object obj17 = !flag8;
		T val2 = ((obj17 != null) ? val : table);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65B94");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-30]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v93 @ X0_v3 (should have been resolved before IL gen)");
		object obj19 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		_ = 0;
		_ = 0;
		T val3 = default;
		bool flag9 = val3 == (T)(object)0;
		object obj20 = (object)(&obj11);
		if (flag9)
		{
			goto IL_0613;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8618]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+28]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+28]");
		object obj25 = 0;
		object obj26 = (object)(&obj11);
		T val4 = val2;
		T val5 = val3;
		while (true)
		{
			nint num2 = (nint)val5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v35 (Il2CppClass<T>)+12E]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v35 (Il2CppClass<T>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_022d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v35 (Il2CppClass<T>)+98]");
			object obj28 = (nint)0 + (nint)8;
			bool flag10 = flag8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X10_v32-8]");
				bool flag11 = 0 < (nint)obj21;
				obj14 = !flag11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X10_v32-8]");
				obj25 = 0 - obj21;
				flag4 = (nint)obj25 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X10_v32-8]");
				flag5 = 0 == (nint)obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X10_v32-8]");
				obj24 = 0 ^ obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X10_v32-8]");
				obj15 = 0 ^ obj25;
				obj16 = obj24 & obj15;
				flag6 = (nint)obj16 < 0;
				if (flag5)
				{
					break;
				}
				obj27--;
				bool flag12 = (nint)obj27 < 1;
				obj14 = !flag12;
				obj25 = obj27 - 1;
				flag4 = (nint)obj25 < 0;
				flag5 = obj25 == null;
				obj24 = obj27 ^ 1;
				obj15 = obj27 ^ obj25;
				obj16 = obj24 & obj15;
				flag6 = (nint)obj16 < 0;
				obj26 = obj28 + 16;
				flag8 = (nint)obj27 != 1;
				flag10 = flag8;
				obj28 = obj26;
				if (flag8)
				{
					continue;
				}
				goto IL_022d;
			}
			object obj29 = num2 + obj28;
			object obj30 = obj29 + 312;
			flag8 = flag10;
			obj26 = obj28;
			val2 = val4;
			goto IL_0c9e;
			IL_0c9e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v40+8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v427 @ X0_v40] (should have been resolved before IL gen)");
			object obj31 = val3 & 1;
			bool flag13 = obj31 == null;
			obj20 = obj26;
			if (flag13)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-18]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-18]");
			if ((nint)0 == 0)
			{
				goto IL_08bc;
			}
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v39+12E]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v39+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03d7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v39+98]");
			object obj35 = (nint)0 + (nint)8;
			bool flag14 = flag8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X10_v27-8]");
				bool flag15 = 0 < (nint)obj22;
				obj14 = !flag15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X10_v27-8]");
				obj25 = 0 - obj22;
				flag4 = (nint)obj25 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X10_v27-8]");
				flag5 = 0 == (nint)obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X10_v27-8]");
				obj24 = 0 ^ obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X10_v27-8]");
				obj15 = 0 ^ obj25;
				obj16 = obj24 & obj15;
				flag6 = (nint)obj16 < 0;
				if (flag5)
				{
					break;
				}
				obj34--;
				bool flag16 = (nint)obj34 < 1;
				obj14 = !flag16;
				obj25 = obj34 - 1;
				flag4 = (nint)obj25 < 0;
				flag5 = obj25 == null;
				obj24 = obj34 ^ 1;
				obj15 = obj34 ^ obj25;
				obj16 = obj24 & obj15;
				flag6 = (nint)obj16 < 0;
				obj26 = obj35 + 16;
				flag8 = (nint)obj34 != 1;
				flag14 = flag8;
				obj35 = obj26;
				if (flag8)
				{
					continue;
				}
				goto IL_03d7;
			}
			object obj36 = obj33 + obj35;
			object obj37 = obj36 + 312;
			flag8 = flag14;
			obj26 = obj35;
			goto IL_0d9b;
			IL_0d9b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v44+8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v715 @ X0_v44] (should have been resolved before IL gen)");
			if (val3 != (T)(object)0)
			{
				object obj38 = obj23;
				nint num3 = (nint)val3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X9_v33+130]");
				obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v43 (Il2CppClass<T>)+130]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X9_v33+130]");
				bool flag17 = num4 < 0;
				obj14 = !flag17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v43 (Il2CppClass<T>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X9_v33+130]");
				obj25 = num5 - 0;
				flag4 = (nint)obj25 < 0;
				flag5 = obj25 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v43 (Il2CppClass<T>)+130]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X9_v33+130]");
				obj24 = num6 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v43 (Il2CppClass<T>)+130]");
				obj15 = 0 ^ obj25;
				obj16 = obj24 & obj15;
				flag6 = (nint)obj16 < 0;
				flag8 = (byte)(int)(~obj14) != 0;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v43 (Il2CppClass<T>)+B0]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X9_v33+130]");
					object obj39 = num7 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X10_v22-8]");
					obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X10_v22-8]");
					bool flag18 = 0 < (nint)obj38;
					obj14 = !flag18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X10_v22-8]");
					obj25 = 0 - obj38;
					flag4 = (nint)obj25 < 0;
					flag5 = obj25 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X10_v22-8]");
					obj24 = 0 ^ obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X10_v22-8]");
					obj15 = 0 ^ obj25;
					obj16 = obj24 & obj15;
					flag6 = (nint)obj16 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X10_v22-8]");
					flag8 = 0 != (nint)obj38;
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v43 (Il2CppClass<T>)+1A0]");
						obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v738 @ X8_v43 (Il2CppClass<T>)+198] (should have been resolved before IL gen)");
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-18]");
			val5 = (T)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-18]");
			bool flag19 = (nint)0 == 0;
			object obj40 = !flag19;
			obj20 = obj26;
			val4 = val2;
			if (obj40 != null)
			{
				continue;
			}
			goto IL_0613;
			IL_03d7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			val2 = (T)null;
			goto IL_0d9b;
			IL_022d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			val2 = (T)null;
			goto IL_0c9e;
		}
		object obj41 = 5;
		goto IL_0f0b;
		IL_0613:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		if (num8 == 0)
		{
			throw new NullReferenceException();
		}
		goto IL_0a2b;
		IL_0888:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		if (num9 == 0)
		{
			return val3;
		}
		goto IL_0a2b;
		IL_0e22:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-28]");
		val3 = (T)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-28]");
		bool flag20 = (nint)0 == 0;
		object obj42 = !flag20;
		if (obj42 != null)
		{
			goto IL_0909;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-20]");
		bool flag21 = (nint)0 == 0;
		object obj43 = !flag21;
		if (obj43 == null)
		{
			if ((nint)obj41 != 5)
			{
				bool flag22 = obj41 == null;
				object obj44 = !flag22;
				if (obj44 != null)
				{
					goto IL_0888;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X2+38]");
			object obj45 = 0;
			object obj46 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v15+28]");
			bool flag23 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v15+28]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v15+28]");
			object obj47 = num10 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v15+28]");
			object obj48 = 0 & obj47;
			bool flag24 = (nint)obj48 < 0;
			object obj49 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
			bool flag25 = flag23 == flag24;
			object obj50 = !flag25;
			object obj51 = ~obj50;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-10]");
				obj18 = 0;
			}
			else
			{
				obj18 = obj49;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v1+FC]");
			val2 = (T)0;
			goto IL_0888;
		}
		goto IL_094e;
		IL_0a2b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		T result = default;
		return result;
		IL_0909:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		if (num11 == 0)
		{
			OutOfMemoryException ex = new OutOfMemoryException();
			val3 = (T)ex;
			goto IL_094e;
		}
		goto IL_0a2b;
		IL_0e86:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X0_v12+8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v636 @ X0_v12] (should have been resolved before IL gen)");
		goto IL_0e22;
		IL_08bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		if (num12 == 0)
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj20 = obj26;
			val3 = (T)ex2;
			goto IL_0909;
		}
		goto IL_0a2b;
		IL_094e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		if (num13 != 0)
		{
			goto IL_0a2b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)obj18 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		else
		{
			if ((nint)obj18 != 1)
			{
				object obj52 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
				if (num14 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
				goto IL_0a2b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		obj41 = 0;
		goto IL_0f0b;
		IL_0707:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		val2 = (T)null;
		goto IL_0e86;
		IL_0f0b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-30]");
		object obj53 = 0;
		object obj54 = obj53;
		if (obj53 == null)
		{
			goto IL_0e22;
		}
		object obj55 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v18+12E]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v18+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0707;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v18+98]");
		object obj57 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X10_v10-8]");
			if (0 == (nint)obj20)
			{
				break;
			}
			obj56--;
			obj20 = obj57 + 16;
			bool flag26 = (nint)obj56 != 1;
			obj57 = obj20;
			if (flag26)
			{
				continue;
			}
			goto IL_0707;
		}
		object obj58 = obj55 + obj57;
		object obj59 = obj58 + 312;
		obj20 = obj57;
		goto IL_0e86;
	}

	public unsafe static List<object> ReleaseAllWrappers(List<object> collection)
	{
		//IL_0018: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Ref
		//IL_0116: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got I4
		//IL_0285: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got Ref
		//IL_01ea: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65172D0]");
		object obj2 = 0;
		Enumerator<, > enumerator = ((List<System.__Canon>)(object)collection).GetEnumerator();
		object obj4 = default;
		object obj3 = obj4;
		Enumerator<, > val = default;
		object obj5 = (object)(&val);
		while (val.MoveNext())
		{
			object obj6 = 0;
		}
		object obj7 = 0;
		object obj8 = 0;
		Enumerator<, > val2 = (Enumerator<, >)(ref val);
		object obj9 = 0;
		object obj12 = default;
		object obj13 = default;
		IntPtr intPtr = default;
		object obj14 = default;
		object obj15 = default;
		List<object> result = default;
		while (true)
		{
			nint num = (nint)obj2;
			val.Dispose();
			bool flag = obj9 == null;
			object obj10 = !flag;
			if (obj10 == null)
			{
				bool flag2 = obj7 == null;
				object obj11 = !flag2;
				OutOfMemoryException ex = (OutOfMemoryException)(&val);
				if (obj11 == null)
				{
					break;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj7 = obj12;
				obj8 = obj13;
				num = intPtr;
				obj2 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			switch ((long)num)
			{
			case 2L:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj7 = 1;
				obj5 = 1;
				obj9 = obj8;
				break;
			case 1L:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj9 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj8 = obj15;
				break;
			default:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEBADC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
			}
		}
		return collection;
	}

	public static object[] ReleaseAllWrappers(object[] collection)
	{
		//IL_0038: Expected Obj, but got I8
		//IL_0048: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		if (collection != null)
		{
			if (collection.Length < 1)
			{
				goto IL_014e;
			}
			object obj = collection.Length & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
			object obj2 = 0;
			object obj3 = collection + 32;
			object obj4 = 0;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				object obj5 = !flag;
				if (obj5 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v4+v100 @ X20_v6*8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v4+v100 @ X20_v6*8]");
				if ((nint)0 != 0)
				{
					object obj7 = obj2;
					object obj8 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v10+130]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X9_v4+130]");
					bool flag2 = num < 0;
					object obj9 = !flag2;
					object obj10 = ~obj9;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v10+B0]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X9_v4+130]");
						object obj11 = num2 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v6-8]");
						if (0 == (nint)obj7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v10+1A8]");
							obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ X8_v10+1A8] (should have been resolved before IL gen)");
						}
					}
				}
				obj = collection.Length;
				obj4++;
				if ((nint)obj4 < collection.Length)
				{
					continue;
				}
				goto IL_014e;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (object[])(object)new NullReferenceException();
		IL_014e:
		return collection;
	}

	public unsafe static PhotonHashtable ReleaseAllWrappers(PhotonHashtable table)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002d: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_008e: Expected Obj, but got Ref
		//IL_015f: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_0170: Expected VT, but got Ref
		//IL_017a: Expected Obj, but got I4
		//IL_02d6: Expected I, but got Obj
		//IL_02f9: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got Ref
		//IL_021e: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68D565E]");
		object obj = 0;
		if (table != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65172F0]");
			obj = 0;
			nint num = (nint)obj;
			ValueCollection<> values = ((Dictionary<System.__Canon, System.__Canon>)(object)table).Values;
			if (values != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65172F8]");
				object obj3 = 0;
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)values.GetEnumerator();
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator2 = default;
				obj = (object)(&enumerator2);
				while (enumerator2.MoveNext())
				{
					object obj4 = 0;
				}
				object obj5 = 0;
				object obj6 = 0;
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator2);
				object obj7 = 0;
				object obj10 = default;
				PhotonHashtable result = default;
				while (true)
				{
					num = (nint)obj3;
					enumerator2.Dispose();
					bool flag = obj7 == null;
					object obj8 = !flag;
					if (obj8 == null)
					{
						bool flag2 = obj5 == null;
						object obj9 = !flag2;
						OutOfMemoryException ex = (OutOfMemoryException)(&enumerator2);
						if (obj9 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj5 = 1;
						obj = 1;
						obj7 = obj6;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj7 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj6 = obj10;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEBB18");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result;
					}
				}
				return table;
			}
		}
		throw new NullReferenceException();
	}

	public unsafe static void BoxAll(PhotonHashtable table, bool recursive = default(bool))
	{
		//IL_028a: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_0231: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I4
		//IL_0242: Expected VT, but got Ref
		//IL_024b: Expected Obj, but got I4
		//IL_03b0: Expected I4, but got Obj
		//IL_03d3: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68D565F]");
		nint num = 0;
		bool flag = table == null;
		bool flag2 = recursive;
		object obj3;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65172F0]");
			num = 0;
			flag2 = (byte)num != 0;
			ValueCollection<> values = ((Dictionary<System.__Canon, System.__Canon>)(object)table).Values;
			if (values != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65172F8]");
				obj3 = 0;
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)values.GetEnumerator();
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator2 = default;
				num = (nint)(&enumerator2);
				while (enumerator2.MoveNext())
				{
					PhotonHashtable photonHashtable = null;
					if (!recursive)
					{
					}
				}
				nint num2 = unchecked((nint)null);
				object obj4 = 0;
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator2);
				object obj5 = 0;
				object obj8 = default;
				while (true)
				{
					flag2 = (byte)(int)obj3 != 0;
					enumerator2.Dispose();
					bool flag3 = obj5 == null;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						bool flag4 = num2 == 0;
						object obj7 = !flag4;
						OutOfMemoryException ex = (OutOfMemoryException)(&enumerator2);
						if (obj7 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch (flag2)
					{
					case true:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num2 = 1;
						num = 1;
						obj5 = obj4;
						break;
					case true:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj5 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj4 = obj8;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEBB18");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
				}
				return;
			}
		}
		obj3 = 109924352;
		throw new NullReferenceException();
	}

	public static T Unwrap<T>(object obj)
	{
		//IL_01dc: Expected Obj, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_0204: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I4
		//IL_0130: Expected I, but got Obj
		//IL_0048: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I4
		//IL_01d0: Expected VT, but got Obj
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		//IL_021d: Expected VT, but got Obj
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0196: Expected Obj, but got I
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj8;
		if (obj != null)
		{
			nint num2 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v13 (Il2CppClass<System.Object>)+130]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v3 (Il2CppClass<Il2CppMethodRgctx<Photon.Client.StructWrapping.StructWrapperUtility::Unwrap>>)+130]");
			bool flag2 = num3 < 0;
			object obj5 = !flag2;
			object obj6 = ~obj5;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v13 (Il2CppClass<System.Object>)+B0]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v3 (Il2CppClass<Il2CppMethodRgctx<Photon.Client.StructWrapping.StructWrapperUtility::Unwrap>>)+130]");
				object obj7 = num4 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X9_v6-8]");
				if (0 == num)
				{
					obj8 = obj + 44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X0 (System.Object)+28]");
					object obj9 = (nint)0 & (nint)2;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ X8_v13 (Il2CppClass<System.Object>)+1A8] (should have been resolved before IL gen)");
					}
					goto IL_0218;
				}
			}
		}
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		nint num5 = 0;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num5 = intPtr;
		}
		nint num6 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v11 (Il2CppClass<System.Object>)+40]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X1_v3 (Il2CppClass<T>)+40]");
		if (num7 == 0)
		{
			obj8 = obj + 16;
			goto IL_0218;
		}
		InvalidCastException ex = new InvalidCastException();
		return (T)ex;
		IL_0218:
		return (T)obj8;
	}

	public static T Get<T>(object obj)
	{
		//IL_019f: Expected Obj, but got I
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I4
		//IL_0130: Expected I, but got Obj
		//IL_0048: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I4
		//IL_0193: Expected VT, but got Obj
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		//IL_01e0: Expected VT, but got Obj
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj8;
		if (obj != null)
		{
			nint num2 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v14 (Il2CppClass<System.Object>)+130]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v3 (Il2CppClass<Il2CppMethodRgctx<Photon.Client.StructWrapping.StructWrapperUtility::Get>>)+130]");
			bool flag2 = num3 < 0;
			object obj5 = !flag2;
			object obj6 = ~obj5;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v14 (Il2CppClass<System.Object>)+B0]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v3 (Il2CppClass<Il2CppMethodRgctx<Photon.Client.StructWrapping.StructWrapperUtility::Get>>)+130]");
				object obj7 = num4 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v16-8]");
				if (0 == num)
				{
					obj8 = obj + 44;
					goto IL_01db;
				}
			}
		}
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		nint num5 = 0;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num5 = intPtr;
		}
		nint num6 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v11 (Il2CppClass<System.Object>)+40]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X1_v3 (Il2CppClass<T>)+40]");
		if (num7 == 0)
		{
			obj8 = obj + 16;
			goto IL_01db;
		}
		InvalidCastException ex = new InvalidCastException();
		return (T)ex;
		IL_01db:
		return (T)obj8;
	}

	public unsafe static T Unwrap<T>(PhotonHashtable table, object key)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got Ref
		//IL_0077: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got Ref
		//IL_00ff: Expected Obj, but got VT
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
			obj3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+FC]");
		object obj6 = (nint)0 + (nint)15;
		object obj7 = obj6 & 0x1FFFFFFF0L;
		object obj9 = default;
		object obj8 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj7);
		if (table != null)
		{
			object key2 = default;
			object obj10 = table.get_Item(key2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
			object obj11 = 0;
			object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			object obj13 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ X1_v3+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag2 = num != 0;
			T val = default;
			NullReferenceException ex = (NullReferenceException)val;
			if (!flag2)
			{
				return val;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag3 = num2 != 0;
			NullReferenceException ex = (NullReferenceException)(object)table;
			if (!flag3)
			{
				ex = new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T result = default;
		return result;
	}

	public unsafe static bool TryUnwrapValue<T>(PhotonHashtable table, byte key, out T value) where T : new()
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_01ac: Expected Obj, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01e9: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj5 = default;
		ref T reference = ref *(T*)((ref *(byte*)(&obj5)) - (ref *(byte*)obj4));
		ref T reference2 = ref System.Runtime.CompilerServices.Unsafe.As<object, T>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj6 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		System.__Canon _Canon = default;
		if (table != null)
		{
			ref System.__Canon value2 = ref System.Runtime.CompilerServices.Unsafe.As<object, System.__Canon>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8628]");
			object obj7 = 0;
			nint num2 = (nint)obj7;
			bool flag = ((Dictionary<System.__Canon, System.__Canon>)(object)table).TryGetValue(_Canon, out value2);
			if (flag)
			{
				num2 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ X1_v6 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
				ref T reference3 = ref reference;
				ref T reference4 = default;
				reference2 = ref reference4;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (Il2CppClass<T>)+FC]");
				ref T reference3 = ref *(T*)null;
				reference2 = ref *(T*)null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			if (num4 == 0)
			{
				return flag;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag2 = num5 != 0;
			NullReferenceException ex = (NullReferenceException)(object)_Canon;
			if (!flag2)
			{
				ex = new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
	}

	public unsafe static bool TryGetValue<T>(PhotonHashtable table, byte key, out T value) where T : new()
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_01ac: Expected Obj, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01e9: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj5 = default;
		ref T reference = ref *(T*)((ref *(byte*)(&obj5)) - (ref *(byte*)obj4));
		ref T reference2 = ref System.Runtime.CompilerServices.Unsafe.As<object, T>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj6 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		System.__Canon _Canon = default;
		if (table != null)
		{
			ref System.__Canon value2 = ref System.Runtime.CompilerServices.Unsafe.As<object, System.__Canon>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8628]");
			object obj7 = 0;
			nint num2 = (nint)obj7;
			bool flag = ((Dictionary<System.__Canon, System.__Canon>)(object)table).TryGetValue(_Canon, out value2);
			if (flag)
			{
				num2 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ X1_v6 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
				ref T reference3 = ref reference;
				ref T reference4 = default;
				reference2 = ref reference4;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (Il2CppClass<T>)+FC]");
				ref T reference3 = ref *(T*)null;
				reference2 = ref *(T*)null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			if (num4 == 0)
			{
				return flag;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag2 = num5 != 0;
			NullReferenceException ex = (NullReferenceException)(object)_Canon;
			if (!flag2)
			{
				ex = new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
	}

	public unsafe static bool TryGetValue<T>(PhotonHashtable table, object key, out T value) where T : new()
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_01c4: Expected Obj, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I
		//IL_006c: Expected I, but got Obj
		//IL_00ef: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj5 = default;
		ref T reference = ref *(T*)((ref *(byte*)(&obj5)) - (ref *(byte*)obj4));
		_ = 0;
		if (table != null)
		{
			ref System.__Canon value2 = ref System.Runtime.CompilerServices.Unsafe.As<object, System.__Canon>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8628]");
			object obj6 = 0;
			nint num2 = (nint)obj6;
			object key2 = default;
			bool flag = ((Dictionary<System.__Canon, System.__Canon>)(object)table).TryGetValue((System.__Canon)key2, out value2);
			if (flag)
			{
				num2 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ X1_v5 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
				ref T reference2 = default;
				key2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
				reference2 = ref reference;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				key2 = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (Il2CppClass<T>)+FC]");
				ref T reference2 = ref *(T*)null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			if (num4 == 0)
			{
				return flag;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag2 = num5 != 0;
			NullReferenceException ex = (NullReferenceException)(object)table;
			if (!flag2)
			{
				ex = new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
	}

	public unsafe static bool TryUnwrapValue<T>(PhotonHashtable table, object key, out T value) where T : new()
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_01c4: Expected Obj, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I
		//IL_006c: Expected I, but got Obj
		//IL_00ef: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj5 = default;
		ref T reference = ref *(T*)((ref *(byte*)(&obj5)) - (ref *(byte*)obj4));
		_ = 0;
		if (table != null)
		{
			ref System.__Canon value2 = ref System.Runtime.CompilerServices.Unsafe.As<object, System.__Canon>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8628]");
			object obj6 = 0;
			nint num2 = (nint)obj6;
			object key2 = default;
			bool flag = ((Dictionary<System.__Canon, System.__Canon>)(object)table).TryGetValue((System.__Canon)key2, out value2);
			if (flag)
			{
				num2 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ X1_v5 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
				ref T reference2 = default;
				key2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
				reference2 = ref reference;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				key2 = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (Il2CppClass<T>)+FC]");
				ref T reference2 = ref *(T*)null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			if (num4 == 0)
			{
				return flag;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag2 = num5 != 0;
			NullReferenceException ex = (NullReferenceException)(object)table;
			if (!flag2)
			{
				ex = new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
	}

	public unsafe static T Unwrap<T>(PhotonHashtable table, byte key)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got Ref
		//IL_00ff: Expected Obj, but got VT
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
			obj3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+FC]");
		object obj6 = (nint)0 + (nint)15;
		object obj7 = obj6 & 0x1FFFFFFF0L;
		object obj8 = default;
		byte b = (byte)((ref *(byte*)(&obj8)) - (ref *(byte*)obj7));
		if (table != null)
		{
			byte key2 = default;
			object obj9 = table.get_Item(key2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
			object obj10 = 0;
			object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ X1_v3+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag2 = num != 0;
			T val = default;
			NullReferenceException ex = (NullReferenceException)val;
			if (!flag2)
			{
				return val;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag3 = num2 != 0;
			NullReferenceException ex = (NullReferenceException)(object)table;
			if (!flag3)
			{
				ex = new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T result = default;
		return result;
	}

	public unsafe static T Get<T>(PhotonHashtable table, byte key)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got Ref
		//IL_00ff: Expected Obj, but got VT
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
			obj3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+FC]");
		object obj6 = (nint)0 + (nint)15;
		object obj7 = obj6 & 0x1FFFFFFF0L;
		object obj8 = default;
		byte b = (byte)((ref *(byte*)(&obj8)) - (ref *(byte*)obj7));
		if (table != null)
		{
			byte key2 = default;
			object obj9 = table.get_Item(key2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X3_v1+38]");
			object obj10 = 0;
			object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ X1_v3+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag2 = num != 0;
			T val = default;
			NullReferenceException ex = (NullReferenceException)val;
			if (!flag2)
			{
				return val;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag3 = num2 != 0;
			NullReferenceException ex = (NullReferenceException)(object)table;
			if (!flag3)
			{
				ex = new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T result = default;
		return result;
	}
}
