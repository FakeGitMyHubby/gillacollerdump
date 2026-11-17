using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

internal static class FusionUtility
{
	public unsafe static void PruneMixedAuthorityHierarchy(Transform currentParent, Transform targetParent, PlayerRef rootAuth)
	{
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected VT, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I4
		//IL_0278: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got Ref
		//IL_00fc: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_01a5: Invalid comparison between I4 and VT
		int childCount = currentParent.childCount;
		int num = childCount - 1;
		if (childCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D67E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj2 = 0;
		object obj5 = default;
		int num3 = default;
		int num4 = default;
		bool flag5;
		do
		{
			Transform child = currentParent.GetChild(num);
			PlayerRef rootAuth2 = (PlayerRef)(rootAuth & 0xFFFFFFFFL);
			PruneMixedAuthorityHierarchy(child, targetParent, rootAuth2);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			object obj4 = obj5 & 1;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ stack_-58_v5 (System.Int32)+58]");
				object obj6 = (nint)0 & (nint)4;
				bool flag = obj6 == null;
				object obj7 = !flag;
				int num2 = num3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ stack_-58_v5 (System.Int32)+20]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ stack_-58_v5 (System.Int32)+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ stack_-58_v5 (System.Int32)+30]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v9+20]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
						num2 = num4;
						obj3 = 0;
					}
					else
					{
						object obj11 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v25+E4]");
						bool flag2 = (nint)0 == 0;
						object obj12 = !flag2;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						num2 = 0;
						object obj10 = (object)(&num3);
					}
					object obj13 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj14 = !flag3;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((object)num2 != (object)rootAuth)
					{
						int childCount2 = child.childCount;
						if (childCount2 >= 1)
						{
							int num5 = childCount2;
							bool flag4;
							do
							{
								num2 = num5 - 1;
								Transform child2 = child.GetChild(num2);
								child2.SetParent(currentParent);
								flag4 = num2 > 0;
								num5 = num2;
							}
							while (flag4);
						}
						child.SetParent(targetParent);
					}
				}
			}
			int num6 = num - 1;
			flag5 = num > 0;
			num = num6;
		}
		while (flag5);
	}
}
