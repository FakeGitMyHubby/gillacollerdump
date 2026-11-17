using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaSplashMonster : NetworkBehaviour
{
	public const byte Prowl = default(byte);

	public const byte Hear = default(byte);

	public const byte Rush = default(byte);

	public const byte Search = default(byte);

	public const byte Kill = default(byte);

	public MonsterBrain brain;

	public float prowlSpeed;

	public float rushSpeed;

	public float accel;

	public float fasterEachRound;

	public float hearSeconds;

	public float searchSeconds;

	public float switchShare;

	public float switchNear;

	public float lostAfter;

	public float reach;

	public float prowlBack;

	public Transform prowlMark;

	public float rushSink;

	public AudioClip[] hearSounds;

	public AudioClip[] surgeSounds;

	private byte _NetState;

	private float _NetSpeed;

	private float _NetPace;

	private float _NetSink;

	private Vector3 _NetLook;

	private float _NetLookWeight;

	private int _NetKills;

	private PlayerRef _NetVictim;

	private byte _NetPool;

	public static readonly List<GillaSplashMonster> All;

	private byte state;

	private int poolIndex;

	private int kills;

	private int seenKills;

	private PlayerRef victim;

	private float stateT;

	private float speed;

	private float animSpeed;

	private float pace;

	private float sink;

	private float lookWeight;

	private float wait;

	private float yawVel;

	private float repathAt;

	private float nextWake;

	private float surgeAt;

	private Vector3 target;

	private Vector3 look;

	private PlayerRef quarry;

	private float quarryHeard;

	private float followAt;

	private float heardTime;

	private Vector3 heardAt;

	private PlayerRef heardFrom;

	private readonly List<Vector3> path;

	private GillaSplashPool pool;

	private Transform model;

	private Vector3 modelRest;

	private Vector3 lastPos;

	private float killSeconds;

	private const float SplashBudget = default(float);

	private const float SplashReach = default(float);

	private unsafe byte NetState
	{
		get
		{
			//IL_0080: Expected I4, but got Obj
			int* ptr = Ptr;
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
				return (byte)(int)ex2;
			}
			return (byte)ptr;
		}
		set
		{
			if (Ptr != null)
			{
				int* ptr = (int*)(int)value;
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

	private unsafe float NetSpeed
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+4]");
				return 0f;
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

	private unsafe float NetPace
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+8]");
				return 0f;
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

	private unsafe float NetSink
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+C]");
				return 0f;
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

	private unsafe Vector3 NetLook
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

	private unsafe float NetLookWeight
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+1C]");
				return 0f;
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

	private unsafe int NetKills
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+20]");
				return 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (int)ex2;
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

	private unsafe PlayerRef NetVictim
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+24]");
				return (PlayerRef)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (PlayerRef)ex2;
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

	public unsafe byte NetPool
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+28]");
				return 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (byte)(int)ex2;
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

	public bool Live
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

	private bool Authority
	{
		get
		{
			//IL_0031: Expected I4, but got Obj
			//IL_003c: Expected I4, but got Obj
			//IL_0060: Expected Obj, but got I
			//IL_007a: Expected Obj, but got I4
			bool result;
			if (Live)
			{
				result = (byte)(int)((SimulationBehaviour)this)._object != 0;
				if ((int)(~((SimulationBehaviour)this)._object) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v2 (System.Boolean)+58]");
					object obj = (nint)0 & (nint)2;
					bool flag = obj == null;
					object obj2 = !flag;
					if (obj2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
						bool result2 = default;
						return result2;
					}
					result = false;
				}
			}
			else
			{
				result = true;
			}
			return result;
		}
	}

	public byte State => state;

	public int PoolIndex
	{
		get
		{
			if (Live)
			{
				byte netPool = NetPool;
				return netPool & 0xFF;
			}
			return poolIndex;
		}
		set
		{
			//IL_006d: Expected Obj, but got I4
			//IL_0087: Expected Obj, but got I4
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected Obj, but got Unknown
			poolIndex = value;
			if (!Live)
			{
				return;
			}
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			if ((object)((SimulationBehaviour)this)._object == null)
			{
				return;
			}
			object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				object obj3 = obj4 & 1;
				if (obj3 != null)
				{
					NetPool = (byte)value;
				}
			}
		}
	}

	public bool Hunting
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			object obj = state - 1;
			bool flag = (nint)obj < 3;
			object obj2 = !flag;
			return (byte)(int)(~obj2) != 0;
		}
	}

	public Vector3 Mouth
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01fd: Expected Obj, but got I4
			//IL_01d3: Expected VT, but got Obj
			//IL_00a4: Expected Obj, but got I4
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
			if (!(brain != null))
			{
				goto IL_0153;
			}
			MonsterBrain monsterBrain = brain;
			if ((object)brain != null)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v15+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(monsterBrain.face != null))
				{
					goto IL_0153;
				}
				MonsterBrain monsterBrain2 = brain;
				if ((object)brain != null && (object)monsterBrain2.face != null)
				{
					return monsterBrain2.face.position;
				}
			}
			goto IL_01c5;
			IL_0153:
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Transform transform2 = base.transform;
				if ((object)transform2 != null)
				{
					return transform2.forward;
				}
			}
			goto IL_01c5;
			IL_01c5:
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
	}

	public Vector3 Mark
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00cb: Expected Obj, but got I4
			//IL_00a1: Expected VT, but got Obj
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
			if (prowlMark != null)
			{
				if ((object)prowlMark != null)
				{
					return prowlMark.position;
				}
				NullReferenceException ex = new NullReferenceException();
				return (Vector3)ex;
			}
			return Mouth;
		}
	}

	public float RoundPace
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0156: Expected Obj, but got I
			//IL_0178: Expected Obj, but got I4
			//IL_0057: Expected Obj, but got I4
			//IL_00fe: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaSplashGame current = GillaSplashGame.Current;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = (UnityEngine.Object)current != (UnityEngine.Object)null;
			bool flag4 = !flag3;
			double num = 1.0;
			if (!flag4)
			{
				bool live = current.Live;
				bool flag5 = !live;
				num = 1.0;
				if (!flag5)
				{
					int round = current.Round;
					object obj7 = round - 1;
					object obj8 = ~obj7;
					object obj9 = obj7 & obj8;
					float num2 = fasterEachRound * (float)obj9;
					num = (double)num2 + 1.0;
				}
			}
			return (float)num;
		}
	}

	private GillaSplashPool Pool
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01a8: Expected Obj, but got I4
			//IL_00b5: Expected Obj, but got I
			//IL_00cd: Expected Obj, but got I
			//IL_00dd: Expected Obj, but got I
			//IL_00ff: Expected Obj, but got I4
			//IL_01c6: Expected Obj, but got I
			//IL_01de: Expected I, but got Obj
			//IL_0134: Expected Obj, but got I
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected Obj, but got Unknown
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
			if (pool != null)
			{
				GillaSplashPool gillaSplashPool = pool;
				if ((object)pool == null)
				{
					goto IL_0170;
				}
				int num = PoolIndex;
				if (gillaSplashPool.index == num)
				{
					goto IL_0169;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7990]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC890]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v12+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Predicate<System.__Canon> predicate = default;
			predicate._002Ector((object)this, (IntPtr)obj7);
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC898]");
				object obj10 = 0;
				System.__Canon _Canon = ((List<System.__Canon>)obj9).Find(predicate);
				pool = (GillaSplashPool)(object)_Canon;
				object obj11 = this + 360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				goto IL_0169;
			}
			goto IL_0170;
			IL_0170:
			return (GillaSplashPool)(object)new NullReferenceException();
			IL_0169:
			return pool;
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02e3: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_033a: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I
		//IL_01c4: Expected F4, but got I
		//IL_020f: Expected Obj, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0285: Expected F4, but got I
		//IL_02a1: Expected VT, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			UnityEngine.Object obj7 = default;
			brain = (MonsterBrain)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5 = obj7;
		}
		object obj8 = obj3;
		object obj9 = obj;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5+20]");
		bool flag5 = (UnityEngine.Object)0 != null;
		bool flag6 = !flag5;
		Transform transform = null;
		if (!flag6)
		{
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v11+20]");
			Transform transform2 = ((Component)0).transform;
			transform = transform2;
		}
		object obj12 = this + 368;
		model = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v16+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (model != null)
		{
			Vector3 localPosition = model.localPosition;
			Vector3 vector = default;
			modelRest = vector;
		}
		object obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v9+40]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v9+40]");
		bool flag8 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v9+40]");
		bool flag9 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v9+40]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v9+40]");
		object obj16 = num2 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v9+40]");
		object obj17 = 0 & obj16;
		bool flag10 = (nint)obj17 < 0;
		bool flag11 = flag8 == flag10;
		object obj18 = !flag9;
		object obj19 = flag11 & obj18;
		object obj20 = ~obj19;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAF4]");
			num = 0f;
		}
		float num3 = prowlBack;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A930]");
		float num4 = num3 + 0f;
		killSeconds = num;
		sink = num4;
		Transform transform3 = base.transform;
		Vector3 position = transform3.position;
		lastPos = (Vector3)num;
		_ = prowlBack;
	}

	private void OnEnable()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0031: Expected I4, but got I8
		//IL_005d: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
		object obj = 0;
		object obj2 = obj;
		Fusion.SimulationBehaviourRuntimeFlags flags = (Fusion.SimulationBehaviourRuntimeFlags)((long)((SimulationBehaviour)this).Flags & 0xFFFFFFEFL);
		((SimulationBehaviour)this).Flags = flags;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+A0]");
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
		//IL_0015: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
		object obj = 0;
		object obj2 = obj;
		Fusion.SimulationBehaviourRuntimeFlags flags = ((SimulationBehaviour)this).Flags | (Fusion.SimulationBehaviourRuntimeFlags)0x10;
		((SimulationBehaviour)this).Flags = flags;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+A0]");
		object obj4 = 0;
		bool flag2 = ((List<System.__Canon>)obj4).Remove((System.__Canon)(object)this);
	}

	public override void Spawned()
	{
		//IL_0050: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		int netKills = NetKills;
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		seenKills = netKills;
		if ((object)((SimulationBehaviour)this)._object == null)
		{
			return;
		}
		object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			object obj4 = default;
			object obj3 = obj4 & 1;
			if (obj3 != null)
			{
				byte netPool = NetPool;
				int num = netPool & 0xFF;
				poolIndex = num;
			}
		}
	}

	public unsafe void Splash(Vector3 at, float strength, bool loud)
	{
		//IL_004c: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected VT, but got Unknown
		//IL_00c0: Expected VT, but got I
		//IL_00c0: Expected I4, but got VT
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
		//IL_0036: Expected VT, but got I
		//IL_0036: Expected VT, but got Ref
		IntPtr intPtr = default;
		if (Live)
		{
			bool flag = (byte)(at & 1) != 0;
			NetworkBool at2 = flag;
			object obj = default;
			RPC_Splash((Vector3)at2, strength, (NetworkBool)(&obj), (RpcInfo)(nint)intPtr);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
		Vector3 at3 = (Vector3)(at & 1);
		Splashed(at3, strength, (byte)(int)none != 0, (PlayerRef)(nint)intPtr);
	}

	private unsafe void RPC_Splash(Vector3 at, float strength, NetworkBool loud, RpcInfo info = default(RpcInfo))
	{
		//IL_07cb: Expected Ref, but got VT
		//IL_00d5: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected VT, but got Unknown
		//IL_00bb: Expected VT, but got Ref
		//IL_00bb: Expected VT, but got I4
		//IL_068b: Expected Obj, but got I4
		//IL_0694: Expected VT, but got I4
		//IL_005d: Expected VT, but got Ref
		//IL_005d: Expected VT, but got I
		//IL_0180: Expected Obj, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected I4, but got Unknown
		//IL_01aa: Expected I4, but got I8
		//IL_01dc: Expected I4, but got VT
		//IL_01ea: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I4
		//IL_02fd: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I
		//IL_0345: Expected VT, but got I8
		//IL_0360: Expected Obj, but got I4
		//IL_0383: Expected Obj, but got VT
		//IL_039d: Expected Obj, but got I4
		//IL_03a5: Expected I4, but got VT
		//IL_03ae: Expected F4, but got I4
		//IL_06d7: Expected Obj, but got I4
		//IL_0467: Expected Obj, but got I4
		//IL_0470: Expected Obj, but got I4
		//IL_0478: Expected VT, but got Ref
		//IL_0480: Expected I, but got VT
		//IL_0490: Expected VT, but got I4
		//IL_0499: Expected Obj, but got I4
		//IL_04a1: Expected VT, but got F4
		//IL_04a9: Expected Obj, but got Ref
		//IL_04b2: Expected Obj, but got I4
		//IL_04ba: Expected I4, but got VT
		//IL_0253: Expected Obj, but got I4
		//IL_0258: Expected VT, but got Obj
		//IL_0269: Expected VT, but got I4
		//IL_073e: Expected Ref, but got VT
		//IL_0758: Expected Obj, but got I4
		//IL_087b: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I
		//IL_03de: Expected I4, but got Obj
		//IL_03de: Expected VT, but got I4
		//IL_0406: Expected Obj, but got I
		//IL_040e: Expected VT, but got Obj
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected VT, but got Unknown
		//IL_0280: Invalid comparison between VT and I4
		//IL_07a4: Expected Obj, but got I4
		//IL_076f: Expected Obj, but got I4
		//IL_0777: Expected Obj, but got VT
		//IL_0780: Expected Obj, but got I4
		//IL_0514: Expected Obj, but got I
		//IL_053e: Expected Obj, but got I4
		//IL_029d: Invalid comparison between VT and I4
		//IL_02af: Expected Obj, but got I4
		//IL_02b4: Expected VT, but got Obj
		//IL_02c5: Expected VT, but got I4
		//IL_07e9: Expected Obj, but got I
		//IL_07f9: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I4
		//IL_064d: Expected native int or pointer, but got VT
		//IL_0573: Expected Obj, but got I
		//IL_057c: Expected VT, but got Obj
		//IL_05b7: Expected Obj, but got I4
		//IL_05ef: Expected I4, but got I8
		//IL_0606: Expected VT, but got I4
		//IL_0606: Expected VT, but got I4
		//IL_0626: Expected I, but got Obj
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		RpcInfo rpcInfo = default;
		ref float reference = ref *(float*)rpcInfo;
		object obj;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer;
		int num;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		int num2;
		int num3;
		NetworkBool networkBool;
		Fusion.RpcBuilder rpcBuilder3;
		NullReferenceException ex;
		object obj11;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)((SimulationBehaviour)this)._runner != null)
			{
				object obj4 = bytePayloadSize2 + bytePayloadSize;
				int payloadByteCount = obj4 + bytePayloadSize3;
				Fusion.RpcBuilder rpcBuilder = ((SimulationBehaviour)this)._runner.CreateRpcBuilder(3783123414u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				num = rpcInvokeInfo >> 32;
				object obj5 = num - 522;
				bool flag4 = (nint)obj5 < 2;
				object obj6 = !flag4;
				object obj7 = ~obj6;
				PlayerRef playerRef;
				object obj8;
				if (obj7 == null && num != 518)
				{
					bool flag5 = num != 524;
					obj8 = 0;
					playerRef = (PlayerRef)this;
					playerRef2 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag5)
					{
						goto IL_0375;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						obj8 = 0;
						playerRef = (PlayerRef)this;
						playerRef2 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag6)
						{
							goto IL_0375;
						}
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v66+E4]");
				bool flag7 = (nint)0 == 0;
				object obj10 = !flag7;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8A8]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				obj8 = 0;
				playerRef2 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_0375;
			}
			ex = new NullReferenceException();
			num = bytePayloadSize3;
			num2 = bytePayloadSize2;
			networkBool = loud;
			obj11 = 0;
			rpcBuilder3 = (Fusion.RpcBuilder)0;
			num3 = bytePayloadSize;
			goto IL_06a1;
		}
		goto IL_0005;
		IL_0861:
		object obj12 = default;
		bool flag8 = obj12 == null;
		object obj13 = !flag8;
		object obj14;
		nint num5;
		if (obj13 == null)
		{
			if ((nint)obj14 != 7)
			{
				bool flag9 = obj14 == null;
				object obj15 = !flag9;
				if (obj15 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v16+E4]");
			bool flag10 = (nint)0 == 0;
			object obj18 = !flag10;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v16+A0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v7+18]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8A0]");
				object obj21 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj21);
				object obj22 = obj;
				int num4 = num3 | num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v12+E4]");
				bool flag11 = (nint)0 == 0;
				object obj23 = !flag11;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num2 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num4, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X27_v3+18] (should have been resolved before IL gen)");
				object obj24 = default;
				obj12 = obj24;
				num5 = unchecked((nint)null);
			}
			if (num3 != 0)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			int rawValue = default;
			((NetworkBool*)(nint)loud)->RawValue = rawValue;
			reference = ref *(float*)null;
			goto IL_0005;
		}
		goto IL_06a1;
		IL_083e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0375:
		object obj25 = rpcInvokeInfo >> 32;
		bool flag12 = obj25 == null;
		object obj26 = !flag12;
		int num6 = (int)rpcInvokeInfo2;
		float num7 = 0f;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj27 = 0;
			writer.Write((Vector3)12, (int)obj27);
			float num8 = default;
			writer.Write(num8, 4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E00]");
			object obj28 = 0;
			PlayerRef playerRef = (PlayerRef)obj28;
			NetworkBool value = (NetworkBool)(at & 0xFFFFFFFFL);
			writer.Write(value, 4);
			int num9 = rpcBuilder2.Send();
			num6 = 4;
			num7 = num8;
		}
		rpcBuilder2.Dispose();
		obj12 = 0;
		object obj29 = 0;
		Fusion.RpcBuilder rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder2);
		num5 = (nint)playerRef2;
		num2 = (int)(&writer);
		networkBool = (NetworkBool)num6;
		obj11 = 0;
		rpcBuilder3 = (Fusion.RpcBuilder)num7;
		ex = (NullReferenceException)(&rpcBuilder2);
		obj14 = 7;
		num3 = (int)rpcInvokeInfo;
		goto IL_0861;
		IL_06a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj30;
		OutOfMemoryException ex2;
		if ((nint)obj11 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj12 = 1;
			obj30 = obj29;
		}
		else
		{
			bool flag13 = (nint)obj11 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_083e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj31 = default;
			obj30 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj29 = obj31;
		}
		((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
		bool flag14 = obj30 == null;
		object obj32 = !flag14;
		if (obj32 == null)
		{
			obj11 = 0;
			ex = (NullReferenceException)rpcBuilder4;
			obj14 = 0;
			goto IL_0861;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj11 = 0;
		goto IL_083e;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loud @ X2 (Fusion.NetworkBool)+18]");
		object obj33 = (nint)0 & (nint)1;
		bool flag15 = obj33 == null;
		object obj34 = !flag15;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loud @ X2 (Fusion.NetworkBool)+4]");
			object obj35 = default;
			if (!Believable((PlayerRef)0, (Vector3)(&obj35), ref reference))
			{
				return;
			}
		}
		NetworkBool networkBool2 = (NetworkBool)(at & 0xFFFFFFFFL);
		bool flag16 = networkBool2;
		bool flag17 = flag16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loud @ X2 (Fusion.NetworkBool)+4]");
		Splashed((Vector3)flag17, strength, loud: false, (PlayerRef)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
	}

	private unsafe bool Believable(PlayerRef from, Vector3 at, ref float strength)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0310: Expected Obj, but got I4
		//IL_002e: Expected VT, but got I4
		//IL_005d: Expected Obj, but got F4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0098: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected VT, but got Unknown
		//IL_014d: Invalid comparison between F4 and I4
		//IL_015c: Expected F8, but got I4
		//IL_0326: Expected native int or pointer, but got VT
		//IL_0345: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I4
		//IL_01e7: Expected VT, but got I4
		//IL_0284: Expected Obj, but got I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected VT, but got Unknown
		//IL_02c9: Expected VT, but got I4
		//IL_02e6: Expected I4, but got Obj
		//IL_0220: Expected VT, but got I4
		//IL_023c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (NetworkApe.Sane((Vector3)0))
		{
			object obj4 = ~at.x;
			object obj5 = 0x7F800000 & obj4;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef playerRef = (PlayerRef)(from & 0xFFFFFFFFL);
				if (GillaNetGuard.Spend(playerRef, (GillaNetGuard.Kind)3, 12f, 24f))
				{
					float x = at.x;
					bool flag3 = at.x < 0f;
					double num = 0.0;
					if (!flag3)
					{
						bool flag4 = !((double)at.x > 1.0);
						num = at.x;
						if (!flag4)
						{
							num = 1.0;
						}
					}
					((Vector3*)(nint)at)->x = (float)num;
					GillaSplashPool gillaSplashPool = Pool;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj9 = 0;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v9+E4]");
					bool flag5 = (nint)0 == 0;
					object obj11 = !flag5;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = gillaSplashPool != null;
					bool flag7 = !flag6;
					Vector3 vector = (Vector3)0;
					float num2 = default;
					double num3 = default;
					if (!flag7)
					{
						if ((object)gillaSplashPool == null)
						{
							NullReferenceException ex = new NullReferenceException();
							return (byte)(int)ex != 0;
						}
						bool flag8 = gillaSplashPool.Over((Vector3)0);
						bool flag9 = !flag8;
						vector = (Vector3)0;
						x = num2;
						num = num3;
						if (flag9)
						{
							goto IL_02d2;
						}
					}
					object obj12 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v18+E4]");
					bool flag10 = (nint)0 == 0;
					object obj13 = !flag10;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerRef playerRef2 = (PlayerRef)(from & 0xFFFFFFFFL);
					return GillaNetGuard.Near(playerRef2, (Vector3)0, (float)num3, num2);
				}
			}
		}
		goto IL_02d2;
		IL_02d2:
		return false;
	}

	private void Splashed(Vector3 at, float strength, bool loud, PlayerRef from)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected VT, but got Unknown
		//IL_0082: Expected VT, but got I8
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected VT, but got Unknown
		//IL_00a2: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 at2 = (Vector3)(at & 1);
		GillaSplashDirector.Show(at2, strength, entering: false);
		if (Authority)
		{
			Vector3 at3 = (Vector3)((loud ? 1 : 0) & 0xFFFFFFFFL);
			PlayerRef playerRef = (PlayerRef)(at & 1);
			Heard(at3, playerRef, (byte)(int)from != 0);
		}
	}

	private void Heard(Vector3 at, PlayerRef from, bool loud)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04a3: Expected Obj, but got I4
		//IL_058f: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I4
		//IL_0260: Expected Obj, but got I
		//IL_028a: Expected Obj, but got I4
		//IL_0500: Expected Obj, but got I
		//IL_052a: Expected Obj, but got I4
		//IL_0562: Expected Obj, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			return;
		}
		Vector3 vector = default;
		heardAt = vector;
		heardFrom = (PlayerRef)at;
		float num = (heardTime = Time.time);
		if (state == 4)
		{
			return;
		}
		if (state != 3)
		{
			bool flag2 = state == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				target = vector;
				quarry = (PlayerRef)at;
				float time = Time.time;
				followAt = 0f;
				quarryHeard = time;
				state = 1;
				stateT = 0f;
				Screech();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num2;
			if (quarry == (PlayerRef)at)
			{
				target = vector;
				float time2 = Time.time;
				num2 = repathAt;
				quarryHeard = time2;
			}
			else
			{
				Transform transform = base.transform;
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v15+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v18+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Transform transform2 = base.transform;
				Vector3 position2 = transform2.position;
				object obj15 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v24+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float time3 = Time.time;
				float num3 = time3 - quarryHeard;
				if (!(num3 > lostAfter))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+130]");
					object obj18 = default;
					object obj17 = 0 - obj18;
					object obj19 = obj18 - obj18;
					object obj20 = obj17 * obj17;
					object obj21 = obj19 * obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num4 = (float)vector - num;
					float num5 = num4 * num4;
					float num6 = num5 + (float)obj21;
					float num7 = (float)obj20 * switchShare;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					if (!(num6 < num7))
					{
						object obj22 = from & 1;
						if (obj22 == null || !(num6 < switchNear))
						{
							return;
						}
					}
				}
				target = vector;
				quarry = (PlayerRef)at;
				float time4 = Time.time;
				num2 = repathAt;
				quarryHeard = time4;
				followAt = 0f;
			}
			float time5 = Time.time;
			float num8 = time5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			float num9 = num8 + 0f;
			if (num2 < num9)
			{
				num9 = num2;
			}
			repathAt = num9;
		}
		else
		{
			target = vector;
			quarry = (PlayerRef)at;
			float time6 = Time.time;
			followAt = 0f;
			quarryHeard = time6;
			state = 2;
			stateT = 0f;
			repathAt = 0f;
		}
	}

	private void After(Vector3 at, PlayerRef from)
	{
		Vector3 vector = default;
		target = vector;
		quarry = (PlayerRef)at;
		float time = Time.time;
		followAt = 0f;
		quarryHeard = time;
	}

	private unsafe bool QuarryAt(GillaSplashPool p, out Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_07f1: Expected Ref, but got VT
		//IL_081b: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I4
		//IL_07da: Expected I4, but got Obj
		//IL_0202: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_0839: Expected Obj, but got I
		//IL_0851: Expected Obj, but got I
		//IL_0861: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_0344: Expected Obj, but got I4
		//IL_03ee: Expected Obj, but got I8
		//IL_0444: Expected Obj, but got I4
		//IL_08aa: Expected Obj, but got I4
		//IL_08c0: Expected Obj, but got I
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected Obj, but got Unknown
		//IL_0528: Expected Obj, but got I
		//IL_0542: Expected Obj, but got I8
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected Obj, but got Unknown
		//IL_0559: Expected Obj, but got I4
		//IL_057a: Expected Obj, but got I4
		//IL_090c: Expected Obj, but got I4
		//IL_05a9: Expected Obj, but got I4
		//IL_05d0: Expected VT, but got I4
		//IL_05fe: Expected Obj, but got I4
		//IL_064b: Expected F4, but got I
		//IL_065b: Expected Obj, but got I
		//IL_0729: Expected Obj, but got I
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got Unknown
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected Obj, but got Unknown
		//IL_0764: Expected Obj, but got I4
		//IL_06b0: Expected F4, but got I
		//IL_06b0: Expected VT, but got I4
		//IL_06ce: Expected Obj, but got I4
		//IL_06de: Expected F4, but got I
		//IL_06ee: Expected Obj, but got I
		//IL_0706: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+130]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)target;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = p == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
			if (quarry != none)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v13+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				NetworkApe networkApe = NetworkApe.Find(quarry);
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v13+E4]");
				bool flag6 = (nint)0 == 0;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = (UnityEngine.Object)networkApe == (UnityEngine.Object)null;
				bool flag8 = !flag7;
				object obj13 = !flag8;
				if (obj13 == null)
				{
					if ((object)networkApe != null)
					{
						object obj14 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v22+E4]");
						bool flag9 = (nint)0 == 0;
						object obj15 = !flag9;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag10 = networkApe.head == null;
						bool flag11 = !flag10;
						object obj16 = !flag11;
						if (obj16 != null)
						{
							goto IL_0780;
						}
						if ((object)networkApe.head != null)
						{
							Vector3 position = networkApe.head.position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj17 = 0;
							object obj18 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v20+A0]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							object obj21 = default;
							if (obj21 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v30+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v21+2C]");
									nint num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
									object obj22 = num * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v21+24]");
									object obj24 = default;
									object obj23 = 0 * obj24;
									object obj26 = default;
									object obj25 = obj26 + obj22;
									float num2 = (float)obj24 + (float)obj23;
									object obj27 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v33+E4]");
									bool flag12 = (nint)0 == 0;
									object obj28 = !flag12;
									if (obj28 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag13 = networkApe.leftHand != null;
									bool flag14 = !flag13;
									UnityEngine.Object obj29 = null;
									if (!flag14)
									{
										if ((object)networkApe.leftHand == null)
										{
											goto IL_07cc;
										}
										Vector3 position2 = networkApe.leftHand.position;
										obj29 = null;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v30+18]");
									object obj30 = 0 & 0xFFFFFFFEL;
									if (obj30 != null)
									{
										object obj31 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v38+E4]");
										bool flag15 = (nint)0 == 0;
										object obj32 = !flag15;
										if (obj32 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag16 = networkApe.rightHand != null;
										bool flag17 = !flag16;
										object obj34 = default;
										object obj33 = obj34;
										UnityEngine.Object obj35 = null;
										if (!flag17)
										{
											if ((object)networkApe.rightHand == null)
											{
												goto IL_07cc;
											}
											Vector3 position3 = networkApe.rightHand.position;
											obj33 = obj34;
											obj35 = null;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v30+18]");
										bool flag18 = (nint)0 < (nint)2;
										object obj36 = !flag18;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v30+18]");
										object obj37 = -2;
										bool flag19 = obj37 == null;
										object obj38 = ~obj36;
										object obj39 = obj38 | flag19;
										if (obj39 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v30+18]");
											if ((nint)0 < (nint)1)
											{
												goto IL_0780;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
											object obj40 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v30+18]");
											object obj41 = 0 & 0xFFFFFFFFL;
											object obj42 = obj21 + 40;
											object obj43 = 0;
											object obj44 = obj34;
											object obj45 = obj25;
											object obj47 = default;
											object obj46 = obj47;
											object obj48 = 0;
											while (true)
											{
												bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj43) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41);
												object obj49 = !flag20;
												if (obj49 != null)
												{
													break;
												}
												object obj50 = obj40;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v44+E4]");
												bool flag21 = (nint)0 == 0;
												object obj51 = !flag21;
												if (obj51 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												GillaSplashPool gillaSplashPool = GillaSplashPool.At((Vector3)0);
												object obj52 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v34+E4]");
												bool flag22 = (nint)0 == 0;
												object obj53 = !flag22;
												if (obj53 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool flag23 = gillaSplashPool == p;
												bool flag24 = !flag23;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X26_v6-8]");
												num2 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X26_v6-4]");
												obj44 = 0;
												obj45 = obj42;
												obj35 = p;
												if (!flag24)
												{
													if ((object)p == null)
													{
														goto IL_07cc;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X26_v6-8]");
													bool flag25 = p.In((Vector3)0, 0f);
													bool flag26 = !flag25;
													object obj54 = !flag26;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X26_v6-8]");
													num2 = 0f;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X26_v6-4]");
													obj44 = 0;
													obj45 = obj42;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
													obj46 = 0;
													obj35 = null;
													if (obj54 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X26_v6-8]");
														reference = ref *(Vector3*)null;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X26_v6-4]");
														_ = 0;
														return true;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v30+18]");
												obj41 = 0;
												obj43++;
												obj42 += 12;
												object obj55 = obj43;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v30+18]");
												bool flag27 = (nint)obj55 < 0;
												obj48 = 0;
												if (!flag27)
												{
													return false;
												}
											}
										}
									}
								}
								IndexOutOfRangeException ex = new IndexOutOfRangeException();
							}
						}
					}
					goto IL_07cc;
				}
			}
		}
		goto IL_0780;
		IL_07cc:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_0780:
		return false;
	}

	public unsafe void Catch()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I4
		//IL_02b2: Expected VT, but got Ref
		//IL_0207: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_025f: Expected Obj, but got I4
		if (state == 4)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v7+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v4 (UnityEngine.Object)+A9]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v10+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform backTo = Sent();
		if (!((KillCam)obj5).Begin(brain, backTo))
		{
			return;
		}
		brain.PlayKill();
		bool live = Live;
		bool flag6 = !live;
		object obj13 = 0;
		if (!flag6)
		{
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			if ((object)((SimulationBehaviour)this)._object != null)
			{
				object obj14 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
				bool flag7 = obj14 == null;
				object obj15 = !flag7;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
					object obj17 = default;
					object obj16 = obj17 & 1;
					bool flag8 = obj16 == null;
					obj13 = 0;
					if (!flag8)
					{
						goto IL_026d;
					}
				}
			}
			object obj18 = default;
			RPC_Caught((RpcInfo)(&obj18));
			return;
		}
		goto IL_026d;
		IL_026d:
		PlayerRef who;
		if (Live)
		{
			who = ((SimulationBehaviour)this)._runner.LocalPlayer;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v22+E4]");
			bool flag9 = (nint)0 == 0;
			object obj21 = !flag9;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			who = PlayerRef.None;
		}
		StartKill(who);
	}

	private unsafe static Transform Sent()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I
		//IL_03cf: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_03f5: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I4
		//IL_0487: Expected Obj, but got I
		//IL_04a9: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_02b5: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_04cf: Expected Obj, but got I
		//IL_04f1: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got I4
		//IL_0245: Expected Obj, but got I4
		//IL_02a0: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8158]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashGame current = GillaSplashGame.Current;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v9+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)current != (UnityEngine.Object)null;
		bool flag6 = !flag5;
		object obj13 = 0;
		UnityEngine.Object obj14 = null;
		object obj18;
		if (!flag6)
		{
			if ((object)current == null)
			{
				goto IL_0387;
			}
			bool live = current.Live;
			bool flag7 = !live;
			obj13 = 0;
			obj14 = null;
			if (!flag7)
			{
				object obj15 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v38+E4]");
				bool flag8 = (nint)0 == 0;
				object obj16 = !flag8;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag9 = (UnityEngine.Object)obj11 != null;
				bool flag10 = !flag9;
				obj13 = 0;
				obj14 = null;
				if (!flag10)
				{
					if (obj11 == null)
					{
						goto IL_0387;
					}
					object obj17 = obj8;
					obj18 = obj11 + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v42+E4]");
					bool flag11 = (nint)0 == 0;
					object obj19 = !flag11;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag12 = (UnityEngine.Object)obj18 != null;
					bool flag13 = !flag12;
					obj13 = 0;
					obj14 = null;
					if (!flag13)
					{
						byte phase = current.Phase;
						int num = phase & 0xFF;
						if (num == 2)
						{
							object obj20 = default;
							current.RPC_Died((RpcInfo)(&obj20));
						}
						goto IL_0425;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
		object obj21 = 0;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v19+E4]");
		bool flag14 = (nint)0 == 0;
		object obj23 = !flag14;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v23+E4]");
		bool flag15 = (nint)0 == 0;
		object obj25 = !flag15;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj21;
		}
		object obj26 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v23+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v17+E4]");
		bool flag16 = (nint)0 == 0;
		object obj28 = !flag16;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = (UnityEngine.Object)obj27 != null;
		bool flag18 = !flag17;
		Transform result = null;
		if (!flag18)
		{
			if (obj27 == null)
			{
				goto IL_0387;
			}
			obj18 = obj27 + 80;
			goto IL_0425;
		}
		goto IL_046a;
		IL_046a:
		return result;
		IL_0387:
		return (Transform)(object)new NullReferenceException();
		IL_0425:
		result = (Transform)obj18;
		goto IL_046a;
	}

	private unsafe void RPC_Caught(RpcInfo info = default(RpcInfo))
	{
		//IL_0048: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I4
		//IL_04f7: Expected Obj, but got I4
		//IL_00db: Expected I4, but got I8
		//IL_010d: Expected Obj, but got VT
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0135: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I
		//IL_0276: Expected VT, but got I8
		//IL_0291: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got VT
		//IL_02ce: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_0311: Expected VT, but got Ref
		//IL_0319: Expected I, but got VT
		//IL_0322: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got Ref
		//IL_0333: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got VT
		//IL_0184: Expected Obj, but got I4
		//IL_0189: Expected VT, but got Obj
		//IL_0192: Expected VT, but got I4
		//IL_0599: Expected Ref, but got VT
		//IL_05b3: Expected Obj, but got I4
		//IL_06ce: Expected Obj, but got I4
		//IL_01b1: Invalid comparison between VT and I4
		//IL_05ff: Expected Obj, but got I4
		//IL_05ca: Expected Obj, but got I4
		//IL_05d2: Expected Obj, but got VT
		//IL_05db: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I
		//IL_03bf: Expected Obj, but got I4
		//IL_01ce: Invalid comparison between VT and I4
		//IL_01e0: Expected Obj, but got I4
		//IL_01e5: Expected VT, but got Obj
		//IL_01ee: Expected VT, but got I4
		//IL_063c: Expected Obj, but got I
		//IL_064c: Expected Obj, but got I
		//IL_0377: Expected Obj, but got I4
		//IL_04c9: Expected native int or pointer, but got VT
		//IL_04d6: Expected native int or pointer, but got VT
		//IL_04e0: Expected I, but got Obj
		//IL_03f4: Expected Obj, but got I
		//IL_03fd: Expected VT, but got Obj
		//IL_0416: Expected VT, but got Obj
		//IL_0438: Expected Obj, but got I4
		//IL_0470: Expected I4, but got I8
		//IL_0487: Expected VT, but got I4
		object obj;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer = default;
		object obj4 = default;
		RpcInvokeInfo rpcInvokeInfo2;
		NullReferenceException ex;
		object obj11;
		if (!NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj = 0;
			networkRunner = ((SimulationBehaviour)this)._runner;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(3532389391u, 0, (NetworkBehaviour)this, invalid);
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
				if (obj7 == null && (nint)obj4 != 518)
				{
					bool flag3 = (nint)obj4 != 524;
					obj8 = 0;
					playerRef = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef2 = invalid;
					if (flag3)
					{
						goto IL_02a6;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag4 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						obj8 = 0;
						playerRef = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef2 = invalid;
						if (flag4)
						{
							goto IL_02a6;
						}
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v58+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8B8]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				obj8 = 0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef2 = none;
				goto IL_02a6;
			}
			ex = new NullReferenceException();
			obj11 = 0;
			goto IL_04fc;
		}
		goto IL_0005;
		IL_06b4:
		nint num = default;
		bool flag6 = num == 0;
		object obj12 = !flag6;
		object obj13;
		nint num2;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v11+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v11+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+18]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8B0]");
				object obj20 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj20);
				object obj21 = obj;
				RpcInvokeInfo invokeInfo = (RpcInvokeInfo)((object)networkRunner | obj4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v12+E4]");
				bool flag9 = (nint)0 == 0;
				object obj22 = !flag9;
				if (obj22 == null)
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
			num2 = unchecked((nint)null);
			goto IL_0005;
		}
		goto IL_04fc;
		IL_0691:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_02a6:
		object obj23 = rpcInvokeInfo >> 32;
		bool flag10 = obj23 == null;
		object obj24 = !flag10;
		if (obj24 == null)
		{
			int num3 = rpcBuilder2.Send();
		}
		rpcBuilder2.Dispose();
		num = 0;
		object obj25 = 0;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		num2 = (nint)rpcInvokeInfo2;
		obj11 = 0;
		ex = (NullReferenceException)(&rpcBuilder2);
		obj13 = 7;
		networkRunner = (NetworkRunner)rpcInvokeInfo;
		goto IL_06b4;
		IL_04fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj26;
		OutOfMemoryException ex2;
		if ((nint)obj11 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj26 = obj25;
			num = 1;
		}
		else
		{
			bool flag11 = (nint)obj11 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag11)
			{
				goto IL_0691;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj27 = default;
			obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj25 = obj27;
		}
		((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
		bool flag12 = obj26 == null;
		object obj28 = !flag12;
		if (obj28 == null)
		{
			obj11 = 0;
			ex = (NullReferenceException)rpcBuilder3;
			obj13 = 0;
			goto IL_06b4;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj11 = 0;
		goto IL_0691;
		IL_0005:
		if (state != 4)
		{
			StartKill(info.Source);
		}
	}

	private unsafe void StartKill(PlayerRef who)
	{
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected Obj, but got VT
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got I
		//IL_0517: Expected Obj, but got I
		//IL_0539: Expected Obj, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got VT
		//IL_0599: Expected Obj, but got I
		//IL_05b5: Expected I, but got Obj
		//IL_00eb: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected VT, but got I4
		//IL_05ec: Expected I, but got Obj
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected Obj, but got I
		//IL_062b: Expected VT, but got I4
		//IL_01b2: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I4
		//IL_07c8: Expected Obj, but got I
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got I
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got I
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got I4
		//IL_048d: Expected Obj, but got I4
		//IL_0861: Expected Obj, but got I
		//IL_0869: Expected VT, but got Obj
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected Ref, but got Unknown
		//IL_088c: Expected Obj, but got I4
		//IL_0256: Expected Obj, but got I4
		//IL_0295: Expected I, but got Obj
		//IL_04ac: Expected Obj, but got I4
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Unknown
		//IL_063f: Expected I, but got Obj
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected Obj, but got I4
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got I4
		//IL_031f: Invalid comparison between Obj and VT
		//IL_032d: Expected I, but got Obj
		//IL_06ef: Expected Obj, but got I4
		//IL_074e: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I4
		//IL_03b4: Expected I, but got Obj
		//IL_03de: Expected I, but got Obj
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got I4
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got I
		//IL_0443: Expected VT, but got I4
		//IL_0448: Expected I, but got Obj
		state = 4;
		List<Vector3> list = path;
		stateT = 0f;
		speed = 0f;
		bool flag = path == null;
		UnityEngine.Object obj2 = default;
		UnityEngine.Object obj = obj2;
		Enumerator<, > val = (Enumerator<, >)0;
		UnityEngine.Object obj3 = (UnityEngine.Object)who;
		object obj4;
		object obj22;
		float dt = default;
		nint num2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
			Enumerator<, > val2 = (Enumerator<, >)((nint)0 + (nint)1);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj4 = 0;
			victim = who;
			int num = kills + 1;
			kills = num;
			bool live = Live;
			bool flag2 = !live;
			val = (Enumerator<, >)0;
			PlayerRef playerRef = who;
			if (flag2)
			{
				goto IL_04e7;
			}
			bool flag3 = (object)((SimulationBehaviour)this)._runner == null;
			obj = obj2;
			val = (Enumerator<, >)0;
			obj3 = (UnityEngine.Object)who;
			if (!flag3)
			{
				PlayerRef localPlayer = ((SimulationBehaviour)this)._runner.LocalPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v24+E4]");
				bool flag4 = (nint)0 == 0;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = localPlayer == who;
				val = (Enumerator<, >)0;
				playerRef = (PlayerRef)0;
				if (flag5)
				{
					goto IL_04e7;
				}
				bool flag6 = (object)brain == null;
				obj = obj2;
				val = (Enumerator<, >)0;
				obj3 = null;
				if (!flag6)
				{
					brain.PlayKill();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
					object obj8 = 0;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v42+E4]");
					bool flag7 = (nint)0 == 0;
					object obj10 = !flag7;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj9 = obj8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v42+A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v26+8]");
					bool flag8 = (nint)0 == 0;
					obj = obj2;
					val = (Enumerator<, >)0;
					obj3 = null;
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v26+8]");
						Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
						object obj12 = 0;
						float num3 = default;
						object obj26 = default;
						object obj20;
						Enumerator<, > val3;
						while (true)
						{
							if (val.MoveNext())
							{
								object obj13 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v49+E4]");
								bool flag9 = (nint)0 == 0;
								object obj14 = !flag9;
								if (obj14 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag10 = obj2 != null;
								bool flag11 = !flag10;
								num2 = unchecked((nint)null);
								if (flag11)
								{
									continue;
								}
								if ((object)obj2 == null)
								{
									break;
								}
								object obj15 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ stack_-68_v9 (UnityEngine.Object)+6D0]");
								UnityEngine.Object obj16 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X0_v54+E4]");
								bool flag12 = (nint)0 == 0;
								object obj17 = !flag12;
								if (obj17 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag13 = (object)obj16 != (object)who;
								num2 = unchecked((nint)null);
								if (flag13)
								{
									continue;
								}
								object obj18 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ stack_-68_v9 (UnityEngine.Object)+68]");
								obj16 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v56+E4]");
								bool flag14 = (nint)0 == 0;
								object obj19 = !flag14;
								if (obj19 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag15 = obj16 != null;
								bool flag16 = !flag15;
								num2 = unchecked((nint)null);
								if (flag16)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ stack_-68_v9 (UnityEngine.Object)+68]");
								bool flag17 = (nint)0 == 0;
								num2 = unchecked((nint)null);
								obj = null;
								val = (Enumerator<, >)num3;
								obj20 = 0;
								dt = num3;
								val3 = (Enumerator<, >)(ref val);
								obj3 = null;
								val2 = (Enumerator<, >)(ref val);
								if (flag17)
								{
									goto IL_069f;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ stack_-68_v9 (UnityEngine.Object)+68]");
								Vector3 position = ((Transform)0).position;
								Face((Vector3)0, num3);
								num2 = unchecked((nint)null);
							}
							obj = null;
							val = (Enumerator<, >)num3;
							obj20 = 0;
							dt = num3;
							val3 = (Enumerator<, >)(ref val);
							val2 = (Enumerator<, >)(ref val);
							object obj21 = 0;
							obj22 = 0;
							goto IL_0851;
							IL_0851:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
							object obj23 = 0;
							playerRef = (PlayerRef)obj23;
							((Enumerator<, >*)val3)->Dispose();
							bool flag18 = obj21 == null;
							object obj24 = !flag18;
							obj3 = (UnityEngine.Object)obj23;
							if (obj24 == null)
							{
								bool flag19 = (object)obj == null;
								object obj25 = !flag19;
								obj3 = (UnityEngine.Object)obj23;
								OutOfMemoryException ex = (OutOfMemoryException)val3;
								if (obj25 == null)
								{
									goto IL_04ca;
								}
							}
							else
							{
								OutOfMemoryException ex = new OutOfMemoryException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							goto IL_069f;
							IL_069f:
							NullReferenceException ex2 = new NullReferenceException();
							if ((nint)obj3 == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj = (UnityEngine.Object)1;
								obj21 = obj20;
							}
							else
							{
								if ((nint)obj3 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								obj21 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj20 = obj26;
							}
							obj22 = 1;
							goto IL_0851;
						}
						NullReferenceException ex3 = new NullReferenceException();
						num2 = unchecked((nint)null);
						obj = null;
						val = (Enumerator<, >)num3;
						obj20 = 0;
						dt = num3;
						val3 = (Enumerator<, >)(ref val);
						obj3 = null;
						val2 = (Enumerator<, >)(ref val);
					}
				}
			}
		}
		goto IL_0677;
		IL_04ca:
		if (obj22 != null)
		{
			goto IL_04e7;
		}
		return;
		IL_0677:
		throw new NullReferenceException();
		IL_04e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj27 = 0;
		object obj28 = obj4;
		object obj29 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v17+A0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v27+E4]");
		bool flag20 = (nint)0 == 0;
		object obj31 = !flag20;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)obj30 != null))
		{
			return;
		}
		object obj32 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v19+A0]");
		object obj33 = 0;
		object obj34 = obj33;
		bool flag21 = obj33 == null;
		num2 = unchecked((nint)null);
		obj = obj;
		obj3 = null;
		if (!flag21)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v21+20]");
			bool flag22 = (nint)0 == 0;
			num2 = unchecked((nint)null);
			obj = obj;
			obj3 = null;
			if (!flag22)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v21+20]");
				Vector3 position2 = ((Transform)0).position;
				Face((Vector3)0, dt);
				return;
			}
		}
		goto IL_0677;
	}

	private void Begin(byte s)
	{
		int num = s & 0xFF;
		bool flag = num == 0;
		state = s;
		stateT = 0f;
		if (flag)
		{
			float num2 = UnityEngine.Random.Range(0.5f, 2.5f);
			wait = num2;
		}
	}

	private void Update()
	{
		//IL_0058: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I4
		MonsterBrain monsterBrain = brain;
		monsterBrain.Puppet__BackingField = true;
		float deltaTime = Time.deltaTime;
		if (Authority)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v9+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Think(deltaTime);
			}
		}
		Show(deltaTime);
	}

	private unsafe void Think(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1546: Expected Obj, but got I4
		//IL_0071: Expected F4, but got I
		//IL_020f: Expected F4, but got I4
		//IL_0218: Expected VT, but got I4
		//IL_02de: Expected VT, but got I4
		//IL_0967: Invalid comparison between F4 and I4
		//IL_0978: Expected Obj, but got I4
		//IL_0981: Invalid comparison between F4 and I4
		//IL_099c: Expected Obj, but got I4
		//IL_09b2: Expected F4, but got I4
		//IL_09bb: Expected VT, but got I4
		//IL_0b63: Expected F8, but got I4
		//IL_08f6: Expected VT, but got I4
		//IL_15d2: Invalid comparison between F4 and I4
		//IL_15e1: Invalid comparison between F4 and I4
		//IL_15f6: Expected Obj, but got F4
		//IL_1603: Expected Obj, but got F4
		//IL_165f: Expected Obj, but got I4
		//IL_1667: Unknown result type (might be due to invalid IL or missing references)
		//IL_166c: Expected Obj, but got Unknown
		//IL_0246: Expected F4, but got VT
		//IL_0246: Expected VT, but got I4
		//IL_0261: Expected F4, but got I4
		//IL_0277: Expected VT, but got I4
		//IL_0301: Expected Obj, but got I
		//IL_032b: Expected Obj, but got I4
		//IL_07a7: Expected F8, but got I
		//IL_07c2: Expected F4, but got I4
		//IL_07cb: Expected VT, but got I4
		//IL_09f8: Expected Obj, but got I4
		//IL_17e8: Invalid comparison between F4 and I4
		//IL_17fb: Expected Obj, but got F4
		//IL_1803: Unknown result type (might be due to invalid IL or missing references)
		//IL_1808: Expected Obj, but got Unknown
		//IL_1870: Expected Obj, but got I4
		//IL_0689: Expected Obj, but got I
		//IL_06b3: Expected Obj, but got I4
		//IL_0530: Expected Obj, but got I4
		//IL_036a: Expected VT, but got I4
		//IL_00d1: Expected F4, but got I4
		//IL_00da: Expected VT, but got I4
		//IL_0a3b: Expected F4, but got I4
		//IL_0a44: Expected VT, but got I4
		//IL_0573: Expected VT, but got I4
		//IL_18a0: Expected Obj, but got I4
		//IL_18b8: Invalid comparison between F4 and I4
		//IL_18da: Expected Obj, but got I4
		//IL_159b: Expected F4, but got I4
		//IL_15a4: Expected VT, but got I4
		//IL_172b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1730: Expected Obj, but got Unknown
		//IL_1740: Expected Obj, but got I
		//IL_176a: Expected Obj, but got I4
		//IL_0849: Expected Obj, but got I
		//IL_087d: Expected Obj, but got I4
		//IL_0112: Expected F4, but got I4
		//IL_011b: Expected VT, but got I4
		//IL_0733: Invalid comparison between F4 and I
		//IL_03d5: Expected VT, but got Ref
		//IL_05a6: Expected Obj, but got I
		//IL_17cc: Expected F4, but got I4
		//IL_17d5: Expected VT, but got I4
		//IL_0a8a: Expected VT, but got I4
		//IL_0a98: Expected VT, but got F4
		//IL_077a: Expected Obj, but got I4
		//IL_03fb: Expected Obj, but got I
		//IL_040b: Expected VT, but got I
		//IL_0422: Expected Obj, but got VT
		//IL_0438: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I4
		//IL_0ace: Expected Obj, but got I
		//IL_0ae1: Expected VT, but got I4
		//IL_0ae1: Expected VT, but got I4
		//IL_0e1f: Expected Obj, but got I4
		//IL_0e27: Expected VT, but got Obj
		//IL_178e: Expected Obj, but got I
		//IL_17a2: Expected F4, but got I4
		//IL_05e2: Expected Obj, but got I
		//IL_05ff: Expected VT, but got I4
		//IL_05ff: Expected VT, but got I4
		//IL_0613: Expected Obj, but got I
		//IL_061b: Expected VT, but got Obj
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04b6: Invalid comparison between Obj and F8
		//IL_0bd3: Expected Obj, but got I
		//IL_0c07: Expected Obj, but got I4
		//IL_01ce: Expected F8, but got I4
		//IL_0afa: Expected Obj, but got I
		//IL_0b02: Expected VT, but got Obj
		//IL_0cbe: Invalid comparison between F4 and I
		//IL_0ccf: Expected VT, but got Obj
		//IL_0646: Expected F4, but got I
		//IL_16bc: Expected Obj, but got VT
		//IL_16dd: Expected VT, but got Ref
		//IL_0c36: Expected F8, but got I4
		//IL_0b44: Expected F4, but got I4
		//IL_0b4d: Expected F8, but got I4
		//IL_0e51: Expected Obj, but got I4
		//IL_0e59: Expected VT, but got Obj
		//IL_1b8a: Invalid comparison between F4 and I4
		//IL_1b9d: Expected Obj, but got F4
		//IL_1ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1baa: Expected Obj, but got Unknown
		//IL_1bdc: Expected Obj, but got I4
		//IL_0ced: Expected Obj, but got I
		//IL_0cf5: Expected VT, but got Obj
		//IL_0eab: Invalid comparison between F4 and I4
		//IL_0ebe: Expected Obj, but got F4
		//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Expected Obj, but got Unknown
		//IL_0efd: Expected Obj, but got I4
		//IL_0d33: Expected Obj, but got I
		//IL_0d5d: Expected Obj, but got I4
		//IL_1c0c: Expected Obj, but got I4
		//IL_1c24: Invalid comparison between F8 and I4
		//IL_1c46: Expected Obj, but got I4
		//IL_1a59: Expected Obj, but got I4
		//IL_1a71: Invalid comparison between F4 and I4
		//IL_1a91: Expected Obj, but got I4
		//IL_0f34: Expected F4, but got I4
		//IL_1ac7: Expected VT, but got Obj
		//IL_1f67: Expected Obj, but got I
		//IL_1f91: Expected Obj, but got I4
		//IL_1d7c: Expected Obj, but got I
		//IL_1d9e: Expected Obj, but got I
		//IL_1dd2: Expected Obj, but got I
		//IL_0fd1: Expected Obj, but got I4
		//IL_0feb: Invalid comparison between F4 and I4
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Expected Obj, but got Unknown
		//IL_1922: Expected Obj, but got I
		//IL_1c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca1: Expected Obj, but got Unknown
		//IL_1ca9: Expected Obj, but got F8
		//IL_1d03: Invalid comparison between F8 and I4
		//IL_1d16: Expected Obj, but got F8
		//IL_1d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d23: Expected Obj, but got Unknown
		//IL_1d55: Expected Obj, but got I4
		//IL_1092: Expected VT, but got I4
		//IL_1252: Expected VT, but got I4
		//IL_1252: Expected VT, but got I4
		//IL_10a9: Expected VT, but got I4
		//IL_19b4: Invalid comparison between F8 and I4
		//IL_19c3: Invalid comparison between F8 and I4
		//IL_19d8: Expected Obj, but got F8
		//IL_19e7: Expected Obj, but got F8
		//IL_1a1c: Expected Obj, but got I4
		//IL_1a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a29: Expected Obj, but got Unknown
		//IL_1e18: Expected Obj, but got I4
		//IL_1e30: Invalid comparison between F8 and I4
		//IL_1e52: Expected Obj, but got I4
		//IL_10be: Expected Obj, but got I
		//IL_10c6: Expected VT, but got Obj
		//IL_10df: Expected VT, but got I4
		//IL_1b32: Invalid comparison between F4 and I
		//IL_1fc9: Expected Obj, but got I4
		//IL_130c: Invalid comparison between F4 and I4
		//IL_131b: Invalid comparison between F4 and I4
		//IL_1333: Expected Obj, but got F4
		//IL_1345: Expected Obj, but got F4
		//IL_137a: Expected Obj, but got I4
		//IL_1382: Unknown result type (might be due to invalid IL or missing references)
		//IL_1387: Expected Obj, but got Unknown
		//IL_1057: Invalid comparison between F4 and I
		//IL_1ea5: Expected Obj, but got I4
		//IL_1ec4: Invalid comparison between F4 and I4
		//IL_1edb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee0: Expected Obj, but got Unknown
		//IL_1142: Expected VT, but got I4
		//IL_1153: Expected VT, but got I4
		//IL_1b19: Expected VT, but got I4
		//IL_10f2: Expected VT, but got I4
		//IL_10fb: Expected VT, but got I4
		//IL_13cc: Expected F8, but got I4
		//IL_141c: Invalid comparison between F8 and I4
		//IL_142b: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		GillaSplashPool gillaSplashPool = Pool;
		float num = stateT + dt;
		stateT = num;
		float roundPace = RoundPace;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2;
		if (gillaSplashPool != null)
		{
			num2 = gillaSplashPool.depth;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC38]");
			num2 = 0f;
		}
		float num3 = prowlBack - num2;
		float num4;
		UnityEngine.Object obj4;
		double num6;
		PlayerRef none;
		Vector3 vector;
		if (state > 1)
		{
			if (state != 2)
			{
				if (state != 3)
				{
					bool flag2 = state != 4;
					num4 = 0f;
					vector = (Vector3)0;
					obj4 = null;
					if (!flag2)
					{
						num3 = rushSink;
						bool flag3 = stateT < killSeconds;
						num4 = 0f;
						vector = (Vector3)0;
						obj4 = null;
						if (!flag3)
						{
							float time = Time.time;
							float num5 = time - heardTime;
							if ((double)num5 < 2.0)
							{
								target = heardAt;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+158]");
								_ = 0;
								quarry = heardFrom;
								float time2 = Time.time;
								followAt = 0f;
								quarryHeard = time2;
								state = 2;
								stateT = 0f;
								num6 = 0.0;
								goto IL_1587;
							}
							state = 0;
							stateT = 0f;
							float num7 = UnityEngine.Random.Range(0.5f, 2.5f);
							wait = num7;
							float num8 = UnityEngine.Random.Range(2f, 4f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
							object obj5 = 0;
							wait = num8;
							object obj6 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v153+E4]");
							bool flag4 = (nint)0 == 0;
							object obj7 = !flag4;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							none = PlayerRef.None;
							num6 = 0.0;
							goto IL_17b9;
						}
					}
					goto IL_0b5a;
				}
				num3 = rushSink;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				num6 = 0.0;
				bool flag5 = stateT < searchSeconds;
				num4 = 0f;
				vector = (Vector3)0;
				obj4 = null;
				if (!flag5)
				{
					state = 0;
					stateT = 0f;
					float num9 = UnityEngine.Random.Range(0.5f, 2.5f);
					wait = num9;
					float num10 = UnityEngine.Random.Range(1f, 3f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
					object obj8 = 0;
					wait = num10;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X0_v145+E4]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					none = PlayerRef.None;
					goto IL_17b9;
				}
			}
			else
			{
				num3 = rushSink;
				float time3 = Time.time;
				bool flag7 = time3 < followAt;
				vector = (Vector3)0;
				GillaSplashPool gillaSplashPool2 = null;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X0_v128+E4]");
					bool flag8 = (nint)0 == 0;
					object obj13 = !flag8;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerRef none2 = PlayerRef.None;
					bool flag9 = quarry == none2;
					vector = (Vector3)0;
					gillaSplashPool2 = null;
					if (!flag9)
					{
						float time4 = Time.time;
						float num11 = time4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						float num12 = num11 + 0f;
						followAt = num12;
						bool flag10 = QuarryAt(gillaSplashPool, out var at);
						bool flag11 = !flag10;
						vector = (Vector3)(&at);
						gillaSplashPool2 = gillaSplashPool;
						if (!flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+130]");
							Vector3 vector2 = (Vector3)0;
							object obj15 = obj14;
							object obj16 = at - target;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+130]");
							object obj17 = -0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X0_v135+E4]");
							bool flag12 = (nint)0 == 0;
							object obj18 = !flag12;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj19 = obj16 * obj16;
							object obj20 = obj17 * obj17;
							object obj21 = this + 296;
							object obj22 = obj19 + obj20;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.25))
							{
								float time5 = Time.time;
								if (repathAt < time5)
								{
									time5 = repathAt;
								}
								repathAt = time5;
							}
							obj21 = at;
							_ = 0;
							float time6 = Time.time;
							quarryHeard = time6;
							vector = (Vector3)(&at);
							gillaSplashPool2 = gillaSplashPool;
						}
					}
				}
				float num13 = Time.time;
				float num14 = repathAt;
				if (!(num13 < repathAt))
				{
					object obj23 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X0_v116+E4]");
					bool flag13 = (nint)0 == 0;
					object obj24 = !flag13;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag14 = gillaSplashPool != null;
					bool flag15 = !flag14;
					vector = (Vector3)0;
					if (!flag15)
					{
						List<Vector3> list = path;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X21_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
						object obj25 = (nint)0 + (nint)1;
						_ = 0;
						Transform transform = base.transform;
						Vector3 position = transform.position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+130]");
						object obj26 = 0;
						Vector3 vector2 = target;
						List<Vector3> collection = gillaSplashPool.Path((Vector3)0, (Vector3)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6910]");
						object obj27 = 0;
						vector = (Vector3)obj27;
						list.AddRange((IEnumerable<Vector3>)collection);
						float time7 = Time.time;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
						num14 = 0f;
						float num15 = time7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
						num13 = (repathAt = num15 + 0f);
					}
				}
				Transform transform2 = base.transform;
				Vector3 position2 = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
				object obj28 = 0;
				object obj29 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X0_v106+E4]");
				bool flag16 = (nint)0 == 0;
				object obj30 = !flag16;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num16 = (float)target - num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+130]");
				object obj31 = 0 - target;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj32 = 0;
				object obj33 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1042 @ X0_v109+E4]");
				bool flag17 = (nint)0 == 0;
				object obj34 = !flag17;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num17 = num16 * num16;
				object obj35 = obj31 * obj31;
				float num18 = num17 + (float)obj35;
				List<Vector3> list2 = path;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				if (num18 < 0f)
				{
					stateT = 0f;
					state = 3;
					bool flag18 = list2 == null;
					object obj36 = !flag18;
					if (obj36 == null)
					{
						throw new NullReferenceException();
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v79 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					if ((nint)0 != 0)
					{
						num4 = roundPace * rushSpeed;
						num6 = 1.0;
						obj4 = null;
						goto IL_15ae;
					}
					stateT = 0f;
					state = 3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v79 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj37 = (nint)0 + (nint)1;
				_ = 0;
				num4 = 0f;
				num6 = 1.0;
				obj4 = null;
			}
			goto IL_15ae;
		}
		if (state != 0)
		{
			bool flag19 = state != 1;
			num4 = 0f;
			vector = (Vector3)0;
			obj4 = null;
			if (!flag19)
			{
				num3 = rushSink;
				Face((Vector3)0, (float)target);
				bool flag20 = stateT < hearSeconds;
				num4 = 0f;
				num6 = 1.0;
				vector = (Vector3)0;
				obj4 = null;
				if (!flag20)
				{
					stateT = 0f;
					state = 2;
					num6 = 1.0;
					goto IL_1587;
				}
				goto IL_15ae;
			}
		}
		else
		{
			List<Vector3> list3 = path;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v62 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			if ((nint)0 != 0)
			{
				num4 = roundPace * prowlSpeed;
				vector = (Vector3)0;
				obj4 = null;
			}
			else
			{
				float num19 = wait - dt;
				bool flag21 = num19 < 0f;
				object obj38 = !flag21;
				bool flag22 = num19 == 0f;
				wait = num19;
				object obj39 = !flag22;
				object obj40 = obj38 & obj39;
				num4 = 0f;
				vector = (Vector3)0;
				obj4 = null;
				if (obj40 == null)
				{
					object obj41 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X0_v81+E4]");
					bool flag23 = (nint)0 == 0;
					object obj42 = !flag23;
					if (obj42 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag24 = gillaSplashPool != null;
					bool flag25 = !flag24;
					num4 = 0f;
					vector = (Vector3)0;
					obj4 = null;
					if (!flag25)
					{
						Transform transform3 = base.transform;
						Vector3 position3 = transform3.position;
						Vector3 vector3 = gillaSplashPool.RandomSpot((Vector3)0, num19);
						target = (Vector3)num19;
						Transform transform4 = base.transform;
						Vector3 position4 = transform4.position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+130]");
						object obj26 = 0;
						List<Vector3> list4 = gillaSplashPool.Path((Vector3)0, (Vector3)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6910]");
						object obj43 = 0;
						vector = (Vector3)obj43;
						path.AddRange((IEnumerable<Vector3>)list4);
						float num20 = UnityEngine.Random.Range(2f, 5f);
						wait = num20;
						num4 = 0f;
						num6 = 0.0;
						obj4 = (UnityEngine.Object)(object)list4;
						goto IL_15ae;
					}
				}
			}
		}
		goto IL_0b5a;
		IL_1587:
		repathAt = 0f;
		num4 = 0f;
		vector = (Vector3)0;
		obj4 = null;
		goto IL_15ae;
		IL_0b5a:
		num6 = 0.0;
		goto IL_15ae;
		IL_17b9:
		quarry = none;
		num4 = 0f;
		vector = (Vector3)0;
		obj4 = null;
		goto IL_15ae;
		IL_15ae:
		List<Vector3> list5 = path;
		float num21 = num4 - speed;
		bool flag26 = num21 < 0f;
		bool flag27 = num21 == 0f;
		object obj44 = num4 ^ speed;
		object obj45 = num4 ^ num21;
		object obj46 = obj44 & obj45;
		bool flag28 = (nint)obj46 < 0;
		float num22 = num4 - speed;
		double num23 = (double)accel * 1.5;
		bool flag29 = flag26 == flag28;
		object obj47 = !flag27;
		object obj48 = flag29 & obj47;
		object obj49 = ~obj48;
		if (obj49 == null)
		{
			num23 = accel;
		}
		bool flag30 = num22 < 0f;
		object obj50 = num22 ^ num22;
		object obj51 = num22 & obj50;
		bool flag31 = (nint)obj51 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num24 = roundPace * (float)num23;
		float num25 = num24 * dt;
		float num26 = num24 * dt;
		float num27 = 0f - num26;
		bool flag32 = flag30 == flag31;
		object obj52 = !flag32;
		object obj53 = ~obj52;
		if (obj53 != null)
		{
			num27 = num25;
		}
		bool flag33 = num22 < num25;
		object obj54 = !flag33;
		float num28 = num22 - num25;
		bool flag34 = num28 == 0f;
		float num29 = speed + num27;
		object obj55 = !flag34;
		object obj56 = obj54 & obj55;
		object obj57 = ~obj56;
		if (obj57 != null)
		{
			num29 = num4;
		}
		speed = num29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
		if ((nint)0 >= (nint)1)
		{
			float num30 = num29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			bool flag35 = !(num30 > 0f);
			Vector3 vector4 = (Vector3)obj4;
			if (!flag35)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
				object obj58 = 0;
				vector = (Vector3)obj58;
				Vector3 vector5 = list5.get_Item(0);
				Transform transform5 = base.transform;
				Vector3 position5 = transform5.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
				object obj59 = 0;
				object obj60 = obj59;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X0_v31+E4]");
				bool flag36 = (nint)0 == 0;
				object obj61 = !flag36;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				List<Vector3> list6 = path;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				float num31 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				float num32 = num31 - 0f;
				float num33 = speed - speed;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v29 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				bool flag37 = (nint)0 != 1;
				double num34 = num29;
				double num35 = num32;
				if (!flag37)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj62 = 0;
					object obj63 = obj62;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1293 @ X0_v72+E4]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num36 = num33 * num33;
					float num37 = num32 * num32;
					float num38 = num37 + num36;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					num35 = (double)num38 * 4.0;
					double num39 = (double)prowlSpeed - num35;
					bool flag38 = num39 < 0.0;
					bool flag39 = num39 == 0.0;
					object obj64 = (double)prowlSpeed ^ num35;
					object obj65 = (double)prowlSpeed ^ num39;
					object obj66 = obj64 & obj65;
					bool flag40 = (nint)obj66 < 0;
					bool flag41 = flag38 == flag40;
					object obj67 = !flag39;
					object obj68 = flag41 & obj67;
					object obj69 = ~obj68;
					if (obj69 == null)
					{
						num35 = prowlSpeed;
					}
					if ((double)speed < num35)
					{
						num35 = speed;
					}
					speed = (float)num35;
					num34 = 4.0;
				}
				float num40 = speed * dt;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj70 = 0;
				object obj71 = obj70;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1302 @ X0_v35+E4]");
				bool flag42 = (nint)0 == 0;
				object obj72 = !flag42;
				if (obj72 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num41 = num33 * num33;
				float num42 = num32 * num32;
				float num43 = num42 + num41;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Transform transform6 = base.transform;
				bool flag43 = speed < num40;
				object obj73 = !flag43;
				float num44 = speed - num40;
				bool flag44 = num44 == 0f;
				object obj74 = ~obj73;
				object obj75 = obj74 | flag44;
				if (obj75 == null)
				{
					Transform transform7 = base.transform;
					Vector3 position6 = transform7.position;
					object obj76 = obj70;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1464 @ X0_v55+E4]");
					bool flag45 = (nint)0 == 0;
					object obj77 = !flag45;
					if (obj77 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num45 = speed;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					if (num45 > 0f)
					{
					}
					Vector3 vector6 = Floor((Vector3)0);
					transform6.position = (Vector3)0;
					vector4 = (Vector3)0;
				}
				else
				{
					Vector3 vector7 = path.get_Item(0);
					Vector3 vector8 = Floor((Vector3)0);
					transform6.position = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8C8]");
					object obj78 = 0;
					vector = (Vector3)obj78;
					path.RemoveAt(0);
					vector4 = (Vector3)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				if (num43 > 0f)
				{
					Transform transform8 = base.transform;
					Vector3 position7 = transform8.position;
					float num46 = num32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					float dt2 = num46 + 0f;
					Face((Vector3)0, dt2);
					num25 = num32;
					vector4 = (Vector3)0;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			bool flag46 = (nint)0 == 0;
			object obj79 = !flag46;
			Vector3 vector4 = (Vector3)obj4;
			if (obj79 == null)
			{
				bool flag47 = state == 0;
				object obj80 = !flag47;
				vector4 = (Vector3)obj4;
				if (obj80 == null)
				{
					num25 = accel * dt;
					float num47 = accel * dt;
					float num48 = 0f - num47;
					float num49 = 0f - num29;
					bool flag48 = num49 < 0f;
					object obj81 = num49 ^ num49;
					object obj82 = num49 & obj81;
					bool flag49 = (nint)obj82 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					bool flag50 = flag48 == flag49;
					object obj83 = !flag50;
					object obj84 = ~obj83;
					if (obj84 != null)
					{
						num48 = num25;
					}
					bool flag51 = num49 < num25;
					object obj85 = !flag51;
					float num50 = num49 - num25;
					bool flag52 = num50 == 0f;
					float num51 = num29 + num48;
					object obj86 = !flag52;
					object obj87 = obj85 & obj86;
					object obj88 = ~obj87;
					if (obj88 != null)
					{
						num51 = 0f;
					}
					speed = num51;
					vector4 = (Vector3)obj4;
				}
			}
		}
		double num52 = ((!(num3 < sink)) ? 0.5 : 4.0);
		float num53 = num3 - sink;
		double num54 = num52 * (double)dt;
		double num55 = num52 * (double)dt;
		double num56 = 0.0 - num55;
		bool flag53 = num53 < 0f;
		object obj89 = num53 ^ num53;
		object obj90 = num53 & obj89;
		bool flag54 = (nint)obj90 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag55 = flag53 == flag54;
		object obj91 = !flag55;
		object obj92 = ~obj91;
		if (obj92 != null)
		{
			num56 = num54;
		}
		bool flag56 = (double)num53 < num54;
		object obj93 = !flag56;
		double num57 = (double)num53 - num54;
		bool flag57 = num57 == 0.0;
		double num58 = (double)sink + num56;
		object obj94 = !flag57;
		object obj95 = obj93 & obj94;
		object obj96 = ~obj95;
		if (obj96 != null)
		{
			num58 = num3;
		}
		sink = (float)num58;
		double num66;
		if (state == 3)
		{
			Vector3 mouth = Mouth;
			float num59 = stateT;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
			float num60 = num59 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num61 = num60 * 1.1164713E+09f;
			float num62 = num61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			float num63 = num62 * 0f;
			Vector3 euler = default;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			Transform transform9 = base.transform;
			Vector3 forward = transform9.forward;
			Vector3 vector9 = (Quaternion)0 * (Vector3)0;
			double num64 = (double)num53 * 4.0;
			float num65 = num63 * 0f;
			num66 = num58 + (double)num65;
			double num67 = (double)num53 + num64;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj97 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj98 = obj97;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X8_v19+A0]");
			object obj99 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1323 @ X8_v20+18]");
			double num68 = 0.0 * num58;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1323 @ X8_v20+20]");
			nint num69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			object obj100 = num69 * 0;
			num66 = (double)target + num68;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+130]");
			double num67 = 0.0 + (double)obj100;
		}
		object obj101 = this + 308;
		obj101 = num66;
		MonsterBrain monsterBrain = brain;
		double num70 = num6 - (double)lookWeight;
		float num71 = dt * 3f;
		float num72 = dt * 3f;
		float num73 = 0f - num72;
		bool flag58 = num70 < 0.0;
		object obj102 = num70 ^ num70;
		object obj103 = num70 & obj102;
		bool flag59 = (nint)obj103 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag60 = flag58 == flag59;
		object obj104 = !flag60;
		object obj105 = ~obj104;
		if (obj105 != null)
		{
			num73 = num71;
		}
		bool flag61 = num70 < (double)num71;
		object obj106 = !flag61;
		double num74 = num70 - (double)num71;
		bool flag62 = num74 == 0.0;
		float num75 = lookWeight + num73;
		object obj107 = !flag62;
		object obj108 = obj106 & obj107;
		object obj109 = ~obj108;
		double num76 = ((obj109 != null) ? num6 : ((double)num75));
		lookWeight = (float)num76;
		float num77 = monsterBrain.walkSpeed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		float num78 = num77 + 0f;
		float num79 = monsterBrain.runSpeed - num78;
		bool flag63 = num79 < 0f;
		bool flag64 = num79 == 0f;
		object obj110 = monsterBrain.runSpeed ^ num78;
		object obj111 = monsterBrain.runSpeed ^ num79;
		object obj112 = obj110 & obj111;
		bool flag65 = (nint)obj112 < 0;
		bool flag66 = flag63 == flag65;
		object obj113 = !flag64;
		object obj114 = flag66 & obj113;
		object obj115 = ~obj114;
		if (obj115 == null)
		{
			num78 = monsterBrain.runSpeed;
		}
		bool flag67 = speed < monsterBrain.walkSpeed;
		object obj116 = !flag67;
		float num80 = speed - monsterBrain.walkSpeed;
		bool flag68 = num80 == 0f;
		object obj117 = ~obj116;
		object obj118 = obj117 | flag68;
		float num85;
		if (obj118 == null)
		{
			bool flag69 = monsterBrain.walkSpeed == num78;
			double num81 = 0.0;
			if (!flag69)
			{
				float num82 = speed - monsterBrain.walkSpeed;
				float num83 = num78 - monsterBrain.walkSpeed;
				double num84 = (double)num82 / (double)num83;
				bool flag70 = num84 < 0.0;
				num81 = 0.0;
				if (!flag70)
				{
					bool flag71 = !(num84 > 1.0);
					num81 = num84;
					if (!flag71)
					{
						num81 = 1.0;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			num85 = speed / monsterBrain.clipRunSpeed;
			double num86 = num81 + 1.0;
			animSpeed = (float)num86;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			float num87 = speed / num78;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			float num88 = monsterBrain.walkSpeed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A038]");
			num85 = num88 / 0f;
			animSpeed = num87;
		}
		double num89 = ((!((double)num85 < 0.5)) ? ((double)num85) : 0.5);
		pace = (float)num89;
	}

	private unsafe void Face(Vector3 at, float dt)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I4
		//IL_00c0: Invalid comparison between F4 and I
		//IL_0391: Expected VT, but got I4
		//IL_022f: Expected VT, but got F4
		//IL_0267: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I
		//IL_02c4: Expected VT, but got I4
		//IL_0242: Expected VT, but got I4
		//IL_016a: Expected F4, but got I
		//IL_02d6: Invalid comparison between F4 and I4
		//IL_02e5: Expected F4, but got I4
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Ref, but got Unknown
		//IL_033b: Expected F4, but got I
		//IL_0348: Expected VT, but got F4
		//IL_01bb: Invalid comparison between F4 and I4
		//IL_01ca: Expected F4, but got I4
		//IL_01e1: Invalid comparison between F4 and I4
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
		object obj = 0;
		Vector3 position = transform.position;
		object obj2 = obj;
		float num = dt - dt;
		object obj4 = default;
		object obj3 = obj4 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2 = num * num;
		object obj6 = obj3 * obj3;
		float num3 = num2 + (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if (num3 < 0f)
		{
			return;
		}
		float num4 = default;
		Vector3 upwards = default;
		Quaternion rotation = default;
		float smoothTime;
		float num11;
		Vector3 forward = default;
		if ((double)num4 < 1.0)
		{
			Transform transform2 = base.transform;
			Vector3 eulerAngles = transform2.eulerAngles;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v21+A0]");
			object obj9 = 0;
			Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
			Vector3 vector = Quaternion.Internal_ToEulerRad(ref rotation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v22+20]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			object obj10 = num5 * 0;
			Vector3 vector2 = Quaternion.Internal_MakePositive((Vector3)0);
			float num6 = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			float num7 = num6 - 0f;
			float num8 = num7 / 1.13587E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			float num9 = num8 * 1.13587E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			smoothTime = 0f;
			float num10 = num7 - num9;
			if (state != 2)
			{
				smoothTime = 0.25f;
			}
			bool flag2 = num10 < 0f;
			num11 = 0f;
			if (!flag2)
			{
				bool flag3 = num10 > 1.13587E+09f;
				float num12 = 1.13587E+09f;
				if (!flag3)
				{
					bool flag4 = !(num10 > 1.1274813E+09f);
					num12 = num10;
					num11 = num10;
					if (flag4)
					{
						goto IL_02f3;
					}
				}
				num11 = num12 + 3.2833536E+09f;
			}
			goto IL_02f3;
		}
		Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
		Vector3 vector3 = Quaternion.Internal_ToEulerRad(ref rotation);
		Vector3 vector4 = Quaternion.Internal_MakePositive((Vector3)0);
		forward = (Vector3)num;
		goto IL_034d;
		IL_02f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		float num13 = 0f + num11;
		ref float currentVelocity = ref *(float*)(this + 280);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		float num14 = Mathf.SmoothDamp(0f, num13, ref currentVelocity, smoothTime, 720f, num4);
		forward = (Vector3)num;
		goto IL_034d;
		IL_034d:
		Transform transform3 = base.transform;
		Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(ref forward);
		transform3.rotation = (Quaternion)0;
	}

	private Vector3 Floor(Vector3 p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I4
		//IL_0049: Expected VT, but got I4
		//IL_009c: Expected VT, but got Obj
		//IL_0089: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		GillaSplashPool gillaSplashPool = Pool;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = gillaSplashPool != null;
		bool flag3 = !flag2;
		Vector3 result = (Vector3)flag2;
		if (!flag3)
		{
			if ((object)gillaSplashPool == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (Vector3)ex;
			}
			float surface = gillaSplashPool.Surface;
			result = (Vector3)gillaSplashPool;
		}
		return result;
	}

	private static Vector3 Flat(Vector3 v)
	{
		return v;
	}

	private void Screech()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_0040: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj = 0;
		Vector3 mouth = Mouth;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float volume = default;
		float pitchMin = default;
		float pitchMax = default;
		Sfx.Play(hearSounds, (Vector3)0, volume, pitchMin, pitchMax);
	}

	public override void FixedUpdateNetwork()
	{
		//IL_003c: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_00df: Expected VT, but got I4
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object == null)
		{
			return;
		}
		object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			object obj4 = default;
			object obj3 = obj4 & 1;
			if (obj3 != null)
			{
				NetState = state;
				NetSpeed = animSpeed;
				NetPace = pace;
				NetSink = sink;
				NetLook = (Vector3)state;
				NetLookWeight = lookWeight;
				NetKills = kills;
				NetVictim = victim;
			}
		}
	}

	public override void Render()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0150: Expected VT, but got F4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I4
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				object obj3 = obj4 & 1;
				bool flag2 = obj3 == null;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					return;
				}
			}
		}
		byte netState = NetState;
		int num = netState & 0xFF;
		if (num == 1 && state != 1)
		{
			Screech();
		}
		byte netState2 = NetState;
		state = netState2;
		float netSpeed = NetSpeed;
		animSpeed = netSpeed;
		float netPace = NetPace;
		pace = netPace;
		float num2 = (sink = NetSink);
		Vector3 netLook = NetLook;
		look = (Vector3)num2;
		float netLookWeight = NetLookWeight;
		lookWeight = netLookWeight;
		byte netPool = NetPool;
		int num3 = netPool & 0xFF;
		poolIndex = num3;
		int netKills = NetKills;
		if (netKills != seenKills)
		{
			int netKills2 = NetKills;
			seenKills = netKills2;
			PlayerRef netVictim = NetVictim;
			PlayerRef localPlayer = ((SimulationBehaviour)this)._runner.LocalPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (netVictim != localPlayer)
			{
				brain.PlayKill();
			}
		}
	}

	private void Show(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_061c: Expected Obj, but got I4
		//IL_0747: Expected Obj, but got I
		//IL_0086: Expected F8, but got I
		//IL_0090: Expected F4, but got VT
		//IL_00ba: Expected F4, but got VT
		//IL_00ba: Expected VT, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_0059: Expected F4, but got I4
		//IL_00cf: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_0204: Expected VT, but got I4
		//IL_02aa: Expected VT, but got F4
		//IL_02bd: Invalid comparison between F4 and I4
		//IL_02cf: Expected F4, but got I4
		//IL_0643: Invalid comparison between F4 and I
		//IL_0692: Expected Obj, but got I
		//IL_06bc: Expected Obj, but got I4
		//IL_0374: Expected F8, but got I
		//IL_03a8: Invalid comparison between F8 and I4
		//IL_03b7: Expected F8, but got I4
		//IL_0559: Expected Obj, but got I
		//IL_0583: Expected Obj, but got I4
		//IL_06fe: Expected Obj, but got I
		//IL_0728: Expected Obj, but got I4
		//IL_05be: Expected VT, but got I4
		//IL_043a: Expected VT, but got I4
		//IL_0457: Expected Obj, but got I4
		//IL_0474: Invalid comparison between F8 and I4
		//IL_0483: Invalid comparison between F8 and I4
		//IL_049b: Expected Obj, but got F8
		//IL_04a8: Expected Obj, but got F8
		//IL_04dd: Expected Obj, but got I4
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+8]");
		float num;
		if ((nint)0 != 0)
		{
			bool authority = Authority;
			bool flag2 = !authority;
			object obj5 = !flag2;
			num = 0f;
			if (obj5 != null)
			{
				goto IL_0076;
			}
		}
		num = animSpeed;
		goto IL_0076;
		IL_0076:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+138]");
		double num2 = 0.0;
		float num3 = (float)look;
		float num4 = pace;
		brain.ShowPuppet(num, pace, (Vector3)0, (float)look);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		object obj7 = state - 2;
		bool flag3 = obj7 == null;
		brain.ShowChasing(flag3);
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (model != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v35+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v36+24]");
			object obj14 = default;
			object obj13 = 0 * obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v36+2C]");
			float num5 = 0f * sink;
			num = (float)modelRest + (float)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+180]");
			num3 = 0f + num5;
			model.localPosition = (Vector3)0;
			float num6 = default;
			num4 = num6;
		}
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
		object obj15 = 0;
		Vector3 position = transform.position;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform2 = base.transform;
		Vector3 position2 = transform2.position;
		lastPos = (Vector3)num;
		bool flag6 = !(dt > 0f);
		float num7 = 0f;
		if (!flag6)
		{
			float num8 = num - (float)lastPos;
			float num9 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashMonster)+18C]");
			float num10 = num9 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v42+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num11 = num8 * num8;
			float num12 = num10 * num10;
			float num13 = num11 + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			num7 = num13 / dt;
		}
		float time = Time.time;
		float num14 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		if (num14 > 0f && !(time < nextWake))
		{
			Vector3 mark = Mark;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			double num15 = 0.0;
			double num16 = (double)num7 / 12.0;
			double num17 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			double num18 = num17 + 0.0;
			bool flag8 = num18 < 0.0;
			double num19 = 0.0;
			if (!flag8)
			{
				bool flag9 = !(num18 > 1.0);
				num19 = num18;
				num15 = 1.0;
				if (!flag9)
				{
					num19 = 1.0;
					num15 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
			object obj21 = 0;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v36+E4]");
			bool flag10 = (nint)0 == 0;
			object obj23 = !flag10;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaSplashPool.Ripple((Vector3)0, time);
			float time2 = Time.time;
			object obj24 = 17285120 + 464;
			double num20 = (double)num7 - 6.0;
			bool flag11 = num20 < 0.0;
			bool flag12 = num20 == 0.0;
			object obj25 = (double)num7 ^ 6.0;
			object obj26 = (double)num7 ^ num20;
			object obj27 = obj25 & obj26;
			bool flag13 = (nint)obj27 < 0;
			bool flag14 = flag11 == flag13;
			object obj28 = !flag12;
			object obj29 = flag14 & obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X9_v5+v367 @ TEMPCOND_v18*4]");
			float num21 = 0f + time2;
			nextWake = num21;
			num2 = num19;
		}
		if (!((double)num7 > 6.0))
		{
			return;
		}
		float time3 = Time.time;
		if (!(time3 < surgeAt))
		{
			Vector3 mouth = Mouth;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj30 = 0;
			object obj31 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v29+E4]");
			bool flag15 = (nint)0 == 0;
			object obj32 = !flag15;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sfx.Play(surgeSounds, (Vector3)0, time3, surgeAt, num3);
			float time4 = Time.time;
			float num22 = time4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADA4]");
			float num23 = num22 + 0f;
			surgeAt = num23;
		}
	}

	public GillaSplashMonster()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c2: Expected F4, but got I
		//IL_00d4: Expected F4, but got I
		//IL_00e4: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D7F0]");
		prowlSpeed = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E370]");
		hearSeconds = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj2 = 0;
		prowlBack = 2.48f;
		pace = 1f;
		lostAfter = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		quarry = PlayerRef.None;
		quarryHeard = -10f;
		heardTime = -10f;
		heardFrom = PlayerRef.None;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list = default;
		list._002Ector();
		object obj4 = this + 352;
		path = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaSplashMonster()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = list;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private bool _003Cget_Pool_003Eb__110_0(GillaSplashPool p)
	{
		//IL_005b: Expected I4, but got Obj
		//IL_0039: Expected Obj, but got I4
		if ((object)p != null)
		{
			int num = PoolIndex;
			object obj = p.index - num;
			return obj == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
		//IL_0046: Expected VT, but got I4
		NetState = _NetState;
		NetSpeed = _NetSpeed;
		NetPace = _NetPace;
		NetSink = _NetSink;
		NetLook = (Vector3)_NetState;
		NetLookWeight = _NetLookWeight;
		NetKills = _NetKills;
		NetVictim = _NetVictim;
		NetPool = _NetPool;
	}

	public override void CopyStateToBackingFields()
	{
		//IL_006e: Expected VT, but got F4
		byte netState = NetState;
		_NetState = netState;
		float netSpeed = NetSpeed;
		_NetSpeed = netSpeed;
		float netPace = NetPace;
		_NetPace = netPace;
		float num = (_NetSink = NetSink);
		Vector3 netLook = NetLook;
		_NetLook = (Vector3)num;
		float netLookWeight = NetLookWeight;
		_NetLookWeight = netLookWeight;
		int netKills = NetKills;
		_NetKills = netKills;
		PlayerRef netVictim = NetVictim;
		_NetVictim = netVictim;
		byte netPool = NetPool;
		_NetPool = netPool;
	}

	protected unsafe static void RPC_Splash_0040Invoker3783123414([In] ref RpcInvokeContext context)
	{
		//IL_0013: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I
		//IL_020e: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_023e: Expected VT, but got I4
		//IL_0264: Expected Obj, but got I
		//IL_026d: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_0105: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00ae: Expected VT, but got Obj
		//IL_00e0: Expected VT, but got I4
		//IL_0162: Expected Obj, but got I
		//IL_01a2: Expected VT, but got Ref
		//IL_01a2: Expected F4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 value, 12);
		rpcDataReader.Read(out float _, 4);
		rpcDataReader.Read(out NetworkBool value3, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v10+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		RpcInfo info = (RpcInfo)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8A0]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ X21_v3+18] (should have been resolved before IL gen)");
			info = (RpcInfo)0;
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v9+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaSplashMonster gillaSplashMonster = (GillaSplashMonster)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaSplashMonster;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v14 (Il2CppClass<GillaSplashMonster>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X1_v8+130]");
		bool flag3 = num2 < 0;
		object obj12 = !flag3;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v14 (Il2CppClass<GillaSplashMonster>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X1_v8+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v17-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaSplashMonster.RPC_Splash((Vector3)value3, (float)value, (NetworkBool)(&obj15), info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Caught_0040Invoker3532389391([In] ref RpcInvokeContext context)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8B0]");
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
		GillaSplashMonster gillaSplashMonster = (GillaSplashMonster)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaSplashMonster;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<GillaSplashMonster>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
		bool flag2 = num2 < 0;
		object obj12 = !flag2;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<GillaSplashMonster>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v15-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaSplashMonster.RPC_Caught((RpcInfo)(&obj15));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}
}
