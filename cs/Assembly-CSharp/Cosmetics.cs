using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class Cosmetics
{
	public const int Slots = default(int);

	private static readonly byte[] worn;

	private static bool loaded;

	public static byte[] Disguise;

	public static byte Head
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0061: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return In((CosmeticSlot)0);
		}
	}

	public static byte Face
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0061: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return In((CosmeticSlot)1);
		}
	}

	public static string WornNames
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_037c: Expected Obj, but got I
			//IL_039f: Expected Obj, but got I4
			//IL_005a: Expected Obj, but got I
			//IL_00be: Expected Obj, but got I8
			//IL_00ce: Expected Obj, but got I
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected Obj, but got Unknown
			//IL_00e5: Expected Obj, but got I4
			//IL_03c6: Expected Obj, but got I4
			//IL_0343: Expected Obj, but got I
			//IL_031d: Expected Obj, but got I
			//IL_0299: Expected Obj, but got I
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Expected Obj, but got Unknown
			//IL_0181: Expected I4, but got Obj
			//IL_01e3: Expected Obj, but got I4
			//IL_0262: Expected Obj, but got I
			//IL_0272: Expected Obj, but got I
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Expected Obj, but got Unknown
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Load();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<System.__Canon> list = default;
			list._002Ector();
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+A0]");
			object obj6 = 0;
			object obj7 = obj6;
			if (obj6 == null)
			{
				goto IL_0348;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X21_v3+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_02cb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X21_v3+18]");
			object obj8 = 0 & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
			object obj9 = 0;
			object obj10 = obj6 + 32;
			object obj11 = 0;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
				object obj12 = !flag2;
				if (obj12 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X24_v6+v110 @ X22_v7]");
				CosmeticCatalog.Entry entry = CosmeticCatalog.Of(0);
				if (entry == null)
				{
					goto IL_0289;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X24_v6+v110 @ X22_v7]");
				CosmeticCatalog.Entry entry2 = CosmeticCatalog.Of(0);
				if (entry2 != null && list != null)
				{
					System.__Canon[] items = list._items;
					int num = (int)obj9;
					int version = list._version + 1;
					list._version = version;
					if (list._items != null)
					{
						bool flag3 = list._size < items.Length;
						object obj13 = !flag3;
						if (obj13 == null)
						{
							object obj14 = list._items + list._size;
							num = list._size + 1;
							list._size = num;
							object obj15 = obj14 + 32;
							obj15 = entry2.name;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X9_v5 (System.Int32)+20]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v20+A8]");
							object obj17 = 0;
							list.AddWithResize((System.__Canon)(object)entry2.name);
						}
						goto IL_0289;
					}
				}
				goto IL_0348;
				IL_0289:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X21_v3+18]");
				obj8 = 0;
				obj11++;
				object obj18 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X21_v3+18]");
				if ((nint)obj18 < 0)
				{
					continue;
				}
				goto IL_02cb;
			}
			goto IL_0356;
			IL_0356:
			return (string)(object)new IndexOutOfRangeException();
			IL_02cb:
			if (list != null)
			{
				if (list._size > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A0]");
					object separator = 0;
					return string.Join((string)separator, (IEnumerable<string>)list);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4698]");
				return (string)0;
			}
			goto IL_0348;
			IL_0348:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0356;
		}
	}

	public static byte In(CosmeticSlot slot)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01fe: Expected I4, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		NullReferenceException ex = (NullReferenceException)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9 (System.NullReferenceException)+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X9_v7+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X9_v7+10]");
		if ((nint)0 == 0)
		{
			goto IL_0116;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9 (System.NullReferenceException)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v13+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v14+10]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v14+10]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				goto IL_0108;
			}
		}
		goto IL_016d;
		IL_0108:
		ex = new NullReferenceException();
		goto IL_0116;
		IL_016d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+18]");
		bool flag4 = (nint)0 < (nint)slot;
		object obj10 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+18]");
		object obj11 = (nint)0 - (nint)slot;
		bool flag5 = obj11 == null;
		object obj12 = ~obj10;
		object obj13 = obj12 | flag5;
		if (obj13 == null)
		{
			object obj14 = obj5 + slot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6+20]");
			return 0;
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2;
		IL_0116:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9 (System.NullReferenceException)+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v11+A0]");
			obj4 = 0;
		}
		obj5 = obj4;
		if (obj4 == null)
		{
			goto IL_0108;
		}
		goto IL_016d;
	}

	public static void Wear(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj = 0;
		byte id = CosmeticCatalog.IdOf(name);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Wear(id);
	}

	public static void Wear(byte id)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		int id2 = id & 0xFF;
		CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id2);
		if (entry != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Set(entry.slot, id);
		}
	}

	public static void TakeOff(CosmeticSlot slot)
	{
		//IL_0010: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Set(slot, 0);
	}

	public static bool IsWearing(byte id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		if ((id & 0xFF) != 0)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v4+10]");
			byte[] array = (byte[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v4+10]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v12+A0]");
					obj6 = 0;
				}
				array = (byte[])obj6;
			}
			int num = Array.IndexOf(array, id);
			int num2 = ~num;
			return (byte)(num2 >> 31) != 0;
		}
		return false;
	}

	private static void Set(CosmeticSlot slot, byte id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v4+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v16+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v17+10]");
				obj6 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v14+18]");
			bool flag3 = (nint)0 < (nint)slot;
			object obj10 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v14+18]");
			object obj11 = (nint)0 - (nint)slot;
			bool flag4 = obj11 == null;
			object obj12 = ~obj10;
			object obj13 = obj12 | flag4;
			if (obj13 == null)
			{
				object obj14 = obj6 + slot;
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v13+A0]");
				obj5 = 0;
			}
			object obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8+18]");
			bool flag6 = (nint)0 < (nint)slot;
			object obj18 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8+18]");
			object obj19 = (nint)0 - (nint)slot;
			bool flag7 = obj19 == null;
			object obj20 = ~obj18;
			object obj21 = obj20 | flag7;
			if (obj21 == null)
			{
				object obj22 = obj17 + slot;
				string key = Key(slot);
				int value = id & 0xFF;
				PlayerPrefs.SetInt(key, value);
				PlayerPrefs.Save();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
				object obj23 = 0;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v13+E4]");
				bool flag8 = (nint)0 == 0;
				object obj25 = !flag8;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaCloud.ProfileChanged();
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static void Adopt(string[] names)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I8
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got I4
		//IL_0237: Expected Obj, but got I
		//IL_03db: Expected Obj, but got I4
		//IL_0265: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_0339: Expected Obj, but got I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I4
		//IL_037d: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+A0]");
		object array = 0;
		Array.Clear((Array)array, 0, 8);
		bool flag2 = names.Length < 1;
		int num = 0;
		if (flag2)
		{
			goto IL_01ec;
		}
		object obj5 = names.Length & 0xFFFFFFFFL;
		object obj6 = names + 32;
		object obj7 = 0;
		int num2 = 0;
		while (true)
		{
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
			object obj8 = !flag3;
			if (obj8 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X24_v5+v90 @ X23_v6*8]");
			byte b = CosmeticCatalog.IdOf((string)0);
			int id = b & 0xFF;
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id);
			if (entry != null)
			{
				bool flag4 = string.IsNullOrEmpty(entry.wornWith);
				bool flag5 = !flag4;
				num2 = 0;
				if (!flag5)
				{
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v26+E4]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj9 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v26+A0]");
					object obj11 = 0;
					object obj12 = obj11;
					CosmeticSlot slot = entry.slot;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v22+18]");
					bool flag7 = (nint)slot < (nint)0;
					object obj13 = !flag7;
					if (obj13 != null)
					{
						break;
					}
					object obj14 = obj12 + entry.slot;
					num2 = 0;
				}
			}
			obj5 = names.Length;
			obj7++;
			bool flag8 = (nint)obj7 < names.Length;
			num = num2;
			if (flag8)
			{
				continue;
			}
			goto IL_01ec;
		}
		goto IL_02e2;
		IL_01ec:
		int num3 = 8;
		CosmeticSlot cosmeticSlot = (CosmeticSlot)0;
		while (true)
		{
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v11+E4]");
			bool flag9 = (nint)0 == 0;
			object obj16 = !flag9;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string key = Key(cosmeticSlot);
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v12+A0]");
			object obj18 = 0;
			object obj19 = obj18;
			CosmeticSlot cosmeticSlot2 = cosmeticSlot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v14+18]");
			bool flag10 = (nint)cosmeticSlot2 < (nint)0;
			object obj20 = !flag10;
			if (obj20 != null)
			{
				break;
			}
			object obj21 = obj19 + cosmeticSlot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v15+20]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v15+20]");
			PlayerPrefs.SetInt(key, 0);
			cosmeticSlot++;
			bool flag11 = cosmeticSlot != (CosmeticSlot)8;
			num3 = 0;
			if (!flag11)
			{
				PlayerPrefs.Save();
				return;
			}
		}
		goto IL_02e2;
		IL_02e2:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe static string Key(CosmeticSlot slot)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4688]");
		object obj = 0;
		object obj2 = default;
		string text = ((Enum)(&obj2)).ToString();
		return (string)obj + text;
	}

	private static void Load()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6+8]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v18+A0]");
			obj4 = 0;
		}
		_ = 1;
		CosmeticSlot cosmeticSlot = (CosmeticSlot)0;
		while (true)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string key = Key(cosmeticSlot);
			int num = PlayerPrefs.GetInt(key, 0);
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v9+A0]");
			object obj11 = 0;
			object obj12 = obj11;
			if (entry != null && cosmeticSlot == entry.slot)
			{
				bool flag5 = string.IsNullOrEmpty(entry.wornWith);
				bool flag6 = !flag5;
				object obj13 = !flag6;
				object obj14 = ~obj13;
				if (obj14 == null)
				{
					int num2 = num;
				}
				else
				{
					int num2 = 0;
				}
				int num3 = 0;
			}
			else
			{
				int num3 = 0;
				int num2 = 0;
			}
			if (obj11 != null)
			{
				CosmeticSlot cosmeticSlot2 = cosmeticSlot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X22_v4+18]");
				bool flag7 = (nint)cosmeticSlot2 < (nint)0;
				object obj15 = !flag7;
				if (obj15 != null)
				{
					break;
				}
				object obj16 = obj11 + cosmeticSlot;
				cosmeticSlot++;
				if (cosmeticSlot == (CosmeticSlot)8)
				{
					return;
				}
				continue;
			}
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	static Cosmetics()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		object obj5 = default;
		obj4 = obj5;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
