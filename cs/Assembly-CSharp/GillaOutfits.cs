using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class GillaOutfits
{
	private struct Spot
	{
		public float time;

		public Vector3 feet;

		public float tall;

		public Vector3 facing;
	}

	[Serializable]
	public class Outfit
	{
		public string[] names;

		public int colour;

		public int title;

		public Outfit()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			//IL_004c: Expected I4, but got I8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj2 = this + 16;
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			colour = -1;
			base._002Ector();
		}
	}

	public const int MostSaved = default(int);

	private const string Key = null;

	private static List<Outfit> saved;

	public static int Count
	{
		get
		{
			//IL_001d: Expected I4, but got Obj
			List<Outfit> list = Load();
			if (list != null)
			{
				return list._size;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public static Outfit At(int i)
	{
		//IL_00cd: Expected I4, but got I8
		//IL_00e7: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		int num2 = default;
		int num = (int)(num2 & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			List<Outfit> list = Load();
			if (list != null)
			{
				if (list._size <= num2)
				{
					goto IL_00ab;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57D8]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v8+A0]");
				object obj4 = 0;
				if (obj4 != null)
				{
					return (Outfit)(object)((List<System.__Canon>)obj4).get_Item(num2);
				}
			}
			return (Outfit)(object)new NullReferenceException();
		}
		goto IL_00ab;
		IL_00ab:
		return null;
	}

	public static bool Save()
	{
		//IL_0206: Expected I4, but got Obj
		//IL_018a: Expected Obj, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected I4, but got Unknown
		//IL_0037: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		List<Outfit> list = Load();
		if (list != null)
		{
			if (list._size > 7)
			{
				goto IL_0177;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57D8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+A0]");
			object obj3 = 0;
			List<System.__Canon> list2 = (List<System.__Canon>)obj3;
			Outfit outfit = Now();
			if (obj3 != null)
			{
				System.__Canon[] items = list2._items;
				int version = list2._version + 1;
				list2._version = version;
				if (list2._items != null)
				{
					bool flag = list2._size < items.Length;
					object obj4 = !flag;
					if (obj4 == null)
					{
						object obj5 = list2._items + list2._size;
						int size = list2._size + 1;
						list2._size = size;
						object obj6 = obj5 + 32;
						obj6 = outfit;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					else
					{
						((List<System.__Canon>)obj3).AddWithResize((System.__Canon)(object)outfit);
					}
					Store();
					goto IL_0177;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0177:
		object obj7 = list._size - 8;
		bool flag2 = (nint)obj7 < 0;
		int num = list._size ^ 8;
		int num2 = list._size ^ obj7;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag2 == flag3;
		return !flag4;
	}

	public static void Delete(int i)
	{
		//IL_0090: Expected I4, but got I8
		//IL_00aa: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I
		int num2 = default;
		int num = (int)(num2 & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			List<Outfit> list = Load();
			if (list._size > num2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57D8]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v8+A0]");
				object obj4 = 0;
				((List<System.__Canon>)obj4).RemoveAt(num2);
				Store();
			}
		}
	}

	public static void Wear(int i)
	{
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_05ce: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_0148: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I4
		//IL_00d5: Expected I, but got Obj
		//IL_0180: Expected Obj, but got I4
		//IL_01f5: Expected I4, but got I8
		//IL_020f: Expected Obj, but got I4
		//IL_01ab: Expected I, but got Obj
		//IL_0329: Expected Obj, but got I4
		//IL_0372: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I
		//IL_0257: Expected Obj, but got I4
		//IL_03cd: Expected Obj, but got I4
		//IL_0606: Expected Obj, but got I4
		//IL_0624: Expected Obj, but got I
		//IL_0410: Expected I4, but got I8
		//IL_042a: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got I4
		//IL_0448: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I4
		//IL_02fa: Expected I, but got Obj
		//IL_04e3: Expected Obj, but got I4
		//IL_051e: Expected Obj, but got I
		//IL_0548: Expected Obj, but got I4
		//IL_056f: Expected I, but got Obj
		Outfit outfit = At(i);
		if (outfit == null)
		{
			return;
		}
		byte[] array = IdsOf(outfit);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj2 = 0;
		object obj3 = array + 32;
		CosmeticSlot cosmeticSlot = (CosmeticSlot)0;
		while (true)
		{
			bool flag = (int)cosmeticSlot < array.Length;
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X25_v4+v186 @ X21_v5 (CosmeticSlot)]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X25_v4+v186 @ X21_v5 (CosmeticSlot)]");
				Cosmetics.Wear(0);
				nint num = unchecked((nint)null);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				byte b = Cosmetics.In(cosmeticSlot);
				int num2 = b & 0xFF;
				bool flag4 = num2 == 0;
				nint num = unchecked((nint)null);
				if (!flag4)
				{
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v53+E4]");
					bool flag5 = (nint)0 == 0;
					object obj9 = !flag5;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cosmetics.TakeOff(cosmeticSlot);
					num = unchecked((nint)null);
				}
			}
			cosmeticSlot++;
			if (cosmeticSlot != (CosmeticSlot)8)
			{
				continue;
			}
			int num3 = (int)(outfit.colour & 0x80000000L);
			bool flag6 = num3 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F78]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v22+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj14 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v26+E4]");
				bool flag8 = (nint)0 == 0;
				object obj15 = !flag8;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj14 = obj11;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v26+A0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
					object obj17 = 0;
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v40+E4]");
					bool flag9 = (nint)0 == 0;
					object obj19 = !flag9;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaComputer.Disguise(outfit.colour);
					nint num = unchecked((nint)null);
				}
				else
				{
					int num4 = (int)(outfit.colour & 0x80000000L);
					bool flag10 = num4 == 0;
					object obj20 = !flag10;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
						object obj21 = 0;
						object obj22 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v27+E4]");
						bool flag11 = (nint)0 == 0;
						object obj23 = !flag11;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int codeNow = GillaComputer.CodeNow;
						if (outfit.colour != codeNow)
						{
							object obj24 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v31+E4]");
							bool flag12 = (nint)0 == 0;
							object obj25 = !flag12;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GillaComputer.Adopt(outfit.colour);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
							object obj26 = 0;
							object obj27 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v34+E4]");
							bool flag13 = (nint)0 == 0;
							object obj28 = !flag13;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GillaCloud.ProfileChanged();
							nint num = unchecked((nint)null);
						}
					}
				}
			}
			object obj29 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v13+E4]");
			bool flag14 = (nint)0 == 0;
			object obj30 = !flag14;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag15 = NameTitles.MayWear(outfit.title);
			bool flag16 = !flag15;
			object obj31 = !flag16;
			if (obj31 != null || outfit.title == 0)
			{
				object obj32 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v17+E4]");
				bool flag17 = (nint)0 == 0;
				object obj33 = !flag17;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				NameTitles.Wear(outfit.title);
			}
			return;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static bool IsOn(int i)
	{
		//IL_021e: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_025b: Expected Obj, but got I4
		//IL_01fa: Expected I4, but got Obj
		//IL_0092: Expected Obj, but got I4
		//IL_010c: Expected I4, but got I8
		//IL_0126: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		Outfit outfit = At(i);
		bool flag = outfit == null;
		bool result = (byte)(int)outfit != 0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			object obj = 0;
			byte[] array = IdsOf(outfit);
			object obj2 = array + 32;
			CosmeticSlot cosmeticSlot = (CosmeticSlot)0;
			while (true)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				byte b = Cosmetics.In(cosmeticSlot);
				if (array != null)
				{
					bool flag3 = (int)cosmeticSlot < array.Length;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X23_v3+v100 @ X21_v4 (CosmeticSlot)]");
						if ((nint)0 == (int)b)
						{
							cosmeticSlot++;
							if (cosmeticSlot != (CosmeticSlot)8)
							{
								continue;
							}
							int num = (int)(outfit.colour & 0x80000000L);
							bool flag4 = num == 0;
							object obj6 = !flag4;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
								object obj7 = 0;
								object obj8 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v16+E4]");
								bool flag5 = (nint)0 == 0;
								object obj9 = !flag5;
								if (obj9 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								int codeNow = GillaComputer.CodeNow;
								object obj10 = outfit.colour - codeNow;
								bool flag6 = obj10 == null;
								result = flag6;
							}
							else
							{
								result = true;
							}
							break;
						}
						result = false;
						break;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				return (byte)(int)ex2 != 0;
			}
		}
		return result;
	}

	public static byte[] IdsOf(Outfit o)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I8
		//IL_0087: Expected Obj, but got I
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		CosmeticCatalog.Entry entry = (CosmeticCatalog.Entry)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		byte[] array = default;
		if (o != null)
		{
			string[] names = o.names;
			if (o.names != null)
			{
				if (names.Length < 1)
				{
					goto IL_01d2;
				}
				object obj = names.Length & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
				object obj2 = 0;
				object obj3 = o.names + 32;
				object obj4 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
					object obj5 = !flag;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X25_v4+v65 @ X23_v5*8]");
						byte b = CosmeticCatalog.IdOf((string)0);
						int id = b & 0xFF;
						CosmeticCatalog.Entry entry2 = CosmeticCatalog.Of(id);
						if (entry2 != null)
						{
							object obj6 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v16+E4]");
							bool flag2 = (nint)0 == 0;
							object obj7 = !flag2;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (Coins.Owns(b))
							{
								if (array == null)
								{
									break;
								}
								bool flag3 = (int)entry2.slot < array.Length;
								object obj8 = !flag3;
								if (obj8 != null)
								{
									goto IL_01d7;
								}
								object obj9 = array + entry2.slot;
							}
						}
						obj = names.Length;
						obj4++;
						if ((nint)obj4 < names.Length)
						{
							continue;
						}
						goto IL_01d2;
					}
					goto IL_01d7;
					IL_01d7:
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
					break;
				}
			}
		}
		return (byte[])(object)new NullReferenceException();
		IL_01d2:
		return array;
	}

	public static byte FaceOf(Outfit o)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0114: Expected I4, but got Obj
		//IL_0053: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BC8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5850]");
		object obj2 = 0;
		byte[] array = IdsOf(o);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+18]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X9_v1+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_00ea;
		}
		object obj6 = default;
		object obj5 = obj6 + 32;
		byte result;
		while (true)
		{
			if (array != null)
			{
				bool flag = (nint)obj5 < array.Length;
				object obj7 = !flag;
				if (obj7 == null)
				{
					object obj8 = (object)array + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X10_v6+20]");
					result = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X10_v6+20]");
					bool flag2 = (nint)0 == 0;
					object obj9 = !flag2;
					if (obj9 != null)
					{
						break;
					}
					obj4--;
					obj5 += 4;
					if ((nint)obj4 != 1)
					{
						continue;
					}
					goto IL_00ea;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2;
		}
		goto IL_017a;
		IL_00ea:
		result = 0;
		goto IL_017a;
		IL_017a:
		return result;
	}

	private static Outfit Now()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0354: Expected Obj, but got I
		//IL_0364: Expected Obj, but got I
		//IL_0374: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I
		//IL_0395: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I4
		//IL_00c2: Expected I4, but got Obj
		//IL_0124: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_02fe: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4460]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5830]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		System.__Canon _Canon = (System.__Canon)obj2;
		List<System.__Canon> list = default;
		list._002Ector();
		CosmeticSlot cosmeticSlot = (CosmeticSlot)0;
		Outfit outfit = default;
		while (true)
		{
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			byte b = Cosmetics.In(cosmeticSlot);
			int id = b & 0xFF;
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id);
			bool flag2 = entry == null;
			_Canon = null;
			if (!flag2)
			{
				if (list == null)
				{
					break;
				}
				System.__Canon[] items = list._items;
				_Canon = (System.__Canon)(object)entry.name;
				int num = (int)obj4;
				int version = list._version + 1;
				list._version = version;
				if (list._items == null)
				{
					break;
				}
				bool flag3 = list._size < items.Length;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					object obj11 = list._items + list._size;
					num = list._size + 1;
					list._size = num;
					object obj12 = obj11 + 32;
					obj12 = entry.name;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X9_v3 (System.Int32)+20]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v11+A8]");
					object obj14 = 0;
					list.AddWithResize((System.__Canon)(object)entry.name);
				}
			}
			cosmeticSlot++;
			if (cosmeticSlot == (CosmeticSlot)8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				outfit._002Ector();
				if (list == null)
				{
					break;
				}
				System.__Canon[] array = list.ToArray();
				if (outfit == null)
				{
					break;
				}
				object obj15 = outfit + 16;
				obj15 = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj16 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v21+E4]");
				bool flag4 = (nint)0 == 0;
				object obj17 = !flag4;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int codeNow = GillaComputer.CodeNow;
				object obj18 = obj7;
				outfit.colour = codeNow;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v8+E4]");
				bool flag5 = (nint)0 == 0;
				object obj19 = !flag5;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int worn = NameTitles.Worn;
				outfit.title = worn;
				return outfit;
			}
		}
		return (Outfit)(object)new NullReferenceException();
	}

	private static List<Outfit> Load()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0507: Expected Obj, but got I
		//IL_0529: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I8
		//IL_016c: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_0550: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_01e6: Expected Obj, but got I
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_04a2: Expected Obj, but got I4
		//IL_0245: Expected I4, but got Obj
		//IL_04c4: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I4
		//IL_0329: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I
		//IL_0349: Expected Obj, but got I
		//IL_035e: Expected Obj, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_030a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3+A0]");
		object obj3 = 0;
		List<Outfit> result = (List<Outfit>)obj3;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57F8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<System.__Canon> list = default;
			list._002Ector();
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10+A0]");
			object obj7 = 0;
			obj7 = list;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5808]");
			object key = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5800]");
			System.__Canon[] defaultValue = (System.__Canon[])0;
			string json = PlayerPrefs.GetString((string)key, (string)(object)defaultValue);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57E0]");
			object obj9 = 0;
			System.__Canon _Canon = (System.__Canon)obj9;
			System.__Canon _Canon2 = JsonUtility.FromJson<System.__Canon>(json);
			if (_Canon2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v34 (System.__Canon)+10]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v34 (System.__Canon)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X19_v6+18]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X19_v6+18]");
						object obj11 = 0 & 0xFFFFFFFFL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57E8]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v34 (System.__Canon)+10]");
						object obj13 = (nint)0 + (nint)32;
						object obj14 = 0;
						object obj15 = 0;
						object obj26 = default;
						object obj28 = default;
						NullReferenceException ex4 = default;
						List<Outfit> result2 = default;
						while (true)
						{
							bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
							object obj16 = !flag2;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4+v134 @ X21_v5*8]");
								_Canon = (System.__Canon)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4+v134 @ X21_v5*8]");
								if ((nint)0 != 0)
								{
									object obj17 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v30+A0]");
									object obj18 = 0;
									List<System.__Canon> list2 = (List<System.__Canon>)obj18;
									if (obj18 == null)
									{
										goto IL_03d8;
									}
									if (list2._size <= 7)
									{
										defaultValue = list2._items;
										int num = (int)obj12;
										int version = list2._version + 1;
										list2._version = version;
										if (list2._items == null)
										{
											goto IL_03e6;
										}
										bool flag3 = list2._size < defaultValue.Length;
										object obj19 = !flag3;
										if (obj19 == null)
										{
											num = list2._size + 1;
											object obj20 = list2._items + list2._size;
											list2._size = num;
											object obj21 = obj20 + 32;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4+v134 @ X21_v5*8]");
											obj21 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X10_v5 (System.Int32)+20]");
											object obj22 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v33+A8]");
											object obj23 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v34+70]");
											obj15 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4+v134 @ X21_v5*8]");
											((List<System.__Canon>)obj18).AddWithResize((System.__Canon)0);
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X19_v6+18]");
								obj11 = 0;
								obj14++;
								object obj24 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X19_v6+18]");
								if ((nint)obj24 >= 0)
								{
									break;
								}
								continue;
							}
							IndexOutOfRangeException ex = new IndexOutOfRangeException();
							goto IL_03d8;
							IL_03e6:
							NullReferenceException ex2 = new NullReferenceException();
							bool flag4 = (nint)_Canon != 1;
							NullReferenceException ex3 = ex2;
							if (!flag4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								object obj25 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
								object obj27 = obj28 & 1;
								if (obj27 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
								object obj29 = obj26;
								_Canon = (System.__Canon)(101789696 + 1224);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj15 = 0;
								ex3 = ex4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return result2;
							IL_03d8:
							NullReferenceException ex5 = new NullReferenceException();
							goto IL_03e6;
						}
					}
				}
			}
			object obj30 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v18+A0]");
			object obj31 = 0;
			result = (List<Outfit>)obj31;
		}
		return result;
	}

	private static void Store()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_0048: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5838]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaOwned.Kept kept = default;
		kept._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+A0]");
		object obj4 = 0;
		System.__Canon[] array = ((List<System.__Canon>)obj4).ToArray();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5808]");
		object key = 0;
		object obj5 = kept + 16;
		obj5 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string value = JsonUtility.ToJson(kept);
		PlayerPrefs.SetString((string)key, value);
		PlayerPrefs.Save();
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
