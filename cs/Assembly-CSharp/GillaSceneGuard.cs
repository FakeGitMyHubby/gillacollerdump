using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public sealed class GillaSceneGuard : SceneManagerAPI
{
	public const string LoadingScene = null;

	public const string LobbyScene = null;

	private static GillaSceneGuard guard;

	private static AsyncOperation lobbyLoad;

	private static bool lobbyAsking;

	private static bool takingOut;

	private static readonly HashSet<string> let;

	private static int arrived;

	private static int Refused__BackingField;

	private static string LastRefused__BackingField;

	public static int Refused
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+24]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
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

	public static string LastRefused
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
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

	public static bool On
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00ee: Expected Obj, but got I4
			//IL_0185: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			//IL_0066: Expected Obj, but got I4
			//IL_0126: Expected Obj, but got I4
			//IL_01ba: Expected Obj, but got I
			//IL_01dc: Expected Obj, but got I4
			//IL_0144: Expected Obj, but got I
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
			object obj4 = 0;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71B0]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj8 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj5;
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v10+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v2+8]");
				object obj14 = 0 - obj13;
				return obj14 == null;
			}
			return false;
		}
	}

	private static void Install()
	{
		//IL_0010: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I4
		//IL_039e: Expected Obj, but got I
		//IL_02f6: Expected Obj, but got I
		//IL_0318: Expected Obj, but got I4
		//IL_03bf: Expected Obj, but got I
		//IL_03f1: Expected Obj, but got I
		//IL_0413: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I
		//IL_034e: Expected Obj, but got I
		//IL_035e: Expected Obj, but got I
		//IL_0380: Expected Obj, but got I4
		//IL_0431: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I
		//IL_0451: Expected Obj, but got I
		//IL_0467: Expected Obj, but got I
		//IL_0491: Expected I, but got Obj
		//IL_00f3: Expected Obj, but got I4
		//IL_0136: Expected I, but got Obj
		//IL_015c: Expected I, but got Obj
		//IL_018b: Expected Obj, but got I4
		//IL_01ce: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaSceneGuard gillaSceneGuard = default;
		gillaSceneGuard._002Ector();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v5+A0]");
		object obj4 = 0;
		obj4 = gillaSceneGuard;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6+A0]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v7+A0]");
		object obj9 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47C0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+18]");
		((HashSet<System.__Canon>)0).Clear();
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v17+A0]");
		object obj12 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v17+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v17+A0]");
		object obj15 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71B0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v17+A0]");
		object obj18 = (nint)0 + (nint)40;
		obj18 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj19 = obj;
		object obj20 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v17+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v21+E4]");
		bool flag4 = (nint)0 == 0;
		object obj22 = !flag4;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj23 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4380]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v25+E4]");
		bool flag5 = (nint)0 == 0;
		object obj27 = !flag5;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71C0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v25+A0]");
		object obj31 = (nint)0 + (nint)8;
		obj31 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction = default;
		unityAction._002Ector((object)null, (IntPtr)obj25);
		object obj32 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v31+E4]");
		bool flag6 = (nint)0 == 0;
		object obj33 = !flag6;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction2 = default;
		unityAction2._002Ector((object)null, (IntPtr)obj25);
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(null, (IntPtr)obj29);
		object obj34 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v39+E4]");
		bool flag7 = (nint)0 == 0;
		object obj35 = !flag7;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.quitting -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action2 = default;
		action2._002Ector(null, (IntPtr)obj29);
		Application.quitting += action2;
	}

	private static void Remove()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I4
		//IL_0276: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_02a6: Expected Obj, but got I
		//IL_0131: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got I
		//IL_02fd: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I4
		//IL_0321: Expected Obj, but got I
		//IL_032a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4380]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
		object obj7 = 0;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71B0]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj8;
			}
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v15+A0]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v13+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v2+8]");
			if (0 == (nint)obj16)
			{
				object obj17 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v17+E4]");
				bool flag5 = (nint)0 == 0;
				object obj18 = !flag5;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj19 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v21+E4]");
				bool flag6 = (nint)0 == 0;
				object obj20 = !flag6;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj19 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v21+A0]");
				object obj21 = (nint)0 + (nint)8;
				obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction = default;
		unityAction._002Ector((object)null, (IntPtr)obj6);
		object obj22 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	public static AsyncOperation LoadLobby(string scene)
	{
		//IL_0010: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
		object obj5 = 0;
		object obj6 = obj3;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(scene);
		object obj8 = 0;
		AsyncOperation result = asyncOperation;
		object obj9 = 1;
		OutOfMemoryException ex = (OutOfMemoryException)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v12 (System.OutOfMemoryException)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ex = (OutOfMemoryException)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v12 (System.OutOfMemoryException)+A0]");
		object obj11 = 0;
		_ = 0;
		bool flag4 = obj8 == null;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			object obj13 = obj9 & 1;
			if (obj13 != null)
			{
				return result;
			}
		}
		else
		{
			ex = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DF40");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		AsyncOperation result2 = default;
		return result2;
	}

	public static void Keep()
	{
		//IL_0010: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I4
		//IL_0485: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I4
		//IL_04ba: Expected Obj, but got I
		//IL_04dc: Expected Obj, but got I4
		//IL_0371: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_03bf: Expected Obj, but got I4
		//IL_04fa: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_054c: Expected Obj, but got I
		//IL_056e: Expected Obj, but got I4
		//IL_03f7: Expected Obj, but got I4
		//IL_0467: Expected Obj, but got I4
		//IL_052f: Expected Obj, but got I
		//IL_0592: Expected Obj, but got I
		//IL_05b4: Expected Obj, but got I
		//IL_05c4: Expected Obj, but got I
		//IL_05e9: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I
		//IL_02d7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+A0]");
		object obj4 = 0;
		if (obj4 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71B0]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj5;
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v9+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v12+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X9_v2+8]");
		if (0 == (nint)obj13)
		{
			return;
		}
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj16 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v15+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v19+8]");
		string text;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v15+E4]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj20 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v50+E4]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj20 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v50+A0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			object obj24 = default;
			object obj23 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v249 @ X8_v47+2D8] (should have been resolved before IL gen)");
			string text2 = default;
			text = text2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71E0]");
			object obj25 = 0;
			text = (string)obj25;
		}
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v18+E4]");
		bool flag9 = (nint)0 == 0;
		object obj27 = !flag9;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj;
		}
		object obj28 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v18+A0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v23+E4]");
		bool flag10 = (nint)0 == 0;
		object obj30 = !flag10;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj31 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v22+E4]");
		bool flag11 = (nint)0 == 0;
		object obj32 = !flag11;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v22+A0]");
		object obj33 = (nint)0 + (nint)8;
		obj33 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71F8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71D8]");
		object obj35 = 0;
		string message = (string)obj34 + text + (string)obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj36 = 0;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v31+E4]");
		bool flag12 = (nint)0 == 0;
		object obj38 = !flag12;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Debug.LogWarning(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71E8]");
		object obj39 = 0;
		string caller = (string)obj39 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj40 = 0;
		object obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v36+E4]");
		bool flag13 = (nint)0 == 0;
		object obj42 = !flag13;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71D0]");
		object kind = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71C8]");
		object what = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71F0]");
		object how = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj43 = 0;
		GillaBotReport.Tell((string)kind, (string)what, (string)how, caller, (string)obj43);
	}

	protected override AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0340: Expected Obj, but got I4
		//IL_0042: Expected I4, but got VT
		//IL_0238: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I
		//IL_0414: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_02a5: Invalid comparison between VT and I4
		//IL_0393: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I
		//IL_0461: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_0214: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = default;
		string text = NameOf(sceneName, num);
		AsyncOperation result;
		if (Lets(text, (LoadSceneMode)parameters))
		{
			AsyncOperation asyncOperation = base.LoadSceneAsyncByNameOrIndex(sceneName, num, parameters, mustCompleteNextFrame);
			bool flag2 = asyncOperation == null;
			System.__Canon _Canon = (System.__Canon)(object)sceneName;
			if (!flag2)
			{
				if (text == null)
				{
					goto IL_0308;
				}
				bool flag3 = text._stringLength < 1;
				_Canon = (System.__Canon)(object)sceneName;
				if (!flag3)
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v34+E4]");
					bool flag4 = (nint)0 == 0;
					object obj5 = !flag4;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj4 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v34+A0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v24+18]");
					if ((nint)0 == 0)
					{
						goto IL_0308;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v24+18]");
					bool flag5 = ((HashSet<System.__Canon>)0).Add((System.__Canon)(object)text);
					_Canon = (System.__Canon)(object)text;
				}
			}
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v24+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v24+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+10]");
			bool flag7 = (nint)0 == 0;
			result = asyncOperation;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v24+E4]");
				bool flag8 = (nint)0 == 0;
				object obj11 = !flag8;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v19+A0]");
					obj10 = 0;
				}
				object obj13 = obj10 + 8;
				obj13 = asyncOperation;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				result = asyncOperation;
			}
		}
		else
		{
			bool flag9 = !mustCompleteNextFrame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7218]");
			object obj14 = 0;
			object obj15 = obj;
			object obj16 = !flag9;
			object obj17 = ~obj16;
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7208]");
				obj14 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v9+E4]");
			bool flag10 = (nint)0 == 0;
			object obj18 = !flag10;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text2 = Quoted(sceneName, num);
			object obj19;
			if (parameters == (LoadSceneParameters)(object)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7200]");
				obj19 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
				obj19 = 0;
			}
			string asked = (string)obj14 + text2 + (string)obj19;
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v9+E4]");
			bool flag11 = (nint)0 == 0;
			object obj21 = !flag11;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Refuse(asked);
			result = null;
		}
		return result;
		IL_0308:
		return (AsyncOperation)(object)new NullReferenceException();
	}

	protected unsafe override AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v10+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v6+11]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				ref bool reference = ref *(bool*)null;
				object obj9 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text = Quoted(sceneName, sceneBuildIndex);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7270]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
				object obj12 = 0;
				string asked = (string)obj11 + text + (string)obj12;
				Refuse(asked);
				return null;
			}
		}
		return base.UnloadSceneAsyncByNameOrIndex(sceneName, sceneBuildIndex, immediately, options, out outSuccess);
	}

	private static bool Lets(string name, LoadSceneMode mode)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I4
		//IL_03a7: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I
		//IL_02c8: Expected Obj, but got I
		//IL_0329: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying)
		{
			goto IL_02ff;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
		}
		bool flag4 = mode == 0;
		object obj8 = !flag4;
		bool result = false;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v8+10]");
			bool flag5 = (nint)0 == 0;
			result = false;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7230]");
				object obj10 = 0;
				if (name == (string)obj10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v16+E4]");
					bool flag6 = (nint)0 == 0;
					object obj13 = !flag6;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Scene activeScene = SceneManager.GetActiveScene();
					Scene scene = default;
					string name2 = scene.name;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7238]");
					object obj14 = 0;
					if (name2 == (string)obj14)
					{
						object obj15 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v24+E4]");
						bool flag7 = (nint)0 == 0;
						object obj16 = !flag7;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj15 = obj4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v24+A0]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v19+8]");
						AsyncOperation asyncOperation = (AsyncOperation)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v19+8]");
						if ((nint)0 == 0)
						{
							goto IL_02ff;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v24+E4]");
						bool flag8 = (nint)0 == 0;
						object obj18 = !flag8;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj19 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v22+A0]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v23+8]");
							asyncOperation = (AsyncOperation)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v23+8]");
							if ((nint)0 == 0)
							{
								NullReferenceException ex = new NullReferenceException();
								return (byte)(int)ex != 0;
							}
						}
						result = asyncOperation.isDone;
						goto IL_0392;
					}
				}
				result = false;
			}
		}
		goto IL_0392;
		IL_02ff:
		result = true;
		goto IL_0392;
		IL_0392:
		return result;
	}

	private static bool EditorAsked()
	{
		return false;
	}

	private static void Refuse(string asked)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_04f4: Expected Obj, but got I
		//IL_050a: Expected Obj, but got I
		//IL_0345: Expected Obj, but got I4
		//IL_051f: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I4
		//IL_053f: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I4
		//IL_056f: Expected Obj, but got I
		//IL_057f: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I4
		//IL_0415: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I
		//IL_03e5: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I
		//IL_05ce: Expected Obj, but got I8
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_061f: Expected Obj, but got I4
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_0647: Expected Obj, but got I4
		//IL_067a: Expected Obj, but got I
		//IL_068a: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I
		//IL_027c: Expected Obj, but got I4
		//IL_04d6: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_0485: Expected Obj, but got I4
		//IL_06cf: Expected Obj, but got I
		//IL_06df: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v10+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v7+24]");
		object obj7 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v10+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v10+A0]");
		object obj11 = (nint)0 + (nint)40;
		obj11 = asked;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string text = Caller();
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v23+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v23+A0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X9_v4+24]");
		string text2;
		if ((nint)0 >= (nint)6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v23+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v23+E4]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v23+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X9_v17+24]");
			object obj19 = 0 * 3264175145L;
			object obj20 = 85899344 + obj19;
			object obj21 = obj20 >> 2;
			object obj22 = obj20 << 30;
			object obj23 = obj21 | obj22;
			bool flag8 = (nint)obj23 < 42949672;
			object obj24 = !flag8;
			object obj25 = obj23 - 42949672;
			bool flag9 = obj25 == null;
			object obj26 = !flag9;
			object obj27 = obj24 & obj26;
			text2 = asked;
			if (obj27 != null)
			{
				goto IL_0222;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7258]");
		object obj28 = 0;
		string text4;
		string text5;
		if (text._stringLength > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7268]");
			object obj29 = 0;
			string text3 = (string)obj29 + text;
			obj12 = obj;
			text4 = text3;
			text5 = null;
			string text6 = text;
		}
		else
		{
			text4 = (string)obj15;
			string text6 = asked;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v23+E4]");
		bool flag10 = (nint)0 == 0;
		object obj30 = !flag10;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v28+E4]");
		bool flag11 = (nint)0 == 0;
		object obj32 = !flag11;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v28+A0]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v27+24]");
		string text9;
		if ((nint)0 > (nint)5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v28+E4]");
			bool flag12 = (nint)0 == 0;
			object obj35 = !flag12;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj36 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v38+E4]");
			bool flag13 = (nint)0 == 0;
			object obj37 = !flag13;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = default;
			string text7 = num.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7260]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7250]");
			object obj39 = 0;
			string text8 = (string)obj38 + text7 + (string)obj39;
			text9 = text8;
		}
		else
		{
			text9 = (string)obj15;
		}
		string message = (string)obj28 + asked + text4 + text9;
		object obj40 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v30+E4]");
		bool flag14 = (nint)0 == 0;
		object obj41 = !flag14;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Debug.LogWarning(message);
		text5 = text4;
		text2 = null;
		goto IL_0222;
		IL_0222:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj42 = 0;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71D0]");
		object kind = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7248]");
		object how = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v18+E4]");
		bool flag15 = (nint)0 == 0;
		object obj44 = !flag15;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBotReport.Tell((string)kind, asked, (string)how, text, (string)obj15);
	}

	public unsafe static string Caller()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0d48: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I4
		//IL_0068: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_0e49: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I
		//IL_0d67: Expected Obj, but got I
		//IL_0d89: Expected Obj, but got I4
		//IL_02e2: Expected Obj, but got I4
		//IL_0aaa: Expected Obj, but got I
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Expected Obj, but got Unknown
		//IL_0272: Expected I, but got Obj
		//IL_0282: Expected Obj, but got I
		//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Expected Obj, but got Unknown
		//IL_0312: Expected Obj, but got I
		//IL_0334: Expected Obj, but got I4
		//IL_035a: Expected VT, but got Obj
		//IL_0c8c: Expected Obj, but got I4
		//IL_0c94: Expected Obj, but got Ref
		//IL_038e: Expected Obj, but got I4
		//IL_03a7: Expected I4, but got Obj
		//IL_03c5: Expected Obj, but got I
		//IL_03e7: Expected Obj, but got I4
		//IL_040d: Expected VT, but got Obj
		//IL_0441: Expected Obj, but got I4
		//IL_045a: Expected I4, but got Obj
		//IL_0478: Expected Obj, but got I
		//IL_0488: Expected Obj, but got I
		//IL_04aa: Expected Obj, but got I4
		//IL_04d0: Expected VT, but got Obj
		//IL_0504: Expected Obj, but got I4
		//IL_051d: Expected I4, but got Obj
		//IL_053b: Expected Obj, but got I
		//IL_054b: Expected Obj, but got I
		//IL_056d: Expected Obj, but got I4
		//IL_0593: Expected VT, but got Obj
		//IL_05c7: Expected Obj, but got I4
		//IL_05e0: Expected I4, but got Obj
		//IL_0616: Expected I4, but got Obj
		//IL_062c: Expected I, but got Obj
		//IL_0659: Expected Obj, but got I
		//IL_06a3: Expected Obj, but got I
		//IL_06ce: Expected Obj, but got I4
		//IL_06e7: Expected I4, but got Obj
		//IL_06fd: Expected I, but got Obj
		//IL_0750: Expected I, but got Obj
		//IL_07ab: Expected Obj, but got I
		//IL_07b8: Expected Obj, but got I4
		//IL_07d3: Expected Obj, but got I4
		//IL_07ec: Expected I4, but got Obj
		//IL_0802: Expected I, but got Obj
		//IL_081f: Expected Obj, but got I
		//IL_0841: Expected Obj, but got I4
		//IL_0868: Expected Obj, but got I4
		//IL_0883: Expected Obj, but got I4
		//IL_09ea: Expected I4, but got Obj
		//IL_099b: Expected Obj, but got I
		//IL_08b9: Expected Obj, but got I4
		//IL_0df2: Expected I, but got Obj
		//IL_090b: Expected Obj, but got I4
		//IL_0920: Expected Obj, but got I4
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected Obj, but got Unknown
		//IL_0a83: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StackTrace stackTrace = default;
		stackTrace._002Ector(1, fNeedFileInfo: false);
		bool flag = stackTrace == null;
		object obj3 = 0;
		bool flag2 = false;
		int num = 1;
		if (flag)
		{
			goto IL_0b63;
		}
		nint num2 = (nint)stackTrace;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v22 (Il2CppClass<System.Diagnostics.StackTrace>)+1A0]");
		num = 0;
		((ReadOnlyDictionary<TKey, TValue>.KeyCollection)(object)stackTrace).System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002EClear();
		object obj4 = default;
		bool flag3 = obj4 == null;
		object obj5 = !flag3;
		object obj6 = obj4;
		char c;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7298]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj8 = default;
			bool flag4 = obj8 == null;
			num = 0;
			obj6 = obj8;
			obj3 = 0;
			flag2 = false;
			c = '\0';
			if (flag4)
			{
				goto IL_0ba3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X20_v18+18]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X20_v18+18]");
		bool flag5 = (nint)0 < (nint)1;
		obj3 = 0;
		bool flag6 = false;
		if (flag5)
		{
			goto IL_0af4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7280]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7278]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj12 = 0;
		object obj13 = 0;
		object obj14 = 0;
		object obj15 = 0;
		flag2 = false;
		int num3 = num;
		MethodBase methodBase = default;
		string text5 = default;
		while (true)
		{
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
			object obj16 = !flag7;
			if (obj16 == null)
			{
				object obj17 = obj6 + obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v31+20]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v31+20]");
				if ((nint)0 != 0)
				{
					object obj19 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v611 @ X8_v32+1A8] (should have been resolved before IL gen)");
					Type type;
					if (methodBase != null)
					{
						bool flag8 = (object)methodBase == null;
						flag2 = false;
						num3 = 0;
						if (flag8)
						{
							goto IL_0b45;
						}
						nint num4 = (nint)methodBase;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v59 (Il2CppClass<System.Reflection.MethodBase>)+1D0]");
						MethodBase methodBase2 = (MethodBase)0;
						Type reflectedType = ((Type)(object)methodBase).ReflectedType;
						type = reflectedType;
					}
					else
					{
						type = null;
						MethodBase methodBase2 = null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X29_v17+E8]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v64+E4]");
					bool flag9 = (nint)0 == 0;
					object obj21 = !flag9;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag10 = type == null;
					bool flag11 = !flag10;
					object obj22 = !flag11;
					flag2 = false;
					num = 0;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X29_v17+E8]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X0_v69+E4]");
						bool flag12 = (nint)0 == 0;
						object obj24 = !flag12;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj10);
						bool flag13 = type == typeFromHandle;
						bool flag14 = !flag13;
						object obj25 = !flag14;
						string text = (string)obj10;
						flag2 = false;
						num = (int)typeFromHandle;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X29_v17+E8]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X0_v75+E4]");
							bool flag15 = (nint)0 == 0;
							object obj27 = !flag15;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj11);
							bool flag16 = type == typeFromHandle2;
							bool flag17 = !flag16;
							object obj28 = !flag17;
							text = (string)obj11;
							flag2 = false;
							num = (int)typeFromHandle2;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X29_v17+E8]");
								object obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7288]");
								object obj30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X0_v81+E4]");
								bool flag18 = (nint)0 == 0;
								object obj31 = !flag18;
								if (obj31 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj30);
								bool flag19 = type == typeFromHandle3;
								bool flag20 = !flag19;
								object obj32 = !flag20;
								text = (string)obj30;
								flag2 = false;
								num = (int)typeFromHandle3;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X29_v17+E8]");
									object obj33 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7290]");
									object obj34 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X0_v87+E4]");
									bool flag21 = (nint)0 == 0;
									object obj35 = !flag21;
									if (obj35 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj34);
									bool flag22 = type == typeFromHandle4;
									bool flag23 = !flag22;
									object obj36 = !flag23;
									text = (string)obj34;
									flag2 = false;
									num = (int)typeFromHandle4;
									if (obj36 == null)
									{
										bool flag24 = (object)type == null;
										obj3 = obj15;
										flag2 = false;
										num = (int)typeFromHandle4;
										if (flag24)
										{
											break;
										}
										nint num5 = (nint)type;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X8_v41 (Il2CppClass<System.Type>)+2C0]");
										num = 0;
										Type genericTypeDefinition = ((System.RuntimeType)type).GetGenericTypeDefinition();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
										object obj37 = 0;
										string text2 = (string)(((object)genericTypeDefinition != null) ? genericTypeDefinition : obj37);
										bool flag25 = text2 == null;
										obj3 = obj15;
										flag2 = false;
										if (flag25)
										{
											goto IL_0b7f;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72A8]");
										object obj38 = 0;
										bool flag26 = text2.StartsWith((string)obj38);
										bool flag27 = !flag26;
										object obj39 = !flag27;
										text = (string)obj34;
										flag2 = false;
										num = (int)obj38;
										if (obj39 == null)
										{
											nint num6 = (nint)type;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v47 (Il2CppClass<System.Type>)+1C0]");
											c = '\0';
											bool flag28 = ((System.RuntimeType)type).IsArrayImpl();
											bool flag29 = (object)methodBase == null;
											obj3 = obj15;
											flag2 = false;
											if (flag29)
											{
												goto IL_0be9;
											}
											nint num7 = (nint)methodBase;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v48 (Il2CppClass<System.Reflection.MethodBase>)+1C0]");
											c = '\0';
											Type declaringType = ((Type)(object)methodBase).DeclaringType;
											bool flag30 = !flag28;
											obj3 = obj15;
											flag2 = false;
											if (flag30)
											{
												goto IL_0bdb;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72B0]");
											object obj40 = 0;
											bool flag31 = ((string)flag28).StartsWith((string)obj40);
											bool flag32 = !flag31;
											text = (string)flag28;
											string text3 = (string)(object)declaringType;
											flag2 = false;
											c = (char)(int)obj40;
											if (!flag32)
											{
												nint num8 = (nint)type;
												bool isByRef = type.IsByRef;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X29_v17+E8]");
												object obj41 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v115+E4]");
												bool flag33 = (nint)0 == 0;
												object obj42 = !flag33;
												if (obj42 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool flag34 = (Type)isByRef != null;
												bool flag35 = !flag34;
												text = (string)flag28;
												text3 = (string)(object)declaringType;
												flag2 = false;
												c = '\0';
												if (!flag35)
												{
													int num9 = ((string)flag28).IndexOf('>');
													bool flag36 = num9 < 2;
													text3 = (string)(object)declaringType;
													flag2 = false;
													if (!flag36)
													{
														int num10 = num9 - 1;
														string text4 = ((string)flag28).Substring(1, num10);
														text3 = text4;
														obj15 = 0;
														flag2 = (byte)num10 != 0;
													}
													nint num11 = (nint)type;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X8_v57 (Il2CppClass<System.Type>)+1D0]");
													c = '\0';
													bool isByRef2 = type.IsByRef;
													bool flag37 = !isByRef2;
													obj3 = obj15;
													if (flag37)
													{
														goto IL_0bf7;
													}
													bool value = ((bool*)(isByRef2 ? 1 : 0))->m_value;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v58 (System.Boolean)+1C0]");
													c = '\0';
													Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v985 @ X8_v58 (System.Boolean)+1B8] (should have been resolved before IL gen)");
													text = text5;
												}
											}
											bool flag38 = stringBuilder == null;
											obj3 = obj15;
											if (flag38)
											{
												goto IL_0bcd;
											}
											int length = stringBuilder.Length;
											if (length >= 1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72B8]");
												object value2 = 0;
												StringBuilder stringBuilder2 = stringBuilder.Append((string)value2);
											}
											StringBuilder stringBuilder3 = stringBuilder.Append(text);
											bool flag39 = stringBuilder3 == null;
											obj3 = obj15;
											flag2 = false;
											c = (char)(int)text;
											if (flag39)
											{
												goto IL_0bbf;
											}
											StringBuilder stringBuilder4 = stringBuilder3.Append('.');
											bool flag40 = stringBuilder4 == null;
											obj3 = obj15;
											flag2 = false;
											c = '.';
											if (flag40)
											{
												goto IL_0bb1;
											}
											StringBuilder stringBuilder5 = stringBuilder4.Append(text3);
											obj13++;
											bool flag41 = (nint)obj13 > 2;
											flag2 = false;
											num = (int)text3;
											flag6 = false;
											if (flag41)
											{
												goto IL_0b19;
											}
										}
									}
								}
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X20_v18+18]");
					obj9 = 0;
					obj14++;
					object obj43 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X20_v18+18]");
					bool flag42 = (nint)obj43 < 0;
					obj3 = obj15;
					flag6 = flag2;
					num3 = num;
					if (flag42)
					{
						continue;
					}
					goto IL_0af4;
				}
			}
			else
			{
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0b45;
			IL_0b45:
			NullReferenceException ex3 = new NullReferenceException();
			obj3 = obj15;
			num = num3;
			goto IL_0b63;
		}
		goto IL_0b8d;
		IL_0bb1:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0bbf;
		IL_0be9:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_0bf7;
		IL_0bf7:
		NullReferenceException ex6 = new NullReferenceException();
		bool flag43 = c != '\u0001';
		NullReferenceException ex7 = ex6;
		if (!flag43)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj45 = default;
			object obj44 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj47 = default;
			object obj46 = obj47 & 1;
			if (obj46 != null)
			{
				object obj48 = 0;
				object obj50 = default;
				object obj49 = (object)(&obj50);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				goto IL_0e57;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj51 = obj45;
			c = '㓈';
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			flag2 = false;
			NullReferenceException ex8 = default;
			ex7 = ex8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		string result = default;
		return result;
		IL_0bdb:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_0be9;
		IL_0bcd:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_0bdb;
		IL_0af4:
		bool flag44 = stringBuilder == null;
		flag2 = flag6;
		if (!flag44)
		{
			goto IL_0b19;
		}
		goto IL_0b71;
		IL_0e57:
		string result2 = default;
		return result2;
		IL_0b71:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_0b7f;
		IL_0b19:
		((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
		goto IL_0e57;
		IL_0b8d:
		NullReferenceException ex12 = new NullReferenceException();
		c = (char)num;
		goto IL_0ba3;
		IL_0ba3:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_0bb1;
		IL_0b7f:
		NullReferenceException ex14 = new NullReferenceException();
		goto IL_0b8d;
		IL_0b63:
		NullReferenceException ex15 = new NullReferenceException();
		goto IL_0b71;
		IL_0bbf:
		NullReferenceException ex16 = new NullReferenceException();
		goto IL_0bcd;
	}

	private unsafe static void Arrived(Scene scene, LoadSceneMode mode)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0930: Expected Obj, but got I4
		//IL_0ba2: Expected Obj, but got I
		//IL_0bb8: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_094e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_009b: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected Obj, but got Unknown
		//IL_0877: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0740: Expected Obj, but got I4
		//IL_088b: Expected I, but got Obj
		//IL_083a: Expected Obj, but got Ref
		//IL_0851: Expected Obj, but got Ref
		//IL_01a3: Expected Obj, but got I8
		//IL_0af9: Expected Obj, but got I
		//IL_0b19: Expected Obj, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_0207: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_077f: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_0298: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got Ref
		//IL_02c4: Expected Obj, but got I8
		//IL_02dc: Expected Obj, but got I4
		//IL_02fa: Expected Obj, but got I4
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_034a: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_038e: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got I4
		//IL_03cd: Expected Obj, but got I
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_0417: Expected Obj, but got I4
		//IL_042d: Expected Obj, but got I
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_045b: Expected Obj, but got I4
		//IL_0474: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected Obj, but got Unknown
		//IL_09c2: Expected Obj, but got I
		//IL_09ec: Expected Obj, but got I4
		//IL_0530: Expected Obj, but got I4
		//IL_056f: Expected Obj, but got I
		//IL_057f: Expected Obj, but got I
		//IL_058f: Expected Obj, but got I
		//IL_059f: Expected Obj, but got I
		//IL_05d4: Expected Obj, but got I
		//IL_05fe: Expected Obj, but got I
		//IL_0a4b: Expected Obj, but got I
		//IL_0a7d: Expected Obj, but got I4
		//IL_05e9: Expected Obj, but got I
		//IL_069f: Expected Obj, but got I4
		//IL_0a9b: Expected Obj, but got I
		//IL_0aab: Expected Obj, but got I
		//IL_0adb: Expected Obj, but got I4
		//IL_06ee: Expected Obj, but got I4
		//IL_070c: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6+20]");
		object obj5 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6+20]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v61+A0]");
			obj4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6+18]");
		HashSet<System.__Canon> hashSet = (HashSet<System.__Canon>)0;
		Scene scene2 = default;
		string name = scene2.name;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6+18]");
		bool flag3 = (nint)0 == 0;
		string text = null;
		OutOfMemoryException ex = default;
		LoadSceneMode loadSceneMode = default;
		HashSet<System.__Canon> hashSet3;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F8]");
			object obj8 = 0;
			nint num = (nint)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v6+18]");
			bool flag4 = ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)name);
			bool flag5 = !flag4;
			object obj9 = !flag5;
			if (obj9 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			HashSet<System.__Canon> hashSet2 = default;
			bool flag6 = hashSet2 == null;
			text = (string)6;
			if (!flag6)
			{
				bool flag7 = hashSet2._slots == null;
				text = (string)6;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7300]");
					object obj11 = 0;
					string text2 = (string)(hashSet2 + 32);
					text2 = (string)obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					string name2 = scene2.name;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X21_v6 (System.String)-8]");
					object obj12 = 0 & 0xFFFFFFFEL;
					bool flag8 = obj12 == null;
					text = null;
					if (!flag8)
					{
						text2 = (string)(hashSet2 + 40);
						text2 = name2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X21_v6 (System.String)-10]");
						bool flag9 = (nint)0 < (nint)2;
						object obj13 = !flag9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X21_v6 (System.String)-10]");
						object obj14 = -2;
						bool flag10 = obj14 == null;
						object obj15 = ~obj13;
						object obj16 = obj15 | flag10;
						text = name2;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72F0]");
							object obj17 = 0;
							text2 = (string)(hashSet2 + 48);
							text2 = (string)obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72C0]");
							object obj18 = 0;
							object obj19 = default;
							string text3 = ((Enum)(&obj19)).ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X21_v6 (System.String)-18]");
							object obj20 = 0 & 0xFFFFFFFCL;
							bool flag11 = obj20 == null;
							ex = (OutOfMemoryException)(-1);
							obj19 = obj18;
							loadSceneMode = mode;
							text = null;
							OutOfMemoryException ex2 = (OutOfMemoryException)(-1);
							if (!flag11)
							{
								text2 = (string)(hashSet2 + 56);
								text2 = text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X21_v6 (System.String)-20]");
								bool flag12 = (nint)0 < (nint)4;
								object obj21 = !flag12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X21_v6 (System.String)-20]");
								object obj22 = -4;
								bool flag13 = obj22 == null;
								object obj23 = ~obj21;
								object obj24 = obj23 | flag13;
								ex = (OutOfMemoryException)(-1);
								obj19 = obj18;
								loadSceneMode = mode;
								text = text3;
								ex2 = (OutOfMemoryException)(-1);
								if (obj24 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
									object obj25 = 0;
									text = (string)obj25;
									text2 = (string)(hashSet2 + 64);
									text2 = (string)obj25;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X21_v6 (System.String)-28]");
									bool flag14 = (nint)0 < (nint)5;
									object obj26 = !flag14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X21_v6 (System.String)-28]");
									object obj27 = -5;
									bool flag15 = obj27 == null;
									object obj28 = ~obj26;
									object obj29 = obj28 | flag15;
									ex = (OutOfMemoryException)(-1);
									obj19 = obj18;
									loadSceneMode = mode;
									ex2 = (OutOfMemoryException)(-1);
									if (obj29 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72E8]");
										object obj30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
										object obj31 = 0;
										if (mode != (LoadSceneMode)1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
											obj30 = 0;
										}
										object obj32 = hashSet2 + 72;
										obj32 = obj30;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										string message = string.Concat((string[])(object)hashSet2);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
										object obj33 = 0;
										object obj34 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v47+E4]");
										bool flag16 = (nint)0 == 0;
										object obj35 = !flag16;
										if (obj35 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										UnityEngine.Debug.LogWarning(message);
										string name3 = scene2.name;
										object obj36 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v48+E4]");
										bool flag17 = (nint)0 == 0;
										object obj37 = !flag17;
										if (obj37 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										string text4 = Cut(name3, 40);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72F8]");
										object obj38 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72D8]");
										object obj39 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7308]");
										object obj40 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71D0]");
										object obj41 = 0;
										if (mode != (LoadSceneMode)1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72D0]");
											obj40 = 0;
										}
										hashSet = (HashSet<System.__Canon>)obj41;
										object obj42;
										if (mode == (LoadSceneMode)1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72C8]");
											obj42 = 0;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72E0]");
											obj42 = 0;
										}
										string what = (string)obj39 + text4 + (string)obj38 + (string)obj40;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
										object obj43 = 0;
										text2 = (string)obj42;
										object obj44 = obj43;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v54+E4]");
										bool flag18 = (nint)0 == 0;
										object obj45 = !flag18;
										if (obj45 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										GillaBotReport.Tell((string)(object)hashSet, what, text2, (string)obj31, (string)obj31);
										if (mode == (LoadSceneMode)1 && scene2.IsValid())
										{
											object obj46 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v81+E4]");
											bool flag19 = (nint)0 == 0;
											object obj47 = !flag19;
											if (obj47 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj46 = obj;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
											object obj48 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v81+A0]");
											ex2 = (OutOfMemoryException)0;
											object obj49 = obj48;
											_ = 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v82+E4]");
											bool flag20 = (nint)0 == 0;
											object obj50 = !flag20;
											if (obj50 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											AsyncOperation asyncOperation = SceneManager.UnloadSceneAsync(scene2);
											hashSet3 = null;
											obj5 = 1;
											ex = null;
											obj19 = obj18;
											loadSceneMode = (LoadSceneMode)0;
											num = (nint)text2;
											text = null;
											goto IL_0716;
										}
										return;
									}
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
			}
		}
		NullReferenceException ex4 = new NullReferenceException();
		hashSet3 = null;
		goto IL_07b7;
		IL_0716:
		object obj51 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v38+E4]");
		bool flag21 = (nint)0 == 0;
		object obj52 = !flag21;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj51 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v38+A0]");
		object obj53 = 0;
		_ = 0;
		bool flag22 = ex == null;
		object obj54 = !flag22;
		if (obj54 != null)
		{
			goto IL_07b7;
		}
		bool flag23 = loadSceneMode == 0;
		object obj55 = !flag23;
		OutOfMemoryException ex5 = ex;
		if (obj55 == null)
		{
			return;
		}
		goto IL_07c5;
		IL_07c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		bool flag24 = (nint)text != 2;
		object obj57 = default;
		object obj56 = obj57;
		if (!flag24)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj59 = default;
			object obj58 = obj59;
			text = (string)obj58;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj61 = default;
			object obj60 = obj61 & 1;
			if (obj60 != null)
			{
				object obj62 = default;
				OutOfMemoryException ex6 = (OutOfMemoryException)(&obj62);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				OutOfMemoryException ex2 = (OutOfMemoryException)(&obj62);
				goto IL_0716;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj63 = obj59;
			text = (string)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			nint num = unchecked((nint)null);
			object obj64 = default;
			obj56 = obj64;
		}
		if ((nint)text == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			loadSceneMode = (LoadSceneMode)1;
		}
		else
		{
			if ((nint)text != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DF98");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj65 = default;
			ex = (OutOfMemoryException)obj65;
		}
		goto IL_0716;
		IL_07b7:
		ex5 = new OutOfMemoryException();
		goto IL_07c5;
	}

	private static string NameOf(string sceneName, int buildIndex)
	{
		//IL_025c: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_0017: Expected I4, but got I8
		//IL_0031: Expected Obj, but got I4
		//IL_014e: Expected I4, but got I8
		//IL_0168: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		bool flag = string.IsNullOrEmpty(sceneName);
		bool flag2 = !flag;
		string text = sceneName;
		if (!flag2)
		{
			int num = (int)(buildIndex & 0x80000000L);
			bool flag3 = num == 0;
			object obj2 = !flag3;
			if (obj2 == null)
			{
				string scenePathByBuildIndex = SceneUtility.GetScenePathByBuildIndex(buildIndex);
				text = scenePathByBuildIndex;
			}
			else
			{
				text = (string)obj;
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			text = (string)obj;
			goto IL_022b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7220]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		char[] array = default;
		if (array == null)
		{
			goto IL_0230;
		}
		if (array.Length != 0)
		{
			bool flag4 = array.Length == 1;
			array[0] = '/';
			if (!flag4)
			{
				array[1] = '\\';
				if (text != null)
				{
					int num2 = text.LastIndexOfAny(array);
					int num3 = (int)(num2 & 0x80000000L);
					bool flag5 = num3 == 0;
					object obj4 = !flag5;
					if (obj4 == null)
					{
						int startIndex = num2 + 1;
						string text2 = text.Substring(startIndex);
						bool flag6 = text2 == null;
						text = text2;
						if (flag6)
						{
							goto IL_0230;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7228]");
					object value = 0;
					if (text.EndsWith((string)value, (StringComparison)5))
					{
						int length = text._stringLength - 6;
						return text.Substring(0, length);
					}
					goto IL_022b;
				}
				goto IL_0230;
			}
		}
		goto IL_023e;
		IL_022b:
		return text;
		IL_0230:
		NullReferenceException ex = new NullReferenceException();
		goto IL_023e;
		IL_023e:
		return (string)(object)new IndexOutOfRangeException();
	}

	private static string Quoted(string sceneName, int buildIndex)
	{
		//IL_004d: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		if (string.IsNullOrEmpty(sceneName))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4208]");
			object obj = 0;
			int num = default;
			string text = num.ToString();
			return (string)obj + text;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7240]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = Cut(sceneName, 40);
		return (string)obj4 + text2 + (string)obj4;
	}

	private static string Cut(string s, int most)
	{
		//IL_0015: Expected Obj, but got I
		string result;
		if (string.IsNullOrEmpty(s))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			result = (string)obj;
		}
		else
		{
			if (s == null)
			{
				return (string)(object)new NullReferenceException();
			}
			bool flag = s._stringLength <= most;
			result = s;
			if (!flag)
			{
				return s.Substring(0, most);
			}
		}
		return result;
	}

	public GillaSceneGuard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base._002Ector();
	}

	static GillaSceneGuard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+A0]");
		object obj5 = (nint)0 + (nint)24;
		obj5 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+A0]");
		object obj7 = (nint)0 + (nint)40;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
