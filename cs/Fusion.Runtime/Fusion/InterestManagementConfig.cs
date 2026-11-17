using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

[Serializable]
public class InterestManagementConfig
{
	public int AreaOfInterestCellSize;

	public Vector3Int AreaOfInterestCellGridSize;

	internal void Validate()
	{
		//IL_0090: Expected I4, but got VT
		//IL_009b: Invalid comparison between VT and I4
		//IL_003a: Expected VT, but got I4
		//IL_0081: Expected VT, but got I4
		if (AreaOfInterestCellSize <= 3)
		{
			AreaOfInterestCellSize = 4;
		}
		int x = (int)AreaOfInterestCellGridSize;
		if (AreaOfInterestCellGridSize <= (object)0)
		{
			AreaOfInterestCellGridSize = (Vector3Int)32;
			x = 32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.InterestManagementConfig)+18]");
		int y = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.InterestManagementConfig)+18]");
		if ((nint)0 <= (nint)0)
		{
			_ = 32;
			y = 32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.InterestManagementConfig)+1C]");
		int z = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.InterestManagementConfig)+1C]");
		if ((nint)0 <= (nint)0)
		{
			_ = 32;
			z = 32;
		}
		if (CheckCellHashIntOverflow(x, y, z))
		{
			_ = 1024;
			AreaOfInterestCellGridSize = (Vector3Int)4;
		}
	}

	public static bool CheckCellHashIntOverflow(int x, int y, int z)
	{
		//IL_0306: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_018b: Expected I4, but got Obj
		//IL_01b3: Expected Obj, but got I
		//IL_01bb: Expected I4, but got Obj
		//IL_0012: Expected Obj, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I
		//IL_015b: Expected I4, but got Obj
		//IL_007f: Expected Obj, but got I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I4
		//IL_02b5: Expected Obj, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		int num = default;
		int num2 = default;
		object obj = num * num2;
		bool flag = obj != obj;
		ArgumentNullException ex = (ArgumentNullException)num2;
		ArgumentNullException ex2;
		int num3 = default;
		ArgumentNullException ex3;
		if (!flag)
		{
			object obj2 = num * num2;
			object obj3 = obj2 * num3;
			bool flag2 = obj3 != obj3;
			ex2 = (ArgumentNullException)num2;
			if (flag2)
			{
				goto IL_0199;
			}
			object obj4 = num3 * num2;
			if (obj4 == obj4)
			{
				object obj5 = num3 * num2;
				object obj6 = obj2 * num3;
				object obj7 = obj5 + obj6;
				if (obj7 == obj7)
				{
					object obj8 = obj6 + obj5;
					object obj9 = num2 + obj8;
					bool flag3 = obj9 != obj9;
					ex3 = (ArgumentNullException)num2;
					if (!flag3)
					{
						object obj10 = obj8 + num2;
						bool flag4 = (nint)obj10 == 2147483647;
						ex3 = (ArgumentNullException)num2;
						if (!flag4)
						{
							return false;
						}
					}
					goto IL_01c9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65380");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6C8]");
			object obj11 = 0;
			num3 = (int)obj11;
			ex = new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65380");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6C8]");
		object obj12 = 0;
		num3 = (int)obj12;
		ex2 = new ArgumentNullException();
		goto IL_0199;
		IL_0199:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65380");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6C8]");
		object obj13 = 0;
		num3 = (int)obj13;
		ex3 = new ArgumentNullException();
		goto IL_01c9;
		IL_01c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65380");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6C8]");
		object obj14 = 0;
		object obj15 = obj14;
		ArgumentNullException ex4 = new ArgumentNullException();
		bool flag5 = (nint)obj14 != 1;
		ArgumentNullException ex5 = ex4;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj17 = default;
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj19 = default;
			object obj18 = obj19 & 1;
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				return true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj20 = obj17;
			obj15 = 101789696 + 1224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			ArgumentNullException ex6 = default;
			ex5 = ex6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
	}

	public InterestManagementConfig()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D360]");
		AreaOfInterestCellSize = 0;
		base._002Ector();
	}
}
