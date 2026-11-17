using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using GorillaLocomotion;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.XR;

public class MonsterPlayer : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<MonsterNet> _003C_003E9__80_0;

		public static Func<MonsterNet, bool> _003C_003E9__82_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD058]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal bool _003CSpawned_003Eb__80_0(MonsterNet m)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0061: Expected Obj, but got I4
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
			return (UnityEngine.Object)m == (UnityEngine.Object)null;
		}

		internal bool _003CCounted_003Eb__82_0(MonsterNet m)
		{
			//IL_0035: Expected I4, but got Obj
			if ((object)m != null)
			{
				return m.counted;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void _003C_002Ecctor_003Eb__88_0(NetworkRunner runner, NetworkObject o)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0109: Expected Obj, but got I4
			//IL_004a: Expected Obj, but got I4
			//IL_0141: Expected Obj, but got I4
			//IL_0072: Expected Obj, but got I
			//IL_008d: Expected Obj, but got I4
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
			bool flag2 = (UnityEngine.Object)o != (UnityEngine.Object)null;
			bool flag3 = !flag2;
			object obj4 = 0;
			UnityEngine.Object obj5 = null;
			UnityEngine.Object obj6 = null;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0B0]");
				object obj7 = 0;
				obj4 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F1DC");
				obj5 = (UnityEngine.Object)1;
				UnityEngine.Object obj8 = default;
				obj6 = obj8;
			}
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (obj6 != null)
			{
				_ = 1;
			}
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass20_0
	{
		public bool inHand;

		public Matrix4x4 back;

		public float dt;

		public Rigidbody rb;

		public Collider box;

		public MonsterPlayer _003C_003E4__this;
	}

	private sealed class _003C_003Ec__DisplayClass249_0
	{
		public MonsterPlayer _003C_003E4__this;

		public Vector3 velocity;

		internal void _003CDropBoth_003Eb__0()
		{
			//IL_0010: Expected VT, but got I4
			_003C_003E4__this.Drop((Vector3)0);
		}
	}

	private sealed class _003C_003Ec__DisplayClass255_0
	{
		public MonsterPlayer _003C_003E4__this;

		public bool right;

		public float reach;

		internal void _003CTakeSecond_003Eb__0()
		{
			_003C_003E4__this.PickUp(right, reach);
		}
	}

	public float squashSpeed;

	public float squashReach;

	public float maxDoorThrow;

	private GillaDoor slabDoor;

	private bool slabRight;

	private Matrix4x4 slabWas;

	private bool slabWasSet;

	private GillaDoor slabThrown;

	private float slabThrownTill;

	private readonly Dictionary<int, float> squashed;

	private const float FistTouch = default(float);

	private const float MostFistStep = default(float);

	private static MonsterPlayer Local__BackingField;

	private static int Current__BackingField;

	private static float ApeSize__BackingField;

	private static Action m_RigChanging;

	private static Action m_RigChanged;

	public static bool OwnerPunches;

	public static bool MenuPunches;

	public const float MenuShoveEvery = default(float);

	public Player locomotion;

	public Rigidbody body;

	public Transform head;

	public Transform leftTarget;

	public Transform rightTarget;

	public Transform leftFollower;

	public Transform rightFollower;

	public GameObject[] apeBodies;

	public float apeEyeHeight;

	public float apeReach;

	public float grabRadius;

	public float skinTouch;

	public float bodyTouch;

	public float graspFor;

	public float pullApart;

	public int punchesBeforeRip;

	public float hardestThrow;

	public float slamSwing;

	public float heldReach;

	public float smashSwing;

	public float smashMeet;

	public float punchSwing;

	public float punchSwingLasts;

	public float punchReach;

	public float punchEvery;

	public float freePunchSwing;

	public float punchShoveLeast;

	public float punchShoveMost;

	public float punchShoveLimit;

	public float punchAfterThrow;

	public float heldDeadFor;

	public float neverHeldAfter;

	public float maxBodyThrow;

	public float backHold;

	public float faster;

	private MonsterDirector.Entry entry;

	private bool locomotionWasOn;

	private MonsterAvatar worn;

	private CharacterController walker;

	private Vector3 planar;

	private float vy;

	private float backT;

	private float killCooldown;

	private float standHeight;

	private float wornFor;

	private float standEyes;

	private float crawlSize;

	private bool fitted;

	private Vector3 floatBy;

	private bool floatThrough;

	private int floatFrame;

	private RigidbodyInterpolation interp;

	private float maxArm;

	private float unstick;

	private float minCast;

	private float velLimit;

	private float maxJump;

	private float jumpBy;

	private Vector3 offL;

	private Vector3 offR;

	private bool crawling;

	private bool gripL;

	private bool gripR;

	private bool wasGripL;

	private bool wasGripR;

	private bool ripping;

	private bool ripWhole;

	private Vector3 lastL;

	private Vector3 lastR;

	private Vector3 velL;

	private Vector3 velR;

	private Vector3 throwL;

	private Vector3 throwR;

	private Vector3 lastRealL;

	private Vector3 lastRealR;

	private Vector3 realVelL;

	private Vector3 realVelR;

	private float punchIn;

	private float swungFor;

	private Vector3 swung;

	private readonly Vector3[] armWas;

	private readonly Vector3[] armSwung;

	private readonly float[] armSwungAt;

	private readonly float[] armLostAt;

	private readonly int[] deadBody;

	private readonly float[] deadSince;

	private NetworkApe held;

	private GillaDummy heldDummy;

	private bool heldRight;

	private float heldSince;

	private NetworkApe second;

	private GillaDummy secondDummy;

	private bool secondRight;

	private float secondSince;

	private ApePart ripPart;

	private float ripStart;

	private float ripStartReal;

	private readonly int[] bodyOf;

	private readonly int[] bodyPart;

	private readonly GillaPieceId[] pieceIn;

	private int ripBody;

	private int ripBodyPart;

	private bool ripBodyRight;

	private float ripBodyStart;

	private float ripBodyStartReal;

	private int awaitBody;

	private int awaitPart;

	private bool awaitRight;

	private float awaitUntil;

	private float nextAtRest;

	public static int TestGrips;

	public static Vector2? TestStick;

	public const float MoveDeadzone = default(float);

	public static Action TestEachFrame;

	private const float PunchNear = default(float);

	private const int Floor = default(int);

	private float snaredTill;

	private float struggleBuzz;

	private Vector3 snaredAt;

	private Vector3 snaredHead;

	private bool wasSnared;

	private int fistsFrame;

	private bool spawnRoomTold;

	private const float SpawnRoomTellEvery = default(float);

	private float SpawnRoomToldAt__BackingField;

	private const float SlamFastest = default(float);

	public static bool TestAnyHandPunches;

	private const float OnSomeoneFrom = default(float);

	private readonly List<Vector3> touching;

	private float closedL;

	private float closedR;

	public static MonsterPlayer Local
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
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
			return (MonsterPlayer)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
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

	public static int Current
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
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
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
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

	public static bool IsMonster
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+8]");
			bool flag3 = (nint)0 == 0;
			return !flag3;
		}
	}

	public static float ApeSize
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+C]");
			return 0f;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
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

	private static bool MenuShoves
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d1: Expected Obj, but got I4
			//IL_0082: Expected Obj, but got I4
			//IL_00f4: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (IsMonster)
			{
				return false;
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+20]");
			return (nint)0 == 0;
		}
	}

	public static bool ApePunchesOffHere
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_015a: Expected Obj, but got I4
			//IL_0180: Expected Obj, but got I
			//IL_01a2: Expected Obj, but got I4
			//IL_0205: Expected Obj, but got I
			//IL_0227: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I
			//IL_00ac: Expected Obj, but got I4
			//IL_01da: Expected Obj, but got I4
			//IL_0245: Expected Obj, but got I
			//IL_0255: Expected Obj, but got I
			//IL_0130: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v1+8]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v12+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v16+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v16+A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v13+8]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v13+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v14+90]");
					bool flag6 = (nint)0 == 0;
					return !flag6;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public static bool FistsOffInSpawn
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_012d: Expected Obj, but got I4
			//IL_0153: Expected Obj, but got I
			//IL_0175: Expected Obj, but got I4
			//IL_01d3: Expected Obj, but got I
			//IL_01f5: Expected Obj, but got I4
			//IL_00a4: Expected Obj, but got I4
			//IL_01ad: Expected Obj, but got I4
			//IL_0213: Expected Obj, but got I
			//IL_0103: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj8 != null)
			{
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v11+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v15+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v15+A0]");
				object obj14 = 0;
				if (obj14 != null)
				{
					return ((MonsterPlayer)obj14).SpawnRoomHolds;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private bool SpawnRoomHolds
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01b9: Expected Obj, but got I4
			//IL_017c: Expected Obj, but got I4
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected I4, but got Unknown
			//IL_018f: Expected I4, but got Obj
			//IL_008f: Expected Obj, but got I
			//IL_0097: Expected VT, but got Obj
			//IL_00b9: Expected Obj, but got I4
			//IL_0110: Expected Obj, but got I
			//IL_013a: Expected Obj, but got I4
			//IL_016e: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9;
			if (head != null)
			{
				if ((object)head == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				Vector3 position = head.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				object obj4 = 0;
				Vector3 at = (Vector3)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v13 (UnityEngine.Vector3)+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (InSpawnRoom(at))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool hasOwnerMenu = ModMenuAccess.HasOwnerMenu;
					obj9 = (hasOwnerMenu ? 1 : 0) ^ 1;
					goto IL_01c7;
				}
			}
			obj9 = 0;
			goto IL_01c7;
			IL_01c7:
			return (byte)(obj9 & 1) != 0;
		}
	}

	private bool WantsBack
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_02a7: Expected Obj, but got I
			//IL_02c9: Expected Obj, but got I4
			//IL_0302: Expected Obj, but got I
			//IL_0324: Expected Obj, but got I4
			//IL_0051: Expected VT, but got I
			//IL_0217: Expected Obj, but got I4
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Expected I4, but got Unknown
			//IL_009c: Expected Obj, but got I4
			//IL_00e1: Expected Obj, but got I4
			//IL_00ff: Expected Obj, but got I
			//IL_0129: Expected Obj, but got I4
			//IL_019d: Expected Obj, but got I4
			//IL_022c: Expected Obj, but got I
			//IL_0256: Expected Obj, but got I4
			//IL_028a: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X9_v1+8]");
			object obj19;
			if (Button((XRNode)4, (InputFeatureUsage<bool>)0))
			{
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = Grip((XRNode)4);
				bool flag5 = !flag4;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v14+E4]");
					bool flag6 = (nint)0 == 0;
					object obj13 = !flag6;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((UnityEngine.Object)held == (UnityEngine.Object)null)
					{
						object obj14 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v18+E4]");
						bool flag7 = (nint)0 == 0;
						object obj15 = !flag7;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if ((UnityEngine.Object)heldDummy == (UnityEngine.Object)null && !HasSecond)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
							object obj16 = 0;
							object obj17 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v24+E4]");
							bool flag8 = (nint)0 == 0;
							object obj18 = !flag8;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool huntingApes = GillaMapVote.HuntingApes;
							obj19 = (huntingApes ? 1 : 0) ^ 1;
							goto IL_02d7;
						}
					}
				}
			}
			obj19 = 0;
			goto IL_02d7;
			IL_02d7:
			return (byte)(obj19 & 1) != 0;
		}
	}

	public bool OnLegs
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0063: Expected Obj, but got I4
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
			return walker != null;
		}
	}

	public float SpawnRoomToldAt
	{
		get
		{
			return SpawnRoomToldAt__BackingField;
		}
		private set
		{
			SpawnRoomToldAt__BackingField = value;
		}
	}

	private float ReallyApart
	{
		get
		{
			//IL_00c0: Expected Obj, but got I
			//IL_00ea: Expected Obj, but got I4
			Vector3 vector = RealHand(right: false);
			Vector3 vector2 = RealHand(right: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = default;
			object obj4 = obj5 - obj5;
			object obj7 = default;
			object obj6 = obj7 - obj7;
			object obj9 = default;
			object obj8 = obj9 - obj9;
			object obj10 = obj6 * obj6;
			object obj11 = obj4 * obj4;
			object obj12 = obj10 + obj11;
			object obj13 = obj8 * obj8;
			float result = (float)obj13 + (float)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			return result;
		}
	}

	public float PunchReadyIn
	{
		get
		{
			//IL_0010: Expected F4, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			return 0f;
		}
	}

	public float ArmSwungLately
	{
		get
		{
			//IL_010d: Expected Obj, but got I
			//IL_0137: Expected Obj, but got I4
			//IL_0099: Expected Obj, but got I8
			//IL_016f: Expected Obj, but got I4
			//IL_019f: Expected Obj, but got I
			//IL_0212: Invalid comparison between F4 and I4
			//IL_0221: Invalid comparison between F4 and I4
			//IL_0234: Expected Obj, but got F4
			//IL_0241: Expected Obj, but got F4
			//IL_0276: Expected Obj, but got I4
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected Obj, but got Unknown
			Vector3[] array = armSwung;
			if (armSwung == null)
			{
				goto IL_00dc;
			}
			if (array.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Vector3[] array2 = armSwung;
				if (armSwung == null)
				{
					goto IL_00dc;
				}
				object obj4 = array2.Length & 0xFFFFFFFEL;
				if (obj4 != null)
				{
					object obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v9+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X22_v1 (UnityEngine.Vector3[])+24]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X22_v1 (UnityEngine.Vector3[])+24]");
					object obj7 = num * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X22_v1 (UnityEngine.Vector3[])+20]");
					float num2 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X22_v1 (UnityEngine.Vector3[])+20]");
					float num3 = num2 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
					object obj8 = default;
					float num4 = num3 + (float)obj8;
					float num5 = num4 + (float)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					float num7 = default;
					float num6 = num5 - num7;
					bool flag3 = num6 < 0f;
					bool flag4 = num6 == 0f;
					object obj9 = num5 ^ num7;
					object obj10 = num5 ^ num6;
					object obj11 = obj9 & obj10;
					bool flag5 = (nint)obj11 < 0;
					bool flag6 = flag3 == flag5;
					object obj12 = !flag4;
					object obj13 = flag6 & obj12;
					object obj14 = ~obj13;
					if (obj14 != null)
					{
						num5 = num7;
					}
					return num5;
				}
			}
			goto IL_00ea;
			IL_00ea:
			throw new IndexOutOfRangeException();
			IL_00dc:
			NullReferenceException ex = new NullReferenceException();
			goto IL_00ea;
		}
	}

	private bool HasSecond
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00dd: Expected Obj, but got I4
			//IL_0081: Expected Obj, but got I4
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
			if ((UnityEngine.Object)second != (UnityEngine.Object)null)
			{
				return true;
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return (UnityEngine.Object)secondDummy != (UnityEngine.Object)null;
		}
	}

	private static PlayerRef You
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0187: Expected Obj, but got I4
			//IL_01ad: Expected Obj, but got I
			//IL_01cf: Expected Obj, but got I4
			//IL_022d: Expected Obj, but got I
			//IL_024f: Expected Obj, but got I4
			//IL_00fa: Expected Obj, but got I
			//IL_0124: Expected Obj, but got I4
			//IL_00a4: Expected Obj, but got I4
			//IL_0207: Expected Obj, but got I4
			//IL_026d: Expected Obj, but got I
			//IL_015d: Expected VT, but got Obj
			//IL_00ea: Expected VT, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj8 != null)
			{
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v15+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v19+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v19+A0]");
				object obj14 = 0;
				object obj15 = obj14;
				if (obj14 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v16+6D0]");
					return (PlayerRef)0;
				}
				NullReferenceException ex = new NullReferenceException();
				return (PlayerRef)ex;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v10+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return PlayerRef.None;
		}
	}

	private float BodyTouch
	{
		get
		{
			Transform transform = base.transform;
			Vector3 localScale = transform.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			object obj = default;
			return bodyTouch * (float)obj;
		}
	}

	public bool Ripping => ripping;

	public bool RippingWhole
	{
		get
		{
			if (~(ripping ? 1u : 0u) == 0)
			{
				bool flag = !ripWhole;
				return !flag;
			}
			return false;
		}
	}

	public static event Action RigChanging
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	public static event Action RigChanged
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	private bool SlabIn(bool right)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (slabDoor != null)
		{
			object obj4 = (slabRight ? 1 : 0) - (right ? 1 : 0);
			return obj4 == null;
		}
		return false;
	}

	private unsafe bool PunchDoor(Vector3 from, Vector3 fist, Vector3 swing, float size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_113e: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_011e: Expected F4, but got I
		//IL_0154: Expected Obj, but got I
		//IL_01ba: Invalid comparison between F4 and I4
		//IL_007f: Expected Obj, but got I4
		//IL_115c: Expected Obj, but got I
		//IL_1215: Expected Obj, but got I
		//IL_123f: Expected Obj, but got I4
		//IL_1277: Expected Obj, but got I4
		//IL_1589: Expected Obj, but got I4
		//IL_15a7: Expected Obj, but got I
		//IL_15b7: Expected Obj, but got I
		//IL_0224: Invalid comparison between F4 and I4
		//IL_023e: Invalid comparison between F4 and I
		//IL_02cc: Expected Obj, but got I
		//IL_02e4: Expected Obj, but got I
		//IL_02ec: Expected F4, but got Obj
		//IL_02fc: Expected F4, but got I
		//IL_030c: Expected F4, but got I
		//IL_0344: Expected I, but got Obj
		//IL_0354: Expected Obj, but got I
		//IL_0364: Expected Obj, but got I
		//IL_0f3f: Invalid comparison between VT and I4
		//IL_0431: Expected VT, but got I4
		//IL_0f86: Invalid comparison between VT and I4
		//IL_12ea: Expected F4, but got I4
		//IL_039f: Expected Obj, but got I
		//IL_0f78: Expected Obj, but got I4
		//IL_04b7: Expected F4, but got I
		//IL_04ff: Expected Obj, but got I
		//IL_050f: Expected Obj, but got I
		//IL_051f: Expected Obj, but got I
		//IL_0530: Expected F4, but got I4
		//IL_0541: Expected Obj, but got I4
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_149f: Expected I, but got Obj
		//IL_14af: Expected Obj, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03d6: Invalid comparison between F4 and I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_0626: Expected VT, but got I4
		//IL_1636: Expected Obj, but got I4
		//IL_135b: Expected VT, but got I
		//IL_136e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1373: Expected Obj, but got Unknown
		//IL_138a: Expected Obj, but got Ref
		//IL_1398: Expected Obj, but got I4
		//IL_0594: Expected Obj, but got I
		//IL_0fec: Expected Obj, but got I
		//IL_0ffc: Expected Obj, but got I
		//IL_10ca: Expected Obj, but got I4
		//IL_108b: Expected VT, but got I4
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_1550: Expected VT, but got I
		//IL_1037: Expected Obj, but got I
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_05cb: Invalid comparison between F4 and I4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_0688: Expected I, but got Obj
		//IL_0698: Expected Obj, but got I
		//IL_10a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ab: Expected Obj, but got Unknown
		//IL_0eff: Expected Obj, but got Ref
		//IL_0f0d: Expected Obj, but got I4
		//IL_0765: Expected VT, but got I4
		//IL_1045: Unknown result type (might be due to invalid IL or missing references)
		//IL_104a: Expected Obj, but got Unknown
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Expected Obj, but got Unknown
		//IL_1424: Expected Obj, but got I4
		//IL_06d3: Expected Obj, but got I
		//IL_07d1: Expected Obj, but got I4
		//IL_07da: Expected VT, but got I4
		//IL_0e11: Expected Obj, but got I4
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected Obj, but got Unknown
		//IL_0800: Expected VT, but got I4
		//IL_0809: Expected VT, but got I4
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected Obj, but got Unknown
		//IL_070a: Invalid comparison between F4 and I4
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		//IL_082f: Expected Obj, but got I
		//IL_0851: Expected Obj, but got I4
		//IL_0892: Invalid comparison between F4 and I4
		//IL_08b6: Expected VT, but got I4
		//IL_08e9: Expected VT, but got I4
		//IL_092e: Expected Obj, but got I4
		//IL_0973: Expected Obj, but got I4
		//IL_097c: Expected VT, but got I4
		//IL_09aa: Expected VT, but got I4
		//IL_09b3: Expected VT, but got I4
		//IL_09e6: Expected VT, but got I4
		//IL_0a26: Expected Obj, but got I4
		//IL_0a61: Expected VT, but got I4
		//IL_0a61: Expected VT, but got Ref
		//IL_0a85: Expected VT, but got I4
		//IL_0ae9: Expected Obj, but got Ref
		//IL_0af7: Expected Obj, but got I4
		//IL_0b10: Expected VT, but got I4
		//IL_0b19: Expected VT, but got I4
		//IL_0b8c: Expected F4, but got I
		//IL_0b9c: Expected F4, but got I
		//IL_0bbb: Expected F4, but got I
		//IL_0bcc: Expected F4, but got I
		//IL_0c31: Expected F4, but got I
		//IL_0c51: Expected F4, but got I
		//IL_0c5a: Invalid comparison between F4 and I4
		//IL_0c6d: Expected Obj, but got F4
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7a: Expected Obj, but got Unknown
		//IL_0ca2: Expected Obj, but got I4
		//IL_0cd6: Expected F4, but got I
		//IL_144b: Expected Obj, but got I4
		//IL_147b: Expected Obj, but got I4
		//IL_160e: Expected Obj, but got I4
		//IL_0d84: Invalid comparison between F4 and I4
		//IL_0da8: Expected VT, but got I4
		//IL_0dc9: Expected VT, but got I4
		//IL_0e74: Expected VT, but got I4
		//IL_0e7c: Expected Obj, but got Ref
		//IL_0e8a: Expected Obj, but got I4
		//IL_0e9b: Expected VT, but got I4
		//IL_0eb4: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isMonster = IsMonster;
		bool flag2 = !isMonster;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v128+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v128+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v72+20]");
			if ((nint)0 == 0)
			{
				goto IL_00d3;
			}
		}
		float num = default;
		Vector3 vector = default;
		if (SomeoneByFist(vector, num))
		{
			goto IL_00d3;
		}
		float num2 = num - size;
		float num4 = default;
		float num5 = default;
		float num3 = num4 - num5;
		float num8 = default;
		float num7 = default;
		float num6 = num7 - num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num9 = 0f;
		float num10 = num2 * num2;
		float num12 = default;
		float num11 = num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num13 = num11 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj8 = 0;
		float num14 = num3 * num3;
		float num15 = num10 + num14;
		float num16 = num6 * num6;
		float num17 = num16 + num15;
		float num18 = num13 * num13;
		float num19 = num17 - num18;
		bool flag4 = num19 == 0f;
		bool flag5 = !(num17 > num18);
		float num26;
		float num27;
		float num29;
		float num30;
		float num31;
		float num28;
		if (!flag5)
		{
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v118+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num20 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			num19 = num20 - 0f;
			flag4 = num19 == 0f;
			float num21 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			flag5 = !(num21 > 0f);
			float num22;
			float num23;
			float num24;
			if (!flag5)
			{
				num22 = num2 / num9;
				num23 = num3 / num9;
				num24 = num6 / num9;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v67+A0]");
				object obj13 = 0;
				num22 = (float)obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v68+4]");
				num23 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v68+8]");
				num24 = 0f;
			}
			float num25 = num13 * num22;
			num16 = num13 * num23;
			num9 = num13 * num24;
			num26 = num - num25;
			num27 = num4 - num16;
			num18 = num7 - num9;
			num28 = num;
			num29 = num18;
			num30 = num4;
			num31 = num7;
		}
		else
		{
			num28 = size;
			num26 = size;
			num27 = num5;
			num29 = num8;
			num30 = num4;
			num31 = num7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v16+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v16+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v13+40]");
		GillaDoor gillaDoor = (GillaDoor)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v13+40]");
		bool flag9 = (nint)0 == 0;
		float num32 = num5;
		if (flag9)
		{
			goto IL_0f1a;
		}
		nint num33 = (nint)gillaDoor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAF8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v29 (Il2CppClass<GillaDoor>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v29 (Il2CppClass<GillaDoor>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_041e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v29 (Il2CppClass<GillaDoor>)+98]");
		object obj22 = (nint)0 + (nint)8;
		bool flag10 = flag5;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X10_v39-8]");
			num19 = 0f - (float)obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X10_v39-8]");
			if (0 == (nint)obj20)
			{
				break;
			}
			obj21--;
			num19 = (float)obj21 - 1f;
			flag4 = num19 == 0f;
			obj20 = obj22 + 16;
			flag5 = (nint)obj21 != 1;
			obj22 = obj20;
			flag10 = flag5;
			if (flag5)
			{
				continue;
			}
			goto IL_041e;
		}
		object obj23 = num33 + obj22;
		object obj24 = obj23 + 312;
		obj20 = obj22;
		flag5 = flag10;
		goto IL_12c8;
		IL_0f28:
		NullReferenceException ex = new NullReferenceException();
		object obj25 = default;
		OutOfMemoryException ex3 = default;
		NullReferenceException ex2;
		if (vector == (Vector3)(object)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj25 = 1;
		}
		else
		{
			bool flag11 = vector != (Vector3)(object)1;
			ex2 = ex;
			if (flag11)
			{
				goto IL_14f9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj26 = default;
			ex3 = (OutOfMemoryException)obj26;
		}
		goto IL_0fc6;
		IL_00d3:
		bool result = false;
		goto IL_10e0;
		IL_0e62:
		Vector3 way = default;
		gillaDoor.Punch((Vector3)0, way);
		object obj28 = default;
		object obj27 = (object)(&obj28);
		ex3 = null;
		obj25 = 0;
		float num34;
		num7 = num34;
		vector = (Vector3)0;
		num32 = num6;
		float num35;
		num28 = num35;
		num9 = 0f;
		float num36 = default;
		num16 = num36;
		float num37;
		num18 = num37;
		result = true;
		goto IL_14d4;
		IL_14d4:
		object obj29 = obj27;
		if (obj27 != null)
		{
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X8_v20+12E]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X8_v20+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1078;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X8_v20+98]");
			object obj33 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ X10_v11-8]");
				if (0 == (nint)obj31)
				{
					break;
				}
				obj32--;
				obj33 += 16;
				if ((nint)obj32 != 1)
				{
					continue;
				}
				goto IL_1078;
			}
			object obj34 = obj30 + obj33;
			object obj35 = obj34 + 312;
			goto IL_1540;
		}
		goto IL_161c;
		IL_0e57:
		throw new NullReferenceException();
		IL_14f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result2 = default;
		return result2;
		IL_161c:
		bool flag12 = ex3 == null;
		object obj36 = !flag12;
		if (obj36 == null)
		{
			bool flag13 = obj25 == null;
			object obj37 = !flag13;
			OutOfMemoryException ex4 = ex3;
			if (obj37 == null)
			{
				goto IL_10e0;
			}
		}
		else
		{
			OutOfMemoryException ex4 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex5 = default;
		ex2 = ex5;
		goto IL_14f9;
		IL_0f1a:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0f28;
		IL_1540:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ X0_v29+8]");
		vector = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1355 @ X0_v29] (should have been resolved before IL gen)");
		goto IL_161c;
		IL_12c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v811 @ X0_v46] (should have been resolved before IL gen)");
		GillaDoor gillaDoor2 = default;
		bool flag14 = (object)gillaDoor2 == null;
		num37 = 0f;
		num35 = num12;
		num34 = num26;
		if (flag14)
		{
			goto IL_0e57;
		}
		object obj39 = default;
		object obj38 = obj39 * obj39;
		object obj41 = default;
		object obj40 = obj41 * obj41;
		object obj42 = obj38 + obj40;
		object obj44 = default;
		object obj43 = obj44 * obj44;
		object obj45 = obj43 + obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		num9 = 0f;
		float num38 = num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num39 = num38 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num40 = (float)obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num41 = num40 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB00]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj48 = 0;
		float num43 = default;
		float num42 = num43;
		num37 = 0f;
		Vector3 vector2 = way;
		Collider collider = (Collider)109895680;
		GillaDoor gillaDoor3 = gillaDoor2;
		float num44 = num6;
		num32 = num5;
		num16 = num39;
		num18 = num41;
		float num45 = num12;
		float num46 = num26;
		object obj54 = default;
		UnityEngine.Object obj61 = default;
		IntPtr intPtr = default;
		while (true)
		{
			nint num47 = (nint)gillaDoor3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v38 (Il2CppClass<GillaDoor>)+12E]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v38 (Il2CppClass<GillaDoor>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0613;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v38 (Il2CppClass<GillaDoor>)+98]");
			object obj50 = (nint)0 + (nint)8;
			bool flag15 = flag5;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X10_v34-8]");
				num19 = 0f - (float)obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X10_v34-8]");
				if (0 == (nint)obj46)
				{
					break;
				}
				obj49--;
				num19 = (float)obj49 - 1f;
				flag4 = num19 == 0f;
				obj20 = obj50 + 16;
				flag5 = (nint)obj49 != 1;
				obj50 = obj20;
				flag15 = flag5;
				if (flag5)
				{
					continue;
				}
				goto IL_0613;
			}
			object obj51 = num47 + obj50;
			object obj52 = obj51 + 312;
			way = vector2;
			obj20 = obj50;
			flag5 = flag15;
			goto IL_134b;
			IL_0752:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			way = (Vector3)0;
			goto IL_13f0;
			IL_0ee0:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_0eee;
			IL_0eee:
			NullReferenceException ex8 = new NullReferenceException();
			obj27 = (object)(&obj28);
			ex3 = null;
			obj25 = 0;
			num43 = num42;
			goto IL_0f1a;
			IL_0613:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			way = (Vector3)0;
			goto IL_134b;
			IL_134b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X0_v54+8]");
			vector = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1198 @ X0_v54] (should have been resolved before IL gen)");
			object obj53 = obj54 & 1;
			bool flag16 = obj53 == null;
			obj27 = (object)(&obj28);
			ex3 = null;
			obj25 = 0;
			num43 = num42;
			if (flag16)
			{
				break;
			}
			if ((object)gillaDoor2 != null)
			{
				nint num48 = (nint)gillaDoor2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X8_v43 (Il2CppClass<GillaDoor>)+12E]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X8_v43 (Il2CppClass<GillaDoor>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0752;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X8_v43 (Il2CppClass<GillaDoor>)+98]");
				object obj56 = (nint)0 + (nint)8;
				bool flag17 = flag5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1360 @ X10_v29-8]");
					num19 = 0f - (float)obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1360 @ X10_v29-8]");
					if (0 == (nint)obj47)
					{
						break;
					}
					obj55--;
					num19 = (float)obj55 - 1f;
					flag4 = num19 == 0f;
					obj20 = obj56 + 16;
					flag5 = (nint)obj55 != 1;
					obj56 = obj20;
					flag17 = flag5;
					if (flag5)
					{
						continue;
					}
					goto IL_0752;
				}
				object obj57 = num48 + obj56;
				object obj58 = obj57 + 312;
				obj20 = obj56;
				flag5 = flag17;
				goto IL_13f0;
			}
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_0ee0;
			IL_13f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1389 @ X0_v62] (should have been resolved before IL gen)");
			object obj59 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1395 @ X0_v65+E4]");
			bool flag18 = (nint)0 == 0;
			object obj60 = !flag18;
			if (obj60 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag19 = obj61 == null;
			bool flag20 = !flag19;
			object obj62 = !flag20;
			vector2 = (Vector3)0;
			if (obj62 == null)
			{
				bool flag21 = (object)obj61 == null;
				way = (Vector3)0;
				vector = (Vector3)0;
				if (flag21)
				{
					goto IL_0ee0;
				}
				object obj63 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v64 (UnityEngine.Object)+E4]");
				collider = (Collider)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1424 @ X0_v71+E4]");
				bool flag22 = (nint)0 == 0;
				object obj64 = !flag22;
				if (obj64 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool isMonster2 = IsMonster;
				num19 = (float)collider - (float)(isMonster2 ? 1 : 0);
				flag4 = num19 == 0f;
				flag5 = (nint)collider != (isMonster2 ? 1 : 0);
				vector2 = (Vector3)0;
				if (!flag5)
				{
					bool punchable = ((GillaDoor)obj61).Punchable;
					bool flag23 = !punchable;
					vector2 = (Vector3)0;
					if (!flag23)
					{
						Collider slabBox = ((GillaDoor)obj61).SlabBox;
						object obj65 = obj48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1431 @ X0_v77+E4]");
						bool flag24 = (nint)0 == 0;
						object obj66 = !flag24;
						if (obj66 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag25 = slabBox == null;
						bool flag26 = !flag25;
						object obj67 = !flag26;
						vector2 = (Vector3)0;
						collider = slabBox;
						if (obj67 == null)
						{
							bool flag27 = (object)slabBox == null;
							way = (Vector3)0;
							vector = (Vector3)0;
							if (flag27)
							{
								goto IL_0eee;
							}
							bool flag28 = slabBox.enabled;
							bool flag29 = !flag28;
							vector2 = (Vector3)0;
							collider = slabBox;
							if (!flag29)
							{
								object obj68 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1441 @ X0_v83+E4]");
								bool flag30 = (nint)0 == 0;
								object obj69 = !flag30;
								if (obj69 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag31 = Touches(slabBox, (Vector3)(&num37), (Vector3)0, swing, num26, out *(Vector3*)intPtr);
								bool flag32 = !flag31;
								num7 = num31;
								vector2 = (Vector3)0;
								collider = slabBox;
								num32 = num30;
								num28 = num;
								num9 = num29;
								num16 = num27;
								num18 = num26;
								if (!flag32)
								{
									Vector3 foot = ((GillaDoor)obj61).Foot;
									bool flag33 = (object)head == null;
									obj27 = (object)(&obj28);
									ex3 = null;
									obj25 = 0;
									num43 = num42;
									num7 = num31;
									way = (Vector3)0;
									vector = (Vector3)0;
									num32 = num30;
									num28 = num;
									num9 = num29;
									num16 = num27;
									num18 = num26;
									if (flag33)
									{
										goto IL_0f28;
									}
									Vector3 position = head.position;
									float num49 = num26 - num26;
									float num50 = num27 - num27;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v64 (UnityEngine.Object)+144]");
									num28 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v64 (UnityEngine.Object)+148]");
									num32 = 0f;
									float num51 = num29 - num29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v64 (UnityEngine.Object)+14C]");
									num7 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v64 (UnityEngine.Object)+14C]");
									num42 = -0;
									float num52 = num49;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v64 (UnityEngine.Object)+144]");
									float num53 = num52 * 0f;
									float num54 = num50;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v64 (UnityEngine.Object)+148]");
									float num55 = num54 * 0f;
									float num56 = num53 + num55;
									float num57 = num51;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v64 (UnityEngine.Object)+14C]");
									float num58 = num57 * 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v64 (UnityEngine.Object)+148]");
									num9 = -0;
									float num59 = num58 + num56;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v64 (UnityEngine.Object)+144]");
									float num60 = -0;
									bool flag34 = num59 < 0f;
									object obj70 = num59 ^ num59;
									object obj71 = num59 & obj70;
									bool flag35 = (nint)obj71 < 0;
									bool flag36 = flag34 == flag35;
									object obj72 = !flag36;
									object obj73 = ~obj72;
									if (obj73 == null)
									{
										num45 = num60;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X0_v64 (UnityEngine.Object)+144]");
										num45 = 0f;
									}
									bool flag37 = flag34 == flag35;
									object obj74 = !flag37;
									object obj75 = ~obj74;
									num44 = ((obj75 != null) ? num32 : num9);
									bool flag38 = flag34 == flag35;
									object obj76 = !flag38;
									object obj77 = ~obj76;
									num46 = ((obj77 != null) ? num7 : num42);
									object obj78 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1493 @ X0_v92+E4]");
									bool flag39 = (nint)0 == 0;
									object obj79 = !flag39;
									if (obj79 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									float num61 = (float)obj39 * num45;
									float num62 = (float)obj41 * num44;
									float num63 = num61 + num62;
									float num64 = (float)obj44 * num46;
									num18 = num64 + num63;
									num19 = num18 - num41;
									flag4 = num19 == 0f;
									flag5 = !(num18 < num41);
									vector2 = (Vector3)0;
									collider = slabBox;
									num16 = num41;
									num43 = num42;
									way = (Vector3)0;
									gillaDoor = (GillaDoor)obj61;
									num6 = num44;
									num35 = num45;
									num34 = num46;
									if (flag5)
									{
										goto IL_0e62;
									}
								}
							}
						}
					}
				}
			}
			bool flag40 = (object)gillaDoor2 == null;
			object obj80 = !flag40;
			num43 = num42;
			way = vector2;
			gillaDoor = gillaDoor2;
			num6 = num44;
			num35 = num45;
			num34 = num46;
			gillaDoor3 = gillaDoor2;
			if (obj80 != null)
			{
				continue;
			}
			goto IL_0e57;
		}
		goto IL_0fc6;
		IL_041e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		way = (Vector3)0;
		goto IL_12c8;
		IL_0fc6:
		result = false;
		goto IL_14d4;
		IL_10e0:
		return result;
		IL_1078:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		way = (Vector3)0;
		goto IL_1540;
	}

	private unsafe static bool Touches(Collider box, Vector3 from, Vector3 to, Vector3 swing, float touch, out Vector3 on)
	{
		//IL_0009: Expected native int or pointer, but got VT
		//IL_0017: Expected native int or pointer, but got VT
		//IL_02e8: Expected Obj, but got I
		//IL_031f: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I
		//IL_0357: Expected F4, but got Obj
		//IL_0367: Expected Obj, but got I
		//IL_0377: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_047e: Invalid comparison between F4 and I
		//IL_04bc: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_0214: Invalid comparison between F4 and I
		//IL_0257: Expected VT, but got Ref
		//IL_02bc: Expected I4, but got Obj
		//IL_0285: Expected F4, but got VT
		//IL_0280: Expected native int or pointer, but got VT
		//IL_028d: Expected native int or pointer, but got VT
		((Vector3*)(nint)from)->x = 0f;
		((Vector3*)(nint)from)->z = 0f;
		object obj = default;
		float num = (float)obj - touch;
		object obj3 = default;
		object obj4 = default;
		object obj2 = obj3 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj5 = 0;
		object obj7 = default;
		object obj8 = default;
		object obj6 = obj7 - obj8;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		float num2;
		object obj12;
		object obj13;
		if ((nint)obj7 > 0)
		{
			num2 = num / (float)obj7;
			obj12 = obj2 / obj7;
			obj13 = obj6 / obj7;
		}
		else
		{
			object obj15 = default;
			object obj14 = obj15 * obj15;
			object obj17 = default;
			object obj16 = obj17 * obj17;
			object obj18 = obj14 + obj16;
			object obj20 = default;
			object obj19 = obj20 * obj20;
			object obj21 = obj19 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			if ((nint)obj21 > 0)
			{
				object obj22 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v30+E4]");
				bool flag2 = (nint)0 == 0;
				object obj23 = !flag2;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				if (num3 > 0)
				{
					float num4 = (float)obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
					num2 = num4 / 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
					obj12 = obj17 / 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
					obj13 = obj20 / 0;
					goto IL_03d6;
				}
			}
			object obj24 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v22+A0]");
			object obj25 = 0;
			num2 = (float)obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v23+4]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v23+8]");
			obj13 = 0;
		}
		goto IL_03d6;
		IL_03d6:
		object obj26 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v8+A0]");
		object obj27 = 0;
		object obj28 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v9+8]");
		object obj29 = obj28 - 0;
		object obj30 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v9+4]");
		object obj31 = obj30 - 0;
		float num5 = num2 - (float)obj27;
		float num6 = num5 * num5;
		object obj32 = obj31 * obj31;
		float num7 = num6 + (float)obj32;
		object obj33 = obj29 * obj29;
		float num8 = (float)obj33 + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if (!(num8 < 0f))
		{
			object obj34 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj35 = !flag3;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num9 = num2 * num2;
			object obj36 = obj12 * obj12;
			float num10 = num9 + (float)obj36;
			object obj37 = obj13 * obj13;
			float num11 = num10 + (float)obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (!(num11 > 0f) && (object)box == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			object obj39 = default;
			object obj38 = obj39 + obj39;
			float maxDistance = (float)obj38 + (float)obj7;
			object obj40 = default;
			if (box.Raycast((Ray)(&obj40), out var hitInfo, maxDistance))
			{
				((Vector3*)(nint)from)->x = (float)hitInfo;
				float z = default;
				((Vector3*)(nint)from)->z = z;
				return true;
			}
		}
		return false;
	}

	private unsafe bool SomeoneByFist(Vector3 fist, float size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0722: Expected Obj, but got I4
		//IL_087e: Expected Obj, but got I
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected VT, but got Obj
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected F4, but got Unknown
		//IL_04c3: Expected Obj, but got I4
		//IL_07ed: Expected VT, but got Obj
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected Ref, but got Unknown
		//IL_0810: Expected Obj, but got I4
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_04ea: Expected Obj, but got I4
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected Obj, but got Unknown
		//IL_05fd: Invalid comparison between VT and I4
		//IL_0153: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I4
		//IL_0655: Invalid comparison between VT and I4
		//IL_0636: Expected Obj, but got I4
		//IL_063f: Expected Obj, but got I4
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected F4, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got I4
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02a2: Expected Obj, but got I4
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Invalid comparison between Unknown and Obj
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected VT, but got I4
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected VT, but got I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected F4, but got Unknown
		//IL_0372: Expected VT, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got I4
		//IL_03cf: Expected VT, but got I4
		//IL_03ed: Expected Obj, but got I4
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+A0]");
		NetworkApe networkApe = (NetworkApe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v8 (NetworkApe)+8]");
		bool flag2 = (nint)0 == 0;
		Enumerator<, > val = (Enumerator<, >)0;
		NetworkApe networkApe3 = default;
		NetworkApe networkApe2 = networkApe3;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			object obj6 = 0;
			Enumerator<, > val3 = default;
			Enumerator<, > val2 = val3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
			Enumerator<, > val4 = (Enumerator<, >)(val2 * 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v8 (NetworkApe)+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			object obj7 = val4 * val4;
			Enumerator<, > val6 = default;
			Enumerator<, > val5 = val6;
			object obj9 = default;
			object obj8 = obj9;
			Enumerator<, > val8 = default;
			Enumerator<, > val7 = val8;
			NetworkApe networkApe4 = networkApe3;
			float num5;
			Enumerator<, > val10 = default;
			object obj11 = default;
			Enumerator<, > val12 = default;
			Enumerator<, > val14 = default;
			object obj13 = default;
			object obj15 = default;
			object obj18 = default;
			object obj32 = default;
			bool result2 = default;
			object obj28;
			Enumerator<, > val18;
			float num2 = default;
			while (true)
			{
				Vector3 vector = (Vector3)obj4;
				bool flag3 = val.MoveNext();
				bool flag4 = !flag3;
				Enumerator<, > val9 = val10;
				object obj10 = obj11;
				Enumerator<, > val11 = val12;
				Enumerator<, > val13 = val14;
				object obj12 = obj13;
				object obj14 = obj15;
				Enumerator<, > val15 = val5;
				object obj16 = obj8;
				Enumerator<, > val16 = val3;
				object obj17 = obj18;
				Enumerator<, > val17 = val7;
				networkApe = networkApe4;
				if (flag4)
				{
					goto IL_0493;
				}
				object obj19 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v32+E4]");
				networkApe4 = (NetworkApe)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v32+E4]");
				bool flag5 = (nint)0 == 0;
				object obj20 = !flag5;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!CanTouch(networkApe3))
				{
					continue;
				}
				object obj21 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v36+E4]");
				networkApe4 = (NetworkApe)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v36+E4]");
				bool flag6 = (nint)0 == 0;
				object obj22 = !flag6;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!LandsOn(networkApe3))
				{
					continue;
				}
				if ((object)networkApe3 != null)
				{
					if ((object)networkApe3.head != null)
					{
						Vector3 position = networkApe3.head.position;
						float num = (float)val7 - num2;
						object obj23 = obj8 - obj9;
						val5 -= val6;
						float num3 = num * num;
						object obj24 = obj23 * obj23;
						float num4 = num3 + (float)obj24;
						obj8 = val5 * val5;
						val7 = (Enumerator<, >)(obj8 + num4);
						object obj25 = val7 - obj7;
						bool flag7 = obj25 == null;
						obj15 = !flag7;
						bool flag8 = System.Runtime.CompilerServices.Unsafe.As<Enumerator<, >, UIntPtr>(ref val7) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
						val3 = val6;
						obj18 = obj9;
						if (flag8)
						{
							continue;
						}
						bool flag9 = (object)head == null;
						val3 = val6;
						obj18 = obj9;
						vector = (Vector3)0;
						if (!flag9)
						{
							Vector3 position2 = head.position;
							bool flag10 = (object)networkApe3.head == null;
							val3 = val6;
							obj18 = obj9;
							vector = (Vector3)0;
							num5 = (float)val7;
							if (flag10)
							{
								break;
							}
							Vector3 position3 = networkApe3.head.position;
							Vector3 vector2 = (Vector3)obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v54 (UnityEngine.Vector3)+E4]");
							networkApe = (NetworkApe)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v54 (UnityEngine.Vector3)+E4]");
							bool flag11 = (nint)0 == 0;
							object obj26 = !flag11;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag12 = Walled(vector2, (Vector3)0);
							bool flag13 = !flag12;
							object obj27 = !flag13;
							val9 = val5;
							obj10 = obj8;
							val11 = val7;
							val13 = val5;
							obj12 = obj8;
							obj14 = obj15;
							val15 = val5;
							obj16 = obj8;
							val16 = val7;
							obj17 = obj8;
							val17 = val7;
							val10 = val5;
							obj11 = obj8;
							val12 = val7;
							val14 = val5;
							obj13 = obj8;
							val3 = val7;
							obj18 = obj8;
							networkApe4 = networkApe;
							if (obj27 != null)
							{
								continue;
							}
							goto IL_0493;
						}
						goto IL_0571;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_0571;
				IL_0493:
				obj28 = 0;
				val = val8;
				networkApe2 = null;
				val18 = (Enumerator<, >)(ref val);
				num2 = (float)val17;
				object obj29 = 0;
				bool result = flag3;
				while (true)
				{
					vector = (Vector3)obj6;
					((Enumerator<, >*)val18)->Dispose();
					bool flag14 = obj29 == null;
					object obj30 = !flag14;
					val10 = val9;
					obj11 = obj10;
					val12 = val11;
					val14 = val13;
					obj13 = obj12;
					obj15 = obj14;
					val6 = val15;
					obj9 = obj16;
					val3 = val16;
					obj18 = obj17;
					if (obj30 == null)
					{
						bool flag15 = (object)networkApe2 == null;
						object obj31 = !flag15;
						val10 = val9;
						obj11 = obj10;
						val12 = val11;
						val14 = val13;
						obj13 = obj12;
						obj15 = obj14;
						val6 = val15;
						obj9 = obj16;
						val3 = val16;
						obj18 = obj17;
						OutOfMemoryException ex3 = (OutOfMemoryException)val18;
						if (obj31 == null)
						{
							return result;
						}
					}
					else
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if (vector == (Vector3)(object)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						networkApe2 = (NetworkApe)1;
						networkApe = (NetworkApe)1;
						obj29 = obj28;
					}
					else
					{
						if (vector != (Vector3)(object)1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj29 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj28 = obj32;
					}
					val9 = val10;
					obj10 = obj11;
					val11 = val12;
					val13 = val14;
					obj12 = obj13;
					obj14 = obj15;
					val15 = val6;
					obj16 = obj9;
					val16 = val3;
					obj17 = obj18;
					result = false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result2;
				IL_0571:
				NullReferenceException ex4 = new NullReferenceException();
				num5 = (float)val7;
				break;
			}
			NullReferenceException ex5 = new NullReferenceException();
			val6 = val5;
			obj9 = obj8;
			obj28 = 0;
			val = val8;
			networkApe2 = null;
			val18 = (Enumerator<, >)(ref val);
			num2 = num5;
		}
		throw new NullReferenceException();
	}

	private unsafe void TakeSlabs(float reach)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a4f: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I4
		//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected Obj, but got Unknown
		//IL_0b1f: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_0a68: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_0a95: Expected Obj, but got I
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		//IL_0ac4: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I4
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0441: Expected Obj, but got I4
		//IL_044a: Expected Obj, but got I4
		//IL_0453: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I8
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0220: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I4
		//IL_02d0: Expected VT, but got Ref
		//IL_02ee: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I
		//IL_0338: Expected VT, but got Obj
		//IL_035a: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I
		//IL_03c2: Expected Obj, but got I4
		//IL_04a6: Expected Obj, but got I
		//IL_04f7: Expected Obj, but got I
		//IL_050f: Expected VT, but got I4
		//IL_050f: Expected VT, but got I4
		//IL_053f: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I4
		//IL_05a0: Expected Obj, but got I
		//IL_05ca: Expected Obj, but got I4
		//IL_060d: Expected Obj, but got I4
		//IL_07c8: Expected Obj, but got I
		//IL_07f2: Expected Obj, but got I4
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected I4, but got Unknown
		//IL_0852: Expected VT, but got I4
		//IL_085b: Expected VT, but got I4
		//IL_0890: Expected Obj, but got I
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected Obj, but got Unknown
		//IL_08c2: Expected Obj, but got I
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected Obj, but got Unknown
		//IL_0902: Expected Obj, but got I4
		//IL_064d: Expected Obj, but got I
		//IL_0677: Expected Obj, but got I4
		//IL_06a6: Expected Obj, but got I
		//IL_06c2: Expected Obj, but got I4
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected Obj, but got Unknown
		//IL_09a2: Expected Obj, but got I4
		//IL_095e: Expected Obj, but got I4
		//IL_0b58: Expected Obj, but got I4
		//IL_0a0b: Expected F4, but got I
		//IL_0a0b: Expected F4, but got I
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_072a: Expected Obj, but got I4
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected I4, but got Unknown
		//IL_077e: Expected VT, but got I4
		//IL_077e: Expected VT, but got Ref
		//IL_078b: Expected VT, but got Ref
		//IL_07b3: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!IsMonster)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = this + 48;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)obj5 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj9 = 0;
		object obj10 = 1;
		object obj11 = 0;
		ref int reference = ref *(int*)null;
		object obj12 = 0;
		object obj32 = default;
		Quaternion rotation2 = default;
		UnityEngine.Object obj45 = default;
		object obj52 = default;
		object obj53 = default;
		RpcInfo info = default;
		object obj55 = default;
		object obj57 = default;
		PlayerRef playerRef = default;
		Quaternion rot = default;
		XRNode node;
		while (true)
		{
			object obj13 = obj11 & 1;
			bool flag5 = obj13 == null;
			object obj14 = !flag5;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
				object obj16 = 477 + 1;
			}
			else
			{
				object obj16 = 477;
			}
			object obj17 = !flag5;
			object obj18 = ~obj17;
			if (obj18 == null)
			{
				object obj19 = 479 + 1;
			}
			else
			{
				object obj19 = 479;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v418 @ X10_v3]");
			object obj20 = (nint)0 ^ (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v423 @ X11_v3]");
			object obj21 = 0 | obj20;
			bool flag6 = obj21 == null;
			object obj22 = !flag6;
			GillaDoor gillaDoor;
			if (obj22 == null)
			{
				int[] array = bodyOf;
				if (bodyOf == null)
				{
					goto IL_0a10;
				}
				bool flag7 = (nint)obj12 < array.Length;
				object obj23 = !flag7;
				if (obj23 != null)
				{
					goto IL_0a1e;
				}
				object obj24 = (object)bodyOf + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v14+20]");
				object obj25 = 0 & 0x80000000L;
				if (obj25 != null)
				{
					object obj26 = obj11 & 1;
					bool flag8 = obj26 == null;
					object obj27 = !flag8;
					object obj28 = ~obj27;
					if (obj28 == null)
					{
						object obj29 = 200;
					}
					else
					{
						object obj29 = 192;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v539 @ X8_v16]");
					if ((nint)0 == 0)
					{
						goto IL_0a10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v539 @ X8_v16]");
					Vector3 position = ((Transform)0).position;
					float num = BodyTouch;
					object obj30 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v19+E4]");
					bool flag9 = (nint)0 == 0;
					object obj31 = !flag9;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					flag3 = GillaCorpse.Nearest((Vector3)(&obj32), reach, out var _, out *(int*)null);
					bool flag10 = !flag3;
					object obj33 = !flag10;
					float num2 = num;
					reference = ref *(int*)null;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v539 @ X8_v16]");
						Vector3 position2 = ((Transform)0).position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
						object obj34 = 0;
						Vector3 at = (Vector3)obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v26 (UnityEngine.Vector3)+E4]");
						bool flag11 = (nint)0 == 0;
						object obj35 = !flag11;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						gillaDoor = NearestLoose(at, reach);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj36 = 0;
						object obj37 = obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v23+E4]");
						bool flag12 = (nint)0 == 0;
						object obj38 = !flag12;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						flag3 = gillaDoor == null;
						bool flag13 = !flag3;
						num2 = reach;
						reference = ref *(int*)null;
						if (flag13)
						{
							if ((object)gillaDoor != null)
							{
								Transform loose = gillaDoor.Loose;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v539 @ X8_v16]");
								Quaternion rotation = ((Transform)0).rotation;
								Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
								if ((object)loose != null)
								{
									Vector3 position3 = loose.position;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v539 @ X8_v16]");
									Vector3 position4 = ((Transform)0).position;
									Vector3 vector = (Quaternion)0 * (Vector3)0;
									Quaternion rotation3 = loose.rotation;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
									object obj39 = 0;
									object obj40 = obj39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X0_v47+E4]");
									bool flag14 = (nint)0 == 0;
									object obj41 = !flag14;
									if (obj41 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F0765C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
									object obj42 = 0;
									object obj43 = obj42;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v29+E4]");
									bool flag15 = (nint)0 == 0;
									object obj44 = !flag15;
									if (obj44 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag16 = obj45 != null;
									bool flag17 = !flag16;
									object obj46 = 0;
									UnityEngine.Object obj47 = null;
									bool flag23;
									Vector3 vector2;
									float num3;
									object obj54;
									object obj56;
									float num4;
									if (!flag17)
									{
										if ((object)obj45 == null)
										{
											goto IL_0a10;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
										object obj48 = 0;
										object obj49 = obj48;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v78+E4]");
										bool flag18 = (nint)0 == 0;
										object obj50 = !flag18;
										if (obj50 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v50 (UnityEngine.Object)+40]");
										bool flag19 = (UnityEngine.Object)0 != null;
										bool flag20 = !flag19;
										obj46 = 0;
										obj47 = null;
										if (!flag20)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v50 (UnityEngine.Object)+40]");
											if ((nint)0 == 0)
											{
												goto IL_0a10;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DA9760");
											object obj51 = obj52 & 1;
											bool flag21 = obj51 == null;
											obj46 = 0;
											obj47 = null;
											if (!flag21)
											{
												bool flag22 = (byte)(obj11 & 1) != 0;
												NetworkBool networkBool = flag22;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v27 (GillaDoor)+98]");
												((NetworkApe)obj45).RPC_HoldDoor((byte)0, networkBool, (Vector3)(&obj53), (Quaternion)0, info);
												vector2 = (Vector3)(&obj53);
												num3 = reach;
												obj54 = obj55;
												obj56 = obj57;
												num4 = reach;
												flag23 = (byte)(int)networkBool != 0;
												goto IL_0880;
											}
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
									object obj58 = 0;
									object obj59 = obj58;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X0_v70+E4]");
									bool flag24 = (nint)0 == 0;
									object obj60 = !flag24;
									if (obj60 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									PlayerRef none = PlayerRef.None;
									int playerId = playerRef.PlayerId;
									flag23 = (byte)(obj11 & 1) != 0;
									gillaDoor.Hold(playerId, flag23, (Vector3)0, rot);
									vector2 = (Vector3)0;
									num3 = reach;
									obj54 = obj55;
									obj56 = obj57;
									num4 = reach;
									goto IL_0880;
								}
							}
							goto IL_0a10;
						}
					}
				}
			}
			object obj61 = obj10 & 1;
			bool flag25 = obj61 == null;
			object obj62 = !flag25;
			obj10 = 0;
			obj11 = 1;
			obj12 = 1;
			if (obj62 == null)
			{
				return;
			}
			continue;
			IL_0a1e:
			throw new IndexOutOfRangeException();
			IL_0880:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj63 = 0;
			object obj64 = obj11 & 1;
			slabDoor = gillaDoor;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj65 = 0;
			object obj66 = this + 128;
			object obj67 = obj65;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v57+E4]");
			bool flag26 = (nint)0 == 0;
			object obj68 = !flag26;
			if (obj68 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag27 = (UnityEngine.Object)obj66 == gillaDoor;
			bool flag28 = !flag27;
			UnityEngine.Object obj69 = gillaDoor;
			if (!flag28)
			{
				obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj69 = null;
			}
			object obj70 = obj63;
			object obj71 = obj11 & 1;
			bool flag29 = obj71 == null;
			object obj72 = !flag29;
			object obj73 = ~obj72;
			node = ((obj73 != null) ? ((XRNode)4) : ((XRNode)5));
			break;
			IL_0a10:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0a1e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X0_v62+E4]");
		bool flag30 = (nint)0 == 0;
		object obj74 = !flag30;
		if (obj74 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		Buzz(node, num5, 0f);
	}

	private unsafe static GillaDoor NearestLoose(Vector3 at, float reach)
	{
		//IL_0010: Expected Obj, but got I
		//IL_09ea: Expected Obj, but got I4
		//IL_0a22: Expected Obj, but got I4
		//IL_0d39: Expected Obj, but got I
		//IL_0d49: Expected Obj, but got I
		//IL_0d6e: Expected Obj, but got I4
		//IL_0881: Expected VT, but got I
		//IL_0048: Expected I, but got Obj
		//IL_0058: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_0848: Expected I, but got VT
		//IL_0ab4: Expected Obj, but got Ref
		//IL_0ac4: Expected Obj, but got Ref
		//IL_0acd: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I
		//IL_0a53: Invalid comparison between F4 and I4
		//IL_0198: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_0c6b: Expected I, but got Obj
		//IL_0c7b: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_00e1: Invalid comparison between F4 and I4
		//IL_00f0: Invalid comparison between F4 and I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got I4
		//IL_0b44: Expected VT, but got I
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5c: Expected Obj, but got Unknown
		//IL_0210: Expected Obj, but got I
		//IL_088e: Expected Obj, but got Ref
		//IL_0afe: Invalid comparison between F4 and I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_08cb: Expected Obj, but got I
		//IL_08db: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_024e: Invalid comparison between F4 and I4
		//IL_025d: Invalid comparison between F4 and I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_096a: Expected Obj, but got I4
		//IL_0820: Expected Obj, but got Ref
		//IL_031a: Expected I, but got Obj
		//IL_032a: Expected Obj, but got I
		//IL_0d1a: Expected VT, but got I
		//IL_0916: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I4
		//IL_0beb: Expected Obj, but got I
		//IL_0c0d: Expected Obj, but got I4
		//IL_0365: Expected Obj, but got I
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected Obj, but got Unknown
		//IL_0481: Expected Obj, but got I4
		//IL_048a: Expected Obj, but got I4
		//IL_0493: Expected VT, but got I4
		//IL_0b9b: Invalid comparison between F4 and I4
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected Obj, but got Unknown
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected Obj, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got Unknown
		//IL_04ba: Expected Obj, but got Ref
		//IL_04cd: Expected Obj, but got I4
		//IL_04d6: Expected VT, but got I4
		//IL_0388: Expected Obj, but got I
		//IL_03a3: Invalid comparison between F4 and I4
		//IL_03b2: Invalid comparison between F4 and I4
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_04f4: Expected Obj, but got I
		//IL_0514: Expected Obj, but got I4
		//IL_051d: Expected VT, but got I4
		//IL_0552: Expected Obj, but got I4
		//IL_055b: Expected Obj, but got I4
		//IL_0564: Expected VT, but got I4
		//IL_0597: Expected Obj, but got I
		//IL_05b9: Expected Obj, but got I4
		//IL_05fe: Expected Obj, but got I4
		//IL_0607: Expected Obj, but got I4
		//IL_0610: Expected VT, but got I4
		//IL_0637: Expected Obj, but got Ref
		//IL_0652: Expected Obj, but got I4
		//IL_0657: Expected I, but got Obj
		//IL_0673: Expected VT, but got I4
		//IL_0c33: Expected Obj, but got I
		//IL_0c55: Expected Obj, but got I4
		//IL_072d: Invalid comparison between F4 and I4
		//IL_0740: Expected Obj, but got I4
		//IL_0749: Expected VT, but got I4
		//IL_07bf: Expected Obj, but got I4
		//IL_07df: Expected Obj, but got Ref
		//IL_07fa: Expected Obj, but got I4
		//IL_0803: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+40]");
		GillaDoor gillaDoor = (GillaDoor)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+40]");
		bool flag3 = (nint)0 == 0;
		Collider collider = null;
		object obj7 = 109895680;
		if (flag3)
		{
			goto IL_086b;
		}
		nint num = (nint)gillaDoor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAF8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v13 (Il2CppClass<GillaDoor>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v13 (Il2CppClass<GillaDoor>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0138;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v13 (Il2CppClass<GillaDoor>)+98]");
		object obj10 = (nint)0 + (nint)8;
		bool flag5 = default;
		bool flag4 = flag5;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X10_v36-8]");
			float num2 = 0f - (float)obj8;
			bool flag6 = num2 < 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X10_v36-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v13 (Il2CppClass<GillaDoor>)+12E]");
			obj9 = -1;
			num2 = (float)obj9 - 1f;
			flag6 = num2 < 0f;
			bool flag7 = num2 == 0f;
			obj8 = obj10 + 16;
			flag5 = (nint)obj9 != 1;
			flag4 = flag5;
			obj10 = obj8;
			if (flag5)
			{
				continue;
			}
			goto IL_0138;
		}
		obj9 = obj10;
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		flag5 = flag4;
		obj8 = obj10;
		goto IL_0a81;
		IL_086b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0879;
		IL_0ca0:
		NullReferenceException ex2 = new NullReferenceException();
		object obj14 = default;
		object obj13 = obj14;
		object obj16 = default;
		object obj15 = obj16;
		goto IL_0837;
		IL_0a81:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v16+8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v414 @ X0_v16] (should have been resolved before IL gen)");
		Collider collider2 = default;
		flag3 = (object)collider2 == null;
		object obj17 = (object)(&collider);
		collider = collider2;
		obj6 = (object)(&collider);
		obj7 = 109895680;
		Vector3 vector;
		object obj25;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB00]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			obj7 = 0;
			obj13 = obj14;
			obj15 = obj16;
			float num5 = default;
			float num4 = num5;
			UnityEngine.Object obj21 = null;
			Collider collider3 = collider2;
			float num7 = default;
			float num6 = num7;
			object obj24 = default;
			object obj27 = default;
			UnityEngine.Object obj41 = default;
			GillaDoor result = default;
			while (true)
			{
				nint num8 = (nint)collider3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v19 (Il2CppClass<UnityEngine.Collider>)+12E]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v19 (Il2CppClass<UnityEngine.Collider>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02a5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v19 (Il2CppClass<UnityEngine.Collider>)+98]");
				object obj22 = (nint)0 + (nint)8;
				bool flag8 = flag5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X10_v31-8]");
					float num2 = 0f - (float)obj18;
					bool flag6 = num2 < 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X10_v31-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v19 (Il2CppClass<UnityEngine.Collider>)+12E]");
					obj9 = -1;
					num2 = (float)obj9 - 1f;
					flag6 = num2 < 0f;
					bool flag7 = num2 == 0f;
					obj8 = obj22 + 16;
					flag5 = (nint)obj9 != 1;
					flag8 = flag5;
					obj22 = obj8;
					if (flag5)
					{
						continue;
					}
					goto IL_02a5;
				}
				obj9 = obj22;
				object obj23 = num8 + obj22;
				obj24 = obj23 + 312;
				flag5 = flag8;
				obj8 = obj22;
				goto IL_0b2c;
				IL_0d0a:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v36+8]");
				vector = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v829 @ X0_v36] (should have been resolved before IL gen)");
				goto IL_099e;
				IL_0957:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				obj25 = 0;
				goto IL_0d0a;
				IL_03fa:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				obj25 = 0;
				goto IL_0bc9;
				IL_02a5:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				obj25 = 0;
				goto IL_0b2c;
				IL_0b2c:
				obj6 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X0_v21+8]");
				vector = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v624 @ X0_v21] (should have been resolved before IL gen)");
				object obj26 = obj27 & 1;
				if (obj26 != null)
				{
					if ((object)collider2 != null)
					{
						nint num9 = (nint)collider2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v32 (Il2CppClass<UnityEngine.Collider>)+12E]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v32 (Il2CppClass<UnityEngine.Collider>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_03fa;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v32 (Il2CppClass<UnityEngine.Collider>)+98]");
						object obj28 = (nint)0 + (nint)8;
						bool flag9 = flag5;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X10_v26-8]");
							float num2 = 0f - (float)obj19;
							bool flag6 = num2 < 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X10_v26-8]");
							if (0 == (nint)obj19)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v32 (Il2CppClass<UnityEngine.Collider>)+12E]");
							obj9 = -1;
							num2 = (float)obj9 - 1f;
							flag6 = num2 < 0f;
							bool flag7 = num2 == 0f;
							obj8 = obj28 + 16;
							flag5 = (nint)obj9 != 1;
							flag9 = flag5;
							obj28 = obj8;
							if (flag5)
							{
								continue;
							}
							goto IL_03fa;
						}
						obj9 = obj28;
						object obj29 = num9 + obj28;
						object obj30 = obj29 + 312;
						flag5 = flag9;
						obj8 = obj28;
						goto IL_0bc9;
					}
					NullReferenceException ex3 = new NullReferenceException();
					goto IL_0816;
				}
				object obj31 = (object)(&collider);
				object obj32 = obj31;
				if (obj31 != null)
				{
					object obj33 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v27+12E]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v27+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0957;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v27+98]");
					object obj36 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X10_v19-8]");
						if (0 == (nint)obj34)
						{
							break;
						}
						obj35--;
						obj36 += 16;
						if ((nint)obj35 != 1)
						{
							continue;
						}
						goto IL_0957;
					}
					object obj37 = obj33 + obj36;
					object obj38 = obj37 + 312;
					goto IL_0d0a;
				}
				goto IL_099e;
				IL_0bc9:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v816 @ X0_v44] (should have been resolved before IL gen)");
				object obj39 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v47+E4]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v47+E4]");
				bool flag10 = (nint)0 == 0;
				object obj40 = !flag10;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag11 = obj41 == null;
				bool flag12 = !flag11;
				object obj42 = !flag12;
				obj25 = 0;
				vector = (Vector3)0;
				if (obj42 == null)
				{
					flag3 = (object)obj41 == null;
					obj17 = (object)(&collider);
					collider = collider2;
					obj25 = 0;
					vector = (Vector3)0;
					if (flag3)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v46 (UnityEngine.Object)+E4]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v46 (UnityEngine.Object)+E4]");
					bool flag13 = (nint)0 == 0;
					obj25 = 0;
					vector = (Vector3)0;
					if (!flag13)
					{
						bool heldNow = ((GillaDoor)obj41).HeldNow;
						bool flag14 = !heldNow;
						object obj43 = !flag14;
						obj25 = 0;
						vector = (Vector3)0;
						if (obj43 == null)
						{
							Collider looseBox = ((GillaDoor)obj41).LooseBox;
							object obj44 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X0_v56+E4]");
							obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X0_v56+E4]");
							bool flag15 = (nint)0 == 0;
							object obj45 = !flag15;
							if (obj45 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag16 = looseBox == null;
							bool flag17 = !flag16;
							object obj46 = !flag17;
							obj25 = 0;
							vector = (Vector3)0;
							if (obj46 == null)
							{
								flag3 = (object)looseBox == null;
								obj17 = (object)(&collider);
								collider = collider2;
								collider3 = looseBox;
								obj25 = 0;
								num3 = unchecked((nint)null);
								if (flag3)
								{
									goto IL_084d;
								}
								Vector3 vector2 = looseBox.ClosestPoint((Vector3)0);
								object obj47 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v63+E4]");
								obj6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v63+E4]");
								bool flag18 = (nint)0 == 0;
								object obj48 = !flag18;
								if (obj48 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								float num10 = num5 - num5;
								object obj49 = obj16 - obj16;
								obj13 = obj14 - obj14;
								float num11 = num10 * num10;
								object obj50 = obj49 * obj49;
								float num12 = num11 + (float)obj50;
								obj15 = obj13 * obj13;
								num4 = (float)obj15 + num12;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								float num2 = num5 - num6;
								bool flag6 = num5 < num6;
								bool flag7 = num2 == 0f;
								obj25 = 0;
								vector = (Vector3)0;
								if (flag6)
								{
									bool flag19 = (object)collider2 == null;
									flag3 = !flag19;
									obj21 = obj41;
									collider3 = collider2;
									obj25 = 0;
									num6 = num5;
									if (flag3)
									{
										continue;
									}
									obj17 = (object)(&collider);
									obj14 = obj13;
									obj16 = obj15;
									obj25 = 0;
									vector = (Vector3)0;
									goto IL_0ca0;
								}
							}
						}
					}
				}
				bool flag20 = (object)collider2 == null;
				flag3 = !flag20;
				collider3 = collider2;
				if (flag3)
				{
					continue;
				}
				goto IL_0816;
				IL_0816:
				obj17 = (object)(&collider);
				obj14 = obj13;
				obj16 = obj15;
				goto IL_0ca0;
				IL_099e:
				OutOfMemoryException ex4 = new OutOfMemoryException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
			}
			goto IL_0837;
		}
		goto IL_0879;
		IL_0138:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj25 = 0;
		goto IL_0a81;
		IL_0879:
		vector = (Vector3)num3;
		goto IL_0ca0;
		IL_084d:
		NullReferenceException ex5 = new NullReferenceException();
		obj14 = obj13;
		obj16 = obj15;
		goto IL_086b;
		IL_0837:
		NullReferenceException ex6 = new NullReferenceException();
		num3 = (nint)vector;
		goto IL_084d;
	}

	private void SlabInHand()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03e6: Expected Obj, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_016a: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_030d: Expected Obj, but got I4
		//IL_02ff: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I4
		//IL_0374: Expected Obj, but got I4
		//IL_0366: Expected Obj, but got I4
		//IL_0390: Expected Obj, but got I4
		//IL_0382: Expected Obj, but got I4
		//IL_03ac: Expected Obj, but got I4
		//IL_0444: Expected VT, but got I4
		//IL_039e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 != null;
		bool flag3 = !flag2;
		bool flag4 = false;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			bool heldNow = ((GillaDoor)obj3).HeldNow;
			bool flag5 = !heldNow;
			flag4 = false;
			if (!flag5)
			{
				Transform loose = ((GillaDoor)obj3).Loose;
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v10+E4]");
				bool flag6 = (nint)0 == 0;
				object obj7 = !flag6;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = loose == null;
				bool flag8 = !flag7;
				flag4 = false;
				if (flag8)
				{
					bool flag9 = !slabRight;
					object obj8 = !flag9;
					object obj9 = ~obj8;
					if (obj9 == null)
					{
						object obj10 = 477 + 1;
					}
					else
					{
						object obj10 = 477;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v306 @ X9_v8]");
					if ((nint)0 != 0)
					{
						Squashing(slabDoor, inHand: true);
						flag4 = true;
						obj5 = slabDoor;
					}
					else
					{
						if (!slabRight)
						{
							object obj11 = 540;
						}
						else
						{
							object obj11 = 552;
						}
						if (!slabRight)
						{
							object obj12 = 536;
						}
						else
						{
							object obj12 = 548;
						}
						if (!slabRight)
						{
							object obj13 = 532;
						}
						else
						{
							object obj13 = 544;
						}
						LetGoSlab((Vector3)0);
						flag4 = false;
						obj5 = null;
					}
					goto IL_0135;
				}
			}
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5 = null;
		}
		goto IL_0135;
		IL_0135:
		object obj14 = obj;
		object obj15 = this + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v9+E4]");
		bool flag10 = (nint)0 == 0;
		object obj16 = !flag10;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)obj15 != null))
		{
			return;
		}
		float time = Time.time;
		bool flag11 = time > slabThrownTill;
		object obj17 = 0;
		if (!flag11)
		{
			Transform loose2 = ((GillaDoor)obj15).Loose;
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v8+E4]");
			bool flag12 = (nint)0 == 0;
			object obj19 = !flag12;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = loose2 == null;
			bool flag14 = !flag13;
			object obj20 = !flag14;
			obj17 = 0;
			if (obj20 == null)
			{
				bool heldNow2 = ((GillaDoor)obj15).HeldNow;
				bool flag15 = !heldNow2;
				obj17 = 0;
				if (flag15)
				{
					Squashing(slabThrown, inHand: false);
					return;
				}
			}
		}
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private unsafe void LetGoSlab(Vector3 velocity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_03d9: Expected Obj, but got I4
		//IL_040d: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_05c5: Expected Obj, but got I
		//IL_05ef: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_04c9: Expected Obj, but got I4
		//IL_0615: Expected Obj, but got I
		//IL_063f: Expected Obj, but got I4
		//IL_01fa: Expected VT, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_0588: Expected VT, but got I4
		//IL_0261: Expected Obj, but got I
		//IL_027d: Expected VT, but got I4
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_029b: Expected Obj, but got I
		//IL_0501: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I
		//IL_02e1: Expected VT, but got I4
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_031e: Expected VT, but got I4
		//IL_0539: Expected VT, but got I4
		//IL_0539: Expected VT, but got Ref
		//IL_0569: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = this + 48;
		UnityEngine.Object obj3 = (UnityEngine.Object)obj2;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj2 == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			return;
		}
		Transform loose = ((GillaDoor)obj2).Loose;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = loose == null;
		bool flag6 = !flag5;
		object obj9 = !flag6;
		if (obj9 != null)
		{
			return;
		}
		Transform loose2 = ((GillaDoor)obj2).Loose;
		float num2 = default;
		float num = num2 * num2;
		object obj11 = default;
		object obj10 = obj11 * obj11;
		float num3 = num + (float)obj10;
		float num5 = default;
		float num4 = num5 * num5;
		float num6 = num4 + num3;
		float num7 = maxDoorThrow * maxDoorThrow;
		bool flag7 = !(num6 > num7);
		float num8 = num2;
		float num9 = default;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj12 = 0;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v76+E4]");
			bool flag8 = (nint)0 == 0;
			object obj14 = !flag8;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			num4 = num2 / num7;
			num9 = (float)obj11 / num7;
			num8 = num4 * maxDoorThrow;
			num7 = num5 / num7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v21+E4]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v25+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj15;
		}
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v25+A0]");
		object obj21 = 0;
		UnityEngine.Object obj22 = (UnityEngine.Object)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v14+E4]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = (UnityEngine.Object)obj21 != null;
		bool flag13 = !flag12;
		Quaternion rot = (Quaternion)0;
		Vector3 vector = default;
		object obj32 = default;
		float num10;
		object obj31;
		float num11;
		float num12;
		float num13;
		if (!flag13)
		{
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v43+E4]");
			bool flag14 = (nint)0 == 0;
			object obj25 = !flag14;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X22_v7 (UnityEngine.Object)+40]");
			bool flag15 = (UnityEngine.Object)0 != null;
			bool flag16 = !flag15;
			rot = (Quaternion)0;
			if (!flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X22_v7 (UnityEngine.Object)+40]");
				object obj26 = 0;
				object obj27 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v48+E4]");
				bool flag17 = (nint)0 == 0;
				object obj28 = !flag17;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X23_v8+30]");
				bool flag18 = (UnityEngine.Object)0;
				bool flag19 = !flag18;
				rot = (Quaternion)0;
				if (!flag19)
				{
					ArgumentNullException ex = new ArgumentNullException();
					object obj29 = ex & 1;
					bool flag20 = obj29 == null;
					rot = (Quaternion)0;
					if (!flag20)
					{
						Vector3 position = loose2.position;
						Quaternion rotation = loose2.rotation;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+98]");
						object obj30 = default;
						Vector3 spin = default;
						RpcInfo info = default;
						((NetworkApe)obj21).RPC_LetGoDoor((byte)0, (Vector3)(&obj30), (Quaternion)0, vector, spin, info);
						num10 = num8;
						obj31 = obj32;
						num11 = num9;
						num12 = num4;
						num13 = num7;
						rot = (Quaternion)(&obj30);
						goto IL_0374;
					}
				}
			}
		}
		Vector3 position2 = loose2.position;
		Quaternion rotation2 = loose2.rotation;
		Vector3 velocity2 = default;
		((GillaDoor)obj2).LetGo((Vector3)0, rot, velocity2, vector);
		num10 = num8;
		obj31 = obj32;
		num11 = num9;
		num12 = num4;
		num13 = num7;
		goto IL_0374;
		IL_0374:
		object obj33 = this + 128;
		obj33 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float time = Time.time;
		float num14 = time + 3f;
	}

	private unsafe void Squashing(GillaDoor d, bool inHand)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_15c3: Expected Obj, but got Ref
		//IL_15e5: Expected F4, but got I4
		//IL_15ee: Expected F4, but got I4
		//IL_15f7: Expected F4, but got I4
		//IL_1600: Expected F4, but got I4
		//IL_1609: Expected F8, but got I4
		//IL_160f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1625: Expected F4, but got I4
		//IL_162e: Expected F4, but got I4
		//IL_1637: Expected F4, but got I4
		//IL_1640: Expected F4, but got I4
		//IL_1649: Expected F4, but got I4
		//IL_1652: Expected VT, but got I4
		//IL_165f: Expected Obj, but got Ref
		//IL_1668: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I
		//IL_0038: Expected Obj, but got Ref
		//IL_007f: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0168: Expected F4, but got I
		//IL_018a: Expected F4, but got I4
		//IL_0193: Expected F4, but got I4
		//IL_019c: Expected F4, but got I4
		//IL_01a5: Expected F4, but got I4
		//IL_01ae: Expected F8, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected F4, but got I4
		//IL_01d3: Expected F4, but got I4
		//IL_01dc: Expected F4, but got I4
		//IL_01e5: Expected F4, but got I4
		//IL_0203: Expected Obj, but got Ref
		//IL_020c: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I4
		//IL_16f6: Expected Obj, but got I
		//IL_170e: Expected Obj, but got I
		//IL_171e: Expected F4, but got I
		//IL_172e: Expected F4, but got I
		//IL_173e: Expected F4, but got I
		//IL_1746: Unknown result type (might be due to invalid IL or missing references)
		//IL_174e: Expected VT, but got Unknown
		//IL_1685: Expected Obj, but got Ref
		//IL_16b9: Expected Obj, but got I4
		//IL_16d3: Expected Obj, but got I4
		//IL_02e0: Expected Obj, but got Ref
		//IL_02f0: Expected Obj, but got I
		//IL_02f8: Expected I4, but got Obj
		//IL_0310: Expected Obj, but got I4
		//IL_0327: Expected I4, but got Obj
		//IL_0293: Expected F4, but got I4
		//IL_029c: Expected F4, but got I4
		//IL_02a5: Expected F4, but got I4
		//IL_02b5: Expected F4, but got I
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got I
		//IL_03b8: Expected Obj, but got I4
		//IL_176c: Expected Obj, but got I
		//IL_178d: Expected F4, but got I4
		//IL_1796: Expected F8, but got I4
		//IL_179c: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d1: Expected F4, but got VT
		//IL_17e9: Expected Obj, but got Ref
		//IL_17f2: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got I
		//IL_0413: Expected Obj, but got I
		//IL_0423: Expected Obj, but got I
		//IL_042d: Expected F8, but got I4
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected F4, but got Unknown
		//IL_044d: Expected Obj, but got Ref
		//IL_0b86: Expected F4, but got I4
		//IL_0b98: Expected Obj, but got I4
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Expected F4, but got I4
		//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Expected Obj, but got I4
		//IL_0be4: Expected Obj, but got I4
		//IL_195a: Expected Obj, but got I
		//IL_1962: Unknown result type (might be due to invalid IL or missing references)
		//IL_196b: Expected Ref, but got Unknown
		//IL_1985: Expected Obj, but got I4
		//IL_1995: Expected F4, but got VT
		//IL_047c: Expected Obj, but got I4
		//IL_14f2: Expected VT, but got F4
		//IL_04a2: Expected Obj, but got F4
		//IL_0bf2: Invalid comparison between F4 and I4
		//IL_0c03: Expected Obj, but got I4
		//IL_0c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected Obj, but got Unknown
		//IL_04cc: Invalid comparison between F4 and I4
		//IL_04dc: Expected F4, but got I4
		//IL_04e6: Expected Obj, but got I4
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected F4, but got I4
		//IL_0520: Expected F4, but got VT
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected Obj, but got I
		//IL_0ca0: Expected Obj, but got I4
		//IL_0552: Expected F4, but got I4
		//IL_055c: Expected Obj, but got I4
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected F4, but got I4
		//IL_0596: Expected F4, but got VT
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1548: Expected F4, but got I4
		//IL_1842: Expected Obj, but got I
		//IL_1861: Expected F4, but got VT
		//IL_0c58: Expected Obj, but got I4
		//IL_15af: Expected Obj, but got I4
		//IL_05bc: Expected Obj, but got F4
		//IL_0cd5: Expected Obj, but got I
		//IL_0d09: Expected F4, but got VT
		//IL_075c: Expected Obj, but got F4
		//IL_0771: Expected F4, but got I4
		//IL_0779: Expected I, but got Obj
		//IL_0783: Expected Obj, but got I4
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected F4, but got I4
		//IL_07bd: Expected F4, but got VT
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected Obj, but got F4
		//IL_07eb: Expected Obj, but got I4
		//IL_066c: Expected Obj, but got I4
		//IL_069c: Invalid comparison between F4 and I4
		//IL_06b4: Expected Obj, but got F8
		//IL_06c1: Expected Obj, but got F4
		//IL_072d: Expected I, but got Obj
		//IL_0802: Expected Obj, but got F4
		//IL_081d: Expected VT, but got Ref
		//IL_144a: Expected Obj, but got I4
		//IL_0840: Expected Obj, but got I4
		//IL_0860: Expected Obj, but got Ref
		//IL_0d4a: Expected Obj, but got I8
		//IL_0d5a: Expected Obj, but got I
		//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Expected Obj, but got Unknown
		//IL_0d71: Expected Obj, but got I4
		//IL_0984: Expected F4, but got I4
		//IL_099c: Expected I, but got Obj
		//IL_09a6: Expected Obj, but got I4
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected F4, but got I4
		//IL_09d8: Expected F4, but got VT
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected Obj, but got F4
		//IL_09fe: Expected Obj, but got I4
		//IL_1908: Expected Obj, but got I4
		//IL_1919: Expected F4, but got VT
		//IL_0877: Expected Obj, but got F4
		//IL_08ba: Expected VT, but got Ref
		//IL_0a1b: Expected Obj, but got F4
		//IL_0a3a: Expected VT, but got Obj
		//IL_0a3a: Expected VT, but got I4
		//IL_0a3a: Expected VT, but got Ref
		//IL_0a3a: Expected Obj, but got F4
		//IL_08e2: Expected Obj, but got Ref
		//IL_093a: Expected I, but got Obj
		//IL_0d8e: Expected Obj, but got I
		//IL_0db0: Expected Obj, but got I4
		//IL_0a69: Expected Obj, but got I4
		//IL_0df5: Expected Obj, but got I4
		//IL_0aa5: Expected F4, but got I
		//IL_0ac4: Expected F4, but got I
		//IL_1410: Expected Obj, but got I4
		//IL_1419: Unknown result type (might be due to invalid IL or missing references)
		//IL_141e: Expected Obj, but got Unknown
		//IL_0ad3: Expected Obj, but got I4
		//IL_0adc: Expected F8, but got I4
		//IL_0b44: Expected I, but got Obj
		//IL_0b54: Expected F4, but got I
		//IL_0b73: Expected Obj, but got F4
		//IL_0b77: Expected Obj, but got I4
		//IL_0e31: Expected F4, but got VT
		//IL_0ed5: Expected Obj, but got I
		//IL_0ef7: Expected Obj, but got I4
		//IL_0f3c: Expected Obj, but got I4
		//IL_0f70: Expected Obj, but got I
		//IL_0f92: Expected Obj, but got I4
		//IL_0fd7: Expected Obj, but got I4
		//IL_101b: Expected F4, but got VT
		//IL_1048: Expected Obj, but got I
		//IL_105e: Expected VT, but got Ref
		//IL_1081: Expected Obj, but got I4
		//IL_1089: Expected VT, but got Ref
		//IL_1091: Expected Obj, but got Ref
		//IL_112c: Expected F4, but got VT
		//IL_1134: Expected I4, but got VT
		//IL_10be: Expected VT, but got Ref
		//IL_115b: Expected Obj, but got I
		//IL_1189: Expected Obj, but got I4
		//IL_10de: Expected VT, but got Ref
		//IL_10e6: Expected Obj, but got Ref
		//IL_10f6: Expected Obj, but got Ref
		//IL_11b5: Expected VT, but got I4
		//IL_11b5: Expected VT, but got I4
		//IL_11d5: Expected F8, but got I4
		//IL_1207: Expected F4, but got VT
		//IL_120f: Expected I4, but got VT
		//IL_1233: Expected Obj, but got I
		//IL_1887: Expected Obj, but got I
		//IL_1897: Expected Obj, but got I
		//IL_18af: Expected F4, but got I
		//IL_18bf: Expected F4, but got I
		//IL_18e1: Expected Obj, but got I4
		//IL_1349: Expected VT, but got I4
		//IL_1373: Expected Obj, but got I4
		//IL_13af: Expected F4, but got I
		//IL_13ce: Expected F4, but got I
		//IL_13e7: Expected F4, but got I
		//IL_13fc: Expected I4, but got VT
		Vector3 way = default;
		UnityEngine.Object obj = (UnityEngine.Object)(&way);
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref way, 88));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag = (object)d == null;
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		double num5 = 0.0;
		Enumerator<, > val = (Enumerator<, >)0;
		float num7 = default;
		float num6 = num7;
		float num8 = 0f;
		float num9 = 0f;
		float num10 = 0f;
		float num11 = 0f;
		float num12 = 0f;
		bool flag2 = default;
		way = (Vector3)flag2;
		MonsterPlayer monsterPlayer = this;
		UnityEngine.Object obj3 = (UnityEngine.Object)(&way);
		UnityEngine.Object obj4 = (UnityEngine.Object)109895680;
		object obj5;
		Matrix4x4 m = default;
		float num14;
		float num15 = default;
		float num16 = default;
		float num13;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj5 = 0;
			Collider looseBox = d.LooseBox;
			object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref way, 80));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform loose = d.Loose;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v42+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = looseBox == null;
			bool flag5 = !flag4;
			object obj9 = !flag5;
			if (obj9 != null)
			{
				return;
			}
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X0_v103+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = loose == null;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			if (obj12 != null)
			{
				return;
			}
			float deltaTime = Time.deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			num13 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			bool flag9 = (object)loose == null;
			num = 0f;
			num2 = 0f;
			num3 = 0f;
			num4 = 0f;
			num5 = 0.0;
			val = (Enumerator<, >)0;
			num6 = num7;
			num8 = 0f;
			num9 = 0f;
			num10 = 0f;
			num11 = 0f;
			num12 = deltaTime;
			flag2 = false;
			monsterPlayer = null;
			obj3 = (UnityEngine.Object)(&way);
			obj4 = (UnityEngine.Object)109895680;
			if (!flag9)
			{
				Matrix4x4 localToWorldMatrix = loose.localToWorldMatrix;
				object obj13 = 0 & 1;
				bool flag10;
				if (obj13 != null && ~(slabWasSet ? 1u : 0u) == 0)
				{
					Matrix4x4 matrix4x = Matrix4x4.Internal_Inverse(ref m);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DF8E5C");
					num = 0f;
					num2 = 0f;
					num3 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+4C]");
					num14 = 0f;
					Enumerator<, > val2 = (Enumerator<, >)slabWas;
					flag10 = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8758]");
					object obj14 = 0;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ X8_v70+A0]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X8_v71+50]");
					num = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X8_v71+70]");
					num2 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X8_v71+60]");
					num3 = 0f;
					num14 = num7;
					Enumerator<, > val2 = default;
					m = (Matrix4x4)val2;
					flag10 = false;
				}
				object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref way, 72));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X8_v71+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj18 = (flag2 ? 1 : 0) & 1;
				bool flag11 = obj18 == null;
				object obj19 = !flag11;
				MonsterPlayer monsterPlayer2 = null;
				if (obj19 == null)
				{
					monsterPlayer2 = (MonsterPlayer)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref way, 72));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F70]");
					object obj20 = 0;
					flag10 = (byte)(int)obj20 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
					object obj21 = (flag2 ? 1 : 0) & 1;
					bool flag12 = obj21 == null;
					flag2 = (byte)(int)obj20 != 0;
					monsterPlayer = monsterPlayer2;
					if (flag12)
					{
						goto IL_037e;
					}
				}
				bool flag13 = (byte)(~(slabWasSet ? 1u : 0u)) != 0;
				flag2 = flag10;
				monsterPlayer = monsterPlayer2;
				num8 = num15;
				num9 = num16;
				num10 = num7;
				if (!flag13)
				{
					goto IL_037e;
				}
				goto IL_1467;
			}
		}
		goto IL_1490;
		IL_14ba:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_14c8;
		IL_149e:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_14ac;
		IL_14d6:
		throw new NullReferenceException();
		IL_143c:
		object obj22 = (flag2 ? 1 : 0) & 1;
		if (obj22 != null)
		{
			goto IL_1467;
		}
		return;
		IL_037e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ X0_v115+E4]");
		bool flag14 = (nint)0 == 0;
		object obj25 = !flag14;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj23;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ X0_v115+A0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v51+8]");
		bool flag15 = (nint)0 == 0;
		num4 = 0f;
		num5 = 0.0;
		val = (Enumerator<, >)0;
		num6 = num14;
		num8 = num15;
		num9 = num16;
		float num17 = num2;
		num10 = num7;
		num11 = (float)m;
		num13 = num;
		num12 = num3;
		obj3 = (UnityEngine.Object)(&way);
		obj4 = (UnityEngine.Object)109895680;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v51+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			obj4 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7168]");
			object obj28 = 0;
			num5 = 0.0;
			float num18 = num2;
			num13 = num;
			Enumerator<, > val3 = default;
			num12 = (float)val3;
			obj3 = (UnityEngine.Object)(&way);
			bool flag22 = default;
			object obj33 = default;
			object obj35 = default;
			object obj37 = default;
			bool flag24 = default;
			bool flag26 = default;
			float num20 = default;
			object obj39 = default;
			object obj41 = default;
			double num29 = default;
			object obj31;
			Enumerator<, > val2;
			nint num23 = default;
			while (true)
			{
				monsterPlayer = (MonsterPlayer)obj4;
				if (!val.MoveNext())
				{
					break;
				}
				object obj29 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1694 @ X0_v121+E4]");
				bool flag16 = (nint)0 == 0;
				object obj30 = !flag16;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!CanTouch((NetworkApe)num14))
				{
					continue;
				}
				bool flag17 = num14 == 0f;
				num4 = 0f;
				obj31 = 0;
				val = val3;
				num6 = 0f;
				num8 = num15;
				num9 = num16;
				num17 = num18;
				num10 = num7;
				num11 = (float)m;
				val2 = (Enumerator<, >)(ref val);
				if (flag17)
				{
					goto IL_149e;
				}
				bool flag18 = squashed == null;
				num4 = 0f;
				obj31 = 0;
				val = val3;
				num6 = 0f;
				num8 = num15;
				num9 = num16;
				num17 = num18;
				num10 = num7;
				num11 = (float)m;
				val2 = (Enumerator<, >)(ref val);
				if (flag18)
				{
					goto IL_14ac;
				}
				bool flag19 = squashed.TryGetValue(((NetworkApe)num14).owner, out var value);
				bool flag20 = !flag19;
				bool flag21 = flag22;
				object obj32 = obj33;
				object obj34 = obj35;
				object obj36 = obj37;
				bool flag23 = flag24;
				bool flag25 = flag26;
				float num19 = num20;
				object obj38 = obj39;
				float num21 = num13;
				float num22 = num12;
				if (!flag20)
				{
					float time = Time.time;
					num22 = time - value;
					bool flag27 = (double)num22 < 3.0;
					obj38 = !flag27;
					num19 = num22 - 3f;
					flag25 = (double)num22 < 3.0;
					flag23 = num19 == 0f;
					obj36 = (double)num22 ^ 3.0;
					obj34 = num22 ^ num19;
					obj32 = obj36 & obj34;
					flag21 = (nint)obj32 < 0;
					num21 = value;
					flag22 = flag21;
					obj33 = obj32;
					obj35 = obj34;
					obj37 = obj36;
					flag24 = flag23;
					flag26 = flag25;
					num20 = num19;
					obj39 = obj38;
					num23 = (nint)obj28;
					num13 = value;
					num12 = num22;
					flag2 = (byte)(&value) != 0;
					if (flag25)
					{
						continue;
					}
				}
				bool flag28 = (object)((NetworkApe)num14).head == null;
				num4 = 0f;
				num23 = (nint)obj28;
				obj31 = 0;
				val = val3;
				num6 = 0f;
				num8 = num15;
				num9 = num16;
				num17 = num18;
				num10 = num7;
				num11 = (float)m;
				val2 = (Enumerator<, >)(ref val);
				num13 = num21;
				num12 = num22;
				flag2 = (byte)(&value) != 0;
				monsterPlayer = (MonsterPlayer)((NetworkApe)num14).owner;
				if (flag28)
				{
					goto IL_14c8;
				}
				Vector3 position = ((NetworkApe)num14).head.position;
				bool flag29 = _003CSquashing_003Eg__Meets_007C20_1((Vector3)(&num5), out way, ref *(_003C_003Ec__DisplayClass20_0*)obj28);
				bool flag30 = !flag29;
				object obj40 = !flag30;
				num17 = num18;
				float num24 = num21;
				bool flag31 = (byte)(&way) != 0;
				monsterPlayer = (MonsterPlayer)(&num5);
				float num25;
				float num26;
				if (obj40 == null)
				{
					Vector3 middleFromEyes = ((NetworkApe)num14).MiddleFromEyes;
					num12 = num22 + num22;
					num24 = num21 + num21;
					num17 = num18 + num18;
					bool flag32 = _003CSquashing_003Eg__Meets_007C20_1((Vector3)(&num5), out way, ref *(_003C_003Ec__DisplayClass20_0*)obj28);
					bool flag33 = !flag32;
					flag31 = (byte)(&way) != 0;
					monsterPlayer = (MonsterPlayer)(&num5);
					num25 = num21;
					num26 = num22;
					flag22 = flag21;
					obj33 = obj32;
					obj35 = obj34;
					obj37 = obj36;
					flag24 = flag23;
					flag26 = flag25;
					num20 = num19;
					obj39 = obj38;
					num23 = (nint)obj28;
					num18 = num17;
					num13 = num24;
					flag2 = (byte)(&way) != 0;
					if (flag33)
					{
						continue;
					}
				}
				num12 = Time.time;
				bool flag34 = squashed == null;
				num4 = 0f;
				num25 = num21;
				num26 = num22;
				num23 = (nint)obj28;
				obj31 = 0;
				val = val3;
				num6 = 0f;
				num8 = num15;
				num9 = num16;
				num10 = num7;
				num11 = (float)m;
				val2 = (Enumerator<, >)(ref val);
				num13 = num24;
				flag2 = flag31;
				obj3 = (UnityEngine.Object)((NetworkApe)num14).owner;
				if (!flag34)
				{
					squashed.set_Item(((NetworkApe)num14).owner, num12);
					((NetworkApe)num14).RPC_Squished((Vector3)(&obj41), (Vector3)0, (RpcInfo)obj28);
					object obj42 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1813 @ X0_v136+E4]");
					bool flag35 = (nint)0 == 0;
					object obj43 = !flag35;
					if (obj43 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					Buzz((XRNode)4, 1f, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					Buzz((XRNode)5, 1f, 0f);
					obj41 = 0;
					double num27 = 0.0;
					double num28 = num29;
					double num30 = num5;
					num25 = num21;
					num26 = num22;
					flag22 = flag21;
					obj33 = obj32;
					obj35 = obj34;
					obj37 = obj36;
					flag24 = flag23;
					flag26 = flag25;
					num20 = num19;
					obj39 = obj38;
					num23 = (nint)obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					num13 = 0f;
					num12 = 1f;
					flag2 = false;
					obj3 = (UnityEngine.Object)((NetworkApe)num14).owner;
					continue;
				}
				goto IL_14d6;
			}
			num4 = 0f;
			ref _003C_003Ec__DisplayClass20_0 reference = ref *(_003C_003Ec__DisplayClass20_0*)num23;
			obj31 = 0;
			val = val3;
			num6 = 0f;
			num8 = num15;
			num9 = num16;
			num17 = num18;
			num10 = num7;
			val2 = (Enumerator<, >)(ref val);
			object obj44 = 14;
			object obj45 = 0;
			object obj49 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
				object obj46 = 0;
				monsterPlayer = (MonsterPlayer)obj46;
				((Enumerator<, >*)val2)->Dispose();
				bool flag36 = obj45 == null;
				object obj47 = !flag36;
				num23 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
				num11 = (float)m;
				if (obj47 == null)
				{
					bool flag37 = num6 == 0f;
					object obj48 = !flag37;
					num23 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					OutOfMemoryException ex3 = (OutOfMemoryException)val2;
					if (obj48 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex3 = new OutOfMemoryException();
					m = (Matrix4x4)num11;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)monsterPlayer == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					num6 = 1f;
					obj45 = obj31;
				}
				else
				{
					if ((nint)monsterPlayer != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj45 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj31 = obj49;
				}
				reference = ref *(_003C_003Ec__DisplayClass20_0*)num23;
				obj44 = 0;
			}
			if ((nint)obj44 != 14)
			{
				bool flag38 = obj44 == null;
				object obj50 = !flag38;
				if (obj50 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
			object obj51 = 0;
			object obj52 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1585 @ X0_v7+E4]");
			bool flag39 = (nint)0 == 0;
			object obj53 = !flag39;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj52 = obj51;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1585 @ X0_v7+A0]");
			object obj54 = 0;
			bool flag40 = obj54 == null;
			num23 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			num11 = (float)m;
			if (!flag40)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB720]");
				object obj55 = 0;
				monsterPlayer = (MonsterPlayer)obj55;
				System.__Canon[] array = ((List<System.__Canon>)obj54).ToArray();
				bool flag41 = array == null;
				num23 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
				num11 = (float)m;
				if (!flag41)
				{
					if (array.Length < 1)
					{
						goto IL_143c;
					}
					object obj56 = array.Length & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj57 = 0;
					object obj58 = array + 32;
					obj28 = 0;
					float num31 = default;
					while (true)
					{
						bool flag42 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj56);
						object obj59 = !flag42;
						num23 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						num11 = (float)m;
						if (obj59 != null)
						{
							break;
						}
						object obj60 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X29_v1+v239 @ X27_v1*8]");
						obj3 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1709 @ X0_v12+E4]");
						bool flag43 = (nint)0 == 0;
						object obj61 = !flag43;
						if (obj61 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag44 = obj3 == null;
						bool flag45 = !flag44;
						object obj62 = !flag45;
						flag2 = false;
						monsterPlayer = null;
						if (obj62 == null)
						{
							bool flag46 = (object)obj3 == null;
							num23 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
							num11 = (float)m;
							flag2 = false;
							monsterPlayer = null;
							if (flag46)
							{
								goto IL_1490;
							}
							bool alive = ((GillaDummy)obj3).Alive;
							bool flag47 = !alive;
							flag2 = false;
							monsterPlayer = null;
							if (!flag47)
							{
								bool mine = ((GillaDummy)obj3).Mine;
								bool flag48 = !mine;
								flag2 = false;
								monsterPlayer = null;
								if (!flag48)
								{
									object obj63 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X22_v4 (UnityEngine.Object)+68]");
									obj4 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1778 @ X0_v21+E4]");
									bool flag49 = (nint)0 == 0;
									object obj64 = !flag49;
									if (obj64 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag50 = obj4 == null;
									bool flag51 = !flag50;
									object obj65 = !flag51;
									flag2 = false;
									monsterPlayer = null;
									if (obj65 == null)
									{
										object obj66 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X22_v4 (UnityEngine.Object)+80]");
										obj4 = (UnityEngine.Object)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1796 @ X0_v25+E4]");
										bool flag52 = (nint)0 == 0;
										object obj67 = !flag52;
										if (obj67 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag53 = obj4 == null;
										bool flag54 = !flag53;
										object obj68 = !flag54;
										flag2 = false;
										monsterPlayer = null;
										if (obj68 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X22_v4 (UnityEngine.Object)+68]");
											bool flag55 = (nint)0 == 0;
											num23 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
											num11 = (float)m;
											flag2 = false;
											monsterPlayer = null;
											if (!flag55)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X22_v4 (UnityEngine.Object)+68]");
												Vector3 position2 = ((Transform)0).position;
												bool flag56 = _003CSquashing_003Eg__Meets_007C20_1((Vector3)(&num4), out way, ref reference);
												bool flag57 = !flag56;
												object obj69 = !flag57;
												Vector3 vector = (Vector3)(&way);
												MonsterPlayer monsterPlayer3 = (MonsterPlayer)(&num4);
												if (obj69 == null)
												{
													Vector3 middle = ((GillaDummy)obj3).Middle;
													bool flag58 = _003CSquashing_003Eg__Meets_007C20_1((Vector3)(&num4), out way, ref reference);
													bool flag59 = !flag58;
													vector = (Vector3)(&way);
													monsterPlayer3 = (MonsterPlayer)(&num4);
													flag2 = (byte)(&way) != 0;
													monsterPlayer = (MonsterPlayer)(&num4);
													if (flag59)
													{
														goto IL_1406;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X22_v4 (UnityEngine.Object)+68]");
												bool flag60 = (nint)0 == 0;
												num23 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
												num11 = (float)m;
												flag2 = (byte)(int)vector != 0;
												monsterPlayer = monsterPlayer3;
												if (!flag60)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X22_v4 (UnityEngine.Object)+68]");
													Vector3 position3 = ((Transform)0).position;
													object obj70 = obj23;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ X0_v36+E4]");
													bool flag61 = (nint)0 == 0;
													object obj71 = !flag61;
													if (obj71 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													NetworkApe.Crushed((Vector3)0, (Vector3)0);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X22_v4 (UnityEngine.Object)+68]");
													bool flag62 = (nint)0 == 0;
													double num27 = 0.0;
													double num28 = num31;
													double num30 = num4;
													float num25 = num31;
													float num26 = num4;
													num23 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
													num11 = (float)m;
													flag2 = (byte)(int)vector != 0;
													monsterPlayer = null;
													if (!flag62)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X22_v4 (UnityEngine.Object)+68]");
														Vector3 position4 = ((Transform)0).position;
														object obj72 = obj57;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
														object obj73 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1856 @ X8_v24+A0]");
														object obj74 = 0;
														object obj75 = obj73;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1859 @ X8_v25+1C]");
														num26 = 0f;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1859 @ X8_v25+20]");
														num25 = 0f;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1860 @ X0_v42+E4]");
														bool flag63 = (nint)0 == 0;
														object obj76 = !flag63;
														if (obj76 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1859 @ X8_v25+18]");
														float num32 = 0f;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
														float num33 = num32 * 0f;
														float num34 = num26;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
														float num35 = num34 * 0f;
														float num36 = num25;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
														float num37 = num36 * 0f;
														double num38 = (double)num4 * 2.5;
														double num39 = (double)num31 * 2.5;
														double num40 = 0.0 * 2.5;
														double num41 = (double)num12 + (double)num33;
														float num42 = num13 + num35;
														float num43 = num17 + num37;
														double num44 = num38;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1859 @ X8_v25+18]");
														num30 = num44 + 0.0;
														num28 = num39 + (double)num26;
														num27 = num40 + (double)num25;
														GillaBlast.CrushDummy((GillaDummy)obj3, (Vector3)0, vector);
														object obj77 = obj27;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1877 @ X0_v45+E4]");
														bool flag64 = (nint)0 == 0;
														object obj78 = !flag64;
														if (obj78 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
														Buzz((XRNode)4, 1f, 0f);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
														Buzz((XRNode)5, 1f, 0f);
														num17 = num43;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
														num13 = 0f;
														num12 = 1f;
														flag2 = (byte)(int)vector != 0;
														monsterPlayer = null;
														goto IL_1406;
													}
												}
											}
											goto IL_1490;
										}
									}
								}
							}
						}
						goto IL_1406;
						IL_1406:
						obj56 = array.Length;
						obj28++;
						if ((nint)obj28 < array.Length)
						{
							continue;
						}
						goto IL_143c;
					}
					goto IL_14ba;
				}
			}
		}
		goto IL_1490;
		IL_1467:
		slabWasSet = true;
		slabWas = m;
		return;
		IL_14ac:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_14ba;
		IL_1490:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_149e;
		IL_14c8:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_14d6;
	}

	private unsafe void TellSlabsAtRest(NetworkApe you)
	{
		//IL_0010: Expected Obj, but got I
		//IL_09ca: Expected Obj, but got I4
		//IL_0a02: Expected Obj, but got I4
		//IL_0cc9: Expected Obj, but got I
		//IL_0cd9: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_07e1: Expected Obj, but got I4
		//IL_073c: Expected Obj, but got I4
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Expected Obj, but got Unknown
		//IL_0174: Expected Obj, but got I
		//IL_0184: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_01e5: Expected VT, but got I4
		//IL_01ee: Expected VT, but got I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0c68: Expected Obj, but got I4
		//IL_0c06: Expected Obj, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_087c: Expected Obj, but got I
		//IL_088c: Expected Obj, but got I
		//IL_0776: Expected Obj, but got Ref
		//IL_0784: Expected Obj, but got I4
		//IL_02a5: Expected I, but got Obj
		//IL_0956: Expected Obj, but got I4
		//IL_0917: Expected I, but got Obj
		//IL_0ad9: Expected Obj, but got I
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected Obj, but got Unknown
		//IL_0b08: Expected Obj, but got Ref
		//IL_0b16: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I
		//IL_0caa: Expected Obj, but got I
		//IL_08c7: Expected Obj, but got I
		//IL_0a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected Obj, but got Unknown
		//IL_0349: Expected Obj, but got I
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected Obj, but got Unknown
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected Obj, but got Unknown
		//IL_036f: Expected Obj, but got I
		//IL_0436: Expected I, but got Obj
		//IL_0be0: Expected Obj, but got I4
		//IL_03aa: Expected Obj, but got I
		//IL_049c: Expected I, but got Obj
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected Obj, but got Unknown
		//IL_06c5: Expected Obj, but got I4
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_050f: Expected I, but got Obj
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_053e: Expected I, but got Obj
		//IL_0582: Expected VT, but got I4
		//IL_05f8: Expected VT, but got I4
		//IL_0608: Expected Obj, but got Ref
		//IL_0648: Expected VT, but got I4
		//IL_0648: Expected VT, but got Ref
		//IL_0652: Expected Obj, but got I4
		//IL_0663: Expected Obj, but got I4
		//IL_068c: Expected Obj, but got I4
		//IL_0695: Expected Obj, but got I4
		//IL_069e: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+40]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+40]");
		if ((nint)0 == 0)
		{
			goto IL_0791;
		}
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAF8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v21+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v21+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0120;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v21+98]");
		object obj11 = (nint)0 + (nint)8;
		bool flag4 = default;
		bool flag3 = flag4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X10_v36-8]");
			object obj12 = 0 - obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X10_v36-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj10--;
			obj12 = obj10 - 1;
			bool flag5 = obj12 == null;
			obj9 = obj11 + 16;
			flag4 = (nint)obj10 != 1;
			flag3 = flag4;
			obj11 = obj9;
			if (flag4)
			{
				continue;
			}
			goto IL_0120;
		}
		object obj13 = obj8 + obj11;
		object obj14 = obj13 + 312;
		flag4 = flag3;
		obj9 = obj11;
		goto IL_0a51;
		IL_0741:
		NullReferenceException ex = new NullReferenceException();
		goto IL_074f;
		IL_0765:
		NullReferenceException ex2 = new NullReferenceException();
		object obj16 = default;
		object obj15 = (object)(&obj16);
		OutOfMemoryException ex3 = null;
		object obj17 = 0;
		NetworkApe networkApe2;
		NetworkApe networkApe = networkApe2;
		goto IL_0791;
		IL_0c9a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X0_v19+8]");
		NetworkApe networkApe3 = (NetworkApe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v805 @ X0_v19] (should have been resolved before IL gen)");
		goto IL_0c4e;
		IL_0c4e:
		bool flag6 = ex3 == null;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			bool flag7 = obj17 == null;
			object obj19 = !flag7;
			OutOfMemoryException ex4 = ex3;
			if (obj19 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex4 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		networkApe = networkApe3;
		NullReferenceException ex6 = default;
		NullReferenceException ex5 = ex6;
		goto IL_0c2b;
		IL_074f:
		NullReferenceException ex7 = new NullReferenceException();
		UnityEngine.Object obj20;
		networkApe2 = (NetworkApe)obj20;
		goto IL_0765;
		IL_0908:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		nint num = unchecked((nint)null);
		goto IL_0c9a;
		IL_0c2b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0791:
		NullReferenceException ex8 = new NullReferenceException();
		if ((nint)networkApe == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj17 = 1;
			networkApe3 = networkApe;
		}
		else
		{
			bool flag8 = (nint)networkApe != 1;
			ex5 = ex8;
			if (flag8)
			{
				goto IL_0c2b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj21 = default;
			ex3 = (OutOfMemoryException)obj21;
			networkApe3 = networkApe;
		}
		goto IL_083f;
		IL_072b:
		NullReferenceException ex9 = new NullReferenceException();
		byte b;
		obj20 = (UnityEngine.Object)b;
		goto IL_0741;
		IL_0120:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num = unchecked((nint)null);
		goto IL_0a51;
		IL_0a51:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v33+8]");
		b = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v266 @ X0_v33] (should have been resolved before IL gen)");
		object obj22 = default;
		if (obj22 == null)
		{
			goto IL_072b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB00]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj25 = 0;
		Vector3 vector2 = default;
		Vector3 vector = vector2;
		object obj27 = default;
		object obj26 = obj27;
		object obj29 = default;
		object obj28 = obj29;
		object obj31 = default;
		object obj30 = obj31;
		Quaternion quaternion2 = default;
		Quaternion quaternion = quaternion2;
		object obj33 = default;
		object obj32 = obj33;
		object obj35 = default;
		object obj34 = obj35;
		object obj37 = default;
		object obj36 = obj37;
		Quaternion quaternion4 = default;
		Quaternion quaternion3 = quaternion4;
		Quaternion rot = (Quaternion)0;
		Vector3 at = (Vector3)0;
		nint num2 = num;
		object obj38 = obj22;
		object obj45 = default;
		UnityEngine.Object obj53 = default;
		object obj54 = default;
		RpcInfo info = default;
		object obj55 = default;
		object obj56 = default;
		object obj57 = default;
		while (true)
		{
			object obj39 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v30+12E]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v30+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0296;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v30+98]");
			object obj41 = (nint)0 + (nint)8;
			bool flag9 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X10_v31-8]");
				object obj12 = 0 - obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X10_v31-8]");
				if (0 == (nint)obj23)
				{
					break;
				}
				obj40--;
				obj12 = obj40 - 1;
				bool flag5 = obj12 == null;
				obj9 = obj41 + 16;
				flag4 = (nint)obj40 != 1;
				flag9 = flag4;
				obj41 = obj9;
				if (flag4)
				{
					continue;
				}
				goto IL_0296;
			}
			object obj42 = obj39 + obj41;
			object obj43 = obj42 + 312;
			num = num2;
			flag4 = flag9;
			obj9 = obj41;
			goto IL_0ac9;
			IL_0ac9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X0_v45+8]");
			networkApe3 = (NetworkApe)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v692 @ X0_v45] (should have been resolved before IL gen)");
			object obj44 = obj45 & 1;
			bool flag10 = obj44 == null;
			obj15 = (object)(&obj16);
			ex3 = null;
			obj17 = 0;
			vector2 = vector;
			obj27 = obj26;
			obj29 = obj28;
			obj31 = obj30;
			quaternion2 = quaternion;
			obj33 = obj32;
			obj35 = obj34;
			obj37 = obj36;
			quaternion4 = quaternion3;
			if (flag10)
			{
				break;
			}
			bool flag11 = obj22 == null;
			vector2 = vector;
			obj27 = obj26;
			obj29 = obj28;
			obj31 = obj30;
			quaternion2 = quaternion;
			obj33 = obj32;
			obj35 = obj34;
			obj37 = obj36;
			quaternion4 = quaternion3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X0_v45+8]");
			obj20 = (UnityEngine.Object)0;
			if (flag11)
			{
				goto IL_0741;
			}
			object obj46 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v33+12E]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v33+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0427;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v33+98]");
			object obj48 = (nint)0 + (nint)8;
			bool flag12 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X10_v26-8]");
				object obj12 = 0 - obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X10_v26-8]");
				if (0 == (nint)obj24)
				{
					break;
				}
				obj47--;
				obj12 = obj47 - 1;
				bool flag5 = obj12 == null;
				obj9 = obj48 + 16;
				flag4 = (nint)obj47 != 1;
				flag12 = flag4;
				obj48 = obj9;
				if (flag4)
				{
					continue;
				}
				goto IL_0427;
			}
			object obj49 = obj46 + obj48;
			object obj50 = obj49 + 312;
			flag4 = flag12;
			obj9 = obj48;
			goto IL_0bac;
			IL_0bac:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v863 @ X0_v48] (should have been resolved before IL gen)");
			object obj51 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X0_v51+E4]");
			bool flag13 = (nint)0 == 0;
			object obj52 = !flag13;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag14 = obj53 != null;
			bool flag15 = !flag14;
			num = unchecked((nint)null);
			b = 0;
			if (!flag15)
			{
				bool flag16 = (object)obj53 == null;
				vector2 = vector;
				obj27 = obj26;
				obj29 = obj28;
				obj31 = obj30;
				quaternion2 = quaternion;
				obj33 = obj32;
				obj35 = obj34;
				obj37 = obj36;
				quaternion4 = quaternion3;
				num = unchecked((nint)null);
				obj20 = null;
				if (flag16)
				{
					goto IL_074f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X0_v50 (UnityEngine.Object)+E4]");
				bool flag17 = (nint)0 == 0;
				num = unchecked((nint)null);
				b = 0;
				if (!flag17)
				{
					bool flag18 = ((GillaDoor)obj53).NewlyAtRest(out at, out rot);
					bool flag19 = !flag18;
					quaternion3 = (Quaternion)0;
					num = (nint)(&rot);
					b = (byte)(&at);
					if (!flag19)
					{
						bool flag20 = (object)networkApe == null;
						vector2 = vector;
						obj27 = obj26;
						obj29 = obj28;
						obj31 = obj30;
						quaternion2 = quaternion;
						obj33 = obj32;
						obj35 = obj34;
						obj37 = obj36;
						quaternion4 = (Quaternion)0;
						num = (nint)(&rot);
						networkApe2 = (NetworkApe)(&at);
						if (flag20)
						{
							goto IL_0765;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X0_v50 (UnityEngine.Object)+98]");
						b = 0;
						NetworkApe networkApe4 = networkApe;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X0_v50 (UnityEngine.Object)+98]");
						networkApe4.RPC_PlaceDoor(0, (Vector3)(&obj54), (Quaternion)0, info);
						obj54 = 0;
						vector = at;
						obj26 = 0;
						obj28 = obj55;
						obj30 = obj56;
						quaternion = rot;
						obj32 = obj57;
						obj34 = 0;
						obj36 = 0;
						quaternion3 = (Quaternion)0;
						num = (nint)(&obj54);
					}
				}
			}
			bool flag21 = obj22 == null;
			object obj58 = !flag21;
			vector2 = vector;
			obj27 = obj26;
			obj29 = obj28;
			obj31 = obj30;
			quaternion2 = quaternion;
			obj33 = obj32;
			obj35 = obj34;
			obj37 = obj36;
			quaternion4 = quaternion3;
			num2 = num;
			obj38 = obj22;
			if (obj58 != null)
			{
				continue;
			}
			goto IL_072b;
			IL_0427:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num = unchecked((nint)null);
			goto IL_0bac;
			IL_0296:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num = unchecked((nint)null);
			goto IL_0ac9;
		}
		goto IL_083f;
		IL_083f:
		object obj59 = obj15;
		if (obj15 == null)
		{
			goto IL_0c4e;
		}
		object obj60 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v14+12E]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0908;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v14+98]");
		object obj63 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X10_v10-8]");
			if (0 == (nint)obj61)
			{
				break;
			}
			obj62--;
			obj63 += 16;
			if ((nint)obj62 != 1)
			{
				continue;
			}
			goto IL_0908;
		}
		object obj64 = obj60 + obj63;
		object obj65 = obj64 + 312;
		goto IL_0c9a;
	}

	public static bool InSpawnRoom(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I4
		//IL_002e: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return GillaDynamite.InSpawn((Vector3)0);
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+A0]");
		object obj6 = 0;
		obj6 = this;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v11+A0]");
		object obj10 = (nint)0 + (nint)56;
		obj10 = 0;
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PrepareRips();
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I4
		//IL_0278: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 != this;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v15+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v15+A0]");
			object obj15 = 0;
			obj15 = 0;
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v20+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v20+A0]");
			object obj19 = 0;
			_ = 0;
		}
	}

	public void Become(int monster)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I4
		//IL_026f: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_0351: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v7+8]");
		if ((nint)0 == monster)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		object obj9 = obj7;
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v2+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj11 != null)
		{
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v20+A0]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v22+A9]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 != null)
			{
				return;
			}
		}
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v13+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v15+10]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v15+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v161 @ X8_v16+18] (should have been resolved before IL gen)");
		}
		Turn(monster);
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v17+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v18+18]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v18+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v19+40]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v19+28]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v19+18]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v125 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	private void Turn(int monster)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0770: Expected Obj, but got I
		//IL_0792: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I
		//IL_07ca: Expected Obj, but got I4
		//IL_0847: Expected Obj, but got I
		//IL_0131: Expected I4, but got Obj
		//IL_0115: Expected I4, but got Obj
		//IL_01bf: Expected Obj, but got I4
		//IL_0802: Expected Obj, but got I4
		//IL_087c: Expected Obj, but got I
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_0212: Expected Obj, but got I4
		//IL_0370: Expected Obj, but got I
		//IL_039a: Expected Obj, but got I4
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I8
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I4
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_0829: Expected Obj, but got I4
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_0293: Expected Obj, but got I4
		//IL_04a6: Expected VT, but got F8
		//IL_02c2: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I4
		//IL_04d3: Expected VT, but got F8
		//IL_0324: Expected Obj, but got I4
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_0500: Expected VT, but got F8
		//IL_0532: Expected VT, but got F8
		//IL_0307: Expected Obj, but got I
		//IL_0310: Expected Obj, but got I4
		//IL_0559: Expected VT, but got I4
		//IL_05c9: Expected VT, but got I4
		//IL_05e6: Expected Obj, but got I8
		//IL_063c: Expected Obj, but got I
		//IL_064c: Expected Obj, but got I
		//IL_066e: Expected Obj, but got I4
		//IL_06ad: Expected F4, but got I
		//IL_06ad: Expected F4, but got I
		//IL_06cf: Expected F4, but got I
		//IL_06cf: Expected F4, but got I
		//IL_0714: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj7 = null;
		if (!flag3)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v36+A0]");
			object obj9 = 0;
			((KillCam)obj9).Heal();
			obj7 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v13+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v11+8]");
		if ((nint)0 != 0)
		{
			BackToApe();
			bool flag6 = (byte)(int)obj7 != 0;
		}
		else
		{
			bool flag7 = monster == 0;
			bool flag6 = (byte)(int)obj7 != 0;
			if (!flag7)
			{
				ApeLetGo();
				bool flag8 = Resize(1f, needsRoom: false);
				flag6 = false;
			}
		}
		MonsterDirector.Entry entry = MonsterCatalog.Of(monster);
		if (entry == null)
		{
			return;
		}
		object obj16 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v21+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v21+A0]");
		object obj20 = 0;
		object obj21 = this + 328;
		this.entry = entry;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		GameObject[] array = apeBodies;
		bool flag11 = array.Length < 1;
		object obj22 = 0;
		MonsterDirector.Entry entry2 = entry;
		if (flag11)
		{
			goto IL_0360;
		}
		object obj23 = array.Length & 0xFFFFFFFFL;
		object obj24 = array + 32;
		object obj25 = 0;
		object obj26 = 0;
		MonsterDirector.Entry entry3 = entry;
		while (true)
		{
			bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
			object obj27 = !flag12;
			if (obj27 != null)
			{
				break;
			}
			object obj28 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v69+E4]");
			bool flag13 = (nint)0 == 0;
			object obj29 = !flag13;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X26_v6+v124 @ X25_v7*8]");
			bool flag14 = (UnityEngine.Object)0 != null;
			bool flag15 = !flag14;
			obj22 = 0;
			entry2 = null;
			if (!flag15)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X26_v6+v124 @ X25_v7*8]");
				((GameObject)0).SetActive(value: false);
				obj22 = 0;
				entry2 = null;
			}
			obj23 = array.Length;
			obj25++;
			bool flag16 = (nint)obj25 < array.Length;
			obj26 = obj22;
			entry3 = entry2;
			if (flag16)
			{
				continue;
			}
			goto IL_0360;
		}
		goto IL_073b;
		IL_073b:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0360:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
		object obj30 = 0;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v27+E4]");
		bool flag17 = (nint)0 == 0;
		object obj32 = !flag17;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MonsterAvatar monsterAvatar = MonsterAvatar.Create(entry, null, head, leftFollower, rightFollower, firstPerson: true);
		worn = monsterAvatar;
		object obj33 = this + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj34 = worn + 56;
		obj34 = leftTarget;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj35 = worn + 64;
		obj35 = rightTarget;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (~(entry.legs ? 1u : 0u) == 0)
		{
			Walk(entry);
		}
		else
		{
			Crawl(entry);
		}
		Vector3 position = leftFollower.position;
		lastL = (Vector3)1.0;
		Vector3 position2 = rightFollower.position;
		lastR = (Vector3)1.0;
		Vector3 vector = RealHand(right: false);
		lastRealL = (Vector3)1.0;
		Vector3 vector2 = RealHand(right: true);
		Vector3[] array2 = armWas;
		lastRealR = (Vector3)1.0;
		Transform transform = base.transform;
		Vector3 vector3 = transform.InverseTransformPoint((Vector3)0);
		if (array2.Length != 0)
		{
			_ = lastRealL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+230]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+234]");
			_ = 0;
			Vector3[] array3 = armWas;
			Transform transform2 = base.transform;
			Vector3 vector4 = transform2.InverseTransformPoint((Vector3)0);
			object obj36 = array3.Length & 0xFFFFFFFEL;
			if (obj36 != null)
			{
				_ = lastRealR;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+23C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+240]");
				_ = 0;
				object obj37 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0E8]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v54+E4]");
				bool flag18 = (nint)0 == 0;
				object obj40 = !flag18;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				Buzz((XRNode)4, num, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				Buzz((XRNode)5, num2, 0f);
				string message = (string)obj38 + entry.name;
				object obj41 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v29+E4]");
				bool flag19 = (nint)0 == 0;
				object obj42 = !flag19;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.Log(message);
				return;
			}
		}
		goto IL_073b;
	}

	private static void PrepareRips()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0383: Expected Obj, but got I4
		//IL_03a9: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I
		//IL_044a: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I8
		//IL_01ab: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I4
		//IL_03f2: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I
		//IL_0308: Expected Obj, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I4
		//IL_02ee: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 == null;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			return;
		}
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X19_v3 (UnityEngine.Object)+68]");
		bool flag7 = (UnityEngine.Object)0 == null;
		bool flag8 = !flag7;
		object obj14 = !flag8;
		if (obj14 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X19_v3 (UnityEngine.Object)+68]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11+20]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11+20]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v7+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v7+18]");
		object obj17 = 0 & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11+20]");
		object obj19 = (nint)0 + (nint)32;
		object obj20 = 0;
		object obj21 = 0;
		UnityEngine.Object obj22 = null;
		while (true)
		{
			bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
			object obj23 = !flag9;
			if (obj23 != null)
			{
				break;
			}
			object obj24 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X24_v4+v168 @ X22_v5*8]");
			UnityEngine.Object obj25 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v19+E4]");
			bool flag10 = (nint)0 == 0;
			object obj26 = !flag10;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X24_v4+v168 @ X22_v5*8]");
			bool flag11 = (UnityEngine.Object)0 != null;
			bool flag12 = !flag11;
			obj22 = null;
			if (!flag12)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X19_v8 (UnityEngine.Object)+28]");
				bool flag13 = (nint)0 == 0;
				obj22 = null;
				if (!flag13)
				{
					object obj27 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v24+E4]");
					bool flag14 = (nint)0 == 0;
					object obj28 = !flag14;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X24_v4+v168 @ X22_v5*8]");
					GillaRip.Prepare((Dismemberment)0);
					obj22 = null;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v7+18]");
			obj17 = 0;
			obj20++;
			object obj29 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v7+18]");
			bool flag15 = (nint)obj29 < 0;
			obj21 = 0;
			if (!flag15)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Walk(MonsterDirector.Entry e)
	{
		//IL_0030: Expected F4, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_006c: Expected VT, but got Obj
		//IL_008e: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got I4
		//IL_0262: Expected VT, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_02d1: Expected VT, but got I4
		//IL_032e: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I4
		//IL_0310: Expected VT, but got I4
		//IL_0319: Expected VT, but got I4
		//IL_047f: Expected Obj, but got I
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected Obj, but got Unknown
		//IL_0435: Expected Obj, but got I4
		//IL_050b: Expected Obj, but got I
		//IL_0523: Expected Obj, but got I
		//IL_0538: Expected VT, but got Obj
		Vector3 localPosition = head.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAFC]");
		standHeight = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Vector3 position = head.position;
		Vector3 vector = (Vector3)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v9 (UnityEngine.Vector3)+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 vector2 = FloorUnder(vector);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3;
		if (locomotion == null)
		{
			UnityEngine.Object obj6 = null;
			flag3 = true;
		}
		else
		{
			flag3 = locomotion.enabled;
			UnityEngine.Object obj6 = null;
		}
		object obj7 = obj2;
		locomotionWasOn = flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = locomotion != null;
		bool flag6 = !flag5;
		object obj9 = 0;
		if (!flag6)
		{
			locomotion.enabled = false;
			obj9 = 0;
		}
		Freeze(on: true);
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 position2 = transform2.position;
		Transform transform3 = base.transform;
		Vector3 position3 = transform3.position;
		transform.position = (Vector3)0;
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v30+E4]");
		bool flag7 = (nint)0 == 0;
		object obj11 = !flag7;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = body != null;
		bool flag9 = !flag8;
		Vector3 vector3 = (Vector3)0;
		if (!flag9)
		{
			Transform transform4 = base.transform;
			Vector3 position4 = transform4.position;
			body.position = (Vector3)0;
			vector3 = (Vector3)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB500]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v35+E4]");
		bool flag10 = (nint)0 == 0;
		object obj15 = !flag10;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Physics.SyncTransforms();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v12+E4]");
		bool flag11 = (nint)0 == 0;
		object obj17 = !flag11;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj18 = default;
		if (obj18 != null)
		{
			object obj19 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v55+E4]");
			bool flag12 = (nint)0 == 0;
			object obj20 = !flag12;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DestroyImmediate(obj18);
		}
		GameObject gameObject = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0F0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		CharacterController characterController = default;
		walker = characterController;
		object obj22 = this + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		walker.slopeLimit = 45f;
		standEyes = e.eyeHeight;
		Size(e.eyeHeight);
		fitted = false;
		wornFor = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v21+A0]");
		object obj25 = 0;
		vy = 0f;
		planar = (Vector3)obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v22+8]");
		_ = 0;
	}

	private void Size(float eyeHeight)
	{
		//IL_02f9: Expected Obj, but got I
		//IL_0362: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I4
		//IL_042d: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_0132: Invalid comparison between F4 and I4
		//IL_0141: Invalid comparison between F4 and I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0169: Expected Obj, but got F4
		//IL_019e: Expected Obj, but got I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01d2: Expected F4, but got I
		//IL_047d: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_040f: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		float num = eyeHeight / standHeight;
		bool flag = (double)num < 0.5;
		double num2 = 0.5;
		if (!flag)
		{
			bool flag2 = !((double)num > 2.0);
			num2 = num;
			double num3 = 2.0;
			if (!flag2)
			{
				num2 = 2.0;
				num3 = 2.0;
			}
		}
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj3 = !flag3;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6+A0]");
		object obj6 = 0;
		double num4 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v7+C]");
		double num5 = num4 * 0.0;
		ScaleAboutHead((float)num5);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v10+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v10+A0]");
		object obj9 = 0;
		float num6 = eyeHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		float num7 = num6 + 0f;
		float num8 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v13+C]");
		float num9 = num8 * 0f;
		float height = num9 / (float)num5;
		walker.height = height;
		float num10 = eyeHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		float num11 = num10 * 0f;
		float num12 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num13 = num12 - 0f;
		bool flag6 = num13 < 0f;
		bool flag7 = num13 == 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		object obj10 = num11 ^ 0;
		object obj11 = num11 ^ num13;
		object obj12 = obj10 & obj11;
		bool flag8 = (nint)obj12 < 0;
		bool flag9 = flag6 == flag8;
		object obj13 = !flag7;
		object obj14 = flag9 & obj13;
		object obj15 = ~obj14;
		float num14;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			num14 = 0f;
		}
		else
		{
			num14 = num11;
		}
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v16+E4]");
		bool flag10 = (nint)0 == 0;
		object obj17 = !flag10;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v16+A0]");
		object obj18 = 0;
		float num15 = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v19+C]");
		float num16 = num15 * 0f;
		float radius = num16 / (float)num5;
		walker.radius = radius;
		float radius2 = walker.radius;
		float num17 = radius2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		float skinWidth = num17 * 0f;
		walker.skinWidth = skinWidth;
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v22+E4]");
		bool flag11 = (nint)0 == 0;
		object obj20 = !flag11;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v22+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v24+C]");
		float num18 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num19 = num18 * 0f;
		float stepOffset = num19 / (float)num5;
		walker.stepOffset = stepOffset;
	}

	private void Crawl(MonsterDirector.Entry e)
	{
		//IL_02fb: Expected F8, but got I
		//IL_030b: Invalid comparison between F4 and I
		//IL_003c: Invalid comparison between F4 and I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_0118: Expected Obj, but got VT
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected VT, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected VT, but got Unknown
		//IL_0226: Expected Obj, but got I
		//IL_023d: Expected VT, but got Obj
		//IL_025f: Expected Obj, but got I4
		float num;
		float num2;
		if (~(e.hangs ? 1u : 0u) == 0)
		{
			num = e.reach;
			if (e.reach > 0f)
			{
				num2 = apeReach;
				goto IL_02dc;
			}
		}
		num = e.eyeHeight;
		num2 = apeEyeHeight;
		goto IL_02dc;
		IL_02dc:
		float num3 = num / num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		double num4 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		if (!(num3 < 0f))
		{
			bool flag = !((double)num3 > 3.5);
			num4 = num3;
			if (!flag)
			{
				num4 = 3.5;
			}
		}
		Player player = locomotion;
		object obj = this + 452;
		maxArm = player.maxArmLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		unstick = player.unStickDistance;
		jumpBy = player.jumpMultiplier;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (GorillaLocomotion.Player)+F0]");
		_ = 0;
		obj = player.leftHandOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (GorillaLocomotion.Player)+E4]");
		_ = 0;
		offR = player.rightHandOffset;
		object obj2 = default;
		Vector3 leftHandOffset = player.leftHandOffset * obj2;
		double num5 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (GorillaLocomotion.Player)+F0]");
		double num6 = num5 * 0.0;
		float jumpMultiplier = faster * player.jumpMultiplier;
		double num7 = (double)player.maxArmLength * num4;
		player.leftHandOffset = leftHandOffset;
		Player player2 = locomotion;
		player.jumpMultiplier = jumpMultiplier;
		player.maxArmLength = (float)num7;
		Vector3 rightHandOffset = player2.rightHandOffset * obj2;
		double num8 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v5 (GorillaLocomotion.Player)+E4]");
		double num9 = num8 * 0.0;
		player2.rightHandOffset = rightHandOffset;
		crawlSize = (float)num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj3 = 0;
		Vector3 position = head.position;
		Vector3 vector = (Vector3)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v7 (UnityEngine.Vector3)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 vector2 = FloorUnder(vector);
		ScaleAboutHead((float)num4);
		double num10 = ((~(e.hangs ? 1u : 0u) != 0) ? ((double)e.eyeHeight) : (num4 * (double)apeEyeHeight));
		double num11 = num9 + num10;
		float num12 = (float)num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float eyeY = num12 + 0f;
		Settle(eyeY);
		crawling = true;
	}

	private void BackToApe()
	{
		//IL_0ad9: Expected Obj, but got I
		//IL_0ae3: Expected VT, but got I
		//IL_0897: Expected Obj, but got I
		//IL_08a7: Expected Obj, but got I
		//IL_08b7: Expected Obj, but got I
		//IL_08cf: Expected F4, but got I
		//IL_08df: Expected Obj, but got I
		//IL_08e9: Expected VT, but got I
		//IL_08f2: Expected Obj, but got I4
		//IL_08fb: Expected Obj, but got I4
		//IL_0904: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I8
		//IL_006f: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Expected I4, but got Unknown
		//IL_092f: Expected Obj, but got I
		//IL_0947: Expected F4, but got I
		//IL_0957: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_019a: Expected I, but got Obj
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got I4
		//IL_0217: Expected I4, but got I8
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected I4, but got Unknown
		//IL_09a7: Expected Obj, but got I
		//IL_09bf: Expected F4, but got I
		//IL_09cf: Expected Obj, but got I
		//IL_09de: Expected VT, but got I4
		//IL_0230: Expected Obj, but got I8
		//IL_028a: Expected Obj, but got I4
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_0370: Expected VT, but got Obj
		//IL_0392: Expected Obj, but got I4
		//IL_030d: Expected Obj, but got I4
		//IL_03e6: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_04eb: Expected F4, but got I4
		//IL_0a24: Expected Obj, but got I4
		//IL_0478: Expected Obj, but got I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_04c5: Expected Obj, but got I4
		//IL_0a5c: Expected Obj, but got I4
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_051b: Expected F4, but got Obj
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected Obj, but got Unknown
		//IL_0542: Expected F4, but got Obj
		//IL_0575: Expected VT, but got Obj
		//IL_0af8: Expected Obj, but got I
		//IL_0605: Expected Obj, but got I4
		//IL_064a: Expected Obj, but got I4
		//IL_0685: Expected Obj, but got I4
		//IL_082c: Expected Obj, but got I4
		//IL_06d7: Expected Obj, but got I8
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected Obj, but got Unknown
		//IL_06ee: Expected Obj, but got I4
		//IL_0abb: Expected Obj, but got I4
		//IL_0a83: Expected Obj, but got I4
		//IL_0b6a: Expected Obj, but got I
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Expected Obj, but got Unknown
		//IL_072d: Expected Obj, but got I4
		//IL_075c: Expected Obj, but got I
		//IL_0778: Expected Obj, but got I4
		//IL_07c6: Expected Obj, but got I4
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got Unknown
		//IL_07a5: Expected Obj, but got I
		//IL_07ae: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		nint num = default;
		DropBoth((Vector3)num);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v9+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj5 = 0;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v10+4]");
		float num2 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v10+8]");
		object obj7 = 0;
		LetGoSlab((Vector3)num);
		object obj8 = 1;
		object obj9 = 0;
		object obj10 = 0;
		Vector3 velocity = default;
		while (true)
		{
			int[] array = bodyOf;
			bool flag = (nint)obj10 < array.Length;
			object obj11 = !flag;
			if (obj11 != null)
			{
				break;
			}
			object obj12 = (object)array + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v15+20]");
			object obj13 = 0 & 0x80000000L;
			bool flag2 = obj13 == null;
			object obj14 = !flag2;
			if (obj14 == null)
			{
				object obj15 = obj;
				bool flag3 = (byte)(obj9 & 1) != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v61+A0]");
				object obj16 = 0;
				obj6 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v62+4]");
				num2 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v62+8]");
				obj7 = 0;
				LetGoBody(flag3, velocity);
				num = (flag3 ? 1 : 0);
			}
			object obj17 = obj8 & 1;
			bool flag4 = obj17 == null;
			object obj18 = !flag4;
			obj8 = 0;
			obj9 = 1;
			obj10 = 1;
			if (obj18 != null)
			{
				continue;
			}
			object obj19 = 0;
			object obj20 = 1;
			object obj21 = 0;
			while (true)
			{
				GillaPieceId[] array2 = pieceIn;
				bool flag5 = (nint)obj21 < array2.Length;
				object obj22 = !flag5;
				if (obj22 != null)
				{
					break;
				}
				object obj23 = obj3;
				object obj24 = (object)array2 + obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v13+E4]");
				bool flag6 = (nint)0 == 0;
				object obj25 = !flag6;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v21+20]");
				bool flag7 = (UnityEngine.Object)0 != null;
				bool flag8 = !flag7;
				num = unchecked((nint)null);
				if (!flag8)
				{
					object obj26 = obj;
					bool flag9 = (byte)(obj19 & 1) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v58+A0]");
					object obj27 = 0;
					obj6 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v59+4]");
					num2 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v59+8]");
					obj7 = 0;
					LetGoPiece(flag9, (Vector3)0);
					num = (flag9 ? 1 : 0);
				}
				object obj28 = obj20 & 1;
				bool flag10 = obj28 == null;
				object obj29 = !flag10;
				obj19 = 1;
				obj20 = 0;
				obj21 = 1;
				if (obj29 != null)
				{
					continue;
				}
				int[] array3 = deadBody;
				ripBody = -1;
				object obj30 = array3.Length & 0xFFFFFFFEL;
				if (obj30 == null)
				{
					break;
				}
				object obj31 = obj3;
				array3[0] = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v18+E4]");
				bool flag11 = (nint)0 == 0;
				object obj32 = !flag11;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (worn != null)
				{
					GameObject obj33 = worn.gameObject;
					object obj34 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v56+E4]");
					bool flag12 = (nint)0 == 0;
					object obj35 = !flag12;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj33);
				}
				object obj36 = this + 344;
				worn = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Vector3 position = head.position;
				Vector3 vector = (Vector3)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v28 (UnityEngine.Vector3)+E4]");
				bool flag13 = (nint)0 == 0;
				object obj37 = !flag13;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Vector3 vector2 = FloorUnder(vector);
				object obj38 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v30+E4]");
				bool flag14 = (nint)0 == 0;
				object obj39 = !flag14;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag15 = walker != null;
				bool flag16 = !flag15;
				object obj40 = 0;
				UnityEngine.Object obj41 = null;
				if (!flag16)
				{
					walker.enabled = false;
					object obj42 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v79+E4]");
					bool flag17 = (nint)0 == 0;
					object obj43 = !flag17;
					if (obj43 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(walker);
					object obj44 = this + 352;
					walker = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj40 = 0;
					obj41 = null;
				}
				bool flag18 = (byte)(~(crawling ? 1u : 0u)) != 0;
				float num3 = num2;
				float num4 = -1f;
				if (!flag18)
				{
					Player player = locomotion;
					object obj45 = this + 428;
					num3 = (float)obj45;
					object obj46 = this + 452;
					player.minimumRaycastDistance = minCast;
					player.maxArmLength = (float)obj45;
					num4 = jumpBy;
					player.jumpMultiplier = jumpBy;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+1CC]");
					_ = 0;
					player.leftHandOffset = (Vector3)obj46;
					Player player2 = locomotion;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+1D8]");
					_ = 0;
					player2.rightHandOffset = offR;
					crawling = false;
				}
				object obj47 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X0_v35+E4]");
				bool flag19 = (nint)0 == 0;
				object obj48 = !flag19;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj49 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v39+E4]");
				bool flag20 = (nint)0 == 0;
				object obj50 = !flag20;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj49 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v39+A0]");
				object obj51 = 0;
				crawlSize = 1f;
				_ = 1065353216;
				ScaleAboutHead(1f);
				Freeze(on: false);
				float num5 = num2 + apeEyeHeight;
				float num6 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				float eyeY = num6 + 0f;
				Settle(eyeY);
				object obj52 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v43+E4]");
				bool flag21 = (nint)0 == 0;
				object obj53 = !flag21;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag22 = locomotion != null;
				bool flag23 = !flag22;
				object obj54 = 0;
				bool flag24 = false;
				if (!flag23)
				{
					flag24 = locomotionWasOn;
					locomotion.enabled = locomotionWasOn;
					obj54 = 0;
				}
				GameObject[] array4 = apeBodies;
				locomotionWasOn = true;
				if (array4.Length >= 1)
				{
					object obj55 = array4.Length & 0xFFFFFFFFL;
					object obj56 = array4 + 32;
					object obj57 = 0;
					object obj58 = obj54;
					bool flag25 = flag24;
					while (true)
					{
						bool flag26 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj57) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj55);
						object obj59 = !flag26;
						if (obj59 != null)
						{
							break;
						}
						object obj60 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v63+E4]");
						bool flag27 = (nint)0 == 0;
						object obj61 = !flag27;
						if (obj61 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X25_v8+v150 @ X24_v7*8]");
						bool flag28 = (UnityEngine.Object)0 != null;
						bool flag29 = !flag28;
						obj54 = 0;
						flag24 = false;
						if (!flag29)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X25_v8+v150 @ X24_v7*8]");
							((GameObject)0).SetActive(value: true);
							obj54 = 0;
							flag24 = true;
						}
						obj55 = array4.Length;
						obj57++;
						bool flag30 = (nint)obj57 < array4.Length;
						obj58 = obj54;
						flag25 = flag24;
						if (flag30)
						{
							continue;
						}
						goto IL_0802;
					}
					break;
				}
				goto IL_0802;
				IL_0802:
				object obj62 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X0_v49+E4]");
				bool flag31 = (nint)0 == 0;
				object obj63 = !flag31;
				if (obj63 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj64 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v53+E4]");
				bool flag32 = (nint)0 == 0;
				object obj65 = !flag32;
				if (obj65 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj64 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v53+A0]");
				object obj66 = 0;
				object obj67 = this + 328;
				entry = null;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return;
			}
			break;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Freeze(bool on)
	{
		//IL_0010: Expected Obj, but got I
		//IL_035f: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I4
		//IL_02f8: Expected VT, but got I4
		//IL_01c4: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected I4, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected I4, but got Unknown
		//IL_021e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = locomotion != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		bool flag4 = false;
		if (!flag3)
		{
			Player player = locomotion;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v24+E4]");
			bool flag5 = (nint)0 == 0;
			object obj6 = !flag5;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = player.headCollider != null;
			bool flag7 = !flag6;
			object obj7 = 0;
			bool flag8 = false;
			if (!flag7)
			{
				Player player2 = locomotion;
				object obj8 = !on;
				flag8 = (byte)(1 & obj8) != 0;
				player2.headCollider.enabled = flag8;
				obj7 = 0;
			}
			Player player3 = locomotion;
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v29+E4]");
			bool flag9 = (nint)0 == 0;
			object obj10 = !flag9;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag10 = player3.bodyCollider != null;
			bool flag11 = !flag10;
			obj4 = 0;
			flag4 = false;
			if (!flag11)
			{
				Player player4 = locomotion;
				object obj11 = !on;
				flag4 = (byte)(1 & obj11) != 0;
				player4.bodyCollider.enabled = flag4;
				obj4 = 0;
			}
		}
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v9+E4]");
		bool flag12 = (nint)0 == 0;
		object obj13 = !flag12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(body == null))
		{
			if (on)
			{
				RigidbodyInterpolation interpolation = body.interpolation;
				interp = interpolation;
				body.interpolation = (RigidbodyInterpolation)0;
				body.linearVelocity = (Vector3)0;
				body.isKinematic = true;
			}
			else
			{
				body.isKinematic = false;
				body.interpolation = interp;
			}
		}
	}

	public bool SetApeSize(float s, bool needsRoom = default(bool))
	{
		//IL_02fa: Expected F8, but got I
		//IL_030a: Expected Obj, but got I
		//IL_031a: Invalid comparison between F4 and I
		//IL_0360: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I4
		//IL_02ea: Expected I4, but got Obj
		//IL_019d: Expected Obj, but got I4
		//IL_03ca: Expected Obj, but got I
		//IL_03f4: Invalid comparison between F8 and I4
		//IL_0403: Invalid comparison between F8 and I4
		//IL_0416: Expected Obj, but got F8
		//IL_0423: Expected Obj, but got F8
		//IL_044f: Expected Obj, but got I
		//IL_0468: Expected Obj, but got I4
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_04c3: Invalid comparison between F8 and I4
		//IL_04d2: Invalid comparison between F8 and I4
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_04fa: Expected Obj, but got F8
		//IL_052f: Expected Obj, but got I4
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_023d: Expected F8, but got I
		//IL_055b: Invalid comparison between Obj and F8
		//IL_027a: Expected Obj, but got I4
		//IL_0582: Expected Obj, but got I
		//IL_0592: Expected Obj, but got I
		//IL_064a: Expected Obj, but got I4
		//IL_05c7: Expected Obj, but got I
		//IL_05d7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		double num = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		bool flag = s < 0f;
		double num2 = s;
		if (!flag)
		{
			bool flag2 = !((double)s > 3.0);
			num = s;
			num2 = 3.0;
			if (!flag2)
			{
				num = 3.0;
				num2 = 3.0;
			}
		}
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj3 = !flag3;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = locomotion == null;
		bool flag5 = !flag4;
		object obj4 = !flag5;
		bool result;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj5 = 0;
			object obj6 = obj;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v7+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v9+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj8 != null)
			{
				object obj10 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v30+A0]");
				object obj11 = 0;
				object obj12 = obj11;
				if (obj11 == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v32+A9]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0242;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v13+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v16+E4]");
			bool flag9 = (nint)0 == 0;
			object obj18 = !flag9;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			object obj20 = obj19;
			double num4 = default;
			double num3 = num2 - num4;
			bool flag10 = num3 < 0.0;
			bool flag11 = num3 == 0.0;
			object obj21 = num2 ^ num4;
			object obj22 = num2 ^ num3;
			object obj23 = obj21 & obj22;
			bool flag12 = (nint)obj23 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v18+A0]");
			object obj24 = 0;
			bool flag13 = flag10 == flag12;
			object obj25 = !flag11;
			object obj26 = flag13 & obj25;
			object obj27 = ~obj26;
			if (obj27 != null)
			{
				num2 = num4;
			}
			double num5 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			double num6 = num5 * 0.0;
			double num7 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v19+4]");
			double num8 = num7 - 0.0;
			bool flag14 = num8 < 0.0;
			bool flag15 = num8 == 0.0;
			double num9 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v19+4]");
			object obj28 = num9 ^ 0;
			object obj29 = num6 ^ num8;
			object obj30 = obj28 & obj29;
			bool flag16 = (nint)obj30 < 0;
			bool flag17 = flag14 == flag16;
			object obj31 = !flag15;
			object obj32 = flag17 & obj31;
			object obj33 = ~obj32;
			if (obj33 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v19+4]");
				num6 = 0.0;
			}
			object obj34 = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6))
			{
				object obj35 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v20+E4]");
				bool flag18 = (nint)0 == 0;
				object obj36 = !flag18;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj35 = obj14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v20+A0]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v21+10]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v21+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v325 @ X8_v22+18] (should have been resolved before IL gen)");
				}
				bool flag19 = Resize((float)num, needsRoom);
				object obj39 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v24+E4]");
				bool flag20 = (nint)0 == 0;
				object obj40 = !flag20;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj39 = obj14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v24+A0]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v25+18]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v25+18]");
				bool flag21 = (nint)0 == 0;
				result = flag19;
				if (!flag21)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ X8_v26+18] (should have been resolved before IL gen)");
					result = flag19;
				}
				goto IL_0604;
			}
		}
		goto IL_0242;
		IL_0242:
		result = true;
		goto IL_0604;
		IL_0604:
		return result;
	}

	private unsafe bool Resize(float s, bool needsRoom)
	{
		//IL_09d3: Expected F8, but got I
		//IL_09e3: Invalid comparison between F4 and I
		//IL_09f9: Expected Obj, but got I
		//IL_0a02: Expected F8, but got I4
		//IL_0a3a: Expected Obj, but got I4
		//IL_0a72: Expected Obj, but got I4
		//IL_0aa4: Expected Obj, but got I
		//IL_0ace: Invalid comparison between F8 and I4
		//IL_0add: Invalid comparison between F8 and I4
		//IL_0af0: Expected Obj, but got F8
		//IL_0afd: Expected Obj, but got F8
		//IL_0b29: Expected Obj, but got I
		//IL_0b42: Expected Obj, but got I4
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Expected Obj, but got Unknown
		//IL_0b8d: Expected F8, but got I
		//IL_0bad: Invalid comparison between F8 and I4
		//IL_0bbc: Invalid comparison between F8 and I4
		//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected Obj, but got Unknown
		//IL_0be4: Expected Obj, but got F8
		//IL_0c19: Expected Obj, but got I4
		//IL_0c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Expected Obj, but got Unknown
		//IL_00a7: Expected F8, but got I
		//IL_0c45: Invalid comparison between Obj and F8
		//IL_00e4: Expected Obj, but got I4
		//IL_0c74: Expected Obj, but got I
		//IL_0c96: Expected Obj, but got I4
		//IL_0df1: Expected Obj, but got I
		//IL_0e13: Expected Obj, but got I4
		//IL_045b: Expected Obj, but got I4
		//IL_09c3: Expected I4, but got Obj
		//IL_0368: Expected Obj, but got I4
		//IL_0546: Expected VT, but got F4
		//IL_0d3e: Expected Obj, but got I4
		//IL_05af: Expected VT, but got F4
		//IL_05d6: Expected Obj, but got I4
		//IL_0e31: Expected Obj, but got I
		//IL_0e6c: Expected Obj, but got I4
		//IL_0cb4: Expected Obj, but got I
		//IL_0cc4: Expected Obj, but got I
		//IL_0ce4: Expected Obj, but got I
		//IL_0d06: Expected Obj, but got I4
		//IL_0d7b: Expected Obj, but got I4
		//IL_01e6: Expected VT, but got I8
		//IL_01e6: Expected VT, but got Ref
		//IL_020b: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I8
		//IL_0e92: Expected Obj, but got I
		//IL_0eb9: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I4
		//IL_02fa: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_0696: Expected Obj, but got I
		//IL_06bf: Expected Obj, but got I
		//IL_0712: Expected VT, but got I4
		//IL_07e2: Expected VT, but got I4
		//IL_0811: Expected Obj, but got I4
		//IL_0856: Expected VT, but got I4
		//IL_093a: Expected Obj, but got I
		//IL_0964: Expected Obj, but got I4
		//IL_08c7: Expected VT, but got I4
		//IL_08e4: Expected Obj, but got I
		//IL_08f4: Expected F8, but got I
		//IL_0904: Expected F8, but got I
		//IL_090c: Expected F8, but got Obj
		//IL_091c: Expected VT, but got I4
		//IL_0925: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		double num = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		bool flag = s < 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		double num2 = 0.0;
		if (!flag)
		{
			bool flag2 = !((double)s > 3.0);
			num = s;
			num2 = 3.0;
			if (!flag2)
			{
				num = 3.0;
				num2 = 3.0;
			}
		}
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj3 = !flag3;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		object obj7 = obj6;
		double num4 = default;
		double num3 = num2 - num4;
		bool flag5 = num3 < 0.0;
		bool flag6 = num3 == 0.0;
		object obj8 = num2 ^ num4;
		object obj9 = num2 ^ num3;
		object obj10 = obj8 & obj9;
		bool flag7 = (nint)obj10 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v12+A0]");
		object obj11 = 0;
		bool flag8 = flag5 == flag7;
		object obj12 = !flag6;
		object obj13 = flag8 & obj12;
		object obj14 = ~obj13;
		if (obj14 != null)
		{
			num2 = num4;
		}
		double num5 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		double num6 = num5 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v13+4]");
		double num7 = 0.0;
		double num8 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v13+4]");
		double num9 = num8 - 0.0;
		bool flag9 = num9 < 0.0;
		bool flag10 = num9 == 0.0;
		double num10 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v13+4]");
		object obj15 = num10 ^ 0;
		object obj16 = num6 ^ num9;
		object obj17 = obj15 & obj16;
		bool flag11 = (nint)obj17 < 0;
		bool flag12 = flag9 == flag11;
		object obj18 = !flag10;
		object obj19 = flag12 & obj18;
		object obj20 = ~obj19;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v13+4]");
			num6 = 0.0;
		}
		object obj21 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6))
		{
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v9+E4]");
			bool flag13 = (nint)0 == 0;
			object obj23 = !flag13;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v13+E4]");
			bool flag14 = (nint)0 == 0;
			object obj26 = !flag14;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = obj;
			}
			object obj27 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v13+A0]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v19+E4]");
			bool flag15 = (nint)0 == 0;
			object obj29 = !flag15;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(walker != null))
			{
				float num11 = (float)num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X9_v4+C]");
				float num12 = num11 / 0f;
				bool flag16 = HeadAtSize(num12, out var at);
				bool flag17 = !flag16;
				object obj30 = !flag17;
				if (obj30 == null && needsRoom)
				{
					goto IL_0486;
				}
				Player player = locomotion;
				if ((object)locomotion != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					float num13 = num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v22 (GorillaLocomotion.Player)+F0]");
					float num14 = num13 * 0f;
					float minimumRaycastDistance = num12 * player.minimumRaycastDistance;
					object obj31 = default;
					float maxArmLength = player.maxArmLength * (float)obj31;
					float num15 = num12 * (float)player.leftHandOffset;
					player.minimumRaycastDistance = minimumRaycastDistance;
					player.maxArmLength = maxArmLength;
					player.leftHandOffset = (Vector3)num15;
					Player player2 = locomotion;
					if ((object)locomotion != null)
					{
						object obj32 = obj;
						float num16 = num12 * (float)player2.rightHandOffset;
						float num17 = num12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v7 (GorillaLocomotion.Player)+E4]");
						float num18 = num17 * 0f;
						player2.rightHandOffset = (Vector3)num16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v23+E4]");
						bool flag18 = (nint)0 == 0;
						object obj33 = !flag18;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj34 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X0_v27+E4]");
						bool flag19 = (nint)0 == 0;
						object obj35 = !flag19;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj34 = obj;
						}
						object obj36 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X0_v27+A0]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v27+E4]");
						bool flag20 = (nint)0 == 0;
						object obj38 = !flag20;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (worn != null)
						{
							MonsterAvatar monsterAvatar = worn;
							if ((object)worn == null)
							{
								goto IL_09b5;
							}
							monsterAvatar.sizeBy = (float)num;
						}
						Transform transform = base.transform;
						if ((object)transform != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj39 = 0;
							object obj40 = obj39;
							double num19 = num * (double)crawlSize;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v31+A0]");
							object obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v32+14]");
							double num20 = 0.0 * num19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v32+10]");
							double num21 = 0.0 * num19;
							double num22 = num19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v32+C]");
							double num23 = num22 * 0.0;
							transform.localScale = (Vector3)0;
							Transform transform2 = base.transform;
							if ((object)transform2 != null)
							{
								Vector3 position = transform2.position;
								if ((object)head != null)
								{
									Vector3 position2 = head.position;
									double num24 = (double)at - num23;
									object obj42 = default;
									double num25 = (double)obj42 - num21;
									double num26 = 0.0 - num20;
									double num27 = num23 + num24;
									double num28 = num21 + num25;
									double num29 = num20 + num26;
									transform2.position = (Vector3)0;
									object obj43 = obj25;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v41+E4]");
									bool flag21 = (nint)0 == 0;
									object obj44 = !flag21;
									if (obj44 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag22 = body != null;
									bool flag23 = !flag22;
									Vector3 vector = (Vector3)0;
									if (flag23)
									{
										goto IL_092a;
									}
									Transform transform3 = base.transform;
									if ((object)transform3 != null)
									{
										Vector3 position3 = transform3.position;
										if ((object)body != null)
										{
											body.position = (Vector3)0;
											if ((object)body != null)
											{
												object obj45 = obj39;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v40+A0]");
												object obj46 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v41+4]");
												num28 = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v41+8]");
												num29 = 0.0;
												num27 = (double)obj46;
												body.linearVelocity = (Vector3)0;
												vector = (Vector3)0;
												goto IL_092a;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_09b5;
			}
			bool flag24 = !needsRoom;
			ref RaycastHit reference = ref *(RaycastHit*)null;
			UnityEngine.Object obj47 = null;
			if (!flag24)
			{
				if ((object)head == null)
				{
					goto IL_09b5;
				}
				Vector3 position4 = head.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
				object obj49 = 0;
				object obj50 = obj48;
				object obj51 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v59+A0]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X0_v93+E4]");
				bool flag25 = (nint)0 == 0;
				object obj53 = !flag25;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double num30 = default;
				QueryTriggerInteraction queryTriggerInteraction = default;
				bool flag26 = Physics.Raycast((Vector3)(&num30), (Vector3)4294961403L, out *(RaycastHit*)1, (float)num6, 0, queryTriggerInteraction);
				bool flag27 = !flag26;
				int num31 = 0;
				object obj54 = 1114636288;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v60+20]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v60+1C]");
				object obj56 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v60+18]");
				object obj57 = 0;
				reference = ref *(RaycastHit*)1;
				obj47 = (UnityEngine.Object)4294961403L;
				if (!flag27)
				{
					Transform transform4 = base.transform;
					if ((object)transform4 == null)
					{
						goto IL_09b5;
					}
					Vector3 position5 = transform4.position;
					float num32 = standEyes;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					float num33 = num32 + 0f;
					double num34 = num * (double)num33;
					num6 = num7 + num34;
					double num35 = default;
					bool flag28 = num6 > num35;
					num31 = 0;
					obj54 = 1114636288;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v60+20]");
					obj55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v60+1C]");
					obj56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v60+18]");
					obj57 = 0;
					num7 = num35;
					reference = ref *(RaycastHit*)1;
					obj47 = null;
					if (flag28)
					{
						goto IL_0486;
					}
				}
			}
			object obj58 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v73+E4]");
			bool flag29 = (nint)0 == 0;
			object obj59 = !flag29;
			if (obj59 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj60 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v77+E4]");
			bool flag30 = (nint)0 == 0;
			object obj61 = !flag30;
			if (obj61 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj60 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v77+A0]");
			object obj62 = 0;
			Size(standEyes);
			object obj63 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v79+E4]");
			bool flag31 = (nint)0 == 0;
			object obj64 = !flag31;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (worn != null)
			{
				MonsterAvatar monsterAvatar2 = worn;
				if ((object)worn == null)
				{
					goto IL_09b5;
				}
				monsterAvatar2.sizeBy = (float)num;
			}
		}
		goto IL_00ac;
		IL_092a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj65 = 0;
		object obj66 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X0_v46+E4]");
		bool flag32 = (nint)0 == 0;
		object obj67 = !flag32;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Physics.SyncTransforms();
		if ((object)locomotion != null)
		{
			locomotion.InitializeValues();
			goto IL_00ac;
		}
		goto IL_09b5;
		IL_09b5:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0486:
		return false;
		IL_00ac:
		return true;
	}

	private unsafe bool HeadAtSize(float k, out Vector3 at)
	{
		//IL_04ca: Expected I4, but got Obj
		//IL_0060: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_01f3: Expected F4, but got I
		//IL_04f9: Expected Obj, but got I
		//IL_0676: Expected Obj, but got I
		//IL_0696: Expected Obj, but got I
		//IL_06b8: Expected Obj, but got I4
		//IL_024c: Expected F4, but got VT
		//IL_024c: Expected VT, but got Ref
		//IL_039d: Expected F4, but got I8
		//IL_03ad: Expected Obj, but got I
		//IL_03bd: Expected F4, but got I
		//IL_03cd: Expected F4, but got I
		//IL_03dd: Expected F4, but got I
		//IL_03ea: Expected F4, but got VT
		//IL_027d: Expected Obj, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02ee: Invalid comparison between F4 and I4
		//IL_02fd: Invalid comparison between F4 and I4
		//IL_0310: Expected Obj, but got F4
		//IL_031d: Expected Obj, but got F4
		//IL_0352: Expected Obj, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_052d: Expected Obj, but got I4
		//IL_0427: Expected F4, but got VT
		//IL_0427: Expected VT, but got Ref
		//IL_046b: Expected Obj, but got I4
		//IL_0490: Expected F4, but got I4
		//IL_0572: Invalid comparison between F4 and I4
		//IL_0581: Invalid comparison between F4 and I4
		//IL_0594: Expected Obj, but got F4
		//IL_05a1: Expected Obj, but got F4
		//IL_05d6: Expected Obj, but got I4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_0612: Invalid comparison between F4 and I4
		//IL_0625: Expected Obj, but got F4
		//IL_0632: Expected Obj, but got F4
		Player player;
		float num3;
		if ((object)head != null)
		{
			Vector3 position = head.position;
			ref Vector3 reference = ref *(Vector3*)null;
			player = locomotion;
			if ((object)locomotion != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(player.headCollider != null))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					float num = 0f;
					float num2 = k;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					num3 = num2 * 0f;
					UnityEngine.Object obj4 = null;
					goto IL_04e9;
				}
				Player player2 = locomotion;
				if ((object)locomotion != null && (object)player2.headCollider != null)
				{
					float radius = player2.headCollider.radius;
					Player player3 = locomotion;
					if ((object)locomotion != null && (object)player3.headCollider != null)
					{
						Transform transform = player3.headCollider.transform;
						if ((object)transform != null)
						{
							Vector3 lossyScale = transform.lossyScale;
							float num = radius * radius;
							num3 = num * k;
							UnityEngine.Object obj4 = null;
							goto IL_04e9;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_04e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj6 = 0;
		object obj7 = obj5;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v8+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		float num7;
		float num10;
		if (Physics.Raycast((Vector3)(&obj11), (Vector3)player.locomotionEnabledLayers, out *(RaycastHit*)1, (float)at, 0, queryTriggerInteraction))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector3&)+4]");
			object obj14 = default;
			object obj13 = 0 - obj14;
			float num4 = num3 + (float)obj14;
			float num5 = (float)obj13 * k;
			float num6 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			num7 = num6 + 0f;
			float num8 = (float)obj14 + num5;
			float num9 = num8 - num7;
			bool flag3 = num9 < 0f;
			bool flag4 = num9 == 0f;
			object obj15 = num8 ^ num7;
			object obj16 = num8 ^ num9;
			object obj17 = obj15 & obj16;
			bool flag5 = (nint)obj17 < 0;
			bool flag6 = flag3 == flag5;
			object obj18 = !flag4;
			object obj19 = flag6 & obj18;
			object obj20 = ~obj19;
			num10 = ((obj20 != null) ? num7 : num8);
		}
		else
		{
			num7 = 4.2865787E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v9+24]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector3&)+8]");
			float num4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector3&)+4]");
			float num5 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector3&)+4]");
			num10 = 0f;
			float num8 = (float)at;
		}
		object obj21 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj23 = default;
		bool flag8 = Physics.Raycast((Vector3)(&obj23), (Vector3)player.locomotionEnabledLayers, out *(RaycastHit*)1, (float)at, 0, queryTriggerInteraction);
		bool flag9 = !flag8;
		object obj24 = default;
		float num11 = (float)obj24 - num3;
		float num12 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A964]");
		float num13 = num12 + 0f;
		object obj25 = !flag9;
		object obj26 = ~obj25;
		if (obj26 != null)
		{
			num13 = 2.139095E+09f;
		}
		float num14 = ((!(num10 < num13)) ? num13 : num10);
		float num15 = num7 - num14;
		bool flag10 = num15 < 0f;
		bool flag11 = num15 == 0f;
		object obj27 = num7 ^ num14;
		object obj28 = num7 ^ num15;
		object obj29 = obj27 & obj28;
		bool flag12 = (nint)obj29 < 0;
		bool flag13 = flag10 == flag12;
		object obj30 = !flag11;
		object obj31 = flag13 & obj30;
		object obj32 = ~obj31;
		if (obj32 == null)
		{
			num14 = num7;
		}
		float num16 = num13 - num7;
		bool flag14 = num16 < 0f;
		object obj33 = num13 ^ num7;
		object obj34 = num13 ^ num16;
		object obj35 = obj33 & obj34;
		bool flag15 = (nint)obj35 < 0;
		return flag14 == flag15;
	}

	private void ScaleAboutHead(float s)
	{
		//IL_0038: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_00a3: Expected VT, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_012d: Expected VT, but got I4
		//IL_015c: Expected Obj, but got I4
		//IL_01a1: Expected VT, but got I4
		//IL_01fe: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I4
		//IL_01e0: Expected VT, but got I4
		//IL_01e9: Expected VT, but got I4
		Vector3 position = head.position;
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v8+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v9+14]");
		float num = 0f * s;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v9+10]");
		float num2 = 0f * s;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v9+C]");
		float num3 = 0f * s;
		transform.localScale = (Vector3)0;
		Vector3 position2 = head.position;
		Transform transform2 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = default;
		float num4 = (float)obj5 - num;
		float num5 = s - num3;
		Vector3 position3 = transform2.position;
		float num6 = num5 + num3;
		float num7 = num4 + num;
		transform2.position = (Vector3)0;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = body != null;
		bool flag3 = !flag2;
		Vector3 vector = (Vector3)0;
		if (!flag3)
		{
			Transform transform3 = base.transform;
			Vector3 position4 = transform3.position;
			body.position = (Vector3)0;
			vector = (Vector3)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v21+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Physics.SyncTransforms();
	}

	private void Settle(float eyeY)
	{
		//IL_0027: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_00ed: Expected VT, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_0161: Expected VT, but got I4
		//IL_0213: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I4
		//IL_01a0: Expected VT, but got I4
		//IL_01bd: Expected Obj, but got I
		//IL_01cd: Expected F4, but got I
		//IL_01dd: Expected F4, but got I
		//IL_01e5: Expected F4, but got Obj
		//IL_01f5: Expected VT, but got I4
		//IL_01fe: Expected VT, but got I4
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v6+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Vector3 position2 = head.position;
		object obj5 = default;
		float num = eyeY - (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v7+18]");
		float num2 = 0f * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v7+1C]");
		float num3 = 0f * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v7+20]");
		float num4 = 0f * num;
		float num5 = eyeY + num2;
		float num6 = (float)obj5 + num3;
		object obj6 = default;
		float num7 = (float)obj6 + num4;
		transform.position = (Vector3)0;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = body != null;
		bool flag3 = !flag2;
		Vector3 vector = (Vector3)0;
		if (!flag3)
		{
			Transform transform2 = base.transform;
			Vector3 position3 = transform2.position;
			body.position = (Vector3)0;
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v16+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v17+4]");
			num6 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v17+8]");
			num7 = 0f;
			num5 = (float)obj10;
			body.linearVelocity = (Vector3)0;
			vector = (Vector3)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Physics.SyncTransforms();
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (locomotion != null)
		{
			locomotion.InitializeValues();
		}
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_09b7: Expected Obj, but got I4
		//IL_0cb2: Expected Obj, but got I
		//IL_0cc2: Expected Obj, but got I
		//IL_09e7: Expected Obj, but got I4
		//IL_0a1f: Expected Obj, but got I4
		//IL_0cf7: Expected Obj, but got I
		//IL_0d07: Expected F8, but got I
		//IL_0d1c: Invalid comparison between I and F8
		//IL_0d42: Expected VT, but got I
		//IL_03ba: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_0ac7: Expected Obj, but got I4
		//IL_0d95: Expected Obj, but got I
		//IL_0a57: Expected Obj, but got I4
		//IL_0591: Expected Obj, but got I
		//IL_05bb: Expected Obj, but got I4
		//IL_0d60: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_063e: Expected Obj, but got I4
		//IL_0194: Expected VT, but got I4
		//IL_00f1: Expected VT, but got I
		//IL_0672: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I
		//IL_045b: Expected Obj, but got I
		//IL_047d: Expected Obj, but got I4
		//IL_0b11: Expected Obj, but got I
		//IL_0b29: Expected Obj, but got I
		//IL_0b31: Expected F8, but got Obj
		//IL_0b41: Expected F8, but got I
		//IL_0b51: Expected F8, but got I
		//IL_0b5c: Expected VT, but got I4
		//IL_01cb: Expected Obj, but got I4
		//IL_01ea: Expected VT, but got I4
		//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Expected Obj, but got Unknown
		//IL_0c65: Expected Obj, but got I4
		//IL_06b9: Expected Obj, but got I4
		//IL_0546: Expected F4, but got I4
		//IL_0b71: Expected Obj, but got I
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected Obj, but got Unknown
		//IL_04dd: Expected Obj, but got I
		//IL_0235: Expected VT, but got I4
		//IL_0758: Expected Obj, but got I4
		//IL_08d0: Expected Obj, but got I4
		//IL_07ae: Expected Obj, but got I4
		//IL_050c: Expected Obj, but got I4
		//IL_0bb3: Expected Obj, but got I
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc8: Expected Obj, but got Unknown
		//IL_0bf5: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I
		//IL_027d: Expected Obj, but got I4
		//IL_0958: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_0988: Expected Obj, but got I
		//IL_0a8f: Expected Obj, but got I4
		//IL_084a: Expected Obj, but got I
		//IL_0874: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I
		//IL_0379: Expected VT, but got I4
		//IL_038b: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+38]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ X8_v5+18] (should have been resolved before IL gen)");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v8+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10+C]");
		double num = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10+C]");
		bool flag4 = !(0.0 < 1.0);
		double num2 = 1.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+28]");
		Vector3 vector = (Vector3)0;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v91+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v91+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v69+8]");
			if ((nint)0 != 0)
			{
				bool flag7 = (byte)(~(crawling ? 1u : 0u)) != 0;
				num2 = 1.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+28]");
				vector = (Vector3)0;
				if (flag7)
				{
					goto IL_0390;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v92+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = body != null;
			bool flag10 = !flag9;
			num2 = 1.0;
			ForceMode forceMode = (ForceMode)0;
			vector = (Vector3)0;
			if (!flag10)
			{
				bool isKinematic = body.isKinematic;
				bool flag11 = !isKinematic;
				object obj17 = !flag11;
				num2 = 1.0;
				forceMode = (ForceMode)0;
				vector = (Vector3)0;
				if (obj17 == null)
				{
					bool useGravity = body.useGravity;
					bool flag12 = !useGravity;
					num2 = 1.0;
					forceMode = (ForceMode)0;
					vector = (Vector3)0;
					if (!flag12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
						object obj18 = 0;
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v100+E4]");
						bool flag13 = (nint)0 == 0;
						object obj20 = !flag13;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Vector3 gravity = Physics.gravity;
						object obj21 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v104+E4]");
						bool flag14 = (nint)0 == 0;
						object obj22 = !flag14;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj23 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v108+E4]");
						bool flag15 = (nint)0 == 0;
						object obj24 = !flag15;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj23 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v108+A0]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v82+C]");
						double num3 = 0.0 + -1.0;
						double num4 = num4 * num3;
						num *= num3;
						num2 = 1.0 * num3;
						body.AddForce((Vector3)5, (ForceMode)0);
						forceMode = (ForceMode)0;
						vector = (Vector3)5;
					}
				}
			}
		}
		goto IL_0390;
		IL_0c1a:
		object obj27;
		object obj26 = ~obj27;
		object obj28 = 1 & obj26;
		bool off;
		SaySpawnRoom(off);
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v30+E4]");
		bool flag16 = (nint)0 == 0;
		object obj30 = !flag16;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj29 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v30+A0]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v27+20]");
		object obj32 = 0 & obj28;
		if (obj32 != null)
		{
			ApePunches();
			return;
		}
		ApeLetGo();
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v33+E4]");
		bool flag17 = (nint)0 == 0;
		object obj34 = !flag17;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj33 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v33+A0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v30+21]");
		object obj36 = 0 & obj28;
		if (obj36 != null)
		{
			MenuFists();
			return;
		}
		float deltaTime = Time.deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num5 = punchIn - deltaTime;
		punchIn = num5;
		return;
		IL_0390:
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v12+E4]");
		bool flag18 = (nint)0 == 0;
		object obj38 = !flag18;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v16+E4]");
		bool flag19 = (nint)0 == 0;
		object obj40 = !flag19;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj39 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v16+A0]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17+8]");
		if ((nint)0 != 0)
		{
			if (this.entry == null)
			{
				return;
			}
			float deltaTime2 = Time.deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj43 = 0;
			object obj44 = obj42;
			object obj45 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v49+A0]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v61+E4]");
			bool flag20 = (nint)0 == 0;
			object obj47 = !flag20;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj46 != null)
			{
				object obj48 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v60+A0]");
				object obj49 = 0;
				object obj50 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v62+A9]");
				bool flag21 = (nint)0 == 0;
				object obj51 = !flag21;
				if (obj51 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			bool wantsBack = WantsBack;
			bool flag22 = !wantsBack;
			float num6 = 0f;
			if (!flag22)
			{
				num6 = deltaTime2 + backT;
			}
			backT = num6;
			if (num6 > backHold)
			{
				backT = 0f;
				Become(0);
				return;
			}
			object obj52 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v67+E4]");
			bool flag23 = (nint)0 == 0;
			object obj53 = !flag23;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (walker != null)
			{
				WalkOn(deltaTime2);
				num6 = deltaTime2;
			}
			MonsterDirector.Entry entry = this.entry;
			if (~(entry.grabs ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
				object obj54 = 0;
				object obj55 = obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v74+E4]");
				bool flag24 = (nint)0 == 0;
				object obj56 = !flag24;
				if (obj56 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaRip.MakeOneMore();
			}
			Hands(deltaTime2);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj57 = 0;
		object obj58 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v18+E4]");
		bool flag25 = (nint)0 == 0;
		object obj59 = !flag25;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (slabDoor != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj60 = 0;
			object obj61 = obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v45+A0]");
			object obj62 = 0;
			num2 = (double)obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v46+4]");
			num = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v46+8]");
			double num4 = 0.0;
			LetGoSlab((Vector3)0);
		}
		bool spawnRoomHolds = SpawnRoomHolds;
		object obj63 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v24+E4]");
		bool flag26 = (nint)0 == 0;
		object obj64 = !flag26;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool apePunchesOffHere = ApePunchesOffHere;
		obj27 = apePunchesOffHere | spawnRoomHolds;
		if (spawnRoomHolds)
		{
			object obj65 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v43+E4]");
			bool flag27 = (nint)0 == 0;
			object obj66 = !flag27;
			if (obj66 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!ApePunchesOffHere)
			{
				object obj67 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v46+E4]");
				bool flag28 = (nint)0 == 0;
				object obj68 = !flag28;
				if (obj68 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj67 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v46+A0]");
				object obj69 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v37+20]");
				if ((nint)0 != 0)
				{
					off = true;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v46+E4]");
					bool flag29 = (nint)0 == 0;
					object obj70 = !flag29;
					if (obj70 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj71 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v39+A0]");
						obj69 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v37+21]");
					bool flag30 = (nint)0 == 0;
					bool flag31 = !flag30;
					off = flag31;
				}
				goto IL_0c1a;
			}
		}
		off = false;
		goto IL_0c1a;
	}

	public void Snared(float seconds)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0034: Expected VT, but got F4
		//IL_0060: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I4
		//IL_00d0: Expected VT, but got F4
		float time = Time.time;
		float num = (snaredTill = time + seconds);
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Vector3 position = transform.position;
		object obj2 = obj;
		snaredAt = (Vector3)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform2;
		if (head != null)
		{
			transform2 = head;
		}
		else
		{
			transform2 = base.transform;
			bool flag2 = (object)transform2 == null;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				throw new NullReferenceException();
			}
		}
		Vector3 position2 = transform2.position;
		snaredHead = (Vector3)num;
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06c4: Expected Obj, but got I4
		//IL_06fc: Expected Obj, but got I4
		//IL_0751: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I4
		//IL_01fb: Expected F4, but got VT
		//IL_0299: Expected VT, but got I4
		//IL_02c3: Expected Obj, but got I4
		//IL_0310: Expected VT, but got I4
		//IL_0260: Expected Obj, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_0438: Expected Obj, but got I4
		//IL_033e: Expected VT, but got I4
		//IL_036c: Expected Obj, but got I4
		//IL_037d: Expected VT, but got I4
		//IL_0508: Expected F4, but got I
		//IL_0530: Expected Obj, but got I
		//IL_03b0: Expected Obj, but got I
		//IL_03c8: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I
		//IL_03f0: Expected F4, but got Obj
		//IL_0400: Expected VT, but got I4
		//IL_0409: Expected VT, but got I4
		//IL_05de: Expected Obj, but got I8
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected Obj, but got Unknown
		//IL_05f5: Expected Obj, but got I4
		//IL_0733: Expected Obj, but got I4
		//IL_0635: Expected F4, but got I
		//IL_0635: Expected F4, but got I
		//IL_064e: Expected Obj, but got I
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+8]");
		if ((nint)0 != 0)
		{
			float time = Time.time;
			if (time < snaredTill)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+32C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+330]");
				object obj9 = 0;
				wasSnared = true;
				object obj10 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v21+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = head != null;
				bool flag5 = !flag4;
				float num = (float)snaredAt;
				if (!flag5)
				{
					Vector3 position = head.position;
					Transform transform = base.transform;
					Vector3 position2 = transform.position;
					float num2 = time - time;
					object obj13 = default;
					object obj12 = obj13 - obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+32C]");
					obj8 = 0;
					num = (float)snaredHead - num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+33C]");
					obj9 = 0 - obj12;
				}
				Transform transform2 = base.transform;
				transform2.position = (Vector3)0;
				object obj14 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v28+E4]");
				bool flag6 = (nint)0 == 0;
				object obj15 = !flag6;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = body != null;
				bool flag8 = !flag7;
				object obj16 = obj9;
				Vector3 vector = (Vector3)0;
				object obj17 = obj8;
				float num3 = num;
				if (!flag8)
				{
					body.position = (Vector3)0;
					bool isKinematic = body.isKinematic;
					bool flag9 = !isKinematic;
					object obj18 = !flag9;
					obj16 = obj9;
					vector = (Vector3)0;
					obj17 = obj8;
					num3 = num;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj19 = 0;
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v32+A0]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v33+4]");
						obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v33+8]");
						obj16 = 0;
						num3 = (float)obj21;
						body.linearVelocity = (Vector3)0;
						vector = (Vector3)0;
					}
				}
				object obj22 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v33+E4]");
				bool flag10 = (nint)0 == 0;
				object obj23 = !flag10;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (locomotion != null && locomotion.enabled)
				{
					locomotion.InitializeValues();
				}
				float time2 = Time.time;
				if (time2 < struggleBuzz)
				{
					return;
				}
				float time3 = Time.time;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				float num4 = UnityEngine.Random.Range(0.25f, 0f);
				float num5 = time3 + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB98]");
				object obj24 = 0;
				struggleBuzz = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v42+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v42+18]");
					bool flag11 = (nint)0 == 1;
					_ = 4;
					if (!flag11)
					{
						_ = 5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v42+18]");
						if ((nint)0 < (nint)1)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v42+18]");
						object obj25 = 0 & 0xFFFFFFFFL;
						object obj27 = default;
						object obj26 = obj27 + 32;
						object obj28 = 0;
						InputDevice inputDevice = default;
						while (true)
						{
							bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25);
							object obj29 = !flag12;
							if (obj29 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X21_v9+v486 @ X20_v14*4]");
							InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
							bool flag13 = inputDevice.SendHapticImpulse(0u, num6, 0f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v42+18]");
							obj25 = 0;
							obj28++;
							object obj30 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v42+18]");
							if ((nint)obj30 >= 0)
							{
								return;
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
		}
		if (~(wasSnared ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj31 = 0;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v12+E4]");
			bool flag14 = (nint)0 == 0;
			object obj33 = !flag14;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (locomotion != null && locomotion.enabled)
			{
				locomotion.InitializeValues();
			}
		}
		wasSnared = false;
	}

	public void CloseFingers(bool right, float k)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (worn != null)
		{
			worn.CloseFingers(right, k);
		}
	}

	public void Float(Vector3 velocity, bool through)
	{
		//IL_001e: Expected I4, but got VT
		Vector3 vector = default;
		floatBy = vector;
		floatThrough = (byte)(int)velocity != 0;
		int frameCount = Time.frameCount;
		floatFrame = frameCount;
	}

	private void WalkOn(float dt)
	{
		//IL_0c4d: Expected Obj, but got I
		//IL_0c6e: Expected Obj, but got I
		//IL_0c8e: Expected Obj, but got I4
		//IL_0c96: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I4
		//IL_0015: Invalid comparison between F4 and I
		//IL_0026: Expected Obj, but got I
		//IL_0d24: Expected Obj, but got I
		//IL_0d3c: Expected Obj, but got I
		//IL_0d4c: Expected F4, but got I
		//IL_0d54: Expected F4, but got Obj
		//IL_0d64: Expected F4, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_0d79: Expected Obj, but got I
		//IL_0d91: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I4
		//IL_11f3: Expected Obj, but got I
		//IL_1222: Expected Obj, but got I
		//IL_1232: Expected Obj, but got I
		//IL_1247: Expected F4, but got Obj
		//IL_126d: Expected F4, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_0dab: Expected Obj, but got I
		//IL_0dd5: Expected Obj, but got I4
		//IL_12d9: Invalid comparison between F4 and I
		//IL_0cce: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got I
		//IL_0422: Expected F4, but got Obj
		//IL_0432: Expected F4, but got I
		//IL_1185: Expected Obj, but got I
		//IL_11a2: Expected Obj, but got I
		//IL_11af: Invalid comparison between F4 and Obj
		//IL_11c1: Expected Obj, but got I4
		//IL_0dfb: Expected Obj, but got I
		//IL_1308: Expected Obj, but got I
		//IL_132f: Expected Obj, but got I
		//IL_1346: Expected F4, but got Obj
		//IL_134e: Invalid comparison between F4 and Obj
		//IL_0164: Expected Obj, but got I4
		//IL_0d06: Expected Obj, but got I4
		//IL_0e2f: Expected Obj, but got I4
		//IL_13d0: Invalid comparison between F4 and I
		//IL_01ad: Expected Obj, but got I
		//IL_01e8: Invalid comparison between F4 and I
		//IL_01fa: Expected Obj, but got I4
		//IL_056a: Expected Obj, but got I
		//IL_0572: Expected F4, but got Obj
		//IL_0582: Expected F4, but got I
		//IL_022a: Expected Obj, but got I4
		//IL_1411: Expected Obj, but got I4
		//IL_05f4: Invalid comparison between F4 and I4
		//IL_0603: Invalid comparison between F4 and I4
		//IL_061b: Expected Obj, but got F8
		//IL_0628: Expected Obj, but got F4
		//IL_065d: Expected Obj, but got I4
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_06ca: Expected Obj, but got I4
		//IL_0ea3: Invalid comparison between F4 and I4
		//IL_0eb2: Expected F8, but got I4
		//IL_0ed0: Invalid comparison between F4 and I
		//IL_0f7f: Expected Obj, but got I
		//IL_0f87: Expected F4, but got Obj
		//IL_0f97: Expected F8, but got I
		//IL_0766: Expected Obj, but got I
		//IL_14ee: Invalid comparison between F8 and I4
		//IL_1478: Expected Obj, but got I4
		//IL_0fa6: Expected VT, but got F4
		//IL_0fc3: Expected Obj, but got I4
		//IL_0fdb: Expected F8, but got I4
		//IL_07ad: Invalid comparison between F4 and I
		//IL_0850: Invalid comparison between F4 and I4
		//IL_0816: Expected Obj, but got I
		//IL_081e: Expected F4, but got Obj
		//IL_082e: Expected F4, but got I
		//IL_0953: Expected Obj, but got I4
		//IL_090d: Expected Obj, but got I4
		//IL_0899: Expected Obj, but got I4
		//IL_08b1: Invalid comparison between F4 and I4
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected Obj, but got Unknown
		//IL_09fb: Expected VT, but got I4
		//IL_108d: Expected Obj, but got I
		//IL_109d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a2: Expected Obj, but got Unknown
		//IL_10c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ca: Expected Obj, but got Unknown
		//IL_116b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1170: Expected Obj, but got Unknown
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected Obj, but got Unknown
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Expected Obj, but got Unknown
		//IL_0acb: Expected VT, but got I4
		//IL_0ae0: Expected VT, but got I4
		//IL_0b17: Expected Obj, but got I4
		//IL_0a90: Expected VT, but got I4
		//IL_0bce: Expected VT, but got I4
		//IL_0bce: Expected VT, but got I4
		//IL_0ab6: Expected VT, but got I4
		//IL_0be7: Expected VT, but got I4
		//IL_0b92: Expected VT, but got I4
		//IL_0c23: Expected VT, but got I4
		//IL_0c23: Expected VT, but got I4
		//IL_0c3c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		float num = wornFor + dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		wornFor = num;
		bool flag = (byte)(~(fitted ? 1u : 0u)) != 0;
		object obj3 = !flag;
		IntPtr intPtr = default;
		UnityEngine.Object obj4 = (UnityEngine.Object)(nint)intPtr;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			bool flag2 = !(num > 0f);
			obj4 = (UnityEngine.Object)(nint)intPtr;
			if (!flag2)
			{
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v151+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = worn != null;
				bool flag5 = !flag4;
				object obj7 = 0;
				obj4 = null;
				if (!flag5)
				{
					MonsterAvatar monsterAvatar = worn;
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v155+E4]");
					bool flag6 = (nint)0 == 0;
					object obj9 = !flag6;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v159+E4]");
					bool flag7 = (nint)0 == 0;
					object obj11 = !flag7;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj10 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v159+A0]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v111+C]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					object obj13 = num2 * 0;
					float num3 = monsterAvatar.EyeHeightNow__BackingField;
					bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
					obj7 = 0;
					obj4 = null;
					if (!flag8)
					{
						MonsterAvatar monsterAvatar2 = worn;
						fitted = true;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v159+E4]");
						bool flag9 = (nint)0 == 0;
						object obj14 = !flag9;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj15 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v163+E4]");
						bool flag10 = (nint)0 == 0;
						object obj16 = !flag10;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj15 = obj;
						}
						MonsterDirector.Entry entry = this.entry;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v163+A0]");
						object obj17 = 0;
						float num4 = monsterAvatar2.EyeHeightNow__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v18+C]");
						float eyeHeight = num4 / 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
						float eyeHeight2 = entry.eyeHeight;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
						bool flag11 = !(eyeHeight2 > 0f);
						obj7 = 0;
						obj4 = null;
						if (!flag11)
						{
							standEyes = eyeHeight;
							Size(eyeHeight);
							obj7 = 0;
							obj4 = null;
						}
					}
				}
			}
		}
		float num5 = Time.time;
		float num6 = snaredTill;
		float num7;
		float num8;
		if (!(num5 < snaredTill))
		{
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v142+E4]");
			bool flag12 = (nint)0 == 0;
			object obj19 = !flag12;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector2 vector = Stick((XRNode)4);
			num7 = num5;
			num8 = num6;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v102+A0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v103+4]");
			num5 = 0f;
			num7 = (float)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v103+4]");
			num8 = 0f;
		}
		Vector3 forward = head.forward;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v9+A0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj26 = 0;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v10+20]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v10+20]");
		object obj28 = num9 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X8_v12+A0]");
		object obj29 = 0;
		object obj31 = default;
		object obj30 = obj28 + obj31;
		float num10 = (float)obj29;
		bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
		float num11 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		float num12 = 0f;
		object obj32 = default;
		object obj33 = default;
		if (!flag13)
		{
			float num13 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v10+18]");
			float num14 = num13 * 0f;
			float num15 = num6 * (float)obj32;
			float num16 = num14 + num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			float num17 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v10+20]");
			num10 = num17 * 0f;
			float num18 = num10 + num16;
			float num19 = num18 / (float)obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v10+18]");
			num6 = 0f * (float)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v10+20]");
			float num20 = 0f * num19;
			num11 = num5 - num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			num12 = 0f - num20;
			num5 = num20;
		}
		float num21 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj34 = 0;
		object obj35 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v13+E4]");
		bool flag14 = (nint)0 == 0;
		object obj36 = !flag14;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num21 = num11;
		}
		float num22 = num21 * num21;
		float num23 = num12 * num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num24 = num22 + num23;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num25 = num24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num26;
		float num27;
		if (num25 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			num26 = num12 / num24;
			num27 = num21 / num23;
		}
		else
		{
			object obj37 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v91+A0]");
			object obj38 = 0;
			num27 = (float)obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X8_v92+8]");
			num26 = 0f;
		}
		Vector3 right = head.right;
		object obj39 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v23+A0]");
		object obj40 = 0;
		object obj41 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X8_v26+A0]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v24+20]");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v24+20]");
		object obj43 = num28 * 0;
		float num29 = (float)obj43 + num21;
		float num30 = (float)obj42;
		bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num29) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42);
		float num31 = num24;
		float num32 = num10;
		if (!flag15)
		{
			float num33 = num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v24+18]");
			float num14 = num33 * 0f;
			float num34 = num23 * (float)obj32;
			float num35 = num14 + num34;
			float num36 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v24+20]");
			num30 = num36 * 0f;
			float num37 = num30 + num35;
			float num38 = num37 / num29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v24+18]");
			num23 = 0f * (float)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v24+20]");
			float num39 = 0f * num38;
			num31 = num24 - num23;
			num32 = num10 - num39;
			num24 = num39;
		}
		float num40 = num31;
		object obj44 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v21+E4]");
		bool flag16 = (nint)0 == 0;
		object obj45 = !flag16;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num40 = num31;
		}
		float num41 = num40 * num40;
		float num42 = num32 * num32;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num43 = num41 + num42;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num44;
		float num45;
		if (num43 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			num44 = num32 / num43;
			num45 = num40 / num42;
		}
		else
		{
			object obj46 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v85+A0]");
			object obj47 = 0;
			num45 = (float)obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v86+8]");
			num44 = 0f;
		}
		object obj48 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ X0_v24+E4]");
		bool flag17 = (nint)0 == 0;
		object obj49 = !flag17;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MonsterDirector.Entry entry2 = this.entry;
		float num46 = num7 * num7;
		float num47 = num8 * num8;
		float num48 = num46 + num47;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num49 = num48 - 1f;
		bool flag18 = num49 < 0f;
		bool flag19 = num49 == 0f;
		object obj50 = (double)num48 ^ 1.0;
		object obj51 = num48 ^ num49;
		object obj52 = obj50 & obj51;
		bool flag20 = (nint)obj52 < 0;
		bool flag21 = flag18 == flag20;
		object obj53 = !flag19;
		object obj54 = flag21 & obj53;
		object obj55 = ~obj54;
		float num50 = ((obj55 != null) ? num48 : 1f);
		object obj56 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X0_v26+E4]");
		bool flag22 = (nint)0 == 0;
		object obj57 = !flag22;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj58 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X0_v30+E4]");
		float num51;
		if ((nint)0 != 0)
		{
			num51 = num26;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj58 = obj;
			num51 = num26;
		}
		float num52 = num50 + -0.25f;
		float num53 = num52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num54 = num53 / 0f;
		bool flag23 = num54 < 0f;
		double num55 = 0.0;
		if (!flag23)
		{
			bool flag24 = !((double)num54 > 1.0);
			num55 = num54;
			if (!flag24)
			{
				num55 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		object obj60 = default;
		float num70;
		double num71;
		if (num50 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X0_v30+A0]");
			object obj59 = 0;
			float num56 = entry2.runSpeed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X8_v73+C]");
			float num57 = num56 * 0f;
			float num58 = num27 * (float)obj60;
			float num59 = num8 * num51;
			float num60 = num7 * num44;
			float num61 = num45 * (float)obj33;
			object obj61 = obj34;
			float num62 = num57 * faster;
			float num63 = num58 + num61;
			float num64 = num59 + num60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v97+E4]");
			bool flag25 = (nint)0 == 0;
			object obj62 = !flag25;
			if (obj62 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			double num65 = (double)num62 * num55;
			float num66 = num30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num67;
			float num69;
			if (num66 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				num67 = num64 / num30;
				float num68 = num63;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				num69 = num68 / 0f;
			}
			else
			{
				object obj63 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ X8_v79+A0]");
				object obj64 = 0;
				num69 = (float)obj64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X8_v80+8]");
				num67 = 0f;
			}
			num70 = num69 * (float)obj33;
			num71 = num65 * (double)num67;
		}
		else
		{
			object obj65 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v70+A0]");
			object obj66 = 0;
			num70 = (float)obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X8_v71+8]");
			num71 = 0.0;
		}
		float num72 = num70 - (float)planar;
		double num73 = num71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+170]");
		double num74 = num73 - 0.0;
		float num75 = num72 * num72;
		double num76 = num74 * num74;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		double num77 = num76 + (double)num75;
		bool flag26 = num77 == 0.0;
		float num78 = (float)num71;
		object obj72 = default;
		if (!flag26)
		{
			float num79 = dt * 20f;
			bool flag27 = num79 < 0f;
			float num80 = 20f;
			if (!flag27)
			{
				num80 = num79 * num79;
				bool flag28 = num77 < (double)num80;
				object obj67 = !flag28;
				float num81 = (float)num77 - num80;
				bool flag29 = num81 == 0f;
				object obj68 = ~obj67;
				object obj69 = obj68 | flag29;
				num78 = (float)num71;
				if (obj69 != null)
				{
					goto IL_0f9c;
				}
			}
			object obj70 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X0_v85+E4]");
			bool flag30 = (nint)0 == 0;
			object obj71 = !flag30;
			if (obj71 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			float num82 = num72 / dt;
			float num83 = (float)num74 / num80;
			float num84 = num82 * (float)obj72;
			num70 = (float)planar + num84;
			float num85 = num79 * num83;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+170]");
			num78 = 0f + num85;
		}
		goto IL_0f9c;
		IL_0f9c:
		planar = (Vector3)num70;
		int frameCount = Time.frameCount;
		object obj73 = frameCount - floatFrame;
		bool flag31 = (nint)obj73 < 2;
		double num86 = 0.0;
		if (!flag31)
		{
			bool isGrounded = walker.isGrounded;
			bool flag32 = !isGrounded;
			object obj74 = !flag32;
			num86 = -1.0;
			if (obj74 == null)
			{
				float num87 = dt;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF20]");
				float num88 = num87 * 0f;
				num86 = (double)vy + (double)num88;
			}
		}
		vy = (float)num86;
		Vector3 localPosition = head.localPosition;
		float height = walker.height;
		float skinWidth = walker.skinWidth;
		Vector3 localPosition2 = head.localPosition;
		walker.center = (Vector3)0;
		object obj75 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1178 @ X8_v51+A0]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ X8_v53+18]");
		object obj77 = 0 * obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ X8_v53+20]");
		float num89 = 0f * vy;
		object obj78 = planar + obj77;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+170]");
		float num90 = 0f + num89;
		object obj79;
		if ((nint)obj73 < 2)
		{
			obj76 = this + 404;
			obj79 = this + 412;
		}
		else
		{
			obj79 = obj76 + 8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		float num91 = num90 + (float)obj79;
		object obj80 = obj78 + obj76;
		float num92 = num91 * dt;
		float num93 = (float)obj80 * (float)obj72;
		if ((nint)obj73 <= 1 && ~(floatThrough ? 1u : 0u) == 0)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			float num94 = num92 + dt;
			float num95 = num93 + num93;
			float num97 = default;
			float num96 = num97 + num91;
			transform.position = (Vector3)0;
			num40 = num97;
			float num14 = num93;
			num93 = num95;
			Vector3 vector2 = (Vector3)0;
		}
		else
		{
			CollisionFlags collisionFlags = walker.Move((Vector3)0);
			float num94 = num92;
			Vector3 vector2 = (Vector3)0;
			float num98 = default;
			float num96 = num98;
		}
		object obj81 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1242 @ X0_v47+E4]");
		bool flag33 = (nint)0 == 0;
		object obj82 = !flag33;
		if (obj82 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (body != null)
		{
			Transform transform2 = base.transform;
			Vector3 position2 = transform2.position;
			body.position = (Vector3)0;
		}
		Vector3 position3 = leftTarget.position;
		Quaternion rotation = leftTarget.rotation;
		Vector3 vector3 = (Quaternion)0 * (Vector3)0;
		leftFollower.position = (Vector3)0;
		Vector3 position4 = rightTarget.position;
		Quaternion rotation2 = rightTarget.rotation;
		Vector3 vector4 = (Quaternion)0 * (Vector3)0;
		rightFollower.position = (Vector3)0;
	}

	private void Hands(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05b8: Expected Obj, but got I4
		//IL_069c: Expected Obj, but got I
		//IL_06ac: Expected Obj, but got I
		//IL_06c6: Expected Obj, but got I8
		//IL_06e0: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected I4, but got Unknown
		//IL_05eb: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_0609: Expected Obj, but got I
		//IL_0619: Expected Obj, but got I
		//IL_0629: Expected Obj, but got I
		//IL_0643: Expected Obj, but got I8
		//IL_065d: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_0730: Expected Obj, but got I4
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected I4, but got Unknown
		//IL_01b2: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I4
		//IL_02dc: Expected Obj, but got I4
		//IL_031a: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got I4
		//IL_0463: Expected Obj, but got I4
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected Obj, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+24]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+24]");
		object obj6 = 0 & 0x80000000L;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		bool flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v38+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v39+24]");
				obj5 = 0;
			}
			flag4 = (byte)(obj5 & 1) != 0;
			bool flag5 = (object)this == null;
			object obj11 = !flag5;
			if (obj11 != null)
			{
				goto IL_0107;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = Grip((XRNode)4);
			bool flag8 = (object)this == null;
			flag4 = flag7;
			if (!flag8)
			{
				goto IL_0107;
			}
		}
		goto IL_0579;
		IL_025b:
		gripL = false;
		float time = Time.time;
		if (armLostAt != null)
		{
			float[] array = default;
			array[0] = time;
			goto IL_0330;
		}
		goto IL_0579;
		IL_03b1:
		gripR = false;
		float time2 = Time.time;
		if (armLostAt != null)
		{
			float[] array2 = default;
			array2[1] = time2;
			goto IL_0473;
		}
		goto IL_0579;
		IL_0330:
		GillaItem gillaItem = GillaHands.Holding(1);
		object obj14;
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v14+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gillaItem != null)
		{
			goto IL_03b1;
		}
		if (~(gripR ? 1u : 0u) == 0)
		{
			bool flag10 = (byte)(~(wasGripR ? 1u : 0u)) != 0;
			object obj16 = !flag10;
			if (obj16 == null)
			{
				bool flag11 = GillaHands.Reaches(1);
				bool flag12 = !flag11;
				object obj17 = !flag12;
				if (obj17 != null)
				{
					goto IL_03b1;
				}
			}
		}
		goto IL_0473;
		IL_0473:
		FollowHands(dt);
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Vector3 localScale = transform.localScale;
			MonsterDirector.Entry entry = this.entry;
			if (this.entry != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				float reach = grabRadius * dt;
				if (~(entry.grabs ? 1u : 0u) == 0)
				{
					Grabbing(reach);
					ShowPull();
					AwaitTorn();
					AwaitBody();
					TellAtRest();
				}
				else
				{
					Killing(reach, dt);
				}
				object obj18 = this + 477;
				object obj19 = this + 479;
				obj19 = obj18;
				return;
			}
		}
		goto IL_0579;
		IL_0579:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0107:
		object obj20 = obj;
		gripL = flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v10+E4]");
		bool flag13 = (nint)0 == 0;
		object obj21 = !flag13;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v10+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v9+24]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v9+24]");
		object obj24 = 0 & 0x80000000L;
		bool flag14 = obj24 == null;
		object obj25 = !flag14;
		bool flag16;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v10+E4]");
			bool flag15 = (nint)0 == 0;
			object obj26 = !flag15;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj27 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v32+A0]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v33+24]");
				obj23 = 0;
			}
			object obj29 = obj23 >> 1;
			flag16 = (byte)(obj29 & 1) != 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v10+E4]");
			bool flag17 = (nint)0 == 0;
			object obj30 = !flag17;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag18 = Grip((XRNode)5);
			flag16 = flag18;
		}
		gripR = flag16;
		GillaItem gillaItem2 = GillaHands.Holding(0);
		object obj31 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v12+E4]");
		bool flag19 = (nint)0 == 0;
		object obj32 = !flag19;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gillaItem2 != null)
		{
			goto IL_025b;
		}
		bool flag20 = (byte)(~(gripL ? 1u : 0u)) != 0;
		time = dt;
		if (!flag20)
		{
			bool flag21 = (byte)(~(wasGripL ? 1u : 0u)) != 0;
			object obj33 = !flag21;
			time = dt;
			if (obj33 == null)
			{
				bool flag22 = GillaHands.Reaches(0);
				bool flag23 = !flag22;
				object obj34 = !flag23;
				time = dt;
				if (obj34 != null)
				{
					goto IL_025b;
				}
			}
		}
		goto IL_0330;
	}

	private void FollowHands(float dt)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_00e9: Expected VT, but got F4
		//IL_011e: Expected VT, but got F4
		//IL_0175: Invalid comparison between F8 and I4
		//IL_0184: Expected F8, but got I4
		//IL_022b: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0251: Invalid comparison between F8 and I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02b2: Expected F8, but got I4
		//IL_02d1: Expected Obj, but got VT
		//IL_02ee: Expected Obj, but got I
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected VT, but got Unknown
		//IL_0374: Expected VT, but got F4
		//IL_039e: Expected VT, but got F4
		Vector3 position = leftFollower.position;
		object obj = this + 484;
		Vector3 position2 = rightFollower.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1+10]");
		object obj3 = default;
		object obj2 = obj3 - 0;
		float num = dt - (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num2 = num / dt;
		float num3 = (float)obj2 / dt;
		Vector3 vector = RealHand(right: false);
		Vector3 vector2 = RealHand(right: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1+10]");
		_ = 0;
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1+58]");
		float num5 = num4 - 0f;
		float num6 = num5 / dt;
		lastRealR = (Vector3)num2;
		float num7 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1+48]");
		float num8 = num7 - 0f;
		float num9 = num8 / dt;
		lastRealL = (Vector3)num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1+10]");
		_ = 0;
		float num10 = dt * -25f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num11 = 1.0 - (double)num10;
		bool flag = num11 < 0.0;
		double num12 = 0.0;
		if (!flag)
		{
			bool flag2 = !(num11 > 1.0);
			num12 = num11;
			if (!flag2)
			{
				num12 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1+18]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1+30]");
		object obj4 = num13 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+204]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+21C]");
		object obj5 = num14 - 0;
		bool flag3 = num11 < 0.0;
		object obj7 = default;
		object obj6 = obj4 * obj7;
		double num15 = (double)obj5 * num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1+30]");
		object obj8 = 0 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+21C]");
		double num16 = 0.0 + num15;
		double num17 = 0.0;
		if (!flag3)
		{
			bool flag4 = !(num11 > 1.0);
			num17 = num11;
			if (!flag4)
			{
				num17 = 1.0;
			}
		}
		object obj9 = velR - throwR;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+210]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+228]");
		object obj10 = num18 - 0;
		object obj12 = default;
		object obj11 = obj9 * obj12;
		double num19 = (double)obj10 * num17;
		Vector3 vector3 = throwR + obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+228]");
		double num20 = 0.0 + num19;
		throwR = vector3;
		Vector3 real = default;
		ArmSwing(0, real, num2);
		ArmSwing(1, real, num2);
		lastL = (Vector3)dt;
		float num21 = punchIn - dt;
		punchIn = num21;
		lastR = (Vector3)dt;
	}

	private void ApePunches()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_05fb: Expected Obj, but got I
		//IL_061d: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_063b: Expected F4, but got I
		//IL_064b: Expected Obj, but got I
		//IL_066d: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_07f3: Expected I4, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected I4, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_01f7: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I4
		//IL_06eb: Expected Obj, but got I
		//IL_06fb: Expected Obj, but got I
		//IL_0715: Expected Obj, but got I8
		//IL_072f: Expected Obj, but got I4
		//IL_01c0: Expected I4, but got Obj
		//IL_0331: Expected Obj, but got I
		//IL_035b: Expected Obj, but got I4
		//IL_0409: Expected Obj, but got I4
		//IL_04f7: Expected Obj, but got I4
		//IL_0760: Expected Obj, but got I
		//IL_0770: Expected Obj, but got I
		//IL_078a: Expected Obj, but got I8
		//IL_07a4: Expected Obj, but got I4
		//IL_044b: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got I4
		//IL_0480: Expected Obj, but got I4
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected I4, but got Unknown
		//IL_03a2: Expected Obj, but got I4
		//IL_02bf: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected I4, but got Unknown
		//IL_03d2: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		float deltaTime = Time.deltaTime;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10;
		if ((UnityEngine.Object)obj5 != null)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v38+A0]");
			object obj8 = 0;
			object obj9 = obj8;
			if (obj8 == null)
			{
				goto IL_05bd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v40+A9]");
			obj10 = 0;
		}
		else
		{
			obj10 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		int frameCount = Time.frameCount;
		object obj12 = frameCount - fistsFrame;
		int frameCount2 = Time.frameCount;
		fistsFrame = frameCount2;
		UnityEngine.Object obj13 = null;
		int num2 = 0;
		while (true)
		{
			bool flag2 = (nint)obj12 > 1;
			int num3 = (int)obj13;
			if (!flag2)
			{
				bool flag3 = HandTaken(num2);
				bool flag4 = !flag3;
				num3 = num2;
				obj13 = (UnityEngine.Object)num2;
				if (flag4)
				{
					goto IL_0693;
				}
			}
			float[] array = armLostAt;
			num = Time.time;
			if (armLostAt == null)
			{
				break;
			}
			bool flag5 = num2 < array.Length;
			object obj14 = !flag5;
			if (obj14 != null)
			{
				goto IL_05cb;
			}
			int num4 = armLostAt + num2;
			obj13 = (UnityEngine.Object)num3;
			goto IL_0693;
			IL_0693:
			num2++;
			if (num2 != 2)
			{
				continue;
			}
			bool flag6;
			if (obj10 != null)
			{
				if ((object)this == null)
				{
					break;
				}
				gripL = false;
				int num5 = (int)obj13;
				flag6 = false;
				goto IL_04b9;
			}
			bool flag7 = HandTaken(0);
			bool flag8 = !flag7;
			object obj15 = !flag8;
			bool flag9 = false;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v48+E4]");
				bool flag10 = (nint)0 == 0;
				object obj18 = !flag10;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj16;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v48+A0]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v28+24]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v28+24]");
				object obj21 = 0 & 0x80000000L;
				bool flag11 = obj21 == null;
				object obj22 = !flag11;
				if (obj22 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v48+E4]");
					bool flag12 = (nint)0 == 0;
					object obj23 = !flag12;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					flag9 = Grip((XRNode)4);
					bool flag13 = (object)this == null;
					object obj24 = !flag13;
					if (obj24 == null)
					{
						break;
					}
					goto IL_02d4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v48+E4]");
				bool flag14 = (nint)0 == 0;
				object obj25 = !flag14;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj26 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v31+A0]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v32+24]");
					obj20 = 0;
				}
				flag9 = (byte)(obj20 & 1) != 0;
			}
			if ((object)this == null)
			{
				break;
			}
			goto IL_02d4;
			IL_04b9:
			gripR = flag6;
			FollowHands(deltaTime);
			object obj28 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v15+E4]");
			bool flag15 = (nint)0 == 0;
			object obj29 = !flag15;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaRip.MakeOneMore();
			Transform transform = base.transform;
			if ((object)transform == null)
			{
				break;
			}
			Vector3 localScale = transform.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			float reach = grabRadius * deltaTime;
			Grabbing(reach);
			ShowPull();
			AwaitTorn();
			AwaitBody();
			TellAtRest();
			object obj30 = this + 477;
			object obj31 = this + 479;
			obj31 = obj30;
			return;
			IL_02d4:
			gripL = flag9;
			if (HandTaken(1))
			{
				int num5 = 1;
				flag6 = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				object obj32 = 0;
				object obj33 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v35+E4]");
				bool flag16 = (nint)0 == 0;
				object obj34 = !flag16;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj33 = obj32;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v35+A0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v21+24]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v21+24]");
				object obj37 = 0 & 0x80000000L;
				bool flag17 = obj37 == null;
				object obj38 = !flag17;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v35+E4]");
					bool flag18 = (nint)0 == 0;
					object obj39 = !flag18;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj40 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v24+A0]");
						object obj41 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v25+24]");
						obj36 = 0;
					}
					object obj42 = obj36 >> 1;
					flag6 = (byte)(obj42 & 1) != 0;
					int num5 = 1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v35+E4]");
					bool flag19 = (nint)0 == 0;
					object obj43 = !flag19;
					if (obj43 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					flag6 = Grip((XRNode)5);
					int num5 = 1;
				}
			}
			goto IL_04b9;
		}
		goto IL_05bd;
		IL_05bd:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05cb;
		IL_05cb:
		throw new IndexOutOfRangeException();
	}

	private void MenuFists()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0556: Expected Obj, but got I
		//IL_0566: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I4
		//IL_05ae: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_076e: Expected I4, but got Obj
		//IL_04a6: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_05fc: Expected Obj, but got I4
		//IL_04fc: Expected F4, but got I
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected I4, but got Unknown
		//IL_01d0: Expected Obj, but got I4
		//IL_01f7: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I4
		//IL_063d: Expected Obj, but got I
		//IL_064d: Expected Obj, but got I
		//IL_065d: Expected Obj, but got I
		//IL_0677: Expected Obj, but got I8
		//IL_0691: Expected Obj, but got I4
		//IL_034d: Expected Obj, but got I
		//IL_0377: Expected Obj, but got I4
		//IL_0425: Expected Obj, but got I4
		//IL_06c2: Expected Obj, but got I
		//IL_06d2: Expected Obj, but got I
		//IL_06e2: Expected Obj, but got I
		//IL_06fc: Expected Obj, but got I8
		//IL_0716: Expected Obj, but got I4
		//IL_0467: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I4
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected I4, but got Unknown
		//IL_03be: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected I4, but got Unknown
		//IL_03ee: Expected Obj, but got I
		//IL_03fe: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		float deltaTime = Time.deltaTime;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4;
		if ((UnityEngine.Object)obj5 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v36+A0]");
			object obj9 = 0;
			object obj10 = obj9;
			bool flag2 = obj9 == null;
			int num = 0;
			if (flag2)
			{
				goto IL_047e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v38+A9]");
			bool flag3 = (nint)0 == 0;
			flag4 = flag3;
		}
		else
		{
			flag4 = true;
		}
		int frameCount = Time.frameCount;
		object obj11 = frameCount - fistsFrame;
		int frameCount2 = Time.frameCount;
		fistsFrame = frameCount2;
		UnityEngine.Object obj12 = null;
		int num2 = 0;
		int num3;
		while (true)
		{
			bool flag5 = (nint)obj11 > 1;
			int num = (int)obj12;
			if (!flag5)
			{
				bool flag6 = HandTaken(num2);
				bool flag7 = !flag6;
				num = num2;
				num3 = num2;
				if (flag7)
				{
					goto IL_05d4;
				}
			}
			float[] array = armLostAt;
			deltaTime = Time.time;
			if (armLostAt == null)
			{
				break;
			}
			bool flag8 = num2 < array.Length;
			object obj13 = !flag8;
			if (obj13 == null)
			{
				int num4 = armLostAt + num2;
				num3 = num;
				goto IL_05d4;
			}
			throw new IndexOutOfRangeException();
			IL_05d4:
			num2++;
			bool flag9 = num2 != 2;
			obj12 = (UnityEngine.Object)num3;
			if (flag9)
			{
				continue;
			}
			goto IL_018e;
		}
		goto IL_047e;
		IL_047e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_048c;
		IL_04d6:
		bool flag10;
		gripR = flag10;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		FollowHands(0f);
		FreePunching();
		object obj14 = this + 477;
		object obj15 = this + 479;
		obj15 = obj14;
		return;
		IL_02ad:
		bool flag11;
		gripL = flag11;
		if (HandTaken(1))
		{
			int num = 1;
			flag10 = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj16 = 0;
			ex = (NullReferenceException)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v49 (System.NullReferenceException)+E4]");
			bool flag12 = (nint)0 == 0;
			object obj17 = !flag12;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				ex = (NullReferenceException)obj16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v49 (System.NullReferenceException)+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v49 (System.NullReferenceException)+E4]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v14+24]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v14+24]");
			object obj20 = 0 & 0x80000000L;
			bool flag13 = obj20 == null;
			object obj21 = !flag13;
			int num = 1;
			if (obj21 != null)
			{
				goto IL_048c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v49 (System.NullReferenceException)+E4]");
			bool flag14 = (nint)0 == 0;
			object obj22 = !flag14;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj23 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v17+A0]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v18+24]");
				obj19 = 0;
			}
			object obj25 = obj19 >> 1;
			flag10 = (byte)(obj25 & 1) != 0;
			num = 1;
		}
		goto IL_04d6;
		IL_018e:
		if (flag4)
		{
			bool flag15 = HandTaken(0);
			bool flag16 = !flag15;
			object obj26 = !flag16;
			flag11 = false;
			int num;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				object obj27 = 0;
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v31+E4]");
				bool flag17 = (nint)0 == 0;
				object obj29 = !flag17;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj28 = obj27;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v31+A0]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v31+E4]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v21+24]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v21+24]");
				object obj32 = 0 & 0x80000000L;
				bool flag18 = obj32 == null;
				object obj33 = !flag18;
				if (obj33 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v31+E4]");
					bool flag19 = (nint)0 == 0;
					object obj34 = !flag19;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					flag11 = Grip((XRNode)4);
					bool flag20 = (object)this == null;
					object obj35 = !flag20;
					num = 0;
					if (obj35 != null)
					{
						goto IL_02ad;
					}
					goto IL_047e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v31+E4]");
				bool flag21 = (nint)0 == 0;
				object obj36 = !flag21;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj37 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v24+A0]");
					object obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v25+24]");
					obj31 = 0;
				}
				flag11 = (byte)(obj31 & 1) != 0;
			}
			bool flag22 = (object)this == null;
			num = 0;
			if (!flag22)
			{
				goto IL_02ad;
			}
		}
		else
		{
			bool flag23 = (object)this == null;
			int num = num3;
			if (!flag23)
			{
				gripL = false;
				num = num3;
				flag10 = false;
				goto IL_04d6;
			}
		}
		goto IL_047e;
		IL_048c:
		bool flag24 = obj6 == null;
		object obj39 = !flag24;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		flag10 = Grip((XRNode)5);
		goto IL_04d6;
	}

	private void SaySpawnRoom(bool off)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		if (off)
		{
			bool flag = (byte)(~(spawnRoomTold ? 1u : 0u)) != 0;
			object obj = !flag;
			if (obj == null)
			{
				float unscaledTime = Time.unscaledTime;
				float num = unscaledTime - SpawnRoomToldAt__BackingField;
				if ((double)num > 10.0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
					object obj2 = 0;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v4+E4]");
					bool flag2 = (nint)0 == 0;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD110]");
					object title = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD108]");
					object line = 0;
					GillaToast.Show(2, (string)title, (string)line, error: true);
					float unscaledTime2 = Time.unscaledTime;
					SpawnRoomToldAt__BackingField = unscaledTime2;
				}
			}
		}
		spawnRoomTold = off;
	}

	private bool HandTaken(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_017f: Expected I4, but got Obj
		//IL_0087: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = locomotion != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		if (!flag3)
		{
			if ((object)locomotion == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			object obj5 = i - 1;
			bool right = obj5 == null;
			bool flag4 = locomotion.HandOff(right);
			bool flag5 = !flag4;
			object obj6 = !flag5;
			obj4 = 0;
			if (obj6 != null)
			{
				goto IL_0159;
			}
		}
		GillaItem gillaItem = GillaHands.Holding(i);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v5+E4]");
		bool flag6 = (nint)0 == 0;
		object obj8 = !flag6;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gillaItem != null)
		{
			goto IL_0159;
		}
		return GillaToys.HeldIn(i);
		IL_0159:
		return true;
	}

	private void ApeLetGo()
	{
		//IL_0010: Expected Obj, but got I
		//IL_07e2: Expected Obj, but got I4
		//IL_004c: Expected VT, but got I4
		//IL_0055: Expected VT, but got I4
		//IL_0801: Expected Obj, but got I
		//IL_0819: Expected Obj, but got I
		//IL_0831: Expected Obj, but got I
		//IL_0841: Expected Obj, but got I
		//IL_0854: Expected Obj, but got I4
		//IL_085d: Expected Obj, but got I4
		//IL_0866: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_00d2: Expected VT, but got I4
		//IL_00db: Expected VT, but got I4
		//IL_052e: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_0116: Expected VT, but got I4
		//IL_011f: Expected VT, but got I4
		//IL_0563: Expected Obj, but got I8
		//IL_057d: Expected Obj, but got I4
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_05b8: Expected Obj, but got I4
		//IL_05c1: Expected Obj, but got I4
		//IL_05ca: Expected Obj, but got I4
		//IL_05d3: Expected Obj, but got I4
		//IL_05ea: Expected Obj, but got I4
		//IL_05f3: Expected Obj, but got I4
		//IL_05fc: Expected Obj, but got I4
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected I4, but got Unknown
		//IL_0891: Expected Obj, but got I
		//IL_08a9: Expected Obj, but got I
		//IL_08b9: Expected Obj, but got I
		//IL_08cf: Expected VT, but got I4
		//IL_0177: Expected I4, but got I8
		//IL_018f: Expected VT, but got I4
		//IL_0198: Expected VT, but got I4
		//IL_061c: Expected Obj, but got I4
		//IL_0661: Expected Obj, but got I4
		//IL_0690: Expected Obj, but got I
		//IL_06ac: Expected VT, but got I4
		//IL_01e1: Expected I4, but got I8
		//IL_01f9: Expected VT, but got I4
		//IL_0202: Expected VT, but got I4
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected Obj, but got Unknown
		//IL_06e7: Expected Obj, but got I4
		//IL_06f0: Expected Obj, but got I4
		//IL_06f9: Expected Obj, but got I4
		//IL_0702: Expected VT, but got I4
		//IL_070b: Expected Obj, but got I4
		//IL_0732: Expected I4, but got I8
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected I4, but got Unknown
		//IL_0909: Expected Obj, but got I
		//IL_0921: Expected Obj, but got I
		//IL_0931: Expected Obj, but got I
		//IL_0940: Expected VT, but got I4
		//IL_0948: Expected VT, but got I4
		//IL_074b: Expected Obj, but got I8
		//IL_0268: Expected Obj, but got I4
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected Obj, but got Unknown
		//IL_0795: Expected I4, but got I8
		//IL_079e: Expected Obj, but got I4
		//IL_02b5: Expected VT, but got I4
		//IL_02be: Expected VT, but got I4
		//IL_02ef: Expected Obj, but got I8
		//IL_0336: Expected Obj, but got I4
		//IL_0383: Expected VT, but got I4
		//IL_038c: Expected VT, but got I4
		//IL_03ae: Expected I4, but got I8
		//IL_03c6: Expected VT, but got I4
		//IL_03cf: Expected VT, but got I4
		//IL_0427: Expected I4, but got I8
		//IL_043f: Expected VT, but got I4
		//IL_0448: Expected VT, but got I4
		//IL_0491: Expected I4, but got I8
		//IL_04a9: Expected VT, but got I4
		//IL_04b2: Expected VT, but got I4
		//IL_04d4: Expected I4, but got I8
		//IL_04ee: Expected Obj, but got I4
		//IL_04f7: Expected VT, but got I4
		//IL_0500: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)held == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		Vector3 velocity = (Vector3)0;
		Vector3 velocity2 = (Vector3)0;
		if (!flag3)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v34+E4]");
			bool flag4 = (nint)0 == 0;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = (UnityEngine.Object)heldDummy == (UnityEngine.Object)null;
			bool flag6 = !flag5;
			velocity = (Vector3)0;
			velocity2 = (Vector3)0;
			if (!flag6)
			{
				bool hasSecond = HasSecond;
				bool flag7 = !hasSecond;
				object obj6 = !flag7;
				velocity = (Vector3)0;
				velocity2 = (Vector3)0;
				if (obj6 == null)
				{
					int[] array = bodyOf;
					if (array.Length == 0)
					{
						goto IL_07a3;
					}
					int num = (int)(array[0] & 0x80000000L);
					bool flag8 = num == 0;
					velocity = (Vector3)0;
					velocity2 = (Vector3)0;
					if (!flag8)
					{
						if (array.Length == 1)
						{
							goto IL_07a3;
						}
						int num2 = (int)(array[1] & 0x80000000L);
						bool flag9 = num2 == 0;
						velocity = (Vector3)0;
						velocity2 = (Vector3)0;
						if (!flag9)
						{
							GillaPieceId[] array2 = pieceIn;
							if (array2.Length == 0)
							{
								goto IL_07a3;
							}
							object obj7 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v40+E4]");
							bool flag10 = (nint)0 == 0;
							object obj8 = !flag10;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag11 = array2[0] == null;
							bool flag12 = !flag11;
							velocity = (Vector3)0;
							velocity2 = (Vector3)0;
							if (!flag12)
							{
								GillaPieceId[] array3 = pieceIn;
								object obj9 = array3.Length & 0xFFFFFFFEL;
								if (obj9 == null)
								{
									goto IL_07a3;
								}
								object obj10 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v44+E4]");
								bool flag13 = (nint)0 == 0;
								object obj11 = !flag13;
								if (obj11 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag14 = array3[1] == null;
								bool flag15 = !flag14;
								velocity = (Vector3)0;
								velocity2 = (Vector3)0;
								if (!flag15)
								{
									int num3 = (int)(ripBody & 0x80000000L);
									bool flag16 = num3 == 0;
									velocity = (Vector3)0;
									velocity2 = (Vector3)0;
									if (!flag16)
									{
										int[] array4 = deadBody;
										if (array4.Length == 0)
										{
											goto IL_07a3;
										}
										int num4 = (int)(array4[0] & 0x80000000L);
										bool flag17 = num4 == 0;
										velocity = (Vector3)0;
										velocity2 = (Vector3)0;
										if (!flag17)
										{
											if (array4.Length == 1)
											{
												goto IL_07a3;
											}
											int num5 = (int)(array4[1] & 0x80000000L);
											bool flag18 = num5 == 0;
											velocity = (Vector3)0;
											velocity2 = (Vector3)0;
											if (!flag18)
											{
												int num6 = (int)(awaitBody & 0x80000000L);
												bool flag19 = num6 == 0;
												object obj12 = !flag19;
												velocity = (Vector3)0;
												velocity2 = (Vector3)0;
												if (obj12 != null)
												{
													return;
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
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10+A0]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v11+4]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v11+8]");
		object obj18 = 0;
		DropBoth(velocity2);
		object obj19 = 0;
		object obj20 = 1;
		object obj21 = 0;
		while (true)
		{
			int[] array5 = bodyOf;
			bool flag20 = (nint)obj21 < array5.Length;
			object obj22 = !flag20;
			if (obj22 != null)
			{
				break;
			}
			object obj23 = (object)array5 + obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v14+20]");
			object obj24 = 0 & 0x80000000L;
			bool flag21 = obj24 == null;
			object obj25 = !flag21;
			if (obj25 == null)
			{
				object obj26 = obj13;
				bool flag22 = (byte)(obj19 & 1) != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v29+A0]");
				object obj27 = 0;
				obj16 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v30+4]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v30+8]");
				obj18 = 0;
				LetGoBody(flag22, velocity);
				velocity2 = (Vector3)flag22;
			}
			object obj28 = obj20 & 1;
			bool flag23 = obj28 == null;
			object obj29 = !flag23;
			obj19 = 1;
			obj20 = 0;
			obj21 = 1;
			if (obj29 != null)
			{
				continue;
			}
			object obj30 = 0;
			object obj31 = 1;
			object obj32 = 0;
			while (true)
			{
				GillaPieceId[] array6 = pieceIn;
				bool flag24 = (nint)obj32 < array6.Length;
				object obj33 = !flag24;
				if (obj33 != null)
				{
					break;
				}
				object obj34 = obj;
				object obj35 = (object)array6 + obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v17+E4]");
				bool flag25 = (nint)0 == 0;
				object obj36 = !flag25;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v20+20]");
				bool flag26 = (UnityEngine.Object)0 != null;
				bool flag27 = !flag26;
				velocity2 = (Vector3)0;
				if (!flag27)
				{
					object obj37 = obj13;
					bool flag28 = (byte)(obj30 & 1) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v26+A0]");
					object obj38 = 0;
					obj16 = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v27+4]");
					obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v27+8]");
					obj18 = 0;
					LetGoPiece(flag28, (Vector3)0);
					velocity2 = (Vector3)flag28;
				}
				object obj39 = obj31 & 1;
				bool flag29 = obj39 == null;
				object obj40 = !flag29;
				obj30 = 1;
				obj31 = 0;
				velocity = (Vector3)0;
				obj32 = 1;
				if (obj40 == null)
				{
					int[] array7 = deadBody;
					ripBody = -1;
					object obj41 = array7.Length & 0xFFFFFFFEL;
					if (obj41 == null)
					{
						break;
					}
					array7[0] = -1;
					object obj42 = this + 477;
					awaitBody = -1;
					obj42 = 0;
					return;
				}
			}
			break;
		}
		goto IL_07a3;
		IL_07a3:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private Vector3 RealHand(bool right)
	{
		//IL_013d: Expected VT, but got Obj
		//IL_012a: Expected VT, but got I4
		//IL_014b: Expected VT, but got I4
		//IL_00a1: Expected VT, but got I4
		Vector3 vector;
		if (right)
		{
			if ((object)rightTarget != null)
			{
				Vector3 position = rightTarget.position;
				if ((object)rightTarget != null)
				{
					Quaternion rotation = rightTarget.rotation;
					if ((object)locomotion != null)
					{
						vector = (Vector3)0;
						goto IL_013d;
					}
				}
			}
		}
		else if ((object)leftTarget != null)
		{
			Vector3 position2 = leftTarget.position;
			if ((object)leftTarget != null)
			{
				Quaternion rotation2 = leftTarget.rotation;
				if ((object)locomotion != null)
				{
					vector = (Vector3)0;
					goto IL_013d;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
		IL_013d:
		return (Quaternion)0 * vector;
	}

	private bool PulledApart(float drawnFrom, float reallyFrom)
	{
		//IL_020a: Expected I4, but got Obj
		//IL_021a: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I4
		//IL_015a: Invalid comparison between F4 and I4
		//IL_0169: Invalid comparison between F4 and I4
		//IL_017c: Expected Obj, but got F4
		//IL_0189: Expected Obj, but got F4
		//IL_01be: Expected Obj, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_0288: Invalid comparison between F4 and I4
		//IL_029b: Expected Obj, but got F4
		//IL_02a8: Expected Obj, but got F4
		if ((object)leftFollower != null)
		{
			Vector3 position = leftFollower.position;
			if ((object)rightFollower != null)
			{
				Vector3 position2 = rightFollower.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float reallyApart = ReallyApart;
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					float num = drawnFrom - drawnFrom;
					float num2 = reallyFrom - reallyFrom;
					object obj5 = default;
					object obj4 = obj5 - obj5;
					float num3 = num * num;
					float num4 = num2 * num2;
					float num5 = num3 + num4;
					object obj6 = obj4 * obj4;
					float num6 = (float)obj6 + num5;
					float num7 = reallyApart - reallyFrom;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num8 = num6 - drawnFrom;
					float num9 = num8 - num7;
					bool flag2 = num9 < 0f;
					bool flag3 = num9 == 0f;
					object obj7 = num8 ^ num7;
					object obj8 = num8 ^ num9;
					object obj9 = obj7 & obj8;
					bool flag4 = (nint)obj9 < 0;
					bool flag5 = flag2 == flag4;
					object obj10 = !flag3;
					object obj11 = flag5 & obj10;
					object obj12 = ~obj11;
					float num10 = ((obj12 != null) ? num7 : num8);
					Vector3 localScale = transform.localScale;
					float num11 = pullApart * num8;
					float num12 = num10 - num11;
					bool flag6 = num12 < 0f;
					object obj13 = num10 ^ num11;
					object obj14 = num10 ^ num12;
					object obj15 = obj13 & obj14;
					bool flag7 = (nint)obj15 < 0;
					return flag6 == flag7;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe void Grabbing(float reach)
	{
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_011b: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_06ec: Expected Obj, but got I4
		//IL_0730: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got I4
		//IL_0b6d: Expected Obj, but got I4
		//IL_0795: Expected Obj, but got I4
		//IL_07af: Invalid comparison between F4 and I4
		//IL_07c0: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I4
		//IL_0bb0: Expected Obj, but got I4
		//IL_090c: Expected Obj, but got I4
		//IL_0926: Invalid comparison between F4 and I4
		//IL_0937: Expected Obj, but got I4
		//IL_0c94: Expected Obj, but got I4
		//IL_0bed: Expected Obj, but got I4
		//IL_0d4a: Expected Obj, but got I4
		//IL_0c32: Expected Obj, but got I4
		//IL_0829: Expected I4, but got I8
		//IL_021a: Expected Obj, but got I
		//IL_1693: Expected Obj, but got I4
		//IL_0d06: Expected Obj, but got I4
		//IL_0997: Expected I4, but got I8
		//IL_0d3c: Expected Obj, but got I4
		//IL_0c58: Expected Obj, but got I4
		//IL_0878: Expected Obj, but got I4
		//IL_09dd: Expected Obj, but got I4
		//IL_158b: Expected Obj, but got I4
		//IL_0dbe: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I
		//IL_0280: Expected Obj, but got I4
		//IL_0a1e: Expected Obj, but got I4
		//IL_0a61: Expected Obj, but got I4
		//IL_0a99: Expected Obj, but got I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02e2: Expected Obj, but got I4
		//IL_0ade: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I4
		//IL_0b04: Expected Obj, but got I4
		//IL_0340: Expected Obj, but got I4
		//IL_0332: Expected Obj, but got I4
		//IL_03dd: Expected Obj, but got I4
		//IL_16ca: Expected VT, but got I4
		//IL_04f1: Expected Obj, but got I4
		//IL_04e3: Expected Obj, but got I4
		//IL_050d: Expected Obj, but got I4
		//IL_0eb7: Expected VT, but got I4
		//IL_04ff: Expected Obj, but got I4
		//IL_047a: Expected Obj, but got I4
		//IL_052f: Expected Obj, but got I4
		//IL_0456: Expected Obj, but got I4
		//IL_0521: Expected Obj, but got I4
		//IL_04ac: Expected Obj, but got I4
		//IL_054b: Expected Obj, but got I4
		//IL_053d: Expected Obj, but got I4
		//IL_0e7e: Expected Obj, but got I4
		//IL_0572: Expected Obj, but got I4
		//IL_05b7: Expected Obj, but got I4
		//IL_05d2: Expected Obj, but got I4
		//IL_0609: Expected Obj, but got I8
		//IL_0623: Expected Obj, but got I4
		//IL_1356: Expected VT, but got Ref
		//IL_066d: Expected Obj, but got I4
		//IL_138f: Expected Obj, but got I
		//IL_13b9: Expected Obj, but got I4
		//IL_0efd: Expected Obj, but got I
		//IL_0f11: Expected Obj, but got I
		//IL_0f3b: Expected Obj, but got I4
		//IL_0f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f63: Expected VT, but got Unknown
		//IL_0f91: Expected Obj, but got I
		//IL_1436: Expected Obj, but got I
		//IL_147e: Expected Obj, but got I4
		//IL_14ba: Expected F4, but got I
		//IL_14d9: Expected F4, but got I
		//IL_1505: Expected Obj, but got I4
		//IL_0ff5: Expected Obj, but got I
		//IL_1052: Expected Obj, but got I4
		//IL_107a: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Expected I4, but got Unknown
		//IL_1181: Expected Obj, but got I4
		//IL_16fa: Expected Obj, but got I
		//IL_11c6: Expected Obj, but got I
		//IL_1239: Expected Obj, but got I4
		//IL_1141: Invalid comparison between F4 and I4
		//IL_1743: Expected Obj, but got I4
		//IL_1765: Expected Obj, but got I4
		//IL_129b: Expected F4, but got I
		//IL_129b: Expected F4, but got I
		SlabInHand();
		if (HasSecond)
		{
			Both(reach);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)heldDummy != (UnityEngine.Object)null)
		{
			HoldingDummy(reach);
			return;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = this + 672;
		bool flag3 = (UnityEngine.Object)held == (UnityEngine.Object)null;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		object obj8 = 0;
		if (obj7 != null)
		{
			goto IL_0699;
		}
		object obj9 = obj6;
		Vector3 velocity;
		bool flag19;
		object obj35;
		float num4;
		double num5;
		bool flag30;
		ApePart apePart = default;
		float num7;
		if (obj6 != null)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v84+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v34+40]");
			bool flag6 = (UnityEngine.Object)0 == null;
			bool flag7 = !flag6;
			object obj12 = !flag7;
			obj8 = 0;
			if (obj12 != null)
			{
				goto IL_0699;
			}
			object obj13 = obj6;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v35+40]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v35+40]");
				if ((nint)0 != 0)
				{
					object obj15 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v89+E4]");
					bool flag8 = (nint)0 == 0;
					object obj16 = !flag8;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X21_v16+30]");
					bool flag9 = (UnityEngine.Object)0;
					bool flag10 = !flag9;
					obj8 = 0;
					if (!flag10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X21_v16+30]");
						if ((nint)0 == 0)
						{
							goto IL_151f;
						}
						ArgumentNullException ex = new ArgumentNullException();
						object obj17 = ex & 1;
						bool flag11 = obj17 == null;
						obj8 = 0;
						if (!flag11)
						{
							bool flag12 = !heldRight;
							object obj18 = !flag12;
							object obj19 = ~obj18;
							if (obj19 == null)
							{
								object obj20 = 477 + 1;
							}
							else
							{
								object obj20 = 477;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v840 @ X8_v41]");
							if ((nint)0 != 0)
							{
								float time = Time.time;
								float num = time - heldSince;
								if (num > neverHeldAfter)
								{
									if (obj6 == null)
									{
										goto IL_151f;
									}
									if (!((NetworkApe)obj6).Busy)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
										velocity = (Vector3)0;
										goto IL_0ebc;
									}
								}
								bool flag13 = (byte)(~(ripping ? 1u : 0u)) != 0;
								object obj21 = !flag13;
								if (obj21 == null)
								{
									if (obj6 == null)
									{
										goto IL_151f;
									}
									if (((NetworkApe)obj6).Busy)
									{
										bool flag14 = Slamming();
										bool flag15 = !flag14;
										object obj22 = !flag15;
										if (obj22 != null)
										{
											return;
										}
									}
									bool flag16 = (byte)(~(ripping ? 1u : 0u)) != 0;
									object obj23 = !flag16;
									if (obj23 == null)
									{
										bool flag17 = Punching();
										bool flag18 = !flag17;
										object obj24 = !flag18;
										if (obj24 != null)
										{
											return;
										}
									}
								}
								flag19 = heldRight;
								if (!heldRight)
								{
									object obj25 = 477 + 1;
								}
								else
								{
									object obj25 = 477;
								}
								if (!flag19)
								{
									object obj26 = 200;
								}
								else
								{
									object obj26 = 192;
								}
								if (!flag19)
								{
									object obj27 = 479 + 1;
								}
								else
								{
									object obj27 = 479;
								}
								if (!flag19)
								{
									object obj28 = 192;
								}
								else
								{
									object obj28 = 200;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v1004 @ X9_v16]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v1029 @ X11_v6]");
									bool flag20 = (nint)0 == 0;
									object obj29 = !flag20;
									if (obj29 == null)
									{
										int[] array = bodyOf;
										if (bodyOf != null)
										{
											object obj30 = (flag19 ? 1 : 0) ^ 1;
											bool flag21 = (nint)obj30 < array.Length;
											object obj31 = !flag21;
											if (obj31 != null)
											{
												goto IL_152d;
											}
											object obj32 = (object)bodyOf + obj30;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1078 @ X11_v11+20]");
											object obj33 = 0 & 0x80000000L;
											bool flag22 = obj33 == null;
											object obj34 = !flag22;
											if (obj34 == null)
											{
												goto IL_0632;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v415 @ X10_v9]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v415 @ X10_v9]");
												Vector3 position = ((Transform)0).position;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
												obj35 = 0;
												object obj36 = obj35;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1128 @ X0_v123+E4]");
												bool flag23 = (nint)0 == 0;
												object obj37 = !flag23;
												if (obj37 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Vector3 hand = (Vector3)(this + 720);
												ref float away = default;
												bool flag24 = Part((NetworkApe)obj6, hand, num, out var part, out away);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v415 @ X10_v9]");
												Vector3 position2 = ((Transform)0).position;
												object obj38 = obj6;
												if (obj6 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v66+68]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v66+68]");
														Vector3 position3 = ((Transform)0).position;
														if (obj6 != null)
														{
															Vector3 middleFromEyes = ((NetworkApe)obj6).MiddleFromEyes;
															float num2 = num + num;
															float num3 = neverHeldAfter + neverHeldAfter;
															object obj39 = (int)apePart + (int)apePart;
															num4 = num - num2;
															num5 = (double)neverHeldAfter - (double)num3;
															apePart = (ApePart)(apePart - obj39);
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
															object obj40 = obj6;
															if (obj6 != null)
															{
																if (num4 < reach)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v67+6E8]");
																	if ((nint)0 >= (nint)punchesBeforeRip)
																	{
																		bool flag26;
																		if (flag24)
																		{
																			num5 = (double)part * 1.5;
																			float num6 = num4 - (float)num5;
																			bool flag25 = num6 < 0f;
																			apePart = part;
																			flag26 = flag25;
																		}
																		else
																		{
																			flag26 = true;
																		}
																		ripWhole = flag26;
																		goto IL_16de;
																	}
																}
																ripWhole = false;
																bool flag27 = !flag24;
																object obj41 = !flag27;
																if (obj41 == null)
																{
																	flag19 = heldRight;
																	num7 = reach;
																	goto IL_0632;
																}
																goto IL_16de;
															}
														}
													}
												}
											}
										}
										goto IL_151f;
									}
								}
								bool flag28 = !ripping;
								Bodies(reach, flag28);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v1004 @ X9_v16]");
								bool flag29 = (nint)0 == 0;
								object obj42 = !flag29;
								flag30 = flag28;
								if (obj42 == null)
								{
									ripping = false;
									return;
								}
								goto IL_12b2;
							}
							Bodies(reach, grab: false);
							if (!heldRight)
							{
							}
							if (!heldRight)
							{
							}
							if (!heldRight)
							{
							}
							velocity = (Vector3)0;
							goto IL_0ebc;
						}
					}
					goto IL_0699;
				}
			}
		}
		goto IL_151f;
		IL_160d:
		Bodies(reach, flag30);
		goto IL_12b2;
		IL_16de:
		ripping = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v415 @ X10_v9]");
		Vector3 position4 = ((Transform)0).position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v508 @ X9_v18]");
		if ((nint)0 == 0)
		{
			goto IL_151f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v508 @ X9_v18]");
		Vector3 position5 = ((Transform)0).position;
		float num8 = num4 - num4;
		double num9 = num5 - num5;
		apePart -= apePart;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
		ripStart = num8;
		float reallyApart = ReallyApart;
		object obj43 = obj35;
		ripStartReal = reallyApart;
		object obj44 = 17285120 + 1288;
		XRNode node = (heldRight ? ((XRNode)4) : ((XRNode)5));
		bool flag31 = !ripWhole;
		object obj45 = 17285120 + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ X0_v142+E4]");
		bool flag32 = (nint)0 == 0;
		object obj46 = !flag32;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ X8_v72+v1143 @ Z_v21 (System.Boolean)*4]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X8_v74+v1143 @ Z_v21 (System.Boolean)*4]");
		Buzz(node, num10, 0f);
		num7 = reach;
		flag30 = false;
		goto IL_160d;
		IL_0ebc:
		Drop(velocity);
		return;
		IL_151f:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_152d;
		IL_12b2:
		if (~(ripping ? 1u : 0u) != 0 || !PulledApart(ripStart, ripStartReal))
		{
			return;
		}
		if (~(ripWhole ? 1u : 0u) == 0)
		{
			RipHeld();
			return;
		}
		if ((object)held != null)
		{
			object obj47 = default;
			held.RPC_Tear((byte)ripPart, (RpcInfo)(&obj47));
			NetworkApe networkApe = held;
			if ((object)held != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
				object obj48 = 0;
				object obj49 = obj48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X0_v105+E4]");
				bool flag33 = (nint)0 == 0;
				object obj50 = !flag33;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num11 = GillaCorpse.Part(ripPart);
				awaitPart = num11;
				awaitBody = networkApe.owner;
				bool flag34 = (byte)((heldRight ? 1u : 0u) ^ 1u) != 0;
				awaitRight = flag34;
				float time2 = Time.time;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				object obj51 = 0;
				float num12 = time2 + 1f;
				object obj52 = obj51;
				awaitUntil = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1183 @ X0_v110+E4]");
				bool flag35 = (nint)0 == 0;
				object obj53 = !flag35;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				Buzz((XRNode)4, 1f, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				Buzz((XRNode)5, 1f, 0f);
				ripping = false;
				bool flag36 = ripPart == 0;
				object obj54 = !flag36;
				if (obj54 == null)
				{
					HeldDied();
				}
				return;
			}
		}
		goto IL_151f;
		IL_0b43:
		object obj55 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X0_v25+E4]");
		bool flag37 = (nint)0 == 0;
		object obj56 = !flag37;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag38 = (UnityEngine.Object)obj6 == null;
		bool flag39 = !flag38;
		object obj57 = 0;
		UnityEngine.Object obj58 = null;
		float num13;
		if (!flag39)
		{
			object obj59 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v54+E4]");
			bool flag40 = (nint)0 == 0;
			object obj60 = !flag40;
			if (obj60 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag41 = (UnityEngine.Object)heldDummy == (UnityEngine.Object)null;
			bool flag42 = !flag41;
			obj57 = 0;
			obj58 = null;
			if (!flag42)
			{
				TakeSlabs(reach);
				obj57 = 0;
				obj58 = null;
				num13 = reach;
			}
		}
		object obj61 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X0_v30+E4]");
		bool flag43 = (nint)0 == 0;
		object obj62 = !flag43;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool grab;
		if ((UnityEngine.Object)obj6 == null)
		{
			object obj63 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X0_v48+E4]");
			bool flag44 = (nint)0 == 0;
			object obj64 = !flag44;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			grab = (UnityEngine.Object)heldDummy == (UnityEngine.Object)null;
			object obj65 = 0;
		}
		else
		{
			object obj65 = 0;
			grab = false;
		}
		Bodies(reach, grab);
		object obj66 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v36+E4]");
		bool flag45 = (nint)0 == 0;
		object obj67 = !flag45;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)held == (UnityEngine.Object)null)
		{
			object obj68 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X0_v40+E4]");
			bool flag46 = (nint)0 == 0;
			object obj69 = !flag46;
			if (obj69 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)heldDummy == (UnityEngine.Object)null)
			{
				FreePunching();
			}
		}
		return;
		IL_0699:
		held = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ripping = false;
		bool flag47 = (byte)(~(gripL ? 1u : 0u)) != 0;
		num13 = reach;
		if (!flag47)
		{
			bool flag48 = (byte)(~(wasGripL ? 1u : 0u)) != 0;
			object obj70 = !flag48;
			num13 = reach;
			if (obj70 == null)
			{
				num13 = Time.time;
				closedL = num13;
			}
		}
		if (~(gripR ? 1u : 0u) == 0)
		{
			bool flag49 = (byte)(~(wasGripR ? 1u : 0u)) != 0;
			object obj71 = !flag49;
			if (obj71 == null)
			{
				num13 = Time.time;
				closedR = num13;
			}
		}
		bool flag50 = (byte)(~(gripL ? 1u : 0u)) != 0;
		bool flag51 = false;
		if (!flag50)
		{
			float time3 = Time.time;
			num13 = time3 - closedL;
			float num14 = graspFor;
			bool flag52 = num13 < graspFor;
			object obj72 = !flag52;
			float num15 = num13 - graspFor;
			bool flag53 = num15 == 0f;
			object obj73 = !flag53;
			object obj74 = obj72 & obj73;
			flag51 = false;
			if (obj74 == null)
			{
				int[] array2 = bodyOf;
				if (bodyOf == null)
				{
					goto IL_151f;
				}
				int num16 = (int)(array2[0] & 0x80000000L);
				bool flag54 = num16 == 0;
				flag51 = false;
				if (!flag54)
				{
					bool flag55 = SlabIn(right: false);
					bool flag56 = !flag55;
					object obj75 = !flag56;
					flag51 = false;
					if (obj75 == null)
					{
						PickUp(right: false, reach);
						flag51 = false;
						num13 = reach;
					}
				}
			}
		}
		if (~(gripR ? 1u : 0u) == 0)
		{
			float time4 = Time.time;
			num13 = time4 - closedR;
			float num14 = graspFor;
			bool flag57 = num13 < graspFor;
			object obj76 = !flag57;
			float num17 = num13 - graspFor;
			bool flag58 = num17 == 0f;
			object obj77 = !flag58;
			object obj78 = obj76 & obj77;
			if (obj78 == null)
			{
				int[] array3 = bodyOf;
				if (bodyOf == null)
				{
					goto IL_151f;
				}
				if ((int)(array3[1] & 0x80000000L) != 0)
				{
					bool flag59 = SlabIn(right: true);
					bool flag60 = !flag59;
					object obj79 = !flag60;
					flag51 = true;
					if (obj79 == null)
					{
						object obj80 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X0_v64+E4]");
						bool flag61 = (nint)0 == 0;
						object obj81 = !flag61;
						if (obj81 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag62 = (UnityEngine.Object)obj6 == null;
						bool flag63 = !flag62;
						obj8 = 0;
						if (!flag63)
						{
							object obj82 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X0_v71+E4]");
							bool flag64 = (nint)0 == 0;
							object obj83 = !flag64;
							if (obj83 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag65 = (UnityEngine.Object)heldDummy == (UnityEngine.Object)null;
							bool flag66 = !flag65;
							obj8 = 0;
							if (!flag66)
							{
								PickUp(right: true, reach);
								obj8 = 0;
								flag51 = true;
								num13 = reach;
								goto IL_0b43;
							}
						}
						bool flag67 = TakeSecond(right: true, reach);
						flag51 = true;
						num13 = reach;
					}
				}
			}
		}
		goto IL_0b43;
		IL_152d:
		throw new IndexOutOfRangeException();
		IL_0632:
		bool right = !flag19;
		bool flag68 = TakeSecond(right, reach);
		bool flag69 = !flag68;
		object obj84 = !flag69;
		if (obj84 == null)
		{
			bool flag70 = !ripping;
			flag30 = flag70;
			goto IL_160d;
		}
	}

	private void ShowPull()
	{
		//IL_0015: Expected Obj, but got I
		//IL_058f: Expected I4, but got I8
		//IL_05a9: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		//IL_05e6: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I4
		//IL_0376: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_0339: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_0690: Expected Obj, but got I4
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_0528: Expected Obj, but got I4
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I4
		//IL_0682: Expected Obj, but got I4
		//IL_04c0: Expected Obj, but got I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_06ac: Expected Obj, but got I4
		//IL_04b2: Expected Obj, but got I4
		//IL_0551: Expected Obj, but got I4
		//IL_055a: Expected Obj, but got I4
		//IL_0568: Expected Obj, but got I4
		//IL_0401: Expected Obj, but got I4
		//IL_097e: Expected Obj, but got I
		//IL_098e: Expected Obj, but got I
		//IL_09b0: Expected Obj, but got I4
		//IL_069e: Expected Obj, but got I4
		//IL_04dc: Expected Obj, but got I4
		//IL_03f3: Expected Obj, but got I4
		//IL_08e8: Expected Obj, but got I
		//IL_08f8: Expected Obj, but got I
		//IL_091a: Expected Obj, but got I4
		//IL_04ce: Expected Obj, but got I4
		//IL_041d: Expected Obj, but got I4
		//IL_08ba: Expected Obj, but got I4
		//IL_040f: Expected Obj, but got I4
		//IL_070c: Expected Obj, but got I4
		//IL_045a: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I
		//IL_0742: Invalid comparison between F4 and I
		//IL_0766: Expected Obj, but got I
		//IL_0790: Expected Obj, but got I4
		//IL_07ea: Expected F4, but got I
		//IL_0804: Expected F4, but got I
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj = 0;
		Vector3 localScale = transform.localScale;
		object obj2 = default;
		float num = pullApart * (float)obj2;
		bool flag = (byte)(~(ripping ? 1u : 0u)) != 0;
		UnityEngine.Object obj3 = null;
		if (flag)
		{
			goto IL_057b;
		}
		bool flag2 = (byte)(~(ripWhole ? 1u : 0u)) != 0;
		object obj5 = default;
		object obj4 = obj5;
		UnityEngine.Object obj6 = null;
		if (!flag2)
		{
			goto IL_0077;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v31+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)held != (UnityEngine.Object)null;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		object obj11 = 0;
		UnityEngine.Object obj12 = null;
		if (obj10 == null)
		{
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v47+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = (UnityEngine.Object)heldDummy != (UnityEngine.Object)null;
			bool flag8 = !flag7;
			obj11 = 0;
			obj12 = null;
			if (flag8)
			{
				bool flag9 = (byte)(~(ripping ? 1u : 0u)) != 0;
				obj5 = 0;
				obj3 = null;
				if (!flag9)
				{
					bool flag10 = (byte)(~(ripWhole ? 1u : 0u)) != 0;
					object obj15 = !flag10;
					obj4 = 0;
					obj6 = null;
					obj5 = 0;
					obj3 = null;
					if (obj15 != null)
					{
						goto IL_0077;
					}
				}
				goto IL_057b;
			}
		}
		object obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v36+E4]");
		bool flag11 = (nint)0 == 0;
		object obj17 = !flag11;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = ((!((UnityEngine.Object)held != (UnityEngine.Object)null)) ? ((object)(heldDummy + 128)) : ((object)(held + 168)));
		bool right = !heldRight;
		Transform transform2 = Holding(right);
		object obj19 = obj;
		if (!heldRight)
		{
			object obj20 = 200;
		}
		else
		{
			object obj20 = 192;
		}
		if (!heldRight)
		{
			object obj21 = 192;
		}
		else
		{
			object obj21 = 200;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v456 @ X11_v4]");
		Transform transform3 = (Transform)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v472 @ X9_v9]");
		Transform b = (Transform)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v28+E4]");
		bool flag12 = (nint)0 == 0;
		object obj22 = !flag12;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform grip = transform2;
		ApePart part = ripPart;
		GillaCorpse gillaCorpse = null;
		Dismemberment ape = (Dismemberment)obj18;
		goto IL_0928;
		IL_0077:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v54+E4]");
		bool flag13 = (nint)0 == 0;
		object obj25 = !flag13;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = (UnityEngine.Object)held != (UnityEngine.Object)null;
		bool flag15 = !flag14;
		object obj26 = !flag15;
		object obj27 = 0;
		UnityEngine.Object obj28 = null;
		if (obj26 == null)
		{
			object obj29 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v70+E4]");
			bool flag16 = (nint)0 == 0;
			object obj30 = !flag16;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag17 = (UnityEngine.Object)heldDummy != (UnityEngine.Object)null;
			bool flag18 = !flag17;
			obj27 = 0;
			obj28 = null;
			obj5 = 0;
			obj3 = null;
			if (flag18)
			{
				goto IL_057b;
			}
		}
		object obj31 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v59+E4]");
		bool flag19 = (nint)0 == 0;
		object obj32 = !flag19;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object ape2 = ((!((UnityEngine.Object)held != (UnityEngine.Object)null)) ? ((object)(heldDummy + 128)) : ((object)(held + 168)));
		bool right2 = !heldRight;
		Transform transform4 = Holding(right2);
		object obj33 = obj;
		if (!heldRight)
		{
			object obj34 = 200;
		}
		else
		{
			object obj34 = 192;
		}
		if (!heldRight)
		{
			object obj35 = 192;
		}
		else
		{
			object obj35 = 200;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v41+E4]");
		bool flag20 = (nint)0 == 0;
		object obj36 = !flag20;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v490 @ X11_v7]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v505 @ X9_v15]");
		GillaPull.MineMiddle((Dismemberment)ape2, transform4, (Transform)num2, (Transform)0, num);
		Transform transform5 = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v505 @ X9_v15]");
		grip = (Transform)0;
		float num3 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v490 @ X11_v7]");
		part = (ApePart)0;
		gillaCorpse = (GillaCorpse)(object)transform4;
		goto IL_06e2;
		IL_06e2:
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v10+E4]");
		bool flag21 = (nint)0 == 0;
		object obj38 = !flag21;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float mineStrain = GillaPull.MineStrain;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		if (!(mineStrain < 0f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj39 = 0;
			object obj40 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v13+E4]");
			bool flag22 = (nint)0 == 0;
			object obj41 = !flag22;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num4 = mineStrain * mineStrain;
			float amp = num4 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			Buzz((XRNode)4, amp, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			Buzz((XRNode)5, amp, 0f);
		}
		return;
		IL_0928:
		GillaPull.Mine(ape, gillaCorpse, part, grip, transform3, b, num);
		transform5 = transform3;
		num3 = num;
		goto IL_06e2;
		IL_057b:
		int num5 = (int)(ripBody & 0x80000000L);
		bool flag23 = num5 == 0;
		object obj42 = !flag23;
		if (obj42 == null && ripBodyPart != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj43 = 0;
			object obj44 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v20+E4]");
			bool flag24 = (nint)0 == 0;
			object obj45 = !flag24;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCorpse gillaCorpse2 = GillaCorpse.Find(ripBody);
			Transform transform6 = Holding(ripBodyRight);
			object obj46 = obj;
			ApePart apePart = (ApePart)(ripBodyPart - 1);
			if (!ripBodyRight)
			{
				object obj47 = 192;
			}
			else
			{
				object obj47 = 200;
			}
			if (!ripBodyRight)
			{
				object obj48 = 200;
			}
			else
			{
				object obj48 = 192;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v364 @ X10_v4]");
			transform3 = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v406 @ X8_v20]");
			b = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v26+E4]");
			bool flag25 = (nint)0 == 0;
			object obj49 = !flag25;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			grip = transform6;
			part = apePart;
			gillaCorpse = gillaCorpse2;
			ape = null;
			goto IL_0928;
		}
	}

	private unsafe bool SlamHit(Vector3 middle, Vector3 eyes, out RaycastHit hit, out Vector3 swing)
	{
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Expected Obj, but got Unknown
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected Obj, but got Unknown
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected Obj, but got Unknown
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected Obj, but got Unknown
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected Obj, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected Obj, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected Obj, but got Unknown
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Expected Obj, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected Obj, but got Unknown
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Expected Obj, but got Unknown
		//IL_0823: Expected native int or pointer, but got VT
		//IL_0844: Expected Obj, but got I4
		//IL_0866: Expected Obj, but got I4
		//IL_0888: Expected Obj, but got I4
		//IL_08aa: Expected Obj, but got I4
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected Obj, but got Unknown
		//IL_08d7: Expected Obj, but got I4
		//IL_0946: Expected Obj, but got I4
		//IL_09cf: Invalid comparison between F4 and I4
		//IL_09de: Invalid comparison between F4 and I4
		//IL_09f1: Expected Obj, but got F4
		//IL_09fe: Expected Obj, but got F4
		//IL_0a33: Expected Obj, but got I4
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Expected Obj, but got Unknown
		//IL_0096: Expected F4, but got Obj
		//IL_0a70: Expected Obj, but got I4
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected Obj, but got Unknown
		//IL_0089: Expected F4, but got Obj
		//IL_00b0: Expected F4, but got Obj
		//IL_0aad: Expected Obj, but got I4
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected Obj, but got Unknown
		//IL_00a3: Expected F4, but got Obj
		//IL_00ca: Expected F4, but got Obj
		//IL_0ad9: Expected native int or pointer, but got VT
		//IL_0ae6: Expected native int or pointer, but got VT
		//IL_0af3: Expected native int or pointer, but got VT
		//IL_00bd: Expected F4, but got Obj
		//IL_0b96: Expected Obj, but got I
		//IL_0bc0: Expected Obj, but got I4
		//IL_0795: Expected I4, but got Obj
		//IL_0222: Invalid comparison between F4 and I
		//IL_0246: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I4
		//IL_0b27: Expected Obj, but got I4
		//IL_0bde: Expected Obj, but got I
		//IL_0bf7: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I4
		//IL_0390: Expected Obj, but got I
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_044d: Expected Obj, but got I8
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_0498: Expected Obj, but got I
		//IL_0515: Expected Obj, but got I
		//IL_0544: Expected VT, but got I4
		//IL_054d: Expected Obj, but got I4
		//IL_0b73: Expected Obj, but got I4
		//IL_057c: Expected Obj, but got I4
		//IL_05e7: Expected VT, but got I8
		//IL_060a: Expected Obj, but got I
		//IL_06ef: Expected Obj, but got I
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected Obj, but got Unknown
		//IL_072a: Expected VT, but got I4
		//IL_074f: Expected VT, but got I8
		//IL_0645: Expected Obj, but got F4
		//IL_067e: Expected Obj, but got I
		object obj = this + 520;
		object obj2 = this + 524;
		object obj3 = this + 592;
		object obj4 = this + 596;
		object obj5 = this + 508;
		object obj6 = this + 512;
		object obj7 = this + 580;
		object obj8 = this + 584;
		object obj9 = this + 528;
		object obj10 = this + 516;
		object obj11 = this + 600;
		_ = 0;
		_ = 0;
		((Vector3*)(nint)middle)->x = 0f;
		bool flag = !heldRight;
		object obj12 = !flag;
		object obj13 = ~obj12;
		if (obj13 != null)
		{
			obj = obj5;
		}
		object obj14 = !flag;
		object obj15 = ~obj14;
		if (obj15 != null)
		{
			obj3 = obj7;
		}
		object obj16 = !flag;
		object obj17 = ~obj16;
		if (obj17 != null)
		{
			obj4 = obj8;
		}
		object obj18 = !flag;
		object obj19 = ~obj18;
		if (obj19 != null)
		{
			obj2 = obj6;
		}
		object obj20 = this + 588;
		object obj21 = !flag;
		object obj22 = ~obj21;
		object obj23 = ((obj22 != null) ? obj10 : obj9);
		float num = (float)obj3 * (float)obj3;
		float num2 = (float)obj4 * (float)obj4;
		bool flag2 = !heldRight;
		float num3 = (float)obj * (float)obj;
		float num4 = (float)obj2 * (float)obj2;
		object obj24 = !flag2;
		object obj25 = ~obj24;
		object obj26 = ((obj25 != null) ? obj20 : obj11);
		float num5 = num2 + num;
		float num6 = (float)obj23 * (float)obj23;
		float num7 = num4 + num3;
		float num8 = (float)obj26 * (float)obj26;
		float num9 = num8 + num5;
		float num10 = num6 + num7;
		float num11 = num9 - num10;
		bool flag3 = num11 < 0f;
		bool flag4 = num11 == 0f;
		object obj27 = num9 ^ num10;
		object obj28 = num9 ^ num11;
		object obj29 = obj27 & obj28;
		bool flag5 = (nint)obj29 < 0;
		bool flag6 = flag3 == flag5;
		object obj30 = !flag4;
		object obj31 = flag6 & obj30;
		object obj32 = ~obj31;
		float num12 = ((obj32 != null) ? ((float)obj) : ((float)obj3));
		bool flag7 = flag3 == flag5;
		object obj33 = !flag4;
		object obj34 = flag7 & obj33;
		object obj35 = ~obj34;
		float num13 = ((obj35 != null) ? ((float)obj2) : ((float)obj4));
		bool flag8 = flag3 == flag5;
		object obj36 = !flag4;
		object obj37 = flag8 & obj36;
		object obj38 = ~obj37;
		float num14 = ((obj38 != null) ? ((float)obj23) : ((float)obj26));
		((Vector3*)(nint)eyes)->x = num12;
		((Vector3*)(nint)eyes)->y = num13;
		((Vector3*)(nint)eyes)->z = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj39 = 0;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v4+E4]");
		bool flag9 = (nint)0 == 0;
		object obj41 = !flag9;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			float num15 = num12 * num12;
			float num16 = num13 * num13;
			float num17 = num15 + num16;
			float num18 = num14 * num14;
			float num19 = num17 + num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Vector3 localScale = transform.localScale;
			float num20 = slamSwing * num19;
			if (!(num19 < num20))
			{
				Transform transform2 = base.transform;
				if ((object)transform2 == null)
				{
					goto IL_0787;
				}
				Vector3 localScale2 = transform2.localScale;
				double num21 = (double)num19 * 30.0;
				if (!((double)num19 > num21))
				{
					float time = Time.time;
					float num22 = time - heldSince;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
					if (!(num22 < 0f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
						object obj42 = 0;
						object obj43 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v18+E4]");
						bool flag10 = (nint)0 == 0;
						object obj44 = !flag10;
						if (obj44 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj45 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X0_v22+E4]");
						bool flag11 = (nint)0 == 0;
						object obj46 = !flag11;
						if (obj46 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj45 = obj42;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X0_v22+A0]");
						object obj47 = 0;
						float deltaTime = Time.deltaTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
						object obj48 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						if (!heldRight)
						{
							object obj49 = 192;
						}
						else
						{
							object obj49 = 200;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v619 @ X8_v24]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v619 @ X8_v24]");
							Vector3 position = ((Transform)0).position;
							object obj50 = default;
							if (obj50 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v25+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v25+18]");
									bool flag12 = (nint)0 == 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
									_ = 0;
									if (!flag12)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v25+18]");
										bool flag13 = (nint)0 < (nint)2;
										object obj51 = !flag13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v25+18]");
										object obj52 = -2;
										bool flag14 = obj52 == null;
										object obj53 = ~obj51;
										object obj54 = obj53 | flag14;
										if (obj54 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v25+18]");
											if ((nint)0 < (nint)1)
											{
												goto IL_075d;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											float num23 = eyes.z / num19;
											float num24 = num19 * deltaTime;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v25+18]");
											object obj55 = 0 & 0xFFFFFFFFL;
											object obj56 = obj50 + 40;
											object obj57 = default;
											float num25 = eyes.x / (float)obj57;
											float num26 = heldReach;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v19+C]");
											float num27 = num26 * 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
											object obj58 = 0;
											float num28 = num27;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC4C]");
											float num29 = num28 + 0f;
											float num30 = num23;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
											float num31 = num30 * 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
											float num32 = num24 * 1.5f;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											float num33 = num29;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
											float num34 = num33 + 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
											object obj59 = 0;
											float num35 = num25 * num24;
											float num36 = num32 + num34;
											Vector3 vector = eyes;
											Vector3 vector2 = (Vector3)0;
											object obj60 = 0;
											float num37 = default;
											float num44 = default;
											while (true)
											{
												bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj60) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj55);
												object obj61 = !flag15;
												if (obj61 != null)
												{
													break;
												}
												object obj62 = obj59;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v31+E4]");
												bool flag16 = (nint)0 == 0;
												object obj63 = !flag16;
												if (obj63 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X24_v7-8]");
												num34 = 0f - num35;
												num24 = (float)obj56 - num31;
												bool flag17 = Physics.SphereCast(middle, num34, (Vector3)4294961403L, out *(RaycastHit*)1, num37, 0, (QueryTriggerInteraction)(int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref swing));
												bool flag18 = !flag17;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
												obj58 = 0;
												num32 = num37;
												if (!flag18)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [middle @ X1 (UnityEngine.Vector3)+10]");
													float num38 = 0f * eyes.y;
													object obj64 = 0f - num38;
													float num39 = eyes.x;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [middle @ X1 (UnityEngine.Vector3)+C]");
													float num40 = num39 * 0f;
													num24 = eyes.z;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [middle @ X1 (UnityEngine.Vector3)+14]");
													obj58 = 0;
													float num41 = (float)obj64 - num40;
													float num42 = eyes.z;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [middle @ X1 (UnityEngine.Vector3)+14]");
													float num43 = num42 * 0f;
													num34 = num41 - num43;
													bool flag19 = !(num34 < num20);
													num32 = num20;
													if (flag19)
													{
														return true;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v25+18]");
												obj55 = 0;
												obj60++;
												obj56 += 12;
												object obj65 = obj60;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v25+18]");
												bool flag20 = (nint)obj65 < 0;
												vector = (Vector3)1;
												num8 = num36;
												num7 = num23;
												num10 = num44;
												vector2 = (Vector3)4294961403L;
												if (flag20)
												{
													continue;
												}
												goto IL_075d;
											}
										}
									}
								}
								IndexOutOfRangeException ex = new IndexOutOfRangeException();
							}
						}
						goto IL_0787;
					}
				}
			}
			goto IL_075d;
		}
		goto IL_0787;
		IL_0787:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_075d:
		return false;
	}

	private unsafe bool Slamming()
	{
		//IL_01f0: Expected I4, but got Obj
		//IL_0085: Expected VT, but got Ref
		//IL_0085: Expected VT, but got Ref
		//IL_00c0: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0138: Expected VT, but got Ref
		//IL_0138: Expected VT, but got Ref
		//IL_0138: Expected VT, but got I4
		//IL_0138: Expected VT, but got Ref
		//IL_0148: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I4
		//IL_01ae: Expected F4, but got I
		//IL_01cd: Expected F4, but got I
		Transform transform = Holding(heldRight);
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			NetworkApe networkApe = held;
			if ((object)held != null && (object)networkApe.head != null)
			{
				Vector3 position2 = networkApe.head.position;
				object obj = default;
				object obj2 = default;
				ref RaycastHit reference = default;
				ref Vector3 reference2 = default;
				bool flag = SlamHit((Vector3)(&obj), (Vector3)(&obj2), out reference, out reference2);
				if (flag)
				{
					if ((object)held == null)
					{
						goto IL_01e2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v10+A0]");
					object obj5 = 0;
					object obj6 = obj2 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v11+18]");
					object obj8 = default;
					object obj7 = 0 * obj8;
					object obj9 = obj7 - obj6;
					object obj10 = default;
					held.RPC_Slam((Vector3)(&obj10), (Vector3)0, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), (RpcInfo)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					Buzz((XRNode)4, 1f, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					Buzz((XRNode)5, 1f, 0f);
					HeldDied();
				}
				return flag;
			}
		}
		goto IL_01e2;
		IL_01e2:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe bool SlammingDummy(GillaDummy d)
	{
		//IL_0426: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_0145: Expected VT, but got Ref
		//IL_0145: Expected VT, but got Ref
		//IL_0195: Expected Obj, but got I4
		//IL_01dd: Expected F4, but got I4
		//IL_039e: Expected Obj, but got I
		//IL_0490: Expected Obj, but got I
		//IL_04b2: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I
		//IL_051a: Expected VT, but got I4
		//IL_052a: Expected Obj, but got I
		//IL_0554: Expected Obj, but got I4
		//IL_03e0: Expected F4, but got I
		//IL_03ff: Expected F4, but got I
		//IL_0254: Expected Obj, but got I4
		//IL_029c: Expected F4, but got I4
		//IL_0303: Expected Obj, but got I
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_0361: Expected Obj, but got I4
		//IL_046b: Expected VT, but got I4
		//IL_046b: Expected VT, but got Obj
		Transform transform = Holding(heldRight);
		object obj;
		Transform transform2;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			if ((object)d != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (d.head != null)
				{
					transform2 = d.head;
					bool flag2 = (object)d.head == null;
					object obj4 = !flag2;
					if (obj4 != null)
					{
						goto IL_0122;
					}
				}
				else
				{
					transform2 = Holding(heldRight);
					if ((object)transform2 != null)
					{
						goto IL_0122;
					}
				}
			}
		}
		goto IL_0418;
		IL_0122:
		Vector3 position2 = transform2.position;
		object obj5 = default;
		object obj6 = default;
		ref RaycastHit hit = default;
		ref Vector3 swing = default;
		bool flag3 = SlamHit((Vector3)(&obj5), (Vector3)(&obj6), out hit, out swing);
		if (flag3)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v17+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = d.tearing != null;
			bool flag6 = !flag5;
			float num = 0f;
			object obj10 = default;
			object obj9 = obj10;
			object obj12 = default;
			object obj11 = obj12;
			if (!flag6)
			{
				Dismemberment tearing = d.tearing;
				if ((object)d.tearing == null)
				{
					goto IL_0418;
				}
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v33+E4]");
				bool flag7 = (nint)0 == 0;
				object obj14 = !flag7;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = tearing.bloodMaterial != null;
				bool flag9 = !flag8;
				num = 0f;
				obj9 = obj10;
				obj11 = obj12;
				if (!flag9)
				{
					Dismemberment tearing2 = d.tearing;
					if ((object)d.tearing == null)
					{
						goto IL_0418;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
					object obj17 = default;
					object obj16 = obj17 * 0;
					object obj18 = default;
					float num2 = (float)obj18 * 0f;
					object obj19 = obj15;
					num = (float)obj5 + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v37+E4]");
					bool flag10 = (nint)0 == 0;
					object obj20 = !flag10;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Blood.Burst((Vector3)tearing2.bloodMaterial, (Vector3)0, null, num);
					obj9 = obj17;
					object obj21 = default;
					obj11 = obj21;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			object obj22 = (nint)0 * (nint)0;
			float num3 = (float)obj6 * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v15+A0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v16+18]");
			float num4 = 0f * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v16+20]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			object obj26 = num5 * 0;
			float num6 = num4 - num3;
			object obj27 = obj26 - obj22;
			d.Blasted((Vector3)0, 0, apart: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v24+E4]");
			bool flag11 = (nint)0 == 0;
			object obj30 = !flag11;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			Buzz((XRNode)4, 1f, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			Buzz((XRNode)5, 1f, 0f);
			DummyDied(d);
		}
		return flag3;
		IL_0418:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe bool Punching()
	{
		//IL_0899: Expected I4, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0a15: Expected Obj, but got I
		//IL_0a2d: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I
		//IL_012f: Expected VT, but got Obj
		//IL_0149: Expected VT, but got I
		//IL_0159: Expected Obj, but got I
		//IL_08da: Expected Obj, but got VT
		//IL_08e7: Expected Obj, but got VT
		//IL_097d: Invalid comparison between F4 and I4
		//IL_098c: Invalid comparison between F4 and I4
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected Obj, but got Unknown
		//IL_09a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Expected Obj, but got Unknown
		//IL_09e1: Expected Obj, but got I4
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_00af: Expected VT, but got Obj
		//IL_00c9: Expected VT, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_0a8c: Expected VT, but got I4
		//IL_0a9b: Invalid comparison between F4 and I4
		//IL_0abf: Expected Obj, but got I
		//IL_0ae9: Expected Obj, but got I4
		//IL_0243: Expected Obj, but got I
		//IL_026d: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I4
		//IL_02e6: Expected Obj, but got I4
		//IL_0310: Expected Obj, but got I4
		//IL_0b29: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I4
		//IL_03bd: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I
		//IL_042a: Expected Obj, but got I4
		//IL_039d: Expected Obj, but got I4
		//IL_03a5: Expected Obj, but got I4
		//IL_048f: Expected Obj, but got I
		//IL_0534: Expected VT, but got Ref
		//IL_0534: Expected VT, but got Ref
		//IL_0552: Expected Obj, but got I4
		//IL_0b47: Expected Obj, but got I
		//IL_0b5f: Expected Obj, but got I
		//IL_0632: Expected VT, but got I4
		//IL_0632: Expected VT, but got Ref
		//IL_0642: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I
		//IL_05d3: Expected VT, but got Ref
		//IL_05d3: Expected VT, but got Ref
		//IL_0bba: Expected Obj, but got I4
		//IL_06a1: Expected F4, but got I
		//IL_06c5: Expected Obj, but got I4
		//IL_0bea: Expected Obj, but got I4
		//IL_072b: Expected F4, but got I
		//IL_0764: Expected Obj, but got I
		//IL_0784: Expected Obj, but got I
		//IL_07ae: Expected Obj, but got I4
		//IL_0831: Expected Obj, but got I4
		//IL_0823: Expected Obj, but got I
		//IL_0872: Expected VT, but got Ref
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			object obj = this + 508;
			Vector3 localScale = transform.localScale;
			bool flag = !heldRight;
			if (Fist(flag))
			{
				object obj2;
				object obj3;
				object obj4;
				Vector3 vector;
				Vector3 vector2;
				Vector3 vector3;
				Vector3 vector4;
				object obj5;
				if (~(heldRight ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+204]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+210]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+24C]");
					obj4 = 0;
					vector = (Vector3)obj;
					vector2 = velR;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X24_v2+48]");
					vector3 = (Vector3)0;
					vector4 = realVelR;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+258]");
					obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+210]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+204]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+258]");
					obj4 = 0;
					vector = velR;
					vector2 = (Vector3)obj;
					vector3 = realVelR;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X24_v2+48]");
					vector4 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+24C]");
					obj5 = 0;
				}
				object obj6 = obj2 - obj3;
				object obj7 = vector - vector2;
				object obj8 = vector3 - vector4;
				object obj9 = obj4 - obj5;
				object obj10 = obj7 * obj7;
				object obj11 = obj8 * obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				object obj12 = obj7 * obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj13 = obj5 + obj10;
				object obj14 = obj9 * obj9;
				object obj15 = obj11 + obj14;
				float num = (float)obj12 + (float)obj13;
				float num2 = (float)obj15 - num;
				bool flag2 = num2 < 0f;
				bool flag3 = num2 == 0f;
				object obj16 = obj15 ^ num;
				object obj17 = obj15 ^ num2;
				object obj18 = obj16 & obj17;
				bool flag4 = (nint)obj18 < 0;
				bool flag5 = flag2 == flag4;
				object obj19 = !flag3;
				object obj20 = flag5 & obj19;
				object obj21 = ~obj20;
				object obj22 = ((obj21 != null) ? obj6 : obj9);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
				float deltaTime = Time.deltaTime;
				Vector3 vector5 = Swung((Vector3)flag, num);
				if (!(punchIn > 0f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj23 = 0;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X0_v21+E4]");
					bool flag6 = (nint)0 == 0;
					object obj25 = !flag6;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num3 = num * num;
					object obj27 = default;
					object obj26 = obj27 * obj27;
					float num4 = num3 + (float)obj26;
					object obj28 = obj22 * obj22;
					float num5 = (float)obj28 + num4;
					object obj29 = default;
					float num6 = (float)obj29 * punchSwing;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					if (!(num5 < num6))
					{
						NetworkApe networkApe = held;
						if ((object)held != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj30 = 0;
							object obj31 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v23+E4]");
							bool flag7 = (nint)0 == 0;
							object obj32 = !flag7;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag8 = networkApe.tearing == null;
							bool flag9 = !flag8;
							object obj33 = !flag9;
							if (obj33 != null)
							{
								goto IL_0836;
							}
							object obj34 = obj30;
							if (!heldRight)
							{
								object obj35 = 200;
							}
							else
							{
								object obj35 = 192;
							}
							if (!heldRight)
							{
								object obj36 = 192;
							}
							else
							{
								object obj36 = 200;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v27+E4]");
							bool flag10 = (nint)0 == 0;
							object obj37 = !flag10;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (worn != null)
							{
								if ((object)worn == null)
								{
									goto IL_088b;
								}
								bool flag11 = !heldRight;
								Vector3 vector6 = worn.FistFromHand(flag11);
								object obj38 = 0;
								UnityEngine.Object obj39 = (UnityEngine.Object)flag11;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
								object obj38 = 0;
								UnityEngine.Object obj39 = null;
							}
							NetworkApe networkApe2 = held;
							if ((object)held != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
								object obj40 = 0;
								object obj41 = obj40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X0_v32+E4]");
								bool flag12 = (nint)0 == 0;
								object obj42 = !flag12;
								if (obj42 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								GillaWounds gillaWounds = GillaWounds.On(networkApe2.tearing);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v311 @ X8_v21]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v311 @ X8_v21]");
									Vector3 position = ((Transform)0).position;
									bool flag13 = !heldRight;
									bool right = !flag13;
									Vector3 vector7 = RealHand(flag13);
									Vector3 vector8 = RealHand(right);
									if ((object)gillaWounds != null)
									{
										float num7 = num5 + num5;
										float num8 = num7 - num5;
										float num9 = num5 + num8;
										byte section = default;
										object obj43 = default;
										ref Vector3 point = default;
										bool flag14 = gillaWounds.Hit((Vector3)(&section), num9, (Vector3)(&obj43), out *(GoreSection*)null, out point);
										bool flag15 = !flag14;
										object obj44 = !flag15;
										object obj45 = obj22;
										object obj46 = obj27;
										if (obj44 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v132 @ X10_v4]");
											if ((nint)0 == 0)
											{
												goto IL_088b;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v132 @ X10_v4]");
											Vector3 position2 = ((Transform)0).position;
											float reach = num5 + num9;
											bool flag16 = gillaWounds.Hit((Vector3)(&section), reach, (Vector3)(&obj43), out *(GoreSection*)null, out point);
											bool flag17 = !flag16;
											obj45 = obj22;
											obj46 = obj27;
											if (flag17)
											{
												goto IL_0836;
											}
										}
										punchIn = punchEvery;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
										object obj47 = 0;
										object obj48 = obj47;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v27+A0]");
										object obj49 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v28+8]");
										_ = 0;
										if ((object)held != null)
										{
											object obj50 = default;
											held.RPC_Punch(section, (Vector3)(&obj50), (RpcInfo)0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
											object obj51 = 0;
											XRNode node = (heldRight ? ((XRNode)4) : ((XRNode)5));
											object obj52 = obj51;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X0_v47+E4]");
											bool flag18 = (nint)0 == 0;
											object obj53 = !flag18;
											if (obj53 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
											Buzz(node, 1f, 0f);
											object obj54 = obj51;
											bool flag19 = !heldRight;
											object obj55 = !flag19;
											object obj56 = ~obj55;
											XRNode node2 = ((obj56 != null) ? ((XRNode)4) : ((XRNode)5));
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X0_v50+E4]");
											bool flag20 = (nint)0 == 0;
											object obj57 = !flag20;
											if (obj57 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
											Buzz(node2, 0.5f, 0f);
											NetworkApe networkApe3 = held;
											if ((object)held != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
												object obj58 = 0;
												object obj59 = obj30;
												object obj60 = obj58;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X9_v12+A0]");
												object obj61 = 0;
												UnityEngine.Object obj62 = (UnityEngine.Object)obj61;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v53+E4]");
												bool flag21 = (nint)0 == 0;
												object obj63 = !flag21;
												if (obj63 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												object obj64;
												if ((UnityEngine.Object)obj61 != null)
												{
													if (obj61 == null)
													{
														goto IL_088b;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X20_v13 (UnityEngine.Object)+80]");
													obj64 = 0;
												}
												else
												{
													obj64 = 3;
												}
												if (networkApe3.punches < (nint)obj64)
												{
													goto IL_0836;
												}
												if ((object)held != null)
												{
													object obj65 = default;
													held.RPC_Finished((RpcInfo)(&obj65));
													HeldDied();
													return true;
												}
											}
										}
									}
								}
							}
						}
						goto IL_088b;
					}
				}
				goto IL_0836;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj66 = 0;
			object obj67 = obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v9+A0]");
			object obj68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v10+8]");
			_ = 0;
			return false;
		}
		goto IL_088b;
		IL_0836:
		return false;
		IL_088b:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe void FreePunching()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected F4, but got I
		//IL_006b: Expected F4, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Expected Obj, but got Unknown
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got I4
		//IL_017d: Invalid comparison between F4 and I4
		//IL_01a5: Expected I4, but got I8
		//IL_0206: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I8
		//IL_029e: Expected Obj, but got I4
		//IL_02e5: Expected Obj, but got I4
		//IL_0314: Expected Obj, but got I
		//IL_0332: Expected Obj, but got I4
		//IL_033b: Expected VT, but got I4
		//IL_0d04: Expected Obj, but got I4
		//IL_040a: Expected VT, but got I4
		//IL_0475: Expected Obj, but got I4
		//IL_04dd: Expected VT, but got I4
		//IL_0525: Expected Obj, but got I4
		//IL_0d67: Expected Obj, but got I
		//IL_0d6f: Expected F4, but got Obj
		//IL_0d7f: Expected F4, but got I
		//IL_0d8f: Expected F4, but got I
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Expected Obj, but got Unknown
		//IL_05f8: Expected Obj, but got I4
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05ea: Expected Obj, but got I4
		//IL_063b: Expected Obj, but got I
		//IL_069c: Expected VT, but got I4
		//IL_069c: Expected VT, but got Ref
		//IL_069c: Expected VT, but got Ref
		//IL_06cf: Expected Obj, but got I4
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		//IL_0782: Expected VT, but got I4
		//IL_0782: Expected VT, but got I4
		//IL_07a5: Expected Obj, but got I4
		//IL_07c8: Expected F4, but got Obj
		//IL_07d8: Expected F4, but got I
		//IL_07e8: Expected F4, but got I
		//IL_09b7: Expected Obj, but got I4
		//IL_09ec: Expected Obj, but got I
		//IL_0a01: Expected Obj, but got I
		//IL_0a11: Expected Obj, but got I
		//IL_0a3b: Expected Obj, but got I4
		//IL_083f: Expected Obj, but got I4
		//IL_08b2: Expected Obj, but got I4
		//IL_0831: Expected Obj, but got I4
		//IL_0b32: Expected F4, but got I
		//IL_0b32: Expected VT, but got I4
		//IL_085b: Expected Obj, but got I4
		//IL_0a99: Expected F4, but got I
		//IL_0a99: Expected VT, but got I4
		//IL_0aac: Expected VT, but got I4
		//IL_08e7: Expected Obj, but got I
		//IL_08fc: Expected Obj, but got I
		//IL_084d: Expected Obj, but got I4
		//IL_0b6d: Expected VT, but got Ref
		//IL_0b6d: Expected VT, but got I4
		//IL_0b6d: Expected VT, but got Ref
		//IL_0b7d: Expected Obj, but got I
		//IL_0b87: Expected Obj, but got I4
		//IL_0b8f: Expected F4, but got Obj
		//IL_0b9f: Expected F4, but got I
		//IL_0baf: Expected F4, but got I
		//IL_0bb8: Expected F4, but got I4
		//IL_0bd1: Expected F4, but got I4
		//IL_0be1: Expected VT, but got Ref
		//IL_0ad5: Expected F4, but got Obj
		//IL_0ae5: Expected F4, but got I
		//IL_0aee: Expected VT, but got I4
		//IL_0afe: Expected F4, but got I
		//IL_0b06: Expected I4, but got Obj
		//IL_0877: Expected Obj, but got I4
		//IL_0f85: Expected Obj, but got I4
		//IL_0e9b: Expected VT, but got I4
		//IL_0e9b: Expected VT, but got I4
		//IL_0e9b: Expected VT, but got I4
		//IL_0eb7: Expected Obj, but got I4
		//IL_0eed: Expected Obj, but got I4
		//IL_0f2e: Expected VT, but got I4
		//IL_0f36: Expected I4, but got Obj
		//IL_0869: Expected Obj, but got I4
		//IL_0973: Expected VT, but got I4
		//IL_1052: Expected Obj, but got I4
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj2 = 0;
			Vector3 localScale = transform.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			float num = 0f;
			float num2 = 0f;
			byte b = 0;
			float num4 = default;
			float num3 = num4;
			object obj5 = 40;
			object obj6 = 0;
			ref GoreSection reference = default;
			ref Vector3 point = default;
			object obj36 = default;
			float num27 = default;
			object obj38 = default;
			object obj53 = default;
			float num39 = default;
			while (true)
			{
				Vector3[] array = armSwung;
				if (armSwung == null)
				{
					break;
				}
				bool flag = (nint)obj6 < array.Length;
				object obj7 = !flag;
				if (obj7 == null)
				{
					object obj8 = (object)armSwung + obj5;
					object obj9 = obj5 - 52;
					bool right = obj9 == null;
					if (Fist(right))
					{
						object obj10 = obj5 - 52;
						bool right2 = obj10 == null;
						bool flag2 = SlabIn(right2);
						bool flag3 = !flag2;
						object obj11 = !flag3;
						if (obj11 == null)
						{
							num3 = punchIn;
							if (!(punchIn > 0f) && (int)(ripBody & 0x80000000L) != 0)
							{
								int[] array2 = bodyOf;
								if (bodyOf == null)
								{
									break;
								}
								bool flag4 = (nint)obj6 < array2.Length;
								object obj12 = !flag4;
								if (obj12 != null)
								{
									goto IL_0cac;
								}
								object obj13 = (object)bodyOf + obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v12+20]");
								object obj14 = 0 & 0x80000000L;
								if (obj14 != null)
								{
									GillaPieceId[] array3 = pieceIn;
									if (pieceIn == null)
									{
										break;
									}
									bool flag5 = (nint)obj6 < array3.Length;
									object obj15 = !flag5;
									if (obj15 != null)
									{
										goto IL_0cac;
									}
									object obj16 = obj;
									object obj17 = (object)pieceIn + obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X0_v15+E4]");
									bool flag6 = (nint)0 == 0;
									object obj18 = !flag6;
									if (obj18 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v15+20]");
									bool flag7 = (UnityEngine.Object)0 != null;
									bool flag8 = !flag7;
									object obj19 = !flag8;
									Vector3 vector = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v15+20]");
									XRNode xRNode = (XRNode)0;
									if (obj19 == null)
									{
										object obj20 = obj3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X0_v20+E4]");
										bool flag9 = (nint)0 == 0;
										object obj21 = !flag9;
										if (obj21 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-8]");
										float num5 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-8]");
										float num6 = num5 * 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-4]");
										float num7 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-4]");
										float num8 = num7 * 0f;
										float num9 = num6 + num8;
										float num10 = (float)obj8 * (float)obj8;
										num3 = num9 + num10;
										float num11 = num4 * freePunchSwing;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										bool flag10 = num3 < num11;
										vector = (Vector3)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v15+20]");
										xRNode = (XRNode)0;
										if (!flag10)
										{
											float time = Time.time;
											float[] array4 = armLostAt;
											if (armLostAt == null)
											{
												break;
											}
											bool flag11 = (nint)obj6 < array4.Length;
											object obj22 = !flag11;
											if (obj22 != null)
											{
												goto IL_0cac;
											}
											object obj23 = (object)armLostAt + obj6;
											float num12 = punchSwingLasts;
											float num13 = time;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v19+20]");
											num3 = num13 - 0f;
											num11 = punchSwingLasts + punchSwingLasts;
											bool flag12 = num3 < num11;
											vector = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v15+20]");
											xRNode = (XRNode)0;
											if (!flag12)
											{
												object obj24 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X0_v23+E4]");
												bool flag13 = (nint)0 == 0;
												object obj25 = !flag13;
												if (obj25 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												float num14;
												float num16;
												float num15;
												if (worn != null)
												{
													if ((object)worn == null)
													{
														break;
													}
													object obj26 = obj5 - 52;
													bool right3 = obj26 == null;
													Vector3 vector2 = worn.FistFromHand(right3);
													num14 = num12;
													num15 = num11;
													num16 = num3;
												}
												else
												{
													object obj27 = obj4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v42+A0]");
													object obj28 = 0;
													num16 = (float)obj28;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v43+4]");
													num15 = 0f;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v43+8]");
													num14 = 0f;
												}
												object obj29 = obj5 - 52;
												bool right4 = obj29 == null;
												if ((nint)obj5 == 52)
												{
													object obj30 = 200;
												}
												else
												{
													object obj30 = 192;
												}
												Vector3 vector3 = RealHand(right4);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v208 @ X22_v8]");
												if ((nint)0 == 0)
												{
													break;
												}
												float num17 = num14 + num12;
												float num18 = num15 + num11;
												float num19 = num16 + num3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v208 @ X22_v8]");
												Vector3 position = ((Transform)0).position;
												float num20 = num16 + num3;
												float num21 = num15 + num18;
												float num22 = num14 + num17;
												float num23 = num4 * punchReach;
												NetworkApe networkApe = Punchable((Vector3)(&b), (Vector3)(&num2), num19, (Vector3)0, out reference, out point);
												object obj31 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v23+E4]");
												bool flag14 = (nint)0 == 0;
												object obj32 = !flag14;
												if (obj32 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												object obj35;
												float num26;
												object obj37;
												float num28;
												float num29;
												float num30;
												float num34;
												float num35;
												float num36;
												if ((UnityEngine.Object)networkApe == (UnityEngine.Object)null)
												{
													object obj33 = obj5 - 52;
													bool flag15 = obj33 == null;
													Vector3 vector4 = RealHand(flag15);
													float num24 = num15 + num18;
													num15 = num16 + num19;
													float num25 = num14 + num17;
													bool flag16 = PunchCorpse((Vector3)flag15, (Vector3)0, num15);
													bool flag17 = !flag16;
													object obj34 = !flag17;
													obj35 = obj36;
													num26 = num27;
													obj37 = obj38;
													num22 = (float)obj8;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-4]");
													num21 = 0f;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-8]");
													num28 = 0f;
													num29 = num25;
													num30 = num;
													if (obj34 == null)
													{
														if ((nint)obj5 == 52)
														{
															object obj39 = 600;
														}
														else
														{
															object obj39 = 588;
														}
														if ((nint)obj5 == 52)
														{
															object obj40 = 596;
														}
														else
														{
															object obj40 = 584;
														}
														obj37 = (((nint)obj5 != 52) ? ((object)580) : ((object)592));
														float deltaTime = Time.deltaTime;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v654 @ X10_v5]");
														float num31 = 0f * deltaTime;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v713 @ X9_v20]");
														float num32 = 0f * deltaTime;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v735 @ X8_v38]");
														float num33 = 0f * deltaTime;
														num3 = num15 - num31;
														num11 = num24 - num32;
														num29 = num25 - num33;
														bool flag18 = PunchDoor((Vector3)flag15, (Vector3)0, (Vector3)0, num3);
														bool flag19 = !flag18;
														obj35 = 592;
														num26 = num4;
														num22 = num25;
														num21 = num24;
														num28 = num15;
														num30 = num;
														obj36 = 592;
														num27 = num4;
														obj38 = obj37;
														num34 = num25;
														num35 = num24;
														num36 = num15;
														num23 = num4;
														num12 = num29;
														vector = (Vector3)0;
														xRNode = (XRNode)networkApe;
														if (flag19)
														{
															goto IL_0c61;
														}
													}
													Vector3[] array5 = armSwung;
													punchIn = punchEvery;
													if (armSwung == null)
													{
														break;
													}
													bool flag20 = (nint)obj6 < array5.Length;
													object obj41 = !flag20;
													if (obj41 != null)
													{
														goto IL_0cac;
													}
													object obj42 = obj4;
													object obj43 = (object)armSwung + obj5;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X8_v34+A0]");
													object obj44 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v35+8]");
													obj43 = 0;
													object obj45 = obj2;
													xRNode = (((nint)obj5 != 52) ? ((XRNode)4) : ((XRNode)5));
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X0_v63+E4]");
													bool flag21 = (nint)0 == 0;
													object obj46 = !flag21;
													if (obj46 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													num23 = num4;
													num11 = 0.25f;
													vector = (Vector3)0;
													num3 = 1f;
													byte b2 = (flag15 ? ((byte)1) : ((byte)0));
												}
												else
												{
													Vector3[] array6 = armSwung;
													if (armSwung == null)
													{
														break;
													}
													bool flag22 = (nint)obj6 < array6.Length;
													object obj47 = !flag22;
													if (obj47 != null)
													{
														goto IL_0cac;
													}
													object obj48 = obj4;
													object obj49 = (object)armSwung + obj5;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X8_v27+A0]");
													object obj50 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X8_v28+8]");
													obj49 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
													obj2 = 0;
													object obj51 = obj2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X0_v41+E4]");
													bool flag23 = (nint)0 == 0;
													object obj52 = !flag23;
													if (obj52 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													if (MenuShoves)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-8]");
														Vector3 vector5 = Shove(networkApe, (Vector3)0, 0f);
														bool flag24 = MenuShove(networkApe, (Vector3)0);
														num28 = num4;
														float num25 = num14;
														float num24 = num15;
														num29 = (float)obj8;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-4]");
														float num37 = 0f;
														vector = (Vector3)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-8]");
														float num38 = 0f;
														byte b2 = (byte)(int)networkApe;
													}
													else
													{
														punchIn = punchEvery;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-8]");
														Vector3 vector6 = Shove(networkApe, (Vector3)0, 0f);
														if ((object)networkApe == null)
														{
															break;
														}
														networkApe.RPC_PunchDown(b, (Vector3)(&obj53), (Vector3)0, (RpcInfo)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
														obj2 = 0;
														obj53 = 0;
														num22 = (float)obj8;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-4]");
														num21 = 0f;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v8-8]");
														num28 = 0f;
														float num25 = 0f;
														num15 = num2;
														float num24 = num39;
														num29 = 0f;
														float num37 = num39;
														vector = (Vector3)(&obj53);
														float num38 = num2;
														byte b2 = b;
													}
													object obj54 = obj2;
													xRNode = (((nint)obj5 != 52) ? ((XRNode)4) : ((XRNode)5));
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X0_v44+E4]");
													bool flag25 = (nint)0 == 0;
													object obj55 = !flag25;
													if (obj55 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													obj35 = obj36;
													num26 = num27;
													obj37 = obj38;
													num11 = num;
													num3 = 1f;
													num30 = num;
												}
												Buzz(xRNode, num3, num11);
												obj36 = obj35;
												num27 = num26;
												obj38 = obj37;
												num34 = num22;
												num35 = num21;
												num36 = num28;
												num12 = num29;
												num = num30;
											}
										}
									}
								}
							}
						}
					}
					goto IL_0c61;
				}
				goto IL_0cac;
				IL_0c61:
				obj5 += 12;
				obj6++;
				if ((nint)obj5 == 64)
				{
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0cac;
		IL_0cac:
		throw new IndexOutOfRangeException();
	}

	private unsafe bool PunchCorpse(Vector3 fist, Vector3 swing, float size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I4
		//IL_051e: Expected Obj, but got I
		//IL_0540: Expected Obj, but got I4
		//IL_05db: Expected Obj, but got I
		//IL_0605: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_04ce: Expected I4, but got Obj
		//IL_0149: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I
		//IL_0578: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_0288: Expected Obj, but got I
		//IL_02c3: Expected Obj, but got I4
		//IL_02f2: Expected VT, but got Ref
		//IL_033d: Expected Obj, but got I4
		//IL_05b0: Expected Obj, but got I4
		//IL_0402: Expected Obj, but got I4
		//IL_0447: Expected VT, but got Ref
		//IL_0447: Expected VT, but got Ref
		//IL_04a4: Expected VT, but got I4
		//IL_04a4: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v7+A0]");
		object obj8 = 0;
		UnityEngine.Object obj9 = (UnityEngine.Object)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (IsMonster)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = (UnityEngine.Object)obj8 == null;
			bool flag6 = !flag5;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				if (obj8 == null)
				{
					goto IL_04c0;
				}
				object obj15 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v18+E4]");
				bool flag7 = (nint)0 == 0;
				object obj16 = !flag7;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X19_v3 (UnityEngine.Object)+40]");
				bool flag8 = (UnityEngine.Object)0 == null;
				bool flag9 = !flag8;
				object obj17 = !flag9;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X19_v3 (UnityEngine.Object)+40]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X19_v3 (UnityEngine.Object)+40]");
					if ((nint)0 == 0)
					{
						goto IL_04c0;
					}
					object obj19 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v23+E4]");
					bool flag10 = (nint)0 == 0;
					object obj20 = !flag10;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X21_v10+30]");
					if ((bool)(UnityEngine.Object)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X21_v10+30]");
						if ((nint)0 == 0)
						{
							goto IL_04c0;
						}
						ArgumentNullException ex = new ArgumentNullException();
						object obj21 = ex & 1;
						if (obj21 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
							object obj22 = 0;
							object obj23 = obj22;
							object obj24 = default;
							float num = punchReach * (float)obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v29+E4]");
							bool flag11 = (nint)0 == 0;
							object obj25 = !flag11;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GillaCorpse gillaCorpse = default;
							if (GillaCorpse.Nearest((Vector3)(&gillaCorpse), size, out var _, out *(int*)null))
							{
								object obj26 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v33+E4]");
								bool flag12 = (nint)0 == 0;
								object obj27 = !flag12;
								if (obj27 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag13 = gillaCorpse != null;
								bool flag14 = !flag13;
								UnityEngine.Object obj28 = null;
								UnityEngine.Object obj29 = null;
								if (!flag14)
								{
									if ((object)gillaCorpse == null)
									{
										goto IL_04c0;
									}
									GillaWounds punchable = gillaCorpse.Punchable;
									obj28 = null;
									obj29 = punchable;
								}
								object obj30 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v38+E4]");
								bool flag15 = (nint)0 == 0;
								object obj31 = !flag15;
								if (obj31 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag16 = obj29 == null;
								bool flag17 = !flag16;
								object obj32 = !flag17;
								if (obj32 == null)
								{
									if ((object)obj29 != null)
									{
										byte section = default;
										object obj33 = default;
										ref Vector3 point = default;
										if (!((GillaWounds)obj29).Hit((Vector3)(&section), size, (Vector3)(&obj33), out *(GoreSection*)null, out point))
										{
											goto IL_04b2;
										}
										if ((object)gillaCorpse != null)
										{
											object obj34 = default;
											((NetworkApe)obj8).RPC_PunchCorpse(gillaCorpse.Id__BackingField, section, (Vector3)(&obj34), (RpcInfo)0);
											return true;
										}
									}
									goto IL_04c0;
								}
							}
						}
					}
				}
			}
		}
		goto IL_04b2;
		IL_04b2:
		return false;
		IL_04c0:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	public unsafe bool MenuShove(NetworkApe who, Vector3 going)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0065: Invalid comparison between F4 and I4
		//IL_00dd: Expected I4, but got Obj
		//IL_00b3: Expected VT, but got I4
		//IL_00b3: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)who == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null && !(punchIn > 0f))
		{
			punchIn = 2f;
			if ((object)who != null)
			{
				object obj5 = default;
				who.RPC_Shove((Vector3)(&obj5), (RpcInfo)0);
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	private bool Fist(bool right)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+40]");
		if ((nint)0 != 0)
		{
			return true;
		}
		bool flag2;
		if (right)
		{
			if (~(gripR ? 1u : 0u) != 0)
			{
				goto IL_00a7;
			}
			flag2 = wasGripR;
		}
		else
		{
			if (~(gripL ? 1u : 0u) != 0)
			{
				goto IL_00a7;
			}
			flag2 = wasGripL;
		}
		bool flag3 = !flag2;
		return !flag3;
		IL_00a7:
		return false;
	}

	private void ArmSwing(int i, Vector3 real, float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0740: Expected Obj, but got I4
		//IL_07b6: Expected Obj, but got I
		//IL_07d0: Expected Obj, but got I8
		//IL_0168: Expected VT, but got I4
		//IL_0797: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_022c: Expected Obj, but got I4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_028a: Expected VT, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_02d2: Expected Obj, but got I4
		//IL_02e1: Expected Obj, but got I4
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0322: Expected Obj, but got I4
		//IL_038d: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I4
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_045b: Expected Obj, but got I4
		//IL_04bc: Expected Obj, but got I4
		//IL_04cb: Expected Obj, but got I4
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_05ed: Expected Obj, but got I4
		//IL_05fc: Expected Obj, but got I4
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected Obj, but got Unknown
		//IL_0528: Expected Obj, but got I4
		//IL_0570: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I
		//IL_05be: Invalid comparison between F4 and Obj
		//IL_063d: Expected Obj, but got I4
		//IL_06a6: Expected Obj, but got I4
		//IL_06b5: Expected Obj, but got I4
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected Obj, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+24]");
		object obj5 = 0 & 0x80000000L;
		if (obj5 != null)
		{
			XRNode node = ((i != 1) ? ((XRNode)4) : ((XRNode)5));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = Tracked(node);
			bool flag4 = !flag3;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				float[] array = armLostAt;
				float time = Time.time;
				if (armLostAt == null)
				{
					goto IL_0701;
				}
				bool flag5 = array.Length < i;
				object obj8 = !flag5;
				object obj9 = array.Length - i;
				bool flag6 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag6;
				if (obj11 != null)
				{
					goto IL_070f;
				}
				object obj12 = armLostAt + i;
			}
		}
		Transform transform = base.transform;
		Vector3[] array5;
		if ((object)transform != null)
		{
			Vector3 vector = transform.InverseTransformPoint((Vector3)0);
			Transform transform2 = base.transform;
			Vector3[] array2 = armWas;
			if (armWas != null)
			{
				bool flag7 = array2.Length < i;
				object obj13 = !flag7;
				object obj14 = array2.Length - i;
				bool flag8 = obj14 == null;
				object obj15 = ~obj13;
				object obj16 = obj15 | flag8;
				if (obj16 != null)
				{
					goto IL_070f;
				}
				if ((object)transform2 != null)
				{
					object obj17 = i * 12;
					object obj18 = (object)armWas + obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v8+28]");
					object obj20 = default;
					object obj19 = obj20 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v8+24]");
					object obj22 = default;
					object obj21 = obj22 - 0;
					float num = dt;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v8+20]");
					float num2 = num - 0f;
					Vector3 vector2 = transform2.TransformVector((Vector3)0);
					Vector3[] array3 = armWas;
					if (armWas != null)
					{
						bool flag9 = array3.Length < i;
						object obj23 = !flag9;
						object obj24 = array3.Length - i;
						bool flag10 = obj24 == null;
						object obj25 = ~obj23;
						object obj26 = obj25 | flag10;
						if (obj26 != null)
						{
							goto IL_070f;
						}
						object obj27 = i * 12;
						object obj28 = (object)armWas + obj27;
						float time2 = Time.time;
						float[] array4 = armSwungAt;
						if (armSwungAt != null)
						{
							bool flag11 = array4.Length < i;
							object obj29 = !flag11;
							object obj30 = array4.Length - i;
							bool flag12 = obj30 == null;
							object obj31 = ~obj29;
							object obj32 = obj31 | flag12;
							if (obj32 != null)
							{
								goto IL_070f;
							}
							object obj33 = default;
							float num3 = num2 / (float)obj33;
							object obj34 = armSwungAt + i;
							float num4 = time2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v12+20]");
							float num5 = num4 - 0f;
							object obj35 = obj21 / obj33;
							object obj36 = obj19 / obj33;
							if (num5 > punchSwingLasts)
							{
								bool flag13 = armSwung == null;
								object obj37 = !flag13;
								array5 = armSwung;
								if (obj37 != null)
								{
									goto IL_05d2;
								}
							}
							else
							{
								array5 = armSwung;
								if (armSwung != null)
								{
									bool flag14 = array5.Length < i;
									object obj38 = !flag14;
									object obj39 = array5.Length - i;
									bool flag15 = obj39 == null;
									object obj40 = ~obj38;
									object obj41 = obj40 | flag15;
									if (obj41 == null)
									{
										float num6 = num3 * num3;
										object obj42 = obj35 * obj35;
										object obj43 = i * 12;
										object obj44 = (object)armSwung + obj43;
										float num7 = num6 + (float)obj42;
										object obj45 = obj36 * obj36;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X9_v13+20]");
										nint num8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X9_v13+20]");
										object obj46 = num8 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X9_v13+24]");
										nint num9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X9_v13+24]");
										object obj47 = num9 * 0;
										float num10 = (float)obj45 + num7;
										object obj48 = obj46 + obj47;
										object obj50 = default;
										object obj49 = obj48 + obj50;
										if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num10) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49))
										{
											goto IL_05d2;
										}
										return;
									}
									goto IL_070f;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0701;
		IL_070f:
		throw new IndexOutOfRangeException();
		IL_0701:
		NullReferenceException ex = new NullReferenceException();
		goto IL_070f;
		IL_05d2:
		bool flag16 = array5.Length < i;
		object obj51 = !flag16;
		object obj52 = array5.Length - i;
		bool flag17 = obj52 == null;
		object obj53 = ~obj51;
		object obj54 = obj53 | flag17;
		if (obj54 == null)
		{
			object obj55 = i * 12;
			object obj56 = (object)array5 + obj55;
			float[] array6 = armSwungAt;
			float time3 = Time.time;
			if (armSwungAt == null)
			{
				goto IL_0701;
			}
			bool flag18 = array6.Length < i;
			object obj57 = !flag18;
			object obj58 = array6.Length - i;
			bool flag19 = obj58 == null;
			object obj59 = ~obj57;
			object obj60 = obj59 | flag19;
			if (obj60 == null)
			{
				object obj61 = armSwungAt + i;
				return;
			}
		}
		goto IL_070f;
	}

	public static bool LandsOn(NetworkApe a)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected I4, but got Unknown
		//IL_005f: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_015d: Expected I4, but got Obj
		//IL_014a: Expected Obj, but got I4
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
		if (!((UnityEngine.Object)a != (UnityEngine.Object)null))
		{
			goto IL_0113;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7;
		if (MenuShoves)
		{
			if ((object)a == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			if (a.SaysNoToPunches)
			{
				goto IL_0113;
			}
			bool downHere = a.DownHere;
			obj7 = (downHere ? 1 : 0) ^ 1;
		}
		else
		{
			obj7 = 1;
		}
		goto IL_0195;
		IL_0113:
		obj7 = 0;
		goto IL_0195;
		IL_0195:
		return (byte)(obj7 & 1) != 0;
	}

	private unsafe NetworkApe Punchable(Vector3 real, Vector3 drawn, float reach, Vector3 swing, out GoreSection section, out Vector3 point)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0ddb: Expected F4, but got I4
		//IL_0dd6: Expected native int or pointer, but got VT
		//IL_0de4: Expected native int or pointer, but got VT
		//IL_0df2: Expected native int or pointer, but got VT
		//IL_0e17: Expected Obj, but got I
		//IL_0e42: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I4
		//IL_0e72: Expected F4, but got I4
		//IL_0e7b: Expected F4, but got I4
		//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Expected VT, but got I4
		//IL_0077: Expected F4, but got I4
		//IL_0080: Expected F4, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected VT, but got I4
		//IL_0116: Expected F4, but got I4
		//IL_011f: Expected F4, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected VT, but got I4
		//IL_00dc: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_01a2: Expected VT, but got Obj
		//IL_01c4: Expected Obj, but got I4
		//IL_01ef: Expected VT, but got I4
		//IL_01fb: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I4
		//IL_0ed7: Expected Obj, but got I
		//IL_0ef7: Expected F4, but got I4
		//IL_0f00: Expected F4, but got I4
		//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f53: Expected VT, but got I4
		//IL_0245: Expected I, but got Obj
		//IL_025b: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected F4, but got I4
		//IL_02c0: Expected F4, but got I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected F4, but got Unknown
		//IL_030a: Expected F4, but got I4
		//IL_0313: Expected VT, but got I4
		//IL_0c27: Expected Obj, but got I4
		//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Expected Obj, but got I4
		//IL_0fa9: Expected Obj, but got I
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fba: Expected Ref, but got Unknown
		//IL_0fd4: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_0c64: Expected Obj, but got I4
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Expected Obj, but got Unknown
		//IL_0c91: Expected Obj, but got I4
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got I4
		//IL_0404: Expected Obj, but got I4
		//IL_046d: Expected Obj, but got I4
		//IL_0d6d: Expected Obj, but got I4
		//IL_04b2: Expected Obj, but got I4
		//IL_04bb: Expected VT, but got I4
		//IL_04f3: Expected Obj, but got I4
		//IL_0535: Expected VT, but got I4
		//IL_056d: Expected Obj, but got I4
		//IL_05ad: Expected Obj, but got I4
		//IL_07a6: Expected Obj, but got I4
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected VT, but got I4
		//IL_05f5: Expected Obj, but got I4
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected VT, but got I4
		//IL_0896: Expected VT, but got I4
		//IL_0640: Expected VT, but got Obj
		//IL_0662: Expected Obj, but got I4
		//IL_08ce: Expected VT, but got I4
		//IL_0906: Expected Obj, but got I4
		//IL_06d6: Expected Obj, but got I
		//IL_0700: Expected Obj, but got I4
		//IL_0773: Expected VT, but got I4
		//IL_09d3: Expected Obj, but got I4
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected VT, but got I4
		//IL_096c: Expected Obj, but got I4
		//IL_0a26: Expected VT, but got Ref
		//IL_0a26: Expected VT, but got Ref
		//IL_0a44: Expected Obj, but got I4
		//IL_0a4d: Expected VT, but got I4
		//IL_0a8d: Expected VT, but got Ref
		//IL_0ab5: Expected VT, but got Ref
		//IL_0ab5: Expected VT, but got Ref
		//IL_0ad1: Expected VT, but got I4
		//IL_0b11: Expected VT, but got Ref
		//IL_0b1a: Expected VT, but got I4
		//IL_0b72: Expected VT, but got Ref
		//IL_0b88: Expected native int or pointer, but got VT
		//IL_0b96: Expected native int or pointer, but got VT
		//IL_0ba3: Expected native int or pointer, but got VT
		//IL_0983: Expected Obj, but got I4
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		((Vector3*)(nint)real)->x = 1f;
		((Vector3*)(nint)drawn)->z = 0f;
		((Vector3*)(nint)drawn)->x = 0f;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v4+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float x;
		float x2;
		Enumerator<, > val;
		NetworkApe networkApe2 = default;
		float num2 = default;
		float num4 = default;
		float num6 = default;
		object obj9;
		MonsterPlayer monsterPlayer;
		UnityEngine.Object obj8;
		float num;
		float num3;
		float num5;
		Vector3 vector;
		NetworkApe networkApe;
		if ((UnityEngine.Object)obj5 != null)
		{
			bool flag2 = obj5 == null;
			x = 0f;
			x2 = 0f;
			val = (Enumerator<, >)0;
			networkApe = networkApe2;
			num = num2;
			num3 = num4;
			num5 = num6;
			vector = (Vector3)0;
			obj8 = null;
			monsterPlayer = this;
			if (flag2)
			{
				goto IL_0cab;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X22_v7 (UnityEngine.Object)+80]");
			obj9 = 0;
		}
		else
		{
			obj9 = 3;
		}
		Transform transform = base.transform;
		bool flag3 = (object)transform == null;
		x = 0f;
		x2 = 0f;
		val = (Enumerator<, >)0;
		networkApe = networkApe2;
		num = num2;
		num3 = num4;
		num5 = num6;
		vector = (Vector3)0;
		obj8 = null;
		monsterPlayer = this;
		float num18 = default;
		float num20 = default;
		float num21 = default;
		float num23 = default;
		if (!flag3)
		{
			Vector3 localScale = transform.localScale;
			bool flag4 = (object)head == null;
			x = 0f;
			x2 = 0f;
			val = (Enumerator<, >)0;
			networkApe = networkApe2;
			num = num2;
			num3 = num4;
			num5 = num6;
			vector = (Vector3)0;
			obj8 = null;
			monsterPlayer = this;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
				monsterPlayer = (MonsterPlayer)0;
				Vector3 position = head.position;
				Vector3 vector2 = (Vector3)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X0_v15 (UnityEngine.Vector3)+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = Walled(vector2, (Vector3)0);
				nint num7 = (nint)monsterPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v11 (Il2CppClass<MonsterPlayer>)+E4]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				nint num8 = num7;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num8 = (nint)monsterPlayer;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v12 (Il2CppClass<MonsterPlayer>)+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v13+8]");
				bool flag8 = (nint)0 == 0;
				x = 0f;
				x2 = 0f;
				val = (Enumerator<, >)0;
				networkApe = networkApe2;
				float num9 = default;
				num = num9;
				float num10 = default;
				num3 = num10;
				float num11 = default;
				num5 = num11;
				float num12 = num11;
				float num13 = num9;
				float num14 = num10;
				float num15 = num10;
				vector = (Vector3)0;
				obj8 = null;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
					object obj14 = 0;
					float num16 = num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
					float num17 = num16 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v13+8]");
					Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
					num15 = num17 * num17;
					x = 0f;
					float num19 = default;
					num18 = num19;
					x2 = 0f;
					num = num9;
					num3 = num10;
					num20 = num11;
					num5 = num11;
					float num22 = default;
					num21 = num22;
					Enumerator<, > val2 = default;
					num23 = (float)val2;
					num12 = num11;
					num13 = num9;
					num14 = 2.139095E+09f;
					vector = (Vector3)0;
					monsterPlayer = null;
					float num25 = default;
					float num34 = default;
					float num38 = default;
					NetworkApe result = default;
					object obj37 = default;
					object obj27;
					Enumerator<, > val3;
					while (true)
					{
						obj8 = (UnityEngine.Object)obj14;
						float num24;
						float num26;
						GillaWounds gillaWounds;
						Vector3 vector3;
						float num32;
						float num33;
						float num35;
						float num36;
						float num37;
						float num39;
						float num40;
						Vector3 vector4;
						Vector3 vector5;
						UnityEngine.Object tearing;
						if (val.MoveNext())
						{
							object obj16 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X0_v23+E4]");
							bool flag9 = (nint)0 == 0;
							object obj17 = !flag9;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (!CanTouch(networkApe2))
							{
								continue;
							}
							if ((object)networkApe2 == null)
							{
								break;
							}
							bool busy = networkApe2.Busy;
							bool flag10 = !busy;
							object obj18 = 0;
							if (!flag10)
							{
								bool downHere = networkApe2.DownHere;
								bool flag11 = !downHere;
								obj18 = 0;
								if (flag11)
								{
									continue;
								}
							}
							if (networkApe2.punches >= (nint)obj9)
							{
								continue;
							}
							object obj19 = obj2;
							tearing = networkApe2.tearing;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X0_v31+E4]");
							bool flag12 = (nint)0 == 0;
							object obj20 = !flag12;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag13 = tearing == null;
							bool flag14 = !flag13;
							object obj21 = !flag14;
							vector = (Vector3)0;
							if (obj21 != null)
							{
								continue;
							}
							object obj22 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X0_v35+E4]");
							bool flag15 = (nint)0 == 0;
							object obj23 = !flag15;
							if (obj23 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag16 = LandsOn(networkApe2);
							bool flag17 = !flag16;
							vector = (Vector3)0;
							if (flag17)
							{
								continue;
							}
							object obj24 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v942 @ X0_v40+E4]");
							bool flag18 = (nint)0 == 0;
							object obj25 = !flag18;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool isMonster = IsMonster;
							bool flag19 = !isMonster;
							object obj26 = !flag19;
							num24 = num25;
							num26 = num12;
							float num27 = num13;
							obj8 = null;
							if (obj26 == null)
							{
								bool flag20 = (object)networkApe2.head == null;
								obj27 = 0;
								val = val2;
								networkApe = null;
								val3 = (Enumerator<, >)(ref val);
								vector = (Vector3)0;
								obj8 = null;
								if (flag20)
								{
									goto IL_0d01;
								}
								Vector3 position2 = networkApe2.head.position;
								Vector3 at = (Vector3)obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X0_v59 (UnityEngine.Vector3)+E4]");
								bool flag21 = (nint)0 == 0;
								object obj28 = !flag21;
								if (obj28 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag22 = InSpawnRoom(at);
								bool flag23 = !flag22;
								num24 = num20;
								num26 = num21;
								num27 = num23;
								obj8 = null;
								if (!flag23)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
									object obj29 = 0;
									object obj30 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v61+E4]");
									bool flag24 = (nint)0 == 0;
									object obj31 = !flag24;
									if (obj31 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool hasOwnerMenu = ModMenuAccess.HasOwnerMenu;
									bool flag25 = !hasOwnerMenu;
									num24 = num20;
									num26 = num21;
									num27 = num23;
									obj8 = null;
									num25 = num20;
									num12 = num21;
									num13 = num23;
									vector = (Vector3)0;
									if (flag25)
									{
										continue;
									}
								}
							}
							bool flag26 = (object)networkApe2.head == null;
							num25 = num24;
							obj27 = 0;
							val = val2;
							networkApe = null;
							val3 = (Enumerator<, >)(ref val);
							num12 = num26;
							num13 = num27;
							vector = (Vector3)0;
							if (!flag26)
							{
								Vector3 position3 = networkApe2.head.position;
								float num28 = num23 - num4;
								float num29 = num21 - num2;
								num20 -= num6;
								float num30 = num28 * num28;
								float num31 = num29 * num29;
								num23 = num30 + num31;
								num21 = num20 * num20;
								num13 = num21 + num23;
								bool flag27 = !(num13 < num14);
								num25 = num24;
								num12 = num26;
								vector = (Vector3)0;
								if (flag27)
								{
									continue;
								}
								bool flag28 = num13 > num15;
								num25 = num24;
								num12 = num26;
								vector = (Vector3)0;
								if (flag28)
								{
									continue;
								}
								object obj32 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ X0_v45+E4]");
								bool flag29 = (nint)0 == 0;
								object obj33 = !flag29;
								if (obj33 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								gillaWounds = GillaWounds.On(networkApe2.tearing);
								if (flag6)
								{
									bool flag30 = (object)gillaWounds == null;
									object obj34 = !flag30;
									if (obj34 == null)
									{
										obj27 = 0;
										val = val2;
										networkApe = null;
										val3 = (Enumerator<, >)(ref val);
										vector = (Vector3)0;
										obj8 = null;
										goto IL_0d0f;
									}
								}
								else
								{
									bool flag31 = (object)gillaWounds == null;
									num25 = num24;
									tearing = gillaWounds;
									obj27 = 0;
									val = val2;
									networkApe = null;
									val3 = (Enumerator<, >)(ref val);
									num12 = num26;
									vector = (Vector3)0;
									obj8 = null;
									if (flag31)
									{
										goto IL_0d1d;
									}
									bool flag32 = gillaWounds.Hit((Vector3)(&x2), num10, (Vector3)(&x), out *(GoreSection*)null, out System.Runtime.CompilerServices.Unsafe.As<GoreSection, Vector3>(ref section));
									bool flag33 = !flag32;
									object obj35 = !flag33;
									vector3 = (Vector3)0;
									num32 = num22;
									num33 = num34;
									num35 = num19;
									num36 = num11;
									num37 = num38;
									num39 = num9;
									num40 = num10;
									vector4 = (Vector3)(&x);
									if (obj35 != null)
									{
										goto IL_0b80;
									}
								}
								bool flag34 = gillaWounds.Hit((Vector3)(&x2), num4, (Vector3)(&x), out *(GoreSection*)null, out System.Runtime.CompilerServices.Unsafe.As<GoreSection, Vector3>(ref section));
								bool flag35 = !flag34;
								vector3 = (Vector3)0;
								num32 = num22;
								num33 = num34;
								num35 = num19;
								num36 = num6;
								num37 = num38;
								num39 = num2;
								num40 = num4;
								vector4 = (Vector3)(&x);
								vector5 = (Vector3)0;
								num18 = num22;
								num25 = num24;
								tearing = gillaWounds;
								num = num34;
								num3 = num19;
								num20 = num6;
								num5 = num38;
								num21 = num2;
								num23 = num4;
								num12 = num26;
								vector = (Vector3)(&x);
								if (flag35)
								{
									continue;
								}
								goto IL_0b80;
							}
							goto IL_0cd9;
						}
						obj27 = 0;
						val = val2;
						networkApe = null;
						val3 = (Enumerator<, >)(ref val);
						object obj36 = 0;
						goto IL_0f99;
						IL_0d1d:
						NullReferenceException ex = new NullReferenceException();
						if ((nint)obj8 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							networkApe = (NetworkApe)1;
							obj36 = obj27;
						}
						else
						{
							if ((nint)obj8 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return result;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj36 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj27 = obj37;
						}
						goto IL_0f99;
						IL_0b80:
						((Vector3*)(nint)real)->x = x2;
						((Vector3*)(nint)drawn)->z = 0f;
						((Vector3*)(nint)drawn)->x = x;
						vector5 = vector3;
						num18 = num32;
						num25 = num24;
						tearing = gillaWounds;
						num = num33;
						num3 = num35;
						num20 = num36;
						num5 = num37;
						num21 = num39;
						num23 = num40;
						num12 = num26;
						num14 = num13;
						vector = vector4;
						monsterPlayer = (MonsterPlayer)(object)networkApe2;
						continue;
						IL_0d01:
						NullReferenceException ex2 = new NullReferenceException();
						goto IL_0d0f;
						IL_0f99:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
						object obj38 = 0;
						obj8 = (UnityEngine.Object)obj38;
						((Enumerator<, >*)val3)->Dispose();
						bool flag36 = obj36 == null;
						object obj39 = !flag36;
						if (obj39 == null)
						{
							bool flag37 = (object)networkApe == null;
							object obj40 = !flag37;
							OutOfMemoryException ex3 = (OutOfMemoryException)val3;
							if (obj40 == null)
							{
								return (NetworkApe)(object)monsterPlayer;
							}
						}
						else
						{
							OutOfMemoryException ex3 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						goto IL_0d01;
						IL_0d0f:
						NullReferenceException ex4 = new NullReferenceException();
						goto IL_0d1d;
					}
					NullReferenceException ex5 = new NullReferenceException();
					obj27 = 0;
					val = val2;
					networkApe = null;
					val3 = (Enumerator<, >)(ref val);
				}
			}
		}
		goto IL_0cab;
		IL_0cab:
		NullReferenceException ex6 = new NullReferenceException();
		num18 = num18;
		num20 = num20;
		num21 = num21;
		num23 = num23;
		goto IL_0cd9;
		IL_0cd9:
		throw new NullReferenceException();
	}

	private Vector3 Shove(NetworkApe who, Vector3 swing, float size)
	{
		//IL_065e: Expected Obj, but got I4
		//IL_094f: Expected Obj, but got I4
		//IL_095f: Expected Obj, but got I
		//IL_0977: Expected Obj, but got I
		//IL_0683: Expected Obj, but got I
		//IL_06b2: Expected Obj, but got I
		//IL_06c2: Expected Obj, but got I
		//IL_06d7: Expected F4, but got Obj
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_0655: Expected VT, but got Obj
		//IL_072b: Expected Obj, but got I
		//IL_09b2: Expected Obj, but got I
		//IL_09d9: Expected Obj, but got I
		//IL_09f0: Invalid comparison between F4 and Obj
		//IL_077a: Expected Obj, but got I
		//IL_0231: Expected F4, but got I
		//IL_0241: Invalid comparison between F4 and I
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_0a9e: Expected Obj, but got I4
		//IL_0310: Expected F4, but got I
		//IL_0320: Invalid comparison between F4 and I
		//IL_0a2e: Expected Obj, but got I4
		//IL_0286: Expected F4, but got I
		//IL_0296: Invalid comparison between F4 and I
		//IL_0815: Expected Obj, but got I
		//IL_081d: Expected F4, but got Obj
		//IL_082d: Expected F4, but got I
		//IL_0a66: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I
		//IL_085c: Expected Obj, but got I4
		//IL_0882: Expected Obj, but got I
		//IL_088a: Expected VT, but got Obj
		//IL_089a: Expected Obj, but got I
		//IL_0545: Expected Obj, but got I
		//IL_0567: Expected Obj, but got I4
		//IL_0ab1: Expected VT, but got I4
		//IL_04ba: Expected I4, but got Obj
		//IL_04dc: Expected Obj, but got I4
		//IL_08d5: Expected Obj, but got I
		//IL_08f7: Expected Obj, but got I4
		//IL_0ace: Expected Obj, but got I
		//IL_0aeb: Expected Obj, but got I
		//IL_0b03: Expected Obj, but got I
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected Obj, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected Obj, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected Obj, but got Unknown
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected VT, but got Unknown
		object obj = 109891584;
		object obj3 = default;
		object obj2 = obj3;
		float num2 = default;
		float num = num2;
		object obj4 = 109891584;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v5+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+20]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+20]");
		object obj10 = num3 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8+A0]");
		object obj11 = 0;
		object obj13 = default;
		object obj12 = obj10 + obj13;
		float num4 = (float)obj11;
		float num5;
		float num6;
		float num7 = default;
		object obj16 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
		{
			num5 = num;
			num6 = num7;
		}
		else
		{
			float num8 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+18]");
			float num9 = num8 * 0f;
			object obj15 = default;
			object obj14 = obj3 * obj15;
			float num10 = num9 + (float)obj14;
			float num11 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+20]");
			num4 = num11 * 0f;
			float num12 = num4 + num10;
			float num13 = num12 / (float)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+18]");
			obj2 = 0 * obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+20]");
			float num14 = 0f * num13;
			num5 = num2 - (float)obj2;
			num6 = num7 - num14;
			num = num14;
		}
		object obj24;
		float num34;
		float num40;
		float num41;
		float num37;
		if ((object)who != null && (object)who.head != null)
		{
			Vector3 position = who.head.position;
			if ((object)head != null)
			{
				Vector3 position2 = head.position;
				object obj17 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v13+A0]");
				object obj18 = 0;
				object obj19 = obj8;
				float num15 = num - num;
				float num16 = num4 - num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v16+A0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v14+20]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v14+20]");
				object obj21 = num17 * 0;
				float num18 = (float)obj21 + num;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num18) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
				{
					float num19 = num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v14+18]");
					float num20 = num19 * 0f;
					float num21 = num16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v14+20]");
					float num22 = num21 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					float num23 = num22 + num20;
					float num24 = num23 / num18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v14+18]");
					object obj22 = 0 * obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v14+20]");
					float num25 = 0f * num24;
					num15 -= (float)obj22;
					num16 -= num25;
				}
				float num26 = num6 * num6;
				float num27 = num2 * num2;
				object obj23 = obj3 * obj3;
				float num28 = num5 * num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				obj24 = 0;
				float num29 = num27 + (float)obj23;
				float num30 = num7 * num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				float num31 = num30 + num29;
				float num32 = num28 + num26;
				float num33 = num31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				num34 = num33 * 0f;
				object obj27;
				if (!(num32 > num34))
				{
					float num35 = num15 * num15;
					num30 = num16 * num16;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					float num36 = num35 + num30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					num34 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					if (num36 > 0f)
					{
						object obj25 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X0_v67+E4]");
						bool flag = (nint)0 == 0;
						object obj26 = !flag;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						num37 = 0f;
						float num38 = num34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						if (num38 > 0f)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							float num39 = num15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							num40 = num39 / 0f;
							num41 = num16 / num34;
							goto IL_0a3c;
						}
						obj27 = obj5;
						goto IL_0805;
					}
				}
				object obj28 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v56+E4]");
				bool flag2 = (nint)0 == 0;
				object obj29 = !flag2;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				num37 = 0f;
				float num42 = num34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				if (num42 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num41 = num6 / num34;
					float num43 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					num40 = num43 / 0f;
					num28 = num5;
					goto IL_0a3c;
				}
				obj27 = obj5;
				goto IL_0805;
			}
		}
		goto IL_0647;
		IL_0a3c:
		object obj30 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj31 = !flag3;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num44 = punchShoveLeast;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj32 = 0;
		float num45 = num34 / num37;
		if (!(num45 < punchShoveLeast))
		{
			num37 = punchShoveMost;
			bool flag4 = !(num45 > punchShoveMost);
			num44 = num45;
			if (!flag4)
			{
				num44 = punchShoveMost;
			}
		}
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj34 = !flag5;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = who.drawn != null;
		bool flag7 = !flag6;
		UnityEngine.Object obj35 = null;
		Vector3 vector;
		object obj36;
		if (!flag7)
		{
			flag6 = who.DownHere;
			bool flag8 = !flag6;
			obj35 = null;
			if (flag8)
			{
				GillaHeldApe drawn = who.drawn;
				if ((object)who.drawn == null)
				{
					goto IL_0647;
				}
				vector = drawn.going;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v44 (GillaHeldApe)+8C]");
				obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X22_v1+9A0]");
				bool flag9 = (nint)0 == 0;
				object obj37 = !flag9;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					flag6 = false;
					_ = 1;
				}
				object obj38 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v46+A0]");
				object obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X24_v1+99F]");
				bool flag10 = (nint)0 == 0;
				object obj40 = !flag10;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
					flag6 = false;
					_ = 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v47+18]");
				nint num46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v47+18]");
				object obj41 = num46 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v47+20]");
				nint num47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v47+20]");
				object obj42 = num47 * 0;
				object obj43 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v49+A0]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				object obj45 = obj42 + obj41;
				bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44);
				obj35 = null;
				if (!flag11)
				{
					Vector3 vector2 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v47+18]");
					object obj46 = vector2 * 0;
					object obj47 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v47+20]");
					object obj48 = obj47 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					object obj49 = obj48 + obj46;
					object obj50 = obj49 / obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v47+18]");
					object obj51 = 0 * obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v47+20]");
					object obj52 = 0 * obj50;
					vector -= obj51;
					obj36 -= obj52;
					obj35 = null;
				}
				goto IL_0905;
			}
		}
		object obj53 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v41+A0]");
		object obj54 = 0;
		vector = (Vector3)obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v42+8]");
		obj36 = 0;
		goto IL_0905;
		IL_0805:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v19+A0]");
		object obj55 = 0;
		num40 = (float)obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v20+8]");
		num41 = 0f;
		goto IL_0a3c;
		IL_0905:
		object obj56 = default;
		float num48 = num40 * (float)obj56;
		float num49 = num41 * num44;
		float num50 = num48 + (float)vector;
		float num51 = num49 + (float)obj36;
		float num52 = num50 * num50;
		float num53 = num51 * num51;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num54 = num53 + num52;
		float num55 = punchShoveLimit * punchShoveLimit;
		if (num54 > num55)
		{
			flag6 = (byte)(int)obj24 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v23 (System.Boolean)+E4]");
			bool flag12 = (nint)0 == 0;
			object obj57 = !flag12;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		}
		return (Vector3)flag6;
		IL_0647:
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	public Vector3 Swung(Vector3 swing, float dt)
	{
		//IL_0105: Expected VT, but got F4
		//IL_0121: Expected VT, but got Obj
		//IL_0046: Expected Obj, but got F4
		//IL_0064: Expected Obj, but got VT
		//IL_0081: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		object obj = default;
		if (!((swungFor += (float)obj) > punchSwingLasts))
		{
			object obj2 = dt * dt;
			object obj4 = default;
			object obj3 = obj4 * obj4;
			object obj5 = swung * swung;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+268]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+268]");
			object obj6 = num * 0;
			object obj7 = obj2 + obj3;
			object obj9 = default;
			object obj8 = obj9 * obj9;
			object obj10 = obj5 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+26C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+26C]");
			object obj11 = num2 * 0;
			object obj12 = obj8 + obj7;
			object obj13 = obj10 + obj11;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
			{
				goto IL_011f;
			}
		}
		swung = (Vector3)dt;
		swungFor = 0f;
		goto IL_011f;
		IL_011f:
		return (Vector3)this;
	}

	private void HeldDied()
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I
		NetworkApe networkApe = held;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = this + 672;
		if (networkApe.drawn != null)
		{
			object obj5 = obj4;
			Transform hand = Holding(heldRight);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+670]");
			((GillaHeldApe)0).Take(hand, heldDeadFor);
		}
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v6+6CC]");
		ExpectBody(0, heldRight);
		held = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ripping = false;
	}

	public void ExpectBody(int id, bool right)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		int[] array = deadBody;
		if (deadBody == null)
		{
			goto IL_00d6;
		}
		bool flag = (right ? 1 : 0) < array.Length;
		object obj = !flag;
		if (obj == null)
		{
			float[] array2 = deadSince;
			object obj2 = deadBody + right;
			float time = Time.time;
			if (deadSince == null)
			{
				goto IL_00d6;
			}
			bool flag2 = (right ? 1 : 0) < array2.Length;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				object obj4 = deadSince + right;
				return;
			}
		}
		goto IL_00e4;
		IL_00d6:
		NullReferenceException ex = new NullReferenceException();
		goto IL_00e4;
		IL_00e4:
		throw new IndexOutOfRangeException();
	}

	private void AwaitBody()
	{
		//IL_0508: Expected Obj, but got I
		//IL_0518: Expected Obj, but got I
		//IL_0521: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I8
		//IL_006f: Expected Obj, but got I4
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I8
		//IL_01d7: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_0336: Expected Obj, but got I4
		//IL_0344: Expected I, but got Obj
		//IL_0381: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I4
		//IL_03c4: Expected I, but got Obj
		//IL_03fc: Expected Obj, but got I4
		//IL_0434: Expected F4, but got I
		//IL_0449: Invalid comparison between F4 and I
		//IL_045d: Expected I, but got Obj
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_04c6: Expected Obj, but got I4
		//IL_04d7: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = 0;
		while (true)
		{
			int[] array = deadBody;
			bool flag = (nint)obj3 < array.Length;
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			object obj5 = (object)array + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X9_v6+20]");
			object obj6 = 0 & 0x80000000L;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				if ((nint)obj3 == 1)
				{
					object obj8 = 477 + 1;
				}
				else
				{
					object obj8 = 477;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v1 (MonsterPlayer)+v389 @ X9_v9]");
				if ((nint)0 != 0)
				{
					float time = Time.time;
					float[] array2 = deadSince;
					bool flag3 = (nint)obj3 < array2.Length;
					object obj9 = !flag3;
					if (obj9 != null)
					{
						break;
					}
					object obj10 = (object)array2 + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v12+20]");
					float num = 0f + heldDeadFor;
					if (time > num)
					{
						array = deadBody;
					}
					else
					{
						int[] array3 = bodyOf;
						bool flag4 = (nint)obj3 < array3.Length;
						object obj11 = !flag4;
						if (obj11 != null)
						{
							break;
						}
						object obj12 = (object)array3 + obj3;
						array = deadBody;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v15+20]");
						object obj13 = 0 & 0x80000000L;
						bool flag5 = obj13 == null;
						object obj14 = !flag5;
						if (obj14 != null)
						{
							bool flag6 = (nint)obj3 < array.Length;
							object obj15 = !flag6;
							if (obj15 != null)
							{
								break;
							}
							object obj16 = obj;
							object obj17 = (object)array + obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X0_v11+E4]");
							bool flag7 = (nint)0 == 0;
							object obj18 = !flag7;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v17+20]");
							GillaCorpse gillaCorpse = GillaCorpse.Find(0);
							object obj19 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v18+E4]");
							bool flag8 = (nint)0 == 0;
							object obj20 = !flag8;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag9 = gillaCorpse == null;
							bool flag10 = !flag9;
							object obj21 = !flag10;
							int num2 = 0;
							nint num3 = unchecked((nint)null);
							if (obj21 == null)
							{
								bool flag11 = gillaCorpse.Has(0);
								bool flag12 = !flag11;
								num2 = 0;
								num3 = unchecked((nint)null);
								if (!flag12)
								{
									bool isHalf = gillaCorpse.IsHalf;
									bool flag13 = !isHalf;
									object obj22 = !flag13;
									num2 = 0;
									num3 = unchecked((nint)null);
									if (obj22 == null)
									{
										float[] array4 = deadSince;
										bool flag14 = (nint)obj3 < array4.Length;
										object obj23 = !flag14;
										if (obj23 != null)
										{
											break;
										}
										object obj24 = (object)array4 + obj3;
										time = gillaCorpse.MadeAt__BackingField;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v20+20]");
										num = 0f;
										float num4 = gillaCorpse.MadeAt__BackingField;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v20+20]");
										bool flag15 = num4 < 0f;
										num2 = 0;
										num3 = unchecked((nint)null);
										if (!flag15)
										{
											object obj25 = obj3 - 1;
											bool right = obj25 == null;
											HoldBody(gillaCorpse, 0, right, byMiddle: false);
											array = deadBody;
											bool flag16 = deadBody == null;
											object obj26 = !flag16;
											num2 = 0;
											num3 = (nint)gillaCorpse;
											if (obj26 == null)
											{
												throw new NullReferenceException();
											}
											goto IL_01eb;
										}
									}
								}
							}
							goto IL_0527;
						}
					}
				}
				goto IL_01eb;
			}
			goto IL_0527;
			IL_0527:
			obj3++;
			if ((nint)obj3 == 2)
			{
				return;
			}
			continue;
			IL_01eb:
			bool flag17 = (nint)obj3 < array.Length;
			object obj27 = !flag17;
			if (obj27 != null)
			{
				break;
			}
			object obj28 = (object)array + obj3;
			_ = 4294967295L;
			goto IL_0527;
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe void RipHeld()
	{
		//IL_0010: Expected Obj, but got I
		//IL_057a: Expected Obj, but got I4
		//IL_05b2: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I4
		//IL_02bb: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I4
		//IL_060e: Expected VT, but got Obj
		//IL_061e: Expected Obj, but got I
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got Unknown
		//IL_0662: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I4
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected I4, but got Unknown
		//IL_02a6: Expected VT, but got I
		//IL_04ae: Expected Obj, but got I4
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected I4, but got Unknown
		//IL_04df: Expected VT, but got I4
		//IL_04df: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		NetworkApe networkApe = held;
		if ((object)held != null && (object)rightFollower != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v6+A0]");
			object obj6 = 0;
			UnityEngine.Object obj7 = (UnityEngine.Object)obj6;
			Vector3 position = rightFollower.position;
			if ((object)leftFollower != null)
			{
				Vector3 position2 = leftFollower.position;
				NetworkApe networkApe2 = held;
				if ((object)held != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
					object obj8 = 0;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaWounds gillaWounds = GillaWounds.On(networkApe2.tearing);
					if ((object)gillaWounds != null)
					{
						Vector3 vector = gillaWounds.PlusX();
						NetworkApe networkApe3 = held;
						if ((object)held != null && (object)networkApe3.tearing != null)
						{
							Transform transform = networkApe3.tearing.transform;
							if ((object)transform != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
								object obj11 = 0;
								Quaternion rotation = transform.rotation;
								object obj12 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v23+E4]");
								bool flag4 = (nint)0 == 0;
								object obj13 = !flag4;
								if (obj13 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								PlayerRef playerRef;
								if ((UnityEngine.Object)obj6 != null)
								{
									if (obj6 == null)
									{
										goto IL_053b;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X22_v3 (UnityEngine.Object)+6D0]");
									playerRef = (PlayerRef)0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
									object obj14 = 0;
									object obj15 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v46+E4]");
									bool flag5 = (nint)0 == 0;
									object obj16 = !flag5;
									if (obj16 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									PlayerRef none = PlayerRef.None;
									playerRef = none;
								}
								object obj18 = default;
								object obj17 = obj18 - obj18;
								object obj20 = default;
								object obj19 = obj20 - obj20;
								object obj22 = default;
								object obj21 = obj22 - obj22;
								object obj23 = obj17 * obj18;
								object obj24 = obj19 * obj20;
								Quaternion quaternion = (Quaternion)(obj23 + obj24);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
								object obj25 = 0;
								object obj26 = obj21 * obj22;
								object obj27 = obj25;
								object obj28 = obj26 + quaternion;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v28+E4]");
								bool flag6 = (nint)0 == 0;
								object obj29 = !flag6;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag7 = (nint)obj28 < 0;
								bool flag8 = obj28 == null;
								object obj30 = obj28 ^ obj28;
								object obj31 = obj28 & obj30;
								bool flag9 = (nint)obj31 < 0;
								bool flag10 = flag7 == flag9;
								object obj32 = !flag8;
								bool flag11 = (byte)((flag10 & obj32) ? 1 : 0) != 0;
								int seed = GillaRip.PickSeed();
								NetworkBool plusInRight = flag11;
								if ((object)rightFollower != null)
								{
									Quaternion rotation2 = rightFollower.rotation;
									Quaternion rotation3 = default;
									Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation3);
									if ((object)leftFollower != null)
									{
										Quaternion rotation4 = leftFollower.rotation;
										Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation3);
										if ((object)held != null)
										{
											bool flag12 = (nint)obj28 < 0;
											bool flag13 = obj28 == null;
											object obj33 = obj28 ^ obj28;
											object obj34 = obj28 & obj33;
											bool flag14 = (nint)obj34 < 0;
											bool flag15 = flag12 == flag14;
											object obj35 = !flag13;
											bool plusInRight2 = (byte)((flag15 & obj35) ? 1 : 0) != 0;
											object obj36 = default;
											RpcInfo info = default;
											held.RPC_Rip(playerRef, (byte)seed, plusInRight, (Quaternion)(&obj36), (Quaternion)0, info);
											HalvesInHands(networkApe.owner, plusInRight2);
											ripping = false;
											HeldDied();
											if (deadBody != null)
											{
												int[] array = default;
												array[0] = -1;
												return;
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
		goto IL_053b;
		IL_053b:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void HalvesInHands(int id, bool plusInRight)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0379: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I4
		//IL_0222: Expected Obj, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I4
		//IL_0288: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Buzz((XRNode)4, 1f, 0.5f);
		Buzz((XRNode)5, 1f, 0.5f);
		bool flag2 = plusInRight;
		int num = id;
		object obj6 = 0;
		object obj7 = 1;
		while (true)
		{
			object obj8 = obj4;
			object obj9 = obj7 ^ plusInRight;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			int sign = ((obj11 != null) ? 1 : (-1));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num2 = GillaCorpse.HalfId(id, sign);
			int[] array = bodyOf;
			GillaCorpse gillaCorpse = GillaCorpse.Find(num2);
			object obj13 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v7+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = gillaCorpse != null;
			bool flag7 = !flag6;
			object obj15 = !flag7;
			object obj16 = ~obj15;
			if (obj16 == null)
			{
				int num3 = num2;
			}
			else
			{
				int num3 = -1;
			}
			if (bodyOf != null)
			{
				bool flag8 = (nint)obj6 < array.Length;
				object obj17 = !flag8;
				if (obj17 != null)
				{
					break;
				}
				object obj18 = (object)bodyOf + obj6;
				int[] array2 = bodyPart;
				if (bodyPart != null)
				{
					bool flag9 = (nint)obj6 < array2.Length;
					object obj19 = !flag9;
					if (obj19 != null)
					{
						break;
					}
					object obj20 = (object)bodyPart + obj6;
					_ = 0;
					object obj21 = obj7 & 1;
					bool flag10 = obj21 == null;
					object obj22 = !flag10;
					flag2 = false;
					num = 0;
					obj6 = 1;
					obj7 = 0;
					if (obj22 == null)
					{
						return;
					}
					continue;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe void RipBody(GillaCorpse body)
	{
		//IL_003d: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I4
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05bd: Expected Obj, but got VT
		//IL_05ca: Expected Obj, but got VT
		//IL_05f1: Expected Obj, but got VT
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected Obj, but got Unknown
		//IL_077e: Expected Obj, but got I
		//IL_07ad: Expected Obj, but got I4
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected Obj, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		//IL_068e: Expected Obj, but got I
		//IL_06b8: Expected Obj, but got I4
		//IL_0808: Expected Obj, but got I4
		//IL_039f: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		//IL_04b4: Expected Obj, but got I4
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected I4, but got Unknown
		//IL_04e9: Expected VT, but got I4
		//IL_04e9: Expected VT, but got I4
		//IL_01fe: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_055b: Expected Obj, but got I4
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected I4, but got Unknown
		//IL_023d: Expected Obj, but got I
		//IL_06f0: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I4
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02c5: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected I4, but got Unknown
		//IL_037c: Expected VT, but got I4
		//IL_037c: Expected VT, but got I4
		//IL_037c: Expected VT, but got Ref
		Vector3 position = rightFollower.position;
		Vector3 position2 = leftFollower.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj = 0;
		Vector3 vector = body.PlusX();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = GillaRip.PickSeed();
		Transform transform = body.transform;
		Quaternion rotation = transform.rotation;
		Quaternion rotation2 = rightFollower.rotation;
		Quaternion rotation3 = default;
		Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj4 = 0;
		Quaternion rotation4 = leftFollower.rotation;
		Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation3);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v25+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		object obj8 = default;
		object obj7 = obj8;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj8;
		}
		Quaternion quaternion3 = default;
		object obj10 = default;
		object obj9 = quaternion3 * obj10;
		object obj11 = obj10 * obj10;
		object obj12 = obj8 - obj8;
		object obj13 = obj10 * quaternion3;
		object obj14 = quaternion3 * quaternion3;
		object obj15 = quaternion3 - quaternion3;
		object obj17 = default;
		object obj16 = obj17 * obj10;
		object obj18 = obj10 * obj10;
		object obj19 = quaternion3 * quaternion3;
		object obj20 = obj8;
		Quaternion quaternion4 = quaternion3;
		object obj21 = obj17;
		object obj22 = obj9 + obj13;
		object obj23 = obj17 * obj8;
		object obj24 = obj17 - obj17;
		object obj25 = obj11 - obj14;
		object obj26 = obj8 * obj8;
		object obj27 = obj12 * obj8;
		object obj28 = obj15 * quaternion3;
		object obj29 = obj4;
		object obj30 = obj8 * obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj31 = 0;
		object obj32 = obj18 - obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v29+E4]");
		bool flag3 = (nint)0 == 0;
		object obj33 = !flag3;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj29 = obj4;
			obj20 = obj8;
			quaternion4 = quaternion3;
			obj21 = obj17;
		}
		object obj34 = obj28 + obj27;
		object obj35 = obj23 + obj22;
		object obj36 = obj8 * obj21;
		object obj37 = obj17 * quaternion4;
		object obj38 = obj24 * obj17;
		object obj39 = quaternion3 * obj20;
		object obj40 = obj25 - obj26;
		object obj41 = obj17 * obj21;
		object obj42 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v29+A0]");
		object obj43 = 0;
		UnityEngine.Object obj44 = (UnityEngine.Object)obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj45 = !flag4;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj46 = obj38 + obj34;
		object obj47 = obj35 - obj36;
		object obj48 = obj40 - obj41;
		bool flag5 = (UnityEngine.Object)obj43 != null;
		bool flag6 = !flag5;
		object obj49 = 0;
		UnityEngine.Object obj50 = null;
		bool flag19 = default;
		object obj61;
		if (!flag6)
		{
			object obj51 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v46+E4]");
			bool flag7 = (nint)0 == 0;
			object obj52 = !flag7;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X22_v4 (UnityEngine.Object)+40]");
			bool flag8 = (UnityEngine.Object)0 != null;
			bool flag9 = !flag8;
			obj49 = 0;
			obj50 = null;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X22_v4 (UnityEngine.Object)+40]");
				UnityEngine.Object obj53 = (UnityEngine.Object)0;
				object obj54 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X0_v51+E4]");
				bool flag10 = (nint)0 == 0;
				object obj55 = !flag10;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X23_v7 (UnityEngine.Object)+30]");
				bool flag11 = (UnityEngine.Object)0;
				bool flag12 = !flag11;
				obj49 = 0;
				obj50 = null;
				if (!flag12)
				{
					ArgumentNullException ex = new ArgumentNullException();
					object obj56 = ex & 1;
					bool flag13 = obj56 == null;
					obj49 = 0;
					obj50 = obj53;
					if (!flag13)
					{
						bool flag14 = (nint)obj46 < 0;
						bool flag15 = obj46 == null;
						object obj57 = obj46 ^ obj46;
						object obj58 = obj46 & obj57;
						bool flag16 = (nint)obj58 < 0;
						bool flag17 = flag14 == flag16;
						object obj59 = !flag15;
						bool flag18 = (byte)((flag17 & obj59) ? 1 : 0) != 0;
						NetworkBool plusInRight = flag18;
						object obj60 = default;
						((NetworkApe)obj43).RPC_RipCorpse(body.Id__BackingField, (byte)num, plusInRight, (Quaternion)(&obj60), (Quaternion)0, (RpcInfo)flag19);
						obj61 = obj46;
						goto IL_04fb;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj62 = 0;
		object obj63 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X0_v36+E4]");
		bool flag20 = (nint)0 == 0;
		object obj65 = !flag20;
		if (obj65 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
		object obj66 = obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v15+E4]");
		bool flag21 = (nint)0 == 0;
		object obj67 = !flag21;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag22 = (nint)obj46 < 0;
		bool flag23 = obj46 == null;
		object obj68 = obj46 ^ obj46;
		object obj69 = obj46 & obj68;
		bool flag24 = (nint)obj69 < 0;
		int seed = num & 0xFF;
		bool flag25 = flag22 == flag24;
		object obj70 = !flag23;
		bool plusInRight2 = (byte)((flag25 & obj70) ? 1 : 0) != 0;
		bool flag26 = GillaCorpse.RipIt(none, body.Id__BackingField, seed, plusInRight2, (Quaternion)1, (Quaternion)0, flag19);
		obj61 = obj46;
		goto IL_04fb;
		IL_04fb:
		bool flag27 = (nint)obj61 < 0;
		bool flag28 = obj61 == null;
		object obj71 = obj61 ^ obj61;
		object obj72 = obj61 & obj71;
		bool flag29 = (nint)obj72 < 0;
		bool flag30 = flag27 == flag29;
		object obj73 = !flag28;
		bool plusInRight3 = (byte)((flag30 & obj73) ? 1 : 0) != 0;
		HalvesInHands(body.Id__BackingField, plusInRight3);
	}

	private Transform Holding(bool right)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = worn != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		bool flag4 = false;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			if ((object)worn == null)
			{
				return (Transform)(object)new NullReferenceException();
			}
			Transform transform = worn.Grip(right);
			obj4 = 0;
			flag4 = right;
			obj5 = transform;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = obj5 != null;
		bool flag7 = !flag6;
		object obj8 = !flag7;
		if (obj8 == null)
		{
			bool flag8 = !right;
			object obj9 = !flag8;
			object obj10 = ~obj9;
			if (obj10 == null)
			{
				object obj11 = 200;
			}
			else
			{
				object obj11 = 192;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v128 @ X8_v7]");
			obj5 = (UnityEngine.Object)0;
		}
		return (Transform)obj5;
	}

	private unsafe void PickUp(bool right, float reach)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I4
		//IL_0853: Expected Obj, but got I4
		//IL_099a: Expected Obj, but got I
		//IL_09bc: Expected Obj, but got I4
		//IL_02dc: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I4
		//IL_0394: Expected Obj, but got I
		//IL_05fb: Expected Obj, but got I4
		//IL_0613: Expected Obj, but got I
		//IL_088b: Expected Obj, but got I4
		//IL_0403: Expected Obj, but got I4
		//IL_041b: Expected Obj, but got I
		//IL_08c3: Expected Obj, but got I4
		//IL_09da: Expected Obj, but got I
		//IL_047c: Expected Obj, but got I
		//IL_04ef: Expected Obj, but got I
		//IL_04ff: Invalid comparison between F4 and I
		//IL_0519: Expected Obj, but got I4
		//IL_067f: Expected VT, but got I4
		//IL_067f: Expected VT, but got Ref
		//IL_067f: Expected VT, but got I
		//IL_06ae: Expected Obj, but got I4
		//IL_06fe: Expected VT, but got I4
		//IL_0592: Expected Obj, but got I
		//IL_05ae: Expected VT, but got I4
		//IL_05ae: Expected VT, but got I4
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_05cf: Expected Obj, but got I
		//IL_05d8: Expected Obj, but got I4
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Expected Obj, but got Unknown
		//IL_08fb: Expected Obj, but got I
		//IL_091b: Expected Obj, but got I
		//IL_093b: Expected Obj, but got I4
		//IL_0746: Expected VT, but got I4
		//IL_0757: Expected VT, but got I4
		//IL_0974: Expected Obj, but got I4
		//IL_0804: Expected F4, but got I
		//IL_0804: Expected F4, but got I
		HandPoints(right, touching);
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Vector3 localScale = transform.localScale;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = default;
		float num = skinTouch * (float)obj5;
		NetworkApe networkApe = OnSomeone(touching, num);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)networkApe == (UnityEngine.Object)null)
		{
			TakeDummy(right, touching, reach);
			return;
		}
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)networkApe == (UnityEngine.Object)held;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			return;
		}
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v20+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = (UnityEngine.Object)networkApe == (UnityEngine.Object)second;
		bool flag8 = !flag7;
		object obj13 = !flag8;
		if (obj13 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v24+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v28+E4]");
		bool flag10 = (nint)0 == 0;
		object obj18 = !flag10;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj14;
		}
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v28+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v14+E4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = (UnityEngine.Object)obj20 == null;
		bool flag13 = !flag12;
		object obj22 = !flag13;
		if (obj22 != null)
		{
			return;
		}
		Transform transform2 = Holding(right);
		Vector3 position = transform2.position;
		Vector3 position2 = networkApe.head.position;
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v37+E4]");
		bool flag14 = (nint)0 == 0;
		object obj24 = !flag14;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2 = num - num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		object obj25 = num3 - 0;
		object obj27 = default;
		object obj26 = obj27 - obj27;
		object obj28;
		float num5;
		if (networkApe.limp != null)
		{
			bool isDown = networkApe.limp.IsDown;
			bool flag15 = !isDown;
			obj28 = obj25;
			object obj29 = 0;
			float num4 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			object obj30 = 0;
			UnityEngine.Object obj31 = null;
			num5 = num2;
			if (!flag15)
			{
				Vector3 eyes = networkApe.limp.Eyes;
				Vector3 middle = networkApe.limp.Middle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				object obj32 = num6 - 0;
				object obj33 = obj27 - obj27;
				float num7 = num - num;
				object obj34 = obj32 * obj32;
				float num8 = num7 * num7;
				float num9 = num8 + (float)obj34;
				object obj35 = obj33 * obj33;
				num4 = (float)obj35 + num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				obj30 = 0;
				float num10 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				bool flag16 = !(num10 > 0f);
				obj28 = obj25;
				obj29 = 0;
				obj31 = null;
				num5 = num2;
				if (!flag16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
					Vector3 fromDirection = default;
					Vector3 toDirection = default;
					Quaternion quaternion = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
					Vector3 eyes2 = networkApe.limp.Eyes;
					float num11 = num4 - num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					object obj36 = num12 - 0;
					object obj37 = obj27 - obj27;
					Vector3 vector = (Quaternion)0 * (Vector3)0;
					obj26 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					obj28 = 0;
					obj29 = 0;
					obj31 = null;
					num5 = num4;
				}
			}
		}
		else
		{
			obj28 = obj25;
			object obj29 = 0;
			float num4 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			object obj30 = 0;
			UnityEngine.Object obj31 = null;
			num5 = num2;
		}
		object obj38 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v42+E4]");
		bool flag17 = (nint)0 == 0;
		object obj39 = !flag17;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj40 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v46+E4]");
		bool flag18 = (nint)0 == 0;
		object obj41 = !flag18;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj40 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v46+A0]");
		object obj42 = 0;
		object obj43 = obj42;
		NetworkBool rightHand = right;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v22+6D0]");
		object obj44 = default;
		networkApe.RPC_Grab((PlayerRef)0, rightHand, (Vector3)(&obj44), (RpcInfo)0);
		object obj45 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v50+E4]");
		bool flag19 = (nint)0 == 0;
		object obj46 = !flag19;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = networkApe.drawn != null;
		bool flag21 = !flag20;
		object obj47 = obj26;
		Vector3 vector2 = (Vector3)0;
		float num13 = num5;
		object obj48 = obj28;
		if (!flag21)
		{
			Transform hand = Holding(right);
			networkApe.drawn.Take(hand, (Vector3)0);
			obj47 = obj26;
			vector2 = (Vector3)0;
			num13 = num5;
			obj48 = obj28;
		}
		object obj49 = this + 672;
		held = networkApe;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		heldRight = right;
		float time = Time.time;
		heldSince = time;
		object obj50 = this + 612;
		bool flag22 = !right;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj51 = 0;
		object obj52 = obj;
		object obj53 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v28+A0]");
		object obj54 = 0;
		obj50 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X8_v29+8]");
		_ = 0;
		object obj55 = !flag22;
		object obj56 = ~obj55;
		XRNode node = ((obj56 != null) ? ((XRNode)4) : ((XRNode)5));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v59+E4]");
		bool flag23 = (nint)0 == 0;
		object obj57 = !flag23;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		Buzz(node, num14, 0f);
	}

	private unsafe void Drop(Vector3 velocity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0579: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00f3: Expected VT, but got I4
		//IL_005c: Expected VT, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_0167: Expected Obj, but got I
		//IL_019b: Expected VT, but got I4
		//IL_01c6: Expected Obj, but got I
		//IL_05ce: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got I
		//IL_0224: Expected VT, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0279: Expected VT, but got I4
		//IL_037a: Expected VT, but got I4
		//IL_037a: Expected VT, but got Ref
		//IL_029c: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got I4
		//IL_03e5: Expected Obj, but got I
		//IL_04ad: Invalid comparison between F4 and I4
		//IL_04bc: Invalid comparison between F4 and I4
		//IL_04d3: Expected Obj, but got F4
		//IL_04e2: Expected Obj, but got F4
		//IL_0517: Expected Obj, but got I4
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected Obj, but got Unknown
		//IL_068c: Expected VT, but got I4
		//IL_043c: Expected Obj, but got I
		//IL_0460: Expected VT, but got I4
		//IL_0460: Expected VT, but got I4
		//IL_0460: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)heldDummy != (UnityEngine.Object)null)
		{
			DropDummy((Vector3)0);
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = this + 672;
		bool flag3 = (UnityEngine.Object)held != (UnityEngine.Object)null;
		bool flag4 = !flag3;
		float num2 = default;
		float num = num2;
		float num4 = default;
		float num3 = num4;
		float num6 = default;
		float num5 = num6;
		Vector3 vector = (Vector3)0;
		if (!flag4)
		{
			object obj7 = obj6;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+40]");
			bool flag6 = (UnityEngine.Object)0 != null;
			bool flag7 = !flag6;
			num = num2;
			num3 = num4;
			num5 = num6;
			vector = (Vector3)0;
			if (!flag7)
			{
				object obj10 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v8+40]");
				object obj11 = 0;
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v21+E4]");
				bool flag8 = (nint)0 == 0;
				object obj13 = !flag8;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X21_v6+30]");
				bool flag9 = (UnityEngine.Object)0;
				bool flag10 = !flag9;
				num = num2;
				num3 = num4;
				num5 = num6;
				vector = (Vector3)0;
				if (!flag10)
				{
					ArgumentNullException ex = new ArgumentNullException();
					object obj14 = ex & 1;
					bool flag11 = obj14 == null;
					num = num2;
					num3 = num4;
					num5 = num6;
					vector = (Vector3)0;
					if (!flag11)
					{
						float num7 = num6 * num6;
						float num8 = num4 * num4;
						float num9 = num7 + num8;
						float num10 = num2 * num2;
						float num11 = num10 + num9;
						float num12 = hardestThrow * hardestThrow;
						bool flag12 = !(num11 > num12);
						num = num2;
						float num13 = num6;
						float num14 = num4;
						float num15 = num2;
						if (!flag12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj15 = 0;
							object obj16 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v41+E4]");
							bool flag13 = (nint)0 == 0;
							object obj17 = !flag13;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							num10 = num6 / num12;
							num = num4 / num12;
							num13 = num10 * hardestThrow;
							num12 = num2 / num12;
							num14 = num * hardestThrow;
							num15 = num12 * hardestThrow;
						}
						NetworkApe networkApe = (NetworkApe)obj6;
						Vector3 position = networkApe.head.position;
						object obj18 = default;
						RpcInfo info = default;
						networkApe.RPC_Release((Vector3)(&obj18), (Vector3)0, info);
						object obj19 = obj6;
						object obj20 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v32+E4]");
						bool flag14 = (nint)0 == 0;
						object obj21 = !flag14;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v15+670]");
						bool flag15 = (UnityEngine.Object)0 != null;
						bool flag16 = !flag15;
						float num16 = num15;
						float num17 = num14;
						float num18 = num13;
						if (!flag16)
						{
							object obj22 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v17+68]");
							Vector3 position2 = ((Transform)0).position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v17+670]");
							((GillaHeldApe)0).LetGo((Vector3)0, (Vector3)0);
							num16 = num15;
							num17 = num14;
							num18 = num13;
						}
						num5 = punchIn;
						num3 = punchAfterThrow;
						float num19 = punchIn - punchAfterThrow;
						bool flag17 = num19 < 0f;
						bool flag18 = num19 == 0f;
						object obj23 = punchIn ^ punchAfterThrow;
						object obj24 = punchIn ^ num19;
						object obj25 = obj23 & obj24;
						bool flag19 = (nint)obj25 < 0;
						bool flag20 = flag17 == flag19;
						object obj26 = !flag18;
						object obj27 = flag20 & obj26;
						object obj28 = ~obj27;
						if (obj28 != null)
						{
							num5 = punchAfterThrow;
						}
						punchIn = num5;
						vector = (Vector3)0;
					}
				}
			}
		}
		held = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ripping = false;
	}

	private void DropBoth(Vector3 velocity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0070: Expected VT, but got Obj
		//IL_0090: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass249_0 obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD100]");
		object obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Vector3 velocity2 = default;
		obj2.velocity = velocity2;
		Drop((Vector3)this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(obj2, (IntPtr)obj4);
		AsSecond(action);
	}

	public PlayerRef HeldIn(bool right)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05da: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_02ba: Expected Obj, but got I4
		//IL_02ff: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_054d: Expected Obj, but got I
		//IL_0577: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I4
		//IL_05b0: Expected VT, but got Obj
		//IL_00e1: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I4
		//IL_0394: Expected Obj, but got I4
		//IL_03dc: Expected Obj, but got I4
		//IL_0612: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I4
		//IL_064a: Expected Obj, but got I4
		//IL_046c: Expected Obj, but got I
		//IL_0488: Expected Obj, but got I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I4
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_04ef: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)held != (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = 0;
		UnityEngine.Object obj5 = null;
		NetworkApe networkApe3;
		if (!flag3)
		{
			bool flag4 = heldRight != right;
			obj4 = 0;
			obj5 = null;
			if (!flag4)
			{
				NetworkApe networkApe = held;
				if ((object)held != null)
				{
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v38+E4]");
					bool flag5 = (nint)0 == 0;
					object obj7 = !flag5;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = (UnityEngine.Object)((SimulationBehaviour)networkApe)._object != (UnityEngine.Object)null;
					bool flag7 = !flag6;
					obj4 = 0;
					obj5 = null;
					if (flag7)
					{
						goto IL_0290;
					}
					NetworkApe networkApe2 = held;
					if ((object)held != null)
					{
						UnityEngine.Object obj8 = ((SimulationBehaviour)networkApe2)._object;
						if ((object)((SimulationBehaviour)networkApe2)._object != null)
						{
							object obj9 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v43+E4]");
							bool flag8 = (nint)0 == 0;
							object obj10 = !flag8;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X21_v12 (UnityEngine.Object)+30]");
							bool flag9 = (UnityEngine.Object)0;
							bool flag10 = !flag9;
							obj4 = 0;
							obj5 = null;
							if (flag10)
							{
								goto IL_0290;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X21_v12 (UnityEngine.Object)+30]");
							if ((nint)0 != 0)
							{
								ArgumentNullException ex = new ArgumentNullException();
								object obj11 = ex & 1;
								bool flag11 = obj11 == null;
								obj4 = 0;
								obj5 = ((SimulationBehaviour)networkApe2)._object;
								if (flag11)
								{
									goto IL_0290;
								}
								networkApe3 = held;
								bool flag12 = (object)held == null;
								object obj12 = !flag12;
								if (obj12 != null)
								{
									goto IL_0533;
								}
							}
						}
					}
				}
				goto IL_05a2;
			}
		}
		goto IL_0290;
		IL_05a2:
		NullReferenceException ex2 = new NullReferenceException();
		return (PlayerRef)ex2;
		IL_0533:
		return networkApe3.ownerRef;
		IL_053d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v16+E4]");
		bool flag13 = (nint)0 == 0;
		object obj15 = !flag13;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return PlayerRef.None;
		IL_0290:
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v11+E4]");
		bool flag14 = (nint)0 == 0;
		object obj17 = !flag14;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = (UnityEngine.Object)second != (UnityEngine.Object)null;
		bool flag16 = !flag15;
		object obj18 = 0;
		UnityEngine.Object obj19 = null;
		if (!flag16)
		{
			bool flag17 = secondRight != right;
			obj18 = 0;
			obj19 = null;
			if (!flag17)
			{
				NetworkApe networkApe4 = second;
				if ((object)second != null)
				{
					object obj20 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v21+E4]");
					bool flag18 = (nint)0 == 0;
					object obj21 = !flag18;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag19 = (UnityEngine.Object)((SimulationBehaviour)networkApe4)._object != (UnityEngine.Object)null;
					bool flag20 = !flag19;
					obj18 = 0;
					obj19 = null;
					if (flag20)
					{
						goto IL_053d;
					}
					NetworkApe networkApe5 = second;
					if ((object)second != null)
					{
						UnityEngine.Object obj22 = ((SimulationBehaviour)networkApe5)._object;
						if ((object)((SimulationBehaviour)networkApe5)._object != null)
						{
							object obj23 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v26+E4]");
							bool flag21 = (nint)0 == 0;
							object obj24 = !flag21;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X20_v8 (UnityEngine.Object)+30]");
							bool flag22 = (UnityEngine.Object)0;
							bool flag23 = !flag22;
							obj18 = 0;
							obj19 = null;
							if (flag23)
							{
								goto IL_053d;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X20_v8 (UnityEngine.Object)+30]");
							if ((nint)0 != 0)
							{
								ArgumentNullException ex3 = new ArgumentNullException();
								object obj25 = ex3 & 1;
								bool flag24 = obj25 == null;
								obj18 = 0;
								obj19 = ((SimulationBehaviour)networkApe5)._object;
								if (flag24)
								{
									goto IL_053d;
								}
								networkApe3 = second;
								if ((object)second != null)
								{
									goto IL_0533;
								}
							}
						}
					}
				}
				goto IL_05a2;
			}
		}
		goto IL_053d;
	}

	private void Swap()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		held = second;
		object obj = this + 672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 696;
		second = held;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = this + 680;
		heldDummy = secondDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = this + 704;
		secondDummy = heldDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		heldRight = secondRight;
		secondRight = heldRight;
		heldSince = secondSince;
		secondSince = heldSince;
	}

	private void AsSecond(Action act)
	{
		Swap();
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: act.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		Swap();
	}

	private bool TakeSecond(bool right, float reach)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01df: Expected I4, but got Obj
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I8
		//IL_0175: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		//IL_01a0: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD128]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass255_0 obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool hasSecond = HasSecond;
			bool flag = !hasSecond;
			object obj4 = !flag;
			if (obj4 == null)
			{
				int[] array = bodyOf;
				if (bodyOf == null)
				{
					goto IL_01c3;
				}
				bool flag2 = (obj2.right ? 1 : 0) < array.Length;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					goto IL_01d1;
				}
				object obj6 = bodyOf + obj2.right;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X9_v5+20]");
				object obj7 = 0 & 0x80000000L;
				if (obj7 != null)
				{
					bool flag3 = !obj2.right;
					bool right2 = !flag3;
					if (!SlabIn(right2))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD130]");
						object obj9 = 0;
						Action action = default;
						action._002Ector(obj2, (IntPtr)obj9);
						AsSecond(action);
						return HasSecond;
					}
				}
			}
			return false;
		}
		goto IL_01c3;
		IL_01c3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01d1;
		IL_01d1:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private void Both(float reach)
	{
		//IL_018a: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		Bodies(reach, grab: false);
		bool flag = Smashing();
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD120]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		InThisHand();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(this, (IntPtr)obj3);
		AsSecond(action);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)held == (UnityEngine.Object)null)
		{
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)heldDummy == (UnityEngine.Object)null)
			{
				Swap();
			}
		}
	}

	private bool Smashing()
	{
		//IL_0010: Expected Obj, but got I
		//IL_07d1: Expected I4, but got Obj
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0061: Invalid comparison between F4 and I
		//IL_009f: Invalid comparison between F4 and I
		//IL_00e8: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_0811: Expected Obj, but got I
		//IL_086a: Expected Obj, but got I4
		//IL_022c: Invalid comparison between Obj and F4
		//IL_0261: Invalid comparison between F4 and I
		//IL_0c0e: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I
		//IL_0469: Expected Obj, but got I
		//IL_0471: Expected F4, but got Obj
		//IL_0481: Expected F4, but got I
		//IL_0491: Expected F4, but got I
		//IL_0c50: Expected Obj, but got I
		//IL_0c85: Expected Obj, but got I4
		//IL_088a: Expected VT, but got F4
		//IL_03d4: Invalid comparison between F4 and I
		//IL_04ad: Expected Obj, but got I4
		//IL_049f: Expected Obj, but got I4
		//IL_04c9: Expected Obj, but got I4
		//IL_04bb: Expected Obj, but got I4
		//IL_04e5: Expected Obj, but got I4
		//IL_04d7: Expected Obj, but got I4
		//IL_0501: Expected VT, but got I4
		//IL_04f3: Expected VT, but got I4
		//IL_051d: Expected Obj, but got I4
		//IL_050f: Expected Obj, but got I4
		//IL_0539: Expected Obj, but got I4
		//IL_052b: Expected Obj, but got I4
		//IL_0555: Expected Obj, but got I4
		//IL_0547: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I4
		//IL_0563: Expected Obj, but got I4
		//IL_058d: Expected Obj, but got I4
		//IL_057f: Expected Obj, but got I4
		//IL_05a9: Expected Obj, but got I4
		//IL_099e: Expected Obj, but got I
		//IL_09bb: Expected Obj, but got I
		//IL_059b: Expected Obj, but got I4
		//IL_05c5: Expected Obj, but got I4
		//IL_09fa: Expected Obj, but got I
		//IL_0a17: Expected Obj, but got I
		//IL_05b7: Expected Obj, but got I4
		//IL_05e1: Expected VT, but got I4
		//IL_0a56: Expected Obj, but got I
		//IL_0a91: Expected Obj, but got I
		//IL_0b21: Invalid comparison between F4 and I4
		//IL_0b30: Invalid comparison between F4 and I4
		//IL_0b43: Expected Obj, but got F4
		//IL_0b50: Expected Obj, but got F4
		//IL_0b85: Expected Obj, but got I4
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Expected Obj, but got Unknown
		//IL_05d3: Expected VT, but got I4
		//IL_0647: Expected Obj, but got F4
		//IL_0650: Expected Obj, but got F4
		//IL_0659: Expected Obj, but got F4
		//IL_06c2: Expected VT, but got F4
		//IL_06dc: Expected VT, but got I4
		//IL_06ec: Expected Obj, but got I
		//IL_070b: Expected Obj, but got I
		//IL_071c: Expected I, but got Obj
		//IL_0755: Expected Obj, but got I4
		//IL_0791: Expected F4, but got I
		//IL_07b0: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD148]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		MonsterWounds._003C_003Ec__DisplayClass257_0 obj2 = default;
		obj2._002Ector();
		float num2;
		object obj4;
		object obj9 = default;
		float num10;
		float num11;
		float num12;
		float num13;
		float num14;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			float time = Time.time;
			float num = time - heldSince;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			if (!(num < 0f))
			{
				float time2 = Time.time;
				num2 = time2 - secondSince;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				if (!(num2 < 0f))
				{
					Transform transform = Holding(heldRight);
					Transform transform2 = Holding(secondRight);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
					obj4 = 0;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v7+E4]");
					bool flag = (nint)0 == 0;
					object obj6 = !flag;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Vector3 vector = MiddleOf(held, heldDummy, transform);
					Vector3 vector2 = MiddleOf(second, secondDummy, transform2);
					Transform transform3 = base.transform;
					if ((object)transform3 != null)
					{
						Vector3 localScale = transform3.localScale;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj7 = 0;
						float num3 = num2 - num2;
						float num4 = secondSince - secondSince;
						object obj8 = obj9 - obj9;
						object obj10 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v27+E4]");
						bool flag2 = (nint)0 == 0;
						object obj11 = !flag2;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num5 = num3 * num3;
						float num6 = num4 * num4;
						float num7 = num5 + num6;
						object obj12 = obj8 * obj8;
						float num8 = (float)obj12 + num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
						float num9 = 0f * smashMeet;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num9))
						{
							goto IL_0243;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
						if (num8 > 0f)
						{
							object obj13 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v60+E4]");
							bool flag3 = (nint)0 == 0;
							object obj14 = !flag3;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							bool flag4 = (nint)obj9 <= 0;
							num10 = secondSince;
							num11 = num2;
							if (flag4)
							{
								goto IL_0441;
							}
							num12 = num3 / (float)obj9;
							num13 = num4 / (float)obj9;
							num14 = (float)obj8 / (float)obj9;
							num10 = secondSince;
							num11 = num2;
							goto IL_087d;
						}
						if ((object)transform2 != null)
						{
							Vector3 position = transform2.position;
							if ((object)transform != null)
							{
								Vector3 position2 = transform.position;
								object obj15 = obj7;
								float num15 = num8 - num8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
								nint num16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
								object obj16 = num16 - 0;
								float num17 = smashMeet - smashMeet;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X0_v49+E4]");
								bool flag5 = (nint)0 == 0;
								object obj17 = !flag5;
								if (obj17 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								float num18 = num15 * num15;
								object obj18 = obj16 * obj16;
								float num19 = num18 + (float)obj18;
								float num20 = num17 * num17;
								float num21 = num20 + num19;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								bool flag6 = !(num21 > 0f);
								num10 = secondSince;
								num11 = num2;
								if (flag6)
								{
									goto IL_0441;
								}
								num12 = num15 / num21;
								num13 = (float)obj16 / num21;
								num14 = num17 / num21;
								num10 = secondSince;
								num11 = num2;
								goto IL_087d;
							}
						}
					}
					goto IL_07c3;
				}
			}
			goto IL_0243;
		}
		goto IL_07c3;
		IL_0441:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj19 = 0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v30+A0]");
		object obj21 = 0;
		num12 = (float)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v31+4]");
		num13 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v31+8]");
		num14 = 0f;
		goto IL_087d;
		IL_087d:
		obj2.way = (Vector3)num12;
		if (!heldRight)
		{
			object obj22 = 516;
		}
		else
		{
			object obj22 = 528;
		}
		if (!heldRight)
		{
			object obj23 = 512;
		}
		else
		{
			object obj23 = 524;
		}
		if (!heldRight)
		{
			object obj24 = 508;
		}
		else
		{
			object obj24 = 520;
		}
		Vector3 faces = (heldRight ? ((Vector3)600) : ((Vector3)588));
		if (!heldRight)
		{
			object obj25 = 584;
		}
		else
		{
			object obj25 = 596;
		}
		if (!heldRight)
		{
			object obj26 = 580;
		}
		else
		{
			object obj26 = 592;
		}
		if (!secondRight)
		{
			object obj27 = 512;
		}
		else
		{
			object obj27 = 524;
		}
		if (!secondRight)
		{
			object obj28 = 508;
		}
		else
		{
			object obj28 = 520;
		}
		if (!secondRight)
		{
			object obj29 = 584;
		}
		else
		{
			object obj29 = 596;
		}
		if (!secondRight)
		{
			object obj30 = 580;
		}
		else
		{
			object obj30 = 592;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v417 @ X17_v2]");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v729 @ X9_v7]");
		object obj31 = num22 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v418 @ X16_v2]");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v725 @ X11_v3]");
		object obj32 = num23 - 0;
		if (!secondRight)
		{
			object obj33 = 516;
		}
		else
		{
			object obj33 = 528;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v483 @ X21_v9]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v415 @ X11_v4]");
		object obj34 = num24 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v416 @ X7_v2]");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v445 @ X9_v8]");
		object obj35 = num25 - 0;
		if (!secondRight)
		{
			Vector3 vector3 = (Vector3)588;
		}
		else
		{
			Vector3 vector3 = (Vector3)600;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v419 @ X15_v2]");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v749 @ X8_v15]");
		object obj36 = num26 - 0;
		float num27 = (float)obj31 * num12;
		float num28 = (float)obj32 * num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v443 @ X2_v6 (UnityEngine.Vector3)]");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v480 @ X8_v16 (UnityEngine.Vector3)]");
		object obj37 = num29 - 0;
		float num30 = (float)obj34 * num12;
		float num31 = (float)obj35 * num13;
		float num32 = num27 + num28;
		float num33 = (float)obj36 * num14;
		float num34 = num30 + num31;
		float num35 = (float)obj37 * num14;
		float num36 = num33 + num32;
		float num37 = num35 + num34;
		float num38 = num36 - num37;
		bool flag7 = num38 < 0f;
		bool flag8 = num38 == 0f;
		object obj38 = num36 ^ num37;
		object obj39 = num36 ^ num38;
		object obj40 = obj38 & obj39;
		bool flag9 = (nint)obj40 < 0;
		bool flag10 = flag7 == flag9;
		object obj41 = !flag8;
		object obj42 = flag10 & obj41;
		object obj43 = ~obj42;
		if (obj43 != null)
		{
			num36 = num37;
		}
		float num39 = num2 * smashSwing;
		bool flag11 = num36 < num39;
		bool result = false;
		if (!flag11)
		{
			float num40 = num2 * 30f;
			bool flag12 = num36 > num40;
			result = false;
			if (!flag12)
			{
				object obj44 = obj9 + obj9;
				object obj45 = 0f - num12;
				object obj46 = 0f - num13;
				object obj47 = 0f - num14;
				float num41 = num11 + num2;
				float num42 = num10 + secondSince;
				float num43 = num41 * 0.5f;
				double num44 = (double)num42 * 0.5;
				double num45 = (double)obj44 * 0.5;
				obj2.at = (Vector3)num43;
				SmashOne((Vector3)secondRight, faces);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD150]");
				object obj49 = 0;
				Action action = default;
				action._002Ector(obj2, (IntPtr)obj49);
				AsSecond(action);
				object obj50 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X0_v36+E4]");
				bool flag13 = (nint)0 == 0;
				object obj51 = !flag13;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
				Buzz((XRNode)4, 1f, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
				Buzz((XRNode)5, 1f, 0f);
				result = true;
			}
		}
		goto IL_0bdf;
		IL_07c3:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0bdf:
		return result;
		IL_0243:
		result = false;
		goto IL_0bdf;
	}

	private unsafe void SmashOne(Vector3 at, Vector3 faces)
	{
		//IL_0422: Expected Obj, but got I
		//IL_047c: Expected Obj, but got I
		//IL_04a6: Expected Obj, but got I
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected Obj, but got Unknown
		//IL_04dd: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_0283: Expected Obj, but got I4
		//IL_03f7: Expected VT, but got I4
		//IL_030c: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I4
		//IL_03da: Expected VT, but got I4
		//IL_03da: Expected VT, but got Obj
		//IL_01c6: Expected VT, but got I
		//IL_01c6: Expected VT, but got I4
		//IL_01c6: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj3 = default;
		object obj4 = default;
		object obj2 = obj3 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj5 = 0;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v9+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10+18]");
		object obj10 = default;
		object obj9 = 0 * obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = obj2 + obj9;
		bool flag2 = (UnityEngine.Object)held != (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj13 = 0;
		UnityEngine.Object obj14 = null;
		if (!flag3)
		{
			NetworkApe networkApe = held;
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v33+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = (UnityEngine.Object)((SimulationBehaviour)networkApe)._object != (UnityEngine.Object)null;
			bool flag6 = !flag5;
			obj13 = 0;
			obj14 = null;
			if (!flag6)
			{
				NetworkApe networkApe2 = held;
				UnityEngine.Object obj17 = ((SimulationBehaviour)networkApe2)._object;
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v38+E4]");
				bool flag7 = (nint)0 == 0;
				object obj19 = !flag7;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X20_v12 (UnityEngine.Object)+30]");
				bool flag8 = (UnityEngine.Object)0;
				bool flag9 = !flag8;
				obj13 = 0;
				obj14 = null;
				if (!flag9)
				{
					ArgumentNullException ex = new ArgumentNullException();
					object obj20 = ex & 1;
					bool flag10 = obj20 == null;
					obj13 = 0;
					obj14 = obj17;
					if (!flag10)
					{
						object obj21 = default;
						IntPtr intPtr = default;
						RpcInfo info = default;
						held.RPC_Slam((Vector3)(&obj21), (Vector3)0, (Vector3)(nint)intPtr, info);
						HeldDied();
						return;
					}
				}
			}
		}
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v11+E4]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)heldDummy != (UnityEngine.Object)null))
		{
			return;
		}
		GillaDummy gillaDummy = heldDummy;
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v15+E4]");
		bool flag12 = (nint)0 == 0;
		object obj25 = !flag12;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gillaDummy.tearing != null)
		{
			Dismemberment tearing = gillaDummy.tearing;
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v22+E4]");
			bool flag13 = (nint)0 == 0;
			object obj27 = !flag13;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (tearing.bloodMaterial != null)
			{
				Dismemberment tearing2 = gillaDummy.tearing;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
				object obj28 = 0;
				object obj29 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v26+E4]");
				bool flag14 = (nint)0 == 0;
				object obj30 = !flag14;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float size = default;
				Blood.Burst((Vector3)tearing2.bloodMaterial, (Vector3)0, null, size);
			}
		}
		gillaDummy.Blasted((Vector3)0, 0, apart: false);
		DummyDied(gillaDummy);
	}

	private static Vector3 MiddleOf(NetworkApe who, GillaDummy d, Transform hand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_0228: Expected VT, but got Obj
		//IL_00a4: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)who != (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = 0;
		UnityEngine.Object obj5 = null;
		if (flag3)
		{
			goto IL_014a;
		}
		if ((object)who != null)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = who.head != null;
			bool flag6 = !flag5;
			obj4 = 0;
			obj5 = null;
			if (flag6)
			{
				goto IL_014a;
			}
			if ((object)who.head != null)
			{
				Vector3 position = who.head.position;
				return who.MiddleFromEyes;
			}
		}
		goto IL_021a;
		IL_014a:
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)d != (UnityEngine.Object)null)
		{
			if ((object)d != null)
			{
				return d.Middle;
			}
		}
		else if ((object)hand != null)
		{
			return hand.position;
		}
		goto IL_021a;
		IL_021a:
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	private void InThisHand()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0486: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_04bf: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_009d: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_021d: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I4
		//IL_03f7: Expected Obj, but got I4
		//IL_029e: Expected VT, but got I
		//IL_04f7: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_042d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool flag = !heldRight;
		object obj2 = obj;
		if (!heldRight)
		{
		}
		if (!heldRight)
		{
		}
		if (!heldRight)
		{
		}
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			object obj5 = 477 + 1;
		}
		else
		{
			object obj5 = 477;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7;
		if ((UnityEngine.Object)heldDummy != (UnityEngine.Object)null)
		{
			obj7 = this + 680;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v47+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef you = You;
			bool flag4 = heldRight;
			if (((GillaDummy)obj7).HeldBy(you, heldRight))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v26 (MonsterPlayer)+v89 @ X9_v2]");
				if ((nint)0 != 0)
				{
					bool flag5 = SlammingDummy(heldDummy);
				}
				else
				{
					DropDummy((Vector3)you);
				}
				return;
			}
		}
		else
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)held == (UnityEngine.Object)null)
			{
				return;
			}
			obj7 = this + 672;
			object obj13 = obj7;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v15+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v10+40]");
			bool flag8 = (UnityEngine.Object)0 == null;
			bool flag9 = !flag8;
			object obj16 = !flag9;
			bool flag4 = false;
			if (obj16 == null)
			{
				object obj17 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v11+40]");
				Vector3 vector = (Vector3)0;
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v20+E4]");
				bool flag10 = (nint)0 == 0;
				object obj19 = !flag10;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X21_v5 (UnityEngine.Vector3)+30]");
				bool flag11 = (UnityEngine.Object)0;
				bool flag12 = !flag11;
				flag4 = false;
				if (!flag12)
				{
					ArgumentNullException ex = new ArgumentNullException();
					object obj20 = ex & 1;
					bool flag13 = obj20 == null;
					flag4 = false;
					if (!flag13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v26 (MonsterPlayer)+v89 @ X9_v2]");
						Vector3 velocity;
						if ((nint)0 != 0)
						{
							float time = Time.time;
							float num = time - heldSince;
							if (!(num > neverHeldAfter) || ((NetworkApe)obj7).Busy)
							{
								if (((NetworkApe)obj7).Busy)
								{
									bool flag14 = Slamming();
								}
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
							velocity = (Vector3)0;
						}
						else
						{
							velocity = vector;
						}
						Drop(velocity);
						return;
					}
				}
			}
		}
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public Transform HoldPoint(bool right)
	{
		return Holding(right);
	}

	private unsafe void TakeDummy(bool right, List<Vector3> touching, float reach)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I4
		//IL_050c: Expected Obj, but got I
		//IL_052e: Expected Obj, but got I4
		//IL_0702: Expected Obj, but got I
		//IL_0724: Expected Obj, but got I4
		//IL_00cf: Expected VT, but got I4
		//IL_01ad: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I4
		//IL_0202: Expected VT, but got Ref
		//IL_0230: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I4
		//IL_0566: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_0163: Expected VT, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_018f: Expected VT, but got I4
		//IL_02f8: Expected Obj, but got I4
		//IL_0389: Expected Obj, but got I4
		//IL_03d9: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I
		//IL_05d9: Expected Obj, but got I
		//IL_05e9: Expected F4, but got I
		//IL_0625: Expected Obj, but got I
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_058a: Expected VT, but got I4
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		//IL_0683: Expected Obj, but got I
		//IL_06a3: Expected Obj, but got I4
		//IL_06dc: Expected Obj, but got I4
		//IL_04ee: Expected F4, but got I
		//IL_04ee: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj2 = 0;
		Vector3 vector = touching.get_Item(0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v10+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj9 != null;
		bool flag5 = !flag4;
		Vector3 vector2 = (Vector3)0;
		if (!flag5)
		{
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v65+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v69+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v69+A0]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v39+A8]");
			Vector3 position = ((Transform)0).position;
			bool flag8 = Walled(position, (Vector3)0);
			bool flag9 = !flag8;
			object obj17 = !flag9;
			vector2 = (Vector3)0;
			if (obj17 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v16+E4]");
		bool flag10 = (nint)0 == 0;
		object obj20 = !flag10;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj21 = default;
		GillaDummy gillaDummy = GillaDummy.Nearest((Vector3)(&obj21), reach, out *(float*)null);
		object obj22 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v16+E4]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = (UnityEngine.Object)gillaDummy == (UnityEngine.Object)null;
		bool flag13 = !flag12;
		object obj24 = !flag13;
		if (obj24 != null)
		{
			return;
		}
		Transform transform = Holding(right);
		Vector3 position2 = transform.position;
		Transform transform2 = base.transform;
		Vector3 localScale = transform2.localScale;
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v29+E4]");
		bool flag14 = (nint)0 == 0;
		object obj26 = !flag14;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj27 = default;
		float num = skinTouch * (float)obj27;
		if (OnBody(gillaDummy.tearing, null, null, touching, num))
		{
			object obj28 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v34+E4]");
			bool flag15 = (nint)0 == 0;
			object obj29 = !flag15;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef you = You;
			object obj30 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v20+E4]");
			bool flag16 = (nint)0 == 0;
			object obj31 = !flag16;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag17 = gillaDummy.head != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj32 = 0;
			if (flag17)
			{
				Vector3 position3 = gillaDummy.head.position;
				float num2 = num - reach;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				object obj34 = default;
				object obj33 = 0 - obj34;
				object obj35 = default;
				float num3 = (float)obj35 - (float)obj35;
				float num4 = reach;
			}
			else
			{
				object obj36 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v31+A0]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v32+20]");
				float num4 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v32+18]");
				float num5 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB7C]");
				float num2 = num5 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v32+1C]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB7C]");
				object obj33 = num6 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v32+20]");
				float num7 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB7C]");
				float num3 = num7 * 0f;
			}
			gillaDummy.Grab(you, right, (Vector3)0);
			object obj38 = this + 680;
			heldDummy = gillaDummy;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			heldRight = right;
			float time = Time.time;
			heldSince = time;
			object obj39 = obj32;
			object obj40 = this + 612;
			object obj41 = obj2;
			bool flag18 = !right;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v24+A0]");
			object obj42 = 0;
			obj40 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v25+8]");
			_ = 0;
			object obj43 = !flag18;
			object obj44 = ~obj43;
			XRNode node = ((obj44 != null) ? ((XRNode)4) : ((XRNode)5));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v45+E4]");
			bool flag19 = (nint)0 == 0;
			object obj45 = !flag19;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			Buzz(node, num8, 0f);
		}
	}

	private unsafe void HoldingDummy(float reach)
	{
		//IL_0010: Expected Obj, but got I
		//IL_09a3: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I4
		//IL_045f: Expected Obj, but got I4
		//IL_0a64: Expected VT, but got I4
		//IL_0483: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I4
		//IL_0415: Expected Obj, but got I4
		//IL_024a: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got I4
		//IL_08a7: Expected Obj, but got I4
		//IL_08e3: Expected F4, but got I
		//IL_0902: Expected F4, but got I
		//IL_02e1: Expected Obj, but got I8
		//IL_02fb: Expected Obj, but got I4
		//IL_093b: Expected Obj, but got I4
		//IL_0349: Expected Obj, but got I4
		//IL_04f9: Expected Obj, but got I
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected VT, but got Unknown
		//IL_053a: Expected Obj, but got I
		//IL_0655: Expected Obj, but got I4
		//IL_0a90: Expected Obj, but got I
		//IL_06a6: Expected Obj, but got I
		//IL_06d5: Expected Obj, but got I4
		//IL_0ac9: Expected Obj, but got I
		//IL_0af3: Expected Obj, but got I4
		//IL_0771: Expected Obj, but got I4
		//IL_0615: Invalid comparison between F4 and I4
		//IL_0b21: Expected Obj, but got I4
		//IL_0b43: Expected Obj, but got I4
		//IL_07d3: Expected F4, but got I
		//IL_07d3: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		UnityEngine.Object obj3 = heldDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)heldDummy == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		bool flag4 = false;
		object obj6;
		ApePart part;
		float num;
		double num2;
		ApePart apePart = default;
		bool grab;
		float num4;
		ref float reference;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef you = You;
			if ((object)heldDummy == null)
			{
				goto IL_095a;
			}
			flag4 = heldRight;
			if (heldDummy.HeldBy(you, heldRight))
			{
				bool flag6 = !heldRight;
				object obj9 = !flag6;
				object obj10 = ~obj9;
				if (obj10 == null)
				{
					object obj11 = 477 + 1;
				}
				else
				{
					object obj11 = 477;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v520 @ X8_v12]");
				if ((nint)0 != 0)
				{
					if (~(ripping ? 1u : 0u) != 0)
					{
						bool flag7 = SlammingDummy(heldDummy);
						bool flag8 = !flag7;
						object obj12 = !flag8;
						if (obj12 != null)
						{
							return;
						}
						bool flag9 = (byte)(~(ripping ? 1u : 0u)) != 0;
						object obj13 = !flag9;
						if (obj13 == null && PunchingDummy(heldDummy))
						{
							return;
						}
					}
					bool flag10 = heldRight;
					if (!heldRight)
					{
						object obj14 = 477 + 1;
					}
					else
					{
						object obj14 = 477;
					}
					if (!flag10)
					{
						object obj15 = 200;
					}
					else
					{
						object obj15 = 192;
					}
					if (!flag10)
					{
						object obj16 = 479 + 1;
					}
					else
					{
						object obj16 = 479;
					}
					if (!flag10)
					{
						object obj17 = 192;
					}
					else
					{
						object obj17 = 200;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v544 @ X9_v10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v560 @ X11_v6]");
						bool flag11 = (nint)0 == 0;
						object obj18 = !flag11;
						if (obj18 == null)
						{
							int[] array = bodyOf;
							if (bodyOf == null)
							{
								goto IL_095a;
							}
							object obj19 = (flag10 ? 1 : 0) ^ 1;
							bool flag12 = (nint)obj19 < array.Length;
							object obj20 = !flag12;
							if (obj20 != null)
							{
								goto IL_0968;
							}
							object obj21 = (object)bodyOf + obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X11_v11+20]");
							object obj22 = 0 & 0x80000000L;
							bool flag13 = obj22 == null;
							object obj23 = !flag13;
							reference = ref *(float*)null;
							if (obj23 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v105 @ X10_v9]");
								if ((nint)0 == 0)
								{
									goto IL_095a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v105 @ X10_v9]");
								Vector3 position = ((Transform)0).position;
								Vector3 hand = (Vector3)(this + 720);
								bool flag14 = heldDummy.PartNear(hand, reach, out part, out *(float*)null);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v105 @ X10_v9]");
								Vector3 position2 = ((Transform)0).position;
								Vector3 middle = heldDummy.Middle;
								num = reach - reach;
								object obj24 = default;
								num2 = (double)obj24 - (double)obj24;
								apePart -= apePart;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
								if (num < reach)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X20_v3 (UnityEngine.Object)+C4]");
									if ((nint)0 >= (nint)punchesBeforeRip)
									{
										bool flag16;
										if (flag14)
										{
											num2 = (double)part * 1.5;
											float num3 = num - (float)num2;
											bool flag15 = num3 < 0f;
											apePart = part;
											flag16 = flag15;
										}
										else
										{
											flag16 = true;
										}
										ripWhole = flag16;
										goto IL_0a74;
									}
								}
								ripWhole = false;
								bool flag17 = !flag14;
								object obj25 = !flag17;
								if (obj25 != null)
								{
									goto IL_0a74;
								}
								flag10 = heldRight;
								num4 = reach;
								reference = ref *(float*)null;
								flag4 = (byte)(&part) != 0;
							}
							bool right = !flag10;
							bool flag18 = TakeSecond(right, reach);
							bool flag19 = !flag18;
							object obj26 = !flag19;
							if (obj26 == null)
							{
								bool flag20 = !ripping;
								grab = flag20;
								goto IL_0a26;
							}
							return;
						}
					}
					bool flag21 = !ripping;
					Bodies(reach, flag21);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v544 @ X9_v10]");
					bool flag22 = (nint)0 == 0;
					object obj27 = !flag22;
					reference = ref *(float*)null;
					grab = flag21;
					if (obj27 == null)
					{
						goto IL_0396;
					}
					goto IL_07f6;
				}
				Bodies(reach, grab: false);
				if (!heldRight)
				{
				}
				if (!heldRight)
				{
				}
				if (!heldRight)
				{
				}
				DropDummy((Vector3)0);
				return;
			}
		}
		object obj28 = this + 680;
		heldDummy = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_0396;
		IL_095a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0968;
		IL_0a74:
		ripping = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v105 @ X10_v9]");
		Vector3 position3 = ((Transform)0).position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v114 @ X9_v12]");
		if ((nint)0 == 0)
		{
			goto IL_095a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v114 @ X9_v12]");
		Vector3 position4 = ((Transform)0).position;
		float num5 = num - num;
		double num6 = num2 - num2;
		object obj29 = apePart - apePart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj30 = 0;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v58+E4]");
		bool flag23 = (nint)0 == 0;
		object obj32 = !flag23;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num7 = num5 * num5;
		double num8 = num6 * num6;
		float num9 = num7 + (float)num8;
		object obj33 = obj29 * obj29;
		float num10 = num9 + (float)obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		ripStart = num10;
		float reallyApart = ReallyApart;
		object obj34 = obj6;
		ripStartReal = reallyApart;
		object obj35 = 17285120 + 1288;
		XRNode node = (heldRight ? ((XRNode)4) : ((XRNode)5));
		bool flag24 = !ripWhole;
		object obj36 = 17285120 + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X0_v61+E4]");
		bool flag25 = (nint)0 == 0;
		object obj37 = !flag25;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X8_v39+v680 @ Z_v15 (System.Boolean)*4]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v41+v680 @ Z_v15 (System.Boolean)*4]");
		Buzz(node, num11, 0f);
		num4 = reach;
		reference = ref *(float*)null;
		flag4 = (byte)(&part) != 0;
		grab = false;
		goto IL_0a26;
		IL_0968:
		throw new IndexOutOfRangeException();
		IL_0396:
		ripping = false;
		return;
		IL_07f6:
		if (~(ripping ? 1u : 0u) != 0 || !PulledApart(ripStart, ripStartReal))
		{
			return;
		}
		if (~(ripWhole ? 1u : 0u) == 0)
		{
			RipDummy(heldDummy);
			return;
		}
		heldDummy.Tear(ripPart);
		object obj38 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v31+E4]");
		bool flag26 = (nint)0 == 0;
		object obj39 = !flag26;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		Buzz((XRNode)4, 1f, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		Buzz((XRNode)5, 1f, 0f);
		ripping = false;
		bool alive = heldDummy.Alive;
		bool flag27 = !alive;
		object obj40 = !flag27;
		if (obj40 == null)
		{
			DummyDied(heldDummy);
		}
		return;
		IL_0a26:
		Bodies(reach, grab);
		goto IL_07f6;
	}

	private unsafe bool PunchingDummy(GillaDummy d)
	{
		//IL_072b: Expected I4, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_08a7: Expected Obj, but got I
		//IL_08bf: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I
		//IL_012f: Expected VT, but got Obj
		//IL_0149: Expected VT, but got I
		//IL_0159: Expected Obj, but got I
		//IL_076c: Expected Obj, but got VT
		//IL_0779: Expected Obj, but got VT
		//IL_080f: Invalid comparison between F4 and I4
		//IL_081e: Invalid comparison between F4 and I4
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected Obj, but got Unknown
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected Obj, but got Unknown
		//IL_0873: Expected Obj, but got I4
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_00af: Expected VT, but got Obj
		//IL_00c9: Expected VT, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_091e: Expected VT, but got I4
		//IL_092d: Invalid comparison between F4 and I4
		//IL_0951: Expected Obj, but got I
		//IL_097b: Expected Obj, but got I4
		//IL_0237: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I4
		//IL_09bb: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I
		//IL_03f5: Expected Obj, but got I4
		//IL_0391: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I4
		//IL_045a: Expected Obj, but got I
		//IL_04ff: Expected VT, but got Ref
		//IL_04ff: Expected VT, but got Ref
		//IL_051d: Expected Obj, but got I4
		//IL_09d9: Expected Obj, but got I
		//IL_09f1: Expected Obj, but got I
		//IL_0a15: Expected VT, but got I4
		//IL_0a25: Expected Obj, but got I
		//IL_0a5f: Expected Obj, but got I4
		//IL_0576: Expected Obj, but got I
		//IL_05a3: Expected VT, but got Ref
		//IL_05a3: Expected VT, but got Ref
		//IL_063e: Expected F4, but got I
		//IL_0662: Expected Obj, but got I4
		//IL_0a8f: Expected Obj, but got I4
		//IL_06c8: Expected F4, but got I
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			object obj = this + 508;
			Vector3 localScale = transform.localScale;
			bool flag = !heldRight;
			if (Fist(flag))
			{
				object obj2;
				object obj3;
				object obj4;
				Vector3 vector;
				Vector3 vector2;
				Vector3 vector3;
				Vector3 vector4;
				object obj5;
				if (~(heldRight ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+204]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+210]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+24C]");
					obj4 = 0;
					vector = (Vector3)obj;
					vector2 = velR;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X25_v2+48]");
					vector3 = (Vector3)0;
					vector4 = realVelR;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+258]");
					obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+210]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+204]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+258]");
					obj4 = 0;
					vector = velR;
					vector2 = (Vector3)obj;
					vector3 = realVelR;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X25_v2+48]");
					vector4 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+24C]");
					obj5 = 0;
				}
				object obj6 = obj2 - obj3;
				object obj7 = vector - vector2;
				object obj8 = vector3 - vector4;
				object obj9 = obj4 - obj5;
				object obj10 = obj7 * obj7;
				object obj11 = obj8 * obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				object obj12 = obj7 * obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj13 = obj5 + obj10;
				object obj14 = obj9 * obj9;
				object obj15 = obj11 + obj14;
				float num = (float)obj12 + (float)obj13;
				float num2 = (float)obj15 - num;
				bool flag2 = num2 < 0f;
				bool flag3 = num2 == 0f;
				object obj16 = obj15 ^ num;
				object obj17 = obj15 ^ num2;
				object obj18 = obj16 & obj17;
				bool flag4 = (nint)obj18 < 0;
				bool flag5 = flag2 == flag4;
				object obj19 = !flag3;
				object obj20 = flag5 & obj19;
				object obj21 = ~obj20;
				object obj22 = ((obj21 != null) ? obj6 : obj9);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
				float deltaTime = Time.deltaTime;
				Vector3 vector5 = Swung((Vector3)flag, num);
				if (!(punchIn > 0f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj23 = 0;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v21+E4]");
					bool flag6 = (nint)0 == 0;
					object obj25 = !flag6;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num3 = num * num;
					object obj27 = default;
					object obj26 = obj27 * obj27;
					float num4 = num3 + (float)obj26;
					object obj28 = obj22 * obj22;
					float num5 = (float)obj28 + num4;
					object obj29 = default;
					float num6 = (float)obj29 * punchSwing;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					if (!(num5 < num6))
					{
						if ((object)d != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj30 = 0;
							object obj31 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v23+E4]");
							bool flag7 = (nint)0 == 0;
							object obj32 = !flag7;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag8 = d.tearing == null;
							bool flag9 = !flag8;
							object obj33 = !flag9;
							if (obj33 != null)
							{
								goto IL_06f7;
							}
							object obj34 = obj30;
							if (!heldRight)
							{
								object obj35 = 200;
							}
							else
							{
								object obj35 = 192;
							}
							if (!heldRight)
							{
								object obj36 = 192;
							}
							else
							{
								object obj36 = 200;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v27+E4]");
							bool flag10 = (nint)0 == 0;
							object obj37 = !flag10;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (worn != null)
							{
								if ((object)worn == null)
								{
									goto IL_071d;
								}
								bool flag11 = !heldRight;
								Vector3 vector6 = worn.FistFromHand(flag11);
								object obj38 = 0;
								UnityEngine.Object obj39 = (UnityEngine.Object)flag11;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
								object obj38 = 0;
								UnityEngine.Object obj39 = null;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
							object obj40 = 0;
							object obj41 = obj40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v32+E4]");
							bool flag12 = (nint)0 == 0;
							object obj42 = !flag12;
							if (obj42 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GillaWounds gillaWounds = GillaWounds.On(d.tearing);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v246 @ X8_v21]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v246 @ X8_v21]");
								Vector3 position = ((Transform)0).position;
								bool flag13 = !heldRight;
								bool right = !flag13;
								Vector3 vector7 = RealHand(flag13);
								Vector3 vector8 = RealHand(right);
								if ((object)gillaWounds != null)
								{
									float num7 = num5 + num5;
									float num8 = num7 - num5;
									float num9 = num5 + num8;
									GoreSection section = default;
									object obj43 = default;
									ref Vector3 point = default;
									bool flag14 = gillaWounds.Hit((Vector3)(&section), num9, (Vector3)(&obj43), out *(GoreSection*)null, out point);
									bool flag15 = !flag14;
									object obj44 = !flag15;
									ref GoreSection reference = ref *(GoreSection*)null;
									object obj45 = obj22;
									object obj46 = obj27;
									if (obj44 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v121 @ X10_v4]");
										if ((nint)0 == 0)
										{
											goto IL_071d;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v121 @ X10_v4]");
										Vector3 position2 = ((Transform)0).position;
										float reach = num5 + num9;
										bool flag16 = gillaWounds.Hit((Vector3)(&section), reach, (Vector3)(&obj43), out *(GoreSection*)null, out point);
										bool flag17 = !flag16;
										reference = ref *(GoreSection*)null;
										obj45 = obj22;
										obj46 = obj27;
										if (flag17)
										{
											goto IL_06f7;
										}
									}
									punchIn = punchEvery;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									object obj47 = 0;
									object obj48 = obj47;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v29+A0]");
									object obj49 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v30+8]");
									_ = 0;
									d.Punch(section, (Vector3)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
									object obj50 = 0;
									XRNode node = (heldRight ? ((XRNode)4) : ((XRNode)5));
									object obj51 = obj50;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v47+E4]");
									bool flag18 = (nint)0 == 0;
									object obj52 = !flag18;
									if (obj52 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
									Buzz(node, 1f, 0f);
									object obj53 = obj50;
									bool flag19 = !heldRight;
									object obj54 = !flag19;
									object obj55 = ~obj54;
									XRNode node2 = ((obj55 != null) ? ((XRNode)4) : ((XRNode)5));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v50+E4]");
									bool flag20 = (nint)0 == 0;
									object obj56 = !flag20;
									if (obj56 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
									Buzz(node2, 0.5f, 0f);
									if (d.Alive)
									{
										goto IL_06f7;
									}
									DummyDied(d);
									return true;
								}
							}
						}
						goto IL_071d;
					}
				}
				goto IL_06f7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj57 = 0;
			object obj58 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v9+A0]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v10+8]");
			_ = 0;
			return false;
		}
		goto IL_071d;
		IL_06f7:
		return false;
		IL_071d:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void DummyDied(GillaDummy d)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		int bodyId = d.BodyId;
		ExpectBody(bodyId, heldRight);
		object obj = this + 680;
		heldDummy = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ripping = false;
	}

	private void RipDummy(GillaDummy d)
	{
		//IL_006f: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got VT
		//IL_02a5: Expected Obj, but got VT
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_04b2: Expected Obj, but got I4
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected I4, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected Obj, but got Unknown
		//IL_066a: Expected VT, but got I4
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected Obj, but got Unknown
		if ((object)d != null)
		{
			int bodyId = d.BodyId;
			if ((object)rightFollower != null)
			{
				Vector3 position = rightFollower.position;
				if ((object)leftFollower != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
					object obj = 0;
					Vector3 position2 = leftFollower.position;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v12+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaWounds gillaWounds = GillaWounds.On(d.tearing);
					if ((object)gillaWounds != null)
					{
						Vector3 vector = gillaWounds.PlusX();
						if ((object)d.tearing != null)
						{
							Transform transform = d.tearing.transform;
							if ((object)transform != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
								object obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
								object obj5 = 0;
								Quaternion rotation = transform.rotation;
								object obj6 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v21+E4]");
								bool flag2 = (nint)0 == 0;
								object obj7 = !flag2;
								if (obj7 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								PlayerRef you = You;
								object obj8 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v8+E4]");
								bool flag3 = (nint)0 == 0;
								object obj9 = !flag3;
								if (obj9 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								int seed = GillaRip.PickSeed();
								if ((object)rightFollower != null)
								{
									Quaternion rotation2 = rightFollower.rotation;
									Quaternion rotation3 = default;
									Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation3);
									if ((object)leftFollower != null)
									{
										Quaternion quaternion2 = default;
										object obj10 = quaternion2 - quaternion2;
										object obj12 = default;
										object obj11 = obj12 * obj12;
										object obj13 = quaternion2 * quaternion2;
										object obj15 = default;
										object obj14 = obj15 * obj12;
										object obj17 = default;
										object obj16 = obj17 - obj17;
										object obj18 = obj12 * obj15;
										object obj19 = obj17 * obj12;
										object obj20 = obj15 - obj15;
										object obj21 = obj10 * quaternion2;
										object obj22 = obj12 * obj17;
										object obj23 = quaternion2 * obj12;
										object obj24 = obj11 - obj13;
										object obj25 = obj16 * obj17;
										object obj26 = obj12 * quaternion2;
										object obj27 = obj14 + obj18;
										object obj28 = obj20 * obj15;
										object obj29 = obj17 * obj17;
										object obj30 = obj19 + obj22;
										object obj31 = obj17 * quaternion2;
										object obj32 = obj15 * obj17;
										object obj33 = quaternion2 * obj17;
										object obj34 = obj15 * quaternion2;
										object obj35 = obj21 + obj25;
										object obj36 = quaternion2 * obj15;
										object obj37 = obj23 + obj26;
										object obj38 = obj24 - obj29;
										object obj39 = obj15 * obj15;
										object obj40 = obj17 * obj15;
										object obj41 = obj31 + obj27;
										object obj42 = obj28 + obj35;
										object obj43 = obj36 + obj30;
										object obj44 = obj32 + obj37;
										object obj45 = obj38 - obj39;
										object obj46 = obj41 - obj33;
										bool flag4 = (nint)obj42 < 0;
										bool flag5 = obj42 == null;
										object obj47 = obj42 ^ obj42;
										object obj48 = obj42 & obj47;
										bool flag6 = (nint)obj48 < 0;
										object obj49 = obj43 - obj34;
										object obj50 = obj44 - obj40;
										bool flag7 = flag4 == flag6;
										object obj51 = !flag5;
										bool plusInRight = (byte)((flag7 & obj51) ? 1 : 0) != 0;
										Quaternion rotation4 = leftFollower.rotation;
										Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation3);
										object obj52 = obj12 * obj34;
										object obj53 = quaternion2 * obj44;
										object obj54 = obj17 * obj44;
										object obj55 = obj12 * obj33;
										object obj56 = obj15 * obj44;
										object obj57 = obj12 * obj40;
										object obj58 = obj12 * obj44;
										object obj59 = quaternion2 * obj34;
										object obj60 = obj53 + obj52;
										object obj61 = obj15 * obj33;
										object obj62 = obj17 * obj40;
										object obj63 = obj54 + obj55;
										object obj64 = quaternion2 * obj40;
										object obj65 = obj15 * obj40;
										object obj66 = obj56 + obj57;
										object obj67 = obj17 * obj34;
										object obj68 = obj15 * obj34;
										object obj69 = obj58 - obj59;
										object obj70 = obj17 * obj33;
										object obj71 = quaternion2 * obj33;
										object obj72 = obj61 + obj60;
										object obj73 = obj64 + obj63;
										object obj74 = obj67 + obj66;
										object obj75 = obj69 - obj70;
										object obj76 = obj72 - obj62;
										object obj77 = obj73 - obj68;
										object obj78 = obj74 - obj71;
										object obj79 = obj75 - obj65;
										Quaternion rotLeft = default;
										d.Rip(you, (byte)seed, plusInRight, (Quaternion)0, rotLeft);
										HalvesInHands(bodyId, plusInRight);
										object obj80 = this + 680;
										heldDummy = null;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										ripping = false;
										if (deadBody != null)
										{
											int[] array = default;
											array[0] = -1;
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void DropDummy(Vector3 velocity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0057: Expected VT, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I
		//IL_00e7: Expected VT, but got I4
		//IL_02dc: Expected VT, but got I4
		//IL_02dc: Expected VT, but got I4
		//IL_02e5: Expected VT, but got I4
		//IL_0129: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = this + 680;
		bool flag2 = (UnityEngine.Object)heldDummy != (UnityEngine.Object)null;
		bool flag3 = !flag2;
		Vector3 vector = (Vector3)0;
		if (!flag3)
		{
			object obj5 = obj4;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v5+68]");
			bool flag5 = (UnityEngine.Object)0 != null;
			bool flag6 = !flag5;
			vector = (Vector3)0;
			if (!flag6)
			{
				GillaDummy gillaDummy = (GillaDummy)obj4;
				Vector3 position = gillaDummy.head.position;
				float num2 = default;
				float num = num2 * num2;
				float num4 = default;
				float num3 = num4 * num4;
				float num5 = num + num3;
				float num7 = default;
				float num6 = num7 * num7;
				float num8 = num6 + num5;
				float num9 = hardestThrow * hardestThrow;
				bool flag7 = !(num8 > num9);
				float num10 = num2;
				float num11 = num4;
				float num12 = num7;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj8 = 0;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v20+E4]");
					bool flag8 = (nint)0 == 0;
					object obj10 = !flag8;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num13 = num2 / num9;
					float num14 = num4 / num9;
					num10 = num13 * hardestThrow;
					float num15 = num7 / num9;
					num11 = num14 * hardestThrow;
					num12 = num15 * hardestThrow;
				}
				gillaDummy.Release((Vector3)0, (Vector3)0);
				vector = (Vector3)0;
			}
		}
		heldDummy = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ripping = false;
	}

	private unsafe void Bodies(float reach, bool grab)
	{
		//IL_1a59: Expected Obj, but got I
		//IL_1a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6e: Expected Obj, but got Unknown
		//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a79: Expected Obj, but got Unknown
		//IL_1a82: Expected F4, but got I4
		//IL_1aa0: Expected Obj, but got I4
		//IL_1aa9: Expected Obj, but got I4
		//IL_1ab2: Expected Obj, but got I4
		//IL_1cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc9: Expected Obj, but got Unknown
		//IL_0022: Expected Obj, but got I4
		//IL_0014: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_034d: Expected VT, but got I4
		//IL_1b10: Expected Obj, but got I4
		//IL_06aa: Expected Obj, but got I4
		//IL_1c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c54: Expected Obj, but got Unknown
		//IL_1c6e: Expected Obj, but got I4
		//IL_1c7e: Expected I, but got VT
		//IL_1c86: Expected I4, but got Obj
		//IL_0144: Expected Obj, but got I4
		//IL_0e37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3c: Expected Obj, but got Unknown
		//IL_0e45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4a: Expected Obj, but got Unknown
		//IL_0e53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e58: Expected Obj, but got Unknown
		//IL_039f: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I8
		//IL_03f0: Expected Obj, but got I4
		//IL_03f8: Expected I4, but got Obj
		//IL_11d3: Expected I4, but got I8
		//IL_11ed: Expected Obj, but got I4
		//IL_06f3: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_120b: Expected Obj, but got I
		//IL_1235: Expected Obj, but got I4
		//IL_072a: Expected Obj, but got I8
		//IL_0749: Expected I, but got VT
		//IL_0751: Expected I4, but got Obj
		//IL_04db: Expected Obj, but got I4
		//IL_045a: Expected Obj, but got I4
		//IL_128b: Expected Obj, but got I4
		//IL_044c: Expected Obj, but got I4
		//IL_02c4: Expected Obj, but got I4
		//IL_12d0: Expected Obj, but got I4
		//IL_0522: Expected Obj, but got I4
		//IL_0476: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I4
		//IL_1404: Expected I4, but got I8
		//IL_0551: Expected Obj, but got I
		//IL_0468: Expected Obj, but got I4
		//IL_07a3: Expected Obj, but got I4
		//IL_061c: Expected I4, but got I8
		//IL_0636: Expected Obj, but got I4
		//IL_063f: Expected VT, but got I4
		//IL_0492: Expected Obj, but got I4
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected Obj, but got Unknown
		//IL_1b77: Expected F4, but got I
		//IL_1b87: Expected Obj, but got I
		//IL_1b97: Expected F4, but got I
		//IL_1ba6: Expected VT, but got I4
		//IL_0484: Expected Obj, but got I4
		//IL_1317: Expected Obj, but got I4
		//IL_1332: Expected Obj, but got I4
		//IL_07ea: Expected Obj, but got I4
		//IL_0669: Expected VT, but got I4
		//IL_05cb: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I
		//IL_026d: Expected Obj, but got I4
		//IL_0819: Expected Obj, but got I
		//IL_0837: Expected Obj, but got I4
		//IL_0844: Expected I, but got Obj
		//IL_05bd: Expected Obj, but got I4
		//IL_0686: Expected I4, but got I8
		//IL_068f: Expected VT, but got I4
		//IL_05e7: Expected Obj, but got I4
		//IL_0885: Expected Obj, but got I4
		//IL_05d9: Expected Obj, but got I4
		//IL_0603: Expected Obj, but got I4
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected Obj, but got Unknown
		//IL_0948: Expected Obj, but got I4
		//IL_0955: Expected I, but got Obj
		//IL_1c03: Expected F4, but got I
		//IL_1c13: Expected Obj, but got I
		//IL_1c23: Expected F4, but got I
		//IL_1c32: Expected VT, but got I4
		//IL_1c3a: Expected Obj, but got I4
		//IL_05f5: Expected Obj, but got I4
		//IL_08ec: Expected I, but got Obj
		//IL_09c2: Expected Obj, but got I
		//IL_09ec: Expected Obj, but got I4
		//IL_1a25: Expected I4, but got I8
		//IL_0a1b: Expected VT, but got Ref
		//IL_0a41: Expected Obj, but got I
		//IL_0a6b: Expected Obj, but got I4
		//IL_1482: Expected Obj, but got I4
		//IL_0a96: Expected VT, but got Ref
		//IL_0ac4: Expected Obj, but got I4
		//IL_1474: Expected Obj, but got I4
		//IL_0c41: Expected I, but got Obj
		//IL_0c66: Expected I, but got Obj
		//IL_1498: Expected Obj, but got I
		//IL_14b0: Expected VT, but got Ref
		//IL_14e2: Expected Obj, but got I
		//IL_150c: Expected Obj, but got I4
		//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcb: Expected Obj, but got Unknown
		//IL_0c10: Expected I4, but got Obj
		//IL_156c: Expected Obj, but got I4
		//IL_15af: Expected Obj, but got I4
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected Obj, but got Unknown
		//IL_0ccf: Expected Obj, but got I4
		//IL_1760: Expected Obj, but got I
		//IL_178a: Expected Obj, but got I4
		//IL_0b6d: Expected VT, but got I4
		//IL_0b8a: Expected Obj, but got I4
		//IL_0b9a: Expected Obj, but got I4
		//IL_0baf: Expected I, but got Obj
		//IL_17c0: Expected Obj, but got I
		//IL_17ea: Expected Obj, but got I4
		//IL_1842: Expected VT, but got I4
		//IL_184b: Expected VT, but got I4
		//IL_1609: Expected Obj, but got I4
		//IL_1638: Expected Obj, but got I
		//IL_1654: Expected Obj, but got I4
		//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcb: Expected Obj, but got Unknown
		//IL_0e29: Expected I4, but got Obj
		//IL_18d3: Expected Obj, but got I4
		//IL_18ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f2: Expected Obj, but got Unknown
		//IL_0d7a: Expected Obj, but got I4
		//IL_169f: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a4: Expected Obj, but got Unknown
		//IL_16bc: Expected Obj, but got I4
		//IL_1942: Expected Obj, but got I4
		//IL_1701: Expected VT, but got I4
		//IL_1701: Expected VT, but got Ref
		//IL_0ea4: Expected VT, but got I4
		//IL_195c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1961: Expected Obj, but got Unknown
		//IL_1971: Expected Obj, but got I
		//IL_198f: Expected I4, but got I8
		//IL_19b1: Expected Obj, but got I4
		//IL_170e: Expected VT, but got Ref
		//IL_1716: Expected I4, but got VT
		//IL_0ec7: Expected Obj, but got I4
		//IL_19ed: Expected F4, but got I
		//IL_1a0c: Expected F4, but got I
		//IL_0eef: Expected Obj, but got I4
		//IL_0f98: Expected Obj, but got I4
		//IL_1060: Expected Obj, but got I4
		//IL_0f39: Expected VT, but got I4
		//IL_0f45: Expected Obj, but got I4
		//IL_101f: Expected I, but got Obj
		//IL_1028: Expected Obj, but got I4
		//IL_1089: Expected Obj, but got I4
		//IL_1d1f: Expected I4, but got Obj
		//IL_1d4e: Expected Obj, but got I
		//IL_1d78: Expected Obj, but got I4
		//IL_1d80: Expected F4, but got Obj
		//IL_1dc5: Expected Obj, but got I
		//IL_1dd0: Expected Obj, but got I4
		//IL_1142: Expected F4, but got I
		//IL_1df2: Expected Obj, but got I4
		//IL_112d: Expected F4, but got I
		//IL_116c: Expected F4, but got I
		//IL_1e3d: Expected Obj, but got I4
		//IL_1157: Expected F4, but got I
		//IL_1199: Expected Obj, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float num = BodyTouch;
		object obj2 = this + 200;
		object obj3 = this + 192;
		float num2 = 0f;
		GillaCorpse gillaCorpse = null;
		float num3 = num;
		bool flag = grab;
		object obj4 = 9;
		object obj5 = 32;
		object obj6 = 0;
		int num8 = default;
		object obj34 = default;
		GillaCorpse gillaCorpse3 = default;
		float num13 = default;
		Transform thing = default;
		UnityEngine.Object obj115 = default;
		object obj121 = default;
		object obj122 = default;
		object obj124 = default;
		object obj126 = default;
		object obj128 = default;
		object obj130 = default;
		while (true)
		{
			GillaPieceId[] array = pieceIn;
			object obj7 = obj6 - 1;
			bool flag2 = obj7 == null;
			if ((nint)obj6 == 1)
			{
				object obj8 = 477 + 1;
			}
			else
			{
				object obj8 = 477;
			}
			if ((nint)obj6 == 1)
			{
				object obj9 = 479 + 1;
			}
			else
			{
				object obj9 = 479;
			}
			UnityEngine.Object obj14;
			if (pieceIn != null)
			{
				bool flag3 = (nint)obj6 < array.Length;
				object obj10 = !flag3;
				if (obj10 != null)
				{
					goto IL_1a42;
				}
				object obj11 = obj;
				object obj12 = (object)pieceIn + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v8+E4]");
				bool flag4 = (nint)0 == 0;
				object obj13 = !flag4;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v11+20]");
				bool flag5 = (UnityEngine.Object)0 != null;
				bool flag6 = !flag5;
				obj14 = null;
				if (flag6)
				{
					goto IL_030a;
				}
				GillaPieceId[] array2 = pieceIn;
				if (pieceIn != null)
				{
					bool flag7 = (nint)obj6 < array2.Length;
					object obj15 = !flag7;
					if (obj15 != null)
					{
						goto IL_1a42;
					}
					object obj16 = (object)pieceIn + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v114+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v114+20]");
						if (!((UnityEngine.Behaviour)0).isActiveAndEnabled)
						{
							goto IL_0280;
						}
						GillaPieceId[] array3 = pieceIn;
						if (pieceIn != null)
						{
							bool flag8 = (nint)obj6 < array3.Length;
							object obj17 = !flag8;
							if (obj17 != null)
							{
								goto IL_1a42;
							}
							object obj18 = (object)pieceIn + obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v118+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v118+20]");
								bool flag9 = ((GillaPieceId)0).Held;
								bool flag10 = !flag9;
								object obj19 = !flag10;
								obj14 = null;
								if (obj19 == null)
								{
									goto IL_0280;
								}
								goto IL_030a;
							}
						}
					}
				}
			}
			goto IL_1a34;
			IL_13f5:
			ripBody = -1;
			break;
			IL_0f9d:
			int num4;
			bool flag11 = num4 == 0;
			GillaCorpse gillaCorpse2 = gillaCorpse;
			nint num5;
			object obj20;
			if (!flag11)
			{
				if ((object)gillaCorpse == null)
				{
					goto IL_1a34;
				}
				if (!gillaCorpse.IsOff(num4))
				{
					num5 = unchecked((nint)null);
					obj20 = 0;
					goto IL_1cf8;
				}
				gillaCorpse2 = gillaCorpse;
			}
			goto IL_0dbd;
			IL_1a34:
			NullReferenceException ex = new NullReferenceException();
			goto IL_1a42;
			IL_0c7d:
			int[] array4 = bodyOf;
			object obj24;
			float num7;
			GillaCorpse corpse;
			if (bodyOf != null)
			{
				object obj21 = obj4 - 8;
				bool flag12 = (nint)obj21 < array4.Length;
				object obj22 = !flag12;
				if (obj22 != null)
				{
					goto IL_1a42;
				}
				if ((object)gillaCorpse != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X9_v31 (System.Int32[])+v181 @ X29_v2*4]");
					bool flag13 = (nint)0 != gillaCorpse.Id__BackingField;
					float num6 = num;
					gillaCorpse2 = gillaCorpse;
					if (!flag13)
					{
						int[] array5 = bodyPart;
						if (bodyPart == null)
						{
							goto IL_1a34;
						}
						bool flag14 = (nint)obj21 < array5.Length;
						object obj23 = !flag14;
						if (obj23 != null)
						{
							goto IL_1a42;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X9_v34 (System.Int32[])+v181 @ X29_v2*4]");
						bool flag15 = (nint)0 == 0;
						num6 = num;
						gillaCorpse2 = gillaCorpse;
						if (flag15)
						{
							Vector3 position = ((Transform)obj24).position;
							bool flag16 = gillaCorpse.RipsHere((Vector3)0, num7);
							bool flag17 = !flag16;
							object obj25 = !flag17;
							if (obj25 == null)
							{
								bool flag18 = num8 == 0;
								object obj26 = !flag18;
								if (obj26 == null)
								{
									Vector3 position2 = ((Transform)obj24).position;
									if ((object)gillaCorpse != null)
									{
										num8 = gillaCorpse.NearestOn((Vector3)0, num7);
										corpse = (GillaCorpse)num8;
										num6 = reach;
										num4 = num8;
										goto IL_0f9d;
									}
									goto IL_1a34;
								}
							}
							bool flag19 = !flag16;
							num6 = reach;
							num4 = num8;
							if (flag19)
							{
								goto IL_0f9d;
							}
							num6 = reach;
							obj20 = 1;
							goto IL_1cf8;
						}
					}
					goto IL_0dbd;
				}
			}
			goto IL_1a34;
			IL_1af6:
			bool flag20 = !grab;
			object obj27 = !flag20;
			object obj28 = ~obj27;
			object obj30;
			object obj29 = ((obj28 != null) ? ((object)1) : obj30);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v223 @ X10_v2]");
			object obj31 = obj29 | 0;
			bool flag21 = obj31 == null;
			object obj32 = !flag21;
			object obj33 = obj34;
			Vector3 vector;
			nint num9 = (nint)vector;
			flag = (byte)(int)obj14 != 0;
			GillaCorpse gillaCorpse4;
			float num11;
			float num12;
			float num10;
			if (obj32 == null)
			{
				int[] array6 = bodyOf;
				if (bodyOf == null)
				{
					goto IL_1a34;
				}
				bool flag22 = (nint)obj6 < array6.Length;
				object obj35 = !flag22;
				if (obj35 != null)
				{
					goto IL_1a42;
				}
				object obj36 = (object)bodyOf + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v52+20]");
				object obj37 = 0 & 0x80000000L;
				bool flag23 = obj37 == null;
				obj33 = obj34;
				num9 = (nint)vector;
				flag = (byte)(int)obj14 != 0;
				if (!flag23)
				{
					GillaPieceId[] array7 = pieceIn;
					if (pieceIn == null)
					{
						goto IL_1a34;
					}
					bool flag24 = (nint)obj6 < array7.Length;
					object obj38 = !flag24;
					if (obj38 != null)
					{
						goto IL_1a42;
					}
					object obj39 = obj;
					object obj40 = (object)pieceIn + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X0_v76+E4]");
					bool flag25 = (nint)0 == 0;
					object obj41 = !flag25;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X8_v55+20]");
					bool flag26 = (UnityEngine.Object)0 != null;
					bool flag27 = !flag26;
					object obj42 = !flag27;
					obj33 = obj34;
					num9 = unchecked((nint)null);
					flag = false;
					if (obj42 == null)
					{
						object obj43 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1179 @ X0_v80+E4]");
						bool flag28 = (nint)0 == 0;
						object obj44 = !flag28;
						if (obj44 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if ((UnityEngine.Object)held != (UnityEngine.Object)null)
						{
							bool flag29 = heldRight == flag2;
							obj33 = obj34;
							num9 = unchecked((nint)null);
							flag = false;
							if (flag29)
							{
								goto IL_0e2e;
							}
						}
						object obj45 = obj6 - 1;
						bool flag30 = obj45 == null;
						bool flag31 = SlabIn(flag30);
						bool flag32 = !flag31;
						object obj46 = !flag32;
						obj33 = obj34;
						num9 = unchecked((nint)null);
						flag = flag30;
						if (obj46 == null)
						{
							obj24 = (((nint)obj6 != 1) ? obj3 : obj2);
							if (obj24 == null)
							{
								goto IL_1a34;
							}
							Vector3 position3 = ((Transform)obj24).position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
							object obj47 = 0;
							object obj48 = obj47;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X0_v88+E4]");
							bool flag33 = (nint)0 == 0;
							object obj49 = !flag33;
							if (obj49 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag34 = GillaCorpse.Nearest((Vector3)(&gillaCorpse), num3, out corpse, out *(int*)null);
							Vector3 position4 = ((Transform)obj24).position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
							object obj50 = 0;
							object obj51 = obj50;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ X0_v94+E4]");
							bool flag35 = (nint)0 == 0;
							object obj52 = !flag35;
							if (obj52 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GillaPieceId gillaPieceId = GillaSlice.NearestFree((Vector3)(&num2), num3, out *(float*)null);
							object obj53 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X8_v66+E4]");
							bool flag36 = (nint)0 == 0;
							object obj54 = !flag36;
							if (obj54 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (gillaPieceId != null)
							{
								bool flag37 = !flag34;
								num10 = num3;
								if (!flag37)
								{
									Vector3 position5 = ((Transform)obj24).position;
									if ((object)gillaCorpse == null)
									{
										goto IL_1a34;
									}
									num3 = gillaCorpse.HowFar(num8, (Vector3)0);
									bool flag38 = !(num2 < num3);
									gillaCorpse3 = (GillaCorpse)num8;
									num10 = num2;
									gillaCorpse4 = (GillaCorpse)num8;
									num7 = num3;
									num11 = num2;
									num5 = unchecked((nint)null);
									if (flag38)
									{
										goto IL_0c7d;
									}
								}
								object obj55 = obj6 - 1;
								bool flag39 = obj55 == null;
								HoldPiece(gillaPieceId, flag39);
								float num6 = num;
								obj33 = obj34;
								num12 = num13;
								num9 = (flag39 ? 1 : 0);
								flag = (byte)(int)gillaPieceId != 0;
							}
							else
							{
								bool flag40 = !flag34;
								gillaCorpse4 = gillaCorpse3;
								num7 = num3;
								num11 = num3;
								num5 = unchecked((nint)null);
								float num6 = num;
								obj33 = obj34;
								num12 = num13;
								num10 = num3;
								num9 = unchecked((nint)null);
								flag = false;
								if (!flag40)
								{
									goto IL_0c7d;
								}
							}
						}
					}
				}
			}
			goto IL_0e2e;
			IL_1cf8:
			if ((object)gillaCorpse != null)
			{
				bool flag41 = obj20 == null;
				ripBodyRight = flag2;
				ripBody = gillaCorpse.Id__BackingField;
				object obj56 = !flag41;
				object obj57 = ~obj56;
				GillaCorpse gillaCorpse5 = ((obj57 != null) ? ((GillaCorpse)num8) : null);
				ripBodyPart = (int)gillaCorpse5;
				if ((object)leftFollower != null)
				{
					Vector3 position6 = leftFollower.position;
					if (obj2 != null)
					{
						Vector3 position7 = ((Transform)obj2).position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj58 = 0;
						object obj59 = obj58;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X0_v114+E4]");
						bool flag42 = (nint)0 == 0;
						object obj60 = !flag42;
						float num14 = (float)gillaCorpse4;
						object obj61 = obj34;
						float num15 = num13;
						float num16 = num7;
						if (obj60 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							num14 = num7;
							obj61 = obj34;
							num15 = num13;
							num16 = num7;
						}
						float num17 = num7 - num16;
						float num18 = num13 - num15;
						obj33 = obj34 - obj61;
						float num19 = num17 * num17;
						float num20 = num18 * num18;
						float num21 = num19 + num20;
						object obj62 = obj33 * obj33;
						float num22 = (float)obj62 + num21;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						ripBodyStart = num22;
						float reallyApart = ReallyApart;
						XRNode node = (((nint)obj6 != 1) ? ((XRNode)4) : ((XRNode)5));
						bool flag43 = obj20 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
						object obj63 = 0;
						object obj64 = !flag43;
						object obj65 = ~obj64;
						if (obj65 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
							num10 = 0f;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
							num10 = 0f;
						}
						object obj66 = !flag43;
						object obj67 = ~obj66;
						if (obj67 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
							num12 = 0f;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
							num12 = 0f;
						}
						ripBodyStartReal = reallyApart;
						object obj68 = obj63;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1563 @ X0_v117+E4]");
						bool flag44 = (nint)0 == 0;
						object obj69 = !flag44;
						if (obj69 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Buzz(node, num10, num12);
						gillaCorpse3 = (GillaCorpse)num14;
						num13 = num12;
						num3 = num10;
						num9 = num5;
						flag = false;
						goto IL_0e2e;
					}
				}
			}
			goto IL_1a34;
			IL_0280:
			GillaPieceId[] array8 = pieceIn;
			if (pieceIn == null)
			{
				goto IL_1a34;
			}
			bool flag45 = (nint)obj6 < array8.Length;
			object obj70 = !flag45;
			if (obj70 == null)
			{
				object obj71 = (object)pieceIn + obj6;
				object obj72 = (object)pieceIn + obj5;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj14 = null;
				goto IL_030a;
			}
			goto IL_1a42;
			IL_0dbd:
			object obj73 = obj6 - 1;
			bool right = obj73 == null;
			HoldBody(gillaCorpse2, num8, right, byMiddle: false);
			gillaCorpse3 = gillaCorpse4;
			obj33 = obj34;
			num3 = num7;
			num12 = num13;
			num10 = num11;
			num9 = num8;
			flag = (byte)(int)gillaCorpse2 != 0;
			goto IL_0e2e;
			IL_030a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v217 @ X9_v5]");
			obj30 = (nint)0 ^ (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v223 @ X10_v2]");
			object obj74 = obj30 & 0;
			bool flag46 = obj74 == null;
			vector = (Vector3)0;
			if (!flag46)
			{
				int[] array9 = bodyOf;
				if (bodyOf == null)
				{
					goto IL_1a34;
				}
				bool flag47 = (nint)obj6 < array9.Length;
				object obj75 = !flag47;
				if (obj75 == null)
				{
					object obj76 = (object)bodyOf + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X8_v96+20]");
					object obj77 = 0 & 0x80000000L;
					bool flag48 = obj77 == null;
					object obj78 = !flag48;
					bool flag49 = (byte)(int)obj14 != 0;
					if (obj78 == null)
					{
						object obj79 = obj6 - 1;
						bool flag50 = obj79 == null;
						if ((nint)obj6 == 1)
						{
							object obj80 = 552;
						}
						else
						{
							object obj80 = 540;
						}
						if ((nint)obj6 == 1)
						{
							object obj81 = 548;
						}
						else
						{
							object obj81 = 536;
						}
						if ((nint)obj6 == 1)
						{
							object obj82 = 544;
						}
						else
						{
							object obj82 = 532;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v925 @ X9_v50]");
						num13 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v928 @ X8_v110]");
						obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v924 @ X10_v27]");
						num3 = 0f;
						LetGoBody(flag50, (Vector3)0);
						flag49 = flag50;
					}
					GillaPieceId[] array10 = pieceIn;
					if (pieceIn == null)
					{
						goto IL_1a34;
					}
					bool flag51 = (nint)obj6 < array10.Length;
					object obj83 = !flag51;
					if (obj83 == null)
					{
						object obj84 = obj;
						object obj85 = (object)pieceIn + obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X0_v144+E4]");
						bool flag52 = (nint)0 == 0;
						object obj86 = !flag52;
						if (obj86 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X8_v100+20]");
						bool flag53 = (UnityEngine.Object)0 != null;
						bool flag54 = !flag53;
						obj14 = null;
						if (!flag54)
						{
							object obj87 = obj6 - 1;
							bool flag55 = obj87 == null;
							if ((nint)obj6 == 1)
							{
								object obj88 = 552;
							}
							else
							{
								object obj88 = 540;
							}
							if ((nint)obj6 == 1)
							{
								object obj89 = 548;
							}
							else
							{
								object obj89 = 536;
							}
							if ((nint)obj6 == 1)
							{
								object obj90 = 544;
							}
							else
							{
								object obj90 = 532;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v1147 @ X9_v45]");
							num13 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v1150 @ X8_v106]");
							obj34 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v1146 @ X10_v22]");
							num3 = 0f;
							LetGoPiece(flag55, (Vector3)0);
							obj14 = (UnityEngine.Object)flag55;
						}
						int num23 = (int)(ripBody & 0x80000000L);
						bool flag56 = num23 == 0;
						object obj91 = !flag56;
						vector = (Vector3)0;
						if (obj91 == null)
						{
							bool flag57 = ripBodyRight != flag2;
							vector = (Vector3)0;
							if (!flag57)
							{
								ripBody = -1;
								vector = (Vector3)0;
							}
						}
						goto IL_1af6;
					}
				}
				goto IL_1a42;
			}
			goto IL_1af6;
			IL_1a42:
			throw new IndexOutOfRangeException();
			IL_188d:
			int[] array11 = bodyOf;
			if (bodyOf == null)
			{
				goto IL_1a34;
			}
			bool flag58 = (ripBodyRight ? 1 : 0) < array11.Length;
			object obj92 = !flag58;
			GillaCorpse gillaCorpse6;
			if (obj92 == null)
			{
				object obj93 = bodyOf + ripBodyRight;
				int[] array12 = bodyPart;
				_ = gillaCorpse6.Id__BackingField;
				if (bodyPart == null)
				{
					goto IL_1a34;
				}
				bool flag59 = (ripBodyRight ? 1 : 0) < array12.Length;
				object obj94 = !flag59;
				if (obj94 == null)
				{
					object obj95 = bodyPart + ripBodyRight;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
					object obj96 = 0;
					_ = ripBodyPart;
					object obj97 = obj96;
					ripBody = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1472 @ X0_v45+E4]");
					bool flag60 = (nint)0 == 0;
					object obj98 = !flag60;
					if (obj98 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					Buzz((XRNode)4, 1f, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					Buzz((XRNode)5, 1f, 0f);
					break;
				}
			}
			goto IL_1a42;
			IL_0e2e:
			obj6++;
			obj5 += 8;
			obj4--;
			bool flag61 = (nint)obj6 != 2;
			obj34 = obj33;
			if (flag61)
			{
				continue;
			}
			int num24 = (int)(ripBody & 0x80000000L);
			bool flag62 = num24 == 0;
			object obj99 = !flag62;
			if (obj99 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj100 = 0;
			object obj101 = obj100;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ X0_v16+E4]");
			bool flag63 = (nint)0 == 0;
			object obj102 = !flag63;
			if (obj102 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			gillaCorpse6 = GillaCorpse.Find(ripBody);
			object obj103 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X8_v21+E4]");
			bool flag64 = (nint)0 == 0;
			object obj104 = !flag64;
			if (obj104 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag65 = gillaCorpse6 == null;
			bool flag66 = !flag65;
			object obj105 = !flag66;
			if (obj105 != null)
			{
				goto IL_13f5;
			}
			int[] array13 = bodyOf;
			if (bodyOf != null)
			{
				object obj106 = (ripBodyRight ? 1 : 0) ^ 1;
				bool flag67 = (nint)obj106 < array13.Length;
				object obj107 = !flag67;
				if (obj107 != null)
				{
					goto IL_1a42;
				}
				object obj108 = (object)bodyOf + obj106;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1199 @ X8_v25+20]");
				if ((nint)0 != ripBody)
				{
					goto IL_13f5;
				}
				if ((object)gillaCorpse6 != null)
				{
					if (!gillaCorpse6.Has(ripBodyPart) || gillaCorpse6.IsOff(ripBodyPart))
					{
						goto IL_13f5;
					}
					if (!PulledApart(ripBodyStart, ripBodyStartReal))
					{
						break;
					}
					if (ripBodyPart == 0)
					{
						ripBody = -1;
						RipBody(gillaCorpse6);
						break;
					}
					if (!ripBodyRight)
					{
						object obj109 = 192;
					}
					else
					{
						object obj109 = 200;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v616 @ X8_v30]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v616 @ X8_v30]");
						Vector3 position8 = ((Transform)0).position;
						int num25 = gillaCorpse6.LinkOn(ripBodyPart, (Vector3)(&thing), out *(Transform*)null);
						(Vector3, Quaternion) tuple = InHand(ripBodyRight, thing, byMiddle: false);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
						object obj110 = 0;
						object obj111 = obj110;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X0_v37+E4]");
						bool flag68 = (nint)0 == 0;
						object obj112 = !flag68;
						if (obj112 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int num26 = ripBodyPart | num25;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F0765C");
						object obj113 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v35+E4]");
						bool flag69 = (nint)0 == 0;
						object obj114 = !flag69;
						if (obj114 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag70 = obj115 != null;
						bool flag71 = !flag70;
						object obj116 = 0;
						UnityEngine.Object obj117 = null;
						Quaternion quaternion;
						int num27;
						object obj123;
						object obj125;
						object obj127;
						object obj129;
						int num28;
						bool flag76;
						if (!flag71)
						{
							if ((object)obj115 == null)
							{
								goto IL_1a34;
							}
							object obj118 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1380 @ X0_v60+E4]");
							bool flag72 = (nint)0 == 0;
							object obj119 = !flag72;
							if (obj119 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ X0_v40 (UnityEngine.Object)+40]");
							bool flag73 = (UnityEngine.Object)0 != null;
							bool flag74 = !flag73;
							obj116 = 0;
							obj117 = null;
							if (!flag74)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ X0_v40 (UnityEngine.Object)+40]");
								if ((nint)0 == 0)
								{
									goto IL_1a34;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DA9760");
								object obj120 = obj121 & 1;
								bool flag75 = obj120 == null;
								obj116 = 0;
								obj117 = null;
								if (!flag75)
								{
									NetworkBool networkBool = ripBodyRight;
									((NetworkApe)obj115).RPC_TearCorpse(gillaCorpse6.Id__BackingField, (byte)num26, networkBool, (Quaternion)(&obj122), (RpcInfo)0);
									quaternion = (Quaternion)(&obj122);
									num27 = (int)networkBool;
									obj123 = obj124;
									obj125 = obj126;
									obj127 = obj128;
									obj129 = obj130;
									num28 = num26;
									flag76 = (byte)gillaCorpse6.Id__BackingField != 0;
									goto IL_188d;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
						object obj131 = 0;
						object obj132 = obj131;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1375 @ X0_v51+E4]");
						bool flag77 = (nint)0 == 0;
						object obj133 = !flag77;
						if (obj133 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						PlayerRef none = PlayerRef.None;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
						object obj134 = 0;
						object obj135 = obj134;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1395 @ X8_v47+E4]");
						bool flag78 = (nint)0 == 0;
						object obj136 = !flag78;
						if (obj136 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag79 = !ripBodyRight;
						bool flag80 = !flag79;
						GillaCorpse.TearOff(none, flag80, gillaCorpse6.Id__BackingField, num26, (Quaternion)0);
						quaternion = (Quaternion)0;
						num27 = num26;
						obj123 = obj124;
						obj125 = obj126;
						obj127 = obj128;
						obj129 = obj130;
						num28 = gillaCorpse6.Id__BackingField;
						flag76 = flag80;
						goto IL_188d;
					}
				}
			}
			goto IL_1a34;
		}
	}

	public void Await(int body, int part, bool right)
	{
		awaitBody = body;
		awaitPart = part;
		awaitRight = right;
		float time = Time.time;
		float num = time + 1f;
		awaitUntil = num;
	}

	private void AwaitTorn()
	{
		//IL_0307: Expected I4, but got I8
		//IL_0321: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0093: Expected I4, but got I8
		//IL_00a8: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0287: Expected Obj, but got I8
		int num = (int)(awaitBody & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		bool flag2 = !awaitRight;
		object obj2 = !flag2;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = 477 + 1;
		}
		else
		{
			object obj4 = 477;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v191 @ X8_v7]");
		if ((nint)0 != 0)
		{
			float time = Time.time;
			if (!(time > awaitUntil))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v5+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaCorpse gillaCorpse = GillaCorpse.Find(awaitBody);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v16+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = gillaCorpse == null;
				bool flag6 = !flag5;
				object obj11 = !flag6;
				if (obj11 != null)
				{
					return;
				}
				if ((object)gillaCorpse != null)
				{
					if (!gillaCorpse.IsOff(awaitPart) || !gillaCorpse.Has(awaitPart))
					{
						return;
					}
					int[] array = bodyOf;
					if (bodyOf != null)
					{
						bool flag7 = (awaitRight ? 1 : 0) < array.Length;
						object obj12 = !flag7;
						if (obj12 == null)
						{
							object obj13 = bodyOf + awaitRight;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X9_v7+20]");
							object obj14 = 0 & 0x80000000L;
							if (obj14 != null)
							{
								bool flag8 = !awaitRight;
								bool right = !flag8;
								HoldBody(gillaCorpse, awaitPart, right, byMiddle: true);
								goto IL_0084;
							}
							return;
						}
						goto IL_02ec;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_02ec;
			}
		}
		goto IL_0084;
		IL_0084:
		awaitBody = -1;
		return;
		IL_02ec:
		throw new IndexOutOfRangeException();
	}

	private unsafe void TellAtRest()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_0aab: Expected Obj, but got I
		//IL_0acd: Expected Obj, but got I4
		//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd7: Expected Obj, but got Unknown
		//IL_0cf9: Expected Obj, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_00fc: Expected VT, but got I4
		//IL_0105: Expected VT, but got I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I
		//IL_01f5: Expected VT, but got I4
		//IL_01fe: Expected VT, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I
		//IL_029f: Expected VT, but got I4
		//IL_02a8: Expected VT, but got I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0328: Expected Obj, but got I
		//IL_0352: Expected Obj, but got I4
		//IL_0b23: Expected Obj, but got I
		//IL_0b43: Expected VT, but got I4
		//IL_0b4c: Expected VT, but got I4
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Expected Obj, but got I
		//IL_0389: Expected Obj, but got I
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected Obj, but got I
		//IL_03a6: Expected VT, but got I4
		//IL_03af: Expected VT, but got I4
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected F4, but got Unknown
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected Obj, but got I4
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected Obj, but got I4
		//IL_085f: Expected Obj, but got I4
		//IL_0c7e: Expected Obj, but got I
		//IL_0c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8f: Expected Ref, but got Unknown
		//IL_0ca9: Expected Obj, but got I4
		//IL_03fe: Expected Obj, but got I4
		//IL_087e: Expected Obj, but got I4
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected Obj, but got Unknown
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected Obj, but got I4
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected Obj, but got Unknown
		//IL_08e6: Expected Obj, but got Unknown
		//IL_0a07: Expected Obj, but got I4
		//IL_08cb: Expected Obj, but got I4
		//IL_0c2d: Expected VT, but got I4
		//IL_0c35: Expected VT, but got Ref
		//IL_0a66: Expected Obj, but got I4
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected VT, but got I4
		//IL_04ae: Expected VT, but got Ref
		//IL_04ae: Expected Obj, but got Unknown
		//IL_04ee: Expected Obj, but got I4
		//IL_0533: Expected Obj, but got I4
		//IL_053c: Expected VT, but got I4
		//IL_0544: Expected VT, but got Ref
		//IL_054e: Expected VT, but got I4
		//IL_055f: Expected Obj, but got I4
		//IL_0578: Expected Obj, but got I4
		//IL_0581: Expected VT, but got I4
		//IL_0592: Expected F4, but got VT
		//IL_05c0: Expected VT, but got I4
		//IL_05c8: Expected VT, but got Ref
		//IL_05d9: Expected Obj, but got I4
		//IL_05f2: Expected Obj, but got I4
		//IL_05fb: Expected VT, but got I4
		//IL_0611: Expected F4, but got VT
		//IL_0964: Expected VT, but got I4
		//IL_0632: Expected Obj, but got I4
		//IL_0644: Expected VT, but got I4
		//IL_064c: Expected VT, but got Ref
		//IL_065d: Expected Obj, but got I4
		//IL_0676: Expected Obj, but got I4
		//IL_067f: Expected VT, but got I4
		//IL_0687: Expected F4, but got VT
		//IL_0bee: Expected Obj, but got I4
		//IL_0906: Expected Obj, but got I4
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected I4, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected VT, but got I4
		//IL_0714: Expected VT, but got Ref
		//IL_0714: Expected Obj, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected Obj, but got Unknown
		//IL_0750: Expected Obj, but got I4
		//IL_0759: Expected VT, but got I4
		//IL_0761: Expected VT, but got Ref
		//IL_076b: Expected VT, but got I4
		//IL_078b: Expected VT, but got F4
		//IL_079d: Expected Obj, but got I4
		//IL_07b6: Expected VT, but got I4
		//IL_07be: Expected VT, but got Ref
		//IL_07de: Expected VT, but got F4
		//IL_07e6: Expected VT, but got F4
		float time = Time.time;
		if (time < nextAtRest)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		float time2 = Time.time;
		object obj2 = obj;
		float num = time2 + 0.5f;
		nextAtRest = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v9+A0]");
		Enumerator<, > val = (Enumerator<, >)0;
		UnityEngine.Object obj8 = (UnityEngine.Object)val;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)val == null;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			return;
		}
		bool flag6 = (int)val == 0;
		Quaternion rot = (Quaternion)0;
		Vector3 at = (Vector3)0;
		UnityEngine.Object obj12 = default;
		UnityEngine.Object obj11 = obj12;
		Enumerator<, > val2 = (Enumerator<, >)0;
		byte b = 0;
		UnityEngine.Object obj13 = null;
		double num2 = 0.5;
		if (!flag6)
		{
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v34+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X19_v5 (UnityEngine.Object)+40]");
			bool flag8 = (UnityEngine.Object)0 == null;
			bool flag9 = !flag8;
			object obj16 = !flag9;
			if (obj16 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X19_v5 (UnityEngine.Object)+40]");
			UnityEngine.Object obj17 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X19_v5 (UnityEngine.Object)+40]");
			bool flag10 = (nint)0 == 0;
			rot = (Quaternion)0;
			at = (Vector3)0;
			obj11 = obj12;
			val2 = (Enumerator<, >)0;
			b = 0;
			obj13 = null;
			num2 = 0.5;
			if (!flag10)
			{
				object obj18 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v39+E4]");
				bool flag11 = (nint)0 == 0;
				object obj19 = !flag11;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X20_v15 (UnityEngine.Object)+30]");
				if (!(UnityEngine.Object)0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X20_v15 (UnityEngine.Object)+30]");
				bool flag12 = (nint)0 == 0;
				rot = (Quaternion)0;
				at = (Vector3)0;
				obj11 = obj12;
				val2 = (Enumerator<, >)0;
				b = 0;
				obj13 = null;
				num2 = 0.5;
				if (!flag12)
				{
					ArgumentNullException ex = new ArgumentNullException();
					object obj20 = ex & 1;
					if (obj20 == null)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
					object obj21 = 0;
					object obj22 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v46+E4]");
					bool flag13 = (nint)0 == 0;
					object obj23 = !flag13;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj22 = obj21;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v46+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v23+8]");
					bool flag14 = (nint)0 == 0;
					rot = (Quaternion)0;
					at = (Vector3)0;
					obj11 = obj12;
					val2 = (Enumerator<, >)0;
					b = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X19_v5 (UnityEngine.Object)+40]");
					obj13 = (UnityEngine.Object)0;
					num2 = 0.5;
					if (!flag14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v23+8]");
						Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CC0]");
						object obj25 = 0;
						rot = (Quaternion)0;
						at = (Vector3)0;
						b = 0;
						Enumerator<, > val3 = default;
						num = (float)val3;
						num2 = 0.5;
						Quaternion quaternion2 = default;
						RpcInfo info = default;
						Quaternion quaternion4 = default;
						double num5 = default;
						double num6 = default;
						object obj35 = default;
						object obj44 = default;
						object obj37;
						Enumerator<, > val6;
						while (true)
						{
							IL_0b93:
							if (val2.MoveNext())
							{
								object obj26 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X0_v52+E4]");
								bool flag15 = (nint)0 == 0;
								object obj27 = !flag15;
								if (obj27 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag16 = obj12 != null;
								bool flag17 = !flag16;
								b = 0;
								if (flag17)
								{
									continue;
								}
								bool flag18 = (object)obj12 == null;
								b = 0;
								obj13 = null;
								if (flag18)
								{
									break;
								}
								int num3 = 0;
								while (true)
								{
									bool flag19 = ((GillaCorpse)obj12).NewlyAtRest(num3, out at, out rot);
									bool flag20 = !flag19;
									Quaternion quaternion = (Quaternion)0;
									Vector3 vector = (Vector3)(&rot);
									b = (byte)(&at);
									if (!flag20)
									{
										Enumerator<, > val4 = val;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ stack_-B8 (UnityEngine.Object)+30]");
										((NetworkApe)val4).RPC_PlaceCorpse(0, (byte)num3, (Vector3)(&quaternion2), (Quaternion)0, info);
										TornArm tornArm = ((GillaCorpse)obj12).ArmOf(num3);
										object obj28 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v65+E4]");
										bool flag21 = (nint)0 == 0;
										object obj29 = !flag21;
										if (obj29 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag22 = tornArm == null;
										bool flag23 = !flag22;
										object obj30 = !flag23;
										quaternion = (Quaternion)0;
										vector = (Vector3)(&quaternion2);
										quaternion2 = (Quaternion)0;
										Quaternion quaternion3 = quaternion4;
										object obj31 = 0;
										double num4 = num5;
										Quaternion quaternion5 = rot;
										object obj32 = 0;
										Quaternion quaternion6 = (Quaternion)0;
										b = 0;
										num = (float)at;
										num2 = num6;
										if (obj30 == null)
										{
											bool flag24 = (object)tornArm == null;
											quaternion = (Quaternion)0;
											vector = (Vector3)(&quaternion2);
											quaternion3 = quaternion4;
											obj31 = 0;
											num4 = num5;
											quaternion5 = rot;
											obj32 = 0;
											quaternion6 = (Quaternion)0;
											b = 0;
											obj13 = null;
											num = (float)at;
											num2 = num6;
											if (flag24)
											{
												break;
											}
											object obj33 = 16;
											int num7 = 1;
											Quaternion quaternion7 = (Quaternion)0;
											Vector3 vector2 = (Vector3)(&quaternion2);
											Quaternion quaternion8 = quaternion4;
											object obj34 = 0;
											double num8 = num5;
											Quaternion quaternion9 = rot;
											obj32 = 0;
											Quaternion quaternion10 = (Quaternion)0;
											num = (float)at;
											num2 = num6;
											while (true)
											{
												Transform transform = tornArm.Link(num7);
												bool flag25 = (object)transform == null;
												b = 0;
												obj13 = (UnityEngine.Object)num7;
												if (!flag25)
												{
													Vector3 position = transform.position;
													Transform transform2 = tornArm.Link(num7);
													if ((object)transform2 != null)
													{
														Quaternion rotation = transform2.rotation;
														b = (byte)(obj33 | num3);
														Enumerator<, > val5 = val;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ stack_-B8 (UnityEngine.Object)+30]");
														((NetworkApe)val5).RPC_PlaceCorpse(0, b, (Vector3)(&obj35), (Quaternion)0, info);
														int num9 = num7 + 1;
														object obj36 = obj33 + 16;
														bool flag26 = num9 != 3;
														obj35 = 0;
														quaternion = (Quaternion)0;
														vector = (Vector3)(&obj35);
														quaternion2 = (Quaternion)0;
														quaternion3 = quaternion9;
														obj31 = obj32;
														num4 = num2;
														quaternion5 = (Quaternion)num;
														quaternion6 = quaternion9;
														obj35 = 0;
														obj33 = obj36;
														num7 = num9;
														quaternion7 = (Quaternion)0;
														vector2 = (Vector3)(&obj35);
														quaternion8 = quaternion9;
														obj34 = obj32;
														num8 = num2;
														quaternion9 = (Quaternion)num;
														quaternion10 = (Quaternion)num;
														if (!flag26)
														{
															break;
														}
														continue;
													}
													NullReferenceException ex2 = new NullReferenceException();
													b = 0;
													obj13 = (UnityEngine.Object)num7;
												}
												NullReferenceException ex3 = new NullReferenceException();
												quaternion = quaternion7;
												vector = vector2;
												quaternion3 = quaternion8;
												obj31 = obj34;
												num4 = num8;
												quaternion5 = quaternion9;
												quaternion6 = quaternion10;
												goto end_IL_0bfc;
											}
										}
									}
									num3++;
									if (num3 == 4)
									{
										goto IL_0b93;
									}
									continue;
									end_IL_0bfc:
									break;
								}
								NullReferenceException ex4 = new NullReferenceException();
								quaternion2 = (Quaternion)0;
								break;
							}
							obj11 = null;
							val2 = val3;
							obj37 = 0;
							val = (Enumerator<, >)(ref val2);
							val6 = (Enumerator<, >)(ref val2);
							object obj38 = 12;
							object obj39 = 0;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CA8]");
								object obj40 = 0;
								obj13 = (UnityEngine.Object)obj40;
								((Enumerator<, >*)val6)->Dispose();
								bool flag27 = obj39 == null;
								object obj41 = !flag27;
								if (obj41 == null)
								{
									bool flag28 = (object)obj11 == null;
									object obj42 = !flag28;
									OutOfMemoryException ex5 = (OutOfMemoryException)val6;
									if (obj42 == null)
									{
										if ((nint)obj38 != 12)
										{
											bool flag29 = obj38 == null;
											object obj43 = !flag29;
											if (obj43 != null)
											{
												return;
											}
										}
										((MonsterPlayer)val6).TellSlabsAtRest((NetworkApe)val);
										return;
									}
								}
								else
								{
									OutOfMemoryException ex5 = new OutOfMemoryException();
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
								if ((nint)obj13 == 2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									obj11 = (UnityEngine.Object)1;
									obj39 = obj37;
								}
								else
								{
									if ((nint)obj13 != 1)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									obj39 = obj44;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									obj37 = obj44;
								}
								obj38 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D85C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						NullReferenceException ex6 = new NullReferenceException();
						obj11 = null;
						val2 = val3;
						obj37 = 0;
						val = (Enumerator<, >)(ref val2);
						val6 = (Enumerator<, >)(ref val2);
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private unsafe (Vector3, Quaternion) InHand(bool right, Transform thing, bool byMiddle = default(bool))
	{
		//IL_01a8: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_018e: Expected VT, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_0164: Expected VT, but got I4
		//IL_0171: Expected VT, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_01f4: Expected Obj, but got I
		//IL_0202: Expected VT, but got I4
		//IL_0228: Expected VT, but got I4
		//IL_023f: Expected VT, but got Obj
		//IL_023a: Expected native int or pointer, but got VT
		//IL_024c: Expected VT, but got Obj
		//IL_0254: Expected VT, but got Ref
		//IL_010f: Expected VT, but got I4
		bool flag = !right;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 200;
		}
		else
		{
			object obj3 = 192;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v75 @ X8_v3]");
		Transform transform;
		Quaternion item;
		Vector3 vector;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v75 @ X8_v3]");
			Quaternion rotation = ((Transform)0).rotation;
			Quaternion rotation2 = default;
			Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
			if (byMiddle)
			{
				if ((object)thing != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9050]");
					object obj4 = 0;
					transform = (Transform)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
					object obj6 = default;
					object obj5 = obj6 & 1;
					Renderer renderer = default;
					if (obj5 == null)
					{
						item = (Quaternion)obj4;
						vector = (Vector3)(&renderer);
						goto IL_01e4;
					}
					Vector3 position = thing.position;
					if ((object)renderer != null)
					{
						Bounds bounds = renderer.bounds;
						vector = (Vector3)0;
						goto IL_0169;
					}
				}
			}
			else if ((object)thing != null)
			{
				Vector3 position2 = thing.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v75 @ X8_v3]");
				Vector3 position3 = ((Transform)0).position;
				transform = thing;
				vector = (Vector3)0;
				goto IL_0169;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return ((Vector3, Quaternion))ex;
		IL_0169:
		item = (Quaternion)transform;
		goto IL_01e4;
		IL_01e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD158]");
		object obj7 = 0;
		Vector3 vector2 = (Quaternion)0 * vector;
		Quaternion rotation3 = thing.rotation;
		_ = 0;
		_ = 0;
		(Vector3, Quaternion) tuple = ((Vector3, Quaternion))0;
		_ = 0;
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, ((Vector3)obj7, item));
		return tuple;
	}

	private unsafe void HoldBody(GillaCorpse c, int part, bool right, bool byMiddle = default(bool))
	{
		//IL_0015: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I4
		//IL_0b1e: Expected Obj, but got I4
		//IL_0b7b: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got I4
		//IL_0139: Expected VT, but got Ref
		//IL_0152: Expected Obj, but got Ref
		//IL_0bb3: Expected Obj, but got I
		//IL_0bdd: Expected Obj, but got I4
		//IL_0336: Expected Obj, but got I4
		//IL_0c15: Expected Obj, but got I4
		//IL_0cbe: Expected Obj, but got I
		//IL_0cf5: Expected Obj, but got I4
		//IL_04a6: Expected Obj, but got I4
		//IL_0704: Expected Obj, but got I
		//IL_071c: Expected Obj, but got I
		//IL_073e: Expected Obj, but got I4
		//IL_078e: Expected Obj, but got I4
		//IL_03f8: Expected VT, but got I4
		//IL_03f8: Expected VT, but got I4
		//IL_07ce: Expected VT, but got I
		//IL_07ce: Expected VT, but got I4
		//IL_07d7: Expected VT, but got I4
		//IL_0405: Unsupported input type for neg.
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_040e: Unsupported input type for neg.
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_0417: Unsupported input type for neg.
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0500: Expected Obj, but got I4
		//IL_052f: Expected Obj, but got I
		//IL_054b: Expected Obj, but got I4
		//IL_0868: Expected Obj, but got I4
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected Obj, but got Unknown
		//IL_0891: Expected Obj, but got I4
		//IL_056e: Expected Obj, but got I
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected Obj, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_0c76: Expected Obj, but got I4
		//IL_0c4d: Expected Obj, but got I4
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected Obj, but got Unknown
		//IL_05b8: Expected Obj, but got I
		//IL_05d4: Expected Obj, but got I4
		//IL_0932: Expected Obj, but got I4
		//IL_09e5: Expected Obj, but got I4
		//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected Obj, but got Unknown
		//IL_0a12: Expected Obj, but got I
		//IL_0a41: Expected Obj, but got I4
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected Obj, but got Unknown
		//IL_063b: Expected Obj, but got I4
		//IL_064b: Expected Obj, but got I
		//IL_0a78: Expected Obj, but got I4
		//IL_0983: Expected Obj, but got I8
		//IL_068d: Expected VT, but got I4
		//IL_068d: Expected VT, but got Ref
		//IL_0ca5: Expected F4, but got I
		//IL_0ca5: Expected F4, but got I
		//IL_069a: Expected VT, but got Ref
		//IL_06da: Expected I4, but got VT
		object obj;
		int num;
		TornArm tornArm;
		int num2;
		if ((object)c != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj = 0;
			bool flag = c.IsOff(part);
			bool flag2 = !flag;
			object obj2 = !flag2;
			object obj3 = ~obj2;
			num = ((obj3 == null) ? part : 0);
			tornArm = c.ArmOf(num);
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(tornArm != null))
			{
				num2 = 0;
				ref float reference = ref *(float*)null;
				UnityEngine.Object obj6 = null;
				goto IL_0b51;
			}
			bool flag4 = !right;
			object obj7 = !flag4;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				object obj9 = 200;
			}
			else
			{
				object obj9 = 192;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v271 @ X8_v37]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterPlayer)+v271 @ X8_v37]");
				Vector3 position = ((Transform)0).position;
				if ((object)tornArm != null)
				{
					object obj10 = default;
					int num3 = tornArm.Nearest((Vector3)(&obj10), out *(float*)null);
					num2 = num3;
					ref float reference = ref *(float*)null;
					UnityEngine.Object obj6 = (UnityEngine.Object)(&obj10);
					goto IL_0b51;
				}
			}
		}
		goto IL_0ab1;
		IL_0b51:
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform;
		if (tornArm != null)
		{
			if ((object)tornArm == null)
			{
				goto IL_0ab1;
			}
			transform = tornArm.Link(num2);
			object obj13 = 0;
			int num4 = num2;
		}
		else
		{
			transform = c.Thing(part);
			object obj13 = 0;
			int num4 = part;
		}
		bool byMiddle2;
		if (byMiddle)
		{
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v85+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			byMiddle2 = tornArm == null;
		}
		else
		{
			byMiddle2 = false;
		}
		if ((object)this != null)
		{
			(Vector3, Quaternion) tuple = InHand(right, transform, byMiddle2);
			bool flag7 = !byMiddle;
			object obj17 = default;
			object obj16 = obj17;
			object obj19 = default;
			object obj18 = obj19;
			object obj21 = default;
			object obj20 = obj21;
			object obj23 = default;
			object obj22 = obj23;
			object obj25 = default;
			object obj24 = obj25;
			object obj27 = default;
			object obj26 = obj27;
			Transform transform2 = transform;
			int num5 = (right ? 1 : 0);
			object obj30 = default;
			object obj31 = default;
			object obj32 = default;
			if (!flag7)
			{
				object obj28 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v75+E4]");
				bool flag8 = (nint)0 == 0;
				object obj29 = !flag8;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag9 = tornArm != null;
				bool flag10 = !flag9;
				obj16 = obj17;
				obj18 = obj19;
				obj20 = obj21;
				obj22 = obj23;
				obj24 = obj25;
				obj26 = obj27;
				transform2 = null;
				num5 = 0;
				if (!flag10)
				{
					if ((object)tornArm == null)
					{
						goto IL_0ab1;
					}
					Vector3 vector = tornArm.MiddleOf(num2);
					Vector3 vector2 = (Quaternion)0 * (Vector3)num2;
					obj26 = 0 - obj30;
					obj24 = 0 - obj31;
					obj22 = 0 - obj32;
					obj16 = obj32;
					obj18 = obj31;
					obj20 = obj30;
					transform2 = null;
					num5 = num2;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj33 = 0;
			object obj34 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v23+E4]");
			bool flag11 = (nint)0 == 0;
			object obj35 = !flag11;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj36 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v27+E4]");
			bool flag12 = (nint)0 == 0;
			object obj37 = !flag12;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj36 = obj33;
			}
			object obj38 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v27+A0]");
			object obj39 = 0;
			int num6 = num | num2;
			UnityEngine.Object obj40 = (UnityEngine.Object)obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v15+E4]");
			bool flag13 = (nint)0 == 0;
			object obj41 = !flag13;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag14 = (UnityEngine.Object)obj39 != null;
			bool flag15 = !flag14;
			object obj42 = 0;
			UnityEngine.Object obj43 = null;
			object obj56 = default;
			Vector3 vector3;
			object obj51;
			object obj52;
			object obj53;
			object obj54;
			object obj55;
			object obj57;
			object obj58;
			int num7;
			int num8;
			bool flag23;
			if (!flag15)
			{
				if (obj39 == null)
				{
					goto IL_0ab1;
				}
				object obj44 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v48+E4]");
				bool flag16 = (nint)0 == 0;
				object obj45 = !flag16;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X24_v4 (UnityEngine.Object)+40]");
				bool flag17 = (UnityEngine.Object)0 != null;
				bool flag18 = !flag17;
				obj42 = 0;
				obj43 = null;
				if (!flag18)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X24_v4 (UnityEngine.Object)+40]");
					UnityEngine.Object obj46 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X24_v4 (UnityEngine.Object)+40]");
					if ((nint)0 == 0)
					{
						goto IL_0ab1;
					}
					object obj47 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X0_v53+E4]");
					bool flag19 = (nint)0 == 0;
					object obj48 = !flag19;
					if (obj48 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X25_v10 (UnityEngine.Object)+30]");
					bool flag20 = (UnityEngine.Object)0;
					bool flag21 = !flag20;
					obj42 = 0;
					obj43 = null;
					if (!flag21)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X25_v10 (UnityEngine.Object)+30]");
						if ((nint)0 == 0)
						{
							goto IL_0ab1;
						}
						ArgumentNullException ex = new ArgumentNullException();
						object obj49 = ex & 1;
						bool flag22 = obj49 == null;
						obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X24_v4 (UnityEngine.Object)+40]");
						obj43 = (UnityEngine.Object)0;
						if (!flag22)
						{
							NetworkBool networkBool = right;
							object obj50 = default;
							RpcInfo info = default;
							((NetworkApe)obj39).RPC_HoldCorpse(c.Id__BackingField, (byte)num6, networkBool, (Vector3)(&obj50), (Quaternion)0, info);
							vector3 = (Vector3)(&obj50);
							obj51 = obj30;
							obj52 = obj22;
							obj53 = obj24;
							obj54 = obj26;
							obj55 = obj56;
							obj57 = obj32;
							obj58 = obj31;
							num7 = (int)networkBool;
							num8 = num6;
							flag23 = (byte)c.Id__BackingField != 0;
							goto IL_0831;
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj59 = 0;
			object obj60 = obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X0_v39+E4]");
			bool flag24 = (nint)0 == 0;
			object obj62 = !flag24;
			if (obj62 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
			object obj63 = obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v27+E4]");
			bool flag25 = (nint)0 == 0;
			object obj64 = !flag25;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IntPtr intPtr = default;
			GillaCorpse.HoldIt(none, right, c.Id__BackingField, num6, (Vector3)0, (Quaternion)(nint)intPtr);
			vector3 = (Vector3)0;
			obj51 = obj30;
			obj52 = obj22;
			obj53 = obj24;
			obj54 = obj26;
			obj55 = obj56;
			obj57 = obj32;
			obj58 = obj31;
			num7 = num6;
			num8 = c.Id__BackingField;
			flag23 = right;
			goto IL_0831;
		}
		goto IL_0ab1;
		IL_0ab1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0abf;
		IL_0abf:
		throw new IndexOutOfRangeException();
		IL_0831:
		int[] array = bodyOf;
		if (bodyOf == null)
		{
			goto IL_0ab1;
		}
		object obj65 = (right ? 1 : 0) ^ 1;
		object obj66 = obj65 & 1;
		bool flag26 = (nint)obj66 < array.Length;
		object obj67 = !flag26;
		if (obj67 == null)
		{
			object obj68 = obj65 & 1;
			object obj69 = (object)bodyOf + obj68;
			object obj70 = obj69 + 32;
			if ((nint)obj70 == c.Id__BackingField)
			{
				int[] array2 = bodyPart;
				if (bodyPart == null)
				{
					goto IL_0ab1;
				}
				bool flag27 = (nint)obj66 < array2.Length;
				object obj71 = !flag27;
				if (obj71 != null)
				{
					goto IL_0abf;
				}
				object obj72 = (object)bodyPart + obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X11_v7+20]");
				if ((nint)0 == num)
				{
					obj70 = 4294967295L;
				}
			}
			bool flag28 = (right ? 1 : 0) < array.Length;
			object obj73 = !flag28;
			if (obj73 == null)
			{
				object obj74 = bodyOf + right;
				int[] array3 = bodyPart;
				_ = c.Id__BackingField;
				if (bodyPart == null)
				{
					goto IL_0ab1;
				}
				bool flag29 = (right ? 1 : 0) < array3.Length;
				object obj75 = !flag29;
				if (obj75 == null)
				{
					object obj76 = bodyPart + right;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
					object obj77 = 0;
					object obj78 = obj77;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v32+E4]");
					bool flag30 = (nint)0 == 0;
					object obj79 = !flag30;
					if (obj79 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag31 = !right;
					object obj80 = !flag31;
					object obj81 = ~obj80;
					XRNode node = ((obj81 != null) ? ((XRNode)4) : ((XRNode)5));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					Buzz(node, num9, 0f);
					return;
				}
			}
		}
		goto IL_0abf;
	}

	private unsafe void HoldPiece(GillaPieceId p, bool right)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I4
		//IL_08ad: Expected Obj, but got I
		//IL_08cf: Expected Obj, but got I4
		//IL_094f: Expected Obj, but got I
		//IL_0979: Expected Obj, but got I4
		//IL_03b2: Expected Obj, but got I
		//IL_03ca: Expected Obj, but got I
		//IL_03ec: Expected Obj, but got I4
		//IL_043c: Expected Obj, but got I4
		//IL_0480: Expected VT, but got I4
		//IL_0480: Expected VT, but got I
		//IL_0489: Expected VT, but got I4
		//IL_04de: Expected I4, but got VT
		//IL_04e6: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_0522: Expected Obj, but got I4
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected Obj, but got Unknown
		//IL_054b: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected Obj, but got Unknown
		//IL_05a0: Expected Obj, but got I4
		//IL_05d2: Expected Obj, but got I
		//IL_0907: Expected Obj, but got I4
		//IL_0216: Expected Obj, but got I
		//IL_06e3: Expected I, but got Obj
		//IL_06f3: Expected Obj, but got I
		//IL_0650: Expected Obj, but got I4
		//IL_073e: Expected Obj, but got I4
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected Obj, but got Unknown
		//IL_0695: Expected Obj, but got I4
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected Obj, but got Unknown
		//IL_0774: Expected Obj, but got I
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected Obj, but got Unknown
		//IL_07be: Expected Obj, but got I4
		//IL_07f5: Expected Obj, but got I4
		//IL_0323: Expected VT, but got I4
		//IL_0323: Expected VT, but got I4
		//IL_0323: Expected VT, but got Ref
		//IL_0323: Expected I4, but got VT
		//IL_0338: Expected VT, but got I
		//IL_039d: Expected Obj, but got VT
		//IL_0936: Expected F4, but got I
		//IL_0936: Expected F4, but got I
		bool flag = (object)p == null;
		IntPtr intPtr = default;
		bool flag2 = (byte)(nint)intPtr != 0;
		bool flag3 = right;
		UnityEngine.Object obj = p;
		object obj6;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj2 = 0;
			Transform thing = p.transform;
			(Vector3, Quaternion) tuple = InHand(right, thing, byMiddle: false);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj4 = !flag4;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v17+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj2;
			}
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v17+A0]");
			object obj9 = 0;
			UnityEngine.Object obj10 = (UnityEngine.Object)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = (UnityEngine.Object)obj9 != null;
			bool flag8 = !flag7;
			bool flag9 = false;
			UnityEngine.Object obj12 = null;
			object obj21 = default;
			object obj23 = default;
			object obj25 = default;
			object obj27 = default;
			object obj29 = default;
			object obj31 = default;
			object obj33 = default;
			Quaternion quaternion;
			object obj20;
			object obj22;
			object obj24;
			object obj26;
			object obj28;
			object obj30;
			object obj32;
			if (!flag8)
			{
				bool flag10 = obj9 == null;
				flag2 = false;
				flag3 = false;
				obj = null;
				if (flag10)
				{
					goto IL_082e;
				}
				object obj13 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X0_v52+E4]");
				bool flag11 = (nint)0 == 0;
				object obj14 = !flag11;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X22_v7 (UnityEngine.Object)+40]");
				bool flag12 = (UnityEngine.Object)0 != null;
				bool flag13 = !flag12;
				flag9 = false;
				obj12 = null;
				if (!flag13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X22_v7 (UnityEngine.Object)+40]");
					UnityEngine.Object obj15 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X22_v7 (UnityEngine.Object)+40]");
					bool flag14 = (nint)0 == 0;
					flag2 = false;
					flag3 = false;
					obj = null;
					if (flag14)
					{
						goto IL_082e;
					}
					object obj16 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v57+E4]");
					bool flag15 = (nint)0 == 0;
					object obj17 = !flag15;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X23_v11 (UnityEngine.Object)+30]");
					bool flag16 = (UnityEngine.Object)0;
					bool flag17 = !flag16;
					flag9 = false;
					obj12 = null;
					if (!flag17)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X23_v11 (UnityEngine.Object)+30]");
						bool flag18 = (nint)0 == 0;
						flag2 = false;
						flag3 = false;
						obj = null;
						if (flag18)
						{
							goto IL_082e;
						}
						ArgumentNullException ex = new ArgumentNullException();
						object obj18 = ex & 1;
						bool flag19 = obj18 == null;
						flag9 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X22_v7 (UnityEngine.Object)+40]");
						obj12 = (UnityEngine.Object)0;
						if (!flag19)
						{
							NetworkBool right2 = right;
							PieceKey key = p.key;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaPieceId)+24]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaPieceId)+21]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaPieceId)+28]");
							object obj19 = default;
							((NetworkApe)obj9).RPC_HoldPiece((byte)(int)key, (int)num, (byte)num2, 0, right2, (Vector3)(&obj19), (Quaternion)0, (RpcInfo)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaPieceId)+28]");
							quaternion = (Quaternion)0;
							obj20 = obj21;
							obj22 = obj23;
							obj24 = obj25;
							obj26 = obj27;
							obj28 = obj29;
							obj30 = obj31;
							obj32 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaPieceId)+21]");
							flag2 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaPieceId)+24]");
							flag3 = false;
							obj = (UnityEngine.Object)p.key;
							goto IL_04eb;
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v43+E4]");
			bool flag20 = (nint)0 == 0;
			object obj37 = !flag20;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
			object obj38 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v27+E4]");
			bool flag21 = (nint)0 == 0;
			object obj39 = !flag21;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool right3 = right;
			PieceKey key2 = p.key;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaPieceId)+28]");
			GillaSlice.HoldIt(none, right3, key2, (Vector3)0, (Quaternion)0);
			quaternion = (Quaternion)0;
			obj20 = obj21;
			obj22 = obj23;
			obj24 = obj25;
			obj26 = obj27;
			obj28 = obj29;
			obj30 = obj31;
			obj32 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaPieceId)+28]");
			flag2 = false;
			flag3 = (byte)(int)p.key != 0;
			obj = (UnityEngine.Object)right;
			goto IL_04eb;
		}
		goto IL_082e;
		IL_082e:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_083c;
		IL_084a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_083c:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		goto IL_084a;
		IL_04eb:
		GillaPieceId[] array = pieceIn;
		if (pieceIn == null)
		{
			goto IL_082e;
		}
		object obj40 = (right ? 1 : 0) ^ 1;
		object obj41 = obj40 & 1;
		bool flag22 = (nint)obj41 < array.Length;
		object obj42 = !flag22;
		if (obj42 == null)
		{
			object obj43 = obj40 & 1;
			object obj44 = obj6;
			object obj45 = (object)pieceIn + obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v22+E4]");
			bool flag23 = (nint)0 == 0;
			object obj46 = !flag23;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v14+20]");
			bool flag24 = (UnityEngine.Object)0 == p;
			bool flag25 = !flag24;
			obj = p;
			if (!flag25)
			{
				GillaPieceId[] array2 = pieceIn;
				bool flag26 = pieceIn == null;
				flag3 = false;
				obj = p;
				if (flag26)
				{
					goto IL_082e;
				}
				bool flag27 = (nint)obj41 < array2.Length;
				object obj47 = !flag27;
				flag3 = false;
				obj = p;
				if (obj47 != null)
				{
					goto IL_083c;
				}
				object obj48 = (object)pieceIn + obj43;
				object obj49 = obj48 + 32;
				obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj = null;
			}
			GillaPieceId[] array3 = pieceIn;
			bool flag28 = pieceIn == null;
			flag3 = false;
			if (flag28)
			{
				goto IL_082e;
			}
			nint num3 = (nint)array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v16 (Il2CppClass<GillaPieceId[]>)+40]");
			obj = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag29 = ex3 == null;
			flag3 = false;
			if (flag29)
			{
				goto IL_084a;
			}
			bool flag30 = (right ? 1 : 0) < array3.Length;
			object obj50 = !flag30;
			flag3 = false;
			if (obj50 == null)
			{
				object obj51 = pieceIn + right;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				object obj52 = 0;
				object obj53 = obj51 + 32;
				obj53 = p;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj54 = obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X0_v32+E4]");
				bool flag31 = (nint)0 == 0;
				object obj55 = !flag31;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag32 = !right;
				object obj56 = !flag32;
				object obj57 = ~obj56;
				XRNode node = ((obj57 != null) ? ((XRNode)4) : ((XRNode)5));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				Buzz(node, num4, 0f);
				return;
			}
		}
		goto IL_083c;
	}

	private unsafe void LetGoPiece(bool right, Vector3 velocity)
	{
		//IL_0020: Expected Obj, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_071b: Expected Obj, but got I
		//IL_0745: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I4
		//IL_0656: Expected Obj, but got I4
		//IL_076b: Expected Obj, but got I
		//IL_0795: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I4
		//IL_0477: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I4
		//IL_02b3: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I4
		//IL_02f2: Expected Obj, but got I
		//IL_06d3: Expected Obj, but got I
		//IL_06fd: Expected Obj, but got I4
		//IL_0571: Expected VT, but got I
		//IL_0571: Expected VT, but got I4
		//IL_068e: Expected Obj, but got I4
		//IL_033c: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I4
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_03bf: Expected Obj, but got I4
		//IL_03cf: Expected Obj, but got I
		//IL_06be: Expected VT, but got I4
		//IL_06be: Expected VT, but got Ref
		GillaPieceId[] array = pieceIn;
		object obj4;
		Vector3 velocity2 = default;
		Vector3 spin = default;
		if (pieceIn != null)
		{
			bool flag = (right ? 1 : 0) < array.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0585;
			}
			object obj2 = pieceIn + right;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			obj4 = obj2 + 32;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = (UnityEngine.Object)obj4 == null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			if (obj7 != null)
			{
				return;
			}
			if (obj4 != null)
			{
				if (!((UnityEngine.Behaviour)obj4).isActiveAndEnabled)
				{
					return;
				}
				object obj9 = default;
				object obj8 = obj9 * obj9;
				object obj11 = default;
				object obj10 = obj11 * obj11;
				object obj12 = obj8 + obj10;
				float num2 = default;
				float num = num2 * num2;
				float num3 = num + (float)obj12;
				float num4 = maxBodyThrow * maxBodyThrow;
				if (num3 > num4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj13 = 0;
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v83+E4]");
					bool flag5 = (nint)0 == 0;
					object obj15 = !flag5;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					num = (float)obj9 / num4;
					float num5 = (float)obj11 / num4;
					num4 = num2 / num4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v18+E4]");
				bool flag6 = (nint)0 == 0;
				object obj18 = !flag6;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj19 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v22+E4]");
				bool flag7 = (nint)0 == 0;
				object obj20 = !flag7;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj19 = obj16;
				}
				object obj21 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v22+A0]");
				object obj22 = 0;
				UnityEngine.Object obj23 = (UnityEngine.Object)obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v15+E4]");
				bool flag8 = (nint)0 == 0;
				object obj24 = !flag8;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag9 = (UnityEngine.Object)obj22 != null;
				bool flag10 = !flag9;
				object obj25 = 0;
				UnityEngine.Object obj26 = null;
				if (flag10)
				{
					goto IL_0467;
				}
				if (obj22 != null)
				{
					object obj27 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v46+E4]");
					bool flag11 = (nint)0 == 0;
					object obj28 = !flag11;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v8 (UnityEngine.Object)+40]");
					bool flag12 = (UnityEngine.Object)0 != null;
					bool flag13 = !flag12;
					obj25 = 0;
					obj26 = null;
					if (flag13)
					{
						goto IL_0467;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v8 (UnityEngine.Object)+40]");
					UnityEngine.Object obj29 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v8 (UnityEngine.Object)+40]");
					if ((nint)0 != 0)
					{
						object obj30 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v51+E4]");
						bool flag14 = (nint)0 == 0;
						object obj31 = !flag14;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X22_v9 (UnityEngine.Object)+30]");
						bool flag15 = (UnityEngine.Object)0;
						bool flag16 = !flag15;
						obj25 = 0;
						obj26 = null;
						if (flag16)
						{
							goto IL_0467;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X22_v9 (UnityEngine.Object)+30]");
						if ((nint)0 != 0)
						{
							ArgumentNullException ex = new ArgumentNullException();
							object obj32 = ex & 1;
							bool flag17 = obj32 == null;
							obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v8 (UnityEngine.Object)+40]");
							obj26 = (UnityEngine.Object)0;
							if (flag17)
							{
								goto IL_0467;
							}
							NetworkBool right2 = right;
							Transform transform = ((Component)obj4).transform;
							if ((object)transform != null)
							{
								Vector3 position = transform.position;
								Transform transform2 = ((Component)obj4).transform;
								if ((object)transform2 != null)
								{
									Quaternion rotation = transform2.rotation;
									object obj33 = default;
									RpcInfo info = default;
									((NetworkApe)obj22).RPC_LetGoPiece(right2, (Vector3)(&obj33), (Quaternion)0, velocity2, spin, info);
									return;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0577;
		IL_0577:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0585;
		IL_0467:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj34 = 0;
		object obj35 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v27+E4]");
		bool flag18 = (nint)0 == 0;
		object obj36 = !flag18;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
		Transform transform3 = ((Component)obj4).transform;
		if ((object)transform3 != null)
		{
			Vector3 position2 = transform3.position;
			Transform transform4 = ((Component)obj4).transform;
			if ((object)transform4 != null)
			{
				Quaternion rotation2 = transform4.rotation;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
				object obj37 = 0;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v38+E4]");
				bool flag19 = (nint)0 == 0;
				object obj39 = !flag19;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				IntPtr intPtr = default;
				GillaSlice.LetGo(none, right, (Vector3)0, (Quaternion)(nint)intPtr, velocity2, spin);
				return;
			}
		}
		goto IL_0577;
		IL_0585:
		throw new IndexOutOfRangeException();
	}

	public GillaPieceId PieceIn(bool right)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I
		GillaPieceId[] array = pieceIn;
		if (pieceIn != null)
		{
			bool flag = (right ? 1 : 0) < array.Length;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = pieceIn + right;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2+20]");
				return (GillaPieceId)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (GillaPieceId)(object)new IndexOutOfRangeException();
	}

	public bool FistNow(bool right)
	{
		return Fist(right);
	}

	private unsafe void LetGoBody(bool right, Vector3 velocity)
	{
		//IL_0020: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I4
		//IL_0343: Expected Obj, but got I4
		//IL_08b9: Expected Obj, but got I
		//IL_08e3: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I4
		//IL_036d: Expected Obj, but got I
		//IL_0397: Expected Obj, but got I4
		//IL_0804: Expected Obj, but got I4
		//IL_0909: Expected Obj, but got I
		//IL_0933: Expected Obj, but got I4
		//IL_0450: Expected Obj, but got I4
		//IL_0661: Expected Obj, but got I
		//IL_068b: Expected Obj, but got I4
		//IL_04aa: Expected Obj, but got I4
		//IL_04d9: Expected Obj, but got I
		//IL_04f5: Expected Obj, but got I4
		//IL_089b: Expected Obj, but got I4
		//IL_071f: Expected VT, but got I
		//IL_071f: Expected VT, but got I4
		//IL_0518: Expected Obj, but got I
		//IL_083c: Expected Obj, but got I4
		//IL_0562: Expected Obj, but got I
		//IL_057e: Expected Obj, but got I4
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected Obj, but got Unknown
		//IL_05e5: Expected Obj, but got I4
		//IL_05f5: Expected Obj, but got I
		//IL_086c: Expected VT, but got I4
		//IL_086c: Expected VT, but got Ref
		int[] array = bodyOf;
		object obj2;
		Transform transform;
		Vector3 velocity2 = default;
		Vector3 spin = default;
		if (bodyOf != null)
		{
			bool flag = (right ? 1 : 0) < array.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0733;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			obj2 = 0;
			object obj3 = bodyOf + right;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v6+20]");
			GillaCorpse gillaCorpse = GillaCorpse.Find(0);
			int[] array2 = bodyPart;
			if (bodyPart != null)
			{
				bool flag3 = (right ? 1 : 0) < array2.Length;
				object obj6 = !flag3;
				if (obj6 != null)
				{
					goto IL_0733;
				}
				int[] array3 = bodyOf;
				if (bodyOf != null)
				{
					bool flag4 = (right ? 1 : 0) < array3.Length;
					object obj7 = !flag4;
					if (obj7 != null)
					{
						goto IL_0733;
					}
					object obj8 = bodyPart + right;
					object obj9 = bodyOf + right;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj10 = 0;
					_ = 4294967295L;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v10+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = gillaCorpse == null;
					bool flag7 = !flag6;
					object obj13 = !flag7;
					if (obj13 != null)
					{
						return;
					}
					if ((object)gillaCorpse != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v8+20]");
						if (!gillaCorpse.Has(0))
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v8+20]");
						TornArm tornArm = gillaCorpse.ArmOf(0);
						object obj14 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v11+E4]");
						bool flag8 = (nint)0 == 0;
						object obj15 = !flag8;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (tornArm != null)
						{
							if ((object)tornArm == null)
							{
								goto IL_0725;
							}
							transform = tornArm.HeldLink;
							object obj16 = 0;
							int num = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v8+20]");
							transform = gillaCorpse.Thing(0);
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v8+20]");
							int num = 0;
						}
						object obj18 = default;
						object obj17 = obj18 * obj18;
						object obj20 = default;
						object obj19 = obj20 * obj20;
						object obj21 = obj17 + obj19;
						float num3 = default;
						float num2 = num3 * num3;
						float num4 = num2 + (float)obj21;
						float num5 = maxBodyThrow * maxBodyThrow;
						if (num4 > num5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj22 = 0;
							object obj23 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v86+E4]");
							bool flag9 = (nint)0 == 0;
							object obj24 = !flag9;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							num2 = (float)obj18 / num5;
							float num6 = (float)obj20 / num5;
							num5 = num3 / num5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
						object obj25 = 0;
						object obj26 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v25+E4]");
						bool flag10 = (nint)0 == 0;
						object obj27 = !flag10;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj28 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v29+E4]");
						bool flag11 = (nint)0 == 0;
						object obj29 = !flag11;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj28 = obj25;
						}
						object obj30 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v29+A0]");
						object obj31 = 0;
						UnityEngine.Object obj32 = (UnityEngine.Object)obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v19+E4]");
						bool flag12 = (nint)0 == 0;
						object obj33 = !flag12;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag13 = (UnityEngine.Object)obj31 != null;
						bool flag14 = !flag13;
						object obj34 = 0;
						UnityEngine.Object obj35 = null;
						if (flag14)
						{
							goto IL_0651;
						}
						if (obj31 != null)
						{
							object obj36 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X0_v51+E4]");
							bool flag15 = (nint)0 == 0;
							object obj37 = !flag15;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X21_v8 (UnityEngine.Object)+40]");
							bool flag16 = (UnityEngine.Object)0 != null;
							bool flag17 = !flag16;
							obj34 = 0;
							obj35 = null;
							if (flag17)
							{
								goto IL_0651;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X21_v8 (UnityEngine.Object)+40]");
							UnityEngine.Object obj38 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X21_v8 (UnityEngine.Object)+40]");
							if ((nint)0 != 0)
							{
								object obj39 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v56+E4]");
								bool flag18 = (nint)0 == 0;
								object obj40 = !flag18;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X22_v11 (UnityEngine.Object)+30]");
								bool flag19 = (UnityEngine.Object)0;
								bool flag20 = !flag19;
								obj34 = 0;
								obj35 = null;
								if (flag20)
								{
									goto IL_0651;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X22_v11 (UnityEngine.Object)+30]");
								if ((nint)0 != 0)
								{
									ArgumentNullException ex = new ArgumentNullException();
									object obj41 = ex & 1;
									bool flag21 = obj41 == null;
									obj34 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X21_v8 (UnityEngine.Object)+40]");
									obj35 = (UnityEngine.Object)0;
									if (flag21)
									{
										goto IL_0651;
									}
									NetworkBool right2 = right;
									if ((object)transform != null)
									{
										Vector3 position = transform.position;
										Quaternion rotation = transform.rotation;
										object obj42 = default;
										RpcInfo info = default;
										((NetworkApe)obj31).RPC_LetGoCorpse(right2, (Vector3)(&obj42), (Quaternion)0, velocity2, spin, info);
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0725;
		IL_0725:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0733;
		IL_0733:
		throw new IndexOutOfRangeException();
		IL_0651:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj43 = 0;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v34+E4]");
		bool flag22 = (nint)0 == 0;
		object obj45 = !flag22;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
		if ((object)transform != null)
		{
			Vector3 position2 = transform.position;
			Quaternion rotation2 = transform.rotation;
			object obj46 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v43+E4]");
			bool flag23 = (nint)0 == 0;
			object obj47 = !flag23;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IntPtr intPtr = default;
			GillaCorpse.LetGo(none, right, (Vector3)0, (Quaternion)(nint)intPtr, velocity2, spin);
			return;
		}
		goto IL_0725;
	}

	public (int, int) BodyIn(bool right)
	{
		//IL_00e2: Expected VT, but got Obj
		//IL_0020: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00c6: Expected VT, but got I4
		int[] array = bodyOf;
		if (bodyOf == null)
		{
			goto IL_00c6;
		}
		bool flag = (right ? 1 : 0) < array.Length;
		object obj = !flag;
		if (obj == null)
		{
			int[] array2 = bodyPart;
			if (bodyPart == null)
			{
				goto IL_00c6;
			}
			bool flag2 = (right ? 1 : 0) < array2.Length;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				object obj3 = bodyOf + right;
				object obj4 = bodyPart + right;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v4+20]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X9_v5+20]");
				(int, int) tuple = ((int)num, 0);
				return ((int, int))0;
			}
		}
		goto IL_00d4;
		IL_00c6:
		NullReferenceException ex = new NullReferenceException();
		goto IL_00d4;
		IL_00d4:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return ((int, int))ex2;
	}

	private unsafe void Killing(float reach, float dt)
	{
		//IL_073f: Invalid comparison between F4 and I4
		//IL_0763: Expected Obj, but got I
		//IL_078d: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0072: Expected VT, but got Obj
		//IL_0094: Expected Obj, but got I4
		//IL_07c5: Expected Obj, but got I4
		//IL_07fd: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I
		//IL_0254: Expected VT, but got Obj
		//IL_0276: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I4
		//IL_0675: Expected VT, but got Ref
		//IL_0685: Expected Obj, but got I
		//IL_06ba: Expected Obj, but got I4
		//IL_06f6: Expected F4, but got I
		//IL_0715: Expected F4, but got I
		//IL_0326: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I
		//IL_0184: Expected VT, but got Obj
		//IL_01a6: Expected Obj, but got I4
		//IL_0392: Expected VT, but got Ref
		//IL_03c0: Expected Obj, but got I4
		//IL_0835: Expected Obj, but got I4
		//IL_086d: Expected Obj, but got I4
		//IL_062d: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I4
		//IL_0561: Expected Obj, but got I4
		//IL_04a5: Expected Obj, but got I4
		//IL_0658: Expected VT, but got I4
		//IL_04d0: Expected VT, but got Ref
		//IL_05ad: Expected Obj, but got I4
		//IL_05d8: Expected VT, but got Ref
		float num2 = default;
		float num = (killCooldown -= num2);
		if (num > 0f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		UnityEngine.Object obj;
		if (~(gripL ? 1u : 0u) != 0 || ~(wasGripL ? 1u : 0u) == 0)
		{
			obj = null;
		}
		else
		{
			Vector3 position = leftFollower.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj2 = 0;
			Vector3 at = (Vector3)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v87 (UnityEngine.Vector3)+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkApe networkApe = NearestBody(at, num);
			float num3 = reach;
			obj = networkApe;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = obj == null;
		bool flag4 = !flag3;
		UnityEngine.Object obj7 = null;
		if (!flag4)
		{
			bool flag5 = (byte)(~(gripR ? 1u : 0u)) != 0;
			obj7 = null;
			if (!flag5)
			{
				bool flag6 = (byte)(~(wasGripR ? 1u : 0u)) != 0;
				object obj8 = !flag6;
				obj7 = null;
				if (obj8 == null)
				{
					Vector3 position2 = rightFollower.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
					object obj9 = 0;
					Vector3 at2 = (Vector3)obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v78 (UnityEngine.Vector3)+E4]");
					bool flag7 = (nint)0 == 0;
					object obj10 = !flag7;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					NetworkApe networkApe2 = NearestBody(at2, num);
					float num3 = reach;
					obj7 = null;
					obj = networkApe2;
				}
			}
		}
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v9+E4]");
		bool flag8 = (nint)0 == 0;
		object obj12 = !flag8;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = obj == null;
		bool flag10 = !flag9;
		UnityEngine.Object obj13 = null;
		if (!flag10)
		{
			Vector3 position3 = head.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj14 = 0;
			Vector3 at3 = (Vector3)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v71 (UnityEngine.Vector3)+E4]");
			bool flag11 = (nint)0 == 0;
			object obj15 = !flag11;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num4 = reach;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			float num3 = num4 * 0f;
			NetworkApe networkApe3 = NearestBody(at3, num);
			obj13 = null;
			obj = networkApe3;
		}
		object obj16 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v14+E4]");
		bool flag12 = (nint)0 == 0;
		object obj17 = !flag12;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj == null)
		{
			Vector3 position4 = head.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v26+E4]");
			bool flag13 = (nint)0 == 0;
			object obj20 = !flag13;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num5 = reach;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			float num6 = num5 * 0f;
			object obj21 = default;
			GillaDummy gillaDummy = GillaDummy.Nearest((Vector3)(&obj21), num, out *(float*)null);
			object obj22 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v17+E4]");
			bool flag14 = (nint)0 == 0;
			object obj23 = !flag14;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag15 = (UnityEngine.Object)gillaDummy == (UnityEngine.Object)null;
			bool flag16 = !flag15;
			ref float reference = ref *(float*)null;
			GillaDummy gillaDummy2 = gillaDummy;
			if (!flag16)
			{
				bool flag17 = (byte)(~(gripL ? 1u : 0u)) != 0;
				reference = ref *(float*)null;
				gillaDummy2 = gillaDummy;
				if (!flag17)
				{
					bool flag18 = (byte)(~(wasGripL ? 1u : 0u)) != 0;
					object obj24 = !flag18;
					reference = ref *(float*)null;
					gillaDummy2 = gillaDummy;
					if (obj24 == null)
					{
						Vector3 position5 = leftFollower.position;
						object obj25 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v59+E4]");
						bool flag19 = (nint)0 == 0;
						object obj26 = !flag19;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaDummy gillaDummy3 = GillaDummy.Nearest((Vector3)(&obj21), num, out *(float*)null);
						num6 = reach;
						reference = ref *(float*)null;
						gillaDummy2 = gillaDummy3;
					}
				}
			}
			object obj27 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v34+E4]");
			bool flag20 = (nint)0 == 0;
			object obj28 = !flag20;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag21 = (UnityEngine.Object)gillaDummy2 == (UnityEngine.Object)null;
			bool flag22 = !flag21;
			ref float reference2 = ref *(float*)null;
			if (!flag22)
			{
				bool flag23 = (byte)(~(gripR ? 1u : 0u)) != 0;
				reference2 = ref *(float*)null;
				if (!flag23)
				{
					bool flag24 = (byte)(~(wasGripR ? 1u : 0u)) != 0;
					object obj29 = !flag24;
					reference2 = ref *(float*)null;
					if (obj29 == null)
					{
						Vector3 position6 = rightFollower.position;
						object obj30 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v51+E4]");
						bool flag25 = (nint)0 == 0;
						object obj31 = !flag25;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaDummy gillaDummy4 = GillaDummy.Nearest((Vector3)(&obj21), num, out *(float*)null);
						num6 = reach;
						reference2 = ref *(float*)null;
						gillaDummy2 = gillaDummy4;
					}
				}
			}
			object obj32 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v39+E4]");
			bool flag26 = (nint)0 == 0;
			object obj33 = !flag26;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag27 = (UnityEngine.Object)gillaDummy2 == (UnityEngine.Object)null;
			bool flag28 = !flag27;
			object obj34 = !flag28;
			if (obj34 == null)
			{
				gillaDummy2.Blasted((Vector3)0, 0, apart: false);
				killCooldown = 1f;
			}
		}
		else
		{
			object obj35 = default;
			((NetworkApe)obj).RPC_Kill((RpcInfo)(&obj35));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj36 = 0;
			killCooldown = 1f;
			object obj37 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v19+E4]");
			bool flag29 = (nint)0 == 0;
			object obj38 = !flag29;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			Buzz((XRNode)4, 1f, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			Buzz((XRNode)5, 1f, 0f);
		}
	}

	private unsafe static NetworkApe Nearest(Vector3 at, float reach)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05fc: Expected I, but got Obj
		//IL_061e: Expected Obj, but got I4
		//IL_0747: Expected Obj, but got I
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected Obj, but got I
		//IL_0027: Expected I, but got Obj
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got I
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected F4, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got I4
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got I4
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected Ref, but got Unknown
		//IL_06ee: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_046b: Expected Obj, but got I4
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected Obj, but got Unknown
		//IL_04c0: Expected Obj, but got I4
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got I4
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got I4
		//IL_0594: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I4
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got I4
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got I
		//IL_0676: Expected Obj, but got I
		//IL_0698: Expected Obj, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected F4, but got Unknown
		//IL_0405: Expected Obj, but got I4
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected F4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		NetworkApe networkApe = (NetworkApe)0;
		nint num = (nint)networkApe;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2 (Il2CppClass<NetworkApe>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		nint num2 = num;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num2 = (nint)networkApe;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (Il2CppClass<NetworkApe>)+A0]");
		UnityEngine.Object obj2 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v7 (UnityEngine.Object)+8]");
		bool flag2 = (nint)0 == 0;
		UnityEngine.Object obj4 = default;
		UnityEngine.Object obj3 = obj4;
		Enumerator<, > val = (Enumerator<, >)0;
		IntPtr intPtr = default;
		UnityEngine.Object obj5 = (UnityEngine.Object)(nint)intPtr;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v7 (UnityEngine.Object)+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj9 = 0;
			object obj11 = default;
			object obj10 = obj11;
			object obj13 = default;
			object obj12 = obj13;
			UnityEngine.Object obj14 = null;
			Enumerator<, > val3 = default;
			Enumerator<, > val2 = val3;
			obj2 = obj4;
			float num4 = default;
			float num3 = num4;
			object obj15;
			object obj16;
			float num5;
			NetworkApe result = default;
			object obj35 = default;
			object obj20;
			object obj27;
			float num7 = default;
			Enumerator<, > val4;
			while (true)
			{
				obj15 = obj10;
				obj16 = obj12;
				num5 = (float)val2;
				while (true)
				{
					if (val.MoveNext())
					{
						object obj17 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v33+E4]");
						obj2 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v33+E4]");
						bool flag3 = (nint)0 == 0;
						object obj18 = !flag3;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag4 = obj4 == null;
						bool flag5 = !flag4;
						object obj19 = !flag5;
						obj20 = 0;
						if (obj19 != null)
						{
							continue;
						}
						if ((object)obj4 == null)
						{
							break;
						}
						bool isLocal = ((NetworkApe)obj4).IsLocal;
						bool flag6 = !isLocal;
						object obj21 = !flag6;
						obj20 = 0;
						if (obj21 != null)
						{
							continue;
						}
						bool isMonster = ((NetworkApe)obj4).IsMonster;
						bool flag7 = !isMonster;
						object obj22 = !flag7;
						obj20 = 0;
						if (obj22 != null)
						{
							continue;
						}
						bool busy = ((NetworkApe)obj4).Busy;
						bool flag8 = !busy;
						object obj23 = !flag8;
						obj20 = 0;
						if (obj23 != null)
						{
							continue;
						}
						object obj24 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v44+E4]");
						obj2 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v44+E4]");
						bool flag9 = (nint)0 == 0;
						object obj25 = !flag9;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ stack_-B8 (UnityEngine.Object)+68]");
						bool flag10 = (UnityEngine.Object)0 == null;
						bool flag11 = !flag10;
						object obj26 = !flag11;
						obj20 = 0;
						if (obj26 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ stack_-B8 (UnityEngine.Object)+68]");
						bool flag12 = (nint)0 == 0;
						obj20 = 0;
						obj3 = null;
						val = val3;
						obj27 = 0;
						val4 = (Enumerator<, >)(ref val);
						obj5 = null;
						networkApe = (NetworkApe)obj14;
						if (!flag12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ stack_-B8 (UnityEngine.Object)+68]");
							Vector3 position = ((Transform)0).position;
							object obj28 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v51+E4]");
							obj2 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v51+E4]");
							bool flag13 = (nint)0 == 0;
							object obj29 = !flag13;
							if (obj29 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num6 = num5 - num7;
							object obj30 = obj16 - obj13;
							obj15 -= obj11;
							float num8 = num6 * num6;
							object obj31 = obj30 * obj30;
							float num9 = num8 + (float)obj31;
							obj16 = obj15 * obj15;
							val2 = (Enumerator<, >)(obj16 + num9);
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							bool flag14 = !(num5 < num3);
							obj20 = 0;
							num5 = (float)val2;
							if (!flag14)
							{
								goto IL_03ec;
							}
							continue;
						}
						goto IL_053b;
					}
					obj3 = null;
					val = val3;
					obj27 = 0;
					val4 = (Enumerator<, >)(ref val);
					networkApe = (NetworkApe)obj14;
					object obj32 = 0;
					goto IL_06c3;
					IL_06c3:
					obj5 = (UnityEngine.Object)obj8;
					((Enumerator<, >*)val4)->Dispose();
					bool flag15 = obj32 == null;
					object obj33 = !flag15;
					obj11 = obj15;
					obj13 = obj16;
					num7 = num5;
					if (obj33 == null)
					{
						bool flag16 = (object)obj3 == null;
						object obj34 = !flag16;
						obj11 = obj15;
						obj13 = obj16;
						num7 = num5;
						OutOfMemoryException ex = (OutOfMemoryException)val4;
						if (obj34 == null)
						{
							return networkApe;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					obj15 = obj11;
					obj16 = obj13;
					num5 = num7;
					goto IL_053b;
					IL_053b:
					NullReferenceException ex2 = new NullReferenceException();
					if ((nint)obj5 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj3 = (UnityEngine.Object)1;
						obj2 = (UnityEngine.Object)1;
						obj32 = obj27;
					}
					else
					{
						if ((nint)obj5 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return result;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj32 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj27 = obj35;
					}
					goto IL_06c3;
				}
				break;
				IL_03ec:
				obj10 = obj15;
				obj12 = obj16;
				obj20 = 0;
				obj14 = obj4;
				num3 = (float)val2;
			}
			NullReferenceException ex3 = new NullReferenceException();
			obj11 = obj15;
			obj13 = obj16;
			obj20 = 0;
			obj3 = null;
			val = val3;
			obj27 = 0;
			num7 = num5;
			val4 = (Enumerator<, >)(ref val);
			obj5 = null;
			networkApe = (NetworkApe)obj14;
		}
		throw new NullReferenceException();
	}

	private static bool CanTouch(NetworkApe a)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_057c: Expected I4, but got Obj
		//IL_009e: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_0310: Expected Obj, but got I4
		//IL_0319: Expected VT, but got I4
		//IL_03a8: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_0470: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I4
		//IL_038a: Expected Obj, but got I4
		//IL_0504: Invalid comparison between F4 and I4
		//IL_051c: Expected Obj, but got F8
		//IL_0529: Expected Obj, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)a == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			if ((object)a == null)
			{
				goto IL_056e;
			}
			bool isLocal = a.IsLocal;
			bool flag4 = !isLocal;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				bool isMonster = a.IsMonster;
				bool flag5 = !isMonster;
				object obj6 = !flag5;
				if (obj6 == null)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v15+E4]");
					bool flag6 = (nint)0 == 0;
					object obj8 = !flag6;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!(a.head == null))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
						object obj9 = 0;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v19+E4]");
						bool flag7 = (nint)0 == 0;
						object obj11 = !flag7;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaModeRound current = GillaModeRound.Current;
						object obj12 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v11+E4]");
						bool flag8 = (nint)0 == 0;
						object obj13 = !flag8;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag9 = a.drawn != null;
						bool flag10 = !flag9;
						UnityEngine.Object obj14 = null;
						if (!flag10)
						{
							if ((object)a.drawn == null)
							{
								goto IL_056e;
							}
							bool inHand = a.drawn.InHand;
							bool flag11 = !inHand;
							object obj15 = !flag11;
							obj14 = null;
							if (obj15 != null)
							{
								goto IL_0158;
							}
						}
						object obj16 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v27+E4]");
						bool flag12 = (nint)0 == 0;
						object obj17 = !flag12;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag13 = (UnityEngine.Object)current != (UnityEngine.Object)null;
						bool flag14 = !flag13;
						object obj18 = 0;
						PlayerRef playerRef = (PlayerRef)0;
						if (!flag14)
						{
							if ((object)current == null)
							{
								goto IL_056e;
							}
							playerRef = a.ownerRef;
							bool flag15 = current.IsOut(a.ownerRef);
							bool flag16 = !flag15;
							object obj19 = !flag16;
							obj18 = 0;
							if (obj19 != null)
							{
								goto IL_0158;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
						object obj20 = 0;
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v32+E4]");
						bool flag17 = (nint)0 == 0;
						object obj22 = !flag17;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaCorpse gillaCorpse = GillaCorpse.Find(a.owner);
						object obj23 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v16+E4]");
						bool flag18 = (nint)0 == 0;
						object obj24 = !flag18;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag19 = gillaCorpse == null;
						bool flag20 = !flag19;
						object obj25 = !flag20;
						if (obj25 == null)
						{
							if ((object)gillaCorpse == null)
							{
								goto IL_056e;
							}
							if (gillaCorpse.Has(0))
							{
								float time = Time.time;
								float num = time - gillaCorpse.MadeAt__BackingField;
								float num2 = num - 3f;
								bool flag21 = num2 < 0f;
								object obj26 = (double)num ^ 3.0;
								object obj27 = num ^ num2;
								object obj28 = obj26 & obj27;
								bool flag22 = (nint)obj28 < 0;
								return flag21 == flag22;
							}
						}
						return true;
					}
				}
			}
		}
		goto IL_0158;
		IL_0158:
		return false;
		IL_056e:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe static NetworkApe OnSomeone(List<Vector3> touching, float touch)
	{
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected Obj, but got I
		//IL_0785: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_07ab: Expected Obj, but got I
		//IL_07cd: Expected Obj, but got I4
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Expected Obj, but got Unknown
		//IL_098c: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I
		//IL_0236: Expected I, but got Obj
		//IL_0258: Expected Obj, but got I4
		//IL_0828: Expected Obj, but got I
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got I4
		//IL_0280: Expected I, but got Obj
		//IL_0297: Expected Obj, but got I
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I
		//IL_02c4: Expected F4, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected F4, but got Unknown
		//IL_0805: Expected Obj, but got I4
		//IL_09aa: Expected Obj, but got I
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got I4
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got I4
		//IL_08ee: Expected Obj, but got I
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected Ref, but got Unknown
		//IL_0919: Expected Obj, but got I4
		//IL_0301: Expected Obj, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got I
		//IL_01b3: Expected Obj, but got I
		//IL_01e0: Expected VT, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_06eb: Expected Obj, but got I4
		//IL_0672: Expected Obj, but got I4
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got I4
		//IL_050e: Expected Obj, but got I4
		//IL_056f: Invalid comparison between F4 and I4
		//IL_0582: Expected Obj, but got I4
		//IL_059c: Expected Obj, but got I4
		//IL_08a5: Expected Obj, but got I4
		bool flag = touching == null;
		NetworkApe networkApe2 = default;
		NetworkApe networkApe = networkApe2;
		Enumerator<, > val = (Enumerator<, >)0;
		float num2 = default;
		float num = num2;
		IntPtr intPtr = default;
		UnityEngine.Object obj = (UnityEngine.Object)(nint)intPtr;
		UnityEngine.Object obj2 = (UnityEngine.Object)109895680;
		object obj3;
		NetworkApe result;
		Enumerator<, > val2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [touching @ X0 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			if ((nint)0 == 0)
			{
				goto IL_0643;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v28+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj3;
			}
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v28+A0]");
			val2 = (Enumerator<, >)0;
			obj2 = (UnityEngine.Object)val2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v17+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = obj2 != null;
			bool flag6 = !flag5;
			Transform transform = null;
			obj = null;
			if (flag6)
			{
				goto IL_021e;
			}
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v66+E4]");
			bool flag7 = (nint)0 == 0;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v70+E4]");
			bool flag8 = (nint)0 == 0;
			object obj14 = !flag8;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v70+A0]");
			object obj15 = 0;
			object obj16 = obj15;
			bool flag9 = obj15 == null;
			networkApe = networkApe2;
			val = (Enumerator<, >)0;
			num = num2;
			transform = null;
			obj = null;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v35+A8]");
				bool flag10 = (nint)0 == 0;
				networkApe = networkApe2;
				val = (Enumerator<, >)0;
				num = num2;
				transform = null;
				obj = null;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v35+A8]");
					Vector3 position = ((Transform)0).position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
					object obj17 = 0;
					transform = (Transform)obj17;
					Vector3 vector = touching.get_Item(0);
					bool flag11 = Walled(vector, (Vector3)0);
					bool flag12 = !flag11;
					object obj18 = !flag12;
					float num3 = num2;
					obj = null;
					result = null;
					if (obj18 == null)
					{
						goto IL_021e;
					}
					goto IL_0813;
				}
			}
		}
		goto IL_0690;
		IL_0690:
		throw new NullReferenceException();
		IL_021e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		obj2 = (UnityEngine.Object)0;
		nint num4 = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v33 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag13 = (nint)0 == 0;
		object obj19 = !flag13;
		nint num5 = num4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num5 = (nint)obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v34 (Il2CppClass<UnityEngine.Object>)+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v20+8]");
		bool flag14 = (nint)0 == 0;
		networkApe = networkApe2;
		val = (Enumerator<, >)0;
		num = num2;
		if (flag14)
		{
			goto IL_0690;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v20+8]");
		Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
		object obj22 = 0;
		float num6 = 2.139095E+09f;
		Enumerator<, > val3 = default;
		num = (float)val3;
		obj2 = null;
		object obj27 = default;
		object obj28 = default;
		object obj37;
		Enumerator<, > val4;
		while (true)
		{
			obj = (UnityEngine.Object)obj21;
			if (!val.MoveNext())
			{
				break;
			}
			object obj23 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v40+E4]");
			bool flag15 = (nint)0 == 0;
			object obj24 = !flag15;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!CanTouch(networkApe2))
			{
				continue;
			}
			if ((object)networkApe2 != null)
			{
				bool busy = networkApe2.Busy;
				bool flag16 = !busy;
				obj = null;
				if (!flag16)
				{
					bool letGoHere = networkApe2.LetGoHere;
					bool flag17 = !letGoHere;
					object obj25 = !flag17;
					obj = null;
					if (obj25 == null)
					{
						bool downHere = networkApe2.DownHere;
						bool flag18 = !downHere;
						obj = null;
						if (flag18)
						{
							continue;
						}
					}
				}
				if ((object)networkApe2.head != null)
				{
					Vector3 position2 = networkApe2.head.position;
					Transform transform = (Transform)obj22;
					Vector3 vector2 = touching.get_Item(0);
					float num7 = num - num;
					object obj26 = obj27 - obj27;
					obj28 -= obj28;
					float num8 = num7 * num7;
					object obj29 = obj26 * obj26;
					num = num8 + (float)obj29;
					obj27 = obj28 * obj28;
					float num3 = (float)obj27 + num;
					if (!((double)num3 > 6.25))
					{
						object obj30 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v54+E4]");
						bool flag19 = (nint)0 == 0;
						object obj31 = !flag19;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag20 = OnBody(networkApe2.tearing, networkApe2.leftHand, networkApe2.rightHand, touching, num2);
						float num9 = num3 - num6;
						bool flag21 = num9 < 0f;
						object obj32 = flag20 & flag21;
						bool flag22 = obj32 == null;
						object obj33 = !flag22;
						object obj34 = ~obj33;
						if (obj34 == null)
						{
							num6 = num3;
						}
						object obj35 = !flag22;
						object obj36 = ~obj35;
						NetworkApe networkApe3 = (NetworkApe)((obj36 != null) ? obj2 : networkApe2);
						num = num2;
						transform = networkApe2.rightHand;
						obj2 = networkApe3;
					}
					continue;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			networkApe = null;
			obj37 = 0;
			val = val3;
			val2 = (Enumerator<, >)(ref val);
			val4 = (Enumerator<, >)(ref val);
			goto IL_0690;
		}
		networkApe = null;
		obj37 = 0;
		val = val3;
		val2 = (Enumerator<, >)(ref val);
		val4 = (Enumerator<, >)(ref val);
		object obj38 = 0;
		object obj41 = default;
		NetworkApe result2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			object obj39 = 0;
			obj = (UnityEngine.Object)obj39;
			((Enumerator<, >*)val4)->Dispose();
			bool flag23 = obj38 == null;
			object obj40 = !flag23;
			if (obj40 == null)
			{
				break;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			if ((nint)obj == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				networkApe = (NetworkApe)1;
				obj38 = obj37;
				continue;
			}
			if ((nint)obj == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj38 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj37 = obj41;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return result2;
		}
		bool flag24 = (object)networkApe == null;
		result = (NetworkApe)obj2;
		if (!flag24)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0643;
		}
		goto IL_0813;
		IL_0643:
		result = null;
		goto IL_0813;
		IL_0813:
		return result;
	}

	private unsafe static bool OnBody(Dismemberment body, Transform left, Transform right, List<Vector3> touching, float touch)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected F4, but got I4
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got I
		//IL_005d: Expected F4, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got I4
		//IL_045d: Expected Obj, but got I4
		//IL_0c00: Expected Obj, but got I
		//IL_0c2b: Expected Obj, but got I4
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Expected Obj, but got I4
		//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got I4
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got I4
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Ref
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected F4, but got Unknown
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected Obj, but got I4
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Expected Obj, but got I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Invalid comparison between Unknown and F4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected Obj, but got I4
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I4
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Invalid comparison between F4 and I4
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Invalid comparison between Unknown and F4
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE2EB]");
		Enumerator<, > val = (Enumerator<, >)0;
		List<Vector3> list = default;
		bool flag = list == null;
		float num = 0f;
		Enumerator<, > val3 = default;
		Enumerator<, > val2 = val3;
		Enumerator<, > val4 = (Enumerator<, >)0;
		Enumerator<, > val5 = (Enumerator<, >)0;
		Transform transform2 = default;
		Transform transform = transform2;
		bool flag2 = false;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A38]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Enumerator<, > enumerator = list.GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj3 = 0;
			num = 0f;
			Transform transform4 = default;
			Transform transform3 = transform4;
			Enumerator<, > val6 = val3;
			Enumerator<, > val7 = default;
			val5 = val7;
			val = (Enumerator<, >)(ref val4);
			float num3 = default;
			float num4 = default;
			float num5 = default;
			object obj8 = default;
			object obj9 = default;
			while (true)
			{
				bool flag3 = val4.MoveNext();
				UnityEngine.Object obj7;
				Enumerator<, > val8;
				Transform transform5;
				Enumerator<, > val9;
				Enumerator<, > val10;
				if (flag3)
				{
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v67+E4]");
					val = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v67+E4]");
					bool flag4 = (nint)0 == 0;
					object obj5 = !flag4;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag5 = transform2 != null;
					bool flag6 = !flag5;
					UnityEngine.Object obj6 = null;
					if (!flag6)
					{
						if ((object)transform2 == null)
						{
							NullReferenceException ex = new NullReferenceException();
							transform3 = null;
							obj7 = null;
							goto IL_0974;
						}
						Vector3 position = transform2.position;
						float num2 = (float)val5 - (float)val3;
						num3 = (float)val6 - num4;
						num5 = (float)obj8 - (float)obj9;
						object obj10 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v92+E4]");
						val8 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v92+E4]");
						bool flag7 = (nint)0 == 0;
						object obj11 = !flag7;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num6 = num2 * num2;
						float num7 = num3 * num3;
						float num8 = num6 + num7;
						val6 = (Enumerator<, >)(num5 * num5);
						val5 = (Enumerator<, >)(num8 + val6);
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						float num9 = (float)val5 - touch;
						bool flag8 = (float)val5 < touch;
						num = num2;
						float num10 = num2;
						obj6 = null;
						num = num2;
						transform5 = null;
						val9 = val6;
						val10 = val5;
						if (flag8)
						{
							goto IL_0414;
						}
					}
					object obj12 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v75+E4]");
					val = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v75+E4]");
					bool flag9 = (nint)0 == 0;
					object obj13 = !flag9;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag10 = transform4 != null;
					bool flag11 = !flag10;
					transform3 = null;
					float num11 = num4;
					float num12 = (float)val3;
					if (flag11)
					{
						continue;
					}
					bool flag12 = (object)transform4 == null;
					transform3 = null;
					obj7 = null;
					if (!flag12)
					{
						Vector3 position2 = transform4.position;
						num12 = (float)val5 - (float)val3;
						float num10 = (float)val6 - num4;
						num11 = (float)obj8 - (float)obj9;
						object obj14 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ X0_v82+E4]");
						val8 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ X0_v82+E4]");
						bool flag13 = (nint)0 == 0;
						object obj15 = !flag13;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num13 = num12 * num12;
						float num14 = num10 * num10;
						float num15 = num13 + num14;
						val9 = (Enumerator<, >)(num11 * num11);
						val10 = (Enumerator<, >)(num15 + val9);
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						float num9 = (float)val10 - touch;
						bool flag8 = num9 < 0f;
						bool flag14 = !((float)val10 < touch);
						num = num12;
						num5 = num5;
						num3 = num3;
						float num2 = num10;
						transform5 = null;
						num = num12;
						transform3 = null;
						val6 = val9;
						val5 = val10;
						val = val8;
						if (flag14)
						{
							continue;
						}
						goto IL_0414;
					}
					goto IL_0974;
				}
				transform = (Transform)6;
				object obj16 = 0;
				goto IL_0bf0;
				IL_0bf0:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A20]");
				object obj17 = 0;
				transform2 = (Transform)obj17;
				val4.Dispose();
				bool flag15 = obj16 == null;
				object obj18 = !flag15;
				transform4 = transform3;
				val2 = (Enumerator<, >)0;
				val4 = val7;
				object obj19 = 0;
				Enumerator<, > val11 = (Enumerator<, >)(ref val4);
				flag2 = flag3;
				NullReferenceException ex2;
				if (obj18 == null)
				{
					val2 = (Enumerator<, >)0;
					val4 = val7;
					obj19 = 0;
					val11 = (Enumerator<, >)(ref val4);
					ex2 = (NullReferenceException)(&val4);
					val = (Enumerator<, >)0;
					flag2 = flag3;
					break;
				}
				throw new OutOfMemoryException();
				IL_0414:
				transform3 = transform5;
				val6 = val9;
				val5 = val10;
				transform = (Transform)5;
				obj16 = 0;
				val = val8;
				goto IL_0bf0;
				IL_0974:
				NullReferenceException ex3 = new NullReferenceException();
				val2 = (Enumerator<, >)0;
				val4 = val7;
				obj19 = 0;
				Transform transform6 = (Transform)obj7;
				val11 = (Enumerator<, >)(ref val4);
				ex2 = new NullReferenceException();
				transform2 = transform6;
				flag2 = flag3;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			transform4 = transform3;
		}
		throw new NullReferenceException();
	}

	private void HandPoints(bool right, List<Vector3> into)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0033: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I4
		//IL_0519: Expected Obj, but got I
		//IL_052e: Expected VT, but got I
		//IL_02b1: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I
		//IL_0323: Expected VT, but got I
		//IL_0338: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_0389: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I
		//IL_040a: Expected Obj, but got I
		//IL_041f: Expected VT, but got I
		//IL_0434: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I
		//IL_03d0: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I4
		//IL_04e1: Expected Obj, but got I
		//IL_04a9: Expected Obj, but got I
		//IL_04cc: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
		object obj3 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
		object obj5 = 0;
		if (worn != null && worn.Hand(right, out var _, out var _, out var _))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			object obj6 = 0;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
			object obj8 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v14+18]");
			bool flag2 = num < 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj10 = (nint)0 * (nint)12;
				object obj11 = obj6 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj12 = (nint)0 + (nint)1;
				_ = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X10_v8+20]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v24+A8]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v25+70]");
				into.AddWithResize((Vector3)0);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			object obj15 = 0;
			object obj16 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
			object obj17 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v16+18]");
			bool flag3 = num2 < 0;
			object obj18 = !flag3;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj19 = (nint)0 * (nint)12;
				object obj20 = obj15 + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj21 = (nint)0 + (nint)1;
				_ = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v10+20]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v21+A8]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v22+70]");
				into.AddWithResize((Vector3)0);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			object obj24 = 0;
			object obj25 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
			object obj26 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v18+18]");
			bool flag4 = num3 < 0;
			object obj27 = !flag4;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj28 = (nint)0 * (nint)12;
				object obj29 = obj24 + obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj30 = (nint)0 + (nint)1;
				goto IL_04ef;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v12+20]");
			object obj31 = 0;
		}
		else
		{
			Transform transform;
			if (right)
			{
				transform = rightFollower;
				bool flag5 = (object)rightFollower == null;
				object obj32 = !flag5;
				if (obj32 == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				transform = leftFollower;
			}
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			object obj33 = 0;
			object obj34 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
			object obj35 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v11+18]");
			bool flag6 = num4 < 0;
			object obj36 = !flag6;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj37 = (nint)0 * (nint)12;
				object obj29 = obj33 + obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj30 = (nint)0 + (nint)1;
				goto IL_04ef;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v7+20]");
			object obj31 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v7+A8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v8+70]");
		into.AddWithResize((Vector3)0);
		return;
		IL_04ef:
		_ = 0;
	}

	public float TouchFrom(Component body, bool right)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
		object obj = 0;
		HandPoints(right, touching);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return GillaSkin.Nearest(body, touching);
	}

	public bool WouldTakeHold(Dismemberment body, Transform left, Transform right, bool rightHand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I4
		//IL_034d: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_026d: Expected I4, but got Obj
		//IL_00ad: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I4
		//IL_0327: Expected Obj, but got I4
		//IL_038d: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_0179: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		HandPoints(rightHand, touching);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 != null;
		bool flag5 = !flag4;
		object obj10 = 0;
		if (flag5)
		{
			goto IL_01a5;
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v22+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v26+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v26+A0]");
		object obj15 = 0;
		object obj16 = obj15;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v17+A8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v17+A8]");
				Vector3 position = ((Transform)0).position;
				if (touching != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
					object obj17 = 0;
					obj10 = obj17;
					Vector3 vector = touching.get_Item(0);
					if (Walled(vector, (Vector3)0))
					{
						return false;
					}
					goto IL_01a5;
				}
			}
		}
		goto IL_025f;
		IL_025f:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_01a5:
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Vector3 localScale = transform.localScale;
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v17+E4]");
			bool flag8 = (nint)0 == 0;
			object obj19 = !flag8;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj20 = default;
			float touch = skinTouch * (float)obj20;
			return OnBody(body, left, right, touching, touch);
		}
		goto IL_025f;
	}

	private unsafe static NetworkApe NearestBody(Vector3 at, float reach)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1430: Expected Obj, but got I4
		//IL_1456: Expected Obj, but got I
		//IL_1478: Expected Obj, but got I4
		//IL_18cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18db: Expected Obj, but got Unknown
		//IL_18fd: Expected Obj, but got I4
		//IL_007d: Expected VT, but got I4
		//IL_01cd: Expected Obj, but got I
		//IL_01d5: Expected I, but got Obj
		//IL_01f7: Expected Obj, but got I4
		//IL_14d3: Expected Obj, but got I
		//IL_14f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1505: Expected Obj, but got I4
		//IL_150d: Expected Obj, but got VT
		//IL_00b5: Expected Obj, but got I4
		//IL_021f: Expected I, but got Obj
		//IL_0235: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got I
		//IL_027f: Expected F4, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_14b0: Expected Obj, but got I4
		//IL_152b: Expected VT, but got Obj
		//IL_191b: Expected Obj, but got I
		//IL_193f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1955: Expected Obj, but got I4
		//IL_118d: Expected Obj, but got I4
		//IL_118d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1191: Unknown result type (might be due to invalid IL or missing references)
		//IL_119b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Expected Obj, but got I4
		//IL_1857: Expected Obj, but got I
		//IL_185f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1868: Expected Ref, but got Unknown
		//IL_1882: Expected Obj, but got I4
		//IL_02bf: Expected Obj, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got I4
		//IL_11cf: Expected Obj, but got I4
		//IL_11d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11df: Expected Obj, but got Unknown
		//IL_0154: Expected Obj, but got I
		//IL_0166: Expected VT, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_01aa: Expected VT, but got I4
		//IL_0348: Expected VT, but got I4
		//IL_139e: Expected Obj, but got I4
		//IL_037d: Expected Obj, but got I4
		//IL_0386: Expected VT, but got I4
		//IL_0403: Expected VT, but got Obj
		//IL_0425: Expected Obj, but got I4
		//IL_1288: Expected VT, but got I4
		//IL_03b9: Expected VT, but got I4
		//IL_199a: Expected Obj, but got I4
		//IL_049a: Invalid comparison between F4 and I4
		//IL_04a9: Invalid comparison between F4 and I4
		//IL_04bc: Expected Obj, but got F4
		//IL_04c9: Expected Obj, but got F4
		//IL_04fe: Expected Obj, but got I4
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_12e7: Expected Obj, but got I4
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Invalid comparison between F4 and I4
		//IL_157c: Expected Obj, but got I4
		//IL_0622: Expected F4, but got I4
		//IL_0671: Expected F4, but got I4
		//IL_159a: Expected Obj, but got I
		//IL_15dc: Expected Obj, but got I4
		//IL_15e5: Expected VT, but got I4
		//IL_06bc: Expected F4, but got I4
		//IL_06dd: Expected Obj, but got I4
		//IL_0acc: Expected VT, but got I4
		//IL_0b92: Expected Obj, but got I4
		//IL_0722: Expected F4, but got I4
		//IL_0ae2: Expected I, but got Obj
		//IL_0af2: Expected VT, but got I
		//IL_0b34: Expected Obj, but got I4
		//IL_0b44: Expected VT, but got I
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected Obj, but got Unknown
		//IL_0bf1: Expected VT, but got Obj
		//IL_076d: Expected F4, but got I4
		//IL_078e: Expected Obj, but got I4
		//IL_0c9e: Expected Obj, but got I8
		//IL_0cde: Expected Obj, but got I4
		//IL_0c07: Expected I, but got Obj
		//IL_0c17: Expected VT, but got I
		//IL_0c66: Expected Obj, but got I4
		//IL_0c76: Expected VT, but got I
		//IL_0cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfa: Expected Obj, but got Unknown
		//IL_0d2c: Expected Obj, but got I4
		//IL_0d34: Expected VT, but got Obj
		//IL_161d: Expected Obj, but got I4
		//IL_086a: Invalid comparison between F4 and I4
		//IL_0d5c: Expected Obj, but got I8
		//IL_0d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected Obj, but got Unknown
		//IL_0dbb: Expected Obj, but got I4
		//IL_0dc3: Expected VT, but got Obj
		//IL_164d: Expected F4, but got I4
		//IL_165e: Expected F4, but got I4
		//IL_10ca: Expected VT, but got Obj
		//IL_10ec: Expected Obj, but got I4
		//IL_19c1: Expected Obj, but got I4
		//IL_088a: Expected F4, but got I4
		//IL_1134: Expected Obj, but got I4
		//IL_08b4: Expected F4, but got I4
		//IL_08bd: Expected F4, but got I4
		//IL_08e3: Expected Obj, but got I4
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected Obj, but got I4
		//IL_0de5: Expected Obj, but got I
		//IL_0e07: Expected Obj, but got I4
		//IL_17e3: Expected Obj, but got I4
		//IL_17ec: Expected I4, but got Obj
		//IL_0e4c: Expected Obj, but got I4
		//IL_0e55: Expected VT, but got I4
		//IL_16cc: Expected Obj, but got I
		//IL_16d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16da: Expected Obj, but got Unknown
		//IL_1741: Expected Obj, but got I4
		//IL_174a: Expected Obj, but got I4
		//IL_16ae: Expected Obj, but got I4
		//IL_0e7b: Expected Obj, but got I4
		//IL_0e84: Expected VT, but got I4
		//IL_09ea: Invalid comparison between F4 and I4
		//IL_0a63: Expected F4, but got I4
		//IL_0a74: Expected F4, but got I4
		//IL_0a7d: Expected F4, but got I4
		//IL_0a12: Expected F4, but got I4
		//IL_0a1b: Expected F4, but got I4
		//IL_0a24: Expected F4, but got I4
		//IL_0a2d: Expected F4, but got I4
		//IL_1792: Expected Obj, but got I4
		//IL_0f7f: Expected VT, but got I4
		//IL_17ca: Expected Obj, but got I4
		//IL_1076: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v6+A0]");
		Enumerator<, > val = (Enumerator<, >)0;
		UnityEngine.Object obj8 = (UnityEngine.Object)val;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = obj8 != null;
		bool flag5 = !flag4;
		float num2 = default;
		float num = num2;
		Vector3 vector = (Vector3)0;
		if (flag5)
		{
			goto IL_01bd;
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v159+E4]");
		bool flag6 = (nint)0 == 0;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v163+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v163+A0]");
		object obj14 = 0;
		object obj15 = obj14;
		bool flag8 = obj14 == null;
		NetworkApe networkApe2 = default;
		NetworkApe networkApe = networkApe2;
		Enumerator<, > val2 = (Enumerator<, >)0;
		num = num2;
		object obj16 = 0;
		UnityEngine.Object obj17 = null;
		float num3 = num2;
		float num5 = default;
		float num6 = default;
		float num8 = default;
		NetworkApe result;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v78+A8]");
			bool flag9 = (nint)0 == 0;
			networkApe = networkApe2;
			val2 = (Enumerator<, >)0;
			num = num2;
			obj16 = 0;
			obj17 = null;
			num3 = num2;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v78+A8]");
				Vector3 position = ((Transform)0).position;
				bool flag10 = Walled(position, (Vector3)0);
				bool flag11 = !flag10;
				object obj18 = !flag11;
				float num4 = num5;
				num = num6;
				float num7 = num8;
				vector = (Vector3)0;
				result = null;
				if (obj18 == null)
				{
					goto IL_01bd;
				}
				goto IL_14be;
			}
		}
		goto IL_1306;
		IL_132c:
		throw new NullReferenceException();
		IL_1306:
		NullReferenceException ex = new NullReferenceException();
		float num10 = default;
		float num9 = num10;
		float num12 = default;
		float num11 = num12;
		float num14 = default;
		float num13 = num14;
		goto IL_132c;
		IL_14be:
		return result;
		IL_01bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		obj8 = (UnityEngine.Object)0;
		nint num15 = (nint)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v35 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag12 = (nint)0 == 0;
		object obj19 = !flag12;
		nint num16 = num15;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num16 = (nint)obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v36 (Il2CppClass<UnityEngine.Object>)+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v21+8]");
		bool flag13 = (nint)0 == 0;
		networkApe = networkApe2;
		val2 = (Enumerator<, >)0;
		obj16 = 0;
		obj17 = (UnityEngine.Object)vector;
		num3 = num2;
		if (flag13)
		{
			goto IL_1306;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v21+8]");
		Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj22 = 0;
		float num17 = num5;
		num11 = num8;
		NetworkApe networkApe3 = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
		num13 = 0f;
		obj16 = 0;
		num3 = num2;
		float num44 = default;
		float num45 = default;
		Enumerator<, > val3 = default;
		UnityEngine.Object obj43 = default;
		IndexOutOfRangeException ex2 = default;
		ArgumentNullException ex3 = default;
		object obj39;
		Enumerator<, > val4;
		while (true)
		{
			Vector3 vector2 = (Vector3)obj21;
			if (!val2.MoveNext())
			{
				break;
			}
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X0_v42+E4]");
			bool flag14 = (nint)0 == 0;
			object obj24 = !flag14;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!CanTouch(networkApe2))
			{
				continue;
			}
			if ((object)networkApe2 == null)
			{
				goto IL_1226;
			}
			bool busy = networkApe2.Busy;
			bool flag15 = !busy;
			vector2 = (Vector3)0;
			if (!flag15)
			{
				bool letGoHere = networkApe2.LetGoHere;
				bool flag16 = !letGoHere;
				object obj25 = !flag16;
				vector2 = (Vector3)0;
				if (obj25 == null)
				{
					bool downHere = networkApe2.DownHere;
					bool flag17 = !downHere;
					vector2 = (Vector3)0;
					if (flag17)
					{
						continue;
					}
				}
			}
			if ((object)networkApe2.head == null)
			{
				goto IL_1234;
			}
			Vector3 position2 = networkApe2.head.position;
			Vector3 vector3 = (Vector3)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X0_v72 (UnityEngine.Vector3)+E4]");
			bool flag18 = (nint)0 == 0;
			object obj26 = !flag18;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 vector4 = FloorUnder(vector3);
			float num18 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			float num19 = num18 + 0f;
			if (!(num8 < num19))
			{
				float num20 = num8 - num11;
				bool flag19 = num20 < 0f;
				bool flag20 = num20 == 0f;
				object obj27 = num8 ^ num11;
				object obj28 = num8 ^ num20;
				object obj29 = obj27 & obj28;
				bool flag21 = (nint)obj29 < 0;
				bool flag22 = flag19 == flag21;
				object obj30 = !flag22;
				object obj31 = obj30 | flag20;
				object obj32 = ~obj31;
				num19 = ((obj32 != null) ? num11 : num8);
			}
			object obj33 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X0_v75+E4]");
			bool flag23 = (nint)0 == 0;
			object obj34 = !flag23;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num21 = num8 - num19;
			object obj35 = obj5;
			UnityEngine.Object limp = networkApe2.limp;
			float num22 = num6 - num13;
			num10 = num5 - num17;
			float num23 = num21 * num21;
			float num24 = num22 * num22;
			float num25 = num24 + num23;
			float num26 = num10 * num10;
			float num27 = num26 + num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num28 = num27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
			num14 = num28 + 0f;
			float num29 = ((!(num14 < 0f)) ? num14 : 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X0_v77+E4]");
			bool flag24 = (nint)0 == 0;
			object obj36 = !flag24;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag25 = limp != null;
			bool flag26 = !flag25;
			float num30 = num10;
			float num31 = 0f;
			float num32 = num17;
			float num33 = num11;
			float num34 = num13;
			float num35 = num14;
			if (!flag26)
			{
				bool flag27 = (object)networkApe2.limp == null;
				num12 = 0f;
				num32 = num17;
				num33 = num11;
				num34 = num13;
				obj16 = 0;
				obj17 = null;
				if (flag27)
				{
					goto IL_12c2;
				}
				bool isDown = networkApe2.limp.IsDown;
				bool flag28 = !isDown;
				num30 = num10;
				num31 = 0f;
				num32 = num17;
				num33 = num11;
				num34 = num13;
				num35 = num14;
				if (!flag28)
				{
					bool flag29 = (object)networkApe2.limp == null;
					num12 = 0f;
					num32 = num17;
					num33 = num11;
					num34 = num13;
					obj16 = 0;
					obj17 = null;
					if (flag29)
					{
						goto IL_12d0;
					}
					Vector3 middle = networkApe2.limp.Middle;
					object obj37 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ X0_v134+E4]");
					bool flag30 = (nint)0 == 0;
					object obj38 = !flag30;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num36 = 0f - num8;
					float num37 = num14 - num6;
					num9 = num10 - num5;
					float num38 = num36 * num36;
					float num39 = num37 * num37;
					float num40 = num39 + num38;
					float num41 = num9 * num9;
					float num42 = num41 + num40;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num43 = num42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
					num35 = num43 + 0f;
					if (num35 < 0f)
					{
						num35 = 0f;
					}
					bool flag31 = !(num35 < num29);
					num44 = num10;
					num45 = 0f;
					num30 = num9;
					num31 = 0f;
					num32 = num17;
					num33 = num14;
					num34 = num13;
					if (!flag31)
					{
						bool flag32 = (object)networkApe2.limp == null;
						num44 = num10;
						num45 = 0f;
						num11 = 0f;
						num32 = num17;
						num33 = num14;
						num34 = num13;
						networkApe = null;
						obj39 = 0;
						val2 = val3;
						val = (Enumerator<, >)(ref val2);
						num13 = num35;
						val4 = (Enumerator<, >)(ref val2);
						obj16 = 0;
						obj17 = null;
						if (flag32)
						{
							goto IL_132c;
						}
						Vector3 middle2 = networkApe2.limp.Middle;
						object obj40 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1410 @ X0_v139+E4]");
						bool flag33 = (nint)0 == 0;
						object obj41 = !flag33;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num46 = 0f - num8;
						float num47 = num35 - num6;
						num30 = num9 - num5;
						float num48 = num46 * num46;
						float num49 = num47 * num47;
						float num50 = num49 + num48;
						float num51 = num30 * num30;
						float num52 = num51 + num50;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						float num53 = num52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
						float num54 = num53 + 0f;
						if (num54 < 0f)
						{
							num44 = num10;
							num45 = 0f;
							num29 = 0f;
							num19 = 0f;
							num31 = 0f;
							num32 = num9;
							num33 = num14;
							num34 = num35;
							num35 = num54;
						}
						else
						{
							num44 = num10;
							num45 = 0f;
							num29 = num54;
							num19 = 0f;
							num31 = 0f;
							num32 = num9;
							num33 = num14;
							num34 = num35;
							num35 = num54;
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag34 = (object)obj43 == null;
			limp = obj43;
			num17 = num30;
			num11 = num31;
			num13 = num35;
			obj16 = 0;
			vector2 = (Vector3)2;
			if (flag34)
			{
				goto IL_1242;
			}
			UnityEngine.Object leftHand = networkApe2.leftHand;
			bool flag35 = (object)networkApe2.leftHand == null;
			Vector3 vector5 = (Vector3)2;
			if (!flag35)
			{
				nint num55 = (nint)obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ X8_v68 (Il2CppClass<UnityEngine.Object>)+40]");
				vector5 = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag36 = ex2 == null;
				limp = obj43;
				num17 = num30;
				num11 = num31;
				num13 = num35;
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ X8_v68 (Il2CppClass<UnityEngine.Object>)+40]");
				vector2 = (Vector3)0;
				if (flag36)
				{
					goto IL_126c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X0_v83 (UnityEngine.Object)+18]");
			bool flag37 = (nint)0 == 0;
			limp = obj43;
			num17 = num30;
			num11 = num31;
			num13 = num35;
			obj16 = 0;
			vector2 = vector5;
			Vector3 vector6;
			if (!flag37)
			{
				object obj44 = obj43 + 32;
				obj44 = leftHand;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				UnityEngine.Object obj45 = networkApe2.rightHand;
				bool flag38 = (object)networkApe2.rightHand == null;
				vector2 = (Vector3)leftHand;
				if (!flag38)
				{
					nint num56 = (nint)obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ X8_v67 (Il2CppClass<UnityEngine.Object>)+40]");
					vector2 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag39 = ex3 == null;
					leftHand = networkApe2.rightHand;
					limp = obj43;
					num17 = num30;
					num11 = num31;
					num13 = num35;
					obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ X8_v67 (Il2CppClass<UnityEngine.Object>)+40]");
					vector6 = (Vector3)0;
					if (flag39)
					{
						goto IL_128d;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X0_v83 (UnityEngine.Object)+18]");
				object obj46 = 0 & 0xFFFFFFFEL;
				bool flag40 = obj46 == null;
				leftHand = obj45;
				limp = obj43;
				num17 = num30;
				num11 = num31;
				num13 = num35;
				obj16 = 0;
				if (!flag40)
				{
					object obj47 = obj43 + 40;
					obj47 = obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X0_v83 (UnityEngine.Object)+18]");
					bool flag41 = (nint)0 < (nint)1;
					obj16 = 0;
					Vector3 vector7 = (Vector3)obj45;
					if (!flag41)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X0_v83 (UnityEngine.Object)+18]");
						object obj48 = 0 & 0xFFFFFFFFL;
						object obj49 = obj43 + 32;
						leftHand = obj45;
						float num57 = num44;
						float num58 = num45;
						float num59 = num19;
						num17 = num30;
						num11 = num31;
						float num60 = num32;
						float num61 = num33;
						float num62 = num34;
						object obj50 = 0;
						vector2 = (Vector3)obj45;
						UnityEngine.Object obj51 = null;
						while (true)
						{
							bool flag42 = System.Runtime.CompilerServices.Unsafe.As<UnityEngine.Object, UIntPtr>(ref obj51) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48);
							object obj52 = !flag42;
							if (obj52 == null)
							{
								object obj53 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X28_v18+v854 @ X19_v24 (UnityEngine.Object)*8]");
								leftHand = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ X0_v101+E4]");
								bool flag43 = (nint)0 == 0;
								object obj54 = !flag43;
								if (obj54 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag44 = leftHand == null;
								bool flag45 = !flag44;
								object obj55 = !flag45;
								vector7 = (Vector3)0;
								if (obj55 == null)
								{
									bool flag46 = (object)leftHand == null;
									obj50 = 0;
									vector2 = (Vector3)0;
									if (flag46)
									{
										goto IL_1208;
									}
									Vector3 position3 = ((Transform)leftHand).position;
									object obj56 = obj22;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1483 @ X0_v109+E4]");
									bool flag47 = (nint)0 == 0;
									object obj57 = !flag47;
									if (obj57 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									float num63 = num11 - num8;
									float num64 = num35 - num6;
									float num65 = num17 - num5;
									float num66 = num63 * num63;
									float num67 = num64 * num64;
									float num68 = num67 + num66;
									float num69 = num65 * num65;
									float num70 = num69 + num68;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									bool flag48 = !(num70 < num29);
									num57 = num17;
									num58 = num11;
									num17 = num65;
									num11 = num69;
									num61 = num35;
									num35 = num70;
									vector7 = (Vector3)0;
									if (!flag48)
									{
										Vector3 position4 = ((Transform)leftHand).position;
										object obj58 = obj22;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1503 @ X0_v114+E4]");
										bool flag49 = (nint)0 == 0;
										object obj59 = !flag49;
										if (obj59 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Vector3 position5 = ((Transform)leftHand).position;
										float num71 = num69 - num8;
										float num72 = num70 - num6;
										num17 = num65 - num5;
										float num73 = num71 * num71;
										float num74 = num72 * num72;
										float num75 = num74 + num73;
										num11 = num17 * num17;
										num35 = num11 + num75;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										num57 = num70;
										num58 = num65;
										num59 = num69;
										num60 = num65;
										num61 = num69;
										num62 = num70;
										vector7 = (Vector3)0;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X0_v83 (UnityEngine.Object)+18]");
								obj48 = 0;
								obj8 = (UnityEngine.Object)(obj51 + 1);
								UnityEngine.Object obj60 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X0_v83 (UnityEngine.Object)+18]");
								bool flag50 = (nint)obj60 < 0;
								obj45 = leftHand;
								num44 = num57;
								num45 = num58;
								num19 = num59;
								num30 = num17;
								num31 = num11;
								num32 = num60;
								num33 = num61;
								num34 = num62;
								obj16 = 0;
								obj50 = 0;
								vector2 = vector7;
								obj51 = obj8;
								if (!flag50)
								{
									break;
								}
								continue;
							}
							IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
							goto IL_1208;
							IL_1208:
							NullReferenceException ex5 = new NullReferenceException();
							num13 = num35;
							obj16 = obj50;
							goto IL_1226;
						}
					}
					bool flag51 = !(num29 < num3);
					leftHand = obj45;
					limp = obj43;
					num17 = num30;
					num11 = num31;
					num13 = num3;
					if (!flag51)
					{
						Vector3 vector8 = (Vector3)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X0_v94 (UnityEngine.Vector3)+E4]");
						bool flag52 = (nint)0 == 0;
						object obj61 = !flag52;
						if (obj61 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag53 = Walled(vector8, vector7);
						bool flag54 = !flag53;
						object obj62 = !flag54;
						object obj63 = ~obj62;
						num13 = ((obj63 != null) ? num29 : num3);
						object obj64 = !flag54;
						NetworkApe networkApe4 = (((int)(~obj64) != 0) ? networkApe2 : networkApe3);
						leftHand = obj45;
						limp = obj43;
						num17 = num5;
						num11 = num8;
						networkApe3 = networkApe4;
						float num4 = num32;
						num = num34;
						float num7 = num19;
						num3 = num13;
					}
					continue;
				}
				goto IL_1250;
			}
			goto IL_125e;
			IL_12c2:
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_12d0;
			IL_1242:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_1250;
			IL_1226:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_1234;
			IL_1250:
			IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
			goto IL_125e;
			IL_125e:
			ex2 = new IndexOutOfRangeException();
			goto IL_126c;
			IL_128d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex10 = new ArgumentNullException();
			num10 = num17;
			num12 = num11;
			num14 = num13;
			obj17 = null;
			goto IL_12c2;
			IL_12d0:
			NullReferenceException ex11 = new NullReferenceException();
			networkApe = null;
			obj39 = 0;
			val2 = val3;
			val = (Enumerator<, >)(ref val2);
			val4 = (Enumerator<, >)(ref val2);
			goto IL_1306;
			IL_1234:
			NullReferenceException ex12 = new NullReferenceException();
			goto IL_1242;
			IL_126c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ex3 = new ArgumentNullException();
			vector6 = (Vector3)0;
			goto IL_128d;
		}
		networkApe = null;
		obj39 = 0;
		val2 = val3;
		val = (Enumerator<, >)(ref val2);
		val4 = (Enumerator<, >)(ref val2);
		object obj65 = 0;
		object obj69 = default;
		NetworkApe result2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			object obj66 = 0;
			obj17 = (UnityEngine.Object)obj66;
			((Enumerator<, >*)val4)->Dispose();
			bool flag55 = obj65 == null;
			object obj67 = !flag55;
			num9 = num17;
			if (obj67 == null)
			{
				bool flag56 = (object)networkApe == null;
				object obj68 = !flag56;
				num9 = num17;
				OutOfMemoryException ex13 = (OutOfMemoryException)val4;
				if (obj68 == null)
				{
					break;
				}
			}
			else
			{
				OutOfMemoryException ex13 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj17 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num17 = num9;
				networkApe = (NetworkApe)1;
				obj65 = obj39;
				continue;
			}
			if ((nint)obj17 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj65 = obj69;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num17 = num9;
				obj39 = obj69;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return result2;
		}
		result = networkApe3;
		goto IL_14be;
	}

	private static bool Walled(Vector3 from, Vector3 to)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_0040: Expected VT, but got I4
		//IL_0040: Expected VT, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		QueryTriggerInteraction queryTriggerInteraction = default;
		return Physics.Linecast((Vector3)4294961403L, (Vector3)1, 0, queryTriggerInteraction);
	}

	public static float RigOf(NetworkApe who)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I
		//IL_01e9: Expected Obj, but got I4
		//IL_04d8: Expected Obj, but got I4
		//IL_065d: Expected Obj, but got I
		//IL_067f: Expected Obj, but got I4
		//IL_0508: Expected Obj, but got I4
		//IL_0293: Expected Obj, but got I4
		//IL_0578: Expected Obj, but got I4
		//IL_06e7: Expected Obj, but got I
		//IL_0709: Expected Obj, but got I4
		//IL_0540: Expected Obj, but got I4
		//IL_069d: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I4
		//IL_02dc: Expected F8, but got I
		//IL_05ea: Expected F4, but got I
		//IL_05fa: Invalid comparison between F8 and I
		//IL_03e1: Invalid comparison between F4 and I4
		//IL_05b0: Expected Obj, but got I4
		//IL_0727: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I
		if ((object)who != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = who.monsterBody != null;
			bool flag3 = !flag2;
			float result = 1f;
			if (!flag3)
			{
				MonsterAvatar monsterBody = who.monsterBody;
				bool flag4 = (object)who.monsterBody == null;
				float num = 1f;
				if (flag4)
				{
					goto IL_0481;
				}
				MonsterDirector.Entry entry = monsterBody.entry;
				bool flag5 = monsterBody.entry == null;
				result = 1f;
				if (!flag5)
				{
					float num3;
					if (~(entry.legs ? 1u : 0u) == 0)
					{
						double num2 = (double)entry.eyeHeight / 1.5;
						bool flag6 = num2 < 0.5;
						num3 = 0.5f;
						if (!flag6)
						{
							bool flag7 = num2 > 2.0;
							num3 = 2f;
							if (!flag7)
							{
								num3 = (float)num2;
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
						object obj4 = 0;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v10+E4]");
						bool flag8 = (nint)0 == 0;
						object obj6 = !flag8;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj7 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v14+E4]");
						bool flag9 = (nint)0 == 0;
						object obj8 = !flag9;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj7 = obj4;
						}
						object obj9 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v14+A0]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v12+E4]");
						bool flag10 = (nint)0 == 0;
						object obj11 = !flag10;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = (UnityEngine.Object)obj10 != null;
						object obj12 = obj4;
						bool flag12 = !flag11;
						double num4 = 0.5;
						if (!flag12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v19+E4]");
							bool flag13 = (nint)0 == 0;
							object obj13 = !flag13;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							obj12 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v19+E4]");
							bool flag14 = (nint)0 == 0;
							object obj14 = !flag14;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj12 = obj4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v19+A0]");
							object obj15 = 0;
							object obj16 = obj15;
							bool flag15 = obj15 == null;
							num = 1f;
							if (flag15)
							{
								goto IL_0481;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v38+D8]");
							num4 = 0.0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v19+E4]");
						bool flag16 = (nint)0 == 0;
						object obj17 = !flag16;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj18 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v23+E4]");
						bool flag17 = (nint)0 == 0;
						object obj19 = !flag17;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj18 = obj4;
						}
						object obj20 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v23+A0]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v19+E4]");
						bool flag18 = (nint)0 == 0;
						object obj22 = !flag18;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj29;
						if ((UnityEngine.Object)obj21 != null)
						{
							object obj23 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v28+E4]");
							bool flag19 = (nint)0 == 0;
							object obj24 = !flag19;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj25 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v32+E4]");
							bool flag20 = (nint)0 == 0;
							object obj26 = !flag20;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj25 = obj4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v32+A0]");
							object obj27 = 0;
							object obj28 = obj27;
							bool flag21 = obj27 == null;
							num = 1f;
							if (flag21)
							{
								goto IL_0481;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v30+DC]");
							obj29 = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
							obj29 = 0;
						}
						double num5 = ((~(entry.hangs ? 1u : 0u) != 0 || !(entry.reach > 0f)) ? ((double)entry.eyeHeight / num4) : ((double)entry.reach / (double)obj29));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						num3 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						if (!(num5 < 0.0))
						{
							bool flag22 = !(num5 > 3.5);
							num3 = (float)num5;
							if (!flag22)
							{
								num3 = 3.5f;
							}
						}
						monsterBody = who.monsterBody;
						bool flag23 = (object)who.monsterBody == null;
						num = num3;
						if (flag23)
						{
							goto IL_0481;
						}
					}
					result = num3 * monsterBody.sizeBy;
				}
			}
			return result;
		}
		goto IL_0481;
		IL_0481:
		throw new NullReferenceException();
	}

	public unsafe static bool Part(NetworkApe who, Vector3 hand, float reach, out ApePart part, out float away)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04ce: Expected native int or pointer, but got VT
		//IL_04db: Expected Ref, but got F4
		//IL_04c5: Expected I4, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I8
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_04a4: Expected Obj, but got I4
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected I4, but got Unknown
		//IL_01f4: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I8
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_0257: Expected F4, but got I4
		//IL_05ce: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I4
		//IL_02d0: Expected Obj, but got I4
		//IL_0512: Expected Obj, but got I
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected Obj, but got Unknown
		//IL_0333: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got I
		//IL_0594: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I4
		//IL_0440: Invalid comparison between F4 and I4
		//IL_0469: Expected Ref, but got F4
		//IL_047e: Expected F4, but got I
		//IL_0479: Expected native int or pointer, but got VT
		//IL_0487: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD138]");
		object obj = 0;
		((Vector3*)(nint)hand)->x = 0f;
		float num = default;
		ref ApePart reference = ref *(ApePart*)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12;
		if ((object)who != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD140]");
			object obj2 = 0;
			(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0, (System.__Canon)(object)who.head);
			object obj3 = default;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+18]");
				if ((nint)0 != 0)
				{
					object obj4 = obj3 + 40;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple2 = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)1, (System.__Canon)(object)who.leftHand);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+18]");
					object obj5 = 0 & 0xFFFFFFFEL;
					if (obj5 != null)
					{
						object obj6 = obj3 + 56;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						System.__Canon rightHand = (System.__Canon)(object)who.rightHand;
						(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple3 = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)2, (System.__Canon)(object)who.rightHand);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+18]");
						bool flag = (nint)0 < (nint)2;
						object obj7 = !flag;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+18]");
						object obj8 = -2;
						bool flag2 = obj8 == null;
						object obj9 = ~obj7;
						object obj10 = obj9 | flag2;
						if (obj10 == null)
						{
							object obj11 = obj3 + 72;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+18]");
							if ((nint)0 < (nint)1)
							{
								obj12 = 0;
								goto IL_05a2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+18]");
							object obj15 = 0 & 0xFFFFFFFFL;
							object obj16 = obj3 + 40;
							object obj18 = default;
							object obj17 = obj18;
							object obj20 = default;
							object obj19 = obj20;
							obj12 = 0;
							object obj21 = 0;
							float num2 = 0f;
							UnityEngine.Object obj22 = null;
							while (true)
							{
								bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15);
								object obj23 = !flag3;
								if (obj23 != null)
								{
									break;
								}
								object obj24 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v20+E4]");
								bool flag4 = (nint)0 == 0;
								object obj25 = !flag4;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag5 = (UnityEngine.Object)obj16 == null;
								bool flag6 = !flag5;
								object obj26 = !flag6;
								object obj27 = obj17;
								object obj28 = obj19;
								float num3 = num2;
								obj22 = null;
								rightHand = null;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X29_v6-8]");
									bool flag7 = who.IsTorn((ApePart)0);
									bool flag8 = !flag7;
									object obj29 = !flag8;
									obj27 = obj17;
									obj28 = obj19;
									num3 = num2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X29_v6-8]");
									obj22 = (UnityEngine.Object)0;
									rightHand = null;
									if (obj29 == null)
									{
										if (obj16 == null)
										{
											goto IL_04b7;
										}
										Vector3 position = ((Transform)obj16).position;
										object obj30 = obj14;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X0_v30+E4]");
										bool flag9 = (nint)0 == 0;
										object obj31 = !flag9;
										if (obj31 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float num4 = num2 - reach;
										object obj32 = obj19 - obj20;
										obj27 = obj17 - obj18;
										float num5 = num4 * num4;
										object obj33 = obj32 * obj32;
										float num6 = num5 + (float)obj33;
										object obj34 = obj27 * obj27;
										num3 = (float)obj34 + num6;
										obj28 = part;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										bool flag10 = !(num3 < (float)part);
										obj22 = null;
										rightHand = null;
										if (!flag10)
										{
											reference = ref *(ApePart*)num3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X29_v6-8]");
											((Vector3*)(nint)hand)->x = 0f;
											obj12 = 1;
											obj22 = null;
											rightHand = null;
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+18]");
								obj15 = 0;
								obj21++;
								obj16 += 16;
								object obj35 = obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+18]");
								bool flag11 = (nint)obj35 < 0;
								obj17 = obj27;
								obj19 = obj28;
								num2 = num3;
								if (flag11)
								{
									continue;
								}
								goto IL_05a2;
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
		}
		goto IL_04b7;
		IL_05a2:
		return (byte)(obj12 & 1) != 0;
		IL_04b7:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	private unsafe static Vector3 FloorUnder(Vector3 from)
	{
		//IL_00d4: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		//IL_0038: Expected VT, but got I8
		//IL_0038: Expected VT, but got Ref
		//IL_006e: Expected VT, but got I4
		//IL_0061: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		object obj5 = num * 0;
		object obj6 = obj4;
		object obj7 = default;
		float maxDistance = (float)obj7 + (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		bool flag2 = Physics.Raycast((Vector3)(&obj9), (Vector3)4294961403L, out *(RaycastHit*)1, maxDistance, 0, queryTriggerInteraction);
		if (flag2)
		{
			return (Vector3)flag2;
		}
		return (Vector3)flag2;
	}

	private static bool Grip(XRNode node)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I
		//IL_0186: Expected VT, but got I
		//IL_0084: Invalid comparison between F4 and I4
		//IL_0093: Invalid comparison between F4 and I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got F4
		//IL_00f0: Expected Obj, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected I4, but got Unknown
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		InputDevice inputDevice = default;
		bool isValid = inputDevice.isValid;
		bool flag = !isValid;
		bool result = false;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v9+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6+80]");
			if (inputDevice.TryGetFeatureValue((InputFeatureUsage<float>)0, out var value))
			{
				float num = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				float num2 = num - 0f;
				bool flag3 = num2 < 0f;
				bool flag4 = num2 == 0f;
				float num3 = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				object obj5 = num3 ^ 0;
				object obj6 = value ^ num2;
				object obj7 = obj5 & obj6;
				bool flag5 = (nint)obj7 < 0;
				bool flag6 = flag3 == flag5;
				object obj8 = !flag4;
				bool flag7 = (byte)((flag6 & obj8) ? 1 : 0) != 0;
				result = flag7;
			}
			else
			{
				result = false;
			}
		}
		return result;
	}

	private static bool Tracked(XRNode node)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I
		//IL_00ca: Expected VT, but got Obj
		//IL_00d9: Expected Obj, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		InputDevice inputDevice = default;
		bool isValid = inputDevice.isValid;
		bool flag = !isValid;
		bool result = false;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v9+A0]");
			object obj4 = 0;
			bool flag3 = inputDevice.TryGetFeatureValue((InputFeatureUsage<bool>)obj4, out var value);
			object obj5 = !flag3;
			object obj6 = 1 & obj5;
			object obj7 = value | obj6;
			bool flag4 = obj7 == null;
			bool flag5 = !flag4;
			result = flag5;
		}
		return result;
	}

	private static bool Button(XRNode node, InputFeatureUsage<bool> usage)
	{
		//IL_0074: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected I4, but got Unknown
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		InputDevice inputDevice = default;
		bool isValid = inputDevice.isValid;
		bool flag = !isValid;
		bool result = false;
		if (!flag)
		{
			bool flag2 = inputDevice.TryGetFeatureValue(usage, out var value);
			bool flag3 = !value;
			object obj = !flag3;
			result = (byte)((flag2 & obj) ? 1 : 0) != 0;
		}
		return result;
	}

	private unsafe static Vector2 Stick(XRNode node)
	{
		//IL_0010: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected VT, but got Unknown
		//IL_016f: Expected Ref, but got VT
		//IL_019d: Expected Obj, but got I4
		//IL_00b0: Expected VT, but got I4
		//IL_008e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6+28]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD118]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v8+A0]");
				obj4 = 0;
			}
			Vector2? vector = (Vector2?)(object)(obj4 + 40);
			Vector2 value = ((Vector2?*)vector)->Value;
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float deadzone = default;
			return GillaSticks.Dead((Vector2)0, deadzone);
		}
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return GillaSticks.Read(node, 0.25f, trustPushes: true);
	}

	private static void Buzz(XRNode node, float amp, float seconds)
	{
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		InputDevice inputDevice = default;
		if (inputDevice.isValid)
		{
			bool flag = inputDevice.SendHapticImpulse(0u, amp, seconds);
		}
	}

	public MonsterPlayer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0517: Expected F4, but got I
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bf: Expected Obj, but got I8
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_01ac: Expected F4, but got I8
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I
		//IL_01ec: Expected F4, but got I8
		//IL_0256: Expected I4, but got I8
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0286: Expected I4, but got I8
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_031e: Expected I4, but got I8
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_034e: Expected I4, but got I8
		//IL_03b8: Expected I4, but got I8
		//IL_03d6: Expected Obj, but got I
		//IL_03e6: Expected Obj, but got I
		//IL_03f6: Expected Obj, but got I
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0418: Expected I4, but got I8
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_0469: Expected I4, but got I8
		//IL_0478: Expected I4, but got I8
		//IL_0487: Expected I4, but got I8
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj3 = 0;
		object obj4 = this + 264;
		maxDoorThrow = 8f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BFA8]");
		squashSpeed = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<int, float> dictionary = default;
		dictionary._002Ector();
		object obj5 = this + 144;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 1045220557;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C7D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B958]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C7E0]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EFC0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CB60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CD50]");
		_ = 0;
		_ = 1066611507;
		_ = 1;
		object obj6 = obj5 + 276;
		obj6 = 8589934582L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BDC8]");
		_ = 0;
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = obj5 + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = obj5 + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj9 = obj5 + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		float[] array = default;
		if (array.Length != 0)
		{
			bool flag = array.Length == 1;
			array[0] = 3.2400998E+09f;
			if (!flag)
			{
				object obj10 = this + 648;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
				object obj11 = 0;
				array[1] = 3.2400998E+09f;
				armLostAt = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				int[] array2 = default;
				if (array2.Length != 0)
				{
					bool flag2 = array2.Length == 1;
					array2[0] = -1;
					if (!flag2)
					{
						object obj12 = this + 656;
						array2[1] = -1;
						deadBody = array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						float[] array3 = default;
						deadSince = array3;
						object obj13 = this + 664;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						int[] array4 = default;
						if (array4.Length != 0)
						{
							bool flag3 = array4.Length == 1;
							array4[0] = -1;
							if (!flag3)
							{
								object obj14 = this + 736;
								array4[1] = -1;
								bodyOf = array4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								int[] array5 = default;
								if (array5.Length != 0)
								{
									bool flag4 = array5.Length == 1;
									array5[0] = -1;
									if (!flag4)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD160]");
										object obj15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
										object obj16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AA0]");
										object obj17 = 0;
										object obj18 = this + 744;
										array5[1] = -1;
										bodyPart = array5;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										GillaPieceId[] array6 = default;
										pieceIn = array6;
										object obj19 = this + 752;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										ripBody = -1;
										fistsFrame = -10;
										awaitBody = -1;
										SpawnRoomToldAt__BackingField = -999f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										List<Vector3> list = default;
										list._002Ector(4);
										object obj20 = this + 848;
										touching = list;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										closedL = 0f;
										base._002Ector();
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	static MonsterPlayer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		_ = 1065353216;
		_ = 4294967295L;
	}

	private Vector3 _003CSquashing_003Eg__Going_007C20_0(Vector3 on, ref _003C_003Ec__DisplayClass20_0 P_1)
	{
		//IL_0185: Invalid comparison between F4 and I4
		//IL_0029: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_0014: Expected VT, but got Obj
		//IL_0107: Expected VT, but got I4
		//IL_00de: Expected Obj, but got I
		//IL_014c: Expected VT, but got I4
		//IL_014c: Expected Obj, but got I
		if (on.x != 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			return (Vector3)this;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [on @ X1 (UnityEngine.Vector3)+48]");
		bool flag2 = (UnityEngine.Object)0 != null;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [on @ X1 (UnityEngine.Vector3)+48]");
			bool flag3 = (nint)0 == 0;
			UnityEngine.Object obj4 = null;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [on @ X1 (UnityEngine.Vector3)+48]");
				flag2 = ((Rigidbody)0).isKinematic;
				if (flag2)
				{
					goto IL_00ff;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD048]");
				bool flag4 = (nint)0 == 0;
				obj4 = null;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD048]");
					return ((Rigidbody)0).GetPointVelocity((Vector3)0);
				}
			}
			throw new NullReferenceException();
		}
		goto IL_00ff;
		IL_00ff:
		return (Vector3)flag2;
	}

	private unsafe bool _003CSquashing_003Eg__Meets_007C20_1(Vector3 p, out Vector3 way, ref _003C_003Ec__DisplayClass20_0 P_2)
	{
		//IL_029d: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got I
		//IL_02c2: Expected F4, but got Obj
		//IL_02bd: Expected native int or pointer, but got VT
		//IL_02d7: Expected F4, but got I
		//IL_02d2: Expected native int or pointer, but got VT
		//IL_028d: Expected I4, but got Obj
		//IL_001b: Expected VT, but got I4
		//IL_001b: Expected Obj, but got I
		//IL_00a2: Invalid comparison between Obj and F4
		//IL_00c7: Expected VT, but got Ref
		//IL_00c7: Expected Obj, but got VT
		//IL_030c: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I4
		//IL_03c9: Invalid comparison between Obj and F4
		//IL_0107: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0407: Expected Obj, but got I4
		//IL_0262: Expected Obj, but got I
		//IL_026a: Expected F4, but got Obj
		//IL_027a: Expected F4, but got I
		//IL_0388: Expected native int or pointer, but got VT
		//IL_0395: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj3 = 0;
		((Vector3*)(nint)p)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+8]");
		((Vector3*)(nint)p)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [way @ X2 (UnityEngine.Vector3&)+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [way @ X2 (UnityEngine.Vector3&)+50]");
			Vector3 vector = ((Collider)0).ClosestPoint((Vector3)0);
			object obj5 = default;
			object obj4 = obj5 - obj5;
			object obj7 = default;
			object obj6 = obj7 - obj7;
			object obj9 = default;
			object obj8 = obj9 - obj9;
			object obj10 = obj4 * obj4;
			object obj11 = obj6 * obj6;
			object obj12 = obj10 + obj11;
			object obj13 = obj8 * obj8;
			object obj14 = obj13 + obj12;
			float num = squashReach * squashReach;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num))
			{
				Vector3 vector2 = ((MonsterPlayer)vector)._003CSquashing_003Eg__Going_007C20_0((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref way), ref System.Runtime.CompilerServices.Unsafe.As<Vector3, _003C_003Ec__DisplayClass20_0>(ref way));
				object obj15 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj18 = !flag;
				object obj19 = obj7;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = obj5;
					obj19 = obj7;
				}
				object obj20 = obj9 * obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				object obj21 = default;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)squashSpeed))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
					if ((nint)obj14 > 0)
					{
						object obj23 = obj5 - obj5;
						object obj24 = obj7 - obj7;
						object obj25 = obj9 - obj9;
						object obj26 = obj23 * obj15;
						object obj27 = obj24 * obj19;
						obj20 = obj25 * obj9;
						object obj28 = obj26 + obj27;
						obj22 = obj20 + obj28;
						bool flag2 = (nint)obj22 < 0;
						object obj29 = !flag2;
						bool flag3 = obj22 == null;
						object obj30 = ~obj29;
						object obj31 = obj30 | flag3;
						if (obj31 != null)
						{
							goto IL_023c;
						}
					}
					object obj32 = obj21;
					object obj33 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v14+E4]");
					bool flag4 = (nint)0 == 0;
					object obj34 = !flag4;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj32 = obj21;
						obj15 = obj5;
					}
					object obj35 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					float x;
					float z;
					if ((nint)obj35 > 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						float num2 = (float)obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						x = num2 / 0f;
						z = (float)obj9 / (float)obj32;
					}
					else
					{
						object obj36 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v18+A0]");
						object obj37 = 0;
						x = (float)obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v19+8]");
						z = 0f;
					}
					((Vector3*)(nint)p)->x = x;
					((Vector3*)(nint)p)->z = z;
					return true;
				}
			}
			goto IL_023c;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_023c:
		return false;
	}
}
