using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace GorillaLocomotion;

public class Player : MonoBehaviour
{
	private static Player _instance;

	public SphereCollider headCollider;

	public CapsuleCollider bodyCollider;

	public Transform leftHandFollower;

	public Transform rightHandFollower;

	public Transform rightHandTransform;

	public Transform leftHandTransform;

	private Vector3 lastLeftHandPosition;

	private Vector3 lastRightHandPosition;

	private Vector3 lastHeadPosition;

	private Rigidbody playerRigidBody;

	public int velocityHistorySize;

	public float maxArmLength;

	public float unStickDistance;

	public float velocityLimit;

	public float maxJumpSpeed;

	public float jumpMultiplier;

	public float minimumRaycastDistance;

	public float defaultSlideFactor;

	public float defaultPrecision;

	private Vector3[] velocityHistory;

	private int velocityIndex;

	private Vector3 currentVelocity;

	private Vector3 denormalizedVelocityAverage;

	private bool jumpHandIsLeft;

	private Vector3 lastPosition;

	public Vector3 rightHandOffset;

	public Vector3 leftHandOffset;

	public LayerMask locomotionEnabledLayers;

	public bool wasLeftHandTouching;

	public bool wasRightHandTouching;

	public bool disableMovement;

	public bool leftHandDisabled;

	public bool rightHandDisabled;

	private bool leftWasResting;

	private bool rightWasResting;

	private float hitSlip;

	private Vector3 hitNormal;

	private float leftSlip;

	private float rightSlip;

	private Vector3 leftSlipNormal;

	private Vector3 rightSlipNormal;

	private float launchedUntil;

	public HeldShape leftHeld;

	public HeldShape rightHeld;

	private Quaternion lastLeftTurn;

	private Quaternion lastRightTurn;

	private int leftWhich;

	private int rightWhich;

	private Vector3 hitPoint;

	private Vector3 leftHeldAt;

	private Vector3 rightHeldAt;

	private Vector3 leftHeldFaces;

	private Vector3 rightHeldFaces;

	private Collider hitCollider;

	private Collider leftHeldOn;

	private Collider rightHeldOn;

	public static readonly HashSet<Collider> GoesInto;

	private bool passing;

	private bool metSoft;

	private Vector3 softPoint;

	private Vector3 softNormal;

	private Collider softCollider;

	private readonly bool[] intoNow;

	private readonly bool[] into;

	private readonly Vector3[] intoAt;

	private readonly Vector3[] intoFaces;

	private readonly Collider[] intoOn;

	private static readonly RaycastHit[] castHits;

