using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class ApeAvatarDriver : MonoBehaviour
{
	public Transform headTarget;

	public Transform leftHandTarget;

	public Transform rightHandTarget;

	public Transform headBone;

	public Transform eyeL;

	public Transform eyeR;

	public Transform upperArmL;

	public Transform forearmL;

	public Transform handL;

	public Transform upperArmR;

	public Transform forearmR;

	public Transform handR;

	public Transform indexL;

	public Transform pinkieL;

	public Transform indexR;

	public Transform pinkieR;

	public float eyeBack;

	public float turnSmoothing;

	public float bodyTiltFollow = 1f;

	[NonSerialized]
	public bool turnHeld;

	public const float HeldNeckTwist = default(float);

	public float maxStretch;

	public float elbowFollowsHand;

	public float forearmTwist;

	public float handScale;

	public float handPitch;

	public float gripDepth;

	public float handDepth;

	public Vector3 handRotTrimL;

	public Vector3 handRotTrimR;

	public Vector3 palmSurfaceL;

	public Vector3 palmSurfaceR;

	private Vector3 headOffset;

	private Quaternion headRotOffset;

	private Quaternion handOffsetL;

	private Quaternion handOffsetR;

	private Vector3 palmLocalL;

	private Vector3 palmLocalR;

	private Vector3 palmDirL;

	private Vector3 palmDirR;

	private Quaternion restUpperL;

	private Quaternion restLowerL;

	private Quaternion restHandL;

	private Quaternion restUpperR;

	private Quaternion restLowerR;

	private Quaternion restHandR;

	private Vector3 restLowerPosL;

	private Vector3 restLowerPosR;

	private Vector3 restHandPosL;

	private Vector3 restHandPosR;

	private Vector3 restUpperScaleL;

	private Vector3 restUpperScaleR;

	private Vector3 restLowerScaleL;

	private Vector3 restLowerScaleR;

	private int axisL;

	private int axisR;

	private Vector3 poleL;

	private Vector3 poleR;

	private float twistL;

	private float twistR;

	private float yaw;

	private float headYaw;

	private Quaternion tilt;

	private bool ready;

	public float BodyYaw => yaw;

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I4
		//IL_004c: Expected VT, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_00ac: Expected VT, but got I4
		//IL_00b5: Expected VT, but got I4
		//IL_014d: Expected VT, but got I4
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
		bool flag2 = handL != null;
		bool flag3 = !flag2;
		Vector3 vector = (Vector3)0;
		if (!flag3)
		{
			Vector3 localScale = handL.localScale;
			float num = num * handScale;
			float num2 = num2 * handScale;
			float num3 = num3 * handScale;
			handL.localScale = (Vector3)0;
			vector = (Vector3)0;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (handR != null)
		{
			Vector3 localScale2 = handR.localScale;
			handR.localScale = (Vector3)0;
		}
	}

	private unsafe void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0bea: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_0265: Expected VT, but got I4
		//IL_0265: Expected VT, but got I4
		//IL_029e: Expected VT, but got I4
		//IL_029e: Expected VT, but got I4
		//IL_02b1: Expected VT, but got F4
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0359: Expected Obj, but got VT
		//IL_037a: Expected Obj, but got VT
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_03fa: Expected Obj, but got F8
		//IL_041c: Expected Obj, but got I4
		//IL_054e: Expected Obj, but got I4
		//IL_04a6: Expected Obj, but got I
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected VT, but got Unknown
		//IL_04cb: Expected Obj, but got I
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected Ref, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Ref, but got Unknown
		//IL_0688: Expected Obj, but got I4
		//IL_05e0: Expected Obj, but got I
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected VT, but got Unknown
		//IL_0605: Expected Obj, but got I
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected Ref, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Ref, but got Unknown
		//IL_0c22: Expected Obj, but got I4
		//IL_06f0: Expected VT, but got F8
		//IL_0c5a: Expected Obj, but got I4
		//IL_071d: Expected VT, but got F8
		//IL_078b: Expected VT, but got F8
		//IL_0c92: Expected Obj, but got I4
		//IL_07b8: Expected VT, but got F8
		//IL_084e: Expected VT, but got F8
		//IL_07e0: Expected VT, but got F8
		//IL_0cca: Expected Obj, but got I4
		//IL_087b: Expected VT, but got F8
		//IL_08e9: Expected VT, but got F8
		//IL_0d02: Expected Obj, but got I4
		//IL_0916: Expected VT, but got F8
		//IL_0984: Expected VT, but got F8
		//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Expected Obj, but got Unknown
		//IL_0d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d84: Expected Obj, but got Unknown
		//IL_0d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d99: Expected Obj, but got Unknown
		//IL_0dce: Expected Obj, but got I4
		//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddb: Expected Obj, but got Unknown
		//IL_0de9: Expected I4, but got Obj
		//IL_09b1: Expected VT, but got F8
		//IL_0a42: Expected VT, but got F8
		//IL_09d9: Expected VT, but got F8
		//IL_0e42: Expected Obj, but got I4
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Expected Obj, but got Unknown
		//IL_0ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Expected Obj, but got Unknown
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected Obj, but got Unknown
		//IL_0a6f: Expected VT, but got F8
		//IL_0e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e70: Expected Obj, but got Unknown
		//IL_0ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea5: Expected Obj, but got Unknown
		//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Expected Obj, but got Unknown
		//IL_0ef9: Expected Obj, but got I4
		//IL_0f01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f06: Expected Obj, but got Unknown
		//IL_0f14: Expected I4, but got Obj
		//IL_0f59: Expected Obj, but got I4
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected Obj, but got Unknown
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected Obj, but got Unknown
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = headBone == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = headTarget == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v12+E4]");
				bool flag7 = (nint)0 == 0;
				object obj9 = !flag7;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = eyeL == null;
				bool flag9 = !flag8;
				object obj10 = !flag9;
				if (obj10 == null)
				{
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v16+E4]");
					bool flag10 = (nint)0 == 0;
					object obj12 = !flag10;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!(eyeR == null))
					{
						Transform transform = base.transform;
						Vector3 eulerAngles = transform.eulerAngles;
						float num = default;
						headYaw = num;
						yaw = num;
						float num2 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
						float num3 = num2 * 0f;
						Vector3 euler = default;
						Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
						Vector3 position = eyeL.position;
						Vector3 position2 = eyeR.position;
						Vector3 vector = (Quaternion)0 * (Vector3)0;
						Quaternion rotation = default;
						Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation);
						Vector3 position3 = headBone.position;
						Vector3 vector2 = (Quaternion)0 * (Vector3)0;
						headOffset = (Vector3)num3;
						Quaternion rotation2 = default;
						Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation2);
						Quaternion rotation3 = headBone.rotation;
						object obj13 = this + 264;
						object obj14 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction TRN2 not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
						Vector3 vector3 = default;
						object obj16 = default;
						object obj15 = vector3 * obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						object obj17 = vector3 * vector3;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
						object obj18 = vector3 * vector3;
						object obj19 = obj15 + obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
						object obj20 = obj15 - obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
						object obj21 = obj19 + obj18;
						object obj22 = obj20 - obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
						object obj23 = obj18 * vector3;
						double num4 = (double)obj21 - (double)obj23;
						obj13 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v43+E4]");
						bool flag11 = (nint)0 == 0;
						object obj24 = !flag11;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag12 = handL != null;
						bool flag13 = !flag12;
						Vector3 vector4 = vector3;
						Transform transform2 = null;
						Transform transform3 = null;
						ref Quaternion reference = default;
						ref Vector3 reference2 = default;
						ref Vector3 palmDir = default;
						if (!flag13)
						{
							transform2 = indexL;
							Transform transform4 = pinkieL;
							vector4 = palmSurfaceL;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+E8]");
							obj22 = 0;
							Vector3 surface = (Vector3)(this + 280);
							transform3 = handL;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+EC]");
							obj18 = 0;
							reference = ref *(Quaternion*)(this + 312);
							reference2 = ref *(Vector3*)(this + 336);
							CalibrateHand(handL, indexL, pinkieL, 1f, surface, out reference, out reference2, out palmDir);
							num4 = 1.0;
						}
						object obj25 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v48+E4]");
						bool flag14 = (nint)0 == 0;
						object obj26 = !flag14;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag15 = handR != null;
						bool flag16 = !flag15;
						ref Vector3 reference3 = ref reference2;
						ref Quaternion reference4 = ref reference;
						Transform transform5 = null;
						Transform transform6 = null;
						if (!flag16)
						{
							transform5 = indexR;
							Transform transform4 = pinkieR;
							vector4 = palmSurfaceR;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+F4]");
							obj22 = 0;
							Vector3 surface = (Vector3)(this + 296);
							transform6 = handR;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+F8]");
							obj18 = 0;
							CalibrateHand(handR, indexR, pinkieR, -1f, surface, out *(Quaternion*)(this + 324), out *(Vector3*)(this + 348), out palmDir);
							num4 = -1.0;
						}
						object obj27 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v53+E4]");
						bool flag17 = (nint)0 == 0;
						object obj28 = !flag17;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag18 = upperArmL != null;
						bool flag19 = !flag18;
						UnityEngine.Object obj29 = null;
						if (!flag19)
						{
							Quaternion localRotation = upperArmL.localRotation;
							restUpperL = (Quaternion)num4;
							Vector3 localScale = upperArmL.localScale;
							restUpperScaleL = (Vector3)num4;
							obj29 = null;
						}
						object obj30 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v58+E4]");
						bool flag20 = (nint)0 == 0;
						object obj31 = !flag20;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag21 = forearmL != null;
						bool flag22 = !flag21;
						UnityEngine.Object obj32 = null;
						if (!flag22)
						{
							Quaternion localRotation2 = forearmL.localRotation;
							restLowerL = (Quaternion)num4;
							Vector3 localPosition = forearmL.localPosition;
							restLowerPosL = (Vector3)num4;
							Vector3 localScale2 = forearmL.localScale;
							restLowerScaleL = (Vector3)num4;
							obj32 = null;
						}
						object obj33 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X0_v63+E4]");
						bool flag23 = (nint)0 == 0;
						object obj34 = !flag23;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag24 = handL != null;
						bool flag25 = !flag24;
						UnityEngine.Object obj35 = null;
						if (!flag25)
						{
							Quaternion localRotation3 = handL.localRotation;
							restHandL = (Quaternion)num4;
							Vector3 localPosition2 = handL.localPosition;
							restHandPosL = (Vector3)num4;
							obj35 = null;
						}
						object obj36 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v68+E4]");
						bool flag26 = (nint)0 == 0;
						object obj37 = !flag26;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag27 = upperArmR != null;
						bool flag28 = !flag27;
						UnityEngine.Object obj38 = null;
						if (!flag28)
						{
							Quaternion localRotation4 = upperArmR.localRotation;
							restUpperR = (Quaternion)num4;
							Vector3 localScale3 = upperArmR.localScale;
							restUpperScaleR = (Vector3)num4;
							obj38 = null;
						}
						object obj39 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v73+E4]");
						bool flag29 = (nint)0 == 0;
						object obj40 = !flag29;
						if (obj40 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag30 = forearmR != null;
						bool flag31 = !flag30;
						UnityEngine.Object obj41 = null;
						if (!flag31)
						{
							Quaternion localRotation5 = forearmR.localRotation;
							restLowerR = (Quaternion)num4;
							Vector3 localPosition3 = forearmR.localPosition;
							restLowerPosR = (Vector3)num4;
							Vector3 localScale4 = forearmR.localScale;
							restLowerScaleR = (Vector3)num4;
							obj41 = null;
						}
						object obj42 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v78+E4]");
						bool flag32 = (nint)0 == 0;
						object obj43 = !flag32;
						if (obj43 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (handR != null)
						{
							Quaternion localRotation6 = handR.localRotation;
							restHandR = (Quaternion)num4;
							Vector3 localPosition4 = handR.localPosition;
							restHandPosR = (Vector3)num4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1D0]");
						object obj44 = 0 - restLowerPosL;
						bool flag33 = (nint)obj44 < 0;
						bool flag34 = obj44 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1D0]");
						object obj45 = 0 ^ restLowerPosL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1D0]");
						object obj46 = 0 ^ obj44;
						object obj47 = obj45 & obj46;
						bool flag35 = (nint)obj47 < 0;
						bool flag36 = flag33 == flag35;
						object obj48 = !flag34;
						object obj49 = flag36 & obj48;
						int num5 = obj49 << 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1CC]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1D0]");
						bool flag37;
						bool flag38;
						if (num6 >= 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1CC]");
							object obj50 = 0 - restLowerPosL;
							flag37 = (nint)obj50 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1CC]");
							object obj51 = 0 ^ restLowerPosL;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1CC]");
							object obj52 = 0 ^ obj50;
							object obj53 = obj51 & obj52;
							flag38 = (nint)obj53 < 0;
						}
						else
						{
							flag38 = false;
							flag37 = true;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						bool flag39 = flag37 == flag38;
						object obj54 = !flag39;
						object obj55 = ~obj54;
						if (obj55 != null)
						{
							num5 = 1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1DC]");
						object obj56 = 0 - restLowerPosR;
						bool flag40 = (nint)obj56 < 0;
						bool flag41 = obj56 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1DC]");
						object obj57 = 0 ^ restLowerPosR;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1DC]");
						object obj58 = 0 ^ obj56;
						object obj59 = obj57 & obj58;
						bool flag42 = (nint)obj59 < 0;
						axisL = num5;
						bool flag43 = flag40 == flag42;
						object obj60 = !flag41;
						object obj61 = flag43 & obj60;
						int num7 = obj61 << 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1D8]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1DC]");
						bool flag44;
						bool flag45;
						if (num8 >= 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1D8]");
							object obj62 = 0 - restLowerPosR;
							flag44 = (nint)obj62 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1D8]");
							object obj63 = 0 ^ restLowerPosR;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1D8]");
							object obj64 = 0 ^ obj62;
							object obj65 = obj63 & obj64;
							flag45 = (nint)obj65 < 0;
						}
						else
						{
							flag45 = false;
							flag44 = true;
						}
						bool flag46 = flag44 == flag45;
						object obj66 = !flag46;
						object obj67 = ~obj66;
						int num9 = ((obj67 != null) ? 1 : num7);
						axisR = num9;
						ready = true;
						return;
					}
				}
			}
		}
		enabled = false;
	}

	private unsafe void CalibrateHand(Transform hand, Transform index1, Transform pinkie1, float palmSide, Vector3 surface, out Quaternion offset, out Vector3 palmLocal, out Vector3 palmDir)
	{
		//IL_06da: Expected Obj, but got I
		//IL_06f2: Expected Obj, but got I
		//IL_0702: Expected Obj, but got I
		//IL_070f: Expected F4, but got Obj
		//IL_070a: Expected native int or pointer, but got VT
		//IL_04e2: Expected Obj, but got I
		//IL_04fa: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_00d0: Invalid comparison between F4 and I4
		//IL_00df: Invalid comparison between F4 and I4
		//IL_00f2: Expected Obj, but got F4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected I4, but got Unknown
		//IL_0188: Expected VT, but got I4
		//IL_0188: Expected VT, but got I4
		//IL_019b: Expected VT, but got I4
		//IL_019b: Expected VT, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected VT, but got Unknown
		//IL_0586: Expected VT, but got I4
		//IL_0586: Expected VT, but got I4
		//IL_02de: Expected native int or pointer, but got VT
		//IL_02f2: Expected VT, but got I4
		//IL_02f2: Expected VT, but got I4
		//IL_05bd: Expected Obj, but got I
		//IL_05e7: Expected Obj, but got I4
		//IL_060d: Expected Obj, but got I
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected Obj, but got Unknown
		//IL_069b: Invalid comparison between F8 and I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_03a9: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Obj, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_04a7: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		((Vector3*)(nint)surface)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v11+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+8]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+4]");
		_ = 0;
		ref Quaternion reference2 = ref *(Quaternion*)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+4]");
		_ = 0;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = index1 == null;
		bool flag3 = !flag2;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			return;
		}
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = pinkie1 == null;
		bool flag6 = !flag5;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			bool flag7 = palmSide < 0f;
			bool flag8 = palmSide == 0f;
			object obj14 = palmSide ^ palmSide;
			object obj15 = palmSide & obj14;
			bool flag9 = (nint)obj15 < 0;
			bool flag10 = flag7 == flag9;
			object obj16 = !flag8;
			bool left = (byte)((flag10 & obj16) ? 1 : 0) != 0;
			HandFrame(hand, index1, pinkie1, left, out var _, out var palm, out var knuckles);
			Quaternion rotation = hand.rotation;
			Quaternion rotation2 = default;
			Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
			Vector3 vector = (Quaternion)0 * (Vector3)0;
			Vector3 vector2 = (Quaternion)0 * (Vector3)0;
			Vector3 forward = default;
			Vector3 upwards = default;
			Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
			float num = handPitch;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			Vector3 vector3 = (Vector3)(num * 0);
			Vector3 euler = default;
			Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(ref euler);
			Vector3 vector4 = (Quaternion)0 * (Vector3)0;
			Vector3 forward2 = default;
			Quaternion quaternion4 = Quaternion.Internal_LookRotation(ref forward2, ref upwards);
			Quaternion quaternion5 = Quaternion.Internal_Inverse(ref rotation2);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction TRN2 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
			object obj18 = default;
			object obj17 = obj7 * obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			double num3 = default;
			double num2 = num3 * (double)vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
			double num4 = (double)obj7 * num3;
			double num5 = (double)obj17 + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
			double num6 = num5 + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			double num7 = num4 * (double)obj7;
			float x = (float)num6 - (float)num7;
			((Vector3*)(nint)surface)->x = x;
			Vector3 vector5 = (Quaternion)0 * (Vector3)0;
			reference = ref *(Vector3*)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+8]");
			_ = 0;
			Vector3 position = hand.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v39+E4]");
			bool flag11 = (nint)0 == 0;
			object obj21 = !flag11;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj22 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v28+A0]");
			object obj23 = 0;
			double num8 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v29+8]");
			double num9 = num8 - 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v29+4]");
			object obj25 = default;
			object obj24 = obj25 - 0;
			object obj27 = default;
			object obj26 = obj27 - obj23;
			object obj28 = obj26 * obj26;
			object obj29 = obj24 * obj24;
			object obj30 = obj28 + obj29;
			double num10 = num9 * num9;
			double num11 = num10 + (double)obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
			bool flag12 = !(num11 < 0.0);
			object obj31 = obj27;
			object obj32 = obj25;
			double num12 = num3;
			if (!flag12)
			{
				object obj33 = obj7 - knuckles;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+4]");
				object obj35 = default;
				object obj34 = 0 - obj35;
				object obj36 = obj33 * obj33;
				object obj37 = obj34 * obj34;
				object obj38 = obj36 + obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+8]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+8]");
				object obj39 = num13 * 0;
				object obj40 = obj39 + obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Vector3 position2 = hand.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+8]");
				object obj41 = -0;
				object obj42 = knuckles - obj40;
				double num14 = (double)obj41 * 0.5;
				object obj43 = obj40 * 0;
				object obj44 = obj42 * 63;
				object obj46 = default;
				object obj45 = palm * obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+8]");
				double num15 = 0.0 + num14;
				object obj47 = obj40 + obj44;
				object obj48 = obj45 * palm;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
				object obj49 = obj43 * 0;
				object obj50 = obj48 + obj47;
				double num16 = num15 + (double)obj49;
				Vector3 vector6 = hand.InverseTransformPoint((Vector3)0);
				obj31 = obj50;
				object obj51 = default;
				obj32 = obj51;
				num12 = num16;
			}
			reference2 = ref *(Quaternion*)obj31;
		}
	}

	public unsafe static void HandFrame(Transform hand, Transform index1, Transform pinkie1, bool left, out Vector3 finger, out Vector3 palm, out Vector3 knuckles)
	{
		//IL_008a: Expected Ref, but got F8
		//IL_065d: Expected Obj, but got I
		//IL_0696: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		//IL_014d: Expected F8, but got Obj
		//IL_015d: Expected F8, but got I
		//IL_016d: Expected F8, but got I
		//IL_046d: Expected Ref, but got F8
		//IL_04ad: Expected Obj, but got VT
		//IL_04ca: Expected Obj, but got I
		//IL_04da: Expected Obj, but got I
		//IL_0539: Expected Obj, but got I
		//IL_0549: Expected Obj, but got I
		//IL_0560: Expected F8, but got Obj
		//IL_0568: Invalid comparison between F8 and Obj
		//IL_06d3: Expected Obj, but got I4
		//IL_02c9: Invalid comparison between F8 and I
		//IL_0322: Expected Obj, but got I
		//IL_033a: Expected Obj, but got I
		//IL_0342: Expected F8, but got Obj
		//IL_0352: Expected F8, but got I
		//IL_0362: Expected F8, but got I
		//IL_05f2: Expected Obj, but got I4
		//IL_0390: Invalid comparison between F8 and I
		//IL_03e9: Expected Obj, but got I
		//IL_0401: Expected Obj, but got I
		//IL_0409: Expected F8, but got Obj
		//IL_0419: Expected F8, but got I
		//IL_0429: Expected F8, but got I
		//IL_0608: Expected Ref, but got F8
		//IL_0437: Expected Obj, but got F8
		//IL_0440: Expected Obj, but got F8
		//IL_0449: Expected Obj, but got F8
		Vector3 position = index1.position;
		Vector3 position2 = pinkie1.position;
		object obj2 = default;
		object obj = obj2 + obj2;
		object obj4 = default;
		object obj3 = obj4 + obj4;
		object obj6 = default;
		object obj5 = obj6 + obj6;
		double num = (double)obj * 0.5;
		double num2 = (double)obj3 * 0.5;
		double num3 = (double)obj5 * 0.5;
		ref Vector3 reference = ref *(Vector3*)num;
		Vector3 position3 = hand.position;
		double num4 = num - (double)obj;
		double num5 = num2 - (double)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj7 = 0;
		double num6 = num3 - (double)obj5;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		double num7;
		double num8;
		double num9;
		if ((nint)obj5 > 0)
		{
			num7 = num4 / (double)obj5;
			num8 = num5 / (double)obj5;
			num9 = num6 / (double)obj5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v41+A0]");
			object obj12 = 0;
			num7 = (double)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v42+4]");
			num8 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v42+8]");
			num9 = 0.0;
		}
		ref Vector3 reference2 = ref *(Vector3*)num7;
		Vector3 position4 = index1.position;
		Vector3 position5 = pinkie1.position;
		object obj13 = finger * finger;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+4]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+4]");
		object obj14 = num10 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj15 = 0;
		double num11 = num8 - num8;
		double num12 = num9 - num9;
		object obj16 = obj15;
		double num13 = num7 - num7;
		object obj17 = obj13 + obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+8]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+8]");
		object obj18 = num14 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v12+A0]");
		object obj19 = 0;
		double num15 = (double)obj18 + (double)obj17;
		double num16 = (double)obj19;
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
		double num17 = 0.5;
		double num18 = num7;
		if (!flag2)
		{
			double num19 = (double)finger * num13;
			double num20 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+4]");
			double num21 = num20 * 0.0;
			double num22 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+8]");
			num17 = num22 * 0.0;
			double num23 = num19 + num21;
			double num24 = num17 + num23;
			double num25 = num24 / num15;
			num16 = (double)finger * num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+4]");
			num18 = 0.0 * num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+8]");
			num15 = 0.0 * num25;
			num13 -= num16;
			num11 -= num18;
			num12 -= num15;
		}
		object obj20 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj21 = !flag3;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num26 = num13 * num13;
		double num27 = num11 * num11;
		double num28 = num26 + num27;
		double num29 = num12 * num12;
		double num30 = num28 + num29;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		double num31;
		double num32;
		double num33;
		if (num30 > 0.0)
		{
			num31 = num13 / num30;
			num32 = num11 / num30;
			num33 = num12 / num30;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj22 = 0;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v34+A0]");
			object obj24 = 0;
			num31 = (double)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v35+4]");
			num32 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v35+8]");
			num33 = 0.0;
		}
		double num34 = num33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+4]");
		double num35 = num34 * 0.0;
		double num36 = num32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+8]");
		double num37 = num36 * 0.0;
		double num38 = num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+8]");
		double num39 = num38 * 0.0;
		double num40 = num33 * (double)finger;
		double num41 = num32 * (double)finger;
		double num42 = num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [finger @ X4 (UnityEngine.Vector3&)+4]");
		double num43 = num42 * 0.0;
		object obj25 = obj7;
		double num44 = num35 - num37;
		double num45 = num39 - num40;
		double num46 = num41 - num43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v24+E4]");
		bool flag4 = (nint)0 == 0;
		object obj26 = !flag4;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double num47 = num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		double num48;
		double num49;
		double num50;
		if (num47 > 0.0)
		{
			num48 = num44 / num18;
			num49 = num45 / num18;
			num50 = num46 / num18;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj27 = 0;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v28+A0]");
			object obj29 = 0;
			num48 = (double)obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v29+4]");
			num49 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v29+8]");
			num50 = 0.0;
		}
		ref Vector3 reference3 = ref *(Vector3*)num48;
		if (left)
		{
			object obj30 = 0.0 - num48;
			object obj31 = 0.0 - num49;
			object obj32 = 0.0 - num50;
			reference3 = ref *(Vector3*)obj30;
		}
	}

	private unsafe void LateUpdate()
	{
		//IL_004f: Expected F8, but got I
		//IL_005f: Invalid comparison between F8 and I
		//IL_00ee: Expected Obj, but got I4
		//IL_0fab: Expected Obj, but got F4
		//IL_0fd9: Invalid comparison between F8 and I
		//IL_0e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e47: Expected VT, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_0dfd: Expected Obj, but got I4
		//IL_0f1c: Expected Obj, but got I
		//IL_0f34: Expected Obj, but got I
		//IL_0f6a: Expected VT, but got F8
		//IL_1000: Expected Obj, but got I
		//IL_102a: Expected Obj, but got I4
		//IL_066c: Expected VT, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I
		//IL_01b3: Expected VT, but got Obj
		//IL_06ab: Expected VT, but got I4
		//IL_06ab: Expected VT, but got I4
		//IL_016a: Expected VT, but got F8
		//IL_0758: Expected VT, but got I4
		//IL_1050: Expected Obj, but got I
		//IL_1097: Expected VT, but got I4
		//IL_07a9: Expected Obj, but got I
		//IL_099d: Expected VT, but got I4
		//IL_09c7: Expected Obj, but got I4
		//IL_0354: Expected F8, but got I4
		//IL_0edb: Invalid comparison between F8 and I4
		//IL_0eea: Expected F8, but got I4
		//IL_0246: Expected F8, but got I4
		//IL_0c04: Expected Obj, but got I4
		//IL_036b: Invalid comparison between F8 and I4
		//IL_037a: Expected F8, but got I4
		//IL_0e79: Invalid comparison between F8 and I4
		//IL_0e92: Expected VT, but got I
		//IL_0ea3: Expected F8, but got I4
		//IL_0a4d: Expected Obj, but got I4
		//IL_10c9: Expected VT, but got I
		//IL_03d9: Expected F8, but got I8
		//IL_025d: Invalid comparison between F8 and I4
		//IL_026c: Expected F8, but got I4
		//IL_0391: Invalid comparison between F8 and I4
		//IL_02cc: Invalid comparison between F8 and I4
		//IL_02df: Expected Obj, but got F8
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_0314: Expected Obj, but got I4
		//IL_0c78: Expected Obj, but got I4
		//IL_0346: Expected F8, but got I4
		//IL_0283: Invalid comparison between F8 and I4
		//IL_0ac7: Expected F4, but got VT
		//IL_0ad7: Expected F8, but got I
		//IL_0ae7: Expected F8, but got I
		//IL_0af7: Expected F4, but got I
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b02: Expected VT, but got Unknown
		//IL_0b0c: Expected F8, but got VT
		//IL_0b1c: Expected F8, but got I
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Expected VT, but got Unknown
		//IL_0b37: Expected F8, but got I
		//IL_0b47: Expected F8, but got I
		//IL_0bd5: Expected Ref, but got VT
		//IL_0bd5: Expected VT, but got I
		//IL_0bd5: Expected I4, but got VT
		//IL_0bd5: Expected F4, but got VT
		//IL_0bd5: Expected VT, but got I
		//IL_0bd5: Expected VT, but got I
		//IL_0bd5: Expected VT, but got I
		//IL_0bd5: Expected VT, but got I4
		//IL_0ecd: Expected F8, but got I8
		//IL_0338: Expected F8, but got I8
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected Obj, but got Unknown
		//IL_0cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Expected Obj, but got Unknown
		//IL_0cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Expected Obj, but got Unknown
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Expected Obj, but got Unknown
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected VT, but got Unknown
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Expected VT, but got Unknown
		//IL_0d8a: Expected Ref, but got VT
		//IL_0d8a: Expected VT, but got I
		//IL_0d8a: Expected I4, but got Obj
		//IL_0d8a: Expected F4, but got VT
		//IL_0d8a: Expected VT, but got I
		//IL_0d8a: Expected VT, but got Obj
		//IL_0d8a: Expected VT, but got I
		//IL_0d8a: Expected VT, but got Obj
		//IL_0d8a: Expected VT, but got I
		//IL_0d8a: Expected VT, but got Obj
		//IL_0d8a: Expected VT, but got I4
		if (~(ready ? 1u : 0u) != 0)
		{
			return;
		}
		Vector3 forward = headTarget.forward;
		object obj = default;
		double num = (double)obj * (double)obj;
		object obj3 = default;
		object obj2 = obj3 * obj3;
		double num2 = num + (double)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		double num3 = 0.0;
		double num4 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		if (num4 < 0.0)
		{
			Vector3 up = headTarget.up;
			Vector3 forward2 = headTarget.forward;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			double num5 = (((nint)0 >= (nint)0) ? (-1.0) : 1.0);
			double num6 = (double)obj * num5;
			double num7 = num * num5;
			double num8 = num6 * num6;
			num3 = num7 * num7;
			num2 = num8 + num3;
			object obj4 = 0;
		}
		else
		{
			object obj4 = 0;
		}
		float deltaTime = Time.deltaTime;
		float num9 = turnSmoothing * deltaTime;
		object obj5 = 0f - num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num10 = 1.0 - (double)obj5;
		double num11 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		Quaternion b;
		Vector3 upwards = default;
		double num12;
		double num13;
		if (!(num11 > 0.0))
		{
			b = (Quaternion)upwards;
			num12 = yaw;
			num13 = 1.0;
			goto IL_0e0c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X0_v67+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		Vector3 vector;
		if ((nint)obj5 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			double num14 = 0.0 / num;
			vector = (Vector3)num14;
		}
		else
		{
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ X8_v54+A0]");
			object obj11 = 0;
			vector = (Vector3)obj11;
		}
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X8_v36+A0]");
		object obj13 = 0;
		Vector3 forward3 = default;
		Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward3, ref upwards);
		Quaternion rotation = default;
		Vector3 vector2 = Quaternion.Internal_ToEulerRad(ref rotation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X8_v37+20]");
		float num15 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
		float num16 = num15 * 0f;
		Vector3 vector3 = Quaternion.Internal_MakePositive((Vector3)0);
		num12 = yaw;
		headYaw = num16;
		float num17 = num16 - yaw;
		float num18 = num17 / 1.13587E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num19 = num18 * 1.13587E+09f;
		num = (double)num17 - (double)num19;
		bool flag2 = num17 < num19;
		if (~(turnHeld ? 1u : 0u) == 0)
		{
			num13 = 0.0;
			if (!flag2)
			{
				bool flag3 = num > 1135869952.0;
				double num20 = 1135869952.0;
				if (!flag3)
				{
					bool flag4 = !(num > 1127481344.0);
					num20 = num;
					num13 = num;
					if (flag4)
					{
						goto IL_0e66;
					}
				}
				num13 = num20 + 3283353600.0;
			}
			goto IL_0e66;
		}
		double num21 = 0.0;
		if (!flag2)
		{
			bool flag5 = num > 1135869952.0;
			double num22 = 1135869952.0;
			if (!flag5)
			{
				bool flag6 = !(num > 1127481344.0);
				num22 = num;
				num21 = num;
				if (flag6)
				{
					goto IL_0ed2;
				}
			}
			num21 = num22 + 3283353600.0;
			num = 3283353600.0;
		}
		goto IL_0ed2;
		IL_10a0:
		num12 += num13;
		yaw = (float)num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X8_v37+18]");
		b = (Quaternion)0;
		forward3 = vector;
		goto IL_0e0c;
		IL_0ed2:
		bool flag7 = num10 < 0.0;
		double num23 = 0.0;
		if (!flag7)
		{
			bool flag8 = !(num10 > 1.0);
			num23 = num10;
			if (!flag8)
			{
				num23 = 1.0;
			}
		}
		num13 = num21 * num23;
		goto IL_10a0;
		IL_0e66:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		bool flag9 = !(num > 1116471296.0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X8_v37+18]");
		b = (Quaternion)0;
		forward3 = vector;
		num21 = 1116471296.0;
		if (flag9)
		{
			goto IL_0e0c;
		}
		bool flag10 = num13 < 0.0;
		object obj14 = num13 ^ num13;
		object obj15 = num13 & obj14;
		bool flag11 = (nint)obj15 < 0;
		bool flag12 = flag10 == flag11;
		object obj16 = !flag12;
		object obj17 = ~obj16;
		num = ((obj17 != null) ? 1116471296.0 : 3263954944.0);
		num13 -= num;
		num21 = 3263954944.0;
		goto IL_10a0;
		IL_0e0c:
		double num24 = num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		double num25 = num24 * 0.0;
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref forward3);
		float num26 = headYaw;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		Quaternion quaternion3 = (Quaternion)(num26 * 0);
		Quaternion quaternion4 = Quaternion.Internal_FromEulerRad(ref forward3);
		Quaternion rotation2 = default;
		Quaternion quaternion5 = Quaternion.Internal_Inverse(ref rotation2);
		Quaternion rotation3 = headTarget.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction TRN2 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		object obj19 = default;
		object obj18 = quaternion3 * obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		double num27 = num21 * (double)quaternion3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		double num28 = (double)quaternion3 * num21;
		double num29 = (double)obj18 + num27;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		double num30 = num29 + num28;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
		double num31 = num28 * (double)quaternion3;
		double num32 = num30 - num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X8_v14+A0]");
		object obj22 = 0;
		Quaternion a = default;
		Quaternion quaternion6 = Quaternion.Internal_Slerp(ref a, ref b, bodyTiltFollow);
		Quaternion a2 = default;
		Quaternion b2 = default;
		Quaternion quaternion7 = Quaternion.Internal_Slerp(ref a2, ref b2, (float)num10);
		tilt = (Quaternion)num10;
		Transform transform = base.transform;
		double num33 = num21 * num32;
		double num34 = num * num28;
		double num35 = num21 * (double)obj22;
		double num36 = num13 * num28;
		float num37 = (float)num21 * (float)num10;
		double num38 = num25 * num28;
		double num39 = num * (double)obj22;
		double num40 = num33 + num34;
		double num41 = num25 * (double)obj22;
		double num42 = num35 + num36;
		float num43 = (float)num * (float)num10;
		float num44 = num37 + (float)num38;
		double num45 = num13 * num32;
		double num46 = num41 + num40;
		float num47 = num43 + (float)num42;
		double num48 = num13 * num10;
		double num49 = num25 * num32;
		double num50 = num45 + (double)num44;
		double num51 = num46 - num48;
		float num52 = num47 - (float)num49;
		double num53 = num50 - num39;
		transform.rotation = (Quaternion)0;
		Transform transform2 = base.transform;
		Vector3 position = transform2.position;
		Vector3 position2 = headTarget.position;
		Vector3 vector4 = (Quaternion)0 * (Vector3)0;
		double num54 = num51 + num51;
		float num55 = num52 + num52;
		double num56 = num53 + num53;
		Vector3 position3 = headBone.position;
		double num57 = num56 - num53;
		float num58 = num55 - num52;
		double num59 = num54 - num51;
		double num60 = num53 + num57;
		double num61 = num51 + num59;
		float num62 = num52 + num58;
		transform2.position = (Vector3)0;
		Quaternion rotation4 = headTarget.rotation;
		float num63 = num52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+114]");
		float num64 = num63 * 0f;
		double num65 = num60 * (double)headRotOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj23 = 0;
		float num66 = num52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+110]");
		float num67 = num66 * 0f;
		double num68 = num61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+114]");
		double num69 = num68 * 0.0;
		float num70 = num52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+10C]");
		float num71 = num70 * 0f;
		float num72 = num62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+114]");
		float num73 = num72 * 0f;
		float num74 = num52 * (float)headRotOffset;
		double num75 = num60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+114]");
		double num76 = num75 * 0.0;
		float num77 = num64 - (float)num65;
		float num78 = num62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+10C]");
		float num79 = num78 * 0f;
		double num80 = num69 + (double)num67;
		double num81 = num60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+10C]");
		double num82 = num81 * 0.0;
		double num83 = num60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+110]");
		double num84 = num83 * 0.0;
		float num85 = num73 + num71;
		double num86 = num61 * (double)headRotOffset;
		double num87 = num76 + (double)num74;
		float num88 = num62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+110]");
		float num89 = num88 * 0f;
		float num90 = num62 * (float)headRotOffset;
		double num91 = num61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+110]");
		double num92 = num91 * 0.0;
		double num93 = num61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+10C]");
		double num94 = num93 * 0.0;
		float num95 = num77 - num79;
		double num96 = num82 + num80;
		double num97 = num86 + (double)num85;
		double num98 = num87 + (double)num89;
		float num99 = num95 - (float)num92;
		double num100 = num96 - (double)num90;
		double num101 = num97 - num84;
		double num102 = num98 - num94;
		headBone.rotation = (Quaternion)0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1251 @ X0_v39+E4]");
		bool flag13 = (nint)0 == 0;
		object obj25 = !flag13;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = handL != null;
		bool flag15 = !flag14;
		Transform transform3 = null;
		float num103 = (float)num102;
		Transform transform4 = null;
		Vector3 restHandPos = default;
		ref float twist = default;
		if (!flag15)
		{
			object obj26 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ X0_v55+E4]");
			bool flag16 = (nint)0 == 0;
			object obj27 = !flag16;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag17 = leftHandTarget != null;
			bool flag18 = !flag17;
			transform3 = null;
			num103 = (float)num102;
			transform4 = null;
			if (!flag18)
			{
				transform4 = upperArmL;
				transform3 = forearmL;
				num103 = (float)restUpperL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+16C]");
				num101 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+170]");
				num100 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+174]");
				num99 = 0f;
				Quaternion restLower = (Quaternion)(this + 560);
				num98 = (double)restLowerL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+17C]");
				num92 = 0.0;
				Quaternion restHand = (Quaternion)(this + 584);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+180]");
				num94 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+184]");
				num96 = 0.0;
				Transform upper = upperArmL;
				Transform lower = forearmL;
				Transform end = handL;
				Transform target = leftHandTarget;
				int num104 = axisL;
				Quaternion restLowerPos = restHandL;
				Vector3 restUpperScale = restLowerPosL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1D0]");
				nint num105 = 0;
				Vector3 handOffset = restHandPosL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1E8]");
				nint num106 = 0;
				Vector3 palmLocal = restUpperScaleL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+200]");
				nint num107 = 0;
				Quaternion quaternion8 = restUpperL;
				Vector3 vector5 = restLowerScaleL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+218]");
				DriveArm(upper, lower, end, target, (Quaternion)num104, restLower, restHand, (Vector3)restLowerPos, restHandPos, restUpperScale, (Vector3)num105, (Quaternion)handOffset, (Vector3)num106, palmLocal, (Vector3)num107, (float)quaternion8, (int)vector5, (Quaternion)0, ref *(Vector3*)handOffsetL, ref twist);
			}
		}
		object obj28 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1341 @ X0_v44+E4]");
		bool flag19 = (nint)0 == 0;
		object obj29 = !flag19;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (handR != null)
		{
			object obj30 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1356 @ X0_v48+E4]");
			bool flag20 = (nint)0 == 0;
			object obj31 = !flag20;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (rightHandTarget != null)
			{
				object obj32 = this + 468;
				object obj33 = this + 492;
				object obj34 = this + 516;
				object obj35 = this + 540;
				Quaternion restLower2 = (Quaternion)(this + 572);
				Quaternion restHand2 = (Quaternion)(this + 588);
				Transform upper2 = upperArmR;
				Transform lower2 = forearmR;
				Transform end2 = handR;
				Transform target2 = rightHandTarget;
				int num108 = axisR;
				Quaternion restLowerPos2 = restHandR;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1DC]");
				nint num109 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+1F4]");
				nint num110 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+20C]");
				nint num111 = 0;
				Quaternion quaternion9 = restUpperR;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeAvatarDriver)+224]");
				DriveArm(upper2, lower2, end2, target2, (Quaternion)num108, restLower2, restHand2, (Vector3)restLowerPos2, restHandPos, (Vector3)obj32, (Vector3)num109, (Quaternion)obj33, (Vector3)num110, (Vector3)obj34, (Vector3)num111, (float)quaternion9, (int)obj35, (Quaternion)0, ref *(Vector3*)handOffsetR, ref twist);
			}
		}
	}

	private unsafe void DriveArm(Transform upper, Transform lower, Transform end, Transform target, Quaternion restUpper, Quaternion restLower, Quaternion restHand, Vector3 restLowerPos, Vector3 restHandPos, Vector3 restUpperScale, Vector3 restLowerScale, Quaternion handOffset, Vector3 trim, Vector3 palmLocal, Vector3 palmDir, float side, int axis, Quaternion body, ref Vector3 pole, ref float twist)
	{
		//IL_000e: Expected VT, but got I4
		//IL_001c: Expected VT, but got I4
		//IL_002f: Expected VT, but got I4
		//IL_003d: Expected VT, but got I4
		//IL_0050: Expected VT, but got I4
		//IL_0063: Expected VT, but got I4
		//IL_0071: Expected VT, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected VT, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_03a7: Expected VT, but got I4
		//IL_03c7: Expected VT, but got I4
		//IL_03d9: Expected VT, but got I4
		//IL_119d: Expected Obj, but got I
		//IL_11c7: Expected Obj, but got I4
		//IL_124c: Expected Obj, but got I4
		//IL_12c5: Expected Obj, but got I4
		//IL_194d: Expected VT, but got I4
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_05a5: Expected VT, but got I4
		//IL_1985: Expected Obj, but got I4
		//IL_12dc: Invalid comparison between VT and I4
		//IL_05e7: Expected Obj, but got I
		//IL_056a: Expected VT, but got I4
		//IL_068f: Expected Obj, but got I
		//IL_0697: Expected VT, but got Obj
		//IL_06a7: Expected F8, but got I
		//IL_06b7: Expected F8, but got I
		//IL_12fe: Expected VT, but got I4
		//IL_1307: Expected VT, but got I4
		//IL_052a: Invalid comparison between VT and I4
		//IL_053b: Expected Obj, but got I4
		//IL_136a: Expected Obj, but got I4
		//IL_1427: Invalid comparison between F8 and I
		//IL_064c: Expected VT, but got Obj
		//IL_057d: Expected VT, but got I4
		//IL_0557: Expected VT, but got I4
		//IL_19ab: Expected Obj, but got I
		//IL_1a22: Invalid comparison between F4 and I
		//IL_1a38: Expected F4, but got VT
		//IL_147b: Expected native int or pointer, but got VT
		//IL_1488: Expected native int or pointer, but got VT
		//IL_1495: Expected native int or pointer, but got VT
		//IL_14fc: Expected VT, but got Obj
		//IL_14fc: Expected VT, but got Obj
		//IL_1465: Expected Obj, but got I4
		//IL_1523: Expected Obj, but got I4
		//IL_1a70: Expected Obj, but got I4
		//IL_1aa8: Expected Obj, but got I4
		//IL_081d: Expected VT, but got F4
		//IL_0873: Expected Obj, but got VT
		//IL_089a: Expected Obj, but got VT
		//IL_08a7: Expected VT, but got Obj
		//IL_08c1: Invalid comparison between VT and I
		//IL_0786: Expected Obj, but got I
		//IL_078e: Expected VT, but got Obj
		//IL_079e: Expected F8, but got I
		//IL_07ae: Expected F8, but got I
		//IL_0902: Expected Obj, but got I
		//IL_090a: Expected VT, but got Obj
		//IL_0769: Expected VT, but got F8
		//IL_1553: Unknown result type (might be due to invalid IL or missing references)
		//IL_1558: Expected Obj, but got Unknown
		//IL_1594: Unknown result type (might be due to invalid IL or missing references)
		//IL_1599: Expected Obj, but got Unknown
		//IL_15ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b3: Expected Obj, but got Unknown
		//IL_15e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e7: Expected Obj, but got Unknown
		//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1601: Expected Obj, but got Unknown
		//IL_1609: Unknown result type (might be due to invalid IL or missing references)
		//IL_160e: Expected Obj, but got Unknown
		//IL_1657: Unknown result type (might be due to invalid IL or missing references)
		//IL_165c: Expected Obj, but got Unknown
		//IL_1664: Unknown result type (might be due to invalid IL or missing references)
		//IL_1669: Expected Obj, but got Unknown
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Expected Obj, but got Unknown
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected Obj, but got Unknown
		//IL_09d3: Expected VT, but got I4
		//IL_09fa: Expected native int or pointer, but got VT
		//IL_0b90: Expected VT, but got I4
		//IL_0c2a: Invalid comparison between F4 and I
		//IL_1179: Expected VT, but got I4
		//IL_1187: Expected VT, but got I4
		//IL_0c48: Expected Obj, but got I4
		//IL_0cc1: Invalid comparison between F4 and I
		//IL_0d5e: Invalid comparison between F4 and I
		//IL_0f48: Expected VT, but got I4
		//IL_16f3: Expected Obj, but got I4
		//IL_0fb3: Invalid comparison between F4 and I
		//IL_0fcc: Expected F4, but got I
		//IL_1124: Unknown result type (might be due to invalid IL or missing references)
		//IL_1129: Expected Obj, but got Unknown
		//IL_1144: Expected VT, but got F4
		//IL_114d: Expected VT, but got F4
		//IL_1009: Expected Obj, but got I4
		//IL_172b: Expected Obj, but got I4
		//IL_1044: Invalid comparison between VT and I4
		//IL_10e2: Expected F4, but got I
		//IL_1747: Expected VT, but got I4
		//IL_1078: Invalid comparison between VT and I4
		//IL_1089: Expected Obj, but got I4
		//IL_110e: Expected F4, but got I
		upper.localRotation = (Quaternion)0;
		upper.localScale = (Vector3)0;
		lower.localRotation = (Quaternion)0;
		lower.localScale = (Vector3)0;
		lower.localPosition = (Vector3)0;
		end.localRotation = (Quaternion)0;
		end.localPosition = (Vector3)0;
		Quaternion rotation = target.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		object obj2 = default;
		object obj = obj2 * 0;
		nint num = default;
		object obj3 = default;
		Vector3 vector = (Vector3)(num * obj3);
		Vector3 euler = default;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		object obj5 = default;
		object obj4 = obj5 * vector;
		object obj6 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref twist) * obj5;
		object obj7 = obj5 * obj5;
		object obj8 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref twist) * vector;
		object obj9 = obj5 * obj;
		object obj11 = default;
		object obj10 = obj11 * obj5;
		object obj12 = obj5 * num;
		object obj14 = default;
		object obj13 = obj14 * obj5;
		object obj15 = obj4 + obj6;
		object obj16 = obj11 * num;
		object obj17 = obj7 - obj8;
		object obj18 = obj11 * obj;
		object obj19 = obj9 + obj10;
		object obj20 = obj14 * vector;
		object obj21 = obj11 * vector;
		object obj22 = obj12 + obj13;
		object obj23 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref twist) * obj;
		object obj24 = obj14 * obj;
		object obj25 = obj16 + obj15;
		object obj26 = obj17 - obj18;
		object obj27 = obj14 * num;
		object obj28 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref twist) * num;
		object obj29 = obj20 + obj19;
		object obj30 = obj23 + obj22;
		object obj31 = obj25 - obj24;
		object obj32 = obj26 - obj27;
		object obj33 = obj29 - obj28;
		object obj34 = obj30 - obj21;
		object obj36 = default;
		object obj35 = obj36 * obj31;
		object obj37 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref pole) * obj31;
		object obj38 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref pole) * obj32;
		object obj40 = default;
		object obj39 = obj40 * obj32;
		object obj41 = obj36 * obj33;
		object obj42 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref twist) * obj32;
		object obj43 = obj36 * obj34;
		object obj44 = obj36 * obj32;
		object obj45 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref twist) * obj33;
		object obj46 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref pole) * obj34;
		object obj47 = obj38 + obj35;
		object obj48 = obj40 * obj31;
		object obj49 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref twist) * obj31;
		object obj50 = obj39 + obj41;
		object obj51 = obj40 * obj33;
		object obj52 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref pole) * obj33;
		object obj53 = obj42 + obj43;
		object obj54 = obj44 - obj37;
		object obj55 = obj40 * obj34;
		object obj56 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref twist) * obj34;
		object obj57 = obj45 + obj47;
		object obj58 = obj46 + obj50;
		object obj59 = obj48 + obj53;
		object obj60 = obj54 - obj51;
		object obj61 = obj57 - obj55;
		object obj62 = obj58 - obj49;
		object obj63 = obj59 - obj52;
		object obj64 = obj60 - obj56;
		end.rotation = (Quaternion)0;
		Vector3 position = target.position;
		Vector3 vector2 = end.TransformDirection((Vector3)0);
		Vector3 vector3 = end.TransformPoint((Vector3)0);
		Vector3 position2 = end.position;
		Vector3 position3 = upper.position;
		Vector3 position4 = lower.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj65 = 0;
		object obj66 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v28+E4]");
		bool flag = (nint)0 == 0;
		object obj67 = !flag;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj69 = default;
		object obj68 = obj69 - obj69;
		object obj71 = default;
		object obj70 = obj71 - obj71;
		object obj72 = obj14 - obj14;
		object obj73 = obj68 * obj68;
		object obj74 = obj70 * obj70;
		Vector3 position5 = lower.position;
		Vector3 position6 = end.position;
		object obj75 = obj65;
		object obj76 = default;
		float num2 = (float)obj76 * handDepth;
		object obj77 = default;
		float num3 = (float)obj77 * handDepth;
		float num4 = (float)obj11 * handDepth;
		object obj78 = obj73 + obj74;
		object obj79 = obj72 * obj72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X0_v35+E4]");
		bool flag2 = (nint)0 == 0;
		object obj80 = !flag2;
		if (obj80 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj81 = obj79 + obj78;
		object obj82 = obj68 - obj68;
		object obj83 = obj70 - obj70;
		object obj84 = obj14 - obj14;
		object obj85 = obj82 * obj82;
		object obj86 = obj83 * obj83;
		object obj87 = obj85 + obj86;
		object obj88 = obj84 * obj84;
		float num5 = (float)obj61 + num3;
		float num6 = (float)obj63 + num4;
		float num7 = (float)obj62 + num2;
		object obj89 = obj69 - obj69;
		object obj90 = obj71 - obj71;
		object obj91 = obj14 - obj14;
		Vector3 position7 = upper.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj92 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num8 = num5 - (float)obj89;
		float num9 = num7 - (float)obj90;
		float num10 = num6 - (float)obj91;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X0_v40+E4]");
		bool flag3 = (nint)0 == 0;
		object obj93 = !flag3;
		if (obj93 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num11 = num8 - (float)obj87;
		float num12 = num9 - (float)obj88;
		float num13 = num10 - (float)obj14;
		float num14 = num11 * num11;
		float num15 = num12 * num12;
		float num16 = num14 + num15;
		float num17 = num13 * num13;
		float num18 = num2 + (float)obj81;
		float num19 = num17 + num16;
		float num20 = num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC78]");
		float num21 = num20 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		bool flag4 = !(num19 > num21);
		Vector3 vector4 = (Vector3)0;
		if (!flag4)
		{
			float num22 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC78]");
			float num23 = num22 * 0f;
			float num24 = num19 - (float)obj81;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			float num25 = num24 / num23;
			if ((!((double)num25 < 1.0) && num25 > maxStretch) || restUpper != (Quaternion)(object)1)
			{
				bool flag5 = restUpper == (Quaternion)(object)0;
				object obj94 = !flag5;
				if (obj94 == null)
				{
					upper.localScale = (Vector3)0;
				}
				else
				{
					upper.localScale = (Vector3)0;
				}
			}
			else
			{
				upper.localScale = (Vector3)0;
			}
			lower.localScale = (Vector3)0;
			vector4 = (Vector3)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		object obj96 = default;
		object obj95 = obj96 * 0;
		Vector3 vector5 = (Quaternion)0 * vector4;
		object obj97 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X0_v47+E4]");
		bool flag6 = (nint)0 == 0;
		object obj98 = !flag6;
		if (obj98 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj100 = default;
		object obj99 = obj100 * obj100;
		object obj102 = default;
		object obj101 = obj102 * obj102;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj103 = 0;
		object obj104 = obj99 + obj101;
		object obj106 = default;
		object obj105 = obj106 * obj106;
		object obj107 = obj105 + obj104;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		Vector3 vector6;
		double num26;
		double num27;
		object obj108;
		if ((nint)obj107 > 0)
		{
			vector6 = (Vector3)(obj100 / obj107);
			num26 = (double)obj102 / (double)obj107;
			num27 = (double)obj106 / (double)obj107;
			obj108 = obj103;
		}
		else
		{
			object obj109 = obj103;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X8_v60+A0]");
			object obj110 = 0;
			vector6 = (Vector3)obj110;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v61+4]");
			num26 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v61+8]");
			num27 = 0.0;
			obj108 = obj103;
		}
		double num28 = 1.0 - (double)elbowFollowsHand;
		double num29 = (double)vector6 * num28;
		double num30 = num26 * num28;
		double num31 = num27 * num28;
		Vector3 forward = target.forward;
		object obj111 = 109891584;
		double num32 = num28 * (double)elbowFollowsHand;
		float num33 = elbowFollowsHand * elbowFollowsHand;
		float num34 = (float)obj106 * elbowFollowsHand;
		double num35 = num29 - num32;
		double num36 = num30 - (double)num33;
		double num37 = num31 - (double)num34;
		double num38 = num35 * num35;
		double num39 = num36 * num36;
		double num40 = num38 + num39;
		double num41 = num37 * num37;
		double num42 = num41 + num40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if (num42 > 0.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X29_v2+9A1]");
			bool flag7 = (nint)0 == 0;
			object obj112 = !flag7;
			if (obj112 == null)
			{
				_ = 1;
			}
			object obj113 = obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X0_v125+E4]");
			bool flag8 = (nint)0 == 0;
			object obj114 = !flag8;
			if (obj114 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			nint num43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num43 > 0)
			{
				double num44 = num35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				double num45 = num44 / 0.0;
				double num46 = num36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				num26 = num46 / 0.0;
				double num47 = num37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				num27 = num47 / 0.0;
				vector6 = (Vector3)num45;
			}
			else
			{
				object obj115 = obj108;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v56+A0]");
				object obj116 = 0;
				vector6 = (Vector3)obj116;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X8_v57+4]");
				num26 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X8_v57+8]");
				num27 = 0.0;
			}
		}
		object obj117 = obj108;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v28+A0]");
		object obj118 = 0;
		float num48 = restLower.x - (float)obj118;
		float num49 = restLower.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v29+8]");
		float num50 = num49 - 0f;
		float num51 = num48 * num48;
		double num52 = (double)num50 * (double)num50;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num53 = (float)num52 + num51;
		float num54 = num53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		bool flag9 = num54 < 0f;
		Quaternion rotation2 = (Quaternion)vector;
		float x = (float)vector6;
		Vector3 b = default;
		if (!flag9)
		{
			float deltaTime = Time.deltaTime;
			float num55 = deltaTime * -20f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			num53 = 1f - num55;
			Vector3 vector7 = Vector3.Internal_Slerp(ref euler, ref b, num53);
			b = vector6;
			rotation2 = (Quaternion)restLower.x;
			num26 = 1.0;
			x = num53;
			num52 = 1.0;
			num27 = num34;
		}
		((Quaternion*)(nint)restLower)->x = x;
		((Quaternion*)(nint)restLower)->y = (float)num26;
		((Quaternion*)(nint)restLower)->z = (float)num27;
		Vector3 position8 = upper.position;
		float num56 = num53 + restLower.x;
		double num57 = num52 + (double)restLower.y;
		float num58 = num34 + restLower.z;
		SolveTwoBone(upper, lower, end, (Vector3)end, (Vector3)target);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X29_v2+9A1]");
		bool flag10 = (nint)0 == 0;
		object obj119 = !flag10;
		if (obj119 == null)
		{
			_ = 1;
		}
		object obj120 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1136 @ X0_v59+E4]");
		bool flag11 = (nint)0 == 0;
		object obj121 = !flag11;
		if (obj121 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj122 = handOffset * handOffset;
		object obj124 = default;
		object obj123 = obj124 * obj124;
		object obj125 = obj122 + obj123;
		object obj126 = trim * trim;
		Quaternion quaternion2 = (Quaternion)(obj126 + obj125);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		Vector3 vector8;
		if (quaternion2 > (object)0)
		{
			vector8 = (Vector3)(handOffset / quaternion2);
		}
		else
		{
			object obj127 = obj108;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1166 @ X8_v46+A0]");
			object obj128 = 0;
			vector8 = (Vector3)obj128;
		}
		Quaternion rotation3 = lower.rotation;
		Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation2);
		object obj129 = obj64 * quaternion2;
		object obj130 = obj61 * obj124;
		object obj131 = obj62 * obj124;
		object obj132 = obj64 * obj126;
		object obj133 = obj63 * obj124;
		object obj134 = obj64 * trim;
		object obj135 = obj64 * obj124;
		object obj136 = obj61 * quaternion2;
		object obj137 = obj130 + obj129;
		object obj138 = obj63 * obj126;
		object obj139 = obj131 + obj132;
		object obj140 = obj61 * trim;
		object obj141 = obj133 + obj134;
		object obj142 = obj62 * quaternion2;
		object obj143 = obj63 * quaternion2;
		object obj144 = obj135 - obj136;
		object obj145 = obj62 * obj126;
		object obj146 = obj61 * obj126;
		object obj147 = obj138 + obj137;
		object obj148 = obj140 + obj139;
		object obj149 = obj62 * trim;
		object obj150 = obj63 * trim;
		object obj151 = obj142 + obj141;
		object obj152 = obj144 - obj145;
		object obj153 = obj148 - obj143;
		object obj154 = obj147 - obj149;
		object obj155 = obj151 - obj146;
		object obj156 = obj152 - obj150;
		Quaternion rotation4 = default;
		Quaternion q = Quaternion.Internal_Inverse(ref rotation4);
		object obj157 = obj156 * obj150;
		object obj158 = obj155 * obj152;
		object obj159 = obj156 * obj152;
		object obj160 = obj154 * obj5;
		object obj161 = obj153 * obj5;
		object obj162 = obj157 + obj158;
		object obj163 = obj154 * restHandPos;
		object obj164 = obj155 * obj150;
		object obj165 = obj159 - obj160;
		object obj166 = obj153 * restHandPos;
		object obj167 = obj163 + obj162;
		object obj168 = obj165 - obj166;
		object obj169 = obj167 - obj161;
		object obj170 = obj168 - obj164;
		float angle = TwistAngle(q, (Vector3)0);
		float num59 = (((Quaternion*)(nint)restHand)->x = Unwrap(angle, restHand.x));
		Quaternion rotation5 = lower.rotation;
		float num60 = restHand.x * forearmTwist;
		Quaternion quaternion4 = Quaternion.Internal_AngleAxis(num60, ref euler);
		float num61 = (float)obj170 * num60;
		float num62 = num59 * (float)obj170;
		float num63 = (float)obj170 * forearmTwist;
		float num64 = restHand.x * (float)obj170;
		object obj171 = obj170 * obj169;
		object obj172 = obj169 * obj170;
		float num65 = num61 + num62;
		float num66 = restHand.x * (float)obj169;
		float num67 = restHand.x * num60;
		float num68 = num63 + num64;
		float num69 = (float)obj169 * num60;
		float num70 = (float)obj169 * forearmTwist;
		object obj173 = obj171 + obj172;
		float num71 = num59 * forearmTwist;
		float num72 = num59 * (float)obj169;
		float num73 = num66 + num65;
		float num74 = num69 + num68;
		float num75 = num71 + (float)obj173;
		float num76 = num73 - num70;
		float num77 = num74 - num72;
		float num78 = num75 - num67;
		lower.rotation = (Quaternion)0;
		Vector3 localScale = upper.localScale;
		object obj174 = default;
		float num79 = num77 - (float)obj174;
		float num80 = num76 - (float)palmLocal;
		float num81 = num78 - (float)palmDir;
		float num82 = num80 * num80;
		float num83 = num79 * num79;
		float num84 = num82 + num83;
		float num85 = num81 * num81;
		float num86 = num85 + num84;
		float num87 = num86;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if (!(num87 < 0f))
		{
			object obj175 = 4;
			euler = vector8;
			float num88 = num10;
			float num89 = num9;
			bool flag18;
			do
			{
				Vector3 position9 = end.position;
				Vector3 position10 = lower.position;
				float num90 = num86 - num86;
				float num91 = num85 - num85;
				float num92 = num81 - num81;
				Vector3 position11 = lower.position;
				float num93 = num90 * num90;
				float num94 = num91 * num91;
				float num95 = num93 + num94;
				float num96 = num92 * num92;
				float num97 = num96 + num95;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
				if (num97 < 0f)
				{
					break;
				}
				float num98 = num89 - num85;
				float num99 = num88 - num81;
				float num100 = num8 - num86;
				float num101 = num98 * num98;
				float num102 = num100 * num100;
				float num103 = num102 + num101;
				float num104 = num99 * num99;
				float num105 = num104 + num103;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
				if (num105 < 0f)
				{
					break;
				}
				Quaternion quaternion5 = Quaternion.Internal_FromToRotation(ref euler, ref b);
				Quaternion rotation6 = lower.rotation;
				float num106 = num103 * num100;
				float num107 = num100 * num103;
				float num108 = num103 * num98;
				float num109 = num98 * num103;
				float num110 = num103 * num99;
				float num111 = num99 * num103;
				float num112 = num103 * num103;
				float num113 = num100 * num100;
				float num114 = num106 + num107;
				float num115 = num98 * num99;
				float num116 = num98 * num100;
				float num117 = num108 + num109;
				float num118 = num99 * num100;
				float num119 = num99 * num98;
				float num120 = num110 + num111;
				float num121 = num100 * num98;
				float num122 = num99 * num99;
				float num123 = num112 - num113;
				float num124 = num98 * num98;
				float num125 = num100 * num99;
				float num126 = num115 + num114;
				float num127 = num118 + num117;
				float num128 = num121 + num120;
				float num129 = num123 - num124;
				float num130 = num126 - num119;
				float num131 = num127 - num125;
				float num132 = num128 - num116;
				float num133 = num129 - num122;
				lower.rotation = (Quaternion)0;
				Vector3 position12 = lower.position;
				Vector3 position13 = end.position;
				object obj176 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1534 @ X0_v94+E4]");
				bool flag12 = (nint)0 == 0;
				object obj177 = !flag12;
				if (obj177 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				num81 = num132 - num132;
				num85 = num81 * num81;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				bool flag13 = !(num132 > 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				num86 = 0f;
				if (!flag13)
				{
					Vector3 localScale2 = lower.localScale;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X29_v2+9A1]");
					bool flag14 = (nint)0 == 0;
					object obj178 = !flag14;
					if (obj178 == null)
					{
						_ = 1;
					}
					object obj179 = obj65;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ X0_v100+E4]");
					bool flag15 = (nint)0 == 0;
					object obj180 = !flag15;
					if (obj180 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					bool flag16 = restUpper == (Quaternion)(object)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					float num134 = 0f / num132;
					float num136;
					float num137;
					float num138;
					if (!flag16)
					{
						bool flag17 = restUpper == (Quaternion)(object)0;
						object obj181 = !flag17;
						if (obj181 == null)
						{
							float num135 = num134;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
							num136 = num135 * 0f;
							num137 = num85;
							num138 = num81;
						}
						else
						{
							num138 = num134 * num81;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
							num136 = 0f;
							num137 = num85;
						}
					}
					else
					{
						num137 = num134 * num85;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
						num136 = 0f;
						num138 = num81;
					}
					lower.localScale = (Vector3)0;
					num81 = num138;
					num85 = num137;
					num86 = num136;
				}
				obj175--;
				flag18 = (nint)obj175 != 1;
				b = (Vector3)num100;
				euler = (Vector3)num90;
				num88 = num10;
				num89 = num9;
			}
			while (flag18);
		}
		end.rotation = (Quaternion)0;
		end.position = (Vector3)0;
	}

	public static float TwistAngle(Quaternion q, Vector3 axis)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_00af: Invalid comparison between F4 and I4
		//IL_00be: Expected F4, but got I4
		//IL_00d5: Invalid comparison between F4 and I4
		//IL_00e4: Expected F4, but got I4
		//IL_00fb: Invalid comparison between F4 and I4
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 * obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 * obj6;
		object obj7 = obj + obj4;
		object obj9 = default;
		object obj10 = default;
		object obj8 = obj9 * obj10;
		object obj11 = obj8 + obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFF0");
		object obj12 = obj11 + obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
		object obj13 = obj12 * 0;
		float num = (float)obj13 / 1.13587E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num2 = num * 1.13587E+09f;
		float num3 = (float)obj13 - num2;
		bool flag = num3 < 0f;
		float result = 0f;
		if (!flag)
		{
			bool flag2 = num3 > 1.13587E+09f;
			float num4 = 1.13587E+09f;
			if (!flag2)
			{
				bool flag3 = !(num3 > 1.1274813E+09f);
				num4 = num3;
				result = num3;
				if (flag3)
				{
					goto IL_013b;
				}
			}
			result = num4 + 3.2833536E+09f;
		}
		goto IL_013b;
		IL_013b:
		return result;
	}

	private static float Unwrap(float angle, float last)
	{
		//IL_0051: Invalid comparison between F4 and I4
		//IL_0060: Expected F4, but got I4
		//IL_0139: Invalid comparison between F4 and I4
		//IL_00fc: Invalid comparison between F4 and I8
		//IL_0077: Invalid comparison between F4 and I4
		//IL_0086: Expected F4, but got I4
		//IL_00ea: Expected Obj, but got I8
		//IL_011c: Expected Obj, but got I4
		//IL_009d: Invalid comparison between F4 and I4
		float num = angle - last;
		float num2 = num / 1.13587E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num3 = num2 * 1.13587E+09f;
		float num4 = num - num3;
		bool flag = num4 < 0f;
		float num5 = 0f;
		if (!flag)
		{
			bool flag2 = num4 > 1.13587E+09f;
			float num6 = 1.13587E+09f;
			if (!flag2)
			{
				bool flag3 = !(num4 > 1.1274813E+09f);
				num6 = num4;
				num5 = num4;
				if (flag3)
				{
					goto IL_0121;
				}
			}
			num5 = num6 + 3.2833536E+09f;
		}
		goto IL_0121;
		IL_0121:
		float num7 = num5 + last;
		object obj;
		if (num7 > 1.1320689E+09f)
		{
			obj = 3283353600L;
		}
		else
		{
			if (!(num7 < 3.2795525E+09f))
			{
				goto IL_0164;
			}
			obj = 1135869952;
		}
		num7 += (float)obj;
		goto IL_0164;
		IL_0164:
		return num7;
	}

	private static int DominantAxis(Vector3 v)
	{
		//IL_0098: Expected Obj, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00b3: Expected I4, but got Obj
		//IL_0171: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		object obj4 = obj2 ^ obj3;
		object obj5 = obj2 ^ obj;
		object obj6 = obj4 & obj5;
		bool flag3 = (nint)obj6 < 0;
		bool flag4 = flag == flag3;
		object obj7 = !flag2;
		object obj8 = flag4 & obj7;
		int result = obj8 << 1;
		object obj9 = default;
		bool flag5;
		bool flag6;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj10 = obj9 - obj3;
			flag5 = (nint)obj10 < 0;
			object obj11 = obj9 ^ obj3;
			object obj12 = obj9 ^ obj10;
			object obj13 = obj11 & obj12;
			flag6 = (nint)obj13 < 0;
		}
		else
		{
			flag6 = false;
			flag5 = true;
		}
		bool flag7 = flag5 == flag6;
		object obj14 = !flag7;
		object obj15 = ~obj14;
		if (obj15 == null)
		{
			return result;
		}
		return 1;
	}

	private static Vector3 ScaleAlong(Vector3 scale, int axis, float s)
	{
		//IL_0009: Invalid comparison between VT and I4
		//IL_0026: Invalid comparison between VT and I4
		//IL_0037: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		if (scale != (Vector3)(object)1)
		{
			bool flag = scale == (Vector3)(object)0;
			object obj = !flag;
			object obj2 = ~obj;
			if (obj2 == null)
			{
			}
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
			}
			return scale;
		}
		return scale;
	}

	public static void SolveTwoBone(Transform upper, Transform lower, Transform end, Vector3 target, Vector3 pole)
	{
		//IL_0b8d: Expected Obj, but got I
		//IL_0bb7: Expected Obj, but got I4
		//IL_0bef: Expected Obj, but got I4
		//IL_0c34: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_0c71: Expected Obj, but got I4
		//IL_02e9: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I
		//IL_0309: Expected VT, but got Obj
		//IL_0319: Expected Obj, but got I
		//IL_0329: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I
		//IL_02b7: Expected VT, but got Obj
		//IL_1214: Expected Obj, but got I4
		//IL_03bf: Expected Obj, but got I
		//IL_03d7: Expected Obj, but got I
		//IL_03df: Expected VT, but got Obj
		//IL_03ef: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected Obj, but got Unknown
		//IL_0dc4: Expected VT, but got I4
		//IL_0390: Expected VT, but got Obj
		//IL_0dd6: Expected Obj, but got VT
		//IL_0df3: Expected Obj, but got I
		//IL_0e25: Expected Obj, but got I
		//IL_0ea5: Expected Obj, but got I
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_0a37: Invalid comparison between F4 and I
		//IL_05be: Invalid comparison between F4 and I
		//IL_05df: Expected Obj, but got VT
		//IL_05f8: Expected VT, but got I4
		//IL_0ad6: Invalid comparison between F4 and I
		//IL_06d7: Expected VT, but got I4
		//IL_0708: Expected VT, but got I4
		//IL_12ce: Expected Obj, but got I4
		//IL_133e: Expected Obj, but got I4
		//IL_085f: Expected Obj, but got I
		//IL_0877: Expected Obj, but got I
		//IL_088f: Expected Obj, but got I
		//IL_089f: Expected Obj, but got I
		//IL_0b1b: Invalid comparison between F4 and I
		//IL_0f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Expected Obj, but got Unknown
		//IL_0fd6: Invalid comparison between F4 and I
		//IL_0fef: Expected F4, but got I
		//IL_11a6: Expected Obj, but got I4
		//IL_0b60: Invalid comparison between F4 and I
		//IL_1306: Expected Obj, but got I4
		//IL_11e0: Expected VT, but got I4
		//IL_093e: Expected Obj, but got I
		//IL_0956: Expected Obj, but got I
		//IL_095e: Expected VT, but got Obj
		//IL_096e: Expected F4, but got I
		//IL_097e: Expected Obj, but got I
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_104b: Expected Obj, but got Unknown
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Expected Obj, but got Unknown
		//IL_1165: Expected VT, but got I4
		//IL_090d: Expected VT, but got Obj
		Vector3 position = upper.position;
		Vector3 position2 = lower.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 position3 = lower.position;
		Vector3 position4 = end.position;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 position5 = upper.position;
		object obj7 = default;
		object obj6 = obj7 - obj7;
		object obj9 = default;
		object obj8 = obj9 - obj9;
		object obj11 = default;
		object obj10 = obj11 - obj11;
		object obj12 = obj6 * obj6;
		object obj13 = obj8 * obj8;
		object obj14 = obj13 + obj12;
		object obj15 = obj10 * obj10;
		object obj16 = obj15 + obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		if ((nint)obj16 < 0)
		{
			return;
		}
		object obj17 = obj7 - obj7;
		object obj18 = obj9 - obj9;
		object obj19 = obj17 * obj17;
		object obj20 = obj7 - obj7;
		object obj21 = obj9 - obj9;
		object obj22 = obj11 - obj11;
		object obj23 = obj18 * obj18;
		object obj24 = obj11 - obj11;
		object obj25 = obj20 * obj20;
		object obj26 = obj21 * obj21;
		object obj27 = obj22 * obj22;
		object obj28 = obj23 + obj25;
		object obj29 = obj;
		object obj30 = obj27 + obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj31 = !flag3;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
		if ((nint)obj30 >= 0)
		{
			object obj33 = obj11 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC2C]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC2C]");
			obj23 = obj33 * 0;
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
			obj32 = obj30;
			if (!flag4)
			{
				obj32 = obj23;
			}
		}
		object obj34 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v24+E4]");
		bool flag5 = (nint)0 == 0;
		object obj35 = !flag5;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		object obj36;
		Vector3 vector;
		object obj37;
		object obj38;
		if ((nint)obj30 > 0)
		{
			obj36 = obj6 / obj30;
			vector = (Vector3)(obj8 / obj30);
			obj37 = obj10 / obj30;
			obj25 = obj8;
			obj38 = obj10;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj39 = 0;
			object obj40 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v96+A0]");
			object obj41 = 0;
			vector = (Vector3)obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v97+4]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v97+8]");
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			obj38 = 0;
		}
		Vector3 position6 = end.position;
		object obj42 = obj38 - obj9;
		object obj43 = obj25 - obj7;
		object obj44 = obj26 - obj11;
		object obj45 = obj42 * obj42;
		object obj46 = obj43 * obj43;
		object obj47 = obj45 + obj46;
		object obj48 = obj44 * obj44;
		object obj49 = obj48 + obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		if ((nint)obj49 < 0)
		{
			return;
		}
		object obj50 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v30+E4]");
		bool flag6 = (nint)0 == 0;
		object obj51 = !flag6;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		Vector3 vector2;
		object obj52;
		object obj53;
		if ((nint)obj26 > 0)
		{
			vector2 = (Vector3)(obj42 / obj26);
			obj52 = obj43 / obj26;
			obj53 = obj44 / obj26;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj54 = 0;
			object obj55 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v90+A0]");
			object obj56 = 0;
			vector2 = (Vector3)obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v91+4]");
			obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v91+8]");
			obj53 = 0;
		}
		Vector3 toDirection = default;
		Vector3 fromDirection = default;
		Quaternion quaternion = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
		Quaternion rotation = upper.rotation;
		object obj57 = obj9 * obj52;
		object obj58 = obj52 * obj9;
		object obj59 = obj9 * obj53;
		object obj60 = obj53 * obj9;
		float num = (float)obj57 + (float)obj58;
		float num2 = (float)obj53 * (float)vector2;
		object obj61 = obj59 + obj60;
		object obj62 = vector2 * obj52;
		float num3 = (float)obj62 + (float)obj61;
		upper.rotation = (Quaternion)0;
		object obj63 = vector * vector;
		object obj64 = obj36 * obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj65 = 0;
		object obj66 = obj65;
		object obj67 = obj63 + obj64;
		object obj68 = obj37 * obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v30+A0]");
		object obj69 = 0;
		object obj70 = obj68 + obj67;
		object obj71 = obj69;
		object obj73 = default;
		object obj72 = obj73 - obj9;
		bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj70) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj69);
		object obj75 = default;
		object obj74 = obj75 - obj7;
		object obj77 = default;
		object obj76 = obj77 - obj11;
		object obj78 = obj11;
		object obj79 = obj77;
		if (!flag7)
		{
			object obj80 = obj72 * vector;
			object obj81 = obj74 * obj36;
			object obj82 = obj76 * obj37;
			object obj83 = obj80 + obj81;
			object obj84 = obj82 + obj83;
			object obj85 = obj84 / obj70;
			obj79 = vector * obj85;
			obj78 = obj36 * obj85;
			obj71 = obj37 * obj85;
			obj72 -= obj79;
			obj74 -= obj78;
			obj76 -= obj71;
		}
		Vector3 position7 = lower.position;
		object obj86 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X8_v34+A0]");
		object obj87 = 0;
		float num4 = (float)obj71 - (float)obj9;
		float num5 = (float)obj79 - (float)obj7;
		float num6 = (float)obj78 - (float)obj11;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj70) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj87))
		{
			float num7 = (float)vector * num4;
			float num8 = (float)obj36 * num5;
			float num9 = (float)obj37 * num6;
			float num10 = num7 + num8;
			float num11 = num9 + num10;
			float num12 = num11 / (float)obj70;
			float num13 = (float)vector * num12;
			num3 = (float)obj36 * num12;
			float num14 = (float)obj37 * num12;
			num4 -= num13;
			num5 -= num3;
			num6 -= num14;
		}
		object obj88 = obj72 * obj72;
		object obj89 = obj74 * obj74;
		object obj90 = obj88 + obj89;
		object obj91 = obj76 * obj76;
		object obj92 = obj90 + obj91;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		bool flag8 = (nint)obj92 <= 0;
		fromDirection = vector2;
		if (!flag8)
		{
			float num15 = num4 * num4;
			float num16 = num5 * num5;
			float num17 = num15 + num16;
			float num18 = num6 * num6;
			float num19 = num17 + num18;
			float num20 = num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			bool flag9 = !(num20 > 0f);
			fromDirection = vector2;
			object obj93 = obj11;
			Transform transform = (Transform)position7;
			object obj94 = obj74;
			object obj95 = obj72;
			Quaternion quaternion2 = (Quaternion)0;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72DCC");
				Quaternion quaternion3 = Quaternion.Internal_AngleAxis(num4, ref fromDirection);
				Quaternion rotation2 = upper.rotation;
				float num21 = (float)obj72 * num5;
				float num22 = num5 * (float)obj72;
				float num23 = (float)obj72 * num6;
				float num24 = num6 * (float)obj72;
				num = num21 + num22;
				num2 = num6 * num4;
				float num25 = num23 + num24;
				float num26 = num4 * num5;
				num19 = num2 + num;
				num18 = num26 + num25;
				upper.rotation = (Quaternion)0;
				fromDirection = vector;
				obj93 = obj11;
				transform = upper;
				obj94 = obj74;
				obj95 = obj72;
				quaternion2 = (Quaternion)0;
			}
			object obj96 = obj93 * obj93;
			object obj97 = obj93 + obj93;
			object obj98 = obj32 * obj32;
			object obj99 = obj96 + obj98;
			object obj100 = obj16 * obj16;
			object obj101 = obj99 - obj100;
			object obj102 = obj97 * obj32;
			double num27 = (double)obj101 / (double)obj102;
			bool flag10 = num27 < -1.0;
			double num28 = -1.0;
			if (!flag10)
			{
				bool flag11 = !(num27 > 1.0);
				num28 = num27;
				if (!flag11)
				{
					num28 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFE0");
			object obj103 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X0_v79+E4]");
			bool flag12 = (nint)0 == 0;
			object obj104 = !flag12;
			if (obj104 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj105;
			object obj106;
			object obj107;
			if ((nint)obj97 > 0)
			{
				obj105 = obj95 / obj97;
				obj106 = obj94 / obj97;
				obj107 = obj76 / obj97;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj108 = 0;
				object obj109 = obj108;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v82+A0]");
				object obj110 = 0;
				obj105 = obj110;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X8_v83+4]");
				obj106 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X8_v83+8]");
				obj107 = 0;
			}
			object obj111 = obj36 * obj107;
			object obj112 = obj37 * obj106;
			num3 = (float)obj37 * (float)obj105;
			num6 = (float)vector * (float)obj107;
			object obj113 = vector * obj106;
			object obj114 = obj36 * obj105;
			object obj115 = obj111 - obj112;
			float num29 = num3 - num6;
			object obj116 = obj113 - obj114;
			object obj117 = obj115 * obj115;
			float num30 = num29 * num29;
			float num31 = (float)obj117 + num30;
			num5 = (float)obj116 * (float)obj116;
			float num32 = num5 + num31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			bool flag13 = !(num32 > 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			num4 = 0f;
			if (!flag13)
			{
				object obj118 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ X0_v83+E4]");
				bool flag14 = (nint)0 == 0;
				object obj119 = !flag14;
				if (obj119 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				float num33 = (float)num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
				float num34 = num33 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				Vector3 vector3;
				float num35;
				object obj120;
				if ((nint)obj111 > 0)
				{
					vector3 = (Vector3)(obj115 / obj111);
					num35 = num29 / (float)obj111;
					obj120 = obj116 / obj111;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj121 = 0;
					object obj122 = obj121;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1259 @ X8_v76+A0]");
					object obj123 = 0;
					vector3 = (Vector3)obj123;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1260 @ X8_v77+4]");
					num35 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1260 @ X8_v77+8]");
					obj120 = 0;
				}
				Quaternion quaternion4 = Quaternion.Internal_AngleAxis(num34, ref fromDirection);
				Quaternion rotation3 = upper.rotation;
				float num36 = (float)obj120 * num34;
				float num37 = num34 * (float)obj120;
				object obj124 = obj120 * vector3;
				object obj125 = vector3 * obj120;
				float num38 = (float)obj120 * num35;
				float num39 = num35 * (float)obj120;
				float num40 = num36 + num37;
				float num41 = (float)vector3 * num35;
				float num42 = (float)vector3 * num34;
				num = (float)obj124 + (float)obj125;
				num2 = num35 * num34;
				float num43 = num35 * (float)vector3;
				float num44 = num38 + num39;
				float num45 = num34 * (float)vector3;
				float num46 = num34 * num35;
				float num47 = num41 + num40;
				float num48 = num2 + num;
				num3 = num45 + num44;
				num4 = num47 - num43;
				num5 = num48 - num46;
				num6 = num3 - num42;
				upper.rotation = (Quaternion)0;
				fromDirection = vector3;
			}
		}
		Vector3 position8 = end.position;
		Vector3 position9 = lower.position;
		float num49 = num4 - num4;
		float num50 = num5 - num5;
		float num51 = num6 - num6;
		Vector3 position10 = lower.position;
		float num52 = num49 * num49;
		float num53 = num50 * num50;
		float num54 = num52 + num53;
		float num55 = num51 * num51;
		float num56 = num55 + num54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		if (!(num56 > 0f))
		{
			return;
		}
		float num57 = (float)obj9 - num4;
		float num58 = (float)obj7 - num5;
		float num59 = (float)obj11 - num6;
		float num60 = num57 * num57;
		float num61 = num58 * num58;
		float num62 = num60 + num61;
		float num63 = num59 * num59;
		float num64 = num63 + num62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		if (num64 > 0f)
		{
			object obj126 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X0_v50+E4]");
			bool flag15 = (nint)0 == 0;
			object obj127 = !flag15;
			if (obj127 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num62 > 0f)
			{
			}
			object obj128 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1251 @ X0_v54+E4]");
			bool flag16 = (nint)0 == 0;
			object obj129 = !flag16;
			if (obj129 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num65 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num65 > 0f)
			{
			}
			Quaternion quaternion5 = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
			Quaternion rotation4 = lower.rotation;
			lower.rotation = (Quaternion)0;
		}
	}

	public ApeAvatarDriver()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_0028: Expected F4, but got I
		//IL_003a: Expected F4, but got I
		//IL_0057: Expected F4, but got I
		//IL_006c: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		object obj = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B590]");
		eyeBack = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CB30]");
		maxStretch = 0f;
		handDepth = 0.02f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B278]");
		handPitch = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v9+A0]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v9+A0]");
		object obj3 = 0;
		axisL = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v9+A0]");
		object obj4 = 0;
		base._002Ector();
	}
}
