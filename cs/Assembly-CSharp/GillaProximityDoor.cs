using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaProximityDoor : MonoBehaviour
{
	[Serializable]
	public class Place
	{
		public string name;

		public Bounds area;

		public GameObject[] roots;

		public int with;

		public Place()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			//IL_004c: Expected I4, but got I8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj2 = this + 48;
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			with = -1;
			base._002Ector();
		}
	}

	public float openAngle = 95f;

	public Vector3 middle;

	public float reach;

	public float openTime;

	public bool moderatorsOnly;

	public Vector3 openSide;

	public static Func<bool> YouModerate;

	private Quaternion shut;

	private float open;

	private float speed;

	private float nextLook;

	private bool someoneNear;

	private const float WallIn = default(float);

	private const float WallWide = default(float);

	private const float WallTall = default(float);

	private const float WallThick = default(float);

	private const float VentFrom = default(float);

	private const float VentTo = default(float);

	private const float VentSide = default(float);

	private const float VentBelow = default(float);

	private const float VentAbove = default(float);

	private const float BlockFrom = default(float);

	private const float BlockBelow = default(float);

	private const float BlockAbove = default(float);

	private BoxCollider wall;

	private BoxCollider room;

	private Bounds block;

	private bool hasBlock;

	public BoxCollider StaffOnlyWall => wall;

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_0145: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F20]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v9+8]");
		Func<bool> func = (Func<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F30]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v9+8]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v13+A0]");
				obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F38]");
			object obj10 = 0;
			Func<bool> func2 = default;
			func2._002Ector(obj4, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v12+A0]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			func = func2;
		}
		object obj13 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+A0]");
		object obj15 = 0;
		obj15 = func;
		object obj16 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void Awake()
	{
		Transform transform = base.transform;
		Quaternion localRotation = transform.localRotation;
		Quaternion quaternion = default;
		shut = quaternion;
	}

	private void Start()
	{
		//IL_0024: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_0a42: Expected Obj, but got I
		//IL_0a6c: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got VT
		//IL_019f: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_0236: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_0297: Expected VT, but got I4
		//IL_06c1: Expected Obj, but got I
		//IL_02bc: Expected VT, but got I4
		//IL_02cc: Expected Obj, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_030b: Expected VT, but got I4
		//IL_031b: Expected Obj, but got I
		//IL_0345: Expected Obj, but got I4
		//IL_06e7: Expected Obj, but got I
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected I4, but got Unknown
		//IL_03f5: Expected Obj, but got I4
		//IL_043d: Expected Obj, but got I4
		//IL_071e: Expected Obj, but got I4
		//IL_04f7: Expected Obj, but got I4
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got Unknown
		//IL_0773: Expected Obj, but got I4
		//IL_0563: Expected Obj, but got I4
		//IL_0515: Expected Obj, but got I
		//IL_0493: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I4
		//IL_05c4: Expected VT, but got I4
		//IL_05db: Expected VT, but got I4
		//IL_0632: Expected Obj, but got I
		//IL_064f: Expected Obj, but got I
		//IL_0799: Expected Obj, but got I
		//IL_07c0: Expected Obj, but got I
		//IL_07dd: Expected Obj, but got I
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected Obj, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected Obj, but got Unknown
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected Obj, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected Obj, but got Unknown
		//IL_08f2: Invalid comparison between F8 and I4
		//IL_0901: Invalid comparison between F8 and I4
		//IL_0914: Expected Obj, but got F8
		//IL_0921: Expected Obj, but got F8
		//IL_0956: Expected Obj, but got I4
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected Obj, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected Obj, but got Unknown
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected Obj, but got Unknown
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected VT, but got Unknown
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Expected Obj, but got Unknown
		//IL_0a8a: Expected Obj, but got I
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected Obj, but got Unknown
		//IL_0ad7: Expected Obj, but got I
		//IL_0af4: Expected Obj, but got I
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b20: Expected Obj, but got Unknown
		//IL_0bde: Expected VT, but got F8
		if (~(moderatorsOnly ? 1u : 0u) != 0)
		{
			return;
		}
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Transform parent = transform.parent;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = parent == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F48]");
		object obj6 = 0;
		GameObject gameObject = default;
		gameObject._002Ector((string)obj6);
		GameObject gameObject2 = base.gameObject;
		int layer = gameObject2.layer;
		gameObject.layer = layer;
		Transform transform2 = gameObject.transform;
		Transform transform3 = base.transform;
		Transform parent2 = transform3.parent;
		transform2.SetParent(parent2, worldPositionStays: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v25+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = openSide * openSide;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+40]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+40]");
		object obj11 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj12 = 0;
		object obj13 = obj10 + obj11;
		object obj15 = default;
		object obj14 = obj13 + obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		object obj16;
		if ((nint)obj14 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+44]");
			obj16 = 0 / obj14;
		}
		else
		{
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v54+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v55+8]");
			obj16 = 0;
		}
		Transform transform4 = gameObject.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj19 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADCC]");
		object obj20 = obj19 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+2C]");
		object obj21 = 0 + obj20;
		transform4.localPosition = (Vector3)0;
		Transform transform5 = gameObject.transform;
		object obj22 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v25+A0]");
		object obj23 = 0;
		Vector3 forward = default;
		Vector3 upwards = default;
		Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
		transform5.localRotation = (Quaternion)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DE8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		object obj25 = this + 104;
		object obj26 = default;
		obj25 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		((BoxCollider)obj25).size = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F30]");
		object obj27 = 0;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v41+E4]");
		bool flag5 = (nint)0 == 0;
		object obj29 = !flag5;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj27;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v41+A0]");
		object obj30 = 0;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v432 @ X8_v32+18] (should have been resolved before IL gen)");
		object obj33 = default;
		object obj32 = ~obj33;
		bool flag6 = (byte)(1 & obj32) != 0;
		((Collider)obj25).enabled = flag6;
		Transform transform6 = base.transform;
		Transform parent3 = transform6.parent;
		Transform parent4 = parent3.parent;
		object obj34 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v34+E4]");
		bool flag7 = (nint)0 == 0;
		object obj35 = !flag7;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = parent4 != null;
		bool flag9 = !flag8;
		UnityEngine.Object obj36 = null;
		object obj37 = 0;
		string text = null;
		if (!flag9)
		{
			Transform transform7 = base.transform;
			Transform parent5 = transform7.parent;
			Transform parent6 = parent5.parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F50]");
			object obj38 = 0;
			text = (string)obj38;
			Transform transform8 = parent6.Find((string)obj38);
			obj36 = transform8;
			obj37 = 0;
		}
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v53+E4]");
		bool flag10 = (nint)0 == 0;
		object obj40 = !flag10;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = obj36 != null;
		bool flag12 = !flag11;
		object obj41 = 0;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F40]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj43 = default;
			obj41 = obj43;
		}
		object obj44 = this + 112;
		obj44 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj45 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X0_v60+E4]");
		bool flag13 = (nint)0 == 0;
		object obj46 = !flag13;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = (UnityEngine.Object)obj44 == null;
		bool flag15 = !flag14;
		object obj47 = !flag15;
		if (obj47 == null)
		{
			Transform transform9 = base.transform;
			Transform parent7 = transform9.parent;
			Transform transform10 = ((Component)obj44).transform;
			Vector3 center = ((BoxCollider)obj44).center;
			Vector3 vector = transform10.TransformPoint((Vector3)0);
			Vector3 vector2 = parent7.InverseTransformPoint((Vector3)0);
			Vector3 size = ((BoxCollider)obj44).size;
			Transform transform11 = ((Component)obj44).transform;
			Vector3 lossyScale = transform11.lossyScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			object obj48 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
			object obj49 = num3 * 0;
			object obj50 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v44+A0]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X9_v7+14]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB24]");
			object obj52 = num4 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X9_v7+C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			object obj53 = num5 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj54 = obj48 + obj52;
			object obj55 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
			object obj56 = obj55 * 0;
			object obj57 = obj49 + obj53;
			double num6 = (double)obj54 * 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+2C]");
			double num7 = 0.0 + (double)obj56;
			object obj58 = obj57 * 63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			double num8 = 0.0 - num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			double num9 = 0.0 + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
			object obj59 = 0 - obj58;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
			object obj60 = 0 + obj58;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			if (!(num8 < num7))
			{
				num8 = num7;
			}
			double num10 = num9 - num7;
			bool flag16 = num10 < 0.0;
			bool flag17 = num10 == 0.0;
			object obj61 = num9 ^ num7;
			object obj62 = num9 ^ num10;
			object obj63 = obj61 & obj62;
			bool flag18 = (nint)obj63 < 0;
			bool flag19 = flag16 == flag18;
			object obj64 = !flag17;
			object obj65 = flag19 & obj64;
			object obj66 = ~obj65;
			if (obj66 != null)
			{
				num9 = num7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
			double num11 = num9 - num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
			object obj67 = obj60 - 0;
			double num12 = num11 * 0.5;
			object obj68 = obj67 * 63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
			Bounds bounds = (Bounds)(0 + obj68);
			double num13 = num8 + num12;
			object obj69 = bounds - obj68;
			double num14 = num13 - num12;
			block = bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v44+A0]");
			object obj70 = 0;
			double num15 = num13 + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj71 = bounds + obj68;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v45+20]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABC0]");
			object obj72 = num16 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v45+20]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			object obj73 = num17 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v45+18]");
			double num18 = 0.0 * num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v45+18]");
			object obj74 = 0 * obj59;
			hasBlock = true;
			double num19 = num14 + (double)obj72;
			double num20 = num15 + (double)obj73;
			double num21 = (double)obj69 + num18;
			object obj75 = obj71 + obj74;
			double num22 = num20 - num19;
			double num23 = (double)obj75 - num21;
			double num24 = num22 * 0.5;
			double num25 = num23 * 63.0;
			double num26 = num19 + num24;
			double num27 = num21 + num25;
			block = (Bounds)num27;
		}
	}

	private void Update()
	{
		//IL_023e: Expected F8, but got I4
		//IL_004e: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_0290: Invalid comparison between F4 and I
		//IL_00c7: Expected Obj, but got I4
		//IL_00cc: Expected I, but got Obj
		//IL_0260: Invalid comparison between F4 and I4
		//IL_02b7: Expected F4, but got I
		//IL_00ea: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I4
		//IL_02cc: Expected F8, but got I
		//IL_04ea: Expected Obj, but got I
		//IL_0305: Expected F8, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_019a: Expected I, but got Obj
		//IL_0586: Expected Obj, but got I
		//IL_05b0: Expected Obj, but got I4
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_020c: Expected Obj, but got I4
		//IL_035a: Invalid comparison between F4 and I4
		//IL_0369: Invalid comparison between F4 and I4
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_038a: Expected Obj, but got F4
		//IL_03bf: Expected Obj, but got I4
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected I4, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_03f9: Expected F4, but got I4
		//IL_0700: Invalid comparison between F4 and I4
		//IL_041b: Invalid comparison between F4 and I4
		//IL_0620: Invalid comparison between F4 and I
		//IL_0446: Expected F4, but got I4
		//IL_044f: Expected F4, but got I4
		//IL_046e: Invalid comparison between F4 and I
		//IL_04ad: Expected VT, but got I4
		float unscaledTime = Time.unscaledTime;
		if (!(unscaledTime < nextLook))
		{
			float unscaledTime2 = Time.unscaledTime;
			float num = unscaledTime2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			float num2 = num + 0f;
			nextLook = num2;
			bool flag = Near();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			someoneNear = flag;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = wall != null;
			bool flag4 = !flag3;
			object obj4 = 0;
			nint num3 = unchecked((nint)null);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F30]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v32+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v32+A0]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v367 @ X8_v34+18] (should have been resolved before IL gen)");
				bool flag6 = wall.enabled;
				object obj11 = default;
				object obj10 = obj11 ^ flag6;
				object obj12 = obj10 & 1;
				bool flag7 = obj12 == null;
				object obj13 = !flag7;
				obj4 = 0;
				num3 = unchecked((nint)null);
				if (obj13 == null)
				{
					object obj14 = ~obj11;
					bool flag8 = (byte)(1 & obj14) != 0;
					wall.enabled = flag8;
					obj4 = 0;
					num3 = (flag8 ? 1 : 0);
				}
				object obj15 = obj11 & 1;
				bool flag9 = obj15 == null;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					KeepOut();
				}
			}
		}
		double num4 = (someoneNear ? 1.0 : 0.0);
		if ((double)open == num4 && speed == 0f)
		{
			return;
		}
		float num5 = openTime;
		float num6 = openTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		if (num6 < 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			num5 = 0f;
		}
		double num7;
		if (!someoneNear)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			num7 = 0.0;
		}
		else
		{
			num7 = 1.0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC00]");
		float num8 = 0f / num5;
		double num9;
		if (!someoneNear)
		{
			num9 = 2.0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
			num9 = 0.0;
		}
		float deltaTime = Time.deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		double num10 = num7 * (double)num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v9+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		double num11 = num10 * num10;
		double num12 = num9 * num10;
		float num13 = deltaTime - 1f;
		bool flag11 = num13 < 0f;
		bool flag12 = num13 == 0f;
		object obj20 = deltaTime ^ 1;
		object obj21 = deltaTime ^ num13;
		object obj22 = obj20 & obj21;
		bool flag13 = (nint)obj22 < 0;
		bool flag14 = flag11 == flag13;
		object obj23 = !flag12;
		object obj24 = flag14 & obj23;
		object obj25 = ~obj24;
		float num14 = ((obj25 != null) ? 1f : deltaTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num15 = 0f / num14;
		float num16 = open;
		float num17 = speed;
		float num18 = default;
		num17 = num18;
		float num19 = default;
		num16 = num19;
		float num20 = default;
		num14 = num20;
		do
		{
			double num21 = num4 - (double)num16;
			double num22 = num12 * (double)num17;
			num14--;
			double num23 = num11 * num21;
			double num24 = num23 - num22;
			float num25 = num15 * (float)num24;
			num17 += num25;
			float num26 = num15 * num17;
			num16 += num26;
		}
		while (num14 != 1f);
		open = num16;
		speed = num17;
		if (num16 < 0f)
		{
			open = 0f;
			num17 = 0f;
			num16 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num27 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA9C]");
		if (num27 < 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			float num28 = num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			if (num28 < 0f)
			{
				open = (float)num4;
				speed = 0f;
			}
		}
		Transform transform = base.transform;
		float angle = openAngle * open;
		Vector3 axis = default;
		Quaternion quaternion = Quaternion.Internal_AngleAxis(angle, ref axis);
		transform.localRotation = (Quaternion)0;
	}

	private bool Near()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_037c: Expected I4, but got Obj
		//IL_00b8: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I
		//IL_0207: Expected Obj, but got VT
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_028d: Invalid comparison between Obj and F4
		//IL_015f: Expected VT, but got I4
		//IL_0173: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I
		//IL_02c8: Expected VT, but got I4
		//IL_0315: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			goto IL_02f7;
		}
		Transform transform = base.transform;
		Vector3 vector;
		object obj7;
		object obj8;
		if ((object)transform != null)
		{
			Transform parent = transform.parent;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(parent != null))
			{
				vector = middle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+28]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+2C]");
				obj8 = 0;
				goto IL_03bd;
			}
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Transform parent2 = transform2.parent;
				if ((object)parent2 != null)
				{
					Vector3 vector2 = parent2.TransformPoint((Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+2C]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+28]");
					obj7 = 0;
					vector = middle;
					goto IL_03bd;
				}
			}
		}
		goto IL_036e;
		IL_02f7:
		return false;
		IL_03bd:
		if ((object)main != null)
		{
			Transform transform3 = main.transform;
			if ((object)transform3 != null)
			{
				Vector3 position = transform3.position;
				object obj9 = middle - vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+28]");
				object obj10 = 0 - obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+2C]");
				object obj11 = 0 - obj8;
				object obj12 = obj9 * obj9;
				object obj13 = obj10 * obj10;
				object obj14 = obj12 + obj13;
				object obj15 = obj11 * obj11;
				object obj16 = obj15 + obj14;
				float num = reach * reach;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num))
				{
					goto IL_02f7;
				}
				if (~(moderatorsOnly ? 1u : 0u) != 0 || Beyond((Vector3)0))
				{
					return true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F30]");
				object obj17 = 0;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v27+E4]");
				bool flag5 = (nint)0 == 0;
				object obj19 = !flag5;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj18 = obj17;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v27+A0]");
				object obj20 = 0;
				object obj21 = obj20;
				if (obj20 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v202 @ X8_v11+18] (should have been resolved before IL gen)");
				}
			}
		}
		goto IL_036e;
		IL_036e:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool Beyond(Vector3 at)
	{
		//IL_020c: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_008f: Expected VT, but got I4
		//IL_0248: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_0114: Expected VT, but got I4
		//IL_0121: Expected VT, but got I4
		Transform transform = base.transform;
		object obj4;
		object obj6;
		object obj8;
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Transform parent = transform.parent;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = parent != null;
			bool flag3 = !flag2;
			Vector3 vector = (Vector3)0;
			object obj5 = default;
			obj4 = obj5;
			object obj7 = default;
			obj6 = obj7;
			object obj9 = default;
			obj8 = obj9;
			if (flag3)
			{
				goto IL_0238;
			}
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Transform parent2 = transform2.parent;
				if ((object)parent2 != null)
				{
					Vector3 vector2 = parent2.InverseTransformPoint((Vector3)0);
					vector = (Vector3)0;
					obj4 = obj5;
					obj6 = obj7;
					obj8 = obj9;
					goto IL_0238;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0238:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		object obj13 = default;
		object obj14;
		object obj15;
		if ((nint)obj13 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Vector3 vector3 = openSide;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			obj14 = vector3 / 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+44]");
			obj15 = 0 / obj13;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v17+A0]");
			object obj18 = 0;
			obj14 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v18+8]");
			obj15 = 0;
		}
		object obj19 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+28]");
		object obj20 = obj19 - 0;
		object obj21 = obj4 - middle;
		object obj22 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+2C]");
		object obj23 = obj22 - 0;
		object obj24 = obj21 * obj14;
		object obj26 = default;
		object obj25 = obj20 * obj26;
		object obj27 = obj23 * obj15;
		object obj28 = obj24 + obj25;
		object obj29 = obj27 + obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAA0]");
		object obj30 = obj29 - 0;
		return (nint)obj30 < 0;
	}

	private void KeepOut()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_0297: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I
		//IL_0144: Expected VT, but got I4
		//IL_0189: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I4
		//IL_01ee: Expected VT, but got I4
		//IL_0202: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
		bool flag5 = (UnityEngine.Object)0 == null;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+A9]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v13+A0]");
		object obj15 = 0;
		bool flag8 = obj15 == null;
		object obj16 = !flag8;
		if (obj16 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
		Vector3 position = ((Transform)0).position;
		if (InStaffRoom((Vector3)0))
		{
			((KillCam)obj5).SendHome();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
			Vector3 position2 = ((Transform)0).position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v21+E4]");
			bool flag9 = (nint)0 == 0;
			object obj19 = !flag9;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int hand = GillaToast.NearerHand((Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F58]");
			object title = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F60]");
			object line = 0;
			GillaToast.Show(hand, (string)title, (string)line, error: true);
		}
	}

	public unsafe bool InStaffRoom(Vector3 at)
	{
		//IL_04e2: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected I4, but got Unknown
		//IL_01db: Expected VT, but got I4
		//IL_0123: Expected VT, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected VT, but got Unknown
		//IL_013f: Expected Ref, but got VT
		//IL_068f: Expected Obj, but got I
		//IL_06b9: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got VT
		//IL_0221: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected Obj, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got Unknown
		//IL_0703: Expected Obj, but got I
		//IL_0537: Unsupported input type for neg.
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected Obj, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected Obj, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected Obj, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected Obj, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_0773: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I
		//IL_0367: Expected Obj, but got I
		//IL_062c: Invalid comparison between Obj and F8
		//IL_063e: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I4
		//IL_0409: Expected Obj, but got I4
		//IL_0665: Expected Obj, but got I4
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected Obj, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		Transform transform = base.transform;
		object obj4;
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Transform parent = transform.parent;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (parent == null)
			{
				obj4 = 0;
				goto IL_0509;
			}
			bool flag2 = (byte)(~(hasBlock ? 1u : 0u)) != 0;
			object obj5 = 0;
			if (flag2)
			{
				goto IL_017c;
			}
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Transform parent2 = transform2.parent;
				if ((object)parent2 != null)
				{
					Vector3 vector = parent2.InverseTransformPoint((Vector3)0);
					Bounds bounds = (Bounds)(this + 120);
					Vector3 point = default;
					bool flag3 = ((Bounds*)bounds)->Internal_Contains(ref point);
					bool flag4 = !flag3;
					obj5 = 0;
					if (flag4)
					{
						goto IL_017c;
					}
					obj4 = 1;
					goto IL_0509;
				}
			}
		}
		goto IL_04d4;
		IL_017c:
		Transform transform3 = base.transform;
		if ((object)transform3 != null)
		{
			Transform parent3 = transform3.parent;
			if ((object)parent3 != null)
			{
				Vector3 vector2 = parent3.InverseTransformPoint((Vector3)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v19+E4]");
				bool flag5 = (nint)0 == 0;
				object obj8 = !flag5;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj9 = openSide * openSide;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+40]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+40]");
				object obj10 = num * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj11 = 0;
				object obj12 = obj9 + obj10;
				object obj14 = default;
				object obj13 = obj12 + obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				object obj15;
				object obj16;
				if ((nint)obj13 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Vector3 vector3 = openSide;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					obj15 = vector3 / 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+44]");
					obj16 = 0 / obj13;
				}
				else
				{
					object obj17 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v32+A0]");
					object obj18 = 0;
					obj15 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v33+8]");
					obj16 = 0;
				}
				object obj19 = obj11;
				object obj21 = default;
				object obj20 = obj21 - middle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+28]");
				object obj23 = default;
				object obj22 = obj23 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v16+A0]");
				object obj24 = 0;
				object obj26 = default;
				object obj25 = obj26 * obj22;
				object obj27 = 0 - obj25;
				object obj28 = obj20 * obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v17+20]");
				object obj29 = obj26 * 0;
				object obj30 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v17+1C]");
				object obj31 = obj30 * 0;
				object obj32 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v17+18]");
				object obj33 = obj32 * 0;
				object obj34 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v17+20]");
				object obj35 = obj34 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaProximityDoor)+2C]");
				object obj37 = default;
				object obj36 = obj37 - 0;
				object obj38 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v17+1C]");
				object obj39 = obj38 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v17+18]");
				object obj40 = obj26 * 0;
				object obj41 = obj27 - obj28;
				object obj42 = obj36 * obj16;
				object obj43 = obj6;
				object obj44 = obj29 - obj31;
				object obj45 = obj33 - obj35;
				object obj46 = obj39 - obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v24+E4]");
				bool flag6 = (nint)0 == 0;
				object obj47 = !flag6;
				if (obj47 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				object obj48 = obj41 - obj42;
				object obj49 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				object obj50;
				object obj51;
				object obj52;
				if ((nint)obj49 > 0)
				{
					obj50 = obj44 / obj15;
					obj51 = obj45 / obj15;
					obj52 = obj46 / obj15;
				}
				else
				{
					object obj53 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v27+A0]");
					object obj54 = 0;
					obj50 = obj54;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v28+4]");
					obj51 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v28+8]");
					obj52 = 0;
				}
				bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.5);
				obj4 = 0;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E0]");
					bool flag8 = (nint)obj48 >= 0;
					obj4 = 0;
					if (!flag8)
					{
						object obj55 = obj20 * obj50;
						object obj56 = obj22 * obj51;
						object obj57 = obj55 + obj56;
						object obj58 = obj36 * obj52;
						object obj59 = obj58 + obj57;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						bool flag9 = (nint)obj59 >= 0;
						obj4 = 0;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
							bool flag10;
							bool flag11;
							bool flag12;
							if ((nint)obj22 < 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE78]");
								object obj60 = obj22 - 0;
								flag10 = (nint)obj60 < 0;
								flag11 = obj60 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE78]");
								object obj61 = obj22 ^ 0;
								object obj62 = obj22 ^ obj60;
								object obj63 = obj61 & obj62;
								flag12 = (nint)obj63 < 0;
							}
							else
							{
								flag12 = false;
								flag11 = true;
								flag10 = false;
							}
							bool flag13 = flag10 == flag12;
							object obj64 = !flag11;
							object obj65 = flag13 & obj64;
							obj4 = obj65;
						}
					}
				}
				goto IL_0509;
			}
		}
		goto IL_04d4;
		IL_04d4:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0509:
		return (byte)(obj4 & 1) != 0;
	}

	public GillaProximityDoor()
	{
		//IL_001d: Expected F4, but got I
		//IL_0032: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_005c: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BF90]");
		reach = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v6+A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v7+48]");
		openSide = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v7+50]");
		_ = 0;
		base._002Ector();
	}

	static GillaProximityDoor()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00c0: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F28]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F68]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F30]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<bool> func = default;
		func._002Ector(obj7, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+A0]");
		object obj9 = 0;
		obj9 = func;
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
