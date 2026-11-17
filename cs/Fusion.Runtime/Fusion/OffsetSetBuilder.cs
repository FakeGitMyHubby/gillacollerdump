using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Fusion;

internal struct OffsetSetBuilder
{
	private List<int> _values;

	public void Add(int value)
	{
		//IL_00f1: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		List<int> values = _values;
		bool flag = _values == null;
		int num = default;
		int item = num;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2 (System.Collections.Generic.List`1<System.Int32>)+18]");
			int index = (int)(-1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2 (System.Collections.Generic.List`1<System.Int32>)+18]");
			bool flag2 = (nint)0 < (nint)1;
			item = num;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
				object obj = 0;
				int num2 = _values.get_Item(index);
				bool flag3 = num2 < num;
				item = num;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					int num3 = default;
					string message = default;
					((ArgumentException)num3)._002Ector(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					item = num3;
					throw new ArgumentNullException();
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<int> list = default;
			list._002Ector();
			_values = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		List<int> values2 = _values;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj4 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v5+18]");
		bool flag4 = num4 < 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj6 = obj3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj7 = (nint)0 + (nint)1;
		}
		else
		{
			values2.AddWithResize(item);
		}
	}

	public OffsetSet MakeOffsetSet()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		if (_values != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73C8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6DD8]");
			object obj2 = 0;
			int[] array = _values.ToArray();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj4 = default;
			object obj3 = obj4 + 16;
			obj3 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj4._002Ector();
			return (OffsetSet)obj4;
		}
		return null;
	}
}
