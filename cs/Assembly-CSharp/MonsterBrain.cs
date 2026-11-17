using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.AI;

public class MonsterBrain : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass125_0
	{
		public MonsterAvatar _003C_003E4__this;

		public string side;
	}

	public enum State
	{
		// error: enumerator has no value
		Wander,
		// error: enumerator has no value
		Notice,
		// error: enumerator has no value
		Chase,
		// error: enumerator has no value
		Search,
		// error: enumerator has no value
		Kill,
		// error: enumerator has no value
		Recover,
		// error: enumerator has no value
		Pry,
		// error: enumerator has no value
		Break
	}

	public Animator animator;

	public Transform grabSocket;

	public Transform face;

	public float clipWalkSpeed;

	public float clipRunSpeed;

	public float killSeconds;

	public MonsterNet net;

	public float walkSpeed;

	public float runSpeed;

	public float turnSpeed;

	public float gravity;

	public float sightRange;

	public float sightAngle;

	public float senseRange;

	public float loseRange;

	public float hearRange;

	public float hearThreshold;

	public float hearThroughWalls;

	public float trailSpacing;

	public float grabRange;

	private const float OnTopOf = default(float);

	private const float WaitForClaim = default(float);

	private const float ClaimSlack = default(float);

	private float reachedFor;

	public float reachBelow;

	public float reachAbove;

	public float wanderRadius;

	public float giveUpSeconds;

	public float walkAwaySeconds;

	public float recoverSeconds;

	public float killHoldAfterBite;

	public bool despawnAfterKill;

	public bool killLooksUp;

	public AudioClip chaseLoop;

	public float chaseLoopVolume;

	public float health;

	public float staggerSeconds;

	public float deadSeconds;

	public bool pries;

	public bool breaksDoors;

	public float breakSeconds;

	public float breakStand;

	public float pryStand;

	public float pryLiftSeconds;

	public float pryDoneSeconds;

	public float climbSpeed;

	public float climbPitch;

	public bool wallCrawler;

	public float lurkEvery;

	public float lurkHeight;

	public bool weeping;

	public float gazeAngle;

	public float gazeRange;

	private State state__BackingField;

	private float Health__BackingField;

	private bool Dead__BackingField;

	private MonsterWounds Hurt__BackingField;

	private float SnareLeft__BackingField;

	private float ClimbPitch__BackingField;

	private GillaDoor PryDoor__BackingField;

	private bool Prying__BackingField;

	private bool Puppet__BackingField;

	private float AnimSpeed__BackingField;

	private float AnimPace__BackingField;

	private Vector3 LookPoint__BackingField;

	private float LookWeight__BackingField;

	public static readonly List<MonsterBrain> All;

	public static bool Frozen;

	public static bool IgnoreLocal;

	public static float TestVoice;

	private CharacterController cc;

	private Transform headBone;

	private Vector3 home;

	private Vector3 wanderTarget;

	private Vector3 stuckAt;

	private Vector3 pathGoal;

	private Vector3 lookWant;

	private Vector3 lastSeen;

	private readonly List<Vector3> trail;

	private readonly List<MonsterCatalog.Target> targets;

	private readonly Dictionary<PlayerRef, float> killedAt;

	private MonsterCatalog.Target prey;

	private bool hasPrey;

	private bool killLocal;

	private bool pathOk;

	private bool pathEnds;

	private float wait;

	private float vy;

	private float speed;

	private float stateT;

	private float unreachT;

	private float ignoreT;

	private float stuckT;

	private float repathAt;

	private float yawVel;

	private float gait;

	private float nextGlance;

	private float lookWeightWant;

	private NavMeshPath path;

	private NavMeshPath scratch;

	private int corner;

	private const int Solid = default(int);

	private static readonly int SpeedId;

	private static readonly int PaceId;

	private static readonly int KillId;

	private static readonly int PryId;

	private bool hasPry;

	private State pryFrom;

	private float pryT;

	private float doorCheckAt;

	private bool pryLifted;

	private Vector3 prySpot;

	private Vector3 pryToward;

	private MonsterClimb climb;

	private bool lurking;

	private int lurkPhase;

	private float lurkT;

	private float lurkHold;

	private float nextLurk;

	private Vector3 lurkFoot;

	private Vector3 lurkInto;

	private Vector3 lurkFrom;

	private Vector3 lurkLand;

	private int climbPhase;

	private float climbT;

	private Vector3 climbFoot;

	private Vector3 climbFrom;

	private Transform model;

	private Quaternion modelRest;

	private AudioSource voice;

	private static AudioListener ears;

	private static float earsLookedAt;

	private bool Chasing__BackingField;

	public bool livesBelow;

	private bool asleep;

	private Renderer[] drawn;

	private readonly List<Renderer> drawnOn;

	private Vector3 shove;

	private Vector3 fallAxis;

	private float staggerT;

	private float deadT;

	private float snareT;

	private float stumbleAt;

	private Quaternion deadFrom;

	private Vector3 deadAt;

	private const float StumblesPast = default(float);

	private float noticeFor;

	private readonly Dictionary<(int, int), float> marked;

	private readonly List<(int, int)> unmark;

	private readonly Vector3[] parts;

	private const float FreeAfter = default(float);

	private static MicLevel localMic;

	private bool listening;

	private float listeningSince;

	private float stoodT;

	private Vector3 stoodAt;

	private const float ListenMost = default(float);

	private const float ListenAgain = default(float);

	private const float StoodMost = default(float);

	private float hearAt;

	private float searchFor;

	private readonly Dictionary<Transform, (float, bool, float)> ways;

	private float easiestAt;

	private const float EasiestEvery = default(float);

	private const float EasiestBy = default(float);

	private float breakT;

	public State state
	{
		get
		{
			return state__BackingField;
		}
		private set
		{
			state__BackingField = value;
		}
	}

	public float Health
	{
		get
		{
			return Health__BackingField;
		}
		private set
		{
			Health__BackingField = value;
		}
	}

	public bool Dead
	{
		get
		{
			return Dead__BackingField;
		}
		private set
		{
			Dead__BackingField = value;
		}
	}

	public MonsterWounds Hurt
	{
		get
		{
			return Hurt__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 264;
			Hurt__BackingField = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public float SnareLeft
	{
		get
		{
			return SnareLeft__BackingField;
		}
		private set
		{
			SnareLeft__BackingField = value;
		}
	}

	public Vector3 Middle
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0129: Expected Obj, but got I4
			//IL_00ff: Expected VT, but got Obj
			//IL_00b9: Expected VT, but got I4
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
			bool flag2 = cc != null;
			Transform transform = base.transform;
			if (flag2)
			{
				if ((object)cc != null)
				{
					Vector3 center = cc.center;
					if ((object)transform != null)
					{
						return transform.TransformPoint((Vector3)0);
					}
				}
			}
			else if ((object)transform != null)
			{
				return transform.position;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
	}

	public bool Climbing
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
			return climb != null;
		}
	}

	public float ClimbPitch
	{
		get
		{
			return ClimbPitch__BackingField;
		}
		private set
		{
			ClimbPitch__BackingField = value;
		}
	}

	public GillaDoor PryDoor
	{
		get
		{
			return PryDoor__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 280;
			PryDoor__BackingField = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool Prying
	{
		get
		{
			return Prying__BackingField;
		}
		private set
		{
			Prying__BackingField = value;
		}
	}

	public bool Puppet
	{
		get
		{
			return Puppet__BackingField;
		}
		set
		{
			Puppet__BackingField = value;
		}
	}

	public float AnimSpeed
	{
		get
		{
			return AnimSpeed__BackingField;
		}
		private set
		{
			AnimSpeed__BackingField = value;
		}
	}

	public float AnimPace
	{
		get
		{
			return AnimPace__BackingField;
		}
		private set
		{
			AnimPace__BackingField = value;
		}
	}

	public Vector3 LookPoint
	{
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}
		private set
		{
			Vector3 vector = default;
			LookPoint__BackingField = vector;
		}
	}

	public float LookWeight
	{
		get
		{
			return LookWeight__BackingField;
		}
		private set
		{
			LookWeight__BackingField = value;
		}
	}

	public Transform PreyHead
	{
		get
		{
			//IL_0020: Expected Obj, but got VT
			if (~(hasPrey ? 1u : 0u) == 0)
			{
				return (Transform)prey;
			}
			return null;
		}
	}

	public bool Chasing
	{
		get
		{
			return Chasing__BackingField;
		}
		private set
		{
			Chasing__BackingField = value;
		}
	}

	public bool MarkedYou
	{
		get
		{
			//IL_002e: Expected I4, but got Obj
			//IL_0017: Expected VT, but got I4
			(int, int) tuple = (1, 0);
			if (marked != null)
			{
				return marked.ContainsKey(((int, int))0);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public PlayerRef PreyPlayer
	{
		get
		{
			//IL_00c5: Expected Obj, but got I
			//IL_00ef: Expected Obj, but got I4
			//IL_002e: Expected Obj, but got I
			//IL_0058: Expected Obj, but got I4
			//IL_0087: Expected Obj, but got I
			//IL_00b5: Expected VT, but got I
			if (state__BackingField == (State)2 && ~(hasPrey ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+1C8]");
				if ((UnityEngine.Object)0 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+1B8]");
					return (PlayerRef)0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return PlayerRef.None;
		}
	}

	private bool ThroughDoors
	{
		get
		{
			if (~(pries ? 1u : 0u) == 0)
			{
				return true;
			}
			bool flag = !breaksDoors;
			return !flag;
		}
	}

	private float NeedGap
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I4
			//IL_008c: Expected F4, but got I
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
			if (cc != null)
			{
				float height = cc.height;
				float num = height;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				return num + 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AED0]");
			return 0f;
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected Obj, but got Unknown
		//IL_05fc: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I
		//IL_0196: Expected VT, but got F4
		//IL_0159: Expected VT, but got F4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_023d: Expected Obj, but got I4
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got Unknown
		//IL_0655: Expected F4, but got I
		//IL_0655: Expected F4, but got I
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_0693: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_02f7: Expected Obj, but got I
		//IL_03de: Expected Obj, but got I
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_04c1: Expected Obj, but got I
		//IL_0508: Expected Obj, but got I4
		//IL_056f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB500]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		CharacterController characterController = default;
		cc = characterController;
		object obj2 = this + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		GameObject gameObject = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA00]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		MonsterWounds monsterWounds = default;
		Hurt__BackingField = monsterWounds;
		object obj5 = this + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj4;
		Health__BackingField = health;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = animator != null;
		bool flag3 = !flag2;
		Transform transform = null;
		if (!flag3)
		{
			Transform transform2 = animator.transform;
			transform = transform2;
		}
		object obj8 = this + 696;
		model = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v20+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (model != null)
		{
			Quaternion localRotation = ((Transform)obj8).localRotation;
			modelRest = (Quaternion)health;
		}
		Transform transform3 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA08]");
		object obj11 = 0;
		Vector3 position = transform3.position;
		home = (Vector3)health;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NavMeshPath navMeshPath = default;
		navMeshPath._002Ector();
		object obj12 = this + 520;
		path = navMeshPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NavMeshPath navMeshPath2 = default;
		navMeshPath2._002Ector();
		object obj13 = this + 528;
		scratch = navMeshPath2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v36+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = face != null;
		bool flag7 = !flag6;
		Transform transform4 = null;
		if (!flag7)
		{
			Transform parent = face.parent;
			transform4 = parent;
		}
		object obj16 = this + 328;
		headBone = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC48]");
		float num2 = UnityEngine.Random.Range(num, 0f);
		object obj17 = obj4;
		object obj18 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v44+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = (UnityEngine.Object)obj18 == null;
		bool flag10 = !flag9;
		UnityEngine.Object obj20 = null;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9F0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			UnityEngine.Object obj22 = default;
			net = (MonsterNet)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj20 = obj22;
		}
		object obj23 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v49+E4]");
		bool flag11 = (nint)0 == 0;
		object obj24 = !flag11;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Component component;
		if (face != null)
		{
			component = face;
		}
		else
		{
			Transform transform5 = base.transform;
			component = transform5;
		}
		GameObject gameObject2 = component.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		object obj26 = this + 720;
		AudioSource audioSource = default;
		voice = audioSource;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		voice.playOnAwake = false;
		((AudioSource)obj26).loop = true;
		((AudioSource)obj26).clip = chaseLoop;
		voice.volume = 0f;
		((AudioSource)obj26).spatialBlend = 1f;
		((AudioSource)obj26).rolloffMode = (AudioRolloffMode)0;
		((AudioSource)obj26).minDistance = 3f;
		((AudioSource)obj26).maxDistance = 45f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9E8]");
		object obj27 = 0;
		((AudioSource)obj26).dopplerLevel = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj28 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v16+E4]");
		bool flag12 = (nint)0 == 0;
		object obj29 = !flag12;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj30 = default;
		if (obj30 == null)
		{
			GameObject gameObject3 = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9F8]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		}
	}

	private static void FreshEars()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
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
		object obj4 = (nint)0 + (nint)32;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+A0]");
		object obj6 = 0;
		_ = 3240099840L;
	}

	private static bool InSpawnFromPast(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I
		//IL_0372: Expected Obj, but got I4
		//IL_04bf: Expected Obj, but got I
		//IL_04e1: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I4
		//IL_0442: Expected Obj, but got I
		//IL_0464: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_0482: Expected Obj, but got I
		//IL_03f5: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I4
		//IL_0338: Expected I4, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I4
		//IL_031b: Expected VT, but got I4
		//IL_031b: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v1+20]");
		bool flag3 = (UnityEngine.Object)0 == null;
		bool flag4 = !flag3;
		UnityEngine.Object obj8 = null;
		if (!flag4)
		{
			float unscaledTime = Time.unscaledTime;
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v35+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v35+A0]");
			object obj11 = 0;
			float num = unscaledTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v15+28]");
			float num2 = num - 0f;
			bool flag6 = !((double)num2 > 1.0);
			double num3 = 1.0;
			obj8 = null;
			if (!flag6)
			{
				num2 = Time.unscaledTime;
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v38+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				object obj14 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v38+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v17+E4]");
				bool flag8 = (nint)0 == 0;
				object obj16 = !flag8;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B0]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v20+A0]");
				object obj19 = (nint)0 + (nint)32;
				UnityEngine.Object obj20 = default;
				obj19 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				num3 = 1.0;
				obj8 = obj20;
			}
		}
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v9+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj;
		}
		object obj23 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v9+A0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+E4]");
		bool flag10 = (nint)0 == 0;
		object obj25 = !flag10;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X9_v3+20]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v15+E4]");
			bool flag11 = (nint)0 == 0;
			object obj27 = !flag11;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj26 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v15+A0]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v9+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v9+20]");
				Transform transform = ((Component)0).transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8E8]");
					object obj29 = 0;
					object obj30 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v21+E4]");
					bool flag12 = (nint)0 == 0;
					object obj31 = !flag12;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return MonsterDread.ShutOut((Vector3)0, (Vector3)0);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	public void ShowChasing(bool on)
	{
		Chasing__BackingField = on;
	}

	private void ChaseVoice(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04a3: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_010e: Expected VT, but got I4
		//IL_0160: Expected Obj, but got I
		//IL_0168: Expected VT, but got Obj
		//IL_018a: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I4
		//IL_04c1: Expected Obj, but got I
		//IL_053d: Invalid comparison between F4 and I4
		//IL_0550: Expected Obj, but got F4
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Obj, but got Unknown
		//IL_058e: Expected Obj, but got I4
		//IL_02b6: Expected F8, but got I
		//IL_02bf: Expected F4, but got I4
		//IL_05d7: Expected Obj, but got I4
		//IL_05ef: Invalid comparison between F4 and I4
		//IL_0600: Expected Obj, but got I4
		//IL_0347: Invalid comparison between F4 and I4
		//IL_03a2: Invalid comparison between F4 and I4
		//IL_03b3: Expected Obj, but got I4
		//IL_03bc: Invalid comparison between F4 and I4
		//IL_03cd: Expected Obj, but got I4
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
		bool flag2 = voice == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		AudioClip clip = voice.clip;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = clip == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		bool mute;
		if (GillaBackroomsSwitch.OnYourSide((Vector3)0))
		{
			Transform transform2 = base.transform;
			Vector3 position2 = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj8 = 0;
			Vector3 at = (Vector3)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v49 (UnityEngine.Vector3)+E4]");
			bool flag7 = (nint)0 == 0;
			object obj9 = !flag7;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			mute = InSpawnFromPast(at);
		}
		else
		{
			mute = true;
		}
		voice.mute = mute;
		AudioSource audioSource;
		float volume;
		bool flag10;
		if (~(Chasing__BackingField ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v40+E4]");
			bool flag8 = (nint)0 == 0;
			object obj12 = !flag8;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v40+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v15+8]");
			if ((nint)0 == 0)
			{
				audioSource = voice;
				volume = voice.volume;
				goto IL_02e7;
			}
			bool flag9 = !Puppet__BackingField;
			flag10 = flag9;
		}
		else
		{
			flag10 = true;
		}
		audioSource = voice;
		volume = voice.volume;
		if (!flag10)
		{
			goto IL_02e7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		double num = 0.0;
		float num2 = 0f;
		goto IL_04f5;
		IL_02e7:
		num2 = chaseLoopVolume;
		num = 0.25;
		goto IL_04f5;
		IL_04f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		float num4 = default;
		float num3 = 0f * num4;
		float num5 = num3 / (float)num;
		float num6 = num2 - volume;
		bool flag11 = num6 < 0f;
		object obj14 = num6 ^ num6;
		object obj15 = num6 & obj14;
		bool flag12 = (nint)obj15 < 0;
		float num7 = 0f - num5;
		bool flag13 = flag11 == flag12;
		object obj16 = !flag13;
		object obj17 = ~obj16;
		float num8 = ((obj17 != null) ? num5 : num7);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float volume2 = volume + num8;
		bool flag14 = num7 < num5;
		object obj18 = !flag14;
		float num9 = num7 - num5;
		bool flag15 = num9 == 0f;
		object obj19 = !flag15;
		object obj20 = obj18 & obj19;
		object obj21 = ~obj20;
		if (obj21 != null)
		{
			volume2 = num2;
		}
		audioSource.volume = volume2;
		float volume3 = voice.volume;
		if (!(volume3 > 0f) || voice.isPlaying)
		{
			float volume4 = voice.volume;
			bool flag16 = volume4 < 0f;
			object obj22 = !flag16;
			bool flag17 = volume4 == 0f;
			object obj23 = !flag17;
			object obj24 = obj22 & obj23;
			if (obj24 == null && voice.isPlaying)
			{
				voice.Stop();
			}
		}
		else
		{
			AudioClip clip2 = voice.clip;
			float length = clip2.length;
			float time = UnityEngine.Random.Range(0f, length);
			voice.time = time;
			voice.Play();
		}
	}

	private void Start()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0041: Expected VT, but got I4
		//IL_0070: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I
		//IL_01bd: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Vector3 position = transform.position;
			Vector3 vector = default;
			home = vector;
			PickWander((Vector3?)(object)0);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(animator != null))
			{
				return;
			}
			if ((object)animator != null)
			{
				AnimatorControllerParameter[] parameters = animator.parameters;
				if (parameters != null)
				{
					object obj4 = parameters.Length;
					if (parameters.Length < 1)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
					object obj5 = 0;
					object obj6 = 0;
					while (true)
					{
						bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
						object obj7 = !flag2;
						if (obj7 != null)
						{
							break;
						}
						object obj8 = (object)parameters + obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v9+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v9+20]");
							int nameHash = ((AnimatorControllerParameter)0).nameHash;
							object obj9 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v11+E4]");
							bool flag3 = (nint)0 == 0;
							object obj10 = !flag3;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj9 = obj5;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v11+A0]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v12+1C]");
							if ((nint)nameHash == 0)
							{
								hasPry = true;
							}
							obj4 = parameters.Length;
							obj6++;
							if ((nint)obj6 >= parameters.Length)
							{
								return;
							}
							continue;
						}
						goto IL_01f3;
					}
					goto IL_0201;
				}
			}
		}
		goto IL_01f3;
		IL_01f3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0201;
		IL_0201:
		throw new IndexOutOfRangeException();
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
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
		List<System.__Canon> list = (List<System.__Canon>)obj4;
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag2 = list._size < items.Length;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj7 = obj6 + 32;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)(object)this);
		}
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+A0]");
		object obj4 = 0;
		bool flag2 = ((List<System.__Canon>)obj4).Remove((System.__Canon)(object)this);
		if (~(livesBelow ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB08]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v11+A0]");
			object obj7 = 0;
			_ = 0;
		}
	}

	private unsafe bool Asleep()
	{
		//IL_0fd5: Expected Obj, but got I
		//IL_0fe5: Expected Obj, but got I
		//IL_120c: Expected Obj, but got I
		//IL_1246: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I4
		//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Expected I4, but got Unknown
		//IL_0558: Expected Obj, but got I4
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected I4, but got Unknown
		//IL_102a: Expected Obj, but got I
		//IL_1047: Unknown result type (might be due to invalid IL or missing references)
		//IL_1051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got I
		//IL_0704: Expected Obj, but got I
		//IL_070c: Expected I4, but got Obj
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected Obj, but got Unknown
		//IL_0765: Expected Obj, but got I4
		//IL_05c9: Expected Obj, but got I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got I4
		//IL_0443: Expected Obj, but got I4
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got I4
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b3: Expected Obj, but got I
		//IL_11bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c4: Expected Ref, but got Unknown
		//IL_11de: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected Obj, but got I
		//IL_081d: Expected Obj, but got I4
		//IL_0498: Expected Obj, but got I4
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		//IL_1124: Expected Obj, but got I
		//IL_1135: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Unknown result type (might be due to invalid IL or missing references)
		//IL_115b: Expected Obj, but got I4
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_1167: Unknown result type (might be due to invalid IL or missing references)
		//IL_116f: Unknown result type (might be due to invalid IL or missing references)
		//IL_117b: Expected Obj, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected Obj, but got I4
		//IL_0c5f: Expected Obj, but got I4
		//IL_0513: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I4
		//IL_0872: Expected Obj, but got I8
		//IL_0882: Expected Obj, but got I
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected Obj, but got Unknown
		//IL_0899: Expected Obj, but got I4
		//IL_04e5: Expected Obj, but got I4
		//IL_0d37: Expected Obj, but got I4
		//IL_10f6: Expected Obj, but got I4
		//IL_1106: Expected Obj, but got I4
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected Obj, but got I4
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I4
		//IL_0cea: Expected Obj, but got I4
		//IL_0f5b: Expected Obj, but got I4
		//IL_0297: Expected Obj, but got I
		//IL_0d79: Expected Obj, but got I4
		//IL_08c8: Expected Obj, but got I4
		//IL_0fb2: Expected Obj, but got I4
		//IL_08f7: Expected Obj, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b38: Expected Obj, but got I
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Expected Obj, but got Unknown
		//IL_0e78: Expected Obj, but got I4
		//IL_0953: Expected Obj, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got I4
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Expected Obj, but got I4
		//IL_0972: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected VT, but got Unknown
		//IL_03bf: Expected Ref, but got VT
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected VT, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected VT, but got Unknown
		//IL_09d2: Expected Obj, but got I4
		//IL_09f5: Expected I4, but got Obj
		//IL_0a40: Expected Obj, but got I4
		//IL_0a6e: Expected Obj, but got I4
		//IL_0af9: Expected Obj, but got I
		//IL_0b14: Expected Obj, but got I
		//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Expected Obj, but got Unknown
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Expected Obj, but got Unknown
		//IL_0ad1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB08]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+E4]");
		int num = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj6 == null)
		{
			goto IL_003f;
		}
		bool flag2 = (byte)(~(Puppet__BackingField ? 1u : 0u)) != 0;
		object obj8 = !flag2;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val2 = (Enumerator<, >)0;
		int num2 = 0;
		UnityEngine.Object obj9 = null;
		if (obj8 != null)
		{
			goto IL_0ffd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v94+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v94+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v59+8]");
		bool flag4 = (nint)0 == 0;
		val = (Enumerator<, >)0;
		val2 = (Enumerator<, >)0;
		num2 = 0;
		obj9 = null;
		if (flag4)
		{
			goto IL_0e7d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v59+8]");
		Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
		object obj14 = 0;
		int num3 = 0;
		bool flag5;
		object obj16 = default;
		object obj18 = default;
		UnityEngine.Object obj21 = default;
		Enumerator<, > val3 = default;
		object obj27 = default;
		object obj28 = default;
		Vector3 point = default;
		Enumerator<, > val5;
		Enumerator<, > val4;
		object obj23;
		object obj15;
		object obj17;
		UnityEngine.Object obj22;
		while (true)
		{
			flag5 = val2.MoveNext();
			bool flag6 = !flag5;
			obj15 = obj16;
			obj17 = obj18;
			num2 = num3;
			if (flag6)
			{
				break;
			}
			object obj19 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X0_v101+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = obj21 != null;
			bool flag9 = !flag8;
			num3 = 0;
			if (flag9)
			{
				continue;
			}
			bool flag10 = (object)obj21 == null;
			val = (Enumerator<, >)0;
			obj22 = null;
			val2 = val3;
			obj23 = 0;
			num = (int)(&val2);
			val4 = val3;
			val5 = (Enumerator<, >)(ref val2);
			num2 = 0;
			obj9 = null;
			if (flag10)
			{
				goto IL_0e93;
			}
			bool isLocal = ((NetworkApe)obj21).IsLocal;
			bool flag11 = !isLocal;
			object obj24 = !flag11;
			num3 = 0;
			if (obj24 != null)
			{
				continue;
			}
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X0_v107+E4]");
			bool flag12 = (nint)0 == 0;
			object obj26 = !flag12;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ stack_-A8_v16 (UnityEngine.Object)+68]");
			bool flag13 = (UnityEngine.Object)0 != null;
			bool flag14 = !flag13;
			num3 = 0;
			if (flag14)
			{
				continue;
			}
			bool flag15 = (object)obj6 == null;
			val = (Enumerator<, >)0;
			obj22 = null;
			val2 = val3;
			obj23 = 0;
			num = (int)(&val2);
			val4 = val3;
			val5 = (Enumerator<, >)(ref val2);
			num2 = 0;
			obj9 = null;
			if (flag15)
			{
				goto IL_0ebd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ stack_-A8_v16 (UnityEngine.Object)+68]");
			bool flag16 = (nint)0 == 0;
			val = (Enumerator<, >)0;
			obj22 = null;
			val2 = val3;
			obj23 = 0;
			num = (int)(&val2);
			val4 = val3;
			val5 = (Enumerator<, >)(ref val2);
			num2 = 0;
			obj9 = null;
			if (!flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ stack_-A8_v16 (UnityEngine.Object)+68]");
				Vector3 position = ((Transform)0).position;
				Bounds bounds = (Bounds)(obj6 + 40);
				bool flag17 = ((Bounds*)bounds)->Internal_Contains(ref point);
				bool flag18 = !flag17;
				obj15 = obj27;
				obj17 = obj28;
				point = (Vector3)val3;
				num2 = 0;
				obj16 = obj27;
				obj18 = obj28;
				point = (Vector3)val3;
				num3 = 0;
				if (!flag18)
				{
					break;
				}
				continue;
			}
			goto IL_0ecb;
		}
		val = (Enumerator<, >)0;
		object obj29 = 6;
		object obj30 = 0;
		obj22 = null;
		val2 = val3;
		obj23 = 0;
		num = (int)(&val2);
		val4 = val3;
		val5 = (Enumerator<, >)(ref val2);
		bool flag19 = flag5;
		goto IL_11a3;
		IL_003f:
		UnityEngine.Object obj31 = null;
		goto IL_0fea;
		IL_0ffd:
		bool allOn;
		UnityEngine.Object obj41;
		if ((object)obj6 != null)
		{
			allOn = ((GillaBackroomsSwitch)obj6).AllOn;
			obj31 = (UnityEngine.Object)((allOn ? 1 : 0) ^ 1);
			num = obj31 & 1;
			if ((asleep ? 1 : 0) == num)
			{
				goto IL_0fea;
			}
			asleep = (byte)num != 0;
			if (allOn)
			{
				bool flag20 = (object)drawnOn == null;
				obj9 = null;
				obj6 = (UnityEngine.Object)allOn;
				if (!flag20)
				{
					Enumerator<, > enumerator2 = ((List<System.__Canon>)(object)drawnOn).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A00]");
					object obj32 = 0;
					Enumerator<, > val6 = default;
					while (val.MoveNext())
					{
						object obj33 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X0_v55+E4]");
						bool flag21 = (nint)0 == 0;
						object obj34 = !flag21;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag22 = obj21 != null;
						bool flag23 = !flag22;
						num2 = 0;
						if (flag23)
						{
							continue;
						}
						bool flag24 = (object)obj21 == null;
						val = val6;
						obj22 = null;
						obj23 = 0;
						num = (int)(&val);
						val4 = val6;
						val5 = (Enumerator<, >)(ref val);
						num2 = 0;
						obj9 = null;
						obj6 = (UnityEngine.Object)allOn;
						if (!flag24)
						{
							((Renderer)obj21).enabled = true;
							num2 = 0;
							continue;
						}
						goto IL_0eaf;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49F8]");
					object obj35 = 0;
					obj9 = (UnityEngine.Object)obj35;
					val.Dispose();
					val = val6;
					obj15 = obj16;
					obj17 = obj18;
					obj22 = null;
					obj23 = 0;
					num = (int)(&val);
					val4 = val6;
					val5 = (Enumerator<, >)(ref val);
					obj6 = (UnityEngine.Object)allOn;
					OutOfMemoryException ex = new OutOfMemoryException();
					if ((nint)obj9 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj30 = obj23;
						obj22 = (UnityEngine.Object)1;
					}
					else
					{
						if ((nint)obj9 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							bool result = default;
							return result;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						object obj36 = default;
						obj30 = obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj23 = obj36;
					}
					obj29 = 0;
					flag19 = false;
					goto IL_11a3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA360]");
				object obj37 = 0;
				num2 = (int)obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
				object obj38 = this + 736;
				UnityEngine.Object obj39 = default;
				drawn = (Renderer[])(object)obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				List<Renderer> list = drawnOn;
				bool flag25 = (object)drawnOn == null;
				obj9 = obj39;
				obj6 = (UnityEngine.Object)allOn;
				if (!flag25)
				{
					num2 = list._size;
					num = list._version + 1;
					list._size = 0;
					list._version = num;
					bool flag26 = list._size < 1;
					obj9 = obj39;
					if (!flag26)
					{
						Array.Clear(list._items, 0, list._size);
						obj9 = null;
					}
					object obj40 = obj38;
					bool flag27 = obj38 == null;
					obj6 = (UnityEngine.Object)allOn;
					if (!flag27)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X22_v6+18]");
						bool flag28 = (nint)0 < (nint)1;
						obj41 = obj21;
						if (flag28)
						{
							goto IL_0c35;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X22_v6+18]");
						object obj42 = 0 & 0xFFFFFFFFL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4188]");
						obj = 0;
						obj14 = obj38 + 32;
						object obj43 = 0;
						while (true)
						{
							bool flag29 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj43) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42);
							object obj44 = !flag29;
							obj22 = obj21;
							obj6 = (UnityEngine.Object)allOn;
							if (obj44 != null)
							{
								break;
							}
							object obj45 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X0_v35+E4]");
							bool flag30 = (nint)0 == 0;
							object obj46 = !flag30;
							if (obj46 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X26_v5+v475 @ X23_v7*8]");
							bool flag31 = (UnityEngine.Object)0 != null;
							bool flag32 = !flag31;
							num2 = 0;
							obj9 = null;
							if (flag32)
							{
								goto IL_0b28;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X26_v5+v475 @ X23_v7*8]");
							bool flag33 = (nint)0 == 0;
							num2 = 0;
							obj9 = null;
							obj6 = (UnityEngine.Object)allOn;
							if (!flag33)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X26_v5+v475 @ X23_v7*8]");
								bool flag34 = ((Renderer)0).enabled;
								bool flag35 = !flag34;
								num2 = 0;
								obj9 = null;
								if (flag35)
								{
									goto IL_0b28;
								}
								List<System.__Canon> list2 = (List<System.__Canon>)(object)drawnOn;
								bool flag36 = (object)drawnOn == null;
								num2 = 0;
								obj9 = null;
								obj6 = (UnityEngine.Object)allOn;
								if (!flag36)
								{
									System.__Canon[] items = list2._items;
									num = (int)obj;
									int version = list2._version + 1;
									list2._version = version;
									bool flag37 = list2._items == null;
									num2 = 0;
									obj9 = null;
									obj6 = (UnityEngine.Object)allOn;
									if (!flag37)
									{
										bool flag38 = list2._size < items.Length;
										object obj47 = !flag38;
										if (obj47 == null)
										{
											object obj48 = list2._items + list2._size;
											num = list2._size + 1;
											list2._size = num;
											object obj49 = obj48 + 32;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X26_v5+v475 @ X23_v7*8]");
											obj49 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										}
										else
										{
											List<Renderer> list3 = drawnOn;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X26_v5+v475 @ X23_v7*8]");
											((List<System.__Canon>)(object)list3).AddWithResize((System.__Canon)0);
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X26_v5+v475 @ X23_v7*8]");
										((Renderer)0).enabled = false;
										num2 = 0;
										obj9 = null;
										goto IL_0b28;
									}
								}
							}
							goto IL_0e7d;
							IL_0b28:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X22_v6+18]");
							obj42 = 0;
							obj43++;
							object obj50 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X22_v6+18]");
							if ((nint)obj50 < 0)
							{
								continue;
							}
							goto IL_0b6a;
						}
						goto IL_0ea1;
					}
				}
			}
		}
		goto IL_0e7d;
		IL_0ee9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0ef8;
		IL_0eaf:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0ebd;
		IL_0c35:
		object obj51 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X0_v15+E4]");
		bool flag39 = (nint)0 == 0;
		object obj52 = !flag39;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag40 = animator != null;
		bool flag41 = !flag40;
		int num4 = 0;
		bool flag42 = false;
		if (!flag41)
		{
			bool flag43 = (object)animator == null;
			obj21 = obj41;
			num2 = 0;
			obj9 = null;
			obj6 = (UnityEngine.Object)allOn;
			if (flag43)
			{
				goto IL_0e7d;
			}
			animator.enabled = allOn;
			num4 = 0;
			flag42 = allOn;
		}
		bool flag44 = !allOn;
		object obj53 = !flag44;
		if (obj53 != null)
		{
			goto IL_003f;
		}
		object obj54 = obj2;
		obj6 = voice;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X0_v20+E4]");
		bool flag45 = (nint)0 == 0;
		object obj55 = !flag45;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj6 != null)
		{
			bool flag46 = (object)voice == null;
			obj21 = obj41;
			num2 = 0;
			obj9 = null;
			if (flag46)
			{
				goto IL_0e7d;
			}
			voice.Stop();
		}
		if (~(Puppet__BackingField ? 1u : 0u) == 0)
		{
			obj31 = (UnityEngine.Object)1;
		}
		else
		{
			Chasing__BackingField = false;
			hasPrey = false;
			state__BackingField = (State)0;
			stateT = 0f;
			reachedFor = 0f;
			listening = false;
			obj31 = (UnityEngine.Object)1;
		}
		goto IL_0fea;
		IL_0ecb:
		NullReferenceException ex3 = new NullReferenceException();
		obj15 = obj16;
		obj17 = obj18;
		goto IL_0ee9;
		IL_11a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
		object obj56 = 0;
		obj9 = (UnityEngine.Object)obj56;
		((Enumerator<, >*)val5)->Dispose();
		bool flag47 = obj30 == null;
		object obj57 = !flag47;
		if (obj57 != null)
		{
			goto IL_0ef8;
		}
		bool flag48 = (object)obj22 == null;
		object obj58 = !flag48;
		ex3 = (NullReferenceException)val5;
		if (obj58 != null)
		{
			goto IL_0ee9;
		}
		if ((nint)obj29 != 6)
		{
			bool flag49 = obj29 == null;
			object obj59 = !flag49;
			obj31 = obj22;
			if (obj59 != null)
			{
				goto IL_0fea;
			}
		}
		object obj60 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v13+A0]");
		object obj61 = 0;
		obj16 = obj15;
		obj18 = obj17;
		obj21 = obj22;
		num = (flag19 ? 1 : 0);
		goto IL_0ffd;
		IL_0ef8:
		throw new OutOfMemoryException();
		IL_0fea:
		return (byte)(obj31 & 1) != 0;
		IL_0ebd:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0ecb;
		IL_0b6a:
		obj41 = obj21;
		goto IL_0c35;
		IL_0ea1:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_0eaf;
		IL_0e93:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0ea1;
		IL_0e7d:
		NullReferenceException ex7 = new NullReferenceException();
		obj22 = obj21;
		goto IL_0e93;
	}

	private unsafe void Update()
	{
		//IL_004d: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_42e8: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I4
		//IL_0197: Expected VT, but got I4
		//IL_0277: Invalid comparison between F4 and I4
		//IL_02a4: Invalid comparison between F4 and I4
		//IL_02d1: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I4
		//IL_0340: Expected Obj, but got I4
		//IL_054c: Expected Obj, but got I4
		//IL_4369: Invalid comparison between F4 and I4
		//IL_0221: Expected VT, but got I4
		//IL_4350: Expected Obj, but got I4
		//IL_038c: Expected F8, but got I
		//IL_03a1: Invalid comparison between F4 and I
		//IL_03b3: Expected Obj, but got I4
		//IL_0266: Expected VT, but got I4
		//IL_059b: Expected Obj, but got I4
		//IL_065a: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I4
		//IL_0437: Expected Obj, but got I4
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected Obj, but got Unknown
		//IL_0687: Expected Obj, but got I4
		//IL_0470: Expected Obj, but got I4
		//IL_0480: Expected Obj, but got I4
		//IL_049a: Expected Obj, but got I4
		//IL_13b2: Expected Obj, but got I4
		//IL_06c3: Expected F4, but got VT
		//IL_06d3: Expected F8, but got I
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected Ref, but got Unknown
		//IL_06ec: Expected VT, but got Ref
		//IL_13f7: Expected Obj, but got I4
		//IL_04c5: Expected Obj, but got I4
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_04eb: Expected Obj, but got I4
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_142a: Expected Obj, but got I4
		//IL_1433: Expected Obj, but got I4
		//IL_0768: Expected Obj, but got I8
		//IL_18b9: Expected VT, but got F4
		//IL_18c2: Expected F4, but got I4
		//IL_07b8: Expected VT, but got F4
		//IL_14c9: Invalid comparison between F4 and I4
		//IL_14d8: Expected F8, but got I4
		//IL_1e73: Expected Obj, but got VT
		//IL_4400: Expected Obj, but got I4
		//IL_3862: Expected VT, but got F4
		//IL_386b: Expected F4, but got I4
		//IL_11fa: Expected VT, but got F4
		//IL_1203: Expected F4, but got I4
		//IL_333f: Expected F8, but got I
		//IL_16ad: Expected VT, but got F4
		//IL_16b6: Expected F4, but got I4
		//IL_1b9d: Expected Obj, but got I
		//IL_1bbd: Expected Obj, but got I
		//IL_1bdf: Expected Obj, but got I4
		//IL_3380: Expected Obj, but got I4
		//IL_3389: Unknown result type (might be due to invalid IL or missing references)
		//IL_338e: Expected Obj, but got Unknown
		//IL_33ad: Expected F8, but got I
		//IL_1e02: Expected Obj, but got I4
		//IL_08f9: Expected VT, but got F4
		//IL_0902: Expected F4, but got I4
		//IL_1ead: Invalid comparison between VT and I4
		//IL_1c24: Expected Obj, but got I4
		//IL_127c: Expected F4, but got I4
		//IL_129c: Expected VT, but got F4
		//IL_12a5: Expected F4, but got I4
		//IL_33d6: Invalid comparison between VT and I4
		//IL_1707: Expected F4, but got VT
		//IL_1717: Expected F8, but got I
		//IL_1727: Expected F8, but got I
		//IL_3970: Invalid comparison between F4 and I4
		//IL_1b0b: Expected F4, but got I
		//IL_1b0b: Expected F4, but got I
		//IL_1b3d: Expected F4, but got I4
		//IL_1b56: Expected F8, but got I4
		//IL_1b5e: Expected F8, but got VT
		//IL_194e: Expected Obj, but got VT
		//IL_32d7: Expected VT, but got Ref
		//IL_32df: Expected VT, but got F4
		//IL_32e8: Expected F4, but got I4
		//IL_3309: Expected F8, but got I4
		//IL_3321: Expected F4, but got VT
		//IL_45d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_45d9: Expected Obj, but got Unknown
		//IL_45f5: Expected VT, but got F4
		//IL_1eca: Expected Obj, but got VT
		//IL_4417: Invalid comparison between F4 and I4
		//IL_4439: Expected Obj, but got I4
		//IL_4bfa: Expected VT, but got F4
		//IL_4c03: Expected F4, but got I4
		//IL_3903: Expected Obj, but got I4
		//IL_1c68: Expected Obj, but got I
		//IL_133d: Expected VT, but got I4
		//IL_1345: Expected VT, but got F4
		//IL_3540: Expected Obj, but got I
		//IL_3553: Expected VT, but got F4
		//IL_355c: Expected F4, but got I4
		//IL_33f5: Expected Obj, but got VT
		//IL_1785: Expected Obj, but got I4
		//IL_3e35: Expected F4, but got VT
		//IL_3e45: Expected F8, but got I
		//IL_3e68: Expected F8, but got I
		//IL_39b8: Expected F4, but got I
		//IL_39c0: Expected VT, but got F4
		//IL_39c9: Expected F4, but got I4
		//IL_39f1: Expected F8, but got I
		//IL_0b40: Invalid comparison between F4 and I4
		//IL_0b51: Expected Obj, but got I4
		//IL_0b5a: Invalid comparison between F4 and I4
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected Obj, but got Unknown
		//IL_1988: Invalid comparison between VT and I4
		//IL_0971: Invalid comparison between VT and I4
		//IL_0be4: Expected Obj, but got I4
		//IL_0bed: Expected VT, but got I4
		//IL_35be: Expected F4, but got I4
		//IL_3ec6: Expected Obj, but got I4
		//IL_1662: Expected VT, but got F8
		//IL_1f31: Expected Obj, but got I4
		//IL_20be: Expected Obj, but got I4
		//IL_0fb6: Expected Obj, but got I4
		//IL_0fc6: Expected Obj, but got I4
		//IL_0fe0: Expected Obj, but got I4
		//IL_0b9f: Expected VT, but got I4
		//IL_19a5: Expected Obj, but got VT
		//IL_345c: Expected Obj, but got I4
		//IL_453b: Expected Obj, but got I4
		//IL_17f2: Invalid comparison between F4 and I4
		//IL_1803: Expected Obj, but got I4
		//IL_180c: Invalid comparison between F4 and I4
		//IL_1823: Unknown result type (might be due to invalid IL or missing references)
		//IL_1828: Expected Obj, but got Unknown
		//IL_3efd: Expected F8, but got I
		//IL_3f0d: Invalid comparison between F4 and I
		//IL_3e1d: Expected Obj, but got I4
		//IL_0990: Expected Obj, but got VT
		//IL_099f: Invalid comparison between VT and I4
		//IL_1f68: Expected F8, but got I
		//IL_2118: Invalid comparison between F4 and I
		//IL_1cfa: Expected Obj, but got I4
		//IL_3f80: Expected VT, but got I4
		//IL_2217: Invalid comparison between F4 and I
		//IL_1d29: Expected Obj, but got I
		//IL_1d44: Expected VT, but got F4
		//IL_1d4d: Expected F4, but got I4
		//IL_1d7f: Expected I4, but got Obj
		//IL_3a12: Expected Obj, but got VT
		//IL_363e: Expected VT, but got Ref
		//IL_1850: Expected VT, but got I
		//IL_1879: Expected Obj, but got I4
		//IL_3f9e: Invalid comparison between F4 and I
		//IL_3f46: Expected VT, but got F4
		//IL_09be: Expected Obj, but got VT
		//IL_09cc: Expected VT, but got F4
		//IL_09e1: Invalid comparison between VT and I4
		//IL_1faf: Expected F8, but got I4
		//IL_1fb7: Expected F4, but got VT
		//IL_2297: Invalid comparison between F8 and I4
		//IL_22a6: Expected F8, but got I4
		//IL_1a0c: Expected Obj, but got I4
		//IL_4c38: Expected Obj, but got VT
		//IL_4c47: Invalid comparison between VT and I4
		//IL_3603: Expected F8, but got I4
		//IL_360b: Expected F4, but got VT
		//IL_4297: Expected F4, but got I
		//IL_45a0: Expected F4, but got I4
		//IL_1a43: Expected F8, but got I
		//IL_1da7: Expected I4, but got Obj
		//IL_3a3e: Invalid comparison between VT and I4
		//IL_3c88: Invalid comparison between F8 and I4
		//IL_3c97: Invalid comparison between F8 and I4
		//IL_3cb1: Expected Obj, but got F8
		//IL_3cc0: Expected Obj, but got F8
		//IL_3cff: Expected Obj, but got I4
		//IL_3d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d0c: Expected Obj, but got Unknown
		//IL_3656: Expected VT, but got Ref
		//IL_3672: Expected VT, but got Ref
		//IL_367a: Expected VT, but got F4
		//IL_368b: Expected F8, but got I4
		//IL_369b: Expected F4, but got VT
		//IL_4d9f: Expected VT, but got F4
		//IL_4d5f: Expected VT, but got F4
		//IL_0a00: Expected Obj, but got VT
		//IL_0a22: Expected VT, but got F4
		//IL_0a54: Expected VT, but got F4
		//IL_0a5d: Expected F4, but got I4
		//IL_21ab: Expected Obj, but got I4
		//IL_21b4: Expected F4, but got I4
		//IL_0c64: Expected Obj, but got I4
		//IL_0c6d: Expected VT, but got I4
		//IL_3a87: Expected Obj, but got VT
		//IL_3aa6: Expected VT, but got F4
		//IL_3ab1: Expected Obj, but got I4
		//IL_3d39: Expected Obj, but got I4
		//IL_4697: Invalid comparison between F4 and I4
		//IL_46aa: Expected Obj, but got F4
		//IL_46b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_46b7: Expected Obj, but got Unknown
		//IL_46e9: Expected Obj, but got I4
		//IL_22f8: Expected F8, but got I4
		//IL_10bb: Expected Obj, but got I4
		//IL_1a8a: Expected F8, but got I4
		//IL_1a92: Expected F4, but got VT
		//IL_3a5d: Expected Obj, but got VT
		//IL_3a6b: Expected VT, but got F4
		//IL_37c8: Expected F8, but got I
		//IL_0ae3: Expected VT, but got F4
		//IL_0aec: Expected F4, but got I4
		//IL_21d5: Expected F4, but got I4
		//IL_44aa: Expected Obj, but got I4
		//IL_4c81: Expected Obj, but got VT
		//IL_4c9f: Expected Obj, but got I4
		//IL_4ca8: Expected F4, but got I4
		//IL_3806: Expected VT, but got F4
		//IL_381b: Expected I4, but got VT
		//IL_3706: Unknown result type (might be due to invalid IL or missing references)
		//IL_370b: Expected Obj, but got Unknown
		//IL_3725: Expected Obj, but got I4
		//IL_4719: Expected Obj, but got I4
		//IL_4731: Invalid comparison between F4 and I4
		//IL_4753: Expected Obj, but got I4
		//IL_1152: Expected Obj, but got I4
		//IL_3d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d4c: Expected Obj, but got Unknown
		//IL_3d66: Expected Obj, but got I4
		//IL_3d6e: Expected VT, but got F4
		//IL_3d86: Expected I4, but got VT
		//IL_3792: Expected VT, but got F4
		//IL_37a2: Expected I4, but got VT
		//IL_3fed: Expected I4, but got VT
		//IL_4791: Invalid comparison between F4 and I
		//IL_10f6: Expected F8, but got I
		//IL_41cd: Expected VT, but got I4
		//IL_3b0d: Invalid comparison between VT and I4
		//IL_0ce3: Expected Obj, but got I4
		//IL_4007: Expected Obj, but got VT
		//IL_4024: Expected I4, but got VT
		//IL_3b2c: Expected Obj, but got VT
		//IL_3b3b: Expected VT, but got I4
		//IL_250f: Expected Obj, but got I4
		//IL_4260: Expected VT, but got I4
		//IL_4269: Expected Obj, but got I4
		//IL_427a: Expected F4, but got I4
		//IL_204b: Expected Obj, but got I4
		//IL_205c: Expected F4, but got I4
		//IL_0d01: Expected Obj, but got I4
		//IL_403e: Expected Obj, but got VT
		//IL_405b: Expected I4, but got VT
		//IL_3b49: Expected VT, but got I4
		//IL_3bd3: Expected Obj, but got I4
		//IL_3bdc: Expected Obj, but got I4
		//IL_3bed: Expected F4, but got I4
		//IL_0d69: Expected F8, but got I
		//IL_0d79: Invalid comparison between F4 and I
		//IL_0d8b: Expected Obj, but got I4
		//IL_0d94: Expected VT, but got I4
		//IL_4079: Expected F8, but got I
		//IL_409e: Expected VT, but got Ref
		//IL_2582: Expected F4, but got I4
		//IL_3c0e: Expected VT, but got I4
		//IL_3c28: Expected F4, but got I
		//IL_4150: Expected F4, but got VT
		//IL_4160: Expected F8, but got I
		//IL_416a: Expected VT, but got Ref
		//IL_4173: Expected VT, but got I4
		//IL_3c44: Expected Obj, but got I4
		//IL_3c5a: Expected F4, but got I4
		//IL_40ea: Expected VT, but got I4
		//IL_2443: Expected F4, but got I
		//IL_47ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_47b3: Expected Obj, but got Unknown
		//IL_242e: Expected F4, but got I
		//IL_24b1: Expected VT, but got I4
		//IL_24c2: Expected F4, but got I4
		//IL_0e3e: Expected Obj, but got I4
		//IL_2709: Invalid comparison between F4 and I4
		//IL_271b: Expected Obj, but got I4
		//IL_483a: Invalid comparison between F4 and I4
		//IL_0e5c: Expected Obj, but got I
		//IL_0e6c: Expected Obj, but got I4
		//IL_0ea3: Expected Obj, but got I4
		//IL_2733: Expected VT, but got I4
		//IL_274f: Expected Obj, but got I4
		//IL_0ed3: Expected VT, but got I4
		//IL_0ed3: Expected VT, but got I4
		//IL_0f01: Expected Obj, but got I4
		//IL_2834: Expected Obj, but got I4
		//IL_0f4b: Expected F8, but got I
		//IL_0f5b: Expected F8, but got I
		//IL_0f6b: Expected F8, but got I
		//IL_0f74: Expected Obj, but got I4
		//IL_0f7d: Expected VT, but got I4
		//IL_2a08: Expected VT, but got I4
		//IL_2a3d: Expected Obj, but got I4
		//IL_2a59: Invalid comparison between F8 and I4
		//IL_2a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a75: Expected Obj, but got Unknown
		//IL_285b: Expected VT, but got I4
		//IL_4ddb: Expected Obj, but got I4
		//IL_2a9e: Expected F8, but got I4
		//IL_279b: Expected VT, but got I4
		//IL_27bc: Expected Obj, but got I4
		//IL_27d5: Expected Obj, but got I4
		//IL_491b: Invalid comparison between F8 and I4
		//IL_492a: Invalid comparison between F8 and I4
		//IL_493d: Expected Obj, but got F8
		//IL_494a: Expected Obj, but got F8
		//IL_4991: Expected Obj, but got I4
		//IL_4999: Unknown result type (might be due to invalid IL or missing references)
		//IL_499e: Expected Obj, but got Unknown
		//IL_2aea: Invalid comparison between F8 and I4
		//IL_2af9: Expected F8, but got I4
		//IL_28f2: Expected Obj, but got I4
		//IL_2919: Expected VT, but got I4
		//IL_2937: Expected Obj, but got I4
		//IL_2950: Expected Obj, but got I4
		//IL_2971: Expected Obj, but got I4
		//IL_49e1: Expected Obj, but got I4
		//IL_30c4: Invalid comparison between F4 and I4
		//IL_30d7: Expected Obj, but got F4
		//IL_30df: Unknown result type (might be due to invalid IL or missing references)
		//IL_30e4: Expected Obj, but got Unknown
		//IL_3116: Expected Obj, but got I4
		//IL_2eb8: Expected Obj, but got I4
		//IL_2c63: Expected F4, but got I
		//IL_2c75: Invalid comparison between F4 and I
		//IL_4a08: Expected Obj, but got I4
		//IL_4a20: Invalid comparison between F4 and I4
		//IL_4a42: Expected Obj, but got I4
		//IL_4a7b: Invalid comparison between F4 and I4
		//IL_2f0c: Expected Obj, but got I
		//IL_2f37: Expected F4, but got I
		//IL_2ced: Expected F4, but got I
		//IL_2d4e: Invalid comparison between F4 and I4
		//IL_2d5d: Invalid comparison between F4 and I4
		//IL_2d75: Expected Obj, but got F8
		//IL_2d82: Expected Obj, but got F4
		//IL_2db7: Expected Obj, but got I4
		//IL_2dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc4: Expected Obj, but got Unknown
		//IL_31f9: Invalid comparison between F4 and I
		//IL_2f6e: Expected Obj, but got I
		//IL_3227: Expected Obj, but got I4
		//IL_4ab6: Invalid comparison between F4 and I
		//IL_3219: Expected Obj, but got I4
		//IL_2fe7: Expected Obj, but got I4
		//IL_3243: Expected Obj, but got I4
		//IL_4add: Invalid comparison between F4 and I
		//IL_3235: Expected Obj, but got I4
		//IL_325f: Expected Obj, but got I4
		//IL_3045: Expected Obj, but got I
		//IL_4b1b: Invalid comparison between F8 and I4
		//IL_4b2a: Expected F8, but got I4
		//IL_3251: Expected Obj, but got I4
		//IL_4b55: Expected Obj, but got I
		//IL_4b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b6c: Expected Obj, but got Unknown
		//IL_4b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b9d: Expected Obj, but got Unknown
		if (~(livesBelow ? 1u : 0u) == 0)
		{
			bool flag = Asleep();
			bool flag2 = !flag;
			object obj = !flag2;
			if (obj != null)
			{
				goto IL_00ba;
			}
		}
		bool flag3 = (byte)(~(Puppet__BackingField ? 1u : 0u)) != 0;
		object obj2 = !flag3;
		if (obj2 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v8+8]");
		float deltaTime;
		object obj8;
		object obj11;
		double num = default;
		double num12 = default;
		if ((nint)0 == 0)
		{
			deltaTime = Time.deltaTime;
			bool flag5 = (byte)(~(Dead__BackingField ? 1u : 0u)) != 0;
			object obj7 = !flag5;
			if (obj7 != null)
			{
				return;
			}
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E80]");
				obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1530 @ X0_v15+E4]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!GillaPitKill.Fallen((Vector3)0))
				{
					if (snareT > 0f)
					{
						Snare(deltaTime);
						return;
					}
					if (staggerT > 0f)
					{
						goto IL_4514;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1555 @ X0_v20+E4]");
					bool flag7 = (nint)0 == 0;
					object obj13 = !flag7;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag8 = Hurt__BackingField != null;
					bool flag9 = !flag8;
					object obj14 = 0;
					UnityEngine.Object obj15 = null;
					if (!flag9)
					{
						MonsterWounds monsterWounds = Hurt__BackingField;
						if ((object)Hurt__BackingField == null)
						{
							goto IL_42a9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
						num = 0.0;
						float num2 = monsterWounds.Wreck__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
						bool flag10 = !(num2 > 0f);
						obj14 = 0;
						obj15 = null;
						if (!flag10)
						{
							double num3 = (double)walkSpeed * 0.5;
							bool flag11 = !((double)speed > num3);
							obj14 = 0;
							num = speed;
							obj15 = null;
							if (!flag11)
							{
								float time = Time.time;
								bool flag12 = time < stumbleAt;
								obj14 = 0;
								num = stumbleAt;
								obj15 = null;
								if (!flag12)
								{
									bool flag13 = state__BackingField < (State)7;
									object obj16 = !flag13;
									object obj17 = state__BackingField - 7;
									bool flag14 = obj17 == null;
									object obj18 = !flag14;
									object obj19 = obj16 & obj18;
									if (obj19 == null)
									{
										object obj20 = 1 << (int)state__BackingField;
										object obj21 = obj20 & 0xD0;
										bool flag15 = obj21 == null;
										obj14 = 0;
										num = stumbleAt;
										obj15 = null;
										if (!flag15)
										{
											goto IL_0508;
										}
									}
									object obj22 = obj11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1707 @ X0_v351+E4]");
									bool flag16 = (nint)0 == 0;
									object obj23 = !flag16;
									if (obj23 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag17 = climb == null;
									bool flag18 = !flag17;
									obj14 = 0;
									num = stumbleAt;
									obj15 = null;
									if (!flag18)
									{
										bool flag19 = (byte)(~(lurking ? 1u : 0u)) != 0;
										object obj24 = !flag19;
										obj14 = 0;
										num = stumbleAt;
										obj15 = null;
										if (obj24 == null)
										{
											float time2 = Time.time;
											float num4 = UnityEngine.Random.Range(3.5f, 7f);
											float num5 = time2 + num4;
											MonsterWounds monsterWounds2 = Hurt__BackingField;
											stumbleAt = num5;
											if ((object)Hurt__BackingField != null)
											{
												bool flag20 = monsterWounds2.Wreck__BackingField < 0f;
												double num6 = 0.0;
												if (!flag20)
												{
													bool flag21 = !((double)monsterWounds2.Wreck__BackingField > 1.0);
													num6 = monsterWounds2.Wreck__BackingField;
													if (!flag21)
													{
														num6 = 1.0;
													}
												}
												double num7 = num6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADA8]");
												double num8 = num7 * 0.0;
												double num9 = num8 + 0.25;
												staggerT = (float)num9;
												Transform transform2 = base.transform;
												if ((object)transform2 != null)
												{
													Vector3 right = transform2.right;
													MonsterWounds monsterWounds3 = Hurt__BackingField;
													if ((object)Hurt__BackingField != null)
													{
														Transform transform3 = base.transform;
														if ((object)transform3 != null)
														{
															double num10 = (double)monsterWounds3.Side__BackingField * 1.5;
															double num11 = num12 * num10;
															double num13 = 0.25 * num10;
															double num14 = num9 * num10;
															Vector3 forward = transform3.forward;
															double num15 = (double)speed * 0.25;
															double num16 = num10 * num15;
															double num17 = 0.25 * num15;
															double num18 = num12 * num15;
															double num19 = num14 + num16;
															double num20 = num13 + num17;
															double num21 = num11 + num18;
															shove = (Vector3)num19;
															goto IL_4514;
														}
													}
												}
											}
											goto IL_42a9;
										}
									}
								}
							}
						}
					}
					goto IL_0508;
				}
				if ((object)cc != null)
				{
					cc.enabled = false;
					Transform transform4 = base.transform;
					if ((object)transform4 != null)
					{
						transform4.position = (Vector3)0;
						if ((object)cc != null)
						{
							cc.enabled = true;
							vy = 0f;
							PickWander((Vector3?)(object)0);
							return;
						}
					}
				}
			}
			goto IL_42a9;
		}
		goto IL_00ba;
		IL_00ba:
		speed = 0f;
		AnimSpeed__BackingField = 0f;
		return;
		IL_37b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+194]");
		double num22 = 0.0;
		Vector3 vector;
		WalkAway(vector);
		float time3 = Time.time;
		float num23 = (hearAt = time3 + 25f);
		float length = default;
		Vector3 euler = (Vector3)length;
		double num24 = 25.0;
		bool flag22 = (byte)(int)vector != 0;
		goto IL_43d6;
		IL_4447:
		Transform transform5 = base.transform;
		float num26;
		double num28;
		float num32;
		double num33;
		float num34;
		float num45;
		float num48;
		if ((object)transform5 != null)
		{
			Vector3 position2 = transform5.position;
			object obj25 = obj3;
			float num25 = num26 - num23;
			double num27 = num28 - num22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2723 @ X0_v47+E4]");
			bool flag23 = (nint)0 == 0;
			object obj26 = !flag23;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num29 = num25 * num25;
			double num30 = num27 * num27;
			float num31 = num29 + (float)num30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD80]");
			if (num31 < 0f)
			{
				Transform transform6 = base.transform;
				if ((object)transform6 == null)
				{
					goto IL_42a9;
				}
				Vector3 position3 = transform6.position;
				object obj27 = obj3;
				num25 = num32 - num31;
				num27 = num33 - num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2791 @ X0_v139+E4]");
				bool flag24 = (nint)0 == 0;
				object obj28 = !flag24;
				num34 = 0f;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num34 = 0f;
				}
			}
			float num35 = num25 * num25;
			double num36 = num27 * num27;
			float num37 = num35 + (float)num36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			if (num37 > 0f)
			{
				Transform transform7 = base.transform;
				if ((object)transform7 == null)
				{
					goto IL_42a9;
				}
				Vector3 forward2 = transform7.forward;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5EB4");
				double num38 = num27;
			}
			double num39 = -30.0 / 1117782016.0;
			bool flag25 = num39 < 0.0;
			double num40 = 0.0;
			if (!flag25)
			{
				bool flag26 = num39 > 1.0;
				num40 = 1.0;
				if (!flag26)
				{
					num40 = num39;
				}
			}
			double num41 = num40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC84]");
			double num42 = num41 * 0.0;
			double num43 = num42 + 1.0;
			double num44;
			if (~(weeping ? 1u : 0u) == 0)
			{
				num44 = 1114636288.0;
			}
			else
			{
				bool flag27 = !(num34 > speed);
				num44 = 10.0;
				if (!flag27)
				{
					num44 = 6.0;
				}
			}
			num45 = num34 * (float)num43;
			float num46 = deltaTime * (float)num44;
			float num47 = deltaTime * (float)num44;
			num48 = 0f - num47;
			float num49 = num45 - speed;
			bool flag28 = num49 < 0f;
			object obj29 = num49 ^ num49;
			object obj30 = num49 & obj29;
			bool flag29 = (nint)obj30 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			bool flag30 = flag28 == flag29;
			object obj31 = !flag30;
			object obj32 = ~obj31;
			if (obj32 != null)
			{
				num48 = num46;
			}
			bool flag31 = num49 < num46;
			object obj33 = !flag31;
			float num50 = num49 - num46;
			bool flag32 = num50 == 0f;
			float num51 = speed + num48;
			object obj34 = !flag32;
			object obj35 = obj33 & obj34;
			object obj36 = ~obj35;
			if (obj36 != null)
			{
				num51 = num45;
			}
			speed = num51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			if (!(num37 > 0f) || state__BackingField == (State)4)
			{
				goto IL_24c7;
			}
			Transform transform8 = base.transform;
			if ((object)transform8 != null)
			{
				Vector3 eulerAngles = transform8.eulerAngles;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5FD8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE604C");
				if (~(weeping ? 1u : 0u) == 0 && state__BackingField == (State)2)
				{
					double num52 = (double)turnSpeed * 3.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
					num48 = 0f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
					num48 = 0f;
					double num52 = turnSpeed;
					if (state__BackingField != (State)2)
					{
						num48 = 0.25f;
					}
				}
				object obj37 = this + 500;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE6078");
				Transform transform9 = base.transform;
				Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
				if ((object)transform9 != null)
				{
					transform9.rotation = (Quaternion)0;
					num46 = deltaTime;
					num45 = 0f;
					goto IL_24c7;
				}
			}
		}
		goto IL_42a9;
		IL_1fbc:
		float want = default;
		Vector3 vector2 = PryStep(deltaTime, ref want);
		double num53;
		num12 = num53;
		double num54;
		num = num54;
		flag22 = (byte)(&want) != 0;
		goto IL_07b0;
		IL_1feb:
		Vector3 vector3 = BreakStep(deltaTime, ref want);
		num12 = num53;
		double num55;
		num = num55;
		flag22 = (byte)(&want) != 0;
		goto IL_07b0;
		IL_42b7:
		throw new IndexOutOfRangeException();
		IL_2987:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
		speed = 0f;
		float num57;
		float num56 = num57;
		float num59;
		float num58 = num59;
		float num60 = num57;
		object obj39;
		object obj38 = obj39;
		float num62;
		float num61 = num62;
		goto IL_4851;
		IL_4514:
		Stagger(deltaTime);
		return;
		IL_3077:
		float num63 = lookWeightWant - LookWeight__BackingField;
		float num64 = deltaTime * 3f;
		float num65 = deltaTime * 3f;
		float num66 = 0f - num65;
		bool flag33 = num63 < 0f;
		object obj40 = num63 ^ num63;
		object obj41 = num63 & obj40;
		bool flag34 = (nint)obj41 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag35 = flag33 == flag34;
		object obj42 = !flag35;
		object obj43 = ~obj42;
		if (obj43 != null)
		{
			num66 = num64;
		}
		bool flag36 = num63 < num64;
		object obj44 = !flag36;
		float num67 = num63 - num64;
		bool flag37 = num67 == 0f;
		float num68 = LookWeight__BackingField + num66;
		object obj45 = !flag37;
		object obj46 = obj44 & obj45;
		object obj47 = ~obj46;
		if (obj47 != null)
		{
			num68 = lookWeightWant;
		}
		LookWeight__BackingField = num68;
		if (!(lookWeightWant > 0f))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+130]");
		float num69 = 0f - lookWeightWant;
		float num70 = (float)LookPoint__BackingField - num68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+134]");
		float num71 = 0f - num66;
		float num72 = num70 * num70;
		float num73 = num69 * num69;
		float num74 = num71 * num71;
		float num75 = num72 + num73;
		float num76 = num74 + num75;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if (num76 < 0f)
		{
			object obj48 = 388;
		}
		else
		{
			object obj48 = 304;
		}
		float num77 = deltaTime * -8f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if (num76 < 0f)
		{
			object obj49 = 384;
		}
		else
		{
			object obj49 = 300;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if (num76 < 0f)
		{
			object obj50 = 392;
		}
		else
		{
			object obj50 = 308;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num78 = 1.0 - (double)num77;
		bool flag38 = num78 < 0.0;
		double num79 = 0.0;
		if (!flag38)
		{
			bool flag39 = !(num78 > 1.0);
			num79 = num78;
			if (!flag39)
			{
				num79 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+188]");
		nint num80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+v403 @ X8_v45]");
		object obj51 = num80 - 0;
		Vector3 vector4 = lookWant;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+v193 @ X10_v7]");
		object obj52 = vector4 - 0;
		object obj54 = default;
		object obj53 = obj52 * obj54;
		double num81 = (double)obj51 * num79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+v193 @ X10_v7]");
		object obj55 = 0 + obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+v403 @ X8_v45]");
		double num82 = 0.0 + num81;
		object obj56 = obj55;
		return;
		IL_0508:
		object obj57;
		if (~(weeping ? 1u : 0u) != 0 || state__BackingField == (State)4)
		{
			obj57 = 0;
		}
		else
		{
			GatherTargets();
			if (Watched())
			{
				Hold(deltaTime);
				return;
			}
			obj57 = 1;
		}
		if (ignoreT > 0f)
		{
			float num83 = ignoreT - deltaTime;
			ignoreT = num83;
		}
		float num84 = deltaTime + stateT;
		stateT = num84;
		bool flag40 = StoodTooLong(deltaTime);
		bool flag41 = !flag40;
		object obj58 = !flag41;
		if (obj58 != null)
		{
			return;
		}
		object obj59 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1700 @ X0_v28+E4]");
		bool flag42 = (nint)0 == 0;
		object obj60 = !flag42;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (climb != null)
		{
			Climb(deltaTime);
			return;
		}
		if (~(lurking ? 1u : 0u) == 0)
		{
			Lurk(deltaTime);
			return;
		}
		object obj61 = obj57 & 1;
		bool flag43 = obj61 == null;
		object obj62 = !flag43;
		if (obj62 == null)
		{
			GatherTargets();
		}
		float num85;
		bool flag45;
		ref MonsterCatalog.Target reference;
		if (~(hasPrey ? 1u : 0u) == 0)
		{
			num85 = (float)prey;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+1C0]");
			num = 0.0;
			reference = ref *(MonsterCatalog.Target*)(this + 432);
			object obj63 = default;
			bool flag44 = Find((MonsterCatalog.Target)(&obj63), out reference);
			flag45 = flag44;
		}
		else
		{
			reference = ref *(MonsterCatalog.Target*)null;
			num85 = deltaTime;
			flag45 = false;
		}
		Transform transform10 = base.transform;
		if ((object)transform10 == null)
		{
			goto IL_42a9;
		}
		obj56 = this + 300;
		Vector3 position4 = transform10.position;
		lookWeightWant = 0f;
		if (~(weeping ? 1u : 0u) == 0)
		{
			object obj64 = (long)state__BackingField & 0xFFFFFFFEL;
			if ((nint)obj64 != 4)
			{
				Vector3 vector5 = Weep(deltaTime, flag45, ref want);
				reference = ref *(MonsterCatalog.Target*)(&want);
				flag22 = flag45;
				goto IL_07b0;
			}
		}
		float num86;
		double num87;
		double num88;
		State state;
		float num94;
		object obj77;
		float num100;
		double num101;
		float num102;
		double num103;
		double num104;
		if (state__BackingField <= (State)3)
		{
			if (state__BackingField <= (State)1)
			{
				if (state__BackingField != 0)
				{
					bool flag46 = state__BackingField != (State)1;
					euler = (Vector3)length;
					want = 0f;
					num86 = num85;
					num87 = num12;
					num22 = num12;
					num24 = num;
					num88 = num;
					flag22 = false;
					num23 = num85;
					if (!flag46)
					{
						if (flag45)
						{
							if (prey != (MonsterCatalog.Target)(object)0)
							{
								Vector3 position5 = ((Transform)prey).position;
								if (prey != (MonsterCatalog.Target)(object)0)
								{
									Vector3 position6 = ((Transform)prey).position;
									lastSeen = (Vector3)num85;
									if (prey != (MonsterCatalog.Target)(object)0)
									{
										Vector3 position7 = ((Transform)prey).position;
										double num89 = stateT;
										double num90 = noticeFor;
										lookWant = (Vector3)num85;
										lookWeightWant = 1f;
										bool flag47 = !(stateT > noticeFor);
										euler = (Vector3)length;
										want = 0f;
										num86 = num85;
										num87 = num12;
										num22 = num12;
										num24 = num;
										num88 = num;
										flag22 = false;
										num23 = num85;
										if (!flag47)
										{
											reachedFor = 0f;
											state__BackingField = (State)2;
											Chasing__BackingField = true;
											listening = false;
											stateT = 0f;
											euler = (Vector3)length;
											want = 0f;
											num86 = num85;
											num87 = num12;
											num22 = num12;
											num24 = num;
											num88 = num;
											flag22 = false;
											num23 = num85;
										}
										goto IL_43d6;
									}
								}
							}
							goto IL_42a9;
						}
						state__BackingField = (State)0;
						Chasing__BackingField = false;
						num24 = num;
						flag22 = false;
						num23 = num85;
						goto IL_4bc6;
					}
				}
				else
				{
					if (Spot(out var seen))
					{
						Chasing__BackingField = false;
						state__BackingField = (State)1;
						stateT = 0f;
						reachedFor = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
						nint num91 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						num23 = UnityEngine.Random.Range(num91, 0f);
						listening = false;
						noticeFor = num23;
						prey = seen;
						_ = 0;
						want = 0f;
						num86 = num85;
						num87 = num12;
						num22 = 0.0;
						num24 = (double)seen;
						num88 = num;
						state = (State)1;
						goto IL_45ce;
					}
					if (Hear(out var heard))
					{
						object obj65 = default;
						Investigate((MonsterCatalog.Target)(&obj65));
						euler = (Vector3)length;
						want = 0f;
						num86 = num85;
						num87 = num12;
						num22 = num12;
						num24 = 0.0;
						num88 = num;
						flag22 = (byte)(&obj65) != 0;
						num23 = (float)heard;
					}
					else if (wait > 0f)
					{
						num23 = (wait -= deltaTime);
						float dt = num23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
						Glance(dt, 0f);
						euler = (Vector3)length;
						want = 0f;
						num86 = num85;
						num87 = num12;
						num22 = num12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
						num24 = 0.0;
						num88 = num;
						flag22 = (byte)(&heard) != 0;
					}
					else
					{
						if (~(wallCrawler ? 1u : 0u) == 0)
						{
							float time4 = Time.time;
							if (!(time4 < nextLurk))
							{
								bool flag48 = StartLurk();
								bool flag49 = !flag48;
								object obj66 = !flag49;
								if (obj66 != null)
								{
									return;
								}
							}
						}
						num86 = (float)wanderTarget;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+160]");
						num88 = 0.0;
						float num92 = walkSpeed * gait;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+164]");
						num87 = 0.0;
						Transform transform11 = base.transform;
						if ((object)transform11 == null)
						{
							goto IL_42a9;
						}
						Vector3 position8 = transform11.position;
						object obj67 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2729 @ X0_v314+E4]");
						bool flag50 = (nint)0 == 0;
						object obj68 = !flag50;
						if (obj68 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
						num24 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
						if (!(num92 < 0f))
						{
							bool flag51 = Stuck(deltaTime);
							bool flag52 = !flag51;
							euler = (Vector3)length;
							want = num92;
							num22 = num12;
							flag22 = false;
							num23 = deltaTime;
							if (flag52)
							{
								goto IL_43d6;
							}
						}
						PickWander((Vector3?)(object)0);
						float value = UnityEngine.Random.value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						float num93;
						float minInclusive;
						if (value < 0f)
						{
							num93 = 7f;
							minInclusive = 4f;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
							minInclusive = 0f;
							num93 = 3.5f;
						}
						num23 = (wait = UnityEngine.Random.Range(minInclusive, num93));
						euler = (Vector3)length;
						want = num92;
						reference = ref *(MonsterCatalog.Target*)null;
						num22 = num12;
						num24 = num93;
						flag22 = false;
					}
				}
			}
			else
			{
				if (state__BackingField == (State)2)
				{
					num94 = Time.time;
					double num95 = easiestAt;
					if (num94 < easiestAt)
					{
						bool flag53 = !flag45;
						object obj69 = !flag53;
						if (obj69 != null)
						{
							goto IL_33cb;
						}
						num24 = num95;
						flag22 = false;
						num23 = num94;
					}
					else
					{
						float time5 = Time.time;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
						num95 = 0.0;
						float num96 = time5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
						num94 = (easiestAt = num96 + 0f);
						bool flag54 = GoForEasiest(flag45);
						object obj70 = flag54 | flag45;
						object obj71 = obj70 & 1;
						bool flag55 = obj71 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
						num24 = 0.0;
						flag22 = flag45;
						num23 = num94;
						if (!flag55)
						{
							goto IL_33cb;
						}
					}
					goto IL_34bf;
				}
				bool flag56 = state__BackingField != (State)3;
				euler = (Vector3)length;
				want = 0f;
				num86 = num85;
				num87 = num12;
				num22 = num12;
				num24 = num;
				num88 = num;
				flag22 = false;
				num23 = num85;
				if (!flag56)
				{
					num86 = (float)lastSeen;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+190]");
					num88 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+194]");
					num87 = 0.0;
					Transform transform12 = base.transform;
					if ((object)transform12 == null)
					{
						goto IL_42a9;
					}
					Vector3 position9 = transform12.position;
					object obj72 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2461 @ X0_v287+E4]");
					bool flag57 = (nint)0 == 0;
					object obj73 = !flag57;
					if (obj73 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
					if ((double)num85 > 1.0)
					{
						float num97 = walkSpeed;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
						num85 = num97 * 0f;
						bool flag58 = num85 < 0f;
						object obj74 = !flag58;
						bool flag59 = num85 == 0f;
						object obj75 = ~obj74;
						object obj76 = obj75 | flag59;
						want = num85;
						if (obj76 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X23_v7+60]");
							lookWant = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+194]");
							_ = 0;
							lookWeightWant = 0.6f;
							want = num85;
							obj77 = 1;
							goto IL_4540;
						}
					}
					else
					{
						want = 0f;
					}
					Glance(num85, 1f);
					obj77 = 0;
					goto IL_4540;
				}
			}
		}
		else if (state__BackingField <= (State)5)
		{
			if (state__BackingField == (State)4)
			{
				ref MonsterCatalog.Target reference2;
				double num98;
				bool flag63;
				float num99;
				if (~(killLocal ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
					object obj78 = 0;
					object obj79 = obj11;
					object obj80 = obj78;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2274 @ X8_v111+A0]");
					object obj81 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2273 @ X0_v236+E4]");
					bool flag60 = (nint)0 == 0;
					object obj82 = !flag60;
					if (obj82 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag61 = (UnityEngine.Object)obj81 == null;
					bool flag62 = !flag61;
					object obj83 = !flag62;
					reference2 = ref *(MonsterCatalog.Target*)null;
					num98 = num;
					flag63 = false;
					num99 = num85;
					if (obj83 == null)
					{
						object obj84 = obj78;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2474 @ X8_v113+A0]");
						object obj85 = 0;
						object obj86 = obj85;
						if (obj85 == null)
						{
							goto IL_42a9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X8_v115+A9]");
						bool flag64 = (nint)0 == 0;
						reference2 = ref *(MonsterCatalog.Target*)null;
						num98 = num;
						flag63 = false;
						num99 = num85;
						if (!flag64)
						{
							object obj87 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2642 @ X0_v240+E4]");
							bool flag65 = (nint)0 == 0;
							object obj88 = !flag65;
							if (obj88 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X8_v115+C0]");
							bool flag66 = (UnityEngine.Object)0 != this;
							bool flag67 = !flag66;
							euler = (Vector3)length;
							want = 0f;
							num86 = num85;
							num87 = num12;
							reference = ref *(MonsterCatalog.Target*)null;
							num22 = num12;
							num24 = num;
							num88 = num;
							flag22 = (byte)(int)this != 0;
							num23 = num85;
							if (flag67)
							{
								goto IL_43d6;
							}
							reference2 = ref *(MonsterCatalog.Target*)null;
							num98 = num;
							flag63 = (byte)(int)this != 0;
							num99 = num85;
						}
					}
				}
				else
				{
					num99 = stateT;
					num98 = killSeconds;
					bool flag68 = !(stateT > killSeconds);
					reference2 = ref reference;
					flag63 = false;
					euler = (Vector3)length;
					want = 0f;
					num86 = num85;
					num87 = num12;
					num22 = num12;
					num24 = killSeconds;
					num88 = num;
					flag22 = false;
					num23 = stateT;
					if (flag68)
					{
						goto IL_43d6;
					}
				}
				if (~(despawnAfterKill ? 1u : 0u) == 0)
				{
					GameObject obj89 = gameObject;
					object obj90 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v110+E4]");
					bool flag69 = (nint)0 == 0;
					object obj91 = !flag69;
					if (obj91 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj89);
					return;
				}
				Chasing__BackingField = false;
				state__BackingField = (State)5;
				reference = ref reference2;
				num24 = num98;
				flag22 = flag63;
				num23 = num99;
				goto IL_4bc6;
			}
			bool flag70 = state__BackingField != (State)5;
			euler = (Vector3)length;
			want = 0f;
			num86 = num85;
			num87 = num12;
			num22 = num12;
			num24 = num;
			num88 = num;
			flag22 = false;
			num23 = num85;
			if (!flag70)
			{
				num100 = stateT;
				num101 = recoverSeconds;
				bool flag71 = !(stateT > recoverSeconds);
				want = 0f;
				num102 = num85;
				num103 = num12;
				num104 = num;
				euler = (Vector3)length;
				want = 0f;
				num86 = num85;
				num87 = num12;
				num22 = num12;
				num24 = recoverSeconds;
				num88 = num;
				flag22 = false;
				num23 = stateT;
				if (!flag71)
				{
					goto IL_12f0;
				}
			}
		}
		else
		{
			if (state__BackingField == (State)6)
			{
				bool flag72 = Spot(out var seen2);
				bool flag73 = !flag72;
				num53 = num12;
				num54 = num;
				if (!flag73)
				{
					bool flag74 = InReach((Transform)seen2);
					bool flag75 = !flag74;
					num53 = num12;
					num54 = num;
					if (!flag75)
					{
						if (seen2 != (MonsterCatalog.Target)(object)0)
						{
							Vector3 position10 = ((Transform)seen2).position;
							Transform transform13 = base.transform;
							if ((object)transform13 != null)
							{
								Vector3 position11 = transform13.position;
								object obj92 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2755 @ X0_v205+E4]");
								bool flag76 = (nint)0 == 0;
								object obj93 = !flag76;
								if (obj93 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
								num53 = 0.0;
								double num105 = grabRange;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
								num54 = num105 * 0.0;
								if (!((double)num85 < num54))
								{
									goto IL_1fbc;
								}
								EndPry();
								num24 = 0.0;
								num23 = (float)seen2;
								goto IL_456b;
							}
						}
						goto IL_42a9;
					}
				}
				goto IL_1fbc;
			}
			bool flag77 = state__BackingField != (State)7;
			euler = (Vector3)length;
			want = 0f;
			num86 = num85;
			num87 = num12;
			num22 = num12;
			num24 = num;
			num88 = num;
			flag22 = false;
			num23 = num85;
			if (!flag77)
			{
				bool flag78 = Spot(out var seen3);
				bool flag79 = !flag78;
				num53 = num12;
				num55 = num;
				if (!flag79)
				{
					bool flag80 = InReach((Transform)seen3);
					bool flag81 = !flag80;
					num53 = num12;
					num55 = num;
					if (!flag81)
					{
						if (seen3 != (MonsterCatalog.Target)(object)0)
						{
							Vector3 position12 = ((Transform)seen3).position;
							Transform transform14 = base.transform;
							if ((object)transform14 != null)
							{
								Vector3 position13 = transform14.position;
								object obj94 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2775 @ X0_v223+E4]");
								bool flag82 = (nint)0 == 0;
								object obj95 = !flag82;
								if (obj95 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
								num53 = 0.0;
								double num106 = grabRange;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
								num55 = num106 * 0.0;
								if (!((double)num85 < num55))
								{
									goto IL_1feb;
								}
								EndPry();
								num24 = 0.0;
								num23 = (float)seen3;
								goto IL_456b;
							}
						}
						goto IL_42a9;
					}
				}
				goto IL_1feb;
			}
		}
		goto IL_43d6;
		IL_24c7:
		if ((object)cc != null)
		{
			bool isGrounded = cc.isGrounded;
			bool flag83 = !isGrounded;
			object obj96 = !flag83;
			float num107 = -1f;
			if (obj96 == null)
			{
				num45 = vy;
				float num108 = deltaTime * gravity;
				num107 = vy - num108;
			}
			vy = num107;
			Transform transform15 = base.transform;
			if ((object)transform15 != null)
			{
				Vector3 forward3 = transform15.forward;
				bool flag84 = state__BackingField == (State)4;
				float num109 = 0f;
				if (!flag84)
				{
					num109 = speed;
				}
				Transform transform16 = base.transform;
				if ((object)transform16 != null)
				{
					Vector3 position14 = transform16.position;
					Transform transform17 = base.transform;
					if ((object)transform17 != null)
					{
						Vector3 forward4 = transform17.forward;
						if ((object)cc != null)
						{
							float num110 = num107 * num109;
							float num111 = num45 * num109;
							num60 = num48 * num109;
							float num112 = deltaTime * num110;
							float num113 = deltaTime * num111;
							float num114 = deltaTime * num60;
							float num115 = num112 + num107;
							float num116 = num113 + num45;
							float num117 = num114 + num48;
							float radius = cc.radius;
							num56 = num107 * radius;
							float num118 = num45 * radius;
							num58 = speed;
							num61 = num48 * radius;
							float num119 = num115 + num56;
							float num120 = num116 + num118;
							float num121 = num117 + num61;
							bool flag85 = !(speed > 0f);
							obj38 = 0;
							if (!flag85)
							{
								bool flag86 = MonsterNavMesh.Barred((Vector3)0);
								bool flag87 = !flag86;
								obj38 = 0;
								if (!flag87)
								{
									Transform transform18 = base.transform;
									if ((object)transform18 == null)
									{
										goto IL_42a9;
									}
									Vector3 position15 = transform18.position;
									bool flag88 = MonsterNavMesh.Barred((Vector3)0);
									bool flag89 = !flag88;
									obj38 = 0;
									num57 = num121;
									num59 = num120;
									obj39 = 0;
									num62 = num119;
									if (flag89)
									{
										goto IL_2987;
									}
								}
								num58 = speed;
								num56 = num121;
								num61 = num119;
							}
							if (num58 > 0f)
							{
								object obj97 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3352 @ X0_v93+E4]");
								bool flag90 = (nint)0 == 0;
								object obj98 = !flag90;
								if (obj98 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag91 = GillaPitKill.InRoom((Vector3)0);
								bool flag92 = !flag91;
								num56 = num121;
								num58 = num120;
								num61 = num119;
								if (!flag92)
								{
									Transform transform19 = base.transform;
									if ((object)transform19 == null)
									{
										goto IL_42a9;
									}
									Vector3 position16 = transform19.position;
									object obj99 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3503 @ X0_v100+E4]");
									bool flag93 = (nint)0 == 0;
									object obj100 = !flag93;
									if (obj100 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag94 = GillaPitKill.InRoom((Vector3)0);
									bool flag95 = !flag94;
									object obj101 = !flag95;
									num57 = num121;
									num59 = num120;
									obj39 = 0;
									num62 = num119;
									num56 = num121;
									num58 = num120;
									obj38 = 0;
									num61 = num119;
									if (obj101 == null)
									{
										goto IL_2987;
									}
								}
							}
							goto IL_4851;
						}
					}
				}
			}
		}
		goto IL_42a9;
		IL_4851:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
		if ((object)cc != null)
		{
			float num122 = num56 * vy;
			float num123 = num60 + num122;
			float num124 = deltaTime * num123;
			CollisionFlags collisionFlags = cc.Move((Vector3)0);
			double num125 = speed;
			float num126 = walkSpeed;
			bool flag96 = speed < walkSpeed;
			object obj102 = !flag96;
			double num127 = (double)speed - (double)walkSpeed;
			bool flag97 = num127 == 0.0;
			object obj103 = ~obj102;
			object obj104 = obj103 | flag97;
			double num132;
			double num136;
			if (obj104 == null)
			{
				bool flag98 = walkSpeed == runSpeed;
				double num128 = 0.0;
				if (!flag98)
				{
					double num129 = (double)speed - (double)walkSpeed;
					float num130 = runSpeed - walkSpeed;
					double num131 = num129 / (double)num130;
					bool flag99 = num131 < 0.0;
					num128 = 0.0;
					if (!flag99)
					{
						bool flag100 = num131 > 1.0;
						num128 = 1.0;
						if (!flag100)
						{
							num128 = num131;
						}
					}
				}
				float num46 = clipRunSpeed;
				num126 /= clipWalkSpeed;
				num132 = num128 + 1.0;
				float num133 = runSpeed / clipRunSpeed;
				float num134 = num133 - num126;
				double num135 = (double)num134 * num128;
				num136 = (double)num126 + num135;
				num125 = 1.0;
				num124 = (float)num135;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				double num137 = speed;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				num132 = num137 / 0.0;
				double num128 = clipWalkSpeed;
				num136 = (double)walkSpeed / (double)clipWalkSpeed;
			}
			object obj105 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3497 @ X0_v69+E4]");
			bool flag101 = (nint)0 == 0;
			object obj106 = !flag101;
			if (obj106 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag102 = Hurt__BackingField != null;
			bool flag103 = !flag102;
			double num138 = 0.5;
			if (!flag103)
			{
				MonsterWounds monsterWounds4 = Hurt__BackingField;
				if ((object)Hurt__BackingField == null)
				{
					goto IL_42a9;
				}
				num124 = monsterWounds4.Pace__BackingField;
				bool flag104 = !((double)monsterWounds4.Pace__BackingField < 1.0);
				double num128 = 1.0;
				num138 = 0.5;
				if (!flag104)
				{
					num128 = speed;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
					num124 = 0f;
					float num139 = speed;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
					bool flag105 = !(num139 > 0f);
					num138 = 0.5;
					if (!flag105)
					{
						num124 = walkSpeed;
						bool flag106 = !(speed < walkSpeed);
						num138 = 0.5;
						if (!flag106)
						{
							num125 = clipWalkSpeed;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
							float num46 = 0f;
							float num140 = walkSpeed * 0.25f;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
							num124 = speed / num140;
							num136 = (double)speed / (double)clipWalkSpeed;
							float num141 = num124 - 1f;
							bool flag107 = num141 < 0f;
							bool flag108 = num141 == 0f;
							object obj107 = (double)num124 ^ 1.0;
							object obj108 = num124 ^ num141;
							object obj109 = obj107 & obj108;
							bool flag109 = (nint)obj109 < 0;
							bool flag110 = flag107 == flag109;
							object obj110 = !flag108;
							object obj111 = flag110 & obj110;
							object obj112 = ~obj111;
							if (obj112 == null)
							{
								num128 = 1.0;
								num132 = 1.0;
								num138 = 0.25;
							}
							else
							{
								num128 = 1.0;
								num132 = num124;
								num138 = 0.25;
							}
						}
					}
				}
			}
			double num142 = num138 - num136;
			bool flag111 = num142 < 0.0;
			bool flag112 = num142 == 0.0;
			object obj113 = num138 ^ num136;
			object obj114 = num138 ^ num142;
			object obj115 = obj113 & obj114;
			bool flag113 = (nint)obj115 < 0;
			object obj116 = obj11;
			AnimSpeed__BackingField = (float)num132;
			bool flag114 = flag111 == flag113;
			object obj117 = !flag112;
			object obj118 = flag114 & obj117;
			object obj119 = ~obj118;
			if (obj119 != null)
			{
				num138 = num136;
			}
			AnimPace__BackingField = (float)num138;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3586 @ X0_v73+E4]");
			bool flag115 = (nint)0 == 0;
			object obj120 = !flag115;
			if (obj120 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag116 = this.animator != null;
			bool flag117 = !flag116;
			bool flag118 = false;
			int num143 = 0;
			if (flag117)
			{
				goto IL_3077;
			}
			object obj121 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3608 @ X0_v81+E4]");
			bool flag119 = (nint)0 == 0;
			object obj122 = !flag119;
			if (obj122 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)this.animator != null)
			{
				object obj123 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3640 @ X8_v49+A0]");
				object obj124 = 0;
				Animator animator = this.animator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3642 @ X8_v50+10]");
				nint num144 = 0;
				double num145 = num132;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				animator.SetFloat((int)num144, (float)num145, 0f, deltaTime);
				if ((object)this.animator != null)
				{
					object obj125 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3657 @ X8_v52+A0]");
					object obj126 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3658 @ X8_v53+14]");
					num143 = 0;
					Animator animator2 = this.animator;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3658 @ X8_v53+14]");
					animator2.SetFloat(0, AnimPace__BackingField);
					bool flag120 = (byte)(~(hasPry ? 1u : 0u)) != 0;
					flag118 = false;
					if (!flag120)
					{
						object obj127 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3666 @ X0_v85+E4]");
						bool flag121 = (nint)0 == 0;
						object obj128 = !flag121;
						if (obj128 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if ((object)this.animator == null)
						{
							goto IL_42a9;
						}
						object obj129 = obj3;
						flag118 = Prying__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3697 @ X8_v56+A0]");
						object obj130 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3619 @ X8_v57+1C]");
						num143 = 0;
						Animator animator3 = this.animator;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3619 @ X8_v57+1C]");
						animator3.SetBool(0, Prying__BackingField);
					}
					goto IL_3077;
				}
			}
		}
		goto IL_42a9;
		IL_42a9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_42b7;
		IL_0f9a:
		bool flag122 = state__BackingField < (State)3;
		object obj131 = !flag122;
		object obj132 = state__BackingField - 3;
		bool flag123 = obj132 == null;
		object obj133 = !flag123;
		object obj134 = obj131 & obj133;
		num32 = num86;
		num33 = num87;
		Vector3 goal;
		object obj138;
		if (obj134 == null)
		{
			bool flag124 = state__BackingField == (State)1;
			num32 = num86;
			num33 = num87;
			if (!flag124)
			{
				num23 = Time.time;
				num24 = doorCheckAt;
				bool flag125 = num23 < doorCheckAt;
				num32 = num86;
				num33 = num87;
				if (!flag125)
				{
					float time6 = Time.time;
					float num146 = time6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					float num147 = num146 + 0f;
					doorCheckAt = num147;
					bool flag126 = (byte)(~(pries ? 1u : 0u)) != 0;
					object obj135 = !flag126;
					double num89 = 3.5;
					if (obj135 == null)
					{
						if (!breaksDoors)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
							num89 = 0.0;
						}
						else
						{
							num89 = 2.5;
						}
					}
					GillaDoor gillaDoor = DoorInWay(goal, num86);
					object obj136 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2618 @ X8_v77+E4]");
					bool flag127 = (nint)0 == 0;
					object obj137 = !flag127;
					if (obj137 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag128 = gillaDoor != null;
					bool flag129 = !flag128;
					num32 = num86;
					num33 = num87;
					obj138 = 0;
					num22 = num87;
					num24 = num88;
					num23 = num86;
					if (!flag129)
					{
						if (~(pries ? 1u : 0u) == 0)
						{
							BeginPry(gillaDoor);
						}
						else
						{
							if (~(breaksDoors ? 1u : 0u) != 0)
							{
								if (state__BackingField != (State)3)
								{
									bool flag130 = state__BackingField == 0;
									object obj139 = !flag130;
									obj138 = 0;
									num24 = num88;
									num34 = 0f;
									num23 = num86;
									if (obj139 == null)
									{
										PickWander((Vector3?)(object)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
										num23 = (wait = UnityEngine.Random.Range(0f, 2f));
										obj138 = 0;
										num24 = 2.0;
										num34 = 0f;
									}
								}
								else
								{
									state__BackingField = (State)0;
									Chasing__BackingField = false;
									stateT = 0f;
									reachedFor = 0f;
									listening = false;
									hasPrey = false;
									PickWander((Vector3?)(object)0);
									obj138 = 0;
									num24 = num88;
									num34 = 0f;
									num23 = num86;
								}
								goto IL_4ceb;
							}
							BeginBreak(gillaDoor);
						}
						obj138 = 0;
						num24 = num88;
						num34 = 0f;
						num23 = num86;
						goto IL_4ceb;
					}
				}
			}
		}
		goto IL_4447;
		IL_456b:
		state__BackingField = (State)2;
		Chasing__BackingField = true;
		stateT = 0f;
		reachedFor = 0f;
		want = 0f;
		num86 = num85;
		num87 = num12;
		num12 = num53;
		num88 = num;
		state = (State)1;
		goto IL_4d8a;
		IL_4ceb:
		num32 = num86;
		num33 = num87;
		num22 = num87;
		goto IL_4447;
		IL_4d8a:
		listening = false;
		prey = (MonsterCatalog.Target)num23;
		num22 = num12;
		goto IL_45ce;
		IL_4540:
		if (Spot(out var seen4))
		{
			Chasing__BackingField = false;
			state__BackingField = (State)1;
			stateT = 0f;
			reachedFor = 0f;
			noticeFor = 0.25f;
			num24 = 0.0;
			num23 = (float)seen4;
			state = (State)1;
			goto IL_4d8a;
		}
		bool flag131 = Hear(out var heard2);
		bool flag132 = !flag131;
		vector = (Vector3)(&heard2);
		if (!flag132)
		{
			object obj140 = default;
			Investigate((MonsterCatalog.Target)(&obj140));
			bool flag133 = state__BackingField != (State)3;
			vector = (Vector3)(&obj140);
			euler = (Vector3)length;
			num22 = num12;
			num24 = 0.0;
			flag22 = (byte)(&obj140) != 0;
			num23 = (float)heard2;
			if (flag133)
			{
				goto IL_43d6;
			}
		}
		if (~(listening ? 1u : 0u) == 0)
		{
			float time7 = Time.time;
			float num148 = time7 - listeningSince;
			if (!((double)num148 > 12.0))
			{
				object obj141 = obj77 & 1;
				bool flag134 = obj141 == null;
				object obj142 = !flag134;
				num24 = 12.0;
				if (obj142 == null)
				{
					num24 = stateT;
					if ((double)stateT > 4.0)
					{
						goto IL_37b8;
					}
				}
				bool flag135 = Stuck(deltaTime);
				bool flag136 = !flag135;
				euler = (Vector3)length;
				num22 = num12;
				flag22 = (byte)(int)vector != 0;
				num23 = deltaTime;
				if (flag136)
				{
					goto IL_43d6;
				}
			}
			goto IL_37b8;
		}
		num101 = stateT;
		double num149 = (double)stateT - 4.0;
		bool flag137 = num149 < 0.0;
		bool flag138 = num149 == 0.0;
		object obj143 = (double)stateT ^ 4.0;
		object obj144 = (double)stateT ^ num149;
		object obj145 = obj143 & obj144;
		bool flag139 = (nint)obj145 < 0;
		num100 = searchFor;
		bool flag140 = flag137 == flag139;
		object obj146 = !flag138;
		object obj147 = flag140 & obj146;
		object obj148 = ~obj147;
		object obj149 = ((obj148 != null) ? ((object)1) : obj77);
		bool flag141 = num101 > (double)num100;
		num102 = num86;
		num103 = num87;
		num104 = num88;
		if (!flag141)
		{
			object obj150 = obj149 & 1;
			bool flag142 = obj150 == null;
			object obj151 = !flag142;
			euler = (Vector3)length;
			num22 = num12;
			num24 = num101;
			flag22 = (byte)(int)vector != 0;
			num23 = num100;
			if (obj151 != null)
			{
				goto IL_43d6;
			}
			num102 = num86;
			num103 = num87;
			num104 = num88;
		}
		goto IL_12f0;
		IL_12f0:
		state__BackingField = (State)0;
		Chasing__BackingField = false;
		stateT = 0f;
		reachedFor = 0f;
		listening = false;
		hasPrey = false;
		PickWander((Vector3?)(object)0);
		euler = (Vector3)length;
		num86 = num102;
		num87 = num103;
		reference = ref *(MonsterCatalog.Target*)null;
		num22 = num12;
		num24 = num101;
		num88 = num104;
		flag22 = false;
		num23 = num100;
		goto IL_43d6;
		IL_43d6:
		object obj152 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2240 @ X0_v38+E4]");
		bool flag143 = (nint)0 == 0;
		object obj153 = !flag143;
		if (obj153 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Hurt__BackingField != null)
		{
			MonsterWounds monsterWounds5 = Hurt__BackingField;
			if ((object)Hurt__BackingField == null)
			{
				goto IL_42a9;
			}
			num24 = monsterWounds5.Pace__BackingField;
			num34 = want * monsterWounds5.Pace__BackingField;
			num23 = want;
		}
		else
		{
			num34 = want;
		}
		bool flag144 = state__BackingField == (State)4;
		num28 = num87;
		num26 = num86;
		if (!flag144)
		{
			bool flag145 = num34 < 0f;
			object obj154 = !flag145;
			bool flag146 = num34 == 0f;
			object obj155 = ~obj154;
			object obj156 = obj155 | flag146;
			num28 = num87;
			num26 = num86;
			if (obj156 == null)
			{
				Vector3 vector6 = Steer((Vector3)0);
				num28 = num87;
				num26 = num86;
				num22 = num87;
				num24 = num88;
				num23 = num86;
			}
		}
		bool flag147 = !(num34 > 0f);
		num32 = num86;
		num33 = num87;
		obj138 = 0;
		if (!flag147)
		{
			bool flag148 = (byte)(~(pathOk ? 1u : 0u)) != 0;
			obj138 = 0;
			goal = (Vector3)0;
			if (flag148)
			{
				goto IL_0f9a;
			}
			if (path != null)
			{
				Vector3[] corners = path.corners;
				if (corners != null)
				{
					bool flag149 = corner >= corners.Length;
					obj138 = 0;
					goal = (Vector3)0;
					if (flag149)
					{
						goto IL_0f9a;
					}
					if (path != null)
					{
						Vector3[] corners2 = path.corners;
						if (corners2 != null)
						{
							bool flag150 = corner < corners2.Length;
							object obj157 = !flag150;
							if (obj157 != null)
							{
								goto IL_42b7;
							}
							object obj158 = corner * 12;
							object obj159 = (object)corners2 + obj158;
							Transform transform20 = base.transform;
							if ((object)transform20 != null)
							{
								Vector3 position17 = transform20.position;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1491 @ X8_v87+24]");
								num23 = 0f - (float)num24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
								num24 = 0.0;
								float num150 = num23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
								bool flag151 = !(num150 > 0f);
								obj138 = 0;
								goal = (Vector3)0;
								if (flag151)
								{
									goto IL_0f9a;
								}
								Transform transform21 = base.transform;
								if ((object)transform21 != null)
								{
									Vector3 position18 = transform21.position;
									if (path != null)
									{
										Vector3[] corners3 = path.corners;
										if (corners3 != null)
										{
											bool flag152 = corner < corners3.Length;
											object obj160 = !flag152;
											if (obj160 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA20]");
												object obj161 = 0;
												object obj162 = corner * 12;
												object obj163 = (object)corners3 + obj162;
												object obj164 = obj161;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3227 @ X0_v171+E4]");
												bool flag153 = (nint)0 == 0;
												object obj165 = !flag153;
												if (obj165 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												MonsterClimb monsterClimb = MonsterClimb.Up((Vector3)0, (Vector3)0, num23);
												object obj166 = obj11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v92+E4]");
												bool flag154 = (nint)0 == 0;
												object obj167 = !flag154;
												if (obj167 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool flag155 = monsterClimb != null;
												bool flag156 = !flag155;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3226 @ X8_v90+28]");
												double num38 = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3226 @ X8_v90+24]");
												double num90 = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3226 @ X8_v90+20]");
												double num89 = 0.0;
												obj138 = 0;
												goal = (Vector3)0;
												if (!flag156)
												{
													StartClimb(monsterClimb);
													return;
												}
												goto IL_0f9a;
											}
											goto IL_42b7;
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_42a9;
		}
		goto IL_4447;
		IL_45ce:
		object obj168 = this + 432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		hasPrey = (byte)state != 0;
		euler = (Vector3)length;
		flag22 = false;
		goto IL_43d6;
		IL_34bf:
		Chasing__BackingField = false;
		state__BackingField = (State)3;
		List<Vector3> list = trail;
		stateT = 0f;
		reachedFor = 0f;
		searchFor = 9f;
		listening = false;
		if (trail == null)
		{
			goto IL_42a9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1511 @ X8_v118 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
		object obj169 = (nint)0 + (nint)1;
		_ = 0;
		euler = (Vector3)length;
		want = 0f;
		num86 = num85;
		num87 = num12;
		num22 = num12;
		num88 = num;
		goto IL_43d6;
		IL_07b0:
		euler = (Vector3)length;
		num86 = deltaTime;
		num87 = num12;
		num22 = num12;
		num24 = num;
		num88 = num;
		num23 = deltaTime;
		goto IL_43d6;
		IL_4bc6:
		stateT = 0f;
		reachedFor = 0f;
		listening = false;
		hasPrey = false;
		euler = (Vector3)length;
		want = 0f;
		num86 = num85;
		num87 = num12;
		num22 = num12;
		num88 = num;
		goto IL_43d6;
		IL_33cb:
		if (prey != (MonsterCatalog.Target)(object)0)
		{
			Vector3 position19 = ((Transform)prey).position;
			Transform transform22 = base.transform;
			if ((object)transform22 != null)
			{
				Vector3 position20 = transform22.position;
				object obj170 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2718 @ X0_v254+E4]");
				bool flag157 = (nint)0 == 0;
				object obj171 = !flag157;
				if (obj171 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
				bool flag158 = !(num94 > loseRange);
				num24 = loseRange;
				flag22 = false;
				num23 = num94;
				if (!flag158)
				{
					goto IL_34bf;
				}
				bool flag159 = CanSee((Transform)prey);
				if (flag159)
				{
					if (prey == (MonsterCatalog.Target)(object)0)
					{
						goto IL_42a9;
					}
					Vector3 position21 = ((Transform)prey).position;
					lastSeen = (Vector3)num94;
					_ = loseRange;
				}
				Vector3 vector7 = Hunt((Transform)prey, flag159);
				if (prey != (MonsterCatalog.Target)(object)0)
				{
					Vector3 position22 = ((Transform)prey).position;
					bool flag160 = !flag159;
					lookWant = (Vector3)runSpeed;
					object obj172 = !flag160;
					object obj173 = ~obj172;
					double num89 = ((obj173 != null) ? 0.5 : 1.0);
					_ = loseRange;
					lookWeightWant = (float)num89;
					bool flag161 = Way((Transform)prey, out length);
					bool flag162 = !flag161;
					object obj174 = !flag162;
					num23 = 0f;
					if (obj174 == null)
					{
						num23 = deltaTime + unreachT;
					}
					num24 = giveUpSeconds;
					unreachT = num23;
					if (num23 > giveUpSeconds)
					{
						if (prey == (MonsterCatalog.Target)(object)0)
						{
							goto IL_42a9;
						}
						Vector3 position23 = ((Transform)prey).position;
						WalkAway((Vector3)0);
						euler = (Vector3)0;
						double num90 = 1.0;
						want = runSpeed;
						num86 = num94;
						num87 = num12;
						reference = ref *(MonsterCatalog.Target*)(&length);
						num22 = num12;
						num88 = loseRange;
						flag22 = false;
					}
					else
					{
						bool flag163 = !flag159;
						flag22 = (byte)(int)prey != 0;
						double num90;
						if (!flag163)
						{
							bool flag164 = InReach((Transform)prey);
							bool flag165 = !flag164;
							flag22 = (byte)(int)prey != 0;
							if (!flag165)
							{
								bool flag166 = Grabbable((Transform)prey);
								bool flag167 = !flag166;
								flag22 = (byte)(int)prey != 0;
								if (!flag167)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+1C0]");
									num22 = 0.0;
									float num151 = deltaTime + reachedFor;
									reachedFor = num151;
									object obj175 = default;
									if (WaitsForClaim((MonsterCatalog.Target)(&obj175)))
									{
										num24 = reachedFor;
										bool flag168 = !((double)reachedFor > 1.5);
										euler = (Vector3)0;
										num90 = 1.0;
										want = runSpeed;
										num86 = num94;
										num87 = num12;
										reference = ref *(MonsterCatalog.Target*)(&length);
										num88 = loseRange;
										flag22 = (byte)(&obj175) != 0;
										num23 = 1.5f;
										if (flag168)
										{
											goto IL_43d6;
										}
									}
									num23 = (float)prey;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v19 (MonsterBrain)+1C0]");
									num24 = 0.0;
									object obj176 = default;
									StartKill((MonsterCatalog.Target)(&obj176));
									euler = (Vector3)0;
									num90 = 1.0;
									want = runSpeed;
									num86 = num94;
									num87 = num12;
									reference = ref *(MonsterCatalog.Target*)(&length);
									num88 = loseRange;
									flag22 = (byte)(&obj176) != 0;
									goto IL_43d6;
								}
							}
						}
						reachedFor = 0f;
						euler = (Vector3)0;
						num90 = 1.0;
						want = runSpeed;
						num86 = num94;
						num87 = num12;
						reference = ref *(MonsterCatalog.Target*)(&length);
						num22 = num12;
						num88 = loseRange;
					}
					goto IL_43d6;
				}
			}
		}
		goto IL_42a9;
	}

	private void LateUpdate()
	{
		//IL_002a: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_013a: Invalid comparison between F4 and I
		//IL_0187: Expected VT, but got F4
		//IL_01a4: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got VT
		//IL_0255: Expected Obj, but got I
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_02c1: Invalid comparison between F4 and I
		//IL_0340: Invalid comparison between F4 and I4
		//IL_034f: Invalid comparison between F4 and I4
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0370: Expected Obj, but got F4
		//IL_03a5: Expected Obj, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_0474: Invalid comparison between F4 and I8
		//IL_0487: Expected F4, but got I8
		//IL_03e4: Invalid comparison between F4 and I4
		//IL_043f: Expected VT, but got I4
		//IL_040c: Expected F4, but got I4
		float deltaTime = Time.deltaTime;
		if (~(Dead__BackingField ? 1u : 0u) == 0)
		{
			Lie(deltaTime);
			return;
		}
		ChaseVoice(deltaTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = headBone == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = face == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		float num = LookWeight__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		if (num < 0f)
		{
			return;
		}
		Vector3 position = face.position;
		Vector3 position2 = headBone.position;
		Vector3 vector = (Vector3)(LookWeight__BackingField - LookWeight__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		object obj8 = num2 - 0;
		object obj10 = default;
		object obj9 = obj10 - obj10;
		Vector3 position3 = headBone.position;
		object obj11 = vector * vector;
		object obj12 = obj8 * obj8;
		object obj13 = obj11 + obj12;
		object obj14 = obj9 * obj9;
		object obj15 = obj14 + obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		if ((nint)obj15 < 0)
		{
			return;
		}
		float num3 = (float)LookPoint__BackingField - LookWeight__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+130]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		object obj16 = num4 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+134]");
		object obj17 = 0 - obj10;
		float num5 = num3 * num3;
		object obj18 = obj16 * obj16;
		float num6 = num5 + (float)obj18;
		object obj19 = obj17 * obj17;
		float num7 = (float)obj19 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		if (num7 < 0f)
		{
			return;
		}
		Vector3 fromDirection = default;
		Vector3 toDirection = default;
		Quaternion quaternion = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
		Quaternion q = default;
		Quaternion.Internal_ToAxisAngleRad(ref q, out Vector3 _, out float angle);
		float num8 = angle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
		float num9 = num8 * 0f;
		float num10 = num9 + 3.2833536E+09f;
		float num11 = num9 - 1.1274813E+09f;
		bool flag7 = num11 < 0f;
		bool flag8 = num11 == 0f;
		object obj20 = num9 ^ 0x43340000;
		object obj21 = num9 ^ num11;
		object obj22 = obj20 & obj21;
		bool flag9 = (nint)obj22 < 0;
		bool flag10 = flag7 == flag9;
		object obj23 = !flag8;
		object obj24 = flag10 & obj23;
		object obj25 = ~obj24;
		if (obj25 != null)
		{
			num10 = num9;
		}
		bool flag11 = num10 < 3.26212E+09f;
		float num12 = 3.26212E+09f;
		if (!flag11)
		{
			bool flag12 = !(num10 > 1.1146363E+09f);
			num12 = num10;
			if (!flag12)
			{
				num12 = 1.1146363E+09f;
			}
		}
		float angle2 = num12 * LookWeight__BackingField;
		Quaternion quaternion2 = Quaternion.Internal_AngleAxis(angle2, ref fromDirection);
		Quaternion rotation = headBone.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
		headBone.rotation = (Quaternion)0;
	}

	public void Blasted(float damage, Vector3 push, Vector3 at, float near)
	{
		//IL_0325: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_00d1: Expected VT, but got I4
		//IL_01bf: Expected Obj, but got I4
		//IL_00f3: Expected VT, but got I4
		//IL_0114: Expected VT, but got I4
		//IL_016b: Expected Obj, but got I4
		//IL_025c: Invalid comparison between F4 and I4
		//IL_026d: Expected Obj, but got I4
		//IL_0278: Invalid comparison between F4 and I4
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_01f9: Invalid comparison between F4 and I4
		//IL_020a: Expected Obj, but got I4
		//IL_0215: Invalid comparison between F4 and I4
		//IL_0226: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02ca: Expected Obj, but got I4
		//IL_02e2: Expected VT, but got F4
		bool flag = (byte)(~(Dead__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null || ~(Puppet__BackingField ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		float num = Health__BackingField - damage;
		object obj3 = obj2;
		Health__BackingField = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = Hurt__BackingField != null;
		bool flag4 = !flag3;
		object obj6 = default;
		object obj5 = obj6;
		object obj8 = default;
		object obj7 = obj8;
		float num2 = near;
		Vector3 vector = (Vector3)0;
		if (!flag4)
		{
			float num3 = default;
			Hurt__BackingField.Blast((Vector3)0, num3);
			object obj9 = default;
			obj5 = obj9;
			object obj10 = default;
			obj7 = obj10;
			float num4 = default;
			num2 = num4;
			vector = (Vector3)0;
			num = num3;
		}
		object obj14;
		if (state__BackingField != (State)4)
		{
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(climb != null))
			{
				bool flag6 = !lurking;
				object obj13 = !flag6;
				obj14 = obj13;
				goto IL_0333;
			}
		}
		obj14 = 1;
		goto IL_0333;
		IL_02a2:
		object obj15 = obj14 & 1;
		bool flag7 = obj15 == null;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			shove = (Vector3)near;
			staggerT = staggerSeconds;
			speed = 0f;
		}
		return;
		IL_0333:
		if (obj14 != null)
		{
			bool flag8 = Health__BackingField < 0f;
			object obj17 = !flag8;
			bool flag9 = Health__BackingField == 0f;
			object obj18 = !flag9;
			object obj19 = obj17 & obj18;
			if (obj19 == null)
			{
				Health__BackingField = 1f;
				goto IL_02a2;
			}
		}
		bool flag10 = Health__BackingField < 0f;
		object obj20 = !flag10;
		bool flag11 = Health__BackingField == 0f;
		object obj21 = ~obj20;
		object obj22 = obj21 | flag11;
		if (obj22 == null)
		{
			goto IL_02a2;
		}
		Die();
	}

	public void Stabbed(float damage, GoreSection section, Vector3 point)
	{
		//IL_03cf: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_00c9: Expected VT, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_00f4: Expected VT, but got I4
		//IL_010d: Expected VT, but got I4
		//IL_016c: Expected Obj, but got I4
		//IL_025d: Invalid comparison between F4 and I4
		//IL_026e: Expected Obj, but got I4
		//IL_0279: Invalid comparison between F4 and I4
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_01fa: Invalid comparison between F4 and I4
		//IL_020b: Expected Obj, but got I4
		//IL_0216: Invalid comparison between F4 and I4
		//IL_0227: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got I4
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got I4
		//IL_0317: Invalid comparison between F4 and I4
		//IL_0326: Invalid comparison between F4 and I4
		//IL_033b: Expected Obj, but got F4
		//IL_034a: Expected Obj, but got F4
		//IL_037f: Expected Obj, but got I4
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		bool flag = (byte)(~(Dead__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null || ~(Puppet__BackingField ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		float num = Health__BackingField - damage;
		object obj3 = obj2;
		Health__BackingField = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = Hurt__BackingField != null;
		bool flag4 = !flag3;
		float num3 = default;
		float num2 = num3;
		float num5 = default;
		float num4 = num5;
		Vector3 vector = (Vector3)0;
		GoreSection goreSection = (GoreSection)0;
		if (!flag4)
		{
			Hurt__BackingField.Stabbed(section, (Vector3)0);
			float num6 = default;
			num2 = num6;
			num4 = num3;
			vector = (Vector3)0;
			goreSection = section;
			num = num5;
		}
		object obj8;
		if (state__BackingField != (State)4)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj6 = !flag5;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(climb != null))
			{
				bool flag6 = !lurking;
				object obj7 = !flag6;
				obj8 = obj7;
				goto IL_03dd;
			}
		}
		obj8 = 1;
		goto IL_03dd;
		IL_02a3:
		object obj9 = obj8 & 1;
		bool flag7 = obj9 == null;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			speed = 0f;
			float num7 = staggerSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			float num8 = num7 * 0f;
			float num9 = staggerT - num8;
			bool flag8 = num9 < 0f;
			bool flag9 = num9 == 0f;
			object obj11 = staggerT ^ num8;
			object obj12 = staggerT ^ num9;
			object obj13 = obj11 & obj12;
			bool flag10 = (nint)obj13 < 0;
			bool flag11 = flag8 == flag10;
			object obj14 = !flag9;
			object obj15 = flag11 & obj14;
			object obj16 = ~obj15;
			if (obj16 == null)
			{
				num8 = staggerT;
			}
			staggerT = num8;
		}
		return;
		IL_03dd:
		if (obj8 != null)
		{
			bool flag12 = Health__BackingField < 0f;
			object obj17 = !flag12;
			bool flag13 = Health__BackingField == 0f;
			object obj18 = !flag13;
			object obj19 = obj17 & obj18;
			if (obj19 == null)
			{
				Health__BackingField = 1f;
				goto IL_02a3;
			}
		}
		bool flag14 = Health__BackingField < 0f;
		object obj20 = !flag14;
		bool flag15 = Health__BackingField == 0f;
		object obj21 = ~obj20;
		object obj22 = obj21 | flag15;
		if (obj22 == null)
		{
			goto IL_02a3;
		}
		Die();
	}

	private void Stagger(float dt)
	{
		//IL_041f: Expected Obj, but got I
		//IL_0437: Expected Obj, but got I
		//IL_043f: Expected F4, but got Obj
		//IL_044f: Expected F4, but got I
		//IL_02d2: Expected Obj, but got I
		//IL_0312: Invalid comparison between F4 and I4
		//IL_0338: Expected VT, but got F4
		//IL_0375: Expected Obj, but got I4
		//IL_0022: Invalid comparison between F4 and I4
		//IL_021b: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_0083: Invalid comparison between F4 and I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_026d: Expected VT, but got I4
		//IL_01c0: Expected Obj, but got I
		//IL_01ec: Expected F4, but got I
		float num = staggerT - dt;
		staggerT = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+A0]");
		object obj3 = 0;
		float num2 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+8]");
		float num3 = 0f;
		float num4 = (float)obj3 - (float)shove;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+8]");
		float num5 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2F8]");
		float num6 = num5 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		float num7 = num4 * num4;
		float num8 = num6 * num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num9 = num8 + num7;
		if (num9 != 0f)
		{
			float num10 = dt * 9f;
			bool flag = num10 < 0f;
			float num11 = 9f;
			if (!flag)
			{
				num11 = num10 * num10;
				bool flag2 = num9 < num11;
				object obj5 = !flag2;
				float num12 = num9 - num11;
				bool flag3 = num12 == 0f;
				object obj6 = ~obj5;
				object obj7 = obj6 | flag3;
				num8 = dt;
				num7 = num11;
				if (obj7 != null)
				{
					goto IL_0326;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v26+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			float num13 = num4 / dt;
			float num14 = num6 / num11;
			object obj11 = default;
			num8 = num13 * (float)obj11;
			num2 = (float)shove + num8;
			num7 = num10 * num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2F8]");
			num3 = 0f + num7;
		}
		goto IL_0326;
		IL_0326:
		object obj12 = obj4;
		shove = (Vector3)num2;
		speed = 0f;
		AnimSpeed__BackingField = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (this.animator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v20+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v18+A0]");
			object obj18 = 0;
			Animator animator = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v19+10]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			animator.SetFloat((int)num15, 0f, 0f, dt);
		}
		bool isGrounded = cc.isGrounded;
		bool flag7 = !isGrounded;
		object obj19 = !flag7;
		float num16 = -1f;
		if (obj19 == null)
		{
			float num17 = gravity * dt;
			num16 = vy - num17;
		}
		vy = num16;
		CollisionFlags collisionFlags = cc.Move((Vector3)0);
	}

	public void Snared(float seconds, Vector3 at)
	{
		//IL_02e8: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I4
		//IL_00c0: Expected VT, but got I4
		//IL_00de: Expected VT, but got I4
		//IL_00ff: Expected VT, but got I4
		//IL_014d: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I8
		//IL_0234: Invalid comparison between F4 and I4
		//IL_0243: Invalid comparison between F4 and I4
		//IL_0258: Expected Obj, but got F4
		//IL_0267: Expected Obj, but got F4
		//IL_029c: Expected Obj, but got I4
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_0320: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I
		//IL_034d: Expected VT, but got Obj
		bool flag = (byte)(~(Dead__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		bool flag2 = (byte)(~(Puppet__BackingField ? 1u : 0u)) != 0;
		object obj2 = !flag2;
		if (obj2 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = Hurt__BackingField != null;
		bool flag5 = !flag4;
		float num2 = default;
		float num = num2;
		float num4 = default;
		float num3 = num4;
		float num5 = seconds;
		Vector3 vector = (Vector3)0;
		if (!flag5)
		{
			Hurt__BackingField.Trapped((Vector3)0);
			float num6 = default;
			num = num6;
			num3 = num2;
			num5 = num4;
			vector = (Vector3)0;
		}
		if (state__BackingField == (State)4)
		{
			return;
		}
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj7 = !flag6;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = climb != null;
		bool flag8 = !flag7;
		object obj8 = !flag8;
		if (obj8 != null)
		{
			return;
		}
		bool flag9 = (byte)(~(lurking ? 1u : 0u)) != 0;
		object obj9 = !flag9;
		if (obj9 == null)
		{
			object obj10 = (long)state__BackingField & 0xFFFFFFFEL;
			if ((nint)obj10 == 6)
			{
				EndPry();
			}
			float num7 = snareT;
			staggerT = 0f;
			float num8 = snareT - seconds;
			bool flag10 = num8 < 0f;
			bool flag11 = num8 == 0f;
			object obj11 = snareT ^ seconds;
			object obj12 = snareT ^ num8;
			object obj13 = obj11 & obj12;
			bool flag12 = (nint)obj13 < 0;
			bool flag13 = flag10 == flag12;
			object obj14 = !flag11;
			object obj15 = flag13 & obj14;
			object obj16 = ~obj15;
			if (obj16 != null)
			{
				num7 = seconds;
			}
			snareT = num7;
			SnareLeft__BackingField = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v16+A0]");
			object obj19 = 0;
			speed = 0f;
			shove = (Vector3)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v17+8]");
			_ = 0;
		}
	}

	private void Snare(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02fc: Expected Obj, but got I8
		//IL_0348: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I
		//IL_0229: Expected VT, but got I4
		//IL_00c1: Expected Obj, but got I
		//IL_00ed: Expected F4, but got I
		//IL_0253: Expected VT, but got F4
		//IL_0263: Invalid comparison between F4 and I4
		//IL_0274: Expected Obj, but got I4
		//IL_027f: Invalid comparison between F4 and I4
		//IL_02a0: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = this + 292;
		object obj3 = obj;
		float num = snareT - dt;
		obj2 = 4575657221408423936L;
		speed = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		snareT = num;
		SnareLeft__BackingField = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (this.animator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v15+A0]");
			object obj9 = 0;
			Animator animator = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v16+10]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			animator.SetFloat((int)num2, 0f, 0f, dt);
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v18+A0]");
			object obj11 = 0;
			Animator animator2 = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v19+14]");
			animator2.SetFloat(0, 1f);
		}
		bool isGrounded = cc.isGrounded;
		bool flag3 = !isGrounded;
		object obj12 = !flag3;
		float num3 = -1f;
		if (obj12 == null)
		{
			float num4 = gravity * dt;
			num3 = vy - num4;
		}
		vy = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj13 = 0;
		object obj14 = obj13;
		float num5 = vy * dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v11+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v12+20]");
		float num6 = 0f * num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v12+1C]");
		float num7 = 0f * num5;
		float num8 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v12+18]");
		float num9 = num8 * 0f;
		CollisionFlags collisionFlags = cc.Move((Vector3)0);
		Transform transform = base.transform;
		Vector3 position = transform.position;
		stuckAt = (Vector3)num9;
		bool flag4 = snareT < 0f;
		object obj16 = !flag4;
		bool flag5 = snareT == 0f;
		stuckT = 0f;
		object obj17 = !flag5;
		object obj18 = obj16 & obj17;
		if (obj18 == null)
		{
			repathAt = 0f;
		}
	}

	public void ShowSnare(float left)
	{
		snareT = left;
		SnareLeft__BackingField = left;
	}

	public void HeardHealth(float left)
	{
		Health__BackingField = left;
	}

	private void Die()
	{
		//IL_014f: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		if (~(Prying__BackingField ? 1u : 0u) == 0)
		{
			EndPry();
		}
		object obj2 = obj;
		hasPrey = false;
		Chasing__BackingField = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)net != (UnityEngine.Object)null && net.Live)
		{
			string text = name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB10]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			MonsterDirector.Killed(text);
		}
		ShowDeath();
	}

	public void ShowDeath()
	{
		//IL_0558: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I4
		//IL_0576: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I4
		//IL_0297: Expected Obj, but got I4
		//IL_0595: Expected Obj, but got I
		//IL_05a5: Expected Obj, but got I
		//IL_05b6: Expected Obj, but got VT
		//IL_05d3: Expected Obj, but got I
		//IL_05fd: Expected Obj, but got I
		//IL_0300: Expected VT, but got I4
		//IL_063e: Expected Obj, but got I
		//IL_0656: Expected Obj, but got I
		//IL_032e: Expected VT, but got I4
		//IL_07e9: Expected Obj, but got I
		//IL_0806: Expected Obj, but got I
		//IL_0816: Expected Obj, but got I
		//IL_0848: Expected Obj, but got I
		//IL_0858: Expected Obj, but got I
		//IL_0362: Unsupported input type for neg.
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected VT, but got Unknown
		//IL_0378: Expected Obj, but got I
		//IL_037c: Unsupported input type for neg.
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected VT, but got Unknown
		//IL_0670: Expected Obj, but got I
		//IL_069a: Expected Obj, but got I4
		//IL_04e0: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I
		//IL_0508: Expected Obj, but got I
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected Obj, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected Obj, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Expected Obj, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_0733: Expected VT, but got Obj
		//IL_074d: Expected VT, but got Obj
		//IL_075a: Expected Obj, but got VT
		//IL_0795: Expected Obj, but got VT
		//IL_07af: Invalid comparison between Obj and F8
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		bool flag = (byte)(~(Dead__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj2 = 0;
			Dead__BackingField = true;
			deadT = 0f;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v4+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA18]");
			object obj6 = 0;
			bool flag3 = ((List<System.__Canon>)obj5).Remove((System.__Canon)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = animator != null;
			bool flag6 = !flag5;
			UnityEngine.Object obj10 = null;
			if (!flag6)
			{
				animator.speed = 0f;
				obj10 = null;
			}
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v14+E4]");
			bool flag7 = (nint)0 == 0;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = voice != null;
			bool flag9 = !flag8;
			UnityEngine.Object obj13 = null;
			if (!flag9)
			{
				voice.Stop();
				obj13 = null;
			}
			object obj14 = obj7;
			SnareLeft__BackingField = 0f;
			snareT = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v19+E4]");
			bool flag10 = (nint)0 == 0;
			object obj15 = !flag10;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = Hurt__BackingField != null;
			bool flag12 = !flag11;
			UnityEngine.Object obj16 = null;
			if (!flag12)
			{
				Hurt__BackingField.Died();
				obj16 = null;
			}
			object obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v24+E4]");
			bool flag13 = (nint)0 == 0;
			object obj18 = !flag13;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag14 = model != null;
			bool flag15 = !flag14;
			UnityEngine.Object obj19 = null;
			if (!flag15)
			{
				Quaternion rotation = model.rotation;
				deadFrom = (Quaternion)0;
				Vector3 position = model.position;
				deadAt = (Vector3)0;
				obj19 = null;
			}
			Vector3 vector = shove;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2F4]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2F8]");
			object obj21 = 0;
			object obj22 = shove * shove;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2F4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2F4]");
			object obj23 = num * 0;
			object obj24 = obj22 + obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2F8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2F8]");
			object obj25 = num2 * 0;
			object obj26 = obj24 + obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			object obj27 = default;
			if ((nint)obj26 <= 0)
			{
				Transform transform = base.transform;
				Vector3 forward = transform.forward;
				vector = (Vector3)(0 - obj26);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				obj20 = -0;
				obj21 = 0 - obj27;
				obj19 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v17+A0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+18]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+18]");
			object obj31 = num3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+1C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+1C]");
			object obj32 = num4 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj33 = 0;
			object obj34 = obj33;
			object obj35 = obj31 + obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+20]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+20]");
			object obj36 = num5 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v22+A0]");
			object obj37 = 0;
			object obj38 = obj36 + obj35;
			object obj39 = obj37;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37))
			{
				Vector3 vector2 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+18]");
				object obj40 = vector2 * 0;
				object obj41 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+1C]");
				object obj42 = obj41 * 0;
				object obj43 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+20]");
				object obj44 = obj43 * 0;
				object obj45 = obj40 + obj42;
				object obj46 = obj44 + obj45;
				object obj47 = obj46 / obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+18]");
				obj39 = 0 * obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+1C]");
				obj27 = 0 * obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+20]");
				obj38 = 0 * obj47;
				vector -= obj39;
				obj20 -= obj27;
				obj21 -= obj38;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj48 = 0;
			object obj49 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v34+E4]");
			bool flag16 = (nint)0 == 0;
			object obj50 = !flag16;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			object obj51 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj52;
			object obj53;
			object obj54;
			if ((nint)obj51 > 0)
			{
				obj52 = vector / obj27;
				obj53 = obj20 / obj27;
				obj54 = obj21 / obj27;
			}
			else
			{
				object obj55 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v33+A0]");
				object obj56 = 0;
				obj52 = obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v34+4]");
				obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v34+8]");
				obj54 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+1C]");
			object obj57 = 0 * obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+20]");
			object obj58 = 0 * obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+20]");
			object obj59 = 0 * obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+18]");
			object obj60 = 0 * obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+18]");
			object obj61 = 0 * obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+1C]");
			object obj62 = 0 * obj52;
			Vector3 vector3 = (Vector3)(obj57 - obj58);
			object obj63 = obj59 - obj60;
			Vector3 vector4 = (Vector3)(obj61 - obj62);
			object obj64 = vector3 * vector3;
			fallAxis = vector3;
			object obj65 = obj63 * obj63;
			object obj66 = obj64 + obj65;
			object obj67 = vector4 * vector4;
			object obj68 = obj67 + obj66;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.5))
			{
				Transform transform2 = base.transform;
				Vector3 right = transform2.right;
				fallAxis = vector4;
			}
		}
	}

	private void Lie(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I4
		//IL_004c: Expected VT, but got I4
		//IL_007c: Invalid comparison between F4 and I4
		//IL_008e: Expected F4, but got I4
		//IL_04ec: Expected Obj, but got I4
		//IL_00f2: Expected F4, but got I4
		//IL_00c4: Expected F8, but got I4
		//IL_0524: Expected Obj, but got I4
		//IL_0700: Invalid comparison between F8 and I4
		//IL_070f: Expected F8, but got I4
		//IL_063d: Expected Obj, but got I4
		//IL_0741: Expected Obj, but got I
		//IL_0759: Expected Obj, but got I
		//IL_02b4: Expected Obj, but got I
		//IL_031f: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_04a8: Expected VT, but got I4
		//IL_04a8: Expected VT, but got I4
		//IL_04b1: Expected VT, but got I4
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		float num = deadT + dt;
		deadT = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = model != null;
		bool flag3 = !flag2;
		Vector3 vector = (Vector3)0;
		if (flag3)
		{
			goto IL_04b6;
		}
		float num2 = deadT;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
		float num3 = num2 / 0f;
		bool flag4 = !(num3 < 0f);
		float num4 = 0f;
		if (!flag4)
		{
			goto IL_009c;
		}
		bool flag5 = (double)num3 > 1.0;
		double num5 = 1.0;
		float num6 = 0f;
		if (!flag5)
		{
			bool flag6 = (double)num3 < 1.0;
			num4 = num3;
			num5 = num3;
			num6 = num3;
			if (flag6)
			{
				goto IL_009c;
			}
		}
		float num7 = deadT;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEC0]");
		float num8 = num7 + 0f;
		double num9 = num5 * 1118306304.0;
		double num10 = (double)num8 * -6.0;
		double num11 = num5 * num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num12 = (double)num8 * 18.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		double num13 = num10 * 7.0;
		double num14 = num12 * num13;
		num4 = num6;
		goto IL_06bc;
		IL_04b6:
		if (deadT < deadSeconds)
		{
			return;
		}
		bool flag7 = (byte)(~(Puppet__BackingField ? 1u : 0u)) != 0;
		object obj4 = !flag7;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v10+E4]");
		bool flag8 = (nint)0 == 0;
		object obj6 = !flag8;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)net != (UnityEngine.Object)null && net.Live)
		{
			MonsterNet monsterNet = net;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			object obj8 = default;
			object obj7 = obj8 & 1;
			if (obj7 != null)
			{
				MonsterNet monsterNet2 = net;
				((SimulationBehaviour)monsterNet2)._runner.Despawn(((SimulationBehaviour)monsterNet2)._object);
			}
			return;
		}
		GameObject obj9 = gameObject;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v9+E4]");
		bool flag9 = (nint)0 == 0;
		object obj11 = !flag9;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.Destroy(obj9);
		return;
		IL_009c:
		float num15 = num4 * 1.1183063E+09f;
		num11 = (double)num4 * (double)num15;
		num14 = 0.0;
		goto IL_06bc;
		IL_06bc:
		double num16 = (double)deadSeconds + -1.5;
		double num17 = (double)deadT - num16;
		double num18 = num17 / 1.5;
		bool flag10 = num18 < 0.0;
		double num19 = 0.0;
		if (!flag10)
		{
			bool flag11 = !(num18 > 1.0);
			num19 = num18;
			if (!flag11)
			{
				num19 = 1.0;
			}
		}
		float num20 = (float)num11 - (float)num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v18+A0]");
		object obj14 = 0;
		Vector3 axis = default;
		Quaternion quaternion = Quaternion.Internal_AngleAxis(num20, ref axis);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num21 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+324]");
		float num22 = num21 * 0f;
		float num23 = num20 * (float)deadFrom;
		float num24 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+320]");
		float num25 = num24 * 0f;
		double num26 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+324]");
		double num27 = num26 * 0.0;
		float num28 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+31C]");
		float num29 = num28 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+304]");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+324]");
		object obj15 = num30 * 0;
		float num31 = num4 * (float)deadFrom;
		float num32 = num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+324]");
		float num33 = num32 * 0f;
		double num34 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v19+2C]");
		double num35 = num34 * 0.0;
		float num36 = num22 - num23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+304]");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+31C]");
		object obj16 = num37 * 0;
		double num38 = num27 + (double)num25;
		float num39 = num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+31C]");
		float num40 = num39 * 0f;
		float num41 = (float)obj15 + num29;
		double num42 = num19 * (double)deadFrom;
		float num43 = num33 + num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+304]");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+320]");
		object obj17 = num44 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+304]");
		object obj18 = 0 * deadFrom;
		float num45 = num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+320]");
		float num46 = num45 * 0f;
		double num47 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+320]");
		double num48 = num47 * 0.0;
		float num49 = num36 - (float)obj16;
		double num50 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+31C]");
		double num51 = num50 * 0.0;
		float num52 = num40 + (float)num38;
		double num53 = num35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		double num54 = num53 * 0.0;
		double num55 = num42 + (double)num41;
		float num56 = num43 + (float)obj17;
		float num57 = num49 - (float)num48;
		float num58 = num52 - (float)obj18;
		double num59 = num55 - (double)num46;
		float num60 = num56 - (float)num51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+330]");
		double num61 = 0.0 + num54;
		model.SetPositionAndRotation((Vector3)0, (Quaternion)0);
		vector = (Vector3)0;
		goto IL_04b6;
	}

	private void StartClimb(MonsterClimb wall)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected VT, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		climb = wall;
		object obj = this + 584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 660;
		obj2 = 0;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Vector3 vector = default;
		climbFrom = vector;
		Vector3 vector2 = wall.Into;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		object obj3 = vector * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		object obj5 = default;
		object obj4 = obj5 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		object obj7 = default;
		object obj6 = obj7 * 0;
		Vector3 vector3 = wall.rim - obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [wall @ X1 (MonsterClimb)+24]");
		object obj8 = 0 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [wall @ X1 (MonsterClimb)+34]");
		object obj9 = 0 - obj6;
		climbFoot = vector3;
		cc.enabled = false;
		vy = 0f;
	}

	private unsafe void Climb(float dt)
	{
		//IL_0b4e: Expected Obj, but got I
		//IL_0b66: Expected Obj, but got I
		//IL_0ba1: Expected Obj, but got I
		//IL_0bab: Expected VT, but got I4
		//IL_0099: Invalid comparison between F4 and I4
		//IL_00a8: Expected F4, but got I4
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bce: Expected Ref, but got Unknown
		//IL_0bf3: Expected F4, but got I
		//IL_0133: Expected VT, but got I4
		//IL_00bf: Invalid comparison between F4 and I4
		//IL_00ce: Expected F4, but got I4
		//IL_00e5: Invalid comparison between F4 and I4
		//IL_0e82: Expected Obj, but got I
		//IL_037f: Expected F8, but got I
		//IL_03ab: Invalid comparison between F4 and I4
		//IL_03ba: Expected F8, but got I4
		//IL_04fc: Expected F8, but got I
		//IL_0df2: Expected Obj, but got I4
		//IL_0e08: Expected VT, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_0e2e: Expected Obj, but got I
		//IL_0629: Expected F8, but got I
		//IL_064b: Invalid comparison between F4 and I4
		//IL_065a: Expected F8, but got I4
		//IL_0e9b: Expected F8, but got VT
		//IL_0ec0: Expected VT, but got I4
		//IL_0ee3: Expected F8, but got I
		//IL_0f3e: Expected VT, but got I4
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_041a: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I4
		//IL_0439: Expected VT, but got I4
		//IL_0f55: Expected Obj, but got I4
		//IL_115f: Expected Obj, but got I4
		//IL_06ec: Invalid comparison between F8 and I4
		//IL_06fb: Invalid comparison between F8 and I4
		//IL_0713: Expected Obj, but got F8
		//IL_0720: Expected Obj, but got F8
		//IL_0755: Expected Obj, but got I4
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected Obj, but got Unknown
		//IL_01e9: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I4
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected Obj, but got Unknown
		//IL_05a6: Expected Obj, but got I4
		//IL_05cc: Expected VT, but got F4
		//IL_0614: Expected VT, but got I4
		//IL_0fb9: Invalid comparison between F8 and I4
		//IL_0c55: Expected Obj, but got I
		//IL_0c8e: Expected Obj, but got I4
		//IL_0a54: Expected Obj, but got I
		//IL_0a7e: Expected Obj, but got I4
		//IL_07d4: Expected Obj, but got I
		//IL_07e8: Expected Obj, but got VT
		//IL_080f: Expected VT, but got I4
		//IL_02b9: Expected Obj, but got I4
		//IL_02d3: Invalid comparison between F4 and I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_0ab3: Expected Obj, but got I
		//IL_0ade: Expected F4, but got I
		//IL_081d: Invalid comparison between F8 and I4
		//IL_082c: Expected F8, but got I4
		//IL_0947: Expected F8, but got I
		//IL_0957: Expected F8, but got I
		//IL_0965: Expected VT, but got I4
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected Obj, but got Unknown
		//IL_0979: Expected Obj, but got I4
		//IL_09a7: Expected VT, but got I4
		//IL_0afb: Expected Obj, but got I
		//IL_10e5: Expected Obj, but got I4
		//IL_111d: Expected VT, but got I4
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected Obj, but got Unknown
		//IL_1197: Expected Obj, but got I4
		//IL_08f2: Expected Obj, but got I4
		//IL_092a: Expected VT, but got I4
		//IL_0330: Invalid comparison between F4 and I
		//IL_09c4: Expected Obj, but got I
		//IL_09d4: Expected F4, but got I
		//IL_09e4: Expected F4, but got I
		//IL_0cf3: Expected VT, but got I4
		//IL_0d29: Expected VT, but got I4
		float num = (climbT += dt);
		Vector3 vector = climb.Into;
		Transform transform = base.transform;
		Vector3 eulerAngles = transform.eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v6+A0]");
		object obj3 = 0;
		Vector3 forward = default;
		Vector3 upwards = default;
		Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
		Quaternion rotation = default;
		Vector3 vector2 = Quaternion.Internal_ToEulerRad(ref rotation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v7+20]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
		object obj4 = num2 * 0;
		Vector3 vector3 = Quaternion.Internal_MakePositive((Vector3)0);
		float num4 = default;
		float num3 = (float)obj4 - num4;
		float num5 = num3 / 1.13587E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num6 = num5 * 1.13587E+09f;
		float num7 = num3 - num6;
		float num8 = turnSpeed + turnSpeed;
		bool flag = num7 < 0f;
		float num9 = 0f;
		if (!flag)
		{
			bool flag2 = num7 > 1.13587E+09f;
			float num10 = 1.13587E+09f;
			if (!flag2)
			{
				bool flag3 = !(num7 > 1.1274813E+09f);
				num10 = num7;
				num9 = num7;
				if (flag3)
				{
					goto IL_0bb4;
				}
			}
			num9 = num10 + 3.2833536E+09f;
		}
		goto IL_0bb4;
		IL_0bb4:
		float num11 = num4 + num9;
		ref float currentVelocity = ref *(float*)(this + 500);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		float num12 = Mathf.SmoothDamp(num4, num11, ref currentVelocity, 0f, num8, dt);
		Transform transform2 = base.transform;
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref forward);
		transform2.rotation = (Quaternion)0;
		MonsterClimb monsterClimb = climb;
		float num13;
		float num32;
		double num35;
		float deltaTime;
		double num51;
		double num50;
		double num34;
		double num33;
		double num31;
		double num30;
		Quaternion quaternion3;
		object obj28;
		if (climbPhase != 2)
		{
			bool flag4 = climbPhase == 1;
			num13 = walkSpeed / clipWalkSpeed;
			if (!flag4)
			{
				bool flag5 = climbPhase == 0;
				object obj5 = !flag5;
				if (obj5 == null)
				{
					Transform transform3 = base.transform;
					Vector3 position = transform3.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X0_v61+E4]");
					bool flag6 = (nint)0 == 0;
					object obj8 = !flag6;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num14 = walkSpeed;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
					float num15 = num14 * 0f;
					float num16 = (float)climbFoot - walkSpeed;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2A4]");
					float num17 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
					float num18 = num17 - 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj9 = 0;
					object obj10 = obj9;
					float num19 = num15 * dt;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X0_v64+E4]");
					bool flag7 = (nint)0 == 0;
					object obj11 = !flag7;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num20 = num16 * num16;
					float num21 = num18 * num18;
					float num22 = num20 + num21;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Transform transform4 = base.transform;
					bool flag8 = walkSpeed < num19;
					object obj12 = !flag8;
					float num23 = walkSpeed - num19;
					bool flag9 = num23 == 0f;
					object obj13 = ~obj12;
					object obj14 = obj13 | flag9;
					if (obj14 == null)
					{
						Vector3 position2 = transform4.position;
						object obj15 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X0_v73+E4]");
						bool flag10 = (nint)0 == 0;
						object obj16 = !flag10;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num24 = walkSpeed;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						float num25;
						float num26;
						if (num24 > 0f)
						{
							num25 = 0f / walkSpeed;
							num26 = num18 / walkSpeed;
						}
						else
						{
							object obj17 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ X8_v51+A0]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X8_v52+4]");
							num25 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X8_v52+8]");
							num26 = 0f;
						}
						float num27 = num19 * num25;
						float num28 = num19 * num26;
						float num29 = num21 + num27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
						num30 = 0.0 + (double)num28;
						transform4.position = (Vector3)0;
						num31 = dt;
						num32 = dt;
						num33 = num29;
						num34 = num8;
						num35 = 1.0;
						quaternion3 = (Quaternion)0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2A4]");
						num30 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2A0]");
						num33 = 0.0;
						transform4.position = (Vector3)0;
						object obj19 = this + 660;
						obj19 = 1;
						num31 = dt;
						num32 = dt;
						num34 = num8;
						num35 = 1.0;
						quaternion3 = (Quaternion)0;
					}
					goto IL_0f4c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
				double num36 = 0.0;
				float num37 = climbT;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
				float num38 = num37 / 0f;
				bool flag11 = num38 < 0f;
				double num39 = 0.0;
				if (!flag11)
				{
					bool flag12 = !((double)num38 > 1.0);
					num36 = 1.0;
					num39 = num38;
					if (!flag12)
					{
						num36 = 1.0;
						num39 = 1.0;
					}
				}
				double num40 = num39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
				double num41 = num40 * 0.0;
				double num42 = num41 * 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				Transform transform5 = base.transform;
				MonsterClimb monsterClimb2 = climb;
				double num43 = num39 * num39;
				double num44 = num43 - 1.0;
				bool flag13 = num44 < 0.0;
				bool flag14 = num44 == 0.0;
				object obj20 = num43 ^ 1.0;
				object obj21 = num43 ^ num44;
				object obj22 = obj20 & obj21;
				bool flag15 = (nint)obj22 < 0;
				bool flag16 = flag13 == flag15;
				object obj23 = !flag14;
				object obj24 = flag16 & obj23;
				object obj25 = ~obj24;
				double num45 = ((obj25 != null) ? num43 : 1.0);
				if (num42 < 0.0 || num42 > 1.0)
				{
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X21_v9 (MonsterClimb)+3C]");
				nint num46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2AC]");
				object obj26 = num46 - 0;
				object obj27 = monsterClimb2.top - climbFrom;
				double num47 = num45 * (double)obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				transform5.position = (Vector3)0;
				bool flag17 = num39 < 0.0;
				double num48 = 0.0;
				if (!flag17)
				{
					bool flag18 = !(num39 > 1.0);
					num48 = num39;
					if (!flag18)
					{
						num48 = 1.0;
					}
				}
				double num49 = num48 + num48;
				num50 = climbSpeed;
				num51 = clipRunSpeed;
				double num52 = num48 * 3.0;
				double num53 = num48 * num49;
				double num54 = num48 * num53;
				double num55 = num48 * num52;
				double num56 = num55 - num54;
				double num57 = 1.0 - num56;
				double num58 = num57 * 0.0;
				num31 = (double)climbSpeed / (double)clipRunSpeed;
				double num59 = num56 + num58;
				num33 = 1.0 - num59;
				double num60 = (double)climbPitch * num33;
				double num61 = num31 * 1.5;
				ClimbPitch__BackingField = (float)num60;
				bool flag19 = num39 < 1.0;
				obj28 = 0;
				num30 = 1.5;
				num34 = 1.0;
				num13 = (float)num61;
				num35 = 2.0;
				quaternion3 = (Quaternion)0;
				deltaTime = dt;
				if (!flag19)
				{
					object obj29 = this + 584;
					climb = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					ClimbPitch__BackingField = 0f;
					cc.enabled = true;
					num33 = runSpeed;
					repathAt = 0f;
					double num62 = (double)runSpeed * 0.5;
					speed = (float)num62;
					obj28 = 0;
					num30 = 1.5;
					num34 = 1.0;
					num13 = (float)num61;
					num35 = 2.0;
					quaternion3 = (Quaternion)1;
					deltaTime = dt;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
				num33 = 0.0;
				num34 = climbPitch;
				float num63 = climbT;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
				float num64 = num63 / 0f;
				bool flag20 = num64 < 0f;
				double num65 = 0.0;
				if (!flag20)
				{
					bool flag21 = !((double)num64 > 1.0);
					num65 = num64;
					if (!flag21)
					{
						num65 = 1.0;
					}
				}
				double num66 = num65 + num65;
				num51 = num65 * 3.0;
				double num67 = num65 * num66;
				double num68 = num65 * num67;
				double num69 = num65 * num51;
				num31 = num69 - num68;
				num50 = 1.0 - num31;
				double num70 = num50 * 0.0;
				double num71 = num31 + num70;
				num30 = num34 * num71;
				ClimbPitch__BackingField = (float)num30;
				bool flag22 = (double)climbT < num33;
				obj28 = 0;
				num35 = 1.0;
				quaternion3 = (Quaternion)0;
				deltaTime = dt;
				if (!flag22)
				{
					object obj30 = this + 660;
					obj30 = 2;
					obj28 = 0;
					num35 = 1.0;
					quaternion3 = (Quaternion)0;
					deltaTime = dt;
				}
			}
			goto IL_0e1e;
		}
		ClimbPitch__BackingField = climbPitch;
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v25+A0]");
		object obj32 = 0;
		Transform transform6 = base.transform;
		Vector3 position3 = transform6.position;
		Transform transform7 = base.transform;
		float num72 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v26+18]");
		float num73 = num72 * 0f;
		float num74 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v26+1C]");
		float num75 = num74 * 0f;
		float num76 = num73 - num75;
		double num77 = (double)climbT * 9.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v13 (MonsterClimb)+30]");
		double num78 = 0.0 + -0.25;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D4]");
		num51 = 0.0;
		float num79 = climbSpeed * dt;
		double num80 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v26+20]");
		num50 = num80 * 0.0;
		double num81 = num77;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D4]");
		double num82 = num81 * 0.0;
		float num83 = num11 + num79;
		float num84 = num76 * (float)num82;
		double num85 = ((!((double)num83 < num78)) ? num78 : ((double)num83));
		num34 = (double)climbFoot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+2A4]");
		float num86 = 0f + num84;
		transform7.position = (Vector3)0;
		float num87 = climbSpeed / clipRunSpeed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
		num33 = 0.0;
		float num88 = num87;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
		num13 = num88 * 0f;
		bool flag23 = num85 < num78;
		float num89 = num11;
		num31 = num84;
		num32 = dt;
		num30 = num86;
		num35 = 2.0;
		quaternion3 = (Quaternion)0;
		if (!flag23)
		{
			object obj33 = this + 660;
			obj33 = 3;
			Transform transform8 = base.transform;
			Vector3 position4 = transform8.position;
			climbFrom = (Vector3)num87;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
			_ = 0;
			num89 = num11;
			num31 = num84;
			num32 = dt;
			num30 = num86;
			num35 = 2.0;
			quaternion3 = (Quaternion)0;
		}
		goto IL_0f4c;
		IL_0f4c:
		obj28 = 0;
		deltaTime = num32;
		goto IL_0e1e;
		IL_0e1e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj34 = 0;
		PoseClimb();
		object obj35 = obj34;
		AnimSpeed__BackingField = (float)num35;
		double num90 = ((!((double)num13 < 0.5)) ? ((double)num13) : 0.5);
		AnimPace__BackingField = (float)num90;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X0_v25+E4]");
		bool flag24 = (nint)0 == 0;
		object obj36 = !flag24;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (this.animator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj37 = 0;
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v30+E4]");
			bool flag25 = (nint)0 == 0;
			object obj39 = !flag25;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj40 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X8_v19+A0]");
			object obj41 = 0;
			Animator animator = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X8_v20+10]");
			nint num91 = 0;
			double num92 = num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			animator.SetFloat((int)num91, (float)num92, 0f, deltaTime);
			object obj42 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X8_v22+A0]");
			object obj43 = 0;
			Animator animator2 = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X8_v23+14]");
			animator2.SetFloat(0, AnimPace__BackingField);
		}
	}

	private void PoseClimb()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_0066: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (model != null)
		{
			float angle = 0f - ClimbPitch__BackingField;
			Vector3 axis = default;
			Quaternion quaternion = Quaternion.Internal_AngleAxis(angle, ref axis);
			model.localRotation = (Quaternion)0;
		}
	}

	public void ShowClimb(float pitch)
	{
		ClimbPitch__BackingField = pitch;
		PoseClimb();
	}

	private unsafe bool StartLurk()
	{
		//IL_07d2: Expected I4, but got Obj
		//IL_0856: Expected Obj, but got I
		//IL_086e: Expected Obj, but got I
		//IL_087e: Expected Obj, but got I
		//IL_088e: Expected Obj, but got I
		//IL_089e: Expected Obj, but got I
		//IL_08ae: Expected Obj, but got I
		//IL_08ea: Expected Obj, but got I
		//IL_091b: Expected Obj, but got I4
		//IL_0924: Expected Obj, but got I4
		//IL_092d: Expected VT, but got I4
		//IL_0936: Expected Obj, but got I4
		//IL_093f: Expected Obj, but got I4
		//IL_0955: Expected Obj, but got I4
		//IL_097b: Expected Obj, but got I
		//IL_098a: Expected VT, but got I4
		//IL_098a: Expected VT, but got I4
		//IL_09b8: Expected Obj, but got I4
		//IL_0067: Expected VT, but got I8
		//IL_0067: Expected VT, but got Ref
		//IL_00b0: Expected Obj, but got I
		//IL_00bd: Expected VT, but got I8
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected Obj, but got Unknown
		//IL_09f7: Expected VT, but got I4
		//IL_0127: Expected Obj, but got I
		//IL_0134: Expected VT, but got I8
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I
		//IL_01b9: Expected VT, but got I8
		//IL_060e: Expected Obj, but got I4
		//IL_0b89: Expected Obj, but got I
		//IL_0bb3: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I4
		//IL_027b: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I
		//IL_02ba: Expected VT, but got I4
		//IL_06e4: Expected Obj, but got I
		//IL_06ec: Expected F4, but got Obj
		//IL_06fc: Expected Obj, but got I
		//IL_0aeb: Expected VT, but got F4
		//IL_06b5: Unsupported input type for neg.
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_0a2d: Expected Obj, but got I
		//IL_0a50: Expected Obj, but got I4
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_0740: Expected Obj, but got I
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got Unknown
		//IL_075f: Expected Obj, but got I4
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected Obj, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_036e: Expected VT, but got I4
		//IL_036e: Expected VT, but got I8
		//IL_0a7e: Expected Obj, but got I
		//IL_0aa1: Expected Obj, but got I4
		//IL_03b0: Expected F4, but got I
		//IL_03c0: Expected Obj, but got I
		//IL_03d6: Expected VT, but got I4
		//IL_03e6: Expected F4, but got I
		//IL_040b: Unsupported input type for neg.
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected F4, but got Unknown
		//IL_0414: Unsupported input type for neg.
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected F4, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_049d: Expected VT, but got I4
		//IL_049d: Expected VT, but got I8
		//IL_05a3: Expected F8, but got I
		//IL_05ac: Expected Obj, but got I4
		//IL_05c2: Expected VT, but got I4
		//IL_04f0: Expected F8, but got I
		//IL_04f9: Expected Obj, but got I4
		//IL_050f: Expected VT, but got I4
		//IL_0556: Expected F8, but got I
		//IL_055f: Expected Obj, but got I4
		//IL_057d: Expected VT, but got I4
		float time = Time.time;
		float num = lurkEvery;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num2 = num * 0f;
		float num3 = lurkEvery;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
		float maxInclusive = num3 * 0f;
		float num4 = UnityEngine.Random.Range(num2, maxInclusive);
		float num5 = (nextLurk = time + num4);
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v7+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v8+20]");
			float num6 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			float num7 = num6 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v8+18]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			object obj8 = num8 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			float num9 = num5 + (float)obj8;
			float num10 = num2 + num7;
			object obj9 = 0;
			object obj10 = 0;
			RaycastHit raycastHit = (RaycastHit)0;
			object obj11 = 2139095039;
			object obj12 = 0;
			double num11 = 30.0;
			object obj13 = 0;
			float num12 = num9;
			Vector3 euler = default;
			RaycastHit raycastHit2 = default;
			QueryTriggerInteraction queryTriggerInteraction = default;
			object obj20 = default;
			UnityEngine.Object obj23 = default;
			object obj30 = default;
			object obj32 = default;
			object obj33 = default;
			object obj39 = default;
			while (true)
			{
				float num13 = UnityEngine.Random.Range(-12f, 12f);
				double num14 = (double)obj9 * num11;
				double num15 = num14 + (double)num13;
				double num16 = num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
				double num17 = num16 * 0.0;
				Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v16+A0]");
				object obj15 = 0;
				Vector3 vector = (Quaternion)0 * (Vector3)0;
				object obj16 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v17+E4]");
				bool flag = (nint)0 == 0;
				object obj17 = !flag;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = Physics.Raycast((Vector3)(&raycastHit2), (Vector3)4294965499L, out *(RaycastHit*)1, num9, 0, queryTriggerInteraction);
				bool flag3 = !flag2;
				object obj18 = obj12;
				int num18 = 1;
				double num19 = 7.0;
				float num20 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
				object obj19 = 0;
				Vector3 vector2 = (Vector3)4294965499L;
				num12 = (float)num17;
				float num21 = num10;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
					bool flag4 = (nint)obj20 < 0;
					obj18 = obj12;
					num18 = 1;
					num19 = 7.0;
					num20 = num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
					obj19 = 0;
					vector2 = (Vector3)4294965499L;
					num12 = (float)num17;
					num21 = num10;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						bool flag5 = (nint)0 > (nint)0;
						obj18 = obj12;
						num18 = 1;
						num19 = 7.0;
						num20 = num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
						obj19 = 0;
						vector2 = (Vector3)4294965499L;
						num12 = (float)num17;
						num21 = num10;
						if (!flag5)
						{
							Collider collider = raycastHit2.collider;
							if ((object)collider == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
							object obj21 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v41+E4]");
							bool flag6 = (nint)0 == 0;
							object obj22 = !flag6;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag7 = obj23 != null;
							bool flag8 = !flag7;
							object obj24 = !flag8;
							obj18 = obj12;
							num18 = 0;
							num19 = 7.0;
							num20 = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
							obj19 = 0;
							vector2 = (Vector3)0;
							num12 = (float)num17;
							num21 = num10;
							if (obj24 == null)
							{
								object obj25 = obj;
								object obj26 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v43+A0]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X0_v49+E4]");
								bool flag9 = (nint)0 == 0;
								object obj28 = !flag9;
								if (obj28 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
								object obj29 = obj30 * 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
								object obj31 = obj32 * 0;
								float num22 = (float)raycastHit2 + (float)obj29;
								float num23 = (float)obj33 + (float)obj31;
								double num24 = lurkHeight;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
								num19 = num24 + 0.0;
								if (Physics.Raycast((Vector3)4294965499L, (Vector3)1, num22, 0, (QueryTriggerInteraction)0))
								{
									obj18 = obj12;
									num18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v44+20]");
									num20 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v44+1C]");
									obj19 = 0;
									num11 = 30.0;
									vector2 = (Vector3)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v44+18]");
									num12 = 0f;
									num21 = num23;
								}
								else
								{
									object obj34 = obj;
									object obj35 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v46+A0]");
									object obj36 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v54+E4]");
									bool flag10 = (nint)0 == 0;
									object obj37 = !flag10;
									if (obj37 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									num12 = 0 - obj30;
									num20 = 0 - obj32;
									float num25 = lurkHeight;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
									float num26 = num25 + 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v47+18]");
									object obj38 = 0 * obj39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v47+20]");
									float num27 = 0f * num26;
									float maxDistance = num22 + (float)obj38;
									num21 = num23 + num27;
									if (Physics.Raycast((Vector3)4294965499L, (Vector3)1, maxDistance, 0, (QueryTriggerInteraction)0))
									{
										bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
										obj18 = obj12;
										num18 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
										num19 = 0.0;
										obj19 = 0;
										num11 = 30.0;
										vector2 = (Vector3)1;
										if (!flag11)
										{
											obj10 = obj33;
											raycastHit = raycastHit2;
											obj11 = obj20;
											obj18 = obj32;
											num18 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
											num19 = 0.0;
											obj19 = 0;
											num11 = 30.0;
											obj13 = obj30;
											vector2 = (Vector3)1;
										}
									}
									else
									{
										obj18 = obj12;
										num18 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
										num19 = 0.0;
										obj19 = 0;
										num11 = 30.0;
										vector2 = (Vector3)1;
									}
								}
							}
						}
					}
				}
				obj9++;
				bool flag12 = (nint)obj9 != 12;
				obj12 = obj18;
				euler = (Vector3)0;
				num7 = num21;
				if (flag12)
				{
					continue;
				}
				if ((nint)obj11 != 2139095039)
				{
					object obj40 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v24+E4]");
					bool flag13 = (nint)0 == 0;
					object obj41 = !flag13;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj42 = 0;
					object obj43 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v28+E4]");
					bool flag14 = (nint)0 == 0;
					object obj44 = !flag14;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj45 = obj13 * obj13;
					object obj46 = obj18 * obj18;
					object obj47 = obj45 + obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					float num28;
					object obj49;
					if ((nint)obj47 > 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						num28 = 0f / num12;
						object obj48 = 0 - obj18;
						obj49 = obj48 / obj47;
					}
					else
					{
						object obj50 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v37+A0]");
						object obj51 = 0;
						num28 = (float)obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v38+8]");
						obj49 = 0;
					}
					lurkInto = (Vector3)num28;
					Transform transform2 = base.transform;
					if ((object)transform2 == null)
					{
						break;
					}
					Vector3 position2 = transform2.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					object obj52 = this + 596;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+278]");
					nint num29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD90]");
					object obj53 = num29 * 0;
					lurking = true;
					object obj54 = this + 612;
					obj52 = 0;
					object obj55 = lurkInto * obj49;
					object obj56 = obj10 + obj53;
					object obj57 = raycastHit + obj55;
					obj54 = obj57;
					float num30 = UnityEngine.Random.Range(9f, 20f);
					lurkHold = num30;
				}
				object obj58 = obj11 - 2139095039;
				bool flag15 = obj58 == null;
				return !flag15;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe void Lurk(float dt)
	{
		//IL_0264: Invalid comparison between F4 and I4
		//IL_0273: Expected F8, but got I4
		//IL_0e10: Invalid comparison between F8 and I4
		//IL_0e1f: Expected F8, but got I4
		//IL_0651: Expected Obj, but got I
		//IL_067b: Expected Obj, but got I4
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_0f86: Expected VT, but got I4
		//IL_06a1: Expected Obj, but got I4
		//IL_0066: Invalid comparison between F4 and I4
		//IL_0075: Expected F8, but got I4
		//IL_031a: Expected Obj, but got I
		//IL_0358: Expected VT, but got I4
		//IL_05f8: Expected F8, but got I4
		//IL_0fff: Expected Obj, but got I
		//IL_1029: Expected Obj, but got I4
		//IL_0dcd: Invalid comparison between F8 and I4
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		//IL_05be: Expected Obj, but got I4
		//IL_037f: Invalid comparison between F8 and I4
		//IL_038e: Expected F8, but got I4
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected Obj, but got Unknown
		//IL_074f: Expected Obj, but got I4
		//IL_0767: Invalid comparison between F4 and I4
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Unknown
		//IL_00ee: Expected VT, but got I4
		//IL_0124: Invalid comparison between F4 and I
		//IL_0133: Expected F8, but got I4
		//IL_10ab: Expected Obj, but got I
		//IL_10c3: Expected Obj, but got I
		//IL_10fe: Expected Obj, but got I
		//IL_1108: Expected VT, but got I4
		//IL_0f06: Expected F4, but got I4
		//IL_0620: Expected F8, but got I4
		//IL_0236: Expected F8, but got I4
		//IL_023f: Expected F4, but got I4
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected Obj, but got Unknown
		//IL_0811: Expected Obj, but got I4
		//IL_0ab1: Invalid comparison between F4 and I4
		//IL_0ac0: Expected F4, but got I4
		//IL_11c6: Expected F8, but got I4
		//IL_0837: Expected VT, but got F4
		//IL_084a: Expected F8, but got I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got I4
		//IL_015e: Expected F8, but got I4
		//IL_1126: Unknown result type (might be due to invalid IL or missing references)
		//IL_112b: Expected Ref, but got Unknown
		//IL_1150: Expected F4, but got I
		//IL_03e2: Expected Obj, but got VT
		//IL_0877: Invalid comparison between F4 and I4
		//IL_0886: Invalid comparison between F4 and I4
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected Obj, but got Unknown
		//IL_08ae: Expected Obj, but got F4
		//IL_08e3: Expected Obj, but got I4
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected Obj, but got Unknown
		//IL_0b4d: Expected Obj, but got I
		//IL_0b5b: Expected VT, but got I4
		//IL_0ad7: Invalid comparison between F4 and I4
		//IL_0ae6: Expected F4, but got I4
		//IL_0430: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I4
		//IL_0935: Expected Obj, but got I4
		//IL_0f51: Expected F4, but got I
		//IL_0f61: Invalid comparison between F8 and I
		//IL_1059: Expected Obj, but got I4
		//IL_0afd: Invalid comparison between F4 and I4
		//IL_11f6: Expected Obj, but got I4
		//IL_119c: Expected Obj, but got I4
		//IL_0488: Expected F4, but got I
		//IL_1088: Expected Obj, but got I4
		//IL_1214: Invalid comparison between F4 and I
		//IL_0990: Expected Obj, but got I4
		//IL_0c07: Expected Obj, but got I
		//IL_0c31: Expected Obj, but got I4
		//IL_09c3: Expected Obj, but got I
		//IL_09e5: Expected Obj, but got I
		//IL_0a1d: Expected VT, but got I4
		//IL_0c66: Expected Obj, but got I
		//IL_0c91: Expected F4, but got I
		//IL_0cae: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num = walkSpeed / clipWalkSpeed;
		float num2 = (lurkT += dt);
		float num15;
		double num18;
		object obj2;
		bool chase;
		object obj;
		if (lurkPhase <= 1)
		{
			if (lurkPhase != 0)
			{
				if (lurkPhase != 1)
				{
					goto IL_0244;
				}
				float num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				float num4 = num3 / 0f;
				bool flag = num4 < 0f;
				double num5 = 0.0;
				if (!flag)
				{
					bool flag2 = !((double)num4 > 1.0);
					num5 = num4;
					if (!flag2)
					{
						num5 = 1.0;
					}
				}
				double num6 = num5 + num5;
				double num7 = num5 * 3.0;
				double num8 = num5 * num6;
				double num9 = num5 * num8;
				double num10 = num5 * num7;
				double num11 = num10 - num9;
				double num12 = 1.0 - num11;
				double num13 = num12 * 0.0;
				double num14 = num11 + num13;
				Transform transform = base.transform;
				if (num14 < 0.0 || num14 > 1.0)
				{
				}
				transform.position = (Vector3)0;
				num15 = lurkT;
				double num16 = num14 * 1119092736.0;
				ClimbPitch__BackingField = (float)num16;
				float num17 = lurkT;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				bool flag3 = num17 < 0f;
				num18 = 0.0;
				if (!flag3)
				{
					obj = this + 596;
					obj2 = 2;
					num18 = 0.0;
					goto IL_0df0;
				}
			}
			else
			{
				if (Spot(out var seen))
				{
					object obj3 = this + 432;
					prey = seen;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					hasPrey = true;
					chase = true;
					goto IL_1037;
				}
				Transform transform2 = base.transform;
				Vector3 position = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v73+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj7 = 109891584;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X0_v76+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num19 = (float)lurkFoot - num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v69 (MonsterBrain)+26C]");
				object obj12 = default;
				object obj11 = 0 - obj12;
				float num20 = num19 * num19;
				object obj13 = obj11 * obj11;
				float num21 = num20 + (float)obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				float radius = cc.radius;
				float num22 = radius;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
				float num23 = num22 + 0f;
				bool flag6 = num20 < num23;
				object obj14 = !flag6;
				float num24 = num20 - num23;
				bool flag7 = num24 == 0f;
				object obj15 = ~obj14;
				object obj16 = obj15 | flag7;
				if (obj16 == null)
				{
					float num25 = lurkT;
					if ((double)lurkT > 4.0)
					{
						chase = false;
						goto IL_1037;
					}
					float num26 = num21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					float num27 = num26 - 0f;
					bool flag8 = num27 < 0f;
					bool flag9 = num27 == 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					object obj17 = num21 ^ 0;
					object obj18 = num21 ^ num27;
					object obj19 = obj17 & obj18;
					bool flag10 = (nint)obj19 < 0;
					bool flag11 = flag8 == flag10;
					object obj20 = !flag9;
					object obj21 = flag11 & obj20;
					object obj22 = ~obj21;
					if (obj22 == null)
					{
					}
					bool isGrounded = cc.isGrounded;
					bool flag12 = !isGrounded;
					object obj23 = !flag12;
					float num28 = -1f;
					if (obj23 == null)
					{
						float num29 = gravity * dt;
						num25 = vy;
						num28 = vy - num29;
					}
					vy = num28;
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X22_v8+9A1]");
					bool flag13 = (nint)0 == 0;
					object obj25 = !flag13;
					if (obj25 == null)
					{
						_ = 1;
						obj24 = 0;
					}
					object obj26 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ X0_v87+E4]");
					bool flag14 = (nint)0 == 0;
					object obj27 = !flag14;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					if (num20 > 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1359 @ X8_v71+A0]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
					CollisionFlags collisionFlags = cc.Move((Vector3)0);
					num18 = 1.0;
					float num30 = default;
					num15 = num30;
				}
				else
				{
					cc.enabled = false;
					object obj31 = this + 596;
					vy = 0f;
					obj31 = 1;
					Transform transform3 = base.transform;
					Vector3 position2 = transform3.position;
					lurkFrom = (Vector3)num23;
					num18 = 0.0;
					num15 = num20;
				}
			}
		}
		else if (lurkPhase != 2)
		{
			if (lurkPhase != 3)
			{
				goto IL_0244;
			}
			ClimbPitch__BackingField = 90f;
			Glance(num2, 1f);
			if (Spot(out var seen2))
			{
				object obj32 = this + 432;
				prey = seen2;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				hasPrey = true;
				Drop();
				num18 = 0.0;
				num15 = 0f;
			}
			else
			{
				num15 = lurkHold;
				bool flag15 = !(lurkT > lurkHold);
				num18 = 0.0;
				if (!flag15)
				{
					hasPrey = false;
					Drop();
					num18 = 0.0;
				}
			}
		}
		else
		{
			ClimbPitch__BackingField = 90f;
			Transform transform4 = base.transform;
			Vector3 position3 = transform4.position;
			Transform transform5 = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v69 (MonsterBrain)+268]");
			float num31 = 0f + lurkHeight;
			float num32 = climbSpeed * dt;
			float num33 = (float)lurkInto + num32;
			float num34 = ((!(num33 < num31)) ? num31 : num33);
			transform5.position = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			num = climbSpeed / clipWalkSpeed;
			num15 = lurkHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v69 (MonsterBrain)+268]");
			float num35 = 0f + lurkHeight;
			bool flag16 = num34 < num35;
			num18 = 1.0;
			if (!flag16)
			{
				obj = this + 596;
				obj2 = 3;
				num18 = 1.0;
				goto IL_0df0;
			}
		}
		goto IL_0de1;
		IL_1037:
		EndLurk(chase);
		return;
		IL_0de1:
		Transform transform6 = base.transform;
		Vector3 eulerAngles = transform6.eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj33 = 0;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v11+A0]");
		object obj35 = 0;
		Vector3 forward = default;
		Vector3 upwards = default;
		Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
		Quaternion rotation = default;
		Vector3 vector = Quaternion.Internal_ToEulerRad(ref rotation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X8_v12+20]");
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
		object obj36 = num36 * 0;
		Vector3 vector2 = Quaternion.Internal_MakePositive((Vector3)0);
		float num37 = (float)obj36 - num15;
		float num38 = num37 / 1.13587E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num39 = num38 * 1.13587E+09f;
		float num40 = num37 - num39;
		float maxSpeed = turnSpeed + turnSpeed;
		bool flag17 = num40 < 0f;
		float num41 = 0f;
		if (!flag17)
		{
			bool flag18 = num40 > 1.13587E+09f;
			float num42 = 1.13587E+09f;
			if (!flag18)
			{
				bool flag19 = !(num40 > 1.1274813E+09f);
				num42 = num40;
				num41 = num40;
				if (flag19)
				{
					goto IL_1111;
				}
			}
			num41 = num42 + 3.2833536E+09f;
		}
		goto IL_1111;
		IL_0df0:
		obj = obj2;
		goto IL_0de1;
		IL_1111:
		float target = num15 + num41;
		ref float currentVelocity = ref *(float*)(this + 500);
		float current = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		float num43 = Mathf.SmoothDamp(current, target, ref currentVelocity, 0f, maxSpeed, dt);
		Transform transform7 = base.transform;
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref forward);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj37 = 0;
		transform7.rotation = (Quaternion)0;
		PoseClimb();
		object obj38 = obj37;
		AnimSpeed__BackingField = (float)num18;
		double num44 = ((!((double)num < 0.5)) ? ((double)num) : 0.5);
		AnimPace__BackingField = (float)num44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1311 @ X0_v21+E4]");
		bool flag20 = (nint)0 == 0;
		object obj39 = !flag20;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (this.animator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj40 = 0;
			object obj41 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ X0_v25+E4]");
			bool flag21 = (nint)0 == 0;
			object obj42 = !flag21;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj43 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ X8_v20+A0]");
			object obj44 = 0;
			Animator animator = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1375 @ X8_v21+10]");
			nint num45 = 0;
			double num46 = num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			animator.SetFloat((int)num45, (float)num46, 0f, dt);
			object obj45 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X8_v23+A0]");
			object obj46 = 0;
			Animator animator2 = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X8_v24+14]");
			animator2.SetFloat(0, AnimPace__BackingField);
		}
		return;
		IL_0244:
		float num47 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
		float num48 = num47 / 0f;
		bool flag22 = num48 < 0f;
		double num49 = 0.0;
		if (!flag22)
		{
			bool flag23 = !((double)num48 > 1.0);
			num49 = num48;
			if (!flag23)
			{
				num49 = 1.0;
			}
		}
		Transform transform8 = base.transform;
		bool flag24 = num49 < 0.0;
		double num50 = 0.0;
		if (!flag24)
		{
			bool flag25 = !(num49 > 1.0);
			num50 = num49;
			if (!flag25)
			{
				num50 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v69 (MonsterBrain)+290]");
		nint num51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v69 (MonsterBrain)+284]");
		object obj47 = num51 - 0;
		double num52 = (double)obj47 * num50;
		double num53 = num49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
		double num54 = num53 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		transform8.position = (Vector3)0;
		double num55 = lurkT;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		double num56 = num55 / 0.0;
		bool flag26 = num56 < 0.0;
		double num57 = 0.0;
		if (!flag26)
		{
			bool flag27 = num56 > 1.0;
			num57 = 1.0;
			if (!flag27)
			{
				num57 = num56;
			}
		}
		double num58 = num57 + num57;
		double num59 = num57 * 3.0;
		double num60 = num57 * num58;
		double num61 = num57 * num60;
		double num62 = num57 * num59;
		double num63 = num62 - num61;
		double num64 = 1.0 - num63;
		double num65 = num64 * 0.0;
		double num66 = num63 + num65;
		double num67 = 1.0 - num66;
		double num68 = num67 * 1119092736.0;
		ClimbPitch__BackingField = (float)num68;
		bool flag28 = (byte)(~(hasPrey ? 1u : 0u)) != 0;
		num15 = 1.1190927E+09f;
		if (!flag28)
		{
			Vector3 position4 = ((Transform)prey).position;
			Transform transform9 = base.transform;
			Vector3 position5 = transform9.position;
			double num69 = num68 - num68;
			double num70 = num64 - num64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj48 = 0;
			object obj49 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ X0_v49+E4]");
			bool flag29 = (nint)0 == 0;
			object obj50 = !flag29;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num71 = num69 * num69;
			double num72 = num70 * num70;
			double num73 = num71 + num72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			num15 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			if (num73 < 0.0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v69 (MonsterBrain)+278]");
				num15 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			}
		}
		bool flag30 = num49 < 1.0;
		num18 = 0.0;
		if (!flag30)
		{
			EndLurk(hasPrey);
			return;
		}
		goto IL_0de1;
	}

	private unsafe void Drop()
	{
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0142: Expected Obj, but got I4
		//IL_001d: Expected VT, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I4
		//IL_00db: Expected VT, but got I8
		//IL_00db: Expected VT, but got Ref
		//IL_0129: Expected Obj, but got I
		//IL_01b0: Expected VT, but got F4
		object obj = this + 596;
		obj = 4;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		lurkFrom = (Vector3)0;
		Transform transform2 = base.transform;
		Vector3 position2 = transform2.position;
		Transform transform3 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj2 = 0;
		Vector3 position3 = transform3.position;
		Vector3 vector = lurkInto;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		object obj3 = vector * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+278]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		object obj4 = num * 0;
		float num2 = 0f - (float)obj3;
		object obj5 = obj2;
		object obj7 = default;
		object obj6 = obj7 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num3 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		if (Physics.Raycast((Vector3)(&num3), (Vector3)4294965499L, out *(RaycastHit*)1, num2, 0, queryTriggerInteraction))
		{
			object obj10 = default;
			object obj9 = obj10;
			num2 = num3;
			object obj11 = default;
			obj6 = obj11;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+268]");
			object obj9 = 0;
		}
		lurkLand = (Vector3)num2;
	}

	private void EndLurk(bool chase)
	{
		//IL_0125: Expected VT, but got I4
		lurking = false;
		ClimbPitch__BackingField = 0f;
		PoseClimb();
		cc.enabled = true;
		vy = 0f;
		repathAt = 0f;
		if (chase && ~(hasPrey ? 1u : 0u) == 0)
		{
			state__BackingField = (State)2;
			Chasing__BackingField = true;
			float num = runSpeed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			float num2 = num * 0f;
			reachedFor = 0f;
			listening = false;
			stateT = 0f;
			speed = num2;
		}
		else
		{
			state__BackingField = (State)0;
			Chasing__BackingField = false;
			stateT = 0f;
			reachedFor = 0f;
			listening = false;
			hasPrey = false;
			PickWander((Vector3?)(object)0);
		}
	}

	public void ShowPuppet(float animSpeed, float pace, Vector3 look, float lookWeight)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0127: Expected VT, but got F4
		//IL_0171: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I
		//IL_00dc: Expected F4, but got I
		//IL_00f9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		LookPoint__BackingField = (Vector3)lookWeight;
		AnimSpeed__BackingField = animSpeed;
		AnimPace__BackingField = pace;
		float num = default;
		LookWeight__BackingField = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(this.animator == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v7+A0]");
			object obj7 = 0;
			float deltaTime = Time.deltaTime;
			Animator animator = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v5+10]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			animator.SetFloat((int)num2, animSpeed, 0f, deltaTime);
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v8+A0]");
			object obj9 = 0;
			Animator animator2 = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+14]");
			animator2.SetFloat(0, pace);
		}
	}

	public void ShowPry(bool on)
	{
		//IL_0010: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Prying__BackingField = on;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (this.animator != null && ~(hasPry ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+A0]");
			object obj8 = 0;
			Animator animator = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+1C]");
			animator.SetBool(0, on);
		}
	}

	public void PlayKill()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
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
		if (!(this.animator == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+A0]");
			object obj8 = 0;
			Animator animator = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+14]");
			animator.SetFloat(0, 1f);
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v8+A0]");
			object obj10 = 0;
			Animator animator2 = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v9+18]");
			animator2.SetTrigger(0);
		}
	}

	private void Begin(State s, float notice = default(float))
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_01f3: Expected Obj, but got I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_00f4: Invalid comparison between F4 and I4
		//IL_018f: Expected Obj, but got I4
		//IL_0125: Expected F4, but got I
		//IL_0125: Expected F4, but got I
		object obj = s - 6;
		state__BackingField = s;
		bool flag = (nint)obj < 2;
		object obj2 = !flag;
		bool flag3;
		object obj4;
		if (obj2 == null)
		{
			object obj3 = pryFrom - 2;
			bool flag2 = obj3 == null;
			flag3 = flag2;
		}
		else
		{
			if (s == (State)2)
			{
				stateT = 0f;
				Chasing__BackingField = true;
				obj4 = this + 848;
				reachedFor = 0f;
				goto IL_01ea;
			}
			flag3 = false;
		}
		bool flag4 = s == (State)3;
		Chasing__BackingField = flag3;
		stateT = 0f;
		reachedFor = 0f;
		if (!flag4)
		{
			if (s != (State)1)
			{
				bool flag5 = s == (State)5;
				listening = false;
				if (!flag5)
				{
					bool flag6 = s == 0;
					object obj5 = !flag6;
					if (obj5 != null)
					{
						return;
					}
				}
				obj4 = this + 464;
				goto IL_01ea;
			}
			float num = default;
			if (!(num > 0f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				num = UnityEngine.Random.Range(num2, 0f);
			}
			noticeFor = num;
		}
		else
		{
			searchFor = 9f;
		}
		obj4 = this + 848;
		goto IL_01ea;
		IL_01ea:
		obj4 = 0;
	}

	private unsafe static (int, int) Key(MonsterCatalog.Target t)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_017d: Expected VT, but got I4
		//IL_0197: Expected VT, but got Ref
		//IL_01ee: Expected native int or pointer, but got VT
		//IL_00e9: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I4
		//IL_01aa: Expected VT, but got Obj
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected VT, but got Unknown
		//IL_0147: Expected Ref, but got VT
		//IL_0155: Expected VT, but got I4
		//IL_016e: Expected VT, but got Ref
		//IL_008e: Expected VT, but got I4
		//IL_00a7: Expected VT, but got Ref
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
		(int, int) result;
		int item;
		int item2;
		(int, int) tuple;
		if ((UnityEngine.Object)t.dummy != (UnityEngine.Object)null)
		{
			if ((object)t.dummy == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return ((int, int))ex;
			}
			((object)t.dummy).Finalize();
			result = ((int, int))0;
			int num = default;
			item = num;
			item2 = 2;
			tuple = ((int, int))(&result);
		}
		else
		{
			bool flag2 = !t.local;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v9+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef playerRef = (PlayerRef)(t + 8);
				int playerId = ((PlayerRef*)playerRef)->PlayerId;
				result = ((int, int))0;
				item = playerId;
				item2 = 0;
				tuple = ((int, int))(&result);
			}
			else
			{
				result = ((int, int))0;
				item = 0;
				item2 = 1;
				tuple = ((int, int))(&result);
			}
		}
		*((int, int)*)(nint)tuple = (item2, item);
		return result;
	}

	private unsafe bool Watched()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0018: Expected Obj, but got Ref
		//IL_107d: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I
		//IL_010e: Expected VT, but got I4
		//IL_0118: Expected F4, but got I4
		//IL_012b: Expected Obj, but got I4
		//IL_0084: Expected VT, but got I4
		//IL_008e: Expected F4, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_10f5: Expected Obj, but got I
		//IL_1112: Expected Obj, but got I
		//IL_112f: Expected Obj, but got I
		//IL_114c: Expected Obj, but got I
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Expected VT, but got Unknown
		//IL_1179: Expected F4, but got Obj
		//IL_1182: Expected VT, but got I4
		//IL_00d9: Expected F4, but got I4
		//IL_10a6: Expected VT, but got I4
		//IL_10ca: Expected Obj, but got I4
		//IL_0170: Expected VT, but got I4
		//IL_019c: Expected Obj, but got I4
		//IL_01ed: Expected VT, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I8
		//IL_024d: Expected VT, but got I4
		//IL_026f: Expected Obj, but got I4
		//IL_02be: Expected VT, but got I4
		//IL_02d8: Expected Obj, but got I4
		//IL_11a7: Expected VT, but got I4
		//IL_11c9: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0369: Expected VT, but got I4
		//IL_0393: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I
		//IL_03e9: Expected VT, but got I
		//IL_0448: Expected VT, but got I4
		//IL_045f: Expected Obj, but got I4
		//IL_0470: Expected Obj, but got I4
		//IL_0499: Expected Obj, but got I
		//IL_04a9: Expected Obj, but got I
		//IL_04b9: Expected Obj, but got I
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Ref
		//IL_04f9: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I4
		//IL_08b0: Expected VT, but got I4
		//IL_08b9: Expected F8, but got I4
		//IL_08c2: Expected Obj, but got I4
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected Obj, but got I4
		//IL_0903: Expected Obj, but got I4
		//IL_0911: Expected Obj, but got I4
		//IL_1324: Expected Obj, but got I
		//IL_132c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1335: Expected Ref, but got Unknown
		//IL_134f: Expected Obj, but got I4
		//IL_051f: Expected F4, but got I
		//IL_053f: Expected Obj, but got I
		//IL_0561: Expected Obj, but got I4
		//IL_05a6: Expected Obj, but got I4
		//IL_05af: Expected Obj, but got I4
		//IL_091f: Invalid comparison between F8 and I4
		//IL_0930: Expected Obj, but got I4
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected Obj, but got Unknown
		//IL_05e7: Expected Obj, but got I4
		//IL_060c: Expected F4, but got Obj
		//IL_0627: Expected VT, but got Ref
		//IL_0662: Expected Obj, but got I4
		//IL_0985: Expected Obj, but got I4
		//IL_07ef: Expected VT, but got I4
		//IL_0800: Expected F8, but got I4
		//IL_0809: Expected Obj, but got I4
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected Obj, but got I4
		//IL_084a: Expected Obj, but got I4
		//IL_09cd: Expected Obj, but got I
		//IL_0e35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3a: Expected I4, but got Unknown
		//IL_0875: Expected Obj, but got I
		//IL_08a1: Expected Obj, but got I4
		//IL_0e52: Expected VT, but got I4
		//IL_0e63: Expected F8, but got I4
		//IL_0e6c: Expected Obj, but got I4
		//IL_0e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e94: Expected Obj, but got I4
		//IL_0ead: Expected Obj, but got I4
		//IL_0aac: Expected Obj, but got I
		//IL_0abc: Expected VT, but got I
		//IL_0acc: Expected Obj, but got I
		//IL_0ad4: Expected F4, but got VT
		//IL_0726: Expected VT, but got I4
		//IL_0737: Expected F8, but got I4
		//IL_0740: Expected Obj, but got I4
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected Obj, but got I4
		//IL_12d4: Expected Obj, but got I
		//IL_12f6: Expected F8, but got I4
		//IL_12ff: Expected Obj, but got I4
		//IL_1303: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected Obj, but got I
		//IL_0af9: Invalid comparison between F4 and VT
		//IL_0b42: Expected F8, but got I4
		//IL_0b4b: Expected Obj, but got I4
		//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected Obj, but got I
		//IL_0b81: Expected I, but got Obj
		//IL_0b97: Expected Obj, but got I
		//IL_0bc4: Expected F8, but got I4
		//IL_0bcd: Expected Obj, but got I4
		//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Expected Obj, but got I
		//IL_0c24: Expected Obj, but got I4
		//IL_0c84: Expected Obj, but got I
		//IL_0c94: Expected Obj, but got I
		//IL_0ca4: Expected Obj, but got I
		//IL_0cb6: Expected VT, but got F8
		//IL_0c4f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj3 = default;
		object obj2 = (object)(&obj3);
		object obj4 = obj;
		Vector3[] array = parts;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = face != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj6 = 0;
		Dictionary<(int, int), float>.Enumerator enumerator;
		Dictionary<(int, int), float>.Enumerator enumerator2;
		double num2;
		Dictionary<(int, int), float> dictionary;
		float num;
		UnityEngine.Object obj8;
		Dictionary<(int, int), float>.Enumerator enumerator3 = default;
		double num3 = default;
		Dictionary<(int, int), float>.Enumerator enumerator4;
		object obj7;
		MonsterBrain monsterBrain;
		if (flag2)
		{
			bool flag3 = (object)face == null;
			enumerator = (Dictionary<(int, int), float>.Enumerator)0;
			num = 0f;
			dictionary = (Dictionary<(int, int), float>)(object)parts;
			obj7 = 0;
			obj8 = null;
			monsterBrain = this;
			if (flag3)
			{
				goto IL_0eeb;
			}
			Vector3 position = face.position;
			enumerator2 = enumerator3;
			num = 0f;
			num2 = num3;
			obj8 = null;
		}
		else
		{
			Transform transform = base.transform;
			bool flag4 = (object)transform == null;
			enumerator = (Dictionary<(int, int), float>.Enumerator)0;
			num = 0f;
			dictionary = (Dictionary<(int, int), float>)(object)parts;
			obj7 = 0;
			obj8 = null;
			monsterBrain = this;
			if (flag4)
			{
				goto IL_0eeb;
			}
			Vector3 position2 = transform.position;
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v67+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v68+20]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
			object obj11 = num4 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v68+18]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
			object obj12 = num5 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v68+1C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
			object obj13 = num6 * 0;
			num2 = num3 + (double)obj13;
			enumerator2 = (Dictionary<(int, int), float>.Enumerator)(enumerator3 + obj11);
			nint num7 = 17276928;
			num = (float)obj12;
			enumerator4 = (Dictionary<(int, int), float>.Enumerator)0;
			obj8 = null;
		}
		bool flag5 = parts == null;
		enumerator = (Dictionary<(int, int), float>.Enumerator)0;
		enumerator3 = enumerator2;
		num3 = num2;
		dictionary = (Dictionary<(int, int), float>)(object)parts;
		obj7 = 0;
		monsterBrain = this;
		double num9 = default;
		Enumerator<, > val2 = default;
		UnityEngine.Object obj26 = default;
		object obj27;
		UnityEngine.Object obj30 = default;
		Dictionary<(int, int), float>.Enumerator enumerator6 = default;
		Transform transform3;
		double num15;
		double num8;
		IndexOutOfRangeException ex;
		object obj35;
		Enumerator<, > val3;
		double num11;
		object obj21;
		if (!flag5)
		{
			bool flag6 = array.Length == 0;
			enumerator = (Dictionary<(int, int), float>.Enumerator)0;
			num8 = num9;
			enumerator3 = enumerator2;
			num3 = num2;
			dictionary = (Dictionary<(int, int), float>)(object)parts;
			obj7 = 0;
			monsterBrain = this;
			if (flag6)
			{
				goto IL_0f0f;
			}
			dictionary = (Dictionary<(int, int), float>)(object)parts;
			Vector3 middle = Middle;
			bool flag7 = parts == null;
			enumerator = (Dictionary<(int, int), float>.Enumerator)0;
			enumerator3 = enumerator2;
			num3 = num2;
			obj7 = 0;
			monsterBrain = this;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X22_v18 (System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32, System.Int32>, System.Single>)+18]");
				object obj14 = 0 & 0xFFFFFFFEL;
				bool flag8 = obj14 == null;
				enumerator = (Dictionary<(int, int), float>.Enumerator)0;
				num8 = num9;
				enumerator3 = enumerator2;
				num3 = num2;
				obj7 = 0;
				monsterBrain = this;
				if (flag8)
				{
					goto IL_0f0f;
				}
				dictionary = (Dictionary<(int, int), float>)(object)parts;
				Transform transform2 = base.transform;
				bool flag9 = (object)transform2 == null;
				enumerator = (Dictionary<(int, int), float>.Enumerator)0;
				enumerator3 = enumerator2;
				num3 = num2;
				obj7 = 0;
				obj8 = null;
				monsterBrain = this;
				if (!flag9)
				{
					Vector3 position3 = transform2.position;
					bool flag10 = parts == null;
					enumerator = (Dictionary<(int, int), float>.Enumerator)0;
					enumerator3 = enumerator2;
					num3 = num2;
					enumerator4 = enumerator2;
					obj7 = 0;
					obj8 = null;
					monsterBrain = this;
					if (!flag10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X22_v18 (System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32, System.Int32>, System.Single>)+18]");
						bool flag11 = (nint)0 < (nint)2;
						object obj15 = !flag11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X22_v18 (System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32, System.Int32>, System.Single>)+18]");
						object obj16 = -2;
						bool flag12 = obj16 == null;
						object obj17 = ~obj15;
						object obj18 = obj17 | flag12;
						enumerator = (Dictionary<(int, int), float>.Enumerator)0;
						num8 = num9;
						enumerator3 = enumerator2;
						num3 = num2;
						enumerator4 = enumerator2;
						obj7 = 0;
						obj8 = null;
						monsterBrain = this;
						if (obj18 != null)
						{
							goto IL_0f0f;
						}
						object obj19 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X8_v38+A0]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v39+20]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v39+18]");
						enumerator3 = (Dictionary<(int, int), float>.Enumerator)((nint)0 * (nint)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v39+20]");
						double num10 = 0.0 * 0.25;
						num += (float)enumerator3;
						num3 = (double)enumerator2 + num10;
						bool flag13 = targets == null;
						enumerator = (Dictionary<(int, int), float>.Enumerator)0;
						num11 = 0.25;
						obj21 = 0;
						enumerator4 = enumerator2;
						obj7 = 0;
						obj8 = null;
						monsterBrain = this;
						if (!flag13)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA80]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA48]");
							object obj24 = 0;
							Enumerator<, > enumerator5 = targets.GetEnumerator();
							Enumerator<, > val = (Enumerator<, >)(ref val2);
							object obj25 = (object)(&obj26);
							float num12 = default;
							num = num12;
							obj27 = 0;
							obj7 = 0;
							while (val2.MoveNext())
							{
								object obj28 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X23_v3 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								num = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ X0_v40+E4]");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X23_v3 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								obj2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ X0_v40+E4]");
								bool flag14 = (nint)0 == 0;
								object obj29 = !flag14;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag15 = obj30 == null;
								bool flag16 = !flag15;
								object obj31 = !flag16;
								obj7 = 0;
								if (obj31 != null)
								{
									continue;
								}
								object obj32 = obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X0_v44+E4]");
								bool flag17 = (nint)0 == 0;
								object obj33 = !flag17;
								if (obj33 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								num = (float)obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X23_v3 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+28]");
								_ = 0;
								(int, int) key = Key((MonsterCatalog.Target)(&obj26));
								bool flag18 = LooksAtMe((Transform)obj30);
								dictionary = marked;
								bool flag19 = !flag18;
								object obj34 = !flag19;
								if (obj34 == null)
								{
									if (marked == null)
									{
										goto IL_0e3f;
									}
									obj7 = obj24;
									bool flag20 = marked.ContainsKey(key);
									bool flag21 = !flag20;
									obj26 = obj30;
									if (flag21)
									{
										continue;
									}
									bool flag22 = CanSee((Transform)obj30);
									bool flag23 = !flag22;
									obj26 = obj30;
									if (flag23)
									{
										continue;
									}
									num = Time.time;
									bool flag24 = marked == null;
									enumerator = (Dictionary<(int, int), float>.Enumerator)0;
									obj26 = obj30;
									num8 = 0.0;
									obj35 = 0;
									val3 = (Enumerator<, >)(ref val2);
									enumerator3 = enumerator6;
									num11 = 0.25;
									obj21 = 0;
									num3 = num9;
									enumerator4 = enumerator2;
									obj8 = obj30;
									monsterBrain = this;
									if (!flag24)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA68]");
										object obj36 = 0;
										obj7 = obj36;
										marked.set_Item(key, num);
										obj26 = obj30;
										continue;
									}
									goto IL_0f01;
								}
								num = Time.time;
								bool flag25 = marked == null;
								enumerator = (Dictionary<(int, int), float>.Enumerator)0;
								obj26 = obj30;
								num8 = 0.0;
								obj35 = 0;
								val3 = (Enumerator<, >)(ref val2);
								enumerator3 = enumerator6;
								num11 = 0.25;
								obj21 = 0;
								num3 = num9;
								enumerator4 = enumerator2;
								obj7 = 0;
								obj8 = obj30;
								monsterBrain = this;
								if (!flag25)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA68]");
									object obj37 = 0;
									obj7 = obj37;
									marked.set_Item(key, num);
									obj26 = obj30;
									obj27 = 1;
									continue;
								}
								goto IL_0f3a;
							}
							enumerator = (Dictionary<(int, int), float>.Enumerator)0;
							double num13 = 0.0;
							obj35 = 0;
							val3 = (Enumerator<, >)(ref val2);
							enumerator3 = enumerator6;
							num11 = 0.25;
							obj21 = 0;
							num3 = num9;
							enumerator4 = enumerator2;
							object obj38 = 7;
							monsterBrain = this;
							object obj39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA70]");
							object obj40 = 0;
							obj8 = (UnityEngine.Object)obj40;
							((Enumerator<, >*)val3)->Dispose();
							bool flag26 = obj39 == null;
							object obj41 = !flag26;
							num8 = num13;
							if (obj41 != null)
							{
								goto IL_0f2c;
							}
							bool flag27 = num13 == 0.0;
							object obj42 = !flag27;
							num8 = num13;
							ex = (IndexOutOfRangeException)val3;
							if (obj42 != null)
							{
								goto IL_0f1d;
							}
							if ((nint)obj38 != 7)
							{
								bool flag28 = obj38 == null;
								object obj43 = !flag28;
								if (obj43 != null)
								{
									goto IL_0e2c;
								}
							}
							bool flag29 = monsterBrain.marked == null;
							num9 = num13;
							if (!flag29)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA60]");
								object obj44 = 0;
								obj8 = (UnityEngine.Object)obj44;
								int count = monsterBrain.marked.Count;
								if (count <= 0)
								{
									goto IL_0e2c;
								}
								List<(int, int)> list = monsterBrain.unmark;
								bool flag30 = monsterBrain.unmark == null;
								num9 = num13;
								if (!flag30)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v12 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+1C]");
									nint num7 = (nint)0 + (nint)1;
									_ = 0;
									bool flag31 = monsterBrain.marked == null;
									num9 = num13;
									if (!flag31)
									{
										Dictionary<(int, int), float>.Enumerator enumerator7 = monsterBrain.marked.GetEnumerator();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA88]");
										object obj45 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
										enumerator4 = (Dictionary<(int, int), float>.Enumerator)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69B0]");
										dictionary = (Dictionary<(int, int), float>)0;
										Dictionary<(int, int), float>.Enumerator enumerator8 = default;
										num = (float)enumerator8;
										double num14 = default;
										while (true)
										{
											transform3 = (Transform)obj45;
											if (!enumerator.MoveNext())
											{
												break;
											}
											float time = Time.time;
											num = time - (float)num14;
											if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) <= System.Runtime.CompilerServices.Unsafe.As<Dictionary<(int, int), float>.Enumerator, UIntPtr>(ref enumerator4))
											{
												continue;
											}
											List<(int, int)> list2 = monsterBrain.unmark;
											bool flag32 = monsterBrain.unmark == null;
											enumerator = enumerator8;
											num15 = 0.0;
											obj35 = 0;
											val3 = (Enumerator<, >)(ref enumerator);
											num3 = num13;
											if (!flag32)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X0_v27 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
												object obj46 = 0;
												num7 = (nint)dictionary;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X0_v27 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+1C]");
												object obj47 = (nint)0 + (nint)1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X0_v27 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
												bool flag33 = (nint)0 == 0;
												enumerator = enumerator8;
												num15 = 0.0;
												obj35 = 0;
												val3 = (Enumerator<, >)(ref enumerator);
												num3 = num13;
												if (!flag33)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X0_v27 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
													obj47 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X0_v27 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
													nint num16 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ X8_v28+18]");
													bool flag34 = num16 < 0;
													object obj48 = !flag34;
													if (obj48 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X0_v27 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
														nint num17 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X0_v27 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
														object obj49 = num17 + 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X0_v27 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
														num7 = (nint)0 + (nint)1;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X9_v5 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32, System.Int32>, System.Single>>)+20]");
														object obj50 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ X8_v29+A8]");
														object obj51 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X8_v30+70]");
														obj7 = 0;
														monsterBrain.unmark.AddWithResize(((int, int))num13);
													}
													continue;
												}
											}
											goto IL_0ebf;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA78]");
										object obj52 = 0;
										obj8 = (UnityEngine.Object)obj52;
										enumerator.Dispose();
										enumerator = enumerator8;
										num8 = 0.0;
										obj35 = 0;
										val3 = (Enumerator<, >)(ref enumerator);
										num3 = num13;
										goto IL_0f2c;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0eeb;
		IL_0f3a:
		throw new NullReferenceException();
		IL_0eeb:
		NullReferenceException ex2 = new NullReferenceException();
		num8 = num9;
		goto IL_0f01;
		IL_0e2c:
		return (byte)(obj27 & 1) != 0;
		IL_0f01:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0f0f;
		IL_0f2c:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		goto IL_0f3a;
		IL_0f1d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0f2c;
		IL_0ebf:
		NullReferenceException ex5 = new NullReferenceException();
		obj8 = transform3;
		NullReferenceException ex6 = new NullReferenceException();
		num9 = num15;
		goto IL_0eeb;
		IL_0f0f:
		ex = new IndexOutOfRangeException();
		goto IL_0f1d;
		IL_0e3f:
		NullReferenceException ex7 = new NullReferenceException();
		enumerator = (Dictionary<(int, int), float>.Enumerator)0;
		obj26 = obj30;
		num15 = 0.0;
		obj35 = 0;
		val3 = (Enumerator<, >)(ref val2);
		enumerator3 = enumerator6;
		num11 = 0.25;
		obj21 = 0;
		num3 = num9;
		enumerator4 = enumerator2;
		obj7 = 0;
		transform3 = (Transform)obj30;
		monsterBrain = this;
		goto IL_0ebf;
	}

	private bool LooksAtMe(Transform head)
	{
		//IL_062b: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected I4, but got Unknown
		//IL_0135: Expected Obj, but got I8
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I4
		//IL_0199: Expected F4, but got I
		//IL_073f: Expected Obj, but got I4
		//IL_0655: Expected Obj, but got I4
		//IL_025a: Invalid comparison between F4 and I
		//IL_0543: Expected Obj, but got I4
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected Obj, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected Obj, but got Unknown
		//IL_05ce: Expected Obj, but got I4
		//IL_0292: Invalid comparison between F4 and I4
		//IL_02a3: Expected Obj, but got I4
		//IL_068d: Expected Obj, but got I4
		//IL_02fe: Invalid comparison between F4 and I
		//IL_0314: Expected Obj, but got I
		//IL_031d: Expected F4, but got I4
		//IL_06bf: Invalid comparison between F4 and I4
		//IL_06d0: Expected Obj, but got I4
		//IL_0455: Expected VT, but got I
		//IL_0455: Expected VT, but got I4
		//IL_0480: Expected F4, but got I
		//IL_0490: Expected F4, but got I
		//IL_0718: Expected Obj, but got I4
		//IL_04c5: Expected VT, but got I
		//IL_04c5: Expected VT, but got I4
		//IL_04e3: Expected Obj, but got I4
		//IL_0513: Expected F4, but got I
		//IL_0523: Expected F4, but got I
		object obj5;
		if ((object)head != null)
		{
			Vector3 position = head.position;
			Vector3 forward = head.forward;
			Vector3[] array = parts;
			if (parts != null)
			{
				bool flag = array.Length < 0;
				bool flag2 = array.Length == 0;
				object obj = array.Length ^ array.Length;
				object obj2 = array.Length & obj;
				bool flag3 = (nint)obj2 < 0;
				bool flag4 = flag == flag3;
				object obj3 = !flag2;
				object obj4 = flag4 & obj3;
				bool flag5 = array.Length < 1;
				obj5 = obj4;
				if (flag5)
				{
					goto IL_05fc;
				}
				float num2 = default;
				float num = num2 * num2;
				float num4 = default;
				float num3 = num4 * num4;
				object obj6 = array.Length & 0xFFFFFFFFL;
				object obj8 = default;
				object obj7 = obj8 * obj8;
				object obj9 = parts + 40;
				float num5 = num + num3;
				float num6 = (float)obj7 + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj10 = 0;
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
				float num7 = 0f;
				object obj12 = obj4;
				IntPtr intPtr = default;
				while (true)
				{
					bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
					object obj13 = !flag6;
					if (obj13 != null)
					{
						break;
					}
					object obj14 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v12+E4]");
					bool flag7 = (nint)0 == 0;
					object obj15 = !flag7;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X24_v5-8]");
					float num8 = 0f - num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X24_v5-4]");
					float num9 = 0f - num4;
					object obj16 = obj9 - obj8;
					float num10 = num8 * num8;
					float num11 = num9 * num9;
					num7 = num10 + num11;
					num3 = (float)obj16 * (float)obj16;
					float num12 = num7 + num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num13 = num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
					if (!(num13 < 0f))
					{
						num3 = gazeRange;
						float num14 = num7 - gazeRange;
						bool flag8 = num14 == 0f;
						obj3 = !flag8;
						if (!(num7 > gazeRange))
						{
							object obj17 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v16+E4]");
							bool flag9 = (nint)0 == 0;
							object obj18 = !flag9;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num15 = num6 * num12;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
							bool flag10 = num15 < 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
							obj7 = 0;
							num3 = 0f;
							if (!flag10)
							{
								float num16 = num2 * num8;
								float num17 = num4 * num9;
								float num18 = num16 + num17;
								obj7 = obj8 * obj16;
								double num19 = (double)obj7 + (double)num18;
								double num20 = num19 / (double)num15;
								bool flag11 = num20 < -1.0;
								double num21 = -1.0;
								if (!flag11)
								{
									bool flag12 = !(num20 > 1.0);
									num21 = num20;
									num19 = 1.0;
									if (!flag12)
									{
										num21 = 1.0;
										num19 = 1.0;
									}
								}
								object obj19 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v24+E4]");
								bool flag13 = (nint)0 == 0;
								object obj20 = !flag13;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
								double num22 = num21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
								double num23 = num22 * 0.0;
								num3 = (float)num23;
							}
							num7 = gazeAngle;
							float num24 = num3 - gazeAngle;
							bool flag14 = num24 == 0f;
							obj3 = !flag14;
							if (!(num3 > gazeAngle))
							{
								bool flag15 = Unblocked((Vector3)0, (Vector3)(nint)intPtr);
								bool flag16 = !flag15;
								object obj21 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X24_v5-4]");
								float num25 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X24_v5-8]");
								float num26 = 0f;
								obj7 = obj8;
								num7 = num2;
								num3 = num4;
								if (!flag16)
								{
									bool flag17 = Unblocked((Vector3)0, (Vector3)(nint)intPtr);
									bool flag18 = !flag17;
									object obj22 = !flag18;
									obj21 = obj8;
									num25 = num4;
									num26 = num2;
									obj7 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X24_v5-8]");
									num7 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X24_v5-4]");
									num3 = 0f;
									obj5 = obj12;
									if (obj22 != null)
									{
										goto IL_05fc;
									}
								}
							}
						}
					}
					obj6 = array.Length;
					obj11++;
					obj9 += 12;
					object obj23 = obj11 - array.Length;
					bool flag19 = (nint)obj23 < 0;
					object obj24 = obj11 ^ array.Length;
					object obj25 = obj11 ^ obj23;
					object obj26 = obj24 & obj25;
					bool flag20 = (nint)obj26 < 0;
					bool flag21 = flag19 == flag20;
					object obj27 = !flag21;
					bool flag22 = (nint)obj11 < array.Length;
					obj5 = obj27;
					obj12 = obj27;
					if (flag22)
					{
						continue;
					}
					goto IL_05fc;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_05fc:
		return (byte)(obj5 & 1) != 0;
	}

	private unsafe bool Unblocked(Vector3 a, Vector3 b)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_0044: Expected VT, but got I8
		//IL_0044: Expected VT, but got Ref
		//IL_00fd: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RaycastHit raycastHit = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		bool flag2 = Physics.Linecast((Vector3)(&raycastHit), (Vector3)4294965499L, out *(RaycastHit*)1, 0, queryTriggerInteraction);
		bool flag3 = !flag2;
		bool result = true;
		if (!flag3)
		{
			Collider collider = raycastHit.collider;
			if ((object)collider != null)
			{
				Transform transform = collider.transform;
				Transform parent = base.transform;
				if ((object)transform != null)
				{
					bool flag4 = transform.IsChildOf(parent);
					result = flag4;
					goto IL_0135;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_0135;
		IL_0135:
		return result;
	}

	private void Hold(float dt)
	{
		//IL_002c: Expected VT, but got I4
		//IL_0155: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_0133: Expected VT, but got I4
		//IL_0140: Expected VT, but got I4
		//IL_0286: Expected Obj, but got I
		speed = 0f;
		yawVel = 0f;
		stoodT = 0f;
		bool flag = cc.enabled;
		bool flag2 = !flag;
		Vector3 vector = (Vector3)0;
		if (!flag2)
		{
			bool isGrounded = cc.isGrounded;
			bool flag3 = !isGrounded;
			object obj = !flag3;
			float num = -1f;
			float num3 = default;
			if (obj == null)
			{
				float num2 = gravity * num3;
				num = vy - num2;
			}
			vy = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj2 = 0;
			object obj3 = obj2;
			float num4 = vy * num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v17+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v18+20]");
			float num5 = 0f * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v18+1C]");
			float num6 = 0f * num4;
			float num7 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v18+18]");
			num3 = num7 * 0f;
			CollisionFlags collisionFlags = cc.Move((Vector3)0);
			vector = (Vector3)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		AnimPace__BackingField = 0f;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(this.animator == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v9+A0]");
			object obj12 = 0;
			Animator animator = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v10+10]");
			float num8 = animator.GetFloat(0);
			AnimSpeed__BackingField = num8;
			object obj13 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v11+A0]");
			object obj14 = 0;
			Animator animator2 = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v12+14]");
			animator2.SetFloat(0, 0f);
		}
	}

	private unsafe Vector3 Weep(float dt, bool preyOk, ref float want)
	{
		//IL_0904: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I4
		//IL_093f: Expected F4, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_032e: Expected F4, but got VT
		//IL_0055: Expected VT, but got Ref
		//IL_08f4: Expected VT, but got Obj
		//IL_0702: Invalid comparison between F4 and I4
		//IL_0348: Expected Obj, but got VT
		//IL_0088: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		//IL_06d8: Expected VT, but got I4
		//IL_09fd: Expected Ref, but got F4
		//IL_0a08: Invalid comparison between VT and I4
		//IL_01b3: Expected Obj, but got I4
		//IL_074a: Expected F4, but got I
		//IL_0374: Invalid comparison between VT and I4
		//IL_0297: Expected Obj, but got I
		//IL_02bd: Expected F4, but got VT
		//IL_01d9: Expected VT, but got Ref
		//IL_01e6: Expected VT, but got Ref
		//IL_00f5: Expected Obj, but got I4
		//IL_07e6: Expected Obj, but got I4
		//IL_03bb: Expected Obj, but got VT
		//IL_03cb: Expected VT, but got F4
		//IL_03f0: Expected Obj, but got VT
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Obj, but got Unknown
		//IL_09dd: Expected F4, but got I4
		//IL_09e5: Expected F4, but got VT
		//IL_01ff: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I4
		//IL_024a: Expected F4, but got VT
		//IL_0393: Expected Obj, but got VT
		//IL_03a1: Expected VT, but got F4
		//IL_0130: Expected F4, but got VT
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected Obj, but got Unknown
		//IL_0a70: Expected Obj, but got I
		//IL_0a9a: Expected Obj, but got I4
		//IL_030a: Expected F4, but got I4
		//IL_0312: Expected F4, but got VT
		//IL_085c: Invalid comparison between F4 and I
		//IL_0151: Expected Obj, but got I4
		//IL_08ae: Expected VT, but got I4
		//IL_04b2: Expected VT, but got I4
		//IL_04b7: Expected VT, but got Obj
		//IL_08e1: Expected VT, but got I4
		//IL_0895: Expected VT, but got I4
		//IL_0a2c: Expected Obj, but got VT
		//IL_04e5: Expected Obj, but got VT
		//IL_0ac3: Expected Ref, but got F4
		//IL_0512: Expected Obj, but got VT
		//IL_0558: Expected VT, but got Ref
		//IL_05c9: Expected Obj, but got I4
		//IL_05ef: Expected VT, but got Ref
		//IL_05fd: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj = 0;
		MonsterCatalog.Target target = default;
		object obj6;
		float num;
		float length;
		ref float reference;
		float num2;
		if (state__BackingField == (State)2)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v77+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = default;
			(int, int) key = Key((MonsterCatalog.Target)(&obj4));
			if (marked == null)
			{
				goto IL_08e6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA48]");
			object obj5 = 0;
			reference = ref *(float*)obj5;
			bool flag2 = marked.ContainsKey(key);
			bool flag3 = !flag2;
			target = prey;
			obj6 = 0;
			if (!flag3)
			{
				bool flag4 = !preyOk;
				target = prey;
				obj6 = 0;
				if (!flag4)
				{
					num = Time.time;
					num2 = easiestAt;
					bool flag5 = num < easiestAt;
					length = (float)prey;
					if (flag5)
					{
						goto IL_033c;
					}
					target = prey;
					obj6 = 1;
				}
			}
		}
		else
		{
			reference = ref want;
			obj6 = 0;
		}
		float time = Time.time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		num2 = 0f;
		float num3 = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		num = (easiestAt = num3 + 0f);
		ref float reference2;
		Vector3 result;
		if (NearestMarked(out var best))
		{
			if (obj6 != null)
			{
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v37+E4]");
				bool flag6 = (nint)0 == 0;
				object obj8 = !flag6;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj9 = default;
				(int, int) tuple = Key((MonsterCatalog.Target)(&obj9));
				object obj10 = default;
				(int, int) other = Key((MonsterCatalog.Target)(&obj10));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAD8]");
				object obj11 = 0;
				reference = ref *(float*)obj11;
				(int, int) tuple2 = default;
				bool flag7 = tuple2.Equals(other);
				bool flag8 = !flag7;
				object obj12 = !flag8;
				target = best;
				reference2 = ref *(float*)obj11;
				length = (float)best;
				if (obj12 != null)
				{
					goto IL_098b;
				}
			}
			List<Vector3> list = trail;
			if (trail != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v21 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj13 = (nint)0 + (nint)1;
				_ = 0;
				repathAt = 0f;
				reference2 = ref reference;
				length = (float)target;
				goto IL_098b;
			}
		}
		else
		{
			bool flag9 = obj6 == null;
			length = (float)target;
			if (!flag9)
			{
				goto IL_033c;
			}
			if (state__BackingField != 0)
			{
				state__BackingField = (State)0;
				Chasing__BackingField = false;
				stateT = 0f;
				reachedFor = 0f;
				listening = false;
				hasPrey = false;
				PickWander((Vector3?)(object)0);
				wait = 0f;
				reference = ref *(float*)null;
			}
			else
			{
				num = wait;
				if (wait > 0f)
				{
					float dt2 = (wait -= dt);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
					Glance(dt2, 0f);
					Transform transform = base.transform;
					if ((object)transform == null)
					{
						goto IL_08e6;
					}
					result = transform.position;
					goto IL_0a35;
				}
			}
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Vector3 position = transform2.position;
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v12+E4]");
				bool flag10 = (nint)0 == 0;
				object obj15 = !flag10;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num4 = (float)wanderTarget - num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+164]");
				object obj17 = default;
				object obj16 = 0 - obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj18 = 0;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v15+E4]");
				bool flag11 = (nint)0 == 0;
				object obj20 = !flag11;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num5 = num4 * num4;
				object obj21 = obj16 * obj16;
				float num6 = num5 + (float)obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				if (!(num6 < 0f))
				{
					bool flag12 = Stuck(dt);
					bool flag13 = !flag12;
					result = (Vector3)flag12;
					if (flag13)
					{
						goto IL_0aa8;
					}
				}
				PickWander((Vector3?)(object)0);
				float num7 = UnityEngine.Random.Range(1.5f, 4f);
				wait = num7;
				result = (Vector3)0;
				goto IL_0aa8;
			}
		}
		goto IL_08e6;
		IL_0a35:
		return result;
		IL_033c:
		bool flag14 = CanSee((Transform)prey);
		if (flag14)
		{
			if (prey == (MonsterCatalog.Target)(object)0)
			{
				goto IL_08e6;
			}
			Vector3 position2 = ((Transform)prey).position;
			lastSeen = (Vector3)num;
		}
		ref float reference3 = ref *(float*)runSpeed;
		if (prey == (MonsterCatalog.Target)(object)0)
		{
			goto IL_08e6;
		}
		Vector3 position3 = ((Transform)prey).position;
		lookWant = (Vector3)runSpeed;
		lookWeightWant = 1f;
		if (Way((Transform)prey, out length))
		{
			unreachT = 0f;
		}
		else if ((double)(unreachT += dt) > 1.0)
		{
			state__BackingField = (State)0;
			Chasing__BackingField = false;
			stateT = 0f;
			reachedFor = 0f;
			listening = false;
			hasPrey = false;
			PickWander((Vector3?)(object)0);
			result = (Vector3)this;
			goto IL_0a35;
		}
		if (flag14 && InReach((Transform)prey) && Grabbable((Transform)prey))
		{
			float num8 = reachedFor + dt;
			reachedFor = num8;
			object obj22 = default;
			if (!WaitsForClaim((MonsterCatalog.Target)(&obj22)) || (double)reachedFor > 1.5)
			{
				object obj23 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X0_v66+E4]");
				bool flag15 = (nint)0 == 0;
				object obj24 = !flag15;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj25 = default;
				(int, int) key2 = Key((MonsterCatalog.Target)(&obj25));
				object obj26 = default;
				StartKill((MonsterCatalog.Target)(&obj26));
				if (state__BackingField == (State)4)
				{
					if (marked == null)
					{
						goto IL_08e6;
					}
					bool flag16 = marked.Remove(key2);
				}
			}
		}
		else
		{
			reachedFor = 0f;
		}
		result = Hunt((Transform)prey, flag14);
		goto IL_0a35;
		IL_0aa8:
		float num9 = walkSpeed * gait;
		reference3 = ref *(float*)num9;
		goto IL_0a35;
		IL_098b:
		object obj27 = this + 432;
		prey = best;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		hasPrey = true;
		bool flag17 = state__BackingField == (State)2;
		reference = ref reference2;
		num2 = 0f;
		num = (float)best;
		if (!flag17)
		{
			Chasing__BackingField = true;
			state__BackingField = (State)2;
			reachedFor = 0f;
			listening = false;
			stateT = 0f;
			reference = ref reference2;
			num2 = 0f;
			num = (float)best;
		}
		goto IL_033c;
		IL_08e6:
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	private unsafe bool NearestMarked(out MonsterCatalog.Target best)
	{
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Ref
		//IL_00ef: Expected Obj, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected F4, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected Obj, but got I4
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got I4
		//IL_053a: Expected Obj, but got I4
		//IL_0856: Expected Obj, but got I
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Expected Ref, but got Unknown
		//IL_0881: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		//IL_0179: Expected VT, but got Ref
		//IL_0555: Expected Obj, but got I4
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Obj, but got Unknown
		//IL_060f: Expected Ref, but got VT
		//IL_01a4: Expected I, but got Obj
		//IL_01ce: Expected Obj, but got I4
		//IL_01de: Expected F4, but got I
		//IL_01ee: Expected F4, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got I4
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected Obj, but got I4
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected F4, but got I
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Obj, but got Unknown
		//IL_05a2: Expected Obj, but got I4
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got I4
		//IL_07e3: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Invalid comparison between I and Unknown
		//IL_035d: Expected Obj, but got I4
		//IL_036d: Expected F4, but got I
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got I4
		//IL_03b0: Expected Obj, but got I4
		//IL_03c0: Expected F4, but got I
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got I4
		//IL_0403: Expected Obj, but got I4
		//IL_0413: Expected F4, but got I
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got I4
		//IL_0462: Expected Obj, but got I4
		//IL_046b: Expected F4, but got I4
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got I4
		//IL_04ce: Expected F4, but got I4
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		ref MonsterCatalog.Target reference = ref *(MonsterCatalog.Target*)null;
		_ = 0;
		bool flag = marked == null;
		bool flag3 = default;
		bool flag2 = flag3;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val2 = (Enumerator<, >)0;
		ref MonsterCatalog.Target reference2 = ref best;
		object obj = 109895680;
		if (flag)
		{
			goto IL_0677;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA60]");
		object obj2 = 0;
		reference2 = ref *(MonsterCatalog.Target*)obj2;
		bool result2;
		if (marked.Count != 0)
		{
			bool flag4 = targets == null;
			flag2 = flag3;
			val = (Enumerator<, >)0;
			val2 = (Enumerator<, >)0;
			obj = 109895680;
			if (flag4)
			{
				goto IL_0677;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA80]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA48]");
			object obj5 = 0;
			Enumerator<, > enumerator = targets.GetEnumerator();
			Enumerator<, > val3 = (Enumerator<, >)(ref val);
			Transform transform = default;
			object obj6 = (object)(&transform);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			obj = 0;
			Enumerator<, > val4 = (Enumerator<, >)2139095039;
			float num = (flag3 ? 1 : 0);
			Enumerator<, > val5 = default;
			val2 = val5;
			Enumerator<, > val6;
			Enumerator<, > val7 = default;
			object obj16;
			Enumerator<, > val8;
			Enumerator<, > val9;
			while (true)
			{
				val6 = val4;
				float length;
				nint num2;
				while (val.MoveNext())
				{
					object obj7 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v33+E4]");
					bool flag5 = (nint)0 == 0;
					object obj8 = !flag5;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+28]");
					_ = 0;
					(int, int) tuple = Key((MonsterCatalog.Target)(&transform));
					if (marked != null)
					{
						num2 = (nint)obj5;
						bool flag6 = marked.ContainsKey(tuple);
						bool flag7 = !flag6;
						transform = (Transform)flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
						length = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
						num = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
						val2 = (Enumerator<, >)0;
						if (flag7)
						{
							continue;
						}
						if (flag3)
						{
							Vector3 position = ((Transform)flag3).position;
							Transform transform2 = base.transform;
							bool flag8 = (object)transform2 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
							val6 = (Enumerator<, >)0;
							reference2 = ref *(MonsterCatalog.Target*)null;
							if (!flag8)
							{
								Vector3 position2 = transform2.position;
								object obj9 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v49+E4]");
								bool flag9 = (nint)0 == 0;
								object obj10 = !flag9;
								if (obj10 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj11 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X0_v52+E4]");
								bool flag10 = (nint)0 == 0;
								object obj12 = !flag10;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								object obj13 = num3 - 0;
								object obj14 = val7 - val7;
								object obj15 = obj13 * obj13;
								num = (float)obj14 * (float)obj14;
								val2 = (Enumerator<, >)(obj15 + num);
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								bool flag11 = (nint)0 >= (nint)val4;
								transform = (Transform)flag3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								length = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								val6 = (Enumerator<, >)0;
								if (flag11)
								{
									continue;
								}
								bool flag12 = CanSee((Transform)flag3);
								bool flag13 = !flag12;
								transform = (Transform)flag3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								length = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								val6 = (Enumerator<, >)0;
								if (flag13)
								{
									continue;
								}
								bool flag14 = InReach((Transform)flag3);
								bool flag15 = !flag14;
								transform = (Transform)flag3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								length = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								val6 = (Enumerator<, >)0;
								if (flag15)
								{
									continue;
								}
								bool flag16 = Way((Transform)flag3, out length);
								bool flag17 = !flag16;
								num2 = (nint)(&length);
								transform = (Transform)flag3;
								length = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
								val6 = (Enumerator<, >)0;
								if (flag17)
								{
									continue;
								}
								goto IL_0489;
							}
							goto IL_0614;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					NullReferenceException ex2 = new NullReferenceException();
					reference2 = ref *(MonsterCatalog.Target*)tuple;
					goto IL_0614;
					IL_0614:
					NullReferenceException ex3 = new NullReferenceException();
					transform = (Transform)flag3;
					flag2 = false;
					val = val5;
					obj16 = 0;
					val8 = val7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
					num = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
					val2 = (Enumerator<, >)0;
					val9 = (Enumerator<, >)(ref val);
					goto IL_0677;
				}
				break;
				IL_0489:
				reference = ref *(flag3 ? ((MonsterCatalog.Target*)1) : ((MonsterCatalog.Target*)null));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				num2 = (nint)(&length);
				transform = (Transform)flag3;
				length = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
				val4 = (Enumerator<, >)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+18]");
				val2 = (Enumerator<, >)0;
			}
			Enumerator<, > val10 = val4;
			flag2 = false;
			val = val5;
			obj16 = 0;
			val8 = val7;
			val9 = (Enumerator<, >)(ref val);
			object obj17 = 5;
			object obj18 = 0;
			bool result = default;
			object obj22 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA70]");
				object obj19 = 0;
				reference2 = ref *(MonsterCatalog.Target*)obj19;
				((Enumerator<, >*)val9)->Dispose();
				bool flag18 = obj18 == null;
				object obj20 = !flag18;
				if (obj20 == null)
				{
					bool flag19 = !flag2;
					object obj21 = !flag19;
					OutOfMemoryException ex4 = (OutOfMemoryException)val9;
					if (obj21 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex4 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) == (void*)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					flag2 = true;
					obj18 = obj16;
				}
				else
				{
					if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != (void*)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FCB0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj18 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj16 = obj22;
				}
				val10 = val6;
				obj17 = 0;
			}
			if ((nint)obj17 != 5)
			{
				bool flag20 = obj17 == null;
				object obj23 = !flag20;
				result2 = flag2;
				if (obj23 != null)
				{
					goto IL_07fe;
				}
			}
			object obj24 = val10 - 2139095039;
			bool flag21 = (nint)obj24 < 0;
			result2 = flag21;
		}
		else
		{
			result2 = false;
		}
		goto IL_07fe;
		IL_0677:
		throw new NullReferenceException();
		IL_07fe:
		return result2;
	}

	private unsafe void GatherTargets()
	{
		//IL_1e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6a: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got I4
		//IL_1cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf8: Expected F4, but got Unknown
		//IL_00ea: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_0102: Expected Obj, but got Ref
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Ref
		//IL_0166: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I
		//IL_0e11: Expected Obj, but got I4
		//IL_210b: Expected Obj, but got I
		//IL_212d: Expected Obj, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Ref
		//IL_01cf: Expected Obj, but got I4
		//IL_158d: Expected Obj, but got I
		//IL_15b7: Expected Obj, but got I4
		//IL_2339: Expected Obj, but got I
		//IL_2350: Unknown result type (might be due to invalid IL or missing references)
		//IL_2354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e46: Expected Obj, but got I
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Expected Obj, but got I
		//IL_0e98: Expected Obj, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Ref
		//IL_0245: Expected Obj, but got I4
		//IL_0ee8: Expected Obj, but got I4
		//IL_15ed: Expected Obj, but got I
		//IL_15fd: Expected Obj, but got I
		//IL_1601: Unknown result type (might be due to invalid IL or missing references)
		//IL_1606: Unknown result type (might be due to invalid IL or missing references)
		//IL_1616: Unknown result type (might be due to invalid IL or missing references)
		//IL_161e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I4
		//IL_0f0e: Expected Obj, but got I
		//IL_0f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3b: Expected Obj, but got I4
		//IL_1e8d: Expected Obj, but got I
		//IL_1eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1edb: Expected Obj, but got Ref
		//IL_1ee9: Expected Obj, but got I4
		//IL_2416: Unknown result type (might be due to invalid IL or missing references)
		//IL_242c: Expected Obj, but got Ref
		//IL_1651: Expected Obj, but got I4
		//IL_0f6b: Expected Obj, but got I4
		//IL_0f81: Expected Obj, but got I4
		//IL_02c9: Expected Obj, but got I
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got I
		//IL_02e6: Expected F4, but got I4
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got I4
		//IL_1694: Expected Obj, but got I4
		//IL_0f9f: Expected Obj, but got I
		//IL_0fc9: Expected Obj, but got I4
		//IL_0ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce1: Expected Obj, but got I4
		//IL_0cef: Expected Obj, but got I4
		//IL_0cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Expected Obj, but got Ref
		//IL_0d0d: Expected Obj, but got I4
		//IL_1009: Expected Obj, but got I4
		//IL_101f: Expected Obj, but got I4
		//IL_23af: Expected Obj, but got I
		//IL_23b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c0: Expected Ref, but got Unknown
		//IL_23da: Expected Obj, but got I4
		//IL_23e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got I4
		//IL_1c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c51: Expected Obj, but got Ref
		//IL_1c5f: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I4
		//IL_16e4: Expected Obj, but got I4
		//IL_1045: Expected Obj, but got I
		//IL_105c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1060: Unknown result type (might be due to invalid IL or missing references)
		//IL_1072: Expected Obj, but got I4
		//IL_0d2c: Expected Obj, but got I4
		//IL_0d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5c: Expected Obj, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Ref
		//IL_0400: Expected Obj, but got I4
		//IL_171c: Expected Obj, but got I4
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_109b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ad: Expected Obj, but got I4
		//IL_0d7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_174b: Expected Obj, but got I
		//IL_1767: Expected Obj, but got I4
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected Obj, but got Unknown
		//IL_044b: Expected Obj, but got I4
		//IL_10cc: Expected Obj, but got I
		//IL_0db9: Expected Obj, but got I4
		//IL_0dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got I4
		//IL_0499: Expected Obj, but got I4
		//IL_1799: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b7: Expected Obj, but got Ref
		//IL_17c5: Expected Obj, but got I4
		//IL_10f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1107: Expected Obj, but got I4
		//IL_1d8a: Expected Obj, but got I4
		//IL_1df1: Expected Obj, but got I4
		//IL_1df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected Obj, but got I4
		//IL_04d7: Expected Obj, but got I4
		//IL_17e4: Expected Obj, but got I
		//IL_1131: Expected VT, but got I4
		//IL_1131: Expected VT, but got I4
		//IL_1816: Unknown result type (might be due to invalid IL or missing references)
		//IL_1824: Unknown result type (might be due to invalid IL or missing references)
		//IL_1828: Unknown result type (might be due to invalid IL or missing references)
		//IL_1834: Expected Obj, but got Ref
		//IL_1842: Expected Obj, but got I4
		//IL_1161: Unknown result type (might be due to invalid IL or missing references)
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Expected Obj, but got I4
		//IL_050c: Expected Obj, but got I4
		//IL_0515: Expected Obj, but got I4
		//IL_186c: Expected VT, but got I4
		//IL_186c: Expected VT, but got I4
		//IL_11af: Expected Obj, but got I4
		//IL_1894: Unknown result type (might be due to invalid IL or missing references)
		//IL_1898: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a5: Expected Obj, but got I4
		//IL_2157: Unknown result type (might be due to invalid IL or missing references)
		//IL_216b: Expected Obj, but got I
		//IL_218d: Expected Obj, but got I4
		//IL_0871: Expected Obj, but got I4
		//IL_11f5: Expected Obj, but got I
		//IL_1fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe6: Expected Obj, but got I4
		//IL_1fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2002: Unknown result type (might be due to invalid IL or missing references)
		//IL_200e: Expected Obj, but got Ref
		//IL_055d: Expected Obj, but got I
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Obj, but got I
		//IL_05af: Expected Obj, but got I4
		//IL_18d8: Expected Obj, but got Ref
		//IL_1365: Expected Obj, but got I
		//IL_1381: Unknown result type (might be due to invalid IL or missing references)
		//IL_138a: Unknown result type (might be due to invalid IL or missing references)
		//IL_139e: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b8: Expected Obj, but got I4
		//IL_05ea: Expected Obj, but got I
		//IL_0602: Expected Obj, but got I
		//IL_1908: Unknown result type (might be due to invalid IL or missing references)
		//IL_1913: Unknown result type (might be due to invalid IL or missing references)
		//IL_192f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1933: Unknown result type (might be due to invalid IL or missing references)
		//IL_1944: Unknown result type (might be due to invalid IL or missing references)
		//IL_1950: Expected Obj, but got Ref
		//IL_1961: Expected Obj, but got I4
		//IL_1233: Expected Obj, but got I
		//IL_1252: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256: Unknown result type (might be due to invalid IL or missing references)
		//IL_125a: Unknown result type (might be due to invalid IL or missing references)
		//IL_125e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1270: Expected Obj, but got I4
		//IL_1f58: Expected Obj, but got I4
		//IL_13fa: Expected Obj, but got I4
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected Obj, but got I4
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected Obj, but got Ref
		//IL_06f9: Expected Obj, but got I4
		//IL_0702: Expected Obj, but got I4
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got I4
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected Obj, but got Ref
		//IL_069c: Expected Obj, but got I4
		//IL_197f: Expected Obj, but got I
		//IL_1995: Expected Obj, but got I
		//IL_1999: Unknown result type (might be due to invalid IL or missing references)
		//IL_199d: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e9: Expected F4, but got I4
		//IL_19f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a19: Expected Obj, but got Ref
		//IL_1a2a: Expected Obj, but got I4
		//IL_21eb: Expected Obj, but got I
		//IL_21fb: Expected Obj, but got I
		//IL_221d: Expected Obj, but got I4
		//IL_128e: Expected Obj, but got I
		//IL_12b2: Expected Obj, but got I4
		//IL_1440: Expected Obj, but got I
		//IL_145d: Unknown result type (might be due to invalid IL or missing references)
		//IL_146c: Expected Obj, but got I4
		//IL_21c5: Expected Obj, but got I4
		//IL_0925: Expected VT, but got I4
		//IL_0925: Expected VT, but got I4
		//IL_0720: Expected Obj, but got I
		//IL_0738: Expected Obj, but got I
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got I4
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected Obj, but got Ref
		//IL_07ad: Expected Obj, but got I4
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected Obj, but got Unknown
		//IL_1a48: Expected Obj, but got I
		//IL_1a71: Expected Obj, but got I4
		//IL_244c: Expected Obj, but got I
		//IL_12f2: Expected Obj, but got I4
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4d: Expected Obj, but got VT
		//IL_1b5d: Expected F4, but got I
		//IL_1b6d: Expected Obj, but got I
		//IL_1b7d: Expected Obj, but got I
		//IL_1ba9: Expected VT, but got Ref
		//IL_1bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bca: Expected F4, but got I
		//IL_1bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1510: Unknown result type (might be due to invalid IL or missing references)
		//IL_1519: Unknown result type (might be due to invalid IL or missing references)
		//IL_1488: Unknown result type (might be due to invalid IL or missing references)
		//IL_131f: Expected Obj, but got I
		//IL_07e2: Expected Obj, but got I4
		//IL_07eb: Expected Obj, but got I4
		//IL_1a9c: Expected Obj, but got I
		//IL_1aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adf: Expected Obj, but got Unknown
		//IL_1aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b02: Expected F4, but got I
		//IL_1b1a: Expected F4, but got I
		//IL_1b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3b: Expected Obj, but got I4
		//IL_22cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2305: Unknown result type (might be due to invalid IL or missing references)
		//IL_2309: Unknown result type (might be due to invalid IL or missing references)
		//IL_231b: Expected Obj, but got I4
		//IL_14bb: Expected Obj, but got I4
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected Obj, but got I4
		//IL_2258: Expected Obj, but got I
		//IL_2268: Expected Obj, but got I
		//IL_2285: Unknown result type (might be due to invalid IL or missing references)
		//IL_2299: Unknown result type (might be due to invalid IL or missing references)
		//IL_229d: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c1: Expected Obj, but got I4
		//IL_2031: Expected Obj, but got I
		//IL_2041: Expected F4, but got I
		//IL_0823: Expected Obj, but got I4
		//IL_1535: Unknown result type (might be due to invalid IL or missing references)
		//IL_1539: Unknown result type (might be due to invalid IL or missing references)
		//IL_1543: Unknown result type (might be due to invalid IL or missing references)
		//IL_1550: Expected F4, but got I4
		//IL_1560: Unknown result type (might be due to invalid IL or missing references)
		//IL_1564: Unknown result type (might be due to invalid IL or missing references)
		//IL_1568: Unknown result type (might be due to invalid IL or missing references)
		//IL_156c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1578: Expected Obj, but got Ref
		//IL_0a10: Expected Obj, but got I4
		//IL_1f76: Expected Obj, but got I
		//IL_1f98: Expected Obj, but got I4
		//IL_1fa1: Expected Obj, but got I4
		//IL_14ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Unknown result type (might be due to invalid IL or missing references)
		//IL_207e: Unknown result type (might be due to invalid IL or missing references)
		//IL_208a: Expected Obj, but got I4
		//IL_20aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c0: Expected Obj, but got I4
		//IL_20c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e8: Expected Obj, but got Ref
		//IL_0a48: Expected Obj, but got I
		//IL_0a58: Expected F4, but got I
		//IL_0856: Expected Obj, but got I4
		//IL_0a75: Expected Obj, but got I
		//IL_0a8b: Expected Obj, but got I
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected Obj, but got Unknown
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected Obj, but got I4
		//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b24: Expected Obj, but got Ref
		//IL_0b47: Expected Obj, but got I
		//IL_0b70: Expected Obj, but got I4
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Expected Obj, but got VT
		//IL_0c4a: Expected F4, but got I
		//IL_0c5a: Expected Obj, but got I
		//IL_0c6a: Expected Obj, but got I
		//IL_0c89: Expected VT, but got Ref
		//IL_0ca9: Expected F4, but got I
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Expected Obj, but got I
		//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Expected Obj, but got Unknown
		//IL_0bf8: Expected F4, but got I
		//IL_0c10: Expected F4, but got I
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
		List<MonsterCatalog.Target> list = targets;
		bool flag = targets == null;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val2 = (Enumerator<, >)0;
		Enumerator<, > val3 = (Enumerator<, >)0;
		Enumerator<, > val4 = (Enumerator<, >)0;
		Enumerator<, > val5 = (Enumerator<, >)0;
		IntPtr intPtr = default;
		UnityEngine.Object obj = (UnityEngine.Object)(nint)intPtr;
		MonsterBrain monsterBrain = this;
		object obj2;
		object obj6;
		Enumerator<, > val7;
		float num4;
		UnityEngine.Object obj18 = default;
		UnityEngine.Object obj20;
		Enumerator<, > val8 = default;
		UnityEngine.Object obj36 = default;
		object obj51 = default;
		object obj65;
		Transform transform;
		Enumerator<, > val6;
		float num5 = default;
		float num3;
		List<MonsterCatalog.Target> list2;
		UnityEngine.Object obj37;
		object obj5;
		object obj10;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+1C]");
			val6 = (Enumerator<, >)((nint)0 + (nint)1);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+18]");
			bool flag2 = (nint)0 < (nint)1;
			int num = (int)(nint)intPtr;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+10]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+18]");
				Array.Clear((Array)num2, 0, 0);
				num = 0;
			}
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v149+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA30]");
			obj6 = 0;
			object obj8 = default;
			object obj7 = (object)(&obj8);
			bool flag4 = (UnityEngine.Object)net != (UnityEngine.Object)null;
			bool flag5 = !flag4;
			val = (Enumerator<, >)0;
			val2 = (Enumerator<, >)0;
			val3 = (Enumerator<, >)0;
			val4 = (Enumerator<, >)0;
			val7 = (Enumerator<, >)0;
			object obj9 = (object)(&obj8);
			obj = null;
			obj10 = 0;
			monsterBrain = this;
			if (flag5)
			{
				goto IL_0de7;
			}
			bool flag6 = (object)net == null;
			val = (Enumerator<, >)0;
			val2 = (Enumerator<, >)0;
			val3 = (Enumerator<, >)0;
			val4 = (Enumerator<, >)0;
			val5 = (Enumerator<, >)0;
			obj9 = (object)(&obj8);
			obj = null;
			obj10 = 0;
			monsterBrain = this;
			if (!flag6)
			{
				bool live = net.Live;
				bool flag7 = !live;
				val = (Enumerator<, >)0;
				val2 = (Enumerator<, >)0;
				val3 = (Enumerator<, >)0;
				val4 = (Enumerator<, >)0;
				val7 = (Enumerator<, >)0;
				obj9 = (object)(&obj8);
				obj = null;
				obj10 = 0;
				monsterBrain = this;
				if (flag7)
				{
					goto IL_0de7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v156+E4]");
				bool flag8 = (nint)0 == 0;
				object obj13 = !flag8;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj11;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v156+A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v84+8]");
				bool flag9 = (nint)0 == 0;
				val = (Enumerator<, >)0;
				val2 = (Enumerator<, >)0;
				val3 = (Enumerator<, >)0;
				val4 = (Enumerator<, >)0;
				val5 = (Enumerator<, >)0;
				obj9 = (object)(&obj8);
				obj = null;
				obj10 = 0;
				monsterBrain = this;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v84+8]");
					Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
					object obj15 = 0;
					num3 = 0f;
					val3 = (Enumerator<, >)0;
					num4 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+60]");
					val7 = (Enumerator<, >)0;
					val6 = (Enumerator<, >)(ref val4);
					obj10 = 0;
					object obj64 = default;
					object obj69 = default;
					while (true)
					{
						object obj21;
						if (val4.MoveNext())
						{
							object obj16 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1387 @ X0_v162+E4]");
							bool flag10 = (nint)0 == 0;
							object obj17 = !flag10;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag11 = obj18 == null;
							bool flag12 = !flag11;
							object obj19 = !flag12;
							obj10 = 0;
							if (obj19 != null)
							{
								continue;
							}
							bool flag13 = (object)obj18 == null;
							val = (Enumerator<, >)0;
							val2 = (Enumerator<, >)num3;
							obj20 = null;
							obj21 = 0;
							val8 = (Enumerator<, >)(ref val4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+60]");
							val4 = (Enumerator<, >)0;
							obj9 = (object)(&obj8);
							obj = null;
							obj10 = 0;
							monsterBrain = this;
							if (flag13)
							{
								break;
							}
							object obj22 = obj2;
							object obj23 = obj18 + 104;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X0_v166+E4]");
							bool flag14 = (nint)0 == 0;
							object obj24 = !flag14;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag15 = (UnityEngine.Object)obj23 == null;
							bool flag16 = !flag15;
							object obj25 = !flag16;
							obj10 = 0;
							if (obj25 != null)
							{
								continue;
							}
							bool isMonster = ((NetworkApe)obj18).IsMonster;
							bool flag17 = !isMonster;
							object obj26 = !flag17;
							obj10 = 0;
							if (obj26 != null)
							{
								continue;
							}
							bool busy = ((NetworkApe)obj18).Busy;
							bool flag18 = !busy;
							object obj27 = !flag18;
							obj10 = 0;
							if (obj27 != null)
							{
								continue;
							}
							bool isLocal = ((NetworkApe)obj18).IsLocal;
							if (isLocal)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
								object obj28 = 0;
								object obj29 = obj2;
								object obj30 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1820 @ X0_v196+E4]");
								val6 = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1821 @ X8_v105+A0]");
								object obj31 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1820 @ X0_v196+E4]");
								bool flag19 = (nint)0 == 0;
								object obj32 = !flag19;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag20 = (UnityEngine.Object)obj31 != null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
								object obj33 = 0;
								object obj34 = obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1853 @ X8_v109+A0]");
								object obj35 = 0;
								obj36 = (UnityEngine.Object)obj35;
								if (flag20)
								{
									bool flag21 = obj35 == null;
									val = (Enumerator<, >)0;
									num5 = num4;
									list2 = (List<MonsterCatalog.Target>)obj35;
									transform = (Transform)obj31;
									obj37 = null;
									obj21 = 0;
									val8 = (Enumerator<, >)(ref val4);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+60]");
									val4 = (Enumerator<, >)0;
									val5 = val7;
									obj9 = (object)(&obj8);
									obj = null;
									obj10 = 0;
									monsterBrain = this;
									if (flag21)
									{
										goto IL_1d2c;
									}
									obj23 = obj35 + 32;
								}
								object obj38 = obj2;
								transform = (Transform)obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1874 @ X0_v200+E4]");
								bool flag22 = (nint)0 == 0;
								object obj39 = !flag22;
								if (obj39 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag23 = obj36 == null;
								bool flag24 = !flag23;
								object obj40 = !flag24;
								obj10 = 0;
								if (obj40 != null)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
								object obj41 = 0;
								object obj42 = obj41;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1924 @ X8_v114+A0]");
								object obj43 = 0;
								object obj44 = obj43;
								bool flag25 = obj43 == null;
								val = (Enumerator<, >)0;
								num5 = num4;
								list2 = (List<MonsterCatalog.Target>)(object)obj36;
								obj37 = null;
								obj21 = 0;
								val8 = (Enumerator<, >)(ref val4);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+60]");
								val4 = (Enumerator<, >)0;
								val5 = val7;
								obj9 = (object)(&obj8);
								obj = null;
								obj10 = 0;
								monsterBrain = this;
								if (flag25)
								{
									goto IL_1d3a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ X8_v116+A9]");
								bool flag26 = (nint)0 == 0;
								object obj45 = !flag26;
								obj10 = 0;
								if (obj45 != null)
								{
									continue;
								}
								object obj46 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X0_v205+E4]");
								bool flag27 = (nint)0 == 0;
								object obj47 = !flag27;
								if (obj47 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj46 = obj5;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X0_v205+A0]");
								object obj48 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1955 @ X8_v119+9]");
								bool flag28 = (nint)0 == 0;
								object obj49 = !flag28;
								obj10 = 0;
								if (obj49 != null)
								{
									continue;
								}
								obj = null;
								obj10 = 0;
							}
							else
							{
								transform = (Transform)obj23;
								obj = null;
								obj10 = 0;
							}
							bool flag29 = (object)transform == null;
							val = (Enumerator<, >)0;
							val2 = (Enumerator<, >)num3;
							num5 = num4;
							obj37 = null;
							obj21 = 0;
							val8 = (Enumerator<, >)(ref val4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+60]");
							val4 = (Enumerator<, >)0;
							val5 = val7;
							obj9 = (object)(&obj8);
							monsterBrain = this;
							if (flag29)
							{
								goto IL_1ce7;
							}
							Vector3 position = transform.position;
							Transform transform2 = base.transform;
							bool flag30 = (object)transform2 == null;
							val = (Enumerator<, >)0;
							num5 = num4;
							list2 = (List<MonsterCatalog.Target>)(object)obj36;
							obj37 = null;
							obj21 = 0;
							val8 = (Enumerator<, >)(ref val4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+60]");
							val4 = (Enumerator<, >)0;
							val5 = val7;
							obj9 = (object)(&obj8);
							obj = null;
							monsterBrain = this;
							if (flag30)
							{
								goto IL_1d05;
							}
							Vector3 position2 = transform2.position;
							bool flag31 = GillaBackroomsSwitch.SameSide((Vector3)0, (Vector3)0);
							bool flag32 = !flag31;
							object obj50 = obj51;
							float num6 = num4;
							Enumerator<, > val9 = val7;
							if (flag32)
							{
								continue;
							}
							list2 = targets;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj52 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1970 @ X0_v187+E4]");
							val6 = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1970 @ X0_v187+E4]");
							bool flag33 = (nint)0 == 0;
							object obj53 = !flag33;
							if (obj53 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj52 = obj5;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1970 @ X0_v187+A0]");
							object obj54 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1972 @ X8_v94+C]");
							float num7 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1972 @ X8_v94+C]");
							if ((nint)0 < (nint)0)
							{
								num7 = ((NetworkApe)obj18).VoiceLevel;
								obj = null;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1970 @ X0_v187+E4]");
								bool flag34 = (nint)0 == 0;
								object obj55 = !flag34;
								obj = transform;
								if (obj55 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj56 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1986 @ X8_v101+A0]");
									object obj57 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1985 @ X8_v102+C]");
									num7 = 0f;
									obj = transform;
								}
							}
							bool flag35 = list2 == null;
							val = (Enumerator<, >)0;
							object obj58 = isLocal;
							num3 = num7;
							num5 = num4;
							obj50 = obj51;
							num6 = num4;
							val9 = val7;
							obj37 = null;
							obj21 = 0;
							val8 = (Enumerator<, >)(ref val4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+60]");
							val4 = (Enumerator<, >)0;
							val5 = (Enumerator<, >)num7;
							obj9 = (object)(&obj8);
							monsterBrain = this;
							if (!flag35)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X23_v2 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+10]");
								object obj59 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X23_v2 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+1C]");
								obj58 = (nint)0 + (nint)1;
								val6 = (Enumerator<, >)obj6;
								obj7 = val3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X23_v2 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+10]");
								bool flag36 = (nint)0 == 0;
								val = (Enumerator<, >)0;
								num3 = num7;
								num5 = num7;
								obj50 = obj51;
								num6 = num4;
								val9 = val7;
								obj37 = null;
								obj21 = 0;
								val8 = (Enumerator<, >)(ref val4);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+60]");
								val4 = (Enumerator<, >)0;
								val5 = val3;
								obj9 = (object)(&obj8);
								monsterBrain = this;
								if (!flag36)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X23_v2 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+18]");
									obj58 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X23_v2 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+18]");
									nint num8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X8_v96+18]");
									bool flag37 = num8 < 0;
									object obj60 = !flag37;
									if (obj60 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X23_v2 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+10]");
										nint num9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X23_v2 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+18]");
										object obj61 = num9 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X23_v2 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+18]");
										val6 = (Enumerator<, >)((nint)0 + (nint)1);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+10]");
										_ = 0;
										object obj62 = obj61 + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										num3 = num7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+10]");
										num4 = 0f;
										obj50 = obj51;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+10]");
										num6 = 0f;
										val9 = val7;
										obj36 = (UnityEngine.Object)(object)list2;
										val7 = (Enumerator<, >)obj7;
									}
									else
									{
										System.__Canon _Canon = (System.__Canon)val6._current;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+10]");
										num4 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1990 @ X8_v97 (System.__Canon)+A8]");
										object obj63 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1341 @ X8_v98+70]");
										obj10 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+10]");
										_ = 0;
										list2.AddWithResize((MonsterCatalog.Target)(&obj64));
										num3 = num7;
										obj50 = obj51;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X26_v19+10]");
										num6 = 0f;
										val9 = val7;
										obj36 = (UnityEngine.Object)(object)list2;
										val7 = (Enumerator<, >)obj7;
									}
									continue;
								}
							}
							goto IL_1d13;
						}
						val = (Enumerator<, >)0;
						list2 = (List<MonsterCatalog.Target>)(object)obj36;
						obj65 = 11;
						obj37 = null;
						obj21 = 0;
						val8 = (Enumerator<, >)(ref val4);
						obj9 = (object)(&obj8);
						monsterBrain = this;
						object obj66 = 0;
						goto IL_239f;
						IL_239f:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
						object obj67 = 0;
						obj = (UnityEngine.Object)obj67;
						((Enumerator<, >*)val8)->Dispose();
						bool flag38 = obj66 == null;
						object obj68 = !flag38;
						num5 = num4;
						val5 = val7;
						if (obj68 != null)
						{
							OutOfMemoryException ex = new OutOfMemoryException();
							goto IL_1d2c;
						}
						goto IL_0d12;
						IL_1d2c:
						NullReferenceException ex2 = new NullReferenceException();
						goto IL_1d3a;
						IL_1d3a:
						NullReferenceException ex3 = new NullReferenceException();
						if ((nint)obj == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj37 = (UnityEngine.Object)1;
							obj66 = obj21;
						}
						else
						{
							if ((nint)obj != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj66 = obj69;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj21 = obj69;
						}
						num4 = num5;
						obj65 = 0;
						val7 = val5;
						goto IL_239f;
					}
					goto IL_1c64;
				}
			}
		}
		goto IL_1cb4;
		IL_157d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj70 = 0;
		object obj71 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X0_v47+E4]");
		bool flag39 = (nint)0 == 0;
		object obj72 = !flag39;
		if (obj72 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj71 = obj70;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X0_v47+A0]");
		object obj73 = 0;
		bool flag40 = obj73 == null;
		num5 = num4;
		val5 = val7;
		if (flag40)
		{
			goto IL_1cb4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C58]");
		obj36 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C40]");
		transform = (Transform)0;
		Enumerator<, > enumerator2 = ((List<System.__Canon>)obj73).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+60]");
		val5 = (Enumerator<, >)0;
		val6 = (Enumerator<, >)(ref val);
		while (val.MoveNext())
		{
			object obj74 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1374 @ X0_v54+E4]");
			bool flag41 = (nint)0 == 0;
			object obj75 = !flag41;
			if (obj75 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag42 = obj18 != null;
			bool flag43 = !flag42;
			obj10 = 0;
			if (flag43)
			{
				continue;
			}
			if ((object)obj18 == null)
			{
				goto IL_1c1d;
			}
			bool standing = ((GillaDummy)obj18).Standing;
			bool flag44 = !standing;
			obj10 = 0;
			if (flag44)
			{
				continue;
			}
			object obj76 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1705 @ X0_v61+E4]");
			bool flag45 = (nint)0 == 0;
			object obj77 = !flag45;
			if (obj77 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ stack_-90_v18 (UnityEngine.Object)+68]");
			bool flag46 = (UnityEngine.Object)0 != null;
			bool flag47 = !flag46;
			obj10 = 0;
			if (flag47)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ stack_-90_v18 (UnityEngine.Object)+68]");
			bool flag48 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+60]");
			val = (Enumerator<, >)0;
			obj20 = obj18;
			val7 = val5;
			obj5 = (object)(&val3);
			obj = null;
			obj10 = 0;
			if (flag48)
			{
				goto IL_1c72;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ stack_-90_v18 (UnityEngine.Object)+68]");
			Vector3 position3 = ((Transform)0).position;
			Transform transform3 = monsterBrain.transform;
			bool flag49 = (object)transform3 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+60]");
			val = (Enumerator<, >)0;
			obj20 = obj18;
			val7 = val5;
			obj5 = (object)(&val3);
			obj = null;
			obj10 = 0;
			if (flag49)
			{
				goto IL_1c80;
			}
			Vector3 position4 = transform3.position;
			bool flag50 = GillaBackroomsSwitch.SameSide((Vector3)0, (Vector3)0);
			bool flag51 = !flag50;
			object obj50 = obj51;
			float num6 = num4;
			Enumerator<, > val9 = val5;
			obj10 = 0;
			if (flag51)
			{
				continue;
			}
			List<MonsterCatalog.Target> list3 = monsterBrain.targets;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj78 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val3, 24));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag52 = monsterBrain.targets == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+60]");
			val = (Enumerator<, >)0;
			val2 = (Enumerator<, >)0;
			num5 = num4;
			obj50 = obj51;
			num6 = num4;
			val9 = val5;
			obj20 = obj18;
			val7 = (Enumerator<, >)0;
			obj5 = (object)(&val3);
			obj = obj18;
			obj10 = 0;
			if (!flag52)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X21_v21 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+10]");
				object obj79 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X21_v21 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+1C]");
				object obj58 = (nint)0 + (nint)1;
				val6 = (Enumerator<, >)obj6;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X21_v21 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+10]");
				bool flag53 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+60]");
				val = (Enumerator<, >)0;
				val2 = (Enumerator<, >)0;
				num5 = 0f;
				obj50 = obj51;
				num6 = num4;
				val9 = val5;
				obj20 = obj18;
				val7 = val3;
				obj5 = (object)(&val3);
				obj = obj18;
				obj10 = 0;
				if (!flag53)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X21_v21 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+18]");
					obj58 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X21_v21 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+18]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1783 @ X8_v35+18]");
					bool flag54 = num10 < 0;
					object obj80 = !flag54;
					if (obj80 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X21_v21 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+10]");
						nint num11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X21_v21 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+18]");
						object obj81 = num11 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X21_v21 (System.Collections.Generic.List`1<MonsterCatalog+Target>)+18]");
						val6 = (Enumerator<, >)((nint)0 + (nint)1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+40]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+50]");
						_ = 0;
						object obj82 = obj81 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						val2 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+50]");
						num4 = 0f;
						obj50 = obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+50]");
						num6 = 0f;
						val9 = val5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+40]");
						val5 = (Enumerator<, >)0;
						obj10 = 0;
					}
					else
					{
						System.__Canon _Canon2 = (System.__Canon)val6._current;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+50]");
						num4 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1936 @ X8_v36 (System.__Canon)+A8]");
						object obj83 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ X8_v37+70]");
						obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+40]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+50]");
						_ = 0;
						monsterBrain.targets.AddWithResize((MonsterCatalog.Target)(&val8));
						val2 = (Enumerator<, >)0;
						obj50 = obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+50]");
						num6 = 0f;
						val9 = val5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+40]");
						val5 = (Enumerator<, >)0;
					}
					continue;
				}
			}
			goto IL_1c96;
		}
		obj = transform;
		val.Dispose();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+60]");
		val = (Enumerator<, >)0;
		num5 = num4;
		obj5 = (object)(&val3);
		monsterBrain = null;
		goto IL_1cd1;
		IL_0de7:
		object obj84 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X0_v85+E4]");
		bool flag55 = (nint)0 == 0;
		object obj85 = !flag55;
		if (obj85 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj84 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X0_v85+A0]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X8_v41+9]");
		bool flag56 = (nint)0 == 0;
		object obj87 = !flag56;
		num4 = num5;
		if (obj87 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj88 = 0;
			object obj89 = obj2;
			object obj90 = obj88;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X0_v86+E4]");
			val6 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X8_v43+A0]");
			object obj91 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X0_v86+E4]");
			bool flag57 = (nint)0 == 0;
			object obj92 = !flag57;
			if (obj92 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag58 = (UnityEngine.Object)obj91 != null;
			bool flag59 = !flag58;
			num4 = num5;
			obj = null;
			obj10 = 0;
			if (!flag59)
			{
				object obj93 = obj88;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X8_v45+A0]");
				object obj94 = 0;
				object obj95 = obj94;
				bool flag60 = obj94 == null;
				val5 = val7;
				obj = null;
				obj10 = 0;
				if (flag60)
				{
					goto IL_1cb4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v47+A9]");
				bool flag61 = (nint)0 == 0;
				object obj96 = !flag61;
				num4 = num5;
				obj = null;
				obj10 = 0;
				if (obj96 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
					object obj97 = 0;
					object obj98 = obj97;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1349 @ X0_v90+E4]");
					bool flag62 = (nint)0 == 0;
					object obj99 = !flag62;
					if (obj99 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool isMonster2 = MonsterPlayer.IsMonster;
					bool flag63 = !isMonster2;
					object obj100 = !flag63;
					num4 = num5;
					obj = null;
					obj10 = 0;
					if (obj100 == null)
					{
						object obj101 = obj88;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X8_v52+A0]");
						object obj102 = 0;
						object obj103 = obj102;
						bool flag64 = obj102 == null;
						val5 = val7;
						obj = null;
						obj10 = 0;
						if (!flag64)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v54+20]");
							bool flag65 = (nint)0 == 0;
							val5 = val7;
							obj = null;
							obj10 = 0;
							if (!flag65)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v54+20]");
								Vector3 position5 = ((Transform)0).position;
								Transform transform4 = monsterBrain.transform;
								bool flag66 = (object)transform4 == null;
								val5 = val7;
								obj = null;
								obj10 = 0;
								if (!flag66)
								{
									Vector3 position6 = transform4.position;
									bool flag67 = GillaBackroomsSwitch.SameSide((Vector3)0, (Vector3)0);
									bool flag68 = !flag67;
									num4 = num5;
									object obj50 = obj51;
									float num6 = num5;
									Enumerator<, > val9 = val7;
									obj = null;
									obj10 = 0;
									if (flag68)
									{
										goto IL_157d;
									}
									object obj104 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1799 @ X0_v102+E4]");
									bool flag69 = (nint)0 == 0;
									object obj105 = !flag69;
									if (obj105 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj104 = obj5;
									}
									object obj106 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1799 @ X0_v102+A0]");
									val6 = (Enumerator<, >)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1801 @ X8_v56+E4]");
									object obj58 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1801 @ X8_v56+E4]");
									bool flag70 = (nint)0 == 0;
									object obj107 = !flag70;
									if (obj107 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X9_v34 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+30]");
									bool flag71 = (UnityEngine.Object)0 == null;
									bool flag72 = !flag71;
									obj = null;
									if (!flag72)
									{
										object obj108 = obj88;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1826 @ X8_v73+A0]");
										object obj109 = 0;
										bool flag73 = obj109 == null;
										obj50 = obj51;
										num6 = num5;
										val9 = val7;
										val5 = val7;
										obj = null;
										obj10 = 0;
										if (flag73)
										{
											goto IL_1cb4;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA28]");
										object obj110 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F01C");
										UnityEngine.Object obj111 = default;
										bool flag74 = (object)obj111 == null;
										object obj112 = !flag74;
										UnityEngine.Object obj113 = obj111;
										if (obj112 == null)
										{
											object obj114 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1878 @ X0_v135+E4]");
											bool flag75 = (nint)0 == 0;
											object obj115 = !flag75;
											if (obj115 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA40]");
											object obj116 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
											UnityEngine.Object obj117 = default;
											obj113 = obj117;
										}
										object obj118 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X0_v129+E4]");
										bool flag76 = (nint)0 == 0;
										object obj119 = !flag76;
										if (obj119 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj118 = obj5;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X0_v129+A0]");
										object obj120 = (nint)0 + (nint)48;
										obj120 = obj113;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										obj = obj113;
									}
									object obj121 = obj88;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1835 @ X8_v58+A0]");
									object obj122 = 0;
									object obj123 = obj122;
									bool flag77 = obj122 == null;
									val2 = (Enumerator<, >)0;
									val3 = (Enumerator<, >)0;
									obj50 = obj51;
									num6 = num5;
									val9 = val7;
									val5 = (Enumerator<, >)0;
									obj10 = 0;
									if (!flag77)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj124 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1891 @ X0_v110+E4]");
										bool flag78 = (nint)0 == 0;
										object obj125 = !flag78;
										if (obj125 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj124 = obj5;
										}
										object obj126 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1891 @ X0_v110+A0]");
										object obj127 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1893 @ X8_v62+E4]");
										obj58 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1893 @ X8_v62+E4]");
										bool flag79 = (nint)0 == 0;
										object obj128 = !flag79;
										if (obj128 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1894 @ X9_v26+30]");
										bool flag80 = (UnityEngine.Object)0 != null;
										bool flag81 = !flag80;
										Enumerator<, > val10 = (Enumerator<, >)(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val3, 16));
										object obj129 = !flag81;
										object obj130 = ~obj129;
										if (obj130 == null)
										{
											val10 = (Enumerator<, >)16;
										}
										if (flag80)
										{
											object obj131 = obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v118+E4]");
											bool flag82 = (nint)0 == 0;
											object obj132 = !flag82;
											if (obj132 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj131 = obj5;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v118+A0]");
											object obj133 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1963 @ X8_v68+30]");
											object obj134 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1963 @ X8_v68+30]");
											bool flag83 = (nint)0 == 0;
											val2 = (Enumerator<, >)0;
											obj50 = obj51;
											num6 = num5;
											val9 = val7;
											val5 = (Enumerator<, >)0;
											obj = null;
											val6 = (Enumerator<, >)16;
											obj10 = 0;
											if (flag83)
											{
												goto IL_1cb4;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v69+3C]");
											val5 = (Enumerator<, >)0;
											val10 = (Enumerator<, >)(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val3, 16));
											val6 = (Enumerator<, >)(ref val3);
										}
										else
										{
											val5 = (Enumerator<, >)0;
											val6 = (Enumerator<, >)16;
										}
										val10 = val5;
										bool flag84 = monsterBrain.targets == null;
										val2 = (Enumerator<, >)0;
										obj50 = obj51;
										num6 = num5;
										val9 = val7;
										obj = null;
										obj10 = 0;
										if (!flag84)
										{
											obj10 = obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FD28");
											Enumerator<, > val11 = val3;
											val2 = (Enumerator<, >)0;
											num4 = 0f;
											obj50 = obj51;
											num6 = num5;
											val9 = val7;
											val7 = val3;
											obj = (UnityEngine.Object)(&val11);
											goto IL_157d;
										}
									}
								}
							}
						}
						goto IL_1cb4;
					}
				}
			}
		}
		goto IL_157d;
		IL_0d12:
		bool flag85 = (object)obj37 == null;
		object obj135 = !flag85;
		val2 = (Enumerator<, >)num3;
		num5 = num4;
		obj36 = (UnityEngine.Object)(object)list2;
		obj18 = obj37;
		val5 = val7;
		NullReferenceException ex4 = (NullReferenceException)val8;
		if (obj135 == null)
		{
			bool flag86 = (nint)obj65 == 11;
			val2 = (Enumerator<, >)num3;
			obj36 = (UnityEngine.Object)(object)list2;
			obj18 = obj37;
			if (!flag86)
			{
				bool flag87 = obj65 == null;
				object obj136 = !flag87;
				val2 = (Enumerator<, >)num3;
				num5 = num4;
				obj36 = (UnityEngine.Object)(object)list2;
				obj18 = obj37;
				if (obj136 == null)
				{
					goto IL_0de7;
				}
				return;
			}
			goto IL_157d;
		}
		goto IL_1cc2;
		IL_1c96:
		NullReferenceException ex5 = new NullReferenceException();
		obj18 = obj20;
		val5 = val7;
		goto IL_1cb4;
		IL_1c80:
		NullReferenceException ex6 = new NullReferenceException();
		num5 = num4;
		goto IL_1c96;
		IL_1d13:
		throw new NullReferenceException();
		IL_1ce7:
		NullReferenceException ex7 = new NullReferenceException();
		num3 = (float)val2;
		list2 = (List<MonsterCatalog.Target>)(object)obj36;
		goto IL_1d05;
		IL_1d05:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_1d13;
		IL_1c64:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_1c72;
		IL_1cd1:
		OutOfMemoryException ex10 = new OutOfMemoryException();
		obj37 = obj18;
		goto IL_1ce7;
		IL_1cc2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_1cd1;
		IL_1cb4:
		ex4 = new NullReferenceException();
		goto IL_1cc2;
		IL_1c72:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_1c80;
		IL_1c1d:
		NullReferenceException ex12 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X26_v11+60]");
		val = (Enumerator<, >)0;
		obj20 = obj18;
		val7 = val5;
		obj5 = (object)(&val3);
		obj = null;
		obj10 = 0;
		goto IL_1c64;
	}

	private unsafe bool Hear(out MonsterCatalog.Target heard)
	{
		//IL_0b0c: Invalid comparison between F4 and I4
		//IL_0b1d: Expected Obj, but got I4
		//IL_0b28: Invalid comparison between F4 and I4
		//IL_0045: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_01c6: Expected F4, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got I4
		//IL_0201: Expected F8, but got I
		//IL_0104: Expected F4, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got I4
		//IL_013f: Expected F8, but got I
		//IL_0bb0: Expected Obj, but got I
		//IL_0bc8: Expected Obj, but got I
		//IL_0bd8: Expected F8, but got I
		//IL_0c35: Expected F8, but got I
		//IL_0c45: Expected F4, but got I
		//IL_0c63: Expected Obj, but got I4
		//IL_016c: Expected F4, but got I
		//IL_0189: Expected F8, but got I
		//IL_0b67: Expected F4, but got I4
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected Obj, but got I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I
		//IL_0262: Expected F4, but got I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected F8, but got Unknown
		//IL_0282: Expected Obj, but got I4
		//IL_028a: Expected F8, but got I4
		//IL_029a: Expected F8, but got I
		//IL_08f0: Expected Obj, but got I4
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected Obj, but got I4
		//IL_0914: Expected Obj, but got I4
		//IL_0dc5: Expected Obj, but got I
		//IL_0dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd6: Expected Ref, but got Unknown
		//IL_0df0: Expected Obj, but got I4
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Invalid comparison between Unknown and F4
		//IL_02c4: Expected Obj, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Invalid comparison between F4 and I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_092f: Expected Obj, but got I4
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected Obj, but got Unknown
		//IL_0318: Expected Obj, but got I
		//IL_0342: Expected Obj, but got I4
		//IL_038d: Expected Obj, but got I4
		//IL_0396: Expected VT, but got I4
		//IL_0527: Expected F8, but got I4
		//IL_09af: Invalid comparison between F8 and I4
		//IL_03ce: Expected Obj, but got I4
		//IL_097c: Expected Obj, but got I4
		//IL_09f0: Expected Obj, but got VT
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Invalid comparison between F8 and I4
		//IL_0583: Expected F8, but got I4
		//IL_0a18: Expected Obj, but got I4
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Expected Obj, but got I4
		//IL_069f: Expected Obj, but got I4
		//IL_03f1: Expected Obj, but got I
		//IL_0427: Expected Obj, but got Ref
		//IL_0cb7: Expected I, but got Obj
		//IL_0cd9: Expected Obj, but got I4
		//IL_05b6: Invalid comparison between F8 and I4
		//IL_05c5: Invalid comparison between F8 and I4
		//IL_05dd: Expected Obj, but got F8
		//IL_05ea: Expected Obj, but got F8
		//IL_061f: Expected Obj, but got I4
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_072a: Invalid comparison between F8 and I4
		//IL_073b: Expected Obj, but got I4
		//IL_0772: Expected F8, but got I
		//IL_0496: Expected Obj, but got Ref
		//IL_0791: Expected Obj, but got I4
		//IL_07a5: Expected Obj, but got I
		//IL_07ad: Expected VT, but got Obj
		//IL_07cf: Expected Obj, but got I4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04d1: Expected Obj, but got Ref
		//IL_04e9: Expected Obj, but got Ref
		//IL_07fa: Expected VT, but got I4
		//IL_0818: Expected Obj, but got I4
		//IL_0d1f: Expected F8, but got I
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Expected F8, but got I
		ref MonsterCatalog.Target reference = ref *(MonsterCatalog.Target*)null;
		_ = 0;
		bool flag = ignoreT == 0f;
		object obj = !flag;
		bool flag2 = ignoreT > 0f;
		bool result = false;
		if (!flag2)
		{
			float time = Time.time;
			if (!(time < hearAt))
			{
				float time2 = Time.time;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				UnityEngine.Object obj3 = face;
				float num = time2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
				float num2 = num + 0f;
				object obj4 = obj2;
				hearAt = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v6+E4]");
				bool flag3 = (nint)0 == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num4 = default;
				float value;
				bool flag6 = default;
				Enumerator<, > val;
				float num6 = default;
				float num8;
				double num9;
				double num5;
				double num7;
				double num10 = default;
				object obj6;
				bool flag5;
				double num3;
				if (obj3 != null)
				{
					bool flag4 = (object)face == null;
					num3 = num4;
					value = 0f;
					flag5 = flag6;
					val = (Enumerator<, >)0;
					num5 = num6;
					obj6 = 0;
					UnityEngine.Object obj7 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					num7 = 0.0;
					if (flag4)
					{
						goto IL_0a2f;
					}
					Vector3 position = face.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					num8 = 0f;
					num9 = num10;
					obj7 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					num7 = 0.0;
				}
				else
				{
					Transform transform = base.transform;
					bool flag7 = (object)transform == null;
					num3 = num4;
					value = 0f;
					flag5 = flag6;
					val = (Enumerator<, >)0;
					num5 = num6;
					obj6 = 0;
					UnityEngine.Object obj7 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					num7 = 0.0;
					if (flag7)
					{
						goto IL_0a2f;
					}
					Vector3 position2 = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj8 = 0;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v48+A0]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v49+1C]");
					num7 = 0.0;
					double num11 = num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v49+20]");
					num9 = num11 + 0.0;
					float num12 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v49+18]");
					float num13 = num12 + 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					float num14 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v49+1C]");
					float num15 = num14 + 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v49+20]");
					num10 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					float num16 = 0f;
					num8 = num15;
					obj7 = null;
					num2 = num15;
					obj3 = (UnityEngine.Object)109891584;
				}
				bool flag8 = targets == null;
				num3 = num4;
				value = 0f;
				flag5 = flag6;
				val = (Enumerator<, >)0;
				num5 = num2;
				obj6 = 0;
				if (flag8)
				{
					goto IL_0a2f;
				}
				Enumerator<, > enumerator = targets.GetEnumerator();
				Enumerator<, > val2 = (Enumerator<, >)(ref val);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA80]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				obj3 = (UnityEngine.Object)0;
				value = 0f;
				Enumerator<, > val3 = default;
				num10 = (double)val3;
				double num17 = 1.0;
				obj6 = 0;
				num7 = (flag6 ? 1 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				double num18 = 0.0;
				UnityEngine.Object obj18 = default;
				PlayerRef playerRef2 = default;
				object obj24 = default;
				object obj20 = default;
				Enumerator<, > val4 = default;
				object obj34;
				Enumerator<, > val5;
				while (true)
				{
					num5 = num17;
					num2 = (float)num18;
					object obj19;
					object obj21;
					double num25;
					float num29;
					double num31;
					double num32;
					float num13;
					while (val.MoveNext())
					{
						num2 = hearThreshold;
						bool flag9 = (float)val3 < hearThreshold;
						object obj12 = !flag9;
						float num19 = (float)val3 - hearThreshold;
						bool flag10 = num19 == 0f;
						object obj13 = ~obj12;
						object obj14 = obj13 | flag10;
						if (obj14 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj15 = 0;
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X0_v19+E4]");
						bool flag11 = (nint)0 == 0;
						object obj17 = !flag11;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag12 = obj18 == null;
						bool flag13 = !flag12;
						obj19 = obj20;
						obj21 = 0;
						PlayerRef playerRef = (PlayerRef)0;
						double num20 = num7;
						UnityEngine.Object obj7;
						if (!flag13)
						{
							bool flag14 = (object)killedAt == null;
							num3 = num4;
							obj6 = 0;
							obj7 = null;
							if (flag14)
							{
								goto IL_09fd;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAE0]");
							object obj22 = 0;
							obj19 = obj22;
							bool flag15 = killedAt.TryGetValue(playerRef2, out value);
							bool flag16 = !flag15;
							obj21 = (object)(&value);
							playerRef = playerRef2;
							num20 = num7;
							if (!flag16)
							{
								float time3 = Time.time;
								num10 = recoverSeconds;
								num2 = time3 - value;
								num20 = (double)recoverSeconds + 6.0;
								bool flag17 = !((double)num2 < num20);
								obj21 = (object)(&value);
								playerRef = playerRef2;
								if (!flag17)
								{
									object obj23 = obj24 & 1;
									bool flag18 = obj23 == null;
									obj21 = (object)(&value);
									playerRef = playerRef2;
									obj20 = obj22;
									obj6 = (object)(&value);
									num7 = num20;
									if (flag18)
									{
										continue;
									}
								}
							}
						}
						num2 = hearThreshold;
						bool flag19 = (double)hearThreshold == 1.0;
						num3 = 0.0;
						if (!flag19)
						{
							num20 = (double)val3 - (double)hearThreshold;
							double num21 = 1.0 - (double)hearThreshold;
							double num22 = num20 / num21;
							bool flag20 = num22 < 0.0;
							num3 = 0.0;
							num2 = (float)num22;
							if (!flag20)
							{
								double num23 = num22 - 1.0;
								bool flag21 = num23 < 0.0;
								bool flag22 = num23 == 0.0;
								object obj25 = num22 ^ 1.0;
								object obj26 = num22 ^ num23;
								object obj27 = obj25 & obj26;
								bool flag23 = (nint)obj27 < 0;
								bool flag24 = flag21 == flag23;
								obj = !flag22;
								object obj28 = flag24 & obj;
								object obj29 = ~obj28;
								if (obj29 == null)
								{
									num3 = 1.0;
									num20 = 1.0;
									num2 = (float)num22;
								}
								else
								{
									num3 = num22;
									num20 = 1.0;
									num2 = (float)num22;
								}
							}
						}
						if (flag6)
						{
							float num16 = hearRange;
							Vector3 position3 = ((Transform)flag6).position;
							nint num24 = (nint)obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X0_v30 (Il2CppClass<UnityEngine.Object>)+E4]");
							bool flag25 = (nint)0 == 0;
							object obj30 = !flag25;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							num25 = 1.0 - num9;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							double num26 = num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
							double num27 = num26 * 0.0;
							float num28 = (float)num27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
							num29 = num28 + 0f;
							num4 = num16 * num29;
							double num30 = num5 - (double)num4;
							bool flag26 = num30 == 0.0;
							obj = !flag26;
							bool flag27 = num5 > (double)num4;
							obj20 = obj19;
							num10 = num25;
							obj6 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
							num7 = 0.0;
							num2 = num29;
							if (flag27)
							{
								continue;
							}
							Vector3 position4 = ((Transform)flag6).position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
							object obj31 = 0;
							Vector3 a = (Vector3)obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ X0_v35 (UnityEngine.Vector3)+E4]");
							bool flag28 = (nint)0 == 0;
							object obj32 = !flag28;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag29 = Clear(a, (Vector3)0);
							bool flag30 = !flag29;
							object obj33 = !flag30;
							if (obj33 == null)
							{
								num4 *= hearThroughWalls;
							}
							num5 /= (double)num4;
							bool flag31 = !(num5 < num17);
							num31 = num25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
							num32 = 0.0;
							num13 = num29;
							obj20 = obj19;
							num10 = num9;
							obj6 = obj21;
							num7 = num8;
							num2 = (float)num17;
							if (flag31)
							{
								continue;
							}
							goto IL_083c;
						}
						NullReferenceException ex = new NullReferenceException();
						obj20 = obj19;
						num10 = 1.0;
						obj6 = obj21;
						obj7 = (UnityEngine.Object)playerRef;
						num7 = num20;
						goto IL_09fd;
						IL_09fd:
						NullReferenceException ex2 = new NullReferenceException();
						flag5 = false;
						obj34 = 0;
						val = val4;
						val5 = (Enumerator<, >)(ref val);
						goto IL_0a2f;
					}
					break;
					IL_083c:
					reference = ref *(flag6 ? ((MonsterCatalog.Target*)1) : ((MonsterCatalog.Target*)null));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X26_v4 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+1D]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X26_v4 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+1F]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num31 = num25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					num32 = 0.0;
					num13 = num29;
					obj20 = obj19;
					num10 = num9;
					num17 = num5;
					obj6 = obj21;
					num7 = num8;
					num18 = num5;
				}
				double num33 = num17;
				flag5 = false;
				obj34 = 0;
				val = val4;
				val5 = (Enumerator<, >)(ref val);
				object obj35 = 10;
				object obj36 = 0;
				bool result2 = default;
				object obj40 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA70]");
					object obj37 = 0;
					UnityEngine.Object obj7 = (UnityEngine.Object)obj37;
					((Enumerator<, >*)val5)->Dispose();
					bool flag32 = obj36 == null;
					object obj38 = !flag32;
					num3 = num4;
					if (obj38 == null)
					{
						bool flag33 = !flag5;
						object obj39 = !flag33;
						OutOfMemoryException ex3 = (OutOfMemoryException)val5;
						if (obj39 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
						num4 = (float)num3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj7 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						flag5 = true;
						obj36 = obj34;
					}
					else
					{
						if ((nint)obj7 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FCB0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return result2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj36 = obj40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj34 = obj40;
					}
					num33 = num5;
					obj35 = 0;
				}
				if ((nint)obj35 != 10)
				{
					bool flag34 = obj35 == null;
					object obj41 = !flag34;
					result = flag5;
					if (obj41 != null)
					{
						goto IL_0b9b;
					}
				}
				double num34 = num33 - 1.0;
				bool flag35 = num34 < 0.0;
				result = flag35;
			}
			else
			{
				result = false;
			}
		}
		goto IL_0b9b;
		IL_0b9b:
		return result;
		IL_0a2f:
		throw new NullReferenceException();
	}

	private void Investigate(MonsterCatalog.Target t)
	{
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0260: Expected VT, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I4
		//IL_02ba: Expected Obj, but got I
		//IL_02e4: Expected Obj, but got I4
		//IL_019c: Expected VT, but got F4
		//IL_01bc: Expected Obj, but got I4
		//IL_01c4: Expected VT, but got F4
		//IL_0237: Expected F4, but got I
		object obj = this + 432;
		prey = (MonsterCatalog.Target)t.head;
		_ = t.voice;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		hasPrey = true;
		Vector3 position = t.head.position;
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj2 = 0;
		Vector3 position2 = transform.position;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = t.voice - t.voice;
		object obj6 = default;
		object obj5 = obj6 - obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2 = num * num;
		object obj10 = obj5 * obj5;
		float num3 = num2 + (float)obj10;
		float num4 = senseRange + senseRange;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (num3 < num4 && Way(t.head, out var _))
		{
			Chasing__BackingField = false;
			state__BackingField = (State)1;
			stateT = 0f;
			reachedFor = 0f;
			noticeFor = 0.35f;
			listening = false;
			return;
		}
		Vector3 position3 = t.head.position;
		lastSeen = (Vector3)num3;
		bool flag3 = (byte)(~(listening ? 1u : 0u)) != 0;
		object obj11 = !flag3;
		Vector3 vector = (Vector3)num3;
		if (obj11 == null)
		{
			Chasing__BackingField = false;
			state__BackingField = (State)3;
			searchFor = 9f;
			stateT = 0f;
			reachedFor = 0f;
			listening = true;
			float time = Time.time;
			vector = lastSeen;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+190]");
			num4 = 0f;
			listeningSince = time;
		}
		lookWant = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+194]");
		_ = 0;
		lookWeightWant = 1f;
	}

	private unsafe bool Find(MonsterCatalog.Target was, out MonsterCatalog.Target t)
	{
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got I4
		//IL_03b9: Expected Obj, but got I4
		//IL_06a4: Expected Obj, but got I
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Ref, but got Unknown
		//IL_06c7: Expected Obj, but got I4
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I4
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Invalid comparison between Unknown and I4
		//IL_03d8: Expected Obj, but got I4
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I4
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got I4
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_042d: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Ref, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I4
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I4
		//IL_02a4: Invalid comparison between Obj and VT
		List<MonsterCatalog.Target> list = targets;
		Enumerator<, > val2 = default;
		Enumerator<, > val3 = default;
		Enumerator<, > val5;
		object obj19 = default;
		Enumerator<, > val10 = default;
		object obj20;
		bool result;
		object obj21;
		ref MonsterCatalog.Target reference;
		ref MonsterCatalog.Target reference3;
		Enumerator<, > val9;
		if (targets != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA80]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj3 = 0;
			Enumerator<, > enumerator = list.GetEnumerator();
			Enumerator<, > val = (Enumerator<, >)(ref val2);
			reference = ref t;
			MonsterCatalog.Target target = default;
			UnityEngine.Object obj8 = default;
			object obj12 = default;
			object obj18 = default;
			Enumerator<, > val4 = default;
			Enumerator<, > val7 = default;
			while (true)
			{
				if (val2.MoveNext())
				{
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v30+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					ref MonsterCatalog.Target reference2;
					if ((UnityEngine.Object)target.dummy != (UnityEngine.Object)null)
					{
						object obj6 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v45+E4]");
						bool flag2 = (nint)0 == 0;
						object obj7 = !flag2;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag3 = obj8 == target.dummy;
						bool flag4 = !flag3;
						reference = ref *(MonsterCatalog.Target*)null;
						if (flag4)
						{
							continue;
						}
						reference2 = ref *(MonsterCatalog.Target*)null;
					}
					else
					{
						object obj9 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X0_v37+E4]");
						bool flag5 = (nint)0 == 0;
						object obj10 = !flag5;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag6 = obj8 == null;
						bool flag7 = !flag6;
						reference = ref *(MonsterCatalog.Target*)null;
						if (flag7)
						{
							continue;
						}
						object obj11 = target.local ^ obj12;
						object obj13 = obj11 & 1;
						bool flag8 = obj13 == null;
						object obj14 = !flag8;
						reference = ref *(MonsterCatalog.Target*)null;
						if (obj14 != null)
						{
							continue;
						}
						bool flag9 = !target.local;
						object obj15 = !flag9;
						reference2 = ref *(MonsterCatalog.Target*)null;
						if (obj15 == null)
						{
							object obj16 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X0_v41+E4]");
							bool flag10 = (nint)0 == 0;
							object obj17 = !flag10;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag11 = obj18 != (object)target.player;
							reference2 = ref *(MonsterCatalog.Target*)null;
							reference = ref *(MonsterCatalog.Target*)null;
							if (flag11)
							{
								continue;
							}
						}
					}
					reference3 = ref *(MonsterCatalog.Target*)val3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X28_v6 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+1D]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X28_v6 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+24]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					reference = ref reference2;
					val2 = val4;
					val5 = (Enumerator<, >)0;
					obj19 = 0;
					Enumerator<, > val6 = val7;
					Enumerator<, > val8 = val3;
					val9 = val4;
					val10 = (Enumerator<, >)(ref val2);
					obj20 = 0;
					result = true;
					obj21 = 8;
				}
				else
				{
					val2 = val4;
					val5 = (Enumerator<, >)0;
					obj19 = 0;
					Enumerator<, > val6 = val7;
					Enumerator<, > val8 = val3;
					val9 = val4;
					val10 = (Enumerator<, >)(ref val2);
					obj20 = 0;
					result = false;
					obj21 = 9;
				}
				break;
			}
			goto IL_0694;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		bool flag12 = num != 0;
		reference = ref t;
		val9 = (Enumerator<, >)0;
		if (!flag12)
		{
			NullReferenceException ex = new NullReferenceException();
			reference = ref t;
			val2 = (Enumerator<, >)0;
			val9 = (Enumerator<, >)0;
			list = (List<MonsterCatalog.Target>)(object)ex;
			goto IL_04da;
		}
		goto IL_0623;
		IL_0623:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result2 = default;
		return result2;
		IL_051f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (num2 != 0)
		{
			goto IL_0623;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj22 = default;
		if ((nint)obj22 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			val3 = (Enumerator<, >)1;
			obj20 = obj19;
		}
		else
		{
			if ((nint)obj22 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FCB0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				if (num3 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
				goto IL_0623;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj23 = default;
			obj20 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj19 = obj23;
		}
		val5 = val3;
		result = false;
		obj21 = 0;
		goto IL_0694;
		IL_0694:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA70]");
		obj22 = 0;
		((Enumerator<, >*)val10)->Dispose();
		bool flag13 = obj20 == null;
		object obj24 = !flag13;
		val3 = val5;
		list = (List<MonsterCatalog.Target>)val10;
		if (obj24 != null)
		{
			goto IL_04da;
		}
		bool flag14 = (int)val5 == 0;
		object obj25 = !flag14;
		val3 = val5;
		list = (List<MonsterCatalog.Target>)val10;
		if (obj25 != null)
		{
			goto IL_051f;
		}
		if ((nint)obj21 != 9)
		{
			bool flag15 = obj21 == null;
			object obj26 = !flag15;
			if (obj26 != null)
			{
				goto IL_06e5;
			}
		}
		reference3 = ref *(MonsterCatalog.Target*)null;
		_ = 0;
		val9 = (Enumerator<, >)0;
		result = false;
		goto IL_06e5;
		IL_06e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		bool flag16 = num4 != 0;
		list = (List<MonsterCatalog.Target>)val10;
		if (!flag16)
		{
			return result;
		}
		goto IL_0623;
		IL_04da:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (num5 == 0)
		{
			OutOfMemoryException ex2 = new OutOfMemoryException();
			list = (List<MonsterCatalog.Target>)(object)ex2;
			goto IL_051f;
		}
		goto IL_0623;
	}

	private unsafe bool Spot(out MonsterCatalog.Target seen)
	{
		//IL_0e64: Invalid comparison between F4 and I4
		//IL_0e75: Expected Obj, but got I4
		//IL_0e80: Invalid comparison between F4 and I4
		//IL_0e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10be: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c6: Expected Obj, but got Unknown
		//IL_001f: Expected F4, but got I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00d0: Expected F4, but got I4
		//IL_00f3: Expected F4, but got I
		//IL_098a: Expected F8, but got I4
		//IL_0993: Expected F4, but got I4
		//IL_09a5: Expected Obj, but got I4
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Expected Obj, but got I4
		//IL_09d0: Expected Obj, but got I4
		//IL_113d: Expected Obj, but got I
		//IL_1145: Unknown result type (might be due to invalid IL or missing references)
		//IL_114e: Expected Ref, but got Unknown
		//IL_1168: Expected Obj, but got I4
		//IL_1170: Expected F8, but got I4
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_1178: Expected Obj, but got Unknown
		//IL_0122: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got Ref
		//IL_0169: Expected I, but got Obj
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected VT, but got I4
		//IL_09eb: Expected Obj, but got I4
		//IL_09f3: Expected F8, but got I4
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected Obj, but got Unknown
		//IL_0336: Invalid comparison between F8 and I4
		//IL_0344: Expected Ref, but got VT
		//IL_034c: Expected Obj, but got I4
		//IL_01ae: Expected I, but got Obj
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got F8
		//IL_0a8f: Invalid comparison between F8 and I4
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got I
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected Obj, but got I4
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got I4
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfa: Expected I4, but got F8
		//IL_0e18: Expected Obj, but got I4
		//IL_0f11: Expected Obj, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected F4, but got I4
		//IL_046f: Expected Obj, but got F8
		//IL_04a3: Expected F4, but got I4
		//IL_0c8f: Expected F4, but got I4
		//IL_0c98: Expected F8, but got I4
		//IL_0ca1: Expected Obj, but got I4
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got F8
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got I4
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Invalid comparison between I4 and F4
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected Obj, but got F8
		//IL_0870: Expected F4, but got I4
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected Ref, but got F8
		//IL_0923: Expected F4, but got I4
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected Obj, but got I4
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected Obj, but got Unknown
		//IL_070a: Invalid comparison between F8 and I
		//IL_0719: Expected F8, but got I4
		//IL_0f85: Invalid comparison between F8 and I4
		//IL_0f96: Expected Obj, but got I4
		//IL_0fb4: Expected Obj, but got I
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1001: Expected Obj, but got I
		//IL_1019: Unknown result type (might be due to invalid IL or missing references)
		//IL_101d: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1087: Expected Obj, but got I4
		ref MonsterCatalog.Target reference = ref *(MonsterCatalog.Target*)null;
		_ = 0;
		bool flag = ignoreT == 0f;
		object obj = !flag;
		bool flag2 = ignoreT > 0f;
		double num = ignoreT;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val2 = (Enumerator<, >)this;
		bool result = false;
		object obj3 = default;
		object obj2 = obj3;
		if (flag2)
		{
			goto IL_1095;
		}
		bool flag3 = targets == null;
		float value = 0f;
		double num3 = default;
		double num2 = num3;
		Enumerator<, > val3 = (Enumerator<, >)0;
		num = ignoreT;
		val = (Enumerator<, >)0;
		ref MonsterCatalog.Target reference2 = ref reference;
		NullReferenceException ex = (NullReferenceException)(object)targets;
		object obj4 = obj3;
		if (flag3)
		{
			goto IL_0cb7;
		}
		Enumerator<, > enumerator = targets.GetEnumerator();
		Enumerator<, > val4 = (Enumerator<, >)(ref val3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA80]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		obj4 = 0;
		value = 0f;
		double num5 = default;
		double num4 = num5;
		num = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
		float num6 = 0f;
		ref MonsterCatalog.Target reference3 = default;
		PlayerRef playerRef2 = default;
		object obj14 = default;
		double num13 = default;
		object obj23 = default;
		double num15 = default;
		double num17 = default;
		double num19 = default;
		Enumerator<, > val6 = default;
		object obj11 = default;
		Transform transform;
		while (val3.MoveNext())
		{
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X0_v33+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = (UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3) == null;
			bool flag6 = !flag5;
			object obj10 = obj11;
			nint num7 = unchecked((nint)null);
			double num8 = num4;
			double num9 = num;
			val = (Enumerator<, >)num6;
			PlayerRef playerRef = (PlayerRef)0;
			nint num10;
			if (!flag6)
			{
				bool flag7 = (object)killedAt == null;
				num10 = unchecked((nint)null);
				val = (Enumerator<, >)num6;
				reference2 = ref *(MonsterCatalog.Target*)null;
				transform = (Transform)(object)killedAt;
				if (flag7)
				{
					goto IL_0bc4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAE0]");
				object obj12 = 0;
				obj10 = obj12;
				flag5 = killedAt.TryGetValue(playerRef2, out value);
				bool flag8 = !flag5;
				num7 = (nint)(&value);
				num8 = num4;
				num9 = num;
				val = (Enumerator<, >)num6;
				playerRef = playerRef2;
				if (!flag8)
				{
					float time = Time.time;
					num8 = recoverSeconds;
					num6 = time - value;
					num9 = (double)recoverSeconds + 6.0;
					bool flag9 = !((double)num6 < num9);
					num7 = (nint)(&value);
					val = (Enumerator<, >)num6;
					playerRef = playerRef2;
					flag5 = false;
					if (!flag9)
					{
						object obj13 = obj14 & 1;
						bool flag10 = obj13 == null;
						num7 = (nint)(&value);
						val = (Enumerator<, >)num6;
						playerRef = playerRef2;
						flag5 = false;
						obj11 = obj12;
						num10 = (nint)(&value);
						num4 = recoverSeconds;
						num = num9;
						if (flag10)
						{
							continue;
						}
					}
				}
			}
			bool flag11 = num3 == 0.0;
			reference2 = ref *(MonsterCatalog.Target*)playerRef;
			transform = (Transform)flag5;
			if (!flag11)
			{
				Vector3 position = ((Transform)num3).position;
				transform = base.transform;
				if ((object)transform != null)
				{
					Vector3 position2 = transform.position;
					object obj15 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X0_v52+E4]");
					bool flag12 = (nint)0 == 0;
					object obj16 = !flag12;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj17 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1176 @ X0_v55+E4]");
					bool flag13 = (nint)0 == 0;
					object obj18 = !flag13;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					double num11 = num8 - num8;
					num = num11 * num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					bool flag14 = 2139095039 >= 2139095039;
					obj11 = obj10;
					num10 = num7;
					num4 = num8;
					num6 = 2.139095E+09f;
					if (flag14)
					{
						continue;
					}
					bool flag15 = CanSee((Transform)num3);
					bool flag16 = !flag15;
					obj11 = obj10;
					num10 = num7;
					num4 = num8;
					num6 = 2.139095E+09f;
					if (flag16)
					{
						continue;
					}
					Vector3 position3 = ((Transform)num3).position;
					transform = base.transform;
					bool flag17 = (object)transform == null;
					obj11 = obj10;
					num10 = num7;
					num4 = num8;
					val = (Enumerator<, >)2139095039;
					reference2 = ref *(MonsterCatalog.Target*)null;
					if (!flag17)
					{
						Vector3 position4 = transform.position;
						object obj19 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v64+E4]");
						bool flag18 = (nint)0 == 0;
						object obj20 = !flag18;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						val = (Enumerator<, >)senseRange;
						bool flag19 = !(2.139095E+09f > senseRange);
						object obj21 = obj;
						double num12 = num13;
						object obj22 = obj23;
						double num14 = num15;
						double num16 = num17;
						double num18 = num19;
						Enumerator<, > val5 = val6;
						double num20 = num8;
						double num21 = num;
						float num22 = senseRange;
						if (!flag19)
						{
							transform = base.transform;
							bool flag20 = (object)transform == null;
							obj11 = obj10;
							num10 = num7;
							num4 = num8;
							reference2 = ref *(MonsterCatalog.Target*)null;
							if (flag20)
							{
								goto IL_0c4e;
							}
							Vector3 forward = transform.forward;
							object obj24 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1218 @ X0_v75+E4]");
							bool flag21 = (nint)0 == 0;
							object obj25 = !flag21;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num23 = 2.139095E+09f - 2.139095E+09f;
							double num24 = num8 - num8;
							object obj26 = val * val;
							double num25 = num * num;
							double num26 = num8 * num8;
							num12 = num24 * num24;
							double num27 = (double)obj26 + num25;
							float num28 = num23 * num23;
							double num29 = num26 + num27;
							double num30 = num12 + (double)num28;
							num20 = num30 * num29;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							double num31 = num20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
							bool flag22 = num31 < 0.0;
							num14 = 0.0;
							if (!flag22)
							{
								float num32 = num23 * (float)val;
								double num33 = num * 0.0;
								double num34 = num24 * num8;
								double num35 = (double)num32 + num33;
								double num36 = num34 + num35;
								double num37 = num36 / num20;
								bool flag23 = num37 < -1.0;
								double num38 = -1.0;
								if (!flag23)
								{
									bool flag24 = !(num37 > 1.0);
									num38 = num37;
									num35 = 1.0;
									if (!flag24)
									{
										num38 = 1.0;
										num35 = 1.0;
									}
								}
								object obj27 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1308 @ X0_v79+E4]");
								bool flag25 = (nint)0 == 0;
								object obj28 = !flag25;
								if (obj28 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
								double num39 = num38;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
								num14 = num39 * 0.0;
							}
							double num40 = (double)sightAngle * 0.5;
							double num41 = num14 - num40;
							bool flag26 = num41 == 0.0;
							obj21 = !flag26;
							bool flag27 = num14 > num40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
							obj22 = 0;
							num16 = num8;
							num18 = num;
							val5 = val;
							num21 = 0.5;
							num22 = (float)num40;
							obj = obj21;
							num13 = num12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
							obj23 = 0;
							num15 = num14;
							num17 = num8;
							num19 = num;
							val6 = val;
							obj11 = obj10;
							num10 = num7;
							num4 = num20;
							num = 0.5;
							num6 = (float)num40;
							if (flag27)
							{
								continue;
							}
						}
						bool flag28 = Way((Transform)num3, out var length);
						bool flag29 = !flag28;
						obj = obj21;
						length = 0f;
						num13 = num12;
						obj23 = obj22;
						num15 = num14;
						num17 = num16;
						num19 = num18;
						val6 = val5;
						obj11 = obj10;
						num10 = (nint)(&length);
						num4 = num20;
						num = num21;
						num6 = num22;
						if (!flag29)
						{
							reference = ref *(MonsterCatalog.Target*)num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X26_v8 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+1D]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X26_v8 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+24]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj = obj21;
							length = 0f;
							num13 = num12;
							obj23 = obj22;
							num15 = num14;
							num17 = num16;
							num19 = num18;
							val6 = val5;
							obj11 = obj10;
							num10 = (nint)(&length);
							num4 = num20;
							num = num21;
							num6 = num22;
						}
						continue;
					}
					goto IL_0c09;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				nint num42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				bool flag30 = num42 != 0;
				obj11 = obj10;
				num10 = num7;
				num4 = num8;
				num = num9;
				reference2 = ref *(MonsterCatalog.Target*)null;
				if (flag30)
				{
					goto IL_0e2c;
				}
				NullReferenceException ex2 = new NullReferenceException();
				reference2 = ref *(MonsterCatalog.Target*)null;
				transform = (Transform)(object)ex2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			nint num43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			bool flag31 = num43 != 0;
			obj11 = obj10;
			num10 = num7;
			num4 = num8;
			num = num9;
			if (!flag31)
			{
				NullReferenceException ex3 = new NullReferenceException();
				obj11 = obj10;
				num10 = num7;
				num4 = num8;
				num = num9;
				transform = (Transform)(object)ex3;
				goto IL_0bc4;
			}
			goto IL_0e2c;
			IL_0bc4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			nint num44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			if (num44 == 0)
			{
				NullReferenceException ex4 = new NullReferenceException();
				transform = (Transform)(object)ex4;
				goto IL_0c09;
			}
			goto IL_0e2c;
			IL_0c4e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			nint num45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			if (num45 == 0)
			{
				goto IL_0c7d;
			}
			goto IL_0e2c;
			IL_0c09:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			nint num46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			if (num46 == 0)
			{
				NullReferenceException ex5 = new NullReferenceException();
				transform = (Transform)(object)ex5;
				goto IL_0c4e;
			}
			goto IL_0e2c;
		}
		double num47 = 2139095039.0;
		float num48 = 2.139095E+09f;
		bool flag32 = false;
		object obj29 = 0;
		Enumerator<, > val7 = default;
		val3 = val7;
		val = (Enumerator<, >)num6;
		Enumerator<, > val8 = (Enumerator<, >)(ref val3);
		object obj30 = 7;
		object obj31 = 0;
		goto IL_112d;
		IL_1095:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X21_v2+28]");
		nint num49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		bool flag33 = num49 != 0;
		reference2 = ref reference;
		transform = (Transform)val2;
		if (!flag33)
		{
			return result;
		}
		goto IL_0e2c;
		IL_0d49:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X21_v7+28]");
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		if (num50 != 0)
		{
			goto IL_0e2c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) == (void*)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			flag32 = true;
			obj31 = obj29;
		}
		else
		{
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != (void*)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FCB0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				nint num51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				if (num51 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
				goto IL_0e2c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj32 = default;
			obj31 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			flag32 = (byte)(int)num2 != 0;
			obj29 = obj32;
		}
		num47 = num48;
		obj30 = 0;
		goto IL_112d;
		IL_0c7d:
		ex = new NullReferenceException();
		num48 = 2.139095E+09f;
		num2 = 0.0;
		obj29 = 0;
		val3 = val7;
		val8 = (Enumerator<, >)(ref val3);
		goto IL_0cb7;
		IL_112d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA70]");
		object obj33 = 0;
		reference2 = ref *(MonsterCatalog.Target*)obj33;
		((Enumerator<, >*)val8)->Dispose();
		bool flag34 = obj31 == null;
		object obj34 = !flag34;
		num2 = (flag32 ? 1 : 0);
		transform = (Transform)val8;
		obj4 = obj3;
		if (obj34 != null)
		{
			goto IL_0d04;
		}
		bool flag35 = !flag32;
		object obj35 = !flag35;
		num2 = (flag32 ? 1 : 0);
		transform = (Transform)val8;
		obj4 = obj3;
		if (obj35 != null)
		{
			goto IL_0d49;
		}
		if ((nint)obj30 != 7)
		{
			bool flag36 = obj30 == null;
			object obj36 = !flag36;
			reference = ref *(MonsterCatalog.Target*)obj33;
			val2 = val8;
			result = flag32;
			obj2 = obj3;
			if (obj36 != null)
			{
				goto IL_1095;
			}
		}
		double num52 = num47 - 2139095039.0;
		bool flag37 = num52 < 0.0;
		num = num47;
		val = (Enumerator<, >)2139095039;
		reference = ref reference2;
		val2 = val8;
		result = flag37;
		obj2 = obj3;
		goto IL_1095;
		IL_0cb7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		nint num53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		bool flag38 = num53 != 0;
		transform = (Transform)(object)ex;
		if (!flag38)
		{
			NullReferenceException ex6 = new NullReferenceException();
			transform = (Transform)(object)ex6;
			goto IL_0d04;
		}
		goto IL_0e2c;
		IL_0e2c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result2 = default;
		return result2;
		IL_0d04:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X21_v7+28]");
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		if (num54 == 0)
		{
			OutOfMemoryException ex7 = new OutOfMemoryException();
			transform = (Transform)(object)ex7;
			goto IL_0d49;
		}
		goto IL_0e2c;
	}

	private unsafe bool GoForEasiest(bool haveOne)
	{
		//IL_100d: Expected Obj, but got Ref
		//IL_006e: Expected F4, but got I4
		//IL_0077: Expected F4, but got I4
		//IL_1209: Expected Obj, but got Ref
		//IL_1229: Expected Obj, but got I4
		//IL_1232: Expected F4, but got I4
		//IL_1243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got VT
		//IL_0033: Expected Obj, but got I4
		//IL_003c: Expected I4, but got Obj
		//IL_0060: Expected F4, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I4
		//IL_00e2: Expected F4, but got I4
		//IL_00f2: Expected F8, but got I4
		//IL_0100: Expected VT, but got I4
		//IL_1039: Expected F4, but got I4
		//IL_1053: Expected I4, but got VT
		//IL_1068: Expected Obj, but got I
		//IL_0a46: Expected F8, but got I4
		//IL_0a4f: Expected Obj, but got I4
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected Obj, but got I4
		//IL_0a83: Expected Obj, but got I4
		//IL_11c0: Expected Obj, but got I
		//IL_11c8: Expected I4, but got Obj
		//IL_11c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d1: Expected Ref, but got Unknown
		//IL_11eb: Expected Obj, but got I4
		//IL_11eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f3: Expected Obj, but got Unknown
		//IL_0435: Expected Obj, but got I4
		//IL_0a91: Invalid comparison between F8 and I4
		//IL_0aa2: Expected Obj, but got I4
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		//IL_0494: Expected I, but got Obj
		//IL_049d: Expected VT, but got I4
		//IL_0168: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I4
		//IL_0665: Invalid comparison between F8 and I4
		//IL_0673: Expected I4, but got VT
		//IL_067b: Expected Obj, but got I4
		//IL_04d1: Expected I, but got Obj
		//IL_02ab: Expected Obj, but got I4
		//IL_0b26: Invalid comparison between F4 and I4
		//IL_0b37: Expected Obj, but got I4
		//IL_0692: Expected Obj, but got F8
		//IL_02ea: Expected I, but got Obj
		//IL_01ea: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I4
		//IL_0b69: Expected Obj, but got I4
		//IL_0aef: Expected Obj, but got I4
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected Obj, but got Unknown
		//IL_0502: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I4
		//IL_0259: Expected I, but got Obj
		//IL_1149: Invalid comparison between F8 and I4
		//IL_1158: Expected F4, but got I4
		//IL_1158: Unknown result type (might be due to invalid IL or missing references)
		//IL_1160: Expected Obj, but got Unknown
		//IL_1169: Expected F8, but got I4
		//IL_0e42: Expected F8, but got I4
		//IL_0e4b: Expected Obj, but got I4
		//IL_0e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_0329: Expected I, but got Obj
		//IL_0f74: Expected F8, but got I4
		//IL_06df: Expected Obj, but got I
		//IL_0709: Expected Obj, but got I4
		//IL_0274: Expected I, but got Obj
		//IL_0fd3: Expected Obj, but got I4
		//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7c: Expected Obj, but got Unknown
		//IL_0b94: Expected F4, but got I4
		//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected Obj, but got Unknown
		//IL_0ba5: Expected F8, but got I4
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d18: Expected I4, but got Unknown
		//IL_0356: Expected Obj, but got I4
		//IL_0363: Expected I, but got Obj
		//IL_10c4: Expected Obj, but got I4
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected Obj, but got Unknown
		//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Expected Obj, but got Unknown
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Expected Obj, but got Unknown
		//IL_0bd6: Expected Obj, but got Ref
		//IL_0be5: Expected VT, but got Obj
		//IL_0c43: Expected F4, but got I4
		//IL_0771: Invalid comparison between F4 and I4
		//IL_0782: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		//IL_03bb: Expected Obj, but got I4
		//IL_07eb: Expected Obj, but got I4
		//IL_03e0: Invalid comparison between VT and Obj
		//IL_03eb: Expected I, but got Obj
		//IL_03fd: Expected I, but got Obj
		//IL_0c70: Expected Obj, but got I
		//IL_0c93: Expected F4, but got I4
		//IL_0cc2: Expected VT, but got I4
		//IL_0ceb: Expected F4, but got I4
		//IL_0cfc: Expected Obj, but got VT
		//IL_0d05: Expected F8, but got I4
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected Obj, but got Unknown
		//IL_08bb: Expected Obj, but got F8
		//IL_0870: Expected Obj, but got F8
		//IL_090a: Expected Obj, but got F8
		//IL_0926: Invalid comparison between F8 and I4
		//IL_0939: Expected Obj, but got F8
		//IL_0946: Expected Obj, but got F8
		//IL_097b: Expected Obj, but got I4
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected Obj, but got Unknown
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Obj, but got Unknown
		//IL_09e3: Expected Obj, but got Ref
		//IL_0a08: Expected Obj, but got F8
		object obj2 = default;
		object obj = (object)(&obj2);
		_ = 0;
		float num;
		nint num4 = default;
		float num2;
		float num3;
		bool flag3;
		if (haveOne)
		{
			bool flag = Way((Transform)prey, out var length);
			bool flag2 = !flag;
			object obj3 = !flag2;
			num = (((int)(~obj3) != 0) ? 2.139095E+09f : length);
			num2 = 2.139095E+09f;
			num3 = length;
			num4 = (nint)(&length);
			flag3 = (byte)(int)prey != 0;
		}
		else
		{
			num = 2.139095E+09f;
			num3 = 0f;
			flag3 = haveOne;
		}
		object obj4 = (object)(&obj2);
		_ = 0;
		bool flag4 = targets == null;
		obj2 = 0;
		float length2 = 0f;
		double num6 = default;
		double num5 = num6;
		Enumerator<, > val = (Enumerator<, >)0;
		NullReferenceException ex = (NullReferenceException)(object)targets;
		if (flag4)
		{
			goto IL_0e62;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Enumerator<, > enumerator = targets.GetEnumerator();
		Enumerator<, > val2 = (Enumerator<, >)(ref val);
		double num7 = (double)num + -2.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj6 = 0;
		obj2 = 0;
		length2 = 0f;
		Transform transform = null;
		double num8 = 2139095039.0;
		UnityEngine.Object obj7 = null;
		PlayerRef playerRef = (PlayerRef)0;
		float num10 = default;
		float num9 = num10;
		double num11 = num6;
		double num12 = -2.0;
		UnityEngine.Object obj11 = default;
		UnityEngine.Object obj16 = default;
		object obj21 = default;
		PlayerRef playerRef2 = default;
		object obj29 = default;
		Transform transform2;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA80]");
			object obj8 = 0;
			UnityEngine.Object obj9 = (UnityEngine.Object)obj8;
			if (!val.MoveNext())
			{
				break;
			}
			bool flag5 = !haveOne;
			UnityEngine.Object obj10 = obj11;
			nint num13 = num4;
			if (!flag5)
			{
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+1C8]");
				obj10 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X0_v73+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (obj10 != null)
				{
					object obj14 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+1C8]");
					obj11 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X0_v85+E4]");
					bool flag7 = (nint)0 == 0;
					object obj15 = !flag7;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag8 = obj16 == obj11;
					bool flag9 = !flag8;
					object obj17 = !flag9;
					num4 = unchecked((nint)null);
					if (obj17 != null)
					{
						continue;
					}
					obj10 = obj11;
					num13 = unchecked((nint)null);
					obj9 = obj11;
				}
				else
				{
					object obj18 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X0_v77+E4]");
					bool flag10 = (nint)0 == 0;
					object obj19 = !flag10;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag11 = obj16 == null;
					bool flag12 = !flag11;
					num13 = unchecked((nint)null);
					obj9 = null;
					if (!flag12)
					{
						object obj20 = obj21 & 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+1BC]");
						bool flag13 = obj20 != null;
						num13 = unchecked((nint)null);
						obj9 = null;
						if (!flag13)
						{
							bool flag14 = obj20 == null;
							object obj22 = !flag14;
							obj11 = obj10;
							num4 = unchecked((nint)null);
							if (obj22 != null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+1B8]");
							obj10 = (UnityEngine.Object)0;
							object obj24 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X0_v81+E4]");
							bool flag15 = (nint)0 == 0;
							object obj25 = !flag15;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag16 = playerRef2 == (PlayerRef)(object)obj10;
							num13 = unchecked((nint)null);
							obj9 = null;
							obj11 = obj10;
							num4 = unchecked((nint)null);
							if (flag16)
							{
								continue;
							}
						}
					}
				}
			}
			object obj26 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X0_v38+E4]");
			bool flag17 = (nint)0 == 0;
			object obj27 = !flag17;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag18 = obj16 == null;
			bool flag19 = !flag18;
			object obj28 = obj29;
			float num14 = num9;
			num2 = (float)num11;
			num3 = (float)num12;
			nint num15 = unchecked((nint)null);
			PlayerRef playerRef3 = (PlayerRef)0;
			if (!flag19)
			{
				bool flag20 = (object)killedAt == null;
				num2 = (float)num11;
				num3 = (float)num12;
				num4 = unchecked((nint)null);
				flag3 = false;
				transform2 = (Transform)(object)killedAt;
				if (flag20)
				{
					goto IL_0e01;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAE0]");
				object obj30 = 0;
				obj28 = obj30;
				flag18 = killedAt.TryGetValue(playerRef2, out var value);
				bool flag21 = !flag18;
				num14 = num9;
				num2 = (float)num11;
				num3 = (float)num12;
				num15 = (nint)(&value);
				playerRef3 = playerRef2;
				if (!flag21)
				{
					float time = Time.time;
					num14 = recoverSeconds;
					num12 = (double)time - (double)value;
					num11 = (double)recoverSeconds + 6.0;
					bool flag22 = !(num12 < num11);
					num2 = (float)num11;
					num3 = (float)num12;
					num15 = (nint)(&value);
					playerRef3 = playerRef2;
					flag18 = false;
					if (!flag22)
					{
						object obj31 = obj21 & 1;
						bool flag23 = obj31 == null;
						num2 = (float)num11;
						num3 = (float)num12;
						num15 = (nint)(&value);
						playerRef3 = playerRef2;
						flag18 = false;
						obj29 = obj30;
						obj11 = obj10;
						num9 = recoverSeconds;
						num4 = (nint)(&value);
						if (flag23)
						{
							continue;
						}
					}
				}
			}
			bool flag24 = num6 == 0.0;
			flag3 = (byte)(int)playerRef3 != 0;
			transform2 = (Transform)flag18;
			if (!flag24)
			{
				Vector3 position = ((Transform)num6).position;
				transform2 = base.transform;
				if ((object)transform2 != null)
				{
					Vector3 position2 = transform2.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
					object obj32 = 0;
					object obj33 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X0_v53+E4]");
					bool flag25 = (nint)0 == 0;
					object obj34 = !flag25;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj35 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X0_v56+E4]");
					bool flag26 = (nint)0 == 0;
					object obj36 = !flag26;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num16 = num3 - num3;
					float num17 = num14 - num14;
					float num18 = num - 2.139095E+09f;
					bool flag27 = num18 < 0f;
					object obj37 = !flag27;
					float num19 = num16 * num16;
					num11 = (double)num17 * (double)num17;
					num12 = (double)num19 + num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					object obj38 = ((num12 < num7) ? ((object)1) : obj37);
					bool flag28 = !(num12 < num8);
					obj29 = obj28;
					obj11 = obj10;
					num9 = num14;
					num4 = num15;
					if (flag28)
					{
						continue;
					}
					object obj39 = obj38 & 1;
					bool flag29 = obj39 == null;
					obj29 = obj28;
					obj11 = obj10;
					num9 = num14;
					num4 = num15;
					if (flag29)
					{
						continue;
					}
					num11 = senseRange;
					if (num12 > (double)senseRange)
					{
						bool flag30 = CanSee((Transform)num6);
						bool flag31 = !flag30;
						obj29 = obj28;
						obj11 = obj10;
						num9 = num14;
						num4 = num15;
						if (flag31)
						{
							continue;
						}
					}
					bool flag32 = InReach((Transform)num6);
					bool flag33 = !flag32;
					obj29 = obj28;
					obj11 = obj10;
					num9 = num14;
					num4 = num15;
					if (!flag33)
					{
						bool flag34 = Way((Transform)num6, out length2);
						double num20 = (double)length2 - num8;
						bool flag35 = num20 < 0.0;
						object obj40 = (double)length2 ^ num8;
						object obj41 = (double)length2 ^ num20;
						object obj42 = obj40 & obj41;
						bool flag36 = (nint)obj42 < 0;
						bool flag37 = flag35 == flag36;
						object obj43 = !flag37;
						object obj44 = flag34 & obj43;
						object obj45 = obj44 & 1;
						bool flag38 = obj45 == null;
						obj29 = obj28;
						obj11 = obj10;
						num9 = num14;
						num12 = length2;
						num4 = (nint)(&length2);
						if (!flag38)
						{
							object obj46 = (object)(&obj2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X28_v7 (System.Collections.Generic.LowLevelDictionary`2<MonsterCatalog+Target>+Enumerator<MonsterCatalog+Target>)+24]");
							_ = 0;
							obj29 = obj28;
							obj11 = obj10;
							transform = (Transform)num6;
							num8 = length2;
							obj7 = obj16;
							playerRef = playerRef2;
							num9 = num14;
							num12 = length2;
							num4 = (nint)(&length2);
						}
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				nint num21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				bool flag39 = num21 != 0;
				obj29 = obj28;
				num9 = num14;
				num4 = num15;
				flag3 = false;
				if (flag39)
				{
					goto IL_0fe7;
				}
				NullReferenceException ex2 = new NullReferenceException();
				flag3 = false;
				transform2 = (Transform)(object)ex2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			bool flag40 = num22 != 0;
			obj29 = obj28;
			num9 = num14;
			num4 = num15;
			if (!flag40)
			{
				NullReferenceException ex3 = new NullReferenceException();
				obj29 = obj28;
				num9 = num14;
				num4 = num15;
				transform2 = (Transform)(object)ex3;
				goto IL_0e01;
			}
			goto IL_0fe7;
			IL_0e01:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			if (num23 == 0)
			{
				goto IL_0e30;
			}
			goto IL_0fe7;
		}
		num5 = 0.0;
		object obj47 = 0;
		Enumerator<, > val3 = default;
		val = val3;
		Enumerator<, > val4 = (Enumerator<, >)(ref val);
		num2 = (float)num11;
		num3 = (float)num12;
		object obj48 = 0;
		object obj49 = 13;
		goto IL_11b0;
		IL_0eaf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		if (num24 == 0)
		{
			OutOfMemoryException ex4 = new OutOfMemoryException();
			transform2 = (Transform)(object)ex4;
			goto IL_0ef4;
		}
		goto IL_0fe7;
		IL_11b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA70]");
		object obj50 = 0;
		flag3 = (byte)(int)obj50 != 0;
		((Enumerator<, >*)val4)->Dispose();
		bool flag41 = obj48 == null;
		object obj51 = !flag41;
		transform2 = (Transform)val4;
		if (obj51 != null)
		{
			goto IL_0eaf;
		}
		bool flag42 = num5 == 0.0;
		object obj52 = !flag42;
		transform2 = (Transform)val4;
		if (obj52 != null)
		{
			goto IL_0ef4;
		}
		double num25;
		if ((nint)obj49 != 13)
		{
			bool flag43 = obj49 == null;
			object obj53 = !flag43;
			transform2 = (Transform)val4;
			num25 = num5;
			if (obj53 != null)
			{
				goto IL_1111;
			}
		}
		float num26 = num - 2.139095E+09f;
		bool flag44 = num26 < 0f;
		object obj54 = !flag44;
		object obj55 = ((num8 < num7) ? ((object)1) : obj54);
		bool flag45 = num8 == 2139095039.0;
		num3 = 2.139095E+09f;
		transform2 = (Transform)val4;
		num25 = 0.0;
		if (!flag45)
		{
			object obj56 = obj55 & 1;
			bool flag46 = obj56 == null;
			num3 = 2.139095E+09f;
			transform2 = (Transform)val4;
			num25 = 0.0;
			if (!flag46)
			{
				object obj57 = this + 445;
				object obj58 = this + 432;
				object obj59 = (object)(&obj2);
				prey = (MonsterCatalog.Target)transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X8_v17+7]");
				_ = 0;
				obj57 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				List<Vector3> list = trail;
				reachedFor = 0f;
				hasPrey = true;
				bool flag47 = trail == null;
				num3 = 2.139095E+09f;
				flag3 = false;
				if (!flag47)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v20 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj60 = (nint)0 + (nint)1;
					_ = 0;
					bool flag48 = (object)transform == null;
					num3 = 2.139095E+09f;
					flag3 = false;
					if (!flag48)
					{
						Vector3 position3 = transform.position;
						lastSeen = (Vector3)2139095039;
						unreachT = 0f;
						repathAt = 0f;
						num3 = 2.139095E+09f;
						flag3 = false;
						transform2 = (Transform)position3;
						num25 = 1.0;
						goto IL_1111;
					}
				}
				goto IL_0e62;
			}
		}
		goto IL_1111;
		IL_1111:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		if (num27 == 0)
		{
			return (byte)(num25 & 1) != 0;
		}
		goto IL_0fe7;
		IL_0ef4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		if (num28 != 0)
		{
			goto IL_0fe7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((flag3 ? 1 : 0) == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num5 = 1.0;
			obj48 = obj47;
		}
		else
		{
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FCB0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				nint num29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				if (num29 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
				goto IL_0fe7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj61 = default;
			obj48 = obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj47 = obj61;
		}
		obj49 = 0;
		goto IL_11b0;
		IL_0e62:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		bool flag49 = num30 != 0;
		transform2 = (Transform)(object)ex;
		if (!flag49)
		{
			NullReferenceException ex5 = new NullReferenceException();
			transform2 = (Transform)(object)ex5;
			goto IL_0eaf;
		}
		goto IL_0fe7;
		IL_0e30:
		ex = new NullReferenceException();
		num5 = 0.0;
		obj47 = 0;
		val = val3;
		val4 = (Enumerator<, >)(ref val);
		goto IL_0e62;
		IL_0fe7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
	}

	private void StartKill(MonsterCatalog.Target t)
	{
		//IL_04bd: Expected Obj, but got I
		//IL_04dc: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I4
		//IL_027f: Expected VT, but got Obj
		//IL_02b0: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I4
		//IL_052d: Expected Obj, but got I
		//IL_053d: Invalid comparison between F4 and I
		//IL_054f: Expected VT, but got I4
		//IL_0449: Expected Obj, but got I4
		//IL_0577: Expected Obj, but got I
		//IL_05a1: Expected Obj, but got I4
		//IL_03be: Expected Obj, but got I
		//IL_05c7: Expected Obj, but got I
		//IL_05d7: Expected Obj, but got I
		//IL_05e7: Expected Obj, but got I
		//IL_0402: Expected VT, but got I4
		//IL_040b: Expected Obj, but got I4
		//IL_0414: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool flag = !t.local;
		object obj2 = !flag;
		MonsterCatalog.Target target = t;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj3 = 0;
			object obj4 = obj;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = (UnityEngine.Object)obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 != null)
			{
				return;
			}
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v8+A0]");
			object obj10 = 0;
			bool flag5 = ((KillCam)obj10).Begin(this, (Transform)null);
			bool flag6 = !flag5;
			object obj11 = !flag6;
			target = (MonsterCatalog.Target)this;
			if (obj11 == null)
			{
				return;
			}
		}
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = (UnityEngine.Object)t.dummy != (UnityEngine.Object)null;
		bool flag9 = !flag8;
		UnityEngine.Object obj14 = null;
		if (!flag9)
		{
			bool standing = t.dummy.Standing;
			bool flag10 = !standing;
			obj14 = null;
			if (flag10)
			{
				return;
			}
		}
		Chasing__BackingField = false;
		object obj15 = obj;
		state__BackingField = (State)4;
		stateT = 0f;
		reachedFor = 0f;
		listening = false;
		killLocal = t.local;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v18+E4]");
		bool flag11 = (nint)0 == 0;
		object obj16 = !flag11;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float time = default;
		if ((UnityEngine.Object)t.dummy != (UnityEngine.Object)null)
		{
			t.dummy.Eaten(this);
			object obj17 = 0;
		}
		else
		{
			time = Time.time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAF0]");
			object obj18 = 0;
			object obj17 = obj18;
			killedAt.set_Item(t.player, time);
		}
		speed = 0f;
		Vector3 position = t.head.position;
		Transform transform = base.transform;
		Vector3 position2 = transform.position;
		float num = time - time;
		object obj20 = default;
		object obj19 = obj20 - obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj21 = 0;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v28+E4]");
		bool flag12 = (nint)0 == 0;
		object obj23 = !flag12;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2 = num * num;
		object obj24 = obj19 * obj19;
		float num3 = num2 + (float)obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		bool flag13 = !(num3 > 0f);
		Quaternion quaternion = (Quaternion)0;
		if (!flag13)
		{
			Transform transform2 = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj26 = 0;
			object obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v42+E4]");
			bool flag14 = (nint)0 == 0;
			object obj28 = !flag14;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj29 = 0;
			object obj30 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if ((nint)obj30 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			}
			object obj31 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v34+A0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v35+18]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v35+20]");
			obj24 = 0;
			Vector3 forward = default;
			Vector3 upwards = default;
			Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
			transform2.rotation = (Quaternion)0;
			object obj17 = 0;
			quaternion = (Quaternion)0;
		}
		PlayKill();
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v32+E4]");
		bool flag15 = (nint)0 == 0;
		object obj34 = !flag15;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)net != (UnityEngine.Object)null)
		{
			net.KillStarted(t.player);
		}
	}

	public void OnBite()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 != null;
		bool flag3 = !flag2;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (!flag3)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v9+A0]");
			object obj10 = 0;
			object obj11 = obj10;
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v11+C0]");
			bool flag5 = (UnityEngine.Object)0 == this;
			bool flag6 = !flag5;
			obj7 = 0;
			obj8 = this;
			if (!flag6)
			{
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v13+A0]");
				object obj15 = 0;
				((KillCam)obj15).Bite();
				obj7 = 0;
				obj8 = null;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj16 = 0;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaDummy.BittenBy(this, arm: false);
	}

	public void OnTear()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I4
		//IL_0110: Expected I4, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 != null;
		bool flag3 = !flag2;
		object obj7 = 0;
		ApePart apePart = (ApePart)0;
		if (!flag3)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v9+A0]");
			object obj9 = 0;
			object obj10 = obj9;
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v11+C0]");
			bool flag5 = (UnityEngine.Object)0 == this;
			bool flag6 = !flag5;
			obj7 = 0;
			apePart = (ApePart)this;
			if (!flag6)
			{
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v13+A0]");
				object obj14 = 0;
				((KillCam)obj14).TearArm((ApePart)2);
				obj7 = 0;
				apePart = (ApePart)2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaDummy.BittenBy(this, arm: true);
	}

	private void Look(Vector3 at, float weight)
	{
		//IL_000a: Expected VT, but got F4
		lookWant = (Vector3)weight;
		float num = default;
		lookWeightWant = num;
	}

	private void Glance(float dt, float weight = default(float))
	{
		//IL_0028: Expected F4, but got I
		//IL_00ce: Expected VT, but got I4
		//IL_00ce: Expected VT, but got I4
		//IL_00e7: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_024d: Expected VT, but got F4
		float time = Time.time;
		if (!(time < nextGlance))
		{
			float time2 = Time.time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
			float num = UnityEngine.Random.Range(0f, 3f);
			float num2 = time2 + num;
			nextGlance = num2;
			float num3 = UnityEngine.Random.Range(-10f, 15f);
			float num4 = UnityEngine.Random.Range(-75f, 75f);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			float num5 = num3 * num4;
			Vector3 euler = default;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			Transform transform = base.transform;
			Vector3 forward = transform.forward;
			Vector3 vector = (Quaternion)0 * (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4;
			object obj5 = default;
			float num6;
			float num7;
			if (face != null)
			{
				Vector3 position = face.position;
				obj4 = obj5;
				num6 = num5;
				num7 = num3;
			}
			else
			{
				Transform transform2 = base.transform;
				Vector3 position2 = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v17+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v18+20]");
				obj4 = obj5 + 0;
				float num8 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v18+18]");
				num6 = num8 + 0f;
				float num9 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v18+1C]");
				num7 = num9 + 0f;
			}
			float num10 = num5 * 4f;
			float num11 = num3 * 4f;
			double num12 = (double)obj5 * 4.0;
			float num13 = num10 + num6;
			float num14 = num11 + num7;
			double num15 = num12 + (double)obj4;
			lookWant = (Vector3)num13;
		}
		lookWeightWant = weight;
	}

	private unsafe Vector3 Hunt(Transform head, bool sees)
	{
		//IL_0010: Expected Obj, but got I
		//IL_114c: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_0479: Expected Obj, but got I
		//IL_0489: Expected Obj, but got I
		//IL_04a7: Expected Obj, but got I
		//IL_054c: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_0262: Expected Obj, but got I
		//IL_026a: Expected I4, but got Obj
		//IL_028d: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I4
		//IL_0583: Expected Obj, but got I4
		//IL_05c1: Expected Obj, but got I
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_069a: Expected Obj, but got I
		//IL_06aa: Expected Obj, but got I
		//IL_06bf: Expected VT, but got I
		//IL_118d: Expected Obj, but got I
		//IL_11a5: Expected Obj, but got I
		//IL_11c7: Expected Obj, but got I4
		//IL_0654: Expected Obj, but got I
		//IL_0664: Expected Obj, but got I
		//IL_067b: Expected VT, but got I
		//IL_0685: Expected VT, but got Obj
		//IL_0760: Expected Obj, but got I4
		//IL_0608: Expected Obj, but got I
		//IL_062b: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I4
		//IL_0366: Expected Obj, but got F8
		//IL_0373: Expected Obj, but got F8
		//IL_013e: Expected VT, but got Obj
		//IL_077e: Expected Obj, but got I
		//IL_07a0: Expected Obj, but got I4
		//IL_07d0: Expected Obj, but got I
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected Obj, but got Unknown
		//IL_045b: Expected Obj, but got I4
		//IL_08b8: Expected Obj, but got I4
		//IL_0828: Expected Obj, but got I
		//IL_0830: Expected I4, but got Obj
		//IL_11e5: Expected Obj, but got I
		//IL_11f5: Expected Obj, but got I
		//IL_11ff: Expected I4, but got Obj
		//IL_121f: Expected Obj, but got I
		//IL_122f: Expected F8, but got I
		//IL_123f: Expected F8, but got I
		//IL_1261: Expected Obj, but got I4
		//IL_08f1: Expected Obj, but got I4
		//IL_12bc: Expected Obj, but got I4
		//IL_0981: Expected Obj, but got I4
		//IL_09db: Expected Obj, but got I
		//IL_0a0b: Expected Obj, but got I4
		//IL_0a2b: Expected Obj, but got I4
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Expected Obj, but got Unknown
		//IL_0a87: Expected Obj, but got I4
		//IL_09ae: Expected F8, but got I
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Expected Obj, but got Unknown
		//IL_0af2: Expected Obj, but got I4
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected Obj, but got Unknown
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Expected Obj, but got Unknown
		//IL_0b36: Expected I4, but got Obj
		//IL_0b41: Expected Obj, but got I4
		//IL_0e38: Expected Obj, but got I
		//IL_0e48: Expected Obj, but got I
		//IL_0e68: Expected F8, but got I
		//IL_0e78: Expected Obj, but got I
		//IL_0b5d: Expected Obj, but got I4
		//IL_13c8: Expected Obj, but got I
		//IL_13ea: Expected Obj, but got I4
		//IL_141a: Expected Obj, but got I
		//IL_142a: Unknown result type (might be due to invalid IL or missing references)
		//IL_142f: Expected Obj, but got Unknown
		//IL_12da: Expected Obj, but got I
		//IL_12ea: Expected Obj, but got I
		//IL_12f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f8: Expected Obj, but got Unknown
		//IL_135d: Expected Obj, but got I4
		//IL_0e95: Expected I4, but got Obj
		//IL_0b6a: Expected I4, but got Obj
		//IL_0b85: Expected VT, but got Obj
		//IL_0b95: Expected Obj, but got I
		//IL_0bb7: Expected Obj, but got I4
		//IL_0be1: Expected VT, but got I4
		//IL_0bff: Expected Obj, but got I4
		//IL_0f25: Expected Obj, but got I4
		//IL_0d7e: Expected Obj, but got I4
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Expected Obj, but got Unknown
		//IL_0c35: Expected Obj, but got I4
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c55: Expected Obj, but got Unknown
		//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c62: Expected Obj, but got Unknown
		//IL_1388: Expected Obj, but got I
		//IL_13aa: Expected Obj, but got I4
		//IL_0d9c: Expected Obj, but got I
		//IL_0df9: Expected Obj, but got I4
		//IL_0fc4: Expected Obj, but got I4
		//IL_0fe2: Expected Obj, but got F8
		//IL_0fef: Expected Obj, but got F8
		//IL_0d27: Expected Obj, but got I4
		//IL_1063: Expected I4, but got Obj
		//IL_1099: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE20E]");
		List<Vector3> list = (List<Vector3>)0;
		bool flag = (object)head == null;
		double num2 = default;
		double num = num2;
		double num4 = default;
		double num3 = num4;
		Transform transform = head;
		bool flag3 = default;
		bool flag2 = flag3;
		object obj = 109895680;
		double num6 = default;
		bool flag8;
		double num11;
		double num12;
		double num13;
		double num15;
		bool flag10;
		bool flag11;
		double num5;
		double num7;
		double num8;
		List<Vector3> list3;
		bool flag9 = default;
		double num14 = default;
		double num16 = default;
		if (!flag)
		{
			Vector3 position = head.position;
			List<Vector3> list2 = trail;
			if (flag3)
			{
				bool flag4 = trail == null;
				transform = head;
				obj = 109895680;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					list = (List<Vector3>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj3 = (nint)0 + (nint)2;
					list3 = (List<Vector3>)obj2;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					bool flag5 = (nint)0 == 0;
					transform = head;
					obj = 109895680;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						if ((nint)0 != 0)
						{
							_ = 1;
							return (Vector3)trail;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X9_v9 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+20]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v54+A8]");
						object obj5 = 0;
						List<Vector3> list4 = trail;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v55+70]");
						list4.AddWithResize((Vector3)0);
						return (Vector3)trail;
					}
				}
			}
			else
			{
				bool flag6 = trail == null;
				num = num2;
				num3 = num4;
				num5 = num6;
				num7 = num2;
				num8 = num4;
				transform = head;
				flag2 = flag3;
				obj = 109895680;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					bool flag7 = (nint)0 == 0;
					flag8 = flag9;
					object obj7 = default;
					object obj6 = obj7;
					object obj9 = default;
					object obj8 = obj9;
					object obj11 = default;
					object obj10 = obj11;
					double num10 = default;
					double num9 = num10;
					object obj13 = default;
					object obj12 = obj13;
					num11 = num2;
					num12 = num4;
					num13 = num14;
					num15 = num16;
					flag10 = flag3;
					int num17 = 0;
					List<Vector3> list5 = trail;
					flag11 = flag3;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						num17 = (int)(-1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
						list3 = (List<Vector3>)0;
						flag10 = (byte)(int)list3 != 0;
						Vector3 vector = trail.get_Item(num17);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
						object obj14 = 0;
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v55+E4]");
						bool flag12 = (nint)0 == 0;
						object obj16 = !flag12;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						num15 = num4 - num4;
						num13 = num6 - num6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj17 = 0;
						object obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v58+E4]");
						list = (List<Vector3>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v58+E4]");
						bool flag13 = (nint)0 == 0;
						object obj19 = !flag13;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						double num18 = num15 * num15;
						double num19 = num13 * num13;
						num12 = num18 + num19;
						num11 = trailSpacing;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						bool flag14 = num12 < (double)trailSpacing;
						obj13 = !flag14;
						num10 = num12 - (double)trailSpacing;
						obj11 = num12 ^ (double)trailSpacing;
						obj9 = num12 ^ num10;
						obj7 = obj11 & obj9;
						flag8 = !(num12 > (double)trailSpacing);
						flag11 = false;
						if (flag8)
						{
							goto IL_06e4;
						}
						list5 = trail;
						bool flag15 = trail == null;
						obj6 = obj7;
						obj8 = obj9;
						obj10 = obj11;
						num9 = num10;
						obj12 = obj13;
						flag11 = false;
						flag9 = flag8;
						num = trailSpacing;
						num3 = num12;
						num14 = num13;
						num16 = num15;
						flag3 = flag10;
						num5 = num6;
						num7 = num2;
						num8 = num4;
						transform = head;
						flag2 = false;
						obj = 109895680;
						if (flag15)
						{
							goto IL_10c2;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					list = (List<Vector3>)0;
					list3 = (List<Vector3>)obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj3 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					bool flag16 = (nint)0 == 0;
					flag9 = flag8;
					obj7 = obj6;
					obj9 = obj8;
					obj11 = obj10;
					num10 = num9;
					obj13 = obj12;
					num = num11;
					num3 = num12;
					num14 = num13;
					num16 = num15;
					flag3 = flag10;
					num5 = num6;
					num7 = num2;
					num8 = num4;
					transform = head;
					flag2 = flag11;
					obj = 109895680;
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						bool flag17 = num20 < 0;
						obj13 = !flag17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						double num21 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						num10 = num21 - 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						obj11 = num22 ^ 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						obj9 = 0 ^ num10;
						obj7 = obj11 & obj9;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj21 = (nint)0 * (nint)12;
							list = (List<Vector3>)(object)((object)list + obj21);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							list3 = (List<Vector3>)((nint)0 + (nint)1);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X9_v9 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+20]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v41+A8]");
							list = (List<Vector3>)0;
							List<Vector3> list6 = list5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+70]");
							list6.AddWithResize((Vector3)0);
							num11 = num2;
							num12 = num4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+70]");
							num17 = 0;
						}
						goto IL_06e4;
					}
				}
			}
		}
		goto IL_10c2;
		IL_0d34:
		bool flag18 = trail == null;
		double num24;
		double num23 = num24;
		double num26;
		double num25 = num26;
		double num28;
		double num27 = num28;
		num = num8;
		num3 = num7;
		num14 = num26;
		list3 = (List<Vector3>)7;
		if (!flag18)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAE8]");
			list = (List<Vector3>)0;
			trail.RemoveRange(0, flag2 ? 1 : 0);
			num23 = num24;
			num25 = num26;
			num27 = num28;
			num6 = num5;
			num = num8;
			num3 = num7;
			num14 = num26;
			flag3 = flag2;
			list3 = (List<Vector3>)7;
			goto IL_0dff;
		}
		goto IL_10c2;
		IL_0ce6:
		num23 = num5;
		num25 = num8;
		num27 = num7;
		num6 = num5;
		num = num8;
		num3 = num7;
		num14 = num8;
		list3 = (List<Vector3>)7;
		bool flag19;
		flag2 = flag19;
		goto IL_0dff;
		IL_10fd:
		List<Vector3> list7;
		return list7.get_Item(0);
		IL_0dff:
		list7 = trail;
		if (trail == null)
		{
			goto IL_10c2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
		Transform transform2 = (Transform)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		flag2 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		num14 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8C8]");
		object obj23 = 0;
		double num29 = num;
		double num30 = num3;
		NullReferenceException ex;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			list = (List<Vector3>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			bool flag20 = (nint)0 < (nint)2;
			object obj13 = !flag20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			double num10 = 0.0 - 2.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			object obj11 = (nint)0 ^ (nint)2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			object obj9 = 0 ^ num10;
			object obj7 = obj11 & obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			if ((nint)0 < (nint)2)
			{
				break;
			}
			flag3 = (byte)(int)transform2 != 0;
			Vector3 vector2 = list7.get_Item(0);
			Transform transform3 = base.transform;
			bool flag21 = (object)transform3 == null;
			num = num29;
			num3 = num30;
			transform = transform2;
			if (!flag21)
			{
				Vector3 position2 = transform3.position;
				object obj24 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v29+E4]");
				bool flag22 = (nint)0 == 0;
				object obj25 = !flag22;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool value = ((bool*)(flag2 ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X0_v32 (System.Boolean)+E4]");
				list = (List<Vector3>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X0_v32 (System.Boolean)+E4]");
				bool flag23 = (nint)0 == 0;
				object obj26 = !flag23;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double num31 = num30 - num30;
				double num32 = num6 - num6;
				double num33 = num31 * num31;
				num = num32 * num32;
				num3 = num33 + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				bool flag24 = num3 < num14;
				obj13 = !flag24;
				num10 = num3 - num14;
				obj11 = num3 ^ num14;
				obj9 = num3 ^ num10;
				obj7 = obj11 & obj9;
				flag9 = !(num3 < num14);
				ex = (NullReferenceException)(object)trail;
				transform = transform2;
				if (flag9)
				{
					goto IL_10d0;
				}
				bool flag25 = trail == null;
				transform = transform2;
				if (!flag25)
				{
					flag3 = (byte)(int)obj23 != 0;
					trail.RemoveAt(0);
					list7 = trail;
					bool flag26 = trail == null;
					object obj27 = !flag26;
					transform = transform2;
					num29 = num;
					num30 = num3;
					if (obj27 != null)
					{
						continue;
					}
				}
			}
			goto IL_10c2;
		}
		goto IL_10fd;
		IL_10c2:
		ex = new NullReferenceException();
		goto IL_10d0;
		IL_10d0:
		bool flag27 = ex == null;
		list7 = (List<Vector3>)(object)ex;
		transform2 = transform;
		if (flag27)
		{
			goto IL_10c2;
		}
		goto IL_10fd;
		IL_06e4:
		List<Vector3> list8 = trail;
		bool flag28 = trail == null;
		flag9 = flag8;
		num = num11;
		num3 = num12;
		num14 = num13;
		num16 = num15;
		flag3 = flag10;
		num5 = num6;
		num7 = num2;
		num8 = num4;
		transform = head;
		flag2 = flag11;
		obj = 109895680;
		if (!flag28)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v12 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			list = (List<Vector3>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v12 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			bool flag29 = (nint)0 < (nint)401;
			object obj13 = !flag29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v12 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			double num10 = 0.0 - 401.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v12 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			object obj11 = (nint)0 ^ (nint)0x191;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v12 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			object obj9 = 0 ^ num10;
			object obj7 = obj11 & obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v12 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			if ((nint)0 >= (nint)401)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8C8]");
				list = (List<Vector3>)0;
				flag10 = (byte)(int)list != 0;
				trail.RemoveAt(0);
			}
			Transform transform4 = base.transform;
			bool flag30 = (object)transform4 == null;
			num = num11;
			num3 = num12;
			num14 = num13;
			num16 = num15;
			flag3 = flag10;
			num5 = num6;
			num7 = num2;
			num8 = num4;
			transform = head;
			flag2 = flag11;
			obj = 109895680;
			if (!flag30)
			{
				Vector3 position3 = transform4.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj29 = 0;
				flag2 = (byte)(int)cc != 0;
				object obj30 = obj28;
				object obj31 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v15+A0]");
				list = (List<Vector3>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				num16 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				num14 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v17+E4]");
				bool flag31 = (nint)0 == 0;
				object obj32 = !flag31;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag32 = (UnityEngine.Object)flag2 != null;
				bool flag33 = !flag32;
				num = num11;
				num3 = 1.0;
				if (!flag33)
				{
					bool flag34 = (object)cc == null;
					num = num11;
					num3 = 1.0;
					flag3 = false;
					num5 = num6;
					num7 = num12;
					num8 = num11;
					transform = head;
					obj = 109895680;
					if (flag34)
					{
						goto IL_10c2;
					}
					float height = cc.height;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					num = 0.0;
					double num34 = height;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					num3 = num34 * 0.0;
				}
				list = trail;
				bool flag35 = trail == null;
				flag3 = false;
				num5 = num6;
				num7 = num12;
				num8 = num11;
				transform = head;
				obj = 109895680;
				if (!flag35)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					list = (List<Vector3>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					flag2 = (byte)(-1) != 0;
					bool flag36 = (flag2 ? 1 : 0) < (true ? 1 : 0);
					obj13 = !flag36;
					num10 = (double)(flag2 ? 1 : 0) - 1.0;
					obj11 = (flag2 ? 1 : 0) ^ 1;
					obj9 = flag2 ^ num10;
					obj7 = obj11 & obj9;
					flag9 = (flag2 ? 1 : 0) < (true ? 1 : 0);
					flag3 = false;
					num5 = num6;
					num7 = num12;
					num8 = num11;
					transform = head;
					obj = 109895680;
					if (flag9)
					{
						goto IL_0dff;
					}
					num26 = num16 * num3;
					num24 = num14 * num3;
					list = (List<Vector3>)(list - 2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+20]");
					num28 = 0.0 * num3;
					bool flag37 = (nint)list < 7;
					obj13 = !flag37;
					num10 = (double)list - 7.0;
					obj11 = list ^ 7;
					obj9 = list ^ num10;
					obj7 = obj11 & obj9;
					flag9 = (byte)(int)(~obj13) != 0;
					object obj33 = !flag9;
					if (obj33 != null)
					{
						list = (List<Vector3>)7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
					transform = (Transform)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
					obj = 0;
					obj23 = list + 1;
					num7 = num12 + num26;
					num8 = num11 + num24;
					num5 = num6 + num28;
					flag3 = false;
					while (true)
					{
						bool flag38 = trail == null;
						num = num26;
						num3 = num28;
						list3 = (List<Vector3>)7;
						if (flag38)
						{
							break;
						}
						flag3 = (byte)(int)transform != 0;
						Vector3 vector3 = trail.get_Item(flag2 ? 1 : 0);
						Vector3 a = (Vector3)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v44 (UnityEngine.Vector3)+E4]");
						list = (List<Vector3>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v44 (UnityEngine.Vector3)+E4]");
						bool flag39 = (nint)0 == 0;
						object obj34 = !flag39;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag40 = Clear(a, (Vector3)flag2);
						bool flag41 = !flag40;
						object obj35 = !flag41;
						if (obj35 == null)
						{
							obj23--;
							bool flag42 = (nint)obj23 < 1;
							obj13 = !flag42;
							num10 = (double)obj23 - 1.0;
							obj11 = obj23 ^ 1;
							obj9 = obj23 ^ num10;
							obj7 = obj11 & obj9;
							flag19 = (byte)((flag2 ? 1u : 0u) - 1u) != 0;
							flag9 = (nint)obj23 != 1;
							num23 = num24;
							num25 = num26;
							num27 = num28;
							num24 = num5;
							num26 = num8;
							num28 = num7;
							num14 = num8;
							num16 = num7;
							flag2 = flag19;
							if (flag9)
							{
								continue;
							}
							goto IL_0ce6;
						}
						goto IL_0d34;
					}
				}
			}
		}
		goto IL_10c2;
	}

	private unsafe Vector3 Steer(Vector3 goal)
	{
		//IL_09b4: Expected VT, but got I4
		//IL_0112: Expected VT, but got F4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_00f1: Expected VT, but got I4
		//IL_0994: Expected VT, but got Obj
		//IL_018e: Expected VT, but got Ref
		//IL_0474: Expected VT, but got I4
		//IL_01f2: Expected VT, but got Ref
		//IL_025e: Expected VT, but got Obj
		//IL_025e: Expected VT, but got I8
		//IL_0529: Expected Obj, but got I4
		//IL_0543: Expected Obj, but got I4
		//IL_0a1b: Expected Obj, but got I4
		//IL_057c: Expected Obj, but got I
		//IL_058c: Expected Obj, but got I
		//IL_0744: Expected Obj, but got I4
		//IL_0a7a: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I4
		//IL_0332: Expected Obj, but got I4
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0386: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I4
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_03f8: Expected Obj, but got I4
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected I4, but got Unknown
		//IL_0424: Expected I, but got Obj
		//IL_044c: Expected VT, but got Obj
		//IL_0795: Expected Obj, but got I
		//IL_07bf: Expected Obj, but got I4
		//IL_059f: Expected Obj, but got I4
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected Obj, but got Unknown
		//IL_0ac4: Expected Obj, but got I
		//IL_0acc: Expected VT, but got Obj
		//IL_0aee: Expected Obj, but got I4
		//IL_060a: Expected Obj, but got I4
		//IL_0835: Invalid comparison between F8 and I
		//IL_0965: Expected Obj, but got I4
		//IL_0a53: Expected Obj, but got I4
		//IL_085c: Expected Obj, but got I4
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected Obj, but got Unknown
		//IL_0731: Expected Obj, but got I4
		//IL_089a: Expected Obj, but got I4
		//IL_06d6: Expected Obj, but got I4
		//IL_06fe: Expected Obj, but got I4
		//IL_08b8: Expected Obj, but got I4
		//IL_08d3: Expected Obj, but got I4
		//IL_0915: Invalid comparison between F8 and I4
		bool ready = MonsterNavMesh.Ready;
		bool flag = !ready;
		Vector3 result = (Vector3)ready;
		if (flag)
		{
			goto IL_09c2;
		}
		float time = Time.time;
		bool flag2 = !(time < repathAt);
		object obj2 = default;
		object obj = obj2;
		float num2 = default;
		double num4 = default;
		float num9;
		object obj4;
		double num10;
		if (!flag2)
		{
			float num = num2 - (float)pathGoal;
			double num3 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+178]");
			double num5 = num3 - 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+17C]");
			obj = obj2 - 0;
			float num6 = num * num;
			double num7 = num5 * num5;
			float num8 = num6 + (float)num7;
			object obj3 = obj * obj;
			num9 = num8 + (float)obj3;
			bool flag3 = !((double)num9 > 4.0);
			obj4 = obj;
			num10 = 4.0;
			result = (Vector3)0;
			if (flag3)
			{
				goto IL_09c7;
			}
		}
		float time2 = Time.time;
		pathGoal = (Vector3)num2;
		num9 = (repathAt = time2 + 0.25f);
		Transform transform = base.transform;
		if ((object)transform == null)
		{
			goto IL_0978;
		}
		Vector3 position = transform.position;
		float num11 = default;
		bool flag4 = NavMesh.SamplePosition((Vector3)(&num11), out *(NavMeshHit*)4294967295L, num9, 0);
		bool flag5 = !flag4;
		int num12 = 0;
		double num13 = 1.5;
		num10 = 0.25;
		bool flag17;
		nint num16;
		if (!flag5)
		{
			double num14 = default;
			flag4 = NavMesh.SamplePosition((Vector3)(&num14), out *(NavMeshHit*)4294967295L, num2, 0);
			bool flag6 = !flag4;
			num12 = 0;
			num13 = 3.0;
			obj = obj2;
			num10 = num4;
			num9 = num2;
			if (!flag6)
			{
				NavMeshPath navMeshPath = default;
				flag4 = NavMesh.CalculatePath((Vector3)4294967295L, (Vector3)path, 0, navMeshPath);
				bool flag7 = !flag4;
				object obj6 = default;
				object obj5 = obj6;
				object obj8 = default;
				object obj7 = obj8;
				num12 = 0;
				num13 = num14;
				object obj9 = default;
				obj = obj9;
				double num15 = default;
				num10 = num15;
				num9 = num11;
				if (!flag7)
				{
					if (path != null)
					{
						Vector3[] corners = path.corners;
						if (corners != null)
						{
							object obj10 = corners.Length - 2;
							bool flag8 = (nint)obj10 < 0;
							object obj11 = corners.Length ^ 2;
							object obj12 = corners.Length ^ obj10;
							object obj13 = obj11 & obj12;
							bool flag9 = (nint)obj13 < 0;
							bool flag10 = flag8 == flag9;
							bool flag11 = !flag10;
							object obj14 = corners.Length - 1;
							bool flag12 = (nint)obj14 < 0;
							bool flag13 = obj14 == null;
							object obj15 = corners.Length ^ 1;
							object obj16 = corners.Length ^ obj14;
							object obj17 = obj15 & obj16;
							bool flag14 = (nint)obj17 < 0;
							bool flag15 = flag12 == flag14;
							object obj18 = !flag13;
							bool flag16 = (byte)((flag15 & obj18) ? 1 : 0) != 0;
							pathOk = flag16;
							obj5 = obj6;
							obj7 = obj8;
							num16 = unchecked((nint)null);
							num13 = num14;
							obj = obj9;
							num10 = num15;
							num9 = num11;
							result = (Vector3)corners;
							flag17 = flag11;
							goto IL_09e0;
						}
					}
					goto IL_0978;
				}
			}
		}
		pathOk = false;
		num16 = num12;
		result = (Vector3)flag4;
		flag17 = false;
		goto IL_09e0;
		IL_0978:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0986;
		IL_0948:
		Vector3[] corners2;
		bool flag18 = corner < corners2.Length;
		object obj19 = !flag18;
		if (obj19 != null)
		{
			goto IL_0986;
		}
		goto IL_09c2;
		IL_0a02:
		int num17;
		object obj20;
		bool flag19 = num17 < (nint)obj20;
		object obj21 = !flag19;
		double num19;
		if (obj21 == null)
		{
			object obj22 = num17 * 12;
			object obj23 = (object)corners2 + obj22;
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Vector3 position2 = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
				object obj24 = 0;
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v13+E4]");
				bool flag20 = (nint)0 == 0;
				object obj26 = !flag20;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v9+20]");
				double num18 = 0.0 - num19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v9+28]");
				object obj27 = 0 - obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj28 = 0;
				result = (Vector3)obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (UnityEngine.Vector3)+E4]");
				bool flag21 = (nint)0 == 0;
				object obj29 = !flag21;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double num20 = num18 * num18;
				object obj30 = obj27 * obj27;
				double num21 = num20 + (double)obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
				if (num21 < 0.0)
				{
					object obj31 = corners2.Length - 1;
					if (corner < (nint)obj31)
					{
						bool flag22 = corner < corners2.Length;
						object obj32 = !flag22;
						if (obj32 == null)
						{
							object obj33 = corner + 1;
							bool flag23 = (nint)obj33 < corners2.Length;
							object obj34 = !flag23;
							if (obj34 == null)
							{
								double num22 = num21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABC0]");
								double num23 = num22 / 0.0;
								double num24 = num23 + 1.0;
								if (!(num24 < 0.0) && num24 > 1.0)
								{
									goto IL_0948;
								}
								goto IL_09c2;
							}
						}
						goto IL_0986;
					}
				}
				goto IL_0948;
			}
			goto IL_0978;
		}
		goto IL_0986;
		IL_09e0:
		pathEnds = flag17;
		corner = 1;
		obj4 = obj;
		goto IL_09c7;
		IL_09c2:
		return result;
		IL_0986:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (Vector3)ex2;
		IL_09c7:
		if (~(pathEnds ? 1u : 0u) == 0)
		{
			Transform transform3 = base.transform;
			if ((object)transform3 == null)
			{
				goto IL_0978;
			}
			result = transform3.position;
		}
		else if (~(pathOk ? 1u : 0u) == 0)
		{
			if (path != null)
			{
				corners2 = path.corners;
				if (corners2 != null)
				{
					obj20 = corners2.Length;
					num17 = corner;
					object obj35 = corners2.Length - 1;
					bool flag24 = corner >= (nint)obj35;
					num19 = num9;
					if (!flag24)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj37 = 0;
						while (true)
						{
							bool flag25 = num17 < (nint)obj20;
							object obj38 = !flag25;
							if (obj38 != null)
							{
								break;
							}
							object obj39 = num17 * 12;
							object obj40 = (object)corners2 + obj39;
							Transform transform4 = base.transform;
							if ((object)transform4 == null)
							{
								goto IL_0978;
							}
							Vector3 position3 = transform4.position;
							object obj41 = obj36;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v27+E4]");
							bool flag26 = (nint)0 == 0;
							object obj42 = !flag26;
							if (obj42 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj43 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v30+E4]");
							bool flag27 = (nint)0 == 0;
							object obj44 = !flag27;
							if (obj44 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v24+20]");
							float num25 = 0f - num9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v24+28]");
							object obj45 = 0 - obj4;
							num17 = corner;
							float num26 = num25 * num25;
							num10 = (double)obj45 * (double)obj45;
							num19 = (double)num26 + num10;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							if (num19 < 0.5)
							{
								obj20 = corners2.Length;
								num17 = (corner = num17 + 1);
								object obj46 = corners2.Length - 1;
								bool flag28 = num17 < (nint)obj46;
								num9 = (float)num19;
								if (flag28)
								{
									continue;
								}
							}
							else
							{
								obj20 = corners2.Length;
							}
							goto IL_0a02;
						}
						goto IL_0986;
					}
					goto IL_0a02;
				}
			}
			goto IL_0978;
		}
		goto IL_09c2;
	}

	private unsafe bool StoodTooLong(float dt)
	{
		//IL_0967: Expected Obj, but got I8
		//IL_014f: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I4
		//IL_0174: Expected VT, but got F4
		//IL_005b: Expected Obj, but got I4
		//IL_0953: Expected I4, but got Obj
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_01f4: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I4
		//IL_0263: Expected Obj, but got I4
		//IL_0279: Expected I, but got Obj
		//IL_0289: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0355: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got Ref
		//IL_0424: Expected Obj, but got I8
		//IL_03bc: Expected I, but got Obj
		//IL_03cc: Expected Obj, but got I
		//IL_0402: Expected Obj, but got I
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_0486: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got Ref
		//IL_0532: Expected Obj, but got I4
		//IL_0542: Expected Obj, but got I4
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected Obj, but got Unknown
		//IL_04c2: Expected I, but got Obj
		//IL_04d2: Expected Obj, but got I
		//IL_0508: Expected Obj, but got I
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected Obj, but got Unknown
		//IL_05ba: Expected Obj, but got I
		//IL_05e0: Expected Obj, but got Ref
		//IL_065e: Expected Obj, but got I8
		//IL_05f6: Expected I, but got Obj
		//IL_0606: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected Obj, but got Unknown
		//IL_06c0: Expected Obj, but got I
		//IL_06ea: Expected Obj, but got I4
		//IL_0736: Expected Obj, but got I
		//IL_0746: Expected Obj, but got I
		//IL_0751: Expected Obj, but got I4
		//IL_077d: Expected Obj, but got I
		//IL_0792: Expected Obj, but got I
		//IL_07bc: Expected Obj, but got I4
		//IL_07f6: Expected Obj, but got I8
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected Obj, but got Unknown
		//IL_0879: Expected Obj, but got I4
		//IL_08a8: Expected Obj, but got I
		//IL_090c: Expected VT, but got I4
		object obj = (long)state__BackingField & 0xFFFFFFFEL;
		bool flag = (nint)obj == 4;
		float num = dt;
		object obj3;
		IndexOutOfRangeException ex = default;
		if (!flag)
		{
			bool flag2 = (byte)(~(lurking ? 1u : 0u)) != 0;
			object obj2 = !flag2;
			num = dt;
			if (obj2 == null)
			{
				Transform transform = base.transform;
				bool flag3 = (object)transform == null;
				num = dt;
				obj3 = 0;
				if (!flag3)
				{
					Vector3 position = transform.position;
					float num2 = dt - (float)stoodAt;
					double num4 = default;
					double num3 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+360]");
					double num5 = num3 - 0.0;
					object obj5 = default;
					object obj4 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+364]");
					obj5 = obj4 - 0;
					float num6 = num2 * num2;
					double num7 = num5 * num5;
					float num8 = num6 + (float)num7;
					object obj6 = obj5 * obj5;
					num = num8 + (float)obj6;
					bool flag4 = !((double)num > 1.0);
					num4 = 1.0;
					if (!flag4)
					{
						goto IL_012d;
					}
					if ((double)(stoodT += dt) < 30.0)
					{
						return false;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
					object obj7 = 0;
					stoodT = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					string text = name;
					object[] array = default;
					bool flag5 = array == null;
					num4 = 30.0;
					obj3 = 0;
					if (!flag5)
					{
						bool flag6 = text == null;
						object obj8 = 0;
						if (!flag6)
						{
							nint num9 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
							obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag7 = ex == null;
							num4 = 30.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
							obj3 = 0;
							if (flag7)
							{
								goto IL_0936;
							}
						}
						bool flag8 = array.Length == 0;
						num4 = 30.0;
						obj3 = obj8;
						if (!flag8)
						{
							object obj9 = array + 32;
							obj9 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Transform transform2 = base.transform;
							bool flag9 = (object)transform2 == null;
							num4 = 30.0;
							obj3 = 0;
							if (flag9)
							{
								goto IL_091a;
							}
							Vector3 position2 = transform2.position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj11 = default;
							bool flag10 = obj11 == null;
							object obj13 = default;
							object obj12 = (object)(&obj13);
							if (!flag10)
							{
								nint num10 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
								obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag11 = ex == null;
								num4 = 30.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
								obj3 = 0;
								if (flag11)
								{
									goto IL_0936;
								}
							}
							object obj14 = array.Length & 0xFFFFFFFEL;
							bool flag12 = obj14 == null;
							num4 = 30.0;
							obj3 = obj12;
							if (!flag12)
							{
								object obj15 = array + 40;
								obj15 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj17 = default;
								bool flag13 = obj17 == null;
								object obj19 = default;
								object obj18 = (object)(&obj19);
								if (!flag13)
								{
									nint num11 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
									obj18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag14 = ex == null;
									num4 = 30.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
									obj3 = 0;
									if (flag14)
									{
										goto IL_0936;
									}
								}
								bool flag15 = array.Length < 2;
								object obj20 = !flag15;
								object obj21 = array.Length - 2;
								bool flag16 = obj21 == null;
								object obj22 = ~obj20;
								object obj23 = obj22 | flag16;
								num4 = 30.0;
								obj3 = obj18;
								if (obj23 == null)
								{
									object obj24 = array + 48;
									obj24 = obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAC0]");
									object obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj26 = default;
									bool flag17 = obj26 == null;
									object obj28 = default;
									object obj27 = (object)(&obj28);
									if (!flag17)
									{
										nint num12 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v41 (Il2CppClass<System.Object[]>)+40]");
										obj27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag18 = ex == null;
										num4 = 30.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v41 (Il2CppClass<System.Object[]>)+40]");
										obj3 = 0;
										if (flag18)
										{
											goto IL_0936;
										}
									}
									object obj29 = array.Length & 0xFFFFFFFCL;
									bool flag19 = obj29 == null;
									num4 = 30.0;
									obj3 = obj27;
									if (!flag19)
									{
										object obj30 = array + 56;
										obj30 = obj26;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
										object obj31 = 0;
										object obj32 = obj31;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v47+E4]");
										bool flag20 = (nint)0 == 0;
										object obj33 = !flag20;
										if (obj33 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag21 = climb != null;
										bool flag22 = !flag21;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAD0]");
										object obj34 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAC8]");
										object format = 0;
										object obj35 = !flag22;
										object obj36 = ~obj35;
										if (obj36 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
											obj34 = 0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
										string message = string.Format((string)format, array);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
										object obj37 = 0;
										object obj38 = obj37;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v35+E4]");
										bool flag23 = (nint)0 == 0;
										object obj39 = !flag23;
										if (obj39 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Debug.LogWarning(message);
										object obj40 = (long)state__BackingField & 0xFFFFFFFEL;
										if ((nint)obj40 == 6)
										{
											EndPry();
										}
										object obj41 = this + 584;
										climb = null;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										List<Vector3> list = trail;
										ClimbPitch__BackingField = 0f;
										bool flag24 = trail == null;
										num4 = 30.0;
										obj3 = 0;
										if (!flag24)
										{
											state__BackingField = (State)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v38 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
											object obj42 = (nint)0 + (nint)1;
											Chasing__BackingField = false;
											_ = 0;
											stateT = 0f;
											reachedFor = 0f;
											listening = false;
											hasPrey = false;
											wait = 0f;
											ignoreT = walkAwaySeconds;
											PickWander((Vector3?)(object)0);
											return true;
										}
										goto IL_091a;
									}
								}
							}
						}
						goto IL_0928;
					}
				}
				goto IL_091a;
			}
		}
		goto IL_012d;
		IL_012d:
		Transform transform3 = base.transform;
		bool flag25 = (object)transform3 == null;
		obj3 = 0;
		if (!flag25)
		{
			Vector3 position3 = transform3.position;
			stoodAt = (Vector3)num;
			stoodT = 0f;
			return false;
		}
		goto IL_091a;
		IL_091a:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0928;
		IL_0936:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex3 = new ArgumentNullException();
		return (byte)(int)ex3 != 0;
		IL_0928:
		ex = new IndexOutOfRangeException();
		goto IL_0936;
	}

	private bool Reachable(Transform head)
	{
		float length;
		return Way(head, out length);
	}

	private unsafe bool Way(Transform head, out float length)
	{
		//IL_0731: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0044: Expected F4, but got I4
		//IL_0063: Invalid comparison between F4 and VT
		//IL_0760: Expected Obj, but got I
		//IL_0778: Expected Obj, but got I
		//IL_0788: Expected Obj, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected I4, but got Unknown
		//IL_0810: Expected Obj, but got I
		//IL_0832: Expected Obj, but got I4
		//IL_09cb: Expected VT, but got I8
		//IL_09cb: Expected VT, but got Ref
		//IL_09e9: Expected Obj, but got I4
		//IL_0858: Expected Obj, but got I4
		//IL_087a: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_08f1: Expected Obj, but got I
		//IL_091b: Expected Obj, but got I4
		//IL_01cf: Expected Ref, but got F4
		//IL_0210: Expected VT, but got Ref
		//IL_03ce: Invalid comparison between F8 and I4
		//IL_024b: Invalid comparison between F4 and I
		//IL_02b1: Expected VT, but got Ref
		//IL_04b1: Expected VT, but got I4
		//IL_02f1: Expected VT, but got Obj
		//IL_02f1: Expected VT, but got I8
		//IL_04d1: Expected Obj, but got I4
		//IL_04f5: Expected Obj, but got I4
		//IL_05fc: Expected Obj, but got I8
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_0613: Expected Obj, but got I4
		//IL_055e: Expected Obj, but got I4
		//IL_0999: Expected Obj, but got I4
		//IL_0972: Expected Obj, but got I4
		//IL_0659: Expected Obj, but got I
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected Obj, but got Unknown
		//IL_06e9: Expected Obj, but got I4
		bool flag3;
		if ((object)ways != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB20]");
			object obj = 0;
			bool flag = ((Dictionary<System.__Canon, (float, bool, float)>)(object)ways).TryGetValue((System.__Canon)(object)head, out (float, bool, float) value);
			bool flag2 = !flag;
			float num = 0f;
			if (!flag2)
			{
				num = Time.time;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) < System.Runtime.CompilerServices.Unsafe.As<(float, bool, float), UIntPtr>(ref value))
				{
					ref float reference = ref *(float*)null;
					object obj2 = default;
					flag3 = (byte)(obj2 & 1) != 0;
					goto IL_04b6;
				}
			}
			if ((object)head != null)
			{
				Vector3 position = head.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v10+A0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v11+24]");
				double num2 = 0.0 * 1.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v11+28]");
				double num3 = 0.0 * 1.5;
				Vector3 position2 = head.position;
				object obj7 = obj3;
				float num4 = num + (float)num2;
				object obj8 = obj6;
				double num5 = (double)value + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X8_v14+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v17+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				float maxDistance = 1.5f;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					maxDistance = 1.5f;
				}
				float num6 = default;
				QueryTriggerInteraction queryTriggerInteraction = default;
				bool flag5 = Physics.Raycast((Vector3)(&num6), (Vector3)4294965499L, out *(RaycastHit*)1, maxDistance, 0, queryTriggerInteraction);
				bool flag6 = !flag5;
				object obj11 = !flag6;
				object obj12 = ~obj11;
				float maxDistance2 = ((obj12 != null) ? num4 : num6);
				object obj13 = !flag6;
				object obj14 = ~obj13;
				double num8 = default;
				double num7 = ((obj14 != null) ? num5 : num8);
				object obj15 = !flag6;
				object obj16 = ~obj15;
				if (obj16 == null)
				{
				}
				Vector3 position3 = head.position;
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
					object obj17 = 0;
					Vector3 position4 = transform.position;
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v26+E4]");
					bool flag7 = (nint)0 == 0;
					object obj19 = !flag7;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num9 = num6 - num6;
					object obj21 = default;
					object obj20 = obj21 - obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj22 = 0;
					object obj23 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v29+E4]");
					bool flag8 = (nint)0 == 0;
					object obj24 = !flag8;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num10 = num9 * num9;
					object obj25 = obj20 * obj20;
					float num11 = num10 + (float)obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					ref float reference = ref *(float*)num11;
					if (MonsterNavMesh.Ready)
					{
						object obj26 = default;
						if (NavMesh.SamplePosition((Vector3)(&obj26), out *(NavMeshHit*)4294967295L, maxDistance2, 0))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
							float num12 = default;
							if (num12 < 0f)
							{
								Transform transform2 = base.transform;
								if ((object)transform2 != null)
								{
									Vector3 position5 = transform2.position;
									object obj27 = default;
									if (!NavMesh.SamplePosition((Vector3)(&obj27), out *(NavMeshHit*)4294967295L, num12, 0) || !NavMesh.CalculatePath((Vector3)4294967295L, (Vector3)scratch, 0, null))
									{
										goto IL_035d;
									}
									if (scratch != null)
									{
										if (scratch.status != 0)
										{
											goto IL_035d;
										}
										bool flag9 = (byte)(~(pries ? 1u : 0u)) != 0;
										object obj28 = !flag9;
										if (obj28 == null)
										{
											bool flag10 = (byte)(~(breaksDoors ? 1u : 0u)) != 0;
											object obj29 = !flag10;
											if (obj29 == null)
											{
												if (scratch == null)
												{
													goto IL_0715;
												}
												Vector3[] corners = scratch.corners;
												bool flag11 = ShutDoorOn(corners);
												bool flag12 = !flag11;
												object obj30 = !flag12;
												if (obj30 != null)
												{
													goto IL_035d;
												}
											}
										}
										reference = ref *(float*)null;
										if (scratch != null)
										{
											Vector3[] corners2 = scratch.corners;
											if (corners2 != null)
											{
												bool flag13 = corners2.Length < 2;
												flag3 = true;
												if (!flag13)
												{
													object obj31 = corners2.Length & 0xFFFFFFFFL;
													object obj32 = corners2 + 52;
													object obj33 = 1;
													object obj35 = default;
													object obj34 = obj35;
													object obj36 = obj27;
													while (true)
													{
														bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31);
														object obj37 = !flag14;
														if (obj37 != null)
														{
															break;
														}
														object obj38 = obj22;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v61+E4]");
														bool flag15 = (nint)0 == 0;
														object obj39 = !flag15;
														if (obj39 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X27_v7-8]");
														nint num13 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X27_v7-14]");
														object obj40 = num13 - 0;
														object obj41 = obj32;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X27_v7-C]");
														object obj42 = obj41 - 0;
														obj33++;
														obj32 += 12;
														object obj43 = obj40 * obj40;
														obj34 = obj42 * obj42;
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
														object obj44 = obj43 + obj34;
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
														obj36 = length + obj44;
														reference = ref *(float*)obj36;
														obj31 = corners2.Length;
														if ((nint)obj33 < corners2.Length)
														{
															continue;
														}
														goto IL_0707;
													}
													goto IL_0723;
												}
												goto IL_0929;
											}
										}
									}
								}
								goto IL_0715;
							}
						}
						goto IL_035d;
					}
					Transform transform3 = base.transform;
					if ((object)transform3 != null)
					{
						Vector3 position6 = transform3.position;
						double num14 = num7 - (double)obj25;
						double num15 = num14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
						double num16 = num15 - 0.0;
						bool flag16 = num16 < 0.0;
						flag3 = flag16;
						goto IL_0929;
					}
				}
			}
		}
		goto IL_0715;
		IL_0707:
		flag3 = true;
		goto IL_0929;
		IL_035d:
		flag3 = false;
		goto IL_0929;
		IL_0929:
		if ((object)ways != null)
		{
			int count = ((Dictionary<System.__Canon, (float, bool, float)>)(object)ways).Count;
			if (count >= 33)
			{
				if ((object)ways == null)
				{
					goto IL_0715;
				}
				((Dictionary<System.__Canon, (float, bool, float)>)(object)ways).Clear();
			}
			float time = Time.time;
			float num17 = time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float item = num17 + 0f;
			(float, bool, float) tuple = (item, flag3, length);
			if ((object)ways != null)
			{
				((Dictionary<System.__Canon, (float, bool, float)>)(object)ways).set_Item((System.__Canon)(object)head, ((float, bool, float))0);
				goto IL_04b6;
			}
		}
		goto IL_0715;
		IL_04b6:
		return flag3;
		IL_0715:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0723;
		IL_0723:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private void WalkAway(Vector3 you)
	{
		//IL_0026: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0065: Expected VT, but got Obj
		//IL_0070: Expected VT, but got I4
		List<Vector3> list = trail;
		state__BackingField = (State)0;
		Chasing__BackingField = false;
		stateT = 0f;
		reachedFor = 0f;
		listening = false;
		hasPrey = false;
		unreachT = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
		object obj = (nint)0 + (nint)1;
		ignoreT = walkAwaySeconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
		object obj2 = 0;
		_ = 0;
		wait = 0f;
		Vector3? vector = (Vector3)obj2;
		PickWander((Vector3?)(object)0);
	}

	private bool CanSee(Transform head)
	{
		//IL_0010: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I4
		//IL_01f1: Expected I4, but got Obj
		//IL_0256: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_02ec: Expected Obj, but got I
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got I4
		//IL_014b: Invalid comparison between Obj and F4
		//IL_0185: Expected Obj, but got I
		//IL_018d: Expected VT, but got Obj
		//IL_01af: Expected Obj, but got I4
		//IL_01da: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4;
		object obj5 = default;
		object obj6;
		object obj7 = default;
		object obj8;
		object obj9 = default;
		if (face != null)
		{
			if ((object)face == null)
			{
				goto IL_01e3;
			}
			Vector3 position = face.position;
			obj4 = obj5;
			obj6 = obj7;
			obj8 = obj9;
		}
		else
		{
			Transform transform = base.transform;
			if ((object)transform == null)
			{
				goto IL_01e3;
			}
			Vector3 position2 = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v19+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v20+20]");
			obj4 = obj5 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v20+18]");
			obj8 = obj9 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v20+1C]");
			obj6 = obj7 + 0;
		}
		if ((object)head != null)
		{
			Vector3 position3 = head.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v20+18]");
			object obj13 = 0 - obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v20+1C]");
			object obj14 = 0 - obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v20+20]");
			object obj16 = 0 - obj4;
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj18 = !flag2;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj19 = obj13 * obj13;
			object obj20 = obj14 * obj14;
			object obj21 = obj19 + obj20;
			object obj22 = obj16 * obj16;
			object obj23 = obj22 + obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)sightRange))
			{
				return false;
			}
			Vector3 position4 = head.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj24 = 0;
			Vector3 a = (Vector3)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v15 (UnityEngine.Vector3)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj25 = !flag3;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Clear(a, (Vector3)0);
		}
		goto IL_01e3;
		IL_01e3:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static bool Clear(Vector3 a, Vector3 b)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I4
		//IL_0040: Expected VT, but got I4
		//IL_0040: Expected VT, but got I8
		//IL_0099: Expected Obj, but got I4
		//IL_00d2: Expected VT, but got I4
		//IL_00d2: Expected VT, but got I8
		//IL_00e4: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected I4, but got Unknown
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
		object obj4;
		if (Physics.Linecast((Vector3)4294965499L, (Vector3)1, 0, queryTriggerInteraction))
		{
			obj4 = 0;
		}
		else
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = Physics.Linecast((Vector3)4294965499L, (Vector3)1, 0, queryTriggerInteraction);
			obj4 = (flag3 ? 1 : 0) ^ 1;
		}
		return (byte)(obj4 & 1) != 0;
	}

	private bool InReach(Transform head)
	{
		//IL_00e3: Expected I4, but got Obj
		//IL_007b: Expected Obj, but got F4
		//IL_00b4: Invalid comparison between F4 and I4
		if ((object)head != null)
		{
			Vector3 position = head.position;
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position2 = transform.position;
				object obj2 = default;
				object obj = obj2 - obj2;
				object obj3 = 0f - reachBelow;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					float num = (float)obj - reachAbove;
					return num < 0f;
				}
				return false;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool Grabbable(Transform head)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I
		//IL_02ae: Expected I4, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I4
		//IL_0394: Expected Obj, but got I4
		//IL_028d: Invalid comparison between F4 and I4
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
		bool flag2 = grabSocket != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj4 = 0;
		float num2 = default;
		object obj7 = default;
		if (flag2)
		{
			if ((object)head != null)
			{
				Vector3 position = head.position;
				if ((object)grabSocket != null)
				{
					Vector3 position2 = grabSocket.position;
					object obj5 = obj4;
					float num = num2 - num2;
					float num4 = default;
					float num3 = num4 - num4;
					object obj6 = obj7 - obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v31+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num5 = num * num;
					float num6 = num3 * num3;
					float num7 = num5 + num6;
					object obj9 = obj6 * obj6;
					num2 = (float)obj9 + num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					if (num2 < grabRange)
					{
						return true;
					}
					goto IL_016c;
				}
			}
		}
		else if ((object)head != null)
		{
			goto IL_016c;
		}
		goto IL_02a0;
		IL_02a0:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_016c:
		Vector3 position3 = head.position;
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj10 = 0;
			Vector3 position4 = transform.position;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj4;
			float num8 = num2 - num2;
			object obj14 = obj7 - obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num9 = num8 * num8;
			object obj16 = obj14 * obj14;
			float num10 = num9 + (float)obj16;
			float num11 = grabRange;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			float num12 = num11 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			float num13 = num10 - num12;
			return num13 < 0f;
		}
		goto IL_02a0;
	}

	private bool WaitsForClaim(MonsterCatalog.Target t)
	{
		//IL_0166: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_0147: Expected I4, but got Obj
		bool flag = !t.local;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)t.dummy == (UnityEngine.Object)null)
			{
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)net != (UnityEngine.Object)null)
				{
					if ((object)net != null)
					{
						return net.Live;
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
			}
		}
		return false;
	}

	public bool HasYouHere()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0380: Expected Obj, but got I
		//IL_03aa: Expected Obj, but got I4
		//IL_03c8: Expected Obj, but got I
		//IL_03ea: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_0360: Expected I4, but got Obj
		//IL_0108: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got I
		//IL_02a5: Expected VT, but got I4
		//IL_02a5: Expected VT, but got I4
		//IL_02dd: Expected Obj, but got I
		//IL_0310: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+9]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = (UnityEngine.Object)obj5 == null;
			bool flag5 = !flag4;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				if (obj5 == null)
				{
					goto IL_0352;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+A9]");
				bool flag6 = (nint)0 == 0;
				object obj14 = !flag6;
				if (obj14 == null)
				{
					object obj15 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v12+E4]");
					bool flag7 = (nint)0 == 0;
					object obj16 = !flag7;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
					bool flag8 = (UnityEngine.Object)0 == null;
					bool flag9 = !flag8;
					object obj17 = !flag9;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
						object obj18 = 0;
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v16+E4]");
						bool flag10 = (nint)0 == 0;
						object obj20 = !flag10;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool isMonster = MonsterPlayer.IsMonster;
						bool flag11 = !isMonster;
						object obj21 = !flag11;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
								Vector3 position = ((Transform)0).position;
								Transform transform = base.transform;
								if ((object)transform != null)
								{
									Vector3 position2 = transform.position;
									if (GillaBackroomsSwitch.SameSide((Vector3)0, (Vector3)0))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
										if (InReach((Transform)0))
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
											if (Grabbable((Transform)0))
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v2 (UnityEngine.Object)+20]");
												return CanSee((Transform)0);
											}
										}
									}
									goto IL_034c;
								}
							}
							goto IL_0352;
						}
					}
				}
			}
		}
		goto IL_034c;
		IL_034c:
		return false;
		IL_0352:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe void Claimed(PlayerRef who)
	{
		//IL_0364: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I4
		//IL_016c: Invalid comparison between I and VT
		//IL_01ad: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got VT
		//IL_01f4: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got VT
		//IL_023d: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I4
		//IL_029b: Invalid comparison between Obj and F8
		//IL_02d9: Expected Obj, but got I4
		//IL_02ff: Expected VT, but got Ref
		//IL_030d: Expected VT, but got Ref
		bool flag = (byte)(~(Puppet__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null || state__BackingField != (State)2 || ~(hasPrey ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+1C8]");
		bool flag3 = (UnityEngine.Object)0 != null;
		bool flag4 = !flag3;
		object obj5 = !flag4;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+1BC]");
		bool flag5 = (nint)0 == 0;
		object obj6 = !flag5;
		if (obj6 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+1B8]");
		if ((object)0 != (object)who)
		{
			return;
		}
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj11 = !flag7;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = (UnityEngine.Object)prey == null;
		bool flag9 = !flag8;
		object obj12 = !flag9;
		if (obj12 != null)
		{
			return;
		}
		Vector3 position = ((Transform)prey).position;
		Transform transform = base.transform;
		Vector3 position2 = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v20+E4]");
		bool flag10 = (nint)0 == 0;
		object obj15 = !flag10;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
		object obj16 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)4.0))
		{
			object obj17 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v24+E4]");
			bool flag11 = (nint)0 == 0;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj19 = default;
			(int, int) key = Key((MonsterCatalog.Target)(&obj19));
			object obj20 = default;
			StartKill((MonsterCatalog.Target)(&obj20));
			if (state__BackingField == (State)4)
			{
				bool flag12 = marked.Remove(key);
			}
		}
	}

	private void PickWander()
	{
		//IL_000b: Expected VT, but got I4
		PickWander((Vector3?)(object)0);
	}

	private unsafe void PickWander(Vector3? from)
	{
		//IL_001e: Expected VT, but got I4
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected Obj, but got Unknown
		//IL_0727: Expected Obj, but got VT
		//IL_0096: Expected VT, but got Ref
		//IL_00cc: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00fd: Expected F4, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_0193: Expected VT, but got Ref
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected Obj, but got Unknown
		//IL_01c2: Invalid comparison between VT and I4
		//IL_0417: Expected VT, but got Obj
		//IL_0417: Expected VT, but got I8
		//IL_0236: Expected Obj, but got I4
		//IL_04b1: Expected Obj, but got I4
		//IL_06b0: Expected Obj, but got I4
		//IL_0525: Expected Obj, but got I4
		//IL_0672: Expected VT, but got Obj
		//IL_054f: Expected Obj, but got I4
		//IL_06e9: Expected Obj, but got I4
		//IL_039e: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I4
		Transform transform = base.transform;
		Vector3 position = transform.position;
		stuckAt = (Vector3)0;
		stuckT = 0f;
		float num3 = default;
		Vector3 vector4;
		float num28;
		if (MonsterNavMesh.Ready)
		{
			Transform transform2 = base.transform;
			Vector3 position2 = transform2.position;
			float num = default;
			if (NavMesh.SamplePosition((Vector3)(&num), out *(NavMeshHit*)4294967295L, 0f, 0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C08]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj3 = 0;
				float num2 = num3;
				float num4 = 0f;
				object obj4 = 12;
				object obj5 = 0;
				Vector3? vector = from;
				double num7 = default;
				object obj6 = default;
				double num9 = default;
				float num11 = default;
				float num13 = default;
				object obj8 = default;
				Vector3? vector2 = default;
				Vector3? vector3 = default;
				float num17 = default;
				NavMeshPath navMeshPath = default;
				object obj17 = default;
				double num26 = default;
				float num27 = default;
				while (true)
				{
					Vector2 insideUnitCircle = UnityEngine.Random.insideUnitCircle;
					Transform transform3 = base.transform;
					float num5 = num2 * wanderRadius;
					float num6 = num4 * wanderRadius;
					Vector3 position3 = transform3.position;
					num4 = num6 + num4;
					num3 = num2 + (float)obj5;
					num7 = (double)num5 + num7;
					if (NavMesh.SamplePosition((Vector3)(&obj6), out *(NavMeshHit*)4294967295L, num4, 0))
					{
						bool flag = (Vector3)vector == (Vector3)(object)0;
						double num8 = num9;
						float num10 = num11;
						float num12 = num13;
						object obj7 = obj8;
						object obj9 = obj5;
						if (!flag)
						{
							Vector3 value = vector2.Value;
							object obj10 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v39+E4]");
							bool flag2 = (nint)0 == 0;
							object obj11 = !flag2;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj12 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v42+E4]");
							bool flag3 = (nint)0 == 0;
							object obj13 = !flag3;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Transform transform4 = base.transform;
							Vector3 position4 = transform4.position;
							Vector3 value2 = vector3.Value;
							object obj14 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v50+E4]");
							bool flag4 = (nint)0 == 0;
							object obj15 = !flag4;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num14 = num4 - num4;
							double num15 = num7 - num7;
							double num16 = (double)num17 - num7;
							float num18 = num14 * num14;
							double num19 = num15 * num15;
							double num20 = num16 * num16;
							float num21 = num18 + (float)num19;
							float num22 = (float)obj6 - num4;
							float num23 = num22 * num22;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							num3 = num23 + (float)num20;
							float num24 = num21 + 6f;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							bool flag5 = num3 < num24;
							num8 = num7;
							num10 = num4;
							num12 = num17;
							obj7 = obj6;
							obj9 = 0;
							vector = vector3;
							num9 = num7;
							num11 = num4;
							num13 = num17;
							obj8 = obj6;
							num7 = 6.0;
							num4 = num24;
							obj5 = 0;
							vector = vector3;
							if (flag5)
							{
								goto IL_05ec;
							}
						}
						bool flag6 = NavMesh.CalculatePath((Vector3)4294967295L, (Vector3)scratch, 0, navMeshPath);
						bool flag7 = !flag6;
						float num25 = num17;
						object obj16 = obj17;
						num9 = num8;
						num11 = num10;
						num13 = num12;
						obj8 = obj7;
						num7 = num26;
						num3 = num27;
						num4 = num;
						obj5 = obj9;
						if (!flag7)
						{
							NavMeshPathStatus status = scratch.status;
							bool flag8 = status == 0;
							object obj18 = !flag8;
							num25 = num17;
							obj16 = obj17;
							num9 = num8;
							num11 = num10;
							num13 = num12;
							obj8 = obj7;
							num7 = num26;
							num3 = num27;
							num4 = num;
							obj5 = obj9;
							if (obj18 == null)
							{
								bool flag9 = (byte)(~(pries ? 1u : 0u)) != 0;
								object obj19 = !flag9;
								if (obj19 != null)
								{
									break;
								}
								bool flag10 = !breaksDoors;
								object obj20 = !flag10;
								if (obj20 != null)
								{
									break;
								}
								Vector3[] corners = scratch.corners;
								bool flag11 = ShutDoorOn(corners);
								bool flag12 = !flag11;
								num25 = num17;
								obj16 = obj17;
								num9 = num8;
								num11 = num10;
								num13 = num12;
								obj8 = obj7;
								num7 = num26;
								num3 = num27;
								num4 = num;
								obj5 = obj9;
								if (flag12)
								{
									break;
								}
							}
						}
					}
					goto IL_05ec;
					IL_05ec:
					obj4--;
					bool flag13 = (nint)obj4 != 1;
					num2 = num3;
					if (flag13)
					{
						continue;
					}
					goto IL_0622;
				}
				num28 = num17;
				vector4 = (Vector3)obj6;
				goto IL_070f;
			}
		}
		goto IL_0622;
		IL_0622:
		Vector2 insideUnitCircle2 = UnityEngine.Random.insideUnitCircle;
		float num29 = num3 * wanderRadius;
		vector4 = home;
		float num30 = num29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+158]");
		num28 = num30 + 0f;
		goto IL_070f;
		IL_070f:
		object obj21 = this + 348;
		obj21 = vector4;
	}

	private unsafe GillaDoor DoorInWay(Vector3 goal, float ahead)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0fa8: Expected Obj, but got I4
		//IL_0fe0: Expected Obj, but got I4
		//IL_1490: Expected Obj, but got I
		//IL_14a0: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_00f3: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0169: Expected VT, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_0247: Expected VT, but got I4
		//IL_01d7: Expected VT, but got I4
		//IL_1051: Invalid comparison between F4 and I4
		//IL_0208: Expected VT, but got I4
		//IL_0261: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I
		//IL_0291: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I4
		//IL_02b3: Expected Obj, but got I4
		//IL_02c9: Expected Obj, but got I4
		//IL_0231: Expected VT, but got I4
		//IL_03d5: Expected Obj, but got I4
		//IL_0427: Expected F4, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_0323: Invalid comparison between F4 and I4
		//IL_0332: Invalid comparison between F4 and I4
		//IL_045f: Expected Obj, but got I4
		//IL_1078: Expected Obj, but got I
		//IL_10a2: Expected Obj, but got I4
		//IL_04ba: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I4
		//IL_0396: Expected F4, but got I
		//IL_03a6: Expected F4, but got I
		//IL_03b6: Expected Obj, but got I
		//IL_10da: Expected Obj, but got I4
		//IL_14f5: Expected Obj, but got I
		//IL_1505: Expected Obj, but got I
		//IL_050b: Expected Obj, but got I
		//IL_051b: Expected Obj, but got I
		//IL_060a: Expected I, but got Obj
		//IL_1184: Expected VT, but got I
		//IL_0556: Expected Obj, but got I
		//IL_0c09: Expected Obj, but got Ref
		//IL_110a: Expected Obj, but got I4
		//IL_112a: Invalid comparison between F4 and I4
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_1361: Expected Obj, but got I
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_058b: Expected Obj, but got I4
		//IL_05a4: Invalid comparison between F4 and I4
		//IL_05b3: Invalid comparison between F4 and I4
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		//IL_074e: Expected I, but got Obj
		//IL_1262: Expected VT, but got I
		//IL_1275: Unknown result type (might be due to invalid IL or missing references)
		//IL_127a: Expected Obj, but got Unknown
		//IL_069a: Expected Obj, but got I
		//IL_0c1f: Expected Obj, but got I4
		//IL_1204: Expected Obj, but got I4
		//IL_1224: Invalid comparison between F4 and I4
		//IL_1433: Expected Obj, but got Ref
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_138e: Expected Obj, but got Ref
		//IL_0e83: Expected Obj, but got Ref
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected Obj, but got Unknown
		//IL_06cf: Expected Obj, but got I4
		//IL_06e8: Invalid comparison between F4 and I4
		//IL_06f7: Invalid comparison between F4 and I4
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_0c3c: Expected Obj, but got I
		//IL_0c4c: Expected Obj, but got I
		//IL_07b8: Expected Obj, but got I
		//IL_0cd7: Expected I, but got Obj
		//IL_08a7: Expected I, but got Obj
		//IL_13ff: Expected VT, but got I
		//IL_0c87: Expected Obj, but got I
		//IL_133b: Expected Obj, but got I4
		//IL_07f3: Expected Obj, but got I
		//IL_0911: Expected VT, but got I4
		//IL_12b9: Expected Obj, but got I4
		//IL_12d9: Invalid comparison between F4 and I4
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Expected Obj, but got Unknown
		//IL_0ba8: Expected Obj, but got I4
		//IL_0bdd: Expected I, but got Obj
		//IL_0bea: Expected I, but got Obj
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected Obj, but got Unknown
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected Obj, but got Unknown
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Expected Obj, but got Unknown
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Expected Obj, but got Unknown
		//IL_0828: Expected Obj, but got I4
		//IL_0841: Invalid comparison between F4 and I4
		//IL_0850: Invalid comparison between F4 and I4
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected Obj, but got Unknown
		//IL_0ed9: Expected Obj, but got Ref
		//IL_0f0e: Expected I, but got Obj
		//IL_0f17: Expected VT, but got I4
		//IL_095e: Expected Obj, but got I4
		//IL_0967: Expected VT, but got I4
		//IL_0997: Expected Obj, but got I4
		//IL_09a0: Expected VT, but got I4
		//IL_09d4: Expected Obj, but got I4
		//IL_09ec: Invalid comparison between F4 and I4
		//IL_09fb: Invalid comparison between F4 and I4
		//IL_0a27: Expected VT, but got I4
		//IL_0a5f: Expected Obj, but got I4
		//IL_0a92: Expected VT, but got I4
		//IL_0a92: Expected VT, but got Ref
		//IL_0add: Expected VT, but got Ref
		//IL_0b20: Expected Obj, but got I4
		//IL_0b46: Invalid comparison between F4 and I4
		//IL_0b80: Expected VT, but got Ref
		//IL_0e30: Expected Obj, but got I4
		//IL_0e65: Expected I, but got Obj
		//IL_0e6d: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v7+40]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v7+40]");
		bool flag3 = (nint)0 == 0;
		float num2 = default;
		float num = num2;
		object obj9 = default;
		object obj8 = obj9;
		float num4 = default;
		float num3 = num4;
		float num5 = ahead;
		if (flag3)
		{
			goto IL_0f3b;
		}
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB08]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v13+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v13+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v13+98]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X10_v47-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj12--;
			obj13 += 16;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_00e4;
		}
		object obj14 = obj10 + obj13;
		object obj15 = obj14 + 312;
		goto IL_1013;
		IL_05fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		nint num6 = unchecked((nint)null);
		goto IL_1158;
		IL_0435:
		object obj17;
		object obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X0_v33+E4]");
		bool flag4 = (nint)0 == 0;
		object obj18 = !flag4;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj19 = 0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v36+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+E4]");
		bool flag6 = (nint)0 == 0;
		object obj23 = !flag6;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v42+E4]");
		bool flag7 = (nint)0 == 0;
		object obj25 = !flag7;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v42+A0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v32+40]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v32+40]");
		if ((nint)0 == 0)
		{
			goto IL_0f3b;
		}
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X8_v33+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAF8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X8_v33+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05fb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X8_v33+98]");
		object obj31 = (nint)0 + (nint)8;
		bool flag9;
		bool flag8 = flag9;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X10_v42-8]");
			bool flag10 = 0 < (nint)obj30;
			object obj32 = !flag10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X10_v42-8]");
			float num7 = 0f - (float)obj30;
			bool flag11 = num7 < 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X10_v42-8]");
			if (0 == (nint)obj30)
			{
				break;
			}
			obj29--;
			bool flag12 = (nint)obj29 < 1;
			obj32 = !flag12;
			num7 = (float)obj29 - 1f;
			flag11 = num7 < 0f;
			bool flag13 = num7 == 0f;
			obj30 = obj31 + 16;
			flag9 = (nint)obj29 != 1;
			flag8 = flag9;
			obj31 = obj30;
			if (flag9)
			{
				continue;
			}
			goto IL_05fb;
		}
		object obj33 = obj28 + obj31;
		object obj34 = obj33 + 312;
		flag9 = flag8;
		obj30 = obj31;
		goto IL_1158;
		IL_0bf8:
		NullReferenceException ex = new NullReferenceException();
		object obj36;
		object obj35 = (object)(&obj36);
		IndexOutOfRangeException ex2 = (IndexOutOfRangeException)(object)ex;
		goto IL_1458;
		IL_0f3b:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0f49;
		IL_0ec8:
		NullReferenceException ex4 = new NullReferenceException();
		obj35 = (object)(&obj36);
		object obj38;
		object obj37 = obj38;
		float num9;
		float num8 = num9;
		float num10;
		num = num10;
		object obj39;
		obj8 = obj39;
		float num11;
		num3 = num11;
		float num12;
		num5 = num12;
		num6 = unchecked((nint)null);
		Vector3 vector = (Vector3)0;
		ex2 = (IndexOutOfRangeException)(object)ex4;
		goto IL_1458;
		IL_1048:
		object obj40;
		object obj41;
		object obj42;
		object obj43;
		object obj44;
		object obj45;
		float num13;
		float num14;
		float needGap;
		Vector3[] array;
		int num15;
		float num16;
		float num17;
		object obj48;
		if (num2 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB00]");
			obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj42 = 0;
			obj36 = 0;
			num = num2;
			obj8 = obj9;
			obj43 = 0;
			num3 = num4;
			GillaDoor gillaDoor = null;
			obj44 = 0;
			obj45 = obj9;
			num13 = num4;
			num14 = needGap;
			num5 = num2;
			if (array != null)
			{
				bool flag14 = num15 < array.Length;
				object obj32 = !flag14;
				float num7 = (float)num15 - (float)array.Length;
				bool flag11 = num7 < 0f;
				bool flag13 = num7 == 0f;
				flag9 = num15 >= array.Length;
				if (!flag9)
				{
					if (obj32 == null)
					{
						object obj46 = num15 * 12;
						object obj47 = (object)array + obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X8_v65+20]");
						num16 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X8_v65+24]");
						num17 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X8_v65+28]");
						obj48 = 0;
						goto IL_0435;
					}
					goto IL_0f66;
				}
			}
			else
			{
				bool flag15 = num15 < 0;
				object obj32 = !flag15;
				bool flag11 = num15 < 0;
				bool flag13 = num15 == 0;
				flag9 = num15 > 0;
				obj48 = obj9;
				num17 = num4;
				num16 = ahead;
				float num7 = num15;
				if (!flag9)
				{
					goto IL_0435;
				}
			}
		}
		goto IL_0f24;
		IL_0f49:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0f66;
		IL_0f66:
		ex2 = new IndexOutOfRangeException();
		goto IL_1458;
		IL_1458:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		GillaDoor result = default;
		return result;
		IL_00e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num6 = unchecked((nint)null);
		goto IL_1013;
		IL_1013:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v450 @ X0_v21] (should have been resolved before IL gen)");
		object obj49 = default;
		if (obj49 == null)
		{
			goto IL_0f24;
		}
		needGap = NeedGap;
		Transform transform = base.transform;
		bool flag16 = (object)transform == null;
		num = num2;
		obj8 = obj9;
		num3 = num4;
		num5 = needGap;
		vector = (Vector3)0;
		if (flag16)
		{
			goto IL_0f3b;
		}
		Vector3 position = transform.position;
		if (~(pathOk ? 1u : 0u) == 0)
		{
			bool flag17 = path == null;
			num = num2;
			obj8 = obj9;
			num3 = num4;
			num5 = needGap;
			vector = (Vector3)0;
			if (flag17)
			{
				goto IL_0f3b;
			}
			Vector3[] corners = path.corners;
			bool flag18 = (byte)(~(pathOk ? 1u : 0u)) != 0;
			vector = (Vector3)0;
			array = corners;
			if (!flag18)
			{
				num15 = corner;
				vector = (Vector3)0;
				array = corners;
				goto IL_1048;
			}
		}
		else
		{
			vector = (Vector3)0;
			array = null;
		}
		num15 = 0;
		goto IL_1048;
		IL_1158:
		float num18 = num16 - num14;
		object obj50 = obj48 - obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ X0_v43+8]");
		vector = (Vector3)0;
		float num19 = num18 * num18;
		num3 = (float)obj50 * (float)obj50;
		num5 = num3 + num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1025 @ X0_v43] (should have been resolved before IL gen)");
		object obj51 = default;
		if (obj51 == null)
		{
			goto IL_0bf8;
		}
		obj38 = obj37;
		num9 = num8;
		num10 = num;
		obj39 = obj8;
		num11 = num3;
		object obj52 = obj51;
		num12 = num5;
		nint num20 = num6;
		object obj59 = default;
		UnityEngine.Object obj68 = default;
		ref float t = default;
		object obj74 = default;
		while (true)
		{
			object obj53 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ X8_v39+12E]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ X8_v39+12E]");
			if ((nint)0 == 0)
			{
				goto IL_073f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ X8_v39+98]");
			object obj55 = (nint)0 + (nint)8;
			bool flag19 = flag9;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ X10_v37-8]");
				bool flag20 = 0 < (nint)obj40;
				object obj32 = !flag20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ X10_v37-8]");
				float num7 = 0f - (float)obj40;
				bool flag11 = num7 < 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ X10_v37-8]");
				if (0 == (nint)obj40)
				{
					break;
				}
				obj54--;
				bool flag21 = (nint)obj54 < 1;
				obj32 = !flag21;
				num7 = (float)obj54 - 1f;
				flag11 = num7 < 0f;
				bool flag13 = num7 == 0f;
				obj30 = obj55 + 16;
				flag9 = (nint)obj54 != 1;
				flag19 = flag9;
				obj55 = obj30;
				if (flag9)
				{
					continue;
				}
				goto IL_073f;
			}
			object obj56 = obj53 + obj55;
			object obj57 = obj56 + 312;
			flag9 = flag19;
			obj30 = obj55;
			goto IL_1252;
			IL_0cc8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num20 = unchecked((nint)null);
			goto IL_13ef;
			IL_13ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1339 @ X0_v56+8]");
			vector = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1339 @ X0_v56] (should have been resolved before IL gen)");
			goto IL_1386;
			IL_0898:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num20 = unchecked((nint)null);
			goto IL_1307;
			IL_073f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num20 = unchecked((nint)null);
			goto IL_1252;
			IL_1252:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X0_v49+8]");
			vector = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1137 @ X0_v49] (should have been resolved before IL gen)");
			object obj58 = obj59 & 1;
			if (obj58 != null)
			{
				if (obj51 == null)
				{
					break;
				}
				object obj60 = obj51;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ X8_v50+12E]");
				object obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ X8_v50+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0898;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ X8_v50+98]");
				object obj62 = (nint)0 + (nint)8;
				bool flag22 = flag9;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X10_v32-8]");
					bool flag23 = 0 < (nint)obj41;
					object obj32 = !flag23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X10_v32-8]");
					float num7 = 0f - (float)obj41;
					bool flag11 = num7 < 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X10_v32-8]");
					if (0 == (nint)obj41)
					{
						break;
					}
					obj61--;
					bool flag24 = (nint)obj61 < 1;
					obj32 = !flag24;
					num7 = (float)obj61 - 1f;
					flag11 = num7 < 0f;
					bool flag13 = num7 == 0f;
					obj30 = obj62 + 16;
					flag9 = (nint)obj61 != 1;
					flag22 = flag9;
					obj62 = obj30;
					if (flag9)
					{
						continue;
					}
					goto IL_0898;
				}
				object obj63 = obj60 + obj62;
				object obj64 = obj63 + 312;
				flag9 = flag22;
				obj30 = obj62;
				goto IL_1307;
			}
			object obj65 = 15;
			goto IL_142b;
			IL_1307:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1300 @ X0_v63] (should have been resolved before IL gen)");
			object obj66 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ X0_v66+E4]");
			bool flag25 = (nint)0 == 0;
			object obj67 = !flag25;
			if (obj67 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag26 = obj68 != null;
			bool flag27 = !flag26;
			vector = (Vector3)0;
			if (!flag27)
			{
				if ((object)obj68 == null)
				{
					goto IL_0ec8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X0_v65 (UnityEngine.Object)+A8]");
				bool flag28 = (nint)0 == 0;
				object obj69 = !flag28;
				vector = (Vector3)0;
				if (obj69 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X0_v65 (UnityEngine.Object)+E4]");
					bool flag29 = (nint)0 == 0;
					object obj70 = !flag29;
					vector = (Vector3)0;
					if (obj70 == null)
					{
						num12 = ((GillaDoor)obj68).Gap;
						bool flag30 = num12 < needGap;
						object obj32 = !flag30;
						float num7 = num12 - needGap;
						bool flag11 = num7 < 0f;
						bool flag13 = num7 == 0f;
						flag9 = !(num12 < needGap);
						num11 = needGap;
						vector = (Vector3)0;
						if (!flag9)
						{
							object obj71 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ X0_v73+E4]");
							bool flag31 = (nint)0 == 0;
							object obj72 = !flag31;
							if (obj72 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag32 = Crosses((GillaDoor)obj68, (Vector3)(&obj43), (Vector3)0, out t);
							bool flag33 = !flag32;
							obj38 = obj48;
							num9 = num17;
							num10 = num16;
							obj39 = obj45;
							num11 = num13;
							num12 = num14;
							vector = (Vector3)(&obj43);
							if (!flag33)
							{
								object obj73 = obj74 * obj43;
								num12 = (float)obj44 + (float)obj73;
								bool flag34 = num12 < num2;
								obj32 = !flag34;
								num7 = num12 - num2;
								flag11 = num12 < num2;
								flag13 = num7 == 0f;
								obj38 = obj48;
								num9 = num17;
								num10 = num16;
								obj39 = obj45;
								num11 = num2;
								vector = (Vector3)(&obj43);
								if (flag11)
								{
									obj65 = 14;
									obj38 = obj48;
									num9 = num17;
									num10 = num16;
									obj39 = obj45;
									num11 = num2;
									GillaDoor gillaDoor = (GillaDoor)obj68;
									num20 = unchecked((nint)null);
									vector = (Vector3)(&obj43);
									goto IL_142b;
								}
							}
						}
					}
				}
			}
			bool flag35 = obj51 == null;
			object obj75 = !flag35;
			obj37 = obj38;
			num8 = num9;
			num = num10;
			obj8 = obj39;
			num3 = num11;
			num5 = num12;
			num6 = unchecked((nint)null);
			obj52 = obj51;
			num20 = unchecked((nint)null);
			if (obj75 != null)
			{
				continue;
			}
			goto IL_0bf8;
			IL_1386:
			obj35 = (object)(&obj36);
			obj37 = obj38;
			num8 = num9;
			num = num10;
			obj8 = obj39;
			num3 = num11;
			num5 = num12;
			num6 = num20;
			goto IL_0f49;
			IL_142b:
			object obj76 = (object)(&obj36);
			object obj77 = obj76;
			if (obj76 == null)
			{
				goto IL_1386;
			}
			object obj78 = obj77;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1219 @ X8_v46+12E]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			object obj80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1219 @ X8_v46+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0cc8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1219 @ X8_v46+98]");
			object obj81 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X10_v26-8]");
				if (0 == (nint)obj80)
				{
					break;
				}
				obj79--;
				obj81 += 16;
				if ((nint)obj79 != 1)
				{
					continue;
				}
				goto IL_0cc8;
			}
			object obj82 = obj78 + obj81;
			object obj83 = obj82 + 312;
			goto IL_13ef;
		}
		NullReferenceException ex6 = new NullReferenceException();
		obj35 = (object)(&obj36);
		obj37 = obj38;
		num8 = num9;
		num = num10;
		obj8 = obj39;
		num3 = num11;
		num5 = num12;
		num6 = num20;
		ex2 = (IndexOutOfRangeException)(object)ex6;
		goto IL_1458;
		IL_0f24:
		return null;
	}

	private unsafe bool ShutDoorOn(Vector3[] corners)
	{
		//IL_0021: Expected Obj, but got I4
		//IL_003d: Invalid comparison between F4 and I4
		//IL_0bc7: Expected Obj, but got I4
		//IL_0fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbc: Expected I4, but got Unknown
		//IL_0076: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I4
		//IL_0f50: Expected Obj, but got I4
		//IL_0c6f: Expected Obj, but got I4
		//IL_0fd1: Expected Obj, but got I
		//IL_0fe1: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I
		//IL_021a: Expected I, but got Obj
		//IL_0cef: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_07b1: Expected Obj, but got Ref
		//IL_0c9f: Expected Obj, but got I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0e79: Expected Obj, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01a9: Expected Obj, but got I4
		//IL_01c3: Invalid comparison between F4 and I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_0395: Expected I, but got Obj
		//IL_0d88: Expected Obj, but got I
		//IL_0d9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da0: Expected Obj, but got Unknown
		//IL_02ef: Expected Obj, but got I
		//IL_07c7: Expected Obj, but got I4
		//IL_0d38: Expected Obj, but got I4
		//IL_0f66: Expected Obj, but got Ref
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_0ea6: Expected Obj, but got Ref
		//IL_0a71: Expected Obj, but got Ref
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0324: Expected Obj, but got I4
		//IL_033e: Invalid comparison between F4 and I4
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_07e4: Expected Obj, but got I
		//IL_07f4: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_087f: Expected I, but got Obj
		//IL_04e0: Expected I, but got Obj
		//IL_0f17: Expected Obj, but got I
		//IL_082f: Expected Obj, but got I
		//IL_0e53: Expected Obj, but got I4
		//IL_043a: Expected Obj, but got I
		//IL_0ddf: Expected Obj, but got I4
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected Obj, but got Unknown
		//IL_0750: Expected Obj, but got I4
		//IL_0785: Expected I, but got Obj
		//IL_078a: Expected I, but got Obj
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected Obj, but got Unknown
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Obj, but got Unknown
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Expected Obj, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_046f: Expected Obj, but got I4
		//IL_0489: Invalid comparison between F4 and I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_0ac7: Expected Obj, but got Ref
		//IL_0afc: Expected I, but got Obj
		//IL_0597: Expected Obj, but got I4
		//IL_05b0: Invalid comparison between F4 and I4
		//IL_05f9: Expected Obj, but got I4
		//IL_0b77: Expected Obj, but got Ref
		//IL_0bac: Expected I, but got Obj
		//IL_0622: Expected Obj, but got I4
		//IL_063d: Invalid comparison between F4 and I4
		//IL_0b1f: Expected Obj, but got Ref
		//IL_0b54: Expected I, but got Obj
		//IL_067f: Expected Obj, but got I4
		//IL_06b2: Expected VT, but got I4
		//IL_06b2: Expected VT, but got Ref
		//IL_06d0: Expected Obj, but got I4
		//IL_06e0: Expected Obj, but got I
		//IL_06f0: Expected Obj, but got I
		//IL_0708: Expected Obj, but got I
		//IL_0718: Expected Obj, but got I
		//IL_0720: Expected F4, but got Obj
		//IL_0728: Expected Obj, but got Ref
		//IL_09fc: Expected Obj, but got I
		//IL_0a0c: Expected Obj, but got I
		//IL_0a24: Expected Obj, but got I
		//IL_0a34: Expected Obj, but got I
		//IL_0a3c: Expected F4, but got Obj
		//IL_0a45: Expected Obj, but got I4
		//IL_0a4a: Expected I, but got Obj
		//IL_0a52: Expected Obj, but got Ref
		//IL_0a5b: Expected Obj, but got I4
		float needGap = NeedGap;
		bool flag = corners == null;
		float num = needGap;
		Vector3[] array = corners;
		bool flag4;
		object obj4;
		object obj5;
		object obj6;
		object obj7;
		object obj8;
		object obj9;
		if (!flag)
		{
			bool flag2 = corners.Length < 2;
			object obj = !flag2;
			float num2 = (float)corners.Length - 2f;
			bool flag3 = num2 == 0f;
			flag4 = corners.Length < 2;
			if (flag4)
			{
				object obj2 = 0;
				return (byte)(obj2 & 1) != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB00]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			obj7 = 0;
			obj8 = 0;
			num = needGap;
			array = corners;
			obj9 = 1;
			object obj10 = 0;
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v23+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v23+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v17+40]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v17+40]");
			if ((nint)0 != 0)
			{
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v18+12E]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAF8]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v18+12E]");
				if ((nint)0 == 0)
				{
					goto IL_020b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v18+98]");
				object obj20 = (nint)0 + (nint)8;
				bool flag7 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X10_v38-8]");
					bool flag8 = 0 < (nint)obj19;
					obj = !flag8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X10_v38-8]");
					num2 = 0f - (float)obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X10_v38-8]");
					if (0 == (nint)obj19)
					{
						break;
					}
					obj18--;
					bool flag9 = (nint)obj18 < 1;
					obj = !flag9;
					num2 = (float)obj18 - 1f;
					flag3 = num2 == 0f;
					obj19 = obj20 + 16;
					flag4 = (nint)obj18 != 1;
					obj20 = obj19;
					flag7 = flag4;
					if (flag4)
					{
						continue;
					}
					goto IL_020b;
				}
				object obj21 = obj17 + obj20;
				object obj22 = obj21 + 312;
				obj19 = obj20;
				flag4 = flag7;
				goto IL_0cdf;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0bf6;
		IL_0bf6:
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_0f8b;
		IL_0f8b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_0b66:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		object obj23 = (object)(&obj8);
		object obj25;
		object obj24 = obj25;
		object obj27;
		object obj26 = obj27;
		object obj29;
		object obj28 = obj29;
		object obj31;
		object obj30 = obj31;
		object obj33;
		object obj32 = obj33;
		float num3;
		num = num3;
		nint num4 = unchecked((nint)null);
		array = null;
		ex2 = (OutOfMemoryException)(object)ex3;
		goto IL_0f8b;
		IL_020b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num4 = unchecked((nint)null);
		goto IL_0cdf;
		IL_0b0e:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		obj23 = (object)(&obj8);
		obj24 = obj25;
		obj26 = obj27;
		obj28 = obj29;
		obj30 = obj31;
		obj32 = obj33;
		num = num3;
		num4 = unchecked((nint)null);
		array = null;
		ex2 = (OutOfMemoryException)(object)ex4;
		goto IL_0f8b;
		IL_0ab6:
		NullReferenceException ex5 = new NullReferenceException();
		obj23 = (object)(&obj8);
		obj24 = obj25;
		obj26 = obj27;
		obj28 = obj29;
		obj30 = obj31;
		obj32 = obj33;
		num = num3;
		num4 = unchecked((nint)null);
		array = null;
		ex2 = (OutOfMemoryException)(object)ex5;
		goto IL_0f8b;
		IL_0cdf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v24+8]");
		array = (Vector3[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v783 @ X0_v24] (should have been resolved before IL gen)");
		object obj34 = default;
		if (obj34 == null)
		{
			goto IL_07a0;
		}
		object obj35 = obj9 - 1;
		object obj36 = obj9 * 12;
		object obj37 = (object)corners + obj36;
		object obj38 = obj37 + 20;
		object obj39 = obj37 + 32;
		obj25 = obj24;
		obj27 = obj26;
		obj29 = obj28;
		obj31 = obj30;
		obj33 = obj32;
		num3 = num;
		nint num5 = num4;
		object obj40 = obj34;
		object obj47 = default;
		UnityEngine.Object obj56 = default;
		object obj60 = default;
		ref float t = default;
		while (true)
		{
			object obj41 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X8_v26+12E]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X8_v26+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0386;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X8_v26+98]");
			object obj43 = (nint)0 + (nint)8;
			bool flag10 = flag4;
			object obj19;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X10_v33-8]");
				bool flag11 = 0 < (nint)obj4;
				object obj = !flag11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X10_v33-8]");
				float num2 = 0f - (float)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X10_v33-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				obj42--;
				bool flag12 = (nint)obj42 < 1;
				obj = !flag12;
				num2 = (float)obj42 - 1f;
				bool flag3 = num2 == 0f;
				obj19 = obj43 + 16;
				flag4 = (nint)obj42 != 1;
				obj43 = obj19;
				flag10 = flag4;
				if (flag4)
				{
					continue;
				}
				goto IL_0386;
			}
			object obj44 = obj41 + obj43;
			object obj45 = obj44 + 312;
			obj19 = obj43;
			flag4 = flag10;
			goto IL_0d78;
			IL_0f07:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v36+8]");
			array = (Vector3[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1096 @ X0_v36] (should have been resolved before IL gen)");
			goto IL_0e9e;
			IL_0870:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num5 = unchecked((nint)null);
			goto IL_0f07;
			IL_04d1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num5 = unchecked((nint)null);
			goto IL_0e1f;
			IL_0386:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num5 = unchecked((nint)null);
			goto IL_0d78;
			IL_0d78:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X0_v30+8]");
			array = (Vector3[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v898 @ X0_v30] (should have been resolved before IL gen)");
			object obj46 = obj47 & 1;
			if (obj46 != null)
			{
				if (obj34 == null)
				{
					break;
				}
				object obj48 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v39+12E]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v39+12E]");
				if ((nint)0 == 0)
				{
					goto IL_04d1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v39+98]");
				object obj50 = (nint)0 + (nint)8;
				bool flag13 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X10_v28-8]");
					bool flag14 = 0 < (nint)obj5;
					object obj = !flag14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X10_v28-8]");
					float num2 = 0f - (float)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X10_v28-8]");
					if (0 == (nint)obj5)
					{
						break;
					}
					obj49--;
					bool flag15 = (nint)obj49 < 1;
					obj = !flag15;
					num2 = (float)obj49 - 1f;
					bool flag3 = num2 == 0f;
					obj19 = obj50 + 16;
					flag4 = (nint)obj49 != 1;
					obj50 = obj19;
					flag13 = flag4;
					if (flag4)
					{
						continue;
					}
					goto IL_04d1;
				}
				object obj51 = obj48 + obj50;
				object obj52 = obj51 + 312;
				obj19 = obj50;
				flag4 = flag13;
				goto IL_0e1f;
			}
			object obj53 = 7;
			goto IL_0f5e;
			IL_0e1f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1057 @ X0_v43] (should have been resolved before IL gen)");
			object obj54 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X0_v46+E4]");
			bool flag16 = (nint)0 == 0;
			object obj55 = !flag16;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag17 = obj56 != null;
			bool flag18 = !flag17;
			array = null;
			if (!flag18)
			{
				if ((object)obj56 == null)
				{
					goto IL_0ab6;
				}
				num3 = ((GillaDoor)obj56).Gap;
				bool flag19 = num3 < needGap;
				object obj = !flag19;
				float num2 = num3 - needGap;
				bool flag3 = num2 == 0f;
				flag4 = !(num3 < needGap);
				array = null;
				if (!flag4)
				{
					bool flag20 = (nint)obj35 < corners.Length;
					object obj57 = !flag20;
					if (obj57 != null)
					{
						goto IL_0b66;
					}
					bool flag21 = (nint)obj9 < corners.Length;
					obj = !flag21;
					num2 = (float)obj9 - (float)corners.Length;
					flag3 = num2 == 0f;
					if (obj != null)
					{
						goto IL_0b0e;
					}
					object obj58 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v55+E4]");
					bool flag22 = (nint)0 == 0;
					object obj59 = !flag22;
					if (obj59 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag23 = Crosses((GillaDoor)obj56, (Vector3)(&obj60), (Vector3)0, out t);
					bool flag24 = !flag23;
					object obj61 = !flag24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X29_v10+8]");
					obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X29_v10+4]");
					obj27 = 0;
					obj29 = obj39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X22_v10+8]");
					obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X22_v10+4]");
					obj33 = 0;
					num3 = (float)obj38;
					array = (Vector3[])(&obj60);
					if (obj61 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X29_v10+8]");
						obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X29_v10+4]");
						obj27 = 0;
						obj29 = obj39;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X22_v10+8]");
						obj31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X22_v10+4]");
						obj33 = 0;
						num3 = (float)obj38;
						obj53 = 6;
						num5 = unchecked((nint)null);
						array = (Vector3[])(&obj60);
						object obj10 = 1;
						goto IL_0f5e;
					}
				}
			}
			bool flag25 = obj34 == null;
			object obj62 = !flag25;
			obj24 = obj25;
			obj26 = obj27;
			obj28 = obj29;
			obj30 = obj31;
			obj32 = obj33;
			num = num3;
			num4 = unchecked((nint)null);
			num5 = unchecked((nint)null);
			obj40 = obj34;
			if (obj62 != null)
			{
				continue;
			}
			goto IL_07a0;
			IL_0f5e:
			object obj63 = (object)(&obj8);
			object obj64 = obj63;
			if (obj63 == null)
			{
				goto IL_0e9e;
			}
			object obj65 = obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v35+12E]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			object obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v35+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0870;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v35+98]");
			object obj68 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X10_v22-8]");
				if (0 == (nint)obj67)
				{
					break;
				}
				obj66--;
				obj68 += 16;
				if ((nint)obj66 != 1)
				{
					continue;
				}
				goto IL_0870;
			}
			object obj69 = obj65 + obj68;
			object obj70 = obj69 + 312;
			goto IL_0f07;
			IL_0e9e:
			obj23 = (object)(&obj8);
			obj24 = obj25;
			obj26 = obj27;
			obj28 = obj29;
			obj30 = obj31;
			obj32 = obj33;
			num = num3;
			num4 = num5;
			goto IL_0bf6;
		}
		NullReferenceException ex6 = new NullReferenceException();
		obj23 = (object)(&obj8);
		obj24 = obj25;
		obj26 = obj27;
		obj28 = obj29;
		obj30 = obj31;
		obj32 = obj33;
		num = num3;
		num4 = num5;
		ex2 = (OutOfMemoryException)(object)ex6;
		goto IL_0f8b;
		IL_07a0:
		NullReferenceException ex7 = new NullReferenceException();
		obj23 = (object)(&obj8);
		ex2 = (OutOfMemoryException)(object)ex7;
		goto IL_0f8b;
	}

	private unsafe static bool Crosses(GillaDoor d, Vector3 a, Vector3 b, out float t)
	{
		//IL_01ee: Expected native int or pointer, but got VT
		//IL_01e5: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_025f: Expected Obj, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_00db: Invalid comparison between F4 and I4
		//IL_00e9: Expected native int or pointer, but got VT
		//IL_00f7: Expected F8, but got I4
		//IL_034d: Expected Obj, but got I4
		//IL_0375: Expected Obj, but got I
		//IL_038d: Expected Obj, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_03e5: Expected Obj, but got I
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_048a: Expected Obj, but got I4
		//IL_04a2: Invalid comparison between F8 and I4
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_01c4: Invalid comparison between F8 and I4
		((Vector3*)(nint)a)->x = 0f;
		if ((object)d != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj = 0;
			Vector3 foot = d.Foot;
			object obj2 = obj;
			object obj4 = default;
			object obj3 = obj4 - obj4;
			object obj6 = default;
			object obj5 = obj6 - obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = default;
			object obj8 = obj9 - obj4;
			object obj10 = d.Through__BackingField * obj3;
			object obj12 = default;
			object obj11 = obj12 - obj6;
			object obj14 = default;
			object obj13 = obj5 * obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [d @ X0 (GillaDoor)+148]");
			object obj15 = (nint)0 * (nint)0;
			object obj16 = d.Through__BackingField * obj8;
			object obj17 = obj11 * obj14;
			object obj18 = obj10 + obj15;
			object obj19 = obj16 + obj15;
			object obj20 = obj13 + obj18;
			object obj21 = obj17 + obj19;
			bool flag2 = obj20 == obj21;
			bool result = false;
			if (!flag2)
			{
				object obj22 = obj20 * obj21;
				bool flag3 = (nint)obj22 > 0;
				result = false;
				if (!flag3)
				{
					object obj23 = obj20 - obj21;
					float num = (float)obj20 / (float)obj23;
					bool flag4 = num < 0f;
					((Vector3*)(nint)a)->x = num;
					double num2 = 0.0;
					if (!flag4)
					{
						bool flag5 = !((double)num > 1.0);
						num2 = num;
						if (!flag5)
						{
							num2 = 1.0;
						}
					}
					object obj24 = obj9 - obj4;
					object obj25 = obj12 - obj6;
					object obj26 = obj;
					double num3 = (double)obj24 * num2;
					double num4 = (double)obj25 * num2;
					double num5 = (double)obj6 + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v9+E4]");
					bool flag6 = (nint)0 == 0;
					object obj27 = !flag6;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					double num6 = num5 - (double)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj28 = 0;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v10+A0]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					double num7 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v11+1C]");
					double num8 = num7 * 0.0;
					Vector3 vector = d.Through__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v11+1C]");
					object obj31 = vector * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [d @ X0 (GillaDoor)+148]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v11+18]");
					object obj32 = num9 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [d @ X0 (GillaDoor)+148]");
					object obj33 = 0 * obj22;
					object obj34 = obj32 - obj31;
					double num10 = num8 - (double)obj33;
					double num11 = num6 * (double)obj34;
					double num12 = 0.0 * num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					double num13 = num11 + num12;
					double num14 = (double)d.Width__BackingField * 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					bool flag7 = num13 < num14;
					object obj35 = !flag7;
					double num15 = num13 - num14;
					bool flag8 = num15 == 0.0;
					object obj36 = ~obj35;
					object obj37 = obj36 | flag8;
					if (obj37 == null)
					{
						result = false;
					}
					else
					{
						object obj39 = default;
						object obj40 = default;
						object obj38 = obj39 - obj40;
						double num16 = (double)obj38 * num2;
						double num17 = (double)obj40 + num16;
						double num18 = num17 - (double)obj40;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						double num19 = num18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
						double num20 = num19 - 0.0;
						bool flag9 = num20 < 0.0;
						result = flag9;
					}
				}
			}
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void BeginPry(GillaDoor door)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		state__BackingField = (State)6;
		object obj = state__BackingField - 2;
		bool flag = obj == null;
		stateT = 0f;
		reachedFor = 0f;
		listening = false;
		pryFrom = state__BackingField;
		Chasing__BackingField = flag;
		PryDoor__BackingField = door;
		object obj2 = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Prying__BackingField = false;
		pryLifted = false;
		pryT = 0f;
	}

	private unsafe Vector3 PryStep(float dt, ref float want)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b65: Expected Obj, but got I4
		//IL_0b31: Expected VT, but got Obj
		//IL_00ea: Expected Obj, but got I4
		//IL_00f0: Expected I4, but got Obj
		//IL_0ba1: Expected VT, but got I4
		//IL_01ff: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I4
		//IL_07c3: Expected VT, but got I4
		//IL_027d: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02e8: Expected VT, but got I
		//IL_02f1: Invalid comparison between F4 and I4
		//IL_0304: Expected Obj, but got F4
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0339: Expected Obj, but got I4
		//IL_07cd: Expected VT, but got Obj
		//IL_0bcd: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I
		//IL_07ad: Expected VT, but got Obj
		//IL_0850: Expected VT, but got Obj
		//IL_0176: Expected VT, but got Obj
		//IL_0bfd: Expected Obj, but got I4
		//IL_0382: Expected Obj, but got I
		//IL_0822: Expected VT, but got Obj
		//IL_03a4: Expected VT, but got I
		//IL_04c9: Expected Obj, but got I4
		//IL_0c69: Expected Obj, but got I
		//IL_0c71: Expected VT, but got Obj
		//IL_0c93: Expected Obj, but got I4
		//IL_0593: Expected F8, but got I4
		//IL_0866: Expected F4, but got I4
		//IL_0cf1: Expected Ref, but got F8
		//IL_067f: Expected Obj, but got I4
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected Obj, but got Unknown
		//IL_0cfe: Expected VT, but got Obj
		//IL_0d20: Expected Obj, but got I4
		//IL_087b: Expected VT, but got I4
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05e7: Invalid comparison between F8 and I4
		//IL_05f6: Expected F8, but got I4
		//IL_08e2: Expected Obj, but got I4
		//IL_0dca: Expected Obj, but got VT
		//IL_0e22: Expected Obj, but got I4
		//IL_0a83: Expected Obj, but got I4
		//IL_0a8b: Expected VT, but got I4
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected Obj, but got Unknown
		//IL_0ac2: Expected Obj, but got I4
		//IL_0aca: Expected VT, but got I4
		//IL_0e5a: Expected Obj, but got I4
		//IL_0af8: Expected VT, but got F4
		//IL_0b1e: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		UnityEngine.Object obj3 = PryDoor__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (PryDoor__BackingField == null)
		{
			goto IL_0052;
		}
		float needGap = NeedGap;
		Vector3 result;
		if (~(Prying__BackingField ? 1u : 0u) != 0)
		{
			if ((object)PryDoor__BackingField != null)
			{
				Vector3 foot = PryDoor__BackingField.Foot;
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					object obj6 = default;
					object obj5 = obj6 - obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
					object obj7 = 0;
					float num = needGap - needGap;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+144]");
					float num2 = 0f * num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+148]");
					object obj10 = -0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+14C]");
					object obj11 = -0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+148]");
					object obj12 = (nint)0 * (nint)0;
					float num3 = (float)obj12 + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+14C]");
					object obj13 = 0 * obj5;
					float num4 = (float)obj13 + num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+144]");
					Vector3 vector = (Vector3)(-0);
					bool flag3 = num4 < 0f;
					object obj14 = num4 ^ num4;
					object obj15 = num4 & obj14;
					bool flag4 = (nint)obj15 < 0;
					bool flag5 = flag3 == flag4;
					object obj16 = !flag5;
					object obj17 = ~obj16;
					object obj18;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+148]");
						obj18 = 0;
					}
					else
					{
						obj18 = obj10;
					}
					bool flag6 = flag3 == flag4;
					object obj19 = !flag6;
					object obj20 = ~obj19;
					object obj21;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+14C]");
						obj21 = 0;
					}
					else
					{
						obj21 = obj11;
					}
					bool flag7 = flag3 == flag4;
					object obj22 = !flag7;
					object obj23 = ~obj22;
					Vector3 vector2;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+144]");
						vector2 = (Vector3)0;
					}
					else
					{
						vector2 = vector;
					}
					Transform transform2 = base.transform;
					if ((object)transform2 != null)
					{
						Vector3 position2 = transform2.position;
						float gap = PryDoor__BackingField.Gap;
						if (!(gap < needGap) && !PryDoor__BackingField.IsMoving)
						{
							goto IL_0052;
						}
						Transform transform3 = base.transform;
						if ((object)transform3 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+154]");
							double num5 = 0.0 * 0.5;
							double num6 = num5 + (double)pryStand;
							double num7 = (double)vector2 * num6;
							double num8 = (double)obj21 * num6;
							Vector3 position3 = transform3.position;
							object obj24 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v25+E4]");
							bool flag8 = (nint)0 == 0;
							object obj25 = !flag8;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							double num9 = (double)obj6 - num8;
							float num10 = needGap - (float)num7;
							float num11 = num10 - (float)num6;
							double num12 = num9 - (double)obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj26 = 0;
							result = (Vector3)obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v6 (UnityEngine.Vector3)+E4]");
							bool flag9 = (nint)0 == 0;
							object obj27 = !flag9;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num13 = num11 * num11;
							double num14 = num12 * num12;
							float num15 = num13 + (float)num14;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
							if ((nint)obj10 > 0)
							{
								bool flag10 = pryFrom != (State)2;
								double num16 = 0.0;
								if (!flag10)
								{
									result = (Vector3)obj26;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v6 (UnityEngine.Vector3)+E4]");
									bool flag11 = (nint)0 == 0;
									object obj28 = !flag11;
									if (obj28 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A834]");
									object obj29 = obj10 + 0;
									double num17 = (double)obj29 / 1.5;
									bool flag12 = num17 < 0.0;
									num16 = 0.0;
									if (!flag12)
									{
										bool flag13 = num17 > 1.0;
										num16 = 1.0;
										if (!flag13)
										{
											num16 = num17;
										}
									}
								}
								float num18 = walkSpeed;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
								float num19 = num18 * 0f;
								float num20 = runSpeed - num19;
								double num21 = (double)num20 * num16;
								double num22 = (double)num19 + num21;
								ref float reference = ref *(float*)num22;
								goto IL_0baf;
							}
							float num23 = walkSpeed * dt;
							float num24 = num23 * num23;
							object obj33;
							if (num15 > num24)
							{
								object obj30 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v57+E4]");
								bool flag14 = (nint)0 == 0;
								object obj31 = !flag14;
								if (obj31 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								float num25 = num11 / (float)obj10;
								object obj32 = 0 / obj10;
								num11 = num25 * num23;
								double num26 = num12 / (double)obj10;
								float num27 = (float)obj32 * num23;
								num12 = num26 * (double)num23;
								obj33 = obj21;
							}
							else
							{
								obj33 = obj21;
								float num27 = 0f;
							}
							if ((object)cc != null)
							{
								CollisionFlags collisionFlags = cc.Move((Vector3)0);
								Transform transform4 = base.transform;
								if ((object)transform4 != null)
								{
									Vector3 forward = transform4.forward;
									object obj34 = obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X0_v37+E4]");
									bool flag15 = (nint)0 == 0;
									object obj35 = !flag15;
									if (obj35 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object obj36 = obj18 * obj18;
									float num28 = num11 * num11;
									double num29 = num12 * num12;
									object obj37 = obj26;
									object obj38 = vector2 * vector2;
									double num30 = num29 + (double)num28;
									object obj39 = obj38 + obj36;
									object obj40 = obj33 * obj33;
									object obj41 = obj40 + obj39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X0_v40+E4]");
									bool flag16 = (nint)0 == 0;
									object obj42 = !flag16;
									if (obj42 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
									if ((nint)obj41 >= 0)
									{
										float num31 = (float)vector2 * num11;
										object obj43 = obj18 * 0;
										float num32 = (float)obj43 + num31;
										double num33 = (double)obj33 * num12;
										double num34 = num33 + (double)num32;
										double num35 = num34 / (double)obj41;
										bool flag17 = num35 < -1.0;
										double num36 = -1.0;
										if (!flag17)
										{
											bool flag18 = !(num35 > 1.0);
											num36 = num35;
											if (!flag18)
											{
												num36 = 1.0;
											}
										}
										object obj44 = obj26;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X0_v49+E4]");
										bool flag19 = (nint)0 == 0;
										object obj45 = !flag19;
										if (obj45 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
										double num37 = num36;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
										double num38 = num37 * 0.0;
										if (!(num38 < 15.0))
										{
											goto IL_0baf;
										}
									}
									bool isMoving = PryDoor__BackingField.IsMoving;
									bool flag20 = !isMoving;
									object obj46 = !flag20;
									result = (Vector3)isMoving;
									if (obj46 == null)
									{
										bool isOpen = PryDoor__BackingField.IsOpen;
										bool flag21 = !isOpen;
										object obj47 = !flag21;
										result = (Vector3)isOpen;
										if (obj47 == null)
										{
											pryT = 0f;
											Prying__BackingField = true;
											prySpot = (Vector3)num10;
											pryToward = vector2;
											result = (Vector3)isOpen;
										}
									}
									goto IL_0baf;
								}
							}
						}
					}
				}
			}
			goto IL_0b23;
		}
		float num39 = (pryT += dt);
		bool flag22 = (byte)(~(pryLifted ? 1u : 0u)) != 0;
		object obj48 = !flag22;
		bool flag23 = (byte)(int)this != 0;
		if (obj48 == null)
		{
			if (num39 < pryLiftSeconds)
			{
				if ((object)PryDoor__BackingField == null)
				{
					goto IL_0b23;
				}
				flag23 = PryDoor__BackingField.IsOpen;
				if (flag23)
				{
					EndPry();
					result = (Vector3)this;
					goto IL_0baf;
				}
			}
			else
			{
				if ((object)PryDoor__BackingField == null)
				{
					goto IL_0b23;
				}
				flag23 = PryDoor__BackingField.Pry();
				pryLifted = true;
			}
		}
		float num40 = pryT;
		float num41 = pryDoneSeconds;
		bool flag24 = pryT < pryDoneSeconds;
		result = (Vector3)flag23;
		float num42;
		if (!flag24)
		{
			if ((object)PryDoor__BackingField == null)
			{
				goto IL_0b23;
			}
			float gap2 = PryDoor__BackingField.Gap;
			if (!(gap2 < needGap))
			{
				if (pryFrom == (State)2)
				{
					EndPry();
					if (~(hasPrey ? 1u : 0u) == 0)
					{
						num42 = runSpeed;
						result = (Vector3)this;
						goto IL_0d7b;
					}
				}
				else
				{
					EndPry();
				}
				float num43 = runSpeed;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				num42 = num43 * 0f;
				result = (Vector3)this;
				goto IL_0d7b;
			}
			num40 = pryT;
			num41 = pryDoneSeconds;
			result = (Vector3)PryDoor__BackingField;
		}
		double num44 = (double)num41 + 4.0;
		if ((double)num40 > num44)
		{
			EndPry();
			PickWander((Vector3?)(object)0);
			result = (Vector3)this;
		}
		goto IL_0baf;
		IL_0d7b:
		speed = num42;
		goto IL_0baf;
		IL_0b23:
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
		IL_0baf:
		return result;
		IL_0052:
		EndPry();
		Transform transform5 = base.transform;
		if ((object)transform5 == null)
		{
			goto IL_0b23;
		}
		result = transform5.position;
		goto IL_0baf;
	}

	private void EndPry()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		Prying__BackingField = false;
		PryDoor__BackingField = null;
		object obj = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Vector3 vector = default;
		stuckAt = vector;
		bool flag = pryFrom == (State)3;
		stuckT = 0f;
		if (!flag)
		{
			if (pryFrom == (State)2 && ~(hasPrey ? 1u : 0u) == 0)
			{
				reachedFor = 0f;
				state__BackingField = (State)2;
				Chasing__BackingField = true;
				listening = false;
				stateT = 0f;
			}
			else
			{
				state__BackingField = (State)0;
				Chasing__BackingField = false;
				stateT = 0f;
				reachedFor = 0f;
				listening = false;
				hasPrey = false;
			}
		}
		else
		{
			state__BackingField = pryFrom;
			Chasing__BackingField = false;
			stateT = 0f;
			reachedFor = 0f;
			searchFor = 9f;
			listening = false;
		}
	}

	private void BeginBreak(GillaDoor door)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		state__BackingField = (State)7;
		object obj = state__BackingField - 2;
		bool flag = obj == null;
		stateT = 0f;
		reachedFor = 0f;
		listening = false;
		pryFrom = state__BackingField;
		Chasing__BackingField = flag;
		PryDoor__BackingField = door;
		object obj2 = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		breakT = 0f;
	}

	private unsafe Vector3 BreakStep(float dt, ref float want)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I4
		//IL_065d: Expected VT, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I
		//IL_0213: Unsupported input type for neg.
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_022e: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I
		//IL_0273: Invalid comparison between F4 and I4
		//IL_0286: Expected Obj, but got F4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02bb: Expected Obj, but got I4
		//IL_06bd: Expected Obj, but got I4
		//IL_06ed: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I4
		//IL_0759: Expected Obj, but got I
		//IL_0761: Expected VT, but got Obj
		//IL_0783: Expected Obj, but got I4
		//IL_045c: Invalid comparison between F4 and I
		//IL_0535: Expected I4, but got VT
		//IL_07cb: Expected VT, but got I4
		//IL_047e: Invalid comparison between F4 and I4
		//IL_048f: Expected Obj, but got I4
		//IL_049a: Invalid comparison between F4 and I4
		//IL_04ab: Expected Obj, but got I4
		//IL_0553: Expected VT, but got I4
		//IL_0612: Expected VT, but got I4
		//IL_0617: Expected VT, but got Obj
		//IL_0799: Expected Ref, but got F4
		//IL_064a: Expected VT, but got Obj
		//IL_05c4: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		UnityEngine.Object obj3 = PryDoor__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (PryDoor__BackingField == null)
		{
			goto IL_0052;
		}
		Vector3 vector;
		float num20;
		if ((object)PryDoor__BackingField != null)
		{
			float gap = PryDoor__BackingField.Gap;
			float needGap = NeedGap;
			if (!(gap < needGap) && !PryDoor__BackingField.IsMoving)
			{
				goto IL_0052;
			}
			Vector3 foot = PryDoor__BackingField.Foot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v3 (UnityEngine.Object)+14C]");
			object obj5 = 0;
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				float num = needGap - needGap;
				object obj7 = default;
				object obj6 = obj7 - obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v17+E4]");
				bool flag2 = (nint)0 == 0;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v3 (UnityEngine.Object)+144]");
				float num2 = 0f * num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v3 (UnityEngine.Object)+148]");
				object obj11 = -0;
				object obj12 = 0 - obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v3 (UnityEngine.Object)+148]");
				object obj13 = (nint)0 * (nint)0;
				float num3 = (float)obj13 + num2;
				object obj14 = obj5 * obj6;
				float num4 = (float)obj14 + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v3 (UnityEngine.Object)+144]");
				object obj15 = -0;
				bool flag3 = num4 < 0f;
				object obj16 = num4 ^ num4;
				object obj17 = num4 & obj16;
				bool flag4 = (nint)obj17 < 0;
				bool flag5 = flag3 == flag4;
				object obj18 = !flag5;
				object obj19 = ~obj18;
				if (obj19 == null)
				{
				}
				bool flag6 = flag3 == flag4;
				object obj20 = !flag6;
				object obj21 = ~obj20;
				if (obj21 != null)
				{
					obj5 = obj12;
				}
				bool flag7 = flag3 == flag4;
				object obj22 = !flag7;
				object obj23 = ~obj22;
				object obj24;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v3 (UnityEngine.Object)+144]");
					obj24 = 0;
				}
				else
				{
					obj24 = obj15;
				}
				Transform transform2 = base.transform;
				if ((object)transform2 != null)
				{
					Vector3 position2 = transform2.position;
					Transform transform3 = base.transform;
					if ((object)transform3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v3 (UnityEngine.Object)+154]");
						double num5 = 0.0 * 0.5;
						double num6 = num5 + (double)breakStand;
						double num7 = (double)obj24 * num6;
						double num8 = (double)obj5 * num6;
						Vector3 position3 = transform3.position;
						object obj25 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v25+E4]");
						bool flag8 = (nint)0 == 0;
						object obj26 = !flag8;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num9 = needGap - (float)num7;
						double num10 = (double)obj7 - num8;
						float num11 = num9 - (float)num6;
						double num12 = num10 - (double)obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj27 = 0;
						vector = (Vector3)obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v6 (UnityEngine.Vector3)+E4]");
						bool flag9 = (nint)0 == 0;
						object obj28 = !flag9;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num13 = num11 * num11;
						double num14 = num12 * num12;
						float num15 = num13 + (float)num14;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
						if (num15 > 0f)
						{
							bool flag10 = breakT < 0f;
							object obj29 = !flag10;
							bool flag11 = breakT == 0f;
							object obj30 = !flag11;
							object obj31 = obj29 & obj30;
							if (obj31 == null)
							{
								float num16;
								if (pryFrom == (State)2)
								{
									num16 = runSpeed;
								}
								else
								{
									float num17 = walkSpeed;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
									num16 = num17 * 0f;
								}
								ref float reference = ref *(float*)num16;
								goto IL_069f;
							}
						}
						float num18 = breakT + dt;
						float num19 = breakSeconds;
						breakT = num18;
						bool flag12 = num18 < breakSeconds;
						bool flag13 = (byte)(int)vector != 0;
						if (!flag12)
						{
							flag13 = PryDoor__BackingField.Blow((Vector3)0);
							if (flag13)
							{
								if (pryFrom == (State)2)
								{
									EndPry();
									if (~(hasPrey ? 1u : 0u) == 0)
									{
										num20 = runSpeed;
										vector = (Vector3)this;
										goto IL_07d9;
									}
								}
								else
								{
									EndPry();
								}
								float num21 = runSpeed;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
								num20 = num21 * 0f;
								vector = (Vector3)this;
								goto IL_07d9;
							}
							num18 = breakT;
							num19 = breakSeconds;
						}
						double num22 = (double)num19 + 3.0;
						bool flag14 = !((double)num18 > num22);
						vector = (Vector3)flag13;
						if (!flag14)
						{
							EndPry();
							PickWander((Vector3?)(object)0);
							vector = (Vector3)this;
						}
						goto IL_069f;
					}
				}
			}
		}
		goto IL_064f;
		IL_07d9:
		speed = num20;
		goto IL_069f;
		IL_064f:
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
		IL_0052:
		EndPry();
		Transform transform4 = base.transform;
		if ((object)transform4 == null)
		{
			goto IL_064f;
		}
		vector = transform4.position;
		goto IL_069f;
		IL_069f:
		return vector;
	}

	private bool Stuck(float dt)
	{
		//IL_01b2: Expected I4, but got Obj
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_016e: Invalid comparison between F4 and I4
		//IL_017f: Expected Obj, but got I4
		//IL_019f: Expected F4, but got I4
		//IL_0118: Expected VT, but got F4
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			float num = dt - (float)stuckAt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+16C]");
			object obj2 = default;
			object obj = obj2 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterBrain)+170]");
			object obj4 = default;
			object obj3 = obj4 - 0;
			float num2 = num * num;
			object obj5 = obj * obj;
			float num3 = num2 + (float)obj5;
			object obj6 = obj3 * obj3;
			float num4 = num3 + (float)obj6;
			if (!((double)num4 > 0.25))
			{
				float num5 = stuckT + dt;
				float num6 = num5 - 3f;
				bool flag = num6 < 0f;
				object obj7 = !flag;
				object obj8 = ~obj7;
				if (obj8 == null)
				{
					num5 = 0f;
				}
				bool result = !flag;
				stuckT = num5;
				return result;
			}
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Vector3 position2 = transform2.position;
				stuckAt = (Vector3)num4;
				_ = 0.25;
				stuckT = 0f;
				return false;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static Vector3 Flat(Vector3 v)
	{
		return v;
	}

	public MonsterBrain()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got I
		//IL_01f9: Expected F4, but got I
		//IL_020b: Expected F4, but got I
		//IL_021d: Expected F4, but got I
		//IL_022d: Expected Obj, but got I
		//IL_023f: Expected F4, but got I
		//IL_0252: Expected F4, but got I
		//IL_0262: Expected Obj, but got I
		//IL_027f: Expected F4, but got I
		//IL_0291: Expected F4, but got I
		//IL_02ac: Expected F4, but got Obj
		//IL_02c9: Expected F4, but got I
		//IL_02db: Expected F4, but got I
		//IL_02f9: Expected F4, but got I
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_034b: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I
		//IL_036d: Expected VT, but got Obj
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got I
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB58]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B7F8]");
		clipWalkSpeed = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EBE0]");
		walkSpeed = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EA60]");
		sightRange = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D440]");
		hearRange = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EBF0]");
		reachBelow = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj5 = 0;
		killSeconds = 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C778]");
		walkAwaySeconds = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FA70]");
		chaseLoopVolume = 0f;
		grabRange = 0.9f;
		breakSeconds = (float)typeof(_0021_00210);
		killHoldAfterBite = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BC08]");
		pryDoneSeconds = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C780]");
		lurkEvery = 0f;
		climbPitch = 78f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C280]");
		gazeAngle = 0f;
		AnimPace__BackingField = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list = default;
		list._002Ector();
		object obj6 = this + 408;
		trail = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB78]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<MonsterCatalog.Target> list2 = default;
		list2._002Ector();
		object obj8 = this + 416;
		targets = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB68]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<PlayerRef, float> dictionary = default;
		dictionary._002Ector();
		object obj10 = this + 424;
		killedAt = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		gait = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v26+A0]");
		object obj13 = 0;
		modelRest = (Quaternion)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list3 = default;
		list3._002Ector();
		object obj14 = this + 744;
		drawnOn = (List<Renderer>)(object)list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		noticeFor = 0.6f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<(int, int), float> dictionary2 = default;
		dictionary2._002Ector();
		object obj15 = this + 824;
		marked = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(int, int)> list4 = default;
		list4._002Ector();
		object obj16 = this + 832;
		unmark = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Vector3[] array = default;
		parts = array;
		object obj17 = this + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB60]");
		object obj18 = 0;
		searchFor = 9f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, (float, bool, float)> dictionary3 = default;
		dictionary3._002Ector();
		object obj19 = this + 880;
		ways = (Dictionary<Transform, (float, bool, float)>)(object)dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static MonsterBrain()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB90]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB98]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v3+A0]");
		object obj8 = 0;
		obj8 = list;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+A0]");
		object obj11 = 0;
		_ = 3212836864L;
		int num = Animator.StringToHash((string)obj3);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v8+A0]");
		object obj13 = 0;
		int num2 = Animator.StringToHash((string)obj4);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v10+A0]");
		object obj15 = 0;
		int num3 = Animator.StringToHash((string)obj5);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v12+A0]");
		object obj17 = 0;
		int num4 = Animator.StringToHash((string)obj6);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v14+A0]");
		object obj19 = 0;
		_ = 3240099840L;
	}
}
