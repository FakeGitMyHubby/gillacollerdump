using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal static class ICallbacksExtensions
{
	[MethodImpl((MethodImplOptions)256)]
	public static void InvokeOnInput(Simulation.ICallbacks callbacks, SimulationInput input)
	{
		//IL_000d: Expected I, but got Obj
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		nint num = (nint)callbacks;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (Il2CppClass<Fusion.Simulation+ICallbacks>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (Il2CppClass<Fusion.Simulation+ICallbacks>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00a9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (Il2CppClass<Fusion.Simulation+ICallbacks>)+98]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj2--;
			obj3 += 16;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00a9;
		}
		object obj4 = obj3 + 36;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_010a;
		IL_00a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_010a;
		IL_010a:
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v3+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v108 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static void InvokeOnInputMissing(Simulation.ICallbacks callbacks, SimulationInput input)
	{
		//IL_000d: Expected I, but got Obj
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		nint num = (nint)callbacks;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (Il2CppClass<Fusion.Simulation+ICallbacks>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (Il2CppClass<Fusion.Simulation+ICallbacks>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00a9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (Il2CppClass<Fusion.Simulation+ICallbacks>)+98]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj2--;
			obj3 += 16;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00a9;
		}
		object obj4 = obj3 + 37;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_010a;
		IL_00a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_010a;
		IL_010a:
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v3+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v108 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
