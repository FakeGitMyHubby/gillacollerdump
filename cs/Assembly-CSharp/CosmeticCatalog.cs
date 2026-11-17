using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

public class CosmeticCatalog : ScriptableObject
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass13_0
	{
		public float hall;

		public float cave;

		public float generic;
	}

	[Serializable]
	public class Entry
	{
		public string name;

		public string label;

		public CosmeticSlot slot;

		public int price = 300;

		public GameObject prefab;

		public Texture2D eyeTexture;

		public float eyeScale = 1f;

		public float eyeTurn;

		public Material eyeMaterial;

		public string comesWith;

		public string wornWith;

		public bool retired;

		public bool shutsMouth;

		public bool tucksEars;
	}

	public Entry[] cosmetics;

	public Coins.Bundle[] bundles;

	private static CosmeticCatalog loaded;

	public static int Count
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0102: Expected Obj, but got I4
			//IL_00cf: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			CosmeticCatalog cosmeticCatalog = Get();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (cosmeticCatalog != null)
			{
				CosmeticCatalog cosmeticCatalog2 = Get();
				if ((object)cosmeticCatalog2 != null)
				{
					Entry[] array = cosmeticCatalog2.cosmetics;
					if (cosmeticCatalog2.cosmetics != null)
					{
						return array.Length;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return 0;
		}
	}

	public static int BundleCount
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_014a: Expected Obj, but got I4
			//IL_0117: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			CosmeticCatalog cosmeticCatalog = Get();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (cosmeticCatalog != null)
			{
				CosmeticCatalog cosmeticCatalog2 = Get();
				if ((object)cosmeticCatalog2 != null)
				{
					if (cosmeticCatalog2.bundles == null)
					{
						goto IL_00fb;
					}
					CosmeticCatalog cosmeticCatalog3 = Get();
					if ((object)cosmeticCatalog3 != null)
					{
						Coins.Bundle[] array = cosmeticCatalog3.bundles;
						if (cosmeticCatalog3.bundles != null)
						{
							return array.Length;
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			goto IL_00fb;
			IL_00fb:
			return 0;
		}
	}

	public static CosmeticCatalog Get()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45C0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v10+A0]");
			object obj10 = 0;
			object obj11 = default;
			obj10 = obj11;
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+A0]");
		return (CosmeticCatalog)0;
	}

	public static Entry Of(int id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		CosmeticCatalog cosmeticCatalog = Get();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = cosmeticCatalog != null;
		int num = default;
		object obj4 = num - 1;
		bool flag3 = num < 1;
		Entry result = null;
		if (!flag3)
		{
			bool flag4 = !flag2;
			result = null;
			if (!flag4)
			{
				if ((object)cosmeticCatalog != null)
				{
					Entry[] array = cosmeticCatalog.cosmetics;
					if (cosmeticCatalog.cosmetics != null)
					{
						if (array.Length < num)
						{
							result = null;
						}
						else
						{
							bool flag5 = (nint)obj4 < array.Length;
							object obj5 = !flag5;
							if (obj5 != null)
							{
								goto IL_0159;
							}
							object obj6 = (object)cosmeticCatalog.cosmetics + obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v9+20]");
							result = (Entry)0;
						}
						goto IL_01a8;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_0159;
			}
		}
		goto IL_01a8;
		IL_0159:
		return (Entry)(object)new IndexOutOfRangeException();
		IL_01a8:
		return result;
	}

	public static byte IdOf(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_017d: Expected I4, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected I4, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0135: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		CosmeticCatalog cosmeticCatalog = Get();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (cosmeticCatalog != null)
		{
			Entry[] array = cosmeticCatalog.cosmetics;
			object obj4 = 0;
			string text = default;
			while ((nint)obj4 < array.Length)
			{
				bool flag2 = (nint)obj4 < array.Length;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					object obj6 = (object)array + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v9+20]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v10+10]");
					bool flag3 = (string)0 == text;
					bool flag4 = !flag3;
					object obj8 = !flag4;
					if (obj8 == null)
					{
						array = cosmeticCatalog.cosmetics;
						obj4++;
						bool flag5 = cosmeticCatalog.cosmetics == null;
						object obj9 = !flag5;
						if (obj9 == null)
						{
							throw new NullReferenceException();
						}
						continue;
					}
					return (byte)(obj4 + 1);
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				return (byte)(int)ex;
			}
		}
		return 0;
	}

	public static Coins.Bundle BundleAt(int i)
	{
		//IL_0012: Expected I4, but got I8
		//IL_002c: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I
		int num = (int)(i & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			int bundleCount = BundleCount;
			if (bundleCount > i)
			{
				CosmeticCatalog cosmeticCatalog = Get();
				if ((object)cosmeticCatalog != null)
				{
					Coins.Bundle[] array = cosmeticCatalog.bundles;
					if (cosmeticCatalog.bundles != null)
					{
						bool flag2 = array.Length < i;
						object obj2 = !flag2;
						object obj3 = array.Length - i;
						bool flag3 = obj3 == null;
						object obj4 = ~obj2;
						object obj5 = obj4 | flag3;
						if (obj5 == null)
						{
							object obj6 = cosmeticCatalog.bundles + i;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+20]");
							return (Coins.Bundle)0;
						}
						goto IL_0153;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_0153;
			}
		}
		return null;
		IL_0153:
		return (Coins.Bundle)(object)new IndexOutOfRangeException();
	}

	public static Coins.Bundle BundleNamed(string name)
	{
		//IL_002f: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I
		int bundleCount = BundleCount;
		if (bundleCount >= 1)
		{
			object obj = 4;
			while (true)
			{
				CosmeticCatalog cosmeticCatalog = Get();
				if ((object)cosmeticCatalog != null)
				{
					Coins.Bundle[] array = cosmeticCatalog.bundles;
					if (cosmeticCatalog.bundles != null)
					{
						object obj2 = obj - 4;
						bool flag = (nint)obj2 < array.Length;
						object obj3 = !flag;
						if (obj3 != null)
						{
							goto IL_01f9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6 (Bundle[])+v69 @ X20_v5*8]");
						Coins.Bundle bundle = (Coins.Bundle)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6 (Bundle[])+v69 @ X20_v5*8]");
						if ((nint)0 != 0)
						{
							bool flag2 = bundle.name == name;
							bool flag3 = !flag2;
							object obj4 = !flag3;
							if (obj4 == null)
							{
								bundleCount = BundleCount;
								obj++;
								object obj5 = obj - 4;
								if ((nint)obj5 >= bundleCount)
								{
									break;
								}
								continue;
							}
							CosmeticCatalog cosmeticCatalog2 = Get();
							if ((object)cosmeticCatalog2 != null)
							{
								Coins.Bundle[] array2 = cosmeticCatalog2.bundles;
								if (cosmeticCatalog2.bundles != null)
								{
									bool flag4 = (nint)obj2 < array2.Length;
									object obj6 = !flag4;
									if (obj6 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v8 (Bundle[])+v69 @ X20_v5*8]");
										return (Coins.Bundle)0;
									}
									goto IL_01f9;
								}
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_01f9;
				IL_01f9:
				return (Coins.Bundle)(object)new IndexOutOfRangeException();
			}
		}
		return null;
	}

	public static Coins.Bundle BundleWithSku(string sku)
	{
		//IL_002f: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I
		int bundleCount = BundleCount;
		if (bundleCount >= 1)
		{
			object obj = 4;
			while (true)
			{
				CosmeticCatalog cosmeticCatalog = Get();
				if ((object)cosmeticCatalog != null)
				{
					Coins.Bundle[] array = cosmeticCatalog.bundles;
					if (cosmeticCatalog.bundles != null)
					{
						object obj2 = obj - 4;
						bool flag = (nint)obj2 < array.Length;
						object obj3 = !flag;
						if (obj3 != null)
						{
							goto IL_01f9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6 (Bundle[])+v69 @ X20_v5*8]");
						Coins.Bundle bundle = (Coins.Bundle)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6 (Bundle[])+v69 @ X20_v5*8]");
						if ((nint)0 != 0)
						{
							bool flag2 = bundle.sku == sku;
							bool flag3 = !flag2;
							object obj4 = !flag3;
							if (obj4 == null)
							{
								bundleCount = BundleCount;
								obj++;
								object obj5 = obj - 4;
								if ((nint)obj5 >= bundleCount)
								{
									break;
								}
								continue;
							}
							CosmeticCatalog cosmeticCatalog2 = Get();
							if ((object)cosmeticCatalog2 != null)
							{
								Coins.Bundle[] array2 = cosmeticCatalog2.bundles;
								if (cosmeticCatalog2.bundles != null)
								{
									bool flag4 = (nint)obj2 < array2.Length;
									object obj6 = !flag4;
									if (obj6 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v8 (Bundle[])+v69 @ X20_v5*8]");
										return (Coins.Bundle)0;
									}
									goto IL_01f9;
								}
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_01f9;
				IL_01f9:
				return (Coins.Bundle)(object)new IndexOutOfRangeException();
			}
		}
		return null;
	}

	public static List<byte> IdsOf(Coins.Bundle b)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I8
		//IL_0088: Expected Obj, but got I
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I4
		//IL_028e: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I4
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<byte> list = default;
		list._002Ector();
		if (b != null)
		{
			string[] items = b.items;
			if (b.items == null)
			{
				goto IL_0228;
			}
			if (items.Length >= 1)
			{
				object obj2 = items.Length & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D8]");
				object obj3 = 0;
				object obj4 = b.items + 32;
				object obj5 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
					object obj6 = !flag;
					if (obj6 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X23_v5+v170 @ X21_v7*8]");
					byte b2 = IdOf((string)0);
					if ((b2 & 0xFF) == 0)
					{
						goto IL_01ed;
					}
					if (list != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+10]");
						object obj7 = 0;
						object obj8 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+1C]");
						object obj9 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v11+18]");
							bool flag2 = num < 0;
							object obj10 = !flag2;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
								obj8 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+10]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
								object obj11 = num2 + 0;
							}
							else
							{
								list.AddWithResize(b2);
							}
							goto IL_01ed;
						}
					}
					goto IL_0228;
					IL_01ed:
					obj2 = items.Length;
					obj5++;
					if ((nint)obj5 < items.Length)
					{
						continue;
					}
					goto IL_0223;
				}
				goto IL_0236;
			}
		}
		goto IL_0223;
		IL_0236:
		return (List<byte>)(object)new IndexOutOfRangeException();
		IL_0223:
		return list;
		IL_0228:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0236;
	}

	public static List<Entry> WornWith(string skin)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I8
		//IL_017b: Expected Obj, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I4
		//IL_044a: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_01e8: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I4
		//IL_02c0: Expected I4, but got Obj
		//IL_0322: Expected Obj, but got I4
		//IL_03ac: Expected Obj, but got I
		//IL_03b4: Expected I4, but got Obj
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0385: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45E0]");
		UnityEngine.Object obj = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		CosmeticCatalog cosmeticCatalog = Get();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3+E4]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (cosmeticCatalog != null)
		{
			bool flag2 = string.IsNullOrEmpty(skin);
			bool flag3 = !flag2;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				if ((object)cosmeticCatalog != null)
				{
					Entry[] array = cosmeticCatalog.cosmetics;
					if (cosmeticCatalog.cosmetics != null)
					{
						if (array.Length < 1)
						{
							goto IL_03ef;
						}
						object obj7 = array.Length & 0xFFFFFFFFL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45F0]");
						object obj8 = 0;
						object obj9 = cosmeticCatalog.cosmetics + 32;
						object obj10 = 0;
						while (true)
						{
							bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
							object obj11 = !flag4;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X27_v4+v221 @ X25_v5*8]");
								System.__Canon _Canon = (System.__Canon)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X27_v4+v221 @ X25_v5*8]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X21_v7 (System.__Canon)+50]");
									if ((string)0 == skin)
									{
										object obj12 = obj3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X21_v7 (System.__Canon)+28]");
										obj = (UnityEngine.Object)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v19+E4]");
										bool flag5 = (nint)0 == 0;
										object obj13 = !flag5;
										if (obj13 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if (obj != null)
										{
											if (list == null)
											{
												break;
											}
											System.__Canon[] items = list._items;
											num = (int)obj8;
											int version = list._version + 1;
											list._version = version;
											if (list._items == null)
											{
												break;
											}
											bool flag6 = list._size < items.Length;
											object obj14 = !flag6;
											if (obj14 == null)
											{
												object obj15 = list._items + list._size;
												num = list._size + 1;
												list._size = num;
												object obj16 = obj15 + 32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X27_v4+v221 @ X25_v5*8]");
												obj16 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X27_v4+v221 @ X25_v5*8]");
												list.AddWithResize((System.__Canon)0);
												flag2 = (byte)(int)list != 0;
											}
										}
									}
								}
								obj7 = array.Length;
								obj10++;
								if ((nint)obj10 < array.Length)
								{
									continue;
								}
								goto IL_03ef;
							}
							IndexOutOfRangeException ex = new IndexOutOfRangeException();
							break;
						}
					}
				}
				return (List<Entry>)(object)new NullReferenceException();
			}
		}
		goto IL_03ef;
		IL_03ef:
		return (List<Entry>)(object)list;
	}

	public unsafe static GameObject Display(Entry e)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I
		//IL_00fb: Expected I4, but got Obj
		//IL_0127: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I4
		//IL_06b2: Expected Obj, but got I
		//IL_0707: Expected Obj, but got I
		//IL_0c7a: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I4
		//IL_0749: Expected Obj, but got I
		//IL_0759: Expected Obj, but got I
		//IL_0762: Expected Obj, but got I4
		//IL_0cc2: Expected Obj, but got I
		//IL_13e6: Expected Obj, but got I4
		//IL_0dde: Expected Obj, but got I
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected Obj, but got Unknown
		//IL_0d07: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I
		//IL_027c: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I4
		//IL_078d: Expected Obj, but got I
		//IL_0e26: Expected Obj, but got I
		//IL_14ac: Expected Obj, but got I4
		//IL_1398: Expected I, but got Obj
		//IL_13a8: Expected Obj, but got I
		//IL_0f0f: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I4
		//IL_07cf: Expected I, but got Obj
		//IL_07df: Expected Obj, but got I
		//IL_0808: Expected Obj, but got I4
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Expected Obj, but got Unknown
		//IL_0e6b: Expected Obj, but got I4
		//IL_12e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e9: Expected Obj, but got Unknown
		//IL_02a8: Expected Obj, but got I
		//IL_08ab: Expected Obj, but got I4
		//IL_0f57: Expected Obj, but got I
		//IL_14d3: Expected Obj, but got I4
		//IL_09a5: Expected Obj, but got I4
		//IL_09b2: Expected Obj, but got Ref
		//IL_09ba: Expected Obj, but got Ref
		//IL_09c3: Expected Obj, but got I4
		//IL_0921: Expected Obj, but got I
		//IL_0932: Expected Obj, but got I4
		//IL_082f: Expected Obj, but got I
		//IL_084c: Expected Obj, but got I
		//IL_0873: Expected Obj, but got I
		//IL_1040: Expected Obj, but got I
		//IL_0d42: Expected Obj, but got I
		//IL_1562: Expected Obj, but got I
		//IL_156a: Expected I4, but got Obj
		//IL_0359: Expected Obj, but got I4
		//IL_0366: Expected Obj, but got Ref
		//IL_036e: Expected Obj, but got Ref
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0950: Expected Obj, but got I
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected Obj, but got Unknown
		//IL_08df: Expected Obj, but got I
		//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8a: Expected Obj, but got Unknown
		//IL_0f9c: Expected Obj, but got I4
		//IL_141b: Expected Obj, but got I4
		//IL_02c3: Expected Obj, but got I
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_1088: Expected Obj, but got I
		//IL_14fa: Expected Obj, but got I4
		//IL_0d8a: Expected Obj, but got I
		//IL_0d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d98: Expected Obj, but got Unknown
		//IL_0db7: Expected Obj, but got I4
		//IL_09e8: Expected Obj, but got I
		//IL_0394: Expected I, but got Obj
		//IL_03a4: Expected Obj, but got I
		//IL_0eab: Expected Obj, but got I
		//IL_0ebb: Expected Obj, but got I
		//IL_0ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec9: Expected Obj, but got Unknown
		//IL_0ee8: Expected Obj, but got I4
		//IL_0ad6: Expected Obj, but got I4
		//IL_0a87: Expected Obj, but got I4
		//IL_0443: Expected Obj, but got I4
		//IL_10be: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c3: Expected Obj, but got Unknown
		//IL_10d5: Expected Obj, but got I4
		//IL_0a23: Expected Obj, but got I
		//IL_135d: Expected Obj, but got I4
		//IL_136a: Expected Obj, but got Ref
		//IL_1372: Expected Obj, but got Ref
		//IL_03df: Expected Obj, but got I
		//IL_1521: Expected Obj, but got I4
		//IL_0fdc: Expected Obj, but got I
		//IL_0fec: Expected Obj, but got I
		//IL_0ff5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffa: Expected Obj, but got Unknown
		//IL_1019: Expected Obj, but got I4
		//IL_0b49: Expected Obj, but got I
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected Obj, but got Unknown
		//IL_0486: Expected I4, but got Obj
		//IL_048e: Expected I, but got Obj
		//IL_049e: Expected Obj, but got I
		//IL_04ae: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I4
		//IL_04e9: Expected Obj, but got I4
		//IL_04f6: Expected Obj, but got Ref
		//IL_04fe: Expected Obj, but got Ref
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_1226: Expected Obj, but got I4
		//IL_0b23: Expected Obj, but got I4
		//IL_0a3e: Expected Obj, but got I
		//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4c: Expected Obj, but got Unknown
		//IL_03fa: Expected Obj, but got I
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_1275: Expected Obj, but got I4
		//IL_0b91: Expected Obj, but got I
		//IL_0539: Expected Obj, but got I
		//IL_055b: Expected Obj, but got I4
		//IL_0568: Expected Obj, but got Ref
		//IL_0570: Expected Obj, but got Ref
		//IL_1115: Expected Obj, but got I
		//IL_1125: Expected Obj, but got I
		//IL_112e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1133: Expected Obj, but got Unknown
		//IL_115a: Expected Obj, but got I4
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected Obj, but got Unknown
		//IL_0bd6: Expected Obj, but got I4
		//IL_1485: Expected Obj, but got I4
		//IL_05c9: Expected Obj, but got I4
		//IL_0677: Expected Obj, but got I4
		//IL_05fc: Expected Obj, but got I4
		//IL_0609: Expected Obj, but got Ref
		//IL_0611: Expected Obj, but got Ref
		//IL_0622: Expected Obj, but got I4
		//IL_0c16: Expected Obj, but got I
		//IL_0c26: Expected Obj, but got I
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected Obj, but got Unknown
		//IL_0c53: Expected Obj, but got I4
		//IL_0658: Expected Obj, but got I4
		GameObject result;
		IEnumerator enumerator;
		UnityEngine.Object obj9 = default;
		UnityEngine.Object prefab;
		object obj8;
		bool flag5;
		if (e != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = e.prefab == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			result = null;
			if (obj4 == null)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v9+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4640]");
				object obj7 = 0;
				flag5 = (byte)(int)obj7 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDA38");
				bool flag6 = (object)e.prefab == null;
				enumerator = null;
				obj8 = 0;
				prefab = e.prefab;
				if (!flag6)
				{
					string text = e.prefab.name;
					bool flag7 = (object)obj9 == null;
					enumerator = null;
					obj8 = 0;
					flag5 = false;
					prefab = obj9;
					if (!flag7)
					{
						obj9.name = text;
						if (e.slot != (CosmeticSlot)7)
						{
							bool flag8 = e.slot != (CosmeticSlot)6;
							enumerator = null;
							prefab = obj9;
							if (flag8)
							{
								goto IL_0c6a;
							}
							Transform transform = ((GameObject)obj9).transform;
							bool flag9 = (object)transform == null;
							enumerator = null;
							obj8 = 0;
							flag5 = false;
							prefab = obj9;
							if (!flag9)
							{
								IEnumerator enumerator2 = transform.GetEnumerator();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
								object obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4648]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4650]");
								object obj12 = 0;
								obj8 = 0;
								IEnumerator enumerator3 = enumerator2;
								object obj20 = default;
								object obj26 = default;
								object obj28 = default;
								object obj33;
								GameObject result2 = default;
								object obj34 = default;
								UnityEngine.Object obj37 = default;
								while (true)
								{
									nint num = (nint)enumerator3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v75 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
									object obj13 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v75 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_02f9;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v75 (Il2CppClass<System.Collections.IEnumerator>)+98]");
									object obj14 = (nint)0 + (nint)8;
									object obj15;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X10_v37-8]");
										if (0 == (nint)obj10)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v75 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
										obj13 = -1;
										obj15 = obj14 + 16;
										bool flag10 = (nint)obj13 != 1;
										obj14 = obj15;
										if (flag10)
										{
											continue;
										}
										goto IL_02f9;
									}
									obj13 = obj14;
									object obj16 = num + obj14;
									object obj17 = obj16 + 312;
									obj15 = obj14;
									goto IL_12c1;
									IL_11b9:
									NullReferenceException ex = new NullReferenceException();
									goto IL_11c7;
									IL_1552:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
									object obj18 = 0;
									flag5 = (byte)(int)obj18 != 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									object obj19 = obj20;
									if (obj20 == null)
									{
										goto IL_1401;
									}
									object obj21 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1340 @ X8_v20+12E]");
									obj13 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1340 @ X8_v20+12E]");
									if ((nint)0 == 0)
									{
										goto IL_0a74;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1340 @ X8_v20+98]");
									object obj22 = (nint)0 + (nint)8;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1436 @ X10_v9-8]");
										if (0 == (nint)obj18)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1340 @ X8_v20+12E]");
										obj13 = -1;
										obj15 = obj22 + 16;
										bool flag11 = (nint)obj13 != 1;
										obj22 = obj15;
										if (flag11)
										{
											continue;
										}
										goto IL_0a74;
									}
									obj13 = obj22;
									object obj23 = obj21 + obj22;
									object obj24 = obj23 + 312;
									obj15 = obj22;
									goto IL_144d;
									IL_144d:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1462 @ X0_v22+8]");
									flag5 = false;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1462 @ X0_v22] (should have been resolved before IL gen)");
									goto IL_1401;
									IL_02f9:
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
									obj8 = 0;
									goto IL_12c1;
									IL_12c1:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ X0_v91+8]");
									flag5 = false;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1213 @ X0_v91] (should have been resolved before IL gen)");
									object obj25 = obj26 & 1;
									object obj27;
									OutOfMemoryException ex2;
									object obj29;
									if (obj25 != null)
									{
										bool flag12 = enumerator2 == null;
										obj27 = 0;
										ex2 = null;
										obj19 = (object)(&obj28);
										obj29 = (object)(&enumerator);
										enumerator = enumerator2;
										prefab = obj9;
										if (flag12)
										{
											goto IL_11ab;
										}
										nint num2 = (nint)enumerator2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X8_v78 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
										obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X8_v78 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
										if ((nint)0 == 0)
										{
											goto IL_0430;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X8_v78 (Il2CppClass<System.Collections.IEnumerator>)+98]");
										object obj30 = (nint)0 + (nint)8;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1365 @ X10_v32-8]");
											if (0 == (nint)obj10)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X8_v78 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
											obj13 = -1;
											obj15 = obj30 + 16;
											bool flag13 = (nint)obj13 != 1;
											obj30 = obj15;
											if (flag13)
											{
												continue;
											}
											goto IL_0430;
										}
										obj13 = obj30 + 1;
										object obj31 = num2 + obj13;
										object obj32 = obj31 + 312;
										obj15 = obj30;
										goto IL_132b;
									}
									obj27 = 0;
									ex2 = null;
									obj19 = (object)(&obj28);
									obj29 = (object)(&enumerator);
									obj33 = 7;
									prefab = obj9;
									goto IL_1552;
									IL_11d5:
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
									if ((flag5 ? 1 : 0) == 2)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										obj27 = 1;
									}
									else
									{
										if (!flag5)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
											return result2;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										ex2 = (OutOfMemoryException)obj34;
									}
									obj33 = 0;
									goto IL_1552;
									IL_1401:
									bool flag14 = ex2 == null;
									object obj35 = !flag14;
									if (obj35 != null)
									{
										goto IL_11c7;
									}
									bool flag15 = obj27 == null;
									object obj36 = !flag15;
									OutOfMemoryException ex3 = ex2;
									if (obj36 == null)
									{
										break;
									}
									goto IL_11d5;
									IL_0a74:
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
									obj8 = 0;
									goto IL_144d;
									IL_11c7:
									ex3 = new OutOfMemoryException();
									goto IL_11d5;
									IL_11ab:
									NullReferenceException ex4 = new NullReferenceException();
									goto IL_11b9;
									IL_0430:
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
									obj8 = 1;
									goto IL_132b;
									IL_132b:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1421 @ X0_v94+8]");
									flag5 = false;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1421 @ X0_v94] (should have been resolved before IL gen)");
									bool flag16 = (object)obj37 == null;
									obj27 = 0;
									ex2 = null;
									obj19 = (object)(&obj28);
									obj29 = (object)(&enumerator);
									enumerator = enumerator2;
									prefab = obj9;
									if (!flag16)
									{
										flag5 = (byte)(int)obj11 != 0;
										nint num3 = (nint)obj37;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v81 (Il2CppClass<UnityEngine.Object>)+130]");
										obj15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X1_v42 (System.Boolean)+130]");
										obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v81 (Il2CppClass<UnityEngine.Object>)+130]");
										nint num4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X1_v42 (System.Boolean)+130]");
										bool flag17 = num4 < 0;
										object obj38 = !flag17;
										object obj39 = ~obj38;
										obj27 = 0;
										ex2 = null;
										obj19 = (object)(&obj28);
										obj29 = (object)(&enumerator);
										enumerator = enumerator2;
										prefab = obj9;
										if (obj39 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v81 (Il2CppClass<UnityEngine.Object>)+B0]");
											nint num5 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X1_v42 (System.Boolean)+130]");
											object obj40 = num5 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ X8_v83-8]");
											bool flag18 = (nint)0 != (flag5 ? 1 : 0);
											obj27 = 0;
											ex2 = null;
											obj19 = (object)(&obj28);
											obj29 = (object)(&enumerator);
											enumerator = enumerator2;
											prefab = obj9;
											if (!flag18)
											{
												string text2 = obj37.name;
												bool flag19 = text2 != (string)obj12;
												bool flag20 = !flag19;
												obj8 = 0;
												if (!flag20)
												{
													GameObject gameObject = ((Component)obj37).gameObject;
													bool flag21 = (object)gameObject == null;
													obj27 = 0;
													ex2 = null;
													obj19 = (object)(&obj28);
													obj29 = (object)(&enumerator);
													enumerator = enumerator2;
													obj8 = 0;
													flag5 = false;
													prefab = obj9;
													if (flag21)
													{
														goto IL_11b9;
													}
													gameObject.SetActive(value: false);
													obj8 = 0;
												}
												bool flag22 = enumerator2 == null;
												object obj41 = !flag22;
												enumerator3 = enumerator2;
												if (obj41 == null)
												{
													throw new NullReferenceException();
												}
												continue;
											}
										}
										InvalidCastException ex5 = new InvalidCastException();
									}
									NullReferenceException ex6 = new NullReferenceException();
									goto IL_11ab;
								}
								if ((nint)obj33 != 7)
								{
									bool flag23 = obj33 == null;
									object obj42 = !flag23;
									result = (GameObject)prefab;
									if (obj42 != null)
									{
										goto IL_1171;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4618]");
								object obj43 = 0;
								obj8 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
								object obj44 = default;
								bool flag24 = obj44 == null;
								flag5 = true;
								if (!flag24)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v19+18]");
									object obj45 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v19+18]");
									if ((nint)0 < (nint)1)
									{
										goto IL_0c6a;
									}
									object obj46 = obj44 + 32;
									flag5 = true;
									object obj47 = 0;
									while (true)
									{
										bool flag25 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45);
										object obj48 = !flag25;
										if (obj48 != null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X22_v7+v504 @ X21_v8*8]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X22_v7+v504 @ X21_v8*8]");
											((Behaviour)0).enabled = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v19+18]");
											obj45 = 0;
											obj47++;
											object obj49 = obj47;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v19+18]");
											bool flag26 = (nint)obj49 < 0;
											obj8 = 0;
											flag5 = false;
											if (flag26)
											{
												continue;
											}
											goto IL_0c6a;
										}
										goto IL_1176;
									}
									goto IL_1184;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4618]");
							object obj50 = 0;
							obj8 = obj50;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
							object obj51 = default;
							bool flag27 = obj51 == null;
							enumerator = null;
							flag5 = true;
							prefab = obj9;
							if (!flag27)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v82+18]");
								object obj52 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v82+18]");
								bool flag28 = (nint)0 < (nint)1;
								enumerator = null;
								prefab = obj9;
								if (flag28)
								{
									goto IL_0c6a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4600]");
								object obj53 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45F8]");
								object obj54 = 0;
								object obj12 = 0;
								flag5 = true;
								object obj59 = default;
								while (true)
								{
									bool flag29 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj52);
									object obj55 = !flag29;
									enumerator = null;
									prefab = obj9;
									if (obj55 != null)
									{
										break;
									}
									object obj56 = obj51 + obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v64+20]");
									Behaviour behaviour = (Behaviour)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v64+20]");
									bool flag30 = (nint)0 == 0;
									enumerator = null;
									prefab = obj9;
									object obj61;
									if (!flag30)
									{
										object obj15 = obj53;
										nint num6 = (nint)behaviour;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v65 (Il2CppClass<UnityEngine.Behaviour>)+130]");
										object obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v65 (Il2CppClass<UnityEngine.Behaviour>)+130]");
										nint num7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ X10_v5+130]");
										bool flag31 = num7 < 0;
										object obj57 = !flag31;
										object obj58 = ~obj57;
										if (obj58 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v65 (Il2CppClass<UnityEngine.Behaviour>)+B0]");
											obj59 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v65 (Il2CppClass<UnityEngine.Behaviour>)+B0]");
											nint num8 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ X10_v5+130]");
											object obj60 = num8 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X11_v23-8]");
											bool flag32 = 0 == (nint)obj15;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v65 (Il2CppClass<UnityEngine.Behaviour>)+B0]");
											obj61 = 0;
											if (flag32)
											{
												goto IL_0940;
											}
										}
										obj15 = obj54;
										object obj62 = obj13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ X10_v5+130]");
										bool flag33 = (nint)obj62 < 0;
										object obj63 = !flag33;
										object obj64 = ~obj63;
										if (obj64 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v65 (Il2CppClass<UnityEngine.Behaviour>)+B0]");
											nint num9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ X10_v5+130]");
											object obj65 = num9 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ X8_v70-8]");
											bool flag34 = 0 == (nint)obj15;
											obj61 = obj59;
											if (flag34)
											{
												goto IL_0940;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v64+20]");
										((Behaviour)0).enabled = false;
										obj61 = obj59;
										obj8 = 0;
										flag5 = false;
										goto IL_0940;
									}
									goto IL_1176;
									IL_0940:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v82+18]");
									obj52 = 0;
									obj12++;
									object obj66 = obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v82+18]");
									bool flag35 = (nint)obj66 < 0;
									obj59 = obj61;
									if (flag35)
									{
										continue;
									}
									goto IL_098a;
								}
								goto IL_1184;
							}
						}
					}
				}
				goto IL_1176;
			}
		}
		else
		{
			result = null;
		}
		goto IL_1171;
		IL_0eff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4610]");
		object obj67 = 0;
		obj8 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
		object obj68 = default;
		bool flag36 = obj68 == null;
		flag5 = true;
		if (flag36)
		{
			goto IL_1176;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v65+18]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v65+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_1030;
		}
		object obj70 = obj68 + 32;
		flag5 = true;
		object obj71 = 0;
		while (true)
		{
			bool flag37 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj71) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj69);
			object obj72 = !flag37;
			if (obj72 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X22_v21+v510 @ X21_v27*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X22_v21+v510 @ X21_v27*8]");
				((Behaviour)0).enabled = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v65+18]");
				obj69 = 0;
				obj71++;
				object obj73 = obj71;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v65+18]");
				bool flag38 = (nint)obj73 < 0;
				obj8 = 0;
				flag5 = false;
				if (flag38)
				{
					continue;
				}
				goto IL_1030;
			}
			goto IL_1176;
		}
		goto IL_1184;
		IL_1171:
		return result;
		IL_1184:
		throw new IndexOutOfRangeException();
		IL_0c6a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4620]");
		object obj74 = 0;
		obj8 = obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
		object obj75 = default;
		bool flag39 = obj75 == null;
		flag5 = true;
		if (flag39)
		{
			goto IL_1176;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v59+18]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v59+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0dce;
		}
		object obj77 = obj75 + 32;
		flag5 = true;
		object obj78 = 0;
		while (true)
		{
			bool flag40 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj78) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj76);
			object obj79 = !flag40;
			if (obj79 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X22_v23+v506 @ X21_v33*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X22_v23+v506 @ X21_v33*8]");
				GameObject gameObject2 = ((Component)0).gameObject;
				bool flag41 = (object)gameObject2 == null;
				flag5 = false;
				if (!flag41)
				{
					gameObject2.SetActive(value: false);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v59+18]");
					obj76 = 0;
					obj78++;
					object obj80 = obj78;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v59+18]");
					bool flag42 = (nint)obj80 < 0;
					obj8 = 0;
					flag5 = false;
					if (flag42)
					{
						continue;
					}
					goto IL_0dce;
				}
			}
			goto IL_1176;
		}
		goto IL_1184;
		IL_098a:
		enumerator = null;
		prefab = obj9;
		goto IL_0c6a;
		IL_0dce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4628]");
		object obj81 = 0;
		obj8 = obj81;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
		object obj82 = default;
		bool flag43 = obj82 == null;
		flag5 = true;
		if (flag43)
		{
			goto IL_1176;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v62+18]");
		object obj83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v62+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0eff;
		}
		object obj84 = obj82 + 32;
		flag5 = true;
		object obj85 = 0;
		while (true)
		{
			bool flag44 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj85) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj83);
			object obj86 = !flag44;
			if (obj86 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X22_v22+v508 @ X21_v30*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X22_v22+v508 @ X21_v30*8]");
				((Renderer)0).enabled = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v62+18]");
				obj83 = 0;
				obj85++;
				object obj87 = obj85;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v62+18]");
				bool flag45 = (nint)obj87 < 0;
				obj8 = 0;
				flag5 = false;
				if (flag45)
				{
					continue;
				}
				goto IL_0eff;
			}
			goto IL_1176;
		}
		goto IL_1184;
		IL_1176:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_1184;
		IL_1030:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4608]");
		object obj88 = 0;
		obj8 = obj88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
		object obj89 = default;
		bool flag46 = obj89 == null;
		flag5 = true;
		if (flag46)
		{
			goto IL_1176;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v68+18]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v68+18]");
		bool flag47 = (nint)0 < (nint)1;
		result = (GameObject)prefab;
		if (flag47)
		{
			goto IL_1171;
		}
		object obj91 = obj89 + 32;
		flag5 = true;
		object obj92 = 0;
		while (true)
		{
			bool flag48 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj92) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj90);
			object obj93 = !flag48;
			if (obj93 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X22_v20+v511 @ X21_v24*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X22_v20+v511 @ X21_v24*8]");
				((Behaviour)0).enabled = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v68+18]");
				obj90 = 0;
				obj92++;
				object obj94 = obj92;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v68+18]");
				bool flag49 = (nint)obj94 < 0;
				result = (GameObject)prefab;
				obj8 = 0;
				flag5 = false;
				if (flag49)
				{
					continue;
				}
				goto IL_1171;
			}
			goto IL_1176;
		}
		goto IL_1184;
	}

	public CosmeticCatalog()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4658]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4660]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 24;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 32;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
