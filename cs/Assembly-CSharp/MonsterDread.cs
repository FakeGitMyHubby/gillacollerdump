using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class MonsterDread : MonoBehaviour
{
	public float far;

	public float near;

	public float position;

	public float rotation;

	public float frequency;

	public float overlayFar;

	private Vector3 offPos;

	private Quaternion offRot;

	private float dread;

	private float border;

	private Renderer overlay;

	private Material overlayMat;

	private Volume post;

	private static readonly int DensityId;

	private UniversalAdditionalCameraData camData;

	private bool camLooked;

	public static bool ShutOut(Vector3 you, Vector3 monster)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_002e: Expected VT, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected I4, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_00a0: Expected VT, but got I4
		//IL_00b2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6;
		if (GillaDynamite.InSpawn((Vector3)0))
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = GillaDynamite.InSpawn((Vector3)0);
			obj6 = (flag3 ? 1 : 0) ^ 1;
		}
		else
		{
			obj6 = 0;
		}
		return (byte)(obj6 & 1) != 0;
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender += unityAction;
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender -= unityAction;
		Undo();
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0484: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got I
		//IL_0311: Expected Obj, but got I
		//IL_0327: Expected Obj, but got I
		//IL_0351: Expected VT, but got I4
		//IL_038f: Expected Obj, but got I
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_03cb: Expected Obj, but got I
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA438]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA400]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj6 = default;
		bool flag2 = obj6 != null;
		bool flag3 = !flag2;
		object obj7 = 0;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GameObject gameObject = default;
			gameObject._002Ector((string)obj);
			Transform transform = gameObject.transform;
			Transform parent = base.transform;
			transform.SetParent(parent, worldPositionStays: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA3B0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj10 = this + 112;
			object obj11 = default;
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			((Volume)obj10).isGlobal = true;
			object obj12 = obj10 + 48;
			obj12 = obj6;
			_ = 1092616192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_ = 0;
			((Behaviour)obj10).enabled = false;
			obj7 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE38]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CB0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		object obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj17 = default;
		if (!(obj17 == null))
		{
			GameObject gameObject2 = GameObject.CreatePrimitive((PrimitiveType)0);
			gameObject2.name = (string)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7560]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			object obj19 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj21 = default;
			UnityEngine.Object.Destroy(obj21);
			Transform transform2 = gameObject2.transform;
			Transform parent2 = base.transform;
			transform2.SetParent(parent2, worldPositionStays: false);
			Transform transform3 = gameObject2.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj22 = 0;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v16+A0]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v17+C]");
			object obj25 = (nint)0 * (nint)63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v17+14]");
			double num = 0.0 * 0.5;
			transform3.localScale = (Vector3)0;
			GameObject gameObject3 = base.gameObject;
			int layer = gameObject3.layer;
			gameObject2.layer = layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B18]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			object obj27 = this + 96;
			object obj28 = default;
			obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Material material = default;
			material._002Ector((Material)obj17);
			object obj30 = this + 104;
			obj30 = material;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			((Renderer)obj27).sharedMaterial = (Material)obj30;
			((Renderer)obj27).shadowCastingMode = (ShadowCastingMode)0;
			((Renderer)obj27).receiveShadows = false;
			((Renderer)obj27).enabled = false;
		}
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (overlayMat != null)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(overlayMat);
		}
	}

	private unsafe void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1367: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I4
		//IL_1385: Expected Obj, but got I
		//IL_13a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b2: Expected Obj, but got I
		//IL_13bb: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got I4
		//IL_095b: Expected F8, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got I4
		//IL_1509: Invalid comparison between F8 and I4
		//IL_151c: Expected Obj, but got F8
		//IL_1524: Unknown result type (might be due to invalid IL or missing references)
		//IL_1529: Expected Obj, but got Unknown
		//IL_1551: Expected Obj, but got I4
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Invalid comparison between F8 and I4
		//IL_09b4: Expected F8, but got I4
		//IL_0847: Expected Obj, but got I4
		//IL_0850: Expected Obj, but got I4
		//IL_0861: Expected Obj, but got I4
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Expected Obj, but got I4
		//IL_159a: Expected Obj, but got I4
		//IL_15b2: Invalid comparison between F4 and I4
		//IL_15c3: Expected Obj, but got I4
		//IL_18f6: Expected Obj, but got I
		//IL_18f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ff: Expected Ref, but got Unknown
		//IL_1919: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I4
		//IL_160c: Expected F8, but got I4
		//IL_1191: Unknown result type (might be due to invalid IL or missing references)
		//IL_1195: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got I4
		//IL_1634: Unknown result type (might be due to invalid IL or missing references)
		//IL_1641: Invalid comparison between F8 and I4
		//IL_1650: Expected F8, but got I4
		//IL_08aa: Expected Obj, but got I4
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected Obj, but got Unknown
		//IL_16fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1754: Invalid comparison between F8 and I4
		//IL_1767: Expected Obj, but got F8
		//IL_176f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1774: Expected Obj, but got Unknown
		//IL_179c: Expected Obj, but got I4
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Invalid comparison between F8 and I4
		//IL_0a72: Expected F8, but got I4
		//IL_17d1: Expected Obj, but got I4
		//IL_17ee: Invalid comparison between F8 and I4
		//IL_17f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_180e: Expected Obj, but got I4
		//IL_1824: Expected I4, but got Obj
		//IL_0200: Expected Obj, but got I4
		//IL_10cb: Expected Obj, but got I4
		//IL_10d9: Expected Obj, but got I4
		//IL_10e2: Expected Obj, but got I4
		//IL_10f3: Expected Obj, but got I4
		//IL_10f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1100: Unknown result type (might be due to invalid IL or missing references)
		//IL_1108: Unknown result type (might be due to invalid IL or missing references)
		//IL_1110: Unknown result type (might be due to invalid IL or missing references)
		//IL_185e: Expected Obj, but got I4
		//IL_0b6c: Expected Obj, but got I4
		//IL_124b: Expected Obj, but got I4
		//IL_1263: Unknown result type (might be due to invalid IL or missing references)
		//IL_1267: Unknown result type (might be due to invalid IL or missing references)
		//IL_127b: Unknown result type (might be due to invalid IL or missing references)
		//IL_127f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1896: Expected Obj, but got I4
		//IL_1311: Unknown result type (might be due to invalid IL or missing references)
		//IL_1315: Unknown result type (might be due to invalid IL or missing references)
		//IL_1329: Unknown result type (might be due to invalid IL or missing references)
		//IL_132d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Expected Obj, but got I4
		//IL_0bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d8: Expected Obj, but got I4
		//IL_0d8c: Expected Obj, but got I4
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c09: Expected F8, but got I
		//IL_0c2b: Invalid comparison between F8 and I4
		//IL_0c3a: Invalid comparison between F8 and I4
		//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c57: Expected Obj, but got Unknown
		//IL_0c66: Expected Obj, but got F8
		//IL_0c9b: Expected Obj, but got I4
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Expected I4, but got Unknown
		//IL_0cdb: Expected Obj, but got I4
		//IL_0cf3: Expected Obj, but got I4
		//IL_0cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected VT, but got I4
		//IL_02b7: Expected VT, but got I4
		//IL_0e22: Expected Obj, but got I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected F4, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got I4
		//IL_0d2b: Expected Obj, but got I4
		//IL_0e4a: Expected Obj, but got I4
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected F4, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got I4
		//IL_037e: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I4
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9f: Expected F8, but got I
		//IL_0ec1: Invalid comparison between F8 and I4
		//IL_0ed0: Invalid comparison between F8 and I4
		//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eed: Expected Obj, but got Unknown
		//IL_0efc: Expected Obj, but got F8
		//IL_0f31: Expected Obj, but got I4
		//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Expected I4, but got Unknown
		//IL_0f67: Expected Obj, but got I4
		//IL_0f7f: Expected Obj, but got I4
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected F4, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I4
		//IL_0452: Expected Obj, but got I4
		//IL_0463: Expected Obj, but got I4
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected VT, but got Obj
		//IL_04d6: Expected Obj, but got I4
		//IL_0fd9: Expected Obj, but got I
		//IL_0fe1: Expected I, but got Obj
		//IL_1003: Expected Obj, but got I4
		//IL_0501: Expected VT, but got I4
		//IL_051f: Expected Obj, but got I4
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected F4, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected F4, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got I4
		//IL_103a: Expected Obj, but got I4
		//IL_104f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected F4, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected F4, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected Obj, but got I4
		//IL_0609: Expected Obj, but got I4
		//IL_0612: Expected Obj, but got I4
		//IL_0623: Expected Obj, but got I4
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_106d: Expected I, but got Obj
		//IL_107d: Expected Obj, but got I
		//IL_1092: Expected I4, but got Obj
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected F4, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected F4, but got Unknown
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected F8, but got Unknown
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got I4
		//IL_0701: Expected Obj, but got I4
		//IL_070a: Expected Obj, but got I4
		//IL_071b: Expected Obj, but got I4
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_141d: Expected Obj, but got I4
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_142b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1433: Expected F8, but got Unknown
		//IL_1463: Unknown result type (might be due to invalid IL or missing references)
		//IL_146b: Expected F4, but got Unknown
		//IL_146b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1473: Expected F8, but got Unknown
		//IL_147f: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Expected Obj, but got I4
		//IL_148c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1490: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		Undo();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		UnityEngine.Object obj5;
		Enumerator<, > val;
		Enumerator<, > val2;
		UnityEngine.Object obj6;
		if (MonsterPlayer.IsMonster)
		{
			obj5 = null;
			val = (Enumerator<, >)0;
			val2 = (Enumerator<, >)2139095039;
			obj6 = (UnityEngine.Object)109895680;
			goto IL_0940;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v68+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v68+A0]");
		object obj10 = 0;
		bool flag3 = obj10 == null;
		UnityEngine.Object obj12 = default;
		UnityEngine.Object obj11 = obj12;
		UnityEngine.Object obj13 = null;
		val = (Enumerator<, >)0;
		IntPtr intPtr = default;
		UnityEngine.Object obj14 = (UnityEngine.Object)(nint)intPtr;
		UnityEngine.Object obj15 = (UnityEngine.Object)109895680;
		if (flag3)
		{
			goto IL_1121;
		}
		Enumerator<, > enumerator = ((List<System.__Canon>)obj10).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C50]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8E8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj18 = 0;
		Enumerator<, > val4 = default;
		Enumerator<, > val3 = val4;
		Enumerator<, > val5 = (Enumerator<, >)2139095039;
		obj15 = (UnityEngine.Object)109895680;
		double num5 = default;
		double num8 = default;
		double num9 = default;
		object obj38 = default;
		float num10;
		double num;
		float num6;
		Enumerator<, > val6;
		double num3;
		double num2 = default;
		float num7;
		double num4 = default;
		object obj28 = default;
		object obj21 = default;
		while (true)
		{
			object obj27;
			double num11;
			double num12;
			double num13;
			object obj29;
			object obj30;
			object obj31;
			object obj32;
			Enumerator<, > val10;
			object obj33;
			object obj34;
			Enumerator<, > val11;
			object obj22;
			object obj23;
			object obj24;
			Enumerator<, > val7;
			Enumerator<, > val8;
			Enumerator<, > val9;
			if (val.MoveNext())
			{
				object obj19 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v74+E4]");
				bool flag4 = (nint)0 == 0;
				object obj20 = !flag4;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = obj12 != null;
				bool flag6 = !flag5;
				obj21 = 0;
				obj15 = obj12;
				if (flag6)
				{
					continue;
				}
				if ((object)obj12 != null)
				{
					bool flag7 = ((Behaviour)obj12).isActiveAndEnabled;
					bool flag8 = !flag7;
					obj21 = 0;
					obj15 = obj12;
					if (flag8)
					{
						continue;
					}
					Transform transform = ((Component)obj12).transform;
					bool flag9 = (object)transform == null;
					obj14 = null;
					if (!flag9)
					{
						Vector3 vector = transform.position;
						Transform transform2 = base.transform;
						bool flag10 = (object)transform2 == null;
						num = num2;
						num3 = num4;
						val6 = val3;
						obj14 = null;
						if (flag10)
						{
							goto IL_10b9;
						}
						Vector3 vector2 = transform2.position;
						bool flag11 = GillaBackroomsSwitch.SameSide((Vector3)0, (Vector3)0);
						bool flag12 = !flag11;
						num5 = num2;
						num6 = (float)num4;
						num7 = (float)val3;
						num = num2;
						num3 = num4;
						val6 = val3;
						obj21 = 0;
						obj15 = obj12;
						if (flag12)
						{
							continue;
						}
						Transform transform3 = base.transform;
						bool flag13 = (object)transform3 == null;
						num5 = num2;
						num6 = (float)num4;
						num7 = (float)val3;
						num = num2;
						num3 = num4;
						val6 = val3;
						obj21 = 0;
						obj11 = null;
						obj22 = 0;
						obj23 = 1;
						obj13 = obj12;
						obj24 = 109891584;
						val7 = (Enumerator<, >)2139095039;
						val = val4;
						val8 = (Enumerator<, >)(ref val);
						val9 = (Enumerator<, >)(ref val);
						obj14 = null;
						obj15 = obj12;
						if (flag13)
						{
							break;
						}
						Vector3 vector3 = transform3.position;
						Transform transform4 = ((Component)obj12).transform;
						bool flag14 = (object)transform4 == null;
						num5 = num2;
						num6 = (float)num4;
						num7 = (float)val3;
						num = num2;
						num3 = num4;
						val6 = val3;
						obj21 = 0;
						obj11 = null;
						obj22 = 0;
						obj23 = 1;
						obj13 = obj12;
						obj24 = 109891584;
						val7 = (Enumerator<, >)2139095039;
						val = val4;
						val8 = (Enumerator<, >)(ref val);
						val9 = (Enumerator<, >)(ref val);
						obj14 = null;
						obj15 = obj12;
						if (flag14)
						{
							goto IL_112f;
						}
						Vector3 vector4 = transform4.position;
						Vector3 you = (Vector3)obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X0_v100 (UnityEngine.Vector3)+E4]");
						bool flag15 = (nint)0 == 0;
						object obj25 = !flag15;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag16 = ShutOut(you, (Vector3)0);
						bool flag17 = !flag16;
						object obj26 = !flag17;
						num8 = num2;
						num9 = num4;
						num10 = (float)val3;
						num5 = num2;
						num6 = (float)num4;
						num7 = (float)val3;
						num = num2;
						num3 = num4;
						val6 = val3;
						obj21 = 0;
						obj15 = obj12;
						if (obj26 != null)
						{
							continue;
						}
						Transform transform5 = ((Component)obj12).transform;
						bool flag18 = (object)transform5 == null;
						obj27 = obj28;
						num11 = num2;
						num12 = num4;
						num10 = (float)val3;
						num13 = num2;
						num6 = (float)num4;
						num7 = (float)val3;
						num = num2;
						num3 = num4;
						val6 = val3;
						obj29 = 0;
						obj11 = null;
						obj30 = 0;
						obj31 = 1;
						obj13 = obj12;
						obj32 = 109891584;
						val10 = (Enumerator<, >)2139095039;
						val = val4;
						obj33 = obj17;
						obj34 = obj16;
						val11 = (Enumerator<, >)(ref val);
						val9 = (Enumerator<, >)(ref val);
						obj14 = null;
						obj15 = obj12;
						if (!flag18)
						{
							Vector3 vector5 = transform5.position;
							Transform transform6 = base.transform;
							bool flag19 = (object)transform6 == null;
							obj27 = obj28;
							num11 = num2;
							num12 = num4;
							num10 = (float)val3;
							num13 = num2;
							num6 = (float)num4;
							num7 = (float)val3;
							num = (double)val3;
							num3 = num4;
							val6 = (Enumerator<, >)num2;
							obj29 = 0;
							obj11 = null;
							obj30 = 0;
							obj31 = 1;
							obj13 = obj12;
							obj32 = 109891584;
							val10 = (Enumerator<, >)2139095039;
							val = val4;
							obj33 = obj17;
							obj34 = obj16;
							val11 = (Enumerator<, >)(ref val);
							val9 = (Enumerator<, >)(ref val);
							obj14 = null;
							obj15 = obj12;
							if (!flag19)
							{
								Vector3 vector6 = transform6.position;
								object obj35 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1189 @ X0_v109+E4]");
								bool flag20 = (nint)0 == 0;
								object obj36 = !flag20;
								if (obj36 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								double num14 = (double)val3 - (double)val3;
								double num15 = num4 - num4;
								double num16 = num2 - num2;
								double num17 = num14 * num14;
								double num18 = num15 * num15;
								double num19 = num17 + num18;
								double num20 = num16 * num16;
								Enumerator<, > val12 = (Enumerator<, >)(num20 + num19);
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								if (val5 >= val12)
								{
									val5 = val12;
								}
								num8 = (double)val3;
								num9 = num4;
								num10 = (float)num2;
								num2 = num16;
								num4 = num20;
								num5 = num16;
								num6 = (float)num20;
								num7 = (float)val3;
								num = (double)val3;
								num3 = num20;
								val6 = (Enumerator<, >)num16;
								obj21 = 0;
								val3 = val12;
								obj15 = obj12;
								continue;
							}
							goto IL_11c5;
						}
						goto IL_11d3;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
					obj14 = null;
				}
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_10b9;
			}
			obj11 = null;
			obj22 = 0;
			obj23 = 1;
			obj13 = obj12;
			obj24 = 109891584;
			val7 = (Enumerator<, >)2139095039;
			val = val4;
			val8 = (Enumerator<, >)(ref val);
			val9 = (Enumerator<, >)(ref val);
			object obj37 = 0;
			goto IL_18e6;
			IL_11d3:
			NullReferenceException ex3 = new NullReferenceException();
			if ((nint)obj14 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj28 = obj27;
				num8 = num11;
				num9 = num12;
				num5 = num13;
				obj21 = obj29;
				obj11 = (UnityEngine.Object)1;
				obj22 = obj30;
				obj23 = obj31;
				obj24 = obj32;
				val7 = val10;
				obj17 = obj33;
				obj16 = obj34;
				val8 = val11;
				obj37 = obj30;
			}
			else
			{
				if ((nint)obj14 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D7E4");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj37 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj28 = obj27;
				num8 = num11;
				num9 = num12;
				num5 = num13;
				obj21 = obj29;
				obj22 = obj38;
				obj23 = obj31;
				obj24 = obj32;
				val7 = val10;
				obj17 = obj33;
				obj16 = obj34;
				val8 = val11;
			}
			goto IL_18e6;
			IL_18e6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C48]");
			object obj39 = 0;
			((Enumerator<, >*)val9)->Dispose();
			bool flag21 = obj37 == null;
			object obj40 = !flag21;
			obj14 = (UnityEngine.Object)obj39;
			if (obj40 == null)
			{
				bool flag22 = (object)obj11 == null;
				object obj41 = !flag22;
				obj5 = obj13;
				val2 = val5;
				obj6 = obj15;
				obj27 = obj28;
				num11 = num8;
				num12 = num9;
				num13 = num5;
				obj29 = obj21;
				obj30 = obj22;
				obj31 = obj23;
				obj32 = obj24;
				val10 = val7;
				obj33 = obj17;
				obj34 = obj16;
				val11 = val8;
				obj14 = (UnityEngine.Object)obj39;
				OutOfMemoryException ex4 = (OutOfMemoryException)val9;
				if (obj41 == null)
				{
					goto IL_0940;
				}
			}
			else
			{
				OutOfMemoryException ex4 = new OutOfMemoryException();
				obj27 = obj28;
				num11 = num8;
				num12 = num9;
				num13 = num5;
				obj29 = obj21;
				obj30 = obj22;
				obj31 = obj23;
				obj32 = obj24;
				val10 = val7;
				obj33 = obj17;
				obj34 = obj16;
				val11 = val8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_11c5;
			IL_11c5:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_11d3;
			IL_10b9:
			NullReferenceException ex6 = new NullReferenceException();
			obj21 = 0;
			obj11 = null;
			obj22 = 0;
			obj23 = 1;
			obj13 = obj12;
			obj24 = 109891584;
			val7 = (Enumerator<, >)2139095039;
			val = val4;
			val8 = (Enumerator<, >)(ref val);
			val9 = (Enumerator<, >)(ref val);
			obj15 = obj12;
			goto IL_1121;
		}
		goto IL_113d;
		IL_186c:
		object obj42 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X0_v42+E4]");
		bool flag23 = (nint)0 == 0;
		object obj43 = !flag23;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj44;
		double num21;
		bool flag25;
		if (obj44 != null)
		{
			bool flag24 = (object)post == null;
			obj21 = 0;
			obj11 = obj11;
			obj13 = obj5;
			val3 = (Enumerator<, >)num21;
			obj14 = null;
			val5 = val2;
			obj15 = obj6;
			if (flag24)
			{
				goto IL_1121;
			}
			flag25 = post.enabled;
		}
		else
		{
			flag25 = false;
		}
		PostProcessing(flag25);
		object obj45 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ X0_v48+E4]");
		bool flag26 = (nint)0 == 0;
		object obj46 = !flag26;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag27 = overlay == null;
		bool flag28 = !flag27;
		object obj47 = !flag28;
		if (obj47 != null)
		{
			return;
		}
		bool flag29 = (object)overlay == null;
		obj21 = 0;
		obj11 = obj11;
		obj13 = obj5;
		val3 = (Enumerator<, >)num21;
		obj14 = null;
		val5 = val2;
		obj15 = obj6;
		if (!flag29)
		{
			val3 = (Enumerator<, >)border;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			num4 = 0.0;
			double num22 = border;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			double num23 = num22 - 0.0;
			bool flag30 = num23 < 0.0;
			bool flag31 = num23 == 0.0;
			float num24 = border;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			object obj48 = num24 ^ 0;
			object obj49 = (double)border ^ num23;
			object obj50 = obj48 & obj49;
			bool flag32 = (nint)obj50 < 0;
			bool flag33 = flag30 == flag32;
			obj28 = !flag31;
			bool flag34 = (byte)((flag33 & obj28) ? 1 : 0) != 0;
			overlay.enabled = flag34;
			bool flag35 = (object)overlay == null;
			obj21 = 0;
			obj11 = obj11;
			obj13 = obj5;
			obj14 = (UnityEngine.Object)flag34;
			val5 = val2;
			obj15 = obj6;
			if (!flag35)
			{
				if (!overlay.enabled)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8E8]");
				obj15 = (UnityEngine.Object)0;
				nint num25 = (nint)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X0_v56 (Il2CppClass<UnityEngine.Object>)+E4]");
				bool flag36 = (nint)0 == 0;
				object obj51 = !flag36;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag37 = (object)overlayMat == null;
				obj21 = 0;
				obj11 = obj11;
				obj13 = obj5;
				obj14 = null;
				val5 = val2;
				if (!flag37)
				{
					nint num26 = (nint)obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ X8_v24 (Il2CppClass<UnityEngine.Object>)+A0]");
					object obj52 = 0;
					overlayMat.SetFloat((int)obj52, border);
					return;
				}
			}
		}
		goto IL_1121;
		IL_1121:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_112f;
		IL_0940:
		bool flag38 = near == far;
		double num27 = 0.0;
		if (!flag38)
		{
			float num28 = (float)val2 - near;
			float num29 = far - near;
			double num30 = (double)num28 / (double)num29;
			bool flag39 = num30 < 0.0;
			num27 = 0.0;
			if (!flag39)
			{
				bool flag40 = !(num30 > 1.0);
				num27 = num30;
				if (!flag40)
				{
					num27 = 1.0;
				}
			}
		}
		num10 = dread;
		num = 1.0 - num27;
		float deltaTime = Time.deltaTime;
		double num31 = num * num;
		float num32 = deltaTime + deltaTime;
		double num33 = num31 - (double)dread;
		float num34 = 0f - num32;
		bool flag41 = num33 < 0.0;
		object obj53 = num33 ^ num33;
		object obj54 = num33 & obj53;
		bool flag42 = (nint)obj54 < 0;
		bool flag43 = flag41 == flag42;
		object obj55 = !flag43;
		object obj56 = ~obj55;
		float num35 = ((obj56 != null) ? num32 : num34);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		num6 = num10 + num35;
		bool flag44 = num34 < num32;
		object obj57 = !flag44;
		float num36 = num34 - num32;
		bool flag45 = num36 == 0f;
		object obj58 = !flag45;
		object obj59 = obj57 & obj58;
		object obj60 = ~obj59;
		if (obj60 == null)
		{
			num31 = num6;
		}
		bool flag46 = near == overlayFar;
		dread = (float)num31;
		double num37 = 0.0;
		if (!flag46)
		{
			float num38 = (float)val2 - near;
			float num39 = overlayFar - near;
			double num40 = (double)num38 / (double)num39;
			bool flag47 = num40 < 0.0;
			num37 = 0.0;
			if (!flag47)
			{
				bool flag48 = !(num40 > 1.0);
				num37 = num40;
				if (!flag48)
				{
					num37 = 1.0;
				}
			}
		}
		double num41 = 1.0 - num37;
		val6 = (Enumerator<, >)border;
		bool flag49 = num41 < 0.0;
		double num42 = 0.0;
		if (!flag49)
		{
			bool flag50 = !(num41 > 1.0);
			num42 = num41;
			if (!flag50)
			{
				num42 = 1.0;
			}
		}
		double num43 = num42 + num42;
		double num44 = num42 * 3.0;
		double num45 = num42 * num43;
		double num46 = num42 * num45;
		double num47 = num42 * num44;
		double num48 = num47 - num46;
		double num49 = 1.0 - num48;
		double num50 = num49 * 0.0;
		num3 = num48 + num50;
		float deltaTime2 = Time.deltaTime;
		num2 = num3 - (double)val6;
		object obj61 = obj4;
		num7 = deltaTime2 * 1.5f;
		float num51 = deltaTime2 * 1.5f;
		float num52 = 0f - num51;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag51 = num2 < 0.0;
		object obj62 = num2 ^ num2;
		object obj63 = num2 & obj62;
		bool flag52 = (nint)obj63 < 0;
		bool flag53 = flag51 == flag52;
		object obj64 = !flag53;
		object obj65 = ~obj64;
		if (obj65 != null)
		{
			num52 = num7;
		}
		bool flag54 = 1.5 < (double)num7;
		object obj66 = !flag54;
		double num53 = 1.5 - (double)num7;
		bool flag55 = num53 == 0.0;
		float num54 = (float)val6 + num52;
		object obj67 = !flag55;
		object obj68 = obj66 & obj67;
		num21 = (((int)(~obj68) != 0) ? num3 : ((double)num54));
		border = (float)num21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ X0_v37+E4]");
		bool flag56 = (nint)0 == 0;
		object obj69 = !flag56;
		if (obj69 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag57 = post != null;
		bool flag58 = !flag57;
		num4 = 1.5;
		object obj70 = 0;
		bool flag59 = false;
		obj44 = post;
		if (!flag58)
		{
			bool flag60 = (object)post == null;
			num4 = 1.5;
			obj21 = 0;
			obj11 = obj11;
			obj13 = obj5;
			val3 = (Enumerator<, >)num21;
			obj14 = null;
			val5 = val2;
			obj15 = obj6;
			if (!flag60)
			{
				val3 = (Enumerator<, >)border;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				num4 = 0.0;
				double num55 = border;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				double num56 = num55 - 0.0;
				bool flag61 = num56 < 0.0;
				bool flag62 = num56 == 0.0;
				float num57 = border;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				object obj71 = num57 ^ 0;
				object obj72 = (double)border ^ num56;
				object obj73 = obj71 & obj72;
				bool flag63 = (nint)obj73 < 0;
				bool flag64 = flag61 == flag63;
				obj28 = !flag62;
				bool flag65 = (byte)((flag64 & obj28) ? 1 : 0) != 0;
				post.enabled = flag65;
				obj44 = post;
				bool flag66 = (object)post == null;
				obj21 = 0;
				obj11 = obj11;
				obj13 = obj5;
				obj14 = (UnityEngine.Object)flag65;
				val5 = val2;
				obj15 = obj6;
				if (!flag66)
				{
					num21 = border;
					_ = border;
					obj70 = 0;
					flag59 = flag65;
					goto IL_186c;
				}
			}
			goto IL_1121;
		}
		goto IL_186c;
		IL_112f:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_113d;
		IL_113d:
		throw new NullReferenceException();
	}

	private unsafe void PostProcessing(bool on)
	{
		//IL_025c: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got Ref
		//IL_021e: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I4
		//IL_0137: Expected I, but got Obj
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0165: Expected Obj, but got I
		//IL_016d: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool flag = (byte)(~(camLooked ? 1u : 0u)) != 0;
		object obj2 = !flag;
		UnityEngine.Object obj3 = (UnityEngine.Object)on;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE48]");
			object obj4 = 0;
			camLooked = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			object obj6 = default;
			object obj5 = obj6 & 1;
			Camera camera = default;
			UnityEngine.Object obj8;
			if (obj5 != null)
			{
				object obj7 = (object)(&camera);
				obj8 = camera;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE40]");
				object obj9 = 0;
				object obj7 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F01C");
				UnityEngine.Object obj10 = default;
				camera = (Camera)obj10;
				obj8 = obj10;
			}
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Camera camera2;
			if (obj8 == null)
			{
				Camera main = Camera.main;
				camera = main;
				camera2 = main;
			}
			else
			{
				camera2 = camera;
			}
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = camera2 != null;
			bool flag5 = !flag4;
			nint num = unchecked((nint)null);
			obj3 = null;
			if (!flag5)
			{
				obj3 = (UnityEngine.Object)(this + 120);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE50]");
				object obj15 = 0;
				num = (nint)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			}
		}
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (camData != null)
		{
			UniversalAdditionalCameraData universalAdditionalCameraData = camData;
			bool flag7 = !universalAdditionalCameraData.m_RenderPostProcessing;
			object obj18 = !flag7;
			if ((nint)obj18 != (on ? 1 : 0))
			{
				universalAdditionalCameraData.m_RenderPostProcessing = on;
			}
		}
	}

	private void Shake()
	{
		//IL_020d: Invalid comparison between F4 and I
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I4
		//IL_0133: Expected F4, but got I
		//IL_0151: Expected F4, but got I
		//IL_016a: Expected F4, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I
		//IL_02cd: Expected VT, but got F4
		//IL_035e: Expected VT, but got F4
		//IL_01b1: Expected VT, but got I4
		//IL_01ef: Expected VT, but got I4
		Undo();
		float num = dread;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		if (num < 0f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v2+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 != null)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v23+A0]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v25+A9]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 != null)
			{
				return;
			}
		}
		float time = Time.time;
		float num2 = time * frequency;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		float num3 = Mathf.PerlinNoise(num2, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num4 = Mathf.PerlinNoise(0f, num2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		float num5 = Mathf.PerlinNoise(num2, 0f);
		float num6 = num5 + num5;
		float num7 = num3 + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj11 = 0;
		object obj12 = obj11;
		float num8 = position * dread;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v17+A0]");
		object obj13 = 0;
		float num9 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v18+C]");
		float num10 = num9 - 0f;
		float num11 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v18+14]");
		float num12 = num11 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num13 = rotation * num10;
		object obj14 = default;
		float num14 = num10 * (float)obj14;
		float num15 = num12 * num8;
		offPos = (Vector3)num14;
		object obj15 = default;
		float num16 = num4 * (float)obj15;
		float num17 = dread * num13;
		object obj16 = default;
		float num18 = num16 * (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num19 = num17 * 0.5f;
		float num20 = num18 * dread;
		float num21 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		float num22 = num21 * 0f;
		Vector3 euler = default;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		offRot = (Quaternion)num14;
		Transform transform = base.transform;
		Vector3 localPosition = transform.localPosition;
		transform.localPosition = (Vector3)0;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Quaternion localRotation = transform3.localRotation;
		transform2.localRotation = (Quaternion)0;
	}

	private void Undo()
	{
		//IL_0094: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I
		//IL_0034: Expected VT, but got I4
		//IL_0158: Expected Obj, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I
		//IL_007f: Expected VT, but got I4
		//IL_01fb: Expected Obj, but got I
		//IL_0205: Expected VT, but got Obj
		//IL_0230: Expected Obj, but got I
		//IL_023a: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj4 = 0;
		object obj5 = offPos - obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDread)+40]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+8]");
		object obj6 = num - 0;
		object obj7 = obj5 * obj5;
		object obj8 = obj6 * obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj9 = obj8 + obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if ((nint)obj9 < 0)
		{
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v19+A0]");
			object obj11 = 0;
			object obj12 = offRot * obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDread)+4C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v20+8]");
			object obj13 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj15 = default;
			object obj14 = obj12 + obj15;
			object obj16 = obj13 + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj17 = obj13 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
			if ((nint)obj17 > 0)
			{
				return;
			}
		}
		Transform transform = base.transform;
		Vector3 localPosition = transform.localPosition;
		transform.localPosition = (Vector3)0;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Quaternion localRotation = transform3.localRotation;
		Quaternion quaternion2 = default;
		Quaternion quaternion = Quaternion.Internal_Inverse(ref quaternion2);
		transform2.localRotation = (Quaternion)0;
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v10+A0]");
		object obj19 = 0;
		offPos = (Vector3)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v11+8]");
		_ = 0;
		object obj20 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v13+A0]");
		object obj21 = 0;
		offRot = (Quaternion)obj21;
	}

	public MonsterDread()
	{
		//IL_0012: Expected F4, but got I
		//IL_0024: Expected F4, but got I
		//IL_0039: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_005b: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EC00]");
		far = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BDC0]");
		frequency = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v6+A0]");
		offRot = (Quaternion)(object)0;
		base._002Ector();
	}

	static MonsterDread()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE58]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8E8]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}
}
