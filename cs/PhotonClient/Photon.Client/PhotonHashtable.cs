using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Photon.Client;

public class PhotonHashtable : Dictionary<object, object>
{
	private static readonly object[] boxedByte;

	// C# has no syntax for parameterized property 'Item'.
	public object get_Item(object key)
	{
		bool flag = ((Dictionary<System.__Canon, System.__Canon>)(object)this).TryGetValue((System.__Canon)key, out System.__Canon _);
		return null;
	}

	public void set_Item(object key, object value)
	{
		((Dictionary<System.__Canon, System.__Canon>)(object)this).set_Item((System.__Canon)key, (System.__Canon)value);
	}

	// C# has no syntax for parameterized property 'Item'.
	public object get_Item(byte key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
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
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)(int)key;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+18]");
			object obj7 = -(int)key;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				object obj10 = obj4 + key;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v6+20]");
				bool flag4 = ((Dictionary<System.__Canon, System.__Canon>)(object)this).TryGetValue((System.__Canon)0, out System.__Canon value);
				return value;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return new IndexOutOfRangeException();
	}

	public void set_Item(byte key, object value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)(int)key;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+18]");
			object obj7 = -(int)key;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				object obj10 = obj4 + key;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+20]");
				((Dictionary<System.__Canon, System.__Canon>)(object)this).set_Item((System.__Canon)0, (System.__Canon)value);
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	// C# has no syntax for parameterized property 'Item'.
	public object get_Item(int key)
	{
		//IL_0016: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		System.__Canon key2 = default;
		bool flag = ((Dictionary<System.__Canon, System.__Canon>)(object)this).TryGetValue(key2, out System.__Canon value);
		return value;
	}

	public void set_Item(int key, object value)
	{
		//IL_0016: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		System.__Canon key2 = default;
		((Dictionary<System.__Canon, System.__Canon>)(object)this).set_Item(key2, (System.__Canon)value);
	}

	public static object GetBoxedByte(byte value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
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
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)(int)value;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			object obj7 = -(int)value;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				object obj10 = obj4 + value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+20]");
				return 0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return new IndexOutOfRangeException();
	}

	unsafe static PhotonHashtable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I
		//IL_0142: Expected Obj, but got Ref
		//IL_003c: Expected Obj, but got Ref
		//IL_00ba: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+A0]");
		object obj4 = 0;
		object obj5 = default;
		obj4 = obj5;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj7 = 0;
		object obj8 = 32;
		object obj9 = 0;
		object obj13 = default;
		object obj15 = default;
		IndexOutOfRangeException ex = default;
		while (true)
		{
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7+A0]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj14;
			object obj17;
			if (obj11 != null)
			{
				bool flag = obj13 == null;
				obj14 = (object)(&obj15);
				if (!flag)
				{
					object obj16 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v13+40]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag2 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v13+40]");
					obj17 = 0;
					if (flag2)
					{
						break;
					}
				}
				object obj18 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X24_v2+18]");
				bool flag3 = (nint)obj18 < 0;
				object obj19 = !flag3;
				if (obj19 == null)
				{
					object obj20 = obj11 + obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj21 = obj9 + 1;
					obj8 += 8;
					bool flag4 = (nint)obj21 != 256;
					obj15 = obj9;
					obj9 = obj21;
					if (!flag4)
					{
						return;
					}
					continue;
				}
			}
			else
			{
				NullReferenceException ex2 = new NullReferenceException();
				obj14 = (object)(&obj15);
			}
			ex = new IndexOutOfRangeException();
			obj17 = obj14;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	public PhotonHashtable()
	{
		((Dictionary<System.__Canon, System.__Canon>)(object)this)._002Ector(7);
	}

	public PhotonHashtable(int x)
	{
		((Dictionary<System.__Canon, System.__Canon>)(object)this)._002Ector(x);
	}

	public void Add(byte k, object v)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)(int)k;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+18]");
			object obj7 = -(int)k;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				object obj10 = obj4 + k;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+20]");
				((Dictionary<System.__Canon, System.__Canon>)(object)this).Add((System.__Canon)0, (System.__Canon)v);
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	public void Add(int k, object v)
	{
		//IL_0016: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		System.__Canon key = default;
		((Dictionary<System.__Canon, System.__Canon>)(object)this).Add(key, (System.__Canon)v);
	}

	public void Remove(byte k)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)(int)k;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5+18]");
			object obj7 = -(int)k;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				object obj10 = obj4 + k;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6+20]");
				bool flag4 = ((Dictionary<System.__Canon, System.__Canon>)(object)this).Remove((System.__Canon)0);
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	public void Remove(int k)
	{
		//IL_0016: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		System.__Canon key = default;
		bool flag = ((Dictionary<System.__Canon, System.__Canon>)(object)this).Remove(key);
	}

	public bool ContainsKey(byte key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_00da: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)(int)key;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5+18]");
			object obj7 = -(int)key;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				object obj10 = obj4 + key;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6+20]");
				return ((Dictionary<System.__Canon, System.__Canon>)(object)this).ContainsKey((System.__Canon)0);
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public new unsafe DictionaryEntryEnumerator GetEnumerator()
	{
		//IL_0027: Expected native int or pointer, but got VT
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = ((Dictionary<System.__Canon, System.__Canon>)(object)this).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		DictionaryEntryEnumerator dictionaryEntryEnumerator = default;
		Dictionary<object, object>.Enumerator enumerator2 = default;
		System.Runtime.CompilerServices.Unsafe.Write(&((DictionaryEntryEnumerator*)(nint)dictionaryEntryEnumerator)->enumerator, enumerator2);
		DictionaryEntryEnumerator result = default;
		return result;
	}

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected Obj, but got I4
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected Obj, but got I4
		//IL_096c: Expected Obj, but got I4
		//IL_0d5f: Expected Obj, but got I
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d70: Expected Ref, but got Unknown
		//IL_0d8a: Expected Obj, but got I4
		//IL_098b: Expected Obj, but got I4
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected Obj, but got Unknown
		//IL_021d: Expected I, but got Obj
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got I4
		//IL_0c7c: Expected Obj, but got I4
		//IL_024f: Expected I, but got Obj
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_0b5a: Expected Obj, but got I4
		//IL_09d8: Expected Obj, but got I4
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_0bb9: Expected Obj, but got I4
		//IL_0a29: Expected Obj, but got I
		//IL_0319: Expected Obj, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got VT
		//IL_03b1: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I
		//IL_03d7: Expected Obj, but got I4
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected Obj, but got I4
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0387: Expected Obj, but got I4
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Expected Obj, but got I8
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_0428: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected Obj, but got Unknown
		//IL_04a1: Expected I, but got Obj
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got I4
		//IL_04d8: Expected Obj, but got I8
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_053f: Expected Obj, but got I4
		//IL_0555: Expected Obj, but got I
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected Obj, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected Obj, but got Unknown
		//IL_0cde: Expected Obj, but got I4
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got Unknown
		//IL_069a: Expected Obj, but got I4
		//IL_06b0: Expected Obj, but got I
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected Obj, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_0d0f: Expected Obj, but got I8
		//IL_074b: Expected I, but got Obj
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected Obj, but got I4
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected Obj, but got Unknown
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected Obj, but got I4
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got VT
		//IL_090a: Expected Obj, but got I
		//IL_091a: Expected Obj, but got I
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected Obj, but got Unknown
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected Obj, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515818]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj2 = obj;
		Dictionary<System.__Canon, System.__Canon>.KeyCollection keys = ((Dictionary<System.__Canon, System.__Canon>)(object)this).Keys;
		bool flag = keys == null;
		object obj4 = default;
		object obj3 = obj4;
		Enumerator<> val = (Enumerator<>)0;
		object obj5 = 109924352;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D45E0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7100]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516018]");
			object obj10 = 0;
			Enumerator<> enumerator = keys.GetEnumerator();
			Enumerator<> val2 = (Enumerator<>)(ref val);
			string text2 = default;
			object obj13 = default;
			System.__Canon _Canon2 = default;
			object obj31 = default;
			System.__Canon _Canon3 = default;
			Enumerator<> val3 = default;
			string result = default;
			object obj60 = default;
			while (true)
			{
				System.__Canon _Canon;
				if (val.MoveNext())
				{
					string text4;
					if (obj4 != null)
					{
						object obj11 = this.get_Item(obj4);
						if (obj11 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							bool flag2 = text2 == null;
							_Canon = (System.__Canon)8;
							text = text2;
							if (flag2)
							{
								goto IL_0a7c;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v68 (System.String)+18]");
							bool flag3 = (nint)0 == 0;
							_Canon = (System.__Canon)8;
							text = text2;
							if (!flag3)
							{
								object obj12 = text2 + 32;
								obj12 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
								if (obj13 != null)
								{
									object obj14 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v56+168]");
									val2 = (Enumerator<>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v764 @ X8_v56+168] (should have been resolved before IL gen)");
									_Canon = _Canon2;
								}
								else
								{
									_Canon = null;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v68 (System.String)+18]");
								object obj15 = 0 & 0xFFFFFFFEL;
								if (obj15 != null)
								{
									object obj16 = text2 + 40;
									obj16 = _Canon;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v68 (System.String)+18]");
									bool flag4 = (nint)0 < (nint)2;
									object obj17 = !flag4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v68 (System.String)+18]");
									object obj18 = -2;
									bool flag5 = obj18 == null;
									object obj19 = ~obj17;
									object obj20 = obj19 | flag5;
									text = text2;
									if (obj20 != null)
									{
										goto IL_0a6e;
									}
									object obj21 = text2 + 48;
									obj21 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									nint num = (nint)obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X8_v43 (Il2CppClass<System.Object>)+168]");
									val2 = (Enumerator<>)0;
									object obj22 = obj4.GetHashCode();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v68 (System.String)+18]");
									object obj23 = 0 & 0xFFFFFFFCL;
									bool flag6 = obj23 == null;
									_Canon = (System.__Canon)obj22;
									if (!flag6)
									{
										object obj24 = text2 + 56;
										obj24 = obj22;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v68 (System.String)+18]");
										bool flag7 = (nint)0 < (nint)4;
										object obj25 = !flag7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v68 (System.String)+18]");
										object obj26 = -4;
										bool flag8 = obj26 == null;
										object obj27 = ~obj25;
										object obj28 = obj27 | flag8;
										obj2 = obj22;
										text = text2;
										if (obj28 != null)
										{
											goto IL_0abc;
										}
										object obj29 = text2 + 64;
										obj29 = obj10;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj30 = this.get_Item(obj4);
										bool flag9 = obj30 == null;
										obj2 = obj4;
										text = text2;
										if (flag9)
										{
											goto IL_0aae;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
										if (obj31 != null)
										{
											object obj32 = obj31;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v55+168]");
											val2 = (Enumerator<>)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v841 @ X8_v55+168] (should have been resolved before IL gen)");
											_Canon = _Canon3;
										}
										else
										{
											_Canon = null;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v68 (System.String)+18]");
										bool flag10 = (nint)0 < (nint)6;
										object obj33 = !flag10;
										object obj34 = ~obj33;
										if (obj34 == null)
										{
											object obj35 = text2 + 72;
											obj35 = _Canon;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v68 (System.String)+18]");
											bool flag11 = (nint)0 < (nint)6;
											object obj36 = !flag11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v68 (System.String)+18]");
											object obj37 = -6;
											bool flag12 = obj37 == null;
											object obj38 = ~obj36;
											object obj39 = obj38 | flag12;
											obj2 = _Canon;
											text = text2;
											if (obj39 != null)
											{
												goto IL_0aa0;
											}
											object obj40 = text2 + 80;
											obj40 = obj9;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj41 = this.get_Item(obj4);
											if (obj41 != null)
											{
												nint num2 = (nint)obj41;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ X8_v54 (Il2CppClass<System.Object>)+168]");
												val2 = (Enumerator<>)0;
												int hashCode = obj41.GetHashCode();
												_Canon = (System.__Canon)hashCode;
											}
											else
											{
												_Canon = null;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v68 (System.String)+18]");
											object obj42 = 0 & 0xFFFFFFF8L;
											if (obj42 != null)
											{
												object obj43 = text2 + 88;
												obj43 = _Canon;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												string text3 = string.Concat((string[])(object)text2);
												bool flag13 = list == null;
												_Canon = (System.__Canon)(object)text3;
												text = text2;
												if (!flag13)
												{
													System.__Canon[] items = list._items;
													val2 = (Enumerator<>)obj7;
													int version = list._version + 1;
													list._version = version;
													bool flag14 = list._items == null;
													_Canon = (System.__Canon)(object)text3;
													text = text2;
													if (!flag14)
													{
														version = list._size;
														bool flag15 = list._size < items.Length;
														object obj44 = !flag15;
														if (obj44 == null)
														{
															object obj45 = list._items + list._size;
															int num3 = ++list._size;
															object obj46 = obj45 + 32;
															obj46 = text3;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															val2 = (Enumerator<>)num3;
															text = text2;
														}
														else
														{
															System.__Canon _Canon4 = (System.__Canon)val2._currentKey;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X8_v52 (System.__Canon)+A8]");
															object obj47 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v53+70]");
															text4 = (string)0;
															list.AddWithResize((System.__Canon)(object)text3);
															text = text2;
														}
														continue;
													}
												}
												goto IL_0a60;
											}
										}
									}
								}
								IndexOutOfRangeException ex = new IndexOutOfRangeException();
								goto IL_0a52;
							}
							goto IL_0a8a;
						}
						nint num4 = (nint)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v37 (Il2CppClass<System.Object>)+168]");
						val2 = (Enumerator<>)0;
						int hashCode2 = obj4.GetHashCode();
						text = (string)hashCode2;
					}
					else
					{
						text = null;
					}
					object obj48 = this.get_Item(obj4);
					if (obj48 != null)
					{
						nint num5 = (nint)obj48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v28 (Il2CppClass<System.Object>)+168]");
						val2 = (Enumerator<>)0;
						int hashCode3 = obj48.GetHashCode();
						text4 = (string)hashCode3;
					}
					else
					{
						text4 = null;
					}
					string text5 = text + (string)obj6 + text4;
					bool flag16 = list == null;
					object obj49 = 0;
					_Canon = (System.__Canon)(object)text5;
					if (!flag16)
					{
						System.__Canon[] items2 = list._items;
						val2 = (Enumerator<>)obj7;
						int version = list._version + 1;
						list._version = version;
						bool flag17 = list._items == null;
						obj49 = 0;
						_Canon = (System.__Canon)(object)text5;
						if (!flag17)
						{
							version = list._size;
							bool flag18 = list._size < items2.Length;
							object obj50 = !flag18;
							if (obj50 == null)
							{
								object obj51 = list._items + list._size;
								int num6 = ++list._size;
								object obj52 = obj51 + 32;
								obj52 = text5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								obj49 = 0;
								val2 = (Enumerator<>)num6;
							}
							else
							{
								System.__Canon _Canon5 = (System.__Canon)val2._currentKey;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v26 (System.__Canon)+A8]");
								object obj53 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v27+70]");
								text4 = (string)0;
								list.AddWithResize((System.__Canon)(object)text5);
								obj49 = 0;
							}
							continue;
						}
					}
					goto IL_0a52;
				}
				obj3 = null;
				val = val3;
				object obj54 = 0;
				Enumerator<> val4 = val3;
				Enumerator<> val5 = (Enumerator<>)(ref val);
				object obj55 = 0;
				object obj56 = 20;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515820]");
					object obj57 = 0;
					obj2 = obj57;
					((Enumerator<>*)val5)->Dispose();
					bool flag19 = obj55 == null;
					object obj58 = !flag19;
					if (obj58 == null)
					{
						bool flag20 = obj3 == null;
						object obj59 = !flag20;
						OutOfMemoryException ex2 = (OutOfMemoryException)val5;
						if (obj59 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj2 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj3 = 1;
						obj55 = obj54;
					}
					else
					{
						if ((nint)obj2 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEAE10");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return result;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj55 = obj60;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj54 = obj60;
					}
					obj56 = 0;
				}
				string result2;
				if ((nint)obj56 != 20)
				{
					bool flag21 = obj56 == null;
					object obj61 = !flag21;
					result2 = (string)val5;
					if (obj61 != null)
					{
						goto IL_0a3f;
					}
				}
				if (list == null)
				{
					break;
				}
				System.__Canon[] value = list.ToArray();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
				object separator = 0;
				result2 = string.Join((string)separator, (string[])(object)value);
				goto IL_0a3f;
				IL_0a52:
				NullReferenceException ex3 = new NullReferenceException();
				goto IL_0a60;
				IL_0a60:
				NullReferenceException ex4 = new NullReferenceException();
				goto IL_0a6e;
				IL_0a6e:
				IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
				goto IL_0a7c;
				IL_0a8a:
				IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
				obj2 = _Canon;
				goto IL_0aa0;
				IL_0aa0:
				IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
				goto IL_0aae;
				IL_0abc:
				IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
				obj3 = null;
				val = val3;
				obj54 = 0;
				val4 = val3;
				val5 = (Enumerator<>)(ref val);
				break;
				IL_0a7c:
				NullReferenceException ex9 = new NullReferenceException();
				goto IL_0a8a;
				IL_0aae:
				NullReferenceException ex10 = new NullReferenceException();
				goto IL_0abc;
				IL_0a3f:
				return result2;
			}
		}
		throw new NullReferenceException();
	}

	public object Clone()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6503C18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector((IDictionary<System.__Canon, System.__Canon>)this);
		return dictionary;
	}
}
