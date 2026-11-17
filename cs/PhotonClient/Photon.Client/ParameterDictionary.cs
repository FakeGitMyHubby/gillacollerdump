using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Photon.Client.StructWrapping;
using UnityEngine;
using UnityEngine.UIElements;

namespace Photon.Client;

public class ParameterDictionary : IEnumerable<KeyValuePair<string, string>>, _0021_00210
{
	public readonly NonAllocDictionary<byte, object> paramDict;

	public readonly StructWrapperPools wrapperPools;

	// C# has no syntax for parameterized property 'Item'.
	public object get_Item(byte key)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		object obj2 = default;
		object obj7;
		if (paramDict != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8178]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4E34");
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8188]");
				object obj3 = 0;
				nint num = (nint)obj2;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X9_v3 (Il2CppClass<System.Object>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v10+130]");
				bool flag = num2 < 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X9_v3 (Il2CppClass<System.Object>)+B0]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v10+130]");
					object obj6 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X9_v5-8]");
					obj7 = ((0 != (nint)obj4) ? null : obj2);
					goto IL_0137;
				}
			}
			obj7 = null;
			goto IL_0137;
		}
		return new NullReferenceException();
		IL_0137:
		if (obj7 != null)
		{
			return obj7;
		}
		return obj2;
	}

	public void set_Item(byte key, object value)
	{
		//IL_0015: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516488]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4EF4");
	}

	public int Count
	{
		get
		{
			//IL_0032: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			if (paramDict != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516490]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4BF8");
				int result = default;
				return result;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public ParameterDictionary()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516460]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516468]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516470]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StructWrapperPools structWrapperPools = default;
		structWrapperPools._002Ector();
		object obj4 = this + 24;
		obj4 = structWrapperPools;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4C18");
		object obj5 = this + 16;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public ParameterDictionary(int capacity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516460]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516468]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516470]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StructWrapperPools structWrapperPools = default;
		structWrapperPools._002Ector();
		object obj4 = this + 24;
		obj4 = structWrapperPools;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4C18");
		object obj5 = this + 16;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public static implicit operator NonAllocDictionary<byte, object>(ParameterDictionary value)
	{
		if (value != null)
		{
			return value.paramDict;
		}
		return (NonAllocDictionary<byte, object>)(object)new NullReferenceException();
	}

	private IEnumerator<KeyValuePair<byte, object>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EByte_002CSystem_002EObject_003E_003E_002EGetEnumerator()
	{
		//IL_000d: Expected I, but got Obj
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		NonAllocDictionary<byte, object> nonAllocDictionary = paramDict;
		if (paramDict != null)
		{
			nint num = (nint)nonAllocDictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516478]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+98]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj2--;
				obj3 += 16;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00a9;
			}
			object obj4 = num + obj3;
			object obj5 = obj4 + 312;
			goto IL_0133;
		}
		return (IEnumerator<KeyValuePair<byte, object>>)new NullReferenceException();
		IL_0133:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v149 @ X0_v3] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_00a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0133;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		//IL_000d: Expected I, but got Obj
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		NonAllocDictionary<byte, object> nonAllocDictionary = paramDict;
		if (paramDict != null)
		{
			nint num = (nint)nonAllocDictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516478]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Photon.Client.NonAllocDictionary`2<System.Byte, System.Object>>)+98]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj2--;
				obj3 += 16;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00a9;
			}
			object obj4 = num + obj3;
			object obj5 = obj4 + 312;
			goto IL_0133;
		}
		return (IEnumerator)new NullReferenceException();
		IL_0133:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v149 @ X0_v3] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_00a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0133;
	}

	public NonAllocDictionary<byte, object>.PairIterator GetEnumerator()
	{
		//IL_0032: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		if (paramDict != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516480]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5484");
			NonAllocDictionary<byte, object>.PairIterator result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (NonAllocDictionary<byte, object>.PairIterator)ex;
	}

	public void Clear()
	{
		//IL_0025: Expected Obj, but got I
		wrapperPools.Clear();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516498]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB593C");
	}

	public void Add(byte code, string value)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4D20");
		object obj3 = default;
		object obj2 = obj3 & 1;
		bool flag = obj2 == null;
		byte b = code;
		if (!flag)
		{
			string text = b.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A8]");
			object obj4 = 0;
			string message = text + (string)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516488]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4EF4");
	}

	public void Add(byte code, PhotonHashtable value)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4D20");
		object obj3 = default;
		object obj2 = obj3 & 1;
		bool flag = obj2 == null;
		byte b = code;
		if (!flag)
		{
			string text = b.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A8]");
			object obj4 = 0;
			string message = text + (string)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516488]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4EF4");
	}

	public void Add(byte code, byte value)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0135: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I
		if (paramDict != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516460]");
			object obj2 = 0;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4D20");
			object obj5 = default;
			object obj4 = obj5 & 1;
			bool flag = obj4 == null;
			byte b2 = default;
			byte b = b2;
			if (!flag)
			{
				string text = b.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A8]");
				object obj6 = 0;
				string message = text + (string)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v16+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogError(message);
				obj3 = 0;
			}
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v10+A0]");
			object obj12 = 0;
			object obj13 = obj12;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v10+18]");
				bool flag4 = (nint)0 < (nint)(int)value;
				object obj14 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v10+18]");
				object obj15 = -(int)value;
				bool flag5 = obj15 == null;
				object obj16 = ~obj14;
				object obj17 = obj16 | flag5;
				if (obj17 != null)
				{
					goto IL_0218;
				}
				if (paramDict != null)
				{
					object obj18 = obj12 + value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516488]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4EF4");
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0218;
		IL_0218:
		throw new IndexOutOfRangeException();
	}

	public void Add(byte code, bool value)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0135: Expected Obj, but got I4
		//IL_021c: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I
		if (paramDict != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516460]");
			object obj2 = 0;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4D20");
			object obj5 = default;
			object obj4 = obj5 & 1;
			bool flag = obj4 == null;
			byte b2 = default;
			byte b = b2;
			if (!flag)
			{
				string text = b.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A8]");
				object obj6 = 0;
				string message = text + (string)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v16+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogError(message);
				obj3 = 0;
			}
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v10+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v9+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v9+8]");
			if ((nint)0 != 0)
			{
				bool flag4 = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v10+18]");
				bool flag5 = (nint)(flag4 ? 1 : 0) < (nint)0;
				object obj14 = !flag5;
				if (obj14 != null)
				{
					goto IL_01e6;
				}
				if (paramDict != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516488]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v9+8]");
					object obj16 = (nint)0 + (nint)(value ? 1 : 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4EF4");
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01e6;
		IL_01e6:
		throw new IndexOutOfRangeException();
	}

	public void Add(byte code, short value)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4D20");
		object obj4 = default;
		object obj3 = obj4 & 1;
		bool flag = obj3 == null;
		byte b = code;
		if (!flag)
		{
			byte b2 = default;
			string text = b2.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A8]");
			object obj5 = 0;
			string message = text + (string)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
			obj2 = 0;
			b = b2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516488]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4EF4");
	}

	public void Add(byte code, int value)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4D20");
		object obj4 = default;
		object obj3 = obj4 & 1;
		bool flag = obj3 == null;
		byte b = code;
		if (!flag)
		{
			byte b2 = default;
			string text = b2.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A8]");
			object obj5 = 0;
			string message = text + (string)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
			obj2 = 0;
			b = b2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516488]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4EF4");
	}

	public void Add(byte code, long value)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4D20");
		object obj4 = default;
		object obj3 = obj4 & 1;
		bool flag = obj3 == null;
		byte b = code;
		if (!flag)
		{
			byte b2 = default;
			string text = b2.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A8]");
			object obj5 = 0;
			string message = text + (string)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
			obj2 = 0;
			b = b2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516488]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4EF4");
	}

	public void Add(byte code, object value)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4D20");
		object obj3 = default;
		object obj2 = obj3 & 1;
		bool flag = obj2 == null;
		byte b = code;
		if (!flag)
		{
			string text = b.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A8]");
			object obj4 = 0;
			string message = text + (string)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516488]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4EF4");
	}

	public unsafe T Unwrap<T>(byte key)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got Ref
		//IL_0140: Expected Obj, but got VT
		//IL_00af: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
				obj3 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+FC]");
		object obj7 = (nint)0 + (nint)15;
		object obj8 = obj7 & 0x1FFFFFFF0L;
		object obj9 = default;
		byte b = (byte)((ref *(byte*)(&obj9)) - (ref *(byte*)obj8));
		NullReferenceException ex = (NullReferenceException)(object)paramDict;
		if (paramDict != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8178]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4E34");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
			object obj11 = 0;
			object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			object obj13 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ X1_v3+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag3 = num != 0;
			T val = default;
			ex = (NullReferenceException)val;
			if (!flag3)
			{
				return val;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			if (num2 == 0)
			{
				ex = new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T result = default;
		return result;
	}

	public unsafe T Get<T>(byte key)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got Ref
		//IL_0140: Expected Obj, but got VT
		//IL_00af: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
				obj3 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+FC]");
		object obj7 = (nint)0 + (nint)15;
		object obj8 = obj7 & 0x1FFFFFFF0L;
		object obj9 = default;
		byte b = (byte)((ref *(byte*)(&obj9)) - (ref *(byte*)obj8));
		NullReferenceException ex = (NullReferenceException)(object)paramDict;
		if (paramDict != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8178]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4E34");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X3_v1+38]");
			object obj11 = 0;
			object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			object obj13 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ X1_v3+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag3 = num != 0;
			T val = default;
			ex = (NullReferenceException)val;
			if (!flag3)
			{
				return val;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			if (num2 == 0)
			{
				ex = new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T result = default;
		return result;
	}

	public bool ContainsKey(byte key)
	{
		//IL_0032: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		if (paramDict != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164A0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4D20");
			bool result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public object TryGetObject(byte key)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		if (paramDict != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8180]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4DC8");
			object obj3 = default;
			object obj2 = obj3 & 1;
			bool flag = obj2 == null;
			object obj4 = !flag;
			object obj5 = ~obj4;
			object result = default;
			if (obj5 == null)
			{
				return result;
			}
			return null;
		}
		return new NullReferenceException();
	}

	public bool TryGetValue(byte key, out object value)
	{
		//IL_0032: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		if (paramDict != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8180]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4DC8");
			bool result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe bool TryGetValue<T>(byte key, out T value) where T : struct
	{
		//IL_0029: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected I4, but got Unknown
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01c5: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I
		//IL_02c3: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_032f: Expected Obj, but got I4
		//IL_03bf: Expected I4, but got Obj
		//IL_03a1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8180]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4DC8");
		object obj3 = default;
		object obj2 = obj3 & 1;
		object obj12;
		if (obj2 != null)
		{
			object obj4 = (nint)0 + (nint)309;
			object obj5 = obj4 & 1;
			bool flag = obj5 == null;
			object obj6 = !flag;
			nint num = 0;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			object obj7 = default;
			if (obj7 != null)
			{
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v30+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v15 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1<T>>)+130]");
				bool flag2 = num2 < 0;
				object obj9 = !flag2;
				object obj10 = ~obj9;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v30+B0]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v15 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1<T>>)+130]");
					object obj11 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v32-8]");
					if (0 == num)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-28_v5+2C]");
						obj12 = 0;
						goto IL_03d2;
					}
				}
			}
			if (obj7 != null)
			{
				object obj13 = typeof(Predicate<VisualElement>) + 2096;
				object obj14 = obj7;
				object obj15 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X9_v9+130]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v23+130]");
				bool flag3 = num4 < 0;
				object obj16 = !flag3;
				object obj17 = ~obj16;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X9_v9+B0]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v23+130]");
					object obj18 = num5 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X9_v11-8]");
					if (0 == (nint)obj15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-28_v5+30]");
						object obj19 = 0;
						object obj20 = (nint)0 + (nint)309;
						object obj21 = obj20 & 1;
						bool flag4 = obj21 == null;
						object obj22 = !flag4;
						nint num6 = 0;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
							IntPtr intPtr = default;
							num6 = intPtr;
						}
						object obj23 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v27+40]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X1_v11 (Il2CppClass<T>)+40]");
						if (num7 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X21_v8+10]");
							obj12 = 0;
							goto IL_03d2;
						}
						InvalidCastException ex = new InvalidCastException();
						return (byte)(int)ex != 0;
					}
				}
			}
			object obj24 = (nint)0 + (nint)309;
			object obj25 = obj24 & 1;
			bool flag5 = obj25 == null;
			object obj26 = !flag5;
			nint num8 = 0;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr2 = default;
				num8 = intPtr2;
			}
			object obj27 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v18+40]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X1_v8 (Il2CppClass<T>)+40]");
			if (num9 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-28_v5+10]");
				obj12 = 0;
				goto IL_03d2;
			}
			throw new InvalidCastException();
		}
		ref T reference = ref *(T*)null;
		goto IL_03bf;
		IL_03d2:
		reference = ref *(T*)obj12;
		goto IL_03bf;
		IL_03bf:
		return (byte)(obj3 & 1) != 0;
	}

	public string ToStringFull(bool includeTypes = default(bool))
	{
		//IL_0015: Expected Obj, but got I
		if (includeTypes)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65164B0]");
			object format = 0;
			string arg = SupportClass.DictionaryToString(paramDict, includeTypes: true);
			return string.Format((string)format, arg);
		}
		return SupportClass.DictionaryToString(paramDict, includeTypes: false);
	}
}
