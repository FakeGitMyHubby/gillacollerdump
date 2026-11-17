using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.Rendering;

public class GillaSplashDirector : MonoBehaviour
{
	private sealed class Copy
	{
		public SkinnedMeshRenderer glow;

		public int wanted = -1;

		public bool screenOnly;

		public Copy()
		{
			//IL_000f: Expected I4, but got I8
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<GillaSplashSpectate.Footprint, Vector3> _003C_003E9__52_1;

		public static Func<GillaSplashPool, GillaSplashLayout.Hall> _003C_003E9__52_0;

		public static Func<GameObject, Stack<GameObject>> _003C_003E9__54_0;

		public static Func<GillaSplashPool, List<GillaSplashSpectate.Footprint>> _003C_003E9__57_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7888]");
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

		internal unsafe GillaSplashLayout.Hall _003Cget_Halls_003Eb__52_0(GillaSplashPool p)
		{
			//IL_0128: Expected VT, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_0155: Expected Obj, but got I
			//IL_0165: Expected Obj, but got I
			//IL_0175: Expected Obj, but got I
			//IL_0198: Expected Obj, but got I4
			//IL_00f1: Expected Obj, but got Ref
			//IL_0103: Expected native int or pointer, but got VT
			//IL_0110: Expected native int or pointer, but got VT
			//IL_0086: Expected Obj, but got I4
			//IL_01b6: Expected Obj, but got I
			//IL_01d0: Expected Obj, but got I
			//IL_01e1: Expected I, but got Obj
			//IL_01ff: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			if ((object)p != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7888]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+A0]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BA8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6+8]");
				Func<GillaSplashSpectate.Footprint, Vector3> selector = (Func<GillaSplashSpectate.Footprint, Vector3>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6+8]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj8 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v10+A0]");
						obj4 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BB8]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BC0]");
					object obj10 = 0;
					Func<GillaSplashSpectate.Footprint, Vector3> func = default;
					func._002Ector(obj4, (IntPtr)obj10);
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v9+A0]");
					object obj12 = (nint)0 + (nint)8;
					obj12 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					selector = func;
				}
				IEnumerable<Vector3> source = Enumerable.Select(p.standing, selector);
				Vector3[] pillars = Enumerable.ToArray(source);
				Rect water = default;
				object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref water, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				GillaSplashLayout.Hall hall = default;
				System.Runtime.CompilerServices.Unsafe.Write(&((GillaSplashLayout.Hall*)(nint)hall)->water, water);
				System.Runtime.CompilerServices.Unsafe.Write(&((GillaSplashLayout.Hall*)(nint)hall)->pillars, pillars);
				GillaSplashLayout.Hall result = default;
				return result;
			}
			NullReferenceException ex = new NullReferenceException();
			return (GillaSplashLayout.Hall)ex;
		}

		internal Vector3 _003Cget_Halls_003Eb__52_1(GillaSplashSpectate.Footprint s)
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}

		internal Stack<GameObject> _003CPrepare_003Eb__54_0(GameObject _)
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BC8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Stack<System.__Canon> stack = default;
			stack._002Ector();
			return (Stack<GameObject>)(object)stack;
		}

		internal List<GillaSplashSpectate.Footprint> _003CPut_003Eb__57_0(GillaSplashPool _)
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<GillaSplashSpectate.Footprint> list = default;
			list._002Ector();
			return list;
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public int style;

		public int round;

		public System.Random rng;

		internal unsafe IEnumerable<GillaSplashLayout.Spot> _003CPreview_003Eb__0(GillaSplashLayout.Hall hall)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0072: Expected Obj, but got I4
			//IL_003f: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Rect rect = default;
			return (IEnumerable<GillaSplashLayout.Spot>)GillaSplashLayout.MakeHall((GillaSplashLayout.Hall)(&rect), style, round, rng);
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public GillaSplashLayout.Spot spot;

		internal bool _003CPut_003Eb__1(GillaSplashPool p)
		{
			//IL_015f: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_0071: Invalid comparison between I and VT
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected Obj, but got Unknown
			//IL_0120: Expected Obj, but got I
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected Obj, but got Unknown
			if ((object)p != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashDirector+<>c__DisplayClass57_0)+14]");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0) >= System.Runtime.CompilerServices.Unsafe.As<Rect, UIntPtr>(ref p.area))
				{
					Rect area = p.area;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaSplashPool)+2C]");
					object obj4 = area + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashDirector+<>c__DisplayClass57_0)+14]");
					if (0 < (nint)obj4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashDirector+<>c__DisplayClass57_0)+18]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaSplashPool)+28]");
						if (num >= 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaSplashPool)+28]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (GillaSplashPool)+30]");
							object obj5 = num2 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashDirector+<>c__DisplayClass57_0)+18]");
							object obj6 = 0 - obj5;
							return (nint)obj6 < 0;
						}
					}
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public Transform[] all;

		internal Transform _003CWading_003Eb__0(string n)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_0045: Expected Obj, but got I
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected Obj, but got Unknown
			//IL_0085: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BE0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BF0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BF8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BE8]");
				object obj5 = 0;
				object obj6 = obj2 + 16;
				obj6 = n;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Func<System.__Canon, bool> func = default;
				func._002Ector(obj2, (IntPtr)obj4);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35CBB88");
				Transform result = default;
				return result;
			}
			return (Transform)(object)new NullReferenceException();
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_1
	{
		public string n;

		internal bool _003CWading_003Eb__1(Transform t)
		{
			//IL_0055: Expected I4, but got Obj
			if ((object)t != null)
			{
				string name = t.name;
				return name == n;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public GillaSplashPool[] pools;

	public GameObject[] kinds;

	public Material[] decks;

	public Material[] sides;

	public Material outline;

	public GameObject monsterPrefab;

	public Transform spawn;

	public float drag;

	public float noiseEvery;

	public AudioClip[] splashSounds;

	public AudioClip[] dipSounds;

	public AudioClip[] wadeSounds;

	private static GillaSplashDirector Instance__BackingField;

	private const float CheckEvery = default(float);

	private readonly List<GameObject> local;

	private float offlineFor;

	private float nextCheck;

	private readonly bool[] wasIn;

	private readonly Vector3[] lastAt;

	private readonly float[] nextWake;

	private readonly Dictionary<Transform, (Vector3, float)> others;

	private Vector3 lastNoise;

	private float nextNoise;

	private Renderer murk;

	private Material murkMat;

	private AudioLowPassFilter muffle;

	private readonly float[] asked;

	private readonly float[] sunk;

	private static readonly int SunkId;

	private readonly List<GameObject> standing;

	private readonly List<int> standingKinds;

	private readonly List<GillaSinkPlatform> sinkers;

	private Transform[] hallGroups;

	private Stack<GameObject>[] spare;

	private bool[] hasPlatforms;

	private int hallsOut;

	private int built;

	private readonly Dictionary<GillaSplashMonster, Transform[]> limbs;

	private readonly Dictionary<Transform, (Vector3, float)> wading;

	private int Style__BackingField;

	private const float WakeEvery = default(float);

	private const float WakeSpeed = default(float);

	public static GillaSplashDirector Instance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
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
			return (GillaSplashDirector)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
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

	public int Style
	{
		get
		{
			return Style__BackingField;
		}
		private set
		{
			Style__BackingField = value;
		}
	}

	public IReadOnlyList<GameObject> Standing => (IReadOnlyList<GameObject>)standing;

	public IReadOnlyList<GillaSinkPlatform> Sinkers => (IReadOnlyList<GillaSinkPlatform>)sinkers;

	public GillaSplashLayout.Hall[] Halls
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d7: Expected Obj, but got I4
			//IL_016d: Expected Obj, but got I
			//IL_017e: Expected Obj, but got I
			//IL_01a1: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got I
			//IL_010f: Expected Obj, but got I
			//IL_0120: Expected I, but got Obj
			//IL_013e: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7888]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6+10]");
			Func<System.__Canon, GillaSplashLayout.Hall> selector = (Func<System.__Canon, GillaSplashLayout.Hall>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6+10]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v10+A0]");
					obj4 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78A8]");
				object obj9 = 0;
				Func<System.__Canon, GillaSplashLayout.Hall> func = default;
				func._002Ector(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9+A0]");
				object obj11 = (nint)0 + (nint)16;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				selector = func;
			}
			IEnumerable<GillaSplashLayout.Hall> source = Enumerable.Select((IEnumerable<System.__Canon>)(object)pools, selector);
			return Enumerable.ToArray(source);
		}
	}

	public Transform HallGroup(int hall)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I
		Transform[] array = hallGroups;
		if (hallGroups != null)
		{
			bool flag = array.Length < hall;
			object obj = !flag;
			object obj2 = array.Length - hall;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				object obj5 = hallGroups + hall;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2+20]");
				return (Transform)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (Transform)(object)new IndexOutOfRangeException();
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01e7: Expected I, but got Obj
		//IL_0209: Expected Obj, but got I4
		//IL_021f: Expected I, but got Obj
		//IL_0241: Expected Obj, but got I4
		//IL_028e: Expected Obj, but got I
		//IL_029b: Expected I, but got Obj
		//IL_02b3: Expected I, but got Obj
		//IL_02cd: Expected Obj, but got I
		//IL_003b: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I8
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_0270: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_017d: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
		List<GillaSplashSpectate.Footprint> list = (List<GillaSplashSpectate.Footprint>)0;
		nint num = (nint)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2 (Il2CppClass<System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		nint num2 = (nint)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5 (Il2CppClass<System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>>)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj2 = !flag2;
		nint num3 = num2;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num3 = (nint)list;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v6 (Il2CppClass<System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>>)+A0]");
		object obj3 = 0;
		obj3 = this;
		nint num4 = (nint)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Prepare();
		nint num5 = (nint)list;
		float[] array = sunk;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v9 (Il2CppClass<System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>>)+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v10+8]");
		Shader.SetGlobalFloatArray(0, sunk);
		GillaSplashPool[] array2 = pools;
		if (array2.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78B8]");
		object obj6 = 0;
		object obj7 = array2.Length & 0xFFFFFFFFL;
		object obj8 = array2 + 32;
		object obj9 = 0;
		object obj10 = 0;
		List<GillaSplashSpectate.Footprint> list2 = default;
		while (true)
		{
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
			object obj11 = !flag3;
			if (obj11 != null)
			{
				break;
			}
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X26_v4+v108 @ X22_v5*8]");
			bool flag5 = (UnityEngine.Object)0 != null;
			bool flag6 = !flag5;
			obj10 = 0;
			array = null;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				list2._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X26_v4+v108 @ X22_v5*8]");
				((GillaSplashPool)0).Lay(list2);
				obj10 = 0;
				array = (float[])(object)list2;
			}
			obj7 = array2.Length;
			obj9++;
			if ((nint)obj9 >= array2.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Prepare()
	{
		//IL_0016: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I4
		//IL_06ba: Expected Obj, but got I
		//IL_06ca: Expected Obj, but got I
		//IL_06ec: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_00d4: Expected I4, but got Obj
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got I4
		//IL_070a: Expected Obj, but got I
		//IL_0724: Expected Obj, but got I
		//IL_0735: Expected I, but got Obj
		//IL_0753: Expected Obj, but got I
		//IL_076e: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_0205: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I4
		//IL_0326: Expected Obj, but got I4
		//IL_032f: Expected Obj, but got I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected I4, but got Unknown
		//IL_048f: Expected Obj, but got I4
		//IL_04b0: Expected Obj, but got I4
		//IL_0439: Expected Obj, but got I
		//IL_0473: Expected Obj, but got I
		//IL_0552: Expected Obj, but got I4
		//IL_05de: Expected Obj, but got I
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_0620: Expected Obj, but got I4
		//IL_0632: Expected Obj, but got I4
		//IL_064b: Expected Obj, but got I4
		if (spare != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7888]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v29+18]");
		Func<System.__Canon, System.__Canon> selector = (Func<System.__Canon, System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v29+18]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v33+A0]");
				obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78D0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78D8]");
			object obj9 = 0;
			Func<System.__Canon, System.__Canon> func = default;
			func._002Ector(obj4, (IntPtr)obj9);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v32+A0]");
			object obj11 = (nint)0 + (nint)24;
			obj11 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj12 = 0;
			selector = func;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78C0]");
		object obj13 = 0;
		bool flag4 = (byte)(int)obj13 != 0;
		IEnumerable<System.__Canon> source = Enumerable.Select((IEnumerable<System.__Canon>)(object)kinds, selector);
		System.__Canon[] array = (System.__Canon[])(object)(spare = (Stack<GameObject>[])(object)Enumerable.ToArray(source));
		object obj14 = this + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		GillaSplashPool[] array2 = pools;
		bool flag5 = pools == null;
		Transform transform = (Transform)(object)array;
		IndexOutOfRangeException ex = default;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Transform transform2 = default;
			hasPlatforms = (bool[])(object)transform2;
			object obj16 = this + 264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			GillaSplashPool[] array3 = pools;
			bool flag6 = pools == null;
			transform = transform2;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj18 = this + 248;
				object obj19 = default;
				obj18 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78E8]");
				object obj21 = 0;
				GameObject gameObject = default;
				gameObject._002Ector((string)obj21);
				bool flag7 = (object)gameObject == null;
				flag4 = false;
				transform = (Transform)obj21;
				if (!flag7)
				{
					Transform transform3 = gameObject.transform;
					Transform transform4 = base.transform;
					bool flag8 = (object)transform3 == null;
					flag4 = false;
					transform = null;
					if (!flag8)
					{
						transform3.SetParent(transform4, worldPositionStays: false);
						GillaSplashPool[] array4 = pools;
						bool flag9 = pools == null;
						flag4 = false;
						object obj12 = 0;
						transform = transform4;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78E0]");
							object obj22 = 0;
							int num = 0;
							object obj23 = 0;
							object obj24 = 0;
							object obj25 = 32;
							GameObject gameObject2 = default;
							while (true)
							{
								if ((nint)obj24 >= array4.Length)
								{
									return;
								}
								object obj26 = obj18;
								int num2 = obj24 + 1;
								string text = num.ToString();
								string text2 = (string)obj22 + text;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								gameObject2._002Ector(text2);
								bool flag10 = (object)gameObject2 == null;
								flag4 = false;
								obj12 = obj23;
								transform = (Transform)(object)text2;
								if (flag10)
								{
									break;
								}
								Transform transform5 = gameObject2.transform;
								bool flag11 = obj18 == null;
								flag4 = false;
								obj12 = obj23;
								transform = null;
								if (flag11)
								{
									break;
								}
								bool flag12 = (object)transform5 == null;
								Transform transform6 = null;
								if (!flag12)
								{
									object obj27 = obj26;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v28+40]");
									transform6 = (Transform)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag13 = ex == null;
									flag4 = false;
									obj12 = obj23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v28+40]");
									transform = (Transform)0;
									if (flag13)
									{
										goto IL_0675;
									}
								}
								object obj28 = num2 - 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X28_v5+18]");
								bool flag14 = (nint)obj28 < 0;
								object obj29 = !flag14;
								flag4 = false;
								obj12 = obj23;
								transform = transform6;
								if (obj29 == null)
								{
									object obj30 = obj18 + obj25;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj31 = obj18;
									bool flag15 = obj18 == null;
									flag4 = false;
									obj12 = obj23;
									transform = transform5;
									if (flag15)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v25+18]");
									bool flag16 = (nint)obj28 < 0;
									object obj32 = !flag16;
									flag4 = false;
									obj12 = obj23;
									transform = transform5;
									if (obj32 == null)
									{
										object obj33 = obj18 + obj24;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v26+20]");
										bool flag17 = (nint)0 == 0;
										flag4 = false;
										obj12 = obj23;
										transform = transform5;
										if (flag17)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v26+20]");
										((Transform)0).SetParent(transform3, worldPositionStays: false);
										array4 = pools;
										obj25 += 8;
										obj24 = obj28 + 1;
										bool flag18 = pools == null;
										object obj34 = !flag18;
										flag4 = false;
										obj12 = 0;
										transform = transform3;
										num = num2;
										obj23 = 0;
										if (obj34 == null)
										{
											break;
										}
										continue;
									}
								}
								goto IL_0667;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0667;
		IL_0675:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_0667:
		ex = new IndexOutOfRangeException();
		goto IL_0675;
	}

	public void Preview(int style, int round, int seed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00e1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass55_0 obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7908]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7910]");
		object obj5 = 0;
		obj2.style = style;
		obj2.round = round;
		Prepare();
		Style__BackingField = obj2.style;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		System.Random random = default;
		random._002Ector(seed);
		object obj6 = obj2 + 24;
		obj6 = random;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		GillaSplashLayout.Hall[] halls = Halls;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<GillaSplashLayout.Hall, System.__Canon> func = default;
		func._002Ector((object)obj2, (IntPtr)obj5);
		IEnumerable<GillaSplashLayout.Spot> source = Enumerable.SelectMany(halls, (Func<GillaSplashLayout.Hall, IEnumerable<GillaSplashLayout.Spot>>)func);
		List<GillaSplashLayout.Spot> spots = Enumerable.ToList(source);
		Put(spots);
	}

	private void FollowLayout()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I
		//IL_03e5: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I
		//IL_024b: Expected VT, but got I4
		//IL_043b: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got I
		//IL_0349: Expected Obj, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0314: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashGame current = GillaSplashGame.Current;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)current == (UnityEngine.Object)null;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		if (obj7 != null || !current.Live || current.Layouts == 0)
		{
			return;
		}
		int layouts = current.Layouts;
		if (layouts == built)
		{
			return;
		}
		int layoutCheck = current.LayoutCheck;
		int num = current.CheckNow();
		if (layoutCheck != num)
		{
			return;
		}
		int layouts2 = current.Layouts;
		built = layouts2;
		byte map = current.Map;
		int num2 = map & 0xFF;
		Style__BackingField = num2;
		int platformCount = current.PlatformCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79E8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<GillaSplashLayout.Spot> list = default;
		list._002Ector(platformCount);
		int platformCount2 = current.PlatformCount;
		if (platformCount2 >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79F0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79D8]");
			object obj11 = 0;
			NetworkArray<int> networkArray = (NetworkArray<int>)0;
			int num3 = 0;
			bool flag7;
			NetworkArray<int> networkArray2 = default;
			do
			{
				NetworkArray<int> platforms = current.Platforms;
				int v = networkArray.get_Item(num3);
				object obj12 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v18+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaSplashLayout.Spot item = GillaSplashLayout.Unpack(v);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v29 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+10]");
				object obj14 = 0;
				object obj15 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v29 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+1C]");
				object obj16 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v29 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X9_v7+18]");
				bool flag6 = num4 < 0;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v29 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
					object obj18 = obj14 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v29 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
					object obj19 = (nint)0 + (nint)1;
					_ = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X10_v5+20]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X9_v9+A8]");
					object obj21 = 0;
					list.AddWithResize(item);
				}
				num3++;
				int platformCount3 = current.PlatformCount;
				flag7 = num3 < platformCount3;
				networkArray = networkArray2;
			}
			while (flag7);
		}
		Put(list);
	}

	private unsafe void Put(List<GillaSplashLayout.Spot> spots)
	{
		//IL_0010: Expected Obj, but got I
		//IL_413d: Expected I, but got Obj
		//IL_415f: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I4
		//IL_418b: Expected Obj, but got I4
		//IL_419d: Expected Obj, but got I4
		//IL_41d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_41da: Expected I4, but got Unknown
		//IL_0404: Expected Obj, but got I4
		//IL_0417: Expected Obj, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected I4, but got Unknown
		//IL_0527: Expected Obj, but got I
		//IL_0537: Expected Obj, but got I
		//IL_056a: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I4
		//IL_04f3: Expected Obj, but got I4
		//IL_058e: Expected Obj, but got I
		//IL_05d6: Expected Obj, but got I4
		//IL_0184: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I4
		//IL_0616: Expected Obj, but got I4
		//IL_0629: Expected Obj, but got I4
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected I4, but got Unknown
		//IL_01af: Expected I, but got Obj
		//IL_01e5: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I4
		//IL_0731: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected I4, but got Unknown
		//IL_077f: Expected Obj, but got I4
		//IL_07a9: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I4
		//IL_02d5: Expected Obj, but got I4
		//IL_07db: Expected I, but got Obj
		//IL_07fd: Expected Obj, but got I4
		//IL_422a: Expected Obj, but got I
		//IL_427a: Expected Obj, but got I4
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_030f: Expected Obj, but got I
		//IL_0341: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I4
		//IL_4298: Expected Obj, but got I
		//IL_42a8: Expected Obj, but got I
		//IL_42ca: Expected Obj, but got I4
		//IL_42d3: Expected Obj, but got I4
		//IL_0825: Expected I, but got Obj
		//IL_08aa: Expected I, but got Obj
		//IL_08c8: Expected Obj, but got I4
		//IL_036c: Expected I, but got Obj
		//IL_0381: Expected Obj, but got I
		//IL_0399: Expected Obj, but got I4
		//IL_03b5: Expected Obj, but got I4
		//IL_03c5: Expected I4, but got Obj
		//IL_0868: Expected Obj, but got I4
		//IL_42f1: Expected Obj, but got I
		//IL_430b: Expected Obj, but got I
		//IL_431c: Expected I, but got Obj
		//IL_433f: Expected Obj, but got I
		//IL_435a: Expected Obj, but got I4
		//IL_091a: Expected Obj, but got I4
		//IL_089d: Expected Obj, but got I
		//IL_0a48: Expected Obj, but got I4
		//IL_0a55: Expected Obj, but got I4
		//IL_0a93: Expected Obj, but got I4
		//IL_0aa9: Expected Obj, but got I
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Expected I4, but got Unknown
		//IL_458f: Expected I, but got Obj
		//IL_4647: Expected Obj, but got I4
		//IL_4662: Expected Obj, but got I4
		//IL_466c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4671: Expected Obj, but got Unknown
		//IL_4699: Unknown result type (might be due to invalid IL or missing references)
		//IL_469e: Expected I4, but got Unknown
		//IL_46ab: Expected I4, but got Obj
		//IL_0cc1: Expected Obj, but got I4
		//IL_3f2f: Expected Obj, but got I
		//IL_3f41: Expected I4, but got I8
		//IL_3f6b: Expected Obj, but got I4
		//IL_0a06: Expected Obj, but got I4
		//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d30: Expected Obj, but got Unknown
		//IL_0d4a: Expected Obj, but got I4
		//IL_0d52: Expected Obj, but got I4
		//IL_367d: Expected Obj, but got I4
		//IL_3692: Expected Obj, but got I
		//IL_36cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d2: Expected I4, but got Unknown
		//IL_3fcc: Expected Obj, but got I
		//IL_400c: Expected Obj, but got Ref
		//IL_38e2: Expected Obj, but got I4
		//IL_38ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_38f1: Expected Obj, but got Unknown
		//IL_3919: Unknown result type (might be due to invalid IL or missing references)
		//IL_391e: Expected I4, but got Unknown
		//IL_392b: Expected I4, but got Obj
		//IL_394f: Expected I4, but got Obj
		//IL_0e14: Expected Obj, but got I4
		//IL_4055: Expected Obj, but got Ref
		//IL_397b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3980: Expected I4, but got Unknown
		//IL_398d: Expected Obj, but got I4
		//IL_0e69: Invalid comparison between VT and I4
		//IL_0e7a: Expected Obj, but got I4
		//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e89: Expected Obj, but got Unknown
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb6: Expected I4, but got Unknown
		//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected I4, but got Unknown
		//IL_0ee9: Invalid comparison between VT and I4
		//IL_0efa: Expected Obj, but got I4
		//IL_39fe: Expected Obj, but got I4
		//IL_3a78: Expected Obj, but got I4
		//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1d: Expected Obj, but got Unknown
		//IL_0f4f: Expected Obj, but got I4
		//IL_4097: Expected Obj, but got I
		//IL_40c0: Expected Obj, but got I
		//IL_40ea: Expected Obj, but got I4
		//IL_3bc0: Expected Obj, but got I4
		//IL_3bf8: Expected I4, but got Obj
		//IL_3c05: Expected I4, but got Obj
		//IL_3c29: Expected I4, but got Obj
		//IL_0f9e: Expected Obj, but got I4
		//IL_0fa8: Expected I, but got Obj
		//IL_3ae0: Expected Obj, but got I
		//IL_0fd8: Expected Obj, but got I
		//IL_0ff2: Expected Obj, but got I
		//IL_1003: Expected I, but got Obj
		//IL_3b26: Expected Obj, but got I4
		//IL_1018: Expected Obj, but got I
		//IL_1020: Expected I, but got Obj
		//IL_1045: Expected I4, but got I8
		//IL_105f: Expected Obj, but got I4
		//IL_1068: Expected Obj, but got I4
		//IL_3cab: Expected Obj, but got I
		//IL_3ccc: Expected I, but got Obj
		//IL_45be: Expected Obj, but got I4
		//IL_45c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_45cb: Expected Obj, but got Unknown
		//IL_45f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_45f6: Expected I4, but got Unknown
		//IL_4603: Expected I4, but got Obj
		//IL_4627: Expected I4, but got Obj
		//IL_3b68: Expected Obj, but got I
		//IL_3b8f: Expected Obj, but got I
		//IL_10a0: Expected Obj, but got I
		//IL_10a8: Expected I, but got Obj
		//IL_10ca: Expected Obj, but got I4
		//IL_437f: Expected Obj, but got I
		//IL_43e0: Expected Obj, but got I4
		//IL_10f2: Expected I, but got Obj
		//IL_110c: Invalid comparison between VT and I
		//IL_111d: Expected Obj, but got I4
		//IL_1132: Unknown result type (might be due to invalid IL or missing references)
		//IL_1137: Expected Obj, but got Unknown
		//IL_116a: Unknown result type (might be due to invalid IL or missing references)
		//IL_116f: Expected I4, but got Unknown
		//IL_117c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1181: Expected I4, but got Unknown
		//IL_11be: Expected Obj, but got I4
		//IL_11c6: Expected I4, but got Obj
		//IL_11de: Expected I4, but got Obj
		//IL_1231: Expected Obj, but got I4
		//IL_3d7c: Expected Obj, but got I4
		//IL_3d84: Expected I4, but got Obj
		//IL_128c: Expected Obj, but got I
		//IL_12a1: Invalid comparison between VT and I
		//IL_12b2: Expected Obj, but got I4
		//IL_12c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cc: Expected Obj, but got Unknown
		//IL_12ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1304: Expected I4, but got Unknown
		//IL_1311: Unknown result type (might be due to invalid IL or missing references)
		//IL_1316: Expected I4, but got Unknown
		//IL_1353: Expected Obj, but got I4
		//IL_135b: Expected I4, but got Obj
		//IL_3db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3db5: Expected Obj, but got Unknown
		//IL_3dd7: Expected Obj, but got I4
		//IL_3e5f: Expected Obj, but got I4
		//IL_3e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e6c: Expected I4, but got Unknown
		//IL_3e97: Expected Obj, but got I4
		//IL_3eb7: Expected Obj, but got I
		//IL_1376: Unknown result type (might be due to invalid IL or missing references)
		//IL_137b: Expected I4, but got Unknown
		//IL_138b: Expected Obj, but got I
		//IL_13dc: Expected Obj, but got I4
		//IL_1434: Unknown result type (might be due to invalid IL or missing references)
		//IL_1439: Expected Obj, but got Unknown
		//IL_1456: Expected Obj, but got I
		//IL_1475: Expected Obj, but got I4
		//IL_1591: Expected Obj, but got I4
		//IL_15ab: Expected Obj, but got I4
		//IL_150a: Expected Obj, but got I
		//IL_1523: Expected Obj, but got I
		//IL_1537: Expected Obj, but got I4
		//IL_160d: Invalid comparison between VT and I4
		//IL_161e: Expected Obj, but got I4
		//IL_162d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1632: Expected Obj, but got Unknown
		//IL_165f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1664: Expected I4, but got Unknown
		//IL_1671: Unknown result type (might be due to invalid IL or missing references)
		//IL_1676: Expected I4, but got Unknown
		//IL_16b3: Expected Obj, but got I4
		//IL_16bb: Expected I4, but got Obj
		//IL_193c: Expected Obj, but got I4
		//IL_16d3: Expected I4, but got Obj
		//IL_1716: Expected Obj, but got I4
		//IL_19e1: Expected Obj, but got I4
		//IL_1779: Expected Obj, but got I
		//IL_179a: Expected Obj, but got I4
		//IL_17af: Expected Obj, but got I
		//IL_17ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ef: Expected I4, but got Unknown
		//IL_182c: Expected Obj, but got I4
		//IL_1834: Expected I4, but got Obj
		//IL_1a3b: Expected Obj, but got I4
		//IL_1a56: Expected Obj, but got I4
		//IL_1a65: Expected Obj, but got I4
		//IL_1a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9f: Expected I4, but got Unknown
		//IL_1adc: Expected Obj, but got I4
		//IL_1859: Unknown result type (might be due to invalid IL or missing references)
		//IL_185e: Expected Obj, but got Unknown
		//IL_1868: Unknown result type (might be due to invalid IL or missing references)
		//IL_186d: Expected Obj, but got Unknown
		//IL_188d: Expected Obj, but got I
		//IL_18af: Expected Obj, but got I4
		//IL_1b34: Expected Obj, but got I4
		//IL_18dc: Expected Obj, but got I
		//IL_18e4: Expected I, but got Obj
		//IL_1b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9b: Expected Obj, but got Unknown
		//IL_1bb5: Expected Obj, but got I
		//IL_1bc5: Expected Obj, but got I
		//IL_1bd3: Expected VT, but got I4
		//IL_1bf5: Expected VT, but got I
		//IL_1c10: Expected VT, but got I4
		//IL_1c25: Expected Obj, but got I
		//IL_1c2d: Expected I, but got Obj
		//IL_1c60: Expected VT, but got I4
		//IL_1c7a: Expected Obj, but got I4
		//IL_1c83: Expected Obj, but got I4
		//IL_1cde: Expected Obj, but got I
		//IL_1d00: Expected Obj, but got I4
		//IL_1d16: Expected Obj, but got I
		//IL_1d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5f: Expected I4, but got Unknown
		//IL_276d: Expected Obj, but got I
		//IL_2787: Expected Obj, but got I
		//IL_27b1: Expected Obj, but got I4
		//IL_27ec: Expected Obj, but got I
		//IL_1db9: Expected Obj, but got I4
		//IL_1dc1: Expected I, but got Obj
		//IL_1dca: Expected Obj, but got I4
		//IL_2bbe: Expected VT, but got I4
		//IL_2bd8: Expected Obj, but got I4
		//IL_2be9: Expected Obj, but got I4
		//IL_2bee: Expected I, but got Obj
		//IL_4444: Expected Obj, but got I4
		//IL_447c: Expected I4, but got Obj
		//IL_4489: Expected I4, but got Obj
		//IL_44be: Expected Obj, but got I4
		//IL_44c6: Expected I4, but got Obj
		//IL_2832: Expected VT, but got I4
		//IL_284c: Expected Obj, but got I4
		//IL_285e: Expected I, but got Obj
		//IL_2c46: Expected Obj, but got I
		//IL_2c9c: Expected VT, but got I4
		//IL_2cb6: Expected Obj, but got I4
		//IL_2cc7: Expected Obj, but got I4
		//IL_2ccc: Expected I, but got Obj
		//IL_1dfc: Expected Obj, but got I
		//IL_1e2d: Expected VT, but got I4
		//IL_1e47: Expected Obj, but got I4
		//IL_2d1e: Expected Obj, but got I4
		//IL_2d3e: Expected Obj, but got I4
		//IL_2d52: Expected Obj, but got I4
		//IL_2d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d96: Expected I4, but got Unknown
		//IL_2915: Expected VT, but got I4
		//IL_292f: Expected Obj, but got I4
		//IL_2941: Expected I, but got Obj
		//IL_1e9b: Expected Obj, but got I
		//IL_1eaf: Expected Obj, but got I
		//IL_2e39: Expected Obj, but got I
		//IL_2e49: Expected Obj, but got I
		//IL_1ed5: Expected Obj, but got I
		//IL_2eaa: Expected VT, but got I4
		//IL_2ec4: Expected Obj, but got I4
		//IL_2dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dd7: Expected Obj, but got Unknown
		//IL_2e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e05: Expected Obj, but got Unknown
		//IL_2e24: Expected I, but got Obj
		//IL_29d9: Expected VT, but got I4
		//IL_29f3: Expected Obj, but got I4
		//IL_2a05: Expected I, but got Obj
		//IL_2114: Expected VT, but got I4
		//IL_212e: Expected Obj, but got I4
		//IL_2137: Expected Obj, but got I4
		//IL_213c: Expected I, but got Obj
		//IL_2169: Expected Obj, but got I4
		//IL_1f25: Expected VT, but got I4
		//IL_1f3f: Expected Obj, but got I4
		//IL_1f48: Expected Obj, but got I4
		//IL_1f4d: Expected I, but got Obj
		//IL_1f7a: Expected Obj, but got I4
		//IL_2f17: Expected Obj, but got I
		//IL_2f24: Expected I4, but got VT
		//IL_2f34: Expected Obj, but got I
		//IL_2f88: Expected VT, but got I4
		//IL_2fa2: Expected Obj, but got I4
		//IL_2fb7: Expected Obj, but got VT
		//IL_2a57: Expected Obj, but got I4
		//IL_2a77: Expected Obj, but got I4
		//IL_2a8b: Expected Obj, but got I4
		//IL_2aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_2acf: Expected I4, but got Unknown
		//IL_2192: Expected Obj, but got I4
		//IL_21a1: Expected Obj, but got I4
		//IL_21d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_21db: Expected I4, but got Unknown
		//IL_2210: Expected Obj, but got I4
		//IL_221e: Expected I, but got Obj
		//IL_3012: Expected Obj, but got I
		//IL_303b: Expected Obj, but got I4
		//IL_3058: Expected Obj, but got I
		//IL_30a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_30a8: Expected I4, but got Unknown
		//IL_2b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b10: Expected Obj, but got Unknown
		//IL_2b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3e: Expected Obj, but got Unknown
		//IL_2255: Expected VT, but got I4
		//IL_226f: Expected Obj, but got I4
		//IL_2278: Expected Obj, but got I4
		//IL_227d: Expected I, but got Obj
		//IL_22aa: Expected Obj, but got I4
		//IL_204d: Expected Obj, but got I4
		//IL_205a: Expected I, but got Obj
		//IL_3129: Expected Obj, but got I
		//IL_3139: Expected Obj, but got I
		//IL_315d: Expected I4, but got VT
		//IL_1fb8: Expected I, but got Obj
		//IL_1ffa: Expected Obj, but got I4
		//IL_200f: Expected I, but got Obj
		//IL_318b: Expected VT, but got I4
		//IL_31a5: Expected Obj, but got I4
		//IL_31b5: Expected Obj, but got I4
		//IL_30ef: Expected Obj, but got I
		//IL_3105: Expected Obj, but got I
		//IL_22c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c7: Expected Obj, but got Unknown
		//IL_2071: Unknown result type (might be due to invalid IL or missing references)
		//IL_2076: Expected Obj, but got Unknown
		//IL_20b0: Expected Obj, but got I4
		//IL_2392: Expected Obj, but got I4
		//IL_239f: Expected I, but got Obj
		//IL_2553: Expected I, but got Obj
		//IL_25a5: Expected Obj, but got I4
		//IL_25ba: Expected I, but got Obj
		//IL_320b: Expected Obj, but got I4
		//IL_321a: Expected Obj, but got I4
		//IL_3231: Unknown result type (might be due to invalid IL or missing references)
		//IL_3236: Expected I4, but got Unknown
		//IL_325c: Expected Obj, but got I4
		//IL_22fd: Expected I, but got Obj
		//IL_233f: Expected Obj, but got I4
		//IL_2354: Expected I, but got Obj
		//IL_20d0: Expected I4, but got Obj
		//IL_23b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bb: Expected Obj, but got Unknown
		//IL_23cb: Expected Obj, but got I
		//IL_240a: Expected VT, but got I4
		//IL_2424: Expected Obj, but got I4
		//IL_2434: Expected Obj, but got I
		//IL_2439: Expected I, but got Obj
		//IL_246e: Expected Obj, but got I
		//IL_25e2: Expected Obj, but got I8
		//IL_260a: Expected Obj, but got I4
		//IL_2617: Expected I, but got Obj
		//IL_3272: Unknown result type (might be due to invalid IL or missing references)
		//IL_3277: Expected Obj, but got Unknown
		//IL_3287: Expected Obj, but got I
		//IL_32d1: Expected Obj, but got I4
		//IL_32fb: Expected Obj, but got I4
		//IL_2486: Expected Obj, but got I4
		//IL_24a1: Expected Obj, but got I4
		//IL_24ba: Expected Obj, but got I4
		//IL_24cf: Expected I, but got Obj
		//IL_262e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2633: Expected Obj, but got Unknown
		//IL_4505: Expected VT, but got I4
		//IL_451f: Expected Obj, but got I4
		//IL_4531: Expected Obj, but got I4
		//IL_4539: Expected Obj, but got I4
		//IL_32e8: Expected Obj, but got I4
		//IL_2667: Expected Obj, but got I
		//IL_2670: Unknown result type (might be due to invalid IL or missing references)
		//IL_2675: Expected Obj, but got Unknown
		//IL_2696: Expected Obj, but got I4
		//IL_26a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ab: Expected Obj, but got Unknown
		//IL_26d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_26de: Expected I4, but got Unknown
		//IL_26eb: Expected I4, but got Obj
		//IL_2722: Expected I, but got Obj
		//IL_273f: Expected I, but got Obj
		//IL_24e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ec: Expected Obj, but got Unknown
		//IL_24fc: Expected Obj, but got I
		//IL_251d: Expected Obj, but got I4
		//IL_253d: Expected Obj, but got I
		//IL_3310: Expected VT, but got I
		//IL_3320: Expected Obj, but got I
		//IL_3330: Expected Obj, but got I
		//IL_3340: Expected Obj, but got I
		//IL_3356: Expected Obj, but got I
		//IL_3363: Expected I4, but got Obj
		//IL_339c: Expected VT, but got I4
		//IL_33a6: Expected Obj, but got I4
		//IL_33b8: Expected Obj, but got I4
		//IL_33c0: Expected Obj, but got I4
		//IL_33fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3401: Expected Obj, but got Unknown
		//IL_3411: Expected Obj, but got I
		//IL_3421: Expected Obj, but got I
		//IL_344a: Expected Obj, but got I4
		//IL_3581: Expected Obj, but got I
		//IL_3591: Expected Obj, but got I
		//IL_35a3: Expected I, but got Obj
		//IL_35b8: Expected VT, but got Ref
		//IL_35b8: Expected Obj, but got I
		//IL_35d0: Expected VT, but got I
		//IL_35e0: Expected VT, but got I
		//IL_35f0: Expected Obj, but got I
		//IL_3609: Expected Obj, but got I4
		//IL_3611: Expected Obj, but got Ref
		//IL_346e: Expected Obj, but got I
		//IL_347e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3483: Expected Obj, but got Unknown
		//IL_34b8: Expected Obj, but got I
		//IL_34e4: Expected Obj, but got I
		//IL_34fb: Expected VT, but got I4
		//IL_350b: Expected VT, but got I
		//IL_351b: Expected Obj, but got I
		//IL_352c: Expected Obj, but got I4
		//IL_3534: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
		IEnumerable<System.__Canon> enumerable = (IEnumerable<System.__Canon>)0;
		nint num = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v2 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.__Canon>>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Stopwatch stopwatch = Stopwatch.StartNew();
		bool flag2 = (object)standing == null;
		List<GillaSplashSpectate.Footprint> list = (List<GillaSplashSpectate.Footprint>)(object)spots;
		GillaSplashDirector gillaSplashDirector = this;
		List<GillaSplashLayout.Spot> list2 = spots;
		Stack<System.__Canon> stack = (Stack<System.__Canon>)109891584;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BD8]");
			int num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
			System.__Canon[] array = (System.__Canon[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7888]");
			int num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7920]");
			_003C_003Ec__DisplayClass57_0 obj4 = (_003C_003Ec__DisplayClass57_0)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7928]");
			int num4 = 0;
			List<GillaSplashLayout.Spot> list3 = spots;
			List<System.__Canon> list4 = (List<System.__Canon>)(object)standing;
			int num5 = 0;
			stack = (Stack<System.__Canon>)109891584;
			Func<System.__Canon, System.__Canon> func = default;
			_003C_003Ec__DisplayClass57_0 obj39 = default;
			Predicate<System.__Canon> predicate = default;
			System.__Canon _Canon3 = default;
			Vector3 euler = default;
			object obj62 = default;
			Transform transform4 = default;
			IEnumerable<System.__Canon> enumerable3 = default;
			object obj26 = default;
			object obj28 = default;
			Vector3 vector2 = default;
			object obj22 = default;
			object obj31 = default;
			object obj33 = default;
			object obj24 = default;
			GillaSplashDirector gillaSplashDirector2 = default;
			object arg = default;
			object arg2 = default;
			int num15 = default;
			object obj107 = default;
			IndexOutOfRangeException ex = default;
			while (true)
			{
				bool flag3 = num5 < list4._size;
				object obj5 = !flag3;
				object obj6 = num5 - list4._size;
				bool flag4 = (nint)obj6 < 0;
				bool flag5 = obj6 == null;
				int num6 = num5 ^ list4._size;
				int num7 = num5 ^ obj6;
				int num8 = num6 & num7;
				bool flag6 = num8 < 0;
				nint num9;
				if (num5 < list4._size)
				{
					num9 = ((int*)num2)->m_value;
					System.__Canon _Canon = list4.get_Item(num5);
					bool flag7 = _Canon == null;
					list = (List<GillaSplashSpectate.Footprint>)num5;
					gillaSplashDirector = this;
					list2 = spots;
					enumerable = (IEnumerable<System.__Canon>)num5;
					if (flag7)
					{
						break;
					}
					((GameObject)(object)_Canon).SetActive(false);
					bool flag8 = standingKinds == null;
					list = null;
					num9 = unchecked((nint)null);
					gillaSplashDirector = this;
					list2 = spots;
					enumerable = (IEnumerable<System.__Canon>)num5;
					if (flag8)
					{
						break;
					}
					num9 = (nint)obj2;
					stack = (Stack<System.__Canon>)(object)spare;
					int num10 = standingKinds.get_Item(num5);
					bool flag9 = spare == null;
					list = (List<GillaSplashSpectate.Footprint>)num5;
					gillaSplashDirector = this;
					list2 = spots;
					enumerable = (IEnumerable<System.__Canon>)num5;
					if (flag9)
					{
						break;
					}
					bool flag10 = num10 < stack._size;
					obj5 = !flag10;
					obj6 = num10 - stack._size;
					flag4 = (nint)obj6 < 0;
					flag5 = obj6 == null;
					num6 = num10 ^ stack._size;
					num7 = num10 ^ obj6;
					num8 = num6 & num7;
					flag6 = num8 < 0;
					int num11 = num5;
					if (obj5 == null)
					{
						bool flag11 = (object)standing == null;
						list = (List<GillaSplashSpectate.Footprint>)num5;
						gillaSplashDirector = this;
						list2 = spots;
						enumerable = (IEnumerable<System.__Canon>)num5;
						if (flag11)
						{
							break;
						}
						object obj7 = spare + num10;
						num9 = ((int*)num2)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X9_v64+20]");
						stack = (Stack<System.__Canon>)0;
						System.__Canon _Canon2 = ((List<System.__Canon>)(object)standing).get_Item(num5);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X9_v64+20]");
						bool flag12 = (nint)0 == 0;
						list = (List<GillaSplashSpectate.Footprint>)num5;
						gillaSplashDirector = this;
						list2 = spots;
						enumerable = (IEnumerable<System.__Canon>)num5;
						if (flag12)
						{
							break;
						}
						num9 = (nint)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X9_v64+20]");
						((Stack<System.__Canon>)0).Push(_Canon2);
						list4 = (List<System.__Canon>)(object)standing;
						enumerable = (IEnumerable<System.__Canon>)(num5 + 1);
						bool flag13 = (object)standing == null;
						object obj8 = !flag13;
						list3 = (List<GillaSplashLayout.Spot>)(object)_Canon2;
						num5 = (int)enumerable;
						if (obj8 == null)
						{
							list = (List<GillaSplashSpectate.Footprint>)(object)_Canon2;
							gillaSplashDirector = this;
							break;
						}
						continue;
					}
					goto IL_4111;
				}
				bool flag14 = list4._size < 1;
				obj5 = !flag14;
				obj6 = list4._size - 1;
				flag4 = (nint)obj6 < 0;
				flag5 = obj6 == null;
				num6 = list4._size ^ 1;
				num7 = list4._size ^ obj6;
				num8 = num6 & num7;
				flag6 = num8 < 0;
				int version = list4._version + 1;
				list4._size = 0;
				list4._version = version;
				bool flag15 = list4._size < 1;
				list = (List<GillaSplashSpectate.Footprint>)(object)list3;
				object obj9;
				if (!flag15)
				{
					Array.Clear(list4._items, 0, list4._size);
					obj9 = 0;
					list = null;
				}
				List<int> list5 = standingKinds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79C0]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7980]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj3 = 0;
				bool flag16 = standingKinds == null;
				num9 = list4._size;
				gillaSplashDirector = this;
				list2 = spots;
				enumerable = (IEnumerable<System.__Canon>)num5;
				if (flag16)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v23 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj10 = (nint)0 + (nint)1;
				_ = 0;
				List<GillaSinkPlatform> list6 = sinkers;
				bool flag17 = (object)sinkers == null;
				num9 = list4._size;
				gillaSplashDirector = this;
				list2 = spots;
				enumerable = (IEnumerable<System.__Canon>)num5;
				if (flag17)
				{
					break;
				}
				int version2 = list6._version + 1;
				bool flag18 = list6._size < 1;
				obj5 = !flag18;
				obj6 = list6._size - 1;
				flag4 = (nint)obj6 < 0;
				flag5 = obj6 == null;
				num6 = list6._size ^ 1;
				num7 = list6._size ^ obj6;
				num8 = num6 & num7;
				flag6 = num8 < 0;
				list6._size = 0;
				list6._version = version2;
				if (list6._size >= 1)
				{
					Array.Clear(list6._items, 0, list6._size);
					obj9 = 0;
					list = null;
				}
				Array array2 = sunk;
				bool flag19 = sunk == null;
				num9 = list6._size;
				gillaSplashDirector = this;
				list2 = spots;
				enumerable = (IEnumerable<System.__Canon>)num5;
				if (flag19)
				{
					break;
				}
				float[] array3 = sunk;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X0_v35 (System.Array)+18]");
				Array.Clear(array3, 0, 0);
				Array array4 = asked;
				bool flag20 = asked == null;
				obj9 = 0;
				list = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X0_v35 (System.Array)+18]");
				num9 = 0;
				gillaSplashDirector = this;
				list2 = spots;
				enumerable = (IEnumerable<System.__Canon>)num5;
				if (flag20)
				{
					break;
				}
				float[] array5 = asked;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X0_v36 (System.Array)+18]");
				Array.Clear(array5, 0, 0);
				nint num12 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X0_v37 (Il2CppClass<System.__Canon[]>)+E4]");
				bool flag21 = (nint)0 == 0;
				object obj11 = !flag21;
				nint num13 = num12;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num13 = (nint)array;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1100 @ X0_v38 (Il2CppClass<System.__Canon[]>)+A0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1102 @ X8_v26+8]");
				Shader.SetGlobalFloatArray(0, sunk);
				int value = ((int*)num3)->m_value;
				enumerable = (IEnumerable<System.__Canon>)(object)pools;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X0_v41 (System.Int32)+E4]");
				bool flag22 = (nint)0 == 0;
				object obj13 = !flag22;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					value = ((int*)num3)->m_value;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X0_v41 (System.Int32)+A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X8_v116+20]");
				Func<System.__Canon, System.__Canon> selector = (Func<System.__Canon, System.__Canon>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X8_v116+20]");
				bool flag23 = (nint)0 == 0;
				object obj15 = !flag23;
				obj9 = 0;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X0_v41 (System.Int32)+E4]");
					bool flag24 = (nint)0 == 0;
					object obj16 = !flag24;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						int value2 = ((int*)num3)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1239 @ X8_v120 (System.Int32)+A0]");
						obj14 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7930]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79B0]");
					object obj18 = 0;
					func._002Ector(obj14, (IntPtr)obj18);
					int value3 = ((int*)num3)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X8_v119 (System.Int32)+A0]");
					object obj19 = (nint)0 + (nint)32;
					obj19 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj9 = 0;
					selector = func;
					stack = (Stack<System.__Canon>)obj14;
				}
				num9 = (nint)obj4;
				IEnumerable<System.__Canon> source = Enumerable.Select(enumerable, selector);
				list = (List<GillaSplashSpectate.Footprint>)((int*)num4)->m_value;
				System.__Canon[] array6 = Enumerable.ToArray(source);
				GillaSplashPool[] array7 = pools;
				bool flag25 = pools == null;
				gillaSplashDirector = this;
				list2 = spots;
				if (flag25)
				{
					break;
				}
				GameObject[] array8 = (GameObject[])array7.Length;
				object obj21;
				List<GillaSplashSpectate.Footprint> list7;
				if (array7.Length != 0)
				{
					bool flag26 = array7.Length == 0;
					int num11 = ((int*)num4)->m_value;
					if (flag26)
					{
						goto IL_4111;
					}
					bool flag27 = (object)array7[0] == null;
					gillaSplashDirector = this;
					list2 = spots;
					if (flag27)
					{
						break;
					}
					Transform transform = array7[0].transform;
					bool flag28 = (object)transform == null;
					list = null;
					gillaSplashDirector = this;
					list2 = spots;
					if (flag28)
					{
						break;
					}
					Vector3 localPosition = transform.localPosition;
					bool flag29 = spots == null;
					object obj20 = !flag29;
					obj21 = obj22;
					list7 = null;
					if (obj20 == null)
					{
						list = null;
						gillaSplashDirector = this;
						break;
					}
				}
				else
				{
					bool flag30 = spots == null;
					obj21 = 0;
					list7 = (List<GillaSplashSpectate.Footprint>)((int*)num4)->m_value;
					gillaSplashDirector = this;
					list2 = spots;
					if (flag30)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [spots @ X1 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
				bool flag31 = (nint)0 < (nint)1;
				obj5 = !flag31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [spots @ X1 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
				obj6 = -1;
				flag4 = (nint)obj6 < 0;
				flag5 = obj6 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [spots @ X1 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
				num6 = (int)((nint)0 ^ (nint)1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [spots @ X1 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
				num7 = 0 ^ obj6;
				num8 = num6 & num7;
				flag6 = num8 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [spots @ X1 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
				flag15 = (nint)0 < (nint)1;
				list2 = spots;
				if (!flag15)
				{
					object obj23 = obj24;
					object obj25 = obj26;
					object obj27 = obj28;
					Vector3 vector = vector2;
					object obj29 = obj22;
					object obj30 = obj31;
					object obj32 = obj33;
					int num14 = num15;
					object obj34 = obj9;
					bool flag32 = flag15;
					bool flag33 = flag6;
					int num16 = num8;
					int num17 = num7;
					int num18 = num6;
					bool flag34 = flag5;
					bool flag35 = flag4;
					object obj35 = obj6;
					object obj36 = obj5;
					List<GillaSplashSpectate.Footprint> list8 = list7;
					IntPtr intPtr = num9;
					int num19 = 0;
					object obj37 = obj3;
					object obj38 = obj2;
					int num20 = num2;
					List<GillaSplashLayout.Spot> list9 = spots;
					IEnumerable<System.__Canon> enumerable2 = enumerable;
					Stack<System.__Canon> stack2 = stack;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						obj39._002Ector();
						num9 = (nint)obj38;
						GillaSplashLayout.Spot spot = list9.get_Item(num19);
						bool flag36 = obj39 == null;
						obj24 = obj23;
						obj26 = obj25;
						obj28 = obj27;
						vector2 = vector;
						obj22 = obj29;
						obj31 = obj30;
						obj33 = obj32;
						num15 = num14;
						obj9 = obj34;
						flag15 = flag32;
						flag6 = flag33;
						num8 = num16;
						num7 = num17;
						num6 = num18;
						flag5 = flag34;
						flag4 = flag35;
						obj6 = obj35;
						obj5 = obj36;
						list = (List<GillaSplashSpectate.Footprint>)num19;
						num4 = num19;
						obj3 = obj37;
						obj2 = obj38;
						num2 = num20;
						gillaSplashDirector = this;
						list2 = list9;
						enumerable = enumerable2;
						stack = stack2;
						if (flag36)
						{
							break;
						}
						obj39.spot = spot;
						object obj40 = spot & 0x80000000L;
						bool flag37 = obj40 == null;
						object obj41 = !flag37;
						list7 = (List<GillaSplashSpectate.Footprint>)num19;
						int num21;
						int num11;
						if (obj41 == null)
						{
							array8 = kinds;
							bool flag38 = kinds == null;
							obj24 = obj23;
							obj26 = obj25;
							obj28 = obj27;
							vector2 = vector;
							obj22 = obj29;
							obj31 = obj30;
							obj33 = obj32;
							num15 = num14;
							obj9 = obj34;
							flag15 = flag32;
							flag6 = flag33;
							num8 = num16;
							num7 = num17;
							num6 = num18;
							flag5 = flag34;
							flag4 = flag35;
							obj6 = obj35;
							obj5 = obj36;
							list = (List<GillaSplashSpectate.Footprint>)num19;
							num4 = num19;
							obj3 = obj37;
							obj2 = obj38;
							num2 = num20;
							gillaSplashDirector = this;
							list2 = list9;
							enumerable = enumerable2;
							stack = stack2;
							if (flag38)
							{
								break;
							}
							bool flag39 = spot < (object)array8.Length;
							obj5 = !flag39;
							obj6 = spot - array8.Length;
							flag4 = (nint)obj6 < 0;
							flag5 = obj6 == null;
							num6 = spot ^ array8.Length;
							num7 = spot ^ obj6;
							num8 = num6 & num7;
							flag6 = num8 < 0;
							flag15 = spot >= (object)array8.Length;
							list7 = (List<GillaSplashSpectate.Footprint>)num19;
							if (!flag15)
							{
								object obj42 = obj37;
								array8 = (GameObject[])(array8 + spot);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ X8_v46+E4]");
								num14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ X8_v46+E4]");
								bool flag40 = (nint)0 == 0;
								object obj43 = !flag40;
								if (obj43 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag41 = array8[0] == null;
								bool flag42 = !flag41;
								object obj44 = !flag42;
								list7 = null;
								num9 = unchecked((nint)null);
								stack2 = (Stack<System.__Canon>)(object)array8[0];
								if (obj44 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7990]");
									object obj45 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79B8]");
									object obj46 = 0;
									predicate._002Ector((object)obj39, (IntPtr)obj46);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7918]");
									object obj47 = 0;
									num9 = (nint)obj47;
									num21 = Array.FindIndex((System.__Canon[])(object)pools, predicate);
									int num22 = (int)(num21 & 0x80000000L);
									bool flag43 = num22 == 0;
									object obj48 = !flag43;
									obj34 = 0;
									list7 = (List<GillaSplashSpectate.Footprint>)(object)predicate;
									enumerable2 = (IEnumerable<System.__Canon>)(object)predicate;
									stack2 = (Stack<System.__Canon>)(object)pools;
									if (obj48 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
										stack = (Stack<System.__Canon>)0;
										nint num23 = (nint)stack;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1486 @ X0_v64 (Il2CppClass<System.Collections.Generic.Stack`1<System.__Canon>>)+E4]");
										bool flag44 = (nint)0 == 0;
										object obj49 = !flag44;
										nint num24 = num23;
										if (obj49 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											num24 = (nint)stack;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v65 (Il2CppClass<System.Collections.Generic.Stack`1<System.__Canon>>)+A0]");
										object obj50 = 0;
										object obj51 = obj50;
										bool flag45 = obj50 == null;
										obj24 = obj23;
										obj26 = obj25;
										obj28 = obj27;
										vector2 = vector;
										obj22 = obj29;
										obj31 = obj30;
										obj33 = obj32;
										num15 = num14;
										obj9 = 0;
										list = (List<GillaSplashSpectate.Footprint>)(object)predicate;
										num4 = num19;
										obj3 = obj37;
										obj2 = obj38;
										num2 = num20;
										gillaSplashDirector = this;
										list2 = list9;
										enumerable = (IEnumerable<System.__Canon>)(object)predicate;
										if (flag45)
										{
											break;
										}
										GillaSplashLayout.Spot spot2 = obj39.spot;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X9_v29+18]");
										bool flag46 = spot2 < (object)0;
										obj5 = !flag46;
										GillaSplashLayout.Spot spot3 = obj39.spot;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X9_v29+18]");
										obj6 = spot3 - 0;
										flag4 = (nint)obj6 < 0;
										flag5 = obj6 == null;
										GillaSplashLayout.Spot spot4 = obj39.spot;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X9_v29+18]");
										num6 = spot4 ^ 0;
										num7 = obj39.spot ^ obj6;
										num8 = num6 & num7;
										flag6 = num8 < 0;
										obj28 = obj27;
										vector2 = vector;
										obj22 = obj29;
										obj9 = 0;
										num11 = (int)predicate;
										if (obj5 == null)
										{
											num15 = (int)spare;
											bool flag47 = spare == null;
											obj24 = obj23;
											obj26 = obj25;
											obj28 = obj27;
											vector2 = vector;
											obj22 = obj29;
											obj31 = obj30;
											obj33 = obj32;
											obj9 = 0;
											list = (List<GillaSplashSpectate.Footprint>)(object)predicate;
											num4 = num19;
											obj3 = obj37;
											obj2 = obj38;
											num2 = num20;
											gillaSplashDirector = this;
											list2 = list9;
											enumerable = (IEnumerable<System.__Canon>)(object)predicate;
											if (flag47)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+18]");
											obj33 = 0;
											GillaSplashLayout.Spot spot5 = obj39.spot;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+18]");
											bool flag48 = spot5 < (object)0;
											obj5 = !flag48;
											GillaSplashLayout.Spot spot6 = obj39.spot;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+18]");
											obj6 = spot6 - 0;
											flag4 = (nint)obj6 < 0;
											flag5 = obj6 == null;
											GillaSplashLayout.Spot spot7 = obj39.spot;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+18]");
											num6 = spot7 ^ 0;
											num7 = obj39.spot ^ obj6;
											num8 = num6 & num7;
											flag6 = num8 < 0;
											obj28 = obj27;
											vector2 = vector;
											obj22 = obj29;
											obj9 = 0;
											num11 = (int)predicate;
											if (obj5 == null)
											{
												num15 += obj39.spot;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+20]");
												Stack<System.__Canon> stack3 = (Stack<System.__Canon>)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+20]");
												bool flag49 = (nint)0 == 0;
												obj24 = obj23;
												obj26 = obj25;
												obj28 = obj27;
												vector2 = vector;
												obj22 = obj29;
												obj31 = obj30;
												obj9 = 0;
												list = (List<GillaSplashSpectate.Footprint>)(object)predicate;
												num4 = num19;
												obj3 = obj37;
												obj2 = obj38;
												num2 = num20;
												gillaSplashDirector = this;
												list2 = list9;
												enumerable = (IEnumerable<System.__Canon>)(object)predicate;
												if (flag49)
												{
													break;
												}
												object obj52 = obj50 + obj39.spot;
												num15 = stack3._size;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X9_v30+30]");
												obj31 = 0;
												bool flag50 = stack3._size < 0;
												obj5 = !flag50;
												flag4 = stack3._size < 0;
												flag5 = stack3._size == 0;
												num7 = stack3._size ^ stack3._size;
												num8 = stack3._size & num7;
												flag6 = num8 < 0;
												if (stack3._size > 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7998]");
													object obj53 = 0;
													list = (List<GillaSplashSpectate.Footprint>)obj53;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+20]");
													_Canon3 = ((Stack<System.__Canon>)0).Pop();
													num6 = num15;
													obj6 = num15;
													enumerable = (IEnumerable<System.__Canon>)(object)predicate;
													goto IL_18fb;
												}
												GameObject[] array9 = kinds;
												bool flag51 = kinds == null;
												obj24 = obj23;
												obj26 = obj25;
												obj28 = obj27;
												vector2 = vector;
												obj22 = obj29;
												obj9 = 0;
												num6 = stack3._size;
												obj6 = stack3._size;
												list = (List<GillaSplashSpectate.Footprint>)(object)predicate;
												num4 = num19;
												obj3 = obj37;
												obj2 = obj38;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X9_v30+38]");
												num2 = 0;
												gillaSplashDirector = this;
												list2 = list9;
												enumerable = (IEnumerable<System.__Canon>)(object)predicate;
												if (flag51)
												{
													break;
												}
												bool flag52 = obj39.spot < (object)array9.Length;
												obj5 = !flag52;
												obj6 = obj39.spot - array9.Length;
												flag4 = (nint)obj6 < 0;
												flag5 = obj6 == null;
												num6 = obj39.spot ^ array9.Length;
												num7 = obj39.spot ^ obj6;
												num8 = num6 & num7;
												flag6 = num8 < 0;
												obj28 = obj27;
												vector2 = vector;
												obj22 = obj29;
												obj9 = 0;
												num11 = (int)predicate;
												if (obj5 == null)
												{
													num15 = (int)hallGroups;
													bool flag53 = hallGroups == null;
													obj24 = obj23;
													obj26 = obj25;
													obj28 = obj27;
													vector2 = vector;
													obj22 = obj29;
													obj9 = 0;
													list = (List<GillaSplashSpectate.Footprint>)(object)predicate;
													num4 = num19;
													obj3 = obj37;
													obj2 = obj38;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X9_v30+38]");
													num2 = 0;
													gillaSplashDirector = this;
													list2 = list9;
													enumerable = (IEnumerable<System.__Canon>)(object)predicate;
													if (flag53)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+18]");
													obj33 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+18]");
													bool flag54 = (nint)num21 < (nint)0;
													obj5 = !flag54;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+18]");
													obj6 = (nint)num21 - (nint)0;
													flag4 = (nint)obj6 < 0;
													flag5 = obj6 == null;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+18]");
													num6 = (int)((nint)num21 ^ (nint)0);
													num7 = num21 ^ obj6;
													num8 = num6 & num7;
													flag6 = num8 < 0;
													obj28 = obj27;
													vector2 = vector;
													obj22 = obj29;
													obj9 = 0;
													num11 = (int)predicate;
													if (obj5 == null)
													{
														object obj54 = obj37;
														object obj55 = kinds + obj39.spot;
														object obj56 = hallGroups + num21;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1516 @ X0_v126+E4]");
														num15 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1504 @ X9_v60+20]");
														enumerable = (IEnumerable<System.__Canon>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1516 @ X0_v126+E4]");
														bool flag55 = (nint)0 == 0;
														object obj57 = !flag55;
														if (obj57 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7988]");
														object obj58 = 0;
														num9 = (nint)obj58;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDB68");
														list = (List<GillaSplashSpectate.Footprint>)enumerable;
														goto IL_18fb;
													}
												}
											}
										}
										goto IL_4111;
									}
								}
							}
						}
						goto IL_364e;
						IL_18fb:
						bool flag56 = _Canon3 == null;
						obj24 = obj23;
						obj26 = obj25;
						obj28 = obj27;
						vector2 = vector;
						obj22 = obj29;
						obj9 = 0;
						num4 = num19;
						obj3 = obj37;
						obj2 = obj38;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X9_v30+38]");
						num2 = 0;
						gillaSplashDirector = this;
						list2 = list9;
						stack = (Stack<System.__Canon>)_Canon3;
						if (flag56)
						{
							break;
						}
						Transform transform2 = ((GameObject)(object)_Canon3).transform;
						Transform[] array10 = hallGroups;
						bool flag57 = hallGroups == null;
						obj24 = obj23;
						obj26 = obj25;
						obj28 = obj27;
						vector2 = vector;
						obj22 = obj29;
						obj9 = 0;
						list = null;
						num4 = num19;
						obj3 = obj37;
						obj2 = obj38;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X9_v30+38]");
						num2 = 0;
						gillaSplashDirector = this;
						list2 = list9;
						stack = (Stack<System.__Canon>)_Canon3;
						if (flag57)
						{
							break;
						}
						object obj59 = array10.Length;
						bool flag58 = num21 < array10.Length;
						obj5 = !flag58;
						obj6 = num21 - array10.Length;
						flag4 = (nint)obj6 < 0;
						flag5 = obj6 == null;
						num6 = num21 ^ array10.Length;
						num7 = num21 ^ obj6;
						num8 = num6 & num7;
						flag6 = num8 < 0;
						obj28 = obj27;
						vector2 = vector;
						obj22 = obj29;
						obj9 = 0;
						num11 = 0;
						Vector3 vector3;
						bool flag62;
						System.__Canon _Canon4;
						if (obj5 == null)
						{
							bool flag59 = (object)transform2 == null;
							obj24 = obj23;
							obj26 = obj25;
							obj28 = obj27;
							vector2 = vector;
							obj22 = obj29;
							obj9 = 0;
							list = null;
							num4 = num19;
							obj3 = obj37;
							obj2 = obj38;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X9_v30+38]");
							num2 = 0;
							gillaSplashDirector = this;
							list2 = list9;
							enumerable = (IEnumerable<System.__Canon>)transform2;
							stack = (Stack<System.__Canon>)_Canon3;
							if (flag59)
							{
								break;
							}
							object obj60 = hallGroups + num21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1525 @ X8_v58+20]");
							transform2.SetParent((Transform)0, worldPositionStays: false);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v53 (GillaSplashDirector+<>c__DisplayClass57_0)+18]");
							obj28 = 0;
							transform2.localPosition = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v53 (GillaSplashDirector+<>c__DisplayClass57_0)+1C]");
							nint num25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
							vector3 = (Vector3)(num25 * 0);
							Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
							transform2.localRotation = (Quaternion)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5058]");
							object obj61 = 0;
							num9 = (nint)obj61;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
							bool flag60 = obj62 == null;
							obj24 = obj23;
							obj26 = obj25;
							euler = (Vector3)0;
							vector2 = vector3;
							obj22 = obj21;
							obj9 = 0;
							list = (List<GillaSplashSpectate.Footprint>)1;
							num4 = num19;
							obj3 = obj37;
							obj2 = obj38;
							num2 = num21;
							gillaSplashDirector = this;
							list2 = list9;
							enumerable = (IEnumerable<System.__Canon>)transform2;
							stack = (Stack<System.__Canon>)_Canon3;
							if (flag60)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v76+18]");
							object obj63 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v76+18]");
							bool flag61 = (nint)0 < (nint)1;
							obj5 = !flag61;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v76+18]");
							obj6 = -1;
							flag4 = (nint)obj6 < 0;
							flag5 = obj6 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v76+18]");
							num6 = (int)((nint)0 ^ (nint)1);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v76+18]");
							num7 = 0 ^ obj6;
							num8 = num6 & num7;
							flag6 = num8 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v76+18]");
							flag62 = (nint)0 < (nint)1;
							_Canon4 = _Canon3;
							if (flag62)
							{
								goto IL_275d;
							}
							flag15 = flag62;
							list = (List<GillaSplashSpectate.Footprint>)1;
							nint num26 = (nint)obj61;
							obj2 = 0;
							Transform transform3 = transform2;
							System.__Canon _Canon5 = _Canon3;
							while (true)
							{
								bool flag63 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj63);
								obj5 = !flag63;
								obj6 = obj2 - obj63;
								flag4 = (nint)obj6 < 0;
								flag5 = obj6 == null;
								num6 = obj2 ^ obj63;
								num7 = obj2 ^ obj6;
								num8 = num6 & num7;
								flag6 = num8 < 0;
								vector2 = vector3;
								obj22 = obj21;
								obj9 = 0;
								num11 = (int)list;
								num9 = num26;
								if (obj5 != null)
								{
									break;
								}
								object obj64 = obj62 + obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v90+20]");
								list2 = (List<GillaSplashLayout.Spot>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v90+20]");
								bool flag64 = (nint)0 == 0;
								obj24 = obj23;
								obj26 = obj25;
								euler = (Vector3)0;
								vector2 = vector3;
								obj22 = obj21;
								obj9 = 0;
								num9 = num26;
								num4 = num19;
								obj3 = obj62;
								num2 = num21;
								gillaSplashDirector = this;
								enumerable = (IEnumerable<System.__Canon>)transform3;
								stack = (Stack<System.__Canon>)_Canon5;
								if (flag64)
								{
									goto end_IL_4574;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v90+20]");
								string text = ((UnityEngine.Object)0).name;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79C8]");
								object obj65 = 0;
								bool flag65 = text == (string)obj65;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
								object obj66 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								System.__Canon _Canon6;
								object obj69;
								int num29;
								if (flag65)
								{
									bool flag66 = (object)transform4 == null;
									obj24 = obj23;
									obj26 = obj25;
									euler = (Vector3)0;
									vector2 = vector3;
									obj22 = obj21;
									obj9 = 0;
									list = (List<GillaSplashSpectate.Footprint>)2;
									num9 = unchecked((nint)null);
									num4 = num19;
									obj3 = obj62;
									num2 = num21;
									gillaSplashDirector = this;
									enumerable = (IEnumerable<System.__Canon>)transform4;
									stack = (Stack<System.__Canon>)flag65;
									if (flag66)
									{
										goto end_IL_4574;
									}
									bool flag67 = (object)outline == null;
									int num27 = 2;
									if (!flag67)
									{
										nint num28 = (nint)transform4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ X8_v110 (Il2CppClass<UnityEngine.Transform>)+40]");
										num27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag68 = ex == null;
										vector2 = vector3;
										obj22 = obj21;
										obj9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ X8_v110 (Il2CppClass<UnityEngine.Transform>)+40]");
										num11 = 0;
										num9 = unchecked((nint)null);
										if (flag68)
										{
											goto IL_411f;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v105 (UnityEngine.Transform)+18]");
									bool flag69 = (nint)0 == 0;
									vector2 = vector3;
									obj22 = obj21;
									obj9 = 0;
									num11 = num27;
									num9 = unchecked((nint)null);
									if (flag69)
									{
										break;
									}
									object obj67 = transform4 + 32;
									obj67 = outline;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									_Canon6 = (System.__Canon)(object)outline;
									bool flag70 = (object)outline == null;
									object obj68 = !flag70;
									if (obj68 != null)
									{
										goto IL_254b;
									}
									obj69 = obj59;
									num29 = (int)outline;
									_Canon4 = (System.__Canon)(object)outline;
								}
								else
								{
									Material[] array11 = decks;
									bool flag71 = decks == null;
									obj24 = obj23;
									obj26 = obj25;
									euler = (Vector3)0;
									vector2 = vector3;
									obj22 = obj21;
									obj9 = 0;
									list = (List<GillaSplashSpectate.Footprint>)2;
									num9 = unchecked((nint)null);
									num4 = num19;
									obj3 = obj62;
									num2 = num21;
									gillaSplashDirector = this;
									enumerable = (IEnumerable<System.__Canon>)transform4;
									stack = (Stack<System.__Canon>)flag65;
									if (flag71)
									{
										goto end_IL_4574;
									}
									bool flag72 = num21 < array11.Length;
									obj5 = !flag72;
									obj6 = num21 - array11.Length;
									flag4 = (nint)obj6 < 0;
									flag5 = obj6 == null;
									num6 = num21 ^ array11.Length;
									num7 = num21 ^ obj6;
									num8 = num6 & num7;
									flag6 = num8 < 0;
									vector2 = vector3;
									obj22 = obj21;
									obj9 = 0;
									num11 = 2;
									num9 = unchecked((nint)null);
									if (obj5 != null)
									{
										break;
									}
									bool flag73 = (object)transform4 == null;
									obj24 = obj23;
									obj26 = obj25;
									euler = (Vector3)0;
									vector2 = vector3;
									obj22 = obj21;
									obj9 = 0;
									list = (List<GillaSplashSpectate.Footprint>)2;
									num9 = unchecked((nint)null);
									num4 = num19;
									obj3 = obj62;
									num2 = num21;
									gillaSplashDirector = this;
									enumerable = (IEnumerable<System.__Canon>)transform4;
									stack = (Stack<System.__Canon>)flag65;
									if (flag73)
									{
										goto end_IL_4574;
									}
									object obj70 = decks + num21;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v102+20]");
									bool flag74 = (nint)0 == 0;
									int num30 = 2;
									if (!flag74)
									{
										nint num31 = (nint)transform4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X8_v107 (Il2CppClass<UnityEngine.Transform>)+40]");
										num30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag75 = ex == null;
										vector2 = vector3;
										obj22 = obj21;
										obj9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X8_v107 (Il2CppClass<UnityEngine.Transform>)+40]");
										num11 = 0;
										num9 = unchecked((nint)null);
										if (flag75)
										{
											goto IL_411f;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v105 (UnityEngine.Transform)+18]");
									bool flag76 = (nint)0 == 0;
									vector2 = vector3;
									obj22 = obj21;
									obj9 = 0;
									num11 = num30;
									num9 = unchecked((nint)null);
									if (flag76)
									{
										break;
									}
									object obj71 = transform4 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v102+20]");
									obj71 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Material[] array12 = sides;
									bool flag77 = sides == null;
									obj24 = obj23;
									obj26 = obj25;
									euler = (Vector3)0;
									vector2 = vector3;
									obj22 = obj21;
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v102+20]");
									list = (List<GillaSplashSpectate.Footprint>)0;
									num9 = unchecked((nint)null);
									num4 = num19;
									obj3 = obj62;
									num2 = num21;
									gillaSplashDirector = this;
									enumerable = (IEnumerable<System.__Canon>)transform4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v102+20]");
									stack = (Stack<System.__Canon>)0;
									if (flag77)
									{
										goto end_IL_4574;
									}
									obj59 = array12.Length;
									bool flag78 = num21 < array12.Length;
									object obj72 = !flag78;
									vector2 = vector3;
									obj22 = obj21;
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v102+20]");
									num11 = 0;
									num9 = unchecked((nint)null);
									if (obj72 != null)
									{
										break;
									}
									object obj73 = sides + num21;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1686 @ X8_v106+20]");
									_Canon6 = (System.__Canon)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1686 @ X8_v106+20]");
									bool flag79 = (nint)0 == 0;
									obj69 = array12.Length;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v102+20]");
									num29 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1686 @ X8_v106+20]");
									_Canon4 = (System.__Canon)0;
									if (!flag79)
									{
										goto IL_254b;
									}
								}
								goto IL_25c8;
								IL_254b:
								nint num32 = (nint)transform4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X8_v100 (Il2CppClass<UnityEngine.Transform>)+40]");
								num29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag80 = ex == null;
								obj69 = obj59;
								_Canon4 = _Canon6;
								vector2 = vector3;
								obj22 = obj21;
								obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X8_v100 (Il2CppClass<UnityEngine.Transform>)+40]");
								num11 = 0;
								num9 = unchecked((nint)null);
								if (!flag80)
								{
									goto IL_25c8;
								}
								goto IL_411f;
								IL_25c8:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v105 (UnityEngine.Transform)+18]");
								object obj74 = 0 & 0xFFFFFFFEL;
								bool flag81 = obj74 == null;
								vector2 = vector3;
								obj22 = obj21;
								obj9 = 0;
								num11 = num29;
								num9 = unchecked((nint)null);
								if (flag81)
								{
									break;
								}
								object obj75 = transform4 + 40;
								obj75 = _Canon4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								((Renderer)(object)list2).sharedMaterials = (Material[])(object)transform4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v76+18]");
								obj63 = 0;
								obj2++;
								object obj76 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v76+18]");
								bool flag82 = (nint)obj76 < 0;
								obj5 = !flag82;
								object obj77 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v76+18]");
								obj6 = obj77 - 0;
								flag4 = (nint)obj6 < 0;
								flag5 = obj6 == null;
								object obj78 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v76+18]");
								num6 = obj78 ^ 0;
								num7 = obj2 ^ obj6;
								num8 = num6 & num7;
								flag6 = num8 < 0;
								object obj79 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v76+18]");
								flag62 = (nint)obj79 < 0;
								num9 = unchecked((nint)null);
								flag15 = flag62;
								obj59 = obj69;
								list = (List<GillaSplashSpectate.Footprint>)(object)transform4;
								num26 = unchecked((nint)null);
								transform3 = transform4;
								_Canon5 = _Canon4;
								if (flag62)
								{
									continue;
								}
								goto IL_275d;
							}
						}
						goto IL_4111;
						IL_275d:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7938]");
						object obj80 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						obj3 = 0;
						object obj81 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v65+E4]");
						bool flag83 = (nint)0 == 0;
						object obj82 = !flag83;
						if (obj82 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag84 = (UnityEngine.Object)enumerable3 != null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7980]");
						obj2 = 0;
						if (flag84)
						{
							bool flag85 = enumerable3 == null;
							obj24 = obj23;
							obj26 = obj25;
							euler = (Vector3)0;
							vector2 = vector3;
							obj22 = obj21;
							obj9 = 0;
							flag15 = flag62;
							list = null;
							num9 = unchecked((nint)null);
							num4 = num19;
							num2 = num21;
							gillaSplashDirector = this;
							list2 = spots;
							enumerable = enumerable3;
							stack = (Stack<System.__Canon>)_Canon4;
							if (flag85)
							{
								break;
							}
							Vector3 localPosition2 = transform2.localPosition;
							Quaternion localRotation = transform2.localRotation;
							List<System.__Canon> list10 = (List<System.__Canon>)(object)sinkers;
							bool flag86 = (object)sinkers == null;
							obj24 = obj23;
							obj26 = obj25;
							euler = (Vector3)0;
							vector2 = vector3;
							obj22 = obj21;
							obj9 = 0;
							flag15 = flag62;
							list = null;
							num9 = unchecked((nint)null);
							num4 = num19;
							num2 = num21;
							gillaSplashDirector = this;
							list2 = spots;
							enumerable = enumerable3;
							stack = (Stack<System.__Canon>)(object)transform2;
							if (flag86)
							{
								break;
							}
							System.__Canon[] items = list10._items;
							num15 = list10._version + 1;
							list10._version = num15;
							bool flag87 = list10._items == null;
							obj24 = obj23;
							obj26 = obj25;
							euler = (Vector3)0;
							vector2 = vector3;
							obj22 = obj21;
							obj9 = 0;
							flag15 = flag62;
							list = null;
							num9 = unchecked((nint)null);
							num4 = num19;
							num2 = num21;
							gillaSplashDirector = this;
							list2 = spots;
							enumerable = enumerable3;
							stack = (Stack<System.__Canon>)(object)transform2;
							if (flag87)
							{
								break;
							}
							num15 = list10._size;
							obj33 = items.Length;
							bool flag88 = list10._size < items.Length;
							obj5 = !flag88;
							obj6 = list10._size - items.Length;
							flag4 = (nint)obj6 < 0;
							flag5 = obj6 == null;
							num6 = list10._size ^ items.Length;
							num7 = list10._size ^ obj6;
							num8 = num6 & num7;
							flag6 = num8 < 0;
							if (obj5 == null)
							{
								object obj83 = list10._items + list10._size;
								int size = list10._size + 1;
								list10._size = size;
								object obj84 = obj83 + 32;
								obj84 = enumerable3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								_Canon4 = (System.__Canon)(object)transform2;
							}
							else
							{
								((List<System.__Canon>)(object)sinkers).AddWithResize((System.__Canon)enumerable3);
								_Canon4 = (System.__Canon)(object)transform2;
							}
						}
						((GameObject)(object)_Canon3).SetActive(true);
						List<System.__Canon> list11 = (List<System.__Canon>)(object)standing;
						bool flag89 = (object)standing == null;
						obj24 = obj23;
						obj26 = obj25;
						euler = (Vector3)0;
						vector2 = vector3;
						obj22 = obj21;
						obj9 = 0;
						flag15 = flag62;
						list = (List<GillaSplashSpectate.Footprint>)1;
						num9 = unchecked((nint)null);
						num4 = num19;
						num2 = num21;
						gillaSplashDirector = this;
						list2 = spots;
						enumerable = enumerable3;
						stack = (Stack<System.__Canon>)_Canon4;
						if (flag89)
						{
							break;
						}
						System.__Canon[] items2 = list11._items;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4940]");
						object obj85 = 0;
						num15 = list11._version + 1;
						object obj86 = obj85;
						list11._version = num15;
						bool flag90 = list11._items == null;
						obj24 = obj23;
						obj26 = obj25;
						euler = (Vector3)0;
						vector2 = vector3;
						obj22 = obj21;
						obj9 = 0;
						flag15 = flag62;
						list = (List<GillaSplashSpectate.Footprint>)1;
						num9 = unchecked((nint)null);
						num4 = num19;
						num2 = num21;
						gillaSplashDirector = this;
						list2 = spots;
						enumerable = enumerable3;
						stack = (Stack<System.__Canon>)_Canon4;
						if (flag90)
						{
							break;
						}
						num15 = list11._size;
						obj33 = items2.Length;
						bool flag91 = list11._size < items2.Length;
						obj5 = !flag91;
						obj6 = list11._size - items2.Length;
						flag4 = (nint)obj6 < 0;
						flag5 = obj6 == null;
						num6 = list11._size ^ items2.Length;
						num7 = list11._size ^ obj6;
						num8 = num6 & num7;
						flag6 = num8 < 0;
						if (obj5 == null)
						{
							object obj87 = list11._items + list11._size;
							int size2 = list11._size + 1;
							list11._size = size2;
							object obj88 = obj87 + 32;
							obj88 = _Canon3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							list = (List<GillaSplashSpectate.Footprint>)(object)_Canon3;
							num9 = unchecked((nint)null);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X9_v38+20]");
							object obj89 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1653 @ X8_v80+A8]");
							object obj90 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1655 @ X8_v81+70]");
							num9 = 0;
							((List<System.__Canon>)(object)standing).AddWithResize(_Canon3);
							list = (List<GillaSplashSpectate.Footprint>)(object)_Canon3;
						}
						List<int> list12 = standingKinds;
						bool flag92 = standingKinds == null;
						obj24 = obj23;
						obj26 = obj25;
						euler = (Vector3)0;
						vector2 = vector3;
						obj22 = obj21;
						obj9 = 0;
						flag15 = flag62;
						num4 = num19;
						num2 = num21;
						gillaSplashDirector = this;
						list2 = spots;
						enumerable = enumerable3;
						stack = (Stack<System.__Canon>)_Canon4;
						if (flag92)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v87 (System.Collections.Generic.List`1<System.Int32>)+10]");
						object obj91 = 0;
						num11 = (int)obj39.spot;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
						object obj92 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v87 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						num15 = (int)((nint)0 + (nint)1);
						object obj93 = obj92;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v87 (System.Collections.Generic.List`1<System.Int32>)+10]");
						bool flag93 = (nint)0 == 0;
						obj24 = obj23;
						obj26 = obj25;
						euler = (Vector3)0;
						vector2 = vector3;
						obj22 = obj21;
						obj9 = 0;
						flag15 = flag62;
						list = (List<GillaSplashSpectate.Footprint>)obj39.spot;
						num4 = num19;
						num2 = num21;
						gillaSplashDirector = this;
						list2 = spots;
						enumerable = enumerable3;
						stack = (Stack<System.__Canon>)_Canon4;
						if (flag93)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v87 (System.Collections.Generic.List`1<System.Int32>)+18]");
						num15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v69+18]");
						obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v87 (System.Collections.Generic.List`1<System.Int32>)+18]");
						nint num33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v69+18]");
						bool flag94 = num33 < 0;
						obj5 = !flag94;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v87 (System.Collections.Generic.List`1<System.Int32>)+18]");
						nint num34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v69+18]");
						obj6 = num34 - 0;
						flag4 = (nint)obj6 < 0;
						flag5 = obj6 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v87 (System.Collections.Generic.List`1<System.Int32>)+18]");
						nint num35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v69+18]");
						num6 = (int)(num35 ^ 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v87 (System.Collections.Generic.List`1<System.Int32>)+18]");
						num7 = 0 ^ obj6;
						num8 = num6 & num7;
						flag6 = num8 < 0;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v87 (System.Collections.Generic.List`1<System.Int32>)+10]");
							nint num36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v87 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj94 = num36 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v87 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj95 = (nint)0 + (nint)1;
							_ = obj39.spot;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X9_v42+20]");
							object obj96 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1693 @ X8_v77+A8]");
							object obj97 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1694 @ X8_v78+70]");
							num9 = 0;
							standingKinds.AddWithResize((int)obj39.spot);
						}
						bool flag95 = array6 == null;
						obj24 = obj23;
						obj26 = obj25;
						euler = (Vector3)0;
						vector2 = vector3;
						obj22 = obj21;
						obj9 = 0;
						flag15 = flag62;
						list = (List<GillaSplashSpectate.Footprint>)num11;
						num4 = num19;
						num2 = num21;
						gillaSplashDirector = this;
						list2 = spots;
						enumerable = enumerable3;
						stack = (Stack<System.__Canon>)_Canon4;
						if (flag95)
						{
							break;
						}
						bool flag96 = num21 < array6.Length;
						object obj98 = !flag96;
						obj6 = num21 - array6.Length;
						num6 = num21 ^ array6.Length;
						num7 = num21 ^ obj6;
						num8 = num6 & num7;
						vector2 = vector3;
						obj22 = obj21;
						obj9 = 0;
						if (obj98 == null)
						{
							object obj99 = array6 + num21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1708 @ X8_v72+20]");
							List<GillaSplashSpectate.Footprint> list13 = (List<GillaSplashSpectate.Footprint>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X9_v30+38]");
							int num37 = (int)((nint)0 & (nint)1);
							flag4 = num37 < 0;
							flag5 = num37 == 0;
							flag15 = !flag5;
							obj26 = !flag15;
							if (obj26 == null)
							{
								object obj100 = 0;
							}
							else
							{
								object obj100 = num19 + 1;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1708 @ X8_v72+20]");
							bool flag97 = (nint)0 == 0;
							obj24 = obj23;
							euler = (Vector3)0;
							vector2 = vector3;
							obj22 = obj21;
							obj9 = 0;
							flag6 = false;
							obj5 = 0;
							list = (List<GillaSplashSpectate.Footprint>)num11;
							num4 = num19;
							num2 = num21;
							gillaSplashDirector = this;
							list2 = spots;
							enumerable = enumerable3;
							stack = (Stack<System.__Canon>)_Canon4;
							if (flag97)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v53 (GillaSplashDirector+<>c__DisplayClass57_0)+14]");
							vector2 = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v88 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+10]");
							object obj101 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v53 (GillaSplashDirector+<>c__DisplayClass57_0)+1C]");
							obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7950]");
							object obj102 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v88 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+1C]");
							obj33 = (nint)0 + (nint)1;
							num15 = (int)obj102;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79C0]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v88 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+10]");
							bool flag98 = (nint)0 == 0;
							obj24 = obj23;
							euler = (Vector3)0;
							obj9 = 0;
							flag6 = false;
							obj5 = 0;
							list = (List<GillaSplashSpectate.Footprint>)num11;
							num4 = num19;
							gillaSplashDirector = this;
							list2 = spots;
							enumerable = enumerable3;
							stack = (Stack<System.__Canon>)_Canon4;
							if (flag98)
							{
								break;
							}
							obj27 = obj31 * 63;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v88 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
							obj32 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v44+18]");
							obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v88 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
							nint num38 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v44+18]");
							bool flag99 = num38 < 0;
							object obj103 = !flag99;
							if (obj103 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v88 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
								object obj104 = (nint)0 * (nint)24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v88 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+10]");
								array8 = (GameObject[])(0 + obj104);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v88 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
								num14 = (int)((nint)0 + (nint)1);
								GameObject[] array13 = array8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v53 (GillaSplashDirector+<>c__DisplayClass57_0)+14]");
								array13[0] = (GameObject)0;
								array8[1] = (GameObject)obj27;
								GameObject[] array14 = array8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v53 (GillaSplashDirector+<>c__DisplayClass57_0)+1C]");
								array14[2] = (GameObject)0;
								obj25 = obj26;
								euler = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v53 (GillaSplashDirector+<>c__DisplayClass57_0)+14]");
								vector = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v53 (GillaSplashDirector+<>c__DisplayClass57_0)+1C]");
								obj29 = 0;
								obj30 = obj31;
								obj34 = 0;
								list7 = (List<GillaSplashSpectate.Footprint>)num11;
								obj37 = obj3;
								obj38 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79C0]");
								num20 = 0;
								list9 = spots;
								enumerable2 = enumerable3;
								stack2 = (Stack<System.__Canon>)_Canon4;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v19 (System.Int32)+20]");
								object obj105 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1721 @ X9_v45+A8]");
								array8 = (GameObject[])0;
								num9 = (nint)array8[10];
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1708 @ X8_v72+20]");
								((List<GillaSplashSpectate.Footprint>)0).AddWithResize((GillaSplashSpectate.Footprint)(&euler));
								obj25 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v53 (GillaSplashDirector+<>c__DisplayClass57_0)+14]");
								euler = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v53 (GillaSplashDirector+<>c__DisplayClass57_0)+14]");
								vector = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X0_v53 (GillaSplashDirector+<>c__DisplayClass57_0)+1C]");
								obj29 = 0;
								obj30 = obj31;
								num14 = num15;
								obj34 = 0;
								list7 = (List<GillaSplashSpectate.Footprint>)(&euler);
								obj37 = obj3;
								obj38 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79C0]");
								num20 = 0;
								list9 = spots;
								enumerable2 = enumerable3;
								stack2 = (Stack<System.__Canon>)_Canon4;
							}
							goto IL_364e;
						}
						goto IL_4111;
						IL_364e:
						num4 = num19 + 1;
						int num39 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1314 @ X29_v9 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
						bool flag100 = (nint)num39 < (nint)0;
						obj5 = !flag100;
						int num40 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1314 @ X29_v9 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
						obj6 = (nint)num40 - (nint)0;
						flag4 = (nint)obj6 < 0;
						flag5 = obj6 == null;
						int num41 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1314 @ X29_v9 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
						num6 = (int)((nint)num41 ^ (nint)0);
						num7 = num4 ^ obj6;
						num8 = num6 & num7;
						flag6 = num8 < 0;
						int num42 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1314 @ X29_v9 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
						flag15 = (nint)num42 < (nint)0;
						obj24 = obj23;
						obj26 = obj25;
						obj28 = obj27;
						vector2 = vector;
						obj22 = obj29;
						obj31 = obj30;
						obj33 = obj32;
						num15 = num14;
						obj9 = obj34;
						obj3 = obj37;
						obj2 = obj38;
						num2 = num20;
						list2 = list9;
						enumerable = enumerable2;
						stack = stack2;
						flag32 = flag15;
						flag33 = flag6;
						num16 = num8;
						num17 = num7;
						num18 = num6;
						flag34 = flag5;
						flag35 = flag4;
						obj35 = obj6;
						obj36 = obj5;
						list8 = list7;
						intPtr = num9;
						num19 = num4;
						if (flag15)
						{
							continue;
						}
						goto IL_37eb;
						continue;
						end_IL_4574:
						break;
					}
					break;
				}
				goto IL_37eb;
				IL_37eb:
				GillaSplashPool[] array15 = pools;
				bool flag101 = pools == null;
				list = list7;
				gillaSplashDirector = this;
				if (flag101)
				{
					break;
				}
				object obj106 = obj107;
				object obj108 = obj24;
				int num43 = num15;
				nint num44 = num9;
				int num45 = num4;
				IEnumerable<System.__Canon> enumerable4 = enumerable;
				IEnumerable<System.__Canon> enumerable5 = null;
				while (true)
				{
					obj33 = array15.Length;
					bool flag102 = (nint)enumerable5 < array15.Length;
					obj5 = !flag102;
					obj6 = enumerable5 - array15.Length;
					flag4 = (nint)obj6 < 0;
					flag5 = obj6 == null;
					num6 = enumerable5 ^ array15.Length;
					num7 = (object)enumerable5 ^ obj6;
					num8 = num6 & num7;
					flag6 = num8 < 0;
					flag15 = (nint)enumerable5 >= array15.Length;
					obj107 = obj106;
					obj24 = obj108;
					num15 = num43;
					list = list7;
					num9 = num44;
					num4 = num45;
					gillaSplashDirector = this;
					enumerable = enumerable4;
					stack = (Stack<System.__Canon>)enumerable5;
					bool[] array17;
					int num11;
					if (!flag15)
					{
						bool flag103 = array6 == null;
						obj107 = obj106;
						obj24 = obj108;
						num15 = num43;
						list = list7;
						num9 = num44;
						num4 = num45;
						gillaSplashDirector = this;
						enumerable = enumerable4;
						stack = (Stack<System.__Canon>)enumerable5;
						if (flag103)
						{
							break;
						}
						num15 = array6.Length;
						bool flag104 = (nint)enumerable5 < array6.Length;
						obj5 = !flag104;
						obj6 = enumerable5 - array6.Length;
						flag4 = (nint)obj6 < 0;
						flag5 = obj6 == null;
						num6 = enumerable5 ^ array6.Length;
						num7 = (object)enumerable5 ^ obj6;
						num8 = num6 & num7;
						flag6 = num8 < 0;
						num11 = (int)list7;
						num9 = num44;
						if (obj5 == null)
						{
							object obj109 = (object)array6 + (object)enumerable5;
							num4 = obj109 + 32;
							list = (List<GillaSplashSpectate.Footprint>)((int*)num4)->m_value;
							bool flag105 = ((int*)num4)->m_value == 0;
							obj107 = obj106;
							obj24 = obj108;
							num9 = num44;
							gillaSplashDirector = this;
							enumerable = enumerable5;
							stack = (Stack<System.__Canon>)enumerable5;
							if (flag105)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X1_v14 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
							bool flag106 = (nint)0 < (nint)0;
							obj5 = !flag106;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X1_v14 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
							flag4 = (nint)0 < (nint)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X1_v14 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
							flag5 = (nint)0 == 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X1_v14 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
							nint num46 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X1_v14 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
							num7 = (int)(num46 ^ 0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X1_v14 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
							num8 = (int)((nint)0 & (nint)num7);
							flag6 = num8 < 0;
							obj107 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X1_v14 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
							if ((nint)0 <= (nint)0)
							{
								bool[] array16 = hasPlatforms;
								bool flag107 = hasPlatforms == null;
								obj24 = obj108;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X1_v14 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
								num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X1_v14 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+18]");
								obj6 = 0;
								num9 = num44;
								gillaSplashDirector = this;
								enumerable = enumerable5;
								stack = (Stack<System.__Canon>)enumerable5;
								if (flag107)
								{
									break;
								}
								bool flag108 = (nint)enumerable5 < array16.Length;
								object obj110 = !flag108;
								num11 = ((int*)num4)->m_value;
								num9 = num44;
								if (obj110 != null)
								{
									goto IL_4111;
								}
								object obj111 = (object)hasPlatforms + (object)enumerable5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X12_v10+20]");
								obj108 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X12_v10+20]");
								bool flag109 = (nint)0 == 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X12_v10+20]");
								obj24 = 0;
								array17 = hasPlatforms;
								if (flag109)
								{
									goto IL_45a5;
								}
							}
							bool flag110 = System.Runtime.CompilerServices.Unsafe.As<IEnumerable<System.__Canon>, UIntPtr>(ref enumerable5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33);
							obj5 = !flag110;
							obj6 = (object)enumerable5 - obj33;
							flag4 = (nint)obj6 < 0;
							flag5 = obj6 == null;
							num6 = (object)enumerable5 ^ obj33;
							num7 = (object)enumerable5 ^ obj6;
							num8 = num6 & num7;
							flag6 = num8 < 0;
							num11 = (int)list;
							num9 = num44;
							if (obj5 == null)
							{
								object obj112 = (object)array15 + (object)enumerable5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X8_v40+20]");
								bool flag111 = (nint)0 == 0;
								obj24 = obj108;
								num9 = num44;
								gillaSplashDirector = this;
								enumerable = enumerable5;
								stack = (Stack<System.__Canon>)enumerable5;
								if (flag111)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X8_v40+20]");
								((GillaSplashPool)0).Lay(list);
								array17 = hasPlatforms;
								num15 = array6.Length;
								obj24 = obj108;
								num44 = unchecked((nint)null);
								goto IL_45a5;
							}
						}
						goto IL_4111;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
					object obj113 = 0;
					gillaSplashDirector.hallsOut = -2147483648;
					object obj114 = obj113;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v7+E4]");
					bool flag112 = (nint)0 == 0;
					object obj115 = !flag112;
					if (obj115 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Physics.SyncTransforms();
					List<GameObject> list14 = gillaSplashDirector.standing;
					if ((object)gillaSplashDirector.standing == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					enumerable = (IEnumerable<System.__Canon>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					List<GillaSinkPlatform> list15 = gillaSplashDirector.sinkers;
					bool flag113 = (object)gillaSplashDirector.sinkers == null;
					int size3 = list14._size;
					list = (List<GillaSplashSpectate.Footprint>)(&size3);
					if (flag113)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					bool flag114 = stopwatch == null;
					int size4 = list15._size;
					size3 = list14._size;
					list = (List<GillaSplashSpectate.Footprint>)(&size4);
					gillaSplashDirector = gillaSplashDirector2;
					if (flag114)
					{
						break;
					}
					long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79D0]");
					object format = 0;
					string message = string.Format((string)format, gillaSplashDirector2, arg, arg2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj116 = 0;
					object obj117 = obj116;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1109 @ X8_v18+E4]");
					bool flag115 = (nint)0 == 0;
					object obj118 = !flag115;
					if (obj118 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Debug.Log(message);
					return;
					IL_45a5:
					bool flag116 = (nint)enumerable5 < num15;
					obj5 = !flag116;
					obj6 = enumerable5 - num15;
					flag4 = (nint)obj6 < 0;
					flag5 = obj6 == null;
					num6 = enumerable5 ^ num15;
					num7 = (object)enumerable5 ^ obj6;
					num8 = num6 & num7;
					flag6 = num8 < 0;
					num11 = (int)list;
					num9 = num44;
					if (obj5 == null)
					{
						int value4 = ((int*)num4)->m_value;
						bool flag117 = ((int*)num4)->m_value == 0;
						num9 = num44;
						gillaSplashDirector = this;
						enumerable = enumerable5;
						stack = (Stack<System.__Canon>)enumerable5;
						if (flag117)
						{
							break;
						}
						bool flag118 = array17 == null;
						num9 = num44;
						gillaSplashDirector = this;
						enumerable = enumerable5;
						stack = (Stack<System.__Canon>)enumerable5;
						if (flag118)
						{
							break;
						}
						num15 = array17.Length;
						bool flag119 = (nint)enumerable5 < array17.Length;
						object obj119 = !flag119;
						num11 = (int)list;
						num9 = num44;
						if (obj119 == null)
						{
							object obj120 = (object)array17 + (object)enumerable5;
							stack = (Stack<System.__Canon>)(enumerable5 + 1);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v36 (System.Int32)+18]");
							bool flag120 = (nint)0 < (nint)0;
							obj5 = !flag120;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v36 (System.Int32)+18]");
							flag4 = (nint)0 < (nint)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v36 (System.Int32)+18]");
							flag5 = (nint)0 == 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v36 (System.Int32)+18]");
							nint num47 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v36 (System.Int32)+18]");
							num7 = (int)(num47 ^ 0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v36 (System.Int32)+18]");
							num8 = (int)((nint)0 & (nint)num7);
							flag6 = num8 < 0;
							bool flag121 = flag4 == flag6;
							obj107 = !flag5;
							flag15 = (byte)((flag121 & obj107) ? 1 : 0) != 0;
							array15 = pools;
							bool flag122 = pools == null;
							object obj121 = !flag122;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v36 (System.Int32)+18]");
							num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v36 (System.Int32)+18]");
							obj6 = 0;
							num9 = num44;
							gillaSplashDirector = this;
							enumerable = enumerable5;
							obj106 = obj107;
							obj108 = obj24;
							num43 = array17.Length;
							list7 = list;
							num45 = num4;
							enumerable4 = enumerable5;
							enumerable5 = (IEnumerable<System.__Canon>)stack;
							if (obj121 == null)
							{
								break;
							}
							continue;
						}
					}
					goto IL_4111;
				}
				break;
				IL_4111:
				ex = new IndexOutOfRangeException();
				goto IL_411f;
				IL_411f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
				throw new ArgumentNullException();
			}
		}
		throw new NullReferenceException();
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_025a: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
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
		bool flag4 = (UnityEngine.Object)obj8 == this;
		bool flag5 = !flag4;
		UnityEngine.Object obj10 = this;
		if (!flag5)
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v26+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v26+A0]");
			object obj15 = 0;
			obj15 = 0;
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj10 = null;
		}
		ClearLocal();
		object obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (murkMat != null)
		{
			object obj19 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v16+E4]");
			bool flag9 = (nint)0 == 0;
			object obj20 = !flag9;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(murkMat);
		}
	}

	private void Update()
	{
		FollowLayout();
		Spawning();
		float deltaTime = Time.deltaTime;
		You(deltaTime);
		float deltaTime2 = Time.deltaTime;
		Wakes(deltaTime2);
		Sinking();
		float deltaTime3 = Time.deltaTime;
		Wading(deltaTime3);
		HallsOut();
	}

	private void HallsOut()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0644: Expected Obj, but got I4
		//IL_0662: Expected Obj, but got I
		//IL_068c: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I4
		//IL_027d: Expected I4, but got I8
		//IL_06c4: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I4
		//IL_01f8: Expected I4, but got I8
		//IL_0112: Expected VT, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I
		//IL_0362: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I4
		//IL_026b: Expected I4, but got I8
		//IL_0259: Expected I4, but got I8
		//IL_0390: Expected I4, but got I8
		//IL_03aa: Expected Obj, but got I4
		//IL_043f: Expected Obj, but got I4
		//IL_0727: Expected Obj, but got I4
		//IL_0490: Expected Obj, but got I
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected Obj, but got Unknown
		//IL_040d: Unsupported input type for neg.
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected Obj, but got Unknown
		//IL_05ee: Expected Obj, but got I4
		//IL_0523: Expected Obj, but got I4
		//IL_0576: Expected Obj, but got I
		//IL_05ad: Expected Obj, but got I4
		//IL_05b5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			if ((object)main != null)
			{
				Transform transform = main.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v50+E4]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float round = default;
					GillaSplashPool gillaSplashPool = GillaSplashPool.Near((Vector3)0, round);
					obj4 = null;
					obj5 = gillaSplashPool;
					goto IL_0652;
				}
			}
			goto IL_05fc;
		}
		goto IL_0652;
		IL_0652:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashGame current = GillaSplashGame.Current;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num;
		if ((UnityEngine.Object)current != (UnityEngine.Object)null)
		{
			if ((object)current == null)
			{
				goto IL_05fc;
			}
			bool live = current.Live;
			bool flag7 = !live;
			num = -2;
			UnityEngine.Object obj14 = null;
			if (!flag7)
			{
				byte phase = current.Phase;
				int num2 = phase & 0xFF;
				num = (int)((num2 != 2) ? 4294967294L : (4294967294L + 1));
				obj14 = null;
			}
		}
		else
		{
			num = -2;
			UnityEngine.Object obj14 = null;
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v16+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj5 != null)
		{
			if ((object)obj5 == null)
			{
				goto IL_05fc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X20_v3 (UnityEngine.Object)+20]");
			num = 0;
		}
		if (num == hallsOut)
		{
			return;
		}
		Transform[] array = hallGroups;
		hallsOut = num;
		if (hallGroups != null)
		{
			object obj17 = num + 1;
			bool flag9 = obj17 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj18 = 0;
			object obj19 = -num;
			object obj20 = 0;
			UnityEngine.Object obj21 = null;
			object obj22 = 0;
			while (true)
			{
				if ((nint)obj22 >= array.Length)
				{
					return;
				}
				int num3 = (int)(num & 0x80000000L);
				bool flag10 = num3 == 0;
				object obj23 = !flag10;
				bool flag11 = flag9;
				if (obj23 == null)
				{
					object obj24 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v29+E4]");
					bool flag12 = (nint)0 == 0;
					object obj25 = !flag12;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj26 = obj19 + obj22;
					object obj27 = (((nint)obj26 >= 0) ? obj26 : ((object)(0 - obj26)));
					array = hallGroups;
					object obj28 = obj27 - 2;
					bool flag13 = (nint)obj28 < 0;
					object obj29 = obj27 ^ 2;
					object obj30 = obj27 ^ obj28;
					object obj31 = obj29 & obj30;
					bool flag14 = (nint)obj31 < 0;
					bool flag15 = flag13 == flag14;
					bool flag16 = !flag15;
					bool flag17 = hallGroups == null;
					flag11 = flag16;
					if (flag17)
					{
						break;
					}
				}
				bool flag18 = (nint)obj22 < array.Length;
				object obj32 = !flag18;
				if (obj32 == null)
				{
					object obj33 = (object)array + obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v15+20]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v15+20]");
					GameObject gameObject = ((Component)0).gameObject;
					if ((object)gameObject == null)
					{
						break;
					}
					bool activeSelf = gameObject.activeSelf;
					bool flag19 = flag11 == activeSelf;
					obj21 = null;
					if (!flag19)
					{
						Transform[] array2 = hallGroups;
						if (hallGroups == null)
						{
							break;
						}
						bool flag20 = (nint)obj22 < array2.Length;
						object obj34 = !flag20;
						if (obj34 != null)
						{
							goto IL_060a;
						}
						object obj35 = (object)hallGroups + obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v20+20]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v20+20]");
						GameObject gameObject2 = ((Component)0).gameObject;
						if ((object)gameObject2 == null)
						{
							break;
						}
						gameObject2.SetActive(flag11);
						obj20 = 0;
						obj21 = (UnityEngine.Object)flag11;
					}
					array = hallGroups;
					obj22++;
					bool flag21 = hallGroups == null;
					object obj36 = !flag21;
					if (obj36 == null)
					{
						break;
					}
					continue;
				}
				goto IL_060a;
			}
		}
		goto IL_05fc;
		IL_05fc:
		NullReferenceException ex = new NullReferenceException();
		goto IL_060a;
		IL_060a:
		throw new IndexOutOfRangeException();
	}

	private unsafe void Wading(float dt)
	{
		//IL_14a2: Invalid comparison between F4 and I4
		//IL_14b3: Expected Obj, but got I4
		//IL_14bc: Invalid comparison between F4 and I4
		//IL_14d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d8: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_14f6: Expected Obj, but got I
		//IL_150e: Expected VT, but got I4
		//IL_1521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_00ac: Expected VT, but got I4
		//IL_00c1: Expected F4, but got I
		//IL_1543: Expected Obj, but got I
		//IL_10db: Expected Obj, but got I4
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_10df: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ee: Expected Obj, but got I4
		//IL_10f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ff: Expected Obj, but got I4
		//IL_1881: Expected Obj, but got I
		//IL_1889: Expected I, but got Obj
		//IL_1889: Unknown result type (might be due to invalid IL or missing references)
		//IL_1892: Expected Ref, but got Unknown
		//IL_18ac: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_111e: Expected Obj, but got I4
		//IL_1126: Unknown result type (might be due to invalid IL or missing references)
		//IL_112e: Expected Obj, but got Unknown
		//IL_0181: Expected Obj, but got I
		//IL_142c: Expected Obj, but got I4
		//IL_1173: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I
		//IL_1493: Expected Obj, but got I4
		//IL_11b8: Expected Obj, but got I
		//IL_11c0: Expected I, but got Obj
		//IL_0251: Expected Obj, but got Ref
		//IL_0256: Expected I, but got Obj
		//IL_01d7: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got Ref
		//IL_0689: Expected Obj, but got I
		//IL_13a3: Expected Obj, but got I4
		//IL_13a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got Ref
		//IL_1226: Expected Obj, but got I
		//IL_122e: Expected I, but got Obj
		//IL_1379: Expected I, but got Obj
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02e3: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I4
		//IL_0358: Expected Obj, but got I4
		//IL_07b1: Expected Obj, but got I4
		//IL_0376: Expected Obj, but got I
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_03b8: Expected Obj, but got I8
		//IL_07e4: Expected Obj, but got I
		//IL_0806: Expected Obj, but got I4
		//IL_03f5: Expected Obj, but got I
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_043f: Expected Obj, but got I4
		//IL_0455: Expected Obj, but got I
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_084b: Expected Obj, but got I4
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Expected Obj, but got Unknown
		//IL_0fec: Expected Obj, but got I4
		//IL_04a8: Expected Obj, but got I
		//IL_04b0: Expected I, but got Obj
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_04ea: Expected Obj, but got I8
		//IL_0527: Expected Obj, but got I
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_0557: Expected Obj, but got I
		//IL_0576: Expected Obj, but got I
		//IL_0587: Expected I, but got Obj
		//IL_05ae: Expected Obj, but got I
		//IL_05fd: Expected Obj, but got I4
		//IL_0917: Expected Obj, but got I4
		//IL_0623: Expected Obj, but got I
		//IL_1587: Expected Obj, but got I4
		//IL_093d: Expected Obj, but got I
		//IL_094d: Expected F4, but got I
		//IL_095d: Expected Obj, but got I
		//IL_098b: Expected Obj, but got I4
		//IL_09aa: Expected F4, but got I
		//IL_09b9: Expected Obj, but got I4
		//IL_09f7: Expected F4, but got I
		//IL_0a81: Expected Obj, but got I
		//IL_0a94: Expected Obj, but got I4
		//IL_0ac1: Expected F4, but got I4
		//IL_160c: Expected Obj, but got I4
		//IL_162e: Expected Obj, but got I4
		//IL_0acf: Expected F4, but got I4
		//IL_1667: Expected Obj, but got I4
		//IL_0ae9: Expected F4, but got VT
		//IL_169f: Expected Obj, but got I4
		//IL_0b2e: Expected Obj, but got I
		//IL_0b58: Expected Obj, but got I4
		//IL_0bbb: Expected VT, but got I4
		//IL_0be9: Expected Obj, but got I4
		//IL_16bd: Expected Obj, but got I
		//IL_16ce: Expected VT, but got Obj
		//IL_16e8: Expected F4, but got I4
		//IL_0c61: Expected F4, but got I4
		//IL_0f48: Expected Obj, but got I
		//IL_0f5b: Expected VT, but got Obj
		//IL_0f64: Expected F4, but got I4
		//IL_0f8d: Expected F4, but got I4
		//IL_0fb7: Expected F4, but got VT
		//IL_0d49: Invalid comparison between F4 and I4
		//IL_0d58: Invalid comparison between F4 and I4
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected Obj, but got Unknown
		//IL_0d80: Expected Obj, but got F4
		//IL_0db5: Expected Obj, but got I4
		//IL_0dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Expected Obj, but got Unknown
		//IL_1758: Expected Obj, but got I4
		//IL_0df1: Invalid comparison between F4 and I4
		//IL_0e4c: Expected Obj, but got I
		//IL_0e76: Expected Obj, but got I4
		//IL_0ea1: Expected VT, but got I4
		//IL_0eb1: Expected Obj, but got I
		//IL_0edb: Expected Obj, but got I4
		//IL_0f06: Expected VT, but got I4
		float num = default;
		bool flag = num < 0f;
		object obj = !flag;
		bool flag2 = num == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v4+A0]");
		object obj7 = 0;
		bool flag4 = obj7 == null;
		(Vector3, float) tuple = ((Vector3, float))0;
		System.__Canon value = null;
		UnityEngine.Object obj9 = default;
		UnityEngine.Object obj8 = obj9;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag4)
		{
			Enumerator<, > enumerator = ((List<System.__Canon>)obj7).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj12 = 0;
			tuple = ((Vector3, float))0;
			value = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
			float num2 = 0f;
			_003C_003Ec__DisplayClass61_0 obj22 = default;
			UnityEngine.Object obj25 = default;
			IEnumerable<System.__Canon> enumerable = default;
			Func<System.__Canon, System.__Canon> func = default;
			float num43 = default;
			float num60 = default;
			float num61 = default;
			float num5 = default;
			float num7 = default;
			float num9 = default;
			object obj48 = default;
			object obj50 = default;
			object obj52 = default;
			float num17 = default;
			float num19 = default;
			float num21 = default;
			float num23 = default;
			float num25 = default;
			float num27 = default;
			float num29 = default;
			float num31 = default;
			float num33 = default;
			IEnumerable<System.__Canon> enumerable2 = default;
			_003C_003Ec__DisplayClass61_0 obj23 = default;
			float num11 = default;
			float num13 = default;
			float num15 = default;
			Enumerator<, > val2 = default;
			object obj103 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A90]");
				object obj13 = 0;
				UnityEngine.Object obj17;
				System.__Canon _Canon3;
				nint num3;
				if (val.MoveNext())
				{
					object obj14 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X0_v36+E4]");
					bool flag5 = (nint)0 == 0;
					object obj15 = !flag5;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = obj9 == null;
					bool flag7 = !flag6;
					object obj16 = !flag7;
					System.__Canon _Canon = null;
					if (obj16 != null)
					{
						continue;
					}
					bool flag8 = (object)limbs == null;
					_Canon = null;
					obj17 = null;
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A60]");
						object obj18 = 0;
						object obj19 = obj18;
						System.__Canon _Canon2;
						if (((Dictionary<System.__Canon, System.__Canon>)(object)limbs).TryGetValue((System.__Canon)(object)obj9, out value))
						{
							bool flag9 = (object)obj9 == null;
							object obj20 = !flag9;
							_Canon = (System.__Canon)(&value);
							_Canon2 = (System.__Canon)(object)obj9;
							if (obj20 == null)
							{
								_Canon = (System.__Canon)(&value);
								_Canon3 = (System.__Canon)(object)obj9;
								goto IL_133e;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AC8]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							obj22._002Ector();
							bool flag10 = (object)obj9 == null;
							obj23 = obj22;
							_Canon = (System.__Canon)(&value);
							num3 = unchecked((nint)null);
							if (flag10)
							{
								goto IL_137e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E8]");
							object obj24 = 0;
							_Canon = (System.__Canon)obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
							bool flag11 = obj22 == null;
							obj23 = obj22;
							obj17 = obj25;
							if (flag11)
							{
								goto IL_130c;
							}
							object obj26 = obj22 + 16;
							obj26 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							bool flag12 = enumerable == null;
							enumerable2 = enumerable;
							obj23 = obj22;
							_Canon3 = (System.__Canon)4;
							if (flag12)
							{
								goto IL_135a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X0_v135 (System.Collections.Generic.IEnumerable`1<System.__Canon>)+18]");
							bool flag13 = (nint)0 == 0;
							enumerable2 = enumerable;
							obj23 = obj22;
							_Canon3 = (System.__Canon)4;
							if (flag13)
							{
								goto IL_1330;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4908]");
							object obj28 = 0;
							_Canon3 = (System.__Canon)obj28;
							object obj29 = enumerable + 32;
							obj29 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X0_v135 (System.Collections.Generic.IEnumerable`1<System.__Canon>)+18]");
							object obj30 = 0 & 0xFFFFFFFEL;
							bool flag14 = obj30 == null;
							enumerable2 = enumerable;
							obj23 = obj22;
							if (flag14)
							{
								goto IL_1368;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
							object obj31 = 0;
							_Canon3 = (System.__Canon)obj31;
							object obj32 = enumerable + 40;
							obj32 = obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X0_v135 (System.Collections.Generic.IEnumerable`1<System.__Canon>)+18]");
							bool flag15 = (nint)0 < (nint)2;
							object obj33 = !flag15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X0_v135 (System.Collections.Generic.IEnumerable`1<System.__Canon>)+18]");
							object obj34 = -2;
							bool flag16 = obj34 == null;
							object obj35 = ~obj33;
							object obj36 = obj35 | flag16;
							enumerable2 = enumerable;
							obj23 = obj22;
							if (obj36 != null)
							{
								goto IL_134c;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AD0]");
							object obj37 = 0;
							num3 = (nint)obj37;
							object obj38 = enumerable + 48;
							obj38 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X0_v135 (System.Collections.Generic.IEnumerable`1<System.__Canon>)+18]");
							object obj39 = 0 & 0xFFFFFFFCL;
							bool flag17 = obj39 == null;
							enumerable2 = enumerable;
							obj23 = obj22;
							if (flag17)
							{
								goto IL_138c;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AD8]");
							object obj40 = 0;
							object obj41 = enumerable + 56;
							obj41 = obj40;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA0]");
							object obj42 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AC0]");
							object obj43 = 0;
							func._002Ector((object)obj22, (IntPtr)obj43);
							IEnumerable<System.__Canon> source = Enumerable.Select(enumerable, func);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A80]");
							object obj44 = 0;
							obj17 = (UnityEngine.Object)obj44;
							System.__Canon[] array = Enumerable.ToArray(source);
							bool flag18 = (object)limbs == null;
							Func<System.__Canon, System.__Canon> func2 = func;
							enumerable2 = enumerable;
							obj23 = obj22;
							value = (System.__Canon)(object)array;
							obj19 = 0;
							_Canon = (System.__Canon)(object)array;
							if (flag18)
							{
								goto IL_131a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A70]");
							object obj45 = 0;
							obj19 = obj45;
							((Dictionary<System.__Canon, System.__Canon>)(object)limbs).set_Item((System.__Canon)(object)obj9, (System.__Canon)(object)array);
							func2 = func;
							enumerable2 = enumerable;
							obj23 = obj22;
							value = (System.__Canon)(object)array;
							_Canon = (System.__Canon)(object)array;
							_Canon2 = (System.__Canon)(object)obj9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ stack_-E0 (UnityEngine.Object)+E9]");
						object obj46 = (nint)0 & (nint)0xFE;
						if ((nint)obj46 != 2)
						{
							continue;
						}
						if (value != null)
						{
							float num4 = num5;
							float num6 = num7;
							float num8 = num9;
							object obj47 = obj48;
							object obj49 = obj50;
							object obj51 = obj52;
							float num10 = num11;
							float num12 = num13;
							float num14 = num15;
							float num16 = num17;
							float num18 = num19;
							float num20 = num21;
							float num22 = num23;
							float num24 = num25;
							float num26 = num27;
							float num28 = num29;
							float num30 = num31;
							float num32 = num33;
							Func<System.__Canon, System.__Canon> func3 = null;
							IEnumerable<System.__Canon> enumerable3 = enumerable2;
							_003C_003Ec__DisplayClass61_0 obj53 = obj23;
							object obj54 = obj19;
							System.__Canon _Canon4 = _Canon;
							float num34 = num2;
							System.__Canon _Canon5 = value;
							while (true)
							{
								Func<System.__Canon, System.__Canon> func4 = func3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v53 (System.__Canon)+18]");
								bool flag19 = (nint)func4 >= 0;
								num5 = num4;
								num7 = num6;
								num9 = num8;
								obj48 = obj47;
								obj50 = obj49;
								obj52 = obj51;
								num11 = num10;
								num13 = num12;
								num15 = num14;
								num17 = num16;
								num19 = num18;
								num21 = num20;
								num23 = num22;
								num25 = num24;
								num27 = num26;
								num29 = num28;
								num31 = num30;
								num33 = num32;
								Func<System.__Canon, System.__Canon> func2 = func3;
								enumerable2 = enumerable3;
								obj23 = obj53;
								obj19 = obj54;
								_Canon = _Canon4;
								num2 = num34;
								if (flag19)
								{
									break;
								}
								Func<System.__Canon, System.__Canon> func5 = func3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v53 (System.__Canon)+18]");
								bool flag20 = (nint)func5 < 0;
								object obj55 = !flag20;
								if (obj55 == null)
								{
									object obj56 = obj10;
									object obj57 = (object)_Canon5 + (object)func3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1498 @ X8_v59+20]");
									obj53 = (_003C_003Ec__DisplayClass61_0)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X0_v77+E4]");
									bool flag21 = (nint)0 == 0;
									object obj58 = !flag21;
									if (obj58 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag22 = (UnityEngine.Object)(object)obj53 == null;
									bool flag23 = !flag22;
									object obj59 = !flag23;
									num15 = num14;
									_Canon = null;
									_Canon2 = null;
									if (obj59 == null)
									{
										bool flag24 = obj53 == null;
										_Canon4 = null;
										_Canon2 = null;
										if (flag24)
										{
											goto IL_128e;
										}
										Vector3 position = ((Transform)(object)obj53).position;
										Transform transform = ((Component)obj9).transform;
										bool flag25 = (object)transform == null;
										num28 = num12;
										num30 = num14;
										num32 = num34;
										_Canon4 = null;
										_Canon2 = null;
										if (flag25)
										{
											goto IL_1280;
										}
										Vector3 forward = transform.forward;
										bool flag26 = (nint)func3 < 2;
										object obj60 = !flag26;
										IEnumerable<System.__Canon> enumerable4 = (IEnumerable<System.__Canon>)(~obj60);
										bool flag27 = (nint)func3 < 2;
										object obj61 = !flag27;
										object obj62 = ~obj61;
										bool flag28 = (object)wading == null;
										num8 = num14;
										obj47 = obj62;
										num22 = num12;
										num24 = num14;
										num26 = num34;
										num28 = num12;
										num30 = num14;
										num32 = num34;
										enumerable3 = enumerable4;
										_Canon4 = null;
										_Canon2 = null;
										if (flag28)
										{
											goto IL_129c;
										}
										object obj63 = obj11;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1757 @ X8_v64+A0]");
										object obj64 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1758 @ X8_v65+28]");
										num24 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A10]");
										object obj65 = 0;
										obj54 = obj65;
										bool flag29 = ((Dictionary<System.__Canon, (Vector3, float)>)(object)wading).TryGetValue((System.__Canon)(object)obj53, out tuple);
										object obj66 = 17281024 + 2752;
										bool flag30 = !flag29;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1771 @ X8_v69+v1743 @ TEMPCOND_v35 (System.Collections.Generic.IEnumerable`1<System.__Canon>)*4]");
										num30 = 0f;
										object obj67 = 17281024 + 2216;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1771 @ X8_v69+v1743 @ TEMPCOND_v35 (System.Collections.Generic.IEnumerable`1<System.__Canon>)*4]");
										float num35 = 0f * num34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1771 @ X8_v69+v1743 @ TEMPCOND_v35 (System.Collections.Generic.IEnumerable`1<System.__Canon>)*4]");
										float num36 = 0f * num12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1774 @ X8_v71+v1604 @ TEMPCOND_v36*4]");
										num22 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1774 @ X8_v71+v1604 @ TEMPCOND_v36*4]");
										float num37 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1758 @ X8_v65+24]");
										float num38 = num37 * 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1774 @ X8_v71+v1604 @ TEMPCOND_v36*4]");
										float num39 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1758 @ X8_v65+2C]");
										float num40 = num39 * 0f;
										float num41 = num34 + num35;
										float num42 = num12 + num36;
										num28 = num41 + num38;
										num32 = num42 + num40;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
										object obj68 = 0;
										object obj69 = obj68;
										object obj70 = !flag30;
										object obj71 = ~obj70;
										num26 = ((obj71 != null) ? 0f : num43);
										object obj72 = !flag30;
										object obj73 = ~obj72;
										num16 = ((obj73 != null) ? num32 : 0f);
										object obj74 = !flag30;
										obj51 = ~obj74;
										float num44 = ((obj51 != null) ? num28 : ((float)tuple));
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1787 @ X0_v90+E4]");
										bool flag31 = (nint)0 == 0;
										object obj75 = !flag31;
										if (obj75 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object obj76 = obj12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1825 @ X0_v93+E4]");
										bool flag32 = (nint)0 == 0;
										object obj77 = !flag32;
										if (obj77 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
										object obj78 = 0;
										object obj79 = obj78;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1833 @ X0_v95+E4]");
										bool flag33 = (nint)0 == 0;
										object obj80 = !flag33;
										if (obj80 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float num45 = num30 * num14;
										float num46 = num14 + num45;
										float num47 = num22 * num24;
										num18 = num46 + num47;
										GillaSplashPool gillaSplashPool = GillaSplashPool.At((Vector3)0);
										object obj81 = obj10;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ X0_v99+E4]");
										bool flag34 = (nint)0 == 0;
										object obj82 = !flag34;
										if (obj82 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if (gillaSplashPool != null)
										{
											bool flag35 = (object)gillaSplashPool == null;
											num6 = num44;
											num8 = num14;
											obj47 = obj62;
											num10 = 0f;
											num12 = num32;
											num15 = num18;
											num20 = num14;
											enumerable3 = (IEnumerable<System.__Canon>)gillaSplashPool;
											_Canon4 = null;
											num34 = num28;
											obj17 = null;
											if (flag35)
											{
												goto IL_12c8;
											}
											float surface = gillaSplashPool.Surface;
											float num48 = num32 - num16;
											float num49 = num28 - num44;
											float num50 = num48 * num48;
											float num51 = num49 * num49;
											float num52 = num51 + num50;
											float num53 = surface;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
											float num54 = num53 + 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
											float num55 = num52 / num;
											float num56 = num55;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
											float num57 = num56 - 0f;
											bool flag36 = num57 < 0f;
											bool flag37 = num57 == 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
											object obj83 = num55 ^ 0;
											object obj84 = num55 ^ num57;
											object obj85 = obj83 & obj84;
											bool flag38 = (nint)obj85 < 0;
											bool flag39 = flag36 == flag38;
											obj49 = !flag37;
											object obj86 = flag39 & obj49;
											obj51 = ~obj86;
											bool flag40;
											if (obj51 == null)
											{
												float num58 = num18 - num54;
												flag40 = num58 < 0f;
											}
											else
											{
												flag40 = false;
											}
											object obj87 = !flag40;
											if (obj87 == null)
											{
												float time = Time.time;
												if (!(time < num26))
												{
													float surface2 = gillaSplashPool.Surface;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
													object obj88 = 0;
													object obj89 = obj88;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1943 @ X0_v109+E4]");
													bool flag41 = (nint)0 == 0;
													object obj90 = !flag41;
													if (obj90 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													GillaSplashPool.Ripple((Vector3)0, num28);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AB0]");
													object obj91 = 0;
													object obj92 = obj91;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1956 @ X0_v112+E4]");
													bool flag42 = (nint)0 == 0;
													object obj93 = !flag42;
													if (obj93 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													GillaVoxelSplash.Emit((Vector3)0, num28);
													float time2 = Time.time;
													float num59 = time2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
													num26 = num59 + 0f;
													num22 = surface2;
												}
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A28]");
										object obj94 = 0;
										(Vector3, float) tuple2 = ((Vector3)obj94, num28);
										bool flag43 = (object)wading == null;
										num4 = 0f;
										num6 = num44;
										num8 = num14;
										obj47 = obj62;
										num10 = num26;
										num12 = num32;
										num15 = num18;
										num20 = num14;
										enumerable3 = (IEnumerable<System.__Canon>)wading;
										_Canon4 = null;
										num34 = num28;
										_Canon2 = (System.__Canon)obj94;
										if (flag43)
										{
											goto IL_12b2;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A20]");
										object obj95 = 0;
										((Dictionary<System.__Canon, (Vector3, float)>)(object)wading).set_Item((System.__Canon)(object)obj53, ((Vector3, float))obj95);
										num4 = 0f;
										num6 = num44;
										num8 = num14;
										obj47 = obj62;
										num10 = num60;
										num12 = 0f;
										num15 = num61;
										num20 = num14;
										enumerable3 = (IEnumerable<System.__Canon>)wading;
										_Canon = (System.__Canon)obj95;
										num34 = (float)tuple2;
										_Canon2 = (System.__Canon)(object)obj53;
									}
									func2 = (Func<System.__Canon, System.__Canon>)(func3 + 1);
									bool flag44 = value == null;
									object obj96 = !flag44;
									num5 = num4;
									num7 = num6;
									num9 = num8;
									obj48 = obj47;
									obj50 = obj49;
									obj52 = obj51;
									num11 = num10;
									num13 = num12;
									num17 = num16;
									num19 = num18;
									num21 = num20;
									num23 = num22;
									num25 = num24;
									num27 = num26;
									num29 = num28;
									num31 = num30;
									num33 = num32;
									enumerable2 = enumerable3;
									obj23 = obj53;
									obj19 = obj54;
									num2 = num34;
									num14 = num15;
									func3 = func2;
									_Canon4 = _Canon;
									_Canon5 = value;
									if (obj96 != null)
									{
										continue;
									}
									goto IL_10c2;
								}
								IndexOutOfRangeException ex = new IndexOutOfRangeException();
								goto IL_1280;
								IL_12b2:
								NullReferenceException ex2 = new NullReferenceException();
								obj17 = (UnityEngine.Object)(object)_Canon2;
								goto IL_12c8;
								IL_12c8:
								NullReferenceException ex3 = new NullReferenceException();
								num11 = num10;
								num13 = num12;
								obj19 = obj54;
								_Canon = _Canon4;
								num2 = num34;
								goto IL_12fe;
								IL_1280:
								NullReferenceException ex4 = new NullReferenceException();
								goto IL_128e;
								IL_129c:
								NullReferenceException ex5 = new NullReferenceException();
								num15 = num14;
								goto IL_12b2;
								IL_128e:
								NullReferenceException ex6 = new NullReferenceException();
								goto IL_129c;
							}
							continue;
						}
						goto IL_10c2;
					}
					goto IL_12fe;
				}
				obj8 = null;
				object obj97 = 0;
				val = val2;
				object obj98 = 17;
				Enumerator<, > val3 = (Enumerator<, >)(ref val);
				object obj99 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A88]");
					object obj100 = 0;
					num3 = (nint)obj100;
					((Enumerator<, >*)val3)->Dispose();
					bool flag45 = obj99 == null;
					object obj101 = !flag45;
					num = num2;
					if (obj101 == null)
					{
						bool flag46 = (object)obj8 == null;
						object obj102 = !flag46;
						num = num2;
						OutOfMemoryException ex7 = (OutOfMemoryException)val3;
						if (obj102 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex7 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num3)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj8 = (UnityEngine.Object)1;
						obj99 = obj97;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj99 = obj103;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj97 = obj103;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E314");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					num2 = num;
					obj98 = 0;
				}
				if ((nint)obj98 != 17)
				{
					bool flag47 = obj98 == null;
					object obj104 = !flag47;
					if (obj104 != null)
					{
						return;
					}
				}
				bool flag48 = (object)limbs == null;
				num = num2;
				if (flag48)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A68]");
				object obj105 = 0;
				num3 = (nint)obj105;
				int count = ((Dictionary<System.__Canon, System.__Canon>)(object)limbs).Count;
				if (count > 8)
				{
					bool flag49 = (object)limbs == null;
					num = num2;
					if (flag49)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A58]");
					object obj106 = 0;
					num3 = (nint)obj106;
					((Dictionary<System.__Canon, System.__Canon>)(object)limbs).Clear();
					bool flag50 = (object)wading == null;
					num = num2;
					if (flag50)
					{
						break;
					}
					((Dictionary<System.__Canon, (Vector3, float)>)(object)wading).Clear();
				}
				return;
				IL_1330:
				IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
				goto IL_133e;
				IL_135a:
				NullReferenceException ex9 = new NullReferenceException();
				goto IL_1368;
				IL_134c:
				IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
				goto IL_135a;
				IL_1368:
				IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
				num3 = (nint)_Canon3;
				goto IL_137e;
				IL_137e:
				NullReferenceException ex12 = new NullReferenceException();
				goto IL_138c;
				IL_138c:
				IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
				obj8 = null;
				obj97 = 0;
				val = val2;
				num = num2;
				val3 = (Enumerator<, >)(ref val);
				break;
				IL_10c2:
				throw new NullReferenceException();
				IL_133e:
				NullReferenceException ex14 = new NullReferenceException();
				goto IL_134c;
				IL_12fe:
				NullReferenceException ex15 = new NullReferenceException();
				goto IL_130c;
				IL_130c:
				NullReferenceException ex16 = new NullReferenceException();
				goto IL_131a;
				IL_131a:
				NullReferenceException ex17 = new NullReferenceException();
				_Canon3 = (System.__Canon)(object)obj17;
				goto IL_1330;
			}
		}
		throw new NullReferenceException();
	}

	private unsafe static void Wake(Vector3 at, Vector3 was, float dt, ref float next)
	{
		//IL_02f9: Expected Obj, but got I4
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_0090: Expected VT, but got I4
		//IL_00a4: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I4
		//IL_0133: Expected VT, but got I4
		//IL_0164: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_0358: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I4
		//IL_0213: Invalid comparison between F4 and I
		//IL_024f: Expected native int or pointer, but got VT
		//IL_028a: Invalid comparison between F4 and I
		//IL_03ba: Expected Obj, but got I4
		//IL_02dd: Expected VT, but got I4
		//IL_02ae: Invalid comparison between F4 and I
		object obj = default;
		bool flag = (nint)obj < 0;
		object obj2 = !flag;
		bool flag2 = obj == null;
		object obj3 = ~obj2;
		object obj4 = obj3 | flag2;
		if (obj4 != null)
		{
			return;
		}
		float time = Time.time;
		if (time < at.x)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashPool gillaSplashPool = GillaSplashPool.At((Vector3)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = gillaSplashPool == null;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 != null || !gillaSplashPool.In((Vector3)0, dt))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = default;
		float num = dt - (float)obj15;
		object obj17 = default;
		object obj18 = default;
		object obj16 = obj17 - obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj19 = 0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v17+E4]");
		bool flag8 = (nint)0 == 0;
		object obj21 = !flag8;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2 = num * num;
		object obj22 = obj16 * obj16;
		float num3 = num2 + (float)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num4 = num3 / (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		if (num4 < 0f)
		{
			return;
		}
		float time2 = Time.time;
		float num5 = time2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
		float x = num5 + 0f;
		((Vector3*)(nint)at)->x = x;
		float surface = gillaSplashPool.Surface;
		float num6 = num4 / 6f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		if (!(num6 < 0f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			if (num6 > 0f)
			{
				goto IL_02c0;
			}
		}
		object obj23 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v21+E4]");
		bool flag9 = (nint)0 == 0;
		object obj24 = !flag9;
		if (obj24 == null)
		{
			goto IL_02c0;
		}
		goto IL_02cf;
		IL_02c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_02cf;
		IL_02cf:
		GillaSplashPool.Ripple((Vector3)0, dt);
	}

	private unsafe void Wakes(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0c90: Expected Obj, but got I4
		//IL_0dc8: Expected Obj, but got I
		//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Expected VT, but got I4
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected VT, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected Obj, but got I
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected Obj, but got I4
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected F4, but got Unknown
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected Obj, but got I4
		//IL_096c: Expected Obj, but got I4
		//IL_0d7f: Expected Obj, but got I
		//IL_0d87: Expected I, but got Obj
		//IL_0d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Expected Ref, but got Unknown
		//IL_0daa: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I4
		//IL_0129: Expected VT, but got I4
		//IL_098b: Expected Obj, but got I4
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected Obj, but got Unknown
		//IL_014f: Expected VT, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_0192: Expected VT, but got I4
		//IL_0c01: Expected Obj, but got I4
		//IL_09d8: Expected Obj, but got I4
		//IL_0c60: Expected Obj, but got I4
		//IL_0a15: Expected Obj, but got I
		//IL_0a1d: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I
		//IL_01d2: Expected VT, but got I4
		//IL_01db: Expected Obj, but got I4
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected F4, but got Unknown
		//IL_01f9: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I4
		//IL_02a7: Expected VT, but got I4
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7c: Expected Obj, but got I4
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Expected I, but got Obj
		//IL_023f: Expected Obj, but got I
		//IL_0261: Expected VT, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected F4, but got Unknown
		//IL_0279: Expected Obj, but got I
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02e5: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I8
		//IL_03b4: Expected VT, but got I4
		//IL_032a: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I
		//IL_035c: Expected VT, but got I4
		//IL_036c: Expected Obj, but got I
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_04a1: Expected Obj, but got I4
		//IL_04b7: Expected Obj, but got I
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		//IL_04ed: Expected VT, but got I4
		//IL_042f: Expected Obj, but got I
		//IL_0459: Expected VT, but got I4
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected F4, but got Unknown
		//IL_0471: Expected Obj, but got I
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected Obj, but got Unknown
		//IL_0519: Expected Obj, but got I
		//IL_054b: Expected VT, but got I4
		//IL_0573: Expected Obj, but got I8
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_058a: Expected Obj, but got I4
		//IL_0593: Expected VT, but got I4
		//IL_05a3: Expected VT, but got I
		//IL_0d3e: Expected Obj, but got I4
		//IL_05d2: Expected Obj, but got I4
		//IL_0601: Expected Obj, but got I
		//IL_061f: Expected Obj, but got I4
		//IL_0638: Expected VT, but got I4
		//IL_0ab8: Expected Obj, but got VT
		//IL_08cc: Expected Obj, but got I
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected Obj, but got Unknown
		//IL_0908: Expected VT, but got Obj
		//IL_0665: Expected VT, but got I4
		//IL_066e: Expected VT, but got I4
		//IL_0697: Expected Obj, but got I
		//IL_074e: Expected VT, but got Ref
		//IL_075e: Expected VT, but got I
		//IL_06da: Expected Obj, but got I4
		//IL_06eb: Expected Obj, but got I4
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected Obj, but got I
		//IL_0ce9: Expected Obj, but got I
		//IL_0d17: Expected Obj, but got I4
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected F4, but got Unknown
		//IL_07bb: Expected VT, but got I4
		//IL_07bb: Expected VT, but got Ref
		//IL_07cc: Expected Obj, but got I
		//IL_070a: Expected Obj, but got I4
		//IL_0712: Expected VT, but got Ref
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got I
		//IL_07dd: Expected VT, but got Obj
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected F4, but got Unknown
		//IL_07ee: Expected VT, but got Obj
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected VT, but got Ref
		//IL_0848: Expected VT, but got Obj
		//IL_0863: Expected VT, but got Obj
		//IL_0863: Expected Obj, but got I
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected Obj, but got I4
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v4+8]");
		bool flag2 = (nint)0 == 0;
		Enumerator<, > val = (Enumerator<, >)0;
		(Vector3, float) value = ((Vector3, float))0;
		UnityEngine.Object obj6 = default;
		UnityEngine.Object obj5 = obj6;
		Enumerator<, > val2 = (Enumerator<, >)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A20]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v4+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			val = (Enumerator<, >)0;
			value = ((Vector3, float))0;
			Enumerator<, > val4 = default;
			Enumerator<, > val3 = val4;
			object obj19 = default;
			object obj44 = default;
			object obj46 = default;
			object obj49 = default;
			Enumerator<, > val5 = default;
			Enumerator<, > val7 = default;
			object obj55 = default;
			object obj63 = default;
			ArgumentNullException ex = default;
			IndexOutOfRangeException ex2 = default;
			ArgumentNullException ex3 = default;
			float num3 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
				object obj12 = 0;
				float num;
				UnityEngine.Object obj22;
				UnityEngine.Object obj30;
				if (val2.MoveNext())
				{
					object obj13 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X0_v34+E4]");
					bool flag3 = (nint)0 == 0;
					object obj14 = !flag3;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj6 == null;
					bool flag5 = !flag4;
					object obj15 = !flag5;
					(Vector3, float) tuple = ((Vector3, float))0;
					if (obj15 != null)
					{
						continue;
					}
					bool flag6 = (object)obj6 == null;
					tuple = ((Vector3, float))0;
					UnityEngine.Object obj16 = null;
					if (flag6)
					{
						goto IL_0acb;
					}
					bool isLocal = ((NetworkApe)obj6).IsLocal;
					bool flag7 = !isLocal;
					object obj17 = !flag7;
					tuple = ((Vector3, float))0;
					if (obj17 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					bool flag8 = obj19 == null;
					tuple = ((Vector3, float))0;
					obj16 = (UnityEngine.Object)3;
					if (flag8)
					{
						goto IL_0ae7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ stack_-D8 (UnityEngine.Object)+70]");
					UnityEngine.Object obj20 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ stack_-D8 (UnityEngine.Object)+70]");
					bool flag9 = (nint)0 == 0;
					obj16 = (UnityEngine.Object)3;
					if (!flag9)
					{
						object obj21 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v56+40]");
						obj16 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag10 = ex == null;
						tuple = ((Vector3, float))0;
						num = (float)val3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v56+40]");
						obj22 = (UnityEngine.Object)0;
						if (flag10)
						{
							goto IL_0b53;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v60+18]");
					bool flag11 = (nint)0 == 0;
					tuple = ((Vector3, float))0;
					if (flag11)
					{
						goto IL_0af5;
					}
					object obj23 = obj19 + 32;
					obj23 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ stack_-D8 (UnityEngine.Object)+78]");
					UnityEngine.Object obj24 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ stack_-D8 (UnityEngine.Object)+78]");
					bool flag12 = (nint)0 == 0;
					UnityEngine.Object obj25 = obj20;
					if (!flag12)
					{
						object obj26 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X8_v55+40]");
						obj25 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag13 = ex2 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ stack_-D8 (UnityEngine.Object)+78]");
						obj20 = (UnityEngine.Object)0;
						tuple = ((Vector3, float))0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X8_v55+40]");
						obj16 = (UnityEngine.Object)0;
						if (flag13)
						{
							goto IL_0b11;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v60+18]");
					object obj27 = 0 & 0xFFFFFFFEL;
					bool flag14 = obj27 == null;
					obj20 = obj24;
					tuple = ((Vector3, float))0;
					obj16 = obj25;
					if (flag14)
					{
						goto IL_0ad9;
					}
					object obj28 = obj19 + 40;
					obj28 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ stack_-D8 (UnityEngine.Object)+68]");
					bool flag15 = (nint)0 == 0;
					obj16 = obj24;
					if (!flag15)
					{
						object obj29 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X8_v54+40]");
						obj16 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag16 = ex3 == null;
						obj20 = obj24;
						tuple = ((Vector3, float))0;
						num = (float)val3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X8_v54+40]");
						obj30 = (UnityEngine.Object)0;
						if (flag16)
						{
							goto IL_0b36;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v60+18]");
					bool flag17 = (nint)0 < (nint)2;
					object obj31 = !flag17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v60+18]");
					object obj32 = -2;
					bool flag18 = obj32 == null;
					object obj33 = ~obj31;
					object obj34 = obj33 | flag18;
					obj20 = obj24;
					tuple = ((Vector3, float))0;
					if (obj34 == null)
					{
						object obj35 = obj19 + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ stack_-D8 (UnityEngine.Object)+68]");
						obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v60+18]");
						bool flag19 = (nint)0 < (nint)1;
						obj20 = obj24;
						tuple = ((Vector3, float))0;
						if (flag19)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v60+18]");
						object obj36 = 0 & 0xFFFFFFFFL;
						object obj37 = obj19 + 32;
						object obj38 = 0;
						tuple = ((Vector3, float))0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ stack_-D8 (UnityEngine.Object)+68]");
						Vector3 vector = (Vector3)0;
						object obj43;
						object obj45;
						while (true)
						{
							bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj36);
							object obj39 = !flag20;
							if (obj39 == null)
							{
								object obj40 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X0_v83+E4]");
								bool flag21 = (nint)0 == 0;
								object obj41 = !flag21;
								if (obj41 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X25_v8+v1021 @ X27_v8*8]");
								bool flag22 = (UnityEngine.Object)0 == null;
								bool flag23 = !flag22;
								object obj42 = !flag23;
								obj43 = obj44;
								obj45 = obj46;
								tuple = ((Vector3, float))0;
								System.__Canon _Canon = null;
								if (obj42 == null)
								{
									bool flag24 = (object)others == null;
									tuple = ((Vector3, float))0;
									vector = (Vector3)0;
									if (flag24)
									{
										goto IL_0a99;
									}
									Dictionary<Transform, (Vector3, float)> dictionary = others;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X25_v8+v1021 @ X27_v8*8]");
									object obj48;
									object obj50;
									if (((Dictionary<System.__Canon, (Vector3, float)>)(object)dictionary).TryGetValue((System.__Canon)0, out value))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X25_v8+v1021 @ X27_v8*8]");
										bool flag25 = (nint)0 == 0;
										object obj47 = !flag25;
										obj48 = obj49;
										obj50 = 0;
										val3 = val5;
										if (obj47 == null)
										{
											obj50 = 0;
											tuple = ((Vector3, float))(&value);
											val3 = val5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X25_v8+v1021 @ X27_v8*8]");
											obj16 = (UnityEngine.Object)0;
											goto IL_0abd;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X25_v8+v1021 @ X27_v8*8]");
										bool flag26 = (nint)0 == 0;
										tuple = ((Vector3, float))(&value);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X25_v8+v1021 @ X27_v8*8]");
										vector = (Vector3)0;
										if (flag26)
										{
											goto IL_0aa7;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X25_v8+v1021 @ X27_v8*8]");
										Vector3 position = ((Transform)0).position;
										obj48 = obj46;
										obj50 = obj44;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X25_v8+v1021 @ X27_v8*8]");
									Vector3 position2 = ((Transform)0).position;
									object obj51 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X0_v93+E4]");
									bool flag27 = (nint)0 == 0;
									object obj52 = !flag27;
									if (obj52 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Wake((Vector3)(&val), (Vector3)0, (float)val3, ref *(float*)(&value));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X25_v8+v1021 @ X27_v8*8]");
									Vector3 position3 = ((Transform)0).position;
									vector = (Vector3)obj10;
									(Vector3, float) tuple2 = ((Vector3)obj10, (float)val3);
									bool flag28 = (object)others == null;
									float num2 = num3;
									object obj53 = obj50;
									object obj54 = obj48;
									Enumerator<, > val6 = val;
									obj24 = others;
									tuple = ((Vector3, float))(&value);
									if (flag28)
									{
										goto IL_0a8b;
									}
									tuple = ((Vector3, float))obj11;
									Dictionary<Transform, (Vector3, float)> dictionary2 = others;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X25_v8+v1021 @ X27_v8*8]");
									((Dictionary<System.__Canon, (Vector3, float)>)(object)dictionary2).set_Item((System.__Canon)0, ((Vector3, float))obj11);
									num2 = num3;
									obj53 = obj50;
									obj54 = obj48;
									val6 = val7;
									obj43 = 0;
									obj45 = obj55;
									obj24 = others;
									val3 = (Enumerator<, >)tuple2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X25_v8+v1021 @ X27_v8*8]");
									_Canon = (System.__Canon)0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v60+18]");
								obj36 = 0;
								obj38++;
								object obj56 = obj38;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v60+18]");
								bool flag29 = (nint)obj56 < 0;
								obj44 = obj43;
								obj46 = obj45;
								vector = (Vector3)_Canon;
								if (!flag29)
								{
									break;
								}
								continue;
							}
							IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
							goto IL_0a8b;
							IL_0aa7:
							NullReferenceException ex5 = new NullReferenceException();
							obj16 = (UnityEngine.Object)vector;
							goto IL_0abd;
							IL_0a8b:
							NullReferenceException ex6 = new NullReferenceException();
							goto IL_0a99;
							IL_0abd:
							NullReferenceException ex7 = new NullReferenceException();
							goto IL_0acb;
							IL_0a99:
							NullReferenceException ex8 = new NullReferenceException();
							goto IL_0aa7;
						}
						obj44 = obj43;
						obj46 = obj45;
						obj20 = obj24;
						continue;
					}
					goto IL_0b03;
				}
				obj5 = null;
				val2 = val4;
				object obj57 = 0;
				num3 = (float)val3;
				Enumerator<, > val8 = (Enumerator<, >)(ref val2);
				object obj58 = 0;
				object obj59 = 9;
				nint num4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
					object obj60 = 0;
					num4 = (nint)obj60;
					((Enumerator<, >*)val8)->Dispose();
					bool flag30 = obj58 == null;
					object obj61 = !flag30;
					if (obj61 == null)
					{
						bool flag31 = (object)obj5 == null;
						object obj62 = !flag31;
						OutOfMemoryException ex9 = (OutOfMemoryException)val8;
						if (obj62 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex9 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num4)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj5 = (UnityEngine.Object)1;
						obj58 = obj57;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj58 = obj63;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj57 = obj63;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					obj59 = 0;
				}
				if ((nint)obj59 != 9)
				{
					bool flag32 = obj59 == null;
					object obj64 = !flag32;
					if (obj64 != null)
					{
						return;
					}
				}
				if ((object)others == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A18]");
				object obj65 = 0;
				num4 = (nint)obj65;
				int count = ((Dictionary<System.__Canon, (Vector3, float)>)(object)others).Count;
				if (count > 64)
				{
					if ((object)others == null)
					{
						break;
					}
					((Dictionary<System.__Canon, (Vector3, float)>)(object)others).Clear();
				}
				return;
				IL_0b36:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
				ex = new ArgumentNullException();
				obj22 = null;
				goto IL_0b53;
				IL_0acb:
				NullReferenceException ex10 = new NullReferenceException();
				goto IL_0ad9;
				IL_0ad9:
				IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
				goto IL_0ae7;
				IL_0ae7:
				NullReferenceException ex12 = new NullReferenceException();
				goto IL_0af5;
				IL_0b03:
				ex2 = new IndexOutOfRangeException();
				goto IL_0b11;
				IL_0af5:
				IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
				goto IL_0b03;
				IL_0b11:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
				ex3 = new ArgumentNullException();
				num = (float)val3;
				obj30 = null;
				goto IL_0b36;
				IL_0b53:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
				ArgumentNullException ex14 = new ArgumentNullException();
				obj5 = null;
				val2 = val4;
				obj57 = 0;
				num3 = num;
				val8 = (Enumerator<, >)(ref val2);
				num4 = unchecked((nint)null);
				break;
			}
		}
		throw new NullReferenceException();
	}

	private unsafe void Sinking()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1cb9: Expected Obj, but got I
		//IL_1cdb: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I4
		//IL_1d04: Expected VT, but got I4
		//IL_1d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d17: Expected VT, but got I4
		//IL_00cd: Expected VT, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected VT, but got I4
		//IL_01df: Expected Obj, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected F8, but got I
		//IL_020e: Expected Obj, but got I
		//IL_021e: Expected F4, but got I
		//IL_022e: Expected Obj, but got I
		//IL_0238: Expected VT, but got I4
		//IL_0241: Expected Obj, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got I4
		//IL_09af: Expected Obj, but got I4
		//IL_09bd: Expected Obj, but got I4
		//IL_09c6: Expected Obj, but got I4
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e3: Expected VT, but got Unknown
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Expected Obj, but got I4
		//IL_22a4: Expected Obj, but got I
		//IL_22ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b5: Expected Ref, but got Unknown
		//IL_22cf: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I4
		//IL_0a13: Expected Obj, but got I4
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected Obj, but got Unknown
		//IL_0191: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I4
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_03af: Expected Obj, but got I4
		//IL_03b8: Expected Obj, but got I4
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected VT, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected Obj, but got Unknown
		//IL_0a9e: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected VT, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Expected Obj, but got I
		//IL_0b51: Expected Obj, but got I4
		//IL_0a68: Expected Obj, but got I4
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Expected Obj, but got Unknown
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected Obj, but got Unknown
		//IL_0ad4: Expected Obj, but got I4
		//IL_04cc: Expected Obj, but got I4
		//IL_04d5: Expected Obj, but got I4
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected VT, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected Obj, but got I4
		//IL_0bae: Expected Obj, but got I
		//IL_0bd8: Expected Obj, but got I4
		//IL_0437: Expected Obj, but got I4
		//IL_1d7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d80: Expected Obj, but got Unknown
		//IL_1d9f: Expected Obj, but got I4
		//IL_1da8: Expected Obj, but got I4
		//IL_1db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc5: Expected VT, but got F8
		//IL_1dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd5: Expected Obj, but got I4
		//IL_0c0d: Expected Obj, but got I
		//IL_0c37: Expected Obj, but got I4
		//IL_2061: Expected Obj, but got I
		//IL_052f: Expected Obj, but got I
		//IL_055e: Invalid comparison between F4 and I4
		//IL_0472: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got I4
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected VT, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected Obj, but got I
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ce: Expected Obj, but got I4
		//IL_22fd: Expected Obj, but got I
		//IL_2327: Expected Obj, but got I4
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected Obj, but got Unknown
		//IL_0ca7: Expected Obj, but got I4
		//IL_05b9: Expected Obj, but got I
		//IL_068d: Expected Obj, but got I4
		//IL_0696: Expected Obj, but got I4
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected VT, but got F8
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected Obj, but got I4
		//IL_1e06: Invalid comparison between F8 and I4
		//IL_1e15: Expected F8, but got I4
		//IL_1e1d: Expected VT, but got F8
		//IL_1e54: Expected Obj, but got I4
		//IL_1e5d: Expected Obj, but got I4
		//IL_1e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e82: Expected Obj, but got I4
		//IL_1c3c: Expected Obj, but got I4
		//IL_0d0e: Expected Obj, but got I4
		//IL_0728: Invalid comparison between F4 and I4
		//IL_0737: Expected F8, but got I4
		//IL_073f: Expected VT, but got F4
		//IL_1c9b: Expected Obj, but got I4
		//IL_0d3d: Expected Obj, but got I
		//IL_0d5b: Expected Obj, but got I4
		//IL_07ab: Expected Obj, but got I
		//IL_07cf: Expected Obj, but got I4
		//IL_07dd: Expected Obj, but got I4
		//IL_07e6: Expected Obj, but got I4
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected Obj, but got I4
		//IL_0773: Expected VT, but got F4
		//IL_0d79: Expected Obj, but got I
		//IL_0d89: Expected I, but got Obj
		//IL_0d99: Expected Obj, but got I
		//IL_0da9: Expected Obj, but got I
		//IL_0dcb: Expected Obj, but got I4
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_0840: Expected Obj, but got I
		//IL_0850: Expected F8, but got I
		//IL_1ec6: Expected Obj, but got I
		//IL_1ede: Invalid comparison between F8 and I4
		//IL_1eed: Invalid comparison between F8 and I4
		//IL_1efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f00: Expected Obj, but got Unknown
		//IL_1f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0d: Expected Obj, but got Unknown
		//IL_1f42: Expected Obj, but got I4
		//IL_1f4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4f: Expected Obj, but got Unknown
		//IL_0796: Expected VT, but got F4
		//IL_0e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e96: Expected Obj, but got Unknown
		//IL_0e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea4: Expected Obj, but got Unknown
		//IL_0eb4: Expected Obj, but got I
		//IL_0ebd: Expected Obj, but got I4
		//IL_0ecd: Expected VT, but got I
		//IL_0ee0: Expected Obj, but got I4
		//IL_0ee9: Expected Obj, but got I4
		//IL_0862: Expected VT, but got F8
		//IL_0e1b: Expected I, but got Obj
		//IL_0e2b: Expected Obj, but got I
		//IL_1f76: Expected F8, but got I
		//IL_1fa5: Invalid comparison between F8 and I4
		//IL_1fb4: Invalid comparison between F8 and I4
		//IL_1fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcf: Expected Obj, but got Unknown
		//IL_1fdc: Expected Obj, but got F8
		//IL_2011: Expected Obj, but got I4
		//IL_2019: Unknown result type (might be due to invalid IL or missing references)
		//IL_201e: Expected Obj, but got Unknown
		//IL_1961: Unknown result type (might be due to invalid IL or missing references)
		//IL_1966: Expected Obj, but got Unknown
		//IL_19a2: Expected Obj, but got I4
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a40: Expected Obj, but got Unknown
		//IL_0efe: Expected Obj, but got I
		//IL_0f26: Expected Obj, but got I4
		//IL_2039: Unknown result type (might be due to invalid IL or missing references)
		//IL_203d: Invalid comparison between F8 and Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a75: Expected Obj, but got I
		//IL_1a97: Expected Obj, but got I4
		//IL_1aa4: Expected Obj, but got I4
		//IL_1abc: Expected Obj, but got I
		//IL_0f4e: Expected Obj, but got I
		//IL_0f63: Expected Obj, but got I
		//IL_08b2: Expected Obj, but got I4
		//IL_08bb: Expected Obj, but got I4
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Expected VT, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected Obj, but got I4
		//IL_19e0: Expected Obj, but got I
		//IL_1a04: Expected Obj, but got I4
		//IL_1a1c: Expected Obj, but got I
		//IL_0f8c: Expected Obj, but got I4
		//IL_1af2: Expected Obj, but got I4
		//IL_1b08: Expected Obj, but got I4
		//IL_0906: Expected Obj, but got I
		//IL_092a: Expected Obj, but got I4
		//IL_0938: Expected Obj, but got I4
		//IL_0941: Expected Obj, but got I4
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected VT, but got Unknown
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected Obj, but got I4
		//IL_0fbe: Expected VT, but got I4
		//IL_0fd3: Expected Obj, but got I
		//IL_0fed: Expected Obj, but got I
		//IL_1008: Expected F8, but got VT
		//IL_1021: Expected Obj, but got I4
		//IL_1042: Expected VT, but got F4
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected Obj, but got Unknown
		//IL_09a1: Expected Obj, but got I4
		//IL_21a4: Expected Obj, but got I
		//IL_223e: Expected Obj, but got I
		//IL_225e: Expected F4, but got I
		//IL_226c: Expected Obj, but got I4
		//IL_10a4: Expected F8, but got VT
		//IL_10c5: Expected Obj, but got I4
		//IL_20f4: Expected Obj, but got I
		//IL_2104: Expected Obj, but got I
		//IL_211c: Expected Obj, but got I
		//IL_212c: Expected F8, but got I
		//IL_213c: Expected Obj, but got I
		//IL_215e: Expected Obj, but got I4
		//IL_10fd: Expected VT, but got I8
		//IL_10fd: Expected VT, but got Ref
		//IL_1131: Expected Obj, but got I
		//IL_1159: Expected VT, but got F8
		//IL_116f: Expected Obj, but got I8
		//IL_11ba: Expected Obj, but got I
		//IL_11eb: Expected Obj, but got I4
		//IL_11f4: Expected VT, but got F8
		//IL_1220: Expected Obj, but got I
		//IL_1242: Expected Obj, but got I
		//IL_1264: Expected Obj, but got I4
		//IL_12a9: Expected Obj, but got I4
		//IL_12ca: Expected Obj, but got I
		//IL_12f2: Expected VT, but got F8
		//IL_1342: Expected Obj, but got I
		//IL_1373: Expected Obj, but got I4
		//IL_137c: Expected VT, but got F8
		//IL_13ac: Expected Obj, but got I
		//IL_13c2: Expected Obj, but got I
		//IL_13dc: Expected Obj, but got I4
		//IL_1414: Expected Obj, but got I
		//IL_143c: Expected VT, but got F8
		//IL_148c: Expected Obj, but got I
		//IL_14bd: Expected Obj, but got I4
		//IL_14c6: Expected VT, but got F8
		//IL_1503: Expected Obj, but got I
		//IL_1532: Invalid comparison between F4 and I4
		//IL_1543: Expected Obj, but got I4
		//IL_154c: Invalid comparison between F4 and I4
		//IL_1573: Expected Obj, but got I
		//IL_1593: Unknown result type (might be due to invalid IL or missing references)
		//IL_159b: Expected VT, but got Unknown
		//IL_15a3: Expected VT, but got F4
		//IL_15bb: Expected Obj, but got I
		//IL_1616: Expected Obj, but got I
		//IL_1636: Unknown result type (might be due to invalid IL or missing references)
		//IL_163e: Expected VT, but got Unknown
		//IL_164f: Expected Obj, but got I4
		//IL_1658: Expected VT, but got F4
		//IL_1670: Expected Obj, but got I
		//IL_168e: Expected Obj, but got I
		//IL_16b7: Expected Obj, but got I4
		//IL_16d8: Expected Obj, but got I
		//IL_16f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1700: Expected VT, but got Unknown
		//IL_1709: Expected Obj, but got I4
		//IL_1712: Expected VT, but got F4
		//IL_172a: Expected Obj, but got I
		//IL_174a: Unknown result type (might be due to invalid IL or missing references)
		//IL_174f: Expected Obj, but got Unknown
		//IL_1758: Unknown result type (might be due to invalid IL or missing references)
		//IL_175d: Expected Obj, but got Unknown
		//IL_1765: Expected F8, but got Obj
		//IL_176d: Invalid comparison between F4 and Obj
		//IL_1794: Expected Obj, but got I
		//IL_17ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b4: Expected VT, but got Unknown
		//IL_17bc: Expected VT, but got F4
		//IL_17d4: Expected Obj, but got I
		//IL_17fb: Expected Obj, but got I
		//IL_1824: Expected Obj, but got I4
		//IL_1845: Expected Obj, but got I
		//IL_185d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1865: Expected VT, but got Unknown
		//IL_186e: Expected Obj, but got I4
		//IL_1877: Expected VT, but got F4
		//IL_188f: Expected Obj, but got I
		//IL_18b9: Expected Obj, but got F4
		//IL_18d2: Expected VT, but got Ref
		//IL_18dc: Expected VT, but got I4
		//IL_18fd: Expected Obj, but got I
		//IL_1922: Unknown result type (might be due to invalid IL or missing references)
		//IL_192a: Expected VT, but got Unknown
		//IL_1933: Expected VT, but got I4
		//IL_1953: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashGame current = GillaSplashGame.Current;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v4+E4]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)current != (UnityEngine.Object)null;
		bool flag4 = !flag3;
		UnityEngine.Object obj8 = null;
		Enumerator<, > val;
		NetworkArray<float> networkArray;
		RaycastHit raycastHit;
		object obj10;
		Component component;
		ref RaycastHit reference;
		if (!flag4)
		{
			bool flag5 = (object)current == null;
			networkArray = (NetworkArray<float>)0;
			val = (Enumerator<, >)0;
			raycastHit = (RaycastHit)0;
			reference = ref *(RaycastHit*)null;
			obj8 = null;
			if (flag5)
			{
				goto IL_1b30;
			}
			bool live = current.Live;
			bool flag6 = !live;
			obj8 = null;
			if (!flag6)
			{
				NetworkBool sinking = current.Sinking;
				bool flag7 = sinking;
				bool flag8 = !flag7;
				obj8 = null;
				if (!flag8)
				{
					byte phase = current.Phase;
					int num = phase & 0xFF;
					object obj9 = num - 2;
					bool flag9 = obj9 == null;
					component = (Component)flag9;
					obj10 = 0;
					obj8 = null;
					goto IL_1ce9;
				}
			}
		}
		component = null;
		obj10 = 1;
		goto IL_1ce9;
		IL_1ce9:
		bool flag10 = (object)sinkers == null;
		networkArray = (NetworkArray<float>)0;
		val = (Enumerator<, >)0;
		raycastHit = (RaycastHit)0;
		reference = ref *(RaycastHit*)null;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A40]");
			object obj11 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)sinkers).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			double num2 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB24]");
			float num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			object obj13 = 0;
			networkArray = (NetworkArray<float>)0;
			object obj14 = 0;
			Transform transform = null;
			Enumerator<, > val3 = default;
			Enumerator<, > val2 = val3;
			reference = ref *(RaycastHit*)null;
			obj6 = 17276928;
			NetworkArray<float> networkArray2 = default;
			NetworkArray<float> networkArray3 = default;
			RaycastHit raycastHit3 = default;
			QueryTriggerInteraction queryTriggerInteraction = default;
			UnityEngine.Object obj82 = default;
			double num18 = default;
			double num14 = default;
			RaycastHit raycastHit4 = default;
			object obj88 = default;
			UnityEngine.Object obj17 = default;
			while (true)
			{
				UnityEngine.Object obj20;
				object obj22;
				Enumerator<, > val4;
				object obj21;
				double num4;
				if (val.MoveNext())
				{
					object obj15 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X0_v98+E4]");
					bool flag11 = (nint)0 == 0;
					object obj16 = !flag11;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag12 = obj17 == null;
					bool flag13 = !flag12;
					object obj18 = !flag13;
					reference = ref *(RaycastHit*)null;
					if (obj18 != null)
					{
						continue;
					}
					object obj19 = obj10 & 1;
					int num6;
					double num5;
					if (obj19 != null)
					{
						bool flag14 = (object)obj17 == null;
						obj20 = null;
						obj21 = 109891584;
						obj22 = 0;
						num4 = 1.0;
						val = val3;
						raycastHit = (RaycastHit)val2;
						val4 = (Enumerator<, >)(ref val);
						reference = ref *(RaycastHit*)null;
						obj8 = null;
						if (flag14)
						{
							goto IL_1b6e;
						}
						num5 = -1.0;
						reference = ref *(RaycastHit*)null;
						num6 = 2;
					}
					else
					{
						bool flag15 = (object)obj17 == null;
						obj20 = null;
						obj21 = 109891584;
						obj22 = 0;
						num4 = 1.0;
						val = val3;
						raycastHit = (RaycastHit)val2;
						val4 = (Enumerator<, >)(ref val);
						reference = ref *(RaycastHit*)null;
						obj8 = null;
						if (flag15)
						{
							goto IL_1b7c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ stack_-118_v16 (UnityEngine.Object)+20]");
						if ((nint)0 > (nint)127)
						{
							bool flag16 = (object)current == null;
							object obj23 = !flag16;
							num5 = -1.0;
							reference = ref *(RaycastHit*)null;
							if (obj23 == null)
							{
								num5 = -1.0;
								obj20 = null;
								obj21 = 109891584;
								obj22 = 0;
								num4 = 1.0;
								val = val3;
								raycastHit = (RaycastHit)val2;
								val4 = (Enumerator<, >)(ref val);
								reference = ref *(RaycastHit*)null;
								obj8 = null;
								goto IL_1bb4;
							}
						}
						else
						{
							bool flag17 = (object)current == null;
							obj20 = null;
							obj21 = 109891584;
							obj22 = 0;
							num4 = 1.0;
							val = val3;
							raycastHit = (RaycastHit)val2;
							val4 = (Enumerator<, >)(ref val);
							reference = ref *(RaycastHit*)null;
							obj8 = null;
							if (flag17)
							{
								goto IL_1ba6;
							}
							NetworkArray<float> sinkAt = current.SinkAt;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5568]");
							obj6 = 0;
							reference = ref *(RaycastHit*)obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ stack_-118_v16 (UnityEngine.Object)+20]");
							float num7 = networkArray.get_Item(0);
							bool flag18 = !(num7 > 0f);
							networkArray = networkArray2;
							num5 = -1.0;
							if (!flag18)
							{
								float now = current.Now;
								NetworkArray<float> sinkAt2 = current.SinkAt;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5568]");
								obj6 = 0;
								reference = ref *(RaycastHit*)obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ stack_-118_v16 (UnityEngine.Object)+20]");
								float num8 = networkArray.get_Item(0);
								num5 = (double)now - (double)num8;
								networkArray = networkArray3;
							}
						}
						int round = current.Round;
						num6 = round;
					}
					bool flag19 = ((GillaSinkPlatform)obj17).Show((float)num5, num6);
					float[] array = sunk;
					obj14 |= flag19;
					bool flag20 = sunk == null;
					obj20 = null;
					obj21 = 109891584;
					obj22 = 0;
					num4 = 1.0;
					val = val3;
					raycastHit = (RaycastHit)num5;
					val4 = (Enumerator<, >)(ref val);
					obj8 = (UnityEngine.Object)num6;
					if (flag20)
					{
						goto IL_1b60;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ stack_-118_v16 (UnityEngine.Object)+20]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ stack_-118_v16 (UnityEngine.Object)+20]");
					bool flag21 = (nint)0 >= (nint)array.Length;
					val2 = (Enumerator<, >)num5;
					if (flag21)
					{
						continue;
					}
					object obj24 = obj10 & 1;
					int num9;
					if (obj24 != null)
					{
						num9 = 2;
					}
					else
					{
						bool flag22 = (object)current == null;
						obj20 = null;
						obj21 = 109891584;
						obj22 = 0;
						num4 = 1.0;
						val = val3;
						raycastHit = (RaycastHit)num5;
						val4 = (Enumerator<, >)(ref val);
						obj8 = (UnityEngine.Object)num6;
						if (flag22)
						{
							goto IL_1bc2;
						}
						int round2 = current.Round;
						num9 = round2;
					}
					bool flag23 = num5 < 0.0;
					double num10 = 0.0;
					raycastHit = (RaycastHit)num5;
					if (!flag23)
					{
						(float, float) tuple = GillaSinkPlatform.At((float)num5, 0, num9);
						float num11 = (float)num5 + num3;
						float num12 = num11 / (float)obj13;
						bool flag24 = num12 < 0f;
						num10 = 0.0;
						raycastHit = (RaycastHit)num12;
						if (!flag24)
						{
							bool flag25 = !((double)num12 > 1.0);
							num10 = num12;
							raycastHit = (RaycastHit)num12;
							if (!flag25)
							{
								num10 = 1.0;
								raycastHit = (RaycastHit)num12;
							}
						}
					}
					float[] array2 = sunk;
					bool flag26 = sunk == null;
					obj20 = null;
					obj21 = 109891584;
					obj22 = 0;
					num4 = 1.0;
					val = val3;
					val4 = (Enumerator<, >)(ref val);
					obj8 = (UnityEngine.Object)num9;
					if (flag26)
					{
						goto IL_1b8a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ stack_-118_v16 (UnityEngine.Object)+20]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ stack_-118_v16 (UnityEngine.Object)+20]");
					bool flag27 = (nint)0 < (nint)array2.Length;
					object obj25 = !flag27;
					obj20 = null;
					obj21 = 109891584;
					obj22 = 0;
					num4 = 1.0;
					val = val3;
					val4 = (Enumerator<, >)(ref val);
					obj8 = (UnityEngine.Object)num9;
					if (obj25 != null)
					{
						goto IL_1b98;
					}
					float[] array3 = sunk;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ stack_-118_v16 (UnityEngine.Object)+20]");
					object obj26 = array3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDCA8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1900 @ X8_v71+20]");
					num5 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					object obj27 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X8_v73+A0]");
					object obj28 = 0;
					double num13 = (double)raycastHit - num14;
					bool flag28 = num13 < 0.0;
					bool flag29 = num13 == 0.0;
					object obj29 = raycastHit ^ num14;
					object obj30 = raycastHit ^ num13;
					object obj31 = obj29 & obj30;
					bool flag30 = (nint)obj31 < 0;
					bool flag31 = flag28 == flag30;
					object obj32 = !flag29;
					object obj33 = flag31 & obj32;
					object obj34 = ~obj33;
					if (obj34 != null)
					{
						raycastHit = (RaycastHit)num14;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v74+4]");
					num14 = 0.0;
					double num15 = (double)raycastHit * num2;
					double num16 = num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v74+4]");
					double num17 = num16 - 0.0;
					bool flag32 = num17 < 0.0;
					bool flag33 = num17 == 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v74+4]");
					object obj35 = num15 ^ 0;
					object obj36 = num15 ^ num17;
					object obj37 = obj35 & obj36;
					bool flag34 = (nint)obj37 < 0;
					bool flag35 = flag32 == flag34;
					object obj38 = !flag33;
					object obj39 = flag35 & obj38;
					object obj40 = ~obj39;
					if (obj40 == null)
					{
						val2 = (Enumerator<, >)num15;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v74+4]");
						val2 = (Enumerator<, >)0;
					}
					if (num18 < (double)val2)
					{
						continue;
					}
					float[] array4 = sunk;
					bool flag36 = sunk == null;
					obj20 = null;
					obj21 = 109891584;
					obj22 = 0;
					num4 = 1.0;
					val = val3;
					raycastHit = (RaycastHit)val2;
					val4 = (Enumerator<, >)(ref val);
					obj8 = (UnityEngine.Object)num9;
					if (flag36)
					{
						goto IL_1bde;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ stack_-118_v16 (UnityEngine.Object)+20]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ stack_-118_v16 (UnityEngine.Object)+20]");
					bool flag37 = (nint)0 < (nint)array4.Length;
					object obj41 = !flag37;
					obj20 = null;
					obj21 = 109891584;
					obj22 = 0;
					num4 = 1.0;
					val = val3;
					raycastHit = (RaycastHit)val2;
					val4 = (Enumerator<, >)(ref val);
					obj8 = (UnityEngine.Object)num9;
					if (obj41 == null)
					{
						float[] array5 = sunk;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ stack_-118_v16 (UnityEngine.Object)+20]");
						object obj42 = array5 + 0;
						transform = (Transform)1;
						continue;
					}
					goto IL_1bec;
				}
				object obj43 = 13;
				obj20 = null;
				obj21 = 109891584;
				obj22 = 0;
				num4 = 1.0;
				val = val3;
				raycastHit = (RaycastHit)val2;
				val4 = (Enumerator<, >)(ref val);
				object obj44 = 0;
				goto IL_2294;
				IL_1ba6:
				NullReferenceException ex = new NullReferenceException();
				goto IL_1bb4;
				IL_0ae2:
				bool flag38 = (object)component == null;
				object obj45 = !flag38;
				float[] array6 = (float[])(object)obj8;
				if (obj45 == null)
				{
					return;
				}
				goto IL_0bfd;
				IL_1b7c:
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_1b8a;
				IL_0bfd:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
				object obj46 = 0;
				object obj47 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1779 @ X0_v13+E4]");
				bool flag39 = (nint)0 == 0;
				object obj48 = !flag39;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj49 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ X0_v17+E4]");
				bool flag40 = (nint)0 == 0;
				object obj50 = !flag40;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj49 = obj46;
				}
				object obj51 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ X0_v17+A0]");
				obj6 = 0;
				UnityEngine.Object obj52 = (UnityEngine.Object)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v15+E4]");
				bool flag41 = (nint)0 == 0;
				object obj53 = !flag41;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag42 = (UnityEngine.Object)obj6 == null;
				bool flag43 = !flag42;
				object obj54 = !flag43;
				if (obj54 != null)
				{
					return;
				}
				bool flag44 = obj6 == null;
				obj17 = obj20;
				reference = ref *(RaycastHit*)null;
				obj8 = null;
				if (flag44)
				{
					break;
				}
				object obj55 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1920 @ X0_v21+E4]");
				bool flag45 = (nint)0 == 0;
				object obj56 = !flag45;
				if (obj56 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+28]");
				bool flag46 = (UnityEngine.Object)0 == null;
				bool flag47 = !flag46;
				object obj57 = !flag47;
				if (obj57 != null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
				component = (Component)0;
				object obj58 = obj3;
				nint num19 = (nint)component;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1945 @ X0_v25+E4]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1946 @ X8_v17 (Il2CppClass<UnityEngine.Component>)+A0]");
				object obj59 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1945 @ X0_v25+E4]");
				bool flag48 = (nint)0 == 0;
				object obj60 = !flag48;
				if (obj60 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)obj59 != null)
				{
					nint num20 = (nint)component;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1957 @ X8_v47 (Il2CppClass<UnityEngine.Component>)+A0]");
					object obj61 = 0;
					object obj62 = obj61;
					bool flag49 = obj61 == null;
					obj17 = obj20;
					reference = ref *(RaycastHit*)null;
					obj8 = null;
					if (flag49)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v49+A9]");
					if ((nint)0 != 0)
					{
						return;
					}
				}
				UnityEngine.Object obj63 = (UnityEngine.Object)(obj6 + 56);
				UnityEngine.Object obj64 = (UnityEngine.Object)(obj6 + 48);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj65 = 0;
				obj21 = 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				RaycastHit raycastHit2 = (RaycastHit)0;
				reference = ref *(RaycastHit*)null;
				obj8 = null;
				obj6 = 17276928;
				UnityEngine.Object obj66 = (UnityEngine.Object)17276928;
				while (true)
				{
					double num5;
					object obj74;
					if ((nint)obj21 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+28]");
						component = (Component)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+28]");
						bool flag50 = (nint)0 == 0;
						obj17 = obj20;
						obj14 = 109891584;
						raycastHit = raycastHit2;
						if (flag50)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+28]");
						Transform transform2 = ((Component)0).transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+28]");
						Vector3 center = ((CapsuleCollider)0).center;
						bool flag51 = (object)transform2 == null;
						obj17 = obj20;
						obj14 = 109891584;
						transform = transform2;
						raycastHit = raycastHit2;
						obj8 = null;
						if (flag51)
						{
							break;
						}
						Vector3 vector = transform2.TransformPoint((Vector3)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+28]");
						float height = ((CapsuleCollider)0).height;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+28]");
						Transform transform3 = ((Component)0).transform;
						bool flag52 = (object)transform3 == null;
						num5 = (double)raycastHit2;
						obj17 = obj20;
						num4 = num18;
						obj14 = 109891584;
						transform = transform2;
						num3 = height;
						num2 = num14;
						raycastHit = (RaycastHit)height;
						obj8 = null;
						if (flag52)
						{
							break;
						}
						Vector3 lossyScale = transform3.lossyScale;
						float num21 = height * 0.5f;
						float num22 = num21 * (float)num14;
						float num23 = num22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
						num3 = num23 + 0f;
						num5 = (double)raycastHit2;
						num4 = num18;
						transform = transform2;
						num2 = num14;
						object obj67 = 0;
					}
					else
					{
						object obj68 = obj21 - 3;
						bool flag53 = obj68 == null;
						bool flag54 = ((Player)obj6).IsHandTouching(flag53);
						bool flag55 = !flag54;
						reference = ref *(RaycastHit*)null;
						obj8 = (UnityEngine.Object)flag53;
						if (flag55)
						{
							goto IL_1a32;
						}
						object obj69;
						UnityEngine.Object obj70;
						if ((nint)obj21 == 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+FB]");
							obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+FB]");
							bool flag56 = (nint)0 == 0;
							reference = ref *(RaycastHit*)null;
							obj8 = (UnityEngine.Object)flag53;
							obj66 = obj64;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+FB]");
							obj69 = 0;
							obj70 = obj64;
							if (!flag56)
							{
								goto IL_1a32;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+FC]");
							obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+FC]");
							bool flag57 = (nint)0 == 0;
							object obj71 = !flag57;
							reference = ref *(RaycastHit*)null;
							obj8 = (UnityEngine.Object)flag53;
							obj66 = obj63;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X21_v8 (UnityEngine.Object)+FC]");
							obj69 = 0;
							obj70 = obj63;
							if (obj71 != null)
							{
								goto IL_1a32;
							}
						}
						bool flag58 = (object)obj70 == null;
						obj17 = obj20;
						obj14 = 109891584;
						raycastHit = raycastHit2;
						reference = ref *(RaycastHit*)null;
						obj8 = (UnityEngine.Object)flag53;
						obj6 = obj69;
						if (flag58)
						{
							break;
						}
						Vector3 position = ((Transform)obj70).position;
						object obj72 = obj65;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2060 @ X8_v42+A0]");
						object obj73 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2063 @ X8_v43+20]");
						double num24 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
						double num25 = num24 * 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2063 @ X8_v43+18]");
						float num26 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
						float num22 = num26 * 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2063 @ X8_v43+1C]");
						double num27 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
						double num28 = num27 * 0.0;
						num4 = num18 + num25;
						num5 = (double)raycastHit2 + (double)num22;
						num2 = num14 + num28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
						obj74 = 0;
						num18 = num25;
						num14 = num28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						num3 = 0f;
						reference = ref *(RaycastHit*)null;
						object obj67 = 0;
					}
					object obj75 = obj65;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
					object obj76 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2097 @ X8_v26+A0]");
					obj66 = (UnityEngine.Object)0;
					object obj77 = obj76;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+24]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+28]");
					double num10 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2100 @ X0_v32+E4]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2100 @ X0_v32+E4]");
					bool flag59 = (nint)0 == 0;
					object obj78 = !flag59;
					if (obj78 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag60 = Physics.Raycast((Vector3)(&raycastHit3), (Vector3)4294961407L, out *(RaycastHit*)1, (float)num5, 0, queryTriggerInteraction);
					bool flag61 = !flag60;
					int num29 = 0;
					float num30 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+2C]");
					object obj79 = 0;
					double num31 = num10;
					obj74 = obj13;
					num18 = num4;
					num14 = num2;
					raycastHit2 = (RaycastHit)num5;
					reference = ref *(RaycastHit*)1;
					obj8 = (UnityEngine.Object)4294961407L;
					if (!flag61)
					{
						Collider collider = raycastHit3.collider;
						bool flag62 = (object)collider == null;
						num29 = 0;
						num30 = num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+2C]");
						obj79 = 0;
						num31 = num10;
						obj74 = obj13;
						num18 = num4;
						num14 = num2;
						obj17 = obj20;
						obj14 = 109891584;
						raycastHit = (RaycastHit)num5;
						reference = ref *(RaycastHit*)1;
						obj8 = null;
						if (flag62)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A30]");
						object obj80 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
						obj66 = (UnityEngine.Object)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+E4]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+E4]");
						bool flag63 = (nint)0 == 0;
						object obj81 = !flag63;
						if (obj81 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag64 = obj82 == null;
						bool flag65 = !flag64;
						object obj83 = !flag65;
						num29 = 0;
						num30 = num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+2C]");
						obj79 = 0;
						num31 = num10;
						obj74 = obj13;
						num18 = num4;
						num14 = num2;
						raycastHit2 = (RaycastHit)num5;
						component = (Component)obj82;
						reference = ref *(RaycastHit*)null;
						obj8 = null;
						if (obj83 == null)
						{
							bool flag66 = (object)obj82 == null;
							num29 = 0;
							num30 = num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+2C]");
							obj79 = 0;
							num31 = num10;
							obj74 = obj13;
							num18 = num4;
							num14 = num2;
							obj17 = obj20;
							obj14 = 109891584;
							raycastHit = (RaycastHit)num5;
							component = (Component)obj82;
							reference = ref *(RaycastHit*)null;
							obj8 = null;
							if (flag66)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
							obj66 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
							object obj84 = -127;
							bool flag67 = obj84 == null;
							object obj38 = !flag67;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
							bool flag68 = (nint)0 > (nint)127;
							num29 = 0;
							num30 = num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+2C]");
							obj79 = 0;
							num31 = num10;
							obj74 = obj13;
							num18 = num4;
							num14 = num2;
							raycastHit2 = (RaycastHit)num5;
							component = (Component)obj82;
							reference = ref *(RaycastHit*)null;
							obj8 = null;
							if (!flag68)
							{
								bool flag69 = (object)current == null;
								num29 = 0;
								num30 = num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+2C]");
								obj79 = 0;
								num31 = num10;
								obj74 = obj13;
								num18 = num4;
								num14 = num2;
								obj17 = obj20;
								obj14 = 109891584;
								raycastHit = (RaycastHit)num5;
								component = (Component)obj82;
								reference = ref *(RaycastHit*)null;
								obj8 = null;
								if (flag69)
								{
									break;
								}
								NetworkArray<float> sinkAt3 = current.SinkAt;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5568]");
								obj6 = 0;
								reference = ref *(RaycastHit*)obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
								float num32 = networkArray.get_Item(0);
								bool flag70 = num32 == 0f;
								obj38 = !flag70;
								bool flag71 = num32 > 0f;
								num29 = 0;
								num30 = num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+2C]");
								obj79 = 0;
								num31 = num10;
								obj74 = obj13;
								num18 = num4;
								num14 = num2;
								networkArray = (NetworkArray<float>)val4;
								raycastHit2 = (RaycastHit)num32;
								component = (Component)obj82;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
								obj8 = (UnityEngine.Object)0;
								obj66 = obj20;
								if (!flag71)
								{
									float time = Time.time;
									transform = (Transform)(object)asked;
									bool flag72 = asked == null;
									num29 = 0;
									num30 = num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ stack_-118_v1 (UnityEngine.Object)+2C]");
									obj79 = 0;
									num31 = num10;
									obj74 = obj13;
									num18 = num4;
									num14 = num2;
									networkArray = (NetworkArray<float>)val4;
									obj17 = obj20;
									obj14 = 109891584;
									raycastHit = (RaycastHit)time;
									component = (Component)obj82;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
									obj8 = (UnityEngine.Object)0;
									if (flag72)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X24_v5 (UnityEngine.Transform)+18]");
									obj66 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
									nint num33 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X24_v5 (UnityEngine.Transform)+18]");
									bool flag73 = num33 < 0;
									object obj85 = !flag73;
									num29 = 0;
									num30 = num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+2C]");
									obj79 = 0;
									num31 = num10;
									obj74 = obj13;
									num18 = num4;
									num14 = num2;
									networkArray = (NetworkArray<float>)val4;
									obj14 = 109891584;
									raycastHit = (RaycastHit)time;
									component = (Component)obj82;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
									obj8 = (UnityEngine.Object)0;
									if (obj85 != null)
									{
										goto IL_1bd0;
									}
									float[] array7 = asked;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
									object obj86 = array7 + 0;
									obj10 = obj86 + 32;
									num14 = (double)obj10;
									bool flag74 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)time) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
									num29 = 0;
									num30 = num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+2C]");
									obj79 = 0;
									num31 = num10;
									obj74 = obj13;
									num18 = num4;
									networkArray = (NetworkArray<float>)val4;
									raycastHit2 = (RaycastHit)time;
									component = (Component)obj82;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
									obj8 = (UnityEngine.Object)0;
									if (!flag74)
									{
										float time2 = Time.time;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X24_v5 (UnityEngine.Transform)+18]");
										obj66 = (UnityEngine.Object)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
										nint num34 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X24_v5 (UnityEngine.Transform)+18]");
										bool flag75 = num34 < 0;
										object obj87 = !flag75;
										num29 = 0;
										num30 = num3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+2C]");
										obj79 = 0;
										num31 = num10;
										obj74 = obj13;
										num18 = num4;
										networkArray = (NetworkArray<float>)val4;
										obj14 = 109891584;
										raycastHit = (RaycastHit)time2;
										component = (Component)obj82;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
										obj8 = (UnityEngine.Object)0;
										if (obj87 != null)
										{
											goto IL_1bd0;
										}
										float num35 = time2 + 0.5f;
										obj10 = num35;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
										current.RPC_Stood(0, (RpcInfo)(&raycastHit4));
										raycastHit4 = (RaycastHit)0;
										num29 = 0;
										num30 = num3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ X8_v37 (UnityEngine.Object)+2C]");
										obj79 = 0;
										num31 = num10;
										obj74 = obj13;
										num18 = num4;
										num14 = 0.5;
										networkArray = (NetworkArray<float>)val4;
										raycastHit2 = (RaycastHit)0;
										component = (Component)obj82;
										reference = ref raycastHit4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ X0_v38 (UnityEngine.Object)+20]");
										obj8 = (UnityEngine.Object)0;
									}
								}
							}
						}
					}
					goto IL_1a32;
					IL_1a32:
					obj21--;
					if ((nint)obj21 == 1)
					{
						return;
					}
				}
				break;
				IL_1bb4:
				NullReferenceException ex3 = new NullReferenceException();
				goto IL_1bc2;
				IL_1bc2:
				NullReferenceException ex4 = new NullReferenceException();
				goto IL_1bd0;
				IL_1bd0:
				IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
				goto IL_1bde;
				IL_1bec:
				IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
				if ((nint)obj8 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj20 = (UnityEngine.Object)1;
					obj44 = obj22;
				}
				else
				{
					if ((nint)obj8 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E350");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj44 = obj88;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj22 = obj88;
				}
				obj43 = 0;
				goto IL_2294;
				IL_1bde:
				NullReferenceException ex7 = new NullReferenceException();
				goto IL_1bec;
				IL_1b98:
				IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
				goto IL_1ba6;
				IL_1b6e:
				NullReferenceException ex9 = new NullReferenceException();
				goto IL_1b7c;
				IL_1b8a:
				NullReferenceException ex10 = new NullReferenceException();
				goto IL_1b98;
				IL_1b60:
				NullReferenceException ex11 = new NullReferenceException();
				goto IL_1b6e;
				IL_2294:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A38]");
				object obj89 = 0;
				obj8 = (UnityEngine.Object)obj89;
				((Enumerator<, >*)val4)->Dispose();
				bool flag76 = obj44 == null;
				object obj90 = !flag76;
				obj17 = obj20;
				if (obj90 == null)
				{
					bool flag77 = (object)obj20 == null;
					object obj91 = !flag77;
					obj17 = obj20;
					OutOfMemoryException ex12 = (OutOfMemoryException)val4;
					if (obj91 == null)
					{
						if ((nint)obj43 != 13)
						{
							bool flag78 = obj43 == null;
							object obj92 = !flag78;
							if (obj92 != null)
							{
								return;
							}
						}
						object obj93 = obj14 & 1;
						bool flag79 = obj93 == null;
						object obj94 = !flag79;
						if (obj94 == null)
						{
							object obj95 = transform & 1;
							bool flag80 = obj95 == null;
							object obj96 = !flag80;
							if (obj96 == null)
							{
								goto IL_0ae2;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
							object obj97 = 0;
							object obj98 = obj97;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1567 @ X0_v87+E4]");
							bool flag81 = (nint)0 == 0;
							object obj99 = !flag81;
							if (obj99 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Physics.SyncTransforms();
							object obj100 = transform & 1;
							if (obj100 == null)
							{
								goto IL_0ae2;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
						object obj101 = 0;
						object obj102 = obj101;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1784 @ X0_v83+E4]");
						bool flag82 = (nint)0 == 0;
						object obj103 = !flag82;
						if (obj103 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj102 = obj101;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1784 @ X0_v83+A0]");
						object obj104 = 0;
						array6 = sunk;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1537 @ X8_v54+8]");
						Shader.SetGlobalFloatArray(0, sunk);
						bool flag83 = (object)component == null;
						reference = ref *(RaycastHit*)null;
						if (flag83)
						{
							return;
						}
						goto IL_0bfd;
					}
				}
				else
				{
					OutOfMemoryException ex12 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				obj20 = obj17;
				goto IL_1b60;
			}
		}
		goto IL_1b30;
		IL_1b30:
		throw new NullReferenceException();
	}

	private void Spawning()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b9b: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_0bd3: Expected Obj, but got I4
		//IL_0c85: Expected Obj, but got I
		//IL_0ca7: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I
		//IL_0c0b: Expected Obj, but got I4
		//IL_034d: Expected Obj, but got I4
		//IL_037c: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_0490: Expected Obj, but got I4
		//IL_04bf: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I4
		//IL_0233: Expected Obj, but got I4
		//IL_050f: Expected F8, but got I4
		//IL_0530: Expected Obj, but got I4
		//IL_055b: Expected I4, but got I8
		//IL_0575: Expected Obj, but got I
		//IL_059d: Expected Obj, but got I
		//IL_05c7: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I
		//IL_067f: Expected Obj, but got I
		//IL_068f: Expected Obj, but got I
		//IL_069f: Expected Obj, but got I
		//IL_06b3: Expected Obj, but got I8
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected Obj, but got Unknown
		//IL_06cc: Expected Obj, but got I4
		//IL_0c4e: Expected Obj, but got I4
		//IL_06e9: Expected Obj, but got I
		//IL_070b: Expected Obj, but got I4
		//IL_073a: Expected Obj, but got I
		//IL_0758: Expected Obj, but got I4
		//IL_0b2f: Expected Obj, but got I4
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected Obj, but got Unknown
		//IL_07b9: Expected Obj, but got I
		//IL_07db: Expected Obj, but got I4
		//IL_0820: Expected Obj, but got I4
		//IL_087a: Expected Obj, but got I
		//IL_08b4: Expected Obj, but got I
		//IL_08e2: Expected Obj, but got I4
		//IL_09a0: Expected I4, but got Obj
		//IL_0a02: Expected Obj, but got I4
		//IL_0abb: Expected Obj, but got I
		//IL_0acb: Expected Obj, but got I
		//IL_0a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Expected Obj, but got Unknown
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = monsterPrefab == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj5;
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v11+A0]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v4 (System.Int32)+8]");
		UnityEngine.Object obj11 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v4 (System.Int32)+8]");
		bool flag7 = (UnityEngine.Object)0 != null;
		bool flag8 = !flag7;
		UnityEngine.Object obj13 = null;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v4 (System.Int32)+8]");
			if ((nint)0 == 0)
			{
				goto IL_0b5c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X20_v7 (UnityEngine.Object)+B0]");
			obj13 = (UnityEngine.Object)0;
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v15+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = obj13 != null;
		bool flag11 = !flag10;
		UnityEngine.Object obj16 = null;
		if (flag11)
		{
			goto IL_0323;
		}
		if ((object)obj13 != null)
		{
			bool isRunning = ((NetworkRunner)obj13).IsRunning;
			bool flag12 = !isRunning;
			obj16 = null;
			if (flag12)
			{
				goto IL_0323;
			}
			offlineFor = 0f;
			ClearLocal();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v4 (System.Int32)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X20_v7 (UnityEngine.Object)+A4]");
				bool flag13 = (nint)0 == 0;
				object obj17 = !flag13;
				if (obj17 != null)
				{
					return;
				}
				float unscaledTime = Time.unscaledTime;
				if (unscaledTime < nextCheck)
				{
					return;
				}
				float unscaledTime2 = Time.unscaledTime;
				float num2 = unscaledTime2 + 2f;
				nextCheck = num2;
				if (!((NetworkRunner)obj13).IsSharedModeMasterClient)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v4 (System.Int32)+8]");
				if (((NetworkBootstrap)0).Settled)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X20_v7 (UnityEngine.Object)+90]");
					if ((nint)0 == 2)
					{
						MakeMissing((NetworkRunner)obj13);
					}
				}
				return;
			}
		}
		goto IL_0b5c;
		IL_0b5c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b6a;
		IL_0323:
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v20+E4]");
		bool flag14 = (nint)0 == 0;
		object obj19 = !flag14;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v4 (System.Int32)+8]");
		if ((UnityEngine.Object)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v4 (System.Int32)+8]");
			if ((nint)0 == 0)
			{
				goto IL_0b5c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X20_v7 (UnityEngine.Object)+A4]");
			if ((nint)0 != 0)
			{
				offlineFor = 0f;
				return;
			}
		}
		float deltaTime = Time.deltaTime;
		float num3 = offlineFor + deltaTime;
		List<GameObject> list = local;
		offlineFor = num3;
		if ((object)local != null)
		{
			if (list._size > 0)
			{
				return;
			}
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X0_v25+E4]");
			bool flag15 = (nint)0 == 0;
			object obj21 = !flag15;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v4 (System.Int32)+8]");
			bool flag16 = (UnityEngine.Object)0 != null;
			bool flag17 = !flag16;
			object obj22 = !flag17;
			object obj23 = ~obj22;
			double num4 = ((obj23 != null) ? 0.0 : 2.0);
			if ((double)num3 < num4)
			{
				return;
			}
			bool flag18 = built == 0;
			object obj24 = !flag18;
			int num5 = 0;
			List<GillaSplashLayout.Spot> list2 = null;
			if (obj24 == null)
			{
				built = -1;
				GillaSplashLayout.Hall[] halls = Halls;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F90]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				System.Random random = default;
				random._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
				object obj26 = 0;
				object obj27 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v59+E4]");
				bool flag19 = (nint)0 == 0;
				object obj28 = !flag19;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				List<GillaSplashLayout.Spot> list3 = GillaSplashLayout.Make(halls, 0, 1, random);
				Put(list3);
				obj13 = (UnityEngine.Object)(object)random;
				num5 = 1;
				list2 = list3;
			}
			GillaSplashPool[] array = pools;
			if (pools != null)
			{
				if (array.Length < 1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5370]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79F8]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4940]");
				object obj31 = 0;
				object obj32 = array.Length & 0xFFFFFFFFL;
				object obj33 = pools + 32;
				object obj34 = 0;
				double num6 = default;
				UnityEngine.Object obj45 = default;
				GillaSplashMonster gillaSplashMonster = default;
				object obj50 = default;
				while (true)
				{
					bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
					object obj35 = !flag20;
					if (obj35 != null)
					{
						break;
					}
					object obj36 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X28_v3+v516 @ X24_v4*8]");
					UnityEngine.Object obj37 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v31+E4]");
					bool flag21 = (nint)0 == 0;
					object obj38 = !flag21;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X28_v3+v516 @ X24_v4*8]");
					bool flag22 = (UnityEngine.Object)0 == null;
					bool flag23 = !flag22;
					object obj39 = !flag23;
					num6 = num6;
					num5 = 0;
					list2 = null;
					if (obj39 != null)
					{
						goto IL_0b25;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X28_v3+v516 @ X24_v4*8]");
					if ((nint)0 != 0)
					{
						object obj40 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X20_v10 (UnityEngine.Object)+38]");
						obj13 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X0_v36+E4]");
						bool flag24 = (nint)0 == 0;
						object obj41 = !flag24;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag25 = obj13 == null;
						bool flag26 = !flag25;
						object obj42 = !flag26;
						num6 = num6;
						num5 = 0;
						list2 = null;
						if (obj42 != null)
						{
							goto IL_0b25;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X20_v10 (UnityEngine.Object)+38]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X20_v10 (UnityEngine.Object)+38]");
							Vector3 position = ((Transform)0).position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X20_v10 (UnityEngine.Object)+38]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X20_v10 (UnityEngine.Object)+38]");
								Quaternion rotation = ((Transform)0).rotation;
								object obj43 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v44+E4]");
								bool flag27 = (nint)0 == 0;
								object obj44 = !flag27;
								if (obj44 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
								if ((object)obj45 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
									if ((object)gillaSplashMonster != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X20_v10 (UnityEngine.Object)+20]");
										gillaSplashMonster.PoolIndex = 0;
										List<System.__Canon> list4 = (List<System.__Canon>)(object)local;
										if ((object)local != null)
										{
											System.__Canon[] items = list4._items;
											num = (int)obj31;
											int version = list4._version + 1;
											list4._version = version;
											if (list4._items != null)
											{
												bool flag28 = list4._size < items.Length;
												object obj46 = !flag28;
												if (obj46 == null)
												{
													object obj47 = list4._items + list4._size;
													num = list4._size + 1;
													list4._size = num;
													object obj48 = obj47 + 32;
													obj48 = obj45;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													double num7 = num6;
													object obj49 = obj50;
													double num8 = 2.0;
													num6 = num4;
													obj13 = obj45;
													num5 = 0;
													list2 = (List<GillaSplashLayout.Spot>)(object)obj45;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v4 (System.Int32)+20]");
													object obj51 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v27+A8]");
													object obj52 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v28+70]");
													num5 = 0;
													((List<System.__Canon>)(object)local).AddWithResize((System.__Canon)(object)obj45);
													double num7 = num6;
													object obj49 = obj50;
													double num8 = 2.0;
													num6 = num4;
													obj13 = obj45;
													list2 = (List<GillaSplashLayout.Spot>)(object)obj45;
												}
												goto IL_0b25;
											}
										}
									}
								}
							}
						}
					}
					goto IL_0b5c;
					IL_0b25:
					obj32 = array.Length;
					obj34++;
					if ((nint)obj34 >= array.Length)
					{
						return;
					}
				}
				goto IL_0b6a;
			}
		}
		goto IL_0b5c;
		IL_0b6a:
		throw new IndexOutOfRangeException();
	}

	private unsafe void ClearLocal()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got I4
		//IL_03b0: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got Ref
		//IL_0105: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDC8F]");
		List<GameObject> list = (List<GameObject>)0;
		bool flag = (object)local == null;
		UnityEngine.Object obj = default;
		List<GameObject> list2 = (List<GameObject>)obj;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
			object obj4 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)local).GetEnumerator();
			UnityEngine.Object obj5 = obj;
			while (val.MoveNext())
			{
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v29+E4]");
				obj5 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v29+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = obj != null;
				bool flag4 = !flag3;
				object obj8 = 0;
				if (!flag4)
				{
					object obj9 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v33+E4]");
					obj5 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v33+E4]");
					bool flag5 = (nint)0 == 0;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj);
					obj8 = 0;
				}
			}
			list2 = null;
			Enumerator<, > val2 = default;
			val = val2;
			object obj11 = 0;
			Enumerator<, > val3 = (Enumerator<, >)(ref val);
			list = (List<GameObject>)obj5;
			object obj12 = 0;
			object obj15 = default;
			while (true)
			{
				val.Dispose();
				bool flag6 = obj12 == null;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					bool flag7 = (object)list2 == null;
					object obj14 = !flag7;
					OutOfMemoryException ex = (OutOfMemoryException)(&val);
					list = list2;
					if (obj14 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj4 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					list2 = (List<GameObject>)1;
					list = (List<GameObject>)1;
					obj12 = obj11;
					continue;
				}
				if ((nint)obj4 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj12 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj11 = obj15;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			list = local;
			if ((object)local != null)
			{
				int version = list._version + 1;
				list._size = 0;
				list._version = version;
				if (list._size >= 1)
				{
					Array.Clear(list._items, 0, list._size);
				}
				return;
			}
		}
		throw new NullReferenceException();
	}

	private void MakeMissing(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_09f7: Expected Obj, but got I4
		//IL_0a15: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected Obj, but got I4
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got I4
		//IL_0120: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityEngine.Object obj4 = (UnityEngine.Object)obj2;
		HashSet<int> hashSet = default;
		hashSet._002Ector();
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v5+A0]");
		object obj7 = 0;
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A90]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C20]");
			GillaSplashGame._003C_003Ec__DisplayClass69_0 obj9 = (GillaSplashGame._003C_003Ec__DisplayClass69_0)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A88]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5358]");
			object obj11 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)obj7).GetEnumerator();
			Enumerator<, > val = default;
			GillaSplashMonster gillaSplashMonster = default;
			Enumerator<, > val3 = default;
			Enumerator<, > val2;
			while (true)
			{
				obj4 = (UnityEngine.Object)obj8;
				if (val.MoveNext())
				{
					if ((object)gillaSplashMonster != null)
					{
						if (gillaSplashMonster.Live)
						{
							int poolIndex = gillaSplashMonster.PoolIndex;
							bool flag2 = hashSet == null;
							obj4 = (UnityEngine.Object)poolIndex;
							if (flag2)
							{
								break;
							}
							nint num = (nint)obj9;
							bool flag3 = hashSet.Add(poolIndex);
						}
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					break;
				}
				obj4 = (UnityEngine.Object)obj10;
				val.Dispose();
				val2 = val3;
				OutOfMemoryException ex2 = new OutOfMemoryException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj12 = obj9;
				object obj13 = 101789696 + 1224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			NullReferenceException ex3 = new NullReferenceException();
			val2 = val3;
		}
		NullReferenceException ex4 = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private unsafe static GillaSplashMonster MonsterIn(int index)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got I4
		//IL_04b2: Expected Obj, but got I
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got I
		//IL_04dc: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Ref, but got Unknown
		//IL_0451: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I4
		//IL_035c: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AA8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+A0]");
		UnityEngine.Object obj4 = (UnityEngine.Object)0;
		bool flag2 = (object)obj4 == null;
		Enumerator<, > val = (Enumerator<, >)0;
		IntPtr intPtr = default;
		UnityEngine.Object obj5 = (UnityEngine.Object)(nint)intPtr;
		object obj6 = 109891584;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A90]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A88]");
			obj6 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)obj4).GetEnumerator();
			UnityEngine.Object obj9 = null;
			Enumerator<, > val2 = default;
			GillaSplashMonster result3 = default;
			object obj23 = default;
			UnityEngine.Object result;
			object obj14;
			object obj15;
			UnityEngine.Object obj12 = default;
			Enumerator<, > val3;
			Enumerator<, > val4;
			while (true)
			{
				UnityEngine.Object obj16;
				object obj17;
				object obj18;
				UnityEngine.Object result2;
				if (val.MoveNext())
				{
					object obj10 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v34+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj12 == null;
					bool flag5 = !flag4;
					object obj13 = !flag5;
					obj14 = 0;
					if (obj13 != null)
					{
						continue;
					}
					if ((object)obj12 == null)
					{
						break;
					}
					int poolIndex = ((GillaSplashMonster)obj12).PoolIndex;
					bool flag6 = poolIndex != index;
					obj14 = 0;
					if (flag6)
					{
						continue;
					}
					bool live = ((GillaSplashMonster)obj12).Live;
					bool flag7 = !live;
					obj14 = 0;
					obj9 = obj12;
					if (flag7)
					{
						continue;
					}
					result = obj12;
					obj14 = 0;
					obj15 = 0;
					val = val2;
					obj16 = null;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					obj17 = 1;
					obj18 = 0;
					result2 = obj12;
					goto IL_0426;
				}
				result = obj9;
				obj15 = 0;
				val = val2;
				obj16 = null;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				obj18 = 0;
				goto IL_046c;
				IL_0426:
				obj5 = (UnityEngine.Object)obj6;
				((Enumerator<, >*)val4)->Dispose();
				bool flag8 = obj18 == null;
				object obj19 = !flag8;
				obj12 = obj16;
				if (obj19 == null)
				{
					bool flag9 = (object)obj16 == null;
					object obj20 = !flag9;
					obj12 = obj16;
					OutOfMemoryException ex = (OutOfMemoryException)val4;
					if (obj20 == null)
					{
						bool flag10 = obj17 == null;
						object obj21 = !flag10;
						object obj22 = ~obj21;
						if (obj22 == null)
						{
							return (GillaSplashMonster)result2;
						}
						return (GillaSplashMonster)result;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj5 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj16 = (UnityEngine.Object)1;
					obj4 = (UnityEngine.Object)1;
					obj18 = obj15;
				}
				else
				{
					if ((nint)obj5 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E314");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj18 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj15 = obj23;
					obj16 = obj12;
				}
				goto IL_046c;
				IL_046c:
				obj17 = 0;
				result2 = null;
				goto IL_0426;
			}
			NullReferenceException ex2 = new NullReferenceException();
			result = obj9;
			obj14 = 0;
			obj15 = 0;
			val = val2;
			obj12 = null;
			val3 = val2;
			val4 = (Enumerator<, >)(ref val);
			obj5 = null;
		}
		throw new NullReferenceException();
	}

	private unsafe void You(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_17af: Expected Obj, but got I4
		//IL_17d5: Expected Obj, but got I
		//IL_17f7: Expected Obj, but got I4
		//IL_1c83: Expected Obj, but got I
		//IL_1cad: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I
		//IL_02cd: Expected VT, but got I4
		//IL_02e2: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I
		//IL_0484: Expected Obj, but got I4
		//IL_049a: Expected Obj, but got I
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected Obj, but got Unknown
		//IL_0557: Expected Obj, but got I4
		//IL_0560: Expected Obj, but got I4
		//IL_0569: Expected Obj, but got I4
		//IL_0572: Expected Obj, but got I4
		//IL_057b: Expected Obj, but got I4
		//IL_0584: Expected Obj, but got I4
		//IL_058d: Expected VT, but got I4
		//IL_0596: Expected Obj, but got I4
		//IL_19a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a8: Expected Obj, but got Unknown
		//IL_19c9: Expected Obj, but got I4
		//IL_05b8: Expected F4, but got I
		//IL_05c1: Invalid comparison between F4 and I4
		//IL_06bb: Expected Obj, but got I
		//IL_06d3: Expected Obj, but got I
		//IL_06db: Expected F4, but got Obj
		//IL_06eb: Expected F4, but got I
		//IL_06fb: Expected F4, but got I
		//IL_0703: Expected F4, but got Obj
		//IL_0602: Expected Obj, but got I4
		//IL_1820: Expected Obj, but got I4
		//IL_0691: Expected F4, but got I
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_07bb: Expected Obj, but got I4
		//IL_1867: Expected Obj, but got I4
		//IL_07d9: Expected Obj, but got I
		//IL_0803: Expected Obj, but got I4
		//IL_187f: Expected VT, but got I4
		//IL_082b: Expected F4, but got I
		//IL_0a66: Expected Obj, but got I4
		//IL_08ad: Expected F8, but got I
		//IL_0a8b: Expected VT, but got I4
		//IL_18ba: Expected F4, but got I
		//IL_18ba: Expected VT, but got I4
		//IL_18ed: Expected F4, but got I
		//IL_0898: Expected F8, but got I4
		//IL_1a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a66: Expected Obj, but got Unknown
		//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a74: Expected Obj, but got Unknown
		//IL_1a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a82: Expected Obj, but got Unknown
		//IL_08dc: Expected Obj, but got I4
		//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e33: Expected Obj, but got Unknown
		//IL_0e4d: Expected Obj, but got I4
		//IL_1727: Unknown result type (might be due to invalid IL or missing references)
		//IL_172c: Expected Obj, but got Unknown
		//IL_173d: Expected Obj, but got I
		//IL_174e: Expected I4, but got Obj
		//IL_0e6b: Expected Obj, but got I
		//IL_0e7b: Expected F4, but got I
		//IL_0ea5: Expected Obj, but got I4
		//IL_0916: Expected Obj, but got I4
		//IL_192d: Expected VT, but got I4
		//IL_1aba: Expected Obj, but got I
		//IL_1ae4: Expected Obj, but got I4
		//IL_0b05: Expected Obj, but got I4
		//IL_0f03: Expected F4, but got VT
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected Obj, but got Unknown
		//IL_0943: Expected Obj, but got I4
		//IL_0961: Expected VT, but got I4
		//IL_1afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b00: Expected Obj, but got Unknown
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected Obj, but got Unknown
		//IL_0b41: Expected Obj, but got I4
		//IL_0b4a: Expected I4, but got Obj
		//IL_109d: Expected Obj, but got I
		//IL_10c7: Expected Obj, but got I4
		//IL_0f37: Invalid comparison between VT and F8
		//IL_0b6e: Expected Obj, but got I4
		//IL_098c: Invalid comparison between F8 and I4
		//IL_099b: Expected F8, but got I4
		//IL_10fd: Expected Obj, but got I
		//IL_1105: Expected I, but got Obj
		//IL_1127: Expected Obj, but got I4
		//IL_0fe9: Invalid comparison between F8 and I4
		//IL_0ff8: Expected F8, but got I4
		//IL_1a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a18: Expected Obj, but got Unknown
		//IL_1a32: Expected Obj, but got I4
		//IL_1a4a: Expected F4, but got I
		//IL_1944: Invalid comparison between F8 and I4
		//IL_1bbc: Expected Obj, but got I
		//IL_1bde: Expected Obj, but got I4
		//IL_1b37: Expected VT, but got I4
		//IL_1b41: Expected VT, but got F4
		//IL_1b9a: Expected VT, but got I4
		//IL_0f9e: Expected F4, but got VT
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cab: Expected Obj, but got Unknown
		//IL_0ceb: Expected Obj, but got I4
		//IL_0a9e: Expected F8, but got I4
		//IL_114f: Expected I, but got Obj
		//IL_1016: Invalid comparison between F8 and I
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Expected Obj, but got Unknown
		//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Expected Obj, but got Unknown
		//IL_09f0: Expected F8, but got I4
		//IL_117e: Expected Obj, but got I4
		//IL_0de3: Expected F4, but got I
		//IL_0df3: Expected F4, but got I
		//IL_0dfc: Expected Obj, but got I4
		//IL_0e05: Expected VT, but got I4
		//IL_0b92: Expected Obj, but got I
		//IL_0bbc: Expected Obj, but got I4
		//IL_1cdd: Expected F4, but got I
		//IL_1cdd: Expected VT, but got I4
		//IL_1cdd: Expected Obj, but got I4
		//IL_1d08: Expected VT, but got Obj
		//IL_11c3: Expected Obj, but got I4
		//IL_11cc: Expected Obj, but got I4
		//IL_11d5: Expected VT, but got I4
		//IL_1045: Expected F8, but got I
		//IL_0d67: Expected Obj, but got I4
		//IL_0bf4: Expected Obj, but got I4
		//IL_127e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1283: Expected Obj, but got Unknown
		//IL_1293: Expected F4, but got I
		//IL_129c: Expected Obj, but got I4
		//IL_1208: Expected Obj, but got I4
		//IL_1211: Expected VT, but got I4
		//IL_0d97: Expected Obj, but got I4
		//IL_0da0: Expected VT, but got I4
		//IL_0c0f: Expected VT, but got Obj
		//IL_0c70: Expected F4, but got I
		//IL_0c90: Expected F4, but got I
		//IL_12c4: Expected Obj, but got I4
		//IL_125f: Expected Obj, but got I4
		//IL_16eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f0: Expected Obj, but got Unknown
		//IL_16f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fe: Expected Obj, but got Unknown
		//IL_1325: Expected Obj, but got I4
		//IL_1343: Expected Obj, but got I
		//IL_1353: Expected F4, but got I
		//IL_1363: Expected F4, but got I
		//IL_138d: Expected Obj, but got I4
		//IL_13b4: Expected VT, but got I4
		//IL_13e2: Expected Obj, but got I4
		//IL_1c16: Expected Obj, but got I4
		//IL_14dc: Expected Obj, but got I4
		//IL_14e4: Expected F4, but got Obj
		//IL_14fc: Expected F4, but got Obj
		//IL_1505: Expected Obj, but got I4
		//IL_150e: Expected VT, but got I4
		//IL_143f: Expected Obj, but got I
		//IL_1469: Expected Obj, but got I4
		//IL_1540: Expected F4, but got Obj
		//IL_1558: Expected F4, but got Obj
		//IL_1561: Expected Obj, but got I4
		//IL_156a: Expected VT, but got I4
		//IL_15a6: Expected Obj, but got I4
		//IL_15c4: Expected Obj, but got I
		//IL_15d4: Expected F4, but got I
		//IL_15dc: Expected F4, but got Obj
		//IL_1606: Expected Obj, but got I4
		//IL_1c2c: Expected I4, but got Obj
		//IL_1c4e: Expected Obj, but got I4
		//IL_1692: Expected F4, but got I
		//IL_16ac: Invalid comparison between F4 and I
		//IL_16ba: Expected F4, but got Obj
		//IL_16c2: Expected F4, but got Obj
		//IL_16cb: Expected Obj, but got I4
		//IL_16d4: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v6+A0]");
		object obj8 = 0;
		UnityEngine.Object obj9 = (UnityEngine.Object)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 == null;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			return;
		}
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+20]");
		bool flag7 = (UnityEngine.Object)0 == null;
		bool flag8 = !flag7;
		object obj14 = !flag8;
		if (obj14 != null)
		{
			return;
		}
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+28]");
		if ((UnityEngine.Object)0 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj17 = 0;
		object obj18 = obj5;
		object obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v14+A0]");
		object obj20 = 0;
		UnityEngine.Object obj21 = (UnityEngine.Object)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v21+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24;
		if ((UnityEngine.Object)obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X21_v8 (UnityEngine.Object)+A9]");
			bool flag11 = (nint)0 == 0;
			object obj23 = !flag11;
			obj24 = obj23;
		}
		else
		{
			obj24 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+20]");
		Transform transform = ((Component)0).transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+28]");
		Transform transform2 = ((Component)0).transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+28]");
		Vector3 center = ((CapsuleCollider)0).center;
		Vector3 vector = transform2.TransformPoint((Vector3)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+28]");
		Transform transform3 = ((Component)0).transform;
		Vector3 up = transform3.up;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+28]");
		float height = ((CapsuleCollider)0).height;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+28]");
		Transform transform4 = ((Component)0).transform;
		Vector3 lossyScale = transform4.lossyScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+30]");
		Vector3 position2 = ((Transform)0).position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+38]");
		Vector3 position3 = ((Transform)0).position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v46+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v46+18]");
			bool flag12 = (nint)0 == 1;
			float num = height * 0.5f;
			float num3 = default;
			float num2 = num * num3;
			float num4 = dt * num2;
			float num5 = num3 * num2;
			double num7 = default;
			float num6 = (float)num7 * num2;
			float num8 = dt - num4;
			float num9 = num3 - num5;
			float num10 = (float)num7 - num6;
			if (!flag12)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v46+18]");
				bool flag13 = (nint)0 < (nint)2;
				object obj26 = !flag13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v46+18]");
				object obj27 = -2;
				bool flag14 = obj27 == null;
				object obj28 = ~obj26;
				object obj29 = obj28 | flag14;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v46+18]");
					if ((nint)0 != 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						float num11 = num10;
						float num12 = num9;
						double num13 = num7;
						float num14 = num3;
						UnityEngine.Object obj30 = null;
						object obj31 = 0;
						object obj32 = 0;
						object obj33 = 0;
						object obj34 = 32;
						object obj35 = 0;
						object obj36 = 32;
						Vector3 vector2 = (Vector3)0;
						UnityEngine.Object obj37 = (UnityEngine.Object)4;
						object obj41 = default;
						float num24 = default;
						bool entering = default;
						object obj105 = default;
						object obj116 = default;
						while (true)
						{
							object obj38 = obj36 - 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v46+18]");
							bool flag15 = (nint)obj38 < 0;
							object obj39 = !flag15;
							if (obj39 != null)
							{
								break;
							}
							object obj40 = obj41 + obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+28]");
							float num15 = 0f;
							float num20;
							float num23;
							Vector3[] array2;
							float num21;
							if (dt > 0f)
							{
								Vector3[] array = lastAt;
								bool flag16 = (nint)obj38 < array.Length;
								object obj42 = !flag16;
								if (obj42 != null)
								{
									break;
								}
								object obj43 = (object)array + obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
								float num16 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X9_v36+20]");
								float num17 = num16 - 0f;
								float num18 = num17 / height;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+28]");
								float num19 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X9_v36+28]");
								num14 = num19 - 0f;
								num20 = num14 / dt;
								num21 = dt;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
								float num22 = 0f;
								num23 = num18;
								array2 = array;
							}
							else
							{
								array2 = lastAt;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj44 = 0;
								object obj45 = obj44;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X9_v32+A0]");
								object obj46 = 0;
								num21 = (float)obj46;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X9_v33+8]");
								num20 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
								float num22 = 0f;
								num23 = (float)obj46;
							}
							bool flag17 = (nint)obj38 < array2.Length;
							object obj47 = !flag17;
							if (obj47 != null)
							{
								break;
							}
							object obj48 = (object)array2 + obj33;
							object obj49 = obj36 - 32;
							if ((nint)obj49 != 2)
							{
								if ((nint)obj49 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+FB]");
									if ((nint)0 != 0)
									{
										goto IL_078f;
									}
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+FC]");
								bool flag18 = (nint)0 == 0;
								object obj50 = !flag18;
								if (obj50 != null)
								{
									goto IL_078f;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
							object obj51 = 0;
							object obj52 = obj51;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X0_v150+E4]");
							bool flag19 = (nint)0 == 0;
							object obj53 = !flag19;
							if (obj53 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
								float num22 = 0f;
							}
							GillaSplashPool gillaSplashPool = GillaSplashPool.At((Vector3)0);
							num14 = num15;
							num21 = num24;
							GillaSplashPool gillaSplashPool2 = gillaSplashPool;
							goto IL_183d;
							IL_1a58:
							obj33 += 12;
							obj36++;
							obj34 += 4;
							bool flag20 = (nint)obj33 != 48;
							GillaSplashPool gillaSplashPool3;
							obj30 = gillaSplashPool3;
							if (flag20)
							{
								continue;
							}
							object obj54 = ~obj35;
							object obj55 = obj24 | obj54;
							object obj56 = obj55 & 1;
							bool flag21 = obj56 == null;
							object obj57 = !flag21;
							if (obj57 != null)
							{
								goto IL_171e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
							object obj58 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashDirector)+B0]");
							float num25 = 0f;
							object obj59 = obj58;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X0_v61+E4]");
							bool flag22 = (nint)0 == 0;
							object obj60 = !flag22;
							if (obj60 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj61 = 0;
							object obj62 = obj61;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X0_v64+E4]");
							bool flag23 = (nint)0 == 0;
							object obj63 = !flag23;
							if (obj63 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float time = Time.time;
							float num26 = nextNoise;
							bool flag24 = time < nextNoise;
							float num27 = (float)lastNoise;
							GillaSplashPool gillaSplashPool4 = (GillaSplashPool)obj37;
							GillaSplashDirector gillaSplashDirector = null;
							if (!flag24)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								bool flag25 = lastNoise > (object)0.25;
								GillaSplashDirector gillaSplashDirector2 = null;
								if (!flag25)
								{
									time = Time.time;
									num14 = nextNoise;
									double num28 = (double)nextNoise + 0.75;
									bool flag26 = (double)time < num28;
									gillaSplashDirector2 = null;
									num26 = (float)num28;
									num27 = (float)lastNoise;
									gillaSplashPool4 = (GillaSplashPool)obj37;
									gillaSplashDirector = null;
									if (flag26)
									{
										goto IL_1af2;
									}
								}
								double num29 = (double)noiseEvery * 5.0;
								double num30 = (double)lastNoise / num29;
								bool flag27 = num30 < 0.0;
								num13 = 0.0;
								if (!flag27)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
									bool flag28 = !(num30 > 0.0);
									num13 = num30;
									if (!flag28)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
										num13 = 0.0;
									}
								}
								gillaSplashDirector2.Heard(gillaSplashPool3, (Vector3)0, num8, entering);
								lastNoise = (Vector3)num8;
								float time2 = Time.time;
								num26 = noiseEvery;
								time = time2 + noiseEvery;
								nextNoise = time;
								num14 = num11;
								num27 = num11;
								num25 = num12;
								vector2 = (Vector3)0;
								gillaSplashPool4 = gillaSplashPool3;
								gillaSplashDirector = null;
							}
							goto IL_1af2;
							IL_171e:
							object obj64 = obj24 ^ 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v3 (UnityEngine.Object)+20]");
							Transform head = ((Component)0).transform;
							bool under = (byte)(obj31 & obj64) != 0;
							Underwater(under, head);
							return;
							IL_1af2:
							object obj65 = obj32 & 1;
							if (obj65 != null)
							{
								float num31 = drag * dt;
								time = 0f - num31;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
								((Player)obj8).Slow(time);
								num26 = dt;
								gillaSplashPool4 = null;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
							object obj66 = 0;
							object obj67 = obj66;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1441 @ X0_v69+E4]");
							bool flag29 = (nint)0 == 0;
							object obj68 = !flag29;
							if (obj68 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GillaSplashGame current = GillaSplashGame.Current;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
							GillaSplashPool gillaSplashPool5 = (GillaSplashPool)0;
							nint num32 = (nint)gillaSplashPool5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1567 @ X8_v47 (Il2CppClass<GillaSplashPool>)+E4]");
							bool flag30 = (nint)0 == 0;
							object obj69 = !flag30;
							nint num33 = num32;
							if (obj69 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								num33 = (nint)gillaSplashPool5;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1583 @ X8_v48 (Il2CppClass<GillaSplashPool>)+A0]");
							object obj70 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1585 @ X8_v49+9]");
							bool flag31 = (nint)0 == 0;
							object obj71 = !flag31;
							if (obj71 == null)
							{
								object obj72 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X0_v74+E4]");
								bool flag32 = (nint)0 == 0;
								object obj73 = !flag32;
								if (obj73 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag33 = (UnityEngine.Object)current == (UnityEngine.Object)null;
								bool flag34 = !flag33;
								object obj74 = !flag34;
								object obj75 = 0;
								PlayerRef playerRef = (PlayerRef)0;
								if (obj74 == null)
								{
									flag33 = current.Live;
									bool flag35 = !flag33;
									obj75 = 0;
									playerRef = (PlayerRef)0;
									if (!flag35)
									{
										PlayerRef localPlayer = ((SimulationBehaviour)current)._runner.LocalPlayer;
										flag33 = current.InRace(localPlayer);
										bool flag36 = !flag33;
										obj75 = 0;
										playerRef = localPlayer;
										if (flag36)
										{
											goto IL_171e;
										}
									}
								}
								object obj76 = obj41 + 40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
								float num34 = 0f;
								object obj77 = 0;
								GillaSplashGame gillaSplashGame = current;
								while (true)
								{
									bool[] array3 = wasIn;
									bool flag37 = (nint)obj77 < array3.Length;
									object obj78 = !flag37;
									if (obj78 != null)
									{
										break;
									}
									object obj79 = (object)array3 + obj77;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1619 @ X8_v54+20]");
									if ((nint)0 != 0)
									{
										object obj80 = obj77;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v46+18]");
										bool flag38 = (nint)obj80 < 0;
										object obj81 = !flag38;
										if (obj81 != null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
										object obj82 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X28_v10-8]");
										num27 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X28_v10-4]");
										num25 = 0f;
										object obj83 = obj82;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1640 @ X0_v81+E4]");
										bool flag39 = (nint)0 == 0;
										object obj84 = !flag39;
										if (obj84 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										GillaSplashPool gillaSplashPool6 = GillaSplashPool.At((Vector3)0);
										object obj85 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v61+E4]");
										bool flag40 = (nint)0 == 0;
										object obj86 = !flag40;
										if (obj86 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag41 = gillaSplashPool6 != null;
										bool flag42 = !flag41;
										gillaSplashGame = null;
										if (!flag42)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
											object obj87 = 0;
											object obj88 = obj87;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1670 @ X0_v108+E4]");
											bool flag43 = (nint)0 == 0;
											object obj89 = !flag43;
											if (obj89 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											GillaSplashMonster gillaSplashMonster = MonsterIn(gillaSplashPool6.index);
											gillaSplashGame = (GillaSplashGame)(object)gillaSplashMonster;
										}
										object obj90 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1664 @ X0_v89+E4]");
										bool flag44 = (nint)0 == 0;
										object obj91 = !flag44;
										if (obj91 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										flag33 = (UnityEngine.Object)gillaSplashGame == (UnityEngine.Object)null;
										bool flag45 = !flag33;
										object obj92 = !flag45;
										num14 = (float)obj76;
										num26 = num25;
										time = num27;
										num34 = (float)obj76;
										obj75 = 0;
										playerRef = (PlayerRef)0;
										if (obj92 == null)
										{
											flag33 = ((GillaSplashMonster)(object)gillaSplashGame).Hunting;
											bool flag46 = !flag33;
											num14 = (float)obj76;
											num26 = num25;
											time = num27;
											num34 = (float)obj76;
											obj75 = 0;
											playerRef = (PlayerRef)0;
											if (!flag46)
											{
												Vector3 mouth = ((GillaSplashMonster)(object)gillaSplashGame).Mouth;
												object obj93 = obj77;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v46+18]");
												bool flag47 = (nint)obj93 < 0;
												object obj94 = !flag47;
												if (obj94 != null)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
												object obj95 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X28_v10-8]");
												num34 = 0f;
												num15 = (float)obj76;
												object obj96 = obj95;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1686 @ X0_v97+E4]");
												bool flag48 = (nint)0 == 0;
												object obj97 = !flag48;
												if (obj97 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												flag33 = (byte)(int)obj61 != 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X0_v80 (System.Boolean)+E4]");
												bool flag49 = (nint)0 == 0;
												object obj98 = !flag49;
												if (obj98 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												float num35 = num27 - num34;
												float num36 = (float)obj76 - num15;
												float num37 = num35 * num35;
												float num38 = num36 * num36;
												time = num37 + num38;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ X22_v12 (GillaSplashGame)+94]");
												num26 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
												float num39 = time;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ X22_v12 (GillaSplashGame)+94]");
												bool flag50 = num39 < 0f;
												num14 = (float)obj76;
												num25 = (float)obj76;
												obj75 = 0;
												playerRef = (PlayerRef)0;
												if (flag50)
												{
													((GillaSplashMonster)(object)gillaSplashGame).Catch();
													goto IL_171e;
												}
											}
										}
									}
									obj77++;
									obj76 += 12;
									if ((nint)obj77 != 4)
									{
										continue;
									}
									goto IL_171e;
								}
								break;
							}
							goto IL_171e;
							IL_183d:
							object obj99 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v52+E4]");
							bool flag51 = (nint)0 == 0;
							object obj100 = !flag51;
							if (obj100 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag52 = gillaSplashPool2 != null;
							bool flag53 = !flag52;
							obj37 = null;
							if (!flag53)
							{
								if ((nint)obj33 == 36)
								{
									num13 = 0.0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
									num13 = 0.0;
								}
								GillaSplashPool gillaSplashPool7 = gillaSplashPool2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
								bool flag54 = gillaSplashPool7.In((Vector3)0, 0f);
								bool flag55 = !flag54;
								num14 = num15;
								num21 = num24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
								float num22 = 0f;
								obj37 = null;
								if (!flag55)
								{
									bool[] array4 = wasIn;
									bool flag56 = (nint)obj38 < array4.Length;
									object obj101 = !flag56;
									if (obj101 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v77 (System.Boolean[])+v534 @ X22_v6]");
									object obj102 = (((nint)0 != 0) ? ((object)1) : obj24);
									bool flag57 = (nint)obj33 == 36;
									num14 = num15;
									num21 = num24;
									ref float next = ref *(float*)null;
									Vector3 vector3 = (Vector3)0;
									if (!flag57)
									{
										object obj103 = obj102 & 1;
										bool flag58 = obj103 == null;
										object obj104 = !flag58;
										num14 = num15;
										num21 = num24;
										next = ref *(float*)null;
										vector3 = (Vector3)0;
										if (obj104 == null)
										{
											double num40 = -0.25 * (double)obj105;
											bool flag59 = num40 < 0.0;
											double num41 = 0.0;
											if (!flag59)
											{
												bool flag60 = !(num40 > 1.0);
												num41 = num40;
												if (!flag60)
												{
													num41 = 1.0;
												}
											}
											bool flag61 = num41 < 0.0;
											if (obj33 != null)
											{
												double num42 = 0.0;
												if (!flag61)
												{
													bool flag62 = !(num41 > 1.0);
													num42 = num41;
													if (!flag62)
													{
														num42 = 1.0;
													}
												}
												double num43 = num42;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB2C]");
												double num44 = num43 * 0.0;
												double num45 = num44;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B000]");
												num13 = num45 + 0.0;
											}
											else
											{
												double num46 = 0.0;
												if (!flag61)
												{
													bool flag63 = !(num41 > 1.0);
													num46 = num41;
													if (!flag63)
													{
														num46 = 1.0;
													}
												}
												double num47 = num46;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
												double num48 = num47 * 0.0;
												double num49 = num48;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
												num13 = num49 + 0.0;
											}
											bool flag64 = flag54;
											GillaSplashPool pool = gillaSplashPool2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
											((GillaSplashDirector)flag64).Heard(pool, (Vector3)1, 0f, entering);
											array4 = wasIn;
											num14 = num15;
											num21 = num24;
											next = ref *(float*)1;
											vector3 = (Vector3)gillaSplashPool2;
										}
									}
									bool flag65 = (nint)obj38 < array4.Length;
									object obj106 = !flag65;
									if (obj106 != null)
									{
										break;
									}
									object obj107 = obj33 - 36;
									bool flag66 = obj107 == null;
									_ = 1;
									object obj108 = !flag66;
									object obj109 = (((int)(~obj108) != 0) ? ((object)1) : obj24);
									object obj110 = obj109 & 1;
									bool flag67 = obj110 == null;
									object obj111 = !flag67;
									float num50 = (float)num13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
									num22 = 0f;
									if (obj111 == null)
									{
										float[] array5 = nextWake;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
										object obj112 = 0;
										object obj113 = obj112;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1574 @ X0_v145+E4]");
										bool flag68 = (nint)0 == 0;
										object obj114 = !flag68;
										if (obj114 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag69 = (nint)obj38 < array5.Length;
										object obj115 = !flag69;
										if (obj115 != null)
										{
											break;
										}
										Vector3 at = (Vector3)((object)array5 + obj34);
										float num51 = num23 * (float)obj116;
										float num52 = num20 * dt;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
										num50 = 0f - num51;
										float num53 = num15 - num52;
										Vector3 was = vector3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
										Wake(at, was, 0f, ref next);
										num14 = num15;
										num21 = num24;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
										num22 = 0f;
									}
									object obj117 = obj5;
									object obj118 = obj33 - 36;
									bool flag70 = obj118 == null;
									bool flag71 = obj33 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1550 @ X0_v140+E4]");
									bool flag72 = (nint)0 == 0;
									object obj119 = !flag72;
									if (obj119 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									obj32 = flag71 | obj32;
									object obj120 = flag70 | obj31;
									bool flag73 = obj30 == null;
									if (obj33 != null)
									{
										bool flag74 = !flag73;
										object obj121 = !flag74;
										if (obj121 == null)
										{
											num13 = num50;
											gillaSplashPool3 = (GillaSplashPool)obj30;
											obj31 = obj120;
											obj35 = 1;
											vector2 = (Vector3)0;
											obj37 = null;
											goto IL_1a58;
										}
									}
									num11 = num15;
									num12 = num24;
									num13 = num50;
									gillaSplashPool3 = gillaSplashPool2;
									obj31 = obj120;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
									num22 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v27+20]");
									num8 = 0f;
									obj35 = 1;
									vector2 = (Vector3)0;
									obj37 = null;
									goto IL_1a58;
								}
							}
							bool[] array6 = wasIn;
							bool flag75 = (nint)obj38 < array6.Length;
							object obj122 = !flag75;
							if (obj122 != null)
							{
								break;
							}
							_ = 0;
							gillaSplashPool3 = (GillaSplashPool)obj30;
							vector2 = (Vector3)0;
							goto IL_1a58;
							IL_078f:
							gillaSplashPool2 = null;
							goto IL_183d;
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Heard(GillaSplashPool pool, Vector3 at, float strength, bool entering)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected VT, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashMonster gillaSplashMonster = MonsterIn(pool.index);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)gillaSplashMonster != (UnityEngine.Object)null)
		{
			Vector3 at2 = (Vector3)(at & 1);
			gillaSplashMonster.Splash(at2, strength, loud: false);
			return;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 at3 = (Vector3)(at & 1);
		Show(at3, strength, entering: false);
	}

	public static void Show(Vector3 at, float strength, bool entering)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0437: Expected Obj, but got I
		//IL_0459: Expected Obj, but got I4
		//IL_002e: Expected VT, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0477: Expected F4, but got I
		//IL_0487: Invalid comparison between F8 and I
		//IL_014a: Expected Obj, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0239: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I4
		//IL_0125: Expected VT, but got I4
		//IL_04c8: Expected Obj, but got I4
		//IL_01ea: Expected VT, but got I4
		//IL_058e: Expected Obj, but got I
		//IL_05b8: Expected Obj, but got I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_031f: Invalid comparison between F8 and I
		//IL_0346: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03a5: Expected Obj, but got I
		//IL_04df: Invalid comparison between F8 and I4
		//IL_04ee: Expected F8, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0516: Expected VT, but got I4
		//IL_0527: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashPool gillaSplashPool = GillaSplashPool.At((Vector3)0);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = gillaSplashPool != null;
		bool flag4 = !flag3;
		UnityEngine.Object obj7 = null;
		float num2 = default;
		float num = num2;
		if (!flag4)
		{
			float surface = gillaSplashPool.Surface;
			obj7 = null;
			num = surface;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num3 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		double num4 = default;
		float num5 = default;
		if (num4 > 0.0)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v41+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaSplashPool.Ripple((Vector3)0, num5);
			num2 = num;
			num3 = num5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
		object obj10 = 0;
		object obj11 = at & 1;
		bool flag6 = obj11 == null;
		double num6 = num4;
		float num8 = default;
		float num7 = num8;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AB0]");
			object obj12 = 0;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v37+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaVoxelSplash.Emit((Vector3)0, num5);
			num6 = num4;
			num7 = num8;
			num2 = num;
			num3 = num5;
		}
		object obj15 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v16+E4]");
		bool flag9 = (nint)0 == 0;
		object obj18 = !flag9;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj10;
		}
		object obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v16+A0]");
		object obj20 = 0;
		UnityEngine.Object obj21 = (UnityEngine.Object)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj20 == null)
		{
			return;
		}
		object obj23 = at & 1;
		float pitchMin;
		AudioClip[] clips;
		if (obj23 != null)
		{
			object obj24 = ((!(num4 < 0.5)) ? ((object)(obj20 + 96)) : ((object)(obj20 + 104)));
			bool flag11 = num4 < 0.0;
			double num9 = 0.0;
			if (!flag11)
			{
				bool flag12 = !(num4 > 1.0);
				num9 = num4;
				if (!flag12)
				{
					num9 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj25 = 0;
			double num10 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			double num11 = num10 * 0.0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v25+E4]");
			bool flag13 = (nint)0 == 0;
			object obj27 = !flag13;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			pitchMin = num;
			clips = (AudioClip[])obj24;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			if (!(num4 > 0.0))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v21+E4]");
			bool flag14 = (nint)0 == 0;
			object obj30 = !flag14;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			pitchMin = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X20_v5 (UnityEngine.Object)+70]");
			clips = (AudioClip[])0;
		}
		Sfx.Play(clips, (Vector3)0, num5, pitchMin, num8);
	}

	private void Underwater(bool under, Transform head)
	{
		//IL_0010: Expected Obj, but got I
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected Obj, but got Unknown
		//IL_090b: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I4
		//IL_0490: Expected VT, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_0649: Expected Obj, but got I4
		//IL_068c: Expected Obj, but got I4
		//IL_083e: Expected Obj, but got I4
		//IL_0943: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		//IL_06b7: Expected Obj, but got I4
		//IL_0597: Expected VT, but got I4
		//IL_04f7: Expected Obj, but got I
		//IL_0521: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I4
		//IL_0548: Expected VT, but got I4
		//IL_08a5: Expected F4, but got I
		//IL_08b0: Expected Obj, but got I4
		//IL_06f4: Expected Obj, but got I4
		//IL_05ba: Expected Obj, but got I
		//IL_05ca: Expected Obj, but got I
		//IL_05da: Expected F8, but got I
		//IL_05ea: Expected Obj, but got I
		//IL_0606: Expected VT, but got I4
		//IL_060f: Expected VT, but got I4
		//IL_0721: Expected Obj, but got I
		//IL_08d0: Expected F4, but got I4
		//IL_0756: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I
		//IL_01de: Expected VT, but got I4
		//IL_0779: Expected Obj, but got I
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected Obj, but got Unknown
		//IL_07b3: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_07eb: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I
		//IL_035a: Expected Obj, but got I
		//IL_0381: Expected Obj, but got I
		//IL_03b1: Expected Obj, but got I
		//IL_0415: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		object obj5 = 0;
		ShadowCastingMode shadowCastingMode = (ShadowCastingMode)0;
		if (!flag3)
		{
			bool flag4 = !under;
			obj5 = 0;
			shadowCastingMode = (ShadowCastingMode)0;
			if (!flag4)
			{
				GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B20]");
				object obj6 = 0;
				gameObject.name = (string)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7560]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v31+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object obj10 = default;
				UnityEngine.Object.Destroy(obj10);
				Transform transform = gameObject.transform;
				transform.SetParent(head, worldPositionStays: false);
				Transform transform2 = gameObject.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v36+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v37+C]");
				double num2 = default;
				double num = 0.0 * num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v37+14]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADDC]");
				object obj14 = num3 * 0;
				transform2.localScale = (Vector3)0;
				GameObject gameObject2 = head.gameObject;
				int layer = gameObject2.layer;
				gameObject.layer = layer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B40]");
				object obj15 = 0;
				Shader shader = Shader.Find((string)obj15);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Material material = default;
				material._002Ector(shader);
				object obj17 = this + 192;
				obj17 = material;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B48]");
				object obj18 = 0;
				((Material)obj17).SetFloat((string)obj18, 1f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B28]");
				object obj19 = 0;
				((Material)obj17).SetFloat((string)obj19, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B38]");
				object obj20 = 0;
				((Material)obj17).SetFloat((string)obj20, 8f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B30]");
				object obj21 = 0;
				((Material)obj17).SetInt((string)obj21, 5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B50]");
				object obj22 = 0;
				((Material)obj17).SetInt((string)obj22, 10);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B60]");
				object obj23 = 0;
				((Material)obj17).SetInt((string)obj23, 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B58]");
				object keyword = 0;
				((Material)obj17).EnableKeyword((string)keyword);
				((Material)obj17).renderQueue = 4990;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B18]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
				object obj25 = default;
				obj3 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				((Renderer)obj3).sharedMaterial = (Material)obj17;
				((Renderer)obj3).shadowCastingMode = (ShadowCastingMode)0;
				num2 = 8.0;
				object obj27 = default;
				object obj26 = obj27;
				obj5 = 0;
				shadowCastingMode = (ShadowCastingMode)0;
			}
		}
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj29 = !flag6;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = (UnityEngine.Object)obj3 != null;
		bool flag8 = !flag7;
		Color color = (Color)0;
		string text = null;
		if (!flag8)
		{
			((Renderer)obj3).enabled = under;
			bool flag9 = !under;
			bool flag10 = under;
			UnityEngine.Object obj30 = null;
			if (!flag9)
			{
				Vector3 position = head.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
				object obj31 = 0;
				object obj32 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X0_v49+E4]");
				bool flag11 = (nint)0 == 0;
				object obj33 = !flag11;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaSplashPool gillaSplashPool = GillaSplashPool.At((Vector3)0);
				flag10 = false;
				obj30 = gillaSplashPool;
			}
			object obj34 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X0_v41+E4]");
			bool flag12 = (nint)0 == 0;
			object obj35 = !flag12;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = obj30 != null;
			bool flag14 = !flag13;
			color = (Color)0;
			text = null;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X22_v9 (UnityEngine.Object)+70]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X22_v9 (UnityEngine.Object)+68]");
				double num2 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X22_v9 (UnityEngine.Object)+6C]");
				object obj26 = 0;
				text = (string)obj36;
				murkMat.SetColor((string)obj36, (Color)0);
				color = (Color)0;
			}
		}
		object obj37 = obj;
		UnityEngine.Object obj38 = (UnityEngine.Object)(this + 200);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v14+E4]");
		bool flag15 = (nint)0 == 0;
		object obj39 = !flag15;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag16 = obj38 == null;
		bool flag17 = !flag16;
		object obj40 = 0;
		UnityEngine.Object obj41 = null;
		if (!flag17)
		{
			bool flag18 = !under;
			obj40 = 0;
			obj41 = null;
			if (!flag18)
			{
				object obj42 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v25+E4]");
				bool flag19 = (nint)0 == 0;
				object obj43 = !flag19;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B0]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
				UnityEngine.Object obj45 = default;
				bool flag20 = obj45 != null;
				bool flag21 = !flag20;
				obj40 = 0;
				obj41 = null;
				if (!flag21)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B08]");
					object obj46 = 0;
					obj40 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
					object obj48 = default;
					object obj47 = obj48 & 1;
					bool flag22 = obj47 == null;
					object obj49 = !flag22;
					obj41 = obj38;
					if (obj49 == null)
					{
						GameObject gameObject3 = ((Component)obj45).gameObject;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B10]");
						object obj50 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
						UnityEngine.Object obj51 = default;
						obj38 = obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj41 = obj51;
					}
				}
			}
		}
		object obj52 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v19+E4]");
		bool flag23 = (nint)0 == 0;
		object obj53 = !flag23;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj38 != null)
		{
			bool flag24 = !under;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA20]");
			float cutoffFrequency = 0f;
			object obj54 = !flag24;
			object obj55 = ~obj54;
			if (obj55 == null)
			{
				cutoffFrequency = 1.1472077E+09f;
			}
			((AudioLowPassFilter)obj38).cutoffFrequency = cutoffFrequency;
		}
	}

	private static Vector3 Flat(Vector3 v)
	{
		return v;
	}

	public GillaSplashDirector()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_010d: Expected F4, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_02a3: Expected Obj, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02e9: Expected Obj, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0334: Expected Obj, but got I
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0370: Expected Obj, but got I
		//IL_037f: Expected I4, but got I8
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B68]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48C0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B70]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj9 = this + 32;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj11 = this + 40;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj13 = this + 48;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj15 = this + 56;
		object obj16 = default;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B9E0]");
		drag = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj17 = this + 120;
		obj17 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj18 = this + 136;
		object obj19 = default;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj20 = this + 144;
		object obj21 = default;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj22 = this + 152;
		object obj23 = default;
		obj22 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, (Vector3, float)> dictionary = default;
		dictionary._002Ector();
		object obj24 = this + 160;
		obj24 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj25 = this + 208;
		object obj26 = default;
		obj25 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj27 = this + 216;
		object obj28 = default;
		obj27 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector();
		object obj29 = this + 224;
		obj29 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list3 = default;
		list3._002Ector();
		object obj31 = this + 232;
		obj31 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B98]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list4 = default;
		list4._002Ector();
		object obj33 = this + 240;
		obj33 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj35 = this + 248;
		object obj36 = default;
		obj35 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B88]");
		object obj37 = 0;
		hallsOut = -2147483648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary2 = default;
		dictionary2._002Ector();
		object obj38 = this + 280;
		limbs = (Dictionary<GillaSplashMonster, Transform[]>)(object)dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, (Vector3, float)> dictionary3 = default;
		dictionary3._002Ector();
		object obj39 = this + 288;
		wading = (Dictionary<Transform, (Vector3, float)>)(object)dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaSplashDirector()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BA0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
	}
}
