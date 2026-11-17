using System;
using Cpp2ILInjected;

namespace Fusion;

[Serializable]
public class HeapConfiguration : Action<GillaCloud.Reply>
{
	internal const int PageCountMin = default(int);

	internal const int PageCountMax = default(int);

	public PageSizes PageShift;

	public int PageCount;

	public int GlobalsSize;

	internal Allocator.Config ToAllocatorConfig()
	{
		//IL_0050: Expected VT, but got I4
		Allocator.Config config = new Allocator.Config(PageShift, PageCount, GlobalsSize);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return (Allocator.Config)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Allocator.Config result = default;
		return result;
	}

	public HeapConfiguration Init(int globalsSize)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		HeapConfiguration heapConfiguration = (HeapConfiguration)MemberwiseClone();
		if ((object)heapConfiguration != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D99A0]");
			object obj = 0;
			object obj2 = obj;
			nint num = (nint)heapConfiguration;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<Fusion.HeapConfiguration>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X1_v3+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<Fusion.HeapConfiguration>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X1_v3+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
				if (0 == (nint)obj2)
				{
					heapConfiguration.GlobalsSize = globalsSize;
					return heapConfiguration;
				}
			}
			InvalidCastException ex = new InvalidCastException();
		}
		return (HeapConfiguration)(object)new NullReferenceException();
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6C0]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		object arg3 = default;
		return string.Format((string)format, arg, arg2, arg3);
	}

	public void SanityCheck()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected I4, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected I4, but got Unknown
		//IL_0197: Expected Obj, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = PageCount - 4096;
		bool flag2 = (nint)obj4 < 0;
		int num = PageCount ^ 0x1000;
		int num2 = PageCount ^ obj4;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag2 == flag3;
		object obj5 = !flag4;
		object obj6 = ~obj5;
		int num4 = ((obj6 != null) ? 4096 : PageCount);
		object obj7 = num4 - 16;
		bool flag5 = (nint)obj7 < 0;
		bool flag6 = obj7 == null;
		int num5 = num4 ^ 0x10;
		int num6 = num4 ^ obj7;
		int num7 = num5 & num6;
		bool flag7 = num7 < 0;
		bool flag8 = flag5 == flag7;
		object obj8 = !flag6;
		object obj9 = flag8 & obj8;
		object obj10 = ~obj9;
		if (obj10 != null)
		{
			num4 = 16;
		}
		PageCount = num4;
	}

	public HeapConfiguration()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B408]");
		PageShift = (PageSizes)0;
		base._002Ector();
	}
}
