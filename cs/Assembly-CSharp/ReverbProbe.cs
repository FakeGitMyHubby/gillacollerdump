using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ReverbProbe : MonoBehaviour
{
	[Serializable]
	public class SurfaceSet
	{
		public SurfaceKind kind;

		public AudioClip[] clips;

		public float volume;

		public SurfaceSet()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj2 = this + 24;
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			volume = 1f;
			base._002Ector();
		}
	}

	public float range;

	public float blend;

	private AudioReverbZone zone;

	private float enclosed;

	private float size = 5f;

	private float nextProbe;

	private static readonly Vector3[] Dirs;

	private const int Solid = default(int);

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00ed: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4380]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4388]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4398]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction = default;
		unityAction._002Ector((object)null, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction2 = default;
		unityAction2._002Ector((object)null, (IntPtr)obj2);
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction2;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AddToListener();
	}

	private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4398]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AddToListener();
	}

	private static void AddToListener()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
		UnityEngine.Object obj5 = default;
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj9 = default;
			if (obj9 == null)
			{
				GameObject gameObject = ((Component)obj5).gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43A8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			}
		}
	}

	private static Vector3[] MakeDirs()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05be: Expected Obj, but got I
		//IL_05e2: Expected Obj, but got I
		//IL_05eb: Expected Obj, but got I4
		//IL_05ff: Expected VT, but got I4
		//IL_05ff: Expected VT, but got I4
		//IL_0026: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I
		//IL_0134: Expected VT, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0162: Expected VT, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00e6: Expected Obj, but got I
		//IL_0179: Expected VT, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_066c: Expected VT, but got I4
		//IL_066c: Expected VT, but got I4
		//IL_0680: Expected Obj, but got I
		//IL_069e: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_024d: Expected VT, but got I
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_027f: Expected VT, but got I8
		//IL_01d4: Expected Obj, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I
		//IL_0739: Expected Obj, but got I
		//IL_0749: Expected Obj, but got I
		//IL_075f: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I
		//IL_035b: Expected Obj, but got I
		//IL_0370: Expected VT, but got I
		//IL_02df: Expected Obj, but got I
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_030a: Expected Obj, but got I
		//IL_07a9: Expected Obj, but got I
		//IL_07b9: Expected Obj, but got I
		//IL_07cf: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I4
		//IL_0433: Expected Obj, but got I
		//IL_0443: Expected Obj, but got I
		//IL_0458: Expected VT, but got I
		//IL_046a: Expected VT, but got I8
		//IL_0473: Expected Obj, but got I4
		//IL_03c7: Expected Obj, but got I
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03f2: Expected Obj, but got I
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected Obj, but got Unknown
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_0808: Expected VT, but got I4
		//IL_0808: Expected VT, but got I4
		//IL_081c: Expected Obj, but got I
		//IL_083a: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I
		//IL_0539: Expected Obj, but got I
		//IL_054e: Expected VT, but got I
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_0580: Expected VT, but got I8
		//IL_04c5: Expected Obj, but got I
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
		//IL_04f0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj3 = 0;
		object obj4 = 0;
		Vector3 euler = default;
		while (true)
		{
			double num = (double)obj4 * 30.0;
			double num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num3 = num2 * 0.0;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			Vector3 vector = (Quaternion)0 * (Vector3)0;
			if (list == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			object obj5 = 0;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
			object obj7 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			if ((nint)0 == 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X9_v3+18]");
			bool flag = num4 < 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj9 = (nint)0 * (nint)12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj10 = 0 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj11 = (nint)0 + (nint)1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v9+20]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v48+A8]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v49+70]");
				list.AddWithResize((Vector3)0);
			}
			obj4++;
			bool flag2 = (nint)obj4 != 12;
			euler = (Vector3)0;
			if (flag2)
			{
				continue;
			}
			euler = (Vector3)0;
			object obj14 = 0;
			while (true)
			{
				double num5 = (double)obj14 * 30.0;
				double num6 = num5 + 15.0;
				double num7 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
				double num8 = num7 * 0.0;
				Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref euler);
				Vector3 vector2 = (Quaternion)0 * (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj15 = 0;
				object obj16 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj17 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v15+18]");
				bool flag3 = num9 < 0;
				object obj18 = !flag3;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj19 = (nint)0 * (nint)12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj20 = 0 + obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj21 = (nint)0 + (nint)1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X9_v6+20]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v45+A8]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v46+70]");
					list.AddWithResize((Vector3)0);
				}
				obj14++;
				bool flag4 = (nint)obj14 != 12;
				euler = (Vector3)3206308266L;
				if (flag4)
				{
					continue;
				}
				object obj24 = obj3;
				object obj25 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v19+A0]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj28 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v20+18]");
				bool flag5 = num10 < 0;
				object obj29 = !flag5;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj30 = (nint)0 * (nint)12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj31 = 0 + obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj32 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X9_v8+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X9_v8+1C]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X9_v8+20]");
					_ = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X10_v10+20]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v41+A8]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v42+70]");
					list.AddWithResize((Vector3)0);
				}
				object obj35 = obj3;
				object obj36 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v24+A0]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj39 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v25+18]");
				bool flag6 = num11 < 0;
				object obj40 = !flag6;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj41 = (nint)0 * (nint)12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj42 = 0 + obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj43 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X9_v12+24]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X9_v12+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X9_v12+2C]");
					_ = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X10_v12+20]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v37+A8]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v38+70]");
					list.AddWithResize((Vector3)0);
				}
				euler = (Vector3)3206308266L;
				object obj46 = 0;
				while (true)
				{
					object obj47 = obj46 * 1119092736;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
					object obj48 = obj47 * 0;
					Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(ref euler);
					Vector3 vector3 = (Quaternion)0 * (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj49 = 0;
					object obj50 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj51 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v32+18]");
					bool flag7 = num12 < 0;
					object obj52 = !flag7;
					if (obj52 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						object obj53 = (nint)0 * (nint)12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						object obj54 = 0 + obj53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						object obj55 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X9_v12+28]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X9_v12+2C]");
						_ = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X9_v17+20]");
						object obj56 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v34+A8]");
						object obj57 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v35+70]");
						list.AddWithResize((Vector3)0);
					}
					obj46++;
					bool flag8 = (nint)obj46 != 4;
					euler = (Vector3)3213964830L;
					if (!flag8)
					{
						return list.ToArray();
					}
				}
				break;
			}
			break;
		}
		return (Vector3[])(object)new NullReferenceException();
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0108: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj2);
		Transform transform = gameObject.transform;
		Transform parent = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43E0]");
		object obj3 = 0;
		transform.SetParent(parent, worldPositionStays: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		object obj4 = this + 40;
		object obj5 = default;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		((AudioReverbZone)obj4).minDistance = 500f;
		((AudioReverbZone)obj4).maxDistance = 500f;
		((AudioReverbZone)obj4).reverbPreset = (AudioReverbPreset)27;
		((AudioReverbZone)obj4).diffusion = 100f;
		((AudioReverbZone)obj4).density = 100f;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADF8]");
		((AudioReverbZone)obj6).HFReference = 0f;
		((AudioReverbZone)obj4).LFReference = 250f;
	}

	private unsafe void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1003: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_1034: Expected Obj, but got F4
		//IL_106d: Invalid comparison between F8 and I4
		//IL_107c: Expected F8, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I4
		//IL_109a: Expected Obj, but got I
		//IL_03e2: Invalid comparison between F8 and I4
		//IL_03f1: Expected F8, but got I4
		//IL_11cb: Expected Obj, but got I8
		//IL_167d: Expected Obj, but got I
		//IL_16a7: Expected Obj, but got I4
		//IL_02f5: Expected F4, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_045f: Invalid comparison between F8 and I4
		//IL_118c: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I8
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_018c: Expected F4, but got I4
		//IL_01a7: Expected Obj, but got I4
		//IL_1648: Expected Obj, but got I
		//IL_162a: Expected Obj, but got I4
		//IL_1247: Expected I4, but got F8
		//IL_1206: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Expected Obj, but got Unknown
		//IL_1225: Expected Obj, but got I4
		//IL_05d9: Expected Obj, but got I
		//IL_0603: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I4
		//IL_0629: Invalid comparison between F8 and I4
		//IL_068e: Expected F8, but got I4
		//IL_024b: Expected VT, but got I8
		//IL_024b: Expected VT, but got Ref
		//IL_16df: Expected Obj, but got I4
		//IL_10de: Expected Obj, but got I
		//IL_10e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ec: Expected Obj, but got Unknown
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fa: Expected Obj, but got Unknown
		//IL_113b: Expected Obj, but got I
		//IL_114b: Expected Obj, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_06fc: Invalid comparison between F8 and I4
		//IL_02c1: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I8
		//IL_12f1: Expected I4, but got F8
		//IL_12b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b5: Expected Obj, but got Unknown
		//IL_12cf: Expected Obj, but got I4
		//IL_07ff: Invalid comparison between F8 and I4
		//IL_0871: Expected F8, but got I4
		//IL_08d5: Invalid comparison between F8 and I4
		//IL_0947: Expected F8, but got I4
		//IL_09ab: Invalid comparison between F8 and I4
		//IL_0a1d: Expected F8, but got I4
		//IL_1717: Expected Obj, but got I4
		//IL_0a8b: Invalid comparison between F8 and I4
		//IL_1451: Expected I4, but got F8
		//IL_1410: Unknown result type (might be due to invalid IL or missing references)
		//IL_1415: Expected Obj, but got Unknown
		//IL_142f: Expected Obj, but got I4
		//IL_0b8e: Invalid comparison between F8 and I4
		//IL_0c00: Expected F8, but got I4
		//IL_0c64: Invalid comparison between F8 and I4
		//IL_0ccc: Expected F8, but got I4
		//IL_174f: Expected Obj, but got I4
		//IL_0d3a: Invalid comparison between F8 and I4
		//IL_1556: Expected I4, but got F8
		//IL_1515: Unknown result type (might be due to invalid IL or missing references)
		//IL_151a: Expected Obj, but got Unknown
		//IL_1534: Expected Obj, but got I4
		//IL_0e3d: Invalid comparison between F8 and I4
		//IL_0eaf: Expected F8, but got I4
		//IL_0f13: Invalid comparison between F8 and I4
		//IL_0f77: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = zone == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		float time = Time.time;
		float num = nextProbe;
		bool flag4 = time < nextProbe;
		ref RaycastHit reference = ref *(RaycastHit*)null;
		UnityEngine.Object obj5 = null;
		if (flag4)
		{
			goto IL_1011;
		}
		float time2 = Time.time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4398]");
		object obj6 = 0;
		float num2 = time2 + 0.25f;
		object obj7 = obj6;
		nextProbe = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v78+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v78+A0]");
		object obj9 = 0;
		object obj10 = obj9;
		if (obj9 == null)
		{
			goto IL_0fc4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X22_v7+18]");
		object obj13;
		float num3;
		object obj15;
		double num4;
		int num6;
		float num7;
		object obj21;
		object obj22;
		object obj23;
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X22_v7+18]");
			object obj12 = 0 & 0xFFFFFFFFL;
			obj13 = obj9 + 40;
			object obj14 = 0;
			num3 = 0f;
			num4 = 0.25;
			ref RaycastHit reference2 = ref *(RaycastHit*)null;
			obj15 = 0;
			object obj19 = default;
			QueryTriggerInteraction queryTriggerInteraction = default;
			float num5 = default;
			while (true)
			{
				bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
				object obj16 = !flag6;
				if (obj16 != null)
				{
					break;
				}
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					object obj17 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X0_v88+E4]");
					bool flag7 = (nint)0 == 0;
					object obj18 = !flag7;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (Physics.Raycast((Vector3)(&obj19), (Vector3)4294961403L, out *(RaycastHit*)1, num2, 0, queryTriggerInteraction))
					{
						obj15++;
						num2 = num5;
					}
					else
					{
						num2 = range;
					}
					num3 += num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X22_v7+18]");
					obj12 = 0;
					obj14++;
					obj13 += 12;
					object obj20 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X22_v7+18]");
					bool flag8 = (nint)obj20 < 0;
					num6 = 0;
					num7 = range;
					obj21 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X25_v8-4]");
					obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X25_v8-8]");
					obj23 = 0;
					reference2 = ref *(RaycastHit*)1;
					if (flag8)
					{
						continue;
					}
					goto IL_0296;
				}
				goto IL_0fc4;
			}
			goto IL_0fd2;
		}
		num3 = 0f;
		num4 = 0.25;
		reference = ref *(RaycastHit*)null;
		obj5 = null;
		obj15 = 0;
		goto IL_1162;
		IL_0fc4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0fd2;
		IL_1547:
		double num8;
		zone.reverb = (int)num8;
		double num9;
		double num11;
		double num14;
		double num18;
		if ((object)zone != null)
		{
			float reverbDelay = zone.reverbDelay;
			bool flag9 = num9 < 0.0;
			double num10 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			double num12 = num10 * 0.0;
			double num13 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEAC]");
			double num15 = num13 * 0.0;
			double num16 = num12 + num15;
			double num17 = num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8CC]");
			double num19 = num17 * 0.0;
			double num20 = num16 + num19;
			double num21 = 0.0;
			if (!flag9)
			{
				bool flag10 = !(num9 > 1.0);
				num21 = num9;
				if (!flag10)
				{
					num21 = 1.0;
				}
			}
			double num22 = num20 - (double)reverbDelay;
			double num23 = num22 * num21;
			float reverbDelay2 = reverbDelay + (float)num23;
			zone.reverbDelay = reverbDelay2;
			if ((object)zone != null)
			{
				float lFReference = zone.LFReference;
				bool flag11 = num9 < 0.0;
				double num24 = num11 * 1132068864.0;
				double num25 = num14 * 1132068864.0;
				double num26 = num24 + num25;
				double num27 = num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9A0]");
				double num28 = num27 * 0.0;
				double num29 = num26 + num28;
				double num30 = 0.0;
				if (!flag11)
				{
					bool flag12 = !(num9 > 1.0);
					num30 = num9;
					if (!flag12)
					{
						num30 = 1.0;
					}
				}
				double num31 = num29 - (double)lFReference;
				double num32 = num31 * num30;
				float lFReference2 = lFReference + (float)num32;
				zone.LFReference = lFReference2;
				return;
			}
		}
		goto IL_0fc4;
		IL_0fd2:
		throw new IndexOutOfRangeException();
		IL_12e2:
		double num33;
		zone.roomHF = (int)num33;
		object obj25;
		double num68;
		double num69;
		double num70 = default;
		if ((object)zone != null)
		{
			float decayTime = zone.decayTime;
			bool flag13 = num9 < 0.0;
			double num34 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC3C]");
			double num35 = num34 * 0.0;
			double num36 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8C8]");
			double num37 = num36 * 0.0;
			double num38 = num35 + num37;
			double num39 = num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF10]");
			double num40 = num39 * 0.0;
			double num41 = num38 + num40;
			double num42 = 0.0;
			if (!flag13)
			{
				bool flag14 = !(num9 > 1.0);
				num42 = num9;
				if (!flag14)
				{
					num42 = 1.0;
				}
			}
			double num43 = num41 - (double)decayTime;
			double num44 = num43 * num42;
			float decayTime2 = decayTime + (float)num44;
			zone.decayTime = decayTime2;
			if ((object)zone != null)
			{
				float decayHFRatio = zone.decayHFRatio;
				bool flag15 = num9 < 0.0;
				double num45 = num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF0]");
				double num46 = num45 * 0.0;
				double num47 = num14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
				double num48 = num47 * 0.0;
				double num49 = num46 + num48;
				double num50 = num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADD0]");
				double num51 = num50 * 0.0;
				double num52 = num49 + num51;
				double num53 = 0.0;
				if (!flag15)
				{
					bool flag16 = !(num9 > 1.0);
					num53 = num9;
					if (!flag16)
					{
						num53 = 1.0;
					}
				}
				double num54 = num52 - (double)decayHFRatio;
				double num55 = num54 * num53;
				float decayHFRatio2 = decayHFRatio + (float)num55;
				zone.decayHFRatio = decayHFRatio2;
				if ((object)zone != null)
				{
					int reflections = zone.reflections;
					bool flag17 = num9 < 0.0;
					double num56 = num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB1C]");
					double num57 = num56 * 0.0;
					double num58 = num14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB5C]");
					double num59 = num58 * 0.0;
					double num60 = num18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC7C]");
					double num61 = num60 * 0.0;
					double num62 = num57 + num59;
					double num63 = num62 + num61;
					double num64 = 0.0;
					if (!flag17)
					{
						bool flag18 = !(num9 > 1.0);
						num64 = num9;
						if (!flag18)
						{
							num64 = 1.0;
						}
					}
					double num65 = num63 - (double)reflections;
					double num66 = num65 * num64;
					double num67 = num66 + (double)reflections;
					object obj24 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ X0_v35+E4]");
					bool flag19 = (nint)0 == 0;
					object obj26 = !flag19;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					if (num67 < 0.0)
					{
						if (num67 == -0.5)
						{
							num68 = -1.0;
							num69 = num70;
							goto IL_13f8;
						}
						num69 = num67 + -0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					}
					else
					{
						if (num67 == 0.5)
						{
							num68 = 1.0;
							num69 = num70;
							goto IL_13f8;
						}
						num69 = num67 + 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					}
					goto IL_1442;
				}
			}
		}
		goto IL_0fc4;
		IL_1162:
		object obj27 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v81+E4]");
		bool flag20 = (nint)0 == 0;
		object obj28 = !flag20;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v81+A0]");
		object obj29 = 0;
		object obj30 = obj29;
		if (obj29 == null)
		{
			goto IL_0fc4;
		}
		float num71 = (float)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v61+18]");
		num = num71 / 0f;
		float num72 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v61+18]");
		float num73 = num72 / 0f;
		enclosed = num;
		size = num73;
		goto IL_1011;
		IL_0296:
		num6 = 0;
		num7 = range;
		obj21 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X25_v8-4]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X25_v8-8]");
		obj23 = 0;
		reference = ref *(RaycastHit*)1;
		obj5 = (UnityEngine.Object)4294961403L;
		goto IL_1162;
		IL_11ee:
		double num75;
		double num76;
		double num74 = num75 + num76;
		object obj31 = num75 & 1;
		bool flag21 = obj31 == null;
		object obj32 = !flag21;
		if (obj32 != null)
		{
			num75 = num74;
		}
		goto IL_1238;
		IL_1298:
		double num78;
		double num77 = num33 + num78;
		object obj33 = num33 & 1;
		bool flag22 = obj33 == null;
		object obj34 = !flag22;
		if (obj34 != null)
		{
			num33 = num77;
		}
		goto IL_12e2;
		IL_1238:
		zone.room = (int)num75;
		if ((object)zone == null)
		{
			goto IL_0fc4;
		}
		double num80;
		double num79 = 1.0 - num80;
		num11 = num80 * (double)enclosed;
		double num81 = (double)enclosed * num79;
		double num82 = num81;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		num14 = num82 * 0.0;
		double num83 = 1.0 - num11;
		num18 = num83 - num14;
		int roomHF = zone.roomHF;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4398]");
		object obj35 = 0;
		object obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X8_v15+E4]");
		bool flag23 = (nint)0 == 0;
		object obj37 = !flag23;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag24 = num9 < 0.0;
		double num84 = num11 * 3278700544.0;
		double num85 = num14 * 0.0;
		double num86 = num18 * 3267887104.0;
		double num87 = num85 + num84;
		double num88 = num87 + num86;
		double num89 = 0.0;
		if (!flag24)
		{
			bool flag25 = !(num9 > 1.0);
			num89 = num9;
			if (!flag25)
			{
				num89 = 1.0;
			}
		}
		double num90 = num88 - (double)roomHF;
		double num91 = num90 * num89;
		double num92 = num91 + (double)roomHF;
		object obj38 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X0_v23+E4]");
		bool flag26 = (nint)0 == 0;
		object obj39 = !flag26;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		if (num92 < 0.0)
		{
			if (num92 == -0.5)
			{
				num78 = -1.0;
				num33 = num70;
				goto IL_1298;
			}
			num33 = num92 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num92 == 0.5)
			{
				num78 = 1.0;
				num33 = num70;
				goto IL_1298;
			}
			num33 = num92 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_12e2;
		IL_1011:
		float deltaTime = Time.deltaTime;
		float num93 = blend * deltaTime;
		object obj40 = 0f - num93;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num94 = (double)size + -2.0;
		double num95 = num94 * 1031798784.0;
		bool flag27 = num95 < 0.0;
		num80 = 0.0;
		if (!flag27)
		{
			bool flag28 = !(num95 > 1.0);
			num80 = num95;
			if (!flag28)
			{
				num80 = 1.0;
			}
		}
		if ((object)zone == null)
		{
			goto IL_0fc4;
		}
		num9 = 1.0 - (double)obj40;
		int room = zone.room;
		bool flag29 = num9 < 0.0;
		double num96 = 0.0;
		if (!flag29)
		{
			bool flag30 = !(num9 > 1.0);
			num96 = num9;
			if (!flag30)
			{
				num96 = 1.0;
			}
		}
		object obj41 = 3296329728L - room;
		double num97 = (double)obj41 * num96;
		double num98 = num97 + (double)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		obj25 = 0;
		object obj42 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v14+E4]");
		bool flag31 = (nint)0 == 0;
		object obj43 = !flag31;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		if (num98 < 0.0)
		{
			if (num98 == -0.5)
			{
				num76 = -1.0;
				num75 = num70;
				goto IL_11ee;
			}
			num75 = num98 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num98 == 0.5)
			{
				num76 = 1.0;
				num75 = num70;
				goto IL_11ee;
			}
			num75 = num98 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_1238;
		IL_1442:
		zone.reflections = (int)num69;
		double num120;
		if ((object)zone != null)
		{
			float reflectionsDelay = zone.reflectionsDelay;
			bool flag32 = num9 < 0.0;
			double num99 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A958]");
			double num100 = num99 * 0.0;
			double num101 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC4]");
			double num102 = num101 * 0.0;
			double num103 = num100 + num102;
			double num104 = num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A99C]");
			double num105 = num104 * 0.0;
			double num106 = num103 + num105;
			double num107 = 0.0;
			if (!flag32)
			{
				bool flag33 = !(num9 > 1.0);
				num107 = num9;
				if (!flag33)
				{
					num107 = 1.0;
				}
			}
			double num108 = num106 - (double)reflectionsDelay;
			double num109 = num108 * num107;
			float reflectionsDelay2 = reflectionsDelay + (float)num109;
			zone.reflectionsDelay = reflectionsDelay2;
			if ((object)zone != null)
			{
				int reverb = zone.reverb;
				bool flag34 = num9 < 0.0;
				double num110 = num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB60]");
				double num111 = num110 * 0.0;
				double num112 = num14 * 3281453056.0;
				double num113 = num18 * 1128792064.0;
				double num114 = num111 + num112;
				double num115 = num114 + num113;
				double num116 = 0.0;
				if (!flag34)
				{
					bool flag35 = !(num9 > 1.0);
					num116 = num9;
					if (!flag35)
					{
						num116 = 1.0;
					}
				}
				double num117 = num115 - (double)reverb;
				double num118 = num117 * num116;
				double num119 = num118 + (double)reverb;
				object obj44 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1311 @ X0_v45+E4]");
				bool flag36 = (nint)0 == 0;
				object obj45 = !flag36;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
				if (num119 < 0.0)
				{
					if (num119 == -0.5)
					{
						num120 = -1.0;
						num8 = num70;
						goto IL_14fd;
					}
					num8 = num119 + -0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				}
				else
				{
					if (num119 == 0.5)
					{
						num120 = 1.0;
						num8 = num70;
						goto IL_14fd;
					}
					num8 = num119 + 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				}
				goto IL_1547;
			}
		}
		goto IL_0fc4;
		IL_13f8:
		double num121 = num69 + num68;
		object obj46 = num69 & 1;
		bool flag37 = obj46 == null;
		object obj47 = !flag37;
		if (obj47 != null)
		{
			num69 = num121;
		}
		goto IL_1442;
		IL_14fd:
		double num122 = num8 + num120;
		object obj48 = num8 & 1;
		bool flag38 = obj48 == null;
		object obj49 = !flag38;
		if (obj49 != null)
		{
			num8 = num122;
		}
		goto IL_1547;
	}

	public ReverbProbe()
	{
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C278]");
		range = 0f;
		base._002Ector();
	}

	static ReverbProbe()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4398]");
		object obj = 0;
		Vector3[] array = MakeDirs();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = array;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal static float _003CUpdate_003Eg__Mix_007C13_0(float h, float c, float g, ref CosmeticCatalog._003C_003Ec__DisplayClass13_0 P_3)
	{
		float num = (float)P_3 * h;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X0 (<>c__DisplayClass13_0&)+4]");
		float num2 = 0f * c;
		float num3 = num + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X0 (<>c__DisplayClass13_0&)+8]");
		float num4 = 0f * g;
		return num3 + num4;
	}
}
