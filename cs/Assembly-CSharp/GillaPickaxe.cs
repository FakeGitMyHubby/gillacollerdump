using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using Photon.Voice.Unity.UtilityScripts;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR;

public class GillaPickaxe : NetworkBehaviour
{
	[Serializable]
	private class Stamp
	{
		public int code;
	}

	private enum Into : byte
	{
		// error: enumerator has no value
		Nothing,
		// error: enumerator has no value
		Player,
		// error: enumerator has no value
		Dummy,
		// error: enumerator has no value
		Body,
		// error: enumerator has no value
		Monster
	}

	private struct Landed
	{
		public Into into;

		public int id;

		public NetworkId thing;

		public GoreSection section;

		public Vector3 point;
	}

	private struct Skin
	{
		public Into into;

		public int id;

		public NetworkId thing;

		public GoreSection section;

		public Vector3 world;

		public Vector3 body;

		public Vector3 normal;

		public float inside;

		public GillaWounds wounds;

		public GillaCorpse corpse;
	}

	private sealed class _003C_003Ec__DisplayClass150_0
	{
		public int id;

		internal bool _003CNearWhatItsIn_003Eb__0(NetworkApe x)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e2: Expected Obj, but got I4
			//IL_00b8: Expected I4, but got Obj
			//IL_0080: Expected Obj, but got I4
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
			if ((UnityEngine.Object)x != (UnityEngine.Object)null)
			{
				if ((object)x != null)
				{
					object obj4 = x.owner - id;
					return obj4 == null;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass161_0
	{
		public Landed l;

		internal bool _003CFacingAt_003Eb__0(NetworkApe x)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e8: Expected Obj, but got I4
			//IL_00be: Expected I4, but got Obj
			//IL_0086: Expected Obj, but got I
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
			if ((UnityEngine.Object)x != (UnityEngine.Object)null)
			{
				if ((object)x != null)
				{
					int owner = x.owner;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe+<>c__DisplayClass161_0)+14]");
					object obj4 = (nint)owner - (nint)0;
					return obj4 == null;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass170_0
	{
		public int id;

		internal bool _003CScratch_003Eb__0(NetworkApe x)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e2: Expected Obj, but got I4
			//IL_00b8: Expected I4, but got Obj
			//IL_0080: Expected Obj, but got I4
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
			if ((UnityEngine.Object)x != (UnityEngine.Object)null)
			{
				if ((object)x != null)
				{
					object obj4 = x.owner - id;
					return obj4 == null;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass175_0
	{
		public int id;

		internal bool _003CHold_003Eb__0(NetworkApe a)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e2: Expected Obj, but got I4
			//IL_00b8: Expected I4, but got Obj
			//IL_0080: Expected Obj, but got I4
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
			if ((UnityEngine.Object)a != (UnityEngine.Object)null)
			{
				if ((object)a != null)
				{
					object obj4 = a.owner - id;
					return obj4 == null;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private const int Spike = default(int);

	private const int Chisel = default(int);

	private const byte JustHurts = default(byte);

	private const byte Counts = default(byte);

	private const byte Kills = default(byte);

	internal const byte Soft = default(byte);

	internal const byte Stone = default(byte);

	internal const byte Metal = default(byte);

	public GillaItem item;

	public Vector3 spikeTip;

	public Vector3 spikeBase;

	public Vector3 edgeTip;

	public Vector3 edgeBase;

	public Vector3 balance;

	public Renderer wet;

	public float inLine;

	public float pushSpeed;

	public float hardSpeed;

	public float knockSpeed;

	public float stabSpeed;

	public float glassSpeed;

	public int miningDamage;

	public float reach;

	public Vector2 firstIn;

	public float chiselIn;

	public float countsAt;

	public float skullStops;

	public float holeRadius;

	public float chiselRadius;

	public float pushRate;

	public float pullRate;

	public float leverMost;

	public float bodyLeverMost;

	public float yanksAt;

	public float bodyYanksAt;

	public float monsterHarm;

	public float monsterHeadHarm;

	public AudioClip[] stabSounds;

	public AudioClip[] skullSounds;

	public AudioClip[] slideSounds;

	public AudioClip[] pullSounds;

	public AudioClip[] stoneSounds;

	public AudioClip[] metalSounds;

	public float loudness;

	private const float Stick = default(float);

	private const float HandSlides = default(float);

	private const float FollowsThrough = default(float);

	private const float Gives = default(float);

	private const float SwingLasts = default(float);

	private const float MostSpeed = default(float);

	private const float ComesBackIn = default(float);

	private const float SlidesFrom = default(float);

	private const float Slips = default(float);

	private const float PullStiff = default(float);

	private const float PullDamp = default(float);

	private const float PullHardest = default(float);

	private const float ScratchReach = default(float);

	private const float ThrownInLine = default(float);

	private const float ThrownBounce = default(float);

	private const float ScratchHold = default(float);

	private const float MostPush = default(float);

	private const float ScratchStep = default(float);

	private const float ScratchJump = default(float);

	private const float ScratchWidth = default(float);

	private static readonly int TipId;

	private static readonly int EdgeId;

	private static readonly int DryId;

	private float _Depth;

	private Vector3 _PullTo;

	private NetworkBool _Pulling;

	private Into into;

	private int end;

	private int targetId;

	private int bodyId;

	private GoreSection section;

	private Vector3 point;

	private Transform on;

	private Vector3 onLocal;

	private Vector3 axisOn;

	private Quaternion turnOn;

	private float depth;

	private float mostIn;

	private float stuckAt;

	private float slidWas;

	private float slideAt;

	private float hiddenSince;

	private bool harmed;

	private bool through;

	private readonly GillaNetGuard.Holder holder;

	private const float PickBudget = default(float);

	private const float ScratchBudget = default(float);

	private const float PickSlack = default(float);

	private const float MonsterBulk = default(float);

	private NetworkApe ape;

	private Dismemberment copy;

	private GillaDummy dummy;

	private MonsterBrain monster;

	private Rigidbody pulls;

	private Vector3 pullTo;

	private readonly Vector3[] was;

	private readonly Vector3[] swung;

	private readonly float[] swungAt;

	private readonly float[] wetTo;

	private float againAt;

	private float clangAt;

	private float comeFor;

	private Vector3 comeFrom;

	private Quaternion comeTurn;

	private int heldWas;

	private float wetAt;

	private float wetSaid;

	private bool wetChanged;

	private Vector3 tipOnMesh;

	private Vector3 edgeOnMesh;

	private float perMesh;

	private MaterialPropertyBlock props;

	private static GillaGoreAssets gore;

	private static ParticleSystem sparks;

	private static ParticleSystem flash;

	private static readonly List<Collider> found;

	private const float ThrownLooks = default(float);

	private readonly bool[] scraping;

	private readonly Skin[] scrapedFrom;

	private const float PickReach = default(float);

	private unsafe float Depth
	{
		get
		{
			//IL_002e: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				return (nint)ptr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
		set
		{
			//IL_0027: Expected I, but got F4
			if (Ptr != null)
			{
				int* ptr = (int*)(nint)value;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	private unsafe Vector3 PullTo
	{
		get
		{
			//IL_0021: Expected VT, but got Obj
			//IL_0073: Expected VT, but got Obj
			if (Ptr == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				InvalidOperationException ex = default;
				string message = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				return (Vector3)ex2;
			}
			return (Vector3)this;
		}
		set
		{
			if (Ptr != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	private unsafe NetworkBool Pulling
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+10]");
				return (NetworkBool)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkBool)ex2;
		}
		set
		{
			if (Ptr != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	private bool Live
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_012b: Expected Obj, but got I4
			//IL_0101: Expected I4, but got Obj
			//IL_0163: Expected Obj, but got I4
			//IL_00ed: Expected I4, but got Obj
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
			if ((UnityEngine.Object)((SimulationBehaviour)this)._object != (UnityEngine.Object)null)
			{
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				if ((object)((SimulationBehaviour)this)._object != null)
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!networkObject._runner)
					{
						goto IL_00ed;
					}
					if ((object)networkObject._runner != null)
					{
						ArgumentNullException ex = new ArgumentNullException();
						return (byte)(int)ex != 0;
					}
				}
				NullReferenceException ex2 = new NullReferenceException();
				return (byte)(int)ex2 != 0;
			}
			goto IL_00ed;
			IL_00ed:
			return false;
		}
	}

	private static Material Spray
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0237: Expected Obj, but got I
			//IL_0259: Expected Obj, but got I4
			//IL_0330: Expected Obj, but got I
			//IL_0352: Expected Obj, but got I4
			//IL_004d: Expected Obj, but got I
			//IL_00cd: Expected Obj, but got I
			//IL_00dd: Expected Obj, but got I
			//IL_0111: Expected Obj, but got I4
			//IL_02a7: Expected Obj, but got I
			//IL_0098: Expected Obj, but got I4
			//IL_0160: Expected Obj, but got I4
			//IL_0277: Expected Obj, but got I
			//IL_0287: Expected Obj, but got I
			//IL_01d7: Expected Obj, but got I4
			//IL_02e3: Expected Obj, but got I
			//IL_02f3: Expected Obj, but got I
			//IL_020c: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X9_v1+10]");
			UnityEngine.Object obj11;
			if ((UnityEngine.Object)0 != null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v31+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v31+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v19+10]");
				obj11 = (UnityEngine.Object)0;
				UnityEngine.Object obj12 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v16+E4]");
				bool flag4 = (nint)0 == 0;
				object obj16 = !flag4;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v16+A0]");
				object obj17 = (nint)0 + (nint)16;
				UnityEngine.Object obj18 = default;
				obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				UnityEngine.Object obj12 = obj18;
				obj11 = obj18;
			}
			object obj19 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = obj11 != null;
			bool flag7 = !flag6;
			Material result = null;
			if (!flag7)
			{
				object obj21 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v15+E4]");
				bool flag8 = (nint)0 == 0;
				object obj22 = !flag8;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj21 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v15+A0]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v10+10]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v10+10]");
				if ((nint)0 == 0)
				{
					return (Material)(object)new NullReferenceException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v11+50]");
				result = (Material)0;
			}
			return result;
		}
	}

	private Vector3 HoleOn
	{
		get
		{
			if (end == 0)
			{
			}
			if (end == 0)
			{
			}
			if (end == 0)
			{
			}
			return Along(end);
		}
	}

	private Vector3 Tip(int e)
	{
		//IL_0071: Expected VT, but got Obj
		if (e == 0)
		{
		}
		if (e == 0)
		{
		}
		if (e == 0)
		{
		}
		return (Vector3)this;
	}

	private Vector3 Along(int e)
	{
		//IL_0066: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I
		//IL_011f: Expected VT, but got Obj
		//IL_0141: Expected Obj, but got I4
		object obj;
		object obj2;
		if (e != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+90]");
			obj = 0;
			Vector3 vector = edgeTip;
			Vector3 vector2 = edgeBase;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+9C]");
			obj2 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+78]");
			obj = 0;
			Vector3 vector = spikeTip;
			Vector3 vector2 = spikeBase;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+84]");
			obj2 = 0;
		}
		object obj3 = obj - obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj4 = 0;
		Vector3 result = (Vector3)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (UnityEngine.Vector3)+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = obj3 * obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if ((nint)obj6 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		}
		return result;
	}

	private float Blade(int e)
	{
		//IL_0141: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got VT
		//IL_01f8: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		object obj;
		Vector3 vector;
		Vector3 vector2;
		object obj2;
		object obj4;
		Vector3 vector3;
		Vector3 vector4;
		object obj5;
		if (e != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+90]");
			obj = 0;
			vector = edgeTip;
			vector2 = edgeBase;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+9C]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A1]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+9C]");
			obj4 = 0;
			vector3 = edgeBase;
			vector4 = edgeTip;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+90]");
			obj5 = 0;
			if (obj3 == null)
			{
				goto IL_00b5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+78]");
			obj5 = 0;
			vector4 = spikeTip;
			vector3 = spikeBase;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+84]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A1]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+84]");
				obj2 = 0;
				vector2 = spikeBase;
				vector = spikeTip;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+78]");
				obj = 0;
				goto IL_00b5;
			}
		}
		goto IL_01ce;
		IL_00b5:
		_ = 1;
		obj4 = obj2;
		vector3 = vector2;
		vector4 = vector;
		obj5 = obj;
		goto IL_01ce;
		IL_01ce:
		object obj7 = vector4 - vector3;
		object obj8 = obj5 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = obj7 * obj7;
		object obj13 = obj8 * obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float result = (float)obj12 + (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		return result;
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_03b7: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_013d: Expected VT, but got I4
		//IL_0167: Expected Obj, but got I4
		//IL_01f3: Expected VT, but got I4
		//IL_020a: Expected VT, but got I4
		//IL_0265: Expected VT, but got I4
		//IL_027c: Expected VT, but got I4
		//IL_02e9: Expected VT, but got I4
		//IL_03dc: Expected Obj, but got I
		//IL_0406: Expected Obj, but got I4
		//IL_0312: Expected Obj, but got VT
		//IL_032f: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51E0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			UnityEngine.Object obj7 = default;
			item = (GillaItem)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B70]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B80]");
		object obj9 = 0;
		_ = 257;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<Vector3, Vector3, float, System.__Canon> action = default;
		action._002Ector((object)this, (IntPtr)obj9);
		object obj10 = obj3 + 80;
		obj10 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		GillaItem gillaItem = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B78]");
		object obj11 = 0;
		gillaItem.KnockLoudness__BackingField = loudness;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		Rigidbody rigidbody = default;
		rigidbody.centerOfMass = (Vector3)0;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (wet != null)
		{
			wet.enabled = false;
			Transform transform = wet.transform;
			Transform transform2 = base.transform;
			Vector3 vector = transform2.TransformPoint((Vector3)0);
			Vector3 vector2 = transform.InverseTransformPoint((Vector3)0);
			tipOnMesh = spikeTip;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+74]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+78]");
			_ = 0;
			Transform transform3 = wet.transform;
			Transform transform4 = base.transform;
			Vector3 vector3 = transform4.TransformPoint((Vector3)0);
			Vector3 vector4 = transform3.InverseTransformPoint((Vector3)0);
			edgeOnMesh = edgeTip;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+8C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+90]");
			_ = 0;
			Transform transform5 = wet.transform;
			Transform transform6 = base.transform;
			Vector3 up = transform6.up;
			Vector3 vector5 = transform5.InverseTransformVector((Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v44+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = edgeTip * edgeTip;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+8C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+8C]");
			object obj18 = num * 0;
			object obj19 = obj17 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+90]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+90]");
			object obj20 = num2 * 0;
			float num3 = (float)obj20 + (float)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			perMesh = num3;
		}
		Remember();
	}

	public override void Spawned()
	{
		Remember();
	}

	private void Remember()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0019: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_0211: Expected VT, but got I4
		//IL_0088: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = 40;
		object obj3 = 0;
		while (true)
		{
			Vector3[] array = was;
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				if ((nint)obj2 == 40)
				{
					object obj4 = 112;
				}
				else
				{
					object obj4 = 136;
				}
				if ((nint)obj2 == 40)
				{
					object obj5 = 116;
				}
				else
				{
					object obj5 = 140;
				}
				if ((nint)obj2 == 40)
				{
					object obj6 = 120;
				}
				else
				{
					object obj6 = 144;
				}
				Vector3 vector = transform.TransformPoint((Vector3)0);
				if (was != null)
				{
					bool flag = (nint)obj3 < array.Length;
					object obj7 = !flag;
					if (obj7 != null)
					{
						break;
					}
					object obj8 = (object)was + obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v129 @ X8_v5]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v124 @ X9_v4]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v54 @ X10_v4]");
					obj8 = 0;
					Vector3[] array2 = swung;
					if (swung != null)
					{
						bool flag2 = (nint)obj3 < array2.Length;
						object obj9 = !flag2;
						if (obj9 != null)
						{
							break;
						}
						object obj10 = obj;
						object obj11 = (object)swung + obj2;
						obj2 += 12;
						obj3++;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v10+A0]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v11+8]");
						obj11 = 0;
						if ((nint)obj2 == 64)
						{
							return;
						}
						continue;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	private void LateUpdate()
	{
		//IL_032f: Expected Obj, but got I
		//IL_0037: Invalid comparison between F4 and I4
		//IL_0048: Expected Obj, but got I4
		//IL_0051: Invalid comparison between F4 and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_0298: Invalid comparison between F4 and I4
		//IL_0156: Expected I4, but got I8
		//IL_0170: Expected Obj, but got I4
		//IL_02c1: Expected I4, but got I8
		//IL_02db: Expected Obj, but got I4
		//IL_01c2: Invalid comparison between F4 and I4
		//IL_01d1: Invalid comparison between F4 and I4
		//IL_01e6: Expected Obj, but got F4
		//IL_01f5: Expected Obj, but got F4
		//IL_022a: Expected Obj, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		bool live = Live;
		bool flag = !live;
		IntPtr intPtr = default;
		NetworkObject networkObject = (NetworkObject)(nint)intPtr;
		if (!flag)
		{
			networkObject = ((SimulationBehaviour)this)._object;
			holder.Watch(((SimulationBehaviour)this)._object);
		}
		float deltaTime = Time.deltaTime;
		bool flag2 = deltaTime < 0f;
		object obj = !flag2;
		bool flag3 = deltaTime == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag3;
		if (obj3 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (item == null)
		{
			return;
		}
		GillaItem gillaItem = item;
		int num = gillaItem.Hand__BackingField;
		if (gillaItem.Hand__BackingField != heldWas)
		{
			int num2 = (int)(gillaItem.Hand__BackingField & 0x80000000L);
			bool flag5 = num2 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				float time = Time.time;
				gillaItem = item;
				float num3 = time;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				float num4 = num3 + 0f;
				float num5 = againAt - num4;
				bool flag6 = num5 < 0f;
				bool flag7 = num5 == 0f;
				object obj8 = againAt ^ num4;
				object obj9 = againAt ^ num5;
				object obj10 = obj8 & obj9;
				bool flag8 = (nint)obj10 < 0;
				bool flag9 = flag6 == flag8;
				object obj11 = !flag7;
				object obj12 = flag9 & obj11;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					num4 = againAt;
				}
				againAt = num4;
			}
			num = gillaItem.Hand__BackingField;
			heldWas = gillaItem.Hand__BackingField;
		}
		if (into != 0)
		{
			InIt(deltaTime);
		}
		else
		{
			if (comeFor > 0f)
			{
				int num6 = (int)(num & 0x80000000L);
				bool flag10 = num6 == 0;
				object obj14 = !flag10;
				if (obj14 == null)
				{
					CameFrom(deltaTime);
				}
			}
			Swings(deltaTime);
		}
		Wets();
	}

	private void Swings(float dt)
	{
		//IL_0046: Expected Obj, but got I4
		//IL_0a8f: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I4
		//IL_0aeb: Expected VT, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_02e0: Invalid comparison between F4 and I4
		//IL_03cd: Expected Obj, but got I4
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_041b: Invalid comparison between F4 and I
		//IL_0321: Expected Obj, but got I4
		//IL_044e: Expected Obj, but got I4
		//IL_045e: Expected Obj, but got I
		//IL_034e: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I
		//IL_04ab: Expected Obj, but got I4
		//IL_0565: Expected Obj, but got I4
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected Obj, but got Unknown
		//IL_04e5: Expected Obj, but got I
		//IL_0502: Expected Obj, but got I
		//IL_0592: Expected Obj, but got F4
		//IL_064d: Expected Obj, but got I4
		//IL_05df: Expected Obj, but got I4
		//IL_0b83: Expected Obj, but got I
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected Obj, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected Obj, but got Unknown
		//IL_06c2: Expected Obj, but got I4
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		//IL_0a48: Expected Obj, but got I4
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Expected Obj, but got Unknown
		//IL_0741: Expected I4, but got I8
		//IL_0799: Expected F4, but got I
		//IL_0799: Expected VT, but got I4
		//IL_07b7: Expected Obj, but got I4
		//IL_07cf: Expected Obj, but got I
		//IL_07df: Expected Obj, but got I
		//IL_07ef: Expected Obj, but got I
		//IL_0807: Expected Obj, but got I
		//IL_0817: Expected Obj, but got I
		//IL_0827: Expected Obj, but got I
		//IL_0989: Expected I4, but got I8
		//IL_09a3: Expected Obj, but got I4
		//IL_08ba: Expected Obj, but got I4
		//IL_08ed: Expected F4, but got I
		//IL_090b: Expected Obj, but got I4
		//IL_091b: Expected Obj, but got I
		//IL_092b: Expected Obj, but got I
		//IL_093b: Expected Obj, but got I
		if ((object)item != null)
		{
			bool mine = item.Mine;
			bool flag = !mine;
			object obj = 1;
			if (!flag)
			{
				GillaItem gillaItem = item;
				if ((object)item == null)
				{
					goto IL_0a71;
				}
				bool flag2 = (byte)(~(gillaItem.Gone__BackingField ? 1u : 0u)) != 0;
				object obj2 = !flag2;
				obj = 1;
				if (obj2 == null)
				{
					bool flag3 = !gillaItem.Swallowed__BackingField;
					object obj3 = !flag3;
					obj = obj3;
				}
			}
			object obj4 = 40;
			int num = 0;
			object obj28 = default;
			float num20 = default;
			object obj43 = default;
			object obj45 = default;
			object obj47 = default;
			Vector3 vector2 = default;
			Vector3 to = default;
			Vector3 going = default;
			while (true)
			{
				Vector3[] array = was;
				if (was == null)
				{
					break;
				}
				bool flag4 = num < array.Length;
				object obj5 = !flag4;
				float num4;
				Vector3[] array5;
				if (obj5 == null)
				{
					object obj6 = (object)was + obj4;
					Transform transform = base.transform;
					if ((object)transform == null)
					{
						break;
					}
					if ((nint)obj4 == 40)
					{
						object obj7 = 112;
					}
					else
					{
						object obj7 = 136;
					}
					if ((nint)obj4 == 40)
					{
						object obj8 = 116;
					}
					else
					{
						object obj8 = 140;
					}
					if ((nint)obj4 == 40)
					{
						object obj9 = 120;
					}
					else
					{
						object obj9 = 144;
					}
					Vector3 vector = transform.TransformPoint((Vector3)0);
					Vector3[] array2 = was;
					if (was == null)
					{
						break;
					}
					bool flag5 = num < array2.Length;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v659 @ X8_v9]");
						float num2 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v7-8]");
						float num3 = num2 - 0f;
						object obj11 = (object)was + obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v168 @ X10_v4]");
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v659 @ X8_v9]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v308 @ X9_v6]");
						_ = 0;
						num4 = num3 / dt;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v308 @ X9_v6]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v7-4]");
						object obj12 = num5 - 0;
						float num6 = (float)obj12 / dt;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v168 @ X10_v4]");
						object obj13 = 0 - obj6;
						float num7 = (float)obj13 / dt;
						float num8 = num4 * num4;
						float num9 = num6 * num6;
						float num10 = num8 + num9;
						float num11 = num7 * num7;
						float num12 = num11 + num10;
						if (num12 > 1.1539579E+09f)
						{
							Vector3[] array3 = swung;
							if (swung == null)
							{
								break;
							}
							bool flag6 = num < array3.Length;
							object obj14 = !flag6;
							if (obj14 == null)
							{
								object obj15 = (object)swung + obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj16 = 0;
								object obj17 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v48+A0]");
								object obj18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v49+8]");
								obj15 = 0;
								goto IL_0b37;
							}
						}
						else
						{
							float time = Time.time;
							float[] array4 = swungAt;
							if (swungAt == null)
							{
								break;
							}
							bool flag7 = num < array4.Length;
							object obj19 = !flag7;
							if (obj19 == null)
							{
								object obj20 = swungAt + num;
								array5 = swung;
								float num13 = time;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v15+20]");
								float num14 = num13 - 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD80]");
								object obj22;
								if (num14 > 0f)
								{
									bool flag8 = swung == null;
									object obj21 = !flag8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD80]");
									obj22 = 0;
									if (obj21 == null)
									{
										break;
									}
								}
								else
								{
									if (swung == null)
									{
										break;
									}
									bool flag9 = num < array5.Length;
									object obj23 = !flag9;
									if (obj23 != null)
									{
										goto IL_0a7f;
									}
									object obj24 = (object)swung + obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v41-8]");
									nint num15 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v41-8]");
									object obj25 = num15 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v41-4]");
									nint num16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v41-4]");
									object obj26 = num16 * 0;
									object obj27 = obj25 + obj26;
									float num17 = (float)obj27 + (float)obj28;
									bool flag10 = num12 < num17;
									obj22 = obj28;
									object obj29 = obj28;
									if (flag10)
									{
										goto IL_0632;
									}
								}
								bool flag11 = num < array5.Length;
								object obj30 = !flag11;
								if (obj30 == null)
								{
									object obj31 = (object)array5 + obj4;
									obj31 = num7;
									float[] array6 = swungAt;
									float num17 = Time.time;
									if (swungAt == null)
									{
										break;
									}
									bool flag12 = num < array6.Length;
									object obj32 = !flag12;
									if (obj32 == null)
									{
										object obj33 = swungAt + num;
										array5 = swung;
										bool flag13 = swung == null;
										object obj29 = obj22;
										if (flag13)
										{
											break;
										}
										goto IL_0632;
									}
								}
							}
						}
					}
				}
				goto IL_0a7f;
				IL_0a04:
				bool[] array7 = scraping;
				if (scraping == null)
				{
					break;
				}
				bool flag14 = num < array7.Length;
				object obj34 = !flag14;
				if (obj34 != null)
				{
					goto IL_0a7f;
				}
				object obj35 = scraping + num;
				_ = 0;
				goto IL_0b37;
				IL_0b37:
				obj4 += 12;
				num++;
				if ((nint)obj4 == 64)
				{
					return;
				}
				continue;
				IL_0632:
				bool flag15 = num < array5.Length;
				object obj36 = !flag15;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj37 = 0;
					object obj38 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X0_v16+E4]");
					if ((nint)0 != 0)
					{
						object obj39 = obj & 1;
						if (obj39 == null)
						{
							goto IL_06d0;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj40 = obj & 1;
						bool flag16 = obj40 == null;
						object obj41 = !flag16;
						if (obj41 == null)
						{
							goto IL_06d0;
						}
					}
					goto IL_0a04;
				}
				goto IL_0a7f;
				IL_06d0:
				float time2 = Time.time;
				if (!(time2 < againAt))
				{
					GillaItem gillaItem2 = item;
					if ((object)item == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					int num18 = (int)(gillaItem2.Hand__BackingField & 0x80000000L);
					bool flag17 = num18 == 0;
					float num19 = num20;
					object obj42 = obj43;
					object obj44 = obj45;
					object obj46 = obj47;
					if (!flag17)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v7-8]");
						bool flag18 = Clangs((Vector3)0, vector2, 0f);
						bool flag19 = !flag18;
						object obj48 = !flag19;
						num19 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v168 @ X10_v4]");
						obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v308 @ X9_v6]");
						obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v659 @ X8_v9]");
						obj46 = 0;
						num20 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v168 @ X10_v4]");
						obj43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v308 @ X9_v6]");
						obj45 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v659 @ X8_v9]");
						obj47 = 0;
						if (obj48 != null)
						{
							goto IL_0b37;
						}
					}
					float num21 = knockSpeed;
					if (!(knockSpeed < stabSpeed))
					{
						num21 = stabSpeed;
					}
					if (!(num4 < num21))
					{
						Vector3[] array8 = swung;
						if (swung == null)
						{
							break;
						}
						bool flag20 = num < array8.Length;
						object obj49 = !flag20;
						if (obj49 != null)
						{
							goto IL_0a7f;
						}
						int e = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v7-8]");
						bool flag21 = Looks(e, vector2, to, going, 0f);
						bool flag22 = !flag21;
						object obj50 = !flag22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v168 @ X10_v4]");
						obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v308 @ X9_v6]");
						obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v659 @ X8_v9]");
						obj46 = 0;
						if (obj50 != null)
						{
							return;
						}
					}
					GillaItem gillaItem3 = item;
					if ((object)item == null)
					{
						break;
					}
					int num22 = (int)(gillaItem3.Hand__BackingField & 0x80000000L);
					bool flag23 = num22 == 0;
					object obj51 = !flag23;
					num20 = num19;
					obj43 = obj42;
					obj45 = obj44;
					obj47 = obj46;
					if (obj51 == null)
					{
						Scrapes(num, vector2);
						num20 = num19;
						obj43 = obj42;
						obj45 = obj44;
						obj47 = obj46;
						goto IL_0b37;
					}
				}
				goto IL_0a04;
			}
		}
		goto IL_0a71;
		IL_0a71:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0a7f;
		IL_0a7f:
		throw new IndexOutOfRangeException();
	}

	private unsafe void HeldKnock(Vector3 at, Vector3 faces, float speed, Collider on)
	{
		//IL_004d: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_087b: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_089d: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I4
		//IL_08c2: Expected VT, but got I4
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected Obj, but got Unknown
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Expected Obj, but got Unknown
		//IL_0960: Invalid comparison between F4 and I
		//IL_0113: Expected Obj, but got I4
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected Obj, but got Unknown
		//IL_099f: Expected Obj, but got I4
		//IL_09a8: Expected Obj, but got I4
		//IL_09b1: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I
		//IL_02c8: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got VT
		//IL_030b: Expected VT, but got I4
		//IL_0314: Expected VT, but got I4
		//IL_016a: Expected Obj, but got I4
		//IL_048c: Expected Obj, but got I4
		//IL_04b3: Expected Obj, but got VT
		//IL_04cf: Expected VT, but got I4
		//IL_0345: Expected VT, but got I4
		//IL_034e: Expected VT, but got I4
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected Obj, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected Obj, but got Unknown
		//IL_09fa: Expected Obj, but got I
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected Obj, but got Unknown
		//IL_0a35: Expected Obj, but got I
		//IL_0a57: Expected Obj, but got I4
		//IL_04fb: Expected VT, but got I4
		//IL_0365: Invalid comparison between VT and I4
		//IL_01e4: Invalid comparison between F4 and I4
		//IL_01f3: Invalid comparison between F4 and I4
		//IL_0206: Expected Obj, but got F4
		//IL_0213: Expected Obj, but got F4
		//IL_0248: Expected Obj, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0695: Expected Obj, but got I4
		//IL_0517: Invalid comparison between VT and I4
		//IL_0389: Expected Obj, but got I
		//IL_0391: Expected VT, but got Obj
		//IL_03b3: Expected VT, but got I4
		//IL_06bc: Expected Obj, but got VT
		//IL_0615: Expected VT, but got I4
		//IL_053b: Expected Obj, but got I
		//IL_0543: Expected VT, but got Obj
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected Obj, but got Unknown
		//IL_0572: Expected Obj, but got Ref
		//IL_03de: Expected VT, but got I4
		//IL_06ed: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I4
		//IL_073d: Expected Obj, but got VT
		//IL_03f6: Expected VT, but got I4
		//IL_040e: Expected I4, but got Obj
		//IL_040e: Expected VT, but got I4
		//IL_040e: Expected VT, but got I4
		//IL_041e: Expected F4, but got I
		//IL_042e: Expected F4, but got I
		//IL_044c: Expected F4, but got I
		//IL_044c: Expected F4, but got I
		//IL_0455: Expected VT, but got I4
		//IL_0801: Expected I4, but got Obj
		//IL_0801: Expected VT, but got I4
		//IL_0801: Expected VT, but got I4
		//IL_0798: Invalid comparison between F4 and I4
		//IL_07e5: Expected VT, but got I
		//IL_07e5: Expected I4, but got Obj
		//IL_07e5: Expected VT, but got Ref
		//IL_07e5: Expected VT, but got I4
		//IL_05b3: Expected Obj, but got Ref
		//IL_0818: Expected VT, but got Obj
		//IL_0818: Expected VT, but got I4
		//IL_0836: Expected F4, but got I
		//IL_0836: Expected F4, but got I
		float num;
		object obj21 = default;
		if ((object)item != null)
		{
			if (!item.Mine)
			{
				return;
			}
			bool flag = into == 0;
			object obj = !flag;
			if (obj != null)
			{
				return;
			}
			object obj2 = 0;
			object obj3 = 1;
			object obj5 = default;
			object obj4 = obj5;
			Vector3[] array = (Vector3[])109891584;
			object obj7 = default;
			object obj6 = obj7;
			float num2 = default;
			num = num2;
			object obj19 = default;
			float num9 = default;
			while (true)
			{
				Transform transform = base.transform;
				if ((object)transform == null)
				{
					break;
				}
				object obj8 = obj3 & 1;
				bool flag2 = obj8 == null;
				object obj9 = !flag2;
				object obj10 = ~obj9;
				if (obj10 == null)
				{
					object obj11 = 112;
				}
				else
				{
					object obj11 = 136;
				}
				object obj12 = !flag2;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					object obj14 = 116;
				}
				else
				{
					object obj14 = 140;
				}
				object obj15 = !flag2;
				object obj16 = ~obj15;
				if (obj16 == null)
				{
					object obj17 = 120;
				}
				else
				{
					object obj17 = 144;
				}
				Vector3 vector = transform.TransformPoint((Vector3)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v251 @ X8_v10]");
				float num3 = 0f - speed;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v153 @ X9_v5]");
				object obj18 = 0 - obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v148 @ X10_v5]");
				object obj20 = 0 - obj21;
				float num4 = num3 * num3;
				object obj22 = obj18 * obj18;
				float num5 = num4 + (float)obj22;
				float num6 = (float)obj20 * (float)obj20;
				float num7 = num6 + num5;
				float num8 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
				if (num8 < 0f)
				{
					array = swung;
					if (swung == null)
					{
						break;
					}
					bool flag3 = (nint)obj2 < array.Length;
					object obj23 = !flag3;
					if (obj23 != null)
					{
						goto IL_084a;
					}
					object obj24 = swung + 32;
					object obj25 = obj2 * 12;
					object obj26 = obj24 + obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj27 = 0;
					object obj28 = obj2 * 12;
					object obj29 = obj24 + obj28;
					object obj30 = obj27;
					obj6 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v37+4]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v52+E4]");
					bool flag4 = (nint)0 == 0;
					object obj31 = !flag4;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj32 = obj6 * obj6;
					object obj33 = obj4 * obj4;
					object obj34 = obj32 + obj33;
					num7 = (float)obj34 + num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num10 = num - num7;
					bool flag5 = num10 < 0f;
					bool flag6 = num10 == 0f;
					object obj35 = num ^ num7;
					object obj36 = num ^ num10;
					object obj37 = obj35 & obj36;
					bool flag7 = (nint)obj37 < 0;
					bool flag8 = flag5 == flag7;
					object obj38 = !flag6;
					object obj39 = flag8 & obj38;
					object obj40 = ~obj39;
					if (obj40 == null)
					{
						num6 = num9;
					}
					else
					{
						num6 = num9;
						num = num7;
					}
				}
				object obj41 = obj3 & 1;
				bool flag9 = obj41 == null;
				object obj42 = !flag9;
				obj2 = 1;
				obj3 = 0;
				if (obj42 != null)
				{
					continue;
				}
				goto IL_028e;
			}
		}
		goto IL_083c;
		IL_028e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj43 = 0;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v14+E4]");
		bool flag10 = (nint)0 == 0;
		object obj45 = !flag10;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = (UnityEngine.Object)at != null;
		bool flag12 = !flag11;
		Vector3 vector2 = (Vector3)0;
		Vector3 vector3 = (Vector3)0;
		if (!flag12)
		{
			float num7 = glassSpeed;
			bool flag13 = num < glassSpeed;
			vector2 = (Vector3)0;
			vector3 = (Vector3)0;
			if (!flag13)
			{
				if (at == (Vector3)(object)0)
				{
					goto IL_083c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B90]");
				object obj46 = 0;
				vector3 = (Vector3)obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
				GillaOre gillaOre = default;
				bool flag14 = (object)gillaOre == null;
				vector2 = (Vector3)0;
				if (!flag14)
				{
					bool flag15 = gillaOre.Shown__BackingField == 0;
					vector2 = (Vector3)0;
					if (!flag15)
					{
						vector3 = (Vector3)miningDamage;
						gillaOre.Struck((Vector3)miningDamage, (Vector3)0, (int)on);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
						num7 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
						float num6 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
						nint num11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
						Buzz(num11, 0f);
						vector2 = (Vector3)0;
						object obj20 = obj21;
					}
				}
			}
		}
		object obj47 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v19+E4]");
		bool flag16 = (nint)0 == 0;
		object obj48 = !flag16;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = (UnityEngine.Object)at != null;
		bool flag18 = !flag17;
		Vector3 vector4 = (Vector3)0;
		UnityEngine.Object obj49 = null;
		if (!flag18)
		{
			bool flag19 = num < glassSpeed;
			vector4 = (Vector3)0;
			obj49 = null;
			if (!flag19)
			{
				if (at == (Vector3)(object)0)
				{
					goto IL_083c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B98]");
				object obj50 = 0;
				vector4 = (Vector3)obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
				object obj52 = default;
				object obj51 = obj52 & 1;
				bool flag20 = obj51 == null;
				GillaGlass gillaGlass = default;
				obj49 = (UnityEngine.Object)(&gillaGlass);
				if (!flag20)
				{
					if ((object)gillaGlass == null)
					{
						goto IL_083c;
					}
					bool flag21 = (byte)(~(gillaGlass.broken ? 1u : 0u)) != 0;
					obj49 = (UnityEngine.Object)(&gillaGlass);
					if (flag21)
					{
						gillaGlass.Struck((Vector3)0, (Vector3)obj50);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						nint num12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
						Buzz(num12, 0f);
						return;
					}
				}
			}
		}
		if (num < knockSpeed)
		{
			if ((object)item != null)
			{
				item.Knock((Vector3)0, speed);
				return;
			}
			goto IL_083c;
		}
		float time = Time.time;
		if (time < clangAt)
		{
			return;
		}
		float time2 = Time.time;
		object obj53 = obj43;
		float num13 = time2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		float num14 = num13 + 0f;
		clangAt = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v26+E4]");
		bool flag22 = (nint)0 == 0;
		object obj54 = !flag22;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte b2;
		if ((UnityEngine.Object)at != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
			object obj55 = 0;
			object obj56 = obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X0_v35+E4]");
			bool flag23 = (nint)0 == 0;
			object obj57 = !flag23;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			byte b = StuffOf((Collider)at);
			b2 = b;
		}
		else
		{
			b2 = 1;
		}
		if (knockSpeed != hardSpeed)
		{
			float num15 = num - knockSpeed;
			float num16 = hardSpeed - knockSpeed;
			float num17 = num15 / num16;
			if (!(num17 < 0f) && (double)num17 > 1.0)
			{
				goto IL_07cb;
			}
		}
		if (!Live)
		{
			Clang((Vector3)b2, (Vector3)0, (byte)(int)on, speed);
			return;
		}
		goto IL_07cb;
		IL_083c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_084a;
		IL_084a:
		throw new IndexOutOfRangeException();
		IL_07cb:
		object obj58 = default;
		IntPtr intPtr = default;
		RPC_Clang((Vector3)b2, (Vector3)(&obj58), (byte)(int)on, speed, (RpcInfo)(nint)intPtr);
	}

	private unsafe bool Clangs(Vector3 from, Vector3 to, float speed)
	{
		//IL_0256: Invalid comparison between F4 and Obj
		//IL_003c: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_00a3: Expected VT, but got I8
		//IL_00a3: Expected VT, but got Ref
		//IL_0110: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I4
		//IL_0239: Expected F4, but got VT
		//IL_0239: Expected VT, but got I4
		//IL_0239: Expected VT, but got I4
		//IL_01c0: Invalid comparison between F4 and I4
		//IL_020e: Expected VT, but got I4
		//IL_020e: Expected F4, but got VT
		//IL_020e: Expected VT, but got Ref
		//IL_020e: Expected VT, but got I4
		float num = knockSpeed;
		object obj = default;
		RaycastHit raycastHit = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		byte b;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			float time = Time.time;
			if (!(time < clangAt))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (Physics.Linecast((Vector3)(&raycastHit), (Vector3)4294961403L, out *(RaycastHit*)1, 0, queryTriggerInteraction))
				{
					float time2 = Time.time;
					float num2 = time2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
					float num3 = num2 + 0f;
					clangAt = num3;
					Collider collider = raycastHit.collider;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
					object obj5 = 0;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					b = StuffOf(collider);
					if (knockSpeed != hardSpeed)
					{
						float num4 = (float)obj - knockSpeed;
						float num5 = hardSpeed - knockSpeed;
						float num6 = num4 / num5;
						if (!(num6 < 0f) && (double)num6 > 1.0)
						{
							goto IL_01f3;
						}
					}
					if (!Live)
					{
						Clang((Vector3)b, (Vector3)1, 0, (float)raycastHit);
						goto IL_023e;
					}
					goto IL_01f3;
				}
			}
		}
		return false;
		IL_023e:
		return true;
		IL_01f3:
		object obj8 = default;
		RPC_Clang((Vector3)b, (Vector3)(&obj8), 0, (float)raycastHit, (RpcInfo)queryTriggerInteraction);
		goto IL_023e;
	}

	internal static byte StuffOf(Collider c)
	{
		//IL_0d71: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I
		//IL_0d9e: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_0252: Expected Obj, but got I8
		//IL_027f: Expected Obj, but got I
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_02c1: Expected Obj, but got I4
		//IL_02d7: Expected Obj, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_031a: Expected Obj, but got I
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_0354: Expected Obj, but got I8
		//IL_01b9: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_03c3: Expected Obj, but got I4
		//IL_03d9: Expected Obj, but got I
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_041c: Expected Obj, but got I
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_045e: Expected Obj, but got I4
		//IL_0474: Expected Obj, but got I
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_04b7: Expected Obj, but got I
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04f9: Expected Obj, but got I4
		//IL_050f: Expected Obj, but got I
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected Obj, but got Unknown
		//IL_0552: Expected Obj, but got I
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_058c: Expected Obj, but got I8
		//IL_05b9: Expected Obj, but got I
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05fb: Expected Obj, but got I4
		//IL_0611: Expected Obj, but got I
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_0654: Expected Obj, but got I
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected Obj, but got Unknown
		//IL_06b3: Expected Obj, but got I8
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected Obj, but got Unknown
		//IL_06ca: Expected Obj, but got I4
		//IL_0dde: Expected Obj, but got I4
		//IL_07d4: Expected Obj, but got I
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected Obj, but got Unknown
		//IL_080e: Expected Obj, but got I8
		//IL_083b: Expected Obj, but got I
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected Obj, but got Unknown
		//IL_087d: Expected Obj, but got I4
		//IL_0893: Expected Obj, but got I
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_0701: Expected Obj, but got I
		//IL_071f: Expected Obj, but got I4
		//IL_08d6: Expected Obj, but got I
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected Obj, but got Unknown
		//IL_0910: Expected Obj, but got I8
		//IL_073d: Expected Obj, but got I
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected Obj, but got Unknown
		//IL_076a: Expected Obj, but got I4
		//IL_093d: Expected Obj, but got I
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected Obj, but got Unknown
		//IL_097f: Expected Obj, but got I4
		//IL_0995: Expected Obj, but got I
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected Obj, but got Unknown
		//IL_09d8: Expected Obj, but got I
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Expected Obj, but got Unknown
		//IL_0a1a: Expected Obj, but got I4
		//IL_0a30: Expected Obj, but got I
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Expected Obj, but got Unknown
		//IL_0a73: Expected Obj, but got I
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Expected Obj, but got Unknown
		//IL_0ab5: Expected Obj, but got I4
		//IL_0acb: Expected Obj, but got I
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af0: Expected Obj, but got Unknown
		//IL_0b0e: Expected Obj, but got I
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Expected Obj, but got Unknown
		//IL_0b48: Expected Obj, but got I8
		//IL_0b75: Expected Obj, but got I
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected Obj, but got Unknown
		//IL_0bb7: Expected Obj, but got I4
		//IL_0bcd: Expected Obj, but got I
		//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected Obj, but got Unknown
		//IL_0c10: Expected Obj, but got I
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected Obj, but got Unknown
		//IL_0c6f: Expected Obj, but got I8
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected Obj, but got Unknown
		//IL_0c86: Expected Obj, but got I4
		//IL_0e05: Expected Obj, but got I4
		//IL_0cbd: Expected Obj, but got I
		//IL_0cdb: Expected Obj, but got I4
		//IL_0cf9: Expected Obj, but got I
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected Obj, but got Unknown
		string text3;
		if ((object)c != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4408]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v6+E4]");
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
			if (flag3)
			{
				goto IL_01c6;
			}
			if ((object)obj5 != null)
			{
				Material sharedMaterial = ((Renderer)obj5).sharedMaterial;
				object obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v77+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = sharedMaterial != null;
				bool flag6 = !flag5;
				obj6 = 0;
				if (flag6)
				{
					goto IL_01c6;
				}
				Material sharedMaterial2 = ((Renderer)obj5).sharedMaterial;
				if ((object)sharedMaterial2 != null)
				{
					string text = sharedMaterial2.name;
					if (text != null)
					{
						string text2 = text.ToLowerInvariant();
						obj6 = 0;
						text3 = text2;
						goto IL_0d8e;
					}
				}
			}
		}
		goto IL_0d63;
		IL_0d8e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = default;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45A0]");
				object obj11 = 0;
				object obj12 = obj10 + 32;
				obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X21_v4-8]");
				object obj13 = 0 & 0xFFFFFFFEL;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4590]");
					object obj14 = 0;
					object obj15 = obj10 + 40;
					obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X21_v6-10]");
					bool flag7 = (nint)0 < (nint)2;
					object obj16 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X21_v6-10]");
					object obj17 = -2;
					bool flag8 = obj17 == null;
					object obj18 = ~obj16;
					object obj19 = obj18 | flag8;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BC0]");
						object obj20 = 0;
						object obj21 = obj10 + 48;
						obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X21_v8-18]");
						object obj22 = 0 & 0xFFFFFFFCL;
						if (obj22 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4558]");
							object obj23 = 0;
							object obj24 = obj10 + 56;
							obj24 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X21_v10-20]");
							bool flag9 = (nint)0 < (nint)4;
							object obj25 = !flag9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X21_v10-20]");
							object obj26 = -4;
							bool flag10 = obj26 == null;
							object obj27 = ~obj25;
							object obj28 = obj27 | flag10;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4520]");
								object obj29 = 0;
								object obj30 = obj10 + 64;
								obj30 = obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X21_v12-28]");
								bool flag11 = (nint)0 < (nint)5;
								object obj31 = !flag11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X21_v12-28]");
								object obj32 = -5;
								bool flag12 = obj32 == null;
								object obj33 = ~obj31;
								object obj34 = obj33 | flag12;
								if (obj34 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BB0]");
									object obj35 = 0;
									object obj36 = obj10 + 72;
									obj36 = obj35;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X21_v14-30]");
									bool flag13 = (nint)0 < (nint)6;
									object obj37 = !flag13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X21_v14-30]");
									object obj38 = -6;
									bool flag14 = obj38 == null;
									object obj39 = ~obj37;
									object obj40 = obj39 | flag14;
									if (obj40 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BB8]");
										object obj41 = 0;
										object obj42 = obj10 + 80;
										obj42 = obj41;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X21_v16-38]");
										object obj43 = 0 & 0xFFFFFFF8L;
										if (obj43 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4560]");
											object obj44 = 0;
											object obj45 = obj10 + 88;
											obj45 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X21_v18-40]");
											bool flag15 = (nint)0 < (nint)8;
											object obj46 = !flag15;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X21_v18-40]");
											object obj47 = -8;
											bool flag16 = obj47 == null;
											object obj48 = ~obj46;
											object obj49 = obj48 | flag16;
											if (obj49 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BA0]");
												object obj50 = 0;
												object obj51 = obj10 + 96;
												obj51 = obj50;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X21_v20-48]");
												if ((nint)0 < (nint)1)
												{
													goto IL_0778;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X21_v20-48]");
												object obj52 = 0 & 0xFFFFFFFFL;
												object obj53 = obj10 + 32;
												object obj54 = 0;
												while (true)
												{
													bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj52);
													object obj55 = !flag17;
													if (obj55 != null)
													{
														break;
													}
													if (text3 != null)
													{
														string text4 = text3;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X23_v6+v116 @ X21_v47*8]");
														bool flag18 = text4.Contains((string)0);
														bool flag19 = !flag18;
														object obj56 = !flag19;
														if (obj56 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11+18]");
															obj52 = 0;
															obj54++;
															object obj57 = obj54;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11+18]");
															bool flag20 = (nint)obj57 < 0;
															object obj6 = 0;
															if (flag20)
															{
																continue;
															}
															goto IL_0778;
														}
														return 2;
													}
													goto IL_0d63;
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
			goto IL_0d55;
		}
		goto IL_0d63;
		IL_0d2b:
		return 1;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj58 = 0;
		text3 = (string)obj58;
		goto IL_0d8e;
		IL_0778:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj59 = default;
		if (obj59 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v35+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44C8]");
				object obj60 = 0;
				object obj61 = obj59 + 32;
				obj61 = obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X21_v25-8]");
				object obj62 = 0 & 0xFFFFFFFEL;
				if (obj62 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44A8]");
					object obj63 = 0;
					object obj64 = obj59 + 40;
					obj64 = obj63;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X21_v27-10]");
					bool flag21 = (nint)0 < (nint)2;
					object obj65 = !flag21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X21_v27-10]");
					object obj66 = -2;
					bool flag22 = obj66 == null;
					object obj67 = ~obj65;
					object obj68 = obj67 | flag22;
					if (obj68 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44B0]");
						object obj69 = 0;
						object obj70 = obj59 + 48;
						obj70 = obj69;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X21_v29-18]");
						object obj71 = 0 & 0xFFFFFFFCL;
						if (obj71 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4580]");
							object obj72 = 0;
							object obj73 = obj59 + 56;
							obj73 = obj72;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X21_v31-20]");
							bool flag23 = (nint)0 < (nint)4;
							object obj74 = !flag23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X21_v31-20]");
							object obj75 = -4;
							bool flag24 = obj75 == null;
							object obj76 = ~obj74;
							object obj77 = obj76 | flag24;
							if (obj77 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4490]");
								object obj78 = 0;
								object obj79 = obj59 + 64;
								obj79 = obj78;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X21_v33-28]");
								bool flag25 = (nint)0 < (nint)5;
								object obj80 = !flag25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X21_v33-28]");
								object obj81 = -5;
								bool flag26 = obj81 == null;
								object obj82 = ~obj80;
								object obj83 = obj82 | flag26;
								if (obj83 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4498]");
									object obj84 = 0;
									object obj85 = obj59 + 72;
									obj85 = obj84;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X21_v35-30]");
									bool flag27 = (nint)0 < (nint)6;
									object obj86 = !flag27;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X21_v35-30]");
									object obj87 = -6;
									bool flag28 = obj87 == null;
									object obj88 = ~obj86;
									object obj89 = obj88 | flag28;
									if (obj89 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4510]");
										object obj90 = 0;
										object obj91 = obj59 + 80;
										obj91 = obj90;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X21_v37-38]");
										object obj92 = 0 & 0xFFFFFFF8L;
										if (obj92 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44E0]");
											object obj93 = 0;
											object obj94 = obj59 + 88;
											obj94 = obj93;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X21_v39-40]");
											bool flag29 = (nint)0 < (nint)8;
											object obj95 = !flag29;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X21_v39-40]");
											object obj96 = -8;
											bool flag30 = obj96 == null;
											object obj97 = ~obj95;
											object obj98 = obj97 | flag30;
											if (obj98 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BA8]");
												object obj99 = 0;
												object obj100 = obj59 + 96;
												obj100 = obj99;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X21_v41-48]");
												if ((nint)0 < (nint)1)
												{
													goto IL_0d2b;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X21_v41-48]");
												object obj101 = 0 & 0xFFFFFFFFL;
												object obj102 = obj59 + 32;
												object obj103 = 0;
												while (true)
												{
													bool flag31 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj103) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj101);
													object obj104 = !flag31;
													if (obj104 != null)
													{
														break;
													}
													if (text3 != null)
													{
														string text5 = text3;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X22_v8+v118 @ X21_v44*8]");
														bool flag32 = text5.Contains((string)0);
														bool flag33 = !flag32;
														object obj105 = !flag33;
														if (obj105 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v35+18]");
															obj101 = 0;
															obj103++;
															object obj106 = obj103;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v35+18]");
															if ((nint)obj106 < 0)
															{
																continue;
															}
															goto IL_0d2b;
														}
														return 0;
													}
													goto IL_0d63;
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
			goto IL_0d55;
		}
		goto IL_0d63;
		IL_0d55:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0d63;
		IL_0d63:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2;
	}

	public unsafe void RPC_Clang(Vector3 at, Vector3 normal, byte stuff, float hard, RpcInfo info = default(RpcInfo))
	{
		//IL_0300: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I4
		//IL_003d: Expected VT, but got I4
		//IL_0376: Expected Obj, but got I4
		//IL_0236: Expected VT, but got I
		//IL_03ec: Expected VT, but got I4
		//IL_03fd: Expected VT, but got I4
		//IL_005b: Expected VT, but got Ref
		//IL_0ca3: Expected Obj, but got I
		//IL_0cbb: Expected Obj, but got I
		//IL_0ccb: Expected Obj, but got I
		//IL_0cdb: Expected Obj, but got I
		//IL_0ceb: Expected Obj, but got I
		//IL_0cf4: Expected VT, but got I4
		//IL_0428: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I4
		//IL_0442: Expected I4, but got Obj
		//IL_0c29: Invalid comparison between F4 and I4
		//IL_0c38: Expected F8, but got I4
		//IL_0086: Expected VT, but got Ref
		//IL_048b: Expected Obj, but got VT
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_04b3: Expected Obj, but got I4
		//IL_0d9e: Expected Obj, but got I
		//IL_0dc8: Expected Obj, but got I4
		//IL_0d77: Invalid comparison between VT and I4
		//IL_05a4: Expected Obj, but got I4
		//IL_0a1e: Expected VT, but got F8
		//IL_028b: Expected Obj, but got I
		//IL_029b: Invalid comparison between VT and I
		//IL_00b7: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_0ad2: Invalid comparison between VT and I4
		//IL_05da: Expected Obj, but got I
		//IL_05ec: Expected VT, but got I8
		//IL_0603: Expected I, but got Obj
		//IL_09a5: Expected Obj, but got I
		//IL_09bd: Expected Obj, but got I
		//IL_09d5: Expected Obj, but got I
		//IL_09e5: Expected Obj, but got I
		//IL_09ee: Expected VT, but got I4
		//IL_0108: Expected VT, but got I4
		//IL_0626: Expected Obj, but got VT
		//IL_0640: Expected Obj, but got I4
		//IL_0659: Expected F4, but got I4
		//IL_0a46: Expected VT, but got F8
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02e2: Expected VT, but got I4
		//IL_02eb: Expected Obj, but got I4
		//IL_0ab3: Expected Obj, but got I4
		//IL_0ac4: Expected Obj, but got I4
		//IL_0735: Expected Obj, but got I4
		//IL_073e: Expected Obj, but got I4
		//IL_0746: Expected VT, but got Ref
		//IL_074e: Expected I4, but got VT
		//IL_078f: Expected VT, but got I4
		//IL_0797: Expected VT, but got F4
		//IL_079f: Expected Obj, but got Ref
		//IL_07b0: Expected Obj, but got I4
		//IL_07b8: Expected I4, but got VT
		//IL_04fe: Expected I, but got Obj
		//IL_0503: Expected VT, but got Obj
		//IL_0514: Expected VT, but got I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I4
		//IL_0b1b: Expected Ref, but got VT
		//IL_0677: Expected Obj, but got I
		//IL_0689: Expected I4, but got Obj
		//IL_0689: Expected VT, but got I4
		//IL_069b: Expected I4, but got Obj
		//IL_069b: Expected VT, but got I4
		//IL_06b0: Expected Obj, but got I
		//IL_06b8: Expected VT, but got Obj
		//IL_06d2: Expected Obj, but got I
		//IL_06da: Expected VT, but got Obj
		//IL_052b: Invalid comparison between VT and I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01cf: Expected VT, but got I4
		//IL_01d7: Expected VT, but got Ref
		//IL_0b89: Expected VT, but got I4
		//IL_0b54: Expected VT, but got I4
		//IL_0b5c: Expected Obj, but got VT
		//IL_0b65: Expected Obj, but got I4
		//IL_0812: Expected Obj, but got I
		//IL_083c: Expected Obj, but got I4
		//IL_0548: Invalid comparison between VT and I4
		//IL_0556: Expected I, but got Obj
		//IL_055b: Expected VT, but got Obj
		//IL_056c: Expected VT, but got I4
		//IL_0c56: Expected Obj, but got I
		//IL_07f4: Expected Obj, but got I4
		//IL_0df0: Expected Obj, but got I4
		//IL_0871: Expected Obj, but got I
		//IL_087a: Expected VT, but got Obj
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected I4, but got Unknown
		//IL_08b5: Expected Obj, but got I4
		//IL_0982: Expected VT, but got I4
		//IL_08ed: Expected I4, but got I8
		//IL_0904: Expected VT, but got I4
		//IL_0904: Expected VT, but got I4
		//IL_0927: Expected I, but got VT
		//IL_0930: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		float num2 = default;
		float num = num2;
		object obj2 = default;
		object obj = obj2;
		object obj4 = default;
		object obj3 = obj4;
		object obj6 = default;
		object obj5 = obj6;
		object obj8 = default;
		object obj7 = obj8;
		RpcChannel rpcChannel = (RpcChannel)0;
		Vector3 vector2 = default;
		Vector3 vector = vector2;
		int num3 = 109891584;
		object obj9 = default;
		int bytePayloadSize4;
		NetworkRunner networkRunner = default;
		int num5 = default;
		RpcInfo rpcInfo;
		object obj13 = default;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		PlayerRef playerRef;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		int num4;
		object obj12;
		object obj10;
		Fusion.RpcBuilder rpcBuilder;
		bool flag4;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj9 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			obj10 = obj9;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			flag4 = (object)networkRunner == null;
			num = num2;
			num4 = bytePayloadSize4;
			num5 = bytePayloadSize2;
			obj = obj2;
			obj3 = obj4;
			obj5 = obj6;
			obj7 = obj8;
			rpcInfo = (RpcInfo)0;
			obj12 = obj13;
			rpcBuilder = (Fusion.RpcBuilder)0;
			vector = vector2;
			num3 = bytePayloadSize;
			if (!flag4)
			{
				object obj14 = bytePayloadSize2 + bytePayloadSize;
				object obj15 = bytePayloadSize3 + bytePayloadSize4;
				int payloadByteCount = (int)(obj14 + obj15);
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(1371460200u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				networkRunner = (NetworkRunner)(rpcInvokeInfo >> 32);
				object obj16 = networkRunner - 522;
				bool flag5 = (nint)obj16 < 2;
				object obj17 = !flag5;
				object obj18 = ~obj17;
				nint num6;
				if (obj18 == null && (nint)networkRunner != 518)
				{
					bool flag6 = (nint)networkRunner != 524;
					num6 = unchecked((nint)null);
					playerRef = (PlayerRef)this;
					playerRef2 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag6)
					{
						goto IL_0618;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag7 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						num6 = unchecked((nint)null);
						playerRef = (PlayerRef)this;
						playerRef2 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag7)
						{
							goto IL_0618;
						}
					}
				}
				object obj19 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X0_v71+E4]");
				bool flag8 = (nint)0 == 0;
				object obj20 = !flag8;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BD8]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				num6 = unchecked((nint)null);
				playerRef2 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_0618;
			}
			goto IL_0a67;
		}
		goto IL_0005;
		IL_0618:
		object obj21 = rpcInvokeInfo >> 32;
		bool flag9 = obj21 == null;
		object obj22 = !flag9;
		obj7 = obj8;
		obj12 = obj13;
		float num7 = 0f;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj23 = 0;
			writer.Write((Vector3)12, (int)obj23);
			writer.Write((Vector3)12, (int)obj23);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj24 = 0;
			playerRef = (PlayerRef)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BD0]");
			object obj25 = 0;
			rpcInvokeInfo2 = (RpcInvokeInfo)obj25;
			writer.Write(num2, 4);
			int num8 = rpcBuilder3.Send();
			obj7 = obj2;
			obj12 = obj4;
			num7 = num2;
		}
		rpcBuilder3.Dispose();
		num = num2;
		object obj26 = 0;
		object obj27 = 0;
		Fusion.RpcBuilder rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder3);
		byte b = (byte)(int)playerRef;
		RpcInfo rpcInfo2 = (RpcInfo)playerRef2;
		num4 = bytePayloadSize4;
		num5 = (int)(&writer);
		obj = obj2;
		obj3 = obj4;
		obj5 = obj6;
		Vector3 vector3 = (Vector3)rpcInvokeInfo2;
		rpcInfo = (RpcInfo)0;
		rpcBuilder = (Fusion.RpcBuilder)num7;
		NullReferenceException ex = (NullReferenceException)(&rpcBuilder3);
		vector = vector2;
		obj10 = 10;
		num3 = (int)rpcInvokeInfo;
		goto IL_0d3e;
		IL_0a75:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex3 = default;
		OutOfMemoryException ex2 = ex3;
		object obj29 = default;
		OutOfMemoryException ex5 = default;
		while (true)
		{
			object obj28;
			if (rpcInfo == (RpcInfo)(object)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj26 = 1;
				obj28 = obj27;
				obj10 = 1;
			}
			else
			{
				if (rpcInfo != (RpcInfo)(object)1)
				{
					goto IL_0d1b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj28 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj27 = obj29;
			}
			((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
			if (obj28 == null)
			{
				break;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			ex2 = ex4;
			rpcInfo = (RpcInfo)0;
			goto IL_0d1b;
			IL_0d1b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			networkRunner = null;
			ex2 = ex5;
			num5 = 0;
			num3 = 0;
		}
		vector3 = vector2;
		rpcInfo = (RpcInfo)0;
		ex = (NullReferenceException)rpcBuilder4;
		obj10 = 0;
		goto IL_0d3e;
		IL_0a67:
		ex = new NullReferenceException();
		goto IL_0a75;
		IL_0d3e:
		bool flag10 = obj26 == null;
		flag4 = !flag10;
		vector2 = vector3;
		if (!flag4)
		{
			if ((nint)obj10 != 10)
			{
				bool flag11 = obj10 == null;
				object obj30 = !flag11;
				if (obj30 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj31 = 0;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X0_v6+E4]");
			bool flag12 = (nint)0 == 0;
			object obj33 = !flag12;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj32 = obj31;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X0_v6+A0]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X8_v5+18]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X8_v5+18]");
			bool flag13 = (nint)0 == 0;
			MethodBase methodBase = (MethodBase)(object)networkRunner;
			if (!flag13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BC8]");
				object obj35 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj35);
				object obj36 = obj9;
				int num9 = num3 | networkRunner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v10+E4]");
				bool flag14 = (nint)0 == 0;
				object obj37 = !flag14;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num5 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num9, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v618 @ X26_v3 (System.Int32)+18] (should have been resolved before IL gen)");
				object obj38 = default;
				obj26 = obj38;
				nint num6 = (nint)invalid2;
				rpcInfo2 = (RpcInfo)0;
				methodBase = methodFromHandle;
				object obj39 = default;
				obj7 = obj39;
			}
			bool flag15 = num3 == 0;
			object obj40 = !flag15;
			if (obj40 == null)
			{
				RpcInfo rpcInfo3 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
				b = 0;
				networkRunner = (NetworkRunner)(object)methodBase;
				vector2 = (Vector3)0;
				rpcChannel = (RpcChannel)0;
				goto IL_0005;
			}
			return;
		}
		goto IL_0a75;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X21_v7 (UnityEngine.Vector3)+18]");
		object obj41 = (nint)0 & (nint)1;
		bool flag16 = obj41 == null;
		object obj42 = !flag16;
		rpcInfo = (RpcInfo)rpcChannel;
		if (obj42 == null)
		{
			float x = default;
			if (!FromHolder((RpcInfo)(&x), scratch: false) || !ByIt((Vector3)(&x)))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj43 = 0;
			object obj44 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v102+E4]");
			bool flag17 = (nint)0 == 0;
			object obj45 = !flag17;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!NetworkApe.Sane((Vector3)0))
			{
				return;
			}
			object obj46 = at & 0xFF;
			bool flag18 = (nint)obj46 < 2;
			object obj47 = !flag18;
			object obj48 = obj46 - 2;
			bool flag19 = obj48 == null;
			object obj49 = !flag19;
			object obj50 = obj47 & obj49;
			if (obj50 != null)
			{
				return;
			}
			object obj51 = num2 & 0x7F800000;
			bool flag20 = (nint)obj51 == 2139095040;
			obj7 = obj2;
			x = vector.x;
			vector2 = (Vector3)0;
			rpcInfo = (RpcInfo)(&x);
			if (flag20)
			{
				return;
			}
		}
		object obj52 = obj6 * obj6;
		object obj53 = obj4 * obj4;
		object obj54 = obj52 + obj53;
		obj12 = obj2 * obj2;
		object obj55 = obj12 + obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		rpcBuilder = (Fusion.RpcBuilder)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		if ((nint)obj55 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj56 = 0;
			object obj57 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v89+E4]");
			bool flag21 = (nint)0 == 0;
			object obj58 = !flag21;
			if (obj58 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			obj12 = 0;
			Fusion.RpcBuilder rpcBuilder5 = rpcBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (rpcBuilder5 > (object)0)
			{
				obj5 = obj6 / rpcBuilder;
				obj3 = obj4 / rpcBuilder;
				obj = obj2 / rpcBuilder;
				vector = (Vector3)109891584;
				obj10 = 17276928;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj59 = 0;
				object obj60 = obj59;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v57+A0]");
				obj10 = 0;
				obj5 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v16+4]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v16+8]");
				obj = 0;
				vector = (Vector3)109891584;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj61 = 0;
			object obj62 = obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v44+A0]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v16+18]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v16+1C]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v16+20]");
			obj = 0;
			vector = (Vector3)109891584;
		}
		bool flag22 = num2 < 0f;
		double num10 = 0.0;
		if (!flag22)
		{
			bool flag23 = !((double)num2 > 1.0);
			num10 = num2;
			rpcBuilder = (Fusion.RpcBuilder)1.0;
			if (!flag23)
			{
				num10 = 1.0;
				rpcBuilder = (Fusion.RpcBuilder)1.0;
			}
		}
		flag4 = (object)this == null;
		num = (float)num10;
		if (!flag4)
		{
			Clang(at, vector2, b, hard);
			return;
		}
		goto IL_0a67;
	}

	private bool FromHolder(RpcInfo info, bool scratch = default(bool))
	{
		//IL_0117: Expected Obj, but got I4
		//IL_000e: Expected F8, but got I4
		//IL_00fd: Expected I4, but got Obj
		//IL_0070: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		bool flag = !scratch;
		object obj = !flag;
		object obj2 = ~obj;
		double num = ((obj2 != null) ? 12.0 : 1109393408.0);
		if (holder != null)
		{
			if (holder.Is(((SimulationBehaviour)this)._object, info.Source))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float burst = (float)num + (float)num;
				return GillaNetGuard.Spend(info.Source, scratch ? ((GillaNetGuard.Kind)1) : ((GillaNetGuard.Kind)0), (float)num, burst);
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool ByIt(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I4
		//IL_002e: Expected VT, but got I4
		//IL_0161: Expected I4, but got Obj
		//IL_0105: Expected Obj, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (NetworkApe.Sane((Vector3)0))
		{
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
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
				bool flag2 = (nint)obj14 < 1115684864;
				object obj15 = !flag2;
				object obj16 = obj14 - 1115684864;
				bool flag3 = obj16 == null;
				object obj17 = ~obj15;
				return (byte)((obj17 | flag3) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	private bool NearWhatItsIn(Into kind, int id, NetworkId thing)
	{
		//IL_0010: Expected Obj, but got I
		//IL_09db: Expected I4, but got Obj
		//IL_0023: Expected Obj, but got I4
		//IL_0564: Expected Obj, but got I
		//IL_058e: Expected Obj, but got I4
		//IL_05c8: Expected Obj, but got I
		//IL_05f2: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I4
		//IL_0642: Expected VT, but got I4
		//IL_0a90: Expected Obj, but got I
		//IL_0aa0: Expected Obj, but got I
		//IL_0aba: Expected Obj, but got I
		//IL_0acb: Expected I, but got Obj
		//IL_0893: Invalid comparison between VT and I4
		//IL_021d: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_0295: Expected VT, but got I4
		//IL_03b0: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I4
		//IL_0a72: Expected Obj, but got I4
		//IL_0453: Expected VT, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_011b: Expected VT, but got I4
		//IL_083f: Expected VT, but got I4
		//IL_0a3a: Expected Obj, but got I4
		//IL_06d5: Expected VT, but got I4
		//IL_096d: Invalid comparison between Obj and F8
		//IL_097e: Expected Obj, but got I4
		//IL_0996: Invalid comparison between F8 and I4
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected I4, but got Unknown
		//IL_0b00: Expected Obj, but got I
		//IL_0b0d: Expected VT, but got Obj
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected VT, but got Unknown
		//IL_07f3: Expected Obj, but got I4
		//IL_04a8: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected VT, but got Unknown
		//IL_0319: Expected Obj, but got I
		//IL_0321: Expected VT, but got Obj
		//IL_0334: Expected Obj, but got I4
		//IL_04d7: Expected Obj, but got I
		//IL_0500: Expected VT, but got I4
		//IL_0689: Expected Obj, but got I4
		//IL_072a: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I
		//IL_01a7: Expected VT, but got Obj
		//IL_01ba: Expected Obj, but got I4
		//IL_051e: Expected Obj, but got I
		//IL_0540: Expected Obj, but got I4
		//IL_0759: Expected Obj, but got I
		//IL_0782: Expected VT, but got I4
		//IL_07a0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass150_0 obj2 = default;
		obj2._002Ector();
		bool result;
		double num;
		Vector3? vector;
		Transform transform;
		if (obj2 != null)
		{
			object obj3 = kind & (Into)0xFF;
			obj2.id = id;
			if ((nint)obj3 <= 2)
			{
				if ((nint)obj3 != 1)
				{
					bool flag = (nint)obj3 != 2;
					result = false;
					if (flag)
					{
						goto IL_0a0b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj4 = 0;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v68+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = (UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null;
					bool flag4 = !flag3;
					object obj7 = 0;
					NetworkId networkId = (NetworkId)0;
					UnityEngine.Object obj8 = null;
					if (!flag4)
					{
						if ((object)((SimulationBehaviour)this)._runner == null)
						{
							goto IL_09cd;
						}
						networkId = (NetworkId)(thing & 0xFFFFFFFFL);
						NetworkObject networkObject = ((SimulationBehaviour)this)._runner.FindObject(networkId);
						if ((object)networkObject != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BE8]");
							object obj9 = 0;
							networkId = (NetworkId)obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
							obj7 = 0;
							UnityEngine.Object obj10 = default;
							obj8 = obj10;
						}
						else
						{
							obj7 = 0;
							obj8 = null;
						}
					}
					object obj11 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v73+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = obj8 != null;
					bool flag7 = !flag6;
					num = 8.0;
					vector = (Vector3?)(object)0;
					if (flag7)
					{
						goto IL_088a;
					}
					if ((object)obj8 != null)
					{
						object obj13 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X0_v77+E4]");
						bool flag8 = (nint)0 == 0;
						object obj14 = !flag8;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X21_v20 (UnityEngine.Object)+68]");
						bool flag9 = (UnityEngine.Object)0 != null;
						bool flag10 = !flag9;
						num = 8.0;
						vector = (Vector3?)(object)0;
						if (flag10)
						{
							goto IL_088a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X21_v20 (UnityEngine.Object)+68]");
						transform = (Transform)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X21_v20 (UnityEngine.Object)+68]");
						if ((nint)0 != 0)
						{
							goto IL_07c6;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
					object obj15 = 0;
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v50+E4]");
					bool flag11 = (nint)0 == 0;
					object obj17 = !flag11;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj16 = obj15;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v50+A0]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C10]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C18]");
					object obj20 = 0;
					Predicate<System.__Canon> predicate = default;
					predicate._002Ector((object)obj2, (IntPtr)obj20);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v27+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C00]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v27+8]");
						System.__Canon _Canon = ((List<System.__Canon>)0).Find(predicate);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj22 = 0;
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v32+E4]");
						bool flag12 = (nint)0 == 0;
						object obj24 = !flag12;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag13 = (UnityEngine.Object)(object)_Canon != null;
						bool flag14 = !flag13;
						num = 8.0;
						vector = (Vector3?)(object)0;
						if (flag14)
						{
							goto IL_088a;
						}
						if (_Canon != null)
						{
							object obj25 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X0_v58+E4]");
							bool flag15 = (nint)0 == 0;
							object obj26 = !flag15;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v54 (System.__Canon)+68]");
							bool flag16 = (UnityEngine.Object)0 != null;
							bool flag17 = !flag16;
							num = 8.0;
							vector = (Vector3?)(object)0;
							if (flag17)
							{
								goto IL_088a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v54 (System.__Canon)+68]");
							transform = (Transform)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v54 (System.__Canon)+68]");
							bool flag18 = (nint)0 == 0;
							object obj27 = !flag18;
							if (obj27 != null)
							{
								goto IL_07c6;
							}
						}
					}
				}
			}
			else if ((nint)obj3 != 3)
			{
				bool flag19 = (nint)obj3 != 4;
				result = false;
				if (flag19)
				{
					goto IL_0a0b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj28 = 0;
				object obj29 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v31+E4]");
				bool flag20 = (nint)0 == 0;
				object obj30 = !flag20;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag21 = (UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null;
				bool flag22 = !flag21;
				object obj31 = 0;
				NetworkId networkId2 = (NetworkId)0;
				UnityEngine.Object obj32 = null;
				if (!flag22)
				{
					if ((object)((SimulationBehaviour)this)._runner == null)
					{
						goto IL_09cd;
					}
					networkId2 = (NetworkId)(thing & 0xFFFFFFFFL);
					NetworkObject networkObject2 = ((SimulationBehaviour)this)._runner.FindObject(networkId2);
					if ((object)networkObject2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF0]");
						object obj33 = 0;
						networkId2 = (NetworkId)obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
						obj31 = 0;
						UnityEngine.Object obj34 = default;
						obj32 = obj34;
					}
					else
					{
						obj31 = 0;
						obj32 = null;
					}
				}
				object obj35 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v36+E4]");
				bool flag23 = (nint)0 == 0;
				object obj36 = !flag23;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag24 = obj32 != null;
				bool flag25 = !flag24;
				num = 10.0;
				vector = (Vector3?)(object)0;
				if (flag25)
				{
					goto IL_088a;
				}
				if ((object)obj32 != null)
				{
					Vector3 middle = ((MonsterBrain)obj32).Middle;
					num = 10.0;
					goto IL_0af0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
				object obj37 = 0;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v19+E4]");
				bool flag26 = (nint)0 == 0;
				object obj39 = !flag26;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaCorpse gillaCorpse = GillaCorpse.Find(id);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj40 = 0;
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v19+E4]");
				bool flag27 = (nint)0 == 0;
				object obj42 = !flag27;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag28 = gillaCorpse != null;
				bool flag29 = !flag28;
				num = 8.0;
				vector = (Vector3?)(object)0;
				if (flag29)
				{
					goto IL_088a;
				}
				if ((object)gillaCorpse != null)
				{
					Vector3 middleNow = gillaCorpse.MiddleNow;
					goto IL_07d8;
				}
			}
		}
		goto IL_09cd;
		IL_0af0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
		object obj43 = 0;
		Vector3? vector2 = (Vector3)obj43;
		vector = vector2;
		goto IL_088a;
		IL_09cd:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0a0b:
		return result;
		IL_07d8:
		num = 8.0;
		goto IL_0af0;
		IL_07c6:
		Vector3 position = transform.position;
		goto IL_07d8;
		IL_088a:
		if ((Vector3)vector != (Vector3)(object)0)
		{
			Vector3 value = vector.Value;
			Transform transform2 = base.transform;
			if ((object)transform2 == null)
			{
				goto IL_09cd;
			}
			Vector3 position2 = transform2.position;
			object obj45 = default;
			object obj44 = obj45 - obj45;
			object obj47 = default;
			object obj46 = obj47 - obj47;
			object obj49 = default;
			object obj48 = obj49 - obj49;
			object obj50 = obj44 * obj44;
			object obj51 = obj46 * obj46;
			object obj52 = obj50 + obj51;
			object obj53 = obj48 * obj48;
			object obj54 = obj53 + obj52;
			double num2 = num * num;
			bool flag30 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2);
			object obj55 = !flag30;
			double num3 = (double)obj54 - num2;
			bool flag31 = num3 == 0.0;
			object obj56 = ~obj55;
			bool flag32 = (byte)((obj56 | flag31) ? 1 : 0) != 0;
			result = flag32;
		}
		else
		{
			result = false;
		}
		goto IL_0a0b;
	}

	private void Clang(Vector3 at, Vector3 normal, byte stuff, float hard)
	{
		//IL_002e: Expected Obj, but got I4
		//IL_0150: Expected F4, but got I
		//IL_0159: Invalid comparison between F8 and I4
		//IL_0168: Expected F8, but got I4
		//IL_0344: Expected F4, but got I
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_01c4: Invalid comparison between F8 and I
		//IL_026d: Invalid comparison between F8 and I4
		//IL_027c: Expected F8, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_01eb: Expected Obj, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0134: Expected VT, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0238: Expected VT, but got I4
		//IL_0391: Expected Obj, but got I4
		//IL_022a: Expected VT, but got I4
		//IL_0262: Expected I4, but got VT
		//IL_0262: Expected VT, but got I4
		bool justKnocked = item.JustKnocked;
		bool flag = !justKnocked;
		object obj = !flag;
		double num = default;
		if (obj == null)
		{
			object obj2 = at & 0xFF;
			object clips;
			if ((nint)obj2 == 1)
			{
				clips = this + 312;
			}
			else
			{
				clips = (((nint)obj2 != 2) ? ((object)(item + 48)) : ((object)(this + 320)));
			}
			bool flag2 = num < 0.0;
			double num2 = 0.0;
			if (!flag2)
			{
				bool flag3 = !(num > 1.0);
				num2 = num;
				if (!flag3)
				{
					num2 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj3 = 0;
			double num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			double num4 = num3 * 0.0;
			object obj4 = obj3;
			double num5 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			double num6 = num5 + 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num7 = (double)loudness * num6;
			float pitchMin = default;
			float pitchMax = default;
			Sfx.Play((AudioClip[])clips, (Vector3)0, hard, pitchMin, pitchMax);
		}
		GillaItem gillaItem = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		gillaItem.Hush(0f);
		bool flag5 = num < 0.0;
		double num8 = 0.0;
		if (!flag5)
		{
			bool flag6 = !(num > 1.0);
			num8 = num;
			if (!flag6)
			{
				num8 = 1.0;
			}
		}
		double num9 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAE4]");
		double num10 = num9 * 0.0;
		float num11 = (float)num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float strength = num11 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		Buzz(strength, 0f);
		object obj6 = at & 0xFF;
		if (obj6 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		if (num > 0.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
			object obj7 = 0;
			object obj8 = obj7;
			object obj9 = at & 0xFF;
			Vector3 at2 = (((nint)obj9 != 2) ? ((Vector3)14) : ((Vector3)30));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v9+E4]");
			bool flag7 = (nint)0 == 0;
			object obj10 = !flag7;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sparks(at2, (Vector3)0, (int)normal, hard);
		}
	}

	internal unsafe static void Sparks(Vector3 at, Vector3 normal, int many, float hard)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05f4: Expected Obj, but got I
		//IL_0628: Expected Obj, but got I4
		//IL_064e: Expected Obj, but got I
		//IL_0670: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_0696: Expected Obj, but got I
		//IL_06b8: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01b2: Expected VT, but got I4
		//IL_06d6: Expected Obj, but got I
		//IL_06ee: Expected Obj, but got I
		//IL_06fc: Expected VT, but got I4
		//IL_0711: Expected F4, but got I
		//IL_071a: Invalid comparison between F8 and I4
		//IL_0729: Expected F8, but got I4
		//IL_079c: Expected Obj, but got I4
		//IL_07ba: Expected Obj, but got I
		//IL_0235: Expected VT, but got Ref
		//IL_0235: Expected Obj, but got I
		//IL_0243: Invalid comparison between VT and I4
		//IL_0267: Expected Obj, but got I
		//IL_0284: Invalid comparison between F8 and I4
		//IL_0293: Invalid comparison between F8 and I4
		//IL_02ab: Expected Obj, but got F8
		//IL_02b8: Expected Obj, but got F8
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0317: Expected Obj, but got I4
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got Unknown
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected Obj, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected Obj, but got Unknown
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected Obj, but got Unknown
		//IL_086f: Invalid comparison between F8 and I4
		//IL_088f: Expected Obj, but got I4
		//IL_089f: Expected F4, but got I
		//IL_09f8: Invalid comparison between F4 and I
		//IL_08d8: Expected VT, but got I4
		//IL_0a39: Expected Obj, but got I4
		//IL_0483: Invalid comparison between F4 and I
		//IL_04c6: Expected Obj, but got I
		//IL_04d6: Expected F4, but got I
		//IL_08fc: Expected F4, but got I
		//IL_092c: Expected VT, but got I4
		//IL_0949: Expected F4, but got I
		//IL_0949: Expected F4, but got I
		//IL_0505: Expected F4, but got I
		//IL_0505: Expected F4, but got I
		//IL_0545: Expected Obj, but got I4
		//IL_0962: Expected Obj, but got I
		//IL_058e: Expected VT, but got Ref
		//IL_058e: Expected Obj, but got I
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected VT, but got Unknown
		//IL_05aa: Invalid comparison between VT and I4
		//IL_05bc: Expected Obj, but got I4
		//IL_05cc: Expected F8, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v1+18]");
		if ((UnityEngine.Object)0 == null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v67+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			MakeSparks();
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj;
		}
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v11+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X9_v2+18]");
		bool flag6 = (UnityEngine.Object)0 == null;
		bool flag7 = !flag6;
		object obj15 = !flag7;
		if (obj15 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
		object obj17 = default;
		object obj16 = obj17 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
		object obj19 = default;
		object obj18 = obj19 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
		object obj21 = default;
		object obj20 = obj21 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		ParticleSystem.EmitParams emitParams = default;
		emitParams.position = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v12+A0]");
		object obj24 = 0;
		emitParams.velocity = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		emitParams.startLifetime = 0f;
		double num = default;
		bool flag8 = num < 0.0;
		double num2 = 0.0;
		if (!flag8)
		{
			bool flag9 = !(num > 1.0);
			num2 = num;
			if (!flag9)
			{
				num2 = 1.0;
			}
		}
		double num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD8]");
		double num4 = num3 * 0.0;
		float num5 = (float)num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD8]");
		float startSize = num5 + 0f;
		emitParams.startSize = startSize;
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v24+E4]");
		bool flag10 = (nint)0 == 0;
		object obj26 = !flag10;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v24+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v17+20]");
		object obj28 = default;
		((ParticleSystem)0).Emit((ParticleSystem.EmitParams)(&obj28), 1);
		if (at < (object)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj29 = 0;
		double num6 = num - 1.0;
		bool flag11 = num6 < 0.0;
		bool flag12 = num6 == 0.0;
		object obj30 = num ^ 1.0;
		object obj31 = num ^ num6;
		object obj32 = obj30 & obj31;
		bool flag13 = (nint)obj32 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AADC]");
		object obj33 = obj17 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AADC]");
		object obj34 = obj19 * 0;
		bool flag14 = flag11 == flag13;
		object obj35 = !flag12;
		object obj36 = flag14 & obj35;
		object obj37 = ~obj36;
		double num7 = ((obj37 != null) ? num : 1.0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		object obj38 = obj17 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		object obj39 = obj19 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AADC]");
		object obj40 = obj21 * 0;
		double num8 = num7 * 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		object obj41 = obj21 * 0;
		float num9 = hard + (float)obj33;
		object obj42 = default;
		float num10 = (float)obj42 + (float)obj40;
		double num11 = num8 + 0.75;
		object obj44 = default;
		object obj43 = obj44 + obj34;
		if (num < 0.0)
		{
			num11 = 0.75;
		}
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
		float num12 = 0f;
		float num13 = num10;
		double num14 = 0.75;
		int num15 = 1;
		Vector3 vector = at;
		object obj53 = default;
		bool flag17;
		do
		{
			Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			float num16 = (float)obj38 + num12;
			double num17 = (double)obj39 + num14;
			float num18 = (float)obj41 + num13;
			float num19 = (float)obj17 * num16;
			double num20 = (double)obj19 * num17;
			float num21 = num19 + (float)num20;
			float num22 = (float)obj21 * num18;
			float num23 = num22 + num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			if (num23 < 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				float num24 = 0f - num23;
				float num25 = (float)obj17 * num24;
				float num26 = (float)obj19 * num24;
				float num27 = (float)obj21 * num24;
				float num28 = num25 + num25;
				float num29 = num26 + num26;
				float num30 = num27 + num27;
				num16 += num28;
				num17 += (double)num29;
				num18 += num30;
			}
			emitParams.position = (Vector3)0;
			object obj46 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X0_v36+E4]");
			bool flag15 = (nint)0 == 0;
			object obj47 = !flag15;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num31 = num16 * num16;
			double num32 = num17 * num17;
			float num33 = num31 + (float)num32;
			float num34 = num18 * num18;
			float num35 = num33 + num34;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num36;
			if (num35 > 0f)
			{
				num36 = num18 / num35;
			}
			else
			{
				object obj48 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v30+A0]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v31+8]");
				num36 = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
			float num37 = UnityEngine.Random.Range(0f, 6.5f);
			float num38 = num37 * (float)num11;
			num13 = num36 * num38;
			emitParams.velocity = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			nint num39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF8]");
			float startLifetime = UnityEngine.Random.Range(num39, 0f);
			emitParams.startLifetime = startLifetime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A838]");
			nint num40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A99C]");
			num12 = (emitParams.startSize = UnityEngine.Random.Range(num40, 0f));
			object obj50 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v45+E4]");
			bool flag16 = (nint)0 == 0;
			object obj51 = !flag16;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj50 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v45+A0]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v29+18]");
			((ParticleSystem)0).Emit((ParticleSystem.EmitParams)(&obj53), 1);
			vector--;
			flag17 = vector != (Vector3)(object)1;
			obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A99C]");
			num14 = 0.0;
			num15 = 1;
		}
		while (flag17);
	}

	private unsafe static void MakeSparks()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0bf7: Expected Obj, but got I4
		//IL_0c2f: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got Ref
		//IL_01f8: Expected Obj, but got I
		//IL_020d: Expected F4, but got I
		//IL_0223: Expected VT, but got Ref
		//IL_023b: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I
		//IL_02e1: Expected VT, but got I4
		//IL_032d: Expected VT, but got I4
		//IL_0355: Expected VT, but got I4
		//IL_0371: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03e1: Expected F4, but got I
		//IL_03e1: Expected VT, but got I4
		//IL_03f6: Expected Obj, but got I
		//IL_0469: Expected F4, but got I
		//IL_04a7: Expected Obj, but got I4
		//IL_04b7: Expected Obj, but got I4
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		//IL_053d: Expected VT, but got Ref
		//IL_0555: Expected Obj, but got I
		//IL_058b: Expected Obj, but got I
		//IL_05ca: Expected F4, but got I
		//IL_05f6: Expected VT, but got Ref
		//IL_060e: Expected Obj, but got I
		//IL_0644: Expected Obj, but got I
		//IL_0676: Expected VT, but got Ref
		//IL_068c: Expected F4, but got I
		//IL_069d: Expected VT, but got Ref
		//IL_06ba: Expected Obj, but got I
		//IL_06f0: Expected Obj, but got I
		//IL_0736: Expected I4, but got I8
		//IL_075d: Expected F4, but got I
		//IL_076e: Expected VT, but got Ref
		//IL_0792: Expected VT, but got Ref
		//IL_07a8: Expected F4, but got I
		//IL_07b9: Expected VT, but got Ref
		//IL_07d6: Expected Obj, but got I
		//IL_080b: Expected Obj, but got I
		//IL_0855: Expected F4, but got I
		//IL_087c: Expected Obj, but got I
		//IL_08b5: Expected Obj, but got I
		//IL_08df: Expected Obj, but got I
		//IL_0915: Expected Obj, but got I
		//IL_0965: Expected VT, but got I4
		//IL_09b1: Expected VT, but got I4
		//IL_0a7a: Expected VT, but got Ref
		//IL_0a92: Expected Obj, but got I
		//IL_0ac8: Expected Obj, but got I
		//IL_0b0a: Expected F4, but got I
		//IL_0b0a: Expected F4, but got I
		//IL_0b36: Expected VT, but got Ref
		//IL_0b4e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CB0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj6 = default;
		bool flag2 = obj6 == null;
		bool flag3 = !flag2;
		UnityEngine.Object obj7 = null;
		UnityEngine.Object obj8 = obj6;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C30]");
			object obj9 = 0;
			obj7 = (UnityEngine.Object)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
			UnityEngine.Object obj10 = default;
			obj8 = obj10;
		}
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = obj8 == null;
		bool flag6 = !flag5;
		object obj13 = !flag6;
		if (obj13 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C28]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ParticleSystem particleSystem = Particles((string)obj16, (Material)obj8, 300);
		object obj18 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v8+A0]");
		object obj19 = (nint)0 + (nint)24;
		obj19 = particleSystem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj20 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v11+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v12+18]");
		if ((nint)0 != 0)
		{
			object obj23 = default;
			object obj22 = (object)(&obj23);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v12+18]");
			ParticleSystem.MainModule main = ((ParticleSystem)0).main;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
			ParticleSystem.MinMaxCurve minMaxCurve = 0f;
			ParticleSystem.MainModule mainModule = default;
			object obj24 = default;
			mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj24);
			object obj25 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X8_v17+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v18+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v18+18]");
				ParticleSystem.ColorOverLifetimeModule colorOverLifetime = ((ParticleSystem)0).colorOverLifetime;
				ParticleSystem.ColorOverLifetimeModule colorOverLifetimeModule = default;
				colorOverLifetimeModule.enabled = true;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54A0]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Gradient gradient = default;
				gradient._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5498]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				GradientColorKey gradientColorKey = new GradientColorKey((Color)0, 1f);
				GradientColorKey[] array = default;
				if (array != null)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X24_v5+2D0]");
					_ = 0;
					GradientColorKey gradientColorKey2 = new GradientColorKey((Color)0, 1f);
					_ = 0;
					_ = 0;
					GradientColorKey gradientColorKey3 = new GradientColorKey((Color)0, 1f);
					bool flag8 = array.Length < 2;
					object obj29 = !flag8;
					object obj30 = array.Length - 2;
					bool flag9 = obj30 == null;
					object obj31 = ~obj29;
					object obj32 = obj31 | flag9;
					if (obj32 != null)
					{
						goto IL_0bbc;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X24_v5+2A0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
					GradientColorKey gradientColorKey4 = new GradientColorKey((Color)0, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5490]");
					object obj33 = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					GradientAlphaKey gradientAlphaKey = new GradientAlphaKey(1f, 0f);
					GradientAlphaKey[] array2 = default;
					if (array2 != null)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
						GradientAlphaKey gradientAlphaKey2 = new GradientAlphaKey(1f, 0f);
						_ = 0;
						GradientAlphaKey gradientAlphaKey3 = new GradientAlphaKey(0f, 1f);
						bool flag10 = array2.Length < 2;
						object obj34 = !flag10;
						object obj35 = array2.Length - 2;
						bool flag11 = obj35 == null;
						object obj36 = ~obj34;
						object obj37 = obj36 | flag11;
						if (obj37 != null)
						{
							goto IL_0bbc;
						}
						_ = 0;
						if ((object)gradient != null)
						{
							gradient.SetKeys(array, array2);
							ParticleSystem.MinMaxGradient minMaxGradient = gradient;
							object obj38 = default;
							colorOverLifetimeModule.color = (ParticleSystem.MinMaxGradient)(&obj38);
							object obj39 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v37+A0]");
							object obj40 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v38+18]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v38+18]");
								ParticleSystem.SizeOverLifetimeModule sizeOverLifetime = ((ParticleSystem)0).sizeOverLifetime;
								ParticleSystem.SizeOverLifetimeModule sizeOverLifetimeModule = default;
								sizeOverLifetimeModule.enabled = true;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
								AnimationCurve curve = AnimationCurve.Linear(0f, 1f, 1f, 0f);
								ParticleSystem.MinMaxCurve minMaxCurve2 = new ParticleSystem.MinMaxCurve(1f, curve);
								object obj41 = default;
								sizeOverLifetimeModule.size = (ParticleSystem.MinMaxCurve)(&obj41);
								object obj42 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v40+A0]");
								object obj43 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v41+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v41+18]");
									ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetime = ((ParticleSystem)0).limitVelocityOverLifetime;
									ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetimeModule = default;
									limitVelocityOverLifetimeModule.enabled = true;
									ParticleSystem.MinMaxCurve minMaxCurve3 = 100f;
									object obj44 = default;
									limitVelocityOverLifetimeModule.limit = (ParticleSystem.MinMaxCurve)(&obj44);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
									ParticleSystem.MinMaxCurve minMaxCurve4 = 0f;
									object obj45 = default;
									limitVelocityOverLifetimeModule.drag = (ParticleSystem.MinMaxCurve)(&obj45);
									object obj46 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X8_v46+A0]");
									object obj47 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v47+18]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v47+18]");
										ParticleSystem.CollisionModule collision = ((ParticleSystem)0).collision;
										ParticleSystem.CollisionModule collisionModule = default;
										collisionModule.enabled = true;
										collisionModule.type = (ParticleSystemCollisionType)1;
										collisionModule.quality = (ParticleSystemCollisionQuality)2;
										LayerMask collidesWith = -5893;
										collisionModule.collidesWith = collidesWith;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
										ParticleSystem.MinMaxCurve minMaxCurve5 = 0f;
										object obj48 = default;
										collisionModule.bounce = (ParticleSystem.MinMaxCurve)(&obj48);
										ParticleSystem.MinMaxCurve minMaxCurve6 = 0.5f;
										object obj49 = default;
										collisionModule.dampen = (ParticleSystem.MinMaxCurve)(&obj49);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
										ParticleSystem.MinMaxCurve minMaxCurve7 = 0f;
										object obj50 = default;
										collisionModule.lifetimeLoss = (ParticleSystem.MinMaxCurve)(&obj50);
										object obj51 = obj14;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X8_v52+A0]");
										object obj52 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X8_v53+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F08]");
											object obj53 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
											ParticleSystemRenderer particleSystemRenderer = default;
											if ((object)particleSystemRenderer != null)
											{
												particleSystemRenderer.renderMode = (ParticleSystemRenderMode)1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D0]");
												particleSystemRenderer.velocityScale = 0f;
												particleSystemRenderer.lengthScale = 1.5f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C38]");
												object obj54 = 0;
												ParticleSystem particleSystem2 = Particles((string)obj54, (Material)obj8, 16);
												object obj55 = obj14;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ X8_v57+A0]");
												object obj56 = (nint)0 + (nint)32;
												obj56 = particleSystem2;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												object obj57 = obj14;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X8_v60+A0]");
												object obj58 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v61+20]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v61+20]");
													ParticleSystem.ColorOverLifetimeModule colorOverLifetime2 = ((ParticleSystem)0).colorOverLifetime;
													ParticleSystem.ColorOverLifetimeModule colorOverLifetimeModule2 = default;
													colorOverLifetimeModule2.enabled = true;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Gradient gradient2 = default;
													gradient2._002Ector();
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													GradientColorKey gradientColorKey5 = new GradientColorKey((Color)0, 1f);
													GradientColorKey[] array3 = default;
													if (array3 != null)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X24_v5+60]");
														_ = 0;
														GradientColorKey gradientColorKey6 = new GradientColorKey((Color)0, 1f);
														_ = 0;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
														GradientAlphaKey gradientAlphaKey4 = new GradientAlphaKey(1f, 0f);
														GradientAlphaKey[] array4 = default;
														if (array4 != null)
														{
															_ = 0;
															GradientAlphaKey gradientAlphaKey5 = new GradientAlphaKey(0f, 1f);
															_ = 0;
															if ((object)gradient2 != null)
															{
																gradient2.SetKeys(array3, array4);
																ParticleSystem.MinMaxGradient minMaxGradient2 = gradient2;
																object obj59 = default;
																colorOverLifetimeModule2.color = (ParticleSystem.MinMaxGradient)(&obj59);
																object obj60 = obj14;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v72+A0]");
																object obj61 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v73+20]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v73+20]");
																	ParticleSystem.SizeOverLifetimeModule sizeOverLifetime2 = ((ParticleSystem)0).sizeOverLifetime;
																	ParticleSystem.SizeOverLifetimeModule sizeOverLifetimeModule2 = default;
																	sizeOverLifetimeModule2.enabled = true;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
																	nint num = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
																	AnimationCurve curve2 = AnimationCurve.Linear(0f, num, 1f, 0f);
																	ParticleSystem.MinMaxCurve minMaxCurve8 = new ParticleSystem.MinMaxCurve(1f, curve2);
																	object obj62 = default;
																	sizeOverLifetimeModule2.size = (ParticleSystem.MinMaxCurve)(&obj62);
																	object obj63 = obj14;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1133 @ X8_v75+A0]");
																	object obj64 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v76+20]");
																	if ((nint)0 != 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
																		ParticleSystemRenderer particleSystemRenderer2 = default;
																		if ((object)particleSystemRenderer2 != null)
																		{
																			particleSystemRenderer2.renderMode = (ParticleSystemRenderMode)0;
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
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0bbc;
		IL_0bbc:
		throw new IndexOutOfRangeException();
	}

	private unsafe static ParticleSystem Particles(string name, Material material, int most)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I
		//IL_00bd: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(name);
		if ((object)gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			ParticleSystem particleSystem = default;
			if ((object)particleSystem != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F08]");
				object obj3 = 0;
				particleSystem.Stop(withChildren: true, (ParticleSystemStopBehavior)0);
				ParticleSystem.MainModule main = particleSystem.main;
				ParticleSystem.MainModule mainModule = default;
				mainModule.playOnAwake = false;
				mainModule.simulationSpace = (ParticleSystemSimulationSpace)1;
				ParticleSystem.MinMaxCurve minMaxCurve = 0f;
				object obj4 = default;
				mainModule.startSpeed = (ParticleSystem.MinMaxCurve)(&obj4);
				mainModule.maxParticles = most;
				ParticleSystem.EmissionModule emission = particleSystem.emission;
				ParticleSystem.EmissionModule emissionModule = default;
				emissionModule.enabled = false;
				ParticleSystem.ShapeModule shape = particleSystem.shape;
				ParticleSystem.ShapeModule shapeModule = default;
				shapeModule.enabled = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				Renderer renderer = default;
				if ((object)renderer != null)
				{
					renderer.sharedMaterial = material;
					renderer.shadowCastingMode = (ShadowCastingMode)0;
					renderer.receiveShadows = false;
					return particleSystem;
				}
			}
		}
		return (ParticleSystem)(object)new NullReferenceException();
	}

	private unsafe bool Looks(int e, Vector3 from, Vector3 to, Vector3 going, float speed)
	{
		//IL_0335: Expected I4, but got Obj
		//IL_001c: Expected I4, but got I8
		//IL_0036: Expected Obj, but got I4
		//IL_003e: Expected VT, but got I4
		//IL_036e: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I4
		//IL_03f9: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_01c4: Invalid comparison between F4 and I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01e5: Expected Obj, but got F4
		//IL_021a: Expected Obj, but got I4
		//IL_00f3: Expected I4, but got VT
		//IL_00f3: Expected VT, but got I4
		//IL_00f3: Expected VT, but got I8
		//IL_0111: Expected Obj, but got I4
		//IL_011a: Expected VT, but got I4
		//IL_0247: Expected F4, but got I4
		//IL_0420: Invalid comparison between F4 and I4
		//IL_042f: Invalid comparison between F4 and I4
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_0450: Expected Obj, but got F4
		//IL_0485: Expected Obj, but got I4
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_0262: Expected F4, but got I4
		//IL_04b2: Expected Obj, but got I4
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_051c: Invalid comparison between F4 and I4
		//IL_04ca: Expected Ref, but got VT
		//IL_04ca: Expected VT, but got I4
		//IL_04ca: Expected VT, but got Ref
		//IL_04e8: Expected Obj, but got I4
		//IL_0315: Expected VT, but got Ref
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_029c: Invalid comparison between F4 and Obj
		//IL_02c9: Expected Ref, but got VT
		//IL_02c9: Expected VT, but got I4
		//IL_02c9: Expected VT, but got Ref
		//IL_02c9: Expected Obj, but got I4
		//IL_02f2: Expected VT, but got Ref
		GillaItem gillaItem = item;
		if ((object)item != null)
		{
			int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			Vector3 vector = (Vector3)e;
			if (obj == null)
			{
				Transform transform = base.transform;
				if ((object)transform == null)
				{
					goto IL_0327;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
				object obj2 = 0;
				Vector3 position = transform.position;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v33+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = Physics.Linecast((Vector3)4294961403L, (Vector3)1, 0, (QueryTriggerInteraction)to);
				bool flag4 = !flag3;
				object obj5 = !flag4;
				vector = (Vector3)1;
				if (obj5 != null)
				{
					goto IL_02ff;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj6 = 0;
			float num3 = default;
			float num2 = num3 - speed;
			object obj7 = obj6;
			object obj9 = default;
			object obj10 = default;
			object obj8 = obj9 - obj10;
			object obj12 = default;
			object obj13 = default;
			object obj11 = obj12 - obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v10+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num4 = num2 * num2;
			object obj15 = obj8 * obj8;
			float num5 = num4 + (float)obj15;
			object obj16 = obj11 * obj11;
			float num6 = (float)obj16 + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			object obj17 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			float num7 = num6 - 6f;
			bool flag7 = num7 < 0f;
			object obj19 = num6 ^ 6;
			object obj20 = num6 ^ num7;
			object obj21 = obj19 & obj20;
			bool flag8 = (nint)obj21 < 0;
			bool flag9 = flag7 == flag8;
			object obj22 = !flag9;
			object obj23 = ~obj22;
			float num8 = ((obj23 != null) ? 6f : num6);
			float num9 = num8 - 1f;
			bool flag10 = num9 < 0f;
			bool flag11 = num9 == 0f;
			object obj24 = num8 ^ 1;
			object obj25 = num8 ^ num9;
			object obj26 = obj24 & obj25;
			bool flag12 = (nint)obj26 < 0;
			bool flag13 = flag10 == flag12;
			object obj27 = !flag11;
			object obj28 = flag13 & obj27;
			object obj29 = ~obj28;
			float num10 = ((obj29 != null) ? 1f : num8);
			object obj30 = 0;
			bool flag14 = default;
			object obj32 = default;
			object obj34 = default;
			object obj35 = default;
			object obj36 = default;
			while (true)
			{
				object obj31 = obj30 + 1;
				float num11 = (float)obj31 / num10;
				Landed l;
				float speed2;
				if (num11 < 0f || !((double)num11 > 1.0))
				{
					flag14 = LandsOn((Vector3)(&obj32), (Vector3)0, out *(Landed*)to);
					bool flag15 = !flag14;
					object obj33 = !flag15;
					if (obj33 != null)
					{
						l = (Landed)(&obj34);
						speed2 = num3;
						goto IL_0530;
					}
				}
				obj30++;
				if ((object)num10 != obj30)
				{
					continue;
				}
				if (!((GillaPickaxe)flag14).OnABody((Vector3)(&obj35), (Vector3)0, out *(Landed*)to))
				{
					break;
				}
				l = (Landed)(&obj36);
				speed2 = num3;
				goto IL_0530;
				IL_0530:
				return Lands(e, l, to, going, speed2);
			}
			goto IL_02ff;
		}
		goto IL_0327;
		IL_0327:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_02ff:
		return false;
	}

	private unsafe bool LandsOn(Vector3 at, Vector3 going, out Landed l)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0028: Expected Obj, but got Ref
		//IL_2155: Expected native int or pointer, but got VT
		//IL_2169: Expected native int or pointer, but got VT
		//IL_2194: Expected Obj, but got I
		//IL_21c4: Expected Obj, but got I4
		//IL_0144: Expected F4, but got I4
		//IL_21e2: Expected Obj, but got I
		//IL_220c: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_0103: Expected VT, but got I4
		//IL_0110: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got Ref
		//IL_2831: Expected Obj, but got I
		//IL_285a: Expected Obj, but got I4
		//IL_2860: Unknown result type (might be due to invalid IL or missing references)
		//IL_286d: Expected Obj, but got I4
		//IL_2876: Expected Obj, but got I4
		//IL_287c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2892: Expected Obj, but got I4
		//IL_28a3: Expected Obj, but got I4
		//IL_28d5: Expected VT, but got I4
		//IL_28ea: Expected Obj, but got I
		//IL_28f2: Expected Obj, but got Ref
		//IL_1c33: Expected I4, but got Obj
		//IL_0136: Expected F4, but got I
		//IL_0171: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got F4
		//IL_01af: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_01e9: Expected VT, but got I4
		//IL_01f1: Expected Obj, but got Ref
		//IL_1c52: Expected I4, but got Obj
		//IL_2801: Expected Obj, but got Ref
		//IL_280a: Expected F4, but got I4
		//IL_2813: Expected Obj, but got I4
		//IL_281c: Expected Obj, but got I4
		//IL_22a7: Expected Obj, but got I4
		//IL_22b9: Expected Obj, but got I4
		//IL_22bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_22cc: Expected Obj, but got I4
		//IL_22d5: Expected Obj, but got I4
		//IL_22db: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ed: Expected Obj, but got I4
		//IL_22f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got I4
		//IL_1c97: Expected I4, but got Obj
		//IL_0265: Expected Obj, but got I4
		//IL_026e: Expected VT, but got I4
		//IL_091d: Expected Obj, but got I4
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected Obj, but got I4
		//IL_0939: Expected Obj, but got I4
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Obj, but got I4
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got I4
		//IL_226e: Expected Obj, but got I4
		//IL_2918: Expected Obj, but got I
		//IL_2943: Expected Obj, but got I4
		//IL_1d1a: Expected I4, but got Obj
		//IL_0321: Expected Obj, but got I4
		//IL_032a: Expected VT, but got I4
		//IL_1d5f: Expected I4, but got Obj
		//IL_1af2: Expected VT, but got I4
		//IL_0384: Expected Obj, but got I4
		//IL_038d: Expected VT, but got I4
		//IL_1b1a: Expected Obj, but got I4
		//IL_1b23: Expected Obj, but got I4
		//IL_1b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3c: Expected Obj, but got I4
		//IL_1b45: Expected Obj, but got I4
		//IL_1b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b57: Expected VT, but got I4
		//IL_1b67: Expected I4, but got Obj
		//IL_1da4: Expected I4, but got Obj
		//IL_03bb: Expected Obj, but got I
		//IL_03dd: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got I4
		//IL_042b: Expected VT, but got I4
		//IL_1bb6: Expected Obj, but got I4
		//IL_1bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc8: Expected I4, but got Obj
		//IL_1de9: Expected I4, but got Obj
		//IL_0459: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I4
		//IL_04c0: Expected Obj, but got I4
		//IL_04c9: Expected VT, but got I4
		//IL_1e2e: Expected I4, but got Obj
		//IL_04ef: Invalid comparison between I and F4
		//IL_0501: Expected VT, but got I4
		//IL_0540: Expected Obj, but got I4
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected Obj, but got I4
		//IL_055c: Expected Obj, but got I4
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got I4
		//IL_057e: Expected Obj, but got I4
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected VT, but got I4
		//IL_1e73: Expected I4, but got Obj
		//IL_05cc: Expected Obj, but got I
		//IL_065f: Expected VT, but got I4
		//IL_1eb8: Expected I4, but got Obj
		//IL_0685: Expected Obj, but got I
		//IL_06af: Expected Obj, but got I4
		//IL_06dd: Expected Obj, but got I
		//IL_0702: Expected Obj, but got I4
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected Obj, but got I4
		//IL_071e: Expected Obj, but got I4
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected Obj, but got I
		//IL_0747: Expected Obj, but got I4
		//IL_0750: Expected Obj, but got I4
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected VT, but got I4
		//IL_076f: Expected I4, but got Obj
		//IL_1efd: Expected I4, but got Obj
		//IL_07a9: Expected VT, but got Ref
		//IL_07a9: Expected VT, but got Ref
		//IL_07f9: Expected Obj, but got I
		//IL_0809: Expected VT, but got Ref
		//IL_0827: Expected Obj, but got Ref
		//IL_084b: Expected F4, but got I4
		//IL_0846: Expected native int or pointer, but got VT
		//IL_087f: Expected F4, but got I
		//IL_087a: Expected native int or pointer, but got VT
		//IL_0888: Expected native int or pointer, but got VT
		//IL_08cb: Expected Obj, but got I
		//IL_08d3: Expected Obj, but got Ref
		//IL_08e4: Expected F4, but got I4
		//IL_08ec: Expected VT, but got Ref
		//IL_08fd: Expected Obj, but got I4
		//IL_0906: Expected Obj, but got I4
		//IL_1f42: Expected I4, but got Obj
		//IL_1f87: Expected I4, but got Obj
		//IL_1fcc: Expected I4, but got Obj
		//IL_2011: Expected I4, but got Obj
		//IL_2095: Expected Obj, but got I4
		//IL_2757: Expected Obj, but got I4
		//IL_2961: Expected Obj, but got I
		//IL_2969: Unknown result type (might be due to invalid IL or missing references)
		//IL_2972: Expected Ref, but got Unknown
		//IL_298c: Expected Obj, but got I4
		//IL_298c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2994: Expected I4, but got Unknown
		//IL_1a37: Expected Obj, but got I4
		//IL_1a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3f: Expected I4, but got Unknown
		//IL_1a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5b: Expected Obj, but got Unknown
		//IL_1a75: Expected Obj, but got I4
		//IL_1a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7d: Expected I4, but got Unknown
		//IL_1a94: Expected F4, but got I4
		//IL_1a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9c: Expected I4, but got Unknown
		//IL_1aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aaf: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Enumerator<, > val = default;
		UnityEngine.Object obj3 = (UnityEngine.Object)(&val);
		((Vector3*)(nint)at)->z = 0f;
		_ = 0;
		((Vector3*)(nint)at)->x = 0f;
		_ = 0;
		object obj4 = obj;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v4+A0]");
		object obj6 = 0;
		UnityEngine.Object obj7 = (UnityEngine.Object)obj6;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj6 != null;
		float num2 = default;
		object obj12;
		float num4 = default;
		object obj13;
		float num6 = default;
		object obj15 = default;
		object obj17 = default;
		UnityEngine.Object obj18;
		UnityEngine.Object obj19 = default;
		float num8 = default;
		NullReferenceException ex;
		float num9 = default;
		float num5;
		float num;
		float num3;
		object obj14;
		object obj16;
		float num7;
		UnityEngine.Object obj21;
		UnityEngine.Object obj20;
		Vector3 vector;
		GoreSection goreSection;
		object obj9;
		Enumerator<, > val2;
		object obj10;
		object obj11;
		Enumerator<, > val3;
		if (flag2)
		{
			bool flag3 = obj6 == null;
			goreSection = (GoreSection)0;
			obj9 = 0;
			val2 = (Enumerator<, >)0;
			obj10 = 0;
			obj11 = 0;
			val3 = (Enumerator<, >)0;
			num = num2;
			obj12 = 0;
			num3 = num4;
			obj13 = 0;
			num5 = num6;
			obj14 = obj15;
			obj16 = obj17;
			obj18 = obj19;
			num7 = num8;
			vector = (Vector3)0;
			obj20 = null;
			ex = (NullReferenceException)flag2;
			obj21 = (UnityEngine.Object)(&val);
			if (flag3)
			{
				goto IL_1c0a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X21_v2 (UnityEngine.Object)+80]");
			num9 = 0f;
		}
		else
		{
			num9 = 3f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj24 = !flag4;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X0_v12+A0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v14+8]");
		bool flag5 = (nint)0 == 0;
		goreSection = (GoreSection)0;
		obj9 = 0;
		val2 = (Enumerator<, >)0;
		obj10 = 0;
		obj11 = 0;
		val3 = (Enumerator<, >)0;
		num = num2;
		obj12 = 0;
		num3 = num4;
		obj13 = 0;
		num5 = num6;
		obj14 = obj15;
		obj16 = obj17;
		obj18 = obj19;
		num7 = num8;
		vector = (Vector3)0;
		obj20 = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v14+8]");
		ex = (NullReferenceException)0;
		obj21 = (UnityEngine.Object)(&val);
		if (flag5)
		{
			goto IL_1c0a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v14+8]");
		Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
		float num10 = default;
		obj3 = (UnityEngine.Object)num10;
		num = num2;
		obj12 = 0;
		num3 = num4;
		obj13 = 0;
		num5 = num6;
		obj14 = obj15;
		obj16 = obj17;
		num7 = num10;
		vector = (Vector3)0;
		obj21 = (UnityEngine.Object)(&val);
		object obj47 = default;
		Enumerator<, > val4 = default;
		IntPtr intPtr = default;
		ref Landed reference;
		float num14;
		UnityEngine.Object obj37;
		object obj48;
		bool flag12;
		while (val.MoveNext())
		{
			object obj28 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1615 @ X0_v119+E4]");
			bool flag6 = (nint)0 == 0;
			object obj29 = !flag6;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = obj19 == null;
			bool flag8 = !flag7;
			object obj30 = !flag8;
			vector = (Vector3)0;
			obj21 = obj19;
			if (obj30 != null)
			{
				continue;
			}
			object obj31 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1693 @ X0_v123+E4]");
			bool flag9 = (nint)0 == 0;
			object obj32 = !flag9;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj33 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1774 @ X0_v127+E4]");
			bool flag10 = (nint)0 == 0;
			object obj34 = !flag10;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj33 = obj22;
			}
			object obj35 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1774 @ X0_v127+A0]");
			object obj36 = 0;
			obj37 = (UnityEngine.Object)obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1557 @ X8_v79+E4]");
			bool flag11 = (nint)0 == 0;
			object obj38 = !flag11;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			flag12 = obj19 == obj37;
			bool flag13 = !flag12;
			object obj39 = !flag13;
			vector = (Vector3)0;
			obj21 = obj19;
			if (obj39 != null)
			{
				continue;
			}
			if ((object)obj19 == null)
			{
				goto IL_1ac8;
			}
			bool isMonster = ((NetworkApe)obj19).IsMonster;
			bool flag14 = !isMonster;
			object obj40 = !flag14;
			vector = (Vector3)0;
			obj21 = obj19;
			if (obj40 != null)
			{
				continue;
			}
			object obj41 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ stack_-148 (UnityEngine.Object)+A8]");
			obj37 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1958 @ X0_v134+E4]");
			bool flag15 = (nint)0 == 0;
			object obj42 = !flag15;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag16 = obj37 == null;
			bool flag17 = !flag16;
			object obj43 = !flag17;
			vector = (Vector3)0;
			obj21 = obj19;
			if (obj43 != null)
			{
				continue;
			}
			object obj44 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ stack_-148 (UnityEngine.Object)+68]");
			obj37 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2043 @ X0_v138+E4]");
			bool flag18 = (nint)0 == 0;
			object obj45 = !flag18;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag19 = obj37 == null;
			bool flag20 = !flag19;
			object obj46 = !flag20;
			vector = (Vector3)0;
			obj21 = obj19;
			if (obj46 != null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ stack_-148 (UnityEngine.Object)+6E8]");
			bool flag21 = !(0f < num9);
			vector = (Vector3)0;
			obj21 = obj19;
			if (flag21)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ stack_-148 (UnityEngine.Object)+68]");
			bool flag22 = (nint)0 == 0;
			goreSection = (GoreSection)0;
			obj9 = 0;
			val2 = (Enumerator<, >)0;
			obj10 = 0;
			obj11 = 0;
			val3 = (Enumerator<, >)0;
			obj18 = null;
			obj47 = 0;
			obj48 = 109891584;
			val4 = (Enumerator<, >)(ref val);
			vector = (Vector3)0;
			obj20 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ stack_-148 (UnityEngine.Object)+68]");
			flag12 = false;
			obj21 = obj19;
			if (flag22)
			{
				goto IL_1d64;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ stack_-148 (UnityEngine.Object)+68]");
			Vector3 position = ((Transform)0).position;
			float num11 = num7 - num8;
			object obj49 = obj16 - obj17;
			obj14 -= obj15;
			float num12 = num11 * num11;
			object obj50 = obj49 * obj49;
			float num13 = num12 + (float)obj50;
			obj16 = obj14 * obj14;
			num7 = (float)obj16 + num13;
			bool flag23 = (double)num7 > 9.0;
			vector = (Vector3)0;
			obj21 = obj19;
			if (flag23)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj51 = 0;
			object obj52 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2201 @ X0_v144+E4]");
			bool flag24 = (nint)0 == 0;
			object obj53 = !flag24;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ stack_-148 (UnityEngine.Object)+A8]");
			GillaWounds gillaWounds = GillaWounds.On((Dismemberment)0);
			bool flag25 = (object)gillaWounds == null;
			goreSection = (GoreSection)0;
			obj9 = 0;
			val2 = (Enumerator<, >)0;
			obj10 = 0;
			obj11 = 0;
			val3 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ stack_-148 (UnityEngine.Object)+A8]");
			obj37 = (UnityEngine.Object)0;
			obj18 = null;
			obj47 = 0;
			obj48 = 109891584;
			val4 = (Enumerator<, >)(ref val);
			vector = (Vector3)0;
			obj20 = null;
			flag12 = (byte)(int)gillaWounds != 0;
			obj21 = obj19;
			if (!flag25)
			{
				num5 = reach;
				bool flag26 = gillaWounds.Hit((Vector3)(&obj13), num8, (Vector3)(&obj12), out *(GoreSection*)null, out *(Vector3*)intPtr);
				bool flag27 = !flag26;
				reference = ref *(Landed*)null;
				num14 = num2;
				num = num4;
				num3 = num6;
				obj14 = obj15;
				obj16 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ stack_-148 (UnityEngine.Object)+A8]");
				obj37 = (UnityEngine.Object)0;
				num7 = num8;
				vector = (Vector3)(&obj12);
				obj21 = obj19;
				if (flag27)
				{
					continue;
				}
				goto IL_081f;
			}
			goto IL_1dee;
		}
		obj48 = (object)(&val);
		num9 = 0f;
		object obj54 = 7;
		object obj55 = 0;
		goto IL_227c;
		IL_1dee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		if (num15 == 0)
		{
			NullReferenceException ex2 = new NullReferenceException();
			flag12 = (byte)(int)ex2 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			if (num16 == 0)
			{
				NullReferenceException ex3 = new NullReferenceException();
				flag12 = (byte)(int)ex3 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				if (num17 == 0)
				{
					NullReferenceException ex4 = new NullReferenceException();
					flag12 = (byte)(int)ex4 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
					nint num18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
					if (num18 == 0)
					{
						NullReferenceException ex5 = new NullReferenceException();
						flag12 = (byte)(int)ex5 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
						nint num19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
						if (num19 == 0)
						{
							NullReferenceException ex6 = new NullReferenceException();
							flag12 = (byte)(int)ex6 != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
							nint num20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
							if (num20 == 0)
							{
								NullReferenceException ex7 = new NullReferenceException();
								flag12 = (byte)(int)ex7 != 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
								nint num21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
								if (num21 == 0)
								{
									NullReferenceException ex8 = new NullReferenceException();
									flag12 = (byte)(int)ex8 != 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
									nint num22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
									if (num22 == 0)
									{
										NullReferenceException ex9 = new NullReferenceException();
										flag12 = (byte)(int)ex9 != 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
										nint num23 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
										if (num23 == 0)
										{
											NullReferenceException ex10 = new NullReferenceException();
											object obj56;
											if ((nint)obj20 == 2)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
												obj18 = (UnityEngine.Object)1;
												obj56 = obj47;
											}
											else
											{
												if ((nint)obj20 != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D7E4");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
													nint num24 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
													if (num24 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
													}
													goto IL_212e;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
												object obj57 = default;
												obj56 = obj57;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
												obj47 = obj57;
											}
											object obj58 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C48]");
											object obj59 = 0;
											obj20 = (UnityEngine.Object)obj59;
											((Enumerator<, >*)val4)->Dispose();
											bool flag28 = obj56 == null;
											object obj60 = !flag28;
											flag12 = (byte)(int)val4 != 0;
											if (obj60 != null)
											{
												goto IL_1c57;
											}
											bool flag29 = (object)obj18 == null;
											object obj61 = !flag29;
											flag12 = (byte)(int)val4 != 0;
											if (obj61 != null)
											{
												goto IL_1c9c;
											}
											object obj62 = obj58 & 1;
											bool flag30 = obj62 == null;
											object obj63 = !flag30;
											flag12 = (byte)(int)val4 != 0;
											if (obj63 == null)
											{
												num9 = 0f;
												flag12 = (byte)(int)val4 != 0;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
											nint num25 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
											if (num25 == 0)
											{
												return (byte)(num9 & 1) != 0;
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
		goto IL_212e;
		IL_1c57:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		if (num26 == 0)
		{
			OutOfMemoryException ex11 = new OutOfMemoryException();
			flag12 = (byte)(int)ex11 != 0;
			goto IL_1c9c;
		}
		goto IL_212e;
		IL_1c9c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		if (num27 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			if (num28 == 0)
			{
				NullReferenceException ex12 = new NullReferenceException();
				flag12 = (byte)(int)ex12 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				nint num29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				if (num29 == 0)
				{
					NullReferenceException ex13 = new NullReferenceException();
					flag12 = (byte)(int)ex13 != 0;
					goto IL_1d64;
				}
			}
		}
		goto IL_212e;
		IL_212e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_1d64:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		if (num30 == 0)
		{
			NullReferenceException ex14 = new NullReferenceException();
			flag12 = (byte)(int)ex14 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			if (num31 == 0)
			{
				NullReferenceException ex15 = new NullReferenceException();
				flag12 = (byte)(int)ex15 != 0;
				goto IL_1dee;
			}
		}
		goto IL_212e;
		IL_081f:
		object obj64 = (object)(&val);
		_ = 0;
		_ = 0;
		((Vector3*)(nint)at)->x = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1680 @ X28_v10+1F]");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ stack_-148 (UnityEngine.Object)+6CC]");
		((Vector3*)(nint)at)->y = 0f;
		((Vector3*)(nint)at)->z = 0f;
		reference = ref *(Landed*)null;
		num14 = num2;
		num = num4;
		num3 = num6;
		obj14 = obj15;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ stack_-148 (UnityEngine.Object)+A8]");
		obj37 = (UnityEngine.Object)0;
		obj48 = (object)(&val);
		num7 = num8;
		num9 = 1f;
		vector = (Vector3)(&obj12);
		obj21 = obj19;
		obj54 = 6;
		obj55 = 0;
		goto IL_227c;
		IL_1c0a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		bool flag31 = num32 != 0;
		flag12 = (byte)(int)ex != 0;
		if (!flag31)
		{
			NullReferenceException ex16 = new NullReferenceException();
			flag12 = (byte)(int)ex16 != 0;
			goto IL_1c57;
		}
		goto IL_212e;
		IL_1ac8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		bool flag32 = num33 != 0;
		vector = (Vector3)0;
		obj20 = obj37;
		if (!flag32)
		{
			NullReferenceException ex17 = new NullReferenceException();
			obj10 = 0;
			obj11 = 0;
			val3 = (Enumerator<, >)0;
			obj18 = null;
			obj47 = 0;
			obj48 = 109891584;
			val4 = (Enumerator<, >)(ref val);
			vector = (Vector3)0;
			obj20 = obj37;
			flag12 = (byte)(int)ex17 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			nint num34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
			if (num34 == 0)
			{
				NullReferenceException ex18 = new NullReferenceException();
				goreSection = (GoreSection)0;
				obj9 = 0;
				val2 = (Enumerator<, >)0;
				flag12 = (byte)(int)ex18 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				nint num35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
				if (num35 == 0)
				{
					ex = new NullReferenceException();
					goto IL_1c0a;
				}
			}
		}
		goto IL_212e;
		IL_227c:
		obj20 = (UnityEngine.Object)obj27;
		val.Dispose();
		bool flag33 = obj55 == null;
		object obj65 = !flag33;
		goreSection = (GoreSection)0;
		obj9 = 0;
		val2 = (Enumerator<, >)0;
		obj10 = 0;
		obj11 = 0;
		val3 = (Enumerator<, >)0;
		obj18 = null;
		obj47 = 0;
		val4 = (Enumerator<, >)(ref val);
		flag12 = (byte)(&val) != 0;
		if (obj65 != null)
		{
			goto IL_1c57;
		}
		goreSection = (GoreSection)0;
		obj9 = 0;
		val2 = (Enumerator<, >)0;
		obj10 = 0;
		obj11 = 0;
		val3 = (Enumerator<, >)0;
		obj18 = null;
		obj47 = 0;
		val4 = (Enumerator<, >)(ref val);
		flag12 = (byte)(&val) != 0;
		goto IL_1c9c;
	}

	private unsafe bool OnABody(Vector3 from, Vector3 to, out Landed l)
	{
		//IL_0ba4: Expected native int or pointer, but got VT
		//IL_0bb8: Expected native int or pointer, but got VT
		//IL_0dc5: Expected Obj, but got I
		//IL_0e0b: Expected Obj, but got I4
		//IL_002e: Invalid comparison between F4 and I
		//IL_0042: Expected F8, but got I4
		//IL_004b: Expected F4, but got I4
		//IL_0e31: Expected Obj, but got I
		//IL_0e53: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_0bdd: Expected Obj, but got I
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected VT, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected Obj, but got I
		//IL_0c44: Expected Obj, but got I4
		//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Invalid comparison between VT and I4
		//IL_0b06: Invalid comparison between VT and I4
		//IL_0cef: Expected I4, but got Obj
		//IL_019e: Expected Obj, but got I4
		//IL_0ab9: Expected Obj, but got I4
		//IL_0d7b: Expected Obj, but got I
		//IL_0d83: Expected VT, but got Obj
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Expected Ref, but got Unknown
		//IL_0da6: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_01ec: Expected VT, but got I4
		//IL_0ae2: Expected Obj, but got I4
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Expected Obj, but got Unknown
		//IL_0212: Expected VT, but got I4
		//IL_021b: Expected VT, but got I4
		//IL_0a6c: Expected Obj, but got I4
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Invalid comparison between Unknown and F8
		//IL_02c0: Expected VT, but got I4
		//IL_0388: Expected Obj, but got I4
		//IL_03cd: Expected Obj, but got I4
		//IL_03f6: Expected VT, but got I4
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected VT, but got I4
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got I4
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected VT, but got I4
		//IL_0a31: Expected VT, but got Obj
		//IL_0496: Expected Obj, but got I
		//IL_04a6: Expected Obj, but got I
		//IL_04b6: Expected Obj, but got I
		//IL_04be: Expected VT, but got Obj
		//IL_04e0: Expected Obj, but got I
		//IL_0516: Expected Obj, but got I
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected Obj, but got I4
		//IL_0cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected Obj, but got I4
		//IL_0596: Expected Obj, but got I4
		//IL_059f: Expected VT, but got I4
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected VT, but got I4
		//IL_09e6: Expected Obj, but got I4
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Expected VT, but got I4
		//IL_05ef: Expected VT, but got I4
		//IL_0612: Expected VT, but got Ref
		//IL_0630: Expected Obj, but got I4
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbb: Expected Obj, but got I4
		//IL_064c: Expected VT, but got I4
		//IL_065d: Expected Obj, but got VT
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected Obj, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Invalid comparison between Unknown and I
		//IL_06e8: Expected VT, but got Ref
		//IL_0797: Expected F4, but got I4
		//IL_0792: Expected native int or pointer, but got VT
		//IL_07b8: Expected F4, but got I
		//IL_07b3: Expected native int or pointer, but got VT
		//IL_07c1: Expected native int or pointer, but got VT
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected Obj, but got I4
		//IL_080b: Expected Obj, but got I4
		//IL_0813: Expected VT, but got Ref
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = 0f;
		_ = 0;
		((Vector3*)(nint)vector)->x = 0f;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj3 = default;
		object obj4 = default;
		object obj2 = obj3 - obj4;
		object obj5 = obj;
		RaycastHit raycastHit = default;
		double num2 = default;
		double num = (double)raycastHit - num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num3 = default;
		bool flag2 = !(num3 > 0f);
		double num4 = 0.0;
		float num5 = 0f;
		if (!flag2)
		{
			float num6 = (float)num / num3;
			num5 = (float)obj2 / num3;
			num4 = num6;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v9+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v11+8]");
		bool flag5 = (nint)0 == 0;
		Enumerator<, > val = (Enumerator<, >)num5;
		if (flag5)
		{
			goto IL_0a81;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CB8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CB0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v11+8]");
		Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
		object obj18 = default;
		object obj17 = obj18;
		object obj19 = obj4;
		RaycastHit hitInfo = (RaycastHit)0;
		Enumerator<, > val2 = (Enumerator<, >)0;
		object obj20 = obj18;
		Enumerator<, > val3 = default;
		val = val3;
		Enumerator<, > val4 = default;
		UnityEngine.Object obj22;
		object obj23 = default;
		Enumerator<, > val5 = default;
		UnityEngine.Object obj26 = default;
		Vector3 vector3;
		Enumerator<, > val6 = default;
		double num11;
		UnityEngine.Object obj32 = default;
		Transform transform;
		ref Landed reference2 = default;
		Vector3 vector2;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CC0]");
			object obj21 = 0;
			bool flag6 = val4.MoveNext();
			bool flag7 = !flag6;
			obj22 = null;
			obj23 = 0;
			val5 = (Enumerator<, >)(ref val4);
			if (flag7)
			{
				break;
			}
			object obj24 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v41+E4]");
			bool flag8 = (nint)0 == 0;
			object obj25 = !flag8;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = obj26 == null;
			bool flag10 = !flag9;
			object obj27 = !flag10;
			vector2 = (Vector3)0;
			if (obj27 != null)
			{
				continue;
			}
			bool flag11 = (object)obj26 == null;
			vector2 = (Vector3)0;
			vector3 = (Vector3)0;
			ref Landed reference;
			UnityEngine.Object obj31;
			object obj33;
			Vector3 vector4;
			Enumerator<, > val7;
			if (!flag11)
			{
				Vector3 middleNow = ((GillaCorpse)obj26).MiddleNow;
				object obj28 = val - raycastHit;
				double num7 = num4 - (double)obj3;
				obj20 -= val6;
				object obj29 = obj28 * obj28;
				double num8 = num7 * num7;
				double num9 = (double)obj29 + num8;
				object obj30 = obj20 * obj20;
				val = (Enumerator<, >)(obj30 + num9);
				bool flag12 = (double)val > 16.0;
				vector2 = (Vector3)0;
				num4 = 16.0;
				if (flag12)
				{
					continue;
				}
				int num10 = 0;
				num11 = 16.0;
				while (true)
				{
					if (num10 != 0)
					{
						bool flag13 = ((GillaCorpse)obj26).IsOff(num10);
						bool flag14 = !flag13;
						reference = ref reference2;
						obj31 = obj32;
						obj33 = obj20;
						vector4 = (Vector3)0;
						val7 = val;
						if (flag14)
						{
							goto IL_0933;
						}
					}
					transform = ((GillaCorpse)obj26).PartTransform(num10);
					object obj34 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X0_v54+E4]");
					bool flag15 = (nint)0 == 0;
					object obj35 = !flag15;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag16 = transform == null;
					bool flag17 = !flag16;
					object obj36 = !flag17;
					reference = ref reference2;
					obj31 = obj32;
					Transform transform2 = transform;
					obj33 = obj20;
					vector4 = (Vector3)0;
					val7 = val;
					if (obj36 == null)
					{
						break;
					}
					goto IL_0933;
					IL_0933:
					num10++;
					bool flag18 = num10 != 4;
					reference2 = ref reference;
					obj32 = obj31;
					obj20 = obj33;
					val = val7;
					if (flag18)
					{
						continue;
					}
					goto IL_0981;
				}
				goto IL_040c;
			}
			goto IL_0a4d;
			IL_0981:
			reference2 = ref reference;
			obj32 = obj31;
			obj20 = obj33;
			vector2 = vector4;
			num4 = num11;
			val = val7;
		}
		goto IL_0abe;
		IL_0a20:
		OutOfMemoryException ex = new OutOfMemoryException();
		UnityEngine.Object obj37;
		vector3 = (Vector3)obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		num4 = num11;
		goto IL_0a4d;
		IL_0d48:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D85C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_040c:
		object obj38 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X0_v58+E4]");
		bool flag19 = (nint)0 == 0;
		object obj39 = !flag19;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = (object)transform == null;
		vector2 = (Vector3)0;
		obj37 = null;
		NullReferenceException ex2;
		if (!flag20)
		{
			object obj40 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X8_v40+A0]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v41+28]");
			obj37 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CA0]");
			object obj42 = 0;
			vector2 = (Vector3)obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F9CC");
			object obj43 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ X8_v44+A0]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X8_v45+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X8_v45+28]");
				Enumerator<, > enumerator2 = ((List<System.__Canon>)0).GetEnumerator();
				Enumerator<, > val8 = default;
				val = val8;
				double num12 = default;
				Enumerator<, > val11 = default;
				object obj55 = default;
				Enumerator<, > val12;
				while (true)
				{
					if (val2.MoveNext())
					{
						object obj45 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X0_v76+E4]");
						bool flag21 = (nint)0 == 0;
						object obj46 = !flag21;
						if (obj46 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag22 = obj32 == null;
						bool flag23 = !flag22;
						object obj47 = !flag23;
						vector2 = (Vector3)0;
						if (obj47 != null)
						{
							continue;
						}
						if ((object)obj32 == null)
						{
							break;
						}
						bool flag24 = ((Collider)obj32).enabled;
						bool flag25 = !flag24;
						vector2 = (Vector3)0;
						if (flag25)
						{
							continue;
						}
						bool flag26 = ((Collider)obj32).Raycast((Ray)(&num12), out hitInfo, num3);
						bool flag27 = !flag26;
						object obj48 = !flag27;
						Enumerator<, > val10;
						if (obj48 == null)
						{
							Vector3 vector5 = ((Collider)obj32).ClosestPoint((Vector3)0);
							object obj49 = raycastHit - raycastHit;
							object obj50 = obj3 - obj3;
							obj20 = val6 - val6;
							object obj51 = obj49 * obj49;
							object obj52 = obj50 * obj50;
							object obj53 = obj51 + obj52;
							num11 = (double)obj20 * (double)obj20;
							val = (Enumerator<, >)(num11 + obj53);
							Enumerator<, > val9 = val;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
							bool flag28 = (nint)val9 >= (nint)0;
							reference2 = ref *(Landed*)null;
							num12 = num2;
							vector2 = (Vector3)(&hitInfo);
							if (flag28)
							{
								continue;
							}
							val10 = val6;
							RaycastHit raycastHit2 = raycastHit;
							object obj54 = obj3;
						}
						else
						{
							val10 = val11;
							RaycastHit raycastHit2 = hitInfo;
							object obj54 = obj55;
							num11 = num2;
							val = val11;
						}
						Transform t = ((Component)obj32).transform;
						object obj56 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1219 @ X0_v88+E4]");
						bool flag29 = (nint)0 == 0;
						object obj57 = !flag29;
						if (obj57 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GoreSection goreSection = SectionOf(t);
						((Vector3*)(nint)vector)->x = 3f;
						_ = 0;
						_ = 0;
						Vector3 vector6 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ stack_-118_v5 (UnityEngine.Object)+30]");
						((Vector3*)(nint)vector6)->y = 0f;
						((Vector3*)(nint)vector)->z = 0f;
						_ = 0;
						_ = 0;
						object obj58 = 12;
						object obj59 = obj18;
						object obj60 = obj4;
						reference2 = ref *(Landed*)null;
						num12 = num2;
						Transform transform2 = (Transform)1;
						vector2 = (Vector3)(&hitInfo);
						val = val10;
					}
					else
					{
						object obj58 = 7;
						object obj59 = obj17;
						object obj60 = obj19;
						Transform transform2 = null;
					}
					obj37 = (UnityEngine.Object)obj16;
					val2.Dispose();
					val12 = (Enumerator<, >)(ref val2);
					goto IL_0a20;
				}
				ex2 = new NullReferenceException();
				val12 = (Enumerator<, >)(ref val2);
				obj18 = obj20;
				vector2 = (Vector3)0;
				obj26 = null;
				obj23 = 0;
				val5 = (Enumerator<, >)(ref val4);
				vector = (Vector3)0;
				num4 = num11;
				goto IL_0d19;
			}
			NullReferenceException ex3 = new NullReferenceException();
		}
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0a20;
		IL_0abe:
		Transform transform3 = null;
		bool result2 = (byte)(int)transform3 != 0;
		object obj61 = obj23;
		goto IL_0d6b;
		IL_0a4d:
		NullReferenceException ex5 = new NullReferenceException();
		obj18 = obj20;
		obj26 = null;
		obj23 = 0;
		val5 = (Enumerator<, >)(ref val4);
		vector = vector3;
		goto IL_0a81;
		IL_0d6b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CA8]");
		object obj62 = 0;
		vector = (Vector3)obj62;
		((Enumerator<, >*)val5)->Dispose();
		bool flag30 = obj61 == null;
		object obj63 = !flag30;
		if (obj63 == null)
		{
			bool flag31 = (object)obj22 == null;
			object obj64 = !flag31;
			OutOfMemoryException ex6 = (OutOfMemoryException)val5;
			if (obj64 == null)
			{
				return result2;
			}
		}
		else
		{
			OutOfMemoryException ex6 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex8 = default;
		NullReferenceException ex7 = ex8;
		obj18 = obj20;
		goto IL_0d48;
		IL_0d19:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D820");
		if (vector == (Vector3)(object)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj20 = obj18;
			obj22 = (UnityEngine.Object)1;
			goto IL_0abe;
		}
		bool flag32 = vector != (Vector3)(object)1;
		ex7 = ex2;
		if (flag32)
		{
			goto IL_0d48;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
		object obj65 = default;
		obj61 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		result2 = false;
		obj20 = obj18;
		obj22 = obj26;
		goto IL_0d6b;
		IL_0a81:
		ex2 = new NullReferenceException();
		goto IL_0d19;
	}

	private static GoreSection SectionOf(Transform t)
	{
		//IL_0211: Expected I4, but got Obj
		//IL_003f: Expected Obj, but got I
		//IL_0067: Expected I4, but got I8
		//IL_0081: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I
		//IL_00d5: Expected I4, but got I8
		//IL_0162: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I
		//IL_012a: Expected I4, but got I8
		//IL_0144: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I
		if ((object)t != null)
		{
			string text = t.name;
			if (text != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F0]");
				object value = 0;
				int num = text.IndexOf((string)value, (StringComparison)5);
				int num2 = (int)(num & 0x80000000L);
				bool flag = num2 == 0;
				object obj = !flag;
				if (obj == null)
				{
					return (GoreSection)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CE8]");
				object value2 = 0;
				int num3 = text.IndexOf((string)value2, (StringComparison)5);
				if ((int)(num3 & 0x80000000L) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CF0]");
					object value3 = 0;
					int num4 = text.IndexOf((string)value3, (StringComparison)5);
					int num5 = (int)(num4 & 0x80000000L);
					bool flag2 = num5 == 0;
					object obj2 = !flag2;
					if (obj2 != null)
					{
						return (GoreSection)1;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CF8]");
				object value4 = 0;
				bool flag3 = text.EndsWith((string)value4);
				bool flag4 = !flag3;
				object obj3 = !flag4;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D00]");
					object value5 = 0;
					if (!text.EndsWith((string)value5))
					{
						return (GoreSection)2;
					}
				}
				return (GoreSection)3;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (GoreSection)(int)ex;
	}

	private unsafe bool Lands(int e, Landed l, Vector3 at, Vector3 going, float speed)
	{
		//IL_06d4: Expected I4, but got Obj
		//IL_0048: Expected VT, but got I4
		//IL_0083: Expected F8, but got I4
		//IL_00cd: Invalid comparison between F8 and I4
		//IL_00dc: Expected F8, but got I4
		//IL_06e9: Expected Obj, but got I
		//IL_06ff: Invalid comparison between F4 and I4
		//IL_0710: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0760: Expected Obj, but got I
		//IL_02b1: Expected I4, but got I8
		//IL_02cb: Expected Obj, but got I4
		//IL_032f: Expected Ref, but got VT
		//IL_032f: Expected VT, but got Ref
		//IL_032f: Expected VT, but got Ref
		//IL_0498: Expected VT, but got Ref
		//IL_04a8: Expected VT, but got Ref
		//IL_057c: Invalid comparison between F4 and Obj
		//IL_04c1: Invalid comparison between F4 and Obj
		//IL_0315: Expected VT, but got I4
		//IL_0599: Invalid comparison between F8 and I4
		//IL_0382: Unsupported input type for neg.
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_03db: Invalid comparison between F4 and I
		//IL_0467: Expected VT, but got Ref
		//IL_0478: Expected VT, but got Ref
		//IL_03f3: Unsupported input type for neg.
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_06b3: Expected F4, but got I
		//IL_06b3: Expected F4, but got VT
		//IL_061b: Expected F4, but got I
		//IL_061b: Expected F4, but got VT
		//IL_061b: Expected VT, but got Ref
		//IL_053d: Expected VT, but got Ref
		//IL_0557: Expected Obj, but got I4
		//IL_055f: Expected VT, but got Ref
		Transform transform = base.transform;
		Vector3 vector = Along(e);
		double num5;
		object obj = default;
		Vector3 vector3;
		if ((object)transform != null)
		{
			Vector3 vector2 = transform.TransformDirection((Vector3)0);
			double num = pushSpeed;
			double num2 = hardSpeed;
			bool flag = pushSpeed == hardSpeed;
			double num4 = default;
			double num3 = num4;
			num5 = 0.0;
			if (!flag)
			{
				num3 = (double)obj - (double)pushSpeed;
				double num6 = (double)hardSpeed - (double)pushSpeed;
				num = num3 / num6;
				bool flag2 = num < 0.0;
				num5 = 0.0;
				if (!flag2)
				{
					bool flag3 = !(num > 1.0);
					num5 = num;
					num2 = 1.0;
					if (!flag3)
					{
						num5 = 1.0;
						num2 = 1.0;
						num = 1.0;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj2 = 0;
			GillaPickaxe gillaPickaxe = (GillaPickaxe)obj2;
			bool flag4 = gillaPickaxe.countsAt == 0f;
			object obj3 = !flag4;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = default;
			object obj4 = obj5 * obj5;
			object obj7 = default;
			object obj6 = obj7 * obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj8 = 0;
			object obj9 = obj4 + obj6;
			object obj11 = default;
			object obj10 = obj11 * obj11;
			object obj12 = obj10 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj13;
			object obj14;
			object obj15;
			if ((nint)obj12 > 0)
			{
				obj13 = obj5 / obj12;
				obj14 = obj7 / obj12;
				obj15 = obj11 / obj12;
			}
			else
			{
				object obj16 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v24+A0]");
				object obj17 = 0;
				obj13 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v25+4]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v25+8]");
				obj15 = 0;
			}
			object obj18 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v13+A0]");
			object obj19 = 0;
			GillaItem gillaItem = item;
			if ((object)item != null)
			{
				object obj21 = default;
				object obj20 = obj21 * obj14;
				float num7 = speed * (float)obj13;
				float num8 = num7 + (float)obj20;
				double num9 = num4 * (double)obj15;
				float num10 = (float)num9 + num8;
				int num11 = (int)(gillaItem.Hand__BackingField & 0x80000000L);
				bool flag5 = num11 == 0;
				object obj22 = !flag5;
				RpcInfo info;
				bool flag6;
				if (obj22 == null)
				{
					if (!(num10 < inLine))
					{
						goto IL_0572;
					}
					info = (RpcInfo)l;
					flag6 = false;
					vector3 = (Vector3)0;
				}
				else
				{
					object obj23 = default;
					object obj24 = default;
					bool flag7 = gillaPickaxe.FacingAt((Landed)(&obj23), (Vector3)(&obj24), out *(Vector3*)at);
					if (flag7 && num10 < inLine)
					{
						object obj26 = default;
						object obj25 = obj26 * obj21;
						object obj27 = 0 - obj25;
						float num12 = speed * (float)obj24;
						float num13 = (float)obj27 - num12;
						double num14 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v2+20]");
						double num15 = num14 * 0.0;
						float num16 = num13 - (float)num15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
						if (!(num16 < 0f))
						{
							object obj28 = 0 - obj26;
							object obj29 = obj5 * obj24;
							object obj30 = obj7 * obj28;
							object obj31 = obj30 - obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v2+20]");
							object obj32 = obj11 * 0;
							object obj33 = obj31 - obj32;
							if ((nint)obj33 > 0)
							{
								goto IL_0572;
							}
						}
						info = (RpcInfo)(&obj24);
						flag6 = true;
						vector3 = (Vector3)(&obj23);
					}
					else
					{
						bool flag8 = !(num10 < inLine);
						info = (RpcInfo)(&obj24);
						flag6 = flag7;
						vector3 = (Vector3)(&obj23);
						if (flag8)
						{
							goto IL_0572;
						}
					}
				}
				float num17 = knockSpeed;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num17) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
				{
					goto IL_0620;
				}
				float time = Time.time;
				float num18 = time;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num19 = num18 + 0f;
				againAt = num19;
				if (Live)
				{
					object obj34 = default;
					RPC_Knock((Vector3)(&obj34), speed, info);
					bool flag9 = !flag6;
					object obj35 = !flag9;
					vector3 = (Vector3)(&obj34);
					if (obj35 != null)
					{
						goto IL_0659;
					}
				}
				else
				{
					Knock(vector3, speed);
					if (flag6)
					{
						goto IL_0659;
					}
				}
				goto IL_06b8;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0659:
		Bounce(vector3);
		goto IL_06b8;
		IL_0620:
		return false;
		IL_0572:
		float num20 = stabSpeed;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num20) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			goto IL_0620;
		}
		Vector3 way = default;
		if (num5 < 0.0 || !(num5 > 1.0))
		{
			bool result = default;
			if (e == 1)
			{
				return result;
			}
			if (!Live)
			{
				Into kind = l.into;
				int id = l.id;
				NetworkId thing = l.thing;
				GoreSection s = l.section;
				Vector3 vector4 = l.point;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X2 (GillaPickaxe+Landed)+14]");
				Vector3 p = default;
				In(e, kind, id, thing, s, p, way, (float)vector4, 0f);
				goto IL_06b8;
			}
		}
		Into kind2 = l.into;
		int id2 = l.id;
		NetworkId thing2 = l.thing;
		GoreSection s2 = l.section;
		Vector3 vector5 = l.point;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X2 (GillaPickaxe+Landed)+14]");
		object obj36 = default;
		RpcInfo info2 = default;
		RPC_In((byte)e, (byte)kind2, id2, thing2, (byte)s2, (Vector3)(&obj36), way, (float)vector5, 0f, info2);
		goto IL_06b8;
		IL_06b8:
		return true;
	}

	private unsafe bool FacingAt(Landed l, Vector3 at, out Vector3 normal)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0ae8: Expected I4, but got Obj
		//IL_003e: Expected VT, but got I4
		//IL_0b28: Expected Obj, but got I
		//IL_0b40: Expected Obj, but got I
		//IL_0b55: Expected F4, but got I
		//IL_0b50: Expected native int or pointer, but got VT
		//IL_0b6a: Expected F4, but got I
		//IL_0b65: Expected native int or pointer, but got VT
		//IL_0b7a: Expected Obj, but got I
		//IL_0b88: Invalid comparison between VT and I4
		//IL_023c: Invalid comparison between VT and I4
		//IL_0622: Expected Obj, but got I
		//IL_064c: Expected Obj, but got I4
		//IL_0051: Invalid comparison between VT and I4
		//IL_06a8: Expected Obj, but got I4
		//IL_025e: Invalid comparison between VT and I4
		//IL_0429: Expected Obj, but got I
		//IL_0453: Expected Obj, but got I4
		//IL_0bc6: Expected Obj, but got I4
		//IL_0cbe: Expected Obj, but got I
		//IL_0cce: Expected Obj, but got I
		//IL_0ce8: Expected Obj, but got I
		//IL_0cf9: Expected I, but got Obj
		//IL_0073: Invalid comparison between VT and I4
		//IL_02a1: Expected Obj, but got I8
		//IL_02bb: Expected Obj, but got I4
		//IL_0488: Expected Obj, but got I
		//IL_049d: Expected Obj, but got I
		//IL_04cb: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I8
		//IL_00d0: Expected Obj, but got I4
		//IL_0ca0: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I4
		//IL_0513: Expected VT, but got I4
		//IL_072f: Expected Ref, but got VT
		//IL_072f: Expected VT, but got Ref
		//IL_08f3: Expected VT, but got I4
		//IL_0c51: Expected Obj, but got I
		//IL_0c33: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_0ac3: Expected Ref, but got VT
		//IL_0ac3: Expected VT, but got Ref
		//IL_0784: Expected VT, but got I4
		//IL_0be4: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I4
		//IL_0952: Expected Obj, but got I4
		//IL_0376: Expected Obj, but got I4
		//IL_05a1: Expected Obj, but got I
		//IL_05c2: Expected VT, but got I4
		//IL_0981: Expected Obj, but got I
		//IL_099d: Expected VT, but got I4
		//IL_03db: Expected Obj, but got I
		//IL_03e3: Expected VT, but got Obj
		//IL_040c: Expected Obj, but got I
		//IL_07e3: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I
		//IL_05ea: Expected Obj, but got I
		//IL_05fa: Expected Obj, but got I
		//IL_0608: Expected VT, but got I4
		//IL_0812: Expected Obj, but got I
		//IL_082e: Expected VT, but got I4
		//IL_01f0: Expected Obj, but got I
		//IL_01f8: Expected VT, but got Obj
		//IL_0221: Expected Obj, but got I
		//IL_09c5: Expected Obj, but got I
		//IL_0d48: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I
		//IL_0856: Expected Obj, but got I
		//IL_0866: Expected Obj, but got I
		//IL_086f: Expected VT, but got I4
		//IL_0a3b: Expected VT, but got I4
		//IL_0a1f: Expected Obj, but got I
		//IL_0a28: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D08]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass161_0 obj2 = default;
		obj2._002Ector();
		if (obj2 == null)
		{
			goto IL_0ada;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPickaxe+Landed)+18]");
		_ = 0;
		_ = l.point;
		obj2.l = (Landed)l.into;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v8+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v9+18]");
		((Vector3*)(nint)at)->x = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v9+20]");
		((Vector3*)(nint)at)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		UnityEngine.Object obj8;
		UnityEngine.Object obj20;
		object obj32;
		Dismemberment dismemberment;
		object obj39 = default;
		float num = default;
		Vector3 world;
		GoreSection world2;
		Vector3 normal2;
		UnityEngine.Object obj51;
		Vector3 vector;
		UnityEngine.Object obj7;
		if (obj2.l <= (object)2)
		{
			if (obj2.l != (Landed)(object)1)
			{
				bool flag = obj2.l != (Landed)(object)2;
				vector = at;
				obj7 = null;
				obj8 = null;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (GillaPickaxe+<>c__DisplayClass161_0)+14]");
					object obj9 = 0 & 0x80000000L;
					bool flag2 = obj9 == null;
					object obj10 = !flag2;
					Vector3 vector2;
					UnityEngine.Object obj19;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
						object obj11 = 0;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v88+E4]");
						bool flag3 = (nint)0 == 0;
						object obj13 = !flag3;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj12 = obj11;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v88+A0]");
						object obj14 = 0;
						List<System.__Canon> list = (List<System.__Canon>)obj14;
						if (obj14 == null)
						{
							goto IL_0ada;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (GillaPickaxe+<>c__DisplayClass161_0)+14]");
						if ((nint)0 < (nint)list._size)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v88+E4]");
							bool flag4 = (nint)0 == 0;
							object obj15 = !flag4;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj16 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v55+A0]");
								object obj17 = 0;
								list = (List<System.__Canon>)obj17;
								if (obj17 == null)
								{
									goto IL_0ada;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D20]");
							object obj18 = 0;
							vector2 = (Vector3)obj18;
							List<System.__Canon> list2 = list;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (GillaPickaxe+<>c__DisplayClass161_0)+14]");
							System.__Canon _Canon = list2.get_Item(0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (GillaPickaxe+<>c__DisplayClass161_0)+14]");
							obj19 = (UnityEngine.Object)0;
							obj20 = (UnityEngine.Object)(object)_Canon;
							goto IL_0c09;
						}
					}
					vector2 = at;
					obj19 = null;
					obj20 = null;
					goto IL_0c09;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
				object obj21 = 0;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v58+E4]");
				bool flag5 = (nint)0 == 0;
				object obj23 = !flag5;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj22 = obj21;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v58+A0]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C10]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D30]");
				object obj26 = 0;
				Predicate<System.__Canon> predicate = default;
				predicate._002Ector((object)obj2, (IntPtr)obj26);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v36+8]");
				if ((nint)0 == 0)
				{
					goto IL_0ada;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C00]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v36+8]");
				System.__Canon _Canon2 = ((List<System.__Canon>)0).Find(predicate);
				object obj28 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v41+E4]");
				bool flag6 = (nint)0 == 0;
				object obj29 = !flag6;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = (UnityEngine.Object)(object)_Canon2 != null;
				bool flag8 = !flag7;
				ref Vector3 reference = ref *(Vector3*)null;
				vector = (Vector3)0;
				obj7 = null;
				obj8 = null;
				if (!flag8)
				{
					if (_Canon2 == null)
					{
						goto IL_0ada;
					}
					object obj30 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X0_v66+E4]");
					bool flag9 = (nint)0 == 0;
					object obj31 = !flag9;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X0_v62 (System.__Canon)+A8]");
					bool flag10 = (UnityEngine.Object)0 != null;
					bool flag11 = !flag10;
					reference = ref *(Vector3*)null;
					vector = (Vector3)0;
					obj7 = null;
					obj8 = null;
					if (!flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
						obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X0_v62 (System.__Canon)+A8]");
						dismemberment = (Dismemberment)0;
						reference = ref *(Vector3*)null;
						vector = (Vector3)0;
						UnityEngine.Object obj33 = null;
						goto IL_0d1e;
					}
				}
			}
		}
		else
		{
			if (obj2.l == (Landed)(object)3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
				object obj34 = 0;
				object obj35 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v19+E4]");
				bool flag12 = (nint)0 == 0;
				object obj36 = !flag12;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (GillaPickaxe+<>c__DisplayClass161_0)+14]");
				GillaCorpse gillaCorpse = GillaCorpse.Find(0);
				object obj37 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v19+E4]");
				bool flag13 = (nint)0 == 0;
				object obj38 = !flag13;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(gillaCorpse != null))
				{
					goto IL_0acc;
				}
				if ((object)gillaCorpse != null)
				{
					return gillaCorpse.Surface((Vector3)(&obj39), num, out *(GoreSection*)(&world), out *(Vector3*)(&world2), out *(Vector3*)at, out normal2, out *(float*)null);
				}
				goto IL_0ada;
			}
			bool flag14 = obj2.l != (Landed)(object)4;
			vector = at;
			obj7 = null;
			obj8 = null;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (GillaPickaxe+<>c__DisplayClass161_0)+14]");
				object obj40 = 0 & 0x80000000L;
				bool flag15 = obj40 == null;
				object obj41 = !flag15;
				Vector3 vector3;
				UnityEngine.Object obj50;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
					object obj42 = 0;
					object obj43 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v44+E4]");
					bool flag16 = (nint)0 == 0;
					object obj44 = !flag16;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj43 = obj42;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v44+A0]");
					object obj45 = 0;
					List<System.__Canon> list3 = (List<System.__Canon>)obj45;
					if (obj45 == null)
					{
						goto IL_0ada;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (GillaPickaxe+<>c__DisplayClass161_0)+14]");
					if ((nint)0 < (nint)list3._size)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v44+E4]");
						bool flag17 = (nint)0 == 0;
						object obj46 = !flag17;
						if (obj46 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj47 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v30+A0]");
							object obj48 = 0;
							list3 = (List<System.__Canon>)obj48;
							if (obj48 == null)
							{
								goto IL_0ada;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D28]");
						object obj49 = 0;
						vector3 = (Vector3)obj49;
						List<System.__Canon> list4 = list3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (GillaPickaxe+<>c__DisplayClass161_0)+14]");
						System.__Canon _Canon3 = list4.get_Item(0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (GillaPickaxe+<>c__DisplayClass161_0)+14]");
						obj50 = (UnityEngine.Object)0;
						obj51 = (UnityEngine.Object)(object)_Canon3;
						goto IL_0c76;
					}
				}
				vector3 = at;
				obj50 = null;
				obj51 = null;
				goto IL_0c76;
			}
		}
		goto IL_0b9c;
		IL_0c76:
		object obj52 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v32+E4]");
		bool flag18 = (nint)0 == 0;
		object obj53 = !flag18;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag19 = obj51 != null;
		bool flag20 = !flag19;
		vector = (Vector3)0;
		obj7 = null;
		obj8 = null;
		if (!flag20)
		{
			if ((object)obj51 == null)
			{
				goto IL_0ada;
			}
			object obj54 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v36+E4]");
			bool flag21 = (nint)0 == 0;
			object obj55 = !flag21;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X20_v11 (UnityEngine.Object)+108]");
			bool flag22 = (UnityEngine.Object)0 != null;
			bool flag23 = !flag22;
			vector = (Vector3)0;
			obj7 = null;
			obj8 = null;
			if (!flag23)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X20_v11 (UnityEngine.Object)+108]");
				object obj56 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X20_v11 (UnityEngine.Object)+108]");
				if ((nint)0 == 0)
				{
					goto IL_0ada;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v24+88]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v24+78]");
					obj8 = (UnityEngine.Object)0;
					vector = (Vector3)0;
					obj7 = null;
				}
				else
				{
					vector = (Vector3)0;
					obj7 = null;
					obj8 = null;
				}
			}
		}
		goto IL_0b9c;
		IL_0acc:
		return false;
		IL_0c09:
		object obj57 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X0_v76+E4]");
		bool flag24 = (nint)0 == 0;
		object obj58 = !flag24;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag25 = obj20 != null;
		bool flag26 = !flag25;
		vector = (Vector3)0;
		obj7 = null;
		obj8 = null;
		if (!flag26)
		{
			if ((object)obj20 == null)
			{
				goto IL_0ada;
			}
			object obj59 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v80+E4]");
			bool flag27 = (nint)0 == 0;
			object obj60 = !flag27;
			if (obj60 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X20_v17 (UnityEngine.Object)+80]");
			bool flag28 = (UnityEngine.Object)0 != null;
			bool flag29 = !flag28;
			vector = (Vector3)0;
			obj7 = null;
			obj8 = null;
			if (!flag29)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X20_v17 (UnityEngine.Object)+80]");
				dismemberment = (Dismemberment)0;
				vector = (Vector3)0;
				UnityEngine.Object obj33 = null;
				goto IL_0d1e;
			}
		}
		goto IL_0b9c;
		IL_0ada:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0d1e:
		object obj61 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v52+E4]");
		bool flag30 = (nint)0 == 0;
		object obj62 = !flag30;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds gillaWounds = GillaWounds.On(dismemberment);
		obj7 = null;
		obj8 = gillaWounds;
		goto IL_0b9c;
		IL_0b9c:
		object obj63 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v10+E4]");
		bool flag31 = (nint)0 == 0;
		object obj64 = !flag31;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(obj8 != null))
		{
			goto IL_0acc;
		}
		if ((object)obj8 != null)
		{
			return ((GillaWounds)obj8).Surface((Vector3)(&obj39), num, out world2, out world, out *(Vector3*)at, out normal2, out *(float*)null);
		}
		goto IL_0ada;
	}

	private void Bounce(Vector3 skin)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0131: Expected VT, but got I4
		//IL_0111: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj5 = default;
		bool flag2 = obj5 == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 == null && !((Rigidbody)obj5).isKinematic)
		{
			Vector3 linearVelocity = ((Rigidbody)obj5).linearVelocity;
			object obj8 = default;
			object obj7 = obj8 * obj8;
			object obj10 = default;
			object obj9 = obj10 * obj10;
			object obj11 = obj7 + obj9;
			object obj13 = default;
			object obj12 = obj13 * obj13;
			object obj14 = obj12 + obj11;
			if ((nint)obj14 < 0)
			{
				((Rigidbody)obj5).linearVelocity = (Vector3)0;
			}
			Vector3 angularVelocity = ((Rigidbody)obj5).angularVelocity;
			((Rigidbody)obj5).angularVelocity = (Vector3)0;
		}
	}

	private unsafe void Scrapes(int e, Vector3 tip)
	{
		//IL_0020: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I
		//IL_00b9: Expected Ref, but got VT
		//IL_00b9: Expected VT, but got Ref
		//IL_00f4: Expected VT, but got Ref
		//IL_0518: Expected Obj, but got I4
		//IL_0527: Expected Obj, but got I4
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_01f7: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_01a5: Expected VT, but got I4
		//IL_01ae: Expected VT, but got I4
		//IL_027d: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02dc: Expected Obj, but got I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0582: Expected Obj, but got I4
		//IL_059a: Expected Obj, but got I4
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected Obj, but got Unknown
		//IL_03a1: Expected Obj, but got I
		//IL_03b1: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I
		//IL_03eb: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got I
		//IL_05ec: Expected Obj, but got I4
		//IL_061b: Expected Obj, but got I
		//IL_0637: Expected VT, but got I4
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Expected Obj, but got Unknown
		//IL_0934: Expected Obj, but got I
		//IL_096b: Expected Obj, but got I4
		//IL_0482: Expected VT, but got I4
		//IL_0482: Expected Obj, but got I
		//IL_048f: Expected VT, but got I4
		//IL_04af: Expected Obj, but got I
		//IL_04bf: Expected Obj, but got I
		//IL_04cf: Expected Obj, but got I
		//IL_0695: Expected VT, but got I4
		//IL_0695: Expected Obj, but got I
		//IL_06a2: Expected VT, but got I4
		//IL_06c2: Expected Obj, but got I
		//IL_06d2: Expected Obj, but got I
		//IL_06e2: Expected Obj, but got I
		//IL_078a: Expected Obj, but got I4
		//IL_0799: Expected Obj, but got I4
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		//IL_07da: Expected Obj, but got I4
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected Obj, but got Unknown
		//IL_082b: Invalid comparison between Obj and F8
		//IL_08ce: Expected F4, but got I
		//IL_08ce: Expected F4, but got I
		//IL_0888: Expected VT, but got Ref
		bool[] array = scraping;
		if (scraping == null)
		{
			goto IL_08d3;
		}
		bool flag = array.Length < e;
		object obj = !flag;
		object obj2 = array.Length - e;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		byte b = default;
		int num2 = default;
		byte b2 = default;
		object obj30;
		object obj31;
		object obj15 = default;
		object obj9;
		if (obj4 == null)
		{
			object obj5 = 17281024 + 3968;
			object obj6 = scraping + e;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v6+20]");
			bool flag3 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X9_v5+v188 @ Z_v4 (System.Boolean)*4]");
			object obj7 = 0;
			float num = default;
			if (OnSkin((Vector3)(&b), num, out *(Skin*)tip))
			{
				object obj8 = default;
				bool flag4 = (nint)obj8 <= 0;
				Vector3 vector = (Vector3)(&b);
				obj9 = obj8;
				if (!flag4)
				{
					Transform transform = base.transform;
					if ((object)transform == null)
					{
						goto IL_08d3;
					}
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
					object obj11 = default;
					object obj10 = obj11 * obj8;
					object obj13 = default;
					object obj12 = obj13 * obj8;
					obj7 = 0 * obj8;
					obj9 = obj8 + obj10;
					object obj14 = obj14 + obj12;
					obj15 += obj7;
					transform.position = (Vector3)0;
					vector = (Vector3)0;
				}
				Skin[] array2 = scrapedFrom;
				if (scrapedFrom == null)
				{
					goto IL_08d3;
				}
				bool flag5 = array2.Length < e;
				object obj16 = !flag5;
				object obj17 = array2.Length - e;
				bool flag6 = obj17 == null;
				object obj18 = ~obj16;
				object obj19 = obj18 | flag6;
				if (obj19 == null)
				{
					bool[] array3 = scraping;
					if (scraping == null)
					{
						goto IL_08d3;
					}
					bool flag7 = array3.Length < e;
					object obj20 = !flag7;
					object obj21 = array3.Length - e;
					bool flag8 = obj21 == null;
					object obj22 = ~obj20;
					object obj23 = obj22 | flag8;
					if (obj23 == null)
					{
						object obj24 = scraping + e;
						object obj25 = e * 72;
						object obj26 = (object)scrapedFrom + obj25;
						object obj27 = obj24 + 32;
						object obj28 = obj26 + 32;
						if (obj27 != null && (int)b == (nint)obj28)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+4]");
							if ((nint)0 == num2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+C]");
								if ((nint)0 == (int)b2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
									object obj29 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+10]");
									obj30 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+18]");
									obj31 = 0;
									object obj32 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v15+E4]");
									bool flag9 = (nint)0 == 0;
									object obj33 = !flag9;
									if (obj33 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+40]");
									if ((UnityEngine.Object)0 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+40]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+40]");
											nint num3 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+C]");
											Vector3 vector2 = ((GillaCorpse)num3).WorldOn((GoreSection)0, (Vector3)0);
											Vector3 vector3 = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+C]");
											GoreSection goreSection = (GoreSection)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+24]");
											obj15 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+20]");
											object obj14 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+1C]");
											obj9 = 0;
											goto IL_06e7;
										}
									}
									else
									{
										object obj34 = obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v36+E4]");
										bool flag10 = (nint)0 == 0;
										object obj35 = !flag10;
										if (obj35 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+38]");
										bool flag11 = (UnityEngine.Object)0 != null;
										bool flag12 = !flag11;
										Vector3 vector3 = (Vector3)0;
										GoreSection goreSection = (GoreSection)0;
										if (flag12)
										{
											goto IL_0916;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+38]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+38]");
											nint num4 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+C]");
											Vector3 vector4 = ((GillaWounds)num4).WorldOn((GoreSection)0, (Vector3)0);
											vector3 = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+C]");
											goreSection = (GoreSection)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+24]");
											obj15 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+20]");
											object obj14 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v10+1C]");
											obj9 = 0;
											goto IL_06e7;
										}
									}
									goto IL_08d3;
								}
							}
						}
						object obj36 = e * 72;
						object obj37 = (object)scrapedFrom + obj36;
						obj27 = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
						object obj38 = obj37 + 88;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						return;
					}
				}
			}
			else
			{
				bool[] array4 = scraping;
				if (scraping == null)
				{
					goto IL_08d3;
				}
				bool flag13 = array4.Length < e;
				object obj39 = !flag13;
				object obj40 = array4.Length - e;
				bool flag14 = obj40 == null;
				object obj41 = ~obj39;
				object obj42 = obj41 | flag14;
				if (obj42 == null)
				{
					object obj43 = scraping + e;
					_ = 0;
					return;
				}
			}
		}
		goto IL_08e1;
		IL_08d3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_08e1;
		IL_0916:
		object obj44 = 0 - obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj45 = 0;
		object obj47 = default;
		object obj46 = obj47 - obj31;
		object obj48 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v19+E4]");
		bool flag15 = (nint)0 == 0;
		object obj49 = !flag15;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj50 = obj46 * obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D8]");
		if ((nint)obj44 < 0)
		{
			return;
		}
		Skin[] array5 = scrapedFrom;
		if (scrapedFrom == null)
		{
			goto IL_08d3;
		}
		bool flag16 = array5.Length < e;
		object obj51 = !flag16;
		object obj52 = array5.Length - e;
		bool flag17 = obj52 == null;
		object obj53 = ~obj51;
		object obj54 = obj53 | flag17;
		if (obj54 == null)
		{
			object obj55 = e * 72;
			object obj56 = (object)scrapedFrom + obj55;
			object obj57 = obj56 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
			object obj58 = obj56 + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.25))
			{
				NetworkId thing = default;
				Vector3 to = default;
				if (Live)
				{
					object obj59 = default;
					RpcInfo info = default;
					RPC_Scratch(b, num2, thing, b2, (Vector3)(&obj59), to, info);
				}
				else
				{
					Vector3 vector5 = default;
					Scratch(b, num2, thing, b2, vector5, to);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B000]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
				Buzz(num5, 0f);
			}
			return;
		}
		goto IL_08e1;
		IL_06e7:
		obj31 = obj15;
		obj30 = obj9;
		goto IL_0916;
		IL_08e1:
		throw new IndexOutOfRangeException();
	}

	private unsafe bool OnSkin(Vector3 tip, float reach, out Skin s)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_1d22: Expected native int or pointer, but got VT
		//IL_1d59: Expected Obj, but got I
		//IL_1d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d93: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_1db1: Expected Obj, but got I
		//IL_1ddb: Expected Obj, but got I4
		//IL_0077: Expected VT, but got I4
		//IL_0080: Expected VT, but got I4
		//IL_0089: Expected VT, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected VT, but got I4
		//IL_00b7: Expected VT, but got I4
		//IL_00c0: Expected VT, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected F4, but got I4
		//IL_00f2: Expected VT, but got I4
		//IL_00fb: Expected VT, but got I4
		//IL_0104: Expected VT, but got I4
		//IL_0116: Expected Obj, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got I4
		//IL_2352: Expected Obj, but got I
		//IL_2372: Expected VT, but got I4
		//IL_237b: Expected VT, but got I4
		//IL_2384: Expected VT, but got I4
		//IL_2396: Expected Obj, but got I4
		//IL_239c: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a9: Expected VT, but got I4
		//IL_23b2: Expected VT, but got I4
		//IL_23bb: Expected VT, but got I4
		//IL_23cd: Expected Obj, but got I4
		//IL_23d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e4: Expected F4, but got I4
		//IL_23ed: Expected VT, but got I4
		//IL_23f6: Expected VT, but got I4
		//IL_23ff: Expected VT, but got I4
		//IL_2411: Expected Obj, but got I4
		//IL_242f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2438: Unknown result type (might be due to invalid IL or missing references)
		//IL_2445: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected F4, but got I4
		//IL_01f3: Expected VT, but got I4
		//IL_01fc: Expected VT, but got I4
		//IL_0205: Expected VT, but got I4
		//IL_0217: Expected Obj, but got I4
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got I4
		//IL_227d: Expected Obj, but got I
		//IL_228d: Expected Obj, but got I
		//IL_22a7: Expected VT, but got I4
		//IL_22b0: Expected VT, but got I4
		//IL_22b9: Expected VT, but got I4
		//IL_22cb: Expected Obj, but got I4
		//IL_22d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22de: Expected VT, but got I4
		//IL_22e7: Expected VT, but got I4
		//IL_22f0: Expected VT, but got I4
		//IL_2302: Expected Obj, but got I4
		//IL_2308: Unknown result type (might be due to invalid IL or missing references)
		//IL_231a: Expected Obj, but got I4
		//IL_231a: Unknown result type (might be due to invalid IL or missing references)
		//IL_231e: Unknown result type (might be due to invalid IL or missing references)
		//IL_232c: Expected Obj, but got I4
		//IL_2331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I4
		//IL_02ce: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I4
		//IL_1e3d: Expected Obj, but got I4
		//IL_247c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2480: Unknown result type (might be due to invalid IL or missing references)
		//IL_2488: Expected Obj, but got Unknown
		//IL_24aa: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I4
		//IL_0382: Expected Obj, but got I4
		//IL_03a8: Expected VT, but got I4
		//IL_03b1: Expected VT, but got I4
		//IL_03ba: Expected VT, but got I4
		//IL_03cc: Expected Obj, but got I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got I4
		//IL_03ee: Expected Obj, but got I4
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got I4
		//IL_1b62: Expected VT, but got I4
		//IL_1b6b: Expected VT, but got I4
		//IL_1b74: Expected VT, but got I4
		//IL_1b86: Expected Obj, but got I4
		//IL_1b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got I4
		//IL_0446: Expected Obj, but got I4
		//IL_046c: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I4
		//IL_04d3: Expected Obj, but got I4
		//IL_04dc: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I
		//IL_0524: Expected Obj, but got I4
		//IL_0569: Expected Obj, but got I4
		//IL_0572: Expected Obj, but got I4
		//IL_05a2: Expected Obj, but got I4
		//IL_05d0: Expected VT, but got I4
		//IL_05d9: Expected VT, but got I4
		//IL_05e2: Expected VT, but got I4
		//IL_05f4: Expected Obj, but got I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected VT, but got I4
		//IL_0610: Expected VT, but got I4
		//IL_0619: Expected VT, but got I4
		//IL_062b: Expected Obj, but got I4
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected Obj, but got I4
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected Obj, but got I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected Obj, but got I4
		//IL_0693: Expected Obj, but got I
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Invalid comparison between Unknown and F8
		//IL_072a: Expected Obj, but got I4
		//IL_0748: Expected Obj, but got I
		//IL_0772: Expected Obj, but got I4
		//IL_07a0: Expected Obj, but got I
		//IL_07bc: Expected VT, but got I4
		//IL_07c5: Expected VT, but got I4
		//IL_07ce: Expected VT, but got I4
		//IL_07e0: Expected Obj, but got I4
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected VT, but got I4
		//IL_07fc: Expected VT, but got I4
		//IL_0805: Expected VT, but got I4
		//IL_0817: Expected Obj, but got I4
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected Obj, but got I4
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected Obj, but got I4
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Expected Obj, but got I4
		//IL_0898: Expected VT, but got Ref
		//IL_08b8: Expected Obj, but got Ref
		//IL_08c0: Expected Obj, but got Ref
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected Obj, but got Ref
		//IL_090f: Expected Obj, but got Ref
		//IL_0913: Unsupported input type for neg.
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Expected Obj, but got Unknown
		//IL_0947: Expected Obj, but got Ref
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected Obj, but got Unknown
		//IL_0985: Expected F4, but got I4
		//IL_0993: Expected Obj, but got Ref
		//IL_099b: Expected Obj, but got Ref
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected Obj, but got I4
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Expected Obj, but got I4
		//IL_1c78: Expected Obj, but got I4
		//IL_1cdf: Expected Obj, but got I4
		//IL_1ce8: Expected Obj, but got I4
		//IL_2224: Expected Obj, but got I
		//IL_222c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2235: Expected Ref, but got Unknown
		//IL_224f: Expected Obj, but got I4
		//IL_1669: Expected Obj, but got I4
		//IL_1671: Unknown result type (might be due to invalid IL or missing references)
		//IL_1679: Expected Obj, but got Unknown
		//IL_16e4: Expected Obj, but got I
		//IL_170e: Expected Obj, but got I4
		//IL_211f: Expected Obj, but got I
		//IL_16c6: Expected Obj, but got I4
		//IL_1afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b01: Expected I4, but got Unknown
		//IL_1745: Expected Obj, but got I
		//IL_1740: Unknown result type (might be due to invalid IL or missing references)
		//IL_1745: Unknown result type (might be due to invalid IL or missing references)
		//IL_1759: Expected Obj, but got I
		//IL_175d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1761: Unknown result type (might be due to invalid IL or missing references)
		//IL_1765: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ae: Expected Obj, but got I
		//IL_21bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_21cf: Expected Obj, but got Ref
		//IL_21dd: Expected Obj, but got I4
		//IL_21e6: Expected Obj, but got I4
		//IL_21eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f8: Expected VT, but got I4
		//IL_1798: Expected Obj, but got I4
		//IL_17dd: Expected Obj, but got I4
		//IL_17e6: Expected Obj, but got I4
		//IL_1803: Unknown result type (might be due to invalid IL or missing references)
		//IL_1807: Unknown result type (might be due to invalid IL or missing references)
		//IL_1813: Expected Obj, but got Ref
		//IL_1821: Expected Obj, but got I4
		//IL_182a: Expected Obj, but got I4
		//IL_182f: Unknown result type (might be due to invalid IL or missing references)
		//IL_183c: Expected Obj, but got I4
		//IL_187c: Expected Obj, but got I4
		//IL_1897: Unknown result type (might be due to invalid IL or missing references)
		//IL_1907: Unknown result type (might be due to invalid IL or missing references)
		//IL_190e: Unknown result type (might be due to invalid IL or missing references)
		//IL_191b: Invalid comparison between Unknown and F8
		//IL_192a: Expected Obj, but got I4
		//IL_195a: Expected VT, but got Ref
		//IL_197a: Expected Obj, but got Ref
		//IL_1982: Expected Obj, but got Ref
		//IL_19a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b2: Expected Obj, but got Ref
		//IL_19c8: Expected Obj, but got Ref
		//IL_19f8: Expected Obj, but got Ref
		//IL_1a06: Unsupported input type for neg.
		//IL_1a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0b: Expected Obj, but got Unknown
		//IL_1a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a28: Expected Obj, but got Unknown
		//IL_1a3e: Expected F4, but got I4
		//IL_1a4c: Expected Obj, but got Ref
		//IL_1a54: Expected Obj, but got Ref
		//IL_1a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a86: Expected Obj, but got I4
		//IL_1a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a98: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		_ = 0;
		((Vector3*)(nint)tip)->x = 0f;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v2+E4]");
		Enumerator<, > val = (Enumerator<, >)0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 normal;
		Vector3 body;
		Vector3 world;
		GoreSection goreSection;
		object obj8;
		Enumerator<, > val2;
		float num;
		Vector3 normal2;
		Vector3 body2;
		Vector3 world2;
		GoreSection goreSection3;
		object obj10;
		object obj12 = default;
		float num3 = default;
		UnityEngine.Object obj14 = default;
		Enumerator<, > val4;
		object obj11;
		float num2;
		object obj19;
		Vector3 vector;
		Vector3 vector2;
		Vector3 vector3;
		GoreSection goreSection2;
		object obj9;
		Enumerator<, > val3;
		Vector3 vector4;
		Enumerator<, > val5;
		UnityEngine.Object obj13;
		UnityEngine.Object obj16;
		object obj17;
		object obj18 = default;
		object obj15;
		if ((UnityEngine.Object)obj5 != null)
		{
			bool flag2 = obj5 == null;
			normal = (Vector3)0;
			body = (Vector3)0;
			world = (Vector3)0;
			goreSection = (GoreSection)0;
			obj8 = 0;
			val2 = (Enumerator<, >)0;
			vector = (Vector3)0;
			vector2 = (Vector3)0;
			vector3 = (Vector3)0;
			goreSection2 = (GoreSection)0;
			obj9 = 0;
			val3 = (Enumerator<, >)0;
			num = 0f;
			normal2 = (Vector3)0;
			body2 = (Vector3)0;
			world2 = (Vector3)0;
			goreSection3 = (GoreSection)0;
			obj10 = 0;
			obj11 = obj12;
			num2 = num3;
			obj13 = obj14;
			val4 = (Enumerator<, >)0;
			val5 = (Enumerator<, >)0;
			obj15 = 0;
			obj16 = null;
			vector4 = tip;
			obj17 = obj18;
			if (flag2)
			{
				goto IL_1bab;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X21_v3 (UnityEngine.Object)+80]");
			obj19 = 0;
		}
		else
		{
			obj19 = 3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj22 = !flag3;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v36+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v26+8]");
		bool flag4 = (nint)0 == 0;
		normal = (Vector3)0;
		body = (Vector3)0;
		world = (Vector3)0;
		goreSection = (GoreSection)0;
		obj8 = 0;
		val2 = (Enumerator<, >)0;
		vector = (Vector3)0;
		vector2 = (Vector3)0;
		vector3 = (Vector3)0;
		goreSection2 = (GoreSection)0;
		obj9 = 0;
		val3 = (Enumerator<, >)0;
		num = 0f;
		normal2 = (Vector3)0;
		body2 = (Vector3)0;
		world2 = (Vector3)0;
		goreSection3 = (GoreSection)0;
		obj10 = 0;
		obj11 = obj12;
		num2 = num3;
		obj13 = obj14;
		val4 = (Enumerator<, >)0;
		val5 = (Enumerator<, >)0;
		obj15 = 0;
		obj16 = null;
		vector4 = tip;
		obj17 = obj18;
		if (flag4)
		{
			goto IL_1bab;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
		UnityEngine.Object obj24 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C58]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v26+8]");
		Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
		num = 0f;
		normal2 = (Vector3)0;
		body2 = (Vector3)0;
		world2 = (Vector3)0;
		goreSection3 = (GoreSection)0;
		obj10 = 0;
		obj11 = obj12;
		num2 = num3;
		val = (Enumerator<, >)(ref val4);
		object obj26 = 0;
		Enumerator<, > val6 = default;
		val5 = val6;
		obj15 = 0;
		obj17 = obj18;
		object obj38;
		Enumerator<, > val7;
		UnityEngine.Object obj39;
		while (val4.MoveNext())
		{
			object obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1183 @ X0_v122+E4]");
			bool flag5 = (nint)0 == 0;
			object obj28 = !flag5;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = obj14 == null;
			bool flag7 = !flag6;
			object obj29 = !flag7;
			obj15 = 0;
			if (obj29 != null)
			{
				continue;
			}
			object obj30 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1460 @ X0_v126+E4]");
			bool flag8 = (nint)0 == 0;
			object obj31 = !flag8;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj32 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1654 @ X0_v130+E4]");
			bool flag9 = (nint)0 == 0;
			object obj33 = !flag9;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj32 = obj20;
			}
			object obj34 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1654 @ X0_v130+A0]");
			val = (Enumerator<, >)0;
			UnityEngine.Object obj35 = (UnityEngine.Object)val;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X8_v81+E4]");
			bool flag10 = (nint)0 == 0;
			object obj36 = !flag10;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = obj14 == obj35;
			bool flag12 = !flag11;
			object obj37 = !flag12;
			obj15 = 0;
			if (obj37 != null)
			{
				continue;
			}
			bool flag13 = (object)obj14 == null;
			vector = (Vector3)0;
			vector2 = (Vector3)0;
			vector3 = (Vector3)0;
			goreSection2 = (GoreSection)0;
			obj9 = 0;
			val3 = (Enumerator<, >)0;
			obj13 = null;
			obj38 = 0;
			obj39 = (UnityEngine.Object)109891584;
			val7 = (Enumerator<, >)(ref val4);
			obj15 = 0;
			obj16 = obj35;
			if (flag13)
			{
				goto IL_1b50;
			}
			bool isMonster = ((NetworkApe)obj14).IsMonster;
			bool flag14 = !isMonster;
			object obj40 = !flag14;
			obj15 = 0;
			if (obj40 != null)
			{
				continue;
			}
			object obj41 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ stack_-1F0 (UnityEngine.Object)+A8]");
			obj35 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2032 @ X0_v136+E4]");
			bool flag15 = (nint)0 == 0;
			object obj42 = !flag15;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag16 = obj35 == null;
			bool flag17 = !flag16;
			object obj43 = !flag17;
			obj15 = 0;
			if (obj43 != null)
			{
				continue;
			}
			object obj44 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ stack_-1F0 (UnityEngine.Object)+68]");
			obj35 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2052 @ X0_v140+E4]");
			bool flag18 = (nint)0 == 0;
			object obj45 = !flag18;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag19 = obj35 == null;
			bool flag20 = !flag19;
			object obj46 = !flag20;
			obj15 = 0;
			if (obj46 != null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ stack_-1F0 (UnityEngine.Object)+6E8]");
			bool flag21 = 0 >= (nint)obj19;
			obj15 = 0;
			if (flag21)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ stack_-1F0 (UnityEngine.Object)+68]");
			bool flag22 = (nint)0 == 0;
			normal = (Vector3)0;
			body = (Vector3)0;
			world = (Vector3)0;
			goreSection = (GoreSection)0;
			obj8 = 0;
			val2 = (Enumerator<, >)0;
			vector = (Vector3)0;
			vector2 = (Vector3)0;
			vector3 = (Vector3)0;
			goreSection2 = (GoreSection)0;
			obj9 = 0;
			val3 = (Enumerator<, >)0;
			obj13 = null;
			obj38 = 0;
			val4 = val6;
			obj39 = (UnityEngine.Object)109891584;
			val7 = (Enumerator<, >)(ref val4);
			obj15 = 0;
			obj16 = null;
			vector4 = tip;
			if (flag22)
			{
				goto IL_1bf2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ stack_-1F0 (UnityEngine.Object)+68]");
			Vector3 position = ((Transform)0).position;
			float num4 = (float)val5 - reach;
			float num5 = num2 - num3;
			obj11 -= obj12;
			float num6 = num4 * num4;
			float num7 = num5 * num5;
			float num8 = num6 + num7;
			num2 = (float)obj11 * (float)obj11;
			val5 = (Enumerator<, >)(num2 + num8);
			bool flag23 = (double)val5 > 9.0;
			obj15 = 0;
			if (flag23)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj47 = 0;
			object obj48 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2170 @ X0_v146+E4]");
			bool flag24 = (nint)0 == 0;
			object obj49 = !flag24;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ stack_-1F0 (UnityEngine.Object)+A8]");
			GillaWounds gillaWounds = GillaWounds.On((Dismemberment)0);
			bool flag25 = (object)gillaWounds == null;
			normal = (Vector3)0;
			body = (Vector3)0;
			world = (Vector3)0;
			goreSection = (GoreSection)0;
			obj8 = 0;
			val2 = (Enumerator<, >)0;
			vector = (Vector3)0;
			vector2 = (Vector3)0;
			vector3 = (Vector3)0;
			goreSection2 = (GoreSection)0;
			obj9 = 0;
			val3 = (Enumerator<, >)0;
			obj35 = gillaWounds;
			obj13 = null;
			obj38 = 0;
			val4 = val6;
			obj39 = (UnityEngine.Object)109891584;
			val7 = (Enumerator<, >)(ref val4);
			obj15 = 0;
			obj16 = null;
			vector4 = tip;
			if (!flag25)
			{
				bool flag26 = gillaWounds.Surface((Vector3)(&obj10), reach, out goreSection3, out world2, out body2, out normal2, out *(float*)null);
				bool flag27 = !flag26;
				ref float reference = ref *(float*)null;
				object obj50 = (object)(&normal2);
				object obj51 = (object)(&body2);
				nint num9 = (nint)(&world2);
				obj18 = obj17;
				obj11 = obj12;
				num2 = num3;
				obj35 = gillaWounds;
				val5 = (Enumerator<, >)reach;
				obj15 = (object)(&goreSection3);
				if (!flag27)
				{
					object obj52 = (object)(&num);
					object obj53 = 0 - normal2;
					_ = 0;
					_ = 0;
					_ = 0;
					object obj54 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num, 14));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					object obj55 = tip + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num = 1f;
					reference = ref *(float*)null;
					obj50 = (object)(&normal2);
					obj51 = (object)(&body2);
					num9 = (nint)(&world2);
					obj18 = obj17;
					obj11 = obj12;
					num2 = num3;
					obj35 = gillaWounds;
					val = (Enumerator<, >)body2;
					obj26 = 1;
					val5 = (Enumerator<, >)normal2;
					obj15 = 72;
					obj17 = obj53;
				}
				continue;
			}
			goto IL_1c0b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
		object obj56 = 0;
		obj16 = (UnityEngine.Object)obj56;
		val4.Dispose();
		normal = (Vector3)0;
		body = (Vector3)0;
		world = (Vector3)0;
		goreSection = (GoreSection)0;
		obj8 = 0;
		val2 = (Enumerator<, >)0;
		vector = (Vector3)0;
		vector2 = (Vector3)0;
		vector3 = (Vector3)0;
		goreSection2 = (GoreSection)0;
		obj9 = 0;
		val3 = (Enumerator<, >)0;
		obj13 = null;
		obj38 = 0;
		val4 = val6;
		obj39 = (UnityEngine.Object)109891584;
		val7 = (Enumerator<, >)(ref val4);
		vector4 = tip;
		goto IL_1bc8;
		IL_1b9d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1bab;
		IL_1bf2:
		throw new NullReferenceException();
		IL_1b50:
		NullReferenceException ex2 = new NullReferenceException();
		normal = (Vector3)0;
		body = (Vector3)0;
		world = (Vector3)0;
		goreSection = (GoreSection)0;
		obj8 = 0;
		val2 = (Enumerator<, >)0;
		vector4 = tip;
		goto IL_1b9d;
		IL_1bab:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_1bb9;
		IL_1bc8:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		NullReferenceException ex5 = new NullReferenceException();
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_1bf2;
		IL_1c0b:
		bool result = default;
		object obj58 = default;
		Enumerator<, > val8 = default;
		while (true)
		{
			NullReferenceException ex7 = new NullReferenceException();
			NullReferenceException ex8 = new NullReferenceException();
			NullReferenceException ex9 = new NullReferenceException();
			NullReferenceException ex10 = new NullReferenceException();
			NullReferenceException ex11 = new NullReferenceException();
			object obj57;
			if ((nint)obj16 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj13 = (UnityEngine.Object)1;
				obj57 = obj38;
			}
			else
			{
				if ((nint)obj16 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D7A8");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj57 = obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj38 = obj58;
			}
			UnityEngine.Object obj59 = obj13;
			obj26 = 1;
			object obj60 = 0;
			object obj61 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C40]");
			object obj62 = 0;
			obj16 = (UnityEngine.Object)obj62;
			((Enumerator<, >*)val7)->Dispose();
			bool flag28 = obj57 == null;
			object obj63 = !flag28;
			obj13 = obj59;
			obj17 = obj61;
			if (obj63 != null)
			{
				break;
			}
			bool flag29 = (object)obj59 == null;
			object obj64 = !flag29;
			obj13 = obj59;
			ex3 = (NullReferenceException)val7;
			obj17 = obj61;
			if (obj64 == null)
			{
				if ((nint)obj60 != 12)
				{
					bool flag30 = obj60 == null;
					object obj65 = !flag30;
					if (obj65 != null)
					{
						return (byte)(obj26 & 1) != 0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
				object obj66 = 0;
				object obj67 = obj66;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2074 @ X0_v9+E4]");
				bool flag31 = (nint)0 == 0;
				object obj68 = !flag31;
				if (obj68 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj67 = obj66;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2074 @ X0_v9+A0]");
				object obj69 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v10+8]");
				bool flag32 = (nint)0 == 0;
				obj13 = obj59;
				obj17 = obj61;
				if (!flag32)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v10+8]");
					Enumerator<, > enumerator2 = ((List<System.__Canon>)0).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CC0]");
					object obj70 = 0;
					val = (Enumerator<, >)(ref val2);
					val5 = val8;
					UnityEngine.Object obj35;
					while (val2.MoveNext())
					{
						object obj71 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2175 @ X0_v16+E4]");
						bool flag33 = (nint)0 == 0;
						object obj72 = !flag33;
						if (obj72 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag34 = obj59 == null;
						bool flag35 = !flag34;
						object obj73 = !flag35;
						obj15 = 0;
						if (obj73 != null)
						{
							continue;
						}
						bool flag36 = (object)obj59 == null;
						val2 = val8;
						obj35 = (UnityEngine.Object)(&num);
						obj13 = null;
						obj38 = 0;
						obj39 = (UnityEngine.Object)3;
						val7 = (Enumerator<, >)(ref val2);
						obj15 = 0;
						obj16 = null;
						obj17 = obj61;
						if (!flag36)
						{
							bool woundable = ((GillaCorpse)obj59).Woundable;
							bool flag37 = !woundable;
							obj15 = 0;
							if (flag37)
							{
								continue;
							}
							Vector3 middleNow = ((GillaCorpse)obj59).MiddleNow;
							float num10 = (float)val5 - reach;
							float num11 = num2 - num3;
							obj11 -= obj12;
							float num12 = num10 * num10;
							float num13 = num11 * num11;
							float num14 = num12 + num13;
							num2 = (float)obj11 * (float)obj11;
							val5 = (Enumerator<, >)(num2 + num14);
							bool flag38 = (double)val5 > 9.0;
							obj15 = 0;
							if (!flag38)
							{
								bool flag39 = ((GillaCorpse)obj59).Surface((Vector3)(&obj8), reach, out goreSection, out world, out body, out normal, out *(float*)null);
								bool flag40 = !flag39;
								ref float reference = ref *(float*)null;
								object obj50 = (object)(&normal);
								object obj51 = (object)(&body);
								nint num9 = (nint)(&world);
								obj18 = obj61;
								obj11 = obj12;
								num2 = num3;
								val5 = (Enumerator<, >)reach;
								obj15 = (object)(&goreSection);
								if (!flag40)
								{
									object obj74 = (object)(&num);
									_ = 0;
									_ = 0;
									_ = 0;
									object obj75 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num, 16));
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj76 = 0 - normal;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
									object obj77 = vector4 + 56;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num = 3f;
									reference = ref *(float*)null;
									obj50 = (object)(&normal);
									obj51 = (object)(&body);
									num9 = (nint)(&world);
									obj18 = obj61;
									obj11 = obj12;
									num2 = num3;
									val = (Enumerator<, >)0;
									obj26 = 1;
									val5 = (Enumerator<, >)0;
									obj15 = 72;
									obj61 = obj76;
								}
							}
							continue;
						}
						goto IL_1b9d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CA8]");
					object obj78 = 0;
					obj16 = (UnityEngine.Object)obj78;
					val2.Dispose();
					val2 = val8;
					obj35 = (UnityEngine.Object)(&num);
					obj13 = null;
					obj38 = 0;
					obj39 = (UnityEngine.Object)3;
					val7 = (Enumerator<, >)(ref val2);
					vector4 = (Vector3)0;
					obj17 = obj61;
					OutOfMemoryException ex12 = new OutOfMemoryException();
					continue;
				}
				goto IL_1bab;
			}
			goto IL_1bb9;
		}
		goto IL_1bc8;
		IL_1bb9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_1bc8;
	}

	public unsafe void RPC_Scratch(byte kind, int id, NetworkId thing, byte s, Vector3 from, Vector3 to, RpcInfo info = default(RpcInfo))
	{
		//IL_02d6: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I4
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected VT, but got Unknown
		//IL_036d: Expected Obj, but got I4
		//IL_0b8d: Expected VT, but got I4
		//IL_0052: Expected VT, but got Ref
		//IL_0064: Expected Obj, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I4
		//IL_09b8: Expected Obj, but got I4
		//IL_09c9: Expected VT, but got I4
		//IL_03bd: Expected Obj, but got I4
		//IL_03ca: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I4
		//IL_03f1: Expected I4, but got Obj
		//IL_040c: Expected I4, but got I8
		//IL_043e: Expected I4, but got VT
		//IL_044c: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I4
		//IL_0545: Expected Obj, but got I
		//IL_056f: Expected Obj, but got I4
		//IL_0151: Expected VT, but got I4
		//IL_05a5: Expected Obj, but got I
		//IL_05b7: Expected VT, but got I8
		//IL_05d2: Expected VT, but got I4
		//IL_05f5: Expected Obj, but got VT
		//IL_060f: Expected Obj, but got I4
		//IL_061f: Expected I4, but got VT
		//IL_0630: Expected VT, but got I4
		//IL_0638: Expected Obj, but got Ref
		//IL_019c: Expected Obj, but got I4
		//IL_0a14: Expected Obj, but got I4
		//IL_0a1d: Expected Obj, but got I4
		//IL_0731: Expected Obj, but got I4
		//IL_073e: Expected VT, but got Ref
		//IL_0746: Expected I4, but got VT
		//IL_0756: Expected I4, but got VT
		//IL_0767: Expected Obj, but got I4
		//IL_076f: Expected Obj, but got Ref
		//IL_0780: Expected Obj, but got I4
		//IL_04b5: Expected VT, but got I4
		//IL_04c2: Expected VT, but got Obj
		//IL_04cb: Expected VT, but got I4
		//IL_01c7: Expected VT, but got I4
		//IL_0a7c: Expected Ref, but got VT
		//IL_0656: Expected Obj, but got I
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected VT, but got Unknown
		//IL_06a5: Expected VT, but got Obj
		//IL_04e2: Invalid comparison between VT and I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_025d: Invalid comparison between Obj and F8
		//IL_0aea: Expected Obj, but got I4
		//IL_0aad: Expected Obj, but got I4
		//IL_0ab5: Expected Obj, but got VT
		//IL_0ac6: Expected Obj, but got I4
		//IL_06c4: Expected Obj, but got I
		//IL_06d6: Expected I4, but got Obj
		//IL_06d6: Expected VT, but got I4
		//IL_06de: Expected I4, but got Obj
		//IL_06f0: Expected I4, but got Obj
		//IL_06f0: Expected VT, but got I4
		//IL_07da: Expected Obj, but got I
		//IL_0804: Expected Obj, but got I4
		//IL_04ff: Invalid comparison between VT and I4
		//IL_0511: Expected VT, but got I4
		//IL_051e: Expected VT, but got Obj
		//IL_0527: Expected VT, but got I4
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected VT, but got Unknown
		//IL_02b3: Expected Obj, but got I4
		//IL_0ba2: Expected Obj, but got I
		//IL_0bb2: Expected Obj, but got I
		//IL_07bc: Expected Obj, but got I4
		//IL_0c5c: Expected Obj, but got I4
		//IL_0839: Expected Obj, but got I
		//IL_0842: Expected VT, but got Obj
		//IL_0856: Expected Obj, but got I
		//IL_088d: Expected Obj, but got I4
		//IL_0936: Expected native int or pointer, but got VT
		//IL_0949: Expected VT, but got I4
		//IL_08c5: Expected I4, but got I8
		//IL_08dc: Expected VT, but got I4
		//IL_08dc: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		Vector3 vector = from;
		byte b = s;
		NetworkId networkId = thing;
		object obj2 = default;
		object obj = obj2;
		int id2 = id;
		NetworkId networkId2 = thing;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer;
		int num;
		PlayerRef playerRef;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		int num2;
		int num3;
		object obj16;
		object obj18 = default;
		int num4;
		object obj17;
		Fusion.RpcBuilder rpcBuilder3;
		NetworkId networkId3;
		object obj4;
		NetworkRunner runner;
		NullReferenceException ex;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj3 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize5 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize6 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			obj4 = obj3;
			runner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v20+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)runner != null)
			{
				object obj6 = bytePayloadSize2 + bytePayloadSize;
				object obj7 = bytePayloadSize3 + bytePayloadSize4;
				object obj8 = bytePayloadSize5 + bytePayloadSize6;
				object obj9 = obj6 + obj7;
				int payloadByteCount = (int)(obj9 + obj8);
				Fusion.RpcBuilder rpcBuilder = runner.CreateRpcBuilder(2618516507u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				num = rpcInvokeInfo >> 32;
				object obj10 = num - 522;
				bool flag4 = (nint)obj10 < 2;
				object obj11 = !flag4;
				object obj12 = ~obj11;
				if (obj12 == null && num != 518)
				{
					bool flag5 = num != 524;
					vector = (Vector3)0;
					playerRef = invalid;
					playerRef2 = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag5)
					{
						goto IL_05e7;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						vector = (Vector3)0;
						playerRef = invalid;
						playerRef2 = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag6)
						{
							goto IL_05e7;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj13 = 0;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v76+E4]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D70]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				vector = (Vector3)0;
				playerRef = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_05e7;
			}
			ex = new NullReferenceException();
			vector = from;
			b = s;
			num2 = bytePayloadSize2;
			num3 = bytePayloadSize;
			networkId3 = thing;
			obj = obj2;
			num4 = id;
			obj16 = 0;
			obj17 = obj18;
			rpcBuilder3 = (Fusion.RpcBuilder)0;
			num = bytePayloadSize6;
			goto IL_09d6;
		}
		goto IL_0005;
		IL_05e7:
		object obj19 = rpcInvokeInfo >> 32;
		bool flag8 = obj19 == null;
		object obj20 = !flag8;
		obj = obj2;
		num4 = (int)rpcInvokeInfo2;
		obj17 = obj18;
		rpcBuilder3 = (Fusion.RpcBuilder)0;
		runner = (NetworkRunner)(&rpcBuilder2);
		object obj22 = default;
		object obj23 = default;
		Fusion.RpcBuilder rpcBuilder4 = default;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			writer.Write(id, 4);
			NetworkId value = (NetworkId)(thing & 0xFFFFFFFFL);
			writer.Write(value, 4);
			playerRef2 = (PlayerRef)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			runner = (NetworkRunner)0;
			writer.Write((Vector3)12, (int)runner);
			num4 = (int)runner;
			writer.Write((Vector3)12, (int)runner);
			int num5 = rpcBuilder2.Send();
			obj = obj22;
			obj17 = obj23;
			rpcBuilder3 = rpcBuilder4;
		}
		rpcBuilder2.Dispose();
		object obj24 = 0;
		NetworkRunner networkRunner = null;
		Fusion.RpcBuilder rpcBuilder5 = (Fusion.RpcBuilder)(&rpcBuilder2);
		b = (byte)(int)playerRef;
		num2 = (int)(&writer);
		num3 = (int)rpcInvokeInfo;
		networkId3 = (NetworkId)playerRef2;
		obj16 = 0;
		ex = (NullReferenceException)(&rpcBuilder2);
		id2 = id;
		obj4 = 9;
		goto IL_0bfa;
		IL_09d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex3 = default;
		OutOfMemoryException ex2 = ex3;
		object obj25 = default;
		OutOfMemoryException ex5 = default;
		while (true)
		{
			if ((nint)obj16 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj24 = 1;
				obj4 = 1;
				runner = networkRunner;
			}
			else
			{
				if ((nint)obj16 != 1)
				{
					goto IL_0bd7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				runner = (NetworkRunner)obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				networkRunner = (NetworkRunner)obj25;
			}
			((Fusion.RpcBuilder*)rpcBuilder5)->Dispose();
			if ((object)runner == null)
			{
				break;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			ex2 = ex4;
			obj16 = 0;
			goto IL_0bd7;
			IL_0bd7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			ex2 = ex5;
			num2 = 0;
			num3 = 0;
			num = 0;
		}
		obj16 = 0;
		ex = (NullReferenceException)rpcBuilder5;
		id2 = id;
		obj4 = 0;
		goto IL_0bfa;
		IL_0bfa:
		if (obj24 == null)
		{
			if ((nint)obj4 != 9)
			{
				bool flag9 = obj4 == null;
				object obj26 = !flag9;
				if (obj26 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj27 = 0;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v22+E4]");
			bool flag10 = (nint)0 == 0;
			object obj29 = !flag10;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj28 = obj27;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v22+A0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v7+18]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D68]");
				object obj32 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj32);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj33 = 0;
				int num6 = num3 | num;
				object obj34 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X8_v14+E4]");
				bool flag11 = (nint)0 == 0;
				object obj35 = !flag11;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num2 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num6, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ X28_v4+18] (should have been resolved before IL gen)");
				object obj36 = default;
				obj24 = obj36;
				vector = (Vector3)invalid2;
				b = 0;
				object obj37 = default;
				obj = obj37;
			}
			bool flag12 = num3 == 0;
			object obj38 = !flag12;
			if (obj38 == null)
			{
				RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
				float x = default;
				((Vector3*)(nint)from)->x = x;
				networkId = (NetworkId)0;
				networkId2 = thing;
				goto IL_0005;
			}
			return;
		}
		goto IL_09d6;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X5 (UnityEngine.Vector3)+18]");
		object obj39 = (nint)0 & (nint)1;
		bool flag13 = obj39 == null;
		object obj40 = !flag13;
		NetworkId thing2;
		if (obj40 == null)
		{
			object obj41 = default;
			bool flag14 = FromHolder((RpcInfo)(&obj41), scratch: true);
			object obj42 = kind - 1;
			object obj43 = obj42 & 0xFF;
			bool flag15 = (nint)obj43 < 2;
			object obj44 = !flag15;
			object obj45 = obj43 - 2;
			bool flag16 = obj45 == null;
			object obj46 = !flag16;
			object obj47 = obj44 & obj46;
			if (obj47 != null || !flag14)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj48 = 0;
			object obj49 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v89+E4]");
			bool flag17 = (nint)0 == 0;
			object obj50 = !flag17;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!NetworkApe.SaneWound(s, (Vector3)0))
			{
				return;
			}
			object obj51 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v93+E4]");
			bool flag18 = (nint)0 == 0;
			object obj52 = !flag18;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!NetworkApe.SaneWound(s, (Vector3)0))
			{
				return;
			}
			object obj54 = default;
			object obj53 = rpcBuilder4 - obj54;
			object obj55 = obj23 - obj18;
			object obj56 = obj22 - obj2;
			object obj57 = obj53 * obj53;
			object obj58 = obj55 * obj55;
			object obj59 = obj57 + obj58;
			object obj60 = obj56 * obj56;
			object obj61 = obj60 + obj59;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj61) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0))
			{
				return;
			}
			thing2 = (NetworkId)(networkId2 & 0xFFFFFFFFL);
			bool flag19 = NearWhatItsIn((Into)kind, id2, thing2);
			bool flag20 = !flag19;
			object obj62 = !flag20;
			if (obj62 == null)
			{
				return;
			}
		}
		else
		{
			thing2 = (NetworkId)(networkId2 & 0xFFFFFFFFL);
		}
		Scratch(kind, id2, thing2, s, vector, (Vector3)0);
	}

	private void Scratch(byte kind, int id, NetworkId thing, byte s, Vector3 from, Vector3 to)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0033: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I
		//IL_031c: Expected Obj, but got I4
		//IL_08de: Expected Obj, but got I
		//IL_08ee: Expected Obj, but got I
		//IL_0908: Expected Obj, but got I
		//IL_0919: Expected I, but got Obj
		//IL_0351: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I4
		//IL_03d9: Expected Obj, but got I4
		//IL_03e2: Expected VT, but got I4
		//IL_0550: Expected I4, but got I8
		//IL_056a: Expected Obj, but got I4
		//IL_0572: Expected VT, but got Obj
		//IL_0948: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_042d: Expected Obj, but got I4
		//IL_09d5: Expected Obj, but got I4
		//IL_0590: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I4
		//IL_07b0: Expected Obj, but got I
		//IL_07da: Expected Obj, but got I4
		//IL_099e: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I4
		//IL_0814: Expected Obj, but got I
		//IL_083e: Expected Obj, but got I4
		//IL_0980: Expected Obj, but got I4
		//IL_0602: Expected VT, but got Obj
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected VT, but got Unknown
		//IL_09fb: Expected Obj, but got I
		//IL_0a1d: Expected Obj, but got I4
		//IL_0723: Expected Obj, but got I
		//IL_087f: Expected VT, but got I4
		//IL_0895: Expected VT, but got I4
		//IL_0632: Expected Obj, but got I4
		//IL_02c2: Expected Obj, but got I
		//IL_02ca: Expected VT, but got Obj
		//IL_0182: Expected VT, but got I4
		//IL_0198: Expected VT, but got I4
		//IL_08b5: Expected VT, but got I4
		//IL_08b5: Expected VT, but got I4
		//IL_0746: Expected Obj, but got I
		//IL_074f: Expected VT, but got I4
		//IL_067f: Expected Obj, but got I
		//IL_0687: Expected I4, but got Obj
		//IL_06aa: Expected VT, but got I4
		//IL_01b8: Expected VT, but got I4
		//IL_01b8: Expected VT, but got I4
		//IL_04b3: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I4
		//IL_0662: Expected Obj, but got I
		//IL_050c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass170_0 obj2 = default;
		obj2._002Ector();
		int num = kind & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		bool flag = num == 1;
		int id2 = default;
		obj2.id = id2;
		float width = default;
		UnityEngine.Object obj5;
		if (!flag)
		{
			System.__Canon _Canon = default;
			UnityEngine.Object obj19;
			object obj25;
			bool flag13;
			object obj26;
			bool flag14;
			bool flag15;
			UnityEngine.Object obj4;
			switch (num)
			{
			case 3:
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
				object obj20 = 0;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v88+E4]");
				bool flag11 = (nint)0 == 0;
				object obj22 = !flag11;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaCorpse gillaCorpse = GillaCorpse.Find(id2);
				object obj23 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v49+E4]");
				bool flag12 = (nint)0 == 0;
				object obj24 = !flag12;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (gillaCorpse != null)
				{
					Vector3 vector = gillaCorpse.WorldOn((GoreSection)s, (Vector3)0);
					Vector3 vector2 = gillaCorpse.WorldOn((GoreSection)s, (Vector3)0);
					gillaCorpse.Scratch((Vector3)0, (Vector3)0, width);
				}
				return;
			}
			case 2:
			{
				bool live = Live;
				bool flag2 = !live;
				UnityEngine.Object obj6 = null;
				NetworkId networkId;
				if (!flag2)
				{
					object obj7 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v80+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = (UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null;
					bool flag5 = !flag4;
					id2 = 0;
					obj6 = null;
					if (!flag5)
					{
						NetworkId networkId2 = default;
						networkId = (NetworkId)(networkId2 & 0xFFFFFFFFL);
						NetworkObject networkObject = ((SimulationBehaviour)this)._runner.FindObject(networkId);
						bool flag6 = (object)networkObject == null;
						id2 = 0;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BE8]");
							object obj9 = 0;
							networkId = (NetworkId)obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
							id2 = 0;
							goto IL_06af;
						}
						goto IL_06bc;
					}
				}
				int num2 = (int)(obj2.id & 0x80000000L);
				bool flag7 = num2 == 0;
				object obj10 = !flag7;
				networkId = (NetworkId)obj6;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v73+E4]");
					bool flag8 = (nint)0 == 0;
					object obj13 = !flag8;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj12 = obj11;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v73+A0]");
					object obj14 = 0;
					List<System.__Canon> list = (List<System.__Canon>)obj14;
					bool flag9 = obj2.id >= list._size;
					networkId = (NetworkId)obj6;
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v73+E4]");
						bool flag10 = (nint)0 == 0;
						object obj15 = !flag10;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj16 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v40+A0]");
							object obj17 = 0;
							list = (List<System.__Canon>)obj17;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D20]");
						object obj18 = 0;
						id2 = (int)obj18;
						_Canon = list.get_Item(obj2.id);
						networkId = (NetworkId)obj2.id;
						goto IL_06af;
					}
				}
				goto IL_06bc;
			}
			default:
				{
					obj4 = null;
					obj5 = null;
					break;
				}
				IL_06bc:
				obj19 = null;
				goto IL_09ab;
				IL_06af:
				obj19 = (UnityEngine.Object)(object)_Canon;
				goto IL_09ab;
				IL_09ab:
				obj25 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v64+E4]");
				flag13 = (nint)0 == 0;
				obj26 = !flag13;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				flag14 = obj19 != null;
				flag15 = !flag14;
				id2 = 0;
				obj4 = null;
				obj5 = null;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X20_v10 (UnityEngine.Object)+80]");
					obj5 = (UnityEngine.Object)0;
					id2 = 0;
					obj4 = null;
				}
				break;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj27 = 0;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v29+E4]");
			bool flag16 = (nint)0 == 0;
			object obj29 = !flag16;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj28 = obj27;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v29+A0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C10]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D88]");
			object obj32 = 0;
			Predicate<System.__Canon> predicate = default;
			predicate._002Ector((object)obj2, (IntPtr)obj32);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C00]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v16+8]");
			System.__Canon _Canon2 = ((List<System.__Canon>)0).Find(predicate);
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v21+E4]");
			bool flag17 = (nint)0 == 0;
			object obj35 = !flag17;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag18 = (UnityEngine.Object)(object)_Canon2 == null;
			bool flag19 = !flag18;
			object obj36 = !flag19;
			NetworkId networkId2 = (NetworkId)0;
			id2 = 0;
			UnityEngine.Object obj4 = null;
			obj5 = null;
			if (obj36 == null)
			{
				object obj37 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X0_v37+E4]");
				bool flag20 = (nint)0 == 0;
				object obj38 = !flag20;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj39 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X0_v41+E4]");
				bool flag21 = (nint)0 == 0;
				object obj40 = !flag21;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj39 = obj27;
				}
				object obj41 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X0_v41+A0]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v26+E4]");
				bool flag22 = (nint)0 == 0;
				object obj43 = !flag22;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)(object)_Canon2 == (UnityEngine.Object)obj42)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
					object obj44 = 0;
					object obj45 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v46+E4]");
					bool flag23 = (nint)0 == 0;
					object obj46 = !flag23;
					if (obj46 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Dismemberment dismemberment = YourBody();
					networkId2 = (NetworkId)0;
					id2 = 0;
					obj4 = (UnityEngine.Object)obj42;
					obj5 = dismemberment;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v33 (System.__Canon)+A8]");
					obj5 = (UnityEngine.Object)0;
					networkId2 = (NetworkId)0;
					id2 = 0;
					obj4 = (UnityEngine.Object)obj42;
				}
			}
		}
		object obj47 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v7+E4]");
		bool flag24 = (nint)0 == 0;
		object obj48 = !flag24;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(obj5 == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj49 = 0;
			object obj50 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v11+E4]");
			bool flag25 = (nint)0 == 0;
			object obj51 = !flag25;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaWounds gillaWounds = GillaWounds.On((Dismemberment)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
			object obj52 = 0;
			object obj53 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v12+E4]");
			bool flag26 = (nint)0 == 0;
			object obj54 = !flag26;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaBloodied gillaBloodied = GillaBloodied.On((Dismemberment)obj5);
			Vector3 vector3 = gillaWounds.WorldOn((GoreSection)s, (Vector3)0);
			Vector3 vector4 = gillaWounds.WorldOn((GoreSection)s, (Vector3)0);
			gillaBloodied.Scratch((Vector3)0, (Vector3)0, width);
		}
	}

	public unsafe void RPC_Knock(Vector3 at, float hard, RpcInfo info = default(RpcInfo))
	{
		//IL_073d: Expected Obj, but got I4
		//IL_076b: Expected Obj, but got I
		//IL_0785: Expected Obj, but got I4
		//IL_078e: Expected VT, but got I4
		//IL_05cd: Invalid comparison between F4 and I4
		//IL_0015: Expected Obj, but got I
		//IL_053b: Expected VT, but got Ref
		//IL_006a: Expected Obj, but got I4
		//IL_0566: Expected VT, but got Ref
		//IL_0613: Expected VT, but got I4
		//IL_061c: Expected Obj, but got I4
		//IL_00d5: Expected I4, but got I8
		//IL_0590: Expected Obj, but got F4
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_05b6: Expected VT, but got Ref
		//IL_0107: Expected Obj, but got VT
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I
		//IL_0270: Expected VT, but got I8
		//IL_028b: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got VT
		//IL_02c8: Expected Obj, but got I4
		//IL_02d1: Expected F4, but got I4
		//IL_065f: Expected Obj, but got I4
		//IL_035b: Expected VT, but got F4
		//IL_0364: Expected Obj, but got I4
		//IL_036d: Expected Obj, but got I4
		//IL_0375: Expected VT, but got Ref
		//IL_037d: Expected I, but got VT
		//IL_0385: Expected Obj, but got Ref
		//IL_038e: Expected Obj, but got I4
		//IL_0396: Expected Obj, but got Ref
		//IL_039e: Expected I4, but got VT
		//IL_017e: Expected Obj, but got I4
		//IL_0183: Expected VT, but got Obj
		//IL_018c: Expected VT, but got I4
		//IL_06c6: Expected Ref, but got VT
		//IL_06de: Expected Obj, but got I4
		//IL_06e6: Expected Obj, but got VT
		//IL_03bd: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I
		//IL_0301: Expected I4, but got Obj
		//IL_0301: Expected VT, but got I4
		//IL_0311: Expected Obj, but got I
		//IL_0319: Expected VT, but got Obj
		//IL_01ab: Invalid comparison between VT and I4
		//IL_03db: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I4
		//IL_0713: Expected Obj, but got I4
		//IL_07ac: Expected Obj, but got I
		//IL_07bc: Expected Obj, but got I
		//IL_01c8: Invalid comparison between VT and I4
		//IL_01da: Expected Obj, but got I4
		//IL_01df: Expected VT, but got Obj
		//IL_01e8: Expected VT, but got I4
		//IL_0851: Expected Obj, but got I4
		//IL_043a: Expected Obj, but got I
		//IL_0443: Expected VT, but got Obj
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected I4, but got Unknown
		//IL_047e: Expected Obj, but got I4
		//IL_050e: Expected native int or pointer, but got VT
		//IL_051d: Expected I, but got Obj
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected I4, but got Unknown
		//IL_04cd: Expected VT, but got I4
		//IL_04cd: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		object obj = !flag2;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj2;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer;
		object obj5 = default;
		PlayerRef playerRef;
		int num;
		Fusion.RpcBuilder rpcBuilder3;
		NullReferenceException ex;
		object obj12;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj2 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			object obj3 = obj2;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				int payloadByteCount = bytePayloadSize2 + bytePayloadSize;
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(3666117485u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				obj5 = rpcInvokeInfo >> 32;
				object obj6 = obj5 - 522;
				bool flag4 = (nint)obj6 < 2;
				object obj7 = !flag4;
				object obj8 = ~obj7;
				object obj9;
				RpcInvokeInfo rpcInvokeInfo2;
				PlayerRef playerRef2;
				if (obj8 == null && (nint)obj5 != 518)
				{
					bool flag5 = (nint)obj5 != 524;
					obj9 = 0;
					playerRef = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef2 = invalid;
					if (flag5)
					{
						goto IL_02a0;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						obj9 = 0;
						playerRef = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef2 = invalid;
						if (flag6)
						{
							goto IL_02a0;
						}
					}
				}
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v70+E4]");
				bool flag7 = (nint)0 == 0;
				object obj11 = !flag7;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D40]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				obj9 = 0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef2 = none;
				goto IL_02a0;
			}
			ex = new NullReferenceException();
			rpcBuilder3 = (Fusion.RpcBuilder)0;
			obj12 = 0;
			num = bytePayloadSize;
			goto IL_0629;
		}
		goto IL_0755;
		IL_03a3:
		object obj13 = default;
		bool flag8 = obj13 == null;
		object obj14 = !flag8;
		if (obj14 != null)
		{
			goto IL_0629;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v40+E4]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v40+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v16+18]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v16+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D38]");
			object obj20 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj20);
			object obj21 = obj2;
			int num2 = num | obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v21+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid2 = PlayerRef.Invalid;
			RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num2, hostMode, (PlayerRef)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ X26_v4+18] (should have been resolved before IL gen)");
			object obj23 = default;
			obj13 = obj23;
		}
		bool flag11 = num == 0;
		object obj24 = !flag11;
		nint num3;
		if (obj24 == null)
		{
			RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			float x = default;
			((Vector3*)(nint)at)->x = x;
			num3 = unchecked((nint)null);
			rpcChannel = (RpcChannel)0;
			goto IL_0755;
		}
		return;
		IL_0814:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_02a0:
		object obj25 = rpcInvokeInfo >> 32;
		bool flag12 = obj25 == null;
		object obj26 = !flag12;
		float num4 = 0f;
		float num5 = default;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj27 = 0;
			writer.Write((Vector3)12, (int)obj27);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BD0]");
			object obj28 = 0;
			RpcInvokeInfo rpcInvokeInfo2 = (RpcInvokeInfo)obj28;
			writer.Write(num5, 4);
			int num6 = rpcBuilder2.Send();
			num4 = num5;
		}
		rpcBuilder2.Dispose();
		rpcBuilder3 = (Fusion.RpcBuilder)num4;
		obj13 = 0;
		object obj29 = 0;
		Fusion.RpcBuilder rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder2);
		num3 = (nint)playerRef;
		networkRunner = (NetworkRunner)(&writer);
		obj12 = 0;
		ex = (NullReferenceException)(&rpcBuilder2);
		num = (int)rpcInvokeInfo;
		goto IL_03a3;
		IL_0629:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj30;
		OutOfMemoryException ex2;
		if ((nint)obj12 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj13 = 1;
			obj30 = obj29;
		}
		else
		{
			bool flag13 = (nint)obj12 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_0814;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj31 = default;
			obj30 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj29 = obj31;
		}
		((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
		bool flag14 = obj30 == null;
		obj12 = 0;
		ex = (NullReferenceException)rpcBuilder4;
		if (flag14)
		{
			goto IL_03a3;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj12 = 0;
		goto IL_0814;
		IL_0755:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector3)+18]");
		object obj32 = (nint)0 & (nint)1;
		bool flag15 = obj32 == null;
		object obj33 = !flag15;
		Vector3 at2 = (Vector3)rpcChannel;
		if (obj33 == null)
		{
			object obj34 = default;
			if (!FromHolder((RpcInfo)(&obj34), scratch: false) || !ByIt((Vector3)(&obj34)))
			{
				return;
			}
			object obj35 = ~num5;
			object obj36 = 0x7F800000 & obj35;
			bool flag16 = obj36 == null;
			at2 = (Vector3)(&obj34);
			if (flag16)
			{
				return;
			}
		}
		if (num5 < 0f || !((double)num5 > 1.0))
		{
			Knock(at2, hard);
		}
	}

	private void Knock(Vector3 at, float hard)
	{
		//IL_000e: Invalid comparison between F8 and I4
		//IL_0024: Expected Obj, but got I
		//IL_002d: Expected F8, but got I4
		//IL_0154: Expected Obj, but got I4
		//IL_00a7: Expected VT, but got I4
		//IL_00b0: Invalid comparison between F8 and I4
		//IL_00bf: Expected F8, but got I4
		//IL_01a6: Expected F4, but got I
		GillaItem gillaItem = item;
		double num = default;
		bool flag = num < 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj = 0;
		double num2 = 0.0;
		if (!flag)
		{
			bool flag2 = !(num > 1.0);
			num2 = num;
			if (!flag2)
			{
				num2 = 1.0;
			}
		}
		object obj2 = obj;
		double num3 = num2 * 1056964607.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj3 = !flag3;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float pitchMin = default;
		float pitchMax = default;
		Sfx.Play(gillaItem.knocks, (Vector3)0, hard, pitchMin, pitchMax);
		bool flag4 = num < 0.0;
		double num4 = 0.0;
		if (!flag4)
		{
			bool flag5 = !(num > 1.0);
			num4 = num;
			if (!flag5)
			{
				num4 = 1.0;
			}
		}
		double num5 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC8]");
		double num6 = num5 * 0.0;
		float num7 = (float)num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float strength = num7 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		Buzz(strength, 0f);
	}

	public unsafe void RPC_In(byte e, byte kind, int id, NetworkId thing, byte s, Vector3 p, Vector3 way, float first, float hard, RpcInfo info = default(RpcInfo))
	{
		//IL_0dac: Expected VT, but got I4
		//IL_0129: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I4
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected VT, but got Unknown
		//IL_0061: Expected Obj, but got I
		//IL_01c3: Expected F4, but got Obj
		//IL_01e5: Expected Obj, but got I4
		//IL_08c0: Expected Obj, but got I4
		//IL_08eb: Expected VT, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_0bda: Expected Obj, but got I4
		//IL_0bfb: Expected VT, but got I4
		//IL_0df9: Expected VT, but got Ref
		//IL_0e0b: Expected Obj, but got I4
		//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e19: Expected Obj, but got Unknown
		//IL_0e33: Expected Obj, but got I4
		//IL_0e3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e41: Expected Obj, but got Unknown
		//IL_0e5b: Expected Obj, but got I4
		//IL_00d2: Expected VT, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected I4, but got Unknown
		//IL_0237: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0278: Expected Obj, but got I4
		//IL_0292: Expected I4, but got Obj
		//IL_02af: Expected I4, but got I8
		//IL_02e1: Expected I4, but got VT
		//IL_02ef: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_0924: Expected Obj, but got I4
		//IL_0932: Expected Obj, but got I4
		//IL_094c: Expected Obj, but got I4
		//IL_03e8: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I4
		//IL_0448: Expected Obj, but got I
		//IL_045a: Expected VT, but got I8
		//IL_0498: Expected Obj, but got VT
		//IL_04b2: Expected Obj, but got I4
		//IL_04cb: Expected F4, but got I4
		//IL_0c8e: Expected I4, but got Obj
		//IL_0ca0: Expected I4, but got Obj
		//IL_0c46: Expected F4, but got I4
		//IL_0c4f: Expected F4, but got I4
		//IL_0614: Expected F4, but got I4
		//IL_0625: Expected VT, but got Ref
		//IL_062d: Expected I4, but got VT
		//IL_0635: Expected I4, but got VT
		//IL_064d: Expected I4, but got VT
		//IL_0656: Expected Obj, but got I4
		//IL_065e: Expected VT, but got F4
		//IL_0666: Expected Obj, but got Ref
		//IL_0697: Expected F4, but got I4
		//IL_035d: Expected VT, but got Obj
		//IL_0366: Expected VT, but got I4
		//IL_0cae: Expected Ref, but got VT
		//IL_0f14: Invalid comparison between F4 and I4
		//IL_04f1: Expected Obj, but got I
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected VT, but got Unknown
		//IL_0385: Invalid comparison between VT and I4
		//IL_09cb: Expected Obj, but got I4
		//IL_0d34: Expected Obj, but got I4
		//IL_0cdf: Expected Obj, but got I4
		//IL_0ce7: Expected Obj, but got VT
		//IL_0d18: Expected F4, but got I4
		//IL_06a5: Invalid comparison between F4 and I4
		//IL_054f: Expected VT, but got Obj
		//IL_0569: Expected Obj, but got I
		//IL_057b: Expected I4, but got Obj
		//IL_057b: Expected VT, but got I4
		//IL_09f2: Expected VT, but got I4
		//IL_06f1: Expected Obj, but got I
		//IL_071b: Expected Obj, but got I4
		//IL_0592: Expected I4, but got Obj
		//IL_0592: Expected VT, but got I4
		//IL_03a2: Invalid comparison between VT and I4
		//IL_03b9: Expected VT, but got Obj
		//IL_03c2: Expected VT, but got I4
		//IL_0e86: Expected Obj, but got I
		//IL_0e96: Expected Obj, but got I
		//IL_06c2: Invalid comparison between F4 and I4
		//IL_06d3: Expected Obj, but got I4
		//IL_05c6: Expected VT, but got I4
		//IL_0a6a: Invalid comparison between F4 and I
		//IL_0f6d: Expected Obj, but got I4
		//IL_0750: Expected Obj, but got I
		//IL_0759: Expected VT, but got Obj
		//IL_076d: Expected Obj, but got I
		//IL_07a4: Expected Obj, but got I4
		//IL_0a87: Expected Obj, but got F4
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Expected Obj, but got Unknown
		//IL_085b: Expected F4, but got VT
		//IL_0856: Expected native int or pointer, but got VT
		//IL_07dc: Expected I4, but got I8
		//IL_07f3: Expected VT, but got I4
		//IL_07f3: Expected VT, but got I4
		//IL_080f: Expected VT, but got I4
		//IL_081f: Expected I4, but got VT
		//IL_0828: Expected VT, but got I4
		//IL_0abb: Expected Obj, but got F4
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected Obj, but got Unknown
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected VT, but got Unknown
		//IL_0b3e: Invalid comparison between F4 and I4
		//IL_0ecc: Invalid comparison between F4 and I4
		//IL_0b62: Invalid comparison between I and F4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		Vector3 p2 = p;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj2 = default;
		object obj = obj2;
		float num = hard;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		byte b = e;
		byte b3 = default;
		byte b2 = b3;
		int num2 = default;
		int id2 = num2;
		NetworkId networkId2 = default;
		NetworkId networkId = networkId2;
		byte b5 = default;
		byte b4 = b5;
		Vector3 vector = p;
		int bytePayloadSize = default;
		int bytePayloadSize2 = default;
		int bytePayloadSize5 = default;
		int bytePayloadSize8 = default;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		int num4;
		PlayerRef playerRef;
		RpcInvokeInfo rpcInvokeInfo2;
		PlayerRef playerRef2;
		byte b6;
		float num3;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj3 = 0;
			bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			bytePayloadSize5 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize6 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize7 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			bytePayloadSize8 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize9 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			num3 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X8_v20 (System.Single)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)((SimulationBehaviour)this)._runner != null)
			{
				object obj5 = bytePayloadSize2 + bytePayloadSize;
				object obj6 = bytePayloadSize3 + bytePayloadSize4;
				object obj7 = bytePayloadSize5 + bytePayloadSize6;
				object obj8 = obj5 + obj6;
				object obj9 = obj7 + bytePayloadSize7;
				object obj10 = bytePayloadSize8 + bytePayloadSize9;
				object obj11 = obj8 + obj9;
				int payloadByteCount = (int)(obj11 + obj10);
				Fusion.RpcBuilder rpcBuilder2 = ((SimulationBehaviour)this)._runner.CreateRpcBuilder(2229528253u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				num4 = rpcInvokeInfo >> 32;
				object obj12 = num4 - 522;
				bool flag4 = (nint)obj12 < 2;
				object obj13 = !flag4;
				object obj14 = ~obj13;
				if (obj14 == null && num4 != 518)
				{
					bool flag5 = num4 != 524;
					b6 = 0;
					playerRef = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef2 = invalid;
					if (flag5)
					{
						goto IL_048a;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						b6 = 0;
						playerRef = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef2 = invalid;
						if (flag6)
						{
							goto IL_048a;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj15 = 0;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v85+E4]");
				bool flag7 = (nint)0 == 0;
				object obj17 = !flag7;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D60]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				b6 = 0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef2 = none;
				goto IL_048a;
			}
			goto IL_0b98;
		}
		goto IL_0005;
		IL_0f7b:
		int e2 = b & 0xFF;
		NetworkId thing2;
		In(e2, (Into)b2, id2, thing2, (GoreSection)b4, p2, way, first, hard);
		return;
		IL_0f0b:
		float num5 = default;
		int num7;
		int num8;
		Fusion.RpcBuilder rpcBuilder4 = default;
		NetworkId networkId3;
		if (num5 == 0f)
		{
			if (num3 != 12f)
			{
				bool flag8 = num3 == 0f;
				object obj18 = !flag8;
				if (obj18 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v28+E4]");
			bool flag9 = (nint)0 == 0;
			object obj21 = !flag9;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj20 = obj19;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v28+A0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v7+18]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v7+18]");
			bool flag10 = (nint)0 == 0;
			p2 = p;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D48]");
				object obj24 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj24);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj25 = 0;
				int num6 = num7 | num4;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ X8_v14+E4]");
				bool flag11 = (nint)0 == 0;
				object obj27 = !flag11;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num8 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num6, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v487 @ X21_v7+18] (should have been resolved before IL gen)");
				p2 = (Vector3)0;
				float num9 = default;
				num5 = num9;
				b6 = (byte)(int)invalid2;
				networkId3 = (NetworkId)0;
				object obj28 = default;
				obj = obj28;
			}
			bool flag12 = num7 == 0;
			object obj29 = !flag12;
			if (obj29 == null)
			{
				RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
				((Vector3*)(nint)p)->x = (float)rpcBuilder4;
				rpcChannel = (RpcChannel)0;
				num = num5;
				rpcBuilder = rpcBuilder4;
				vector = p;
				goto IL_0005;
			}
			return;
		}
		goto IL_0c08;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X21_v9 (UnityEngine.Vector3)+18]");
		object obj30 = (nint)0 & (nint)1;
		bool flag13 = obj30 == null;
		object obj31 = !flag13;
		float num14 = default;
		object obj54 = default;
		float num17 = default;
		float num18 = default;
		if (obj31 == null)
		{
			int num10 = b2 & 0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj32 = 0;
			object obj33 = obj32;
			bool flag17;
			if (num10 == 3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v96+E4]");
				bool flag14 = (nint)0 == 0;
				object obj34 = !flag14;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag15 = NetworkApe.Sane((Vector3)0);
				int num11 = b4 & 0xFF;
				bool flag16 = num11 < 6;
				object obj35 = !flag16;
				object obj36 = ~obj35;
				flag17 = (byte)((obj36 & flag15) ? 1 : 0) != 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v96+E4]");
				bool flag18 = (nint)0 == 0;
				object obj37 = !flag18;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag19 = NetworkApe.SaneWound(b4, (Vector3)0);
				flag17 = flag19;
			}
			object obj38 = default;
			bool flag20 = FromHolder((RpcInfo)(&obj38), scratch: false);
			object obj39 = b2 - 1;
			object obj40 = obj39 & 0xFF;
			bool flag21 = (nint)obj40 < 3;
			object obj41 = !flag21;
			object obj42 = obj40 - 3;
			bool flag22 = obj42 == null;
			object obj43 = !flag22;
			object obj44 = obj41 & obj43;
			if (obj44 != null)
			{
				return;
			}
			int num12 = b & 0xFF;
			bool flag23 = num12 < 1;
			object obj45 = !flag23;
			object obj46 = num12 - 1;
			bool flag24 = obj46 == null;
			object obj47 = !flag24;
			object obj48 = obj45 & obj47;
			if (obj48 != null || !flag20 || !flag17)
			{
				return;
			}
			object obj49 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v100+E4]");
			bool flag25 = (nint)0 == 0;
			object obj50 = !flag25;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!NetworkApe.Sane((Vector3)0))
			{
				return;
			}
			object obj52 = default;
			object obj51 = obj52 * obj52;
			float num13 = num14 * num14;
			float num15 = (float)obj51 + num13;
			object obj53 = obj54 * obj54;
			float num16 = num15 + (float)obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			if (num16 < 0f)
			{
				return;
			}
			object obj55 = ~num17;
			object obj56 = 0x7F800000 & obj55;
			if (obj56 == null)
			{
				return;
			}
			object obj57 = ~num18;
			object obj58 = 0x7F800000 & obj57;
			if (obj58 == null)
			{
				return;
			}
			thing2 = (NetworkId)(networkId & 0xFFFFFFFFL);
			if (!NearWhatItsIn((Into)b2, id2, thing2))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DA98E0");
			if (!(num17 < 0f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+DC]");
				if (0f < num17)
				{
					goto IL_0f7b;
				}
			}
			if (!(num18 < 0f) && (double)num18 > 1.0)
			{
				goto IL_0b98;
			}
		}
		else
		{
			thing2 = (NetworkId)(networkId & 0xFFFFFFFFL);
		}
		goto IL_0f7b;
		IL_0b98:
		NullReferenceException ex = new NullReferenceException();
		b6 = b5;
		int num19 = num2;
		byte b7 = b3;
		networkId3 = networkId2;
		num8 = bytePayloadSize2;
		num7 = bytePayloadSize;
		object obj59 = 0;
		num4 = bytePayloadSize5;
		obj = obj2;
		float num20 = hard;
		Fusion.RpcBuilder rpcBuilder5 = (Fusion.RpcBuilder)0;
		int num21 = bytePayloadSize8;
		goto IL_0c08;
		IL_048a:
		object obj60 = rpcInvokeInfo >> 32;
		bool flag26 = obj60 == null;
		object obj61 = !flag26;
		obj = obj2;
		num20 = hard;
		float num22 = 0f;
		num21 = (int)(&rpcBuilder3);
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			writer.Write(num2, 4);
			NetworkId value = (NetworkId)(networkId2 & 0xFFFFFFFFL);
			writer.Write(value, 4);
			playerRef = (PlayerRef)obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj63 = 0;
			writer.Write((Vector3)12, (int)obj63);
			writer.Write((Vector3)12, (int)obj63);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BD0]");
			num21 = 0;
			writer.Write(num17, 4);
			rpcInvokeInfo2 = (RpcInvokeInfo)((int*)num21)->m_value;
			writer.Write(num18, 4);
			int num23 = rpcBuilder3.Send();
			obj = obj54;
			num20 = num14;
			num22 = num18;
		}
		rpcBuilder3.Dispose();
		num5 = 0f;
		int num24 = 0;
		rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder3);
		num19 = (int)playerRef;
		b7 = (byte)(int)rpcInvokeInfo2;
		networkId3 = (NetworkId)playerRef2;
		num8 = (int)(&writer);
		num7 = (int)rpcInvokeInfo;
		obj59 = 0;
		rpcBuilder5 = (Fusion.RpcBuilder)num22;
		ex = (NullReferenceException)(&rpcBuilder3);
		b = e;
		b2 = b3;
		id2 = num2;
		networkId = networkId2;
		b4 = b5;
		num3 = 12f;
		goto IL_0f0b;
		IL_0c08:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex3 = default;
		OutOfMemoryException ex2 = ex3;
		object obj64 = default;
		OutOfMemoryException ex5 = default;
		while (true)
		{
			if ((nint)obj59 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num5 = 1f;
				num3 = 1f;
				num21 = num24;
			}
			else
			{
				if ((nint)obj59 != 1)
				{
					goto IL_0ee8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				num21 = (int)obj64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num24 = (int)obj64;
			}
			((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
			if (num21 == 0)
			{
				break;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			obj59 = 0;
			ex2 = ex4;
			goto IL_0ee8;
			IL_0ee8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			num8 = 0;
			num7 = 0;
			num4 = 0;
			ex2 = ex5;
		}
		obj59 = 0;
		ex = (NullReferenceException)rpcBuilder4;
		b = e;
		b2 = b3;
		id2 = num2;
		networkId = networkId2;
		b4 = b5;
		num3 = 0f;
		goto IL_0f0b;
	}

	private void In(int e, Into kind, int id, NetworkId thing, GoreSection s, Vector3 p, Vector3 way, float first, float hard)
	{
		//IL_06ac: Expected Obj, but got I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		//IL_0031: Expected VT, but got I4
		//IL_00ed: Expected VT, but got F4
		//IL_015c: Expected Obj, but got I4
		//IL_06d2: Invalid comparison between F4 and I4
		//IL_06e1: Invalid comparison between F4 and I4
		//IL_06f4: Expected Obj, but got F4
		//IL_0701: Expected Obj, but got F4
		//IL_0740: Expected Obj, but got I4
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_02cf: Expected VT, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_03c5: Expected Obj, but got VT
		//IL_03e6: Expected Obj, but got VT
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_045c: Expected VT, but got Obj
		//IL_053f: Expected VT, but got I4
		//IL_0551: Expected Obj, but got I4
		//IL_056b: Expected Obj, but got I4
		//IL_0590: Expected Obj, but got I4
		//IL_07a8: Invalid comparison between F8 and I4
		//IL_07b7: Expected F8, but got I4
		//IL_0582: Expected Obj, but got I4
		//IL_07d5: Expected Obj, but got I
		//IL_0816: Expected Obj, but got I4
		//IL_0616: Expected F4, but got I
		//IL_0616: Expected F4, but got I
		//IL_0616: Expected F4, but got VT
		//IL_0616: Expected VT, but got I4
		//IL_0616: Expected Obj, but got I
		//IL_061f: Invalid comparison between F8 and I4
		//IL_062e: Expected F8, but got I4
		//IL_0868: Expected F4, but got I
		bool flag = into == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		NetworkId thing2 = (NetworkId)(thing & 0xFFFFFFFFL);
		if (!Hold(kind, id, thing2, s, (Vector3)s))
		{
			return;
		}
		GillaItem gillaItem = item;
		into = kind;
		if ((object)item != null)
		{
			gillaItem.Stuck__BackingField = true;
			if (scraping != null)
			{
				bool[] array = default;
				array[0] = false;
				targetId = id;
				int e2 = default;
				end = e2;
				section = s;
				point = (Vector3)first;
				float num = (stuckAt = Time.time);
				hiddenSince = -1f;
				harmed = false;
				if ((object)on != null)
				{
					Vector3 lossyScale = on.lossyScale;
					object obj2 = s & (GoreSection)0xFF;
					float num2;
					if (obj2 != null)
					{
						num2 = Blade(e2);
					}
					else
					{
						num2 = Blade(e2);
						float num3 = num * skullStops;
						if (!(num2 < num3))
						{
							num2 = num3;
						}
					}
					float num5 = default;
					float num4 = num2 - num5;
					bool flag2 = num4 < 0f;
					bool flag3 = num4 == 0f;
					object obj3 = num2 ^ num5;
					object obj4 = num2 ^ num4;
					object obj5 = obj3 & obj4;
					bool flag4 = (nint)obj5 < 0;
					mostIn = num2;
					bool flag5 = flag2 == flag4;
					object obj6 = !flag3;
					object obj7 = flag5 & obj6;
					object obj8 = ~obj7;
					depth = (slidWas = ((obj8 != null) ? num2 : num5));
					if (Live)
					{
						NetworkObject networkObject = ((SimulationBehaviour)this)._object;
						if ((object)((SimulationBehaviour)this)._object != null)
						{
							object obj9 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
							bool flag6 = obj9 == null;
							object obj10 = !flag6;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
								object obj12 = default;
								object obj11 = obj12 & 1;
								if (obj11 != null)
								{
									Depth = depth;
								}
							}
						}
					}
					if ((object)on != null)
					{
						Vector3 vector = on.InverseTransformDirection((Vector3)0);
						Vector3 vector2 = default;
						axisOn = vector2;
						if ((object)on != null)
						{
							Quaternion rotation = on.rotation;
							Quaternion rotation2 = default;
							Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
							Transform transform = base.transform;
							if ((object)transform != null)
							{
								Quaternion rotation3 = transform.rotation;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction TRN2 not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
								object obj14 = default;
								object obj13 = vector2 * obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								object obj15 = vector2 * vector2;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
								object obj16 = vector2 * vector2;
								object obj17 = obj13 + obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
								object obj18 = obj13 - obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
								object obj19 = obj17 + obj16;
								object obj20 = obj18 - obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								object obj21 = obj16 * vector2;
								Quaternion quaternion2 = (turnOn = (Quaternion)(obj19 - obj21));
								Transform transform2 = base.transform;
								if ((object)transform2 != null)
								{
									Vector3 position = transform2.position;
									comeFrom = (Vector3)quaternion2;
									Transform transform3 = base.transform;
									if ((object)transform3 != null)
									{
										Quaternion rotation4 = transform3.rotation;
										comeTurn = quaternion2;
										comeFor = 0.12f;
										if ((object)on != null)
										{
											Vector3 vector3 = on.TransformPoint((Vector3)0);
											object obj22 = s & (GoreSection)0xFF;
											bool flag7 = obj22 == null;
											object obj23 = !flag7;
											if (obj23 == null)
											{
												object obj24 = 288;
											}
											else
											{
												object obj24 = 280;
											}
											double num6 = default;
											bool flag8 = num6 < 0.0;
											double num7 = 0.0;
											if (!flag8)
											{
												bool flag9 = !(num6 > 1.0);
												num7 = num6;
												if (!flag9)
												{
													num7 = 1.0;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
											object obj25 = 0;
											double num8 = num7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC38]");
											double num9 = num8 * 0.0;
											object obj26 = obj25;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v33+E4]");
											bool flag10 = (nint)0 == 0;
											object obj27 = !flag10;
											if (obj27 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v538 @ X8_v13]");
											nint num10 = 0;
											Vector3 vector4 = onLocal;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
											nint num11 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
											Sfx.Play((AudioClip[])num10, (Vector3)0, (float)vector4, num11, 0f);
											bool flag11 = num6 < 0.0;
											double num12 = 0.0;
											if (!flag11)
											{
												bool flag12 = !(num6 > 1.0);
												num12 = num6;
												if (!flag12)
												{
													num12 = 1.0;
												}
											}
											double num13 = num12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC38]");
											double num14 = num13 * 0.0;
											float num15 = (float)num14;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
											float strength = num15 + 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
											Buzz(strength, 0f);
											WetsTo(e2, depth);
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

	private unsafe bool Hold(Into kind, int id, NetworkId thing, GoreSection s, Vector3 p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0eae: Expected I4, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00e7: Expected Obj, but got I4
		//IL_06bc: Expected VT, but got I4
		//IL_02dd: Expected Ref, but got VT
		//IL_02e5: Expected VT, but got I4
		//IL_0458: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I4
		//IL_0eee: Expected Obj, but got I
		//IL_0f18: Expected Obj, but got I4
		//IL_0f36: Expected Obj, but got I
		//IL_0f46: Expected Obj, but got I
		//IL_0f60: Expected Obj, but got I
		//IL_0f71: Expected I, but got Obj
		//IL_013b: Expected Ref, but got VT
		//IL_0143: Expected VT, but got I4
		//IL_0814: Expected Obj, but got I
		//IL_083e: Expected Obj, but got I4
		//IL_04b7: Expected Obj, but got I
		//IL_04cc: Expected Obj, but got I
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected Obj, but got Unknown
		//IL_10d1: Expected Obj, but got I
		//IL_0334: Expected Obj, but got I
		//IL_035e: Expected Obj, but got I4
		//IL_0504: Expected Obj, but got I
		//IL_052e: Expected Obj, but got I4
		//IL_06d5: Expected Obj, but got I
		//IL_06ff: Expected Obj, but got I4
		//IL_0575: Expected Obj, but got I4
		//IL_057e: Expected Obj, but got I4
		//IL_1035: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I4
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa1: Expected Obj, but got Unknown
		//IL_0fdf: Expected Obj, but got I4
		//IL_05bb: Expected Obj, but got I4
		//IL_10fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1101: Expected Obj, but got Unknown
		//IL_1125: Expected Obj, but got I
		//IL_114f: Expected Obj, but got I4
		//IL_08ae: Expected Obj, but got I4
		//IL_0da3: Expected Obj, but got I
		//IL_0dcd: Expected Obj, but got I4
		//IL_0b62: Expected Obj, but got I4
		//IL_0913: Expected Obj, but got I
		//IL_091b: Expected I4, but got Obj
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected VT, but got Unknown
		//IL_1017: Expected Obj, but got I4
		//IL_1060: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Expected Obj, but got Unknown
		//IL_1089: Expected Obj, but got I
		//IL_10b3: Expected Obj, but got I4
		//IL_076f: Expected Obj, but got I4
		//IL_08de: Expected Obj, but got I
		//IL_11cc: Expected Obj, but got I
		//IL_11ee: Expected Obj, but got I4
		//IL_07d4: Expected Obj, but got I
		//IL_07dc: Expected I4, but got Obj
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected VT, but got Unknown
		//IL_0430: Expected Obj, but got I
		//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e21: Expected VT, but got Unknown
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Expected Obj, but got Unknown
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Expected Obj, but got Unknown
		//IL_11a6: Expected Obj, but got I4
		//IL_079f: Expected Obj, but got I
		//IL_0a02: Expected Obj, but got I4
		//IL_028e: Expected Obj, but got I
		//IL_0bc3: Expected Obj, but got I4
		//IL_0643: Expected Obj, but got I
		//IL_066d: Expected Obj, but got I4
		//IL_0c0d: Expected Obj, but got I4
		//IL_0d4c: Expected Obj, but got I4
		//IL_069c: Expected Obj, but got I4
		//IL_0a20: Expected Obj, but got I
		//IL_0a4a: Expected Obj, but got I4
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9e: Expected VT, but got Unknown
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected Obj, but got Unknown
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected VT, but got Unknown
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D90]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass175_0 obj2 = default;
		obj2._002Ector();
		System.__Canon _Canon = default;
		System.__Canon _Canon3 = default;
		if (obj2 != null)
		{
			object obj3 = this + 384;
			int num = default;
			obj2.id = num;
			on = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = this + 504;
			pulls = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = this + 472;
			ape = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = this + 480;
			copy = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = this + 488;
			dummy = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = this + 496;
			monster = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = kind & (Into)0xFF;
			if ((nint)obj9 <= 2)
			{
				if ((nint)obj9 != 1)
				{
					bool flag = (nint)obj9 != 2;
					ref Vector3 reference = ref *(Vector3*)thing;
					Vector3 vector = (Vector3)num;
					Transform transform = null;
					if (flag)
					{
						goto IL_0ede;
					}
					bool live = Live;
					bool flag2 = !live;
					UnityEngine.Object obj10 = null;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj11 = 0;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v155+E4]");
						bool flag3 = (nint)0 == 0;
						object obj13 = !flag3;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag4 = (UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null;
						bool flag5 = !flag4;
						num = 0;
						obj10 = null;
						if (!flag5)
						{
							if ((object)((SimulationBehaviour)this)._runner != null)
							{
								NetworkId networkId = (NetworkId)(thing & 0xFFFFFFFFL);
								NetworkObject networkObject = ((SimulationBehaviour)this)._runner.FindObject(networkId);
								bool flag6 = (object)networkObject == null;
								num = 0;
								if (!flag6)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BE8]");
									object obj14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
									num = 0;
									goto IL_07f7;
								}
								goto IL_0943;
							}
							goto IL_0ea0;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
					object obj15 = 0;
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v148+E4]");
					bool flag7 = (nint)0 == 0;
					object obj17 = !flag7;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj16 = obj15;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v148+A0]");
					object obj18 = 0;
					List<System.__Canon> list = (List<System.__Canon>)obj18;
					if (obj18 != null)
					{
						if (obj2.id < list._size)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v148+E4]");
							bool flag8 = (nint)0 == 0;
							object obj19 = !flag8;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj20 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v68+A0]");
								object obj21 = 0;
								list = (List<System.__Canon>)obj21;
								if (obj21 == null)
								{
									goto IL_0ea0;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D20]");
							object obj22 = 0;
							num = (int)obj22;
							_Canon = list.get_Item(obj2.id);
							goto IL_07f7;
						}
						goto IL_0943;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
					object obj23 = 0;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v67+E4]");
					bool flag9 = (nint)0 == 0;
					object obj25 = !flag9;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj24 = obj23;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v67+A0]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C10]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D98]");
					object obj28 = 0;
					Predicate<System.__Canon> predicate = default;
					predicate._002Ector((object)obj2, (IntPtr)obj28);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v31+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C00]");
						object obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v31+8]");
						System.__Canon _Canon2 = ((List<System.__Canon>)0).Find(predicate);
						ape = (NetworkApe)(object)_Canon2;
						object obj30 = this + 472;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj31 = 0;
						object obj32 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v74+E4]");
						bool flag10 = (nint)0 == 0;
						object obj33 = !flag10;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = (UnityEngine.Object)ape == (UnityEngine.Object)null;
						bool flag12 = !flag11;
						object obj34 = !flag12;
						object obj35 = 0;
						Dismemberment dismemberment = null;
						if (obj34 == null)
						{
							object obj36 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X0_v94+E4]");
							bool flag13 = (nint)0 == 0;
							object obj37 = !flag13;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj38 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X0_v98+E4]");
							bool flag14 = (nint)0 == 0;
							object obj39 = !flag14;
							if (obj39 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj38 = obj23;
							}
							object obj40 = obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X0_v98+A0]");
							object obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v47+E4]");
							bool flag15 = (nint)0 == 0;
							object obj42 = !flag15;
							if (obj42 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (ape == (UnityEngine.Object)obj41)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
								object obj43 = 0;
								object obj44 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X0_v103+E4]");
								bool flag16 = (nint)0 == 0;
								object obj45 = !flag16;
								if (obj45 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Dismemberment dismemberment2 = YourBody();
								obj35 = 0;
								dismemberment = dismemberment2;
							}
							else
							{
								NetworkApe networkApe = ape;
								if ((object)ape == null)
								{
									goto IL_0ea0;
								}
								dismemberment = networkApe.tearing;
								obj35 = 0;
							}
						}
						object obj46 = this + 480;
						copy = dismemberment;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj47 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X0_v81+E4]");
						bool flag17 = (nint)0 == 0;
						object obj48 = !flag17;
						if (obj48 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (copy == null)
						{
							goto IL_0d8d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
						object obj49 = 0;
						object obj50 = obj49;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X0_v85+E4]");
						bool flag18 = (nint)0 == 0;
						object obj51 = !flag18;
						if (obj51 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaWounds gillaWounds = GillaWounds.On(copy);
						if ((object)gillaWounds != null)
						{
							Vector3 vector = (Vector3)(this + 392);
							Transform transform2 = (on = gillaWounds.BoneAt(s, vector, out *(Vector3*)null));
							object obj52 = this + 384;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bodyId = obj2.id;
							ref Vector3 reference = ref *(Vector3*)null;
							Transform transform = transform2;
							goto IL_0ede;
						}
					}
				}
			}
			else
			{
				if ((nint)obj9 == 3)
				{
					return OnBody(obj2.id, (Vector3)num);
				}
				bool flag19 = (nint)obj9 != 4;
				ref Vector3 reference = ref *(Vector3*)thing;
				Vector3 vector = (Vector3)num;
				Transform transform = null;
				if (flag19)
				{
					goto IL_0ede;
				}
				bool live2 = Live;
				bool flag20 = !live2;
				UnityEngine.Object obj53 = null;
				if (!flag20)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj54 = 0;
					object obj55 = obj54;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v58+E4]");
					bool flag21 = (nint)0 == 0;
					object obj56 = !flag21;
					if (obj56 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag22 = (UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null;
					bool flag23 = !flag22;
					num = 0;
					obj53 = null;
					if (!flag23)
					{
						if ((object)((SimulationBehaviour)this)._runner != null)
						{
							NetworkId networkId2 = (NetworkId)(thing & 0xFFFFFFFFL);
							NetworkObject networkObject2 = ((SimulationBehaviour)this)._runner.FindObject(networkId2);
							bool flag24 = (object)networkObject2 == null;
							num = 0;
							if (!flag24)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF0]");
								object obj57 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
								num = 0;
								goto IL_0936;
							}
							goto IL_0b1f;
						}
						goto IL_0ea0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
				object obj58 = 0;
				object obj59 = obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v51+E4]");
				bool flag25 = (nint)0 == 0;
				object obj60 = !flag25;
				if (obj60 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj59 = obj58;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v51+A0]");
				object obj61 = 0;
				List<System.__Canon> list2 = (List<System.__Canon>)obj61;
				if (obj61 != null)
				{
					if (obj2.id < list2._size)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v51+E4]");
						bool flag26 = (nint)0 == 0;
						object obj62 = !flag26;
						if (obj62 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj63 = obj58;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v22+A0]");
							object obj64 = 0;
							list2 = (List<System.__Canon>)obj64;
							if (obj64 == null)
							{
								goto IL_0ea0;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D28]");
						object obj65 = 0;
						num = (int)obj65;
						_Canon3 = list2.get_Item(obj2.id);
						goto IL_0936;
					}
					goto IL_0b1f;
				}
			}
		}
		goto IL_0ea0;
		IL_105a:
		object obj66 = this + 488;
		System.__Canon _Canon4;
		dummy = (GillaDummy)(object)_Canon4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj67 = 0;
		object obj68 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v122+E4]");
		bool flag27 = (nint)0 == 0;
		object obj69 = !flag27;
		if (obj69 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag28 = (UnityEngine.Object)dummy != (UnityEngine.Object)null;
		bool flag29 = !flag28;
		Dismemberment dismemberment3 = null;
		if (!flag29)
		{
			GillaDummy gillaDummy = dummy;
			if ((object)dummy == null)
			{
				goto IL_0ea0;
			}
			dismemberment3 = gillaDummy.tearing;
		}
		object obj70 = this + 480;
		copy = dismemberment3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj71 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X0_v128+E4]");
		bool flag30 = (nint)0 == 0;
		object obj72 = !flag30;
		if (obj72 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag31 = copy == null;
		bool flag32 = !flag31;
		object obj73 = !flag32;
		if (obj73 != null)
		{
			goto IL_0d8d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj74 = 0;
		object obj75 = obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X0_v132+E4]");
		bool flag33 = (nint)0 == 0;
		object obj76 = !flag33;
		if (obj76 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds gillaWounds2 = GillaWounds.On(copy);
		if ((object)gillaWounds2 != null)
		{
			Vector3 vector = (Vector3)(this + 392);
			Transform transform3 = gillaWounds2.BoneAt(s, vector, out *(Vector3*)null);
			on = transform3;
			object obj77 = this + 384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if ((object)dummy != null)
			{
				int num2 = dummy.BodyId;
				bodyId = num2;
				ref Vector3 reference = ref *(Vector3*)null;
				Transform transform = null;
				goto IL_0ede;
			}
		}
		goto IL_0ea0;
		IL_0ea0:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0943:
		_Canon4 = null;
		goto IL_105a;
		IL_07f7:
		_Canon4 = _Canon;
		goto IL_105a;
		IL_0d8d:
		return false;
		IL_0b1f:
		System.__Canon _Canon5 = null;
		goto IL_10f6;
		IL_0936:
		_Canon5 = _Canon3;
		goto IL_10f6;
		IL_10f6:
		object obj78 = this + 496;
		monster = (MonsterBrain)(object)_Canon5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj79 = 0;
		object obj80 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v33+E4]");
		bool flag34 = (nint)0 == 0;
		object obj81 = !flag34;
		if (obj81 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag35 = monster == null;
		bool flag36 = !flag35;
		object obj82 = !flag36;
		if (obj82 != null)
		{
			goto IL_0d8d;
		}
		MonsterBrain monsterBrain = monster;
		if ((object)monster != null)
		{
			object obj83 = obj79;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v37+E4]");
			bool flag37 = (nint)0 == 0;
			object obj84 = !flag37;
			if (obj84 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag38 = monsterBrain.Hurt__BackingField == null;
			bool flag39 = !flag38;
			object obj85 = !flag39;
			if (obj85 != null)
			{
				goto IL_0d8d;
			}
			MonsterBrain monsterBrain2 = monster;
			if ((object)monster != null)
			{
				MonsterWounds monsterWounds = monsterBrain2.Hurt__BackingField;
				if ((object)monsterBrain2.Hurt__BackingField != null)
				{
					if (~(monsterWounds.ready ? 1u : 0u) != 0)
					{
						goto IL_0d8d;
					}
					if ((object)monsterWounds.wounds != null)
					{
						Vector3 vector = (Vector3)(this + 392);
						Transform transform4 = (on = monsterWounds.wounds.BoneAt(s, vector, out *(Vector3*)null));
						object obj86 = this + 384;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						ref Vector3 reference = ref *(Vector3*)null;
						Transform transform = transform4;
						goto IL_0ede;
					}
				}
			}
		}
		goto IL_0ea0;
		IL_0ede:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj87 = 0;
		object obj88 = obj87;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v19+E4]");
		bool flag40 = (nint)0 == 0;
		object obj89 = !flag40;
		if (obj89 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return on != null;
	}

	private static Dismemberment YourBody()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 != null;
		bool flag5 = !flag4;
		Dismemberment result = null;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1+8]");
			if ((nint)0 == 0)
			{
				goto IL_01fe;
			}
			object obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v16+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+68]");
			bool flag7 = (UnityEngine.Object)0 != null;
			bool flag8 = !flag7;
			result = null;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+68]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+68]");
				if ((nint)0 == 0)
				{
					goto IL_01fe;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v14+20]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v14+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v15+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v15+18]");
						if ((nint)0 == 0)
						{
							goto IL_020c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v15+20]");
						result = (Dismemberment)0;
						goto IL_029a;
					}
				}
				result = null;
			}
		}
		goto IL_029a;
		IL_029a:
		return result;
		IL_020c:
		return (Dismemberment)(object)new IndexOutOfRangeException();
		IL_01fe:
		NullReferenceException ex = new NullReferenceException();
		goto IL_020c;
	}

	private bool OnBody(int id, Vector3 p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_07fe: Expected Obj, but got I
		//IL_0820: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected I4, but got Unknown
		//IL_00bf: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_065c: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I
		//IL_0334: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I
		//IL_06c6: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected Obj, but got Unknown
		//IL_0724: Expected Obj, but got I4
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got I4
		//IL_074a: Expected VT, but got I4
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected VT, but got Unknown
		//IL_040c: Expected Obj, but got I4
		//IL_0415: Expected Obj, but got I4
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected Obj, but got Unknown
		//IL_079c: Expected Obj, but got I4
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got I4
		//IL_0465: Expected Obj, but got I4
		//IL_0481: Expected VT, but got I4
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got I4
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaCorpse gillaCorpse = GillaCorpse.Find(id);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = gillaCorpse == null;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		if (obj7 != null)
		{
			goto IL_06a4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CA0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CB8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CB0]");
		object obj11 = 0;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val3 = default;
		Enumerator<, > val2 = val3;
		UnityEngine.Object obj16 = (UnityEngine.Object)2139095039;
		UnityEngine.Object obj17 = null;
		object obj18 = obj13;
		object obj19 = obj15;
		Enumerator<, > val4 = val3;
		object obj20 = 0;
		UnityEngine.Object obj21 = null;
		int num = 0;
		UnityEngine.Object obj22 = (UnityEngine.Object)2139095039;
		UnityEngine.Object obj24 = default;
		Enumerator<, > val5 = default;
		bool result = default;
		while (true)
		{
			if (num != 0)
			{
				if ((object)gillaCorpse == null)
				{
					break;
				}
				bool flag5 = gillaCorpse.IsOff(num);
				bool flag6 = !flag5;
				object obj23 = !flag6;
				if (obj23 == null)
				{
					obj24 = obj24;
					obj20 = 0;
					obj21 = (UnityEngine.Object)num;
					goto IL_05db;
				}
			}
			else if ((object)gillaCorpse == null)
			{
				break;
			}
			Transform transform = gillaCorpse.PartTransform(num);
			obj22 = (UnityEngine.Object)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v14 (UnityEngine.Object)+E4]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = transform == null;
			bool flag9 = !flag8;
			object obj26 = !flag9;
			obj24 = obj24;
			obj20 = 0;
			obj21 = null;
			if (obj26 == null)
			{
				object obj27 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X0_v48+E4]");
				bool flag10 = (nint)0 == 0;
				object obj28 = !flag10;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag11 = (object)transform == null;
				obj20 = 0;
				obj21 = null;
				if (flag11)
				{
					break;
				}
				object obj29 = obj8;
				obj20 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v19+A0]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v20+28]");
				obj21 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F9CC");
				object obj31 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X8_v21+A0]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v22+28]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v22+28]");
				Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
				val2 = val5;
				while (true)
				{
					Enumerator<, > val6;
					if (val.MoveNext())
					{
						object obj33 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v57+E4]");
						bool flag12 = (nint)0 == 0;
						object obj34 = !flag12;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag13 = obj24 == null;
						bool flag14 = !flag13;
						object obj35 = !flag14;
						obj20 = 0;
						if (obj35 != null)
						{
							continue;
						}
						if ((object)obj24 != null)
						{
							bool flag15 = ((Collider)obj24).enabled;
							bool flag16 = !flag15;
							obj20 = 0;
							if (!flag16)
							{
								Vector3 vector = ((Collider)obj24).ClosestPoint((Vector3)0);
								object obj36 = val3 - val3;
								object obj37 = obj15 - obj15;
								object obj38 = obj13 - obj13;
								object obj39 = obj36 * obj36;
								object obj40 = obj37 * obj37;
								object obj41 = obj39 + obj40;
								object obj42 = obj38 * obj38;
								UnityEngine.Object obj43 = (UnityEngine.Object)(object)(obj42 + obj41);
								bool flag17 = System.Runtime.CompilerServices.Unsafe.As<UnityEngine.Object, UIntPtr>(ref obj43) >= System.Runtime.CompilerServices.Unsafe.As<UnityEngine.Object, UIntPtr>(ref obj16);
								obj12 = obj13;
								obj14 = obj15;
								val2 = val3;
								obj20 = 0;
								if (!flag17)
								{
									obj12 = obj13;
									obj14 = obj15;
									val2 = val3;
									obj16 = obj43;
									obj17 = obj24;
									obj18 = obj13;
									obj19 = obj15;
									val4 = val3;
									obj20 = 0;
								}
							}
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						val6 = (Enumerator<, >)(ref val);
						obj20 = 0;
						obj21 = null;
						break;
					}
					obj21 = (UnityEngine.Object)obj11;
					val.Dispose();
					val6 = (Enumerator<, >)(ref val);
					OutOfMemoryException ex2 = new OutOfMemoryException();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D820");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
			}
			goto IL_05db;
			IL_05db:
			num++;
			if (num != 4)
			{
				continue;
			}
			goto IL_0632;
		}
		goto IL_07b4;
		IL_06a4:
		UnityEngine.Object obj44 = null;
		goto IL_07a1;
		IL_0632:
		object obj45 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v27+E4]");
		bool flag18 = (nint)0 == 0;
		object obj46 = !flag18;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj17 == null)
		{
			goto IL_06a4;
		}
		bool flag19 = (object)obj17 == null;
		obj20 = 0;
		obj21 = null;
		if (!flag19)
		{
			Transform transform2 = (on = ((Component)obj17).transform);
			object obj47 = this + 384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag20 = (object)on == null;
			obj20 = 0;
			obj21 = transform2;
			if (!flag20)
			{
				Vector3 vector2 = on.InverseTransformPoint((Vector3)0);
				onLocal = (Vector3)val4;
				Rigidbody attachedRigidbody = ((Collider)obj17).attachedRigidbody;
				pulls = attachedRigidbody;
				object obj48 = this + 504;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj44 = (UnityEngine.Object)1;
				goto IL_07a1;
			}
		}
		goto IL_07b4;
		IL_07a1:
		return (byte)(obj44 & 1) != 0;
		IL_07b4:
		throw new NullReferenceException();
	}

	private void InIt(float dt)
	{
		//IL_0037: Expected VT, but got I4
		//IL_0190: Invalid comparison between F4 and I4
		//IL_01a3: Expected Obj, but got F4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01e2: Expected Obj, but got I4
		//IL_0092: Expected I4, but got I8
		//IL_00ac: Expected Obj, but got I4
		//IL_0250: Expected VT, but got I4
		//IL_0250: Expected VT, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_0267: Expected VT, but got I4
		//IL_065f: Expected Obj, but got I4
		//IL_0677: Invalid comparison between F4 and I4
		//IL_0697: Expected Obj, but got I4
		//IL_04a7: Expected VT, but got I4
		//IL_04a7: Expected VT, but got I4
		//IL_00cb: Expected F4, but got VT
		//IL_00cb: Expected VT, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
		//IL_04fd: Expected VT, but got I4
		//IL_0293: Expected I4, but got I8
		//IL_0305: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I4
		//IL_0567: Expected Obj, but got I4
		//IL_0581: Expected Obj, but got I4
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		if (StillThere())
		{
			Vector3 vector = on.TransformPoint((Vector3)0);
			if (item.Mine)
			{
				GillaItem gillaItem = item;
				int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
				bool flag = num == 0;
				object obj = !flag;
				if (obj == null)
				{
					bool flag2 = Held((Vector3)0, (float)onLocal);
					bool flag3 = !flag2;
					object obj2 = !flag3;
					if (obj2 == null)
					{
						return;
					}
				}
				else
				{
					Quaternion rotation = on.rotation;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
					object obj4 = default;
					object obj3 = 0 * obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
					object obj6 = default;
					object obj5 = obj6 + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					object obj7 = obj5 + onLocal;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
					object obj8 = 0 * turnOn;
					object obj9 = obj7 - obj8;
					Transform transform = base.transform;
					Vector3 holeOn = HoleOn;
					Vector3 vector2 = (Quaternion)0 * (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
					object obj10 = 0 - obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
					object obj12 = default;
					object obj11 = 0 - obj12;
					object obj13 = default;
					float num2 = (float)onLocal - (float)obj13;
					Quaternion rotation2 = default;
					transform.SetPositionAndRotation((Vector3)0, rotation2);
					if (Live)
					{
						NetworkObject networkObject = ((SimulationBehaviour)this)._object;
						if ((object)((SimulationBehaviour)this)._object != null)
						{
							object obj14 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
							bool flag4 = obj14 == null;
							object obj15 = !flag4;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
								object obj17 = default;
								object obj16 = obj17 & 1;
								if (obj16 != null)
								{
									NetworkBool pulling = Pulling;
									if ((bool)pulling)
									{
										NetworkBool pulling2 = false;
										Pulling = pulling2;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				bool live = Live;
				float num3 = depth;
				if (live)
				{
					float num4 = Depth;
					float num5 = num4 - depth;
					float num6 = dt * 1.5f;
					float num7 = dt * 1.5f;
					float num8 = 0f - num7;
					bool flag5 = num5 < 0f;
					object obj18 = num5 ^ num5;
					object obj19 = num5 & obj18;
					bool flag6 = (nint)obj19 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					bool flag7 = flag5 == flag6;
					object obj20 = !flag7;
					object obj21 = ~obj20;
					if (obj21 != null)
					{
						num8 = num6;
					}
					bool flag8 = num5 < num6;
					object obj22 = !flag8;
					float num9 = num5 - num6;
					bool flag9 = num9 == 0f;
					float num10 = num3 + num8;
					object obj23 = !flag9;
					object obj24 = obj22 & obj23;
					object obj25 = ~obj24;
					num3 = ((obj25 != null) ? num4 : num10);
				}
				depth = num3;
				Transform transform2 = base.transform;
				Transform transform3 = base.transform;
				Quaternion rotation3 = transform3.rotation;
				Vector3 holeOn2 = HoleOn;
				Vector3 vector3 = (Quaternion)0 * (Vector3)0;
				transform2.position = (Vector3)0;
			}
			GillaItem gillaItem2 = item;
			if ((int)(gillaItem2.Hand__BackingField & 0x80000000L) != 0)
			{
				Pin();
				gillaItem2 = item;
			}
			if (gillaItem2.Mine)
			{
				bool flag10 = (byte)(~(harmed ? 1u : 0u)) != 0;
				object obj26 = !flag10;
				if (obj26 == null && !(depth < countsAt))
				{
					Harms();
				}
				bool flag11 = (byte)(~(through ? 1u : 0u)) != 0;
				object obj27 = !flag11;
				if (obj27 == null)
				{
					float num11 = ThroughAt();
					if (!(depth < num11))
					{
						GoesThrough();
					}
				}
			}
			WetsTo(end, depth);
			Slides(dt);
		}
		else
		{
			Out(yanked: false, seen: false);
		}
	}

	private unsafe bool Held(Vector3 hole, float dt)
	{
		//IL_0ee7: Expected I4, but got Obj
		//IL_0078: Expected VT, but got I4
		//IL_1713: Expected Obj, but got I
		//IL_173d: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got VT
		//IL_00be: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_0194: Expected VT, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected VT, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_01d3: Expected VT, but got F4
		//IL_020c: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I4
		//IL_0f4f: Expected Obj, but got VT
		//IL_0f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Expected Obj, but got Unknown
		//IL_021a: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I4
		//IL_0fb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Expected Obj, but got Unknown
		//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe4: Expected Obj, but got Unknown
		//IL_0236: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I4
		//IL_0272: Invalid comparison between F4 and I4
		//IL_0281: Invalid comparison between F4 and I4
		//IL_0294: Expected Obj, but got F4
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_02c9: Expected Obj, but got I4
		//IL_02e2: Expected Obj, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_11a9: Invalid comparison between F4 and I4
		//IL_11ba: Expected Obj, but got I4
		//IL_11c3: Invalid comparison between F4 and I4
		//IL_11e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e9: Expected Obj, but got Unknown
		//IL_031d: Expected Obj, but got I4
		//IL_107a: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Expected Obj, but got Unknown
		//IL_108f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1094: Expected Obj, but got Unknown
		//IL_1098: Unsupported input type for neg.
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_109d: Expected Obj, but got Unknown
		//IL_10b5: Invalid comparison between F4 and I4
		//IL_10c8: Expected Obj, but got F4
		//IL_10d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d5: Expected Obj, but got Unknown
		//IL_10fd: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I4
		//IL_037b: Expected VT, but got I4
		//IL_037b: Expected VT, but got I4
		//IL_0388: Unsupported input type for neg.
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected VT, but got Unknown
		//IL_039e: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_0545: Expected VT, but got Obj
		//IL_0580: Expected VT, but got Ref
		//IL_0580: Expected VT, but got I4
		//IL_1146: Expected Obj, but got I4
		//IL_116d: Expected Obj, but got I4
		//IL_05c2: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I4
		//IL_1779: Expected Obj, but got VT
		//IL_179d: Expected Obj, but got VT
		//IL_1820: Expected Obj, but got I4
		//IL_05ff: Expected F8, but got I4
		//IL_120c: Invalid comparison between F8 and I
		//IL_0942: Expected I, but got Obj
		//IL_095a: Expected F4, but got VT
		//IL_096a: Expected VT, but got Ref
		//IL_061a: Expected Obj, but got VT
		//IL_1269: Expected VT, but got I4
		//IL_127b: Expected VT, but got I4
		//IL_124d: Expected Obj, but got I4
		//IL_1304: Expected VT, but got I4
		//IL_090d: Expected VT, but got F4
		//IL_0912: Expected I, but got Obj
		//IL_091a: Expected VT, but got Ref
		//IL_1481: Expected Obj, but got I4
		//IL_18c4: Invalid comparison between F4 and I4
		//IL_1498: Invalid comparison between F4 and I4
		//IL_14c1: Invalid comparison between F4 and I4
		//IL_14d0: Invalid comparison between F4 and I4
		//IL_14e3: Expected Obj, but got F4
		//IL_14eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f0: Expected Obj, but got Unknown
		//IL_1518: Expected Obj, but got I4
		//IL_1520: Unknown result type (might be due to invalid IL or missing references)
		//IL_1525: Expected Obj, but got Unknown
		//IL_0987: Expected F4, but got I4
		//IL_0995: Expected F4, but got I4
		//IL_09c3: Expected Obj, but got I4
		//IL_158c: Invalid comparison between F4 and I
		//IL_09b5: Expected Obj, but got I4
		//IL_0a36: Expected VT, but got I4
		//IL_0a44: Expected VT, but got F4
		//IL_0c41: Expected VT, but got F4
		//IL_0c5f: Expected VT, but got I4
		//IL_0c5f: Expected VT, but got I4
		//IL_0c9a: Expected VT, but got F4
		//IL_0caf: Invalid comparison between F4 and I4
		//IL_0cc9: Expected VT, but got I4
		//IL_0d35: Invalid comparison between F4 and I4
		//IL_0d44: Expected F8, but got I4
		//IL_0da2: Expected VT, but got I4
		//IL_1603: Unknown result type (might be due to invalid IL or missing references)
		//IL_1608: Expected Obj, but got Unknown
		//IL_16c6: Expected VT, but got I4
		//IL_16de: Expected F4, but got I
		//IL_16f6: Expected F4, but got I
		//IL_0e0a: Expected Obj, but got I4
		//IL_0e24: Expected Obj, but got I4
		//IL_0e45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4a: Expected Obj, but got Unknown
		//IL_0ea0: Expected VT, but got I4
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			Vector3 vector = Along(end);
			if ((object)on != null)
			{
				Vector3 vector2 = on.TransformDirection((Vector3)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = axisOn * axisOn;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+198]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+198]");
				object obj5 = num * 0;
				object obj6 = obj4 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+19C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+19C]");
				object obj7 = num2 * 0;
				object obj8 = obj7 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				Vector3 vector3;
				object obj9;
				object obj10;
				if ((nint)obj8 > 0)
				{
					vector3 = axisOn / obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+198]");
					obj9 = 0 / obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+19C]");
					obj10 = 0 / obj8;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v65+A0]");
					object obj13 = 0;
					vector3 = (Vector3)obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v66+4]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v66+8]");
					obj10 = 0;
				}
				Transform transform2 = base.transform;
				if ((object)transform2 != null)
				{
					Quaternion rotation = transform2.rotation;
					Vector3 vector4 = (Vector3)(dt - dt);
					if (end == 0)
					{
						object obj14 = 112;
					}
					else
					{
						object obj14 = 136;
					}
					if (end == 0)
					{
						object obj15 = 116;
					}
					else
					{
						object obj15 = 140;
					}
					object obj17 = default;
					object obj16 = obj17 - obj17;
					object obj18 = vector4 * vector3;
					object obj20 = default;
					object obj19 = obj20 - obj20;
					object obj21 = obj16 * obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+v542 @ X8_v11]");
					object obj22 = dt * 0;
					if (end == 0)
					{
						object obj23 = 120;
					}
					else
					{
						object obj23 = 144;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+v546 @ X9_v3]");
					object obj24 = obj17 * 0;
					object obj25 = obj18 + obj21;
					object obj26 = obj24 + obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+v562 @ X8_v13]");
					object obj27 = obj20 * 0;
					object obj28 = obj19 * obj10;
					object obj29 = obj27 + obj26;
					object obj30 = obj28 + obj25;
					object obj31 = obj30 + obj29;
					float num3 = depth;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
					object obj41 = default;
					if ((nint)obj25 > 0)
					{
						float num4 = (float)obj31 - depth;
						object obj32 = 17281024 + 456;
						bool flag2 = num4 < 0f;
						bool flag3 = num4 == 0f;
						object obj33 = num4 ^ num4;
						object obj34 = num4 & obj33;
						bool flag4 = (nint)obj34 < 0;
						bool flag5 = flag2 == flag4;
						object obj35 = !flag5;
						bool flag6 = flag2 == flag4;
						object obj36 = !flag3;
						object obj37 = flag6 & obj36;
						object obj38 = ~obj37;
						if (obj38 == null)
						{
							object obj39 = 244;
						}
						else
						{
							object obj39 = 248;
						}
						float num5 = (float)obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X9_v12+v604 @ TEMPCOND_v37*4]");
						float num6 = num5 - 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+v641 @ X8_v56]");
						object obj40 = 0 * obj41;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+v641 @ X8_v56]");
						object obj42 = 0 * obj41;
						object obj43 = 0 - obj42;
						float num7 = num6 - num3;
						bool flag7 = num7 < 0f;
						object obj44 = num7 ^ num7;
						object obj45 = num7 & obj44;
						bool flag8 = (nint)obj45 < 0;
						bool flag9 = flag7 == flag8;
						object obj46 = !flag9;
						object obj47 = ~obj46;
						object obj48 = ((obj47 != null) ? obj40 : obj43);
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
						num3 += (float)obj48;
						bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj43) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40);
						object obj49 = !flag10;
						object obj50 = obj43 - obj40;
						bool flag11 = obj50 == null;
						object obj51 = !flag11;
						object obj52 = obj49 & obj51;
						object obj53 = ~obj52;
						if (obj53 != null)
						{
							num3 = num6;
						}
						depth = num3;
					}
					if (!(num3 < mostIn))
					{
						num3 = mostIn;
					}
					bool flag12 = num3 < 0f;
					object obj54 = !flag12;
					bool flag13 = num3 == 0f;
					depth = num3;
					object obj55 = ~obj54;
					object obj56 = obj55 | flag13;
					bool yanked;
					if (obj56 == null)
					{
						Vector3 holeOn = HoleOn;
						Vector3 vector5 = (Quaternion)0 * (Vector3)0;
						Vector3 vector6 = (Vector3)(0 - obj10);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						object obj57 = -0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+19C]");
						object obj58 = -0;
						Vector3 toDirection = default;
						Vector3 fromDirection = default;
						Quaternion quaternion = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
						object obj59 = obj41 * vector6;
						object obj60 = obj10 * obj41;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						object obj61 = 0 * obj41;
						object obj62 = obj41 * obj57;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+19C]");
						object obj63 = 0 * obj41;
						object obj64 = obj41 * obj58;
						object obj65 = obj41 * obj41;
						object obj66 = obj10 * vector6;
						object obj67 = obj60 + obj59;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+19C]");
						object obj68 = 0 * obj57;
						object obj69 = obj10 * obj57;
						object obj70 = obj61 + obj62;
						object obj71 = obj10 * obj58;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						object obj72 = 0 * obj58;
						object obj73 = obj63 + obj64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						object obj74 = 0 * vector6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+19C]");
						object obj75 = 0 * vector6;
						object obj76 = obj65 - obj66;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						object obj77 = 0 * obj57;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+19C]");
						object obj78 = 0 * obj58;
						object obj79 = obj68 + obj67;
						object obj80 = obj71 + obj70;
						object obj81 = obj74 + obj73;
						object obj82 = obj76 - obj77;
						Vector3 vector7 = (Vector3)(obj79 - obj72);
						float num8 = (float)obj80 - (float)obj75;
						float num9 = (float)obj81 - (float)obj69;
						float num10 = (float)obj82 - (float)obj78;
						Vector3 vector8 = (Quaternion)0 * (Vector3)(&toDirection);
						if (into == (Into)3)
						{
							object obj83 = 256;
						}
						else
						{
							object obj83 = 252;
						}
						object obj84 = vector7 * vector7;
						float num11 = num8 * num8;
						object obj85 = obj;
						object obj86 = vector3 * vector3;
						object obj87 = obj9 * obj9;
						float num12 = (float)obj84 + num11;
						float num13 = num9 * num9;
						object obj88 = obj86 + obj87;
						object obj89 = obj10 * obj10;
						object obj90 = obj89 + obj88;
						float num14 = num13 + num12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X0_v29+E4]");
						bool flag14 = (nint)0 == 0;
						object obj91 = !flag14;
						if (obj91 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
						bool flag15 = (nint)obj90 < 0;
						double num15 = 0.0;
						if (!flag15)
						{
							object obj92 = vector3 * vector7;
							float num16 = (float)obj9 * num8;
							float num17 = (float)obj92 + num16;
							float num18 = (float)obj10 * num9;
							float num19 = num18 + num17;
							double num20 = (double)num19 / (double)obj90;
							bool flag16 = num20 < -1.0;
							double num21 = -1.0;
							if (!flag16)
							{
								bool flag17 = !(num20 > 1.0);
								num21 = num20;
								if (!flag17)
								{
									num21 = 1.0;
								}
							}
							object obj93 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X0_v81+E4]");
							bool flag18 = (nint)0 == 0;
							object obj94 = !flag18;
							if (obj94 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
							double num22 = num21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
							num15 = num22 * 0.0;
						}
						double num23 = num15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+v900 @ X8_v19]");
						float num52;
						float num53;
						Vector3 vector10;
						float num51;
						float num50;
						if (num23 > 0.0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+v900 @ X8_v19]");
							float num24 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
							float num25 = num24 * 0f;
							Vector3 vector9 = Vector3.Internal_RotateTowards(ref fromDirection, ref toDirection, num25, 0f);
							Quaternion quaternion2 = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
							float num26 = num10 * num25;
							float num27 = num8 * num13;
							float num28 = (float)vector7 * num13;
							float num29 = num9 * num13;
							float num30 = num10 * 0f;
							float num31 = num10 * (float)vector3;
							float num32 = num10 * num13;
							float num33 = (float)vector7 * num25;
							float num34 = num28 + num26;
							float num35 = num9 * 0f;
							float num36 = num27 + num30;
							float num37 = (float)vector7 * (float)vector3;
							float num38 = num29 + num31;
							float num39 = num8 * num25;
							float num40 = num32 - num33;
							float num41 = num8 * 0f;
							float num42 = num35 + num34;
							float num43 = num9 * num25;
							float num44 = (float)vector7 * 0f;
							float num45 = num37 + num36;
							float num46 = num8 * (float)vector3;
							float num47 = num9 * (float)vector3;
							float num48 = num39 + num38;
							float num49 = num40 - num41;
							num50 = num42 - num46;
							num51 = num45 - num43;
							num52 = num48 - num44;
							num53 = num49 - num47;
							fromDirection = vector7;
							toDirection = (Vector3)num25;
							nint num54 = unchecked((nint)null);
							vector10 = (Vector3)(&toDirection);
						}
						else
						{
							fromDirection = vector6;
							toDirection = vector4;
							nint num54 = unchecked((nint)null);
							num51 = num8;
							num53 = num10;
							num50 = (float)vector7;
							num52 = num9;
							vector10 = (Vector3)(&toDirection);
						}
						Vector3 vector11 = (Quaternion)0 * vector10;
						Vector3 vector12 = (Quaternion)0 * vector10;
						float num55 = dt - num50;
						float num56 = (float)obj17 - num51;
						float num57 = (float)obj20 - num52;
						float num58 = dt - num55;
						float num59 = (float)obj17 - num56;
						float num60 = (float)obj20 - num57;
						Vector3 vector13 = (Quaternion)0 * vector10;
						float num61 = num58 * num50;
						float num62 = num59 * num51;
						float num63 = num50 * num58;
						float num64 = num51 * num59;
						float num65 = num61 + num62;
						float num66 = num60 * num52;
						float num67 = num63 + num64;
						float num68 = num66 + num65;
						float num69 = num52 * num60;
						float num70 = num69 + num67;
						float num71 = num50 * num68;
						float num72 = num51 * num68;
						float num73 = num52 * num68;
						float num74 = num50 * num70;
						float num75 = num58 - num71;
						float num76 = num59 - num72;
						float num77 = num60 - num73;
						float num78 = num51 * num70;
						float num79 = num52 * num70;
						object obj95 = obj;
						float num80 = num75 - num74;
						float num81 = num76 - num78;
						float num82 = num77 - num79;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ X0_v41+E4]");
						bool flag19 = (nint)0 == 0;
						object obj96 = !flag19;
						if (obj96 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num83 = num80 * num80;
						float num84 = num81 * num81;
						float num85 = num82 * num82;
						float num86 = num83 + num84;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						float num87 = num85 + num86;
						float num88 = num84;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9AC]");
						float num89 = num88 + 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						float num90 = num70;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A834]");
						float num91 = num90 + 0f;
						if (num89 < 0f)
						{
							num89 = 0f;
						}
						if (num91 < 0f)
						{
							num91 = 0f;
						}
						float num92 = 0f - num70;
						bool flag20 = num70 < 0f;
						bool flag21 = num70 == 0f;
						object obj97 = num70 ^ num70;
						object obj98 = num70 & obj97;
						bool flag22 = (nint)obj98 < 0;
						bool flag23 = flag20 == flag22;
						object obj99 = !flag21;
						object obj100 = flag23 & obj99;
						object obj101 = ~obj100;
						if (obj101 != null)
						{
							num91 = num92;
						}
						if (into == (Into)3)
						{
							object obj102 = 264;
						}
						else
						{
							object obj102 = 260;
						}
						float num93 = num89 + num87;
						float num94 = num91 + num93;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+v760 @ X8_v37]");
						if (!(num94 > 0f))
						{
							float num95 = (float)obj41;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A840]");
							float num96 = num95 * 0f;
							Vector3 vector14 = Vector3.Internal_RotateTowards(ref fromDirection, ref toDirection, num96, 0f);
							if ((object)on != null)
							{
								Vector3 vector15 = on.InverseTransformDirection((Vector3)0);
								axisOn = (Vector3)num96;
								_ = 0;
								if ((object)on != null)
								{
									Quaternion rotation2 = on.rotation;
									Quaternion rotation3 = default;
									Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation3);
									float num97 = num53 * num96;
									float num98 = num50 * num92;
									float num99 = num51 * num92;
									float num100 = num53 * 0f;
									float num101 = num52 * num92;
									float num102 = num53 * (float)vector3;
									float num103 = num53 * num92;
									float num104 = num50 * num96;
									float num105 = num98 + num97;
									float num106 = num52 * 0f;
									float num107 = num99 + num100;
									float num108 = num50 * (float)vector3;
									float num109 = num101 + num102;
									float num110 = num51 * num96;
									float num111 = num52 * num96;
									float num112 = num103 - num104;
									float num113 = num51 * 0f;
									float num114 = num50 * 0f;
									float num115 = num106 + num105;
									float num116 = num51 * (float)vector3;
									float num117 = num52 * (float)vector3;
									float num118 = num108 + num107;
									float num119 = num110 + num109;
									float num120 = num112 - num113;
									float num121 = num115 - num116;
									float num122 = num118 - num111;
									float num123 = num119 - num114;
									float num124 = num120 - num117;
									turnOn = (Quaternion)num121;
									Vector3 vector16 = (Quaternion)0 * (Vector3)0;
									float num125 = dt + num50;
									float num126 = (float)obj17 + num51;
									float num127 = (float)obj20 + num52;
									pullTo = (Vector3)num125;
									bool flag24 = !(comeFor > 0f);
									object obj103 = obj17;
									Quaternion rotation4 = (Quaternion)0;
									float num128 = num57;
									float num129 = num53;
									float num130 = num56;
									float num131 = num52;
									float num132 = num55;
									if (!flag24)
									{
										float num133 = comeFor;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
										float num134 = num133 / 0f;
										float num135 = num134 + 1f;
										bool flag25 = num135 < 0f;
										double num136 = 0.0;
										if (!flag25)
										{
											bool flag26 = !((double)num135 > 1.0);
											num136 = num135;
											if (!flag26)
											{
												num136 = 1.0;
											}
										}
										float num137 = num56;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+240]");
										float num138 = num137 - 0f;
										float num139 = num57;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+244]");
										float num140 = num139 - 0f;
										object obj104 = this + 584;
										float num141 = num55 - (float)comeFrom;
										float num142 = num138 * (float)num136;
										float num143 = num141 * (float)num136;
										float num144 = num140 * (float)num136;
										obj103 = obj104;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+240]");
										num130 = 0f + num142;
										float num145 = (float)comeFrom + num143;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+244]");
										num128 = 0f + num144;
										Quaternion a = default;
										Quaternion b = default;
										Quaternion quaternion4 = Quaternion.Internal_Slerp(ref a, ref b, num135);
										float num146 = comeFor - (float)obj41;
										comeFor = num146;
										rotation4 = (Quaternion)0;
										num51 = num145;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+244]");
										num129 = 0f;
										num50 = num135;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18 (GillaPickaxe)+240]");
										num131 = 0f;
										num132 = num145;
									}
									Transform transform3 = base.transform;
									if ((object)transform3 != null)
									{
										transform3.SetPositionAndRotation((Vector3)0, rotation4);
										if (Live)
										{
											NetworkObject networkObject = ((SimulationBehaviour)this)._object;
											if ((object)((SimulationBehaviour)this)._object != null)
											{
												object obj105 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
												bool flag27 = obj105 == null;
												object obj106 = !flag27;
												if (obj106 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
													object obj108 = default;
													object obj107 = obj108 & 1;
													if (obj107 != null)
													{
														Depth = depth;
														if (into == (Into)3)
														{
															PullTo = (Vector3)0;
															NetworkBool pulling = true;
															Pulling = pulling;
															return true;
														}
													}
												}
											}
										}
										return true;
									}
								}
							}
							goto IL_0ed9;
						}
						yanked = true;
					}
					else
					{
						yanked = false;
					}
					ComesOut(yanked);
					return false;
				}
			}
		}
		goto IL_0ed9;
		IL_0ed9:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void Pin()
	{
		//IL_001e: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I8
		//IL_0192: Expected Obj, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01a9: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I
		//IL_00ab: Expected VT, but got I4
		//IL_02ed: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_00ea: Expected VT, but got I4
		//IL_01ea: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I4
		//IL_0283: Expected Obj, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_0262: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I4
		GillaItem gillaItem = item;
		bool flag = (byte)(~(gillaItem.Pinned__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			gillaItem.Pinned__BackingField = true;
			bool isKinematic = gillaItem.Body__BackingField.isKinematic;
			gillaItem = item;
			bool flag2 = !isKinematic;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj3 = 0;
				gillaItem.Body__BackingField.linearVelocity = (Vector3)0;
				GillaItem gillaItem2 = item;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v21+A0]");
				object obj5 = 0;
				gillaItem2.Body__BackingField.angularVelocity = (Vector3)0;
				gillaItem = item;
			}
		}
		gillaItem.Body__BackingField.isKinematic = true;
		GillaItem gillaItem3 = item;
		gillaItem3.Body__BackingField.interpolation = (RigidbodyInterpolation)0;
		GillaItem gillaItem4 = item;
		Collider[] array = gillaItem4.Colliders__BackingField;
		if (array.Length < 1)
		{
			return;
		}
		object obj6 = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		object obj8 = array + 32;
		object obj9 = 0;
		object obj10 = 0;
		RigidbodyInterpolation rigidbodyInterpolation = (RigidbodyInterpolation)0;
		while (true)
		{
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
			object obj11 = !flag3;
			if (obj11 != null)
			{
				break;
			}
			object obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X23_v4+v97 @ X21_v6*8]");
			bool flag5 = (UnityEngine.Object)0 != null;
			bool flag6 = !flag5;
			obj9 = 0;
			rigidbodyInterpolation = (RigidbodyInterpolation)0;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X23_v4+v97 @ X21_v6*8]");
				((Collider)0).enabled = false;
				obj9 = 0;
				rigidbodyInterpolation = (RigidbodyInterpolation)0;
			}
			obj6 = array.Length;
			obj10++;
			if ((nint)obj10 >= array.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private bool StillThere()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06d2: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_06a8: Expected I4, but got Obj
		//IL_009e: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I4
		//IL_0331: Expected Obj, but got I4
		//IL_02a4: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I4
		//IL_04c7: Invalid comparison between F4 and I4
		//IL_03c9: Expected Obj, but got I4
		//IL_03e3: Expected Obj, but got I4
		//IL_0790: Invalid comparison between F4 and I4
		//IL_0564: Expected Obj, but got I4
		//IL_05a9: Expected Obj, but got I4
		//IL_073d: Expected Obj, but got I4
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected Obj, but got Unknown
		//IL_060e: Expected Obj, but got I
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected Obj, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected Obj, but got Unknown
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected Obj, but got Unknown
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
		bool flag2 = on == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			goto IL_00c8;
		}
		GillaItem gillaItem = item;
		bool result;
		if ((object)item != null)
		{
			bool flag4 = (byte)(~(gillaItem.Gone__BackingField ? 1u : 0u)) != 0;
			object obj5 = !flag4;
			if (obj5 != null || ~(gillaItem.Swallowed__BackingField ? 1u : 0u) == 0)
			{
				goto IL_00c8;
			}
			if (into == (Into)3)
			{
				goto IL_06e0;
			}
			if (into == (Into)4)
			{
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v63+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return monster != null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCorpse gillaCorpse = GillaCorpse.Find(bodyId);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v14+E4]");
			bool flag7 = (nint)0 == 0;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = gillaCorpse != null;
			bool flag9 = !flag8;
			object obj13 = 0;
			int num = 0;
			if (!flag9)
			{
				if ((object)gillaCorpse == null)
				{
					goto IL_069a;
				}
				bool flag10 = gillaCorpse.Has(0);
				bool flag11 = !flag10;
				obj13 = 0;
				num = 0;
				if (!flag11)
				{
					double num2 = (double)stuckAt + -0.5;
					bool flag12 = !((double)gillaCorpse.MadeAt__BackingField < num2);
					obj13 = 0;
					num = 0;
					if (flag12)
					{
						if ((object)on != null)
						{
							string text = on.name;
							Transform transform = gillaCorpse.Bone(text);
							object obj14 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v20+E4]");
							bool flag13 = (nint)0 == 0;
							object obj15 = !flag13;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag14 = transform == null;
							bool flag15 = !flag14;
							object obj16 = !flag15;
							if (obj16 != null)
							{
								goto IL_00c8;
							}
							object obj17 = this + 384;
							on = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							into = (Into)3;
							if ((object)transform != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DD0]");
								object obj18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
								Rigidbody rigidbody = default;
								pulls = rigidbody;
								object obj19 = this + 504;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj20 = this + 472;
								ape = null;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj21 = this + 480;
								copy = null;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj22 = this + 488;
								dummy = null;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								goto IL_06e0;
							}
						}
						goto IL_069a;
					}
				}
			}
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v21+E4]");
			bool flag16 = (nint)0 == 0;
			object obj24 = !flag16;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (copy != null && section != (GoreSection)1)
			{
				if ((object)copy == null)
				{
					goto IL_069a;
				}
				object obj25 = section - 2;
				bool flag17 = obj25 == null;
				object obj26 = !flag17;
				object obj27 = ~obj26;
				ApePart apePart = ((obj27 != null) ? ((ApePart)1) : ((ApePart)2));
				ApePart id = ((section != 0) ? apePart : ((ApePart)0));
				bool flag18 = copy.IsTorn(id);
				bool flag19 = !flag18;
				object obj28 = !flag19;
				result = false;
				if (obj28 != null)
				{
					goto IL_0754;
				}
			}
			if ((object)on != null)
			{
				GameObject gameObject = on.gameObject;
				if ((object)gameObject != null)
				{
					if (gameObject.activeInHierarchy)
					{
						hiddenSince = -1f;
						goto IL_06e0;
					}
					if (hiddenSince < 0f)
					{
						float time = Time.time;
						hiddenSince = time;
					}
					float time2 = Time.time;
					float num3 = time2 - hiddenSince;
					float num4 = num3 - 1f;
					bool flag20 = num4 < 0f;
					result = flag20;
					goto IL_0754;
				}
			}
		}
		goto IL_069a;
		IL_069a:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0754:
		return result;
		IL_00c8:
		result = false;
		goto IL_0754;
		IL_06e0:
		result = true;
		goto IL_0754;
	}

	private float ThroughAt()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_00ee: Expected F4, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		object obj = into - 1;
		bool flag = (nint)obj < 1;
		object obj2 = !flag;
		object obj3 = obj - 1;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null && section != 0)
		{
			object obj6 = section - 1;
			bool flag3 = obj6 == null;
			object obj7 = 17281024 + 1832;
			Vector3 lossyScale = on.lossyScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X9_v3+v49 @ Z_v3 (System.Boolean)*4]");
			object obj8 = default;
			return 0f * (float)obj8;
		}
		return 2.139095E+09f;
	}

	private void Slides(float dt)
	{
		//IL_022a: Invalid comparison between F4 and I
		//IL_0052: Expected F4, but got I
		//IL_0052: Expected F4, but got I
		//IL_018a: Expected F4, but got I
		//IL_019a: Invalid comparison between F4 and I
		//IL_0089: Expected VT, but got I4
		//IL_00a5: Invalid comparison between F4 and I4
		//IL_00bb: Expected F8, but got I
		//IL_01be: Invalid comparison between F4 and I
		//IL_024e: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I4
		//IL_0149: Expected F4, but got I
		//IL_0149: Expected F4, but got I
		//IL_0149: Expected F4, but got VT
		//IL_0149: Expected VT, but got I4
		//IL_01ed: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		slidWas = depth;
		float num = slidWas / dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		if (num < 0f)
		{
			return;
		}
		float time = Time.time;
		if (!(time < slideAt))
		{
			float time2 = Time.time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B000]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA18]");
			float num3 = UnityEngine.Random.Range(num2, 0f);
			float num4 = time2 + num3;
			slideAt = num4;
			Vector3 vector = on.TransformPoint((Vector3)0);
			float num5 = num + num;
			bool flag = num5 < 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
			double num6 = 0.0;
			if (!flag)
			{
				bool flag2 = !((double)num5 > 1.0);
				num6 = 1.0;
				if (!flag2)
				{
					num6 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v14+E4]");
			bool flag3 = (nint)0 == 0;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AudioClip[] clips = slideSounds;
			Vector3 vector2 = onLocal;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
			Sfx.Play(clips, (Vector3)0, (float)vector2, num7, 0f);
		}
		if (!item.Mine)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		float strength = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		if (!(num < 0f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			bool flag4 = !(num > 0f);
			strength = num;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
				strength = 0f;
			}
		}
		float seconds = dt * 1.5f;
		Buzz(strength, seconds);
	}

	private void FixedUpdate()
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_0211: Expected I4, but got I8
		//IL_02a3: Expected VT, but got I4
		//IL_030d: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I
		//IL_02ee: Expected Obj, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0365: Expected Obj, but got VT
		//IL_0397: Expected VT, but got I4
		//IL_0397: Expected VT, but got I4
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_03fe: Expected Obj, but got I
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected Obj, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected Obj, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected Obj, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected Obj, but got Unknown
		//IL_0560: Expected VT, but got I4
		//IL_061b: Expected VT, but got I4
		//IL_061b: Expected VT, but got I4
		//IL_0461: Expected Obj, but got I
		if (into != (Into)3)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = pulls == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		bool isKinematic = pulls.isKinematic;
		bool flag4 = !isKinematic;
		object obj5 = !flag4;
		if (obj5 != null)
		{
			return;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = on == null;
		bool flag7 = !flag6;
		object obj8 = !flag7;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v15+E4]");
		bool flag8 = (nint)0 == 0;
		object obj10 = !flag8;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (item == null)
		{
			return;
		}
		bool mine = item.Mine;
		if (mine)
		{
			GillaItem gillaItem = item;
			if ((int)(gillaItem.Hand__BackingField & 0x80000000L) != 0)
			{
				return;
			}
		}
		else
		{
			if (!Live)
			{
				return;
			}
			NetworkBool pulling = Pulling;
			if (!pulling)
			{
				return;
			}
		}
		Vector3 vector = on.TransformPoint((Vector3)0);
		Vector3 vector2;
		object obj11;
		object obj12;
		if (mine)
		{
			vector2 = pullTo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+204]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+208]");
			obj12 = 0;
		}
		else
		{
			Vector3 vector3 = PullTo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
			obj12 = 0;
			vector2 = onLocal;
		}
		Transform transform = base.transform;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
		object obj14 = obj13 - 0;
		object obj15 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
		object obj16 = obj15 - 0;
		object obj17 = vector2 - onLocal;
		Quaternion rotation = transform.rotation;
		Vector3 vector4 = Along(end);
		Vector3 vector5 = (Quaternion)0 * (Vector3)end;
		object obj18 = obj17 * onLocal;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
		object obj19 = obj16 * 0;
		object obj20 = obj18 + obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
		object obj21 = obj14 * 0;
		object obj22 = obj21 + obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD90]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD90]");
		if ((nint)obj22 >= 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			bool flag9 = (nint)obj22 <= 0;
			obj23 = obj22;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				obj23 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
		object obj24 = 0 * obj22;
		object obj25 = onLocal * obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
		object obj26 = 0 * obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
		object obj27 = 0 * obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
		object obj28 = 0 * obj23;
		object obj29 = onLocal * obj23;
		object obj30 = obj14 - obj24;
		object obj31 = obj17 - obj25;
		object obj32 = obj16 - obj26;
		object obj33 = obj30 + obj27;
		object obj34 = obj31 + obj29;
		object obj35 = obj32 + obj28;
		object obj36 = obj33 * 1132593152;
		object obj37 = obj34 * 1132593152;
		object obj38 = obj35 * 1132593152;
		Vector3 pointVelocity = pulls.GetPointVelocity((Vector3)0);
		double num = (double)onLocal * 22.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
		double num2 = 0.0 * 22.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
		double num3 = 0.0 * 22.0;
		double num4 = (double)obj37 - num;
		double num5 = (double)obj38 - num2;
		double num6 = (double)obj36 - num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DA9990");
		float mass = pulls.mass;
		ForceMode mode = default;
		pulls.AddForceAtPosition((Vector3)0, (Vector3)0, mode);
		pulls.WakeUp();
	}

	private unsafe void Harms()
	{
		//IL_063e: Expected Obj, but got I4
		//IL_0689: Expected Obj, but got I
		//IL_06d0: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		//IL_00de: Expected VT, but got I4
		//IL_0386: Expected Obj, but got I
		//IL_03b0: Expected Obj, but got I4
		//IL_019d: Expected VT, but got I4
		//IL_00bd: Expected VT, but got I4
		//IL_00bd: Expected F4, but got VT
		//IL_00bd: Expected VT, but got I4
		//IL_00c5: Expected VT, but got I4
		//IL_05f4: Expected VT, but got Ref
		//IL_0406: Expected Obj, but got I4
		//IL_036c: Expected VT, but got I4
		//IL_017d: Expected F4, but got VT
		//IL_017d: Expected VT, but got I4
		//IL_0185: Expected VT, but got I4
		//IL_0449: Expected VT, but got I4
		//IL_0254: Expected Obj, but got I4
		//IL_047d: Expected VT, but got I4
		//IL_0246: Expected Obj, but got I4
		//IL_05b5: Expected VT, but got I4
		//IL_05b5: Expected F4, but got I
		//IL_05be: Expected VT, but got I4
		//IL_04b6: Expected Obj, but got I4
		//IL_04fb: Expected VT, but got I4
		//IL_0292: Expected Obj, but got I4
		//IL_051a: Expected VT, but got I4
		//IL_0532: Expected VT, but got I4
		//IL_0620: Expected F4, but got VT
		//IL_0620: Expected VT, but got I4
		//IL_0629: Expected VT, but got I4
		//IL_0582: Expected F4, but got VT
		//IL_0582: Expected VT, but got Ref
		//IL_058c: Expected VT, but got I4
		//IL_0344: Expected F4, but got VT
		//IL_0344: Expected VT, but got Ref
		//IL_0344: Expected VT, but got Obj
		//IL_0353: Expected VT, but got I4
		object obj = section - 1;
		bool flag = obj == null;
		Into obj2 = into;
		bool flag2 = ((section != 0) ? flag : true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		if (end == 0)
		{
		}
		harmed = true;
		bool flag3 = obj2 != (Into)1;
		IntPtr intPtr = default;
		UnityEngine.Object obj4 = (UnityEngine.Object)(nint)intPtr;
		if (!flag3)
		{
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v63+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 vector;
			if ((UnityEngine.Object)ape != (UnityEngine.Object)null)
			{
				object obj7 = default;
				ape.RPC_Stab((byte)section, (Vector3)flag2, (float)point, (byte)(&obj7), (RpcInfo)0);
				vector = (Vector3)flag2;
				goto IL_05c3;
			}
			obj2 = into;
			vector = (Vector3)0;
			obj4 = null;
		}
		if (obj2 == (Into)2)
		{
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v49+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 vector;
			if ((UnityEngine.Object)dummy != (UnityEngine.Object)null)
			{
				dummy.Stab(section, (Vector3)flag2, (float)point, 0);
				vector = (Vector3)flag2;
				goto IL_05c3;
			}
			obj2 = into;
			vector = (Vector3)0;
			obj4 = null;
		}
		RpcInfo info = default;
		if (obj2 == (Into)4)
		{
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v30+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 vector;
			if (monster != null)
			{
				if (section == 0)
				{
					object obj12 = 272;
				}
				else
				{
					object obj12 = 268;
				}
				if (Live)
				{
					MonsterBrain monsterBrain = monster;
					object obj13 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v38+E4]");
					bool flag7 = (nint)0 == 0;
					object obj14 = !flag7;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((UnityEngine.Object)monsterBrain.net != (UnityEngine.Object)null)
					{
						MonsterBrain monsterBrain2 = monster;
						if (monsterBrain2.net.Live)
						{
							ArgumentNullException ex = new ArgumentNullException();
							object obj15 = default;
							RPC_Monster((NetworkId)ex, (byte)section, (Vector3)(&obj15), (float)point, info);
							vector = (Vector3)section;
							goto IL_05c3;
						}
					}
				}
				MonsterBrain monsterBrain3 = monster;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v461 @ X8_v17]");
				monsterBrain3.Stabbed(0f, section, (Vector3)0);
				vector = (Vector3)0;
				goto IL_05c3;
			}
			obj2 = into;
			vector = (Vector3)0;
			obj4 = null;
		}
		if (obj2 == (Into)3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v5+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCorpse gillaCorpse = GillaCorpse.Find(targetId);
			object obj19 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v11+E4]");
			bool flag9 = (nint)0 == 0;
			object obj20 = !flag9;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag10 = gillaCorpse != null;
			bool flag11 = !flag10;
			Vector3 vector = (Vector3)0;
			if (!flag11)
			{
				bool woundable = gillaCorpse.Woundable;
				bool flag12 = !woundable;
				vector = (Vector3)0;
				if (!flag12)
				{
					object obj21 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X0_v14+E4]");
					bool flag13 = (nint)0 == 0;
					object obj22 = !flag13;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag14 = on != null;
					bool flag15 = !flag14;
					vector = (Vector3)0;
					if (!flag15)
					{
						Vector3 vector2 = on.TransformPoint((Vector3)0);
						Vector3 vector3 = gillaCorpse.OnBody(section, (Vector3)0);
						if (Live)
						{
							object obj23 = default;
							RPC_BodyStab(targetId, (byte)section, (Vector3)(&obj23), (float)onLocal, info);
							vector = (Vector3)section;
						}
						else
						{
							gillaCorpse.Stab(section, (Vector3)0, (float)onLocal);
							vector = (Vector3)0;
						}
					}
				}
			}
		}
		goto IL_05c3;
		IL_05c3:
		if (Live)
		{
			object obj24 = default;
			RPC_Bled((RpcInfo)(&obj24));
		}
		else
		{
			Bled();
		}
	}

	public unsafe void RPC_BodyStab(int id, byte s, Vector3 p, float radius, RpcInfo info = default(RpcInfo))
	{
		//IL_0d09: Expected VT, but got I4
		//IL_04bf: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_0509: Expected F4, but got Obj
		//IL_0535: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_059b: Expected VT, but got I4
		//IL_05ab: Expected VT, but got I4
		//IL_05b8: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_05db: Expected Obj, but got I4
		//IL_05e8: Expected Obj, but got I4
		//IL_05f5: Expected I4, but got Obj
		//IL_0610: Expected I4, but got I8
		//IL_010b: Expected F4, but got I
		//IL_0121: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_0642: Expected Obj, but got VT
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected Obj, but got Unknown
		//IL_066a: Expected Obj, but got I4
		//IL_0b55: Expected VT, but got I4
		//IL_075b: Expected Obj, but got I4
		//IL_0163: Expected VT, but got I4
		//IL_0791: Expected Obj, but got I
		//IL_07a3: Expected VT, but got I8
		//IL_07ba: Expected I, but got Obj
		//IL_0b86: Expected VT, but got I4
		//IL_07dd: Expected Obj, but got VT
		//IL_07f7: Expected Obj, but got I4
		//IL_0800: Expected F4, but got I4
		//IL_018b: Expected VT, but got F4
		//IL_01a5: Expected VT, but got F4
		//IL_0bd8: Expected F4, but got I4
		//IL_0be9: Expected F4, but got I4
		//IL_08c5: Expected F4, but got I4
		//IL_08ce: Expected Obj, but got I4
		//IL_08d6: Expected VT, but got Ref
		//IL_090e: Expected VT, but got F4
		//IL_092b: Expected Obj, but got Ref
		//IL_093c: Expected F4, but got I4
		//IL_0944: Expected I4, but got VT
		//IL_06b5: Expected I, but got Obj
		//IL_06c2: Expected VT, but got Obj
		//IL_06cb: Expected VT, but got I4
		//IL_0c40: Expected Ref, but got VT
		//IL_0db1: Invalid comparison between F4 and I4
		//IL_0dca: Expected Obj, but got I4
		//IL_0831: Expected Obj, but got I
		//IL_0839: Expected VT, but got Obj
		//IL_0205: Expected Obj, but got I4
		//IL_0858: Expected Obj, but got I
		//IL_086a: Expected I4, but got Obj
		//IL_086a: Expected VT, but got I4
		//IL_087a: Expected Obj, but got I
		//IL_0882: Expected VT, but got Obj
		//IL_06e2: Invalid comparison between VT and I4
		//IL_0230: Expected VT, but got I4
		//IL_0c75: Expected Obj, but got VT
		//IL_0c7d: Expected I4, but got Obj
		//IL_0c86: Expected F4, but got I4
		//IL_0952: Invalid comparison between F4 and I4
		//IL_099e: Expected Obj, but got I
		//IL_09c8: Expected Obj, but got I4
		//IL_06ff: Invalid comparison between VT and I4
		//IL_070d: Expected I, but got Obj
		//IL_071a: Expected VT, but got Obj
		//IL_0723: Expected VT, but got I4
		//IL_025a: Expected Obj, but got F4
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0d48: Expected Obj, but got I
		//IL_096f: Invalid comparison between F4 and I4
		//IL_0980: Expected Obj, but got I4
		//IL_0e12: Expected Obj, but got I4
		//IL_02ac: Expected VT, but got F4
		//IL_02b5: Expected VT, but got I4
		//IL_09fd: Expected Obj, but got I
		//IL_0a06: Expected VT, but got Obj
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1f: Expected I4, but got Unknown
		//IL_0a41: Expected Obj, but got I4
		//IL_0af7: Expected F4, but got VT
		//IL_0af2: Expected native int or pointer, but got VT
		//IL_0b1d: Expected VT, but got I4
		//IL_0a79: Expected I4, but got I8
		//IL_0a90: Expected VT, but got I4
		//IL_0a90: Expected VT, but got I4
		//IL_0ab3: Expected I, but got VT
		//IL_0abc: Expected VT, but got I4
		//IL_031b: Expected VT, but got F4
		//IL_0324: Expected VT, but got I4
		//IL_0361: Expected Obj, but got F4
		//IL_03cd: Invalid comparison between F4 and I4
		//IL_0410: Expected Obj, but got I4
		//IL_043b: Expected VT, but got F4
		//IL_046c: Invalid comparison between F4 and I
		//IL_0491: Invalid comparison between F4 and I
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		float num2 = default;
		float num = num2;
		object obj2 = default;
		object obj = obj2;
		float num4 = default;
		float num3 = num4;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		Vector3 vector = p;
		byte b = s;
		RpcChannel rpcChannel = (RpcChannel)0;
		int num5 = id;
		object obj3 = default;
		int bytePayloadSize4;
		NetworkRunner networkRunner = default;
		int num8 = default;
		UnityEngine.Object obj5;
		GillaCorpse gillaCorpse;
		int num9;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		PlayerRef playerRef2;
		PlayerRef playerRef3;
		RpcInvokeInfo rpcInvokeInfo2;
		bool flag4;
		int num7;
		PlayerRef playerRef;
		float num6;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj3 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			num6 = (float)obj3;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v16 (System.Single)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			flag4 = (object)networkRunner == null;
			num7 = bytePayloadSize4;
			num8 = bytePayloadSize2;
			num = num2;
			obj = obj2;
			num3 = num4;
			rpcBuilder = (Fusion.RpcBuilder)0;
			vector = p;
			playerRef = (PlayerRef)s;
			obj5 = null;
			gillaCorpse = (GillaCorpse)id;
			num9 = bytePayloadSize;
			if (!flag4)
			{
				object obj6 = bytePayloadSize2 + bytePayloadSize;
				object obj7 = bytePayloadSize3 + bytePayloadSize4;
				int payloadByteCount = (int)(obj6 + obj7);
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(3899275263u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				networkRunner = (NetworkRunner)(rpcInvokeInfo >> 32);
				object obj8 = networkRunner - 522;
				bool flag5 = (nint)obj8 < 2;
				object obj9 = !flag5;
				object obj10 = ~obj9;
				nint num10;
				if (obj10 == null && (nint)networkRunner != 518)
				{
					bool flag6 = (nint)networkRunner != 524;
					num10 = unchecked((nint)null);
					playerRef2 = invalid;
					playerRef3 = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag6)
					{
						goto IL_07cf;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag7 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						num10 = unchecked((nint)null);
						playerRef2 = invalid;
						playerRef3 = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag7)
						{
							goto IL_07cf;
						}
					}
				}
				object obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v71+E4]");
				bool flag8 = (nint)0 == 0;
				object obj12 = !flag8;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DB8]");
				object rpc = 0;
				playerRef3 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef3);
				num10 = unchecked((nint)null);
				playerRef2 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_07cf;
			}
			goto IL_0b8c;
		}
		goto IL_0005;
		IL_0b70:
		GillaCorpse gillaCorpse2;
		gillaCorpse2.Stab((GoreSection)s, (Vector3)0, radius);
		return;
		IL_0b8c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b9a;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v80+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		gillaCorpse2 = GillaCorpse.Find(num5);
		int value = ((int*)num9)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v43 (System.Int32)+E4]");
		bool flag10 = (nint)0 == 0;
		object obj16 = !flag10;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = gillaCorpse2 == null;
		bool flag12 = !flag11;
		object obj17 = !flag12;
		if (obj17 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X3 (UnityEngine.Vector3)+18]");
		num6 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X3 (UnityEngine.Vector3)+18]");
		object obj18 = (nint)0 & (nint)1;
		bool flag13 = obj18 == null;
		object obj19 = !flag13;
		if (obj19 == null)
		{
			flag4 = holder == null;
			playerRef = (PlayerRef)0;
			obj5 = null;
			gillaCorpse = gillaCorpse2;
			if (!flag4)
			{
				playerRef = (PlayerRef)p.y;
				if (!holder.Is(((SimulationBehaviour)this)._object, (PlayerRef)p.y))
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
				num9 = 0;
				int value2 = ((int*)num9)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v91 (System.Int32)+E4]");
				bool flag14 = (nint)0 == 0;
				object obj20 = !flag14;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!NetworkApe.SaneWound(s, (Vector3)0))
				{
					return;
				}
				object obj21 = ~num2;
				object obj22 = 0x7F800000 & obj21;
				if (obj22 == null)
				{
					return;
				}
				flag4 = (object)gillaCorpse2 == null;
				obj = obj2;
				num3 = num4;
				rpcBuilder = (Fusion.RpcBuilder)radius;
				vector = (Vector3)0;
				obj5 = null;
				gillaCorpse = gillaCorpse2;
				num6 = num2;
				if (!flag4)
				{
					Vector3 middleNow = gillaCorpse2.MiddleNow;
					Transform transform = base.transform;
					flag4 = (object)transform == null;
					obj = obj2;
					num3 = num4;
					rpcBuilder = (Fusion.RpcBuilder)radius;
					vector = (Vector3)0;
					obj5 = null;
					gillaCorpse = gillaCorpse2;
					num6 = num2;
					if (!flag4)
					{
						Vector3 position = transform.position;
						object obj23 = radius - radius;
						float num11 = num4 - num4;
						object obj24 = obj2 - obj2;
						object obj25 = obj23 * obj23;
						float num12 = num11 * num11;
						float num13 = (float)obj25 + num12;
						object obj26 = obj24 * obj24;
						float num14 = (float)obj26 + num13;
						if (num14 > 1.1156849E+09f)
						{
							return;
						}
						int value3 = ((int*)num9)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X0_v100 (System.Int32)+E4]");
						bool flag15 = (nint)0 == 0;
						object obj27 = !flag15;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!NetworkApe.InBudget((PlayerRef)p.y))
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B00C]");
						if (!(num2 < 0f))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
							if (!(num2 > 0f))
							{
							}
						}
						goto IL_0b70;
					}
				}
			}
		}
		else
		{
			flag4 = (object)gillaCorpse2 == null;
			num = num2;
			playerRef = (PlayerRef)0;
			obj5 = null;
			gillaCorpse = gillaCorpse2;
			if (!flag4)
			{
				goto IL_0b70;
			}
		}
		goto IL_0b8c;
		IL_0da8:
		float num15 = default;
		bool flag16 = num15 == 0f;
		flag4 = !flag16;
		gillaCorpse = (GillaCorpse)num5;
		Fusion.RpcBuilder rpcBuilder4 = default;
		RpcInfo rpcInfo;
		if (!flag4)
		{
			if (num6 != 10f)
			{
				bool flag17 = num6 == 0f;
				object obj28 = !flag17;
				if (obj28 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj29 = 0;
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X0_v6+E4]");
			bool flag18 = (nint)0 == 0;
			object obj31 = !flag18;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj30 = obj29;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X0_v6+A0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X8_v5+18]");
			num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X8_v5+18]");
			bool flag19 = (nint)0 == 0;
			MethodBase methodBase = (MethodBase)(object)networkRunner;
			if (!flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DB0]");
				object obj33 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj33);
				object obj34 = obj3;
				int num16 = num9 | networkRunner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v10+E4]");
				bool flag20 = (nint)0 == 0;
				object obj35 = !flag20;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num8 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num16, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v540 @ X27_v3 (System.Int32)+18] (should have been resolved before IL gen)");
				float num17 = default;
				num15 = num17;
				nint num10 = (nint)invalid2;
				rpcInfo = (RpcInfo)0;
				methodBase = methodFromHandle;
				object obj36 = default;
				obj = obj36;
			}
			bool flag21 = num9 == 0;
			object obj37 = !flag21;
			if (obj37 == null)
			{
				RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
				((Vector3*)(nint)p)->x = (float)rpcBuilder4;
				networkRunner = (NetworkRunner)(object)methodBase;
				num3 = num15;
				rpcBuilder = rpcBuilder4;
				vector = (Vector3)0;
				b = 0;
				rpcChannel = (RpcChannel)0;
				goto IL_0005;
			}
			return;
		}
		goto IL_0b9a;
		IL_07cf:
		object obj38 = rpcInvokeInfo >> 32;
		bool flag22 = obj38 == null;
		object obj39 = !flag22;
		float num18 = 0f;
		if (obj39 == null)
		{
			writer.Write(id, 4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj40 = 0;
			playerRef3 = (PlayerRef)obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj41 = 0;
			writer.Write((Vector3)12, (int)obj41);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BD0]");
			object obj42 = 0;
			rpcInvokeInfo2 = (RpcInvokeInfo)obj42;
			writer.Write(num2, 4);
			int num19 = rpcBuilder3.Send();
			num18 = num2;
		}
		rpcBuilder3.Dispose();
		num15 = 0f;
		object obj43 = 0;
		rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder3);
		rpcInfo = (RpcInfo)playerRef2;
		num7 = bytePayloadSize4;
		num8 = (int)(&writer);
		num = num2;
		obj = obj2;
		num3 = num4;
		rpcBuilder = (Fusion.RpcBuilder)num18;
		vector = (Vector3)playerRef3;
		playerRef = (PlayerRef)rpcInvokeInfo2;
		obj5 = null;
		ex = (NullReferenceException)(&rpcBuilder3);
		num5 = id;
		num6 = 10f;
		num9 = (int)rpcInvokeInfo;
		goto IL_0da8;
		IL_0b9a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex3 = default;
		OutOfMemoryException ex2 = ex3;
		object obj45 = default;
		OutOfMemoryException ex5 = default;
		while (true)
		{
			object obj44;
			if ((nint)obj5 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num15 = 1f;
				obj44 = obj43;
				num6 = 1f;
			}
			else
			{
				if ((nint)obj5 != 1)
				{
					goto IL_0d85;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj44 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj43 = obj45;
			}
			((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
			if (obj44 == null)
			{
				break;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			ex2 = ex4;
			obj5 = null;
			goto IL_0d85;
			IL_0d85:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			networkRunner = null;
			ex2 = ex5;
			num8 = 0;
			num9 = 0;
		}
		obj5 = null;
		ex = (NullReferenceException)rpcBuilder4;
		num5 = (int)gillaCorpse;
		num6 = 0f;
		goto IL_0da8;
	}

	public unsafe void RPC_Monster(NetworkId who, byte s, Vector3 p, float harm, RpcInfo info = default(RpcInfo))
	{
		//IL_0f55: Expected Obj, but got I4
		//IL_0f6e: Expected VT, but got I4
		//IL_0fbe: Expected F4, but got I
		//IL_0fd4: Expected Obj, but got I
		//IL_0fee: Expected Obj, but got I4
		//IL_0ff6: Expected VT, but got I4
		//IL_0ffe: Expected Obj, but got I4
		//IL_0739: Expected Obj, but got F4
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected I4, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_0774: Expected Obj, but got I
		//IL_079e: Expected Obj, but got I4
		//IL_005f: Expected F4, but got Obj
		//IL_009b: Expected Obj, but got I4
		//IL_07c9: Expected VT, but got I4
		//IL_06e2: Expected VT, but got F4
		//IL_0706: Expected VT, but got F4
		//IL_0722: Expected VT, but got I4
		//IL_00e9: Expected VT, but got I4
		//IL_0814: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected I4, but got Unknown
		//IL_017a: Expected I4, but got I8
		//IL_083f: Expected VT, but got F4
		//IL_01ac: Expected Obj, but got VT
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01d4: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I4
		//IL_0886: Invalid comparison between F4 and I4
		//IL_0895: Invalid comparison between F4 and I4
		//IL_08ac: Expected Obj, but got F4
		//IL_08bb: Expected Obj, but got F4
		//IL_08f0: Expected Obj, but got I4
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Expected Obj, but got Unknown
		//IL_0e43: Expected F4, but got I4
		//IL_0e54: Expected F4, but got I4
		//IL_02fb: Expected Obj, but got I
		//IL_030d: Expected VT, but got I8
		//IL_0324: Expected I, but got Obj
		//IL_092d: Expected VT, but got F4
		//IL_0eab: Expected Ref, but got VT
		//IL_0edb: Expected Obj, but got VT
		//IL_0347: Expected Obj, but got VT
		//IL_0361: Expected Obj, but got I4
		//IL_036a: Expected F4, but got I4
		//IL_105a: Invalid comparison between F4 and I4
		//IL_1069: Expected F4, but got I4
		//IL_091e: Expected VT, but got F4
		//IL_04d1: Invalid comparison between F4 and I4
		//IL_0450: Expected VT, but got F4
		//IL_0459: Expected F4, but got I4
		//IL_0462: Expected Obj, but got I4
		//IL_046a: Expected VT, but got Ref
		//IL_047a: Expected I4, but got VT
		//IL_04a3: Expected Obj, but got Ref
		//IL_04bb: Expected I4, but got VT
		//IL_021f: Expected I, but got Obj
		//IL_0224: Expected VT, but got Obj
		//IL_022d: Expected VT, but got I4
		//IL_10a4: Expected F4, but got I
		//IL_10c6: Expected Obj, but got I4
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected VT, but got Unknown
		//IL_03ad: Expected Obj, but got I
		//IL_03b5: Expected VT, but got Obj
		//IL_09a6: Expected VT, but got I4
		//IL_093a: Invalid comparison between VT and F4
		//IL_0518: Expected Obj, but got I
		//IL_0542: Expected Obj, but got I4
		//IL_03d4: Expected Obj, but got I
		//IL_03e6: Expected I4, but got Obj
		//IL_03e6: Expected VT, but got I4
		//IL_03f6: Expected Obj, but got I
		//IL_03fe: Expected VT, but got Obj
		//IL_024c: Invalid comparison between VT and I4
		//IL_10f1: Expected F4, but got I
		//IL_1113: Expected Obj, but got I4
		//IL_101c: Expected Obj, but got I
		//IL_0a64: Expected Obj, but got I4
		//IL_0a85: Expected VT, but got I4
		//IL_0961: Expected F4, but got VT
		//IL_11cb: Expected Obj, but got I4
		//IL_0269: Invalid comparison between VT and I4
		//IL_0277: Expected I, but got Obj
		//IL_027c: Expected VT, but got Obj
		//IL_0285: Expected VT, but got I4
		//IL_113e: Expected F4, but got I
		//IL_1160: Expected Obj, but got I4
		//IL_0577: Expected Obj, but got I
		//IL_0580: Expected VT, but got Obj
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected I4, but got Unknown
		//IL_05bb: Expected Obj, but got I4
		//IL_0b2c: Expected Obj, but got VT
		//IL_0b4a: Expected Obj, but got I4
		//IL_0ad6: Expected VT, but got I4
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected VT, but got Unknown
		//IL_0a46: Expected I4, but got Obj
		//IL_0671: Expected F4, but got VT
		//IL_066c: Expected native int or pointer, but got VT
		//IL_068f: Expected VT, but got I4
		//IL_05f3: Expected I4, but got I8
		//IL_060a: Expected VT, but got I4
		//IL_060a: Expected VT, but got I4
		//IL_0635: Expected I, but got VT
		//IL_063e: Expected VT, but got I4
		//IL_0b61: Invalid comparison between VT and I4
		//IL_0af4: Expected Obj, but got I
		//IL_0bc2: Expected Obj, but got I4
		//IL_0be6: Expected Obj, but got I
		//IL_0c00: Expected Obj, but got I4
		//IL_0df1: Expected VT, but got I4
		//IL_0df1: Expected Obj, but got VT
		//IL_0c1b: Expected VT, but got F4
		//IL_0c24: Expected Obj, but got VT
		//IL_0c38: Expected Obj, but got I
		//IL_0c50: Expected F4, but got I
		//IL_0c72: Expected Obj, but got I4
		//IL_0ca5: Expected F4, but got VT
		//IL_0ca5: Expected VT, but got I4
		//IL_0cc3: Expected Obj, but got I4
		//IL_0cda: Expected Obj, but got VT
		//IL_0d2f: Expected F4, but got VT
		//IL_0dc7: Invalid comparison between F4 and I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj3 = default;
		object obj2 = obj3;
		float num2 = default;
		float num = num2;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		RpcHostMode rpcHostMode = (RpcHostMode)s;
		RpcChannel rpcChannel = (RpcChannel)0;
		NetworkId networkId = who;
		Vector3 vector2 = default;
		Vector3 vector = vector2;
		int num3 = 109891584;
		double num5 = default;
		float num4 = (float)num5;
		object obj4 = default;
		int bytePayloadSize4;
		NetworkRunner networkRunner;
		int num9 = default;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		MethodBase methodBase = default;
		PlayerRef playerRef;
		RpcInvokeInfo rpcInvokeInfo2;
		PlayerRef playerRef2;
		byte b;
		int num7;
		bool flag4;
		float num6;
		int num8;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj4 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			num6 = (float)obj4;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v24 (System.Single)+E4]");
			num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v24 (System.Single)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			flag4 = (object)networkRunner == null;
			obj2 = obj3;
			num = num2;
			rpcBuilder = (Fusion.RpcBuilder)0;
			b = s;
			num8 = bytePayloadSize4;
			num9 = bytePayloadSize2;
			rpcChannel = (RpcChannel)0;
			networkId = who;
			vector = vector2;
			num3 = bytePayloadSize;
			num4 = (float)num5;
			if (!flag4)
			{
				num7 = bytePayloadSize2 + bytePayloadSize;
				object obj6 = bytePayloadSize3 + bytePayloadSize4;
				int payloadByteCount = num7 + obj6;
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(3201255347u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				methodBase = (MethodBase)(rpcInvokeInfo >> 32);
				object obj7 = methodBase - 522;
				bool flag5 = (nint)obj7 < 2;
				object obj8 = !flag5;
				object obj9 = ~obj8;
				nint num10;
				if (obj9 == null && (nint)methodBase != 518)
				{
					bool flag6 = (nint)methodBase != 524;
					num10 = unchecked((nint)null);
					playerRef = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef2 = invalid;
					if (flag6)
					{
						goto IL_0339;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag7 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						num10 = unchecked((nint)null);
						playerRef = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef2 = invalid;
						if (flag7)
						{
							goto IL_0339;
						}
					}
				}
				object obj10 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X0_v120+E4]");
				bool flag8 = (nint)0 == 0;
				object obj11 = !flag8;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DA8]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				num10 = unchecked((nint)null);
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef2 = none;
				goto IL_0339;
			}
			goto IL_0df7;
		}
		goto IL_0fae;
		IL_0339:
		object obj12 = rpcInvokeInfo >> 32;
		bool flag9 = obj12 == null;
		object obj13 = !flag9;
		float num11 = 0f;
		if (obj13 == null)
		{
			NetworkId value = (NetworkId)(who & 0xFFFFFFFFL);
			writer.Write(value, 4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj14 = 0;
			playerRef = (PlayerRef)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj15 = 0;
			writer.Write((Vector3)12, (int)obj15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BD0]");
			object obj16 = 0;
			rpcInvokeInfo2 = (RpcInvokeInfo)obj16;
			writer.Write((float)num5, 4);
			int num12 = rpcBuilder3.Send();
			num11 = (float)num5;
		}
		rpcBuilder3.Dispose();
		obj2 = obj3;
		num = num2;
		rpcBuilder = (Fusion.RpcBuilder)num11;
		float num13 = 0f;
		object obj17 = 0;
		Fusion.RpcBuilder rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder3);
		Vector3 vector3 = (Vector3)playerRef;
		b = (byte)(int)rpcInvokeInfo2;
		RpcInfo rpcInfo = (RpcInfo)playerRef2;
		num8 = bytePayloadSize4;
		num9 = (int)(&writer);
		rpcChannel = (RpcChannel)0;
		NullReferenceException ex = (NullReferenceException)(&rpcBuilder3);
		networkId = who;
		vector = vector2;
		num3 = (int)rpcInvokeInfo;
		num4 = (float)num5;
		goto IL_04c8;
		IL_0df7:
		ex = new NullReferenceException();
		goto IL_0e05;
		IL_0fae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X21_v9 (UnityEngine.Vector3)+18]");
		num6 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X21_v9 (UnityEngine.Vector3)+18]");
		object obj18 = (nint)0 & (nint)1;
		bool flag10 = obj18 == null;
		object obj19 = !flag10;
		PlayerRef playerRef3 = (PlayerRef)rpcHostMode;
		NetworkObject networkObject = (NetworkObject)rpcChannel;
		if (obj19 == null)
		{
			flag4 = holder == null;
			b = (byte)rpcHostMode;
			networkRunner = (NetworkRunner)(object)methodBase;
			if (flag4)
			{
				goto IL_0df7;
			}
			playerRef3 = (PlayerRef)vector.y;
			networkObject = ((SimulationBehaviour)this)._object;
			bool flag11 = holder.Is(((SimulationBehaviour)this)._object, (PlayerRef)vector.y);
			bool flag12 = !flag11;
			vector2 = (Vector3)0;
			if (flag12)
			{
				return;
			}
		}
		object obj20 = ~num4;
		if ((0x7F800000 & obj20) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj21 = 0;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v6+E4]");
		bool flag13 = (nint)0 == 0;
		object obj23 = !flag13;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.SaneWound(s, (Vector3)0))
		{
			return;
		}
		object obj24 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v10+E4]");
		bool flag14 = (nint)0 == 0;
		object obj25 = !flag14;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.InBudget((PlayerRef)vector.y))
		{
			return;
		}
		num = monsterHeadHarm;
		float num14 = monsterHarm - monsterHeadHarm;
		bool flag15 = num14 < 0f;
		bool flag16 = num14 == 0f;
		object obj26 = monsterHarm ^ monsterHeadHarm;
		object obj27 = monsterHarm ^ num14;
		object obj28 = obj26 & obj27;
		bool flag17 = (nint)obj28 < 0;
		bool flag18 = flag15 == flag17;
		object obj29 = !flag16;
		object obj30 = flag18 & obj29;
		object obj31 = ~obj30;
		rpcBuilder = ((obj31 != null) ? ((Fusion.RpcBuilder)monsterHeadHarm) : ((Fusion.RpcBuilder)monsterHarm));
		bool flag19 = num4 < 0f;
		float damage = 0f;
		if (!flag19)
		{
			bool flag20 = rpcBuilder >= (object)num4;
			damage = num4;
			if (!flag20)
			{
				damage = (float)rpcBuilder;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		num9 = 0;
		int value2 = ((int*)num9)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X0_v14 (System.Int32)+E4]");
		num6 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X0_v14 (System.Int32)+E4]");
		bool flag21 = (nint)0 == 0;
		object obj32 = !flag21;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag22 = (UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null;
		bool flag23 = !flag22;
		byte b2 = 0;
		NetworkId networkId2 = (NetworkId)0;
		num3 = 0;
		if (!flag23)
		{
			flag4 = (object)((SimulationBehaviour)this)._runner == null;
			obj2 = obj3;
			b = 0;
			num7 = 2139095040;
			networkRunner = (NetworkRunner)(object)methodBase;
			rpcChannel = (RpcChannel)0;
			num3 = 0;
			if (flag4)
			{
				goto IL_0df7;
			}
			networkId2 = (NetworkId)(networkId & 0xFFFFFFFFL);
			NetworkObject networkObject2 = ((SimulationBehaviour)this)._runner.FindObject(networkId2);
			b2 = 0;
			num3 = (int)networkObject2;
		}
		int value3 = ((int*)num9)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v19 (System.Int32)+E4]");
		num6 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v19 (System.Int32)+E4]");
		bool flag24 = (nint)0 == 0;
		object obj33 = !flag24;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag25 = (UnityEngine.Object)num3 != null;
		bool flag26 = !flag25;
		UnityEngine.Object obj34 = null;
		networkId = (NetworkId)0;
		if (!flag26)
		{
			flag4 = num3 == 0;
			obj2 = obj3;
			b = 0;
			num7 = 2139095040;
			networkRunner = (NetworkRunner)(object)methodBase;
			rpcChannel = (RpcChannel)0;
			networkId = (NetworkId)0;
			if (flag4)
			{
				goto IL_0df7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF0]");
			object obj35 = 0;
			obj34 = (UnityEngine.Object)obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			NetworkId networkId3 = default;
			networkId = networkId3;
		}
		int value4 = ((int*)num9)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v24 (System.Int32)+E4]");
		num6 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v24 (System.Int32)+E4]");
		bool flag27 = (nint)0 == 0;
		object obj36 = !flag27;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag28 = (UnityEngine.Object)networkId == null;
		bool flag29 = !flag28;
		object obj37 = !flag29;
		if (obj37 != null)
		{
			return;
		}
		flag4 = networkId == (NetworkId)(object)0;
		obj2 = obj3;
		b = 0;
		num7 = 2139095040;
		networkRunner = (NetworkRunner)(object)methodBase;
		rpcChannel = (RpcChannel)0;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X22_v10 (Fusion.NetworkId)+121]");
			bool flag30 = (nint)0 == 0;
			object obj38 = !flag30;
			if (obj38 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X21_v9 (UnityEngine.Vector3)+18]");
			object obj39 = (nint)0 & (nint)1;
			bool flag31 = obj39 == null;
			object obj40 = !flag31;
			if (obj40 == null)
			{
				vector = (Vector3)vector.y;
				Vector3 middle = ((MonsterBrain)networkId).Middle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
				object obj41 = 0;
				object obj42 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X0_v32+E4]");
				num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X0_v32+E4]");
				bool flag32 = (nint)0 == 0;
				object obj43 = !flag32;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag33 = GillaNetGuard.Near((PlayerRef)vector, (Vector3)0, (float)rpcBuilder, num);
				bool flag34 = !flag33;
				object obj44 = !flag34;
				if (obj44 == null)
				{
					Vector3 middle2 = ((MonsterBrain)networkId).Middle;
					Transform transform = base.transform;
					flag4 = (object)transform == null;
					obj2 = obj3;
					b = 0;
					num7 = 2139095040;
					networkRunner = (NetworkRunner)(object)methodBase;
					rpcChannel = (RpcChannel)0;
					num4 = (float)rpcBuilder;
					if (flag4)
					{
						goto IL_0df7;
					}
					Vector3 position = transform.position;
					float num15 = (float)rpcBuilder - (float)rpcBuilder;
					float num16 = num - num;
					object obj45 = obj3 - obj3;
					float num17 = num15 * num15;
					float num18 = num16 * num16;
					float num19 = num17 + num18;
					object obj46 = obj45 * obj45;
					float num20 = (float)obj46 + num19;
					if (num20 > 1.1204035E+09f)
					{
						return;
					}
				}
			}
			((MonsterBrain)networkId).Stabbed(damage, (GoreSection)s, (Vector3)0);
			return;
		}
		goto IL_0df7;
		IL_0e05:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex3 = default;
		OutOfMemoryException ex2 = ex3;
		object obj48 = default;
		OutOfMemoryException ex5 = default;
		while (true)
		{
			object obj47;
			if (rpcChannel == (RpcChannel)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num13 = 1f;
				obj47 = obj17;
				num6 = 1f;
			}
			else
			{
				if (rpcChannel != (RpcChannel)1)
				{
					goto IL_116e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj47 = obj48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj17 = obj48;
			}
			((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
			flag4 = obj47 == null;
			vector3 = vector2;
			methodBase = (MethodBase)(object)networkRunner;
			rpcChannel = (RpcChannel)0;
			ex = (NullReferenceException)rpcBuilder4;
			if (flag4)
			{
				break;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			ex2 = ex4;
			rpcChannel = (RpcChannel)0;
			goto IL_116e;
			IL_116e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			networkRunner = null;
			ex2 = ex5;
			num9 = 0;
			num3 = 0;
		}
		goto IL_04c8;
		IL_04c8:
		bool flag35 = num13 == 0f;
		flag4 = !flag35;
		vector2 = vector3;
		networkRunner = (NetworkRunner)(object)methodBase;
		num6 = num13;
		if (flag4)
		{
			goto IL_0e05;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj49 = 0;
		object obj50 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X0_v77+E4]");
		bool flag36 = (nint)0 == 0;
		object obj51 = !flag36;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj50 = obj49;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X0_v77+A0]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v31+18]");
		num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v31+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DA0]");
			object obj53 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj53);
			object obj54 = obj4;
			int num21 = num3 | methodBase;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v36+E4]");
			bool flag37 = (nint)0 == 0;
			object obj55 = !flag37;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid2 = PlayerRef.Invalid;
			RpcHostMode hostMode = (RpcHostMode)(num9 & 0xFFFFFFFFL);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num21, hostMode, (PlayerRef)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v537 @ X27_v6 (System.Int32)+18] (should have been resolved before IL gen)");
			object obj56 = default;
			obj2 = obj56;
			float num22 = default;
			num13 = num22;
			nint num10 = (nint)invalid2;
			rpcInfo = (RpcInfo)0;
			methodBase = methodFromHandle;
		}
		bool flag38 = num3 == 0;
		object obj57 = !flag38;
		if (obj57 == null)
		{
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			((Vector3*)(nint)vector)->x = (float)rpcBuilder4;
			num = num13;
			rpcBuilder = rpcBuilder4;
			vector2 = (Vector3)0;
			rpcHostMode = (RpcHostMode)0;
			rpcChannel = (RpcChannel)0;
			goto IL_0fae;
		}
	}

	public unsafe void RPC_Bled(RpcInfo info = default(RpcInfo))
	{
		//IL_007f: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I4
		//IL_0112: Expected I4, but got I8
		//IL_0042: Expected VT, but got Ref
		//IL_0144: Expected Obj, but got VT
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I4
		//IL_0265: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I
		//IL_02ad: Expected VT, but got I8
		//IL_02c8: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got VT
		//IL_0305: Expected Obj, but got I4
		//IL_0340: Expected Obj, but got I4
		//IL_0348: Expected VT, but got Ref
		//IL_0359: Expected Obj, but got Ref
		//IL_0362: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got VT
		//IL_01bb: Expected Obj, but got I4
		//IL_01c0: Expected VT, but got Obj
		//IL_01d1: Expected VT, but got I4
		//IL_05cd: Expected Ref, but got VT
		//IL_05e7: Expected Obj, but got I4
		//IL_0703: Expected Obj, but got I4
		//IL_01e8: Invalid comparison between VT and I4
		//IL_0606: Expected Obj, but got VT
		//IL_060f: Expected Obj, but got I4
		//IL_03c4: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got I4
		//IL_0205: Invalid comparison between VT and I4
		//IL_0217: Expected Obj, but got I4
		//IL_021c: Expected VT, but got Obj
		//IL_022d: Expected VT, but got I4
		//IL_0671: Expected Obj, but got I
		//IL_0681: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I4
		//IL_04f8: Expected native int or pointer, but got VT
		//IL_0505: Expected native int or pointer, but got VT
		//IL_0513: Expected VT, but got I4
		//IL_0423: Expected Obj, but got I
		//IL_042c: Expected VT, but got Obj
		//IL_0445: Expected VT, but got Obj
		//IL_0467: Expected Obj, but got I4
		//IL_049f: Expected I4, but got I8
		//IL_04b6: Expected VT, but got I4
		object obj;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer = default;
		object obj4 = default;
		NullReferenceException ex;
		RpcChannel rpcChannel;
		if (!NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj = 0;
			networkRunner = ((SimulationBehaviour)this)._runner;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(2272601190u, 0, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				obj4 = rpcInvokeInfo >> 32;
				object obj5 = obj4 - 522;
				bool flag2 = (nint)obj5 < 2;
				object obj6 = !flag2;
				object obj7 = ~obj6;
				PlayerRef playerRef;
				object obj8;
				PlayerRef playerRef2;
				RpcInvokeInfo rpcInvokeInfo2;
				if (obj7 == null && (nint)obj4 != 518)
				{
					bool flag3 = (nint)obj4 != 524;
					obj8 = 0;
					playerRef = (PlayerRef)this;
					playerRef2 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag3)
					{
						goto IL_02dd;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag4 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						obj8 = 0;
						playerRef = (PlayerRef)this;
						playerRef2 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag4)
						{
							goto IL_02dd;
						}
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v58+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DC8]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				obj8 = 0;
				playerRef2 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_02dd;
			}
			ex = new NullReferenceException();
			rpcChannel = (RpcChannel)0;
			goto IL_0530;
		}
		goto IL_0005;
		IL_06e9:
		nint num = default;
		bool flag6 = num == 0;
		object obj11 = !flag6;
		object obj12;
		if (obj11 == null)
		{
			if ((nint)obj12 != 7)
			{
				bool flag7 = obj12 == null;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v11+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v11+A0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v7+18]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DC0]");
				object obj19 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj19);
				object obj20 = obj;
				RpcInvokeInfo invokeInfo = (RpcInvokeInfo)((object)networkRunner | obj4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v12+E4]");
				bool flag9 = (nint)0 == 0;
				object obj21 = !flag9;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, invokeInfo, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ X26_v3+18] (should have been resolved before IL gen)");
				IntPtr intPtr = default;
				num = intPtr;
			}
			if ((object)networkRunner != null)
			{
				return;
			}
			RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			Tick tick = default;
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, tick);
			((RpcInfo*)(nint)info)->_validationResult = num;
			PlayerRef playerRef = (PlayerRef)0;
			goto IL_0005;
		}
		goto IL_0530;
		IL_06c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_02dd:
		object obj22 = rpcInvokeInfo >> 32;
		bool flag10 = obj22 == null;
		object obj23 = !flag10;
		if (obj23 == null)
		{
			int num2 = rpcBuilder2.Send();
		}
		rpcBuilder2.Dispose();
		num = 0;
		object obj24 = 0;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		rpcChannel = (RpcChannel)0;
		ex = (NullReferenceException)(&rpcBuilder2);
		obj12 = 7;
		networkRunner = (NetworkRunner)rpcInvokeInfo;
		goto IL_06e9;
		IL_0530:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj25;
		OutOfMemoryException ex2;
		if (rpcChannel == (RpcChannel)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj25 = obj24;
			num = 1;
		}
		else
		{
			bool flag11 = rpcChannel != (RpcChannel)1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag11)
			{
				goto IL_06c6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj26 = default;
			obj25 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj24 = obj26;
		}
		((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
		bool flag12 = obj25 == null;
		object obj27 = !flag12;
		if (obj27 == null)
		{
			rpcChannel = (RpcChannel)0;
			ex = (NullReferenceException)rpcBuilder3;
			obj12 = 0;
			goto IL_06e9;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		rpcChannel = (RpcChannel)0;
		goto IL_06c6;
		IL_0005:
		bool flag13 = !info.IsInvokeLocal;
		object obj28 = !flag13;
		object obj29 = default;
		if (obj28 != null || FromHolder((RpcInfo)(&obj29), scratch: false))
		{
			Bled();
		}
	}

	private void Bled()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_051b: Expected Obj, but got I4
		//IL_0072: Expected VT, but got I4
		//IL_00e5: Expected VT, but got I4
		//IL_00e5: Expected VT, but got I4
		//IL_00ef: Unsupported input type for neg.
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I
		//IL_0123: Expected F4, but got VT
		//IL_0133: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_0169: Expected F4, but got VT
		//IL_0169: Expected VT, but got I4
		//IL_0169: Expected VT, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_0442: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got I
		//IL_0472: Expected I, but got Obj
		//IL_0482: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got I4
		//IL_02dd: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I
		//IL_0267: Expected F4, but got VT
		//IL_0267: Expected VT, but got I4
		//IL_0274: Expected F4, but got VT
		//IL_0284: Expected Obj, but got I
		//IL_0294: Expected Obj, but got I
		//IL_035d: Expected Obj, but got I4
		//IL_03be: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I
		//IL_03db: Expected F4, but got VT
		//IL_03eb: Expected Obj, but got I
		//IL_0402: Expected F4, but got VT
		//IL_0402: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DD0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaPlaces._003C_003Ec__DisplayClass190_0 obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		harmed = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (on == null)
		{
			return;
		}
		Vector3 vector = on.TransformPoint((Vector3)0);
		obj3.hole = onLocal;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
		_ = 0;
		Transform transform = base.transform;
		Quaternion rotation = transform.rotation;
		Vector3 vector2 = Along(end);
		Vector3 vector3 = (Quaternion)0 * (Vector3)end;
		object obj6 = 0 - onLocal;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
		object obj7 = -0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
		object obj8 = -0;
		float num = (float)obj3.hole;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (GillaPlaces+<>c__DisplayClass190_0)+14]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (GillaPlaces+<>c__DisplayClass190_0)+18]");
		object obj10 = 0;
		int beats = default;
		bool first = default;
		BloodAt((Vector3)12, (Vector3)4, (float)obj3.hole, 1, beats, first);
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (copy != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v45+E4]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			obj6 = 0;
			GillaSplatter.Stain(copy, (Vector3)0, (float)obj3.hole, (GillaStains.Stuff)0);
			num = (float)obj3.hole;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (GillaPlaces+<>c__DisplayClass190_0)+14]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (GillaPlaces+<>c__DisplayClass190_0)+18]");
			obj10 = 0;
			GillaStains.Stuff stuff = (GillaStains.Stuff)0;
		}
		else
		{
			bool flag4 = into != (Into)3;
			GillaStains.Stuff stuff = (GillaStains.Stuff)0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v34+E4]");
				bool flag5 = (nint)0 == 0;
				object obj18 = !flag5;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaCorpse gillaCorpse = GillaCorpse.Find(targetId);
				object obj19 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v18+E4]");
				bool flag6 = (nint)0 == 0;
				object obj20 = !flag6;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = gillaCorpse != null;
				bool flag8 = !flag7;
				stuff = (GillaStains.Stuff)0;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (GillaPlaces+<>c__DisplayClass190_0)+14]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (GillaPlaces+<>c__DisplayClass190_0)+18]");
					obj10 = 0;
					num = (float)obj3.hole;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
					obj6 = 0;
					gillaCorpse.Stain((Vector3)0, (float)obj3.hole);
					stuff = (GillaStains.Stuff)0;
				}
			}
		}
		object obj21 = obj3 + 32;
		obj21 = copy;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DD8]");
		object obj23 = 0;
		Action action = default;
		action._002Ector(obj3, (IntPtr)obj23);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj24 = 0;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v30+E4]");
		bool flag9 = (nint)0 == 0;
		object obj26 = !flag9;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds.Later(action);
	}

	private void BloodAt(Vector3 at, Vector3 way, float seconds, int burst, int beats, bool first)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0575: Expected Obj, but got I
		//IL_0597: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I4
		//IL_05cf: Expected Obj, but got I4
		//IL_06e1: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I4
		//IL_0290: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I4
		//IL_02f0: Expected VT, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I4
		//IL_0390: Expected Obj, but got I4
		//IL_0399: Expected VT, but got I4
		//IL_04f3: Expected Obj, but got I
		//IL_051d: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_055c: Expected I4, but got VT
		//IL_055c: Expected Obj, but got VT
		//IL_055c: Expected VT, but got Obj
		//IL_05ed: Expected Obj, but got I
		//IL_0605: Expected Obj, but got I
		//IL_071a: Expected Obj, but got I
		//IL_0737: Expected Obj, but got I
		//IL_0754: Expected Obj, but got I
		//IL_0638: Expected Obj, but got I
		//IL_066f: Expected Obj, but got I4
		//IL_041e: Invalid comparison between F4 and I
		//IL_047f: Expected Obj, but got I
		//IL_0487: Expected F4, but got Obj
		//IL_0497: Expected F4, but got I
		//IL_04a7: Expected F4, but got I
		//IL_068d: Expected Obj, but got I
		//IL_06b7: Expected Obj, but got I4
		//IL_04c9: Expected VT, but got Obj
		//IL_04de: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Material spray = Spray;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = spray == null;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (on == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj10;
		}
		bool flag8 = section == 0;
		object obj15 = !flag8;
		object obj16 = 0;
		Transform transform = null;
		if (obj15 == null)
		{
			object obj17 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v17+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v44+E4]");
			bool flag9 = (nint)0 == 0;
			object obj19 = !flag9;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag10 = (UnityEngine.Object)obj18 != null;
			bool flag11 = !flag10;
			obj16 = 0;
			transform = null;
			if (!flag11)
			{
				Transform transform2 = ((Component)obj18).transform;
				bool flag12 = on.IsChildOf(transform2);
				bool flag13 = !flag12;
				object obj20 = !flag13;
				obj16 = 0;
				transform = transform2;
				if (obj20 != null)
				{
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DE0]");
		object obj22 = 0;
		GameObject gameObject = default;
		gameObject._002Ector((string)obj22);
		Transform transform3 = gameObject.transform;
		transform3.SetParent(on, worldPositionStays: true);
		transform3.position = (Vector3)0;
		GameObject obj23 = transform3.gameObject;
		object obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v18+E4]");
		bool flag14 = (nint)0 == 0;
		object obj25 = !flag14;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj26 = default;
		float t = (float)obj26 + 3f;
		UnityEngine.Object.Destroy(obj23, t);
		int num = burst & 1;
		bool flag15 = num == 0;
		Material material = (Material)1;
		Vector3 vector = (Vector3)0;
		float num6 = default;
		float num8 = default;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj27 = 0;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v26+A0]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v27+18]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			object obj30 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v27+1C]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			object obj31 = num3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v27+20]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			object obj32 = num4 * 0;
			float num5 = num6 + (float)obj30;
			float num7 = num8 + (float)obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj33 = 0;
			object obj35 = default;
			object obj34 = obj35 + obj32;
			object obj36 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v38+E4]");
			bool flag16 = (nint)0 == 0;
			object obj37 = !flag16;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num9 = num5 * num5;
			float num10 = num7 * num7;
			float num11 = num9 + num10;
			object obj38 = obj34 * obj34;
			float num12 = num11 + (float)obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num13;
			if (num12 > 0f)
			{
				num13 = num5 / num12;
				float num14 = num7 / num12;
				float num15 = (float)obj34 / num12;
			}
			else
			{
				object obj39 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v39+A0]");
				object obj40 = 0;
				num13 = (float)obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v40+4]");
				float num14 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v40+8]");
				float num15 = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
			object obj41 = 0;
			object obj42 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v40+E4]");
			bool flag17 = (nint)0 == 0;
			object obj43 = !flag17;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Blood.Punch(transform3, (Vector3)spray, null);
			t = num13;
			material = null;
			vector = (Vector3)spray;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj44 = 0;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v31+E4]");
		bool flag18 = (nint)0 == 0;
		object obj46 = !flag18;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Blood.Spray(transform3, (Vector3)spray, (Material)at, num6, (int)way, 0, num8);
	}

	private unsafe void GoesThrough()
	{
		//IL_0010: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I4
		//IL_0476: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_04d6: Expected VT, but got I4
		//IL_018a: Expected Obj, but got I4
		//IL_01c3: Expected VT, but got I4
		//IL_01db: Expected VT, but got I4
		//IL_04fa: Expected VT, but got I4
		//IL_0504: Expected Obj, but got I4
		//IL_0534: Expected VT, but got Obj
		//IL_023f: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I4
		//IL_03f4: Expected VT, but got Ref
		//IL_0360: Expected VT, but got I4
		//IL_0369: Expected VT, but got I4
		//IL_02e7: Expected VT, but got I4
		//IL_02b4: Expected VT, but got I4
		//IL_02b4: Expected F4, but got I
		//IL_02b4: Expected VT, but got I4
		//IL_02c5: Expected VT, but got I4
		//IL_02cf: Expected VT, but got I4
		//IL_039e: Expected F4, but got I
		//IL_039e: Expected VT, but got I4
		//IL_03b0: Expected VT, but got I4
		//IL_03ba: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		through = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = copy != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v43+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaWounds gillaWounds = GillaWounds.On(copy);
			obj4 = null;
			obj5 = gillaWounds;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = obj5 == null;
		bool flag7 = !flag6;
		object obj11 = !flag7;
		if (obj11 != null)
		{
			return;
		}
		Transform transform = base.transform;
		if (end == 0)
		{
			object obj12 = 112;
		}
		else
		{
			object obj12 = 136;
		}
		if (end == 0)
		{
			object obj13 = 116;
		}
		else
		{
			object obj13 = 140;
		}
		if (end == 0)
		{
			object obj14 = 120;
		}
		else
		{
			object obj14 = 144;
		}
		Vector3 vector = transform.TransformPoint((Vector3)0);
		string bone = on.name;
		Vector3 vector2 = ((GillaWounds)obj5).OnBody(bone, (Vector3)0);
		Vector3 vector3 = ((GillaWounds)obj5).NearestSkin(section, (Vector3)0);
		Into obj15 = into;
		if (end == 0)
		{
		}
		bool flag8 = obj15 != (Into)1;
		Vector3 vector4 = (Vector3)0;
		UnityEngine.Object obj16 = (UnityEngine.Object)section;
		RpcInfo info;
		Vector3 tip;
		if (!flag8)
		{
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v35+E4]");
			bool flag9 = (nint)0 == 0;
			object obj18 = !flag9;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)ape != (UnityEngine.Object)null)
			{
				NetworkApe networkApe = ape;
				GoreSection goreSection = section;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v335 @ X9_v5]");
				object obj19 = default;
				networkApe.RPC_Stab((byte)goreSection, (Vector3)0, 0f, (byte)(&obj19), (RpcInfo)0);
				byte b = (byte)(&obj19);
				info = (RpcInfo)0;
				tip = (Vector3)section;
				goto IL_03bf;
			}
			obj15 = into;
			vector4 = (Vector3)0;
			obj16 = null;
		}
		bool flag10 = obj15 != (Into)2;
		info = (RpcInfo)vector4;
		tip = (Vector3)obj16;
		if (!flag10)
		{
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v24+E4]");
			bool flag11 = (nint)0 == 0;
			object obj21 = !flag11;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag12 = (UnityEngine.Object)dummy != (UnityEngine.Object)null;
			bool flag13 = !flag12;
			info = (RpcInfo)0;
			tip = (Vector3)0;
			if (!flag13)
			{
				GillaDummy gillaDummy = dummy;
				GoreSection goreSection2 = section;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+v335 @ X9_v5]");
				gillaDummy.Stab(goreSection2, (Vector3)0, 0f, 0);
				byte b = 0;
				info = (RpcInfo)0;
				tip = (Vector3)section;
			}
		}
		goto IL_03bf;
		IL_03bf:
		if (Live)
		{
			object obj22 = default;
			RPC_Through((Vector3)(&obj22), info);
		}
		else
		{
			Through(tip);
		}
	}

	public unsafe void RPC_Through(Vector3 tip, RpcInfo info = default(RpcInfo))
	{
		//IL_0695: Expected Obj, but got I4
		//IL_06c3: Expected Obj, but got I
		//IL_06dd: Expected Obj, but got I4
		//IL_06e6: Expected VT, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I4
		//IL_04f4: Expected VT, but got Ref
		//IL_056b: Expected VT, but got I4
		//IL_0574: Expected Obj, but got I4
		//IL_051f: Expected VT, but got Ref
		//IL_053b: Expected VT, but got Ref
		//IL_00b5: Expected I4, but got I8
		//IL_00e7: Expected Obj, but got VT
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I
		//IL_0250: Expected VT, but got I8
		//IL_026b: Expected Obj, but got I4
		//IL_028e: Expected Obj, but got VT
		//IL_02a8: Expected Obj, but got I4
		//IL_02b1: Expected VT, but got I4
		//IL_02b9: Expected I4, but got VT
		//IL_05bf: Expected Obj, but got I4
		//IL_031d: Expected Obj, but got I4
		//IL_0326: Expected Obj, but got I4
		//IL_032e: Expected VT, but got Ref
		//IL_0336: Expected I, but got VT
		//IL_033e: Expected Obj, but got Ref
		//IL_0347: Expected Obj, but got I4
		//IL_034f: Expected Obj, but got Ref
		//IL_0357: Expected I4, but got VT
		//IL_015e: Expected Obj, but got I4
		//IL_0163: Expected VT, but got Obj
		//IL_016c: Expected VT, but got I4
		//IL_061e: Expected Ref, but got VT
		//IL_0636: Expected Obj, but got I4
		//IL_063e: Expected Obj, but got VT
		//IL_0376: Expected Obj, but got I4
		//IL_02d7: Expected Obj, but got I
		//IL_02df: Expected I4, but got Obj
		//IL_02f1: Expected I4, but got Obj
		//IL_02f1: Expected VT, but got I4
		//IL_018b: Invalid comparison between VT and I4
		//IL_0394: Expected Obj, but got I
		//IL_03be: Expected Obj, but got I4
		//IL_066b: Expected Obj, but got I4
		//IL_0704: Expected Obj, but got I
		//IL_0714: Expected Obj, but got I
		//IL_01a8: Invalid comparison between VT and I4
		//IL_01ba: Expected Obj, but got I4
		//IL_01bf: Expected VT, but got Obj
		//IL_01c8: Expected VT, but got I4
		//IL_0796: Expected Obj, but got I4
		//IL_03f3: Expected Obj, but got I
		//IL_03fc: Expected VT, but got Obj
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected I4, but got Unknown
		//IL_0437: Expected Obj, but got I4
		//IL_04c7: Expected native int or pointer, but got VT
		//IL_04d6: Expected I, but got Obj
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected I4, but got Unknown
		//IL_0486: Expected VT, but got I4
		//IL_0486: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		object obj = !flag2;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj2;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer;
		object obj5 = default;
		PlayerRef playerRef;
		RpcInvokeInfo rpcInvokeInfo2;
		int num;
		Fusion.RpcBuilder rpcBuilder3;
		NullReferenceException ex;
		object obj12;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj2 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			object obj3 = obj2;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(4118636233u, bytePayloadSize, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				obj5 = rpcInvokeInfo >> 32;
				object obj6 = obj5 - 522;
				bool flag4 = (nint)obj6 < 2;
				object obj7 = !flag4;
				object obj8 = ~obj7;
				object obj9;
				PlayerRef playerRef2;
				if (obj8 == null && (nint)obj5 != 518)
				{
					bool flag5 = (nint)obj5 != 524;
					obj9 = 0;
					playerRef = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef2 = invalid;
					if (flag5)
					{
						goto IL_0280;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						obj9 = 0;
						playerRef = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef2 = invalid;
						if (flag6)
						{
							goto IL_0280;
						}
					}
				}
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v67+E4]");
				bool flag7 = (nint)0 == 0;
				object obj11 = !flag7;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DF0]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				obj9 = 0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef2 = none;
				goto IL_0280;
			}
			ex = new NullReferenceException();
			rpcBuilder3 = (Fusion.RpcBuilder)0;
			obj12 = 0;
			num = bytePayloadSize;
			goto IL_0581;
		}
		goto IL_06ad;
		IL_035c:
		object obj13 = default;
		bool flag8 = obj13 == null;
		object obj14 = !flag8;
		if (obj14 != null)
		{
			goto IL_0581;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X0_v38+E4]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X0_v38+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v14+18]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v14+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DE8]");
			object obj20 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj20);
			object obj21 = obj2;
			int num2 = num | obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v19+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid2 = PlayerRef.Invalid;
			RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num2, hostMode, (PlayerRef)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ X26_v4+18] (should have been resolved before IL gen)");
			object obj23 = default;
			obj13 = obj23;
		}
		bool flag11 = num == 0;
		object obj24 = !flag11;
		nint num3;
		if (obj24 == null)
		{
			RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			float x = default;
			((Vector3*)(nint)tip)->x = x;
			num3 = unchecked((nint)null);
			rpcChannel = (RpcChannel)0;
			goto IL_06ad;
		}
		return;
		IL_0759:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0280:
		object obj25 = rpcInvokeInfo >> 32;
		bool flag12 = obj25 == null;
		object obj26 = !flag12;
		rpcBuilder3 = (Fusion.RpcBuilder)0;
		int num4 = (int)rpcInvokeInfo2;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj27 = 0;
			num4 = (int)obj27;
			writer.Write((Vector3)12, (int)obj27);
			int num5 = rpcBuilder2.Send();
			Fusion.RpcBuilder rpcBuilder4 = default;
			rpcBuilder3 = rpcBuilder4;
		}
		rpcBuilder2.Dispose();
		obj13 = 0;
		object obj28 = 0;
		Fusion.RpcBuilder rpcBuilder5 = (Fusion.RpcBuilder)(&rpcBuilder2);
		num3 = (nint)playerRef;
		networkRunner = (NetworkRunner)(&writer);
		obj12 = 0;
		ex = (NullReferenceException)(&rpcBuilder2);
		num = (int)rpcInvokeInfo;
		goto IL_035c;
		IL_0581:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj29;
		OutOfMemoryException ex2;
		if ((nint)obj12 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj29 = obj28;
			obj13 = 1;
		}
		else
		{
			bool flag13 = (nint)obj12 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_0759;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj30 = default;
			obj29 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj28 = obj30;
		}
		((Fusion.RpcBuilder*)rpcBuilder5)->Dispose();
		bool flag14 = obj29 == null;
		obj12 = 0;
		ex = (NullReferenceException)rpcBuilder5;
		if (flag14)
		{
			goto IL_035c;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj12 = 0;
		goto IL_0759;
		IL_06ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tip @ X1 (UnityEngine.Vector3)+18]");
		object obj31 = (nint)0 & (nint)1;
		bool flag15 = obj31 == null;
		object obj32 = !flag15;
		Vector3 tip2 = (Vector3)rpcChannel;
		if (obj32 == null)
		{
			object obj33 = default;
			if (!FromHolder((RpcInfo)(&obj33), scratch: false))
			{
				return;
			}
			bool flag16 = ByIt((Vector3)(&obj33));
			bool flag17 = !flag16;
			tip2 = (Vector3)(&obj33);
			if (flag17)
			{
				return;
			}
		}
		Through(tip2);
	}

	private void Through(Vector3 tip)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0047: Expected VT, but got I4
		//IL_0047: Expected VT, but got I4
		//IL_006c: Expected VT, but got I4
		//IL_006c: Expected VT, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00d4: Expected VT, but got I4
		//IL_00f2: Expected F4, but got I
		//IL_00f2: Expected F4, but got I
		through = true;
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj = 0;
		Quaternion rotation = transform.rotation;
		Vector3 vector = Along(end);
		Vector3 vector2 = (Quaternion)0 * (Vector3)end;
		float num = default;
		int beats = default;
		bool first = default;
		BloodAt((Vector3)16, (Vector3)2, num, 1, beats, first);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float pitchMin = default;
		float pitchMax = default;
		Sfx.Play(stabSounds, (Vector3)0, num, pitchMin, pitchMax);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		Buzz(num2, 0f);
	}

	private unsafe void ComesOut(bool yanked)
	{
		//IL_023f: Expected VT, but got Ref
		//IL_006a: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I4
		//IL_02c8: Expected VT, but got I4
		//IL_02c8: Expected F4, but got VT
		//IL_02c8: Expected VT, but got I4
		//IL_02fe: Expected F4, but got VT
		//IL_02fe: Expected VT, but got I4
		bool flag = !yanked;
		GoreSection goreSection = (yanked ? ((GoreSection)1) : ((GoreSection)0));
		Into obj;
		if (!flag)
		{
			bool flag2 = (byte)(~(harmed ? 1u : 0u)) != 0;
			goreSection = (yanked ? ((GoreSection)1) : ((GoreSection)0));
			if (!flag2)
			{
				obj = into;
				bool flag3 = into != (Into)1;
				goreSection = (yanked ? ((GoreSection)1) : ((GoreSection)0));
				if (flag3)
				{
					goto IL_0283;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v19+E4]");
				bool flag4 = (nint)0 == 0;
				object obj4 = !flag4;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)ape != (UnityEngine.Object)null)
				{
					if (end == 0)
					{
					}
					object obj5 = default;
					ape.RPC_Stab((byte)section, (Vector3)0, (float)point, (byte)(&obj5), (RpcInfo)0);
					byte b = (byte)(&obj5);
					goreSection = section;
				}
				else
				{
					bool flag5 = (byte)(~(harmed ? 1u : 0u)) != 0;
					goreSection = (GoreSection)0;
					if (!flag5)
					{
						obj = into;
						goreSection = (GoreSection)0;
						goto IL_0283;
					}
				}
			}
		}
		goto IL_01fd;
		IL_0283:
		if (obj == (Into)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj8 = !flag6;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = (UnityEngine.Object)dummy != (UnityEngine.Object)null;
			bool flag8 = !flag7;
			goreSection = (GoreSection)0;
			if (!flag8)
			{
				goreSection = section;
				if (end == 0)
				{
				}
				dummy.Stab(goreSection, (Vector3)0, (float)point, 0);
				byte b = 0;
			}
		}
		goto IL_01fd;
		IL_01fd:
		if (Live)
		{
			NetworkBool yanked2 = yanked;
			object obj9 = default;
			RPC_Out(yanked2, (RpcInfo)(&obj9));
		}
		else
		{
			Out(yanked, seen: true);
		}
	}

	public unsafe void RPC_Out(NetworkBool yanked, RpcInfo info = default(RpcInfo))
	{
		//IL_00aa: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I4
		//IL_05cb: Expected Obj, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected VT, but got Unknown
		//IL_014a: Expected I4, but got I8
		//IL_0041: Expected VT, but got Ref
		//IL_017c: Expected Obj, but got VT
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_01a4: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I
		//IL_02e5: Expected VT, but got I8
		//IL_0300: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got VT
		//IL_033d: Expected Obj, but got I4
		//IL_0345: Expected I4, but got VT
		//IL_03c5: Expected Obj, but got I4
		//IL_03cd: Expected VT, but got Ref
		//IL_03d5: Expected I, but got VT
		//IL_03dd: Expected Obj, but got Ref
		//IL_03e5: Expected VT, but got I4
		//IL_03ee: Expected Obj, but got I4
		//IL_03f6: Expected Obj, but got Ref
		//IL_03ff: Expected Obj, but got I4
		//IL_0407: Expected I4, but got VT
		//IL_01f3: Expected Obj, but got I4
		//IL_01f8: Expected VT, but got Obj
		//IL_0209: Expected VT, but got I4
		//IL_0675: Expected Ref, but got VT
		//IL_068f: Expected Obj, but got I4
		//IL_07aa: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I
		//IL_036b: Expected VT, but got Obj
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected VT, but got Unknown
		//IL_0220: Invalid comparison between VT and I4
		//IL_06db: Expected Obj, but got I4
		//IL_06a6: Expected Obj, but got I4
		//IL_06ae: Expected Obj, but got VT
		//IL_06b7: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I4
		//IL_023d: Invalid comparison between VT and I4
		//IL_024f: Expected Obj, but got I4
		//IL_0254: Expected VT, but got Obj
		//IL_0265: Expected VT, but got I4
		//IL_0718: Expected Obj, but got I
		//IL_0728: Expected Obj, but got I
		//IL_0443: Expected Obj, but got I4
		//IL_0595: Expected native int or pointer, but got VT
		//IL_05a2: Expected native int or pointer, but got VT
		//IL_05ac: Expected I, but got Obj
		//IL_04c0: Expected Obj, but got I
		//IL_04c9: Expected VT, but got Obj
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected I4, but got Unknown
		//IL_0504: Expected Obj, but got I4
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected I4, but got Unknown
		//IL_0553: Expected VT, but got I4
		//IL_0553: Expected VT, but got I4
		object obj;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer;
		object obj4 = default;
		PlayerRef playerRef;
		RpcInvokeInfo rpcInvokeInfo2;
		int num;
		RpcInfo rpcInfo;
		NullReferenceException ex;
		object obj11;
		if (!NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			object obj2 = obj;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(3659790931u, bytePayloadSize, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				obj4 = rpcInvokeInfo >> 32;
				object obj5 = obj4 - 522;
				bool flag2 = (nint)obj5 < 2;
				object obj6 = !flag2;
				object obj7 = ~obj6;
				object obj8;
				PlayerRef playerRef2;
				if (obj7 == null && (nint)obj4 != 518)
				{
					bool flag3 = (nint)obj4 != 524;
					obj8 = 0;
					playerRef = (PlayerRef)this;
					playerRef2 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag3)
					{
						goto IL_0315;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag4 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						obj8 = 0;
						playerRef = (PlayerRef)this;
						playerRef2 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag4)
						{
							goto IL_0315;
						}
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v60+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E08]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				obj8 = 0;
				playerRef2 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_0315;
			}
			ex = new NullReferenceException();
			rpcInfo = info;
			obj11 = 0;
			num = bytePayloadSize;
			goto IL_05d8;
		}
		goto IL_0005;
		IL_0790:
		nint num2 = default;
		bool flag6 = num2 == 0;
		object obj12 = !flag6;
		object obj13;
		nint num4;
		if (obj12 == null)
		{
			if ((nint)obj13 != 7)
			{
				bool flag7 = obj13 == null;
				object obj14 = !flag7;
				if (obj14 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v12+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v12+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v7+18]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DF8]");
				object obj20 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj20);
				object obj21 = obj;
				int num3 = num | obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v12+E4]");
				bool flag9 = (nint)0 == 0;
				object obj22 = !flag9;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num3, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ X27_v3+18] (should have been resolved before IL gen)");
				IntPtr intPtr = default;
				num2 = intPtr;
			}
			if (num != 0)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			Tick tick = default;
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, tick);
			((RpcInfo*)(nint)info)->_validationResult = num2;
			num4 = unchecked((nint)null);
			goto IL_0005;
		}
		goto IL_05d8;
		IL_076d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0315:
		object obj23 = rpcInvokeInfo >> 32;
		bool flag10 = obj23 == null;
		object obj24 = !flag10;
		int num5 = (int)rpcInvokeInfo2;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E00]");
			object obj25 = 0;
			playerRef = (PlayerRef)obj25;
			NetworkBool value = (NetworkBool)(yanked & 0xFFFFFFFFL);
			writer.Write(value, 4);
			int num6 = rpcBuilder2.Send();
			num5 = 4;
		}
		rpcBuilder2.Dispose();
		num2 = 0;
		object obj26 = 0;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		num4 = (nint)playerRef;
		networkRunner = (NetworkRunner)(&writer);
		rpcInfo = (RpcInfo)num5;
		obj11 = 0;
		ex = (NullReferenceException)(&rpcBuilder2);
		obj13 = 7;
		num = (int)rpcInvokeInfo;
		goto IL_0790;
		IL_05d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj27;
		OutOfMemoryException ex2;
		if ((nint)obj11 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj27 = obj26;
			num2 = 1;
		}
		else
		{
			bool flag11 = (nint)obj11 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag11)
			{
				goto IL_076d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj28 = default;
			obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj26 = obj28;
		}
		((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
		bool flag12 = obj27 == null;
		object obj29 = !flag12;
		if (obj29 == null)
		{
			obj11 = 0;
			ex = (NullReferenceException)rpcBuilder3;
			obj13 = 0;
			goto IL_0790;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj11 = 0;
		goto IL_076d;
		IL_0005:
		bool flag13 = !info.IsInvokeLocal;
		object obj30 = !flag13;
		object obj31 = default;
		if (obj30 != null || FromHolder((RpcInfo)(&obj31), scratch: false))
		{
			NetworkBool networkBool = (NetworkBool)(yanked & 0xFFFFFFFFL);
			bool yanked2 = networkBool;
			Out(yanked2, seen: true);
		}
	}

	private void Out(bool yanked, bool seen)
	{
		//IL_0032: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04fd: Expected VT, but got I4
		//IL_00de: Expected VT, but got I4
		//IL_052f: Expected VT, but got I4
		//IL_064b: Expected I4, but got I8
		//IL_0665: Expected Obj, but got I4
		//IL_07bc: Expected I4, but got I8
		//IL_0550: Expected Obj, but got I4
		//IL_056a: Expected Obj, but got I4
		//IL_0573: Expected VT, but got I4
		//IL_0140: Expected VT, but got I4
		//IL_0140: Expected VT, but got I4
		//IL_015e: Expected Obj, but got I4
		//IL_0175: Expected F8, but got VT
		//IL_0185: Expected F8, but got I
		//IL_0797: Expected VT, but got I4
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		//IL_05b1: Expected VT, but got I4
		//IL_0b71: Expected Obj, but got I
		//IL_0b9b: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I
		//IL_027e: Expected F4, but got I
		//IL_027e: Expected F4, but got I
		//IL_027e: Expected F4, but got VT
		//IL_027e: Expected VT, but got I4
		//IL_0299: Expected F4, but got I
		//IL_02ab: Expected VT, but got I4
		//IL_01b5: Invalid comparison between F4 and I4
		//IL_01c4: Expected F8, but got I4
		//IL_0399: Expected Obj, but got I4
		//IL_06dd: Expected VT, but got F4
		//IL_05f0: Expected F4, but got I4
		//IL_02ce: Unsupported input type for neg.
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected F8, but got Unknown
		//IL_02e4: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I4
		//IL_083b: Expected Obj, but got I8
		//IL_084b: Expected Obj, but got I
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected Obj, but got Unknown
		//IL_0867: Expected Obj, but got I4
		//IL_0c6d: Expected F4, but got I
		//IL_03c0: Expected F4, but got I
		//IL_033c: Expected F4, but got I
		//IL_09c6: Expected VT, but got I4
		//IL_0c9f: Expected Obj, but got I4
		//IL_0bf1: Expected Obj, but got I4
		//IL_0327: Expected F4, but got I
		//IL_073a: Expected VT, but got F4
		//IL_076d: Expected VT, but got I4
		//IL_0358: Expected VT, but got I4
		//IL_0896: Expected Obj, but got I4
		//IL_0c13: Expected Obj, but got I4
		//IL_034a: Expected VT, but got I4
		//IL_08c5: Expected Obj, but got I
		//IL_08ea: Expected VT, but got I4
		//IL_037a: Expected VT, but got I4
		//IL_0954: Expected Obj, but got I4
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Expected Obj, but got Unknown
		//IL_0c4a: Expected F4, but got VT
		//IL_0c52: Expected I4, but got VT
		//IL_036c: Expected VT, but got I4
		//IL_0933: Expected Obj, but got I
		//IL_0945: Expected VT, but got I4
		//IL_0af2: Expected VT, but got I4
		if (into == 0)
		{
			return;
		}
		float num11 = default;
		bool flag = default;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v55+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = on != null;
			bool flag4 = !flag3;
			flag = false;
			if (!flag4)
			{
				if ((object)on != null)
				{
					Vector3 vector = on.TransformPoint((Vector3)0);
					Transform transform = base.transform;
					if ((object)transform != null)
					{
						Quaternion rotation = transform.rotation;
						Vector3 vector2 = Along(end);
						Vector3 vector3 = (Quaternion)0 * (Vector3)end;
						bool flag5 = !yanked;
						object obj4 = !flag5;
						double num = 1.0;
						double num2 = (double)onLocal;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
						double num3 = 0.0;
						if (obj4 == null)
						{
							float num4 = depth;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
							float num5 = num4 / 0f;
							bool flag6 = num5 < 0f;
							double num6 = 0.0;
							if (!flag6)
							{
								bool flag7 = !((double)num5 > 1.0);
								num6 = num5;
								if (!flag7)
								{
									num6 = 1.0;
								}
							}
							double num7 = num6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC8]");
							num2 = num7 * 0.0;
							num = num2 + 0.5;
							num3 = 0.5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
						object obj5 = 0;
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X0_v68+E4]");
						bool flag8 = (nint)0 == 0;
						object obj7 = !flag8;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						double num8 = num * (double)loudness;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD8C]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE30]");
						object obj9 = 0;
						AudioClip[] clips = pullSounds;
						Vector3 vector4 = onLocal;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
						Sfx.Play(clips, (Vector3)0, (float)vector4, num9, 0f);
						bool flag9 = (byte)(~(harmed ? 1u : 0u)) != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
						float num10 = 0f;
						flag = false;
						Vector3 vector5 = (Vector3)0;
						if (!flag9)
						{
							bool flag10 = !yanked;
							num8 = (double)(0 - onLocal);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+18C]");
							obj8 = -0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
							obj9 = -0;
							object obj10 = !flag10;
							object obj11 = ~obj10;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A888]");
								num10 = 0f;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
								num10 = 0f;
							}
							object obj12 = !flag10;
							object obj13 = ~obj12;
							vector5 = ((obj13 != null) ? ((Vector3)16) : ((Vector3)34));
							object obj14 = !flag10;
							object obj15 = ~obj14;
							Vector3 vector6 = ((obj15 != null) ? ((Vector3)2) : ((Vector3)(2 + 1)));
							int beats = default;
							bool first = default;
							BloodAt(vector5, vector6, (float)onLocal, yanked ? 1 : 0, beats, first);
							flag = (byte)(int)vector6 != 0;
						}
						bool flag11 = !yanked;
						object obj16 = !flag11;
						object obj17 = ~obj16;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
							num11 = 0f;
						}
						else
						{
							num11 = 0.5f;
						}
						float strength = num11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
						Buzz(strength, 0f);
						if (~(harmed ? 1u : 0u) == 0)
						{
							Drips();
						}
						goto IL_03e2;
					}
				}
				goto IL_0b2d;
			}
		}
		goto IL_03e2;
		IL_0af7:
		float time = Time.time;
		float num12 = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		float num13 = num12 + 0f;
		againAt = num13;
		Remember();
		return;
		IL_0b3b:
		throw new IndexOutOfRangeException();
		IL_03e2:
		GillaItem gillaItem = item;
		into = (Into)0;
		GillaItem gillaItem2;
		if ((object)item != null)
		{
			object obj18 = this + 384;
			gillaItem.Stuck__BackingField = false;
			on = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj19 = this + 504;
			pulls = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj20 = this + 472;
			ape = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj21 = this + 480;
			copy = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj22 = this + 488;
			dummy = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj23 = this + 496;
			monster = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool live = Live;
			bool flag12 = !live;
			NetworkBool networkBool = (NetworkBool)0;
			if (!flag12)
			{
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				bool flag13 = (object)((SimulationBehaviour)this)._object == null;
				networkBool = (NetworkBool)0;
				if (!flag13)
				{
					object obj24 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
					bool flag14 = obj24 == null;
					object obj25 = !flag14;
					networkBool = (NetworkBool)0;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
						object obj27 = default;
						object obj26 = obj27 & 1;
						bool flag15 = obj26 == null;
						networkBool = (NetworkBool)0;
						if (!flag15)
						{
							NetworkBool networkBool2 = (Pulling = false);
							Depth = 0f;
							num11 = 0f;
							networkBool = networkBool2;
						}
					}
				}
			}
			gillaItem2 = item;
			if ((object)item != null)
			{
				gillaItem2.Pinned__BackingField = false;
				int num14 = (int)(gillaItem2.Hand__BackingField & 0x80000000L);
				bool flag16 = num14 == 0;
				object obj28 = !flag16;
				if (obj28 != null)
				{
					goto IL_07a5;
				}
				if (item.Mine)
				{
					Transform transform2 = base.transform;
					if ((object)transform2 != null)
					{
						Vector3 position = transform2.position;
						comeFrom = (Vector3)num11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
						_ = 0;
						Transform transform3 = base.transform;
						if ((object)transform3 != null)
						{
							Quaternion rotation2 = transform3.rotation;
							comeTurn = (Quaternion)num11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPickaxe)+190]");
							_ = 0;
							comeFor = 0.12f;
							networkBool = (NetworkBool)0;
							goto IL_0af7;
						}
					}
				}
				else
				{
					gillaItem2 = item;
					bool flag17 = (object)item == null;
					networkBool = (NetworkBool)0;
					if (!flag17)
					{
						goto IL_07a5;
					}
				}
			}
		}
		goto IL_0b2d;
		IL_0b2d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b3b;
		IL_07a5:
		if ((int)(gillaItem2.Hand__BackingField & 0x80000000L) == 0)
		{
			goto IL_0af7;
		}
		Collider[] array = gillaItem2.Colliders__BackingField;
		if (gillaItem2.Colliders__BackingField == null)
		{
			goto IL_0b2d;
		}
		if (array.Length < 1)
		{
			goto IL_0980;
		}
		object obj29 = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj30 = 0;
		object obj31 = gillaItem2.Colliders__BackingField + 32;
		object obj32 = 0;
		while (true)
		{
			bool flag18 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
			object obj33 = !flag18;
			if (obj33 != null)
			{
				break;
			}
			object obj34 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v34+E4]");
			bool flag19 = (nint)0 == 0;
			object obj35 = !flag19;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X24_v7+v411 @ X22_v10*8]");
			bool flag20 = (UnityEngine.Object)0 != null;
			bool flag21 = !flag20;
			flag = false;
			NetworkBool networkBool = (NetworkBool)0;
			if (!flag21)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X24_v7+v411 @ X22_v10*8]");
				if ((nint)0 == 0)
				{
					goto IL_0b2d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X24_v7+v411 @ X22_v10*8]");
				((Collider)0).enabled = true;
				flag = false;
				networkBool = (NetworkBool)1;
			}
			obj29 = array.Length;
			obj32++;
			if ((nint)obj32 < array.Length)
			{
				continue;
			}
			goto IL_0980;
		}
		goto IL_0b3b;
		IL_0980:
		if ((object)item != null)
		{
			bool mine = item.Mine;
			bool flag22 = !mine;
			NetworkBool networkBool = (NetworkBool)0;
			if (flag22)
			{
				goto IL_0af7;
			}
			GillaItem gillaItem3 = item;
			if ((object)item != null && (object)gillaItem3.Body__BackingField != null)
			{
				gillaItem3.Body__BackingField.isKinematic = false;
				GillaItem gillaItem4 = item;
				if ((object)item != null && (object)gillaItem4.Body__BackingField != null)
				{
					gillaItem4.Body__BackingField.interpolation = (RigidbodyInterpolation)1;
					GillaItem gillaItem5 = item;
					if ((object)item != null && (object)gillaItem5.Body__BackingField != null)
					{
						gillaItem5.Body__BackingField.WakeUp();
						networkBool = (NetworkBool)0;
						goto IL_0af7;
					}
				}
			}
		}
		goto IL_0b2d;
	}

	private void Drips()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_0284: Expected VT, but got I4
		//IL_02bb: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I
		//IL_032b: Expected Obj, but got I4
		//IL_01e9: Expected F4, but got I
		//IL_01e9: Expected F4, but got I
		//IL_01e9: Expected Obj, but got I4
		//IL_01e9: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Material spray = Spray;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(spray == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GameObject gameObject = default;
			gameObject._002Ector((string)obj8);
			Transform transform = gameObject.transform;
			Transform parent = base.transform;
			transform.SetParent(parent, worldPositionStays: false);
			if (end == 0)
			{
				object obj9 = 112;
			}
			else
			{
				object obj9 = 136;
			}
			if (end == 0)
			{
				object obj10 = 116;
			}
			else
			{
				object obj10 = 140;
			}
			if (end == 0)
			{
				object obj11 = 120;
			}
			else
			{
				object obj11 = 144;
			}
			transform.localPosition = (Vector3)0;
			GameObject obj12 = transform.gameObject;
			object obj13 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj12, 4f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
			object obj16 = 0;
			object obj17 = obj15;
			object obj18 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v15+A0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v23+E4]");
			bool flag4 = (nint)0 == 0;
			object obj20 = !flag4;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v16+24]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v16+28]");
			Blood.Spray(transform, (Vector3)spray, (Material)3, num, 3, 0, 0f);
		}
	}

	private void CameFrom(float dt)
	{
		//IL_005c: Invalid comparison between F4 and I4
		//IL_00c9: Expected VT, but got I4
		//IL_00c9: Expected VT, but got I4
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		float num = comeFor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
		float num2 = num / 0f;
		float num3 = num2 + 1f;
		Vector3 position = transform2.position;
		Transform transform3 = default;
		if (num3 < 0f || !((double)num3 > 1.0))
		{
			transform3 = base.transform;
		}
		Quaternion rotation = transform3.rotation;
		Quaternion a = default;
		Quaternion b = default;
		Quaternion quaternion = Quaternion.Internal_Slerp(ref a, ref b, num3);
		transform.SetPositionAndRotation((Vector3)0, (Quaternion)0);
		float num4 = comeFor - dt;
		comeFor = num4;
	}

	private void WetsTo(int e, float deep)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c2: Invalid comparison between F4 and Obj
		//IL_00d3: Expected Obj, but got I4
		//IL_00eb: Invalid comparison between F4 and I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got F4
		float[] array = wetTo;
		if (wetTo != null)
		{
			bool flag = array.Length < e;
			object obj = !flag;
			object obj2 = array.Length - e;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				object obj5 = wetTo + e;
				float num = deep;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
				float num2 = num + 0f;
				object obj6 = obj5 + 32;
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
				object obj7 = !flag3;
				float num3 = num2 - (float)obj6;
				bool flag4 = num3 == 0f;
				object obj8 = ~obj7;
				object obj9 = obj8 | flag4;
				if (obj9 == null)
				{
					obj6 = num2;
					float time = Time.time;
					wetAt = time;
					wetChanged = true;
				}
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private void Wets()
	{
		//IL_0010: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0067: Invalid comparison between F4 and I4
		//IL_0095: Expected Obj, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I
		//IL_020b: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I4
		//IL_0287: Expected Obj, but got I
		//IL_0299: Expected VT, but got I4
		//IL_0299: Expected I4, but got Obj
		//IL_02ef: Expected Obj, but got I
		//IL_030b: Expected VT, but got I4
		//IL_0323: Expected Obj, but got I
		//IL_035b: Invalid comparison between F4 and I4
		//IL_036a: Expected F4, but got I4
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
		bool flag2 = wet == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null || wetAt < 0f)
		{
			return;
		}
		bool flag4 = (byte)(~(wetChanged ? 1u : 0u)) != 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			float time = Time.time;
			float num = time - wetSaid;
			if ((double)num < 0.5)
			{
				return;
			}
		}
		wetChanged = false;
		float time2 = Time.time;
		object obj6 = this + 648;
		wetSaid = time2;
		bool flag5 = props == null;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			obj6 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v28+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaStains.LayNoise();
		}
		if ((object)wet != null)
		{
			wet.enabled = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
			object obj12 = 0;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v16+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj12;
			}
			if (wetTo != null && obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v16+A0]");
				object obj15 = 0;
				((MaterialPropertyBlock)obj6).SetVector((int)obj15, (Vector4)0);
				if (wetTo != null && props != null)
				{
					object obj16 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v5+A0]");
					object obj17 = 0;
					MaterialPropertyBlock materialPropertyBlock2 = props;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v14+4]");
					materialPropertyBlock2.SetVector(0, (Vector4)0);
					object obj18 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v15+A0]");
					object obj19 = 0;
					float time3 = Time.time;
					float num2 = time3 - wetAt;
					float num3 = num2 / 1.1107041E+09f;
					bool flag8 = num3 < 0f;
					float value = 0f;
					if (!flag8)
					{
						bool flag9 = !((double)num3 > 1.0);
						value = num3;
						if (!flag9)
						{
							value = 1f;
						}
					}
					if (props != null)
					{
						MaterialPropertyBlock materialPropertyBlock3 = props;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v16+8]");
						materialPropertyBlock3.SetFloat(0, value);
						if ((object)wet != null)
						{
							wet.SetPropertyBlock((MaterialPropertyBlock)obj6);
							return;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void Buzz(float strength, float seconds)
	{
		GillaItem gillaItem = item;
		XRNode node;
		if (gillaItem.Hand__BackingField != 0)
		{
			if (gillaItem.Hand__BackingField != 1)
			{
				return;
			}
			node = (XRNode)5;
		}
		else
		{
			node = (XRNode)4;
		}
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		InputDevice inputDevice = default;
		bool flag = inputDevice.SendHapticImpulse(0u, strength, seconds);
	}

	public GillaPickaxe()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_01ba: Expected VT, but got I
		//IL_01cc: Expected F4, but got I
		//IL_01de: Expected F4, but got I
		//IL_01f0: Expected VT, but got I
		//IL_0202: Expected F4, but got I
		//IL_0214: Expected F4, but got I
		//IL_0226: Expected F4, but got I
		//IL_0235: Expected I4, but got I8
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0127: Expected I4, but got I8
		//IL_0134: Expected Obj, but got I8
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E20]");
		object obj5 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B040]");
		balance = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FA60]");
		inLine = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BF88]");
		stabSpeed = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B9D8]");
		firstIn = (Vector2)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E4D0]");
		chiselIn = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F950]");
		chiselRadius = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D640]");
		bodyLeverMost = 0f;
		miningDamage = 8;
		monsterHeadHarm = 160f;
		loudness = 0.4f;
		hiddenSince = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaNetGuard.Holder holder = default;
		holder._002Ector();
		object obj6 = this + 464;
		this.holder = holder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Vector3[] array = default;
		was = array;
		object obj7 = this + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Vector3[] array2 = default;
		swung = array2;
		object obj8 = this + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		float[] array3 = default;
		swungAt = array3;
		object obj9 = this + 544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		float[] array4 = default;
		wetTo = array4;
		object obj10 = this + 552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = this + 604;
		heldWas = -1;
		obj11 = -4411275831796563968L;
		perMesh = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		bool[] array5 = default;
		scraping = array5;
		object obj12 = this + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Skin[] array6 = default;
		scrapedFrom = array6;
		object obj13 = this + 664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaPickaxe()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E30]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E40]");
		object obj5 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj7 = 0;
		obj7 = num;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+A0]");
		object obj9 = 0;
		int num3 = Shader.PropertyToID((string)obj4);
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v9+A0]");
		object obj13 = (nint)0 + (nint)40;
		obj13 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
		//IL_0016: Expected VT, but got I4
		Depth = _Depth;
		PullTo = (Vector3)P_0;
		Pulling = _Pulling;
	}

	public override void CopyStateToBackingFields()
	{
		//IL_002d: Expected VT, but got F4
		float num = (_Depth = Depth);
		Vector3 vector = PullTo;
		_PullTo = (Vector3)num;
		NetworkBool pulling = Pulling;
		_Pulling = pulling;
	}

	protected unsafe static void RPC_Clang_0040Invoker1371460200([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I
		//IL_028a: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0147: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_00c7: Expected VT, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01bf: Expected F4, but got VT
		//IL_01bf: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 value, 12);
		rpcDataReader.Read(out Vector3 _, 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		rpcDataReader.Read(out float _, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		byte stuff = 0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BC8]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ X21_v3+18] (should have been resolved before IL gen)");
			stuff = 0;
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaPickaxe gillaPickaxe = (GillaPickaxe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaPickaxe;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v14 (Il2CppClass<GillaPickaxe>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X1_v9+130]");
		bool flag3 = num2 < 0;
		object obj13 = !flag3;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v14 (Il2CppClass<GillaPickaxe>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X1_v9+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				Vector3 at = default;
				object obj16 = default;
				RpcInfo info = default;
				gillaPickaxe.RPC_Clang(at, (Vector3)(&obj16), stuff, (float)value, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Scratch_0040Invoker2618516507([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0023: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_023c: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_013f: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_00f1: Expected VT, but got Obj
		//IL_019c: Expected Obj, but got I
		//IL_01e8: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out int value, 4);
		rpcDataReader.Read(out NetworkId value2, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		rpcDataReader.Read(out Vector3 _, 12);
		rpcDataReader.Read(out Vector3 _, 12);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D68]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaPickaxe gillaPickaxe = (GillaPickaxe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaPickaxe;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14 (Il2CppClass<GillaPickaxe>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X1_v11+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14 (Il2CppClass<GillaPickaxe>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X1_v11+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte kind = default;
				byte s = default;
				object obj16 = default;
				Vector3 to = default;
				RpcInfo info = default;
				gillaPickaxe.RPC_Scratch(kind, value, value2, s, (Vector3)(&obj16), to, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Knock_0040Invoker3666117485([In] ref RpcInvokeContext context)
	{
		//IL_0012: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I4
		//IL_01ea: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I
		//IL_022a: Expected VT, but got I4
		//IL_0251: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_0096: Expected VT, but got Obj
		//IL_00c5: Expected VT, but got I
		//IL_0152: Expected Obj, but got I
		//IL_018e: Expected F4, but got VT
		//IL_018e: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 value, 12);
		rpcDataReader.Read(out float _, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v9+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		RpcInfo info = (RpcInfo)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D38]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X21_v3+28]");
			info = (RpcInfo)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v9+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaPickaxe gillaPickaxe = (GillaPickaxe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaPickaxe;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<GillaPickaxe>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X1_v7+130]");
		bool flag3 = num2 < 0;
		object obj12 = !flag3;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<GillaPickaxe>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X1_v7+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v17-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaPickaxe.RPC_Knock((Vector3)(&obj15), (float)value, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_In_0040Invoker2229528253([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0024: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_0281: Expected Obj, but got I
		//IL_0291: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I4
		//IL_02f7: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_0180: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I
		//IL_0132: Expected VT, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_0235: Expected F4, but got VT
		//IL_0235: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out int value, 4);
		rpcDataReader.Read(out NetworkId value2, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		rpcDataReader.Read(out Vector3 value3, 12);
		rpcDataReader.Read(out Vector3 _, 12);
		rpcDataReader.Read(out float _, 4);
		rpcDataReader.Read(out float _, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v16+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D48]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaPickaxe gillaPickaxe = (GillaPickaxe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaPickaxe;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v14 (Il2CppClass<GillaPickaxe>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X1_v14+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v14 (Il2CppClass<GillaPickaxe>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X1_v14+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte e = default;
				byte kind = default;
				byte s = default;
				object obj16 = default;
				Vector3 way = default;
				float hard = default;
				RpcInfo info = default;
				gillaPickaxe.RPC_In(e, kind, value, value2, s, (Vector3)(&obj16), way, (float)value3, hard, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_BodyStab_0040Invoker3899275263([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0023: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0147: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I
		//IL_00d0: Expected VT, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01bf: Expected F4, but got VT
		//IL_01bf: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out int value, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		rpcDataReader.Read(out Vector3 value2, 12);
		rpcDataReader.Read(out float _, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v11+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DB0]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaPickaxe gillaPickaxe = (GillaPickaxe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaPickaxe;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v14 (Il2CppClass<GillaPickaxe>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X1_v9+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v14 (Il2CppClass<GillaPickaxe>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X1_v9+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte s = default;
				object obj16 = default;
				RpcInfo info = default;
				gillaPickaxe.RPC_BodyStab(value, s, (Vector3)(&obj16), (float)value2, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Monster_0040Invoker3201255347([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0023: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0147: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I
		//IL_00d0: Expected VT, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01bf: Expected F4, but got VT
		//IL_01bf: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out NetworkId value, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		rpcDataReader.Read(out Vector3 value2, 12);
		rpcDataReader.Read(out float _, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v11+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DA0]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaPickaxe gillaPickaxe = (GillaPickaxe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaPickaxe;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v14 (Il2CppClass<GillaPickaxe>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X1_v9+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v14 (Il2CppClass<GillaPickaxe>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X1_v9+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte s = default;
				object obj16 = default;
				RpcInfo info = default;
				gillaPickaxe.RPC_Monster(value, s, (Vector3)(&obj16), (float)value2, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Bled_0040Invoker2272601190([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_0094: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_0045: Expected VT, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_0125: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DC0]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ X21_v2+18] (should have been resolved before IL gen)");
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaPickaxe gillaPickaxe = (GillaPickaxe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaPickaxe;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<GillaPickaxe>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
		bool flag2 = num2 < 0;
		object obj12 = !flag2;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<GillaPickaxe>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v15-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaPickaxe.RPC_Bled((RpcInfo)(&obj15));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Through_0040Invoker4118636233([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		//IL_0213: Expected VT, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00dd: Expected I, but got Obj
		//IL_0106: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_007e: Expected VT, but got Obj
		//IL_00ad: Expected VT, but got I
		//IL_013a: Expected Obj, but got I
		//IL_0172: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 _, 12);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v8+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		RpcInfo info = (RpcInfo)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DE8]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X21_v3+28]");
			info = (RpcInfo)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaPickaxe gillaPickaxe = (GillaPickaxe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaPickaxe;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v14 (Il2CppClass<GillaPickaxe>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X1_v6+130]");
		bool flag3 = num2 < 0;
		object obj12 = !flag3;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v14 (Il2CppClass<GillaPickaxe>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X1_v6+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v17-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaPickaxe.RPC_Through((Vector3)(&obj15), info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Out_0040Invoker3659790931([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		//IL_0295: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I4
		//IL_034a: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_007e: Expected VT, but got Obj
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0323: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I
		//IL_00f5: Expected I4, but got Obj
		//IL_00fd: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_019a: Expected VT, but got Ref
		//IL_019a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out NetworkBool value, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		object obj8 = default;
		object obj7 = obj8;
		RpcChannel rpcChannel = (RpcChannel)0;
		RpcHostMode rpcHostMode = (RpcHostMode)0;
		object obj9 = 0;
		object obj11 = default;
		object obj10 = obj11;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5DF8]");
			object obj12 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj12);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X21_v3+28]");
			rpcChannel = (RpcChannel)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ X21_v3+18] (should have been resolved before IL gen)");
			object obj13 = default;
			obj7 = obj13;
			rpcHostMode = (RpcHostMode)(int)(&obj11);
			obj9 = 0;
			object obj14 = default;
			obj10 = obj14;
		}
		object obj15 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v9+A0]");
		object obj16 = 0;
		obj16 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaPickaxe gillaPickaxe = (GillaPickaxe)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B68]");
			object obj17 = 0;
			rpcHostMode = (RpcHostMode)obj17;
			nint num = (nint)gillaPickaxe;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v27 (Il2CppClass<GillaPickaxe>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X1_v5 (Fusion.RpcHostMode)+130]");
			bool flag3 = num2 < 0;
			object obj18 = !flag3;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v27 (Il2CppClass<GillaPickaxe>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X1_v5 (Fusion.RpcHostMode)+130]");
				object obj20 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v30-8]");
				if ((nint)0 == (nint)rpcHostMode)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
					object obj21 = default;
					((GillaPickaxe)0).RPC_Out(value, (RpcInfo)(&obj21));
					return;
				}
			}
			InvalidCastException ex = new InvalidCastException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		object obj22 = typeof(MicrophonePermission) + 2256;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj24 = !flag4;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((bool)(UnityEngine.Object)(object)((Exception)ex2)._helpURL)
		{
			if (((Exception)ex2)._helpURL != null)
			{
				throw new ArgumentNullException();
			}
			throw new NullReferenceException();
		}
	}
}
