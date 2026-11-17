using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

public static class LagCompensatedExt
{
	public unsafe static void SortReference(List<LagCompensatedHit> hits, Vector3 reference)
	{
		//IL_003b: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		//IL_00d8: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6540]");
			object obj = 0;
			object obj3 = default;
			object obj2 = obj3;
			object obj5 = default;
			object obj4 = obj5;
			object obj6 = 0;
			int num = 0;
			object obj8 = default;
			object obj9 = default;
			object obj11 = default;
			object obj12 = default;
			object obj15 = default;
			int num2;
			do
			{
				LagCompensatedHit lagCompensatedHit = hits.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				LagCompensatedHit lagCompensatedHit2 = hits.get_Item(num);
				object obj7 = obj8 - obj9;
				object obj10 = obj11 - obj5;
				obj2 = obj12 - obj3;
				object obj13 = obj7 * obj7;
				object obj14 = obj10 * obj10;
				obj6 = obj13 + obj14;
				obj4 = obj2 * obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				hits.set_Item(num, (LagCompensatedHit)(&obj15));
				num++;
				num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
			}
			while ((nint)num2 < (nint)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
			int high = (int)(-1);
			LagCompensatedHit.QuickSort(hits, 0, high);
		}
	}

	public static void SortDistance(List<LagCompensatedHit> hits)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
		int high = (int)(-1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
		if ((nint)0 >= (nint)1)
		{
			LagCompensatedHit.QuickSortDistance(hits, 0, high);
		}
	}
}
