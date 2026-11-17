using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine.InputSystem;

namespace Fusion.Internal;

[Serializable]
public abstract class UnityValueSurrogate<T, TReaderWriter> : UnitySurrogateBase, _0021_00210, Action<InputActionRebindingExtensions.RebindingOperation> where TReaderWriter : struct, IElementReaderWriter<T>
{
	public abstract T DataProperty { get; set; }

	public unsafe override void Read(int* data, int capacity)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_002b: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got Ref
		//IL_0086: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got Ref
		//IL_00d1: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got Ref
		//IL_0117: Expected Obj, but got Ref
		//IL_0131: Expected Obj, but got I
		//IL_013f: Expected Obj, but got Ref
		//IL_0152: Expected Obj, but got Ref
		//IL_0182: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I8
		//IL_01c6: Expected Obj, but got I4
		//IL_01f2: Expected I, but got Obj
		//IL_0205: Expected Obj, but got Ref
		//IL_0215: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v2 (Il2CppClass<Fusion.Internal.UnityValueSurrogate`2>)+A8]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X23_v1+FC]");
		object obj5 = (nint)0 + (nint)16;
		object obj6 = obj5 + 15;
		object obj7 = obj6 & 0x1FFFFFFF0L;
		object obj9 = default;
		object obj8 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X28_v1+18]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+FC]");
		object obj11 = (nint)0 + (nint)15;
		object obj12 = obj11 & 0x1FFFFFFF0L;
		object obj13 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X23_v1+FC]");
		object obj14 = (nint)0 + (nint)15;
		object obj15 = obj14 & 0x1FFFFFFF0L;
		object obj16 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65B94");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
		object obj18 = 0;
		object obj19 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ X1_v4+10] (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v12 (Il2CppClass<Fusion.Internal.UnityValueSurrogate`2>)+A8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v13+18]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v14+28]");
		object obj23 = 0 & 0x80000000L;
		bool flag = obj23 == null;
		object obj24 = !flag;
		if (obj24 == null)
		{
			obj13 = obj13;
		}
		nint num3 = (nint)this;
		object obj25 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v16 (Il2CppClass<Fusion.Internal.UnityValueSurrogate`2<T, TReaderWriter>>)+200]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v106 @ X1_v5+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		if (num4 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	public unsafe override void Write(int* data, int capacity)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_002b: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got Ref
		//IL_0086: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got Ref
		//IL_00d1: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got Ref
		//IL_010e: Expected I, but got Obj
		//IL_0121: Expected Obj, but got Ref
		//IL_0131: Expected Obj, but got I
		//IL_014f: Expected Obj, but got Ref
		//IL_015f: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I8
		//IL_01d3: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got Ref
		//IL_021b: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.Internal.UnityValueSurrogate`2>)+A8]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v1+FC]");
		object obj5 = (nint)0 + (nint)16;
		object obj6 = obj5 + 15;
		object obj7 = obj6 & 0x1FFFFFFF0L;
		object obj9 = default;
		object obj8 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v3+18]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+FC]");
		object obj11 = (nint)0 + (nint)15;
		object obj12 = obj11 & 0x1FFFFFFF0L;
		object obj13 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v1+FC]");
		object obj14 = (nint)0 + (nint)15;
		object obj15 = obj14 & 0x1FFFFFFF0L;
		object obj16 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		nint num2 = (nint)this;
		object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v9 (Il2CppClass<Fusion.Internal.UnityValueSurrogate`2<T, TReaderWriter>>)+1F0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ X1_v3+10] (should have been resolved before IL gen)");
		nint num3 = 0;
		object obj19 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v11 (Il2CppClass<Fusion.Internal.UnityValueSurrogate`2>)+A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65B94");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-38]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v13 (Il2CppClass<Fusion.Internal.UnityValueSurrogate`2>)+A8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v14+18]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v15+28]");
		object obj24 = 0 & 0x80000000L;
		bool flag = obj24 == null;
		object obj25 = !flag;
		if (obj25 == null)
		{
			obj13 = obj13;
		}
		object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		object obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ X1_v5+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		if (num5 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	public override void Init(int capacity)
	{
	}
}
