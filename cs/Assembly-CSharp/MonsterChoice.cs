using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class MonsterChoice
{
	public const string Key = null;

	public const string Default = null;

	private static readonly Dictionary<string, string> Needs;

	private static readonly Dictionary<string, string> Skus;

	private static readonly (string, int)[] AtLevel;

	private static readonly HashSet<string> Soon;

	public const string Usd = null;

	public const int Coins = default(int);

	private static readonly Dictionary<string, string[]> Abilities;

	private static readonly HashSet<string> given;

	public static string TestPick;

	public static bool TestAsPlayer;

	public static IEnumerable<string> AllSkus
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_007f: Expected Obj, but got I4
			//IL_009d: Expected Obj, but got I
			//IL_003e: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
				return (IEnumerable<string>)((Dictionary<System.__Canon, System.__Canon>)0).Values;
			}
			return (IEnumerable<string>)new NullReferenceException();
		}
	}

	public static IReadOnlyList<(string, int)> LevelRewards
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
			return (IReadOnlyList<(string, int)>)0;
		}
	}

	public static string Picked
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I4
			//IL_0153: Expected Obj, but got I
			//IL_0163: Expected Obj, but got I
			//IL_0185: Expected Obj, but got I4
			//IL_0130: Expected Obj, but got I4
			//IL_00a8: Expected Obj, but got I4
			//IL_003c: Expected Obj, but got I
			//IL_004c: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v2+30]");
			string text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v2+30]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC28]");
				object key = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object defaultValue = 0;
				string text2 = PlayerPrefs.GetString((string)key, (string)defaultValue);
				obj2 = obj;
				text = text2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = IsChoosable(text);
			bool flag5 = !flag4;
			object obj7 = !flag5;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				return text;
			}
			return null;
		}
	}

	public static bool ComingSoon(string name)
	{
		//IL_001b: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_0097: Expected I4, but got Obj
		//IL_0080: Expected Obj, but got I
		if (string.IsNullOrEmpty(name))
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+18]");
			return ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)name);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static string[] AbilitiesOf(string name)
	{
		//IL_0114: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		bool flag = string.IsNullOrEmpty(name);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v9+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v8+20]");
			if ((nint)0 == 0)
			{
				return (string[])(object)new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCBC0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v8+20]");
			if (((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)name, out var value))
			{
				return (string[])(object)value;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] result = default;
		return result;
	}

	public static string SkuFor(string name)
	{
		//IL_00ff: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		bool flag = string.IsNullOrEmpty(name);
		bool flag2 = !flag;
		object obj = !flag2;
		string result = null;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v7+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+8]");
			if ((nint)0 == 0)
			{
				return (string)(object)new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+8]");
			bool flag4 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)name, out var value);
			bool flag5 = !flag4;
			object obj6 = !flag5;
			object obj7 = ~obj6;
			result = (string)(object)((obj7 != null) ? null : value);
		}
		return result;
	}

	public unsafe static string ForSku(string sku)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_02f5: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_00ec: Expected VT, but got Ref
		//IL_00f6: Expected Obj, but got I4
		//IL_02bd: Expected VT, but got I4
		//IL_0089: Expected Obj, but got I4
		//IL_0283: Expected I, but got Obj
		//IL_028c: Expected Ref, but got VT
		//IL_02a6: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00ba: Expected VT, but got Ref
		//IL_00c4: Expected Obj, but got I4
		//IL_00cd: Expected VT, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got VT
		//IL_0130: Expected Obj, but got VT
		//IL_01b8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCBD8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+8]");
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = ((Dictionary<System.__Canon, System.__Canon>)0).GetEnumerator();
		object obj7 = default;
		object obj6 = obj7;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator2 = default;
		string text = default;
		object obj13 = default;
		object obj14 = default;
		IntPtr intPtr = default;
		object obj15 = default;
		while (true)
		{
			object obj8;
			object obj9;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator3;
			object obj10;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator4;
			if (enumerator2.MoveNext())
			{
				bool flag2 = text == sku;
				bool flag3 = !flag2;
				obj6 = 0;
				if (flag3)
				{
					continue;
				}
				obj6 = 0;
				obj8 = 0;
				obj9 = 0;
				enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator2);
				obj10 = 0;
				enumerator4 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
				goto IL_027b;
			}
			obj8 = 0;
			obj9 = 0;
			enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator2);
			obj10 = 0;
			goto IL_02b4;
			IL_02b4:
			enumerator4 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
			goto IL_027b;
			IL_027b:
			nint num = (nint)obj5;
			((Dictionary<System.__Canon, System.__Canon>.Enumerator*)enumerator3)->Dispose();
			bool flag4 = obj10 == null;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				bool flag5 = obj8 == null;
				object obj12 = !flag5;
				OutOfMemoryException ex = (OutOfMemoryException)enumerator3;
				if (obj12 == null)
				{
					return (string)enumerator4;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj6 = obj7;
				obj8 = obj13;
				obj9 = obj14;
				num = intPtr;
				obj5 = 109895680;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if (num == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj8 = 1;
				obj10 = obj9;
			}
			else
			{
				if (num != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj10 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj9 = obj15;
			}
			goto IL_02b4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FE74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		string result = default;
		return result;
	}

	public static bool Given(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I4
		//IL_0031: Expected I4, but got Obj
		//IL_0074: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I
		//IL_00cb: Expected I4, but got Obj
		//IL_00af: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (byte)(int)ItemFor(name) != 0;
		if (flag2)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+28]");
				return ((HashSet<System.__Canon>)0).Contains((System.__Canon)flag2);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return flag2;
	}

	public static void EditorGiven(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = ItemFor(name);
		if (text != null)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+28]");
			bool flag3 = ((HashSet<System.__Canon>)0).Add((System.__Canon)(object)text);
		}
	}

	public static int LevelFor(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I
		//IL_0152: Expected I4, but got Obj
		//IL_006b: Expected Obj, but got I8
		//IL_0081: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I4
		//IL_0097: Expected I4, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+10]");
		int result;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v2+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_0128;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v2+18]");
			object obj6 = 0 & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+10]");
			object obj7 = (nint)0 + (nint)40;
			object obj8 = 0;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
				object obj9 = !flag2;
				if (obj9 != null)
				{
					break;
				}
				result = (int)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X23_v6-8]");
				bool flag3 = (string)0 == name;
				bool flag4 = !flag3;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v2+18]");
					obj6 = 0;
					obj8++;
					obj7 += 16;
					object obj11 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v2+18]");
					if ((nint)obj11 < 0)
					{
						continue;
					}
					goto IL_0128;
				}
				goto IL_018a;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
		IL_018a:
		return result;
		IL_0128:
		result = 0;
		goto IL_018a;
	}

	private static void ResetStatics()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
		object obj4 = (nint)0 + (nint)48;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+A0]");
		object obj6 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5+28]");
		((HashSet<System.__Canon>)0).Clear();
	}

	public unsafe static void Adopt(string[] owned)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I4
		//IL_04e0: Expected Obj, but got I
		//IL_0509: Expected VT, but got I4
		//IL_0511: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_03e5: Expected Obj, but got I
		//IL_0406: Expected VT, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_0107: Expected VT, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I4
		//IL_0252: Expected VT, but got Ref
		//IL_025b: Expected Obj, but got I4
		//IL_0485: Expected Ref, but got VT
		//IL_049f: Expected Obj, but got I4
		//IL_018e: Expected I4, but got I8
		//IL_01a8: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got VT
		//IL_01e0: Expected Obj, but got I4
		//IL_044f: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I4
		//IL_02c1: Expected VT, but got Ref
		//IL_0222: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I4
		//IL_0341: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		System.__Canon _Canon = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v7 (System.__Canon)+28]");
		bool flag2 = (nint)0 == 0;
		System.__Canon _Canon3 = default;
		System.__Canon _Canon2 = _Canon3;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		IntPtr intPtr = default;
		System.__Canon _Canon4 = (System.__Canon)(nint)intPtr;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47C0]");
			object obj4 = 0;
			_Canon4 = (System.__Canon)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v7 (System.__Canon)+28]");
			((HashSet<System.__Canon>)0).Clear();
			if (owned == null)
			{
				return;
			}
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v27+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v27+A0]");
			_Canon = (System.__Canon)0;
			bool flag4 = _Canon == null;
			_Canon2 = _Canon3;
			enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCBC8]");
				_Canon = (System.__Canon)0;
				_Canon4 = _Canon;
				ValueCollection<> values = ((Dictionary<System.__Canon, System.__Canon>)_Canon).Values;
				bool flag5 = values == null;
				_Canon2 = _Canon3;
				enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4708]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC00]");
					object obj9 = 0;
					Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)values.GetEnumerator();
					_Canon = _Canon3;
					Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator3 = default;
					object obj18 = default;
					object obj14;
					Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator4;
					Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator5;
					while (true)
					{
						if (enumerator.MoveNext())
						{
							object obj10 = obj7;
							int num = Array.IndexOf((System.__Canon[])(object)owned, _Canon3);
							int num2 = (int)(num & 0x80000000L);
							bool flag6 = num2 == 0;
							object obj11 = !flag6;
							if (obj11 == null)
							{
								object obj12 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v37+E4]");
								bool flag7 = (nint)0 == 0;
								object obj13 = !flag7;
								if (obj13 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj12 = obj;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v37+A0]");
								_Canon = (System.__Canon)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v7 (System.__Canon)+28]");
								if ((nint)0 == 0)
								{
									break;
								}
								obj10 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v7 (System.__Canon)+28]");
								bool flag8 = ((HashSet<System.__Canon>)0).Add(_Canon3);
							}
							continue;
						}
						_Canon2 = null;
						enumerator = enumerator3;
						obj14 = 0;
						enumerator4 = enumerator3;
						enumerator5 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator);
						object obj15 = 0;
						while (true)
						{
							_Canon4 = (System.__Canon)obj9;
							((Dictionary<System.__Canon, System.__Canon>.Enumerator*)enumerator5)->Dispose();
							bool flag9 = obj15 == null;
							object obj16 = !flag9;
							if (obj16 == null)
							{
								bool flag10 = _Canon2 == null;
								object obj17 = !flag10;
								OutOfMemoryException ex = (OutOfMemoryException)enumerator5;
								if (obj17 == null)
								{
									return;
								}
							}
							else
							{
								OutOfMemoryException ex = new OutOfMemoryException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							if ((nint)_Canon4 == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								_Canon2 = (System.__Canon)1;
								_Canon = (System.__Canon)1;
								obj15 = obj14;
								continue;
							}
							if ((nint)_Canon4 != 1)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj15 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj14 = obj18;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FEB0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					NullReferenceException ex2 = new NullReferenceException();
					_Canon2 = null;
					enumerator = enumerator3;
					obj14 = 0;
					enumerator4 = enumerator3;
					enumerator5 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator);
					_Canon4 = _Canon3;
				}
			}
		}
		throw new NullReferenceException();
	}

	public static string ItemFor(string name)
	{
		//IL_00f7: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		bool flag = string.IsNullOrEmpty(name);
		bool flag2 = !flag;
		object obj = !flag2;
		string result = null;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v7+A0]");
			object obj5 = 0;
			if (obj5 == null)
			{
				return (string)(object)new NullReferenceException();
			}
			bool flag4 = ((Dictionary<System.__Canon, System.__Canon>)obj5).TryGetValue((System.__Canon)(object)name, out System.__Canon value);
			bool flag5 = !flag4;
			object obj6 = !flag5;
			object obj7 = ~obj6;
			result = (string)(object)((obj7 != null) ? null : value);
		}
		return result;
	}

	public static bool MayPlay(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0383: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I4
		//IL_021f: Expected Obj, but got I4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected I4, but got Unknown
		//IL_03a6: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got I
		//IL_0359: Expected I4, but got Obj
		//IL_0342: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text;
		bool result;
		if (!ComingSoon(name))
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text = ItemFor(name);
			int num = LevelFor(name);
			bool flag3 = text == null;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				bool flag4 = num == 0;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					goto IL_0112;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v13+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isEditor)
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v30+E4]");
				bool flag6 = (nint)0 == 0;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v30+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v15+38]");
				if ((nint)0 == 0)
				{
					goto IL_0112;
				}
			}
			if (num >= 1)
			{
				int level = GillaLevel.Level;
				object obj14 = level - num;
				bool flag7 = (nint)obj14 < 0;
				int num2 = level ^ num;
				int num3 = level ^ obj14;
				int num4 = num2 & num3;
				bool flag8 = num4 < 0;
				bool flag9 = flag7 == flag8;
				bool flag10 = text == null;
				result = flag9;
				if (!flag10)
				{
					if (level < num)
					{
						goto IL_02dd;
					}
					result = flag9;
				}
				goto IL_0391;
			}
			if (text != null)
			{
				goto IL_02dd;
			}
		}
		result = false;
		goto IL_0391;
		IL_02dd:
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v20+E4]");
		bool flag11 = (nint)0 == 0;
		object obj16 = !flag11;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v20+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v11+28]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v11+28]");
			return ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)text);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0391:
		return result;
		IL_0112:
		result = true;
		goto IL_0391;
	}

	public static string LockLabel(int number)
	{
		//IL_0125: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		MonsterDirector.Entry entry = MonsterCatalog.Of(number);
		if (entry != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = LevelFor(entry.name);
			if (num >= 1)
			{
				int level = GillaLevel.Level;
				if (level < num)
				{
					int num2 = default;
					string text = num2.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC620]");
					object obj4 = 0;
					return (string)obj4 + text;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC20]");
		return (string)0;
	}

	public static string NameOr(string fallback)
	{
		//IL_0010: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string picked = Picked;
		if (picked == null)
		{
		}
		return picked;
	}

	public static int NumberOr(string fallback)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string name = NameOr(fallback);
		return NumberOf(name);
	}

	public static int NumberOf(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_011b: Expected Obj, but got I4
		//IL_0221: Expected I4, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		MonsterCatalog monsterCatalog = MonsterCatalog.Get();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = monsterCatalog == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		string text = default;
		if (obj4 != null || string.IsNullOrEmpty(text))
		{
			goto IL_0084;
		}
		bool flag4 = (object)monsterCatalog == null;
		object obj5 = 109895680;
		if (!flag4)
		{
			MonsterDirector.Entry[] monsters = monsterCatalog.monsters;
			bool flag5 = monsterCatalog.monsters == null;
			obj5 = 109895680;
			if (!flag5)
			{
				object obj6 = 4;
				while (true)
				{
					object obj7 = obj6 - 4;
					if ((nint)obj7 >= monsters.Length)
					{
						break;
					}
					bool flag6 = (nint)obj7 < monsters.Length;
					object obj8 = !flag6;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v9 (Entry[])+v101 @ X21_v8*8]");
						MonsterDirector.Entry entry = (MonsterDirector.Entry)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v9 (Entry[])+v101 @ X21_v8*8]");
						if ((nint)0 != 0)
						{
							bool flag7 = entry.name == text;
							bool flag8 = !flag7;
							object obj9 = !flag8;
							obj5 = obj6;
							if (obj9 != null)
							{
								return obj5 - 3;
							}
						}
						monsters = monsterCatalog.monsters;
						obj5 = obj6 + 1;
						bool flag9 = monsterCatalog.monsters == null;
						object obj10 = !flag9;
						obj6 = obj5;
						if (obj10 != null)
						{
							continue;
						}
						goto IL_01f5;
					}
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
					return (int)ex;
				}
				goto IL_0084;
			}
		}
		goto IL_01f5;
		IL_0084:
		return 0;
		IL_01f5:
		throw new NullReferenceException();
	}

	public static bool IsChoosable(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (IsShown(name))
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return MayPlay(name);
		}
		return false;
	}

	private static bool IsShown(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int monster = NumberOf(name);
		MonsterDirector.Entry entry = MonsterCatalog.Of(monster);
		if (entry == null)
		{
			goto IL_0177;
		}
		bool result = entry.choosable;
		if (~(entry.choosable ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(entry.prefab != null))
			{
				goto IL_0177;
			}
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = ComingSoon(name);
			result = (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
		}
		goto IL_01bd;
		IL_0177:
		result = false;
		goto IL_01bd;
		IL_01bd:
		return result;
	}

	public static List<int> Choices()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_0508: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I4
		//IL_0391: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I
		//IL_0402: Expected Obj, but got I4
		//IL_047e: Expected Obj, but got I
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected I4, but got Unknown
		//IL_049c: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got I
		//IL_04c1: Expected Obj, but got I4
		//IL_04c9: Expected I4, but got Obj
		//IL_0426: Expected Obj, but got I
		//IL_0443: Expected Obj, but got I
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_0464: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list = default;
		list._002Ector();
		MonsterCatalog monsterCatalog = MonsterCatalog.Get();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (monsterCatalog == null)
		{
			goto IL_00a7;
		}
		if ((object)monsterCatalog != null)
		{
			MonsterDirector.Entry[] monsters = monsterCatalog.monsters;
			if (monsterCatalog.monsters != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
				object obj6 = 0;
				object obj7 = 4;
				object obj8 = 0;
				UnityEngine.Object obj9 = null;
				while (true)
				{
					object obj10 = obj7 - 4;
					if ((nint)obj10 >= monsters.Length)
					{
						break;
					}
					bool flag2 = (nint)obj10 < monsters.Length;
					object obj11 = !flag2;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7 (Entry[])+v116 @ X25_v4*8]");
						MonsterDirector.Entry entry = (MonsterDirector.Entry)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7 (Entry[])+v116 @ X25_v4*8]");
						if ((nint)0 != 0 && ~(entry.choosable ? 1u : 0u) == 0)
						{
							object obj12 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v14+E4]");
							bool flag3 = (nint)0 == 0;
							object obj13 = !flag3;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag4 = entry.prefab != null;
							bool flag5 = !flag4;
							obj8 = 0;
							obj9 = null;
							text = (string)(object)entry.prefab;
							if (!flag5)
							{
								MonsterDirector.Entry[] monsters2 = monsterCatalog.monsters;
								if (monsterCatalog.monsters != null)
								{
									bool flag6 = (nint)obj10 < monsters2.Length;
									object obj14 = !flag6;
									if (obj14 != null)
									{
										goto IL_0524;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v11 (Entry[])+v116 @ X25_v4*8]");
									MonsterDirector.Entry entry2 = (MonsterDirector.Entry)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v11 (Entry[])+v116 @ X25_v4*8]");
									if ((nint)0 != 0)
									{
										object obj15 = obj5;
										text = entry2.name;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v18+E4]");
										bool flag7 = (nint)0 == 0;
										object obj16 = !flag7;
										if (obj16 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										flag4 = ComingSoon(text);
										bool flag8 = !flag4;
										object obj17 = !flag8;
										obj8 = 0;
										obj9 = null;
										if (obj17 != null)
										{
											goto IL_04ce;
										}
										if (list != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
											object obj18 = 0;
											object obj19 = obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
											object obj20 = (nint)0 + (nint)1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
												nint num = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v13+18]");
												bool flag9 = num < 0;
												object obj21 = !flag9;
												if (obj21 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
													object obj22 = (nint)0 + (nint)1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
													nint num2 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
													object obj23 = num2 + 0;
													object obj24 = obj7 - 3;
													obj8 = 0;
													obj9 = null;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X9_v11+20]");
													object obj25 = 0;
													int num3 = obj7 - 3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v14+A8]");
													object obj26 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v15+70]");
													obj8 = 0;
													list.AddWithResize(num3);
													obj9 = (UnityEngine.Object)num3;
													flag4 = (byte)(int)list != 0;
												}
												goto IL_04ce;
											}
										}
									}
								}
								goto IL_0516;
							}
						}
						goto IL_04ce;
					}
					goto IL_0524;
					IL_04ce:
					monsters = monsterCatalog.monsters;
					obj7++;
					bool flag10 = monsterCatalog.monsters == null;
					object obj27 = !flag10;
					if (obj27 != null)
					{
						continue;
					}
					goto IL_0516;
				}
				goto IL_00a7;
			}
		}
		goto IL_0516;
		IL_0524:
		return (List<int>)(object)new IndexOutOfRangeException();
		IL_00a7:
		return list;
		IL_0516:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0524;
	}

	public static bool Locked(int number)
	{
		//IL_008a: Expected Obj, but got I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected I4, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		MonsterDirector.Entry entry = MonsterCatalog.Of(number);
		object obj4;
		if (entry != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = MayPlay(entry.name);
			obj4 = (flag2 ? 1 : 0) ^ 1;
		}
		else
		{
			obj4 = 0;
		}
		return (byte)(obj4 & 1) != 0;
	}

	public static void Pick(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!IsChoosable(name))
		{
			return;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v8+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10+A0]");
				obj6 = 0;
			}
			object obj9 = obj6 + 48;
			obj9 = name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC28]");
			object key = 0;
			PlayerPrefs.SetString((string)key, name);
			PlayerPrefs.Save();
		}
	}

	static MonsterChoice()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01e0: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		//IL_02b4: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_0367: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03e9: Expected Obj, but got I
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_043d: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		if (dictionary != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC58]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC50]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E50]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBCB8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC60]");
			object value2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
			object obj5 = 0;
			dictionary.Add((System.__Canon)obj2, (System.__Canon)value);
			dictionary.Add((System.__Canon)obj4, (System.__Canon)value2);
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v7+A0]");
			object obj7 = 0;
			obj7 = dictionary;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<System.__Canon, System.__Canon> dictionary2 = default;
			dictionary2._002Ector();
			if (dictionary2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC48]");
				object value3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6588]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C63E0]");
				object obj10 = 0;
				dictionary2.Add((System.__Canon)obj2, (System.__Canon)value3);
				object obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v12+A0]");
				object obj12 = (nint)0 + (nint)8;
				obj12 = dictionary2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				(System.__Canon, int) tuple = ((System.__Canon)obj2, 20);
				object obj13 = default;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D0]");
					object obj14 = 0;
					object obj15 = obj13 + 32;
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj16 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v14+A0]");
					object obj17 = (nint)0 + (nint)16;
					obj17 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					HashSet<System.__Canon> hashSet = default;
					hashSet._002Ector();
					if (hashSet != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC40]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
						object obj20 = 0;
						bool flag = hashSet.Add((System.__Canon)obj4);
						object obj21 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v17+A0]");
						object obj22 = (nint)0 + (nint)24;
						obj22 = hashSet;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Dictionary<System.__Canon, System.__Canon> dictionary3 = default;
						dictionary3._002Ector();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						System.__Canon _Canon = default;
						if (_Canon != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC68]");
							object obj23 = 0;
							object obj24 = _Canon + 32;
							obj24 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							if (dictionary3 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC30]");
								object obj25 = 0;
								dictionary3.Add((System.__Canon)obj2, _Canon);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								System.__Canon _Canon2 = default;
								if (_Canon2 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC70]");
									object obj26 = 0;
									object obj27 = _Canon2 + 32;
									obj27 = obj26;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC78]");
									object obj28 = 0;
									object obj29 = _Canon2 + 40;
									obj29 = obj28;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									dictionary3.Add((System.__Canon)obj4, _Canon2);
									object obj30 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v27+A0]");
									object obj31 = (nint)0 + (nint)32;
									obj31 = dictionary3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									HashSet<System.__Canon> hashSet2 = default;
									hashSet2._002Ector();
									object obj32 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v28+A0]");
									object obj33 = (nint)0 + (nint)40;
									obj33 = hashSet2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									return;
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}
}
