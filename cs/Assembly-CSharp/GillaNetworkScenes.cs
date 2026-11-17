using System;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaNetworkScenes : NetworkSceneManagerDefault
{
	private static int Refused__BackingField;

	public static int Refused
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0032: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EC8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			object obj3 = 0;
			return (int)obj3;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EC8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
			object obj3 = 0;
			obj3 = value;
		}
	}

	private static void Forget()
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v5+A0]");
		object obj3 = 0;
		obj3 = 0;
	}

	public override NetworkSceneAsyncOp LoadScene(SceneRef sceneRef, NetworkLoadSceneParameters parameters)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2ED0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj4 = 0;
		SceneRef sceneRef2 = default;
		string text = sceneRef2.ToString();
		string what = (string)obj + text + (string)obj2;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string caller = GillaSceneGuard.Caller();
		Refuse(what, (string)obj4, caller);
		return NetworkSceneAsyncOp.FromCompleted(sceneRef2);
	}

	public override NetworkSceneAsyncOp UnloadScene(SceneRef sceneRef)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj4 = 0;
		SceneRef sceneRef2 = default;
		string text = sceneRef2.ToString();
		string what = (string)obj + text + (string)obj2;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string caller = GillaSceneGuard.Caller();
		Refuse(what, (string)obj4, caller);
		return NetworkSceneAsyncOp.FromCompleted(sceneRef2);
	}

	public unsafe override bool OnSceneInfoChanged(NetworkSceneInfo sceneInfo, NetworkSceneInfoChangeSource changeSource)
	{
		//IL_04bf: Expected Ref, but got VT
		//IL_0032: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_04e9: Expected Ref, but got VT
		//IL_050a: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I4
		//IL_0383: Expected Obj, but got I
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I4
		//IL_046d: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		int sceneCount = ((NetworkSceneInfo*)sceneInfo)->SceneCount;
		if (changeSource == 0 || sceneCount < 1)
		{
			goto IL_0395;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		string text = (string)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text3;
		string text2;
		if ((UnityEngine.Object)base.Runner__BackingField != (UnityEngine.Object)null)
		{
			bool flag2 = (object)base.Runner__BackingField == null;
			text2 = null;
			text3 = null;
			if (flag2)
			{
				goto IL_03b1;
			}
			if (base.Runner__BackingField.IsRunning)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v37+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef playerRef = GillaNetGuard.Master(base.Runner__BackingField);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v41+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				if (playerRef != none)
				{
					PlayerRef localPlayer = base.Runner__BackingField.LocalPlayer;
					object obj11 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v47+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (playerRef != localPlayer)
					{
						string playerUserId = base.Runner__BackingField.GetPlayerUserId(playerRef);
						text = (string)((playerUserId != null) ? playerUserId : obj3);
					}
				}
			}
		}
		goto IL_04e0;
		IL_03b1:
		NullReferenceException ex = new NullReferenceException();
		bool flag6 = (nint)text3 != 1;
		NullReferenceException ex2 = ex;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj14 = default;
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj16 = default;
			object obj15 = obj16 & 1;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				goto IL_04e0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj17 = obj14;
			text3 = (string)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			text2 = null;
			NullReferenceException ex3 = default;
			ex2 = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_04e0:
		int sceneCount2 = ((NetworkSceneInfo*)sceneInfo)->SceneCount;
		int num = default;
		string text4 = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EE8]");
		object obj18 = 0;
		object obj19;
		if (changeSource == (NetworkSceneInfoChangeSource)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EF8]");
			obj19 = 0;
		}
		else
		{
			obj19 = obj3;
		}
		text2 = (string)obj19;
		string what = (string)obj18 + text4 + (string)obj19;
		if (text != null)
		{
			bool flag7 = text._stringLength < 0;
			bool flag8 = text._stringLength == 0;
			int num2 = text._stringLength ^ text._stringLength;
			int num3 = text._stringLength & num2;
			bool flag9 = num3 < 0;
			bool flag10 = flag7 == flag9;
			object obj20 = !flag8;
			object obj21 = flag10 & obj20;
			object obj22 = ~obj21;
			object caller;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EF0]");
				caller = 0;
			}
			else
			{
				caller = obj3;
			}
			Refuse(what, text, (string)caller);
			goto IL_0395;
		}
		NullReferenceException ex4 = new NullReferenceException();
		text3 = text4;
		goto IL_03b1;
		IL_0395:
		return true;
	}

	private static void Refuse(string what, string by, string caller)
	{
		//IL_0384: Expected Obj, but got I
		//IL_038c: Expected I, but got Obj
		//IL_039c: Expected Obj, but got I
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_001a: Expected I, but got Obj
		//IL_0030: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EC8]");
		string text = (string)0;
		nint num = (nint)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5 (Il2CppClass<System.String>)+A0]");
		object obj = 0;
		object obj2 = obj + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEB5F]");
		if ((nint)0 != 0)
		{
			obj = obj2;
		}
		else
		{
			nint num2 = (nint)text;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v35 (Il2CppClass<System.String>)+A0]");
			object obj3 = 0;
			obj3 = obj2;
		}
		string text2;
		string text3;
		string text4;
		if ((nint)obj2 >= 6)
		{
			object obj4 = obj2 * 1374389535;
			object obj5 = obj4 >> 37;
			object obj6 = obj5 * 100;
			bool flag = obj2 != obj6;
			IntPtr intPtr = default;
			text2 = (string)(nint)intPtr;
			text3 = caller;
			text4 = by;
			if (flag)
			{
				goto IL_0260;
			}
		}
		bool flag2 = by == null;
		string text5 = (string)109895680;
		string text7;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2ED8]");
			object obj7 = 0;
			text = (string)obj7;
			if (by._stringLength > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7268]");
				object obj8 = 0;
				string text6 = (string)obj8 + by;
				bool flag3 = caller == null;
				text7 = text6;
				text5 = text6;
				if (!flag3)
				{
					goto IL_014f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj9 = 0;
				text7 = (string)obj9;
				bool flag4 = caller == null;
				object obj10 = !flag4;
				text5 = (string)obj9;
				if (obj10 != null)
				{
					goto IL_014f;
				}
			}
		}
		throw new NullReferenceException();
		IL_014f:
		bool flag5 = caller._stringLength <= 0;
		text5 = text7;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7260]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
			object obj12 = 0;
			string text8 = (string)obj11 + caller + (string)obj12;
			text2 = text8;
			text5 = text7;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj13 = 0;
			text2 = (string)obj13;
		}
		string message = text + what + text5 + text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v16+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		text3 = text5;
		text4 = null;
		goto IL_0260;
		IL_0260:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71D0]");
		object kind = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7248]");
		object how = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v5+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBotReport.Tell((string)kind, what, (string)how, caller, by);
	}
}
