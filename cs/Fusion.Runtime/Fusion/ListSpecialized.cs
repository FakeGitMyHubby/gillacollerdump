using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal static class ListSpecialized
{
	public static int BinarySearchSpecialized(List<NetworkId> list, NetworkId value)
	{
		//IL_0125: Expected I4, but got Obj
		//IL_001b: Expected Obj, but got I
		//IL_0112: Expected I4, but got I8
		//IL_004a: Expected Obj, but got I4
		//IL_019d: Expected I4, but got Obj
		//IL_01bb: Expected Obj, but got VT
		//IL_005d: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I4
		//IL_0100: Expected I4, but got Obj
		if ((object)list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<Fusion.NetworkId>)+18]");
			object obj = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ X0 (System.Collections.Generic.List`1<Fusion.NetworkId>)+18]");
			int num;
			if ((nint)0 >= (nint)1)
			{
				object obj2 = 0;
				while (true)
				{
					object obj3 = obj - obj2;
					num = (int)(obj2 + obj3);
					NetworkId networkId = list.get_Item(num);
					object obj4 = networkId - value;
					if (networkId == value)
					{
						break;
					}
					object obj5 = num - 1;
					bool flag = (nint)obj4 < 0;
					object obj6 = obj4 ^ obj4;
					object obj7 = obj4 & obj6;
					bool flag2 = (nint)obj7 < 0;
					bool flag3 = flag == flag2;
					object obj8 = !flag3;
					object obj9 = ~obj8;
					if (obj9 != null)
					{
						obj = obj5;
					}
					if ((nint)obj4 < 0)
					{
						obj2 = num + 1;
					}
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
					{
						object obj10 = ~obj2;
						num = (int)obj10;
						break;
					}
				}
			}
			else
			{
				num = -1;
			}
			return num;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static bool AddUnique(List<NetworkId> list, NetworkId value)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected VT, but got Unknown
		//IL_00aa: Expected I4, but got I8
		//IL_0075: Expected I4, but got Obj
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected VT, but got Unknown
		NetworkId value2 = (NetworkId)(value & 0xFFFFFFFFL);
		int num = BinarySearchSpecialized(list, value2);
		if ((int)(num & 0x80000000L) != 0)
		{
			if ((object)list == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			int index = ~num;
			NetworkId item = (NetworkId)(value & 0xFFFFFFFFL);
			list.Insert(index, item);
		}
		return (byte)(num >> 31) != 0;
	}

	public static bool RemoveUnique(List<NetworkId> list, NetworkId value)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected VT, but got Unknown
		//IL_0094: Expected I4, but got I8
		//IL_00ae: Expected Obj, but got I4
		//IL_005f: Expected I4, but got Obj
		NetworkId value2 = (NetworkId)(value & 0xFFFFFFFFL);
		int num = BinarySearchSpecialized(list, value2);
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		if (obj == null)
		{
			if ((object)list == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			list.RemoveAt(num);
		}
		int num3 = ~num;
		return (byte)(num3 >> 31) != 0;
	}
}
