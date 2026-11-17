using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class Coins
{
	[Serializable]
	public class Bundle
	{
		public string name;

		public string label;

		public string[] items;

		public int price;

		public int coins;

		public bool realMoney;

		public string sku;

		public string usd;

		public string tag;

		public bool xpBoost;

		public int dailyCoins;

		public Bundle()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj2 = this + 32;
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			price = 5000;
			base._002Ector();
		}
	}

	private const string BalanceKey = null;

	private const string OwnedKey = null;

	private const string BoltsKey = null;

	public const int Starting = default(int);

	public static bool Infinite;

	private static bool loaded;

	private static int balance;

	private static int bolts;

	private static readonly HashSet<string> owned;

	private static Action m_Changed;

	public static int Balance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00ed: Expected Obj, but got I4
			//IL_0041: Expected Obj, but got I
			//IL_008e: Expected Obj, but got I4
			//IL_00be: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Load();
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v4+A0]");
			object obj5 = 0;
			if (obj5 != null)
			{
				return 2147483647;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7+A0]");
				obj5 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+4]");
			return 0;
		}
	}

	public static string Text
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e6: Expected Obj, but got I4
			//IL_0104: Expected Obj, but got I
			//IL_006b: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+A0]");
			object obj4 = 0;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F0]");
				return (string)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = Balance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
			object obj6 = 0;
			int num2 = default;
			return num2.ToString((string)obj6);
		}
	}

	public static int Bolts
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Load();
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5+8]");
			return 0;
		}
	}

	public static string BoltsText
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_0082: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = Bolts;
			int num2 = default;
			return num2.ToString((string)obj3);
		}
	}

	public static event Action Changed
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	public static void AddBolts(int amount)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
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
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+8]");
		object obj6 = (nint)0 + (nint)amount;
		object obj7 = ~obj6;
		object obj8 = obj6 & obj7;
		Save();
		if (amount >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCloud.Earned(amount);
		}
	}

	public static void AddBoltsHere(int amount)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
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
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+8]");
		object obj6 = (nint)0 + (nint)amount;
		object obj7 = ~obj6;
		object obj8 = obj6 & obj7;
		Save();
	}

	public static void SpendBolts(int amount, string item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+8]");
		object obj7 = -amount;
		object obj8 = ~obj7;
		object obj9 = obj7 & obj8;
		Save();
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaCloud.SpentBolts(item);
	}

	public static bool Owns(byte id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I4
		//IL_0060: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I
		//IL_024f: Expected I4, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
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
		int id2 = id & 0xFF;
		CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id2);
		bool flag2 = entry == null;
		bool result = (byte)(int)entry != 0;
		if (!flag2)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+10]");
			if ((nint)0 == 0)
			{
				goto IL_0241;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+10]");
			bool flag4 = ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)entry.name);
			bool flag5 = !flag4;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v15+E4]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!OwnerHas(entry))
				{
					if (string.IsNullOrEmpty(entry.comesWith))
					{
						result = false;
						goto IL_0287;
					}
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v22+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj11 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v22+A0]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11+10]");
						return ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)entry.comesWith);
					}
					goto IL_0241;
				}
			}
			result = true;
		}
		goto IL_0287;
		IL_0241:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0287:
		return result;
	}

	private static bool OwnerHas(CosmeticCatalog.Entry e)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got VT
		//IL_0055: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_024b: Expected I4, but got Obj
		//IL_00ff: Expected Obj, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I4
		//IL_02cb: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got I
		//IL_01e7: Expected I4, but got I8
		//IL_020e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ModMenu.Kind? menu = ModMenuAccess.Menu;
		object obj4 = (_003F?)menu >> 32;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		bool result = false;
		if (obj5 == null)
		{
			object obj6 = (_003F?)menu & 0xFF;
			bool flag3 = obj6 == null;
			result = false;
			if (!flag3)
			{
				CosmeticCatalog cosmeticCatalog = CosmeticCatalog.Get();
				if ((object)cosmeticCatalog != null)
				{
					Bundle[] bundles = cosmeticCatalog.bundles;
					if (cosmeticCatalog.bundles != null)
					{
						object obj7 = bundles.Length;
						if (bundles.Length >= 1)
						{
							object obj8 = cosmeticCatalog.bundles + 32;
							object obj9 = 0;
							while (true)
							{
								bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
								object obj10 = !flag4;
								if (obj10 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X23_v6+v128 @ X21_v9*8]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X23_v6+v128 @ X21_v9*8]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v7+20]");
									if ((nint)0 != 0)
									{
										if (e == null)
										{
											goto IL_022f;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v7+20]");
										int num = Array.IndexOf((System.__Canon[])0, (System.__Canon)(object)e.name);
										if ((int)(num & 0x80000000L) == 0)
										{
											goto IL_0221;
										}
										obj7 = bundles.Length;
									}
									obj9++;
									if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
									{
										continue;
									}
									goto IL_0213;
								}
								goto IL_022f;
							}
							goto IL_023d;
						}
					}
					goto IL_0213;
				}
				goto IL_022f;
			}
		}
		goto IL_0283;
		IL_022f:
		NullReferenceException ex = new NullReferenceException();
		goto IL_023d;
		IL_0221:
		result = true;
		goto IL_0283;
		IL_023d:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_0283:
		return result;
		IL_0213:
		result = false;
		goto IL_0283;
	}

	public static bool OwnsName(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_00da: Expected I4, but got Obj
		//IL_00c3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
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
		if (string.IsNullOrEmpty(name))
		{
			return false;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5+10]");
			return ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)name);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe static int PriceOf(Bundle b)
	{
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_0493: Expected I, but got Obj
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got I4
		//IL_05fe: Expected I, but got Obj
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected Ref, but got Unknown
		//IL_0621: Expected Obj, but got I4
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got I4
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00c3: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_04d2: Expected Obj, but got I
		//IL_04fc: Expected Obj, but got I4
		//IL_02a8: Invalid comparison between Obj and F8
		//IL_026a: Invalid comparison between Obj and F8
		//IL_056d: Invalid comparison between F8 and I4
		//IL_057c: Invalid comparison between F8 and I4
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_059d: Expected Obj, but got F8
		//IL_05d2: Expected Obj, but got I4
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0541: Expected Obj, but got I4
		//IL_0339: Expected I4, but got F8
		List<byte> list = CosmeticCatalog.IdsOf(b);
		bool flag = list == null;
		int num2 = default;
		int num = num2;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4728]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4720]");
			object obj3 = 0;
			Enumerator<, > enumerator = list.GetEnumerator();
			object obj4 = 0;
			object obj5 = 0;
			Enumerator<, > val2 = default;
			object obj13 = default;
			int result = default;
			double num6 = default;
			while (true)
			{
				nint num3 = (nint)obj;
				object obj9;
				Enumerator<, > val3;
				Enumerator<, > val4;
				if (val.MoveNext())
				{
					CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num2);
					if (entry != null)
					{
						object obj6 = obj2;
						obj4 = entry.price + obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v44+E4]");
						bool flag2 = (nint)0 == 0;
						object obj7 = !flag2;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag3 = Owns((byte)num2);
						bool flag4 = !flag3;
						object obj8 = !flag4;
						if (obj8 == null)
						{
							obj5 = entry.price + obj5;
						}
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					num = 0;
					val = val2;
					obj9 = 0;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					break;
				}
				num = 0;
				val = val2;
				obj9 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				object obj10 = 0;
				while (true)
				{
					num3 = (nint)obj3;
					((Enumerator<, >*)val4)->Dispose();
					bool flag5 = obj10 == null;
					object obj11 = !flag5;
					if (obj11 == null)
					{
						bool flag6 = num == 0;
						object obj12 = !flag6;
						OutOfMemoryException ex2 = (OutOfMemoryException)val4;
						if (obj12 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num3)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num = 1;
						obj10 = obj9;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj10 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj9 = obj13;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CEFC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result;
					}
				}
				bool flag7 = (nint)obj4 < 1;
				int result2 = 0;
				double num4;
				double num5;
				if (!flag7)
				{
					bool flag8 = (nint)obj5 <= 0;
					result2 = 0;
					if (!flag8)
					{
						if (b == null)
						{
							break;
						}
						object obj14 = obj5 * b.price;
						object obj15 = obj14 / obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj16 = 0;
						object obj17 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v9+E4]");
						bool flag9 = (nint)0 == 0;
						object obj18 = !flag9;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
						if ((nint)obj15 < 0)
						{
							if (obj15 == (object)(-0.5))
							{
								num4 = -1.0;
								num5 = num6;
								goto IL_050a;
							}
							num5 = (double)obj15 + -0.5;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
						}
						else
						{
							if (obj15 == (object)0.5)
							{
								num4 = 1.0;
								num5 = num6;
								goto IL_050a;
							}
							num5 = (double)obj15 + 0.5;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						}
						goto IL_0554;
					}
				}
				goto IL_04bd;
				IL_050a:
				double num7 = num5 + num4;
				object obj19 = num5 & 1;
				bool flag10 = obj19 == null;
				object obj20 = !flag10;
				if (obj20 != null)
				{
					num5 = num7;
				}
				goto IL_0554;
				IL_04bd:
				return result2;
				IL_0554:
				double num8 = num5 - 1.0;
				bool flag11 = num8 < 0.0;
				bool flag12 = num8 == 0.0;
				object obj21 = num5 ^ 1;
				object obj22 = num5 ^ num8;
				object obj23 = obj21 & obj22;
				bool flag13 = (nint)obj23 < 0;
				bool flag14 = flag11 == flag13;
				object obj24 = !flag12;
				object obj25 = flag14 & obj24;
				object obj26 = ~obj25;
				result2 = ((obj26 != null) ? 1 : ((int)num5));
				goto IL_04bd;
			}
		}
		throw new NullReferenceException();
	}

	public static bool OwnsAll(Bundle b)
	{
		//IL_0092: Expected I4, but got Obj
		//IL_003a: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0063: Expected I, but got Obj
		List<byte> list = CosmeticCatalog.IdsOf(b);
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4758]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4740]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Predicate<byte> predicate = default;
				predicate._002Ector((object)null, (IntPtr)obj2);
				return list.TrueForAll(predicate);
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe static bool Buy(Bundle b)
	{
		//IL_003f: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected Obj, but got I4
		//IL_0b39: Expected Obj, but got I
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Expected Obj, but got I4
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got I4
		//IL_09cf: Expected Obj, but got I
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected Obj, but got I4
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I4
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got I4
		//IL_0350: Expected Obj, but got I
		//IL_0360: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected I4, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		if (b == null || ~(b.realMoney ? 1u : 0u) == 0)
		{
			int num = 0;
			return (byte)(num & 1) != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45E8]");
		object obj5 = 0;
		System.__Canon _Canon = (System.__Canon)obj5;
		List<System.__Canon> list = default;
		list._002Ector();
		List<byte> list2 = CosmeticCatalog.IdsOf(b);
		bool flag2 = list2 == null;
		Enumerator<, > val = (Enumerator<, >)0;
		int num3 = default;
		int num2 = num3;
		Enumerator<, > val2 = (Enumerator<, >)0;
		if (flag2)
		{
			goto IL_0871;
		}
		Enumerator<, > enumerator = list2.GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4728]");
		int num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45F0]");
		object obj7 = 0;
		Enumerator<, > val3 = (Enumerator<, >)(ref val2);
		Enumerator<, > val5 = default;
		object obj18;
		Enumerator<, > val4;
		Enumerator<, > val6;
		while (true)
		{
			_Canon = (System.__Canon)((int*)num4)->m_value;
			if (!val2.MoveNext())
			{
				break;
			}
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num3);
			if (entry == null)
			{
				continue;
			}
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v79+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v79+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v54+10]");
			if ((nint)0 != 0)
			{
				_Canon = (System.__Canon)(object)entry.name;
				object obj11 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v54+10]");
				bool flag4 = ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)entry.name);
				bool flag5 = !flag4;
				object obj12 = !flag5;
				if (obj12 != null)
				{
					continue;
				}
				if (list != null)
				{
					System.__Canon[] items = list._items;
					val3 = (Enumerator<, >)obj7;
					int version = list._version + 1;
					list._version = version;
					if (list._items != null)
					{
						version = list._size;
						bool flag6 = list._size < items.Length;
						object obj13 = !flag6;
						if (obj13 == null)
						{
							object obj14 = list._items + list._size;
							val3 = (Enumerator<, >)(list._size + 1);
							list._size = (int)val3;
							object obj15 = obj14 + 32;
							obj15 = entry;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X9_v3 (System.Collections.Generic.LowLevelDictionary`2<System.Byte>+Enumerator<System.Byte>)+20]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v57+A8]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v58+70]");
							obj11 = 0;
							list.AddWithResize((System.__Canon)(object)entry);
						}
						continue;
					}
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			val = (Enumerator<, >)0;
			num2 = 0;
			obj18 = 0;
			val4 = val5;
			val6 = (Enumerator<, >)(ref val2);
			NullReferenceException ex3 = new NullReferenceException();
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_0871;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4720]");
		object obj19 = 0;
		_Canon = (System.__Canon)obj19;
		val2.Dispose();
		val = (Enumerator<, >)0;
		num2 = 0;
		obj18 = 0;
		val2 = val5;
		num4 = 6;
		val4 = val5;
		val6 = (Enumerator<, >)(ref val2);
		goto IL_088e;
		IL_0871:
		NullReferenceException ex5 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_088e;
		IL_088e:
		throw new OutOfMemoryException();
	}

	public unsafe static void EditorGiven(Bundle b)
	{
		//IL_0010: Expected Obj, but got I
		//IL_07db: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Obj, but got I
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got I4
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I4
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got I4
		//IL_0845: Expected Obj, but got I
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected Obj, but got I
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Expected Ref, but got Unknown
		//IL_0a05: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I4
		//IL_04c4: Expected Obj, but got I4
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_0377: Expected Obj, but got I4
		//IL_08c3: Expected Obj, but got I
		//IL_0506: Expected Obj, but got I4
		//IL_05ba: Expected Obj, but got I4
		//IL_06cd: Expected Obj, but got I4
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got I
		//IL_03e9: Expected Obj, but got I4
		//IL_067e: Expected Obj, but got I4
		//IL_053e: Expected Obj, but got I4
		//IL_09a1: Expected Obj, but got I
		//IL_09bb: Expected Obj, but got I
		//IL_05f7: Expected Obj, but got I4
		//IL_092d: Expected Obj, but got I
		//IL_0421: Expected Obj, but got I4
		//IL_0967: Expected Obj, but got I
		//IL_08f8: Expected Obj, but got I
		//IL_0585: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_0468: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		if (b == null)
		{
			return;
		}
		bool flag2 = string.IsNullOrEmpty(b.sku);
		bool flag3 = !flag2;
		object obj4 = !flag3;
		System.__Canon _Canon = null;
		int num2 = default;
		Enumerator<, > val;
		int num;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v88+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v88+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v39+10]");
			bool flag5 = (nint)0 == 0;
			num = num2;
			val = (Enumerator<, >)0;
			_Canon = null;
			if (flag5)
			{
				goto IL_06eb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F8]");
			object obj8 = 0;
			_Canon = (System.__Canon)(object)b.sku;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v39+10]");
			bool flag6 = ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)b.sku);
			bool flag7 = !flag6;
			object obj10 = !flag7;
			if (obj10 != null)
			{
				return;
			}
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v50+E4]");
		bool flag8 = (nint)0 == 0;
		object obj12 = !flag8;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (OwnsAll(b))
		{
			bool flag9 = string.IsNullOrEmpty(b.tag);
			bool flag10 = !flag9;
			object obj13 = !flag10;
			if (obj13 != null)
			{
				return;
			}
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v81+E4]");
			bool flag11 = (nint)0 == 0;
			object obj15 = !flag11;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v81+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v35+10]");
			bool flag12 = (nint)0 == 0;
			num = num2;
			val = (Enumerator<, >)0;
			_Canon = null;
			if (flag12)
			{
				goto IL_06eb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F8]");
			object obj17 = 0;
			_Canon = (System.__Canon)(object)b.tag;
			object obj9 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v35+10]");
			bool flag13 = ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)b.tag);
			bool flag14 = !flag13;
			object obj18 = !flag14;
			if (obj18 != null)
			{
				return;
			}
		}
		List<byte> list = CosmeticCatalog.IdsOf(b);
		bool flag15 = list == null;
		num = num2;
		val = (Enumerator<, >)0;
		if (!flag15)
		{
			Enumerator<, > enumerator = list.GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4728]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
			object obj21 = 0;
			Enumerator<, > val2 = default;
			object obj34 = default;
			while (true)
			{
				_Canon = (System.__Canon)obj19;
				object obj29;
				Enumerator<, > val3;
				Enumerator<, > val4;
				if (val.MoveNext())
				{
					CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num2);
					if (entry == null)
					{
						continue;
					}
					object obj22 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v64+E4]");
					bool flag16 = (nint)0 == 0;
					object obj23 = !flag16;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj22 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v64+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v30+10]");
					if ((nint)0 != 0)
					{
						_Canon = (System.__Canon)(object)entry.name;
						object obj9 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v30+10]");
						bool flag17 = ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)entry.name);
						bool flag18 = !flag17;
						object obj25 = !flag18;
						if (obj25 != null)
						{
							continue;
						}
						object obj26 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v71+E4]");
						bool flag19 = (nint)0 == 0;
						object obj27 = !flag19;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj26 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v71+A0]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v33+10]");
						if ((nint)0 != 0)
						{
							obj9 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v33+10]");
							bool flag20 = ((HashSet<System.__Canon>)0).Add((System.__Canon)(object)entry.name);
							continue;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					NullReferenceException ex2 = new NullReferenceException();
					num = 0;
					obj29 = 0;
					val = val2;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					break;
				}
				num = 0;
				obj29 = 0;
				val = val2;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				object obj30 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4720]");
					object obj31 = 0;
					_Canon = (System.__Canon)obj31;
					((Enumerator<, >*)val4)->Dispose();
					bool flag21 = obj30 == null;
					object obj32 = !flag21;
					if (obj32 == null)
					{
						bool flag22 = num == 0;
						object obj33 = !flag22;
						OutOfMemoryException ex3 = (OutOfMemoryException)val4;
						if (obj33 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)_Canon == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num = 1;
						obj30 = obj29;
						continue;
					}
					if ((nint)_Canon == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj30 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj29 = obj34;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CEFC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				bool flag23 = string.IsNullOrEmpty(b.tag);
				bool flag24 = !flag23;
				object obj35 = !flag24;
				if (obj35 == null)
				{
					object obj36 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v26+E4]");
					bool flag25 = (nint)0 == 0;
					object obj37 = !flag25;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj36 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v26+A0]");
					object obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v16+10]");
					bool flag26 = (nint)0 == 0;
					_Canon = null;
					if (flag26)
					{
						break;
					}
					object obj9 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v16+10]");
					bool flag27 = ((HashSet<System.__Canon>)0).Add((System.__Canon)(object)b.tag);
				}
				bool flag28 = string.IsNullOrEmpty(b.sku);
				bool flag29 = !flag28;
				object obj39 = !flag29;
				System.__Canon _Canon2 = null;
				if (obj39 == null)
				{
					object obj40 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v20+E4]");
					bool flag30 = (nint)0 == 0;
					object obj41 = !flag30;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj40 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v20+A0]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v14+10]");
					bool flag31 = (nint)0 == 0;
					_Canon = null;
					if (flag31)
					{
						break;
					}
					_Canon2 = (System.__Canon)(object)b.sku;
					object obj9 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v14+10]");
					bool flag32 = ((HashSet<System.__Canon>)0).Add((System.__Canon)(object)b.sku);
				}
				object obj43 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v16+E4]");
				bool flag33 = (nint)0 == 0;
				object obj44 = !flag33;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj43 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v16+A0]");
				object obj45 = 0;
				int coins = b.coins;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v12+4]");
				object obj46 = (nint)coins + (nint)0;
				Save();
				return;
			}
		}
		goto IL_06eb;
		IL_06eb:
		throw new NullReferenceException();
	}

	public unsafe static bool Buy(IEnumerable<byte> ids, int price = default(int))
	{
		//IL_0010: Expected Obj, but got I
		//IL_1106: Expected Obj, but got I
		//IL_1128: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected I, but got Obj
		//IL_0188: Expected I, but got Obj
		//IL_11b5: Expected Obj, but got I
		//IL_115d: Expected Obj, but got I4
		//IL_1177: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_02f7: Expected I, but got Obj
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_124c: Expected Obj, but got I
		//IL_125f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1264: Expected Obj, but got Unknown
		//IL_0886: Expected Obj, but got Ref
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fe: Expected Obj, but got I4
		//IL_120e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1213: Expected Obj, but got Unknown
		//IL_140a: Expected Obj, but got I4
		//IL_1410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I4
		//IL_09c3: Expected Obj, but got I4
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Expected I, but got Obj
		//IL_1463: Expected Obj, but got I
		//IL_045a: Expected I, but got Obj
		//IL_09fd: Expected I4, but got I8
		//IL_0a17: Expected Obj, but got I4
		//IL_12ff: Expected Obj, but got I
		//IL_1312: Unknown result type (might be due to invalid IL or missing references)
		//IL_1317: Expected I4, but got Unknown
		//IL_10d9: Expected Obj, but got I4
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Expected Obj, but got Unknown
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected Obj, but got Unknown
		//IL_05c0: Expected Obj, but got I4
		//IL_12b1: Expected Obj, but got I4
		//IL_12c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c6: Expected Obj, but got Unknown
		//IL_1649: Expected Obj, but got I
		//IL_1674: Expected Obj, but got I4
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Invalid comparison between Unknown and I4
		//IL_04cb: Expected Obj, but got I4
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		//IL_1351: Expected Obj, but got I
		//IL_03eb: Expected Obj, but got I4
		//IL_03f9: Expected Obj, but got I4
		//IL_0d8e: Expected Obj, but got I4
		//IL_0d96: Expected Obj, but got Ref
		//IL_0a67: Expected Obj, but got I4
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected I4, but got Unknown
		//IL_0ad0: Expected Obj, but got I4
		//IL_0b79: Expected Obj, but got I4
		//IL_0505: Expected I, but got Obj
		//IL_051f: Expected Obj, but got I
		//IL_053d: Expected Obj, but got I4
		//IL_1491: Expected Obj, but got I4
		//IL_0e1b: Expected Obj, but got I4
		//IL_0c09: Expected Obj, but got I4
		//IL_0e4d: Expected Obj, but got I
		//IL_0e77: Expected Obj, but got I4
		//IL_0ddb: Expected Obj, but got I4
		//IL_14b4: Expected Obj, but got I
		//IL_14ce: Expected Obj, but got I4
		//IL_155a: Expected Obj, but got I
		//IL_156a: Expected Obj, but got I
		//IL_158c: Expected Obj, but got I4
		//IL_1687: Unknown result type (might be due to invalid IL or missing references)
		//IL_168c: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a0: Expected Obj, but got I
		//IL_16b0: Expected Obj, but got I
		//IL_0570: Expected I, but got Obj
		//IL_0c50: Expected Obj, but got I4
		//IL_05f0: Expected I4, but got Obj
		//IL_0ebe: Expected Obj, but got I4
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6e: Expected Obj, but got I4
		//IL_14f1: Expected Obj, but got I
		//IL_0f20: Expected Obj, but got I
		//IL_0f41: Expected Obj, but got I
		//IL_0f6b: Expected Obj, but got I4
		//IL_15a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c4: Expected Obj, but got I
		//IL_15d5: Expected I, but got Obj
		//IL_15f3: Expected Obj, but got I
		//IL_160d: Expected I, but got Obj
		//IL_0caf: Expected Obj, but got I4
		//IL_0c80: Expected Obj, but got I
		//IL_0667: Expected Obj, but got I4
		//IL_067b: Expected Obj, but got I4
		//IL_0eee: Expected Obj, but got I
		//IL_0711: Expected Obj, but got I
		//IL_0721: Expected Obj, but got I
		//IL_0777: Expected Obj, but got I4
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected Obj, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected Obj, but got Unknown
		//IL_0fbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce4: Expected Obj, but got I
		//IL_0d11: Expected I, but got Obj
		//IL_0d2e: Expected Obj, but got I
		//IL_0d2e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45E0]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		System.__Canon _Canon = (System.__Canon)obj3;
		List<System.__Canon> list = default;
		list._002Ector();
		bool flag2 = ids == null;
		object obj5 = 0;
		Enumerator<, > val = (Enumerator<, >)0;
		if (flag2)
		{
			goto IL_0fe6;
		}
		nint num2 = (nint)ids;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4790]");
		int num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Byte>>)+12E]");
		int num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Byte>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0179;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Byte>>)+98]");
		int num5 = (int)((nint)0 + (nint)8);
		bool flag4 = default;
		bool flag3 = flag4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X10_v46 (System.Int32)-8]");
			bool flag5 = (nint)0 < (nint)((int*)num3)->m_value;
			object obj6 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X10_v46 (System.Int32)-8]");
			object obj7 = -((int*)num3)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X10_v46 (System.Int32)-8]");
			if ((nint)0 == ((int*)num3)->m_value)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Byte>>)+12E]");
			num4 = (int)(-1);
			bool flag6 = num4 < 1;
			obj6 = !flag6;
			obj7 = num4 - 1;
			bool flag7 = obj7 == null;
			num3 = num5 + 16;
			flag4 = num4 != 1;
			flag3 = flag4;
			num5 = num3;
			if (flag4)
			{
				continue;
			}
			goto IL_0179;
		}
		num4 = ((int*)num5)->m_value;
		object obj8 = num2 + ((int*)num5)->m_value;
		object obj9 = obj8 + 312;
		flag4 = flag3;
		num3 = num5;
		goto IL_11a5;
		IL_07ca:
		NullReferenceException ex = new NullReferenceException();
		bool flag8;
		object obj10 = default;
		OutOfMemoryException ex3;
		NullReferenceException ex2;
		Enumerator<, > val2;
		bool flag10;
		if ((nint)_Canon == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			ex2 = null;
			flag8 = true;
		}
		else
		{
			bool flag9 = (nint)_Canon != 1;
			obj5 = obj10;
			val = (Enumerator<, >)0;
			ex2 = null;
			flag10 = false;
			val2 = (Enumerator<, >)num4;
			ex3 = (OutOfMemoryException)(object)ex;
			if (flag9)
			{
				goto IL_13e1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj11 = default;
			ex2 = (NullReferenceException)obj11;
			flag8 = false;
		}
		goto IL_087e;
		IL_13b3:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_07ca;
		IL_13e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		NullReferenceException ex5;
		object obj12 = default;
		OutOfMemoryException ex6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			if ((nint)_Canon == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				flag10 = true;
				ex5 = ex2;
				break;
			}
			if ((nint)_Canon == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				ex5 = (NullReferenceException)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex2 = (NullReferenceException)obj12;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF38");
			ex3 = ex6;
		}
		object obj13 = 0;
		goto IL_1639;
		IL_087e:
		object obj14 = (object)(&obj5);
		object obj15 = obj14;
		bool flag11 = obj14 == null;
		val2 = (Enumerator<, >)num4;
		if (flag11)
		{
			goto IL_13f0;
		}
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v62+12E]");
		val2 = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v62+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0967;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v62+98]");
		int num6 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X10_v21 (System.Int32)-8]");
			if ((nint)0 == ((int*)num3)->m_value)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v62+12E]");
			val2 = (Enumerator<, >)(-1);
			num3 = num6 + 16;
			bool flag12 = (int)val2 != 1;
			num6 = num3;
			if (flag12)
			{
				continue;
			}
			goto IL_0967;
		}
		val2 = (Enumerator<, >)((int*)num6)->m_value;
		object obj17 = obj16 + ((int*)num6)->m_value;
		object obj18 = obj17 + 312;
		goto IL_1453;
		IL_0fe6:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0ff4;
		IL_0967:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		nint num7 = unchecked((nint)null);
		goto IL_1453;
		IL_149f:
		bool result;
		return result;
		IL_0179:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num7 = unchecked((nint)null);
		goto IL_11a5;
		IL_11a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v56+8]");
		_Canon = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v404 @ X0_v56] (should have been resolved before IL gen)");
		if (obj10 == null)
		{
			goto IL_07bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4798]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45F0]");
		object obj23 = 0;
		num = 0;
		object obj24 = obj10;
		object obj28 = default;
		object obj40 = default;
		while (true)
		{
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v71+12E]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v71+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02e8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v71+98]");
			int num8 = (int)((nint)0 + (nint)8);
			bool flag13 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X10_v41 (System.Int32)-8]");
				bool flag14 = 0 < (nint)obj19;
				object obj6 = !flag14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X10_v41 (System.Int32)-8]");
				object obj7 = 0 - obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X10_v41 (System.Int32)-8]");
				if (0 == (nint)obj19)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v71+12E]");
				num4 = (int)(-1);
				bool flag15 = num4 < 1;
				obj6 = !flag15;
				obj7 = num4 - 1;
				bool flag7 = obj7 == null;
				num3 = num8 + 16;
				flag4 = num4 != 1;
				flag13 = flag4;
				num8 = num3;
				if (flag4)
				{
					continue;
				}
				goto IL_02e8;
			}
			num4 = ((int*)num8)->m_value;
			object obj26 = obj25 + ((int*)num8)->m_value;
			object obj27 = obj26 + 312;
			flag4 = flag13;
			num3 = num8;
			goto IL_123c;
			IL_044b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num7 = unchecked((nint)null);
			goto IL_12ef;
			IL_07a0:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_07ae;
			IL_12ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X0_v113+8]");
			_Canon = (System.__Canon)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1038 @ X0_v113] (should have been resolved before IL gen)");
			int id = obj28 & 0xFF;
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id);
			if (entry != null)
			{
				object obj29 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ X0_v120+E4]");
				bool flag16 = (nint)0 == 0;
				object obj30 = !flag16;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj29 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ X0_v120+A0]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v81+10]");
				if ((nint)0 == 0)
				{
					goto IL_07a0;
				}
				_Canon = (System.__Canon)(object)entry.name;
				num7 = (nint)obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v81+10]");
				bool flag17 = ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)entry.name);
				bool flag18 = !flag17;
				object obj32 = !flag18;
				if (obj32 == null)
				{
					if (list == null)
					{
						goto IL_07ae;
					}
					num7 = (nint)obj22;
					bool flag19 = list.Contains((System.__Canon)(object)entry);
					bool flag20 = !flag19;
					_Canon = (System.__Canon)(object)entry;
					if (flag20)
					{
						System.__Canon[] items = list._items;
						num4 = (int)obj23;
						num3 = list._version + 1;
						list._version = num3;
						bool flag21 = list._items == null;
						_Canon = (System.__Canon)(object)entry;
						if (flag21)
						{
							goto IL_07ca;
						}
						num3 = list._size;
						bool flag22 = list._size < items.Length;
						object obj6 = !flag22;
						object obj7 = list._size - items.Length;
						bool flag7 = obj7 == null;
						if (obj6 == null)
						{
							object obj33 = list._items + list._size;
							num4 = ++list._size;
							object obj34 = obj33 + 32;
							obj34 = entry;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_Canon = (System.__Canon)(object)entry;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v41 (System.Int32)+20]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1344 @ X8_v85+A8]");
							object obj36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1345 @ X8_v86+70]");
							num7 = 0;
							list.AddWithResize((System.__Canon)(object)entry);
							_Canon = (System.__Canon)(object)entry;
						}
						num = entry.price + num;
						bool flag23 = obj10 == null;
						object obj37 = !flag23;
						obj24 = obj10;
						if (obj37 != null)
						{
							continue;
						}
						goto IL_13b3;
					}
				}
			}
			bool flag24 = obj10 == null;
			object obj38 = !flag24;
			obj24 = obj10;
			if (obj38 != null)
			{
				continue;
			}
			goto IL_13b3;
			IL_02e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num7 = unchecked((nint)null);
			goto IL_123c;
			IL_123c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v105+8]");
			_Canon = (System.__Canon)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v782 @ X0_v105] (should have been resolved before IL gen)");
			object obj39 = obj40 & 1;
			bool flag25 = obj39 == null;
			ex2 = null;
			flag8 = false;
			if (flag25)
			{
				break;
			}
			if (obj10 != null)
			{
				object obj41 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v76+12E]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v76+12E]");
				if ((nint)0 == 0)
				{
					goto IL_044b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v76+98]");
				int num9 = (int)((nint)0 + (nint)8);
				bool flag26 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X10_v36 (System.Int32)-8]");
					bool flag27 = 0 < (nint)obj20;
					object obj6 = !flag27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X10_v36 (System.Int32)-8]");
					object obj7 = 0 - obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X10_v36 (System.Int32)-8]");
					if (0 == (nint)obj20)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v76+12E]");
					num4 = (int)(-1);
					bool flag28 = num4 < 1;
					obj6 = !flag28;
					obj7 = num4 - 1;
					bool flag7 = obj7 == null;
					num3 = num9 + 16;
					flag4 = num4 != 1;
					flag26 = flag4;
					num9 = num3;
					if (flag4)
					{
						continue;
					}
					goto IL_044b;
				}
				num4 = ((int*)num9)->m_value;
				object obj42 = obj41 + ((int*)num9)->m_value;
				object obj43 = obj42 + 312;
				flag4 = flag26;
				num3 = num9;
				goto IL_12ef;
			}
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_07a0;
			IL_07ae:
			NullReferenceException ex10 = new NullReferenceException();
			goto IL_07bc;
		}
		goto IL_087e;
		IL_1003:
		throw new OutOfMemoryException();
		IL_0f96:
		result = true;
		goto IL_149f;
		IL_1453:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v89+8]");
		_Canon = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1049 @ X0_v89] (should have been resolved before IL gen)");
		goto IL_13f0;
		IL_1639:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4760]");
		object obj44 = 0;
		_Canon = (System.__Canon)obj44;
		val.Dispose();
		bool flag29 = ex5 == null;
		object obj45 = !flag29;
		if (obj45 == null)
		{
			bool flag30 = !flag10;
			object obj46 = !flag30;
			ex7 = (NullReferenceException)(&val);
			if (obj46 == null)
			{
				if ((nint)obj13 != 11)
				{
					bool flag31 = obj13 == null;
					object obj47 = !flag31;
					result = flag10;
					if (obj47 != null)
					{
						goto IL_149f;
					}
				}
				object obj48 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ X0_v9+E4]");
				bool flag32 = (nint)0 == 0;
				object obj49 = !flag32;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Save();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47B8]");
				obj = 0;
				object obj50 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ X0_v11+E4]");
				bool flag33 = (nint)0 == 0;
				object obj51 = !flag33;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj50 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ X0_v11+A0]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X8_v17+8]");
				Converter<System.__Canon, System.__Canon> converter = (Converter<System.__Canon, System.__Canon>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X8_v17+8]");
				bool flag34 = (nint)0 == 0;
				object obj53 = !flag34;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ X0_v11+E4]");
					bool flag35 = (nint)0 == 0;
					object obj54 = !flag35;
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj55 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1353 @ X8_v21+A0]");
						obj52 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4788]");
					val2 = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47B0]");
					object obj56 = 0;
					Converter<System.__Canon, System.__Canon> converter2 = default;
					converter2._002Ector(obj52, (IntPtr)obj56);
					object obj57 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1323 @ X8_v20+A0]");
					object obj58 = (nint)0 + (nint)8;
					obj58 = converter2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num7 = (nint)obj56;
					_Canon = (System.__Canon)(object)converter2;
					converter = converter2;
				}
				if (list != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47A8]");
					object obj59 = 0;
					List<System.__Canon> names = list.ConvertAll(converter);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
					object obj60 = 0;
					object obj61 = obj60;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X8_v16+E4]");
					bool flag36 = (nint)0 == 0;
					object obj62 = !flag36;
					if (obj62 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaCloud.Bought((List<string>)(object)names);
					goto IL_0f96;
				}
				goto IL_0fe6;
			}
			goto IL_0ff4;
		}
		OutOfMemoryException ex11 = new OutOfMemoryException();
		ex3 = ex11;
		goto IL_13e1;
		IL_0b4f:
		object obj63 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X0_v65+E4]");
		bool flag37 = (nint)0 == 0;
		object obj64 = !flag37;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num10 = Balance;
		if (num > num10)
		{
			bool flag38 = list._size == 0;
			result = flag38;
			goto IL_149f;
		}
		object obj65 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1257 @ X0_v68+E4]");
		bool flag39 = (nint)0 == 0;
		object obj66 = !flag39;
		if (obj66 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj65 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1257 @ X0_v68+A0]");
		object obj67 = 0;
		bool flag40 = obj67 == null;
		object obj68 = !flag40;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1257 @ X0_v68+E4]");
			bool flag41 = (nint)0 == 0;
			object obj69 = !flag41;
			if (obj69 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj70 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X8_v56+A0]");
				obj67 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1275 @ X8_v55+4]");
			object obj71 = -num;
		}
		Enumerator<, > enumerator = list.GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4768]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
		object obj73 = 0;
		Enumerator<, > val3 = default;
		Enumerator<, > val4;
		while (true)
		{
			_Canon = (System.__Canon)obj72;
			if (!val.MoveNext())
			{
				break;
			}
			object obj74 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1363 @ X0_v76+E4]");
			bool flag42 = (nint)0 == 0;
			object obj75 = !flag42;
			if (obj75 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj74 = obj;
			}
			if (flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1363 @ X0_v76+A0]");
				object obj76 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1311 @ X8_v54+10]");
				if ((nint)0 != 0)
				{
					num7 = (nint)obj73;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1311 @ X8_v54+10]");
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-88_v12 (System.Boolean)+10]");
					bool flag43 = ((HashSet<System.__Canon>)num11).Add((System.__Canon)0);
					continue;
				}
			}
			else
			{
				NullReferenceException ex12 = new NullReferenceException();
			}
			NullReferenceException ex13 = new NullReferenceException();
			val = val3;
			val4 = val3;
			ex2 = null;
			flag10 = false;
			val2 = (Enumerator<, >)(ref val);
			goto IL_0fe6;
		}
		Enumerator<, > val5 = (Enumerator<, >)(ref val);
		val = val3;
		val4 = val3;
		ex2 = null;
		flag10 = false;
		val2 = (Enumerator<, >)(ref val);
		obj13 = 11;
		ex5 = null;
		goto IL_1639;
		IL_13f0:
		bool flag44 = ex2 == null;
		object obj77 = !flag44;
		val = (Enumerator<, >)0;
		flag10 = flag8;
		if (obj77 == null)
		{
			bool flag45 = !flag8;
			object obj78 = !flag45;
			val = (Enumerator<, >)0;
			flag10 = flag8;
			ex7 = ex2;
			if (obj78 == null)
			{
				int num12 = (int)(price & 0x80000000L);
				bool flag46 = num12 == 0;
				object obj79 = !flag46;
				if (obj79 == null)
				{
					bool flag47 = list == null;
					val = (Enumerator<, >)0;
					flag10 = flag8;
					if (!flag47)
					{
						object obj80 = list._size - 1;
						bool flag48 = (nint)obj80 < 0;
						int num13 = list._size ^ 1;
						int num14 = list._size ^ obj80;
						int num15 = num13 & num14;
						bool flag49 = num15 < 0;
						bool flag50 = flag48 == flag49;
						object obj81 = !flag50;
						object obj82 = ~obj81;
						if (obj82 != null)
						{
							num = price;
						}
						bool flag51 = list._size == 0;
						object obj83 = !flag51;
						if (obj83 != null)
						{
							goto IL_0b4f;
						}
						goto IL_0f96;
					}
				}
				else
				{
					bool flag52 = list == null;
					val = (Enumerator<, >)0;
					flag10 = flag8;
					if (!flag52)
					{
						if (list._size != 0)
						{
							goto IL_0b4f;
						}
						goto IL_0f96;
					}
				}
				goto IL_0fe6;
			}
			goto IL_0ff4;
		}
		goto IL_1003;
		IL_0ff4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_1003;
		IL_07bc:
		num = 0;
		goto IL_13b3;
	}

	public static void Add(int amount)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
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
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+4]");
		object obj6 = (nint)0 + (nint)amount;
		object obj7 = ~obj6;
		object obj8 = obj6 & obj7;
		Save();
	}

	public static void Adopt(int coins, string[] names, int boltCount = default(int))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I
		//IL_006e: Expected I4, but got I8
		//IL_0088: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I4
		//IL_02af: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Load();
		object obj4 = obj;
		int num = ~coins;
		int num2 = coins & num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+A0]");
		object obj5 = 0;
		int num4 = default;
		int num3 = (int)(num4 & 0x80000000L);
		bool flag2 = num3 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+A0]");
				obj5 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47C0]");
		object obj10 = 0;
		IEnumerable<System.__Canon> enumerable = (IEnumerable<System.__Canon>)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v7+10]");
		((HashSet<System.__Canon>)0).Clear();
		if (names != null)
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v15+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47C8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v14+10]");
			((HashSet<System.__Canon>)0).UnionWith((IEnumerable<System.__Canon>)(object)names);
			enumerable = (IEnumerable<System.__Canon>)(object)names;
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v12+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Save();
	}

	private static void Load()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I
		//IL_03ed: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_02b5: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I
		//IL_0334: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got I4
		//IL_036f: Expected Obj, but got I
		//IL_01eb: Expected I4, but got Obj
		//IL_0208: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v6+1]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v21+A0]");
			obj4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46D0]");
		object key = 0;
		_ = 1;
		int num = PlayerPrefs.GetInt((string)key, 500);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C8]");
		object key2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v7+A0]");
		object obj9 = 0;
		int num2 = PlayerPrefs.GetInt((string)key2, 0);
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46D8]");
		object key3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object defaultValue = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v9+A0]");
		object obj11 = 0;
		string text = PlayerPrefs.GetString((string)key3, (string)defaultValue);
		if (text != null)
		{
			string[] array = text.Split(',', (StringSplitOptions)0);
			if (array != null)
			{
				object obj12 = array.Length;
				if (array.Length < 1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
				object obj13 = 0;
				object obj14 = 0;
				StringSplitOptions stringSplitOptions = (StringSplitOptions)0;
				char c = ',';
				while (true)
				{
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
					object obj15 = !flag4;
					if (obj15 != null)
					{
						break;
					}
					object obj16 = (object)array + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v15+20]");
					System.__Canon _Canon = (System.__Canon)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v15+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X20_v6 (System.__Canon)+10]");
						if ((nint)0 >= (nint)1)
						{
							object obj17 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v20+E4]");
							bool flag5 = (nint)0 == 0;
							object obj18 = !flag5;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj17 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v20+A0]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v20+10]");
							if ((nint)0 == 0)
							{
								goto IL_0258;
							}
							stringSplitOptions = (StringSplitOptions)obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v20+10]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v15+20]");
							bool flag6 = ((HashSet<System.__Canon>)num3).Add((System.__Canon)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v15+20]");
							c = '\0';
						}
						obj12 = array.Length;
						obj14++;
						if ((nint)obj14 >= array.Length)
						{
							return;
						}
						continue;
					}
					goto IL_0258;
				}
				goto IL_0266;
			}
		}
		goto IL_0258;
		IL_0258:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0266;
		IL_0266:
		throw new IndexOutOfRangeException();
	}

	private static void Save()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46D0]");
		object key = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C8]");
		object key2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A0]");
		object separator = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46D8]");
		object key3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+4]");
		PlayerPrefs.SetInt((string)key, 0);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+8]");
		PlayerPrefs.SetInt((string)key2, 0);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v7+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v8+10]");
		string value = string.Join((string)separator, (IEnumerable<string>)0);
		PlayerPrefs.SetString((string)key3, value);
		PlayerPrefs.Save();
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v10+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v11+18]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v11+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v12+40]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v12+28]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v12+18]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v98 @ X2_v5 (should have been resolved before IL gen)");
		}
	}

	static Coins()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_0048: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D0]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+A0]");
		object obj6 = (nint)0 + (nint)16;
		obj6 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
