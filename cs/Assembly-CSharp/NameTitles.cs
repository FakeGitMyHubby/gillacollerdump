using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

public static class NameTitles
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass65_0
	{
		public Transform self;
	}

	public const int None = default(int);

	public const int Owner = default(int);

	public const int Creator = default(int);

	public const int Beta = default(int);

	public const int Vip = default(int);

	public const int Dev = default(int);

	public const int Moderator = default(int);

	public static readonly string[] Items;

	private static readonly bool[] given;

	public static bool TestAsPlayer;

	public static readonly (string, Color32)[] All;

	public static readonly string[] Creators;

	private const string Key = null;

	private static int worn;

	public const string VipKey = null;

	public const string ModeratorKey = null;

	public static int Count
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0071: Expected Obj, but got I4
			//IL_008f: Expected Obj, but got I
			//IL_009f: Expected Obj, but got I
			//IL_0047: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public static int Worn
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01a9: Expected Obj, but got I4
			//IL_02ae: Expected Obj, but got I
			//IL_02c8: Expected Obj, but got I8
			//IL_01d9: Expected Obj, but got I4
			//IL_02f5: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
			//IL_01f7: Expected Obj, but got I
			//IL_0207: Expected Obj, but got I
			//IL_017f: Expected I4, but got Obj
			//IL_00c2: Expected Obj, but got I
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected I4, but got Unknown
			//IL_0128: Expected Obj, but got I4
			//IL_027d: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v2+28]");
			object obj5 = 0 & 0x80000000L;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE60]");
				object key = 0;
				int num = PlayerPrefs.GetInt((string)key, 0);
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v7+18]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v7+18]");
				if ((nint)0 == 0)
				{
					NullReferenceException ex = new NullReferenceException();
					return (int)ex;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X10_v2+18]");
				int num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X10_v2+18]");
				object obj9 = (nint)num - (nint)0;
				bool flag3 = (nint)obj9 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X10_v2+18]");
				int num3 = (int)((nint)num ^ (nint)0);
				int num4 = num ^ obj9;
				int num5 = num3 & num4;
				bool flag4 = num5 < 0;
				bool flag5 = flag3 == flag4;
				object obj10 = !flag5;
				object obj11 = ~obj10;
				if (obj11 == null)
				{
					num2 = num;
				}
				bool flag6 = num < 0;
				int num6 = num ^ num;
				int num7 = num & num6;
				bool flag7 = num7 < 0;
				bool flag8 = flag6 == flag7;
				object obj12 = !flag8;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					num2 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+E4]");
			bool flag9 = (nint)0 == 0;
			object obj14 = !flag9;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v7+28]");
			return 0;
		}
	}

	public static int Shown
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0154: Expected Obj, but got I4
			//IL_018c: Expected Obj, but got I4
			//IL_01aa: Expected Obj, but got I
			//IL_01cc: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_007a: Expected Obj, but got I4
			//IL_00f9: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F78]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7+10]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v10+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int id = Worn;
				if (MayWear(id))
				{
					object obj11 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v14+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return Worn;
				}
			}
			return 0;
		}
	}

	public static bool OwnsVip
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0137: Expected Obj, but got I4
			//IL_006d: Expected Obj, but got I
			//IL_0091: Expected I4, but got Obj
			//IL_00af: Expected Obj, but got I
			//IL_00d9: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool result;
			if (Given(4))
			{
				result = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE78]");
				object name = 0;
				Coins.Bundle bundle = CosmeticCatalog.BundleNamed((string)name);
				bool flag2 = bundle == null;
				result = (byte)(int)bundle != 0;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
					object obj4 = 0;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v9+E4]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return Coins.OwnsAll(bundle);
				}
			}
			return result;
		}
	}

	public static void Adopt(string[] owned)
	{
		//IL_0010: Expected Obj, but got I
		//IL_030d: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I4
		//IL_0388: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I4
		//IL_0201: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4708]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v15+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v13+8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v13+8]");
			object obj10;
			object obj11;
			if ((nint)0 != 0)
			{
				object obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X23_v9+18]");
				if ((nint)obj8 >= 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GiveVip();
					GiveModerator();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v15+E4]");
				if ((nint)0 != 0)
				{
					bool flag3 = owned == null;
					obj10 = obj7;
					obj11 = obj3;
					if (!flag3)
					{
						goto IL_00a5;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v15+A0]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v13+8]");
					obj7 = 0;
					bool flag4 = owned == null;
					object obj12 = !flag4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v13+8]");
					obj10 = 0;
					obj11 = obj3;
					if (obj12 != null)
					{
						goto IL_00a5;
					}
				}
				bool flag5 = obj10 == null;
				int num = 0;
				if (!flag5)
				{
					goto IL_023d;
				}
			}
			goto IL_02e8;
			IL_00a5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v19+A0]");
				obj6 = 0;
			}
			object obj15 = obj6;
			if (obj6 != null)
			{
				object obj16 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v14+18]");
				bool flag7 = (nint)obj16 < 0;
				object obj17 = !flag7;
				if (obj17 != null)
				{
					break;
				}
				object obj18 = obj6 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v15+20]");
				int num2 = Array.IndexOf((System.__Canon[])(object)owned, (System.__Canon)0);
				obj11 = obj;
				int num3 = ~num2;
				int num = num3 >> 31;
				bool flag8 = obj7 == null;
				object obj19 = !flag8;
				obj10 = obj7;
				if (obj19 != null)
				{
					goto IL_023d;
				}
			}
			goto IL_02e8;
			IL_023d:
			object obj20 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v6+18]");
			bool flag9 = (nint)obj20 < 0;
			object obj21 = !flag9;
			if (obj21 != null)
			{
				break;
			}
			object obj22 = obj10 + obj4;
			obj4++;
			obj3 = obj11;
			continue;
			IL_02e8:
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	public static bool Given(int id)
	{
		//IL_01b5: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_01a7: Expected I4, but got Obj
		//IL_00bb: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		object obj = id - 1;
		if (id >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+8]");
			if ((nint)0 == 0)
			{
				goto IL_018b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10+18]");
			if ((nint)0 >= (nint)id)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v13+A0]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v14+8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v14+8]");
					if ((nint)0 == 0)
					{
						goto IL_018b;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10+18]");
				bool flag3 = (nint)obj < 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					object obj11 = obj6 + obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v11+20]");
					bool flag4 = (nint)0 == 0;
					return !flag4;
				}
				goto IL_0199;
			}
		}
		return false;
		IL_018b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0199;
		IL_0199:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public static string Label(int id)
	{
		//IL_01a0: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		object obj = id - 1;
		if (id >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v8+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v8+18]");
			if ((nint)0 == 0)
			{
				goto IL_0176;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v12+18]");
			if ((nint)0 >= (nint)id)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v15+A0]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v16+18]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v16+18]");
					if ((nint)0 == 0)
					{
						goto IL_0176;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v12+18]");
				bool flag3 = (nint)obj < 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					object obj11 = obj6 + obj;
					return (string)(obj11 + 32);
				}
				goto IL_0184;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		return (string)0;
		IL_0176:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0184;
		IL_0184:
		return (string)(object)new IndexOutOfRangeException();
	}

	public static Color32 Colour(int id)
	{
		//IL_0206: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I8
		//IL_00a1: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_028f: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0233: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I
		//IL_01f8: Expected VT, but got Obj
		//IL_00da: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I8
		//IL_01ab: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		object obj = id - 1;
		object obj12;
		object obj13;
		object obj14;
		object obj15;
		if (id >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v8+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v8+18]");
			if ((nint)0 == 0)
			{
				goto IL_01dc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v12+18]");
			if ((nint)0 >= (nint)id)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v16+A0]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v17+18]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v17+18]");
					if ((nint)0 == 0)
					{
						goto IL_01dc;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v12+18]");
				bool flag3 = (nint)obj < 0;
				object obj10 = !flag3;
				if (obj10 != null)
				{
					goto IL_01ea;
				}
				object obj11 = obj6 + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v13+28]");
				obj12 = 0 & 0xFF000000L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v13+28]");
				obj13 = (nint)0 & (nint)0xFF0000;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v13+28]");
				obj14 = (nint)0 & (nint)0xFF00;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v13+28]");
				obj15 = (nint)0 & (nint)0xFF;
				goto IL_0268;
			}
		}
		obj12 = 4278190080L;
		obj13 = 16711680;
		obj14 = 65280;
		obj15 = 255;
		goto IL_0268;
		IL_01ea:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (Color32)ex;
		IL_01dc:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_01ea;
		IL_0268:
		object obj16 = obj12 | obj14;
		object obj17 = obj13 | obj15;
		return (Color32)(obj17 | obj16);
	}

	public static Color32 Light(int id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got VT
		//IL_0066: Expected Obj, but got VT
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0194: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Color32 color = Colour(id);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj4 = color >> 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
		object obj5 = ~color;
		object obj6 = 0xFF & obj5;
		object obj7 = obj4 ^ 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj9 = default;
		object obj8 = ~obj9;
		object obj10 = 0xFF000000FFL & obj8;
		object obj11 = obj9 & 0xFF000000FFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj13 = default;
		object obj12 = obj10 * obj13;
		object obj14 = obj12 + obj11;
		object obj15 = color & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD5C]");
		object obj16 = obj7 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD5C]");
		object obj17 = obj6 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj18 = obj16 + obj4;
		object obj19 = obj17 + obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
		object obj20 = obj14 & 0xFF0000FF0000L;
		object obj21 = obj19 & 0xFF;
		object obj22 = obj20 | obj18;
		object obj23 = obj22 | obj21;
		object obj24 = default;
		return (Color32)(obj23 | obj24);
	}

	public static void Wear(int id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected I4, but got Unknown
		//IL_00c7: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+18]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE60]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+18]");
		object obj6 = (nint)id - (nint)0;
		bool flag2 = (nint)obj6 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+18]");
		int num2 = (int)((nint)id ^ (nint)0);
		int num3 = id ^ obj6;
		int num4 = num2 & num3;
		bool flag3 = num4 < 0;
		bool flag4 = flag2 == flag3;
		object obj7 = !flag4;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			num = id;
		}
		bool flag5 = id < 0;
		int num5 = id ^ id;
		int num6 = id & num5;
		bool flag6 = num6 < 0;
		bool flag7 = flag5 == flag6;
		object obj9 = !flag7;
		object obj10 = ~obj9;
		int value = ((obj10 != null) ? num : 0);
		PlayerPrefs.SetInt((string)key, value);
		PlayerPrefs.Save();
	}

	public static bool MayWear(int id)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0513: Expected Obj, but got I
		//IL_0523: Expected Obj, but got I
		//IL_04e6: Expected I4, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_055d: Expected Obj, but got I
		//IL_043d: Expected Obj, but got I
		//IL_0461: Expected I4, but got Obj
		//IL_0371: Expected Obj, but got I
		//IL_039b: Expected Obj, but got I4
		//IL_047f: Expected Obj, but got I
		//IL_04a9: Expected Obj, but got I4
		//IL_0408: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I4
		//IL_0662: Expected Obj, but got I
		//IL_0592: Expected Obj, but got I
		//IL_05a2: Expected Obj, but got I
		//IL_05cc: Expected Obj, but got I4
		//IL_0696: Expected Obj, but got I
		//IL_06a6: Expected Obj, but got I
		//IL_06c8: Expected Obj, but got I4
		//IL_0312: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I4
		//IL_05ea: Expected Obj, but got I
		//IL_0604: Expected Obj, but got I
		//IL_0615: Expected I, but got Obj
		//IL_0633: Expected Obj, but got I
		//IL_02f7: Expected Obj, but got I
		object obj;
		bool result;
		if (id >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6+18]");
			if ((nint)0 == 0)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v7+18]");
			if ((nint)0 >= (nint)id)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool isEditor = Application.isEditor;
				object obj9 = obj;
				if (isEditor)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v55+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj9 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v55+A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v42+10]");
					if ((nint)0 == 0)
					{
						goto IL_01ce;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v55+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (Given(id))
				{
					goto IL_01ce;
				}
				if (id <= 3)
				{
					if (id == 1)
					{
						goto IL_0361;
					}
					bool flag5 = id != 2;
					result = false;
					if (!flag5)
					{
						object obj13 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v28+E4]");
						bool flag6 = (nint)0 == 0;
						object obj14 = !flag6;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj13 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE70]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v28+A0]");
						object obj16 = 0;
						object obj17 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v39+E4]");
						bool flag7 = (nint)0 == 0;
						object obj18 = !flag7;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj17 = obj15;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v39+A0]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v34+8]");
						Predicate<System.__Canon> match = (Predicate<System.__Canon>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v34+8]");
						bool flag8 = (nint)0 == 0;
						object obj20 = !flag8;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v39+E4]");
							bool flag9 = (nint)0 == 0;
							object obj21 = !flag9;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj22 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v38+A0]");
								obj19 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A50]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE68]");
							object obj24 = 0;
							Predicate<System.__Canon> predicate = default;
							predicate._002Ector(obj19, (IntPtr)obj24);
							object obj25 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v37+A0]");
							object obj26 = (nint)0 + (nint)8;
							obj26 = predicate;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							match = predicate;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v29+20]");
						return Array.Exists((System.__Canon[])0, match);
					}
				}
				else if (id != 4)
				{
					bool flag10 = id != 5;
					result = false;
					if (!flag10)
					{
						goto IL_0361;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE78]");
					object name = 0;
					Coins.Bundle bundle = CosmeticCatalog.BundleNamed((string)name);
					bool flag11 = bundle == null;
					result = (byte)(int)bundle != 0;
					if (!flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
						object obj27 = 0;
						object obj28 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v32+E4]");
						bool flag12 = (nint)0 == 0;
						object obj29 = !flag12;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						return Coins.OwnsAll(bundle);
					}
				}
				goto IL_0548;
			}
		}
		goto IL_008b;
		IL_0361:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj30 = 0;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v20+E4]");
		bool flag13 = (nint)0 == 0;
		object obj32 = !flag13;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!ModMenuAccess.IsRealOwner)
		{
			goto IL_008b;
		}
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v25+E4]");
		bool flag14 = (nint)0 == 0;
		object obj34 = !flag14;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj33 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v25+A0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v20+10]");
		bool flag15 = (nint)0 == 0;
		result = flag15;
		goto IL_0548;
		IL_01ce:
		result = true;
		goto IL_0548;
		IL_008b:
		result = false;
		goto IL_0548;
		IL_0548:
		return result;
	}

	public static void GiveVip()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE50]");
		object key = 0;
		int num = PlayerPrefs.GetInt((string)key, 0);
		if (num == 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!OwnsVip)
		{
			return;
		}
		PlayerPrefs.SetInt((string)key, 1);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Worn != 0)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int id = Worn;
			if (MayWear(id))
			{
				PlayerPrefs.Save();
				return;
			}
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Wear(4);
	}

	public static void GiveModerator()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE58]");
		object key = 0;
		int num = PlayerPrefs.GetInt((string)key, 0);
		if (num == 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Given(6))
		{
			return;
		}
		PlayerPrefs.SetInt((string)key, 1);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Worn != 0)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int id = Worn;
			if (MayWear(id))
			{
				PlayerPrefs.Save();
				return;
			}
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Wear(6);
	}

	private static void WatchForVip()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00ed: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE80]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(null, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coins.Changed -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action2 = default;
		action2._002Ector(null, (IntPtr)obj2);
		Coins.Changed += action2;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GiveVip();
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
		Array array = (Array)0;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v4 (System.Array)+18]");
		Array.Clear((Array)num, 0, 0);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5+A0]");
		object obj6 = 0;
		_ = 0;
	}

	static NameTitles()
	{
		//IL_0010: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I8
		//IL_00b1: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0186: Expected Obj, but got I8
		//IL_01b3: Expected Obj, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_024e: Expected Obj, but got I
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0290: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02e9: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0331: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I
		//IL_0395: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got I
		//IL_03dd: Expected Obj, but got I
		//IL_0414: Expected VT, but got I8
		//IL_044e: Expected Obj, but got I
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_0465: Expected Obj, but got I4
		//IL_0485: Expected VT, but got I8
		//IL_04a4: Expected Obj, but got I8
		//IL_04d1: Expected Obj, but got I
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_04e8: Expected Obj, but got I4
		//IL_0508: Expected VT, but got I8
		//IL_052f: Expected Obj, but got I4
		//IL_0545: Expected Obj, but got I
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_0588: Expected Obj, but got I
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_059f: Expected Obj, but got I4
		//IL_05bf: Expected VT, but got I8
		//IL_05de: Expected Obj, but got I8
		//IL_060b: Expected Obj, but got I
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected Obj, but got Unknown
		//IL_0622: Expected Obj, but got I4
		//IL_0642: Expected VT, but got I8
		//IL_0669: Expected Obj, but got I4
		//IL_067f: Expected Obj, but got I
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected Obj, but got Unknown
		//IL_06c2: Expected Obj, but got I
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected Obj, but got Unknown
		//IL_06d9: Expected Obj, but got I4
		//IL_06f9: Expected VT, but got I8
		//IL_0720: Expected Obj, but got I4
		//IL_0736: Expected Obj, but got I
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_0780: Expected Obj, but got I4
		//IL_07a8: Expected Obj, but got I
		//IL_07e7: Expected Obj, but got I
		//IL_0816: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDEB8]");
			object obj2 = 0;
			object obj4 = default;
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X20_v4-8]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDEE0]");
				object obj6 = 0;
				object obj7 = obj4 + 40;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X20_v6-10]");
				bool flag = (nint)0 < (nint)2;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X20_v6-10]");
				object obj9 = -2;
				bool flag2 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDEC0]");
					object obj12 = 0;
					object obj13 = obj4 + 48;
					obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X20_v8-18]");
					object obj14 = 0 & 0xFFFFFFFCL;
					if (obj14 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE98]");
						object obj15 = 0;
						object obj16 = obj4 + 56;
						obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X20_v10-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj17 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X20_v10-20]");
						object obj18 = -4;
						bool flag4 = obj18 == null;
						object obj19 = ~obj17;
						object obj20 = obj19 | flag4;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDED0]");
							object obj21 = 0;
							object obj22 = obj4 + 64;
							obj22 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X20_v12-28]");
							bool flag5 = (nint)0 < (nint)5;
							object obj23 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X20_v12-28]");
							object obj24 = -5;
							bool flag6 = obj24 == null;
							object obj25 = ~obj23;
							object obj26 = obj25 | flag6;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDEB0]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
								object obj28 = 0;
								object obj29 = obj4 + 72;
								obj29 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj30 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v23+A0]");
								object obj31 = 0;
								obj31 = obj4;
								object obj32 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj33 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v26+A0]");
								object obj34 = 0;
								object obj35 = obj34;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
								object obj36 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE88]");
								object obj37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDED8]");
								object item = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE90]");
								object obj38 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								object obj39 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v29+A0]");
								object obj40 = (nint)0 + (nint)8;
								object obj41 = default;
								obj40 = obj41;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								(System.__Canon, Color32) tuple = ((System.__Canon)item, (Color32)4281082623L);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v28+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDEA0]");
									object item2 = 0;
									object obj43 = default;
									object obj42 = obj43 + 32;
									obj42 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									(System.__Canon, Color32) tuple2 = ((System.__Canon)item2, (Color32)4291049727L);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X20_v16-8]");
									object obj44 = 0 & 0xFFFFFFFEL;
									if (obj44 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDEE8]");
										object item3 = 0;
										object obj45 = obj43 + 48;
										obj45 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										(System.__Canon, Color32) tuple3 = ((System.__Canon)item3, (Color32)4294937790L);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X20_v18-18]");
										bool flag7 = (nint)0 < (nint)2;
										object obj46 = !flag7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X20_v18-18]");
										object obj47 = -2;
										bool flag8 = obj47 == null;
										object obj48 = ~obj46;
										object obj49 = obj48 | flag8;
										if (obj49 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE78]");
											object item4 = 0;
											object obj50 = obj43 + 64;
											obj50 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											(System.__Canon, Color32) tuple4 = ((System.__Canon)item4, (Color32)4279552255L);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X20_v20-28]");
											object obj51 = 0 & 0xFFFFFFFCL;
											if (obj51 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDEA8]");
												object item5 = 0;
												object obj52 = obj43 + 80;
												obj52 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												(System.__Canon, Color32) tuple5 = ((System.__Canon)item5, (Color32)4294951790L);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X20_v22-38]");
												bool flag9 = (nint)0 < (nint)4;
												object obj53 = !flag9;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X20_v22-38]");
												object obj54 = -4;
												bool flag10 = obj54 == null;
												object obj55 = ~obj53;
												object obj56 = obj55 | flag10;
												if (obj56 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDEC8]");
													object item6 = 0;
													object obj57 = obj43 + 96;
													obj57 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													(System.__Canon, Color32) tuple6 = ((System.__Canon)item6, (Color32)4291034893L);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X20_v24-48]");
													bool flag11 = (nint)0 < (nint)5;
													object obj58 = !flag11;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X20_v24-48]");
													object obj59 = -5;
													bool flag12 = obj59 == null;
													object obj60 = ~obj58;
													object obj61 = obj60 | flag12;
													if (obj61 == null)
													{
														object obj62 = obj43 + 112;
														obj62 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														object obj63 = obj28;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v38+A0]");
														object obj64 = (nint)0 + (nint)24;
														obj64 = obj43;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
														object obj65 = obj28;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v39+A0]");
														object obj66 = (nint)0 + (nint)32;
														object obj67 = default;
														obj66 = obj67;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														object obj68 = obj28;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v42+A0]");
														object obj69 = 0;
														_ = 4294967295L;
														return;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
