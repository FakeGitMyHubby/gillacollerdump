using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.XR;

public class GillaBearTrap : NetworkBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly GillaBearTrap._003C_003Ec _003C_003E9;

		public static Predicate<GillaItem> _003C_003E9__103_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5348]");
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

		internal bool _003CHandedIn_003Eb__103_0(GillaItem c)
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
			return c == null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly GillaBearTrap._003C_003Ec _003C_003E9;

		public static Func<GillaBearTrap, bool> _003C_003E9__69_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB58]");
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

		internal bool _003CSpawned_003Eb__69_0(GillaBearTrap t)
		{
			//IL_0095: Expected I4, but got Obj
			if ((object)t != null)
			{
				byte now = t.Now;
				int num = now & 0xFF;
				if (num == 2)
				{
					return false;
				}
				return !t.sprung;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public GillaItem item;

	public Transform jawL;

	public Transform jawR;

	public Transform springL;

	public Transform springR;

	public Transform pan;

	public Transform dog;

	public Vector3 jawAxisL;

	public Vector3 jawAxisR;

	public float jawAngleL;

	public float jawAngleR;

	public Vector3 springAxisL;

	public Vector3 springAxisR;

	public float springAngleL;

	public float springAngleR;

	public float panDip;

	public Vector3 dogAxis;

	public float dogThrown;

	public float dogRests;

	public float jawReach;

	public float panReach;

	public float holds;

	public float setAfter;

	public float lasts;

	public AudioClip[] setSounds;

	public AudioClip[] snapSounds;

	public AudioClip[] biteSounds;

	public AudioClip[] rattleSounds;

	private const byte Lying = default(byte);

	private const byte IsSet = default(byte);

	private const byte IsSprung = default(byte);

	private const float ShutIn = default(float);

	private const float EyesUpTo = default(float);

	private byte _State;

	private byte stateHere;

	private byte shown;

	private bool sprung;

	private bool youAreOn;

	private bool handWasOn;

	private float stillFor;

	private float shutT;

	private float sprungAtHere;

	private float heldTill;

	private float nextRattle;

	private Vector3 restAt;

	private float restFor;

	private const float SettleReach = default(float);

	private const int MostEach = default(int);

	private const float SprungFrom = default(float);

	private Quaternion openL;

	private Quaternion openR;

	private Quaternion openSL;

	private Quaternion openSR;

	private Quaternion openDog;

	private Vector3 panAt;

	private Vector3 holdsAt;

	public static readonly List<GillaBearTrap> All;

	private unsafe byte State
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

	private byte Now
	{
		get
		{
			if (Live)
			{
				return State;
			}
			return stateHere;
		}
	}

	public bool Spent
	{
		get
		{
			byte now = Now;
			int num = now & 0xFF;
			if (num == 2)
			{
				return true;
			}
			bool flag = !sprung;
			return !flag;
		}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB28]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB28]");
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

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_039f: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_03d7: Expected Obj, but got I4
		//IL_040f: Expected Obj, but got I4
		//IL_0447: Expected Obj, but got I4
		//IL_047f: Expected Obj, but got I4
		//IL_04b7: Expected Obj, but got I4
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51E0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			UnityEngine.Object obj7 = default;
			item = (GillaItem)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5 = obj7;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = jawL != null;
		bool flag6 = !flag5;
		UnityEngine.Object obj10 = null;
		Quaternion quaternion = default;
		if (!flag6)
		{
			Quaternion localRotation = jawL.localRotation;
			openL = quaternion;
			obj10 = null;
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = jawR != null;
		bool flag9 = !flag8;
		UnityEngine.Object obj13 = null;
		if (!flag9)
		{
			Quaternion localRotation2 = jawR.localRotation;
			openR = quaternion;
			obj13 = null;
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v17+E4]");
		bool flag10 = (nint)0 == 0;
		object obj15 = !flag10;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = springL != null;
		bool flag12 = !flag11;
		UnityEngine.Object obj16 = null;
		if (!flag12)
		{
			Quaternion localRotation3 = springL.localRotation;
			openSL = quaternion;
			obj16 = null;
		}
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v22+E4]");
		bool flag13 = (nint)0 == 0;
		object obj18 = !flag13;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = springR != null;
		bool flag15 = !flag14;
		UnityEngine.Object obj19 = null;
		if (!flag15)
		{
			Quaternion localRotation4 = springR.localRotation;
			openSR = quaternion;
			obj19 = null;
		}
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v27+E4]");
		bool flag16 = (nint)0 == 0;
		object obj21 = !flag16;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = dog != null;
		bool flag18 = !flag17;
		UnityEngine.Object obj22 = null;
		if (!flag18)
		{
			Quaternion localRotation5 = dog.localRotation;
			openDog = quaternion;
			obj22 = null;
		}
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v32+E4]");
		bool flag19 = (nint)0 == 0;
		object obj24 = !flag19;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (pan != null)
		{
			Vector3 localPosition = pan.localPosition;
			panAt = (Vector3)quaternion;
		}
	}

	public unsafe override void Spawned()
	{
		//IL_0096: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I4
		//IL_0443: Expected Obj, but got I
		//IL_0453: Expected Obj, but got I
		//IL_0463: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I4
		//IL_04a3: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I
		//IL_04c5: Expected I, but got Obj
		//IL_04d6: Expected I, but got Obj
		//IL_04f4: Expected Obj, but got I
		//IL_0516: Expected I, but got Obj
		//IL_03bb: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I
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
				nint num = unchecked((nint)null);
				if (obj5 != null)
				{
					goto IL_02d1;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB28]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj6;
		}
		NetworkObject networkObject2 = ((SimulationBehaviour)this)._object;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v13+A0]");
		object obj9 = 0;
		int* ptr = networkObject2.Ptr;
		if (networkObject2.Ptr != null)
		{
			NetworkRunner runner = networkObject2._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11 (System.Int32*)+20]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
			nint num2 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v39+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB58]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v19+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v20+8]");
		Func<System.__Canon, bool> func = (Func<System.__Canon, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v20+8]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v19+E4]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj20 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v24+A0]");
				obj16 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB40]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB50]");
			object obj22 = 0;
			nint num2 = (nint)obj22;
			Func<System.__Canon, bool> func2 = default;
			func2._002Ector(obj16, (IntPtr)obj22);
			object obj23 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v23+A0]");
			object obj24 = (nint)0 + (nint)8;
			obj24 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			func = func2;
			nint num = (nint)func2;
		}
		object obj25 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB48]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v21+E4]");
		bool flag8 = (nint)0 == 0;
		object obj27 = !flag8;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3627130");
		object obj28 = default;
		if ((nint)obj28 < 8)
		{
			goto IL_02d1;
		}
		object obj29 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v25+E4]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB60]");
		object what = 0;
		GillaNetGuard.Ignore(this, (string)what, 8);
		return;
		IL_02d1:
		byte state = State;
		shown = state;
		byte state2 = State;
		int num3 = state2 & 0xFF;
		if (num3 == 2)
		{
			sprung = true;
			float time = Time.time;
			sprungAtHere = time;
			Pose(1f);
			PoseDog(1f);
		}
	}

	private void Update()
	{
		//IL_006a: Expected Obj, but got I4
		Sets();
		Settles();
		Shows();
		byte now = Now;
		int num = now & 0xFF;
		if (num == 1)
		{
			bool flag = (byte)(~(sprung ? 1u : 0u)) != 0;
			object obj = !flag;
			if (obj == null && !(restFor < setAfter))
			{
				Looks();
			}
		}
		Shuts();
		Rattles();
		Goes();
	}

	private void Sets()
	{
		//IL_0010: Expected Obj, but got I
		//IL_030b: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_00dc: Expected I4, but got I8
		//IL_0112: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I4
		//IL_026e: Expected F4, but got I4
		//IL_02a4: Expected F4, but got I4
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
		bool flag2 = item == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		bool flag4 = (byte)(~(sprung ? 1u : 0u)) != 0;
		object obj5 = !flag4;
		if (obj5 != null || !item.Mine)
		{
			return;
		}
		byte now = Now;
		GillaItem gillaItem = item;
		byte b;
		if ((int)(gillaItem.Hand__BackingField & 0x80000000L) != 0)
		{
			bool flag5 = (byte)(~(gillaItem.Swallowed__BackingField ? 1u : 0u)) != 0;
			object obj6 = !flag5;
			if (obj6 == null && ~(gillaItem.Gone__BackingField ? 1u : 0u) != 0)
			{
				byte now2 = Now;
				int num = now2 & 0xFF;
				bool flag6 = num == 0;
				object obj7 = !flag6;
				b = now;
				if (obj7 == null)
				{
					Transform transform = base.transform;
					Vector3 up = transform.up;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
					object obj9 = default;
					object obj8 = obj9 * obj9;
					object obj11 = default;
					object obj10 = obj11 * obj11;
					object obj12 = obj8 + obj10;
					object obj14 = default;
					object obj13 = obj14 * obj14;
					object obj15 = obj13 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
					bool flag7 = (nint)obj15 <= 0;
					float num2 = 0f;
					if (!flag7)
					{
						bool still = item.Still;
						bool flag8 = !still;
						num2 = 0f;
						if (!flag8)
						{
							float deltaTime = Time.deltaTime;
							num2 = stillFor + deltaTime;
						}
					}
					stillFor = num2;
					bool flag9 = num2 < setAfter;
					b = now;
					if (!flag9)
					{
						b = 1;
					}
				}
				goto IL_031a;
			}
		}
		stillFor = 0f;
		b = 0;
		goto IL_031a;
		IL_031a:
		byte now3 = Now;
		int num3 = b & 0xFF;
		if (num3 != now3)
		{
			if (Live)
			{
				State = b;
			}
			else
			{
				stateHere = b;
			}
		}
	}

	private void Shows()
	{
		//IL_005f: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_00c2: Expected VT, but got I4
		//IL_00d2: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_016d: Expected VT, but got I4
		//IL_018b: Expected VT, but got I4
		byte now = Now;
		if (shown == now)
		{
			return;
		}
		int num = now & 0xFF;
		if (num == 1)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float volume = default;
			float pitchMin = default;
			float pitchMax = default;
			Sfx.Play(setSounds, (Vector3)0, volume, pitchMin, pitchMax);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Transform transform2;
			if (pan != null)
			{
				transform2 = pan;
			}
			else
			{
				transform2 = base.transform;
				bool flag3 = (object)transform2 == null;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					throw new NullReferenceException();
				}
			}
			Vector3 position2 = transform2.position;
			bool flag4 = YouAreOn((Vector3)0);
			youAreOn = flag4;
			bool flag5 = HandOn((Vector3)0);
			handWasOn = flag5;
		}
		shown = now;
	}

	private void Settles()
	{
		//IL_0021: Expected Obj, but got VT
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_0193: Expected VT, but got I4
		//IL_01b9: Expected VT, but got I4
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Vector3 vector = default;
		object obj = vector - restAt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+150]");
		object obj3 = default;
		object obj2 = obj3 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+154]");
		object obj5 = default;
		object obj4 = obj5 - 0;
		object obj6 = obj * obj;
		object obj7 = obj2 * obj2;
		object obj8 = obj6 + obj7;
		object obj9 = obj4 * obj4;
		object obj10 = obj8 + obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA5C]");
		bool flag = (nint)obj10 < 0;
		object obj11 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA5C]");
		object obj12 = obj10 - 0;
		bool flag2 = obj12 == null;
		object obj13 = ~obj11;
		object obj14 = obj13 | flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj15 = 0;
			restAt = vector;
			object obj16 = obj15;
			restFor = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = pan != null;
			bool flag5 = !flag4;
			Vector3 mouth = (Vector3)0;
			if (!flag5)
			{
				Vector3 position2 = pan.position;
				mouth = (Vector3)0;
			}
			bool flag6 = YouAreOn(mouth);
			youAreOn = flag6;
			bool flag7 = HandOn(mouth);
			handWasOn = flag7;
		}
		else
		{
			float deltaTime = Time.deltaTime;
			float num = restFor + deltaTime;
			restFor = num;
		}
	}

	private bool YouAreOn(Vector3 mouth)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_04cb: Expected Obj, but got I
		//IL_04f5: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_04ab: Expected I4, but got Obj
		//IL_00b1: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I4
		//IL_0525: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I
		//IL_055d: Expected Obj, but got I4
		//IL_0290: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I4
		//IL_05d5: Expected Obj, but got I
		//IL_05e5: Expected F8, but got I
		//IL_02f4: Expected Obj, but got I
		//IL_0316: Expected Obj, but got I4
		//IL_05b2: Expected Obj, but got I4
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_03cd: Invalid comparison between Obj and F8
		//IL_048a: Invalid comparison between F4 and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj8 = !flag3;
		bool result;
		if (obj8 == null)
		{
			if (obj5 != null)
			{
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v11+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X20_v2 (UnityEngine.Object)+20]");
				if ((UnityEngine.Object)0 == null)
				{
					goto IL_0101;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v15+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool isMonster = MonsterPlayer.IsMonster;
				object obj14 = obj11;
				bool flag6 = !isMonster;
				object obj15 = !flag6;
				double num = 1.0;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v20+E4]");
					bool flag7 = (nint)0 == 0;
					object obj16 = !flag7;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					obj14 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v20+E4]");
					bool flag8 = (nint)0 == 0;
					object obj17 = !flag8;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj14 = obj11;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v20+A0]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v24+C]");
					num = 0.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v20+E4]");
				bool flag9 = (nint)0 == 0;
				object obj19 = !flag9;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool isMonster2 = MonsterPlayer.IsMonster;
				bool flag10 = !isMonster2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				object obj21 = !flag10;
				object obj22 = ~obj21;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
					obj20 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X20_v2 (UnityEngine.Object)+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X20_v2 (UnityEngine.Object)+20]");
					Vector3 position = ((Transform)0).position;
					object obj23 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v26+E4]");
					bool flag11 = (nint)0 == 0;
					object obj24 = !flag11;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool isMonster3 = MonsterPlayer.IsMonster;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB28]");
					object obj25 = 0;
					bool flag12 = !isMonster3;
					object obj26 = obj25;
					object obj27 = !flag12;
					object obj28 = ~obj27;
					double num2 = ((obj28 != null) ? 1.0 : 2.0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v30+E4]");
					bool flag13 = (nint)0 == 0;
					object obj29 = !flag13;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
					object obj31 = default;
					object obj30 = 0 - obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADCC]");
					bool flag14 = (nint)obj30 < 0;
					result = false;
					if (!flag14)
					{
						double num3 = num * 1.75;
						double num4 = num3 * num2;
						bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num4);
						result = false;
						if (!flag15)
						{
							object obj33 = default;
							object obj32 = obj20 - obj33;
							object obj34 = obj31 - obj31;
							object obj36 = default;
							object obj35 = obj36 - obj36;
							object obj37 = obj32 * obj32;
							object obj38 = obj34 * obj34;
							float num5 = jawReach * (float)obj20;
							object obj39 = obj38 + obj37;
							object obj40 = obj35 * obj35;
							object obj41 = obj40 + obj39;
							float num6 = num5 * num5;
							float num7 = (float)obj41 - num6;
							bool flag16 = num7 < 0f;
							result = flag16;
						}
					}
					goto IL_05c0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_0101;
		IL_0101:
		result = false;
		goto IL_05c0;
		IL_05c0:
		return result;
	}

	private unsafe void Looks()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1e8d: Expected Obj, but got I
		//IL_1eaf: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got I4
		//IL_1d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I4
		//IL_1ecd: Expected Obj, but got I
		//IL_1ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got I
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got I
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected F4, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected Obj, but got I
		//IL_0b57: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I
		//IL_1f4b: Expected Obj, but got I
		//IL_1f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f85: Expected Obj, but got I4
		//IL_045c: Expected F8, but got I
		//IL_0470: Expected Obj, but got I8
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got I4
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1600: Expected VT, but got I4
		//IL_1f2d: Expected Obj, but got I4
		//IL_163f: Expected Obj, but got I4
		//IL_0b8d: Expected Obj, but got I
		//IL_0b9d: Expected Obj, but got I
		//IL_0bad: Expected Obj, but got I
		//IL_0bbd: Expected Obj, but got I
		//IL_0bcd: Expected Obj, but got I
		//IL_0bdd: Expected Obj, but got I
		//IL_0be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected F8, but got I
		//IL_0c0a: Expected F4, but got I
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Expected Obj, but got I4
		//IL_1ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d05: Expected Obj, but got I4
		//IL_1d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_2179: Expected VT, but got I4
		//IL_1631: Expected Obj, but got I4
		//IL_04dd: Expected Obj, but got I
		//IL_04ed: Expected Obj, but got I
		//IL_050f: Expected Obj, but got I4
		//IL_1662: Expected Obj, but got I4
		//IL_1021: Expected Obj, but got I4
		//IL_102a: Expected Obj, but got I4
		//IL_053e: Expected Obj, but got I
		//IL_055c: Expected Obj, but got I4
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected F4, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_21be: Expected Obj, but got I4
		//IL_21c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_21cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d4: Invalid comparison between Unknown and I4
		//IL_21ea: Expected Obj, but got I
		//IL_1654: Expected Obj, but got I4
		//IL_2342: Expected Obj, but got I4
		//IL_234c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2356: Unknown result type (might be due to invalid IL or missing references)
		//IL_235a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2367: Expected Obj, but got I4
		//IL_236b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2373: Unknown result type (might be due to invalid IL or missing references)
		//IL_237b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Expected Obj, but got I
		//IL_0c5a: Expected Obj, but got I4
		//IL_0a9c: Expected Obj, but got I4
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Expected Obj, but got I4
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected Obj, but got I4
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1039: Unknown result type (might be due to invalid IL or missing references)
		//IL_1043: Unknown result type (might be due to invalid IL or missing references)
		//IL_1047: Unknown result type (might be due to invalid IL or missing references)
		//IL_1054: Expected Obj, but got I4
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_1060: Unknown result type (might be due to invalid IL or missing references)
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_1074: Expected Obj, but got Ref
		//IL_2216: Expected Obj, but got I
		//IL_222e: Expected Obj, but got I
		//IL_224b: Expected Obj, but got I
		//IL_2268: Expected Obj, but got I
		//IL_2285: Expected Obj, but got I
		//IL_2285: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdb: Expected Obj, but got I4
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Expected Obj, but got I4
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got I
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected F4, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d8: Expected VT, but got I4
		//IL_16d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1702: Expected VT, but got I4
		//IL_1717: Expected Obj, but got I
		//IL_171f: Expected I, but got Obj
		//IL_1741: Expected Obj, but got I4
		//IL_168c: Expected VT, but got Ref
		//IL_0d35: Expected Obj, but got I
		//IL_0d57: Expected Obj, but got I4
		//IL_067c: Expected Obj, but got I
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected F4, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_169b: Expected Obj, but got I4
		//IL_169b: Unknown result type (might be due to invalid IL or missing references)
		//IL_169f: Unknown result type (might be due to invalid IL or missing references)
		//IL_16af: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d7: Expected Obj, but got I
		//IL_18df: Expected VT, but got Obj
		//IL_1901: Expected Obj, but got I4
		//IL_0d7e: Expected Obj, but got I
		//IL_0da0: Expected Obj, but got I4
		//IL_06d4: Expected Obj, but got I
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Expected F4, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_178c: Expected I, but got Obj
		//IL_17ae: Expected Obj, but got I4
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df3: Expected Obj, but got I4
		//IL_0df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e19: Expected Obj, but got I4
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected Obj, but got I
		//IL_0755: Expected Obj, but got I4
		//IL_22df: Expected I, but got Obj
		//IL_2301: Expected Obj, but got I4
		//IL_079a: Expected Obj, but got I4
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected F4, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_240f: Expected Obj, but got I4
		//IL_0e62: Expected Obj, but got I
		//IL_0e84: Expected Obj, but got I4
		//IL_17f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1800: Expected Obj, but got Unknown
		//IL_17e2: Expected I, but got Obj
		//IL_0eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb6: Invalid comparison between Unknown and F8
		//IL_0ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Expected Obj, but got I
		//IL_07f6: Expected Obj, but got I
		//IL_0818: Expected Obj, but got I4
		//IL_085d: Expected Obj, but got I4
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected F4, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_1829: Expected I, but got Obj
		//IL_184b: Expected Obj, but got I4
		//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eeb: Invalid comparison between Unknown and F8
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1881: Unknown result type (might be due to invalid IL or missing references)
		//IL_1885: Unknown result type (might be due to invalid IL or missing references)
		//IL_1896: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected Obj, but got I4
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2e: Expected Obj, but got Unknown
		//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected Obj, but got Unknown
		//IL_0f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8a: Invalid comparison between Unknown and F4
		//IL_0f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Expected Obj, but got I
		//IL_095d: Expected Obj, but got I4
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Invalid comparison between Unknown and F8
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected F4, but got Unknown
		//IL_1fd5: Expected Obj, but got I
		//IL_1fed: Expected Obj, but got I
		//IL_1ffd: Expected F8, but got I
		//IL_200d: Expected F4, but got I
		//IL_2072: Expected Obj, but got I
		//IL_2072: Unknown result type (might be due to invalid IL or missing references)
		//IL_2090: Unknown result type (might be due to invalid IL or missing references)
		//IL_2098: Unknown result type (might be due to invalid IL or missing references)
		//IL_2099: Unknown result type (might be due to invalid IL or missing references)
		//IL_1938: Expected VT, but got I4
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Invalid comparison between Unknown and F8
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09df: Expected F4, but got Unknown
		//IL_195a: Expected VT, but got I4
		//IL_195a: Unknown result type (might be due to invalid IL or missing references)
		//IL_195e: Unknown result type (might be due to invalid IL or missing references)
		//IL_196a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1972: Expected F8, but got Unknown
		//IL_197b: Expected Obj, but got I4
		//IL_1981: Unknown result type (might be due to invalid IL or missing references)
		//IL_198e: Expected Obj, but got I4
		//IL_1997: Expected Obj, but got I4
		//IL_0fef: Expected VT, but got Ref
		//IL_0ffe: Expected Obj, but got I4
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Expected Obj, but got Unknown
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected Obj, but got Unknown
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Expected Obj, but got Unknown
		//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Invalid comparison between Unknown and F4
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a76: Expected F4, but got Unknown
		//IL_19a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bb: Expected Obj, but got Unknown
		//IL_19d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e7: Expected Obj, but got Unknown
		//IL_19e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f4: Expected Obj, but got Unknown
		//IL_1a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a10: Expected Obj, but got Unknown
		//IL_1c30: Expected VT, but got I4
		//IL_1c5a: Expected VT, but got I4
		//IL_1c6f: Expected Obj, but got I
		//IL_1c99: Expected Obj, but got I4
		//IL_1a5c: Expected VT, but got Ref
		//IL_1ccb: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		UnityEngine.Object obj3 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform;
		UnityEngine.Object obj7 = default;
		Enumerator<, > val;
		Enumerator<, > val3 = default;
		float num;
		float num2 = default;
		Enumerator<, > val5 = default;
		UnityEngine.Object obj8;
		UnityEngine.Object obj6;
		Enumerator<, > val2;
		bool flag3;
		Enumerator<, > val4;
		if (pan != null)
		{
			transform = pan;
			bool flag2 = (object)pan == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_0121;
			}
			obj6 = obj7;
			val = (Enumerator<, >)0;
			val2 = val3;
			num = num2;
			val4 = val5;
			flag3 = false;
			obj8 = null;
		}
		else
		{
			transform = base.transform;
			bool flag4 = (object)transform == null;
			obj6 = obj7;
			val = (Enumerator<, >)0;
			val2 = val3;
			num = num2;
			val4 = val5;
			flag3 = false;
			obj8 = null;
			if (!flag4)
			{
				goto IL_0121;
			}
		}
		goto IL_1d22;
		IL_0b1d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X0_v53+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X0_v53+A0]");
		obj3 = (UnityEngine.Object)0;
		bool flag6 = (object)obj3 == null;
		obj6 = obj7;
		val = (Enumerator<, >)0;
		float num3;
		val2 = (Enumerator<, >)num3;
		double num4;
		num = (float)num4;
		object obj12 = 17276928;
		System.__Canon[] array2;
		System.__Canon[] array = array2;
		if (flag6)
		{
			goto IL_1d22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C50]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C48]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5280]");
		array = (System.__Canon[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5260]");
		UnityEngine.Object obj17 = (UnityEngine.Object)0;
		Enumerator<, > enumerator = ((List<System.__Canon>)(object)obj3).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADCC]");
		double num5 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
		float num6 = 0f;
		Enumerator<, > val6 = default;
		val4 = val6;
		obj3 = (UnityEngine.Object)17276928;
		object obj25;
		Enumerator<, > val11;
		object obj21;
		Enumerator<, > val7;
		Enumerator<, > val8;
		double num7;
		Enumerator<, > val13;
		Enumerator<, > val9;
		while (val.MoveNext())
		{
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ X0_v99+E4]");
			obj3 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ X0_v99+E4]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = obj7 == null;
			bool flag9 = !flag8;
			object obj20 = !flag9;
			flag3 = false;
			if (obj20 != null)
			{
				continue;
			}
			bool flag10 = (object)obj7 == null;
			obj6 = null;
			val = val6;
			obj21 = 0;
			val7 = (Enumerator<, >)(ref val);
			val2 = (Enumerator<, >)num3;
			num7 = 1.0;
			obj12 = 17276928;
			val8 = (Enumerator<, >)(ref val);
			flag3 = false;
			obj8 = null;
			if (flag10)
			{
				goto IL_1d38;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-138 (UnityEngine.Object)+100]");
			obj3 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-138 (UnityEngine.Object)+100]");
			bool flag11 = (nint)0 == 0;
			object obj22 = !flag11;
			flag3 = false;
			if (obj22 != null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-138 (UnityEngine.Object)+121]");
			obj3 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ stack_-138 (UnityEngine.Object)+121]");
			bool flag12 = (nint)0 == 0;
			object obj23 = !flag12;
			flag3 = false;
			if (obj23 != null)
			{
				continue;
			}
			Transform transform2 = ((Component)obj7).transform;
			bool flag13 = (object)transform2 == null;
			val9 = (Enumerator<, >)0;
			obj6 = null;
			val = val6;
			obj21 = 0;
			val7 = (Enumerator<, >)(ref val);
			val2 = (Enumerator<, >)num3;
			num7 = 1.0;
			obj12 = 17276928;
			val8 = (Enumerator<, >)(ref val);
			flag3 = false;
			obj8 = null;
			if (flag13)
			{
				goto IL_1d5e;
			}
			Vector3 position = transform2.position;
			object obj24 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1722 @ X0_v106+E4]");
			obj3 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1722 @ X0_v106+E4]");
			bool flag14 = (nint)0 == 0;
			object obj26 = !flag14;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Enumerator<, > val10 = (Enumerator<, >)(num4 - (double)num2);
			bool flag15 = (double)val10 < num5;
			val4 = val10;
			flag3 = false;
			if (flag15)
			{
				continue;
			}
			bool flag16 = (double)val10 > 1.0;
			val4 = val10;
			flag3 = false;
			if (flag16)
			{
				continue;
			}
			float num8 = jawReach * num6;
			object obj27 = val10 - val5;
			float num9 = num3 - (float)val3;
			object obj28 = obj27 * obj27;
			float num10 = num9 * num9;
			object obj29 = val11 + obj28;
			Enumerator<, > val12 = (Enumerator<, >)(num10 + obj29);
			float num11 = num8 * num8;
			bool flag17 = !((float)val12 < num11);
			val13 = val11;
			num3 = num8;
			num4 = num11;
			val4 = val12;
			flag3 = false;
			if (flag17)
			{
				continue;
			}
			goto IL_1fc5;
		}
		num7 = 1.0;
		obj12 = 23;
		object obj30 = 0;
		goto IL_2317;
		IL_1d5e:
		NullReferenceException ex = new NullReferenceException();
		GillaEgg gillaEgg = null;
		goto IL_1d71;
		IL_1d22:
		NullReferenceException ex2 = new NullReferenceException();
		num4 = num;
		goto IL_1d38;
		IL_1d80:
		throw new OutOfMemoryException();
		IL_0121:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj31 = 0;
		Vector3 position2 = transform.position;
		object obj32 = obj31;
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v17+A0]");
		obj3 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v42+E4]");
		val8 = (Enumerator<, >)0;
		UnityEngine.Object obj34 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v42+E4]");
		bool flag18 = (nint)0 == 0;
		object obj35 = !flag18;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag19 = obj3 != null;
		bool flag20 = !flag19;
		flag3 = false;
		obj8 = null;
		RpcInfo info = default;
		double num15;
		float num16;
		Enumerator<, > val14;
		if (!flag20)
		{
			bool flag21 = (object)obj3 == null;
			obj6 = obj7;
			val = (Enumerator<, >)0;
			val2 = val3;
			num = num2;
			val4 = val5;
			flag3 = false;
			obj8 = null;
			if (flag21)
			{
				goto IL_1d22;
			}
			object obj36 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v168+E4]");
			bool flag22 = (nint)0 == 0;
			object obj37 = !flag22;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X20_v18 (UnityEngine.Object)+20]");
			bool flag23 = (UnityEngine.Object)0 != null;
			bool flag24 = !flag23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X20_v18 (UnityEngine.Object)+20]");
			array = (System.__Canon[])0;
			flag3 = false;
			obj8 = null;
			if (!flag24)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X20_v18 (UnityEngine.Object)+A9]");
				bool flag25 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X20_v18 (UnityEngine.Object)+20]");
				array = (System.__Canon[])0;
				flag3 = false;
				obj8 = null;
				if (flag25)
				{
					bool flag26 = YouAreOn((Vector3)0);
					object obj38 = ((!flag26) ? ((object)0) : ((object)((youAreOn ? 1 : 0) ^ 1)));
					youAreOn = flag26;
					bool flag27 = HandOn((Vector3)0);
					object obj39 = ((!flag27) ? ((object)0) : ((object)((handWasOn ? 1 : 0) ^ 1)));
					bool flag28 = obj39 == null;
					handWasOn = flag27;
					object obj40 = !flag28;
					val8 = (Enumerator<, >)(obj38 | obj40);
					bool flag29 = (int)val8 == 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X20_v18 (UnityEngine.Object)+20]");
					array = (System.__Canon[])0;
					flag3 = false;
					obj8 = null;
					if (!flag29)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj41 = 0;
						object obj42 = obj41;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1403 @ X8_v82+A0]");
						object obj43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X8_v83+18]");
						nint num12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
						object obj44 = num12 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X8_v83+1C]");
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
						object obj45 = num13 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X8_v83+20]");
						nint num14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
						object obj46 = num14 * 0;
						num15 = (double)val5 + (double)obj44;
						num16 = num2 + (float)obj45;
						val14 = (Enumerator<, >)(val3 + obj46);
						if (Live)
						{
							NetworkBool networkBool = true;
							object obj47 = default;
							RPC_Sprung((Vector3)networkBool, (NetworkBool)(&obj47), info);
							obj47 = 0;
							val2 = val14;
							num = num16;
							val4 = (Enumerator<, >)num15;
							bool flag30 = (byte)(&obj47) != 0;
							Vector3 vector = (Vector3)networkBool;
						}
						else
						{
							Sprung((Vector3)1, flesh: false);
							val2 = val14;
							num = num16;
							val4 = (Enumerator<, >)num15;
							bool flag30 = false;
							Vector3 vector = (Vector3)1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
						array = (System.__Canon[])0;
						nint num17 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X0_v180 (Il2CppClass<System.__Canon[]>)+E4]");
						bool flag31 = (nint)0 == 0;
						object obj48 = !flag31;
						if (obj48 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (MonsterPlayer.IsMonster)
						{
							nint num18 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1698 @ X0_v187 (Il2CppClass<System.__Canon[]>)+E4]");
							bool flag32 = (nint)0 == 0;
							object obj49 = !flag32;
							if (obj49 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							nint num19 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1777 @ X0_v190 (Il2CppClass<System.__Canon[]>)+E4]");
							bool flag33 = (nint)0 == 0;
							object obj50 = !flag33;
							nint num20 = num19;
							if (obj50 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								num20 = (nint)array;
							}
							object obj51 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1789 @ X0_v191 (Il2CppClass<System.__Canon[]>)+A0]");
							val8 = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1474 @ X8_v92+E4]");
							bool flag34 = (nint)0 == 0;
							object obj52 = !flag34;
							if (obj52 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if ((UnityEngine.Object)val8 != null)
							{
								nint num21 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1825 @ X0_v195 (Il2CppClass<System.__Canon[]>)+E4]");
								bool flag35 = (nint)0 == 0;
								object obj53 = !flag35;
								if (obj53 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EB7100");
								MonsterPlayer monsterPlayer = default;
								bool flag36 = (object)monsterPlayer == null;
								val13 = val5;
								obj6 = obj7;
								val = (Enumerator<, >)0;
								flag3 = false;
								obj8 = null;
								if (!flag36)
								{
									monsterPlayer.Snared(holds);
									return;
								}
								goto IL_1d22;
							}
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
						object obj54 = 0;
						Vector3 vector2 = (Vector3)obj54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v185 (UnityEngine.Vector3)+E4]");
						bool flag37 = (nint)0 == 0;
						object obj55 = !flag37;
						if (obj55 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaBlast.TrapYou(vector2);
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj56 = 0;
		object obj57 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v48+E4]");
		bool flag38 = (nint)0 == 0;
		object obj58 = !flag38;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj57 = obj56;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v48+A0]");
		obj3 = (UnityEngine.Object)0;
		bool flag39 = (object)obj3 == null;
		obj6 = obj7;
		val = (Enumerator<, >)0;
		val2 = val3;
		num = num2;
		val4 = val5;
		if (!flag39)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB720]");
			obj3 = (UnityEngine.Object)0;
			obj8 = obj3;
			array2 = ((List<System.__Canon>)(object)obj3).ToArray();
			bool flag40 = array2 == null;
			obj6 = obj7;
			val = (Enumerator<, >)0;
			val2 = val3;
			num = num2;
			val4 = val5;
			if (!flag40)
			{
				float num22 = num2 - num2;
				val11 = (Enumerator<, >)(num22 * num22);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB28]");
				obj25 = 0;
				bool flag41 = array2.Length < 1;
				num3 = (float)val3;
				num4 = num2;
				val4 = val11;
				if (flag41)
				{
					goto IL_0b1d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADCC]");
				num7 = 0.0;
				obj3 = (UnityEngine.Object)(array2.Length & 0xFFFFFFFFL);
				obj15 = array2 + 32;
				val2 = val3;
				num = num2;
				float num23 = num6;
				UnityEngine.Object obj59 = obj17;
				object obj60 = 0;
				Enumerator<, > val15 = val11;
				bool flag42 = flag3;
				UnityEngine.Object obj61 = obj3;
				object obj84 = default;
				while (true)
				{
					bool flag43 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj60) < System.Runtime.CompilerServices.Unsafe.As<UnityEngine.Object, UIntPtr>(ref obj3);
					object obj62 = !flag43;
					if (obj62 == null)
					{
						object obj63 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X26_v1+v203 @ X25_v17*8]");
						UnityEngine.Object obj64 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1135 @ X0_v126+E4]");
						obj3 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1135 @ X0_v126+E4]");
						bool flag44 = (nint)0 == 0;
						object obj65 = !flag44;
						if (obj65 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X26_v1+v203 @ X25_v17*8]");
						bool flag45 = (UnityEngine.Object)0 == null;
						bool flag46 = !flag45;
						object obj66 = !flag46;
						num3 = (float)val2;
						float num24 = num;
						val4 = val15;
						flag3 = false;
						obj8 = null;
						if (obj66 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X26_v1+v203 @ X25_v17*8]");
							bool flag47 = (nint)0 == 0;
							obj6 = obj7;
							val = (Enumerator<, >)0;
							num6 = num23;
							obj17 = obj59;
							obj16 = obj60;
							num5 = 1.75;
							obj12 = 17276928;
							val4 = val15;
							array = array2;
							flag3 = false;
							obj8 = null;
							if (flag47)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X26_v1+v203 @ X25_v17*8]");
							bool alive = ((GillaDummy)0).Alive;
							bool flag48 = !alive;
							num3 = (float)val2;
							num24 = num;
							val4 = val15;
							flag3 = false;
							obj8 = null;
							if (!flag48)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X26_v1+v203 @ X25_v17*8]");
								bool standing = ((GillaDummy)0).Standing;
								bool flag49 = !standing;
								num3 = (float)val2;
								num24 = num;
								val4 = val15;
								flag3 = false;
								obj8 = null;
								if (!flag49)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X26_v1+v203 @ X25_v17*8]");
									bool mine = ((GillaDummy)0).Mine;
									bool flag50 = !mine;
									num3 = (float)val2;
									num24 = num;
									val4 = val15;
									flag3 = false;
									obj8 = null;
									if (!flag50)
									{
										object obj67 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X20_v34 (UnityEngine.Object)+68]");
										obj59 = (UnityEngine.Object)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1682 @ X0_v137+E4]");
										bool flag51 = (nint)0 == 0;
										object obj68 = !flag51;
										if (obj68 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag52 = obj59 == null;
										bool flag53 = !flag52;
										object obj69 = !flag53;
										num3 = (float)val2;
										num24 = num;
										val4 = val15;
										flag3 = false;
										obj8 = null;
										if (obj69 == null)
										{
											object obj70 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X20_v34 (UnityEngine.Object)+80]");
											obj59 = (UnityEngine.Object)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1719 @ X0_v141+E4]");
											obj3 = (UnityEngine.Object)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1719 @ X0_v141+E4]");
											bool flag54 = (nint)0 == 0;
											object obj71 = !flag54;
											if (obj71 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag55 = obj59 == null;
											bool flag56 = !flag55;
											object obj72 = !flag56;
											num3 = (float)val2;
											num24 = num;
											val4 = val15;
											flag3 = false;
											obj8 = null;
											if (obj72 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X20_v34 (UnityEngine.Object)+68]");
												bool flag57 = (nint)0 == 0;
												obj6 = obj7;
												val = (Enumerator<, >)0;
												num6 = num23;
												obj17 = obj59;
												obj16 = obj60;
												num5 = 1.75;
												obj12 = 17276928;
												val4 = val15;
												array = array2;
												flag3 = false;
												obj8 = null;
												if (flag57)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X20_v34 (UnityEngine.Object)+68]");
												Vector3 position3 = ((Transform)0).position;
												object obj73 = obj25;
												num23 = jawReach;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1828 @ X0_v147+E4]");
												bool flag58 = (nint)0 == 0;
												object obj74 = !flag58;
												if (obj74 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												val4 = (Enumerator<, >)(num - num2);
												bool flag59 = (double)val4 < num7;
												num3 = (float)val2;
												num24 = num;
												flag3 = false;
												obj8 = null;
												if (!flag59)
												{
													bool flag60 = (double)val4 > 1.75;
													num3 = (float)val2;
													num24 = num;
													flag3 = false;
													obj8 = null;
													if (!flag60)
													{
														object obj75 = val15 - val5;
														object obj76 = val2 - val3;
														object obj77 = obj75 * obj75;
														object obj78 = obj76 * obj76;
														object obj79 = val11 + obj77;
														val4 = (Enumerator<, >)(obj78 + obj79);
														num24 = num23 * num23;
														bool flag61 = (float)val4 < num24;
														num3 = (float)val11;
														flag3 = false;
														obj8 = null;
														if (flag61)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
															Enumerator<, > val16 = val4;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
															object obj80 = val16 * 0;
															float num25 = num24;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
															float num26 = num25 * 0f;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
															object obj81 = val11 * 0;
															object obj82 = val5 + obj80;
															float num27 = num2 + num26;
															object obj83 = val3 + obj81;
															Vector3 vector3;
															if (Live)
															{
																NetworkBool networkBool2 = true;
																RPC_Sprung((Vector3)networkBool2, (NetworkBool)(&obj84), info);
																object obj85 = obj83;
																float num28 = num27;
																object obj86 = obj82;
																bool flag62 = (byte)(&obj84) != 0;
																vector3 = (Vector3)networkBool2;
															}
															else
															{
																Sprung((Vector3)1, flesh: false);
																object obj85 = obj83;
																float num28 = num27;
																object obj86 = obj82;
																bool flag62 = false;
																vector3 = (Vector3)1;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
															object obj87 = 0;
															object obj88 = obj87;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1937 @ X0_v154+E4]");
															bool flag63 = (nint)0 == 0;
															object obj89 = !flag63;
															if (obj89 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X26_v1+v203 @ X25_v17*8]");
															GillaBlast.TrapDummy((GillaDummy)0, vector3);
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
						obj3 = (UnityEngine.Object)array2.Length;
						obj16 = obj60 + 1;
						bool flag64 = (nint)obj16 < array2.Length;
						num4 = num24;
						num6 = num23;
						obj17 = obj59;
						num5 = 1.75;
						val2 = (Enumerator<, >)num3;
						num = num24;
						obj60 = obj16;
						val15 = val4;
						flag42 = flag3;
						obj61 = obj8;
						if (flag64)
						{
							continue;
						}
						goto IL_0b1d;
					}
					IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
					obj6 = obj7;
					val = (Enumerator<, >)0;
					obj17 = obj59;
					num5 = 1.75;
					obj12 = 17276928;
					val4 = val15;
					flag3 = flag42;
					obj8 = obj61;
					break;
				}
			}
		}
		goto IL_1d22;
		IL_1d71:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_1d80;
		IL_2317:
		obj8 = (UnityEngine.Object)obj14;
		val.Dispose();
		bool flag65 = obj30 == null;
		object obj90 = !flag65;
		gillaEgg = null;
		val9 = (Enumerator<, >)0;
		obj6 = null;
		val = val6;
		obj21 = 0;
		val7 = (Enumerator<, >)(ref val);
		val2 = (Enumerator<, >)num3;
		val8 = (Enumerator<, >)(ref val);
		if (obj90 == null)
		{
			gillaEgg = null;
			val9 = (Enumerator<, >)0;
			obj6 = null;
			val = val6;
			obj21 = 0;
			val7 = (Enumerator<, >)(ref val);
			val2 = (Enumerator<, >)num3;
			val8 = (Enumerator<, >)(ref val);
			ex = (NullReferenceException)(&val);
			obj3 = null;
			goto IL_1d71;
		}
		goto IL_1d80;
		IL_1fc5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj91 = 0;
		object obj92 = obj91;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1838 @ X8_v58+A0]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ X8_v59+18]");
		num7 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ X8_v59+1C]");
		num6 = 0f;
		bool live = Live;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ X8_v59+18]");
		double num29 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		double num30 = num29 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ X8_v59+1C]");
		float num31 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		float num32 = num31 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ X8_v59+20]");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		object obj94 = num33 * 0;
		num15 = (double)val5 + num30;
		num16 = num2 + num32;
		val14 = (Enumerator<, >)(val3 + obj94);
		if (live)
		{
			NetworkBool at = true;
			object obj95 = default;
			RPC_Sprung((Vector3)at, (NetworkBool)(&obj95), info);
			obj95 = 0;
			flag3 = (byte)(&obj95) != 0;
		}
		else
		{
			Sprung((Vector3)1, flesh: false);
			flag3 = false;
		}
		((MonsterBrain)obj7).Snared(holds, (Vector3)0);
		val13 = val3;
		num3 = num2;
		num4 = (double)val5;
		obj12 = 22;
		val4 = (Enumerator<, >)holds;
		obj3 = (UnityEngine.Object)17276928;
		obj30 = 0;
		goto IL_2317;
		IL_1d38:
		NullReferenceException ex4 = new NullReferenceException();
		val9 = (Enumerator<, >)0;
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_1d5e;
	}

	private static bool Over(Vector3 p, Vector3 mouth, float reach, float upTo)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = upTo - obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADCC]");
		object obj3 = obj - 0;
		bool flag = (nint)obj3 < 0;
		object obj4 = !flag;
		object obj5 = ~obj4;
		bool flag2;
		bool flag3;
		bool flag4;
		if (obj5 == null)
		{
			object obj7 = default;
			object obj6 = obj - obj7;
			flag2 = (nint)obj6 < 0;
			flag3 = obj6 == null;
			object obj8 = obj ^ obj7;
			object obj9 = obj ^ obj6;
			object obj10 = obj8 & obj9;
			flag4 = (nint)obj10 < 0;
		}
		else
		{
			flag4 = false;
			flag3 = false;
			flag2 = false;
		}
		bool flag5 = flag2 == flag4;
		object obj11 = !flag5;
		object obj12 = obj11 | flag3;
		if (obj12 == null)
		{
			return false;
		}
		object obj14 = default;
		object obj13 = reach - obj14;
		object obj15 = obj2 - obj2;
		object obj17 = default;
		object obj18 = default;
		object obj16 = obj17 - obj18;
		object obj19 = obj13 * obj13;
		object obj20 = obj15 * obj15;
		object obj21 = obj19 + obj20;
		object obj22 = obj16 * obj16;
		object obj23 = obj22 + obj21;
		object obj25 = default;
		object obj24 = obj25 * obj25;
		object obj26 = obj23 - obj24;
		return (nint)obj26 < 0;
	}

	private bool HandOn(Vector3 mouth)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0590: Expected Obj, but got I4
		//IL_05b6: Expected Obj, but got I
		//IL_05d8: Expected Obj, but got I4
		//IL_0603: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I
		//IL_0635: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_0566: Expected I4, but got Obj
		//IL_00dc: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I
		//IL_034e: Expected Obj, but got I4
		//IL_037d: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_01bd: Expected Obj, but got I4
		//IL_01f9: Expected F4, but got I
		//IL_0209: Invalid comparison between F4 and I
		//IL_03d4: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I4
		//IL_044e: Invalid comparison between F4 and I
		//IL_023a: Expected F4, but got I
		//IL_024a: Invalid comparison between F4 and I
		//IL_047b: Invalid comparison between F4 and I
		//IL_0537: Invalid comparison between F4 and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 == null;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			goto IL_054a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v1+8]");
		bool result;
		if ((nint)0 != 0)
		{
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X20_v3 (UnityEngine.Object)+38]");
			bool flag7 = (UnityEngine.Object)0 != null;
			bool flag8 = !flag7;
			object obj15 = default;
			object obj14 = obj15;
			float num2 = default;
			float num = num2;
			float num4 = default;
			float num3 = num4;
			UnityEngine.Object obj16 = null;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X20_v3 (UnityEngine.Object)+38]");
				if ((nint)0 == 0)
				{
					goto IL_0558;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X20_v3 (UnityEngine.Object)+38]");
				Vector3 position = ((Transform)0).position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB28]");
				object obj17 = 0;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v34+E4]");
				bool flag9 = (nint)0 == 0;
				object obj19 = !flag9;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				num3 = num2 - num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADCC]");
				num = 0f;
				float num5 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADCC]");
				bool flag10 = num5 < 0f;
				obj14 = obj15;
				obj16 = null;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD58]");
					num = 0f;
					float num6 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD58]");
					bool flag11 = num6 > 0f;
					obj14 = obj15;
					obj16 = null;
					if (!flag11)
					{
						float num7 = num4 - num4;
						float num8 = num2 - num2;
						obj14 = obj15 - obj15;
						float num9 = num7 * num7;
						float num10 = num8 * num8;
						float num11 = num10 + num9;
						object obj20 = obj14 * obj14;
						num3 = (float)obj20 + num11;
						num = panReach * panReach;
						bool flag12 = !(num3 < num);
						obj16 = null;
						if (!flag12)
						{
							result = true;
							goto IL_05e6;
						}
					}
				}
			}
			object obj21 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v20+E4]");
			bool flag13 = (nint)0 == 0;
			object obj22 = !flag13;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X20_v3 (UnityEngine.Object)+40]");
			if (!((UnityEngine.Object)0 != null))
			{
				goto IL_054a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X20_v3 (UnityEngine.Object)+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X20_v3 (UnityEngine.Object)+40]");
				Vector3 position2 = ((Transform)0).position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB28]");
				object obj23 = 0;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v26+E4]");
				bool flag14 = (nint)0 == 0;
				object obj25 = !flag14;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num12 = num - num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADCC]");
				bool flag15 = num12 < 0f;
				result = false;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD58]");
					bool flag16 = num12 > 0f;
					result = false;
					if (!flag16)
					{
						float num13 = num3 - num4;
						float num14 = num2 - num2;
						object obj26 = obj14 - obj15;
						float num15 = num13 * num13;
						float num16 = num14 * num14;
						float num17 = num16 + num15;
						object obj27 = obj26 * obj26;
						float num18 = (float)obj27 + num17;
						float num19 = panReach * panReach;
						float num20 = num18 - num19;
						bool flag17 = num20 < 0f;
						result = flag17;
					}
				}
				goto IL_05e6;
			}
		}
		goto IL_0558;
		IL_05e6:
		return result;
		IL_0558:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_054a:
		result = false;
		goto IL_05e6;
	}

	public unsafe void RPC_Sprung(Vector3 at, NetworkBool flesh, RpcInfo info = default(RpcInfo))
	{
		//IL_0a78: Expected VT, but got I4
		//IL_012e: Expected Obj, but got I
		//IL_0157: Expected I, but got Obj
		//IL_0183: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I4
		//IL_003d: Expected I4, but got VT
		//IL_01d1: Expected VT, but got I4
		//IL_01d9: Expected I4, but got VT
		//IL_01e6: Expected Obj, but got I4
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected VT, but got Unknown
		//IL_0931: Expected VT, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_021c: Expected I4, but got I8
		//IL_024e: Expected Obj, but got VT
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I4
		//IL_034d: Expected I, but got Obj
		//IL_036f: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_03a5: Expected Obj, but got I
		//IL_03b7: Expected VT, but got I8
		//IL_03d2: Expected VT, but got I4
		//IL_03f5: Expected Obj, but got VT
		//IL_040f: Expected Obj, but got I4
		//IL_0418: Expected VT, but got I4
		//IL_0420: Expected I4, but got VT
		//IL_097b: Expected Obj, but got I4
		//IL_04d6: Expected Obj, but got I4
		//IL_04df: Expected Obj, but got I4
		//IL_04e7: Expected VT, but got Ref
		//IL_04f7: Expected I, but got VT
		//IL_04ff: Expected Obj, but got Ref
		//IL_0514: Expected Obj, but got Ref
		//IL_051d: Expected Obj, but got I4
		//IL_0525: Expected Obj, but got VT
		//IL_02c5: Expected VT, but got I4
		//IL_02ca: Expected VT, but got Obj
		//IL_02db: Expected VT, but got I4
		//IL_09e2: Expected Ref, but got VT
		//IL_09fc: Expected Obj, but got I4
		//IL_0b39: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I
		//IL_0450: Expected I4, but got Obj
		//IL_0450: Expected VT, but got I4
		//IL_0460: Expected Obj, but got I
		//IL_0468: Expected VT, but got Obj
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected VT, but got Unknown
		//IL_0787: Expected Obj, but got I
		//IL_07b1: Expected Obj, but got I4
		//IL_02f2: Invalid comparison between VT and I4
		//IL_07d8: Expected VT, but got I4
		//IL_0a17: Expected Obj, but got VT
		//IL_0a20: Expected Obj, but got I4
		//IL_057f: Expected Obj, but got I
		//IL_05a9: Expected Obj, but got I4
		//IL_030f: Invalid comparison between VT and I4
		//IL_0321: Expected VT, but got I4
		//IL_0326: Expected VT, but got Obj
		//IL_0337: Expected VT, but got I4
		//IL_0806: Expected Obj, but got VT
		//IL_086e: Invalid comparison between Obj and F8
		//IL_0aa7: Expected Obj, but got I
		//IL_0ab7: Expected Obj, but got I
		//IL_0561: Expected Obj, but got I4
		//IL_0b61: Expected Obj, but got I4
		//IL_08ac: Expected Obj, but got I4
		//IL_05de: Expected Obj, but got I
		//IL_05e7: Expected VT, but got Obj
		//IL_05f3: Expected I, but got Obj
		//IL_0600: Expected VT, but got Obj
		//IL_0622: Expected Obj, but got I4
		//IL_08da: Expected VT, but got I
		//IL_06d4: Expected I4, but got VT
		//IL_06cf: Expected native int or pointer, but got VT
		//IL_06f2: Expected VT, but got I4
		//IL_06fb: Expected VT, but got I4
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected I4, but got Unknown
		//IL_0671: Expected VT, but got I4
		//IL_06a1: Expected I, but got Obj
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		object obj2 = default;
		object obj = obj2;
		object obj4 = default;
		object obj3 = obj4;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		NetworkBool networkBool = flesh;
		RpcChannel rpcChannel = (RpcChannel)0;
		MethodBase methodBase = default;
		NetworkRunner networkRunner = default;
		UnityEngine.Object obj7;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		object obj8 = default;
		PlayerRef playerRef2;
		PlayerRef playerRef3;
		RpcInvokeInfo rpcInvokeInfo2;
		UnityEngine.Object obj6;
		bool flag5;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			methodBase = (MethodBase)0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			nint num = (nint)methodBase;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v20 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			bool flag4 = (object)networkRunner == null;
			obj = obj2;
			obj3 = obj4;
			rpcBuilder = (Fusion.RpcBuilder)0;
			flag5 = (byte)(int)flesh != 0;
			obj6 = null;
			obj7 = (UnityEngine.Object)bytePayloadSize;
			if (!flag4)
			{
				int payloadByteCount = bytePayloadSize2 + bytePayloadSize;
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(3122533263u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				obj8 = rpcInvokeInfo >> 32;
				object obj9 = obj8 - 522;
				bool flag6 = (nint)obj9 < 2;
				object obj10 = !flag6;
				object obj11 = ~obj10;
				PlayerRef playerRef;
				if (obj11 == null && (nint)obj8 != 518)
				{
					bool flag7 = (nint)obj8 != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = (PlayerRef)this;
					playerRef3 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag7)
					{
						goto IL_03e7;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag8 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						playerRef = (PlayerRef)0;
						playerRef2 = (PlayerRef)this;
						playerRef3 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag8)
						{
							goto IL_03e7;
						}
					}
				}
				nint num2 = (nint)methodBase;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v64 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
				bool flag9 = (nint)0 == 0;
				object obj12 = !flag9;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB80]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				playerRef = (PlayerRef)0;
				playerRef3 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_03e7;
			}
			goto IL_0937;
		}
		goto IL_0005;
		IL_073e:
		Transform transform;
		Vector3 position = transform.position;
		Fusion.RpcBuilder rpcBuilder4 = default;
		bool flesh2;
		if (isActiveAndEnabled)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X0_v85+E4]");
			bool flag10 = (nint)0 == 0;
			object obj15 = !flag10;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (NetworkApe.Sane((Vector3)0))
			{
				object obj16 = rpcBuilder4 - rpcBuilder;
				object obj17 = obj4 - obj3;
				object obj18 = obj2 - obj;
				object obj19 = obj16 * obj16;
				object obj20 = obj17 * obj17;
				object obj21 = obj19 + obj20;
				object obj22 = obj18 * obj18;
				object obj23 = obj22 + obj21;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2.25))
				{
					object obj24 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X0_v89+E4]");
					bool flag11 = (nint)0 == 0;
					object obj25 = !flag11;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [flesh @ X2 (Fusion.NetworkBool)+4]");
					bool flag12 = NetworkApe.InBudget((PlayerRef)0);
					bool flag13 = !flag12;
					flesh2 = false;
					if (!flag13)
					{
						goto IL_0904;
					}
					return;
				}
				return;
			}
			return;
		}
		return;
		IL_0945:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj26 = default;
		object obj27;
		object obj28 = default;
		OutOfMemoryException ex;
		if ((nint)obj6 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj26 = 1;
			obj27 = obj28;
		}
		else
		{
			bool flag14 = (nint)obj6 != 1;
			OutOfMemoryException ex2 = default;
			ex = ex2;
			if (flag14)
			{
				goto IL_0afc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj29 = default;
			obj27 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj28 = obj29;
		}
		Fusion.RpcBuilder rpcBuilder5 = default;
		((Fusion.RpcBuilder*)rpcBuilder5)->Dispose();
		bool flag15 = obj27 == null;
		object obj30 = !flag15;
		object obj31;
		NullReferenceException ex3;
		if (obj30 == null)
		{
			obj6 = null;
			ex3 = (NullReferenceException)rpcBuilder5;
			obj31 = 0;
			goto IL_0b1f;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex = ex4;
		obj6 = null;
		goto IL_0afc;
		IL_0904:
		NetworkBool networkBool2 = (NetworkBool)(at & 0xFFFFFFFFL);
		bool flag16 = networkBool2;
		Sprung((Vector3)flag16, flesh2);
		return;
		IL_03e7:
		object obj32 = rpcInvokeInfo >> 32;
		bool flag17 = obj32 == null;
		object obj33 = !flag17;
		rpcBuilder = (Fusion.RpcBuilder)0;
		int num3 = (int)rpcInvokeInfo2;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj34 = 0;
			writer.Write((Vector3)12, (int)obj34);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E00]");
			object obj35 = 0;
			playerRef2 = (PlayerRef)obj35;
			NetworkBool value = (NetworkBool)(at & 0xFFFFFFFFL);
			writer.Write(value, 4);
			int num4 = rpcBuilder3.Send();
			rpcBuilder = rpcBuilder4;
			num3 = 4;
		}
		rpcBuilder3.Dispose();
		obj = obj2;
		obj3 = obj4;
		obj26 = 0;
		obj28 = 0;
		rpcBuilder5 = (Fusion.RpcBuilder)(&rpcBuilder3);
		RpcInfo rpcInfo = (RpcInfo)playerRef2;
		nint num5 = (nint)playerRef3;
		networkRunner = (NetworkRunner)(&writer);
		flag5 = (byte)num3 != 0;
		obj6 = null;
		ex3 = (NullReferenceException)(&rpcBuilder3);
		obj31 = 10;
		obj7 = (UnityEngine.Object)rpcInvokeInfo;
		goto IL_0b1f;
		IL_0937:
		ex3 = new NullReferenceException();
		goto IL_0945;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [flesh @ X2 (Fusion.NetworkBool)+18]");
		object obj36 = (nint)0 & (nint)1;
		bool flag18 = obj36 == null;
		object obj37 = !flag18;
		flesh2 = (byte)(int)networkBool != 0;
		if (obj37 != null)
		{
			goto IL_0904;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj38 = 0;
		obj7 = pan;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v77+E4]");
		bool flag19 = (nint)0 == 0;
		object obj40 = !flag19;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj7 != null)
		{
			transform = pan;
			bool flag20 = (object)pan == null;
			object obj41 = !flag20;
			if (obj41 != null)
			{
				goto IL_073e;
			}
			flag5 = false;
			obj6 = null;
		}
		else
		{
			transform = base.transform;
			bool flag21 = (object)transform == null;
			flag5 = false;
			obj6 = null;
			if (!flag21)
			{
				goto IL_073e;
			}
		}
		goto IL_0937;
		IL_0afc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0b1f:
		bool flag22 = obj26 == null;
		object obj42 = !flag22;
		if (obj42 == null)
		{
			if ((nint)obj31 != 10)
			{
				bool flag23 = obj31 == null;
				object obj43 = !flag23;
				if (obj43 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj44 = 0;
			object obj45 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X0_v6+E4]");
			bool flag24 = (nint)0 == 0;
			object obj46 = !flag24;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj45 = obj44;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X0_v6+A0]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v5+18]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v5+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB78]");
				object obj49 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj49);
				nint num6 = (nint)methodBase;
				RpcInvokeInfo invokeInfo = (RpcInvokeInfo)((object)obj7 | obj8);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X8_v10 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
				bool flag25 = (nint)0 == 0;
				object obj50 = !flag25;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, invokeInfo, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v276 @ X27_v1+18] (should have been resolved before IL gen)");
				object obj51 = default;
				obj = obj51;
				object obj52 = default;
				obj26 = obj52;
				PlayerRef playerRef = invalid2;
				num5 = unchecked((nint)null);
				methodBase = methodFromHandle;
			}
			bool flag26 = (object)obj7 == null;
			object obj53 = !flag26;
			if (obj53 == null)
			{
				RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
				((NetworkBool*)(nint)flesh)->RawValue = (int)rpcBuilder5;
				obj3 = obj26;
				rpcBuilder = rpcBuilder5;
				rpcInfo = (RpcInfo)0;
				networkBool = (NetworkBool)0;
				rpcChannel = (RpcChannel)0;
				goto IL_0005;
			}
			return;
		}
		goto IL_0945;
	}

	private void Sprung(Vector3 at, bool flesh)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0858: Expected Obj, but got I4
		//IL_0876: Expected Obj, but got I
		//IL_08ab: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got F4
		//IL_0270: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I
		//IL_02b9: Expected VT, but got I4
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02e6: Expected Obj, but got I
		//IL_0305: Expected VT, but got I4
		//IL_08c9: Expected Obj, but got I
		//IL_08e9: Expected Obj, but got I
		//IL_0913: Expected Obj, but got I4
		//IL_033d: Expected Obj, but got I4
		//IL_038e: Expected F4, but got I
		//IL_038e: Expected F4, but got I
		//IL_038e: Expected F4, but got I
		//IL_038e: Expected VT, but got I4
		//IL_0931: Expected Obj, but got I
		//IL_0941: Expected Obj, but got I
		//IL_0961: Expected Obj, but got I
		//IL_0983: Expected Obj, but got I4
		//IL_03b6: Expected VT, but got I4
		//IL_03b6: Expected VT, but got I4
		//IL_03c6: Expected Obj, but got I
		//IL_0587: Expected Obj, but got I4
		//IL_03e5: Expected Obj, but got I
		//IL_03ed: Expected I, but got Obj
		//IL_03fe: Expected I, but got Obj
		//IL_040e: Expected Obj, but got I
		//IL_0438: Expected Obj, but got I4
		//IL_05b6: Expected Obj, but got I
		//IL_049e: Expected VT, but got Obj
		//IL_04d8: Expected Obj, but got I
		//IL_04e8: Expected Obj, but got I
		//IL_04f8: Expected F8, but got I
		//IL_0501: Expected VT, but got I4
		//IL_060d: Expected Obj, but got I
		//IL_06b2: Invalid comparison between F4 and I4
		//IL_0703: Expected Obj, but got I
		//IL_077a: Expected Obj, but got I8
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected Obj, but got Unknown
		//IL_0791: Expected Obj, but got I4
		//IL_09aa: Expected Obj, but got I4
		//IL_07ce: Expected F4, but got I
		//IL_07e7: Expected Obj, but got I
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		bool flag = (byte)(~(sprung ? 1u : 0u)) != 0;
		object obj3 = !flag;
		if (obj3 != null)
		{
			return;
		}
		shutT = 0f;
		sprung = true;
		float num = (sprungAtHere = Time.time);
		if (Live)
		{
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			bool flag2 = (object)((SimulationBehaviour)this)._object == null;
			byte b = 0;
			if (!flag2)
			{
				object obj4 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
				bool flag3 = obj4 == null;
				object obj5 = !flag3;
				b = 0;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
					object obj7 = default;
					object obj6 = obj7 & 1;
					bool flag4 = obj6 == null;
					b = 0;
					if (!flag4)
					{
						State = 2;
						b = 2;
					}
				}
			}
		}
		else
		{
			stateHere = 2;
			byte b = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		shown = 2;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform;
		if (pan != null)
		{
			transform = pan;
			bool flag6 = (object)pan == null;
			object obj11 = !flag6;
			if (obj11 != null)
			{
				goto IL_01ec;
			}
		}
		else
		{
			transform = base.transform;
			if ((object)transform != null)
			{
				goto IL_01ec;
			}
		}
		goto IL_081a;
		IL_01ec:
		Vector3 position = transform.position;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj12 = 0;
			object obj13 = obj2 + 16;
			obj13 = num;
			object obj14 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v19+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
			object obj16 = 0;
			float pitchMin = default;
			float num2 = default;
			Sfx.Play(snapSounds, (Vector3)0, num, pitchMin, num2);
			object obj17 = at & 1;
			bool flag8 = obj17 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
			object obj18 = 0;
			double num3 = 1.0;
			nint num4 = 0;
			Vector3 vector = (Vector3)0;
			if (!flag8)
			{
				object obj19 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v43+E4]");
				bool flag9 = (nint)0 == 0;
				object obj20 = !flag9;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AudioClip[] clips = biteSounds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+10]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+14]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+18]");
				Sfx.Play(clips, (Vector3)0, num5, num6, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
				object obj22 = 0;
				object obj23 = obj21;
				object obj24 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v31+A0]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v47+E4]");
				bool flag10 = (nint)0 == 0;
				object obj26 = !flag10;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float size = default;
				Blood.Burst((Vector3)0, (Vector3)0, null, size);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB90]");
				object obj28 = 0;
				num4 = (nint)obj28;
				Action action = default;
				action._002Ector(obj2, (IntPtr)obj28);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
				object obj29 = 0;
				object obj30 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v52+E4]");
				bool flag11 = (nint)0 == 0;
				object obj31 = !flag11;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaWounds.Later(action);
				float time = Time.time;
				float num7 = time + holds;
				heldTill = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X24_v6+8]");
				_ = 0;
				holdsAt = (Vector3)obj13;
				float time2 = Time.time;
				float num8 = time2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
				num = (nextRattle = num8 + 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v32+20]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v32+1C]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v32+18]");
				num3 = 0.0;
				vector = (Vector3)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj32 = 0;
			object obj33 = obj8;
			object obj34 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v15+A0]");
			object obj35 = 0;
			UnityEngine.Object obj36 = (UnityEngine.Object)obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v23+E4]");
			bool flag12 = (nint)0 == 0;
			object obj37 = !flag12;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!((UnityEngine.Object)obj35 != null))
			{
				return;
			}
			if (obj35 != null)
			{
				object obj38 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v27+E4]");
				bool flag13 = (nint)0 == 0;
				object obj39 = !flag13;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X20_v6 (UnityEngine.Object)+20]");
				if (!((UnityEngine.Object)0 != null))
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X20_v6 (UnityEngine.Object)+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X20_v6 (UnityEngine.Object)+20]");
					Vector3 position2 = ((Transform)0).position;
					float num9 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+10]");
					float num10 = num9 - 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
					float num11 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+14]");
					float num12 = num11 - 0f;
					float num13 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+18]");
					float num14 = num13 - 0f;
					float num15 = num10 * num10;
					float num16 = num12 * num12;
					float num17 = num15 + num16;
					float num18 = num14 * num14;
					float num19 = num17 + num18;
					if (!(num19 < 1.1083448E+09f) || !GillaBackroomsSwitch.OnYourSide(position2))
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB98]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj41 = default;
					if (obj41 != null)
					{
						_ = 4;
						_ = 5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v35+18]");
						if ((nint)0 < (nint)1)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v35+18]");
						object obj42 = 0 & 0xFFFFFFFFL;
						object obj43 = obj41 + 32;
						object obj44 = 0;
						InputDevice inputDevice = default;
						while (true)
						{
							bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42);
							object obj45 = !flag14;
							if (obj45 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X21_v8+v429 @ X20_v8*4]");
							InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
							bool flag15 = inputDevice.SendHapticImpulse(0u, 0.5f, 0f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v35+18]");
							obj42 = 0;
							obj44++;
							object obj46 = obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v35+18]");
							if ((nint)obj46 >= 0)
							{
								return;
							}
						}
						goto IL_0828;
					}
				}
			}
		}
		goto IL_081a;
		IL_081a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0828;
		IL_0828:
		throw new IndexOutOfRangeException();
	}

	private void Rattles()
	{
		//IL_0053: Expected F4, but got I
		//IL_007b: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_00fa: Expected F4, but got I
		//IL_00fa: Expected F4, but got I
		//IL_00fa: Expected F4, but got VT
		//IL_00fa: Expected VT, but got I4
		float time = Time.time;
		if (!(time < heldTill))
		{
			return;
		}
		float time2 = Time.time;
		if (!(time2 < nextRattle))
		{
			float time3 = Time.time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num = UnityEngine.Random.Range(0f, 1.5f);
			float num2 = time3 + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj = 0;
			object obj2 = obj;
			nextRattle = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AudioClip[] clips = rattleSounds;
			Vector3 vector = holdsAt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+1BC]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+1C0]");
			Sfx.Play(clips, (Vector3)0, (float)vector, num3, 0f);
		}
	}

	private void Shuts()
	{
		//IL_0024: Invalid comparison between F4 and I4
		if (~(sprung ? 1u : 0u) == 0 && !(shutT < 0f))
		{
			float deltaTime = Time.deltaTime;
			float num = shutT + deltaTime;
			float num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD4]");
			float num3 = num2 / 0f;
			shutT = num;
			float k;
			if ((double)num3 < 1.0)
			{
				k = num3 * num3;
			}
			else
			{
				float num4 = num3 + -1f;
				float num5 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE78]");
				float num6 = num5 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
				float num7 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
				float num8 = num7 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				float num9 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC4C]");
				float num10 = num9 * 0f;
				float num11 = num10 * num8;
				k = num11 + 1f;
			}
			Pose(k);
			PoseDog(shutT);
			if ((double)num3 > 8.0)
			{
				Pose(1f);
				PoseDog(1f);
				shutT = -1f;
			}
		}
	}

	private void Pose(float k)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0cb1: Expected Obj, but got I4
		//IL_0054: Expected VT, but got I4
		//IL_02ff: Expected Obj, but got I4
		//IL_0344: Expected VT, but got I4
		//IL_05ce: Invalid comparison between F4 and I4
		//IL_05dd: Expected F8, but got I4
		//IL_00ce: Expected Obj, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0198: Expected Obj, but got VT
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_02bd: Expected VT, but got I4
		//IL_02d0: Expected VT, but got I4
		//IL_0cf8: Expected Obj, but got I4
		//IL_0691: Expected VT, but got I4
		//IL_03be: Expected Obj, but got I
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_0488: Expected Obj, but got VT
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_0508: Expected Obj, but got I
		//IL_0525: Expected Obj, but got I
		//IL_05ad: Expected VT, but got I4
		//IL_05c0: Expected VT, but got I4
		//IL_093c: Expected Obj, but got I4
		//IL_0981: Expected VT, but got I4
		//IL_0c22: Expected Obj, but got I4
		//IL_070b: Expected Obj, but got I
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected Obj, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected Obj, but got Unknown
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected Obj, but got Unknown
		//IL_07d5: Expected Obj, but got VT
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected Obj, but got Unknown
		//IL_0855: Expected Obj, but got I
		//IL_0872: Expected Obj, but got I
		//IL_08fa: Expected VT, but got I4
		//IL_090d: Expected VT, but got I4
		//IL_09fb: Expected Obj, but got I
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Expected Obj, but got Unknown
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Expected Obj, but got Unknown
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa5: Expected Obj, but got Unknown
		//IL_0ac5: Expected Obj, but got VT
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Expected Obj, but got Unknown
		//IL_0b45: Expected Obj, but got I
		//IL_0b62: Expected Obj, but got I
		//IL_0bea: Expected VT, but got I4
		//IL_0bf3: Expected VT, but got I4
		//IL_0c81: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = jawL != null;
		bool flag3 = !flag2;
		float num = k;
		Quaternion quaternion = (Quaternion)0;
		Vector3 axis = default;
		float num4 = default;
		if (!flag3)
		{
			float num2 = jawAngleL * k;
			Quaternion quaternion2 = Quaternion.Internal_AngleAxis(num2, ref axis);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+168]");
			float num3 = 0f * num4;
			float num5 = (float)openL * num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+168]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+A8]");
			object obj4 = num6 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+164]");
			float num7 = 0f * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+168]");
			object obj5 = 0 * jawAxisL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+160]");
			float num8 = 0f * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+168]");
			float num9 = 0f * num2;
			float num10 = (float)openL * num4;
			float num11 = num3 - num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+160]");
			object obj6 = 0 * jawAxisL;
			Quaternion quaternion3 = openL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+A8]");
			object obj7 = quaternion3 * 0;
			float num12 = (float)obj4 + num7;
			object obj8 = openL * jawAxisL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+164]");
			object obj9 = 0 * jawAxisL;
			float num13 = (float)obj5 + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+164]");
			float num14 = 0f * num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+160]");
			float num15 = 0f * num2;
			float num16 = num9 + num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+160]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+A8]");
			object obj10 = num17 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+164]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+A8]");
			object obj11 = num18 * 0;
			float num19 = num11 - (float)obj6;
			float num20 = (float)obj8 + num12;
			float num21 = num14 + num13;
			float num22 = (float)obj10 + num16;
			num4 = num19 - (float)obj11;
			float num23 = num20 - num15;
			float num24 = num21 - (float)obj7;
			num = num22 - (float)obj9;
			jawL.localRotation = (Quaternion)0;
			axis = jawAxisL;
			quaternion = (Quaternion)0;
		}
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = jawR != null;
		bool flag6 = !flag5;
		Quaternion quaternion4 = (Quaternion)0;
		if (!flag6)
		{
			float num25 = jawAngleR * k;
			Quaternion quaternion5 = Quaternion.Internal_AngleAxis(num25, ref axis);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+178]");
			float num26 = 0f * num4;
			float num27 = (float)openR * num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+178]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+B4]");
			object obj14 = num28 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+174]");
			float num29 = 0f * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+178]");
			object obj15 = 0 * jawAxisR;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+170]");
			float num30 = 0f * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+178]");
			float num31 = 0f * num25;
			float num32 = (float)openR * num4;
			float num33 = num26 - num27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+170]");
			object obj16 = 0 * jawAxisR;
			Quaternion quaternion6 = openR;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+B4]");
			object obj17 = quaternion6 * 0;
			float num34 = (float)obj14 + num29;
			object obj8 = openR * jawAxisR;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+174]");
			object obj18 = 0 * jawAxisR;
			float num35 = (float)obj15 + num30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+174]");
			float num36 = 0f * num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+170]");
			float num37 = 0f * num25;
			float num38 = num31 + num32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+170]");
			nint num39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+B4]");
			object obj19 = num39 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+174]");
			nint num40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+B4]");
			object obj20 = num40 * 0;
			float num41 = num33 - (float)obj16;
			float num20 = (float)obj8 + num34;
			float num21 = num36 + num35;
			float num22 = (float)obj19 + num38;
			num4 = num41 - (float)obj20;
			float num23 = num20 - num37;
			float num24 = num21 - (float)obj17;
			num = num22 - (float)obj18;
			jawR.localRotation = (Quaternion)0;
			axis = jawAxisR;
			quaternion4 = (Quaternion)0;
		}
		bool flag7 = k < 0f;
		double num42 = 0.0;
		double num43 = num;
		if (!flag7)
		{
			bool flag8 = !((double)k > 1.0);
			num42 = k;
			num43 = 1.0;
			if (!flag8)
			{
				num42 = 1.0;
				num43 = 1.0;
			}
		}
		object obj21 = obj;
		double num44 = num42 * num42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v14+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num45 = num42 * num44;
		bool flag10 = springL != null;
		bool flag11 = !flag10;
		Quaternion quaternion7 = (Quaternion)0;
		if (!flag11)
		{
			float num46 = (float)num45 * springAngleL;
			Quaternion quaternion8 = Quaternion.Internal_AngleAxis(num46, ref axis);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+188]");
			float num47 = 0f * num4;
			float num48 = (float)openSL * num46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+188]");
			nint num49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+C8]");
			object obj23 = num49 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+184]");
			float num50 = 0f * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+188]");
			object obj24 = 0 * springAxisL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+180]");
			float num51 = 0f * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+188]");
			float num52 = 0f * num46;
			float num53 = (float)openSL * num4;
			float num54 = num47 - num48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+180]");
			object obj25 = 0 * springAxisL;
			Quaternion quaternion9 = openSL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+C8]");
			object obj26 = quaternion9 * 0;
			float num55 = (float)obj23 + num50;
			object obj8 = openSL * springAxisL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+184]");
			object obj27 = 0 * springAxisL;
			float num56 = (float)obj24 + num51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+184]");
			float num57 = 0f * num46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+180]");
			float num58 = 0f * num46;
			float num59 = num52 + num53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+180]");
			nint num60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+C8]");
			object obj28 = num60 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+184]");
			nint num61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+C8]");
			object obj29 = num61 * 0;
			float num62 = num54 - (float)obj25;
			float num20 = (float)obj8 + num55;
			float num21 = num57 + num56;
			float num22 = (float)obj28 + num59;
			num4 = num62 - (float)obj29;
			float num23 = num20 - num58;
			float num24 = num21 - (float)obj26;
			num43 = (double)num22 - (double)obj27;
			springL.localRotation = (Quaternion)0;
			axis = springAxisL;
			quaternion7 = (Quaternion)0;
		}
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v19+E4]");
		bool flag12 = (nint)0 == 0;
		object obj31 = !flag12;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag13 = springR != null;
		bool flag14 = !flag13;
		Quaternion quaternion10 = (Quaternion)0;
		if (!flag14)
		{
			float num63 = (float)num45 * springAngleR;
			Quaternion quaternion11 = Quaternion.Internal_AngleAxis(num63, ref axis);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+198]");
			float num64 = 0f * num4;
			float num65 = (float)openSR * num63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+198]");
			nint num66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+D4]");
			object obj32 = num66 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+194]");
			float num67 = 0f * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+198]");
			object obj33 = 0 * springAxisR;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+190]");
			float num68 = 0f * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+198]");
			float num69 = 0f * num63;
			float num70 = (float)openSR * num4;
			float num71 = num64 - num65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+190]");
			object obj34 = 0 * springAxisR;
			Quaternion quaternion12 = openSR;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+D4]");
			object obj35 = quaternion12 * 0;
			float num72 = (float)obj32 + num67;
			object obj8 = openSR * springAxisR;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+194]");
			object obj36 = 0 * springAxisR;
			float num73 = (float)obj33 + num68;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+194]");
			float num74 = 0f * num63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+190]");
			float num75 = 0f * num63;
			float num76 = num69 + num70;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+190]");
			nint num77 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+D4]");
			object obj37 = num77 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+194]");
			nint num78 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBearTrap)+D4]");
			object obj38 = num78 * 0;
			float num79 = num71 - (float)obj34;
			float num20 = (float)obj8 + num72;
			float num21 = num74 + num73;
			float num22 = (float)obj37 + num76;
			num4 = num79 - (float)obj38;
			float num23 = num20 - num75;
			float num24 = num21 - (float)obj35;
			num43 = (double)num22 - (double)obj36;
			springR.localRotation = (Quaternion)0;
			quaternion10 = (Quaternion)0;
		}
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v24+E4]");
		bool flag15 = (nint)0 == 0;
		object obj40 = !flag15;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (pan != null)
		{
			pan.localPosition = (Vector3)0;
		}
	}

	private void PoseDog(float t)
	{
		//IL_0010: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_007c: Invalid comparison between F4 and I4
		//IL_008b: Expected F8, but got I4
		//IL_0269: Invalid comparison between F4 and I
		//IL_010e: Invalid comparison between F4 and I4
		//IL_011d: Expected F8, but got I4
		//IL_021b: Expected VT, but got I4
		//IL_031b: Invalid comparison between F8 and I4
		//IL_032a: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = dog == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		float num = t;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE08]");
		float num2 = num / 0f;
		bool flag4 = num2 < 0f;
		double num3 = 0.0;
		if (!flag4)
		{
			bool flag5 = !((double)num2 > 1.0);
			num3 = num2;
			if (!flag5)
			{
				num3 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD4]");
		float angle;
		if (t > 0f)
		{
			float num4 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC9C]");
			float num5 = num4 + 0f;
			float num6 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			float num7 = num6 / 0f;
			bool flag6 = num7 < 0f;
			double num8 = 0.0;
			if (!flag6)
			{
				bool flag7 = !((double)num7 > 1.0);
				num8 = num7;
				if (!flag7)
				{
					num8 = 1.0;
				}
			}
			double num9 = num8 + num8;
			double num10 = num8 * 3.0;
			double num11 = num8 * num9;
			double num12 = num8 * num11;
			double num13 = num8 * num10;
			double num14 = num13 - num12;
			double num15 = 1.0 - num14;
			double num16 = num15 * 0.0;
			double num17 = num14 + num16;
			bool flag8 = num17 < 0.0;
			double num18 = 0.0;
			if (!flag8)
			{
				bool flag9 = !(num17 > 1.0);
				num18 = num17;
				if (!flag9)
				{
					num18 = 1.0;
				}
			}
			float num19 = dogRests - dogThrown;
			double num20 = (double)num19 * num18;
			angle = dogThrown + (float)num20;
		}
		else
		{
			double num21 = 1.0 - num3;
			double num22 = num21 * num21;
			double num23 = num21 * num22;
			double num24 = 1.0 - num23;
			double num25 = num24 * (double)dogThrown;
			angle = (float)num25;
		}
		Vector3 axis = default;
		Quaternion quaternion = Quaternion.Internal_AngleAxis(angle, ref axis);
		dog.localRotation = (Quaternion)0;
	}

	private void Goes()
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_0150: Expected I4, but got I8
		//IL_0230: Expected Obj, but got I8
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I4
		//IL_0255: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I4
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_032a: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I4
		if (~(sprung ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = item == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		GillaItem gillaItem = item;
		if ((object)item != null)
		{
			bool flag4 = (byte)(~(gillaItem.Gone__BackingField ? 1u : 0u)) != 0;
			object obj5 = !flag4;
			if (obj5 != null || !item.Mine)
			{
				return;
			}
			GillaItem gillaItem2 = item;
			if ((object)item != null)
			{
				if ((int)(gillaItem2.Hand__BackingField & 0x80000000L) == 0)
				{
					return;
				}
				float time = Time.time;
				float num = time - sprungAtHere;
				if (num < lasts)
				{
					return;
				}
				GillaItem gillaItem3 = item;
				if ((object)item != null)
				{
					Collider[] array = gillaItem3.Colliders__BackingField;
					if (gillaItem3.Colliders__BackingField != null)
					{
						if (array.Length < 1)
						{
							goto IL_0377;
						}
						object obj6 = array.Length & 0xFFFFFFFFL;
						object obj7 = gillaItem3.Colliders__BackingField + 32;
						object obj8 = 0;
						object obj9 = 0;
						bool flag5 = false;
						while (true)
						{
							bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
							object obj10 = !flag6;
							if (obj10 != null)
							{
								break;
							}
							object obj11 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v17+E4]");
							bool flag7 = (nint)0 == 0;
							object obj12 = !flag7;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X24_v6+v182 @ X23_v7*8]");
							bool flag8 = (UnityEngine.Object)0 != null;
							bool flag9 = !flag8;
							obj9 = 0;
							flag5 = false;
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X24_v6+v182 @ X23_v7*8]");
								if ((nint)0 == 0)
								{
									goto IL_03a3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X24_v6+v182 @ X23_v7*8]");
								((Collider)0).enabled = false;
								obj9 = 0;
								flag5 = false;
							}
							obj6 = array.Length;
							obj8++;
							if ((nint)obj8 < array.Length)
							{
								continue;
							}
							goto IL_0377;
						}
						goto IL_03b1;
					}
				}
			}
		}
		goto IL_03a3;
		IL_03b1:
		throw new IndexOutOfRangeException();
		IL_0377:
		if ((object)item != null)
		{
			item.Recycle();
			return;
		}
		goto IL_03a3;
		IL_03a3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_03b1;
	}

	public GillaBearTrap()
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003f: Expected VT, but got I
		//IL_0066: Expected Obj, but got I
		//IL_0078: Expected F4, but got I
		//IL_008a: Expected VT, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_00b9: Expected VT, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_00f3: Expected VT, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0132: Expected F4, but got I
		//IL_0144: Expected VT, but got I
		//IL_016e: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v1+3C]");
		jawAxisL = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v1+44]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v1+44]");
		jawAngleL = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X9_v2+3C]");
		jawAxisR = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X9_v2+44]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v3+3C]");
		springAxisL = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v3+44]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+A0]");
		object obj5 = 0;
		panDip = 0.01f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X9_v4+3C]");
		springAxisR = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X9_v4+44]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+A0]");
		object obj6 = 0;
		lasts = 25f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D350]");
		dogThrown = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+48]");
		dogAxis = (Vector3)0;
		shutT = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B740]");
		holds = 0f;
		base._002Ector();
	}

	static GillaBearTrap()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBB0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB28]");
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

	public override void CopyBackingFieldsToState(bool P_0)
	{
		State = _State;
	}

	public override void CopyStateToBackingFields()
	{
		byte state = State;
		_State = state;
	}

	protected unsafe static void RPC_Sprung_0040Invoker3122533263([In] ref RpcInvokeContext context)
	{
		//IL_0012: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_0222: Expected VT, but got I4
		//IL_0248: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_00ed: Expected I, but got Obj
		//IL_0116: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_0096: Expected VT, but got Obj
		//IL_00c8: Expected VT, but got I4
		//IL_014a: Expected Obj, but got I
		//IL_0186: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 _, 12);
		rpcDataReader.Read(out NetworkBool value2, 4);
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB78]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ X21_v3+18] (should have been resolved before IL gen)");
			info = (RpcInfo)0;
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v9+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaBearTrap gillaBearTrap = (GillaBearTrap)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB28]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaBearTrap;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<GillaBearTrap>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X1_v7+130]");
		bool flag3 = num2 < 0;
		object obj12 = !flag3;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<GillaBearTrap>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X1_v7+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v17-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaBearTrap.RPC_Sprung((Vector3)value2, (NetworkBool)(&obj15), info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}
}
