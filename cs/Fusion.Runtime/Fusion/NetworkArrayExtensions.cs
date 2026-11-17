using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

public static class NetworkArrayExtensions
{
	public unsafe static int IndexOf<T>(NetworkArray<T> array, T elem) where T : struct, IEquatable<T>
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_015a: Expected Obj, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got Ref
		//IL_019d: Expected Obj, but got I
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got Ref
		//IL_01c9: Expected Obj, but got Ref
		//IL_01d6: Expected Obj, but got Ref
		//IL_01f9: Invalid comparison between VT and I4
		//IL_011a: Expected I4, but got I8
		//IL_003c: Expected Obj, but got Ref
		//IL_0135: Expected Ref, but got VT
		//IL_0230: Expected Obj, but got Ref
		//IL_0277: Expected Obj, but got Ref
		//IL_0068: Expected Obj, but got Ref
		//IL_0076: Expected Obj, but got Ref
		//IL_00a7: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I
		//IL_00db: Invalid comparison between I4 and VT
		//IL_0102: Expected I4, but got I8
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v2 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)16;
		object obj4 = obj3 + 15;
		object obj5 = obj4 & 0x1FFFFFFF0L;
		object obj7 = default;
		object obj6 = (ref *(byte*)(&obj7)) - (ref *(byte*)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v2 (Il2CppClass<T>)+FC]");
		object obj8 = (nint)0 + (nint)15;
		object obj9 = obj8 & 0x1FFFFFFF0L;
		object obj10 = (ref *(byte*)(&obj7)) - (ref *(byte*)obj9);
		object obj11 = (ref *(byte*)(&obj7)) - (ref *(byte*)obj9);
		object obj12 = (ref *(byte*)(&obj7)) - (ref *(byte*)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ X1_v2 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		NetworkArray<T> networkArray = default;
		int num3;
		if (networkArray >= (object)1)
		{
			object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			num3 = 0;
			while (true)
			{
				object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ X1_v5 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				nint num5 = 0;
				object obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65B94");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-28]");
				nint num6 = 0;
				object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
				object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ X1_v3 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C]");
				bool flag = (nint)0 == 0;
				object obj18 = !flag;
				if (obj18 != null)
				{
					break;
				}
				num3++;
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ X1_v11 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) >= System.Runtime.CompilerServices.Unsafe.As<NetworkArray<T>, UIntPtr>(ref networkArray))
				{
					num6 = 0;
					num3 = -1;
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
			object obj19 = 0;
		}
		else
		{
			nint num6 = 0;
			num3 = -1;
			object obj20 = default;
			object obj19 = obj20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X28_v2+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		if (num8 == 0)
		{
			return num3;
		}
		return ((NetworkArray<T>*)networkArray)->Length;
	}

	public static ref T GetRef<T>(NetworkArray<T> array, int index) where T : struct
	{
		//IL_0022: Expected Obj, but got I
		nint num = 0;
		object obj = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v41 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
