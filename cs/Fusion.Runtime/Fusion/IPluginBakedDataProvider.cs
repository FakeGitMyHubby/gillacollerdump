using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

public interface IPluginBakedDataProvider
{
	object Bake([In] ref PluginBakedDataContext context);
}
public interface IPluginBakedDataProvider<T> : _0021_00210
{
	T Bake([In] ref PluginBakedDataContext context);

	private unsafe virtual object Fusion_002EIPluginBakedDataProvider_002EBake([In] ref PluginBakedDataContext context)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0070: Expected Obj, but got Ref
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I4
		//IL_0172: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got Ref
		//IL_01f3: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X8_v2 (Il2CppClass<Fusion.IPluginBakedDataProvider`1>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v3+10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X9_v1+FC]");
		object obj5 = (nint)0 + (nint)15;
		object obj6 = obj5 & 0x1FFFFFFF0L;
		object obj8 = default;
		object obj7 = (ref *(byte*)(&obj8)) - (ref *(byte*)obj6);
		object obj9 = obj3;
		object obj10 = obj3 + 309;
		object obj11 = obj10 & 1;
		bool flag = obj11 == null;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj13 = default;
			obj9 = obj13;
		}
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<Fusion.IPluginBakedDataProvider`1<T>>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<Fusion.IPluginBakedDataProvider`1<T>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_012a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<Fusion.IPluginBakedDataProvider`1<T>>)+98]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X10_v6-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj14--;
			obj15 += 16;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_012a;
		}
		object obj16 = num2 + obj15;
		object obj17 = obj16 + 312;
		goto IL_01cb;
		IL_01cb:
		object obj18 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v2+8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ X1_v3+10] (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v9 (Il2CppClass<Fusion.IPluginBakedDataProvider`1>)+A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X29_v1-8]");
		object result = default;
		if (num4 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		object result2 = default;
		return result2;
		IL_012a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_01cb;
	}
}
