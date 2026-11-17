using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Networking;

public class GillaIntegrity : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public GillaHud _003C_003E4__this;

		public int small;

		internal int _003CDraw_003Eb__0(string l)
		{
			//IL_008b: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			GillaHud gillaHud = _003C_003E4__this;
			if ((object)_003C_003E4__this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return GillaHud.Measure(gillaHud.text, l, small);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public enum Verdict
	{
		// error: enumerator has no value
		Unchecked,
		// error: enumerator has no value
		Checking,
		// error: enumerator has no value
		Cleared,
		// error: enumerator has no value
		Outdated,
		// error: enumerator has no value
		Tampered
	}

	[Serializable]
	public class Stamp
	{
		public string identifier;

		public string version;

		public string signer;

		public string commit;

		public string built;

		public int code;

		public int net;
	}

	[Serializable]
	public class VersionFile
	{
		public string latest;

		public string message;

		public int minimumBuild;

		public int netVersion;

		public string[] signers;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<string> _003C_003E9__46_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1458]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal bool _003CCheckVersion_003Eb__46_0(string s)
		{
			//IL_00b5: Expected Obj, but got I
			//IL_010e: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_00db: Expected Obj, but got I
			//IL_00f5: Expected Obj, but got I
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_009e: Expected I4, but got Obj
			string text = default;
			bool flag = text == null;
			IntPtr intPtr = default;
			string text2 = (string)(nint)intPtr;
			string text3 = text;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
				object oldValue = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj = 0;
				text2 = (string)obj;
				string text4 = text.Replace((string)oldValue, (string)obj);
				if (text4 == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				string text5 = text4.Trim();
				text3 = text5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+A0]");
			object obj5 = 0;
			string a = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5+48]");
			return string.Equals(a, (string)0, (StringComparison)5);
		}
	}

	private sealed class _003CCheckVersion_003Ed__46 : _0021_00210, _00210, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private UnityWebRequest _003Crequest_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CCheckVersion_003Ed__46(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
			//IL_002f: Expected Obj, but got I4
			//IL_0049: Expected Obj, but got I4
			if (_003C_003E1__state != 1)
			{
				object obj = _003C_003E1__state + 3;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 != null)
				{
					return;
				}
			}
			_003C_003Em__Finally1();
		}

		private unsafe bool MoveNext()
		{
			//IL_0105: Expected I4, but got I8
			//IL_011f: Expected I8, but got I4
			//IL_0128: Expected VT, but got I4
			//IL_0130: Expected Obj, but got Ref
			//IL_013d: Expected I4, but got I8
			//IL_0021: Expected Obj, but got I4
			//IL_06f6: Expected I8, but got I4
			//IL_06ff: Expected VT, but got I4
			//IL_070c: Expected I, but got Obj
			//IL_0048: Expected Obj, but got I
			//IL_0057: Expected I4, but got I8
			//IL_01a4: Expected I8, but got I4
			//IL_01ad: Expected VT, but got I4
			//IL_01ba: Expected I, but got Obj
			//IL_0410: Expected I8, but got I4
			//IL_0419: Expected VT, but got I4
			//IL_0421: Expected Obj, but got Ref
			//IL_0426: Expected I, but got Obj
			//IL_0433: Expected I4, but got I8
			//IL_0744: Expected Obj, but got I
			//IL_0754: Expected Obj, but got I
			//IL_0091: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I4
			//IL_0786: Expected Obj, but got I
			//IL_07c0: Expected Obj, but got I4
			//IL_01ed: Expected I8, but got I4
			//IL_01f6: Expected VT, but got I4
			//IL_0203: Expected I, but got Obj
			//IL_0451: Expected Obj, but got I
			//IL_0466: Expected Obj, but got I
			//IL_0489: Expected Obj, but got I
			//IL_0499: Expected Obj, but got I
			//IL_04ac: Expected Obj, but got I4
			//IL_04b5: Expected I4, but got Obj
			//IL_00e8: Expected Obj, but got I
			//IL_0807: Expected I8, but got I4
			//IL_0810: Expected VT, but got I4
			//IL_0818: Expected I, but got Obj
			//IL_0821: Expected Obj, but got I4
			//IL_0248: Expected Obj, but got I4
			//IL_0ddd: Expected Obj, but got I4
			//IL_1061: Expected Obj, but got I4
			//IL_0529: Expected Obj, but got I4
			//IL_054b: Expected Obj, but got I4
			//IL_054b: Expected Obj, but got I
			//IL_028f: Expected Obj, but got I
			//IL_029f: Expected Obj, but got I
			//IL_0579: Expected Obj, but got I4
			//IL_0589: Expected I, but got Obj
			//IL_02ec: Expected Obj, but got I
			//IL_0c65: Expected Obj, but got I4
			//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a5: Expected Obj, but got Unknown
			//IL_05e1: Expected Obj, but got I4
			//IL_05f6: Expected Obj, but got I8
			//IL_05fe: Expected I, but got Obj
			//IL_0606: Expected I4, but got Obj
			//IL_0c9d: Expected Obj, but got I4
			//IL_062a: Expected Obj, but got I
			//IL_064a: Expected Obj, but got I4
			//IL_0664: Expected Obj, but got I8
			//IL_0675: Expected I4, but got Obj
			//IL_1085: Expected Obj, but got I
			//IL_10b7: Expected Obj, but got I
			//IL_0694: Expected Obj, but got I
			//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a6: Expected Obj, but got Unknown
			//IL_0cc5: Expected Obj, but got I4
			//IL_0324: Expected I, but got Obj
			//IL_0cfd: Expected Obj, but got I4
			//IL_10f5: Expected Obj, but got I
			//IL_10fd: Expected Obj, but got I
			//IL_0d35: Expected Obj, but got I4
			//IL_111c: Expected Obj, but got I
			//IL_0d9d: Expected Obj, but got I4
			//IL_03a2: Expected Obj, but got I4
			//IL_11d1: Expected Obj, but got I4
			//IL_0e6b: Expected Obj, but got I4
			//IL_0860: Expected Obj, but got I4
			//IL_0d6d: Expected Obj, but got I4
			//IL_11ef: Expected Obj, but got I
			//IL_08fc: Expected Obj, but got I4
			//IL_0dfb: Expected Obj, but got I
			//IL_0e0b: Expected Obj, but got I
			//IL_0e2f: Expected Obj, but got I
			//IL_1151: Expected Obj, but got I
			//IL_1181: Expected I8, but got I4
			//IL_118a: Expected VT, but got I4
			//IL_1193: Expected Obj, but got I4
			//IL_119c: Expected Obj, but got I4
			//IL_0e89: Expected Obj, but got I
			//IL_0e99: Expected Obj, but got I
			//IL_0ebe: Expected Obj, but got I
			//IL_089f: Expected Obj, but got I
			//IL_08bf: Expected Obj, but got I
			//IL_098e: Expected Obj, but got I
			//IL_093b: Expected Obj, but got I
			//IL_094c: Expected Obj, but got I4
			//IL_0962: Expected Obj, but got I4
			//IL_03eb: Expected Obj, but got I
			//IL_09ec: Expected Obj, but got I
			//IL_0a16: Expected Obj, but got I4
			//IL_0ee8: Expected Obj, but got I
			//IL_0ef8: Expected Obj, but got I
			//IL_0f1a: Expected Obj, but got I4
			//IL_0aaf: Expected Obj, but got I4
			//IL_0ac4: Expected Obj, but got I
			//IL_0ada: Expected I4, but got I8
			//IL_0a5d: Expected Obj, but got I4
			//IL_0b29: Expected Obj, but got I4
			//IL_0f38: Expected Obj, but got I
			//IL_0f52: Expected Obj, but got I
			//IL_0f63: Expected I, but got Obj
			//IL_0f81: Expected Obj, but got I
			//IL_0fc5: Expected Obj, but got I
			//IL_0fd5: Expected Obj, but got I
			//IL_0fee: Expected Obj, but got I
			//IL_100c: Expected Obj, but got I
			//IL_1022: Expected Obj, but got I4
			//IL_0a8d: Expected Obj, but got I
			bool result;
			_003CCheckVersion_003Ed__46 obj6 = default;
			nint num2 = default;
			UnityWebRequest.Result result2;
			_003CCheckVersion_003Ed__46 obj5;
			long num;
			DateTime dateTime;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				result = false;
				if (obj == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D14B0]");
					object value = 0;
					_003C_003E1__state = -1;
					if (string.IsNullOrEmpty((string)value))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj2 = 0;
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v172+E4]");
						bool flag2 = (nint)0 == 0;
						object obj4 = !flag2;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D14B8]");
						object message = 0;
						Debug.Log(message);
						goto IL_0826;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE000]");
					bool flag3 = (nint)0 == 0;
					num = 0L;
					dateTime = (DateTime)0;
					obj5 = (_003CCheckVersion_003Ed__46)(&obj6);
					num2 = unchecked((nint)null);
					result2 = (UnityWebRequest.Result)(-1);
					if (flag3)
					{
						goto IL_0b7c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4F8]");
					_003CCheckVersion_003Ed__46 obj7 = (_003CCheckVersion_003Ed__46)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE000]");
					bool flag4 = ((string)0).Contains((string)(object)obj7);
					bool flag5 = !flag4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1498]");
					obj5 = (_003CCheckVersion_003Ed__46)0;
					object obj9 = obj8;
					object obj10 = !flag5;
					if ((int)(~obj10) != 0)
					{
						obj5 = obj7;
					}
					string text = (string)(object)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v85+E4]");
					bool flag6 = (nint)0 == 0;
					object obj11 = !flag6;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					DateTime utcNow = DateTime.UtcNow;
					long ticks = dateTime.Ticks;
					string text2 = num.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1480]");
					result2 = (UnityWebRequest.Result)0;
					string text3 = (string)((UnityWebRequest.Result*)(int)result2)->value__;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE000]");
					string uri = (string)0 + text + (string)((UnityWebRequest.Result*)(int)result2)->value__ + text2;
					UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri);
					bool flag7 = obj6 == null;
					object obj12 = 0;
					string text4 = text2;
					num2 = (nint)unityWebRequest;
					if (flag7)
					{
						goto IL_0bb4;
					}
					object obj13 = obj6 + 32;
					obj13 = unityWebRequest;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 4294967293L;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ stack_-38_v2 (GillaIntegrity+<CheckVersion>d__46)+20]");
					bool flag8 = (nint)0 == 0;
					obj12 = 0;
					text4 = text2;
					obj5 = (_003CCheckVersion_003Ed__46)4294967293L;
					num2 = (nint)unityWebRequest;
					result2 = (UnityWebRequest.Result)obj6;
					if (flag8)
					{
						goto IL_0bc2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ stack_-38_v2 (GillaIntegrity+<CheckVersion>d__46)+20]");
					((UnityWebRequest)0).timeout = 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ stack_-38_v2 (GillaIntegrity+<CheckVersion>d__46)+20]");
					bool flag9 = (nint)0 == 0;
					obj12 = 0;
					text4 = text2;
					text3 = null;
					obj5 = (_003CCheckVersion_003Ed__46)4294967293L;
					num2 = 8;
					result2 = (UnityWebRequest.Result)obj6;
					if (flag9)
					{
						goto IL_0bd0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ stack_-38_v2 (GillaIntegrity+<CheckVersion>d__46)+20]");
					UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = ((UnityWebRequest)0).SendWebRequest();
					object obj14 = obj6 + 24;
					obj14 = unityWebRequestAsyncOperation;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj6._003C_003E1__state = 1;
					result = true;
				}
				goto IL_0c3e;
			}
			_003C_003E1__state = -3;
			bool flag10 = _003Crequest_003E5__2 == null;
			num = 0L;
			dateTime = (DateTime)0;
			obj5 = (_003CCheckVersion_003Ed__46)(&obj6);
			int num3 = -3;
			if (flag10)
			{
				goto IL_0b66;
			}
			UnityWebRequest.Result result3 = _003Crequest_003E5__2.result;
			UnityWebRequest unityWebRequest2 = obj6._003Crequest_003E5__2;
			Predicate<System.__Canon> predicate;
			if (result3 == (UnityWebRequest.Result)1)
			{
				bool flag11 = obj6._003Crequest_003E5__2 == null;
				num = 0L;
				dateTime = (DateTime)0;
				obj5 = obj6;
				num2 = unchecked((nint)null);
				result2 = result3;
				if (flag11)
				{
					goto IL_0b8a;
				}
				bool flag12 = unityWebRequest2.m_DownloadHandler == null;
				num = 0L;
				dateTime = (DateTime)0;
				obj5 = obj6;
				num2 = unchecked((nint)null);
				result2 = result3;
				if (flag12)
				{
					goto IL_0ba6;
				}
				string text5 = unityWebRequest2.m_DownloadHandler.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1468]");
				num3 = 0;
				predicate = (Predicate<System.__Canon>)((int*)num3)->m_value;
				System.__Canon _Canon = JsonUtility.FromJson<System.__Canon>(text5);
				bool flag13 = _Canon == null;
				obj5 = obj6;
				if (!flag13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj16 = 0;
					object obj17 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v50 (System.__Canon)+10]");
					object obj18;
					if ((nint)0 == 0)
					{
						obj18 = obj16;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v50 (System.__Canon)+10]");
						obj18 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v51+E4]");
					bool flag14 = (nint)0 == 0;
					object obj19 = !flag14;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj20 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v55+E4]");
					bool flag15 = (nint)0 == 0;
					object obj21 = !flag15;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj20 = obj15;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v55+A0]");
					object obj22 = (nint)0 + (nint)56;
					obj22 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj23 = obj15;
					obj5 = (_003CCheckVersion_003Ed__46)obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X0_v59+E4]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v50 (System.__Canon)+18]");
					nint num4;
					if ((nint)0 == 0)
					{
						num4 = (nint)obj5;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v50 (System.__Canon)+18]");
						num4 = 0;
					}
					bool flag16 = obj24 == null;
					object obj25 = !flag16;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj26 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X0_v63+E4]");
					bool flag17 = (nint)0 == 0;
					object obj27 = !flag17;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj26 = obj15;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X0_v63+A0]");
					object obj28 = (nint)0 + (nint)64;
					obj28 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj29 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v73+E4]");
					bool flag18 = (nint)0 == 0;
					object obj30 = !flag18;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj29 = obj15;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v73+A0]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X8_v37+30]");
					object obj36;
					object obj35;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v73+E4]");
						bool flag19 = (nint)0 == 0;
						object obj32 = !flag19;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						obj29 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v73+E4]");
						bool flag20 = (nint)0 == 0;
						object obj33 = !flag20;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj29 = obj15;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v73+A0]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v76+30]");
						result2 = (UnityWebRequest.Result)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v76+30]");
						bool flag21 = (nint)0 == 0;
						num = 0L;
						dateTime = (DateTime)0;
						obj35 = 109895680;
						string text = (string)109895680;
						num2 = num4;
						if (flag21)
						{
							goto IL_0bde;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v6 (UnityEngine.Networking.UnityWebRequest+Result)+38]");
						obj36 = 0;
					}
					else
					{
						obj36 = null;
					}
					object obj37 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v50 (System.__Canon)+20]");
					bool flag22 = (nint)obj37 >= 0;
					obj35 = 109895680;
					char c = (char)num4;
					if (!flag22)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v73+E4]");
						bool flag23 = (nint)0 == 0;
						object obj38 = !flag23;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj29 = obj15;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v73+A0]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1488]");
						object format = 0;
						object arg = default;
						object arg2 = default;
						string text6 = string.Format((string)format, arg, arg2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X8_v68+50]");
						Fail((List<string>)0, 'V', text6);
						obj29 = obj15;
						object obj40 = obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v50 (System.__Canon)+20]");
						object obj41 = 0;
						string text4 = null;
						string text3 = text6;
						c = 'V';
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v50 (System.__Canon)+24]");
					bool flag24 = (nint)0 < (nint)55;
					predicate = (Predicate<System.__Canon>)c;
					if (!flag24)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v73+E4]");
						bool flag25 = (nint)0 == 0;
						object obj42 = !flag25;
						if (obj42 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj29 = obj15;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v73+A0]");
						object obj43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1490]");
						object format2 = 0;
						object arg3 = default;
						object arg4 = default;
						string text7 = string.Format((string)format2, arg3, arg4);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X8_v62+50]");
						Fail((List<string>)0, 'R', text7);
						obj29 = obj15;
						object obj40 = 54;
						string text4 = null;
						string text3 = text7;
						predicate = (Predicate<System.__Canon>)82;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v73+E4]");
					bool flag26 = (nint)0 == 0;
					object obj44 = !flag26;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj29 = obj15;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v73+A0]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v45+48]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v45+48]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v50 (System.__Canon)+28]");
						System.__Canon[] array = (System.__Canon[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v50 (System.__Canon)+28]");
						if ((nint)0 != 0)
						{
							num3 = array.Length;
							if (array.Length != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1458]");
								obj35 = 0;
								object obj46 = obj35;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X0_v75+E4]");
								bool flag27 = (nint)0 == 0;
								object obj47 = !flag27;
								if (obj47 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj46 = obj35;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X0_v75+A0]");
								object obj48 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v55+8]");
								Predicate<System.__Canon> predicate2 = (Predicate<System.__Canon>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v55+8]");
								bool flag28 = (nint)0 == 0;
								object obj49 = !flag28;
								if (obj49 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X0_v75+E4]");
									bool flag29 = (nint)0 == 0;
									object obj50 = !flag29;
									if (obj50 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj51 = obj35;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v59+A0]");
										obj48 = 0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A50]");
									obj5 = (_003CCheckVersion_003Ed__46)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1470]");
									object obj52 = 0;
									Predicate<System.__Canon> predicate3 = default;
									predicate3._002Ector(obj48, (IntPtr)obj52);
									object obj53 = obj35;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X8_v58+A0]");
									object obj54 = (nint)0 + (nint)8;
									obj54 = predicate3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string text4 = null;
									predicate2 = predicate3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1460]");
								num3 = 0;
								string text3 = (string)((int*)num3)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v50 (System.__Canon)+28]");
								int num5 = Array.FindIndex((System.__Canon[])0, predicate2);
								int num6 = (int)(num5 & 0x80000000L);
								bool flag30 = num6 == 0;
								predicate = predicate2;
								if (!flag30)
								{
									object obj55 = obj15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X0_v80+E4]");
									bool flag31 = (nint)0 == 0;
									object obj56 = !flag31;
									if (obj56 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj55 = obj15;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X0_v80+A0]");
									num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1390]");
									obj5 = (_003CCheckVersion_003Ed__46)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D14A8]");
									obj24 = 0;
									_003CCheckVersion_003Ed__46 obj57 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v14 (System.Int32)+48]");
									string text8 = (string)(object)obj57 + (string)0 + (string)obj24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v14 (System.Int32)+58]");
									Fail((List<string>)0, 'K', text8);
									string text4 = null;
									text3 = text8;
									predicate = (Predicate<System.__Canon>)75;
								}
							}
						}
					}
				}
			}
			else
			{
				bool flag32 = obj6._003Crequest_003E5__2 == null;
				num = 0L;
				dateTime = (DateTime)0;
				obj5 = obj6;
				num2 = unchecked((nint)null);
				result2 = result3;
				if (flag32)
				{
					goto IL_0b98;
				}
				string error = obj6._003Crequest_003E5__2.error;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D14A0]");
				object obj58 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1478]");
				obj5 = (_003CCheckVersion_003Ed__46)0;
				string text3 = (string)(object)obj5;
				string message2 = (string)obj58 + error + (string)(object)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj59 = 0;
				object obj60 = obj59;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v44+E4]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v44+E4]");
				bool flag33 = (nint)0 == 0;
				object obj61 = !flag33;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message2);
				string text4 = null;
				predicate = null;
			}
			obj6._003C_003Em__Finally1();
			num = 0L;
			dateTime = (DateTime)0;
			num2 = (nint)predicate;
			object obj62 = 0;
			goto IL_1047;
			IL_1047:
			bool flag34 = obj62 == null;
			object obj63 = !flag34;
			if (obj63 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0E28");
				OutOfMemoryException ex = new OutOfMemoryException();
				goto IL_0b66;
			}
			goto IL_0826;
			IL_0b8a:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0b98;
			IL_0bc2:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_0bd0;
			IL_0b66:
			NullReferenceException ex4 = new NullReferenceException();
			result2 = (UnityWebRequest.Result)num3;
			goto IL_0b7c;
			IL_0bd0:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_0bde;
			IL_0c3e:
			return result;
			IL_0ba6:
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_0bb4;
			IL_0bb4:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_0bc2;
			IL_0b7c:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_0b8a;
			IL_0b98:
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_0ba6;
			IL_0826:
			result = false;
			goto IL_0c3e;
			IL_0bde:
			NullReferenceException ex10 = new NullReferenceException();
			if (num2 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				object obj64 = default;
				obj62 = obj64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num3 = (int)result2;
				goto IL_1047;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0DCC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result4 = default;
			return result4;
		}

		private void _003C_003Em__Finally1()
		{
			//IL_00f2: Expected I4, but got I8
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0068: Expected Obj, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			UnityWebRequest unityWebRequest = _003Crequest_003E5__2;
			_003C_003E1__state = -1;
			if (_003Crequest_003E5__2 == null)
			{
				return;
			}
			nint num = (nint)unityWebRequest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4 (Il2CppClass<UnityEngine.Networking.UnityWebRequest>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4 (Il2CppClass<UnityEngine.Networking.UnityWebRequest>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4 (Il2CppClass<UnityEngine.Networking.UnityWebRequest>)+98]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X10_v7-8]");
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
			goto IL_0135;
			IL_0135:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v152 @ X0_v2] (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_00a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0135;
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	private sealed class _003CStart_003Ed__43 : _00210, _0021_00210, _00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GillaIntegrity _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CStart_003Ed__43(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0295: Expected I4, but got I8
			//IL_0204: Expected Obj, but got I
			//IL_0213: Expected I4, but got I8
			//IL_023d: Expected Obj, but got I4
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c9: Expected Obj, but got Unknown
			//IL_026a: Expected Obj, but got I
			//IL_02e9: Expected Obj, but got I4
			//IL_0160: Expected Obj, but got I
			//IL_016f: Expected I4, but got I8
			//IL_0199: Expected Obj, but got I4
			//IL_1321: Expected Obj, but got I4
			//IL_1226: Expected I4, but got Obj
			//IL_1292: Expected Obj, but got I
			//IL_12a2: Expected Obj, but got I
			//IL_18de: Expected Obj, but got I
			//IL_18f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_18fb: Expected Obj, but got Unknown
			//IL_1904: Expected Obj, but got I4
			//IL_005f: Expected Obj, but got I
			//IL_006e: Expected I4, but got I8
			//IL_0098: Expected Obj, but got I4
			//IL_1274: Expected Obj, but got I4
			//IL_03da: Expected Obj, but got I4
			//IL_185e: Expected Obj, but got I
			//IL_13ca: Expected Obj, but got I
			//IL_01ef: Expected Obj, but got I4
			//IL_0310: Expected Obj, but got I4
			//IL_040a: Expected Obj, but got I
			//IL_12e9: Expected Obj, but got I4
			//IL_1352: Expected Obj, but got I
			//IL_1374: Expected Obj, but got I
			//IL_1893: Expected Obj, but got I
			//IL_18a3: Expected Obj, but got I
			//IL_036f: Expected Obj, but got I4
			//IL_0340: Expected Obj, but got I
			//IL_0494: Expected Obj, but got I4
			//IL_039c: Expected Obj, but got I
			//IL_0456: Expected Obj, but got I4
			//IL_13ac: Expected Obj, but got I4
			//IL_13ff: Expected Obj, but got I
			//IL_055c: Expected Obj, but got I4
			//IL_1938: Expected Obj, but got I
			//IL_1950: Unknown result type (might be due to invalid IL or missing references)
			//IL_1955: Expected Obj, but got Unknown
			//IL_195e: Expected Obj, but got I4
			//IL_1971: Expected Obj, but got I4
			//IL_0486: Expected Obj, but got I
			//IL_1469: Expected Obj, but got I
			//IL_1479: Expected Obj, but got I
			//IL_04f7: Expected Obj, but got I4
			//IL_05cc: Expected Obj, but got I
			//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e1: Expected Obj, but got Unknown
			//IL_0609: Expected Obj, but got I4
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_0616: Expected Obj, but got Unknown
			//IL_0527: Expected Obj, but got I
			//IL_064a: Expected Obj, but got I4
			//IL_0535: Expected Obj, but got I4
			//IL_144b: Expected Obj, but got I4
			//IL_063c: Expected Obj, but got I4
			//IL_06f5: Expected Obj, but got I
			//IL_0714: Expected Obj, but got I
			//IL_0724: Expected Obj, but got I4
			//IL_0750: Expected Obj, but got I
			//IL_0682: Expected Obj, but got I
			//IL_0692: Expected Obj, but got I
			//IL_06a2: Expected Obj, but got I4
			//IL_1502: Expected Obj, but got I4
			//IL_06ce: Expected Obj, but got I
			//IL_153a: Expected Obj, but got I4
			//IL_198c: Expected Obj, but got I
			//IL_1572: Expected Obj, but got I4
			//IL_19b3: Expected Obj, but got I
			//IL_0c71: Expected Obj, but got I
			//IL_07a7: Expected Obj, but got I
			//IL_07db: Expected Obj, but got I4
			//IL_0ebe: Expected Obj, but got I4
			//IL_174c: Expected Obj, but got I
			//IL_0ca8: Expected Obj, but got I4
			//IL_15aa: Expected Obj, but got I4
			//IL_19e8: Expected Obj, but got I
			//IL_16af: Expected Obj, but got I4
			//IL_116d: Expected Obj, but got I
			//IL_118e: Expected Obj, but got I
			//IL_11b8: Expected Obj, but got I4
			//IL_1b05: Expected Obj, but got I
			//IL_1b1f: Expected Obj, but got I
			//IL_1b4c: Expected Obj, but got I
			//IL_1b5c: Expected Obj, but got I
			//IL_1b71: Expected Obj, but got I
			//IL_0824: Expected Obj, but got I
			//IL_11e8: Expected I, but got Obj
			//IL_0f2a: Expected Obj, but got I4
			//IL_0f3a: Expected Obj, but got I
			//IL_0cf1: Expected Obj, but got I
			//IL_0d01: Expected Obj, but got I
			//IL_1013: Expected Obj, but got I4
			//IL_1791: Expected Obj, but got I
			//IL_17b2: Expected Obj, but got I
			//IL_17e5: Expected Obj, but got I
			//IL_17f5: Expected Obj, but got I
			//IL_0f8f: Expected Obj, but got I
			//IL_0fb9: Expected Obj, but got I4
			//IL_0f6a: Expected Obj, but got I
			//IL_0f7a: Expected Obj, but got I
			//IL_0d50: Expected Obj, but got I
			//IL_0fe4: Expected I, but got Obj
			//IL_16df: Expected Obj, but got I4
			//IL_0880: Expected I, but got Obj
			//IL_1b8a: Expected Obj, but got I
			//IL_1b9f: Expected Obj, but got I
			//IL_0d97: Expected Obj, but got I4
			//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fc: Expected Obj, but got Unknown
			//IL_0904: Expected Obj, but got I
			//IL_16fd: Expected Obj, but got I
			//IL_15e2: Expected Obj, but got I4
			//IL_107c: Expected Obj, but got I4
			//IL_0dc7: Expected Obj, but got I
			//IL_1a26: Expected Obj, but got I
			//IL_1a36: Expected Obj, but got I
			//IL_10ff: Expected Obj, but got I
			//IL_1129: Expected Obj, but got I4
			//IL_0e17: Expected Obj, but got I
			//IL_0e27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2c: Expected Obj, but got Unknown
			//IL_0e54: Expected Obj, but got I4
			//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e61: Expected Obj, but got Unknown
			//IL_10ac: Expected Obj, but got I
			//IL_10bc: Expected Obj, but got I
			//IL_09ba: Expected Obj, but got I8
			//IL_095f: Expected I, but got Obj
			//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ed: Expected Obj, but got Unknown
			//IL_09fd: Expected Obj, but got I
			//IL_161a: Expected Obj, but got I4
			//IL_1a73: Expected Obj, but got I
			//IL_0abd: Expected Obj, but got I4
			//IL_0acd: Expected Obj, but got I4
			//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af2: Expected Obj, but got Unknown
			//IL_0a5a: Expected I, but got Obj
			//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b16: Expected Obj, but got Unknown
			//IL_0b1e: Expected Obj, but got I
			//IL_1652: Expected Obj, but got I4
			//IL_1ab8: Expected Obj, but got I
			//IL_1ac8: Expected Obj, but got I
			//IL_0bd4: Expected Obj, but got I8
			//IL_0b79: Expected I, but got Obj
			//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c07: Expected Obj, but got Unknown
			//IL_0c17: Expected Obj, but got I
			//IL_0c31: Expected Obj, but got I
			bool result;
			nint num = default;
			if (_003C_003E1__state <= 1)
			{
				if (_003C_003E1__state != 0)
				{
					bool flag = _003C_003E1__state != 1;
					result = false;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
						object obj = 0;
						_003C_003E1__state = -1;
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v217+E4]");
						bool flag2 = (nint)0 == 0;
						object obj3 = !flag2;
						if (obj3 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaIntegrity gillaIntegrity = (GillaIntegrity)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v221 (GillaIntegrity)+E4]");
						bool flag3 = (nint)0 == 0;
						object obj4 = !flag3;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							gillaIntegrity = (GillaIntegrity)obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v221 (GillaIntegrity)+A0]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v173+30]");
						if ((nint)0 != 0)
						{
							if ((object)_003C_003E4__this == null)
							{
								goto IL_11ed;
							}
							gillaIntegrity.CheckApk();
							char c = (char)num;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v221 (GillaIntegrity)+E4]");
							bool flag4 = (nint)0 == 0;
							object obj6 = !flag4;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj7 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v174+A0]");
								obj5 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D14D8]");
							object obj8 = 0;
							string text = (string)obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v173+58]");
							Fail((List<string>)0, 'B', (string)obj8);
							char c = 'B';
						}
						object obj9 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X0_v223+E4]");
						bool flag5 = (nint)0 == 0;
						object obj10 = !flag5;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D14D0]");
						object obj11 = 0;
						object obj12 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X0_v227+E4]");
						bool flag6 = (nint)0 == 0;
						object obj13 = !flag6;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj12 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X0_v227+A0]");
						object obj14 = (nint)0 + (nint)32;
						obj14 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj15 = this + 24;
						obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj16 = 2;
						goto IL_132f;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
					object obj17 = 0;
					_003C_003E1__state = -1;
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v200+E4]");
					bool flag7 = (nint)0 == 0;
					object obj19 = !flag7;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D14E0]");
					object obj20 = 0;
					object obj21 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v204+E4]");
					bool flag8 = (nint)0 == 0;
					object obj22 = !flag8;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj21 = obj17;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v204+A0]");
					object obj23 = (nint)0 + (nint)32;
					obj23 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj24 = this + 24;
					obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 1;
					result = true;
				}
				goto IL_1245;
			}
			object obj25;
			object obj30;
			if (_003C_003E1__state != 2)
			{
				bool flag9 = _003C_003E1__state != 3;
				result = false;
				if (flag9)
				{
					goto IL_1245;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
				obj25 = 0;
				_003C_003E1__state = -1;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+E4]");
				bool flag10 = (nint)0 == 0;
				object obj27 = !flag10;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj26 = obj25;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+A0]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v151+50]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v151+50]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X9_v7+18]");
					if ((nint)0 > (nint)0)
					{
						obj30 = 1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+E4]");
						bool flag11 = (nint)0 == 0;
						object obj31 = !flag11;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj26 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+A0]");
							obj28 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v151+58]");
						object obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v151+58]");
						if ((nint)0 == 0)
						{
							goto IL_11ed;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X9_v38+18]");
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+E4]");
							bool flag12 = (nint)0 == 0;
							object obj33 = !flag12;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj26 = obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+A0]");
								obj28 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v151+1]");
							obj30 = 0;
						}
						else
						{
							obj30 = 0;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+E4]");
					bool flag13 = (nint)0 == 0;
					object obj34 = !flag13;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj26 = obj25;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+A0]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v147+58]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v147+58]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X9_v10+18]");
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+E4]");
							bool flag14 = (nint)0 == 0;
							object obj37 = !flag14;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj26 = obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+A0]");
								obj35 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v147+1]");
							if ((nint)0 != 0)
							{
								object obj38 = 4;
								goto IL_1429;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+E4]");
						bool flag15 = (nint)0 == 0;
						object obj39 = !flag15;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj26 = obj25;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+A0]");
						object obj40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v143+50]");
						object obj41 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v143+50]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v144+18]");
							bool flag16 = (nint)0 < (nint)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v144+18]");
							bool flag17 = (nint)0 == 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v144+18]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v144+18]");
							object obj42 = num2 ^ 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v144+18]");
							object obj43 = 0 & obj42;
							bool flag18 = (nint)obj43 < 0;
							bool flag19 = flag16 == flag18;
							object obj44 = !flag17;
							object obj45 = flag19 & obj44;
							object obj46 = ~obj45;
							if (obj46 == null)
							{
								object obj38 = 2 + 1;
							}
							else
							{
								object obj38 = 2;
							}
							goto IL_1429;
						}
					}
				}
			}
			else
			{
				_003C_003E1__state = -1;
				if ((object)_003C_003E4__this != null)
				{
					IEnumerator enumerator = ((GillaIntegrity)null).CheckVersion();
					object obj15 = this + 24;
					obj15 = enumerator;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj16 = 3;
					goto IL_132f;
				}
			}
			goto IL_11ed;
			IL_11ed:
			NullReferenceException ex = new NullReferenceException();
			goto IL_11fb;
			IL_0f7f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj47 = 0;
			object obj48 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X8_v47+E4]");
			bool flag20 = (nint)0 == 0;
			object obj49 = !flag20;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string message;
			Debug.LogWarning(message);
			num = unchecked((nint)null);
			goto IL_0fe9;
			IL_1245:
			return result;
			IL_1660:
			object obj50 = obj25;
			object obj55;
			if (obj30 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v57+E4]");
				bool flag21 = (nint)0 == 0;
				object obj51 = !flag21;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj52 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X0_v74+E4]");
				bool flag22 = (nint)0 == 0;
				object obj53 = !flag22;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE468]");
				object obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1508]");
				object format = 0;
				object arg = default;
				string text2 = string.Format((string)format, arg, obj55);
				object obj56 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ X8_v72+A0]");
				object obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1320]");
				object obj58 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ X8_v73+58]");
				string text3 = string.Join((string)obj58, (IEnumerable<string>)0);
				object obj59 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v77+A0]");
				object obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v28+58]");
				object obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v28+58]");
				bool flag23 = (nint)0 == 0;
				string text4 = null;
				string text = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ X8_v73+58]");
				num = 0;
				if (!flag23)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj62 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X10_v8+18]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v77+E4]");
						bool flag24 = (nint)0 == 0;
						object obj63 = !flag24;
						if (obj63 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj59 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v77+A0]");
							obj60 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v28+50]");
						object obj64 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ X9_v28+50]");
						bool flag25 = (nint)0 == 0;
						text4 = null;
						text = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ X8_v73+58]");
						num = 0;
						if (flag25)
						{
							goto IL_11ed;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X9_v29+18]");
						bool flag26 = (nint)0 < (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X9_v29+18]");
						bool flag27 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X9_v29+18]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X9_v29+18]");
						object obj65 = num3 ^ 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X9_v29+18]");
						object obj66 = 0 & obj65;
						bool flag28 = (nint)obj66 < 0;
						bool flag29 = flag26 == flag28;
						object obj67 = !flag27;
						object obj68 = flag29 & obj67;
						object obj69 = ~obj68;
						if (obj69 == null)
						{
							obj62 = obj58;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v77+E4]");
					bool flag30 = (nint)0 == 0;
					object obj70 = !flag30;
					if (obj70 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj59 = obj25;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v77+A0]");
					object obj71 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X8_v78+50]");
					string text5 = string.Join((string)obj58, (IEnumerable<string>)0);
					message = text2 + text3 + (string)obj62 + text5;
					text4 = text5;
					text = (string)obj62;
					string text6 = text3;
					goto IL_0f7f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v57+E4]");
				bool flag31 = (nint)0 == 0;
				object obj72 = !flag31;
				if (obj72 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj50 = obj25;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v57+A0]");
				object obj73 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v48+58]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v48+58]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X1_v11 (Il2CppMethodInfo)+18]");
					string text;
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v57+E4]");
						bool flag32 = (nint)0 == 0;
						object obj74 = !flag32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v48+58]");
						IEnumerable<string> values = (IEnumerable<string>)0;
						if (obj74 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj75 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X8_v62+A0]");
							object obj76 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X8_v63+58]");
							values = (IEnumerable<string>)0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1320]");
						object separator = 0;
						string text7 = string.Join((string)separator, values);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D14E8]");
						object obj77 = 0;
						message = (string)obj77 + text7;
						text = null;
						string text6 = text7;
						goto IL_0f7f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D14F8]");
					object obj78 = 0;
					string message2 = (string)obj78 + (string)obj55;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj79 = 0;
					object obj80 = obj79;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X8_v54+E4]");
					bool flag33 = (nint)0 == 0;
					object obj81 = !flag33;
					if (obj81 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.Log(message2);
					text = null;
					num = unchecked((nint)null);
					goto IL_0fe9;
				}
			}
			goto IL_11ed;
			IL_132f:
			result = true;
			goto IL_1245;
			IL_11fb:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			goto IL_1209;
			IL_0fe9:
			object obj82 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X0_v38+E4]");
			bool flag34 = (nint)0 == 0;
			object obj83 = !flag34;
			if (obj83 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj82 = obj25;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X0_v38+A0]");
			object obj84 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X8_v34+58]");
			List<string> list = (List<string>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X8_v34+58]");
			if ((nint)0 != 0)
			{
				if (list._size >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X0_v38+E4]");
					bool flag35 = (nint)0 == 0;
					object obj85 = !flag35;
					if (obj85 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj86 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X8_v41+A0]");
						object obj87 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1216 @ X8_v42+58]");
						list = (List<string>)0;
					}
					bool flag36 = obj30 == null;
					bool flag37 = !flag36;
					TellOwner(list, flag37);
					num = (flag37 ? 1 : 0);
				}
				if ((object)_003C_003E4__this != null)
				{
					GameObject gameObject = _003C_003E4__this.gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj88 = 0;
					object obj89 = obj88;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v39+E4]");
					bool flag38 = (nint)0 == 0;
					object obj90 = !flag38;
					if (obj90 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(gameObject);
					result = false;
					goto IL_1245;
				}
			}
			goto IL_11ed;
			IL_1429:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v20+E4]");
			bool flag39 = (nint)0 == 0;
			object obj91 = !flag39;
			if (obj91 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj92 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v23+E4]");
			object[] array;
			if ((nint)0 != 0)
			{
				bool flag40 = obj30 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj93 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v23+A0]");
				object obj94 = 0;
				object obj95 = !flag40;
				object obj96 = ~obj95;
				if (obj96 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1500]");
					obj93 = 0;
				}
				array = (object[])obj93;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj97 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj98 = 0;
				bool flag41 = obj30 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v177+A0]");
				object obj99 = 0;
				object obj100 = !flag41;
				object obj101 = ~obj100;
				if (obj101 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1500]");
					obj98 = 0;
				}
				array = (object[])obj98;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v177+E4]");
				bool flag42 = (nint)0 == 0;
				object obj102 = !flag42;
				if (obj102 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
			}
			object obj103 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X0_v27+E4]");
			bool flag43 = (nint)0 == 0;
			object obj104 = !flag43;
			if (obj104 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj103 = obj25;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X0_v27+A0]");
			object obj105 = (nint)0 + (nint)32;
			obj105 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj106 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v33+E4]");
			bool flag44 = (nint)0 == 0;
			object obj107 = !flag44;
			if (obj107 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj106 = obj25;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v33+A0]");
			object obj108 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v28+30]");
			object[] array3;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj109 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj110 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X8_v87+E4]");
				bool flag45 = (nint)0 == 0;
				object obj111 = !flag45;
				if (obj111 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj112 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v104+E4]");
				bool flag46 = (nint)0 == 0;
				object obj113 = !flag46;
				if (obj113 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj112 = obj25;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v104+A0]");
				object obj114 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v91+30]");
				bool flag47 = (nint)0 == 0;
				num = 4;
				if (!flag47)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj115 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object[] array2 = default;
					bool flag48 = array2 == null;
					object obj116 = default;
					num = (nint)(&obj116);
					if (!flag48)
					{
						IntPtr intPtr = default;
						bool flag49 = intPtr == (IntPtr)0;
						nint num4 = (nint)(&obj116);
						if (!flag49)
						{
							nint num5 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v126 (Il2CppClass<System.Object[]>)+40]");
							num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag50 = ex2 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v126 (Il2CppClass<System.Object[]>)+40]");
							num = 0;
							if (flag50)
							{
								goto IL_1209;
							}
						}
						bool flag51 = array2.Length == 0;
						num = num4;
						if (!flag51)
						{
							object obj117 = array2 + 32;
							obj117 = (nint)intPtr;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj118 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v113+E4]");
							bool flag52 = (nint)0 == 0;
							object obj119 = !flag52;
							if (obj119 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj118 = obj25;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v113+A0]");
							object obj120 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X8_v99+30]");
							object obj121 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X8_v99+30]");
							bool flag53 = (nint)0 == 0;
							num = intPtr;
							if (flag53)
							{
								goto IL_11ed;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v100+18]");
							bool flag54 = (nint)0 == 0;
							nint num6 = intPtr;
							if (!flag54)
							{
								nint num7 = (nint)array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v124 (Il2CppClass<System.Object[]>)+40]");
								num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag55 = ex2 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v124 (Il2CppClass<System.Object[]>)+40]");
								num = 0;
								if (flag55)
								{
									goto IL_1209;
								}
							}
							object obj122 = array2.Length & 0xFFFFFFFEL;
							bool flag56 = obj122 == null;
							num = num6;
							if (!flag56)
							{
								object obj123 = array2 + 40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v100+18]");
								obj123 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj124 = obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v120+E4]");
								bool flag57 = (nint)0 == 0;
								object obj125 = !flag57;
								if (obj125 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj124 = obj25;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v120+A0]");
								object obj126 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1242 @ X8_v106+30]");
								bool flag58 = (nint)0 == 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v100+18]");
								num = 0;
								if (flag58)
								{
									goto IL_11ed;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								IntPtr intPtr2 = default;
								bool flag59 = intPtr2 == (IntPtr)0;
								object obj127 = default;
								nint num8 = (nint)(&obj127);
								if (!flag59)
								{
									nint num9 = (nint)array2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v122 (Il2CppClass<System.Object[]>)+40]");
									num8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag60 = ex2 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v122 (Il2CppClass<System.Object[]>)+40]");
									num = 0;
									if (flag60)
									{
										goto IL_1209;
									}
								}
								bool flag61 = array2.Length < 2;
								object obj128 = !flag61;
								object obj129 = array2.Length - 2;
								bool flag62 = obj129 == null;
								object obj130 = ~obj128;
								object obj131 = obj130 | flag62;
								num = num8;
								if (obj131 == null)
								{
									object obj132 = array2 + 48;
									obj132 = (nint)intPtr2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj133 = obj25;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v129+E4]");
									bool flag63 = (nint)0 == 0;
									object obj134 = !flag63;
									if (obj134 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj133 = obj25;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v129+A0]");
									object obj135 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X8_v114+30]");
									object obj136 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X8_v114+30]");
									bool flag64 = (nint)0 == 0;
									num = intPtr2;
									if (flag64)
									{
										goto IL_11ed;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v115+28]");
									bool flag65 = (nint)0 == 0;
									nint num10 = intPtr2;
									if (!flag65)
									{
										nint num11 = (nint)array2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v120 (Il2CppClass<System.Object[]>)+40]");
										num10 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag66 = ex2 == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v120 (Il2CppClass<System.Object[]>)+40]");
										num = 0;
										if (flag66)
										{
											goto IL_1209;
										}
									}
									object obj137 = array2.Length & 0xFFFFFFFCL;
									bool flag67 = obj137 == null;
									num = num10;
									if (!flag67)
									{
										object obj138 = array2 + 56;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v115+28]");
										obj138 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D14F0]");
										object format2 = 0;
										string text8 = string.Format((string)format2, array2);
										string text = null;
										array3 = array2;
										obj55 = text8;
										goto IL_1660;
									}
								}
							}
						}
						goto IL_11fb;
					}
				}
				goto IL_11ed;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1510]");
			object obj139 = 0;
			obj55 = obj139;
			array3 = array;
			goto IL_1660;
			IL_1209:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex3 = new ArgumentNullException();
			return (byte)(int)ex3 != 0;
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	public const string VersionUrl = null;

	public const string VersionPage = null;

	public static readonly bool RequireStoreInstall;

	public static readonly bool EnforceApk;

	private static readonly string[] StoreInstallers;

	private static readonly string[] Injected;

	private static Verdict Result__BackingField;

	private static string Status__BackingField;

	private static string Codes__BackingField;

	private static Stamp Build__BackingField;

	private static string Latest__BackingField;

	private static string Message__BackingField;

	private static string apkSigner;

	private static readonly List<string> outdated;

	private static readonly List<string> tampered;

	private const int GetSigningCertificates = default(int);

	private const int FlagDebuggable = default(int);

	public static Verdict Result
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+18]");
			return (Verdict)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
		}
	}

	public static bool Done
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I
			//IL_00d6: Expected Obj, but got I
			//IL_010a: Expected Obj, but got I
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected Obj, but got Unknown
			//IL_0154: Expected Obj, but got I4
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+18]");
			object obj7 = -1;
			bool flag3 = (nint)obj7 < 0;
			bool flag4 = obj7 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+18]");
			object obj8 = (nint)0 ^ (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+18]");
			object obj9 = 0 ^ obj7;
			object obj10 = obj8 & obj9;
			bool flag5 = (nint)obj10 < 0;
			bool flag6 = flag3 == flag5;
			object obj11 = !flag4;
			return (byte)((flag6 & obj11) ? 1 : 0) != 0;
		}
	}

	public static bool Cleared
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00f5: Expected Obj, but got I4
			//IL_0068: Expected Obj, but got I
			//IL_0092: Expected Obj, but got I4
			//IL_0132: Expected Obj, but got I4
			//IL_0150: Expected Obj, but got I
			//IL_0166: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isEditor)
			{
				return true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v11+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v9+18]");
			object obj10 = -2;
			return obj10 == null;
		}
	}

	public static string Status
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+20]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
			object obj4 = (nint)0 + (nint)32;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static string Codes
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+28]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
			object obj4 = (nint)0 + (nint)40;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static Stamp Build
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+30]");
			return (Stamp)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static string Latest
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+38]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
			object obj4 = (nint)0 + (nint)56;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static string Message
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+40]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
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
			object obj4 = (nint)0 + (nint)64;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static void Begin()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I4
		//IL_02f8: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I
		//IL_0360: Expected Obj, but got I
		//IL_038a: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I
		//IL_03f3: Expected Obj, but got I
		//IL_0410: Expected Obj, but got I
		//IL_043a: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I4
		//IL_03a8: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+18]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Stamp stamp = LoadStamp();
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12+A0]");
		object obj11 = (nint)0 + (nint)48;
		obj11 = stamp;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v16+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isEditor = Application.isEditor;
		object obj15 = obj;
		if (isEditor)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v20+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v43+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v43+A0]");
			object obj19 = 0;
			_ = 2;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v20+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v24+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v24+A0]");
		object obj24 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D12E0]");
		object obj25 = 0;
		GameObject gameObject = default;
		gameObject._002Ector((string)obj25);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj26 = 0;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v27+E4]");
		bool flag11 = (nint)0 == 0;
		object obj28 = !flag11;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D12D8]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
	}

	public static IEnumerator WaitForVerdict()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D12F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		return (IEnumerator)obj2;
	}

	private static Stamp LoadStamp()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AF8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AE0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj6 = default;
		bool flag2 = obj6 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		Stamp result = null;
		if (obj7 == null)
		{
			if ((object)obj6 == null)
			{
				NullReferenceException ex = new NullReferenceException();
				object obj8 = 0;
				UnityEngine.Object obj9 = null;
				NullReferenceException ex2 = ex;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				Stamp result2 = default;
				return result2;
			}
			string text = ((TextAsset)obj6).text;
			System.__Canon _Canon = JsonUtility.FromJson<System.__Canon>(text);
			result = (Stamp)(object)_Canon;
		}
		return result;
	}

	private IEnumerator Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D12F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	private unsafe static void TellOwner(List<string> found, bool turnedAway)
	{
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected Obj, but got I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_02f4: Expected Obj, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got I4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected I4, but got Obj
		//IL_06d9: Expected I4, but got Obj
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected Ref, but got Unknown
		//IL_06fc: Expected Obj, but got I4
		//IL_0704: Expected Obj, but got I4
		//IL_0475: Expected I4, but got Obj
		//IL_0341: Expected Obj, but got I4
		//IL_0349: Expected Obj, but got I4
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got I4
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected I, but got Obj
		//IL_0281: Expected Obj, but got I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_03c5: Expected Obj, but got I
		//IL_03ec: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected I4, but got I8
		//IL_013c: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I4
		//IL_0500: Expected Obj, but got I4
		//IL_0509: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I4
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got I4
		//IL_0561: Expected I4, but got Obj
		//IL_0649: Expected Obj, but got I
		//IL_066b: Expected Obj, but got I4
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_072f: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got I4
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_01f3: Expected I, but got Obj
		bool flag = (object)found == null;
		char c = '\0';
		string text2 = default;
		string text = text2;
		Enumerator<, > val = (Enumerator<, >)0;
		bool flag2 = turnedAway;
		List<string> list = found;
		string text3 = (string)109895680;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			Enumerator<, > val2 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4420]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4418]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1310]");
			object obj3 = 0;
			List<string> list2 = (List<string>)val2;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)found).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj4 = 0;
			c = '\0';
			Enumerator<, > val3 = (Enumerator<, >)(ref val);
			text3 = (string)val2;
			Enumerator<, > val4 = default;
			object obj23 = default;
			object obj13;
			Enumerator<, > val5;
			Enumerator<, > val6;
			while (true)
			{
				string text4 = (string)obj;
				if (val.MoveNext())
				{
					if (text2 != null)
					{
						if (text2._stringLength >= 1)
						{
							char c2 = text2.get_Chars(0);
							bool flag3 = text3 == null;
							nint num = unchecked((nint)null);
							flag2 = (byte)c2 != 0;
							if (flag3)
							{
								break;
							}
							int num2 = text3.IndexOf(c2);
							int num3 = (int)(num2 & 0x80000000L);
							bool flag4 = num3 == 0;
							num = unchecked((nint)null);
							text4 = (string)c2;
							if (!flag4)
							{
								char c3 = text2.get_Chars(0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X28_v4+90]");
								object obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v52+E4]");
								val3 = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v52+E4]");
								bool flag5 = (nint)0 == 0;
								object obj6 = !flag5;
								if (obj6 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string text5 = c.ToString();
								string text6 = text3 + text5;
								c = c3;
								num = unchecked((nint)null);
								text4 = text5;
								text3 = text6;
							}
						}
						if ((object)list2 != null)
						{
							bool flag6 = (nint)list2._items < 0;
							bool flag7 = list2._items == null;
							object obj7 = (object)list2._items ^ (object)list2._items;
							object obj8 = (object)list2._items & obj7;
							bool flag8 = (nint)obj8 < 0;
							bool flag9 = flag6 == flag8;
							object obj9 = !flag7;
							object obj10 = flag9 & obj9;
							object obj11 = ~obj10;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1320]");
								val3 = (Enumerator<, >)0;
							}
							else
							{
								val3 = val2;
							}
							bool flag10 = text2._stringLength < 61;
							string text7 = text2;
							if (!flag10)
							{
								string text8 = text2.Substring(0, 60);
								text7 = text8;
							}
							string text9 = string.Concat(list2, (string)val3, text7);
							nint num = (nint)text7;
							list2 = (List<string>)(object)text9;
							continue;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					NullReferenceException ex2 = new NullReferenceException();
					flag2 = (byte)(int)text4 != 0;
					break;
				}
				object obj12 = 9;
				string text10 = null;
				val = val4;
				obj13 = 0;
				val5 = val4;
				val6 = (Enumerator<, >)(ref val);
				list = list2;
				while (true)
				{
					char c4 = (char)(int)text10;
					object obj14 = obj13;
					while (true)
					{
						flag2 = (byte)(int)obj2 != 0;
						((Enumerator<, >*)val6)->Dispose();
						bool flag11 = obj14 == null;
						object obj15 = !flag11;
						text = (string)c4;
						if (obj15 == null)
						{
							bool flag12 = c4 == '\0';
							object obj16 = !flag12;
							text = (string)c4;
							OutOfMemoryException ex3 = (OutOfMemoryException)val6;
							if (obj16 == null)
							{
								if ((nint)obj12 != 9)
								{
									bool flag13 = obj12 == null;
									object obj17 = !flag13;
									if (obj17 != null)
									{
										return;
									}
								}
								string what = (string)obj3 + text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
								object obj18 = 0;
								bool flag14 = !turnedAway;
								object obj19 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1308]");
								object how = 0;
								object obj20 = !flag14;
								object obj21 = ~obj20;
								if (obj21 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1318]");
									how = 0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1300]");
								object kind = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v8+E4]");
								bool flag15 = (nint)0 == 0;
								object obj22 = !flag15;
								if (obj22 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								GillaBotReport.Tell((string)kind, what, (string)how, list, (string)val2);
								return;
							}
						}
						else
						{
							OutOfMemoryException ex3 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						switch (flag2)
						{
						case true:
							break;
						case true:
							goto IL_052f;
						default:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE0C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						break;
						IL_052f:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj14 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj12 = 0;
						c4 = (char)(int)text;
						obj13 = obj23;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj12 = 0;
					text10 = (string)1;
				}
			}
			NullReferenceException ex4 = new NullReferenceException();
			text = null;
			val = val4;
			obj13 = 0;
			val5 = val4;
			val6 = (Enumerator<, >)(ref val);
			list = list2;
		}
		throw new NullReferenceException();
	}

	private static void Fail(List<string> list, char code, string why)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_0301: Expected Obj, but got I4
		//IL_038f: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		//IL_01cc: Expected I4, but got I8
		//IL_0213: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got I4
		//IL_03a4: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I
		//IL_03d6: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1328]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		string text = string.Format((string)format, arg, why);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
		object obj2 = 0;
		string[] items = list._items;
		object obj3 = obj2;
		int version = list._version + 1;
		list._version = version;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
		object obj4 = 0;
		bool flag = list._size < items.Length;
		object obj5 = !flag;
		if (obj5 == null)
		{
			object obj6 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj7 = obj6 + 32;
			obj7 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = why;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v4+20]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v24+A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v25+70]");
			object obj8 = 0;
			((List<System.__Canon>)(object)list).AddWithResize((System.__Canon)(object)text);
		}
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v13+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v11+28]");
		int num = ((string)0).IndexOf(code);
		if ((int)(num & 0x80000000L) != 0)
		{
			object obj16 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v17+E4]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj18 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v21+E4]");
			bool flag5 = (nint)0 == 0;
			object obj19 = !flag5;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X22_v3+90]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v21+A0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v17+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			char c = default;
			string text2 = c.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v7+28]");
			string text3 = (string)0 + text2;
			object obj23 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v29+E4]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj23 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v29+A0]");
			object obj25 = (nint)0 + (nint)40;
			obj25 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private IEnumerator CheckVersion()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1330]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		return (IEnumerator)obj2;
	}

	private unsafe void CheckApk()
	{
		//IL_397a: Expected Obj, but got I
		//IL_3993: Expected Obj, but got I
		//IL_39ab: Expected Obj, but got I
		//IL_39cd: Expected Obj, but got I4
		//IL_39eb: Expected Obj, but got I
		//IL_3a0d: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_3a2b: Expected Obj, but got I
		//IL_3a4d: Expected Obj, but got I4
		//IL_47a8: Expected Obj, but got I
		//IL_47b8: Expected Obj, but got I
		//IL_47d5: Expected Obj, but got I4
		//IL_47f3: Expected Obj, but got I4
		//IL_4821: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I
		//IL_3a85: Expected Obj, but got I4
		//IL_483f: Expected Obj, but got I
		//IL_484f: Expected Obj, but got I
		//IL_4892: Expected Obj, but got I4
		//IL_489f: Expected Obj, but got Ref
		//IL_48af: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got Ref
		//IL_01de: Expected Obj, but got I4
		//IL_3aa3: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I4
		//IL_0436: Expected Obj, but got Ref
		//IL_48e7: Expected Obj, but got I4
		//IL_035c: Expected I, but got Obj
		//IL_03b1: Expected Obj, but got I4
		//IL_03be: Expected Obj, but got Ref
		//IL_3ac8: Expected Obj, but got I
		//IL_3ad8: Expected Obj, but got I
		//IL_3b1b: Expected Obj, but got I4
		//IL_3b28: Expected Obj, but got Ref
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_0484: Expected Obj, but got I
		//IL_3535: Expected I, but got Obj
		//IL_024a: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got I
		//IL_056c: Expected Obj, but got I8
		//IL_05a6: Expected Obj, but got I
		//IL_05af: Expected Obj, but got I4
		//IL_05bc: Expected Obj, but got Ref
		//IL_04c0: Expected I, but got Obj
		//IL_0514: Expected Obj, but got I
		//IL_051d: Expected Obj, but got I4
		//IL_052a: Expected Obj, but got Ref
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_05f0: Expected Obj, but got I
		//IL_0634: Expected Obj, but got I
		//IL_063d: Expected Obj, but got I4
		//IL_064a: Expected Obj, but got Ref
		//IL_0680: Expected Obj, but got I
		//IL_06ad: Expected Obj, but got I
		//IL_06c5: Expected Obj, but got I
		//IL_06e7: Expected Obj, but got I4
		//IL_3b5b: Expected Obj, but got I
		//IL_3b7d: Expected Obj, but got I4
		//IL_492b: Expected Obj, but got I4
		//IL_4940: Expected Obj, but got I
		//IL_4951: Expected Obj, but got I4
		//IL_495e: Expected Obj, but got Ref
		//IL_4976: Expected I, but got Obj
		//IL_070f: Expected Obj, but got I
		//IL_072e: Expected Obj, but got I
		//IL_073e: Expected Obj, but got I
		//IL_3601: Expected Obj, but got I4
		//IL_0753: Expected Obj, but got I
		//IL_0763: Expected Obj, but got I
		//IL_0791: Expected Obj, but got I4
		//IL_07bf: Expected Obj, but got I4
		//IL_3657: Expected Obj, but got I
		//IL_3668: Expected Obj, but got I4
		//IL_3670: Expected I, but got Obj
		//IL_3697: Expected Obj, but got I4
		//IL_3bb5: Expected Obj, but got I4
		//IL_36ed: Expected Obj, but got I
		//IL_36fe: Expected Obj, but got I4
		//IL_3706: Expected I, but got Obj
		//IL_4c89: Expected Obj, but got I4
		//IL_49a4: Expected Obj, but got I
		//IL_49f2: Expected Obj, but got I4
		//IL_4a07: Expected Obj, but got I
		//IL_4a18: Expected Obj, but got I4
		//IL_4a25: Expected Obj, but got Ref
		//IL_4a3a: Expected Obj, but got I4
		//IL_4a42: Expected I, but got Obj
		//IL_372d: Expected Obj, but got I4
		//IL_3783: Expected Obj, but got I
		//IL_3794: Expected Obj, but got I4
		//IL_379c: Expected I, but got Obj
		//IL_51d2: Expected Obj, but got I4
		//IL_2556: Expected Obj, but got I4
		//IL_082b: Expected Obj, but got I4
		//IL_0833: Expected I, but got Obj
		//IL_37d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_37da: Expected Obj, but got Unknown
		//IL_095f: Expected Obj, but got I4
		//IL_0974: Expected Obj, but got I
		//IL_0985: Expected Obj, but got I4
		//IL_0992: Expected Obj, but got Ref
		//IL_3925: Expected Obj, but got I4
		//IL_51fa: Expected Obj, but got I4
		//IL_26d0: Expected Obj, but got I4
		//IL_41e5: Expected Obj, but got I
		//IL_0873: Expected Obj, but got I4
		//IL_3807: Expected Obj, but got Ref
		//IL_25ba: Expected Obj, but got I4
		//IL_2521: Expected Obj, but got I4
		//IL_252a: Unknown result type (might be due to invalid IL or missing references)
		//IL_252f: Expected Obj, but got Unknown
		//IL_09c0: Expected Obj, but got I
		//IL_09d0: Expected Obj, but got I
		//IL_09f9: Expected Obj, but got I
		//IL_0a11: Expected Obj, but got I
		//IL_0a33: Expected Obj, but got I4
		//IL_3847: Expected Obj, but got I4
		//IL_2845: Expected Obj, but got I4
		//IL_4267: Expected Obj, but got I
		//IL_25a3: Expected Obj, but got I4
		//IL_3c1a: Expected Obj, but got I
		//IL_3c3c: Expected Obj, but got I4
		//IL_3bfc: Expected Obj, but got I4
		//IL_08a3: Expected Obj, but got I
		//IL_2734: Expected Obj, but got I4
		//IL_269b: Expected Obj, but got I4
		//IL_26a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26a9: Expected Obj, but got Unknown
		//IL_4b3e: Expected Obj, but got I4
		//IL_4b5c: Expected Obj, but got I4
		//IL_4b71: Expected Obj, but got I
		//IL_4b82: Expected Obj, but got I4
		//IL_4b8f: Expected Obj, but got Ref
		//IL_4b9f: Expected I, but got Obj
		//IL_0a5b: Expected Obj, but got I
		//IL_4a68: Expected Obj, but got I
		//IL_4aa7: Expected Obj, but got I4
		//IL_4abc: Expected Obj, but got I
		//IL_4acd: Expected Obj, but got I4
		//IL_4ada: Expected Obj, but got Ref
		//IL_4aef: Expected Obj, but got I4
		//IL_4af7: Expected Obj, but got Ref
		//IL_3883: Expected Obj, but got I
		//IL_388b: Expected I4, but got Obj
		//IL_389b: Expected Obj, but got I
		//IL_42df: Expected Obj, but got I
		//IL_271d: Expected Obj, but got I4
		//IL_0a7a: Expected Obj, but got I
		//IL_0a8a: Expected Obj, but got I
		//IL_38df: Expected Obj, but got I
		//IL_38ef: Expected Obj, but got I
		//IL_28a8: Expected Obj, but got I
		//IL_28c9: Expected I, but got Obj
		//IL_280b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2810: Expected Obj, but got Unknown
		//IL_2819: Unknown result type (might be due to invalid IL or missing references)
		//IL_281e: Expected Obj, but got Unknown
		//IL_0a9f: Expected Obj, but got I
		//IL_0acc: Expected Obj, but got I4
		//IL_0ad9: Expected Obj, but got I4
		//IL_0aef: Expected Obj, but got I4
		//IL_0b03: Expected Obj, but got I
		//IL_08da: Expected Obj, but got I
		//IL_0b22: Expected Obj, but got I
		//IL_0b2a: Expected I, but got Obj
		//IL_090e: Expected Obj, but got I
		//IL_28df: Expected I, but got Obj
		//IL_0b77: Expected Obj, but got I4
		//IL_0b94: Expected Obj, but got Ref
		//IL_0b9d: Expected Obj, but got I4
		//IL_0bc3: Expected Obj, but got I4
		//IL_0bd0: Expected Obj, but got Ref
		//IL_436b: Expected Obj, but got I
		//IL_0bfe: Expected Obj, but got I
		//IL_4332: Expected Obj, but got I
		//IL_117b: Expected Obj, but got I
		//IL_1184: Expected Obj, but got I4
		//IL_29e9: Expected Obj, but got I
		//IL_29f9: Expected Obj, but got I
		//IL_2a09: Expected Obj, but got I
		//IL_2a19: Expected Obj, but got I
		//IL_29be: Expected Obj, but got I
		//IL_29c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_29cc: Expected Obj, but got Unknown
		//IL_3cc9: Expected Obj, but got Ref
		//IL_0c33: Expected Obj, but got I
		//IL_0c43: Expected Obj, but got I
		//IL_0c53: Expected Obj, but got I
		//IL_0c63: Expected Obj, but got I
		//IL_0c73: Expected Obj, but got I
		//IL_0c7c: Expected Obj, but got I4
		//IL_457a: Expected I, but got Obj
		//IL_4c09: Expected Obj, but got I4
		//IL_4c26: Expected Obj, but got Ref
		//IL_4c2f: Expected Obj, but got I4
		//IL_4c55: Expected Obj, but got I4
		//IL_4c62: Expected Obj, but got Ref
		//IL_3ca3: Expected Obj, but got I4
		//IL_3cb3: Expected Obj, but got I
		//IL_11a1: Expected I, but got Obj
		//IL_43f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_43f6: Expected Obj, but got Unknown
		//IL_0c8e: Expected I4, but got Obj
		//IL_0c9e: Expected Obj, but got I
		//IL_0cb6: Expected Obj, but got I
		//IL_0cd8: Expected Obj, but got I4
		//IL_3024: Expected Obj, but got Ref
		//IL_43aa: Expected Obj, but got I
		//IL_3215: Expected I, but got Obj
		//IL_3c5a: Expected Obj, but got I
		//IL_3c7c: Expected Obj, but got I4
		//IL_461b: Expected Obj, but got I4
		//IL_4628: Expected Obj, but got Ref
		//IL_2b33: Expected Obj, but got I4
		//IL_2b40: Expected Obj, but got Ref
		//IL_2af8: Expected Obj, but got I
		//IL_2b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b06: Expected Obj, but got Unknown
		//IL_3cfe: Expected Obj, but got I
		//IL_0d00: Expected Obj, but got I
		//IL_1270: Expected Obj, but got I
		//IL_1279: Unknown result type (might be due to invalid IL or missing references)
		//IL_127e: Expected Obj, but got Unknown
		//IL_0d1f: Expected Obj, but got I
		//IL_0d2f: Expected Obj, but got I
		//IL_2b56: Expected I, but got Obj
		//IL_3266: Expected Obj, but got I4
		//IL_327b: Expected Obj, but got Ref
		//IL_3284: Expected Obj, but got I4
		//IL_32aa: Expected Obj, but got I4
		//IL_32b7: Expected Obj, but got Ref
		//IL_0d44: Expected Obj, but got I
		//IL_0d5c: Expected Obj, but got I
		//IL_0d7d: Expected Obj, but got I
		//IL_0d98: Expected I, but got Obj
		//IL_464d: Expected Obj, but got I
		//IL_4461: Expected I, but got Obj
		//IL_4483: Expected Obj, but got I4
		//IL_312b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3130: Expected Obj, but got Unknown
		//IL_3139: Unknown result type (might be due to invalid IL or missing references)
		//IL_313e: Expected Obj, but got Unknown
		//IL_2c86: Expected Obj, but got I4
		//IL_442b: Expected Obj, but got I
		//IL_0e08: Expected Obj, but got I4
		//IL_44a1: Expected Obj, but got I
		//IL_44b1: Expected Obj, but got I
		//IL_44d9: Expected Obj, but got I4
		//IL_44e6: Expected Obj, but got Ref
		//IL_2c25: Expected Obj, but got I
		//IL_2c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c33: Expected Obj, but got Unknown
		//IL_0e73: Expected Obj, but got I4
		//IL_0e8a: Expected I, but got Obj
		//IL_2e8f: Expected Obj, but got I4
		//IL_2cef: Expected Obj, but got I8
		//IL_2d05: Expected Obj, but got I
		//IL_2d0e: Expected Obj, but got I4
		//IL_2d1b: Expected I, but got Obj
		//IL_0ed5: Expected Obj, but got I4
		//IL_451e: Expected Obj, but got I4
		//IL_4547: Expected Obj, but got I4
		//IL_4554: Expected Obj, but got Ref
		//IL_2d58: Expected Obj, but got I4
		//IL_2d65: Expected Obj, but got Ref
		//IL_31be: Expected Obj, but got I4
		//IL_0f3f: Expected I4, but got Obj
		//IL_2d9b: Expected Obj, but got I
		//IL_2db0: Expected Obj, but got I
		//IL_2dce: Expected Obj, but got I4
		//IL_2f22: Expected Obj, but got I4
		//IL_0f98: Expected Obj, but got I4
		//IL_0fb8: Expected Obj, but got I4
		//IL_45cf: Expected Obj, but got I4
		//IL_45dc: Expected Obj, but got Ref
		//IL_2e21: Expected Obj, but got I
		//IL_2e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e2f: Expected Obj, but got Unknown
		//IL_103a: Expected Obj, but got I
		//IL_104a: Expected Obj, but got I
		//IL_105a: Expected Obj, but got I
		//IL_107d: Expected Obj, but got I
		//IL_108d: Expected Obj, but got I
		//IL_1096: Unknown result type (might be due to invalid IL or missing references)
		//IL_109b: Expected Obj, but got Unknown
		//IL_10ba: Expected Obj, but got I4
		//IL_10cc: Expected I, but got Obj
		//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdd: Expected Obj, but got Unknown
		//IL_1006: Unknown result type (might be due to invalid IL or missing references)
		//IL_100b: Expected Obj, but got Unknown
		//IL_2f57: Expected Obj, but got I
		//IL_2f67: Expected Obj, but got I
		//IL_2f87: Expected Obj, but got I4
		//IL_2f9d: Expected I4, but got Obj
		//IL_2fde: Expected Obj, but got I
		//IL_10f2: Expected Obj, but got I
		//IL_1102: Expected Obj, but got I
		//IL_1112: Expected Obj, but got I
		//IL_1122: Expected Obj, but got I
		//IL_1132: Expected Obj, but got I
		//IL_113b: Expected Obj, but got I4
		//IL_114c: Expected Obj, but got I4
		//IL_1156: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
		object obj = 0;
		AndroidJavaObject currentContext = AndroidApplication.currentContext;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC8]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X19_v2+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X19_v2+38]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X19_v2+38]");
			obj4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X19_v2+38]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v351+10]");
			obj6 = 0;
		}
		bool flag3 = currentContext == null;
		string text = null;
		NullReferenceException ex = null;
		System.__Canon _Canon = null;
		System.__Canon _Canon2 = null;
		SHA256 sHA = null;
		System.__Canon _Canon3 = null;
		System.__Canon _Canon4 = null;
		System.__Canon _Canon5 = null;
		AndroidJavaObject androidJavaObject = currentContext;
		if (flag3)
		{
			goto IL_336a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D13D8]");
		object methodName = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAB0]");
		System.__Canon _Canon6 = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+A0]");
		object args = 0;
		System.__Canon _Canon7 = currentContext.Call<System.__Canon>((string)methodName, (object[])args);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC8]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X19_v70+38]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X19_v70+38]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X19_v70+38]");
			obj11 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v138+10]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v245+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X19_v70+38]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v348+10]");
			obj13 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1358]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1340]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v245+A0]");
		int num = 0;
		object[] array = (object[])((int*)num)->m_value;
		string text2 = (string)obj17;
		System.__Canon _Canon8 = currentContext.Call<System.__Canon>((string)obj16, (object[])((int*)num)->m_value);
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v248+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v252+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v252+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X8_v147+30]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X8_v147+30]");
		bool flag8 = (nint)0 == 0;
		text = null;
		ex = null;
		_Canon = null;
		_Canon2 = null;
		sHA = null;
		_Canon3 = null;
		_Canon4 = null;
		object obj24 = 0;
		OutOfMemoryException ex2 = null;
		object obj25 = (object)(&_Canon5);
		_Canon5 = _Canon7;
		nint num2 = (nint)obj16;
		androidJavaObject = currentContext;
		if (flag8)
		{
			goto IL_3378;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v148+10]");
		string text3 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v148+10]");
		bool flag9 = (string)(object)_Canon8 != (string)0;
		bool flag10 = !flag9;
		array = null;
		int num3;
		if (!flag10)
		{
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X0_v516+E4]");
			bool flag11 = (nint)0 == 0;
			object obj27 = !flag11;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj26 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X0_v516+A0]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE0F1]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X0_v516+E4]");
			bool flag12 = (nint)0 == 0;
			object obj29 = !flag12;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj26 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X0_v516+A0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1299 @ X8_v344+30]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1299 @ X8_v344+30]");
			bool flag13 = (nint)0 == 0;
			text = null;
			ex = null;
			_Canon = null;
			_Canon2 = null;
			sHA = null;
			_Canon3 = null;
			_Canon4 = null;
			obj24 = 0;
			ex2 = null;
			obj25 = (object)(&_Canon5);
			_Canon5 = _Canon7;
			array = null;
			androidJavaObject = currentContext;
			if (flag13)
			{
				goto IL_3565;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D13C0]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1398]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v345+10]");
			text2 = (string)0;
			int value = ((int*)num)->m_value;
			int value2 = ((int*)num3)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v345+10]");
			string text4 = (string)value + (string)(object)_Canon8 + (string)value2 + (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ X8_v341+58]");
			Fail((List<string>)0, 'P', text4);
			int num4 = 0;
			array = (object[])(object)text4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object[] array2 = default;
		bool flag14 = array2 == null;
		text = null;
		ex = null;
		_Canon = null;
		_Canon2 = null;
		sHA = null;
		_Canon3 = null;
		_Canon4 = null;
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&_Canon5);
		_Canon5 = _Canon7;
		num2 = 2;
		androidJavaObject = currentContext;
		if (flag14)
		{
			goto IL_3386;
		}
		bool flag15 = _Canon8 == null;
		num2 = 2;
		nint num6;
		if (!flag15)
		{
			nint num5 = (nint)array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ X8_v339 (Il2CppClass<System.Object[]>)+40]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			object obj33 = default;
			bool flag16 = obj33 == null;
			text = null;
			ex = null;
			_Canon = null;
			_Canon2 = null;
			sHA = null;
			_Canon3 = null;
			_Canon4 = null;
			obj24 = 0;
			ex2 = null;
			obj25 = (object)(&_Canon5);
			_Canon5 = _Canon7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ X8_v339 (Il2CppClass<System.Object[]>)+40]");
			num6 = 0;
			androidJavaObject = currentContext;
			if (flag16)
			{
				goto IL_351d;
			}
		}
		bool flag17 = array2.Length == 0;
		text = null;
		ex = null;
		_Canon = null;
		_Canon2 = null;
		sHA = null;
		_Canon3 = null;
		_Canon4 = null;
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&_Canon5);
		_Canon5 = _Canon7;
		androidJavaObject = currentContext;
		if (flag17)
		{
			goto IL_33b1;
		}
		object obj34 = array2 + 32;
		obj34 = _Canon8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		Array array3 = (Array)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IntPtr intPtr = default;
		bool flag18 = intPtr == (IntPtr)0;
		int num7 = default;
		num2 = (nint)(&num7);
		ArgumentNullException ex3 = default;
		nint num9;
		List<System.__Canon> list;
		if (!flag18)
		{
			nint num8 = (nint)array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2097 @ X8_v338 (Il2CppClass<System.Object[]>)+40]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag19 = ex3 == null;
			text = null;
			ex = null;
			_Canon = null;
			_Canon2 = null;
			sHA = null;
			_Canon3 = null;
			_Canon4 = null;
			list = (List<System.__Canon>)(nint)intPtr;
			obj24 = 0;
			ex2 = null;
			obj25 = (object)(&_Canon5);
			_Canon5 = _Canon7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2097 @ X8_v338 (Il2CppClass<System.Object[]>)+40]");
			num9 = 0;
			androidJavaObject = currentContext;
			if (flag19)
			{
				goto IL_353a;
			}
		}
		object obj35 = array2.Length & 0xFFFFFFFEL;
		bool flag20 = obj35 == null;
		text = null;
		ex = null;
		_Canon = null;
		_Canon2 = null;
		sHA = null;
		_Canon3 = null;
		_Canon4 = null;
		list = (List<System.__Canon>)(nint)intPtr;
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&_Canon5);
		_Canon5 = _Canon7;
		androidJavaObject = currentContext;
		if (flag20)
		{
			goto IL_33bf;
		}
		object obj36 = array2 + 40;
		obj36 = (nint)intPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag21 = _Canon7 == null;
		text = null;
		ex = null;
		_Canon = null;
		_Canon2 = null;
		sHA = null;
		_Canon3 = null;
		_Canon4 = null;
		list = (List<System.__Canon>)(nint)intPtr;
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&_Canon5);
		_Canon5 = _Canon7;
		num2 = intPtr;
		androidJavaObject = currentContext;
		if (flag21)
		{
			goto IL_33cd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D13F8]");
		object obj37 = 0;
		text2 = (string)(object)_Canon6;
		System.__Canon _Canon9 = ((AndroidJavaObject)(object)_Canon7).Call<System.__Canon>((string)obj37, array2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC8]");
		object obj38 = 0;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X22_v63+38]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X22_v63+38]");
		bool flag22 = (nint)0 == 0;
		object obj41 = !flag22;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X22_v63+38]");
			obj40 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2707 @ X8_v160+10]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v272+E4]");
		bool flag23 = (nint)0 == 0;
		object obj43 = !flag23;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X22_v63+38]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2797 @ X8_v336+10]");
			obj42 = 0;
		}
		bool flag24 = _Canon9 == null;
		text = null;
		ex = null;
		_Canon = null;
		_Canon2 = null;
		sHA = null;
		_Canon3 = null;
		object obj45 = 0;
		OutOfMemoryException ex4 = null;
		_Canon4 = _Canon9;
		list = (List<System.__Canon>)(nint)intPtr;
		num7 = (int)(&_Canon4);
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&_Canon5);
		_Canon5 = _Canon7;
		array = array2;
		num2 = (nint)obj37;
		num = (int)(&_Canon4);
		androidJavaObject = currentContext;
		if (flag24)
		{
			goto IL_33db;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D13E0]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1338]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v272+A0]");
		num3 = 0;
		text2 = (string)obj47;
		long num10 = ((AndroidJavaObject)(object)_Canon9).Call<long>((string)obj46, (object[])((int*)num3)->m_value);
		object obj48 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2959 @ X0_v275+E4]");
		bool flag25 = (nint)0 == 0;
		object obj49 = !flag25;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj50 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X0_v279+E4]");
		bool flag26 = (nint)0 == 0;
		object obj51 = !flag26;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj50 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X0_v279+A0]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3569 @ X8_v323+30]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3569 @ X8_v323+30]");
		bool flag27 = (nint)0 == 0;
		text = null;
		ex = null;
		_Canon = null;
		_Canon2 = null;
		sHA = null;
		_Canon3 = null;
		obj45 = 0;
		ex4 = null;
		_Canon4 = _Canon9;
		list = (List<System.__Canon>)(nint)intPtr;
		num7 = (int)(&_Canon4);
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&_Canon5);
		_Canon5 = _Canon7;
		array = (object[])((int*)num3)->m_value;
		num2 = (nint)obj46;
		androidJavaObject = currentContext;
		if (flag27)
		{
			goto IL_33e9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X9_v126 (System.Int32)+38]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X9_v126 (System.Int32)+38]");
		bool flag28 = num10 == 0;
		array = (object[])((int*)num3)->m_value;
		num2 = (nint)obj46;
		int num11 = default;
		if (!flag28)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X0_v279+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X0_v279+E4]");
			bool flag29 = (nint)0 == 0;
			object obj53 = !flag29;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj54 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3648 @ X8_v333+A0]");
				obj52 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj55 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ X0_v487+E4]");
			bool flag30 = (nint)0 == 0;
			object obj56 = !flag30;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj55 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ X0_v487+A0]");
			object obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3776 @ X8_v327+30]");
			bool flag31 = (nint)0 == 0;
			text = null;
			ex = null;
			_Canon = null;
			_Canon2 = null;
			sHA = null;
			_Canon3 = null;
			obj45 = 0;
			ex4 = null;
			_Canon4 = _Canon9;
			list = (List<System.__Canon>)(nint)intPtr;
			num7 = (int)(&_Canon4);
			obj24 = 0;
			ex2 = null;
			obj25 = (object)(&_Canon5);
			_Canon5 = _Canon7;
			array = (object[])((int*)num3)->m_value;
			text3 = (string)(&num11);
			androidJavaObject = currentContext;
			if (flag31)
			{
				goto IL_3573;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1370]");
			object format = 0;
			object arg = default;
			object arg2 = default;
			string text5 = string.Format((string)format, arg, arg2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3569 @ X8_v323+58]");
			Fail((List<string>)0, 'C', text5);
			text2 = null;
			array = (object[])(object)text5;
			num2 = 67;
		}
		bool flag32 = _Canon9 == null;
		text = null;
		ex = null;
		_Canon = null;
		_Canon2 = null;
		sHA = null;
		_Canon3 = null;
		obj45 = 0;
		ex4 = null;
		_Canon4 = _Canon9;
		list = (List<System.__Canon>)(nint)intPtr;
		num7 = (int)(&_Canon4);
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&_Canon5);
		_Canon5 = _Canon7;
		androidJavaObject = currentContext;
		if (flag32)
		{
			goto IL_33f7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1378]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1348]");
		object obj59 = 0;
		array = (object[])obj59;
		System.__Canon _Canon10 = ((AndroidJavaObject)(object)_Canon9).Get<System.__Canon>((string)obj58);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC8]");
		object obj60 = 0;
		object obj61 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X22_v66+38]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X22_v66+38]");
		bool flag33 = (nint)0 == 0;
		object obj63 = !flag33;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X22_v66+38]");
			obj62 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3731 @ X8_v176+10]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X0_v285+E4]");
		bool flag34 = (nint)0 == 0;
		object obj65 = !flag34;
		if (obj65 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X22_v66+38]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3779 @ X8_v321+10]");
			obj64 = 0;
		}
		bool flag35 = _Canon10 == null;
		text = null;
		ex = null;
		_Canon = null;
		_Canon2 = null;
		sHA = null;
		object obj67 = 0;
		OutOfMemoryException ex5 = null;
		num11 = (int)(&_Canon3);
		_Canon3 = _Canon10;
		obj45 = 0;
		ex4 = null;
		_Canon4 = _Canon9;
		list = (List<System.__Canon>)(nint)intPtr;
		num7 = (int)(&_Canon4);
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&_Canon5);
		_Canon5 = _Canon7;
		num2 = (nint)obj58;
		num = (int)(&_Canon3);
		androidJavaObject = currentContext;
		if (flag35)
		{
			goto IL_3405;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D13E8]");
		object methodName2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC70]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X0_v285+A0]");
		num3 = 0;
		array = (object[])((int*)num3)->m_value;
		text2 = (string)((int*)num)->m_value;
		System.__Canon _Canon11 = ((AndroidJavaObject)(object)_Canon10).Call<System.__Canon>((string)methodName2, (object[])((int*)num3)->m_value);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4460]");
		object obj69 = 0;
		num2 = (nint)obj69;
		List<System.__Canon> list2 = default;
		list2._002Ector();
		SHA256 sHA2 = SHA256.Create();
		bool flag36 = _Canon11 == null;
		text = null;
		ex = null;
		_Canon = null;
		_Canon2 = null;
		sHA = sHA2;
		obj67 = 0;
		ex5 = null;
		num11 = (int)(&_Canon3);
		_Canon3 = _Canon10;
		object obj70 = (object)(&sHA);
		obj45 = 0;
		ex4 = null;
		_Canon4 = _Canon9;
		list = list2;
		num7 = (int)(&_Canon4);
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&_Canon5);
		_Canon5 = _Canon7;
		androidJavaObject = currentContext;
		if (flag36)
		{
			goto IL_3430;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3940 @ X0_v287 (System.__Canon)+18]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3940 @ X0_v287 (System.__Canon)+18]");
		object obj72;
		object obj73;
		AndroidJavaObject androidJavaObject2;
		object obj93;
		object obj94;
		object obj86 = default;
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC78]");
			obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			obj73 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
			androidJavaObject2 = (AndroidJavaObject)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj74 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
			object obj75 = 0;
			obj = 0;
			Array array4 = default;
			object obj85;
			while (true)
			{
				bool flag37 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj71);
				object obj76 = !flag37;
				string text6 = (string)(object)array;
				System.__Canon _Canon12 = (System.__Canon)num2;
				if (obj76 == null)
				{
					num = (int)((object)_Canon11 + obj);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC8]");
					object obj77 = 0;
					array3 = (Array)obj77;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X24_v42 (System.Array)+38]");
					object obj78 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X24_v42 (System.Array)+38]");
					bool flag38 = (nint)0 == 0;
					object obj79 = !flag38;
					if (obj79 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X24_v42 (System.Array)+38]");
						obj78 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4438 @ X8_v307+10]");
					object obj80 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4527 @ X0_v456+E4]");
					bool flag39 = (nint)0 == 0;
					object obj81 = !flag39;
					if (obj81 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X24_v42 (System.Array)+38]");
						object obj82 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4530 @ X8_v319+10]");
						obj80 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X9_v126 (System.Int32)+20]");
					if ((nint)0 == 0)
					{
						goto IL_3228;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4527 @ X0_v456+A0]");
					object obj83 = 0;
					array = (object[])obj83;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1380]");
					object obj84 = 0;
					text2 = (string)obj72;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X9_v126 (System.Int32)+20]");
					System.__Canon _Canon13 = ((AndroidJavaObject)0).Call<System.__Canon>((string)obj84, (object[])obj83);
					bool flag40 = _Canon13 == null;
					num2 = (nint)obj84;
					_Canon6 = _Canon13;
					if (flag40)
					{
						goto IL_3236;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4609 @ X0_v458 (System.__Canon)+18]");
					int num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4609 @ X0_v458 (System.__Canon)+18]");
					Buffer.BlockCopy((Array)(object)_Canon13, 0, array4, 0, 0);
					bool flag41 = sHA2 == null;
					obj85 = 0;
					array3 = array4;
					text2 = null;
					text6 = (string)(object)array4;
					_Canon12 = null;
					_Canon6 = _Canon13;
					if (flag41)
					{
						goto IL_31fc;
					}
					byte[] array5 = sHA2.ComputeHash((byte[])array4);
					string text7 = BitConverter.ToString(array5);
					bool flag42 = text7 == null;
					obj85 = 0;
					array3 = array4;
					text2 = null;
					array = null;
					num2 = unchecked((nint)null);
					_Canon6 = _Canon13;
					if (flag42)
					{
						goto IL_321a;
					}
					text6 = (string)obj74;
					string text8 = text7.Replace((string)(object)androidJavaObject2, (string)obj74);
					bool flag43 = text8 == null;
					obj85 = 0;
					array3 = array4;
					text2 = null;
					_Canon12 = (System.__Canon)(object)androidJavaObject2;
					_Canon6 = _Canon13;
					if (flag43)
					{
						goto IL_31ee;
					}
					string text9 = text8.ToLowerInvariant();
					if (list2 != null)
					{
						System.__Canon[] items = list2._items;
						num = (int)obj75;
						num3 = ++list2._version;
						if (list2._items != null)
						{
							num3 = list2._size;
							obj86 = items.Length;
							bool flag44 = list2._size < items.Length;
							object obj87 = !flag44;
							if (obj87 == null)
							{
								object obj88 = list2._items + list2._size;
								num = list2._size + 1;
								list2._size = num;
								object obj89 = obj88 + 32;
								obj89 = text9;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								array = (object[])obj74;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X9_v126 (System.Int32)+20]");
								object obj90 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5320 @ X8_v317+A8]");
								object obj91 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5321 @ X8_v318+70]");
								array = (object[])0;
								list2.AddWithResize((System.__Canon)(object)text9);
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3036 @ X9_v126 (System.Int32)+20]");
							((AndroidJavaObject)0).Dispose();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3940 @ X0_v287 (System.__Canon)+18]");
							obj71 = 0;
							obj++;
							object obj92 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3940 @ X0_v287 (System.__Canon)+18]");
							bool flag45 = (nint)obj92 < 0;
							obj85 = 0;
							array3 = array4;
							text2 = null;
							num2 = unchecked((nint)null);
							_Canon6 = _Canon13;
							if (!flag45)
							{
								break;
							}
							continue;
						}
					}
					NullReferenceException ex6 = new NullReferenceException();
					obj85 = 0;
					array3 = array4;
					text2 = null;
					_Canon12 = (System.__Canon)(object)text9;
					_Canon6 = _Canon13;
				}
				IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
				goto IL_31ee;
				IL_3228:
				NullReferenceException ex8 = new NullReferenceException();
				goto IL_3236;
				IL_321a:
				NullReferenceException ex9 = new NullReferenceException();
				goto IL_3228;
				IL_3236:
				NullReferenceException ex10 = new NullReferenceException();
				text = null;
				ex = null;
				_Canon = null;
				_Canon2 = null;
				sHA = sHA2;
				obj67 = 0;
				ex5 = null;
				num11 = (int)(&_Canon3);
				obj70 = (object)(&sHA);
				obj45 = 0;
				ex4 = null;
				_Canon4 = _Canon9;
				list = list2;
				num7 = (int)(&_Canon4);
				obj24 = 0;
				ex2 = null;
				obj25 = (object)(&_Canon5);
				goto IL_32bc;
				IL_31ee:
				NullReferenceException ex11 = new NullReferenceException();
				goto IL_31fc;
				IL_31fc:
				NullReferenceException ex12 = new NullReferenceException();
				array = (object[])(object)text6;
				num2 = (nint)_Canon12;
				goto IL_321a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			obj93 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAB0]");
			_Canon6 = (System.__Canon)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1340]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			obj32 = 0;
			obj85 = 0;
			array3 = array4;
			obj94 = 6;
			text2 = null;
			num2 = unchecked((nint)null);
			androidJavaObject = currentContext;
			System.__Canon _Canon14 = _Canon8;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			obj93 = 0;
			obj94 = 6;
			androidJavaObject = currentContext;
			System.__Canon _Canon14 = _Canon8;
		}
		object obj95 = (object)(&sHA);
		NullReferenceException ex13 = (NullReferenceException)obj95;
		if (obj95 != null)
		{
			nint num12 = (nint)ex13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4359 @ X8_v293 (Il2CppClass<System.NullReferenceException>)+12E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4359 @ X8_v293 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_123d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4359 @ X8_v293 (Il2CppClass<System.NullReferenceException>)+98]");
			int num13 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4561 @ X10_v131 (System.Int32)-8]");
				obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4561 @ X10_v131 (System.Int32)-8]");
				if (0 == (nint)obj93)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4359 @ X8_v293 (Il2CppClass<System.NullReferenceException>)+12E]");
				num = (int)(-1);
				num3 = num13 + 16;
				bool flag46 = num != 1;
				num13 = num3;
				if (flag46)
				{
					continue;
				}
				goto IL_123d;
			}
			num = ((int*)num13)->m_value;
			object obj96 = num12 + ((int*)num13)->m_value;
			object obj97 = obj96 + 312;
			num3 = num13;
			goto IL_3d22;
		}
		goto IL_4be2;
		IL_2898:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAF0]");
		object path = 0;
		IEnumerable<string> enumerable = File.ReadLines((string)path);
		bool flag47 = enumerable == null;
		num2 = unchecked((nint)null);
		if (flag47)
		{
			goto IL_3478;
		}
		nint num14 = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B8]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4054 @ X8_v98 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4054 @ X8_v98 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_298b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4054 @ X8_v98 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+98]");
		int num15 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4121 @ X10_v99 (System.Int32)-8]");
			obj86 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4121 @ X10_v99 (System.Int32)-8]");
			if ((nint)0 == ((int*)num3)->m_value)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4054 @ X8_v98 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
			num = (int)(-1);
			num3 = num15 + 16;
			bool flag48 = num != 1;
			num15 = num3;
			if (flag48)
			{
				continue;
			}
			goto IL_298b;
		}
		num = ((int*)num15)->m_value;
		object obj98 = num14 + ((int*)num15)->m_value;
		object obj99 = obj98 + 312;
		num3 = num15;
		goto IL_435b;
		IL_4228:
		int value3 = ((int*)num7)->m_value;
		if (((int*)num7)->m_value != 0)
		{
			int value4 = ((int*)value3)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3531 @ X8_v21 (System.Int32)+12E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3531 @ X8_v21 (System.Int32)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_2668;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3531 @ X8_v21 (System.Int32)+98]");
			int num16 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3670 @ X10_v15 (System.Int32)-8]");
				obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3670 @ X10_v15 (System.Int32)-8]");
				if (0 == (nint)obj93)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3531 @ X8_v21 (System.Int32)+12E]");
				num = (int)(-1);
				num3 = num16 + 16;
				bool flag49 = num != 1;
				num16 = num3;
				if (flag49)
				{
					continue;
				}
				goto IL_2668;
			}
			num = ((int*)num16)->m_value;
			object obj100 = value4 + ((int*)num16)->m_value;
			object obj101 = obj100 + 312;
			num3 = num16;
			goto IL_428b;
		}
		goto IL_51b8;
		IL_42aa:
		object obj102 = obj25;
		if (obj25 != null)
		{
			object obj103 = obj102;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3748 @ X8_v13+12E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3748 @ X8_v13+12E]");
			if ((nint)0 == 0)
			{
				goto IL_27dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3748 @ X8_v13+98]");
			int num17 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3954 @ X10_v7 (System.Int32)-8]");
				obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3954 @ X10_v7 (System.Int32)-8]");
				if (0 == (nint)obj93)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3748 @ X8_v13+12E]");
				num = (int)(-1);
				num3 = num17 + 16;
				bool flag50 = num != 1;
				num17 = num3;
				if (flag50)
				{
					continue;
				}
				goto IL_27dd;
			}
			num = ((int*)num17)->m_value;
			object obj104 = obj103 + ((int*)num17)->m_value;
			object obj105 = obj104 + 312;
			num3 = num17;
			goto IL_4303;
		}
		goto IL_51e0;
		IL_33b1:
		IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
		goto IL_33bf;
		IL_3386:
		NullReferenceException ex15 = new NullReferenceException();
		goto IL_3394;
		IL_336a:
		NullReferenceException ex16 = new NullReferenceException();
		goto IL_3378;
		IL_3378:
		NullReferenceException ex17 = new NullReferenceException();
		goto IL_3386;
		IL_3300:
		NullReferenceException ex18 = new NullReferenceException();
		goto IL_330e;
		IL_330e:
		NullReferenceException ex19 = new NullReferenceException();
		char c;
		num2 = (int)c;
		NullReferenceException ex20 = new NullReferenceException();
		object obj106;
		obj86 = obj106;
		obj17 = obj73;
		obj32 = obj72;
		int num18;
		num3 = num18;
		object[] array6;
		array = array6;
		System.__Canon _Canon15;
		_Canon6 = _Canon15;
		androidJavaObject = androidJavaObject2;
		goto IL_336a;
		IL_33db:
		NullReferenceException ex21 = new NullReferenceException();
		goto IL_33e9;
		IL_32d2:
		NullReferenceException ex22 = new NullReferenceException();
		obj106 = obj86;
		num18 = num3;
		array6 = array;
		_Canon15 = _Canon6;
		goto IL_3300;
		IL_33e9:
		NullReferenceException ex23 = new NullReferenceException();
		goto IL_33f7;
		IL_32bc:
		IndexOutOfRangeException ex24 = new IndexOutOfRangeException();
		c = (char)num2;
		goto IL_32d2;
		IL_33f7:
		NullReferenceException ex25 = new NullReferenceException();
		goto IL_3405;
		IL_344c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_345b;
		IL_4671:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5171 @ X0_v192+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5171 @ X0_v192] (should have been resolved before IL gen)");
		goto IL_45ea;
		IL_45ea:
		string text10 = default;
		text = text10;
		obj86 = obj106;
		obj17 = obj73;
		obj32 = obj72;
		num3 = num18;
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&text);
		_Canon6 = _Canon15;
		androidJavaObject = androidJavaObject2;
		goto IL_3486;
		IL_301c:
		object obj107 = (object)(&text);
		object obj108 = obj107;
		bool flag51 = obj107 == null;
		string text11;
		array = (object[])(object)text11;
		num2 = (int)c;
		if (flag51)
		{
			goto IL_45ea;
		}
		object obj109 = obj108;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4926 @ X8_v106+12E]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4926 @ X8_v106+12E]");
		if ((nint)0 == 0)
		{
			goto IL_30fd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4926 @ X8_v106+98]");
		int num19 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5136 @ X10_v79 (System.Int32)-8]");
			obj106 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5136 @ X10_v79 (System.Int32)-8]");
			if (0 == (nint)obj93)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4926 @ X8_v106+12E]");
			num = (int)(-1);
			num18 = num19 + 16;
			bool flag52 = num != 1;
			num19 = num18;
			if (flag52)
			{
				continue;
			}
			goto IL_30fd;
		}
		num = ((int*)num19)->m_value;
		object obj110 = obj109 + ((int*)num19)->m_value;
		object obj111 = obj110 + 312;
		num18 = num19;
		array = (object[])(object)text11;
		goto IL_4671;
		IL_2ef8:
		object obj112 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2438 @ X0_v200+E4]");
		bool flag53 = (nint)0 == 0;
		object obj113 = !flag53;
		if (obj113 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj112 = obj;
		}
		string text12;
		bool flag54 = text12 == null;
		text = text10;
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&text);
		if (!flag54)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2438 @ X0_v200+A0]");
			object obj114 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4597 @ X8_v112+58]");
			androidJavaObject2 = (AndroidJavaObject)0;
			int num20 = text12.LastIndexOf(' ');
			object obj115 = num20 + 1;
			object obj116 = ~obj115;
			int startIndex = obj115 & obj116;
			string text13 = text12.Substring(startIndex);
			string text14 = (string)(object)ex13 + text13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4597 @ X8_v112+58]");
			Fail((List<string>)0, 'I', text14);
			obj106 = obj86;
			obj73 = obj17;
			obj72 = obj32;
			num18 = num3;
			text11 = text14;
			c = 'I';
			_Canon15 = _Canon6;
			goto IL_301c;
		}
		goto IL_3557;
		IL_2eed:
		throw new NullReferenceException();
		IL_3405:
		NullReferenceException ex26 = new NullReferenceException();
		goto IL_3413;
		IL_30fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array = null;
		goto IL_4671;
		IL_3430:
		NullReferenceException ex27 = new NullReferenceException();
		goto IL_343e;
		IL_3413:
		OutOfMemoryException ex28 = new OutOfMemoryException();
		goto IL_3421;
		IL_3421:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_3430;
		IL_27dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array = null;
		goto IL_4303;
		IL_343e:
		OutOfMemoryException ex29 = new OutOfMemoryException();
		goto IL_344c;
		IL_33cd:
		NullReferenceException ex30 = new NullReferenceException();
		goto IL_33db;
		IL_4c6f:
		bool flag55 = ex5 == null;
		object obj117 = !flag55;
		if (obj117 != null)
		{
			goto IL_343e;
		}
		bool flag56 = obj67 == null;
		object obj118 = !flag56;
		ex29 = ex5;
		if (obj118 != null)
		{
			goto IL_344c;
		}
		if ((nint)obj94 != 21)
		{
			bool flag57 = obj94 == null;
			object obj119 = !flag57;
			if (obj119 != null)
			{
				goto IL_4228;
			}
		}
		obj94 = 22;
		goto IL_4228;
		IL_33bf:
		IndexOutOfRangeException ex31 = new IndexOutOfRangeException();
		goto IL_33cd;
		IL_24ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array = null;
		goto IL_4209;
		IL_3394:
		OutOfMemoryException ex32 = new OutOfMemoryException();
		goto IL_33a2;
		IL_51b8:
		bool flag58 = ex4 == null;
		object obj120 = !flag58;
		if (obj120 != null)
		{
			goto IL_3413;
		}
		bool flag59 = obj45 == null;
		object obj121 = !flag59;
		ex28 = ex4;
		if (obj121 != null)
		{
			goto IL_3421;
		}
		if ((nint)obj94 != 22)
		{
			bool flag60 = obj94 == null;
			object obj122 = !flag60;
			if (obj122 != null)
			{
				goto IL_42aa;
			}
		}
		obj94 = 23;
		goto IL_42aa;
		IL_123d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array = null;
		goto IL_3d22;
		IL_4be2:
		text = null;
		ex = null;
		_Canon = null;
		_Canon2 = null;
		sHA = sHA2;
		obj67 = 0;
		ex5 = null;
		num11 = (int)(&_Canon3);
		_Canon3 = _Canon10;
		obj70 = (object)(&sHA);
		obj45 = 0;
		ex4 = null;
		_Canon4 = _Canon9;
		list = list2;
		num7 = (int)(&_Canon4);
		obj24 = 0;
		ex2 = null;
		obj25 = (object)(&_Canon5);
		_Canon5 = _Canon7;
		goto IL_345b;
		IL_3d22:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4646 @ X0_v435+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4646 @ X0_v435] (should have been resolved before IL gen)");
		goto IL_4be2;
		IL_3478:
		NullReferenceException ex33 = new NullReferenceException();
		goto IL_3486;
		IL_345b:
		OutOfMemoryException ex34 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_3478;
		IL_3486:
		OutOfMemoryException ex35 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex36 = new NullReferenceException();
		NullReferenceException ex37 = new NullReferenceException();
		NullReferenceException ex38 = new NullReferenceException();
		OutOfMemoryException ex39 = new OutOfMemoryException();
		IndexOutOfRangeException ex40 = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex41 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		num6 = num2;
		goto IL_351d;
		IL_353a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex42 = new ArgumentNullException();
		text3 = null;
		goto IL_3557;
		IL_3565:
		NullReferenceException ex43 = new NullReferenceException();
		goto IL_3573;
		IL_3557:
		NullReferenceException ex44 = new NullReferenceException();
		goto IL_3565;
		IL_2668:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array = null;
		goto IL_428b;
		IL_3573:
		NullReferenceException ex45 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex46 = new ArgumentNullException();
		IEnumerable<string> enumerable2 = null;
		NullReferenceException ex47 = new NullReferenceException();
		NullReferenceException ex48 = new NullReferenceException();
		if ((nint)enumerable2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj67 = 1;
		}
		else
		{
			if ((nint)enumerable2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				if ((nint)enumerable2 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj45 = 1;
				}
				else
				{
					if ((nint)enumerable2 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
						if ((nint)enumerable2 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj24 = 1;
						}
						else
						{
							if ((nint)enumerable2 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
								bool flag61 = (nint)enumerable2 != 1;
								NullReferenceException ex49 = ex48;
								if (!flag61)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									object obj124 = default;
									object obj123 = obj124;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
									object obj126 = default;
									object obj125 = obj126 & 1;
									object obj127 = default;
									if (obj125 != null)
									{
										obj127 = obj124;
										object obj129 = default;
										object obj128 = (object)(&obj129);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4028 @ X0_v63+E4]");
										bool flag62 = (nint)0 == 0;
										object obj130 = !flag62;
										if (obj130 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4063 @ X0_v67+A0]");
										object obj131 = 0;
										num = (int)obj127;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4132 @ X8_v44+58]");
										androidJavaObject = (AndroidJavaObject)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3036 @ X9_v126 (System.Int32)+188] (should have been resolved before IL gen)");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
										string text16 = default;
										string text17 = default;
										string text15 = text16 + text17;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4132 @ X8_v44+58]");
										Fail((List<string>)0, 'A', text15);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
										obj93 = 0;
										ex13 = ex;
										array = (object[])(object)text15;
										goto IL_2898;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
									object obj132 = obj127;
									enumerable2 = (IEnumerable<string>)(101789696 + 1224);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									NullReferenceException ex50 = default;
									ex49 = ex50;
									array = null;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							object obj133 = default;
							ex2 = (OutOfMemoryException)obj133;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
						obj93 = 0;
						ex13 = ex48;
						obj94 = 0;
						num2 = (nint)enumerable2;
						goto IL_42aa;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					object obj134 = default;
					ex4 = (OutOfMemoryException)obj134;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
				obj93 = 0;
				ex13 = ex48;
				obj94 = 0;
				num2 = (nint)enumerable2;
				goto IL_4228;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj135 = default;
			ex5 = (OutOfMemoryException)obj135;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		obj93 = 0;
		ex13 = ex48;
		obj94 = 0;
		num2 = (nint)enumerable2;
		int value5 = ((int*)num11)->m_value;
		if (((int*)num11)->m_value != 0)
		{
			int value6 = ((int*)value5)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3263 @ X8_v29 (System.Int32)+12E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3263 @ X8_v29 (System.Int32)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_24ee;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3263 @ X8_v29 (System.Int32)+98]");
			int num21 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3459 @ X10_v23 (System.Int32)-8]");
				obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3459 @ X10_v23 (System.Int32)-8]");
				if (0 == (nint)obj93)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3263 @ X8_v29 (System.Int32)+12E]");
				num = (int)(-1);
				num3 = num21 + 16;
				bool flag63 = num != 1;
				num21 = num3;
				if (flag63)
				{
					continue;
				}
				goto IL_24ee;
			}
			num = ((int*)num21)->m_value;
			object obj136 = value6 + ((int*)num21)->m_value;
			object obj137 = obj136 + 312;
			num3 = num21;
			goto IL_4209;
		}
		goto IL_4c6f;
		IL_428b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3744 @ X0_v19+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3744 @ X0_v19] (should have been resolved before IL gen)");
		goto IL_51b8;
		IL_351d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex3 = new ArgumentNullException();
		num9 = unchecked((nint)null);
		goto IL_353a;
		IL_33a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_33b1;
		IL_51e0:
		bool flag64 = ex2 == null;
		object obj138 = !flag64;
		if (obj138 != null)
		{
			goto IL_3394;
		}
		bool flag65 = obj24 == null;
		object obj139 = !flag65;
		ex32 = ex2;
		if (obj139 == null)
		{
			if (obj94 == null || (nint)obj94 == 23)
			{
				goto IL_2898;
			}
			return;
		}
		goto IL_33a2;
		IL_4209:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3527 @ X0_v28+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3527 @ X0_v28] (should have been resolved before IL gen)");
		goto IL_4c6f;
		IL_435b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4175 @ X0_v186+8]");
		text3 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4175 @ X0_v186] (should have been resolved before IL gen)");
		bool flag66 = text10 == null;
		text12 = text10;
		if (flag66)
		{
			goto IL_2eed;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1368]");
		ex13 = (NullReferenceException)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91C0]");
		list = (List<System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		array3 = (Array)0;
		obj106 = obj86;
		obj73 = obj17;
		obj72 = obj32;
		num18 = num3;
		array6 = array;
		_Canon15 = _Canon6;
		androidJavaObject2 = androidJavaObject;
		string text18 = text10;
		string text20 = default;
		object obj153 = default;
		while (true)
		{
			nint num22 = (nint)text18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4407 @ X8_v116 (Il2CppClass<System.String>)+12E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4407 @ X8_v116 (Il2CppClass<System.String>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_2ac5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4407 @ X8_v116 (Il2CppClass<System.String>)+98]");
			int num23 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4586 @ X10_v94 (System.Int32)-8]");
				obj106 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4586 @ X10_v94 (System.Int32)-8]");
				if (0 == (nint)obj140)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4407 @ X8_v116 (Il2CppClass<System.String>)+12E]");
				num = (int)(-1);
				num18 = num23 + 16;
				bool flag67 = num != 1;
				num23 = num18;
				if (flag67)
				{
					continue;
				}
				goto IL_2ac5;
			}
			num = ((int*)num23)->m_value;
			object obj141 = num22 + ((int*)num23)->m_value;
			object obj142 = obj141 + 312;
			num18 = num23;
			goto IL_43ce;
			IL_444f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5157 @ X0_v216] (should have been resolved before IL gen)");
			nint num24 = (nint)array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5163 @ X0_v219 (Il2CppClass<System.Array>)+E4]");
			bool flag68 = (nint)0 == 0;
			object obj143 = !flag68;
			if (obj143 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text19 = ShiftAuth.LoadedText(text20);
			object obj144 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5054 @ X0_v224+E4]");
			bool flag69 = (nint)0 == 0;
			object obj145 = !flag69;
			if (obj145 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj144 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5054 @ X0_v224+A0]");
			object obj146 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5058 @ X8_v124+10]");
			_Canon15 = (System.__Canon)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5058 @ X8_v124+10]");
			bool flag70 = (nint)0 == 0;
			text = text10;
			obj24 = 0;
			ex2 = null;
			obj25 = (object)(&text);
			c = '\0';
			androidJavaObject2 = (AndroidJavaObject)(object)text19;
			if (!flag70)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X25_v42 (System.__Canon)+18]");
				bool flag71 = (nint)0 < (nint)1;
				text3 = null;
				if (flag71)
				{
					goto IL_2e75;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X25_v42 (System.__Canon)+18]");
				object obj147 = 0 & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5058 @ X8_v124+10]");
				obj72 = (nint)0 + (nint)32;
				obj17 = 0;
				array = array6;
				num2 = unchecked((nint)null);
				while (true)
				{
					bool flag72 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj147);
					object obj148 = !flag72;
					text = text10;
					obj86 = obj106;
					obj73 = obj17;
					num3 = num18;
					obj24 = 0;
					ex2 = null;
					obj25 = (object)(&text);
					_Canon6 = _Canon15;
					androidJavaObject2 = (AndroidJavaObject)(object)text19;
					if (obj148 != null)
					{
						break;
					}
					bool flag73 = text19 == null;
					text = text10;
					obj86 = obj106;
					obj73 = obj17;
					num3 = num18;
					obj24 = 0;
					ex2 = null;
					obj25 = (object)(&text);
					c = (char)num2;
					_Canon6 = _Canon15;
					androidJavaObject2 = (AndroidJavaObject)(object)text19;
					if (!flag73)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4308 @ X27_v54+v2395 @ X26_v51*8]");
						text3 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4308 @ X27_v54+v2395 @ X26_v51*8]");
						bool flag74 = text19.Contains((string)0);
						bool flag75 = !flag74;
						object obj149 = !flag75;
						obj86 = obj106;
						obj32 = obj72;
						num3 = num18;
						array = null;
						_Canon6 = _Canon15;
						androidJavaObject = (AndroidJavaObject)(object)text19;
						text12 = text20;
						if (obj149 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X25_v42 (System.__Canon)+18]");
							obj147 = 0;
							obj73 = obj17 + 1;
							object obj150 = obj73;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X25_v42 (System.__Canon)+18]");
							bool flag76 = (nint)obj150 < 0;
							array6 = null;
							obj17 = obj73;
							array = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4308 @ X27_v54+v4285 @ X26_v54*8]");
							num2 = 0;
							if (flag76)
							{
								continue;
							}
							goto IL_2e75;
						}
						goto IL_2ef8;
					}
					goto IL_32d2;
				}
				goto IL_32bc;
			}
			goto IL_330e;
			IL_2e75:
			bool flag77 = text10 == null;
			object obj151 = !flag77;
			obj86 = obj106;
			obj17 = obj73;
			obj32 = obj72;
			num3 = num18;
			array = array6;
			_Canon6 = _Canon15;
			androidJavaObject = (AndroidJavaObject)(object)text19;
			text12 = text10;
			androidJavaObject2 = (AndroidJavaObject)(object)text19;
			text18 = text10;
			if (obj151 != null)
			{
				continue;
			}
			goto IL_2eed;
			IL_2bf2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			array6 = null;
			goto IL_444f;
			IL_2ac5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			array6 = null;
			goto IL_43ce;
			IL_43ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4671 @ X0_v213+8]");
			c = '\0';
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4671 @ X0_v213] (should have been resolved before IL gen)");
			object obj152 = obj153 & 1;
			bool flag78 = obj152 == null;
			text11 = (string)(object)array6;
			if (flag78)
			{
				break;
			}
			bool flag79 = text10 == null;
			text = text10;
			obj24 = 0;
			ex2 = null;
			obj25 = (object)(&text);
			if (flag79)
			{
				goto IL_3300;
			}
			nint num25 = (nint)text10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4807 @ X8_v119 (Il2CppClass<System.String>)+12E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4807 @ X8_v119 (Il2CppClass<System.String>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_2bf2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4807 @ X8_v119 (Il2CppClass<System.String>)+98]");
			int num26 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5107 @ X10_v89 (System.Int32)-8]");
				obj106 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5107 @ X10_v89 (System.Int32)-8]");
				if (0 == (nint)list)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4807 @ X8_v119 (Il2CppClass<System.String>)+12E]");
				num = (int)(-1);
				num18 = num26 + 16;
				bool flag80 = num != 1;
				num26 = num18;
				if (flag80)
				{
					continue;
				}
				goto IL_2bf2;
			}
			num = ((int*)num26)->m_value;
			object obj154 = num25 + ((int*)num26)->m_value;
			object obj155 = obj154 + 312;
			num18 = num26;
			goto IL_444f;
		}
		goto IL_301c;
		IL_4303:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3997 @ X0_v10+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3997 @ X0_v10] (should have been resolved before IL gen)");
		goto IL_51e0;
		IL_298b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array = null;
		goto IL_435b;
	}

	static GillaIntegrity()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0b3b: Expected Obj, but got I
		//IL_0b44: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I8
		//IL_00c1: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_019a: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_022f: Expected Obj, but got I8
		//IL_025c: Expected Obj, but got I
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_029e: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02f7: Expected Obj, but got I
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_0331: Expected Obj, but got I8
		//IL_035e: Expected Obj, but got I
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_03a0: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03f9: Expected Obj, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_043b: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_0494: Expected Obj, but got I
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04d6: Expected Obj, but got I4
		//IL_04ec: Expected Obj, but got I
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_052f: Expected Obj, but got I
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		//IL_0569: Expected Obj, but got I8
		//IL_0596: Expected Obj, but got I
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_05d8: Expected Obj, but got I4
		//IL_05ee: Expected Obj, but got I
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected Obj, but got Unknown
		//IL_0631: Expected Obj, but got I
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got Unknown
		//IL_0673: Expected Obj, but got I4
		//IL_0689: Expected Obj, but got I
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected Obj, but got Unknown
		//IL_06cc: Expected Obj, but got I
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected Obj, but got Unknown
		//IL_070e: Expected Obj, but got I4
		//IL_0724: Expected Obj, but got I
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected Obj, but got Unknown
		//IL_0767: Expected Obj, but got I
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected Obj, but got Unknown
		//IL_07a9: Expected Obj, but got I4
		//IL_07bf: Expected Obj, but got I
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Expected Obj, but got Unknown
		//IL_0802: Expected Obj, but got I
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected Obj, but got Unknown
		//IL_0844: Expected Obj, but got I4
		//IL_085a: Expected Obj, but got I
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected Obj, but got Unknown
		//IL_089d: Expected Obj, but got I
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected Obj, but got Unknown
		//IL_08df: Expected Obj, but got I4
		//IL_08f5: Expected Obj, but got I
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected Obj, but got Unknown
		//IL_0938: Expected Obj, but got I
		//IL_0948: Expected Obj, but got I
		//IL_0958: Expected Obj, but got I
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected Obj, but got Unknown
		//IL_0997: Expected Obj, but got I
		//IL_09cc: Expected Obj, but got I
		//IL_09fc: Expected Obj, but got I
		//IL_0a31: Expected Obj, but got I
		//IL_0a61: Expected Obj, but got I
		//IL_0aae: Expected Obj, but got I
		//IL_0af6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = 257;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1430]");
			object obj5 = 0;
			object obj7 = default;
			object obj6 = obj7 + 32;
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X20_v4-8]");
			object obj8 = 0 & 0xFFFFFFFEL;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1448]");
				object obj9 = 0;
				object obj10 = obj7 + 40;
				obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X20_v6-10]");
				bool flag = (nint)0 < (nint)2;
				object obj11 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X20_v6-10]");
				object obj12 = -2;
				bool flag2 = obj12 == null;
				object obj13 = ~obj11;
				object obj14 = obj13 | flag2;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1440]");
					object obj15 = 0;
					object obj16 = obj7 + 48;
					obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj17 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v16+A0]");
					object obj18 = (nint)0 + (nint)8;
					obj18 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v19+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB08]");
						object obj19 = 0;
						object obj21 = default;
						object obj20 = obj21 + 32;
						obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X20_v8-8]");
						object obj22 = 0 & 0xFFFFFFFEL;
						if (obj22 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB00]");
							object obj23 = 0;
							object obj24 = obj21 + 40;
							obj24 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X20_v10-10]");
							bool flag3 = (nint)0 < (nint)2;
							object obj25 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X20_v10-10]");
							object obj26 = -2;
							bool flag4 = obj26 == null;
							object obj27 = ~obj25;
							object obj28 = obj27 | flag4;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1418]");
								object obj29 = 0;
								object obj30 = obj21 + 48;
								obj30 = obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X20_v12-18]");
								object obj31 = 0 & 0xFFFFFFFCL;
								if (obj31 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB60]");
									object obj32 = 0;
									object obj33 = obj21 + 56;
									obj33 = obj32;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X20_v14-20]");
									bool flag5 = (nint)0 < (nint)4;
									object obj34 = !flag5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X20_v14-20]");
									object obj35 = -4;
									bool flag6 = obj35 == null;
									object obj36 = ~obj34;
									object obj37 = obj36 | flag6;
									if (obj37 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1450]");
										object obj38 = 0;
										object obj39 = obj21 + 64;
										obj39 = obj38;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X20_v16-28]");
										bool flag7 = (nint)0 < (nint)5;
										object obj40 = !flag7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X20_v16-28]");
										object obj41 = -5;
										bool flag8 = obj41 == null;
										object obj42 = ~obj40;
										object obj43 = obj42 | flag8;
										if (obj43 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB58]");
											object obj44 = 0;
											object obj45 = obj21 + 72;
											obj45 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X20_v18-30]");
											bool flag9 = (nint)0 < (nint)6;
											object obj46 = !flag9;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X20_v18-30]");
											object obj47 = -6;
											bool flag10 = obj47 == null;
											object obj48 = ~obj46;
											object obj49 = obj48 | flag10;
											if (obj49 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB48]");
												object obj50 = 0;
												object obj51 = obj21 + 80;
												obj51 = obj50;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X20_v20-38]");
												object obj52 = 0 & 0xFFFFFFF8L;
												if (obj52 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB38]");
													object obj53 = 0;
													object obj54 = obj21 + 88;
													obj54 = obj53;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X20_v22-40]");
													bool flag11 = (nint)0 < (nint)8;
													object obj55 = !flag11;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X20_v22-40]");
													object obj56 = -8;
													bool flag12 = obj56 == null;
													object obj57 = ~obj55;
													object obj58 = obj57 | flag12;
													if (obj58 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1420]");
														object obj59 = 0;
														object obj60 = obj21 + 96;
														obj60 = obj59;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X20_v24-48]");
														bool flag13 = (nint)0 < (nint)9;
														object obj61 = !flag13;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X20_v24-48]");
														object obj62 = -9;
														bool flag14 = obj62 == null;
														object obj63 = ~obj61;
														object obj64 = obj63 | flag14;
														if (obj64 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1428]");
															object obj65 = 0;
															object obj66 = obj21 + 104;
															obj66 = obj65;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X20_v26-50]");
															bool flag15 = (nint)0 < (nint)10;
															object obj67 = !flag15;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X20_v26-50]");
															object obj68 = -10;
															bool flag16 = obj68 == null;
															object obj69 = ~obj67;
															object obj70 = obj69 | flag16;
															if (obj70 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB10]");
																object obj71 = 0;
																object obj72 = obj21 + 112;
																obj72 = obj71;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X20_v28-58]");
																bool flag17 = (nint)0 < (nint)11;
																object obj73 = !flag17;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X20_v28-58]");
																object obj74 = -11;
																bool flag18 = obj74 == null;
																object obj75 = ~obj73;
																object obj76 = obj75 | flag18;
																if (obj76 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB28]");
																	object obj77 = 0;
																	object obj78 = obj21 + 120;
																	obj78 = obj77;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X20_v30-60]");
																	bool flag19 = (nint)0 < (nint)12;
																	object obj79 = !flag19;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X20_v30-60]");
																	object obj80 = -12;
																	bool flag20 = obj80 == null;
																	object obj81 = ~obj79;
																	object obj82 = obj81 | flag20;
																	if (obj82 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1438]");
																		object obj83 = 0;
																		object obj84 = obj21 + 128;
																		obj84 = obj83;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X20_v32-68]");
																		bool flag21 = (nint)0 < (nint)13;
																		object obj85 = !flag21;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X20_v32-68]");
																		object obj86 = -13;
																		bool flag22 = obj86 == null;
																		object obj87 = ~obj85;
																		object obj88 = obj87 | flag22;
																		if (obj88 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBC0]");
																			object obj89 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
																			object obj90 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
																			object obj91 = 0;
																			object obj92 = obj21 + 136;
																			obj92 = obj89;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			object obj93 = obj;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v59+A0]");
																			object obj94 = (nint)0 + (nint)16;
																			obj94 = obj21;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			object obj95 = obj;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v60+A0]");
																			object obj96 = (nint)0 + (nint)32;
																			obj96 = obj90;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			object obj97 = obj;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v61+A0]");
																			object obj98 = (nint)0 + (nint)40;
																			obj98 = obj90;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			object obj99 = obj;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v62+A0]");
																			object obj100 = (nint)0 + (nint)56;
																			obj100 = obj90;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			object obj101 = obj;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v63+A0]");
																			object obj102 = (nint)0 + (nint)64;
																			obj102 = obj90;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																			List<System.__Canon> list = default;
																			list._002Ector();
																			object obj103 = obj;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v64+A0]");
																			object obj104 = (nint)0 + (nint)80;
																			obj104 = list;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																			List<System.__Canon> list2 = default;
																			list2._002Ector();
																			object obj105 = obj;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v65+A0]");
																			object obj106 = (nint)0 + (nint)88;
																			obj106 = list2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			return;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
