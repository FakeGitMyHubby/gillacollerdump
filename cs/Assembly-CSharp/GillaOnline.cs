using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Fusion;
using Photon.Client;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.Networking;

public class GillaOnline : MonoBehaviour
{
	private sealed class _003CSend_003Ed__16 : _0021_00210, _00210, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GillaOfflineReport.Report r;

		private string _003Cbody_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CSend_003Ed__16(int _003C_003E1__state)
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
			//IL_0265: Expected I4, but got I8
			//IL_0021: Expected Obj, but got I4
			//IL_02a3: Expected Obj, but got I
			//IL_02b3: Expected Obj, but got I
			//IL_0048: Expected Obj, but got I
			//IL_0057: Expected I4, but got I8
			//IL_02e3: Expected Obj, but got I
			//IL_0095: Expected I, but got Obj
			//IL_0339: Expected Obj, but got I
			//IL_0349: Expected Obj, but got I
			//IL_0aa1: Expected Obj, but got I
			//IL_0acb: Expected Obj, but got I4
			//IL_00b7: Expected I, but got Obj
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Expected Obj, but got Unknown
			//IL_03ad: Expected Obj, but got I4
			//IL_00d2: Expected I, but got Obj
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_0133: Expected I, but got Obj
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected Obj, but got Unknown
			//IL_0168: Expected Obj, but got I
			//IL_0192: Expected Obj, but got I4
			//IL_09e1: Expected Obj, but got I4
			//IL_0bca: Expected Obj, but got I
			//IL_08f4: Expected Obj, but got I
			//IL_03d5: Expected Obj, but got I
			//IL_03dd: Expected I, but got Obj
			//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a35: Expected Obj, but got Unknown
			//IL_0a3d: Expected Obj, but got I
			//IL_01ed: Expected Obj, but got I4
			//IL_03f2: Expected Obj, but got I
			//IL_0430: Expected Obj, but got I4
			//IL_0a19: Expected Obj, but got I4
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Expected Obj, but got Unknown
			//IL_0bff: Expected Obj, but got I
			//IL_04a8: Expected I, but got Obj
			//IL_0251: Expected I, but got Obj
			//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c4: Expected Obj, but got Unknown
			//IL_0b03: Expected Obj, but got I4
			//IL_0c3a: Expected Obj, but got I
			//IL_0c69: Expected Obj, but got I
			//IL_0531: Expected Obj, but got I4
			//IL_0b92: Expected Obj, but got I
			//IL_0502: Expected Obj, but got I
			//IL_0b21: Expected Obj, but got I
			//IL_0b3b: Expected Obj, but got I
			//IL_0b74: Expected I, but got Obj
			//IL_055f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0564: Expected Obj, but got Unknown
			//IL_0588: Expected I4, but got I8
			//IL_05b6: Expected I, but got Obj
			//IL_05cc: Expected I, but got Obj
			//IL_05f5: Expected Obj, but got I
			//IL_063b: Expected I, but got Obj
			//IL_066b: Expected Obj, but got I
			//IL_06aa: Expected I, but got Obj
			//IL_06f4: Expected I, but got Obj
			//IL_0712: Expected Obj, but got I
			//IL_0722: Expected Obj, but got I
			//IL_0765: Expected I, but got Obj
			//IL_07da: Unknown result type (might be due to invalid IL or missing references)
			//IL_07df: Expected Obj, but got Unknown
			_003CSend_003Ed__16 obj4 = default;
			nint num = default;
			bool result;
			UnityWebRequestAsyncOperation unityWebRequestAsyncOperation2;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				result = false;
				if (obj != null)
				{
					goto IL_0828;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F90]");
				object obj2 = 0;
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj3 = default;
				obj3._002Ector();
				GillaOfflineReport.Report report = obj4.r;
				bool flag2 = obj4.r == null;
				num = unchecked((nint)null);
				if (!flag2)
				{
					bool flag3 = obj3 == null;
					num = unchecked((nint)null);
					if (flag3)
					{
						goto IL_0849;
					}
					num = (nint)report.Offline;
					object obj5 = obj3 + 16;
					obj5 = report.Offline;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					GillaOfflineReport.Report report2 = obj4.r;
					if (obj4.r == null)
					{
						goto IL_0857;
					}
					num = (nint)report2.Step;
					object obj6 = obj3 + 24;
					obj6 = report2.Step;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
					object obj7 = 0;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v74+E4]");
					bool flag4 = (nint)0 == 0;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj10 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v78+E4]");
					bool flag5 = (nint)0 == 0;
					object obj11 = !flag5;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj10 = obj7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v78+A0]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v43+30]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v78+E4]");
						bool flag6 = (nint)0 == 0;
						object obj13 = !flag6;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj14 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X0_v137+E4]");
						bool flag7 = (nint)0 == 0;
						object obj15 = !flag7;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj14 = obj7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X0_v137+A0]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v79+30]");
						if ((nint)0 == 0)
						{
							goto IL_08e3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v79+30]");
						int num2 = (int)((nint)0 + (nint)56);
						string text = ((int*)num2)->ToString();
						num = (nint)text;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object obj17 = 0;
						num = (nint)obj17;
					}
					object obj18 = obj3 + 32;
					obj18 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					GillaOfflineReport.Report report3 = obj4.r;
					if (obj4.r == null)
					{
						goto IL_0865;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F00]");
					object obj19 = 0;
					object obj20 = obj19;
					_ = report3.Secs;
					_ = report3.Back;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X0_v83+E4]");
					bool flag8 = (nint)0 == 0;
					object obj21 = !flag8;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text2 = GillaOfflineReport.DetailNow(obj4.r);
					object obj22 = obj3 + 48;
					obj22 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					string text3 = JsonUtility.ToJson(obj3);
					bool flag9 = obj4 == null;
					num = (nint)text3;
					if (flag9)
					{
						goto IL_0873;
					}
					object obj23 = obj4 + 40;
					obj23 = text3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj24 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v96+E4]");
					bool flag10 = (nint)0 == 0;
					object obj25 = !flag10;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj24 = obj19;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v96+A0]");
					object obj26 = (nint)0 + (nint)8;
					obj26 = obj4._003Cbody_003E5__2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj27 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v51+A0]");
					object value = 0;
					object obj28;
					if (string.IsNullOrEmpty((string)value))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FB0]");
						obj28 = 0;
					}
					else
					{
						object obj29 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X0_v125+E4]");
						bool flag11 = (nint)0 == 0;
						object obj30 = !flag11;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj29 = obj19;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X0_v125+A0]");
						obj28 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0A0]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0B0]");
					object obj32 = 0;
					string text4 = (string)obj32;
					UnityWebRequest unityWebRequest = default;
					unityWebRequest._002Ector((string)obj28, (string)obj32);
					bool flag12 = obj4 == null;
					int num3 = 0;
					num = (nint)obj28;
					if (flag12)
					{
						goto IL_0881;
					}
					object obj33 = obj4 + 48;
					obj33 = unityWebRequest;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj4._003C_003E1__state = -3;
					Encoding uTF = Encoding.UTF8;
					bool flag13 = uTF == null;
					num3 = 0;
					num = (nint)unityWebRequest;
					if (flag13)
					{
						goto IL_088f;
					}
					nint num4 = (nint)uTF;
					((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])(object)obj4._003Cbody_003E5__2, 0, 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0A8]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					UploadHandlerRaw uploadHandlerRaw = default;
					byte[] array = default;
					uploadHandlerRaw._002Ector(array);
					bool flag14 = obj4._003Crequest_003E5__3 == null;
					text4 = null;
					num3 = 0;
					num = (nint)array;
					if (flag14)
					{
						goto IL_089d;
					}
					obj4._003Crequest_003E5__3.uploadHandler = uploadHandlerRaw;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF098]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					DownloadHandlerBuffer downloadHandlerBuffer = default;
					downloadHandlerBuffer._002Ector();
					bool flag15 = obj4._003Crequest_003E5__3 == null;
					text4 = null;
					num3 = 0;
					num = unchecked((nint)null);
					if (flag15)
					{
						goto IL_08ab;
					}
					obj4._003Crequest_003E5__3.downloadHandler = downloadHandlerBuffer;
					bool flag16 = obj4._003Crequest_003E5__3 == null;
					text4 = null;
					num3 = 0;
					num = (nint)downloadHandlerBuffer;
					if (flag16)
					{
						goto IL_08b9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0B8]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0C0]");
					object obj37 = 0;
					text4 = (string)obj37;
					obj4._003Crequest_003E5__3.SetRequestHeader((string)obj36, (string)obj37);
					bool flag17 = obj4._003Crequest_003E5__3 == null;
					num3 = 0;
					num = (nint)obj36;
					if (flag17)
					{
						goto IL_08c7;
					}
					obj4._003Crequest_003E5__3.timeout = 10;
					bool flag18 = obj4._003Crequest_003E5__3 == null;
					text4 = null;
					num3 = 0;
					num = 10;
					if (flag18)
					{
						goto IL_08d5;
					}
					UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = obj4._003Crequest_003E5__3.SendWebRequest();
					object obj38 = obj4 + 24;
					obj38 = unityWebRequestAsyncOperation;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj4._003C_003E1__state = 1;
					result = true;
					text4 = null;
					num3 = 0;
					unityWebRequestAsyncOperation2 = unityWebRequestAsyncOperation;
					goto IL_096e;
				}
			}
			else
			{
				_003C_003E1__state = -3;
				if (_003Crequest_003E5__3 != null)
				{
					UnityWebRequest.Result result2 = _003Crequest_003E5__3.result;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FB8]");
					object obj39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FA0]");
					object obj40 = 0;
					string text5;
					if (result2 == (UnityWebRequest.Result)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FA8]");
						object obj41 = 0;
						text5 = (string)obj41;
					}
					else
					{
						bool flag19 = obj4._003Crequest_003E5__3 == null;
						unityWebRequestAsyncOperation2 = null;
						if (flag19)
						{
							goto IL_08f9;
						}
						string error = obj4._003Crequest_003E5__3.error;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F98]");
						object obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
						object obj43 = 0;
						string text6 = (string)obj42 + error + (string)obj43;
						text5 = text6;
					}
					string message = (string)obj40 + _003Cbody_003E5__2 + (string)obj39 + text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj44 = 0;
					object obj45 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v52+E4]");
					bool flag20 = (nint)0 == 0;
					object obj46 = !flag20;
					if (obj46 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.Log(message);
					obj4._003C_003Em__Finally1();
					object obj47 = obj4 + 48;
					obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					result = false;
					goto IL_0828;
				}
				NullReferenceException ex = new NullReferenceException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0849;
			IL_089d:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_08ab;
			IL_08d5:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_08e3;
			IL_08b9:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_08c7;
			IL_0b97:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A14F0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result3 = default;
			return result3;
			IL_0828:
			return result;
			IL_08f9:
			NullReferenceException ex6 = new NullReferenceException();
			bool flag21 = (nint)unityWebRequestAsyncOperation2 != 1;
			NullReferenceException ex7 = ex6;
			if (!flag21)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj48 = default;
				bool flag22 = obj48 == null;
				result = false;
				if (flag22)
				{
					goto IL_0828;
				}
				goto IL_096e;
			}
			goto IL_0b97;
			IL_08e3:
			NullReferenceException ex8 = new NullReferenceException();
			unityWebRequestAsyncOperation2 = (UnityWebRequestAsyncOperation)num;
			goto IL_08f9;
			IL_096e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1510");
			OutOfMemoryException ex9 = new OutOfMemoryException();
			ex7 = (NullReferenceException)(object)ex9;
			goto IL_0b97;
			IL_08c7:
			NullReferenceException ex10 = new NullReferenceException();
			goto IL_08d5;
			IL_0881:
			NullReferenceException ex11 = new NullReferenceException();
			goto IL_088f;
			IL_088f:
			NullReferenceException ex12 = new NullReferenceException();
			goto IL_089d;
			IL_08ab:
			NullReferenceException ex13 = new NullReferenceException();
			goto IL_08b9;
			IL_0873:
			NullReferenceException ex14 = new NullReferenceException();
			goto IL_0881;
			IL_0849:
			NullReferenceException ex15 = new NullReferenceException();
			goto IL_0857;
			IL_0865:
			NullReferenceException ex16 = new NullReferenceException();
			goto IL_0873;
			IL_0857:
			NullReferenceException ex17 = new NullReferenceException();
			goto IL_0865;
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
			UnityWebRequest unityWebRequest = _003Crequest_003E5__3;
			_003C_003E1__state = -1;
			if (_003Crequest_003E5__3 == null)
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

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public string refused;

		public int lobbies;

		public int lobbyCount;

		public int appStats;

		public RealtimeClient c;

		internal unsafe void _003CLook_003Eb__0(OperationResponse response)
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected I4, but got Unknown
			//IL_00d6: Expected Obj, but got I
			//IL_0077: Expected Obj, but got I
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected Obj, but got Unknown
			//IL_0141: Expected I4, but got I8
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected Obj, but got Unknown
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected Obj, but got Unknown
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Expected I4, but got Unknown
			if (response.OperationCode != 221)
			{
				return;
			}
			short num = (short)(response + 18);
			if (((short*)num)->m_value != 0)
			{
				string text = ((short*)num)->ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
				object obj = 0;
				string text2 = text + (string)obj + response.DebugMessage;
				object obj2 = this + 16;
				obj2 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return;
			}
			object obj3 = response.get_Item((byte)229);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			object obj5 = default;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+18]");
				int num3;
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+18]");
					int num2 = 0;
					object obj6 = obj5 + 32;
					num3 = 0;
					object obj7 = default;
					obj6 = obj7;
					int num4 = default;
					num2 = num4;
					int num5 = default;
					num3 = num5;
					do
					{
						obj6 += 4;
						num2--;
						num3 = obj6 + num3;
					}
					while (num2 != 1);
				}
				else
				{
					num3 = 0;
				}
				lobbies = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+18]");
				lobbyCount = 0;
			}
			else
			{
				lobbies = 0;
			}
		}

		internal void _003CLook_003Eb__1(EventData e)
		{
			if (e.Code == 226)
			{
				RealtimeClient realtimeClient = c;
				appStats = realtimeClient.PlayersInRoomsCount__BackingField;
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_1
	{
		public string ticket;

		internal void _003CLook_003Eb__2(bool ok, string fresh)
		{
			//IL_001a: Expected Obj, but got I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected Obj, but got Unknown
			bool flag = !ok;
			object obj = !flag;
			object obj2 = ~obj;
			string text = ((obj2 != null) ? null : fresh);
			object obj3 = this + 16;
			obj3 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public RealtimeClient client;

		internal unsafe void _003CTell_003Eg__Answer_007C0(OperationResponse r)
		{
			//IL_003a: Expected Obj, but got I
			//IL_0054: Expected Obj, but got I
			//IL_0062: Expected I, but got Obj
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected I4, but got Unknown
			//IL_011e: Expected Obj, but got I
			//IL_0134: Expected Obj, but got I4
			//IL_017c: Expected Obj, but got I
			//IL_01a6: Expected Obj, but got I4
			//IL_00c3: Expected Obj, but got I
			//IL_00f8: Expected Obj, but got I4
			//IL_01de: Expected Obj, but got I4
			//IL_0202: Expected Obj, but got I
			if (r.OperationCode == 252)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FE0]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF8]");
				object obj2 = 0;
				Action<System.__Canon> action = default;
				action._002Ector((object)this, (IntPtr)obj2);
				client.OpResponseReceived -= (Action<OperationResponse>)action;
				short num = (short)(r + 18);
				string text3;
				if (((short*)num)->m_value != 0)
				{
					string text = ((short*)num)->ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
					object obj3 = 0;
					string debugMessage = r.DebugMessage;
					string text2 = text + (string)obj3 + r.DebugMessage;
					object obj4 = 0;
					Action<OperationResponse> action2 = (Action<OperationResponse>)obj3;
					text3 = text2;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3040]");
					object obj5 = 0;
					text3 = (string)obj5;
					string debugMessage = null;
					object obj4 = 0;
					Action<OperationResponse> action2 = (Action<OperationResponse>)action;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj9 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v14+E4]");
				bool flag2 = (nint)0 == 0;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v14+A0]");
				object obj11 = (nint)0 + (nint)8;
				obj11 = text3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
		}
	}

	public const string Property = null;

	public const float Every = default(float);

	public const float Soonest = default(float);

	private const float GiveUp = default(float);

	private static string LastLook__BackingField;

	private static string TellReply__BackingField;

	private float nextLook;

	private float lastLook = -999f;

	private bool looking;

	private NetworkRunner roomOf;

	private RealtimeClient client;

	private const float Fresh = default(float);

	private static int lastCount;

	private static float lastCountAt;

	private static readonly FieldInfo CloudField;

	public static string LastLook
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
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
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
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
			obj4 = value;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static string TellReply
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
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
			object obj4 = (nint)0 + (nint)8;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static int Total
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_04b2: Expected Obj, but got I4
			//IL_04d8: Expected Obj, but got I
			//IL_04fa: Expected Obj, but got I4
			//IL_07d9: Expected Obj, but got I
			//IL_07fb: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I
			//IL_0518: Expected Obj, but got I
			//IL_0542: Expected Obj, but got I4
			//IL_0819: Expected Obj, but got I
			//IL_0833: Expected Obj, but got I8
			//IL_084d: Expected Obj, but got I4
			//IL_00b1: Expected Obj, but got I4
			//IL_0177: Expected Obj, but got I4
			//IL_08ca: Expected Obj, but got I4
			//IL_0149: Expected Obj, but got I4
			//IL_057a: Expected Obj, but got I4
			//IL_01b3: Expected Obj, but got I4
			//IL_0598: Expected Obj, but got I
			//IL_05c8: Invalid comparison between F4 and I4
			//IL_05d9: Expected Obj, but got I4
			//IL_086b: Expected Obj, but got I
			//IL_087b: Expected Obj, but got I
			//IL_0354: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Expected Obj, but got Unknown
			//IL_0488: Expected I4, but got Obj
			//IL_03ae: Expected Obj, but got I4
			//IL_00fa: Expected Obj, but got I
			//IL_06e1: Expected Obj, but got I
			//IL_0222: Expected Obj, but got I
			//IL_0286: Expected Obj, but got I4
			//IL_02c2: Expected I4, but got I8
			//IL_02dc: Expected Obj, but got I4
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Expected Obj, but got Unknown
			//IL_03fb: Expected Obj, but got I4
			//IL_0314: Expected Obj, but got I4
			//IL_0433: Expected Obj, but got I4
			//IL_05f6: Expected Obj, but got I
			//IL_0619: Expected Obj, but got I4
			//IL_064c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0651: Expected I4, but got Unknown
			//IL_0686: Expected Obj, but got I4
			//IL_068e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0693: Expected Obj, but got Unknown
			//IL_0706: Expected Obj, but got I
			//IL_071b: Expected Obj, but got I
			//IL_075e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0763: Expected I4, but got Unknown
			//IL_0798: Expected Obj, but got I4
			//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a5: Expected Obj, but got Unknown
			//IL_06ba: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v1+8]");
			bool flag4 = (UnityEngine.Object)0 != null;
			bool flag5 = !flag4;
			UnityEngine.Object obj10 = null;
			if (!flag5)
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v58+E4]");
				bool flag6 = (nint)0 == 0;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v62+E4]");
				bool flag7 = (nint)0 == 0;
				object obj14 = !flag7;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v62+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v35+8]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v35+8]");
				if ((nint)0 == 0)
				{
					goto IL_047a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v36+B0]");
				obj10 = (UnityEngine.Object)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v12+E4]");
			bool flag8 = (nint)0 == 0;
			object obj19 = !flag8;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj17;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v12+A0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10+10]");
			object obj21 = 0 & 0x80000000L;
			bool flag9 = obj21 == null;
			object obj22 = !flag9;
			object obj27;
			if (obj22 == null)
			{
				float unscaledTime = Time.unscaledTime;
				object obj23 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v51+E4]");
				bool flag10 = (nint)0 == 0;
				object obj24 = !flag10;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj23 = obj17;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v51+A0]");
				object obj25 = 0;
				float num = unscaledTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v28+14]");
				float num2 = num - 0f;
				float num3 = num2 - 1.1230249E+09f;
				bool flag11 = num3 < 0f;
				object obj26 = !flag11;
				obj27 = obj26;
			}
			else
			{
				obj27 = 1;
			}
			object obj28 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v14+E4]");
			bool flag12 = (nint)0 == 0;
			object obj29 = !flag12;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = obj10 == null;
			bool flag14 = !flag13;
			object obj30 = !flag14;
			UnityEngine.Object obj31 = null;
			int num4;
			int num5;
			if (obj30 == null)
			{
				if ((object)obj10 == null)
				{
					goto IL_047a;
				}
				bool isRunning = ((NetworkRunner)obj10).IsRunning;
				bool flag15 = !isRunning;
				obj31 = null;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X19_v4 (UnityEngine.Object)+2F8]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X19_v4 (UnityEngine.Object)+2F8]");
					bool flag16 = (nint)0 == 0;
					obj31 = null;
					if (!flag16)
					{
						object obj33 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v19+28]");
						num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v28+E4]");
						bool flag17 = (nint)0 == 0;
						object obj34 = !flag17;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						num5 = Told((NetworkRunner)obj10);
						int num6 = (int)(num5 & 0x80000000L);
						bool flag18 = num6 == 0;
						object obj35 = !flag18;
						if (obj35 == null)
						{
							object obj36 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v40+E4]");
							bool flag19 = (nint)0 == 0;
							object obj37 = !flag19;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj36 = obj17;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v40+A0]");
							object obj38 = 0;
							float unscaledTime2 = Time.unscaledTime;
							object obj39 = obj17;
							object obj40 = num5 - num4;
							bool flag20 = (nint)obj40 < 0;
							bool flag21 = obj40 == null;
							int num7 = num5 ^ num4;
							int num8 = num5 ^ obj40;
							int num9 = num7 & num8;
							bool flag22 = num9 < 0;
							bool flag23 = flag20 == flag22;
							object obj41 = !flag21;
							object obj42 = flag23 & obj41;
							object obj43 = ~obj42;
							if (obj43 != null)
							{
								num5 = num4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v25+A0]");
							object obj44 = 0;
						}
						else
						{
							object obj45 = obj27 & 1;
							bool flag24 = obj45 == null;
							object obj46 = !flag24;
							if (obj46 != null)
							{
								goto IL_06c4;
							}
							object obj47 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v33+E4]");
							bool flag25 = (nint)0 == 0;
							object obj48 = !flag25;
							if (obj48 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj47 = obj17;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v33+A0]");
							object obj49 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v21+10]");
							object obj50 = -num4;
							bool flag26 = (nint)obj50 < 0;
							bool flag27 = obj50 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v21+10]");
							int num10 = (int)((nint)0 ^ (nint)num4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v21+10]");
							int num11 = 0 ^ obj50;
							int num12 = num10 & num11;
							bool flag28 = num12 < 0;
							bool flag29 = flag26 == flag28;
							object obj51 = !flag27;
							object obj52 = flag29 & obj51;
							object obj53 = ~obj52;
							if (obj53 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v21+10]");
								num5 = 0;
							}
							else
							{
								num5 = num4;
							}
						}
						goto IL_08d8;
					}
				}
			}
			object obj54 = obj27 & 1;
			if (obj54 != null)
			{
				num4 = 0;
			}
			else
			{
				object obj55 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v23+E4]");
				bool flag30 = (nint)0 == 0;
				object obj56 = !flag30;
				if (obj56 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj55 = obj17;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v23+A0]");
				object obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v18+10]");
				num4 = 0;
			}
			goto IL_06c4;
			IL_06c4:
			num5 = num4;
			goto IL_08d8;
			IL_047a:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_08d8:
			return num5;
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
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
		_ = -70364449210369L;
	}

	public static int Told(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I4
		//IL_0178: Expected I4, but got I8
		//IL_018b: Expected I4, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)runner != (UnityEngine.Object)null)
		{
			if ((object)runner == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			SessionInfo sessionInfo = runner.SessionInfo__BackingField;
			if (runner.SessionInfo__BackingField != null && (object)sessionInfo.Properties__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FC8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE198]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4283DDC");
				object obj7 = default;
				object obj6 = obj7 & 1;
				SessionProperty sessionProperty = default;
				if (obj6 != null && sessionProperty != null && sessionProperty.IsInt)
				{
					return sessionProperty;
				}
			}
		}
		return -1;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I
		//IL_0331: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_0355: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01d4: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 != null;
		bool flag5 = !flag4;
		UnityEngine.Object obj11 = null;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X21_v3 (UnityEngine.Object)+B0]");
			obj11 = (UnityEngine.Object)0;
		}
		bool flag6 = (byte)(~(looking ? 1u : 0u)) != 0;
		object obj12 = !flag6;
		if (obj12 != null)
		{
			return;
		}
		object obj13 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = obj11 == null;
		bool flag9 = !flag8;
		object obj15 = !flag9;
		if (obj15 != null || !((NetworkRunner)obj11).IsRunning)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v1+8]");
		if (!((NetworkBootstrap)0).Settled || !((NetworkRunner)obj11).IsSharedModeMasterClient)
		{
			return;
		}
		object obj16 = obj5;
		object obj17 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v21+E4]");
		bool flag10 = (nint)0 == 0;
		object obj18 = !flag10;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj11 != (UnityEngine.Object)obj17)
		{
			roomOf = (NetworkRunner)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			double num = (double)lastLook + 15.0;
			if ((double)nextLook < num)
			{
				num = nextLook;
			}
			nextLook = (float)num;
		}
		float unscaledTime = Time.unscaledTime;
		if (!(unscaledTime < nextLook))
		{
			float unscaledTime2 = Time.unscaledTime;
			float num2 = unscaledTime2 + 1.1146363E+09f;
			nextLook = num2;
			IEnumerator routine = Look((NetworkRunner)obj11);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator Look(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FD0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj2 + 56;
		obj4 = runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	private static bool Tell(NetworkRunner runner, int count)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0364: Expected Obj, but got I4
		//IL_0327: Expected I4, but got Obj
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_039c: Expected Obj, but got I4
		//IL_03fd: Expected Obj, but got I
		//IL_041f: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I
		//IL_01f3: Expected I, but got Obj
		//IL_0259: Expected I, but got Obj
		//IL_0298: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FD8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RealtimeClient realtimeClient = RoomClient(runner);
		if (obj3 != null)
		{
			object obj6 = obj3 + 16;
			obj6 = realtimeClient;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			RealtimeClient realtimeClient2 = (RealtimeClient)obj6;
			if (obj6 != null)
			{
				Room room = realtimeClient2.CurrentRoom__BackingField;
				if (realtimeClient2.CurrentRoom__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FE0]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF8]");
					object obj8 = 0;
					Action<System.__Canon> action = default;
					action._002Ector(obj3, (IntPtr)obj8);
					((RealtimeClient)obj6).OpResponseReceived += (Action<OperationResponse>)action;
					object obj9 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v18+E4]");
					bool flag2 = (nint)0 == 0;
					object obj10 = !flag2;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FA8]");
					object obj11 = 0;
					object obj12 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v22+E4]");
					bool flag3 = (nint)0 == 0;
					object obj13 = !flag3;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj12 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v22+A0]");
					object obj14 = (nint)0 + (nint)8;
					obj14 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					PhotonHashtable photonHashtable = default;
					photonHashtable._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					if (photonHashtable != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FC8]");
						object key = 0;
						System.__Canon value = default;
						((Dictionary<System.__Canon, System.__Canon>)(object)photonHashtable).Add((System.__Canon)key, value);
						nint num = (nint)room;
						int hashCode = ((object)realtimeClient2.CurrentRoom__BackingField).GetHashCode();
						if ((hashCode & 1) != 0)
						{
							return true;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Action<System.__Canon> action2 = default;
						action2._002Ector(obj3, (IntPtr)obj8);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+10]");
							((RealtimeClient)0).OpResponseReceived -= (Action<OperationResponse>)action2;
							object obj17 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v36+E4]");
							bool flag4 = (nint)0 == 0;
							object obj18 = !flag4;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3000]");
							object obj19 = 0;
							object obj20 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v40+E4]");
							bool flag5 = (nint)0 == 0;
							object obj21 = !flag5;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj20 = obj2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v40+A0]");
							object obj22 = (nint)0 + (nint)8;
							obj22 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							goto IL_030b;
						}
					}
					goto IL_0319;
				}
			}
			goto IL_030b;
		}
		goto IL_0319;
		IL_0319:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_030b:
		return false;
	}

	private static RealtimeClient RoomClient(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0570: Expected Obj, but got I4
		//IL_05dd: Expected Obj, but got I
		//IL_05ef: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_058e: Expected Obj, but got I
		//IL_059e: Expected Obj, but got I
		//IL_036b: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_04f0: Expected Obj, but got I4
		//IL_0503: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I
		//IL_02ad: Expected Obj, but got I
		//IL_02b5: Expected I, but got Obj
		//IL_02e6: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+18]");
		RealtimeClient result;
		UnityEngine.Object obj15;
		if ((FieldInfo)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)runner != (UnityEngine.Object)null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v14+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v14+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v11+18]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v11+18]");
				if ((nint)0 != 0)
				{
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v20+2D0]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v144 @ X8_v20+2C8] (should have been resolved before IL gen)");
					object obj14 = default;
					if (obj14 == null)
					{
						goto IL_02f4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
					Type type = default;
					bool flag4 = (object)type == null;
					obj15 = runner;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3010]");
						object obj16 = 0;
						PropertyInfo property = type.GetProperty((string)obj16, (BindingFlags)20);
						bool flag5 = (object)property == null;
						result = (RealtimeClient)(object)property;
						if (!flag5)
						{
							object value = property.GetValue(obj14);
							if (value == null)
							{
								goto IL_02f4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
							Type type2 = default;
							bool flag6 = (object)type2 == null;
							obj13 = 0;
							obj15 = (UnityEngine.Object)obj14;
							if (flag6)
							{
								goto IL_0383;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3018]");
							object obj17 = 0;
							PropertyInfo property2 = type2.GetProperty((string)obj17, (BindingFlags)20);
							bool flag7 = (object)property2 == null;
							result = (RealtimeClient)(object)property2;
							if (!flag7)
							{
								object value2 = property2.GetValue(value);
								bool flag8 = value2 == null;
								result = (RealtimeClient)value2;
								if (!flag8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3008]");
									object obj18 = 0;
									nint num = (nint)value2;
									object obj19 = obj18;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v7 (Il2CppClass<System.Object>)+130]");
									nint num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v27+130]");
									bool flag9 = num2 < 0;
									object obj20 = !flag9;
									if (obj20 == null)
									{
										goto IL_02f4;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v7 (Il2CppClass<System.Object>)+B0]");
									nint num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v27+130]");
									object obj21 = num3 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X9_v9-8]");
									result = (RealtimeClient)((0 != (nint)obj19) ? null : value2);
								}
							}
						}
						goto IL_05c3;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
					object obj13 = 0;
					obj15 = null;
				}
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_0383;
			}
		}
		goto IL_02f4;
		IL_02f4:
		result = null;
		goto IL_05c3;
		IL_0383:
		NullReferenceException ex3 = new NullReferenceException();
		bool flag10 = (nint)obj15 != 1;
		NullReferenceException ex4 = ex3;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj23 = default;
			object obj22 = obj23;
			obj15 = (UnityEngine.Object)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj25 = default;
			object obj24 = obj25 & 1;
			if (obj24 != null)
			{
				object obj26 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				if (obj23 != null)
				{
					object obj27 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v299 @ X8_v17+188] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string text = default;
					string text2 = default;
					string message = text + text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v43+E4]");
					bool flag11 = (nint)0 == 0;
					object obj28 = !flag11;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogWarning(message);
					goto IL_02f4;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj29 = obj23;
				obj15 = (UnityEngine.Object)(101789696 + 1224);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				object obj13 = 0;
			}
			NullReferenceException ex5 = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			ex4 = ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		RealtimeClient result2 = default;
		return result2;
		IL_05c3:
		return result;
	}

	private void Finish(string what)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+A0]");
		object obj6 = 0;
		bool flag3 = what != (string)obj6;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v11+A0]");
		object obj9 = 0;
		obj9 = what;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		looking = false;
		if (flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3028]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj12 = 0;
			string message = (string)obj11 + what;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
		}
	}

	private void OnDestroy()
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I
		object obj = this + 56;
		if (obj != null)
		{
			bool isConnected = ((RealtimeClient)obj).IsConnected;
			bool flag = !isConnected;
			object obj2 = 0;
			if (!flag)
			{
				((RealtimeClient)obj).Disconnect();
				obj2 = 0;
			}
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4+80]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+80]");
				((ConnectionHandler)0).RemoveInstance();
			}
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	static GillaOnline()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I4
		//IL_004d: Expected VT, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_007b: Expected I4, but got Obj
		//IL_009d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3030]");
		object obj3 = 0;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = obj;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6+A0]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj11 = 0;
		_ = -70364449210369L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v2+E8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj13 = !flag;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3038]");
		object obj14 = 0;
		nint num = (nint)typeFromHandle;
		PropertyInfo[] properties = ((System.RuntimeType)typeFromHandle).GetProperties((BindingFlags)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v13+A0]");
		object obj16 = (nint)0 + (nint)24;
		obj16 = properties;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
