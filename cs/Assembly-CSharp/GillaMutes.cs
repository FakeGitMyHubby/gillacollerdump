using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class GillaMutes
{
	private const string Key = null;

	private const int MostKept = default(int);

	private static List<string> ids;

	private static HashSet<string> set;

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+A0]");
		object obj6 = (nint)0 + (nint)8;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private unsafe static void Load()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I
		//IL_0496: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I
		//IL_041a: Expected Obj, but got I4
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_0235: Expected Obj, but got I
		//IL_0262: Expected I4, but got Obj
		//IL_027f: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I
		//IL_02f2: Expected I4, but got Obj
		//IL_0354: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I
		//IL_03e6: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_03b7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v11+A0]");
		object obj7 = 0;
		obj7 = list;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v18+A0]");
		object obj11 = (nint)0 + (nint)8;
		obj11 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D28]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		int num = 0;
		string text = PlayerPrefs.GetString((string)key, (string)((int*)num)->m_value);
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
				object obj14 = 0;
				object obj15 = 0;
				StringSplitOptions stringSplitOptions = (StringSplitOptions)0;
				while (true)
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
					object obj16 = !flag2;
					if (obj16 != null)
					{
						break;
					}
					object obj17 = (object)array + obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v25+20]");
					System.__Canon _Canon = (System.__Canon)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v25+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X20_v6 (System.__Canon)+10]");
						if ((nint)0 < (nint)1)
						{
							goto IL_0410;
						}
						object obj18 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v29+A0]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v30+8]");
						if ((nint)0 != 0)
						{
							stringSplitOptions = (StringSplitOptions)obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v30+8]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v25+20]");
							if (!((HashSet<System.__Canon>)num2).Add((System.__Canon)0))
							{
								goto IL_0410;
							}
							object obj20 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v31+A0]");
							object obj21 = 0;
							List<System.__Canon> list2 = (List<System.__Canon>)obj21;
							if (obj21 != null)
							{
								System.__Canon[] items = list2._items;
								num = (int)obj14;
								int version = list2._version + 1;
								list2._version = version;
								if (list2._items != null)
								{
									bool flag3 = list2._size < items.Length;
									object obj22 = !flag3;
									if (obj22 == null)
									{
										object obj23 = list2._items + list2._size;
										num = list2._size + 1;
										list2._size = num;
										object obj24 = obj23 + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v25+20]");
										obj24 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X9_v7 (System.Int32)+20]");
										object obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v34+A8]");
										object obj26 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v35+70]");
										stringSplitOptions = (StringSplitOptions)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v25+20]");
										((List<System.__Canon>)obj21).AddWithResize((System.__Canon)0);
									}
									goto IL_0410;
								}
							}
						}
					}
					goto IL_0447;
					IL_0410:
					obj12 = array.Length;
					obj15++;
					if ((nint)obj15 >= array.Length)
					{
						return;
					}
				}
				goto IL_0455;
			}
		}
		goto IL_0447;
		IL_0455:
		throw new IndexOutOfRangeException();
		IL_0447:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0455;
	}

	public static bool IsMuted(string id)
	{
		//IL_001b: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I
		//IL_008a: Expected I4, but got Obj
		//IL_0073: Expected Obj, but got I
		if (string.IsNullOrEmpty(id))
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D20]");
		object obj = 0;
		Load();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+8]");
			return ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)id);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool Toggle(string id)
	{
		//IL_001b: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I
		//IL_00b9: Expected I4, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected I4, but got Unknown
		if (string.IsNullOrEmpty(id))
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D20]");
		object obj = 0;
		Load();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+8]");
			bool flag = ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)id);
			object obj4 = !flag;
			bool now = (byte)(1 & obj4) != 0;
			return Set(id, now);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool Set(string id, bool now)
	{
		//IL_0028: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_047f: Expected I4, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I
		//IL_0295: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_0427: Expected Obj, but got I
		//IL_0448: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_02fd: Expected Obj, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0361: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I
		//IL_03c0: Expected Obj, but got I
		bool result;
		if (string.IsNullOrEmpty(id))
		{
			result = false;
			goto IL_046c;
		}
		Load();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v4+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v5+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v5+8]");
			bool flag = ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)id);
			bool flag2 = flag == now;
			result = now;
			if (flag2)
			{
				goto IL_046c;
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v10+A0]");
			object obj5 = 0;
			if (now)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v11+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v11+8]");
					bool flag3 = ((HashSet<System.__Canon>)0).Add((System.__Canon)(object)id);
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v26+A0]");
					object obj8 = 0;
					List<System.__Canon> list = (List<System.__Canon>)obj8;
					if (obj8 != null)
					{
						System.__Canon[] items = list._items;
						int version = list._version + 1;
						list._version = version;
						if (list._items != null)
						{
							bool flag4 = list._size < items.Length;
							object obj9 = !flag4;
							if (obj9 == null)
							{
								object obj10 = list._items + list._size;
								int size = list._size + 1;
								list._size = size;
								object obj11 = obj10 + 32;
								obj11 = id;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							}
							else
							{
								((List<System.__Canon>)obj8).AddWithResize((System.__Canon)(object)id);
							}
							object obj12 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v12+A0]");
							object obj13 = 0;
							List<System.__Canon> list2 = (List<System.__Canon>)obj13;
							if (obj13 != null)
							{
								if (list2._size < 201)
								{
									goto IL_0407;
								}
								while (true)
								{
									System.__Canon item = list2.get_Item(0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X9_v12+8]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X9_v12+8]");
									bool flag5 = ((HashSet<System.__Canon>)0).Remove(item);
									object obj14 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v32+A0]");
									object obj15 = 0;
									if (obj15 == null)
									{
										break;
									}
									((List<System.__Canon>)obj15).RemoveAt(0);
									obj12 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v12+A0]");
									obj13 = 0;
									list2 = (List<System.__Canon>)obj13;
									if (obj13 == null)
									{
										break;
									}
									if (list2._size > 200)
									{
										continue;
									}
									goto IL_0407;
								}
							}
						}
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v11+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v11+8]");
					bool flag6 = ((HashSet<System.__Canon>)0).Remove((System.__Canon)(object)id);
					object obj16 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v19+A0]");
					object obj17 = 0;
					if (obj17 != null)
					{
						bool flag7 = ((List<System.__Canon>)obj17).Remove((System.__Canon)(object)id);
						object obj12 = obj;
						goto IL_0407;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_046c:
		return result;
		IL_0407:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v12+A0]");
		object values = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A0]");
		object separator = 0;
		string value = string.Join((string)separator, (IEnumerable<string>)values);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D28]");
		object key = 0;
		PlayerPrefs.SetString((string)key, value);
		PlayerPrefs.Save();
		result = now;
		goto IL_046c;
	}
}
