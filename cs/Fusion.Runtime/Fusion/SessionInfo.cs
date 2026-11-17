using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public class SessionInfo
{
	private string Name__BackingField;

	private string Region__BackingField;

	private ReadOnlyDictionary<string, SessionProperty> Properties__BackingField;

	private int PlayerCount__BackingField;

	private int MaxPlayers__BackingField;

	internal bool _isValid;

	internal bool _isOpen;

	internal bool _isVisible;

	private readonly NetworkRunner _runner;

	public bool IsValid => _isValid;

	public string Name
	{
		get
		{
			return Name__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string Region
	{
		get
		{
			return Region__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool IsVisible
	{
		get
		{
			return _isVisible;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0177: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_0126: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = (UnityEngine.Object)_runner == (UnityEngine.Object)null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				return;
			}
			if (_runner.IsSinglePlayer)
			{
				_isVisible = value;
				return;
			}
			NetworkRunner runner = _runner;
			if ((object)_runner != null && (object)runner._cloudServices != null)
			{
				bool value2 = runner._cloudServices.UpdateRoomIsVisible(value);
				bool? flag4 = value2;
				bool flag5 = 0 < 256;
				object obj5 = !flag5;
				object obj6 = ~obj5;
				if (obj6 == null)
				{
					_isValid = false;
				}
			}
		}
	}

	public bool IsOpen
	{
		get
		{
			return _isOpen;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0177: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_0126: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = (UnityEngine.Object)_runner == (UnityEngine.Object)null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				return;
			}
			if (_runner.IsSinglePlayer)
			{
				_isOpen = value;
				return;
			}
			NetworkRunner runner = _runner;
			if ((object)_runner != null && (object)runner._cloudServices != null)
			{
				bool value2 = runner._cloudServices.UpdateRoomIsOpen(value);
				bool? flag4 = value2;
				bool flag5 = 0 < 256;
				object obj5 = !flag5;
				object obj6 = ~obj5;
				if (obj6 == null)
				{
					_isValid = false;
				}
			}
		}
	}

	public ReadOnlyDictionary<string, SessionProperty> Properties
	{
		get
		{
			return Properties__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public int PlayerCount
	{
		get
		{
			return PlayerCount__BackingField;
		}
		internal set
		{
			PlayerCount__BackingField = value;
		}
	}

	public int MaxPlayers
	{
		get
		{
			return MaxPlayers__BackingField;
		}
		internal set
		{
			MaxPlayers__BackingField = value;
		}
	}

	public static implicit operator bool(SessionInfo sessionInfo)
	{
		//IL_0017: Expected I4, but got Obj
		bool flag = sessionInfo == null;
		bool result = (byte)(int)sessionInfo != 0;
		if (!flag)
		{
			bool flag2 = !sessionInfo._isValid;
			bool flag3 = !flag2;
			result = flag3;
		}
		return result;
	}

	internal SessionInfo(NetworkRunner runner = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		base._002Ector();
		object obj2 = this + 56;
		obj2 = runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)runner != (UnityEngine.Object)null && runner.IsSinglePlayer)
		{
			_isValid = true;
		}
	}

	public unsafe bool UpdateCustomProperties(Dictionary<string, SessionProperty> customProperties)
	{
		//IL_0010: Expected Obj, but got I
		//IL_052e: Expected Obj, but got I4
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected I4, but got Unknown
		//IL_00c3: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0138: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I4
		//IL_0311: Expected VT, but got Ref
		//IL_031a: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got I4
		//IL_03fe: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I
		//IL_05c5: Expected Ref, but got VT
		//IL_05df: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got I4
		//IL_0422: Expected VT, but got Ref
		//IL_0342: Expected Obj, but got I4
		//IL_034a: Expected Obj, but got VT
		//IL_03b5: Expected Obj, but got I
		//IL_03cf: Expected Obj, but got I
		//IL_0491: Expected Obj, but got I4
		//IL_038f: Expected Obj, but got I4
		//IL_04f0: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		UnityEngine.Object runner = _runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (runner == null)
		{
			goto IL_004f;
		}
		bool flag2 = (object)_runner == null;
		System.__Canon _Canon = null;
		UnityEngine.Object obj4 = null;
		SessionInfo sessionInfo = this;
		NetworkRunner networkRunner;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator2 = default;
		NetworkRunner networkRunner2;
		object obj14;
		bool? flag3;
		if (!flag2)
		{
			if (!_runner.IsSinglePlayer)
			{
				networkRunner = _runner;
				if ((object)_runner != null)
				{
					if ((object)networkRunner._cloudServices == null)
					{
						goto IL_004f;
					}
					bool value = networkRunner._cloudServices.UpdateRoomProperties(customProperties);
					flag3 = value;
					bool flag4 = 0 < 256;
					object obj5 = !flag4;
					object obj6 = ~obj5;
					networkRunner = null;
					if (obj6 == null)
					{
						_isValid = false;
						goto IL_03f5;
					}
				}
				goto IL_053c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3C8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3B8]");
			object obj8 = 0;
			obj4 = (UnityEngine.Object)obj8;
			Dictionary<System.__Canon, System.__Canon> dictionary = default;
			dictionary._002Ector();
			sessionInfo = (SessionInfo)(this + 32);
			bool flag5 = sessionInfo == null;
			_Canon = null;
			runner = (UnityEngine.Object)(object)dictionary;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57D8]");
				object obj9 = 0;
				obj4 = (UnityEngine.Object)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @42840A4");
				object obj10 = default;
				bool flag6 = (nint)obj10 < 1;
				_Canon = null;
				runner = (UnityEngine.Object)(object)dictionary;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57D0]");
					object obj11 = 0;
					_Canon = (System.__Canon)obj11;
					Dictionary<System.__Canon, System.__Canon> dictionary2 = default;
					dictionary2._002Ector((IDictionary<System.__Canon, System.__Canon>)sessionInfo);
					obj4 = (UnityEngine.Object)(object)sessionInfo;
					runner = (UnityEngine.Object)(object)dictionary2;
				}
			}
			if ((object)customProperties != null)
			{
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = ((Dictionary<System.__Canon, System.__Canon>)(object)customProperties).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4A68]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3C0]");
				object obj13 = 0;
				System.__Canon _Canon2 = default;
				while (true)
				{
					obj4 = (UnityEngine.Object)obj12;
					if (!enumerator2.MoveNext())
					{
						break;
					}
					if ((object)runner != null)
					{
						((Dictionary<System.__Canon, System.__Canon>)(object)runner).set_Item((System.__Canon)null, _Canon2);
						_Canon = _Canon2;
						continue;
					}
					goto IL_0403;
				}
				networkRunner2 = null;
				obj14 = 0;
				flag3 = (bool?)(object)(&enumerator2);
				object obj15 = 0;
				object obj16 = 10;
				bool result = default;
				object obj20 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4A60]");
					object obj17 = 0;
					obj4 = (UnityEngine.Object)obj17;
					((Dictionary<System.__Canon, System.__Canon>.Enumerator*)flag3)->Dispose();
					bool flag7 = obj15 == null;
					object obj18 = !flag7;
					if (obj18 == null)
					{
						bool flag8 = (object)networkRunner2 == null;
						object obj19 = !flag8;
						OutOfMemoryException ex = (OutOfMemoryException)flag3;
						if (obj19 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj4 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						networkRunner2 = (NetworkRunner)1;
						obj15 = obj14;
					}
					else
					{
						if ((nint)obj4 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A32FC");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return result;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj15 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj14 = obj20;
					}
					obj16 = 0;
				}
				if ((nint)obj16 != 10)
				{
					bool flag9 = obj16 == null;
					object obj21 = !flag9;
					networkRunner = networkRunner2;
					if (obj21 != null)
					{
						goto IL_053c;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5240]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5238]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4283AD0");
				object obj24 = default;
				sessionInfo = (SessionInfo)obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				goto IL_03f5;
			}
		}
		goto IL_0427;
		IL_0427:
		throw new NullReferenceException();
		IL_0403:
		NullReferenceException ex2 = new NullReferenceException();
		networkRunner2 = null;
		obj14 = 0;
		flag3 = (bool?)(object)(&enumerator2);
		goto IL_0427;
		IL_03f5:
		networkRunner = (NetworkRunner)1;
		goto IL_053c;
		IL_004f:
		networkRunner = null;
		goto IL_053c;
		IL_053c:
		return (byte)(networkRunner & 1) != 0;
	}

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_088d: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		//IL_080d: Expected Obj, but got I4
		//IL_085c: Expected Obj, but got I4
		//IL_0a19: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I
		//IL_05d0: Expected Obj, but got I
		//IL_05e0: Expected Obj, but got I
		//IL_06ca: Expected Obj, but got I4
		//IL_073d: Expected Obj, but got I
		//IL_0a5b: Expected Obj, but got I
		//IL_061b: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_02c3: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I4
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected Obj, but got Unknown
		//IL_0717: Expected Obj, but got I4
		//IL_0636: Expected Obj, but got I
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected Obj, but got Unknown
		//IL_0786: Expected Obj, but got I4
		//IL_079b: Expected Obj, but got Ref
		//IL_0320: Expected Obj, but got I
		//IL_08ed: Expected Obj, but got I
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected Obj, but got Unknown
		//IL_035b: Expected Obj, but got I
		//IL_0595: Expected Obj, but got I4
		//IL_05aa: Expected Obj, but got Ref
		//IL_05b3: Expected Obj, but got I4
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_037e: Expected Obj, but got I
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_0461: Expected Obj, but got I
		//IL_0972: Expected Obj, but got I
		//IL_049c: Expected Obj, but got I
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected Obj, but got Unknown
		//IL_09d0: Expected Obj, but got I4
		//IL_057d: Expected Obj, but got I
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_04bf: Expected Obj, but got I
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57E0]");
		object value = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D54E0]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector((string)value);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object obj4 = obj2;
		object obj5 = default;
		string value2 = string.Format((string)format, obj2, obj5);
		bool flag = stringBuilder == null;
		object obj6 = 0;
		object obj7 = 0;
		object obj8 = obj5;
		object obj9 = 109895680;
		if (flag)
		{
			goto IL_07a0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5830]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5818]");
		object arg = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5838]");
		object arg2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5828]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5810]");
		object arg3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5808]");
		obj9 = 0;
		StringBuilder stringBuilder2 = stringBuilder.Append(value2);
		string value3 = (string)obj10 + Name__BackingField + (string)obj11;
		StringBuilder stringBuilder3 = stringBuilder.Append(value3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg4 = default;
		string value4 = string.Format((string)format, arg, arg4);
		StringBuilder stringBuilder4 = stringBuilder.Append(value4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg5 = default;
		string value5 = string.Format((string)format, arg2, arg5);
		StringBuilder stringBuilder5 = stringBuilder.Append(value5);
		string value6 = (string)obj12 + Region__BackingField + (string)obj11;
		StringBuilder stringBuilder6 = stringBuilder.Append(value6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg6 = default;
		string value7 = string.Format((string)format, arg3, arg6);
		StringBuilder stringBuilder7 = stringBuilder.Append(value7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg7 = default;
		string value8 = string.Format((string)format, obj9, arg7);
		StringBuilder stringBuilder8 = stringBuilder.Append(value8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5820]");
		object value9 = 0;
		StringBuilder stringBuilder9 = stringBuilder.Append((string)value9);
		if ((object)Properties__BackingField == null)
		{
			goto IL_072d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57F8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57F0]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5800]");
		obj2 = 0;
		string text = (string)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4284360");
		obj7 = 0;
		obj8 = null;
		object obj15 = default;
		bool flag3 = default;
		object obj24 = default;
		object arg9 = default;
		object obj30 = default;
		OutOfMemoryException ex3 = default;
		object obj31 = default;
		object obj17;
		object obj20;
		while (true)
		{
			if (obj15 != null)
			{
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v39+12E]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v39+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03e0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v39+98]");
				object obj18 = (nint)0 + (nint)8;
				bool flag2 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X10_v28-8]");
					object obj19 = 0 - obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X10_v28-8]");
					if (0 == (nint)obj14)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v39+12E]");
					obj17 = -1;
					obj19 = obj17 - 1;
					bool flag4 = obj19 == null;
					obj20 = obj18 + 16;
					flag3 = (nint)obj17 != 1;
					flag2 = flag3;
					obj18 = obj20;
					if (flag3)
					{
						continue;
					}
					goto IL_03e0;
				}
				obj17 = obj18;
				object obj21 = obj16 + obj18;
				object obj22 = obj21 + 312;
				flag3 = flag2;
				obj20 = obj18;
				goto IL_08dd;
			}
			NullReferenceException ex = new NullReferenceException();
			obj4 = text;
			goto IL_0774;
			IL_08dd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X0_v83+8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v851 @ X0_v83] (should have been resolved before IL gen)");
			object obj23 = obj24 & 1;
			if (obj23 == null)
			{
				break;
			}
			if (obj15 == null)
			{
				goto IL_0774;
			}
			object obj25 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X8_v42+12E]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X8_v42+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0521;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X8_v42+98]");
			object obj26 = (nint)0 + (nint)8;
			bool flag5 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X10_v23-8]");
				object obj19 = 0 - obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X10_v23-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X8_v42+12E]");
				obj17 = -1;
				obj19 = obj17 - 1;
				bool flag4 = obj19 == null;
				obj20 = obj26 + 16;
				flag3 = (nint)obj17 != 1;
				flag5 = flag3;
				obj26 = obj20;
				if (flag3)
				{
					continue;
				}
				goto IL_0521;
			}
			obj17 = obj26;
			object obj27 = obj25 + obj26;
			object obj28 = obj27 + 312;
			flag3 = flag5;
			obj20 = obj26;
			goto IL_0962;
			IL_0521:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj8 = null;
			goto IL_0962;
			IL_0962:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v86+8]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v914 @ X0_v86] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v86+8]");
			object arg8;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X1_v39+10]");
				arg8 = 0;
			}
			else
			{
				arg8 = null;
			}
			string text2 = string.Format((string)obj2, arg9, arg8);
			StringBuilder stringBuilder10 = stringBuilder.Append(text2);
			obj7 = 0;
			obj8 = null;
			text = text2;
			continue;
			IL_0774:
			NullReferenceException ex2 = new NullReferenceException();
			obj30 = 0;
			ex3 = null;
			obj6 = obj15;
			obj31 = (object)(&obj6);
			goto IL_07a0;
			IL_03e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj8 = null;
			goto IL_08dd;
		}
		obj30 = 0;
		ex3 = null;
		obj6 = obj15;
		obj31 = (object)(&obj6);
		object obj32 = 7;
		goto IL_0a92;
		IL_07bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)obj4 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj30 = 1;
		}
		else
		{
			if ((nint)obj4 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				string result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj33 = default;
			ex3 = (OutOfMemoryException)obj33;
		}
		obj32 = 0;
		goto IL_0a92;
		IL_072d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
		object value10 = 0;
		StringBuilder stringBuilder11 = stringBuilder.Append((string)value10);
		((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
		goto IL_0a6a;
		IL_0a6a:
		string result2 = default;
		return result2;
		IL_07a0:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_07ae;
		IL_09ff:
		bool flag6 = ex3 == null;
		object obj34 = !flag6;
		if (obj34 != null)
		{
			goto IL_07ae;
		}
		bool flag7 = obj30 == null;
		object obj35 = !flag7;
		OutOfMemoryException ex5 = ex3;
		if (obj35 == null)
		{
			if ((nint)obj32 != 7)
			{
				bool flag8 = obj32 == null;
				object obj36 = !flag8;
				result2 = (string)(object)ex3;
				if (obj36 != null)
				{
					goto IL_0a6a;
				}
			}
			goto IL_072d;
		}
		goto IL_07bc;
		IL_0a92:
		object obj37 = obj31;
		if (obj31 == null)
		{
			goto IL_09ff;
		}
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v9+12E]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v9+12E]");
		if ((nint)0 == 0)
		{
			goto IL_066c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v9+98]");
		object obj39 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X10_v9-8]");
			if (0 == (nint)obj20)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v9+12E]");
			obj17 = -1;
			obj20 = obj39 + 16;
			bool flag9 = (nint)obj17 != 1;
			obj39 = obj20;
			if (flag9)
			{
				continue;
			}
			goto IL_066c;
		}
		obj17 = obj39;
		object obj40 = obj38 + obj39;
		object obj41 = obj40 + 312;
		obj20 = obj39;
		goto IL_0a4b;
		IL_0a4b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v11+8]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v659 @ X0_v11] (should have been resolved before IL gen)");
		goto IL_09ff;
		IL_07ae:
		ex5 = new OutOfMemoryException();
		goto IL_07bc;
		IL_066c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj8 = null;
		goto IL_0a4b;
	}
}
