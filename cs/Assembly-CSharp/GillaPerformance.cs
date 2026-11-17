using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using PlayFab;
using PlayFab.ClientModels;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GillaPerformance : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public string account;

		public Action<string, string, string> done;

		public Action<string> failed;

		internal void _003CReadFromPlayFab_003Eb__0(GetUserDataResult result)
		{
			//IL_02ba: Expected Obj, but got I
			//IL_02d3: Expected Obj, but got I
			//IL_01ca: Expected Obj, but got I
			//IL_01da: Expected Obj, but got I
			//IL_01ea: Expected Obj, but got I
			//IL_0216: Expected Obj, but got I4
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_004f: Expected Obj, but got I4
			//IL_00a7: Expected Obj, but got I4
			//IL_0280: Expected Obj, but got I
			//IL_0290: Expected Obj, but got I
			//IL_02a0: Expected Obj, but got I
			//IL_02f9: Expected Obj, but got I
			//IL_0188: Expected Obj, but got I
			//IL_01a3: Expected Obj, but got I
			//IL_00dc: Expected Obj, but got I
			IntPtr intPtr = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
				object obj = 0;
				bool flag = account == null;
				System.__Canon _Canon = (System.__Canon)(nint)intPtr;
				System.__Canon _Canon2 = (System.__Canon)(object)result;
				if (!flag)
				{
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59D0]");
					object key = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text = GillaModeration.ValueOf(result, (string)key);
					object obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v9+E4]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj5 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v9+A0]");
					object obj7 = 0;
					if (text == null)
					{
						goto IL_016e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5968]");
					object obj8 = 0;
					bool flag4 = text.StartsWith((string)obj8);
					bool flag5 = !flag4;
					_Canon = null;
					if (!flag5)
					{
						object obj9 = obj8;
						int stringLength = text._stringLength;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v15+10]");
						if ((nint)stringLength <= (nint)0)
						{
							goto IL_016e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v15+10]");
						string text2 = text.Substring(0);
						_Canon = (System.__Canon)(object)text2;
					}
					goto IL_0178;
				}
				goto IL_01b2;
				IL_01b2:
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59C8]");
				object key2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59D8]");
				object key3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59E0]");
				object key4 = 0;
				Action<string, string, string> action = done;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v5+E4]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text3 = GillaModeration.ValueOf(result, (string)key2);
				string text4 = GillaModeration.ValueOf(result, (string)key3);
				string text5 = GillaModeration.ValueOf(result, (string)key4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X22_v3 (System.Action`3<System.String, System.String, System.String>)+40]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X22_v3 (System.Action`3<System.String, System.String, System.String>)+28]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X22_v3 (System.Action`3<System.String, System.String, System.String>)+18]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v219 @ X5_v1 (should have been resolved before IL gen)");
				continue;
				IL_016e:
				_Canon = null;
				goto IL_0178;
				IL_0178:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A30]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v10+18]");
				((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)account, _Canon);
				_Canon2 = (System.__Canon)(object)account;
				goto IL_01b2;
			}
		}

		internal void _003CReadFromPlayFab_003Eb__1(PlayFabError error)
		{
			//IL_002c: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			//IL_004c: Expected Obj, but got I
			Action<string> action = failed;
			string text = error.GenerateErrorReport();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X19_v2 (System.Action`1<System.String>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X19_v2 (System.Action`1<System.String>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X19_v2 (System.Action`1<System.String>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v34 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private const float Foveation = default(float);

	private const float FarClip = default(float);

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I4
		//IL_0125: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isEditor)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4380]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A40]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A48]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction = default;
			unityAction._002Ector((object)null, (IntPtr)obj5);
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction2 = default;
			unityAction2._002Ector((object)null, (IntPtr)obj5);
			SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction2;
			Scene activeScene = SceneManager.GetActiveScene();
			Loaded(activeScene, (LoadSceneMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GameObject gameObject = default;
			gameObject._002Ector((string)obj8);
			gameObject.hideFlags = (HideFlags)61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v20+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A38]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		}
	}

	private unsafe static void Loaded(Scene scene, LoadSceneMode mode)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_046c: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_04e5: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I
		//IL_03ca: Expected Obj, but got I
		//IL_03f4: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I4
		//IL_048a: Expected Obj, but got I
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0295: Expected Obj, but got Ref
		//IL_02ce: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		GameObject gameObject = GameObject.Find((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = gameObject == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A60]");
		object obj6 = 0;
		int num = BakedLampsOff();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj9 = (UnityEngine.Object)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj10 = default;
		if (obj10 == null)
		{
			goto IL_0420;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v12+18]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v12+18]");
		bool flag5 = (nint)0 < (nint)1;
		object obj12 = 0;
		if (flag5)
		{
			goto IL_02d3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A68]");
		object obj13 = 0;
		object obj14 = 0;
		object obj15 = 0;
		object obj16 = 0;
		UnityEngine.Object obj17 = (UnityEngine.Object)obj6;
		object obj24 = default;
		while (true)
		{
			bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
			object obj18 = !flag6;
			if (obj18 != null)
			{
				break;
			}
			object obj19 = obj10 + obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v17+20]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v17+20]");
			if ((nint)0 != 0)
			{
				object obj21 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v36+E4]");
				bool flag7 = (nint)0 == 0;
				object obj22 = !flag7;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X25_v7+30]");
				bool flag8 = (UnityEngine.Object)0 != null;
				bool flag9 = !flag8;
				obj12 = 0;
				obj9 = null;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X25_v7+30]");
					if ((nint)0 == 0)
					{
						goto IL_0420;
					}
					obj12 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38126A8");
					object obj23 = obj24 & 1;
					bool flag10 = obj23 == null;
					obj9 = (UnityEngine.Object)(&obj14);
					if (!flag10)
					{
						if (obj14 == null)
						{
							goto IL_0420;
						}
						_ = 0;
						obj9 = (UnityEngine.Object)(&obj14);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v12+18]");
				obj11 = 0;
				obj15++;
				object obj25 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v12+18]");
				bool flag11 = (nint)obj25 < 0;
				obj16 = obj12;
				obj17 = obj9;
				if (flag11)
				{
					continue;
				}
				goto IL_02d3;
			}
			goto IL_0420;
		}
		goto IL_042e;
		IL_0420:
		NullReferenceException ex = new NullReferenceException();
		goto IL_042e;
		IL_042e:
		throw new IndexOutOfRangeException();
		IL_02d3:
		Camera main = Camera.main;
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v10+E4]");
		bool flag12 = (nint)0 == 0;
		object obj27 = !flag12;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (main != null)
		{
			if ((object)main == null)
			{
				goto IL_0420;
			}
			main.farClipPlane = 150f;
		}
		if ((object)gameObject != null)
		{
			Transform baseRoot = gameObject.transform;
			GillaAreas gillaAreas = GillaAreas.Make(baseRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v27+E4]");
			bool flag13 = (nint)0 == 0;
			object obj30 = !flag13;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaWarmUp gillaWarmUp = GillaWarmUp.Run();
			return;
		}
		goto IL_0420;
	}

	public static int BakedLampsOff()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01e9: Expected Obj, but got I
		//IL_020b: Expected Obj, but got I4
		//IL_01d1: Expected I4, but got Obj
		//IL_005b: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A70]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj5 = default;
		if (obj5 == null)
		{
			goto IL_01b5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
		int num;
		if ((nint)0 >= (nint)1)
		{
			object obj7 = 0;
			num = 0;
			object obj11 = default;
			object obj12 = default;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
				object obj8 = !flag2;
				if (obj8 != null)
				{
					break;
				}
				object obj9 = obj5 + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v9+20]");
				if ((nint)0 == 0)
				{
					goto IL_01b5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v9+20]");
				if (((Behaviour)0).enabled)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v9+20]");
					LightBakingOutput bakingOutput = ((Light)0).bakingOutput;
					object obj10 = obj11 & 1;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v9+20]");
						LightBakingOutput bakingOutput2 = ((Light)0).bakingOutput;
						if ((nint)obj12 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v9+20]");
							((Behaviour)0).enabled = false;
							num++;
							object obj13 = 0;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
				obj6 = 0;
				obj7++;
				object obj14 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
				if ((nint)obj14 < 0)
				{
					continue;
				}
				goto IL_025b;
			}
			goto IL_01c3;
		}
		num = 0;
		goto IL_025b;
		IL_025b:
		return num;
		IL_01b5:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01c3;
		IL_01c3:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
	}

	private IEnumerator Start()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		return (IEnumerator)obj2;
	}

	private unsafe static void Apply()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got I4
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Ref, but got Unknown
		//IL_02d4: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A88]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AB8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @37885AC");
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AA0]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A98]");
			obj3 = 0;
			Enumerator<, > enumerator = list.GetEnumerator();
			obj7 = obj;
			Enumerator<, > val = default;
			object obj8;
			object obj9;
			Enumerator<, > val2;
			if (!val.MoveNext())
			{
				obj8 = 0;
				obj9 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj10 = 0;
				object obj13 = default;
				while (true)
				{
					obj7 = obj3;
					((Enumerator<, >*)val2)->Dispose();
					bool flag2 = obj10 == null;
					object obj11 = !flag2;
					if (obj11 == null)
					{
						bool flag3 = obj8 == null;
						object obj12 = !flag3;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj12 == null)
						{
							return;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj7 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj8 = 1;
						obj10 = obj9;
						continue;
					}
					if ((nint)obj7 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj10 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj9 = obj13;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D76C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj8 = 0;
			obj9 = 0;
			val2 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}
}