	public static Player Instance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
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
			return (Player)0;
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)obj6 != null;
		bool flag4 = !flag3;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (!flag4)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v17+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v17+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = (UnityEngine.Object)obj13 != this;
			bool flag8 = !flag7;
			obj8 = 0;
			obj9 = this;
			if (!flag8)
			{
				GameObject obj15 = gameObject;
				object obj16 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v12+E4]");
				bool flag9 = (nint)0 == 0;
				object obj17 = !flag9;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(obj15);
				goto IL_01ba;
			}
		}
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v11+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v11+A0]");
		object obj20 = 0;
		obj20 = this;
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_01ba;
		IL_01ba:
		InitializeValues();
	}

	public Vector3 HandNow(bool right)
	{
		if (right)
		{
			return CurrentRightHandPosition();
		}
		return CurrentLeftHandPosition();
	}

	private void FollowerToHand(Transform follower, Vector3 hand)
	{
		//IL_000a: Expected VT, but got Obj
		//IL_0021: Expected VT, but got I4
		Vector3 vector = OnYourSide((Vector3)follower);
		follower.position = (Vector3)0;
	}

	private unsafe Vector3 OnYourSide(Vector3 hand)
	{
		//IL_0151: Expected VT, but got Obj
		//IL_0180: Expected Obj, but got I
		//IL_0195: Expected VT, but got Obj
		//IL_01b7: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		//IL_010d: Expected VT, but got Ref
		//IL_0128: Expected VT, but got I4
		//IL_013e: Expected VT, but got I4
		if ((object)headCollider != null)
		{
			Transform transform = headCollider.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj = 0;
				object obj3 = default;
				object obj2 = obj3 - obj3;
				Vector3 result = (Vector3)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v10 (UnityEngine.Vector3)+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj5 = obj2 * obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				object obj6 = default;
				if ((nint)obj6 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
					object obj7 = 0;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num = default;
					float maxDistance = default;
					QueryTriggerInteraction queryTriggerInteraction = default;
					bool flag3 = Physics.SphereCast((Vector3)(&num), 0f, (Vector3)locomotionEnabledLayers, out *(RaycastHit*)1, maxDistance, 0, queryTriggerInteraction);
					bool flag4 = !flag3;
					result = (Vector3)flag3;
					if (!flag4)
					{
						result = (Vector3)flag3;
					}
				}
				return result;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	public bool HandOff(bool right)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		int hand;
		if (right)
		{
			bool flag = (byte)(~(rightHandDisabled ? 1u : 0u)) != 0;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0050;
			}
			hand = 1;
		}
		else
		{
			if (~(leftHandDisabled ? 1u : 0u) == 0)
			{
				goto IL_0050;
			}
			hand = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return GillaOneArm.Resting(hand);
		IL_0050:
		return true;
	}

	public void InitializeValues()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected Obj, but got Unknown
		//IL_060f: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_0062: Expected VT, but got I4
		//IL_01d6: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I
		//IL_022b: Expected VT, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_00e4: Expected VT, but got I4
		//IL_0263: Expected Obj, but got I4
		//IL_062d: Expected Obj, but got I
		//IL_0645: Expected Obj, but got I
		//IL_064f: Expected VT, but got Obj
		//IL_066c: Expected Obj, but got I
		//IL_0681: Expected VT, but got Obj
		//IL_02a8: Expected VT, but got I4
		//IL_0121: Expected Obj, but got I4
		//IL_0166: Expected VT, but got I4
		//IL_03b8: Expected VT, but got Obj
		//IL_02e0: Expected Obj, but got I4
		//IL_0325: Expected VT, but got I4
		//IL_0194: Expected VT, but got I4
		//IL_019d: Expected VT, but got I4
		//IL_0402: Expected VT, but got Obj
		//IL_0436: Expected Obj, but got I4
		//IL_034e: Expected VT, but got I4
		//IL_0357: Expected VT, but got I4
		//IL_06bd: Expected Obj, but got I4
		//IL_049e: Expected VT, but got Obj
		//IL_0514: Expected VT, but got Obj
		//IL_055c: Expected VT, but got I4
		//IL_05a0: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj3 = this + 120;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v3-48]");
		bool flag2 = (UnityEngine.Object)0 != null;
		bool flag3 = !flag2;
		Vector3 vector = (Vector3)0;
		Transform transform = null;
		if (!flag3)
		{
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v70+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = leftHandTransform != null;
			bool flag6 = !flag5;
			vector = (Vector3)0;
			transform = null;
			if (!flag6)
			{
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v74+E4]");
				bool flag7 = (nint)0 == 0;
				object obj10 = !flag7;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = headCollider != null;
				bool flag9 = !flag8;
				vector = (Vector3)0;
				transform = null;
				if (!flag9)
				{
					Vector3 vector2 = CurrentLeftHandPosition();
					FollowerToHand(leftHandFollower, (Vector3)0);
					vector = (Vector3)0;
					transform = leftHandFollower;
				}
			}
		}
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v11+E4]");
		bool flag10 = (nint)0 == 0;
		object obj12 = !flag10;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj13 = 0;
		bool flag11 = rightHandFollower != null;
		bool flag12 = !flag11;
		Vector3 vector3 = (Vector3)0;
		if (!flag12)
		{
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v56+E4]");
			bool flag13 = (nint)0 == 0;
			object obj15 = !flag13;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag14 = rightHandTransform != null;
			bool flag15 = !flag14;
			vector3 = (Vector3)0;
			if (!flag15)
			{
				object obj16 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v60+E4]");
				bool flag16 = (nint)0 == 0;
				object obj17 = !flag16;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag17 = headCollider != null;
				bool flag18 = !flag17;
				vector3 = (Vector3)0;
				if (!flag18)
				{
					Vector3 vector4 = CurrentRightHandPosition();
					FollowerToHand(rightHandFollower, (Vector3)0);
					vector3 = (Vector3)0;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj18 = this + 168;
		object obj19 = default;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v11+A0]");
		object obj22 = 0;
		denormalizedVelocityAverage = (Vector3)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X9_v1+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v11+A0]");
		object obj23 = 0;
		wasLeftHandTouching = false;
		currentVelocity = (Vector3)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+8]");
		_ = 0;
		Transform transform2 = leftHandFollower.transform;
		Vector3 position = transform2.position;
		lastLeftHandPosition = (Vector3)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+8]");
		_ = 0;
		Transform transform3 = rightHandFollower.transform;
		Vector3 position2 = transform3.position;
		object obj24 = obj2;
		lastRightHandPosition = (Vector3)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v30+E4]");
		bool flag19 = (nint)0 == 0;
		object obj25 = !flag19;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = leftHandTransform != null;
		bool flag21 = !flag20;
		UnityEngine.Object obj26 = null;
		if (!flag21)
		{
			Quaternion rotation = leftHandTransform.rotation;
			lastLeftTurn = (Quaternion)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+8]");
			_ = 0;
			obj26 = null;
		}
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v35+E4]");
		bool flag22 = (nint)0 == 0;
		object obj28 = !flag22;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (rightHandTransform != null)
		{
			Quaternion rotation2 = rightHandTransform.rotation;
			lastRightTurn = (Quaternion)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+8]");
			_ = 0;
		}
		leftWhich = -1;
		Transform transform4 = headCollider.transform;
		Vector3 position3 = transform4.position;
		lastHeadPosition = (Vector3)(-1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+8]");
		_ = 0;
		velocityIndex = 0;
		Transform transform5 = base.transform;
		Vector3 position4 = transform5.position;
		lastPosition = (Vector3)(-1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+8]");
		_ = 0;
		launchedUntil = -1f;
	}

	private Vector3 CurrentLeftHandPosition()
	{
		//IL_0234: Expected VT, but got Obj
		//IL_0245: Expected Obj, but got VT
		//IL_0262: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I4
		//IL_00d5: Invalid comparison between Obj and F4
		//IL_0173: Expected Obj, but got VT
		//IL_02d9: Expected VT, but got Obj
		//IL_02fb: Expected Obj, but got I4
		Vector3 offsetVector = default;
		Vector3 vector = PositionWithOffset(leftHandTransform, offsetVector);
		Vector3 result;
		if ((object)headCollider != null)
		{
			Transform transform = headCollider.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				object obj = leftHandOffset - leftHandOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+EC]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+EC]");
				object obj2 = num - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+F0]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+F0]");
				object obj4 = num2 - 0;
				Player player = (Player)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v9 (GorillaLocomotion.Player)+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = obj * obj;
				object obj7 = obj2 * obj2;
				object obj8 = obj6 + obj7;
				object obj9 = obj4 * obj4;
				object obj10 = obj9 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)maxArmLength))
				{
					result = player.PositionWithOffset(leftHandTransform, offsetVector);
					goto IL_02c7;
				}
				if ((object)headCollider != null)
				{
					Transform transform2 = headCollider.transform;
					if ((object)transform2 != null)
					{
						Vector3 position2 = transform2.position;
						Vector3 vector2 = ((Player)position2).PositionWithOffset(leftHandTransform, offsetVector);
						if ((object)headCollider != null)
						{
							Transform transform3 = headCollider.transform;
							if ((object)transform3 != null)
							{
								Vector3 position3 = transform3.position;
								result = (Vector3)obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v10 (UnityEngine.Vector3)+E4]");
								bool flag2 = (nint)0 == 0;
								object obj11 = !flag2;
								if (obj11 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+F0]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								if (num3 <= 0)
								{
								}
								goto IL_02c7;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
		IL_02c7:
		return result;
	}

	private Vector3 CurrentRightHandPosition()
	{
		//IL_0234: Expected VT, but got Obj
		//IL_0245: Expected Obj, but got VT
		//IL_0262: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I4
		//IL_00d5: Invalid comparison between Obj and F4
		//IL_0173: Expected Obj, but got VT
		//IL_02d9: Expected VT, but got Obj
		//IL_02fb: Expected Obj, but got I4
		Vector3 offsetVector = default;
		Vector3 vector = PositionWithOffset(rightHandTransform, offsetVector);
		Vector3 result;
		if ((object)headCollider != null)
		{
			Transform transform = headCollider.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				object obj = rightHandOffset - rightHandOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+E0]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+E0]");
				object obj2 = num - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+E4]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+E4]");
				object obj4 = num2 - 0;
				Player player = (Player)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v9 (GorillaLocomotion.Player)+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = obj * obj;
				object obj7 = obj2 * obj2;
				object obj8 = obj6 + obj7;
				object obj9 = obj4 * obj4;
				object obj10 = obj9 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)maxArmLength))
				{
					result = player.PositionWithOffset(rightHandTransform, offsetVector);
					goto IL_02c7;
				}
				if ((object)headCollider != null)
				{
					Transform transform2 = headCollider.transform;
					if ((object)transform2 != null)
					{
						Vector3 position2 = transform2.position;
						Vector3 vector2 = ((Player)position2).PositionWithOffset(rightHandTransform, offsetVector);
						if ((object)headCollider != null)
						{
							Transform transform3 = headCollider.transform;
							if ((object)transform3 != null)
							{
								Vector3 position3 = transform3.position;
								result = (Vector3)obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v10 (UnityEngine.Vector3)+E4]");
								bool flag2 = (nint)0 == 0;
								object obj11 = !flag2;
								if (obj11 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+E4]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								if (num3 <= 0)
								{
								}
								goto IL_02c7;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
		IL_02c7:
		return result;
	}

	private Vector3 PositionWithOffset(Transform transformToModify, Vector3 offsetVector)
	{
		//IL_0062: Expected VT, but got Obj
		//IL_004b: Expected VT, but got I4
		//IL_004b: Expected VT, but got I4
		if ((object)transformToModify != null)
		{
			Vector3 position = transformToModify.position;
			Quaternion rotation = transformToModify.rotation;
			return (Quaternion)0 * (Vector3)0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	private unsafe void Update()
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected F8, but got I
		//IL_0045: Expected F8, but got Obj
		//IL_00d7: Expected VT, but got I4
		//IL_0137: Invalid comparison between F4 and I4
		//IL_0148: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I4
		//IL_2fe4: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I4
		//IL_0272: Expected VT, but got I4
		//IL_02dd: Expected VT, but got I4
		//IL_0285: Expected VT, but got F4
		//IL_0345: Expected Obj, but got I
		//IL_0362: Expected Obj, but got I
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected VT, but got Unknown
		//IL_0386: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I4
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_041e: Invalid comparison between F8 and I4
		//IL_042d: Invalid comparison between F8 and I4
		//IL_0445: Expected Obj, but got F8
		//IL_0452: Expected Obj, but got F8
		//IL_0487: Expected Obj, but got I4
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_02f0: Expected VT, but got F4
		//IL_27c2: Expected Obj, but got I4
		//IL_27cb: Expected Obj, but got I4
		//IL_27e0: Expected I4, but got I8
		//IL_2817: Expected F4, but got I
		//IL_2823: Unknown result type (might be due to invalid IL or missing references)
		//IL_2828: Expected VT, but got Unknown
		//IL_2831: Unknown result type (might be due to invalid IL or missing references)
		//IL_2836: Expected Obj, but got Unknown
		//IL_285a: Expected Obj, but got I4
		//IL_2863: Expected Obj, but got I4
		//IL_2870: Expected I4, but got I8
		//IL_04eb: Expected Obj, but got I4
		//IL_0503: Expected F4, but got I
		//IL_0518: Expected I4, but got I8
		//IL_2887: Unknown result type (might be due to invalid IL or missing references)
		//IL_288c: Expected Obj, but got Unknown
		//IL_28a6: Expected Obj, but got I4
		//IL_28b6: Expected F4, but got I
		//IL_2906: Expected F4, but got I
		//IL_290e: Expected VT, but got F8
		//IL_0cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected Obj, but got Unknown
		//IL_0cfc: Expected Obj, but got I4
		//IL_0890: Expected Obj, but got I4
		//IL_089d: Expected I4, but got I8
		//IL_05a3: Expected Ref, but got F4
		//IL_05a3: Expected Ref, but got F8
		//IL_05a3: Expected VT, but got Ref
		//IL_05a3: Expected VT, but got Ref
		//IL_05a3: Expected VT, but got I4
		//IL_0dec: Expected Ref, but got VT
		//IL_0df4: Expected I4, but got VT
		//IL_0a85: Expected Obj, but got I4
		//IL_0ad5: Expected VT, but got F8
		//IL_06a8: Expected VT, but got I4
		//IL_06b0: Expected VT, but got Ref
		//IL_06b8: Expected VT, but got Ref
		//IL_06c1: Expected Obj, but got I4
		//IL_06d1: Expected F8, but got I
		//IL_06de: Expected I4, but got I8
		//IL_06ee: Expected F4, but got I
		//IL_06f8: Expected F8, but got VT
		//IL_0d65: Expected F8, but got VT
		//IL_091f: Expected Ref, but got F4
		//IL_091f: Expected Ref, but got F8
		//IL_091f: Expected VT, but got Ref
		//IL_091f: Expected VT, but got Ref
		//IL_091f: Expected VT, but got I4
		//IL_0e3e: Expected Ref, but got VT
		//IL_0e4e: Expected I4, but got VT
		//IL_0a2c: Expected Obj, but got I4
		//IL_0a35: Expected VT, but got I4
		//IL_0a3d: Expected VT, but got Ref
		//IL_0a45: Expected VT, but got Ref
		//IL_0a5a: Expected I4, but got I8
		//IL_0a6a: Expected F4, but got I
		//IL_075a: Expected I4, but got I8
		//IL_0774: Expected Obj, but got I4
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected Ref, but got Unknown
		//IL_0830: Expected VT, but got I4
		//IL_0838: Expected VT, but got Ref
		//IL_0840: Expected VT, but got Ref
		//IL_0851: Expected Obj, but got I4
		//IL_05f7: Expected Obj, but got I
		//IL_0621: Expected Obj, but got I4
		//IL_0b42: Expected I4, but got I8
		//IL_0b5c: Expected Obj, but got I4
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected Obj, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_07aa: Expected Obj, but got VT
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected Obj, but got Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected Obj, but got Unknown
		//IL_0662: Expected VT, but got Ref
		//IL_0662: Expected VT, but got Ref
		//IL_0662: Expected VT, but got I4
		//IL_0662: Expected VT, but got Obj
		//IL_0680: Expected F4, but got I
		//IL_0690: Expected F8, but got I
		//IL_069a: Expected F8, but got VT
		//IL_0be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be6: Expected Ref, but got Unknown
		//IL_0c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0b: Expected Obj, but got Unknown
		//IL_0c2b: Expected Obj, but got I4
		//IL_0c34: Expected VT, but got I4
		//IL_0c3c: Expected VT, but got Ref
		//IL_0c44: Expected VT, but got Ref
		//IL_0c64: Expected F8, but got VT
		//IL_0c7d: Expected Obj, but got I4
		//IL_0c86: Expected VT, but got I4
		//IL_0c8e: Expected VT, but got Ref
		//IL_0c96: Expected VT, but got Ref
		//IL_0973: Expected Obj, but got I
		//IL_099d: Expected Obj, but got I4
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Expected Obj, but got Unknown
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Expected Obj, but got Unknown
		//IL_0bb8: Expected VT, but got Obj
		//IL_09de: Expected VT, but got Ref
		//IL_09de: Expected VT, but got Ref
		//IL_09de: Expected VT, but got I4
		//IL_09de: Expected VT, but got Obj
		//IL_0a06: Expected F8, but got I
		//IL_0a16: Expected F4, but got I
		//IL_0f61: Expected F4, but got I
		//IL_0f61: Expected VT, but got I4
		//IL_0f61: Expected F4, but got VT
		//IL_0f61: Expected VT, but got Ref
		//IL_3015: Expected Obj, but got I
		//IL_302d: Expected Obj, but got I
		//IL_30c5: Expected F8, but got I
		//IL_30d5: Invalid comparison between F8 and I
		//IL_13e8: Expected VT, but got F8
		//IL_141b: Expected Obj, but got I4
		//IL_16c0: Expected VT, but got F8
		//IL_1381: Expected VT, but got I4
		//IL_2aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af0: Expected Obj, but got Unknown
		//IL_2b14: Expected Obj, but got I4
		//IL_1442: Expected F8, but got I
		//IL_1452: Expected F8, but got I
		//IL_146d: Expected F4, but got VT
		//IL_1494: Expected F8, but got I
		//IL_14a4: Expected F8, but got I
		//IL_14ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b2: Expected Obj, but got Unknown
		//IL_194b: Expected VT, but got F8
		//IL_1965: Expected VT, but got I4
		//IL_152e: Expected Obj, but got I4
		//IL_2958: Expected Obj, but got I
		//IL_2982: Expected Obj, but got I4
		//IL_16df: Expected F8, but got I
		//IL_16ef: Expected F8, but got I
		//IL_170a: Expected F4, but got VT
		//IL_1731: Expected F8, but got I
		//IL_1741: Expected F8, but got I
		//IL_174a: Unknown result type (might be due to invalid IL or missing references)
		//IL_174f: Expected Obj, but got Unknown
		//IL_155b: Expected Obj, but got I4
		//IL_14d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dd: Expected Obj, but got Unknown
		//IL_17cb: Expected Obj, but got I4
		//IL_2a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a4b: Expected Obj, but got Unknown
		//IL_2a65: Expected Obj, but got I4
		//IL_1985: Invalid comparison between F4 and I4
		//IL_1996: Expected Obj, but got I4
		//IL_19a4: Invalid comparison between F4 and I4
		//IL_19bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c0: Expected Obj, but got Unknown
		//IL_17f8: Expected Obj, but got I4
		//IL_1775: Unknown result type (might be due to invalid IL or missing references)
		//IL_177a: Expected Obj, but got Unknown
		//IL_3116: Expected Obj, but got I4
		//IL_1503: Expected Obj, but got I4
		//IL_1100: Expected Obj, but got I
		//IL_113d: Expected Obj, but got I
		//IL_1167: Expected Obj, but got I4
		//IL_1a13: Invalid comparison between F4 and I4
		//IL_1a24: Expected Obj, but got I4
		//IL_1a32: Invalid comparison between F4 and I4
		//IL_1a43: Expected Obj, but got I4
		//IL_2bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bdd: Expected Obj, but got Unknown
		//IL_2bf7: Expected Obj, but got I4
		//IL_29aa: Expected VT, but got I4
		//IL_29d7: Expected Ref, but got F8
		//IL_29d7: Expected Ref, but got F8
		//IL_29d7: Expected VT, but got Ref
		//IL_29d7: Expected VT, but got Ref
		//IL_29f2: Expected Ref, but got VT
		//IL_29fa: Expected VT, but got Ref
		//IL_2a1c: Expected F8, but got I
		//IL_2a26: Expected F8, but got VT
		//IL_11dd: Expected F4, but got VT
		//IL_11dd: Expected VT, but got Ref
		//IL_1adf: Expected Obj, but got I4
		//IL_3129: Expected Obj, but got I4
		//IL_17a0: Expected Obj, but got I4
		//IL_2cb0: Expected Obj, but got I
		//IL_2cda: Expected Obj, but got I4
		//IL_2b3c: Expected VT, but got I4
		//IL_2b69: Expected Ref, but got F8
		//IL_2b69: Expected Ref, but got F8
		//IL_2b69: Expected VT, but got Ref
		//IL_2b69: Expected VT, but got Ref
		//IL_2b84: Expected Ref, but got VT
		//IL_2b8c: Expected VT, but got Ref
		//IL_2bae: Expected F8, but got I
		//IL_2bb8: Expected F8, but got VT
		//IL_1584: Invalid comparison between F4 and I4
		//IL_15a3: Expected F8, but got I4
		//IL_2d98: Expected Obj, but got I
		//IL_2dd9: Expected Obj, but got I4
		//IL_1bde: Expected Obj, but got VT
		//IL_1bfb: Expected Obj, but got I
		//IL_2a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7e: Expected Obj, but got Unknown
		//IL_2a9f: Expected VT, but got Obj
		//IL_2ab1: Expected I4, but got I8
		//IL_2acb: Expected Obj, but got I4
		//IL_2e57: Expected Obj, but got I
		//IL_2e98: Expected Obj, but got I4
		//IL_1821: Invalid comparison between F4 and I4
		//IL_1840: Expected F8, but got I4
		//IL_166d: Expected Ref, but got VT
		//IL_1675: Expected VT, but got Ref
		//IL_16a7: Expected F8, but got I
		//IL_214a: Expected Obj, but got I4
		//IL_1b2c: Expected F8, but got VT
		//IL_1b3c: Expected F4, but got I
		//IL_1b4c: Expected F8, but got I
		//IL_2c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c10: Expected Obj, but got Unknown
		//IL_2c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c1b: Expected Obj, but got Unknown
		//IL_2c4c: Expected I4, but got I8
		//IL_2c66: Expected Obj, but got I4
		//IL_2c6f: Expected VT, but got I4
		//IL_15f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fe: Expected Obj, but got Unknown
		//IL_1604: Unknown result type (might be due to invalid IL or missing references)
		//IL_1609: Expected Obj, but got Unknown
		//IL_1613: Expected I4, but got Obj
		//IL_161d: Expected Obj, but got VT
		//IL_1623: Unknown result type (might be due to invalid IL or missing references)
		//IL_1628: Expected Obj, but got Unknown
		//IL_256a: Expected VT, but got I4
		//IL_1b8a: Expected F8, but got VT
		//IL_1b9a: Expected F4, but got I
		//IL_1baa: Expected F8, but got I
		//IL_2d12: Expected Obj, but got I4
		//IL_1900: Expected I4, but got VT
		//IL_1908: Expected VT, but got Ref
		//IL_1932: Expected F8, but got I
		//IL_1896: Unknown result type (might be due to invalid IL or missing references)
		//IL_189b: Expected Obj, but got Unknown
		//IL_18a5: Expected VT, but got Obj
		//IL_18c8: Expected VT, but got Obj
		//IL_2639: Expected VT, but got I4
		//IL_2653: Expected Obj, but got I4
		//IL_2528: Expected Obj, but got I4
		//IL_1d4b: Expected F4, but got I
		//IL_1d55: Expected F8, but got VT
		//IL_2f25: Expected Obj, but got I4
		//IL_2d52: Expected VT, but got I4
		//IL_2d5b: Expected VT, but got I4
		//IL_3158: Expected Obj, but got I4
		//IL_25f7: Expected Obj, but got I4
		//IL_2f46: Expected VT, but got F4
		//IL_2f83: Expected VT, but got F4
		//IL_1db9: Expected Obj, but got I
		//IL_1dd1: Expected Obj, but got I
		//IL_1de9: Expected Obj, but got I
		//IL_1cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d02: Expected Obj, but got Unknown
		//IL_1d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d17: Expected Obj, but got Unknown
		//IL_2e11: Expected Obj, but got I4
		//IL_2ed0: Expected Obj, but got I4
		//IL_202a: Expected Obj, but got I
		//IL_208b: Expected Obj, but got I4
		//IL_237f: Expected Obj, but got I
		//IL_23b3: Expected Obj, but got I4
		//IL_20e8: Expected VT, but got Ref
		//IL_23ee: Expected VT, but got Ref
		//IL_243a: Expected VT, but got F8
		//IL_245e: Expected Obj, but got I4
		//IL_2711: Expected VT, but got F8
		double num;
		double num2;
		float time;
		object obj4;
		Vector3 move;
		object obj14;
		object obj15;
		object obj19 = default;
		double num11;
		double num12;
		float num13;
		object obj28;
		double num14;
		int num15;
		float num16;
		double num17;
		double num18;
		float num19;
		Vector3 vector6 = default;
		Quaternion toTurn = default;
		bool singleHand = default;
		Vector3 vector7 = default;
		Vector3 vector8 = default;
		Quaternion quaternion = default;
		object obj32 = default;
		if ((object)bodyCollider != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v8+4]");
			num = 0.0;
			num2 = (double)obj3;
			Transform transform = bodyCollider.transform;
			if ((object)headCollider != null)
			{
				Transform transform2 = headCollider.transform;
				if ((object)transform2 != null)
				{
					Vector3 eulerAngles = transform2.eulerAngles;
					if ((object)transform != null)
					{
						transform.eulerAngles = (Vector3)0;
						leftSlip = 0f;
						if (intoNow != null)
						{
							bool[] array = default;
							array[0] = false;
							time = Time.time;
							float num3 = time - launchedUntil;
							bool flag = num3 < 0f;
							obj4 = !flag;
							if ((object)leftHandTransform != null)
							{
								Quaternion rotation = leftHandTransform.rotation;
								if ((object)rightHandTransform != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
									object obj5 = 0;
									Quaternion rotation2 = rightHandTransform.rotation;
									object obj6 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X0_v18+E4]");
									bool flag2 = (nint)0 == 0;
									object obj7 = !flag2;
									if (obj7 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag3 = GillaOneArm.Resting(0);
									bool flag4 = GillaOneArm.Resting(1);
									if (~(leftWasResting ? 1u : 0u) == 0)
									{
										bool flag5 = !flag3;
										object obj8 = !flag5;
										if (obj8 == null)
										{
											Vector3 vector = CurrentLeftHandPosition();
											Vector3 vector2 = OnYourSide((Vector3)0);
											lastLeftHandPosition = (Vector3)time;
											_ = 0;
											wasLeftHandTouching = false;
										}
									}
									if (~(rightWasResting ? 1u : 0u) == 0)
									{
										bool flag6 = !flag4;
										object obj9 = !flag6;
										if (obj9 == null)
										{
											Vector3 vector3 = CurrentRightHandPosition();
											Vector3 vector4 = OnYourSide((Vector3)0);
											lastRightHandPosition = (Vector3)time;
											_ = 0;
											wasRightHandTouching = false;
										}
									}
									leftWasResting = flag3;
									rightWasResting = flag4;
									object obj10 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X8_v17+A0]");
									object obj11 = 0;
									float deltaTime = Time.deltaTime;
									float deltaTime2 = Time.deltaTime;
									Transform transform3 = base.transform;
									if ((object)transform3 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v18+2C]");
										nint num4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v18+2C]");
										object obj12 = num4 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v18+24]");
										nint num5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v18+24]");
										object obj13 = num5 + 0;
										move = (Vector3)(this + 272);
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										obj14 = rightHandDisabled | flag4;
										obj15 = leftHandDisabled | flag3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A81C]");
										object obj16 = obj12 * 0;
										object obj17 = obj13 * 0;
										float num6 = deltaTime * (float)obj16;
										object obj18 = default;
										double num7 = (double)obj17 * (double)obj18;
										float num8 = deltaTime2 * num6;
										double num9 = num7 * (double)obj19;
										Vector3 lossyScale = transform3.lossyScale;
										double num10 = num7 - 1.0;
										bool flag7 = num10 < 0.0;
										bool flag8 = num10 == 0.0;
										object obj20 = num7 ^ 1.0;
										object obj21 = num7 ^ num10;
										object obj22 = obj20 & obj21;
										bool flag9 = (nint)obj22 < 0;
										bool flag10 = flag7 == flag9;
										object obj23 = !flag8;
										object obj24 = flag10 & obj23;
										object obj25 = ~obj24;
										num11 = ((obj25 != null) ? num7 : 1.0);
										object obj26 = default;
										num12 = num9 * (double)obj26;
										num13 = num8 * (float)num11;
										Vector3 vector5 = CurrentLeftHandPosition();
										bool flag11 = obj15 == null;
										object obj27 = !flag11;
										obj28 = 0;
										num14 = num12;
										num15 = -1;
										num16 = deltaTime2;
										if (obj27 != null)
										{
											goto IL_27f7;
										}
										bool flag12 = time < launchedUntil;
										num17 = num2;
										obj28 = 0;
										num18 = num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v8+8]");
										num19 = 0f;
										num14 = num12;
										num15 = -1;
										num16 = deltaTime2;
										if (!flag12)
										{
											float num20 = deltaTime2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+58]");
											float num21 = num20 - 0f;
											double num22 = num11 - (double)lastLeftHandPosition;
											float num23 = num13 + num21;
											double num24 = num22 + num12;
											int num25 = default;
											if (!HandCast(0, leftHeld, (Vector3)1, (Quaternion)(&vector6), (Vector3)(&num25), toTurn, singleHand, out *(Vector3*)num24, out *(int*)num23))
											{
												vector7 = (Vector3)1;
												vector8 = (Vector3)(&num25);
												quaternion = (Quaternion)(&vector6);
												obj28 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+54]");
												num14 = 0.0;
												num15 = -1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+58]");
												num16 = 0f;
												num11 = (double)lastLeftHandPosition;
												goto IL_27f7;
											}
											float num26;
											double num27;
											if (~(wasLeftHandTouching ? 1u : 0u) == 0)
											{
												Vector3 vector9 = CurrentLeftHandPosition();
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
												object obj29 = 0;
												object obj30 = obj29;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1587 @ X0_v255+E4]");
												bool flag13 = (nint)0 == 0;
												object obj31 = !flag13;
												if (obj31 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Vector3 vector10 = StillOn(leftHeld, leftWhich, (Vector3)leftHeld, (Quaternion)1, (Vector3)(&vector6), (Quaternion)(&num25));
												num15 = leftWhich;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+58]");
												num26 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+54]");
												num18 = 0.0;
												num27 = (double)lastLeftHandPosition;
											}
											else
											{
												Vector3 vector11 = CurrentLeftHandPosition();
												num27 = (double)vector6 - (double)lastLeftHandPosition;
												double num28 = (double)obj32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+54]");
												num18 = num28 - 0.0;
												float num29 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+58]");
												num26 = num29 - 0f;
												int num30 = (int)(num25 & 0x80000000L);
												bool flag14 = num30 == 0;
												object obj33 = !flag14;
												num15 = num25;
												if (obj33 == null)
												{
													object obj34 = this + 380;
													object obj35 = this + 260;
													obj34 = hitPoint;
													object obj36 = this + 404;
													object obj37 = this + 440;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+178]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+10C]");
													_ = 0;
													obj36 = obj35;
													leftHeldOn = hitCollider;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													num15 = num25;
												}
											}
											Vector3 vector12 = Touch(move, out *(float*)(this + 280), out *(Vector3*)1);
											vector7 = (Vector3)1;
											vector8 = (Vector3)(&num25);
											quaternion = (Quaternion)(&vector6);
											num17 = num27;
											obj28 = 1;
											num19 = num26;
											num14 = num18;
											num16 = num26;
											num11 = num27;
										}
										goto IL_281d;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_2734;
		IL_1a6b:
		bool flag15 = (byte)(~(disableMovement ? 1u : 0u)) != 0;
		double num32;
		double num31 = num32;
		if (!flag15)
		{
			goto IL_1a8c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj38 = 0;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2581 @ X0_v149+E4]");
		bool flag16 = (nint)0 == 0;
		object obj40 = !flag16;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj41 = denormalizedVelocityAverage * denormalizedVelocityAverage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+C4]");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+C4]");
		object obj42 = num33 * 0;
		object obj43 = obj41 + obj42;
		object obj44 = default;
		double num34 = (double)obj43 + (double)obj44;
		float num35 = velocityLimit;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double num37;
		float num38;
		float num39;
		double num40;
		Vector3 vector14;
		if (num34 > (double)velocityLimit)
		{
			object obj45 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2805 @ X0_v152+E4]");
			bool flag17 = (nint)0 == 0;
			object obj46 = !flag17;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num36 = (float)obj44 * jumpMultiplier;
			Rigidbody rigidbody;
			if (num36 > maxJumpSpeed)
			{
				object obj47 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2879 @ X0_v158+E4]");
				bool flag18 = (nint)0 == 0;
				object obj48 = !flag18;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				object obj49;
				object obj50;
				if ((nint)obj44 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Vector3 vector13 = denormalizedVelocityAverage;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					obj49 = vector13 / 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+C8]");
					obj50 = 0 / obj44;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj51 = 0;
					object obj52 = obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2926 @ X8_v93+A0]");
					object obj53 = 0;
					obj49 = obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2927 @ X8_v94+8]");
					obj50 = 0;
				}
				if ((object)playerRigidBody == null)
				{
					goto IL_2734;
				}
				num34 = (double)obj49 * (double)obj19;
				num37 = (double)obj50 * (double)maxJumpSpeed;
				num35 = num38;
				rigidbody = playerRigidBody;
			}
			else
			{
				if ((object)playerRigidBody == null)
				{
					goto IL_2734;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+C4]");
				num39 = 0f;
				num40 = (double)denormalizedVelocityAverage;
				double num41 = jumpMultiplier;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+C8]");
				num37 = num41 * 0.0;
				float num42 = jumpMultiplier;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+C4]");
				num35 = num42 * 0f;
				num34 = (double)jumpMultiplier * (double)denormalizedVelocityAverage;
				rigidbody = playerRigidBody;
			}
			rigidbody.linearVelocity = (Vector3)0;
			vector14 = (Vector3)0;
		}
		goto IL_1e25;
		IL_2b22:
		object obj54;
		bool flag19 = obj54 == null;
		Vector3 vector15 = (Vector3)(!flag19);
		int num43 = default;
		double num45;
		double num44;
		bool flag20 = HandCast(1, rightHeld, vector15, (Quaternion)(&vector6), (Vector3)(&num43), toTurn, singleHand, out *(Vector3*)num44, out *(int*)num45);
		bool flag21 = !flag20;
		ref Vector3 reference = ref *(Vector3*)vector15;
		Vector3 vector16 = (Vector3)(&num43);
		ref RaycastHit reference2 = ref *(RaycastHit*)rightHeld;
		bool flag22 = (byte)(&vector6) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+64]");
		num37 = 0.0;
		num31 = (double)lastRightHandPosition;
		int num46 = 1;
		if (flag21)
		{
			goto IL_1937;
		}
		double num47 = hitSlip;
		bool flag23 = hitSlip < 0f;
		lastRightHandPosition = vector6;
		_ = 0;
		num31 = 0.0;
		if (!flag23)
		{
			bool flag24 = !((double)hitSlip > 1.0);
			num31 = hitSlip;
			if (!flag24)
			{
				num31 = 1.0;
			}
		}
		object obj55 = this + 260;
		object obj56 = this + 292;
		rightSlip = (float)num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+10C]");
		_ = 0;
		obj56 = obj55;
		int num48 = (int)(num43 & 0x80000000L);
		bool flag25 = num48 == 0;
		object obj57 = !flag25;
		vector14 = (Vector3)1;
		if (obj57 == null)
		{
			object obj58 = this + 448;
			vector14 = (Vector3)hitCollider;
			rightHeldAt = hitPoint;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+178]");
			_ = 0;
			rightHeldFaces = (Vector3)obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2478 @ X8_v104+8]");
			_ = 0;
			rightHeldOn = hitCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj59 = obj4;
		int layerMask = (int)vector15;
		vector16 = (Vector3)(&num43);
		reference2 = ref *(RaycastHit*)rightHeld;
		flag22 = (byte)(&vector6) != 0;
		int num49 = num43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+64]");
		num37 = 0.0;
		goto IL_2c7d;
		IL_281d:
		Vector3 move2 = (Vector3)(this + 276);
		object obj60 = obj14 & 0xFF;
		Vector3 vector17 = CurrentRightHandPosition();
		bool flag26 = obj60 == null;
		object obj61 = !flag26;
		object obj62 = 0;
		int num50 = -1;
		float num62 = default;
		float num64;
		Vector3 vector23;
		Quaternion quaternion2;
		double num65;
		float num66;
		float num67;
		Vector3 vector24;
		double num68;
		if (obj61 == null)
		{
			bool flag27 = time < launchedUntil;
			obj62 = 0;
			num50 = -1;
			if (!flag27)
			{
				float num51 = num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+64]");
				float num52 = num51 - 0f;
				double num53 = num11 - (double)lastRightHandPosition;
				float num54 = num13 + num52;
				double num55 = num12 + num53;
				int num56 = default;
				double num59 = default;
				float num63 = default;
				if (HandCast(1, rightHeld, (Vector3)1, (Quaternion)(&vector6), (Vector3)(&num56), toTurn, singleHand, out *(Vector3*)num55, out *(int*)num54))
				{
					Vector3 vector20;
					double num57;
					float num58;
					if (~(wasRightHandTouching ? 1u : 0u) == 0)
					{
						Vector3 vector18 = CurrentRightHandPosition();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
						object obj63 = 0;
						object obj64 = obj63;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ X0_v238+E4]");
						bool flag28 = (nint)0 == 0;
						object obj65 = !flag28;
						if (obj65 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Vector3 vector19 = StillOn(rightHeld, rightWhich, (Vector3)rightHeld, (Quaternion)1, (Vector3)(&vector6), (Quaternion)(&num56));
						num50 = rightWhich;
						vector20 = lastRightHandPosition;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+60]");
						num57 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+64]");
						num58 = 0f;
					}
					else
					{
						Vector3 vector21 = CurrentRightHandPosition();
						vector20 = vector6 - lastRightHandPosition;
						num57 = (double)obj32 - num59;
						float num60 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+64]");
						num58 = num60 - 0f;
						int num61 = (int)(num56 & 0x80000000L);
						bool flag29 = num61 == 0;
						object obj66 = !flag29;
						num50 = num56;
						if (obj66 == null)
						{
							object obj67 = this + 260;
							object obj68 = this + 448;
							rightHeldAt = hitPoint;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+178]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+10C]");
							_ = 0;
							rightHeldFaces = (Vector3)obj67;
							rightHeldOn = hitCollider;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							num50 = num56;
						}
					}
					Vector3 vector22 = Touch(move2, out *(float*)(this + 292), out *(Vector3*)1);
					object obj69 = obj28 & 1;
					bool flag30 = obj69 == null;
					num62 = num63;
					obj62 = 1;
					vector7 = (Vector3)1;
					vector8 = (Vector3)(&num56);
					quaternion = (Quaternion)(&vector6);
					num14 = num57;
					num16 = num58;
					num64 = num58;
					num2 = (double)vector20;
					num = num57;
					num38 = num63;
					obj59 = 1;
					vector23 = (Vector3)1;
					vector16 = (Vector3)(&num56);
					quaternion2 = (Quaternion)(&vector6);
					num65 = num57;
					num49 = num50;
					num66 = num58;
					num67 = num58;
					vector24 = vector20;
					num68 = num57;
					if (flag30)
					{
						goto IL_0a6f;
					}
					goto IL_0cd4;
				}
				num62 = num63;
				obj62 = 0;
				vector7 = (Vector3)1;
				vector8 = (Vector3)(&num56);
				quaternion = (Quaternion)(&vector6);
				num14 = num59;
				num50 = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+64]");
				num16 = 0f;
			}
		}
		object obj70 = obj28 & 1;
		bool flag31 = obj70 == null;
		object obj71 = !flag31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v8+8]");
		num64 = 0f;
		num38 = num62;
		obj59 = obj62;
		vector23 = vector7;
		vector16 = vector8;
		quaternion2 = quaternion;
		num65 = num14;
		num49 = num50;
		num66 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v8+8]");
		num67 = 0f;
		vector24 = (Vector3)num2;
		num68 = num;
		if (obj71 == null)
		{
			goto IL_0a6f;
		}
		goto IL_0cd4;
		IL_2990:
		object obj72;
		bool flag32 = obj72 == null;
		Vector3 vector25 = (Vector3)(!flag32);
		int num69 = default;
		double num70;
		bool flag33 = HandCast(0, leftHeld, vector25, (Quaternion)(&vector6), (Vector3)(&num69), toTurn, singleHand, out *(Vector3*)num44, out *(int*)num70);
		bool flag34 = !flag33;
		reference = ref *(Vector3*)vector25;
		vector16 = (Vector3)(&num69);
		reference2 = ref *(RaycastHit*)leftHeld;
		flag22 = (byte)(&vector6) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+58]");
		num37 = 0.0;
		num31 = (double)lastLeftHandPosition;
		num46 = 0;
		if (flag34)
		{
			goto IL_16ac;
		}
		num47 = hitSlip;
		bool flag35 = hitSlip < 0f;
		lastLeftHandPosition = vector6;
		_ = 0;
		num31 = 0.0;
		if (!flag35)
		{
			bool flag36 = !((double)hitSlip > 1.0);
			num31 = hitSlip;
			if (!flag36)
			{
				num31 = 1.0;
			}
		}
		object obj73 = this + 260;
		leftSlip = (float)num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+10C]");
		_ = 0;
		leftSlipNormal = (Vector3)obj73;
		int num71 = (int)(num69 & 0x80000000L);
		bool flag37 = num71 == 0;
		object obj74 = !flag37;
		num46 = 0;
		if (obj74 == null)
		{
			object obj75 = this + 380;
			object obj76 = this + 440;
			num46 = (int)hitCollider;
			obj75 = hitPoint;
			object obj77 = this + 404;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+178]");
			_ = 0;
			obj77 = obj73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2279 @ X8_v116+8]");
			_ = 0;
			leftHeldOn = hitCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		reference = ref *(Vector3*)vector25;
		vector16 = (Vector3)(&num69);
		reference2 = ref *(RaycastHit*)leftHeld;
		flag22 = (byte)(&vector6) != 0;
		obj28 = obj4;
		num15 = num69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+58]");
		num37 = 0.0;
		goto IL_2ae2;
		IL_1937:
		Vector3 vector26 = CurrentRightHandPosition();
		lastRightHandPosition = (Vector3)num31;
		layerMask = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		vector14 = (Vector3)num46;
		goto IL_2c7d;
		IL_1a8c:
		object obj78 = obj28 | obj59;
		bool flag38 = (nint)obj78 != 1;
		num35 = (float)num47;
		num34 = num31;
		if (!flag38)
		{
			goto IL_1ac9;
		}
		goto IL_1e25;
		IL_3108:
		bool flag39;
		obj72 = (flag39 ? 1 : 0) ^ 1;
		goto IL_2990;
		IL_3005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj79 = 0;
		object obj80 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1838 @ X8_v29+A0]");
		object obj81 = 0;
		double num73;
		double num72 = num73;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ X8_v30+8]");
		num37 = num72 - 0.0;
		double num75;
		double num74 = num75;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ X8_v30+4]");
		double num76 = num74 - 0.0;
		double num78;
		double num77 = num78 - (double)obj81;
		double num79 = num77 * num77;
		double num80 = num76 * num76;
		double num81 = num79 + num80;
		double num82 = num37 * num37;
		num31 = num82 + num81;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		num47 = 0.0;
		double num83 = num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if (num83 < 0.0)
		{
			goto IL_1386;
		}
		Transform transform4 = base.transform;
		Transform transform5 = base.transform;
		if ((object)transform5 != null)
		{
			Vector3 position = transform5.position;
			if ((object)transform4 != null)
			{
				num37 = num73 + num37;
				num47 = num75 + num47;
				num31 = num78 + num31;
				transform4.position = (Vector3)0;
				goto IL_1386;
			}
		}
		goto IL_2734;
		IL_16ac:
		Vector3 vector27 = CurrentLeftHandPosition();
		lastLeftHandPosition = (Vector3)num31;
		goto IL_2ae2;
		IL_21a0:
		Vector3 vector28 = CurrentRightHandPosition();
		double num84 = num34 - (double)lastRightHandPosition;
		float num85 = num35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+60]");
		float num86 = num85 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj82 = 0;
		double num87 = num37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+64]");
		double num88 = num87 - 0.0;
		object obj83 = obj82;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2824 @ X0_v74+E4]");
		bool flag40 = (nint)0 == 0;
		object obj84 = !flag40;
		if (obj84 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num89 = num84 * num84;
		float num90 = num86 * num86;
		double num91 = num89 + (double)num90;
		double num92 = num88 * num88;
		double num93 = num91 + num92;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (!(num93 > (double)unStickDistance))
		{
			goto IL_2410;
		}
		object obj90 = default;
		bool flag43;
		bool flag44;
		bool flag45;
		if ((object)headCollider != null)
		{
			Transform transform6 = headCollider.transform;
			if ((object)transform6 != null)
			{
				Vector3 position2 = transform6.position;
				Vector3 vector29 = CurrentRightHandPosition();
				if ((object)headCollider != null)
				{
					Transform transform7 = headCollider.transform;
					if ((object)transform7 != null)
					{
						Vector3 position3 = transform7.position;
						Vector3 vector30 = CurrentRightHandPosition();
						if ((object)headCollider != null)
						{
							Transform transform8 = headCollider.transform;
							if ((object)transform8 != null)
							{
								Vector3 position4 = transform8.position;
								object obj85 = obj82;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3003 @ X0_v91+E4]");
								bool flag41 = (nint)0 == 0;
								object obj86 = !flag41;
								if (obj86 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
								object obj87 = 0;
								object obj88 = obj87;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3021 @ X0_v93+E4]");
								bool flag42 = (nint)0 == 0;
								object obj89 = !flag42;
								if (obj89 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (Physics.SphereCast((Vector3)(&obj90), (float)num93, (Vector3)locomotionEnabledLayers, out *(RaycastHit*)null, unStickDistance, layerMask))
								{
									goto IL_2410;
								}
								Vector3 vector31 = CurrentRightHandPosition();
								lastRightHandPosition = (Vector3)num93;
								_ = unStickDistance;
								flag43 = false;
								flag44 = flag45;
								goto IL_2ede;
							}
						}
					}
				}
			}
		}
		goto IL_2734;
		IL_2ede:
		if (~(leftHandDisabled ? 1u : 0u) == 0)
		{
			if ((object)headCollider != null)
			{
				Transform transform9 = headCollider.transform;
				if ((object)transform9 != null)
				{
					Vector3 position5 = transform9.position;
					bool flag46 = (object)leftHandFollower == null;
					object obj91 = !flag46;
					if (obj91 != null)
					{
						goto IL_255a;
					}
				}
			}
		}
		else if ((object)leftHandFollower != null)
		{
			goto IL_255a;
		}
		goto IL_2734;
		IL_2ae2:
		object obj92 = obj14 & 0xFF;
		Vector3 vector32 = CurrentRightHandPosition();
		bool flag47 = obj92 == null;
		object obj93 = !flag47;
		if (obj93 != null)
		{
			goto IL_1937;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+60]");
		num47 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+164]");
		double num94 = 0.0;
		num44 = num31 - (double)lastRightHandPosition;
		num39 = (float)lastRightTurn;
		double num95 = num37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+64]");
		num45 = num95 - 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+15C]");
		num40 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+160]");
		double num96 = 0.0;
		object obj94 = obj28 & 1;
		bool flag48;
		if (obj94 != null)
		{
			object obj95 = obj59 & 1;
			if (obj95 != null)
			{
				obj54 = 0;
				goto IL_2b22;
			}
		}
		else
		{
			flag48 = wasLeftHandTouching;
			bool flag49 = !wasLeftHandTouching;
			object obj96 = !flag49;
			object obj97 = ~obj96;
			object obj98 = ((obj97 != null) ? ((object)1) : obj59);
			object obj99 = obj98 & 1;
			bool flag50 = obj99 == null;
			object obj100 = !flag50;
			if (obj100 != null)
			{
				goto IL_311b;
			}
		}
		flag48 = wasRightHandTouching;
		goto IL_311b;
		IL_1ac9:
		bool flag51 = (byte)(~(disableMovement ? 1u : 0u)) != 0;
		object obj101 = !flag51;
		num35 = (float)num47;
		num34 = num31;
		if (obj101 == null)
		{
			bool flag52 = obj28 == null;
			num35 = (float)num47;
			if (!flag52)
			{
				num31 = (double)leftSlipNormal;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+11C]");
				num35 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+120]");
				num37 = 0.0;
				PushOff(vector14);
			}
			bool flag53 = obj59 == null;
			num34 = num31;
			if (!flag53)
			{
				num34 = (double)rightSlipNormal;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+128]");
				num35 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+12C]");
				num37 = 0.0;
				PushOff(vector14);
			}
		}
		goto IL_1e25;
		IL_0a6f:
		bool flag54 = (byte)(~(wasLeftHandTouching ? 1u : 0u)) != 0;
		object obj102 = !flag54;
		num38 = num62;
		obj59 = obj62;
		vector23 = vector7;
		vector16 = vector8;
		quaternion2 = quaternion;
		num65 = num14;
		num49 = num50;
		num66 = num16;
		num67 = num64;
		vector24 = (Vector3)num2;
		num68 = num;
		if (obj102 != null)
		{
			goto IL_0cd4;
		}
		goto IL_0df9;
		IL_2734:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0cd4:
		object obj103 = obj59 & 1;
		bool flag55 = obj103 == null;
		object obj104 = !flag55;
		if (obj104 == null)
		{
			bool flag56 = (byte)(~(wasRightHandTouching ? 1u : 0u)) != 0;
			num62 = num38;
			obj62 = obj59;
			vector7 = vector23;
			vector8 = vector16;
			quaternion = quaternion2;
			num14 = num65;
			num50 = num49;
			num16 = num66;
			num64 = num67;
			num2 = (double)vector24;
			num = num68;
			if (flag56)
			{
				goto IL_0df9;
			}
		}
		double num97 = num17 + (double)vector24;
		num14 = num18 + num68;
		num16 = num19 + num67;
		num78 = num97 * 0.5;
		num75 = num14 * 0.5;
		num73 = (double)num16 * 0.5;
		reference = ref *(Vector3*)vector23;
		flag22 = (byte)(int)quaternion2 != 0;
		goto IL_2924;
		IL_1386:
		if ((object)headCollider != null)
		{
			Transform transform10 = headCollider.transform;
			if ((object)transform10 != null)
			{
				Vector3 position6 = transform10.position;
				lastHeadPosition = (Vector3)num31;
				Vector3 vector33 = CurrentLeftHandPosition();
				bool flag57 = obj15 == null;
				object obj105 = !flag57;
				num46 = 0;
				if (obj105 != null)
				{
					goto IL_16ac;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+54]");
				num47 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+154]");
				num94 = 0.0;
				num44 = num31 - (double)lastLeftHandPosition;
				num39 = (float)lastLeftTurn;
				double num98 = num37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+58]");
				num70 = num98 - 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+14C]");
				num40 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+150]");
				num96 = 0.0;
				object obj106 = obj28 & 1;
				if (obj106 != null)
				{
					object obj107 = obj59 & 1;
					if (obj107 != null)
					{
						obj72 = 0;
						goto IL_2990;
					}
				}
				else
				{
					flag39 = wasLeftHandTouching;
					bool flag58 = !wasLeftHandTouching;
					object obj108 = !flag58;
					object obj109 = ~obj108;
					object obj110 = ((obj109 != null) ? ((object)1) : obj59);
					object obj111 = obj110 & 1;
					bool flag59 = obj111 == null;
					object obj112 = !flag59;
					if (obj112 != null)
					{
						goto IL_3108;
					}
				}
				flag39 = wasRightHandTouching;
				goto IL_3108;
			}
		}
		goto IL_2734;
		IL_0df9:
		num78 = num17 + num2;
		num75 = num18 + num;
		num73 = (double)num19 + (double)num64;
		num38 = num62;
		obj59 = obj62;
		reference = ref *(Vector3*)vector7;
		vector16 = vector8;
		flag22 = (byte)(int)quaternion != 0;
		num49 = num50;
		goto IL_2924;
		IL_24a6:
		flag43 = false;
		goto IL_2ede;
		IL_2924:
		if ((object)headCollider != null)
		{
			float radius = headCollider.radius;
			if ((object)headCollider != null)
			{
				Transform transform11 = headCollider.transform;
				if ((object)transform11 != null)
				{
					Vector3 position7 = transform11.position;
					double num99 = num78 + (double)radius;
					double num100 = num75 + num14;
					double num101 = num73 + (double)num16;
					num44 = defaultPrecision;
					num40 = num99 - (double)lastHeadPosition;
					double num102 = num100;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+6C]");
					num96 = num102 - 0.0;
					double num103 = num101;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+70]");
					num94 = num103 - 0.0;
					Vector3 vector34 = lastHeadPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+6C]");
					bool flag60 = IterativeCollisionSphereCast((Vector3)(&vector6), (float)vector34, (Vector3)0, 0f, out reference, flag22);
					bool flag61 = !flag60;
					reference2 = ref *(RaycastHit*)null;
					num39 = radius;
					if (flag61)
					{
						goto IL_3005;
					}
					if ((object)headCollider != null)
					{
						Transform transform12 = headCollider.transform;
						if ((object)transform12 != null)
						{
							Vector3 position8 = transform12.position;
							if ((object)headCollider != null)
							{
								Transform transform13 = headCollider.transform;
								if ((object)transform13 != null)
								{
									Vector3 position9 = transform13.position;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
									object obj113 = 0;
									object obj114 = obj113;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1972 @ X0_v208+E4]");
									bool flag62 = (nint)0 == 0;
									object obj115 = !flag62;
									if (obj115 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									if ((object)headCollider != null)
									{
										num78 = (double)vector6 - (double)lastHeadPosition;
										double num104 = (double)obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+6C]");
										num75 = num104 - 0.0;
										double num105 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+70]");
										num73 = num105 - 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										float num106 = (float)lastHeadPosition - (float)lastHeadPosition;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+6C]");
										float num107 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+6C]");
										float num108 = num107 - 0f;
										double num109 = num78 + (double)num106;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+70]");
										nint num110 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+70]");
										object obj116 = num110 - 0;
										double num111 = num75 + (double)num108;
										double num112 = num73 + (double)obj116;
										float radius2 = headCollider.radius;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
										object obj117 = 0;
										object obj118 = obj117;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2139 @ X0_v211+E4]");
										bool flag63 = (nint)0 == 0;
										object obj119 = !flag63;
										if (obj119 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float num113 = radius2 * defaultPrecision;
										float num114 = num113;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC2C]");
										float num115 = num114 * 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+6C]");
										num94 = 0.0 + (double)num115;
										bool flag64 = Physics.Raycast((Vector3)(&obj90), (Vector3)locomotionEnabledLayers, out *(RaycastHit*)null, (float)lastHeadPosition, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
										bool flag65 = !flag64;
										num96 = num112;
										reference2 = ref *(RaycastHit*)null;
										num40 = num111;
										num39 = (float)num109;
										if (flag65)
										{
											goto IL_3005;
										}
										if ((object)headCollider != null)
										{
											Transform transform14 = headCollider.transform;
											if ((object)transform14 != null)
											{
												Vector3 position10 = transform14.position;
												num78 = (double)lastHeadPosition - (double)lastHeadPosition;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+6C]");
												double num116 = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+6C]");
												num75 = num116 - 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+70]");
												double num117 = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+70]");
												num73 = num117 - 0.0;
												num96 = num112;
												reference2 = ref *(RaycastHit*)null;
												num40 = num111;
												num39 = (float)num109;
												goto IL_3005;
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
		goto IL_2734;
		IL_2410:
		flag43 = true;
		flag44 = flag45;
		goto IL_2ede;
		IL_255a:
		leftHandFollower.position = (Vector3)0;
		if (~(rightHandDisabled ? 1u : 0u) == 0)
		{
			if ((object)headCollider != null)
			{
				Transform transform15 = headCollider.transform;
				if ((object)transform15 != null)
				{
					Vector3 position11 = transform15.position;
					bool flag66 = (object)rightHandFollower == null;
					object obj120 = !flag66;
					if (obj120 != null)
					{
						goto IL_2629;
					}
				}
			}
		}
		else if ((object)rightHandFollower != null)
		{
			goto IL_2629;
		}
		goto IL_2734;
		IL_27f7:
		num17 = num2;
		num18 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v8+8]");
		num19 = 0f;
		goto IL_281d;
		IL_1e25:
		if (obj28 != null)
		{
			Vector3 vector35 = CurrentLeftHandPosition();
			double num118 = num34 - (double)lastLeftHandPosition;
			float num119 = num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+54]");
			float num120 = num119 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj121 = 0;
			double num121 = num37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+58]");
			double num122 = num121 - 0.0;
			object obj122 = obj121;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2734 @ X0_v111+E4]");
			bool flag67 = (nint)0 == 0;
			object obj123 = !flag67;
			if (obj123 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num123 = num118 * num118;
			float num124 = num120 * num120;
			double num125 = num123 + (double)num124;
			double num126 = num122 * num122;
			num34 = num125 + num126;
			num35 = unStickDistance;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			if (!(num34 > (double)unStickDistance))
			{
				goto IL_2130;
			}
			if ((object)headCollider != null)
			{
				Transform transform16 = headCollider.transform;
				if ((object)transform16 != null)
				{
					Vector3 position12 = transform16.position;
					Vector3 vector36 = CurrentLeftHandPosition();
					if ((object)headCollider != null)
					{
						Transform transform17 = headCollider.transform;
						if ((object)transform17 != null)
						{
							Vector3 position13 = transform17.position;
							Vector3 vector37 = CurrentLeftHandPosition();
							if ((object)headCollider != null)
							{
								Transform transform18 = headCollider.transform;
								if ((object)transform18 != null)
								{
									Vector3 position14 = transform18.position;
									object obj124 = obj121;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2968 @ X0_v128+E4]");
									bool flag68 = (nint)0 == 0;
									object obj125 = !flag68;
									if (obj125 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
									object obj126 = 0;
									object obj127 = obj126;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									float num127 = num35 - num35;
									double num128 = num34 - num34;
									double num129 = num37 - num37;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2986 @ X0_v130+E4]");
									bool flag69 = (nint)0 == 0;
									object obj128 = !flag69;
									if (obj128 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									num44 = num37 - (double)minimumRaycastDistance;
									num39 = minimumRaycastDistance * defaultPrecision;
									bool flag70 = Physics.SphereCast((Vector3)(&obj90), (float)num34, (Vector3)locomotionEnabledLayers, out *(RaycastHit*)null, num35, layerMask);
									bool flag71 = !flag70;
									num94 = num129;
									num96 = num127;
									reference2 = ref *(RaycastHit*)null;
									num40 = num128;
									vector14 = (Vector3)locomotionEnabledLayers;
									if (!flag71)
									{
										goto IL_2130;
									}
									Vector3 vector38 = CurrentLeftHandPosition();
									lastLeftHandPosition = (Vector3)num34;
									bool flag72 = obj59 == null;
									object obj129 = !flag72;
									num94 = num129;
									num96 = num127;
									reference2 = ref *(RaycastHit*)null;
									num40 = num128;
									flag45 = false;
									vector14 = (Vector3)locomotionEnabledLayers;
									flag44 = false;
									if (obj129 != null)
									{
										goto IL_21a0;
									}
									goto IL_24a6;
								}
							}
						}
					}
				}
			}
			goto IL_2734;
		}
		bool flag73 = obj59 == null;
		flag45 = false;
		flag44 = false;
		if (!flag73)
		{
			goto IL_21a0;
		}
		goto IL_24a6;
		IL_311b:
		obj54 = (flag48 ? 1 : 0) ^ 1;
		goto IL_2b22;
		IL_2c7d:
		StoreVelocities();
		if (obj28 != null)
		{
			num31 = move.x;
			bool flag74 = move.x < 0f;
			object obj130 = !flag74;
			bool flag75 = move.x == 0f;
			object obj131 = ~obj130;
			object obj132 = obj131 | flag75;
			num32 = move.x;
			if (obj132 != null)
			{
				goto IL_1a6b;
			}
		}
		if (obj59 == null)
		{
			goto IL_1a8c;
		}
		num32 = move2.x;
		bool flag76 = move2.x < 0f;
		object obj133 = !flag76;
		bool flag77 = move2.x == 0f;
		object obj134 = !flag77;
		object obj135 = obj133 & obj134;
		num31 = move2.x;
		if (obj135 == null)
		{
			goto IL_1a6b;
		}
		goto IL_1ac9;
		IL_2629:
		rightHandFollower.position = (Vector3)0;
		bool flag78 = !flag44;
		object obj136 = !flag78;
		object obj137 = ~obj136;
		int num130 = ((obj137 != null) ? (-1) : num15);
		bool flag79 = !flag43;
		wasLeftHandTouching = flag44;
		leftWhich = num130;
		object obj138 = !flag79;
		object obj139 = ~obj138;
		int num131 = ((obj139 != null) ? (-1) : num49);
		lastLeftTurn = (Quaternion)time;
		rightWhich = num131;
		bool[] array2 = intoNow;
		wasRightHandTouching = flag43;
		_ = 0;
		lastRightTurn = (Quaternion)time;
		_ = 0;
		if (intoNow != null && into != null)
		{
			bool[] array3 = default;
			array3[0] = array2[0];
			array3[1] = array2[1];
			return;
		}
		goto IL_2734;
		IL_2130:
		bool flag80 = obj59 == null;
		object obj140 = !flag80;
		flag45 = true;
		if (obj140 != null)
		{
			goto IL_21a0;
		}
		flag44 = true;
		goto IL_24a6;
	}

	private unsafe bool HandCast(int whose, HeldShape held, Vector3 from, Quaternion fromTurn, Vector3 move, Quaternion toTurn, bool singleHand, out Vector3 end, out int which)
	{
		//IL_1829: Expected native int or pointer, but got VT
		//IL_184b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1850: Expected VT, but got Unknown
		//IL_186e: Expected I4, but got VT
		//IL_186e: Expected Ref, but got VT
		//IL_002f: Expected Obj, but got I4
		//IL_0038: Expected VT, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_18a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a7: Expected Obj, but got Unknown
		//IL_1b3a: Expected Obj, but got I
		//IL_1b78: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I4
		//IL_1977: Expected Obj, but got I
		//IL_19bd: Expected Obj, but got I
		//IL_19e1: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I4
		//IL_18bc: Expected Obj, but got I
		//IL_18cc: Expected Obj, but got I
		//IL_18f3: Expected Obj, but got I
		//IL_1917: Expected Obj, but got I
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_0411: Expected Obj, but got I4
		//IL_0421: Expected Obj, but got I
		//IL_0445: Expected Obj, but got I
		//IL_045e: Expected Obj, but got I4
		//IL_0487: Expected F4, but got I4
		//IL_0498: Expected Obj, but got I4
		//IL_04b3: Expected VT, but got I4
		//IL_04db: Expected F4, but got I
		//IL_1a73: Invalid comparison between F4 and I4
		//IL_038d: Expected Obj, but got I
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03ca: Expected Obj, but got I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected I4, but got Unknown
		//IL_17a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a5: Expected Obj, but got Unknown
		//IL_17cf: Expected Obj, but got VT
		//IL_0512: Invalid comparison between F4 and I4
		//IL_0523: Expected Obj, but got I4
		//IL_055e: Expected F4, but got I
		//IL_0574: Expected VT, but got I4
		//IL_1820: Expected I4, but got Obj
		//IL_0611: Invalid comparison between F4 and I4
		//IL_0622: Expected Obj, but got I4
		//IL_063a: Expected F4, but got I
		//IL_06aa: Expected F4, but got I
		//IL_06c0: Expected VT, but got I4
		//IL_075d: Invalid comparison between F4 and I4
		//IL_076e: Expected Obj, but got I4
		//IL_0786: Expected F4, but got I
		//IL_07b6: Expected F4, but got I
		//IL_1a5b: Expected Obj, but got I4
		//IL_07fc: Expected Obj, but got I
		//IL_0826: Expected Obj, but got I4
		//IL_0a0a: Expected VT, but got I4
		//IL_16e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ea: Expected Obj, but got Unknown
		//IL_1709: Expected Obj, but got I4
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected VT, but got Unknown
		//IL_0a4e: Expected I4, but got VT
		//IL_0a4e: Expected Ref, but got VT
		//IL_0a4e: Expected VT, but got Ref
		//IL_0c1c: Expected VT, but got Ref
		//IL_0c74: Expected Ref, but got F8
		//IL_0c84: Expected Ref, but got F4
		//IL_0c8c: Expected VT, but got Ref
		//IL_0c9c: Expected F8, but got I
		//IL_0ab6: Expected Ref, but got F8
		//IL_0ac6: Expected Ref, but got F4
		//IL_0ae6: Expected F8, but got I
		//IL_0d13: Expected Ref, but got F8
		//IL_0d23: Expected Ref, but got F4
		//IL_0d43: Expected F8, but got I
		//IL_0b1f: Expected Obj, but got I4
		//IL_0b2e: Expected Obj, but got I4
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Expected Obj, but got Unknown
		//IL_0b6d: Expected Ref, but got F8
		//IL_0b7d: Expected Ref, but got F4
		//IL_0b85: Expected VT, but got Ref
		//IL_0b95: Expected F8, but got I
		//IL_0d6b: Invalid comparison between F4 and I4
		//IL_0d7c: Expected Obj, but got I4
		//IL_0d94: Expected Ref, but got F8
		//IL_0da4: Expected Ref, but got F4
		//IL_0dbc: Expected F8, but got I
		//IL_0bc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bca: Expected Obj, but got Unknown
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd8: Expected Obj, but got Unknown
		//IL_0e02: Expected VT, but got I4
		//IL_0ec5: Expected Obj, but got I4
		//IL_0edd: Invalid comparison between F4 and I4
		//IL_0ef4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef9: Expected Obj, but got Unknown
		//IL_0f19: Expected Ref, but got F4
		//IL_1072: Expected Obj, but got I4
		//IL_10b3: Expected Ref, but got F8
		//IL_10c3: Expected Ref, but got F4
		//IL_10e3: Expected F8, but got I
		//IL_0f6f: Expected native int or pointer, but got VT
		//IL_0f7c: Expected native int or pointer, but got VT
		//IL_0f89: Expected native int or pointer, but got VT
		//IL_0f96: Expected native int or pointer, but got VT
		//IL_0fbd: Expected Obj, but got I
		//IL_0fcf: Expected VT, but got Obj
		//IL_0fdf: Expected Obj, but got I
		//IL_0fff: Expected Ref, but got F4
		//IL_111c: Expected Obj, but got I4
		//IL_112b: Expected Obj, but got I4
		//IL_114b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1150: Expected Obj, but got Unknown
		//IL_116a: Expected Ref, but got F8
		//IL_117a: Expected Ref, but got F4
		//IL_1182: Expected VT, but got Ref
		//IL_1192: Expected F8, but got I
		//IL_11c8: Expected F4, but got I
		//IL_11d6: Expected Obj, but got I4
		//IL_11ed: Expected F4, but got Obj
		//IL_124a: Expected Ref, but got F8
		//IL_125a: Expected Ref, but got F4
		//IL_127a: Expected F8, but got I
		//IL_12ab: Expected Obj, but got I4
		//IL_12ba: Expected Obj, but got I4
		//IL_12da: Unknown result type (might be due to invalid IL or missing references)
		//IL_12df: Expected Obj, but got Unknown
		//IL_12f9: Expected Ref, but got F8
		//IL_1309: Expected Ref, but got F4
		//IL_1311: Expected VT, but got Ref
		//IL_1321: Expected F8, but got I
		//IL_1339: Expected F4, but got I
		//IL_1351: Expected F4, but got VT
		//IL_1361: Expected F4, but got I
		//IL_136f: Expected Obj, but got I4
		//IL_13dd: Expected Ref, but got F8
		//IL_13ed: Expected Ref, but got F4
		//IL_140d: Expected F8, but got I
		//IL_143c: Expected VT, but got Ref
		//IL_1506: Expected Obj, but got I4
		//IL_1515: Expected Obj, but got I4
		//IL_1535: Unknown result type (might be due to invalid IL or missing references)
		//IL_153a: Expected Obj, but got Unknown
		//IL_1552: Expected Ref, but got F8
		//IL_1562: Expected Ref, but got F4
		//IL_157a: Expected F8, but got I
		//IL_1452: Expected I, but got Obj
		//IL_1462: Expected VT, but got I
		//IL_1495: Expected Ref, but got F8
		//IL_14a5: Expected Ref, but got F4
		//IL_14b5: Expected VT, but got I
		//IL_14c5: Expected F8, but got I
		//IL_14dd: Expected F4, but got I
		//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a7: Expected Obj, but got Unknown
		//IL_15b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b5: Expected Obj, but got Unknown
		//IL_15d9: Expected Obj, but got I
		//IL_15f3: Expected Obj, but got I4
		//IL_1604: Expected Obj, but got I4
		//IL_160e: Expected VT, but got Obj
		//IL_165e: Expected Ref, but got F8
		//IL_166e: Expected Ref, but got F4
		//IL_1677: Expected Obj, but got I4
		//IL_1681: Expected VT, but got Obj
		//IL_1691: Expected F8, but got I
		//IL_16b1: Expected Obj, but got I
		((Vector3*)(nint)move)->x = 0f / 0f;
		float num = minimumRaycastDistance;
		float num2 = defaultPrecision;
		Vector3 vector = (Vector3)(from & 1);
		float num3 = default;
		float num4 = default;
		bool flag = IterativeCollisionSphereCast((Vector3)fromTurn, num3, vector, num4, out *(Vector3*)from, (byte)(int)fromTurn != 0);
		bool flag2 = held == null;
		bool result = flag;
		if (!flag2)
		{
			Vector3[] at = held.at;
			bool flag3 = held.at == null;
			object obj = 0;
			Vector3 vector2 = (Vector3)0;
			object obj2 = 0;
			object obj3 = 0;
			ref int reference = ref which;
			float num6 = default;
			float num5 = num6;
			ref Vector3 reference2 = ref end;
			double num7 = minimumRaycastDistance;
			double num9 = default;
			double num8 = num9;
			float num10 = num4;
			if (flag3)
			{
				goto IL_178f;
			}
			bool flag4 = at.Length == 0;
			result = flag;
			if (!flag4)
			{
				float num11 = num3 + (float)(ref end);
				float num12 = num4 + num6;
				double num13 = num9 + (double)(ref which);
				bool flag5 = !flag;
				float num14 = (float)num9;
				float num15 = -1f;
				float num16 = num11;
				if (!flag5)
				{
					float num17 = fromTurn.x - num11;
					float num18 = fromTurn.y - num12;
					num14 = fromTurn.z - (float)num13;
					float num19 = num17 * num17;
					float num20 = num18 * num18;
					float num21 = num19 + num20;
					num16 = num14 * num14;
					float num22 = num21 + num16;
					num = (float)num13;
					num15 = num22;
				}
				object obj4 = this + 260;
				double num23 = (double)(ref end) * 0.5;
				double num24 = (double)num6 * 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj5 = 0;
				double num25 = (double)(ref which) * 0.5;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X0_v12+E4]");
				bool flag6 = (nint)0 == 0;
				object obj7 = !flag6;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				float num26 = num4 + (float)num24;
				float radius = num3 + (float)num23;
				double num27 = num9 + num25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X0_v14+E4]");
				bool flag7 = (nint)0 == 0;
				object obj10 = !flag7;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj11 = default;
				double num28 = (double)obj11 * 0.5;
				double num29 = num28 + (double)held.reach;
				num7 = num29 + (double)minimumRaycastDistance;
				bool flag8 = Physics.CheckSphere((Vector3)locomotionEnabledLayers, radius, 0);
				bool flag9 = !flag8;
				result = flag;
				if (!flag9)
				{
					bool flag18;
					float num30;
					Collider collider;
					bool flag12;
					if (~(held.goesIn ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
						object obj12 = 0;
						object obj13 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v53+E4]");
						bool flag10 = (nint)0 == 0;
						object obj14 = !flag10;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj13 = obj12;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v53+A0]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X8_v60+8]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X8_v60+8]");
						bool flag11 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+178]");
						obj = 0;
						num30 = hitSlip;
						vector2 = hitPoint;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+10C]");
						obj2 = 0;
						obj3 = obj4;
						reference = ref which;
						num5 = num6;
						reference2 = ref end;
						collider = hitCollider;
						flag12 = flag;
						num8 = num27;
						num10 = num26;
						if (flag11)
						{
							goto IL_178f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v61+20]");
						bool flag13 = (nint)0 < (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v61+20]");
						bool flag14 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v61+20]");
						nint num31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v61+20]");
						object obj17 = num31 ^ 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v61+20]");
						object obj18 = 0 & obj17;
						bool flag15 = (nint)obj18 < 0;
						bool flag16 = flag13 == flag15;
						object obj19 = !flag14;
						bool flag17 = (byte)((flag16 & obj19) ? 1 : 0) != 0;
						flag18 = flag17;
					}
					else
					{
						flag18 = false;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj20 = 0;
					Vector3[] at2 = held.at;
					passing = flag18;
					metSoft = false;
					bool flag19 = held.at == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+178]");
					obj = 0;
					num30 = hitSlip;
					vector2 = hitPoint;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+10C]");
					obj2 = 0;
					obj3 = obj4;
					reference = ref which;
					num5 = num6;
					reference2 = ref end;
					collider = hitCollider;
					flag12 = flag;
					num8 = num27;
					num10 = num26;
					if (flag19)
					{
						goto IL_178f;
					}
					object obj21 = this + 368;
					object obj22 = this + 460;
					object obj23 = 109891584;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+178]");
					object obj24 = 0;
					float num32 = hitSlip;
					Vector3 vector3 = hitPoint;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+10C]");
					object obj25 = 0;
					object obj26 = obj4;
					Vector3 vector4 = vector;
					object obj27 = 0;
					float num33 = num2;
					ref int reference3 = ref which;
					float num34 = num6;
					ref Vector3 reference4 = ref end;
					float num35 = 0f;
					object obj28 = obj22;
					object obj29 = 40;
					Collider collider2 = hitCollider;
					bool flag20 = flag;
					Vector3 vector5 = (Vector3)0;
					double num36 = num7;
					double num37 = num27;
					float num39 = default;
					float num38 = num39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A884]");
					float num40 = 0f;
					int num41 = whose;
					HeldShape heldShape = held;
					Vector3 vector6 = from;
					Quaternion quaternion = fromTurn;
					Vector3 vector7 = move;
					double num42 = default;
					double num43 = default;
					float num44 = default;
					float num45 = default;
					double num46 = default;
					double num47 = default;
					IntPtr intPtr = default;
					IndexOutOfRangeException ex = default;
					object obj71 = default;
					while (true)
					{
						bool flag21 = !(num35 < (float)at2.Length);
						obj = obj24;
						num30 = num32;
						vector2 = vector3;
						obj2 = obj25;
						obj3 = obj26;
						vector = vector4;
						num2 = num33;
						reference = ref reference3;
						num5 = num34;
						reference2 = ref reference4;
						collider = collider2;
						flag12 = flag20;
						num7 = num36;
						num8 = num37;
						num10 = num38;
						if (flag21)
						{
							break;
						}
						bool flag22 = num35 < (float)at2.Length;
						object obj30 = !flag22;
						float num49;
						float num50;
						double num51;
						double num55;
						float num57;
						float num58;
						bool flag31;
						object obj64;
						object obj66;
						object obj67;
						Vector3 vector11;
						float num71;
						int num72;
						HeldShape heldShape2;
						Vector3 vector12;
						Quaternion quaternion2;
						Vector3 vector13;
						if (obj30 == null)
						{
							object obj31 = (object)at2 + obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v26-8]");
							reference2 = ref *(Vector3*)null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v26-4]");
							num5 = 0f;
							reference = ref *(int*)obj31;
							Vector3 vector8 = (Quaternion)0 * vector5;
							Vector3[] at3 = heldShape.at;
							bool flag23 = heldShape.at == null;
							obj = obj24;
							num30 = num32;
							vector2 = vector3;
							obj2 = obj25;
							obj3 = obj26;
							vector = vector4;
							num2 = num33;
							collider = collider2;
							flag12 = flag20;
							num7 = num42;
							num8 = num43;
							num10 = num44;
							if (flag23)
							{
								goto IL_178f;
							}
							bool flag24 = num35 < (float)at3.Length;
							object obj32 = !flag24;
							reference3 = ref *(int*)obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v26-4]");
							num34 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v26-8]");
							reference4 = ref *(Vector3*)null;
							num36 = num42;
							num37 = num43;
							num38 = num44;
							num40 = num45;
							if (obj32 == null)
							{
								object obj33 = (object)heldShape.at + obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v28-8]");
								reference2 = ref *(Vector3*)null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v28-4]");
								num5 = 0f;
								reference = ref *(int*)obj33;
								Vector3 vector9 = (Quaternion)0 * vector5;
								float[] radius2 = heldShape.radius;
								bool flag25 = heldShape.radius == null;
								obj = obj24;
								num30 = num32;
								vector2 = vector3;
								obj2 = obj25;
								obj3 = obj26;
								vector = vector4;
								num2 = num33;
								collider = collider2;
								flag12 = flag20;
								num7 = num46;
								num8 = num47;
								num10 = num39;
								if (flag25)
								{
									goto IL_178f;
								}
								bool flag26 = num35 < (float)radius2.Length;
								object obj34 = !flag26;
								reference3 = ref *(int*)obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v28-4]");
								num34 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v28-8]");
								reference4 = ref *(Vector3*)null;
								num36 = num46;
								num37 = num47;
								num38 = num39;
								num40 = (nint)intPtr;
								if (obj34 == null)
								{
									float num48 = (float)heldShape.radius + num35;
									object obj35 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v30+E4]");
									bool flag27 = (nint)0 == 0;
									object obj36 = !flag27;
									if (obj36 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
									object obj37 = 0;
									object obj38 = obj37;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X0_v32+E4]");
									bool flag28 = (nint)0 == 0;
									object obj39 = !flag28;
									if (obj39 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									num49 = num3 + num45;
									num50 = num4 + num44;
									num51 = num9 + num43;
									double num52 = num13 + num47;
									float num53 = num11 + (float)(nint)intPtr;
									float num54 = num12 + num39;
									num55 = num52 - num51;
									double num56 = num51 + num52;
									num57 = num53 - num49;
									num58 = num54 - num50;
									float num59 = num49 + num53;
									float num60 = num50 + num54;
									num8 = num56 * 0.5;
									float num61 = num57 * num57;
									float num62 = num58 * num58;
									num40 = num59 * 0.5f;
									num10 = num60 * 0.5f;
									float num63 = num61 + num62;
									double num64 = num55 * num55;
									double num65 = num64 + (double)num63;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									double num66 = num65 * 0.5;
									double num67 = num66;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
									double num68 = num67 + 0.0;
									double num69 = num68;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A884]");
									num7 = num69 + 0.0;
									bool flag29 = Physics.CheckSphere((Vector3)locomotionEnabledLayers, num40, 0);
									bool flag30 = !flag29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A884]");
									reference2 = ref *(Vector3*)null;
									vector5 = (Vector3)0;
									if (flag30)
									{
										goto IL_16bf;
									}
									num2 = defaultPrecision;
									vector = (Vector3)(vector6 & 1);
									flag31 = IterativeCollisionSphereCast((Vector3)(&obj27), num49, vector, num50, out *(Vector3*)from, (byte)(int)fromTurn != 0);
									if (~(metSoft ? 1u : 0u) != 0)
									{
										goto IL_0bf5;
									}
									bool[] array = intoNow;
									bool flag32 = intoNow == null;
									obj = obj24;
									num30 = num32;
									vector2 = vector3;
									obj2 = obj25;
									obj3 = obj26;
									reference = ref *(int*)num55;
									num5 = num58;
									reference2 = ref *(Vector3*)num57;
									collider = collider2;
									flag12 = flag20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
									num7 = 0.0;
									num8 = num51;
									num10 = num50;
									if (flag32)
									{
										goto IL_178f;
									}
									bool flag33 = array.Length < num41;
									object obj40 = !flag33;
									object obj41 = array.Length - num41;
									bool flag34 = obj41 == null;
									object obj42 = ~obj40;
									object obj43 = obj42 | flag34;
									vector4 = vector;
									num33 = defaultPrecision;
									reference3 = ref *(int*)num55;
									num34 = num58;
									reference4 = ref *(Vector3*)num57;
									vector5 = (Vector3)(&obj27);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
									num36 = 0.0;
									num37 = num51;
									num38 = num50;
									num40 = num49;
									if (obj43 == null)
									{
										object obj44 = intoNow + whose;
										object obj45 = obj44 + 32;
										if (obj45 != null)
										{
											goto IL_0bf5;
										}
										Vector3[] array2 = intoAt;
										obj45 = 1;
										bool flag35 = intoAt == null;
										obj = obj24;
										num30 = num32;
										vector2 = vector3;
										obj2 = obj25;
										obj3 = obj26;
										reference = ref *(int*)num55;
										num5 = num58;
										reference2 = ref *(Vector3*)num57;
										collider = collider2;
										flag12 = flag20;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
										num7 = 0.0;
										num8 = num51;
										num10 = num50;
										if (flag35)
										{
											goto IL_178f;
										}
										bool flag36 = array2.Length < num41;
										object obj46 = !flag36;
										object obj47 = array2.Length - num41;
										bool flag37 = obj47 == null;
										object obj48 = ~obj46;
										object obj49 = obj48 | flag37;
										vector4 = vector;
										num33 = defaultPrecision;
										reference3 = ref *(int*)num55;
										num34 = num58;
										reference4 = ref *(Vector3*)num57;
										vector5 = (Vector3)(&obj27);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
										num36 = 0.0;
										num37 = num51;
										num38 = num50;
										num40 = num49;
										if (obj49 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+1D4]");
											num10 = 0f;
											object obj50 = whose * 12;
											object obj51 = (object)intoAt + obj50;
											num40 = (float)obj22;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+1D4]");
											_ = 0;
											Vector3[] array3 = intoFaces;
											bool flag38 = intoFaces == null;
											obj = obj24;
											num30 = num32;
											vector2 = vector3;
											obj2 = obj25;
											obj3 = obj26;
											reference = ref *(int*)num55;
											num5 = num58;
											reference2 = ref *(Vector3*)num57;
											collider = collider2;
											flag12 = flag20;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
											num7 = 0.0;
											num8 = num51;
											if (flag38)
											{
												goto IL_178f;
											}
											bool flag39 = array3.Length < num41;
											object obj52 = !flag39;
											object obj53 = array3.Length - num41;
											bool flag40 = obj53 == null;
											object obj54 = ~obj52;
											object obj55 = obj54 | flag40;
											vector4 = vector;
											num33 = defaultPrecision;
											reference3 = ref *(int*)num55;
											num34 = num58;
											reference4 = ref *(Vector3*)num57;
											vector5 = (Vector3)(&obj27);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
											num36 = 0.0;
											num37 = num51;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+1D4]");
											num38 = 0f;
											if (obj55 == null)
											{
												num40 = (float)softNormal;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+1E0]");
												num10 = 0f;
												object obj56 = whose * 12;
												object obj57 = (object)intoFaces + obj56;
												_ = softNormal;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+1E0]");
												_ = 0;
												Collider[] array4 = intoOn;
												bool flag41 = intoOn == null;
												obj = obj24;
												num30 = num32;
												vector2 = vector3;
												obj2 = obj25;
												obj3 = obj26;
												reference = ref *(int*)num55;
												num5 = num58;
												reference2 = ref *(Vector3*)num57;
												collider = collider2;
												flag12 = flag20;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
												num7 = 0.0;
												num8 = num51;
												if (flag41)
												{
													goto IL_178f;
												}
												bool flag42 = (object)softCollider == null;
												Vector3 vector10 = (Vector3)(&obj27);
												if (!flag42)
												{
													nint num70 = (nint)array4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X8_v57 (Il2CppClass<UnityEngine.Collider[]>)+40]");
													vector10 = (Vector3)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag43 = ex == null;
													vector4 = vector;
													num33 = defaultPrecision;
													reference3 = ref *(int*)num55;
													num34 = num58;
													reference4 = ref *(Vector3*)num57;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X8_v57 (Il2CppClass<UnityEngine.Collider[]>)+40]");
													vector5 = (Vector3)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
													num36 = 0.0;
													num37 = num51;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+1E0]");
													num38 = 0f;
													if (flag43)
													{
														goto IL_1803;
													}
												}
												bool flag44 = array4.Length < num41;
												object obj58 = !flag44;
												object obj59 = array4.Length - num41;
												bool flag45 = obj59 == null;
												object obj60 = ~obj58;
												object obj61 = obj60 | flag45;
												vector4 = vector;
												num33 = num2;
												reference3 = ref *(int*)num55;
												num34 = num58;
												reference4 = ref *(Vector3*)num57;
												vector5 = vector10;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
												num36 = 0.0;
												num37 = num51;
												num38 = num10;
												if (obj61 == null)
												{
													object obj62 = intoOn + whose;
													object obj63 = obj62 + 32;
													obj63 = softCollider;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
													obj64 = 0;
													bool flag46 = !flag31;
													object obj65 = !flag46;
													obj66 = obj23;
													obj67 = 12;
													vector11 = (Vector3)softCollider;
													num38 = num10;
													num71 = num40;
													num72 = num41;
													heldShape2 = held;
													vector12 = vector6;
													quaternion2 = quaternion;
													vector13 = vector7;
													vector4 = vector;
													num33 = num2;
													reference = ref *(int*)num55;
													num5 = num58;
													reference2 = ref *(Vector3*)num57;
													obj28 = 12;
													vector5 = (Vector3)softCollider;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
													num7 = 0.0;
													num8 = num51;
													heldShape = held;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
													obj20 = 0;
													if (obj65 != null)
													{
														goto IL_0cc2;
													}
													goto IL_16bf;
												}
											}
										}
									}
								}
							}
						}
						goto IL_17f5;
						IL_17f5:
						ex = new IndexOutOfRangeException();
						goto IL_1803;
						IL_1803:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
						ArgumentNullException ex2 = new ArgumentNullException();
						return (byte)(int)ex2 != 0;
						IL_16bf:
						at2 = heldShape.at;
						num35++;
						obj29 += 12;
						bool flag47 = heldShape.at == null;
						object obj68 = !flag47;
						obj = obj24;
						num30 = num32;
						vector2 = vector3;
						obj2 = obj25;
						obj3 = obj26;
						vector = vector4;
						num2 = num33;
						collider = collider2;
						flag12 = flag20;
						reference3 = ref reference;
						num34 = num5;
						reference4 = ref reference2;
						num36 = num7;
						num37 = num8;
						num38 = num10;
						if (obj68 != null)
						{
							continue;
						}
						goto IL_178f;
						IL_0cc2:
						Vector3[] at4 = heldShape2.at;
						bool flag48 = heldShape2.at == null;
						obj = obj24;
						num30 = num32;
						vector2 = vector3;
						obj2 = obj25;
						obj3 = obj26;
						reference = ref *(int*)num55;
						num5 = num58;
						reference2 = ref *(Vector3*)num57;
						collider = collider2;
						flag12 = flag20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
						num7 = 0.0;
						num8 = num51;
						num10 = num38;
						if (flag48)
						{
							goto IL_178f;
						}
						bool flag49 = num35 < (float)at4.Length;
						object obj69 = !flag49;
						vector4 = vector;
						num33 = num2;
						reference3 = ref *(int*)num55;
						num34 = num58;
						reference4 = ref *(Vector3*)num57;
						vector5 = vector11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
						num36 = 0.0;
						num37 = num51;
						num40 = num71;
						if (obj69 == null)
						{
							object obj70 = (object)heldShape2.at + obj29;
							reference = ref *(int*)obj70;
							Vector3 vector14 = (Quaternion)0 * vector11;
							num7 = (double)obj27 - (double)(nint)intPtr;
							num10 = (float)obj71 - num39;
							num8 = 0.0 - num47;
							double num73 = num7 - (double)num11;
							float num74 = num10 - num12;
							num5 = (float)num8 - (float)num13;
							double num75 = num73 * num73;
							float num76 = num74 * num74;
							double num77 = num75 + (double)num76;
							float num78 = num5 * num5;
							num40 = num78 + (float)num77;
							bool flag50 = num40 < num15;
							object obj72 = !flag50;
							float num79 = num40 - num15;
							bool flag51 = num79 == 0f;
							object obj73 = ~obj72;
							object obj74 = obj73 | flag51;
							obj23 = obj66;
							vector4 = vector;
							num33 = num2;
							reference2 = ref *(Vector3*)num15;
							obj28 = obj67;
							vector5 = vector11;
							num41 = num72;
							heldShape = heldShape2;
							vector6 = vector12;
							quaternion = quaternion2;
							vector7 = vector13;
							obj20 = obj64;
							if (obj74 == null)
							{
								((Quaternion*)(nint)quaternion2)->x = (float)num7;
								((Quaternion*)(nint)quaternion2)->y = num10;
								((Quaternion*)(nint)quaternion2)->z = (float)num8;
								((Vector3*)(nint)vector13)->x = num35;
								num10 = hitSlip;
								obj23 = obj66;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X11_v6+8]");
								obj24 = 0;
								num32 = hitSlip;
								vector3 = (Vector3)obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X10_v5+8]");
								obj25 = 0;
								obj26 = obj4;
								vector4 = vector;
								num33 = num2;
								reference2 = ref *(Vector3*)num15;
								obj28 = obj21;
								collider2 = hitCollider;
								flag20 = true;
								vector5 = vector11;
								num15 = num40;
								num41 = num72;
								heldShape = heldShape2;
								vector6 = vector12;
								quaternion = quaternion2;
								vector7 = vector13;
								obj20 = obj64;
							}
							goto IL_16bf;
						}
						goto IL_17f5;
						IL_0bf5:
						bool flag52 = !flag31;
						obj66 = obj23;
						obj67 = obj28;
						vector11 = (Vector3)(&obj27);
						num38 = num50;
						num71 = num49;
						num72 = num41;
						heldShape2 = heldShape;
						vector12 = vector6;
						quaternion2 = quaternion;
						vector13 = vector7;
						obj64 = obj20;
						vector4 = vector;
						num33 = num2;
						reference = ref *(int*)num55;
						num5 = num58;
						reference2 = ref *(Vector3*)num57;
						vector5 = (Vector3)(&obj27);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v30 (System.Single)+20]");
						num7 = 0.0;
						num8 = num51;
						num10 = num50;
						num40 = num49;
						if (!flag52)
						{
							goto IL_0cc2;
						}
						goto IL_16bf;
					}
					object obj75 = this + 432;
					object obj76 = obj3;
					passing = false;
					hitSlip = num30;
					object obj77 = vector2;
					hitCollider = collider;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					result = flag12;
				}
			}
		}
		return result;
		IL_178f:
		throw new NullReferenceException();
	}

	private static Vector3 StillOn(HeldShape held, int which, Vector3 last, Quaternion lastTurn, Vector3 now, Quaternion turn)
	{
		//IL_0164: Expected VT, but got Obj
		//IL_002f: Expected I4, but got I8
		//IL_0049: Expected Obj, but got I4
		//IL_0185: Expected VT, but got Obj
		//IL_00b5: Expected VT, but got I4
		//IL_00b5: Expected VT, but got I4
		//IL_0103: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0153: Expected VT, but got I4
		//IL_0153: Expected VT, but got I4
		if (held != null)
		{
			int num = (int)(which & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				Vector3[] at = held.at;
				if (held.at != null)
				{
					if (at.Length <= which)
					{
						goto IL_015c;
					}
					Vector3 vector = (Quaternion)0 * (Vector3)which;
					Vector3[] at2 = held.at;
					if (held.at != null)
					{
						bool flag2 = at2.Length < which;
						object obj2 = !flag2;
						object obj3 = at2.Length - which;
						bool flag3 = obj3 == null;
						object obj4 = ~obj2;
						object obj5 = obj4 | flag3;
						if (obj5 == null)
						{
							return (Quaternion)0 * (Vector3)which;
						}
						goto IL_0177;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_0177;
			}
		}
		goto IL_015c;
		IL_0177:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (Vector3)ex2;
		IL_015c:
		return (Vector3)held;
	}

	public unsafe bool HeldInto(bool right, out Vector3 at, out Vector3 faces, out Collider on)
	{
		//IL_021d: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		Vector3[] array = intoAt;
		if (intoAt == null)
		{
			goto IL_0201;
		}
		bool flag = (right ? 1 : 0) < array.Length;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = (right ? 1 : 0) * 12;
			object obj3 = (object)intoAt + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+20]");
			ref Vector3 reference = ref *(Vector3*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+28]");
			_ = 0;
			Vector3[] array2 = intoFaces;
			if (intoFaces == null)
			{
				goto IL_0201;
			}
			bool flag2 = (right ? 1 : 0) < array2.Length;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				object obj5 = (right ? 1 : 0) * 12;
				object obj6 = (object)intoFaces + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v6+20]");
				ref Vector3 reference2 = ref *(Vector3*)null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v6+28]");
				_ = 0;
				Collider[] array3 = intoOn;
				if (intoOn == null)
				{
					goto IL_0201;
				}
				bool flag3 = (right ? 1 : 0) < array3.Length;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					object obj8 = intoOn + right;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v8+20]");
					ref Collider reference3 = ref *(Collider*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool[] array4 = into;
					if (into == null)
					{
						goto IL_0201;
					}
					bool flag4 = (right ? 1 : 0) < array4.Length;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						object obj10 = into + right;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v10+20]");
						return false;
					}
				}
			}
		}
		goto IL_020f;
		IL_0201:
		NullReferenceException ex = new NullReferenceException();
		goto IL_020f;
		IL_020f:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public unsafe bool HeldTouching(bool right, out Vector3 at, out Vector3 faces, out Collider on)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0086: Expected VT, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_012c: Expected Ref, but got VT
		//IL_0137: Expected Obj, but got I4
		//IL_0034: Expected Ref, but got VT
		//IL_004e: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		Vector3 vector;
		if (right)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+190]");
			_ = 0;
			ref Vector3 reference = ref *(Vector3*)rightHeldAt;
			vector = rightHeldFaces;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+1A8]");
			object obj = 0;
		}
		else
		{
			object obj2 = this + 380;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+184]");
			_ = 0;
			object obj3 = this + 404;
			ref Vector3 reference = ref *(Vector3*)obj2;
			vector = (Vector3)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+19C]");
			object obj = 0;
		}
		bool flag = !right;
		ref Vector3 reference2 = ref *(Vector3*)vector;
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			object obj6 = 448;
		}
		else
		{
			object obj6 = 440;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+v41 @ X8_v2]");
		ref Collider reference3 = ref *(Collider*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num;
		if (right)
		{
			if (~(wasRightHandTouching ? 1u : 0u) != 0)
			{
				goto IL_0107;
			}
			num = rightWhich;
		}
		else
		{
			if (~(wasLeftHandTouching ? 1u : 0u) != 0)
			{
				goto IL_0107;
			}
			num = leftWhich;
		}
		int num2 = ~num;
		return (byte)(num2 >> 31) != 0;
		IL_0107:
		return false;
	}

	private unsafe bool IterativeCollisionSphereCast(Vector3 startPosition, float sphereRadius, Vector3 movementVector, float precision, out Vector3 endPosition, bool singleHand)
	{
		//IL_0720: Expected VT, but got Ref
		//IL_08d7: Expected Obj, but got I
		//IL_0901: Expected Obj, but got I4
		//IL_06f5: Expected I4, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_0148: Invalid comparison between F4 and I
		//IL_003f: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_01b1: Expected F4, but got Obj
		//IL_01c1: Expected F4, but got I
		//IL_01d1: Expected F4, but got I
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_0939: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_027e: Expected VT, but got Ref
		//IL_076b: Expected Obj, but got I4
		//IL_046e: Expected Obj, but got I
		//IL_04bd: Expected F4, but got I4
		//IL_00f8: Expected Obj, but got I
		//IL_07b5: Expected Obj, but got I
		//IL_07c2: Expected F4, but got Obj
		//IL_07bd: Expected native int or pointer, but got VT
		//IL_07d7: Expected F4, but got I
		//IL_07d2: Expected native int or pointer, but got VT
		//IL_02a7: Expected native int or pointer, but got VT
		//IL_02b4: Expected native int or pointer, but got VT
		//IL_02c1: Expected native int or pointer, but got VT
		//IL_0300: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I4
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected Obj, but got Unknown
		//IL_0387: Expected F4, but got I4
		//IL_04f8: Expected F4, but got I
		//IL_081b: Expected Obj, but got I4
		//IL_082b: Expected Obj, but got I
		//IL_0871: Expected Obj, but got I
		//IL_098d: Expected VT, but got Ref
		//IL_09ab: Expected Obj, but got I4
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_03c2: Expected F4, but got I
		//IL_0674: Expected VT, but got Ref
		//IL_06b0: Expected native int or pointer, but got VT
		//IL_06c2: Expected native int or pointer, but got VT
		//IL_06d4: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 * obj3;
		RaycastHit raycastHit = default;
		object obj14 = default;
		object obj16 = default;
		object obj17 = default;
		float num5 = default;
		object obj18 = default;
		if (CollisionsSphereCast(startPosition, sphereRadius, (Vector3)(&raycastHit), precision, out endPosition, out *(singleHand ? ((RaycastHit*)1) : ((RaycastHit*)null))))
		{
			Collider collider = raycastHit.collider;
			if ((object)collider != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCB0]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object obj8 = default;
				object obj9;
				if (obj8 != null)
				{
					if ((object)obj8 == null)
					{
						goto IL_06e7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v48 (UnityEngine.Object)+20]");
					obj9 = 0;
				}
				else
				{
					object obj10 = movementVector & 1;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
						obj9 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD09C]");
						obj9 = 0;
					}
				}
				object obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v52+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = obj8 != null;
				bool flag4 = !flag3;
				float num = 0f;
				if (!flag4)
				{
					if ((object)obj8 == null)
					{
						goto IL_06e7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v48 (UnityEngine.Object)+20]");
					num = 0f;
				}
				if ((object)this != null)
				{
					hitSlip = num;
					object obj13 = this + 260;
					obj13 = obj14;
					hitPoint = (Vector3)raycastHit;
					Collider collider2 = raycastHit.collider;
					hitCollider = collider2;
					object obj15 = this + 432;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					float num2 = sphereRadius + (float)obj16;
					float num3 = precision + (float)obj17;
					float num4 = num5 + (float)obj18;
					object obj19 = obj14 * obj14;
					object obj20 = 0 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
					object obj21 = 0;
					object obj22 = obj21;
					float num6 = num4 - startPosition.z;
					object obj23 = obj19 + obj20;
					object obj25 = default;
					object obj24 = obj25 * obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v44+A0]");
					object obj26 = 0;
					object obj27 = obj24 + obj23;
					float num7 = num2 - startPosition.x;
					float num8 = num3 - startPosition.y;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26))
					{
						float num9 = num7 * (float)obj14;
						float num10 = num8 * 0f;
						float num11 = num6 * (float)obj25;
						float num12 = num9 + num10;
						float num13 = num11 + num12;
						float num14 = num13 / (float)obj27;
						float num15 = (float)obj14 * num14;
						float num16 = 0f * num14;
						num7 -= num15;
						num8 -= num16;
					}
					float num17 = (float)obj9 * num7;
					float num18 = (float)obj9 * num8;
					bool flag5 = CollisionsSphereCast(startPosition, startPosition.x, (Vector3)(&raycastHit), startPosition.y, out endPosition, out *(singleHand ? ((RaycastHit*)1) : ((RaycastHit*)null)));
					bool flag6 = !flag5;
					object obj28 = !flag6;
					if (obj28 == null)
					{
						float sphereRadius2 = startPosition.x + num17;
						float precision2 = startPosition.y + num18;
						if (!CollisionsSphereCast(startPosition, sphereRadius2, (Vector3)(&raycastHit), precision2, out endPosition, out *(singleHand ? ((RaycastHit*)1) : ((RaycastHit*)null))))
						{
							((Vector3*)(nint)startPosition)->x = startPosition.x;
							((Vector3*)(nint)startPosition)->y = startPosition.y;
							((Vector3*)(nint)startPosition)->z = startPosition.z;
							return true;
						}
					}
					goto IL_0695;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj29 = 0;
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v11+E4]");
			bool flag7 = (nint)0 == 0;
			object obj31 = !flag7;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj32 = 0;
			object obj33 = obj18 * obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num19;
			float num20;
			float num21;
			if (num5 > 0f)
			{
				num19 = (float)obj16 / num5;
				num20 = (float)obj17 / num5;
				num21 = (float)obj18 / num5;
			}
			else
			{
				object obj34 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v30+A0]");
				object obj35 = 0;
				num19 = (float)obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v31+4]");
				num20 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v31+8]");
				num21 = 0f;
			}
			object obj36 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v14+E4]");
			bool flag8 = (nint)0 == 0;
			object obj37 = !flag8;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E8]");
			object obj38 = obj * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAE0]");
			object obj39 = obj3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAE0]");
			object obj40 = obj * 0;
			float num22 = (float)obj38 + num5;
			float num23 = num22 * num19;
			float num24 = num22 * num20;
			float num25 = num22 * num21;
			if (!CollisionsSphereCast(startPosition, sphereRadius, (Vector3)(&raycastHit), precision, out endPosition, out *(singleHand ? ((RaycastHit*)1) : ((RaycastHit*)null))))
			{
				object obj41 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v20+A0]");
				object obj42 = 0;
				((Vector3*)(nint)startPosition)->x = (float)obj42;
				Vector3 vector = startPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v21+8]");
				((Vector3*)(nint)vector)->z = 0f;
				return false;
			}
			((Vector3*)(nint)startPosition)->x = sphereRadius;
			((Vector3*)(nint)startPosition)->y = precision;
			((Vector3*)(nint)startPosition)->z = num5;
			Collider collider3 = raycastHit.collider;
			if ((object)collider3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCB0]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj44 = 0;
				object obj45 = obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v27+E4]");
				bool flag9 = (nint)0 == 0;
				object obj46 = !flag9;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object obj47 = default;
				bool flag10 = obj47 != null;
				bool flag11 = !flag10;
				float num26 = 0f;
				if (!flag11)
				{
					if ((object)obj47 == null)
					{
						goto IL_06e7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v25 (UnityEngine.Object)+20]");
					num26 = 0f;
				}
				if ((object)this != null)
				{
					hitSlip = num26;
					object obj48 = this + 260;
					obj48 = obj14;
					hitPoint = (Vector3)raycastHit;
					Collider collider4 = raycastHit.collider;
					hitCollider = collider4;
					object obj49 = this + 432;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					goto IL_0695;
				}
			}
		}
		goto IL_06e7;
		IL_06e7:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0695:
		return true;
	}

	private unsafe bool CollisionsSphereCast(Vector3 startPosition, float sphereRadius, Vector3 movementVector, float precision, out Vector3 finalPosition, out RaycastHit hitInfo)
	{
		//IL_027b: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I4
		//IL_03d9: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0086: Expected native int or pointer, but got VT
		//IL_0093: Expected native int or pointer, but got VT
		//IL_0153: Expected VT, but got I
		//IL_0313: Expected Obj, but got I4
		//IL_05f1: Expected VT, but got Ref
		//IL_044a: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I
		//IL_046f: Expected F4, but got Obj
		//IL_046a: Expected native int or pointer, but got VT
		//IL_0484: Expected F4, but got I
		//IL_047f: Expected native int or pointer, but got VT
		//IL_017c: Expected native int or pointer, but got VT
		//IL_0189: Expected native int or pointer, but got VT
		//IL_0196: Expected native int or pointer, but got VT
		//IL_0416: Expected Obj, but got I4
		//IL_069e: Expected VT, but got I
		//IL_069e: Expected VT, but got Ref
		//IL_0664: Expected Obj, but got I4
		//IL_01cd: Expected native int or pointer, but got VT
		//IL_01da: Expected native int or pointer, but got VT
		//IL_01e7: Expected native int or pointer, but got VT
		//IL_01fa: Expected native int or pointer, but got VT
		//IL_0361: Invalid comparison between F4 and I
		//IL_0228: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I
		//IL_0248: Expected F4, but got Obj
		//IL_0258: Expected F4, but got I
		//IL_0398: Invalid comparison between F8 and I4
		//IL_04d6: Expected native int or pointer, but got VT
		//IL_04e3: Expected native int or pointer, but got VT
		//IL_0266: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		float num = default;
		float distance = num;
		float num2 = default;
		float radius = num2;
		object obj5 = default;
		object obj4 = obj5;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			distance = num;
			radius = num2;
			obj4 = obj5;
		}
		object obj7 = default;
		object obj6 = obj4 * obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double num3 = 1.0 - (double)obj7;
		double num4 = num3 * (double)obj4;
		object obj8 = default;
		double num5 = num4 + (double)obj8;
		float num8 = default;
		if (SphereCast(movementVector, radius, (Vector3)locomotionEnabledLayers, out System.Runtime.CompilerServices.Unsafe.As<Vector3, RaycastHit>(ref finalPosition), distance, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hitInfo)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [movementVector @ X2 (UnityEngine.Vector3)+C]");
			object obj10 = default;
			object obj9 = 0 * obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [movementVector @ X2 (UnityEngine.Vector3)+14]");
			object obj11 = 0 * obj5;
			float x = movementVector.x + (float)obj9;
			float num6 = movementVector.z + (float)obj11;
			((Vector3*)(nint)startPosition)->x = x;
			((Vector3*)(nint)startPosition)->z = num6;
			object obj12 = obj5;
			float num7 = num6 - num8;
			object obj13 = obj;
			object obj14 = default;
			float num9 = (float)obj14 - num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj5;
			}
			object obj16 = obj7 * obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			double num10 = 1.0 - (double)obj16;
			double num11 = num10 * (double)obj12;
			object obj17 = default;
			double num12 = num11 + (double)obj17;
			float x2 = default;
			bool flag3 = SphereCast((Vector3)(&x2), num2, (Vector3)locomotionEnabledLayers, out System.Runtime.CompilerServices.Unsafe.As<Vector3, RaycastHit>(ref finalPosition), num, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hitInfo));
			float num13 = startPosition.z - num8;
			float num14 = startPosition.x - num2;
			if (flag3)
			{
				float num15 = num2;
				float num16 = num14;
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v41+E4]");
				bool flag4 = (nint)0 == 0;
				object obj19 = !flag4;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num15 = num2;
					num16 = num14;
				}
				float num17 = num13 * num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num18;
				float num20;
				if (num17 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num18 = num13 / num17;
					float num19 = num16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					num20 = num19 / 0f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj20 = 0;
					object obj21 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v35+A0]");
					object obj22 = 0;
					num20 = (float)obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v36+8]");
					num18 = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD01C]");
				double num21 = 0.0 - num11;
				if (num21 < 0.0)
				{
					num21 = 0.0;
				}
				object obj23 = default;
				float num22 = num20 * (float)obj23;
				double num23 = (double)num18 * num21;
				float x3 = num15 + num22;
				double num24 = (double)num8 + num23;
				((Vector3*)(nint)startPosition)->x = x3;
				((Vector3*)(nint)startPosition)->z = (float)num24;
				_ = 0;
				_ = 0;
			}
			else
			{
				object obj24 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v30+E4]");
				bool flag5 = (nint)0 == 0;
				object obj25 = !flag5;
				float distance2 = num2;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					distance2 = num2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD0F4]");
				if (Raycast((Vector3)(&x2), (Vector3)0, out System.Runtime.CompilerServices.Unsafe.As<Vector3, RaycastHit>(ref finalPosition), distance2, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hitInfo)))
				{
					((Vector3*)(nint)startPosition)->z = num8;
					((Vector3*)(nint)startPosition)->x = num2;
					((Vector3*)(nint)startPosition)->y = num;
					_ = 0;
					((Vector3*)(nint)movementVector)->x = x2;
					_ = 0;
					return true;
				}
			}
			return true;
		}
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj27 = !flag6;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 vector = movementVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD0F4]");
		if (Raycast(vector, (Vector3)0, out System.Runtime.CompilerServices.Unsafe.As<Vector3, RaycastHit>(ref finalPosition), num2, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hitInfo)))
		{
			((Vector3*)(nint)startPosition)->z = num8;
			((Vector3*)(nint)startPosition)->x = num2;
			((Vector3*)(nint)startPosition)->y = num;
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj28 = 0;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v13+A0]");
		object obj30 = 0;
		((Vector3*)(nint)startPosition)->x = (float)obj30;
		Vector3 vector2 = startPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v14+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		return false;
	}

	private unsafe Vector3 Touch(Vector3 move, out float slip, out Vector3 normal)
	{
		//IL_000b: Invalid comparison between F4 and I4
		//IL_001a: Expected F8, but got I4
		//IL_00dc: Expected native int or pointer, but got VT
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_010f: Invalid comparison between F4 and I4
		//IL_0120: Expected Obj, but got I4
		//IL_012e: Invalid comparison between F4 and I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_00d4: Expected VT, but got Obj
		//IL_00b2: Expected VT, but got I4
		//IL_00bc: Expected VT, but got Obj
		//IL_016f: Expected Obj, but got F4
		//IL_018c: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I
		//IL_0245: Expected VT, but got I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_020c: Expected VT, but got Obj
		//IL_02ca: Expected Obj, but got F4
		//IL_02e7: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I
		//IL_0329: Expected Obj, but got I
		bool flag = hitSlip < 0f;
		double num = 0.0;
		if (!flag)
		{
			bool flag2 = !((double)hitSlip > 1.0);
			num = hitSlip;
			if (!flag2)
			{
				num = 1.0;
			}
		}
		((Vector3*)(nint)move)->x = (float)num;
		object obj = this + 260;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+10C]");
		_ = 0;
		ref float reference = ref *(float*)obj;
		bool flag3 = move.x < 0f;
		object obj2 = !flag3;
		bool flag4 = move.x == 0f;
		object obj3 = ~obj2;
		object obj4 = obj3 | flag4;
		object obj7;
		Vector3 result = default;
		if (obj4 == null)
		{
			if ((object)playerRigidBody != null)
			{
				Vector3 linearVelocity = playerRigidBody.linearVelocity;
				object obj5 = slip * slip;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [slip @ X2 (System.Single&)+4]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [slip @ X2 (System.Single&)+4]");
				object obj6 = num2 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
				obj7 = 0;
				object obj8 = obj7;
				object obj9 = obj5 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [slip @ X2 (System.Single&)+8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [slip @ X2 (System.Single&)+8]");
				object obj10 = num3 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v14+A0]");
				object obj11 = 0;
				object obj12 = obj10 + obj9;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
				{
					playerRigidBody.linearVelocity = (Vector3)0;
					object obj14 = default;
					object obj13 = obj14 * slip;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [slip @ X2 (System.Single&)+4]");
					object obj16 = default;
					object obj15 = obj16 * 0;
					object obj17 = obj13 + obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [slip @ X2 (System.Single&)+8]");
					object obj19 = default;
					object obj18 = obj19 * 0;
					object obj20 = obj18 + obj17;
					if ((nint)obj20 <= 0)
					{
						goto IL_02b3;
					}
				}
				result = (Vector3)playerRigidBody;
				goto IL_02b3;
			}
		}
		else if ((object)playerRigidBody != null)
		{
			playerRigidBody.linearVelocity = (Vector3)0;
			result = (Vector3)playerRigidBody;
			goto IL_00c1;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
		IL_02b3:
		object obj21 = slip * slip;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [slip @ X2 (System.Single&)+4]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [slip @ X2 (System.Single&)+4]");
		object obj22 = num4 * 0;
		object obj23 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v18+A0]");
		object obj24 = 0;
		object obj25 = obj21 + obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [slip @ X2 (System.Single&)+8]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [slip @ X2 (System.Single&)+8]");
		object obj26 = num5 * 0;
		object obj27 = obj26 + obj25;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24))
		{
			/*Error: End of method reached without returning.*/;
		}
		goto IL_00c1;
		IL_00c1:
		return result;
	}

	private void PushOff(Vector3 normal)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_005d: Invalid comparison between Obj and F4
		//IL_006e: Expected Obj, but got I4
		//IL_0088: Invalid comparison between F4 and I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_018e: Expected VT, but got I4
		object obj2 = default;
		object obj = obj2 * denormalizedVelocityAverage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+C4]");
		object obj4 = default;
		object obj3 = obj4 * 0;
		object obj5 = obj + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+C8]");
		object obj7 = default;
		object obj6 = obj7 * 0;
		object obj8 = obj6 + obj5;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)velocityLimit);
		object obj9 = !flag;
		float num = (float)obj8 - velocityLimit;
		bool flag2 = num == 0f;
		object obj10 = ~obj9;
		object obj11 = obj10 | flag2;
		if (obj11 != null)
		{
			return;
		}
		Vector3 linearVelocity = playerRigidBody.linearVelocity;
		object obj12 = obj2 * obj2;
		object obj13 = obj4 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj14 = 0;
		object obj15 = obj14;
		object obj16 = obj12 + obj13;
		object obj17 = obj7 * obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v6+A0]");
		object obj18 = 0;
		object obj19 = obj17 + obj16;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18))
		{
			float num2 = (float)obj8 * jumpMultiplier;
			if (!(num2 < maxJumpSpeed))
			{
			}
		}
		playerRigidBody.linearVelocity = (Vector3)0;
	}

	private unsafe bool SphereCast(Vector3 from, float radius, Vector3 direction, out RaycastHit hit, float distance, int mask)
	{
		//IL_012f: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I4
		//IL_0095: Expected VT, but got I
		//IL_00a7: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		if (~(passing ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v8+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v1+10]");
			int n = Physics.SphereCastNonAlloc((Vector3)0, radius, direction, null, distance, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hit));
			return Nearest(n, out *(RaycastHit*)from);
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Physics.SphereCast(from, radius, direction, out *(RaycastHit*)null, distance, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hit));
	}

	private unsafe bool Raycast(Vector3 from, Vector3 direction, out RaycastHit hit, float distance, int mask)
	{
		//IL_0127: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_0091: Expected VT, but got I
		//IL_00a3: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		if (~(passing ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v8+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v1+10]");
			int n = Physics.RaycastNonAlloc((Vector3)0, direction, null, distance, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hit));
			return Nearest(n, out *(RaycastHit*)from);
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Physics.Raycast(from, direction, out *(RaycastHit*)null, distance, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hit));
	}

	private unsafe bool Nearest(int n, out RaycastHit hit)
	{
		//IL_071b: Expected VT, but got I4
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0910: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0056: Expected VT, but got I4
		//IL_005f: Expected VT, but got I4
		//IL_0070: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got I8
		//IL_0086: Expected Obj, but got I4
		//IL_008f: Expected VT, but got I4
		//IL_0098: Expected VT, but got I4
		//IL_07dd: Expected Obj, but got I4
		//IL_077e: Expected Obj, but got I
		//IL_078e: Expected Obj, but got I
		//IL_073c: Expected I4, but got Obj
		//IL_00d5: Expected Obj, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0100: Expected VT, but got Obj
		//IL_0137: Expected Obj, but got I4
		//IL_018e: Expected VT, but got I
		//IL_019e: Expected VT, but got I
		//IL_01fe: Invalid comparison between VT and I4
		//IL_020f: Expected Obj, but got I4
		//IL_0218: Invalid comparison between VT and I4
		//IL_0229: Expected Obj, but got I4
		//IL_025e: Expected VT, but got I
		//IL_029b: Expected Obj, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_08d0: Expected Obj, but got I
		//IL_0803: Expected Obj, but got I
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected Obj, but got Unknown
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Expected Obj, but got Unknown
		//IL_083f: Expected VT, but got Obj
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected VT, but got Unknown
		//IL_0866: Invalid comparison between VT and I
		//IL_02dd: Expected Obj, but got I
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_045c: Expected Obj, but got I4
		//IL_03bb: Expected I4, but got Obj
		//IL_0337: Expected I4, but got Obj
		//IL_03d1: Expected Ref, but got VT
		//IL_040b: Expected VT, but got I
		//IL_0423: Expected I4, but got Obj
		//IL_036d: Expected I4, but got Obj
		//IL_049f: Expected Obj, but got I4
		//IL_04e2: Expected Obj, but got I4
		//IL_0934: Expected Obj, but got I
		//IL_0944: Expected Obj, but got I
		//IL_0528: Expected Obj, but got I4
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected Obj, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_0574: Expected Obj, but got I
		//IL_0591: Expected Obj, but got I
		//IL_05a1: Expected Obj, but got I
		//IL_05e7: Expected Obj, but got I4
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected Obj, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected Obj, but got Unknown
		//IL_062a: Expected VT, but got I
		//IL_0647: Expected Obj, but got I
		//IL_0657: Expected Obj, but got I
		//IL_069d: Expected Obj, but got I4
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected Obj, but got Unknown
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected Obj, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected VT, but got Unknown
		//IL_06e5: Expected Ref, but got VT
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected Obj, but got Unknown
		ref RaycastHit reference = ref *(RaycastHit*)null;
		_ = 0;
		_ = 0;
		RaycastHit raycastHit4;
		if (n >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCB8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj4 = 0;
			ref RaycastHit reference2 = ref hit;
			RaycastHit raycastHit = (RaycastHit)0;
			RaycastHit raycastHit2 = (RaycastHit)0;
			int num = n;
			object obj5 = 32;
			object obj6 = 4294967295L;
			object obj7 = 0;
			RaycastHit raycastHit3 = (RaycastHit)2139095039;
			raycastHit4 = (RaycastHit)2139095039;
			RaycastHit raycastHit7 = default;
			object obj21 = default;
			RaycastHit raycastHit9 = default;
			object obj26 = default;
			while (true)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj9 = !flag;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v6+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v10+10]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v10+10]");
				if ((nint)0 == 0)
				{
					goto IL_0720;
				}
				object obj12 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v11+18]");
				bool flag2 = (nint)obj12 < 0;
				object obj13 = !flag2;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v10+10]");
					object obj14 = 0 + obj5;
					RaycastHit raycastHit5 = (RaycastHit)obj14;
					Collider collider = raycastHit.collider;
					object obj15 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj16 = !flag3;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = collider == null;
					bool flag5 = !flag4;
					reference2 = ref *(RaycastHit*)null;
					raycastHit = raycastHit5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v14+20]");
					raycastHit2 = (RaycastHit)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v14+10]");
					RaycastHit raycastHit6 = (RaycastHit)0;
					num = 0;
					if (flag5)
					{
						bool flag6 = raycastHit7 < (object)0;
						object obj17 = !flag6;
						bool flag7 = raycastHit7 == (RaycastHit)(object)0;
						object obj18 = !flag7;
						object obj19 = obj17 & obj18;
						object obj20 = obj21;
						RaycastHit raycastHit8 = raycastHit9;
						RaycastHit raycastHit10 = raycastHit7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v14+10]");
						RaycastHit raycastHit11 = (RaycastHit)0;
						if (obj19 == null)
						{
							object obj22 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v21+A0]");
							object obj23 = 0;
							object obj24 = raycastHit5 - obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v22+8]");
							object obj25 = obj26 - 0;
							object obj27 = obj24 * obj24;
							raycastHit6 = (RaycastHit)(obj25 * obj25);
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
							raycastHit2 = (RaycastHit)(raycastHit6 + obj27);
							RaycastHit raycastHit12 = raycastHit2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
							bool flag8 = raycastHit12 < (object)0;
							obj21 = obj26;
							raycastHit9 = raycastHit5;
							reference2 = ref *(RaycastHit*)null;
							raycastHit = raycastHit5;
							num = 0;
							obj20 = obj26;
							raycastHit8 = raycastHit5;
							raycastHit10 = raycastHit2;
							raycastHit11 = raycastHit6;
							if (flag8)
							{
								goto IL_01b5;
							}
						}
						object obj28 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v18+E4]");
						bool flag9 = (nint)0 == 0;
						object obj29 = !flag9;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj28 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v18+A0]");
						object obj30 = 0;
						Collider collider2 = raycastHit.collider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+8]");
						if ((nint)0 == 0)
						{
							goto IL_0720;
						}
						reference2 = ref *(RaycastHit*)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+8]");
						if (((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)collider2))
						{
							bool flag10 = raycastHit7 >= raycastHit3;
							obj21 = obj20;
							raycastHit9 = raycastHit8;
							raycastHit2 = raycastHit7;
							raycastHit6 = raycastHit11;
							num = (int)collider2;
							if (!flag10)
							{
								obj21 = obj20;
								raycastHit9 = raycastHit8;
								raycastHit2 = raycastHit7;
								raycastHit6 = raycastHit11;
								num = (int)collider2;
								obj6 = obj7;
								raycastHit3 = raycastHit7;
							}
						}
						else
						{
							bool flag11 = raycastHit7 >= raycastHit4;
							obj21 = obj20;
							raycastHit9 = raycastHit8;
							raycastHit2 = raycastHit7;
							raycastHit6 = raycastHit11;
							num = (int)collider2;
							if (!flag11)
							{
								reference = ref *(RaycastHit*)raycastHit;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v14+10]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v14+20]");
								_ = 0;
								obj21 = obj20;
								raycastHit9 = raycastHit8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v14+10]");
								raycastHit5 = (RaycastHit)0;
								raycastHit2 = raycastHit7;
								raycastHit6 = raycastHit;
								num = (int)collider2;
								raycastHit4 = raycastHit7;
							}
						}
					}
					goto IL_01b5;
				}
				goto IL_072e;
				IL_0720:
				NullReferenceException ex = new NullReferenceException();
				goto IL_072e;
				IL_072e:
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				return (byte)(int)ex2 != 0;
				IL_01b5:
				obj7++;
				obj5 += 48;
				if (n != (nint)obj7)
				{
					continue;
				}
				object obj31 = obj6 & 0x80000000L;
				bool flag12 = obj31 == null;
				object obj32 = !flag12;
				if (obj32 != null || raycastHit3 >= raycastHit4)
				{
					break;
				}
				bool flag13 = (byte)(~(metSoft ? 1u : 0u)) != 0;
				object obj33 = !flag13;
				if (obj33 != null)
				{
					break;
				}
				object obj34 = obj;
				metSoft = true;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v30+E4]");
				bool flag14 = (nint)0 == 0;
				object obj35 = !flag14;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj34 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v30+A0]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v27+10]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v27+10]");
				if ((nint)0 == 0)
				{
					goto IL_0720;
				}
				object obj38 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X9_v8+18]");
				bool flag15 = (nint)obj38 < 0;
				object obj39 = !flag15;
				if (obj39 == null)
				{
					object obj40 = obj6 * 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v27+10]");
					object obj41 = 0 + obj40;
					object obj42 = this + 460;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X9_v9+20]");
					obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X9_v9+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v30+A0]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X9_v10+10]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X9_v10+10]");
					if ((nint)0 == 0)
					{
						goto IL_0720;
					}
					object obj45 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X9_v11+18]");
					bool flag16 = (nint)obj45 < 0;
					object obj46 = !flag16;
					if (obj46 == null)
					{
						object obj47 = obj6 * 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X9_v10+10]");
						object obj48 = 0 + obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X9_v12+2C]");
						softNormal = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X9_v12+34]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v30+A0]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X9_v13+10]");
						object obj50 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X9_v13+10]");
						if ((nint)0 == 0)
						{
							goto IL_0720;
						}
						object obj51 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X9_v14+18]");
						bool flag17 = (nint)obj51 < 0;
						object obj52 = !flag17;
						if (obj52 == null)
						{
							object obj53 = obj6 * 48;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X9_v13+10]");
							object obj54 = 0 + obj53;
							RaycastHit raycastHit13 = (RaycastHit)(obj54 + 32);
							Collider collider3 = ((RaycastHit*)raycastHit13)->collider;
							softCollider = collider3;
							object obj55 = this + 488;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							break;
						}
					}
				}
				goto IL_072e;
			}
		}
		else
		{
			raycastHit4 = (RaycastHit)2139095039;
		}
		object obj56 = raycastHit4 - 2139095039;
		return (nint)obj56 < 0;
	}

	public bool IsHandTouching(bool forLeftHand)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		bool flag = !forLeftHand;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = 248 + 1;
		}
		else
		{
			object obj2 = 248;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+v10 @ X8_v2]");
		return false;
	}

	public void Slow(float keep)
	{
		//IL_001f: Expected VT, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected VT, but got Unknown
		//IL_0071: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I4
		Vector3 linearVelocity = playerRigidBody.linearVelocity;
		playerRigidBody.linearVelocity = (Vector3)0;
		Vector3[] array = velocityHistory;
		object obj = default;
		Vector3 vector = denormalizedVelocityAverage * obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+C8]");
		float num = 0f * keep;
		denormalizedVelocityAverage = vector;
		object obj2 = 0;
		object obj3 = 0;
		while (true)
		{
			if ((nint)obj2 < array.Length)
			{
				bool flag = (nint)obj2 < array.Length;
				object obj4 = !flag;
				if (obj4 != null)
				{
					break;
				}
				object obj5 = (object)array + obj3;
				obj3 += 12;
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v5+20]");
				object obj6 = 0 * obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v5+28]");
				float num2 = 0f * keep;
				array = velocityHistory;
				bool flag2 = velocityHistory == null;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	public void Launch(Vector3 velocity, float seconds)
	{
		//IL_001b: Expected VT, but got I4
		InitializeValues();
		playerRigidBody.linearVelocity = (Vector3)0;
		float time = Time.time;
		object obj = default;
		float num = time + (float)obj;
		launchedUntil = num;
	}

	public void Turn(float degrees)
	{
		//IL_0019: Expected VT, but got I
		//IL_004e: Expected VT, but got I4
		//IL_00a8: Expected VT, but got I4
		//IL_0142: Expected VT, but got I4
		//IL_01ad: Expected VT, but got I4
		//IL_01d1: Expected VT, but got I4
		//IL_01f2: Expected VT, but got I4
		//IL_01f2: Expected VT, but got I4
		//IL_0212: Expected VT, but got I
		//IL_026e: Expected VT, but got I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0290: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I4
		//IL_02a2: Expected VT, but got I4
		//IL_02ab: Expected VT, but got I4
		//IL_045c: Expected VT, but got I4
		//IL_0493: Expected VT, but got F4
		//IL_04c7: Expected VT, but got I4
		//IL_0311: Expected VT, but got I4
		//IL_051b: Expected VT, but got I4
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected Obj, but got Unknown
		//IL_06a8: Expected Obj, but got F4
		//IL_06b5: Expected I, but got F4
		//IL_033a: Expected Obj, but got I4
		//IL_0357: Expected VT, but got I4
		//IL_0357: Expected VT, but got I4
		//IL_0376: Expected Obj, but got I4
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03ea: Expected Obj, but got I4
		//IL_0423: Expected VT, but got I4
		//IL_042c: Expected VT, but got I4
		//IL_0435: Expected VT, but got I4
		bool flag = (object)headCollider == null;
		IntPtr intPtr = default;
		Vector3 vector = (Vector3)(nint)intPtr;
		if (!flag)
		{
			Transform transform = headCollider.transform;
			bool flag2 = (object)transform == null;
			vector = (Vector3)0;
			if (!flag2)
			{
				Vector3 position = transform.position;
				Transform transform2 = base.transform;
				bool flag3 = (object)transform2 == null;
				object obj2 = default;
				object obj = obj2;
				object obj4 = default;
				object obj3 = obj4;
				float num = degrees;
				vector = (Vector3)0;
				if (!flag3)
				{
					Vector3 up = transform2.up;
					Vector3 axis = default;
					Quaternion quaternion = Quaternion.Internal_AngleAxis(degrees, ref axis);
					Transform transform3 = base.transform;
					Transform transform4 = base.transform;
					bool flag4 = (object)transform4 == null;
					Transform transform5 = transform3;
					object obj5 = obj2;
					object obj6 = obj4;
					float num2 = degrees;
					obj = obj2;
					obj3 = obj4;
					num = degrees;
					vector = (Vector3)0;
					if (!flag4)
					{
						Vector3 up2 = transform4.up;
						bool flag5 = (object)transform3 == null;
						transform5 = transform3;
						obj5 = obj2;
						obj6 = obj4;
						num2 = degrees;
						obj = obj2;
						obj3 = obj4;
						num = degrees;
						vector = (Vector3)0;
						if (!flag5)
						{
							Vector3 vector2 = default;
							transform3.RotateAround((Vector3)0, vector2, degrees);
							Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref axis);
							Vector3 vector3 = (Quaternion)0 * (Vector3)0;
							Vector3[] array = velocityHistory;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
							denormalizedVelocityAverage = (Vector3)0;
							bool flag6 = velocityHistory == null;
							transform5 = transform3;
							obj5 = obj2;
							obj6 = obj4;
							num2 = degrees;
							obj = obj2;
							obj3 = obj4;
							num = degrees;
							vector = (Vector3)0;
							if (!flag6)
							{
								transform5 = (Transform)(this + 328);
								object obj7 = 0;
								object obj8 = 0;
								axis = (Vector3)0;
								Vector3 vector4 = (Vector3)0;
								Quaternion turn = default;
								bool disabled = default;
								object obj16 = default;
								object obj18 = default;
								object obj20 = default;
								while (true)
								{
									bool flag7 = (nint)obj7 >= array.Length;
									obj5 = obj2;
									obj6 = obj4;
									num2 = degrees;
									obj = obj2;
									obj3 = obj4;
									num = degrees;
									vector = vector4;
									if (!flag7)
									{
										Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(ref axis);
										Vector3[] array2 = velocityHistory;
										bool flag8 = velocityHistory == null;
										obj5 = obj2;
										obj6 = obj4;
										num2 = degrees;
										obj = obj2;
										obj3 = obj4;
										num = degrees;
										vector = (Vector3)0;
										if (flag8)
										{
											break;
										}
										bool flag9 = (nint)obj7 < array2.Length;
										object obj9 = !flag9;
										if (obj9 == null)
										{
											Vector3 vector5 = (Quaternion)0 * (Vector3)0;
											bool flag10 = (nint)obj7 < array.Length;
											object obj10 = !flag10;
											if (obj10 == null)
											{
												object obj11 = (object)array + obj8;
												obj8 += 12;
												obj7++;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
												_ = 0;
												array = velocityHistory;
												bool flag11 = velocityHistory == null;
												object obj12 = !flag11;
												obj5 = obj2;
												obj6 = obj4;
												num2 = degrees;
												obj = obj2;
												obj3 = obj4;
												num = degrees;
												vector = (Vector3)0;
												axis = (Vector3)0;
												vector4 = (Vector3)0;
												if (obj12 == null)
												{
													break;
												}
												continue;
											}
										}
										throw new IndexOutOfRangeException();
									}
									Vector3 vector6 = (Quaternion)0 * vector;
									float num3 = num + num2;
									object obj13 = obj3 + obj6;
									object obj14 = obj + obj5;
									lastPosition = (Vector3)num3;
									bool flag12 = HandOff(right: false);
									Vector3 vector7 = TurnedHand((Vector3)flag12, vector2, turn, disabled);
									lastLeftHandPosition = lastLeftHandPosition;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+54]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+58]");
									_ = 0;
									bool flag13 = HandOff(right: true);
									Vector3 vector8 = TurnedHand((Vector3)flag13, vector2, turn, disabled);
									lastRightHandPosition = lastRightHandPosition;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+60]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+64]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
									object obj15 = (object)transform5 * obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									object obj17 = (nint)((UnityEngine.Object)transform5).m_CachedPtr * obj16;
									float num4 = num2 * (float)obj18;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
									object obj19 = obj20 * (object)transform5;
									float num5 = num2 * (float)obj5;
									object obj21 = obj20 * (nint)((UnityEngine.Object)transform5).m_CachedPtr;
									float num6 = (float)obj15 + num4;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
									float num7 = (float)obj17 + num5;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
									float num8 = num6 + (float)(nint)((UnityEngine.Object)transform5).m_CachedPtr;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
									float num9 = num7 + (float)obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
									float num10 = num8 - (float)obj19;
									float num11 = num9 - (float)obj21;
									transform5 = (Transform)num10;
									((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)num11;
									return;
								}
							}
						}
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private unsafe Vector3 TurnedHand(Vector3 last, Vector3 pivot, Quaternion turn, bool disabled)
	{
		//IL_000e: Expected VT, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_003a: Expected Obj, but got I4
		//IL_0067: Expected Ref, but got VT
		//IL_0067: Expected VT, but got I4
		//IL_0067: Expected VT, but got Ref
		//IL_0082: Expected VT, but got I4
		//IL_0098: Expected VT, but got I4
		Vector3 result = (Quaternion)0 * last;
		object obj = last & 1;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = default;
			float sphereRadius = default;
			float precision = default;
			bool flag2 = IterativeCollisionSphereCast((Vector3)(&obj3), sphereRadius, (Vector3)1, precision, out *(Vector3*)turn, disabled);
			bool flag3 = !flag2;
			result = (Vector3)flag2;
			if (!flag3)
			{
				result = (Vector3)flag2;
			}
		}
		return result;
	}

	private void StoreVelocities()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0089: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected VT, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected VT, but got Unknown
		//IL_0226: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I4
		//IL_02a0: Expected VT, but got F4
		object obj = velocityIndex + 1;
		int num = obj / velocityHistorySize;
		object obj2 = num * velocityHistorySize;
		int num2 = obj - obj2;
		Vector3[] array = velocityHistory;
		velocityIndex = num2;
		if (velocityHistory != null)
		{
			bool flag = num2 < array.Length;
			object obj3 = !flag;
			if (obj3 != null)
			{
				goto IL_02b9;
			}
			object obj4 = num2 * 12;
			object obj5 = (object)velocityHistory + obj4;
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+D8]");
				object obj7 = default;
				object obj6 = obj7 - 0;
				object obj9 = default;
				object obj8 = obj9 - lastPosition;
				float deltaTime = Time.deltaTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				float num3 = (float)obj6 / deltaTime;
				Vector3[] array2 = velocityHistory;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+D8]");
				Vector3 vector = (Vector3)(obj8 / 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+20]");
				object obj10 = vector - 0;
				currentVelocity = vector;
				object obj12 = default;
				object obj11 = obj10 / obj12;
				float num4 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+28]");
				float num5 = num4 - 0f;
				float num6 = num5 / (float)velocityHistorySize;
				Vector3 vector2 = denormalizedVelocityAverage + obj11;
				denormalizedVelocityAverage = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GorillaLocomotion.Player)+C8]");
				float num7 = 0f + num6;
				if (velocityHistory != null)
				{
					bool flag2 = velocityIndex < array2.Length;
					object obj13 = !flag2;
					if (obj13 != null)
					{
						goto IL_02b9;
					}
					object obj14 = velocityIndex * 12;
					object obj15 = (object)velocityHistory + obj14;
					Transform transform2 = base.transform;
					if ((object)transform2 != null)
					{
						Vector3 position2 = transform2.position;
						lastPosition = (Vector3)num3;
						return;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_02b9;
		IL_02b9:
		throw new IndexOutOfRangeException();
	}

	public Player()
	{
		//IL_00ca: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I
		//IL_00ec: Expected F4, but got I
		//IL_0107: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_012f: Expected F4, but got I
		//IL_0144: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B9F8]");
		maxArmLength = 0f;
		defaultPrecision = 0.995f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4470]");
		object obj3 = 0;
		object obj4 = this + 328;
		launchedUntil = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B2A0]");
		minimumRaycastDistance = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v9+A0]");
		object obj7 = 0;
		obj4 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v9+A0]");
		object obj8 = 0;
		leftWhich = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		bool[] array = default;
		intoNow = array;
		object obj9 = this + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		bool[] array2 = default;
		into = array2;
		object obj10 = this + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Vector3[] array3 = default;
		intoAt = array3;
		object obj11 = this + 512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Vector3[] array4 = default;
		intoFaces = array4;
		object obj12 = this + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Collider[] array5 = default;
		intoOn = array5;
		object obj13 = this + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static Player()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCC0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCD0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+A0]");
		object obj5 = (nint)0 + (nint)8;
		obj5 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+A0]");
		object obj7 = (nint)0 + (nint)16;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
