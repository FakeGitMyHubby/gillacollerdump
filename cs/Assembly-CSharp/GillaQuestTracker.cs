using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GillaQuestTracker : MonoBehaviour
{
	private Transform head;

	private Vector3 last;

	private float metres;

	private float lit;

	private int roundSeen = -1;

	private int raceSeen;

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0096: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4380]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction = default;
		unityAction._002Ector((object)null, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction2 = default;
		unityAction2._002Ector((object)null, (IntPtr)obj2);
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction2;
		Attach();
	}

	private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		Attach();
	}

	private static void Attach()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_0352: Expected Obj, but got I
		//IL_0374: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I4
		//IL_0392: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj15;
		if ((UnityEngine.Object)obj8 != null)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v35+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v39+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v39+A0]");
			object obj14 = 0;
			obj15 = (UnityEngine.Object)obj14;
		}
		else
		{
			object obj16 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F50]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v30+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
			UnityEngine.Object obj19 = default;
			obj15 = obj19;
		}
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = obj15 == null;
		bool flag9 = !flag8;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6198]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj24 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v14+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj26 = default;
			if (!(obj26 != null))
			{
				GameObject gameObject = ((Component)obj15).gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61A0]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			}
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003e: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(this, (IntPtr)obj2);
		KillCam.Died += action;
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003e: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(this, (IntPtr)obj2);
		KillCam.Died -= action;
	}

	private void OnDied()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v9+A0]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v11+C8]");
			if ((nint)0 != 0)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaQuests.Report((GillaQuests.Stat)10, 1);
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj5 = default;
		bool flag2 = obj5 != null;
		bool flag3 = !flag2;
		object obj6 = 0;
		Component component;
		if (!flag3)
		{
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v17+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (UnityEngine.Object)+20]");
			bool flag5 = (UnityEngine.Object)0 != null;
			bool flag6 = !flag5;
			obj6 = 0;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (UnityEngine.Object)+20]");
				component = (Component)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (UnityEngine.Object)+20]");
				bool flag7 = (nint)0 == 0;
				object obj9 = !flag7;
				obj6 = 0;
				if (obj9 == null)
				{
					throw new NullReferenceException();
				}
				goto IL_01d0;
			}
		}
		component = this;
		goto IL_01d0;
		IL_01d0:
		Transform transform = component.transform;
		object obj10 = this + 32;
		obj10 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Vector3 position = ((Transform)obj10).position;
		Vector3 vector = default;
		last = vector;
	}

	private void Update()
	{
		//IL_0944: Expected Obj, but got I
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected Obj, but got Unknown
		//IL_0983: Expected Obj, but got I4
		//IL_0032: Expected VT, but got F4
		//IL_0042: Expected Obj, but got I
		//IL_0070: Invalid comparison between Obj and F8
		//IL_09ae: Expected I4, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I4
		//IL_09cc: Expected Obj, but got I
		//IL_09ee: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		//IL_020e: Expected Obj, but got I4
		//IL_0a1b: Expected Obj, but got I
		//IL_023b: Expected I4, but got F4
		//IL_0245: Expected I4, but got F4
		//IL_01ad: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I4
		//IL_03bd: Expected Obj, but got I4
		//IL_02eb: Expected I4, but got F4
		//IL_02fb: Expected I4, but got F4
		//IL_066c: Expected Obj, but got I
		//IL_0696: Expected Obj, but got I4
		//IL_06e6: Expected Obj, but got I4
		//IL_03f9: Expected Obj, but got I4
		//IL_0446: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I4
		//IL_04c4: Expected Obj, but got I4
		//IL_050c: Expected Obj, but got I4
		//IL_07e8: Expected Obj, but got I4
		//IL_0557: Expected Obj, but got I
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected Obj, but got Unknown
		//IL_05ab: Expected I4, but got VT
		//IL_0869: Expected Obj, but got I
		//IL_05d6: Expected Obj, but got I
		//IL_060a: Expected Obj, but got I4
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected Obj, but got Unknown
		//IL_08c0: Expected Obj, but got I
		//IL_08f4: Expected Obj, but got I4
		float deltaTime = Time.deltaTime;
		Vector3 position = head.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj3 = default;
		object obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaQuestTracker)+30]");
		object obj4 = obj2 - 0;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		last = (Vector3)deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		object obj8 = obj4 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)3.0);
		UnityEngine.Object obj9 = null;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj10 = 0;
			object obj11 = obj7;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v50+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v93+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj19;
			if ((UnityEngine.Object)obj13 != null)
			{
				object obj15 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v53+A0]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v55+A9]");
				bool flag4 = (nint)0 == 0;
				object obj18 = !flag4;
				obj19 = 0;
				obj9 = null;
				if (obj18 != null)
				{
					goto IL_0991;
				}
			}
			float num = (float)obj4 + metres;
			metres = num;
			obj19 = 0;
			obj9 = null;
		}
		goto IL_0991;
		IL_0991:
		bool flag5 = (double)metres < 1.0;
		int num2 = (int)obj9;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
			object obj20 = 0;
			object obj21 = obj20;
			float num3 = metres - metres;
			metres = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v89+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaQuests.Report((GillaQuests.Stat)8, (int)metres);
			num2 = (int)metres;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C8]");
		object obj23 = 0;
		float num4 = lit;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v15+A0]");
		object obj25 = 0;
		if (obj25 != null)
		{
			num4 = (lit = deltaTime + num4);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj26 = 0;
		bool flag7 = (double)num4 < 1.0;
		float num5 = 1f;
		float num6 = num4;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
			object obj27 = 0;
			object obj28 = obj27;
			num6 = num4 - num4;
			lit = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v82+E4]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaQuests.Report((GillaQuests.Stat)6, (int)num4);
			num5 = num4;
			num2 = (int)num4;
		}
		object obj30 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v14+E4]");
		bool flag9 = (nint)0 == 0;
		object obj31 = !flag9;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeRound current = GillaModeRound.Current;
		object obj32 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v20+E4]");
		bool flag10 = (nint)0 == 0;
		object obj33 = !flag10;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = (UnityEngine.Object)current != (UnityEngine.Object)null;
		bool flag12 = !flag11;
		object obj34 = 0;
		int num7 = 0;
		if (!flag12)
		{
			bool live = current.Live;
			bool flag13 = !live;
			obj34 = 0;
			num7 = 0;
			if (!flag13)
			{
				byte phase = current.Phase;
				int num8 = phase & 0xFF;
				bool flag14 = num8 != 1;
				obj34 = 0;
				num7 = 0;
				if (!flag14)
				{
					int round = current.Round;
					bool flag15 = round == roundSeen;
					obj34 = 0;
					num7 = 0;
					if (!flag15)
					{
						object obj35 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X0_v62+E4]");
						bool flag16 = (nint)0 == 0;
						object obj36 = !flag16;
						if (obj36 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag17 = (UnityEngine.Object)((SimulationBehaviour)current)._runner != (UnityEngine.Object)null;
						bool flag18 = !flag17;
						obj34 = 0;
						num7 = 0;
						if (!flag18)
						{
							NetworkDictionary<PlayerRef, byte> players = current.Players;
							PlayerRef localPlayer = ((SimulationBehaviour)current)._runner.LocalPlayer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C0]");
							object obj37 = 0;
							obj34 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B65C");
							object obj39 = default;
							object obj38 = obj39 & 1;
							bool flag19 = obj38 == null;
							object obj40 = default;
							obj3 = obj40;
							float num9 = default;
							num5 = num9;
							float num10 = default;
							num6 = num10;
							num7 = (int)localPlayer;
							if (!flag19)
							{
								int round2 = current.Round;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
								object obj41 = 0;
								roundSeen = round2;
								object obj42 = obj41;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v74+E4]");
								bool flag20 = (nint)0 == 0;
								object obj43 = !flag20;
								if (obj43 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								GillaQuests.Report((GillaQuests.Stat)9, 1);
								obj3 = obj40;
								num5 = num9;
								num6 = num10;
								num7 = 1;
							}
						}
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj44 = 0;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v22+E4]");
		bool flag21 = (nint)0 == 0;
		object obj46 = !flag21;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashGame current2 = GillaSplashGame.Current;
		object obj47 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v25+E4]");
		bool flag22 = (nint)0 == 0;
		object obj48 = !flag22;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)current2 != (UnityEngine.Object)null) || !current2.Live)
		{
			return;
		}
		byte phase2 = current2.Phase;
		int num11 = phase2 & 0xFF;
		if (num11 != 2)
		{
			return;
		}
		int starts = current2.Starts;
		if (starts == raceSeen)
		{
			return;
		}
		object obj49 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v36+E4]");
		bool flag23 = (nint)0 == 0;
		object obj50 = !flag23;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)((SimulationBehaviour)current2)._runner != (UnityEngine.Object)null))
		{
			return;
		}
		NetworkDictionary<PlayerRef, byte> players2 = current2.Players;
		PlayerRef localPlayer2 = ((SimulationBehaviour)current2)._runner.LocalPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C0]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B65C");
		object obj53 = default;
		object obj52 = obj53 & 1;
		if (obj52 != null)
		{
			int starts2 = current2.Starts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
			object obj54 = 0;
			raceSeen = starts2;
			object obj55 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X0_v48+E4]");
			bool flag24 = (nint)0 == 0;
			object obj56 = !flag24;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaQuests.Report((GillaQuests.Stat)12, 1);
		}
	}

	private void OnApplicationPause(bool paused)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		if (paused)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaQuests.Flush();
		}
	}

	private void OnApplicationQuit()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaQuests.Flush();
	}
}
